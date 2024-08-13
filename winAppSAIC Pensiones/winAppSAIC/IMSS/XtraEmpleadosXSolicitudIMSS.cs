using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using System.Diagnostics;
using Excel = Microsoft.Office.Interop.Excel;
using DevExpress.XtraBars.Helpers;
using DevExpress.Skins;
using compCatalogosSAIC;
using DevExpress.XtraGrid.Views.Grid;
using winAppSAIC.OperadoresM;

namespace winAppSAIC.IMSS
{
    public partial class XtraEmpleadosXSolicitudIMSS : DevExpress.XtraEditors.XtraForm
    {


        tools.dsc dsc = new tools.dsc();
        String sRuta_Ope_Altas = String.Empty;
        String sRuta_Ope_Bajas = String.Empty;
        String sRuta_Ope_Salario = String.Empty;
        String sRuta_Ope_Cuentas = String.Empty;
        String sRutaCarpeta = String.Empty;

        int iTotalEmpleados = 0;
        OperadoresM.Solicitud miSolicitud;
        const int IMSS = 1;
        OperadoresM.ColorSolicitud miColorSolicitud;
        Empleado objEmp;

        DateTime dFechaHoy = new DateTime();
        Boolean flagMensajeDeFechasExtemporaneas = false;

        DateTime dFechaAltaLimite = new DateTime();
        DateTime dFechaBajaLimite = new DateTime();
        DateTime dFechaBajaFuturaLimite = new DateTime();

        public XtraEmpleadosXSolicitudIMSS(OperadoresM.Solicitud miSolicitud)
        {
            InitializeComponent();
            this.miSolicitud = miSolicitud;
            pintarRow();
            dFechaAltaLimite = obtenerFechaAltaLimite();
            dFechaBajaLimite = obtenerFechaBajaLImite();
            dFechaBajaFuturaLimite = obtenerFechaBajaFuturaLImite();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerarLayOut_Click(object sender, EventArgs e)
        {
            if (gridViewEmpleados.SelectedRowsCount > 0)
            {
                String stLayOut = String.Empty;
                Boolean flagTaMuyBien = true;
                DataTable dtEmpleadosSeleccionados = dsc.deGridViewSelectedToDataTable(gridViewEmpleados);

                var query = (from x in dtEmpleadosSeleccionados.AsEnumerable()
                             where x.Field<String>("Estatus").Equals("SOLICITUD RECHAZADA") ||
                             x.Field<String>("EstatusRegistro").Equals("SOLICITUD CANCELADA")
                             select x);

                if (query.Count() > 0)
                {
                    DialogResult oDialogResult = XtraMessageBox.Show("Hay empleados seleccionados en estatus Rechazado o Cancelado. ¿Desea continuar con el Layout?", "SAIC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    flagTaMuyBien = oDialogResult == DialogResult.Yes ? true : false;
                }

                if (flagTaMuyBien)
                {
                    //generar LayOut cuando es Alta
                    if (miSolicitud.idTipoSolicitud == 1)
                    {
                        stLayOut = generarLayOutIMSS(dtEmpleadosSeleccionados);

                        if (!String.IsNullOrEmpty(stLayOut))
                        {
                            String stRuta = miSolicitud.sRutaSolicitud + miSolicitud.idSolicitud + @"\";
                            dsc.CheckandCreateFolder(stRuta);

                            String stNombre = "IMSS_LayOut " + dsc.nombreAleatorio() + ".txt";
                            File.WriteAllText(stRuta + stNombre, stLayOut);
                            System.Threading.Thread.Sleep(2000);
                            XtraMessageBox.Show("LayOut Generado con Exito" + Environment.NewLine + Environment.NewLine +
                                "LayOut se guardo en la Ubicacion: " + stRuta
                                , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            XtraMessageBox.Show("No hay datos en la base de los empleados.", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (miSolicitud.idTipoSolicitud == 2) //generar layout cuando es baja
                    {
                        List<String> layOutbajas;
                        layOutbajas = generarLayOutIMSSBaja(dtEmpleadosSeleccionados);

                        if (layOutbajas.Count > 0)
                        {
                            String stRuta = miSolicitud.sRutaSolicitud + miSolicitud.idSolicitud + @"\"; ;
                            dsc.CheckandCreateFolder(stRuta);

                            String stNombre = "IMSS_LayOut_Baja " + dsc.nombreAleatorio() + ".txt";
                            File.WriteAllLines(stRuta + stNombre, layOutbajas);
                            System.Threading.Thread.Sleep(2000);
                            XtraMessageBox.Show("LayOut Generado con Exito" + Environment.NewLine + Environment.NewLine +
                                "LayOut se guardo en la Ubicacion: " + stRuta
                                , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            XtraMessageBox.Show("No hay datos en la base de los empleados.", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            else
            {
                XtraMessageBox.Show("Seleccione un Empleado.", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private String generarLayOutIMSS(DataTable dtEmpleadosSeleccionados)
        {
            String stLayOut = String.Empty;

            foreach (DataRow unRow in dtEmpleadosSeleccionados.Rows)
            {
                DataTable dtDatos = new DataTable();
                int iNumeroEmpleado = 0;
                int iTipoTrabajador = 0;
                int iTipoSalaraio = 0;
                int iSemanaJornada = 0;

                int.TryParse(unRow["IdEmpleado"].ToString(), out iNumeroEmpleado);
                int.TryParse(unRow["TipoTrab"].ToString(), out iTipoTrabajador);
                int.TryParse(unRow["TipoSalario"].ToString(), out iTipoSalaraio);
                int.TryParse(unRow["SemanaJornada"].ToString(), out iSemanaJornada);

                try
                {
                    stpSelAltaEmpleadoLayOutIMSSTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelAltaEmpleadoLayOutIMSS, iNumeroEmpleado, iTipoTrabajador, iTipoSalaraio, iSemanaJornada);
                }

                catch (Exception ex) { }
                dtDatos = dbSAICBPOCatalogosDataSet1.stpSelAltaEmpleadoLayOutIMSS;
                if (dtDatos.Rows.Count > 0)
                {
                    stLayOut += dbSAICBPOCatalogosDataSet1.stpSelAltaEmpleadoLayOutIMSS.Rows[0]["RegistroPatronalIMSS"].ToString() +
                        dbSAICBPOCatalogosDataSet1.stpSelAltaEmpleadoLayOutIMSS.Rows[0]["NSS"].ToString() +
                        dbSAICBPOCatalogosDataSet1.stpSelAltaEmpleadoLayOutIMSS.Rows[0]["APaternoEmpleado"].ToString() +
                        dbSAICBPOCatalogosDataSet1.stpSelAltaEmpleadoLayOutIMSS.Rows[0]["AMaternoEmpleado"].ToString() +
                        dbSAICBPOCatalogosDataSet1.stpSelAltaEmpleadoLayOutIMSS.Rows[0]["NombreEmpleado"].ToString() +
                        dbSAICBPOCatalogosDataSet1.stpSelAltaEmpleadoLayOutIMSS.Rows[0]["SDI"].ToString() +
                        dbSAICBPOCatalogosDataSet1.stpSelAltaEmpleadoLayOutIMSS.Rows[0]["TipoTrabajador"].ToString() +
                        dbSAICBPOCatalogosDataSet1.stpSelAltaEmpleadoLayOutIMSS.Rows[0]["TipoSalario"].ToString() +
                        dbSAICBPOCatalogosDataSet1.stpSelAltaEmpleadoLayOutIMSS.Rows[0]["SemanaJornada"].ToString() +
                        dbSAICBPOCatalogosDataSet1.stpSelAltaEmpleadoLayOutIMSS.Rows[0]["Fecha"].ToString() +
                        dbSAICBPOCatalogosDataSet1.stpSelAltaEmpleadoLayOutIMSS.Rows[0]["UMF"].ToString() +
                        dbSAICBPOCatalogosDataSet1.stpSelAltaEmpleadoLayOutIMSS.Rows[0]["TipoMovimiento"].ToString() +
                        dbSAICBPOCatalogosDataSet1.stpSelAltaEmpleadoLayOutIMSS.Rows[0]["Guia"].ToString() +
                        dbSAICBPOCatalogosDataSet1.stpSelAltaEmpleadoLayOutIMSS.Rows[0]["Clabe"].ToString() +
                        dbSAICBPOCatalogosDataSet1.stpSelAltaEmpleadoLayOutIMSS.Rows[0]["CURP"].ToString() +
                        dbSAICBPOCatalogosDataSet1.stpSelAltaEmpleadoLayOutIMSS.Rows[0]["Identificador"].ToString() + Environment.NewLine;
                }
            }

            return stLayOut;
        }

        private List<String> generarLayOutIMSSBaja(DataTable dtEmpleadosSeleccionados)
        {
            String stLayOut = String.Empty;
            List<String> listLayOut = new List<String>();
            foreach (DataRow unRow in dtEmpleadosSeleccionados.Rows)
            {
                int idEmpleado = 0;
                int.TryParse(unRow["idEmpleado"].ToString(), out idEmpleado);

                String stlayOut = String.Empty;
                stpSelAltaEmpleadoLayOutIMSSBajasTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelAltaEmpleadoLayOutIMSSBajas, idEmpleado, miSolicitud.idTenedoraSA);
                if (dbSAICBPOCatalogosDataSet1.stpSelAltaEmpleadoLayOutIMSSBajas.Rows.Count > 0)
                {
                    listLayOut.Add(dbSAICBPOCatalogosDataSet1.stpSelAltaEmpleadoLayOutIMSSBajas[0]["LayOutBajas"].ToString());
                }
            }

            return listLayOut;
        }

        private void XtraEmpleadosXSolicitudIMSS_Load(object sender, EventArgs e)
        {
            miColorSolicitud = new ColorSolicitud();
            miColorSolicitud = miColorSolicitud.obtenerColor();
            MostrarDetalleSolicitud(miSolicitud);
            CargarInformacion();
            dFechaHoy = ObtenerFechaServidor();




        }

        private void MostrarDetalleSolicitud(Solicitud miSolicitud)
        {
            btnExportar.Enabled = false;
            documentosToolStripMenuItem.Enabled = false;
            btnAbrirCarpeta.Enabled = false;
            btnEstatusSolicitud.Enabled = false;
            txtbxSolicitud.Text = miSolicitud.idSolicitud.ToString();
            txtbxfechaAlta.Text = miSolicitud.FechaCreacion.ToShortDateString();
            txtbxOperador.Text = miSolicitud.NombreOperador;
            txtbxTenedoraSA.Text = miSolicitud.TenedoraSA;
            txtbxRPatronal.Text = miSolicitud.RegistroPatronal;
            txtEstatus.Text = miSolicitud.EstatusIMSS;
            txtCliente.Text = miSolicitud.Cliente;
            txtTipoSolicitud.Text = miSolicitud.DescTipoSolicitud;
        }

        private void CargarInformacion()
        {
            try
            {
                splashScreenManager1.ShowWaitForm();
                stpSelSolicitudAltaEmpleadosIMSSTableAdapter2.Fill(dbSAICBPOCatalogosDataSet1.stpSelSolicitudAltaEmpleadosIMSS, miSolicitud.idSolicitud);
                if (dbSAICBPOCatalogosDataSet1.stpSelSolicitudAltaEmpleadosIMSS.Rows.Count > 0)
                {
                    btnExportar.Enabled = true;
                    documentosToolStripMenuItem.Enabled = true;
                    btnAbrirCarpeta.Enabled = true;
                    int iEmpleadosSolicitados = dbSAICBPOCatalogosDataSet1.stpSelSolicitudAltaEmpleadosIMSS.AsEnumerable().Where(x => x["Estatus"].ToString() == "SOLICITUD EMITIDA" || x["Estatus"].ToString() == "SOLICITUD EN PROCESO" || x["Estatus"].ToString() == "SOLICITUD RESPONDIDA" || x["Estatus"].ToString() == "SOLICITUD RECHAZADA").ToList().Count;
                    iTotalEmpleados = dbSAICBPOCatalogosDataSet1.stpSelSolicitudAltaEmpleadosIMSS.Rows.Count;
                    lblTotalEmpleadosSolicitud.Text = "Total Empleados: " + dbSAICBPOCatalogosDataSet1.stpSelSolicitudAltaEmpleadosIMSS.Rows.Count;
                    lblEmpleadosSolicitados.Text = "Empleados Solicitados: " + iEmpleadosSolicitados;
                    lblEmpleadosAtendidos.Text = "Empleados Atendidos: " + dbSAICBPOCatalogosDataSet1.stpSelSolicitudAltaEmpleadosIMSS.AsEnumerable().Where(x => x["Estatus"].ToString() == "SOLICITUD ATENDIDA AL 100%").ToList().Count;

                    if (iEmpleadosSolicitados > 0)
                    {
                        btnEstatusSolicitud.Enabled = true;
                    }
                    else
                    {
                        btnEstatusSolicitud.Enabled = false;
                    }

                    dFechaHoy = ObtenerFechaServidor();
                    //Validar si hay fechas extemporaneas
                    if (miSolicitud.idTipoSolicitud == 1)//Alta
                    {
                        foreach (DataRow item in dbSAICBPOCatalogosDataSet1.stpSelSolicitudAltaEmpleadosIMSS.Rows)
                        {
                            DateTime dFechaIngresoContrato;
                            DateTime.TryParse(item["Fecha Alta Contrato"].ToString(), out dFechaIngresoContrato);

                            if (dFechaIngresoContrato < dFechaAltaLimite.AddDays(-1))
                            {
                                flagMensajeDeFechasExtemporaneas = true;
                                break;
                            }
                        }
                    }
                    else if (miSolicitud.idTipoSolicitud == 2)
                    {
                        foreach (DataRow item in dbSAICBPOCatalogosDataSet1.stpSelSolicitudAltaEmpleadosIMSS.Rows)
                        {
                            DateTime dFechaBajaContrato;
                            DateTime.TryParse(item["Fecha Baja Contrato"].ToString(), out dFechaBajaContrato);

                            if (dFechaBajaContrato < dFechaBajaLimite.AddDays(-1))
                            {
                                flagMensajeDeFechasExtemporaneas = true;
                                break;
                            }
                        }
                    }
                }

                if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }
                if (flagMensajeDeFechasExtemporaneas)
                {
                    if (miSolicitud.EstatusIMSS != "SOLICITUD ATENDIDA AL 100%")
                    {
                        XtraMessageBox.Show("Se identificaron empleados con fechas extemporáneas en la Solicitud, favor de revisar."
                                 , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                sRuta_Ope_Altas = dsc.ObtenerRutaSolicitud(1, 2);
                sRuta_Ope_Bajas = dsc.ObtenerRutaSolicitud(2, 2);
                sRuta_Ope_Cuentas = dsc.ObtenerRutaSolicitud(3, 2);
                sRuta_Ope_Salario = dsc.ObtenerRutaSolicitud(4, 2);

            }
            catch (Exception ex)
            {
                if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }
                XtraMessageBox.Show("No se puede cargar la información de la Solicitud." + Environment.NewLine + ex.Message
                   , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pintarRow()
        {
            for (int i = 0; i < gridViewEmpleados.RowCount; i++)
            {
                //if (gridViewEmpleados.GetDataRow(i)["CLABE"].ToString() == "Clabe Invalida") // CLABEIncorrecta
                //    gridViewEmpleados.UnselectRow(i);
            }
        }

        private void gridViewEmpleados_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            String stColumna = e.Column.ToString();
            String stValue = e.Value.ToString().ToUpper();
        }

        /// <summary>
        /// Actualizar informacion en la base de datos del empleados.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridViewEmpleados_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //Boolean hayRechazoEmpleados = false;

            //try
            //{
            //    DataRow unRow = gridViewEmpleados.GetDataRow(e.RowHandle);

            //    if (!String.IsNullOrEmpty(unRow["Rechazo"].ToString()))
            //    {
            //        hayRechazoEmpleados = hayEmpleadoRechazo();

            //        if (!hayRechazoEmpleados)
            //        {
            //            DialogResult Resultado = XtraMessageBox.Show("Se esta haciendo un comentario de Rechazo. ¿Esta Seguro que quiere Rechazar la Solicitd " + miSolicitud.idSolicitud + "?"
            //       , "SAIC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //            if (Resultado == DialogResult.No)
            //            {
            //                unRow["Rechazo"] = String.Empty;
            //            }
            //            else
            //            {
            //                hayRechazoEmpleados = true;
            //            }
            //        }
            //    }

            //    int idEmpleado = 0;
            //    int.TryParse(unRow["IdEmpleado"].ToString(), out idEmpleado);

            //    queriesTableAdapter1.stpUpEmpleadoInformacionIMSS(
            //        miSolicitud.idSolicitud,
            //        idEmpleado,
            //        unRow["Apellido Paterno"].ToString().ToUpper(),
            //        unRow["Apellido Materno"].ToString().ToUpper(),
            //        unRow["Nombre"].ToString().ToUpper(),
            //        unRow["NSS"].ToString(),
            //        unRow["RFC"].ToString().ToUpper(),
            //        unRow["CURP"].ToString().ToUpper(),
            //        hayRechazoEmpleados,
            //        unRow["Rechazo"].ToString().ToUpper(),
            //        OperadorBD.OperadorGlobal.NombreUsuario,
            //        OperadorBD.OperadorGlobal.NombreOperador
            //        );

            //    CargarInformacion();
            //}
            //catch (Exception exp)
            //{
            //    XtraMessageBox.Show("No se pudo actualizar la información en la Base: " + Environment.NewLine + exp.Message
            //   , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    throw;
            //}
        }

        /// <summary>
        /// Funcion para saber si algun otro empleado ya contiene rechazo.
        /// </summary>
        /// <returns></returns>
        private Boolean hayEmpleadoRechazo()
        {
            Boolean hayempleadosRechazo = false;
            DataTable dtEmpleados = dsc.deGridViewaDataTable(gridViewEmpleados);

            int query = (from x in dtEmpleados.AsEnumerable()
                         where !x.Field<String>("Rechazo").Equals("")
                         select x).ToList().Count;

            if (query > 1)
            {
                hayempleadosRechazo = true;
            }

            return hayempleadosRechazo;
        }

        /// <summary>
        /// Boton para exportar la informacion del gridview a Excel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (gridViewEmpleados.SelectedRowsCount > 0)
            {
                DataTable dtEmpleadosSeleccionados = dsc.deGridViewSelectedToDataTable(gridViewEmpleados);
                OperadoresM.XtraMonitoreoSolicitudesOperaciones Operaciones = new OperadoresM.XtraMonitoreoSolicitudesOperaciones(0);
                Operaciones.descargarArchivoEmpleados(dtEmpleadosSeleccionados, miSolicitud, 2);
            }
            else
            {
                XtraMessageBox.Show("Seleccione a un Empleado."
                  , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gridViewEmpleados.Focus();
            }

            //DataTable dtEmpleados = dsc.deGridViewaDataTable(gridViewEmpleados, 0, 16);

            //dtEmpleados.Columns.Add("Registro Patronal", typeof(System.String));

            //foreach (DataRow item in dtEmpleados.Rows) { item["Registro Patronal"] = miSolicitud.RegistroPatronal; }

            //dtEmpleados.Columns["Registro Patronal"].SetOrdinal(0);

            //String stDatos = dsc.ConvertDataTableToString(dtEmpleados, true);
            //try
            //{
            //    if (!String.IsNullOrEmpty(stDatos))
            //    {
            //        Excel.Application appExcel;
            //        Excel.Workbooks booksExcel;
            //        Excel.Workbook bookExcel;
            //        Excel.Worksheet SheetExcel;
            //        Excel.Range Rango;

            //        appExcel = new Excel.Application();
            //        booksExcel = appExcel.Workbooks;
            //        bookExcel = booksExcel.Add();
            //        appExcel.Visible = true;
            //        appExcel.DisplayAlerts = false;

            //        System.Threading.Thread.Sleep(1000);
            //        Clipboard.Clear();
            //        System.Threading.Thread.Sleep(1000);
            //        Clipboard.SetText(stDatos);

            //        SheetExcel = (Excel.Worksheet)bookExcel.ActiveSheet;
            //        SheetExcel.Name = miSolicitud.idSolicitud.ToString();
            //        Rango = SheetExcel.get_Range("C:O");
            //        Rango.NumberFormat = "@";

            //        Rango = SheetExcel.get_Range("A1");
            //        Rango.Select();

            //        Rango.PasteSpecial();
            //        Rango = SheetExcel.get_Range("A1:O1");
            //        Rango.Select();
            //        Rango.Interior.Pattern = Excel.XlPattern.xlPatternSolid;
            //        Rango.Interior.PatternColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic;
            //        Rango.Interior.ThemeColor = Excel.XlThemeColor.xlThemeColorAccent1;
            //        Rango.Interior.TintAndShade = -0.499984740745262;
            //        Rango.Interior.PatternTintAndShade = 0;

            //        Rango.Font.ThemeColor = Excel.XlThemeColor.xlThemeColorDark1;
            //        Rango.Font.TintAndShade = 0;
            //        Rango.Font.Bold = true;
            //        Rango.Font.Size = 14;

            //        SheetExcel.Cells.Select();
            //        SheetExcel.Cells.EntireColumn.AutoFit();

            //        appExcel.DisplayAlerts = true;

            //        XtraMessageBox.Show("Archivo Generado con Exito."
            //       , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //    }
            //}
            //catch (Exception ex)
            //{
            //    XtraMessageBox.Show("No se puede generar el archivo de Excel."
            //      , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //    if (!String.IsNullOrEmpty(stDatos))
            //    {
            //        File.WriteAllText(stRutaArchivo, stDatos);
            //        Process.Start(stRutaArchivo);
            //    }
            //}

            //splashScreenManager1.CloseWaitForm();
        }

        private void btnEstatusSolicitud_Click(object sender, EventArgs e)
        {
            if (gridViewEmpleados.SelectedRowsCount > 0)
            {
                DialogResult resultado = XtraMessageBox.Show("¿Desea Atender a los empleados Seleccionados?"
                        , "SAIC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == resultado)
                {
                    uncheckedGridEmpleado();

                    String stEmpleadosNoIngresados = String.Empty;
                    int iAtendidos = 0;
                    int iConError = 0;
                    int ipendientes = iTotalEmpleados;
                    DataTable dtEmpleadosSeleccionados = dsc.deGridViewSelectedToDataTable(gridViewEmpleados);

                    splashScreenManager1.ShowWaitForm();

                    foreach (DataRow unRow in dtEmpleadosSeleccionados.Rows)
                    {
                        int iIDempleado;
                        int.TryParse(unRow["IdEmpleado"].ToString(), out iIDempleado);

                        if (iIDempleado != 0 && unRow["EstatusRegistro"].ToString() == "ACTIVO")
                        {
                            try
                            {
                                queriesTableAdapter1.stpUpdEstatusSolicitudAlta(IMSS,
                                                  miSolicitud.idSolicitud,
                                                  iIDempleado,
                                                   OperadorBD.OperadorGlobal.NombreOperador,
                                                   OperadorBD.OperadorGlobal.NombreUsuario,
                                                    DateTime.Now
                                                  );
                                iAtendidos++;
                                ipendientes--;
                            }
                            catch (Exception exp)
                            {
                                stEmpleadosNoIngresados += unRow["idEmpleado"].ToString() + " " + exp.Message + Environment.NewLine;
                                iConError++;
                            }
                        }
                    }

                    splashScreenManager1.CloseWaitForm();
                    miSolicitud = miSolicitud.ObtenerSolcitud(miSolicitud.idSolicitud, 2);
                    MostrarDetalleSolicitud(miSolicitud);
                    CargarInformacion();

                    dtEmpleadosSeleccionados = dsc.deGridViewSelectedToDataTable(gridViewEmpleados);

                    XtraMessageBox.Show("Empleados Atendidos: " + iAtendidos + Environment.NewLine +
                        "Empleados no Actualizados: " + iConError + Environment.NewLine +
                        "Empleados por Atender: " + dtEmpleadosSeleccionados.Select("Estatus <> 'SOLICITUD ATENDIDA AL 100%'").Count()
                        , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                XtraMessageBox.Show("Seleccione un Empleado"
                    , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gridViewEmpleados_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            //for (int i = 0; i < gridViewEmpleados.RowCount; i++)
            //{
            //    if (gridViewEmpleados.GetDataRow(i)["Estatus"].ToString() == "SOLICITUD ATENDIDA AL 100%" || gridViewEmpleados.GetDataRow(i)["Estatus"].ToString() == "SOLICITUD RECHAZADA")
            //        gridViewEmpleados.UnselectRow(i);
            //}
        }

        private void uncheckedGridEmpleado()
        {
            for (int i = 0; i < gridViewEmpleados.RowCount; i++)
            {
                if (gridViewEmpleados.GetDataRow(i)["Estatus"].ToString() == "SOLICITUD ATENDIDA AL 100%" || gridViewEmpleados.GetDataRow(i)["Estatus"].ToString() == "SOLICITUD RECHAZADA")
                    gridViewEmpleados.UnselectRow(i);
            }
        }

        private void gridViewEmpleados_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                if (e.RowHandle >= 0)
                {
                    gridViewEmpleados.OptionsSelection.EnableAppearanceFocusedRow = false;
                    //string category = View.GetRowCellDisplayText(e.RowHandle, View.Columns["Category"]);

                    if (gridViewEmpleados.GetDataRow(e.RowHandle)["idEstatus"].ToString() == "23")
                    {
                        e.Appearance.BackColor = Color.FromArgb(miColorSolicitud.idColorInactivo[0], miColorSolicitud.idColorInactivo[1], miColorSolicitud.idColorInactivo[2]);
                        e.HighPriority = true;
                    }
                    else
                    {
                        if (gridViewEmpleados.GetDataRow(e.RowHandle)["Tipo de Alta"].ToString() == "REINGRESO")
                        {
                            e.Appearance.BackColor = Color.FromArgb(miColorSolicitud.idColorReingreso[0], miColorSolicitud.idColorReingreso[1], miColorSolicitud.idColorReingreso[2]);
                            e.HighPriority = true;
                        }

                        if (gridViewEmpleados.GetDataRow(e.RowHandle)["DescEstatus"].ToString() == "BAJA")
                        {
                            e.Appearance.BackColor = Color.FromArgb(miColorSolicitud.idColorBaja[0], miColorSolicitud.idColorBaja[1], miColorSolicitud.idColorBaja[2]);
                            e.HighPriority = true;
                        }

                        if (gridViewEmpleados.GetDataRow(e.RowHandle)["Estatus"].ToString() == "SOLICITUD ATENDIDA AL 100%")
                        {
                            e.Appearance.BackColor = Color.FromArgb(miColorSolicitud.idColorAtendida[0], miColorSolicitud.idColorAtendida[1], miColorSolicitud.idColorAtendida[2]);
                            e.HighPriority = true;
                        }
                        else if (gridViewEmpleados.GetDataRow(e.RowHandle)["Estatus"].ToString() == "SOLICITUD RECHAZADA")
                        {
                            //e.Appearance.BackColor = Color.LightCoral;
                            e.Appearance.BackColor = Color.FromArgb(miColorSolicitud.idColorRechazada[0], miColorSolicitud.idColorRechazada[1], miColorSolicitud.idColorRechazada[2]);
                            e.HighPriority = true;
                        }
                    }
                }
            }
            catch (Exception) { }
        }

        private void btnSolicitudRechazada_Click(object sender, EventArgs e)
        {
            //DialogResult Resultado = XtraMessageBox.Show("¿Esta Seguro que quiere Rechazar la Solicitd " + miSolicitud.idSolicitud + "?"
            //     , "SAIC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //if (Resultado == DialogResult.Yes)
            //{
            //    DataTable dtEmpleados = dsc.deGridViewaDataTable(gridViewEmpleados);

            //    OperadoresM.frmxRechazarSolicitud rechazarSol = new OperadoresM.frmxRechazarSolicitud(miSolicitud, dtEmpleados);
            //    rechazarSol.ShowDialog();
            //    CargarInformacion();
            //}
        }

        private void btnDescargarDocumentacion_Click(object sender, EventArgs e)
        {

        }

        private void gridViewEmpleados_DoubleClick(object sender, EventArgs e)
        {

            //gridViewEmpleados.Focus();
            //DataRow unRow = gridViewEmpleados.GetDataRow(gridViewEmpleados.FocusedRowHandle);

            //if (unRow != null)
            //{
            //    int idEmpleado = Convert.ToInt32(unRow["idEmpleado"].ToString());

            //    XtraModuloModificacionEmpleados moduloActualizarImss = new XtraModuloModificacionEmpleados(
            //        miSolicitud.idSolicitud,
            //        idEmpleado,
            //        unRow["Nombre"].ToString(),
            //        unRow["Apellido Paterno"].ToString(),
            //        unRow["Apellido Materno"].ToString(),
            //        unRow["CURP"].ToString(),
            //        unRow["RFC"].ToString(),
            //        unRow["NSS"].ToString(),
            //        unRow["SD"].ToString(),
            //        unRow["SDI"].ToString(),
            //        unRow["Funciones"].ToString());
            //    moduloActualizarImss.ShowDialog();
            //}
        }

        private void gridViewEmpleados_Click(object sender, EventArgs e)
        {

        }

        private void repositoryItemButtonEdit1_ButtonClick_2(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        //Boton para rechazar empleado
        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            gridViewEmpleados.Focus();
            DataRow unRow = gridViewEmpleados.GetDataRow(gridViewEmpleados.FocusedRowHandle);

            if (unRow != null)
            {
                if (unRow["EstatusRegistro"].ToString() == "ACTIVO")
                {
                    if (unRow["Estatus"].ToString() == "SOLICITUD ATENDIDA AL 100%")
                    {
                        XtraMessageBox.Show("El Empleado: " +
                            unRow["Nombre"].ToString() + " " +
                            unRow["Apellido Paterno"].ToString() + " " +
                            unRow["Apellido Materno"].ToString() + ", ya se encuentra Atendido al 100%."

                   , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (unRow["Estatus"].ToString() == "SOLICITUD RECHAZADA")
                    {
                        XtraMessageBox.Show("El Empleado: " +
                         unRow["Nombre"].ToString() + " " +
                         unRow["Apellido Paterno"].ToString() + " " +
                         unRow["Apellido Materno"].ToString() + ", NO se puede rechazar dos veces al empleado."

                    , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        int idEmpleado;
                        int.TryParse(unRow["IdEmpleado"].ToString(), out idEmpleado);
                        DataTable dtEmpleadosporAtender = miSolicitud.obtenerRegistros_Emitidos_Proceso_Respondidos(gridViewEmpleados, "Estatus");
                        OperadoresM.XtraRechazoSolicitud rechazarSolicitud = new OperadoresM.XtraRechazoSolicitud(
                            dtEmpleadosporAtender,
                            miSolicitud.idSolicitud,
                            idEmpleado,
                            "IMSS",
                            unRow["Nombre"].ToString() + " " +
                            unRow["Apellido Paterno"].ToString() + " " +
                            unRow["Apellido Materno"].ToString(),
                             unRow["Rechazo"].ToString()
                            );
                        rechazarSolicitud.ShowDialog();

                        miSolicitud = miSolicitud.ObtenerSolcitud(miSolicitud.idSolicitud, 2);
                        MostrarDetalleSolicitud(miSolicitud);
                        CargarInformacion();
                    }
                }
                else
                {
                    XtraMessageBox.Show("No se puede Rechazar, la Solicitud no esta Activada", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                XtraMessageBox.Show("No se puede abrir el modulo de Rechazo.", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //Editar
        private void repositoryItemButtonEdit2_Click(object sender, EventArgs e)
        {
            gridViewEmpleados.Focus();
            DataRow unRow = gridViewEmpleados.GetDataRow(gridViewEmpleados.FocusedRowHandle);

            if (unRow != null)
            {
                if (unRow["EstatusRegistro"].ToString() == "ACTIVO")
                {
                    if (unRow["Estatus"].ToString() == "SOLICITUD ATENDIDA AL 100%")
                    {
                        XtraMessageBox.Show("El Empleado: " +
                            unRow["Nombre"].ToString() + " " +
                            unRow["Apellido Paterno"].ToString() + " " +
                            unRow["Apellido Materno"].ToString() + ", ya se encuentra Atendido al 100%."
                       , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (unRow["Estatus"].ToString() == "SOLICITUD RECHAZADA")
                    {
                        XtraMessageBox.Show("El Empleado: " +
                         unRow["Nombre"].ToString() + " " +
                         unRow["Apellido Paterno"].ToString() + " " +
                         unRow["Apellido Materno"].ToString() + ", NO se puede editar al Empleado, se requiere Respuesta por parte de Operaciones."
                    , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        int idEmpleado = Convert.ToInt32(unRow["idEmpleado"].ToString());
                        if (miSolicitud.idTipoSolicitud == 1)//Solicitud tipo Alta/Reingreso
                        {
                            XtraModuloModificacionEmpleados moduloActualizarImss = new XtraModuloModificacionEmpleados(
                                miSolicitud.idSolicitud,
                                idEmpleado,
                                unRow["Nombre"].ToString(),
                                unRow["Apellido Paterno"].ToString(),
                                unRow["Apellido Materno"].ToString(),
                                unRow["CURP"].ToString(),
                                unRow["RFC"].ToString(),
                                unRow["NSS"].ToString(),
                                unRow["SD"].ToString(),
                                unRow["SDI"].ToString(),
                                unRow["Funciones"].ToString(),
                            unRow["Tipo Contrato"].ToString());
                            moduloActualizarImss.ShowDialog();
                        }
                        else if (miSolicitud.idTipoSolicitud == 2)
                        {
                            DataTable dt = this.stpSelObtenerInfoEmpleadoModificacionCFDITableAdapter1.GetData(Convert.ToInt32(idEmpleado));
                            objEmp = EmpleadoBD.ObtenerInfoEmpleadoModificacionCFDI(dt);
                            XtraMotivoBajaEmpleado bajaEmpleado = new XtraMotivoBajaEmpleado(objEmp, 2, miSolicitud.FechaCreacion);
                            bajaEmpleado.ShowDialog();
                        }
                        miSolicitud = miSolicitud.ObtenerSolcitud(miSolicitud.idSolicitud, 2);
                        MostrarDetalleSolicitud(miSolicitud);
                        CargarInformacion();
                    }
                }
                else
                {
                    XtraMessageBox.Show("No se puede Editar, la Solicitud no esta Activada", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                XtraMessageBox.Show("No se puede abrir el modulo de Edicion.", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //Atender
        private void repositoryItemButtonEdit3_Click(object sender, EventArgs e)
        {
            gridViewEmpleados.Focus();
            DataRow unRow = gridViewEmpleados.GetDataRow(gridViewEmpleados.FocusedRowHandle);

            if (unRow != null)
            {
                if (unRow["EstatusRegistro"].ToString() == "ACTIVO")
                {
                    if (unRow["Estatus"].ToString() == "SOLICITUD ATENDIDA AL 100%")
                    {
                        XtraMessageBox.Show("El Empleado: " +
                              unRow["Nombre"].ToString() + " " +
                              unRow["Apellido Paterno"].ToString() + " " +
                              unRow["Apellido Materno"].ToString() + ", ya se encuentra Atendido al 100%."
                         , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (unRow["Estatus"].ToString() == "SOLICITUD RECHAZADA")
                    {
                        XtraMessageBox.Show("El Empleado: " +
                            unRow["Nombre"].ToString() + " " +
                            unRow["Apellido Paterno"].ToString() + " " +
                            unRow["Apellido Materno"].ToString() + ", NO se puede Atender al Empleado. Se requiere Respuesta por parte de Operaciones."
                       , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        DialogResult resultado = XtraMessageBox.Show("¿Desea Atender al Empleado: " +
                                unRow["Nombre"].ToString() + " " +
                                unRow["Apellido Paterno"].ToString() + " " +
                                unRow["Apellido Materno"].ToString() + "?", "SAIC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (DialogResult.Yes == resultado)
                        {
                            int iIDempleado;
                            int.TryParse(unRow["IdEmpleado"].ToString(), out iIDempleado);

                            if (iIDempleado != 0)
                            {
                                try
                                {
                                    queriesTableAdapter1.stpUpdEstatusSolicitudAlta(IMSS,
                                                      miSolicitud.idSolicitud,
                                                      iIDempleado,
                                                       OperadorBD.OperadorGlobal.NombreOperador,
                                                       OperadorBD.OperadorGlobal.NombreUsuario,
                                                        DateTime.Now
                                                      );
                                }
                                catch (Exception exp)
                                {
                                    XtraMessageBox.Show("No se pudo actualizar al Empleado", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }

                                miSolicitud = miSolicitud.ObtenerSolcitud(miSolicitud.idSolicitud, 2);
                                MostrarDetalleSolicitud(miSolicitud);
                                CargarInformacion();
                            }
                        }
                    }
                }
                else
                {
                    XtraMessageBox.Show("No se puede Atender, la Solicitud no esta Activada", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                XtraMessageBox.Show("No se puede Atender el empleado.", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAbrirCarpeta_Click(object sender, EventArgs e)
        {
            String stRutaSolicitud = miSolicitud.sRutaSolicitud + miSolicitud.idSolicitud + @"\";
            dsc.CheckandCreateFolder(stRutaSolicitud);
            Process.Start(stRutaSolicitud);
        }

        private void toolSubirAfil_Click(object sender, EventArgs e)
        {
            try
            {
                String stRutaContrato = String.Empty;
                String stValorDocumento = String.Empty;

                XtraMessageBox.Show("Por favor seleccione el Archivo Afil de la Solicitud"
               , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);

                OpenFileDialog ofdSelecFile = new OpenFileDialog();
                ofdSelecFile.Filter = "Pdf Files| *.pdf";
                ofdSelecFile.Title = "SAIC | Seleccione Afil";
                ofdSelecFile.Multiselect = false;
                ofdSelecFile.ShowDialog();

                stRutaContrato = ofdSelecFile.FileName;

                if (!String.IsNullOrEmpty(stRutaContrato))
                {
                    splashScreenManager1.ShowWaitForm();
                    splashScreenManager1.SetWaitFormCaption("Cargando AFIL");

                    stValorDocumento = dsc.ConvertToBytes(stRutaContrato);
                    if (!String.IsNullOrEmpty(stValorDocumento))
                    {
                        FileInfo miArchivo = new FileInfo(stRutaContrato);

                        stpSelParametroTableAdapter1.Fill(dbSAICBPOValidacionDataSet1.stpSelParametro, "LIMITEARCHIVO");
                        if (dbSAICBPOValidacionDataSet1.stpSelParametro.Rows.Count > 0)
                        {
                            int iValorLimiteArchivos;
                            int.TryParse(dbSAICBPOValidacionDataSet1.stpSelParametro.Rows[0]["ValorParametro"].ToString(), out iValorLimiteArchivos);

                            if (miArchivo.Length <= iValorLimiteArchivos)
                            {
                                try
                                {
                                    queriesTableAdapter1.stpInsDocumentoIMSS_1(miSolicitud.idSolicitud,
                                                            miArchivo.Name,
                                                            miArchivo.Extension,
                                                            stValorDocumento,
                                                           OperadorBD.OperadorGlobal.NombreUsuario
                                                           , miSolicitud.idTipoSolicitud);

                                    if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }

                                    XtraMessageBox.Show("Archivo " + miArchivo.Name + ", guardado con Exito"
                                       , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                catch (Exception ex)
                                {
                                    if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }
                                    XtraMessageBox.Show("No se puede guardar en el archivo en el servidor." + Environment.NewLine + ex.Message
                                    , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }
                                XtraMessageBox.Show("El Archivo no debe exceder de " + dbSAICBPOValidacionDataSet1.stpSelParametro.Rows[0]["ValorParametro"].ToString() + " KB"
                                 , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }
                            DialogResult resultado = XtraMessageBox.Show("No se tiene valor de limite para archivos."
                             , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }
                        XtraMessageBox.Show("No se puede convertir el Archivo para Subir."
                        , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }
                XtraMessageBox.Show("No se puede guardar en el archivo." + Environment.NewLine + ex.Message
                                , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void documentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridViewEmpleados.SelectedRowsCount > 0)
            {
                OperadoresM.XtraMonitoreoSolicitudesOperaciones Operaciones = new OperadoresM.XtraMonitoreoSolicitudesOperaciones(0);
                DataTable dtEmpleados = dsc.deGridViewSelectedToDataTable(gridViewEmpleados);
                Operaciones.descargarDocumentacionEmpleado(dtEmpleados, miSolicitud);
            }
            else
            {
                XtraMessageBox.Show("Seleccione un Empleado."
             , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //splashScreenManager1.ShowWaitForm();
            //int iArchivosEstan = 0;
            //int iArchivosNOEstan = 0;
            //int iArchivosNoDescargados = 0;
            //String stRutaSolicitud = OperadoresM.Solicitud.stRutaSolicitudes + miSolicitud.idSolicitud + @"\IMSS\";
            //dsc.CheckandCreateFolder(stRutaSolicitud);
            //DataTable dtEmpleados = dsc.deGridViewaDataTable(gridViewEmpleados);
            //foreach (DataRow unRow in dtEmpleados.Rows)
            //{
            //    int idEmpleado = Convert.ToInt32(unRow["IdEmpleado"].ToString());
            //    try
            //    {
            //        stpSelDocumentoEmpleadoTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelDocumentoEmpleado, idEmpleado);
            //        if (dbSAICBPOCatalogosDataSet1.stpSelDocumentoEmpleado.Rows.Count > 0)
            //        {
            //            //Creando Carpeta por Empleado
            //            String stRutaEmpleado = stRutaSolicitud + idEmpleado + @"\";
            //            dsc.CheckandCreateFolder(stRutaEmpleado);

            //            String stNombreEmpleado = dbSAICBPOCatalogosDataSet1.stpSelDocumentoEmpleado[0]["NombreEmpleadoCompleto"].ToString();
            //            stNombreEmpleado = stNombreEmpleado.Replace("\\", "").Replace("/", "").Replace(":", "").Replace("+", "").Replace("?", "").Replace("\"", "").Replace("<", "").Replace(">", "").Replace("|", "");
            //            dsc.ConvertToFile(dbSAICBPOCatalogosDataSet1.stpSelDocumentoEmpleado[0]["DesDocumento"].ToString(), stRutaEmpleado + stNombreEmpleado + ".pdf");
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
            //splashScreenManager1.CloseWaitForm();
            //XtraMessageBox.Show("Documentos Empleados." + Environment.NewLine +
            //      "Documentos Generados: " + iArchivosEstan + Environment.NewLine +
            //      "Documentos no Encontrados: " + iArchivosEstan + Environment.NewLine +
            //      "Documentos no Descargados: " + iArchivosNoDescargados + Environment.NewLine +
            //      "Los Documentos los podra revisar en la Ruta: " + stRutaSolicitud + Environment.NewLine + " De su computadora."
            //      , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void fielToolStripMenuItem_Click(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            splashScreenManager1.SetWaitFormCaption("Descargando Afil");
            splashScreenManager1.SetWaitFormDescription("Espere Por favor...");

            try
            {
                OperadoresM.XtraMonitoreoSolicitudesOperaciones objMonitoreo = new OperadoresM.XtraMonitoreoSolicitudesOperaciones(0);
                String stRuta = miSolicitud.sRutaSolicitud + miSolicitud.idSolicitud + @"\";
                int iConta = objMonitoreo.DescargsarFiel(miSolicitud.idSolicitud, stRuta, miSolicitud.idTipoSolicitud);
                splashScreenManager1.CloseWaitForm();
                XtraMessageBox.Show("Documentos Afil Descargados: " + iConta
                   , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                splashScreenManager1.CloseWaitForm();
                XtraMessageBox.Show("Error al descargar Documentos." + Environment.NewLine + ex.Message
                   , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cargarAfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                String stRutaContrato = String.Empty;
                String stValorDocumento = String.Empty;

                XtraMessageBox.Show("Por favor seleccione el Archivo Afil de la Solicitud"
               , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);

                OpenFileDialog ofdSelecFile = new OpenFileDialog();
                ofdSelecFile.Filter = "Pdf Files| *.pdf";
                ofdSelecFile.Title = "SAIC | Seleccione Afil";
                ofdSelecFile.Multiselect = false;
                ofdSelecFile.ShowDialog();

                stRutaContrato = ofdSelecFile.FileName;

                if (!String.IsNullOrEmpty(stRutaContrato))
                {
                    splashScreenManager1.ShowWaitForm();
                    splashScreenManager1.SetWaitFormCaption("Cargando AFIL");

                    stValorDocumento = dsc.ConvertToBytes(stRutaContrato);
                    if (!String.IsNullOrEmpty(stValorDocumento))
                    {
                        FileInfo miArchivo = new FileInfo(stRutaContrato);

                        stpSelParametroTableAdapter1.Fill(dbSAICBPOValidacionDataSet1.stpSelParametro, "LIMITEARCHIVO");
                        if (dbSAICBPOValidacionDataSet1.stpSelParametro.Rows.Count > 0)
                        {
                            int iValorLimiteArchivos;
                            int.TryParse(dbSAICBPOValidacionDataSet1.stpSelParametro.Rows[0]["ValorParametro"].ToString(), out iValorLimiteArchivos);

                            if (miArchivo.Length <= iValorLimiteArchivos)
                            {
                                queriesTableAdapter1.stpInsDocumentoIMSS_1(miSolicitud.idSolicitud,
                                                        miArchivo.Name,
                                                        miArchivo.Extension,
                                                        stValorDocumento,
                                                       OperadorBD.OperadorGlobal.NombreUsuario
                                                       , miSolicitud.idTipoSolicitud
                                                       );

                                if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }

                                XtraMessageBox.Show("Archivo " + miArchivo.Name + ", guardado con Exito"
                                   , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            else
                            {
                                if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }
                                XtraMessageBox.Show("El Archivo no debe exceder de " + dbSAICBPOValidacionDataSet1.stpSelParametro.Rows[0]["ValorParametro"].ToString() + " KB"
                                 , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }
                            DialogResult resultado = XtraMessageBox.Show("No se tiene valor de limite para archivos."
                             , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }
                        XtraMessageBox.Show("No se puede convertir el Archivo para Subir."
                        , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }
                XtraMessageBox.Show("No se puede guardar en el archivo." + Environment.NewLine + ex.Message
                                , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void eliminarAfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = XtraMessageBox.Show("¿Desea eliminar los Documentos Afil de la Solicitud?"
                     , "SAIC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            splashScreenManager1.ShowWaitForm();
            try
            {
                if (DialogResult.Yes == resultado)
                {
                    queriesTableAdapter1.stpUpdDocumentoIMSS_1(miSolicitud.idSolicitud, OperadorBD.OperadorGlobal.NombreUsuario, miSolicitud.idTipoSolicitud);
                    if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }
                    XtraMessageBox.Show("Documentos Eliminados", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }
                XtraMessageBox.Show("No se puede eliminar los documentos" + Environment.NewLine + ex.Message, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }
        }
        public DateTime ObtenerFechaServidor()
        {
            // Obtener la fecha del servidor
            DateTime dtFechaServidor = new DateTime();
            String stfechaServidor = String.Empty;
            stfechaServidor = stpSelEstatusNominaContabilizadaTableAdapter1.ObtenerFechaServidor().ToString();
            DateTime.TryParse(stfechaServidor, out dtFechaServidor);
            return dtFechaServidor;
        }

        public DateTime obtenerFechaAltaLimite()
        {
            DateTime dFechaAltaLimite = ObtenerFechaServidor();
            int iDiasLimite = 5;

            stpSelParametroTableAdapter1.Fill(dbSAICBPOValidacionDataSet1.stpSelParametro, "DIAS LIMITE ALTAS");
            if (dbSAICBPOValidacionDataSet1.stpSelParametro.Rows.Count > 0)
            {
                int.TryParse(dbSAICBPOValidacionDataSet1.stpSelParametro.Rows[0]["ValorParametro"].ToString(), out iDiasLimite);
            }

            for (int i = 0; i < iDiasLimite; i++)
            {
                if (dFechaAltaLimite.Date.DayOfWeek.ToString() != "Saturday" && dFechaAltaLimite.Date.DayOfWeek.ToString() != "Sunday")
                {
                    dFechaAltaLimite = dFechaAltaLimite.AddDays(-1);
                }
                else
                {
                    dFechaAltaLimite = dFechaAltaLimite.AddDays(-1);
                    i--;
                }
            }

            //stpSelParametroTableAdapter1.Fill(dbSAICBPOValidacionDataSet1.stpSelParametro, "DIAS LIMITE BAJAS");
            //stpSelParametroTableAdapter1.Fill(dbSAICBPOValidacionDataSet1.stpSelParametro, "DIAS PARA BAJAS");
            return dFechaAltaLimite;
        }

        private DateTime obtenerFechaBajaLImite()
        {
            DateTime dFechaBajaLimite = ObtenerFechaServidor();
            int iDiasLimite = 5;

            stpSelParametroTableAdapter1.Fill(dbSAICBPOValidacionDataSet1.stpSelParametro, "DIAS LIMITE BAJAS");
            if (dbSAICBPOValidacionDataSet1.stpSelParametro.Rows.Count > 0)
            {
                int.TryParse(dbSAICBPOValidacionDataSet1.stpSelParametro.Rows[0]["ValorParametro"].ToString(), out iDiasLimite);
            }

            for (int i = 0; i < iDiasLimite; i++)
            {
                if (dFechaBajaLimite.Date.DayOfWeek.ToString() != "Saturday" && dFechaBajaLimite.Date.DayOfWeek.ToString() != "Sunday")
                {
                    dFechaBajaLimite = dFechaBajaLimite.AddDays(-1);
                }
                else
                {
                    dFechaBajaLimite = dFechaBajaLimite.AddDays(-1);
                    i--;
                }
            }
            return dFechaBajaLimite;
        }

        private DateTime obtenerFechaBajaFuturaLImite()
        {
            DateTime dFechaBajaFuturaLimite = new DateTime();
            int iDiasLimite = 2;

            stpSelParametroTableAdapter1.Fill(dbSAICBPOValidacionDataSet1.stpSelParametro, "DIAS PARA BAJAS");
            if (dbSAICBPOValidacionDataSet1.stpSelParametro.Rows.Count > 0)
            {
                int.TryParse(dbSAICBPOValidacionDataSet1.stpSelParametro.Rows[0]["ValorParametro"].ToString(), out iDiasLimite);
            }

            dFechaBajaFuturaLimite = ObtenerFechaServidor().AddDays(iDiasLimite);

            return dFechaBajaFuturaLimite;
        }

    }
}