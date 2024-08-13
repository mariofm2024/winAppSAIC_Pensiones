using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using winAppSAIC.UtileriasLocal;
using compCatalogosSAIC;

namespace winAppSAIC.Facturas
{
    public partial class frmActualizarConceptos : DevExpress.XtraEditors.XtraForm
    {
        public frmActualizarConceptos()
        {
            InitializeComponent();
        }

        public Int64 pIdDetaill = 0;
        public decimal pCantidad = 0;
        public Int32 pIdUnidad = 0;
        public Int32 pIdUsoCFDI = 0;
        public Int32 pIdFronting = 0;
        public Int32 pIdTipoBeneficiario = 0;
        public Int32 pIdBeneficiario = 0;

        String stRechazo;
        ErrorProvider erroProviderCampos = new ErrorProvider();
        tools.dsc dsc = new tools.dsc();
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Close(); // Cerrar Pantalla
        }

        private void frmAgregarConceptos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbSAICBPOFactura.vwFactCatClaveUnidad' table. You can move, or remove it, as needed.
            this.vwFactCatClaveUnidadTableAdapter.Fill(this.dbSAICBPOFactura.vwFactCatClaveUnidad);
            try
            {
                cbUnidad.EditValue = pIdUnidad;
                txtCantidad.Text = pCantidad.ToString();
                this.stpFactSelConceptoTenedoraBeneficiarioFiltroTableAdapter.Fill(dbSAICBPOFactura.stpFactSelConceptoTenedoraBeneficiarioFiltro, 2, pIdTipoBeneficiario, pIdBeneficiario, pIdUsoCFDI, pIdFronting, false);
                               
                // Set column widths according to their contents. 
                cboIdConcepto.Properties.View.BestFitColumns();
                // Specify the total dropdown width. 
                cboIdConcepto.Properties.PopupFormWidth = 700;
                // Set column widths according to their contents. 
                cbUnidad.Properties.View.BestFitColumns();
                // Specify the total dropdown width. 
                cbUnidad.Properties.PopupFormWidth = 350;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validator.IsPresent(cboIdConcepto) && Validator.IsPositiveNumber(txtCantidad)
                    && Validator.IsPresent(cbUnidad))
                {
                    int ? pOk = 0;

                    this.spSoloRespuesta1.stpFactUpdConcepto(pIdDetaill, Convert.ToInt64(cboIdConcepto.EditValue.ToString()), Convert.ToDecimal(txtCantidad.Text.ToString().Replace(".","")),
                        Convert.ToInt32(cbUnidad.EditValue.ToString()),txtComplemento.Text.ToString(), OperadorBD.OperadorGlobal.NombreUsuario, ref pOk);

                    if (pOk == 1)
                        XtraMessageBox.Show("¡Error, Intentelo más tarde!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                    {
                        XtraMessageBox.Show("¡EL Concepto se Actualizo correctamente!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtComplemento_TextChanged(object sender, EventArgs e)
        {
            String stCaracEspeNombre = dsc.contieneCaracteresEspeciales(txtComplemento.Text.ToUpper().Trim(), dsc.stCaracteresEspeciales);
            if (!String.IsNullOrEmpty(stCaracEspeNombre))
            {
                erroProviderCampos.Icon = Properties.Resources.warning1;
                erroProviderCampos.SetError(txtComplemento, "Rechazo Contiene Caracteres Especiales: " + stCaracEspeNombre);
                btnAgregar.Enabled = false;
            }
            else
            {
                erroProviderCampos.Clear();
                btnAgregar.Enabled = true;
            }
        }
    }
}