using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using compCatalogosSAIC;
using System.Data.SqlClient;

namespace winAppSAIC.OperadoresM
{
    public partial class XtrasSolicitudSalariosEmpleado : DevExpress.XtraEditors.XtraForm
    {
        Boolean flagSolicitar;
        Empleado objEmpleado;
        int idSolicitud;
        DateTime dtFechaDeAplicacion;
        DateTime dtFechaMovimientoPasada;
        DateTime dtFechaMovimientoFutura;

        decimal dcSDNuevo;
        decimal dcParteVariable;
        String stObservaciones;

        decimal dcSalarioBaseDeContizacion = 0;
        variableIMSSEmpleado ovariableIMSSEmpleado;

        public XtrasSolicitudSalariosEmpleado(
            Boolean flagSolicitar
            , int idSolicitud
            , Empleado objEmpleado
            , decimal dcSDNuevo
            , decimal dcParteVariable
            , DateTime dtFechaDeAplicacion)
        {
            InitializeComponent();

            this.objEmpleado = objEmpleado;
            this.flagSolicitar = flagSolicitar;
            this.idSolicitud = idSolicitud;
            this.dtFechaDeAplicacion = dtFechaDeAplicacion;
            this.dcParteVariable = dcParteVariable;
            this.dcSDNuevo = dcSDNuevo;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void XtrasSolicitudSalariosEmpleado_Load(object sender, EventArgs e)
        {
            txtIdEmpleado.Text = objEmpleado.IdEmpleado.ToString();
            txtNombreEmpleado.Text = objEmpleado.APaternoEmpleado + " " + objEmpleado.AMaternoEmpleado + " " + objEmpleado.NombreEmpleado;

            //obtenerFechasParaMovimiento();

            String stFechaincial = stpSelEstatusNominaContabilizadaTableAdapter1.ObtenerFechaServidor().ToString();
            DateTime dFechaHoy = new DateTime();
            DateTime.TryParse(stFechaincial, out dFechaHoy);
            dtFecha.Text = dFechaHoy.ToShortDateString();

            if (flagSolicitar)
            {
                btnAceptar.Text = "Solicitar";
                spinEditSD.Value = 0;
                //spinEditParteVariable.Value = 0;
            }
            else
            {
                btnAceptar.Text = "Actualizar";
                spinEditSD.Value = dcSDNuevo;
                spinEditParteVariable.Value = dcParteVariable;
                dtFecha.DateTime = dtFechaDeAplicacion;
            }
        }

        private void spinEditSD_EditValueChanged(object sender, EventArgs e)
        {
            String sErrorSalarios = String.Empty;

            obtenerFechasDeAplicacion();
            sErrorSalarios = validarSalarios(objEmpleado.IdEmpleado, spinEditSD.Value, dtFecha.DateTime);
            if (!String.IsNullOrEmpty(sErrorSalarios))
            {
                lblError.Text = sErrorSalarios;
                btnAceptar.Enabled = false;
            }
            else
            {
                lblError.Text = String.Empty;
                btnAceptar.Enabled = true;
            }

            decimal dFactorDeIntegracion = 0;
            decimal.TryParse(txtFactorDeIntegracion.Text, out dFactorDeIntegracion);

            decimal dcUma = 0;
            decimal.TryParse(txtUMA.Text, out dcUma);

            spinEditSBC.Value = obtenerSBCSDI(spinEditSD.Value, dFactorDeIntegracion, dcUma, spinEditParteVariable.Value);
            dcSalarioBaseDeContizacion = spinEditSBC.Value;

            String sValidarFechasDeAplicacion = String.Empty;
            sValidarFechasDeAplicacion = validarFechaDeAplicacion(dtFecha.DateTime, dtFechaMovimientoPasada, dtFechaMovimientoFutura);

            if (String.IsNullOrEmpty(sValidarFechasDeAplicacion) && ovariableIMSSEmpleado.flagTaMuyBien)
            {
                btnAceptar.Enabled = true;
                lblError.Text = String.Empty;
            }
            else
            {
                btnAceptar.Enabled = false;
                lblError.Text = sValidarFechasDeAplicacion + ", " + ovariableIMSSEmpleado.sMensajeDeError;
            }

            if (String.IsNullOrEmpty(sErrorSalarios) && String.IsNullOrEmpty(sValidarFechasDeAplicacion) && ovariableIMSSEmpleado.flagTaMuyBien)
            {
                lblError.Text = String.Empty;
                btnAceptar.Enabled = true;
            }
            else
            {
                btnAceptar.Enabled = false;
            }
        }

        private void spinEditSDI_EditValueChanged(object sender, EventArgs e)
        {
            //dcSDI = spinEditSDI.Value;
            //validarSalarios();
        }

        private void spinEditSBC_EditValueChanged(object sender, EventArgs e)
        {
            spinEditSDI.Text = spinEditSBC.Text;
        }

        public String validarSalarios(int idEmpleado, decimal dSDCapturado, DateTime dFechaDeAplicacion)
        {
            String sRespuesta = String.Empty;

            stpSelValSMGVTableAdapter1.Fill(dsOperaciones1.stpSelValSMGV, idEmpleado, dSDCapturado, dFechaDeAplicacion, ref sRespuesta);

            return sRespuesta;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            String sRespuesta = String.Empty;
            Boolean flagSalarioMenorAlActual = false;

            decimal dcVacaciones;
            decimal dcPrimaVacacional;
            decimal dcAguinaldo;
            decimal dcFactorDeIntegracion;
            decimal dcUMA;

            decimal dcSDCActual;

            decimal.TryParse(txtVacaciones.Text, out dcVacaciones);
            decimal.TryParse(txtPrimaVacional.Text, out dcPrimaVacacional);
            decimal.TryParse(txtAguinaldo.Text, out dcAguinaldo);
            decimal.TryParse(txtFactorDeIntegracion.Text, out dcFactorDeIntegracion);
            decimal.TryParse(txtUMA.Text, out dcUMA);
            decimal.TryParse(spinEditSDEmpleado.Text, out dcSDCActual);

            sRespuesta = validarSalarios(objEmpleado.IdEmpleado, spinEditSD.Value, dtFecha.DateTime);

            if (String.IsNullOrEmpty(sRespuesta))
            {
                flagSalarioMenorAlActual = spinEditSD.Value < dcSDCActual ? true : false;

                //"Se esta solicitado un salario menor al actual para el empleado " + txtNombreEmpleado.Text + ". ¿Desea continuar?" : "";

                if (flagSolicitar)
                {
                    DialogResult oDialogResult = XtraMessageBox.Show(
                        (flagSalarioMenorAlActual ? "Se esta solicitado un salario menor al actual para el empleado " + txtNombreEmpleado.Text + ". ¿Desea continuar?" :
                        "¿Esta seguro de Solicitar el cambio de Salario para el empleado " + txtNombreEmpleado.Text + "?")
                      , "SAIC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (DialogResult.Yes == oDialogResult)
                    {
                        int? iSolicitud = 0;

                        queriesTableAdapter1.stpInsSolicitudAltaEmpleadosHeader(
                        0,
                        0,
                        0,
                        OperadorBD.OperadorGlobal.IdOperador,
                        OperadorBD.OperadorGlobal.NombreUsuario,
                        4, //Salarios
                        ref iSolicitud
                       );

                        if (iSolicitud > 0)
                        {
                            String stMensajeError = String.Empty;

                            queriesTableAdapter1.stpInsSolicitudSalariosEmpleados_1(
                                           iSolicitud
                                           , objEmpleado.IdEmpleado
                                           , spinEditSD.Value
                                           , spinEditSBC.Value
                                           , spinEditSDI.Value
                                           , spinEditParteVariable.Value
                                           , dcFactorDeIntegracion
                                           , dtFecha.DateTime
                                           , dcVacaciones
                                           , dcPrimaVacacional
                                           , dcAguinaldo
                                           , OperadorBD.OperadorGlobal.NombreUsuario
                                           , dcUMA
                                           , ref stMensajeError);

                            if (String.IsNullOrEmpty(stMensajeError))
                            {
                                XtraMessageBox.Show("Proceso Terminado" + Environment.NewLine +
                                    "Solicitud: " + iSolicitud
                                , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                XtraMessageBox.Show("Proceso con error" + Environment.NewLine +
                                    stMensajeError
                                , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    DialogResult oDialogResult = XtraMessageBox.Show(
                        (flagSalarioMenorAlActual ? "Se esta solicitado actualizar un salario menor al actual para el empleado " + txtNombreEmpleado.Text + ". ¿Desea continuar?" :
                        "¿Esta seguro de Actualizar el cambio de Salario para el empleado " + txtNombreEmpleado.Text + "?")
                      , "SAIC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (DialogResult.Yes == oDialogResult)
                    {
                        String stMensajeError = String.Empty;

                        queriesTableAdapter1.stpUpdSolicitudSalariosEmpleados_1(
                              idSolicitud
                            , objEmpleado.IdEmpleado
                            , spinEditSD.Value
                            , spinEditSBC.Value
                            , spinEditSDI.Value
                            , spinEditParteVariable.Value
                            , dtFecha.DateTime

                            , dcVacaciones
                            , dcPrimaVacacional
                            , dcAguinaldo
                            , dcFactorDeIntegracion
                            , dcUMA

                            , OperadorBD.OperadorGlobal.NombreUsuario
                            , ref stMensajeError
                            );


                        if (String.IsNullOrEmpty(stMensajeError))
                        {
                            XtraMessageBox.Show("Información Guardada"
                         , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            XtraMessageBox.Show("Proceso con error" + Environment.NewLine +
                                    stMensajeError
                                , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                if (!String.IsNullOrEmpty(sRespuesta))
                {
                    lblError.Text = sRespuesta;
                    btnAceptar.Enabled = false;
                }
                else
                {
                    lblError.Text = String.Empty;
                    btnAceptar.Enabled = true;
                }
            }
        }

        private void dtFecha_EditValueChanged(object sender, EventArgs e)
        {
            //validar que el salario sea diferente al actual
            if (spinEditSD.Value == objEmpleado.SalarioDiarioContrato)
            {
                btnAceptar.Enabled = false;
                lblError.Text = "El Salario solicitado es igual al actual.";
            }
            else
            {
                btnAceptar.Enabled = true;
                lblError.Text = String.Empty;

                lblError.Text = String.Empty;
                decimal dcFactorDeIntegracion;
                decimal? dcVacacionesEmpleado = 0;
                decimal? dcPrimaVacacional = 0;
                decimal? dcAguinaldo = 0;
                decimal? dcSalarioDiarioContrato_Empleado = 0;
                int? iAniosLaborados_Empleado = 0;
                decimal? dcUMA = 0;
                String sRespuesta = String.Empty;

                //obtener Informacion del Empleado
                stpSelObtenerInfoEmpleadoParaSolicitudDeSalariosTableAdapter1.Fill(dsOperaciones1.stpSelObtenerInfoEmpleadoParaSolicitudDeSalarios,
                    false,
                    objEmpleado.IdEmpleado
                    , String.Empty
                    , String.Empty
                    , String.Empty
                    , dtFecha.DateTime
                    , ref dcVacacionesEmpleado
                    , ref dcPrimaVacacional
                    , ref dcAguinaldo
                    , ref dcSalarioDiarioContrato_Empleado
                    , ref iAniosLaborados_Empleado
                    , ref dcUMA
                    , ref sRespuesta);

                txtVacaciones.Text = dcVacacionesEmpleado.ToString();
                txtPrimaVacional.Text = dcPrimaVacacional.ToString();
                txtAguinaldo.Text = dcAguinaldo.ToString();
                spinEditSDEmpleado.Text = dcSalarioDiarioContrato_Empleado.ToString();
                txtAniosLaborados.Text = iAniosLaborados_Empleado.ToString();
                txtFechaIngresoContrato.Text = objEmpleado.FechaIngresoContrato.ToShortDateString();
                txtUMA.Text = dcUMA.ToString();

                dcFactorDeIntegracion = obtenerFactorDeIntegracion(Convert.ToDecimal(txtVacaciones.Text), Convert.ToDecimal(txtPrimaVacional.Text), Convert.ToDecimal(txtAguinaldo.Text));
                txtFactorDeIntegracion.Text = dcFactorDeIntegracion.ToString();
                obtenerFechasDeAplicacion();

                String sValidarFechasDeAplicacion = String.Empty;
                sValidarFechasDeAplicacion = validarFechaDeAplicacion(dtFecha.DateTime, dtFechaMovimientoPasada, dtFechaMovimientoFutura);

                //Obtener parte variable del empleado
                ovariableIMSSEmpleado = new variableIMSSEmpleado(objEmpleado.IdEmpleado, dtFecha.DateTime);
                if (ovariableIMSSEmpleado.flagTaMuyBien)
                {
                    spinEditParteVariable.Value = ovariableIMSSEmpleado.ParteVariable;
                    lblSolicitudVariable.ToolTip = ovariableIMSSEmpleado.idSolicitudVariables == 0 ? ovariableIMSSEmpleado.sToolTip : "Solicitud: " + ovariableIMSSEmpleado.idSolicitudVariables;
                }
                else
                {
                    lblSolicitudVariable.ToolTip = ovariableIMSSEmpleado.sToolTip;
                    lblError.Text = ovariableIMSSEmpleado.sMensajeDeError;
                    spinEditParteVariable.Value = 0;
                }

                if (String.IsNullOrEmpty(sValidarFechasDeAplicacion) && ovariableIMSSEmpleado.flagTaMuyBien)
                {
                    btnAceptar.Enabled = true;
                    lblError.Text = String.Empty;
                }
                else
                {
                    btnAceptar.Enabled = false;
                    lblError.Text = !String.IsNullOrEmpty(lblError.Text) ? lblError.Text : sValidarFechasDeAplicacion;
                    //lblError.Text = sValidarFechasDeAplicacion;
                }
            }
        }

        public String validarFechaDeAplicacion(DateTime dtFechaAplicacion, DateTime dtFechaPasada, DateTime dtFechaFutura)
        {
            String sMensaje = String.Empty;
            //DateTime dtFechaAplicacion = new DateTime();
            //DateTime.TryParse(dtFecha.Text, out dtFechaAplicacion);

            if (dtFechaAplicacion < dtFechaPasada.AddDays(-1))
            {
                //XtraMessageBox.Show("La fecha de aplicacion no puede ser menor a " + dtFechaMovimientoPasada.ToShortDateString() + "."
                //  , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                sMensaje = "La fecha de aplicacion no puede ser menor a " + dtFechaPasada.ToShortDateString() + ". ";
                //lblError.Text = "La fecha de aplicacion no puede ser menor a " + dtFechaMovimientoPasada.ToShortDateString() + ". ";
                //flagtaMuyBien = false;

            }

            if (dtFechaAplicacion > dtFechaFutura)
            {
                //XtraMessageBox.Show("La fecha de aplicacion no puede ser mayor a " + dtFechaMovimientoFutura.ToShortDateString() + "."
                // , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                //lblError.Text = "La fecha de aplicacion no puede ser mayor a " + dtFechaMovimientoFutura.ToShortDateString() + ". ";
                //flagtaMuyBien = false;
                sMensaje = "La fecha de aplicacion no puede ser mayor a " + dtFechaFutura.ToShortDateString() + ". ";

            }

            return sMensaje;
        }

        //private Boolean validarFechaMoviento()
        //{
        //    Boolean flagTaMuyBien = true;
        //    if (dtFecha.DateTime.Date < dtFechaMovimientoPasada.Date || dtFecha.DateTime.Date > dtFechaMovimientoFutura.Date)
        //    {
        //        flagTaMuyBien = false;
        //        lblError.Text = "Fecha de Movimiento no puede ser menor a " + iDiasPasado + " dias, ni mayor a " + iDiasFuturo + " dias";
        //    }
        //    else
        //    {
        //        lblError.Text = String.Empty;
        //    }

        //    return flagTaMuyBien;

        //}

        //private void obtenerFechasParaMovimiento()
        //{
        //    stpSelParametroTableAdapter1.Fill(dbSAICBPOValidacionDataSet1.stpSelParametro, "DIASSALARIOPASADO");

        //    if (dbSAICBPOValidacionDataSet1.stpSelParametro.Rows.Count > 0)
        //    {
        //        int.TryParse(dbSAICBPOValidacionDataSet1.stpSelParametro.Rows[0]["ValorParametro"].ToString(), out iDiasPasado);
        //    }

        //    stpSelParametroTableAdapter1.Fill(dbSAICBPOValidacionDataSet1.stpSelParametro, "DIASSALARIOFUTURO");
        //    if (dbSAICBPOValidacionDataSet1.stpSelParametro.Rows.Count > 0)
        //    {
        //        int.TryParse(dbSAICBPOValidacionDataSet1.stpSelParametro.Rows[0]["ValorParametro"].ToString(), out iDiasFuturo);
        //    }

        //    dtFechaMovimientoPasada = ObtenerFechaServidor().AddDays(iDiasPasado);
        //    dtFechaMovimientoFutura = ObtenerFechaServidor().AddDays(iDiasFuturo);

        //    lblFechasParaSolicitar.ToolTip = "Fecha Pasada: " + dtFechaMovimientoPasada.ToShortDateString() + Environment.NewLine +
        //                                       "Fecha Futura: " + dtFechaMovimientoFutura.ToShortDateString();
        //}



        public DateTime obtenerFechaAplicacionPasada(decimal dcSalarioActualEmpleado, decimal dcSalariosEmpleadoASolicitar)
        {
            int iDiasPasado = -5;
            DateTime dtFechaPasada = new DateTime();

            if (dcSalariosEmpleadoASolicitar < dcSalarioActualEmpleado)
            {
                dtFechaPasada = ObtenerFechaServidor();
            }
            else
            {
                stpSelParametroTableAdapter1.Fill(dbSAICBPOValidacionDataSet1.stpSelParametro, "DIASSALARIOPASADO");

                if (dbSAICBPOValidacionDataSet1.stpSelParametro.Rows.Count > 0)
                {
                    int.TryParse(dbSAICBPOValidacionDataSet1.stpSelParametro.Rows[0]["ValorParametro"].ToString(), out iDiasPasado);
                }

                dtFechaPasada = ObtenerFechaServidor().AddDays(iDiasPasado);
            }

            return dtFechaPasada;
        }

        public DateTime obtenerFechaAplicacionFutura()
        {
            int iDiasFuturo = 5;
            DateTime dtFechaFutura = new DateTime();
            stpSelParametroTableAdapter1.Fill(dbSAICBPOValidacionDataSet1.stpSelParametro, "DIASSALARIOFUTURO");
            if (dbSAICBPOValidacionDataSet1.stpSelParametro.Rows.Count > 0)
            {
                int.TryParse(dbSAICBPOValidacionDataSet1.stpSelParametro.Rows[0]["ValorParametro"].ToString(), out iDiasFuturo);
            }

            dtFechaFutura = ObtenerFechaServidor().AddDays(iDiasFuturo);

            return dtFechaFutura;
        }




        private DateTime ObtenerFechaServidor()
        {
            // Obtener la fecha del servidor
            DateTime dtFechaServidor = new DateTime();
            String stfechaServidor = String.Empty;
            stfechaServidor = stpSelEstatusNominaContabilizadaTableAdapter1.ObtenerFechaServidor().ToString();
            DateTime.TryParse(stfechaServidor, out dtFechaServidor);
            return dtFechaServidor;
        }

        public decimal obtenerFactorDeIntegracion(decimal dcvacaciones, decimal dcPrimaVacaciones, decimal dcAguinaldo)
        {
            decimal dcFactorDeIntegracion = 0;

            var resultado = queriesOperacionesAdapter1.FactorDeIntegracion(dcvacaciones, dcPrimaVacaciones, dcAguinaldo);

            decimal.TryParse(resultado.ToString(), out dcFactorDeIntegracion);

            return dcFactorDeIntegracion;
        }


        public decimal obtenerSBCSDI(decimal dSalarioDiarioCapturado, decimal dFactorDeIntegracion, decimal dUMA, decimal dPartevariable)
        {
            //decimal dcFactorIntegracion = 0;
            //decimal dcSalario = 0;
            decimal dcSBC = 0;

            //decimal.TryParse(txtFactorDeIntegracion.Text.ToString(), out dcFactorIntegracion);
            //decimal.TryParse(spinEditSD.Text.ToString(), out dcSalario);

            dcSBC = dSalarioDiarioCapturado * dFactorDeIntegracion;
            dcSBC = dcSBC + dPartevariable;
            //Validando Si el SBC llega al Tope de las 25 UMAs
            //decimal dcUma = 0;
            decimal dcTopeUma = 0;

            //decimal.TryParse(txtUMA.Text, out dcUma);

            dcTopeUma = dUMA * 25;

            if (dcSBC >= dcTopeUma)
            {
                dcSBC = dcTopeUma;
            }
            //Validando Si el SBC llega al Tope de las 25 UMAs

            //spinEditSBC.Value = decimal.Round(dcSBC, 2);
            //dcSalarioBaseDeContizacion = spinEditSBC.Value;

            return decimal.Round(dcSBC, 2);
        }

        private void obtenerFechasDeAplicacion()
        {
            decimal dcSalarioCapturado = 0;
            decimal.TryParse(spinEditSD.Value.ToString(), out dcSalarioCapturado);

            dtFechaMovimientoPasada = obtenerFechaAplicacionPasada(objEmpleado.SalarioDiarioContrato, dcSalarioCapturado);
            dtFechaMovimientoFutura = obtenerFechaAplicacionFutura();

            lblFechasParaSolicitar.ToolTip = "Fecha Pasada: " + dtFechaMovimientoPasada.ToShortDateString() + Environment.NewLine +
                                              "Fecha Futura: " + dtFechaMovimientoFutura.ToShortDateString();
        }

        private void spinEditParteVariable_EditValueChanged(object sender, EventArgs e)
        {

            decimal dFactorDeIntegracion = 0;
            decimal.TryParse(txtFactorDeIntegracion.Text, out dFactorDeIntegracion);

            decimal dcUma = 0;
            decimal.TryParse(txtUMA.Text, out dcUma);

            spinEditSBC.Value = obtenerSBCSDI(spinEditSD.Value, dFactorDeIntegracion, dcUma, spinEditParteVariable.Value);
            dcSalarioBaseDeContizacion = spinEditSBC.Value;

            //decimal dcPartevariable = 0;
            ////decimal dcSBC = 0;
            //decimal dcRes = 0;

            //decimal.TryParse(spinEditParteVariable.Value.ToString(), out dcPartevariable);
            ////decimal.TryParse(spinEditSBC.Value.ToString(), out dcSBC);
            //dcRes = dcPartevariable + dcSalarioBaseDeContizacion;

            ////Validando Si el SBC llega al Tope de las 25 UMAs

            //decimal dcTopeUma = 0;

            //dcTopeUma = dcUma * 25;

            //if (dcRes >= dcTopeUma)
            //{
            //    dcRes = dcTopeUma;
            //}
            ////Validando Si el SBC llega al Tope de las 25 UMAs

            //spinEditSBC.Value = decimal.Round(dcRes, 2);
        }
    }

    public class variableIMSSEmpleado
    {
        public int idEmpleado { get; set; }
        public decimal ParteVariable { get; set; }
        public int iAnioBimestre { get; set; }
        public int iBimestre { get; set; }
        public int idSolicitudVariables { get; set; }
        public DateTime dtAplicacion { get; set; }
        public DateTime dtFechaVigenciaIni { get; set; }
        public DateTime dtFechaVigenciaFin { get; set; }
        public Boolean flagComplemento { get; set; }
        public String sMensajeDeError { get; set; }
        public String sToolTip { get; set; }
        public Boolean flagTaMuyBien { get; set; }

        public variableIMSSEmpleado(int idEmpleado, DateTime dtFechaObtencionDeVariable)
        {
            string sConexionBD = winAppSAIC.Properties.Settings.Default.dbSAICBPOConnectionString;
            try
            {
                using (SqlConnection Cnn = new SqlConnection(sConexionBD))
                {
                    SqlCommand cmd = new SqlCommand("dbo.stpSelInfoVariablesIMSSEmpleado", Cnn)
                    { CommandType = CommandType.StoredProcedure };

                    cmd.Parameters.AddWithValue("@pidEmpleado", idEmpleado);
                    cmd.Parameters.AddWithValue("@pFechaObtencionDeVariable", dtFechaObtencionDeVariable);

                    Cnn.Open(); //abrir conexion
                    cmd.ExecuteNonQuery();  //ejecutar stored procedure
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        flagTaMuyBien = false;
                        sToolTip = String.Empty;

                        while (reader.Read())
                        {
                            this.idEmpleado = Convert.ToInt32(reader.GetValue(0).ToString());
                            ParteVariable = Convert.ToDecimal(reader.GetValue(1).ToString());
                            iAnioBimestre = Convert.ToInt32(reader.GetValue(2).ToString());
                            iBimestre = Convert.ToInt32(reader.GetValue(3).ToString());
                            idSolicitudVariables = Convert.ToInt32(reader.GetValue(4).ToString());
                            dtFechaVigenciaIni = Convert.ToDateTime(reader.GetValue(5).ToString());
                            dtFechaVigenciaFin = Convert.ToDateTime(reader.GetValue(6).ToString());
                            flagComplemento = Convert.ToBoolean(reader.GetValue(7).ToString());
                            sMensajeDeError = String.Empty;
                            flagTaMuyBien = true;

                            if (!flagComplemento)
                            {
                                //validar que la fecha sea primero de mes del bimestre 
                                if (dtFechaObtencionDeVariable.Day == 1 && dtFechaObtencionDeVariable.Month == 1) // inicio del primer Bimestre
                                {
                                    flagTaMuyBien = false;
                                    ParteVariable = 0;
                                    idSolicitudVariables = 0;
                                    sMensajeDeError = "No se puede solicitar actualizacion de salario";
                                    sToolTip = "No se puede solicitar actualizacion de salario";
                                }
                                else if (dtFechaObtencionDeVariable.Day == 1 && dtFechaObtencionDeVariable.Month == 3) // inicio del segundo Bimestre
                                {
                                    flagTaMuyBien = false;
                                    ParteVariable = 0;
                                    idSolicitudVariables = 0;
                                    sMensajeDeError = "No se puede solicitar actualizacion de salario";
                                    sToolTip = "No se puede solicitar actualizacion de salario";
                                }
                                else if (dtFechaObtencionDeVariable.Day == 1 && dtFechaObtencionDeVariable.Month == 5) // inicio del segundo Bimestre
                                {
                                    flagTaMuyBien = false;
                                    ParteVariable = 0;
                                    idSolicitudVariables = 0;
                                    sMensajeDeError = "No se puede solicitar actualizacion de salario";
                                    sToolTip = "No se puede solicitar actualizacion de salario";
                                }
                                else if (dtFechaObtencionDeVariable.Day == 1 && dtFechaObtencionDeVariable.Month == 7) // inicio del segundo Bimestre
                                {
                                    flagTaMuyBien = false;
                                    ParteVariable = 0;
                                    idSolicitudVariables = 0;
                                    sMensajeDeError = "No se puede solicitar actualizacion de salario";
                                    sToolTip = "No se puede solicitar actualizacion de salario";
                                }
                                else if (dtFechaObtencionDeVariable.Day == 1 && dtFechaObtencionDeVariable.Month == 9) // inicio del segundo Bimestre
                                {
                                    flagTaMuyBien = false;
                                    ParteVariable = 0;
                                    idSolicitudVariables = 0;
                                    sMensajeDeError = "No se puede solicitar actualizacion de salario";
                                    sToolTip = "No se puede solicitar actualizacion de salario";
                                }
                                else if (dtFechaObtencionDeVariable.Day == 1 && dtFechaObtencionDeVariable.Month == 11) // inicio del segundo Bimestre
                                {
                                    flagTaMuyBien = false;
                                    ParteVariable = 0;
                                    idSolicitudVariables = 0;
                                    sMensajeDeError = "No se puede solicitar actualizacion de salario";
                                    sToolTip = "No se puede solicitar actualizacion de salario";
                                }
                            }
                        }

                        if (!flagTaMuyBien && String.IsNullOrEmpty(sToolTip))
                        {
                            flagTaMuyBien = false;
                            sMensajeDeError = "Empleado sin Calculo de Variables.";
                            sToolTip = "Empleado sin Calculo de Variables.";
                        }
                    }
                    Cnn.Close();    //cerrar conexion
                }  //using                
            }
            catch (SqlException ex) { }
            catch (Exception ex) { }
        }

    }
}