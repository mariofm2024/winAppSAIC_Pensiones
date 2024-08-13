namespace winAppSAIC.Seguros
{
    partial class frmxPolizas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmxPolizas));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnSalir = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dbSAICBPOCatalogosDataSet = new winAppSAIC.dbSAICBPOCatalogosDataSet();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.btnEditar = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnNuevo = new DevExpress.XtraEditors.SimpleButton();
            this.cboIdPoliza = new DevExpress.XtraEditors.GridLookUpEdit();
            this.catPolizaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAIC_Catalogos = new winAppSAIC.Catalogos.dbSAIC_Catalogos();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdPoliza = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoPoliza = new DevExpress.XtraGrid.Columns.GridColumn();
            this.celIdCIAAseguradora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.celIdTipoSeguro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.celConcepto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.celIdCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.celIdTenedora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.celIdTipoMetodoPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.celIdEstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.celFechaEMI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaIniVig = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaFinVig = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioModificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtConcepto = new DevExpress.XtraEditors.TextEdit();
            this.dtFechaInicioVig = new DevExpress.XtraEditors.DateEdit();
            this.UsuarioCreacionTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.UsuarioModificacionTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.txtIdPoliza = new DevExpress.XtraEditors.TextEdit();
            this.cboCliente = new DevExpress.XtraEditors.GridLookUpEdit();
            this.stpSelClienteSeguroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdClienteComercial1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescNombreComercial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtNoPoliza = new DevExpress.XtraEditors.TextEdit();
            this.dtFechaFinVig = new DevExpress.XtraEditors.DateEdit();
            this.dtFechaEmision = new DevExpress.XtraEditors.DateEdit();
            this.cboTenedora = new DevExpress.XtraEditors.GridLookUpEdit();
            this.vwCatTenedoraMatrizBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPODataSet = new winAppSAIC.dbSAICBPODataSet();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdTenedora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenedora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboMetodoPago = new DevExpress.XtraEditors.GridLookUpEdit();
            this.vwCatMetodoPagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdTipoMetodoPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescTipoMetodoPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboIdEstatus = new DevExpress.XtraEditors.GridLookUpEdit();
            this.vwCatEstatusSeguroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescEstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbTipoSeguro = new DevExpress.XtraEditors.GridLookUpEdit();
            this.vwCatTipoSeguroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDescTipoSeguro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdTipoSeguro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbCIA = new DevExpress.XtraEditors.GridLookUpEdit();
            this.vwCatCIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCIAAseguradora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboPagadorPoliza = new DevExpress.XtraEditors.GridLookUpEdit();
            this.vwCatTipoPagadorPolizaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView7 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdTipoPagadorPoliza = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescTipoPagadorPoliza = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemForUsuarioCreacion = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForUsuarioModificacion = new DevExpress.XtraLayout.LayoutControlItem();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup6 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemCIA = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForIdActividadComercial = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForConcepto = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForIdCliente = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForFechaBaja = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForIdEstatus = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTipoSeguro = new DevExpress.XtraLayout.LayoutControlItem();
            this.cbPagadorPoliza = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.vwCatTenedoraSABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stpSelCIAAseguradorasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stpSelObtenerTipoPolizaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.stpSelClienteSeguroTableAdapter = new winAppSAIC.Catalogos.dbSAIC_CatalogosTableAdapters.stpSelClienteSeguroTableAdapter();
            this.vwCatTipoSeguroTableAdapter = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.vwCatTipoSeguroTableAdapter();
            this.vwCatMetodoPagoTableAdapter = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.vwCatMetodoPagoTableAdapter();
            this.stpSelCIAAseguradorasTableAdapter = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelCIAAseguradorasTableAdapter();
            this.catPolizaTableAdapter1 = new winAppSAIC.Catalogos.dbSAIC_CatalogosTableAdapters.CatPolizaTableAdapter();
            this.stpSelObtenerTipoPolizaTableAdapter = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelObtenerTipoPolizaTableAdapter();
            this.vwCatEstatusSeguroTableAdapter = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.vwCatEstatusSeguroTableAdapter();
            this.vwCatTenedoraSATableAdapter = new winAppSAIC.dbSAICBPODataSetTableAdapters.vwCatTenedoraSATableAdapter();
            this.vwCatCIATableAdapter = new winAppSAIC.Catalogos.dbSAIC_CatalogosTableAdapters.vwCatCIATableAdapter();
            this.vwCatTipoPagadorPolizaTableAdapter = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.vwCatTipoPagadorPolizaTableAdapter();
            this.vwCatTenedoraMatrizTableAdapter = new winAppSAIC.dbSAICBPODataSetTableAdapters.vwCatTenedoraMatrizTableAdapter();
            this.catPolizaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboIdPoliza.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catPolizaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAIC_Catalogos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConcepto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaInicioVig.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaInicioVig.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioCreacionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioModificacionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdPoliza.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelClienteSeguroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoPoliza.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaFinVig.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaFinVig.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaEmision.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaEmision.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTenedora.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCatTenedoraMatrizBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMetodoPago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCatMetodoPagoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboIdEstatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCatEstatusSeguroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoSeguro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCatTipoSeguroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCIA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCatCIABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPagadorPoliza.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCatTipoPagadorPolizaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUsuarioCreacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUsuarioModificacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemCIA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdActividadComercial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForConcepto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFechaBaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdEstatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTipoSeguro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPagadorPoliza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCatTenedoraSABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelCIAAseguradorasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelObtenerTipoPolizaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catPolizaBindingSource1)).BeginInit();
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
            this.btnSalir});
            this.barManager1.MaxItemId = 1;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSalir, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnSalir
            // 
            this.btnSalir.Caption = "Salir";
            this.btnSalir.Id = 0;
            this.btnSalir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.ImageOptions.Image")));
            this.btnSalir.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.ImageOptions.LargeImage")));
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSalir_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(996, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 313);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(996, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 282);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(996, 31);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 282);
            // 
            // dbSAICBPOCatalogosDataSet
            // 
            this.dbSAICBPOCatalogosDataSet.DataSetName = "dbSAICBPOCatalogosDataSet";
            this.dbSAICBPOCatalogosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.btnEditar);
            this.dataLayoutControl1.Controls.Add(this.btnGuardar);
            this.dataLayoutControl1.Controls.Add(this.btnCancelar);
            this.dataLayoutControl1.Controls.Add(this.btnNuevo);
            this.dataLayoutControl1.Controls.Add(this.cboIdPoliza);
            this.dataLayoutControl1.Controls.Add(this.txtConcepto);
            this.dataLayoutControl1.Controls.Add(this.dtFechaInicioVig);
            this.dataLayoutControl1.Controls.Add(this.UsuarioCreacionTextEdit);
            this.dataLayoutControl1.Controls.Add(this.UsuarioModificacionTextEdit);
            this.dataLayoutControl1.Controls.Add(this.txtIdPoliza);
            this.dataLayoutControl1.Controls.Add(this.cboCliente);
            this.dataLayoutControl1.Controls.Add(this.txtNoPoliza);
            this.dataLayoutControl1.Controls.Add(this.dtFechaFinVig);
            this.dataLayoutControl1.Controls.Add(this.dtFechaEmision);
            this.dataLayoutControl1.Controls.Add(this.cboTenedora);
            this.dataLayoutControl1.Controls.Add(this.cboMetodoPago);
            this.dataLayoutControl1.Controls.Add(this.cboIdEstatus);
            this.dataLayoutControl1.Controls.Add(this.cbTipoSeguro);
            this.dataLayoutControl1.Controls.Add(this.cbCIA);
            this.dataLayoutControl1.Controls.Add(this.cboPagadorPoliza);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForUsuarioCreacion,
            this.ItemForUsuarioModificacion});
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 31);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(178, 93, 462, 415);
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(996, 282);
            this.dataLayoutControl1.TabIndex = 4;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // btnEditar
            // 
            this.btnEditar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.ImageOptions.Image")));
            this.btnEditar.Location = new System.Drawing.Point(827, 107);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(157, 22);
            this.btnEditar.StyleController = this.dataLayoutControl1;
            this.btnEditar.TabIndex = 46;
            this.btnEditar.Text = "Editar Poliza";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(827, 133);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(157, 22);
            this.btnGuardar.StyleController = this.dataLayoutControl1;
            this.btnGuardar.TabIndex = 48;
            this.btnGuardar.Text = "Guardar Poliza";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.ImageOptions.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(827, 159);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(157, 22);
            this.btnCancelar.StyleController = this.dataLayoutControl1;
            this.btnCancelar.TabIndex = 47;
            this.btnCancelar.Text = "Cancelar captura";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.ImageOptions.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(827, 81);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(157, 22);
            this.btnNuevo.StyleController = this.dataLayoutControl1;
            this.btnNuevo.TabIndex = 45;
            this.btnNuevo.Text = "Nuevo Poliza";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // cboIdPoliza
            // 
            this.cboIdPoliza.Location = new System.Drawing.Point(118, 12);
            this.cboIdPoliza.MenuManager = this.barManager1;
            this.cboIdPoliza.Name = "cboIdPoliza";
            this.cboIdPoliza.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboIdPoliza.Properties.DataSource = this.catPolizaBindingSource1;
            this.cboIdPoliza.Properties.DisplayMember = "NoPoliza";
            this.cboIdPoliza.Properties.NullText = "";
            this.cboIdPoliza.Properties.ValueMember = "IdPoliza";
            this.cboIdPoliza.Properties.View = this.gridLookUpEdit1View;
            this.cboIdPoliza.Size = new System.Drawing.Size(705, 20);
            this.cboIdPoliza.StyleController = this.dataLayoutControl1;
            this.cboIdPoliza.TabIndex = 1;
            this.cboIdPoliza.EditValueChanged += new System.EventHandler(this.cboIdClienteProveedor_EditValueChanged);
            // 
            // catPolizaBindingSource
            // 
            this.catPolizaBindingSource.DataMember = "CatPoliza";
            this.catPolizaBindingSource.DataSource = this.dbSAIC_Catalogos;
            // 
            // dbSAIC_Catalogos
            // 
            this.dbSAIC_Catalogos.DataSetName = "dbSAIC_Catalogos";
            this.dbSAIC_Catalogos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdPoliza,
            this.colNoPoliza,
            this.celIdCIAAseguradora,
            this.celIdTipoSeguro,
            this.celConcepto,
            this.celIdCliente,
            this.celIdTenedora,
            this.celIdTipoMetodoPago,
            this.celIdEstatus,
            this.celFechaEMI,
            this.colFechaIniVig,
            this.colFechaFinVig,
            this.colUsuarioModificacion});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ColumnAutoWidth = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdPoliza
            // 
            this.colIdPoliza.Caption = "Id Poliza";
            this.colIdPoliza.FieldName = "IdPoliza";
            this.colIdPoliza.Name = "colIdPoliza";
            this.colIdPoliza.Visible = true;
            this.colIdPoliza.VisibleIndex = 0;
            this.colIdPoliza.Width = 90;
            // 
            // colNoPoliza
            // 
            this.colNoPoliza.Caption = "No Poliza";
            this.colNoPoliza.FieldName = "NoPoliza";
            this.colNoPoliza.Name = "colNoPoliza";
            this.colNoPoliza.Visible = true;
            this.colNoPoliza.VisibleIndex = 1;
            this.colNoPoliza.Width = 250;
            // 
            // celIdCIAAseguradora
            // 
            this.celIdCIAAseguradora.Caption = "IdCIAAseguradora";
            this.celIdCIAAseguradora.FieldName = "IdCIAAseguradora";
            this.celIdCIAAseguradora.Name = "celIdCIAAseguradora";
            // 
            // celIdTipoSeguro
            // 
            this.celIdTipoSeguro.Caption = "IdTipoSeguro";
            this.celIdTipoSeguro.FieldName = "IdTipoSeguro";
            this.celIdTipoSeguro.Name = "celIdTipoSeguro";
            // 
            // celConcepto
            // 
            this.celConcepto.Caption = "Concepto";
            this.celConcepto.FieldName = "Concepto";
            this.celConcepto.Name = "celConcepto";
            this.celConcepto.Visible = true;
            this.celConcepto.VisibleIndex = 2;
            // 
            // celIdCliente
            // 
            this.celIdCliente.Caption = "IdCliente";
            this.celIdCliente.FieldName = "IdCliente";
            this.celIdCliente.Name = "celIdCliente";
            // 
            // celIdTenedora
            // 
            this.celIdTenedora.Caption = "IdTenedora";
            this.celIdTenedora.FieldNameSortGroup = "IdTenedora";
            this.celIdTenedora.Name = "celIdTenedora";
            // 
            // celIdTipoMetodoPago
            // 
            this.celIdTipoMetodoPago.Caption = "IdTipoMetodoPago";
            this.celIdTipoMetodoPago.FieldName = "IdTipoMetodoPago";
            this.celIdTipoMetodoPago.Name = "celIdTipoMetodoPago";
            // 
            // celIdEstatus
            // 
            this.celIdEstatus.Caption = "IdEstatus";
            this.celIdEstatus.FieldName = "IdEstatus";
            this.celIdEstatus.Name = "celIdEstatus";
            // 
            // celFechaEMI
            // 
            this.celFechaEMI.Caption = "Fecha EMI";
            this.celFechaEMI.FieldNameSortGroup = "FechaEMI";
            this.celFechaEMI.Name = "celFechaEMI";
            // 
            // colFechaIniVig
            // 
            this.colFechaIniVig.Caption = "Fecha Inicio Vigencia";
            this.colFechaIniVig.FieldName = "FechaIniVig";
            this.colFechaIniVig.Name = "colFechaIniVig";
            this.colFechaIniVig.Visible = true;
            this.colFechaIniVig.VisibleIndex = 3;
            // 
            // colFechaFinVig
            // 
            this.colFechaFinVig.Caption = "Fecha Fin Vigencia";
            this.colFechaFinVig.FieldName = "FechaFinVig";
            this.colFechaFinVig.Name = "colFechaFinVig";
            this.colFechaFinVig.Visible = true;
            this.colFechaFinVig.VisibleIndex = 4;
            // 
            // colUsuarioModificacion
            // 
            this.colUsuarioModificacion.Caption = "UsuarioModificacion";
            this.colUsuarioModificacion.FieldName = "UsuarioModificacion";
            this.colUsuarioModificacion.Name = "colUsuarioModificacion";
            // 
            // txtConcepto
            // 
            this.txtConcepto.Location = new System.Drawing.Point(130, 139);
            this.txtConcepto.MenuManager = this.barManager1;
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtConcepto.Properties.MaxLength = 100;
            this.txtConcepto.Size = new System.Drawing.Size(681, 20);
            this.txtConcepto.StyleController = this.dataLayoutControl1;
            this.txtConcepto.TabIndex = 5;
            this.txtConcepto.Tag = "Concepto";
            // 
            // dtFechaInicioVig
            // 
            this.dtFechaInicioVig.EditValue = null;
            this.dtFechaInicioVig.Enabled = false;
            this.dtFechaInicioVig.Location = new System.Drawing.Point(416, 235);
            this.dtFechaInicioVig.MenuManager = this.barManager1;
            this.dtFechaInicioVig.Name = "dtFechaInicioVig";
            this.dtFechaInicioVig.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaInicioVig.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaInicioVig.Size = new System.Drawing.Size(154, 20);
            this.dtFechaInicioVig.StyleController = this.dataLayoutControl1;
            this.dtFechaInicioVig.TabIndex = 44;
            this.dtFechaInicioVig.TabStop = false;
            this.dtFechaInicioVig.Tag = "Fecha Inicio Vigencia";
            // 
            // UsuarioCreacionTextEdit
            // 
            this.UsuarioCreacionTextEdit.Location = new System.Drawing.Point(125, 301);
            this.UsuarioCreacionTextEdit.MenuManager = this.barManager1;
            this.UsuarioCreacionTextEdit.Name = "UsuarioCreacionTextEdit";
            this.UsuarioCreacionTextEdit.Size = new System.Drawing.Size(644, 20);
            this.UsuarioCreacionTextEdit.StyleController = this.dataLayoutControl1;
            this.UsuarioCreacionTextEdit.TabIndex = 43;
            // 
            // UsuarioModificacionTextEdit
            // 
            this.UsuarioModificacionTextEdit.Location = new System.Drawing.Point(125, 325);
            this.UsuarioModificacionTextEdit.MenuManager = this.barManager1;
            this.UsuarioModificacionTextEdit.Name = "UsuarioModificacionTextEdit";
            this.UsuarioModificacionTextEdit.Size = new System.Drawing.Size(644, 20);
            this.UsuarioModificacionTextEdit.StyleController = this.dataLayoutControl1;
            this.UsuarioModificacionTextEdit.TabIndex = 44;
            // 
            // txtIdPoliza
            // 
            this.txtIdPoliza.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtIdPoliza.Enabled = false;
            this.txtIdPoliza.Location = new System.Drawing.Point(130, 66);
            this.txtIdPoliza.MenuManager = this.barManager1;
            this.txtIdPoliza.Name = "txtIdPoliza";
            this.txtIdPoliza.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.txtIdPoliza.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtIdPoliza.Size = new System.Drawing.Size(42, 20);
            this.txtIdPoliza.StyleController = this.dataLayoutControl1;
            this.txtIdPoliza.TabIndex = 2;
            this.txtIdPoliza.TabStop = false;
            // 
            // cboCliente
            // 
            this.cboCliente.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.cboCliente.Location = new System.Drawing.Point(130, 163);
            this.cboCliente.MenuManager = this.barManager1;
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboCliente.Properties.DataSource = this.stpSelClienteSeguroBindingSource;
            this.cboCliente.Properties.DisplayMember = "NombreComercial";
            this.cboCliente.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.cboCliente.Properties.NullText = "";
            this.cboCliente.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cboCliente.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboCliente.Properties.ValueMember = "IdCliente";
            this.cboCliente.Properties.View = this.gridView1;
            this.cboCliente.Size = new System.Drawing.Size(681, 20);
            this.cboCliente.StyleController = this.dataLayoutControl1;
            this.cboCliente.TabIndex = 6;
            this.cboCliente.Tag = "Cliente";
            // 
            // stpSelClienteSeguroBindingSource
            // 
            this.stpSelClienteSeguroBindingSource.DataMember = "stpSelClienteSeguro";
            this.stpSelClienteSeguroBindingSource.DataSource = this.dbSAIC_Catalogos;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdClienteComercial1,
            this.colDescNombreComercial});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIdClienteComercial1
            // 
            this.colIdClienteComercial1.FieldName = "IdCliente";
            this.colIdClienteComercial1.Name = "colIdClienteComercial1";
            // 
            // colDescNombreComercial
            // 
            this.colDescNombreComercial.Caption = "Nombre Comercial";
            this.colDescNombreComercial.FieldName = "NombreComercial";
            this.colDescNombreComercial.Name = "colDescNombreComercial";
            this.colDescNombreComercial.Visible = true;
            this.colDescNombreComercial.VisibleIndex = 0;
            // 
            // txtNoPoliza
            // 
            this.txtNoPoliza.Location = new System.Drawing.Point(282, 66);
            this.txtNoPoliza.MenuManager = this.barManager1;
            this.txtNoPoliza.Name = "txtNoPoliza";
            this.txtNoPoliza.Size = new System.Drawing.Size(529, 20);
            this.txtNoPoliza.StyleController = this.dataLayoutControl1;
            this.txtNoPoliza.TabIndex = 51;
            this.txtNoPoliza.Tag = "No. Poliza";
            // 
            // dtFechaFinVig
            // 
            this.dtFechaFinVig.EditValue = null;
            this.dtFechaFinVig.Location = new System.Drawing.Point(680, 235);
            this.dtFechaFinVig.MenuManager = this.barManager1;
            this.dtFechaFinVig.Name = "dtFechaFinVig";
            this.dtFechaFinVig.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaFinVig.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaFinVig.Properties.Mask.EditMask = "";
            this.dtFechaFinVig.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.dtFechaFinVig.Size = new System.Drawing.Size(131, 20);
            this.dtFechaFinVig.StyleController = this.dataLayoutControl1;
            this.dtFechaFinVig.TabIndex = 50;
            this.dtFechaFinVig.Tag = "Fecha Fin Vigencia";
            // 
            // dtFechaEmision
            // 
            this.dtFechaEmision.EditValue = null;
            this.dtFechaEmision.Location = new System.Drawing.Point(130, 235);
            this.dtFechaEmision.MenuManager = this.barManager1;
            this.dtFechaEmision.Name = "dtFechaEmision";
            this.dtFechaEmision.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaEmision.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaEmision.Size = new System.Drawing.Size(176, 20);
            this.dtFechaEmision.StyleController = this.dataLayoutControl1;
            this.dtFechaEmision.TabIndex = 52;
            this.dtFechaEmision.Tag = "Fecha Emisión";
            // 
            // cboTenedora
            // 
            this.cboTenedora.Location = new System.Drawing.Point(130, 187);
            this.cboTenedora.MenuManager = this.barManager1;
            this.cboTenedora.Name = "cboTenedora";
            this.cboTenedora.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTenedora.Properties.DataSource = this.vwCatTenedoraMatrizBindingSource;
            this.cboTenedora.Properties.DisplayMember = "RazonSocial";
            this.cboTenedora.Properties.NullText = "";
            this.cboTenedora.Properties.PopupSizeable = false;
            this.cboTenedora.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboTenedora.Properties.ValueMember = "IdTenedora";
            this.cboTenedora.Properties.View = this.gridView2;
            this.cboTenedora.Size = new System.Drawing.Size(681, 20);
            this.cboTenedora.StyleController = this.dataLayoutControl1;
            this.cboTenedora.TabIndex = 53;
            this.cboTenedora.Tag = "Empresa Contratante";
            // 
            // vwCatTenedoraMatrizBindingSource
            // 
            this.vwCatTenedoraMatrizBindingSource.DataMember = "vwCatTenedoraMatriz";
            this.vwCatTenedoraMatrizBindingSource.DataSource = this.dbSAICBPODataSet;
            // 
            // dbSAICBPODataSet
            // 
            this.dbSAICBPODataSet.DataSetName = "dbSAICBPODataSet";
            this.dbSAICBPODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdTenedora,
            this.colTenedora});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colIdTenedora
            // 
            this.colIdTenedora.Caption = "Id Tenedora";
            this.colIdTenedora.FieldName = "IdTenedora";
            this.colIdTenedora.Name = "colIdTenedora";
            // 
            // colTenedora
            // 
            this.colTenedora.Caption = "Tenedora";
            this.colTenedora.FieldName = "RazonSocial";
            this.colTenedora.Name = "colTenedora";
            this.colTenedora.Visible = true;
            this.colTenedora.VisibleIndex = 0;
            // 
            // cboMetodoPago
            // 
            this.cboMetodoPago.Location = new System.Drawing.Point(130, 211);
            this.cboMetodoPago.MenuManager = this.barManager1;
            this.cboMetodoPago.Name = "cboMetodoPago";
            this.cboMetodoPago.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboMetodoPago.Properties.DataSource = this.vwCatMetodoPagoBindingSource;
            this.cboMetodoPago.Properties.DisplayMember = "DescTipoMetodoPago";
            this.cboMetodoPago.Properties.NullText = "";
            this.cboMetodoPago.Properties.PopupSizeable = false;
            this.cboMetodoPago.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboMetodoPago.Properties.ValueMember = "IdTipoMetodoPago";
            this.cboMetodoPago.Properties.View = this.gridView3;
            this.cboMetodoPago.Size = new System.Drawing.Size(176, 20);
            this.cboMetodoPago.StyleController = this.dataLayoutControl1;
            this.cboMetodoPago.TabIndex = 54;
            this.cboMetodoPago.Tag = "Metódo de Pago";
            // 
            // vwCatMetodoPagoBindingSource
            // 
            this.vwCatMetodoPagoBindingSource.DataMember = "vwCatMetodoPago";
            this.vwCatMetodoPagoBindingSource.DataSource = this.dbSAICBPOCatalogosDataSet;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdTipoMetodoPago,
            this.colDescTipoMetodoPago});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colIdTipoMetodoPago
            // 
            this.colIdTipoMetodoPago.Caption = "IdTipoMetodoPago";
            this.colIdTipoMetodoPago.FieldName = "IdTipoMetodoPago";
            this.colIdTipoMetodoPago.Name = "colIdTipoMetodoPago";
            // 
            // colDescTipoMetodoPago
            // 
            this.colDescTipoMetodoPago.Caption = "Tipo Metodo Pago";
            this.colDescTipoMetodoPago.FieldName = "DescTipoMetodoPago";
            this.colDescTipoMetodoPago.Name = "colDescTipoMetodoPago";
            this.colDescTipoMetodoPago.Visible = true;
            this.colDescTipoMetodoPago.VisibleIndex = 0;
            // 
            // cboIdEstatus
            // 
            this.cboIdEstatus.Location = new System.Drawing.Point(416, 211);
            this.cboIdEstatus.MenuManager = this.barManager1;
            this.cboIdEstatus.Name = "cboIdEstatus";
            this.cboIdEstatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboIdEstatus.Properties.DataSource = this.vwCatEstatusSeguroBindingSource;
            this.cboIdEstatus.Properties.DisplayMember = "DescEstatus";
            this.cboIdEstatus.Properties.NullText = "";
            this.cboIdEstatus.Properties.ValueMember = "IdEstatus";
            this.cboIdEstatus.Properties.View = this.gridView4;
            this.cboIdEstatus.Size = new System.Drawing.Size(154, 20);
            this.cboIdEstatus.StyleController = this.dataLayoutControl1;
            this.cboIdEstatus.TabIndex = 43;
            this.cboIdEstatus.Tag = "Estatus";
            this.cboIdEstatus.EditValueChanged += new System.EventHandler(this.cboIdEstatus_EditValueChanged);
            // 
            // vwCatEstatusSeguroBindingSource
            // 
            this.vwCatEstatusSeguroBindingSource.DataMember = "vwCatEstatusSeguro";
            this.vwCatEstatusSeguroBindingSource.DataSource = this.dbSAICBPOCatalogosDataSet;
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEstatus,
            this.colDescEstatus});
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // colIdEstatus
            // 
            this.colIdEstatus.Caption = "IdEstatus";
            this.colIdEstatus.FieldName = "IdEstatus";
            this.colIdEstatus.Name = "colIdEstatus";
            // 
            // colDescEstatus
            // 
            this.colDescEstatus.Caption = "Estatus";
            this.colDescEstatus.FieldName = "DescEstatus";
            this.colDescEstatus.Name = "colDescEstatus";
            this.colDescEstatus.Visible = true;
            this.colDescEstatus.VisibleIndex = 0;
            // 
            // cbTipoSeguro
            // 
            this.cbTipoSeguro.Location = new System.Drawing.Point(130, 91);
            this.cbTipoSeguro.MenuManager = this.barManager1;
            this.cbTipoSeguro.Name = "cbTipoSeguro";
            this.cbTipoSeguro.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTipoSeguro.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cbTipoSeguro.Properties.DataSource = this.vwCatTipoSeguroBindingSource;
            this.cbTipoSeguro.Properties.DisplayMember = "DescTipoSeguro";
            this.cbTipoSeguro.Properties.MaxLength = 255;
            this.cbTipoSeguro.Properties.NullText = "";
            this.cbTipoSeguro.Properties.PopupSizeable = false;
            this.cbTipoSeguro.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbTipoSeguro.Properties.ValueMember = "IdTipoSeguro";
            this.cbTipoSeguro.Properties.View = this.gridView5;
            this.cbTipoSeguro.Size = new System.Drawing.Size(681, 20);
            this.cbTipoSeguro.StyleController = this.dataLayoutControl1;
            this.cbTipoSeguro.TabIndex = 4;
            this.cbTipoSeguro.Tag = "Tipo Seguro";
            this.cbTipoSeguro.EditValueChanged += new System.EventHandler(this.cbTipoSeguro_EditValueChanged);
            // 
            // vwCatTipoSeguroBindingSource
            // 
            this.vwCatTipoSeguroBindingSource.DataMember = "vwCatTipoSeguro";
            this.vwCatTipoSeguroBindingSource.DataSource = this.dbSAICBPOCatalogosDataSet;
            // 
            // gridView5
            // 
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDescTipoSeguro,
            this.IdTipoSeguro});
            this.gridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            // 
            // colDescTipoSeguro
            // 
            this.colDescTipoSeguro.Caption = "Tipo Seguro";
            this.colDescTipoSeguro.FieldName = "DescTipoSeguro";
            this.colDescTipoSeguro.Name = "colDescTipoSeguro";
            this.colDescTipoSeguro.Visible = true;
            this.colDescTipoSeguro.VisibleIndex = 0;
            // 
            // IdTipoSeguro
            // 
            this.IdTipoSeguro.Caption = "IdTipoSeguro";
            this.IdTipoSeguro.FieldName = "IdTipoSeguro";
            this.IdTipoSeguro.Name = "IdTipoSeguro";
            // 
            // cbCIA
            // 
            this.cbCIA.Location = new System.Drawing.Point(130, 115);
            this.cbCIA.MenuManager = this.barManager1;
            this.cbCIA.Name = "cbCIA";
            this.cbCIA.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbCIA.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cbCIA.Properties.DataSource = this.vwCatCIABindingSource;
            this.cbCIA.Properties.DisplayMember = "DescCIAAseguradora";
            this.cbCIA.Properties.MaxLength = 255;
            this.cbCIA.Properties.NullText = "";
            this.cbCIA.Properties.PopupSizeable = false;
            this.cbCIA.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbCIA.Properties.ValueMember = "IdCIAAseguradora";
            this.cbCIA.Properties.View = this.gridView6;
            this.cbCIA.Size = new System.Drawing.Size(681, 20);
            this.cbCIA.StyleController = this.dataLayoutControl1;
            this.cbCIA.TabIndex = 3;
            this.cbCIA.Tag = "CIA";
            // 
            // vwCatCIABindingSource
            // 
            this.vwCatCIABindingSource.DataMember = "vwCatCIA";
            this.vwCatCIABindingSource.DataSource = this.dbSAIC_Catalogos;
            // 
            // gridView6
            // 
            this.gridView6.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCIAAseguradora,
            this.col});
            this.gridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView6.Name = "gridView6";
            this.gridView6.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView6.OptionsView.ShowGroupPanel = false;
            // 
            // colIdCIAAseguradora
            // 
            this.colIdCIAAseguradora.Caption = "IdCIAAseguradora";
            this.colIdCIAAseguradora.FieldName = "IdCIAAseguradora";
            this.colIdCIAAseguradora.Name = "colIdCIAAseguradora";
            // 
            // col
            // 
            this.col.Caption = "CIA";
            this.col.FieldName = "DescCIAAseguradora";
            this.col.Name = "col";
            this.col.Visible = true;
            this.col.VisibleIndex = 0;
            // 
            // cboPagadorPoliza
            // 
            this.cboPagadorPoliza.Location = new System.Drawing.Point(680, 211);
            this.cboPagadorPoliza.MenuManager = this.barManager1;
            this.cboPagadorPoliza.Name = "cboPagadorPoliza";
            this.cboPagadorPoliza.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboPagadorPoliza.Properties.DataSource = this.vwCatTipoPagadorPolizaBindingSource;
            this.cboPagadorPoliza.Properties.DisplayMember = "DescTipoPagadorPoliza";
            this.cboPagadorPoliza.Properties.NullText = "";
            this.cboPagadorPoliza.Properties.PopupSizeable = false;
            this.cboPagadorPoliza.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboPagadorPoliza.Properties.ValueMember = "IdTipoPagadorPoliza";
            this.cboPagadorPoliza.Properties.View = this.gridView7;
            this.cboPagadorPoliza.Size = new System.Drawing.Size(131, 20);
            this.cboPagadorPoliza.StyleController = this.dataLayoutControl1;
            this.cboPagadorPoliza.TabIndex = 55;
            // 
            // vwCatTipoPagadorPolizaBindingSource
            // 
            this.vwCatTipoPagadorPolizaBindingSource.DataMember = "vwCatTipoPagadorPoliza";
            this.vwCatTipoPagadorPolizaBindingSource.DataSource = this.dbSAICBPOCatalogosDataSet;
            // 
            // gridView7
            // 
            this.gridView7.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdTipoPagadorPoliza,
            this.colDescTipoPagadorPoliza});
            this.gridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView7.Name = "gridView7";
            this.gridView7.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView7.OptionsView.ShowGroupPanel = false;
            // 
            // colIdTipoPagadorPoliza
            // 
            this.colIdTipoPagadorPoliza.Caption = "IdTipoPagadorPoliza";
            this.colIdTipoPagadorPoliza.FieldName = "IdTipoPagadorPoliza";
            this.colIdTipoPagadorPoliza.Name = "colIdTipoPagadorPoliza";
            // 
            // colDescTipoPagadorPoliza
            // 
            this.colDescTipoPagadorPoliza.Caption = "Pagador Poliza";
            this.colDescTipoPagadorPoliza.FieldName = "DescTipoPagadorPoliza";
            this.colDescTipoPagadorPoliza.Name = "colDescTipoPagadorPoliza";
            this.colDescTipoPagadorPoliza.Visible = true;
            this.colDescTipoPagadorPoliza.VisibleIndex = 0;
            // 
            // ItemForUsuarioCreacion
            // 
            this.ItemForUsuarioCreacion.Control = this.UsuarioCreacionTextEdit;
            this.ItemForUsuarioCreacion.CustomizationFormText = "Usuario Creacion";
            this.ItemForUsuarioCreacion.Location = new System.Drawing.Point(0, 684);
            this.ItemForUsuarioCreacion.Name = "ItemForUsuarioCreacion";
            this.ItemForUsuarioCreacion.Size = new System.Drawing.Size(761, 24);
            this.ItemForUsuarioCreacion.Text = "Usuario Creacion";
            this.ItemForUsuarioCreacion.TextSize = new System.Drawing.Size(190, 13);
            // 
            // ItemForUsuarioModificacion
            // 
            this.ItemForUsuarioModificacion.Control = this.UsuarioModificacionTextEdit;
            this.ItemForUsuarioModificacion.CustomizationFormText = "Usuario Modificacion";
            this.ItemForUsuarioModificacion.Location = new System.Drawing.Point(0, 684);
            this.ItemForUsuarioModificacion.Name = "ItemForUsuarioModificacion";
            this.ItemForUsuarioModificacion.Size = new System.Drawing.Size(761, 24);
            this.ItemForUsuarioModificacion.Text = "Usuario Modificacion";
            this.ItemForUsuarioModificacion.TextSize = new System.Drawing.Size(190, 13);
            // 
            // Root
            // 
            this.Root.CustomizationFormText = "Root";
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Location = new System.Drawing.Point(0, 0);
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(996, 282);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.CustomizationFormText = "autoGeneratedGroup0";
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup6,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem9,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.emptySpaceItem1,
            this.emptySpaceItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(976, 262);
            // 
            // layoutControlGroup6
            // 
            this.layoutControlGroup6.CustomizationFormText = "Información General";
            this.layoutControlGroup6.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemCIA,
            this.ItemForIdActividadComercial,
            this.ItemForConcepto,
            this.ItemForIdCliente,
            this.layoutControlItem3,
            this.ItemForFechaBaja,
            this.layoutControlItem12,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem8,
            this.ItemForIdEstatus,
            this.ItemForTipoSeguro,
            this.cbPagadorPoliza});
            this.layoutControlGroup6.Location = new System.Drawing.Point(0, 24);
            this.layoutControlGroup6.Name = "layoutControlGroup6";
            this.layoutControlGroup6.Size = new System.Drawing.Size(815, 238);
            this.layoutControlGroup6.Text = "Información General";
            // 
            // ItemCIA
            // 
            this.ItemCIA.Control = this.cbCIA;
            this.ItemCIA.CustomizationFormText = "Razon Social";
            this.ItemCIA.Location = new System.Drawing.Point(0, 49);
            this.ItemCIA.Name = "ItemCIA";
            this.ItemCIA.Size = new System.Drawing.Size(791, 24);
            this.ItemCIA.Text = "CIA";
            this.ItemCIA.TextSize = new System.Drawing.Size(103, 13);
            // 
            // ItemForIdActividadComercial
            // 
            this.ItemForIdActividadComercial.Control = this.cboCliente;
            this.ItemForIdActividadComercial.CustomizationFormText = "Id Actividad Comercial";
            this.ItemForIdActividadComercial.Location = new System.Drawing.Point(0, 97);
            this.ItemForIdActividadComercial.Name = "ItemForIdActividadComercial";
            this.ItemForIdActividadComercial.Size = new System.Drawing.Size(791, 24);
            this.ItemForIdActividadComercial.Text = "Cliente";
            this.ItemForIdActividadComercial.TextSize = new System.Drawing.Size(103, 13);
            // 
            // ItemForConcepto
            // 
            this.ItemForConcepto.Control = this.txtConcepto;
            this.ItemForConcepto.CustomizationFormText = "RFC";
            this.ItemForConcepto.Location = new System.Drawing.Point(0, 73);
            this.ItemForConcepto.Name = "ItemForConcepto";
            this.ItemForConcepto.Size = new System.Drawing.Size(791, 24);
            this.ItemForConcepto.Text = "Concepto";
            this.ItemForConcepto.TextSize = new System.Drawing.Size(103, 13);
            // 
            // ItemForIdCliente
            // 
            this.ItemForIdCliente.Control = this.txtIdPoliza;
            this.ItemForIdCliente.CustomizationFormText = "Id Poliza";
            this.ItemForIdCliente.Location = new System.Drawing.Point(0, 0);
            this.ItemForIdCliente.MaxSize = new System.Drawing.Size(0, 25);
            this.ItemForIdCliente.MinSize = new System.Drawing.Size(50, 25);
            this.ItemForIdCliente.Name = "ItemForIdCliente";
            this.ItemForIdCliente.Size = new System.Drawing.Size(152, 25);
            this.ItemForIdCliente.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.ItemForIdCliente.Text = "Id Poliza";
            this.ItemForIdCliente.TextSize = new System.Drawing.Size(103, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtNoPoliza;
            this.layoutControlItem3.Location = new System.Drawing.Point(152, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(639, 25);
            this.layoutControlItem3.Text = "No. Poliza";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(103, 13);
            // 
            // ItemForFechaBaja
            // 
            this.ItemForFechaBaja.Control = this.dtFechaInicioVig;
            this.ItemForFechaBaja.CustomizationFormText = "Fecha Baja";
            this.ItemForFechaBaja.Location = new System.Drawing.Point(286, 169);
            this.ItemForFechaBaja.MaxSize = new System.Drawing.Size(0, 24);
            this.ItemForFechaBaja.MinSize = new System.Drawing.Size(156, 24);
            this.ItemForFechaBaja.Name = "ItemForFechaBaja";
            this.ItemForFechaBaja.Size = new System.Drawing.Size(264, 27);
            this.ItemForFechaBaja.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.ItemForFechaBaja.Text = "Fecha Inicio Vigencia";
            this.ItemForFechaBaja.TextSize = new System.Drawing.Size(103, 13);
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.dtFechaFinVig;
            this.layoutControlItem12.CustomizationFormText = "Fecha Inicio Vigencia";
            this.layoutControlItem12.Location = new System.Drawing.Point(550, 169);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(241, 27);
            this.layoutControlItem12.Text = "Fecha Fin Vigencia";
            this.layoutControlItem12.TextSize = new System.Drawing.Size(103, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dtFechaEmision;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 169);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(286, 27);
            this.layoutControlItem1.Text = "Fecha Emisión";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(103, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cboTenedora;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 121);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(791, 24);
            this.layoutControlItem2.Text = "Empresa Contratante";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(103, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.cboMetodoPago;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 145);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(286, 24);
            this.layoutControlItem8.Text = "Metódo de Pago";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(103, 13);
            // 
            // ItemForIdEstatus
            // 
            this.ItemForIdEstatus.Control = this.cboIdEstatus;
            this.ItemForIdEstatus.CustomizationFormText = "Id Estatus";
            this.ItemForIdEstatus.Location = new System.Drawing.Point(286, 145);
            this.ItemForIdEstatus.Name = "ItemForIdEstatus";
            this.ItemForIdEstatus.Size = new System.Drawing.Size(264, 24);
            this.ItemForIdEstatus.Text = "Estatus";
            this.ItemForIdEstatus.TextSize = new System.Drawing.Size(103, 13);
            // 
            // ItemForTipoSeguro
            // 
            this.ItemForTipoSeguro.Control = this.cbTipoSeguro;
            this.ItemForTipoSeguro.CustomizationFormText = "Nombre Comercial";
            this.ItemForTipoSeguro.Location = new System.Drawing.Point(0, 25);
            this.ItemForTipoSeguro.Name = "ItemForTipoSeguro";
            this.ItemForTipoSeguro.Size = new System.Drawing.Size(791, 24);
            this.ItemForTipoSeguro.Text = "Tipo Seguro";
            this.ItemForTipoSeguro.TextSize = new System.Drawing.Size(103, 13);
            // 
            // cbPagadorPoliza
            // 
            this.cbPagadorPoliza.Control = this.cboPagadorPoliza;
            this.cbPagadorPoliza.Location = new System.Drawing.Point(550, 145);
            this.cbPagadorPoliza.Name = "cbPagadorPoliza";
            this.cbPagadorPoliza.Size = new System.Drawing.Size(241, 24);
            this.cbPagadorPoliza.Text = "Pagador";
            this.cbPagadorPoliza.TextSize = new System.Drawing.Size(103, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.cboIdPoliza;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(815, 24);
            this.layoutControlItem4.Text = "Buscar Poliza";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(103, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnNuevo;
            this.layoutControlItem5.Location = new System.Drawing.Point(815, 69);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(161, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.btnEditar;
            this.layoutControlItem9.Location = new System.Drawing.Point(815, 95);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(161, 26);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnCancelar;
            this.layoutControlItem6.Location = new System.Drawing.Point(815, 147);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(161, 26);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btnGuardar;
            this.layoutControlItem7.Location = new System.Drawing.Point(815, 121);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(161, 26);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(815, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(161, 69);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(815, 173);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(161, 89);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // vwCatTenedoraSABindingSource
            // 
            this.vwCatTenedoraSABindingSource.DataMember = "vwCatTenedoraSA";
            this.vwCatTenedoraSABindingSource.DataSource = this.dbSAICBPODataSet;
            // 
            // stpSelCIAAseguradorasBindingSource
            // 
            this.stpSelCIAAseguradorasBindingSource.DataMember = "stpSelCIAAseguradoras";
            this.stpSelCIAAseguradorasBindingSource.DataSource = this.dbSAICBPOCatalogosDataSet;
            // 
            // stpSelObtenerTipoPolizaBindingSource
            // 
            this.stpSelObtenerTipoPolizaBindingSource.DataMember = "stpSelObtenerTipoPoliza";
            this.stpSelObtenerTipoPolizaBindingSource.DataSource = this.dbSAICBPOCatalogosDataSet;
            // 
            // stpSelClienteSeguroTableAdapter
            // 
            this.stpSelClienteSeguroTableAdapter.ClearBeforeFill = true;
            // 
            // vwCatTipoSeguroTableAdapter
            // 
            this.vwCatTipoSeguroTableAdapter.ClearBeforeFill = true;
            // 
            // vwCatMetodoPagoTableAdapter
            // 
            this.vwCatMetodoPagoTableAdapter.ClearBeforeFill = true;
            // 
            // stpSelCIAAseguradorasTableAdapter
            // 
            this.stpSelCIAAseguradorasTableAdapter.ClearBeforeFill = true;
            // 
            // catPolizaTableAdapter1
            // 
            this.catPolizaTableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelObtenerTipoPolizaTableAdapter
            // 
            this.stpSelObtenerTipoPolizaTableAdapter.ClearBeforeFill = true;
            // 
            // vwCatEstatusSeguroTableAdapter
            // 
            this.vwCatEstatusSeguroTableAdapter.ClearBeforeFill = true;
            // 
            // vwCatTenedoraSATableAdapter
            // 
            this.vwCatTenedoraSATableAdapter.ClearBeforeFill = true;
            // 
            // vwCatCIATableAdapter
            // 
            this.vwCatCIATableAdapter.ClearBeforeFill = true;
            // 
            // vwCatTipoPagadorPolizaTableAdapter
            // 
            this.vwCatTipoPagadorPolizaTableAdapter.ClearBeforeFill = true;
            // 
            // vwCatTenedoraMatrizTableAdapter
            // 
            this.vwCatTenedoraMatrizTableAdapter.ClearBeforeFill = true;
            // 
            // catPolizaBindingSource1
            // 
            this.catPolizaBindingSource1.DataMember = "CatPoliza";
            this.catPolizaBindingSource1.DataSource = this.dbSAIC_Catalogos;
            // 
            // frmxPolizas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 313);
            this.ControlBox = false;
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmxPolizas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Polizas";
            this.Load += new System.EventHandler(this.frmxPolizas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboIdPoliza.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catPolizaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAIC_Catalogos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConcepto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaInicioVig.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaInicioVig.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioCreacionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioModificacionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdPoliza.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelClienteSeguroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoPoliza.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaFinVig.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaFinVig.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaEmision.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaEmision.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTenedora.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCatTenedoraMatrizBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMetodoPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCatMetodoPagoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboIdEstatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCatEstatusSeguroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoSeguro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCatTipoSeguroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCIA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCatCIABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPagadorPoliza.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCatTipoPagadorPolizaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUsuarioCreacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUsuarioModificacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemCIA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdActividadComercial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForConcepto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFechaBaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdEstatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTipoSeguro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPagadorPoliza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCatTenedoraSABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelCIAAseguradorasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelObtenerTipoPolizaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catPolizaBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnSalir;
        private dbSAICBPOCatalogosDataSet dbSAICBPOCatalogosDataSet;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.TextEdit txtConcepto;
        private DevExpress.XtraEditors.DateEdit dtFechaInicioVig;
        private DevExpress.XtraEditors.TextEdit UsuarioCreacionTextEdit;
        private DevExpress.XtraEditors.TextEdit UsuarioModificacionTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemCIA;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTipoSeguro;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIdActividadComercial;
        private DevExpress.XtraLayout.LayoutControlItem ItemForConcepto;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIdEstatus;
        private DevExpress.XtraLayout.LayoutControlItem ItemForFechaBaja;
        private DevExpress.XtraLayout.LayoutControlItem ItemForUsuarioCreacion;
        private DevExpress.XtraLayout.LayoutControlItem ItemForUsuarioModificacion;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIdCliente;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup6;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashSMCargando;
        private DevExpress.XtraEditors.GridLookUpEdit cboIdPoliza;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPoliza;
        private DevExpress.XtraGrid.Columns.GridColumn colNoPoliza;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaIniVig;
        private DevExpress.XtraEditors.TextEdit txtIdPoliza;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnNuevo;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.SimpleButton btnEditar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraEditors.GridLookUpEdit cboCliente;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdClienteComercial1;
        private DevExpress.XtraGrid.Columns.GridColumn colDescNombreComercial;
        private DevExpress.XtraEditors.TextEdit txtNoPoliza;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.DateEdit dtFechaFinVig;
        private DevExpress.XtraEditors.DateEdit dtFechaEmision;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private Catalogos.dbSAIC_Catalogos dbSAIC_Catalogos;
        private System.Windows.Forms.BindingSource stpSelClienteSeguroBindingSource;
        private Catalogos.dbSAIC_CatalogosTableAdapters.stpSelClienteSeguroTableAdapter stpSelClienteSeguroTableAdapter;
        private System.Windows.Forms.BindingSource vwCatTipoSeguroBindingSource;
        private dbSAICBPOCatalogosDataSetTableAdapters.vwCatTipoSeguroTableAdapter vwCatTipoSeguroTableAdapter;
        private System.Windows.Forms.BindingSource vwCatMetodoPagoBindingSource;
        private dbSAICBPOCatalogosDataSetTableAdapters.vwCatMetodoPagoTableAdapter vwCatMetodoPagoTableAdapter;
        private System.Windows.Forms.BindingSource stpSelCIAAseguradorasBindingSource;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelCIAAseguradorasTableAdapter stpSelCIAAseguradorasTableAdapter;
        private Catalogos.dbSAIC_CatalogosTableAdapters.CatPolizaTableAdapter catPolizaTableAdapter1;
        private System.Windows.Forms.BindingSource stpSelObtenerTipoPolizaBindingSource;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelObtenerTipoPolizaTableAdapter stpSelObtenerTipoPolizaTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaFinVig;
        private System.Windows.Forms.BindingSource catPolizaBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn celConcepto;
        private DevExpress.XtraGrid.Columns.GridColumn celIdTipoSeguro;
        private DevExpress.XtraGrid.Columns.GridColumn celIdTipoMetodoPago;
        private DevExpress.XtraGrid.Columns.GridColumn celIdTenedora;
        private DevExpress.XtraGrid.Columns.GridColumn celIdEstatus;
        private DevExpress.XtraGrid.Columns.GridColumn celIdCliente;
        private DevExpress.XtraGrid.Columns.GridColumn celIdCIAAseguradora;
        private DevExpress.XtraGrid.Columns.GridColumn celFechaEMI;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioModificacion;
        private System.Windows.Forms.BindingSource vwCatEstatusSeguroBindingSource;
        private dbSAICBPOCatalogosDataSetTableAdapters.vwCatEstatusSeguroTableAdapter vwCatEstatusSeguroTableAdapter;
        private dbSAICBPODataSet dbSAICBPODataSet;
        private System.Windows.Forms.BindingSource vwCatTenedoraSABindingSource;
        private dbSAICBPODataSetTableAdapters.vwCatTenedoraSATableAdapter vwCatTenedoraSATableAdapter;
        private DevExpress.XtraEditors.GridLookUpEdit cboTenedora;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTenedora;
        private DevExpress.XtraGrid.Columns.GridColumn colTenedora;
        private DevExpress.XtraEditors.GridLookUpEdit cboMetodoPago;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoMetodoPago;
        private DevExpress.XtraGrid.Columns.GridColumn colDescTipoMetodoPago;
        private DevExpress.XtraEditors.GridLookUpEdit cboIdEstatus;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstatus;
        private DevExpress.XtraGrid.Columns.GridColumn colDescEstatus;
        private DevExpress.XtraEditors.GridLookUpEdit cbTipoSeguro;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.Columns.GridColumn colDescTipoSeguro;
        private DevExpress.XtraGrid.Columns.GridColumn IdTipoSeguro;
        private DevExpress.XtraEditors.GridLookUpEdit cbCIA;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCIAAseguradora;
        private DevExpress.XtraGrid.Columns.GridColumn col;
        private System.Windows.Forms.BindingSource vwCatCIABindingSource;
        private Catalogos.dbSAIC_CatalogosTableAdapters.vwCatCIATableAdapter vwCatCIATableAdapter;
        private DevExpress.XtraEditors.GridLookUpEdit cboPagadorPoliza;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView7;
        private DevExpress.XtraLayout.LayoutControlItem cbPagadorPoliza;
        private System.Windows.Forms.BindingSource vwCatTipoPagadorPolizaBindingSource;
        private dbSAICBPOCatalogosDataSetTableAdapters.vwCatTipoPagadorPolizaTableAdapter vwCatTipoPagadorPolizaTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoPagadorPoliza;
        private DevExpress.XtraGrid.Columns.GridColumn colDescTipoPagadorPoliza;
        private System.Windows.Forms.BindingSource vwCatTenedoraMatrizBindingSource;
        private dbSAICBPODataSetTableAdapters.vwCatTenedoraMatrizTableAdapter vwCatTenedoraMatrizTableAdapter;
        private System.Windows.Forms.BindingSource catPolizaBindingSource1;
    }
}