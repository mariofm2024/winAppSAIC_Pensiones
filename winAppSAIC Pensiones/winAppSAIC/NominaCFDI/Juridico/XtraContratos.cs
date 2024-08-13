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
using DevExpress.XtraReports.UI;
using System.Diagnostics;

namespace winAppSAIC.Juridico
{
    public partial class XtraContratos : DevExpress.XtraEditors.XtraForm
    {
        tools.dsc dsc = new tools.dsc();
        public XtraContratos()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void XtraContratos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetJuridico1.stpSelTipoContratoMatrizTenedora' Puede moverla o quitarla según sea necesario.
            this.stpSelTipoContratoMatrizTenedoraTableAdapter.Fill(this.dataSetJuridico1.stpSelTipoContratoMatrizTenedora);
            // TODO: esta línea de código carga datos en la tabla 'dataSetJuridico1.stpSelDiccionarioContrato' Puede moverla o quitarla según sea necesario.
            this.stpSelDiccionarioContratoTableAdapter.Fill(this.dataSetJuridico1.stpSelDiccionarioContrato);
            stpSelMatrizTenedoraContratosTableAdapter1.Fill(dataSetJuridico1.stpSelMatrizTenedoraContratos);
            stpSelTipoContratoMatrizTenedoraTableAdapter.Fill(dataSetJuridico1.stpSelTipoContratoMatrizTenedora);

            gridLookMatrizTenedora.Properties.PopupFormWidth = 700;
            gridLookUpEditTipoContrato.Properties.PopupFormWidth = 400;
        }
        ContratosMetrizTenedora oContratosMetrizTenedora_General;
        private void gridLookMatrizTenedora_EditValueChanged(object sender, EventArgs e)
        {
            ObtenerInformacionContrato();
        }

        private void ObtenerInformacionContrato()
        {
            int idMatrizTenedora = 0;
            int idTipoContrato = 0;

            int.TryParse(gridLookMatrizTenedora.EditValue.ToString(), out idMatrizTenedora);
            int.TryParse(gridLookUpEditTipoContrato.EditValue.ToString(), out idTipoContrato);

            if (idMatrizTenedora > 0 && idTipoContrato > 0)
            {
                try
                {
                    splashScreenManager2.ShowWaitForm();
                    splashScreenManager2.SetWaitFormCaption("Consultando Contrato");
                    splashScreenManager2.SetWaitFormDescription("Espere...");
                    //int idMatrizTenedora = 0;
                    //int.TryParse(gridLookMatrizTenedora.EditValue.ToString(), out idMatrizTenedora);
                    stpSelContratosMatrizTenedoraTableAdapter1.Fill(dataSetJuridico1.stpSelContratosMatrizTenedora, idMatrizTenedora, idTipoContrato);
                    limpiarControles();
                    if (dataSetJuridico1.stpSelContratosMatrizTenedora.Rows.Count > 0)
                    {
                        oContratosMetrizTenedora_General = obtenerValores(dataSetJuridico1.stpSelContratosMatrizTenedora.Rows[0]);

                        txtIdContratoMatrizTenedora.Text = oContratosMetrizTenedora_General.idContratoMatrizTenedora.ToString();
                        rdContratoActivado.Checked = oContratosMetrizTenedora_General.flagContratoActivado;
                        rdContratoGenerico.Checked = oContratosMetrizTenedora_General.flagContratoGenerico;
                        richEditControlContratos.RtfText = oContratosMetrizTenedora_General.stContrato;
                        if (splashScreenManager2.IsSplashFormVisible) { splashScreenManager2.CloseWaitForm(); }
                    }
                    else
                    {
                        if (splashScreenManager2.IsSplashFormVisible) { splashScreenManager2.CloseWaitForm(); }
                        XtraMessageBox.Show("Tenedora sin Contrato", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarControles();
                    }
                }
                catch (Exception ex)
                {
                    if (splashScreenManager2.IsSplashFormVisible) { splashScreenManager2.CloseWaitForm(); }
                    XtraMessageBox.Show("Error al consultar contrato. " + ex.Message, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                XtraMessageBox.Show("Seleccione una Tenedora y un Tipo Contrato.", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            richEditControlContratos.RtfText = String.Empty;
        }

        private void limpiarControles()
        {
            richEditControlContratos.RtfText = String.Empty;
            txtIdContratoMatrizTenedora.Text = "0";
            rdContratoActivado.Checked = false;
            rdContratoGenerico.Checked = false;
        }

        private ContratosMetrizTenedora asignarValores()
        {
            ContratosMetrizTenedora oContratosMetrizTenedora = new ContratosMetrizTenedora();
            int idContratoMatrizTenedora = 0;
            int idMatrizTenedora = 0;
            int idTipoContrato = 0;

            int.TryParse(txtIdContratoMatrizTenedora.Text, out idContratoMatrizTenedora);
            int.TryParse(gridLookMatrizTenedora.EditValue.ToString(), out idMatrizTenedora);
            int.TryParse(gridLookUpEditTipoContrato.EditValue.ToString(), out idTipoContrato);


            oContratosMetrizTenedora.idContratoMatrizTenedora = idContratoMatrizTenedora;
            oContratosMetrizTenedora.idMatrizTenedora = idMatrizTenedora;
            oContratosMetrizTenedora.idTipoContrato = idTipoContrato;
            oContratosMetrizTenedora.stContrato = richEditControlContratos.RtfText;

            oContratosMetrizTenedora.flagContratoActivado = rdContratoActivado.Checked;
            oContratosMetrizTenedora.flagContratoGenerico = rdContratoGenerico.Checked;

            return oContratosMetrizTenedora;
        }

        private ContratosMetrizTenedora obtenerValores(DataRow row)
        {
            ContratosMetrizTenedora oContratosMetrizTenedora = new ContratosMetrizTenedora();
            oContratosMetrizTenedora.idMatrizTenedora = (int)gridLookMatrizTenedora.EditValue;
            oContratosMetrizTenedora.stRazonSocialMatrizTenedora = gridLookMatrizTenedora.Text;
            oContratosMetrizTenedora.idContratoMatrizTenedora = (int)row["idContratosMatrizTenedora"];
            oContratosMetrizTenedora.flagContratoActivado = (Boolean)row["ContratoActivado"];
            oContratosMetrizTenedora.flagContratoGenerico = (Boolean)row["ContratoGenerico"];
            oContratosMetrizTenedora.stContrato = row["Contrato"].ToString();
            //oContratosMetrizTenedora.idTipoContrato = row["Contrato"].ToString();
            return oContratosMetrizTenedora;
        }

        private void btnDescargarDiccionario_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                ContratosMetrizTenedora oContratosMetrizTenedora = asignarValores();
                if (oContratosMetrizTenedora.idMatrizTenedora > 0 && oContratosMetrizTenedora.idTipoContrato > 0)
                {
                    DialogResult oDialogResult = XtraMessageBox.Show("¿Esta seguro de Guardar la informacion de contrato para la Tenedora " + gridLookMatrizTenedora.Text + "?",
                        "SAIC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (DialogResult.Yes == oDialogResult)
                    {
                        splashScreenManager2.ShowWaitForm();
                        splashScreenManager2.SetWaitFormCaption("Guardando");
                        splashScreenManager2.SetWaitFormDescription("Espere...");

                        queriesJuridico1.stpInsContratosMatrizTenedora(oContratosMetrizTenedora.idContratoMatrizTenedora,
                            oContratosMetrizTenedora.idMatrizTenedora,
                            oContratosMetrizTenedora.stContrato,
                            oContratosMetrizTenedora.flagContratoActivado,
                            oContratosMetrizTenedora.flagContratoGenerico,
                            OperadorBD.OperadorGlobal.NombreUsuario,
                            oContratosMetrizTenedora.idTipoContrato);

                        if (splashScreenManager2.IsSplashFormVisible) { splashScreenManager2.CloseWaitForm(); }

                        XtraMessageBox.Show("Contrato Guardado con Exito",
                        "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        stpSelMatrizTenedoraContratosTableAdapter1.Fill(dataSetJuridico1.stpSelMatrizTenedoraContratos);
                    }
                }
                else
                {
                    XtraMessageBox.Show("Seleccione una Tenedora y Tipo Contrato para continuar",
                      "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                if (splashScreenManager2.IsSplashFormVisible) { splashScreenManager2.CloseWaitForm(); }
                XtraMessageBox.Show("Error al guardar Contrato." + Environment.NewLine + ex.Message,
                     "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rdContratoActivado_CheckedChanged(object sender, EventArgs e)
        {
            if (rdContratoActivado.Checked)
            {
                lblMensaje.Text = "Contrato Activado para Solicitudes de Altas, Reingresos y contratos Individuales desde el Modulo de empleados.";
            }
        }

        private void rdContratoGenerico_CheckedChanged(object sender, EventArgs e)
        {
            if (rdContratoGenerico.Checked)
            {
                lblMensaje.Text = "Contrato GENERICO Activado para Solicitudes de Altas, Reingresos y contratos Individuales desde el Modulo de empleados.";
            }
        }

        private void btnDiccionario_Click(object sender, EventArgs e)
        {
            stpSelDiccionarioContratoTableAdapter.Fill(dataSetJuridico1.stpSelDiccionarioContrato);
            gridControlDiccionario.Visible = true;

            dsc.CheckandCreateFolder(dsc.stRutaSAICJuridico + @"\Contratos\");

            String stArchivoDiccionario = dsc.stRutaSAICJuridico + @"\Contratos\Diccionario Contrato - " + dsc.nombreAleatorio() + ".xlsx";

            gridControlDiccionario.ExportToXlsx(stArchivoDiccionario);

            gridControlDiccionario.Visible = false;

            XtraMessageBox.Show("Diccionario Descargado con Exito" + Environment.NewLine +
                "Ruta: " + stArchivoDiccionario, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnVistaPrevia_Click(object sender, EventArgs e)
        {
            if (oContratosMetrizTenedora_General.idContratoMatrizTenedora > 0)
            {
                VisualizarContrato(oContratosMetrizTenedora_General.idContratoMatrizTenedora, 0, 1, String.Empty);
            }
            else
            {
                XtraMessageBox.Show("Guarde el Contrato para Continuar", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        public void VisualizarContrato(int idContratoMatrizTenedora, int idEmpleado, int idTipoConsulta, String stRutaDescarga)
        {
            try
            {
                stpSelCItMatrizTenedoraTableAdapter1.Fill(dataSetJuridico1.stpSelCItMatrizTenedora, idContratoMatrizTenedora, idEmpleado);

                if (idTipoConsulta == 1)// 1 = para Visualizar
                {
                    if (dataSetJuridico1.stpSelCItMatrizTenedora.Rows.Count > 0)
                    {
                        Reportes.CIT_PPP myReport = new Reportes.CIT_PPP();
                        myReport.Parameters["flagConGenerico"].Value = false;
                        myReport.Parameters["tipoConsulta"].Value = 1;
                        myReport.Parameters["ResultadoHTML"].Value = dataSetJuridico1.stpSelCItMatrizTenedora[0]["Contrato"].ToString();
                        myReport.ShowPreviewDialog();
                    }
                    else
                    {
                        XtraMessageBox.Show("Contrato Vacio, no se puede visualizar el contrato", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (idTipoConsulta == 2)//2 para Autorizar
                {
                    queriesTableAdapter1.stpInsAltaEmpleadosAutorizarContrato(idEmpleado
                        , 1
                        , OperadorBD.OperadorGlobal.NombreUsuario
                        , dataSetJuridico1.stpSelCItMatrizTenedora[0]["Contrato"].ToString()
                        , 0
                        , "Rtf");                    
                }
                else if (idTipoConsulta == 3)//3 para Descargar
                {
                    if (dataSetJuridico1.stpSelCItMatrizTenedora.Rows.Count > 0)
                    {
                        Reportes.CIT_PPP myReport = new Reportes.CIT_PPP();
                        myReport.Parameters["flagConGenerico"].Value = false;
                        myReport.Parameters["tipoConsulta"].Value = 1;
                        myReport.Parameters["ResultadoHTML"].Value = dataSetJuridico1.stpSelCItMatrizTenedora[0]["Contrato"].ToString();
                        myReport.ExportToPdf(stRutaDescarga);
                    }
                    else
                    {
                        XtraMessageBox.Show("Contrato Vacio, no se puede visualizar el contrato", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("No se puede consultar el contrato." + Environment.NewLine + ex.Message, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAbrirCarpeta_Click(object sender, EventArgs e)
        {
            dsc.CheckandCreateFolder(dsc.stRutaSAICJuridico + @"\Contratos\");
            Process.Start(dsc.stRutaSAICJuridico + @"\Contratos\");
        }

        private void btnEmpleadoDePruebas_Click(object sender, EventArgs e)
        {
            //Consultando al empleado de pruebas
            int idEmpleado = 0;
            stpSelParametroTableAdapter1.Fill(dbSAICBPOValidacionDataSet1.stpSelParametro, "IDEMPLEADO_DE_PRUEBAS");
            if (dbSAICBPOValidacionDataSet1.stpSelParametro.Rows.Count > 0)
            {
                int.TryParse(dbSAICBPOValidacionDataSet1.stpSelParametro.Rows[0]["ValorParametro"].ToString(), out idEmpleado);
            }

            if (idEmpleado > 0)
            {
                Catalogos.frmxModificacionEmpleados ofrmxModificacionEmpleados = new Catalogos.frmxModificacionEmpleados(idEmpleado,
                true, false, false, false, false, 0);
                ofrmxModificacionEmpleados.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("No se tiene idEmpleado de Pruebas para modificar desde Contratos.", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void cboIdTipoContrato_EditValueChanged(object sender, EventArgs e)
        {
            ObtenerInformacionContrato();
        }

        private void gridLookUpEditTipoContrato_EditValueChanged(object sender, EventArgs e)
        {
            ObtenerInformacionContrato();
        }
    }



    public class ContratosMetrizTenedora
    {
        public ContratosMetrizTenedora()
        {
            idContratoMatrizTenedora = 0;
            idMatrizTenedora = 0;
            stContrato = String.Empty;
            flagContratoActivado = false;
            flagContratoGenerico = false;
            stRazonSocialMatrizTenedora = String.Empty;
            idTipoContrato = 0;
        }

        public int idContratoMatrizTenedora { get; set; }
        public int idMatrizTenedora { get; set; }
        public String stRazonSocialMatrizTenedora { get; set; }
        public String stContrato { get; set; }
        public Boolean flagContratoActivado { get; set; }
        public Boolean flagContratoGenerico { get; set; }
        public int idTipoContrato { get; set; }
    }
}