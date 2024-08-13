using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Diagnostics;
using compCatalogosSAIC;

namespace winAppSAIC.IMSS
{
    public partial class XtraSolicitudVariables : DevExpress.XtraEditors.XtraForm
    {

        tools.dsc dsc = new tools.dsc();
        DateTime dtFechaDeAplicacion;
        variablesIMSSHeader ovariablesIMSSHeader;
        DataTable dtTodosLosEmpleados;
        String sTipoSolicitud = String.Empty;

        public XtraSolicitudVariables()
        {
            InitializeComponent();
        }

        private String TitulosExcelParaValidacion()
        {
            String[] lstTitulos = new String[] {
                "IdEmpleado",
                "Nombre Empleado Completo",
                "NSS",
                "RFC",
                "CURP"
                , "ParteVariable"
           };

            return String.Join("", lstTitulos).ToUpper().Replace(" ", "");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAbrirCarpeta_Click(object sender, EventArgs e)
        {
            dsc.CheckandCreateFolder(dsc.ObtenerRutaSolicitud(6, 2));
            Process.Start(dsc.ObtenerRutaSolicitud(6, 2));
        }

        private void XtraSolicitudVariables_Load(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            // TODO: esta línea de código carga datos en la tabla 'dbSAICBPOActualizacionesIMSSDataSet.stpSelAnioSolicitudVariablesIMSS' Puede moverla o quitarla según sea necesario.
            this.stpSelAnioSolicitudVariablesIMSSTableAdapter.Fill(this.dbSAICBPOActualizacionesIMSSDataSet.stpSelAnioSolicitudVariablesIMSS);

            if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }
        }

        private void gridLookUpEditAnio_EditValueChanged(object sender, EventArgs e)
        {
            int iAnio = 0;
            int.TryParse(gridLookUpEditAnio.EditValue.ToString(), out iAnio);
            stpSelBimestreSolicitudVariablesIMSSTableAdapter.Fill(dbSAICBPOActualizacionesIMSSDataSet.stpSelBimestreSolicitudVariablesIMSS, iAnio);
        }

        private void gridLookUpEditBimestre_EditValueChanged(object sender, EventArgs e)
        {
            int iBismestre = 0;
            int.TryParse(gridLookUpEditBimestre.EditValue.ToString(), out iBismestre);
            stpSelDetalleBimestreSolicitudVariablesIMSSTableAdapter1.Fill(dbSAICBPOActualizacionesIMSSDataSet.stpSelDetalleBimestreSolicitudVariablesIMSS, iBismestre);
            if (dbSAICBPOActualizacionesIMSSDataSet.stpSelDetalleBimestreSolicitudVariablesIMSS.Rows.Count > 1)
            {

                DateTime dtFechaVigenciaFin;
                txtMeses.Text = dbSAICBPOActualizacionesIMSSDataSet.stpSelDetalleBimestreSolicitudVariablesIMSS.Rows[0]["DescMes"].ToString() + " - " + dbSAICBPOActualizacionesIMSSDataSet.stpSelDetalleBimestreSolicitudVariablesIMSS.Rows[1]["DescMes"].ToString();
                txtDiasDelPeriodo.Text = dbSAICBPOActualizacionesIMSSDataSet.stpSelDetalleBimestreSolicitudVariablesIMSS.Rows[0]["DiasBimestre"].ToString();

                int iMes = 0;
                int.TryParse(dbSAICBPOActualizacionesIMSSDataSet.stpSelDetalleBimestreSolicitudVariablesIMSS.Rows[1]["IdMes"].ToString(), out iMes);

                int iAnio;
                int.TryParse(gridLookUpEditAnio.EditValue.ToString(), out iAnio);

                dtFechaDeAplicacion = new DateTime(iAnio, iMes, 01);
                dtFechaVigenciaFin = dtFechaDeAplicacion;
                dtFechaVigenciaFin = dtFechaVigenciaFin.AddMonths(3);
                dtFechaVigenciaFin = dtFechaVigenciaFin.AddDays(-1);

                txtFechaAplicacion.Text = dtFechaDeAplicacion.AddMonths(1).ToShortDateString();
                txtFechaVigenciaInicio.Text = dtFechaDeAplicacion.AddMonths(1).ToShortDateString();
                txtFechaVigenciaFin.Text = dtFechaVigenciaFin.ToShortDateString();
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl7_Click(object sender, EventArgs e)
        {

        }

        private void btnDescargarExcel_Click(object sender, EventArgs e)
        {
            String ruta = dsc.ObtenerRutaSolicitud(6, 2) + "Variables " + gridLookUpEditAnio.EditValue.ToString() + "-" + gridLookUpEditBimestre.EditValue.ToString() + dsc.nombreAleatorio() + ".xlsx";
            dsc.CheckandCreateFolder(dsc.ObtenerRutaSolicitud(6, 2));
            gridViewvariables.ExportToXlsx(ruta);

            XtraMessageBox.Show("Documento Descargado. Ruta: " + ruta, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            sTipoSolicitud = "SISTEMA";
            ConsultarEmpleadosVaribles();
        }

        private void ConsultarEmpleadosVaribles()
        {

            int iAnio = 0;
            int iBimestre = 0;

            int.TryParse(gridLookUpEditAnio.EditValue.ToString(), out iAnio);
            int.TryParse(gridLookUpEditBimestre.EditValue.ToString(), out iBimestre);

            if (iAnio > 0 && iBimestre > 0)
            {
                splashScreenManager1.ShowWaitForm();

                gridControlPlantilla.Visible = false;
                gridControlPlantilla.Dock = DockStyle.None;

                gridControlVariables.Visible = true;
                gridControlVariables.Dock = DockStyle.Fill;

                gridControl1Aniversarios.Visible = false;
                gridControl1Aniversarios.Dock = DockStyle.None;

                //String stErrores = String.Empty;
                //int iAnio = 0;
                //int iBimestre = 0;
                //DateTime dtFechaAplicacion = new DateTime();
                //DateTime dtFechaIniVigenciaParteVariable = new DateTime();
                //DateTime dtFechaFinVigenciaParteVariable = new DateTime();

                //int.TryParse(gridLookUpEditAnio.EditValue.ToString(), out iAnio);
                //int.TryParse(gridLookUpEditBimestre.EditValue.ToString(), out iBimestre);

                //DateTime.TryParse(txtFechaAplicacion.Text, out dtFechaAplicacion);
                //DateTime.TryParse(txtFechaVigenciaInicio.Text, out dtFechaIniVigenciaParteVariable);
                //DateTime.TryParse(txtFechaVigenciaFin.Text, out dtFechaFinVigenciaParteVariable);

                //stpSelEmpleadosVariablesIMSSTableAdapter.Fill(dbSAICBPOActualizacionesIMSSDataSet.stpSelEmpleadosVariablesIMSS
                //    , 0
                //    , String.Empty
                //    , String.Empty
                //    , String.Empty
                //    , iAnio
                //    , iBimestre
                //    , dtFechaAplicacion
                //    , dtFechaIniVigenciaParteVariable
                //    , dtFechaFinVigenciaParteVariable
                //    , false
                //    , 0
                //    , ref stErrores);

                //dtTodosLosEmpleados = dbSAICBPOActualizacionesIMSSDataSet.stpSelEmpleadosVariablesIMSS;

                dtTodosLosEmpleados = consultarEmpleadosParaVariables();

                txtEmpleadosSeleccionados.Text = "0";
                txtTotalDeEmpleados.Text = dbSAICBPOActualizacionesIMSSDataSet.stpSelEmpleadosVariablesIMSS.Rows.Count.ToString();

                ovariablesIMSSHeader = obtenerInfoVariablesIMSSHeader();

                txtRegistrosPatronales.Text = (from r in dbSAICBPOActualizacionesIMSSDataSet.stpSelEmpleadosVariablesIMSS.AsEnumerable()
                                               select r["RegistroPatronalIMSS"]).Distinct().ToList().Count.ToString();

                txtEmpleadosValidos.Text = (from x in dbSAICBPOActualizacionesIMSSDataSet.stpSelEmpleadosVariablesIMSS.AsEnumerable()
                                            where String.IsNullOrEmpty(x.Field<String>("Estatus"))
                                            select x["RegistroPatronalIMSS"]).ToList().Count.ToString();

                txtEmpleadosConError.Text = (from x in dbSAICBPOActualizacionesIMSSDataSet.stpSelEmpleadosVariablesIMSS.AsEnumerable()
                                             where !String.IsNullOrEmpty(x.Field<String>("Estatus"))
                                             select x["RegistroPatronalIMSS"]).ToList().Count.ToString();

                //obteniendo empleados de aniversario
                obtenerEmpleadosDeAniversario(ovariablesIMSSHeader.dtFechaAplicacion, ovariablesIMSSHeader.iAnio, ovariablesIMSSHeader.iBimestre, false);

                gridLookUpEditAnio.Enabled = false;
                gridLookUpEditBimestre.Enabled = false;

                if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }
            }
            else
            {
                XtraMessageBox.Show("Seleccione un Año y Bimestre para consultar empleados"
                         , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private DataTable consultarEmpleadosParaVariables()
        {
            DataTable dtEmpleados = new DataTable();

            String stErrores = String.Empty;
            int iAnio = 0;
            int iBimestre = 0;
            DateTime dtFechaAplicacion = new DateTime();
            DateTime dtFechaIniVigenciaParteVariable = new DateTime();
            DateTime dtFechaFinVigenciaParteVariable = new DateTime();

            int.TryParse(gridLookUpEditAnio.EditValue.ToString(), out iAnio);
            int.TryParse(gridLookUpEditBimestre.EditValue.ToString(), out iBimestre);

            DateTime.TryParse(txtFechaAplicacion.Text, out dtFechaAplicacion);
            DateTime.TryParse(txtFechaVigenciaInicio.Text, out dtFechaIniVigenciaParteVariable);
            DateTime.TryParse(txtFechaVigenciaFin.Text, out dtFechaFinVigenciaParteVariable);

            stpSelEmpleadosVariablesIMSSTableAdapter.Fill(dbSAICBPOActualizacionesIMSSDataSet.stpSelEmpleadosVariablesIMSS
               , 0
               , String.Empty
               , String.Empty
               , String.Empty
               , iAnio
               , iBimestre
               , dtFechaAplicacion
               , dtFechaIniVigenciaParteVariable
               , dtFechaFinVigenciaParteVariable
               , false
               , 0
               , ref stErrores);

            dtEmpleados = dbSAICBPOActualizacionesIMSSDataSet.stpSelEmpleadosVariablesIMSS;

            return dtEmpleados;
        }



        private variablesIMSSHeader obtenerInfoVariablesIMSSHeader()
        {
            variablesIMSSHeader ovariablesIMSSHeader_1 = new variablesIMSSHeader();

            int iAnio = 0;
            int.TryParse(gridLookUpEditAnio.EditValue.ToString(), out iAnio);

            int iBimestre = 0;
            int.TryParse(gridLookUpEditBimestre.EditValue.ToString(), out iBimestre);

            DateTime dtFechaAplicacion = new DateTime();
            DateTime.TryParse(txtFechaAplicacion.Text, out dtFechaAplicacion);

            DateTime dtFechaVigenciaInicio = new DateTime();
            DateTime.TryParse(txtFechaVigenciaInicio.Text, out dtFechaVigenciaInicio);

            DateTime dtFechaVigenciaFin = new DateTime();
            DateTime.TryParse(txtFechaVigenciaFin.Text, out dtFechaVigenciaFin);

            ovariablesIMSSHeader_1.iAnio = iAnio;
            ovariablesIMSSHeader_1.iBimestre = iBimestre;
            ovariablesIMSSHeader_1.dtFechaAplicacion = dtFechaAplicacion;
            ovariablesIMSSHeader_1.dtFechaVigenciaInicio = dtFechaVigenciaInicio;
            ovariablesIMSSHeader_1.dtFechaVigenciaFin = dtFechaVigenciaFin;

            return ovariablesIMSSHeader_1;
        }


        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            try
            {

                int iContaVariables = 0;
                DataTable dtEmpleadosSeleccionados = new DataTable();
                DataTable dtTodoslosEmpleados_ = new DataTable();

                DataTable dtTodoslosEmpleadosParaComplemento_ = new DataTable();

                if (gridControlVariables.Visible)
                {
                    dtEmpleadosSeleccionados = dsc.deGridViewSelectedToDataTable(gridViewvariables);
                    dtTodoslosEmpleados_ = dtTodosLosEmpleados;

                }
                else if (gridControlPlantilla.Visible)
                {
                    dtTodoslosEmpleadosParaComplemento_ = consultarEmpleadosParaVariables();
                    dtEmpleadosSeleccionados = dsc.deGridViewSelectedToDataTable(gridViewPlantilla);
                    dtTodoslosEmpleados_ = dsc.deGridViewaDataTable(gridViewPlantilla);
                }

                if (dtEmpleadosSeleccionados.Rows.Count > 0)
                {
                    using (var form = new tools.XtraTextBox("Variables", "Solicitud de Variables", 50))
                    {
                        String stMensaje = String.Empty;
                        var result = form.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            splashScreenManager1.ShowWaitForm();
                            int? idVariablesIMSSHeader = 0;
                            ovariablesIMSSHeader.stNombreVaribleIMSS = form.sTextBox;

                            actualizacionesIMSSTableAdapter1.stpInsVariablesIMSSHeader(
                            ovariablesIMSSHeader.stNombreVaribleIMSS
                             , ovariablesIMSSHeader.iAnio
                             , ovariablesIMSSHeader.iBimestre
                             , ovariablesIMSSHeader.dtFechaAplicacion
                             , ovariablesIMSSHeader.dtFechaVigenciaInicio
                             , ovariablesIMSSHeader.dtFechaVigenciaFin
                             , OperadorBD.OperadorGlobal.IdOperador
                             , sTipoSolicitud
                             , ref idVariablesIMSSHeader);

                            if (idVariablesIMSSHeader > 0)
                            {
                                int iAnioVariables = 0;
                                int iBimestreVariables = 0;
                                DateTime dtFechaVigenciaInicio = new DateTime();
                                DateTime dtFechaVigenciaFin = new DateTime();

                                splashScreenManager1.SetWaitFormCaption("Empleados");

                                foreach (DataRow item in dtEmpleadosSeleccionados.Rows)
                                {
                                    iContaVariables++;
                                    splashScreenManager1.SetWaitFormDescription(iContaVariables + " de " + dtEmpleadosSeleccionados.Rows.Count);

                                    int? idVariablesIMSSDetail = 0;
                                    variablesIMSSDetail ovariablesIMSSDetail = new variablesIMSSDetail(item);

                                    actualizacionesIMSSTableAdapter1.stpInsVariablesIMSSDetail(
                                        idVariablesIMSSHeader
                                        , ovariablesIMSSDetail.idEmpleado
                                        , ovariablesIMSSDetail.stNombreCompletoEmpleados
                                        , ovariablesIMSSDetail.stNSS
                                        , ovariablesIMSSDetail.dtFechaIngresoContrato
                                        , ovariablesIMSSDetail.idTenedora
                                        , ovariablesIMSSDetail.stTenedora
                                        , ovariablesIMSSDetail.stRegistroPatronalIMSS
                                        , ovariablesIMSSDetail.dcSalarioDiarioContrato
                                        , ovariablesIMSSDetail.dcSalarioBaseCotizacion
                                        , ovariablesIMSSDetail.dcMontoVariableBimestre
                                        , ovariablesIMSSDetail.iDiasCalculoVariable
                                        , ovariablesIMSSDetail.dcParteVariable
                                        , ovariablesIMSSDetail.dcSalarioBaseCotizacionNuevo
                                        , OperadorBD.OperadorGlobal.IdOperador
                                        , ovariablesIMSSDetail.iAnio
                                        , ovariablesIMSSDetail.iBimestre

                                        , ovariablesIMSSHeader.dtFechaAplicacion
                                        , ovariablesIMSSDetail.dtFechaVigenciaInicio
                                        , ovariablesIMSSDetail.dtFechaVigenciaFin
                                        , false
                                        , ref idVariablesIMSSDetail);

                                    iAnioVariables = ovariablesIMSSDetail.iAnio;
                                    iBimestreVariables = ovariablesIMSSDetail.iBimestre;
                                    dtFechaVigenciaInicio = ovariablesIMSSDetail.dtFechaVigenciaInicio;
                                    dtFechaVigenciaFin = ovariablesIMSSDetail.dtFechaVigenciaFin;
                                }

                                stMensaje = "Proceso Terminado" + Environment.NewLine +
                                    "Solicitud de Variable: " + idVariablesIMSSHeader + Environment.NewLine +
                                    "Empleados: " + iContaVariables + Environment.NewLine;


                                //***********************************************************
                                //***********************************************************
                                //***********************************************************
                                //Agregano el Complemento de empleados con variable = 0
                                //***********************************************************
                                //***********************************************************
                                //***********************************************************

                                //var uTenedoras = (from r in dtEmpleadosSeleccionados.AsEnumerable()
                                //                  select r["IdTenedora"]).Distinct().ToList();

                                //List<int> lstTenedoras = uTenedoras.Select(s => (int)s).ToList();

                                //foreach (int idTenedora in lstTenedoras)
                                //{
                                //    stpSelComplementoVariablesIMSSTableAdapter1.Fill(dbSAICBPOActualizacionesIMSSDataSet.stpSelComplementoVariablesIMSS
                                //        , idVariablesIMSSHeader
                                //        , idTenedora
                                //        , iAnioVariables
                                //        , iBimestreVariables
                                //        , dtFechaVigenciaInicio
                                //        , dtFechaVigenciaFin
                                //        , OperadorBD.OperadorGlobal.NombreUsuario);
                                //}

                                //**************************************************************************************************
                                //Complemento de los empleados que tienen SBC Actual igual al SBC calculado o nuevo
                                //**************************************************************************************************

                                //obteniendo Empleado con estatus = "SBC Actual es igual SBC Calculado"

                                DataTable dtEmpleadosSBCIgual = new DataTable();
                                int iConta_Complemento = 0;
                                int? iConta_Complemento_Registrados = 0;

                                if (gridControlVariables.Visible)
                                {
                                    var iResult = (from x in dtTodoslosEmpleados_.AsEnumerable()
                                                   where x.Field<String>("Estatus") == "SBC Actual es igual SBC Calculado"
                                                   select x);

                                    if (iResult.Count() > 0)
                                    {
                                        dtEmpleadosSBCIgual = iResult.CopyToDataTable();
                                    }
                                }
                                else if (gridControlPlantilla.Visible)
                                {
                                    //Obteniendo el registro patronal de los empleados Seleccionados
                                    List<String> lstRegistrosPatronales = new List<String>();
                                    var JoinResult = (from X in dtTodoslosEmpleadosParaComplemento_.AsEnumerable()
                                                      join Y in dtEmpleadosSeleccionados.AsEnumerable()
                                                      on X.Field<int>("IdEmpleado") equals Y.Field<int>("IdEmpleado")
                                                      select new
                                                      {
                                                          RegistroPatronal = X.Field<String>("RegistroPatronalIMSS")
                                                      }).ToList().Distinct();

                                    if (JoinResult.Count() > 0)
                                    {
                                        foreach (var item in JoinResult)
                                        {
                                            lstRegistrosPatronales.Add(item.RegistroPatronal.ToString());
                                        }

                                        DataTable dtEmpleadosConRegistroPatronal = new DataTable();

                                        //Del mundo de empleados se obtienen todos los empleados de los registros patronales de los empleados seleccionados
                                        foreach (String itemRegistroPatronal in lstRegistrosPatronales)
                                        {
                                            var iRes = (from x in dtTodoslosEmpleadosParaComplemento_.AsEnumerable()
                                                        where x.Field<String>("RegistroPatronalIMSS").Equals(itemRegistroPatronal)
                                                        select x);
                                            if (iRes.Count() > 0)
                                            {
                                                dtEmpleadosConRegistroPatronal.Merge(iRes.CopyToDataTable());
                                            }
                                        }

                                        //Obteniendo la diferencia de empleados: de los empleados seleccionadaos vs los empleados en el registro patronal
                                        DataTable dtRes = new DataTable();

                                        var iResDiferencia = dtEmpleadosConRegistroPatronal.AsEnumerable()
                                           .Where(r => !dtEmpleadosSeleccionados.AsEnumerable().Any(w => w.Field<int>("IdEmpleado") == r.Field<int>("IdEmpleado")));

                                        if (iResDiferencia.Count() > 0)
                                        {
                                            dtRes = iResDiferencia.CopyToDataTable<DataRow>();

                                            //DataTable dtRes1 = new DataTable();
                                            //var iRes1 = (from x in dtRes.AsEnumerable()
                                            //             where x.Field<String>("Estatus").Equals("SBC Actual es igual SBC Calculado")
                                            //             select x);

                                            //if (iRes1.Count() > 0)
                                            //{
                                            //    dtRes1 = iRes1.CopyToDataTable();
                                            //    dtEmpleadosSBCIgual = dtRes1;
                                            //}

                                            dtEmpleadosSBCIgual = dtRes;
                                        }

                                    }
                                }

                                if (dtEmpleadosSBCIgual.Rows.Count > 0)
                                {

                                    splashScreenManager1.SetWaitFormCaption("Complemento");

                                    foreach (DataRow item in dtEmpleadosSBCIgual.Rows)
                                    {
                                        int? iResultado = 0;
                                        iConta_Complemento++;
                                        splashScreenManager1.SetWaitFormDescription(iConta_Complemento + " de " + dtEmpleadosSBCIgual.Rows.Count);
                                        int idEmpleado = 0;
                                        int.TryParse(item["IdEmpleado"].ToString(), out idEmpleado);

                                        int idTenedora = 0;
                                        int.TryParse(item["IdTenedora"].ToString(), out idTenedora);

                                        decimal dparteVariable = 0;
                                        if (gridControlVariables.Visible)
                                        {
                                            decimal.TryParse(item["ParteVariable"].ToString(), out dparteVariable);
                                        }

                                        actualizacionesIMSSTableAdapter1.stpInsComplementoVariablesIMSS_1(
                                            idVariablesIMSSHeader
                                            , idEmpleado
                                            , idTenedora
                                            , iAnioVariables
                                            , iBimestreVariables
                                            , dtFechaVigenciaInicio
                                            , dtFechaVigenciaFin
                                            , OperadorBD.OperadorGlobal.NombreUsuario
                                            , dparteVariable
                                            , ref iResultado);

                                        iConta_Complemento_Registrados = iConta_Complemento_Registrados + iResultado;
                                    }

                                    stMensaje += "Complemento: " + iConta_Complemento_Registrados + Environment.NewLine;
                                }

                                //***********************************************************
                                //***********************************************************
                                //***********************************************************
                                //Agregano el Complemento de empleados con variable = 0
                                //***********************************************************
                                //***********************************************************
                                //***********************************************************


                                //Ingresando la solicitud de Aniversario

                                //obteniendo empleados que no tengan algun error
                                DataTable dtEmpleados = new DataTable();
                                int iConta_Aniversario = 0;

                                if (gridControl1Aniversarios.Visible)
                                {
                                    dtEmpleados = dsc.deGridViewaDataTable(gridView3Aniversarios);
                                }
                                else if (gridControlPlantillaAniversario.Visible)
                                {
                                    dtEmpleados = dsc.deGridViewaDataTable(gridViewPlantillaAniversario);
                                }

                                var queryResult = (from x in dtEmpleados.AsEnumerable()
                                                   where String.IsNullOrEmpty(x.Field<String>("Errores"))
                                                   select x);

                                if (queryResult.Count() > 0)
                                {
                                    DataTable dtEmpleadosAniversario = queryResult.CopyToDataTable();

                                    if (dtEmpleadosAniversario.Rows.Count > 0)
                                    {

                                        //******************************************************
                                        //Buscando al empleado en la consulta de Variables
                                        //******************************************************
                                        int idEmpleado = 0;
                                        int iLugarEmpleadoVariable = 0;

                                        decimal dcMontoVariableBimestre = 0;
                                        int iDiasDeCalculo = 0;
                                        decimal dcParteVariable = 0;

                                        splashScreenManager1.SetWaitFormCaption("Aniversario");

                                        foreach (DataRow item in dtEmpleadosAniversario.Rows)
                                        {
                                            iConta_Aniversario++;
                                            splashScreenManager1.SetWaitFormDescription(iConta_Aniversario + " de " + dtEmpleadosAniversario.Rows.Count);

                                            if (gridControlVariables.Visible)//Buscando si los empleados fueron desde el boton de CONSULTAR
                                            {
                                                int.TryParse(item["idEmpleado"].ToString(), out idEmpleado);
                                                iLugarEmpleadoVariable = gridViewvariables.LocateByValue("IdEmpleado", idEmpleado);

                                                if (iLugarEmpleadoVariable >= 0)
                                                {
                                                    decimal.TryParse(gridViewvariables.GetDataRow(iLugarEmpleadoVariable)["MontoVariablesBimestre"].ToString(), out dcMontoVariableBimestre);
                                                    int.TryParse(gridViewvariables.GetDataRow(iLugarEmpleadoVariable)["DiasCalculoVariables"].ToString(), out iDiasDeCalculo);
                                                    decimal.TryParse(gridViewvariables.GetDataRow(iLugarEmpleadoVariable)["ParteVariable"].ToString(), out dcParteVariable);
                                                }
                                            }
                                            else if (gridControlPlantilla.Visible)//Buscando, su la busqueda fue con plantilla
                                            {
                                                int.TryParse(item["idEmpleado"].ToString(), out idEmpleado);
                                                iLugarEmpleadoVariable = gridViewPlantilla.LocateByValue("IdEmpleado", idEmpleado);

                                                if (iLugarEmpleadoVariable >= 0)
                                                {
                                                    decimal.TryParse(gridViewPlantilla.GetDataRow(iLugarEmpleadoVariable)["MontoVariablesBimestre"].ToString(), out dcMontoVariableBimestre);
                                                    int.TryParse(gridViewPlantilla.GetDataRow(iLugarEmpleadoVariable)["DiasCalculoVariables"].ToString(), out iDiasDeCalculo);
                                                    decimal.TryParse(gridViewPlantilla.GetDataRow(iLugarEmpleadoVariable)["ParteVariable"].ToString(), out dcParteVariable);
                                                }
                                            }

                                            variablesIMSSDetail ovariablesIMSSDetail = new variablesIMSSDetail();
                                            ovariablesIMSSDetail = ovariablesIMSSDetail.deAniversarioToVaribles(item, ovariablesIMSSHeader.iAnio, ovariablesIMSSHeader.iBimestre, dcMontoVariableBimestre, iDiasDeCalculo, dcParteVariable, ovariablesIMSSHeader.dtFechaVigenciaInicio, ovariablesIMSSHeader.dtFechaVigenciaFin);

                                            int? idVariablesIMSSDetail = 0;
                                            actualizacionesIMSSTableAdapter1.stpInsVariablesIMSSDetail(
                                          idVariablesIMSSHeader
                                          , ovariablesIMSSDetail.idEmpleado
                                          , ovariablesIMSSDetail.stNombreCompletoEmpleados
                                          , ovariablesIMSSDetail.stNSS
                                          , ovariablesIMSSDetail.dtFechaIngresoContrato
                                          , ovariablesIMSSDetail.idTenedora
                                          , ovariablesIMSSDetail.stTenedora
                                          , ovariablesIMSSDetail.stRegistroPatronalIMSS
                                          , ovariablesIMSSDetail.dcSalarioDiarioContrato
                                          , ovariablesIMSSDetail.dcSalarioBaseCotizacion
                                          , ovariablesIMSSDetail.dcMontoVariableBimestre
                                          , ovariablesIMSSDetail.iDiasCalculoVariable
                                          , ovariablesIMSSDetail.dcParteVariable
                                          , ovariablesIMSSDetail.dcSalarioBaseCotizacionNuevo
                                          , OperadorBD.OperadorGlobal.IdOperador
                                          , ovariablesIMSSDetail.iAnio
                                          , ovariablesIMSSDetail.iBimestre

                                          , ovariablesIMSSHeader.dtFechaAplicacion
                                          , ovariablesIMSSDetail.dtFechaVigenciaInicio
                                          , ovariablesIMSSDetail.dtFechaVigenciaFin
                                          , true
                                          , ref idVariablesIMSSDetail);

                                        }


                                        stMensaje += "Aniversario: " + iConta_Aniversario;

                                    }
                                }
                                else
                                {
                                    ovariablesIMSSHeader.stNombreVaribleIMSS = String.Empty;
                                }

                                if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }

                                XtraMessageBox.Show(stMensaje, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                if (gridControlVariables.Visible)
                                {
                                    ConsultarEmpleadosVaribles();
                                }
                                else if (gridControlPlantilla.Visible)
                                {
                                    DataTable dtTodoslosEmpleados = dsc.deGridViewaDataTable(gridViewPlantilla);

                                    DateTime dtFechaAplicacion = new DateTime();
                                    DateTime dtFechaIniVigenciaParteVariable = new DateTime();
                                    DateTime dtFechaFinVigenciaParteVariable = new DateTime();

                                    DateTime.TryParse(txtFechaAplicacion.Text, out dtFechaAplicacion);
                                    DateTime.TryParse(txtFechaVigenciaInicio.Text, out dtFechaIniVigenciaParteVariable);
                                    DateTime.TryParse(txtFechaVigenciaFin.Text, out dtFechaFinVigenciaParteVariable);

                                    validarInformacionLayOut(dtTodoslosEmpleados, ovariablesIMSSHeader.iAnio, ovariablesIMSSHeader.iBimestre, dtFechaAplicacion, dtFechaIniVigenciaParteVariable, dtFechaFinVigenciaParteVariable);
                                }
                            }
                        }
                        else
                        {
                            XtraMessageBox.Show("Seleccione un Empleado para Continuar", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    XtraMessageBox.Show("Seleccione un Empleado para Continuar", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }
                XtraMessageBox.Show("Error en el proceso de Solicitud de Variables. " + ex.Message, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        Boolean flagTodos = false;
        private void gridViewvariables_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (!flagSeleccinarPorBoton && !flagTodos)
            {
                if (e.ControllerRow > -1)
                {
                    if (gridViewvariables.GetDataRow(e.ControllerRow)["Estatus"].ToString() != "Aplica modificacion SBC")
                    {
                        try
                        {
                            gridViewvariables.UnselectRow(e.ControllerRow);
                        }
                        catch (Exception) { }
                    }
                }
                else
                {
                    flagTodos = true;
                    for (int i = 0; i < gridViewvariables.RowCount; i++)
                    {
                        if (gridViewvariables.GetDataRow(i)["Estatus"].ToString() != "Aplica modificacion SBC")
                        {
                            gridViewvariables.UnselectRow(i);
                        }
                    }
                    flagTodos = false;
                }
            }


            //for (int i = 0; i < gridViewvariables.RowCount; i++)
            //{
            //    try
            //    {
            //        gridViewvariables.UnselectRow(i);
            //    }
            //    catch (Exception) { }
            //}

            txtEmpleadosSeleccionados.Text = gridViewvariables.SelectedRowsCount.ToString();
        }

        private void todoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String ruta = dsc.ObtenerRutaSolicitud(6, 2) + "Variables " + gridLookUpEditAnio.EditValue.ToString() + "-" + gridLookUpEditBimestre.EditValue.ToString() + dsc.nombreAleatorio() + ".xlsx";
            String rutaAniversario = dsc.ObtenerRutaSolicitud(6, 2) + "Variables-Aniversario " + gridLookUpEditAnio.EditValue.ToString() + "-" + gridLookUpEditBimestre.EditValue.ToString() + dsc.nombreAleatorio() + ".xlsx";
            dsc.CheckandCreateFolder(dsc.ObtenerRutaSolicitud(6, 2));

            if (gridControlVariables.Visible)
            {
                gridViewvariables.ExportToXlsx(ruta);
            }
            else if (gridControlPlantilla.Visible)
            {
                gridControlPlantilla.ExportToXlsx(ruta);
            }

            if (gridControl1Aniversarios.Visible)
            {
                gridView3Aniversarios.ExportToXlsx(rutaAniversario);
            }
            else if (gridControlPlantillaAniversario.Visible)
            {
                gridViewPlantillaAniversario.ExportToXlsx(rutaAniversario);
            }

            XtraMessageBox.Show("Documento Descargado. Ruta: " + ruta, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void porRegistroPatronalToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DataTable dtEmpleados = new DataTable();

            if (gridControlVariables.Visible)
            {
                dtEmpleados = dbSAICBPOActualizacionesIMSSDataSet.stpSelEmpleadosVariablesIMSS;
            }
            else if (gridControlPlantilla.Visible)
            {
                dtEmpleados = dtVariblesXPlantilla;
            }

            if (dtEmpleados.Rows.Count > 0)
            {
                DialogResult oDialogResult = XtraMessageBox.Show("¿Desea descargar " + txtRegistrosPatronales.Text + "?"
                    , "SAIC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (DialogResult.Yes == oDialogResult)
                {
                    List<String> lstRegistrosPatronales = new List<String>();

                    var result = (from r in dtEmpleados.AsEnumerable()
                                  select r["RegistroPatronalIMSS"]).Distinct().ToList();

                    if (result.Count() > 0)
                    {
                        lstRegistrosPatronales = result.Select(s => (String)s).ToList();
                        dsc.CheckandCreateFolder(dsc.ObtenerRutaSolicitud(6, 2));
                        foreach (String sRegistroPatronal in lstRegistrosPatronales)
                        {
                            String stRutaDocumento = dsc.ObtenerRutaSolicitud(6, 2) + "Variables " + sRegistroPatronal + " " + gridLookUpEditAnio.EditValue.ToString() + "-" + gridLookUpEditBimestre.EditValue.ToString() + ".xlsx";
                            dsc.CheckandCreateFolder(dsc.ObtenerRutaSolicitud(6, 2));

                            DataTable dtDatosregistroPatronal = (from x in dtEmpleados.AsEnumerable()
                                                                 where x.Field<String>("RegistroPatronalIMSS").Equals(sRegistroPatronal)
                                                                 select x).CopyToDataTable();

                            gridControlFiltro.Visible = true;
                            gridControlFiltro.DataSource = dtDatosregistroPatronal;
                            gridControlFiltro.ExportToXlsx(stRutaDocumento);
                            gridControlFiltro.Visible = false;
                        }

                        XtraMessageBox.Show(lstRegistrosPatronales.Count + " Archivos Descargados en la ruta: " + dsc.ObtenerRutaSolicitud(6, 2), "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

        }

        private void btnSubirPlantilla_Click(object sender, EventArgs e)
        {
            sTipoSolicitud = "PLANTILLA";
            int iAnio = 0;
            int iBimestre = 0;

            int.TryParse(gridLookUpEditAnio.EditValue.ToString(), out iAnio);
            int.TryParse(gridLookUpEditBimestre.EditValue.ToString(), out iBimestre);

            if (iAnio > 0 && iBimestre > 0)
            {
                OpenFileDialog ofdSelecFile = new OpenFileDialog();
                ofdSelecFile.Filter = "Excel Files (*.xls;*.xlsm;*.xlsb;*.xlsx)|*.xls;*.xlsm;*.xlsb;*.xlsx";
                ofdSelecFile.ShowDialog();

                if (!String.IsNullOrEmpty(ofdSelecFile.FileName))
                {
                    splashScreenManager1.ShowWaitForm();

                    DataTable dtArchivoEmpleado = dsc.ConvertExcelToDataTable(ofdSelecFile.FileName, "F");
                    dtArchivoEmpleado = quitarVacios(dtArchivoEmpleado);

                    if (dtArchivoEmpleado.Rows.Count > 0)
                    {
                        String stLasColumnasArchivo = String.Empty;

                        foreach (DataColumn item in dtArchivoEmpleado.Columns) { stLasColumnasArchivo += item.ColumnName; }

                        if (dsc.fonetica(TitulosExcelParaValidacion(), stLasColumnasArchivo))
                        {

                            DateTime dtFechaAplicacion = new DateTime();
                            DateTime dtFechaIniVigenciaParteVariable = new DateTime();
                            DateTime dtFechaFinVigenciaParteVariable = new DateTime();

                            DateTime.TryParse(txtFechaAplicacion.Text, out dtFechaAplicacion);
                            DateTime.TryParse(txtFechaVigenciaInicio.Text, out dtFechaIniVigenciaParteVariable);
                            DateTime.TryParse(txtFechaVigenciaFin.Text, out dtFechaFinVigenciaParteVariable);

                            validarInformacionLayOut(dtArchivoEmpleado, iAnio, iBimestre, dtFechaAplicacion, dtFechaIniVigenciaParteVariable, dtFechaFinVigenciaParteVariable);
                            if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }
                        }
                        else
                        {
                            if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }
                            XtraMessageBox.Show("El Archivo No cuenta con la estructura correcta."
                              , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }
                        XtraMessageBox.Show("El Archivo No cuenta con informacion."
                          , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            else
            {
                XtraMessageBox.Show("Seleccione un año y bimestre para continuar.", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        DataTable dtVariblesXPlantilla;

        private void validarInformacionLayOut(DataTable dtArchivoEmpleado, int iAnio, int iBimestre, DateTime dtFechaAplicacion, DateTime dtFechaIniVigenciaParteVariable, DateTime dtFechaFinVigenciaParteVariable)
        {
            DataTable dtEmpleadosvariablesPlantilla = dbSAICBPOActualizacionesIMSSDataSet.stpSelEmpleadosVariablesIMSS.Clone();
            //dtEmpleadosvariablesPlantilla.Columns.Remove("Parte Variable");

            foreach (DataRow unRowEmpleado in dtArchivoEmpleado.Rows)
            {
                DataRow unRow = dtEmpleadosvariablesPlantilla.NewRow();
                String stErrores = String.Empty;
                String stNombreColumnaIdEmpleado = String.Empty;
                String stNombreColumnaIdNombre = String.Empty;
                String stNombreColumnaParteVariable = String.Empty;

                int idEmpleado = 0;

                if (dtArchivoEmpleado.Columns.Contains("IdEmpleado"))
                {
                    stNombreColumnaIdEmpleado = "IdEmpleado";
                    stNombreColumnaIdNombre = "NombreEmpleadoCompleto";
                }
                else
                {
                    stNombreColumnaIdEmpleado = "Id Empleado";
                    stNombreColumnaIdNombre = "Nombre Empleado Completo";
                }

                if (dtArchivoEmpleado.Columns.Contains("Parte Variable"))
                {
                    stNombreColumnaParteVariable = "Parte Variable";
                }
                else
                {
                    stNombreColumnaParteVariable = "ParteVariable";
                }

                int.TryParse(unRowEmpleado[stNombreColumnaIdEmpleado].ToString(), out idEmpleado);

                unRow["IdEmpleado"] = unRowEmpleado[stNombreColumnaIdEmpleado];
                unRow["NombreEmpleadoCompleto"] = unRowEmpleado[stNombreColumnaIdNombre];
                unRow["NSS"] = unRowEmpleado["NSS"];
                unRow["RFC"] = unRowEmpleado["RFC"];
                unRow["CURP"] = unRowEmpleado["CURP"];

                decimal dcParteVariable = 0;
                String stMensajeVariables = String.Empty;
                if (!decimal.TryParse(unRowEmpleado[stNombreColumnaParteVariable].ToString(), out dcParteVariable))
                {
                    stMensajeVariables = ", Importe de Varibles no es Numerico";
                }

                decimal.TryParse(unRowEmpleado[stNombreColumnaParteVariable].ToString(), out dcParteVariable);

                stpSelEmpleadosVariablesIMSSTableAdapter.Fill(dbSAICBPOActualizacionesIMSSDataSet.stpSelEmpleadosVariablesIMSS
                    , idEmpleado
                    , unRowEmpleado["NSS"].ToString()
                    , unRowEmpleado["RFC"].ToString()
                    , unRowEmpleado["CURP"].ToString()
                    , iAnio
                    , iBimestre
                    , dtFechaAplicacion
                    , dtFechaIniVigenciaParteVariable
                    , dtFechaFinVigenciaParteVariable
                    , true
                    , dcParteVariable
                    , ref stErrores);

                if (!String.IsNullOrEmpty(stErrores) || dbSAICBPOActualizacionesIMSSDataSet.stpSelEmpleadosVariablesIMSS.Rows.Count == 0)
                {
                    unRow["IdTenedora"] = 0;
                    unRow["Tenedora"] = String.Empty;
                    unRow["RegistroPatronalIMSS"] = String.Empty;
                    unRow["FechaIngresoContrato"] = new DateTime(1900, 01, 01);

                    unRow["Salario Diario Actual"] = 0;
                    unRow["Salario Base de Cotizacion Actual"] = 0;

                    unRow["AnoBimestre"] = 0;
                    unRow["Bimestre"] = 0;
                    unRow["FechaIniVigenciaParteVariable"] = new DateTime(1900, 01, 01);
                    unRow["FechaFinVigenciaParteVariable"] = new DateTime(1900, 01, 01);
                    unRow["DiasCalculoVariables"] = 0;
                    unRow["MontoVariablesBimestre"] = 0;
                    unRow["ParteVariable"] = 0;
                    unRow["Salario Base de Cotizacion Nuevo"] = 0;
                    unRow["Estatus"] = !String.IsNullOrEmpty(stErrores) ? stErrores : "Sin resultado para Empleado.";
                }
                else
                {
                    unRow["IdTenedora"] = dbSAICBPOActualizacionesIMSSDataSet.stpSelEmpleadosVariablesIMSS.Rows[0]["IdTenedora"];
                    unRow["Tenedora"] = dbSAICBPOActualizacionesIMSSDataSet.stpSelEmpleadosVariablesIMSS.Rows[0]["Tenedora"];
                    unRow["RegistroPatronalIMSS"] = dbSAICBPOActualizacionesIMSSDataSet.stpSelEmpleadosVariablesIMSS.Rows[0]["RegistroPatronalIMSS"];
                    unRow["FechaIngresoContrato"] = dbSAICBPOActualizacionesIMSSDataSet.stpSelEmpleadosVariablesIMSS.Rows[0]["FechaIngresoContrato"];

                    unRow["Salario Diario Actual"] = dbSAICBPOActualizacionesIMSSDataSet.stpSelEmpleadosVariablesIMSS.Rows[0]["Salario Diario Actual"];
                    unRow["Salario Base de Cotizacion Actual"] = dbSAICBPOActualizacionesIMSSDataSet.stpSelEmpleadosVariablesIMSS.Rows[0]["Salario Base de Cotizacion Actual"];
                    unRow["Factor de Integracion"] = dbSAICBPOActualizacionesIMSSDataSet.stpSelEmpleadosVariablesIMSS.Rows[0]["Factor de Integracion"];
                    unRow["Salario Base de Cotizacion Real"] = dbSAICBPOActualizacionesIMSSDataSet.stpSelEmpleadosVariablesIMSS.Rows[0]["Salario Base de Cotizacion Real"];

                    unRow["AnoBimestre"] = dbSAICBPOActualizacionesIMSSDataSet.stpSelEmpleadosVariablesIMSS.Rows[0]["AnoBimestre"];
                    unRow["Bimestre"] = dbSAICBPOActualizacionesIMSSDataSet.stpSelEmpleadosVariablesIMSS.Rows[0]["Bimestre"];
                    unRow["FechaIniVigenciaParteVariable"] = dbSAICBPOActualizacionesIMSSDataSet.stpSelEmpleadosVariablesIMSS.Rows[0]["FechaIniVigenciaParteVariable"];
                    unRow["FechaFinVigenciaParteVariable"] = dbSAICBPOActualizacionesIMSSDataSet.stpSelEmpleadosVariablesIMSS.Rows[0]["FechaFinVigenciaParteVariable"];
                    unRow["DiasCalculoVariables"] = dbSAICBPOActualizacionesIMSSDataSet.stpSelEmpleadosVariablesIMSS.Rows[0]["DiasCalculoVariables"];
                    unRow["MontoVariablesBimestre"] = dbSAICBPOActualizacionesIMSSDataSet.stpSelEmpleadosVariablesIMSS.Rows[0]["MontoVariablesBimestre"];
                    unRow["ParteVariable"] = dbSAICBPOActualizacionesIMSSDataSet.stpSelEmpleadosVariablesIMSS.Rows[0]["ParteVariable"];
                    unRow["Salario Base de Cotizacion Nuevo"] = dbSAICBPOActualizacionesIMSSDataSet.stpSelEmpleadosVariablesIMSS.Rows[0]["Salario Base de Cotizacion Nuevo"];
                    unRow["Estatus"] = dbSAICBPOActualizacionesIMSSDataSet.stpSelEmpleadosVariablesIMSS.Rows[0]["Estatus"] + stMensajeVariables;
                }

                dtEmpleadosvariablesPlantilla.Rows.Add(unRow);
            }

            gridControlVariables.Visible = false;
            gridControlVariables.Dock = DockStyle.None;

            gridControlPlantilla.Visible = true;
            gridControlPlantilla.Dock = DockStyle.Fill;

            txtTotalDeEmpleados.Text = dtEmpleadosvariablesPlantilla.Rows.Count.ToString();

            txtRegistrosPatronales.Text = (from r in dtEmpleadosvariablesPlantilla.AsEnumerable()
                                           select r["RegistroPatronalIMSS"]).Distinct().ToList().Count.ToString();

            txtEmpleadosValidos.Text = (from x in dtEmpleadosvariablesPlantilla.AsEnumerable()
                                        where x.Field<String>("Estatus") == "Aplica modificacion SBC"
                                        select x["RegistroPatronalIMSS"]).ToList().Count.ToString();

            txtEmpleadosConError.Text = (from x in dtEmpleadosvariablesPlantilla.AsEnumerable()
                                         where x.Field<String>("Estatus") != "Aplica modificacion SBC"
                                         select x["RegistroPatronalIMSS"]).ToList().Count.ToString();

            gridControlPlantilla.DataSource = dtEmpleadosvariablesPlantilla;
            dtVariblesXPlantilla = dtEmpleadosvariablesPlantilla;
            ovariablesIMSSHeader = obtenerInfoVariablesIMSSHeader();

            //obteniendo empleados de aniversario
            obtenerEmpleadosDeAniversario(ovariablesIMSSHeader.dtFechaAplicacion, ovariablesIMSSHeader.iAnio, ovariablesIMSSHeader.iBimestre, true);

            gridLookUpEditAnio.Enabled = false;
            gridLookUpEditBimestre.Enabled = false;
        }


        private DataTable quitarVacios(DataTable dtArchivoEmpleado)
        {
            DataTable dtResutado = new DataTable();
            dtResutado = dtArchivoEmpleado.Clone();

            var res = from x in dtArchivoEmpleado.AsEnumerable()
                      where x.Field<String>("Id Empleado") != ""
                      select x;

            if (res.Count() > 0)
            {
                dtResutado = res.CopyToDataTable();
            }

            return dtResutado;
        }

        private void gridViewPlantilla_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            for (int i = 0; i < gridViewPlantilla.RowCount; i++)
            {
                if (gridViewPlantilla.GetDataRow(i)["Estatus"].ToString() != "Aplica modificacion SBC")
                {
                    gridViewPlantilla.UnselectRow(i);
                }
            }

            txtEmpleadosSeleccionados.Text = gridViewPlantilla.SelectedRowsCount.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gridLookUpEditAnio.Enabled = true;
            gridLookUpEditBimestre.Enabled = true;

            String stErrores = String.Empty;
            stpSelEmpleadosVariablesIMSSTableAdapter.Fill(dbSAICBPOActualizacionesIMSSDataSet.stpSelEmpleadosVariablesIMSS
                , 0
                , String.Empty
                , String.Empty
                , String.Empty
                , 0
                , 0
                , new DateTime()
                , new DateTime()
                , new DateTime()
                , false
                , 0
                , ref stErrores);

            gridControlPlantilla.Visible = false;
            gridControlVariables.Visible = false;
            gridControl1Aniversarios.Visible = false;
            gridControlPlantillaAniversario.Visible = false;
        }

        private void obtenerEmpleadosDeAniversario(DateTime dtFechaAplicacion, int iAnio, int iBimestre, Boolean flagValidacionConPlantilla)
        {

            //********************************************
            //obtener aniversario empleados
            //********************************************
            String sRespuesta = String.Empty;
            stpSelObtenerInfoEmpleadosAniversariosTableAdapter.Fill(dbSAICBPOActualizacionesIMSSDataSet.stpSelObtenerInfoEmpleadosAniversarios
               , dtFechaAplicacion
               , 0
               , String.Empty
               , String.Empty
               , String.Empty
               , true
               , iAnio
               , iBimestre
               , 0
               , ref sRespuesta);

            DataTable tempVariable = dsc.deGridViewaDataTable(gridViewvariables);

            DataTable dtEmpleadosConAniversario = dbSAICBPOActualizacionesIMSSDataSet.stpSelObtenerInfoEmpleadosAniversarios.Clone();
            foreach (DataRow item in dbSAICBPOActualizacionesIMSSDataSet.stpSelObtenerInfoEmpleadosAniversarios)
            {
                int idEmpleadoAniversario = 0;
                int iLugarEmpleadoVariable = 0;
                int.TryParse(item["IdEmpleado"].ToString(), out idEmpleadoAniversario);

                if (!flagValidacionConPlantilla)
                {
                    iLugarEmpleadoVariable = gridViewvariables.LocateByValue("IdEmpleado", idEmpleadoAniversario);
                }
                else
                {
                    iLugarEmpleadoVariable = gridViewPlantilla.LocateByValue("IdEmpleado", idEmpleadoAniversario);
                }

                if (iLugarEmpleadoVariable >= 0)
                {
                    if (!flagValidacionConPlantilla)
                    {
                        gridViewvariables.GetDataRow(iLugarEmpleadoVariable)["Estatus"] = "Aplica para Solicitud de Aniversario";
                    }
                    else
                    {
                        gridViewPlantilla.GetDataRow(iLugarEmpleadoVariable)["Estatus"] = "Aplica para Solicitud de Aniversario";
                    }

                    if (flagValidacionConPlantilla)
                    {
                        decimal dcVariable = 0;
                        decimal.TryParse(gridViewPlantilla.GetDataRow(iLugarEmpleadoVariable)["ParteVariable"].ToString(), out dcVariable);
                        stpSelObtenerInfoEmpleadosAniversarios1TableAdapter1.Fill(dbSAICBPOActualizacionesIMSSDataSet.stpSelObtenerInfoEmpleadosAniversarios1
                                    , dtFechaAplicacion
                                    , idEmpleadoAniversario
                                    , item["NSS"].ToString()
                                    , item["RFC"].ToString()
                                    , item["CURP"].ToString()
                                    , true
                                    , iAnio
                                    , iBimestre
                                    , dcVariable
                                    , ref sRespuesta);

                        if (dbSAICBPOActualizacionesIMSSDataSet.stpSelObtenerInfoEmpleadosAniversarios1.Rows.Count > 0)
                        {
                            dtEmpleadosConAniversario.ImportRow(dbSAICBPOActualizacionesIMSSDataSet.stpSelObtenerInfoEmpleadosAniversarios1.Rows[0]);
                        }
                    }
                }
                else
                {
                    dtEmpleadosConAniversario.ImportRow(item);
                }
            }

            //gridControlPlnatillaAniversarios.DataSource = dtEmpleadosConAniversario;
            if (!flagValidacionConPlantilla)
            {
                gridControlPlantillaAniversario.Visible = false;
                gridControlPlantillaAniversario.Dock = DockStyle.None;

                gridControl1Aniversarios.Visible = true;
                gridControl1Aniversarios.Dock = DockStyle.Fill;

            }
            else
            {
                gridControl1Aniversarios.Visible = false;
                gridControl1Aniversarios.Dock = DockStyle.None;

                gridControlPlantillaAniversario.Visible = true;
                gridControlPlantillaAniversario.Dock = DockStyle.Fill;
                gridControlPlantillaAniversario.DataSource = dtEmpleadosConAniversario;

            }

            txtEmpleadosAniversario.Text = dbSAICBPOActualizacionesIMSSDataSet.stpSelObtenerInfoEmpleadosAniversarios.Rows.Count.ToString();
            txtRPAniversarios.Text = (from r in dbSAICBPOActualizacionesIMSSDataSet.stpSelObtenerInfoEmpleadosAniversarios.AsEnumerable()
                                      select r["RegistroPatronalIMSS"]).Distinct().ToList().Count.ToString();

            txtAniversarioEmpleadosValidos.Text = (from x in dbSAICBPOActualizacionesIMSSDataSet.stpSelObtenerInfoEmpleadosAniversarios.AsEnumerable()
                                                   where String.IsNullOrEmpty(x.Field<String>("Errores"))
                                                   select x["RegistroPatronalIMSS"]).ToList().Count.ToString();

            txtAniversarioEmpleadoConError.Text = (from x in dbSAICBPOActualizacionesIMSSDataSet.stpSelObtenerInfoEmpleadosAniversarios.AsEnumerable()
                                                   where !String.IsNullOrEmpty(x.Field<String>("Errores"))
                                                   select x["RegistroPatronalIMSS"]).ToList().Count.ToString();
        }

        private void labelControl16_Click(object sender, EventArgs e)
        {

        }

        private void txtAniversarioEmpleadoConError_EditValueChanged(object sender, EventArgs e)
        {

        }


        Boolean flagSeleccinarPorBoton = false;

        private void btnSeleccionarTodos_Click(object sender, EventArgs e)
        {
            flagSeleccinarPorBoton = true;
            if (gridControlVariables.Visible)
            {
                gridViewvariables.SelectAll();
                for (int i = 0; i < gridViewvariables.RowCount; i++)
                {
                    if (gridViewvariables.GetDataRow(i)["Estatus"].ToString() != "Aplica modificacion SBC")
                    {
                        try
                        {
                            gridViewvariables.UnselectRow(i);
                        }
                        catch (Exception) { }
                    }
                }
            }
            else if (gridControlPlantilla.Visible)
            {
                gridViewPlantilla.SelectAll();
                for (int i = 0; i < gridViewPlantilla.RowCount; i++)
                {
                    if (gridViewPlantilla.GetDataRow(i)["Estatus"].ToString() != "Aplica modificacion SBC")
                    {
                        try
                        {
                            gridViewPlantilla.UnselectRow(i);
                        }
                        catch (Exception) { }
                    }
                }
            }
            flagSeleccinarPorBoton = false;
        }

        private void btnDeseleccionar_Click(object sender, EventArgs e)
        {
            flagSeleccinarPorBoton = true;
            if (gridControlVariables.Visible)
            {
                for (int i = 0; i < gridViewvariables.RowCount; i++)
                {
                    gridViewvariables.UnselectRow(i);
                }
            }
            else if (gridControlPlantilla.Visible)
            {
                for (int i = 0; i < gridViewPlantilla.RowCount; i++)
                {
                    gridViewPlantilla.UnselectRow(i);
                }
            }
            flagSeleccinarPorBoton = false;
        }
    }


    public class variablesIMSSHeader
    {
        public String stNombreVaribleIMSS { get; set; }
        public int iAnio { get; set; }
        public int iBimestre { get; set; }
        public DateTime dtFechaAplicacion { get; set; }
        public DateTime dtFechaVigenciaFin { get; set; }
        public DateTime dtFechaVigenciaInicio { get; set; }
        public int? idVariablesIMSSHeader { get; set; }

    }

    public class variablesIMSSDetail
    {
        public int idEmpleado { get; set; }
        public String stNombreCompletoEmpleados { get; set; }
        public String stNSS { get; set; }
        public DateTime dtFechaIngresoContrato { get; set; }
        public int idTenedora { get; set; }
        public String stTenedora { get; set; }
        public String stRegistroPatronalIMSS { get; set; }
        public decimal dcSalarioDiarioContrato { get; set; }
        public decimal dcSalarioBaseCotizacion { get; set; }
        public decimal dcMontoVariableBimestre { get; set; }
        public int iDiasCalculoVariable { get; set; }
        public decimal dcParteVariable { get; set; }
        public decimal dcSalarioBaseCotizacionNuevo { get; set; }
        public int iAnio { get; set; }
        public int iBimestre { get; set; }


        public DateTime dtFechaAplicacion { get; set; }
        public DateTime dtFechaVigenciaInicio { get; set; }
        public DateTime dtFechaVigenciaFin { get; set; }

        public variablesIMSSDetail()
        {
            idEmpleado = 0;
            stNombreCompletoEmpleados = String.Empty;
            stNSS = String.Empty;
            dtFechaIngresoContrato = new DateTime(1900, 01, 01);
            idTenedora = 0;
            stTenedora = String.Empty;
            stRegistroPatronalIMSS = String.Empty;
            dcSalarioDiarioContrato = 0;
            dcSalarioBaseCotizacion = 0;
            dcMontoVariableBimestre = 0;
            iDiasCalculoVariable = 0;
            dcParteVariable = 0;
            dcSalarioBaseCotizacionNuevo = 0;
            iAnio = 0;
            iBimestre = 0;
            dtFechaAplicacion = new DateTime(1900, 01, 01);
            dtFechaVigenciaInicio = new DateTime(1900, 01, 01);
            dtFechaVigenciaFin = new DateTime(1900, 01, 01);
        }

        public variablesIMSSDetail(DataRow unRow)
        {
            int idEmpleado = 0;
            int.TryParse(unRow["IdEmpleado"].ToString(), out idEmpleado);
            this.idEmpleado = idEmpleado;

            int iAnio = 0;
            int.TryParse(unRow["AnoBimestre"].ToString(), out iAnio);
            this.iAnio = iAnio;

            int iBimestre = 0;
            int.TryParse(unRow["Bimestre"].ToString(), out iBimestre);
            this.iBimestre = iBimestre;

            stNombreCompletoEmpleados = unRow["NombreEmpleadoCompleto"].ToString();
            stNSS = unRow["NSS"].ToString();

            DateTime dtFechaIngresoContrato = new DateTime();
            DateTime.TryParse(unRow["FechaIngresoContrato"].ToString(), out dtFechaIngresoContrato);
            this.dtFechaIngresoContrato = dtFechaIngresoContrato;

            int idTenedora = 0;
            int.TryParse(unRow["IdTenedora"].ToString(), out idTenedora);
            this.idTenedora = idTenedora;

            stTenedora = unRow["Tenedora"].ToString();
            stRegistroPatronalIMSS = unRow["RegistroPatronalIMSS"].ToString();

            decimal dcSalarioDiarioContrao = 0;
            decimal.TryParse(unRow["Salario Diario Actual"].ToString(), out dcSalarioDiarioContrao);
            this.dcSalarioDiarioContrato = dcSalarioDiarioContrao;

            decimal dcSalarioBaseCotizacion = 0;
            decimal.TryParse(unRow["Salario Base de Cotizacion Actual"].ToString(), out dcSalarioBaseCotizacion);
            this.dcSalarioBaseCotizacion = dcSalarioBaseCotizacion;

            decimal dcMontoVariableBimestre = 0;
            decimal.TryParse(unRow["MontoVariablesBimestre"].ToString(), out dcMontoVariableBimestre);
            this.dcMontoVariableBimestre = dcMontoVariableBimestre;

            int iDiasCalculoVariable = 0;
            int.TryParse(unRow["DiasCalculoVariables"].ToString(), out iDiasCalculoVariable);
            this.iDiasCalculoVariable = iDiasCalculoVariable;

            decimal dcParteVariable = 0;
            decimal.TryParse(unRow["ParteVariable"].ToString(), out dcParteVariable);
            this.dcParteVariable = dcParteVariable;

            decimal dcSalarioBaseCotizacionNuevo = 0;
            decimal.TryParse(unRow["Salario Base de Cotizacion Nuevo"].ToString(), out dcSalarioBaseCotizacionNuevo);
            this.dcSalarioBaseCotizacionNuevo = dcSalarioBaseCotizacionNuevo;

            DateTime dtFechaVigenciaInicio = new DateTime();
            DateTime.TryParse(unRow["FechaIniVigenciaParteVariable"].ToString(), out dtFechaVigenciaInicio);
            this.dtFechaVigenciaInicio = dtFechaVigenciaInicio;

            DateTime dtFechaVigenciaFin = new DateTime();
            DateTime.TryParse(unRow["FechaFinVigenciaParteVariable"].ToString(), out dtFechaVigenciaFin);
            this.dtFechaVigenciaFin = dtFechaVigenciaFin;
        }


        public variablesIMSSDetail deAniversarioToVaribles(DataRow unRowAniversario, int iAnio, int iBimestre, decimal dcMontoVariableBimestre, int iDiasCalculoVariable, decimal dcParteVariable, DateTime dtFechaVigenciaInicio, DateTime dtFechaVigenciaFin)
        {
            variablesIMSSDetail ovariablesIMSSDetail = new variablesIMSSDetail();

            int idEmpleado = 0;
            int.TryParse(unRowAniversario["IdEmpleado"].ToString(), out idEmpleado);
            ovariablesIMSSDetail.idEmpleado = idEmpleado;

            ovariablesIMSSDetail.iAnio = iAnio;
            ovariablesIMSSDetail.iBimestre = iBimestre;

            ovariablesIMSSDetail.stNombreCompletoEmpleados = unRowAniversario["NombreEmpleadoCompleto"].ToString();
            ovariablesIMSSDetail.stNSS = unRowAniversario["NSS"].ToString();

            DateTime dtFechaIngresoContrato = new DateTime();
            DateTime.TryParse(unRowAniversario["FechaIngresoContrato"].ToString(), out dtFechaIngresoContrato);
            ovariablesIMSSDetail.dtFechaIngresoContrato = dtFechaIngresoContrato;

            int idTenedora = 0;
            int.TryParse(unRowAniversario["IdTenedora"].ToString(), out idTenedora);
            ovariablesIMSSDetail.idTenedora = idTenedora;

            ovariablesIMSSDetail.stTenedora = unRowAniversario["Tenedora"].ToString();
            ovariablesIMSSDetail.stRegistroPatronalIMSS = unRowAniversario["RegistroPatronalIMSS"].ToString();

            decimal dcSalarioDiarioContrao = 0;
            decimal.TryParse(unRowAniversario["SalarioDiarioContrato"].ToString(), out dcSalarioDiarioContrao);
            ovariablesIMSSDetail.dcSalarioDiarioContrato = dcSalarioDiarioContrao;

            decimal dcSalarioBaseCotizacion = 0;
            decimal.TryParse(unRowAniversario["SalarioBaseCotizacionContrato"].ToString(), out dcSalarioBaseCotizacion);
            ovariablesIMSSDetail.dcSalarioBaseCotizacion = dcSalarioBaseCotizacion;

            ovariablesIMSSDetail.dcMontoVariableBimestre = dcMontoVariableBimestre;
            ovariablesIMSSDetail.iDiasCalculoVariable = iDiasCalculoVariable;
            ovariablesIMSSDetail.dcParteVariable = dcParteVariable;

            decimal dcSalarioBaseCotizacionNuevo = 0;
            decimal.TryParse(unRowAniversario["NuevoSalarioBaseCotizacion"].ToString(), out dcSalarioBaseCotizacionNuevo);
            ovariablesIMSSDetail.dcSalarioBaseCotizacionNuevo = dcSalarioBaseCotizacionNuevo;

            ovariablesIMSSDetail.dtFechaVigenciaInicio = dtFechaVigenciaInicio;
            ovariablesIMSSDetail.dtFechaVigenciaFin = dtFechaVigenciaFin;

            return ovariablesIMSSDetail;
        }


    }
}


