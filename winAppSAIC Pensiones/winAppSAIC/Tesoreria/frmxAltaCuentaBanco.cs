using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace winAppSAIC.Tesoreria
{
    public partial class frmxAltaCuentaBanco : DevExpress.XtraEditors.XtraForm
    {
        public frmxAltaCuentaBanco()
        {
            InitializeComponent();
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

        private void frmxAltaCuentaBanco_Load(object sender, EventArgs e)
        {
            try
            {
                this.stpSelEstatusCuentaBancoTableAdapter.Fill(this.dbSAICBPOCatalogosDataSet.stpSelEstatusCuentaBanco);
                this.stpSelMatrizTenedoraCuentaBancoTableAdapter.Fill(this.dbSAICBPOCatalogosDataSet.stpSelMatrizTenedoraCuentaBanco);
                this.stpSelMonedaTableAdapter.Fill(this.dbSAICBPOCatalogosDataSet.stpSelMoneda);
                this.stpSelBancoTodosTableAdapter.Fill(this.dbSAICBPOCatalogosDataSet.stpSelBancoTodos);
                this.stpSelClasifCuentaBancoTableAdapter.Fill(this.dbSAICBPOCatalogosDataSet.stpSelClasifCuentaBanco);
                this.cuentaBancoTableAdapter.Fill(this.dbSAICBPOTesoreriaDataSet.CuentaBanco);
                // Specify the total dropdown width. 
                cboIdMatrizTenedora.Properties.PopupFormWidth = 700;
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

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }
    }
}