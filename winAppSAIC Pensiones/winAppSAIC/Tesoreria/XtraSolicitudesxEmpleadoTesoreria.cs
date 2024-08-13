using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Diagnostics;
using compCatalogosSAIC;
using winAppSAIC.OperadoresM;

namespace winAppSAIC.Tesoreria
{
    public partial class XtraSolicitudesxEmpleadoTesoreria : DevExpress.XtraEditors.XtraForm
    {
        OperadoresM.Solicitud miSolicitud;
        tools.dsc dsc = new tools.dsc();

        const int TESORERIASA = 2;
        const int TESORERIASC = 3;
        int iConsecutivo = 1;
        String stEsquema = String.Empty;
        int iTipoTesoreria;
        OperadoresM.ColorSolicitud miColorSolicitud;

        public XtraSolicitudesxEmpleadoTesoreria(OperadoresM.Solicitud miSolicitud, int iTipoTesoreria)
        {
            InitializeComponent();
            this.miSolicitud = miSolicitud;
            this.iTipoTesoreria = iTipoTesoreria;
            Empleado objEmp;
        }

        private void XtraSolicitudesxEmpleadoTesoreria_Load(object sender, EventArgs e)
        {

            miColorSolicitud = new ColorSolicitud();
            miColorSolicitud = miColorSolicitud.obtenerColor();

            // TODO: This line of code loads data into the 'dbSAICBPOCatalogosDataSet.stpSelObtenerInfoGenericaTenedoraSC' table. You can move, or remove it, as needed.
            this.stpSelObtenerInfoGenericaTenedoraSCTableAdapter.Fill(this.dbSAICBPOCatalogosDataSet.stpSelObtenerInfoGenericaTenedoraSC);
            this.stpSelBancoAltaEmpleadosTableAdapter1.Fill(this.dbSAICBPOCatalogosDataSet.stpSelBancoAltaEmpleados, miSolicitud.idSolicitud, "SA", 0, false);

            if (iTipoTesoreria == 0)
            {
                rdTenedoraSA.Checked = true;
            }
            else
            {
                rdTenedorSC.Checked = true;
            }

            MostrarDetalleSolicitud(miSolicitud);
            CargarInformacion();

        }
        int iTotalEmpleados;

        private void MostrarDetalleSolicitud(Solicitud miSolicitud)
        {
            btnFormatoLayOut.Enabled = true;
            btnSolicitudAtendidos.Enabled = false;
            btnSolicitudRechazada.Enabled = false;
            txtSolicitud.Text = miSolicitud.idSolicitud.ToString();
            txtFechaSolicitud.Text = miSolicitud.FechaCreacion.ToShortDateString();
            txtOperador.Text = miSolicitud.NombreOperador;
            txtTenedoraSA.Text = miSolicitud.TenedoraSA;
            txtEstatus.Text = miSolicitud.EstatusTesoreria;
            //gridViewEmpleados.OptionsSelection.CheckBoxSelectorColumnWidth
            txtCliente.Text = miSolicitud.Cliente;
            gridLookTenedoraSC.Text = miSolicitud.TenedoraSC;
            txtTipoSolicitud.Text = miSolicitud.DescTipoSolicitud;
            gridLookTenedoraSC.EditValue = miSolicitud.idTenedoraSC;
        }

        private void CargarInformacion()
        {
            splashScreenManager1.ShowWaitForm();
            gridLookTenedoraSC.EditValue = miSolicitud.idTenedoraSC;

            if (rdTenedoraSA.Checked)
            {
                //Filtro para Sueldos
                stpSelSolicitudAltaEmpleadosTesoreria_V1TableAdapter1.Fill(dbSAICBPOCatalogosDataSet.stpSelSolicitudAltaEmpleadosTesoreria_V1, miSolicitud.idSolicitud, "S", "M", CheckTodasLasSolicitudes.Checked, miSolicitud.idTenedoraSA);
                this.stpSelBancoAltaEmpleadosTableAdapter1.Fill(this.dbSAICBPOCatalogosDataSet.stpSelBancoAltaEmpleados, miSolicitud.idTenedoraSA, "SA", miSolicitud.idTenedoraSC, false);
            }
            else
            {
                //Filtro para Aliments
                stpSelSolicitudAltaEmpleadosTesoreria_V1TableAdapter1.Fill(dbSAICBPOCatalogosDataSet.stpSelSolicitudAltaEmpleadosTesoreria_V1, miSolicitud.idSolicitud, "A", "M", CheckTodasLasSolicitudes.Checked, miSolicitud.idTenedoraSA);
                this.stpSelBancoAltaEmpleadosTableAdapter1.Fill(this.dbSAICBPOCatalogosDataSet.stpSelBancoAltaEmpleados, miSolicitud.idTenedoraSA, "SC", miSolicitud.idTenedoraSC, false);
            }

            //Filtro Solicitudes de empleados Sin tipo de Pago != CHEQUE
            //DataTable dtDetalleEmpleados = filtroEmpleadosSNCheque(dbSAICBPOCatalogosDataSet.stpSelSolicitudAltaEmpleadosTesoreria_V1);

            if (dbSAICBPOCatalogosDataSet.stpSelSolicitudAltaEmpleadosTesoreria_V1.Rows.Count > 0)
            {
                btnExportar.Enabled = true;
                btnDescargarDocumentacion.Enabled = true;
                iTotalEmpleados = dbSAICBPOCatalogosDataSet.stpSelSolicitudAltaEmpleadosTesoreria_V1.Rows.Count;
                int iEmpleadosSolicitadosSA = dbSAICBPOCatalogosDataSet.stpSelSolicitudAltaEmpleadosTesoreria_V1.AsEnumerable().Where(x => x["Estatus TesoreriaSA"].ToString() != "SOLICITUD ATENDIDA AL 100%").ToList().Count;
                int iEmpleadosSolicitadosSC = dbSAICBPOCatalogosDataSet.stpSelSolicitudAltaEmpleadosTesoreria_V1.AsEnumerable().Where(x => x["Estatus TesoreriaSC"].ToString() != "SOLICITUD ATENDIDA AL 100%").ToList().Count;

                lblTotalEmpleadosSolicitud.Text = "Total Empleados: " + dbSAICBPOCatalogosDataSet.stpSelSolicitudAltaEmpleadosTesoreria_V1.Rows.Count;

                if (rdTenedoraSA.Checked)
                {
                    stpSelSolicitudAltaEmpleadosTesoreria_V1TableAdapter1.Fill(dbSAICBPOCatalogosDataSet.stpSelSolicitudAltaEmpleadosTesoreria_V1, miSolicitud.idSolicitud, "S", "M", CheckTodasLasSolicitudes.Checked, miSolicitud.idTenedoraSA);
                    lblEmpleadosSolicitados.Text = "Empleados Solicitados: " + iEmpleadosSolicitadosSA;
                    lblEmpleadosAtendidos.Text = "Empleados Atendidos: " + dbSAICBPOCatalogosDataSet.stpSelSolicitudAltaEmpleadosTesoreria_V1.AsEnumerable().Where(x => x["Estatus TesoreriaSA"].ToString() == "SOLICITUD ATENDIDA AL 100%").ToList().Count;
                }
                else
                {
                    stpSelSolicitudAltaEmpleadosTesoreria_V1TableAdapter1.Fill(dbSAICBPOCatalogosDataSet.stpSelSolicitudAltaEmpleadosTesoreria_V1, miSolicitud.idSolicitud, "A", "M", CheckTodasLasSolicitudes.Checked, miSolicitud.idTenedoraSA);
                    lblEmpleadosSolicitados.Text = "Empleados Solicitados: " + iEmpleadosSolicitadosSC;
                    lblEmpleadosAtendidos.Text = "Empleados Atendidos: " + dbSAICBPOCatalogosDataSet.stpSelSolicitudAltaEmpleadosTesoreria_V1.AsEnumerable().Where(x => x["Estatus TesoreriaSC"].ToString() == "SOLICITUD ATENDIDA AL 100%").ToList().Count;
                }

                if (iEmpleadosSolicitadosSA > 0 || iEmpleadosSolicitadosSC > 0)
                {
                    btnSolicitudAtendidos.Enabled = true;
                    btnSolicitudRechazada.Enabled = true;
                }
                else
                {
                    btnSolicitudRechazada.Enabled = false;
                    btnSolicitudAtendidos.Enabled = false;
                }
            }

            splashScreenManager1.CloseWaitForm();
        }

        private DataTable filtroEmpleadosSNCheque(DataTable dtEmpleados)
        {

            var query = from x in dtEmpleados.AsEnumerable()
                        where !x.Field<String>("FormaPago").Equals("CHEQUE")
                        select x;

            if (query.Count() > 0)
            {
                dtEmpleados = query.CopyToDataTable();
            }

            return dtEmpleados;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            gridLookBancos.Enabled = false;
            btnFormatoLayOut.Text = "Generar Formato";
        }

        private void rdTenedoraSA_CheckedChanged(object sender, EventArgs e)
        {
            gridLookBancos.Enabled = true;
            btnFormatoLayOut.Text = "Generar LayOut";
            gridLookTenedoraSC.Enabled = false;
            if (rdTenedoraSA.Checked)
            {
                miSolicitud = miSolicitud.ObtenerSolcitud(miSolicitud.idSolicitud, 4);
                MostrarDetalleSolicitud(miSolicitud);
                CargarInformacion();
            }
        }

        private void rdTenedorSC_CheckedChanged(object sender, EventArgs e)
        {
            gridLookBancos.Enabled = true;
            btnFormatoLayOut.Text = "Generar LayOut";
            gridLookTenedoraSC.Enabled = false;
            if (rdTenedorSC.Checked)
            {
                miSolicitud = miSolicitud.ObtenerSolcitud(miSolicitud.idSolicitud, 4);
                MostrarDetalleSolicitud(miSolicitud);
                CargarInformacion();
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (gridViewEmpleados.SelectedRowsCount > 0)
            {
                DataTable dtEmpleados = dsc.deGridViewSelectedToDataTable(gridViewEmpleados);
                //DataTable dtEmpleados = dsc.deGridViewaDataTable(gridViewEmpleados);
                OperadoresM.XtraMonitoreoSolicitudesOperaciones Operaciones = new OperadoresM.XtraMonitoreoSolicitudesOperaciones(0);
                Operaciones.descargarArchivoEmpleados(dtEmpleados, miSolicitud, 3);
            }
            else
            {
                XtraMessageBox.Show("Seleccione a un Empleado."
                 , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gridViewEmpleados.Focus();
            }

            //DataTable dtEmpleados = dsc.deGridViewaDataTable(gridViewEmpleados);
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
            //        Rango = SheetExcel.get_Range("A:M");
            //        Rango.NumberFormat = "@";

            //        Rango = SheetExcel.get_Range("A1");
            //        Rango.Select();

            //        Rango.PasteSpecial();
            //        Rango = SheetExcel.get_Range("A1:M1");
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
        }

        private void CheckConTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            //if (CheckConTarjeta.Checked)
            //{
            //    DataTable dtSolicitudestarjeta = dtEmpleadosSolcitud.Clone();

            //    var query = from x in dtEmpleadosSolcitud.AsEnumerable()
            //                where x.Field<String>("FormaPago").Equals("TARJETA")
            //                select x;

            //    if (query.Count() > 0)
            //    {
            //        dtSolicitudestarjeta = query.CopyToDataTable();
            //        ControlEmpleados.DataSource = dtSolicitudestarjeta;
            //        gridViewEmpleados.BestFitColumns();
            //    }
            //}
            //else
            //{
            //    ControlEmpleados.DataSource = dtEmpleadosSolcitud;
            //    gridViewEmpleados.BestFitColumns();
            //}
        }

        private void btnSolicitudAtendidos_Click(object sender, EventArgs e)
        {
            int iTesoreria = 0;
            if (rdTenedoraSA.Checked)
            {
                iTesoreria = TESORERIASA;
            }
            else
            {
                iTesoreria = TESORERIASC;
            }

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
                    foreach (DataRow unRow in dtEmpleadosSeleccionados.Rows)
                    {
                        int iIDempleado;
                        int idSolicitud;

                        int.TryParse(unRow["IdEmpleado"].ToString(), out iIDempleado);
                        int.TryParse(unRow["idSolicitud"].ToString(), out idSolicitud);

                        if (iIDempleado != 0 && idSolicitud != 0 && unRow["EstatusRegistro"].ToString() == "ACTIVO")
                        {
                            try
                            {
                                queriesTableAdapter1.stpUpdEstatusSolicitudAlta(iTesoreria,
                                                  idSolicitud,
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

                    XtraMessageBox.Show("Empleados Atendidos: " + iAtendidos + Environment.NewLine +
                        "Empleados no Actualizados: " + iConError + Environment.NewLine +
                        "Empleados por Atender: " + ipendientes
                        , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    miSolicitud = miSolicitud.ObtenerSolcitud(miSolicitud.idSolicitud, 4);
                    MostrarDetalleSolicitud(miSolicitud);
                    CargarInformacion();
                }
            }
            else
            {
                XtraMessageBox.Show("Por favor seleccione un Empleado."
                    , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void uncheckedGridEmpleado()
        {
            for (int i = 0; i < gridViewEmpleados.RowCount; i++)
            {
                if (rdTenedoraSA.Checked)
                {
                    if (gridViewEmpleados.GetDataRow(i)["Estatus TesoreriaSA"].ToString() == "SOLICITUD ATENDIDA AL 100%" || gridViewEmpleados.GetDataRow(i)["Estatus TesoreriaSA"].ToString() == "SOLICITUD RECHAZADA" || gridViewEmpleados.GetDataRow(i)["FormaPago"].ToString() == "TARJETA")
                        gridViewEmpleados.UnselectRow(i);
                }
                else
                {
                    if (gridViewEmpleados.GetDataRow(i)["Estatus TesoreriaSC"].ToString() == "SOLICITUD ATENDIDA AL 100%" || gridViewEmpleados.GetDataRow(i)["Estatus TesoreriaSC"].ToString() == "SOLICITUD RECHAZADA" || gridViewEmpleados.GetDataRow(i)["FormaPago"].ToString() == "TARJETA")
                        gridViewEmpleados.UnselectRow(i);
                }
            }
        }


        private void gridViewEmpleados_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            Boolean hayClabe = false;
            Boolean hayRechazoSA = false;
            Boolean hayRechazoSC = false;
            Boolean hayRechazoEmpleados = false;

            try
            {
                DataRow unRow = gridViewEmpleados.GetDataRow(e.RowHandle);

                int idEmpleado = 0;
                int.TryParse(unRow["IdEmpleado"].ToString(), out idEmpleado);

                //Si se esta actulizando la Clabe del empleado
                if (e.Column.FieldName == "CLABE")
                {
                    Boolean esClabe = false;
                    var varEsClabe = queriesTableAdapter1.ValidarClabe(unRow["Clabe"].ToString());
                    Boolean.TryParse(varEsClabe.ToString(), out esClabe);
                    //esClabe = queriesTableAdapter1.ValidarClabe(unRow["Clabe"].ToString());

                    if (esClabe == true)
                    {
                        hayClabe = true;
                    }
                    else
                    {
                        XtraMessageBox.Show("Clabe Incorrecta: " + unRow["Clabe"].ToString() + Environment.NewLine
                  , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                if (e.Column.FieldName == "Rechazo TesoreriaSA" || e.Column.FieldName == "Rechazo TesoreriaSC")
                {
                    hayRechazoEmpleados = hayEmpleadoRechazo();
                    if (!hayRechazoEmpleados)
                    {
                        DialogResult Resultado = XtraMessageBox.Show("Se esta haciendo un comentario de Rechazo. ¿Esta Seguro que quiere Rechazar la Solicitd " + miSolicitud.idSolicitud + "?"
                  , "SAIC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (Resultado == DialogResult.No)
                        {
                            if (e.Column.FieldName == "Rechazo TesoreriaSA")
                            {
                                unRow["Rechazo TesoreriaSA"] = String.Empty;
                            }
                            if (e.Column.FieldName == "Rechazo TesoreriaSC")
                            {
                                unRow["Rechazo TesoreriaSC"] = String.Empty;
                            }
                        }
                        else
                        {
                            if (e.Column.FieldName == "Rechazo TesoreriaSA")
                            {
                                hayRechazoSA = true;
                            }
                            if (e.Column.FieldName == "Rechazo TesoreriaSC")
                            {
                                hayRechazoSC = true;
                            }
                        }
                    }
                }
                actualizarEmpleado(idEmpleado, miSolicitud.idSolicitud, unRow["Clabe"].ToString(), unRow["Rechazo TesoreriaSA"].ToString(), unRow["Rechazo TesoreriaSC"].ToString(), hayRechazoSA, hayRechazoSC, hayClabe);
            }
            catch (Exception exp)
            {
                XtraMessageBox.Show("No se pudo actualizar la información en la Base: " + Environment.NewLine + exp.Message
               , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
                         where !x.Field<String>("Rechazo TesoreriaSA").Equals("") || !x.Field<String>("Rechazo TesoreriaSC").Equals("")
                         select x).ToList().Count;

            if (query > 1)
            {
                hayempleadosRechazo = true;
            }

            return hayempleadosRechazo;
        }

        private void actualizarEmpleado(int iEmpleado, int iSolicitud, String Clabe, String stRechazoSA, String stRechazoSC, Boolean HayRechazoSA, Boolean HayRechazoSC, Boolean ACtualizacionClabe)
        {
            queriesTableAdapter1.stpUpEmpleadoInformacionTesoreria(
                iSolicitud,
                iEmpleado,
                Clabe,

                stRechazoSA,
                stRechazoSC,

                HayRechazoSA,
                HayRechazoSC,
                ACtualizacionClabe,

                OperadorBD.OperadorGlobal.NombreUsuario,
                OperadorBD.OperadorGlobal.NombreOperador
                );

            miSolicitud = miSolicitud.ObtenerSolcitud(miSolicitud.idSolicitud, 4);
            MostrarDetalleSolicitud(miSolicitud);
            CargarInformacion();
        }

        private void gridViewEmpleados_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                if (e.RowHandle >= 0)
                {
                    gridViewEmpleados.OptionsSelection.EnableAppearanceFocusedRow = false;
                    //string category = View.GetRowCellDisplayText(e.RowHandle, View.Columns["Category"]);

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

                    if (rdTenedoraSA.Checked)
                    {
                        if (gridViewEmpleados.GetDataRow(e.RowHandle)["Estatus TesoreriaSA"].ToString() == "SOLICITUD ATENDIDA AL 100%")
                        {
                            e.Appearance.BackColor = Color.FromArgb(miColorSolicitud.idColorAtendida[0], miColorSolicitud.idColorAtendida[1], miColorSolicitud.idColorAtendida[2]);
                            e.HighPriority = true;
                        }
                        else if (gridViewEmpleados.GetDataRow(e.RowHandle)["Estatus TesoreriaSA"].ToString() == "SOLICITUD RECHAZADA")
                        {
                            e.Appearance.BackColor = Color.FromArgb(miColorSolicitud.idColorRechazada[0], miColorSolicitud.idColorRechazada[1], miColorSolicitud.idColorRechazada[2]);
                            e.HighPriority = true;
                        }

                    }

                    if (rdTenedorSC.Checked)
                    {
                        if (gridViewEmpleados.GetDataRow(e.RowHandle)["Estatus TesoreriaSC"].ToString() == "SOLICITUD ATENDIDA AL 100%")
                        {
                            e.Appearance.BackColor = Color.FromArgb(miColorSolicitud.idColorAtendida[0], miColorSolicitud.idColorAtendida[1], miColorSolicitud.idColorAtendida[2]);
                            e.HighPriority = true;
                        }
                        else if (gridViewEmpleados.GetDataRow(e.RowHandle)["Estatus TesoreriaSC"].ToString() == "SOLICITUD RECHAZADA")
                        {
                            e.Appearance.BackColor = Color.FromArgb(miColorSolicitud.idColorRechazada[0], miColorSolicitud.idColorRechazada[1], miColorSolicitud.idColorRechazada[2]);
                            e.HighPriority = true;
                        }
                    }

                    if (gridViewEmpleados.GetDataRow(e.RowHandle)["DescEstatus"].ToString() == "BAJA")
                    {
                        e.Appearance.BackColor = Color.Gainsboro;
                        e.Appearance.ForeColor = Color.DimGray;
                        e.HighPriority = true;
                    }
                }
            }
            catch (Exception) { }
        }

        private void gridViewEmpleados_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            //for (int i = 0; i < gridViewEmpleados.RowCount; i++)
            //{
            //    if (rdTenedoraSA.Checked)
            //    {
            //        if (gridViewEmpleados.GetDataRow(i)["Estatus TesoreriaSA"].ToString() == "SOLICITUD ATENDIDA AL 100%" || gridViewEmpleados.GetDataRow(i)["Estatus TesoreriaSA"].ToString() == "SOLICITUD RECHAZADA")
            //            gridViewEmpleados.UnselectRow(i);
            //    }
            //    else
            //    {
            //        if (gridViewEmpleados.GetDataRow(i)["Estatus TesoreriaSC"].ToString() == "SOLICITUD ATENDIDA AL 100%" || gridViewEmpleados.GetDataRow(i)["Estatus TesoreriaSC"].ToString() == "SOLICITUD RECHAZADA")
            //            gridViewEmpleados.UnselectRow(i);
            //    }
            //}
        }

        private void btnDescargarDocumentacion_Click(object sender, EventArgs e)
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
            //String stRutaSolicitud = dsc.stRutaSAIC + @"Alta Empleados Solicitudes\" + miSolicitud.idSolicitud + @"\";
            //dsc.CheckandCreateFolder(stRutaSolicitud);
            //DataTable dtEmpleados = dsc.deGridViewaDataTable(gridViewEmpleados);
            //foreach (DataRow unRow in dtEmpleados.Rows)
            //{
            //    int idEmpleado = Convert.ToInt32(unRow["IdEmpleado"].ToString());
            //    try
            //    {
            //        stpSelDocumentoEmpleadoTableAdapter1.Fill(dbSAICBPOCatalogosDataSet.stpSelDocumentoEmpleado, idEmpleado);
            //        if (dbSAICBPOCatalogosDataSet.stpSelDocumentoEmpleado.Rows.Count > 0)
            //        {
            //            //Creando Carpeta por Empleado
            //            String stRutaEmpleado = stRutaSolicitud + idEmpleado + @"\";
            //            dsc.CheckandCreateFolder(stRutaEmpleado);

            //            String stNombreEmpleado = dbSAICBPOCatalogosDataSet.stpSelDocumentoEmpleado[0]["NombreEmpleadoCompleto"].ToString();
            //            stNombreEmpleado = stNombreEmpleado.Replace("\\", "").Replace("/", "").Replace(":", "").Replace("+", "").Replace("?", "").Replace("\"", "").Replace("<", "").Replace(">", "").Replace("|", "");
            //            dsc.ConvertToFile(dbSAICBPOCatalogosDataSet.stpSelDocumentoEmpleado[0]["DesDocumento"].ToString(), stRutaEmpleado + stNombreEmpleado + ".pdf");
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

        //Editar
        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            try
            {

                gridViewEmpleados.Focus();
                DataRow unRow = gridViewEmpleados.GetDataRow(gridViewEmpleados.FocusedRowHandle);

                if (unRow["EstatusRegistro"].ToString() == "ACTIVO")
                {
                    String stColumnaEstatusTesoreria = String.Empty;
                    String StAreatesoreia = String.Empty;
                    String StColumnaRechazoTesoreria = String.Empty;

                if (rdTenedoraSA.Checked)
                {
                    StAreatesoreia = "TESOSA";
                    stColumnaEstatusTesoreria = "Estatus TesoreriaSA";
                    StColumnaRechazoTesoreria = "Rechazo TesoreriaSA";
                }
                else
                {
                    StAreatesoreia = "TESOSC";
                    stColumnaEstatusTesoreria = "Estatus TesoreriaSC";
                    StColumnaRechazoTesoreria = "Rechazo TesoreriaSC";
                }

                if (unRow != null)
                {
                    if (unRow[stColumnaEstatusTesoreria].ToString() == "SOLICITUD ATENDIDA AL 100%")
                    {
                        XtraMessageBox.Show("El Empleado: " +
                              unRow["Nombre"].ToString() + " " +
                              unRow["Apellido Paterno"].ToString() + " " +
                              unRow["Apellido Materno"].ToString() + ", ya se encuentra Atendido al 100%."
                         , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (unRow[stColumnaEstatusTesoreria].ToString() == "SOLICITUD RECHAZADA")
                    {
                        XtraMessageBox.Show("El Empleado: " +
                            unRow["Nombre"].ToString() + " " +
                            unRow["Apellido Paterno"].ToString() + " " +
                            unRow["Apellido Materno"].ToString() + ", NO se puede Editar al Empleado. Se requiere Respuesta por parte de Operaciones."
                       , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (unRow["FormaPago"].ToString() == "TARJETA" || (unRow["FormaPago"].ToString() == "TRANSFERENCIA"))
                    {
                        if (rdTenedoraSA.Checked)
                        {
                            int idEmpleado;
                            int.TryParse(unRow["idEmpleado"].ToString(), out idEmpleado);

                            XtraForm1 editarEmpleado = new XtraForm1(
                                idEmpleado,
                                unRow["Apellido Paterno"].ToString() + " " +
                                unRow["Apellido Materno"].ToString() + " " +
                                unRow["Nombre"].ToString(),
                                unRow["CURP"].ToString(),
                                unRow["RFC"].ToString(),
                                unRow["NSS"].ToString(),
                                unRow["FormaPago"].ToString(),
                                unRow["Banco"].ToString(),
                                unRow["Cuenta"].ToString(),
                                unRow["CLABE"].ToString(),
                                unRow["NoTarjeta"].ToString()
                                );
                            editarEmpleado.ShowDialog();

                            miSolicitud = miSolicitud.ObtenerSolcitud(miSolicitud.idSolicitud, 4);
                            MostrarDetalleSolicitud(miSolicitud);
                            CargarInformacion();
                        }
                        else
                        {
                            if (unRow["FormaPago"].ToString() == "TARJETA")
                            {
                                XtraMessageBox.Show("El Empleado: " +
                                                   unRow["Nombre"].ToString() + " " +
                                                   unRow["Apellido Paterno"].ToString() + " " +
                                                   unRow["Apellido Materno"].ToString() + ", No se puede Editar al Empleado. Espere a Tesoreria Sueldos Ingrese una Clabe."
                                              , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {

                                int idEmpleado;
                                int.TryParse(unRow["idEmpleado"].ToString(), out idEmpleado);

                                XtraForm1 editarEmpleado = new XtraForm1(
                            idEmpleado,
                            unRow["Apellido Paterno"].ToString() + " " +
                            unRow["Apellido Materno"].ToString() + " " +
                            unRow["Nombre"].ToString(),
                            unRow["CURP"].ToString(),
                            unRow["RFC"].ToString(),
                            unRow["NSS"].ToString(),
                            unRow["FormaPago"].ToString(),
                            unRow["Banco"].ToString(),
                            unRow["Cuenta"].ToString(),
                            unRow["CLABE"].ToString(),
                            unRow["NoTarjeta"].ToString()
                            );
                                editarEmpleado.ShowDialog();

                                miSolicitud = miSolicitud.ObtenerSolcitud(miSolicitud.idSolicitud, 4);
                                MostrarDetalleSolicitud(miSolicitud);
                                CargarInformacion();
                            }
                        }
                    }
                    else
                    {
                        DialogResult resultado = XtraMessageBox.Show("No se puede Editar al Empleado, " +
                                unRow["Nombre"].ToString() + " " +
                                unRow["Apellido Paterno"].ToString() + " " +
                                unRow["Apellido Materno"].ToString() + "." + Environment.NewLine +
                                "Ya tiene una Clabe asignada."
                                , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                }
                else
                {
                    XtraMessageBox.Show("El estatus del empleado en la solicitud no se encuentra activa.", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                DialogResult resultado = XtraMessageBox.Show("No se puede Editar al Emplado." + Environment.NewLine + ex.Message
                               , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Atender
        private void repositoryItemButtonEdit2_Click(object sender, EventArgs e)
        {
            try
            {
                gridViewEmpleados.Focus();
                DataRow unRow = gridViewEmpleados.GetDataRow(gridViewEmpleados.FocusedRowHandle);

                if (unRow["EstatusRegistro"].ToString() == "ACTIVO")
                {

                String stColumnaEstatusTesoreria = String.Empty;
                String StAreatesoreia = String.Empty;
                String StColumnaRechazoTesoreria = String.Empty;

                int iTeso = 0;

                if (rdTenedoraSA.Checked)
                {
                    StAreatesoreia = "TESOSA";
                    stColumnaEstatusTesoreria = "Estatus TesoreriaSA";
                    StColumnaRechazoTesoreria = "Rechazo TesoreriaSA";
                    iTeso = 2;
                }
                else
                {
                    StAreatesoreia = "TESOSC";
                    stColumnaEstatusTesoreria = "Estatus TesoreriaSC";
                    StColumnaRechazoTesoreria = "Rechazo TesoreriaSC";
                    iTeso = 3;
                }

                if (unRow != null)
                {
                    if (unRow[stColumnaEstatusTesoreria].ToString() == "SOLICITUD ATENDIDA AL 100%")
                    {
                        XtraMessageBox.Show("El Empleado: " +
                              unRow["Nombre"].ToString() + " " +
                              unRow["Apellido Paterno"].ToString() + " " +
                              unRow["Apellido Materno"].ToString() + ", ya se encuentra Atendido al 100%."
                         , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (unRow[stColumnaEstatusTesoreria].ToString() == "SOLICITUD RECHAZADA")
                    {
                        XtraMessageBox.Show("El Empleado: " +
                            unRow["Nombre"].ToString() + " " +
                            unRow["Apellido Paterno"].ToString() + " " +
                            unRow["Apellido Materno"].ToString() + ", NO se puede Atender al Empleado. Se requiere Respuesta por parte de Operaciones."
                       , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (unRow["FormaPago"].ToString() != "TARJETA")
                        {
                            DialogResult resultado = XtraMessageBox.Show("¿Desea Atender al Empleado: " +
                                    unRow["Nombre"].ToString() + " " +
                                    unRow["Apellido Paterno"].ToString() + " " +
                                    unRow["Apellido Materno"].ToString() + "?", "SAIC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (DialogResult.Yes == resultado)
                            {
                                int iIDempleado;
                                int idSolicitud;

                                int.TryParse(unRow["IdEmpleado"].ToString(), out iIDempleado);
                                int.TryParse(unRow["idSolicitud"].ToString(), out idSolicitud);


                                if (iIDempleado != 0 && idSolicitud != 0)
                                {
                                    try
                                    {
                                        queriesTableAdapter1.stpUpdEstatusSolicitudAlta(iTeso,
                                                          idSolicitud,
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

                                        miSolicitud = miSolicitud.ObtenerSolcitud(miSolicitud.idSolicitud, 4);
                                        MostrarDetalleSolicitud(miSolicitud);
                                        CargarInformacion();
                                    }
                                }
                            }
                            else
                            {
                                XtraMessageBox.Show("No se puede Atender al Empleado. Ingrese una CLABE para Atenderlo.", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                else
                {
                    XtraMessageBox.Show("El estatus del empleado en la solicitud no se encuentra activa.", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                DialogResult resultado = XtraMessageBox.Show("No se puede Atender al Emplado." + Environment.NewLine + ex.Message
                              , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Rechazar
        private void repositoryItemButtonEdit3_Click(object sender, EventArgs e)
        {
            try
            {
                gridViewEmpleados.Focus();
                DataRow unRow = gridViewEmpleados.GetDataRow(gridViewEmpleados.FocusedRowHandle);


                if (unRow["EstatusRegistro"].ToString() == "ACTIVO")
                {
                    String stColumnaEstatusTesoreria = String.Empty;
                    String StAreatesoreia = String.Empty;
                    String StColumnaRechazoTesoreria = String.Empty;

                if (rdTenedoraSA.Checked)
                {
                    StAreatesoreia = "TESOSA";
                    stColumnaEstatusTesoreria = "Estatus TesoreriaSA";
                    StColumnaRechazoTesoreria = "Rechazo TesoreriaSA";
                }
                else
                {
                    StAreatesoreia = "TESOSC";
                    stColumnaEstatusTesoreria = "Estatus TesoreriaSC";
                    StColumnaRechazoTesoreria = "Rechazo TesoreriaSC";
                }

                if (unRow != null)
                {
                    if (unRow[stColumnaEstatusTesoreria].ToString() == "SOLICITUD ATENDIDA AL 100%")
                    {
                        XtraMessageBox.Show("El Empleado: " +
                            unRow["Nombre"].ToString() + " " +
                            unRow["Apellido Paterno"].ToString() + " " +
                            unRow["Apellido Materno"].ToString() + ", ya se encuentra Atendido al 100%."

                       , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (unRow[stColumnaEstatusTesoreria].ToString() == "SOLICITUD RECHAZADA")
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
                        int idSolicitud;

                        int.TryParse(unRow["IdEmpleado"].ToString(), out idEmpleado);
                        int.TryParse(unRow["idSolicitud"].ToString(), out idSolicitud);

                        
                        DataTable dtEmpleadosporAtender = miSolicitud.obtenerRegistros_Emitidos_Proceso_Respondidos(gridViewEmpleados, stColumnaEstatusTesoreria);
                        OperadoresM.XtraRechazoSolicitud rechazarSolicitud = new OperadoresM.XtraRechazoSolicitud(
                            dtEmpleadosporAtender,
                            idSolicitud,
                            idEmpleado,
                            StAreatesoreia,
                            unRow["Nombre"].ToString() + " " +
                            unRow["Apellido Paterno"].ToString() + " " +
                            unRow["Apellido Materno"].ToString(),
                             unRow[StColumnaRechazoTesoreria].ToString()
                            );
                        rechazarSolicitud.ShowDialog();

                            miSolicitud = miSolicitud.ObtenerSolcitud(miSolicitud.idSolicitud, 4);
                            MostrarDetalleSolicitud(miSolicitud);
                            CargarInformacion();
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("No se puede abrir el modulo de Rechazo.", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    XtraMessageBox.Show("El estatus del empleado en la solicitud no se encuentra activa.", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                DialogResult resultado = XtraMessageBox.Show("No se puede Rechazar al Emplado." + Environment.NewLine + ex.Message
                                              , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gridLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnFormatoLayOut_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(gridLookBancos.Text))
            {
                if (gridViewEmpleados.SelectedRowsCount > 0)
                {
                    DataTable dtEmpleado = dsc.deGridViewSelectedToDataTable(gridViewEmpleados);

                    if (gridLookBancos.Text != "BANORTE ALTA DE TARJETAS")
                    {
                        int iFormaPagoTarjeta = dtEmpleado.Select("FormaPago = 'TARJETA'").Count();

                        if (iFormaPagoTarjeta > 0)
                        {
                            XtraMessageBox.Show("No se puede Generar LAYOUT.  " + Environment.NewLine + "Hay Empleados seleccionados pendientes por asignar CLABE. Por favor ingrese la Clabe para poder generar LAYOUT."
                            , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            int iEmpleadosRechazados_Atendidos = dtEmpleado.Select("[Estatus TesoreriaSA] = 'SOLICITUD ATENDIDA AL 100%' OR [Estatus TesoreriaSA] = 'SOLICITUD RECHAZADA'").Count();
                            Boolean flagEstaMuyBien = true;

                            if (iEmpleadosRechazados_Atendidos > 0)
                            {
                                DialogResult Resultado = XtraMessageBox.Show("Hay empleados seleccionados con estatus ATENDIDA o RECHAZADA. ¿Desea desea generar el LayOut?"
                            , "SAIC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (DialogResult.Yes != Resultado)
                                {
                                    flagEstaMuyBien = false;
                                }
                            }

                            if (flagEstaMuyBien)
                            {
                                obtenerLayout(dtEmpleado);
                            }
                        }
                    }
                    else
                    {
                        int iFormaPagoTransferencia = dtEmpleado.Select("FormaPago = 'TRANSFERENCIA'").Count();

                        if (iFormaPagoTransferencia > 0)
                        {
                            XtraMessageBox.Show("No se puede Generar LAYOUT.  " + Environment.NewLine + "Hay Empleados seleccionados que ya cuentan con Tarjeta. Por favor seleccione a los empleados con Tipo de Pago: Tarjeta."
                            , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            obtenerLayout(dtEmpleado);
                        }
                    }
                }
                else
                {
                    XtraMessageBox.Show("Seleccione un empleado."
                          , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                XtraMessageBox.Show("Seleccione un tipo de LayOut."
                            , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void obtenerLayout(DataTable dtEmpleados)
        {
            try
            {
                String stCabecera = String.Empty;
                String stNombreArchivo = String.Empty;
                int tipoDelayOut = Convert.ToInt32(gridLookBancos.EditValue);

                DataTable dtbancos = dbSAICBPOCatalogosDataSet.stpSelBancoAltaEmpleados.Clone();

                if (gridLookBancos.Text == "TODOS")
                {
                    dtbancos = dbSAICBPOCatalogosDataSet.stpSelBancoAltaEmpleados;
                }
                else
                {
                    dtbancos = filtarBancoSeleccionado(dbSAICBPOCatalogosDataSet.stpSelBancoAltaEmpleados, tipoDelayOut);
                }

                foreach (DataRow item in dtbancos.Rows)
                {
                    String stEsquema = rdTenedoraSA.Checked ? "S" : "A";
                    List<String> layOutEmpleados = new List<String>();
                    int.TryParse(item["idBancoAltaEmpleados"].ToString(), out tipoDelayOut);

                    if (item["BancoNombreDesc"].ToString() != "TODOS")
                    {
                        foreach (DataRow empleado in dtEmpleados.Rows)
                        {
                            int idEmpleado;
                            int.TryParse(empleado["IdEmpleado"].ToString(), out idEmpleado);

                            if (idEmpleado > 0)
                            {
                                stpSelObtenerLayOutAltaEmpleadosBancosTableAdapter1.Fill(this.dbSAICBPOCatalogosDataSet.stpSelObtenerLayOutAltaEmpleadosBancos, miSolicitud.idSolicitud, idEmpleado, tipoDelayOut, stEsquema, miSolicitud.idTenedoraSC, dtEmpleados.Rows.Count, rdTenedoraSA.Checked);
                                //stpSelObtenerLayOutAltaEmpleadosBancosTableAdapter1.Fill(this.dbSAICBPOCatalogosDataSet.stpSelObtenerLayOutAltaEmpleadosBancos, miSolicitud.idSolicitud, idEmpleado, tipoDelayOut, dtEmpleados.Rows.Count);
                                stCabecera = dbSAICBPOCatalogosDataSet.stpSelObtenerLayOutAltaEmpleadosBancos[0][1].ToString();

                                if (!String.IsNullOrEmpty(dbSAICBPOCatalogosDataSet.stpSelObtenerLayOutAltaEmpleadosBancos[0][0].ToString()))
                                {
                                    layOutEmpleados.Add(dbSAICBPOCatalogosDataSet.stpSelObtenerLayOutAltaEmpleadosBancos[0][0].ToString());
                                }
                            }
                        }

                        int tipoLeyOut_1;
                        int.TryParse(item["idBancoAltaEmpleados"].ToString(), out tipoLeyOut_1);

                        //Agregar cabecera
                        //if (tipoLeyOut_1 == 2)
                        if (!String.IsNullOrEmpty(stCabecera))
                        {
                            List<String> listaTemp = new List<string>();
                            listaTemp.Add(stCabecera);
                            foreach (String layoutEmpleados in layOutEmpleados) { listaTemp.Add(layoutEmpleados); }
                            layOutEmpleados = listaTemp;
                        }

                        int idTenedoraSC;
                        int.TryParse(gridLookTenedoraSC.EditValue.ToString(), out idTenedoraSC);

                        stpSelBancoAltaEmpleadosNombreArchivoTableAdapter1.Fill(this.dbSAICBPOCatalogosDataSet.stpSelBancoAltaEmpleadosNombreArchivo, tipoLeyOut_1, miSolicitud.idTenedoraSA, idTenedoraSC, stEsquema, iConsecutivo.ToString("00"));
                        //stpSelBancoAltaEmpleadosNombreArchivoTableAdapter1.Fill(this.dbSAICBPOCatalogosDataSet.stpSelBancoAltaEmpleadosNombreArchivo, tipoLeyOut_1, miSolicitud.idTenedoraSA, iConsecutivo.ToString("00"));
                        stNombreArchivo = dbSAICBPOCatalogosDataSet.stpSelBancoAltaEmpleadosNombreArchivo[0][0].ToString();

                        if (!String.IsNullOrEmpty(stNombreArchivo))
                        {
                            generarLayOut(layOutEmpleados, stNombreArchivo);
                        }
                        else
                        {
                            XtraMessageBox.Show("No se puede generar el archivo." + Environment.NewLine + Environment.NewLine + "No se tiene nombre para el LayOut."
                             , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }

                XtraMessageBox.Show("LayOut creado con Exito: " + miSolicitud.sRutaSolicitud + miSolicitud.idSolicitud + @"\" + gridLookBancos.Text + @"\" + stNombreArchivo
                            , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("No se puede crear el LayOut Bancario." + Environment.NewLine + ex.Message
                           , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //foreach (DataRow empleado in dtEmpleados.Rows)
            //{
            //    int idEmpleado;
            //    int.TryParse(empleado["IdEmpleado"].ToString(), out idEmpleado);

            //    if (idEmpleado > 0)
            //    {
            //        stpSelObtenerLayOutAltaEmpleadosBancosTableAdapter1.Fill(this.dbSAICBPOCatalogosDataSet.stpSelObtenerLayOutAltaEmpleadosBancos, miSolicitud.idSolicitud, idEmpleado, tipoDelayOut, dtEmpleados.Rows.Count);
            //        stCabecera = dbSAICBPOCatalogosDataSet.stpSelObtenerLayOutAltaEmpleadosBancos[0][1].ToString();
            //        layOutEmpleados.Add(dbSAICBPOCatalogosDataSet.stpSelObtenerLayOutAltaEmpleadosBancos[0][0].ToString());
            //    }
            //}

            ////Agregar cabecera
            //if (tipoDelayOut == 2)
            //{
            //    List<String> lsitaTemp = new List<string>();
            //    lsitaTemp.Add(stCabecera);
            //    foreach (String item in layOutEmpleados) { lsitaTemp.Add(item); }
            //    layOutEmpleados = lsitaTemp;
            //}

            //stpSelBancoAltaEmpleadosNombreArchivoTableAdapter1.Fill(this.dbSAICBPOCatalogosDataSet.stpSelBancoAltaEmpleadosNombreArchivo, tipoDelayOut, miSolicitud.idTenedoraSA, iConsecutivo.ToString("00"));
            //stNombreArchivo = dbSAICBPOCatalogosDataSet.stpSelBancoAltaEmpleadosNombreArchivo[0][0].ToString();

            //generarLayOut(layOutEmpleados, stNombreArchivo);

        }

        public DataTable filtarBancoSeleccionado(DataTable dtbancos, int iIndiceBanco)
        {
            DataTable dtbancosTemp = dtbancos.Clone();
            var query = from x in dtbancos.AsEnumerable()
                        where x.Field<int>("idBancoAltaEmpleados").Equals(iIndiceBanco)
                        select x;

            if (query.Count() > 0)
            {
                dtbancosTemp = query.CopyToDataTable();
            }

            return dtbancosTemp;
        }

        private void generarLayOut(List<String> layOutEmpleados, String stNombreArchivo)
        {
            String stRutaLayOut = miSolicitud.sRutaSolicitud + miSolicitud.idSolicitud + @"\" + gridLookBancos.Text + @"\";
            dsc.CheckandCreateFolder(stRutaLayOut);
            String stNOmbreArchivo = String.Empty;

            File.WriteAllLines(stRutaLayOut + stNombreArchivo, layOutEmpleados);
        }

        private void btnAbrirCarpeta_Click(object sender, EventArgs e)
        {
            String stRutaSolicitud = miSolicitud.sRutaSolicitud + miSolicitud.idSolicitud;
            dsc.CheckandCreateFolder(stRutaSolicitud);
            Process.Start(stRutaSolicitud);
        }

        private void gridViewEmpleados_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void ControlEmpleados_KeyUp(object sender, KeyEventArgs e)
        {

        }

        public void descargarArchivoEmpleadosTarjeta(DataTable dtEmpleados)
        {
            try
            {
                splashScreenManager1.ShowWaitForm();
                splashScreenManager1.SetWaitFormCaption("Descargando Archivo");
                splashScreenManager1.SetWaitFormDescription("Espere Por favor...");

                String stDatosEmppleados = String.Empty;
                stDatosEmppleados = dsc.ConvertDataTableToString(dtEmpleados, true);
                if (!String.IsNullOrEmpty(stDatosEmppleados))
                {
                    String stColumnaExcel = dsc.ColumnaExcel(dtEmpleados.Columns.Count);
                    String stRutaArchivo = String.Empty;

                    stRutaArchivo = miSolicitud.sRutaSolicitud + @"Detalle-Empleados-Tarjeta-" + dsc.nombreAleatorio() + ".xlsx";
                    dsc.CheckandCreateFolder(miSolicitud.sRutaSolicitud);

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
                    Clipboard.SetText(stDatosEmppleados);

                    SheetExcel = (Excel.Worksheet)bookExcel.ActiveSheet;
                    SheetExcel.Name = "Det Empleados Tarjeta";
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

                    appExcel.DisplayAlerts = true;

                    bookExcel.SaveAs(stRutaArchivo);
                }

                if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }

                XtraMessageBox.Show("Archivo Generado con Exito."
               , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }
                XtraMessageBox.Show("No se puede descargar el Reporte." + Environment.NewLine + ex.Message
              , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void gridLookTenedoraSC_EditValueChanged(object sender, EventArgs e)
        {
            if (rdTenedorSC.Checked)
            {
                int idTenedoraSC = 0;

                int.TryParse(gridLookTenedoraSC.EditValue.ToString(), out idTenedoraSC);

                if (idTenedoraSC == 0)
                {
                    int.TryParse(gridLookTenedoraSC.OldEditValue.ToString(), out idTenedoraSC);
                }

                this.stpSelBancoAltaEmpleadosTableAdapter1.Fill(this.dbSAICBPOCatalogosDataSet.stpSelBancoAltaEmpleados, miSolicitud.idTenedoraSA, "SC", idTenedoraSC, false);
            }
        }

        private void CheckTodasLasSolicitudes_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckTodasLasSolicitudes.Checked)
            {
                txtSolicitud.Text = String.Empty;
                txtFechaSolicitud.Text = String.Empty;
                txtEstatus.Text = String.Empty;
                txtCliente.Text = String.Empty;
                CargarTodasLasSolicitudesDeAlta_Tesoreria();
            }
            else
            {
                MostrarDetalleSolicitud(miSolicitud);
                CargarInformacion();
            }
        }

        private void CargarTodasLasSolicitudesDeAlta_Tesoreria()
        {
            CargarInformacion();
        }
    }
}
