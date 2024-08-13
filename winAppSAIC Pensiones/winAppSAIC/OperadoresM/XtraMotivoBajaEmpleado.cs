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

namespace winAppSAIC.OperadoresM
{
    public partial class XtraMotivoBajaEmpleado : DevExpress.XtraEditors.XtraForm
    {
        Empleado miEmpleado;
        String stNombreCompleatoEmpleado = String.Empty;
        DateTime dTimeFechaInical = new DateTime();
        DateTime dTimeFechaLimite = new DateTime();
        DateTime dTimeFechaLimiteFutura = new DateTime();
        int iDiasFuturos = 2;
        DateTime FechaInicial;
        int TipoModulo; //1 = para solicitar la baja 2 = para soliciar actualizacion de la informacion del empleado. Cuando haya modificacion de los datos.
        int iDiasLimiteBajas = 5;

        public XtraMotivoBajaEmpleado(Empleado miEmpleado, int TipoModulo, DateTime FechaInicial)
        {
            InitializeComponent();
            this.miEmpleado = miEmpleado;
            this.TipoModulo = TipoModulo;
            this.FechaInicial = FechaInicial;
        }

        private void toolBtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                int iValor = 0;

                if (lookupMotivosBaja.EditValue != null)
                {
                    int.TryParse(lookupMotivosBaja.EditValue.ToString(), out iValor);

                    String stmensaje = String.Empty;
                    stmensaje = TipoModulo == 1 ? "Se dara de baja al empleado: " + miEmpleado.IdEmpleado + " " + stNombreCompleatoEmpleado + "." : "Se Actualizara la Información de baja de: " + miEmpleado.IdEmpleado + " " + stNombreCompleatoEmpleado + ".";

                    DialogResult drResultado = XtraMessageBox.Show(stmensaje + Environment.NewLine +
                        "¿Desea confirmar la baja del Empleado?"
                  , "SAIC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (DialogResult.Yes == drResultado)
                    {
                        if (TipoModulo == 1)
                        {
                            solicitarBajaEmpleado(miEmpleado, dteditFechabaja.DateTime, iValor);
                        }
                        else if (TipoModulo == 2)
                        {
                            actualizarBajaEmpleado(miEmpleado, dteditFechabaja.DateTime, iValor);
                        }
                    }
                }
                else
                {
                    XtraMessageBox.Show("Seleccione un Motivo de baja."
                 , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lookupMotivosBaja.Focus();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error al dar de baja al Empleado." + Environment.NewLine + ex.Message
                , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void XtraMotivoBajaEmpleado_Load(object sender, EventArgs e)
        {
            stpSelDiasFestivosTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelDiasFestivos);
            stpSelObtenerConceptosBajaTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelObtenerConceptosBaja, true);
            stNombreCompleatoEmpleado = miEmpleado.NombreEmpleado + " " + miEmpleado.APaternoEmpleado + " " + miEmpleado.AMaternoEmpleado;
            txtEditIdEmpleado.Text = miEmpleado.IdEmpleado.ToString();
            txtNombreEmpleado.Text = stNombreCompleatoEmpleado;

            String stFechaincial = String.Empty;
            if (TipoModulo == 1)
            {
                stFechaincial = stpSelEstatusNominaContabilizadaTableAdapter1.ObtenerFechaServidor().ToString();
            }
            else //Para Actualizar!!!!!!!!!!!!! Toma la fecha de creacion de la Solicitud
            {
                //stFechaincial = FechaInicial.ToShortDateString();
                stFechaincial = stpSelEstatusNominaContabilizadaTableAdapter1.ObtenerFechaServidor().ToString();
                lookupMotivosBaja.EditValue = miEmpleado.IdConceptoBaja;
                mmObservacionesBaja.Text = miEmpleado.ObservacionesBaja;
            }

            DateTime.TryParse(stFechaincial, out dTimeFechaInical);
            dTimeFechaLimite = ObtenerFechaLimiteBajaIMSS(dTimeFechaInical, dbSAICBPOCatalogosDataSet1.stpSelDiasFestivos);
            dTimeFechaLimiteFutura = ObtenerFechaLimiteBajaIMSSFutura(dTimeFechaInical);
            dteditFechabaja.Text = dTimeFechaInical.ToShortDateString();
        }

        public DateTime ObtenerFechaLimiteBajaIMSS(DateTime dTimeFechaIni, DataTable dtDiasFestivos)
        {
           

            stpSelParametroTableAdapter1.Fill(dbSAICBPOValidacionDataSet1.stpSelParametro, "DIAS LIMITE BAJAS");

            if (dbSAICBPOValidacionDataSet1.stpSelParametro.Count > 0)
            {
                if (int.TryParse(dbSAICBPOValidacionDataSet1.stpSelParametro[0]["ValorParametro"].ToString(), out iDiasLimiteBajas))
                {
                    int.TryParse(dbSAICBPOValidacionDataSet1.stpSelParametro[0]["ValorParametro"].ToString(), out iDiasLimiteBajas);
                }
            }

            int iDiasLimite = 0;
            while (iDiasLimite < iDiasLimiteBajas)
            {
                String stDiaSemana = dTimeFechaIni.AddDays(-1).DayOfWeek.ToString();

                if (stDiaSemana != "Sunday" && stDiaSemana != "Saturday")
                {
                    if (!diasFestivos(dTimeFechaIni, dtDiasFestivos))
                    {
                        dTimeFechaIni = dTimeFechaIni.AddDays(-1);
                        iDiasLimite++;
                    }
                    else
                    {
                        dTimeFechaIni = dTimeFechaIni.AddDays(-1);
                    }
                }
                else
                {
                    dTimeFechaIni = dTimeFechaIni.AddDays(-1);
                }
            }

            //Si el dia limite es igual a un dia festivo se le resta un dia mas
            if (diasFestivos(dTimeFechaIni, dtDiasFestivos))
            {
                dTimeFechaIni = dTimeFechaIni.AddDays(-1);
            }


            return dTimeFechaIni;
        }


        private void dteditFechabaja_EditValueChanged(object sender, EventArgs e)
        {
            if (dteditFechabaja.DateTime >= miEmpleado.FechaIngresoContrato)
            {
                if (dteditFechabaja.DateTime < dTimeFechaLimite.Date)
                {
                    dteditFechabaja.Text = dTimeFechaInical.ToShortDateString();
                    btnAceptar.Enabled = false;
                    XtraMessageBox.Show("Fecha seleccionada Invalida. No se puede solicitar una baja menor a " + iDiasLimiteBajas + " días."
              , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (dteditFechabaja.DateTime > dTimeFechaLimiteFutura.Date)
                {
                    dteditFechabaja.Text = dTimeFechaInical.ToShortDateString();
                    btnAceptar.Enabled = false;
                    XtraMessageBox.Show("Fecha seleccionada Invalida. No se puede solicitar una baja mayor a " + iDiasFuturos + " dias"
              , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    btnAceptar.Enabled = true;
                }
            }
            else
            {
                btnAceptar.Enabled = false;
                dteditFechabaja.Focus();
                XtraMessageBox.Show("La Fecha de Baja no puede ser menor a la Fecha de Ingreso (" + miEmpleado.FechaIngresoContrato.ToShortDateString() + ").", "SAIC",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void solicitarBajaEmpleado(Empleado miEmpleado, DateTime dtimeFechaBaja, int iMotivobaja)
        {
            int? iSolicitud = 0;
            String stmensaje = String.Empty;
            queriesTableAdapter1.stpInsSolicitudAltaEmpleadosHeader(
                    Convert.ToInt32(miEmpleado.IdTenedoraSA),
                    Convert.ToInt32(2),
                    Convert.ToInt32(miEmpleado.IdCliente),
                    OperadorBD.OperadorGlobal.IdOperador,
                    OperadorBD.OperadorGlobal.NombreUsuario,
                    2, //Tipo de Alta 7 = ALTA
                    ref iSolicitud
                   );


            if (iSolicitud > 0)
            {
                queriesTableAdapter1.stpInsBajaEmpleados(iSolicitud, miEmpleado.IdEmpleado, OperadorBD.OperadorGlobal.IdOperador, dtimeFechaBaja, iMotivobaja, mmObservacionesBaja.Text, stmensaje);

                XtraMessageBox.Show(Environment.NewLine + "Solicitud Generada con Exito" + Environment.NewLine + Environment.NewLine +
                             "Numero de Solicitud: " + iSolicitud + Environment.NewLine
                         , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            else
            {
                btnAceptar.Enabled = false;
                XtraMessageBox.Show(Environment.NewLine + "No se puede insertar el Detalle de la Solicitud" + Environment.NewLine + Environment.NewLine +
                       "Numero de Solicitud: " + iSolicitud + Environment.NewLine
                   , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void actualizarBajaEmpleado(Empleado miEmpleado, DateTime dtimeFechaBaja, int iMotivobaja)
        {
            try
            {
                var respuesta = queriesTableAdapter1.stpUpdInfoEmpleadoBaja(miEmpleado.IdEmpleado, iMotivobaja, dtimeFechaBaja, OperadorBD.OperadorGlobal.IdOperador, mmObservacionesBaja.Text);
                if (String.IsNullOrEmpty(respuesta.ToString()))
                {
                    String stNombreCompleado = miEmpleado.NombreEmpleado + " " + miEmpleado.APaternoEmpleado + " " + miEmpleado.AMaternoEmpleado;
                    XtraMessageBox.Show("Información Actualizada del empleado: " + stNombreCompleado + Environment.NewLine
                , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    XtraMessageBox.Show("No se puede la informacion del Empleado." + Environment.NewLine + respuesta.ToString()
               , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(Environment.NewLine + "No se puede la informacion del Empleado." + Environment.NewLine + ex.Message
                 , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        /// <summary>
        /// Saber si la fecha seleccionada es igual a un dia festivo
        /// </summary>
        /// <returns></returns>
        public Boolean diasFestivos(DateTime dtimeFecha, DataTable dtDiasFestivos)
        {
            Boolean flattaMuyBien = false;
            //dbSAICBPOCatalogosDataSet1.stpSelDiasFestivos
            if (dtDiasFestivos.Rows.Count > 0)
            {
                foreach (DataRow rFecha in dtDiasFestivos.Rows)
                {
                    DateTime dtdiafestivo = new DateTime();
                    DateTime.TryParse(rFecha["DiaFestivo"].ToString(), out dtdiafestivo);
                    if (dtimeFecha.Date == dtdiafestivo.Date)
                    {
                        flattaMuyBien = true;
                        break;
                    }
                }
            }

            return flattaMuyBien;
        }

        /// <summary>
        /// Obtener fecha limite a Futuro para las Bajas de los empleados
        /// </summary>
        /// <param name="FechaIni"></param>
        /// <returns></returns>
        public DateTime ObtenerFechaLimiteBajaIMSSFutura(DateTime FechaIni)
        {
            DateTime FechaLimite = new DateTime();

            //Obtener de la base el numero de dias que se tomaran para contar a Futuro
            stpSelParametroTableAdapter1.Fill(dbSAICBPOValidacionDataSet1.stpSelParametro, "DIAS PARA BAJAS");

            if (dbSAICBPOValidacionDataSet1.stpSelParametro.Rows.Count > 0)
            {
                int.TryParse(dbSAICBPOValidacionDataSet1.stpSelParametro[0]["ValorParametro"].ToString(), out iDiasFuturos);
                if (iDiasFuturos == 0) { iDiasFuturos = 2; }
            }

            FechaLimite = FechaIni.AddDays(iDiasFuturos);

            return FechaLimite;
        }
    }
}