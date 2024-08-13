namespace winAppSAIC.Facturas.Catalogos
{
    partial class frmConceptoTenedora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConceptoTenedora));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnSalir = new DevExpress.XtraBars.BarButtonItem();
            this.btnNuevo = new DevExpress.XtraBars.BarButtonItem();
            this.btnCaptura = new DevExpress.XtraBars.BarButtonItem();
            this.btnGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnBorrar = new DevExpress.XtraBars.BarButtonItem();
            this.cbxFronting = new DevExpress.XtraEditors.GridLookUpEdit();
            this.vwcatFrontingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPOFactura = new winAppSAIC.Facturas.dbSAICBPOFactura();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdMatriz = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRazonSocial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreComercial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.gvrCatalogo = new DevExpress.XtraGrid.GridControl();
            this.vwFactConceptoFrontingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdFactConceptoTenedora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdFactClaveProduServ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescClaveProdServ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTenedoraMatriz = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRazonSocial1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescConceptoInterno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescEstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaCreacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioCreacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaModificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioModificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxEstatus = new DevExpress.XtraEditors.GridLookUpEdit();
            this.vwFactCatEstatusGlobalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEstatus0 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescEstatus0 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbxServicio = new DevExpress.XtraEditors.GridLookUpEdit();
            this.vwFactCatClaveProdServBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClaveClaveProdServ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescClaveProdServ0 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPalabrasSimilares = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            this.spSoloRespuesta1 = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.spSoloRespuesta();
            this.vwcatFrontingTableAdapter = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.vwcatFrontingTableAdapter();
            this.vwFactCatClaveProdServTableAdapter = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.vwFactCatClaveProdServTableAdapter();
            this.vwFactCatEstatusGlobalTableAdapter = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.vwFactCatEstatusGlobalTableAdapter();
            this.vwFactConceptoFrontingTableAdapter = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.vwFactConceptoFrontingTableAdapter();
            this.splashSMCargando = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::winAppSAIC.frmxCargandoInformacion), true, true);
            this.stpFactSelReporteFacturaPDFTableAdapter = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelReporteFacturaPDFTableAdapter();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel2 = new DevExpress.XtraEditors.SidePanel();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxFronting.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwcatFrontingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvrCatalogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwFactConceptoFrontingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxEstatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwFactCatEstatusGlobalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxServicio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwFactCatClaveProdServBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            this.sidePanel1.SuspendLayout();
            this.sidePanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnSalir,
            this.btnNuevo,
            this.btnBorrar,
            this.btnGuardar,
            this.btnCaptura});
            this.barManager1.MaxItemId = 5;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.FloatLocation = new System.Drawing.Point(268, 173);
            this.bar1.FloatSize = new System.Drawing.Size(54, 31);
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSalir),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnNuevo),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCaptura),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnGuardar)});
            this.bar1.Text = "Tools";
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
            // btnNuevo
            // 
            this.btnNuevo.Caption = "Nuevo";
            this.btnNuevo.Id = 1;
            this.btnNuevo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.ImageOptions.Image")));
            this.btnNuevo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.ImageOptions.LargeImage")));
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnNuevo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNuevo_ItemClick);
            // 
            // btnCaptura
            // 
            this.btnCaptura.Caption = "Cancelar captura";
            this.btnCaptura.Id = 4;
            this.btnCaptura.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCaptura.ImageOptions.Image")));
            this.btnCaptura.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCaptura.ImageOptions.LargeImage")));
            this.btnCaptura.Name = "btnCaptura";
            this.btnCaptura.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnCaptura.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCaptura_ItemClick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Caption = "Guardar";
            this.btnGuardar.Id = 3;
            this.btnGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.Image")));
            this.btnGuardar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.LargeImage")));
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnGuardar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGuardar_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(748, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 476);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(748, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 445);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(748, 31);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 445);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Caption = "Borrar";
            this.btnBorrar.Id = 2;
            this.btnBorrar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrar.ImageOptions.Image")));
            this.btnBorrar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBorrar.ImageOptions.LargeImage")));
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // cbxFronting
            // 
            this.cbxFronting.Location = new System.Drawing.Point(109, 53);
            this.cbxFronting.MenuManager = this.barManager1;
            this.cbxFronting.Name = "cbxFronting";
            this.cbxFronting.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxFronting.Properties.DataSource = this.vwcatFrontingBindingSource;
            this.cbxFronting.Properties.DisplayMember = "NombreComercial";
            this.cbxFronting.Properties.NullText = "";
            this.cbxFronting.Properties.ValueMember = "IdMatrizTenedora";
            this.cbxFronting.Properties.View = this.gridLookUpEdit1View;
            this.cbxFronting.Size = new System.Drawing.Size(487, 20);
            this.cbxFronting.TabIndex = 2;
            this.cbxFronting.Tag = "Fronting";
            this.cbxFronting.EditValueChanged += new System.EventHandler(this.cbxFronting_EditValueChanged);
            // 
            // vwcatFrontingBindingSource
            // 
            this.vwcatFrontingBindingSource.DataMember = "vwcatFronting";
            this.vwcatFrontingBindingSource.DataSource = this.dbSAICBPOFactura;
            // 
            // dbSAICBPOFactura
            // 
            this.dbSAICBPOFactura.DataSetName = "dbSAICBPOFactura";
            this.dbSAICBPOFactura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdMatriz,
            this.colRazonSocial,
            this.colNombreComercial});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdMatriz
            // 
            this.colIdMatriz.Caption = "ID";
            this.colIdMatriz.FieldName = "IdMatrizTenedora";
            this.colIdMatriz.Name = "colIdMatriz";
            this.colIdMatriz.Width = 76;
            // 
            // colRazonSocial
            // 
            this.colRazonSocial.Caption = "Razon Social";
            this.colRazonSocial.FieldName = "RazonSocial";
            this.colRazonSocial.Name = "colRazonSocial";
            this.colRazonSocial.Visible = true;
            this.colRazonSocial.VisibleIndex = 0;
            this.colRazonSocial.Width = 311;
            // 
            // colNombreComercial
            // 
            this.colNombreComercial.Caption = "Nombre Comercial";
            this.colNombreComercial.FieldName = "NombreComercial";
            this.colNombreComercial.Name = "colNombreComercial";
            this.colNombreComercial.Visible = true;
            this.colNombreComercial.VisibleIndex = 1;
            this.colNombreComercial.Width = 314;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(109, 29);
            this.txtId.MenuManager = this.barManager1;
            this.txtId.Name = "txtId";
            this.txtId.Properties.Appearance.Options.UseTextOptions = true;
            this.txtId.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtId.Properties.Mask.EditMask = "N0";
            this.txtId.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtId.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtId.Size = new System.Drawing.Size(56, 20);
            this.txtId.TabIndex = 5;
            // 
            // gvrCatalogo
            // 
            this.gvrCatalogo.DataSource = this.vwFactConceptoFrontingBindingSource;
            this.gvrCatalogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvrCatalogo.Location = new System.Drawing.Point(0, 0);
            this.gvrCatalogo.MainView = this.gridView3;
            this.gvrCatalogo.MenuManager = this.barManager1;
            this.gvrCatalogo.Name = "gvrCatalogo";
            this.gvrCatalogo.Size = new System.Drawing.Size(748, 288);
            this.gvrCatalogo.TabIndex = 14;
            this.gvrCatalogo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            this.gvrCatalogo.DoubleClick += new System.EventHandler(this.gvrCatalogo_DoubleClick);
            // 
            // vwFactConceptoFrontingBindingSource
            // 
            this.vwFactConceptoFrontingBindingSource.DataMember = "vwFactConceptoFronting";
            this.vwFactConceptoFrontingBindingSource.DataSource = this.dbSAICBPOFactura;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdFactConceptoTenedora,
            this.colIdFactClaveProduServ,
            this.colDescClaveProdServ,
            this.colIdTenedoraMatriz,
            this.colRazonSocial1,
            this.colDescConceptoInterno,
            this.colIdEstatus,
            this.colDescEstatus,
            this.colFechaCreacion,
            this.colUsuarioCreacion,
            this.colFechaModificacion,
            this.colUsuarioModificacion});
            this.gridView3.GridControl = this.gvrCatalogo;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsBehavior.Editable = false;
            this.gridView3.OptionsPrint.PrintFilterInfo = true;
            this.gridView3.OptionsView.ColumnAutoWidth = false;
            this.gridView3.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView3.OptionsView.RowAutoHeight = true;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colIdFactConceptoTenedora
            // 
            this.colIdFactConceptoTenedora.Caption = "Id";
            this.colIdFactConceptoTenedora.FieldName = "IdFactConceptoFronting";
            this.colIdFactConceptoTenedora.Name = "colIdFactConceptoTenedora";
            this.colIdFactConceptoTenedora.Visible = true;
            this.colIdFactConceptoTenedora.VisibleIndex = 0;
            this.colIdFactConceptoTenedora.Width = 59;
            // 
            // colIdFactClaveProduServ
            // 
            this.colIdFactClaveProduServ.Caption = "Clave";
            this.colIdFactClaveProduServ.FieldName = "IdFactClaveProduServ";
            this.colIdFactClaveProduServ.Name = "colIdFactClaveProduServ";
            this.colIdFactClaveProduServ.Width = 78;
            // 
            // colDescClaveProdServ
            // 
            this.colDescClaveProdServ.Caption = "Servicio";
            this.colDescClaveProdServ.FieldName = "Desc";
            this.colDescClaveProdServ.Name = "colDescClaveProdServ";
            this.colDescClaveProdServ.Visible = true;
            this.colDescClaveProdServ.VisibleIndex = 1;
            this.colDescClaveProdServ.Width = 297;
            // 
            // colIdTenedoraMatriz
            // 
            this.colIdTenedoraMatriz.FieldName = "IdTenedoraMatriz";
            this.colIdTenedoraMatriz.Name = "colIdTenedoraMatriz";
            // 
            // colRazonSocial1
            // 
            this.colRazonSocial1.Caption = "Fronting";
            this.colRazonSocial1.FieldName = "RazonSocial";
            this.colRazonSocial1.Name = "colRazonSocial1";
            this.colRazonSocial1.Visible = true;
            this.colRazonSocial1.VisibleIndex = 2;
            this.colRazonSocial1.Width = 304;
            // 
            // colDescConceptoInterno
            // 
            this.colDescConceptoInterno.Caption = "Concepto Interno";
            this.colDescConceptoInterno.FieldName = "DescInterno";
            this.colDescConceptoInterno.Name = "colDescConceptoInterno";
            this.colDescConceptoInterno.Width = 281;
            // 
            // colIdEstatus
            // 
            this.colIdEstatus.FieldName = "IdEstatus";
            this.colIdEstatus.Name = "colIdEstatus";
            // 
            // colDescEstatus
            // 
            this.colDescEstatus.Caption = "Estatus";
            this.colDescEstatus.FieldName = "DescEstatus";
            this.colDescEstatus.Name = "colDescEstatus";
            this.colDescEstatus.Visible = true;
            this.colDescEstatus.VisibleIndex = 3;
            this.colDescEstatus.Width = 66;
            // 
            // colFechaCreacion
            // 
            this.colFechaCreacion.FieldName = "FechaCreacion";
            this.colFechaCreacion.Name = "colFechaCreacion";
            this.colFechaCreacion.Width = 44;
            // 
            // colUsuarioCreacion
            // 
            this.colUsuarioCreacion.FieldName = "UsuarioCreacion";
            this.colUsuarioCreacion.Name = "colUsuarioCreacion";
            this.colUsuarioCreacion.Width = 44;
            // 
            // colFechaModificacion
            // 
            this.colFechaModificacion.FieldName = "FechaModificacion";
            this.colFechaModificacion.Name = "colFechaModificacion";
            this.colFechaModificacion.Width = 44;
            // 
            // colUsuarioModificacion
            // 
            this.colUsuarioModificacion.FieldName = "UsuarioModificacion";
            this.colUsuarioModificacion.Name = "colUsuarioModificacion";
            this.colUsuarioModificacion.Width = 78;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.cbxFronting);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.txtId);
            this.groupControl1.Controls.Add(this.cbxEstatus);
            this.groupControl1.Controls.Add(this.cbxServicio);
            this.groupControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupControl1.Location = new System.Drawing.Point(82, 6);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(629, 141);
            this.groupControl1.TabIndex = 15;
            this.groupControl1.Text = "Información";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(56, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Estatus:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(52, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Fronting:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(56, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Servicio:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(82, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Id:";
            // 
            // cbxEstatus
            // 
            this.cbxEstatus.Location = new System.Drawing.Point(109, 105);
            this.cbxEstatus.MenuManager = this.barManager1;
            this.cbxEstatus.Name = "cbxEstatus";
            this.cbxEstatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxEstatus.Properties.DataSource = this.vwFactCatEstatusGlobalBindingSource;
            this.cbxEstatus.Properties.DisplayMember = "DescEstatus";
            this.cbxEstatus.Properties.NullText = "";
            this.cbxEstatus.Properties.PopupSizeable = false;
            this.cbxEstatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbxEstatus.Properties.ValueMember = "IdEstatus";
            this.cbxEstatus.Properties.View = this.gridView2;
            this.cbxEstatus.Size = new System.Drawing.Size(125, 20);
            this.cbxEstatus.TabIndex = 4;
            this.cbxEstatus.Tag = "Estatus";
            // 
            // vwFactCatEstatusGlobalBindingSource
            // 
            this.vwFactCatEstatusGlobalBindingSource.DataMember = "vwFactCatEstatusGlobal";
            this.vwFactCatEstatusGlobalBindingSource.DataSource = this.dbSAICBPOFactura;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEstatus0,
            this.colDescEstatus0});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colIdEstatus0
            // 
            this.colIdEstatus0.Caption = "IdEstatus";
            this.colIdEstatus0.FieldName = "IdEstatus";
            this.colIdEstatus0.Name = "colIdEstatus0";
            // 
            // colDescEstatus0
            // 
            this.colDescEstatus0.Caption = "Estatus";
            this.colDescEstatus0.FieldName = "DescEstatus";
            this.colDescEstatus0.Name = "colDescEstatus0";
            this.colDescEstatus0.Visible = true;
            this.colDescEstatus0.VisibleIndex = 0;
            // 
            // cbxServicio
            // 
            this.cbxServicio.Location = new System.Drawing.Point(109, 79);
            this.cbxServicio.MenuManager = this.barManager1;
            this.cbxServicio.Name = "cbxServicio";
            this.cbxServicio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxServicio.Properties.DataSource = this.vwFactCatClaveProdServBindingSource;
            this.cbxServicio.Properties.DisplayMember = "Clave";
            this.cbxServicio.Properties.NullText = "";
            this.cbxServicio.Properties.ValueMember = "IdFactClaveProdServ";
            this.cbxServicio.Properties.View = this.gridView1;
            this.cbxServicio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbxServicio.Size = new System.Drawing.Size(487, 20);
            this.cbxServicio.TabIndex = 0;
            this.cbxServicio.Tag = "Servicio";
            // 
            // vwFactCatClaveProdServBindingSource
            // 
            this.vwFactCatClaveProdServBindingSource.DataMember = "vwFactCatClaveProdServ";
            this.vwFactCatClaveProdServBindingSource.DataSource = this.dbSAICBPOFactura;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colClaveClaveProdServ,
            this.colDescClaveProdServ0,
            this.colPalabrasSimilares});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "IdFactClaveProdServ";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 51;
            // 
            // colClaveClaveProdServ
            // 
            this.colClaveClaveProdServ.Caption = "Clave SAT";
            this.colClaveClaveProdServ.FieldName = "Clave";
            this.colClaveClaveProdServ.Name = "colClaveClaveProdServ";
            this.colClaveClaveProdServ.Visible = true;
            this.colClaveClaveProdServ.VisibleIndex = 1;
            this.colClaveClaveProdServ.Width = 95;
            // 
            // colDescClaveProdServ0
            // 
            this.colDescClaveProdServ0.Caption = "Descripción ";
            this.colDescClaveProdServ0.FieldName = "Desc";
            this.colDescClaveProdServ0.Name = "colDescClaveProdServ0";
            this.colDescClaveProdServ0.Visible = true;
            this.colDescClaveProdServ0.VisibleIndex = 2;
            this.colDescClaveProdServ0.Width = 276;
            // 
            // colPalabrasSimilares
            // 
            this.colPalabrasSimilares.Caption = "Palabras Similares";
            this.colPalabrasSimilares.FieldName = "PalabrasSimilares";
            this.colPalabrasSimilares.Name = "colPalabrasSimilares";
            this.colPalabrasSimilares.Visible = true;
            this.colPalabrasSimilares.VisibleIndex = 3;
            this.colPalabrasSimilares.Width = 279;
            // 
            // gridSplitContainer1
            // 
            this.gridSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSplitContainer1.Grid = this.gvrCatalogo;
            this.gridSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.gridSplitContainer1.Name = "gridSplitContainer1";
            this.gridSplitContainer1.Panel1.Controls.Add(this.gvrCatalogo);
            this.gridSplitContainer1.Size = new System.Drawing.Size(748, 288);
            this.gridSplitContainer1.TabIndex = 25;
            // 
            // vwcatFrontingTableAdapter
            // 
            this.vwcatFrontingTableAdapter.ClearBeforeFill = true;
            // 
            // vwFactCatClaveProdServTableAdapter
            // 
            this.vwFactCatClaveProdServTableAdapter.ClearBeforeFill = true;
            // 
            // vwFactCatEstatusGlobalTableAdapter
            // 
            this.vwFactCatEstatusGlobalTableAdapter.ClearBeforeFill = true;
            // 
            // vwFactConceptoFrontingTableAdapter
            // 
            this.vwFactConceptoFrontingTableAdapter.ClearBeforeFill = true;
            // 
            // splashSMCargando
            // 
            this.splashSMCargando.ClosingDelay = 500;
            // 
            // stpFactSelReporteFacturaPDFTableAdapter
            // 
            this.stpFactSelReporteFacturaPDFTableAdapter.ClearBeforeFill = true;
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.groupControl1);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel1.Location = new System.Drawing.Point(0, 31);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(748, 157);
            this.sidePanel1.TabIndex = 30;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // sidePanel2
            // 
            this.sidePanel2.Controls.Add(this.gridSplitContainer1);
            this.sidePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidePanel2.Location = new System.Drawing.Point(0, 188);
            this.sidePanel2.Name = "sidePanel2";
            this.sidePanel2.Size = new System.Drawing.Size(748, 288);
            this.sidePanel2.TabIndex = 31;
            this.sidePanel2.Text = "sidePanel2";
            // 
            // frmConceptoTenedora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 476);
            this.ControlBox = false;
            this.Controls.Add(this.sidePanel2);
            this.Controls.Add(this.sidePanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmConceptoTenedora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conceptos de Fronting";
            this.Load += new System.EventHandler(this.frmConceptoTenedora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxFronting.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwcatFrontingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvrCatalogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwFactConceptoFrontingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbxEstatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwFactCatEstatusGlobalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxServicio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwFactCatClaveProdServBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
            this.sidePanel1.ResumeLayout(false);
            this.sidePanel2.ResumeLayout(false);
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
        private DevExpress.XtraEditors.GridLookUpEdit cbxFronting;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraBars.BarButtonItem btnNuevo;
        private DevExpress.XtraBars.BarButtonItem btnBorrar;
        private DevExpress.XtraBars.BarButtonItem btnGuardar;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMatriz;
        private DevExpress.XtraGrid.Columns.GridColumn colRazonSocial;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreComercial;
        private DevExpress.XtraGrid.GridControl gvrCatalogo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFactConceptoTenedora;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFactClaveProduServ;
        private DevExpress.XtraGrid.Columns.GridColumn colDescClaveProdServ;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTenedoraMatriz;
        private DevExpress.XtraGrid.Columns.GridColumn colRazonSocial1;
        private DevExpress.XtraGrid.Columns.GridColumn colDescConceptoInterno;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstatus;
        private DevExpress.XtraGrid.Columns.GridColumn colDescEstatus;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaCreacion;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioCreacion;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaModificacion;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioModificacion;
        private DevExpress.XtraBars.BarButtonItem btnCaptura;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GridLookUpEdit cbxEstatus;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstatus0;
        private DevExpress.XtraGrid.Columns.GridColumn colDescEstatus0;
        private DevExpress.XtraEditors.GridLookUpEdit cbxServicio;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colClaveClaveProdServ;
        private DevExpress.XtraGrid.Columns.GridColumn colDescClaveProdServ0;
        private DevExpress.XtraGrid.Columns.GridColumn colPalabrasSimilares;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private dbSAICBPOFacturaTableAdapters.spSoloRespuesta spSoloRespuesta1;
        private dbSAICBPOFactura dbSAICBPOFactura;
        private System.Windows.Forms.BindingSource vwcatFrontingBindingSource;
        private dbSAICBPOFacturaTableAdapters.vwcatFrontingTableAdapter vwcatFrontingTableAdapter;
        private System.Windows.Forms.BindingSource vwFactCatClaveProdServBindingSource;
        private dbSAICBPOFacturaTableAdapters.vwFactCatClaveProdServTableAdapter vwFactCatClaveProdServTableAdapter;
        private System.Windows.Forms.BindingSource vwFactCatEstatusGlobalBindingSource;
        private dbSAICBPOFacturaTableAdapters.vwFactCatEstatusGlobalTableAdapter vwFactCatEstatusGlobalTableAdapter;
        private System.Windows.Forms.BindingSource vwFactConceptoFrontingBindingSource;
        private dbSAICBPOFacturaTableAdapters.vwFactConceptoFrontingTableAdapter vwFactConceptoFrontingTableAdapter;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashSMCargando;
        private dbSAICBPOFacturaTableAdapters.stpFactSelReporteFacturaPDFTableAdapter stpFactSelReporteFacturaPDFTableAdapter;
        private DevExpress.XtraEditors.SidePanel sidePanel2;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
    }
}