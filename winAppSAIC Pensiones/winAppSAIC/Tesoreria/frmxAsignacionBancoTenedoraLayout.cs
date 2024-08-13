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
    public partial class frmxAsignacionBancoTenedoraLayout : DevExpress.XtraEditors.XtraForm
    {
        public frmxAsignacionBancoTenedoraLayout()
        {
            InitializeComponent();
        }

        #region "Metodos Propios"

        private void AsignarToolTips()
        {
            alineacionNoClienteTextEdit.ToolTip = "Valores permitidos L o R";
            alineacionNoClienteTextEdit.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            alineacionNoSucursalTextEdit.ToolTip = "Valores permitidos L o R";
            alineacionNoSucursalTextEdit.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            alineacionNoCuentaTextEdit.ToolTip = "Valores permitidos L o R";
            alineacionNoCuentaTextEdit.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            alineacionNoCLABETextEdit.ToolTip = "Valores permitidos L o R";
            alineacionNoCLABETextEdit.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            alineacionRefNumericaTextEdit.ToolTip = "Valores permitidos L o R";
            alineacionRefNumericaTextEdit.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            alineacionRefAlfanumericaTextEdit.ToolTip = "Valores permitidos L o R";
            alineacionRefAlfanumericaTextEdit.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            alineacionRazonSocialTextEdit.ToolTip = "Valores permitidos L o R";
            alineacionRazonSocialTextEdit.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
        }

        #endregion

        private void tenedoraBancoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            { 
                this.Validate();
                this.tenedoraBancoBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dbSAICBPOTesoreriaDataSet);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmxAsignacionBancoTenedoraLayout_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'dbSAICBPOTesoreriaDataSet1.TenedoraBancoLayout' table. You can move, or remove it, as needed.
                this.tenedoraBancoLayoutTableAdapter.Fill(this.dbSAICBPOTesoreriaDataSet1.TenedoraBancoLayout);
                // TODO: This line of code loads data into the 'dbSAICBPOTesoreriaDataSet.EstatusBancoLayout' table. You can move, or remove it, as needed.
                this.estatusBancoLayoutTableAdapter.Fill(this.dbSAICBPOTesoreriaDataSet.EstatusBancoLayout);
                // TODO: This line of code loads data into the 'dbSAICBPOCatalogosDataSet.stpSelMoneda' table. You can move, or remove it, as needed.
                this.stpSelMonedaTableAdapter.Fill(this.dbSAICBPOCatalogosDataSet.stpSelMoneda);
                // TODO: This line of code loads data into the 'dbSAICBPOCatalogosDataSet.stpSelBanco' table. You can move, or remove it, as needed.
                this.stpSelBancoTableAdapter.Fill(this.dbSAICBPOCatalogosDataSet.stpSelBanco);
                // TODO: This line of code loads data into the 'dbSAICBPOTesoreriaDataSet.TenedoraBanco' table. You can move, or remove it, as needed.
                this.tenedoraBancoTableAdapter.Fill(this.dbSAICBPOTesoreriaDataSet.TenedoraBanco);

                AsignarToolTips();
                idTenedoraGridLookUpEdit.Focus();       //colocar cursor en objetos
            }
            catch (System.Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnFiltrarPorBanco_Click(object sender, EventArgs e)
        {
            try
            {
                this.tenedoraBancoTableAdapter.FillByBanco(this.dbSAICBPOTesoreriaDataSet.TenedoraBanco, Convert.ToByte(cboFiltrarBanco.EditValue));
            }
            catch (System.Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            try
            {
                this.tenedoraBancoTableAdapter.Fill(this.dbSAICBPOTesoreriaDataSet.TenedoraBanco);
            }
            catch (System.Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();        //cerrar pantalla
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                this.tenedoraBancoBindingSource.CancelEdit();
            }
            catch (System.Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}