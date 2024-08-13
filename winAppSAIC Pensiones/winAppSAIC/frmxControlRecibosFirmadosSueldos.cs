using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace winAppSAIC
{
    public partial class frmxControlRecibosFirmados : DevExpress.XtraEditors.XtraForm
    {
        public frmxControlRecibosFirmados()
        {
            InitializeComponent();
        }

        private void pDOHeaderSABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.pDOHeaderSABindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dbSAICBPOReportesDataSet);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmxControlRecibosFirmados_Load(object sender, EventArgs e)
        {
            try
            {
                splashSMCargando.ShowWaitForm();
                this.stpSelFolioLoteCargaNominaSATableAdapter.Fill(this.dbSAICBPODataSet.stpSelFolioLoteCargaNominaSA);
                // Set column widths according to their contents. 
                cboFolioLoteCargaNomina.Properties.View.BestFitColumns();
                // Specify the total dropdown width. 
                cboFolioLoteCargaNomina.Properties.PopupFormWidth = 800;
                splashSMCargando.CloseWaitForm();
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

        private void cboFolioLoteCargaNomina_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                //mostrar datos en base al IdLoteCargaNomina
                this.pDOHeaderSATableAdapter.Fill(this.dbSAICBPOReportesDataSet.PDOHeaderSA, (long)cboFolioLoteCargaNomina.EditValue);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}