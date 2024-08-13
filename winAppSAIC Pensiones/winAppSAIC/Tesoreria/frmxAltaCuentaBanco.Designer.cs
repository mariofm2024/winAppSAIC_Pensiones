namespace winAppSAIC.Tesoreria
{
    partial class frmxAltaCuentaBanco
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
            System.Windows.Forms.Label idCuentaBancoLabel;
            System.Windows.Forms.Label idMatrizTenedoraLabel;
            System.Windows.Forms.Label idClasifCuentaBancoLabel;
            System.Windows.Forms.Label nombreCuentaBancoLabel;
            System.Windows.Forms.Label idBancoLabel;
            System.Windows.Forms.Label noCuentaLabel;
            System.Windows.Forms.Label noSucursalLabel;
            System.Windows.Forms.Label noClienteLabel;
            System.Windows.Forms.Label noCLABELabel;
            System.Windows.Forms.Label saldoInicialLabel;
            System.Windows.Forms.Label idMonedaLabel;
            System.Windows.Forms.Label nombreContactoLabel;
            System.Windows.Forms.Label telefono1Label;
            System.Windows.Forms.Label telefono2Label;
            System.Windows.Forms.Label correoElectronicoLabel;
            System.Windows.Forms.Label observacionesLabel;
            System.Windows.Forms.Label cuentaContableLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmxAltaCuentaBanco));
            this.cuentaBancoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.cuentaBancoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPOTesoreriaDataSet = new winAppSAIC.Tesoreria.dbSAICBPOTesoreriaDataSet();
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
            this.cuentaBancoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.idCuentaBancoLabel1 = new System.Windows.Forms.Label();
            this.noSucursalTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nombreContactoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.telefono1TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.telefono2TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.correoElectronicoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.cuentaContableTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.aplicaOperacionesCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.cboClasifCuentaBanco = new DevExpress.XtraEditors.GridLookUpEdit();
            this.stpSelClasifCuentaBancoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPOCatalogosDataSet = new winAppSAIC.dbSAICBPOCatalogosDataSet();
            this.idClasifCuentaBancoGridLookUpEditView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdClasifCuentaBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescClasifCuentaBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nombreCuentaBancoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.cboBanco = new DevExpress.XtraEditors.GridLookUpEdit();
            this.stpSelBancoTodosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idBancoGridLookUpEditView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.noCuentaTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.noClienteTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.noCLABETextEdit = new DevExpress.XtraEditors.TextEdit();
            this.saldoInicialSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.cboMoneda = new DevExpress.XtraEditors.GridLookUpEdit();
            this.stpSelMonedaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idMonedaGridLookUpEditView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdMoneda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescMoneda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.observacionesTextEdit = new DevExpress.XtraEditors.MemoEdit();
            this.cboIdMatrizTenedora = new DevExpress.XtraEditors.GridLookUpEdit();
            this.stpSelMatrizTenedoraCuentaBancoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRazonSocial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.stpSelClasifCuentaBancoTableAdapter = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelClasifCuentaBancoTableAdapter();
            this.stpSelBancoTodosTableAdapter = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelBancoTodosTableAdapter();
            this.stpSelMonedaTableAdapter = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelMonedaTableAdapter();
            this.stpSelMatrizTenedoraCuentaBancoTableAdapter = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelMatrizTenedoraCuentaBancoTableAdapter();
            this.stpSelEstatusCuentaBancoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stpSelEstatusCuentaBancoTableAdapter = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelEstatusCuentaBancoTableAdapter();
            this.cuentaBancoTableAdapter = new winAppSAIC.Tesoreria.dbSAICBPOTesoreriaDataSetTableAdapters.CuentaBancoTableAdapter();
            this.tableAdapterManager = new winAppSAIC.Tesoreria.dbSAICBPOTesoreriaDataSetTableAdapters.TableAdapterManager();
            idCuentaBancoLabel = new System.Windows.Forms.Label();
            idMatrizTenedoraLabel = new System.Windows.Forms.Label();
            idClasifCuentaBancoLabel = new System.Windows.Forms.Label();
            nombreCuentaBancoLabel = new System.Windows.Forms.Label();
            idBancoLabel = new System.Windows.Forms.Label();
            noCuentaLabel = new System.Windows.Forms.Label();
            noSucursalLabel = new System.Windows.Forms.Label();
            noClienteLabel = new System.Windows.Forms.Label();
            noCLABELabel = new System.Windows.Forms.Label();
            saldoInicialLabel = new System.Windows.Forms.Label();
            idMonedaLabel = new System.Windows.Forms.Label();
            nombreContactoLabel = new System.Windows.Forms.Label();
            telefono1Label = new System.Windows.Forms.Label();
            telefono2Label = new System.Windows.Forms.Label();
            correoElectronicoLabel = new System.Windows.Forms.Label();
            observacionesLabel = new System.Windows.Forms.Label();
            cuentaContableLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cuentaBancoBindingNavigator)).BeginInit();
            this.cuentaBancoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cuentaBancoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOTesoreriaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noSucursalTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nombreContactoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefono1TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefono2TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.correoElectronicoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuentaContableTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aplicaOperacionesCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboClasifCuentaBanco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelClasifCuentaBancoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idClasifCuentaBancoGridLookUpEditView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nombreCuentaBancoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboBanco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelBancoTodosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idBancoGridLookUpEditView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noCuentaTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noClienteTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noCLABETextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saldoInicialSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMoneda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelMonedaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idMonedaGridLookUpEditView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.observacionesTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboIdMatrizTenedora.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelMatrizTenedoraCuentaBancoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelEstatusCuentaBancoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idCuentaBancoLabel
            // 
            idCuentaBancoLabel.AutoSize = true;
            idCuentaBancoLabel.Location = new System.Drawing.Point(21, 46);
            idCuentaBancoLabel.Name = "idCuentaBancoLabel";
            idCuentaBancoLabel.Size = new System.Drawing.Size(108, 13);
            idCuentaBancoLabel.TabIndex = 1;
            idCuentaBancoLabel.Text = "Clave Cuenta Banco:";
            // 
            // idMatrizTenedoraLabel
            // 
            idMatrizTenedoraLabel.AutoSize = true;
            idMatrizTenedoraLabel.Location = new System.Drawing.Point(21, 75);
            idMatrizTenedoraLabel.Name = "idMatrizTenedoraLabel";
            idMatrizTenedoraLabel.Size = new System.Drawing.Size(52, 13);
            idMatrizTenedoraLabel.TabIndex = 3;
            idMatrizTenedoraLabel.Text = "Empresa:";
            // 
            // idClasifCuentaBancoLabel
            // 
            idClasifCuentaBancoLabel.AutoSize = true;
            idClasifCuentaBancoLabel.Location = new System.Drawing.Point(21, 103);
            idClasifCuentaBancoLabel.Name = "idClasifCuentaBancoLabel";
            idClasifCuentaBancoLabel.Size = new System.Drawing.Size(107, 13);
            idClasifCuentaBancoLabel.TabIndex = 5;
            idClasifCuentaBancoLabel.Text = "Clasificación Cuenta:";
            // 
            // nombreCuentaBancoLabel
            // 
            nombreCuentaBancoLabel.AutoSize = true;
            nombreCuentaBancoLabel.Location = new System.Drawing.Point(21, 129);
            nombreCuentaBancoLabel.Name = "nombreCuentaBancoLabel";
            nombreCuentaBancoLabel.Size = new System.Drawing.Size(118, 13);
            nombreCuentaBancoLabel.TabIndex = 7;
            nombreCuentaBancoLabel.Text = "Nombre Cuenta Banco:";
            // 
            // idBancoLabel
            // 
            idBancoLabel.AutoSize = true;
            idBancoLabel.Location = new System.Drawing.Point(21, 154);
            idBancoLabel.Name = "idBancoLabel";
            idBancoLabel.Size = new System.Drawing.Size(40, 13);
            idBancoLabel.TabIndex = 9;
            idBancoLabel.Text = "Banco:";
            // 
            // noCuentaLabel
            // 
            noCuentaLabel.AutoSize = true;
            noCuentaLabel.Location = new System.Drawing.Point(21, 180);
            noCuentaLabel.Name = "noCuentaLabel";
            noCuentaLabel.Size = new System.Drawing.Size(62, 13);
            noCuentaLabel.TabIndex = 11;
            noCuentaLabel.Text = "No Cuenta:";
            // 
            // noSucursalLabel
            // 
            noSucursalLabel.AutoSize = true;
            noSucursalLabel.Location = new System.Drawing.Point(316, 180);
            noSucursalLabel.Name = "noSucursalLabel";
            noSucursalLabel.Size = new System.Drawing.Size(67, 13);
            noSucursalLabel.TabIndex = 13;
            noSucursalLabel.Text = "No Sucursal:";
            // 
            // noClienteLabel
            // 
            noClienteLabel.AutoSize = true;
            noClienteLabel.Location = new System.Drawing.Point(21, 206);
            noClienteLabel.Name = "noClienteLabel";
            noClienteLabel.Size = new System.Drawing.Size(60, 13);
            noClienteLabel.TabIndex = 15;
            noClienteLabel.Text = "No Cliente:";
            // 
            // noCLABELabel
            // 
            noCLABELabel.AutoSize = true;
            noCLABELabel.Location = new System.Drawing.Point(316, 206);
            noCLABELabel.Name = "noCLABELabel";
            noCLABELabel.Size = new System.Drawing.Size(58, 13);
            noCLABELabel.TabIndex = 17;
            noCLABELabel.Text = "No CLABE:";
            // 
            // saldoInicialLabel
            // 
            saldoInicialLabel.AutoSize = true;
            saldoInicialLabel.Location = new System.Drawing.Point(21, 232);
            saldoInicialLabel.Name = "saldoInicialLabel";
            saldoInicialLabel.Size = new System.Drawing.Size(67, 13);
            saldoInicialLabel.TabIndex = 19;
            saldoInicialLabel.Text = "Saldo Inicial:";
            // 
            // idMonedaLabel
            // 
            idMonedaLabel.AutoSize = true;
            idMonedaLabel.Location = new System.Drawing.Point(21, 258);
            idMonedaLabel.Name = "idMonedaLabel";
            idMonedaLabel.Size = new System.Drawing.Size(49, 13);
            idMonedaLabel.TabIndex = 21;
            idMonedaLabel.Text = "Moneda:";
            // 
            // nombreContactoLabel
            // 
            nombreContactoLabel.AutoSize = true;
            nombreContactoLabel.Location = new System.Drawing.Point(21, 284);
            nombreContactoLabel.Name = "nombreContactoLabel";
            nombreContactoLabel.Size = new System.Drawing.Size(95, 13);
            nombreContactoLabel.TabIndex = 23;
            nombreContactoLabel.Text = "Nombre Contacto:";
            // 
            // telefono1Label
            // 
            telefono1Label.AutoSize = true;
            telefono1Label.Location = new System.Drawing.Point(21, 310);
            telefono1Label.Name = "telefono1Label";
            telefono1Label.Size = new System.Drawing.Size(62, 13);
            telefono1Label.TabIndex = 25;
            telefono1Label.Text = "Telefono 1:";
            // 
            // telefono2Label
            // 
            telefono2Label.AutoSize = true;
            telefono2Label.Location = new System.Drawing.Point(316, 310);
            telefono2Label.Name = "telefono2Label";
            telefono2Label.Size = new System.Drawing.Size(62, 13);
            telefono2Label.TabIndex = 27;
            telefono2Label.Text = "Telefono 2:";
            // 
            // correoElectronicoLabel
            // 
            correoElectronicoLabel.AutoSize = true;
            correoElectronicoLabel.Location = new System.Drawing.Point(21, 336);
            correoElectronicoLabel.Name = "correoElectronicoLabel";
            correoElectronicoLabel.Size = new System.Drawing.Size(99, 13);
            correoElectronicoLabel.TabIndex = 29;
            correoElectronicoLabel.Text = "Correo Electronico:";
            // 
            // observacionesLabel
            // 
            observacionesLabel.AutoSize = true;
            observacionesLabel.Location = new System.Drawing.Point(21, 360);
            observacionesLabel.Name = "observacionesLabel";
            observacionesLabel.Size = new System.Drawing.Size(82, 13);
            observacionesLabel.TabIndex = 31;
            observacionesLabel.Text = "Observaciones:";
            // 
            // cuentaContableLabel
            // 
            cuentaContableLabel.AutoSize = true;
            cuentaContableLabel.Location = new System.Drawing.Point(21, 420);
            cuentaContableLabel.Name = "cuentaContableLabel";
            cuentaContableLabel.Size = new System.Drawing.Size(92, 13);
            cuentaContableLabel.TabIndex = 33;
            cuentaContableLabel.Text = "Cuenta Contable:";
            // 
            // cuentaBancoBindingNavigator
            // 
            this.cuentaBancoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cuentaBancoBindingNavigator.BindingSource = this.cuentaBancoBindingSource;
            this.cuentaBancoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cuentaBancoBindingNavigator.CountItemFormat = "de {0}";
            this.cuentaBancoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cuentaBancoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem,
            this.cuentaBancoBindingNavigatorSaveItem,
            this.toolStripSeparator1,
            this.btnSalir});
            this.cuentaBancoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cuentaBancoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cuentaBancoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cuentaBancoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cuentaBancoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cuentaBancoBindingNavigator.Name = "cuentaBancoBindingNavigator";
            this.cuentaBancoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cuentaBancoBindingNavigator.Size = new System.Drawing.Size(634, 25);
            this.cuentaBancoBindingNavigator.TabIndex = 0;
            this.cuentaBancoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(102, 22);
            this.bindingNavigatorAddNewItem.Text = "Nueva Cuenta";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // cuentaBancoBindingSource
            // 
            this.cuentaBancoBindingSource.DataMember = "CuentaBanco";
            this.cuentaBancoBindingSource.DataSource = this.dbSAICBPOTesoreriaDataSet;
            // 
            // dbSAICBPOTesoreriaDataSet
            // 
            this.dbSAICBPOTesoreriaDataSet.DataSetName = "dbSAICBPOTesoreriaDataSet";
            this.dbSAICBPOTesoreriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.bindingNavigatorMoveFirstItem.Text = "Primer Cuenta";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Cuenta anterior";
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
            this.bindingNavigatorMoveNextItem.Text = "Siguiente Cuenta";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Ultima Cuenta";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // cuentaBancoBindingNavigatorSaveItem
            // 
            this.cuentaBancoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cuentaBancoBindingNavigatorSaveItem.Image")));
            this.cuentaBancoBindingNavigatorSaveItem.Name = "cuentaBancoBindingNavigatorSaveItem";
            this.cuentaBancoBindingNavigatorSaveItem.Size = new System.Drawing.Size(110, 22);
            this.cuentaBancoBindingNavigatorSaveItem.Text = "Guardar Cuenta";
            this.cuentaBancoBindingNavigatorSaveItem.Click += new System.EventHandler(this.cuentaBancoBindingNavigatorSaveItem_Click);
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
            // idCuentaBancoLabel1
            // 
            this.idCuentaBancoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cuentaBancoBindingSource, "IdCuentaBanco", true));
            this.idCuentaBancoLabel1.Location = new System.Drawing.Point(147, 46);
            this.idCuentaBancoLabel1.Name = "idCuentaBancoLabel1";
            this.idCuentaBancoLabel1.Size = new System.Drawing.Size(121, 23);
            this.idCuentaBancoLabel1.TabIndex = 2;
            this.idCuentaBancoLabel1.Text = "label1";
            // 
            // noSucursalTextEdit
            // 
            this.noSucursalTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cuentaBancoBindingSource, "NoSucursal", true));
            this.noSucursalTextEdit.Location = new System.Drawing.Point(399, 176);
            this.noSucursalTextEdit.Name = "noSucursalTextEdit";
            this.noSucursalTextEdit.Size = new System.Drawing.Size(150, 20);
            this.noSucursalTextEdit.TabIndex = 14;
            // 
            // nombreContactoTextEdit
            // 
            this.nombreContactoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cuentaBancoBindingSource, "NombreContacto", true));
            this.nombreContactoTextEdit.Location = new System.Drawing.Point(147, 280);
            this.nombreContactoTextEdit.Name = "nombreContactoTextEdit";
            this.nombreContactoTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nombreContactoTextEdit.Size = new System.Drawing.Size(471, 20);
            this.nombreContactoTextEdit.TabIndex = 24;
            // 
            // telefono1TextEdit
            // 
            this.telefono1TextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cuentaBancoBindingSource, "Telefono1", true));
            this.telefono1TextEdit.Location = new System.Drawing.Point(147, 306);
            this.telefono1TextEdit.Name = "telefono1TextEdit";
            this.telefono1TextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.telefono1TextEdit.Size = new System.Drawing.Size(150, 20);
            this.telefono1TextEdit.TabIndex = 26;
            // 
            // telefono2TextEdit
            // 
            this.telefono2TextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cuentaBancoBindingSource, "Telefono2", true));
            this.telefono2TextEdit.Location = new System.Drawing.Point(399, 306);
            this.telefono2TextEdit.Name = "telefono2TextEdit";
            this.telefono2TextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.telefono2TextEdit.Size = new System.Drawing.Size(150, 20);
            this.telefono2TextEdit.TabIndex = 28;
            // 
            // correoElectronicoTextEdit
            // 
            this.correoElectronicoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cuentaBancoBindingSource, "CorreoElectronico", true));
            this.correoElectronicoTextEdit.Location = new System.Drawing.Point(147, 332);
            this.correoElectronicoTextEdit.Name = "correoElectronicoTextEdit";
            this.correoElectronicoTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.correoElectronicoTextEdit.Size = new System.Drawing.Size(471, 20);
            this.correoElectronicoTextEdit.TabIndex = 30;
            // 
            // cuentaContableTextEdit
            // 
            this.cuentaContableTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cuentaBancoBindingSource, "CuentaContable", true));
            this.cuentaContableTextEdit.Location = new System.Drawing.Point(147, 416);
            this.cuentaContableTextEdit.Name = "cuentaContableTextEdit";
            this.cuentaContableTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cuentaContableTextEdit.Size = new System.Drawing.Size(150, 20);
            this.cuentaContableTextEdit.TabIndex = 34;
            // 
            // aplicaOperacionesCheckEdit
            // 
            this.aplicaOperacionesCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cuentaBancoBindingSource, "AplicaOperaciones", true));
            this.aplicaOperacionesCheckEdit.Location = new System.Drawing.Point(147, 442);
            this.aplicaOperacionesCheckEdit.Name = "aplicaOperacionesCheckEdit";
            this.aplicaOperacionesCheckEdit.Properties.Caption = "Visualizar a Operaciones";
            this.aplicaOperacionesCheckEdit.Size = new System.Drawing.Size(150, 19);
            this.aplicaOperacionesCheckEdit.TabIndex = 36;
            // 
            // cboClasifCuentaBanco
            // 
            this.cboClasifCuentaBanco.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cuentaBancoBindingSource, "IdClasifCuentaBanco", true));
            this.cboClasifCuentaBanco.EditValue = "[Seleccione un valor]";
            this.cboClasifCuentaBanco.Location = new System.Drawing.Point(147, 99);
            this.cboClasifCuentaBanco.Name = "cboClasifCuentaBanco";
            this.cboClasifCuentaBanco.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cboClasifCuentaBanco.Properties.Appearance.Options.UseBackColor = true;
            this.cboClasifCuentaBanco.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboClasifCuentaBanco.Properties.DataSource = this.stpSelClasifCuentaBancoBindingSource;
            this.cboClasifCuentaBanco.Properties.DisplayMember = "DescClasifCuentaBanco";
            this.cboClasifCuentaBanco.Properties.ValueMember = "IdClasifCuentaBanco";
            this.cboClasifCuentaBanco.Properties.View = this.idClasifCuentaBancoGridLookUpEditView;
            this.cboClasifCuentaBanco.Size = new System.Drawing.Size(150, 20);
            this.cboClasifCuentaBanco.TabIndex = 6;
            // 
            // stpSelClasifCuentaBancoBindingSource
            // 
            this.stpSelClasifCuentaBancoBindingSource.DataMember = "stpSelClasifCuentaBanco";
            this.stpSelClasifCuentaBancoBindingSource.DataSource = this.dbSAICBPOCatalogosDataSet;
            // 
            // dbSAICBPOCatalogosDataSet
            // 
            this.dbSAICBPOCatalogosDataSet.DataSetName = "dbSAICBPOCatalogosDataSet";
            this.dbSAICBPOCatalogosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idClasifCuentaBancoGridLookUpEditView
            // 
            this.idClasifCuentaBancoGridLookUpEditView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdClasifCuentaBanco,
            this.colDescClasifCuentaBanco});
            this.idClasifCuentaBancoGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.idClasifCuentaBancoGridLookUpEditView.Name = "idClasifCuentaBancoGridLookUpEditView";
            this.idClasifCuentaBancoGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.idClasifCuentaBancoGridLookUpEditView.OptionsView.ShowGroupPanel = false;
            // 
            // colIdClasifCuentaBanco
            // 
            this.colIdClasifCuentaBanco.FieldName = "IdClasifCuentaBanco";
            this.colIdClasifCuentaBanco.Name = "colIdClasifCuentaBanco";
            // 
            // colDescClasifCuentaBanco
            // 
            this.colDescClasifCuentaBanco.Caption = "Clasificación Cuenta";
            this.colDescClasifCuentaBanco.FieldName = "DescClasifCuentaBanco";
            this.colDescClasifCuentaBanco.Name = "colDescClasifCuentaBanco";
            this.colDescClasifCuentaBanco.OptionsColumn.AllowEdit = false;
            this.colDescClasifCuentaBanco.OptionsColumn.FixedWidth = true;
            this.colDescClasifCuentaBanco.Visible = true;
            this.colDescClasifCuentaBanco.VisibleIndex = 0;
            this.colDescClasifCuentaBanco.Width = 150;
            // 
            // nombreCuentaBancoTextEdit
            // 
            this.nombreCuentaBancoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cuentaBancoBindingSource, "NombreCuentaBanco", true));
            this.nombreCuentaBancoTextEdit.Location = new System.Drawing.Point(147, 125);
            this.nombreCuentaBancoTextEdit.Name = "nombreCuentaBancoTextEdit";
            this.nombreCuentaBancoTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.nombreCuentaBancoTextEdit.Properties.Appearance.Options.UseBackColor = true;
            this.nombreCuentaBancoTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nombreCuentaBancoTextEdit.Properties.MaxLength = 100;
            this.nombreCuentaBancoTextEdit.Size = new System.Drawing.Size(471, 20);
            this.nombreCuentaBancoTextEdit.TabIndex = 8;
            // 
            // cboBanco
            // 
            this.cboBanco.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cuentaBancoBindingSource, "IdBanco", true));
            this.cboBanco.Location = new System.Drawing.Point(147, 150);
            this.cboBanco.Name = "cboBanco";
            this.cboBanco.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cboBanco.Properties.Appearance.Options.UseBackColor = true;
            this.cboBanco.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboBanco.Properties.DataSource = this.stpSelBancoTodosBindingSource;
            this.cboBanco.Properties.DisplayMember = "NombreBanco";
            this.cboBanco.Properties.ValueMember = "IdBanco";
            this.cboBanco.Properties.View = this.idBancoGridLookUpEditView;
            this.cboBanco.Size = new System.Drawing.Size(150, 20);
            this.cboBanco.TabIndex = 10;
            // 
            // stpSelBancoTodosBindingSource
            // 
            this.stpSelBancoTodosBindingSource.DataMember = "stpSelBancoTodos";
            this.stpSelBancoTodosBindingSource.DataSource = this.dbSAICBPOCatalogosDataSet;
            // 
            // idBancoGridLookUpEditView
            // 
            this.idBancoGridLookUpEditView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdBanco,
            this.colNombreBanco});
            this.idBancoGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.idBancoGridLookUpEditView.Name = "idBancoGridLookUpEditView";
            this.idBancoGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.idBancoGridLookUpEditView.OptionsView.ShowGroupPanel = false;
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
            this.colNombreBanco.OptionsColumn.AllowEdit = false;
            this.colNombreBanco.Visible = true;
            this.colNombreBanco.VisibleIndex = 0;
            // 
            // noCuentaTextEdit
            // 
            this.noCuentaTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cuentaBancoBindingSource, "NoCuenta", true));
            this.noCuentaTextEdit.Location = new System.Drawing.Point(147, 176);
            this.noCuentaTextEdit.Name = "noCuentaTextEdit";
            this.noCuentaTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.noCuentaTextEdit.Properties.Appearance.Options.UseBackColor = true;
            this.noCuentaTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.noCuentaTextEdit.Properties.MaxLength = 30;
            this.noCuentaTextEdit.Size = new System.Drawing.Size(150, 20);
            this.noCuentaTextEdit.TabIndex = 12;
            // 
            // noClienteTextEdit
            // 
            this.noClienteTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cuentaBancoBindingSource, "NoCliente", true));
            this.noClienteTextEdit.Location = new System.Drawing.Point(147, 202);
            this.noClienteTextEdit.Name = "noClienteTextEdit";
            this.noClienteTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.noClienteTextEdit.Properties.Appearance.Options.UseBackColor = true;
            this.noClienteTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.noClienteTextEdit.Properties.MaxLength = 20;
            this.noClienteTextEdit.Size = new System.Drawing.Size(150, 20);
            this.noClienteTextEdit.TabIndex = 16;
            // 
            // noCLABETextEdit
            // 
            this.noCLABETextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cuentaBancoBindingSource, "NoCLABE", true));
            this.noCLABETextEdit.Location = new System.Drawing.Point(399, 202);
            this.noCLABETextEdit.Name = "noCLABETextEdit";
            this.noCLABETextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.noCLABETextEdit.Properties.Appearance.Options.UseBackColor = true;
            this.noCLABETextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.noCLABETextEdit.Properties.MaxLength = 20;
            this.noCLABETextEdit.Size = new System.Drawing.Size(150, 20);
            this.noCLABETextEdit.TabIndex = 18;
            // 
            // saldoInicialSpinEdit
            // 
            this.saldoInicialSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cuentaBancoBindingSource, "SaldoInicial", true));
            this.saldoInicialSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.saldoInicialSpinEdit.Location = new System.Drawing.Point(147, 228);
            this.saldoInicialSpinEdit.Name = "saldoInicialSpinEdit";
            this.saldoInicialSpinEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.saldoInicialSpinEdit.Properties.Appearance.Options.UseBackColor = true;
            this.saldoInicialSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.saldoInicialSpinEdit.Properties.DisplayFormat.FormatString = "C2";
            this.saldoInicialSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.saldoInicialSpinEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.saldoInicialSpinEdit.Size = new System.Drawing.Size(121, 20);
            this.saldoInicialSpinEdit.TabIndex = 20;
            // 
            // cboMoneda
            // 
            this.cboMoneda.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cuentaBancoBindingSource, "IdMoneda", true));
            this.cboMoneda.Location = new System.Drawing.Point(147, 254);
            this.cboMoneda.Name = "cboMoneda";
            this.cboMoneda.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cboMoneda.Properties.Appearance.Options.UseBackColor = true;
            this.cboMoneda.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboMoneda.Properties.DataSource = this.stpSelMonedaBindingSource;
            this.cboMoneda.Properties.DisplayMember = "DescMoneda";
            this.cboMoneda.Properties.ValueMember = "IdMoneda";
            this.cboMoneda.Properties.View = this.idMonedaGridLookUpEditView;
            this.cboMoneda.Size = new System.Drawing.Size(150, 20);
            this.cboMoneda.TabIndex = 22;
            // 
            // stpSelMonedaBindingSource
            // 
            this.stpSelMonedaBindingSource.DataMember = "stpSelMoneda";
            this.stpSelMonedaBindingSource.DataSource = this.dbSAICBPOCatalogosDataSet;
            // 
            // idMonedaGridLookUpEditView
            // 
            this.idMonedaGridLookUpEditView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdMoneda,
            this.colDescMoneda});
            this.idMonedaGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.idMonedaGridLookUpEditView.Name = "idMonedaGridLookUpEditView";
            this.idMonedaGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.idMonedaGridLookUpEditView.OptionsView.ShowGroupPanel = false;
            // 
            // colIdMoneda
            // 
            this.colIdMoneda.Caption = "Clave Moneda";
            this.colIdMoneda.FieldName = "IdMoneda";
            this.colIdMoneda.Name = "colIdMoneda";
            this.colIdMoneda.OptionsColumn.AllowEdit = false;
            this.colIdMoneda.Visible = true;
            this.colIdMoneda.VisibleIndex = 0;
            // 
            // colDescMoneda
            // 
            this.colDescMoneda.Caption = "Moneda";
            this.colDescMoneda.FieldName = "DescMoneda";
            this.colDescMoneda.Name = "colDescMoneda";
            this.colDescMoneda.OptionsColumn.AllowEdit = false;
            this.colDescMoneda.Visible = true;
            this.colDescMoneda.VisibleIndex = 1;
            // 
            // observacionesTextEdit
            // 
            this.observacionesTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cuentaBancoBindingSource, "Observaciones", true));
            this.observacionesTextEdit.Location = new System.Drawing.Point(147, 358);
            this.observacionesTextEdit.Name = "observacionesTextEdit";
            this.observacionesTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.observacionesTextEdit.Properties.MaxLength = 255;
            this.observacionesTextEdit.Size = new System.Drawing.Size(471, 52);
            this.observacionesTextEdit.TabIndex = 32;
            // 
            // cboIdMatrizTenedora
            // 
            this.cboIdMatrizTenedora.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cuentaBancoBindingSource, "IdMatrizTenedora", true));
            this.cboIdMatrizTenedora.EditValue = "Seleccione un valor";
            this.cboIdMatrizTenedora.Location = new System.Drawing.Point(147, 73);
            this.cboIdMatrizTenedora.Name = "cboIdMatrizTenedora";
            this.cboIdMatrizTenedora.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cboIdMatrizTenedora.Properties.Appearance.Options.UseBackColor = true;
            this.cboIdMatrizTenedora.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboIdMatrizTenedora.Properties.DataSource = this.stpSelMatrizTenedoraCuentaBancoBindingSource;
            this.cboIdMatrizTenedora.Properties.DisplayMember = "RazonSocial";
            this.cboIdMatrizTenedora.Properties.ValueMember = "IdMatrizTenedora";
            this.cboIdMatrizTenedora.Properties.View = this.gridLookUpEdit1View;
            this.cboIdMatrizTenedora.Size = new System.Drawing.Size(471, 20);
            this.cboIdMatrizTenedora.TabIndex = 4;
            // 
            // stpSelMatrizTenedoraCuentaBancoBindingSource
            // 
            this.stpSelMatrizTenedoraCuentaBancoBindingSource.DataMember = "stpSelMatrizTenedoraCuentaBanco";
            this.stpSelMatrizTenedoraCuentaBancoBindingSource.DataSource = this.dbSAICBPOCatalogosDataSet;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRazonSocial});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colRazonSocial
            // 
            this.colRazonSocial.Caption = "Razón Social";
            this.colRazonSocial.FieldName = "RazonSocial";
            this.colRazonSocial.Name = "colRazonSocial";
            this.colRazonSocial.OptionsColumn.AllowEdit = false;
            this.colRazonSocial.OptionsColumn.AllowMove = false;
            this.colRazonSocial.OptionsColumn.AllowShowHide = false;
            this.colRazonSocial.OptionsColumn.FixedWidth = true;
            this.colRazonSocial.Visible = true;
            this.colRazonSocial.VisibleIndex = 0;
            this.colRazonSocial.Width = 500;
            // 
            // stpSelClasifCuentaBancoTableAdapter
            // 
            this.stpSelClasifCuentaBancoTableAdapter.ClearBeforeFill = true;
            // 
            // stpSelBancoTodosTableAdapter
            // 
            this.stpSelBancoTodosTableAdapter.ClearBeforeFill = true;
            // 
            // stpSelMonedaTableAdapter
            // 
            this.stpSelMonedaTableAdapter.ClearBeforeFill = true;
            // 
            // stpSelMatrizTenedoraCuentaBancoTableAdapter
            // 
            this.stpSelMatrizTenedoraCuentaBancoTableAdapter.ClearBeforeFill = true;
            // 
            // stpSelEstatusCuentaBancoBindingSource
            // 
            this.stpSelEstatusCuentaBancoBindingSource.DataMember = "stpSelEstatusCuentaBanco";
            this.stpSelEstatusCuentaBancoBindingSource.DataSource = this.dbSAICBPOCatalogosDataSet;
            // 
            // stpSelEstatusCuentaBancoTableAdapter
            // 
            this.stpSelEstatusCuentaBancoTableAdapter.ClearBeforeFill = true;
            // 
            // cuentaBancoTableAdapter
            // 
            this.cuentaBancoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CuentaBancoTableAdapter = this.cuentaBancoTableAdapter;
            this.tableAdapterManager.SolicitudChequeDetailTableAdapter = null;
            this.tableAdapterManager.SolicitudChequeHeaderTableAdapter = null;
            this.tableAdapterManager.TenedoraBancoTableAdapter = null;
            this.tableAdapterManager.TransaccionBancoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = winAppSAIC.Tesoreria.dbSAICBPOTesoreriaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmxAltaCuentaBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 472);
            this.ControlBox = false;
            this.Controls.Add(this.cboIdMatrizTenedora);
            this.Controls.Add(this.observacionesTextEdit);
            this.Controls.Add(this.cboMoneda);
            this.Controls.Add(this.saldoInicialSpinEdit);
            this.Controls.Add(this.noCLABETextEdit);
            this.Controls.Add(this.noClienteTextEdit);
            this.Controls.Add(this.noCuentaTextEdit);
            this.Controls.Add(this.cboBanco);
            this.Controls.Add(this.nombreCuentaBancoTextEdit);
            this.Controls.Add(this.cboClasifCuentaBanco);
            this.Controls.Add(idCuentaBancoLabel);
            this.Controls.Add(this.idCuentaBancoLabel1);
            this.Controls.Add(idMatrizTenedoraLabel);
            this.Controls.Add(idClasifCuentaBancoLabel);
            this.Controls.Add(nombreCuentaBancoLabel);
            this.Controls.Add(idBancoLabel);
            this.Controls.Add(noCuentaLabel);
            this.Controls.Add(noSucursalLabel);
            this.Controls.Add(this.noSucursalTextEdit);
            this.Controls.Add(noClienteLabel);
            this.Controls.Add(noCLABELabel);
            this.Controls.Add(saldoInicialLabel);
            this.Controls.Add(idMonedaLabel);
            this.Controls.Add(nombreContactoLabel);
            this.Controls.Add(this.nombreContactoTextEdit);
            this.Controls.Add(telefono1Label);
            this.Controls.Add(this.telefono1TextEdit);
            this.Controls.Add(telefono2Label);
            this.Controls.Add(this.telefono2TextEdit);
            this.Controls.Add(correoElectronicoLabel);
            this.Controls.Add(this.correoElectronicoTextEdit);
            this.Controls.Add(observacionesLabel);
            this.Controls.Add(cuentaContableLabel);
            this.Controls.Add(this.cuentaContableTextEdit);
            this.Controls.Add(this.aplicaOperacionesCheckEdit);
            this.Controls.Add(this.cuentaBancoBindingNavigator);
            this.Name = "frmxAltaCuentaBanco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Cuenta de Banco";
            this.Load += new System.EventHandler(this.frmxAltaCuentaBanco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cuentaBancoBindingNavigator)).EndInit();
            this.cuentaBancoBindingNavigator.ResumeLayout(false);
            this.cuentaBancoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cuentaBancoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOTesoreriaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noSucursalTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nombreContactoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefono1TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefono2TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.correoElectronicoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuentaContableTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aplicaOperacionesCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboClasifCuentaBanco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelClasifCuentaBancoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idClasifCuentaBancoGridLookUpEditView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nombreCuentaBancoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboBanco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelBancoTodosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idBancoGridLookUpEditView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noCuentaTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noClienteTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noCLABETextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saldoInicialSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMoneda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelMonedaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idMonedaGridLookUpEditView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.observacionesTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboIdMatrizTenedora.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelMatrizTenedoraCuentaBancoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelEstatusCuentaBancoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dbSAICBPOTesoreriaDataSet dbSAICBPOTesoreriaDataSet;
        private System.Windows.Forms.BindingSource cuentaBancoBindingSource;
        private dbSAICBPOTesoreriaDataSetTableAdapters.CuentaBancoTableAdapter cuentaBancoTableAdapter;
        private dbSAICBPOTesoreriaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cuentaBancoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cuentaBancoBindingNavigatorSaveItem;
        private System.Windows.Forms.Label idCuentaBancoLabel1;
        private DevExpress.XtraEditors.TextEdit noSucursalTextEdit;
        private DevExpress.XtraEditors.TextEdit nombreContactoTextEdit;
        private DevExpress.XtraEditors.TextEdit telefono1TextEdit;
        private DevExpress.XtraEditors.TextEdit telefono2TextEdit;
        private DevExpress.XtraEditors.TextEdit correoElectronicoTextEdit;
        private DevExpress.XtraEditors.TextEdit cuentaContableTextEdit;
        private DevExpress.XtraEditors.CheckEdit aplicaOperacionesCheckEdit;
        private DevExpress.XtraEditors.GridLookUpEdit cboClasifCuentaBanco;
        private DevExpress.XtraGrid.Views.Grid.GridView idClasifCuentaBancoGridLookUpEditView;
        private DevExpress.XtraGrid.Columns.GridColumn colIdClasifCuentaBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colDescClasifCuentaBanco;
        private dbSAICBPOCatalogosDataSet dbSAICBPOCatalogosDataSet;
        private System.Windows.Forms.BindingSource stpSelClasifCuentaBancoBindingSource;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelClasifCuentaBancoTableAdapter stpSelClasifCuentaBancoTableAdapter;
        private DevExpress.XtraEditors.TextEdit nombreCuentaBancoTextEdit;
        private DevExpress.XtraEditors.GridLookUpEdit cboBanco;
        private DevExpress.XtraGrid.Views.Grid.GridView idBancoGridLookUpEditView;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreBanco;
        private System.Windows.Forms.BindingSource stpSelBancoTodosBindingSource;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelBancoTodosTableAdapter stpSelBancoTodosTableAdapter;
        private DevExpress.XtraEditors.TextEdit noCuentaTextEdit;
        private DevExpress.XtraEditors.TextEdit noClienteTextEdit;
        private DevExpress.XtraEditors.TextEdit noCLABETextEdit;
        private DevExpress.XtraEditors.SpinEdit saldoInicialSpinEdit;
        private DevExpress.XtraEditors.GridLookUpEdit cboMoneda;
        private DevExpress.XtraGrid.Views.Grid.GridView idMonedaGridLookUpEditView;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMoneda;
        private DevExpress.XtraGrid.Columns.GridColumn colDescMoneda;
        private System.Windows.Forms.BindingSource stpSelMonedaBindingSource;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelMonedaTableAdapter stpSelMonedaTableAdapter;
        private DevExpress.XtraEditors.MemoEdit observacionesTextEdit;
        private System.Windows.Forms.BindingSource stpSelMatrizTenedoraCuentaBancoBindingSource;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelMatrizTenedoraCuentaBancoTableAdapter stpSelMatrizTenedoraCuentaBancoTableAdapter;
        private DevExpress.XtraEditors.GridLookUpEdit cboIdMatrizTenedora;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colRazonSocial;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.BindingSource stpSelEstatusCuentaBancoBindingSource;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelEstatusCuentaBancoTableAdapter stpSelEstatusCuentaBancoTableAdapter;
    }
}