namespace winAppSAIC.Facturas
{
    partial class frmSolicitudFactura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSolicitudFactura));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.CBTipoFactura = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnLimpia = new System.Windows.Forms.ToolStripMenuItem();
            this.btnxAnticipo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnREP = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPublicoGeneral = new System.Windows.Forms.ToolStripMenuItem();
            this.btnControl = new System.Windows.Forms.ToolStripButton();
            this.btRelacionar = new System.Windows.Forms.ToolStripButton();
            this.btnFacturar = new System.Windows.Forms.ToolStripButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConcepto = new DevExpress.XtraEditors.SimpleButton();
            this.dtFechaPago = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.grControlRelacionado = new DevExpress.XtraEditors.GroupControl();
            this.gvConceptos = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdConcepto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colConceptoPresentar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colConcepto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImporte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIVA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPorIVA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescuento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalIVA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRetencionIVA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecioUnitarioCB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImporteCB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalIVACB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImporteTotalCB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblLoteCargaNomina = new System.Windows.Forms.Label();
            this.lblTenedora = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcargarArchivo = new DevExpress.XtraEditors.ButtonEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.txtTotal = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtIVA = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtSubtotal = new DevExpress.XtraEditors.TextEdit();
            this.dbSAICBPOFactura = new winAppSAIC.Facturas.dbSAICBPOFactura();
            this.vwcatFrontingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwcatFrontingTableAdapter = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.vwcatFrontingTableAdapter();
            this.cbIdFronting = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdMatrizTenedora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreComercial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRazonSocial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbTipoFacturador = new DevExpress.XtraEditors.GridLookUpEdit();
            this.stpFactSelTipoBeneficiarioOperadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdFactTipoBeneficiario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescTipoBeneficiario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbFormaPago = new DevExpress.XtraEditors.GridLookUpEdit();
            this.stpFactSelObtenerFormaPagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdFactFormaPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClaveFormaPagoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColDescFormaPagoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vwFactCatFormaPagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbIdTenedora = new DevExpress.XtraEditors.GridLookUpEdit();
            this.stpFactSelBeneficiarioTenedoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdTenedora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreComercialF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRazonSocialT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbMetodoPago = new DevExpress.XtraEditors.GridLookUpEdit();
            this.vwFactCatMetodoPagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdFactMetodoPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClaveFormaPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescFormaPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbMoneda = new DevExpress.XtraEditors.GridLookUpEdit();
            this.vwCatMonedaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdMoneda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescMoneda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescMonedaLarga = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbTipoRelacion = new DevExpress.XtraEditors.GridLookUpEdit();
            this.stpFactSelCatTipoRelacionv2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView7 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coIdFactTipoRelacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClaveTipoRelacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescTipoRelacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbControl = new DevExpress.XtraEditors.GridLookUpEdit();
            this.stpFactSelControlOperacionesV2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView8 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdControlOperaciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescTipoPeriodoNomina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRazonSocialCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaInicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaFin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubtotalc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIVAC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbFacturaRelacion = new DevExpress.XtraEditors.GridLookUpEdit();
            this.stpFactSelFacturasARelacionarSATBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView9 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdHeaderFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColSerie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColFolioInterno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColDescMetodoPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColDescFormadPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColTotalF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaGeneracionCFDI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColUUID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboIdCliente = new DevExpress.XtraEditors.GridLookUpEdit();
            this.stpFactSelBeneficiarioClienteNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView10 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdMatrizCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreComercialC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRazonSocialC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vwFactCatFormaPagoTableAdapter = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.vwFactCatFormaPagoTableAdapter();
            this.stpFactSelObtenerFormaPagoTableAdapter = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelObtenerFormaPagoTableAdapter();
            this.vwFactCatMetodoPagoTableAdapter = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.vwFactCatMetodoPagoTableAdapter();
            this.btnEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.stpFactSelBeneficiarioTenedoraTableAdapter = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelBeneficiarioTenedoraTableAdapter();
            this.ofdComprobante = new System.Windows.Forms.OpenFileDialog();
            this.stpFactSelDerechosAccesoFacturacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stpFactSelDerechosAccesoFacturacionTableAdapter = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelDerechosAccesoFacturacionTableAdapter();
            this.stpFactSelTipoBeneficiarioOperadorTableAdapter = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelTipoBeneficiarioOperadorTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBancoOrigen = new DevExpress.XtraEditors.GridLookUpEdit();
            this.stpFactSelFrontingClienteBancoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView11 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dbSAICBPOCatalogosDataSet = new winAppSAIC.dbSAICBPOCatalogosDataSet();
            this.label8 = new System.Windows.Forms.Label();
            this.cbBancoDestino = new DevExpress.XtraEditors.GridLookUpEdit();
            this.stpFactSelFrontingClienteBanco1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView12 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdBancoD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreBancoD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdMatrizTenedora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.spSoloRespuesta1 = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.spSoloRespuesta();
            this.txtDeposito = new DevExpress.XtraEditors.SpinEdit();
            this.txtCambio = new DevExpress.XtraEditors.SpinEdit();
            this.stpFactSelFacturasARelacionarSATTableAdapter = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelFacturasARelacionarSATTableAdapter();
            this.stpFactSelHeaderFacturasModificarTableAdapter1 = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelHeaderFacturasModificarTableAdapter();
            this.stpFactSelDetailFacturasTableAdapter1 = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelDetailFacturasTableAdapter();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.label14 = new System.Windows.Forms.Label();
            this.cbUsoCFDI = new DevExpress.XtraEditors.GridLookUpEdit();
            this.stpFactSelUsoCFDIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView13 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsoCFDI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClave = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vwCatMonedaTableAdapter = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.vwCatMonedaTableAdapter();
            this.stpFactSelUsoCFDITableAdapter = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelUsoCFDITableAdapter();
            this.stpFactSelReporteFacturaPDFTableAdapter = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelReporteFacturaPDFTableAdapter();
            this.label15 = new System.Windows.Forms.Label();
            this.cbCuentaOrigen = new DevExpress.XtraEditors.GridLookUpEdit();
            this.stpFactSelBeneficiarioBancoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView14 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label16 = new System.Windows.Forms.Label();
            this.cbProducto = new DevExpress.XtraEditors.GridLookUpEdit();
            this.stpFactSelProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView15 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn43 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn44 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.stpFactSelProductoTableAdapter = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelProductoTableAdapter();
            this.stpFactSelControlOperacionesV2TableAdapter = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelControlOperacionesV2TableAdapter();
            this.stpFactSelCatTipoRelacionv2TableAdapter = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelCatTipoRelacionv2TableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbFacturaRelacionRecibo = new DevExpress.XtraEditors.GridLookUpEdit();
            this.stpFactSelFacturasARelacionarSAT1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView16 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtTipoFactura = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTotalISN = new DevExpress.XtraEditors.TextEdit();
            this.label17 = new System.Windows.Forms.Label();
            this.btnActualizar = new DevExpress.XtraEditors.SimpleButton();
            this.stpFactSelFacturasARelacionarSAT1TableAdapter = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelFacturasARelacionarSAT1TableAdapter();
            this.splashSMCargando = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::winAppSAIC.frmxCargandoInformacion), true, true);
            this.txtIVAPor = new DevExpress.XtraEditors.SpinEdit();
            this.stpFactSelObtenerParametrosFrontingTableAdapter1 = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelObtenerParametrosFrontingTableAdapter();
            this.stpFactSelFrontingClienteBancoTableAdapter = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelFrontingClienteBancoTableAdapter();
            this.stpFactSelFrontingClienteBanco1TableAdapter = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelFrontingClienteBanco1TableAdapter();
            this.stpFactSelBeneficiarioBancoTableAdapter = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelBeneficiarioBancoTableAdapter();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtRetencionIVA = new DevExpress.XtraEditors.TextEdit();
            this.dbSAICBPOValidacionDataSet1 = new winAppSAIC.dbSAICBPOValidacionDataSet();
            this.stpSelParametroTableAdapter1 = new winAppSAIC.dbSAICBPOValidacionDataSetTableAdapters.stpSelParametroTableAdapter();
            this.lblFR1 = new System.Windows.Forms.Label();
            this.txtTotalR = new DevExpress.XtraEditors.TextEdit();
            this.txtIVAR = new DevExpress.XtraEditors.TextEdit();
            this.txtSubtotalR = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtTotalP = new DevExpress.XtraEditors.TextEdit();
            this.stpFactSelBeneficiarioClienteNTableAdapter = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelBeneficiarioClienteNTableAdapter();
            this.label18 = new System.Windows.Forms.Label();
            this.cbPeriodicidad = new DevExpress.XtraEditors.GridLookUpEdit();
            this.stpFactPeriodicidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView17 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.stpFactPeriodicidadTableAdapter = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactPeriodicidadTableAdapter();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grControlRelacionado)).BeginInit();
            this.grControlRelacionado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvConceptos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcargarArchivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIVA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubtotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwcatFrontingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbIdFronting.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoFacturador.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelTipoBeneficiarioOperadorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFormaPago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelObtenerFormaPagoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwFactCatFormaPagoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbIdTenedora.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelBeneficiarioTenedoraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMetodoPago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwFactCatMetodoPagoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMoneda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCatMonedaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoRelacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelCatTipoRelacionv2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbControl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelControlOperacionesV2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFacturaRelacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelFacturasARelacionarSATBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboIdCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelBeneficiarioClienteNBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelDerechosAccesoFacturacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbBancoOrigen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelFrontingClienteBancoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbBancoDestino.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelFrontingClienteBanco1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDeposito.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCambio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUsoCFDI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelUsoCFDIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCuentaOrigen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelBeneficiarioBancoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbProducto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelProductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView15)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbFacturaRelacionRecibo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelFacturasARelacionarSAT1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalISN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIVAPor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRetencionIVA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOValidacionDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIVAR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubtotalR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPeriodicidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactPeriodicidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView17)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSalir,
            this.CBTipoFactura,
            this.btnControl,
            this.btRelacionar,
            this.btnFacturar});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(830, 27);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(53, 24);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // CBTipoFactura
            // 
            this.CBTipoFactura.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLimpia,
            this.btnxAnticipo,
            this.btnREP,
            this.btnPublicoGeneral});
            this.CBTipoFactura.Image = global::winAppSAIC.Properties.Resources.XML_01_icon;
            this.CBTipoFactura.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CBTipoFactura.Name = "CBTipoFactura";
            this.CBTipoFactura.Size = new System.Drawing.Size(105, 24);
            this.CBTipoFactura.Text = "Tipo Factura";
            // 
            // btnLimpia
            // 
            this.btnLimpia.Image = global::winAppSAIC.Properties.Resources._1486485586_add_document_contract_agreement_notic_file_plus_81158___copia;
            this.btnLimpia.Name = "btnLimpia";
            this.btnLimpia.Size = new System.Drawing.Size(182, 22);
            this.btnLimpia.Text = "Factura";
            this.btnLimpia.Click += new System.EventHandler(this.btnLimpia_Click);
            // 
            // btnxAnticipo
            // 
            this.btnxAnticipo.Image = global::winAppSAIC.Properties.Resources.money_add_icon32x32;
            this.btnxAnticipo.Name = "btnxAnticipo";
            this.btnxAnticipo.Size = new System.Drawing.Size(182, 22);
            this.btnxAnticipo.Text = "Factura por Anticipo";
            this.btnxAnticipo.Click += new System.EventHandler(this.btnxAnticipo_Click);
            // 
            // btnREP
            // 
            this.btnREP.Image = global::winAppSAIC.Properties.Resources.backup_restore_icon48x48;
            this.btnREP.Name = "btnREP";
            this.btnREP.Size = new System.Drawing.Size(182, 22);
            this.btnREP.Text = "REP";
            this.btnREP.Click += new System.EventHandler(this.btnREP_Click);
            // 
            // btnPublicoGeneral
            // 
            this.btnPublicoGeneral.Image = global::winAppSAIC.Properties.Resources.uuid;
            this.btnPublicoGeneral.Name = "btnPublicoGeneral";
            this.btnPublicoGeneral.Size = new System.Drawing.Size(182, 22);
            this.btnPublicoGeneral.Text = "Publico en General";
            this.btnPublicoGeneral.Click += new System.EventHandler(this.btnPublicoGeneral_Click);
            // 
            // btnControl
            // 
            this.btnControl.Image = ((System.Drawing.Image)(resources.GetObject("btnControl.Image")));
            this.btnControl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnControl.Name = "btnControl";
            this.btnControl.Size = new System.Drawing.Size(147, 24);
            this.btnControl.Text = "Factura desde Control";
            this.btnControl.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // btRelacionar
            // 
            this.btRelacionar.Image = global::winAppSAIC.Properties.Resources.Transfer_Document_icon16x16;
            this.btRelacionar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btRelacionar.Name = "btRelacionar";
            this.btRelacionar.Size = new System.Drawing.Size(128, 24);
            this.btRelacionar.Text = "Relacionar Factura";
            this.btRelacionar.Visible = false;
            this.btRelacionar.Click += new System.EventHandler(this.btRelacionar_Click);
            // 
            // btnFacturar
            // 
            this.btnFacturar.Image = ((System.Drawing.Image)(resources.GetObject("btnFacturar.Image")));
            this.btnFacturar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(115, 24);
            this.btnFacturar.Text = "Solicitar Factura";
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(481, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 82;
            this.label6.Text = "Moneda:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 80;
            this.label5.Text = "Método Pago:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 78;
            this.label3.Text = "Forma Pago:";
            // 
            // btnConcepto
            // 
            this.btnConcepto.Appearance.BackColor = System.Drawing.Color.White;
            this.btnConcepto.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConcepto.Appearance.Options.UseBackColor = true;
            this.btnConcepto.Appearance.Options.UseFont = true;
            this.btnConcepto.Appearance.Options.UseTextOptions = true;
            this.btnConcepto.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnConcepto.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnConcepto.ImageOptions.Image")));
            this.btnConcepto.Location = new System.Drawing.Point(188, 5);
            this.btnConcepto.LookAndFeel.SkinName = "VS2010";
            this.btnConcepto.Name = "btnConcepto";
            this.btnConcepto.Size = new System.Drawing.Size(124, 28);
            this.btnConcepto.TabIndex = 21;
            this.btnConcepto.Text = "Agregar Concepto";
            this.btnConcepto.Click += new System.EventHandler(this.btnConcepto_Click);
            // 
            // dtFechaPago
            // 
            this.dtFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaPago.Location = new System.Drawing.Point(536, 150);
            this.dtFechaPago.Name = "dtFechaPago";
            this.dtFechaPago.Size = new System.Drawing.Size(114, 21);
            this.dtFechaPago.TabIndex = 11;
            this.dtFechaPago.Tag = "Fecha de Pago";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(463, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 76;
            this.label4.Text = "Fecha Pago:";
            // 
            // grControlRelacionado
            // 
            this.grControlRelacionado.Controls.Add(this.gvConceptos);
            this.grControlRelacionado.Location = new System.Drawing.Point(21, 285);
            this.grControlRelacionado.Name = "grControlRelacionado";
            this.grControlRelacionado.Size = new System.Drawing.Size(798, 168);
            this.grControlRelacionado.TabIndex = 22;
            this.grControlRelacionado.TabStop = true;
            this.grControlRelacionado.Text = "Concepto(s)";
            // 
            // gvConceptos
            // 
            this.gvConceptos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvConceptos.Location = new System.Drawing.Point(2, 20);
            this.gvConceptos.MainView = this.gridView1;
            this.gvConceptos.Name = "gvConceptos";
            this.gvConceptos.Size = new System.Drawing.Size(794, 146);
            this.gvConceptos.TabIndex = 23;
            this.gvConceptos.Tag = "Conceptos";
            this.gvConceptos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCantidad,
            this.colIdConcepto,
            this.colConceptoPresentar,
            this.colConcepto,
            this.colPrecio,
            this.colImporte,
            this.colIVA,
            this.colPorIVA,
            this.colDescuento,
            this.colTotalIVA,
            this.gridColumn12,
            this.colRetencionIVA,
            this.colPrecioUnitarioCB,
            this.colImporteCB,
            this.colTotalIVACB,
            this.colImporteTotalCB});
            this.gridView1.GridControl = this.gvConceptos;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, null, this.colImporte, "C2"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, null, this.colTotalIVA, "C2")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colCantidad
            // 
            this.colCantidad.Caption = "CANT.";
            this.colCantidad.FieldName = "colCantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.Visible = true;
            this.colCantidad.VisibleIndex = 1;
            this.colCantidad.Width = 43;
            // 
            // colIdConcepto
            // 
            this.colIdConcepto.Caption = "IdConcepto";
            this.colIdConcepto.FieldName = "colIdConcepto";
            this.colIdConcepto.Name = "colIdConcepto";
            // 
            // colConceptoPresentar
            // 
            this.colConceptoPresentar.Caption = "CONCEPTO";
            this.colConceptoPresentar.FieldName = "colConceptoPresentar";
            this.colConceptoPresentar.Name = "colConceptoPresentar";
            this.colConceptoPresentar.Visible = true;
            this.colConceptoPresentar.VisibleIndex = 2;
            this.colConceptoPresentar.Width = 202;
            // 
            // colConcepto
            // 
            this.colConcepto.Caption = "Complemento";
            this.colConcepto.FieldName = "colConcepto";
            this.colConcepto.Name = "colConcepto";
            this.colConcepto.Width = 292;
            // 
            // colPrecio
            // 
            this.colPrecio.Caption = "PRECIO UNITARIO";
            this.colPrecio.DisplayFormat.FormatString = "C2";
            this.colPrecio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrecio.FieldName = "colPrecioUnitario";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.Visible = true;
            this.colPrecio.VisibleIndex = 9;
            this.colPrecio.Width = 101;
            // 
            // colImporte
            // 
            this.colImporte.Caption = "IMPORTE";
            this.colImporte.DisplayFormat.FormatString = "C2";
            this.colImporte.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colImporte.FieldName = "colImporte";
            this.colImporte.Name = "colImporte";
            this.colImporte.Visible = true;
            this.colImporte.VisibleIndex = 10;
            this.colImporte.Width = 91;
            // 
            // colIVA
            // 
            this.colIVA.Caption = "IVA";
            this.colIVA.FieldName = "colIVA";
            this.colIVA.Name = "colIVA";
            // 
            // colPorIVA
            // 
            this.colPorIVA.Caption = "colPorIVA";
            this.colPorIVA.FieldName = "colPorIVA";
            this.colPorIVA.Name = "colPorIVA";
            // 
            // colDescuento
            // 
            this.colDescuento.Caption = "RETENCION ISN";
            this.colDescuento.DisplayFormat.FormatString = "C2";
            this.colDescuento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDescuento.FieldName = "colTotalDescuento";
            this.colDescuento.Name = "colDescuento";
            this.colDescuento.Visible = true;
            this.colDescuento.VisibleIndex = 8;
            this.colDescuento.Width = 89;
            // 
            // colTotalIVA
            // 
            this.colTotalIVA.Caption = "IVA";
            this.colTotalIVA.DisplayFormat.FormatString = "C2";
            this.colTotalIVA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalIVA.FieldName = "colTotalIVA";
            this.colTotalIVA.Name = "colTotalIVA";
            this.colTotalIVA.Visible = true;
            this.colTotalIVA.VisibleIndex = 11;
            this.colTotalIVA.Width = 67;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "IMPORTE TOTAL";
            this.gridColumn12.DisplayFormat.FormatString = "C2";
            this.gridColumn12.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn12.FieldName = "colImporteTotal";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 12;
            this.gridColumn12.Width = 96;
            // 
            // colRetencionIVA
            // 
            this.colRetencionIVA.Caption = "RETENCION IVA";
            this.colRetencionIVA.DisplayFormat.FormatString = "C2";
            this.colRetencionIVA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colRetencionIVA.FieldName = "colRetencion";
            this.colRetencionIVA.Name = "colRetencionIVA";
            this.colRetencionIVA.Visible = true;
            this.colRetencionIVA.VisibleIndex = 6;
            this.colRetencionIVA.Width = 127;
            // 
            // colPrecioUnitarioCB
            // 
            this.colPrecioUnitarioCB.Caption = "PRECIO UNITARIO";
            this.colPrecioUnitarioCB.DisplayFormat.FormatString = "C2";
            this.colPrecioUnitarioCB.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrecioUnitarioCB.FieldName = "colPrecioUnitarioCB";
            this.colPrecioUnitarioCB.Name = "colPrecioUnitarioCB";
            this.colPrecioUnitarioCB.Visible = true;
            this.colPrecioUnitarioCB.VisibleIndex = 3;
            this.colPrecioUnitarioCB.Width = 101;
            // 
            // colImporteCB
            // 
            this.colImporteCB.Caption = "IMPORTE";
            this.colImporteCB.DisplayFormat.FormatString = "C2";
            this.colImporteCB.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colImporteCB.FieldName = "colImporteCB";
            this.colImporteCB.Name = "colImporteCB";
            this.colImporteCB.Visible = true;
            this.colImporteCB.VisibleIndex = 4;
            // 
            // colTotalIVACB
            // 
            this.colTotalIVACB.Caption = "IVA";
            this.colTotalIVACB.DisplayFormat.FormatString = "C2";
            this.colTotalIVACB.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalIVACB.FieldName = "colTotalIVACB";
            this.colTotalIVACB.Name = "colTotalIVACB";
            this.colTotalIVACB.Visible = true;
            this.colTotalIVACB.VisibleIndex = 5;
            // 
            // colImporteTotalCB
            // 
            this.colImporteTotalCB.Caption = "IMPORTE TOTAL";
            this.colImporteTotalCB.DisplayFormat.FormatString = "C2";
            this.colImporteTotalCB.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colImporteTotalCB.FieldName = "colImporteTotalCB";
            this.colImporteTotalCB.Name = "colImporteTotalCB";
            this.colImporteTotalCB.Visible = true;
            this.colImporteTotalCB.VisibleIndex = 7;
            this.colImporteTotalCB.Width = 90;
            // 
            // lblLoteCargaNomina
            // 
            this.lblLoteCargaNomina.AutoSize = true;
            this.lblLoteCargaNomina.Location = new System.Drawing.Point(57, 36);
            this.lblLoteCargaNomina.Name = "lblLoteCargaNomina";
            this.lblLoteCargaNomina.Size = new System.Drawing.Size(66, 13);
            this.lblLoteCargaNomina.TabIndex = 66;
            this.lblLoteCargaNomina.Text = "No. Control:";
            // 
            // lblTenedora
            // 
            this.lblTenedora.AutoSize = true;
            this.lblTenedora.Location = new System.Drawing.Point(53, 60);
            this.lblTenedora.Name = "lblTenedora";
            this.lblTenedora.Size = new System.Drawing.Size(70, 13);
            this.lblTenedora.TabIndex = 66;
            this.lblTenedora.Text = "Facturadora:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(49, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 94;
            this.label10.Text = "Tipo Relación:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(333, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 13);
            this.label11.TabIndex = 96;
            this.label11.Text = "Factura de Relación:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(34, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 13);
            this.label12.TabIndex = 98;
            this.label12.Text = "Tipo Beneficiario:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(261, 84);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 13);
            this.label13.TabIndex = 100;
            this.label13.Text = "Beneficiario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 103;
            this.label1.Text = "Archivo:";
            // 
            // txtcargarArchivo
            // 
            this.txtcargarArchivo.Location = new System.Drawing.Point(130, 220);
            this.txtcargarArchivo.Name = "txtcargarArchivo";
            this.txtcargarArchivo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtcargarArchivo.Size = new System.Drawing.Size(315, 20);
            this.txtcargarArchivo.TabIndex = 19;
            this.txtcargarArchivo.Tag = "Archivo";
            this.txtcargarArchivo.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cargarArchivo_ButtonClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(656, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 107;
            this.label7.Text = "Tipo Cambio:";
            // 
            // labelControl19
            // 
            this.labelControl19.Location = new System.Drawing.Point(688, 541);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(28, 13);
            this.labelControl19.TabIndex = 117;
            this.labelControl19.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(719, 538);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtTotal.Properties.Appearance.Options.UseBackColor = true;
            this.txtTotal.Properties.EditFormat.FormatString = "C2";
            this.txtTotal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTotal.Properties.ReadOnly = true;
            this.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 112;
            this.txtTotal.TabStop = false;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(696, 479);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(21, 13);
            this.labelControl9.TabIndex = 113;
            this.labelControl9.Text = "IVA:";
            // 
            // txtIVA
            // 
            this.txtIVA.Location = new System.Drawing.Point(719, 476);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtIVA.Properties.Appearance.Options.UseBackColor = true;
            this.txtIVA.Properties.EditFormat.FormatString = "C2";
            this.txtIVA.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtIVA.Properties.ReadOnly = true;
            this.txtIVA.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtIVA.Size = new System.Drawing.Size(100, 20);
            this.txtIVA.TabIndex = 110;
            this.txtIVA.TabStop = false;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(673, 459);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(44, 13);
            this.labelControl8.TabIndex = 110;
            this.labelControl8.Text = "Subtotal:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(719, 456);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtSubtotal.Properties.Appearance.Options.UseBackColor = true;
            this.txtSubtotal.Properties.EditFormat.FormatString = "C2";
            this.txtSubtotal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSubtotal.Properties.ReadOnly = true;
            this.txtSubtotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotal.TabIndex = 109;
            this.txtSubtotal.TabStop = false;
            // 
            // dbSAICBPOFactura
            // 
            this.dbSAICBPOFactura.DataSetName = "dbSAICBPOFactura";
            this.dbSAICBPOFactura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwcatFrontingBindingSource
            // 
            this.vwcatFrontingBindingSource.DataMember = "vwcatFronting";
            this.vwcatFrontingBindingSource.DataSource = this.dbSAICBPOFactura;
            // 
            // vwcatFrontingTableAdapter
            // 
            this.vwcatFrontingTableAdapter.ClearBeforeFill = true;
            // 
            // cbIdFronting
            // 
            this.cbIdFronting.Location = new System.Drawing.Point(129, 57);
            this.cbIdFronting.Name = "cbIdFronting";
            this.cbIdFronting.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbIdFronting.Properties.DataSource = this.vwcatFrontingBindingSource;
            this.cbIdFronting.Properties.DisplayMember = "NombreComercial";
            this.cbIdFronting.Properties.NullText = "";
            this.cbIdFronting.Properties.ValueMember = "IdMatrizTenedora";
            this.cbIdFronting.Properties.View = this.gridLookUpEdit1View;
            this.cbIdFronting.Size = new System.Drawing.Size(689, 20);
            this.cbIdFronting.TabIndex = 3;
            this.cbIdFronting.Tag = "Facturadora";
            this.cbIdFronting.EditValueChanged += new System.EventHandler(this.cboIdFronting_EditValueChanged);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdMatrizTenedora,
            this.colNombreComercial,
            this.colRazonSocial});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdMatrizTenedora
            // 
            this.colIdMatrizTenedora.Caption = "IdMatrizTenedora";
            this.colIdMatrizTenedora.FieldName = "IdMatrizTenedora";
            this.colIdMatrizTenedora.Name = "colIdMatrizTenedora";
            // 
            // colNombreComercial
            // 
            this.colNombreComercial.Caption = "Nombre Comercial";
            this.colNombreComercial.FieldName = "NombreComercial";
            this.colNombreComercial.Name = "colNombreComercial";
            this.colNombreComercial.Visible = true;
            this.colNombreComercial.VisibleIndex = 0;
            // 
            // colRazonSocial
            // 
            this.colRazonSocial.Caption = "Razon Social";
            this.colRazonSocial.FieldName = "RazonSocial";
            this.colRazonSocial.Name = "colRazonSocial";
            this.colRazonSocial.Visible = true;
            this.colRazonSocial.VisibleIndex = 1;
            // 
            // cbTipoFacturador
            // 
            this.cbTipoFacturador.Location = new System.Drawing.Point(129, 80);
            this.cbTipoFacturador.Name = "cbTipoFacturador";
            this.cbTipoFacturador.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTipoFacturador.Properties.DataSource = this.stpFactSelTipoBeneficiarioOperadorBindingSource;
            this.cbTipoFacturador.Properties.DisplayMember = "Desc";
            this.cbTipoFacturador.Properties.NullText = "";
            this.cbTipoFacturador.Properties.ValueMember = "IdFactTipoBeneficiario";
            this.cbTipoFacturador.Properties.View = this.gridView2;
            this.cbTipoFacturador.Size = new System.Drawing.Size(114, 20);
            this.cbTipoFacturador.TabIndex = 4;
            this.cbTipoFacturador.Tag = "Tipo Beneficiario";
            this.cbTipoFacturador.EditValueChanged += new System.EventHandler(this.cboTipoFacturador_EditValueChanged);
            // 
            // stpFactSelTipoBeneficiarioOperadorBindingSource
            // 
            this.stpFactSelTipoBeneficiarioOperadorBindingSource.DataMember = "stpFactSelTipoBeneficiarioOperador";
            this.stpFactSelTipoBeneficiarioOperadorBindingSource.DataSource = this.dbSAICBPOFactura;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdFactTipoBeneficiario,
            this.colDescTipoBeneficiario});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colIdFactTipoBeneficiario
            // 
            this.colIdFactTipoBeneficiario.Caption = "IdFactTipoBeneficiario";
            this.colIdFactTipoBeneficiario.FieldName = "IdFactTipoBeneficiario";
            this.colIdFactTipoBeneficiario.Name = "colIdFactTipoBeneficiario";
            // 
            // colDescTipoBeneficiario
            // 
            this.colDescTipoBeneficiario.Caption = "Tipo Beneficiario";
            this.colDescTipoBeneficiario.FieldName = "Desc";
            this.colDescTipoBeneficiario.Name = "colDescTipoBeneficiario";
            this.colDescTipoBeneficiario.Visible = true;
            this.colDescTipoBeneficiario.VisibleIndex = 0;
            // 
            // cbFormaPago
            // 
            this.cbFormaPago.Location = new System.Drawing.Point(331, 173);
            this.cbFormaPago.Name = "cbFormaPago";
            this.cbFormaPago.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbFormaPago.Properties.DataSource = this.stpFactSelObtenerFormaPagoBindingSource;
            this.cbFormaPago.Properties.DisplayMember = "Desc";
            this.cbFormaPago.Properties.NullText = "";
            this.cbFormaPago.Properties.ValueMember = "IdFactFormaPago";
            this.cbFormaPago.Properties.View = this.gridView3;
            this.cbFormaPago.Size = new System.Drawing.Size(114, 20);
            this.cbFormaPago.TabIndex = 13;
            this.cbFormaPago.Tag = "Froma de Pago";
            this.cbFormaPago.EditValueChanged += new System.EventHandler(this.cbFormaPago_EditValueChanged);
            // 
            // stpFactSelObtenerFormaPagoBindingSource
            // 
            this.stpFactSelObtenerFormaPagoBindingSource.DataMember = "stpFactSelObtenerFormaPago";
            this.stpFactSelObtenerFormaPagoBindingSource.DataSource = this.dbSAICBPOFactura;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdFactFormaPago,
            this.colClaveFormaPagoc,
            this.ColDescFormaPagoc});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colIdFactFormaPago
            // 
            this.colIdFactFormaPago.Caption = "IdFactFormaPago";
            this.colIdFactFormaPago.FieldName = "IdFactFormaPago";
            this.colIdFactFormaPago.Name = "colIdFactFormaPago";
            // 
            // colClaveFormaPagoc
            // 
            this.colClaveFormaPagoc.Caption = "ClaveFormaPago";
            this.colClaveFormaPagoc.FieldName = "Clave";
            this.colClaveFormaPagoc.Name = "colClaveFormaPagoc";
            // 
            // ColDescFormaPagoc
            // 
            this.ColDescFormaPagoc.Caption = "Forma Pago";
            this.ColDescFormaPagoc.FieldName = "Desc";
            this.ColDescFormaPagoc.Name = "ColDescFormaPagoc";
            this.ColDescFormaPagoc.Visible = true;
            this.ColDescFormaPagoc.VisibleIndex = 0;
            // 
            // vwFactCatFormaPagoBindingSource
            // 
            this.vwFactCatFormaPagoBindingSource.DataMember = "vwFactCatFormaPago";
            this.vwFactCatFormaPagoBindingSource.DataSource = this.dbSAICBPOFactura;
            // 
            // cbIdTenedora
            // 
            this.cbIdTenedora.Location = new System.Drawing.Point(330, 80);
            this.cbIdTenedora.Name = "cbIdTenedora";
            this.cbIdTenedora.Properties.Appearance.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.cbIdTenedora.Properties.Appearance.Options.UseBackColor = true;
            this.cbIdTenedora.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbIdTenedora.Properties.DataSource = this.stpFactSelBeneficiarioTenedoraBindingSource;
            this.cbIdTenedora.Properties.DisplayMember = "NombreComercial";
            this.cbIdTenedora.Properties.NullText = "";
            this.cbIdTenedora.Properties.ValueMember = "IdMatrizTenedora";
            this.cbIdTenedora.Properties.View = this.gridView4;
            this.cbIdTenedora.Size = new System.Drawing.Size(488, 20);
            this.cbIdTenedora.TabIndex = 5;
            this.cbIdTenedora.Tag = "Tenedora";
            this.cbIdTenedora.EditValueChanged += new System.EventHandler(this.cbIdTenedora_EditValueChanged);
            // 
            // stpFactSelBeneficiarioTenedoraBindingSource
            // 
            this.stpFactSelBeneficiarioTenedoraBindingSource.DataMember = "stpFactSelBeneficiarioTenedora";
            this.stpFactSelBeneficiarioTenedoraBindingSource.DataSource = this.dbSAICBPOFactura;
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdTenedora,
            this.colNombreComercialF,
            this.colRazonSocialT});
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // colIdTenedora
            // 
            this.colIdTenedora.Caption = "ID";
            this.colIdTenedora.FieldName = "IdMatrizTenedora";
            this.colIdTenedora.Name = "colIdTenedora";
            // 
            // colNombreComercialF
            // 
            this.colNombreComercialF.Caption = "Nombre Comercial";
            this.colNombreComercialF.FieldName = "NombreComercial";
            this.colNombreComercialF.Name = "colNombreComercialF";
            this.colNombreComercialF.Visible = true;
            this.colNombreComercialF.VisibleIndex = 0;
            // 
            // colRazonSocialT
            // 
            this.colRazonSocialT.Caption = "RazonSocial";
            this.colRazonSocialT.FieldName = "RazonSocial";
            this.colRazonSocialT.Name = "colRazonSocialT";
            this.colRazonSocialT.Visible = true;
            this.colRazonSocialT.VisibleIndex = 1;
            // 
            // cbMetodoPago
            // 
            this.cbMetodoPago.Location = new System.Drawing.Point(130, 173);
            this.cbMetodoPago.Name = "cbMetodoPago";
            this.cbMetodoPago.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMetodoPago.Properties.DataSource = this.vwFactCatMetodoPagoBindingSource;
            this.cbMetodoPago.Properties.DisplayMember = "Clave";
            this.cbMetodoPago.Properties.NullText = "";
            this.cbMetodoPago.Properties.ValueMember = "IdFactMetodoPago";
            this.cbMetodoPago.Properties.View = this.gridView5;
            this.cbMetodoPago.Size = new System.Drawing.Size(114, 20);
            this.cbMetodoPago.TabIndex = 12;
            this.cbMetodoPago.Tag = "Metodo de Pago";
            this.cbMetodoPago.EditValueChanged += new System.EventHandler(this.cbMetodoPago_EditValueChanged);
            // 
            // vwFactCatMetodoPagoBindingSource
            // 
            this.vwFactCatMetodoPagoBindingSource.DataMember = "vwFactCatMetodoPago";
            this.vwFactCatMetodoPagoBindingSource.DataSource = this.dbSAICBPOFactura;
            // 
            // gridView5
            // 
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdFactMetodoPago,
            this.colClaveFormaPago,
            this.colDescFormaPago});
            this.gridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            // 
            // colIdFactMetodoPago
            // 
            this.colIdFactMetodoPago.Caption = "IdFactMetodoPago";
            this.colIdFactMetodoPago.FieldName = "IdFactMetodoPago";
            this.colIdFactMetodoPago.Name = "colIdFactMetodoPago";
            // 
            // colClaveFormaPago
            // 
            this.colClaveFormaPago.Caption = "Clave";
            this.colClaveFormaPago.FieldName = "Clave";
            this.colClaveFormaPago.Name = "colClaveFormaPago";
            this.colClaveFormaPago.Visible = true;
            this.colClaveFormaPago.VisibleIndex = 0;
            this.colClaveFormaPago.Width = 132;
            // 
            // colDescFormaPago
            // 
            this.colDescFormaPago.Caption = "Metodo Pago";
            this.colDescFormaPago.FieldName = "Desc";
            this.colDescFormaPago.Name = "colDescFormaPago";
            this.colDescFormaPago.Visible = true;
            this.colDescFormaPago.VisibleIndex = 1;
            this.colDescFormaPago.Width = 568;
            // 
            // cbMoneda
            // 
            this.cbMoneda.Location = new System.Drawing.Point(536, 174);
            this.cbMoneda.Name = "cbMoneda";
            this.cbMoneda.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMoneda.Properties.DataSource = this.vwCatMonedaBindingSource;
            this.cbMoneda.Properties.DisplayMember = "IdMoneda";
            this.cbMoneda.Properties.NullText = "";
            this.cbMoneda.Properties.ValueMember = "IdMoneda";
            this.cbMoneda.Properties.View = this.gridView6;
            this.cbMoneda.Size = new System.Drawing.Size(114, 20);
            this.cbMoneda.TabIndex = 14;
            this.cbMoneda.Tag = "Moneda";
            this.cbMoneda.EditValueChanged += new System.EventHandler(this.cbMoneda_EditValueChanged);
            // 
            // vwCatMonedaBindingSource
            // 
            this.vwCatMonedaBindingSource.DataMember = "vwCatMoneda";
            this.vwCatMonedaBindingSource.DataSource = this.dbSAICBPOFactura;
            // 
            // gridView6
            // 
            this.gridView6.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdMoneda,
            this.colDescMoneda,
            this.colDescMonedaLarga});
            this.gridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView6.Name = "gridView6";
            this.gridView6.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView6.OptionsView.ShowGroupPanel = false;
            // 
            // colIdMoneda
            // 
            this.colIdMoneda.Caption = "Clave";
            this.colIdMoneda.FieldName = "IdMoneda";
            this.colIdMoneda.Name = "colIdMoneda";
            this.colIdMoneda.Visible = true;
            this.colIdMoneda.VisibleIndex = 0;
            this.colIdMoneda.Width = 180;
            // 
            // colDescMoneda
            // 
            this.colDescMoneda.Caption = "Moneda";
            this.colDescMoneda.FieldName = "DescMoneda";
            this.colDescMoneda.Name = "colDescMoneda";
            this.colDescMoneda.Visible = true;
            this.colDescMoneda.VisibleIndex = 1;
            this.colDescMoneda.Width = 520;
            // 
            // colDescMonedaLarga
            // 
            this.colDescMonedaLarga.Caption = "Moneda";
            this.colDescMonedaLarga.FieldName = "DescMonedaLarga";
            this.colDescMonedaLarga.Name = "colDescMonedaLarga";
            this.colDescMonedaLarga.Width = 169;
            // 
            // cbTipoRelacion
            // 
            this.cbTipoRelacion.Location = new System.Drawing.Point(129, 103);
            this.cbTipoRelacion.Name = "cbTipoRelacion";
            this.cbTipoRelacion.Properties.Appearance.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.cbTipoRelacion.Properties.Appearance.Options.UseBackColor = true;
            this.cbTipoRelacion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTipoRelacion.Properties.DataSource = this.stpFactSelCatTipoRelacionv2BindingSource;
            this.cbTipoRelacion.Properties.DisplayMember = "Desc";
            this.cbTipoRelacion.Properties.NullText = "";
            this.cbTipoRelacion.Properties.ValueMember = "IdFactTipoRelacion";
            this.cbTipoRelacion.Properties.View = this.gridView7;
            this.cbTipoRelacion.Size = new System.Drawing.Size(198, 20);
            this.cbTipoRelacion.TabIndex = 6;
            this.cbTipoRelacion.Tag = "Tipo Relación";
            this.cbTipoRelacion.EditValueChanged += new System.EventHandler(this.cbTipoRelacion_EditValueChanged);
            // 
            // stpFactSelCatTipoRelacionv2BindingSource
            // 
            this.stpFactSelCatTipoRelacionv2BindingSource.DataMember = "stpFactSelCatTipoRelacionv2";
            this.stpFactSelCatTipoRelacionv2BindingSource.DataSource = this.dbSAICBPOFactura;
            // 
            // gridView7
            // 
            this.gridView7.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coIdFactTipoRelacion,
            this.colClaveTipoRelacion,
            this.colDescTipoRelacion});
            this.gridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView7.Name = "gridView7";
            this.gridView7.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView7.OptionsView.ShowGroupPanel = false;
            // 
            // coIdFactTipoRelacion
            // 
            this.coIdFactTipoRelacion.Caption = "IdFactTipoRelacion";
            this.coIdFactTipoRelacion.FieldName = "IdFactTipoRelacion";
            this.coIdFactTipoRelacion.Name = "coIdFactTipoRelacion";
            // 
            // colClaveTipoRelacion
            // 
            this.colClaveTipoRelacion.Caption = "ClaveTipoRelacion";
            this.colClaveTipoRelacion.FieldName = "Clave";
            this.colClaveTipoRelacion.Name = "colClaveTipoRelacion";
            // 
            // colDescTipoRelacion
            // 
            this.colDescTipoRelacion.Caption = "Tipo Relación";
            this.colDescTipoRelacion.FieldName = "Desc";
            this.colDescTipoRelacion.Name = "colDescTipoRelacion";
            this.colDescTipoRelacion.Visible = true;
            this.colDescTipoRelacion.VisibleIndex = 0;
            // 
            // cbControl
            // 
            this.cbControl.Location = new System.Drawing.Point(129, 34);
            this.cbControl.Name = "cbControl";
            this.cbControl.Properties.Appearance.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.cbControl.Properties.Appearance.Options.UseBackColor = true;
            this.cbControl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbControl.Properties.DataSource = this.stpFactSelControlOperacionesV2BindingSource;
            this.cbControl.Properties.DisplayMember = "Descripcion";
            this.cbControl.Properties.NullText = "";
            this.cbControl.Properties.ValueMember = "IdControlOperaciones";
            this.cbControl.Properties.View = this.gridView8;
            this.cbControl.Size = new System.Drawing.Size(315, 20);
            this.cbControl.TabIndex = 0;
            this.cbControl.Tag = "No Control";
            this.cbControl.EditValueChanged += new System.EventHandler(this.cbControl_EditValueChanged);
            // 
            // stpFactSelControlOperacionesV2BindingSource
            // 
            this.stpFactSelControlOperacionesV2BindingSource.DataMember = "stpFactSelControlOperacionesV2";
            this.stpFactSelControlOperacionesV2BindingSource.DataSource = this.dbSAICBPOFactura;
            // 
            // gridView8
            // 
            this.gridView8.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdControlOperaciones,
            this.colDescripcion,
            this.colDescTipoPeriodoNomina,
            this.colRazonSocialCliente,
            this.colFechaInicio,
            this.colFechaFin,
            this.colSubtotalc,
            this.colIVAC,
            this.colTotal});
            this.gridView8.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView8.Name = "gridView8";
            this.gridView8.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView8.OptionsView.ColumnAutoWidth = false;
            this.gridView8.OptionsView.ShowGroupPanel = false;
            this.gridView8.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colIdControlOperaciones, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colIdControlOperaciones
            // 
            this.colIdControlOperaciones.Caption = "Id Control";
            this.colIdControlOperaciones.FieldName = "IdControlOperaciones";
            this.colIdControlOperaciones.Name = "colIdControlOperaciones";
            this.colIdControlOperaciones.Visible = true;
            this.colIdControlOperaciones.VisibleIndex = 0;
            this.colIdControlOperaciones.Width = 86;
            // 
            // colDescripcion
            // 
            this.colDescripcion.Caption = "Descripción";
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 1;
            this.colDescripcion.Width = 188;
            // 
            // colDescTipoPeriodoNomina
            // 
            this.colDescTipoPeriodoNomina.Caption = "Periodo";
            this.colDescTipoPeriodoNomina.FieldName = "DescTipoPeriodoNomina";
            this.colDescTipoPeriodoNomina.Name = "colDescTipoPeriodoNomina";
            this.colDescTipoPeriodoNomina.Visible = true;
            this.colDescTipoPeriodoNomina.VisibleIndex = 2;
            this.colDescTipoPeriodoNomina.Width = 129;
            // 
            // colRazonSocialCliente
            // 
            this.colRazonSocialCliente.Caption = "Cliente";
            this.colRazonSocialCliente.FieldName = "RazonSocialCliente";
            this.colRazonSocialCliente.Name = "colRazonSocialCliente";
            this.colRazonSocialCliente.Visible = true;
            this.colRazonSocialCliente.VisibleIndex = 3;
            this.colRazonSocialCliente.Width = 222;
            // 
            // colFechaInicio
            // 
            this.colFechaInicio.Caption = "Fecha Inicio";
            this.colFechaInicio.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.colFechaInicio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colFechaInicio.FieldName = "FechaInicio";
            this.colFechaInicio.Name = "colFechaInicio";
            this.colFechaInicio.Visible = true;
            this.colFechaInicio.VisibleIndex = 4;
            this.colFechaInicio.Width = 86;
            // 
            // colFechaFin
            // 
            this.colFechaFin.Caption = "Fecha Fin";
            this.colFechaFin.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.colFechaFin.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colFechaFin.FieldName = "FechaFin";
            this.colFechaFin.Name = "colFechaFin";
            this.colFechaFin.Visible = true;
            this.colFechaFin.VisibleIndex = 5;
            this.colFechaFin.Width = 85;
            // 
            // colSubtotalc
            // 
            this.colSubtotalc.Caption = "Subtotal";
            this.colSubtotalc.DisplayFormat.FormatString = "C2";
            this.colSubtotalc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSubtotalc.FieldName = "Subtotal";
            this.colSubtotalc.Name = "colSubtotalc";
            this.colSubtotalc.Visible = true;
            this.colSubtotalc.VisibleIndex = 6;
            this.colSubtotalc.Width = 106;
            // 
            // colIVAC
            // 
            this.colIVAC.Caption = "IVA";
            this.colIVAC.DisplayFormat.FormatString = "C2";
            this.colIVAC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colIVAC.FieldName = "IVA";
            this.colIVAC.Name = "colIVAC";
            this.colIVAC.Visible = true;
            this.colIVAC.VisibleIndex = 7;
            this.colIVAC.Width = 76;
            // 
            // colTotal
            // 
            this.colTotal.Caption = "Total";
            this.colTotal.DisplayFormat.FormatString = "C2";
            this.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotal.FieldName = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 8;
            // 
            // cbFacturaRelacion
            // 
            this.cbFacturaRelacion.Location = new System.Drawing.Point(445, 103);
            this.cbFacturaRelacion.Name = "cbFacturaRelacion";
            this.cbFacturaRelacion.Properties.Appearance.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.cbFacturaRelacion.Properties.Appearance.Options.UseBackColor = true;
            this.cbFacturaRelacion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbFacturaRelacion.Properties.DataSource = this.stpFactSelFacturasARelacionarSATBindingSource;
            this.cbFacturaRelacion.Properties.DisplayMember = "IdHeaderFactura";
            this.cbFacturaRelacion.Properties.NullText = "";
            this.cbFacturaRelacion.Properties.ValueMember = "IdHeaderFactura";
            this.cbFacturaRelacion.Properties.View = this.gridView9;
            this.cbFacturaRelacion.Size = new System.Drawing.Size(373, 20);
            this.cbFacturaRelacion.TabIndex = 7;
            this.cbFacturaRelacion.Tag = "Factura de Relación";
            this.cbFacturaRelacion.EditValueChanged += new System.EventHandler(this.cbFacturaRelacion_EditValueChanged);
            // 
            // stpFactSelFacturasARelacionarSATBindingSource
            // 
            this.stpFactSelFacturasARelacionarSATBindingSource.DataMember = "stpFactSelFacturasARelacionarSAT";
            this.stpFactSelFacturasARelacionarSATBindingSource.DataSource = this.dbSAICBPOFactura;
            // 
            // gridView9
            // 
            this.gridView9.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdHeaderFactura,
            this.ColSerie,
            this.ColFolioInterno,
            this.ColDescMetodoPago,
            this.ColDescFormadPago,
            this.ColTotalF,
            this.colFechaGeneracionCFDI,
            this.ColUUID,
            this.colEstatus});
            this.gridView9.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView9.Name = "gridView9";
            this.gridView9.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView9.OptionsView.ColumnAutoWidth = false;
            this.gridView9.OptionsView.ShowGroupPanel = false;
            // 
            // colIdHeaderFactura
            // 
            this.colIdHeaderFactura.Caption = "Id Factura";
            this.colIdHeaderFactura.FieldName = "IdHeaderFactura";
            this.colIdHeaderFactura.Name = "colIdHeaderFactura";
            this.colIdHeaderFactura.Visible = true;
            this.colIdHeaderFactura.VisibleIndex = 0;
            this.colIdHeaderFactura.Width = 70;
            // 
            // ColSerie
            // 
            this.ColSerie.Caption = "Serie";
            this.ColSerie.FieldName = "Serie";
            this.ColSerie.Name = "ColSerie";
            this.ColSerie.Visible = true;
            this.ColSerie.VisibleIndex = 1;
            this.ColSerie.Width = 48;
            // 
            // ColFolioInterno
            // 
            this.ColFolioInterno.Caption = "Folio";
            this.ColFolioInterno.FieldName = "FolioInterno";
            this.ColFolioInterno.Name = "ColFolioInterno";
            this.ColFolioInterno.Visible = true;
            this.ColFolioInterno.VisibleIndex = 2;
            this.ColFolioInterno.Width = 52;
            // 
            // ColDescMetodoPago
            // 
            this.ColDescMetodoPago.Caption = "Metodo de Pago";
            this.ColDescMetodoPago.FieldName = "ClaveMetodoPago";
            this.ColDescMetodoPago.Name = "ColDescMetodoPago";
            this.ColDescMetodoPago.Visible = true;
            this.ColDescMetodoPago.VisibleIndex = 3;
            this.ColDescMetodoPago.Width = 98;
            // 
            // ColDescFormadPago
            // 
            this.ColDescFormadPago.Caption = "Forma de Pago";
            this.ColDescFormadPago.FieldName = "DescFormaPago";
            this.ColDescFormadPago.Name = "ColDescFormadPago";
            this.ColDescFormadPago.Visible = true;
            this.ColDescFormadPago.VisibleIndex = 4;
            this.ColDescFormadPago.Width = 92;
            // 
            // ColTotalF
            // 
            this.ColTotalF.Caption = "Total";
            this.ColTotalF.DisplayFormat.FormatString = "C2";
            this.ColTotalF.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ColTotalF.FieldName = "Total";
            this.ColTotalF.Name = "ColTotalF";
            this.ColTotalF.Visible = true;
            this.ColTotalF.VisibleIndex = 5;
            this.ColTotalF.Width = 97;
            // 
            // colFechaGeneracionCFDI
            // 
            this.colFechaGeneracionCFDI.Caption = "Fecha";
            this.colFechaGeneracionCFDI.FieldName = "FechaGeneracionCFDI";
            this.colFechaGeneracionCFDI.Name = "colFechaGeneracionCFDI";
            this.colFechaGeneracionCFDI.Visible = true;
            this.colFechaGeneracionCFDI.VisibleIndex = 6;
            // 
            // ColUUID
            // 
            this.ColUUID.Caption = "UUID";
            this.ColUUID.FieldName = "UUID";
            this.ColUUID.Name = "ColUUID";
            this.ColUUID.Visible = true;
            this.ColUUID.VisibleIndex = 7;
            this.ColUUID.Width = 197;
            // 
            // colEstatus
            // 
            this.colEstatus.Caption = "Estatus";
            this.colEstatus.FieldName = "EstatusDocumento";
            this.colEstatus.Name = "colEstatus";
            this.colEstatus.Visible = true;
            this.colEstatus.VisibleIndex = 8;
            // 
            // cboIdCliente
            // 
            this.cboIdCliente.Enabled = false;
            this.cboIdCliente.Location = new System.Drawing.Point(330, 80);
            this.cboIdCliente.Name = "cboIdCliente";
            this.cboIdCliente.Properties.Appearance.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.cboIdCliente.Properties.Appearance.Options.UseBackColor = true;
            this.cboIdCliente.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboIdCliente.Properties.DataSource = this.stpFactSelBeneficiarioClienteNBindingSource;
            this.cboIdCliente.Properties.DisplayMember = "NombreComercial";
            this.cboIdCliente.Properties.NullText = "";
            this.cboIdCliente.Properties.ValueMember = "IdCliente";
            this.cboIdCliente.Properties.View = this.gridView10;
            this.cboIdCliente.Size = new System.Drawing.Size(488, 20);
            this.cboIdCliente.TabIndex = 4;
            this.cboIdCliente.Tag = "Cliente";
            this.cboIdCliente.EditValueChanged += new System.EventHandler(this.cboIdCliente_EditValueChanged);
            // 
            // stpFactSelBeneficiarioClienteNBindingSource
            // 
            this.stpFactSelBeneficiarioClienteNBindingSource.DataMember = "stpFactSelBeneficiarioClienteN";
            this.stpFactSelBeneficiarioClienteNBindingSource.DataSource = this.dbSAICBPOFactura;
            // 
            // gridView10
            // 
            this.gridView10.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdMatrizCliente,
            this.colNombreComercialC,
            this.colRazonSocialC});
            this.gridView10.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView10.Name = "gridView10";
            this.gridView10.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView10.OptionsView.ShowGroupPanel = false;
            // 
            // colIdMatrizCliente
            // 
            this.colIdMatrizCliente.Caption = "ID";
            this.colIdMatrizCliente.FieldName = "IdMatrizCliente";
            this.colIdMatrizCliente.Name = "colIdMatrizCliente";
            // 
            // colNombreComercialC
            // 
            this.colNombreComercialC.Caption = "Nombre Comercial";
            this.colNombreComercialC.FieldName = "NombreComercial";
            this.colNombreComercialC.Name = "colNombreComercialC";
            this.colNombreComercialC.Visible = true;
            this.colNombreComercialC.VisibleIndex = 0;
            // 
            // colRazonSocialC
            // 
            this.colRazonSocialC.Caption = "Razon Social";
            this.colRazonSocialC.FieldName = "RazonSocial";
            this.colRazonSocialC.Name = "colRazonSocialC";
            this.colRazonSocialC.Visible = true;
            this.colRazonSocialC.VisibleIndex = 1;
            // 
            // vwFactCatFormaPagoTableAdapter
            // 
            this.vwFactCatFormaPagoTableAdapter.ClearBeforeFill = true;
            // 
            // stpFactSelObtenerFormaPagoTableAdapter
            // 
            this.stpFactSelObtenerFormaPagoTableAdapter.ClearBeforeFill = true;
            // 
            // vwFactCatMetodoPagoTableAdapter
            // 
            this.vwFactCatMetodoPagoTableAdapter.ClearBeforeFill = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Appearance.BackColor = System.Drawing.Color.White;
            this.btnEliminar.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Appearance.Options.UseBackColor = true;
            this.btnEliminar.Appearance.Options.UseFont = true;
            this.btnEliminar.Appearance.Options.UseTextOptions = true;
            this.btnEliminar.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnEliminar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.ImageOptions.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(524, 5);
            this.btnEliminar.LookAndFeel.SkinName = "VS2010";
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(124, 28);
            this.btnEliminar.TabIndex = 24;
            this.btnEliminar.Text = "Eliminar Concepto";
            this.btnEliminar.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // stpFactSelBeneficiarioTenedoraTableAdapter
            // 
            this.stpFactSelBeneficiarioTenedoraTableAdapter.ClearBeforeFill = true;
            // 
            // ofdComprobante
            // 
            this.ofdComprobante.FileName = "openFileDialog1";
            // 
            // stpFactSelDerechosAccesoFacturacionBindingSource
            // 
            this.stpFactSelDerechosAccesoFacturacionBindingSource.DataMember = "stpFactSelDerechosAccesoFacturacion";
            this.stpFactSelDerechosAccesoFacturacionBindingSource.DataSource = this.dbSAICBPOFactura;
            // 
            // stpFactSelDerechosAccesoFacturacionTableAdapter
            // 
            this.stpFactSelDerechosAccesoFacturacionTableAdapter.ClearBeforeFill = true;
            // 
            // stpFactSelTipoBeneficiarioOperadorTableAdapter
            // 
            this.stpFactSelTipoBeneficiarioOperadorTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 119;
            this.label2.Text = "Banco Origen:";
            // 
            // cbBancoOrigen
            // 
            this.cbBancoOrigen.Location = new System.Drawing.Point(130, 196);
            this.cbBancoOrigen.Name = "cbBancoOrigen";
            this.cbBancoOrigen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbBancoOrigen.Properties.DataSource = this.stpFactSelFrontingClienteBancoBindingSource;
            this.cbBancoOrigen.Properties.DisplayMember = "NombreBanco";
            this.cbBancoOrigen.Properties.NullText = "";
            this.cbBancoOrigen.Properties.ValueMember = "IdBanco";
            this.cbBancoOrigen.Properties.View = this.gridView11;
            this.cbBancoOrigen.Size = new System.Drawing.Size(114, 20);
            this.cbBancoOrigen.TabIndex = 16;
            this.cbBancoOrigen.Tag = "Banco Origen";
            this.cbBancoOrigen.EditValueChanged += new System.EventHandler(this.cbBancoOrigen_EditValueChanged);
            // 
            // stpFactSelFrontingClienteBancoBindingSource
            // 
            this.stpFactSelFrontingClienteBancoBindingSource.DataMember = "stpFactSelFrontingClienteBanco";
            this.stpFactSelFrontingClienteBancoBindingSource.DataSource = this.dbSAICBPOFactura;
            // 
            // gridView11
            // 
            this.gridView11.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdBanco,
            this.colNombreBanco});
            this.gridView11.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView11.Name = "gridView11";
            this.gridView11.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView11.OptionsView.ShowGroupPanel = false;
            // 
            // colIdBanco
            // 
            this.colIdBanco.Caption = "IdBanco";
            this.colIdBanco.FieldName = "IdBanco";
            this.colIdBanco.Name = "colIdBanco";
            // 
            // colNombreBanco
            // 
            this.colNombreBanco.Caption = "Banco";
            this.colNombreBanco.FieldName = "NombreBanco";
            this.colNombreBanco.Name = "colNombreBanco";
            this.colNombreBanco.Visible = true;
            this.colNombreBanco.VisibleIndex = 0;
            this.colNombreBanco.Width = 132;
            // 
            // dbSAICBPOCatalogosDataSet
            // 
            this.dbSAICBPOCatalogosDataSet.DataSetName = "dbSAICBPOCatalogosDataSet";
            this.dbSAICBPOCatalogosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(451, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 121;
            this.label8.Text = "Banco Destino:";
            // 
            // cbBancoDestino
            // 
            this.cbBancoDestino.Location = new System.Drawing.Point(536, 197);
            this.cbBancoDestino.Name = "cbBancoDestino";
            this.cbBancoDestino.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbBancoDestino.Properties.DataSource = this.stpFactSelFrontingClienteBanco1BindingSource;
            this.cbBancoDestino.Properties.DisplayMember = "NombreBanco";
            this.cbBancoDestino.Properties.NullText = "";
            this.cbBancoDestino.Properties.ValueMember = "IdBanco";
            this.cbBancoDestino.Properties.View = this.gridView12;
            this.cbBancoDestino.Size = new System.Drawing.Size(114, 20);
            this.cbBancoDestino.TabIndex = 18;
            this.cbBancoDestino.Tag = "Banco Destino";
            // 
            // stpFactSelFrontingClienteBanco1BindingSource
            // 
            this.stpFactSelFrontingClienteBanco1BindingSource.DataMember = "stpFactSelFrontingClienteBanco1";
            this.stpFactSelFrontingClienteBanco1BindingSource.DataSource = this.dbSAICBPOFactura;
            // 
            // gridView12
            // 
            this.gridView12.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdBancoD,
            this.colNombreBancoD,
            this.IdMatrizTenedora});
            this.gridView12.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView12.Name = "gridView12";
            this.gridView12.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView12.OptionsView.ShowGroupPanel = false;
            // 
            // colIdBancoD
            // 
            this.colIdBancoD.Caption = "IdBanco";
            this.colIdBancoD.FieldName = "IdBanco";
            this.colIdBancoD.Name = "colIdBancoD";
            // 
            // colNombreBancoD
            // 
            this.colNombreBancoD.Caption = "Banco";
            this.colNombreBancoD.FieldName = "NombreBanco";
            this.colNombreBancoD.Name = "colNombreBancoD";
            this.colNombreBancoD.Visible = true;
            this.colNombreBancoD.VisibleIndex = 0;
            this.colNombreBancoD.Width = 132;
            // 
            // IdMatrizTenedora
            // 
            this.IdMatrizTenedora.Caption = "IdMatrizTenedora";
            this.IdMatrizTenedora.FieldName = "IdMatrizTenedora";
            this.IdMatrizTenedora.Name = "IdMatrizTenedora";
            this.IdMatrizTenedora.Width = 568;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(451, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 124;
            this.label9.Text = "Total Deposito:";
            // 
            // txtDeposito
            // 
            this.txtDeposito.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtDeposito.Location = new System.Drawing.Point(536, 220);
            this.txtDeposito.Name = "txtDeposito";
            this.txtDeposito.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDeposito.Properties.DisplayFormat.FormatString = "C2";
            this.txtDeposito.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDeposito.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtDeposito.Size = new System.Drawing.Size(114, 20);
            this.txtDeposito.TabIndex = 20;
            this.txtDeposito.Tag = "Total Deposito";
            // 
            // txtCambio
            // 
            this.txtCambio.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtCambio.Location = new System.Drawing.Point(727, 173);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtCambio.Properties.DisplayFormat.FormatString = "C2";
            this.txtCambio.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtCambio.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtCambio.Size = new System.Drawing.Size(92, 20);
            this.txtCambio.TabIndex = 15;
            this.txtCambio.Tag = "Tipo Cambio";
            // 
            // stpFactSelFacturasARelacionarSATTableAdapter
            // 
            this.stpFactSelFacturasARelacionarSATTableAdapter.ClearBeforeFill = true;
            // 
            // stpFactSelHeaderFacturasModificarTableAdapter1
            // 
            this.stpFactSelHeaderFacturasModificarTableAdapter1.ClearBeforeFill = true;
            // 
            // stpFactSelDetailFacturasTableAdapter1
            // 
            this.stpFactSelDetailFacturasTableAdapter1.ClearBeforeFill = true;
            // 
            // labelControl18
            // 
            this.labelControl18.Location = new System.Drawing.Point(670, 479);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(11, 13);
            this.labelControl18.TabIndex = 126;
            this.labelControl18.Text = "%";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(67, 153);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 13);
            this.label14.TabIndex = 128;
            this.label14.Text = "Uso CFDI:";
            // 
            // cbUsoCFDI
            // 
            this.cbUsoCFDI.Location = new System.Drawing.Point(130, 150);
            this.cbUsoCFDI.Name = "cbUsoCFDI";
            this.cbUsoCFDI.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbUsoCFDI.Properties.DataSource = this.stpFactSelUsoCFDIBindingSource;
            this.cbUsoCFDI.Properties.DisplayMember = "Desc";
            this.cbUsoCFDI.Properties.NullText = "";
            this.cbUsoCFDI.Properties.ValueMember = "IdFactUsoCFDI";
            this.cbUsoCFDI.Properties.View = this.gridView13;
            this.cbUsoCFDI.Size = new System.Drawing.Size(315, 20);
            this.cbUsoCFDI.TabIndex = 10;
            this.cbUsoCFDI.Tag = "Uso CFDI";
            // 
            // stpFactSelUsoCFDIBindingSource
            // 
            this.stpFactSelUsoCFDIBindingSource.DataMember = "stpFactSelUsoCFDI";
            this.stpFactSelUsoCFDIBindingSource.DataSource = this.dbSAICBPOFactura;
            // 
            // gridView13
            // 
            this.gridView13.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colIdUsoCFDI,
            this.colClave});
            this.gridView13.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView13.Name = "gridView13";
            this.gridView13.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView13.OptionsView.ShowGroupPanel = false;
            // 
            // colID
            // 
            this.colID.Caption = "Id";
            this.colID.FieldName = "IdFactUsoCFDI";
            this.colID.Name = "colID";
            // 
            // colIdUsoCFDI
            // 
            this.colIdUsoCFDI.Caption = "Uso CFDI";
            this.colIdUsoCFDI.FieldName = "Desc";
            this.colIdUsoCFDI.Name = "colIdUsoCFDI";
            this.colIdUsoCFDI.Visible = true;
            this.colIdUsoCFDI.VisibleIndex = 0;
            this.colIdUsoCFDI.Width = 132;
            // 
            // colClave
            // 
            this.colClave.Caption = "Clave";
            this.colClave.FieldName = "Clave";
            this.colClave.Name = "colClave";
            this.colClave.Visible = true;
            this.colClave.VisibleIndex = 1;
            // 
            // vwCatMonedaTableAdapter
            // 
            this.vwCatMonedaTableAdapter.ClearBeforeFill = true;
            // 
            // stpFactSelUsoCFDITableAdapter
            // 
            this.stpFactSelUsoCFDITableAdapter.ClearBeforeFill = true;
            // 
            // stpFactSelReporteFacturaPDFTableAdapter
            // 
            this.stpFactSelReporteFacturaPDFTableAdapter.ClearBeforeFill = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(247, 200);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 13);
            this.label15.TabIndex = 130;
            this.label15.Text = "Cuenta Origen:";
            // 
            // cbCuentaOrigen
            // 
            this.cbCuentaOrigen.Location = new System.Drawing.Point(331, 197);
            this.cbCuentaOrigen.Name = "cbCuentaOrigen";
            this.cbCuentaOrigen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbCuentaOrigen.Properties.DataSource = this.stpFactSelBeneficiarioBancoBindingSource;
            this.cbCuentaOrigen.Properties.DisplayMember = "Cuenta";
            this.cbCuentaOrigen.Properties.NullText = "";
            this.cbCuentaOrigen.Properties.ValueMember = "IdFactCuentaBancoBeneficiario";
            this.cbCuentaOrigen.Properties.View = this.gridView14;
            this.cbCuentaOrigen.Size = new System.Drawing.Size(114, 20);
            this.cbCuentaOrigen.TabIndex = 17;
            this.cbCuentaOrigen.Tag = "Cuenta Origen";
            // 
            // stpFactSelBeneficiarioBancoBindingSource
            // 
            this.stpFactSelBeneficiarioBancoBindingSource.DataMember = "stpFactSelBeneficiarioBanco";
            this.stpFactSelBeneficiarioBancoBindingSource.DataSource = this.dbSAICBPOFactura;
            // 
            // gridView14
            // 
            this.gridView14.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridView14.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView14.Name = "gridView14";
            this.gridView14.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView14.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "IdBanco";
            this.gridColumn1.FieldName = "IdFactCuentaBancoBeneficiario";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Cuenta";
            this.gridColumn2.FieldName = "Cuenta";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 132;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(480, 37);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 13);
            this.label16.TabIndex = 222;
            this.label16.Text = "Producto:";
            // 
            // cbProducto
            // 
            this.cbProducto.Location = new System.Drawing.Point(535, 34);
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbProducto.Properties.DataSource = this.stpFactSelProductoBindingSource;
            this.cbProducto.Properties.DisplayMember = "Desc";
            this.cbProducto.Properties.NullText = "";
            this.cbProducto.Properties.ValueMember = "IdFactProductosSerie";
            this.cbProducto.Properties.View = this.gridView15;
            this.cbProducto.Size = new System.Drawing.Size(114, 20);
            this.cbProducto.TabIndex = 1;
            this.cbProducto.Tag = "Producto";
            // 
            // stpFactSelProductoBindingSource
            // 
            this.stpFactSelProductoBindingSource.DataMember = "stpFactSelProducto";
            this.stpFactSelProductoBindingSource.DataSource = this.dbSAICBPOFactura;
            // 
            // gridView15
            // 
            this.gridView15.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn43,
            this.gridColumn44});
            this.gridView15.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView15.Name = "gridView15";
            this.gridView15.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView15.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn43
            // 
            this.gridColumn43.Caption = "Producto";
            this.gridColumn43.FieldName = "Desc";
            this.gridColumn43.Name = "gridColumn43";
            this.gridColumn43.Visible = true;
            this.gridColumn43.VisibleIndex = 0;
            // 
            // gridColumn44
            // 
            this.gridColumn44.Caption = "gridColumn44";
            this.gridColumn44.FieldName = "IdFactProductosSerie";
            this.gridColumn44.Name = "gridColumn44";
            // 
            // stpFactSelProductoTableAdapter
            // 
            this.stpFactSelProductoTableAdapter.ClearBeforeFill = true;
            // 
            // stpFactSelControlOperacionesV2TableAdapter
            // 
            this.stpFactSelControlOperacionesV2TableAdapter.ClearBeforeFill = true;
            // 
            // stpFactSelCatTipoRelacionv2TableAdapter
            // 
            this.stpFactSelCatTipoRelacionv2TableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(153)))), ((int)(((byte)(205)))));
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnConcepto);
            this.panel1.Location = new System.Drawing.Point(1, 243);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 37);
            this.panel1.TabIndex = 224;
            // 
            // cbFacturaRelacionRecibo
            // 
            this.cbFacturaRelacionRecibo.Location = new System.Drawing.Point(129, 127);
            this.cbFacturaRelacionRecibo.Name = "cbFacturaRelacionRecibo";
            this.cbFacturaRelacionRecibo.Properties.Appearance.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.cbFacturaRelacionRecibo.Properties.Appearance.Options.UseBackColor = true;
            this.cbFacturaRelacionRecibo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbFacturaRelacionRecibo.Properties.DataSource = this.stpFactSelFacturasARelacionarSAT1BindingSource;
            this.cbFacturaRelacionRecibo.Properties.DisplayMember = "IdHeaderFactura";
            this.cbFacturaRelacionRecibo.Properties.NullText = "";
            this.cbFacturaRelacionRecibo.Properties.ValueMember = "IdHeaderFactura";
            this.cbFacturaRelacionRecibo.Properties.View = this.gridView16;
            this.cbFacturaRelacionRecibo.Size = new System.Drawing.Size(316, 20);
            this.cbFacturaRelacionRecibo.TabIndex = 9;
            this.cbFacturaRelacionRecibo.Tag = "Factura de Relación";
            this.cbFacturaRelacionRecibo.EditValueChanged += new System.EventHandler(this.cbFacturaRelacionRecibo_EditValueChanged);
            // 
            // stpFactSelFacturasARelacionarSAT1BindingSource
            // 
            this.stpFactSelFacturasARelacionarSAT1BindingSource.DataMember = "stpFactSelFacturasARelacionarSAT1";
            this.stpFactSelFacturasARelacionarSAT1BindingSource.DataSource = this.dbSAICBPOFactura;
            // 
            // gridView16
            // 
            this.gridView16.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn13,
            this.gridColumn14});
            this.gridView16.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView16.Name = "gridView16";
            this.gridView16.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView16.OptionsSelection.MultiSelect = true;
            this.gridView16.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView16.OptionsView.ColumnAutoWidth = false;
            this.gridView16.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Id Factura";
            this.gridColumn3.FieldName = "IdHeaderFactura";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 70;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Serie";
            this.gridColumn4.FieldName = "Serie";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 48;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Folio";
            this.gridColumn5.FieldName = "FolioInterno";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            this.gridColumn5.Width = 52;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Metodo de Pago";
            this.gridColumn6.FieldName = "ClaveMetodoPago";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            this.gridColumn6.Width = 98;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Forma de Pago";
            this.gridColumn7.FieldName = "DescFormaPago";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 5;
            this.gridColumn7.Width = 92;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Total";
            this.gridColumn8.DisplayFormat.FormatString = "C2";
            this.gridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn8.FieldName = "Total";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 7;
            this.gridColumn8.Width = 97;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Fecha";
            this.gridColumn9.FieldName = "FechaGeneracionCFDI";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 9;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "UUID";
            this.gridColumn10.FieldName = "UUID";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 10;
            this.gridColumn10.Width = 197;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Estatus";
            this.gridColumn11.FieldName = "EstatusDocumento";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 11;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "Moneda";
            this.gridColumn13.FieldName = "IdMoneda";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 6;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "Saldo";
            this.gridColumn14.DisplayFormat.FormatString = "C2";
            this.gridColumn14.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn14.FieldName = "SaldoAnterior";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 8;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(653, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(64, 13);
            this.labelControl1.TabIndex = 225;
            this.labelControl1.Text = "Tipo Factura:";
            // 
            // txtTipoFactura
            // 
            this.txtTipoFactura.Location = new System.Drawing.Point(718, 34);
            this.txtTipoFactura.Name = "txtTipoFactura";
            this.txtTipoFactura.Size = new System.Drawing.Size(100, 21);
            this.txtTipoFactura.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(644, 522);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(72, 13);
            this.labelControl2.TabIndex = 228;
            this.labelControl2.Text = "Retención ISN:";
            // 
            // txtTotalISN
            // 
            this.txtTotalISN.Location = new System.Drawing.Point(719, 518);
            this.txtTotalISN.Name = "txtTotalISN";
            this.txtTotalISN.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtTotalISN.Properties.Appearance.Options.UseBackColor = true;
            this.txtTotalISN.Properties.EditFormat.FormatString = "C2";
            this.txtTotalISN.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTotalISN.Properties.ReadOnly = true;
            this.txtTotalISN.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalISN.Size = new System.Drawing.Size(100, 20);
            this.txtTotalISN.TabIndex = 111;
            this.txtTotalISN.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(48, 130);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(75, 13);
            this.label17.TabIndex = 229;
            this.label17.Text = "Facturas PPD:";
            // 
            // btnActualizar
            // 
            this.btnActualizar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.ImageOptions.Image")));
            this.btnActualizar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnActualizar.Location = new System.Drawing.Point(451, 125);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(25, 23);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // stpFactSelFacturasARelacionarSAT1TableAdapter
            // 
            this.stpFactSelFacturasARelacionarSAT1TableAdapter.ClearBeforeFill = true;
            // 
            // splashSMCargando
            // 
            this.splashSMCargando.ClosingDelay = 500;
            // 
            // txtIVAPor
            // 
            this.txtIVAPor.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtIVAPor.Location = new System.Drawing.Point(623, 476);
            this.txtIVAPor.Name = "txtIVAPor";
            this.txtIVAPor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtIVAPor.Properties.DisplayFormat.FormatString = "##";
            this.txtIVAPor.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtIVAPor.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtIVAPor.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.txtIVAPor.Size = new System.Drawing.Size(47, 20);
            this.txtIVAPor.TabIndex = 230;
            this.txtIVAPor.Tag = "Tipo Cambio";
            // 
            // stpFactSelObtenerParametrosFrontingTableAdapter1
            // 
            this.stpFactSelObtenerParametrosFrontingTableAdapter1.ClearBeforeFill = true;
            // 
            // stpFactSelFrontingClienteBancoTableAdapter
            // 
            this.stpFactSelFrontingClienteBancoTableAdapter.ClearBeforeFill = true;
            // 
            // stpFactSelFrontingClienteBanco1TableAdapter
            // 
            this.stpFactSelFrontingClienteBanco1TableAdapter.ClearBeforeFill = true;
            // 
            // stpFactSelBeneficiarioBancoTableAdapter
            // 
            this.stpFactSelBeneficiarioBancoTableAdapter.ClearBeforeFill = true;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(645, 501);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(72, 13);
            this.labelControl4.TabIndex = 238;
            this.labelControl4.Text = "Retención IVA:";
            // 
            // txtRetencionIVA
            // 
            this.txtRetencionIVA.Location = new System.Drawing.Point(719, 497);
            this.txtRetencionIVA.Name = "txtRetencionIVA";
            this.txtRetencionIVA.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtRetencionIVA.Properties.Appearance.Options.UseBackColor = true;
            this.txtRetencionIVA.Properties.EditFormat.FormatString = "C2";
            this.txtRetencionIVA.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtRetencionIVA.Properties.ReadOnly = true;
            this.txtRetencionIVA.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtRetencionIVA.Size = new System.Drawing.Size(100, 20);
            this.txtRetencionIVA.TabIndex = 237;
            this.txtRetencionIVA.TabStop = false;
            // 
            // dbSAICBPOValidacionDataSet1
            // 
            this.dbSAICBPOValidacionDataSet1.DataSetName = "dbSAICBPOValidacionDataSet";
            this.dbSAICBPOValidacionDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stpSelParametroTableAdapter1
            // 
            this.stpSelParametroTableAdapter1.ClearBeforeFill = true;
            // 
            // lblFR1
            // 
            this.lblFR1.AutoSize = true;
            this.lblFR1.Location = new System.Drawing.Point(12, 130);
            this.lblFR1.Name = "lblFR1";
            this.lblFR1.Size = new System.Drawing.Size(111, 13);
            this.lblFR1.TabIndex = 239;
            this.lblFR1.Text = "Facturas de Relación:";
            this.lblFR1.Visible = false;
            // 
            // txtTotalR
            // 
            this.txtTotalR.Location = new System.Drawing.Point(719, 538);
            this.txtTotalR.Name = "txtTotalR";
            this.txtTotalR.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtTotalR.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.txtTotalR.Properties.Appearance.Options.UseBackColor = true;
            this.txtTotalR.Properties.Appearance.Options.UseFont = true;
            this.txtTotalR.Properties.EditFormat.FormatString = "C2";
            this.txtTotalR.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTotalR.Properties.ReadOnly = true;
            this.txtTotalR.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalR.Size = new System.Drawing.Size(100, 20);
            this.txtTotalR.TabIndex = 245;
            // 
            // txtIVAR
            // 
            this.txtIVAR.Location = new System.Drawing.Point(719, 476);
            this.txtIVAR.Name = "txtIVAR";
            this.txtIVAR.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtIVAR.Properties.Appearance.Options.UseBackColor = true;
            this.txtIVAR.Properties.EditFormat.FormatString = "C2";
            this.txtIVAR.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtIVAR.Properties.ReadOnly = true;
            this.txtIVAR.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtIVAR.Size = new System.Drawing.Size(100, 20);
            this.txtIVAR.TabIndex = 244;
            // 
            // txtSubtotalR
            // 
            this.txtSubtotalR.Location = new System.Drawing.Point(719, 456);
            this.txtSubtotalR.Name = "txtSubtotalR";
            this.txtSubtotalR.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtSubtotalR.Properties.Appearance.Options.UseBackColor = true;
            this.txtSubtotalR.Properties.EditFormat.FormatString = "C2";
            this.txtSubtotalR.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSubtotalR.Properties.ReadOnly = true;
            this.txtSubtotalR.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSubtotalR.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotalR.TabIndex = 243;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(23, 460);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(66, 13);
            this.labelControl3.TabIndex = 247;
            this.labelControl3.Text = "Total Cambio:";
            this.labelControl3.Visible = false;
            // 
            // txtTotalP
            // 
            this.txtTotalP.Location = new System.Drawing.Point(92, 456);
            this.txtTotalP.Name = "txtTotalP";
            this.txtTotalP.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtTotalP.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.txtTotalP.Properties.Appearance.Options.UseBackColor = true;
            this.txtTotalP.Properties.Appearance.Options.UseFont = true;
            this.txtTotalP.Properties.EditFormat.FormatString = "C2";
            this.txtTotalP.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTotalP.Properties.ReadOnly = true;
            this.txtTotalP.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalP.Size = new System.Drawing.Size(100, 20);
            this.txtTotalP.TabIndex = 246;
            this.txtTotalP.Visible = false;
            // 
            // stpFactSelBeneficiarioClienteNTableAdapter
            // 
            this.stpFactSelBeneficiarioClienteNTableAdapter.ClearBeforeFill = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(656, 153);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 13);
            this.label18.TabIndex = 249;
            this.label18.Text = "Periodicidad:";
            // 
            // cbPeriodicidad
            // 
            this.cbPeriodicidad.Enabled = false;
            this.cbPeriodicidad.Location = new System.Drawing.Point(727, 150);
            this.cbPeriodicidad.Name = "cbPeriodicidad";
            this.cbPeriodicidad.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbPeriodicidad.Properties.DataSource = this.stpFactPeriodicidadBindingSource;
            this.cbPeriodicidad.Properties.DisplayMember = "DESC";
            this.cbPeriodicidad.Properties.NullText = "";
            this.cbPeriodicidad.Properties.ValueMember = "IdFactPeriodicidad";
            this.cbPeriodicidad.Properties.View = this.gridView17;
            this.cbPeriodicidad.Size = new System.Drawing.Size(91, 20);
            this.cbPeriodicidad.TabIndex = 248;
            this.cbPeriodicidad.Tag = "Producto";
            // 
            // stpFactPeriodicidadBindingSource
            // 
            this.stpFactPeriodicidadBindingSource.DataMember = "stpFactPeriodicidad";
            this.stpFactPeriodicidadBindingSource.DataSource = this.dbSAICBPOFactura;
            // 
            // gridView17
            // 
            this.gridView17.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn15,
            this.gridColumn16});
            this.gridView17.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView17.Name = "gridView17";
            this.gridView17.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView17.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "Periodicidad";
            this.gridColumn15.FieldName = "DESC";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 0;
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "gridColumn44";
            this.gridColumn16.FieldName = "IdFactPeriodicidad";
            this.gridColumn16.Name = "gridColumn16";
            // 
            // stpFactPeriodicidadTableAdapter
            // 
            this.stpFactPeriodicidadTableAdapter.ClearBeforeFill = true;
            // 
            // frmSolicitudFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 569);
            this.ControlBox = false;
            this.Controls.Add(this.label18);
            this.Controls.Add(this.cbPeriodicidad);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtTotalP);
            this.Controls.Add(this.txtTotalR);
            this.Controls.Add(this.txtIVAR);
            this.Controls.Add(this.txtSubtotalR);
            this.Controls.Add(this.lblFR1);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtRetencionIVA);
            this.Controls.Add(this.txtIVAPor);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtTotalISN);
            this.Controls.Add(this.txtTipoFactura);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cbFacturaRelacionRecibo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cbProducto);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cbCuentaOrigen);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cbUsoCFDI);
            this.Controls.Add(this.labelControl18);
            this.Controls.Add(this.txtCambio);
            this.Controls.Add(this.txtDeposito);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbBancoDestino);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbBancoOrigen);
            this.Controls.Add(this.labelControl19);
            this.Controls.Add(this.lblLoteCargaNomina);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.txtIVA);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtcargarArchivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtFechaPago);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grControlRelacionado);
            this.Controls.Add(this.lblTenedora);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.cbIdFronting);
            this.Controls.Add(this.cbTipoFacturador);
            this.Controls.Add(this.cbFormaPago);
            this.Controls.Add(this.cbIdTenedora);
            this.Controls.Add(this.cbMetodoPago);
            this.Controls.Add(this.cbMoneda);
            this.Controls.Add(this.cbTipoRelacion);
            this.Controls.Add(this.cbControl);
            this.Controls.Add(this.cboIdCliente);
            this.Controls.Add(this.cbFacturaRelacion);
            this.Name = "frmSolicitudFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Factura";
            this.Load += new System.EventHandler(this.frmSolicitudFactura_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grControlRelacionado)).EndInit();
            this.grControlRelacionado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvConceptos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcargarArchivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIVA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubtotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwcatFrontingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbIdFronting.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoFacturador.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelTipoBeneficiarioOperadorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFormaPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelObtenerFormaPagoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwFactCatFormaPagoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbIdTenedora.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelBeneficiarioTenedoraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMetodoPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwFactCatMetodoPagoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMoneda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCatMonedaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoRelacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelCatTipoRelacionv2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbControl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelControlOperacionesV2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFacturaRelacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelFacturasARelacionarSATBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboIdCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelBeneficiarioClienteNBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelDerechosAccesoFacturacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbBancoOrigen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelFrontingClienteBancoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbBancoDestino.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelFrontingClienteBanco1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDeposito.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCambio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUsoCFDI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelUsoCFDIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCuentaOrigen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelBeneficiarioBancoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbProducto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelProductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView15)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbFacturaRelacionRecibo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelFacturasARelacionarSAT1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalISN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIVAPor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRetencionIVA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOValidacionDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIVAR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubtotalR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPeriodicidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactPeriodicidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView17)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.ToolStripButton btnFacturar;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnConcepto;
        private System.Windows.Forms.DateTimePicker dtFechaPago;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.GroupControl grControlRelacionado;
        private System.Windows.Forms.Label lblLoteCargaNomina;
        private System.Windows.Forms.Label lblTenedora;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStripButton btRelacionar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.ButtonEdit txtcargarArchivo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripButton btnControl;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraEditors.TextEdit txtTotal;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtIVA;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtSubtotal;
        private DevExpress.XtraGrid.GridControl gvConceptos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colConcepto;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecio;
        private DevExpress.XtraGrid.Columns.GridColumn colImporte;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalIVA;
        private dbSAICBPOFactura dbSAICBPOFactura;
        private System.Windows.Forms.BindingSource vwcatFrontingBindingSource;
        private dbSAICBPOFacturaTableAdapters.vwcatFrontingTableAdapter vwcatFrontingTableAdapter;
        private DevExpress.XtraEditors.GridLookUpEdit cbIdFronting;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.GridLookUpEdit cbTipoFacturador;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.GridLookUpEdit cbFormaPago;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.GridLookUpEdit cbIdTenedora;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraEditors.GridLookUpEdit cbMetodoPago;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraEditors.GridLookUpEdit cbMoneda;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private DevExpress.XtraEditors.GridLookUpEdit cbTipoRelacion;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView7;
        private DevExpress.XtraEditors.GridLookUpEdit cbControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView8;
        private DevExpress.XtraEditors.GridLookUpEdit cbFacturaRelacion;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView9;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMatrizTenedora;
        private DevExpress.XtraGrid.Columns.GridColumn colRazonSocial;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreComercial;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFactTipoBeneficiario;
        private DevExpress.XtraGrid.Columns.GridColumn colDescTipoBeneficiario;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTenedora;
        private DevExpress.XtraGrid.Columns.GridColumn colRazonSocialT;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreComercialF;
        private DevExpress.XtraGrid.Columns.GridColumn colIdControlOperaciones;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colDescTipoPeriodoNomina;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaInicio;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaFin;
        private DevExpress.XtraGrid.Columns.GridColumn colSubtotalc;
        private DevExpress.XtraGrid.Columns.GridColumn colIVAC;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraEditors.GridLookUpEdit cboIdCliente;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView10;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMatrizCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colRazonSocialC;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreComercialC;
        private System.Windows.Forms.BindingSource vwFactCatFormaPagoBindingSource;
        private dbSAICBPOFacturaTableAdapters.vwFactCatFormaPagoTableAdapter vwFactCatFormaPagoTableAdapter;
        private System.Windows.Forms.BindingSource stpFactSelObtenerFormaPagoBindingSource;
        private dbSAICBPOFacturaTableAdapters.stpFactSelObtenerFormaPagoTableAdapter stpFactSelObtenerFormaPagoTableAdapter;
        private System.Windows.Forms.BindingSource vwFactCatMetodoPagoBindingSource;
        private dbSAICBPOFacturaTableAdapters.vwFactCatMetodoPagoTableAdapter vwFactCatMetodoPagoTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFactFormaPago;
        private DevExpress.XtraGrid.Columns.GridColumn colClaveFormaPagoc;
        private DevExpress.XtraGrid.Columns.GridColumn ColDescFormaPagoc;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFactMetodoPago;
        private DevExpress.XtraGrid.Columns.GridColumn colClaveFormaPago;
        private DevExpress.XtraGrid.Columns.GridColumn colDescFormaPago;
        private DevExpress.XtraEditors.SimpleButton btnEliminar;
        private DevExpress.XtraGrid.Columns.GridColumn coIdFactTipoRelacion;
        private DevExpress.XtraGrid.Columns.GridColumn colClaveTipoRelacion;
        private DevExpress.XtraGrid.Columns.GridColumn colDescTipoRelacion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMoneda;
        private DevExpress.XtraGrid.Columns.GridColumn colDescMonedaLarga;
        private DevExpress.XtraGrid.Columns.GridColumn colDescMoneda;
        private System.Windows.Forms.BindingSource stpFactSelBeneficiarioTenedoraBindingSource;
        private dbSAICBPOFacturaTableAdapters.stpFactSelBeneficiarioTenedoraTableAdapter stpFactSelBeneficiarioTenedoraTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colIVA;
        private DevExpress.XtraGrid.Columns.GridColumn colIdConcepto;
        private DevExpress.XtraGrid.Columns.GridColumn colPorIVA;
        private DevExpress.XtraGrid.Columns.GridColumn colRazonSocialCliente;
        private System.Windows.Forms.OpenFileDialog ofdComprobante;
        private System.Windows.Forms.BindingSource stpFactSelTipoBeneficiarioOperadorBindingSource;
        private System.Windows.Forms.BindingSource stpFactSelDerechosAccesoFacturacionBindingSource;
        private dbSAICBPOFacturaTableAdapters.stpFactSelDerechosAccesoFacturacionTableAdapter stpFactSelDerechosAccesoFacturacionTableAdapter;
        private dbSAICBPOFacturaTableAdapters.stpFactSelTipoBeneficiarioOperadorTableAdapter stpFactSelTipoBeneficiarioOperadorTableAdapter;
        public System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.GridLookUpEdit cbBancoOrigen;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView11;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreBanco;
        public System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.GridLookUpEdit cbBancoDestino;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView12;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBancoD;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreBancoD;
        private DevExpress.XtraGrid.Columns.GridColumn IdMatrizTenedora;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraGrid.Columns.GridColumn colConceptoPresentar;
        private dbSAICBPOCatalogosDataSet dbSAICBPOCatalogosDataSet;
        //private winAppSAIC.Catalogos.dbSAIC_CatalogosTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private dbSAICBPOFacturaTableAdapters.spSoloRespuesta spSoloRespuesta1;
        private DevExpress.XtraEditors.SpinEdit txtDeposito;
        private DevExpress.XtraEditors.SpinEdit txtCambio;
        private System.Windows.Forms.BindingSource stpFactSelFacturasARelacionarSATBindingSource;
        private dbSAICBPOFacturaTableAdapters.stpFactSelFacturasARelacionarSATTableAdapter stpFactSelFacturasARelacionarSATTableAdapter;
        private dbSAICBPOFacturaTableAdapters.stpFactSelHeaderFacturasModificarTableAdapter stpFactSelHeaderFacturasModificarTableAdapter1;
        private dbSAICBPOFacturaTableAdapters.stpFactSelDetailFacturasTableAdapter stpFactSelDetailFacturasTableAdapter1;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        public System.Windows.Forms.Label label14;
        private DevExpress.XtraEditors.GridLookUpEdit cbUsoCFDI;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView13;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsoCFDI;
        private DevExpress.XtraGrid.Columns.GridColumn colClave;
        private System.Windows.Forms.BindingSource vwCatMonedaBindingSource;
        private dbSAICBPOFacturaTableAdapters.vwCatMonedaTableAdapter vwCatMonedaTableAdapter;
        private System.Windows.Forms.BindingSource stpFactSelUsoCFDIBindingSource;
        private dbSAICBPOFacturaTableAdapters.stpFactSelUsoCFDITableAdapter stpFactSelUsoCFDITableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colIdHeaderFactura;
        private DevExpress.XtraGrid.Columns.GridColumn ColSerie;
        private DevExpress.XtraGrid.Columns.GridColumn ColFolioInterno;
        private DevExpress.XtraGrid.Columns.GridColumn ColDescMetodoPago;
        private DevExpress.XtraGrid.Columns.GridColumn ColDescFormadPago;
        private DevExpress.XtraGrid.Columns.GridColumn ColTotalF;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaGeneracionCFDI;
        private DevExpress.XtraGrid.Columns.GridColumn ColUUID;
        private dbSAICBPOFacturaTableAdapters.stpFactSelReporteFacturaPDFTableAdapter stpFactSelReporteFacturaPDFTableAdapter;
        public System.Windows.Forms.Label label15;
        private DevExpress.XtraEditors.GridLookUpEdit cbCuentaOrigen;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private System.Windows.Forms.Label label16;
        private DevExpress.XtraEditors.GridLookUpEdit cbProducto;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn43;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn44;
        private System.Windows.Forms.BindingSource stpFactSelProductoBindingSource;
        private dbSAICBPOFacturaTableAdapters.stpFactSelProductoTableAdapter stpFactSelProductoTableAdapter;
        private System.Windows.Forms.BindingSource stpFactSelControlOperacionesV2BindingSource;
        private dbSAICBPOFacturaTableAdapters.stpFactSelControlOperacionesV2TableAdapter stpFactSelControlOperacionesV2TableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colEstatus;
        private System.Windows.Forms.BindingSource stpFactSelCatTipoRelacionv2BindingSource;
        private dbSAICBPOFacturaTableAdapters.stpFactSelCatTipoRelacionv2TableAdapter stpFactSelCatTipoRelacionv2TableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripDropDownButton CBTipoFactura;
        private System.Windows.Forms.ToolStripMenuItem btnLimpia;
        private System.Windows.Forms.ToolStripMenuItem btnxAnticipo;
        private System.Windows.Forms.ToolStripMenuItem btnREP;
        private DevExpress.XtraEditors.GridLookUpEdit cbFacturaRelacionRecibo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox txtTipoFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colDescuento;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtTotalISN;
        private System.Windows.Forms.Label label17;
        private DevExpress.XtraEditors.SimpleButton btnActualizar;
        private System.Windows.Forms.BindingSource stpFactSelFacturasARelacionarSAT1BindingSource;
        private dbSAICBPOFacturaTableAdapters.stpFactSelFacturasARelacionarSAT1TableAdapter stpFactSelFacturasARelacionarSAT1TableAdapter;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashSMCargando;
        private DevExpress.XtraEditors.SpinEdit txtIVAPor;
        private dbSAICBPOFacturaTableAdapters.stpFactSelObtenerParametrosFrontingTableAdapter stpFactSelObtenerParametrosFrontingTableAdapter1;
        private System.Windows.Forms.BindingSource stpFactSelFrontingClienteBancoBindingSource;
        private dbSAICBPOFacturaTableAdapters.stpFactSelFrontingClienteBancoTableAdapter stpFactSelFrontingClienteBancoTableAdapter;
        private System.Windows.Forms.BindingSource stpFactSelFrontingClienteBanco1BindingSource;
        private System.Windows.Forms.BindingSource stpFactSelBeneficiarioBancoBindingSource;
        private dbSAICBPOFacturaTableAdapters.stpFactSelFrontingClienteBanco1TableAdapter stpFactSelFrontingClienteBanco1TableAdapter;
        private dbSAICBPOFacturaTableAdapters.stpFactSelBeneficiarioBancoTableAdapter stpFactSelBeneficiarioBancoTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colRetencionIVA;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtRetencionIVA;
        private dbSAICBPOValidacionDataSet dbSAICBPOValidacionDataSet1;
        private dbSAICBPOValidacionDataSetTableAdapters.stpSelParametroTableAdapter stpSelParametroTableAdapter1;
        private System.Windows.Forms.Label lblFR1;
        private DevExpress.XtraEditors.TextEdit txtTotalR;
        private DevExpress.XtraEditors.TextEdit txtIVAR;
        private DevExpress.XtraEditors.TextEdit txtSubtotalR;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtTotalP;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecioUnitarioCB;
        private DevExpress.XtraGrid.Columns.GridColumn colImporteCB;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalIVACB;
        private DevExpress.XtraGrid.Columns.GridColumn colImporteTotalCB;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private System.Windows.Forms.ToolStripMenuItem btnPublicoGeneral;
        private System.Windows.Forms.BindingSource stpFactSelBeneficiarioClienteNBindingSource;
        private dbSAICBPOFacturaTableAdapters.stpFactSelBeneficiarioClienteNTableAdapter stpFactSelBeneficiarioClienteNTableAdapter;
        private System.Windows.Forms.Label label18;
        private DevExpress.XtraEditors.GridLookUpEdit cbPeriodicidad;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private System.Windows.Forms.BindingSource stpFactPeriodicidadBindingSource;
        private dbSAICBPOFacturaTableAdapters.stpFactPeriodicidadTableAdapter stpFactPeriodicidadTableAdapter;
    }
}