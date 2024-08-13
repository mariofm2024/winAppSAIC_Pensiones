using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;
using compLibreriaSAIC;
using System.Data;
using System.Data.SqlClient;
using compNominaCFDI;
using compCatalogosSAIC;
using DevExpress.XtraEditors;

namespace winAppSAIC.Tesoreria
{
    public partial class frmxReporteDetalleCheques : DevExpress.XtraEditors.XtraForm
    {
        public InfoSolicitudChequeHeader objInfoDetalle;

        #region "Variables Globales"
        EstatusNomina objNomina;
        InfoSolicitudChequeHeader objInfoDetalleSolicitudChequeMasivo = null;
        #endregion

        #region "Metodos Propios"

        /// <summary>
        /// Método para inicializar controles en pantalla
        /// </summary>
        private void InicializarControles()
        {
            //bloqueo de boton Exportar a Excel (XLS)
            btnExportarXLS.Enabled = false;
            cmExportarGrid.Enabled = false;
        }

        private void MostrarInformacionSolicitudChequeMasivo()
        {
            txtIdSolicitud.Text = objInfoDetalle.IdSolicitudChequeHeader.ToString("N0");
            txtLote.Text = objInfoDetalle.IdLoteCargaNomina.ToString("N0"); ; //.FolioLoteCargaNomina;
            txtTenedora.Text = objInfoDetalle.NombreComercialTenedora;
            txtCliente.Text = objInfoDetalle.NombreComercialCliente;
            txtNoControl.Text = objInfoDetalle.NoControl;
            txtBanco.Text = objInfoDetalle.BancoSolicitado;
        }

        #endregion

        public frmxReporteDetalleCheques()
        {
            InitializeComponent();
        }

        private void frmxReporteDetalleCheques_Load(object sender, EventArgs e)
        {
            try
            {
                MostrarInformacionSolicitudChequeMasivo();
                // Agregar el mostrar el detalle de los Cheques
                this.stpSelSolicitudesChequesMasivosReporteDetalleTableAdapter.Fill(dbSAICBPOReportesDataSet.stpSelSolicitudesChequesMasivosReporteDetalle, Convert.ToInt32(objInfoDetalle.IdSolicitudChequeHeader));

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exportarAExcelXLSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (sfdRutaArchivo.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    //stpSelReporteNominaSueldosSA_XLSGridControl.ExportToXls(sfdRutaArchivo.FileName);

                    //Solicitar la visualización del nuevo archivo en Excel
                    if (XtraMessageBox.Show("¿Desea abrir el archivo en Excel?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        // Mostrar resultado en Excel.
                        Utilerias.StartProcess(sfdRutaArchivo.FileName);
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();        //cerrar pantalla
        }
        
        private void btnExportarXLS_Click(object sender, EventArgs e)
        {
            try
            {
                if (sfdRutaArchivo.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    gvSolicitudChequesMasivos.ExportToXls(sfdRutaArchivo.FileName);

                    //Solicitar la visualización del nuevo archivo en Excel
                    if (XtraMessageBox.Show("¿Desea abrir el archivo en Excel?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        // Mostrar resultado en Excel.
                        Utilerias.StartProcess(sfdRutaArchivo.FileName);
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Close();        //cerrar pantalla
        }
     
    }
}