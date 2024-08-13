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
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Diagnostics;
using DevExpress.SpreadsheetSource.Implementation;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;

namespace winAppSAIC.OperadoresM
{
    public partial class XtraMonitoreoSolicitudesOperaciones : DevExpress.XtraEditors.XtraForm
    {

        tools.dsc dsc = new tools.dsc();
        //int iSolicitud;
        Solicitud miSolicitud = new Solicitud();
        DataTable dtEmpleadosGrid;
        OperadoresM.ColorSolicitud miColorSolicitud;
        int iSolicitud = 0;
        Empleado objEmp;
        int idFiltroSolicitud = 0;

        Boolean flaghabilitarSubirDocumentacion = false;
        Boolean flaghabilitarResponderSolicitud = false;
        Boolean flagConFiltroTenedoraSC = true;

        public XtraMonitoreoSolicitudesOperaciones(int idSolicitud)
        {
            InitializeComponent();
            this.idFiltroSolicitud = idSolicitud;
        }

        private void btnExportarEmpleados_Click(object sender, EventArgs e)
        {

            String stRutaArchivo = String.Empty;

            stRutaArchivo = dsc.stRutaTemp + "SolicutdAltaEmpleados " + miSolicitud.idSolicitud + " " + dsc.nombreAleatorio() + ".txt";
            DataTable dtEmpleados = dsc.deGridViewaDataTable(gridVEmpleados);
            String stDatos = dsc.ConvertDataTableToString(dtEmpleados, true);
            try
            {
                if (!String.IsNullOrEmpty(stDatos))
                {
                    Excel.Application appExcel;
                    Excel.Workbooks booksExcel;
                    Excel.Workbook bookExcel;
                    Excel.Worksheet SheetExcel;
                    Excel.Range Rango;

                    appExcel = new Excel.Application();
                    booksExcel = appExcel.Workbooks;
                    bookExcel = booksExcel.Add();
                    appExcel.Visible = true;
                    appExcel.DisplayAlerts = false;

                    System.Threading.Thread.Sleep(1000);
                    Clipboard.Clear();
                    System.Threading.Thread.Sleep(1000);
                    Clipboard.SetText(stDatos);

                    SheetExcel = (Excel.Worksheet)bookExcel.ActiveSheet;
                    SheetExcel.Name = miSolicitud.idSolicitud.ToString();
                    Rango = SheetExcel.get_Range("B:O");
                    Rango.NumberFormat = "@";

                    Rango = SheetExcel.get_Range("A1");
                    Rango.Select();

                    Rango.PasteSpecial();
                    Rango = SheetExcel.get_Range("A1:O1");
                    Rango.Select();
                    Rango.Interior.Pattern = Excel.XlPattern.xlPatternSolid;
                    Rango.Interior.PatternColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic;
                    Rango.Interior.ThemeColor = Excel.XlThemeColor.xlThemeColorAccent1;
                    Rango.Interior.TintAndShade = -0.499984740745262;
                    Rango.Interior.PatternTintAndShade = 0;

                    Rango.Font.ThemeColor = Excel.XlThemeColor.xlThemeColorDark1;
                    Rango.Font.TintAndShade = 0;
                    Rango.Font.Bold = true;
                    Rango.Font.Size = 14;

                    SheetExcel.Cells.Select();
                    SheetExcel.Cells.EntireColumn.AutoFit();

                    appExcel.DisplayAlerts = true;

                    XtraMessageBox.Show("Archivo Generado con Exito."
                   , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("No se puede generar el archivo de Excel."
                  , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (!String.IsNullOrEmpty(stDatos))
                {
                    File.WriteAllText(stRutaArchivo, stDatos);
                    Process.Start(stRutaArchivo);
                }
            }
        }

        private void cboSolicitudAltaEmpleados_EditValueChanged(object sender, EventArgs e)
        {
            //stpSelFolioLoteCargaNominaTimbradosCFDIGridControl.DataSource = null;
            //DataRow row = gridLookSolitudes.GetDataRow(gridLookSolitudes.FocusedRowHandle);
            //int.TryParse(row["IdSolicitud"].ToString(), out iSolicitud);

            //ObtenerInformacionDetalleSolicitud(iSolicitud);
            //obtenerInformacion();

            mostrarSolicitud();
        }


        private void mostrarSolicitud()
        {
            stpSelFolioLoteCargaNominaTimbradosCFDIGridControl.DataSource = null;

            //DataRow row = gridLookSolitudes.GetDataRow(gridLookSolitudes.FocusedRowHandle);
            //int.TryParse(row["IdSolicitud"].ToString(), out iSolicitud);

            String sRow = cboSolicitudAltaEmpleados.Text;
            int.TryParse(sRow, out iSolicitud);

            ObtenerInformacionDetalleSolicitud(iSolicitud);
        }


        private void ObtenerInformacionDetalleSolicitud(int idSolicitud)
        {
            if (!splashScreenManager5.IsSplashFormVisible)
            {
                splashScreenManager5.ShowWaitForm();
            }

            splashScreenManager5.SetWaitFormCaption("Cargando Información...");
            splashScreenManager5.SetWaitFormDescription("Solicitud " + iSolicitud);

            miSolicitud = miSolicitud.ObtenerSolcitud(iSolicitud, 1);
            RevisarSolicitud();
            pintarGridEmpleados(miSolicitud.idSolicitud);
            this.Refresh();

            splashScreenManager5.CloseWaitForm();
        }



        private void obternerEstatusYValidacion()
        {
            toolStripDescargas.Enabled = false;
            documentosToolStripMenuItem.Enabled = false;
            fielToolStripMenuItem.Enabled = false;
            contratosToolStripMenuItem.Enabled = false;
            btnExportarExcel.Enabled = false;
            btnDocumentacion.Enabled = false;
            btnResponderRechazo.Enabled = false;
            checkCmBxAreasRechazo.Enabled = false;
            btnAbrirCarpeta.Enabled = false;
            solicitudToolStripMenuItem1.Enabled = false;
            individualToolStripMenuItem1.Enabled = false;

            checkCmBxAreasRechazo.Properties.Items[0].Enabled = false;
            checkCmBxAreasRechazo.Properties.Items[1].Enabled = false;
            checkCmBxAreasRechazo.Properties.Items[2].Enabled = false;

            txtbxTenedora.Text = miSolicitud.TenedoraSA;
            txtExcedente.Text = miSolicitud.TenedoraSC;
            txtbxCliente.Text = miSolicitud.Cliente;
            txtTipoSolicitud.Text = miSolicitud.DescTipoSolicitud;
            txtFechaSolicitud.Text = miSolicitud.FechaCreacion.ToShortDateString();
            lblJuridico.Text = "Juridico: " + miSolicitud.EstatusJuridico;
            lblTesoreria.Text = "Tesoreria: " + miSolicitud.EstatusTesoreria;
            lblIMSS.Text = "IMSS: " + miSolicitud.EstatusIMSS;
            stpSelAltasTenedorasTableAdapter.Fill(dsOperaciones.stpSelAltasTenedoras, miSolicitud.idTenedoraSA, false);
            stpSelAltasExcedentesTableAdapter.Fill(dsOperaciones.stpSelAltasExcedentes, miSolicitud.idTenedoraSC, false);
            stpSelAltasClientesTableAdapter.Fill(dsOperaciones.stpSelAltasClientes, miSolicitud.idCliente, false);

            ludAltasTenedora.EditValue = miSolicitud.idTenedoraSA;
            ludAltasTenedora.ReadOnly = true;
            ludAltasExcedente.EditValue = miSolicitud.idTenedoraSC;
            ludAltasExcedente.ReadOnly = true;
            ludAltasCliente.EditValue = miSolicitud.idCliente;
            ludAltasCliente.ReadOnly = true;
        }

        private void pintarGridEmpleados(int iSolicitud)
        {
            gridVEmpleados.OptionsSelection.MultiSelect = true;

            miSolicitud = miSolicitud.ObtenerSolcitud(iSolicitud, 1);
            obternerEstatusYValidacion();

            groupControl2.Visible = false;
            groupControlAltaCuentas.Visible = false;
            groupControlSolicitudesSalario.Visible = false;

            if (miSolicitud.idTipoSolicitud == 1 || miSolicitud.idTipoSolicitud == 2)
            {
                groupControl2.Visible = true;
                groupControl2.Dock = DockStyle.Fill;
                groupControlAltaCuentas.Visible = false;
                cbxTodosLosEmpleados.Visible = false;

                stpSelObtenerEmpleadosSolicitudAltaOperacionesTableAdapter1.Fill(dbSAICBPOCatalogosDataSet.stpSelObtenerEmpleadosSolicitudAltaOperaciones, iSolicitud);
                miSolicitud.iTotalDeEmpleados = dbSAICBPOCatalogosDataSet.stpSelObtenerEmpleadosSolicitudAltaOperaciones.Rows.Count;

                txtETotal.Text = miSolicitud.iTotalDeEmpleados.ToString();


                if (miSolicitud.iTotalDeEmpleados > 0)
                {
                    habilitarBotonesContrato(dbSAICBPOCatalogosDataSet.stpSelObtenerEmpleadosSolicitudAltaOperaciones);
                    lblNumeroEmpleados.Text = "Numero de Empleados: " + dbSAICBPOCatalogosDataSet.stpSelObtenerEmpleadosSolicitudAltaOperaciones.Rows.Count;
                    btnExportarExcel.Enabled = true;
                    btnAbrirCarpeta.Enabled = true;
                    toolStripDescargas.Enabled = true;
                    documentosToolStripMenuItem.Enabled = true;
                    documentosToolStripMenuItem.Text = "Expediente";
                    fielToolStripMenuItem.Enabled = true;
                    contratosToolStripMenuItem.Enabled = true;
                    solicitudToolStripMenuItem1.Enabled = true;
                    individualToolStripMenuItem1.Enabled = true;
                    btnDocumentacion.Enabled = false;

                    EstatusSolicitud(dbSAICBPOCatalogosDataSet.stpSelObtenerEmpleadosSolicitudAltaOperaciones);

                    var miQuery = from x in dbSAICBPOCatalogosDataSet.stpSelObtenerEmpleadosSolicitudAltaOperaciones.AsEnumerable()
                                  where (x.Field<String>("EstatusJuridico").Equals("SOLICITUD RECHAZADA") ||
                                   x.Field<String>("EstatusImss").Equals("SOLICITUD RECHAZADA") ||
                                   x.Field<String>("EstatusTesoreriaSA").Equals("SOLICITUD RECHAZADA") ||
                                   x.Field<String>("EstatusTesoreriaSC").Equals("SOLICITUD RECHAZADA")) && x.Field<int>("idEstatus").Equals(2)
                                  select x;

                    var miQueryAtendidas = from x in dbSAICBPOCatalogosDataSet.stpSelObtenerEmpleadosSolicitudAltaOperaciones.AsEnumerable()
                                           where (x.Field<String>("EstatusJuridico").Equals("SOLICITUD ATENDIDA AL 100%") &&
                                            x.Field<String>("EstatusImss").Equals("SOLICITUD ATENDIDA AL 100%") &&
                                            x.Field<String>("EstatusTesoreriaSA").Equals("SOLICITUD ATENDIDA AL 100%") &&
                                            x.Field<String>("EstatusTesoreriaSC").Equals("SOLICITUD ATENDIDA AL 100%")) && x.Field<int>("idEstatus").Equals(2)
                                           select x;

                    var miQueryRechazadas = from x in dbSAICBPOCatalogosDataSet.stpSelObtenerEmpleadosSolicitudAltaOperaciones.AsEnumerable()
                                            where x.Field<int>("idEstatus").Equals(23)
                                            select x;

                    txteAtendidos.Text = miQueryAtendidas.Count().ToString();
                    txteRechazados.Text = miQuery.Count().ToString();
                    txtCancelados.Text = miQueryRechazadas.Count().ToString();
                    if (miQuery.Count() > 0)
                    {
                        DataTable dtEmpleadosRechazados = miQuery.CopyToDataTable();

                        var miQuery1 = from x in dtEmpleadosRechazados.AsEnumerable()
                                       where x.Field<int>("idEstatus").Equals(2)
                                       select x;
                        if (miQuery1.Count() > 0)
                        {
                            stpSelFolioLoteCargaNominaTimbradosCFDIGridControl.DataSource = miQuery1.CopyToDataTable();
                            btnResponderRechazo.Enabled = flaghabilitarResponderSolicitud;
                            checkCmBxAreasRechazo.Enabled = flaghabilitarResponderSolicitud;

                            checkCmBxAreasRechazo.Properties.Items[0].CheckState = CheckState.Unchecked;
                            checkCmBxAreasRechazo.Properties.Items[1].CheckState = CheckState.Unchecked;
                            checkCmBxAreasRechazo.Properties.Items[2].CheckState = CheckState.Unchecked;
                            //checkCmBxAreasRechazo.Properties.Items[3].CheckState = CheckState.Unchecked;

                            gridVEmpleados.OptionsSelection.MultiSelect = true;
                            gridVEmpleados.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;

                            if (miSolicitud.idTipoSolicitud == 1)
                            {
                                var miQueryRechazadasJuridico = from x in dbSAICBPOCatalogosDataSet.stpSelObtenerEmpleadosSolicitudAltaOperaciones.AsEnumerable()
                                                                where x.Field<String>("EstatusJuridico").Equals("SOLICITUD RECHAZADA")
                                                                select x;

                                var miQueryRechazadasIMSS = from x in dbSAICBPOCatalogosDataSet.stpSelObtenerEmpleadosSolicitudAltaOperaciones.AsEnumerable()
                                                            where x.Field<String>("EstatusImss").Equals("SOLICITUD RECHAZADA")
                                                            select x;

                                //Si ambas areas tienen rechazo
                                if ((miSolicitud.iTotalDeEmpleados * 2) == (miQueryRechazadasJuridico.Count() + miQueryRechazadasIMSS.Count()))
                                {
                                    stpSelAltasTenedorasTableAdapter.Fill(dsOperaciones.stpSelAltasTenedoras, miSolicitud.idTenedoraSA, true);
                                    stpSelAltasExcedentesTableAdapter.Fill(dsOperaciones.stpSelAltasExcedentes, miSolicitud.idTenedoraSC, true);
                                    stpSelAltasClientesTableAdapter.Fill(dsOperaciones.stpSelAltasClientes, miSolicitud.idCliente, true);

                                    ludAltasTenedora.ReadOnly = false;
                                    ludAltasExcedente.ReadOnly = false;
                                    ludAltasCliente.ReadOnly = false;

                                    ludAltasTenedora.Properties.PopupFormWidth = 800;
                                    ludAltasCliente.Properties.PopupFormWidth = 800;
                                    btnActualizarTenedoraCliente.Visible = true;
                                    ludAltasTenedora.ReadOnly = false;
                                    ludAltasExcedente.ReadOnly = false;
                                    ludAltasCliente.ReadOnly = false;

                                    flagConFiltroTenedoraSC = true;
                                }
                                else
                                {
                                    btnActualizarTenedoraCliente.Visible = false;
                                    ludAltasTenedora.ReadOnly = true;
                                    ludAltasExcedente.ReadOnly = true;
                                    ludAltasCliente.ReadOnly = true;
                                    flagConFiltroTenedoraSC = false;
                                }
                            }
                            else
                            {
                                btnActualizarTenedoraCliente.Visible = false;
                                ludAltasTenedora.ReadOnly = true;
                                ludAltasExcedente.ReadOnly = true;
                                ludAltasCliente.ReadOnly = true;
                                flagConFiltroTenedoraSC = false;
                            }

                        }
                        else
                        {
                            dtEmpleadosGrid = obtenerInformacionDoCumentos(dbSAICBPOCatalogosDataSet.stpSelObtenerEmpleadosSolicitudAltaOperaciones);
                            stpSelFolioLoteCargaNominaTimbradosCFDIGridControl.DataSource = dtEmpleadosGrid;
                        }
                    }
                    else
                    {
                        dtEmpleadosGrid = obtenerInformacionDoCumentos(dbSAICBPOCatalogosDataSet.stpSelObtenerEmpleadosSolicitudAltaOperaciones);
                        stpSelFolioLoteCargaNominaTimbradosCFDIGridControl.DataSource = dtEmpleadosGrid;
                        btnActualizarTenedoraCliente.Visible = false;
                        ludAltasTenedora.ReadOnly = true;
                        ludAltasExcedente.ReadOnly = true;
                        ludAltasCliente.ReadOnly = true;
                        flagConFiltroTenedoraSC = false;
                    }
                }
            }
            else if (miSolicitud.idTipoSolicitud == 3)
            {
                groupControl2.Visible = false;
                groupControlAltaCuentas.Visible = true;
                groupControlAltaCuentas.Dock = DockStyle.Fill;
                gridVEmpleadoCuenta.OptionsSelection.MultiSelect = true;
                gridVEmpleadoCuenta.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
                cbxTodosLosEmpleados.Checked = false;
                mostrarInformacionDeCuentasDeEmpleados(miSolicitud.idSolicitud);
            }
            else if (miSolicitud.idTipoSolicitud == 4)// Salarios
            {

                btnExportarExcel.Enabled = true;
                btnAbrirCarpeta.Enabled = true;
                toolStripDescargas.Enabled = true;
                fielToolStripMenuItem.Enabled = true;
                contratosToolStripMenuItem.Enabled = false;
                documentosToolStripMenuItem.Enabled = false;


                groupControlSolicitudesSalario.Visible = true;
                groupControlSolicitudesSalario.Dock = DockStyle.Fill;

                stpSelInfoDetalleSolicitudSalariosTableAdapter1.Fill(dbSAICBPOCatalogosDataSet.stpSelInfoDetalleSolicitudSalarios, miSolicitud.idSolicitud);

                lblNumeroEmpleados.Text = "Empleados: " + dbSAICBPOCatalogosDataSet.stpSelInfoDetalleSolicitudSalarios.Rows.Count;
                miSolicitud.iTotalDeEmpleados = dbSAICBPOCatalogosDataSet.stpSelInfoDetalleSolicitudSalarios.Rows.Count;
                txtETotal.Text = miSolicitud.iTotalDeEmpleados.ToString();

                EstatusSolicitudSalarios(dbSAICBPOCatalogosDataSet.stpSelInfoDetalleSolicitudSalarios);


                var miQueryAtendidas = from x in dbSAICBPOCatalogosDataSet.stpSelInfoDetalleSolicitudSalarios.AsEnumerable()
                                       where x.Field<String>("EstatusImss").Equals("SOLICITUD ATENDIDA AL 100%")
                                       && x.Field<int>("idEstatus").Equals(2)
                                       select x;

                var miQueryCancelados = from x in dbSAICBPOCatalogosDataSet.stpSelInfoDetalleSolicitudSalarios.AsEnumerable()
                                        where x.Field<int>("idEstatus").Equals(23)
                                        select x;

                var miQueryRechazadas = from x in dbSAICBPOCatalogosDataSet.stpSelInfoDetalleSolicitudSalarios.AsEnumerable()
                                        where x.Field<String>("EstatusImss").Equals("SOLICITUD RECHAZADA") &&
                                        x.Field<int>("idEstatus").Equals(2)
                                        select x;

                txteAtendidos.Text = miQueryAtendidas.Count().ToString();
                txteRechazados.Text = miQueryRechazadas.Count().ToString();
                txtCancelados.Text = miQueryCancelados.Count().ToString();

                if (miQueryRechazadas.Count() > 0)
                {
                    DataTable dtEmpleadosRechazados = miQueryRechazadas.CopyToDataTable();
                    gridControlSalarios.DataSource = dtEmpleadosRechazados;
                    btnResponderRechazo.Enabled = flaghabilitarResponderSolicitud;
                    checkCmBxAreasRechazo.Enabled = flaghabilitarResponderSolicitud;

                    //checkCmBxAreasRechazo.Properties.Items[0].CheckState = CheckState.Unchecked; // Juridico
                    checkCmBxAreasRechazo.Properties.Items[1].CheckState = CheckState.Unchecked; //IMSS
                    //checkCmBxAreasRechazo.Properties.Items[2].CheckState = CheckState.Unchecked;
                    //checkCmBxAreasRechazo.Properties.Items[3].CheckState = CheckState.Unchecked;

                    gridViewSalarios.OptionsSelection.MultiSelect = true;
                    gridViewSalarios.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;

                }
                else
                {
                    //dtEmpleadosGrid = obtenerInformacionDoCumentos(dbSAICBPOCatalogosDataSet.stpSelInfoDetalleSolicitudSalarios);
                    gridControlSalarios.DataSource = dbSAICBPOCatalogosDataSet.stpSelInfoDetalleSolicitudSalarios;
                }
            }
            else
            {
                groupControl2.Visible = false;
                groupControlAltaCuentas.Visible = false;
                cbxTodosLosEmpleados.Visible = false;
            }
        }


        /// <summary>
        /// Obtener informacion de documentacion
        /// </summary>
        /// <param name="dtEmpelados"></param>
        /// <returns></returns>
        private DataTable obtenerInformacionDoCumentos(DataTable deEmpleados)
        {
            if (deEmpleados.Columns.IndexOf("Documentacion") == -1)
            {
                deEmpleados.Columns.Add("Documentacion", typeof(String));
            }

            foreach (DataRow unRow in deEmpleados.Rows)
            {
                int iEmpleado;
                int.TryParse(unRow["idEmpleado"].ToString(), out iEmpleado);

                if (iEmpleado > 0)
                {
                    stpSelEmpleadoDocumentoTableAdapter1.Fill(dbSAICBPOCatalogosDataSet.stpSelEmpleadoDocumento, iEmpleado, 1);

                    if (dbSAICBPOCatalogosDataSet.stpSelEmpleadoDocumento.Rows.Count > 0)
                    {
                        unRow["Documentacion"] = "SI";
                    }
                    else
                    {
                        unRow["Documentacion"] = "NO";
                    }
                }
            }

            int hayDocumentosporSubir = deEmpleados.Select("Documentacion = 'NO'").Count();
            if (hayDocumentosporSubir > 0)
            {
                btnDocumentacion.Enabled = flaghabilitarSubirDocumentacion;
                btnDocumentacion.Text = "Cargar Documentacion";
                btnAbrirCarpeta.Enabled = true;
                toolStripDescargas.Enabled = true;
                documentosToolStripMenuItem.Enabled = true;
                fielToolStripMenuItem.Enabled = true;
                contratosToolStripMenuItem.Enabled = true;
                solicitudToolStripMenuItem1.Enabled = true;
                individualToolStripMenuItem1.Enabled = true;
            }
            else
            {
                btnDocumentacion.Text = "Solicitud con Documentacion";
            }

            return deEmpleados;
        }

        private void EstatusSolicitudSalarios(DataTable dtEmpleados)
        {
            lblJuridico.Text = "Juridico: " + "No Aplica";
            lblTesoreria.Text = "Tesoreria: " + "No Aplica";

            int iestatusIMSS = (from x in dtEmpleados.AsEnumerable()
                                where x.Field<String>("EstatusIMSS").Equals("SOLICITUD ATENDIDA AL 100%")
                                select x).ToList().Count;

            double dcmContar_1 = 0;
            double resultado = 0;

            dcmContar_1 = iestatusIMSS;
            resultado = dcmContar_1 / (1 * dtEmpleados.Rows.Count);
            resultado = resultado * 100;

            lblEstatus.Text = resultado.ToString("#.##") + "%";

            if (resultado == 0)
            {
                lblEstatus.Text = "0%";
                lblEstatus.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FF0000"); ;
            }
            else if (resultado > 0 && resultado < 100)
            {
                lblEstatus.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FF8000"); ;
            }
            else if (resultado == 100)
            {
                lblEstatus.ForeColor = System.Drawing.ColorTranslator.FromHtml("#00C000"); ;
            }
        }


        private void EstatusSolicitud(DataTable dtEmpleados)
        {

            //int iEstatus = (from x in dtEmpleados.AsEnumerable()
            //                where x.Field<String>("EstatusJuridico").Equals("SOLICITUD ATENDIDA AL 100%") ||
            //                x.Field<String>("EstatusImss").Equals("SOLICITUD ATENDIDA AL 100%") ||
            //                x.Field<String>("EstatusTesoreriaSA").Equals("SOLICITUD ATENDIDA AL 100%") ||
            //                x.Field<String>("EstatusTesoreriaSC").Equals("SOLICITUD ATENDIDA AL 100%")
            //                select x).ToList().Count;

            int iTotalDeEmpleados = (from x in dtEmpleados.AsEnumerable()
                                     where x.Field<int>("idEstatus").Equals(2)
                                     select x).ToList().Count;

            int iestatusJuridico = (from x in dtEmpleados.AsEnumerable()
                                    where x.Field<String>("EstatusJuridico").Equals("SOLICITUD ATENDIDA AL 100%")
                                    && x.Field<int>("idEstatus").Equals(2)
                                    select x).ToList().Count;

            int iestatusTesoSA = (from x in dtEmpleados.AsEnumerable()
                                  where x.Field<String>("EstatusTesoreriaSA").Equals("SOLICITUD ATENDIDA AL 100%")
                                  && x.Field<int>("idEstatus").Equals(2)
                                  select x).ToList().Count;

            int iestatusTesoSC = (from x in dtEmpleados.AsEnumerable()
                                  where x.Field<String>("EstatusTesoreriaSC").Equals("SOLICITUD ATENDIDA AL 100%")
                                  && x.Field<int>("idEstatus").Equals(2)
                                  select x).ToList().Count;

            int iestatusImss = (from x in dtEmpleados.AsEnumerable()
                                where x.Field<String>("EstatusImss").Equals("SOLICITUD ATENDIDA AL 100%")
                                && x.Field<int>("idEstatus").Equals(2)
                                select x).ToList().Count;

            double dcmContar = 0;
            double dcmContar_1 = 0;
            double resultado = 0;

            dcmContar_1 = iestatusJuridico + iestatusTesoSA + iestatusTesoSC + iestatusImss;
            resultado = dcmContar_1 / (4 * iTotalDeEmpleados);
            resultado = resultado * 100;

            //dcmContar = (iEstatus * 100) / (4 * dtEmpleados.Rows.Count);

            resultado = resultado.ToString() == "NaN" ? 0 : resultado;

            lblEstatus.Text = resultado.ToString("#.##") + "%";

            if (resultado == 0)
            {
                lblEstatus.Text = "0%";
                lblEstatus.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FF0000"); ;
            }
            else if (resultado > 0 && resultado < 100)
            {
                lblEstatus.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FF8000"); ;
            }
            else if (resultado == 100)
            {
                lblEstatus.ForeColor = System.Drawing.ColorTranslator.FromHtml("#00C000"); ;
            }
        }

        private void EstatusSolicitudCuentas(DataTable dtEmpleados)
        {
            lblJuridico.Text = "Juridico: No Aplica";
            lblIMSS.Text = "IMSS: No Aplica";

            int iestatusTesoreria = (from x in dtEmpleados.AsEnumerable()
                                     where x.Field<String>("Estatus Tesoreria SA").Equals("SOLICITUD ATENDIDA AL 100%")
                                     select x).ToList().Count;

            int iestatusTesoSC = (from x in dtEmpleados.AsEnumerable()
                                  where x.Field<String>("Estatus Tesoreria SC").Equals("SOLICITUD ATENDIDA AL 100%")
                                  select x).ToList().Count;

            double dcmContar_1 = 0;
            double resultado = 0;

            dcmContar_1 = iestatusTesoreria + iestatusTesoSC;
            resultado = dcmContar_1 / (2 * dtEmpleados.Rows.Count);
            resultado = resultado * 100;

            //dcmContar = (iEstatus * 100) / (4 * dtEmpleados.Rows.Count);

            lblEstatus.Text = resultado.ToString("#.##") + "%";

            if (resultado == 0)
            {
                lblEstatus.Text = "0%";
                lblEstatus.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FF0000");
            }
            else if (resultado > 0 && resultado < 100)
            {
                lblEstatus.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FF8000");
            }
            else if (resultado == 100)
            {
                lblEstatus.ForeColor = System.Drawing.ColorTranslator.FromHtml("#00C000");
            }
        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void XtraMonitoreoSolicitudesOperaciones_Load(object sender, EventArgs e)
        {
            miColorSolicitud = new ColorSolicitud();
            miColorSolicitud = miColorSolicitud.obtenerColor();
            obtenerInformacion();
        }

        private void obtenerInformacion()
        {
            splashScreenManager5.ShowWaitForm();
            System.Drawing.Size d = new Size(900, 400);
            stpSelObtenerSolicitudesAltaOperacionesTableAdapter1.Fill(dbSAICBPOCatalogosDataSet.stpSelObtenerSolicitudesAltaOperaciones, OperadorBD.OperadorGlobal.IdOperador, OperadorBD.OperadorGlobal.IdAreaOperativa);
            cboSolicitudAltaEmpleados.Properties.View.BestFitColumns();
            cboSolicitudAltaEmpleados.Properties.PopupFormSize = d;
            FiltroSolicitud();

            if (idFiltroSolicitud > 0)
            {
                checkProceso.Checked = true;
                checkAtendidas.Checked = true;
                string filterString = "[idSolicitud] = " + idFiltroSolicitud.ToString();
                gridLookSolitudes.Columns["idSolicitud"].FilterInfo = new ColumnFilterInfo(filterString);

                cboSolicitudAltaEmpleados.Text = idFiltroSolicitud.ToString();
                cboSolicitudAltaEmpleados.EditValue = idFiltroSolicitud.ToString();
            }

            habilitarSubirDocumentacion();

            if (splashScreenManager5.IsSplashFormVisible) { splashScreenManager5.CloseWaitForm(); }
        }

        private void RevisarSolicitud()
        {
            queriesTableAdapter1.stpUpdSolicitudAltaEmpleadosRevisarEstatus(miSolicitud.idSolicitud, OperadorBD.OperadorGlobal.NombreUsuario);
        }

        private void habilitarBotonesContrato(DataTable stEmpleados)
        {
            Boolean bandera = false;
            int iHayEmpleadosContrato = 0;
            iHayEmpleadosContrato = stEmpleados.Select("ContratoAutorizado = 'SI'").Count();
            if (iHayEmpleadosContrato > 0) { bandera = true; }

            contratosToolStripMenuItem.Enabled = bandera;
            solicitudToolStripMenuItem1.Enabled = bandera;
            individualToolStripMenuItem1.Enabled = bandera;

        }

        private void checkProceso_CheckedChanged(object sender, EventArgs e)
        {
            FiltroSolicitud();
        }

        private void checkAtendidas_CheckedChanged(object sender, EventArgs e)
        {
            FiltroSolicitud();
        }

        private void checkCanceladas_CheckedChanged(object sender, EventArgs e)
        {
            FiltroSolicitud();
        }

        private void FiltroSolicitud()
        {
            DataTable dtSolicitudes = dbSAICBPOCatalogosDataSet.stpSelObtenerSolicitudesAltaOperaciones.Clone();
            DataTable dtProceso = dbSAICBPOCatalogosDataSet.stpSelObtenerSolicitudesAltaOperaciones.Clone();
            DataTable dtEmitida = dbSAICBPOCatalogosDataSet.stpSelObtenerSolicitudesAltaOperaciones.Clone();
            DataTable dtCanceladas = dbSAICBPOCatalogosDataSet.stpSelObtenerSolicitudesAltaOperaciones.Clone();

            String stProceso = "SOLICITUD EN PROCESO";
            String stEmitida = "SOLICITUD EMITIDA";
            String stRechazada = "SOLICITUD RECHAZADA";
            String stContestada = "SOLICITUD RESPONDIDA";
            String stCancelada = "SOLICITUD CANCELADA";

            String stAtendida = "SOLICITUD ATENDIDA AL 100%";

            if (checkProceso.Checked)
            {
                var query = (from x in dbSAICBPOCatalogosDataSet.stpSelObtenerSolicitudesAltaOperaciones.AsEnumerable()
                             where x.Field<int>("IdEstatus").Equals(2) && (x.Field<String>("EstatusSolicitud").Equals(stProceso) ||
                             x.Field<String>("EstatusSolicitud").Equals(stEmitida) ||
                             x.Field<String>("EstatusSolicitud").Equals(stRechazada) ||
                             x.Field<String>("EstatusSolicitud").Equals(stContestada))
                             select x);

                if (query.Count() > 0)
                {
                    dtProceso = query.CopyToDataTable();
                    dtSolicitudes.Merge(dtProceso);
                }
            }
            if (checkAtendidas.Checked)
            {
                var query = (from x in dbSAICBPOCatalogosDataSet.stpSelObtenerSolicitudesAltaOperaciones.AsEnumerable()
                             where x.Field<String>("EstatusSolicitud").Equals(stAtendida) && x.Field<int>("IdEstatus").Equals(2)
                             select x);

                if (query.Count() > 0)
                {
                    dtEmitida = query.CopyToDataTable();
                    dtSolicitudes.Merge(dtEmitida);
                }
            }
            if (checkCanceladas.Checked)
            {
                var query = (from x in dbSAICBPOCatalogosDataSet.stpSelObtenerSolicitudesAltaOperaciones.AsEnumerable()
                             where x.Field<int>("IdEstatus").Equals(23)
                             select x);

                if (query.Count() > 0)
                {
                    dtEmitida = query.CopyToDataTable();
                    dtSolicitudes.Merge(dtEmitida);
                }
            }

            cboSolicitudAltaEmpleados.Properties.DataSource = dtSolicitudes;
        }

        private void gridVEmpleados_DoubleClick(object sender, EventArgs e)
        {
            gridVEmpleados.Focus();
            DataRow unRow = gridVEmpleados.GetDataRow(gridVEmpleados.FocusedRowHandle);
            if (unRow != null)
            {
                int iIdEmpleado;

                int.TryParse(unRow["IdEmpleado"].ToString(), out iIdEmpleado);

                Boolean banIMMS = unRow["EstatusIMSS"].ToString() == "SOLICITUD RECHAZADA" ? true : false;
                Boolean banJuridico = unRow["EstatusJuridico"].ToString() == "SOLICITUD RECHAZADA" ? true : false;
                Boolean banTesoreriaSA = unRow["EstatusTesoreriaSA"].ToString() == "SOLICITUD RECHAZADA" ? true : false;
                Boolean banTesoreriaSC = unRow["EstatusTesoreriaSC"].ToString() == "SOLICITUD RECHAZADA" ? true : false;

                if (banIMMS || banJuridico || banTesoreriaSA || banTesoreriaSC)
                {
                    Boolean teso = banTesoreriaSA == true || banTesoreriaSC == true ? true : false;
                    if (iIdEmpleado > 0 && unRow["EstatusRegistro"].ToString() == "ACTIVO")
                    {
                        if (miSolicitud.idTipoSolicitud == 1)
                        {
                            Catalogos.frmxModificacionEmpleados modulosEdicionEmpleados = new Catalogos.frmxModificacionEmpleados(iIdEmpleado, false, true, banIMMS, banJuridico, teso, miSolicitud.idSolicitud);
                            modulosEdicionEmpleados.ShowDialog();
                            //Validar Informacion de la solicitud
                            RevisarSolicitud();
                            pintarGridEmpleados(miSolicitud.idSolicitud);
                        }
                        else if (miSolicitud.idTipoSolicitud == 2)
                        {
                            DataTable dt = this.stpSelObtenerInfoEmpleadoModificacionCFDITableAdapter1.GetData(Convert.ToInt32(iIdEmpleado));
                            objEmp = EmpleadoBD.ObtenerInfoEmpleadoModificacionCFDI(dt);
                            XtraMotivoBajaEmpleado bajaEmpleado = new XtraMotivoBajaEmpleado(objEmp, 2, miSolicitud.FechaCreacion);
                            bajaEmpleado.ShowDialog();
                        }
                    }
                }
            }
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            if (miSolicitud.idTipoSolicitud == 4)
            {
                descargarArchivoSolicituSalarios(miSolicitud.idSolicitud);
            }
            else
            {
                descargarArchivoEmpleados(dbSAICBPOCatalogosDataSet.stpSelObtenerEmpleadosSolicitudAltaOperaciones, miSolicitud, 0);
            }
        }

        /// <summary>
        /// 0 - Operaciones
        /// 1 - Juridico
        /// 2 - IMSS
        /// 3 -Tesoreria
        /// </summary>
        /// <param name="dtSolicitud"></param>
        /// <param name="miSolicitud"></param>
        /// <param name="iArea"></param>
        public void descargarArchivoEmpleados(DataTable dtSolicitud, Solicitud miSolicitud, int iArea)
        {
            splashScreenManager5.ShowWaitForm();
            splashScreenManager5.SetWaitFormCaption("Descargando Archivo");
            splashScreenManager5.SetWaitFormDescription("Espere Por favor...");

            DataTable dtInfoEmpleados = null;

            if (iArea == 3) // Tesoreria
            {
                stpSelInformacionAltaEmpleados_TesoreriaTableAdapter1.Fill(dbSAICBPOCatalogosDataSet.stpSelInformacionAltaEmpleados_Tesoreria, 0);
                dtInfoEmpleados = dbSAICBPOCatalogosDataSet.stpSelInformacionAltaEmpleados_Tesoreria.Clone();
            }
            else
            {
                stpSelInformacionAltaEmpleadosTableAdapter1.Fill(dbSAICBPOCatalogosDataSet.stpSelInformacionAltaEmpleados, 0, 0);
                dtInfoEmpleados = dbSAICBPOCatalogosDataSet.stpSelInformacionAltaEmpleados.Clone();
            }

            int iContador = 1;
            //Obtener Empleados de la Solicitud.
            foreach (DataRow item in dtSolicitud.Rows)
            {
                int idEmpleado = 0;
                int.TryParse(item["idEmpleado"].ToString(), out idEmpleado);
                if (idEmpleado != 0)
                {
                    //Descargar Detalle de Empleados
                    if (iArea == 3) // Tesoreria
                    {
                        stpSelInformacionAltaEmpleados_TesoreriaTableAdapter1.Fill(dbSAICBPOCatalogosDataSet.stpSelInformacionAltaEmpleados_Tesoreria, idEmpleado);
                        if (dbSAICBPOCatalogosDataSet.stpSelInformacionAltaEmpleados_Tesoreria.Rows.Count > 0)
                        {
                            dbSAICBPOCatalogosDataSet.stpSelInformacionAltaEmpleados_Tesoreria.Columns["Control"].ReadOnly = false;
                            dbSAICBPOCatalogosDataSet.stpSelInformacionAltaEmpleados_Tesoreria.Rows[0]["Control"] = iContador.ToString();

                            DataRow dtrow = dbSAICBPOCatalogosDataSet.stpSelInformacionAltaEmpleados_Tesoreria.Rows[0];
                            dtInfoEmpleados.ImportRow(dtrow);
                            iContador++;
                        }
                    }
                    else
                    {
                        stpSelInformacionAltaEmpleadosTableAdapter1.Fill(dbSAICBPOCatalogosDataSet.stpSelInformacionAltaEmpleados, idEmpleado, 0);
                        if (dbSAICBPOCatalogosDataSet.stpSelInformacionAltaEmpleados.Rows.Count > 0)
                        {
                            DataRow dtrow = dbSAICBPOCatalogosDataSet.stpSelInformacionAltaEmpleados.Rows[0];
                            dtInfoEmpleados.ImportRow(dtrow);
                        }
                    }
                }
            }

            //Agregar nuevas columnas
            dtInfoEmpleados.Columns.Add("Razon Social Tenedora SA");
            dtInfoEmpleados.Columns.Add("Registro Patronal");
            dtInfoEmpleados.Columns.Add("Razon Social Excedente");
            dtInfoEmpleados.Columns.Add("IdCliente");
            dtInfoEmpleados.Columns.Add("Razon Social Cliente");

            //Asiganar valor a las nuevas columnas
            dtInfoEmpleados.Columns["Razon Social Tenedora SA"].Expression = "'" + miSolicitud.TenedoraSA + "'";
            dtInfoEmpleados.Columns["Registro Patronal"].Expression = "'" + miSolicitud.RegistroPatronal + "'";
            dtInfoEmpleados.Columns["Razon Social Excedente"].Expression = "'" + miSolicitud.TenedoraSC + "'";
            dtInfoEmpleados.Columns["Razon Social Cliente"].Expression = "'" + miSolicitud.Cliente + "'";
            dtInfoEmpleados.Columns["IdCliente"].Expression = "'" + miSolicitud.idCliente + "'";

            String stRutaArchivo = String.Empty;
            dsc.CheckandCreateFolder(stRutaArchivo = miSolicitud.sRutaSolicitud + miSolicitud.idSolicitud + @"\");
            stRutaArchivo = miSolicitud.sRutaSolicitud + miSolicitud.idSolicitud + @"\" + "S" + miSolicitud.idSolicitud + "-" + miSolicitud.idTenedoraSA + "-E" + dtInfoEmpleados.Rows.Count + " " + dsc.nombreAleatorio() + ".xlsx";
            int iCuantosRow = dtInfoEmpleados.Rows.Count + 2;

            String stInformacionEmpleados = dsc.ConvertDataTableToString(dtInfoEmpleados, true);
            String stDatosSolciitud = dsc.ConvertDataTableToString(dtSolicitud, true);
            String stUltimaColumna = dsc.NumToLetterColumnExcel(dtSolicitud.Columns.Count);

            try
            {
                if (!String.IsNullOrEmpty(stInformacionEmpleados))
                {
                    Excel.Application appExcel;
                    Excel.Workbooks booksExcel;
                    Excel.Workbook bookExcel;
                    Excel.Worksheet SheetExcel;
                    Excel.Range Rango;

                    appExcel = new Excel.Application();
                    booksExcel = appExcel.Workbooks;
                    bookExcel = booksExcel.Add();
                    appExcel.Visible = true;
                    appExcel.DisplayAlerts = false;

                    System.Threading.Thread.Sleep(1000);
                    Clipboard.Clear();
                    System.Threading.Thread.Sleep(1000);
                    Clipboard.SetText(stInformacionEmpleados);

                    SheetExcel = (Excel.Worksheet)bookExcel.ActiveSheet;
                    SheetExcel.Name = "S" + miSolicitud.idSolicitud.ToString() + " Det. Empleados";
                    Rango = SheetExcel.get_Range("A1:BE" + iCuantosRow);
                    Rango.Select();
                    Rango.NumberFormat = "@";

                    Rango = SheetExcel.get_Range("A1");
                    Rango.Select();
                    Rango.PasteSpecial();

                    Rango = SheetExcel.get_Range("A1:BE1");
                    Rango.Select();
                    Rango.Interior.Pattern = Excel.XlPattern.xlPatternSolid;
                    Rango.Interior.PatternColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic;
                    Rango.Interior.ThemeColor = Excel.XlThemeColor.xlThemeColorAccent1;
                    Rango.Interior.TintAndShade = -0.499984740745262;
                    Rango.Interior.PatternTintAndShade = 0;

                    Rango.Font.ThemeColor = Excel.XlThemeColor.xlThemeColorDark1;
                    Rango.Font.TintAndShade = 0;
                    Rango.Font.Bold = true;
                    Rango.Font.Size = 14;

                    SheetExcel.Cells.Select();
                    SheetExcel.Cells.EntireColumn.AutoFit();

                    //--------------------------------------
                    System.Threading.Thread.Sleep(1000);
                    Clipboard.Clear();
                    System.Threading.Thread.Sleep(1000);
                    Clipboard.SetText(stDatosSolciitud);

                    SheetExcel = (Excel.Worksheet)bookExcel.Sheets.Add();
                    SheetExcel = (Excel.Worksheet)bookExcel.ActiveSheet;
                    SheetExcel.Name = "S" + miSolicitud.idSolicitud.ToString() + " Det. Solicitud";

                    Rango = SheetExcel.get_Range("A:" + stUltimaColumna);
                    Rango.Select();
                    Rango.NumberFormat = "@";

                    Rango = SheetExcel.get_Range("A1");
                    Rango.Select();
                    Rango.PasteSpecial();

                    Rango = SheetExcel.get_Range("A1:" + stUltimaColumna + "1");
                    Rango.Select();
                    Rango.Interior.Pattern = Excel.XlPattern.xlPatternSolid;
                    Rango.Interior.PatternColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic;
                    Rango.Interior.ThemeColor = Excel.XlThemeColor.xlThemeColorAccent1;
                    Rango.Interior.TintAndShade = -0.499984740745262;
                    Rango.Interior.PatternTintAndShade = 0;

                    Rango.Font.ThemeColor = Excel.XlThemeColor.xlThemeColorDark1;
                    Rango.Font.TintAndShade = 0;
                    Rango.Font.Bold = true;
                    Rango.Font.Size = 14;

                    SheetExcel.Cells.Select();
                    SheetExcel.Cells.EntireColumn.AutoFit();

                    //------------------------------ 3era Hoja Informacion con filtro para las Renovaciones de Contrato
                    if (iArea == 1)
                    {
                        //String stDatosCorrespondencia = stObtenerInformacionEmpleadosCorrespondencia(miSolicitud.idSolicitud);

                        DataTable dtInfoEmpleadosSeleccionados = new DataTable();
                        foreach (DataRow item in dtSolicitud.Rows)
                        {
                            int idEmpleado = 0;
                            int.TryParse(item["idEmpleado"].ToString(), out idEmpleado);
                            if (idEmpleado != 0)
                            {
                                //Descargar Detalle de Empleados
                                dtInfoEmpleadosSeleccionados.Merge(ObtenerInformacionEmpleadosCorrespondencia(idEmpleado));
                            }
                        }

                        String stDatosCorrespondencia = dsc.ConvertDataTableToString(dtInfoEmpleadosSeleccionados, true);
                        String stColumnaExcel = dsc.ColumnaExcel(dtInfoEmpleadosSeleccionados.Columns.Count);

                        System.Threading.Thread.Sleep(1000);
                        Clipboard.Clear();
                        System.Threading.Thread.Sleep(1000);
                        Clipboard.SetText(stDatosCorrespondencia);

                        SheetExcel = (Excel.Worksheet)bookExcel.Sheets.Add();
                        SheetExcel = (Excel.Worksheet)bookExcel.ActiveSheet;
                        SheetExcel.Name = "S" + miSolicitud.idSolicitud.ToString() + " Coresp Empleados";
                        Rango = SheetExcel.get_Range("A:" + stColumnaExcel);
                        Rango.Select();
                        Rango.NumberFormat = "@";
                        Rango = SheetExcel.get_Range("A1");
                        Rango.Select();
                        Rango.PasteSpecial();

                        Rango = SheetExcel.get_Range("A1:" + stColumnaExcel + "1");
                        Rango.Select();
                        Rango.Interior.Pattern = Excel.XlPattern.xlPatternSolid;
                        Rango.Interior.PatternColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic;
                        Rango.Interior.ThemeColor = Excel.XlThemeColor.xlThemeColorAccent1;
                        Rango.Interior.TintAndShade = -0.499984740745262;
                        Rango.Interior.PatternTintAndShade = 0;

                        Rango.Font.ThemeColor = Excel.XlThemeColor.xlThemeColorDark1;
                        Rango.Font.TintAndShade = 0;
                        Rango.Font.Bold = true;
                        Rango.Font.Size = 14;

                        SheetExcel.Cells.Select();
                        SheetExcel.Cells.EntireColumn.AutoFit();

                    }

                    appExcel.DisplayAlerts = true;
                    bookExcel.SaveAs(stRutaArchivo);
                    splashScreenManager5.CloseWaitForm();

                    XtraMessageBox.Show("Archivo Generado con Exito."
                   , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                splashScreenManager5.CloseWaitForm();
                XtraMessageBox.Show("No se puede generar el archivo de Excel." + Environment.NewLine + ex.Message
                  , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (!String.IsNullOrEmpty(stInformacionEmpleados))
                {
                    stRutaArchivo = miSolicitud.sRutaSolicitud + miSolicitud.idSolicitud + @"\Detalle Empleados -" + "S" + miSolicitud.idSolicitud + "-" + miSolicitud.idTenedoraSA + "-E" + dtInfoEmpleados.Rows.Count + " " + dsc.nombreAleatorio() + ".txt";
                    File.WriteAllText(stRutaArchivo, stInformacionEmpleados);
                }
                if (!String.IsNullOrEmpty(stDatosSolciitud))
                {
                    stRutaArchivo = miSolicitud.sRutaSolicitud + miSolicitud.idSolicitud + @"\Detalle Solicitud -" + "S" + miSolicitud.idSolicitud + "-" + miSolicitud.idTenedoraSA + "-E" + dtInfoEmpleados.Rows.Count + " " + dsc.nombreAleatorio() + ".txt";
                    File.WriteAllText(stRutaArchivo, stDatosSolciitud);
                }

                XtraMessageBox.Show("Archivos de texto Guardados en Ruta:" + Environment.NewLine +
                    miSolicitud.sRutaSolicitud + miSolicitud.idSolicitud + @"\"
                 , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void descargarArchivoSolicituSalarios(int idSolicitud)
        {
            String stRutaExcel = miSolicitud.sRutaSolicitud + idSolicitud + @"\";
            dsc.CheckandCreateFolder(stRutaExcel);

            stRutaExcel += "Solicitud de Salarios " + idSolicitud + " - " + dsc.nombreAleatorio() + ".xlsx";

            //stpInfoDetalleSolicitudSalariosTableAdapter1.Fill(dbSAICBPOCatalogosDataSet.stpInfoDetalleSolicitudSalarios, idSolicitud);

            gridControlSalarios.ExportToXlsx(stRutaExcel);

            XtraMessageBox.Show("Archivo descargado:" + Environment.NewLine + "Ruta: " + stRutaExcel
                 , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btnResponderRechazo_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridVEmpleados.SelectedRowsCount > 0)
                {
                    DataTable dtEmpleadosSeleccionados = dsc.deGridViewSelectedToDataTable(gridVEmpleados);
                    Boolean banJuridico = false;
                    Boolean banIMSS = false;
                    Boolean banTesoreria = false;

                    //Juridico
                    if (checkCmBxAreasRechazo.Properties.Items[0].CheckState == CheckState.Checked) { banJuridico = true; }
                    //IMSS
                    if (checkCmBxAreasRechazo.Properties.Items[1].CheckState == CheckState.Checked) { banIMSS = true; }
                    //Tesoreria
                    if (checkCmBxAreasRechazo.Properties.Items[2].CheckState == CheckState.Checked) { banTesoreria = true; }

                    //Actualizar Empleados
                    foreach (DataRow item in dtEmpleadosSeleccionados.Rows)
                    {
                        queriesTableAdapter1.stpUpdEmpleadoRespuestaRechazo(
                            miSolicitud.idSolicitud,
                            Convert.ToInt32(item["IdEmpleado"]),
                            banJuridico,
                            banIMSS,
                            banTesoreria,
                            OperadorBD.OperadorGlobal.NombreOperador
                            );
                    }

                    //Actualizar Solicitud
                    queriesTableAdapter1.stpUpdSolicitudEmpleadoRespuestaRechazo(miSolicitud.idSolicitud,
                        banJuridico,
                        banIMSS,
                        banTesoreria,
                        OperadorBD.OperadorGlobal.NombreUsuario);

                    XtraMessageBox.Show("Solicitud: " + miSolicitud.idSolicitud + ", Reenviada."
                  , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    obtenerInformacion();
                    pintarGridEmpleados(iSolicitud);
                }
                else if (gridVEmpleadoCuenta.SelectedRowsCount > 0)// responder solicitudes de Alta de Cuentas
                {
                    DataTable dtEmpleadosSeleccionados = dsc.deGridViewSelectedToDataTable(gridVEmpleadoCuenta);
                    Boolean banTesoreria = false;

                    if (checkCmBxAreasRechazo.Properties.Items[2].CheckState == CheckState.Checked)
                    {
                        //Tesoreria
                        if (checkCmBxAreasRechazo.Properties.Items[2].CheckState == CheckState.Checked) { banTesoreria = true; }

                        int idSolicitud = 0;
                        //Actualizar Empleados
                        foreach (DataRow item in dtEmpleadosSeleccionados.Rows)
                        {
                            int.TryParse(item["IdSolicitud"].ToString(), out idSolicitud);
                            queriesTableAdapter1.stpUpdEmpleadoRespuestaRechazo(
                                idSolicitud,
                                Convert.ToInt32(item["IdEmpleado"]),
                                false,
                                false,
                                banTesoreria,
                                OperadorBD.OperadorGlobal.NombreOperador
                                );
                        }

                        //Actualizar Solicitud
                        queriesTableAdapter1.stpUpdSolicitudEmpleadoRespuestaRechazo(idSolicitud,
                            false,
                            false,
                            banTesoreria,
                            OperadorBD.OperadorGlobal.NombreUsuario);

                        XtraMessageBox.Show("Solicitud: " + idSolicitud + ", Reenviada."
                      , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        obtenerInformacion();
                        pintarGridEmpleados(iSolicitud);
                    }
                    else
                    {
                        checkCmBxAreasRechazo.Focus();
                        XtraMessageBox.Show("Seleccione una Area para Responder."
               , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (gridViewSalarios.SelectedRowsCount > 0)
                {
                    DataTable dtEmpleadosSeleccionados = dsc.deGridViewSelectedToDataTable(gridViewSalarios);

                    var iResultado = (from x in dtEmpleadosSeleccionados.AsEnumerable()
                                      where x.Field<String>("EstatusIMSS").Equals("SOLICITUD ATENDIDA AL 100%")
                                      select x).ToList().Count;


                    if (iResultado > 0)
                    {
                        XtraMessageBox.Show("Hay Empleado(s) atendidos al 100%. Revise la solicitud con IMSS."
                            , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    Boolean flagCheckIMSS = false;
                    if (checkCmBxAreasRechazo.Properties.Items[1].CheckState == CheckState.Checked) { flagCheckIMSS = true; }

                    //Actualizar Empleados
                    foreach (DataRow item in dtEmpleadosSeleccionados.Rows)
                    {
                        queriesTableAdapter1.stpUpdEmpleadoRespuestaRechazo(
                            miSolicitud.idSolicitud,
                            Convert.ToInt32(item["IdEmpleado"]),
                            false,
                            flagCheckIMSS,
                            false,
                            OperadorBD.OperadorGlobal.NombreOperador
                            );
                    }

                    //Actualizar Solicitud
                    queriesTableAdapter1.stpUpdSolicitudEmpleadoRespuestaRechazo(miSolicitud.idSolicitud,
                        false,
                        flagCheckIMSS,
                        false,
                        OperadorBD.OperadorGlobal.NombreUsuario);

                    XtraMessageBox.Show("Solicitud: " + miSolicitud.idSolicitud + ", Reenviada."
                  , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    obtenerInformacion();
                    pintarGridEmpleados(iSolicitud);
                }
                else
                {
                    XtraMessageBox.Show("Seleccione a un empleado para reenviar la Solicitud."
                  , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("No se pudo contestar la Solicitud." + Environment.NewLine + ex.Message
               , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void valCheckBox()
        {
            checkCmBxAreasRechazo.Properties.Items[0].Enabled = false;
            checkCmBxAreasRechazo.Properties.Items[1].Enabled = false;
            checkCmBxAreasRechazo.Properties.Items[2].Enabled = false;

            DataTable dtEmpleados = dsc.deGridViewSelectedToDataTable(gridVEmpleados);

            if (dtEmpleados.Rows.Count > 0)
            {
                //dtEmpleadosGrid.Select("Documentacion = 'NO'").Count() + Environment.NewLine +
                int iEstatusIMSS = dtEmpleados.Select("EstatusImss = 'SOLICITUD RECHAZADA'").Count();
                int iEstatusTeso = dtEmpleados.Select("EstatusTesoreriaSA = 'SOLICITUD RECHAZADA'").Count() + dtEmpleados.Select("EstatusTesoreriaSC = 'SOLICITUD RECHAZADA'").Count();
                int iEstatusJuridico = dtEmpleados.Select("EstatusJuridico = 'SOLICITUD RECHAZADA'").Count();

                if (iEstatusJuridico > 0)
                {
                    checkCmBxAreasRechazo.Properties.Items[0].Enabled = true;
                }
                if (iEstatusIMSS > 0)
                {
                    checkCmBxAreasRechazo.Properties.Items[1].Enabled = true;
                }
                if (iEstatusTeso > 0)
                {
                    checkCmBxAreasRechazo.Properties.Items[2].Enabled = true;
                }
            }
        }

        private void btnDocumentacion_Click(object sender, EventArgs e)
        {
            String stRutaSolicitud = miSolicitud.sRutaSolicitud;
            stRutaSolicitud += miSolicitud.idSolicitud;
            dsc.CheckandCreateFolder(stRutaSolicitud);
            Process.Start(stRutaSolicitud);
        }
        /// <summary>
        /// Boton para subir documentacion a la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            DataTable dtEmpleados = dsc.deGridViewaDataTable(gridVEmpleados);
            //Filtro de empleados sin documentacion
            //dtEmpleados = FiltroSinDocumentos(dtEmpleados);

            String stRutaSolicutud = miSolicitud.sRutaSolicitud + miSolicitud.idSolicitud;

            XtraMessageBox.Show(Environment.NewLine + "Se Importaran los archivos PDF de la siguiente carpeta: " + Environment.NewLine +
                stRutaSolicutud + Environment.NewLine + Environment.NewLine +
                "Por favor verifique que los documentos se encuentren en la carpeta y renombrados con el RFC de empleado correspondiente."
              , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (!Directory.Exists(stRutaSolicutud))
            {
                stRutaSolicutud = seleccionarRutaArchivos("No se encuenta la Carpeta: " + Environment.NewLine + stRutaSolicutud + "." + Environment.NewLine + "¿Desea seleccionar otra ubicacion?");
            }

            if (!String.IsNullOrEmpty(stRutaSolicutud))
            {
                String[] misArchivos = Directory.GetFiles(stRutaSolicutud, "*.PDF");

                if (misArchivos.Length > 0)
                {
                    validarArchivosEmpleados(misArchivos, dtEmpleados);
                }
                else
                {
                    DialogResult resultado = XtraMessageBox.Show("la ruta seleccionada: " + stRutaSolicutud + ", no contiene documentos."
                    , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        //private DataTable FiltroSinDocumentos(DataTable dtEmpleados)
        //{
        //    DataTable dtEmpleadosFitro = dtEmpleados.Clone();
        //    var query = from x in dtEmpleados.AsEnumerable()
        //                where x.Field<String>("")
        //}

        private String seleccionarRutaArchivos(String stmensaje)
        {
            DialogResult resultado = XtraMessageBox.Show(stmensaje
               , "SAIC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            String stRutaSolicutud = String.Empty;

            if (resultado == DialogResult.Yes)
            {
                using (var folderDialog = new FolderBrowserDialog())
                {
                    if (folderDialog.ShowDialog() == DialogResult.OK)
                    {
                        stRutaSolicutud = folderDialog.SelectedPath;
                    }
                }
            }

            return stRutaSolicutud;
        }

        /// <summary>
        /// Validar archivos que se encuentren en la carpeta seleccionada
        /// </summary>
        /// <param name="losArchivos"></param>
        /// <param name="dtEmpleados"></param>
        private void validarArchivosEmpleados(String[] losArchivos, DataTable dtEmpleados)
        {
            String[] nombreArchivos = losArchivos.Select(x => x.Replace(Path.GetDirectoryName(x) + @"\", "").Replace(Path.GetExtension(x), "")).ToArray();

            DataTable dtEmpleadosArchivos = new DataTable();
            dtEmpleadosArchivos.Columns.Add("IdEmpleado", typeof(int));
            dtEmpleadosArchivos.Columns.Add("RFC", typeof(String));
            dtEmpleadosArchivos.Columns.Add("RutaDocumento", typeof(String));
            dtEmpleadosArchivos.Columns.Add("Valor", typeof(String));
            dtEmpleadosArchivos.Columns.Add("Autorizado", typeof(int));

            List<String> archivosNoestan = new List<String>();

            stpSelParametroTableAdapter1.Fill(dbSAICBPOValidacionDataSet1.stpSelParametro, "LIMITEARCHIVO");

            if (dbSAICBPOValidacionDataSet1.stpSelParametro.Rows.Count > 0)
            {
                int iValorLimiteArchivos;
                int.TryParse(dbSAICBPOValidacionDataSet1.stpSelParametro.Rows[0]["ValorParametro"].ToString(), out iValorLimiteArchivos);

                foreach (DataRow unRow in dtEmpleados.Rows)
                {
                    //Validando que el archivo se encuentre en la ubicacion
                    int iEstaArchivo = Array.IndexOf(nombreArchivos, unRow["RFC"].ToString());
                    if (iEstaArchivo != -1)
                    {
                        //Validar el tamaño del archivo
                        FileInfo miArchivo = new FileInfo(losArchivos[iEstaArchivo]);
                        if (miArchivo.Length <= iValorLimiteArchivos)
                        {
                            DataRow unRowEmpleado = dtEmpleadosArchivos.NewRow();
                            unRowEmpleado["IdEmpleado"] = Convert.ToInt32(unRow["IdEmpleado"].ToString());
                            unRowEmpleado["RFC"] = unRow["RFC"].ToString();
                            unRowEmpleado["RutaDocumento"] = losArchivos[iEstaArchivo];
                            unRowEmpleado["Valor"] = dsc.ConvertToBytes(losArchivos[iEstaArchivo]);
                            unRowEmpleado["Autorizado"] = DisponibleParaSubir(Convert.ToInt32(unRow["IdEmpleado"].ToString()));
                            dtEmpleadosArchivos.Rows.Add(unRowEmpleado);
                        }
                        else
                        {
                            archivosNoestan.Add("Archivo del Empleado: " + unRow["IdEmpleado"].ToString() + ", Su tamaño excede de " + iValorLimiteArchivos + " KB");
                        }
                    }
                    else
                    {
                        archivosNoestan.Add("Archivo del Empleado: " + unRow["IdEmpleado"].ToString() + ", no se encuentra en al carpeta.");
                    }
                }
            }
            else
            {
                DialogResult resultado = XtraMessageBox.Show("No se tiene valor de limite para archivos."
                 , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



            if (dtEmpleadosArchivos.Rows.Count > 0 || archivosNoestan.Count > 0)
            {
                subirArchivosEmpleados(dtEmpleadosArchivos, archivosNoestan);
            }
            else
            {
                DialogResult resultado = XtraMessageBox.Show("No se encontraron Archivos en la Ruta."
                  , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private int DisponibleParaSubir(int idEmpledo)
        {
            int stResultado = 0;
            DataRow[] unRowResultado = dtEmpleadosGrid.Select("idEmpleado = '" + idEmpledo + "'");

            if (unRowResultado.Count() > 0)
            {
                int iColDocumentacion = 0;
                int.TryParse(dtEmpleadosGrid.Columns.IndexOf("Documentacion").ToString(), out iColDocumentacion);
                iColDocumentacion = iColDocumentacion == 0 ? 21 : iColDocumentacion;

                if (unRowResultado[0].ItemArray[iColDocumentacion].ToString() == "NO")
                {
                    stResultado = 1;
                }
            }

            return stResultado;
        }

        /// <summary>
        /// Subir Archivos a la base
        /// </summary>
        /// <param name="dtEmpleados"></param>
        /// <param name="archivosNoEstan"></param>
        private void subirArchivosEmpleados(DataTable dtEmpleados, List<String> archivosNoEstan)
        {
            splashScreenManager5.ShowWaitForm();
            archivosNoEstan.Add("*********Cargar Informacion*********");
            String stDetalle = String.Empty;
            int iContar = 0;
            int iNoSubidos = 0;

            foreach (DataRow unRow in dtEmpleados.Rows)
            {
                if (unRow["Autorizado"].ToString() == "1")
                {
                    try
                    {
                        splashScreenManager5.SetWaitFormCaption("Subiendo Documento");
                        splashScreenManager5.SetWaitFormDescription("Empleado " + unRow["IdEmpleado"].ToString() + "...");

                        queriesTableAdapter1.stpInsDocumentoEmpleados(
                                 Convert.ToInt32(unRow["IdEmpleado"]),
                                 unRow["Valor"].ToString(),
                                 "pdf",
                                 1,
                                 OperadorBD.OperadorGlobal.NombreUsuario
                                 );
                        iContar++;
                    }
                    catch (Exception ex)
                    {
                        archivosNoEstan.Add("Empleado " + unRow["IdEmpleado"].ToString() + " - " + ex.Message);
                        iNoSubidos++;
                    }
                }
            }

            if (archivosNoEstan.Count > 0)
            {
                try
                {
                    stDetalle = Environment.NewLine + "Detalle de Empleados:" + Environment.NewLine +
                               archivosNoEstan.Select(x => x.ToString() + Environment.NewLine);

                    File.WriteAllLines(miSolicitud.sRutaSolicitud + miSolicitud.idSolicitud + @"\Det Documentacion - " + dsc.nombreAleatorio() + ".txt", archivosNoEstan);
                }
                catch (Exception ex) { }
            }

            pintarGridEmpleados(miSolicitud.idSolicitud);

            splashScreenManager5.CloseWaitForm();

            XtraMessageBox.Show(
                "Total de Empleados: " + dtEmpleadosGrid.Rows.Count + Environment.NewLine +
                "Total de Empleados Con Documentos:" + dtEmpleadosGrid.Select("Documentacion = 'SI'").Count() + Environment.NewLine +
                "Total de Empleados Sin Documentos:" + dtEmpleadosGrid.Select("Documentacion = 'NO'").Count()
                           , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //    XtraMessageBox.Show("Documentacion Cargada:" + Environment.NewLine +
        //       "Total de Empleados: " + dtEmpleadosGrid.Rows.Count + Environment.NewLine +
        //       "Total Documentos Subidos: " + iContar + Environment.NewLine +
        //       "Documentos Faltantes: " + dtEmpleadosGrid.Select("Documentacion = 'NO'").Count() + Environment.NewLine +
        //       "Documentos no Encontrados en Carpeta: " + archivosNoEstan.Count + Environment.NewLine +
        //       "Documentos que exceden  1,000 KB: " + archivosNoEstan.Where(x => x.ToString().Contains("1,000 KB")).Count() + Environment.NewLine +
        //       "Documentos con Error: " + iNoSubidos + Environment.NewLine +
        //       "Total de Documentos por la Solicitud: " + dtEmpleadosGrid.Select("Documentacion = 'SI'").Count() + Environment.NewLine +
        //       "Total de Documentos Faltantes: " + (dtEmpleadosGrid.Rows.Count - dtEmpleadosGrid.Select("Documentacion = 'SI'").Count())
        //       , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}

        private void checkCmBxAreasRechazo_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void checkCmBxAreasRechazo_Click(object sender, EventArgs e)
        {

        }

        private void gridVEmpleados_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            valCheckBox(gridVEmpleados, 1);
        }

        private void toolBtnDescargarDocumentacion_Click(object sender, EventArgs e)
        {
            splashScreenManager5.ShowWaitForm();
            int iArchivosEstan = 0;
            int iArchivosNOEstan = 0;
            int iArchivosNoDescargados = 0;
            String stRutaSolicitud = dsc.stRutaSAIC + @"Alta Empleados Solicitudes\" + miSolicitud.idSolicitud + @"\";
            dsc.CheckandCreateFolder(stRutaSolicitud);
            DataTable dtEmpleados = dsc.deGridViewaDataTable(gridVEmpleados);
            foreach (DataRow unRow in dtEmpleados.Rows)
            {
                int idEmpleado = Convert.ToInt32(unRow["IdEmpleado"].ToString());
                try
                {
                    stpSelDocumentoEmpleadoTableAdapter1.Fill(dbSAICBPOCatalogosDataSet.stpSelDocumentoEmpleado, idEmpleado);
                    if (dbSAICBPOCatalogosDataSet.stpSelDocumentoEmpleado.Rows.Count > 0)
                    {
                        foreach (DataRow item in dbSAICBPOCatalogosDataSet.stpSelDocumentoEmpleado.Rows)
                        {
                            //Creando Carpeta por Empleado
                            String stRutaEmpleado = stRutaSolicitud + idEmpleado + @"\" + item["DesTipoDocumento"].ToString() + @"\";
                            dsc.CheckandCreateFolder(stRutaEmpleado);

                            String stNombreEmpleado = item["NombreEmpleadoCompleto"].ToString();
                            stNombreEmpleado = stNombreEmpleado.Replace("\\", "").Replace("/", "").Replace(":", "").Replace("+", "").Replace("?", "").Replace("\"", "").Replace("<", "").Replace(">", "").Replace("|", "");
                            dsc.ConvertToFile(item["DesDocumento"].ToString(), stRutaEmpleado + stNombreEmpleado + ".pdf");
                        }

                        iArchivosEstan++;
                    }
                    else
                    {
                        iArchivosNOEstan++;
                    }
                }
                catch (Exception)
                {
                    iArchivosNoDescargados++;
                }
            }
            splashScreenManager5.CloseWaitForm();
            XtraMessageBox.Show("Documentos Empleados." + Environment.NewLine +
                  "Documentos Generados: " + iArchivosEstan + Environment.NewLine +
                  "Documentos no Encontrados: " + iArchivosEstan + Environment.NewLine +
                  "Documentos no Descargados: " + iArchivosNoDescargados + Environment.NewLine +
                  "Los Documentos los podra revisar en la Ruta: " + stRutaSolicitud + Environment.NewLine + " De su computadora."
                  , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void solicitudToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DescargarContratos(true);


            //Juridico.XtraEmpleadosXSolicitudJuridico juridico = new Juridico.XtraEmpleadosXSolicitudJuridico(miSolicitud);

            //List<String> listRutaAnexos = new List<String>();
            //List<String> RutaContratos = new List<String>();
            //Boolean flatContinuar = true;
            //String stRutaSolicitud = dsc.stRutaAltaSolicitudEmpelados + miSolicitud.idSolicitud + @"\Operaciones\Contratos\";
            //int iConta = 1;
            //dsc.CheckandCreateFolder(stRutaSolicitud);


            //String stEmpleados = String.Empty;
            //DataTable dtEmpleasosSeleccionados = dsc.deGridViewSelectedToDataTable(gridVEmpleados);

            //if (dtEmpleasosSeleccionados.Rows.Count > 0)
            //{
            //    //Filtar Empleados que tengan autorizado Contrato
            //    dtEmpleasosSeleccionados = filtroEmpleadosContrato(dtEmpleasosSeleccionados);
            //    if (dtEmpleasosSeleccionados.Rows.Count > 0)
            //    {
            //        splashScreenManager5.ShowWaitForm();
            //        splashScreenManager5.SetWaitFormCaption("Descargando Anexos");
            //        splashScreenManager5.SetWaitFormDescription("Espere Por favor...");
            //        listRutaAnexos = juridico.DescargarAnexos(stRutaSolicitud);

            //        if (listRutaAnexos.Count == 0)
            //        {
            //            splashScreenManager5.CloseWaitForm();
            //            DialogResult resultado = XtraMessageBox.Show("No se tiene Anexos para la Solicitud " + miSolicitud.idSolicitud + ", de la tenedora: " + miSolicitud.TenedoraSA
            //                + Environment.NewLine + "¿Desea Continuar Sin Anexos?"
            //                , "SAIC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //            if (resultado == DialogResult.Yes) { flatContinuar = true; }
            //            else { flatContinuar = false; }
            //            splashScreenManager5.ShowWaitForm();
            //        }

            //        if (flatContinuar)
            //        {
            //            splashScreenManager5.SetWaitFormDescription("Descargando Contratos");

            //            foreach (DataRow item in dtEmpleasosSeleccionados.Rows)
            //            {
            //                splashScreenManager5.SetWaitFormDescription("Contratos " + iConta + " de " + dtEmpleasosSeleccionados.Rows.Count);
            //                Juridico.Reportes.CIT_PPP myReport = new Juridico.Reportes.CIT_PPP();

            //                myReport.Parameters["stEmpleados"].Value = item["idEmpleado"].ToString() + "|";

            //                myReport.ExportToPdf(stRutaSolicitud +
            //                          item["idEmpleado"].ToString() + " - " +
            //                          item["APaternoEmpleado"].ToString() + " " +
            //                          item["AMaternoEmpleado"].ToString() + " " +
            //                          item["NombreEmpleado"].ToString() + " temp" +
            //                          ".pdf");

            //                juridico.agregarAnexosVScontrato(stRutaSolicitud +
            //                           item["IdEmpleado"].ToString() + " - " +
            //                           item["APaternoEmpleado"].ToString() + " " +
            //                           item["AMaternoEmpleado"].ToString() + " " +
            //                           item["NombreEmpleado"].ToString() + " temp" +
            //                           ".pdf",
            //                           stRutaSolicitud + item["idEmpleado"].ToString() + " - " +
            //                           item["APaternoEmpleado"].ToString() + " " +
            //                           item["AMaternoEmpleado"].ToString() + " " +
            //                           item["NombreEmpleado"].ToString() +
            //                           ".pdf",
            //                           listRutaAnexos);

            //                RutaContratos.Add(stRutaSolicitud + item["idEmpleado"].ToString() + " - " +
            //                           item["APaternoEmpleado"].ToString() + " " +
            //                           item["AMaternoEmpleado"].ToString() + " " +
            //                           item["NombreEmpleado"].ToString() +
            //                           ".pdf");
            //                iConta++;
            //            }

            //            //Consolidar Archivos
            //            splashScreenManager5.SetWaitFormDescription("Consolidando Contratos");
            //            juridico.CosolidarArcchivos(stRutaSolicitud + "Contratos.pdf", RutaContratos);

            //            splashScreenManager5.CloseWaitForm();

            //            XtraMessageBox.Show("Contratos Descargados con Exito." + Environment.NewLine + "Ruta: " + stRutaSolicitud
            //                 , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        }
            //        else
            //        {
            //            splashScreenManager5.CloseWaitForm();
            //        }
            //    }
            //    else
            //    {
            //        XtraMessageBox.Show("Los empleados seleccionados no tiene Contrato Autorizado."
            //        , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
            //else
            //{
            //    XtraMessageBox.Show("Por favor seeleccione a un Empleado."
            //          , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        private DataTable filtroEmpleadosContrato(DataTable dtEmpleadosSeleccionados)
        {
            DataTable dtEmpleadosContrato = dtEmpleadosSeleccionados.Clone();
            var query = from x in dtEmpleadosSeleccionados.AsEnumerable()
                        where x.Field<String>("ContratoAutorizado") == "SI"
                        select x;

            if (query.Count() > 0)
            {
                dtEmpleadosContrato = query.CopyToDataTable();
            }

            return dtEmpleadosContrato;
        }

        private void individualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DescargarContratos(false);
        }


        private void DescargarContratos(Boolean porSolicitud)
        {
            Juridico.XtraEmpleadosXSolicitudJuridico juridico = new Juridico.XtraEmpleadosXSolicitudJuridico(miSolicitud);
            if (gridVEmpleados.SelectedRowsCount > 0)
            {
                splashScreenManager5.ShowWaitForm();
                splashScreenManager5.SetWaitFormCaption("Descargando Contratos");
                splashScreenManager5.SetWaitFormDescription("Espere por Favor...");

                String stMensaje = String.Empty;
                String stRutaSolicitud = miSolicitud.sRutaSolicitud + miSolicitud.idSolicitud + @"\";
                String stRutaAnexos = miSolicitud.sRutaSolicitud + miSolicitud.idSolicitud + @"\Anexos\";
                String stRutaDescargar = String.Empty;

                int iConta = 0;
                int iContaNoAutorizados = 0;
                int iContaSinContrato = 0;

                List<String> listRutaArchivos = new List<string>();
                dsc.CheckandCreateFolder(stRutaSolicitud);

                DataTable dtEmpleasosSeleccionados = dsc.deGridViewSelectedToDataTable(gridVEmpleados);

                iContaNoAutorizados = dtEmpleasosSeleccionados.Select("ContratoAutorizado = 'NO'").Count();
                foreach (DataRow unRow in dtEmpleasosSeleccionados.Rows)
                {
                    stRutaDescargar = String.Empty;

                    String stNombreCompletoEmpleado = unRow["APaternoEmpleado"].ToString() + " " +
                                unRow["AMaternoEmpleado"].ToString() + " " +
                                unRow["NombreEmpleado"].ToString();

                    if (!porSolicitud)
                    {
                        stRutaDescargar = stRutaSolicitud + unRow["idEmpleado"].ToString() + @"\";
                        dsc.CheckandCreateFolder(stRutaDescargar);
                    }
                    else
                    {
                        stRutaDescargar = stRutaSolicitud;
                    }

                    splashScreenManager5.SetWaitFormCaption("Descargando Contratos");
                    splashScreenManager5.SetWaitFormDescription((iConta + 1) + " de " + dtEmpleasosSeleccionados.Rows.Count);

                    int idEmpleado = 0;
                    int.TryParse(unRow["idEmpleado"].ToString(), out idEmpleado);

                    stpSelConsultaContratoEmpleadoTableAdapter1.Fill(dbSAICBPOCatalogosDataSet.stpSelConsultaContratoEmpleado, idEmpleado);
                    if (dbSAICBPOCatalogosDataSet.stpSelConsultaContratoEmpleado.Rows.Count > 0)
                    {
                        Boolean flagContratoGenerico = false;
                        flagContratoGenerico = dbSAICBPOCatalogosDataSet.stpSelConsultaContratoEmpleado.Rows[0]["TipoDocumentoContrato"].ToString() == "Rtf" ? false : true;

                        Juridico.Reportes.CIT_PPP myReport = new Juridico.Reportes.CIT_PPP();
                        myReport.Parameters["tipoConsulta"].Value = 1;
                        myReport.Parameters["ResultadoHTML"].Value = dbSAICBPOCatalogosDataSet.stpSelConsultaContratoEmpleado.Rows[0]["Contrato"].ToString();
                        myReport.Parameters["flagConGenerico"].Value = flagContratoGenerico;

                        String stNombreCompleatoEmpleados = unRow["APaternoEmpleado"].ToString() + " " +
                              unRow["AMaternoEmpleado"].ToString() + " " +
                              unRow["NombreEmpleado"].ToString();

                        String sRutaNombreCit = stRutaDescargar +
                                  unRow["idEmpleado"].ToString() + " - " +
                                  unRow["APaternoEmpleado"].ToString() + " " +
                                  unRow["AMaternoEmpleado"].ToString() + " " +
                                  unRow["NombreEmpleado"].ToString();

                        myReport.ExportToPdf(sRutaNombreCit + " - tmp.pdf");

                        //descargar los documentos para el contrato 
                        List<String> lstRutaDocumentos = juridico.DescargarDocumentosContrato("OPERACIONES", stRutaDescargar, stNombreCompleatoEmpleados, miSolicitud.idSolicitud, 0, Convert.ToInt32(unRow["idEmpleado"].ToString()));

                        stpSelParametroTableAdapter1.Fill(dbSAICBPOValidacionDataSet1.stpSelParametro, "ANEXAR DOC-CIT");
                        Boolean flagAnexarDocumento = false;

                        if (dbSAICBPOValidacionDataSet1.stpSelParametro.Rows.Count > 0)
                        {
                            flagAnexarDocumento = dbSAICBPOValidacionDataSet1.stpSelParametro.Rows[0]["ValorParametro"].ToString() == "SI" ? true : false;
                        }

                        if (flagAnexarDocumento)
                        {
                            juridico.agregarAnexosVScontrato(sRutaNombreCit + " - tmp.pdf",
                                          sRutaNombreCit + ".pdf",
                                          lstRutaDocumentos);
                            listRutaArchivos.Add(sRutaNombreCit + ".pdf");
                        }
                        else
                        {
                            listRutaArchivos.Add(sRutaNombreCit + " - tmp.pdf");
                        }

                        if (porSolicitud)
                        {
                            //Eliminar os archivos Documentos Contrato
                            eliminarArchivos(lstRutaDocumentos);
                        }



                        //descargar Contrato de Conficialidad
                        juridico.DescargarContratoConficialidad(stRutaDescargar, idEmpleado, stNombreCompletoEmpleado);

                        iConta++;
                    }
                    else
                    {
                        iContaSinContrato++;
                    }
                }

                if (listRutaArchivos.Count > 0)
                {
                    //DescargarAnexos
                    splashScreenManager5.SetWaitFormCaption("Descargando Contratos");
                    splashScreenManager5.SetWaitFormDescription("Descargando Anexos...");

                    List<String> listRutaAnexos = juridico.DescargarAnexos(stRutaAnexos, miSolicitud.idMatrizTenedora);
                    List<String> listArchivosTemporales = new List<string>();
                    if (listRutaAnexos.Count > 0)
                    {
                        splashScreenManager5.SetWaitFormCaption("Descargando Contratos");
                        splashScreenManager5.SetWaitFormDescription("Agregando Anexos...");

                        //renomrbrando los archivos como temporales
                        foreach (String rutaArchivo in listRutaArchivos)
                        {
                            File.Move(rutaArchivo, Path.GetDirectoryName(rutaArchivo) + @"\" + Path.GetFileNameWithoutExtension(rutaArchivo) + " - Temp" + Path.GetExtension(rutaArchivo));
                            listArchivosTemporales.Add(Path.GetDirectoryName(rutaArchivo) + @"\" + Path.GetFileNameWithoutExtension(rutaArchivo) + " - Temp" + Path.GetExtension(rutaArchivo));
                        }

                        int iContaArchivos = 0;
                        foreach (String RutaContrato in listRutaArchivos)
                        {
                            juridico.agregarAnexosVScontrato(listArchivosTemporales[iContaArchivos], RutaContrato, listRutaAnexos);
                            iContaArchivos++;
                        }
                    }
                    else
                    {
                        stMensaje = "Los Contratos descargados no contienen Anexos";
                    }

                    if (porSolicitud)
                    {
                        splashScreenManager5.SetWaitFormCaption("Descargando Contratos");
                        splashScreenManager5.SetWaitFormDescription("Consolidando...");
                        juridico.CosolidarArcchivos(stRutaDescargar + "Contratos Solicitud " + miSolicitud.idSolicitud + " - " + dsc.nombreAleatorio() + ".pdf", listRutaArchivos);
                    }
                }

                splashScreenManager5.CloseWaitForm();
                XtraMessageBox.Show("Descargar Contratos" + Environment.NewLine + "Contratos Descargados: " + iConta + Environment.NewLine +
                    "Contratos No Autorizados: " + iContaNoAutorizados + Environment.NewLine +
                    "Contratos NO Descargados y/o No Existen: " + iContaSinContrato + Environment.NewLine + Environment.NewLine + stMensaje
                    , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Por favor seeleccione a un Empleado."
                     , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void documentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridVEmpleados.SelectedRowsCount > 0)
            {
                DataTable dtEmpleados = dsc.deGridViewSelectedToDataTable(gridVEmpleados);
                descargarDocumentacionEmpleado(dtEmpleados, miSolicitud);
            }
            else
            {
                XtraMessageBox.Show("Seleccione un Empleado."
               , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //splashScreenManager5.ShowWaitForm();
            //splashScreenManager5.SetWaitFormCaption("Descargando Documentos");
            //splashScreenManager5.SetWaitFormDescription("Espere Por favor...");

            //int iArchivosEstan = 0;
            //int iArchivosNOEstan = 0;
            //int iArchivosNoDescargados = 0;
            //String stRutaSolicitud = dsc.stRutaSAIC + @"Alta Empleados Solicitudes\" + miSolicitud.idSolicitud + @"\";
            //dsc.CheckandCreateFolder(stRutaSolicitud);
            //DataTable dtEmpleados = dsc.deGridViewaDataTable(gridVEmpleados);
            //foreach (DataRow unRow in dtEmpleados.Rows)
            //{
            //    int idEmpleado = Convert.ToInt32(unRow["IdEmpleado"].ToString());
            //    try
            //    {
            //        stpSelDocumentoEmpleadoTableAdapter1.Fill(dbSAICBPOCatalogosDataSet.stpSelDocumentoEmpleado, idEmpleado);
            //        if (dbSAICBPOCatalogosDataSet.stpSelDocumentoEmpleado.Rows.Count > 0)
            //        {
            //            foreach (DataRow item in dbSAICBPOCatalogosDataSet.stpSelDocumentoEmpleado.Rows)
            //            {
            //                //Creando Carpeta por Empleado
            //                String stRutaEmpleado = dsc.stRutaAltaSolicitudEmpelados + miSolicitud.idSolicitud + @"\" + idEmpleado + @"\";
            //                dsc.CheckandCreateFolder(stRutaEmpleado);

            //                String stNombreEmpleado =  item["NombreEmpleadoCompleto"].ToString() + " - " + item["DesTipoDocumento"].ToString();
            //                stNombreEmpleado = stNombreEmpleado.Replace("\\", "").Replace("/", "").Replace(":", "").Replace("+", "").Replace("?", "").Replace("\"", "").Replace("<", "").Replace(">", "").Replace("|", "");
            //                dsc.ConvertToFile(item["DesDocumento"].ToString(), stRutaEmpleado + stNombreEmpleado + ".pdf");
            //            }

            //            iArchivosEstan++;
            //        }
            //        else
            //        {
            //            iArchivosNOEstan++;
            //        }
            //    }
            //    catch (Exception)
            //    {
            //        iArchivosNoDescargados++;
            //    }
            //}
            //splashScreenManager5.CloseWaitForm();
            //XtraMessageBox.Show("Descargar Documentos." + Environment.NewLine +
            //      "Documentos Generados: " + iArchivosEstan + Environment.NewLine +
            //      "Documentos no Encontrados: " + iArchivosNOEstan + Environment.NewLine +
            //      "Documentos no Descargados: " + iArchivosNoDescargados + Environment.NewLine +
            //      "Los Documentos los podra revisar en la Ruta: " + stRutaSolicitud + Environment.NewLine + " De su computadora."
            //      , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void descargarDocumentacionEmpleado(DataTable dtEmpleadosSeleccionados, Solicitud miSolicitud)
        {
            try
            {
                splashScreenManager5.ShowWaitForm();
                splashScreenManager5.SetWaitFormCaption("Descargando");
                splashScreenManager5.SetWaitFormDescription("Espere Por favor...");

                int iArchivosEstan = 0;
                int iArchivosNOEstan = 0;
                int iArchivosNoDescargados = 0;
                String stRutaSolicitud = miSolicitud.sRutaSolicitud + miSolicitud.idSolicitud + @"\";
                dsc.CheckandCreateFolder(stRutaSolicitud);

                //DataTable dtEmpleados = dsc.deGridViewaDataTable(gridVEmpleados);
                foreach (DataRow unRow in dtEmpleadosSeleccionados.Rows)
                {
                    int idEmpleado = Convert.ToInt32(unRow["IdEmpleado"].ToString());
                    try
                    {
                        stpSelDocumentoEmpleadoTableAdapter1.Fill(dbSAICBPOCatalogosDataSet.stpSelDocumentoEmpleado, idEmpleado);
                        if (dbSAICBPOCatalogosDataSet.stpSelDocumentoEmpleado.Rows.Count > 0)
                        {
                            foreach (DataRow item in dbSAICBPOCatalogosDataSet.stpSelDocumentoEmpleado.Rows)
                            {
                                //Creando Carpeta por Empleado
                                String stRutaEmpleado = miSolicitud.sRutaSolicitud + miSolicitud.idSolicitud + @"\" + idEmpleado + @"\";
                                dsc.CheckandCreateFolder(stRutaEmpleado);

                                String stNombreEmpleado = item["NombreEmpleadoCompleto"].ToString() + " - " + item["DesTipoDocumento"].ToString();
                                stNombreEmpleado = stNombreEmpleado.Replace("\\", "").Replace("/", "").Replace(":", "").Replace("+", "").Replace("?", "").Replace("\"", "").Replace("<", "").Replace(">", "").Replace("|", "");
                                dsc.ConvertToFile(item["DesDocumento"].ToString(), stRutaEmpleado + stNombreEmpleado + ".pdf");
                            }

                            iArchivosEstan++;
                        }
                        else
                        {
                            iArchivosNOEstan++;
                        }
                    }
                    catch (Exception)
                    {
                        iArchivosNoDescargados++;
                    }
                }
                splashScreenManager5.CloseWaitForm();
                XtraMessageBox.Show("Descargar Documentos." + Environment.NewLine +
                      "Documentos Generados: " + iArchivosEstan + Environment.NewLine +
                      "Documentos no Encontrados: " + iArchivosNOEstan + Environment.NewLine +
                      "Documentos no Descargados: " + iArchivosNoDescargados + Environment.NewLine +
                      "Los Documentos los podra revisar en la Ruta: " + stRutaSolicitud + Environment.NewLine + " De su computadora."
                      , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("No se puede descargar la documentación." + Environment.NewLine + ex.Message
                         , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public String descargarDocumentacionEmpleado(Empleado objEmp, String stRutaDescarga)
        {
            String stMensaje = String.Empty;
            String stNombreCompletoEmpleado = objEmp.APaternoEmpleado + " " + objEmp.AMaternoEmpleado + " " + objEmp.NombreEmpleado;

            try
            {
                stpSelDocumentoEmpleadoTableAdapter1.Fill(dbSAICBPOCatalogosDataSet.stpSelDocumentoEmpleado, Convert.ToInt32(objEmp.IdEmpleado));

                String stRutaEmpleado = stRutaDescarga;
                dsc.CheckandCreateFolder(stRutaEmpleado);

                if (dbSAICBPOCatalogosDataSet.stpSelDocumentoEmpleado.Rows.Count > 0)
                {
                    //Creando Carpeta por Empleado
                    foreach (DataRow unRow in dbSAICBPOCatalogosDataSet.stpSelDocumentoEmpleado.Rows)
                    {
                        String stNombreEmpleado = unRow["NombreEmpleadoCompleto"].ToString();
                        stNombreEmpleado = stNombreEmpleado.Replace("\\", "").Replace("/", "").Replace(":", "").Replace("+", "").Replace("?", "").Replace("\"", "").Replace("<", "").Replace(">", "").Replace("|", "");
                        dsc.ConvertToFile(unRow["DesDocumento"].ToString(), stRutaEmpleado + unRow["DesTipoDocumento"].ToString() + " " + stNombreEmpleado + ".pdf");
                    }

                    stMensaje = "Documento Descargado con Exito." + Environment.NewLine + "Ruta de Descarga:" + stRutaEmpleado;
                }
                else
                {
                    stMensaje = "No se encuentra el documento del empleado: " + stNombreCompletoEmpleado;
                }

            }
            catch (Exception ex)
            {
                stMensaje = "No se puede descargar el documento de " + stNombreCompletoEmpleado + Environment.NewLine + ex.Message;
            }

            return stMensaje;
        }



        private void contratosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void solicitudToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DescargarContratos(true);
        }

        private void individualToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DescargarContratos(false);
        }

        private void fielToolStripMenuItem_Click(object sender, EventArgs e)
        {
            splashScreenManager5.ShowWaitForm();
            splashScreenManager5.SetWaitFormCaption("Descargando Afil");
            splashScreenManager5.SetWaitFormDescription("Espere Por favor...");

            try
            {
                String stRuta = miSolicitud.sRutaSolicitud + miSolicitud.idSolicitud + @"\";
                int iConta = DescargsarFiel(miSolicitud.idSolicitud, stRuta, miSolicitud.idTipoSolicitud);
                splashScreenManager5.CloseWaitForm();
                XtraMessageBox.Show("Documentos Afil Descargados: " + iConta
                   , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                splashScreenManager5.CloseWaitForm();
                XtraMessageBox.Show("Error al descargar Documentos." + Environment.NewLine + ex.Message
                   , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public int DescargsarFiel(int idSolicitud, String stRuta, int idTipoSolicitud)
        {
            //String stRuta = dsc.stRutaAltaSolicitudEmpleados + idSolicitud + @"\";
            dsc.CheckandCreateFolder(stRuta);

            stpSelDocumentosIMSS_1TableAdapter1.Fill(dbSAICBPOCatalogosDataSet.stpSelDocumentosIMSS_1, idSolicitud, idTipoSolicitud);
            if (dbSAICBPOCatalogosDataSet.stpSelDocumentosIMSS_1.Rows.Count > 0)
            {
                foreach (DataRow unRow in dbSAICBPOCatalogosDataSet.stpSelDocumentosIMSS_1.Rows)
                {
                    System.Threading.Thread.Sleep(500);
                    dsc.ConvertToFile(unRow["Valor"].ToString(), stRuta + "Afil - " + unRow["NombreArchivo"].ToString().Replace(".pdf", "") + " " + dsc.nombreAleatorio() + unRow["Extencion"]);
                }
            }

            return dbSAICBPOCatalogosDataSet.stpSelDocumentosIMSS_1.Rows.Count;
        }

        private void contratosTarjetasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private String stObtenerInformacionEmpleadosCorrespondencia(int idSolicitud)
        {
            String stEmpleadosCorrespondencia = String.Empty;
            stpSelInfoEmpleadosCorrespondenciaTableAdapter1.Fill(dbSAICBPOCatalogosDataSet.stpSelInfoEmpleadosCorrespondencia, idSolicitud);
            stEmpleadosCorrespondencia = dsc.ConvertDataTableToString(dbSAICBPOCatalogosDataSet.stpSelInfoEmpleadosCorrespondencia, true);
            return stEmpleadosCorrespondencia;
        }

        public DataTable ObtenerInformacionEmpleadosCorrespondencia(int idEmpleado)
        {
            stpSelInfoEmpleadosCorrespondenciaXEmpleadoTableAdapter1.Fill(dbSAICBPOCatalogosDataSet.stpSelInfoEmpleadosCorrespondenciaXEmpleado, idEmpleado);
            return dbSAICBPOCatalogosDataSet.stpSelInfoEmpleadosCorrespondenciaXEmpleado;
        }

        private void gridVEmpleados_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                if (e.RowHandle >= 0)
                {
                    gridVEmpleados.OptionsSelection.EnableAppearanceFocusedRow = false;

                    if (gridVEmpleados.GetDataRow(e.RowHandle)["idEstatus"].ToString() == "23")
                    {
                        e.Appearance.BackColor = Color.FromArgb(miColorSolicitud.idColorInactivo[0], miColorSolicitud.idColorInactivo[1], miColorSolicitud.idColorInactivo[2]);
                        e.HighPriority = true;
                    }
                    else
                    {
                        //string category = View.GetRowCellDisplayText(e.RowHandle, View.Columns["Category"]);
                        if (gridVEmpleados.GetDataRow(e.RowHandle)["Tipo de Alta"].ToString() == "REINGRESO")
                        {
                            e.Appearance.BackColor = Color.FromArgb(miColorSolicitud.idColorReingreso[0], miColorSolicitud.idColorReingreso[1], miColorSolicitud.idColorReingreso[2]);
                            e.Appearance.BackColor2 = Color.White;
                            e.HighPriority = true;
                        }

                        if (gridVEmpleados.GetDataRow(e.RowHandle)["DescEstatus"].ToString() == "BAJA")
                        {
                            e.Appearance.BackColor = Color.FromArgb(miColorSolicitud.idColorBaja[0], miColorSolicitud.idColorBaja[1], miColorSolicitud.idColorBaja[2]);
                            e.HighPriority = true;
                        }

                        if (gridVEmpleados.GetDataRow(e.RowHandle)["EstatusImss"].ToString() == "SOLICITUD ATENDIDA AL 100%" &&
                            gridVEmpleados.GetDataRow(e.RowHandle)["EstatusJuridico"].ToString() == "SOLICITUD ATENDIDA AL 100%" &&
                            gridVEmpleados.GetDataRow(e.RowHandle)["EstatusTesoreriaSA"].ToString() == "SOLICITUD ATENDIDA AL 100%" &&
                            gridVEmpleados.GetDataRow(e.RowHandle)["EstatusTesoreriaSC"].ToString() == "SOLICITUD ATENDIDA AL 100%")
                        {
                            e.Appearance.BackColor = Color.FromArgb(miColorSolicitud.idColorAtendida[0], miColorSolicitud.idColorAtendida[1], miColorSolicitud.idColorAtendida[2]);
                            e.HighPriority = true;
                        }
                        else if (gridVEmpleados.GetDataRow(e.RowHandle)["EstatusImss"].ToString() == "SOLICITUD RECHAZADA" ||
                            gridVEmpleados.GetDataRow(e.RowHandle)["EstatusJuridico"].ToString() == "SOLICITUD RECHAZADA" ||
                            gridVEmpleados.GetDataRow(e.RowHandle)["EstatusTesoreriaSA"].ToString() == "SOLICITUD RECHAZADA" ||
                            gridVEmpleados.GetDataRow(e.RowHandle)["EstatusTesoreriaSC"].ToString() == "SOLICITUD RECHAZADA")
                        {

                            e.Appearance.BackColor = Color.FromArgb(miColorSolicitud.idColorRechazada[0], miColorSolicitud.idColorRechazada[1], miColorSolicitud.idColorRechazada[2]);
                            e.HighPriority = true;
                        }
                    }

                }
            }
            catch (Exception) { }
        }

        private void gridLookSolitudes_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                if (e.RowHandle >= 0)
                {
                    gridLookSolitudes.OptionsSelection.EnableAppearanceFocusedRow = false;

                    if (gridLookSolitudes.GetDataRow(e.RowHandle)["EstatusSolicitud"].ToString() == "SOLICITUD RECHAZADA")
                    {
                        e.Appearance.BackColor = Color.FromArgb(miColorSolicitud.idColorRechazada[0], miColorSolicitud.idColorRechazada[1], miColorSolicitud.idColorRechazada[2]);
                        e.HighPriority = true;
                    }
                }
            }
            catch (Exception ex) { }
        }

        private void mostrarInformacionDeCuentasDeEmpleados(int idSolicitud)
        {

            cbxTodosLosEmpleados.Visible = true;
            groupControl2.Visible = false;
            groupControlAltaCuentas.Visible = true;

            try
            {
                stpSelObtenerEmpleadosSolicitudCuentasOperacionesTableAdapter1.Fill(dbSAICBPOCatalogosDataSet.stpSelObtenerEmpleadosSolicitudCuentasOperaciones, idSolicitud, OperadorBD.OperadorGlobal.IdOperador, cbxTodosLosEmpleados.Checked, 0);
            }
            catch (Exception) { }

            miSolicitud.iTotalDeEmpleados = dbSAICBPOCatalogosDataSet.stpSelObtenerEmpleadosSolicitudCuentasOperaciones.Rows.Count;
            txtETotal.Text = miSolicitud.iTotalDeEmpleados.ToString();
            if (miSolicitud.iTotalDeEmpleados > 0)
            {
                lblNumeroEmpleados.Text = "Numero de Empleados: " + dbSAICBPOCatalogosDataSet.stpSelObtenerEmpleadosSolicitudCuentasOperaciones.Rows.Count;
                EstatusSolicitudCuentas(dbSAICBPOCatalogosDataSet.stpSelObtenerEmpleadosSolicitudCuentasOperaciones);

                var miQueryAtendidas = from x in dbSAICBPOCatalogosDataSet.stpSelObtenerEmpleadosSolicitudCuentasOperaciones.AsEnumerable()
                                       where x.Field<String>("Estatus Tesoreria SA").Equals("SOLICITUD ATENDIDA AL 100%") &&
                                       x.Field<String>("Estatus Tesoreria SC").Equals("SOLICITUD ATENDIDA AL 100%")
                                       && x.Field<int>("idEstatus").Equals(2)
                                       select x;

                var miQueryCancelados = from x in dbSAICBPOCatalogosDataSet.stpSelObtenerEmpleadosSolicitudCuentasOperaciones.AsEnumerable()
                                        where x.Field<int>("idEstatus").Equals(23)
                                        select x;

                var miQueryRechazadas = from x in dbSAICBPOCatalogosDataSet.stpSelObtenerEmpleadosSolicitudCuentasOperaciones.AsEnumerable()
                                        where (x.Field<String>("Estatus Tesoreria SA").Equals("SOLICITUD RECHAZADA") ||
                                        x.Field<String>("Estatus Tesoreria SC").Equals("SOLICITUD RECHAZADA")) &&
                                        x.Field<int>("IdEstatus").Equals(2)
                                        select x;

                txteAtendidos.Text = miQueryAtendidas.Count().ToString();
                txteRechazados.Text = miQueryRechazadas.Count().ToString();
                txtCancelados.Text = miQueryRechazadas.Count().ToString();

                if (miQueryRechazadas.Count() > 0)
                {
                    DataTable dtEmpleadosRechazados = miQueryRechazadas.CopyToDataTable();
                    gridCtrlEmpleadosAltaDeCuentas.DataSource = dtEmpleadosRechazados;
                    btnResponderRechazo.Enabled = flaghabilitarResponderSolicitud;
                    checkCmBxAreasRechazo.Enabled = flaghabilitarResponderSolicitud;

                    //checkCmBxAreasRechazo.Properties.Items[0].CheckState = CheckState.Unchecked;
                    //checkCmBxAreasRechazo.Properties.Items[1].CheckState = CheckState.Unchecked;
                    checkCmBxAreasRechazo.Properties.Items[2].CheckState = CheckState.Unchecked;
                    //checkCmBxAreasRechazo.Properties.Items[3].CheckState = CheckState.Unchecked;

                    gridVEmpleadoCuenta.OptionsSelection.MultiSelect = true;
                    gridVEmpleadoCuenta.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
                }
                else
                {
                    dtEmpleadosGrid = obtenerInformacionDoCumentos(dbSAICBPOCatalogosDataSet.stpSelObtenerEmpleadosSolicitudCuentasOperaciones);
                    gridCtrlEmpleadosAltaDeCuentas.DataSource = dtEmpleadosGrid;
                }

                btnExportarExcel.Enabled = true;
                btnAbrirCarpeta.Enabled = true;
                toolStripDescargas.Enabled = false;
                documentosToolStripMenuItem.Enabled = false;
                fielToolStripMenuItem.Enabled = false;
                contratosToolStripMenuItem.Enabled = false;
                solicitudToolStripMenuItem1.Enabled = false;
                individualToolStripMenuItem1.Enabled = false;
                btnDocumentacion.Enabled = false;
                toolStripDescargas.Enabled = false;
            }
        }

        private void gridVEmpleadoCuenta_DoubleClick(object sender, EventArgs e)
        {
            gridVEmpleadoCuenta.Focus();
            DataRow unRow = gridVEmpleadoCuenta.GetDataRow(gridVEmpleadoCuenta.FocusedRowHandle);
            if (unRow != null)
            {
                int iIdEmpleado = 0;
                int idSolicitud = 0;
                int.TryParse(unRow["IdEmpleado"].ToString(), out iIdEmpleado);
                int.TryParse(unRow["IdSolicitud"].ToString(), out idSolicitud);

                Boolean banTesoreria = unRow["Estatus Tesoreria SA"].ToString() == "SOLICITUD RECHAZADA" ? true : false;

                if (banTesoreria)
                {

                    Boolean taMuyBien = true;
                    DataTable dt = this.stpSelObtenerInfoEmpleadoModificacionCFDITableAdapter1.GetData(iIdEmpleado);
                    Empleado miEmpleado = EmpleadoBD.ObtenerInfoEmpleadoModificacionCFDI(dt);

                    if (idSolicitud != miSolicitud.idSolicitud)
                    {
                        DialogResult drResultado = XtraMessageBox.Show("Se va a realizar cambio de Clabe de la Solicitud: " + idSolicitud + " del Empleado: " + miEmpleado.APaternoEmpleado + " " + miEmpleado.AMaternoEmpleado + " " + miEmpleado.NombreEmpleado + "." + Environment.NewLine + "¿Desea Continuar?"
               , "SAIC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (DialogResult.Yes == drResultado)
                        {
                            taMuyBien = true;
                        }
                        else
                        {
                            taMuyBien = false;
                        }
                    }

                    if (taMuyBien)
                    {
                        XtraSolicitudAltaCtaBancarias formCuentaEmpleado = new XtraSolicitudAltaCtaBancarias(miEmpleado, idSolicitud, true);
                        formCuentaEmpleado.ShowDialog();
                        ObtenerInformacionDetalleSolicitud(idSolicitud);
                    }
                }
            }
        }

        private void valCheckBox(GridView miGrid, int tipoSolicitud)
        {
            checkCmBxAreasRechazo.Properties.Items[0].Enabled = false;
            checkCmBxAreasRechazo.Properties.Items[1].Enabled = false;
            checkCmBxAreasRechazo.Properties.Items[2].Enabled = false;
            //checkCmBxAreasRechazo.Properties.Items[3].Enabled = false;

            //DataTable dtEmpleados = dsc.deGridViewSelectedToDataTable(gridVEmpleados);
            DataTable dtEmpleados = dsc.deGridViewSelectedToDataTable(miGrid);

            if (dtEmpleados.Rows.Count > 0)
            {
                if (tipoSolicitud == 1)
                {
                    int iEstatusIMSS = dtEmpleados.Select("EstatusImss = 'SOLICITUD RECHAZADA'").Count();
                    int iEstatusTeso = dtEmpleados.Select("EstatusTesoreriaSA = 'SOLICITUD RECHAZADA'").Count();
                    int iEstatusTesoSC = dtEmpleados.Select("EstatusTesoreriaSC = 'SOLICITUD RECHAZADA'").Count();
                    int iEstatusJuridico = dtEmpleados.Select("EstatusJuridico = 'SOLICITUD RECHAZADA'").Count();

                    if (iEstatusJuridico > 0)
                    {
                        checkCmBxAreasRechazo.Properties.Items[0].Enabled = true;
                    }
                    if (iEstatusIMSS > 0)
                    {
                        checkCmBxAreasRechazo.Properties.Items[1].Enabled = true;
                    }
                    if (iEstatusTeso > 0)
                    {
                        checkCmBxAreasRechazo.Properties.Items[2].Enabled = true;
                    }
                    if (iEstatusTesoSC > 0)
                    {
                        checkCmBxAreasRechazo.Properties.Items[3].Enabled = true;
                    }
                }
                else if (tipoSolicitud == 3)
                {
                    int iEstatusTeso = dtEmpleados.Select("[Estatus Tesoreria SA] = 'SOLICITUD RECHAZADA'").Count();
                    int iEstatusTesoSC = dtEmpleados.Select("[Estatus Tesoreria SC] = 'SOLICITUD RECHAZADA'").Count();

                    if (iEstatusTeso > 0)
                    {
                        checkCmBxAreasRechazo.Properties.Items[2].Enabled = true;
                    }
                    if (iEstatusTesoSC > 0)
                    {
                        checkCmBxAreasRechazo.Properties.Items[3].Enabled = true;
                    }
                }
                else if (tipoSolicitud == 4)
                {
                    int iEstatusIMSS = dtEmpleados.Select("[EstatusIMSS] = 'SOLICITUD RECHAZADA'").Count();

                    if (iEstatusIMSS > 0)
                    {
                        checkCmBxAreasRechazo.Properties.Items[1].Enabled = true;
                    }
                }
            }
        }

        private void gridVEmpleadoCuenta_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            valCheckBox(gridVEmpleadoCuenta, 3);
        }

        public void descargarArchivoEmpleadosCuentas(DataTable dtSolicitud, Solicitud miSolicitud, int iArea)
        {
            splashScreenManager5.ShowWaitForm();
            splashScreenManager5.SetWaitFormCaption("Descargando Archivo");
            splashScreenManager5.SetWaitFormDescription("Espere Por favor...");

            String stRutaArchivo = String.Empty;
            dsc.CheckandCreateFolder(stRutaArchivo = miSolicitud.sRutaSolicitud + miSolicitud.idSolicitud + @"\");
            stRutaArchivo = miSolicitud.sRutaSolicitud + miSolicitud.idSolicitud + @"\" + "S" + miSolicitud.idSolicitud + "-" + miSolicitud.idTenedoraSA + "-E" + dtSolicitud.Rows.Count + " " + dsc.nombreAleatorio() + ".xlsx";

            String stDatosSolciitud = dsc.ConvertDataTableToString(dtSolicitud, true);
            String stUltimaColumna = dsc.NumToLetterColumnExcel(dtSolicitud.Columns.Count);

            try
            {
                if (!String.IsNullOrEmpty(stDatosSolciitud))
                {
                    Excel.Application appExcel;
                    Excel.Workbooks booksExcel;
                    Excel.Workbook bookExcel;
                    Excel.Worksheet SheetExcel;
                    Excel.Range Rango;

                    appExcel = new Excel.Application();
                    booksExcel = appExcel.Workbooks;
                    bookExcel = booksExcel.Add();
                    appExcel.Visible = true;
                    appExcel.DisplayAlerts = false;

                    //--------------------------------------
                    System.Threading.Thread.Sleep(1000);
                    Clipboard.Clear();
                    System.Threading.Thread.Sleep(1000);
                    Clipboard.SetText(stDatosSolciitud);

                    SheetExcel = (Excel.Worksheet)bookExcel.Sheets.Add();
                    SheetExcel = (Excel.Worksheet)bookExcel.ActiveSheet;
                    SheetExcel.Name = "S" + miSolicitud.idSolicitud.ToString() + " Det. Solicitud";

                    Rango = SheetExcel.get_Range("A:" + stUltimaColumna);
                    Rango.Select();
                    Rango.NumberFormat = "@";

                    Rango = SheetExcel.get_Range("A1");
                    Rango.Select();
                    Rango.PasteSpecial();

                    Rango = SheetExcel.get_Range("A1:" + stUltimaColumna + "1");
                    Rango.Select();
                    Rango.Interior.Pattern = Excel.XlPattern.xlPatternSolid;
                    Rango.Interior.PatternColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic;
                    Rango.Interior.ThemeColor = Excel.XlThemeColor.xlThemeColorAccent1;
                    Rango.Interior.TintAndShade = -0.499984740745262;
                    Rango.Interior.PatternTintAndShade = 0;

                    Rango.Font.ThemeColor = Excel.XlThemeColor.xlThemeColorDark1;
                    Rango.Font.TintAndShade = 0;
                    Rango.Font.Bold = true;
                    Rango.Font.Size = 14;

                    SheetExcel.Cells.Select();
                    SheetExcel.Cells.EntireColumn.AutoFit();

                    appExcel.DisplayAlerts = true;

                    bookExcel.SaveAs(stRutaArchivo);

                    splashScreenManager5.CloseWaitForm();

                    XtraMessageBox.Show("Archivo Generado con Exito."
                   , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                splashScreenManager5.CloseWaitForm();
                XtraMessageBox.Show("No se puede generar el archivo de Excel."
                  , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (!String.IsNullOrEmpty(stDatosSolciitud))
                {
                    stRutaArchivo = miSolicitud.sRutaSolicitud + miSolicitud.idSolicitud + @"\Detalle Solicitud -" + "S" + miSolicitud.idSolicitud + "-" + miSolicitud.idTenedoraSA + "-E" + dtSolicitud.Rows.Count + " " + dsc.nombreAleatorio() + ".txt";
                    File.WriteAllText(stRutaArchivo, stDatosSolciitud);
                }

                XtraMessageBox.Show("Archivos de texto Guardados en Ruta:" + Environment.NewLine +
                    miSolicitud.sRutaSolicitud + miSolicitud.idSolicitud + @"\"
                 , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void eliminarArchivos(List<String> lstRutaArchvios)
        {
            foreach (String item in lstRutaArchvios) { File.Delete(item); }
        }

        private void repositoryItemButtonEditEditar_Click(object sender, EventArgs e)
        {
            DataRow unRow = gridViewSalarios.GetDataRow(gridViewSalarios.FocusedRowHandle);

            if (unRow["idEstatus"].ToString() == "2")
            {
                if (unRow["EstatusIMSS"].ToString() == "SOLICITUD RECHAZADA")
                {
                    int idEmpleado = 0;
                    decimal dcSD = 0;
                    decimal dcParteVariable = 0;
                    DateTime dtFechaDeAplicacion = new DateTime();

                    int.TryParse(unRow["idEmpleado"].ToString(), out idEmpleado);
                    decimal.TryParse(unRow["SDNuevo"].ToString(), out dcSD);
                    decimal.TryParse(unRow["ParteVariable"].ToString(), out dcParteVariable);
                    DateTime.TryParse(unRow["FechaAplicacion"].ToString(), out dtFechaDeAplicacion);

                    frmxModificacionEmpleadosOperador ofrmxModificacionEmpleadosOperador = new frmxModificacionEmpleadosOperador();
                    Empleado oEmpleado = ofrmxModificacionEmpleadosOperador.ObtenerInformacionEmpleado(idEmpleado);

                    XtrasSolicitudSalariosEmpleado oXtrasSolicitudSalariosEmpleado = new XtrasSolicitudSalariosEmpleado(
                        false,
                        miSolicitud.idSolicitud,
                        oEmpleado,
                        dcSD,
                        dcParteVariable,
                        dtFechaDeAplicacion);

                    oXtrasSolicitudSalariosEmpleado.ShowDialog();
                    obtenerInformacion();
                    mostrarSolicitud();
                }
                else
                {
                    XtraMessageBox.Show("No se puede Editar al Empleado, requiere estar Rechazado."
                    , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                XtraMessageBox.Show("La Solicitud del Empleado no esta Activa."
                 , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gridViewSalarios_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            valCheckBox(gridViewSalarios, 4);
        }

        private void gridViewSalarios_RowStyle(object sender, RowStyleEventArgs e)
        {
            try
            {
                if (e.RowHandle >= 0)
                {
                    gridViewSalarios.OptionsSelection.EnableAppearanceFocusedRow = false;

                    if (gridViewSalarios.GetDataRow(e.RowHandle)["EstatusIMSS"].ToString() == "SOLICITUD ATENDIDA AL 100%")
                    {
                        e.Appearance.BackColor = Color.FromArgb(miColorSolicitud.idColorAtendida[0], miColorSolicitud.idColorAtendida[1], miColorSolicitud.idColorAtendida[2]);
                        e.HighPriority = true;
                    }
                    else if (gridViewSalarios.GetDataRow(e.RowHandle)["EstatusIMSS"].ToString() == "SOLICITUD RECHAZADA")
                    {
                        e.Appearance.BackColor = Color.FromArgb(miColorSolicitud.idColorRechazada[0], miColorSolicitud.idColorRechazada[1], miColorSolicitud.idColorRechazada[2]);
                        e.HighPriority = true;
                    }
                }
            }
            catch (Exception ex) { }
        }

        //Cancelar Solciitud
        private void repositoryItemButtonEditCancelar_Click(object sender, EventArgs e)
        {
            DataRow unRow = gridViewSalarios.GetDataRow(gridViewSalarios.FocusedRowHandle);

            if (unRow["idEstatus"].ToString() == "2")
            {
                if (unRow["idEstatusIMSS"].ToString() == "24")
                {

                    DialogResult oDialogResult = XtraMessageBox.Show("¿Esta seguro de Cancelar la solicitud del empleado " + unRow["NombreEmpleadoCompleto"].ToString() + "?"
                              , "SAIC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (DialogResult.Yes == oDialogResult)
                    {
                        int idEmpleado = 0;
                        String sRespuesta = String.Empty;

                        int.TryParse(unRow["IdEmpleado"].ToString(), out idEmpleado);

                        queriesOperacionesAdapter1.stpUpdCancelarEmpleadoSolicitud(miSolicitud.idSolicitud, idEmpleado, OperadorBD.OperadorGlobal.NombreUsuario, ref sRespuesta);

                        XtraMessageBox.Show(sRespuesta
                          , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        obtenerInformacion();
                        mostrarSolicitud();
                    }
                }
                else
                {
                    XtraMessageBox.Show("No se puede Cancelar la solicitud del Empleado, requiere estar Rechazado."
                    , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                XtraMessageBox.Show("La Solicitud del Empleado no esta Activa."
                , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void habilitarSubirDocumentacion()
        {
            try
            {
                this.stpFactSelDerechosAccesoOperadorFacturacionTableAdapter1.Fill(this.dbSAICBPOFactura1.stpFactSelDerechosAccesoOperadorFacturacion, OperadorBD.OperadorGlobal.IdOperador, "btnSolicitudAltaEmpleadosOperaciones.Botones", "btnAcceso");
                if (dbSAICBPOFactura1.stpFactSelDerechosAccesoOperadorFacturacion.Rows.Count > 0)
                {
                    Boolean.TryParse(dbSAICBPOFactura1.stpFactSelDerechosAccesoOperadorFacturacion.Rows[0]["Consultar"].ToString(), out flaghabilitarSubirDocumentacion);
                    Boolean.TryParse(dbSAICBPOFactura1.stpFactSelDerechosAccesoOperadorFacturacion.Rows[0]["Actualizar"].ToString(), out flaghabilitarResponderSolicitud);
                }
                else
                {
                    flaghabilitarSubirDocumentacion = false;
                    flaghabilitarResponderSolicitud = false;
                }
            }
            catch (Exception ex)
            {
                flaghabilitarSubirDocumentacion = false;
                flaghabilitarResponderSolicitud = false;
            }
        }

        private void ItemButtonEditCancelar_Click(object sender, EventArgs e)
        {
            gridVEmpleados.Focus();
            DataRow unRow = gridVEmpleados.GetDataRow(gridVEmpleados.FocusedRowHandle);
            if (unRow != null)
            {
                Boolean flagTaMuyBien = false;

                if (unRow["idEstatus"].ToString() == "2")
                {
                    if (miSolicitud.DescTipoSolicitud == "ALTA DE EMPLEADOS")
                    {
                        if (unRow["EstatusJuridico"].ToString() == "SOLICITUD RECHAZADA" && unRow["EstatusImss"].ToString() == "SOLICITUD RECHAZADA")
                        {
                            flagTaMuyBien = true;
                        }
                        else
                        {
                            XtraMessageBox.Show("El empleado require estar RECHAZADO por el área del IMSS y Juridico."
                            , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (miSolicitud.DescTipoSolicitud == "BAJA DE EMPLEADOS")
                    {
                        if (unRow["EstatusImss"].ToString() == "SOLICITUD RECHAZADA" && unRow["EstatusJuridico"].ToString() == "SOLICITUD RECHAZADA")
                        {
                            flagTaMuyBien = true;
                        }
                        else
                        {
                            XtraMessageBox.Show("El empleado require estar RECHAZADO por el área del IMSS y Juridico."
                            , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                    if (flagTaMuyBien)
                    {
                        DialogResult oDialogResult = XtraMessageBox.Show("¿Esta seguro de Cancelar la solicitud del empleado " + unRow["APaternoEmpleado"].ToString() + " " +
                                   unRow["AMaternoEmpleado"].ToString() + " " +
                                   unRow["NombreEmpleado"].ToString() + "?"
                             , "SAIC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (DialogResult.Yes == oDialogResult)
                        {
                            int idEmpleado = 0;
                            String sRespuesta = String.Empty;

                            int.TryParse(unRow["IdEmpleado"].ToString(), out idEmpleado);

                            queriesOperacionesAdapter1.stpUpdCancelarEmpleadoSolicitud(miSolicitud.idSolicitud, idEmpleado, OperadorBD.OperadorGlobal.NombreUsuario, ref sRespuesta);

                            XtraMessageBox.Show(sRespuesta
                              , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            obtenerInformacion();
                            mostrarSolicitud();
                        }
                    }
                }
                else
                {
                    XtraMessageBox.Show("El registro del Empleado en la solicitud no se encuentra Activa."
                              , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ItemButtonEditEditar_Click(object sender, EventArgs e)
        {
            EditarEmpleado();
        }

        private void EditarEmpleado()
        {
            gridVEmpleados.Focus();
            DataRow unRow = gridVEmpleados.GetDataRow(gridVEmpleados.FocusedRowHandle);
            if (unRow != null)
            {
                if (unRow["Estatusregistro"].ToString() == "ACTIVO")
                {
                    int iIdEmpleado;

                    int.TryParse(unRow["IdEmpleado"].ToString(), out iIdEmpleado);

                    Boolean banIMMS = unRow["EstatusIMSS"].ToString() == "SOLICITUD RECHAZADA" ? true : false;
                    Boolean banJuridico = unRow["EstatusJuridico"].ToString() == "SOLICITUD RECHAZADA" ? true : false;
                    Boolean banTesoreriaSA = unRow["EstatusTesoreriaSA"].ToString() == "SOLICITUD RECHAZADA" ? true : false;
                    Boolean banTesoreriaSC = unRow["EstatusTesoreriaSC"].ToString() == "SOLICITUD RECHAZADA" ? true : false;

                    if (banIMMS || banJuridico || banTesoreriaSA || banTesoreriaSC)
                    {
                        Boolean teso = banTesoreriaSA == true || banTesoreriaSC == true ? true : false;
                        if (iIdEmpleado > 0)
                        {
                            if (miSolicitud.idTipoSolicitud == 1)
                            {
                                Catalogos.frmxModificacionEmpleados modulosEdicionEmpleados = new Catalogos.frmxModificacionEmpleados(iIdEmpleado, true, true, banIMMS, banJuridico, teso, miSolicitud.idSolicitud);
                                modulosEdicionEmpleados.ShowDialog();
                                //Validar Informacion de la solicitud
                                RevisarSolicitud();
                                pintarGridEmpleados(miSolicitud.idSolicitud);
                            }
                            else if (miSolicitud.idTipoSolicitud == 2)
                            {
                                DataTable dt = this.stpSelObtenerInfoEmpleadoModificacionCFDITableAdapter1.GetData(Convert.ToInt32(iIdEmpleado));
                                objEmp = EmpleadoBD.ObtenerInfoEmpleadoModificacionCFDI(dt);
                                XtraMotivoBajaEmpleado bajaEmpleado = new XtraMotivoBajaEmpleado(objEmp, 2, miSolicitud.FechaCreacion);
                                bajaEmpleado.ShowDialog();
                            }
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("No se puede Editar, se requiere Rechazo por alguna de las Areas.", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    XtraMessageBox.Show("El registro del Empleado en la solicitud no se encuentra Activa."
              , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnActualizarTenedoraCliente_Click(object sender, EventArgs e)
        {
            Boolean flagCambioDeSubRegion = true;

            DialogResult drResultado = XtraMessageBox.Show("¿Deseas Actualizar la Solicitud " + cboSolicitudAltaEmpleados.Text + " a la Tenedora " +
                ludAltasTenedora.Text + " y Cliente " +
                ludAltasCliente.Text + "?"
              , "SAIC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult.Yes == drResultado && flagCambioDeSubRegion)
            {
                int idTenedora;
                int idExcedente;
                int idCliente;

                int.TryParse(ludAltasTenedora.EditValue.ToString(), out idTenedora);
                int.TryParse(ludAltasExcedente.EditValue.ToString(), out idExcedente);
                int.TryParse(ludAltasCliente.EditValue.ToString(), out idCliente);

                if (idTenedora > 0 && idCliente > 0)
                {
                    queriesOperacionesAdapter1.stpUpdTenedoraClienteSolicitudesAlta(miSolicitud.idSolicitud,
                        idTenedora,
                        idExcedente,
                        idCliente,
                        OperadorBD.OperadorGlobal.NombreUsuario);

                    XtraMessageBox.Show("Tenedora y/o Cliente Actualizados.", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mostrarSolicitud();
                }
                else
                {
                    XtraMessageBox.Show("No se tiene valor para actualizar Tenedora y/o Cliente.", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void ItemButtonEditRegresarEstatus_Click(object sender, EventArgs e)
        {
            DataRow unRow = gridVEmpleados.GetDataRow(gridVEmpleados.FocusedRowHandle);

            if (unRow["idEstatus"].ToString() == "2")
            {
                //debe estar rechazado por el area de IMSS y Juridico
                IMSS.XtraEmpleadosXSolicitudIMSS oXtraEmpleadosXSolicitudIMSS = new IMSS.XtraEmpleadosXSolicitudIMSS(new Solicitud());
                oXtraEmpleadosXSolicitudIMSS.ObtenerFechaServidor();

                DateTime dtFechaLimite = oXtraEmpleadosXSolicitudIMSS.ObtenerFechaServidor();
                int iDiasAtras = 0;

                stpSelParametroTableAdapter1.Fill(dbSAICBPOValidacionDataSet1.stpSelParametro, "DiASPARA_REGRESARSOLICITUD");
                if (dbSAICBPOValidacionDataSet1.stpSelParametro.Rows.Count > 0)
                {
                    int.TryParse(dbSAICBPOValidacionDataSet1.stpSelParametro.Rows[0]["ValorParametro"].ToString(), out iDiasAtras);
                }

                dtFechaLimite = dtFechaLimite.AddDays(iDiasAtras);
                //miSolicitud.FechaCreacion;
                if (dtFechaLimite <= miSolicitud.FechaCreacion)
                {
                    if (unRow != null)
                    {

                        DialogResult oDialogResult = XtraMessageBox.Show("¿Esta seguro de actualizar el estatus del empleado en la solicitud a PROCESO?"
                            , "SAIC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (DialogResult.Yes == oDialogResult)
                        {
                            int idEmpleado = 0;
                            int.TryParse(unRow["IdEmpleado"].ToString(), out idEmpleado);
                            queriesOperacionesAdapter1.stpUpdActualizarSolicitudEmpleado(miSolicitud.idSolicitud, idEmpleado, OperadorBD.OperadorGlobal.NombreUsuario);

                            XtraMessageBox.Show("Estatus actualizado del empleado " +
                                unRow["APaternoEmpleado"].ToString() + " " +
                                unRow["AMaternoEmpleado"].ToString() + " " +
                                unRow["NombreEmpleado"].ToString() + "."
                            , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            mostrarSolicitud();
                        }
                    }
                }
                else
                {
                    XtraMessageBox.Show("No se puede Actualizar solicitudes menores a " + dtFechaLimite.ToString("dd/MM/yyyy")
                               , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                XtraMessageBox.Show("El registro del Empleado en la solicitud no se encuentra Activa."
                              , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ludAltasTenedora_EditValueChanged(object sender, EventArgs e)
        {
            int idTenedoraSA = 0;
            int.TryParse(ludAltasTenedora.EditValue.ToString(), out idTenedoraSA);
            stpSelAltasExcedentesTableAdapter.Fill(dsOperaciones.stpSelAltasExcedentes, idTenedoraSA, flagConFiltroTenedoraSC);
            ludAltasExcedente.EditValue = miSolicitud.idTenedoraSC;
        }
    }
}