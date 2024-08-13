using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using winAppSAIC.OperadoresM;
using System.Diagnostics;
using System.IO;
using compCatalogosSAIC;

namespace winAppSAIC.IMSS
{
    public partial class XtraAfils : DevExpress.XtraEditors.XtraForm
    {
        tools.dsc dsc = new tools.dsc();
        public XtraAfils()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void XtraAfils_Load(object sender, EventArgs e)
        {
            try
            {

                chkbClientes.Properties.PopupFormWidth = 700;
                cboIdTenedora.Properties.PopupFormWidth = 700;

                String stFechaincial = String.Empty;
                DateTime dTimeFechaInical = new DateTime();

                stFechaincial = stpSelEstatusNominaContabilizadaTableAdapter1.ObtenerFechaServidor().ToString();
                DateTime.TryParse(stFechaincial, out dTimeFechaInical);

                dateFechaIni.DateTime = dTimeFechaInical;
                dateFechaFin.DateTime = dTimeFechaInical;
                if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }

            }
            catch (Exception ex)
            {
                if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }
                XtraMessageBox.Show("Error al cargar información. " + ex.Message, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateFechaIni_EditValueChanged(object sender, EventArgs e)
        {
            cargaInformacionTenedoras();
        }

        private void dateFechaFin_EditValueChanged(object sender, EventArgs e)
        {
            cargaInformacionTenedoras();
        }


        private void cargaInformacionTenedoras()
        {
            try
            {
                splashScreenManager1.ShowWaitForm();

                stpSelDocumentosIMSSInfoTenedorasTableAdapter1.Fill(dbSAICBPOActualizacionesIMSSDataSet1.stpSelDocumentosIMSSInfoTenedoras, dateFechaIni.DateTime.Date, dateFechaFin.DateTime.Date);

                if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }
            }
            catch (Exception ex)
            {
                if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }
                XtraMessageBox.Show("Error al cargar Tenedoras. " + ex.Message, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void cboIdTenedora_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                splashScreenManager1.ShowWaitForm();

                int idTenedora = 0;
                int.TryParse(cboIdTenedora.EditValue.ToString(), out idTenedora);
                stpSelDocumentosIMSSInfoClientesTableAdapter1.Fill(dbSAICBPOActualizacionesIMSSDataSet1.stpSelDocumentosIMSSInfoClientes, dateFechaIni.DateTime, dateFechaFin.DateTime, idTenedora);

                if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }
            }
            catch (Exception ex)
            {
                if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }
                XtraMessageBox.Show("Error al cargar Clientes. " + ex.Message, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscarAfiles();

        }


        private void buscarAfiles()
        {
            try
            {
                splashScreenManager1.ShowWaitForm();
                int idTenedora = 0;
                int.TryParse(cboIdTenedora.EditValue.ToString(), out idTenedora);

                String stCliente = String.Empty;
                foreach (var item in chkbClientes.Properties.Items.GetCheckedValues())
                {
                    stCliente = stCliente + item.ToString() + ",";
                }

                stpSelDocumentosIMSSInfoAfilesTableAdapter1.Fill(dbSAICBPOActualizacionesIMSSDataSet1.stpSelDocumentosIMSSInfoAfiles, dateFechaIni.DateTime, dateFechaFin.DateTime, idTenedora, stCliente);
                txtTotalDocumentos.Text = dbSAICBPOActualizacionesIMSSDataSet1.stpSelDocumentosIMSSInfoAfiles.Rows.Count.ToString();
                txtSeleccionados.Text = "0";
                if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }
            }
            catch (Exception ex)
            {
                if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }
                XtraMessageBox.Show("Error al cargar Afiles. " + ex.Message, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            txtSeleccionados.Text = gridView1.SelectedRowsCount.ToString();
        }

        private void repositoryItemButtonEditSolicitud_DoubleClick(object sender, EventArgs e)
        {


        }

        private void btnAbrirCarpeta_Click(object sender, EventArgs e)
        {
            String stRutaAfiles = dsc.stRutaSAICIMSS + "Afiles\\";
            dsc.CheckandCreateFolder(stRutaAfiles);
            Process.Start(stRutaAfiles);
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            int iConta = 0;
            int iContaNoDescargados = 0;
            int iContaDescargados = 0;

            DataTable dtDocumentos = dsc.deGridViewSelectedToDataTable(gridView1);
            splashScreenManager1.ShowWaitForm();
            List<String> lstErrores = new List<String>();
            foreach (DataRow item in dtDocumentos.Rows)
            {
                int idDocumentoIMSS = 0;
                try
                {
                    iConta++;
                    splashScreenManager1.SetWaitFormCaption("Descargando Afil");
                    splashScreenManager1.SetWaitFormDescription(iConta + " de " + dtDocumentos.Rows.Count);
                    int.TryParse(item["idDocumentoIMSS"].ToString(), out idDocumentoIMSS);
                    stpSelDocumentosIMSSInfoAfileTableAdapter1.Fill(dbSAICBPOActualizacionesIMSSDataSet1.stpSelDocumentosIMSSInfoAfile, idDocumentoIMSS);

                    if (dbSAICBPOActualizacionesIMSSDataSet1.stpSelDocumentosIMSSInfoAfile.Rows.Count > 0)
                    {
                        if (!String.IsNullOrEmpty(dbSAICBPOActualizacionesIMSSDataSet1.stpSelDocumentosIMSSInfoAfile.Rows[0]["ValorDocumento"].ToString()))
                        {
                            String stRutaAarchivo = dsc.stRutaSAICIMSS + @"Afiles\" + cboIdTenedora.Text + @"\";
                            dsc.CheckandCreateFolder(stRutaAarchivo);

                            DateTime dtFechaSolicitud = new DateTime();
                            DateTime.TryParse(dbSAICBPOActualizacionesIMSSDataSet1.stpSelDocumentosIMSSInfoAfile.Rows[0]["FechaCreacionSolicitud"].ToString(), out dtFechaSolicitud);

                            String stNombreArchivo = "S" +
                                dbSAICBPOActualizacionesIMSSDataSet1.stpSelDocumentosIMSSInfoAfile.Rows[0]["idSolicitud"].ToString() + "_" +
                                dbSAICBPOActualizacionesIMSSDataSet1.stpSelDocumentosIMSSInfoAfile.Rows[0]["DescTipoSolicitud"].ToString() + "_" +
                                dbSAICBPOActualizacionesIMSSDataSet1.stpSelDocumentosIMSSInfoAfile.Rows[0]["NombreArchivo"].ToString().Replace(".pdf", "") + "_" +
                                 dtFechaSolicitud.ToShortDateString().Replace("/", "") + ".pdf";

                            dsc.ConvertToFile(dbSAICBPOActualizacionesIMSSDataSet1.stpSelDocumentosIMSSInfoAfile.Rows[0]["ValorDocumento"].ToString(),
                                stRutaAarchivo + stNombreArchivo);
                            iContaDescargados++;
                        }
                        else
                        {
                            iContaNoDescargados++;
                            lstErrores.Add(idDocumentoIMSS + ": Sin Valor de Documento.");
                        }
                    }
                    else
                    {
                        iContaNoDescargados++;
                        lstErrores.Add(idDocumentoIMSS + ": Sin Datos en SAIC.");
                    }
                }
                catch (Exception ex)
                {
                    iContaNoDescargados++;
                    lstErrores.Add(idDocumentoIMSS + ": Error. " + ex.Message);
                }
            }

            if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }

            XtraMessageBox.Show(

                (iContaNoDescargados == 0 ? "Proceso Termiando" : "Proceso Terminado con Errores") +
                Environment.NewLine + Environment.NewLine +
                "Afiles Seleccionados: " + dtDocumentos.Rows.Count + Environment.NewLine +
                "Afiles Descargados: " + iContaDescargados + Environment.NewLine +
                "Afiles Con Error: " + iContaNoDescargados + Environment.NewLine
                , "SAIC",
                MessageBoxButtons.OK,
                iContaNoDescargados == 0 ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

            if (lstErrores.Count > 0)
            {
                String stRutaAarchivo = dsc.stRutaSAICIMSS + @"Afiles\" + cboIdTenedora.Text + @"\";
                dsc.CheckandCreateFolder(stRutaAarchivo);

                stRutaAarchivo += "Detalle de Afiles " + dsc.nombreAleatorio() + ".txt";
                File.WriteAllLines(stRutaAarchivo, lstErrores);
            }

        }

        private void repositoryItemButtonEditSolicitud_Click(object sender, EventArgs e)
        {
            String sdaf = OperadorBD.OperadorGlobal.Grupo;

            DataRow unRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (unRow != null)
            {
                String stGrupo = String.Empty;
                int iSolicitud;
                int.TryParse(unRow["idSolicitud"].ToString(), out iSolicitud);

                Solicitud miSolicitud = new Solicitud();
                miSolicitud = miSolicitud.ObtenerSolcitud(iSolicitud, 2);

                if (OperadorBD.OperadorGlobal.Grupo.Contains("ADMINISTRADORES") || OperadorBD.OperadorGlobal.Grupo.Contains("DIRECTOR"))
                {

                    using (var form = new tools.XtraOpciones("Seleccione Area:", "Operaciones", "IMSS"))
                    {
                        var result = form.ShowDialog();

                        if (result == DialogResult.OK)
                        {
                            int iResultado = form.iResultado;
                            if (iResultado == 1)
                            {
                                XtraMonitoreoSolicitudesOperaciones objMonitoreo = new XtraMonitoreoSolicitudesOperaciones(iSolicitud);
                                objMonitoreo.ShowDialog();
                            }
                            else if (iResultado == 2)
                            {
                                IMSS.XtraEmpleadosXSolicitudIMSS EmpleadosSolicitud = new IMSS.XtraEmpleadosXSolicitudIMSS(miSolicitud);
                                EmpleadosSolicitud.ShowDialog();
                                buscarAfiles();
                            }
                        }
                    }
                }
                else if (OperadorBD.OperadorGlobal.Grupo.Contains("IMSS"))
                {
                    IMSS.XtraEmpleadosXSolicitudIMSS EmpleadosSolicitud = new IMSS.XtraEmpleadosXSolicitudIMSS(miSolicitud);
                    EmpleadosSolicitud.ShowDialog();
                    buscarAfiles();
                }
                else if (OperadorBD.OperadorGlobal.Grupo.Contains("OPERADOR"))
                {
                    XtraMonitoreoSolicitudesOperaciones objMonitoreo = new XtraMonitoreoSolicitudesOperaciones(iSolicitud);
                    objMonitoreo.ShowDialog();
                }

                if (true)
                {

                }


            }
            else
            {
                XtraMessageBox.Show("No se puede abrir la solicitud.", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}