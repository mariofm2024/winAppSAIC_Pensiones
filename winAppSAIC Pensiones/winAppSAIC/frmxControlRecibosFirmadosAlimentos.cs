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
    public partial class frmxControlRecibosFirmadosAlimentos : DevExpress.XtraEditors.XtraForm
    {
        public frmxControlRecibosFirmadosAlimentos()
        {
            InitializeComponent();
        }

        private void pDOHeaderSCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.pDOHeaderSCBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dbSAICBPOReportesDataSet);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       private void frmxControlRecibosFirmadosAlimentos_Load(object sender, EventArgs e)
        {
            try
            {
                splashSMCargando.ShowWaitForm();
                this.stpSelFolioLoteCargaNominaSCTableAdapter.Fill(this.dbSAICBPODataSet.stpSelFolioLoteCargaNominaSC);
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

        private void cboFolioLoteCargaNomina_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                //mostrar datos en base al IdLoteCargaNomina
                this.pDOHeaderSCTableAdapter.Fill(this.dbSAICBPOReportesDataSet.PDOHeaderSC, (long)cboFolioLoteCargaNomina.EditValue);
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
    }
}