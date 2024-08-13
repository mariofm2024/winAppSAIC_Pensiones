namespace winAppSAIC.ControlOperaciones
{
    partial class frmxSolicitudPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmxSolicitudPago));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnSalir = new DevExpress.XtraBars.BarButtonItem();
            this.btnSolicitarPagar = new DevExpress.XtraBars.BarButtonItem();
            this.btnAsimilados = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.btnEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.txtEmisora = new DevExpress.XtraEditors.TextEdit();
            this.lblEmisora = new System.Windows.Forms.Label();
            this.dpFechaPago = new System.Windows.Forms.DateTimePicker();
            this.lblFechaPago = new System.Windows.Forms.Label();
            this.cboFormatoBanco = new System.Windows.Forms.ComboBox();
            this.stpTesSelLayoutBancoFormatoPorBancoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPOTesoreriaDataSet = new winAppSAIC.Tesoreria.dbSAICBPOTesoreriaDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.gdvLotes = new DevExpress.XtraEditors.GroupControl();
            this.sidePanel2 = new DevExpress.XtraEditors.SidePanel();
            this.dgvLotes = new DevExpress.XtraGrid.GridControl();
            this.stpFactSelDetailCOSolicitudPagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvTransferencias = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdLoteCargaNomina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFolioLoteCargaNomina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRazonSocial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTIPO1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPagarBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpleados = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoPago2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTIPOLEYOU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.stpFactSelDetailCOSolicitudPagoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICAsimilados = new winAppSAIC.Asimilados.dbSAICAsimilados();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdControl = new DevExpress.XtraEditors.TextEdit();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.groupControlIAS = new DevExpress.XtraEditors.GroupControl();
            this.dateTimePickerPagoIAS = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.sidePanel4 = new DevExpress.XtraEditors.SidePanel();
            this.label2 = new System.Windows.Forms.Label();
            this.sidePanel5 = new DevExpress.XtraEditors.SidePanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dgvTransferencias = new DevExpress.XtraGrid.GridControl();
            this.gvtransaccion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldTabla = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdLote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenedora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTenedora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBancoOrigen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFormato = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdFormato = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmisora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPagar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoEmpleados = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.stpUpdAutorizacionNominaTableAdapter1 = new winAppSAIC.dbSAICBPODataSetTableAdapters.stpUpdAutorizacionNominaTableAdapter();
            this.stpFactSelDetailCOSolicitudPagoTableAdapter = new winAppSAIC.Tesoreria.dbSAICBPOTesoreriaDataSetTableAdapters.stpFactSelDetailCOSolicitudPagoTableAdapter();
            this.stpTesSelLayoutBancoFormatoPorBancoTableAdapter = new winAppSAIC.Tesoreria.dbSAICBPOTesoreriaDataSetTableAdapters.stpTesSelLayoutBancoFormatoPorBancoTableAdapter();
            this.sidePanel6 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel8 = new DevExpress.XtraEditors.SidePanel();
            this.respuestasTesoreria1 = new winAppSAIC.Tesoreria.dbSAICBPOTesoreriaDataSetTableAdapters.RespuestasTesoreria();
            this.stpFactSelDetailCOSolicitudPagoTableAdapter1 = new winAppSAIC.Asimilados.dbSAICAsimiladosTableAdapters.stpFactSelDetailCOSolicitudPagoTableAdapter();
            this.queriesAsimilados1 = new winAppSAIC.Asimilados.dbSAICAsimiladosTableAdapters.QueriesAsimilados();
            this.spSoloRespuesta1 = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.spSoloRespuesta();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmisora.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpTesSelLayoutBancoFormatoPorBancoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOTesoreriaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvLotes)).BeginInit();
            this.gdvLotes.SuspendLayout();
            this.sidePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelDetailCOSolicitudPagoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTransferencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelDetailCOSolicitudPagoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICAsimilados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdControl.Properties)).BeginInit();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlIAS)).BeginInit();
            this.groupControlIAS.SuspendLayout();
            this.sidePanel4.SuspendLayout();
            this.sidePanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransferencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvtransaccion)).BeginInit();
            this.sidePanel6.SuspendLayout();
            this.sidePanel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnSalir,
            this.btnSolicitarPagar,
            this.btnAsimilados});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSalir),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSolicitarPagar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAsimilados)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnSalir
            // 
            this.btnSalir.Caption = "Salir";
            this.btnSalir.Id = 0;
            this.btnSalir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.ImageOptions.Image")));
            this.btnSalir.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.ImageOptions.LargeImage")));
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnSalir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSalir_ItemClick);
            // 
            // btnSolicitarPagar
            // 
            this.btnSolicitarPagar.Caption = "Solicitar Pago";
            this.btnSolicitarPagar.Id = 1;
            this.btnSolicitarPagar.ImageOptions.Image = global::winAppSAIC.Properties.Resources.coins_in_hand_icon16x16;
            this.btnSolicitarPagar.ImageOptions.LargeImage = global::winAppSAIC.Properties.Resources.coins_in_hand_icon32x32;
            this.btnSolicitarPagar.Name = "btnSolicitarPagar";
            this.btnSolicitarPagar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnSolicitarPagar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSolicitarPagar_ItemClick);
            // 
            // btnAsimilados
            // 
            this.btnAsimilados.Caption = "Cargar Asimilados";
            this.btnAsimilados.Enabled = false;
            this.btnAsimilados.Id = 2;
            this.btnAsimilados.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAsimilados.ImageOptions.Image")));
            this.btnAsimilados.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAsimilados.ImageOptions.LargeImage")));
            this.btnAsimilados.Name = "btnAsimilados";
            this.btnAsimilados.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnAsimilados.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAsimilados_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(864, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 523);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(864, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 499);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(864, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 499);
            // 
            // separatorControl1
            // 
            this.separatorControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.separatorControl1.LineAlignment = DevExpress.XtraEditors.Alignment.Center;
            this.separatorControl1.Location = new System.Drawing.Point(2, 469);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(737, 20);
            this.separatorControl1.TabIndex = 36;
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
            this.btnEliminar.Location = new System.Drawing.Point(752, 21);
            this.btnEliminar.LookAndFeel.SkinName = "VS2010";
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(106, 28);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar Layout";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Appearance.BackColor = System.Drawing.Color.White;
            this.btnAgregar.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Appearance.Options.UseBackColor = true;
            this.btnAgregar.Appearance.Options.UseFont = true;
            this.btnAgregar.Appearance.Options.UseTextOptions = true;
            this.btnAgregar.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnAgregar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.ImageOptions.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(619, 21);
            this.btnAgregar.LookAndFeel.SkinName = "VS2010";
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(106, 28);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar Layout";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtEmisora
            // 
            this.txtEmisora.Enabled = false;
            this.txtEmisora.Location = new System.Drawing.Point(329, 25);
            this.txtEmisora.Name = "txtEmisora";
            this.txtEmisora.Properties.Mask.EditMask = "00000";
            this.txtEmisora.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtEmisora.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtEmisora.Properties.MaxLength = 5;
            this.txtEmisora.Size = new System.Drawing.Size(92, 20);
            this.txtEmisora.TabIndex = 3;
            // 
            // lblEmisora
            // 
            this.lblEmisora.AutoSize = true;
            this.lblEmisora.Location = new System.Drawing.Point(275, 28);
            this.lblEmisora.Name = "lblEmisora";
            this.lblEmisora.Size = new System.Drawing.Size(48, 13);
            this.lblEmisora.TabIndex = 6;
            this.lblEmisora.Text = "Emisora:";
            // 
            // dpFechaPago
            // 
            this.dpFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpFechaPago.Location = new System.Drawing.Point(517, 24);
            this.dpFechaPago.Name = "dpFechaPago";
            this.dpFechaPago.Size = new System.Drawing.Size(92, 21);
            this.dpFechaPago.TabIndex = 4;
            // 
            // lblFechaPago
            // 
            this.lblFechaPago.AutoSize = true;
            this.lblFechaPago.Location = new System.Drawing.Point(429, 28);
            this.lblFechaPago.Name = "lblFechaPago";
            this.lblFechaPago.Size = new System.Drawing.Size(82, 13);
            this.lblFechaPago.TabIndex = 4;
            this.lblFechaPago.Text = "Fecha de Pago:";
            // 
            // cboFormatoBanco
            // 
            this.cboFormatoBanco.DataSource = this.stpTesSelLayoutBancoFormatoPorBancoBindingSource;
            this.cboFormatoBanco.DisplayMember = "DescFormatoLayoutBanco";
            this.cboFormatoBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFormatoBanco.FormattingEnabled = true;
            this.cboFormatoBanco.Location = new System.Drawing.Point(68, 25);
            this.cboFormatoBanco.Name = "cboFormatoBanco";
            this.cboFormatoBanco.Size = new System.Drawing.Size(192, 21);
            this.cboFormatoBanco.TabIndex = 2;
            this.cboFormatoBanco.Tag = "Formato";
            this.cboFormatoBanco.ValueMember = "IdFormatoLayoutBanco";
            // 
            // stpTesSelLayoutBancoFormatoPorBancoBindingSource
            // 
            this.stpTesSelLayoutBancoFormatoPorBancoBindingSource.DataMember = "stpTesSelLayoutBancoFormatoPorBanco";
            this.stpTesSelLayoutBancoFormatoPorBancoBindingSource.DataSource = this.dbSAICBPOTesoreriaDataSet;
            // 
            // dbSAICBPOTesoreriaDataSet
            // 
            this.dbSAICBPOTesoreriaDataSet.DataSetName = "dbSAICBPOTesoreriaDataSet";
            this.dbSAICBPOTesoreriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Formato:";
            // 
            // gdvLotes
            // 
            this.gdvLotes.Controls.Add(this.sidePanel2);
            this.gdvLotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdvLotes.Location = new System.Drawing.Point(0, 0);
            this.gdvLotes.Name = "gdvLotes";
            this.gdvLotes.Size = new System.Drawing.Size(864, 168);
            this.gdvLotes.TabIndex = 43;
            this.gdvLotes.Text = "Lotes";
            // 
            // sidePanel2
            // 
            this.sidePanel2.Controls.Add(this.dgvLotes);
            this.sidePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidePanel2.Location = new System.Drawing.Point(2, 20);
            this.sidePanel2.Name = "sidePanel2";
            this.sidePanel2.Size = new System.Drawing.Size(860, 146);
            this.sidePanel2.TabIndex = 2;
            this.sidePanel2.Text = "sidePanel2";
            // 
            // dgvLotes
            // 
            this.dgvLotes.DataSource = this.stpFactSelDetailCOSolicitudPagoBindingSource;
            this.dgvLotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLotes.Location = new System.Drawing.Point(0, 0);
            this.dgvLotes.MainView = this.gvTransferencias;
            this.dgvLotes.Name = "dgvLotes";
            this.dgvLotes.Size = new System.Drawing.Size(860, 146);
            this.dgvLotes.TabIndex = 1;
            this.dgvLotes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTransferencias});
            this.dgvLotes.DoubleClick += new System.EventHandler(this.dgvLotes_DoubleClick);
            // 
            // stpFactSelDetailCOSolicitudPagoBindingSource
            // 
            this.stpFactSelDetailCOSolicitudPagoBindingSource.DataMember = "stpFactSelDetailCOSolicitudPago";
            this.stpFactSelDetailCOSolicitudPagoBindingSource.DataSource = this.dbSAICBPOTesoreriaDataSet;
            // 
            // gvTransferencias
            // 
            this.gvTransferencias.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdLoteCargaNomina,
            this.colFolioLoteCargaNomina,
            this.colRazonSocial,
            this.colTIPO1,
            this.colTotalPagarBanco,
            this.colEmpleados,
            this.colBanco,
            this.colTipoPago2,
            this.colTIPOLEYOU});
            this.gvTransferencias.GridControl = this.dgvLotes;
            this.gvTransferencias.Name = "gvTransferencias";
            this.gvTransferencias.OptionsBehavior.Editable = false;
            this.gvTransferencias.OptionsView.ShowGroupPanel = false;
            this.gvTransferencias.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTotalPagarBanco, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colIdLoteCargaNomina
            // 
            this.colIdLoteCargaNomina.Caption = "Lote";
            this.colIdLoteCargaNomina.FieldName = "IdLoteCargaNomina";
            this.colIdLoteCargaNomina.Name = "colIdLoteCargaNomina";
            this.colIdLoteCargaNomina.Visible = true;
            this.colIdLoteCargaNomina.VisibleIndex = 0;
            this.colIdLoteCargaNomina.Width = 89;
            // 
            // colFolioLoteCargaNomina
            // 
            this.colFolioLoteCargaNomina.Caption = "Folio";
            this.colFolioLoteCargaNomina.FieldName = "FolioLoteCargaNomina";
            this.colFolioLoteCargaNomina.Name = "colFolioLoteCargaNomina";
            this.colFolioLoteCargaNomina.Visible = true;
            this.colFolioLoteCargaNomina.VisibleIndex = 1;
            this.colFolioLoteCargaNomina.Width = 89;
            // 
            // colRazonSocial
            // 
            this.colRazonSocial.Caption = "Tenedora";
            this.colRazonSocial.FieldName = "RazonSocial";
            this.colRazonSocial.Name = "colRazonSocial";
            this.colRazonSocial.Visible = true;
            this.colRazonSocial.VisibleIndex = 2;
            this.colRazonSocial.Width = 158;
            // 
            // colTIPO1
            // 
            this.colTIPO1.Caption = "Tipo";
            this.colTIPO1.FieldName = "TIPO";
            this.colTIPO1.Name = "colTIPO1";
            this.colTIPO1.Visible = true;
            this.colTIPO1.VisibleIndex = 3;
            this.colTIPO1.Width = 56;
            // 
            // colTotalPagarBanco
            // 
            this.colTotalPagarBanco.DisplayFormat.FormatString = "C2";
            this.colTotalPagarBanco.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalPagarBanco.FieldName = "Total";
            this.colTotalPagarBanco.Name = "colTotalPagarBanco";
            this.colTotalPagarBanco.Visible = true;
            this.colTotalPagarBanco.VisibleIndex = 6;
            this.colTotalPagarBanco.Width = 91;
            // 
            // colEmpleados
            // 
            this.colEmpleados.Caption = "No. Empleados";
            this.colEmpleados.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colEmpleados.FieldName = "NoEmpleados";
            this.colEmpleados.Name = "colEmpleados";
            this.colEmpleados.Visible = true;
            this.colEmpleados.VisibleIndex = 7;
            this.colEmpleados.Width = 81;
            // 
            // colBanco
            // 
            this.colBanco.Caption = "Banco";
            this.colBanco.FieldName = "BO";
            this.colBanco.Name = "colBanco";
            this.colBanco.Visible = true;
            this.colBanco.VisibleIndex = 4;
            // 
            // colTipoPago2
            // 
            this.colTipoPago2.Caption = "Tipo Pago";
            this.colTipoPago2.FieldName = "TipoPago";
            this.colTipoPago2.Name = "colTipoPago2";
            this.colTipoPago2.Visible = true;
            this.colTipoPago2.VisibleIndex = 8;
            this.colTipoPago2.Width = 54;
            // 
            // colTIPOLEYOU
            // 
            this.colTIPOLEYOU.Caption = "Tipo Cuenta";
            this.colTIPOLEYOU.FieldName = "TIPOLEYOUT";
            this.colTIPOLEYOU.Name = "colTIPOLEYOU";
            this.colTIPOLEYOU.Visible = true;
            this.colTIPOLEYOU.VisibleIndex = 5;
            this.colTIPOLEYOU.Width = 111;
            // 
            // stpFactSelDetailCOSolicitudPagoBindingSource1
            // 
            this.stpFactSelDetailCOSolicitudPagoBindingSource1.DataMember = "stpFactSelDetailCOSolicitudPago";
            this.stpFactSelDetailCOSolicitudPagoBindingSource1.DataSource = this.dbSAICAsimilados;
            // 
            // dbSAICAsimilados
            // 
            this.dbSAICAsimilados.DataSetName = "dbSAICAsimilados";
            this.dbSAICAsimilados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "No. Control:";
            // 
            // txtIdControl
            // 
            this.txtIdControl.Location = new System.Drawing.Point(87, 26);
            this.txtIdControl.Name = "txtIdControl";
            this.txtIdControl.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtIdControl.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.25F, System.Drawing.FontStyle.Bold);
            this.txtIdControl.Properties.Appearance.Options.UseBackColor = true;
            this.txtIdControl.Properties.Appearance.Options.UseFont = true;
            this.txtIdControl.Properties.Appearance.Options.UseTextOptions = true;
            this.txtIdControl.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtIdControl.Properties.Mask.EditMask = "00000";
            this.txtIdControl.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtIdControl.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtIdControl.Properties.MaxLength = 5;
            this.txtIdControl.Properties.ReadOnly = true;
            this.txtIdControl.Size = new System.Drawing.Size(92, 20);
            this.txtIdControl.TabIndex = 0;
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.progressBar1);
            this.sidePanel1.Controls.Add(this.groupControl3);
            this.sidePanel1.Controls.Add(this.groupControlIAS);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel1.Location = new System.Drawing.Point(0, 24);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(864, 73);
            this.sidePanel1.TabIndex = 46;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(555, 25);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 47;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.label1);
            this.groupControl3.Controls.Add(this.txtIdControl);
            this.groupControl3.Location = new System.Drawing.Point(10, 7);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(200, 52);
            this.groupControl3.TabIndex = 46;
            this.groupControl3.Text = "Control";
            // 
            // groupControlIAS
            // 
            this.groupControlIAS.Controls.Add(this.dateTimePickerPagoIAS);
            this.groupControlIAS.Controls.Add(this.label3);
            this.groupControlIAS.Location = new System.Drawing.Point(216, 7);
            this.groupControlIAS.Name = "groupControlIAS";
            this.groupControlIAS.Size = new System.Drawing.Size(276, 52);
            this.groupControlIAS.TabIndex = 45;
            this.groupControlIAS.Text = "Asimilados";
            // 
            // dateTimePickerPagoIAS
            // 
            this.dateTimePickerPagoIAS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerPagoIAS.Location = new System.Drawing.Point(150, 26);
            this.dateTimePickerPagoIAS.Name = "dateTimePickerPagoIAS";
            this.dateTimePickerPagoIAS.Size = new System.Drawing.Size(113, 21);
            this.dateTimePickerPagoIAS.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha de Pago Asimilados:";
            // 
            // sidePanel4
            // 
            this.sidePanel4.Controls.Add(this.btnEliminar);
            this.sidePanel4.Controls.Add(this.label2);
            this.sidePanel4.Controls.Add(this.btnAgregar);
            this.sidePanel4.Controls.Add(this.txtEmisora);
            this.sidePanel4.Controls.Add(this.label4);
            this.sidePanel4.Controls.Add(this.lblEmisora);
            this.sidePanel4.Controls.Add(this.cboFormatoBanco);
            this.sidePanel4.Controls.Add(this.dpFechaPago);
            this.sidePanel4.Controls.Add(this.lblFechaPago);
            this.sidePanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sidePanel4.Location = new System.Drawing.Point(0, 168);
            this.sidePanel4.Name = "sidePanel4";
            this.sidePanel4.Size = new System.Drawing.Size(864, 61);
            this.sidePanel4.TabIndex = 1;
            this.sidePanel4.Text = "sidePanel4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Sección Layout Bancario";
            // 
            // sidePanel5
            // 
            this.sidePanel5.Controls.Add(this.groupControl1);
            this.sidePanel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sidePanel5.Location = new System.Drawing.Point(0, 326);
            this.sidePanel5.Name = "sidePanel5";
            this.sidePanel5.Size = new System.Drawing.Size(864, 197);
            this.sidePanel5.TabIndex = 48;
            this.sidePanel5.Text = "sidePanel5";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dgvTransferencias);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(864, 196);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Layout Bancario";
            // 
            // dgvTransferencias
            // 
            this.dgvTransferencias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTransferencias.Location = new System.Drawing.Point(2, 20);
            this.dgvTransferencias.MainView = this.gvtransaccion;
            this.dgvTransferencias.Name = "dgvTransferencias";
            this.dgvTransferencias.Size = new System.Drawing.Size(860, 174);
            this.dgvTransferencias.TabIndex = 6;
            this.dgvTransferencias.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvtransaccion});
            // 
            // gvtransaccion
            // 
            this.gvtransaccion.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldTabla,
            this.colIdLote,
            this.colTenedora,
            this.colIdTenedora,
            this.colBancoOrigen,
            this.colFormato,
            this.colIdFormato,
            this.colEmisora,
            this.colFecha,
            this.colTotalPagar,
            this.colNoEmpleados,
            this.colTipo});
            this.gvtransaccion.GridControl = this.dgvTransferencias;
            this.gvtransaccion.Name = "gvtransaccion";
            this.gvtransaccion.OptionsBehavior.Editable = false;
            this.gvtransaccion.OptionsView.ShowGroupPanel = false;
            // 
            // coldTabla
            // 
            this.coldTabla.Caption = "gridColumn1";
            this.coldTabla.FieldName = "coldTabla";
            this.coldTabla.Name = "coldTabla";
            // 
            // colIdLote
            // 
            this.colIdLote.Caption = "Lote";
            this.colIdLote.FieldName = "colIdLote";
            this.colIdLote.Name = "colIdLote";
            this.colIdLote.Visible = true;
            this.colIdLote.VisibleIndex = 0;
            // 
            // colTenedora
            // 
            this.colTenedora.Caption = "Tenedora";
            this.colTenedora.FieldName = "colTenedora";
            this.colTenedora.Name = "colTenedora";
            this.colTenedora.Visible = true;
            this.colTenedora.VisibleIndex = 1;
            // 
            // colIdTenedora
            // 
            this.colIdTenedora.Caption = "gridColumn4";
            this.colIdTenedora.FieldName = "colIdTenedora";
            this.colIdTenedora.Name = "colIdTenedora";
            // 
            // colBancoOrigen
            // 
            this.colBancoOrigen.Caption = "Banco";
            this.colBancoOrigen.FieldName = "colBancoOrigen";
            this.colBancoOrigen.Name = "colBancoOrigen";
            this.colBancoOrigen.Visible = true;
            this.colBancoOrigen.VisibleIndex = 2;
            // 
            // colFormato
            // 
            this.colFormato.Caption = "Formato";
            this.colFormato.FieldName = "colFormato";
            this.colFormato.Name = "colFormato";
            this.colFormato.Visible = true;
            this.colFormato.VisibleIndex = 3;
            // 
            // colIdFormato
            // 
            this.colIdFormato.Caption = "gridColumn7";
            this.colIdFormato.FieldName = "colIdFormato";
            this.colIdFormato.Name = "colIdFormato";
            // 
            // colEmisora
            // 
            this.colEmisora.Caption = "Emisora";
            this.colEmisora.FieldName = "colEmisora";
            this.colEmisora.Name = "colEmisora";
            this.colEmisora.Visible = true;
            this.colEmisora.VisibleIndex = 4;
            // 
            // colFecha
            // 
            this.colFecha.Caption = "Fecha";
            this.colFecha.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.colFecha.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colFecha.FieldName = "colFecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 5;
            // 
            // colTotalPagar
            // 
            this.colTotalPagar.Caption = "Total Pagar";
            this.colTotalPagar.DisplayFormat.FormatString = "C2";
            this.colTotalPagar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalPagar.FieldName = "colTotalPagar";
            this.colTotalPagar.Name = "colTotalPagar";
            this.colTotalPagar.Visible = true;
            this.colTotalPagar.VisibleIndex = 6;
            // 
            // colNoEmpleados
            // 
            this.colNoEmpleados.Caption = "No. Empleados";
            this.colNoEmpleados.FieldName = "colNoEmpleados";
            this.colNoEmpleados.Name = "colNoEmpleados";
            this.colNoEmpleados.Visible = true;
            this.colNoEmpleados.VisibleIndex = 7;
            // 
            // colTipo
            // 
            this.colTipo.Caption = "Tipo";
            this.colTipo.FieldName = "colTipo";
            this.colTipo.Name = "colTipo";
            this.colTipo.Visible = true;
            this.colTipo.VisibleIndex = 8;
            // 
            // stpFactSelDetailCOSolicitudPagoTableAdapter
            // 
            this.stpFactSelDetailCOSolicitudPagoTableAdapter.ClearBeforeFill = true;
            // 
            // stpTesSelLayoutBancoFormatoPorBancoTableAdapter
            // 
            this.stpTesSelLayoutBancoFormatoPorBancoTableAdapter.ClearBeforeFill = true;
            // 
            // sidePanel6
            // 
            this.sidePanel6.Controls.Add(this.gdvLotes);
            this.sidePanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidePanel6.Location = new System.Drawing.Point(0, 0);
            this.sidePanel6.Name = "sidePanel6";
            this.sidePanel6.Size = new System.Drawing.Size(864, 168);
            this.sidePanel6.TabIndex = 2;
            this.sidePanel6.Text = "sidePanel6";
            // 
            // sidePanel8
            // 
            this.sidePanel8.Controls.Add(this.sidePanel6);
            this.sidePanel8.Controls.Add(this.sidePanel4);
            this.sidePanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidePanel8.Location = new System.Drawing.Point(0, 97);
            this.sidePanel8.Name = "sidePanel8";
            this.sidePanel8.Size = new System.Drawing.Size(864, 229);
            this.sidePanel8.TabIndex = 53;
            this.sidePanel8.Text = "sidePanel8";
            // 
            // stpFactSelDetailCOSolicitudPagoTableAdapter1
            // 
            this.stpFactSelDetailCOSolicitudPagoTableAdapter1.ClearBeforeFill = true;
            // 
            // frmxSolicitudPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 523);
            this.ControlBox = false;
            this.Controls.Add(this.sidePanel8);
            this.Controls.Add(this.sidePanel5);
            this.Controls.Add(this.sidePanel1);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmxSolicitudPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitud Pago";
            this.Load += new System.EventHandler(this.frmxSolicitudPago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmisora.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpTesSelLayoutBancoFormatoPorBancoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOTesoreriaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvLotes)).EndInit();
            this.gdvLotes.ResumeLayout(false);
            this.sidePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelDetailCOSolicitudPagoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTransferencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelDetailCOSolicitudPagoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICAsimilados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdControl.Properties)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlIAS)).EndInit();
            this.groupControlIAS.ResumeLayout(false);
            this.groupControlIAS.PerformLayout();
            this.sidePanel4.ResumeLayout(false);
            this.sidePanel4.PerformLayout();
            this.sidePanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransferencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvtransaccion)).EndInit();
            this.sidePanel6.ResumeLayout(false);
            this.sidePanel8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnSalir;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnSolicitarPagar;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.TextEdit txtEmisora;
        private System.Windows.Forms.Label lblEmisora;
        private System.Windows.Forms.DateTimePicker dpFechaPago;
        private System.Windows.Forms.Label lblFechaPago;
        private System.Windows.Forms.ComboBox cboFormatoBanco;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.GroupControl gdvLotes;
        private DevExpress.XtraGrid.GridControl dgvLotes;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTransferencias;
        private DevExpress.XtraGrid.Columns.GridColumn colIdLoteCargaNomina;
        private DevExpress.XtraGrid.Columns.GridColumn colFolioLoteCargaNomina;
        private DevExpress.XtraGrid.Columns.GridColumn colRazonSocial;
        private DevExpress.XtraGrid.Columns.GridColumn colTIPO1;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPagarBanco;
        private DevExpress.XtraEditors.SidePanel sidePanel5;
        private DevExpress.XtraGrid.GridControl dgvTransferencias;
        private DevExpress.XtraGrid.Views.Grid.GridView gvtransaccion;
        private DevExpress.XtraEditors.SidePanel sidePanel4;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtIdControl;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpleados;
        private DevExpress.XtraGrid.Columns.GridColumn colBanco;
        private DevExpress.XtraEditors.SimpleButton btnEliminar;
        private DevExpress.XtraEditors.SimpleButton btnAgregar;
        private dbSAICBPODataSetTableAdapters.stpUpdAutorizacionNominaTableAdapter stpUpdAutorizacionNominaTableAdapter1;
        private System.Windows.Forms.BindingSource stpTesSelFormatoLayoutBancoPorBancoBindingSource;
        private Tesoreria.dbSAICBPOTesoreriaDataSet dbSAICBPOTesoreriaDataSet;
        private System.Windows.Forms.BindingSource stpFactSelDetailCOSolicitudPagoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoPago2;
        private Tesoreria.dbSAICBPOTesoreriaDataSetTableAdapters.stpFactSelDetailCOSolicitudPagoTableAdapter stpFactSelDetailCOSolicitudPagoTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn coldTabla;
        private DevExpress.XtraGrid.Columns.GridColumn colIdLote;
        private DevExpress.XtraGrid.Columns.GridColumn colTenedora;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTenedora;
        private DevExpress.XtraGrid.Columns.GridColumn colBancoOrigen;
        private DevExpress.XtraGrid.Columns.GridColumn colFormato;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFormato;
        private DevExpress.XtraGrid.Columns.GridColumn colEmisora;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPagar;
        private DevExpress.XtraGrid.Columns.GridColumn colNoEmpleados;
        private DevExpress.XtraGrid.Columns.GridColumn colTipo;
        //private Tesoreria.dbSAICBPOTesoreriaDataSetTableAdapters.spPreguntas spPreguntas1;
        private System.Windows.Forms.BindingSource stpTesSelLayoutBancoFormatoPorBancoBindingSource;
        private Tesoreria.dbSAICBPOTesoreriaDataSetTableAdapters.stpTesSelLayoutBancoFormatoPorBancoTableAdapter stpTesSelLayoutBancoFormatoPorBancoTableAdapter;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SidePanel sidePanel6;
        private DevExpress.XtraEditors.SidePanel sidePanel8;
        private DevExpress.XtraGrid.Columns.GridColumn colTIPOLEYOU;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControlIAS;
        private System.Windows.Forms.DateTimePicker dateTimePickerPagoIAS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private Tesoreria.dbSAICBPOTesoreriaDataSetTableAdapters.RespuestasTesoreria respuestasTesoreria1;
        private DevExpress.XtraEditors.SidePanel sidePanel2;
        private System.Windows.Forms.BindingSource stpFactSelDetailCOSolicitudPagoBindingSource1;
        private Asimilados.dbSAICAsimilados dbSAICAsimilados;
        private Asimilados.dbSAICAsimiladosTableAdapters.stpFactSelDetailCOSolicitudPagoTableAdapter stpFactSelDetailCOSolicitudPagoTableAdapter1;
        private DevExpress.XtraBars.BarButtonItem btnAsimilados;
        private Asimilados.dbSAICAsimiladosTableAdapters.QueriesAsimilados queriesAsimilados1;
        private Facturas.dbSAICBPOFacturaTableAdapters.spSoloRespuesta spSoloRespuesta1;
    }
}