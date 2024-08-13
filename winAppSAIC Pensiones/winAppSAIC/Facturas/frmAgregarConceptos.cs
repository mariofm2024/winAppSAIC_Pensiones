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

namespace winAppSAIC.Facturas
{
    public partial class frmAgregarConceptos : DevExpress.XtraEditors.XtraForm
    {
        public frmAgregarConceptos()
        {
            InitializeComponent();
        }
        public Int32 pIdFronting = 0;
        public int pIdTipoBeneficiario = 0;
        public Int32 pIdBeneficiario = 0;
        public string pBFLAG = "N";
        public string pIVAGlobal = "";
        public Int32 pIdUsoCFDI = 0;
        public string pFechaPagoD = "";
        public bool pRetencion = false;
        public bool pConRetencion = false;
        public bool pFlagIVA = false;
        public bool pObjetoImpuesto = false;
        public bool pIVA = false;
        public String pMoneda = "";
        public String pMonedaOri = "";
        public bool Agregar = false;
        public String pIVAPorc = "0";
        public bool pExento = false;

        public double pCantidad = 0;
        public string pUnidad = "", pComplemento = "";
        public double pUnitario = 0, IVAPor = 0, pRestoPago = 0, pDescuento = 0, pRetencionIVA = 0, pTipoCambio = 0, pUnitarioP = 0;
        public Int64 pIdConcepto = 0, pIdUnidad = 0, pIdFacturaRelacion = 0;

        public string pDesc = "", pDescFull = "", pFOLIOSERIE = "";
        String stRechazo;

        private void txtPrecio_EditValueChanged(object sender, EventArgs e)
        {
            Cambio();
        }

        private void txtCambio_EditValueChanged(object sender, EventArgs e)
        {
            Cambio();
        }

        ErrorProvider erroProviderCampos = new ErrorProvider();
        tools.dsc dsc = new tools.dsc();

        Decimal? TotalAcumulado = 0;
        Decimal? LimiteAcumulado = 0;

        private void cboIdConcepto_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                TotalAcumulado = 0;
                LimiteAcumulado = 0;
                Int64 vIdConcepto = Convert.ToInt64(cboIdConcepto.EditValue != null ? cboIdConcepto.EditValue.ToString() : "-1");
                if (vIdConcepto > 0)
                {
                    DataRow row = gridLookUpEdit1View.GetDataRow(gridLookUpEdit1View.FocusedRowHandle);
                    LimiteAcumulado = Convert.ToInt32(row[16]);
                    this.spSoloRespuesta1.stpFactSelObtenerAcumuladoFactura(Convert.ToInt64(cboIdConcepto.EditValue.ToString()), pFechaPagoD, ref TotalAcumulado);
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

        private void Cambio()
       {
            if (pBFLAG == "R")
            {
                decimal pCambio = 0;

                if (pMoneda != pMonedaOri)
                {
                    pCambio = (Convert.ToDecimal(txtPrecio.Text.Replace("$", "")) * Convert.ToDecimal(txtCambio.Text.Replace("$", "")));
                    //txtConMoneda.Text = pCambio.ToString("N2");// (Math.Truncate(pCambio * 100) / 100).ToString();
                    txtConMoneda.Text = (Math.Truncate(pCambio * 100) / 100).ToString();
                }
                else
                {
                    txtConMoneda.Text = txtPrecio.Text;
                }
            }
            else
            {
                txtConMoneda.Text = txtPrecio.Text;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Agregar = false;
            Close(); // Cerrar Pantalla
        }

        private void frmAgregarConceptos_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'dbSAICBPOFactura.vwFactClaveUnidad' table. You can move, or remove it, as needed.
                this.vwFactCatClaveUnidadTableAdapter.Fill(this.dbSAICBPOFactura.vwFactCatClaveUnidad);

                this.stpFactSelConceptoTenedoraBeneficiarioFiltro2022TableAdapter.Fill(dbSAICBPOFactura.stpFactSelConceptoTenedoraBeneficiarioFiltro2022, 2, pIdTipoBeneficiario, pIdBeneficiario, pIdUsoCFDI, pIdFronting, pConRetencion, pBFLAG);
                txtPrecio.Text = pUnidad.ToString();

                lblFolioFactura.Text = pFOLIOSERIE;

                if (pIVAGlobal == "1")
                {
                    txtIVAPor.ReadOnly = true;
                    txtIVAPor.Text = "16";
                }
                else
                {
                    txtIVAPor.ReadOnly = false;
                    txtIVAPor.Text = pIVAGlobal;
                }

                txtPrecio.Text = pUnitario.ToString();
                txtCambio.Text = pTipoCambio.ToString();
                // C= Control, N=Normal, NC= Nota de Credito Normal, A1-Anticipo, A2-Anticipo Servicio Entregado, A3-Nota de Credito Anticipo
                switch (pBFLAG)
                {
                    case "C":
                        txtCantidad.Text = "1";
                        txtCantidad.ReadOnly = true;
                        txtPrecio.ReadOnly = true;
                        pRestoPago = pUnitario;
                        txtDescuentoISN.Enabled = true;
                        lblFolioFactura.Enabled = false;
                        txtRIVA.Enabled = false;
                        break;
                    case "R":
                        txtCantidad.Text = "1";
                        txtCantidad.ReadOnly = true;
                        txtIVAPor.Text = pIVAPorc;
                        cbUnidad.EditValue = 3;
                        cbUnidad.ReadOnly = true;
                        cboIdConcepto.ReadOnly = true;
                        txtPrecio.Text = pRestoPago.ToString();
                        txtDescuentoISN.Enabled = false;
                        lblFolioFactura.Enabled = true;
                        txtRIVA.Enabled = false;
                        if (pMoneda != pMonedaOri)
                            txtCambio.Enabled = true;
                        else
                            txtCambio.Enabled = false;
                        break;
                    case "G":
                        txtCantidad.Text = "1";
                        txtCantidad.ReadOnly = true;
                        cbUnidad.EditValue = 3;
                        cbUnidad.ReadOnly = true;
                        break;
                    case "NS":
                        txtPrecio.Text = pRestoPago.ToString();
                        txtRIVA.Enabled = false;
                        break;
                    case "GS":
                        txtPrecio.Text = pRestoPago.ToString();
                        txtRIVA.Enabled = false;
                        break;
                    case "NC":
                        txtCantidad.Text = "1";
                        txtCantidad.ReadOnly = true;
                        cbUnidad.EditValue = 3;
                        cbUnidad.ReadOnly = true;
                        txtIVAPor.Text = pIVAPorc;
                        txtPrecio.Text = pRestoPago.ToString();
                        txtDescuentoISN.Enabled = true;
                        lblFolioFactura.Enabled = false;
                        txtRIVA.Enabled = true;
                        break;
                    case "NR":
                    case "A1":
                    case "A2":
                        txtIVAPor.Text = pIVAPorc;
                        txtPrecio.Text = pRestoPago.ToString();
                        txtDescuentoISN.Enabled = true;
                        lblFolioFactura.Enabled = false;
                        txtRIVA.Enabled = false;
                        break;
                    case "A3":
                        txtCantidad.Text = "1";
                        txtCantidad.ReadOnly = true;
                        cbUnidad.EditValue = 3;
                        cbUnidad.ReadOnly = true;
                        txtPrecio.Text = pRestoPago.ToString();
                        txtIVAPor.Text = pIVAPorc;
                        txtDescuentoISN.Enabled = false;
                        lblFolioFactura.Enabled = false;
                        txtRIVA.Enabled = false;
                        break;
                }
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
                if (pBFLAG == "R")
                {
                    if (Validator.IsPositiveNumber(txtCantidad) && Validator.IsPresent(cbUnidad) &&
                        Validator.IsPositiveNumber(txtPrecio) && Validator.IsPresent(txtIVAPor) && Validator.IsPositiveOrZeroNumber(txtIVAPor) &&
                        Validator.IsPresent(txtCambio) && Validator.IsPositiveNumber(txtCambio))
                    {

                        pCantidad = Convert.ToDouble(txtCantidad.Text.Replace(".", "").Replace(",", ""));
                        pUnidad = cbUnidad.Text.ToString();
                        pIdUnidad = Convert.ToInt64(cbUnidad.EditValue.ToString());
                        pComplemento = txtComplemento.Text;
                        pUnitarioP = Convert.ToDouble(txtPrecio.Text.Replace("$", ""));//
                        pUnitario = Convert.ToDouble(txtConMoneda.Text.Replace("$", ""));
                        pIdConcepto = 0;
                        pDescFull = cboIdConcepto.Text + " " + pComplemento;
                        pDesc = pComplemento;
                        pIVA = pFlagIVA;
                        if (pExento)
                            IVAPor = 0;
                        else
                        {
                            pIVA = true;
                            IVAPor = Convert.ToDouble(txtIVAPor.Text);
                        }
                        pRetencionIVA = Convert.ToDouble(txtRIVA.Text.Replace("$", ""));
                        Agregar = true;
                        pDescuento = 0;
                        pObjetoImpuesto = false;
                        pTipoCambio = Convert.ToDouble(txtCambio.Text.Replace("$", ""));

                        if (pBFLAG == "N" || pBFLAG == "A1")
                            Close();
                        else if ((pBFLAG == "C" || pBFLAG == "R" || pBFLAG == "NR" || pBFLAG == "NC" || pBFLAG == "A2" || pBFLAG == "A3") && (pCantidad * pUnitario) <= pRestoPago && (pCantidad * Convert.ToDouble(txtConMoneda.Text.Replace(",", "").Replace("$", ""))) <= (pRestoPago))
                        {
                            //Cerrar la Ventana
                            Close();
                        }
                        else
                        {
                            Agregar = false;
                            XtraMessageBox.Show("¡El Concepto debe de ser menor que $" + (pRestoPago).ToString() + "!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                }
                else
                {
                    if (Validator.IsPresent(cbUnidad) && Validator.IsPresent(cboIdConcepto) &&
                       Validator.IsPositiveNumber(txtCantidad) && Validator.IsPositiveNumber(txtPrecio)
                       && Validator.IsPositiveOrZeroNumber(txtIVAPor))
                    {
                        if ((TotalAcumulado + (Convert.ToDecimal(txtPrecio.Text.Replace("$", "")) * Convert.ToDecimal(txtCantidad.Text.Replace(".", "").Replace(",", "")))) <= LimiteAcumulado)
                        {
                            pCantidad = Convert.ToDouble(txtCantidad.Text.Replace(".", "").Replace(",", ""));
                            pUnidad = cbUnidad.Text.ToString();
                            pIdUnidad = Convert.ToInt64(cbUnidad.EditValue.ToString());
                            pComplemento = txtComplemento.Text;
                            pUnitarioP = Convert.ToDouble(txtPrecio.Text.Replace("$", ""));
                            pUnitario = Convert.ToDouble(txtConMoneda.Text.Replace("$", ""));
                            pIdConcepto = Convert.ToInt64(cboIdConcepto.EditValue.ToString());
                            pDescFull = cboIdConcepto.Text + " " + pComplemento;
                            pDesc = pComplemento;
                            DataRow row = gridLookUpEdit1View.GetDataRow(gridLookUpEdit1View.FocusedRowHandle);
                            pRetencion = (bool)row[15];
                            pObjetoImpuesto = (bool)row[19];
                            if ((bool)row[19])
                            {
                                pIVA = false;
                                IVAPor = 0;
                                pRetencionIVA = 0;
                            }
                            else
                            {
                                pIVA = (bool)row[14];
                                IVAPor = Convert.ToDouble(txtIVAPor.Text);
                                pRetencionIVA = Convert.ToDouble(txtRIVA.Text.Replace("$", ""));
                            }

                            Agregar = true;
                            pDescuento = Convert.ToDouble(txtDescuentoISN.Text);
                            pTipoCambio = Convert.ToDouble(txtCambio.Text.Replace("$", ""));


                            if (pBFLAG == "N" || pBFLAG == "A1" || pBFLAG == "NS" || pBFLAG == "G" || pBFLAG == "GS")
                                Close();
                            else if ((pBFLAG == "C" || pBFLAG == "R" || pBFLAG == "NC" || pBFLAG == "NR" || pBFLAG == "A2" || pBFLAG == "A3") && (pCantidad * pUnitario) <= pRestoPago && (pCantidad * Convert.ToDouble(txtConMoneda.Text.Replace(",", "").Replace("$", ""))) <= (pRestoPago))
                            {
                                if (pBFLAG != "NC" && pBFLAG != "A2" && pBFLAG != "A3")
                                    //Cerrar la Ventana
                                    Close();
                                else if ((pBFLAG == "NC" || pBFLAG == "A2" || pBFLAG == "A3") && pExento != (bool)row[14])
                                    //Cerrar la Ventana
                                    Close();
                                else
                                    XtraMessageBox.Show("¡El Concepto no puede ser utilizado por la diferencia de IVA!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                Agregar = false;
                                XtraMessageBox.Show("¡El Concepto debe de ser menor que $" + pRestoPago.ToString() + "!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            Agregar = false;
                            XtraMessageBox.Show("¡El Concepto supero el limite de " + Convert.ToDecimal(LimiteAcumulado).ToString("C2") + " permitido.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
