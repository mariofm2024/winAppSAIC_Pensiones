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
using winAppSAIC.UtileriasLocal;

namespace winAppSAIC.ControlOperaciones
{
    public partial class frmNuevoControlOperaciones : DevExpress.XtraEditors.XtraForm
    {
        string Id = "", Id2 = "", IdTipoNomina = "", TieneIVA = "16", IdMoneda = "", TipoCambio = "", LotesSA = "", LotesSC = "", RFCCliente="";
        bool TComisionN = false, TComisionCS = false, TComisionISR = false, TComisionISN = false, TComisionAsi = false, TMaquilaComision = false, TMaquilaCF = false, EstatusIVA = false;
        double PCTBPO = 0, PCTASimilados = 0, PCTCucas = 0, PCTCucasP = 0, PCTEfectivo = 0, PCTEfectivoP = 0, PCTTarjeta = 0, PCTTarjetaP = 0, PCTSeguros = 0, PCTSegurosP = 0, PCTProveedor = 0, PCTProveedorP = 0, PCTGasto = 0, PCTGastoP = 0, PCTOtro = 0, PCTOtroP = 0;
        double TotalImpuestos = 0, pTotalObligaciones = 0;
        double TotalNomina = 0, TotalAlimentos = 0, TotalNDed = 0, TotalCNomina = 0, TotalCAliemtos = 0, TotalCS = 0, TotalCISR = 0, TotalCISN = 0, TotalComision = 0, TotalNoNomina = 0, TotalMaquilaComision = 0, TotalMaquilaComisionA = 0, TotalMaquilaCJ = 0;

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvDetail.GetSelectedRows().Count() > 0)
                {
                    gvDetail.DeleteSelectedRows();
                    Totales();
                }
                else
                    XtraMessageBox.Show("¡Debe de Seleccionar por lo menos un Concepto!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbTipoProducto.Focus();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Totales()
        {
            decimal Total = 0, TotalCADN = 0, TotalCProv = 0; 
            DataRow row = null;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                row = dt.Rows[i];
                Total = Total + Convert.ToDecimal(row[7].ToString());
                TotalCADN = TotalCADN + Convert.ToDecimal(row[8].ToString());
                TotalCProv = TotalCProv + Convert.ToDecimal(row[9].ToString());
            }
            
            txtTAsimilados.Text = Convert.ToDecimal(Total).ToString("C");
            txtTCAsimilados.Text = Convert.ToDecimal(TotalCADN).ToString("C");
            txtTCAsimiladosProv.Text = Convert.ToDecimal(TotalCProv).ToString("C");


            Suma();

            txtImporte.EditValue = Convert.ToDecimal(txtTotal.EditValue.ToString().Replace("$", ""));

        }

        int? TieneIVAFronting = 0;

        DataTable dt = new DataTable();
        /// <summary>
        /// Metodo que nos Crea Tablas para las Transacciones
        /// </summary>
        private void CrearTabla()
        {
            dt = new DataTable();
            dt.TableName = "Productos";
            dt.Columns.Add("colIdTabla", typeof(Int64));
            dt.Columns.Add("colIdProducto", typeof(Int32));
            dt.Columns.Add("colProducto", typeof(String));            
            dt.Columns.Add("colIdTenedora", typeof(Int32));
            dt.Columns.Add("colTenedora", typeof(String));
            dt.Columns.Add("colIdBanco", typeof(int));
            dt.Columns.Add("colBanco", typeof(String));
            dt.Columns.Add("colTotalPagar", typeof(Decimal));
            dt.Columns.Add("colCom", typeof(Decimal));
            dt.Columns.Add("colComP", typeof(Decimal));
            dt.Columns.Add("colLotes", typeof(String));
            dt.Columns.Add("colLotesTotal", typeof(Decimal));
        }

        private void cbPeriodoNomina_EditValueChanged(object sender, EventArgs e)
        {
            //TipoCarga(false);
            if (btnConLotes.Visible == true)
            {
                if (cbPeriodoNomina.Text.Contains("ASIMILADOS") || cbPeriodoNomina.Text == "HONORARIOS")
                {
                    txtDescripcion.Text = cbPeriodoNomina.Text;
                    grpDesc.Enabled = false;
                    grpTNomina.Enabled = true;
                }
                else
                {
                    txtDescripcion.Text = "";
                    grpDesc.Enabled = true;
                    grpTNomina.Enabled = false;
                    Limpiagrupo();
                    if (cbPeriodoNomina.Text == "CONTROL DEPOSITO" || cbPeriodoNomina.Text == "OTROS C/COMISION")
                    {
                        grpTNomina.Enabled = true;
                    }

                }
            }
        }


        private void cbMoneda_EditValueChanged(object sender, EventArgs e)
        {
            if (cbMoneda.Text == "MXP")
            {
                txtCambio.Text = "1";
                txtCambio.ReadOnly = true;
            }
            else
            {
                txtCambio.ReadOnly = false;
            }
        }

        private void txtIVA_EditValueChanged(object sender, EventArgs e)
        {
            Suma();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                bool bflag = true;
                //obtener No. de Version CFDI
                if (Validator.IsPresent(cbTipoProducto) && Validator.IsPresent(cbEProducto) && Validator.IsPresent(cbBancoProducto) && Validator.IsPositiveOrZeroNumber(txtMoProducto))
                {
                    if (cbTipoProducto.Text.Contains("ASIMILADOS"))
                        if (TComisionAsi)
                            bflag = true;
                        else
                            bflag = false;

                    if (bflag)
                    {

                        if (cbTipoProducto.Text.Contains("ASIMILADOS"))
                        {
                            if (gridView14.SelectedRowsCount > 0)
                                bflag = true;
                            else
                                bflag = false;
                        }
                        if (bflag)
                        {
                            DataRow dr = dt.NewRow();
                            dr["colIdTabla"] = Convert.ToInt64(dt.Rows.Count + 1);
                            dr["colIdProducto"] = Convert.ToInt64(cbTipoProducto.EditValue);
                            dr["colProducto"] = cbTipoProducto.SelectedText;
                            dr["colIdTenedora"] = Convert.ToInt64(cbEProducto.EditValue);
                            dr["colTenedora"] = cbEProducto.SelectedText;
                            dr["colIdBanco"] = Convert.ToInt64(cbBancoProducto.EditValue);
                            dr["colBanco"] = cbBancoProducto.SelectedText;
                            dr["colTotalPagar"] = Convert.ToDecimal(txtMoProducto.Text);

                            String LotesAsimilados = "";
                            decimal TotalLotesAsimilados = 0;
                            if (cbLotesAsimilados.Enabled)
                            {
                                DataRow row = null;
                                foreach (int indice in gridView14.GetSelectedRows())
                                {
                                    row = gridView14.GetDataRow(indice);
                                    LotesAsimilados = LotesAsimilados + row[0].ToString() + ",";
                                    TotalLotesAsimilados = TotalLotesAsimilados + Convert.ToDecimal(row[7].ToString());
                                }
                                txtMoProducto.Text = TotalLotesAsimilados.ToString();
                                dr["colTotalPagar"] = TotalLotesAsimilados;
                            }

                            dr["colLotes"] = LotesAsimilados;
                            dr["colLotesTotal"] = TotalLotesAsimilados;


                            txtTAsimilados.Text = Convert.ToDecimal(Convert.ToDecimal(txtTAsimilados.Text.Replace("$", "").ToString()) + Convert.ToDecimal(txtMoProducto.Text.Replace("$", "").ToString())).ToString("C");

                            if (cbTipoProducto.Text.Contains("ASIMILADOS") || cbTipoProducto.Text == "HONORARIOS")
                            {

                                dr["colCom"] = Convert.ToDecimal(((Convert.ToDouble(txtMoProducto.Text.Replace("$", "")) / 100) * PCTASimilados));
                                dr["colComP"] = 0;
                                txtTCAsimilados.Text = Convert.ToDecimal(Convert.ToDouble(txtTCAsimilados.Text.Replace("$", "")) + ((Convert.ToDouble(txtMoProducto.Text.Replace("$", "")) / 100) * PCTASimilados)).ToString("C");
                                txtTCAsimiladosProv.Text = Convert.ToDecimal(Convert.ToDouble(txtTCAsimiladosProv.Text.Replace("$", "")) + 0).ToString("C");
                            }
                            else if (cbTipoProducto.Text == "CUCAS")
                            {
                                dr["colCom"] = Convert.ToDecimal(((Convert.ToDouble(txtMoProducto.Text.Replace("$", "")) / 100) * PCTCucas));
                                dr["colComP"] = Convert.ToDecimal(((Convert.ToDouble(txtMoProducto.Text.Replace("$", "")) / 100) * PCTCucasP));
                                txtTCAsimilados.Text = Convert.ToDecimal(Convert.ToDouble(txtTCAsimilados.Text.Replace("$", "")) + ((Convert.ToDouble(txtMoProducto.Text.Replace("$", "")) / 100) * PCTCucas)).ToString("C");
                                txtTCAsimiladosProv.Text = Convert.ToDecimal(Convert.ToDouble(txtTCAsimiladosProv.Text.Replace("$", "")) + ((Convert.ToDouble(txtMoProducto.Text.Replace("$", "")) / 100) * PCTCucasP)).ToString("C");
                            }
                            else if (cbTipoProducto.Text == "EFECTIVO")
                            {
                                dr["colCom"] = Convert.ToDecimal(((Convert.ToDouble(txtMoProducto.Text.Replace("$", "")) / 100) * PCTEfectivo));
                                dr["colComP"] = Convert.ToDecimal(((Convert.ToDouble(txtMoProducto.Text.Replace("$", "")) / 100) * PCTEfectivoP));
                                txtTCAsimilados.Text = Convert.ToDecimal(Convert.ToDouble(txtTCAsimilados.Text.Replace("$", "")) + ((Convert.ToDouble(txtMoProducto.Text.Replace("$", "")) / 100) * PCTEfectivo)).ToString("C");
                                txtTCAsimiladosProv.Text = Convert.ToDecimal(Convert.ToDouble(txtTCAsimiladosProv.Text.Replace("$", "")) + ((Convert.ToDouble(txtMoProducto.Text.Replace("$", "")) / 100) * PCTEfectivoP)).ToString("C");
                            }
                            else if (cbTipoProducto.Text == "TARJETA")
                            {
                                dr["colCom"] = Convert.ToDecimal(((Convert.ToDouble(txtMoProducto.Text.Replace("$", "")) / 100) * PCTTarjeta));
                                dr["colComP"] = Convert.ToDecimal(((Convert.ToDouble(txtMoProducto.Text.Replace("$", "")) / 100) * PCTTarjetaP));
                                txtTCAsimilados.Text = Convert.ToDecimal(Convert.ToDouble(txtTCAsimilados.Text.Replace("$", "")) + ((Convert.ToDouble(txtMoProducto.Text.Replace("$", "")) / 100) * PCTTarjeta)).ToString("C");
                                txtTCAsimiladosProv.Text = Convert.ToDecimal(Convert.ToDouble(txtTCAsimiladosProv.Text.Replace("$", "")) + ((Convert.ToDouble(txtMoProducto.Text.Replace("$", "")) / 100) * PCTTarjetaP)).ToString("C");
                            }
                            else if (cbTipoProducto.Text == "SEGUROS")
                            {
                                dr["colCom"] = Convert.ToDecimal(((Convert.ToDouble(txtMoProducto.Text.Replace("$", "")) / 100) * PCTSeguros));
                                dr["colComP"] = Convert.ToDecimal(((Convert.ToDouble(txtMoProducto.Text.Replace("$", "")) / 100) * PCTSegurosP));
                                txtTCAsimilados.Text = Convert.ToDecimal(Convert.ToDouble(txtTCAsimilados.Text.Replace("$", "")) + ((Convert.ToDouble(txtMoProducto.Text.Replace("$", "")) / 100) * PCTSeguros)).ToString("C");
                                txtTCAsimiladosProv.Text = Convert.ToDecimal(Convert.ToDouble(txtTCAsimiladosProv.Text.Replace("$", "")) + ((Convert.ToDouble(txtMoProducto.Text.Replace("$", "")) / 100) * PCTSegurosP)).ToString("C");
                            }
                            else if (cbTipoProducto.Text == "PROVEEDOR")
                            {
                                dr["colCom"] = Convert.ToDecimal(((Convert.ToDouble(txtMoProducto.Text.Replace("$", "")) / 100) * PCTProveedor));
                                dr["colComP"] = Convert.ToDecimal(((Convert.ToDouble(txtMoProducto.Text.Replace("$", "")) / 100) * PCTProveedorP));
                                txtTCAsimilados.Text = Convert.ToDecimal(Convert.ToDouble(txtTCAsimilados.Text.Replace("$", "")) + ((Convert.ToDouble(txtMoProducto.Text.Replace("$", "")) / 100) * PCTProveedor)).ToString("C");
                                txtTCAsimiladosProv.Text = Convert.ToDecimal(Convert.ToDouble(txtTCAsimiladosProv.Text.Replace("$", "")) + ((Convert.ToDouble(txtMoProducto.Text.Replace("$", "")) / 100) * PCTProveedorP)).ToString("C");
                            }
                            else if (cbTipoProducto.Text == "GASTO")
                            {
                                dr["colCom"] = Convert.ToDecimal(((Convert.ToDouble(txtMoProducto.Text.Replace("$", "")) / 100) * PCTGasto));
                                dr["colComP"] = Convert.ToDecimal(((Convert.ToDouble(txtMoProducto.Text.Replace("$", "")) / 100) * PCTGastoP));
                                txtTCAsimilados.Text = Convert.ToDecimal(Convert.ToDouble(txtTCAsimilados.Text.Replace("$", "")) + ((Convert.ToDouble(txtMoProducto.Text.Replace("$", "")) / 100) * PCTGasto)).ToString("C");
                                txtTCAsimiladosProv.Text = Convert.ToDecimal(Convert.ToDouble(txtTCAsimiladosProv.Text.Replace("$", "")) + ((Convert.ToDouble(txtMoProducto.Text.Replace("$", "")) / 100) * PCTGastoP)).ToString("C");
                            }
                            else
                            {
                                dr["colCom"] = Convert.ToDecimal(((Convert.ToDouble(txtMoProducto.Text.Replace("$", "")) / 100) * PCTOtro));
                                dr["colComP"] = Convert.ToDecimal(((Convert.ToDouble(txtMoProducto.Text.Replace("$", "")) / 100) * PCTOtroP));
                                txtTCAsimilados.Text = Convert.ToDecimal(Convert.ToDouble(txtTCAsimilados.Text.Replace("$", "")) + ((Convert.ToDouble(txtMoProducto.Text.Replace("$", "")) / 100) * PCTOtro)).ToString("C");
                                txtTCAsimiladosProv.Text = Convert.ToDecimal(Convert.ToDouble(txtTCAsimiladosProv.Text.Replace("$", "")) + ((Convert.ToDouble(txtMoProducto.Text.Replace("$", "")) / 100) * PCTOtroP)).ToString("C");
                            }

                            dt.Rows.Add(dr);

                            Suma();

                            txtImporte.EditValue = Convert.ToDecimal(txtTotal.EditValue.ToString().Replace("$", ""));


                            gvProductos.DataSource = dt;
                            cbTipoProducto.EditValue = -1;
                            cbEProducto.EditValue = -1;
                            cbBancoProducto.EditValue = -1;
                            txtMoProducto.Text = "0";
                            dbSAICAsimilados.stpSelLoteCargaNominaParaControl.Clear();
                            cbTipoProducto.Focus();
                        }
                        else
                        {
                            XtraMessageBox.Show("Debe de Seleccionar por lo menos un Lote de Asimilados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("El Cliente no tiene Activo la Bandera de Asimilados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkRetencion_CheckedChanged(object sender, EventArgs e)
        {
            Suma();
        }

        public frmNuevoControlOperaciones()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Close(); //SALIR
        }

        private void Limpiar()
        {
            //Limpiar 
            cbFronting1.EditValue = -1;
            txtMo1.Text = "0";
            cbBanco1.EditValue = -1;

            cbFronting2.EditValue = -1;
            txtMo2.Text = "0";
            cbBanco2.EditValue = -1;

            cbFronting3.EditValue = -1;
            txtMo3.Text = "0";
            cbBanco3.EditValue = -1;

            cbFronting4.EditValue = -1;
            txtMo4.Text = "0";
            cbBanco4.EditValue = -1;

            cbFronting5.EditValue = -1;
            txtMo5.Text = "0";
            cbBanco5.EditValue = -1;

            cbEProducto.EditValue = -1;
            txtMoProducto.Text = "0";
            cbBancoProducto.EditValue = -1;

            TotalNomina = 0; TotalNoNomina = 0; TotalAlimentos = 0;
            TotalCNomina = 0; TotalCAliemtos = 0;
            TotalCS = 0; TotalCISR = 0; TotalCISN = 0;
            TotalComision = 0;
            LotesSA = "";
            LotesSC = "";
            TotalImpuestos = 0;
            pTotalObligaciones = 0;
            cbMoneda.EditValue = -1;
            txtCambio.Text = "1";

            cbCliente.Focus();

            dt.Clear();
        }

        private void Limpiagrupo()
        {
            txtTNomina.Text = "0";
            txtTAlimentos.Text = "0";
            txtTComision.Text = "0";
            txtTAsimilados.Text = "0";
            txtTCAsimilados.Text = "0";
            txtTCAsimiladosProv.Text = "0";
            txtNoEmpleados.Text = "0";
        }

        private void TipoCarga(bool bflag)
        {
            // TODO: This line of code loads data into the 'dbSAICBPODataSet.stpSelTipoPeriodoNomina' table. You can move, or remove it, as needed.
            this.stpFactSelTipoPeriodoNominaNCTableAdapter.Fill(this.dbSAICBPOFactura.stpFactSelTipoPeriodoNominaNC, Convert.ToInt16(bflag));

            this.stpFactSelTipoPeriodoNominaNC1TableAdapter.Fill(this.dbSAICBPOFactura.stpFactSelTipoPeriodoNominaNC1, 2);
            this.stpFactSelTipoPeriodoNominaNC2TableAdapter.Fill(this.dbSAICBPOFactura.stpFactSelTipoPeriodoNominaNC2, 3);

            grpSA.Enabled = bflag;
            grpSC.Enabled = bflag;
            grpTNomina.Enabled = bflag;
            btnSinLotes.Visible = bflag;
            btnConLotes.Visible = !bflag;

            grpDesc.Enabled = !bflag;

            chkRetencion.Checked = false;

            LotesSA = "";
            LotesSC = "";

            txtDescripcion.Text = "";
            txtImporte.Text = "0";
            txtTAsimilados.Text = Convert.ToDecimal("0").ToString("C");
            txtTCAsimilados.Text = Convert.ToDecimal("0").ToString("C");
            txtTCAsimiladosProv.Text = Convert.ToDecimal("0").ToString("C");
            dt.Clear();
            gridView1.ClearSelection();
            gridView2.ClearSelection();


            cbEProducto.EditValue = -1;
            if (btnConLotes.Visible)
                if (cbPeriodoNomina.Text.Contains("ASIMILADOS") || cbPeriodoNomina.Text == "HONORARIOS")
                {
                    txtDescripcion.Text = cbPeriodoNomina.Text;
                    grpDesc.Enabled = false;
                    grpTNomina.Enabled = true;
                }
                else
                {
                    if (cbPeriodoNomina.Text == "CONTROL DEPOSITO" || cbPeriodoNomina.Text == "OTROS C/COMISION")
                    {
                        grpTNomina.Enabled = true;
                    }
                    txtDescripcion.Text = "";
                }

            cbEProducto.Enabled = true;
            txtMoProducto.Enabled = true;
            cbBancoProducto.Enabled = true;


            if (cbPeriodoNomina.Text.Contains("MAQUILA CUOTA FIJA"))
            {
                lblNoEmpleados.Visible = true;
                txtNoEmpleados.Visible = true;
            }
            else
            {
                lblNoEmpleados.Visible = false;
                txtNoEmpleados.Visible = false;
            }


            if (EstatusIVA == false)
            {
                ckIVA.Checked = true;
                ckIVA.Enabled = false;
                txtIVA.Text = Convert.ToDecimal("0").ToString("C");

                txtIVA.ReadOnly = true;
                txtIVAPor.Enabled = false;
                txtIVAPor.Text = TieneIVA == "1" ? "16" : TieneIVA;
            }
            else
            {
                if (TieneIVA == "1")
                {
                    txtIVAPor.Enabled = true;
                    txtIVAPor.Text = TieneIVA;
                }
                else
                {
                    txtIVAPor.Enabled = false;
                    txtIVAPor.Text = TieneIVA;
                }
                ckIVA.Enabled = true;
                ckIVA.Checked = true;
            }
        }

        public void ActivarFronting()
        {
            if (TieneIVAFronting == 1)
            {
                txtIVAPor.Enabled = true;
                txtIVAPor.Text = TieneIVA;
            }
            else
            {
                txtIVAPor.Enabled = false;
                txtIVAPor.Text = TieneIVA;
            }

        }

        private long? Cargar(long? IdControlOperacion)
        {
            Int32 pCliente = (Int32)cbCliente.EditValue;

            Int32 pFronting1 = (Int32)cbFronting1.EditValue;
            decimal pMo1 = (decimal)txtMo1.EditValue;
            Int32 pBanco1 = Convert.ToInt32(string.IsNullOrEmpty(cbBanco1.EditValue.ToString()) ? "-1" : cbBanco1.EditValue);

            decimal pMo2 = 0;
            Int32 pBanco2 = -1;

            Int32 pFronting2 = Convert.ToInt32(cbFronting2.EditValue != null && string.IsNullOrEmpty(cbFronting2.EditValue.ToString()) ? "-1" : cbFronting2.EditValue);

            if (pFronting2 == 0)
                pFronting2 = -1;

            if (pFronting2 != -1)
            {
                pMo2 = Convert.ToDecimal(string.IsNullOrEmpty(txtMo2.EditValue.ToString()) ? "0" : txtMo2.EditValue);
                pBanco2 = Convert.ToInt32(string.IsNullOrEmpty(cbBanco2.EditValue.ToString()) ? "-1" : cbBanco2.EditValue);
            }

            decimal pMo3 = 0;
            Int32 pBanco3 = -1;

            Int32 pFronting3 = Convert.ToInt32(cbFronting3.EditValue != null && string.IsNullOrEmpty(cbFronting3.EditValue.ToString()) ? "-1" : cbFronting3.EditValue);
            if (pFronting3 == 0)
                pFronting3 = -1;

            if (pFronting3 != -1)
            {
                pMo3 = Convert.ToDecimal(string.IsNullOrEmpty(txtMo3.EditValue.ToString()) ? "0" : txtMo3.EditValue);
                pBanco3 = Convert.ToInt32(string.IsNullOrEmpty(cbBanco3.EditValue.ToString()) ? "-1" : cbBanco3.EditValue);
            }

            decimal pMo4 = 0;
            Int32 pBanco4 = -1;

            Int32 pFronting4 = Convert.ToInt32(cbFronting4.EditValue != null && string.IsNullOrEmpty(cbFronting4.EditValue.ToString()) ? "-1" : cbFronting4.EditValue);
            if (pFronting4 == 0)
                pFronting4 = -1;
            if (pFronting4 != -1)
            {
                pMo4 = Convert.ToDecimal(string.IsNullOrEmpty(txtMo4.EditValue.ToString()) ? "0" : txtMo4.EditValue);
                pBanco4 = Convert.ToInt32(string.IsNullOrEmpty(cbBanco4.EditValue.ToString()) ? "-1" : cbBanco4.EditValue);
            }

            decimal pMo5 = 0;
            Int32 pBanco5 = -1;

            Int32 pFronting5 = Convert.ToInt32(cbFronting5.EditValue != null && string.IsNullOrEmpty(cbFronting5.EditValue.ToString()) ? "-1" : cbFronting5.EditValue);
            if (pFronting5 == 0)
                pFronting5 = -1;
            if (pFronting5 != -1)
            {
                pMo5 = Convert.ToDecimal(string.IsNullOrEmpty(txtMo5.EditValue.ToString()) ? "0" : txtMo5.EditValue);
                pBanco5 = Convert.ToInt32(string.IsNullOrEmpty(cbBanco5.EditValue.ToString()) ? "-1" : cbBanco5.EditValue);
            }
            

            Int32 pSC = -1;
            decimal pTNomina = Convert.ToDecimal(string.IsNullOrEmpty(txtTNomina.Text) ? "0" : txtTNomina.Text.Replace("$", ""));
            decimal pTAlimentos = Convert.ToDecimal(string.IsNullOrEmpty(txtTAlimentos.Text) ? "0" : txtTAlimentos.Text.Replace("$", ""));
            decimal pTASimilados = Convert.ToDecimal(string.IsNullOrEmpty(txtTAsimilados.Text) ? "0" : txtTAsimilados.Text.Replace("$", ""));
            decimal pTComis = Convert.ToDecimal(string.IsNullOrEmpty(txtTComision.Text) ? "0" : txtTComision.Text.Replace("$", ""));
            decimal pTCASimi = Convert.ToDecimal(string.IsNullOrEmpty(txtTCAsimilados.Text) ? "0" : txtTCAsimilados.Text.Replace("$", ""))+ Convert.ToDecimal(string.IsNullOrEmpty(txtTCAsimiladosProv.Text) ? "0" : txtTCAsimiladosProv.Text.Replace("$", ""));
            decimal pSubtotal = Convert.ToDecimal(string.IsNullOrEmpty(txtSubtotal.Text) ? "0" : txtSubtotal.Text.Replace("$", ""));
            decimal pIva = Convert.ToDecimal(string.IsNullOrEmpty(txtIVA.Text) ? "0" : txtIVA.Text.Replace("$", ""));

            int PorIVA = 0;
            if (ckIVA.Checked == true)
                PorIVA = Convert.ToInt16(txtIVAPor.Text);
            else
                PorIVA = 0;

            decimal Retencion = 0;
            if (chkRetencion.Checked == true)
                Retencion = Convert.ToDecimal(txtRetencion.Text.Replace("$", ""));
            else
                Retencion = 0;
            decimal pTotal = Convert.ToDecimal(string.IsNullOrEmpty(txtTotal.Text) ? "0" : txtTotal.Text.Replace("$", ""));
            string FIni = Convert.ToDateTime(dtFechaInicio.Text).Year.ToString() + "-" + Convert.ToDateTime(dtFechaInicio.Text).Month.ToString() + "-" + Convert.ToDateTime(dtFechaInicio.Text).Day.ToString();
            string FFin = Convert.ToDateTime(dtFechaFin.Text).Year.ToString() + "-" + Convert.ToDateTime(dtFechaFin.Text).Month.ToString() + "-" + Convert.ToDateTime(dtFechaFin.Text).Day.ToString();
            string pobser = txtObservaciones.Text;
            string Moneda = cbMoneda.EditValue.ToString();
            decimal pTipoCambio = Convert.ToDecimal(txtCambio.Text);
            Int64 pIdControlRelac = Convert.ToInt32(cbControlRelac.EditValue != null && string.IsNullOrEmpty(cbControlRelac.EditValue.ToString()) ? "0" : cbControlRelac.EditValue);

            spSoloRespuesta1.stpFactInsControlOperacionesAPP2023(pCliente, pFronting1, pMo1, pBanco1, pFronting2, pMo2, pBanco2, pFronting3, pMo3, pBanco3, pFronting4, pMo4, pBanco4, pFronting5, pMo5, pBanco5, FIni, FFin, 
                LotesSA, LotesSC, txtDescripcion.Text, Convert.ToInt16(cbPeriodoNomina.EditValue.ToString()), pSC, -1, -1, 
                pTNomina, pTAlimentos, pTASimilados, 0, Convert.ToDecimal(TotalImpuestos), Convert.ToDecimal(pTotalObligaciones),
                pTComis, pTCASimi, pSubtotal, pIva, pTotal, Moneda, pTipoCambio, (short)OperadorBD.OperadorGlobal.IdOperador,
                OperadorBD.OperadorGlobal.NombreUsuario, pobser, pIdControlRelac, PorIVA, -1, -1, Retencion, Convert.ToInt16(cbTipoNomina.EditValue.ToString()), ref IdControlOperacion);

            DataRow row = null;
            if (IdControlOperacion > 0)
            {
                int num = 0;
                Int64? pIdFrontin = 0;
                Int64? pIdok = 0;

                for (int i = 0; i < this.dt.Rows.Count; i++)
                {
                    row = this.dt.Rows[i];
                    this.spSoloRespuesta1.stpFactInsCOProductos(IdControlOperacion, Convert.ToInt32(row[1]), Convert.ToInt32(row[3]), Convert.ToInt32(row[5]), Convert.ToDecimal(row[7]), Convert.ToDecimal(row[8]), Convert.ToDecimal(row[9]), OperadorBD.OperadorGlobal.IdOperador, OperadorBD.OperadorGlobal.NombreUsuario, ref pIdFrontin);

                    if (pIdFrontin > 0)
                    {
                        if (row[2].ToString().Contains("ASIMILADOS"))
                        {
                            this.queriesAsimilados1.stpInsControlOperacionesAPP(IdControlOperacion, row[10].ToString(), Convert.ToInt32(row[3]), OperadorBD.OperadorGlobal.IdOperador, OperadorBD.OperadorGlobal.NombreUsuario, ref pIdok);
                            if (pIdok == 1)
                                num++;
                        }
                        else
                            num++;
                    }
                }
                if (this.dt.Rows.Count != num)
                    IdControlOperacion = 0;
            }

            return IdControlOperacion;
        }

        private void Suma()
        {
            TotalComision = 0;

            if (TComisionN == true)
            {
                TotalComision = (((TotalNomina - TotalNoNomina) + TotalCNomina + TotalAlimentos + TotalCAliemtos) / 100) * PCTBPO;
            }
            if (TComisionCS == true)
            {
                TotalComision = TotalComision + ((TotalCS / 100) * PCTBPO);
            }
            if (TComisionISR == true)
            {
                TotalComision = TotalComision + ((TotalCISR / 100) * PCTBPO);
            }
            //if (TComisionISN == true)
            //{
            //    TotalComision = TotalComision + ((TotalCISN / 100) * PCTBPO);
            //}
            if (TMaquilaComision == true && cbPeriodoNomina.Text == "MAQUILA COMISION")
            {
                TotalComision = (((TotalMaquilaComision + TotalMaquilaComisionA) / 100) * PCTBPO);
            }
            if (TMaquilaCF == true && cbPeriodoNomina.Text == "MAQUILA CUOTA FIJA")
            {
                txtNoEmpleados.Text = TotalMaquilaCJ.ToString();
                TotalComision = TotalMaquilaCJ * PCTBPO;
            }

            if (cbPeriodoNomina.Text.Contains("MAQUILA"))
            {
                txtRetencion.Text = Convert.ToDecimal("0").ToString("C");
                txtTNomina.Text = Convert.ToDecimal("0").ToString("C");
                txtTAlimentos.Text = Convert.ToDecimal("0").ToString("C");
                txtTComision.Text = Convert.ToDecimal(TotalComision.ToString()).ToString("C");
                txtTCAsimilados.Text = Convert.ToDecimal("0").ToString("C");
                txtTCAsimiladosProv.Text = Convert.ToDecimal("0").ToString("C");
            }
            else 
            {
                txtRetencion.Text = Convert.ToDecimal("0").ToString("C");
                txtTNomina.Text = Convert.ToDecimal(((TotalNomina - TotalNoNomina) + TotalCNomina + TotalCS + TotalCISR).ToString()).ToString("C");
                txtTAlimentos.Text = Convert.ToDecimal((TotalAlimentos + TotalCAliemtos).ToString()).ToString("C");
                txtTComision.Text = Convert.ToDecimal(TotalComision.ToString()).ToString("C");  
            }

            if (btnSinLotes.Visible)
            {
                txtSubtotal.Text = Convert.ToDecimal(
                                    Convert.ToDouble(string.IsNullOrEmpty(txtTNomina.Text.Replace("$", "")) ? 0 : Convert.ToDouble(txtTNomina.Text.Replace("$", ""))) +
                                    Convert.ToDouble(string.IsNullOrEmpty(txtTAlimentos.Text.Replace("$", "")) ? 0 : Convert.ToDouble(txtTAlimentos.Text.Replace("$", ""))) +
                                    Convert.ToDouble(string.IsNullOrEmpty(txtTComision.Text.Replace("$", "")) ? 0 : Convert.ToDouble(txtTComision.Text.Replace("$", ""))) +
                                    Convert.ToDouble(string.IsNullOrEmpty(txtTAsimilados.Text.Replace("$", "")) ? 0 : Convert.ToDouble(txtTAsimilados.Text.Replace("$", ""))) +
                                    Convert.ToDouble(string.IsNullOrEmpty(txtTCAsimilados.Text.Replace("$", "")) ? 0 : Convert.ToDouble(txtTCAsimilados.Text.Replace("$", ""))) +
                                    Convert.ToDouble(string.IsNullOrEmpty(txtTCAsimiladosProv.Text.Replace("$", "")) ? 0 : Convert.ToDouble(txtTCAsimiladosProv.Text.Replace("$", "")))).ToString("C");


                if (ckIVA.Checked == true)
                {
                    txtIVA.ReadOnly = true;
                    txtIVA.Text = Convert.ToDecimal((Convert.ToDouble(string.IsNullOrEmpty(txtSubtotal.Text.Replace("$", "")) ? 0 : Convert.ToDecimal(txtSubtotal.Text.Replace("$", ""))) / 100) *
                                Convert.ToDouble(string.IsNullOrEmpty(txtIVAPor.Text.Replace("$", "")) ? 0 : Convert.ToDecimal(txtIVAPor.Text.Replace("$", "")))).ToString("C");

                    if (chkRetencion.Checked)
                    {
                        txtRetencion.Text = Convert.ToDecimal((Convert.ToDouble(string.IsNullOrEmpty(txtSubtotal.Text.Replace("$", "")) ? 0 : Convert.ToDecimal(txtSubtotal.Text.Replace("$", ""))) / 100) *
                                             Convert.ToDouble(string.IsNullOrEmpty(txtIVAPor.Text.Replace("$", "")) ? 0 : 6)).ToString("C");
                    }
                    else
                    {
                        txtRetencion.Text = Convert.ToDecimal("0").ToString("C");
                    }

                    txtTotal.Text = Convert.ToDecimal(
                            Convert.ToDouble(string.IsNullOrEmpty(txtSubtotal.Text.Replace("$", "")) ? 0 : Convert.ToDecimal(txtSubtotal.Text.Replace("$", ""))) +
                            Convert.ToDouble(string.IsNullOrEmpty(txtIVA.Text.Replace("$", "")) ? 0 : Convert.ToDecimal(txtIVA.Text.Replace("$", ""))) -
                            Convert.ToDouble(string.IsNullOrEmpty(txtRetencion.Text.Replace("$", "")) ? 0 : Convert.ToDecimal(txtRetencion.Text.Replace("$", "")))
                            ).ToString("C");

                }
                else
                {
                    txtIVA.ReadOnly = false;
                    txtTotal.Text = Convert.ToDecimal(
                                    Convert.ToDouble(string.IsNullOrEmpty(txtSubtotal.Text.Replace("$", "")) ? 0 : Convert.ToDecimal(txtSubtotal.Text.Replace("$", ""))) +
                                    Convert.ToDouble(string.IsNullOrEmpty(txtIVA.Text.Replace("$", "")) ? 0 : Convert.ToDecimal(txtIVA.Text.Replace("$", ""))) -
                                    Convert.ToDouble(string.IsNullOrEmpty(txtRetencion.Text.Replace("$", "")) ? 0 : Convert.ToDecimal(txtRetencion.Text.Replace("$", "")))
                                    ).ToString("C");
                }

                txtImporte.EditValue = 0;
            }
            else
            {
                //if (cbPeriodoNomina.Text.Contains("ASIMILADOS") || cbPeriodoNomina.Text == "HONORARIOS")
                //{
                txtSubtotal.Text = Convert.ToDecimal(
                                    Convert.ToDouble(string.IsNullOrEmpty(txtTAsimilados.Text.Replace("$", "")) ? 0 : Convert.ToDouble(txtTAsimilados.Text.Replace("$", ""))) +
                                    Convert.ToDouble(string.IsNullOrEmpty(txtTCAsimilados.Text.Replace("$", "")) ? 0 : Convert.ToDouble(txtTCAsimilados.Text.Replace("$", ""))) +
                                    Convert.ToDouble(string.IsNullOrEmpty(txtTCAsimiladosProv.Text.Replace("$", "")) ? 0 : Convert.ToDouble(txtTCAsimiladosProv.Text.Replace("$", "")))
                                    ).ToString("C");


                if (ckIVA.Checked == true)
                {
                    if (chkRetencion.Checked == true)
                    {
                        txtIVA.Text = Convert.ToDecimal(Convert.ToDouble(string.IsNullOrEmpty(txtSubtotal.Text.Replace("$", "")) ? 0 : Convert.ToDecimal(txtSubtotal.Text.Replace("$", ""))) *
                                                    (Convert.ToDouble(string.IsNullOrEmpty(txtIVAPor.Text.Replace("$", "")) ? 0 : Convert.ToDecimal(txtIVAPor.Text.Replace("$", ""))) / 100)).ToString("C");

                        txtRetencion.Text = Convert.ToDecimal(Convert.ToDouble(string.IsNullOrEmpty(txtSubtotal.Text.Replace("$", "")) ? 0 : Convert.ToDecimal(txtSubtotal.Text.Replace("$", ""))) *
                                                    (Convert.ToDouble(string.IsNullOrEmpty(txtIVAPor.Text.Replace("$", "")) ? 0 : 6) / 100)).ToString("C");

                        txtTotal.Text = Convert.ToDecimal(
                                    Convert.ToDouble(string.IsNullOrEmpty(txtIVA.Text.Replace("$", "")) ? 0 : Convert.ToDouble(txtIVA.Text.Replace("$", ""))) +
                                    Convert.ToDouble(string.IsNullOrEmpty(txtSubtotal.Text.Replace("$", "")) ? 0 : Convert.ToDouble(txtSubtotal.Text.Replace("$", ""))) -
                                    Convert.ToDouble(string.IsNullOrEmpty(txtRetencion.Text.Replace("$", "")) ? 0 : Convert.ToDecimal(txtRetencion.Text.Replace("$", "")))
                                    ).ToString("C");
                    }
                    else
                    {
                        txtIVA.Text = Convert.ToDecimal(Convert.ToDouble(string.IsNullOrEmpty(txtSubtotal.Text.Replace("$", "")) ? 0 : Convert.ToDecimal(txtSubtotal.Text.Replace("$", ""))) *
                                                   (Convert.ToDouble(string.IsNullOrEmpty(txtIVAPor.Text.Replace("$", "")) ? 0 : Convert.ToDecimal(txtIVAPor.Text.Replace("$", ""))) / 100)).ToString("C");
                        txtTotal.Text = Convert.ToDecimal(
                                    Convert.ToDouble(string.IsNullOrEmpty(txtIVA.Text.Replace("$", "")) ? 0 : Convert.ToDouble(txtIVA.Text.Replace("$", ""))) +
                                    Convert.ToDouble(string.IsNullOrEmpty(txtSubtotal.Text.Replace("$", "")) ? 0 : Convert.ToDouble(txtSubtotal.Text.Replace("$", ""))) -
                                    Convert.ToDouble(string.IsNullOrEmpty(txtRetencion.Text.Replace("$", "")) ? 0 : Convert.ToDecimal(txtRetencion.Text.Replace("$", "")))
                                    ).ToString("C");
                    }
                }
                else
                {
                    txtIVA.Text = Convert.ToDecimal("0").ToString("C");
                    txtTotal.Text = Convert.ToDecimal(txtSubtotal.EditValue.ToString().Replace("$", "")).ToString("C");
                }
                //}
                //else
                //{

                //    if (ckIVA.Checked == true)
                //    {
                //        if (chkRetencion.Checked == true)
                //        {
                //            txtSubtotal.Text = Convert.ToDecimal(Convert.ToDouble(string.IsNullOrEmpty(txtTotal.Text.Replace("$", "")) ? 0 : Convert.ToDecimal(txtTotal.Text.Replace("$", ""))) /
                //                   (1 + (Convert.ToDouble(string.IsNullOrEmpty(txtIVAPor.Text.Replace("$", "")) ? 0 : 10) / 100))).ToString("C");

                //            txtRetencion.Text = Convert.ToDecimal((Convert.ToDouble(string.IsNullOrEmpty(txtSubtotal.Text.Replace("$", "")) ? 0 : Convert.ToDecimal(txtSubtotal.Text.Replace("$", ""))) / 100) *
                //                                Convert.ToDouble(string.IsNullOrEmpty(txtIVAPor.Text.Replace("$", "")) ? 0 : 6)).ToString("C");

                //            txtIVA.Text = Convert.ToDecimal((Convert.ToDouble(string.IsNullOrEmpty(txtSubtotal.Text.Replace("$", "")) ? 0 : Convert.ToDecimal(txtSubtotal.Text.Replace("$", ""))) / 100) *
                //                          Convert.ToDouble(string.IsNullOrEmpty(txtIVAPor.Text.Replace("$", "")) ? 0 : Convert.ToDecimal(txtIVAPor.Text.Replace("$", "")))).ToString("C");
                //        }
                //        else
                //        {
                //            txtSubtotal.Text = Convert.ToDecimal(Convert.ToDouble(string.IsNullOrEmpty(txtTotal.Text.Replace("$", "")) ? 0 : Convert.ToDecimal(txtTotal.Text.Replace("$", ""))) /
                //                   (1 + (Convert.ToDouble(string.IsNullOrEmpty(txtIVAPor.Text.Replace("$", "")) ? 0 : Convert.ToDecimal(txtIVAPor.Text.Replace("$", ""))) / 100))).ToString("C");

                //            txtIVA.Text = Convert.ToDecimal(Convert.ToDouble(string.IsNullOrEmpty(txtTotal.Text.Replace("$", "")) ? 0 : Convert.ToDecimal(txtTotal.Text.Replace("$", ""))) -
                //                            Convert.ToDouble(string.IsNullOrEmpty(txtSubtotal.Text.Replace("$", "")) ? 0 : Convert.ToDecimal(txtSubtotal.Text.Replace("$", "")))).ToString("C");
                //        }
                //    }
                //    else
                //    {
                //        txtSubtotal.Text = Convert.ToDecimal(txtImporte.EditValue.ToString().Replace("$", "")).ToString("C");
                //        txtIVA.Text = Convert.ToDecimal("0").ToString("C");
                //    }
                //    if (cbPeriodoNomina.Text == "CONTROL DEPOSITO" || cbPeriodoNomina.Text == "OTROS C/COMISION")
                //    {
                //        TotalComision = Convert.ToDouble(txtSubtotal.Text.Replace("$", "")) - Convert.ToDouble(string.IsNullOrEmpty(txtSubtotal.Text.Replace("$", "")) ? 0 : Convert.ToDouble(txtSubtotal.Text.Replace("$", ""))) / (1 + PCTBPO / 100);
                //        //TotalComision = (TotalComision / 100) * PCTBPO;                        
                //        txtTComision.Text = Convert.ToDecimal(TotalComision.ToString()).ToString("C");
                //    }

                //}
            }
        }

        private void ObtenerEmpleados()
        {
            TotalMaquilaCJ = 0;

            long? pNoEmp = 0;
            if (cbPeriodoNomina.Text == "MAQUILA CUOTA FIJA")
            {
                spSoloRespuesta1.stpFactSelObtenerEmpleadosUnicos(LotesSA, LotesSC, ref pNoEmp);
                TotalMaquilaCJ = Convert.ToDouble(pNoEmp);
            }
        }

        private void frmNuevoControlOperaciones_Load(object sender, EventArgs e)
        {
           
            try
            {
                splashSMCargando.ShowWaitForm();
                // TODO: This line of code loads data into the 'dbSAICBPODataSet.vwCatCliente' table. You can move, or remove it, as needed.
                this.vwCatClienteTableAdapter.Fill(this.dbSAICBPODataSet.vwCatCliente);
                // TODO: This line of code loads data into the 'dbSAICBPODataSet.vwCatTenedoraSC' table. You can move, or remove it, as needed.
                this.vwCatTenedoraSCTableAdapter.Fill(this.dbSAICBPODataSet.vwCatTenedoraSC);
                // TODO: This line of code loads data into the 'dbSAICBPOFactura.vwCatTenedoraAsimilados' table. You can move, or remove it, as needed.
                this.vwFactCatTenedoraAsimiladosTableAdapter.Fill(this.dbSAICBPOFactura.vwFactCatTenedoraAsimilados);
                // TODO: This line of code loads data into the 'dbSAICBPOFactura.vwFactCatTenedoraAsimilados1' table. You can move, or remove it, as needed.
                this.vwFactCatTenedoraAsimilados1TableAdapter.Fill(this.dbSAICBPOFactura.vwFactCatTenedoraAsimilados1);
                // TODO: This line of code loads data into the 'dbSAICBPOFactura.vwCatMoneda' table. You can move, or remove it, as needed.
                this.vwCatMonedaTableAdapter.Fill(this.dbSAICBPOFactura.vwCatMoneda);

                // Set column widths according to their contents. 
                cbCliente.Properties.View.BestFitColumns();
                // Specify the total dropdown width. 
                cbCliente.Properties.PopupFormWidth = 500;
                // Set column widths according to their contents. 
                cbFronting1.Properties.View.BestFitColumns();
                // Specify the total dropdown width. 
                cbFronting1.Properties.PopupFormWidth = 500;
                // Set column widths according to their contents. 
                cbFronting2.Properties.View.BestFitColumns();
                // Specify the total dropdown width. 
                cbFronting2.Properties.PopupFormWidth = 500;
                // Set column widths according to their contents. 
                cbFronting3.Properties.View.BestFitColumns();
                // Specify the total dropdown width. 
                cbFronting3.Properties.PopupFormWidth = 500;
                // Set column widths according to their contents. 
                cbFronting4.Properties.View.BestFitColumns();
                // Specify the total dropdown width. 
                cbFronting4.Properties.PopupFormWidth = 500;
                // Set column widths according to their contents. 
                cbFronting5.Properties.View.BestFitColumns();
                // Specify the total dropdown width. 
                cbFronting5.Properties.PopupFormWidth = 500;
                // Set column widths according to their contents. 
                cbEProducto.Properties.View.BestFitColumns();
                // Specify the total dropdown width. 
                cbEProducto.Properties.PopupFormWidth = 500;
                // Set column widths according to their contents. 
                cbLotesAsimilados.Properties.View.BestFitColumns();
                // Specify the total dropdown width. 
                cbLotesAsimilados.Properties.PopupFormWidth = 500;

                txtCambio.Text = "1";
                txtCambio.ReadOnly = true;
                dtFechaInicio.Value = DateTime.Now;
                dtFechaFin.Value = DateTime.Now;
                TipoCarga(false);
                CrearTabla();

                splashSMCargando.CloseWaitForm();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                splashSMCargando.CloseWaitForm();
            }
        }

        private void cbCliente_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                //Limpiar Campos
                Limpiar();
             
                //Asignar Valores 
                EstatusIVA = false; TieneIVA = "16"; TComisionN = false; TComisionCS = false; TComisionISR = false;
                TComisionISN = false; TComisionAsi = false; TMaquilaComision = false; TMaquilaCF = false;
                PCTBPO = 0; PCTASimilados = 0; PCTCucas = 0; PCTCucasP = 0;
                PCTEfectivo = 0;  PCTEfectivoP = 0; PCTTarjeta = 0; PCTTarjetaP = 0;
                PCTSeguros = 0; PCTSegurosP = 0; PCTProveedor = 0; PCTProveedorP = 0;
                PCTGasto = 0; PCTGastoP = 0; PCTOtro = 0; PCTOtroP = 0; RFCCliente = "";


                if (Validator.IsPresent(cbPeriodoNomina) && Validator.IsPresent(cbCliente))
                {
                    IdTipoNomina = cbPeriodoNomina.EditValue.ToString();
                    string IdSC = "-1";
                    string IdPeriodo = "-1";

                    Id = cbCliente.EditValue.ToString();

                    GridLookUpEdit lookUp = sender as GridLookUpEdit;
                    DataRowView dataRow = lookUp.GetSelectedDataRow() as DataRowView;
                    if (dataRow != null)
                    {
                        RFCCliente = dataRow["RFC"].ToString(); // Convert.ToString(fila[3].ToString());
                    }
                    

                    if (cbPeriodoNomina.EditValue != null)
                        IdPeriodo = cbPeriodoNomina.EditValue.ToString();
                    string FIni =  Convert.ToDateTime(dtFechaInicio.Text).Year.ToString() + "-" + Convert.ToDateTime(dtFechaInicio.Text).Month.ToString() + "-" + Convert.ToDateTime(dtFechaInicio.Text).Day.ToString();
                    string FFin =  Convert.ToDateTime(dtFechaFin.Text).Year.ToString() + "-" + Convert.ToDateTime(dtFechaFin.Text).Month.ToString() + "-" + Convert.ToDateTime(dtFechaFin.Text).Day.ToString();

                    this.stpFactSelClienteFrontingTableAdapter.Fill(dbSAICBPOFactura.stpFactSelClienteFronting, Id, "-1");
                    this.stpFactSelControlOperacionesRelaTableAdapter.Fill(dbSAICBPOFactura.stpFactSelControlOperacionesRela, Convert.ToInt32(Id), (Int32)OperadorBD.OperadorGlobal.IdOperador);
                    this.stpSelObtenerParametrosClienteTableAdapter.Fill(dbSAICBPOFactura.stpFactSelObtenerParametrosCliente, Convert.ToInt32(Id));

                    dbSAICBPOFactura.stpFactSelLotesParaControlOperacionesSA.Clear();
                    dbSAICBPOFactura.stpFactSelLotesParaControlOperacionesSC.Clear();
                    dgvSA.DataSource = dbSAICBPOFactura.stpFactSelLotesParaControlOperacionesSA;
                    dgvSC.DataSource = dbSAICBPOFactura.stpFactSelLotesParaControlOperacionesSC;

                    this.stpFactSelLotesParaControlOperacionesSATableAdapter.Fill(dbSAICBPOFactura.stpFactSelLotesParaControlOperacionesSA, Convert.ToInt32(Id), Convert.ToInt32(IdSC), (Int32)OperadorBD.OperadorGlobal.IdOperador, Convert.ToInt32(IdPeriodo), FIni, FFin);
                    dgvSA.DataSource = dbSAICBPOFactura.stpFactSelLotesParaControlOperacionesSA;
                    this.stpFactSelLotesParaControlOperacionesSCTableAdapter.Fill(dbSAICBPOFactura.stpFactSelLotesParaControlOperacionesSC, Convert.ToInt32(Id), -1, (Int32)OperadorBD.OperadorGlobal.IdOperador, Convert.ToInt16(IdPeriodo), FIni, FFin);
                    dgvSC.DataSource = dbSAICBPOFactura.stpFactSelLotesParaControlOperacionesSC;

                    if (dbSAICBPOFactura.stpFactSelObtenerParametrosCliente.Count > 0)
                    {
                        //obtener el No. de Items seleccionados
                        DataRow row = null;
                        for (int i = 0; i < dbSAICBPOFactura.stpFactSelObtenerParametrosCliente.Count; i++)
                        {
                            row = dbSAICBPOFactura.stpFactSelObtenerParametrosCliente.Rows[i];
                            if (row[1].ToString() == "NOMINA")
                                TComisionN = true;
                            else if (row[1].ToString() == "COSTO SOCIAL")
                                TComisionCS = true;
                            else if (row[1].ToString() == "ISR")
                                TComisionISR = true;
                            else if (row[1].ToString() == "ISN")
                                TComisionISN = true;
                            else if (row[1].ToString().Contains("ASIMILADOS"))
                                TComisionAsi = true;
                            else if (row[1].ToString().Contains("TOTAL PERCEPCIONES"))
                                TMaquilaComision = true;
                            else if (row[1].ToString().Contains("CUOTA FIJA"))
                                TMaquilaCF = true;

                            PCTBPO = Convert.ToDouble(row[3].ToString());
                            PCTASimilados = Convert.ToDouble(row[4].ToString());

                            EstatusIVA = (bool)row[5];
                            TieneIVA = (row[6].ToString() == "1" ? "16" : row[6].ToString());

                            PCTCucas = Convert.ToDouble(row[7].ToString());
                            PCTCucasP = Convert.ToDouble(row[8].ToString());
                            PCTEfectivo = Convert.ToDouble(row[9].ToString());
                            PCTEfectivoP = Convert.ToDouble(row[10].ToString());
                            PCTTarjeta = Convert.ToDouble(row[11].ToString());
                            PCTTarjetaP = Convert.ToDouble(row[12].ToString());
                            PCTSeguros = Convert.ToDouble(row[13].ToString());
                            PCTSegurosP = Convert.ToDouble(row[14].ToString());
                            PCTProveedor = Convert.ToDouble(row[15].ToString());
                            PCTProveedorP = Convert.ToDouble(row[16].ToString());
                            PCTGasto = Convert.ToDouble(row[17].ToString());
                            PCTGastoP = Convert.ToDouble(row[18].ToString());
                            PCTOtro = Convert.ToDouble(row[19].ToString());
                            PCTOtroP = Convert.ToDouble(row[20].ToString());
                        }
                        TipoCarga(!btnConLotes.Visible);
                    }
                    else
                    {
                        TComisionN = false;
                        TComisionCS = false;
                        TComisionISR = false;
                        TComisionISN = false;
                        TMaquilaComision = false;
                        TMaquilaCF = false;
                        PCTBPO = 0;
                        PCTASimilados = 0;
                        TieneIVA = "16";
                        TComisionAsi = false;

                        PCTCucas = 0;
                        PCTCucasP = 0;
                        PCTEfectivo = 0;
                        PCTEfectivoP = 0;
                        PCTTarjeta = 0;
                        PCTTarjetaP = 0;
                        PCTSeguros = 0;
                        PCTSegurosP = 0;
                        PCTProveedor = 0;
                        PCTProveedorP = 0;
                        PCTGasto = 0;
                        PCTGastoP = 0;
                        PCTOtro = 0;
                        PCTOtroP = 0;

                        TipoCarga(!btnConLotes.Visible);
                    }
                }
                else
                {
                    dbSAICBPOFactura.stpFactSelLotesParaControlOperacionesSA.Clear();
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            try
            {
                bool bandera = false;

                if (Validator.IsPresent(cbCliente) && Validator.IsPresent(cbFronting1) &&
                     Validator.IsPositiveOrZeroNumber(txtMo1) && Validator.IsPresent(cbBanco1) && Validator.IsPresent(cbMoneda)
                     && Validator.IsPositiveNumber(txtCambio)
                     ) //&& dtFechaInicio.Value <= dtFechaFin.Value)
                {
                    if (btnSinLotes.Visible)
                    {
                        if (cbFronting2.EditValue != null && cbFronting2.EditValue.ToString() != "" && cbFronting2.EditValue.ToString() != "-1")
                            if (Validator.IsPositiveOrZeroNumber(txtMo2) && Validator.IsPresent(cbBanco2))
                                if (cbFronting3.EditValue != null && cbFronting3.EditValue.ToString() != "" && cbFronting3.EditValue.ToString() != "-1")
                                    if (Validator.IsPositiveOrZeroNumber(txtMo3) && Validator.IsPresent(cbBanco3))
                                        if (cbFronting4.EditValue != null && cbFronting4.EditValue.ToString() != "" && cbFronting4.EditValue.ToString() != "-1")
                                            if (Validator.IsPositiveOrZeroNumber(txtMo4) && Validator.IsPresent(cbBanco4))
                                                if (cbFronting5.EditValue != null && cbFronting5.EditValue.ToString() != "" && cbFronting5.EditValue.ToString() != "-1")
                                                    if (Validator.IsPositiveOrZeroNumber(txtMo5) && Validator.IsPresent(cbBanco5))
                                                        bandera = true;
                                                    else
                                                        bandera = false;
                                                else
                                                {
                                                    txtMo5.EditValue = 0; cbBanco5.EditValue = -1;
                                                    bandera = true;
                                                }
                                            else
                                                bandera = false;
                                        else
                                        {
                                            txtMo4.EditValue = 0; cbBanco4.EditValue = -1;
                                            bandera = true;
                                        }
                                    else
                                        bandera = false;
                                else
                                {
                                    txtMo3.EditValue = 0; cbBanco3.EditValue = -1;
                                    bandera = true;
                                }
                            else
                                bandera = false;
                        else
                        {
                            txtMo2.EditValue = 0; cbBanco2.EditValue = -1;
                            bandera = true;
                        }
                        if (bandera == true)
                            if (LotesSA != "" || LotesSC != "")
                            {
                                if (txtIVAPor.Text == "16" || txtIVAPor.Text == "0")
                                {
                                    if (Convert.ToDecimal(txtTAsimilados.Text.Replace("$", "")) == 0)
                                        CargarControl();
                                    else if (Convert.ToDecimal(txtTAsimilados.Text.Replace("$", "")) > 0 && Convert.ToDecimal(txtTAsimilados.Text.Replace("$", "")) == Convert.ToDecimal(txtMoProducto.Text.Replace("$", "")) && Validator.IsPresent(cbEProducto) && Validator.IsPresent(cbBancoProducto))
                                        CargarControl();
                                    else if (Convert.ToDecimal(txtTAsimilados.Text.Replace("$", "")) > 0)
                                        CargarControl();
                                }
                                else
                                    XtraMessageBox.Show("Solo se permite 16 y/o 0 %.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                                XtraMessageBox.Show("Debe de Seleccionar por lo menos un Lote.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (cbFronting2.EditValue != null && cbFronting2.EditValue.ToString() != "" && cbFronting2.EditValue.ToString() != "-1")
                            if (Validator.IsPositiveOrZeroNumber(txtMo2) && Validator.IsPresent(cbBanco2))
                                if (cbFronting3.EditValue != null && cbFronting3.EditValue.ToString() != "" && cbFronting3.EditValue.ToString() != "-1")
                                    if (Validator.IsPositiveOrZeroNumber(txtMo3) && Validator.IsPresent(cbBanco3))
                                        if (cbFronting4.EditValue != null && cbFronting4.EditValue.ToString() != "" && cbFronting4.EditValue.ToString() != "-1")
                                            if (Validator.IsPositiveOrZeroNumber(txtMo4) && Validator.IsPresent(cbBanco4))
                                                if (cbFronting5.EditValue != null && cbFronting5.EditValue.ToString() != "" && cbFronting5.EditValue.ToString() != "-1")
                                                    if (Validator.IsPositiveOrZeroNumber(txtMo5) && Validator.IsPresent(cbBanco5))
                                                        bandera = true;
                                                    else
                                                        bandera = false;
                                                else
                                                {
                                                    txtMo5.EditValue = 0; cbBanco5.EditValue = -1;
                                                    bandera = true;
                                                }
                                            else
                                                bandera = false;
                                        else
                                        {
                                            txtMo4.EditValue = 0; cbBanco4.EditValue = -1;
                                            bandera = true;
                                        }
                                    else
                                        bandera = false;
                                else
                                {
                                    txtMo3.EditValue = 0; cbBanco3.EditValue = -1;
                                    bandera = true;
                                }
                            else
                                bandera = false;
                        else
                        {
                            txtMo2.EditValue = 0; cbBanco2.EditValue = -1;
                            bandera = true;
                        }
                        if (bandera == true)
                        {
                            if (txtIVAPor.Text == "16" || txtIVAPor.Text == "0")
                            {
                                if (cbPeriodoNomina.Text.Contains("ASIMILADOS") || cbPeriodoNomina.Text == "HONORARIOS")
                                {
                                    //if ( Convert.ToDecimal(txtTAsimilados.Text.Replace("$", "")) + Convert.ToDecimal(txtTCAsimilados.Text.Replace("$", "")) + Convert.ToDecimal(txtTCAsimiladosProv.Text.Replace("$", "")) == Convert.ToDecimal(txtImporte.Text.Replace("$", "")))
                                    //    CargarControl();
                                    //ELSE
                                    if (Convert.ToDecimal(txtTAsimilados.Text.Replace("$", "")) > 0) //Validator.IsPresent(txtDescripcion) &&
                                        CargarControl();
                                }
                                else
                                {
                                    if ( Validator.IsPositiveNumber(txtImporte)) //Validator.IsPresent(txtDescripcion) &&
                                        CargarControl();
                                }
                            }
                            else
                                XtraMessageBox.Show("Solo se permite 16 y/o 0 %.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarControl()
        {
            long? IdControlOperacion = 0;

            IdControlOperacion = Cargar(IdControlOperacion);
            if (IdControlOperacion != 0)
            {
                XtraMessageBox.Show("¡El alta del Control No.:" + IdControlOperacion.ToString() + " ha sido exitosa!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close(); //SALIR
            }
            else
            {
                XtraMessageBox.Show("¡El alta del Control NO ha sido exitosa!\nContacte a Sistemas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtImporte_EditValueChanged(object sender, EventArgs e)
        {
            Suma();
        }
        
        private void cbFronting1_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                //obtener el renglon completo del Combobox
                if (cbFronting1.EditValue == null || cbFronting1.EditValue.ToString() == "-1")
                    Id2 = "-1";
                else
                    Id2 = cbFronting1.EditValue.ToString();


                dbSAICBPOFactura.stpFactSelClienteFronting1.Clear();
                dbSAICBPOFactura.stpFactSelClienteFronting2.Clear();
                dbSAICBPOFactura.stpFactSelClienteFronting3.Clear();
                dbSAICBPOFactura.stpFactSelClienteFronting4.Clear();

                dbSAICBPOFactura.stpFactSelFrontingBanco.Clear();
                dbSAICBPOFactura.stpFactSelFrontingBanco1.Clear();
                dbSAICBPOFactura.stpFactSelFrontingBanco2.Clear();
                dbSAICBPOFactura.stpFactSelFrontingBanco3.Clear();
                dbSAICBPOFactura.stpFactSelFrontingBanco4.Clear();

                this.stpFactSelFrontingBancoTableAdapter.Fill(dbSAICBPOFactura.stpFactSelFrontingBanco, Id2.ToString());
                this.stpFactSelClienteFronting1TableAdapter.Fill(dbSAICBPOFactura.stpFactSelClienteFronting1, Id, Id2);

                this.spSoloRespuesta1.stpFactSelObtenerIVAFrontings(Convert.ToInt32(cbFronting1.EditValue), -1, -1, -1, -1, ref TieneIVAFronting);
                ActivarFronting();

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbFronting2_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                //obtener el renglon completo del Combobox
                if (cbFronting2.EditValue == null || cbFronting2.EditValue.ToString() == "-1")
                    Id2 = "-1";
                else                   
                    Id2 = cbFronting2.EditValue.ToString();

                dbSAICBPOFactura.stpFactSelClienteFronting2.Clear();
                dbSAICBPOFactura.stpFactSelClienteFronting3.Clear();
                dbSAICBPOFactura.stpFactSelClienteFronting4.Clear();

                dbSAICBPOFactura.stpFactSelFrontingBanco1.Clear();
                dbSAICBPOFactura.stpFactSelFrontingBanco2.Clear();
                dbSAICBPOFactura.stpFactSelFrontingBanco3.Clear();
                dbSAICBPOFactura.stpFactSelFrontingBanco4.Clear();

                if (cbFronting2.EditValue == null || cbFronting2.EditValue.ToString() =="-1")
                    Id2 = "-1";
                else
                {
                    Id2 = cbFronting2.EditValue.ToString();

                    this.stpFactSelFrontingBanco1TableAdapter.Fill(dbSAICBPOFactura.stpFactSelFrontingBanco1, Id2);

                    Id2 = cbFronting1.EditValue.ToString() + "," + cbFronting2.EditValue.ToString();

                    this.stpFactSelClienteFronting2TableAdapter.Fill(dbSAICBPOFactura.stpFactSelClienteFronting2, Id, Id2);

                    this.spSoloRespuesta1.stpFactSelObtenerIVAFrontings(Convert.ToInt32(cbFronting1.EditValue.ToString()), Convert.ToInt32(cbFronting2.EditValue.ToString()), -1, -1, -1, ref TieneIVAFronting);

                    ActivarFronting();

                    cbFronting3.EditValue = -1;
                    cbFronting4.EditValue = -1;
                    cbFronting5.EditValue = -1;
                }
                txtMo2.EditValue = 0;
                txtMo3.EditValue = 0;
                txtMo4.EditValue = 0;
                txtMo5.EditValue = 0;
                cbBanco2.EditValue = -1;
                cbBanco3.EditValue = -1;
                cbBanco4.EditValue = -1;
                cbBanco5.EditValue = -1;

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConLotes_Click(object sender, EventArgs e)
        {
            try
            {
                TipoCarga(true);
                //ckIVA.Enabled = true;
                //ckIVA.Checked = true;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btSinLotes_Click(object sender, EventArgs e)
        {
            try
            {
                TipoCarga(false);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ckIVA_CheckedChanged(object sender, EventArgs e)
        {
            if (ckIVA.Checked == false)
            {
                ckIVA.Checked = false;
                txtRetencion.Text = Convert.ToDecimal("0").ToString("C");
            }
            else
            {
                ckIVA.Checked = true;
            }
            Suma();
        }

        private void txtIVAPor_EditValueChanged(object sender, EventArgs e)
        {
            Suma();
        }

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            TotalNomina = 0; TotalCNomina = 0; TotalCS = 0; TotalCISR = 0; TotalCISN = 0; TotalNDed = 0; TotalNoNomina = 0; TotalMaquilaComision = 0;

            try
            {
                LotesSA = "";
                IdMoneda = "MXN";
                TipoCambio = "0";
                 //obtener el No. de Items seleccionados
                 DataRow row = null;
                foreach (int indice in gridView1.GetSelectedRows())
                {
                    row = gridView1.GetDataRow(indice);
                    TotalMaquilaComision = Math.Round(TotalMaquilaComision + Convert.ToDouble(row[3].ToString()), 2);
                    TotalNomina = Math.Round(TotalNomina + Convert.ToDouble(row[5].ToString()), 2);
                    TotalCNomina = Math.Round(TotalCNomina + Convert.ToDouble(row[8].ToString()), 2);
                    TotalCS = Math.Round(TotalCS + Convert.ToDouble(row[9].ToString()), 2);
                    TotalCISR = Math.Round(TotalCISR + Convert.ToDouble(row[10].ToString()), 2);
                    TotalCISN = Math.Round(TotalCISN + Convert.ToDouble(row[11].ToString()), 2);
                    TotalNoNomina = Math.Round(TotalNoNomina + Convert.ToDouble(row[14].ToString()), 2);

                    IdMoneda = row[12].ToString();
                    TipoCambio = row[13].ToString();

                    LotesSA = LotesSA + row[0].ToString() + ",";
                }
                ObtenerEmpleados();
                Suma();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView2_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            TotalAlimentos = 0; TotalCAliemtos = 0; TotalMaquilaComisionA = 0;
            try
             {
                LotesSC = "";
                //obtener el No. de Items seleccionados
                DataRow row = null;
                foreach (int indice in gridView2.GetSelectedRows())
                {
                    row = gridView2.GetDataRow(indice);

                    TotalMaquilaComisionA = Math.Round(TotalMaquilaComisionA + Convert.ToDouble(row[3].ToString()), 2);
                    TotalAlimentos = Math.Round(TotalAlimentos + Convert.ToDouble(row[3].ToString()), 2);
                    TotalCAliemtos = Math.Round(TotalCAliemtos + Convert.ToDouble(row[8].ToString()), 2);


                    IdMoneda = row[12].ToString();
                    TipoCambio = row[13].ToString();
                    LotesSC = LotesSC + row[0].ToString() + ",";
                }
                ObtenerEmpleados();
                Suma();

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbFronting3_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                //obtener el renglon completo del Combobox
                if (cbFronting3.EditValue == null || cbFronting3.EditValue.ToString() == "-1")
                    Id2 = "-1";
                else
                    Id2 = cbFronting3.EditValue.ToString();

                dbSAICBPOFactura.stpFactSelClienteFronting3.Clear();
                dbSAICBPOFactura.stpFactSelClienteFronting4.Clear();

                dbSAICBPOFactura.stpFactSelFrontingBanco2.Clear();
                dbSAICBPOFactura.stpFactSelFrontingBanco3.Clear();
                dbSAICBPOFactura.stpFactSelFrontingBanco4.Clear();

                if (cbFronting3.EditValue == null || cbFronting3.EditValue.ToString() == "-1")
                    Id2 = "-1";
                else
                {
                    Id2 = cbFronting3.EditValue.ToString();

                    this.stpFactSelFrontingBanco2TableAdapter.Fill(dbSAICBPOFactura.stpFactSelFrontingBanco2, Id2);

                    Id2 = cbFronting1.EditValue.ToString() + "," + cbFronting2.EditValue.ToString() + "," + cbFronting3.EditValue.ToString();

                    this.stpFactSelClienteFronting3TableAdapter.Fill(dbSAICBPOFactura.stpFactSelClienteFronting3, Id, Id2);

                    this.spSoloRespuesta1.stpFactSelObtenerIVAFrontings(Convert.ToInt32(cbFronting1.EditValue.ToString()), Convert.ToInt32(cbFronting2.EditValue.ToString()), Convert.ToInt32(cbFronting3.EditValue.ToString()), -1, -1, ref TieneIVAFronting);

                    ActivarFronting();

                    cbFronting4.EditValue = -1;
                    cbFronting5.EditValue = -1;
                }

                txtMo3.EditValue = 0;
                txtMo4.EditValue = 0;
                txtMo5.EditValue = 0;
                cbBanco3.EditValue = -1;
                cbBanco4.EditValue = -1;
                cbBanco5.EditValue = -1;

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMoAsi2_EditValueChanged(object sender, EventArgs e)
        {
            if (cbPeriodoNomina.Text.Contains("ASIMILADOS") || btnConLotes.Visible == false || cbPeriodoNomina.Text == "HONORARIOS" || cbPeriodoNomina.Text == "MAQUILA COMISION")
            {
                txtTAsimilados.Text = Convert.ToDecimal(Convert.ToDecimal(txtMoProducto.Text.ToString())).ToString("C");
            }
            Suma();
        }

        private void cbAsimilados_EditValueChanged(object sender, EventArgs e)
        {
            Int32 IdASimilados = 0;
            string pRFCCliente = "";
            string pRFCAsimi = "";
            string idCliente = "";
            txtMoProducto.Focus();

            dbSAICBPOFactura.stpFactSelFrontingBanco5.Clear();

            //obtener el renglon completo del Combobox
            if (cbEProducto.EditValue == null || cbEProducto.EditValue.ToString() == "-1")
                Id2 = "-1";
            else
            {
                if (Validator.IsPresent(cbCliente))
                {
                    Id2 = cbEProducto.EditValue.ToString();

                    this.stpFactSelFrontingBanco5TableAdapter.Fill(dbSAICBPOFactura.stpFactSelFrontingBanco5, Id2);

                    cbLotesAsimilados.Enabled = false;

                    if (cbTipoProducto.Text == "ASIMILADOS")
                    {
                        cbLotesAsimilados.Enabled = true;
                        pRFCCliente = RFCCliente;


                        GridLookUpEdit lookUp = sender as GridLookUpEdit;
                        DataRowView dataRow = lookUp.GetSelectedDataRow() as DataRowView;
                        if (dataRow != null)
                        {
                            IdASimilados = Convert.ToInt32(dataRow["IdAsimilados"].ToString());
                            pRFCAsimi = dataRow["RFCAsi"].ToString(); 
                        }
                        else
                        {
                            IdASimilados = 0;
                            pRFCAsimi = "";
                        }

                        //DataRow row = null;
                        //foreach (int indice in gridView11.GetSelectedRows())
                        //{
                        //    row = gridView11.GetDataRow(indice);
                        //    IdASimilados = Convert.ToInt32(row[3].ToString());
                        //    pRFCAsimi = row[4].ToString();
                        //}

                        this.stpSelLoteCargaNominaParaControlTableAdapter.Fill(dbSAICAsimilados.stpSelLoteCargaNominaParaControl, OperadorBD.OperadorGlobal.NombreOperador, pRFCAsimi, IdASimilados, pRFCCliente, false, OperadorBD.OperadorGlobal.IdOperador, -1);
                    }
                    else
                    {
                        dbSAICAsimilados.stpSelLoteCargaNominaParaControl.Clear();
                    }
                }
            }

        }

        private void cbFronting4_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                //obtener el renglon completo del Combobox
                if (cbFronting4.EditValue == null || cbFronting4.EditValue.ToString() == "-1")
                    Id2 = "-1";
                else
                    Id2 = cbFronting4.EditValue.ToString();

                dbSAICBPOFactura.stpFactSelClienteFronting4.Clear();

                dbSAICBPOFactura.stpFactSelFrontingBanco3.Clear();
                dbSAICBPOFactura.stpFactSelFrontingBanco4.Clear();

                if (cbFronting4.EditValue == null || cbFronting4.EditValue.ToString() == "-1")
                    Id2 = "-1";
                else
                {
                    Id2 = cbFronting4.EditValue.ToString();

                    this.stpFactSelFrontingBanco3TableAdapter.Fill(dbSAICBPOFactura.stpFactSelFrontingBanco3, Id2);

                    Id2 = cbFronting1.EditValue.ToString() + "," + cbFronting2.EditValue.ToString() + "," + cbFronting3.EditValue.ToString() + "," + cbFronting4.EditValue.ToString() + ",";

                    this.stpFactSelClienteFronting4TableAdapter.Fill(dbSAICBPOFactura.stpFactSelClienteFronting4, Id, Id2);

                    this.spSoloRespuesta1.stpFactSelObtenerIVAFrontings(Convert.ToInt32(cbFronting1.EditValue.ToString()), Convert.ToInt32(cbFronting2.EditValue.ToString()), Convert.ToInt32(cbFronting3.EditValue.ToString()), Convert.ToInt32(cbFronting4.EditValue.ToString()), -1, ref TieneIVAFronting);

                    ActivarFronting();

                    cbFronting5.EditValue = -1;
                }

                txtMo4.EditValue = 0;
                txtMo5.EditValue = 0;
                cbBanco4.EditValue = -1;
                cbBanco5.EditValue = -1;

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void cbFronting5_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                //obtener el renglon completo del Combobox
                if (cbFronting5.EditValue == null || cbFronting5.EditValue.ToString() == "-1")
                    Id2 = "-1";
                else
                    Id2 = cbFronting5.EditValue.ToString();

                dbSAICBPOFactura.stpFactSelFrontingBanco4.Clear();

                if (cbFronting5.EditValue == null || cbFronting5.EditValue.ToString() == "-1")
                    Id2 = "-1";
                else
                {
                    Id2 = cbFronting5.EditValue.ToString();
                    this.stpFactSelFrontingBanco4TableAdapter.Fill(dbSAICBPOFactura.stpFactSelFrontingBanco4, Id2);
                    this.spSoloRespuesta1.stpFactSelObtenerIVAFrontings(Convert.ToInt32(cbFronting1.EditValue.ToString()), Convert.ToInt32(cbFronting2.EditValue.ToString()), Convert.ToInt32(cbFronting3.EditValue.ToString()), Convert.ToInt32(cbFronting4.EditValue.ToString()), Convert.ToInt32(cbFronting5.EditValue.ToString()), ref TieneIVAFronting);

                    ActivarFronting();
                }

                txtMo5.EditValue = 0;
                cbBanco5.EditValue = -1;
                txtMo5.Focus();

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}