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
using System.IO;

namespace winAppSAIC.IMSS
{
    public partial class XtraMonitoreoDeAniversarios : DevExpress.XtraEditors.XtraForm
    {
        tools.dsc dsc = new tools.dsc();
        DataRow rowSolicitudSeleccionada;

        String stRutaAniversarios = String.Empty;
        String stRutaVariables = String.Empty;

        public XtraMonitoreoDeAniversarios()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAbrirCarpeta_Click(object sender, EventArgs e)
        {
            if (txtTipoSolicitud.Text == "ANIVERSARIO")
            {
                dsc.CheckandCreateFolder(stRutaAniversarios + idAniversarioHeader + @"\");
                Process.Start(stRutaAniversarios + idAniversarioHeader + @"\");
            }
            else if (txtTipoSolicitud.Text == "VARIABLES")
            {
                dsc.CheckandCreateFolder(stRutaVariables + idAniversarioHeader + @"\");
                Process.Start(stRutaVariables + idAniversarioHeader + @"\");
            }
        }

        private void XtraMonitoreoDeAniversarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbSAICBPOActualizacionesIMSSDataSet.stpSelObtenerSolicitudAniversariosVariables' Puede moverla o quitarla según sea necesario.
            this.stpSelObtenerSolicitudAniversariosVariablesTableAdapter.Fill(this.dbSAICBPOActualizacionesIMSSDataSet.stpSelObtenerSolicitudAniversariosVariables);
            // TODO: esta línea de código carga datos en la tabla 'dbSAICBPOActualizacionesIMSSDataSet.stpSelObtenerSolicitudAniversarios' Puede moverla o quitarla según sea necesario.
            //this.stpSelObtenerSolicitudAniversariosTableAdapter.Fill(this.dbSAICBPOActualizacionesIMSSDataSet.stpSelObtenerSolicitudAniversarios);
            gridLookSolicitudes.Properties.PopupFormWidth = 700;
            lblEstatus.Text = "0%";

            stRutaAniversarios = dsc.stRutaSAICIMSS + @"Aniversarios\";
            stRutaVariables = dsc.stRutaSAICIMSS + @"Variables\";

        }

        private void gridLookSolicitudes_EditValueChanged(object sender, EventArgs e)
        {
            rowSolicitudSeleccionada = gridLookUpEdit1View.GetDataRow(gridLookUpEdit1View.FocusedRowHandle);
            //DataRow unRow = 
            consultarSolicitud(rowSolicitudSeleccionada);
        }

        int idAniversarioHeader = 0;
        private void consultarSolicitud(DataRow unRow)
        {
            splashScreenManager2.ShowWaitForm();

            txtSeleccionados.Text = "0";

            idAniversarioHeader = 0;
            int.TryParse(unRow["idSolicitud"].ToString(), out idAniversarioHeader);

            txtUsuario.Text = unRow["NombreCompletoOperador"].ToString();
            txtTipoSolicitud.Text = unRow["Tipo Solicitud"].ToString();

            txtidSolicitud.Text = gridLookSolicitudes.EditValue.ToString();
            txtFechaCreacion.Text = unRow["Fecha Solicitud"].ToString();

            txtBimestre.Text = String.Empty;

            if (txtTipoSolicitud.Text == "ANIVERSARIO")
            {
                //int idSolicitudAniversarioHeader = 0;
                //int.TryParse(gridLookSolicitudes.EditValue.ToString(), out idSolicitudAniversarioHeader);

                gridControlVariables.Visible = false;
                gridControlVariables.Dock = DockStyle.None;

                gridControlAniversario.Dock = DockStyle.Fill;
                gridControlAniversario.Visible = true;

                stpSelObtenerSolicitudAniversariosDetailTableAdapter.Fill(dbSAICBPOActualizacionesIMSSDataSet.stpSelObtenerSolicitudAniversariosDetail, idAniversarioHeader);

                txtTotalEmpleados.Text = dbSAICBPOActualizacionesIMSSDataSet.stpSelObtenerSolicitudAniversariosDetail.Rows.Count.ToString();
                txtRegistrosPatronales.Text = (from r in dbSAICBPOActualizacionesIMSSDataSet.stpSelObtenerSolicitudAniversariosDetail.AsEnumerable()
                                               select r["RegistroPatronalIMSS"]).Distinct().ToList().Count.ToString();

                int iTotalAtendidos = (from x in dbSAICBPOActualizacionesIMSSDataSet.stpSelObtenerSolicitudAniversariosDetail.AsEnumerable()
                                       where x.Field<int>("idEstatus").Equals(17)
                                       select x).ToList().Count;

                int iTotalDeRegistros = (from x in dbSAICBPOActualizacionesIMSSDataSet.stpSelObtenerSolicitudAniversariosDetail.AsEnumerable()
                                         where !x.Field<int>("idEstatus").Equals(23)
                                         select x).ToList().Count;

                txtAtendidos.Text = iTotalAtendidos.ToString();

                txtCancelados.Text = (from x in dbSAICBPOActualizacionesIMSSDataSet.stpSelObtenerSolicitudAniversariosDetail.AsEnumerable()
                                      where x.Field<int>("idEstatus").Equals(23)
                                      select x).ToList().Count.ToString();

                pintarStatus(iTotalDeRegistros, iTotalAtendidos);

            }
            else if (txtTipoSolicitud.Text == "VARIABLES")
            {
                txtBimestre.Text = unRow["Bimestre"].ToString();
                gridControlAniversario.Dock = DockStyle.None;
                gridControlAniversario.Visible = false;

                gridControlVariables.Visible = true;
                gridControlVariables.Dock = DockStyle.Fill;

                stpSelObtenerSolicitudVariablesDetailTableAdapter.Fill(dbSAICBPOActualizacionesIMSSDataSet.stpSelObtenerSolicitudVariablesDetail, idAniversarioHeader);

                txtTotalEmpleados.Text = dbSAICBPOActualizacionesIMSSDataSet.stpSelObtenerSolicitudVariablesDetail.Rows.Count.ToString();
                txtRegistrosPatronales.Text = (from r in dbSAICBPOActualizacionesIMSSDataSet.stpSelObtenerSolicitudVariablesDetail.AsEnumerable()
                                               select r["RegistroPatronalIMSS"]).Distinct().ToList().Count.ToString();

                int iTotalAtendidos = (from x in dbSAICBPOActualizacionesIMSSDataSet.stpSelObtenerSolicitudVariablesDetail.AsEnumerable()
                                       where x.Field<int>("idEstatus").Equals(17)
                                       select x).ToList().Count;

                int iTotalDeRegistros = (from x in dbSAICBPOActualizacionesIMSSDataSet.stpSelObtenerSolicitudVariablesDetail.AsEnumerable()
                                         where !x.Field<int>("idEstatus").Equals(23)
                                         select x).ToList().Count;

                txtAtendidos.Text = iTotalAtendidos.ToString();

                txtCancelados.Text = (from x in dbSAICBPOActualizacionesIMSSDataSet.stpSelObtenerSolicitudVariablesDetail.AsEnumerable()
                                      where x.Field<int>("idEstatus").Equals(23)
                                      select x).ToList().Count.ToString();

                pintarStatus(iTotalDeRegistros, iTotalAtendidos);
            }

            stpSelObtenerSolicitudVariablesComplementoTableAdapter.Fill(dbSAICBPOActualizacionesIMSSDataSet.stpSelObtenerSolicitudVariablesComplemento, idAniversarioHeader);

            if (splashScreenManager2.IsSplashFormVisible) { splashScreenManager2.CloseWaitForm(); }

        }

        private void pintarStatus(double iTotalderegistros, double iTotalAtendidos)
        {
            double resultado = 0;
            if (iTotalderegistros != 0 && iTotalAtendidos != 0)
            {
                resultado = (iTotalAtendidos / iTotalderegistros) * 100;
            }

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

        private void btnLayOut_Click(object sender, EventArgs e)
        {
            if (txtTipoSolicitud.Text == "ANIVERSARIO")
            {
                if (gridViewAniversario.SelectedRowsCount > 0)
                {
                    DataTable dtEmpleadosLayOut = new DataTable();
                    dtEmpleadosLayOut = dsc.deGridViewSelectedToDataTable(gridViewAniversario);
                    generarLayOut(dtEmpleadosLayOut, "ANIVERSARIO");
                }
                else
                {
                    XtraMessageBox.Show("Seleccione un Empleado", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (txtTipoSolicitud.Text == "VARIABLES")
            {
                if (gridViewVariables.SelectedRowsCount > 0)
                {
                    DataTable dtEmpleadosLayOut = new DataTable();
                    dtEmpleadosLayOut = dsc.deGridViewSelectedToDataTable(gridViewVariables);
                    generarLayOut(dtEmpleadosLayOut, "VARIABLES");
                }
                else
                {
                    XtraMessageBox.Show("Seleccione un Empleado", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


        }

        private void btnAtender_Click(object sender, EventArgs e)
        {

            if (txtTipoSolicitud.Text == "ANIVERSARIO")
            {
                if (gridViewAniversario.SelectedRowsCount > 0)
                {
                    DialogResult oDialogResult = XtraMessageBox.Show("¿Esta seguro de atender a " + gridViewAniversario.SelectedRowsCount.ToString() + " empleado(s)?", "SAIC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (DialogResult.Yes == oDialogResult)
                    {
                        splashScreenManager2.ShowWaitForm();
                        DataTable dtEmpleadosLayOut = new DataTable();
                        dtEmpleadosLayOut = dsc.deGridViewSelectedToDataTable(gridViewAniversario);

                        foreach (DataRow item in dtEmpleadosLayOut.Rows)
                        {
                            int idEstatus = 0;
                            int.TryParse(item["idEstatus"].ToString(), out idEstatus);
                            int idAniverdarioDetail = 0;
                            int.TryParse(item["idSolicitudAniversarioDetail"].ToString(), out idAniverdarioDetail);

                            if (idEstatus != 17 && idEstatus != 23)
                            {
                                actualizacionesIMSSTableAdapter1.stpUpdSolicitudAniversarioAtenderCancelar(idAniverdarioDetail, 17, OperadorBD.OperadorGlobal.IdOperador, txtTipoSolicitud.Text);
                            }
                        }

                        if (splashScreenManager2.IsSplashFormVisible) { splashScreenManager2.CloseWaitForm(); }
                        consultarSolicitud(rowSolicitudSeleccionada);
                    }
                }
                else
                {
                    XtraMessageBox.Show("Seleccione un Empleado", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (txtTipoSolicitud.Text == "VARIABLES")
            {
                if (gridViewVariables.SelectedRowsCount > 0)
                {
                    DialogResult oDialogResult = XtraMessageBox.Show("¿Esta seguro de atender a " + gridViewVariables.SelectedRowsCount.ToString() + " empleado(s)?", "SAIC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (DialogResult.Yes == oDialogResult)
                    {
                        splashScreenManager2.ShowWaitForm();
                        DataTable dtEmpleadosLayOut = new DataTable();
                        dtEmpleadosLayOut = dsc.deGridViewSelectedToDataTable(gridViewVariables);

                        foreach (DataRow item in dtEmpleadosLayOut.Rows)
                        {
                            int idEstatus = 0;
                            int.TryParse(item["idEstatus"].ToString(), out idEstatus);
                            if (idEstatus != 17 && idEstatus != 23)
                            {
                                int idAniverdarioDetail = 0;
                                int.TryParse(item["idVariablesIMSSDetail"].ToString(), out idAniverdarioDetail);
                                actualizacionesIMSSTableAdapter1.stpUpdSolicitudAniversarioAtenderCancelar(idAniverdarioDetail, 17, OperadorBD.OperadorGlobal.IdOperador, txtTipoSolicitud.Text);
                            }
                        }

                        if (splashScreenManager2.IsSplashFormVisible) { splashScreenManager2.CloseWaitForm(); }
                        consultarSolicitud(rowSolicitudSeleccionada);
                    }
                }
                else
                {
                    XtraMessageBox.Show("Seleccione un Empleado", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (txtTipoSolicitud.Text == "ANIVERSARIO")
            {
                if (gridViewAniversario.SelectedRowsCount > 0)
                {

                    //DialogResult oDialogResult = XtraMessageBox.Show("¿Desea Eliminar los empleados seleccionados?", "SAIC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    splashScreenManager2.ShowWaitForm();
                    DataTable dtEmpleadosLayOut = new DataTable();
                    dtEmpleadosLayOut = dsc.deGridViewSelectedToDataTable(gridViewAniversario);

                    foreach (DataRow item in dtEmpleadosLayOut.Rows)
                    {
                        int idAniverdarioDetail = 0;
                        int idEstatus = 0;

                        int.TryParse(item["idSolicitudAniversarioDetail"].ToString(), out idAniverdarioDetail);
                        int.TryParse(item["idEstatus"].ToString(), out idEstatus);

                        if (idEstatus != 17 && idEstatus != 23)
                        {
                            actualizacionesIMSSTableAdapter1.stpUpdSolicitudAniversarioAtenderCancelar(idAniverdarioDetail, 23, OperadorBD.OperadorGlobal.IdOperador, txtTipoSolicitud.Text);
                        }
                    }

                    if (splashScreenManager2.IsSplashFormVisible) { splashScreenManager2.CloseWaitForm(); }
                    consultarSolicitud(rowSolicitudSeleccionada);
                }
                else
                {
                    XtraMessageBox.Show("Seleccione un Empleado", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (txtTipoSolicitud.Text == "VARIABLES")
            {
                if (gridViewVariables.SelectedRowsCount > 0)
                {
                    splashScreenManager2.ShowWaitForm();
                    DataTable dtEmpleadosLayOut = new DataTable();
                    dtEmpleadosLayOut = dsc.deGridViewSelectedToDataTable(gridViewVariables);

                    foreach (DataRow item in dtEmpleadosLayOut.Rows)
                    {
                        int idEstatus = 0;
                        int.TryParse(item["idEstatus"].ToString(), out idEstatus);

                        int idAniverdarioDetail = 0;
                        int.TryParse(item["idVariablesIMSSDetail"].ToString(), out idAniverdarioDetail);

                        if (idEstatus != 17 && idEstatus != 23)
                        {
                            actualizacionesIMSSTableAdapter1.stpUpdSolicitudAniversarioAtenderCancelar(idAniverdarioDetail, 23, OperadorBD.OperadorGlobal.IdOperador, txtTipoSolicitud.Text);
                        }
                    }

                    if (splashScreenManager2.IsSplashFormVisible) { splashScreenManager2.CloseWaitForm(); }
                    consultarSolicitud(rowSolicitudSeleccionada);
                }
                else
                {
                    XtraMessageBox.Show("Seleccione un Empleado", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void btnDescargarExcel_Click(object sender, EventArgs e)
        {

            String stRutaDocumento = String.Empty;

            if (txtTipoSolicitud.Text == "ANIVERSARIO")
            {
                stRutaDocumento = stRutaAniversarios + "Solicitud de Aniversarios " + gridLookSolicitudes.EditValue.ToString() + " " + dsc.nombreAleatorio() + ".xlsx";
                gridControlAniversario.ExportToXlsx(stRutaDocumento);
                XtraMessageBox.Show("Archivo descardo en la ruta: " + stRutaDocumento, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtTipoSolicitud.Text == "VARIABLES")
            {
                stRutaDocumento = stRutaVariables + "Solicitud de Variables " + gridLookSolicitudes.EditValue.ToString() + " " + dsc.nombreAleatorio() + ".xlsx";
                gridControlVariables.ExportToXlsx(stRutaDocumento);
                XtraMessageBox.Show("Archivo descardo en la ruta: " + stRutaDocumento, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void generarLayOut(DataTable dtEmpleadosAniversario, String stTipoSolicitud)
        {

            splashScreenManager2.ShowWaitForm();
            int idSolicitud = 0;
            int.TryParse(gridLookSolicitudes.EditValue.ToString(), out idSolicitud);

            var result = (from r in dtEmpleadosAniversario.AsEnumerable()
                          select r["RegistroPatronalIMSS"]).Distinct().ToList();

            List<String> sRegistrosPatronales = result.Select(s => (String)s).ToList();

            foreach (String sRegistroPatronal in sRegistrosPatronales)
            {
                String stRutalayOut = String.Empty;

                DataTable dtEmpleadosRegistroPatronal = (from x in dtEmpleadosAniversario.AsEnumerable()
                                                         where x.Field<String>("RegistroPatronalIMSS").Equals(sRegistroPatronal)
                                                         select x).CopyToDataTable();

                String stNombre = String.Empty;

                if (stTipoSolicitud == "ANIVERSARIO")
                {
                    dsc.CheckandCreateFolder(stRutaAniversarios + idAniversarioHeader + @"\");
                    stNombre = stRutaAniversarios + idAniversarioHeader + @"\" + "S" + idSolicitud + " Aniversario RP_" + sRegistroPatronal + " " + dsc.nombreAleatorio() + ".txt";
                }
                else if (stTipoSolicitud == "VARIABLES")
                {
                    dsc.CheckandCreateFolder(stRutaVariables + idAniversarioHeader + @"\");
                    stNombre = stRutaVariables + idAniversarioHeader + @"\" + "S" + idSolicitud + " Variables RP_" + sRegistroPatronal + " " + dsc.nombreAleatorio() + ".txt";
                }

                if (cBoxPorCliente.Checked)
                {
                    var rClientes = (from r in dtEmpleadosRegistroPatronal.AsEnumerable()
                                     select r["Cliente"]).Distinct().ToList();

                    List<String> lstClientes = rClientes.Select(s => (String)s).ToList();

                    foreach (String sClientes in lstClientes)
                    {
                        List<String> stResultado = new List<String>();

                        DataTable dtEmpleadosRegistroPatronalClientes = (from x in dtEmpleadosRegistroPatronal.AsEnumerable()
                                                                         where x.Field<String>("Cliente").Equals(sClientes)
                                                                         select x).CopyToDataTable();

                        if (stTipoSolicitud == "ANIVERSARIO")
                        {
                            dsc.CheckandCreateFolder(stRutaAniversarios + idAniversarioHeader + @"\");
                            stNombre = stRutaAniversarios + idAniversarioHeader + @"\" + "S" + idSolicitud + " Aniversario RP_" + sRegistroPatronal + " C_" + sClientes + " " + dsc.nombreAleatorio() + ".txt";
                        }
                        else if (stTipoSolicitud == "VARIABLES")
                        {
                            dsc.CheckandCreateFolder(stRutaVariables + idAniversarioHeader + @"\");
                            stNombre = stRutaVariables + idAniversarioHeader + @"\" + "S" + idSolicitud + " Variables RP_" + sRegistroPatronal + " C_" + sClientes + " " + dsc.nombreAleatorio() + ".txt";
                        }

                        foreach (DataRow itemEmpleado in dtEmpleadosRegistroPatronalClientes.Rows)
                        {
                            int idEmpleado = 0;
                            int.TryParse(itemEmpleado["idEmpleado"].ToString(), out idEmpleado);
                            stpSelSalarioEmpleadoLayOutIMSSTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelSalarioEmpleadoLayOutIMSS, idEmpleado, idSolicitud, stTipoSolicitud);

                            if (dbSAICBPOCatalogosDataSet1.stpSelSalarioEmpleadoLayOutIMSS.Rows.Count > 0)
                            {
                                stResultado.Add(dbSAICBPOCatalogosDataSet1.stpSelSalarioEmpleadoLayOutIMSS.Rows[0]["LayOUtSalariosIMSS"].ToString());
                            }
                        }

                        File.WriteAllLines(stNombre, stResultado);
                    }
                }
                else
                {
                    List<String> stResultado = new List<String>();
                    foreach (DataRow item in dtEmpleadosRegistroPatronal.Rows)
                    {
                        int idEmpleado = 0;

                        int.TryParse(item["idEmpleado"].ToString(), out idEmpleado);

                        stpSelSalarioEmpleadoLayOutIMSSTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelSalarioEmpleadoLayOutIMSS, idEmpleado, idSolicitud, stTipoSolicitud);

                        if (dbSAICBPOCatalogosDataSet1.stpSelSalarioEmpleadoLayOutIMSS.Rows.Count > 0)
                        {
                            stResultado.Add(dbSAICBPOCatalogosDataSet1.stpSelSalarioEmpleadoLayOutIMSS.Rows[0]["LayOUtSalariosIMSS"].ToString());
                        }
                    }

                    File.WriteAllLines(stNombre, stResultado);
                }
            }

            if (splashScreenManager2.IsSplashFormVisible) { splashScreenManager2.CloseWaitForm(); }

            XtraMessageBox.Show("Layouts generados con exito.", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gridViewAniversario_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {

        }

        private void gridViewAniversario_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                if (e.RowHandle >= 0)
                {
                    gridViewAniversario.OptionsSelection.EnableAppearanceFocusedRow = false;

                    if (gridViewAniversario.GetDataRow(e.RowHandle)["idEstatus"].ToString() == "23")
                    {
                        e.Appearance.BackColor = Color.LightCoral;
                        e.Appearance.BackColor2 = Color.White;
                        e.HighPriority = true;
                    }
                    else if (gridViewAniversario.GetDataRow(e.RowHandle)["idEstatus"].ToString() == "17")
                    {
                        e.Appearance.BackColor = Color.LightGreen;
                        e.Appearance.BackColor2 = Color.White;
                        e.HighPriority = true;
                    }
                }
            }
            catch (Exception) { }
        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int tipoSolicitud = 0;

            if (txtTipoSolicitud.Text == "ANIVERSARIO")
            {
                tipoSolicitud = 5;
            }
            else if (txtTipoSolicitud.Text == "VARIABLES")
            {
                tipoSolicitud = 6;
            }

            int idSolicitud = 0;
            int.TryParse(gridLookSolicitudes.EditValue.ToString(), out idSolicitud);
            OperadoresM.XtraSolicitudesSalarioAreas oXtraSolicitudesSalarioAreas = new OperadoresM.XtraSolicitudesSalarioAreas(String.Empty, 0);
            oXtraSolicitudesSalarioAreas.cargarAfiles(idSolicitud, tipoSolicitud);
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int tipoSolicitud = 0;

            if (txtTipoSolicitud.Text == "ANIVERSARIO")
            {
                tipoSolicitud = 5;
            }
            else if (txtTipoSolicitud.Text == "VARIABLES")
            {
                tipoSolicitud = 6;
            }

            int idSolicitud = 0;
            int.TryParse(gridLookSolicitudes.EditValue.ToString(), out idSolicitud);

            OperadoresM.XtraSolicitudesSalarioAreas oXtraSolicitudesSalarioAreas = new OperadoresM.XtraSolicitudesSalarioAreas(String.Empty, 0);
            oXtraSolicitudesSalarioAreas.EliminarAfils(idSolicitud, tipoSolicitud);
        }

        private void descargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            splashScreenManager2.ShowWaitForm();


            int tipoSolicitud = 0;
            String stRuta = String.Empty;
            if (txtTipoSolicitud.Text == "ANIVERSARIO")
            {
                tipoSolicitud = 5;

                dsc.CheckandCreateFolder(stRutaAniversarios);
                stRuta = stRutaAniversarios;

            }
            else if (txtTipoSolicitud.Text == "VARIABLES")
            {
                tipoSolicitud = 6;
                dsc.CheckandCreateFolder(stRutaVariables);
                stRuta = stRutaVariables;
            }

            int idSolicitud = 0;
            int.TryParse(gridLookSolicitudes.EditValue.ToString(), out idSolicitud);

            OperadoresM.XtraMonitoreoSolicitudesOperaciones objMonitoreo = new OperadoresM.XtraMonitoreoSolicitudesOperaciones(0);
            int iConta = objMonitoreo.DescargsarFiel(idSolicitud, stRuta, tipoSolicitud);

            if (splashScreenManager2.IsSplashFormVisible) { splashScreenManager2.CloseWaitForm(); }

            if (iConta > 0)
            {
                XtraMessageBox.Show("Afil's descargados con exito. Ruta: " + stRuta, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Solicitud sin Afil's", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void gridViewAniversario_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            txtSeleccionados.Text = gridViewAniversario.SelectedRowsCount.ToString();
        }

        private void gridViewVariables_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                if (e.RowHandle >= 0)
                {
                    gridViewVariables.OptionsSelection.EnableAppearanceFocusedRow = false;

                    if (gridViewVariables.GetDataRow(e.RowHandle)["idEstatus"].ToString() == "23")
                    {
                        e.Appearance.BackColor = Color.LightCoral;
                        e.Appearance.BackColor2 = Color.White;
                        e.HighPriority = true;
                    }
                    else if (gridViewVariables.GetDataRow(e.RowHandle)["idEstatus"].ToString() == "17")
                    {
                        e.Appearance.BackColor = Color.LightGreen;
                        e.Appearance.BackColor2 = Color.White;
                        e.HighPriority = true;
                    }
                }
            }
            catch (Exception) { }
        }

        private void gridViewVariables_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            txtSeleccionados.Text = gridViewAniversario.SelectedRowsCount.ToString();
        }
    }
}