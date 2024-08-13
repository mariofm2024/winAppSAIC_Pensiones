namespace winAppSAIC.Seguros
{
    partial class frmxModificacionEmpleadosSeguros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmxModificacionEmpleadosSeguros));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::winAppSAIC.SplashDeCarga), true, true);
            this.lblBuscarEmpledo = new DevExpress.XtraEditors.LabelControl();
            this.dbSAICBPOCatalogosDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPOCatalogosDataSet = new winAppSAIC.dbSAICBPOCatalogosDataSet();
            this.dbSAICBPONominaCFDIDataSet = new winAppSAIC.NominaCFDI.dbSAICBPONominaCFDIDataSet();
            this.dbSAICBPOCatalogosDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwCatTenedoraSABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPODataSet = new winAppSAIC.dbSAICBPODataSet();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnSalir = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnAgregarPoliza = new DevExpress.XtraBars.BarButtonItem();
            this.cboIdTenedoraSA = new DevExpress.XtraEditors.LookUpEdit();
            this.cboIdEstatus = new DevExpress.XtraEditors.GridLookUpEdit();
            this.vwCatEstatusEmpleadoCFDIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescEstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblTenedora = new DevExpress.XtraEditors.LabelControl();
            this.lblEstatus = new DevExpress.XtraEditors.LabelControl();
            this.gpcInformacionContrato = new DevExpress.XtraEditors.GroupControl();
            this.cboIdCliente = new DevExpress.XtraEditors.LookUpEdit();
            this.vwCatClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lblFechaBaja = new DevExpress.XtraEditors.LabelControl();
            this.calFechaBajaContrato = new DevExpress.XtraEditors.DateEdit();
            this.txtPuestoContrato = new DevExpress.XtraEditors.TextEdit();
            this.lblFechaIngresoReingreso = new DevExpress.XtraEditors.LabelControl();
            this.lblDepar = new DevExpress.XtraEditors.LabelControl();
            this.calFechaIngresoReingresoContrato = new DevExpress.XtraEditors.DateEdit();
            this.lblPuesto = new DevExpress.XtraEditors.LabelControl();
            this.txtDepartamentoContrato = new DevExpress.XtraEditors.TextEdit();
            this.txtCURP = new DevExpress.XtraEditors.TextEdit();
            this.txtRFC = new DevExpress.XtraEditors.TextEdit();
            this.txtNSS = new DevExpress.XtraEditors.TextEdit();
            this.txtAMaternoEmpleado = new DevExpress.XtraEditors.TextEdit();
            this.txtAPaternoEmpleado = new DevExpress.XtraEditors.TextEdit();
            this.txtNombreEmpleado = new DevExpress.XtraEditors.TextEdit();
            this.txtNoEmpleado = new DevExpress.XtraEditors.TextEdit();
            this.lblNoEmpleado = new DevExpress.XtraEditors.LabelControl();
            this.lblCurp = new DevExpress.XtraEditors.LabelControl();
            this.lblRFC = new DevExpress.XtraEditors.LabelControl();
            this.lblNSS = new DevExpress.XtraEditors.LabelControl();
            this.lblAMat = new DevExpress.XtraEditors.LabelControl();
            this.lblAPat = new DevExpress.XtraEditors.LabelControl();
            this.lblNombre = new DevExpress.XtraEditors.LabelControl();
            this.vwCatEstatusEmpleadoCFDITableAdapter = new winAppSAIC.NominaCFDI.dbSAICBPONominaCFDIDataSetTableAdapters.vwCatEstatusEmpleadoCFDITableAdapter();
            this.cboIdEmpleado = new DevExpress.XtraEditors.GridLookUpEdit();
            this.stpSelEmpleadosDisponiblesSEGUROSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreEmpleadoCompleto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNSS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRFC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCURP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.stpSelEmpleadosDisponiblesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stpSelEmpleadosDisponiblesTableAdapter = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelEmpleadosDisponiblesTableAdapter();
            this.vwCatTenedoraSATableAdapter = new winAppSAIC.dbSAICBPODataSetTableAdapters.vwCatTenedoraSATableAdapter();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtpEmpleadoTenedora = new DevExpress.XtraTab.XtraTabPage();
            this.ControlPolizas = new DevExpress.XtraEditors.GroupControl();
            this.GridEmpleados = new DevExpress.XtraGrid.GridControl();
            this.stpSelObtenerInfoEmpleadoSegurosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewPolizasEmpleados = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colControlPoliza1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCIA1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoSeguro1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoPoliza1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstatus1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaINI1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContratante1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClienteContratante1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnEliminar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEliminar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumnCancelar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonCancelar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.ColFechaFin1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColFolio1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txtFolio = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtEmpleadoPoliza = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cboIdTipoPoliza = new DevExpress.XtraEditors.LookUpEdit();
            this.stpSelObtenerTipoPolizaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.cboIdTipoSeguro = new DevExpress.XtraEditors.LookUpEdit();
            this.stpSelTipoSeguroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.stpSelObtenerInfoEmpleadoSegurosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwCatTipoSeguroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelarPoliza = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.stpSelEmpleadosDisponiblesSEGUROSTableAdapter = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelEmpleadosDisponiblesSEGUROSTableAdapter();
            this.stpSelObtenerInfoEmpleadoSegurosTableAdapter = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelObtenerInfoEmpleadoSegurosTableAdapter();
            this.vwCatClienteTableAdapter = new winAppSAIC.dbSAICBPODataSetTableAdapters.vwCatClienteTableAdapter();
            this.stpSelObtenerInfoEmpleadoSegurosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.stpSelObtenerInfoEmpleadoSegurosCrearTableAdapter1 = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelObtenerInfoEmpleadoSegurosCrearTableAdapter();
            this.stpSelObtenerTipoPolizaTableAdapter = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelObtenerTipoPolizaTableAdapter();
            this.vwCatTipoSeguroTableAdapter = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.vwCatTipoSeguroTableAdapter();
            this.stpSelObtenerTipoPolizaTableAdapter1 = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelObtenerTipoPolizaTableAdapter();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditar = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btnAgregar_Poliza = new DevExpress.XtraEditors.SimpleButton();
            this.queriesTableAdapter1 = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.QueriesTableAdapter();
            this.stpSelTipoSeguroTableAdapter1 = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelTipoSeguroTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPONominaCFDIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCatTenedoraSABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboIdTenedoraSA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboIdEstatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCatEstatusEmpleadoCFDIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpcInformacionContrato)).BeginInit();
            this.gpcInformacionContrato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboIdCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCatClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calFechaBajaContrato.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calFechaBajaContrato.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPuestoContrato.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calFechaIngresoReingresoContrato.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calFechaIngresoReingresoContrato.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartamentoContrato.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCURP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRFC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNSS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAMaternoEmpleado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAPaternoEmpleado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreEmpleado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoEmpleado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboIdEmpleado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelEmpleadosDisponiblesSEGUROSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelEmpleadosDisponiblesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtpEmpleadoTenedora.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ControlPolizas)).BeginInit();
            this.ControlPolizas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelObtenerInfoEmpleadoSegurosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPolizasEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFolio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmpleadoPoliza.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboIdTipoPoliza.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelObtenerTipoPolizaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboIdTipoSeguro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelTipoSeguroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelObtenerInfoEmpleadoSegurosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCatTipoSeguroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelObtenerInfoEmpleadoSegurosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // lblBuscarEmpledo
            // 
            this.lblBuscarEmpledo.Location = new System.Drawing.Point(12, 44);
            this.lblBuscarEmpledo.Name = "lblBuscarEmpledo";
            this.lblBuscarEmpledo.Size = new System.Drawing.Size(81, 13);
            this.lblBuscarEmpledo.TabIndex = 1;
            this.lblBuscarEmpledo.Text = "Buscar Empleado";
            // 
            // dbSAICBPOCatalogosDataSetBindingSource1
            // 
            this.dbSAICBPOCatalogosDataSetBindingSource1.DataSource = this.dbSAICBPOCatalogosDataSet;
            this.dbSAICBPOCatalogosDataSetBindingSource1.Position = 0;
            // 
            // dbSAICBPOCatalogosDataSet
            // 
            this.dbSAICBPOCatalogosDataSet.DataSetName = "dbSAICBPOCatalogosDataSet";
            this.dbSAICBPOCatalogosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbSAICBPONominaCFDIDataSet
            // 
            this.dbSAICBPONominaCFDIDataSet.DataSetName = "dbSAICBPONominaCFDIDataSet";
            this.dbSAICBPONominaCFDIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbSAICBPOCatalogosDataSetBindingSource
            // 
            this.dbSAICBPOCatalogosDataSetBindingSource.DataSource = this.dbSAICBPOCatalogosDataSet;
            this.dbSAICBPOCatalogosDataSetBindingSource.Position = 0;
            // 
            // vwCatTenedoraSABindingSource
            // 
            this.vwCatTenedoraSABindingSource.DataMember = "vwCatTenedoraSA";
            this.vwCatTenedoraSABindingSource.DataSource = this.dbSAICBPODataSet;
            // 
            // dbSAICBPODataSet
            // 
            this.dbSAICBPODataSet.DataSetName = "dbSAICBPODataSet";
            this.dbSAICBPODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.btnAgregarPoliza});
            this.barManager1.MaxItemId = 2;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSalir)});
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
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(939, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 635);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(939, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 604);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(939, 31);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 604);
            // 
            // btnAgregarPoliza
            // 
            this.btnAgregarPoliza.Caption = "Agregar Poliza";
            this.btnAgregarPoliza.Id = 1;
            this.btnAgregarPoliza.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarPoliza.ImageOptions.Image")));
            this.btnAgregarPoliza.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarPoliza.ImageOptions.LargeImage")));
            this.btnAgregarPoliza.Name = "btnAgregarPoliza";
            // 
            // cboIdTenedoraSA
            // 
            this.cboIdTenedoraSA.Enabled = false;
            this.cboIdTenedoraSA.Location = new System.Drawing.Point(93, 23);
            this.cboIdTenedoraSA.Name = "cboIdTenedoraSA";
            this.cboIdTenedoraSA.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.cboIdTenedoraSA.Properties.Appearance.Options.UseBackColor = true;
            this.cboIdTenedoraSA.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboIdTenedoraSA.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdTenedora", "Id Tenedora", 50, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Center, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RazonSocial", "Razon Social", 70, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NombreComercial", "Tenedora SA", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cboIdTenedoraSA.Properties.DataSource = this.vwCatTenedoraSABindingSource;
            this.cboIdTenedoraSA.Properties.DisplayMember = "NombreComercial";
            this.cboIdTenedoraSA.Properties.NullText = "";
            this.cboIdTenedoraSA.Properties.ValueMember = "IdTenedora";
            this.cboIdTenedoraSA.Size = new System.Drawing.Size(350, 20);
            this.cboIdTenedoraSA.TabIndex = 50;
            this.cboIdTenedoraSA.Tag = "Tenedora S.A.";
            // 
            // cboIdEstatus
            // 
            this.cboIdEstatus.EditValue = "";
            this.cboIdEstatus.Enabled = false;
            this.cboIdEstatus.Location = new System.Drawing.Point(569, 23);
            this.cboIdEstatus.Name = "cboIdEstatus";
            this.cboIdEstatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboIdEstatus.Properties.DataSource = this.vwCatEstatusEmpleadoCFDIBindingSource;
            this.cboIdEstatus.Properties.DisplayMember = "DescEstatus";
            this.cboIdEstatus.Properties.ValueMember = "IdEstatus";
            this.cboIdEstatus.Properties.View = this.gridLookUpEdit1View;
            this.cboIdEstatus.Size = new System.Drawing.Size(100, 20);
            this.cboIdEstatus.TabIndex = 53;
            // 
            // vwCatEstatusEmpleadoCFDIBindingSource
            // 
            this.vwCatEstatusEmpleadoCFDIBindingSource.DataMember = "vwCatEstatusEmpleadoCFDI";
            this.vwCatEstatusEmpleadoCFDIBindingSource.DataSource = this.dbSAICBPONominaCFDIDataSet;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEstatus,
            this.colDescEstatus});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
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
            this.colDescEstatus.VisibleIndex = 0;
            // 
            // lblTenedora
            // 
            this.lblTenedora.Location = new System.Drawing.Point(18, 27);
            this.lblTenedora.Name = "lblTenedora";
            this.lblTenedora.Size = new System.Drawing.Size(70, 13);
            this.lblTenedora.TabIndex = 4;
            this.lblTenedora.Text = "Tenedora S.A.";
            // 
            // lblEstatus
            // 
            this.lblEstatus.Location = new System.Drawing.Point(528, 26);
            this.lblEstatus.Name = "lblEstatus";
            this.lblEstatus.Size = new System.Drawing.Size(36, 13);
            this.lblEstatus.TabIndex = 10;
            this.lblEstatus.Text = "Estatus";
            // 
            // gpcInformacionContrato
            // 
            this.gpcInformacionContrato.Controls.Add(this.cboIdCliente);
            this.gpcInformacionContrato.Controls.Add(this.labelControl5);
            this.gpcInformacionContrato.Controls.Add(this.cboIdEstatus);
            this.gpcInformacionContrato.Controls.Add(this.lblFechaBaja);
            this.gpcInformacionContrato.Controls.Add(this.cboIdTenedoraSA);
            this.gpcInformacionContrato.Controls.Add(this.lblEstatus);
            this.gpcInformacionContrato.Controls.Add(this.calFechaBajaContrato);
            this.gpcInformacionContrato.Controls.Add(this.txtPuestoContrato);
            this.gpcInformacionContrato.Controls.Add(this.lblFechaIngresoReingreso);
            this.gpcInformacionContrato.Controls.Add(this.lblTenedora);
            this.gpcInformacionContrato.Controls.Add(this.lblDepar);
            this.gpcInformacionContrato.Controls.Add(this.calFechaIngresoReingresoContrato);
            this.gpcInformacionContrato.Controls.Add(this.lblPuesto);
            this.gpcInformacionContrato.Controls.Add(this.txtDepartamentoContrato);
            this.gpcInformacionContrato.Location = new System.Drawing.Point(5, 120);
            this.gpcInformacionContrato.Name = "gpcInformacionContrato";
            this.gpcInformacionContrato.Size = new System.Drawing.Size(710, 127);
            this.gpcInformacionContrato.TabIndex = 15;
            this.gpcInformacionContrato.Text = "Información Contrato Tenedora";
            // 
            // cboIdCliente
            // 
            this.cboIdCliente.Enabled = false;
            this.cboIdCliente.Location = new System.Drawing.Point(93, 49);
            this.cboIdCliente.Name = "cboIdCliente";
            this.cboIdCliente.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.cboIdCliente.Properties.Appearance.Options.UseBackColor = true;
            this.cboIdCliente.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboIdCliente.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdTenedora", "Id Tenedora", 50, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Center, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RazonSocial", "Razon Social", 70, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NombreComercial", "Tenedora SA", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cboIdCliente.Properties.DataSource = this.vwCatClienteBindingSource;
            this.cboIdCliente.Properties.DisplayMember = "NombreComercial";
            this.cboIdCliente.Properties.NullText = "";
            this.cboIdCliente.Properties.ValueMember = "IdCliente";
            this.cboIdCliente.Size = new System.Drawing.Size(350, 20);
            this.cboIdCliente.TabIndex = 57;
            this.cboIdCliente.Tag = "Tenedora S.A.";
            // 
            // vwCatClienteBindingSource
            // 
            this.vwCatClienteBindingSource.DataMember = "vwCatCliente";
            this.vwCatClienteBindingSource.DataSource = this.dbSAICBPODataSet;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(55, 52);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(33, 13);
            this.labelControl5.TabIndex = 56;
            this.labelControl5.Text = "Cliente";
            // 
            // lblFechaBaja
            // 
            this.lblFechaBaja.Location = new System.Drawing.Point(495, 78);
            this.lblFechaBaja.Name = "lblFechaBaja";
            this.lblFechaBaja.Size = new System.Drawing.Size(68, 13);
            this.lblFechaBaja.TabIndex = 8;
            this.lblFechaBaja.Text = "Fecha de Baja";
            // 
            // calFechaBajaContrato
            // 
            this.calFechaBajaContrato.EditValue = null;
            this.calFechaBajaContrato.Enabled = false;
            this.calFechaBajaContrato.Location = new System.Drawing.Point(569, 74);
            this.calFechaBajaContrato.Name = "calFechaBajaContrato";
            this.calFechaBajaContrato.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.calFechaBajaContrato.Properties.Appearance.Options.UseBackColor = true;
            this.calFechaBajaContrato.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calFechaBajaContrato.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calFechaBajaContrato.Size = new System.Drawing.Size(100, 20);
            this.calFechaBajaContrato.TabIndex = 55;
            this.calFechaBajaContrato.Tag = "Fecha de Ingreso";
            // 
            // txtPuestoContrato
            // 
            this.txtPuestoContrato.Enabled = false;
            this.txtPuestoContrato.Location = new System.Drawing.Point(93, 102);
            this.txtPuestoContrato.Name = "txtPuestoContrato";
            this.txtPuestoContrato.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtPuestoContrato.Properties.Appearance.Options.UseBackColor = true;
            this.txtPuestoContrato.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPuestoContrato.Properties.MaxLength = 100;
            this.txtPuestoContrato.Size = new System.Drawing.Size(229, 20);
            this.txtPuestoContrato.TabIndex = 52;
            // 
            // lblFechaIngresoReingreso
            // 
            this.lblFechaIngresoReingreso.Location = new System.Drawing.Point(479, 52);
            this.lblFechaIngresoReingreso.Name = "lblFechaIngresoReingreso";
            this.lblFechaIngresoReingreso.Size = new System.Drawing.Size(84, 13);
            this.lblFechaIngresoReingreso.TabIndex = 6;
            this.lblFechaIngresoReingreso.Text = "Fecha de Ingreso";
            // 
            // lblDepar
            // 
            this.lblDepar.Location = new System.Drawing.Point(18, 79);
            this.lblDepar.Name = "lblDepar";
            this.lblDepar.Size = new System.Drawing.Size(69, 13);
            this.lblDepar.TabIndex = 18;
            this.lblDepar.Text = "Departamento";
            // 
            // calFechaIngresoReingresoContrato
            // 
            this.calFechaIngresoReingresoContrato.EditValue = null;
            this.calFechaIngresoReingresoContrato.Enabled = false;
            this.calFechaIngresoReingresoContrato.Location = new System.Drawing.Point(569, 48);
            this.calFechaIngresoReingresoContrato.Name = "calFechaIngresoReingresoContrato";
            this.calFechaIngresoReingresoContrato.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.calFechaIngresoReingresoContrato.Properties.Appearance.Options.UseBackColor = true;
            this.calFechaIngresoReingresoContrato.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calFechaIngresoReingresoContrato.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calFechaIngresoReingresoContrato.Size = new System.Drawing.Size(100, 20);
            this.calFechaIngresoReingresoContrato.TabIndex = 54;
            this.calFechaIngresoReingresoContrato.Tag = "Fecha de Ingreso";
            // 
            // lblPuesto
            // 
            this.lblPuesto.Location = new System.Drawing.Point(54, 105);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(33, 13);
            this.lblPuesto.TabIndex = 20;
            this.lblPuesto.Text = "Puesto";
            // 
            // txtDepartamentoContrato
            // 
            this.txtDepartamentoContrato.Enabled = false;
            this.txtDepartamentoContrato.Location = new System.Drawing.Point(93, 76);
            this.txtDepartamentoContrato.Name = "txtDepartamentoContrato";
            this.txtDepartamentoContrato.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtDepartamentoContrato.Properties.Appearance.Options.UseBackColor = true;
            this.txtDepartamentoContrato.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDepartamentoContrato.Properties.MaxLength = 100;
            this.txtDepartamentoContrato.Size = new System.Drawing.Size(229, 20);
            this.txtDepartamentoContrato.TabIndex = 51;
            // 
            // txtCURP
            // 
            this.txtCURP.Location = new System.Drawing.Point(470, 94);
            this.txtCURP.Name = "txtCURP";
            this.txtCURP.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtCURP.Properties.Appearance.Options.UseBackColor = true;
            this.txtCURP.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCURP.Properties.MaxLength = 18;
            this.txtCURP.Properties.ReadOnly = true;
            this.txtCURP.Size = new System.Drawing.Size(224, 20);
            this.txtCURP.TabIndex = 14;
            this.txtCURP.Tag = "CURP";
            // 
            // txtRFC
            // 
            this.txtRFC.Location = new System.Drawing.Point(238, 94);
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtRFC.Properties.Appearance.Options.UseBackColor = true;
            this.txtRFC.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRFC.Properties.MaxLength = 13;
            this.txtRFC.Properties.ReadOnly = true;
            this.txtRFC.Size = new System.Drawing.Size(220, 20);
            this.txtRFC.TabIndex = 13;
            this.txtRFC.Tag = "RFC";
            // 
            // txtNSS
            // 
            this.txtNSS.Location = new System.Drawing.Point(12, 95);
            this.txtNSS.Name = "txtNSS";
            this.txtNSS.Properties.MaxLength = 11;
            this.txtNSS.Properties.ReadOnly = true;
            this.txtNSS.Size = new System.Drawing.Size(214, 20);
            this.txtNSS.TabIndex = 12;
            this.txtNSS.TabStop = false;
            this.txtNSS.Tag = "El NSS";
            // 
            // txtAMaternoEmpleado
            // 
            this.txtAMaternoEmpleado.Location = new System.Drawing.Point(470, 57);
            this.txtAMaternoEmpleado.Name = "txtAMaternoEmpleado";
            this.txtAMaternoEmpleado.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtAMaternoEmpleado.Properties.Appearance.Options.UseBackColor = true;
            this.txtAMaternoEmpleado.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAMaternoEmpleado.Properties.MaxLength = 100;
            this.txtAMaternoEmpleado.Properties.ReadOnly = true;
            this.txtAMaternoEmpleado.Size = new System.Drawing.Size(224, 20);
            this.txtAMaternoEmpleado.TabIndex = 8;
            // 
            // txtAPaternoEmpleado
            // 
            this.txtAPaternoEmpleado.Location = new System.Drawing.Point(238, 57);
            this.txtAPaternoEmpleado.Name = "txtAPaternoEmpleado";
            this.txtAPaternoEmpleado.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtAPaternoEmpleado.Properties.Appearance.Options.UseBackColor = true;
            this.txtAPaternoEmpleado.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAPaternoEmpleado.Properties.MaxLength = 100;
            this.txtAPaternoEmpleado.Properties.ReadOnly = true;
            this.txtAPaternoEmpleado.Size = new System.Drawing.Size(220, 20);
            this.txtAPaternoEmpleado.TabIndex = 7;
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Location = new System.Drawing.Point(12, 57);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtNombreEmpleado.Properties.Appearance.Options.UseBackColor = true;
            this.txtNombreEmpleado.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreEmpleado.Properties.MaxLength = 100;
            this.txtNombreEmpleado.Properties.ReadOnly = true;
            this.txtNombreEmpleado.Size = new System.Drawing.Size(214, 20);
            this.txtNombreEmpleado.TabIndex = 5;
            this.txtNombreEmpleado.Tag = "Nombre del Empleado";
            // 
            // txtNoEmpleado
            // 
            this.txtNoEmpleado.Location = new System.Drawing.Point(87, 15);
            this.txtNoEmpleado.Name = "txtNoEmpleado";
            this.txtNoEmpleado.Properties.ReadOnly = true;
            this.txtNoEmpleado.Size = new System.Drawing.Size(100, 20);
            this.txtNoEmpleado.TabIndex = 1;
            this.txtNoEmpleado.TabStop = false;
            // 
            // lblNoEmpleado
            // 
            this.lblNoEmpleado.Location = new System.Drawing.Point(12, 19);
            this.lblNoEmpleado.Name = "lblNoEmpleado";
            this.lblNoEmpleado.Size = new System.Drawing.Size(66, 13);
            this.lblNoEmpleado.TabIndex = 0;
            this.lblNoEmpleado.Text = "No. Empleado";
            // 
            // lblCurp
            // 
            this.lblCurp.Location = new System.Drawing.Point(470, 81);
            this.lblCurp.Name = "lblCurp";
            this.lblCurp.Size = new System.Drawing.Size(27, 13);
            this.lblCurp.TabIndex = 11;
            this.lblCurp.Text = "CURP";
            // 
            // lblRFC
            // 
            this.lblRFC.Location = new System.Drawing.Point(238, 81);
            this.lblRFC.Name = "lblRFC";
            this.lblRFC.Size = new System.Drawing.Size(20, 13);
            this.lblRFC.TabIndex = 10;
            this.lblRFC.Text = "RFC";
            // 
            // lblNSS
            // 
            this.lblNSS.Location = new System.Drawing.Point(12, 81);
            this.lblNSS.Name = "lblNSS";
            this.lblNSS.Size = new System.Drawing.Size(19, 13);
            this.lblNSS.TabIndex = 9;
            this.lblNSS.Text = "NSS";
            // 
            // lblAMat
            // 
            this.lblAMat.Location = new System.Drawing.Point(470, 44);
            this.lblAMat.Name = "lblAMat";
            this.lblAMat.Size = new System.Drawing.Size(80, 13);
            this.lblAMat.TabIndex = 4;
            this.lblAMat.Text = "Apellido Materno";
            // 
            // lblAPat
            // 
            this.lblAPat.Location = new System.Drawing.Point(238, 44);
            this.lblAPat.Name = "lblAPat";
            this.lblAPat.Size = new System.Drawing.Size(78, 13);
            this.lblAPat.TabIndex = 3;
            this.lblAPat.Text = "Apellido Paterno";
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(12, 44);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(37, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // vwCatEstatusEmpleadoCFDITableAdapter
            // 
            this.vwCatEstatusEmpleadoCFDITableAdapter.ClearBeforeFill = true;
            // 
            // cboIdEmpleado
            // 
            this.cboIdEmpleado.EditValue = "";
            this.cboIdEmpleado.Location = new System.Drawing.Point(99, 41);
            this.cboIdEmpleado.Name = "cboIdEmpleado";
            this.cboIdEmpleado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboIdEmpleado.Properties.DataSource = this.stpSelEmpleadosDisponiblesSEGUROSBindingSource;
            this.cboIdEmpleado.Properties.DisplayMember = "NombreEmpleadoCompleto";
            this.cboIdEmpleado.Properties.ValueMember = "IdEmpleado";
            this.cboIdEmpleado.Properties.View = this.gridView1;
            this.cboIdEmpleado.Size = new System.Drawing.Size(639, 20);
            this.cboIdEmpleado.TabIndex = 2;
            this.cboIdEmpleado.EditValueChanged += new System.EventHandler(this.cboIdEmpleado_EditValueChanged);
            // 
            // stpSelEmpleadosDisponiblesSEGUROSBindingSource
            // 
            this.stpSelEmpleadosDisponiblesSEGUROSBindingSource.DataMember = "stpSelEmpleadosDisponiblesSEGUROS";
            this.stpSelEmpleadosDisponiblesSEGUROSBindingSource.DataSource = this.dbSAICBPOCatalogosDataSetBindingSource;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpleado,
            this.colNombreEmpleadoCompleto,
            this.colNSS,
            this.colRFC,
            this.colCURP});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsCustomization.AllowColumnMoving = false;
            this.gridView1.OptionsCustomization.AllowGroup = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIdEmpleado
            // 
            this.colIdEmpleado.AppearanceCell.Options.UseTextOptions = true;
            this.colIdEmpleado.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIdEmpleado.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdEmpleado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIdEmpleado.Caption = "No. Empleado";
            this.colIdEmpleado.FieldName = "IdEmpleado";
            this.colIdEmpleado.Name = "colIdEmpleado";
            this.colIdEmpleado.OptionsColumn.ReadOnly = true;
            this.colIdEmpleado.Visible = true;
            this.colIdEmpleado.VisibleIndex = 0;
            // 
            // colNombreEmpleadoCompleto
            // 
            this.colNombreEmpleadoCompleto.Caption = "Nombre Completo";
            this.colNombreEmpleadoCompleto.FieldName = "NombreEmpleadoCompleto";
            this.colNombreEmpleadoCompleto.Name = "colNombreEmpleadoCompleto";
            this.colNombreEmpleadoCompleto.OptionsColumn.ReadOnly = true;
            this.colNombreEmpleadoCompleto.Visible = true;
            this.colNombreEmpleadoCompleto.VisibleIndex = 1;
            this.colNombreEmpleadoCompleto.Width = 250;
            // 
            // colNSS
            // 
            this.colNSS.FieldName = "NSS";
            this.colNSS.Name = "colNSS";
            this.colNSS.Visible = true;
            this.colNSS.VisibleIndex = 2;
            this.colNSS.Width = 100;
            // 
            // colRFC
            // 
            this.colRFC.FieldName = "RFC";
            this.colRFC.Name = "colRFC";
            this.colRFC.Visible = true;
            this.colRFC.VisibleIndex = 3;
            this.colRFC.Width = 100;
            // 
            // colCURP
            // 
            this.colCURP.FieldName = "CURP";
            this.colCURP.Name = "colCURP";
            this.colCURP.Visible = true;
            this.colCURP.VisibleIndex = 4;
            this.colCURP.Width = 150;
            // 
            // stpSelEmpleadosDisponiblesBindingSource
            // 
            this.stpSelEmpleadosDisponiblesBindingSource.DataMember = "stpSelEmpleadosDisponibles";
            this.stpSelEmpleadosDisponiblesBindingSource.DataSource = this.dbSAICBPOCatalogosDataSet;
            // 
            // stpSelEmpleadosDisponiblesTableAdapter
            // 
            this.stpSelEmpleadosDisponiblesTableAdapter.ClearBeforeFill = true;
            // 
            // vwCatTenedoraSATableAdapter
            // 
            this.vwCatTenedoraSATableAdapter.ClearBeforeFill = true;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 67);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtpEmpleadoTenedora;
            this.xtraTabControl1.Size = new System.Drawing.Size(726, 564);
            this.xtraTabControl1.TabIndex = 11;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtpEmpleadoTenedora});
            // 
            // xtpEmpleadoTenedora
            // 
            this.xtpEmpleadoTenedora.Controls.Add(this.ControlPolizas);
            this.xtpEmpleadoTenedora.Controls.Add(this.groupControl2);
            this.xtpEmpleadoTenedora.Controls.Add(this.gpcInformacionContrato);
            this.xtpEmpleadoTenedora.Controls.Add(this.txtNoEmpleado);
            this.xtpEmpleadoTenedora.Controls.Add(this.txtCURP);
            this.xtpEmpleadoTenedora.Controls.Add(this.lblNombre);
            this.xtpEmpleadoTenedora.Controls.Add(this.txtRFC);
            this.xtpEmpleadoTenedora.Controls.Add(this.lblAPat);
            this.xtpEmpleadoTenedora.Controls.Add(this.txtNSS);
            this.xtpEmpleadoTenedora.Controls.Add(this.lblAMat);
            this.xtpEmpleadoTenedora.Controls.Add(this.txtAMaternoEmpleado);
            this.xtpEmpleadoTenedora.Controls.Add(this.lblNSS);
            this.xtpEmpleadoTenedora.Controls.Add(this.txtAPaternoEmpleado);
            this.xtpEmpleadoTenedora.Controls.Add(this.lblRFC);
            this.xtpEmpleadoTenedora.Controls.Add(this.txtNombreEmpleado);
            this.xtpEmpleadoTenedora.Controls.Add(this.lblCurp);
            this.xtpEmpleadoTenedora.Controls.Add(this.lblNoEmpleado);
            this.xtpEmpleadoTenedora.Name = "xtpEmpleadoTenedora";
            this.xtpEmpleadoTenedora.Size = new System.Drawing.Size(720, 536);
            this.xtpEmpleadoTenedora.Text = "Empleado-Tenedora";
            // 
            // ControlPolizas
            // 
            this.ControlPolizas.Controls.Add(this.GridEmpleados);
            this.ControlPolizas.Location = new System.Drawing.Point(3, 335);
            this.ControlPolizas.Name = "ControlPolizas";
            this.ControlPolizas.Size = new System.Drawing.Size(710, 199);
            this.ControlPolizas.TabIndex = 60;
            this.ControlPolizas.Text = "Polizas";
            this.ControlPolizas.Click += new System.EventHandler(this.ControlPolizas_Click);
            // 
            // GridEmpleados
            // 
            this.GridEmpleados.DataSource = this.stpSelObtenerInfoEmpleadoSegurosBindingSource2;
            this.GridEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridEmpleados.Location = new System.Drawing.Point(2, 20);
            this.GridEmpleados.MainView = this.gridViewPolizasEmpleados;
            this.GridEmpleados.Name = "GridEmpleados";
            this.GridEmpleados.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonCancelar,
            this.repositoryItemButtonEliminar});
            this.GridEmpleados.Size = new System.Drawing.Size(706, 177);
            this.GridEmpleados.TabIndex = 9;
            this.GridEmpleados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPolizasEmpleados});
            this.GridEmpleados.Click += new System.EventHandler(this.GridEmpleados_Click);
            // 
            // stpSelObtenerInfoEmpleadoSegurosBindingSource2
            // 
            this.stpSelObtenerInfoEmpleadoSegurosBindingSource2.DataMember = "stpSelObtenerInfoEmpleadoSeguros";
            this.stpSelObtenerInfoEmpleadoSegurosBindingSource2.DataSource = this.dbSAICBPOCatalogosDataSet;
            // 
            // gridViewPolizasEmpleados
            // 
            this.gridViewPolizasEmpleados.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colControlPoliza1,
            this.colCIA1,
            this.colTipoSeguro1,
            this.colNoPoliza1,
            this.colEstatus1,
            this.colFechaINI1,
            this.colContratante1,
            this.colClienteContratante1,
            this.gridColumnEliminar,
            this.gridColumnCancelar,
            this.ColFechaFin1,
            this.ColFolio1});
            this.gridViewPolizasEmpleados.CustomizationFormBounds = new System.Drawing.Rectangle(395, 363, 208, 170);
            this.gridViewPolizasEmpleados.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridViewPolizasEmpleados.GridControl = this.GridEmpleados;
            this.gridViewPolizasEmpleados.Name = "gridViewPolizasEmpleados";
            this.gridViewPolizasEmpleados.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewPolizasEmpleados.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewPolizasEmpleados.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gridViewPolizasEmpleados.OptionsView.ColumnAutoWidth = false;
            this.gridViewPolizasEmpleados.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewPolizasEmpleados.OptionsView.ShowFooter = true;
            this.gridViewPolizasEmpleados.OptionsView.ShowGroupPanel = false;
            this.gridViewPolizasEmpleados.Click += new System.EventHandler(this.gridViewPolizasEmpleados_Click);
            this.gridViewPolizasEmpleados.DoubleClick += new System.EventHandler(this.gridViewPolizasEmpleados_DoubleClick);
            // 
            // colControlPoliza1
            // 
            this.colControlPoliza1.Caption = "No. Control Poliza";
            this.colControlPoliza1.FieldName = "IdEmpleadoPoliza";
            this.colControlPoliza1.Name = "colControlPoliza1";
            this.colControlPoliza1.Visible = true;
            this.colControlPoliza1.VisibleIndex = 0;
            this.colControlPoliza1.Width = 105;
            // 
            // colCIA1
            // 
            this.colCIA1.Caption = "CIA";
            this.colCIA1.FieldName = "DescCIAAseguradora";
            this.colCIA1.Name = "colCIA1";
            this.colCIA1.Visible = true;
            this.colCIA1.VisibleIndex = 3;
            this.colCIA1.Width = 127;
            // 
            // colTipoSeguro1
            // 
            this.colTipoSeguro1.Caption = "Tipo Seguro";
            this.colTipoSeguro1.FieldName = "DescTipoSeguro";
            this.colTipoSeguro1.Name = "colTipoSeguro1";
            this.colTipoSeguro1.Visible = true;
            this.colTipoSeguro1.VisibleIndex = 2;
            this.colTipoSeguro1.Width = 77;
            // 
            // colNoPoliza1
            // 
            this.colNoPoliza1.Caption = "No. Póliza";
            this.colNoPoliza1.FieldName = "NoPoliza";
            this.colNoPoliza1.Name = "colNoPoliza1";
            this.colNoPoliza1.Visible = true;
            this.colNoPoliza1.VisibleIndex = 1;
            this.colNoPoliza1.Width = 101;
            // 
            // colEstatus1
            // 
            this.colEstatus1.Caption = "Estatus";
            this.colEstatus1.FieldName = "DescEstatus";
            this.colEstatus1.Name = "colEstatus1";
            this.colEstatus1.Visible = true;
            this.colEstatus1.VisibleIndex = 7;
            this.colEstatus1.Width = 76;
            // 
            // colFechaINI1
            // 
            this.colFechaINI1.Caption = "Fecha Inicio Vigencia";
            this.colFechaINI1.FieldName = "FechaIniVig";
            this.colFechaINI1.Name = "colFechaINI1";
            this.colFechaINI1.Visible = true;
            this.colFechaINI1.VisibleIndex = 8;
            this.colFechaINI1.Width = 119;
            // 
            // colContratante1
            // 
            this.colContratante1.Caption = "Contratante";
            this.colContratante1.FieldName = "RazonSocialTenedora";
            this.colContratante1.Name = "colContratante1";
            this.colContratante1.Visible = true;
            this.colContratante1.VisibleIndex = 4;
            this.colContratante1.Width = 122;
            // 
            // colClienteContratante1
            // 
            this.colClienteContratante1.Caption = "Cliente Contratante";
            this.colClienteContratante1.FieldName = "RazonSocialClientePoliza";
            this.colClienteContratante1.Name = "colClienteContratante1";
            this.colClienteContratante1.Visible = true;
            this.colClienteContratante1.VisibleIndex = 5;
            this.colClienteContratante1.Width = 166;
            // 
            // gridColumnEliminar
            // 
            this.gridColumnEliminar.Caption = "Eliminar Póliza";
            this.gridColumnEliminar.ColumnEdit = this.repositoryItemButtonEliminar;
            this.gridColumnEliminar.Name = "gridColumnEliminar";
            this.gridColumnEliminar.Width = 88;
            // 
            // repositoryItemButtonEliminar
            // 
            this.repositoryItemButtonEliminar.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.repositoryItemButtonEliminar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEliminar.Name = "repositoryItemButtonEliminar";
            this.repositoryItemButtonEliminar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEliminar.Click += new System.EventHandler(this.repositoryItemButtonEliminar_Click);
            // 
            // gridColumnCancelar
            // 
            this.gridColumnCancelar.Caption = "Cancelar Póliza";
            this.gridColumnCancelar.ColumnEdit = this.repositoryItemButtonCancelar;
            this.gridColumnCancelar.Name = "gridColumnCancelar";
            this.gridColumnCancelar.Width = 94;
            // 
            // repositoryItemButtonCancelar
            // 
            this.repositoryItemButtonCancelar.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.repositoryItemButtonCancelar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonCancelar.Name = "repositoryItemButtonCancelar";
            this.repositoryItemButtonCancelar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonCancelar.Click += new System.EventHandler(this.repositoryItemButtonCancelar_Click);
            // 
            // ColFechaFin1
            // 
            this.ColFechaFin1.Caption = "Fecha Fin Vigencia";
            this.ColFechaFin1.FieldName = "FechaFinVig";
            this.ColFechaFin1.Name = "ColFechaFin1";
            this.ColFechaFin1.Visible = true;
            this.ColFechaFin1.VisibleIndex = 9;
            this.ColFechaFin1.Width = 108;
            // 
            // ColFolio1
            // 
            this.ColFolio1.Caption = "Folio";
            this.ColFolio1.FieldName = "Folio";
            this.ColFolio1.Name = "ColFolio1";
            this.ColFolio1.Visible = true;
            this.ColFolio1.VisibleIndex = 6;
            this.ColFolio1.Width = 115;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.txtFolio);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.txtEmpleadoPoliza);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.cboIdTipoPoliza);
            this.groupControl2.Controls.Add(this.labelControl7);
            this.groupControl2.Controls.Add(this.cboIdTipoSeguro);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Location = new System.Drawing.Point(5, 254);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(708, 75);
            this.groupControl2.TabIndex = 59;
            this.groupControl2.Text = "Insertar / Eliminar / Baja Poliza";
            // 
            // txtFolio
            // 
            this.txtFolio.EditValue = "";
            this.txtFolio.Enabled = false;
            this.txtFolio.Location = new System.Drawing.Point(489, 46);
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtFolio.Properties.Appearance.Options.UseBackColor = true;
            this.txtFolio.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFolio.Properties.MaxLength = 50;
            this.txtFolio.Size = new System.Drawing.Size(206, 20);
            this.txtFolio.TabIndex = 67;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(465, 49);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(22, 13);
            this.labelControl3.TabIndex = 66;
            this.labelControl3.Text = "Folio";
            // 
            // txtEmpleadoPoliza
            // 
            this.txtEmpleadoPoliza.EditValue = "0";
            this.txtEmpleadoPoliza.Enabled = false;
            this.txtEmpleadoPoliza.Location = new System.Drawing.Point(67, 23);
            this.txtEmpleadoPoliza.Name = "txtEmpleadoPoliza";
            this.txtEmpleadoPoliza.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtEmpleadoPoliza.Properties.Appearance.Options.UseBackColor = true;
            this.txtEmpleadoPoliza.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmpleadoPoliza.Properties.MaxLength = 100;
            this.txtEmpleadoPoliza.Size = new System.Drawing.Size(108, 20);
            this.txtEmpleadoPoliza.TabIndex = 62;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(37, 26);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(27, 13);
            this.labelControl2.TabIndex = 61;
            this.labelControl2.Text = "Poliza";
            // 
            // cboIdTipoPoliza
            // 
            this.cboIdTipoPoliza.Location = new System.Drawing.Point(306, 45);
            this.cboIdTipoPoliza.Name = "cboIdTipoPoliza";
            this.cboIdTipoPoliza.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.cboIdTipoPoliza.Properties.Appearance.Options.UseBackColor = true;
            this.cboIdTipoPoliza.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
            this.cboIdTipoPoliza.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboIdTipoPoliza.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdPoliza", "Id Poliza", 63, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NoPoliza", "No Poliza", 53, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DescCIAAseguradora", "Desc CIA Aseguradora", 119, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FechaIniVig", "Fecha Ini Vig", 71, DevExpress.Utils.FormatType.DateTime, "dd/MM/yyyy", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FechaFinVig", "Fecha Fin Vig", 73, DevExpress.Utils.FormatType.DateTime, "dd/MM/yyyy", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cboIdTipoPoliza.Properties.DataSource = this.stpSelObtenerTipoPolizaBindingSource;
            this.cboIdTipoPoliza.Properties.DisplayMember = "NoPoliza";
            this.cboIdTipoPoliza.Properties.NullText = "";
            this.cboIdTipoPoliza.Properties.PopupWidth = 20;
            this.cboIdTipoPoliza.Properties.ValueMember = "IdPoliza";
            this.cboIdTipoPoliza.Size = new System.Drawing.Size(153, 20);
            this.cboIdTipoPoliza.TabIndex = 59;
            this.cboIdTipoPoliza.Tag = "No. Poliza";
            // 
            // stpSelObtenerTipoPolizaBindingSource
            // 
            this.stpSelObtenerTipoPolizaBindingSource.DataMember = "stpSelObtenerTipoPoliza";
            this.stpSelObtenerTipoPolizaBindingSource.DataSource = this.dbSAICBPOCatalogosDataSetBindingSource;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(257, 49);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(47, 13);
            this.labelControl7.TabIndex = 58;
            this.labelControl7.Text = "No. Poliza";
            // 
            // cboIdTipoSeguro
            // 
            this.cboIdTipoSeguro.Location = new System.Drawing.Point(67, 46);
            this.cboIdTipoSeguro.Name = "cboIdTipoSeguro";
            this.cboIdTipoSeguro.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.cboIdTipoSeguro.Properties.Appearance.Options.UseBackColor = true;
            this.cboIdTipoSeguro.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboIdTipoSeguro.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdTipoSeguro", "IdTipoSeguro", 50, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Center, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DescTipoSeguro", "Tipo Seguro", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cboIdTipoSeguro.Properties.DataSource = this.stpSelTipoSeguroBindingSource;
            this.cboIdTipoSeguro.Properties.DisplayMember = "DescTipoSeguro";
            this.cboIdTipoSeguro.Properties.NullText = "";
            this.cboIdTipoSeguro.Properties.ValueMember = "IdTipoSeguro";
            this.cboIdTipoSeguro.Size = new System.Drawing.Size(181, 20);
            this.cboIdTipoSeguro.TabIndex = 2;
            this.cboIdTipoSeguro.Tag = "Tipo de Seguro";
            this.cboIdTipoSeguro.EditValueChanged += new System.EventHandler(this.cboIdTipoSeguro_EditValueChanged);
            // 
            // stpSelTipoSeguroBindingSource
            // 
            this.stpSelTipoSeguroBindingSource.DataMember = "stpSelTipoSeguro";
            this.stpSelTipoSeguroBindingSource.DataSource = this.dbSAICBPOCatalogosDataSet;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(7, 49);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(57, 13);
            this.labelControl1.TabIndex = 51;
            this.labelControl1.Text = "Tipo Seguro";
            // 
            // stpSelObtenerInfoEmpleadoSegurosBindingSource
            // 
            this.stpSelObtenerInfoEmpleadoSegurosBindingSource.DataMember = "stpSelObtenerInfoEmpleadoSeguros";
            this.stpSelObtenerInfoEmpleadoSegurosBindingSource.DataSource = this.dbSAICBPOCatalogosDataSetBindingSource;
            // 
            // vwCatTipoSeguroBindingSource
            // 
            this.vwCatTipoSeguroBindingSource.DataMember = "vwCatTipoSeguro";
            this.vwCatTipoSeguroBindingSource.DataSource = this.dbSAICBPOCatalogosDataSetBindingSource;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Enabled = false;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(8, 147);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(164, 25);
            this.simpleButton1.TabIndex = 65;
            this.simpleButton1.Text = "Cancelar";
            this.simpleButton1.ToolTip = "Cancelar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnCancelarPoliza
            // 
            this.btnCancelarPoliza.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCancelarPoliza.Enabled = false;
            this.btnCancelarPoliza.ImageOptions.Image = global::winAppSAIC.Properties.Resources.Borrar1;
            this.btnCancelarPoliza.Location = new System.Drawing.Point(8, 88);
            this.btnCancelarPoliza.Name = "btnCancelarPoliza";
            this.btnCancelarPoliza.Size = new System.Drawing.Size(164, 25);
            this.btnCancelarPoliza.TabIndex = 64;
            this.btnCancelarPoliza.Text = "Cancelar Póliza";
            this.btnCancelarPoliza.ToolTip = "Cancelar Póliza";
            this.btnCancelarPoliza.Click += new System.EventHandler(this.btnCancelarPoliza_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.ImageOptions.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(8, 117);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(164, 25);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Eliminar Póliza";
            this.btnCancelar.ToolTip = "Eliminar Póliza";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // stpSelEmpleadosDisponiblesSEGUROSTableAdapter
            // 
            this.stpSelEmpleadosDisponiblesSEGUROSTableAdapter.ClearBeforeFill = true;
            // 
            // stpSelObtenerInfoEmpleadoSegurosTableAdapter
            // 
            this.stpSelObtenerInfoEmpleadoSegurosTableAdapter.ClearBeforeFill = true;
            // 
            // vwCatClienteTableAdapter
            // 
            this.vwCatClienteTableAdapter.ClearBeforeFill = true;
            // 
            // stpSelObtenerInfoEmpleadoSegurosBindingSource1
            // 
            this.stpSelObtenerInfoEmpleadoSegurosBindingSource1.DataMember = "stpSelObtenerInfoEmpleadoSeguros";
            this.stpSelObtenerInfoEmpleadoSegurosBindingSource1.DataSource = this.dbSAICBPOCatalogosDataSetBindingSource;
            // 
            // stpSelObtenerInfoEmpleadoSegurosCrearTableAdapter1
            // 
            this.stpSelObtenerInfoEmpleadoSegurosCrearTableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelObtenerTipoPolizaTableAdapter
            // 
            this.stpSelObtenerTipoPolizaTableAdapter.ClearBeforeFill = true;
            // 
            // vwCatTipoSeguroTableAdapter
            // 
            this.vwCatTipoSeguroTableAdapter.ClearBeforeFill = true;
            // 
            // stpSelObtenerTipoPolizaTableAdapter1
            // 
            this.stpSelObtenerTipoPolizaTableAdapter1.ClearBeforeFill = true;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Enabled = false;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(8, 178);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(164, 25);
            this.simpleButton2.TabIndex = 66;
            this.simpleButton2.Text = "Guardar";
            this.simpleButton2.ToolTip = "Guardar";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.ImageOptions.Image")));
            this.btnEditar.Location = new System.Drawing.Point(8, 59);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(164, 25);
            this.btnEditar.TabIndex = 67;
            this.btnEditar.Text = "Editar información";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.btnAgregar_Poliza);
            this.groupControl3.Controls.Add(this.btnEditar);
            this.groupControl3.Controls.Add(this.simpleButton1);
            this.groupControl3.Controls.Add(this.btnCancelarPoliza);
            this.groupControl3.Controls.Add(this.simpleButton2);
            this.groupControl3.Controls.Add(this.btnCancelar);
            this.groupControl3.Location = new System.Drawing.Point(746, 89);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(181, 210);
            this.groupControl3.TabIndex = 68;
            this.groupControl3.Text = "Acciones";
            // 
            // btnAgregar_Poliza
            // 
            this.btnAgregar_Poliza.Enabled = false;
            this.btnAgregar_Poliza.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar_Poliza.ImageOptions.Image")));
            this.btnAgregar_Poliza.Location = new System.Drawing.Point(8, 30);
            this.btnAgregar_Poliza.Name = "btnAgregar_Poliza";
            this.btnAgregar_Poliza.Size = new System.Drawing.Size(164, 25);
            this.btnAgregar_Poliza.TabIndex = 68;
            this.btnAgregar_Poliza.Text = "Agregar Póliza";
            this.btnAgregar_Poliza.ToolTip = "Guardar";
            this.btnAgregar_Poliza.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // stpSelTipoSeguroTableAdapter1
            // 
            this.stpSelTipoSeguroTableAdapter1.ClearBeforeFill = true;
            // 
            // frmxModificacionEmpleadosSeguros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 635);
            this.ControlBox = false;
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.cboIdEmpleado);
            this.Controls.Add(this.lblBuscarEmpledo);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmxModificacionEmpleadosSeguros";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Información Empleado";
            this.Load += new System.EventHandler(this.frmxModificacionEmpleadosSeguros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPONominaCFDIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCatTenedoraSABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboIdTenedoraSA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboIdEstatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCatEstatusEmpleadoCFDIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpcInformacionContrato)).EndInit();
            this.gpcInformacionContrato.ResumeLayout(false);
            this.gpcInformacionContrato.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboIdCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCatClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calFechaBajaContrato.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calFechaBajaContrato.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPuestoContrato.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calFechaIngresoReingresoContrato.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calFechaIngresoReingresoContrato.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartamentoContrato.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCURP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRFC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNSS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAMaternoEmpleado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAPaternoEmpleado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreEmpleado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoEmpleado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboIdEmpleado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelEmpleadosDisponiblesSEGUROSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelEmpleadosDisponiblesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtpEmpleadoTenedora.ResumeLayout(false);
            this.xtpEmpleadoTenedora.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ControlPolizas)).EndInit();
            this.ControlPolizas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelObtenerInfoEmpleadoSegurosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPolizasEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFolio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmpleadoPoliza.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboIdTipoPoliza.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelObtenerTipoPolizaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboIdTipoSeguro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelTipoSeguroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelObtenerInfoEmpleadoSegurosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCatTipoSeguroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelObtenerInfoEmpleadoSegurosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBuscarEmpledo;
        private DevExpress.XtraEditors.LabelControl lblNoEmpleado;
        private DevExpress.XtraEditors.LabelControl lblFechaIngresoReingreso;
        private DevExpress.XtraEditors.LabelControl lblCurp;
        private DevExpress.XtraEditors.LabelControl lblRFC;
        private DevExpress.XtraEditors.LabelControl lblNSS;
        private DevExpress.XtraEditors.LabelControl lblAMat;
        private DevExpress.XtraEditors.LabelControl lblAPat;
        private DevExpress.XtraEditors.LabelControl lblNombre;
        private DevExpress.XtraEditors.LabelControl lblEstatus;
        private DevExpress.XtraEditors.LabelControl lblTenedora;
        private DevExpress.XtraEditors.DateEdit calFechaIngresoReingresoContrato;
        private DevExpress.XtraEditors.TextEdit txtCURP;
        private DevExpress.XtraEditors.TextEdit txtRFC;
        private DevExpress.XtraEditors.TextEdit txtNSS;
        private DevExpress.XtraEditors.TextEdit txtAMaternoEmpleado;
        private DevExpress.XtraEditors.TextEdit txtAPaternoEmpleado;
        private DevExpress.XtraEditors.TextEdit txtNombreEmpleado;
        private DevExpress.XtraEditors.TextEdit txtNoEmpleado;
        private DevExpress.XtraEditors.GroupControl gpcInformacionContrato;
        private DevExpress.XtraEditors.GridLookUpEdit cboIdEstatus;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private NominaCFDI.dbSAICBPONominaCFDIDataSet dbSAICBPONominaCFDIDataSet;
        private System.Windows.Forms.BindingSource vwCatEstatusEmpleadoCFDIBindingSource;
        private NominaCFDI.dbSAICBPONominaCFDIDataSetTableAdapters.vwCatEstatusEmpleadoCFDITableAdapter vwCatEstatusEmpleadoCFDITableAdapter;
        private DevExpress.XtraEditors.GridLookUpEdit cboIdEmpleado;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private dbSAICBPOCatalogosDataSet dbSAICBPOCatalogosDataSet;
        private System.Windows.Forms.BindingSource stpSelEmpleadosDisponiblesBindingSource;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelEmpleadosDisponiblesTableAdapter stpSelEmpleadosDisponiblesTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreEmpleadoCompleto;
        private DevExpress.XtraGrid.Columns.GridColumn colNSS;
        private DevExpress.XtraGrid.Columns.GridColumn colRFC;
        private DevExpress.XtraGrid.Columns.GridColumn colCURP;
        private DevExpress.XtraEditors.LookUpEdit cboIdTenedoraSA;
        private dbSAICBPODataSet dbSAICBPODataSet;
        private System.Windows.Forms.BindingSource vwCatTenedoraSABindingSource;
        private dbSAICBPODataSetTableAdapters.vwCatTenedoraSATableAdapter vwCatTenedoraSATableAdapter;
        private DevExpress.XtraEditors.LabelControl lblFechaBaja;
        private DevExpress.XtraEditors.DateEdit calFechaBajaContrato;
        private DevExpress.XtraEditors.LabelControl lblDepar;
        private DevExpress.XtraEditors.TextEdit txtPuestoContrato;
        private DevExpress.XtraEditors.TextEdit txtDepartamentoContrato;
        private DevExpress.XtraEditors.LabelControl lblPuesto;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtpEmpleadoTenedora;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnSalir;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource dbSAICBPOCatalogosDataSetBindingSource;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashSMCargando;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstatus;
        private DevExpress.XtraGrid.Columns.GridColumn colDescEstatus;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.BindingSource dbSAICBPOCatalogosDataSetBindingSource1;
        private DevExpress.XtraEditors.LookUpEdit cboIdCliente;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.BindingSource stpSelEmpleadosDisponiblesSEGUROSBindingSource;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelEmpleadosDisponiblesSEGUROSTableAdapter stpSelEmpleadosDisponiblesSEGUROSTableAdapter;
        private System.Windows.Forms.BindingSource stpSelObtenerInfoEmpleadoSegurosBindingSource;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelObtenerInfoEmpleadoSegurosTableAdapter stpSelObtenerInfoEmpleadoSegurosTableAdapter;
        private System.Windows.Forms.BindingSource vwCatClienteBindingSource;
        private dbSAICBPODataSetTableAdapters.vwCatClienteTableAdapter vwCatClienteTableAdapter;
        private DevExpress.XtraBars.BarButtonItem btnAgregarPoliza;
        private System.Windows.Forms.BindingSource stpSelObtenerInfoEmpleadoSegurosBindingSource1;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelObtenerInfoEmpleadoSegurosCrearTableAdapter stpSelObtenerInfoEmpleadoSegurosCrearTableAdapter1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LookUpEdit cboIdTipoPoliza;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LookUpEdit cboIdTipoSeguro;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.TextEdit txtEmpleadoPoliza;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.BindingSource stpSelObtenerTipoPolizaBindingSource;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelObtenerTipoPolizaTableAdapter stpSelObtenerTipoPolizaTableAdapter;
        private DevExpress.XtraEditors.SimpleButton btnCancelarPoliza;
        private System.Windows.Forms.BindingSource vwCatTipoSeguroBindingSource;
        private dbSAICBPOCatalogosDataSetTableAdapters.vwCatTipoSeguroTableAdapter vwCatTipoSeguroTableAdapter;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelObtenerTipoPolizaTableAdapter stpSelObtenerTipoPolizaTableAdapter1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit txtFolio;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton btnEditar;
        private DevExpress.XtraEditors.SimpleButton btnAgregar_Poliza;
        private dbSAICBPOCatalogosDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelTipoSeguroTableAdapter stpSelTipoSeguroTableAdapter1;
        private System.Windows.Forms.BindingSource stpSelTipoSeguroBindingSource;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraEditors.GroupControl ControlPolizas;
        private DevExpress.XtraGrid.GridControl GridEmpleados;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPolizasEmpleados;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonCancelar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEliminar;
        private System.Windows.Forms.BindingSource stpSelObtenerInfoEmpleadoSegurosBindingSource2;
        private DevExpress.XtraGrid.Columns.GridColumn colControlPoliza1;
        private DevExpress.XtraGrid.Columns.GridColumn colCIA1;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoSeguro1;
        private DevExpress.XtraGrid.Columns.GridColumn colNoPoliza1;
        private DevExpress.XtraGrid.Columns.GridColumn colEstatus1;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaINI1;
        private DevExpress.XtraGrid.Columns.GridColumn colContratante1;
        private DevExpress.XtraGrid.Columns.GridColumn colClienteContratante1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnEliminar;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCancelar;
        private DevExpress.XtraGrid.Columns.GridColumn ColFechaFin1;
        private DevExpress.XtraGrid.Columns.GridColumn ColFolio1;
    }
}