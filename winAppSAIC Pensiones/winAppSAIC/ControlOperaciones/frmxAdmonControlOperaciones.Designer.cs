namespace winAppSAIC.ControlOperaciones
{
    partial class frmxAdmonControlOperaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmxAdmonControlOperaciones));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btnFacturar = new System.Windows.Forms.ToolStripButton();
            this.btnActualizar = new System.Windows.Forms.ToolStripButton();
            this.btnSolicitudCancelacion = new System.Windows.Forms.ToolStripButton();
            this.btnHabilitar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelarControl = new System.Windows.Forms.ToolStripButton();
            this.btnSolicitarPago = new System.Windows.Forms.ToolStripButton();
            this.btnVincular = new System.Windows.Forms.ToolStripButton();
            this.btnDesvincular = new System.Windows.Forms.ToolStripButton();
            this.btnDescargar = new System.Windows.Forms.ToolStripButton();
            this.btnCerrarC = new System.Windows.Forms.ToolStripButton();
            this.btnAbrirC = new System.Windows.Forms.ToolStripButton();
            this.btnPago = new System.Windows.Forms.ToolStripButton();
            this.btnPagoEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnAutControl = new System.Windows.Forms.ToolStripButton();
            this.btnEAutControl = new System.Windows.Forms.ToolStripButton();
            this.dbSAICBPOFactura = new winAppSAIC.Facturas.dbSAICBPOFactura();
            this.gdvLotes = new DevExpress.XtraEditors.GroupControl();
            this.dgvLotes = new DevExpress.XtraGrid.GridControl();
            this.stpFactSelDetailControlOperacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdControlOperacion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdLoteCargaNomina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFolioLoteCargaNomina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRazonSocial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTIPO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalNomina1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colISR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colISN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIMSSPatron = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIMSSObrero = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOSTOADICIONAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINFONAVIT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRECINFONAVIT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFONACOT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCuotasSindicales = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPensiónAlimenticia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFondoAhorro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrestamos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVales = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOtros = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPagarBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPercepciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTOTALDeducciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalEmpleados = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.stpFactSelFacturasControlBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdHeaderFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSolicitudFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdControlOperacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdFacturador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRFCFronting = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRazonSocialFronting = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLugarExpedicion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRegimenFiscal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdBeneficiario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoBeneficiario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescTipoBeneficiario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRFCCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRazonSocialBeneficiario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoComprobante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsoCFDI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsoCFDI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPorIVA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMetodoPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClaveMetodoPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescMetodoPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdFormaPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClaveFormaPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescFormaPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMoneda1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoCambio1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubTotal1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIVA1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalDepositado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstatusDocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdHeaderFacturaCFDI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSerie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFolioInterno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUUID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaGeneracionCFDI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescTipoRelacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdHeaderFacturaRelacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSerieInternoRelacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFolioInternoRelacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUUIDRelacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoRelacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClaveTipoRelacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaGeneracionCFDIRelacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstatus1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescEstatus1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComentarios = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdOperador1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreCompletoOperador1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaCreacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtTControl = new DevExpress.XtraEditors.TextEdit();
            this.txtTFacturas = new DevExpress.XtraEditors.TextEdit();
            this.txtSaldo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtMonto1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtMonto2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.txtMonto3 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.txtPeriodoPago = new DevExpress.XtraEditors.TextEdit();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.txtTipoNomina = new DevExpress.XtraEditors.TextEdit();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.txtFronting1 = new DevExpress.XtraEditors.TextEdit();
            this.txtBanco1 = new DevExpress.XtraEditors.TextEdit();
            this.txtBanco2 = new DevExpress.XtraEditors.TextEdit();
            this.txtFronting2 = new DevExpress.XtraEditors.TextEdit();
            this.txtBanco3 = new DevExpress.XtraEditors.TextEdit();
            this.txtFronting3 = new DevExpress.XtraEditors.TextEdit();
            this.txtOperador = new DevExpress.XtraEditors.TextEdit();
            this.txtCliente = new DevExpress.XtraEditors.TextEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdControlOperaciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBeneficiario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescTipoPeriodoNomina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubtotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIVA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaOperacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreCompletoOperador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaInicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaFin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRazonSocialSC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdFronting1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMontoOperacion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdBanco1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdFronting2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMontoOperacion2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdBanco2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdFronting3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMontoOperacion3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdBanco3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coIdTipoPeriodoNomina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTenedoraSC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalNomina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalAlimentos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalAsimilados = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalImpuestos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalObligaciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalComision = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalCAsimilados = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMoneda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoCambio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdOperador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRazonSocial1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRazonSocial2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRazonSocial3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreBanco1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreBanco2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreBanco3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRazonSocialCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescEstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreComercial1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreComercial2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreComercial3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreComercialSC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreComercialA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMesAno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbControl = new DevExpress.XtraEditors.GridLookUpEdit();
            this.stpFactSelControlOperacionesV2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwCatClienteTableAdapter = new winAppSAIC.dbSAICBPODataSetTableAdapters.vwCatClienteTableAdapter();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.stpFactSelDerechosAccesoOperadorFacturacionTableAdapter1 = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelDerechosAccesoOperadorFacturacionTableAdapter();
            this.txtMotivo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.txtEstatus = new DevExpress.XtraEditors.TextEdit();
            this.labelControl21 = new DevExpress.XtraEditors.LabelControl();
            this.splashSMCargando = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::winAppSAIC.frmxCargandoInformacion), true, true);
            this.spSoloRespuesta1 = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.spSoloRespuesta();
            this.stpFactSelFacturasControlTableAdapter = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelFacturasControlTableAdapter();
            this.stpFactSelDetailControlOperacionesTableAdapter = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelDetailControlOperacionesTableAdapter();
            this.txtSaldoToOperacion = new DevExpress.XtraEditors.TextEdit();
            this.txtToControlopera = new DevExpress.XtraEditors.TextEdit();
            this.txtToperacion = new DevExpress.XtraEditors.TextEdit();
            this.labelControl22 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl25 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl26 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl24 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl27 = new DevExpress.XtraEditors.LabelControl();
            this.cbControlRela = new DevExpress.XtraEditors.GridLookUpEdit();
            this.stpFactSelControlOperacionesRelaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdcontrolre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.stpFactSelControlOperacionesV2TableAdapter = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelControlOperacionesV2TableAdapter();
            this.stpFactSelControlOperacionesRelaTableAdapter = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelControlOperacionesRelaTableAdapter();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.labelControl29 = new DevExpress.XtraEditors.LabelControl();
            this.chkCierre = new DevExpress.XtraEditors.CheckEdit();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.btnEliminarFiltro = new DevExpress.XtraEditors.SimpleButton();
            this.btnFiltro = new DevExpress.XtraEditors.SimpleButton();
            this.dtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtFechaIni = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sidePanel2 = new DevExpress.XtraEditors.SidePanel();
            this.txtSaldoCli = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMesAno = new DevExpress.XtraEditors.TextEdit();
            this.txtFechas = new DevExpress.XtraEditors.TextEdit();
            this.labelControl35 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl23 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl34 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCOProductos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdControlOperaciones1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescTipoPeriodoNomina1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTenedora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRazonSocial4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreComercial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMonto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCBPO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chkPagado = new DevExpress.XtraEditors.CheckEdit();
            this.txtBanco5 = new DevExpress.XtraEditors.TextEdit();
            this.txtFronting5 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl28 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl33 = new DevExpress.XtraEditors.LabelControl();
            this.txtMonto5 = new DevExpress.XtraEditors.TextEdit();
            this.txtBanco4 = new DevExpress.XtraEditors.TextEdit();
            this.txtFronting4 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl40 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl41 = new DevExpress.XtraEditors.LabelControl();
            this.txtMonto4 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl42 = new DevExpress.XtraEditors.LabelControl();
            this.txtTotalCotrolD = new DevExpress.XtraEditors.TextEdit();
            this.labelControl39 = new DevExpress.XtraEditors.LabelControl();
            this.txtCambio = new DevExpress.XtraEditors.TextEdit();
            this.labelControl37 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl38 = new DevExpress.XtraEditors.LabelControl();
            this.txtMoneda = new DevExpress.XtraEditors.TextEdit();
            this.labelControl30 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl31 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl32 = new DevExpress.XtraEditors.LabelControl();
            this.txtTControl2 = new DevExpress.XtraEditors.TextEdit();
            this.txtTFacturasSaldo = new DevExpress.XtraEditors.TextEdit();
            this.txtSaldo2 = new DevExpress.XtraEditors.TextEdit();
            this.stpControlCerradoCountTableAdapter1 = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpControlCerradoCountTableAdapter();
            this.queriesAsimilados1 = new winAppSAIC.Asimilados.dbSAICAsimiladosTableAdapters.QueriesAsimilados();
            this.stpFactSelCOProductosControlBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stpFactSelCOProductosControlTableAdapter = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelCOProductosControlTableAdapter();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvLotes)).BeginInit();
            this.gdvLotes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelDetailControlOperacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelFacturasControlBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTControl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTFacturas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaldo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodoPago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoNomina.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFronting1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBanco1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBanco2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFronting2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBanco3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFronting3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOperador.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbControl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelControlOperacionesV2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMotivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaldoToOperacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToControlopera.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToperacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbControlRela.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelControlOperacionesRelaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCierre.Properties)).BeginInit();
            this.sidePanel1.SuspendLayout();
            this.sidePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaldoCli.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMesAno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFechas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPagado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBanco5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFronting5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBanco4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFronting4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalCotrolD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCambio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMoneda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTControl2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTFacturasSaldo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaldo2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelCOProductosControlBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.btnFacturar,
            this.btnActualizar,
            this.btnSolicitudCancelacion,
            this.btnHabilitar,
            this.btnCancelarControl,
            this.btnSolicitarPago,
            this.btnVincular,
            this.btnDesvincular,
            this.btnDescargar,
            this.btnCerrarC,
            this.btnAbrirC,
            this.btnPago,
            this.btnPagoEliminar,
            this.btnAutControl,
            this.btnEAutControl});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(801, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Black;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(53, 24);
            this.toolStripButton1.Text = "Salir";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnFacturar
            // 
            this.btnFacturar.Image = global::winAppSAIC.Properties.Resources.folder_add_256_icon_icons_com_75998;
            this.btnFacturar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(109, 24);
            this.btnFacturar.Text = "Nuevo Control";
            this.btnFacturar.ToolTipText = "Nuevo Control";
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Image = global::winAppSAIC.Properties.Resources.File_List_icon;
            this.btnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(83, 24);
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Visible = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSolicitudCancelacion
            // 
            this.btnSolicitudCancelacion.Image = global::winAppSAIC.Properties.Resources.Service_icon48x48;
            this.btnSolicitudCancelacion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSolicitudCancelacion.Name = "btnSolicitudCancelacion";
            this.btnSolicitudCancelacion.Size = new System.Drawing.Size(141, 24);
            this.btnSolicitudCancelacion.Text = "Solicitar Cancelación";
            this.btnSolicitudCancelacion.Visible = false;
            this.btnSolicitudCancelacion.Click += new System.EventHandler(this.btnSolicitudCancelacion_Click);
            // 
            // btnHabilitar
            // 
            this.btnHabilitar.Image = global::winAppSAIC.Properties.Resources.base_checkmark_32;
            this.btnHabilitar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHabilitar.Name = "btnHabilitar";
            this.btnHabilitar.Size = new System.Drawing.Size(76, 24);
            this.btnHabilitar.Text = "Habilitar";
            this.btnHabilitar.Visible = false;
            this.btnHabilitar.Click += new System.EventHandler(this.btnHabilitar_Click);
            // 
            // btnCancelarControl
            // 
            this.btnCancelarControl.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarControl.Image")));
            this.btnCancelarControl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelarControl.Name = "btnCancelarControl";
            this.btnCancelarControl.Size = new System.Drawing.Size(120, 24);
            this.btnCancelarControl.Text = "Cancelar Control";
            this.btnCancelarControl.Visible = false;
            this.btnCancelarControl.Click += new System.EventHandler(this.btnCancelarControl_Click);
            // 
            // btnSolicitarPago
            // 
            this.btnSolicitarPago.Image = global::winAppSAIC.Properties.Resources.coins_in_hand_icon32x32;
            this.btnSolicitarPago.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSolicitarPago.Name = "btnSolicitarPago";
            this.btnSolicitarPago.Size = new System.Drawing.Size(103, 24);
            this.btnSolicitarPago.Text = "Solicitar Pago";
            this.btnSolicitarPago.Visible = false;
            this.btnSolicitarPago.Click += new System.EventHandler(this.btnSolicitarPago_Click);
            // 
            // btnVincular
            // 
            this.btnVincular.Image = global::winAppSAIC.Properties.Resources.businesspackage_additionalpackage_box_add_insert_negoci_2335;
            this.btnVincular.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVincular.Name = "btnVincular";
            this.btnVincular.Size = new System.Drawing.Size(116, 24);
            this.btnVincular.Text = "Vincular Factura";
            this.btnVincular.Visible = false;
            this.btnVincular.Click += new System.EventHandler(this.btnVincular_Click);
            // 
            // btnDesvincular
            // 
            this.btnDesvincular.Image = ((System.Drawing.Image)(resources.GetObject("btnDesvincular.Image")));
            this.btnDesvincular.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDesvincular.Name = "btnDesvincular";
            this.btnDesvincular.Size = new System.Drawing.Size(139, 24);
            this.btnDesvincular.Text = "Desvincular Facturas";
            this.btnDesvincular.Visible = false;
            this.btnDesvincular.Click += new System.EventHandler(this.btnDesvincular_Click);
            // 
            // btnDescargar
            // 
            this.btnDescargar.Image = global::winAppSAIC.Properties.Resources.file_pdf_download_icon_icons_com_68954;
            this.btnDescargar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.Size = new System.Drawing.Size(126, 24);
            this.btnDescargar.Text = "Descargar Control";
            this.btnDescargar.Visible = false;
            this.btnDescargar.Click += new System.EventHandler(this.btnDescargar_Click);
            // 
            // btnCerrarC
            // 
            this.btnCerrarC.Image = global::winAppSAIC.Properties.Resources.cerrar;
            this.btnCerrarC.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCerrarC.Name = "btnCerrarC";
            this.btnCerrarC.Size = new System.Drawing.Size(106, 24);
            this.btnCerrarC.Text = "Cerrar Control";
            this.btnCerrarC.Visible = false;
            this.btnCerrarC.Click += new System.EventHandler(this.btnCerrarC_Click);
            // 
            // btnAbrirC
            // 
            this.btnAbrirC.Image = global::winAppSAIC.Properties.Resources.abrir;
            this.btnAbrirC.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAbrirC.Name = "btnAbrirC";
            this.btnAbrirC.Size = new System.Drawing.Size(100, 24);
            this.btnAbrirC.Text = "Abrir Control";
            this.btnAbrirC.Visible = false;
            this.btnAbrirC.Click += new System.EventHandler(this.btnAbrirC_Click);
            // 
            // btnPago
            // 
            this.btnPago.Image = global::winAppSAIC.Properties.Resources.payment_icon32x32;
            this.btnPago.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPago.Name = "btnPago";
            this.btnPago.Size = new System.Drawing.Size(101, 24);
            this.btnPago.Text = "Control Pago";
            this.btnPago.Visible = false;
            this.btnPago.Click += new System.EventHandler(this.btnPago_Click);
            // 
            // btnPagoEliminar
            // 
            this.btnPagoEliminar.Image = global::winAppSAIC.Properties.Resources.payment_icon32x32x;
            this.btnPagoEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPagoEliminar.Name = "btnPagoEliminar";
            this.btnPagoEliminar.Size = new System.Drawing.Size(129, 24);
            this.btnPagoEliminar.Text = "Eliminar Ctrl. Pago";
            this.btnPagoEliminar.Visible = false;
            this.btnPagoEliminar.Click += new System.EventHandler(this.btnPagoEliminar_Click);
            // 
            // btnAutControl
            // 
            this.btnAutControl.Image = global::winAppSAIC.Properties.Resources.AutorizarNominas32x32;
            this.btnAutControl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAutControl.Name = "btnAutControl";
            this.btnAutControl.Size = new System.Drawing.Size(122, 24);
            this.btnAutControl.Text = "Autorizar Control";
            this.btnAutControl.Visible = false;
            this.btnAutControl.Click += new System.EventHandler(this.btnAutControl_Click);
            // 
            // btnEAutControl
            // 
            this.btnEAutControl.Image = global::winAppSAIC.Properties.Resources.CancelApproval_32x32;
            this.btnEAutControl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEAutControl.Name = "btnEAutControl";
            this.btnEAutControl.Size = new System.Drawing.Size(147, 24);
            this.btnEAutControl.Text = "Cancelar Autorización";
            this.btnEAutControl.Visible = false;
            this.btnEAutControl.Click += new System.EventHandler(this.btnEAutControl_Click);
            // 
            // dbSAICBPOFactura
            // 
            this.dbSAICBPOFactura.DataSetName = "dbSAICBPOFactura";
            this.dbSAICBPOFactura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gdvLotes
            // 
            this.gdvLotes.Controls.Add(this.dgvLotes);
            this.gdvLotes.Location = new System.Drawing.Point(12, 385);
            this.gdvLotes.Name = "gdvLotes";
            this.gdvLotes.Size = new System.Drawing.Size(394, 108);
            this.gdvLotes.TabIndex = 35;
            this.gdvLotes.Text = "Lotes";
            // 
            // dgvLotes
            // 
            this.dgvLotes.DataSource = this.stpFactSelDetailControlOperacionesBindingSource;
            this.dgvLotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLotes.Location = new System.Drawing.Point(2, 20);
            this.dgvLotes.MainView = this.gridView1;
            this.dgvLotes.Name = "dgvLotes";
            this.dgvLotes.Size = new System.Drawing.Size(390, 86);
            this.dgvLotes.TabIndex = 36;
            this.dgvLotes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // stpFactSelDetailControlOperacionesBindingSource
            // 
            this.stpFactSelDetailControlOperacionesBindingSource.DataMember = "stpFactSelDetailControlOperaciones";
            this.stpFactSelDetailControlOperacionesBindingSource.DataSource = this.dbSAICBPOFactura;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdControlOperacion1,
            this.colIdLoteCargaNomina,
            this.colFolioLoteCargaNomina,
            this.colRazonSocial,
            this.colTIPO,
            this.colTotalNomina1,
            this.colISR,
            this.colISN,
            this.colIMSSPatron,
            this.colIMSSObrero,
            this.colCOSTOADICIONAL,
            this.colINFONAVIT,
            this.colRECINFONAVIT,
            this.colFONACOT,
            this.colCuotasSindicales,
            this.colPensiónAlimenticia,
            this.colFondoAhorro,
            this.colPrestamos,
            this.colVales,
            this.colOtros,
            this.colTotalPagarBanco,
            this.colTotalPercepciones,
            this.colTOTALDeducciones,
            this.colTotalEmpleados});
            this.gridView1.GridControl = this.dgvLotes;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIdControlOperacion1
            // 
            this.colIdControlOperacion1.FieldName = "IdControlOperacion";
            this.colIdControlOperacion1.Name = "colIdControlOperacion1";
            // 
            // colIdLoteCargaNomina
            // 
            this.colIdLoteCargaNomina.Caption = "Lote";
            this.colIdLoteCargaNomina.FieldName = "IdLoteCargaNomina";
            this.colIdLoteCargaNomina.Name = "colIdLoteCargaNomina";
            this.colIdLoteCargaNomina.Visible = true;
            this.colIdLoteCargaNomina.VisibleIndex = 0;
            // 
            // colFolioLoteCargaNomina
            // 
            this.colFolioLoteCargaNomina.Caption = "Folio";
            this.colFolioLoteCargaNomina.FieldName = "FolioLoteCargaNomina";
            this.colFolioLoteCargaNomina.Name = "colFolioLoteCargaNomina";
            this.colFolioLoteCargaNomina.Visible = true;
            this.colFolioLoteCargaNomina.VisibleIndex = 1;
            // 
            // colRazonSocial
            // 
            this.colRazonSocial.Caption = "Tenedora";
            this.colRazonSocial.FieldName = "RazonSocial";
            this.colRazonSocial.Name = "colRazonSocial";
            this.colRazonSocial.Visible = true;
            this.colRazonSocial.VisibleIndex = 2;
            // 
            // colTIPO
            // 
            this.colTIPO.Caption = "Tipo";
            this.colTIPO.FieldName = "TIPO";
            this.colTIPO.Name = "colTIPO";
            this.colTIPO.Visible = true;
            this.colTIPO.VisibleIndex = 3;
            // 
            // colTotalNomina1
            // 
            this.colTotalNomina1.Caption = "Total Nómina";
            this.colTotalNomina1.DisplayFormat.FormatString = "C2";
            this.colTotalNomina1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalNomina1.FieldName = "TotalNomina";
            this.colTotalNomina1.Name = "colTotalNomina1";
            this.colTotalNomina1.Visible = true;
            this.colTotalNomina1.VisibleIndex = 4;
            // 
            // colISR
            // 
            this.colISR.DisplayFormat.FormatString = "C2";
            this.colISR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colISR.FieldName = "ISR";
            this.colISR.Name = "colISR";
            this.colISR.Visible = true;
            this.colISR.VisibleIndex = 5;
            // 
            // colISN
            // 
            this.colISN.DisplayFormat.FormatString = "C2";
            this.colISN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colISN.FieldName = "ISN";
            this.colISN.Name = "colISN";
            this.colISN.Visible = true;
            this.colISN.VisibleIndex = 6;
            // 
            // colIMSSPatron
            // 
            this.colIMSSPatron.Caption = "IMSS Patrón";
            this.colIMSSPatron.DisplayFormat.FormatString = "C2";
            this.colIMSSPatron.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colIMSSPatron.FieldName = "IMSSPatron";
            this.colIMSSPatron.Name = "colIMSSPatron";
            this.colIMSSPatron.Visible = true;
            this.colIMSSPatron.VisibleIndex = 7;
            // 
            // colIMSSObrero
            // 
            this.colIMSSObrero.DisplayFormat.FormatString = "C2";
            this.colIMSSObrero.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colIMSSObrero.FieldName = "IMSSObrero";
            this.colIMSSObrero.Name = "colIMSSObrero";
            this.colIMSSObrero.Visible = true;
            this.colIMSSObrero.VisibleIndex = 8;
            // 
            // colCOSTOADICIONAL
            // 
            this.colCOSTOADICIONAL.Caption = "Costo Adicional";
            this.colCOSTOADICIONAL.DisplayFormat.FormatString = "C2";
            this.colCOSTOADICIONAL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCOSTOADICIONAL.FieldName = "COSTOADICIONAL";
            this.colCOSTOADICIONAL.Name = "colCOSTOADICIONAL";
            this.colCOSTOADICIONAL.Visible = true;
            this.colCOSTOADICIONAL.VisibleIndex = 9;
            // 
            // colINFONAVIT
            // 
            this.colINFONAVIT.DisplayFormat.FormatString = "C2";
            this.colINFONAVIT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colINFONAVIT.FieldName = "INFONAVIT";
            this.colINFONAVIT.Name = "colINFONAVIT";
            this.colINFONAVIT.Visible = true;
            this.colINFONAVIT.VisibleIndex = 10;
            // 
            // colRECINFONAVIT
            // 
            this.colRECINFONAVIT.Caption = "Rec. INFONAVIT";
            this.colRECINFONAVIT.DisplayFormat.FormatString = "C2";
            this.colRECINFONAVIT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colRECINFONAVIT.FieldName = "RECINFONAVIT";
            this.colRECINFONAVIT.Name = "colRECINFONAVIT";
            this.colRECINFONAVIT.Visible = true;
            this.colRECINFONAVIT.VisibleIndex = 11;
            // 
            // colFONACOT
            // 
            this.colFONACOT.DisplayFormat.FormatString = "C2";
            this.colFONACOT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colFONACOT.FieldName = "FONACOT";
            this.colFONACOT.Name = "colFONACOT";
            this.colFONACOT.Visible = true;
            this.colFONACOT.VisibleIndex = 12;
            // 
            // colCuotasSindicales
            // 
            this.colCuotasSindicales.DisplayFormat.FormatString = "C2";
            this.colCuotasSindicales.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCuotasSindicales.FieldName = "CuotasSindicales";
            this.colCuotasSindicales.Name = "colCuotasSindicales";
            this.colCuotasSindicales.Visible = true;
            this.colCuotasSindicales.VisibleIndex = 13;
            // 
            // colPensiónAlimenticia
            // 
            this.colPensiónAlimenticia.DisplayFormat.FormatString = "C2";
            this.colPensiónAlimenticia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPensiónAlimenticia.FieldName = "PensiónAlimenticia";
            this.colPensiónAlimenticia.Name = "colPensiónAlimenticia";
            this.colPensiónAlimenticia.Visible = true;
            this.colPensiónAlimenticia.VisibleIndex = 14;
            // 
            // colFondoAhorro
            // 
            this.colFondoAhorro.DisplayFormat.FormatString = "C2";
            this.colFondoAhorro.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colFondoAhorro.FieldName = "FondoAhorro";
            this.colFondoAhorro.Name = "colFondoAhorro";
            this.colFondoAhorro.Visible = true;
            this.colFondoAhorro.VisibleIndex = 15;
            // 
            // colPrestamos
            // 
            this.colPrestamos.DisplayFormat.FormatString = "C2";
            this.colPrestamos.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrestamos.FieldName = "Prestamos";
            this.colPrestamos.Name = "colPrestamos";
            this.colPrestamos.Visible = true;
            this.colPrestamos.VisibleIndex = 16;
            // 
            // colVales
            // 
            this.colVales.DisplayFormat.FormatString = "C2";
            this.colVales.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colVales.FieldName = "Vales";
            this.colVales.Name = "colVales";
            this.colVales.Visible = true;
            this.colVales.VisibleIndex = 17;
            // 
            // colOtros
            // 
            this.colOtros.DisplayFormat.FormatString = "C2";
            this.colOtros.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOtros.FieldName = "Otros";
            this.colOtros.Name = "colOtros";
            this.colOtros.Visible = true;
            this.colOtros.VisibleIndex = 18;
            // 
            // colTotalPagarBanco
            // 
            this.colTotalPagarBanco.DisplayFormat.FormatString = "C2";
            this.colTotalPagarBanco.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalPagarBanco.FieldName = "TotalPagarBanco";
            this.colTotalPagarBanco.Name = "colTotalPagarBanco";
            this.colTotalPagarBanco.Visible = true;
            this.colTotalPagarBanco.VisibleIndex = 19;
            // 
            // colTotalPercepciones
            // 
            this.colTotalPercepciones.DisplayFormat.FormatString = "C2";
            this.colTotalPercepciones.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalPercepciones.FieldName = "TotalPercepciones";
            this.colTotalPercepciones.Name = "colTotalPercepciones";
            this.colTotalPercepciones.Visible = true;
            this.colTotalPercepciones.VisibleIndex = 20;
            // 
            // colTOTALDeducciones
            // 
            this.colTOTALDeducciones.Caption = "Total Deducciones";
            this.colTOTALDeducciones.DisplayFormat.FormatString = "C2";
            this.colTOTALDeducciones.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTOTALDeducciones.FieldName = "TOTALDeducciones";
            this.colTOTALDeducciones.Name = "colTOTALDeducciones";
            this.colTOTALDeducciones.Visible = true;
            this.colTOTALDeducciones.VisibleIndex = 21;
            // 
            // colTotalEmpleados
            // 
            this.colTotalEmpleados.FieldName = "TotalEmpleados";
            this.colTotalEmpleados.Name = "colTotalEmpleados";
            this.colTotalEmpleados.Visible = true;
            this.colTotalEmpleados.VisibleIndex = 22;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(46, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(39, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Control:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(48, 54);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(37, 13);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Cliente:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(32, 76);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(53, 13);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Fronting 1:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(32, 98);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(53, 13);
            this.labelControl4.TabIndex = 12;
            this.labelControl4.Text = "Fronting 2:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(32, 120);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(53, 13);
            this.labelControl5.TabIndex = 14;
            this.labelControl5.Text = "Fronting 3:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Location = new System.Drawing.Point(412, 384);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(364, 109);
            this.groupControl1.TabIndex = 37;
            this.groupControl1.Text = "Facturas";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.stpFactSelFacturasControlBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 20);
            this.gridControl1.MainView = this.gridView2;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(360, 87);
            this.gridControl1.TabIndex = 38;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // stpFactSelFacturasControlBindingSource
            // 
            this.stpFactSelFacturasControlBindingSource.DataMember = "stpFactSelFacturasControl";
            this.stpFactSelFacturasControlBindingSource.DataSource = this.dbSAICBPOFactura;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdHeaderFactura,
            this.colIdSolicitudFactura,
            this.colIdControlOperacion,
            this.colIdFacturador,
            this.colRFCFronting,
            this.colRazonSocialFronting,
            this.colLugarExpedicion,
            this.colRegimenFiscal,
            this.colIdBeneficiario,
            this.colIdTipoBeneficiario,
            this.colDescTipoBeneficiario,
            this.colRFCCliente,
            this.colRazonSocialBeneficiario,
            this.colTipoComprobante,
            this.colIdTipoFactura,
            this.colIdUsoCFDI,
            this.colUsoCFDI,
            this.colPorIVA,
            this.colIdMetodoPago,
            this.colClaveMetodoPago,
            this.colDescMetodoPago,
            this.colIdFormaPago,
            this.colClaveFormaPago,
            this.colDescFormaPago,
            this.colIdMoneda1,
            this.colTipoCambio1,
            this.colFechaPago,
            this.colSubTotal1,
            this.colIVA1,
            this.colTotal1,
            this.colTotalDepositado,
            this.colEstatusDocumento,
            this.colIdHeaderFacturaCFDI,
            this.colSerie,
            this.colFolioInterno,
            this.colUUID,
            this.colFechaGeneracionCFDI,
            this.colDescTipoRelacion,
            this.colIdHeaderFacturaRelacion,
            this.colSerieInternoRelacion,
            this.colFolioInternoRelacion,
            this.colUUIDRelacion,
            this.colIdTipoRelacion,
            this.colClaveTipoRelacion,
            this.colFechaGeneracionCFDIRelacion,
            this.colIdEstatus1,
            this.colDescEstatus1,
            this.colComentarios,
            this.colIdOperador1,
            this.colNombreCompletoOperador1,
            this.colFechaCreacion});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colIdEstatus1, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colIdHeaderFactura
            // 
            this.colIdHeaderFactura.Caption = "Id Factura";
            this.colIdHeaderFactura.FieldName = "IdHeaderFactura";
            this.colIdHeaderFactura.Name = "colIdHeaderFactura";
            this.colIdHeaderFactura.Visible = true;
            this.colIdHeaderFactura.VisibleIndex = 0;
            // 
            // colIdSolicitudFactura
            // 
            this.colIdSolicitudFactura.Caption = "ID Solicitud";
            this.colIdSolicitudFactura.FieldName = "IdSolicitudFactura";
            this.colIdSolicitudFactura.Name = "colIdSolicitudFactura";
            this.colIdSolicitudFactura.Visible = true;
            this.colIdSolicitudFactura.VisibleIndex = 1;
            // 
            // colIdControlOperacion
            // 
            this.colIdControlOperacion.FieldName = "IdControlOperacion";
            this.colIdControlOperacion.Name = "colIdControlOperacion";
            // 
            // colIdFacturador
            // 
            this.colIdFacturador.FieldName = "IdFacturador";
            this.colIdFacturador.Name = "colIdFacturador";
            // 
            // colRFCFronting
            // 
            this.colRFCFronting.FieldName = "RFCFronting";
            this.colRFCFronting.Name = "colRFCFronting";
            // 
            // colRazonSocialFronting
            // 
            this.colRazonSocialFronting.Caption = "Fronting";
            this.colRazonSocialFronting.FieldName = "RazonSocialFronting";
            this.colRazonSocialFronting.Name = "colRazonSocialFronting";
            this.colRazonSocialFronting.Visible = true;
            this.colRazonSocialFronting.VisibleIndex = 2;
            this.colRazonSocialFronting.Width = 155;
            // 
            // colLugarExpedicion
            // 
            this.colLugarExpedicion.FieldName = "LugarExpedicion";
            this.colLugarExpedicion.Name = "colLugarExpedicion";
            // 
            // colRegimenFiscal
            // 
            this.colRegimenFiscal.FieldName = "RegimenFiscal";
            this.colRegimenFiscal.Name = "colRegimenFiscal";
            // 
            // colIdBeneficiario
            // 
            this.colIdBeneficiario.FieldName = "IdBeneficiario";
            this.colIdBeneficiario.Name = "colIdBeneficiario";
            // 
            // colIdTipoBeneficiario
            // 
            this.colIdTipoBeneficiario.FieldName = "IdTipoBeneficiario";
            this.colIdTipoBeneficiario.Name = "colIdTipoBeneficiario";
            // 
            // colDescTipoBeneficiario
            // 
            this.colDescTipoBeneficiario.Caption = "Tipo Beneficiario";
            this.colDescTipoBeneficiario.FieldName = "DescTipoBeneficiario";
            this.colDescTipoBeneficiario.Name = "colDescTipoBeneficiario";
            this.colDescTipoBeneficiario.Visible = true;
            this.colDescTipoBeneficiario.VisibleIndex = 3;
            this.colDescTipoBeneficiario.Width = 96;
            // 
            // colRFCCliente
            // 
            this.colRFCCliente.FieldName = "RFCCliente";
            this.colRFCCliente.Name = "colRFCCliente";
            // 
            // colRazonSocialBeneficiario
            // 
            this.colRazonSocialBeneficiario.Caption = "Baneficiario";
            this.colRazonSocialBeneficiario.FieldName = "RazonSocialBeneficiario";
            this.colRazonSocialBeneficiario.Name = "colRazonSocialBeneficiario";
            this.colRazonSocialBeneficiario.Visible = true;
            this.colRazonSocialBeneficiario.VisibleIndex = 4;
            this.colRazonSocialBeneficiario.Width = 191;
            // 
            // colTipoComprobante
            // 
            this.colTipoComprobante.Caption = "Tipo Comprobante";
            this.colTipoComprobante.FieldName = "TipoComprobante";
            this.colTipoComprobante.Name = "colTipoComprobante";
            this.colTipoComprobante.Visible = true;
            this.colTipoComprobante.VisibleIndex = 5;
            this.colTipoComprobante.Width = 107;
            // 
            // colIdTipoFactura
            // 
            this.colIdTipoFactura.FieldName = "IdTipoFactura";
            this.colIdTipoFactura.Name = "colIdTipoFactura";
            // 
            // colIdUsoCFDI
            // 
            this.colIdUsoCFDI.FieldName = "IdUsoCFDI";
            this.colIdUsoCFDI.Name = "colIdUsoCFDI";
            // 
            // colUsoCFDI
            // 
            this.colUsoCFDI.Caption = "Uso CFDI";
            this.colUsoCFDI.FieldName = "UsoCFDI";
            this.colUsoCFDI.Name = "colUsoCFDI";
            this.colUsoCFDI.Visible = true;
            this.colUsoCFDI.VisibleIndex = 6;
            this.colUsoCFDI.Width = 147;
            // 
            // colPorIVA
            // 
            this.colPorIVA.FieldName = "PorIVA";
            this.colPorIVA.Name = "colPorIVA";
            // 
            // colIdMetodoPago
            // 
            this.colIdMetodoPago.FieldName = "IdMetodoPago";
            this.colIdMetodoPago.Name = "colIdMetodoPago";
            // 
            // colClaveMetodoPago
            // 
            this.colClaveMetodoPago.Caption = "Metodo de Pago";
            this.colClaveMetodoPago.FieldName = "ClaveMetodoPago";
            this.colClaveMetodoPago.Name = "colClaveMetodoPago";
            this.colClaveMetodoPago.Visible = true;
            this.colClaveMetodoPago.VisibleIndex = 7;
            this.colClaveMetodoPago.Width = 88;
            // 
            // colDescMetodoPago
            // 
            this.colDescMetodoPago.FieldName = "DescMetodoPago";
            this.colDescMetodoPago.Name = "colDescMetodoPago";
            // 
            // colIdFormaPago
            // 
            this.colIdFormaPago.FieldName = "IdFormaPago";
            this.colIdFormaPago.Name = "colIdFormaPago";
            // 
            // colClaveFormaPago
            // 
            this.colClaveFormaPago.FieldName = "ClaveFormaPago";
            this.colClaveFormaPago.Name = "colClaveFormaPago";
            // 
            // colDescFormaPago
            // 
            this.colDescFormaPago.Caption = "Forma de Pago";
            this.colDescFormaPago.FieldName = "DescFormaPago";
            this.colDescFormaPago.Name = "colDescFormaPago";
            this.colDescFormaPago.Visible = true;
            this.colDescFormaPago.VisibleIndex = 9;
            this.colDescFormaPago.Width = 81;
            // 
            // colIdMoneda1
            // 
            this.colIdMoneda1.Caption = "Moneda";
            this.colIdMoneda1.FieldName = "IdMoneda";
            this.colIdMoneda1.Name = "colIdMoneda1";
            this.colIdMoneda1.Visible = true;
            this.colIdMoneda1.VisibleIndex = 8;
            this.colIdMoneda1.Width = 49;
            // 
            // colTipoCambio1
            // 
            this.colTipoCambio1.Caption = "Tipo de Cambio";
            this.colTipoCambio1.DisplayFormat.FormatString = "C2";
            this.colTipoCambio1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTipoCambio1.FieldName = "TipoCambio";
            this.colTipoCambio1.Name = "colTipoCambio1";
            this.colTipoCambio1.Visible = true;
            this.colTipoCambio1.VisibleIndex = 10;
            this.colTipoCambio1.Width = 69;
            // 
            // colFechaPago
            // 
            this.colFechaPago.Caption = "Fecha Pago";
            this.colFechaPago.FieldName = "FechaPago";
            this.colFechaPago.Name = "colFechaPago";
            this.colFechaPago.Visible = true;
            this.colFechaPago.VisibleIndex = 11;
            this.colFechaPago.Width = 99;
            // 
            // colSubTotal1
            // 
            this.colSubTotal1.Caption = "Sub-total";
            this.colSubTotal1.DisplayFormat.FormatString = "C2";
            this.colSubTotal1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSubTotal1.FieldName = "SubTotal";
            this.colSubTotal1.Name = "colSubTotal1";
            this.colSubTotal1.Visible = true;
            this.colSubTotal1.VisibleIndex = 12;
            // 
            // colIVA1
            // 
            this.colIVA1.Caption = "I.V.A";
            this.colIVA1.DisplayFormat.FormatString = "C2";
            this.colIVA1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colIVA1.FieldName = "IVA";
            this.colIVA1.Name = "colIVA1";
            this.colIVA1.Visible = true;
            this.colIVA1.VisibleIndex = 13;
            // 
            // colTotal1
            // 
            this.colTotal1.Caption = "Total";
            this.colTotal1.DisplayFormat.FormatString = "C2";
            this.colTotal1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotal1.FieldName = "Total";
            this.colTotal1.Name = "colTotal1";
            this.colTotal1.Visible = true;
            this.colTotal1.VisibleIndex = 14;
            // 
            // colTotalDepositado
            // 
            this.colTotalDepositado.Caption = "Total Depositado";
            this.colTotalDepositado.DisplayFormat.FormatString = "C2";
            this.colTotalDepositado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalDepositado.FieldName = "TotalDepositado";
            this.colTotalDepositado.Name = "colTotalDepositado";
            this.colTotalDepositado.Visible = true;
            this.colTotalDepositado.VisibleIndex = 15;
            this.colTotalDepositado.Width = 108;
            // 
            // colEstatusDocumento
            // 
            this.colEstatusDocumento.Caption = "Estatus Timbrado";
            this.colEstatusDocumento.FieldName = "EstatusDocumento";
            this.colEstatusDocumento.Name = "colEstatusDocumento";
            this.colEstatusDocumento.Visible = true;
            this.colEstatusDocumento.VisibleIndex = 16;
            this.colEstatusDocumento.Width = 129;
            // 
            // colIdHeaderFacturaCFDI
            // 
            this.colIdHeaderFacturaCFDI.FieldName = "IdHeaderFacturaCFDI";
            this.colIdHeaderFacturaCFDI.Name = "colIdHeaderFacturaCFDI";
            // 
            // colSerie
            // 
            this.colSerie.FieldName = "Serie";
            this.colSerie.Name = "colSerie";
            this.colSerie.Visible = true;
            this.colSerie.VisibleIndex = 17;
            this.colSerie.Width = 71;
            // 
            // colFolioInterno
            // 
            this.colFolioInterno.Caption = "Folio Interno";
            this.colFolioInterno.FieldName = "FolioInterno";
            this.colFolioInterno.Name = "colFolioInterno";
            this.colFolioInterno.Visible = true;
            this.colFolioInterno.VisibleIndex = 18;
            // 
            // colUUID
            // 
            this.colUUID.FieldName = "UUID";
            this.colUUID.Name = "colUUID";
            this.colUUID.Visible = true;
            this.colUUID.VisibleIndex = 19;
            this.colUUID.Width = 154;
            // 
            // colFechaGeneracionCFDI
            // 
            this.colFechaGeneracionCFDI.Caption = "Fecha Timbrado";
            this.colFechaGeneracionCFDI.DisplayFormat.FormatString = "d";
            this.colFechaGeneracionCFDI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colFechaGeneracionCFDI.FieldName = "FechaGeneracionCFDI";
            this.colFechaGeneracionCFDI.Name = "colFechaGeneracionCFDI";
            this.colFechaGeneracionCFDI.Visible = true;
            this.colFechaGeneracionCFDI.VisibleIndex = 20;
            this.colFechaGeneracionCFDI.Width = 102;
            // 
            // colDescTipoRelacion
            // 
            this.colDescTipoRelacion.Caption = "Desc. Relación";
            this.colDescTipoRelacion.FieldName = "DescTipoRelacion";
            this.colDescTipoRelacion.Name = "colDescTipoRelacion";
            this.colDescTipoRelacion.Visible = true;
            this.colDescTipoRelacion.VisibleIndex = 21;
            this.colDescTipoRelacion.Width = 176;
            // 
            // colIdHeaderFacturaRelacion
            // 
            this.colIdHeaderFacturaRelacion.FieldName = "IdHeaderFacturaRelacion";
            this.colIdHeaderFacturaRelacion.Name = "colIdHeaderFacturaRelacion";
            // 
            // colSerieInternoRelacion
            // 
            this.colSerieInternoRelacion.Caption = "Serie Relación";
            this.colSerieInternoRelacion.FieldName = "SerieInternoRelacion";
            this.colSerieInternoRelacion.Name = "colSerieInternoRelacion";
            this.colSerieInternoRelacion.Visible = true;
            this.colSerieInternoRelacion.VisibleIndex = 23;
            // 
            // colFolioInternoRelacion
            // 
            this.colFolioInternoRelacion.Caption = "Folio Relación";
            this.colFolioInternoRelacion.FieldName = "FolioInternoRelacion";
            this.colFolioInternoRelacion.Name = "colFolioInternoRelacion";
            this.colFolioInternoRelacion.Visible = true;
            this.colFolioInternoRelacion.VisibleIndex = 24;
            this.colFolioInternoRelacion.Width = 79;
            // 
            // colUUIDRelacion
            // 
            this.colUUIDRelacion.Caption = "UUID Relación";
            this.colUUIDRelacion.FieldName = "UUIDRelacion";
            this.colUUIDRelacion.Name = "colUUIDRelacion";
            this.colUUIDRelacion.Visible = true;
            this.colUUIDRelacion.VisibleIndex = 22;
            this.colUUIDRelacion.Width = 185;
            // 
            // colIdTipoRelacion
            // 
            this.colIdTipoRelacion.FieldName = "IdTipoRelacion";
            this.colIdTipoRelacion.Name = "colIdTipoRelacion";
            // 
            // colClaveTipoRelacion
            // 
            this.colClaveTipoRelacion.FieldName = "ClaveTipoRelacion";
            this.colClaveTipoRelacion.Name = "colClaveTipoRelacion";
            // 
            // colFechaGeneracionCFDIRelacion
            // 
            this.colFechaGeneracionCFDIRelacion.Caption = "Fecha Timbrado Relación";
            this.colFechaGeneracionCFDIRelacion.FieldName = "FechaGeneracionCFDIRelacion";
            this.colFechaGeneracionCFDIRelacion.Name = "colFechaGeneracionCFDIRelacion";
            this.colFechaGeneracionCFDIRelacion.Visible = true;
            this.colFechaGeneracionCFDIRelacion.VisibleIndex = 25;
            this.colFechaGeneracionCFDIRelacion.Width = 132;
            // 
            // colIdEstatus1
            // 
            this.colIdEstatus1.FieldName = "IdEstatus";
            this.colIdEstatus1.Name = "colIdEstatus1";
            // 
            // colDescEstatus1
            // 
            this.colDescEstatus1.Caption = "Estatus";
            this.colDescEstatus1.FieldName = "DescEstatus";
            this.colDescEstatus1.Name = "colDescEstatus1";
            this.colDescEstatus1.Visible = true;
            this.colDescEstatus1.VisibleIndex = 26;
            // 
            // colComentarios
            // 
            this.colComentarios.Caption = "Comentarios";
            this.colComentarios.FieldName = "Comentarios";
            this.colComentarios.Name = "colComentarios";
            this.colComentarios.Visible = true;
            this.colComentarios.VisibleIndex = 27;
            this.colComentarios.Width = 217;
            // 
            // colIdOperador1
            // 
            this.colIdOperador1.FieldName = "IdOperador";
            this.colIdOperador1.Name = "colIdOperador1";
            // 
            // colNombreCompletoOperador1
            // 
            this.colNombreCompletoOperador1.Caption = "Operador";
            this.colNombreCompletoOperador1.FieldName = "NombreCompletoOperador";
            this.colNombreCompletoOperador1.Name = "colNombreCompletoOperador1";
            this.colNombreCompletoOperador1.Visible = true;
            this.colNombreCompletoOperador1.VisibleIndex = 28;
            this.colNombreCompletoOperador1.Width = 245;
            // 
            // colFechaCreacion
            // 
            this.colFechaCreacion.FieldName = "FechaCreacion";
            this.colFechaCreacion.Name = "colFechaCreacion";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(417, 499);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(66, 13);
            this.labelControl6.TabIndex = 16;
            this.labelControl6.Text = "Total Control:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(415, 520);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(68, 13);
            this.labelControl7.TabIndex = 17;
            this.labelControl7.Text = "Total Factura:";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(455, 541);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(30, 13);
            this.labelControl8.TabIndex = 18;
            this.labelControl8.Text = "Saldo:";
            // 
            // txtTControl
            // 
            this.txtTControl.Location = new System.Drawing.Point(484, 496);
            this.txtTControl.Name = "txtTControl";
            this.txtTControl.Properties.DisplayFormat.FormatString = "C2";
            this.txtTControl.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTControl.Properties.EditFormat.FormatString = "C2";
            this.txtTControl.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTControl.Properties.ReadOnly = true;
            this.txtTControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTControl.Size = new System.Drawing.Size(109, 20);
            this.txtTControl.TabIndex = 42;
            // 
            // txtTFacturas
            // 
            this.txtTFacturas.Location = new System.Drawing.Point(484, 517);
            this.txtTFacturas.Name = "txtTFacturas";
            this.txtTFacturas.Properties.DisplayFormat.FormatString = "C2";
            this.txtTFacturas.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTFacturas.Properties.EditFormat.FormatString = "C2";
            this.txtTFacturas.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTFacturas.Properties.ReadOnly = true;
            this.txtTFacturas.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTFacturas.Size = new System.Drawing.Size(109, 20);
            this.txtTFacturas.TabIndex = 43;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(484, 538);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Properties.DisplayFormat.FormatString = "C2";
            this.txtSaldo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSaldo.Properties.EditFormat.FormatString = "C2";
            this.txtSaldo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSaldo.Properties.ReadOnly = true;
            this.txtSaldo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSaldo.Size = new System.Drawing.Size(109, 20);
            this.txtSaldo.TabIndex = 44;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(38, 283);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(50, 13);
            this.labelControl9.TabIndex = 23;
            this.labelControl9.Text = "Operador:";
            // 
            // txtMonto1
            // 
            this.txtMonto1.Location = new System.Drawing.Point(507, 73);
            this.txtMonto1.Name = "txtMonto1";
            this.txtMonto1.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtMonto1.Properties.Appearance.Options.UseBackColor = true;
            this.txtMonto1.Properties.DisplayFormat.FormatString = "C2";
            this.txtMonto1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtMonto1.Properties.EditFormat.FormatString = "C2";
            this.txtMonto1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtMonto1.Properties.ReadOnly = true;
            this.txtMonto1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMonto1.Size = new System.Drawing.Size(116, 20);
            this.txtMonto1.TabIndex = 6;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(467, 76);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(34, 13);
            this.labelControl10.TabIndex = 25;
            this.labelControl10.Text = "Monto:";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(467, 98);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(34, 13);
            this.labelControl11.TabIndex = 27;
            this.labelControl11.Text = "Monto:";
            // 
            // txtMonto2
            // 
            this.txtMonto2.Location = new System.Drawing.Point(507, 95);
            this.txtMonto2.Name = "txtMonto2";
            this.txtMonto2.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtMonto2.Properties.Appearance.Options.UseBackColor = true;
            this.txtMonto2.Properties.DisplayFormat.FormatString = "C2";
            this.txtMonto2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtMonto2.Properties.EditFormat.FormatString = "C2";
            this.txtMonto2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtMonto2.Properties.ReadOnly = true;
            this.txtMonto2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMonto2.Size = new System.Drawing.Size(116, 20);
            this.txtMonto2.TabIndex = 9;
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(467, 120);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(34, 13);
            this.labelControl12.TabIndex = 29;
            this.labelControl12.Text = "Monto:";
            // 
            // txtMonto3
            // 
            this.txtMonto3.Location = new System.Drawing.Point(507, 117);
            this.txtMonto3.Name = "txtMonto3";
            this.txtMonto3.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtMonto3.Properties.Appearance.Options.UseBackColor = true;
            this.txtMonto3.Properties.DisplayFormat.FormatString = "C2";
            this.txtMonto3.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtMonto3.Properties.EditFormat.FormatString = "C2";
            this.txtMonto3.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtMonto3.Properties.ReadOnly = true;
            this.txtMonto3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMonto3.Size = new System.Drawing.Size(116, 20);
            this.txtMonto3.TabIndex = 12;
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(637, 76);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(33, 13);
            this.labelControl13.TabIndex = 31;
            this.labelControl13.Text = "Banco:";
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(637, 98);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(33, 13);
            this.labelControl14.TabIndex = 33;
            this.labelControl14.Text = "Banco:";
            // 
            // labelControl15
            // 
            this.labelControl15.Location = new System.Drawing.Point(637, 120);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(33, 13);
            this.labelControl15.TabIndex = 35;
            this.labelControl15.Text = "Banco:";
            // 
            // txtPeriodoPago
            // 
            this.txtPeriodoPago.Location = new System.Drawing.Point(278, 258);
            this.txtPeriodoPago.Name = "txtPeriodoPago";
            this.txtPeriodoPago.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtPeriodoPago.Properties.Appearance.Options.UseBackColor = true;
            this.txtPeriodoPago.Properties.ReadOnly = true;
            this.txtPeriodoPago.Size = new System.Drawing.Size(178, 20);
            this.txtPeriodoPago.TabIndex = 27;
            this.txtPeriodoPago.TabStop = false;
            // 
            // labelControl17
            // 
            this.labelControl17.Location = new System.Drawing.Point(232, 261);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(40, 13);
            this.labelControl17.TabIndex = 38;
            this.labelControl17.Text = "Periodo:";
            // 
            // txtTipoNomina
            // 
            this.txtTipoNomina.Location = new System.Drawing.Point(91, 258);
            this.txtTipoNomina.Name = "txtTipoNomina";
            this.txtTipoNomina.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtTipoNomina.Properties.Appearance.Options.UseBackColor = true;
            this.txtTipoNomina.Properties.ReadOnly = true;
            this.txtTipoNomina.Size = new System.Drawing.Size(116, 20);
            this.txtTipoNomina.TabIndex = 26;
            this.txtTipoNomina.TabStop = false;
            // 
            // labelControl16
            // 
            this.labelControl16.Location = new System.Drawing.Point(26, 261);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(62, 13);
            this.labelControl16.TabIndex = 40;
            this.labelControl16.Text = "Tipo Nómina:";
            // 
            // txtFronting1
            // 
            this.txtFronting1.Location = new System.Drawing.Point(88, 73);
            this.txtFronting1.Name = "txtFronting1";
            this.txtFronting1.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtFronting1.Properties.Appearance.Options.UseBackColor = true;
            this.txtFronting1.Properties.ReadOnly = true;
            this.txtFronting1.Size = new System.Drawing.Size(365, 20);
            this.txtFronting1.TabIndex = 5;
            this.txtFronting1.TabStop = false;
            // 
            // txtBanco1
            // 
            this.txtBanco1.Location = new System.Drawing.Point(676, 73);
            this.txtBanco1.Name = "txtBanco1";
            this.txtBanco1.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtBanco1.Properties.Appearance.Options.UseBackColor = true;
            this.txtBanco1.Properties.ReadOnly = true;
            this.txtBanco1.Size = new System.Drawing.Size(100, 20);
            this.txtBanco1.TabIndex = 7;
            this.txtBanco1.TabStop = false;
            // 
            // txtBanco2
            // 
            this.txtBanco2.Location = new System.Drawing.Point(676, 95);
            this.txtBanco2.Name = "txtBanco2";
            this.txtBanco2.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtBanco2.Properties.Appearance.Options.UseBackColor = true;
            this.txtBanco2.Properties.ReadOnly = true;
            this.txtBanco2.Size = new System.Drawing.Size(100, 20);
            this.txtBanco2.TabIndex = 10;
            this.txtBanco2.TabStop = false;
            // 
            // txtFronting2
            // 
            this.txtFronting2.Location = new System.Drawing.Point(88, 95);
            this.txtFronting2.Name = "txtFronting2";
            this.txtFronting2.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtFronting2.Properties.Appearance.Options.UseBackColor = true;
            this.txtFronting2.Properties.ReadOnly = true;
            this.txtFronting2.Size = new System.Drawing.Size(365, 20);
            this.txtFronting2.TabIndex = 8;
            this.txtFronting2.TabStop = false;
            // 
            // txtBanco3
            // 
            this.txtBanco3.Location = new System.Drawing.Point(676, 117);
            this.txtBanco3.Name = "txtBanco3";
            this.txtBanco3.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtBanco3.Properties.Appearance.Options.UseBackColor = true;
            this.txtBanco3.Properties.ReadOnly = true;
            this.txtBanco3.Size = new System.Drawing.Size(100, 20);
            this.txtBanco3.TabIndex = 13;
            this.txtBanco3.TabStop = false;
            // 
            // txtFronting3
            // 
            this.txtFronting3.Location = new System.Drawing.Point(88, 117);
            this.txtFronting3.Name = "txtFronting3";
            this.txtFronting3.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtFronting3.Properties.Appearance.Options.UseBackColor = true;
            this.txtFronting3.Properties.ReadOnly = true;
            this.txtFronting3.Size = new System.Drawing.Size(365, 20);
            this.txtFronting3.TabIndex = 11;
            this.txtFronting3.TabStop = false;
            // 
            // txtOperador
            // 
            this.txtOperador.Location = new System.Drawing.Point(91, 280);
            this.txtOperador.Name = "txtOperador";
            this.txtOperador.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtOperador.Properties.Appearance.Options.UseBackColor = true;
            this.txtOperador.Properties.ReadOnly = true;
            this.txtOperador.Size = new System.Drawing.Size(365, 20);
            this.txtOperador.TabIndex = 29;
            this.txtOperador.TabStop = false;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(88, 51);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtCliente.Properties.Appearance.Options.UseBackColor = true;
            this.txtCliente.Properties.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(535, 20);
            this.txtCliente.TabIndex = 4;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdControlOperaciones,
            this.colBeneficiario,
            this.colDescripcion,
            this.colDescTipoPeriodoNomina,
            this.colSubtotal,
            this.colIVA,
            this.colTotal,
            this.colFechaOperacion,
            this.colNombreCompletoOperador,
            this.colFechaInicio,
            this.colFechaFin,
            this.colRazonSocialSC,
            this.colIdCliente,
            this.colIdFronting1,
            this.colMontoOperacion1,
            this.colIdBanco1,
            this.colIdFronting2,
            this.colMontoOperacion2,
            this.colIdBanco2,
            this.colIdFronting3,
            this.colMontoOperacion3,
            this.colIdBanco3,
            this.coIdTipoPeriodoNomina,
            this.colIdTenedoraSC,
            this.colTotalNomina,
            this.colTotalAlimentos,
            this.colTotalAsimilados,
            this.colTotalImpuestos,
            this.colTotalObligaciones,
            this.colTotalComision,
            this.colTotalCAsimilados,
            this.colIdMoneda,
            this.colTipoCambio,
            this.colIdEstatus,
            this.colIdOperador,
            this.colRazonSocial1,
            this.colRazonSocial2,
            this.colRazonSocial3,
            this.colNombreBanco1,
            this.colNombreBanco2,
            this.colNombreBanco3,
            this.colRazonSocialCliente,
            this.colDescEstatus,
            this.colNombreComercial1,
            this.colNombreComercial2,
            this.colNombreComercial3,
            this.colNombreComercialSC,
            this.colNombreComercialA,
            this.colMesAno});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ColumnAutoWidth = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            this.gridLookUpEdit1View.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colIdControlOperaciones, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colIdControlOperaciones
            // 
            this.colIdControlOperaciones.Caption = "Id Control";
            this.colIdControlOperaciones.FieldName = "IdControlOperaciones";
            this.colIdControlOperaciones.Name = "colIdControlOperaciones";
            this.colIdControlOperaciones.Visible = true;
            this.colIdControlOperaciones.VisibleIndex = 0;
            this.colIdControlOperaciones.Width = 56;
            // 
            // colBeneficiario
            // 
            this.colBeneficiario.Caption = "Cliente";
            this.colBeneficiario.FieldName = "NombrecomercialBeneficiario";
            this.colBeneficiario.Name = "colBeneficiario";
            this.colBeneficiario.Visible = true;
            this.colBeneficiario.VisibleIndex = 1;
            this.colBeneficiario.Width = 281;
            // 
            // colDescripcion
            // 
            this.colDescripcion.Caption = "Descripción";
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 10;
            this.colDescripcion.Width = 243;
            // 
            // colDescTipoPeriodoNomina
            // 
            this.colDescTipoPeriodoNomina.Caption = "Periodo";
            this.colDescTipoPeriodoNomina.FieldName = "DescTipoPeriodoNomina";
            this.colDescTipoPeriodoNomina.Name = "colDescTipoPeriodoNomina";
            this.colDescTipoPeriodoNomina.Visible = true;
            this.colDescTipoPeriodoNomina.VisibleIndex = 4;
            this.colDescTipoPeriodoNomina.Width = 132;
            // 
            // colSubtotal
            // 
            this.colSubtotal.Caption = "Subtotal";
            this.colSubtotal.DisplayFormat.FormatString = "C2";
            this.colSubtotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSubtotal.FieldName = "Subtotal";
            this.colSubtotal.Name = "colSubtotal";
            this.colSubtotal.Visible = true;
            this.colSubtotal.VisibleIndex = 5;
            this.colSubtotal.Width = 98;
            // 
            // colIVA
            // 
            this.colIVA.Caption = "IVA";
            this.colIVA.DisplayFormat.FormatString = "C2";
            this.colIVA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colIVA.FieldName = "IVA";
            this.colIVA.Name = "colIVA";
            this.colIVA.Visible = true;
            this.colIVA.VisibleIndex = 6;
            this.colIVA.Width = 117;
            // 
            // colTotal
            // 
            this.colTotal.Caption = "Total";
            this.colTotal.DisplayFormat.FormatString = "C2";
            this.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotal.FieldName = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 7;
            this.colTotal.Width = 110;
            // 
            // colFechaOperacion
            // 
            this.colFechaOperacion.Caption = "Fecha Operacion";
            this.colFechaOperacion.FieldName = "FechaOperacion";
            this.colFechaOperacion.Name = "colFechaOperacion";
            this.colFechaOperacion.Visible = true;
            this.colFechaOperacion.VisibleIndex = 8;
            this.colFechaOperacion.Width = 107;
            // 
            // colNombreCompletoOperador
            // 
            this.colNombreCompletoOperador.Caption = "Operador";
            this.colNombreCompletoOperador.FieldName = "NombreCompletoOperador";
            this.colNombreCompletoOperador.Name = "colNombreCompletoOperador";
            this.colNombreCompletoOperador.Visible = true;
            this.colNombreCompletoOperador.VisibleIndex = 9;
            this.colNombreCompletoOperador.Width = 242;
            // 
            // colFechaInicio
            // 
            this.colFechaInicio.Caption = "FechaInicio";
            this.colFechaInicio.FieldName = "FechaInicio";
            this.colFechaInicio.Name = "colFechaInicio";
            // 
            // colFechaFin
            // 
            this.colFechaFin.Caption = "FechaFin";
            this.colFechaFin.FieldName = "FechaFin";
            this.colFechaFin.Name = "colFechaFin";
            // 
            // colRazonSocialSC
            // 
            this.colRazonSocialSC.Caption = "RazonSocialSC";
            this.colRazonSocialSC.FieldName = "RazonSocialSC";
            this.colRazonSocialSC.Name = "colRazonSocialSC";
            // 
            // colIdCliente
            // 
            this.colIdCliente.Caption = "IdCliente";
            this.colIdCliente.FieldName = "IdCliente";
            this.colIdCliente.Name = "colIdCliente";
            // 
            // colIdFronting1
            // 
            this.colIdFronting1.Caption = "IdFronting1";
            this.colIdFronting1.FieldName = "IdFronting1";
            this.colIdFronting1.Name = "colIdFronting1";
            // 
            // colMontoOperacion1
            // 
            this.colMontoOperacion1.Caption = "MontoOperacion1";
            this.colMontoOperacion1.FieldName = "MontoOperacion1";
            this.colMontoOperacion1.Name = "colMontoOperacion1";
            // 
            // colIdBanco1
            // 
            this.colIdBanco1.Caption = "IdBanco1";
            this.colIdBanco1.FieldName = "IdBanco1";
            this.colIdBanco1.Name = "colIdBanco1";
            // 
            // colIdFronting2
            // 
            this.colIdFronting2.Caption = "IdFronting2";
            this.colIdFronting2.FieldName = "IdFronting2";
            this.colIdFronting2.Name = "colIdFronting2";
            // 
            // colMontoOperacion2
            // 
            this.colMontoOperacion2.Caption = "MontoOperacion2";
            this.colMontoOperacion2.FieldName = "MontoOperacion2";
            this.colMontoOperacion2.Name = "colMontoOperacion2";
            // 
            // colIdBanco2
            // 
            this.colIdBanco2.Caption = "IdBanco2";
            this.colIdBanco2.FieldName = "IdBanco2";
            this.colIdBanco2.Name = "colIdBanco2";
            // 
            // colIdFronting3
            // 
            this.colIdFronting3.Caption = "IdFronting3";
            this.colIdFronting3.FieldName = "IdFronting3";
            this.colIdFronting3.Name = "colIdFronting3";
            // 
            // colMontoOperacion3
            // 
            this.colMontoOperacion3.Caption = "MontoOperacion3";
            this.colMontoOperacion3.FieldName = "MontoOperacion3";
            this.colMontoOperacion3.Name = "colMontoOperacion3";
            // 
            // colIdBanco3
            // 
            this.colIdBanco3.Caption = "IdBanco3";
            this.colIdBanco3.FieldName = "IdBanco3";
            this.colIdBanco3.Name = "colIdBanco3";
            // 
            // coIdTipoPeriodoNomina
            // 
            this.coIdTipoPeriodoNomina.Caption = "IdTipoPeriodoNomina";
            this.coIdTipoPeriodoNomina.FieldName = "IdTipoPeriodoNomina";
            this.coIdTipoPeriodoNomina.Name = "coIdTipoPeriodoNomina";
            // 
            // colIdTenedoraSC
            // 
            this.colIdTenedoraSC.Caption = "IdTenedoraSC";
            this.colIdTenedoraSC.FieldName = "IdTenedoraSC";
            this.colIdTenedoraSC.Name = "colIdTenedoraSC";
            // 
            // colTotalNomina
            // 
            this.colTotalNomina.Caption = "TotalNomina";
            this.colTotalNomina.FieldName = "TotalNomina";
            this.colTotalNomina.Name = "colTotalNomina";
            // 
            // colTotalAlimentos
            // 
            this.colTotalAlimentos.Caption = "TotalAlimentos";
            this.colTotalAlimentos.FieldName = "TotalAlimentos";
            this.colTotalAlimentos.Name = "colTotalAlimentos";
            // 
            // colTotalAsimilados
            // 
            this.colTotalAsimilados.Caption = "TotalAsimilados";
            this.colTotalAsimilados.FieldName = "TotalAsimilados";
            this.colTotalAsimilados.Name = "colTotalAsimilados";
            // 
            // colTotalImpuestos
            // 
            this.colTotalImpuestos.Caption = "TotalImpuestos";
            this.colTotalImpuestos.FieldName = "TotalImpuestos";
            this.colTotalImpuestos.Name = "colTotalImpuestos";
            // 
            // colTotalObligaciones
            // 
            this.colTotalObligaciones.Caption = "TotalObligaciones";
            this.colTotalObligaciones.FieldName = "TotalObligaciones";
            this.colTotalObligaciones.Name = "colTotalObligaciones";
            // 
            // colTotalComision
            // 
            this.colTotalComision.Caption = "TotalComision";
            this.colTotalComision.FieldName = "TotalComision";
            this.colTotalComision.Name = "colTotalComision";
            // 
            // colTotalCAsimilados
            // 
            this.colTotalCAsimilados.Caption = "TotalCAsimilados";
            this.colTotalCAsimilados.FieldName = "TotalCAsimilados";
            this.colTotalCAsimilados.Name = "colTotalCAsimilados";
            // 
            // colIdMoneda
            // 
            this.colIdMoneda.Caption = "IdMoneda";
            this.colIdMoneda.FieldName = "IdMoneda";
            this.colIdMoneda.Name = "colIdMoneda";
            // 
            // colTipoCambio
            // 
            this.colTipoCambio.Caption = "TipoCambio";
            this.colTipoCambio.FieldName = "TipoCambio";
            this.colTipoCambio.Name = "colTipoCambio";
            // 
            // colIdEstatus
            // 
            this.colIdEstatus.Caption = "IdEstatus";
            this.colIdEstatus.FieldName = "IdEstatus";
            this.colIdEstatus.Name = "colIdEstatus";
            // 
            // colIdOperador
            // 
            this.colIdOperador.Caption = "IdOperador";
            this.colIdOperador.FieldName = "IdOperador";
            this.colIdOperador.Name = "colIdOperador";
            // 
            // colRazonSocial1
            // 
            this.colRazonSocial1.Caption = "RazonSocial1";
            this.colRazonSocial1.FieldName = "RazonSocial1";
            this.colRazonSocial1.Name = "colRazonSocial1";
            // 
            // colRazonSocial2
            // 
            this.colRazonSocial2.Caption = "RazonSocial2";
            this.colRazonSocial2.FieldName = "RazonSocial2";
            this.colRazonSocial2.Name = "colRazonSocial2";
            // 
            // colRazonSocial3
            // 
            this.colRazonSocial3.Caption = "RazonSocial3";
            this.colRazonSocial3.FieldName = "RazonSocial3";
            this.colRazonSocial3.Name = "colRazonSocial3";
            // 
            // colNombreBanco1
            // 
            this.colNombreBanco1.Caption = "NombreBanco1";
            this.colNombreBanco1.FieldName = "NombreBanco1";
            this.colNombreBanco1.Name = "colNombreBanco1";
            // 
            // colNombreBanco2
            // 
            this.colNombreBanco2.Caption = "NombreBanco2";
            this.colNombreBanco2.FieldName = "NombreBanco2";
            this.colNombreBanco2.Name = "colNombreBanco2";
            // 
            // colNombreBanco3
            // 
            this.colNombreBanco3.Caption = "NombreBanco3";
            this.colNombreBanco3.FieldName = "NombreBanco3";
            this.colNombreBanco3.Name = "colNombreBanco3";
            // 
            // colRazonSocialCliente
            // 
            this.colRazonSocialCliente.Caption = "RazonSocialCliente";
            this.colRazonSocialCliente.FieldName = "RazonSocialCliente";
            this.colRazonSocialCliente.Name = "colRazonSocialCliente";
            // 
            // colDescEstatus
            // 
            this.colDescEstatus.Caption = "Estatus";
            this.colDescEstatus.FieldName = "DescEstatus";
            this.colDescEstatus.Name = "colDescEstatus";
            this.colDescEstatus.Visible = true;
            this.colDescEstatus.VisibleIndex = 3;
            this.colDescEstatus.Width = 114;
            // 
            // colNombreComercial1
            // 
            this.colNombreComercial1.Caption = "NombreComercial1";
            this.colNombreComercial1.FieldName = "NombreComercial1";
            this.colNombreComercial1.Name = "colNombreComercial1";
            // 
            // colNombreComercial2
            // 
            this.colNombreComercial2.Caption = "NombreComercial2";
            this.colNombreComercial2.FieldName = "NombreComercial2";
            this.colNombreComercial2.Name = "colNombreComercial2";
            // 
            // colNombreComercial3
            // 
            this.colNombreComercial3.Caption = "NombreComercial3";
            this.colNombreComercial3.FieldName = "NombreComercial3";
            this.colNombreComercial3.Name = "colNombreComercial3";
            // 
            // colNombreComercialSC
            // 
            this.colNombreComercialSC.Caption = "NombreComercialSC";
            this.colNombreComercialSC.FieldName = "NombreComercialSC";
            this.colNombreComercialSC.Name = "colNombreComercialSC";
            // 
            // colNombreComercialA
            // 
            this.colNombreComercialA.Caption = "NombreComercialA";
            this.colNombreComercialA.FieldName = "NombreComercialA";
            this.colNombreComercialA.Name = "colNombreComercialA";
            // 
            // colMesAno
            // 
            this.colMesAno.Caption = "Mes Año";
            this.colMesAno.FieldName = "MesAno";
            this.colMesAno.Name = "colMesAno";
            this.colMesAno.Visible = true;
            this.colMesAno.VisibleIndex = 2;
            // 
            // cbControl
            // 
            this.cbControl.EditValue = "";
            this.cbControl.Location = new System.Drawing.Point(88, 6);
            this.cbControl.Name = "cbControl";
            this.cbControl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbControl.Properties.DataSource = this.stpFactSelControlOperacionesV2BindingSource;
            this.cbControl.Properties.DisplayMember = "IdControlOperaciones";
            this.cbControl.Properties.ValueMember = "IdControlOperaciones";
            this.cbControl.Properties.View = this.gridLookUpEdit1View;
            this.cbControl.Size = new System.Drawing.Size(365, 20);
            this.cbControl.TabIndex = 1;
            this.cbControl.EditValueChanged += new System.EventHandler(this.cbControl_EditValueChanged);
            // 
            // stpFactSelControlOperacionesV2BindingSource
            // 
            this.stpFactSelControlOperacionesV2BindingSource.DataMember = "stpFactSelControlOperacionesV2";
            this.stpFactSelControlOperacionesV2BindingSource.DataSource = this.dbSAICBPOFactura;
            // 
            // vwCatClienteTableAdapter
            // 
            this.vwCatClienteTableAdapter.ClearBeforeFill = true;
            // 
            // labelControl18
            // 
            this.labelControl18.Location = new System.Drawing.Point(213, 32);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(58, 13);
            this.labelControl18.TabIndex = 51;
            this.labelControl18.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(275, 29);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtDescripcion.Properties.Appearance.Options.UseBackColor = true;
            this.txtDescripcion.Properties.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(473, 20);
            this.txtDescripcion.TabIndex = 3;
            // 
            // labelControl19
            // 
            this.labelControl19.Location = new System.Drawing.Point(26, 32);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(59, 13);
            this.labelControl19.TabIndex = 53;
            this.labelControl19.Text = "No. Control:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(88, 29);
            this.txtId.Name = "txtId";
            this.txtId.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtId.Properties.Appearance.Options.UseBackColor = true;
            this.txtId.Properties.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 2;
            // 
            // stpFactSelDerechosAccesoOperadorFacturacionTableAdapter1
            // 
            this.stpFactSelDerechosAccesoOperadorFacturacionTableAdapter1.ClearBeforeFill = true;
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(91, 302);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtMotivo.Properties.Appearance.Options.UseBackColor = true;
            this.txtMotivo.Properties.ReadOnly = true;
            this.txtMotivo.Size = new System.Drawing.Size(484, 20);
            this.txtMotivo.TabIndex = 30;
            this.txtMotivo.TabStop = false;
            // 
            // labelControl20
            // 
            this.labelControl20.Location = new System.Drawing.Point(52, 305);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(36, 13);
            this.labelControl20.TabIndex = 54;
            this.labelControl20.Text = "Motivo:";
            // 
            // txtEstatus
            // 
            this.txtEstatus.Location = new System.Drawing.Point(510, 280);
            this.txtEstatus.Name = "txtEstatus";
            this.txtEstatus.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtEstatus.Properties.Appearance.Options.UseBackColor = true;
            this.txtEstatus.Properties.ReadOnly = true;
            this.txtEstatus.Size = new System.Drawing.Size(269, 20);
            this.txtEstatus.TabIndex = 28;
            this.txtEstatus.TabStop = false;
            // 
            // labelControl21
            // 
            this.labelControl21.Location = new System.Drawing.Point(464, 284);
            this.labelControl21.Name = "labelControl21";
            this.labelControl21.Size = new System.Drawing.Size(40, 13);
            this.labelControl21.TabIndex = 56;
            this.labelControl21.Text = "Estatus:";
            // 
            // splashSMCargando
            // 
            this.splashSMCargando.ClosingDelay = 500;
            // 
            // stpFactSelFacturasControlTableAdapter
            // 
            this.stpFactSelFacturasControlTableAdapter.ClearBeforeFill = true;
            // 
            // stpFactSelDetailControlOperacionesTableAdapter
            // 
            this.stpFactSelDetailControlOperacionesTableAdapter.ClearBeforeFill = true;
            // 
            // txtSaldoToOperacion
            // 
            this.txtSaldoToOperacion.Location = new System.Drawing.Point(297, 538);
            this.txtSaldoToOperacion.Name = "txtSaldoToOperacion";
            this.txtSaldoToOperacion.Properties.DisplayFormat.FormatString = "C2";
            this.txtSaldoToOperacion.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSaldoToOperacion.Properties.EditFormat.FormatString = "C2";
            this.txtSaldoToOperacion.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSaldoToOperacion.Properties.ReadOnly = true;
            this.txtSaldoToOperacion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSaldoToOperacion.Size = new System.Drawing.Size(109, 20);
            this.txtSaldoToOperacion.TabIndex = 41;
            // 
            // txtToControlopera
            // 
            this.txtToControlopera.Location = new System.Drawing.Point(297, 496);
            this.txtToControlopera.Name = "txtToControlopera";
            this.txtToControlopera.Properties.DisplayFormat.FormatString = "C2";
            this.txtToControlopera.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtToControlopera.Properties.EditFormat.FormatString = "C2";
            this.txtToControlopera.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtToControlopera.Properties.ReadOnly = true;
            this.txtToControlopera.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtToControlopera.Size = new System.Drawing.Size(109, 20);
            this.txtToControlopera.TabIndex = 39;
            // 
            // txtToperacion
            // 
            this.txtToperacion.Location = new System.Drawing.Point(297, 517);
            this.txtToperacion.Name = "txtToperacion";
            this.txtToperacion.Properties.DisplayFormat.FormatString = "C2";
            this.txtToperacion.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtToperacion.Properties.EditFormat.FormatString = "C2";
            this.txtToperacion.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtToperacion.Properties.ReadOnly = true;
            this.txtToperacion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtToperacion.Size = new System.Drawing.Size(109, 20);
            this.txtToperacion.TabIndex = 40;
            // 
            // labelControl22
            // 
            this.labelControl22.Location = new System.Drawing.Point(263, 539);
            this.labelControl22.Name = "labelControl22";
            this.labelControl22.Size = new System.Drawing.Size(30, 13);
            this.labelControl22.TabIndex = 65;
            this.labelControl22.Text = "Saldo:";
            // 
            // labelControl25
            // 
            this.labelControl25.Location = new System.Drawing.Point(213, 518);
            this.labelControl25.Name = "labelControl25";
            this.labelControl25.Size = new System.Drawing.Size(80, 13);
            this.labelControl25.TabIndex = 64;
            this.labelControl25.Text = "Total Operación:";
            // 
            // labelControl26
            // 
            this.labelControl26.Location = new System.Drawing.Point(227, 497);
            this.labelControl26.Name = "labelControl26";
            this.labelControl26.Size = new System.Drawing.Size(66, 13);
            this.labelControl26.TabIndex = 63;
            this.labelControl26.Text = "Total Control:";
            // 
            // labelControl24
            // 
            this.labelControl24.Location = new System.Drawing.Point(15, 350);
            this.labelControl24.Name = "labelControl24";
            this.labelControl24.Size = new System.Drawing.Size(75, 13);
            this.labelControl24.TabIndex = 69;
            this.labelControl24.Text = "Observaciones:";
            // 
            // labelControl27
            // 
            this.labelControl27.Location = new System.Drawing.Point(590, 306);
            this.labelControl27.Name = "labelControl27";
            this.labelControl27.Size = new System.Drawing.Size(83, 13);
            this.labelControl27.TabIndex = 72;
            this.labelControl27.Text = "No. Control Rela:";
            // 
            // cbControlRela
            // 
            this.cbControlRela.EditValue = "";
            this.cbControlRela.Location = new System.Drawing.Point(679, 302);
            this.cbControlRela.Name = "cbControlRela";
            this.cbControlRela.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbControlRela.Properties.DataSource = this.stpFactSelControlOperacionesRelaBindingSource;
            this.cbControlRela.Properties.DisplayMember = "IdControlOperaciones";
            this.cbControlRela.Properties.ValueMember = "IdControlOperaciones";
            this.cbControlRela.Properties.View = this.gridView3;
            this.cbControlRela.Size = new System.Drawing.Size(100, 20);
            this.cbControlRela.TabIndex = 3;
            // 
            // stpFactSelControlOperacionesRelaBindingSource
            // 
            this.stpFactSelControlOperacionesRelaBindingSource.DataMember = "stpFactSelControlOperacionesRela";
            this.stpFactSelControlOperacionesRelaBindingSource.DataSource = this.dbSAICBPOFactura;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdcontrolre});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ColumnAutoWidth = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colIdcontrolre
            // 
            this.colIdcontrolre.Caption = "Id Control Operaciones";
            this.colIdcontrolre.FieldName = "IdControlOperaciones";
            this.colIdcontrolre.Name = "colIdcontrolre";
            this.colIdcontrolre.Visible = true;
            this.colIdcontrolre.VisibleIndex = 0;
            // 
            // stpFactSelControlOperacionesV2TableAdapter
            // 
            this.stpFactSelControlOperacionesV2TableAdapter.ClearBeforeFill = true;
            // 
            // stpFactSelControlOperacionesRelaTableAdapter
            // 
            this.stpFactSelControlOperacionesRelaTableAdapter.ClearBeforeFill = true;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(91, 347);
            this.txtObservaciones.MaxLength = 300;
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(432, 32);
            this.txtObservaciones.TabIndex = 37;
            // 
            // labelControl29
            // 
            this.labelControl29.Location = new System.Drawing.Point(529, 365);
            this.labelControl29.Name = "labelControl29";
            this.labelControl29.Size = new System.Drawing.Size(46, 13);
            this.labelControl29.TabIndex = 77;
            this.labelControl29.Text = "Mes/Año:";
            // 
            // chkCierre
            // 
            this.chkCierre.Location = new System.Drawing.Point(609, 342);
            this.chkCierre.Name = "chkCierre";
            this.chkCierre.Properties.Caption = "Cerrado";
            this.chkCierre.Properties.ReadOnly = true;
            this.chkCierre.Size = new System.Drawing.Size(64, 19);
            this.chkCierre.TabIndex = 33;
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.btnEliminarFiltro);
            this.sidePanel1.Controls.Add(this.btnFiltro);
            this.sidePanel1.Controls.Add(this.dtFechaFin);
            this.sidePanel1.Controls.Add(this.dtFechaIni);
            this.sidePanel1.Controls.Add(this.label4);
            this.sidePanel1.Controls.Add(this.label2);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel1.Location = new System.Drawing.Point(0, 27);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(801, 32);
            this.sidePanel1.TabIndex = 153;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // btnEliminarFiltro
            // 
            this.btnEliminarFiltro.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarFiltro.ImageOptions.Image")));
            this.btnEliminarFiltro.Location = new System.Drawing.Point(426, 6);
            this.btnEliminarFiltro.Name = "btnEliminarFiltro";
            this.btnEliminarFiltro.Size = new System.Drawing.Size(23, 23);
            this.btnEliminarFiltro.TabIndex = 4;
            this.btnEliminarFiltro.Click += new System.EventHandler(this.btnEliminarFiltro_Click);
            // 
            // btnFiltro
            // 
            this.btnFiltro.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltro.ImageOptions.Image")));
            this.btnFiltro.Location = new System.Drawing.Point(397, 6);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(23, 23);
            this.btnFiltro.TabIndex = 3;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // dtFechaFin
            // 
            this.dtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaFin.Location = new System.Drawing.Point(280, 7);
            this.dtFechaFin.Name = "dtFechaFin";
            this.dtFechaFin.Size = new System.Drawing.Size(96, 21);
            this.dtFechaFin.TabIndex = 2;
            this.dtFechaFin.Tag = "Fecha Fin";
            this.dtFechaFin.Value = new System.DateTime(2018, 6, 4, 10, 45, 4, 0);
            // 
            // dtFechaIni
            // 
            this.dtFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaIni.Location = new System.Drawing.Point(91, 7);
            this.dtFechaIni.Name = "dtFechaIni";
            this.dtFechaIni.Size = new System.Drawing.Size(98, 21);
            this.dtFechaIni.TabIndex = 1;
            this.dtFechaIni.Tag = "Fecha Inicio";
            this.dtFechaIni.Value = new System.DateTime(2018, 6, 4, 10, 44, 56, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 100;
            this.label4.Text = "Fecha de Inicio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 102;
            this.label2.Text = "Fecha de Fin:";
            // 
            // sidePanel2
            // 
            this.sidePanel2.Controls.Add(this.txtSaldoCli);
            this.sidePanel2.Controls.Add(this.label1);
            this.sidePanel2.Controls.Add(this.txtMesAno);
            this.sidePanel2.Controls.Add(this.txtFechas);
            this.sidePanel2.Controls.Add(this.labelControl35);
            this.sidePanel2.Controls.Add(this.labelControl23);
            this.sidePanel2.Controls.Add(this.labelControl34);
            this.sidePanel2.Controls.Add(this.gridControl3);
            this.sidePanel2.Controls.Add(this.chkPagado);
            this.sidePanel2.Controls.Add(this.txtBanco5);
            this.sidePanel2.Controls.Add(this.txtFronting5);
            this.sidePanel2.Controls.Add(this.labelControl28);
            this.sidePanel2.Controls.Add(this.labelControl33);
            this.sidePanel2.Controls.Add(this.txtMonto5);
            this.sidePanel2.Controls.Add(this.txtBanco4);
            this.sidePanel2.Controls.Add(this.txtFronting4);
            this.sidePanel2.Controls.Add(this.labelControl40);
            this.sidePanel2.Controls.Add(this.labelControl41);
            this.sidePanel2.Controls.Add(this.txtMonto4);
            this.sidePanel2.Controls.Add(this.labelControl42);
            this.sidePanel2.Controls.Add(this.txtTotalCotrolD);
            this.sidePanel2.Controls.Add(this.labelControl39);
            this.sidePanel2.Controls.Add(this.txtCambio);
            this.sidePanel2.Controls.Add(this.labelControl37);
            this.sidePanel2.Controls.Add(this.labelControl38);
            this.sidePanel2.Controls.Add(this.txtMoneda);
            this.sidePanel2.Controls.Add(this.labelControl30);
            this.sidePanel2.Controls.Add(this.labelControl31);
            this.sidePanel2.Controls.Add(this.labelControl32);
            this.sidePanel2.Controls.Add(this.txtTControl2);
            this.sidePanel2.Controls.Add(this.txtTFacturasSaldo);
            this.sidePanel2.Controls.Add(this.txtSaldo2);
            this.sidePanel2.Controls.Add(this.labelControl1);
            this.sidePanel2.Controls.Add(this.txtCliente);
            this.sidePanel2.Controls.Add(this.gdvLotes);
            this.sidePanel2.Controls.Add(this.labelControl29);
            this.sidePanel2.Controls.Add(this.labelControl2);
            this.sidePanel2.Controls.Add(this.chkCierre);
            this.sidePanel2.Controls.Add(this.labelControl3);
            this.sidePanel2.Controls.Add(this.labelControl4);
            this.sidePanel2.Controls.Add(this.labelControl5);
            this.sidePanel2.Controls.Add(this.txtObservaciones);
            this.sidePanel2.Controls.Add(this.groupControl1);
            this.sidePanel2.Controls.Add(this.cbControlRela);
            this.sidePanel2.Controls.Add(this.labelControl6);
            this.sidePanel2.Controls.Add(this.labelControl27);
            this.sidePanel2.Controls.Add(this.labelControl7);
            this.sidePanel2.Controls.Add(this.labelControl24);
            this.sidePanel2.Controls.Add(this.labelControl8);
            this.sidePanel2.Controls.Add(this.txtSaldoToOperacion);
            this.sidePanel2.Controls.Add(this.txtTControl);
            this.sidePanel2.Controls.Add(this.txtToControlopera);
            this.sidePanel2.Controls.Add(this.txtTFacturas);
            this.sidePanel2.Controls.Add(this.txtToperacion);
            this.sidePanel2.Controls.Add(this.txtSaldo);
            this.sidePanel2.Controls.Add(this.labelControl22);
            this.sidePanel2.Controls.Add(this.txtMonto1);
            this.sidePanel2.Controls.Add(this.labelControl25);
            this.sidePanel2.Controls.Add(this.labelControl10);
            this.sidePanel2.Controls.Add(this.labelControl26);
            this.sidePanel2.Controls.Add(this.txtMonto2);
            this.sidePanel2.Controls.Add(this.labelControl11);
            this.sidePanel2.Controls.Add(this.txtMonto3);
            this.sidePanel2.Controls.Add(this.labelControl12);
            this.sidePanel2.Controls.Add(this.labelControl13);
            this.sidePanel2.Controls.Add(this.txtEstatus);
            this.sidePanel2.Controls.Add(this.labelControl14);
            this.sidePanel2.Controls.Add(this.labelControl21);
            this.sidePanel2.Controls.Add(this.labelControl15);
            this.sidePanel2.Controls.Add(this.txtMotivo);
            this.sidePanel2.Controls.Add(this.labelControl17);
            this.sidePanel2.Controls.Add(this.labelControl20);
            this.sidePanel2.Controls.Add(this.txtPeriodoPago);
            this.sidePanel2.Controls.Add(this.labelControl19);
            this.sidePanel2.Controls.Add(this.labelControl16);
            this.sidePanel2.Controls.Add(this.txtId);
            this.sidePanel2.Controls.Add(this.txtTipoNomina);
            this.sidePanel2.Controls.Add(this.labelControl18);
            this.sidePanel2.Controls.Add(this.txtFronting1);
            this.sidePanel2.Controls.Add(this.txtDescripcion);
            this.sidePanel2.Controls.Add(this.txtBanco1);
            this.sidePanel2.Controls.Add(this.cbControl);
            this.sidePanel2.Controls.Add(this.txtFronting2);
            this.sidePanel2.Controls.Add(this.txtOperador);
            this.sidePanel2.Controls.Add(this.txtBanco2);
            this.sidePanel2.Controls.Add(this.txtBanco3);
            this.sidePanel2.Controls.Add(this.txtFronting3);
            this.sidePanel2.Controls.Add(this.labelControl9);
            this.sidePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidePanel2.Location = new System.Drawing.Point(0, 59);
            this.sidePanel2.Name = "sidePanel2";
            this.sidePanel2.Size = new System.Drawing.Size(801, 563);
            this.sidePanel2.TabIndex = 154;
            this.sidePanel2.Text = "sidePanel2";
            this.sidePanel2.Click += new System.EventHandler(this.sidePanel2_Click);
            // 
            // txtSaldoCli
            // 
            this.txtSaldoCli.Location = new System.Drawing.Point(38, 532);
            this.txtSaldoCli.Name = "txtSaldoCli";
            this.txtSaldoCli.Properties.DisplayFormat.FormatString = "C2";
            this.txtSaldoCli.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSaldoCli.Properties.EditFormat.FormatString = "C2";
            this.txtSaldoCli.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSaldoCli.Properties.ReadOnly = true;
            this.txtSaldoCli.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSaldoCli.Size = new System.Drawing.Size(109, 20);
            this.txtSaldoCli.TabIndex = 197;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 518);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 13);
            this.label1.TabIndex = 196;
            this.label1.Text = "SALDO A FAVOR / FINANCIAMIENTO";
            // 
            // txtMesAno
            // 
            this.txtMesAno.Location = new System.Drawing.Point(581, 361);
            this.txtMesAno.Name = "txtMesAno";
            this.txtMesAno.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtMesAno.Properties.Appearance.Options.UseBackColor = true;
            this.txtMesAno.Properties.ReadOnly = true;
            this.txtMesAno.Size = new System.Drawing.Size(198, 20);
            this.txtMesAno.TabIndex = 195;
            this.txtMesAno.TabStop = false;
            // 
            // txtFechas
            // 
            this.txtFechas.Location = new System.Drawing.Point(510, 258);
            this.txtFechas.Name = "txtFechas";
            this.txtFechas.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtFechas.Properties.Appearance.Options.UseBackColor = true;
            this.txtFechas.Properties.ReadOnly = true;
            this.txtFechas.Size = new System.Drawing.Size(269, 20);
            this.txtFechas.TabIndex = 193;
            this.txtFechas.TabStop = false;
            // 
            // labelControl35
            // 
            this.labelControl35.Location = new System.Drawing.Point(471, 261);
            this.labelControl35.Name = "labelControl35";
            this.labelControl35.Size = new System.Drawing.Size(33, 13);
            this.labelControl35.TabIndex = 194;
            this.labelControl35.Text = "Fecha:";
            // 
            // labelControl23
            // 
            this.labelControl23.Location = new System.Drawing.Point(32, 165);
            this.labelControl23.Name = "labelControl23";
            this.labelControl23.Size = new System.Drawing.Size(53, 13);
            this.labelControl23.TabIndex = 192;
            this.labelControl23.Text = "Fronting 5:";
            // 
            // labelControl34
            // 
            this.labelControl34.Location = new System.Drawing.Point(32, 184);
            this.labelControl34.Name = "labelControl34";
            this.labelControl34.Size = new System.Drawing.Size(52, 13);
            this.labelControl34.TabIndex = 191;
            this.labelControl34.Text = "Productos:";
            // 
            // gridControl3
            // 
            this.gridControl3.DataSource = this.stpFactSelCOProductosControlBindingSource;
            this.gridControl3.Location = new System.Drawing.Point(88, 184);
            this.gridControl3.MainView = this.gridView5;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.Size = new System.Drawing.Size(688, 71);
            this.gridControl3.TabIndex = 0;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView5});
            // 
            // gridView5
            // 
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCOProductos,
            this.colIdControlOperaciones1,
            this.colIdProducto,
            this.colDescTipoPeriodoNomina1,
            this.colIdTenedora,
            this.colRazonSocial4,
            this.colNombreComercial,
            this.colIdBanco,
            this.colNombreBanco,
            this.colMonto,
            this.colCBPO,
            this.colCProveedor});
            this.gridView5.GridControl = this.gridControl3;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsView.ColumnAutoWidth = false;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            // 
            // colIdCOProductos
            // 
            this.colIdCOProductos.Caption = "Id";
            this.colIdCOProductos.FieldName = "IdCOProductos";
            this.colIdCOProductos.Name = "colIdCOProductos";
            this.colIdCOProductos.Visible = true;
            this.colIdCOProductos.VisibleIndex = 0;
            this.colIdCOProductos.Width = 40;
            // 
            // colIdControlOperaciones1
            // 
            this.colIdControlOperaciones1.FieldName = "IdControlOperaciones";
            this.colIdControlOperaciones1.Name = "colIdControlOperaciones1";
            // 
            // colIdProducto
            // 
            this.colIdProducto.FieldName = "IdProducto";
            this.colIdProducto.Name = "colIdProducto";
            // 
            // colDescTipoPeriodoNomina1
            // 
            this.colDescTipoPeriodoNomina1.Caption = "Producto";
            this.colDescTipoPeriodoNomina1.FieldName = "DescTipoPeriodoNomina";
            this.colDescTipoPeriodoNomina1.Name = "colDescTipoPeriodoNomina1";
            this.colDescTipoPeriodoNomina1.Visible = true;
            this.colDescTipoPeriodoNomina1.VisibleIndex = 1;
            this.colDescTipoPeriodoNomina1.Width = 113;
            // 
            // colIdTenedora
            // 
            this.colIdTenedora.FieldName = "IdTenedora";
            this.colIdTenedora.Name = "colIdTenedora";
            // 
            // colRazonSocial4
            // 
            this.colRazonSocial4.FieldName = "RazonSocial";
            this.colRazonSocial4.Name = "colRazonSocial4";
            // 
            // colNombreComercial
            // 
            this.colNombreComercial.Caption = "Empresa";
            this.colNombreComercial.FieldName = "NombreComercial";
            this.colNombreComercial.Name = "colNombreComercial";
            this.colNombreComercial.Visible = true;
            this.colNombreComercial.VisibleIndex = 2;
            this.colNombreComercial.Width = 313;
            // 
            // colIdBanco
            // 
            this.colIdBanco.FieldName = "IdBanco";
            this.colIdBanco.Name = "colIdBanco";
            // 
            // colNombreBanco
            // 
            this.colNombreBanco.Caption = "Banco";
            this.colNombreBanco.FieldName = "NombreBanco";
            this.colNombreBanco.Name = "colNombreBanco";
            this.colNombreBanco.Visible = true;
            this.colNombreBanco.VisibleIndex = 3;
            this.colNombreBanco.Width = 107;
            // 
            // colMonto
            // 
            this.colMonto.Caption = "Total";
            this.colMonto.DisplayFormat.FormatString = "{0:C2}";
            this.colMonto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMonto.FieldName = "Monto";
            this.colMonto.Name = "colMonto";
            this.colMonto.Visible = true;
            this.colMonto.VisibleIndex = 4;
            // 
            // colCBPO
            // 
            this.colCBPO.Caption = "Comisión BPO";
            this.colCBPO.DisplayFormat.FormatString = "{0:C2}";
            this.colCBPO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCBPO.FieldName = "CBPO";
            this.colCBPO.Name = "colCBPO";
            // 
            // colCProveedor
            // 
            this.colCProveedor.Caption = "Comisión Proveedores";
            this.colCProveedor.DisplayFormat.FormatString = "{0:C2}";
            this.colCProveedor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCProveedor.FieldName = "CProveedor";
            this.colCProveedor.Name = "colCProveedor";
            // 
            // chkPagado
            // 
            this.chkPagado.Location = new System.Drawing.Point(711, 342);
            this.chkPagado.Name = "chkPagado";
            this.chkPagado.Properties.Caption = "Pagado";
            this.chkPagado.Properties.ReadOnly = true;
            this.chkPagado.Size = new System.Drawing.Size(68, 19);
            this.chkPagado.TabIndex = 190;
            // 
            // txtBanco5
            // 
            this.txtBanco5.Location = new System.Drawing.Point(676, 161);
            this.txtBanco5.Name = "txtBanco5";
            this.txtBanco5.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtBanco5.Properties.Appearance.Options.UseBackColor = true;
            this.txtBanco5.Properties.ReadOnly = true;
            this.txtBanco5.Size = new System.Drawing.Size(100, 20);
            this.txtBanco5.TabIndex = 19;
            // 
            // txtFronting5
            // 
            this.txtFronting5.Location = new System.Drawing.Point(88, 161);
            this.txtFronting5.Name = "txtFronting5";
            this.txtFronting5.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtFronting5.Properties.Appearance.Options.UseBackColor = true;
            this.txtFronting5.Properties.ReadOnly = true;
            this.txtFronting5.Size = new System.Drawing.Size(365, 20);
            this.txtFronting5.TabIndex = 17;
            // 
            // labelControl28
            // 
            this.labelControl28.Location = new System.Drawing.Point(637, 165);
            this.labelControl28.Name = "labelControl28";
            this.labelControl28.Size = new System.Drawing.Size(33, 13);
            this.labelControl28.TabIndex = 185;
            this.labelControl28.Text = "Banco:";
            // 
            // labelControl33
            // 
            this.labelControl33.Location = new System.Drawing.Point(467, 165);
            this.labelControl33.Name = "labelControl33";
            this.labelControl33.Size = new System.Drawing.Size(34, 13);
            this.labelControl33.TabIndex = 184;
            this.labelControl33.Text = "Monto:";
            // 
            // txtMonto5
            // 
            this.txtMonto5.Location = new System.Drawing.Point(507, 161);
            this.txtMonto5.Name = "txtMonto5";
            this.txtMonto5.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtMonto5.Properties.Appearance.Options.UseBackColor = true;
            this.txtMonto5.Properties.DisplayFormat.FormatString = "C2";
            this.txtMonto5.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtMonto5.Properties.EditFormat.FormatString = "C2";
            this.txtMonto5.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtMonto5.Properties.ReadOnly = true;
            this.txtMonto5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMonto5.Size = new System.Drawing.Size(116, 20);
            this.txtMonto5.TabIndex = 18;
            // 
            // txtBanco4
            // 
            this.txtBanco4.Location = new System.Drawing.Point(676, 139);
            this.txtBanco4.Name = "txtBanco4";
            this.txtBanco4.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtBanco4.Properties.Appearance.Options.UseBackColor = true;
            this.txtBanco4.Properties.ReadOnly = true;
            this.txtBanco4.Size = new System.Drawing.Size(100, 20);
            this.txtBanco4.TabIndex = 16;
            // 
            // txtFronting4
            // 
            this.txtFronting4.Location = new System.Drawing.Point(88, 139);
            this.txtFronting4.Name = "txtFronting4";
            this.txtFronting4.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtFronting4.Properties.Appearance.Options.UseBackColor = true;
            this.txtFronting4.Properties.ReadOnly = true;
            this.txtFronting4.Size = new System.Drawing.Size(365, 20);
            this.txtFronting4.TabIndex = 14;
            // 
            // labelControl40
            // 
            this.labelControl40.Location = new System.Drawing.Point(637, 142);
            this.labelControl40.Name = "labelControl40";
            this.labelControl40.Size = new System.Drawing.Size(33, 13);
            this.labelControl40.TabIndex = 182;
            this.labelControl40.Text = "Banco:";
            // 
            // labelControl41
            // 
            this.labelControl41.Location = new System.Drawing.Point(467, 142);
            this.labelControl41.Name = "labelControl41";
            this.labelControl41.Size = new System.Drawing.Size(34, 13);
            this.labelControl41.TabIndex = 181;
            this.labelControl41.Text = "Monto:";
            // 
            // txtMonto4
            // 
            this.txtMonto4.Location = new System.Drawing.Point(507, 139);
            this.txtMonto4.Name = "txtMonto4";
            this.txtMonto4.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtMonto4.Properties.Appearance.Options.UseBackColor = true;
            this.txtMonto4.Properties.DisplayFormat.FormatString = "C2";
            this.txtMonto4.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtMonto4.Properties.EditFormat.FormatString = "C2";
            this.txtMonto4.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtMonto4.Properties.ReadOnly = true;
            this.txtMonto4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMonto4.Size = new System.Drawing.Size(116, 20);
            this.txtMonto4.TabIndex = 15;
            // 
            // labelControl42
            // 
            this.labelControl42.Location = new System.Drawing.Point(32, 142);
            this.labelControl42.Name = "labelControl42";
            this.labelControl42.Size = new System.Drawing.Size(53, 13);
            this.labelControl42.TabIndex = 180;
            this.labelControl42.Text = "Fronting 4:";
            // 
            // txtTotalCotrolD
            // 
            this.txtTotalCotrolD.Location = new System.Drawing.Point(679, 323);
            this.txtTotalCotrolD.Name = "txtTotalCotrolD";
            this.txtTotalCotrolD.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtTotalCotrolD.Properties.Appearance.Options.UseBackColor = true;
            this.txtTotalCotrolD.Properties.ReadOnly = true;
            this.txtTotalCotrolD.Size = new System.Drawing.Size(100, 20);
            this.txtTotalCotrolD.TabIndex = 36;
            // 
            // labelControl39
            // 
            this.labelControl39.Location = new System.Drawing.Point(607, 327);
            this.labelControl39.Name = "labelControl39";
            this.labelControl39.Size = new System.Drawing.Size(66, 13);
            this.labelControl39.TabIndex = 169;
            this.labelControl39.Text = "Total Control:";
            // 
            // txtCambio
            // 
            this.txtCambio.Location = new System.Drawing.Point(356, 324);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtCambio.Properties.Appearance.Options.UseBackColor = true;
            this.txtCambio.Properties.ReadOnly = true;
            this.txtCambio.Size = new System.Drawing.Size(100, 20);
            this.txtCambio.TabIndex = 32;
            // 
            // labelControl37
            // 
            this.labelControl37.Location = new System.Drawing.Point(288, 327);
            this.labelControl37.Name = "labelControl37";
            this.labelControl37.Size = new System.Drawing.Size(62, 13);
            this.labelControl37.TabIndex = 168;
            this.labelControl37.Text = "Tipo Cambio:";
            // 
            // labelControl38
            // 
            this.labelControl38.Location = new System.Drawing.Point(46, 327);
            this.labelControl38.Name = "labelControl38";
            this.labelControl38.Size = new System.Drawing.Size(42, 13);
            this.labelControl38.TabIndex = 167;
            this.labelControl38.Text = "Moneda:";
            // 
            // txtMoneda
            // 
            this.txtMoneda.Location = new System.Drawing.Point(91, 324);
            this.txtMoneda.Name = "txtMoneda";
            this.txtMoneda.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtMoneda.Properties.Appearance.Options.UseBackColor = true;
            this.txtMoneda.Properties.DisplayFormat.FormatString = "C2";
            this.txtMoneda.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtMoneda.Properties.EditFormat.FormatString = "C2";
            this.txtMoneda.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtMoneda.Properties.ReadOnly = true;
            this.txtMoneda.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMoneda.Size = new System.Drawing.Size(100, 20);
            this.txtMoneda.TabIndex = 31;
            // 
            // labelControl30
            // 
            this.labelControl30.Location = new System.Drawing.Point(598, 499);
            this.labelControl30.Name = "labelControl30";
            this.labelControl30.Size = new System.Drawing.Size(68, 13);
            this.labelControl30.TabIndex = 158;
            this.labelControl30.Text = "Total Factura:";
            // 
            // labelControl31
            // 
            this.labelControl31.Location = new System.Drawing.Point(606, 520);
            this.labelControl31.Name = "labelControl31";
            this.labelControl31.Size = new System.Drawing.Size(60, 13);
            this.labelControl31.TabIndex = 159;
            this.labelControl31.Text = "Total Pagos:";
            // 
            // labelControl32
            // 
            this.labelControl32.Location = new System.Drawing.Point(636, 541);
            this.labelControl32.Name = "labelControl32";
            this.labelControl32.Size = new System.Drawing.Size(30, 13);
            this.labelControl32.TabIndex = 160;
            this.labelControl32.Text = "Saldo:";
            // 
            // txtTControl2
            // 
            this.txtTControl2.Location = new System.Drawing.Point(667, 496);
            this.txtTControl2.Name = "txtTControl2";
            this.txtTControl2.Properties.DisplayFormat.FormatString = "C2";
            this.txtTControl2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTControl2.Properties.EditFormat.FormatString = "C2";
            this.txtTControl2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTControl2.Properties.ReadOnly = true;
            this.txtTControl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTControl2.Size = new System.Drawing.Size(109, 20);
            this.txtTControl2.TabIndex = 45;
            // 
            // txtTFacturasSaldo
            // 
            this.txtTFacturasSaldo.Location = new System.Drawing.Point(667, 517);
            this.txtTFacturasSaldo.Name = "txtTFacturasSaldo";
            this.txtTFacturasSaldo.Properties.DisplayFormat.FormatString = "C2";
            this.txtTFacturasSaldo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTFacturasSaldo.Properties.EditFormat.FormatString = "C2";
            this.txtTFacturasSaldo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTFacturasSaldo.Properties.ReadOnly = true;
            this.txtTFacturasSaldo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTFacturasSaldo.Size = new System.Drawing.Size(109, 20);
            this.txtTFacturasSaldo.TabIndex = 46;
            // 
            // txtSaldo2
            // 
            this.txtSaldo2.Location = new System.Drawing.Point(667, 538);
            this.txtSaldo2.Name = "txtSaldo2";
            this.txtSaldo2.Properties.DisplayFormat.FormatString = "C2";
            this.txtSaldo2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSaldo2.Properties.EditFormat.FormatString = "C2";
            this.txtSaldo2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSaldo2.Properties.ReadOnly = true;
            this.txtSaldo2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSaldo2.Size = new System.Drawing.Size(109, 20);
            this.txtSaldo2.TabIndex = 47;
            // 
            // stpControlCerradoCountTableAdapter1
            // 
            this.stpControlCerradoCountTableAdapter1.ClearBeforeFill = true;
            // 
            // stpFactSelCOProductosControlBindingSource
            // 
            this.stpFactSelCOProductosControlBindingSource.DataMember = "stpFactSelCOProductosControl";
            this.stpFactSelCOProductosControlBindingSource.DataSource = this.dbSAICBPOFactura;
            // 
            // stpFactSelCOProductosControlTableAdapter
            // 
            this.stpFactSelCOProductosControlTableAdapter.ClearBeforeFill = true;
            // 
            // frmxAdmonControlOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 622);
            this.ControlBox = false;
            this.Controls.Add(this.sidePanel2);
            this.Controls.Add(this.sidePanel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmxAdmonControlOperaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administración de Control de Operaciones";
            this.Load += new System.EventHandler(this.frmxAdmonControlOperaciones_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvLotes)).EndInit();
            this.gdvLotes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelDetailControlOperacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelFacturasControlBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTControl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTFacturas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaldo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodoPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoNomina.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFronting1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBanco1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBanco2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFronting2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBanco3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFronting3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOperador.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbControl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelControlOperacionesV2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMotivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaldoToOperacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToControlopera.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToperacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbControlRela.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelControlOperacionesRelaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCierre.Properties)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            this.sidePanel1.PerformLayout();
            this.sidePanel2.ResumeLayout(false);
            this.sidePanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaldoCli.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMesAno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFechas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPagado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBanco5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFronting5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBanco4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFronting4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalCotrolD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCambio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMoneda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTControl2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTFacturasSaldo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaldo2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelCOProductosControlBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton btnFacturar;
        private System.Windows.Forms.ToolStripButton btnVincular;
        private System.Windows.Forms.ToolStripButton btnDesvincular;
        private System.Windows.Forms.ToolStripButton btnCancelarControl;
        private DevExpress.XtraEditors.GroupControl gdvLotes;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.ToolStripButton btnDescargar;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtTControl;
        private DevExpress.XtraEditors.TextEdit txtTFacturas;
        private DevExpress.XtraEditors.TextEdit txtSaldo;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtMonto1;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit txtMonto2;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit txtMonto3;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.TextEdit txtPeriodoPago;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.TextEdit txtTipoNomina;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private Facturas.dbSAICBPOFactura dbSAICBPOFactura;
        private DevExpress.XtraEditors.TextEdit txtFronting1;
        private DevExpress.XtraEditors.TextEdit txtBanco1;
        private DevExpress.XtraEditors.TextEdit txtBanco2;
        private DevExpress.XtraEditors.TextEdit txtFronting2;
        private DevExpress.XtraEditors.TextEdit txtBanco3;
        private DevExpress.XtraEditors.TextEdit txtFronting3;
        private DevExpress.XtraEditors.TextEdit txtOperador;
        private DevExpress.XtraEditors.TextEdit txtCliente;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colIdControlOperaciones;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colDescTipoPeriodoNomina;
        private DevExpress.XtraGrid.Columns.GridColumn colSubtotal;
        private DevExpress.XtraGrid.Columns.GridColumn colIVA;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaOperacion;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreCompletoOperador;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaInicio;
        private DevExpress.XtraGrid.Columns.GridColumn colRazonSocialSC;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFronting1;
        private DevExpress.XtraGrid.Columns.GridColumn colMontoOperacion1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBanco1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFronting2;
        private DevExpress.XtraGrid.Columns.GridColumn colMontoOperacion2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBanco2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFronting3;
        private DevExpress.XtraGrid.Columns.GridColumn colMontoOperacion3;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBanco3;
        private DevExpress.XtraGrid.Columns.GridColumn coIdTipoPeriodoNomina;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTenedoraSC;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalNomina;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalAlimentos;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalAsimilados;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalImpuestos;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalObligaciones;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalComision;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalCAsimilados;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMoneda;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoCambio;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstatus;
        private DevExpress.XtraGrid.Columns.GridColumn colIdOperador;
        private DevExpress.XtraGrid.Columns.GridColumn colRazonSocial1;
        private DevExpress.XtraGrid.Columns.GridColumn colRazonSocial2;
        private DevExpress.XtraGrid.Columns.GridColumn colRazonSocial3;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreBanco1;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreBanco2;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreBanco3;
        private DevExpress.XtraEditors.GridLookUpEdit cbControl;
        private dbSAICBPODataSetTableAdapters.vwCatClienteTableAdapter vwCatClienteTableAdapter;
        private DevExpress.XtraGrid.GridControl dgvLotes;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaFin;
        private DevExpress.XtraGrid.Columns.GridColumn colRazonSocialCliente;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.TextEdit txtDescripcion;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraEditors.TextEdit txtId;
        private Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelDerechosAccesoOperadorFacturacionTableAdapter stpFactSelDerechosAccesoOperadorFacturacionTableAdapter1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.ToolStripButton btnSolicitudCancelacion;
        private DevExpress.XtraEditors.TextEdit txtMotivo;
        private DevExpress.XtraEditors.LabelControl labelControl20;
        private DevExpress.XtraEditors.TextEdit txtEstatus;
        private DevExpress.XtraEditors.LabelControl labelControl21;
        private System.Windows.Forms.ToolStripButton btnHabilitar;
        private DevExpress.XtraGrid.Columns.GridColumn colDescEstatus;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashSMCargando;
        private Facturas.dbSAICBPOFacturaTableAdapters.spSoloRespuesta spSoloRespuesta1;
        private System.Windows.Forms.BindingSource stpFactSelFacturasControlBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdHeaderFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSolicitudFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colIdControlOperacion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFacturador;
        private DevExpress.XtraGrid.Columns.GridColumn colRFCFronting;
        private DevExpress.XtraGrid.Columns.GridColumn colRazonSocialFronting;
        private DevExpress.XtraGrid.Columns.GridColumn colLugarExpedicion;
        private DevExpress.XtraGrid.Columns.GridColumn colRegimenFiscal;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBeneficiario;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoBeneficiario;
        private DevExpress.XtraGrid.Columns.GridColumn colDescTipoBeneficiario;
        private DevExpress.XtraGrid.Columns.GridColumn colRFCCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colRazonSocialBeneficiario;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoComprobante;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsoCFDI;
        private DevExpress.XtraGrid.Columns.GridColumn colUsoCFDI;
        private DevExpress.XtraGrid.Columns.GridColumn colPorIVA;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMetodoPago;
        private DevExpress.XtraGrid.Columns.GridColumn colClaveMetodoPago;
        private DevExpress.XtraGrid.Columns.GridColumn colDescMetodoPago;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFormaPago;
        private DevExpress.XtraGrid.Columns.GridColumn colClaveFormaPago;
        private DevExpress.XtraGrid.Columns.GridColumn colDescFormaPago;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMoneda1;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoCambio1;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaPago;
        private DevExpress.XtraGrid.Columns.GridColumn colSubTotal1;
        private DevExpress.XtraGrid.Columns.GridColumn colIVA1;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal1;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalDepositado;
        private DevExpress.XtraGrid.Columns.GridColumn colEstatusDocumento;
        private DevExpress.XtraGrid.Columns.GridColumn colIdHeaderFacturaCFDI;
        private DevExpress.XtraGrid.Columns.GridColumn colSerie;
        private DevExpress.XtraGrid.Columns.GridColumn colFolioInterno;
        private DevExpress.XtraGrid.Columns.GridColumn colUUID;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaGeneracionCFDI;
        private DevExpress.XtraGrid.Columns.GridColumn colDescTipoRelacion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdHeaderFacturaRelacion;
        private DevExpress.XtraGrid.Columns.GridColumn colSerieInternoRelacion;
        private DevExpress.XtraGrid.Columns.GridColumn colFolioInternoRelacion;
        private DevExpress.XtraGrid.Columns.GridColumn colUUIDRelacion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoRelacion;
        private DevExpress.XtraGrid.Columns.GridColumn colClaveTipoRelacion;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaGeneracionCFDIRelacion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstatus1;
        private DevExpress.XtraGrid.Columns.GridColumn colDescEstatus1;
        private DevExpress.XtraGrid.Columns.GridColumn colComentarios;
        private DevExpress.XtraGrid.Columns.GridColumn colIdOperador1;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreCompletoOperador1;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaCreacion;
        private Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelFacturasControlTableAdapter stpFactSelFacturasControlTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colIdControlOperacion1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdLoteCargaNomina;
        private DevExpress.XtraGrid.Columns.GridColumn colFolioLoteCargaNomina;
        private DevExpress.XtraGrid.Columns.GridColumn colRazonSocial;
        private DevExpress.XtraGrid.Columns.GridColumn colTIPO;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalNomina1;
        private DevExpress.XtraGrid.Columns.GridColumn colISR;
        private DevExpress.XtraGrid.Columns.GridColumn colISN;
        private DevExpress.XtraGrid.Columns.GridColumn colIMSSPatron;
        private DevExpress.XtraGrid.Columns.GridColumn colIMSSObrero;
        private DevExpress.XtraGrid.Columns.GridColumn colCOSTOADICIONAL;
        private DevExpress.XtraGrid.Columns.GridColumn colINFONAVIT;
        private DevExpress.XtraGrid.Columns.GridColumn colRECINFONAVIT;
        private DevExpress.XtraGrid.Columns.GridColumn colFONACOT;
        private DevExpress.XtraGrid.Columns.GridColumn colCuotasSindicales;
        private DevExpress.XtraGrid.Columns.GridColumn colPensiónAlimenticia;
        private DevExpress.XtraGrid.Columns.GridColumn colFondoAhorro;
        private DevExpress.XtraGrid.Columns.GridColumn colPrestamos;
        private DevExpress.XtraGrid.Columns.GridColumn colVales;
        private DevExpress.XtraGrid.Columns.GridColumn colOtros;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPagarBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPercepciones;
        private DevExpress.XtraGrid.Columns.GridColumn colTOTALDeducciones;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalEmpleados;
        private System.Windows.Forms.BindingSource stpFactSelDetailControlOperacionesBindingSource;
        private Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelDetailControlOperacionesTableAdapter stpFactSelDetailControlOperacionesTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreComercial1;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreComercial2;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreComercial3;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreComercialSC;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreComercialA;
        private DevExpress.XtraGrid.Columns.GridColumn colBeneficiario;
        private DevExpress.XtraEditors.TextEdit txtSaldoToOperacion;
        private DevExpress.XtraEditors.TextEdit txtToControlopera;
        private DevExpress.XtraEditors.TextEdit txtToperacion;
        private DevExpress.XtraEditors.LabelControl labelControl22;
        private DevExpress.XtraEditors.LabelControl labelControl25;
        private DevExpress.XtraEditors.LabelControl labelControl26;
        private System.Windows.Forms.ToolStripButton btnCerrarC;
        private System.Windows.Forms.ToolStripButton btnAbrirC;
        private DevExpress.XtraEditors.LabelControl labelControl24;
        private DevExpress.XtraEditors.LabelControl labelControl27;
        private DevExpress.XtraEditors.GridLookUpEdit cbControlRela;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private System.Windows.Forms.BindingSource stpFactSelControlOperacionesV2BindingSource;
        private Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelControlOperacionesV2TableAdapter stpFactSelControlOperacionesV2TableAdapter;
        private System.Windows.Forms.BindingSource stpFactSelControlOperacionesRelaBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdcontrolre;
        private Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelControlOperacionesRelaTableAdapter stpFactSelControlOperacionesRelaTableAdapter;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.ToolStripButton btnActualizar;
        private DevExpress.XtraEditors.LabelControl labelControl29;
        private DevExpress.XtraEditors.CheckEdit chkCierre;
        private System.Windows.Forms.ToolStripButton btnSolicitarPago;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraEditors.SimpleButton btnEliminarFiltro;
        private DevExpress.XtraEditors.SimpleButton btnFiltro;
        private System.Windows.Forms.DateTimePicker dtFechaFin;
        private System.Windows.Forms.DateTimePicker dtFechaIni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SidePanel sidePanel2;
        private DevExpress.XtraEditors.TextEdit txtTotalCotrolD;
        private DevExpress.XtraEditors.LabelControl labelControl39;
        private DevExpress.XtraEditors.TextEdit txtCambio;
        private DevExpress.XtraEditors.LabelControl labelControl37;
        private DevExpress.XtraEditors.LabelControl labelControl38;
        private DevExpress.XtraEditors.TextEdit txtMoneda;
        private DevExpress.XtraEditors.LabelControl labelControl30;
        private DevExpress.XtraEditors.LabelControl labelControl31;
        private DevExpress.XtraEditors.LabelControl labelControl32;
        private DevExpress.XtraEditors.TextEdit txtTControl2;
        private DevExpress.XtraEditors.TextEdit txtTFacturasSaldo;
        private DevExpress.XtraEditors.TextEdit txtSaldo2;
        private DevExpress.XtraGrid.Columns.GridColumn colMesAno;
        private DevExpress.XtraEditors.TextEdit txtBanco5;
        private DevExpress.XtraEditors.TextEdit txtFronting5;
        private DevExpress.XtraEditors.LabelControl labelControl28;
        private DevExpress.XtraEditors.LabelControl labelControl33;
        private DevExpress.XtraEditors.TextEdit txtMonto5;
        private DevExpress.XtraEditors.TextEdit txtBanco4;
        private DevExpress.XtraEditors.TextEdit txtFronting4;
        private DevExpress.XtraEditors.LabelControl labelControl40;
        private DevExpress.XtraEditors.LabelControl labelControl41;
        private DevExpress.XtraEditors.TextEdit txtMonto4;
        private DevExpress.XtraEditors.CheckEdit chkPagado;
        private System.Windows.Forms.ToolStripButton btnPago;
        private System.Windows.Forms.ToolStripButton btnPagoEliminar;
        private System.Windows.Forms.ToolStripButton btnAutControl;
        private System.Windows.Forms.ToolStripButton btnEAutControl;
        private Facturas.dbSAICBPOFacturaTableAdapters.stpControlCerradoCountTableAdapter stpControlCerradoCountTableAdapter1;
        private DevExpress.XtraEditors.LabelControl labelControl23;
        private DevExpress.XtraEditors.LabelControl labelControl34;
        private DevExpress.XtraGrid.GridControl gridControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraEditors.LabelControl labelControl42;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCOProductos;
        private DevExpress.XtraGrid.Columns.GridColumn colIdControlOperaciones1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colDescTipoPeriodoNomina1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTenedora;
        private DevExpress.XtraGrid.Columns.GridColumn colRazonSocial4;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreComercial;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colMonto;
        private DevExpress.XtraGrid.Columns.GridColumn colCBPO;
        private DevExpress.XtraGrid.Columns.GridColumn colCProveedor;
        private DevExpress.XtraEditors.TextEdit txtMesAno;
        private DevExpress.XtraEditors.TextEdit txtFechas;
        private DevExpress.XtraEditors.LabelControl labelControl35;
        private Asimilados.dbSAICAsimiladosTableAdapters.QueriesAsimilados queriesAsimilados1;
        private DevExpress.XtraEditors.TextEdit txtSaldoCli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource stpFactSelCOProductosControlBindingSource;
        private Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelCOProductosControlTableAdapter stpFactSelCOProductosControlTableAdapter;
    }
}