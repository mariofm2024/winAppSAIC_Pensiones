namespace winAppSAIC.Facturas
{
    partial class frmAdmonFacturasFC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmonFacturasFC));
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btnCancelarFactura = new System.Windows.Forms.ToolStripButton();
            this.btnFacturar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelarTimbre = new System.Windows.Forms.ToolStripButton();
            this.btnContabilizar = new System.Windows.Forms.ToolStripButton();
            this.btnDescontabilizar = new System.Windows.Forms.ToolStripButton();
            this.btnComprobante = new System.Windows.Forms.ToolStripButton();
            this.btnDescargar = new System.Windows.Forms.ToolStripButton();
            this.btnVisualizarErrores = new System.Windows.Forms.ToolStripButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblTenedora = new System.Windows.Forms.Label();
            this.grConceptos = new DevExpress.XtraEditors.GroupControl();
            this.gvConceptos = new DevExpress.XtraGrid.GridControl();
            this.stpFactSelDetailFacturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPOFactura = new winAppSAIC.Facturas.dbSAICBPOFactura();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdDetailFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdHeaderFactura2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUnidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn43 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComplemento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecioUnitario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIVA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colISN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprossat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRetencion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.stpFactSelConceptoTenedoraBeneficiarioFiltroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFronting = new System.Windows.Forms.TextBox();
            this.txtTipoBeneficiarios = new System.Windows.Forms.TextBox();
            this.txtFormaPago = new System.Windows.Forms.TextBox();
            this.txtBeneficiario = new System.Windows.Forms.TextBox();
            this.txtFechaPago = new System.Windows.Forms.TextBox();
            this.txtMetodoPago = new System.Windows.Forms.TextBox();
            this.txtTotalDeposito = new System.Windows.Forms.TextBox();
            this.txtMoneda = new System.Windows.Forms.TextBox();
            this.txtTipoCambio = new System.Windows.Forms.TextBox();
            this.txtBancoOrigen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCuentaOrigen = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtMesAno = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chkContabilizado = new System.Windows.Forms.CheckBox();
            this.validacionesGeneralTableAdapter1 = new winAppSAIC.Catalogos.dbSAICBPO_CatalogosValidacionDataSetTableAdapters.ValidacionesGeneralTableAdapter();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.stpFactSelFacturasARelacionarSATBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn46 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn45 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn22 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn23 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn24 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn25 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn26 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn27 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn28 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn29 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn30 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn31 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn32 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn33 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn34 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn35 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn36 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn37 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn38 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn39 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn40 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn41 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn42 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtIdSolicitud = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFacturas = new DevExpress.XtraEditors.GridLookUpEdit();
            this.stpFactSelHeaderFacturasTimbrarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvFacturas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdHeaderFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSolicitudFactura0 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSerie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFolio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRazonSocialFronting = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescTipoBeneficiario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RazonSocialBeneficiario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdControlOperacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescEstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreCompletoOperador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn44 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vwFactHeaderFacturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtEstatus = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.vwFactHeaderFacturasTableAdapter = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.vwFactHeaderFacturasTableAdapter();
            this.stpFactSelDetailFacturasTableAdapter = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelDetailFacturasTableAdapter();
            this.stpFactSelDerechosAccesoOperadorFacturacionTableAdapter1 = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelDerechosAccesoOperadorFacturacionTableAdapter();
            this.spSoloRespuesta1 = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.spSoloRespuesta();
            this.stpFactSelControlOperacionesFacturasTableAdapter1 = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelControlOperacionesFacturasTableAdapter();
            this.stpFactSelGenerarFacturaTableAdapter1 = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelGenerarFacturaTableAdapter();
            this.stpFactSelFacturasARelacionarSATTableAdapter = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelFacturasARelacionarSATTableAdapter();
            this.splashSMProcesando = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::winAppSAIC.frmxCargandoInformacion), true, true);
            this.txtOperador = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.stpFactSelComprobantesFacturaTableAdapter1 = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelComprobantesFacturaTableAdapter();
            this.label17 = new System.Windows.Forms.Label();
            this.txtBancoDestino = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtUsoCFDI = new DevExpress.XtraEditors.GridLookUpEdit();
            this.stpFactSelUsoCFDIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdFactUsoCFDI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClave = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.stpFactSelConceptoTenedoraBeneficiarioFiltroTableAdapter = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelConceptoTenedoraBeneficiarioFiltroTableAdapter();
            this.stpFactSelUsoCFDITableAdapter = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelUsoCFDITableAdapter();
            this.btnConcepto = new DevExpress.XtraEditors.SimpleButton();
            this.stpFactSelComprobantePagoFacturaTableAdapter1 = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelComprobantePagoFacturaTableAdapter();
            this.stpFactSelHeaderFacturasTimbrarTableAdapter = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelHeaderFacturasTimbrarTableAdapter();
            this.dtFechaIni = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.dbSAICBPOValidacionDataSet1 = new winAppSAIC.dbSAICBPOValidacionDataSet();
            this.stpSelEstatusNominaContabilizadaTableAdapter1 = new winAppSAIC.dbSAICBPOValidacionDataSetTableAdapters.stpSelEstatusNominaContabilizadaTableAdapter();
            this.stpSelParametroTableAdapter1 = new winAppSAIC.dbSAICBPOValidacionDataSetTableAdapters.stpSelParametroTableAdapter();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.stpFactSelGenerarFactura2020TableAdapter1 = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelGenerarFactura2020TableAdapter();
            this.txtPeriodicidad = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grConceptos)).BeginInit();
            this.grConceptos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvConceptos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelDetailFacturasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelConceptoTenedoraBeneficiarioFiltroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelFacturasARelacionarSATBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFacturas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelHeaderFacturasTimbrarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwFactHeaderFacturasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsoCFDI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelUsoCFDIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOValidacionDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar1
            // 
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
            // 
            // bar3
            // 
            this.bar3.BarName = "Main menu";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.OptionsBar.MultiLine = true;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Main menu";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.btnCancelarFactura,
            this.btnFacturar,
            this.btnCancelarTimbre,
            this.btnContabilizar,
            this.btnDescontabilizar,
            this.btnComprobante,
            this.btnDescargar,
            this.btnVisualizarErrores});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(844, 27);
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
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // btnCancelarFactura
            // 
            this.btnCancelarFactura.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarFactura.Image")));
            this.btnCancelarFactura.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelarFactura.Name = "btnCancelarFactura";
            this.btnCancelarFactura.Size = new System.Drawing.Size(119, 24);
            this.btnCancelarFactura.Text = "Cancelar Factura";
            this.btnCancelarFactura.Visible = false;
            this.btnCancelarFactura.Click += new System.EventHandler(this.btnCancelarFactura_Click);
            // 
            // btnFacturar
            // 
            this.btnFacturar.Image = ((System.Drawing.Image)(resources.GetObject("btnFacturar.Image")));
            this.btnFacturar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(72, 24);
            this.btnFacturar.Text = "Timbrar";
            this.btnFacturar.Visible = false;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // btnCancelarTimbre
            // 
            this.btnCancelarTimbre.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarTimbre.Image")));
            this.btnCancelarTimbre.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelarTimbre.Name = "btnCancelarTimbre";
            this.btnCancelarTimbre.Size = new System.Drawing.Size(117, 24);
            this.btnCancelarTimbre.Text = "Cancelar Timbre";
            this.btnCancelarTimbre.Visible = false;
            this.btnCancelarTimbre.Click += new System.EventHandler(this.btnCancelarTimbre_Click);
            // 
            // btnContabilizar
            // 
            this.btnContabilizar.Image = ((System.Drawing.Image)(resources.GetObject("btnContabilizar.Image")));
            this.btnContabilizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnContabilizar.Name = "btnContabilizar";
            this.btnContabilizar.Size = new System.Drawing.Size(94, 24);
            this.btnContabilizar.Text = "Contabilizar";
            this.btnContabilizar.Visible = false;
            this.btnContabilizar.Click += new System.EventHandler(this.btnContabilizar_Click);
            // 
            // btnDescontabilizar
            // 
            this.btnDescontabilizar.Image = ((System.Drawing.Image)(resources.GetObject("btnDescontabilizar.Image")));
            this.btnDescontabilizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDescontabilizar.Name = "btnDescontabilizar";
            this.btnDescontabilizar.Size = new System.Drawing.Size(111, 24);
            this.btnDescontabilizar.Text = "Descontabilizar";
            this.btnDescontabilizar.Visible = false;
            this.btnDescontabilizar.Click += new System.EventHandler(this.btnDescontabilizar_Click);
            // 
            // btnComprobante
            // 
            this.btnComprobante.Image = global::winAppSAIC.Properties.Resources.saveHS;
            this.btnComprobante.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnComprobante.Name = "btnComprobante";
            this.btnComprobante.Size = new System.Drawing.Size(160, 24);
            this.btnComprobante.Text = "Descargar Comprobante";
            this.btnComprobante.Click += new System.EventHandler(this.btnComprobante_Click);
            // 
            // btnDescargar
            // 
            this.btnDescargar.Image = ((System.Drawing.Image)(resources.GetObject("btnDescargar.Image")));
            this.btnDescargar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.Size = new System.Drawing.Size(106, 24);
            this.btnDescargar.Text = "Decargar CFDI";
            this.btnDescargar.Visible = false;
            this.btnDescargar.Click += new System.EventHandler(this.btnDescargar_Click);
            // 
            // btnVisualizarErrores
            // 
            this.btnVisualizarErrores.Image = global::winAppSAIC.Properties.Resources.VerificarErrores;
            this.btnVisualizarErrores.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVisualizarErrores.Name = "btnVisualizarErrores";
            this.btnVisualizarErrores.Size = new System.Drawing.Size(173, 24);
            this.btnVisualizarErrores.Text = "Visualizar Errores Timbrado";
            this.btnVisualizarErrores.Visible = false;
            this.btnVisualizarErrores.Click += new System.EventHandler(this.btnVisualizarErrores_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(661, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 162;
            this.label7.Text = "Tipo Cambio:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(257, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 13);
            this.label13.TabIndex = 158;
            this.label13.Text = "Beneficiario:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 13);
            this.label12.TabIndex = 156;
            this.label12.Text = "Tipo Beneficiario:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(480, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 148;
            this.label6.Text = "Moneda:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 146;
            this.label5.Text = "Método Pago:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(257, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 144;
            this.label8.Text = "Forma Pago:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(447, 105);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 13);
            this.label14.TabIndex = 142;
            this.label14.Text = "Fecha de Pago:";
            // 
            // lblTenedora
            // 
            this.lblTenedora.AutoSize = true;
            this.lblTenedora.Location = new System.Drawing.Point(48, 57);
            this.lblTenedora.Name = "lblTenedora";
            this.lblTenedora.Size = new System.Drawing.Size(70, 13);
            this.lblTenedora.TabIndex = 138;
            this.lblTenedora.Text = "Facturadora:";
            // 
            // grConceptos
            // 
            this.grConceptos.Controls.Add(this.gvConceptos);
            this.grConceptos.Location = new System.Drawing.Point(12, 236);
            this.grConceptos.Name = "grConceptos";
            this.grConceptos.Size = new System.Drawing.Size(816, 151);
            this.grConceptos.TabIndex = 137;
            this.grConceptos.Text = "Conceptos";
            // 
            // gvConceptos
            // 
            this.gvConceptos.DataSource = this.stpFactSelDetailFacturasBindingSource;
            this.gvConceptos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvConceptos.Location = new System.Drawing.Point(2, 20);
            this.gvConceptos.MainView = this.gridView1;
            this.gvConceptos.Name = "gvConceptos";
            this.gvConceptos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemGridLookUpEdit1});
            this.gvConceptos.Size = new System.Drawing.Size(812, 129);
            this.gvConceptos.TabIndex = 19;
            this.gvConceptos.Tag = "";
            this.gvConceptos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // stpFactSelDetailFacturasBindingSource
            // 
            this.stpFactSelDetailFacturasBindingSource.DataMember = "stpFactSelDetailFacturas";
            this.stpFactSelDetailFacturasBindingSource.DataSource = this.dbSAICBPOFactura;
            // 
            // dbSAICBPOFactura
            // 
            this.dbSAICBPOFactura.DataSetName = "dbSAICBPOFactura";
            this.dbSAICBPOFactura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdDetailFactura,
            this.colIdHeaderFactura2,
            this.colCantidad,
            this.colIdUnidad,
            this.colNombre,
            this.gridColumn43,
            this.colComplemento,
            this.colPrecioUnitario,
            this.colIVA,
            this.colTotal3,
            this.colISN,
            this.colprossat,
            this.colRetencion});
            this.gridView1.GridControl = this.gvConceptos;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, null, null, "C2"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, null, null, "C2"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", null, "C2")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIdDetailFactura
            // 
            this.colIdDetailFactura.FieldName = "IdDetailFactura";
            this.colIdDetailFactura.Name = "colIdDetailFactura";
            // 
            // colIdHeaderFactura2
            // 
            this.colIdHeaderFactura2.FieldName = "IdHeaderFactura";
            this.colIdHeaderFactura2.Name = "colIdHeaderFactura2";
            // 
            // colCantidad
            // 
            this.colCantidad.Caption = "CANT.";
            this.colCantidad.FieldName = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.Visible = true;
            this.colCantidad.VisibleIndex = 0;
            this.colCantidad.Width = 48;
            // 
            // colIdUnidad
            // 
            this.colIdUnidad.FieldName = "IdUnidad";
            this.colIdUnidad.Name = "colIdUnidad";
            // 
            // colNombre
            // 
            this.colNombre.Caption = "UNIDAD";
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 1;
            this.colNombre.Width = 71;
            // 
            // gridColumn43
            // 
            this.gridColumn43.Caption = "gridColumn43";
            this.gridColumn43.FieldName = "IdConceptoBeneficiario";
            this.gridColumn43.Name = "gridColumn43";
            // 
            // colComplemento
            // 
            this.colComplemento.Caption = "CONCEPTO";
            this.colComplemento.FieldName = "Complemento";
            this.colComplemento.Name = "colComplemento";
            this.colComplemento.Visible = true;
            this.colComplemento.VisibleIndex = 3;
            this.colComplemento.Width = 185;
            // 
            // colPrecioUnitario
            // 
            this.colPrecioUnitario.Caption = "PRECIO UNITARIO";
            this.colPrecioUnitario.DisplayFormat.FormatString = "c2";
            this.colPrecioUnitario.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrecioUnitario.FieldName = "PrecioUnitario";
            this.colPrecioUnitario.Name = "colPrecioUnitario";
            this.colPrecioUnitario.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PrecioUnitario", "{0:c2}")});
            this.colPrecioUnitario.Visible = true;
            this.colPrecioUnitario.VisibleIndex = 4;
            this.colPrecioUnitario.Width = 109;
            // 
            // colIVA
            // 
            this.colIVA.DisplayFormat.FormatString = "c2";
            this.colIVA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colIVA.FieldName = "IVA";
            this.colIVA.Name = "colIVA";
            this.colIVA.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "IVA", "{0:c2}")});
            this.colIVA.Visible = true;
            this.colIVA.VisibleIndex = 5;
            this.colIVA.Width = 65;
            // 
            // colTotal3
            // 
            this.colTotal3.Caption = "TOTAL";
            this.colTotal3.DisplayFormat.FormatString = "c2";
            this.colTotal3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotal3.FieldName = "Total";
            this.colTotal3.Name = "colTotal3";
            this.colTotal3.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", "{0:c2}")});
            this.colTotal3.Visible = true;
            this.colTotal3.VisibleIndex = 7;
            this.colTotal3.Width = 84;
            // 
            // colISN
            // 
            this.colISN.Caption = "RETENCION ISN";
            this.colISN.DisplayFormat.FormatString = "c2";
            this.colISN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colISN.FieldName = "Descuento";
            this.colISN.Name = "colISN";
            this.colISN.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Descuento", "{0:c2}")});
            this.colISN.Visible = true;
            this.colISN.VisibleIndex = 8;
            this.colISN.Width = 79;
            // 
            // colprossat
            // 
            this.colprossat.Caption = "PROD. SAT";
            this.colprossat.FieldName = "ProductoServicioSAT";
            this.colprossat.Name = "colprossat";
            this.colprossat.Visible = true;
            this.colprossat.VisibleIndex = 2;
            this.colprossat.Width = 65;
            // 
            // colRetencion
            // 
            this.colRetencion.Caption = "RETENCION IVA";
            this.colRetencion.DisplayFormat.FormatString = "C2";
            this.colRetencion.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colRetencion.FieldName = "Retencion";
            this.colRetencion.Name = "colRetencion";
            this.colRetencion.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Retencion", "{0:c2}")});
            this.colRetencion.Visible = true;
            this.colRetencion.VisibleIndex = 6;
            this.colRetencion.Width = 90;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.DataSource = this.stpFactSelConceptoTenedoraBeneficiarioFiltroBindingSource;
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.ValueMember = "DescConceptoInterno";
            this.repositoryItemGridLookUpEdit1.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // stpFactSelConceptoTenedoraBeneficiarioFiltroBindingSource
            // 
            this.stpFactSelConceptoTenedoraBeneficiarioFiltroBindingSource.DataMember = "stpFactSelConceptoTenedoraBeneficiarioFiltro";
            this.stpFactSelConceptoTenedoraBeneficiarioFiltroBindingSource.DataSource = this.dbSAICBPOFactura;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(65, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 163;
            this.label1.Text = "Facturas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(650, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 180;
            this.label2.Text = "Total Deposito:";
            // 
            // txtFronting
            // 
            this.txtFronting.BackColor = System.Drawing.Color.LightYellow;
            this.txtFronting.Location = new System.Drawing.Point(115, 54);
            this.txtFronting.Name = "txtFronting";
            this.txtFronting.ReadOnly = true;
            this.txtFronting.Size = new System.Drawing.Size(697, 21);
            this.txtFronting.TabIndex = 186;
            // 
            // txtTipoBeneficiarios
            // 
            this.txtTipoBeneficiarios.BackColor = System.Drawing.Color.LightYellow;
            this.txtTipoBeneficiarios.Location = new System.Drawing.Point(115, 78);
            this.txtTipoBeneficiarios.Name = "txtTipoBeneficiarios";
            this.txtTipoBeneficiarios.ReadOnly = true;
            this.txtTipoBeneficiarios.Size = new System.Drawing.Size(123, 21);
            this.txtTipoBeneficiarios.TabIndex = 187;
            // 
            // txtFormaPago
            // 
            this.txtFormaPago.BackColor = System.Drawing.Color.LightYellow;
            this.txtFormaPago.Location = new System.Drawing.Point(320, 127);
            this.txtFormaPago.Name = "txtFormaPago";
            this.txtFormaPago.ReadOnly = true;
            this.txtFormaPago.Size = new System.Drawing.Size(121, 21);
            this.txtFormaPago.TabIndex = 188;
            // 
            // txtBeneficiario
            // 
            this.txtBeneficiario.BackColor = System.Drawing.Color.LightYellow;
            this.txtBeneficiario.Location = new System.Drawing.Point(320, 78);
            this.txtBeneficiario.Name = "txtBeneficiario";
            this.txtBeneficiario.ReadOnly = true;
            this.txtBeneficiario.Size = new System.Drawing.Size(492, 21);
            this.txtBeneficiario.TabIndex = 189;
            this.txtBeneficiario.TextChanged += new System.EventHandler(this.txtBeneficiario_TextChanged);
            // 
            // txtFechaPago
            // 
            this.txtFechaPago.BackColor = System.Drawing.Color.LightYellow;
            this.txtFechaPago.Location = new System.Drawing.Point(526, 102);
            this.txtFechaPago.Name = "txtFechaPago";
            this.txtFechaPago.ReadOnly = true;
            this.txtFechaPago.Size = new System.Drawing.Size(123, 21);
            this.txtFechaPago.TabIndex = 192;
            // 
            // txtMetodoPago
            // 
            this.txtMetodoPago.BackColor = System.Drawing.Color.LightYellow;
            this.txtMetodoPago.Location = new System.Drawing.Point(115, 127);
            this.txtMetodoPago.Name = "txtMetodoPago";
            this.txtMetodoPago.ReadOnly = true;
            this.txtMetodoPago.Size = new System.Drawing.Size(123, 21);
            this.txtMetodoPago.TabIndex = 193;
            // 
            // txtTotalDeposito
            // 
            this.txtTotalDeposito.BackColor = System.Drawing.Color.LightYellow;
            this.txtTotalDeposito.Location = new System.Drawing.Point(728, 154);
            this.txtTotalDeposito.Name = "txtTotalDeposito";
            this.txtTotalDeposito.ReadOnly = true;
            this.txtTotalDeposito.Size = new System.Drawing.Size(84, 21);
            this.txtTotalDeposito.TabIndex = 194;
            // 
            // txtMoneda
            // 
            this.txtMoneda.BackColor = System.Drawing.Color.LightYellow;
            this.txtMoneda.Location = new System.Drawing.Point(526, 127);
            this.txtMoneda.Name = "txtMoneda";
            this.txtMoneda.ReadOnly = true;
            this.txtMoneda.Size = new System.Drawing.Size(123, 21);
            this.txtMoneda.TabIndex = 195;
            this.txtMoneda.Text = " ";
            // 
            // txtTipoCambio
            // 
            this.txtTipoCambio.BackColor = System.Drawing.Color.LightYellow;
            this.txtTipoCambio.Location = new System.Drawing.Point(728, 127);
            this.txtTipoCambio.Name = "txtTipoCambio";
            this.txtTipoCambio.ReadOnly = true;
            this.txtTipoCambio.Size = new System.Drawing.Size(84, 21);
            this.txtTipoCambio.TabIndex = 196;
            // 
            // txtBancoOrigen
            // 
            this.txtBancoOrigen.BackColor = System.Drawing.Color.LightYellow;
            this.txtBancoOrigen.Location = new System.Drawing.Point(115, 151);
            this.txtBancoOrigen.Name = "txtBancoOrigen";
            this.txtBancoOrigen.ReadOnly = true;
            this.txtBancoOrigen.Size = new System.Drawing.Size(123, 21);
            this.txtBancoOrigen.TabIndex = 200;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 199;
            this.label4.Text = "Banco Origen:";
            // 
            // txtCuentaOrigen
            // 
            this.txtCuentaOrigen.BackColor = System.Drawing.Color.LightYellow;
            this.txtCuentaOrigen.Location = new System.Drawing.Point(320, 151);
            this.txtCuentaOrigen.Name = "txtCuentaOrigen";
            this.txtCuentaOrigen.ReadOnly = true;
            this.txtCuentaOrigen.Size = new System.Drawing.Size(121, 21);
            this.txtCuentaOrigen.TabIndex = 202;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(244, 154);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 13);
            this.label15.TabIndex = 201;
            this.label15.Text = "Cuenta Origen:";
            // 
            // txtMesAno
            // 
            this.txtMesAno.BackColor = System.Drawing.Color.LightYellow;
            this.txtMesAno.Location = new System.Drawing.Point(320, 176);
            this.txtMesAno.Name = "txtMesAno";
            this.txtMesAno.ReadOnly = true;
            this.txtMesAno.Size = new System.Drawing.Size(121, 21);
            this.txtMesAno.TabIndex = 204;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(205, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 13);
            this.label9.TabIndex = 203;
            this.label9.Text = "Mes/Año Contabilizado:";
            // 
            // chkContabilizado
            // 
            this.chkContabilizado.AutoSize = true;
            this.chkContabilizado.Enabled = false;
            this.chkContabilizado.Location = new System.Drawing.Point(115, 178);
            this.chkContabilizado.Name = "chkContabilizado";
            this.chkContabilizado.Size = new System.Drawing.Size(90, 17);
            this.chkContabilizado.TabIndex = 205;
            this.chkContabilizado.Text = "Contabilizado";
            this.chkContabilizado.UseVisualStyleBackColor = true;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Location = new System.Drawing.Point(13, 393);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(816, 134);
            this.groupControl1.TabIndex = 167;
            this.groupControl1.Text = "Facturas Relacionadas SAT";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.stpFactSelFacturasARelacionarSATBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 20);
            this.gridControl1.MainView = this.gridView4;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(812, 112);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // stpFactSelFacturasARelacionarSATBindingSource
            // 
            this.stpFactSelFacturasARelacionarSATBindingSource.DataMember = "stpFactSelFacturasARelacionarSAT";
            this.stpFactSelFacturasARelacionarSATBindingSource.DataSource = this.dbSAICBPOFactura;
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn46,
            this.gridColumn45,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn15,
            this.gridColumn16,
            this.gridColumn17,
            this.gridColumn18,
            this.gridColumn19,
            this.gridColumn20,
            this.gridColumn21,
            this.gridColumn22,
            this.gridColumn23,
            this.gridColumn24,
            this.gridColumn25,
            this.gridColumn26,
            this.gridColumn27,
            this.gridColumn28,
            this.gridColumn29,
            this.gridColumn30,
            this.gridColumn31,
            this.gridColumn32,
            this.gridColumn33,
            this.gridColumn34,
            this.gridColumn35,
            this.gridColumn36,
            this.gridColumn37,
            this.gridColumn38,
            this.gridColumn39,
            this.gridColumn40,
            this.gridColumn41,
            this.gridColumn42});
            this.gridView4.GridControl = this.gridControl1;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsBehavior.Editable = false;
            this.gridView4.OptionsView.ColumnAutoWidth = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            this.gridView4.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn5, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Id Factura";
            this.gridColumn1.FieldName = "IdHeaderFactura";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "IdSolicitudFactura";
            this.gridColumn2.Name = "gridColumn2";
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Id Control";
            this.gridColumn3.FieldName = "IdControlOperacion";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn46
            // 
            this.gridColumn46.Caption = "Serie";
            this.gridColumn46.FieldName = "Serie";
            this.gridColumn46.Name = "gridColumn46";
            this.gridColumn46.Visible = true;
            this.gridColumn46.VisibleIndex = 2;
            // 
            // gridColumn45
            // 
            this.gridColumn45.Caption = "Folio";
            this.gridColumn45.FieldName = "FolioInterno";
            this.gridColumn45.Name = "gridColumn45";
            this.gridColumn45.Visible = true;
            this.gridColumn45.VisibleIndex = 3;
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "IdFacturador";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Facturadora";
            this.gridColumn5.FieldName = "RazonSocialFronting";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Width = 119;
            // 
            // gridColumn6
            // 
            this.gridColumn6.FieldName = "IdBeneficiario";
            this.gridColumn6.Name = "gridColumn6";
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Beneficiario";
            this.gridColumn7.FieldName = "NombreComercialBeneficiario";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 4;
            this.gridColumn7.Width = 128;
            // 
            // gridColumn8
            // 
            this.gridColumn8.FieldName = "IdTipoBeneficiario";
            this.gridColumn8.Name = "gridColumn8";
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Tipo Beneficiario";
            this.gridColumn9.FieldName = "DescTipoBeneficiario";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 5;
            this.gridColumn9.Width = 125;
            // 
            // gridColumn10
            // 
            this.gridColumn10.FieldName = "IdMetodoPago";
            this.gridColumn10.Name = "gridColumn10";
            // 
            // gridColumn11
            // 
            this.gridColumn11.FieldName = "ClaveMetodoPago";
            this.gridColumn11.Name = "gridColumn11";
            // 
            // gridColumn12
            // 
            this.gridColumn12.FieldName = "DescMetodoPago";
            this.gridColumn12.Name = "gridColumn12";
            // 
            // gridColumn13
            // 
            this.gridColumn13.FieldName = "IdFormaPago";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Width = 117;
            // 
            // gridColumn14
            // 
            this.gridColumn14.FieldName = "DescFormaPago";
            this.gridColumn14.Name = "gridColumn14";
            // 
            // gridColumn15
            // 
            this.gridColumn15.FieldName = "IdMoneda";
            this.gridColumn15.Name = "gridColumn15";
            // 
            // gridColumn16
            // 
            this.gridColumn16.DisplayFormat.FormatString = "C2";
            this.gridColumn16.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn16.FieldName = "TipoCambio";
            this.gridColumn16.Name = "gridColumn16";
            // 
            // gridColumn17
            // 
            this.gridColumn17.FieldName = "FechaPago";
            this.gridColumn17.Name = "gridColumn17";
            // 
            // gridColumn18
            // 
            this.gridColumn18.Caption = "Subtotal";
            this.gridColumn18.DisplayFormat.FormatString = "C2";
            this.gridColumn18.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn18.FieldName = "SubTotal";
            this.gridColumn18.Name = "gridColumn18";
            this.gridColumn18.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SubTotal", "SUM={0:C2}")});
            this.gridColumn18.Visible = true;
            this.gridColumn18.VisibleIndex = 6;
            // 
            // gridColumn19
            // 
            this.gridColumn19.Caption = "IVA";
            this.gridColumn19.DisplayFormat.FormatString = "C2";
            this.gridColumn19.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn19.FieldName = "IVA";
            this.gridColumn19.Name = "gridColumn19";
            this.gridColumn19.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "IVA", "SUM={0:C2}")});
            this.gridColumn19.Visible = true;
            this.gridColumn19.VisibleIndex = 7;
            // 
            // gridColumn20
            // 
            this.gridColumn20.Caption = "Total";
            this.gridColumn20.DisplayFormat.FormatString = "C2";
            this.gridColumn20.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn20.FieldName = "Total";
            this.gridColumn20.Name = "gridColumn20";
            this.gridColumn20.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", "SUM={0:C2}")});
            this.gridColumn20.Visible = true;
            this.gridColumn20.VisibleIndex = 8;
            // 
            // gridColumn21
            // 
            this.gridColumn21.FieldName = "ImporteConLetra";
            this.gridColumn21.Name = "gridColumn21";
            // 
            // gridColumn22
            // 
            this.gridColumn22.FieldName = "IdHeaderFacturaRelacion";
            this.gridColumn22.Name = "gridColumn22";
            // 
            // gridColumn23
            // 
            this.gridColumn23.FieldName = "IdTipoRelacion";
            this.gridColumn23.Name = "gridColumn23";
            // 
            // gridColumn24
            // 
            this.gridColumn24.Caption = "Tipo Relación";
            this.gridColumn24.FieldName = "DescTipoRelacion";
            this.gridColumn24.Name = "gridColumn24";
            this.gridColumn24.Visible = true;
            this.gridColumn24.VisibleIndex = 9;
            this.gridColumn24.Width = 94;
            // 
            // gridColumn25
            // 
            this.gridColumn25.Caption = "Total Depositado";
            this.gridColumn25.DisplayFormat.FormatString = "C2";
            this.gridColumn25.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn25.FieldName = "TotalDepositado";
            this.gridColumn25.Name = "gridColumn25";
            this.gridColumn25.Visible = true;
            this.gridColumn25.VisibleIndex = 10;
            this.gridColumn25.Width = 115;
            // 
            // gridColumn26
            // 
            this.gridColumn26.FieldName = "IdEstatus";
            this.gridColumn26.Name = "gridColumn26";
            // 
            // gridColumn27
            // 
            this.gridColumn27.FieldName = "DescEstatus";
            this.gridColumn27.Name = "gridColumn27";
            // 
            // gridColumn28
            // 
            this.gridColumn28.FieldName = "Comentarios";
            this.gridColumn28.Name = "gridColumn28";
            // 
            // gridColumn29
            // 
            this.gridColumn29.FieldName = "IdBancoOrigen";
            this.gridColumn29.Name = "gridColumn29";
            // 
            // gridColumn30
            // 
            this.gridColumn30.Caption = "Banco Origen";
            this.gridColumn30.FieldName = "NombreBancoOrI";
            this.gridColumn30.Name = "gridColumn30";
            this.gridColumn30.Visible = true;
            this.gridColumn30.VisibleIndex = 11;
            this.gridColumn30.Width = 100;
            // 
            // gridColumn31
            // 
            this.gridColumn31.FieldName = "IdBancoDestino";
            this.gridColumn31.Name = "gridColumn31";
            // 
            // gridColumn32
            // 
            this.gridColumn32.Caption = "Banco Destino";
            this.gridColumn32.FieldName = "NombreBancoDES";
            this.gridColumn32.Name = "gridColumn32";
            this.gridColumn32.Visible = true;
            this.gridColumn32.VisibleIndex = 12;
            this.gridColumn32.Width = 94;
            // 
            // gridColumn33
            // 
            this.gridColumn33.FieldName = "Archivo";
            this.gridColumn33.Name = "gridColumn33";
            // 
            // gridColumn34
            // 
            this.gridColumn34.FieldName = "IdOperador";
            this.gridColumn34.Name = "gridColumn34";
            // 
            // gridColumn35
            // 
            this.gridColumn35.Caption = "Operador";
            this.gridColumn35.FieldName = "NombreCompletoOperador";
            this.gridColumn35.Name = "gridColumn35";
            this.gridColumn35.Visible = true;
            this.gridColumn35.VisibleIndex = 13;
            this.gridColumn35.Width = 102;
            // 
            // gridColumn36
            // 
            this.gridColumn36.Caption = "Fecha Creación";
            this.gridColumn36.FieldName = "FechaCreacion";
            this.gridColumn36.Name = "gridColumn36";
            this.gridColumn36.Visible = true;
            this.gridColumn36.VisibleIndex = 15;
            this.gridColumn36.Width = 124;
            // 
            // gridColumn37
            // 
            this.gridColumn37.FieldName = "IdFacturaCFDI";
            this.gridColumn37.Name = "gridColumn37";
            // 
            // gridColumn38
            // 
            this.gridColumn38.FieldName = "AnoContabilidad";
            this.gridColumn38.Name = "gridColumn38";
            // 
            // gridColumn39
            // 
            this.gridColumn39.FieldName = "MesContabilidad";
            this.gridColumn39.Name = "gridColumn39";
            // 
            // gridColumn40
            // 
            this.gridColumn40.FieldName = "FechaContabilidad";
            this.gridColumn40.Name = "gridColumn40";
            // 
            // gridColumn41
            // 
            this.gridColumn41.FieldName = "UUID";
            this.gridColumn41.Name = "gridColumn41";
            this.gridColumn41.Visible = true;
            this.gridColumn41.VisibleIndex = 14;
            this.gridColumn41.Width = 153;
            // 
            // gridColumn42
            // 
            this.gridColumn42.FieldName = "UUIDRelacion";
            this.gridColumn42.Name = "gridColumn42";
            // 
            // txtIdSolicitud
            // 
            this.txtIdSolicitud.BackColor = System.Drawing.Color.LightYellow;
            this.txtIdSolicitud.Location = new System.Drawing.Point(320, 31);
            this.txtIdSolicitud.Name = "txtIdSolicitud";
            this.txtIdSolicitud.ReadOnly = true;
            this.txtIdSolicitud.Size = new System.Drawing.Size(120, 21);
            this.txtIdSolicitud.TabIndex = 207;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 206;
            this.label3.Text = "No. Solicitud:";
            // 
            // cbFacturas
            // 
            this.cbFacturas.Location = new System.Drawing.Point(115, 31);
            this.cbFacturas.Name = "cbFacturas";
            this.cbFacturas.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbFacturas.Properties.DataSource = this.stpFactSelHeaderFacturasTimbrarBindingSource;
            this.cbFacturas.Properties.DisplayMember = "IdHeaderFactura";
            this.cbFacturas.Properties.NullText = "";
            this.cbFacturas.Properties.ValueMember = "IdHeaderFactura";
            this.cbFacturas.Properties.View = this.dgvFacturas;
            this.cbFacturas.Size = new System.Drawing.Size(123, 20);
            this.cbFacturas.TabIndex = 208;
            this.cbFacturas.EditValueChanged += new System.EventHandler(this.cbFacturas_EditValueChanged);
            // 
            // stpFactSelHeaderFacturasTimbrarBindingSource
            // 
            this.stpFactSelHeaderFacturasTimbrarBindingSource.DataMember = "stpFactSelHeaderFacturasTimbrar";
            this.stpFactSelHeaderFacturasTimbrarBindingSource.DataSource = this.dbSAICBPOFactura;
            // 
            // dgvFacturas
            // 
            this.dgvFacturas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdHeaderFactura,
            this.colIdSolicitudFactura0,
            this.colSerie,
            this.colFolio,
            this.colRazonSocialFronting,
            this.colDescTipoBeneficiario,
            this.RazonSocialBeneficiario,
            this.colIdControlOperacion,
            this.colTotal,
            this.colDescEstatus,
            this.colNombreCompletoOperador,
            this.gridColumn44});
            this.dgvFacturas.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.dgvFacturas.OptionsView.ColumnAutoWidth = false;
            this.dgvFacturas.OptionsView.ShowGroupPanel = false;
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
            // colIdSolicitudFactura0
            // 
            this.colIdSolicitudFactura0.Caption = "Id Solicitud";
            this.colIdSolicitudFactura0.FieldName = "IdSolicitudFactura";
            this.colIdSolicitudFactura0.Name = "colIdSolicitudFactura0";
            this.colIdSolicitudFactura0.Visible = true;
            this.colIdSolicitudFactura0.VisibleIndex = 1;
            // 
            // colSerie
            // 
            this.colSerie.Caption = "Serie";
            this.colSerie.FieldName = "Serie";
            this.colSerie.Name = "colSerie";
            this.colSerie.Visible = true;
            this.colSerie.VisibleIndex = 2;
            // 
            // colFolio
            // 
            this.colFolio.Caption = "Folio";
            this.colFolio.FieldName = "FolioInterno";
            this.colFolio.Name = "colFolio";
            this.colFolio.Visible = true;
            this.colFolio.VisibleIndex = 3;
            // 
            // colRazonSocialFronting
            // 
            this.colRazonSocialFronting.Caption = "Fronting";
            this.colRazonSocialFronting.FieldName = "NombreComercialFronting";
            this.colRazonSocialFronting.Name = "colRazonSocialFronting";
            this.colRazonSocialFronting.Visible = true;
            this.colRazonSocialFronting.VisibleIndex = 4;
            this.colRazonSocialFronting.Width = 266;
            // 
            // colDescTipoBeneficiario
            // 
            this.colDescTipoBeneficiario.Caption = "Tipo Beneficiario";
            this.colDescTipoBeneficiario.FieldName = "DescTipoBeneficiario";
            this.colDescTipoBeneficiario.Name = "colDescTipoBeneficiario";
            this.colDescTipoBeneficiario.Visible = true;
            this.colDescTipoBeneficiario.VisibleIndex = 6;
            this.colDescTipoBeneficiario.Width = 126;
            // 
            // RazonSocialBeneficiario
            // 
            this.RazonSocialBeneficiario.Caption = "Beneficiario";
            this.RazonSocialBeneficiario.FieldName = "NombreComercialBeneficiario";
            this.RazonSocialBeneficiario.Name = "RazonSocialBeneficiario";
            this.RazonSocialBeneficiario.Visible = true;
            this.RazonSocialBeneficiario.VisibleIndex = 5;
            this.RazonSocialBeneficiario.Width = 323;
            // 
            // colIdControlOperacion
            // 
            this.colIdControlOperacion.Caption = "No. Control";
            this.colIdControlOperacion.FieldName = "IdControlOperacion";
            this.colIdControlOperacion.Name = "colIdControlOperacion";
            this.colIdControlOperacion.Visible = true;
            this.colIdControlOperacion.VisibleIndex = 7;
            this.colIdControlOperacion.Width = 73;
            // 
            // colTotal
            // 
            this.colTotal.Caption = "Total";
            this.colTotal.DisplayFormat.FormatString = "c2";
            this.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotal.FieldName = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 8;
            this.colTotal.Width = 67;
            // 
            // colDescEstatus
            // 
            this.colDescEstatus.Caption = "Estatus";
            this.colDescEstatus.FieldName = "DescEstatus";
            this.colDescEstatus.Name = "colDescEstatus";
            this.colDescEstatus.Visible = true;
            this.colDescEstatus.VisibleIndex = 9;
            this.colDescEstatus.Width = 128;
            // 
            // colNombreCompletoOperador
            // 
            this.colNombreCompletoOperador.Caption = "Operador";
            this.colNombreCompletoOperador.FieldName = "NombreCompletoOperador";
            this.colNombreCompletoOperador.Name = "colNombreCompletoOperador";
            this.colNombreCompletoOperador.Visible = true;
            this.colNombreCompletoOperador.VisibleIndex = 10;
            this.colNombreCompletoOperador.Width = 221;
            // 
            // gridColumn44
            // 
            this.gridColumn44.Caption = "gridColumn44";
            this.gridColumn44.FieldName = "IdEstatus";
            this.gridColumn44.Name = "gridColumn44";
            // 
            // vwFactHeaderFacturasBindingSource
            // 
            this.vwFactHeaderFacturasBindingSource.DataMember = "vwFactHeaderFacturas";
            this.vwFactHeaderFacturasBindingSource.DataSource = this.dbSAICBPOFactura;
            // 
            // txtEstatus
            // 
            this.txtEstatus.BackColor = System.Drawing.Color.LightYellow;
            this.txtEstatus.Location = new System.Drawing.Point(526, 176);
            this.txtEstatus.Name = "txtEstatus";
            this.txtEstatus.ReadOnly = true;
            this.txtEstatus.Size = new System.Drawing.Size(123, 21);
            this.txtEstatus.TabIndex = 210;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(482, 179);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 209;
            this.label10.Text = "Estatus:";
            // 
            // vwFactHeaderFacturasTableAdapter
            // 
            this.vwFactHeaderFacturasTableAdapter.ClearBeforeFill = true;
            // 
            // stpFactSelDetailFacturasTableAdapter
            // 
            this.stpFactSelDetailFacturasTableAdapter.ClearBeforeFill = true;
            // 
            // stpFactSelDerechosAccesoOperadorFacturacionTableAdapter1
            // 
            this.stpFactSelDerechosAccesoOperadorFacturacionTableAdapter1.ClearBeforeFill = true;
            // 
            // stpFactSelControlOperacionesFacturasTableAdapter1
            // 
            this.stpFactSelControlOperacionesFacturasTableAdapter1.ClearBeforeFill = true;
            // 
            // stpFactSelGenerarFacturaTableAdapter1
            // 
            this.stpFactSelGenerarFacturaTableAdapter1.ClearBeforeFill = true;
            // 
            // stpFactSelFacturasARelacionarSATTableAdapter
            // 
            this.stpFactSelFacturasARelacionarSATTableAdapter.ClearBeforeFill = true;
            // 
            // splashSMProcesando
            // 
            this.splashSMProcesando.ClosingDelay = 500;
            // 
            // txtOperador
            // 
            this.txtOperador.BackColor = System.Drawing.Color.LightYellow;
            this.txtOperador.Location = new System.Drawing.Point(115, 201);
            this.txtOperador.Name = "txtOperador";
            this.txtOperador.ReadOnly = true;
            this.txtOperador.Size = new System.Drawing.Size(326, 21);
            this.txtOperador.TabIndex = 214;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(61, 204);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 13);
            this.label16.TabIndex = 213;
            this.label16.Text = "Operador:\r\n";
            // 
            // stpFactSelComprobantesFacturaTableAdapter1
            // 
            this.stpFactSelComprobantesFacturaTableAdapter1.ClearBeforeFill = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(61, 105);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 13);
            this.label17.TabIndex = 215;
            this.label17.Text = "Uso CFDI:\r\n";
            // 
            // txtBancoDestino
            // 
            this.txtBancoDestino.BackColor = System.Drawing.Color.LightYellow;
            this.txtBancoDestino.Location = new System.Drawing.Point(526, 151);
            this.txtBancoDestino.Name = "txtBancoDestino";
            this.txtBancoDestino.ReadOnly = true;
            this.txtBancoDestino.Size = new System.Drawing.Size(123, 21);
            this.txtBancoDestino.TabIndex = 218;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(450, 157);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(79, 13);
            this.label18.TabIndex = 217;
            this.label18.Text = "Banco Destino:";
            // 
            // txtSerie
            // 
            this.txtSerie.BackColor = System.Drawing.Color.LightYellow;
            this.txtSerie.Location = new System.Drawing.Point(728, 31);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.ReadOnly = true;
            this.txtSerie.Size = new System.Drawing.Size(84, 21);
            this.txtSerie.TabIndex = 220;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(669, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 219;
            this.label11.Text = "Serie/Folio:";
            // 
            // txtUsoCFDI
            // 
            this.txtUsoCFDI.Location = new System.Drawing.Point(115, 103);
            this.txtUsoCFDI.Name = "txtUsoCFDI";
            this.txtUsoCFDI.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtUsoCFDI.Properties.DataSource = this.stpFactSelUsoCFDIBindingSource;
            this.txtUsoCFDI.Properties.DisplayMember = "Desc";
            this.txtUsoCFDI.Properties.NullText = "";
            this.txtUsoCFDI.Properties.ValueMember = "IdFactUsoCFDI";
            this.txtUsoCFDI.Properties.View = this.gridView2;
            this.txtUsoCFDI.Size = new System.Drawing.Size(325, 20);
            this.txtUsoCFDI.TabIndex = 221;
            this.txtUsoCFDI.Tag = "Uso CFDI";
            this.txtUsoCFDI.EditValueChanged += new System.EventHandler(this.txtUsoCFDI_EditValueChanged);
            // 
            // stpFactSelUsoCFDIBindingSource
            // 
            this.stpFactSelUsoCFDIBindingSource.DataMember = "stpFactSelUsoCFDI";
            this.stpFactSelUsoCFDIBindingSource.DataSource = this.dbSAICBPOFactura;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdFactUsoCFDI,
            this.colDesc,
            this.colClave});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colIdFactUsoCFDI
            // 
            this.colIdFactUsoCFDI.Caption = "Id";
            this.colIdFactUsoCFDI.FieldName = "IdFactUsoCFDI";
            this.colIdFactUsoCFDI.Name = "colIdFactUsoCFDI";
            // 
            // colDesc
            // 
            this.colDesc.Caption = "Uso CFDI";
            this.colDesc.FieldName = "Desc";
            this.colDesc.Name = "colDesc";
            this.colDesc.Visible = true;
            this.colDesc.VisibleIndex = 0;
            // 
            // colClave
            // 
            this.colClave.Caption = "Clave";
            this.colClave.FieldName = "Clave";
            this.colClave.Name = "colClave";
            // 
            // txtProducto
            // 
            this.txtProducto.BackColor = System.Drawing.Color.LightYellow;
            this.txtProducto.Location = new System.Drawing.Point(526, 30);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.ReadOnly = true;
            this.txtProducto.Size = new System.Drawing.Size(123, 21);
            this.txtProducto.TabIndex = 223;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(475, 34);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(54, 13);
            this.label19.TabIndex = 222;
            this.label19.Text = "Producto:";
            // 
            // stpFactSelConceptoTenedoraBeneficiarioFiltroTableAdapter
            // 
            this.stpFactSelConceptoTenedoraBeneficiarioFiltroTableAdapter.ClearBeforeFill = true;
            // 
            // stpFactSelUsoCFDITableAdapter
            // 
            this.stpFactSelUsoCFDITableAdapter.ClearBeforeFill = true;
            // 
            // btnConcepto
            // 
            this.btnConcepto.Appearance.BackColor = System.Drawing.Color.White;
            this.btnConcepto.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConcepto.Appearance.Options.UseBackColor = true;
            this.btnConcepto.Appearance.Options.UseFont = true;
            this.btnConcepto.Appearance.Options.UseTextOptions = true;
            this.btnConcepto.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnConcepto.ImageOptions.ImageUri.Uri = "Refresh;Size16x16";
            this.btnConcepto.Location = new System.Drawing.Point(703, 201);
            this.btnConcepto.LookAndFeel.SkinName = "VS2010";
            this.btnConcepto.Name = "btnConcepto";
            this.btnConcepto.Size = new System.Drawing.Size(124, 28);
            this.btnConcepto.TabIndex = 224;
            this.btnConcepto.Text = "Actualizar Concepto";
            this.btnConcepto.Click += new System.EventHandler(this.btnConcepto_Click);
            // 
            // stpFactSelComprobantePagoFacturaTableAdapter1
            // 
            this.stpFactSelComprobantePagoFacturaTableAdapter1.ClearBeforeFill = true;
            // 
            // stpFactSelHeaderFacturasTimbrarTableAdapter
            // 
            this.stpFactSelHeaderFacturasTimbrarTableAdapter.ClearBeforeFill = true;
            // 
            // dtFechaIni
            // 
            this.dtFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaIni.Location = new System.Drawing.Point(526, 202);
            this.dtFechaIni.Name = "dtFechaIni";
            this.dtFechaIni.Size = new System.Drawing.Size(123, 21);
            this.dtFechaIni.TabIndex = 229;
            this.dtFechaIni.Tag = "Fecha de Pago";
            this.dtFechaIni.Value = new System.DateTime(2020, 1, 6, 0, 0, 0, 0);
            this.dtFechaIni.ValueChanged += new System.EventHandler(this.dtFechaIni_ValueChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(446, 206);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(78, 13);
            this.label20.TabIndex = 228;
            this.label20.Text = "Fecha Emisión:";
            this.label20.Click += new System.EventHandler(this.label20_Click);
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
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(653, 201);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(26, 23);
            this.simpleButton1.TabIndex = 231;
            this.simpleButton1.Visible = false;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // stpFactSelGenerarFactura2020TableAdapter1
            // 
            this.stpFactSelGenerarFactura2020TableAdapter1.ClearBeforeFill = true;
            // 
            // txtPeriodicidad
            // 
            this.txtPeriodicidad.BackColor = System.Drawing.Color.LightYellow;
            this.txtPeriodicidad.Location = new System.Drawing.Point(728, 103);
            this.txtPeriodicidad.Name = "txtPeriodicidad";
            this.txtPeriodicidad.ReadOnly = true;
            this.txtPeriodicidad.Size = new System.Drawing.Size(84, 21);
            this.txtPeriodicidad.TabIndex = 233;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(661, 105);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(68, 13);
            this.label21.TabIndex = 232;
            this.label21.Text = "Periodicidad:";
            // 
            // frmAdmonFacturasFC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 544);
            this.ControlBox = false;
            this.Controls.Add(this.txtPeriodicidad);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.dtFechaIni);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.btnConcepto);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtUsoCFDI);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtBancoDestino);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtOperador);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtEstatus);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbFacturas);
            this.Controls.Add(this.txtIdSolicitud);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.chkContabilizado);
            this.Controls.Add(this.txtMesAno);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCuentaOrigen);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtBancoOrigen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTipoCambio);
            this.Controls.Add(this.txtMoneda);
            this.Controls.Add(this.txtTotalDeposito);
            this.Controls.Add(this.txtMetodoPago);
            this.Controls.Add(this.txtFechaPago);
            this.Controls.Add(this.txtBeneficiario);
            this.Controls.Add(this.txtFormaPago);
            this.Controls.Add(this.txtTipoBeneficiarios);
            this.Controls.Add(this.txtFronting);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblTenedora);
            this.Controls.Add(this.grConceptos);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmAdmonFacturasFC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timbrar Facturas";
            this.Load += new System.EventHandler(this.frmAdmonFacturas_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grConceptos)).EndInit();
            this.grConceptos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvConceptos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelDetailFacturasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelConceptoTenedoraBeneficiarioFiltroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelFacturasARelacionarSATBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFacturas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelHeaderFacturasTimbrarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwFactHeaderFacturasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsoCFDI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelUsoCFDIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOValidacionDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton btnFacturar;
        private System.Windows.Forms.ToolStripButton btnCancelarTimbre;
        private System.Windows.Forms.ToolStripButton btnDescargar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblTenedora;
        private DevExpress.XtraEditors.GroupControl grConceptos;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFronting;
        private System.Windows.Forms.TextBox txtTipoBeneficiarios;
        private System.Windows.Forms.TextBox txtFormaPago;
        private System.Windows.Forms.TextBox txtBeneficiario;
        private System.Windows.Forms.TextBox txtFechaPago;
        private System.Windows.Forms.TextBox txtMetodoPago;
        private System.Windows.Forms.TextBox txtTotalDeposito;
        private System.Windows.Forms.TextBox txtMoneda;
        private System.Windows.Forms.TextBox txtTipoCambio;
        private System.Windows.Forms.TextBox txtBancoOrigen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCuentaOrigen;
        private System.Windows.Forms.Label label15;
        private DevExpress.XtraGrid.GridControl gvConceptos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.TextBox txtMesAno;
        public System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkContabilizado;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashSMCargando;
        private DevExpress.XtraGrid.Columns.GridColumn colIdDetailFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colIdHeaderFactura2;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUnidad;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colComplemento;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecioUnitario;
        private DevExpress.XtraGrid.Columns.GridColumn colIVA;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal3;
        private winAppSAIC.Catalogos.dbSAICBPO_CatalogosValidacionDataSetTableAdapters.ValidacionesGeneralTableAdapter validacionesGeneralTableAdapter1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn19;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn20;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn21;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn22;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn23;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn24;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn25;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn26;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn27;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn28;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn29;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn30;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn31;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn32;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn33;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn34;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn35;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn36;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn37;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn38;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn39;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn40;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn41;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn42;
        private System.Windows.Forms.ToolStripButton btnCancelarFactura;
        private System.Windows.Forms.TextBox txtIdSolicitud;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.GridLookUpEdit cbFacturas;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvFacturas;
        private DevExpress.XtraGrid.Columns.GridColumn colIdHeaderFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSolicitudFactura0;
        private DevExpress.XtraGrid.Columns.GridColumn colRazonSocialFronting;
        private DevExpress.XtraGrid.Columns.GridColumn colDescTipoBeneficiario;
        private DevExpress.XtraGrid.Columns.GridColumn RazonSocialBeneficiario;
        private DevExpress.XtraGrid.Columns.GridColumn colIdControlOperacion;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colDescEstatus;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreCompletoOperador;
        private System.Windows.Forms.TextBox txtEstatus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStripButton btnVisualizarErrores;
        private dbSAICBPOFactura dbSAICBPOFactura;
        private System.Windows.Forms.BindingSource vwFactHeaderFacturasBindingSource;
        private dbSAICBPOFacturaTableAdapters.vwFactHeaderFacturasTableAdapter vwFactHeaderFacturasTableAdapter;
        private System.Windows.Forms.BindingSource stpFactSelDetailFacturasBindingSource;
        private dbSAICBPOFacturaTableAdapters.stpFactSelDetailFacturasTableAdapter stpFactSelDetailFacturasTableAdapter;
        private dbSAICBPOFacturaTableAdapters.stpFactSelDerechosAccesoOperadorFacturacionTableAdapter stpFactSelDerechosAccesoOperadorFacturacionTableAdapter1;
        private dbSAICBPOFacturaTableAdapters.spSoloRespuesta spSoloRespuesta1;
        private dbSAICBPOFacturaTableAdapters.stpFactSelControlOperacionesFacturasTableAdapter stpFactSelControlOperacionesFacturasTableAdapter1;
        private dbSAICBPOFacturaTableAdapters.stpFactSelGenerarFacturaTableAdapter stpFactSelGenerarFacturaTableAdapter1;
        private System.Windows.Forms.BindingSource stpFactSelFacturasARelacionarSATBindingSource;
        private dbSAICBPOFacturaTableAdapters.stpFactSelFacturasARelacionarSATTableAdapter stpFactSelFacturasARelacionarSATTableAdapter;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashSMProcesando;
        private System.Windows.Forms.TextBox txtOperador;
        private System.Windows.Forms.Label label16;
        private dbSAICBPOFacturaTableAdapters.stpFactSelComprobantesFacturaTableAdapter stpFactSelComprobantesFacturaTableAdapter1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtBancoDestino;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ToolStripButton btnContabilizar;
        private System.Windows.Forms.ToolStripButton btnDescontabilizar;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label label11;
        private DevExpress.XtraGrid.Columns.GridColumn colSerie;
        private DevExpress.XtraGrid.Columns.GridColumn colFolio;
        private System.Windows.Forms.ToolStripButton btnComprobante;
        private DevExpress.XtraEditors.GridLookUpEdit txtUsoCFDI;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label label19;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.BindingSource stpFactSelConceptoTenedoraBeneficiarioFiltroBindingSource;
        private dbSAICBPOFacturaTableAdapters.stpFactSelConceptoTenedoraBeneficiarioFiltroTableAdapter stpFactSelConceptoTenedoraBeneficiarioFiltroTableAdapter;
        private System.Windows.Forms.BindingSource stpFactSelUsoCFDIBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFactUsoCFDI;
        private DevExpress.XtraGrid.Columns.GridColumn colDesc;
        private DevExpress.XtraGrid.Columns.GridColumn colClave;
        private dbSAICBPOFacturaTableAdapters.stpFactSelUsoCFDITableAdapter stpFactSelUsoCFDITableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn43;
        private DevExpress.XtraEditors.SimpleButton btnConcepto;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn44;
        private dbSAICBPOFacturaTableAdapters.stpFactSelComprobantePagoFacturaTableAdapter stpFactSelComprobantePagoFacturaTableAdapter1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn46;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn45;
        private DevExpress.XtraGrid.Columns.GridColumn colISN;
        private System.Windows.Forms.BindingSource stpFactSelHeaderFacturasTimbrarBindingSource;
        private dbSAICBPOFacturaTableAdapters.stpFactSelHeaderFacturasTimbrarTableAdapter stpFactSelHeaderFacturasTimbrarTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colprossat;
        private System.Windows.Forms.DateTimePicker dtFechaIni;
        private System.Windows.Forms.Label label20;
        private dbSAICBPOValidacionDataSet dbSAICBPOValidacionDataSet1;
        private dbSAICBPOValidacionDataSetTableAdapters.stpSelEstatusNominaContabilizadaTableAdapter stpSelEstatusNominaContabilizadaTableAdapter1;
        private dbSAICBPOValidacionDataSetTableAdapters.stpSelParametroTableAdapter stpSelParametroTableAdapter1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private dbSAICBPOFacturaTableAdapters.stpFactSelGenerarFactura2020TableAdapter stpFactSelGenerarFactura2020TableAdapter1;
        private DevExpress.XtraGrid.Columns.GridColumn colRetencion;
        private System.Windows.Forms.TextBox txtPeriodicidad;
        private System.Windows.Forms.Label label21;
    }
}