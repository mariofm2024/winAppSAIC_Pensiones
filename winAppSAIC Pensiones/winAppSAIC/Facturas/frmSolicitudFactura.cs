using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using winAppSAIC.UtileriasLocal;
using compCatalogosSAIC;

namespace winAppSAIC.Facturas
{
    public partial class frmSolicitudFactura : DevExpress.XtraEditors.XtraForm
    {
        public frmSolicitudFactura()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();
        double Controlsubtotal = 0;
        double ControlIVA = 0;
        double ControlRetencion = 0;
        double ControlTotal = 0;
        double RestoPago = 0, RetencionIVA = 0;
        double TCambioOri = 0;
        double TCambioPago = 0;
        double TotalFactura = 0;
        Decimal DescuentosISN = 0;
        string TieneIVAGlobla = "16";
        bool TieneIVA8 = false;
        string IdTipoFactura = "N", MonedaOri = "MXP", MonedaPago = "MXP";
        bool Acceso = false;
        int NoTieneIvaxConcepto = 0;
        int? IdTipoRelacion = 0;
        int NoFactura = 1;
        Int64 IdHeaderFactura = 0;
        DateTime dtFechaDePago;
        Boolean flagControConRetencion = false;
        Boolean flagSinControl = true;
        int iValorLimiteArchivos;
        int IdTipoCliente = 0;
        string bMoneda = "";

        private void Limpiar(bool bflag)
        {
            //Limpiar 
            if (cbIdFronting.EditValue != null && Convert.ToInt32(cbIdFronting.EditValue) != -1)
                cbIdFronting.EditValue = -1;
            if (cbTipoFacturador.EditValue != null && Convert.ToInt32(cbTipoFacturador.EditValue) != -1)
                cbTipoFacturador.EditValue = -1;
            if (cbIdTenedora.EditValue != null && Convert.ToInt32(cbIdTenedora.EditValue) != -1)
                cbIdTenedora.EditValue = -1;
            if (cboIdCliente.EditValue != null && Convert.ToInt32(cboIdCliente.EditValue) != -1)
                cboIdCliente.EditValue = -1;
            if (cbFormaPago.EditValue != null && Convert.ToInt32(cbFormaPago.EditValue) != -1)
                cbFormaPago.EditValue = -1;

            cbFormaPago.Enabled = true;
            cbUsoCFDI.Enabled = true;

            if (cbMetodoPago.EditValue != null && Convert.ToInt32(cbMetodoPago.EditValue) != -1)
                cbMetodoPago.EditValue = -1;
            if (cbMoneda.EditValue != null && cbMoneda.EditValue.ToString() != "")
                cbMoneda.EditValue = "";
            txtCambio.Text = string.Empty;
            if (cbTipoRelacion.EditValue != null && Convert.ToInt32(cbTipoRelacion.EditValue) != -1)
                cbTipoRelacion.EditValue = -1;
            if (bflag)
                if (cbControl.EditValue != null && Convert.ToInt32(cbControl.EditValue) != -1)
                    cbControl.EditValue = -1;
            txtSubtotal.Text = Convert.ToDecimal(0).ToString("C");
            txtIVA.Text = Convert.ToDecimal(0).ToString("C");
            txtRetencionIVA.Text = Convert.ToDecimal(0).ToString("C");
            txtTotal.Text = Convert.ToDecimal(0).ToString("C");
            txtTotalISN.Text = Convert.ToDecimal(0).ToString("C");
            if (cbBancoDestino.EditValue != null && Convert.ToInt32(cbBancoDestino.EditValue) != -1)
                cbBancoDestino.EditValue = -1;
            if (cbUsoCFDI.EditValue != null && Convert.ToInt32(cbUsoCFDI.EditValue) != -1)
                cbUsoCFDI.EditValue = -1;
            cbUsoCFDI.ReadOnly = false;
            txtDeposito.Text = string.Empty;
            txtcargarArchivo.Text = string.Empty;

            cbTipoRelacion.Enabled = false;
            cbTipoRelacion.BackColor = Color.LightGoldenrodYellow;
            cbFacturaRelacion.Enabled = false;
            cbFacturaRelacion.BackColor = Color.LightGoldenrodYellow;

            cbFacturaRelacionRecibo.Enabled = false;
            cbFacturaRelacionRecibo.BackColor = Color.LightGoldenrodYellow;
            btnActualizar.Enabled = false;
            dt.Clear();
            dbSAICBPOFactura.stpFactSelFacturasARelacionarSAT.Clear();
            txtcargarArchivo.Text = string.Empty;
            Controlsubtotal = 0;
            ControlIVA = 0;
            ControlRetencion = 0;
            ControlTotal = 0;
            gvConceptos.DataSource = dt;
            btnxAnticipo.Visible = true;
            btnREP.Visible = true;
            btnPublicoGeneral.Visible = true;
            IdTipoFactura = "N";
            NoFactura = 0;
            IdHeaderFactura = 0;
            IdTipoRelacion = 0;

            cbPeriodicidad.Enabled = false;
            cbProducto.EditValue = 1;
            cbProducto.ReadOnly = false;
            cbTipoFacturador.EditValue = -1;
            cbTipoFacturador.ReadOnly = false;
        }

        private void ActivarBotonesC(bool bflag)
        {
            //Limpiar 
            btnControl.Visible = bflag;

            if (Acceso)
            {
                btRelacionar.Visible = bflag;
                //btnAnticipo.Visible = bflag;
            }

            //btnLimpia.Visible = !bflag;
            cbIdFronting.ReadOnly = !bflag;
            cbTipoFacturador.ReadOnly = !bflag;
            cboIdCliente.ReadOnly = !bflag;
            cbMoneda.ReadOnly = !bflag;
            txtCambio.ReadOnly = !bflag;
            cbFacturaRelacion.Enabled = !bflag;
            cbFacturaRelacionRecibo.Enabled = !bflag;
            btnActualizar.Enabled = !bflag;
            cbTipoRelacion.Enabled = !bflag;
            cbControl.Enabled = !bflag;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Cerrar Ventana 
            Close();
        }

        private void frmSolicitudFactura_Load(object sender, EventArgs e)
        {

            try
            {
                splashSMCargando.ShowWaitForm();

                CrearTabla(); //Crear Tabla de Conceptos
                CargarCombos(); //Metodo para Cargar los Combos
                Diseno(); //Metodo para Definir tamaño en combos                
                ActivarBotonesC(true); //Limpiar Botones 
                splashSMCargando.CloseWaitForm();
                btnLimpia.Visible = false;
                txtTipoFactura.Text = "NORMAL";
                IdTipoFactura = "N";
                NoFactura = 0;
                IdHeaderFactura = 0;
                IdTipoRelacion = 0;

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                splashSMCargando.CloseWaitForm();
            }
        }

        /// <summary>
        /// Metodo que nos Crea Tablas para los conceptos
        /// </summary>
        private void CrearTabla()
        {
            dt = new DataTable();
            dt.TableName = "Conceptos";
            dt.Columns.Add("colCantidad", typeof(decimal));
            dt.Columns.Add("colIdConcepto", typeof(Int64));
            dt.Columns.Add("colConcepto", typeof(String));
            dt.Columns.Add("colPrecioUnitario", typeof(Decimal));
            dt.Columns.Add("colImporte", typeof(Decimal));
            dt.Columns.Add("colIVA", typeof(bool));
            dt.Columns.Add("colPorIVA", typeof(Decimal));
            dt.Columns.Add("colTotalIVA", typeof(Decimal));
            dt.Columns.Add("colConceptoPresentar", typeof(String));
            dt.Columns.Add("colIdUnidad", typeof(String));
            dt.Columns.Add("colIdFacturaRela", typeof(Int64));
            dt.Columns.Add("colTotalDescuento", typeof(Decimal));
            dt.Columns.Add("colImporteTotal", typeof(Decimal));
            dt.Columns.Add("colRetencion", typeof(Decimal));
            dt.Columns.Add("colObjetoImpuesto", typeof(bool));
            //POR EL CAMBIO
            dt.Columns.Add("colPrecioUnitarioCB", typeof(Decimal));
            dt.Columns.Add("colImporteCB", typeof(Decimal));
            dt.Columns.Add("colTotalIVACB", typeof(Decimal));
            dt.Columns.Add("colImporteTotalCB", typeof(Decimal));
        }

        private void Totales()
        {
            decimal subtotal = 0, IVA = 0, Total = 0, RetencionIVA = 0, subtotalR = 0, IVAR = 0, TotalR = 0;
            bool bIVA = false;
            DescuentosISN = 0;
            DataRow row = null;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                row = dt.Rows[i];
                subtotal = subtotal + Convert.ToDecimal(row[4].ToString());
                IVA = IVA + Convert.ToDecimal(row[7].ToString());
                RetencionIVA = RetencionIVA + Convert.ToDecimal(row[13].ToString());
                DescuentosISN = DescuentosISN + Convert.ToDecimal(row[11].ToString());
                Total = Total + Convert.ToDecimal(row[12].ToString());
                subtotalR = subtotalR + Convert.ToDecimal(row[16].ToString());
                IVAR = IVAR + Convert.ToDecimal(row[17].ToString());
                TotalR = TotalR + Convert.ToDecimal(row[18].ToString());
                if ((bool)row[5] == true)
                    bIVA = true;
            }
            if (dt.Rows.Count > 0)
            {
                cbUsoCFDI.ReadOnly = true;
                txtIVAPor.ReadOnly = true;
            }
            else
            {
                cbUsoCFDI.ReadOnly = false;
                txtIVAPor.ReadOnly = false;
                NoTieneIvaxConcepto = 0;
            }

            Total = Total - DescuentosISN;
            txtSubtotal.Text = Convert.ToDecimal(subtotal).ToString("C");
            txtIVA.Text = Convert.ToDecimal(IVA).ToString("C");
            txtRetencionIVA.Text = Convert.ToDecimal(RetencionIVA).ToString("C");
            txtTotalISN.Text = Convert.ToDecimal(DescuentosISN).ToString("C");
            txtTotal.Text = Convert.ToDecimal(Total).ToString("C");

            txtSubtotalR.Text = Convert.ToDecimal(subtotalR).ToString("C");
            txtIVAR.Text = Convert.ToDecimal(IVAR).ToString("C");
            txtTotalR.Text = Convert.ToDecimal(TotalR).ToString("C");
            txtTotalP.Text = Convert.ToDecimal(TotalR).ToString("C");

        }

        private void Diseno()
        {
            // Set column widths according to their contents. 
            cbControl.Properties.View.BestFitColumns();
            // Specify the total dropdown width. 
            cbControl.Properties.PopupFormWidth = 900;

            // Set column widths according to their contents. 
            cbIdFronting.Properties.View.BestFitColumns();
            // Specify the total dropdown width. 
            cbIdFronting.Properties.PopupFormWidth = 800;

            // Set column widths according to their contents. 
            cbTipoFacturador.Properties.View.BestFitColumns();
            // Specify the total dropdown width. 
            cbTipoFacturador.Properties.PopupFormWidth = 250;

            // Set column widths according to their contents. 
            cboIdCliente.Properties.View.BestFitColumns();
            // Specify the total dropdown width. 
            cboIdCliente.Properties.PopupFormWidth = 600;

            // Set column widths according to their contents. 
            cbIdTenedora.Properties.View.BestFitColumns();
            // Specify the total dropdown width. 
            cbIdTenedora.Properties.PopupFormWidth = 600;

            // Set column widths according to their contents. 
            cbMetodoPago.Properties.View.BestFitColumns();
            // Specify the total dropdown width. 
            cbMetodoPago.Properties.PopupFormWidth = 250;

            // Set column widths according to their contents. 
            cbFormaPago.Properties.View.BestFitColumns();
            // Specify the total dropdown width. 
            cbFormaPago.Properties.PopupFormWidth = 200;

            // Set column widths according to their contents. 
            cbMoneda.Properties.View.BestFitColumns();
            // Specify the total dropdown width. 
            cbMoneda.Properties.PopupFormWidth = 300;

            // Set column widths according to their contents. 
            cbTipoRelacion.Properties.View.BestFitColumns();
            // Specify the total dropdown width. 
            cbTipoRelacion.Properties.PopupFormWidth = 400;

            // Set column widths according to their contents. 
            cbFacturaRelacion.Properties.View.BestFitColumns();
            // Specify the total dropdown width. 
            cbFacturaRelacion.Properties.PopupFormWidth = 800;
            // Set column widths according to their contents. 
            cbFacturaRelacionRecibo.Properties.View.BestFitColumns();
            // Specify the total dropdown width. 
            cbFacturaRelacionRecibo.Properties.PopupFormWidth = 800;
            // Set column widths according to their contents. 
            cbProducto.Properties.View.BestFitColumns();
            // Specify the total dropdown width. 
            cbProducto.Properties.PopupFormWidth = 150;

        }

        private void CargarCombos()
        {
            // TODO: This line of code loads data into the 'dbSAICBPOFactura.vwFactFormaPago' table. You can move, or remove it, as needed.
            this.vwFactCatFormaPagoTableAdapter.Fill(this.dbSAICBPOFactura.vwFactCatFormaPago);
            // TODO: This line of code loads data into the 'dbSAICBPOFactura.stpSelTipoBeneficiarioOperadorTableAdapter' table. You can move, or remove it, as needed.
            this.stpFactSelTipoBeneficiarioOperadorTableAdapter.Fill(this.dbSAICBPOFactura.stpFactSelTipoBeneficiarioOperador, OperadorBD.OperadorGlobal.IdOperador);
            // TODO: This line of code loads data into the 'dbSAICBPOFactura.vwcatFronting' table. You can move, or remove it, as needed.
            this.vwcatFrontingTableAdapter.Fill(this.dbSAICBPOFactura.vwcatFronting);
            // TODO: This line of code loads data into the 'dbSAICBPOFactura.vwFactMetodoPago' table. You can move, or remove it, as needed.
            this.vwFactCatMetodoPagoTableAdapter.Fill(this.dbSAICBPOFactura.vwFactCatMetodoPago);
            // TODO: This line of code loads data into the 'dbSAICBPOFactura.controlOperacionesTableAdapter' table. You can move, or remove it, as needed.
            this.stpFactSelDerechosAccesoFacturacionTableAdapter.Fill(this.dbSAICBPOFactura.stpFactSelDerechosAccesoFacturacion, OperadorBD.OperadorGlobal.IdOperador);
            // TODO: This line of code loads data into the 'dbSAICBPOFactura.vwCatMoneda' table. You can move, or remove it, as needed.
            this.vwCatMonedaTableAdapter.Fill(this.dbSAICBPOFactura.vwCatMoneda);
            // TODO: This line of code loads data into the 'dbSAICBPOFactura.vwFactCatUsoCFDI' table. You can move, or remove it, as needed.
            this.stpFactSelUsoCFDITableAdapter.Fill(this.dbSAICBPOFactura.stpFactSelUsoCFDI, IdTipoRelacion, IdTipoFactura, NoFactura, IdHeaderFactura);
            // TODO: This line of code loads data into the 'dbSAICBPOFactura.stpFactSelProducto' table. You can move, or remove it, as needed.
            this.stpFactSelProductoTableAdapter.Fill(this.dbSAICBPOFactura.stpFactSelProducto);
            this.stpFactPeriodicidadTableAdapter.Fill(this.dbSAICBPOFactura.stpFactPeriodicidad, 0);

            this.stpFactSelCatTipoRelacionv2TableAdapter.Fill(this.dbSAICBPOFactura.stpFactSelCatTipoRelacionv2, IdTipoFactura, 27);

            stpSelParametroTableAdapter1.Fill(dbSAICBPOValidacionDataSet1.stpSelParametro, "LIMITEARCHIVO");
            if (dbSAICBPOValidacionDataSet1.stpSelParametro.Rows.Count > 0)
            {
                int.TryParse(dbSAICBPOValidacionDataSet1.stpSelParametro.Rows[0]["ValorParametro"].ToString(), out iValorLimiteArchivos);
            }
            else
            {
                XtraMessageBox.Show("No se tiene valor de limite para archivos.", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (this.dbSAICBPOFactura.stpFactSelDerechosAccesoFacturacion.Count > 0)
            {
                DataRow Row = this.dbSAICBPOFactura.stpFactSelDerechosAccesoFacturacion.Rows[0];
                Acceso = (Row[0].ToString() == "1" ? true : false);
            }
        }

        private void ActivarControlesPago(bool bflag, string tipo)
        {

            cbBancoDestino.Enabled = bflag;
            cbBancoDestino.BackColor = Color.White;

            txtDeposito.Enabled = bflag;
            txtDeposito.BackColor = Color.White;

            txtDeposito.Text = string.Empty;

            if (tipo.Contains("Efectivo"))
            {
                cbBancoOrigen.Enabled = !bflag;
                cbBancoOrigen.BackColor = Color.LightGoldenrodYellow;
                cbBancoOrigen.Text = String.Empty;
                cbBancoOrigen.EditValue = "-1";

                cbCuentaOrigen.Enabled = !bflag;
                cbCuentaOrigen.BackColor = Color.LightGoldenrodYellow;
                cbCuentaOrigen.Text = String.Empty;
                cbCuentaOrigen.EditValue = 0;

                txtcargarArchivo.Enabled = !bflag;
                txtcargarArchivo.BackColor = Color.LightGoldenrodYellow;
                txtcargarArchivo.Text = String.Empty;
                CargarBancos();
            }
            else if (tipo.Contains("Cheque"))
            {
                cbBancoOrigen.Enabled = bflag;
                cbBancoOrigen.BackColor = Color.White;

                cbCuentaOrigen.Enabled = !bflag;
                cbCuentaOrigen.BackColor = Color.LightGoldenrodYellow;
                cbCuentaOrigen.Text = String.Empty;
                cbCuentaOrigen.EditValue = 0;

                txtcargarArchivo.Enabled = bflag;
                txtcargarArchivo.BackColor = Color.White;
                CargarBancos();
            }
            else if (tipo.Contains("Transferencia"))
            {
                cbBancoOrigen.Enabled = bflag;
                cbBancoOrigen.BackColor = Color.White;

                cbCuentaOrigen.Enabled = bflag;
                cbCuentaOrigen.BackColor = Color.White;

                txtcargarArchivo.Enabled = bflag;
                txtcargarArchivo.BackColor = Color.White;
                CargarBancos();
            }
            else
            {
                cbBancoOrigen.Enabled = bflag;
                cbBancoOrigen.BackColor = Color.White;

                cbCuentaOrigen.Enabled = bflag;
                cbCuentaOrigen.BackColor = Color.White;

                txtcargarArchivo.Enabled = bflag;
                txtcargarArchivo.BackColor = Color.White;
            }
        }

        private void CargarBancos()
        {
            string sFronting = "";
            string sBeneficiario = "";
            int iTipoBeneficiario = -1;
            int iRelcion = -1;
            if (cbIdFronting.EditValue != null && cbTipoFacturador.EditValue != null)
            {
                sFronting = cbIdFronting.EditValue.ToString();
                iTipoBeneficiario = Convert.ToInt32(cbTipoFacturador.EditValue);

                if (cbTipoRelacion.EditValue != null)
                    iRelcion = Convert.ToInt32(cbTipoRelacion.EditValue);

                if (cbTipoFacturador.Text == "CLIENTE")
                {
                    sBeneficiario = cboIdCliente.EditValue.ToString();
                }
                else
                {
                    sBeneficiario = cbIdTenedora.EditValue.ToString();
                }
                if (iRelcion == 2)
                {
                    this.stpFactSelFrontingClienteBancoTableAdapter.Fill(dbSAICBPOFactura.stpFactSelFrontingClienteBanco, sFronting, 3, iRelcion);
                    this.stpFactSelFrontingClienteBanco1TableAdapter.Fill(dbSAICBPOFactura.stpFactSelFrontingClienteBanco1, sBeneficiario, iTipoBeneficiario, iRelcion);
                }
                else
                {
                    this.stpFactSelFrontingClienteBancoTableAdapter.Fill(dbSAICBPOFactura.stpFactSelFrontingClienteBanco, sBeneficiario, iTipoBeneficiario, iRelcion);
                    this.stpFactSelFrontingClienteBanco1TableAdapter.Fill(dbSAICBPOFactura.stpFactSelFrontingClienteBanco1, sFronting, 3, iRelcion);
                }
            }
        }
        private void CargarIVA(bool TieneIVA, string TieneIVAGlobla)
        {
            //txtIVAPor.ReadOnly = !TieneIVA;
            txtIVAPor.Text = TieneIVAGlobla;
        }


        private void CargarSolicitud()
        {
            //Var para la SolicitudHeader
            Int64? vIdSolicitud = 0, vIdFactura = 0, vIdDetail = 0;
            int? pOk = 0;
            Int64 vIdControl = 0, vIdFacturaRelacion = 0, vIdFacturaRela;
            Int32 vIdFronting = 0, vIdTipoBeneficiario = 0, vIdBeneficiario = 0, vIdMetodoPago = 0, vIdFormaPago = 0, vIdTipoRelacion = 0, vIdPeriodicidad=0;
            Int32 vIdBancoOrigen = 0, vIdBancoDestino = 0, vIdUnidad = 0, vIdUsoCFDI = 0, vIdCueta = 0, vIdProducto = 0, vFlag = 0;
            string vFechaPago = "", vComproPago, vIdMoneda = "", stFile = "";
            decimal vTipoCambio = 0;
            //Var para la SolicitudDetail
            decimal vIdCantidad = 0;
            Int64 vIdConcepto = 0;
            decimal vPrecio = 0, vImporte = 0, vIVA = 0, vSubtotal = 0, vDeposito = 0, vTotal = 0, vRetencion = 0;
            string vsComplemento = "", vIVAPorcentaje = "", vPorcentaje = "";
            byte[] vArchivo;
            bool vIncluyeIVA = true;
            try
            {
                vIdControl = Convert.ToInt64(cbControl.EditValue != null ? cbControl.EditValue.ToString() : "0");
                if (vIdControl == -1)
                    vIdControl = 0;
                vIdFacturaRelacion = Convert.ToInt64(cbFacturaRelacion.EditValue != null ? cbFacturaRelacion.EditValue.ToString() : "-1");
                vIdFronting = Convert.ToInt32(cbIdFronting.EditValue.ToString());
                vIdTipoBeneficiario = Convert.ToInt32(cbTipoFacturador.EditValue.ToString());
                vIdProducto = Convert.ToInt32(cbProducto.EditValue.ToString());

                if (cbTipoFacturador.Text == "CLIENTE")
                    vIdBeneficiario = Convert.ToInt32(cboIdCliente.EditValue.ToString());
                else
                    vIdBeneficiario = Convert.ToInt32(cbIdTenedora.EditValue.ToString());

                vIdMetodoPago = Convert.ToInt32(cbMetodoPago.EditValue.ToString());
                vIdFormaPago = Convert.ToInt32(cbFormaPago.EditValue != null ? cbFormaPago.EditValue.ToString() : "-1");
                vIdTipoRelacion = Convert.ToInt32(cbTipoRelacion.EditValue != null ? cbTipoRelacion.EditValue.ToString() : "1");
                vFechaPago = Convert.ToDateTime(dtFechaPago.Text).Year.ToString() + "-" + Convert.ToDateTime(dtFechaPago.Text).Month.ToString() + "-" + Convert.ToDateTime(dtFechaPago.Text).Day.ToString();
                vComproPago = Convert.ToDateTime(dtFechaDePago).Year.ToString() + "-" + Convert.ToDateTime(dtFechaDePago).Month.ToString() + "-" + Convert.ToDateTime(dtFechaDePago).Day.ToString();
                vIdMoneda = cbMoneda.EditValue.ToString();
                vTipoCambio = Convert.ToDecimal(txtCambio.Text.Replace("$", ""));
                vIdBancoOrigen = Convert.ToInt32(cbBancoOrigen.EditValue != null ? cbBancoOrigen.EditValue.ToString() : "-1");
                vIdCueta = Convert.ToInt32(cbCuentaOrigen.EditValue != null ? cbCuentaOrigen.EditValue.ToString() : "-1");
                vIdBancoDestino = Convert.ToInt32(cbBancoDestino.EditValue != null ? cbBancoDestino.EditValue.ToString() : "-1");
                vDeposito = Convert.ToDecimal(txtDeposito.Text.ToString());
                if (IdTipoFactura == "R")
                {
                    if (cbMoneda.EditValue.ToString() != bMoneda)
                    {
                        vSubtotal = Math.Round(Convert.ToDecimal(txtSubtotal.Text.Replace("$", "")) / Convert.ToDecimal(txtCambio.Text.Replace("$", "")), 2);
                        vIVA = Math.Round(Convert.ToDecimal(txtIVA.Text.Replace("$", "")) / Convert.ToDecimal(txtCambio.Text.Replace("$", "")), 2);
                        vTotal = Convert.ToDecimal(txtTotalP.Text.Replace("$", ""));
                    }
                    else
                    {
                        vSubtotal = Convert.ToDecimal(txtSubtotal.Text.Replace("$", ""));
                        vIVA = Convert.ToDecimal(txtIVA.Text.Replace("$", ""));
                        vTotal = Convert.ToDecimal(txtTotal.Text.Replace("$", ""));
                    }
                }
                else
                {
                    vSubtotal = Convert.ToDecimal(txtSubtotal.Text.Replace("$", ""));
                    vIVA = Convert.ToDecimal(txtIVA.Text.Replace("$", ""));
                    vTotal = Convert.ToDecimal(txtTotal.Text.Replace("$", ""));
                }
                vIdUsoCFDI = Convert.ToInt32(cbUsoCFDI.EditValue.ToString());
                vPorcentaje = txtIVAPor.Text.ToString();

                if (cbPeriodicidad.Enabled)
                    vIdPeriodicidad = Convert.ToInt32(cbPeriodicidad.EditValue.ToString());
                else
                    vIdPeriodicidad = 0;

                if (txtcargarArchivo.Text != string.Empty)
                    vFlag = 1;

                if (NoTieneIvaxConcepto > 0)
                    vPorcentaje = txtIVAPor.Text.ToString();
                else
                    vPorcentaje = "0.";

                if (txtcargarArchivo.Text != string.Empty)
                {
                    vArchivo = File.ReadAllBytes(txtcargarArchivo.Text);
                    stFile = Convert.ToBase64String(vArchivo);
                }
                else
                    vArchivo = null;
                //Insertar Header Solicitud
                this.spSoloRespuesta1.stpFactInsSolicitudFactura(vIdControl, vIdFronting, vIdBeneficiario, vIdTipoBeneficiario,
                                                            OperadorBD.OperadorGlobal.IdOperador, OperadorBD.OperadorGlobal.NombreUsuario, ref vIdSolicitud);

                if (vIdSolicitud > 0)
                {
                    this.spSoloRespuesta1.stpFactInsHeaderFacturaN(vIdSolicitud, vIdFronting, vIdBeneficiario, vIdTipoBeneficiario, vIdProducto,
                                                            vIdMetodoPago, vIdFormaPago, vIdMoneda, vTipoCambio, vFechaPago, vComproPago, IdTipoFactura, vIdUsoCFDI,
                                                            vSubtotal, vPorcentaje, vIVA, DescuentosISN, vTotal, vIdFacturaRelacion, vIdTipoRelacion,
                                                            vDeposito, vIdBancoOrigen, vIdCueta, vIdBancoDestino, vFlag, vIdPeriodicidad, stFile, OperadorBD.OperadorGlobal.IdOperador, OperadorBD.OperadorGlobal.NombreUsuario, ref vIdFactura);

                    if (vIdTipoRelacion == 5 && vIdFactura != 0)
                    {
                        string sFacturas = "";

                        foreach (var item in gridView16.GetSelectedRows())
                        {
                            DataRow row = gridView16.GetDataRow(item);
                            sFacturas = sFacturas + row[0].ToString() + ",";
                        }
                        this.spSoloRespuesta1.stpFactInsFacturasSustitucion(vIdFactura, sFacturas, OperadorBD.OperadorGlobal.NombreUsuario, pOk);
                    }

                    if (vIdControl != 0 && vIdFactura != 0)
                        this.spSoloRespuesta1.stpFactInsFacturasControl(vIdControl, vIdFactura.ToString(), OperadorBD.OperadorGlobal.IdOperador, OperadorBD.OperadorGlobal.NombreUsuario, ref pOk);


                    vSubtotal = 0;
                    vIVA = 0;
                    vTotal = 0;

                    if (vIdFactura > 0)
                    {
                        DataRow Row = null;
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            Row = dt.Rows[i];
                            vIdCantidad = Convert.ToDecimal(Row[0]);
                            vIdConcepto = Convert.ToInt64(Row[1]);
                            vsComplemento = Row[2].ToString();
                            vPrecio = Convert.ToDecimal(Row[3]);
                            vImporte = Convert.ToDecimal(Row[4]);
                            vIVA = Convert.ToDecimal(Row[7]);
                            vSubtotal = Convert.ToDecimal(Row[12]);
                            vIVAPorcentaje = Row[6].ToString();
                            vIncluyeIVA = Convert.ToBoolean(Row[5]);
                            vIdUnidad = Convert.ToInt32(Row[9]);
                            vIdFacturaRela = Convert.ToInt64(Row[10]);
                            DescuentosISN = Convert.ToDecimal(Row[11]);
                            vRetencion = Convert.ToDecimal(Row[13]);

                            //Insertar Detalle Solicitud
                            this.spSoloRespuesta1.stpFactInsDetailFactura2020(vIdFactura, vIdCantidad, vIdUnidad, vIdConcepto, vsComplemento,
                                                                       vPrecio, vIVAPorcentaje, vIVA, vRetencion, vSubtotal, DescuentosISN, vIdFacturaRela, IdTipoFactura, vIncluyeIVA, OperadorBD.OperadorGlobal.IdOperador,
                                                                       OperadorBD.OperadorGlobal.NombreUsuario, ref vIdDetail);
                        }

                        //if (txtcargarArchivo.Text != string.Empty)
                        //{
                        //    this.spSoloRespuesta1.stpFactInsPagoFactura(vIdFactura, vIdBancoOrigen, vIdCueta, vIdBancoDestino, vFechaPago,
                        //                                        vDeposito, stFile, OperadorBD.OperadorGlobal.IdOperador, OperadorBD.OperadorGlobal.NombreUsuario, ref vIdDetail);
                        //}

                        XtraMessageBox.Show("¡La Solicitud No. " + vIdSolicitud.ToString() + " fue generada correctamente!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //Limpiar 
                        ActivarBotonesC(true);
                        Limpiar(true);
                        cbControl.Enabled = false;
                        cbControl.BackColor = Color.LightGoldenrodYellow;
                        cbFacturaRelacion.Enabled = false;
                        cbTipoRelacion.Enabled = false;
                        cbTipoRelacion.BackColor = Color.LightGoldenrodYellow;

                        // TODO: This line of code loads data into the 'dbSAICBPOFactura.vwFactCatUsoCFDI' table. You can move, or remove it, as needed.
                        this.stpFactSelUsoCFDITableAdapter.Fill(this.dbSAICBPOFactura.stpFactSelUsoCFDI, IdTipoRelacion, IdTipoFactura, NoFactura, IdHeaderFactura);

                        this.stpFactSelCatTipoRelacionv2TableAdapter.Fill(this.dbSAICBPOFactura.stpFactSelCatTipoRelacionv2, IdTipoFactura, 27);

                    }
                    else
                        XtraMessageBox.Show("¡Error en Conexión Intente más tarde!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    XtraMessageBox.Show("¡Error en Conexión Intente más tarde!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'dbSAICBPOFactura.controlOperacionesTableAdapter' table. You can move, or remove it, as needed.
                this.stpFactSelControlOperacionesV2TableAdapter.Fill(this.dbSAICBPOFactura.stpFactSelControlOperacionesV2, -1, -1, -1, -1, 2, OperadorBD.OperadorGlobal.IdOperador, true, "", "");

                cbControl.Enabled = true;
                cbControl.BackColor = Color.White;

                ActivarBotonesC(false);
                cbFacturaRelacion.Enabled = false;
                cbFacturaRelacion.BackColor = Color.LightGoldenrodYellow;

                cbFacturaRelacionRecibo.Enabled = false;
                cbTipoRelacion.Enabled = false;
                cbTipoRelacion.BackColor = Color.LightGoldenrodYellow;
                cbIdTenedora.Enabled = false;
                cbIdTenedora.BackColor = Color.LightGoldenrodYellow;
                cboIdCliente.Enabled = false;
                cboIdCliente.BackColor = Color.LightGoldenrodYellow;

                ControlTotal = 0;
                Limpiar(true);
                btnLimpia.Visible = true;
                IdTipoRelacion = 0;
                IdHeaderFactura = 0;
                NoFactura = 0;
                dbSAICBPOFactura.stpFactSelFacturasARelacionarSAT.Clear();

                if (cbFacturaRelacion.EditValue != null && Convert.ToInt32(cbFacturaRelacion.EditValue) != -1)
                    cbFacturaRelacion.EditValue = -1;
                if (cbFacturaRelacionRecibo.EditValue != null && Convert.ToInt32(cbFacturaRelacionRecibo.EditValue) != -1)
                    cbFacturaRelacionRecibo.EditValue = -1;

                this.stpFactSelUsoCFDITableAdapter.Fill(dbSAICBPOFactura.stpFactSelUsoCFDI, IdTipoRelacion, IdTipoFactura, NoFactura, IdHeaderFactura);
                flagSinControl = false;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                splashSMCargando.CloseWaitForm();
            }
        }

        private void btRelacionar_Click(object sender, EventArgs e)
        {
            try
            {
                cbFacturaRelacion.Enabled = true;
                cbFacturaRelacion.BackColor = Color.White;
                cbTipoRelacion.Enabled = true;
                cbTipoRelacion.BackColor = Color.White;

                btnLimpia.Visible = true;
                btnxAnticipo.Visible = true;
                btnREP.Visible = true;
                btnPublicoGeneral.Visible = true;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                splashSMCargando.CloseWaitForm();
            }
        }

        private void btnConcepto_Click(object sender, EventArgs e)
        {
            Int32 IdBeneficiario = 0;
            Int64 IdFacturaRela = 0;
            bool bFlagIVA = false;
            bool bExento = false;
            string bIVA = "";
            bMoneda = "";
            double bTotal = 0;
            RestoPago = 0;
            string bFlagTipos = "", pSerieFolio = ""; // C= Control, N=Normal, NC= Nota de Credito Normal, A1-Anticipo, A2-Anticipo Servicio Entregado, A3-Nota de Credito Anticipo
            try
            {
                //obtener No. de Version CFDI
                if (Validator.IsPresent(cbIdFronting) && Validator.IsPresent(cbTipoFacturador) && Validator.IsPresent(cbUsoCFDI) && Validator.IsPresent(txtIVAPor))
                {
                    bIVA = txtIVAPor.Text;
                    bTotal = 0;
                    if (!TieneIVA8)
                    {
                        if ((txtIVAPor.Text.Equals("16.") || txtIVAPor.Text.Equals("0.")))
                        {
                            if (cbTipoFacturador.Text == "CLIENTE")
                            {
                                if (Validator.IsPresent(cboIdCliente))
                                {
                                    IdBeneficiario = (Int32)cboIdCliente.EditValue;
                                }
                            }
                            else
                            {
                                if (Validator.IsPresent(cbIdTenedora))
                                {
                                    IdBeneficiario = (Int32)cbIdTenedora.EditValue;
                                }
                            }

                            // C= Control, R=Recibo de Pago,  N=Normal, NC= Nota de Credito Normal, A1-Anticipo, A2-Anticipo Servicio Entregado, A3-Nota de Credito Anticipo
                            if (IdTipoFactura == "N" && btnControl.Visible == false)
                                bFlagTipos = "C";
                            else if (IdTipoFactura == "R")
                                bFlagTipos = "R";
                            else if (IdTipoFactura == "N" && cbTipoRelacion.Enabled == false)
                                bFlagTipos = "N";
                            else if (IdTipoFactura == "N" && cbTipoRelacion.Enabled == true)
                            {
                                if (Validator.IsPresent(cbTipoRelacion))
                                {
                                    if (cbTipoRelacion.EditValue.ToString() == "2")
                                        bFlagTipos = "NC";
                                    else if (cbTipoRelacion.EditValue.ToString() == "5")
                                        bFlagTipos = "NS";
                                    else
                                        bFlagTipos = "NR";
                                }
                            }
                            else if (IdTipoFactura == "G" && cbTipoRelacion.Enabled == false)
                                bFlagTipos = "G";
                            else if (IdTipoFactura == "G" && cbTipoRelacion.Enabled == true)
                            {
                                if (Validator.IsPresent(cbTipoRelacion))
                                {
                                    if (cbTipoRelacion.EditValue.ToString() == "5")
                                        bFlagTipos = "GS";
                                }
                            }
                            else if (IdTipoFactura == "A" && cbTipoRelacion.Enabled == false)
                                bFlagTipos = "A1";
                            else if (IdTipoFactura == "A" && cbTipoRelacion.Enabled == true)
                            {
                                if (Validator.IsPresent(cbTipoRelacion))
                                {
                                    if (cbTipoRelacion.EditValue.ToString() == "2")
                                        bFlagTipos = "A3";
                                    else
                                        bFlagTipos = "A2";
                                }
                            }

                            if (IdBeneficiario > 0 && bFlagTipos != "")
                            {
                                bTotal = RestoPago;

                                // Cargar DATOS   
                                if (bFlagTipos == "R")
                                {
                                    dt.Rows.Clear();
                                    if (gridView16.GetSelectedRows().Count() > 0)
                                    {
                                        foreach (var item in gridView16.GetSelectedRows())
                                        {
                                            DataRow row = gridView16.GetDataRow(item);
                                            IdFacturaRela = Convert.ToInt64(row[0].ToString());
                                            RestoPago = Convert.ToDouble(row[35].ToString());
                                            bTotal = RestoPago;
                                            bIVA = row[38].ToString();
                                            bMoneda = row[14].ToString();
                                            if (Convert.ToDecimal(row[18].ToString()) > 0)
                                                bFlagIVA = true;
                                            else
                                                bFlagIVA = false;
                                            bExento = Convert.ToBoolean(row[39].ToString());
                                            pSerieFolio = "Serie Folio:  " + row[26].ToString() + "-" + row[27].ToString();
                                            CargarConceptos(IdBeneficiario, IdFacturaRela, bTotal, bFlagTipos, pSerieFolio, bFlagIVA, bIVA, bExento, bMoneda);
                                        }
                                    }
                                    else
                                        XtraMessageBox.Show("¡Debe de Seleccionar por lo menos una Factura Relacionada!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else if (cbTipoRelacion.Enabled == true && cbTipoRelacion.EditValue.ToString() != "5")
                                {
                                    dt.Rows.Clear();
                                    if (gridView9.GetSelectedRows().Count() > 0)
                                    {
                                        foreach (var item in gridView9.GetSelectedRows())
                                        {
                                            DataRow row = gridView9.GetDataRow(item);
                                            bIVA = row[38].ToString();
                                            bMoneda = row[14].ToString();
                                            if (Convert.ToDecimal(row[18].ToString()) > 0)
                                                bFlagIVA = true;
                                            else
                                                bFlagIVA = false;
                                            bExento = Convert.ToBoolean(row[39].ToString());
                                            RestoPago = Convert.ToDouble(row[35].ToString());
                                            bTotal = RestoPago;

                                        }
                                        CargarConceptos(IdBeneficiario, IdFacturaRela, bTotal, bFlagTipos, pSerieFolio, bFlagIVA, bIVA, bExento, bMoneda);
                                    }
                                    else
                                        XtraMessageBox.Show("¡Debe de Seleccionar una Factura a Relacionada!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                    CargarConceptos(IdBeneficiario, IdFacturaRela, bTotal, bFlagTipos, pSerieFolio, bFlagIVA, bIVA, bExento, bMoneda);

                            }
                        }
                        else
                            XtraMessageBox.Show("¡Solo se Permite 16% ó 0% de IVA!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                        if ((txtIVAPor.Text.Equals("16.") || txtIVAPor.Text.Equals("8.") || txtIVAPor.Text.Equals("0.")))
                        {
                            if (cbTipoFacturador.Text == "CLIENTE")
                            {
                                if (Validator.IsPresent(cboIdCliente))
                                {
                                    IdBeneficiario = (Int32)cboIdCliente.EditValue;
                                }
                            }
                            else
                            {
                                if (Validator.IsPresent(cbIdTenedora))
                                {
                                    IdBeneficiario = (Int32)cbIdTenedora.EditValue;
                                }
                            }

                            // C= Control, R=Recibo de Pago,  N=Normal, NC= Nota de Credito Normal, A1-Anticipo, A2-Anticipo Servicio Entregado, A3-Nota de Credito Anticipo
                            if (IdTipoFactura == "N" && btnControl.Visible == false)
                                bFlagTipos = "C";
                            else if (IdTipoFactura == "R")
                                bFlagTipos = "R";
                            else if (IdTipoFactura == "N" && cbTipoRelacion.Enabled == false)
                                bFlagTipos = "N";
                            else if (IdTipoFactura == "N" && cbTipoRelacion.Enabled == true)
                            {
                                if (Validator.IsPresent(cbTipoRelacion))
                                {
                                    if (cbTipoRelacion.EditValue.ToString() == "2")
                                        bFlagTipos = "NC";
                                    else if (cbTipoRelacion.EditValue.ToString() == "5")
                                        bFlagTipos = "NS";
                                    else
                                        bFlagTipos = "NR";
                                }
                            }
                            else if (IdTipoFactura == "G" && cbTipoRelacion.Enabled == false)
                                bFlagTipos = "G";
                            else if (IdTipoFactura == "G" && cbTipoRelacion.Enabled == true)
                            {
                                if (Validator.IsPresent(cbTipoRelacion))
                                {
                                    if (cbTipoRelacion.EditValue.ToString() == "5")
                                        bFlagTipos = "GS";
                                }
                            }
                            else if (IdTipoFactura == "A" && cbTipoRelacion.Enabled == false)
                                bFlagTipos = "A1";
                            else if (IdTipoFactura == "A" && cbTipoRelacion.Enabled == true)
                            {
                                if (Validator.IsPresent(cbTipoRelacion))
                                {
                                    if (cbTipoRelacion.EditValue.ToString() == "2")
                                        bFlagTipos = "A3";
                                    else
                                        bFlagTipos = "A2";
                                }
                            }

                            if (IdBeneficiario > 0 && bFlagTipos != "")
                            {
                                bTotal = RestoPago;

                                // Cargar DATOS   
                                if (bFlagTipos == "R")
                                {
                                    dt.Rows.Clear();
                                    if (gridView16.GetSelectedRows().Count() > 0)
                                    {
                                        foreach (var item in gridView16.GetSelectedRows())
                                        {
                                            DataRow row = gridView16.GetDataRow(item);
                                            IdFacturaRela = Convert.ToInt64(row[0].ToString());
                                            RestoPago = Convert.ToDouble(row[35].ToString());
                                            bTotal = RestoPago;
                                            bIVA = row[38].ToString();
                                            bMoneda = row[14].ToString();
                                            if (Convert.ToDecimal(row[18].ToString()) > 0)
                                                bFlagIVA = true;
                                            else
                                                bFlagIVA = false;
                                            bExento = Convert.ToBoolean(row[39].ToString());
                                            pSerieFolio = "Serie Folio:  " + row[26].ToString() + "-" + row[27].ToString();
                                            CargarConceptos(IdBeneficiario, IdFacturaRela, bTotal, bFlagTipos, pSerieFolio, bFlagIVA, bIVA, bExento, bMoneda);
                                        }
                                    }
                                    else
                                        XtraMessageBox.Show("¡Debe de Seleccionar por lo menos una Factura Relacionada!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else if (cbTipoRelacion.Enabled == true && cbTipoRelacion.EditValue.ToString() != "5")
                                {
                                    dt.Rows.Clear();
                                    if (gridView9.GetSelectedRows().Count() > 0)
                                    {
                                        foreach (var item in gridView9.GetSelectedRows())
                                        {
                                            DataRow row = gridView9.GetDataRow(item);
                                            bIVA = row[38].ToString();
                                            bMoneda = row[14].ToString();
                                            if (Convert.ToDecimal(row[18].ToString()) > 0)
                                                bFlagIVA = true;
                                            else
                                                bFlagIVA = false;
                                            bExento = Convert.ToBoolean(row[39].ToString());
                                            RestoPago = Convert.ToDouble(row[35].ToString());
                                            bTotal = RestoPago;
                                        }
                                        CargarConceptos(IdBeneficiario, IdFacturaRela, bTotal, bFlagTipos, pSerieFolio, bFlagIVA, bIVA, bExento, bMoneda);
                                    }
                                    else
                                        XtraMessageBox.Show("¡Debe de Seleccionar una Factura a Relacionada!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                    CargarConceptos(IdBeneficiario, IdFacturaRela, bTotal, bFlagTipos, pSerieFolio, bFlagIVA, bIVA, bExento, bMoneda);
                            }
                        }
                        else
                            XtraMessageBox.Show("¡Solo se Permite 16%, 8% ó 0% de IVA!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarConceptos(Int32 IdBeneficiario, Int64 IdFacturaRela, double Total, string bFlagTipos, string pSerieFolio, bool bFlagIVA, string bIVAPorc, bool bExento, string bMoneda)
        {
            bool bRetencion = false;

            if (flagSinControl)
            {
                bRetencion = true;
            }

            Facturas.frmAgregarConceptos objAsignarXML = new Facturas.frmAgregarConceptos()
            {
                pIdFronting = Convert.ToInt32(cbIdFronting.EditValue.ToString()),
                pIdTipoBeneficiario = Convert.ToInt32(cbTipoFacturador.EditValue.ToString()),
                pIdBeneficiario = IdBeneficiario,
                pBFLAG = bFlagTipos,
                pUnitario = ControlTotal,
                pIVAGlobal = txtIVAPor.Text,
                pIdUsoCFDI = Convert.ToInt32(cbUsoCFDI.EditValue.ToString()),
                pRestoPago = Total,
                pIdFacturaRelacion = IdFacturaRela,
                pFOLIOSERIE = pSerieFolio,
                pRetencion = bRetencion,
                pConRetencion = flagControConRetencion,
                pFlagIVA = bFlagIVA,
                pIVAPorc = bIVAPorc,
                pExento = bExento,
                pMoneda = cbMoneda.Text,
                pMonedaOri = bMoneda,
                pTipoCambio = Convert.ToDouble(txtCambio.Text.ToString())
            };
            objAsignarXML.ShowDialog();     //mostrar pantalla

            if (objAsignarXML.Agregar)
            {

                if (objAsignarXML.pIVA)
                    NoTieneIvaxConcepto++;

                Double dDescuento = 0;

                if (objAsignarXML.IVAPor == 16)
                {
                    dDescuento = 1.1;
                }
                else if (objAsignarXML.IVAPor == 8)
                {
                    dDescuento = 1.02;
                }

                DataRow dr = dt.NewRow();
                dr["colCantidad"] = objAsignarXML.pCantidad;
                dr["colIdConcepto"] = objAsignarXML.pIdConcepto;
                dr["colConcepto"] = objAsignarXML.pDesc;
                dr["colConceptoPresentar"] = objAsignarXML.pDescFull;
                dr["colIdUnidad"] = objAsignarXML.pIdUnidad;
                dr["colTotalDescuento"] = objAsignarXML.pDescuento;
                dr["colIdFacturaRela"] = objAsignarXML.pIdFacturaRelacion;
                dr["colObjetoImpuesto"] = objAsignarXML.pObjetoImpuesto;
                // C= Control, R=Recibo de Pago,  N=Normal, NC= Nota de Credito Normal, A1-Anticipo, A2-Anticipo Servicio Entregado, A3-Nota de Credito Anticipo
                switch (bFlagTipos)
                {
                    case "C":
                        dr["colPrecioUnitario"] = objAsignarXML.pUnitario - ControlIVA;
                        dr["colImporte"] = objAsignarXML.pUnitario - ControlIVA;
                        dr["colIVA"] = true;
                        dr["colPorIVA"] = objAsignarXML.IVAPor;
                        dr["colTotalIVA"] = ControlIVA;
                        dr["colRetencion"] = ControlRetencion;
                        dr["colImporteTotal"] = objAsignarXML.pUnitario;

                        if (objAsignarXML.pRetencion)
                        {
                            dr["colPrecioUnitario"] = Math.Round(objAsignarXML.pUnitario / dDescuento, 2);
                            dr["colImporte"] = Math.Round((objAsignarXML.pUnitario / dDescuento) * objAsignarXML.pCantidad, 2);
                            dr["colTotalIVA"] = Math.Round(((objAsignarXML.pUnitario / dDescuento) * objAsignarXML.pCantidad) * (objAsignarXML.IVAPor / 100), 2);
                            dr["colRetencion"] = Math.Round(((objAsignarXML.pUnitario / dDescuento) * objAsignarXML.pCantidad) * 0.06, 2);
                        }

                        break;
                    case "NR":
                        dr["colPrecioUnitario"] = objAsignarXML.pUnitario;
                        dr["colImporte"] = (objAsignarXML.pUnitario * objAsignarXML.pCantidad);
                        dr["colIVA"] = objAsignarXML.pIVA;
                        if (!objAsignarXML.pIVA)
                        {
                            dr["colPorIVA"] = 0;
                            dr["colTotalIVA"] = 0;
                            dr["colRetencion"] = 0;
                            dr["colImporteTotal"] = (objAsignarXML.pUnitario * objAsignarXML.pCantidad);
                        }
                        else
                        {
                            dr["colPorIVA"] = objAsignarXML.IVAPor;
                            dr["colTotalIVA"] = Math.Round(objAsignarXML.pIVA == false ? 0 : (objAsignarXML.pUnitario * objAsignarXML.pCantidad) * (objAsignarXML.IVAPor / 100), 2);
                            dr["colRetencion"] = 0;
                            dr["colImporteTotal"] = (objAsignarXML.pUnitario * objAsignarXML.pCantidad) +
                                                    Math.Round(objAsignarXML.pIVA == false ? 0 : (objAsignarXML.pUnitario * objAsignarXML.pCantidad) * (objAsignarXML.IVAPor / 100), 2);
                        }
                        break;
                    case "R":
                        dr["colPrecioUnitario"] = Math.Round(objAsignarXML.pIVA == false ? objAsignarXML.pUnitario : (objAsignarXML.pUnitario) / (1 + (objAsignarXML.IVAPor / 100)), 2);
                        dr["colImporte"] = Math.Round(objAsignarXML.pIVA == false ? objAsignarXML.pUnitario : (objAsignarXML.pUnitario) / (1 + (objAsignarXML.IVAPor / 100)), 2);
                        dr["colIVA"] = objAsignarXML.pIVA; //false;
                        dr["colPorIVA"] = objAsignarXML.IVAPor;
                        dr["colTotalIVA"] = objAsignarXML.pUnitario - Math.Round(objAsignarXML.pIVA == false ? objAsignarXML.pUnitario : (objAsignarXML.pUnitario) / (1 + (objAsignarXML.IVAPor / 100)), 2);
                        dr["colRetencion"] = 0;
                        dr["colImporteTotal"] = objAsignarXML.pUnitario;

                        txtCambio.Text = objAsignarXML.pTipoCambio.ToString();
                        txtIVAPor.Text = objAsignarXML.IVAPor.ToString();
                        txtTotalP.Text = (Convert.ToDouble(txtTotalP.Text.Replace("$","")) + objAsignarXML.pUnitarioP).ToString();
                        

                        break;
                    case "NC":
                        dr["colPrecioUnitario"] = objAsignarXML.pUnitario;
                        dr["colImporte"] = objAsignarXML.pUnitario * objAsignarXML.pCantidad;

                        dr["colIVA"] = objAsignarXML.pIVA;
                        if (!objAsignarXML.pIVA)
                        {
                            dr["colPorIVA"] = 0;
                            dr["colTotalIVA"] = 0;
                            dr["colRetencion"] = 0;
                            dr["colImporteTotal"] = objAsignarXML.pUnitario * objAsignarXML.pCantidad;
                        }
                        else
                        {
                            dr["colPorIVA"] = objAsignarXML.IVAPor;
                            txtIVAPor.EditValue = objAsignarXML.IVAPor;
                            dr["colTotalIVA"] = Math.Round(objAsignarXML.pIVA == false ? 0 : (objAsignarXML.pUnitario * objAsignarXML.pCantidad) * (objAsignarXML.IVAPor / 100), 2);

                            if (objAsignarXML.IVAPor != 0)
                            {
                                dr["colRetencion"] = Math.Round(objAsignarXML.pRetencionIVA, 2);
                                dr["colImporteTotal"] = (objAsignarXML.pUnitario * objAsignarXML.pCantidad) + Math.Round(objAsignarXML.pIVA == false ? 0 : (objAsignarXML.pUnitario * objAsignarXML.pCantidad) * (objAsignarXML.IVAPor / 100), 2) -
                                                        Math.Round(objAsignarXML.pRetencionIVA, 2);
                            }
                            else
                            {
                                dr["colRetencion"] = 0;
                                dr["colImporteTotal"] = Math.Round(objAsignarXML.pUnitario * objAsignarXML.pCantidad, 2) +
                                                        Math.Round(objAsignarXML.pIVA == false ? 0 : (objAsignarXML.pUnitario * objAsignarXML.pCantidad) * (objAsignarXML.IVAPor / 100), 2);
                            }
                        }
                        break;
                    case "A2":
                        dr["colPrecioUnitario"] = objAsignarXML.pUnitario;
                        dr["colImporte"] = objAsignarXML.pUnitario * objAsignarXML.pCantidad;

                        dr["colIVA"] = objAsignarXML.pIVA;
                        if (!objAsignarXML.pIVA)
                        {
                            dr["colPorIVA"] = 0;
                            dr["colTotalIVA"] = 0;
                            dr["colRetencion"] = 0;
                            dr["colImporteTotal"] = objAsignarXML.pUnitario * objAsignarXML.pCantidad;
                        }
                        else
                        {
                            dr["colPorIVA"] = objAsignarXML.IVAPor;
                            txtIVAPor.EditValue = objAsignarXML.IVAPor;
                            dr["colTotalIVA"] = Math.Round(objAsignarXML.pIVA == false ? 0 : (objAsignarXML.pUnitario * objAsignarXML.pCantidad) * (objAsignarXML.IVAPor / 100), 2);

                            if (objAsignarXML.IVAPor != 0)
                            {
                                dr["colRetencion"] = Math.Round(objAsignarXML.pRetencionIVA, 2);
                                dr["colImporteTotal"] = (objAsignarXML.pUnitario * objAsignarXML.pCantidad) + Math.Round(objAsignarXML.pIVA == false ? 0 : (objAsignarXML.pUnitario * objAsignarXML.pCantidad) * (objAsignarXML.IVAPor / 100), 2) -
                                                        Math.Round(objAsignarXML.pRetencionIVA, 2);
                            }
                            else
                            {
                                dr["colRetencion"] = 0;
                                dr["colImporteTotal"] = Math.Round(objAsignarXML.pUnitario * objAsignarXML.pCantidad, 2) +
                                                        Math.Round(objAsignarXML.pIVA == false ? 0 : (objAsignarXML.pUnitario * objAsignarXML.pCantidad) * (objAsignarXML.IVAPor / 100), 2);
                            }
                        }
                        break;
                    case "A3":
                        dr["colPrecioUnitario"] = objAsignarXML.pUnitario;
                        dr["colImporte"] = objAsignarXML.pUnitario * objAsignarXML.pCantidad;

                        dr["colIVA"] = objAsignarXML.pIVA;
                        if (!objAsignarXML.pIVA)
                        {
                            dr["colPorIVA"] = 0;
                            dr["colTotalIVA"] = 0;
                            dr["colRetencion"] = 0;
                            dr["colImporteTotal"] = objAsignarXML.pUnitario * objAsignarXML.pCantidad;
                        }
                        else
                        {
                            dr["colPorIVA"] = objAsignarXML.IVAPor;
                            txtIVAPor.EditValue = objAsignarXML.IVAPor;
                            dr["colTotalIVA"] = Math.Round(objAsignarXML.pIVA == false ? 0 : (objAsignarXML.pUnitario * objAsignarXML.pCantidad) * (objAsignarXML.IVAPor / 100), 2);

                            if (objAsignarXML.IVAPor != 0)
                            {
                                dr["colRetencion"] = Math.Round(objAsignarXML.pRetencionIVA, 2);
                                dr["colImporteTotal"] = (objAsignarXML.pUnitario * objAsignarXML.pCantidad) + Math.Round(objAsignarXML.pIVA == false ? 0 : (objAsignarXML.pUnitario * objAsignarXML.pCantidad) * (objAsignarXML.IVAPor / 100), 2) -
                                                        Math.Round(objAsignarXML.pRetencionIVA, 2);
                            }
                            else
                            {
                                dr["colRetencion"] = 0;
                                dr["colImporteTotal"] = Math.Round(objAsignarXML.pUnitario * objAsignarXML.pCantidad, 2) +
                                                        Math.Round(objAsignarXML.pIVA == false ? 0 : (objAsignarXML.pUnitario * objAsignarXML.pCantidad) * (objAsignarXML.IVAPor / 100), 2);
                            }
                        }
                        break;
                    default:
                        dr["colPrecioUnitario"] = objAsignarXML.pUnitario;
                        dr["colImporte"] = objAsignarXML.pUnitario * objAsignarXML.pCantidad;

                        dr["colIVA"] = objAsignarXML.pIVA;
                        if (!objAsignarXML.pIVA)
                        {
                            dr["colPorIVA"] = 0;
                            dr["colTotalIVA"] = 0;
                            dr["colRetencion"] = 0;
                            dr["colImporteTotal"] = objAsignarXML.pUnitario * objAsignarXML.pCantidad;
                        }
                        else
                        {
                            dr["colPorIVA"] = objAsignarXML.IVAPor;
                            dr["colTotalIVA"] = Math.Round(objAsignarXML.pIVA == false ? 0 : (objAsignarXML.pUnitario * objAsignarXML.pCantidad) * (objAsignarXML.IVAPor / 100), 2);

                            if (objAsignarXML.pRetencion && objAsignarXML.IVAPor != 0)
                            {
                                dr["colRetencion"] = Math.Round(objAsignarXML.pIVA == false ? 0 : (objAsignarXML.pUnitario * objAsignarXML.pCantidad) * (.06), 2);
                                dr["colImporteTotal"] = (objAsignarXML.pUnitario * objAsignarXML.pCantidad) + Math.Round(objAsignarXML.pIVA == false ? 0 : (objAsignarXML.pUnitario * objAsignarXML.pCantidad) * (objAsignarXML.IVAPor / 100), 2) -
                                                        Math.Round(objAsignarXML.pIVA == false ? 0 : (objAsignarXML.pUnitario * objAsignarXML.pCantidad) * (.06), 2);
                            }
                            else
                            {
                                dr["colRetencion"] = 0;
                                dr["colImporteTotal"] = Math.Round(objAsignarXML.pUnitario * objAsignarXML.pCantidad, 2) +
                                                        Math.Round(objAsignarXML.pIVA == false ? 0 : (objAsignarXML.pUnitario * objAsignarXML.pCantidad) * (objAsignarXML.IVAPor / 100), 2);
                            }
                        }
                        break;
                }

                if (bFlagTipos == "R")
                {
                    if (objAsignarXML.pMoneda != objAsignarXML.pMonedaOri)
                    {
                        dr["colPrecioUnitarioCB"] = Math.Round(Convert.ToDecimal(Math.Round(objAsignarXML.pIVA == false ? objAsignarXML.pUnitario : (objAsignarXML.pUnitario) / (1 + (objAsignarXML.IVAPor / 100)), 2)) / Convert.ToDecimal(objAsignarXML.pTipoCambio), 2);
                        dr["colImporteCB"] = Math.Round(Convert.ToDecimal(Math.Round(objAsignarXML.pIVA == false ? objAsignarXML.pUnitario : (objAsignarXML.pUnitario) / (1 + (objAsignarXML.IVAPor / 100)), 2)) / Convert.ToDecimal(objAsignarXML.pTipoCambio), 2);
                        dr["colTotalIVACB"] = Math.Round(Convert.ToDecimal(objAsignarXML.pUnitario - Math.Round(objAsignarXML.pIVA == false ? objAsignarXML.pUnitario : (objAsignarXML.pUnitario) / (1 + (objAsignarXML.IVAPor / 100)), 2)) / Convert.ToDecimal(objAsignarXML.pTipoCambio), 2);
                        dr["colImporteTotalCB"] = objAsignarXML.pUnitarioP;
                    }
                    else
                    {
                        dr["colPrecioUnitarioCB"] = dr["colPrecioUnitario"];
                        dr["colImporteCB"] = dr["colImporte"];
                        dr["colTotalIVACB"] = dr["colTotalIVA"];
                        dr["colImporteTotalCB"] = dr["colImporteTotal"];
                    }
                }
                else
                {
                    dr["colPrecioUnitarioCB"] = dr["colPrecioUnitario"];
                    dr["colImporteCB"] = dr["colImporte"];
                    dr["colTotalIVACB"] = dr["colTotalIVA"];
                    dr["colImporteTotalCB"] = dr["colImporteTotal"];
                }

                if (bFlagTipos == "C" && dt.Rows.Count == 0)
                    dt.Rows.Add(dr);
                else if (bFlagTipos == "C" && dt.Rows.Count > 0)
                    XtraMessageBox.Show("¡Solo se permite agregar un concepto!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if ((bFlagTipos == "NC" || bFlagTipos == "NR" || bFlagTipos == "A1" || bFlagTipos == "A3") && dt.Rows.Count > 0) // bFlagTipos == "R" ||
                    XtraMessageBox.Show("¡Solo se permite agregar un concepto!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    dt.Rows.Add(dr);

                gvConceptos.DataSource = dt;
                Totales();
            }
        }

        private void cbControl_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Limpiar(false);
                DataRow row = gridView8.GetDataRow(gridView8.FocusedRowHandle);
                //obtener el renglon completo del Combobox
                if (row != null)
                {
                    //asignar valores extraidos del Combobox
                    cbIdFronting.EditValue = Convert.ToInt32(row[2].ToString());
                    cbTipoFacturador.EditValue = 2;
                    cboIdCliente.EditValue = row[1];
                    cbMoneda.EditValue = row[28];
                    txtCambio.Text = Convert.ToDecimal(row[29].ToString()).ToString();
                    Controlsubtotal = Convert.ToDouble(row[25].ToString());
                    ControlIVA = Convert.ToDouble(row[26].ToString());
                    ControlRetencion = Convert.ToDouble(row[79].ToString());
                    ControlTotal = Convert.ToDouble(row[27].ToString());
                    Boolean.TryParse(row[80].ToString(), out flagControConRetencion);
                }
                else
                {
                    XtraMessageBox.Show("¡Debe de Seleccionar un Control!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbMetodoPago_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (!flatClickEnFacturadora)
                {
                    LimpiarCampos(false);
                    if (cbMetodoPago.EditValue != null)
                    {
                        this.stpFactSelObtenerFormaPagoTableAdapter.Fill(dbSAICBPOFactura.stpFactSelObtenerFormaPago, Convert.ToInt32(cbMetodoPago.EditValue.ToString()));
                        if (cbMetodoPago.EditValue.ToString() == "2")
                        {
                            cbFormaPago.Enabled = true;
                            cbFormaPago.BackColor = Color.White;

                            cbBancoOrigen.Enabled = true;
                            cbBancoOrigen.BackColor = Color.White;

                            cbCuentaOrigen.Enabled = true;
                            cbCuentaOrigen.BackColor = Color.White;

                            txtcargarArchivo.Enabled = true;
                            txtcargarArchivo.BackColor = Color.White;

                            dtFechaPago.Enabled = true;
                            dtFechaPago.BackColor = Color.White;

                            cbMoneda.Enabled = true;
                            cbMoneda.BackColor = Color.White;

                            cbBancoDestino.Enabled = true;
                            cbBancoDestino.BackColor = Color.White;

                            txtDeposito.Enabled = true;
                            txtDeposito.BackColor = Color.White;
                        }
                        else if (cbMetodoPago.EditValue.ToString() == "3")
                        {
                            cbFormaPago.EditValue = 23;
                            cbFormaPago.Enabled = false;
                            cbFormaPago.BackColor = Color.LightGoldenrodYellow;

                            cbBancoOrigen.Enabled = false;
                            cbBancoOrigen.BackColor = Color.LightGoldenrodYellow;

                            cbCuentaOrigen.Enabled = false;
                            cbCuentaOrigen.BackColor = Color.LightGoldenrodYellow;

                            txtcargarArchivo.Enabled = false;
                            txtcargarArchivo.BackColor = Color.LightGoldenrodYellow;

                            dtFechaPago.Enabled = false;
                            dtFechaPago.BackColor = Color.LightGoldenrodYellow;

                            cbMoneda.EditValue = "MXP";
                            cbMoneda.Text = "MXP";

                            cbBancoDestino.Enabled = false;
                            cbBancoDestino.BackColor = Color.LightGoldenrodYellow;

                            txtDeposito.Enabled = false;
                            txtDeposito.BackColor = Color.LightGoldenrodYellow;
                        }
                    }
                    else
                    {
                        cbFormaPago.Enabled = false;
                        cbFormaPago.BackColor = Color.LightGoldenrodYellow;
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboTipoFacturador_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (!flatClickEnFacturadora)
                {
                    if (cbTipoFacturador.Text == "CLIENTE")
                    {
                        cboIdCliente.Visible = true;
                        cbIdTenedora.Visible = false;
                        cboIdCliente.Enabled = true;
                        cboIdCliente.BackColor = Color.White;
                        IdTipoCliente = 2;
                    }
                    else
                    {
                        cboIdCliente.Visible = false;
                        cbIdTenedora.Visible = true;
                        cbIdTenedora.Enabled = true;
                        cbIdTenedora.BackColor = Color.White;
                        IdTipoCliente = 3;

                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //bandera pasa saber el click en factura
        Boolean flatClickEnFacturadora = false;

        private void cboIdFronting_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                LimpiarCampos(true);
                //obtener el renglon completo del Combobox                
                if (cbIdFronting.EditValue != null)
                {
                    //asignar valores extraidos del Combobox
                    stpFactSelBeneficiarioClienteNTableAdapter.Fill(dbSAICBPOFactura.stpFactSelBeneficiarioClienteN, Convert.ToInt32(cbIdFronting.EditValue.ToString()), IdTipoFactura);
                    stpFactSelBeneficiarioTenedoraTableAdapter.Fill(dbSAICBPOFactura.stpFactSelBeneficiarioTenedora, Convert.ToInt32(cbIdFronting.EditValue.ToString()));

                    string Id = "0";
                    if (cbIdFronting.EditValue != null)
                    {
                        Id = cbIdFronting.EditValue.ToString();
                        this.stpFactSelObtenerParametrosFrontingTableAdapter1.Fill(dbSAICBPOFactura.stpFactSelObtenerParametrosFronting, Convert.ToInt32(Id));

                        if (dbSAICBPOFactura.stpFactSelObtenerParametrosFronting.Count > 0)
                        {
                            //obtener el No. de Items seleccionados
                            DataRow row = null;
                            for (int i = 0; i < dbSAICBPOFactura.stpFactSelObtenerParametrosFronting.Count; i++)
                            {
                                row = dbSAICBPOFactura.stpFactSelObtenerParametrosFronting.Rows[i];
                                TieneIVA8 = Convert.ToBoolean(row[0]);
                                if (TieneIVA8)
                                    TieneIVAGlobla = (row[1].ToString() == "1" ? "16" : row[1].ToString());
                                else
                                    TieneIVAGlobla = (row[1].ToString() == "1" ? "16" : row[1].ToString());
                            }

                            CargarIVA(TieneIVA8, TieneIVAGlobla);
                        }
                        else
                        {
                            CargarIVA(false, TieneIVAGlobla);
                            TieneIVAGlobla = "16";
                        }
                    }
                    else
                    {
                        //Activar Botones
                        ActivarBotonesC(false);
                        XtraMessageBox.Show("¡Debe de Seleccionar una Fronting!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos(Boolean limpiarMetodoPago)
        {
            int IdBeneficiario = 0;
            flatClickEnFacturadora = true;
            int? bfLAG = 0;

            if (limpiarMetodoPago)
            {
                this.dbSAICBPOFactura.stpFactSelFacturasARelacionarSAT.Clear();
                this.dbSAICBPOFactura.stpFactSelFacturasARelacionarSAT1.Clear();
            }

            if (limpiarMetodoPago && IdTipoFactura != "A" && IdTipoFactura != "R" && IdTipoFactura != "G")
            {
                cbMetodoPago.Text = String.Empty;
                cbMetodoPago.EditValue = "-1";
            }

            if (IdTipoCliente == 2)
                IdBeneficiario = Convert.ToInt32(cboIdCliente.EditValue);
            else
                IdBeneficiario = Convert.ToInt32(cbIdTenedora.EditValue);

            if (IdTipoRelacion != 11)
            {
                if (IdTipoFactura != "A")
                    this.spSoloRespuesta1.stpFactSelObtenerGenerico(IdBeneficiario, IdTipoCliente, ref IdTipoRelacion);

                if (IdTipoRelacion != 24)
                {
                    if (cbTipoRelacion.EditValue != null && Convert.ToInt32(cbTipoRelacion.EditValue) != -1)
                        IdTipoRelacion = Convert.ToInt32(cbTipoRelacion.EditValue);
                }
                else
                {
                    if (cbTipoRelacion.EditValue != null && Convert.ToInt32(cbTipoRelacion.EditValue) == 2)
                        IdTipoRelacion = 25;
                }
            }

            this.stpFactSelUsoCFDITableAdapter.Fill(this.dbSAICBPOFactura.stpFactSelUsoCFDI, IdTipoRelacion, IdTipoFactura, NoFactura, IdHeaderFactura);


            cbFormaPago.Text = String.Empty;
            cbFormaPago.EditValue = "-1";

            cbBancoOrigen.Text = String.Empty;
            cbBancoOrigen.EditValue = "-1";

            cbCuentaOrigen.Text = String.Empty;
            cbCuentaOrigen.EditValue = "-1";

            txtcargarArchivo.Text = String.Empty;
            flatClickEnFacturadora = false;

            dt.Clear();
            Totales();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridView1.GetSelectedRows().Count() > 0)
                {
                    gridView1.DeleteSelectedRows();
                    Totales();
                }
                else
                    XtraMessageBox.Show("¡Debe de Seleccionar por lo menos un Concepto!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbMoneda_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbMoneda.EditValue.ToString() != "MXP")
                {
                    txtCambio.ReadOnly = false;
                }
                else
                {
                    txtCambio.ReadOnly = true;
                    txtCambio.Text = "1";
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargarArchivo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            String stRutaContrato = String.Empty;
            ofdComprobante.Filter = "Pdf Files|*.PDF";
            ofdComprobante.ShowDialog();
            txtcargarArchivo.Text = ofdComprobante.FileName;

            stRutaContrato = ofdComprobante.FileName;
            FileInfo miArchivo = new FileInfo(stRutaContrato);
            if (miArchivo.Length > iValorLimiteArchivos)
            {
                txtcargarArchivo.Text = "";
                XtraMessageBox.Show("El Archivo no puede exceder de " + iValorLimiteArchivos + " KB", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cboIdCliente_EditValueChanged(object sender, EventArgs e)
        {
            LimpiarCampos(true);
            //string Id = "0";
            //try
            //{
            //    if (cboIdCliente.EditValue != null)
            //    {
            //        Id = cboIdCliente.EditValue.ToString();
            //        this.stpFactSelObtenerParametrosClienteTableAdapter1.Fill(dbSAICBPOFactura.stpFactSelObtenerParametrosCliente, Convert.ToInt32(Id));

            //        if (dbSAICBPOFactura.stpFactSelObtenerParametrosCliente.Count > 0)
            //        {
            //            //obtener el No. de Items seleccionados
            //            DataRow row = null;
            //            for (int i = 0; i < dbSAICBPOFactura.stpFactSelObtenerParametrosCliente.Count; i++)
            //            {
            //                row = dbSAICBPOFactura.stpFactSelObtenerParametrosCliente.Rows[i];
            //                TieneIVAGlobla = (row[6].ToString() == "" ? "16" : row[6].ToString());
            //            }

            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        /// <summary>
        /// Seleccion de fecha de pago para el Lote
        /// </summary>
        /// <returns></returns>
        private DateTime solicitarFechaDePago()
        {
            DateTime dtFechaSeleccionada;
            using (var form = new tools.xFormsSolicitarFecha("Fecha Compromiso de Pago", "Confirmar Fecha Compromiso de Pago", "Seleccione Fecha:"))
            {
                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    dtFechaSeleccionada = form.dtFechaSeleccionada;
                }
                else
                {
                    dtFechaSeleccionada = new DateTime(1900, 01, 01);
                }
            }
            return dtFechaSeleccionada;
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            bool Timbrar = false;
            try
            {
                if (Validator.IsPresent(cbProducto) && Validator.IsPresent(cbIdFronting) &&
                    Validator.IsPresent(cbTipoFacturador) &&
                    Validator.IsPresent(cbMetodoPago) &&
                    Validator.IsPresent(cbFormaPago) &&
                    Validator.IsPresent(cbMoneda) &&
                    Validator.IsPositiveNumber(txtCambio))
                {
                    if (IdTipoFactura == "N" && btnControl.Visible == false)
                    {
                        if (Validator.IsPresent(cbControl))
                            Timbrar = true;
                        else
                            Timbrar = false;
                    }
                    else
                        Timbrar = true;

                    if (Timbrar && cbMetodoPago.EditValue.ToString() == "2")
                    {
                        if (cbFormaPago.Text.Contains("Efectivo"))
                        {
                            if (Validator.IsPresent(cbBancoDestino) &&
                                Validator.IsPositiveNumber(txtDeposito))
                                Timbrar = true;
                            else
                                Timbrar = false;
                        }
                        else if (cbFormaPago.Text.Contains("Cheque"))
                        {
                            if (Validator.IsPresent(cbBancoOrigen) && Validator.IsPresent(cbBancoDestino) && Validator.IsPresent(txtcargarArchivo) && Validator.IsPositiveNumber(txtDeposito))
                                Timbrar = true;
                            else
                                Timbrar = false;
                        }
                        else if (cbFormaPago.Text.Contains("Por definir"))
                        {
                            if (Validator.IsPositiveNumber(txtDeposito))
                                Timbrar = true;
                            else
                                Timbrar = false;
                        }
                        else
                        {
                            if (Validator.IsPresent(cbBancoOrigen) && Validator.IsPresent(cbBancoDestino) && Validator.IsPresent(txtcargarArchivo) && Validator.IsPositiveNumber(txtDeposito))
                                Timbrar = true;
                            else
                                Timbrar = false;
                        }
                    }
                    else
                    {
                        Timbrar = true;
                    }

                    if (Timbrar && !cbTipoRelacion.Enabled)
                        Timbrar = true;
                    else if (Timbrar && cbTipoRelacion.Enabled)
                    {
                        if (Timbrar && IdTipoRelacion == 5)
                        {
                            if (gridView16.SelectedRowsCount > 0)
                                Timbrar = true;
                            else
                            {
                                XtraMessageBox.Show("¡Se Requiere por lo menos una Factura a Sustituir!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Timbrar = false;
                            }
                        }
                        else if (Timbrar && Validator.IsPresent(cbFacturaRelacion))
                            Timbrar = true;
                        else
                            Timbrar = false;
                    }
                    else
                        Timbrar = false;

                    if (Timbrar)
                    {
                        if (IdTipoFactura == "R")
                        {
                            if (Convert.ToDateTime(dtFechaPago.Text) >= Convert.ToDateTime(DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year))
                            {
                                if (Convert.ToDateTime(dtFechaPago.Text) == Convert.ToDateTime(DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year) && DateTime.Now > Convert.ToDateTime(DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year + " 12:00:00"))
                                    Timbrar = true;
                                else
                                    Timbrar = false;
                            }
                            else
                                Timbrar = true;

                            if (Timbrar)
                            {
                                if (gridView16.SelectedRowsCount > 0 && gridView16.SelectedRowsCount == dt.Rows.Count)
                                    CargarSolicitud();
                                else
                                    XtraMessageBox.Show("¡Se Requiere por lo menos una Factura PPD y el mismo número de Pagos!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                                XtraMessageBox.Show("¡El REP tiene Fecha Pago de hoy, se debe de solicitar despues de las 12:00pm!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Timbrar && IdTipoRelacion == 5)
                        {
                            CargarSolicitud();
                        }
                        else if (dt.Rows.Count > 0)
                        {
                            CargarSolicitud();
                        }
                        else
                            XtraMessageBox.Show("¡Se Requiere un concepto!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public String ConvertToBytes(String stRutaArchivo)
        {
            String stFile = String.Empty;

            try
            {
                Byte[] bytes = File.ReadAllBytes(stRutaArchivo);
                stFile = Convert.ToBase64String(bytes);
            }
            catch (Exception) { }

            return stFile;
        }

        private void cbTipoRelacion_EditValueChanged(object sender, EventArgs e)
        {
            Int32 IdBeneficiario = 0;
            try
            {
                if (cbTipoRelacion.EditValue != null && cbTipoRelacion.EditValue.ToString() != "-1")
                {
                    if (Validator.IsPresent(cbIdFronting) && Validator.IsPresent(cbTipoFacturador))
                    {
                        if (cbTipoFacturador.Text == "CLIENTE")
                        {
                            if (Validator.IsPresent(cboIdCliente))
                                IdBeneficiario = (Int32)cboIdCliente.EditValue;
                        }
                        else
                        {
                            if (Validator.IsPresent(cbIdTenedora))
                                IdBeneficiario = (Int32)cbIdTenedora.EditValue;
                        }
                        if (IdBeneficiario > 0)
                        {
                            if (cbTipoRelacion.EditValue != null)
                            {
                                IdTipoRelacion = Convert.ToInt32(cbTipoRelacion.EditValue);
                                if (Convert.ToInt32(cbTipoRelacion.EditValue) != 5 && Convert.ToInt32(cbTipoRelacion.EditValue) != 11)
                                {
                                    this.stpFactSelFacturasARelacionarSATTableAdapter.Fill(dbSAICBPOFactura.stpFactSelFacturasARelacionarSAT, Convert.ToInt32(cbIdFronting.EditValue.ToString()), Convert.ToInt32(cbTipoFacturador.EditValue.ToString()), IdBeneficiario, IdTipoFactura, -1, Convert.ToInt32(cbTipoRelacion.EditValue));

                                    cbFacturaRelacion.Enabled = true;
                                    cbFacturaRelacion.BackColor = Color.White;

                                    cbFacturaRelacionRecibo.Enabled = false;
                                    cbFacturaRelacionRecibo.BackColor = Color.LightGoldenrodYellow;
                                    btnActualizar.Enabled = false;
                                }
                                else
                                {
                                    cbFacturaRelacion.Enabled = false;
                                    cbFacturaRelacion.BackColor = Color.LightGoldenrodYellow;
                                    cbFacturaRelacion.EditValue = -1;

                                    cbFacturaRelacionRecibo.BackColor = Color.White;
                                    cbFacturaRelacionRecibo.Enabled = true;
                                    btnActualizar.Enabled = true;
                                }

                                if (Convert.ToInt32(cbTipoRelacion.EditValue) == 5)
                                {
                                    lblFR1.Visible = true;
                                }
                                else
                                {
                                    lblFR1.Visible = false;
                                }

                                if (IdTipoFactura != "A")
                                    this.spSoloRespuesta1.stpFactSelObtenerGenerico(IdBeneficiario, IdTipoCliente, ref IdTipoRelacion);

                                if (IdTipoRelacion != 24)
                                {
                                    if (cbTipoRelacion.EditValue != null && Convert.ToInt32(cbTipoRelacion.EditValue) != -1)
                                        IdTipoRelacion = Convert.ToInt32(cbTipoRelacion.EditValue);

                                    if (IdTipoFactura == "A" && IdTipoRelacion == 2)
                                        NoFactura = 3;
                                    else if (IdTipoFactura == "A")
                                        NoFactura = 2;
                                    else
                                        NoFactura = 0;
                                }
                                else
                                {
                                    if (cbTipoRelacion.EditValue != null && Convert.ToInt32(cbTipoRelacion.EditValue) == 2)
                                        IdTipoRelacion = 25;
                                }

                                this.stpFactSelUsoCFDITableAdapter.Fill(this.dbSAICBPOFactura.stpFactSelUsoCFDI, IdTipoRelacion, IdTipoFactura, NoFactura, IdHeaderFactura);
                            }
                        }

                        if (cbTipoRelacion.EditValue.ToString() == "2" && IdTipoFactura == "A")
                        {
                            cbMetodoPago.EditValue = 2;
                            cbMetodoPago.Enabled = false;
                            cbUsoCFDI.Enabled = true;
                            cbUsoCFDI.EditValue = 23;
                        }
                        else if (cbTipoRelacion.EditValue.ToString() == "2")
                        {
                            cbMetodoPago.EditValue = 2;
                            cbMetodoPago.Enabled = false;
                            cbUsoCFDI.Enabled = true;
                            cbUsoCFDI.EditValue = 23;
                        }
                        else if (cbTipoRelacion.EditValue.ToString() == "8")
                        {
                            cbMetodoPago.EditValue = 2;
                            cbMetodoPago.Enabled = false;
                        }
                        else if ((cbTipoRelacion.EditValue.ToString() == "10") || (cbTipoRelacion.EditValue.ToString() == "9") || (cbTipoRelacion.EditValue.ToString() == "11"))
                        {
                            cbMetodoPago.EditValue = 2;
                            cbMetodoPago.Enabled = false;
                            cbUsoCFDI.EditValue = 23;
                            cbUsoCFDI.Enabled = false;
                        }
                        else if (cbTipoRelacion.EditValue.ToString() == "5" && txtTipoFactura.Text == "REP")
                        {
                            cbMetodoPago.EditValue = 2;
                            cbMetodoPago.Enabled = false;
                            cbUsoCFDI.Enabled = false;
                            cbUsoCFDI.EditValue = 23;
                        }
                        else
                        {
                            cbMetodoPago.Enabled = true;
                            cbUsoCFDI.Enabled = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                splashSMCargando.CloseWaitForm();
            }
        }

        private void cbBancoOrigen_EditValueChanged(object sender, EventArgs e)
        {
            Int32 IdBeneficiario = 0;
            int iRelcion = -1;

            if (!flatClickEnFacturadora)
            {
                if (cbFormaPago.Text.ToUpper() != "EFECTIVO")
                {
                    if (Validator.IsPresent(cbTipoFacturador) && Validator.IsPresent(cbUsoCFDI)
                          && Validator.IsPresent(cbBancoOrigen))
                    {
                        if (cbTipoFacturador.Text == "CLIENTE")
                        {
                            if (Validator.IsPresent(cboIdCliente))
                            {
                                IdBeneficiario = (Int32)cboIdCliente.EditValue;
                            }
                        }
                        else
                        {
                            if (Validator.IsPresent(cbIdTenedora))
                            {
                                IdBeneficiario = (Int32)cbIdTenedora.EditValue;
                            }
                        }

                        //Obtener Cuentas
                        if (cbTipoRelacion.EditValue != null)
                            iRelcion = Convert.ToInt32(cbTipoRelacion.EditValue);

                        if (iRelcion == 2)
                            this.stpFactSelBeneficiarioBancoTableAdapter.Fill(this.dbSAICBPOFactura.stpFactSelBeneficiarioBanco, Convert.ToInt32(cbIdFronting.EditValue.ToString()), 3, Convert.ToInt32(cbBancoOrigen.EditValue));
                        else
                            this.stpFactSelBeneficiarioBancoTableAdapter.Fill(this.dbSAICBPOFactura.stpFactSelBeneficiarioBanco, IdBeneficiario, Convert.ToInt32(cbTipoFacturador.EditValue), Convert.ToInt32(cbBancoOrigen.EditValue));
                    }
                }
            }
        }

        private void cbFacturaRelacion_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Int32 IdEstatus = 0;
                if (cbFacturaRelacion.EditValue != null && cbFacturaRelacion.EditValue.ToString() != "-1")
                    if (Validator.IsPresent(cbFacturaRelacion))
                    {
                        DataRow row = gridView9.GetDataRow(gridView9.FocusedRowHandle);
                        //obtener el renglon completo del Combobox
                        if (row != null)
                        {
                            //asignar valores extraidos del Combobox
                            IdHeaderFactura = Convert.ToInt64(row[0].ToString());
                            cbFormaPago.EditValue = Convert.ToDecimal(row[12].ToString()).ToString();
                            if (Convert.ToDecimal(row[12].ToString()).ToString() == "21")
                                cbFormaPago.EditValue = 2;
                            cbMoneda.EditValue = row[14];
                            txtCambio.Text = Convert.ToDecimal(row[15].ToString()).ToString();
                            txtDeposito.Text = Convert.ToDecimal(row[24].ToString()).ToString();
                            RestoPago = Convert.ToDouble(row[19].ToString());
                            TotalFactura = Convert.ToDouble(row[19].ToString());
                            IdEstatus = Convert.ToInt32(row[30].ToString());
                            if (IdTipoFactura == "A")
                                this.stpFactSelUsoCFDITableAdapter.Fill(this.dbSAICBPOFactura.stpFactSelUsoCFDI, IdTipoRelacion, IdTipoFactura, NoFactura, IdHeaderFactura);

                        }
                        else
                            XtraMessageBox.Show("¡Debe de Seleccionar un Control!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbFormaPago_EditValueChanged(object sender, EventArgs e)
        {
            ActivarControlesPago(true, cbFormaPago.Text);
        }

        private void cbIdTenedora_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                LimpiarCampos(true);
            }
            catch (Exception ex) { }
        }

        private void btnLimpia_Click(object sender, EventArgs e)
        {

            try
            {
                cbControl.Enabled = false;
                cbControl.BackColor = Color.LightGoldenrodYellow;

                btnLimpia.Visible = false;
                btnxAnticipo.Visible = true;
                btnREP.Visible = true;
                btnPublicoGeneral.Visible = true;

                ActivarBotonesC(true);

                cbMetodoPago.Enabled = true;

                cbFacturaRelacion.Enabled = false;
                cbFacturaRelacion.BackColor = Color.LightGoldenrodYellow;

                cbTipoRelacion.Enabled = false;
                cbTipoRelacion.BackColor = Color.LightGoldenrodYellow;

                if (cbFacturaRelacion.EditValue != null && Convert.ToInt32(cbFacturaRelacion.EditValue) != -1)
                    cbFacturaRelacion.EditValue = -1;
                if (cbTipoRelacion.EditValue != null && Convert.ToInt32(cbTipoRelacion.EditValue) != -1)
                    cbTipoRelacion.EditValue = -1;

                if (cbControl.EditValue != null && Convert.ToInt32(cbControl.EditValue) != -1)
                    cbControl.EditValue = -1;

                Controlsubtotal = 0;
                ControlIVA = 0;
                ControlRetencion = 0;
                ControlTotal = 0;
                Limpiar(true);

                txtTipoFactura.Text = "NORMAL";
                IdTipoFactura = "N";
                IdTipoRelacion = 0;
                IdHeaderFactura = 0;
                NoFactura = 0;
                // TODO: This line of code loads data into the 'dbSAICBPOFactura.vwFactCatUsoCFDI' table. You can move, or remove it, as needed.

                this.stpFactSelUsoCFDITableAdapter.Fill(this.dbSAICBPOFactura.stpFactSelUsoCFDI, IdTipoRelacion, IdTipoFactura, NoFactura, IdHeaderFactura);
                this.stpFactSelCatTipoRelacionv2TableAdapter.Fill(this.dbSAICBPOFactura.stpFactSelCatTipoRelacionv2, IdTipoFactura, 27);
                flagSinControl = true;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnxAnticipo_Click(object sender, EventArgs e)
        {
            try
            {
                cbControl.Enabled = false;
                cbControl.BackColor = Color.LightGoldenrodYellow;

                btnLimpia.Visible = false;
                btnxAnticipo.Visible = true;
                btnREP.Visible = true;
                btnPublicoGeneral.Visible = true;

                ActivarBotonesC(true);

                cbFacturaRelacion.Enabled = false;
                cbFacturaRelacion.BackColor = Color.LightGoldenrodYellow;

                cbTipoRelacion.Enabled = false;
                cbTipoRelacion.BackColor = Color.LightGoldenrodYellow;

                if (cbFacturaRelacion.EditValue != null && Convert.ToInt32(cbFacturaRelacion.EditValue) != -1)
                    cbFacturaRelacion.EditValue = -1;
                if (cbTipoRelacion.EditValue != null && Convert.ToInt32(cbTipoRelacion.EditValue) != -1)
                    cbTipoRelacion.EditValue = -1;

                if (cbControl.EditValue != null && Convert.ToInt32(cbControl.EditValue) != -1)
                    cbControl.EditValue = -1;

                Controlsubtotal = 0;
                ControlIVA = 0;
                ControlRetencion = 0;
                ControlTotal = 0;

                Limpiar(true);

                txtTipoFactura.Text = "ANTICIPO";
                cbFacturaRelacionRecibo.Enabled = false;
                btnControl.Visible = false;
                btnLimpia.Visible = true;
                btnxAnticipo.Visible = false;
                btnREP.Visible = true;
                btnPublicoGeneral.Visible = true;
                IdTipoFactura = "A";
                IdTipoRelacion = 8;
                NoFactura = 1;
                IdHeaderFactura = 0;

                cbMetodoPago.EditValue = 2;
                cbMetodoPago.Enabled = false;
                // TODO: This line of code loads data into the 'dbSAICBPOFactura.vwFactCatUsoCFDI' table. You can move, or remove it, as needed.
                this.stpFactSelUsoCFDITableAdapter.Fill(this.dbSAICBPOFactura.stpFactSelUsoCFDI, IdTipoRelacion, IdTipoFactura, NoFactura, IdHeaderFactura);
                this.stpFactSelCatTipoRelacionv2TableAdapter.Fill(this.dbSAICBPOFactura.stpFactSelCatTipoRelacionv2, IdTipoFactura, 27);
                this.dbSAICBPOFactura.stpFactSelCatTipoRelacion.Clear();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbFacturaRelacionRecibo_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnPublicoGeneral_Click(object sender, EventArgs e)
        {
            try
            {
                cbControl.Enabled = false;
                cbControl.BackColor = Color.LightGoldenrodYellow;
                
                btnControl.Visible = false;
                btRelacionar.Visible = true;


                if (cbFacturaRelacionRecibo.EditValue != null && Convert.ToInt32(cbFacturaRelacionRecibo.EditValue) != -1)
                    cbFacturaRelacionRecibo.EditValue = -1;
                if (cbTipoRelacion.EditValue != null && Convert.ToInt32(cbTipoRelacion.EditValue) != -1)
                    cbTipoRelacion.EditValue = -1;

                if (cbControl.EditValue != null && Convert.ToInt32(cbControl.EditValue) != -1)
                    cbControl.EditValue = -1;

                Controlsubtotal = 0;
                ControlIVA = 0;
                ControlRetencion = 0;
                ControlTotal = 0;

                Limpiar(true);

                txtTipoFactura.Text = "Publico en General";
                cbProducto.EditValue = 3;
                cbProducto.ReadOnly = true;
                cbTipoFacturador.EditValue = 2;
                cbTipoFacturador.ReadOnly = true;

                btnLimpia.Visible = true;
                btnxAnticipo.Visible = true;
                btnREP.Visible = true;
                btnPublicoGeneral.Visible = false;


                cbMetodoPago.EditValue = 2;
                cbMetodoPago.Enabled = false;
                cbPeriodicidad.Enabled = true;
                cbPeriodicidad.EditValue = -1;
                IdTipoFactura = "G";
                IdTipoRelacion = 0;
                NoFactura = 0;
                IdHeaderFactura = 0;

                this.stpFactSelUsoCFDITableAdapter.Fill(this.dbSAICBPOFactura.stpFactSelUsoCFDI, IdTipoRelacion, IdTipoFactura, NoFactura, IdHeaderFactura);
                
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnREP_Click(object sender, EventArgs e)
        {
            try
            {
                cbControl.Enabled = false;
                cbControl.BackColor = Color.LightGoldenrodYellow;

                btnLimpia.Visible = false;
                btnxAnticipo.Visible = true;
                btnREP.Visible = true;
                btnPublicoGeneral.Visible = true;

                btnControl.Visible = false;
                btRelacionar.Visible = true;


                if (cbFacturaRelacionRecibo.EditValue != null && Convert.ToInt32(cbFacturaRelacionRecibo.EditValue) != -1)
                    cbFacturaRelacionRecibo.EditValue = -1;
                if (cbTipoRelacion.EditValue != null && Convert.ToInt32(cbTipoRelacion.EditValue) != -1)
                    cbTipoRelacion.EditValue = -1;

                if (cbControl.EditValue != null && Convert.ToInt32(cbControl.EditValue) != -1)
                    cbControl.EditValue = -1;

                Controlsubtotal = 0;
                ControlIVA = 0;
                ControlRetencion = 0;
                ControlTotal = 0;

                Limpiar(true);

                txtTipoFactura.Text = "REP";

                btnLimpia.Visible = true;
                btnxAnticipo.Visible = true;
                btnREP.Visible = false;
                btnPublicoGeneral.Visible = true;

                cbMetodoPago.EditValue = 2;
                cbMetodoPago.Enabled = false;
                IdTipoFactura = "R";
                IdTipoRelacion = 11;
                NoFactura = 0;
                IdHeaderFactura = 0;
                // TODO: This line of code loads data into the 'dbSAICBPOFactura.vwFactCatUsoCFDI' table. You can move, or remove it, as needed.
                this.stpFactSelCatTipoRelacionv2TableAdapter.Fill(this.dbSAICBPOFactura.stpFactSelCatTipoRelacionv2, IdTipoFactura, 0);
                this.stpFactSelUsoCFDITableAdapter.Fill(this.dbSAICBPOFactura.stpFactSelUsoCFDI, IdTipoRelacion, IdTipoFactura, NoFactura, IdHeaderFactura);
                cbFacturaRelacionRecibo.BackColor = Color.White;
                cbFacturaRelacionRecibo.Enabled = true;
                btnActualizar.Enabled = true;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDescuentoISN_EditValueChanged(object sender, EventArgs e)
        {
            Totales();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Int32 IdBeneficiario = 0;
            try
            {
                if (Validator.IsPresent(cbIdFronting) && Validator.IsPresent(cbTipoFacturador))
                {
                    if (cbTipoFacturador.Text == "CLIENTE")
                    {
                        if (Validator.IsPresent(cboIdCliente))
                            IdBeneficiario = (Int32)cboIdCliente.EditValue;
                    }
                    else
                    {
                        if (Validator.IsPresent(cbIdTenedora))
                            IdBeneficiario = (Int32)cbIdTenedora.EditValue;
                    }

                    if (IdBeneficiario > 0)
                    {
                        this.dbSAICBPOFactura.stpFactSelFacturasARelacionarSAT1.Clear();
                        this.stpFactSelFacturasARelacionarSAT1TableAdapter.Fill(dbSAICBPOFactura.stpFactSelFacturasARelacionarSAT1, Convert.ToInt32(cbIdFronting.EditValue.ToString()), Convert.ToInt32(cbTipoFacturador.EditValue.ToString()), IdBeneficiario, IdTipoFactura, -1, IdTipoRelacion);
                        if (cbFacturaRelacionRecibo.EditValue != null && cbFacturaRelacionRecibo.EditValue.ToString() != "-1")
                            cbFacturaRelacionRecibo.EditValue = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (splashSMCargando.IsSplashFormVisible)
                {
                    splashSMCargando.CloseWaitForm();
                }
            }
        }
    }
}
