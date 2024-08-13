namespace winAppSAIC.Cancelaciones
{
    partial class frmxSolicitudCancelacionNomina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmxSolicitudCancelacionNomina));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.txtMes = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemSpinEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.txtAno = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.btnFiltrar = new DevExpress.XtraBars.BarButtonItem();
            this.btnSalir = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barStaticItem3 = new DevExpress.XtraBars.BarStaticItem();
            this.txtAlMes = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemSpinEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.txtEstatusCFDI = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.btnSolicitarCancelacionNomina = new DevExpress.XtraEditors.SimpleButton();
            this.gcResumenEstatusNominaVsTimbrados = new DevExpress.XtraEditors.GroupControl();
            this.lblLeyendaEstatusNominaSueldosVsTimbrados = new DevExpress.XtraEditors.LabelControl();
            this.lblPctEmpleadosPorTimbrar = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.lblPctEmpleadosTimbrados = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.lblNoEmpleadosCancelados = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.lblNoEmpleadosTimbrados = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.lblNoEmpleadosNomina = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtFechaPago = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.chkEstatusNominaContabilizada = new DevExpress.XtraEditors.CheckEdit();
            this.txtPeriodoPago = new DevExpress.XtraEditors.TextEdit();
            this.txtNombreOperador = new DevExpress.XtraEditors.TextEdit();
            this.txtTipoNomina = new DevExpress.XtraEditors.TextEdit();
            this.txtNombreComercialCliente = new DevExpress.XtraEditors.TextEdit();
            this.txtNombreComercialTenedora = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cboFolioLoteCargaNomina = new DevExpress.XtraEditors.GridLookUpEdit();
            this.stpSelFolioLoteCargaNominaPorCancelarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPOCatalogosDataSet = new winAppSAIC.dbSAICBPOCatalogosDataSet();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenedora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOperador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblFolio = new DevExpress.XtraEditors.LabelControl();
            this.stpSelFolioLoteCargaNominaPorCancelarTableAdapter = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelFolioLoteCargaNominaPorCancelarTableAdapter();
            this.splashSMCargando = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::winAppSAIC.frmxCargandoInformacion), true, true);
            this.stpSelInfoDetalleLoteCargaNominaTableAdapter1 = new winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.stpSelInfoDetalleLoteCargaNominaTableAdapter();
            this.stpSelValidarLoteCargaNominaEnSolicitudCancelacionNominaTableAdapter1 = new winAppSAIC.dbSAICBPOValidacionDataSetTableAdapters.stpSelValidarLoteCargaNominaEnSolicitudCancelacionNominaTableAdapter();
            this.dbSAICBPOValidacionDataSet = new winAppSAIC.dbSAICBPOValidacionDataSet();
            this.solicitudCancelacionNominaTableAdapter1 = new winAppSAIC.dbSAICBPODataSetTableAdapters.SolicitudCancelacionNominaTableAdapter();
            this.stpSelObtenerEstatusNominaSueldosVsTimbradoTableAdapter1 = new winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.stpSelObtenerEstatusNominaSueldosVsTimbradoTableAdapter();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.lblMensajeComoHacerCancelacion = new DevExpress.XtraEditors.LabelControl();
            this.txtNoLoteCargaNomina = new DevExpress.XtraEditors.TextEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.txtIdControl = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstatusCFDI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcResumenEstatusNominaVsTimbrados)).BeginInit();
            this.gcResumenEstatusNominaVsTimbrados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFechaPago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEstatusNominaContabilizada.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodoPago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreOperador.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoNomina.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreComercialCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreComercialTenedora.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFolioLoteCargaNomina.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelFolioLoteCargaNominaPorCancelarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOValidacionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoLoteCargaNomina.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdControl.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.Categories.AddRange(new DevExpress.XtraBars.BarManagerCategory[] {
            new DevExpress.XtraBars.BarManagerCategory("Acciones", new System.Guid("323e3bd6-eb28-4bb8-926c-9ee4583b45ac"))});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnSalir,
            this.barStaticItem1,
            this.txtAno,
            this.btnFiltrar,
            this.barStaticItem2,
            this.txtMes,
            this.barStaticItem3,
            this.txtAlMes});
            this.barManager1.MaxItemId = 8;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSpinEdit1,
            this.repositoryItemSpinEdit2,
            this.repositoryItemSpinEdit3});
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.txtMes),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.txtAno),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnFiltrar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSalir)});
            this.bar1.Text = "Tools";
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Caption = "Mes";
            this.barStaticItem2.Id = 4;
            this.barStaticItem2.Name = "barStaticItem2";
            // 
            // txtMes
            // 
            this.txtMes.Caption = "barEditItem1";
            this.txtMes.Edit = this.repositoryItemSpinEdit2;
            this.txtMes.Id = 5;
            this.txtMes.Name = "txtMes";
            // 
            // repositoryItemSpinEdit2
            // 
            this.repositoryItemSpinEdit2.AutoHeight = false;
            this.repositoryItemSpinEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit2.MaxLength = 2;
            this.repositoryItemSpinEdit2.MaxValue = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.repositoryItemSpinEdit2.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.repositoryItemSpinEdit2.Name = "repositoryItemSpinEdit2";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "Año";
            this.barStaticItem1.CategoryGuid = new System.Guid("323e3bd6-eb28-4bb8-926c-9ee4583b45ac");
            this.barStaticItem1.Id = 1;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // txtAno
            // 
            this.txtAno.CategoryGuid = new System.Guid("323e3bd6-eb28-4bb8-926c-9ee4583b45ac");
            this.txtAno.Edit = this.repositoryItemSpinEdit1;
            this.txtAno.EditWidth = 70;
            this.txtAno.Id = 2;
            this.txtAno.Name = "txtAno";
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit1.MaxLength = 4;
            this.repositoryItemSpinEdit1.MaxValue = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.repositoryItemSpinEdit1.MinValue = new decimal(new int[] {
            2010,
            0,
            0,
            0});
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Caption = "Filtrar";
            this.btnFiltrar.CategoryGuid = new System.Guid("323e3bd6-eb28-4bb8-926c-9ee4583b45ac");
            this.btnFiltrar.Id = 3;
            this.btnFiltrar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrar.ImageOptions.Image")));
            this.btnFiltrar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnFiltrar.ImageOptions.LargeImage")));
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnFiltrar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFiltrar_ItemClick);
            // 
            // btnSalir
            // 
            this.btnSalir.Border = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.btnSalir.Caption = "Salir";
            this.btnSalir.Id = 0;
            this.btnSalir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.ImageOptions.Image")));
            this.btnSalir.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.ImageOptions.LargeImage")));
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnSalir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSalir_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1113, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 289);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1113, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 258);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1113, 31);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 258);
            // 
            // barStaticItem3
            // 
            this.barStaticItem3.Caption = "al Mes";
            this.barStaticItem3.Id = 6;
            this.barStaticItem3.Name = "barStaticItem3";
            // 
            // txtAlMes
            // 
            this.txtAlMes.Caption = "barEditItem2";
            this.txtAlMes.Edit = this.repositoryItemSpinEdit3;
            this.txtAlMes.Id = 7;
            this.txtAlMes.Name = "txtAlMes";
            // 
            // repositoryItemSpinEdit3
            // 
            this.repositoryItemSpinEdit3.AutoHeight = false;
            this.repositoryItemSpinEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit3.MaxLength = 2;
            this.repositoryItemSpinEdit3.MaxValue = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.repositoryItemSpinEdit3.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.repositoryItemSpinEdit3.Name = "repositoryItemSpinEdit3";
            // 
            // txtEstatusCFDI
            // 
            this.txtEstatusCFDI.Enabled = false;
            this.txtEstatusCFDI.Location = new System.Drawing.Point(99, 205);
            this.txtEstatusCFDI.Name = "txtEstatusCFDI";
            this.txtEstatusCFDI.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtEstatusCFDI.Properties.Appearance.Options.UseBackColor = true;
            this.txtEstatusCFDI.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEstatusCFDI.Size = new System.Drawing.Size(392, 50);
            this.txtEstatusCFDI.TabIndex = 40;
            this.txtEstatusCFDI.Tag = "Otro Concepto";
            // 
            // labelControl8
            // 
            this.labelControl8.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl8.Location = new System.Drawing.Point(30, 205);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(63, 13);
            this.labelControl8.TabIndex = 39;
            this.labelControl8.Text = "Estatus CFDI";
            // 
            // btnSolicitarCancelacionNomina
            // 
            this.btnSolicitarCancelacionNomina.Appearance.BackColor = System.Drawing.Color.White;
            this.btnSolicitarCancelacionNomina.Appearance.Options.UseBackColor = true;
            this.btnSolicitarCancelacionNomina.Appearance.Options.UseTextOptions = true;
            this.btnSolicitarCancelacionNomina.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnSolicitarCancelacionNomina.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnSolicitarCancelacionNomina.ImageOptions.Image = global::winAppSAIC.Properties.Resources.Borrar1;
            this.btnSolicitarCancelacionNomina.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSolicitarCancelacionNomina.Location = new System.Drawing.Point(917, 52);
            this.btnSolicitarCancelacionNomina.LookAndFeel.SkinName = "VS2010";
            this.btnSolicitarCancelacionNomina.Name = "btnSolicitarCancelacionNomina";
            this.btnSolicitarCancelacionNomina.Size = new System.Drawing.Size(187, 45);
            this.btnSolicitarCancelacionNomina.TabIndex = 38;
            this.btnSolicitarCancelacionNomina.Text = "Solicitar Cancelación de Nómina";
            this.btnSolicitarCancelacionNomina.Click += new System.EventHandler(this.btnSolicitarCancelacionNomina_Click);
            // 
            // gcResumenEstatusNominaVsTimbrados
            // 
            this.gcResumenEstatusNominaVsTimbrados.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcResumenEstatusNominaVsTimbrados.Appearance.Options.UseFont = true;
            this.gcResumenEstatusNominaVsTimbrados.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gcResumenEstatusNominaVsTimbrados.AppearanceCaption.Options.UseFont = true;
            this.gcResumenEstatusNominaVsTimbrados.AppearanceCaption.Options.UseTextOptions = true;
            this.gcResumenEstatusNominaVsTimbrados.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcResumenEstatusNominaVsTimbrados.Controls.Add(this.lblLeyendaEstatusNominaSueldosVsTimbrados);
            this.gcResumenEstatusNominaVsTimbrados.Controls.Add(this.lblPctEmpleadosPorTimbrar);
            this.gcResumenEstatusNominaVsTimbrados.Controls.Add(this.labelControl12);
            this.gcResumenEstatusNominaVsTimbrados.Controls.Add(this.lblPctEmpleadosTimbrados);
            this.gcResumenEstatusNominaVsTimbrados.Controls.Add(this.labelControl10);
            this.gcResumenEstatusNominaVsTimbrados.Controls.Add(this.lblNoEmpleadosCancelados);
            this.gcResumenEstatusNominaVsTimbrados.Controls.Add(this.labelControl11);
            this.gcResumenEstatusNominaVsTimbrados.Controls.Add(this.lblNoEmpleadosTimbrados);
            this.gcResumenEstatusNominaVsTimbrados.Controls.Add(this.labelControl9);
            this.gcResumenEstatusNominaVsTimbrados.Controls.Add(this.lblNoEmpleadosNomina);
            this.gcResumenEstatusNominaVsTimbrados.Controls.Add(this.labelControl7);
            this.gcResumenEstatusNominaVsTimbrados.Location = new System.Drawing.Point(508, 77);
            this.gcResumenEstatusNominaVsTimbrados.Name = "gcResumenEstatusNominaVsTimbrados";
            this.gcResumenEstatusNominaVsTimbrados.Size = new System.Drawing.Size(392, 141);
            this.gcResumenEstatusNominaVsTimbrados.TabIndex = 17;
            this.gcResumenEstatusNominaVsTimbrados.Text = "Resumen Nómina Vs Timbrados";
            // 
            // lblLeyendaEstatusNominaSueldosVsTimbrados
            // 
            this.lblLeyendaEstatusNominaSueldosVsTimbrados.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeyendaEstatusNominaSueldosVsTimbrados.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblLeyendaEstatusNominaSueldosVsTimbrados.Appearance.Options.UseFont = true;
            this.lblLeyendaEstatusNominaSueldosVsTimbrados.Appearance.Options.UseForeColor = true;
            this.lblLeyendaEstatusNominaSueldosVsTimbrados.Appearance.Options.UseTextOptions = true;
            this.lblLeyendaEstatusNominaSueldosVsTimbrados.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblLeyendaEstatusNominaSueldosVsTimbrados.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lblLeyendaEstatusNominaSueldosVsTimbrados.Location = new System.Drawing.Point(152, 108);
            this.lblLeyendaEstatusNominaSueldosVsTimbrados.Name = "lblLeyendaEstatusNominaSueldosVsTimbrados";
            this.lblLeyendaEstatusNominaSueldosVsTimbrados.Size = new System.Drawing.Size(11, 18);
            this.lblLeyendaEstatusNominaSueldosVsTimbrados.TabIndex = 10;
            this.lblLeyendaEstatusNominaSueldosVsTimbrados.Text = "X";
            // 
            // lblPctEmpleadosPorTimbrar
            // 
            this.lblPctEmpleadosPorTimbrar.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPctEmpleadosPorTimbrar.Appearance.Options.UseFont = true;
            this.lblPctEmpleadosPorTimbrar.Location = new System.Drawing.Point(325, 62);
            this.lblPctEmpleadosPorTimbrar.Name = "lblPctEmpleadosPorTimbrar";
            this.lblPctEmpleadosPorTimbrar.Size = new System.Drawing.Size(8, 13);
            this.lblPctEmpleadosPorTimbrar.TabIndex = 9;
            this.lblPctEmpleadosPorTimbrar.Text = "X";
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(190, 62);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(123, 13);
            this.labelControl12.TabIndex = 8;
            this.labelControl12.Text = "% Empleados por Timbrar";
            // 
            // lblPctEmpleadosTimbrados
            // 
            this.lblPctEmpleadosTimbrados.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPctEmpleadosTimbrados.Appearance.Options.UseFont = true;
            this.lblPctEmpleadosTimbrados.Location = new System.Drawing.Point(325, 30);
            this.lblPctEmpleadosTimbrados.Name = "lblPctEmpleadosTimbrados";
            this.lblPctEmpleadosTimbrados.Size = new System.Drawing.Size(8, 13);
            this.lblPctEmpleadosTimbrados.TabIndex = 7;
            this.lblPctEmpleadosTimbrados.Text = "X";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(190, 30);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(117, 13);
            this.labelControl10.TabIndex = 6;
            this.labelControl10.Text = "% Empleados Timbrados";
            // 
            // lblNoEmpleadosCancelados
            // 
            this.lblNoEmpleadosCancelados.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblNoEmpleadosCancelados.Appearance.Options.UseFont = true;
            this.lblNoEmpleadosCancelados.Location = new System.Drawing.Point(152, 84);
            this.lblNoEmpleadosCancelados.Name = "lblNoEmpleadosCancelados";
            this.lblNoEmpleadosCancelados.Size = new System.Drawing.Size(8, 13);
            this.lblNoEmpleadosCancelados.TabIndex = 5;
            this.lblNoEmpleadosCancelados.Text = "X";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(14, 84);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(129, 13);
            this.labelControl11.TabIndex = 4;
            this.labelControl11.Text = "No. Empleados Cancelados";
            // 
            // lblNoEmpleadosTimbrados
            // 
            this.lblNoEmpleadosTimbrados.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblNoEmpleadosTimbrados.Appearance.Options.UseFont = true;
            this.lblNoEmpleadosTimbrados.Location = new System.Drawing.Point(152, 62);
            this.lblNoEmpleadosTimbrados.Name = "lblNoEmpleadosTimbrados";
            this.lblNoEmpleadosTimbrados.Size = new System.Drawing.Size(8, 13);
            this.lblNoEmpleadosTimbrados.TabIndex = 3;
            this.lblNoEmpleadosTimbrados.Text = "X";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(14, 62);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(123, 13);
            this.labelControl9.TabIndex = 2;
            this.labelControl9.Text = "No. Empleados Timbrados";
            // 
            // lblNoEmpleadosNomina
            // 
            this.lblNoEmpleadosNomina.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblNoEmpleadosNomina.Appearance.Options.UseFont = true;
            this.lblNoEmpleadosNomina.Location = new System.Drawing.Point(152, 36);
            this.lblNoEmpleadosNomina.Name = "lblNoEmpleadosNomina";
            this.lblNoEmpleadosNomina.Size = new System.Drawing.Size(8, 13);
            this.lblNoEmpleadosNomina.TabIndex = 1;
            this.lblNoEmpleadosNomina.Text = "X";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(14, 30);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(110, 26);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "No. Empleados Nómina\r\ncon Monto a Pagar > 0";
            // 
            // txtFechaPago
            // 
            this.txtFechaPago.Enabled = false;
            this.txtFechaPago.Location = new System.Drawing.Point(99, 176);
            this.txtFechaPago.Name = "txtFechaPago";
            this.txtFechaPago.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtFechaPago.Properties.Appearance.Options.UseBackColor = true;
            this.txtFechaPago.Size = new System.Drawing.Size(116, 20);
            this.txtFechaPago.TabIndex = 16;
            this.txtFechaPago.TabStop = false;
            // 
            // labelControl6
            // 
            this.labelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl6.Location = new System.Drawing.Point(37, 180);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(56, 13);
            this.labelControl6.TabIndex = 15;
            this.labelControl6.Text = "Fecha Pago";
            // 
            // chkEstatusNominaContabilizada
            // 
            this.chkEstatusNominaContabilizada.Enabled = false;
            this.chkEstatusNominaContabilizada.Location = new System.Drawing.Point(269, 177);
            this.chkEstatusNominaContabilizada.Name = "chkEstatusNominaContabilizada";
            this.chkEstatusNominaContabilizada.Properties.Caption = "Contabilizada";
            this.chkEstatusNominaContabilizada.Size = new System.Drawing.Size(116, 19);
            this.chkEstatusNominaContabilizada.TabIndex = 14;
            this.chkEstatusNominaContabilizada.TabStop = false;
            // 
            // txtPeriodoPago
            // 
            this.txtPeriodoPago.Enabled = false;
            this.txtPeriodoPago.Location = new System.Drawing.Point(269, 151);
            this.txtPeriodoPago.Name = "txtPeriodoPago";
            this.txtPeriodoPago.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtPeriodoPago.Properties.Appearance.Options.UseBackColor = true;
            this.txtPeriodoPago.Size = new System.Drawing.Size(150, 20);
            this.txtPeriodoPago.TabIndex = 13;
            this.txtPeriodoPago.TabStop = false;
            // 
            // txtNombreOperador
            // 
            this.txtNombreOperador.Enabled = false;
            this.txtNombreOperador.Location = new System.Drawing.Point(99, 125);
            this.txtNombreOperador.Name = "txtNombreOperador";
            this.txtNombreOperador.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtNombreOperador.Properties.Appearance.Options.UseBackColor = true;
            this.txtNombreOperador.Size = new System.Drawing.Size(392, 20);
            this.txtNombreOperador.TabIndex = 9;
            this.txtNombreOperador.TabStop = false;
            // 
            // txtTipoNomina
            // 
            this.txtTipoNomina.Enabled = false;
            this.txtTipoNomina.Location = new System.Drawing.Point(99, 151);
            this.txtTipoNomina.Name = "txtTipoNomina";
            this.txtTipoNomina.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtTipoNomina.Properties.Appearance.Options.UseBackColor = true;
            this.txtTipoNomina.Size = new System.Drawing.Size(116, 20);
            this.txtTipoNomina.TabIndex = 11;
            this.txtTipoNomina.TabStop = false;
            // 
            // txtNombreComercialCliente
            // 
            this.txtNombreComercialCliente.Enabled = false;
            this.txtNombreComercialCliente.Location = new System.Drawing.Point(99, 100);
            this.txtNombreComercialCliente.Name = "txtNombreComercialCliente";
            this.txtNombreComercialCliente.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtNombreComercialCliente.Properties.Appearance.Options.UseBackColor = true;
            this.txtNombreComercialCliente.Size = new System.Drawing.Size(392, 20);
            this.txtNombreComercialCliente.TabIndex = 7;
            this.txtNombreComercialCliente.TabStop = false;
            // 
            // txtNombreComercialTenedora
            // 
            this.txtNombreComercialTenedora.Enabled = false;
            this.txtNombreComercialTenedora.Location = new System.Drawing.Point(99, 75);
            this.txtNombreComercialTenedora.Name = "txtNombreComercialTenedora";
            this.txtNombreComercialTenedora.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtNombreComercialTenedora.Properties.Appearance.Options.UseBackColor = true;
            this.txtNombreComercialTenedora.Size = new System.Drawing.Size(392, 20);
            this.txtNombreComercialTenedora.TabIndex = 5;
            this.txtNombreComercialTenedora.TabStop = false;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(35, 155);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(58, 13);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Tipo Nómina";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(227, 155);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(36, 13);
            this.labelControl4.TabIndex = 12;
            this.labelControl4.Text = "Periodo";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(47, 129);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(46, 13);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Operador";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(60, 104);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(33, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Cliente";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(47, 79);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Tenedora";
            // 
            // cboFolioLoteCargaNomina
            // 
            this.cboFolioLoteCargaNomina.EditValue = "";
            this.cboFolioLoteCargaNomina.Location = new System.Drawing.Point(99, 49);
            this.cboFolioLoteCargaNomina.Name = "cboFolioLoteCargaNomina";
            this.cboFolioLoteCargaNomina.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
            this.cboFolioLoteCargaNomina.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboFolioLoteCargaNomina.Properties.DataSource = this.stpSelFolioLoteCargaNominaPorCancelarBindingSource;
            this.cboFolioLoteCargaNomina.Properties.DisplayMember = "FolioLoteCargaNomina";
            this.cboFolioLoteCargaNomina.Properties.NullText = "";
            this.cboFolioLoteCargaNomina.Properties.ValueMember = "IdLoteCargaNomina";
            this.cboFolioLoteCargaNomina.Properties.View = this.gridLookUpEdit1View;
            this.cboFolioLoteCargaNomina.Size = new System.Drawing.Size(250, 20);
            this.cboFolioLoteCargaNomina.TabIndex = 3;
            this.cboFolioLoteCargaNomina.EditValueChanged += new System.EventHandler(this.cboFolioLoteCargaNomina_EditValueChanged);
            // 
            // stpSelFolioLoteCargaNominaPorCancelarBindingSource
            // 
            this.stpSelFolioLoteCargaNominaPorCancelarBindingSource.DataMember = "stpSelFolioLoteCargaNominaPorCancelar";
            this.stpSelFolioLoteCargaNominaPorCancelarBindingSource.DataSource = this.dbSAICBPOCatalogosDataSet;
            // 
            // dbSAICBPOCatalogosDataSet
            // 
            this.dbSAICBPOCatalogosDataSet.DataSetName = "dbSAICBPOCatalogosDataSet";
            this.dbSAICBPOCatalogosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn3,
            this.colTenedora,
            this.colCliente,
            this.colOperador});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsCustomization.AllowGroup = false;
            this.gridLookUpEdit1View.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridLookUpEdit1View.OptionsCustomization.AllowSort = false;
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            this.gridLookUpEdit1View.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn2, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "No. Lote";
            this.gridColumn2.FieldName = "IdLoteCargaNomina";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 30;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Folio Lote Carga Nómina";
            this.gridColumn3.FieldName = "FolioLoteCargaNomina";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 30;
            // 
            // colTenedora
            // 
            this.colTenedora.Caption = "Tenedora";
            this.colTenedora.FieldName = "NombreComercialTenedora";
            this.colTenedora.Name = "colTenedora";
            this.colTenedora.Visible = true;
            this.colTenedora.VisibleIndex = 2;
            this.colTenedora.Width = 84;
            // 
            // colCliente
            // 
            this.colCliente.Caption = "Cliente";
            this.colCliente.FieldName = "NombreComercialCliente";
            this.colCliente.Name = "colCliente";
            this.colCliente.Visible = true;
            this.colCliente.VisibleIndex = 3;
            this.colCliente.Width = 128;
            // 
            // colOperador
            // 
            this.colOperador.FieldName = "Operador";
            this.colOperador.Name = "colOperador";
            this.colOperador.Visible = true;
            this.colOperador.VisibleIndex = 4;
            this.colOperador.Width = 112;
            // 
            // lblFolio
            // 
            this.lblFolio.Location = new System.Drawing.Point(14, 52);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(79, 13);
            this.lblFolio.TabIndex = 2;
            this.lblFolio.Text = "No. Lote Nómina";
            // 
            // stpSelFolioLoteCargaNominaPorCancelarTableAdapter
            // 
            this.stpSelFolioLoteCargaNominaPorCancelarTableAdapter.ClearBeforeFill = true;
            // 
            // stpSelInfoDetalleLoteCargaNominaTableAdapter1
            // 
            this.stpSelInfoDetalleLoteCargaNominaTableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelValidarLoteCargaNominaEnSolicitudCancelacionNominaTableAdapter1
            // 
            this.stpSelValidarLoteCargaNominaEnSolicitudCancelacionNominaTableAdapter1.ClearBeforeFill = true;
            // 
            // dbSAICBPOValidacionDataSet
            // 
            this.dbSAICBPOValidacionDataSet.DataSetName = "dbSAICBPOValidacionDataSet";
            this.dbSAICBPOValidacionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // solicitudCancelacionNominaTableAdapter1
            // 
            this.solicitudCancelacionNominaTableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelObtenerEstatusNominaSueldosVsTimbradoTableAdapter1
            // 
            this.stpSelObtenerEstatusNominaSueldosVsTimbradoTableAdapter1.ClearBeforeFill = true;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.White;
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseTextOptions = true;
            this.simpleButton2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.simpleButton2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.simpleButton2.Location = new System.Drawing.Point(917, 103);
            this.simpleButton2.LookAndFeel.SkinName = "VS2010";
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(187, 45);
            this.simpleButton2.TabIndex = 50;
            this.simpleButton2.Text = "Promover Nómina con Timbrado CFDI Parcial para Fusionar";
            this.simpleButton2.Visible = false;
            // 
            // lblMensajeComoHacerCancelacion
            // 
            this.lblMensajeComoHacerCancelacion.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblMensajeComoHacerCancelacion.Appearance.Options.UseFont = true;
            this.lblMensajeComoHacerCancelacion.Appearance.Options.UseTextOptions = true;
            this.lblMensajeComoHacerCancelacion.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblMensajeComoHacerCancelacion.Location = new System.Drawing.Point(99, 263);
            this.lblMensajeComoHacerCancelacion.Name = "lblMensajeComoHacerCancelacion";
            this.lblMensajeComoHacerCancelacion.Size = new System.Drawing.Size(25, 14);
            this.lblMensajeComoHacerCancelacion.TabIndex = 55;
            this.lblMensajeComoHacerCancelacion.Text = "XXX";
            // 
            // txtNoLoteCargaNomina
            // 
            this.txtNoLoteCargaNomina.Enabled = false;
            this.txtNoLoteCargaNomina.Location = new System.Drawing.Point(99, 49);
            this.txtNoLoteCargaNomina.MenuManager = this.barManager1;
            this.txtNoLoteCargaNomina.Name = "txtNoLoteCargaNomina";
            this.txtNoLoteCargaNomina.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtNoLoteCargaNomina.Properties.Appearance.Options.UseBackColor = true;
            this.txtNoLoteCargaNomina.Size = new System.Drawing.Size(116, 20);
            this.txtNoLoteCargaNomina.TabIndex = 61;
            this.txtNoLoteCargaNomina.TabStop = false;
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(360, 52);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(59, 13);
            this.labelControl13.TabIndex = 69;
            this.labelControl13.Text = "No. Control:";
            // 
            // txtIdControl
            // 
            this.txtIdControl.Enabled = false;
            this.txtIdControl.Location = new System.Drawing.Point(425, 49);
            this.txtIdControl.MenuManager = this.barManager1;
            this.txtIdControl.Name = "txtIdControl";
            this.txtIdControl.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtIdControl.Properties.Appearance.Options.UseBackColor = true;
            this.txtIdControl.Size = new System.Drawing.Size(66, 20);
            this.txtIdControl.TabIndex = 68;
            this.txtIdControl.TabStop = false;
            // 
            // frmxSolicitudCancelacionNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 289);
            this.ControlBox = false;
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.txtIdControl);
            this.Controls.Add(this.txtNoLoteCargaNomina);
            this.Controls.Add(this.lblMensajeComoHacerCancelacion);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.txtEstatusCFDI);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.cboFolioLoteCargaNomina);
            this.Controls.Add(this.btnSolicitarCancelacionNomina);
            this.Controls.Add(this.lblFolio);
            this.Controls.Add(this.gcResumenEstatusNominaVsTimbrados);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtFechaPago);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.chkEstatusNominaContabilizada);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtPeriodoPago);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtNombreOperador);
            this.Controls.Add(this.txtNombreComercialTenedora);
            this.Controls.Add(this.txtTipoNomina);
            this.Controls.Add(this.txtNombreComercialCliente);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmxSolicitudCancelacionNomina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancelación de Nómina";
            this.Load += new System.EventHandler(this.frmxSolicitudCancelacionNomina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstatusCFDI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcResumenEstatusNominaVsTimbrados)).EndInit();
            this.gcResumenEstatusNominaVsTimbrados.ResumeLayout(false);
            this.gcResumenEstatusNominaVsTimbrados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFechaPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEstatusNominaContabilizada.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodoPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreOperador.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoNomina.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreComercialCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreComercialTenedora.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFolioLoteCargaNomina.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelFolioLoteCargaNominaPorCancelarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOValidacionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoLoteCargaNomina.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdControl.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnSalir;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.GroupControl gcResumenEstatusNominaVsTimbrados;
        private DevExpress.XtraEditors.LabelControl lblLeyendaEstatusNominaSueldosVsTimbrados;
        private DevExpress.XtraEditors.LabelControl lblPctEmpleadosPorTimbrar;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl lblPctEmpleadosTimbrados;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl lblNoEmpleadosCancelados;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl lblNoEmpleadosTimbrados;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl lblNoEmpleadosNomina;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtFechaPago;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.CheckEdit chkEstatusNominaContabilizada;
        private DevExpress.XtraEditors.TextEdit txtPeriodoPago;
        private DevExpress.XtraEditors.TextEdit txtNombreOperador;
        private DevExpress.XtraEditors.TextEdit txtTipoNomina;
        private DevExpress.XtraEditors.TextEdit txtNombreComercialCliente;
        private DevExpress.XtraEditors.TextEdit txtNombreComercialTenedora;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GridLookUpEdit cboFolioLoteCargaNomina;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn colTenedora;
        private DevExpress.XtraGrid.Columns.GridColumn colCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colOperador;
        private DevExpress.XtraEditors.LabelControl lblFolio;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarEditItem txtAno;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraBars.BarButtonItem btnFiltrar;
        private System.Windows.Forms.BindingSource stpSelFolioLoteCargaNominaPorCancelarBindingSource;
        private dbSAICBPOCatalogosDataSet dbSAICBPOCatalogosDataSet;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelFolioLoteCargaNominaPorCancelarTableAdapter stpSelFolioLoteCargaNominaPorCancelarTableAdapter;
        private dbSAICBPOReportesDataSetTableAdapters.stpSelInfoDetalleLoteCargaNominaTableAdapter stpSelInfoDetalleLoteCargaNominaTableAdapter1;
        private DevExpress.XtraEditors.SimpleButton btnSolicitarCancelacionNomina;
        private dbSAICBPOValidacionDataSetTableAdapters.stpSelValidarLoteCargaNominaEnSolicitudCancelacionNominaTableAdapter stpSelValidarLoteCargaNominaEnSolicitudCancelacionNominaTableAdapter1;
        private dbSAICBPOValidacionDataSet dbSAICBPOValidacionDataSet;
        private dbSAICBPODataSetTableAdapters.SolicitudCancelacionNominaTableAdapter solicitudCancelacionNominaTableAdapter1;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.MemoEdit txtEstatusCFDI;
        private dbSAICBPOReportesDataSetTableAdapters.stpSelObtenerEstatusNominaSueldosVsTimbradoTableAdapter stpSelObtenerEstatusNominaSueldosVsTimbradoTableAdapter1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.LabelControl lblMensajeComoHacerCancelacion;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        private DevExpress.XtraBars.BarEditItem txtMes;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit2;
        private DevExpress.XtraBars.BarStaticItem barStaticItem3;
        private DevExpress.XtraBars.BarEditItem txtAlMes;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit3;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashSMCargando;
        private DevExpress.XtraEditors.TextEdit txtNoLoteCargaNomina;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.TextEdit txtIdControl;
    }
}