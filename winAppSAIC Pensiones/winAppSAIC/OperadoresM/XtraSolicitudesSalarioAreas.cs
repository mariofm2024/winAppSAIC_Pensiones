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

namespace winAppSAIC.OperadoresM
{
    public partial class XtraSolicitudesSalarioAreas : DevExpress.XtraEditors.XtraForm
    {
        String stArea = String.Empty;
        int iArea = 0;
        int idSolicitud = 0;
        Solicitud oSolicitud = new Solicitud();
        tools.dsc dsc = new tools.dsc();
        String stRutaSolicitud = String.Empty;
        String stColumnaEstatusArea = String.Empty;
        String stColumnaMotivoRechazoArea = String.Empty;
        OperadoresM.ColorSolicitud miColorSolicitud;
        DateTime dFechaHoy = new DateTime();

        public XtraSolicitudesSalarioAreas(String stArea, int idSolicitud)
        {
            InitializeComponent();
            this.stArea = stArea;
            this.idSolicitud = idSolicitud;

            if (stArea == "JURIDICO")
            {
                //stColumnaEstatusArea = "Estatus Juridico";
                //stColumnaMotivoRechazoArea = "MotivoRechazoJuridico";
                //iArea = 4;
                iArea = 4;
                stColumnaEstatusArea = "EstatusIMSS";
                stColumnaMotivoRechazoArea = "MotivoRechazoIMSS";

            }
            else if (stArea == "IMSS")
            {
                iArea = 1;
                stColumnaEstatusArea = "EstatusIMSS";
                stColumnaMotivoRechazoArea = "MotivoRechazoIMSS";
            }
        }

        private void XtraSolicitudesSalarioAreas_Load(object sender, EventArgs e)
        {
            dFechaHoy = ObtenerFechaServidor();
            this.Text = stArea + " - Solicitud de Salario " + idSolicitud;
            oSolicitud = ObtenerDetalleSolicitud(idSolicitud);
            miColorSolicitud = new ColorSolicitud();
            miColorSolicitud = miColorSolicitud.obtenerColor();
            visualizarInformacion();
        }

        private Solicitud ObtenerDetalleSolicitud(int idSolicitud)
        {
            Solicitud oSolicitud = new Solicitud();
            oSolicitud = oSolicitud.ObtenerSolcitud(idSolicitud, iArea);
            stRutaSolicitud = oSolicitud.sRutaSolicitud + oSolicitud.idSolicitud + @"\";
            return oSolicitud;
        }

        private void visualizarInformacion()
        {
            splashScreenManager3.ShowWaitForm();

            txtbxSolicitud.Text = oSolicitud.idSolicitud.ToString();
            txtbxfechaAlta.Text = oSolicitud.FechaCreacion.ToShortDateString();
            txtEstatus.Text = oSolicitud.EstatusSolicitud;
            txtTipoSolicitud.Text = oSolicitud.DescTipoSolicitud;
            txtbxOperador.Text = oSolicitud.NombreOperador;

            if (stArea == "IMSS")
            {
                btnGenerarLayOut.Visible = true;
                toolStripDropDownButtonAfils.Visible = true;
            }
            else
            {
                btnGenerarLayOut.Visible = false;
                toolStripDropDownButtonAfils.Visible = true;
                toolStripDropDownButtonAfils.Enabled = true;
                descargarToolStripMenuItem.Enabled = true;

                cargarAfilsToolStripMenuItem.Visible = false;
                elimnarAfilsToolStripMenuItem.Visible = false;
                cBoxPorCliente.Visible = false;
            }

            stpSelInfoDetalleSolicitudSalariosTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelInfoDetalleSolicitudSalarios, idSolicitud);

            if (dbSAICBPOCatalogosDataSet1.stpSelInfoDetalleSolicitudSalarios.Rows.Count > 0)
            {
                txtEmpleados.Text = dbSAICBPOCatalogosDataSet1.stpSelInfoDetalleSolicitudSalarios.Rows.Count.ToString();

                txtAtendidos.Text = (from x in dbSAICBPOCatalogosDataSet1.stpSelInfoDetalleSolicitudSalarios.AsEnumerable()
                                     where x.Field<String>(stColumnaEstatusArea).Equals("SOLICITUD ATENDIDA AL 100 %")
                                     select x).ToList().Count.ToString();

                txtRechazados.Text = (from x in dbSAICBPOCatalogosDataSet1.stpSelInfoDetalleSolicitudSalarios.AsEnumerable()
                                      where x.Field<String>(stColumnaEstatusArea).Equals("SOLICITUD RECHAZADA")
                                      select x).ToList().Count.ToString();

                txtSeleccionados.Text = gridViewSalariosEmpleados.SelectedRowsCount.ToString();

                btnAbrirCarpeta.Enabled = true;
                btnExportar.Enabled = true;
            }

            if (splashScreenManager3.IsSplashFormVisible) { splashScreenManager3.CloseWaitForm(); }
        }

        // Atender
        private void repositoryItemButtonEditAtender_Click(object sender, EventArgs e)
        {
            DataRow unRow = gridViewSalariosEmpleados.GetDataRow(gridViewSalariosEmpleados.FocusedRowHandle);
            if (unRow[stColumnaEstatusArea].ToString() == "SOLICITUD ATENDIDA AL 100%")
            {
                XtraMessageBox.Show("Solicitud Atendida", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (unRow[stColumnaEstatusArea].ToString() == "SOLICITUD RECHAZADA")
            {
                XtraMessageBox.Show("Solicitud Rechazada, No se puede Atender.", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {


                if (stArea == "IMSS")
                {
                    DialogResult oDialogResult = XtraMessageBox.Show("¿Esta seguro de atender al empleado " + unRow["NombreEmpleadoCompleto"].ToString() + "?", "SAIC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (DialogResult.Yes == oDialogResult)
                    {
                        int idEmpleado = 0;
                        int.TryParse(unRow["idEmpleado"].ToString(), out idEmpleado);
                        queriesTableAdapter1.stpUpdEstatusSolicitudAlta(iArea,
                                                         oSolicitud.idSolicitud,
                                                         idEmpleado,
                                                          OperadorBD.OperadorGlobal.NombreOperador,
                                                          OperadorBD.OperadorGlobal.NombreUsuario,
                                                           DateTime.Now
                                                         );
                    }
                }

                visualizarInformacion();
            }
        }

        //rechazar
        private void repositoryItemButtonEditRechazar_Click(object sender, EventArgs e)
        {
            DataRow unRow = gridViewSalariosEmpleados.GetDataRow(gridViewSalariosEmpleados.FocusedRowHandle);

            if (unRow[stColumnaEstatusArea].ToString() == "SOLICITUD ATENDIDA AL 100%")
            {
                XtraMessageBox.Show("Solicitud Atendida, No se puede rechazar.", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (unRow[stColumnaEstatusArea].ToString() == "SOLICITUD RECHAZADA")
            {
                XtraMessageBox.Show("Solicitud Rechazada, No se puede rechazar.", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (stArea == "IMSS")
                {
                    int idEmpleado = 0;
                    int.TryParse(unRow["idEmpleado"].ToString(), out idEmpleado);
                    String SnombreEmpleado = unRow["NombreEmpleadoCompleto"].ToString();
                    String sRechazo = unRow[stColumnaMotivoRechazoArea].ToString();
                    OperadoresM.XtraRechazoSolicitud oXtraRechazoSolicitud = new XtraRechazoSolicitud(dsc.deGridViewaDataTable(gridViewSalariosEmpleados), oSolicitud.idSolicitud, idEmpleado, stArea, SnombreEmpleado, sRechazo);
                    oXtraRechazoSolicitud.ShowDialog();
                }

                visualizarInformacion();
            }
        }
        //Editar
        private void repositoryItemButtonEditEditar_Click(object sender, EventArgs e)
        {
            DataRow unRow = gridViewSalariosEmpleados.GetDataRow(gridViewSalariosEmpleados.FocusedRowHandle);

            if (unRow[stColumnaEstatusArea].ToString() == "SOLICITUD ATENDIDA AL 100%")
            {
                XtraMessageBox.Show("Solicitud Atendida, No se puede rechazar.", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (unRow[stColumnaEstatusArea].ToString() == "SOLICITUD RECHAZADA")
            {
                XtraMessageBox.Show("Solicitud Rechazada, No se puede rechazar.", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                if (stArea == "IMSS")
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
                        oSolicitud.idSolicitud,
                        oEmpleado,
                        dcSD,
                        dcParteVariable,
                        dtFechaDeAplicacion);

                    oXtrasSolicitudSalariosEmpleado.ShowDialog();
                }

                visualizarInformacion();
            }
        }

        private void gridViewSalariosEmpleados_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                if (e.RowHandle >= 0)
                {
                    gridViewSalariosEmpleados.OptionsSelection.EnableAppearanceFocusedRow = false;

                    if (gridViewSalariosEmpleados.GetDataRow(e.RowHandle)["idEstatus"].ToString() == "23")
                    {
                        e.Appearance.BackColor = Color.FromArgb(miColorSolicitud.idColorInactivo[0], miColorSolicitud.idColorInactivo[1], miColorSolicitud.idColorInactivo[2]);
                        e.HighPriority = true;
                    }
                    else
                    {
                        if (gridViewSalariosEmpleados.GetDataRow(e.RowHandle)[stColumnaEstatusArea].ToString() == "SOLICITUD ATENDIDA AL 100%")
                        {
                            e.Appearance.BackColor = Color.FromArgb(miColorSolicitud.idColorAtendida[0], miColorSolicitud.idColorAtendida[1], miColorSolicitud.idColorAtendida[2]);
                            e.HighPriority = true;
                        }
                        else if (gridViewSalariosEmpleados.GetDataRow(e.RowHandle)[stColumnaEstatusArea].ToString() == "SOLICITUD RECHAZADA")
                        {
                            e.Appearance.BackColor = Color.FromArgb(miColorSolicitud.idColorRechazada[0], miColorSolicitud.idColorRechazada[1], miColorSolicitud.idColorRechazada[2]);
                            e.HighPriority = true;
                        }
                        else
                        {

                            DateTime dtFechaAplicacion = new DateTime();
                            DateTime.TryParse(gridViewSalariosEmpleados.GetDataRow(e.RowHandle)["FechaAplicacion"].ToString(), out dtFechaAplicacion);

                            if (dtFechaAplicacion.Date == dFechaHoy.Date)
                            {
                                e.Appearance.BackColor = Color.Khaki;
                                e.Appearance.BackColor2 = Color.White;
                                e.HighPriority = true;
                            }
                            else if (dtFechaAplicacion.Date < dFechaHoy.Date)
                            {
                                e.Appearance.BackColor = Color.LightCoral;
                                e.Appearance.BackColor2 = Color.White;
                                e.HighPriority = true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { }
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

        private void gridViewSalariosEmpleados_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            txtSeleccionados.Text = gridViewSalariosEmpleados.SelectedRowsCount.ToString();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            String stNombreArchivo = String.Empty;
            stNombreArchivo = stRutaSolicitud + "Solicitud de Salarios " + oSolicitud.idSolicitud + " " + dsc.nombreAleatorio() + ".xls";
            gridViewSalariosEmpleados.ExportToXls(stNombreArchivo);
        }

        private void btnAbrirCarpeta_Click(object sender, EventArgs e)
        {
            dsc.CheckandCreateFolder(stRutaSolicitud);
            Process.Start(stRutaSolicitud);
        }

        private void btnGenerarLayOut_Click(object sender, EventArgs e)
        {
            if (gridViewSalariosEmpleados.SelectedRowsCount > 0)
            {
                dsc.CheckandCreateFolder(stRutaSolicitud);
                DataTable dtEmpleadosSeleccionados = dsc.deGridViewSelectedToDataTable(gridViewSalariosEmpleados);

                //DataTable dt = dtEmpleadosSeleccionados.DefaultView.ToTable(true, "Registro Patronal");
                var result = (from r in dtEmpleadosSeleccionados.AsEnumerable()
                              select r["Registro Patronal"]).Distinct().ToList();

                List<String> sRegistrosPatronales = result.Select(s => (String)s).ToList();

                foreach (String sRegistroPatronal in sRegistrosPatronales)
                {

                    DataTable dtEmpleadosRegistroPatronal = (from x in dtEmpleadosSeleccionados.AsEnumerable()
                                                             where x.Field<String>("Registro Patronal").Equals(sRegistroPatronal)
                                                             select x).CopyToDataTable();

                    if (cBoxPorCliente.Checked) // Por registro patronal y por cliente
                    {

                        var rClientes = (from r in dtEmpleadosRegistroPatronal.AsEnumerable()
                                         select r["Cliente Nombre Comercial"]).Distinct().ToList();

                        List<String> lstClientes = rClientes.Select(s => (String)s).ToList();

                        foreach (String sClientes in lstClientes)
                        {
                            List<String> stResultado = new List<String>();
                            String stNombre = stRutaSolicitud + "IMSS_LayOut RP_" + sRegistroPatronal + " C_" + sClientes + " " + dsc.nombreAleatorio() + ".txt";

                            DataTable dtEmpleadosRegistroPatronalClientes = (from x in dtEmpleadosRegistroPatronal.AsEnumerable()
                                                                             where x.Field<String>("Cliente Nombre Comercial").Equals(sClientes)
                                                                             select x).CopyToDataTable();

                            foreach (DataRow itemEmpleado in dtEmpleadosRegistroPatronalClientes.Rows)
                            {
                                int idEmpleado = 0;
                                int.TryParse(itemEmpleado["idEmpleado"].ToString(), out idEmpleado);
                                stpSelSalarioEmpleadoLayOutIMSSTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelSalarioEmpleadoLayOutIMSS, idEmpleado, oSolicitud.idSolicitud, "SALARIO");

                                if (dbSAICBPOCatalogosDataSet1.stpSelSalarioEmpleadoLayOutIMSS.Rows.Count > 0)
                                {
                                    stResultado.Add(dbSAICBPOCatalogosDataSet1.stpSelSalarioEmpleadoLayOutIMSS.Rows[0]["LayOUtSalariosIMSS"].ToString());
                                }
                            }

                            File.WriteAllLines(stNombre, stResultado);
                        }

                    }
                    else // Solo por Registro Patronal
                    {
                        List<String> stResultado = new List<String>();
                        String stNombre = stRutaSolicitud + "IMSS_LayOut RP_" + sRegistroPatronal + " " + dsc.nombreAleatorio() + ".txt";

                        foreach (DataRow itemEmpleado in dtEmpleadosRegistroPatronal.Rows)
                        {
                            int idEmpleado = 0;
                            int.TryParse(itemEmpleado["idEmpleado"].ToString(), out idEmpleado);
                            stpSelSalarioEmpleadoLayOutIMSSTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelSalarioEmpleadoLayOutIMSS, idEmpleado, oSolicitud.idSolicitud, "SALARIO");

                            if (dbSAICBPOCatalogosDataSet1.stpSelSalarioEmpleadoLayOutIMSS.Rows.Count > 0)
                            {
                                stResultado.Add(dbSAICBPOCatalogosDataSet1.stpSelSalarioEmpleadoLayOutIMSS.Rows[0]["LayOUtSalariosIMSS"].ToString());
                            }
                        }

                        File.WriteAllLines(stNombre, stResultado);
                    }

                }

                XtraMessageBox.Show("LayOut Generado con Exito" + Environment.NewLine +
                    "Ruta: " + stRutaSolicitud, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void btnEstatusSolicitud_Click(object sender, EventArgs e)
        {
            if (gridViewSalariosEmpleados.SelectedRowsCount > 0)
            {
                if (stArea == "IMSS")
                {

                    DialogResult oDialogResult = XtraMessageBox.Show("¿Esta seguro de atender " + gridViewSalariosEmpleados.SelectedRowsCount + "?", "SAIC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (DialogResult.Yes == oDialogResult)
                    {
                        DataTable dtEmpleadosSeleccionados = dsc.deGridViewSelectedToDataTable(gridViewSalariosEmpleados);

                        splashScreenManager3.ShowWaitForm();
                        splashScreenManager3.SetWaitFormCaption("Atendiendo");
                        int iConta = 0;
                        foreach (DataRow unRow in dtEmpleadosSeleccionados.Rows)
                        {
                            iConta++;
                            splashScreenManager3.SetWaitFormDescription(iConta + " de " + dtEmpleadosSeleccionados.Rows.Count);
                            int idEmpleado = 0;
                            int.TryParse(unRow["idEmpleado"].ToString(), out idEmpleado);

                            queriesTableAdapter1.stpUpdEstatusSolicitudAlta(iArea,
                                                             oSolicitud.idSolicitud,
                                                             idEmpleado,
                                                              OperadorBD.OperadorGlobal.NombreOperador,
                                                              OperadorBD.OperadorGlobal.NombreUsuario,
                                                               DateTime.Now
                                                             );
                        }

                        if (splashScreenManager3.IsSplashFormVisible) { splashScreenManager3.CloseWaitForm(); }
                    }

                    visualizarInformacion();
                }
            }
        }

        private void cargarAfilsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cargarAfiles(oSolicitud.idSolicitud, 4);
        }

        public void cargarAfiles(int idSolicitud, int idTipoSolicitud)
        {
            try
            {
                String stRutaContrato = String.Empty;
                String stValorDocumento = String.Empty;

                XtraMessageBox.Show("Seleccione el Archivo Afil de la Solicitud"
               , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);

                OpenFileDialog ofdSelecFile = new OpenFileDialog();
                ofdSelecFile.Filter = "Pdf Files| *.pdf";
                ofdSelecFile.Title = "SAIC | Seleccione Afil";
                ofdSelecFile.Multiselect = false;
                ofdSelecFile.ShowDialog();

                stRutaContrato = ofdSelecFile.FileName;

                if (!String.IsNullOrEmpty(stRutaContrato))
                {
                    splashScreenManager3.ShowWaitForm();
                    splashScreenManager3.SetWaitFormCaption("Cargando AFIL");

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
                                queriesTableAdapter1.stpInsDocumentoIMSS_1(idSolicitud,
                                                        miArchivo.Name,
                                                        miArchivo.Extension,
                                                        stValorDocumento,
                                                       OperadorBD.OperadorGlobal.NombreUsuario
                                                       , idTipoSolicitud
                                                       );

                                if (splashScreenManager3.IsSplashFormVisible) { splashScreenManager3.CloseWaitForm(); }

                                XtraMessageBox.Show("Archivo " + miArchivo.Name + ", guardado con Exito"
                                   , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            else
                            {
                                if (splashScreenManager3.IsSplashFormVisible) { splashScreenManager3.CloseWaitForm(); }
                                XtraMessageBox.Show("El Archivo no debe exceder de " + dbSAICBPOValidacionDataSet1.stpSelParametro.Rows[0]["ValorParametro"].ToString() + " KB"
                                 , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            if (splashScreenManager3.IsSplashFormVisible) { splashScreenManager3.CloseWaitForm(); }
                            DialogResult resultado = XtraMessageBox.Show("No se tiene valor de limite para archivos."
                             , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        if (splashScreenManager3.IsSplashFormVisible) { splashScreenManager3.CloseWaitForm(); }
                        XtraMessageBox.Show("No se puede convertir el Archivo para Subir."
                        , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                if (splashScreenManager3.IsSplashFormVisible) { splashScreenManager3.CloseWaitForm(); }
                XtraMessageBox.Show("No se puede guardar en el archivo." + Environment.NewLine + ex.Message
                                , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void elimnarAfilsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarAfils(oSolicitud.idSolicitud, oSolicitud.idTipoSolicitud);
        }

        public void EliminarAfils(int idSolicitud, int idTipoSolicitud)
        {
            DialogResult resultado = XtraMessageBox.Show("¿Desea eliminar los Documentos Afil de la Solicitud?"
                    , "SAIC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            splashScreenManager3.ShowWaitForm();
            try
            {
                if (DialogResult.Yes == resultado)
                {
                    queriesTableAdapter1.stpUpdDocumentoIMSS_1(idSolicitud, OperadorBD.OperadorGlobal.NombreUsuario, idTipoSolicitud);
                    if (splashScreenManager3.IsSplashFormVisible) { splashScreenManager3.CloseWaitForm(); }
                    XtraMessageBox.Show("Documentos Eliminados", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                if (splashScreenManager3.IsSplashFormVisible) { splashScreenManager3.CloseWaitForm(); }
                XtraMessageBox.Show("No se puede eliminar los documentos" + Environment.NewLine + ex.Message, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (splashScreenManager3.IsSplashFormVisible) { splashScreenManager3.CloseWaitForm(); }
        }





        private void descargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            splashScreenManager3.ShowWaitForm();
            splashScreenManager3.SetWaitFormCaption("Descargando Afil");
            splashScreenManager3.SetWaitFormDescription("Espere Por favor...");

            try
            {
                OperadoresM.XtraMonitoreoSolicitudesOperaciones objMonitoreo = new OperadoresM.XtraMonitoreoSolicitudesOperaciones(0);
                String stRuta = oSolicitud.sRutaSolicitud + oSolicitud.idSolicitud + @"\";
                int iConta = objMonitoreo.DescargsarFiel(oSolicitud.idSolicitud, stRuta, oSolicitud.idTipoSolicitud);
                splashScreenManager3.CloseWaitForm();
                XtraMessageBox.Show("Documentos Afil Descargados: " + iConta
                   , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                splashScreenManager3.CloseWaitForm();
                XtraMessageBox.Show("Error al descargar Documentos." + Environment.NewLine + ex.Message
                   , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gridViewSalariosEmpleados_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {

        }
    }
}