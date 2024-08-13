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

namespace winAppSAIC.ControlOperaciones
{
    public partial class frmxSolicitudesPagoDetailBOrigen : DevExpress.XtraEditors.XtraForm
    {

        public Int64 IdSolicitud = 0;
        public Int32 IdTenedora = 0;
        public string sTenedora = "";
        public string sBanco = "";
        public string sCuenta = "";
        public double dTotal = 0;

        public frmxSolicitudesPagoDetailBOrigen()
        {
            InitializeComponent();
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void frmxSolicitudesPagoDetailBOrigen_Load(object sender, EventArgs e)
        {
            try
            {

                txtSolicitud.Text = IdSolicitud.ToString();
                // Set column widths according to their contents. 
                cbTenedora.Properties.View.BestFitColumns();
                // Specify the total dropdown width. 
                cbTenedora.Properties.PopupFormWidth = 700;
                cbCuenta.Properties.PopupFormWidth = 500;
                dtFechaPago.Value = DateTime.Today;

                this.stpTesSelBeneficiarioTenedoraTableAdapter.Fill(this.dbSAICBPOTesoreriaDataSet.stpTesSelBeneficiarioTenedora, IdTenedora);

                txtSolicitud.Text = IdSolicitud.ToString();
                txtTenedora.Text = sTenedora;
                txtBanco.Text = sBanco;
                txtCuenta.Text = sCuenta;
                txtCatidadTotal.Text = dTotal.ToString();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cbTenedora_EditValueChanged(object sender, EventArgs e)
        {
            Int32 IdTenedora = 0;
            try
            {
                if (Convert.ToInt32(cbTenedora.EditValue) != -1)
                {
                    if (Validator.IsPresent(cbTenedora))
                    {
                        IdTenedora = Convert.ToInt32(cbTenedora.EditValue);

                        this.dbSAICBPOTesoreriaDataSet.stpTesSelBancosMatrizTenedoras.Clear();
                        this.dbSAICBPOTesoreriaDataSet.stpTesSelCuentaBancoPorFronting.Clear();
                        this.dbSAICBPOTesoreriaDataSet.stpTesSelLayoutBancoFormatoPorBanco.Clear();
                        this.stpTesSelBancosMatrizTenedorasTableAdapter.Fill(this.dbSAICBPOTesoreriaDataSet.stpTesSelBancosMatrizTenedoras, IdTenedora);
                    }

                    else
                    {
                        this.dbSAICBPOTesoreriaDataSet.stpTesSelBancosMatrizTenedoras.Clear();
                        this.dbSAICBPOTesoreriaDataSet.stpTesSelCuentaBancoPorFronting.Clear();
                        this.dbSAICBPOTesoreriaDataSet.stpTesSelLayoutBancoFormatoPorBanco.Clear();
                    }
                }
                else if (Convert.ToInt32(cbTenedora.EditValue) == -1)
                {
                    this.dbSAICBPOTesoreriaDataSet.stpTesSelBancosMatrizTenedoras.Clear();
                    this.dbSAICBPOTesoreriaDataSet.stpTesSelCuentaBancoPorFronting.Clear();
                    this.dbSAICBPOTesoreriaDataSet.stpTesSelLayoutBancoFormatoPorBanco.Clear();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbBanco_SelectedIndexChanged(object sender, EventArgs e)
        {
            byte IdBanco = 0;
            Int32 IdTenedora = 0;
            string Banco = "";
            try
            {
                if (cbBanco.SelectedIndex != -1)
                    if (Validator.IsPresent(cbTenedora) && Validator.IsPresent(cbBanco))
                    {
                        IdBanco = Convert.ToByte(cbBanco.SelectedValue);
                        Banco = cbBanco.Text.ToString();
                        IdTenedora = Convert.ToInt32(cbTenedora.EditValue);
                        this.stpTesSelCuentaBancoPorFrontingTableAdapter.Fill(this.dbSAICBPOTesoreriaDataSet.stpTesSelCuentaBancoPorFronting, IdTenedora, IdBanco);
                        this.stpTesSelLayoutBancoFormatoPorBancoTableAdapter.Fill(dbSAICBPOTesoreriaDataSet.stpTesSelLayoutBancoFormatoPorBanco, Banco);
                    }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            byte IdBanco = 0;
            Int32 IdFronting = 0;
            Int32 IdCuenta = 0;
            Int32 Idlayout = 0;
            decimal dTotal = 0;
            string sFechaPago = "";
            Int64? pIdDetail = 0;
            try
            {
                
                if (Validator.IsPresent(cbTenedora) && Validator.IsPresent(cbBanco) && Validator.IsPresent(cbCuenta) && Validator.IsPresent(cbidLayout))
                {
                        DateTime time = Convert.ToDateTime(dtFechaPago.Text);
                        IdBanco = Convert.ToByte(cbBanco.SelectedValue);
                        IdFronting = Convert.ToInt32(cbTenedora.EditValue);
                        IdCuenta = Convert.ToInt32(cbCuenta.EditValue);
                        Idlayout = Convert.ToInt32(cbidLayout.EditValue);
                        sFechaPago = time.ToString("yyyy-MM-dd");

                    this.respuestasTesoreria1.stpTesInsSolicitudPagoDetailFron(IdSolicitud, IdFronting, IdBanco, IdCuenta, Idlayout, sFechaPago, dTotal, OperadorBD.OperadorGlobal.NombreUsuario, OperadorBD.OperadorGlobal.IdOperador, ref pIdDetail);

                    if (pIdDetail > 0)
                        {
                            XtraMessageBox.Show("¡La Transacción se guardo Correctamente!", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            XtraMessageBox.Show("¡Error Intente mas tarde!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}