using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace winAppSAIC.Tesoreria
{
    public partial class frmxControlCuentaBanco : DevExpress.XtraEditors.XtraForm
    {
        public frmxControlCuentaBanco()
        {
            InitializeComponent();
            try
            {
                stpSelMatrizTenedoraCuentaBancoTableAdapter.Fill(dbSAICBPOCatalogosDataSet1.stpSelMatrizTenedoraCuentaBanco);
                this.stpSelClasifCuentaBancoTableAdapter.Fill(this.dbSAICBPOCatalogosDataSet1.stpSelClasifCuentaBanco);
                stpSelBancoTableAdapter.Fill(dbSAICBPOCatalogosDataSet1.stpSelBanco);
                stpSelMonedaTableAdapter.Fill(dbSAICBPOCatalogosDataSet1.stpSelMoneda);
                this.stpSelEstatusCuentaBancoTableAdapter.Fill(this.dbSAICBPOCatalogosDataSet1.stpSelEstatusCuentaBanco);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cuentaBancoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.cuentaBancoBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dbSAICBPOTesoreriaDataSet);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmxControlCuentaBanco_Load(object sender, EventArgs e)
        {
          try
            {
                this.stpSelMonedaTableAdapter.Fill(this.dbSAICBPOCatalogosDataSet1.stpSelMoneda);
                this.stpSelBancoTableAdapter.Fill(this.dbSAICBPOCatalogosDataSet1.stpSelBanco);
                this.stpSelMatrizTenedoraCuentaBancoTableAdapter.Fill(this.dbSAICBPOCatalogosDataSet1.stpSelMatrizTenedoraCuentaBanco);
                this.cuentaBancoTableAdapter.Fill(this.dbSAICBPOTesoreriaDataSet.CuentaBanco);
                // Specify the total dropdown width. 
                cboTenedora.Properties.PopupFormWidth = 900;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();       //cerrar pantalla
        }
    }
}