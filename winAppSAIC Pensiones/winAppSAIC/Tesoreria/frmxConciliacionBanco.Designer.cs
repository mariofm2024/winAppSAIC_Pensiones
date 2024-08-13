namespace winAppSAIC.Tesoreria
{
    partial class frmxConciliacionBanco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmxConciliacionBanco));
            this.dbSAICBPOTesoreriaDataSet = new winAppSAIC.Tesoreria.dbSAICBPOTesoreriaDataSet();
            this.transaccionBancoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transaccionBancoTableAdapter = new winAppSAIC.Tesoreria.dbSAICBPOTesoreriaDataSetTableAdapters.TransaccionBancoTableAdapter();
            this.tableAdapterManager = new winAppSAIC.Tesoreria.dbSAICBPOTesoreriaDataSetTableAdapters.TableAdapterManager();
            this.transaccionBancoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.transaccionBancoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.transaccionBancoGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdTransaccionBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCuentaBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaTransaccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoTransaccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdClienteProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboClienteProveedor = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.stpSelClienteProveedorChequesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdBeneficiarioTransaccionBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboBeneficiarioTransaccionBanco = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.stpSelBeneficiarioTransaccionBancoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdBeneficiarioTransaccionPoliza = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboBeneficiarioTransaccionPoliza = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.stpSelBeneficiarioTransaccionBancoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMontoTransaccionRetiro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMontoTransaccionDeposito = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaAplicacionBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaConciliacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioConciliacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboEstatusTransaccionBanco = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.stpSelEstatusChequesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.stpSelClienteProveedorChequesTableAdapter = new winAppSAIC.Tesoreria.dbSAICBPOTesoreriaDataSetTableAdapters.stpSelClienteProveedorChequesTableAdapter();
            this.stpSelBeneficiarioTransaccionBancoTableAdapter = new winAppSAIC.Tesoreria.dbSAICBPOTesoreriaDataSetTableAdapters.stpSelBeneficiarioTransaccionBancoTableAdapter();
            this.stpSelEstatusChequesTableAdapter = new winAppSAIC.Tesoreria.dbSAICBPOTesoreriaDataSetTableAdapters.stpSelEstatusChequesTableAdapter();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnFiltrar = new DevExpress.XtraEditors.SimpleButton();
            this.dtFechaFin = new DevExpress.XtraEditors.DateEdit();
            this.dtFechaInicio = new DevExpress.XtraEditors.DateEdit();
            this.cboBanco = new DevExpress.XtraEditors.GridLookUpEdit();
            this.stpSelBancoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPOCatalogosDataSet = new winAppSAIC.dbSAICBPOCatalogosDataSet();
            this.idBancoGridLookUpEditView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.cboCuentaBanco = new DevExpress.XtraEditors.GridLookUpEdit();
            this.stpSelCuentaBancoPorBancoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNombreCuentaBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoCuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMoneda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.stpSelBancoTableAdapter = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelBancoTableAdapter();
            this.stpSelCuentaBancoPorBancoTableAdapter = new winAppSAIC.Tesoreria.dbSAICBPOTesoreriaDataSetTableAdapters.stpSelCuentaBancoPorBancoTableAdapter();
            this.splashSMCargando = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::winAppSAIC.frmxCargandoInformacion), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOTesoreriaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaccionBancoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaccionBancoBindingNavigator)).BeginInit();
            this.transaccionBancoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transaccionBancoGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboClienteProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelClienteProveedorChequesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboBeneficiarioTransaccionBanco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelBeneficiarioTransaccionBancoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboBeneficiarioTransaccionPoliza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelBeneficiarioTransaccionBancoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboEstatusTransaccionBanco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelEstatusChequesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaFin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaFin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaInicio.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaInicio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboBanco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelBancoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idBancoGridLookUpEditView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCuentaBanco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelCuentaBancoPorBancoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dbSAICBPOTesoreriaDataSet
            // 
            this.dbSAICBPOTesoreriaDataSet.DataSetName = "dbSAICBPOTesoreriaDataSet";
            this.dbSAICBPOTesoreriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transaccionBancoBindingSource
            // 
            this.transaccionBancoBindingSource.DataMember = "TransaccionBanco";
            this.transaccionBancoBindingSource.DataSource = this.dbSAICBPOTesoreriaDataSet;
            // 
            // transaccionBancoTableAdapter
            // 
            this.transaccionBancoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CuentaBancoTableAdapter = null;
            this.tableAdapterManager.TransaccionBancoTableAdapter = this.transaccionBancoTableAdapter;
            this.tableAdapterManager.UpdateOrder = winAppSAIC.Tesoreria.dbSAICBPOTesoreriaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // transaccionBancoBindingNavigator
            // 
            this.transaccionBancoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.transaccionBancoBindingNavigator.BindingSource = this.transaccionBancoBindingSource;
            this.transaccionBancoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.transaccionBancoBindingNavigator.CountItemFormat = "de {0}";
            this.transaccionBancoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.transaccionBancoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.transaccionBancoBindingNavigatorSaveItem,
            this.bindingNavigatorDeleteItem,
            this.toolStripSeparator1,
            this.btnSalir});
            this.transaccionBancoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.transaccionBancoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.transaccionBancoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.transaccionBancoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.transaccionBancoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.transaccionBancoBindingNavigator.Name = "transaccionBancoBindingNavigator";
            this.transaccionBancoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.transaccionBancoBindingNavigator.Size = new System.Drawing.Size(955, 25);
            this.transaccionBancoBindingNavigator.TabIndex = 0;
            this.transaccionBancoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Visible = false;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Visible = false;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // transaccionBancoBindingNavigatorSaveItem
            // 
            this.transaccionBancoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("transaccionBancoBindingNavigatorSaveItem.Image")));
            this.transaccionBancoBindingNavigatorSaveItem.Name = "transaccionBancoBindingNavigatorSaveItem";
            this.transaccionBancoBindingNavigatorSaveItem.Size = new System.Drawing.Size(198, 22);
            this.transaccionBancoBindingNavigatorSaveItem.Text = "Guardar Movimientos Afectados";
            this.transaccionBancoBindingNavigatorSaveItem.Click += new System.EventHandler(this.transaccionBancoBindingNavigatorSaveItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::winAppSAIC.Properties.Resources.Salir24x24;
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(49, 22);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // transaccionBancoGridControl
            // 
            this.transaccionBancoGridControl.DataSource = this.transaccionBancoBindingSource;
            this.transaccionBancoGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transaccionBancoGridControl.Location = new System.Drawing.Point(2, 2);
            this.transaccionBancoGridControl.MainView = this.gridView1;
            this.transaccionBancoGridControl.Name = "transaccionBancoGridControl";
            this.transaccionBancoGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cboClienteProveedor,
            this.cboBeneficiarioTransaccionBanco,
            this.cboBeneficiarioTransaccionPoliza,
            this.cboEstatusTransaccionBanco});
            this.transaccionBancoGridControl.Size = new System.Drawing.Size(951, 365);
            this.transaccionBancoGridControl.TabIndex = 2;
            this.transaccionBancoGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdTransaccionBanco,
            this.colIdCuentaBanco,
            this.colFechaTransaccion,
            this.colNoTransaccion,
            this.colIdClienteProveedor,
            this.colIdBeneficiarioTransaccionBanco,
            this.colIdBeneficiarioTransaccionPoliza,
            this.colMontoTransaccionRetiro,
            this.colMontoTransaccionDeposito,
            this.colFechaAplicacionBanco,
            this.colFechaConciliacion,
            this.colUsuarioConciliacion});
            this.gridView1.GridControl = this.transaccionBancoGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gridView1_ValidatingEditor);
            // 
            // colIdTransaccionBanco
            // 
            this.colIdTransaccionBanco.FieldName = "IdTransaccionBanco";
            this.colIdTransaccionBanco.Name = "colIdTransaccionBanco";
            this.colIdTransaccionBanco.OptionsColumn.ReadOnly = true;
            // 
            // colIdCuentaBanco
            // 
            this.colIdCuentaBanco.FieldName = "IdCuentaBanco";
            this.colIdCuentaBanco.Name = "colIdCuentaBanco";
            // 
            // colFechaTransaccion
            // 
            this.colFechaTransaccion.AppearanceCell.Options.UseTextOptions = true;
            this.colFechaTransaccion.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFechaTransaccion.AppearanceHeader.Options.UseTextOptions = true;
            this.colFechaTransaccion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFechaTransaccion.Caption = "Fecha Mov.";
            this.colFechaTransaccion.FieldName = "FechaTransaccion";
            this.colFechaTransaccion.Name = "colFechaTransaccion";
            this.colFechaTransaccion.OptionsColumn.AllowEdit = false;
            this.colFechaTransaccion.Visible = true;
            this.colFechaTransaccion.VisibleIndex = 0;
            // 
            // colNoTransaccion
            // 
            this.colNoTransaccion.AppearanceCell.Options.UseTextOptions = true;
            this.colNoTransaccion.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNoTransaccion.AppearanceHeader.Options.UseTextOptions = true;
            this.colNoTransaccion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNoTransaccion.Caption = "No. Mov.";
            this.colNoTransaccion.FieldName = "NoTransaccion";
            this.colNoTransaccion.Name = "colNoTransaccion";
            this.colNoTransaccion.OptionsColumn.AllowEdit = false;
            this.colNoTransaccion.Visible = true;
            this.colNoTransaccion.VisibleIndex = 1;
            this.colNoTransaccion.Width = 90;
            // 
            // colIdClienteProveedor
            // 
            this.colIdClienteProveedor.Caption = "Cliente/Proveedor";
            this.colIdClienteProveedor.ColumnEdit = this.cboClienteProveedor;
            this.colIdClienteProveedor.FieldName = "IdClienteProveedor";
            this.colIdClienteProveedor.Name = "colIdClienteProveedor";
            this.colIdClienteProveedor.OptionsColumn.AllowEdit = false;
            this.colIdClienteProveedor.Visible = true;
            this.colIdClienteProveedor.VisibleIndex = 2;
            this.colIdClienteProveedor.Width = 150;
            // 
            // cboClienteProveedor
            // 
            this.cboClienteProveedor.AutoHeight = false;
            this.cboClienteProveedor.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboClienteProveedor.DataSource = this.stpSelClienteProveedorChequesBindingSource;
            this.cboClienteProveedor.DisplayMember = "NombreComercial";
            this.cboClienteProveedor.Name = "cboClienteProveedor";
            this.cboClienteProveedor.ValueMember = "IdCliente";
            this.cboClienteProveedor.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // stpSelClienteProveedorChequesBindingSource
            // 
            this.stpSelClienteProveedorChequesBindingSource.DataMember = "stpSelClienteProveedorCheques";
            this.stpSelClienteProveedorChequesBindingSource.DataSource = this.dbSAICBPOTesoreriaDataSet;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdBeneficiarioTransaccionBanco
            // 
            this.colIdBeneficiarioTransaccionBanco.Caption = "Beneficiario Banco";
            this.colIdBeneficiarioTransaccionBanco.ColumnEdit = this.cboBeneficiarioTransaccionBanco;
            this.colIdBeneficiarioTransaccionBanco.FieldName = "IdBeneficiarioTransaccionBanco";
            this.colIdBeneficiarioTransaccionBanco.Name = "colIdBeneficiarioTransaccionBanco";
            this.colIdBeneficiarioTransaccionBanco.OptionsColumn.AllowEdit = false;
            this.colIdBeneficiarioTransaccionBanco.Visible = true;
            this.colIdBeneficiarioTransaccionBanco.VisibleIndex = 3;
            this.colIdBeneficiarioTransaccionBanco.Width = 150;
            // 
            // cboBeneficiarioTransaccionBanco
            // 
            this.cboBeneficiarioTransaccionBanco.AutoHeight = false;
            this.cboBeneficiarioTransaccionBanco.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboBeneficiarioTransaccionBanco.DataSource = this.stpSelBeneficiarioTransaccionBancoBindingSource;
            this.cboBeneficiarioTransaccionBanco.DisplayMember = "NombreBeneficiarioTransaccionBanco";
            this.cboBeneficiarioTransaccionBanco.Name = "cboBeneficiarioTransaccionBanco";
            this.cboBeneficiarioTransaccionBanco.ValueMember = "IdBeneficiarioTransaccionBanco";
            this.cboBeneficiarioTransaccionBanco.View = this.gridView2;
            // 
            // stpSelBeneficiarioTransaccionBancoBindingSource
            // 
            this.stpSelBeneficiarioTransaccionBancoBindingSource.DataMember = "stpSelBeneficiarioTransaccionBanco";
            this.stpSelBeneficiarioTransaccionBancoBindingSource.DataSource = this.dbSAICBPOTesoreriaDataSet;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colIdBeneficiarioTransaccionPoliza
            // 
            this.colIdBeneficiarioTransaccionPoliza.Caption = "Beneficiario Póliza";
            this.colIdBeneficiarioTransaccionPoliza.ColumnEdit = this.cboBeneficiarioTransaccionPoliza;
            this.colIdBeneficiarioTransaccionPoliza.FieldName = "IdBeneficiarioTransaccionPoliza";
            this.colIdBeneficiarioTransaccionPoliza.Name = "colIdBeneficiarioTransaccionPoliza";
            this.colIdBeneficiarioTransaccionPoliza.OptionsColumn.AllowEdit = false;
            this.colIdBeneficiarioTransaccionPoliza.Visible = true;
            this.colIdBeneficiarioTransaccionPoliza.VisibleIndex = 4;
            this.colIdBeneficiarioTransaccionPoliza.Width = 150;
            // 
            // cboBeneficiarioTransaccionPoliza
            // 
            this.cboBeneficiarioTransaccionPoliza.AutoHeight = false;
            this.cboBeneficiarioTransaccionPoliza.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboBeneficiarioTransaccionPoliza.DataSource = this.stpSelBeneficiarioTransaccionBancoBindingSource1;
            this.cboBeneficiarioTransaccionPoliza.DisplayMember = "NombreBeneficiarioTransaccionBanco";
            this.cboBeneficiarioTransaccionPoliza.Name = "cboBeneficiarioTransaccionPoliza";
            this.cboBeneficiarioTransaccionPoliza.ValueMember = "IdBeneficiarioTransaccionBanco";
            this.cboBeneficiarioTransaccionPoliza.View = this.gridView3;
            // 
            // stpSelBeneficiarioTransaccionBancoBindingSource1
            // 
            this.stpSelBeneficiarioTransaccionBancoBindingSource1.DataMember = "stpSelBeneficiarioTransaccionBanco";
            this.stpSelBeneficiarioTransaccionBancoBindingSource1.DataSource = this.dbSAICBPOTesoreriaDataSet;
            // 
            // gridView3
            // 
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colMontoTransaccionRetiro
            // 
            this.colMontoTransaccionRetiro.Caption = "Monto Retiro";
            this.colMontoTransaccionRetiro.DisplayFormat.FormatString = "N2";
            this.colMontoTransaccionRetiro.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMontoTransaccionRetiro.FieldName = "MontoTransaccionRetiro";
            this.colMontoTransaccionRetiro.Name = "colMontoTransaccionRetiro";
            this.colMontoTransaccionRetiro.OptionsColumn.AllowEdit = false;
            this.colMontoTransaccionRetiro.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MontoTransaccionRetiro", "{0:N2}")});
            this.colMontoTransaccionRetiro.Visible = true;
            this.colMontoTransaccionRetiro.VisibleIndex = 5;
            this.colMontoTransaccionRetiro.Width = 100;
            // 
            // colMontoTransaccionDeposito
            // 
            this.colMontoTransaccionDeposito.Caption = "Monto Depósito";
            this.colMontoTransaccionDeposito.DisplayFormat.FormatString = "N2";
            this.colMontoTransaccionDeposito.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMontoTransaccionDeposito.FieldName = "MontoTransaccionDeposito";
            this.colMontoTransaccionDeposito.Name = "colMontoTransaccionDeposito";
            this.colMontoTransaccionDeposito.OptionsColumn.AllowEdit = false;
            this.colMontoTransaccionDeposito.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MontoTransaccionDeposito", "{0:N2}")});
            this.colMontoTransaccionDeposito.Visible = true;
            this.colMontoTransaccionDeposito.VisibleIndex = 6;
            this.colMontoTransaccionDeposito.Width = 100;
            // 
            // colFechaAplicacionBanco
            // 
            this.colFechaAplicacionBanco.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.colFechaAplicacionBanco.AppearanceCell.Options.UseBackColor = true;
            this.colFechaAplicacionBanco.AppearanceCell.Options.UseTextOptions = true;
            this.colFechaAplicacionBanco.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFechaAplicacionBanco.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colFechaAplicacionBanco.AppearanceHeader.Options.UseFont = true;
            this.colFechaAplicacionBanco.AppearanceHeader.Options.UseTextOptions = true;
            this.colFechaAplicacionBanco.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFechaAplicacionBanco.Caption = "Fecha Aplicación";
            this.colFechaAplicacionBanco.FieldName = "FechaAplicacionBanco";
            this.colFechaAplicacionBanco.Name = "colFechaAplicacionBanco";
            this.colFechaAplicacionBanco.Visible = true;
            this.colFechaAplicacionBanco.VisibleIndex = 7;
            this.colFechaAplicacionBanco.Width = 100;
            // 
            // colFechaConciliacion
            // 
            this.colFechaConciliacion.FieldName = "FechaConciliacion";
            this.colFechaConciliacion.Name = "colFechaConciliacion";
            // 
            // colUsuarioConciliacion
            // 
            this.colUsuarioConciliacion.FieldName = "UsuarioConciliacion";
            this.colUsuarioConciliacion.Name = "colUsuarioConciliacion";
            // 
            // cboEstatusTransaccionBanco
            // 
            this.cboEstatusTransaccionBanco.AutoHeight = false;
            this.cboEstatusTransaccionBanco.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboEstatusTransaccionBanco.DataSource = this.stpSelEstatusChequesBindingSource;
            this.cboEstatusTransaccionBanco.DisplayMember = "DescEstatus";
            this.cboEstatusTransaccionBanco.Name = "cboEstatusTransaccionBanco";
            this.cboEstatusTransaccionBanco.ValueMember = "IdEstatus";
            this.cboEstatusTransaccionBanco.View = this.gridView4;
            // 
            // stpSelEstatusChequesBindingSource
            // 
            this.stpSelEstatusChequesBindingSource.DataMember = "stpSelEstatusCheques";
            this.stpSelEstatusChequesBindingSource.DataSource = this.dbSAICBPOTesoreriaDataSet;
            // 
            // gridView4
            // 
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // stpSelClienteProveedorChequesTableAdapter
            // 
            this.stpSelClienteProveedorChequesTableAdapter.ClearBeforeFill = true;
            // 
            // stpSelBeneficiarioTransaccionBancoTableAdapter
            // 
            this.stpSelBeneficiarioTransaccionBancoTableAdapter.ClearBeforeFill = true;
            // 
            // stpSelEstatusChequesTableAdapter
            // 
            this.stpSelEstatusChequesTableAdapter.ClearBeforeFill = true;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnFiltrar);
            this.panelControl1.Controls.Add(this.dtFechaFin);
            this.panelControl1.Controls.Add(this.dtFechaInicio);
            this.panelControl1.Controls.Add(this.cboBanco);
            this.panelControl1.Controls.Add(this.labelControl7);
            this.panelControl1.Controls.Add(this.cboCuentaBanco);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 25);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(955, 68);
            this.panelControl1.TabIndex = 3;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrar.Image")));
            this.btnFiltrar.Location = new System.Drawing.Point(737, 34);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 15;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // dtFechaFin
            // 
            this.dtFechaFin.EditValue = null;
            this.dtFechaFin.Location = new System.Drawing.Point(613, 35);
            this.dtFechaFin.Name = "dtFechaFin";
            this.dtFechaFin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaFin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaFin.Size = new System.Drawing.Size(100, 20);
            this.dtFechaFin.TabIndex = 14;
            this.dtFechaFin.Tag = "Fecha Final";
            // 
            // dtFechaInicio
            // 
            this.dtFechaInicio.EditValue = null;
            this.dtFechaInicio.Location = new System.Drawing.Point(487, 35);
            this.dtFechaInicio.Name = "dtFechaInicio";
            this.dtFechaInicio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaInicio.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaInicio.Size = new System.Drawing.Size(100, 20);
            this.dtFechaInicio.TabIndex = 13;
            this.dtFechaInicio.Tag = "Fecha Inicial";
            // 
            // cboBanco
            // 
            this.cboBanco.EditValue = "";
            this.cboBanco.Location = new System.Drawing.Point(102, 9);
            this.cboBanco.Name = "cboBanco";
            this.cboBanco.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboBanco.Properties.DataSource = this.stpSelBancoBindingSource;
            this.cboBanco.Properties.DisplayMember = "NombreBanco";
            this.cboBanco.Properties.ValueMember = "IdBanco";
            this.cboBanco.Properties.View = this.idBancoGridLookUpEditView;
            this.cboBanco.Size = new System.Drawing.Size(250, 20);
            this.cboBanco.TabIndex = 10;
            this.cboBanco.Tag = "Banco";
            this.cboBanco.EditValueChanged += new System.EventHandler(this.cboBanco_EditValueChanged);
            // 
            // stpSelBancoBindingSource
            // 
            this.stpSelBancoBindingSource.DataMember = "stpSelBanco";
            this.stpSelBancoBindingSource.DataSource = this.dbSAICBPOCatalogosDataSet;
            // 
            // dbSAICBPOCatalogosDataSet
            // 
            this.dbSAICBPOCatalogosDataSet.DataSetName = "dbSAICBPOCatalogosDataSet";
            this.dbSAICBPOCatalogosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idBancoGridLookUpEditView
            // 
            this.idBancoGridLookUpEditView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.idBancoGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.idBancoGridLookUpEditView.Name = "idBancoGridLookUpEditView";
            this.idBancoGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.idBancoGridLookUpEditView.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "IdBanco";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Banco";
            this.gridColumn2.FieldName = "NombreBanco";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(12, 39);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(82, 13);
            this.labelControl7.TabIndex = 11;
            this.labelControl7.Text = "Cuenta de Banco";
            // 
            // cboCuentaBanco
            // 
            this.cboCuentaBanco.EditValue = "";
            this.cboCuentaBanco.Location = new System.Drawing.Point(102, 35);
            this.cboCuentaBanco.Name = "cboCuentaBanco";
            this.cboCuentaBanco.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboCuentaBanco.Properties.DataSource = this.stpSelCuentaBancoPorBancoBindingSource;
            this.cboCuentaBanco.Properties.DisplayMember = "NombreCuentaBanco";
            this.cboCuentaBanco.Properties.ValueMember = "IdCuentaBanco";
            this.cboCuentaBanco.Properties.View = this.gridLookUpEdit2View;
            this.cboCuentaBanco.Size = new System.Drawing.Size(348, 20);
            this.cboCuentaBanco.TabIndex = 12;
            this.cboCuentaBanco.Tag = "Cuenta de Banco";
            // 
            // stpSelCuentaBancoPorBancoBindingSource
            // 
            this.stpSelCuentaBancoPorBancoBindingSource.DataMember = "stpSelCuentaBancoPorBanco";
            this.stpSelCuentaBancoPorBancoBindingSource.DataSource = this.dbSAICBPOTesoreriaDataSet;
            // 
            // gridLookUpEdit2View
            // 
            this.gridLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNombreCuentaBanco,
            this.colNoCuenta,
            this.gridColumn3,
            this.colIdMoneda});
            this.gridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit2View.Name = "gridLookUpEdit2View";
            this.gridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // colNombreCuentaBanco
            // 
            this.colNombreCuentaBanco.Caption = "Nombre Cuenta Banco";
            this.colNombreCuentaBanco.FieldName = "NombreCuentaBanco";
            this.colNombreCuentaBanco.Name = "colNombreCuentaBanco";
            this.colNombreCuentaBanco.OptionsColumn.AllowEdit = false;
            this.colNombreCuentaBanco.OptionsColumn.FixedWidth = true;
            this.colNombreCuentaBanco.Visible = true;
            this.colNombreCuentaBanco.VisibleIndex = 0;
            this.colNombreCuentaBanco.Width = 300;
            // 
            // colNoCuenta
            // 
            this.colNoCuenta.Caption = "No. Cuenta";
            this.colNoCuenta.FieldName = "NoCuenta";
            this.colNoCuenta.Name = "colNoCuenta";
            this.colNoCuenta.OptionsColumn.AllowEdit = false;
            this.colNoCuenta.OptionsColumn.FixedWidth = true;
            this.colNoCuenta.Visible = true;
            this.colNoCuenta.VisibleIndex = 1;
            this.colNoCuenta.Width = 84;
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "IdCuentaBanco";
            this.gridColumn3.Name = "gridColumn3";
            // 
            // colIdMoneda
            // 
            this.colIdMoneda.Caption = "Moneda";
            this.colIdMoneda.FieldName = "IdMoneda";
            this.colIdMoneda.Name = "colIdMoneda";
            this.colIdMoneda.OptionsColumn.AllowEdit = false;
            this.colIdMoneda.Visible = true;
            this.colIdMoneda.VisibleIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 12);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(29, 13);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Banco";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(594, 39);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(13, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "&Al:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(461, 39);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(19, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "&Del:";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.transaccionBancoGridControl);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 93);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(955, 369);
            this.panelControl2.TabIndex = 4;
            // 
            // stpSelBancoTableAdapter
            // 
            this.stpSelBancoTableAdapter.ClearBeforeFill = true;
            // 
            // stpSelCuentaBancoPorBancoTableAdapter
            // 
            this.stpSelCuentaBancoPorBancoTableAdapter.ClearBeforeFill = true;
            // 
            // frmxConciliacionBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 462);
            this.ControlBox = false;
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.transaccionBancoBindingNavigator);
            this.Name = "frmxConciliacionBanco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conciliación Bancaria";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmxConciliacionBanco_FormClosing);
            this.Load += new System.EventHandler(this.frmxConciliacionBanco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOTesoreriaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaccionBancoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaccionBancoBindingNavigator)).EndInit();
            this.transaccionBancoBindingNavigator.ResumeLayout(false);
            this.transaccionBancoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transaccionBancoGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboClienteProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelClienteProveedorChequesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboBeneficiarioTransaccionBanco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelBeneficiarioTransaccionBancoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboBeneficiarioTransaccionPoliza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelBeneficiarioTransaccionBancoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboEstatusTransaccionBanco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelEstatusChequesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaFin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaFin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaInicio.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaInicio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboBanco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelBancoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idBancoGridLookUpEditView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCuentaBanco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelCuentaBancoPorBancoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dbSAICBPOTesoreriaDataSet dbSAICBPOTesoreriaDataSet;
        private System.Windows.Forms.BindingSource transaccionBancoBindingSource;
        private dbSAICBPOTesoreriaDataSetTableAdapters.TransaccionBancoTableAdapter transaccionBancoTableAdapter;
        private dbSAICBPOTesoreriaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator transaccionBancoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton transaccionBancoBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl transaccionBancoGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTransaccionBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCuentaBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaTransaccion;
        private DevExpress.XtraGrid.Columns.GridColumn colNoTransaccion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdClienteProveedor;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit cboClienteProveedor;
        private System.Windows.Forms.BindingSource stpSelClienteProveedorChequesBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBeneficiarioTransaccionBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBeneficiarioTransaccionPoliza;
        private DevExpress.XtraGrid.Columns.GridColumn colMontoTransaccionRetiro;
        private DevExpress.XtraGrid.Columns.GridColumn colMontoTransaccionDeposito;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaAplicacionBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaConciliacion;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioConciliacion;
        private dbSAICBPOTesoreriaDataSetTableAdapters.stpSelClienteProveedorChequesTableAdapter stpSelClienteProveedorChequesTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit cboBeneficiarioTransaccionBanco;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.BindingSource stpSelBeneficiarioTransaccionBancoBindingSource;
        private dbSAICBPOTesoreriaDataSetTableAdapters.stpSelBeneficiarioTransaccionBancoTableAdapter stpSelBeneficiarioTransaccionBancoTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit cboBeneficiarioTransaccionPoliza;
        private System.Windows.Forms.BindingSource stpSelBeneficiarioTransaccionBancoBindingSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit cboEstatusTransaccionBanco;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private System.Windows.Forms.BindingSource stpSelEstatusChequesBindingSource;
        private dbSAICBPOTesoreriaDataSetTableAdapters.stpSelEstatusChequesTableAdapter stpSelEstatusChequesTableAdapter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GridLookUpEdit cboBanco;
        private DevExpress.XtraGrid.Views.Grid.GridView idBancoGridLookUpEditView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.GridLookUpEdit cboCuentaBanco;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit2View;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreCuentaBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colNoCuenta;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMoneda;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private dbSAICBPOCatalogosDataSet dbSAICBPOCatalogosDataSet;
        private System.Windows.Forms.BindingSource stpSelBancoBindingSource;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelBancoTableAdapter stpSelBancoTableAdapter;
        private DevExpress.XtraEditors.DateEdit dtFechaFin;
        private DevExpress.XtraEditors.DateEdit dtFechaInicio;
        private System.Windows.Forms.BindingSource stpSelCuentaBancoPorBancoBindingSource;
        private dbSAICBPOTesoreriaDataSetTableAdapters.stpSelCuentaBancoPorBancoTableAdapter stpSelCuentaBancoPorBancoTableAdapter;
        private DevExpress.XtraEditors.SimpleButton btnFiltrar;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashSMCargando;
    }
}