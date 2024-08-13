namespace winAppSAIC.Tesoreria
{
    partial class frmxControlTransaccionBanco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmxControlTransaccionBanco));
            this.cboClienteProveedor = new DevExpress.XtraEditors.GridLookUpEdit();
            this.stpSelClienteProveedorChequesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPOTesoreriaDataSet = new winAppSAIC.Tesoreria.dbSAICBPOTesoreriaDataSet();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRazonSocial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreComercial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblClienteProveedor = new DevExpress.XtraEditors.LabelControl();
            this.chkUtilizarFolioLoteNomina = new System.Windows.Forms.CheckBox();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.txtObservaciones = new DevExpress.XtraEditors.MemoEdit();
            this.cboFolioLoteCargaNomina = new DevExpress.XtraEditors.GridLookUpEdit();
            this.stpSelFolioLoteCargaNominaParaChequesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idLoteCargaNominaGridLookUpEditView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdLoteCargaNomina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFolioLoteCargaNomina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenedora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOperador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblFolio = new DevExpress.XtraEditors.LabelControl();
            this.lblFolioMovimiento = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.cboSubCategoriaTransaccionBanco = new DevExpress.XtraEditors.GridLookUpEdit();
            this.stpSelSubCategoriaTransaccionBancoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPOCatalogosDataSet = new winAppSAIC.dbSAICBPOCatalogosDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdSubCategoriaTransaccionBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescSubCategoriaTransaccionBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboCategoriaTransaccionBanco = new DevExpress.XtraEditors.GridLookUpEdit();
            this.stpSelCategoriaTransaccionBancoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCategoriaTransaccionBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescCategoriaTransaccionBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblMoneda = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtBeneficiarioCheque = new DevExpress.XtraEditors.TextEdit();
            this.txtImporte = new DevExpress.XtraEditors.SpinEdit();
            this.txtNoCheque = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.cboCuentaBanco = new DevExpress.XtraEditors.GridLookUpEdit();
            this.stpSelCuentaBancoTransaccionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNombreCuentaBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoCuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCuentaBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMoneda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboFecha = new DevExpress.XtraEditors.DateEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtOtroConcepto = new DevExpress.XtraEditors.MemoEdit();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.btnEditarCheque = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelarCheque = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardarCheque = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelarCaptura = new DevExpress.XtraEditors.SimpleButton();
            this.btnBuscarCheque = new DevExpress.XtraEditors.SimpleButton();
            this.btnNuevoCheque = new DevExpress.XtraEditors.SimpleButton();
            this.lblACuentaBanco = new DevExpress.XtraEditors.LabelControl();
            this.cboACuentaBanco = new DevExpress.XtraEditors.GridLookUpEdit();
            this.stpSelCuentaBancoPorBancoFiltradoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.cboTipoTransaccion = new DevExpress.XtraEditors.GridLookUpEdit();
            this.stpSelCodigoTransaccionBancoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCodigoTransaccionBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescCodigoTransaccionBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chkChequeConciliado = new System.Windows.Forms.CheckBox();
            this.chkCancelado = new System.Windows.Forms.CheckBox();
            this.stpSelCategoriaTransaccionBancoTableAdapter = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelCategoriaTransaccionBancoTableAdapter();
            this.stpSelSubCategoriaTransaccionBancoTableAdapter = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelSubCategoriaTransaccionBancoTableAdapter();
            this.actualizacionesTesoreriaTableAdapter1 = new winAppSAIC.Tesoreria.dbSAICBPOActualizacionesTesoreriaDataSetTableAdapters.ActualizacionesTesoreriaTableAdapter();
            this.dbSAICBPOTesoreriaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stpSelClienteProveedorChequesTableAdapter = new winAppSAIC.Tesoreria.dbSAICBPOTesoreriaDataSetTableAdapters.stpSelClienteProveedorChequesTableAdapter();
            this.stpSelCodigoTransaccionBancoTableAdapter = new winAppSAIC.Tesoreria.dbSAICBPOTesoreriaDataSetTableAdapters.stpSelCodigoTransaccionBancoTableAdapter();
            this.stpSelCuentaBancoPorBancoFiltradoTableAdapter = new winAppSAIC.Tesoreria.dbSAICBPOTesoreriaDataSetTableAdapters.stpSelCuentaBancoPorBancoFiltradoTableAdapter();
            this.stpSelFolioLoteCargaNominaParaChequesTableAdapter = new winAppSAIC.Tesoreria.dbSAICBPOTesoreriaDataSetTableAdapters.stpSelFolioLoteCargaNominaParaChequesTableAdapter();
            this.stpSelInfoCuentaBancoTableAdapter1 = new winAppSAIC.Tesoreria.dbSAICBPOTesoreriaDataSetTableAdapters.stpSelInfoCuentaBancoTableAdapter();
            this.stpSelCuentaBancoTransaccionTableAdapter = new winAppSAIC.Tesoreria.dbSAICBPOTesoreriaDataSetTableAdapters.stpSelCuentaBancoTransaccionTableAdapter();
            this.txtTipoCambio = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.cboClienteProveedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelClienteProveedorChequesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOTesoreriaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservaciones.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFolioLoteCargaNomina.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelFolioLoteCargaNominaParaChequesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idLoteCargaNominaGridLookUpEditView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSubCategoriaTransaccionBanco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelSubCategoriaTransaccionBancoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCategoriaTransaccionBanco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelCategoriaTransaccionBancoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBeneficiarioCheque.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImporte.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoCheque.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCuentaBanco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelCuentaBancoTransaccionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFecha.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOtroConcepto.Properties)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboACuentaBanco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelCuentaBancoPorBancoFiltradoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTipoTransaccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelCodigoTransaccionBancoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOTesoreriaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoCambio.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cboClienteProveedor
            // 
            this.cboClienteProveedor.EditValue = "";
            this.cboClienteProveedor.Location = new System.Drawing.Point(134, 168);
            this.cboClienteProveedor.Name = "cboClienteProveedor";
            this.cboClienteProveedor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboClienteProveedor.Properties.DataSource = this.stpSelClienteProveedorChequesBindingSource;
            this.cboClienteProveedor.Properties.DisplayMember = "NombreComercial";
            this.cboClienteProveedor.Properties.ValueMember = "IdCliente";
            this.cboClienteProveedor.Properties.View = this.gridView2;
            this.cboClienteProveedor.Size = new System.Drawing.Size(409, 20);
            this.cboClienteProveedor.TabIndex = 14;
            this.cboClienteProveedor.Tag = "Cliente/Proveedor";
            this.cboClienteProveedor.EditValueChanged += new System.EventHandler(this.cboClienteProveedor_EditValueChanged);
            // 
            // stpSelClienteProveedorChequesBindingSource
            // 
            this.stpSelClienteProveedorChequesBindingSource.DataMember = "stpSelClienteProveedorCheques";
            this.stpSelClienteProveedorChequesBindingSource.DataSource = this.dbSAICBPOTesoreriaDataSet;
            // 
            // dbSAICBPOTesoreriaDataSet
            // 
            this.dbSAICBPOTesoreriaDataSet.DataSetName = "dbSAICBPOTesoreriaDataSet";
            this.dbSAICBPOTesoreriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCliente,
            this.colRazonSocial,
            this.colNombreComercial});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colIdCliente
            // 
            this.colIdCliente.FieldName = "IdCliente";
            this.colIdCliente.Name = "colIdCliente";
            this.colIdCliente.OptionsColumn.ReadOnly = true;
            // 
            // colRazonSocial
            // 
            this.colRazonSocial.Caption = "Razón Social";
            this.colRazonSocial.FieldName = "RazonSocial";
            this.colRazonSocial.Name = "colRazonSocial";
            this.colRazonSocial.OptionsColumn.AllowEdit = false;
            this.colRazonSocial.OptionsColumn.ReadOnly = true;
            this.colRazonSocial.Visible = true;
            this.colRazonSocial.VisibleIndex = 0;
            // 
            // colNombreComercial
            // 
            this.colNombreComercial.FieldName = "NombreComercial";
            this.colNombreComercial.Name = "colNombreComercial";
            this.colNombreComercial.OptionsColumn.AllowEdit = false;
            this.colNombreComercial.OptionsColumn.ReadOnly = true;
            this.colNombreComercial.Visible = true;
            this.colNombreComercial.VisibleIndex = 1;
            // 
            // lblClienteProveedor
            // 
            this.lblClienteProveedor.Location = new System.Drawing.Point(12, 172);
            this.lblClienteProveedor.Name = "lblClienteProveedor";
            this.lblClienteProveedor.Size = new System.Drawing.Size(87, 13);
            this.lblClienteProveedor.TabIndex = 13;
            this.lblClienteProveedor.Text = "Cliente/Proveedor";
            // 
            // chkUtilizarFolioLoteNomina
            // 
            this.chkUtilizarFolioLoteNomina.AutoSize = true;
            this.chkUtilizarFolioLoteNomina.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUtilizarFolioLoteNomina.ForeColor = System.Drawing.Color.Blue;
            this.chkUtilizarFolioLoteNomina.Location = new System.Drawing.Point(390, 196);
            this.chkUtilizarFolioLoteNomina.Name = "chkUtilizarFolioLoteNomina";
            this.chkUtilizarFolioLoteNomina.Size = new System.Drawing.Size(120, 17);
            this.chkUtilizarFolioLoteNomina.TabIndex = 17;
            this.chkUtilizarFolioLoteNomina.Text = "Utilizar Lote Nómina";
            this.chkUtilizarFolioLoteNomina.UseVisualStyleBackColor = true;
            this.chkUtilizarFolioLoteNomina.CheckedChanged += new System.EventHandler(this.chkUtilizarFolioLoteNomina_CheckedChanged);
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(12, 433);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(71, 13);
            this.labelControl13.TabIndex = 33;
            this.labelControl13.Text = "Observaciones";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(134, 430);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservaciones.Size = new System.Drawing.Size(409, 50);
            this.txtObservaciones.TabIndex = 34;
            this.txtObservaciones.Tag = "Observaciones";
            this.txtObservaciones.UseOptimizedRendering = true;
            // 
            // cboFolioLoteCargaNomina
            // 
            this.cboFolioLoteCargaNomina.EditValue = "";
            this.cboFolioLoteCargaNomina.Location = new System.Drawing.Point(134, 194);
            this.cboFolioLoteCargaNomina.Name = "cboFolioLoteCargaNomina";
            this.cboFolioLoteCargaNomina.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
            this.cboFolioLoteCargaNomina.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboFolioLoteCargaNomina.Properties.DataSource = this.stpSelFolioLoteCargaNominaParaChequesBindingSource;
            this.cboFolioLoteCargaNomina.Properties.DisplayMember = "FolioLoteCargaNomina";
            this.cboFolioLoteCargaNomina.Properties.ValueMember = "IdLoteCargaNomina";
            this.cboFolioLoteCargaNomina.Properties.View = this.idLoteCargaNominaGridLookUpEditView;
            this.cboFolioLoteCargaNomina.Size = new System.Drawing.Size(250, 20);
            this.cboFolioLoteCargaNomina.TabIndex = 16;
            this.cboFolioLoteCargaNomina.EditValueChanged += new System.EventHandler(this.cboFolioLoteCargaNomina_EditValueChanged);
            // 
            // stpSelFolioLoteCargaNominaParaChequesBindingSource
            // 
            this.stpSelFolioLoteCargaNominaParaChequesBindingSource.DataMember = "stpSelFolioLoteCargaNominaParaCheques";
            this.stpSelFolioLoteCargaNominaParaChequesBindingSource.DataSource = this.dbSAICBPOTesoreriaDataSet;
            // 
            // idLoteCargaNominaGridLookUpEditView
            // 
            this.idLoteCargaNominaGridLookUpEditView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdLoteCargaNomina,
            this.colFolioLoteCargaNomina,
            this.colTenedora,
            this.colCliente,
            this.colOperador});
            this.idLoteCargaNominaGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.idLoteCargaNominaGridLookUpEditView.Name = "idLoteCargaNominaGridLookUpEditView";
            this.idLoteCargaNominaGridLookUpEditView.OptionsCustomization.AllowGroup = false;
            this.idLoteCargaNominaGridLookUpEditView.OptionsCustomization.AllowQuickHideColumns = false;
            this.idLoteCargaNominaGridLookUpEditView.OptionsCustomization.AllowSort = false;
            this.idLoteCargaNominaGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.idLoteCargaNominaGridLookUpEditView.OptionsView.ShowAutoFilterRow = true;
            this.idLoteCargaNominaGridLookUpEditView.OptionsView.ShowGroupPanel = false;
            this.idLoteCargaNominaGridLookUpEditView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colIdLoteCargaNomina, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colIdLoteCargaNomina
            // 
            this.colIdLoteCargaNomina.AppearanceCell.Options.UseTextOptions = true;
            this.colIdLoteCargaNomina.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIdLoteCargaNomina.Caption = "No. Lote";
            this.colIdLoteCargaNomina.FieldName = "IdLoteCargaNomina";
            this.colIdLoteCargaNomina.Name = "colIdLoteCargaNomina";
            this.colIdLoteCargaNomina.OptionsColumn.ReadOnly = true;
            this.colIdLoteCargaNomina.Visible = true;
            this.colIdLoteCargaNomina.VisibleIndex = 0;
            this.colIdLoteCargaNomina.Width = 22;
            // 
            // colFolioLoteCargaNomina
            // 
            this.colFolioLoteCargaNomina.Caption = "Folio Lote Carga Nómina";
            this.colFolioLoteCargaNomina.FieldName = "FolioLoteCargaNomina";
            this.colFolioLoteCargaNomina.Name = "colFolioLoteCargaNomina";
            this.colFolioLoteCargaNomina.Visible = true;
            this.colFolioLoteCargaNomina.VisibleIndex = 1;
            this.colFolioLoteCargaNomina.Width = 41;
            // 
            // colTenedora
            // 
            this.colTenedora.Caption = "Tenedora";
            this.colTenedora.FieldName = "NombreComercialTenedora";
            this.colTenedora.Name = "colTenedora";
            this.colTenedora.Visible = true;
            this.colTenedora.VisibleIndex = 2;
            this.colTenedora.Width = 114;
            // 
            // colCliente
            // 
            this.colCliente.Caption = "Cliente";
            this.colCliente.FieldName = "NombreComercialCliente";
            this.colCliente.Name = "colCliente";
            this.colCliente.Visible = true;
            this.colCliente.VisibleIndex = 3;
            this.colCliente.Width = 173;
            // 
            // colOperador
            // 
            this.colOperador.FieldName = "Operador";
            this.colOperador.Name = "colOperador";
            this.colOperador.Visible = true;
            this.colOperador.VisibleIndex = 4;
            this.colOperador.Width = 150;
            // 
            // lblFolio
            // 
            this.lblFolio.Location = new System.Drawing.Point(12, 197);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(116, 13);
            this.lblFolio.TabIndex = 15;
            this.lblFolio.Text = "Folio Lote Carga Nómina";
            // 
            // lblFolioMovimiento
            // 
            this.lblFolioMovimiento.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblFolioMovimiento.Location = new System.Drawing.Point(134, 44);
            this.lblFolioMovimiento.Name = "lblFolioMovimiento";
            this.lblFolioMovimiento.Size = new System.Drawing.Size(26, 13);
            this.lblFolioMovimiento.TabIndex = 2;
            this.lblFolioMovimiento.Text = "Folio";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(12, 44);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(79, 13);
            this.labelControl11.TabIndex = 1;
            this.labelControl11.Text = "Folio Movimiento";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(12, 350);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(103, 13);
            this.labelControl10.TabIndex = 29;
            this.labelControl10.Text = "SubClasificación Mov.";
            // 
            // cboSubCategoriaTransaccionBanco
            // 
            this.cboSubCategoriaTransaccionBanco.EditValue = "";
            this.cboSubCategoriaTransaccionBanco.Location = new System.Drawing.Point(134, 348);
            this.cboSubCategoriaTransaccionBanco.Name = "cboSubCategoriaTransaccionBanco";
            this.cboSubCategoriaTransaccionBanco.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboSubCategoriaTransaccionBanco.Properties.DataSource = this.stpSelSubCategoriaTransaccionBancoBindingSource;
            this.cboSubCategoriaTransaccionBanco.Properties.DisplayMember = "DescSubCategoriaTransaccionBanco";
            this.cboSubCategoriaTransaccionBanco.Properties.ValueMember = "IdSubCategoriaTransaccionBanco";
            this.cboSubCategoriaTransaccionBanco.Properties.View = this.gridView1;
            this.cboSubCategoriaTransaccionBanco.Size = new System.Drawing.Size(215, 20);
            this.cboSubCategoriaTransaccionBanco.TabIndex = 30;
            this.cboSubCategoriaTransaccionBanco.Tag = "SubClasificación Movimiento";
            // 
            // stpSelSubCategoriaTransaccionBancoBindingSource
            // 
            this.stpSelSubCategoriaTransaccionBancoBindingSource.DataMember = "stpSelSubCategoriaTransaccionBanco";
            this.stpSelSubCategoriaTransaccionBancoBindingSource.DataSource = this.dbSAICBPOCatalogosDataSet;
            // 
            // dbSAICBPOCatalogosDataSet
            // 
            this.dbSAICBPOCatalogosDataSet.DataSetName = "dbSAICBPOCatalogosDataSet";
            this.dbSAICBPOCatalogosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdSubCategoriaTransaccionBanco,
            this.colDescSubCategoriaTransaccionBanco});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIdSubCategoriaTransaccionBanco
            // 
            this.colIdSubCategoriaTransaccionBanco.FieldName = "IdSubCategoriaTransaccionBanco";
            this.colIdSubCategoriaTransaccionBanco.Name = "colIdSubCategoriaTransaccionBanco";
            this.colIdSubCategoriaTransaccionBanco.OptionsColumn.ReadOnly = true;
            // 
            // colDescSubCategoriaTransaccionBanco
            // 
            this.colDescSubCategoriaTransaccionBanco.Caption = "SubClasificación Movimiento";
            this.colDescSubCategoriaTransaccionBanco.FieldName = "DescSubCategoriaTransaccionBanco";
            this.colDescSubCategoriaTransaccionBanco.Name = "colDescSubCategoriaTransaccionBanco";
            this.colDescSubCategoriaTransaccionBanco.OptionsColumn.AllowEdit = false;
            this.colDescSubCategoriaTransaccionBanco.Visible = true;
            this.colDescSubCategoriaTransaccionBanco.VisibleIndex = 0;
            // 
            // cboCategoriaTransaccionBanco
            // 
            this.cboCategoriaTransaccionBanco.EditValue = "";
            this.cboCategoriaTransaccionBanco.Location = new System.Drawing.Point(134, 322);
            this.cboCategoriaTransaccionBanco.Name = "cboCategoriaTransaccionBanco";
            this.cboCategoriaTransaccionBanco.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboCategoriaTransaccionBanco.Properties.DataSource = this.stpSelCategoriaTransaccionBancoBindingSource;
            this.cboCategoriaTransaccionBanco.Properties.DisplayMember = "DescCategoriaTransaccionBanco";
            this.cboCategoriaTransaccionBanco.Properties.ValueMember = "IdCategoriaTransaccionBanco";
            this.cboCategoriaTransaccionBanco.Properties.View = this.gridLookUpEdit1View;
            this.cboCategoriaTransaccionBanco.Size = new System.Drawing.Size(215, 20);
            this.cboCategoriaTransaccionBanco.TabIndex = 28;
            this.cboCategoriaTransaccionBanco.Tag = "Clasificación Movimiento";
            this.cboCategoriaTransaccionBanco.EditValueChanged += new System.EventHandler(this.cboCategoriaTransaccionBanco_EditValueChanged);
            // 
            // stpSelCategoriaTransaccionBancoBindingSource
            // 
            this.stpSelCategoriaTransaccionBancoBindingSource.DataMember = "stpSelCategoriaTransaccionBanco";
            this.stpSelCategoriaTransaccionBancoBindingSource.DataSource = this.dbSAICBPOCatalogosDataSet;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCategoriaTransaccionBanco,
            this.colDescCategoriaTransaccionBanco});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdCategoriaTransaccionBanco
            // 
            this.colIdCategoriaTransaccionBanco.FieldName = "IdCategoriaTransaccionBanco";
            this.colIdCategoriaTransaccionBanco.Name = "colIdCategoriaTransaccionBanco";
            this.colIdCategoriaTransaccionBanco.OptionsColumn.ReadOnly = true;
            // 
            // colDescCategoriaTransaccionBanco
            // 
            this.colDescCategoriaTransaccionBanco.Caption = "Clasificación Movimiento";
            this.colDescCategoriaTransaccionBanco.FieldName = "DescCategoriaTransaccionBanco";
            this.colDescCategoriaTransaccionBanco.Name = "colDescCategoriaTransaccionBanco";
            this.colDescCategoriaTransaccionBanco.OptionsColumn.AllowEdit = false;
            this.colDescCategoriaTransaccionBanco.Visible = true;
            this.colDescCategoriaTransaccionBanco.VisibleIndex = 0;
            // 
            // lblMoneda
            // 
            this.lblMoneda.Location = new System.Drawing.Point(240, 249);
            this.lblMoneda.Name = "lblMoneda";
            this.lblMoneda.Size = new System.Drawing.Size(38, 13);
            this.lblMoneda.TabIndex = 22;
            this.lblMoneda.Text = "Moneda";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(12, 377);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(71, 13);
            this.labelControl9.TabIndex = 31;
            this.labelControl9.Text = "Otro Concepto";
            // 
            // txtBeneficiarioCheque
            // 
            this.txtBeneficiarioCheque.Location = new System.Drawing.Point(134, 296);
            this.txtBeneficiarioCheque.Name = "txtBeneficiarioCheque";
            this.txtBeneficiarioCheque.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBeneficiarioCheque.Size = new System.Drawing.Size(409, 20);
            this.txtBeneficiarioCheque.TabIndex = 26;
            this.txtBeneficiarioCheque.Tag = "Beneficiario Cheque";
            // 
            // txtImporte
            // 
            this.txtImporte.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtImporte.Location = new System.Drawing.Point(134, 245);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtImporte.Properties.DisplayFormat.FormatString = "C2";
            this.txtImporte.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtImporte.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtImporte.Size = new System.Drawing.Size(100, 20);
            this.txtImporte.TabIndex = 21;
            this.txtImporte.Tag = "Importe";
            // 
            // txtNoCheque
            // 
            this.txtNoCheque.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtNoCheque.Location = new System.Drawing.Point(134, 220);
            this.txtNoCheque.Name = "txtNoCheque";
            this.txtNoCheque.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNoCheque.Properties.Mask.EditMask = "n0";
            this.txtNoCheque.Size = new System.Drawing.Size(100, 20);
            this.txtNoCheque.TabIndex = 19;
            this.txtNoCheque.Tag = "No. Transacción";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(12, 120);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(82, 13);
            this.labelControl7.TabIndex = 9;
            this.labelControl7.Text = "Cuenta de Banco";
            // 
            // cboCuentaBanco
            // 
            this.cboCuentaBanco.EditValue = "";
            this.cboCuentaBanco.Location = new System.Drawing.Point(134, 116);
            this.cboCuentaBanco.Name = "cboCuentaBanco";
            this.cboCuentaBanco.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboCuentaBanco.Properties.DataSource = this.stpSelCuentaBancoTransaccionBindingSource;
            this.cboCuentaBanco.Properties.DisplayMember = "NombreCuentaBanco";
            this.cboCuentaBanco.Properties.ValueMember = "IdCuentaBanco";
            this.cboCuentaBanco.Properties.View = this.gridLookUpEdit2View;
            this.cboCuentaBanco.Size = new System.Drawing.Size(250, 20);
            this.cboCuentaBanco.TabIndex = 10;
            this.cboCuentaBanco.Tag = "Cuenta de Banco";
            this.cboCuentaBanco.EditValueChanged += new System.EventHandler(this.cboCuentaBanco_EditValueChanged);
            // 
            // stpSelCuentaBancoTransaccionBindingSource
            // 
            this.stpSelCuentaBancoTransaccionBindingSource.DataMember = "stpSelCuentaBancoTransaccion";
            this.stpSelCuentaBancoTransaccionBindingSource.DataSource = this.dbSAICBPOTesoreriaDataSet;
            // 
            // gridLookUpEdit2View
            // 
            this.gridLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNombreCuentaBanco,
            this.colNoCuenta,
            this.colIdCuentaBanco,
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
            // colIdCuentaBanco
            // 
            this.colIdCuentaBanco.FieldName = "IdCuentaBanco";
            this.colIdCuentaBanco.Name = "colIdCuentaBanco";
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
            // cboFecha
            // 
            this.cboFecha.EditValue = null;
            this.cboFecha.Location = new System.Drawing.Point(134, 64);
            this.cboFecha.Name = "cboFecha";
            this.cboFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboFecha.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboFecha.Properties.CalendarTimeProperties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.cboFecha.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.cboFecha.Size = new System.Drawing.Size(100, 20);
            this.cboFecha.TabIndex = 4;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(12, 325);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(85, 13);
            this.labelControl6.TabIndex = 27;
            this.labelControl6.Text = "Clasificación Mov.";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 299);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(46, 13);
            this.labelControl5.TabIndex = 25;
            this.labelControl5.Text = "Concepto";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 249);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(38, 13);
            this.labelControl4.TabIndex = 20;
            this.labelControl4.Text = "Importe";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 223);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(77, 13);
            this.labelControl3.TabIndex = 18;
            this.labelControl3.Text = "No. Transacción";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 67);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(29, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Fecha";
            // 
            // txtOtroConcepto
            // 
            this.txtOtroConcepto.Location = new System.Drawing.Point(134, 374);
            this.txtOtroConcepto.Name = "txtOtroConcepto";
            this.txtOtroConcepto.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtOtroConcepto.Size = new System.Drawing.Size(409, 50);
            this.txtOtroConcepto.TabIndex = 32;
            this.txtOtroConcepto.Tag = "Otro Concepto";
            this.txtOtroConcepto.UseOptimizedRendering = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(715, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
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
            // btnEditarCheque
            // 
            this.btnEditarCheque.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarCheque.Image")));
            this.btnEditarCheque.Location = new System.Drawing.Point(562, 152);
            this.btnEditarCheque.Name = "btnEditarCheque";
            this.btnEditarCheque.Size = new System.Drawing.Size(134, 25);
            this.btnEditarCheque.TabIndex = 38;
            this.btnEditarCheque.Text = "&Editar Transacción";
            this.btnEditarCheque.Click += new System.EventHandler(this.btnEditarCheque_Click);
            // 
            // btnCancelarCheque
            // 
            this.btnCancelarCheque.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarCheque.Image")));
            this.btnCancelarCheque.Location = new System.Drawing.Point(562, 229);
            this.btnCancelarCheque.Name = "btnCancelarCheque";
            this.btnCancelarCheque.Size = new System.Drawing.Size(134, 25);
            this.btnCancelarCheque.TabIndex = 40;
            this.btnCancelarCheque.Text = "Borrar Transacción";
            // 
            // btnGuardarCheque
            // 
            this.btnGuardarCheque.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarCheque.Image")));
            this.btnGuardarCheque.Location = new System.Drawing.Point(562, 121);
            this.btnGuardarCheque.Name = "btnGuardarCheque";
            this.btnGuardarCheque.Size = new System.Drawing.Size(134, 25);
            this.btnGuardarCheque.TabIndex = 37;
            this.btnGuardarCheque.Text = "&Guardar Transacción";
            this.btnGuardarCheque.Click += new System.EventHandler(this.btnGuardarCheque_Click);
            // 
            // btnCancelarCaptura
            // 
            this.btnCancelarCaptura.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarCaptura.Image")));
            this.btnCancelarCaptura.Location = new System.Drawing.Point(562, 90);
            this.btnCancelarCaptura.Name = "btnCancelarCaptura";
            this.btnCancelarCaptura.Size = new System.Drawing.Size(134, 25);
            this.btnCancelarCaptura.TabIndex = 36;
            this.btnCancelarCaptura.Text = "Cancelar Captura";
            this.btnCancelarCaptura.Click += new System.EventHandler(this.btnCancelarCaptura_Click);
            // 
            // btnBuscarCheque
            // 
            this.btnBuscarCheque.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCheque.Image")));
            this.btnBuscarCheque.Location = new System.Drawing.Point(562, 183);
            this.btnBuscarCheque.Name = "btnBuscarCheque";
            this.btnBuscarCheque.Size = new System.Drawing.Size(134, 25);
            this.btnBuscarCheque.TabIndex = 39;
            this.btnBuscarCheque.Text = "&Buscar Transacción";
            this.btnBuscarCheque.Click += new System.EventHandler(this.btnBuscarCheque_Click);
            // 
            // btnNuevoCheque
            // 
            this.btnNuevoCheque.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoCheque.Image")));
            this.btnNuevoCheque.Location = new System.Drawing.Point(562, 59);
            this.btnNuevoCheque.Name = "btnNuevoCheque";
            this.btnNuevoCheque.Size = new System.Drawing.Size(134, 25);
            this.btnNuevoCheque.TabIndex = 35;
            this.btnNuevoCheque.Text = "&Nueva Transacción";
            this.btnNuevoCheque.Click += new System.EventHandler(this.btnNuevoCheque_Click);
            // 
            // lblACuentaBanco
            // 
            this.lblACuentaBanco.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblACuentaBanco.Location = new System.Drawing.Point(12, 146);
            this.lblACuentaBanco.Name = "lblACuentaBanco";
            this.lblACuentaBanco.Size = new System.Drawing.Size(92, 13);
            this.lblACuentaBanco.TabIndex = 11;
            this.lblACuentaBanco.Text = "A Cuenta de Banco";
            // 
            // cboACuentaBanco
            // 
            this.cboACuentaBanco.EditValue = "";
            this.cboACuentaBanco.Location = new System.Drawing.Point(134, 142);
            this.cboACuentaBanco.Name = "cboACuentaBanco";
            this.cboACuentaBanco.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cboACuentaBanco.Properties.Appearance.Options.UseBackColor = true;
            this.cboACuentaBanco.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboACuentaBanco.Properties.DataSource = this.stpSelCuentaBancoPorBancoFiltradoBindingSource;
            this.cboACuentaBanco.Properties.DisplayMember = "NombreCuentaBanco";
            this.cboACuentaBanco.Properties.ValueMember = "IdCuentaBanco";
            this.cboACuentaBanco.Properties.View = this.gridView3;
            this.cboACuentaBanco.Size = new System.Drawing.Size(250, 20);
            this.cboACuentaBanco.TabIndex = 12;
            this.cboACuentaBanco.Tag = "Cuenta de Banco";
            this.cboACuentaBanco.EditValueChanged += new System.EventHandler(this.cboACuentaBanco_EditValueChanged);
            // 
            // stpSelCuentaBancoPorBancoFiltradoBindingSource
            // 
            this.stpSelCuentaBancoPorBancoFiltradoBindingSource.DataMember = "stpSelCuentaBancoPorBancoFiltrado";
            this.stpSelCuentaBancoPorBancoFiltradoBindingSource.DataSource = this.dbSAICBPOTesoreriaDataSet;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Nombre Cuenta Banco";
            this.gridColumn3.FieldName = "NombreCuentaBanco";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.FixedWidth = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            this.gridColumn3.Width = 300;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "No. Cuenta";
            this.gridColumn4.FieldName = "NoCuenta";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.FixedWidth = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            this.gridColumn4.Width = 84;
            // 
            // gridColumn5
            // 
            this.gridColumn5.FieldName = "IdCuentaBanco";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Moneda";
            this.gridColumn6.FieldName = "IdMoneda";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 2;
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(12, 94);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(80, 13);
            this.labelControl14.TabIndex = 5;
            this.labelControl14.Text = "Tipo Transacción";
            // 
            // cboTipoTransaccion
            // 
            this.cboTipoTransaccion.EditValue = "";
            this.cboTipoTransaccion.Location = new System.Drawing.Point(134, 90);
            this.cboTipoTransaccion.Name = "cboTipoTransaccion";
            this.cboTipoTransaccion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTipoTransaccion.Properties.DataSource = this.stpSelCodigoTransaccionBancoBindingSource;
            this.cboTipoTransaccion.Properties.DisplayMember = "DescCodigoTransaccionBanco";
            this.cboTipoTransaccion.Properties.ValueMember = "IdCodigoTransaccionBanco";
            this.cboTipoTransaccion.Properties.View = this.gridView4;
            this.cboTipoTransaccion.Size = new System.Drawing.Size(144, 20);
            this.cboTipoTransaccion.TabIndex = 6;
            this.cboTipoTransaccion.EditValueChanged += new System.EventHandler(this.cboCuentaBanco_EditValueChanged);
            // 
            // stpSelCodigoTransaccionBancoBindingSource
            // 
            this.stpSelCodigoTransaccionBancoBindingSource.DataMember = "stpSelCodigoTransaccionBanco";
            this.stpSelCodigoTransaccionBancoBindingSource.DataSource = this.dbSAICBPOTesoreriaDataSet;
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCodigoTransaccionBanco,
            this.colDescCodigoTransaccionBanco});
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // colIdCodigoTransaccionBanco
            // 
            this.colIdCodigoTransaccionBanco.FieldName = "IdCodigoTransaccionBanco";
            this.colIdCodigoTransaccionBanco.Name = "colIdCodigoTransaccionBanco";
            // 
            // colDescCodigoTransaccionBanco
            // 
            this.colDescCodigoTransaccionBanco.Caption = "Tipo Transacción";
            this.colDescCodigoTransaccionBanco.FieldName = "DescCodigoTransaccionBanco";
            this.colDescCodigoTransaccionBanco.Name = "colDescCodigoTransaccionBanco";
            this.colDescCodigoTransaccionBanco.Visible = true;
            this.colDescCodigoTransaccionBanco.VisibleIndex = 0;
            // 
            // chkChequeConciliado
            // 
            this.chkChequeConciliado.AutoSize = true;
            this.chkChequeConciliado.Enabled = false;
            this.chkChequeConciliado.Location = new System.Drawing.Point(551, 463);
            this.chkChequeConciliado.Name = "chkChequeConciliado";
            this.chkChequeConciliado.Size = new System.Drawing.Size(152, 17);
            this.chkChequeConciliado.TabIndex = 42;
            this.chkChequeConciliado.Text = "Conciliado en Edo. Cuenta";
            this.chkChequeConciliado.UseVisualStyleBackColor = true;
            // 
            // chkCancelado
            // 
            this.chkCancelado.AutoSize = true;
            this.chkCancelado.Enabled = false;
            this.chkCancelado.Location = new System.Drawing.Point(551, 440);
            this.chkCancelado.Name = "chkCancelado";
            this.chkCancelado.Size = new System.Drawing.Size(116, 17);
            this.chkCancelado.TabIndex = 41;
            this.chkCancelado.Text = "Cheque Cancelado";
            this.chkCancelado.UseVisualStyleBackColor = true;
            this.chkCancelado.Visible = false;
            // 
            // stpSelCategoriaTransaccionBancoTableAdapter
            // 
            this.stpSelCategoriaTransaccionBancoTableAdapter.ClearBeforeFill = true;
            // 
            // stpSelSubCategoriaTransaccionBancoTableAdapter
            // 
            this.stpSelSubCategoriaTransaccionBancoTableAdapter.ClearBeforeFill = true;
            // 
            // dbSAICBPOTesoreriaDataSetBindingSource
            // 
            this.dbSAICBPOTesoreriaDataSetBindingSource.DataSource = this.dbSAICBPOTesoreriaDataSet;
            this.dbSAICBPOTesoreriaDataSetBindingSource.Position = 0;
            // 
            // stpSelClienteProveedorChequesTableAdapter
            // 
            this.stpSelClienteProveedorChequesTableAdapter.ClearBeforeFill = true;
            // 
            // stpSelCodigoTransaccionBancoTableAdapter
            // 
            this.stpSelCodigoTransaccionBancoTableAdapter.ClearBeforeFill = true;
            // 
            // stpSelCuentaBancoPorBancoFiltradoTableAdapter
            // 
            this.stpSelCuentaBancoPorBancoFiltradoTableAdapter.ClearBeforeFill = true;
            // 
            // stpSelFolioLoteCargaNominaParaChequesTableAdapter
            // 
            this.stpSelFolioLoteCargaNominaParaChequesTableAdapter.ClearBeforeFill = true;
            // 
            // stpSelInfoCuentaBancoTableAdapter1
            // 
            this.stpSelInfoCuentaBancoTableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelCuentaBancoTransaccionTableAdapter
            // 
            this.stpSelCuentaBancoTransaccionTableAdapter.ClearBeforeFill = true;
            // 
            // txtTipoCambio
            // 
            this.txtTipoCambio.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtTipoCambio.Location = new System.Drawing.Point(134, 270);
            this.txtTipoCambio.Name = "txtTipoCambio";
            this.txtTipoCambio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTipoCambio.Properties.DisplayFormat.FormatString = "C2";
            this.txtTipoCambio.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTipoCambio.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtTipoCambio.Size = new System.Drawing.Size(100, 20);
            this.txtTipoCambio.TabIndex = 24;
            this.txtTipoCambio.Tag = "Importe";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 274);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(73, 13);
            this.labelControl2.TabIndex = 23;
            this.labelControl2.Text = "Tipo de Cambio";
            // 
            // frmxControlTransaccionBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 492);
            this.ControlBox = false;
            this.Controls.Add(this.txtTipoCambio);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.chkChequeConciliado);
            this.Controls.Add(this.chkCancelado);
            this.Controls.Add(this.cboTipoTransaccion);
            this.Controls.Add(this.labelControl14);
            this.Controls.Add(this.lblACuentaBanco);
            this.Controls.Add(this.cboACuentaBanco);
            this.Controls.Add(this.btnEditarCheque);
            this.Controls.Add(this.btnCancelarCheque);
            this.Controls.Add(this.btnGuardarCheque);
            this.Controls.Add(this.btnCancelarCaptura);
            this.Controls.Add(this.btnBuscarCheque);
            this.Controls.Add(this.btnNuevoCheque);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.cboClienteProveedor);
            this.Controls.Add(this.lblClienteProveedor);
            this.Controls.Add(this.chkUtilizarFolioLoteNomina);
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.cboFolioLoteCargaNomina);
            this.Controls.Add(this.lblFolio);
            this.Controls.Add(this.lblFolioMovimiento);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.cboSubCategoriaTransaccionBanco);
            this.Controls.Add(this.cboCategoriaTransaccionBanco);
            this.Controls.Add(this.lblMoneda);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.txtBeneficiarioCheque);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.txtNoCheque);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.cboCuentaBanco);
            this.Controls.Add(this.cboFecha);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtOtroConcepto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmxControlTransaccionBanco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Transacciones Bancarias";
            this.Load += new System.EventHandler(this.frmxControlTransaccionBanco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cboClienteProveedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelClienteProveedorChequesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOTesoreriaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservaciones.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFolioLoteCargaNomina.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelFolioLoteCargaNominaParaChequesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idLoteCargaNominaGridLookUpEditView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSubCategoriaTransaccionBanco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelSubCategoriaTransaccionBancoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCategoriaTransaccionBanco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelCategoriaTransaccionBancoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBeneficiarioCheque.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImporte.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoCheque.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCuentaBanco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelCuentaBancoTransaccionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFecha.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOtroConcepto.Properties)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboACuentaBanco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelCuentaBancoPorBancoFiltradoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTipoTransaccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelCodigoTransaccionBancoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOTesoreriaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoCambio.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GridLookUpEdit cboClienteProveedor;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colRazonSocial;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreComercial;
        private DevExpress.XtraEditors.LabelControl lblClienteProveedor;
        private System.Windows.Forms.CheckBox chkUtilizarFolioLoteNomina;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.MemoEdit txtObservaciones;
        private DevExpress.XtraEditors.GridLookUpEdit cboFolioLoteCargaNomina;
        private DevExpress.XtraGrid.Views.Grid.GridView idLoteCargaNominaGridLookUpEditView;
        private DevExpress.XtraGrid.Columns.GridColumn colIdLoteCargaNomina;
        private DevExpress.XtraGrid.Columns.GridColumn colFolioLoteCargaNomina;
        private DevExpress.XtraGrid.Columns.GridColumn colTenedora;
        private DevExpress.XtraGrid.Columns.GridColumn colCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colOperador;
        private DevExpress.XtraEditors.LabelControl lblFolio;
        private DevExpress.XtraEditors.LabelControl lblFolioMovimiento;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.GridLookUpEdit cboSubCategoriaTransaccionBanco;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSubCategoriaTransaccionBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colDescSubCategoriaTransaccionBanco;
        private DevExpress.XtraEditors.GridLookUpEdit cboCategoriaTransaccionBanco;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCategoriaTransaccionBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colDescCategoriaTransaccionBanco;
        private DevExpress.XtraEditors.LabelControl lblMoneda;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtBeneficiarioCheque;
        private DevExpress.XtraEditors.SpinEdit txtImporte;
        private DevExpress.XtraEditors.SpinEdit txtNoCheque;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.GridLookUpEdit cboCuentaBanco;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit2View;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreCuentaBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colNoCuenta;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCuentaBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMoneda;
        private DevExpress.XtraEditors.DateEdit cboFecha;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.MemoEdit txtOtroConcepto;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private DevExpress.XtraEditors.SimpleButton btnEditarCheque;
        private DevExpress.XtraEditors.SimpleButton btnCancelarCheque;
        private DevExpress.XtraEditors.SimpleButton btnGuardarCheque;
        private DevExpress.XtraEditors.SimpleButton btnCancelarCaptura;
        private DevExpress.XtraEditors.SimpleButton btnBuscarCheque;
        private DevExpress.XtraEditors.SimpleButton btnNuevoCheque;
        private dbSAICBPOCatalogosDataSet dbSAICBPOCatalogosDataSet;
        private System.Windows.Forms.BindingSource dbSAICBPOTesoreriaDataSetBindingSource;
        private dbSAICBPOTesoreriaDataSet dbSAICBPOTesoreriaDataSet;
        private System.Windows.Forms.BindingSource stpSelClienteProveedorChequesBindingSource;
        private dbSAICBPOTesoreriaDataSetTableAdapters.stpSelClienteProveedorChequesTableAdapter stpSelClienteProveedorChequesTableAdapter;
        private System.Windows.Forms.BindingSource stpSelCategoriaTransaccionBancoBindingSource;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelCategoriaTransaccionBancoTableAdapter stpSelCategoriaTransaccionBancoTableAdapter;
        private System.Windows.Forms.BindingSource stpSelSubCategoriaTransaccionBancoBindingSource;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelSubCategoriaTransaccionBancoTableAdapter stpSelSubCategoriaTransaccionBancoTableAdapter;
        private DevExpress.XtraEditors.LabelControl lblACuentaBanco;
        private DevExpress.XtraEditors.GridLookUpEdit cboACuentaBanco;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.GridLookUpEdit cboTipoTransaccion;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private System.Windows.Forms.BindingSource stpSelCodigoTransaccionBancoBindingSource;
        private dbSAICBPOTesoreriaDataSetTableAdapters.stpSelCodigoTransaccionBancoTableAdapter stpSelCodigoTransaccionBancoTableAdapter;
        private System.Windows.Forms.BindingSource stpSelCuentaBancoPorBancoFiltradoBindingSource;
        private dbSAICBPOTesoreriaDataSetTableAdapters.stpSelCuentaBancoPorBancoFiltradoTableAdapter stpSelCuentaBancoPorBancoFiltradoTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCodigoTransaccionBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colDescCodigoTransaccionBanco;
        private System.Windows.Forms.BindingSource stpSelFolioLoteCargaNominaParaChequesBindingSource;
        private dbSAICBPOTesoreriaDataSetTableAdapters.stpSelFolioLoteCargaNominaParaChequesTableAdapter stpSelFolioLoteCargaNominaParaChequesTableAdapter;
        private dbSAICBPOActualizacionesTesoreriaDataSetTableAdapters.ActualizacionesTesoreriaTableAdapter actualizacionesTesoreriaTableAdapter1;
        private System.Windows.Forms.CheckBox chkChequeConciliado;
        private System.Windows.Forms.CheckBox chkCancelado;
        private dbSAICBPOTesoreriaDataSetTableAdapters.stpSelInfoCuentaBancoTableAdapter stpSelInfoCuentaBancoTableAdapter1;
        private System.Windows.Forms.BindingSource stpSelCuentaBancoTransaccionBindingSource;
        private dbSAICBPOTesoreriaDataSetTableAdapters.stpSelCuentaBancoTransaccionTableAdapter stpSelCuentaBancoTransaccionTableAdapter;
        private DevExpress.XtraEditors.SpinEdit txtTipoCambio;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}