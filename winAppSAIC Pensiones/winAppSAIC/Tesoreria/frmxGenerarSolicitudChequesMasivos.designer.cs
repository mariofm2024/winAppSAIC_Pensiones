namespace winAppSAIC.Tesoreria
{
    partial class frmxGenerarSolicitudChequesMasivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmxGenerarSolicitudChequesMasivos));
            this.dbSAICBPOTesoreriaDataSet = new winAppSAIC.Tesoreria.dbSAICBPOTesoreriaDataSet();
            this.tableAdapterManager = new winAppSAIC.Tesoreria.dbSAICBPOTesoreriaDataSetTableAdapters.TableAdapterManager();
            this.stpSelGenerarSolicitudChequesGridControl = new DevExpress.XtraGrid.GridControl();
            this.stpSelChequesPorLoteCargaNominaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdPDOHeader = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMontoNetoPagar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
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
            this.stpSelFolioLoteCargaNominaParaSolicitudChequesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenedora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOperador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTenedora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblFolio = new DevExpress.XtraEditors.LabelControl();
            this.stpSelInfoDetalleLoteCargaNominaGenericoChequesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.txtMes = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemSpinEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.barStaticItem3 = new DevExpress.XtraBars.BarStaticItem();
            this.txtAno = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemSpinEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.btnFiltrar = new DevExpress.XtraBars.BarButtonItem();
            this.btnSalir = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.barEditItem2 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.stpSelInfoDetalleLoteCargaNominaGenericoChequesTableAdapter = new winAppSAIC.Tesoreria.dbSAICBPOTesoreriaDataSetTableAdapters.stpSelInfoDetalleLoteCargaNominaGenericoChequesTableAdapter();
            this.stpSelFolioLoteCargaNominaParaSolicitudChequesTableAdapter = new winAppSAIC.Tesoreria.dbSAICBPOTesoreriaDataSetTableAdapters.stpSelFolioLoteCargaNominaParaSolicitudChequesTableAdapter();
            this.splashSMCargando = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::winAppSAIC.frmxCargandoInformacion), true, true);
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.btnBuscarNoLoteNomina = new DevExpress.XtraEditors.SimpleButton();
            this.txtNoLoteCargaNomina = new DevExpress.XtraEditors.TextEdit();
            this.panelControl7 = new DevExpress.XtraEditors.PanelControl();
            this.cboIdBancoSolicitado = new DevExpress.XtraEditors.LookUpEdit();
            this.stpSelBancoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPOCatalogosDataSet = new winAppSAIC.dbSAICBPOCatalogosDataSet();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnFiltrarRecibos = new DevExpress.XtraEditors.SimpleButton();
            this.lblAnoPago = new DevExpress.XtraEditors.LabelControl();
            this.txtNoControl = new DevExpress.XtraEditors.TextEdit();
            this.stpSelBancoTableAdapter = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelBancoTableAdapter();
            this.stpSelChequesPorLoteCargaNominaTableAdapter = new winAppSAIC.Tesoreria.dbSAICBPOTesoreriaDataSetTableAdapters.stpSelChequesPorLoteCargaNominaTableAdapter();
            this.solicitudChequeHeaderTableAdapter1 = new winAppSAIC.Tesoreria.dbSAICBPOTesoreriaDataSetTableAdapters.SolicitudChequeHeaderTableAdapter();
            this.solicitudChequeDetailTableAdapter1 = new winAppSAIC.Tesoreria.dbSAICBPOTesoreriaDataSetTableAdapters.SolicitudChequeDetailTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOTesoreriaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelGenerarSolicitudChequesGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelChequesPorLoteCargaNominaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkEstatusNominaContabilizada.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodoPago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreOperador.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoNomina.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreComercialCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreComercialTenedora.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFolioLoteCargaNomina.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelFolioLoteCargaNominaParaSolicitudChequesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelInfoDetalleLoteCargaNominaGenericoChequesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoLoteCargaNomina.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl7)).BeginInit();
            this.panelControl7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboIdBancoSolicitado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelBancoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoControl.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dbSAICBPOTesoreriaDataSet
            // 
            this.dbSAICBPOTesoreriaDataSet.DataSetName = "dbSAICBPOTesoreriaDataSet";
            this.dbSAICBPOTesoreriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CuentaBancoTableAdapter = null;
            this.tableAdapterManager.SolicitudChequeDetailTableAdapter = null;
            this.tableAdapterManager.SolicitudChequeHeaderTableAdapter = null;
            this.tableAdapterManager.TransaccionBancoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = winAppSAIC.Tesoreria.dbSAICBPOTesoreriaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // stpSelGenerarSolicitudChequesGridControl
            // 
            this.stpSelGenerarSolicitudChequesGridControl.DataSource = this.stpSelChequesPorLoteCargaNominaBindingSource;
            this.stpSelGenerarSolicitudChequesGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stpSelGenerarSolicitudChequesGridControl.Location = new System.Drawing.Point(2, 2);
            this.stpSelGenerarSolicitudChequesGridControl.MainView = this.gridView1;
            this.stpSelGenerarSolicitudChequesGridControl.Name = "stpSelGenerarSolicitudChequesGridControl";
            this.stpSelGenerarSolicitudChequesGridControl.Size = new System.Drawing.Size(810, 267);
            this.stpSelGenerarSolicitudChequesGridControl.TabIndex = 0;
            this.stpSelGenerarSolicitudChequesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // stpSelChequesPorLoteCargaNominaBindingSource
            // 
            this.stpSelChequesPorLoteCargaNominaBindingSource.DataMember = "stpSelChequesPorLoteCargaNomina";
            this.stpSelChequesPorLoteCargaNominaBindingSource.DataSource = this.dbSAICBPOTesoreriaDataSet;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdPDOHeader,
            this.colNombreEmpleado,
            this.colMontoNetoPagar});
            this.gridView1.GridControl = this.stpSelGenerarSolicitudChequesGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIdPDOHeader
            // 
            this.colIdPDOHeader.Caption = "No. Control";
            this.colIdPDOHeader.FieldName = "IdPDOHeader";
            this.colIdPDOHeader.Name = "colIdPDOHeader";
            // 
            // colNombreEmpleado
            // 
            this.colNombreEmpleado.FieldName = "NombreEmpleado";
            this.colNombreEmpleado.Name = "colNombreEmpleado";
            this.colNombreEmpleado.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "NombreEmpleado", "No. Registros: {0}")});
            this.colNombreEmpleado.Visible = true;
            this.colNombreEmpleado.VisibleIndex = 1;
            this.colNombreEmpleado.Width = 250;
            // 
            // colMontoNetoPagar
            // 
            this.colMontoNetoPagar.DisplayFormat.FormatString = "N2";
            this.colMontoNetoPagar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMontoNetoPagar.FieldName = "MontoNetoPagar";
            this.colMontoNetoPagar.Name = "colMontoNetoPagar";
            this.colMontoNetoPagar.Visible = true;
            this.colMontoNetoPagar.VisibleIndex = 2;
            this.colMontoNetoPagar.Width = 120;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.stpSelGenerarSolicitudChequesGridControl);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(814, 271);
            this.panelControl1.TabIndex = 4;
            // 
            // chkEstatusNominaContabilizada
            // 
            this.chkEstatusNominaContabilizada.Enabled = false;
            this.chkEstatusNominaContabilizada.Location = new System.Drawing.Point(597, 89);
            this.chkEstatusNominaContabilizada.Name = "chkEstatusNominaContabilizada";
            this.chkEstatusNominaContabilizada.Properties.Caption = "Contabilizada";
            this.chkEstatusNominaContabilizada.Size = new System.Drawing.Size(116, 19);
            this.chkEstatusNominaContabilizada.TabIndex = 29;
            this.chkEstatusNominaContabilizada.TabStop = false;
            // 
            // txtPeriodoPago
            // 
            this.txtPeriodoPago.Enabled = false;
            this.txtPeriodoPago.Location = new System.Drawing.Point(597, 63);
            this.txtPeriodoPago.Name = "txtPeriodoPago";
            this.txtPeriodoPago.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtPeriodoPago.Properties.Appearance.Options.UseBackColor = true;
            this.txtPeriodoPago.Size = new System.Drawing.Size(150, 20);
            this.txtPeriodoPago.TabIndex = 28;
            this.txtPeriodoPago.TabStop = false;
            // 
            // txtNombreOperador
            // 
            this.txtNombreOperador.Enabled = false;
            this.txtNombreOperador.Location = new System.Drawing.Point(134, 88);
            this.txtNombreOperador.Name = "txtNombreOperador";
            this.txtNombreOperador.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtNombreOperador.Properties.Appearance.Options.UseBackColor = true;
            this.txtNombreOperador.Size = new System.Drawing.Size(392, 20);
            this.txtNombreOperador.TabIndex = 24;
            this.txtNombreOperador.TabStop = false;
            // 
            // txtTipoNomina
            // 
            this.txtTipoNomina.Enabled = false;
            this.txtTipoNomina.Location = new System.Drawing.Point(597, 38);
            this.txtTipoNomina.Name = "txtTipoNomina";
            this.txtTipoNomina.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtTipoNomina.Properties.Appearance.Options.UseBackColor = true;
            this.txtTipoNomina.Size = new System.Drawing.Size(116, 20);
            this.txtTipoNomina.TabIndex = 26;
            this.txtTipoNomina.TabStop = false;
            // 
            // txtNombreComercialCliente
            // 
            this.txtNombreComercialCliente.Enabled = false;
            this.txtNombreComercialCliente.Location = new System.Drawing.Point(134, 63);
            this.txtNombreComercialCliente.Name = "txtNombreComercialCliente";
            this.txtNombreComercialCliente.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtNombreComercialCliente.Properties.Appearance.Options.UseBackColor = true;
            this.txtNombreComercialCliente.Size = new System.Drawing.Size(392, 20);
            this.txtNombreComercialCliente.TabIndex = 22;
            this.txtNombreComercialCliente.TabStop = false;
            // 
            // txtNombreComercialTenedora
            // 
            this.txtNombreComercialTenedora.Enabled = false;
            this.txtNombreComercialTenedora.Location = new System.Drawing.Point(134, 38);
            this.txtNombreComercialTenedora.Name = "txtNombreComercialTenedora";
            this.txtNombreComercialTenedora.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtNombreComercialTenedora.Properties.Appearance.Options.UseBackColor = true;
            this.txtNombreComercialTenedora.Size = new System.Drawing.Size(392, 20);
            this.txtNombreComercialTenedora.TabIndex = 20;
            this.txtNombreComercialTenedora.TabStop = false;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(533, 42);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(58, 13);
            this.labelControl5.TabIndex = 25;
            this.labelControl5.Text = "Tipo Nómina";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(555, 67);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(36, 13);
            this.labelControl4.TabIndex = 27;
            this.labelControl4.Text = "Periodo";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(82, 92);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(46, 13);
            this.labelControl3.TabIndex = 23;
            this.labelControl3.Text = "Operador";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(95, 67);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(33, 13);
            this.labelControl2.TabIndex = 21;
            this.labelControl2.Text = "Cliente";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(82, 42);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 13);
            this.labelControl1.TabIndex = 19;
            this.labelControl1.Text = "Tenedora";
            // 
            // cboFolioLoteCargaNomina
            // 
            this.cboFolioLoteCargaNomina.EditValue = "";
            this.cboFolioLoteCargaNomina.Location = new System.Drawing.Point(134, 12);
            this.cboFolioLoteCargaNomina.Name = "cboFolioLoteCargaNomina";
            this.cboFolioLoteCargaNomina.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
            this.cboFolioLoteCargaNomina.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboFolioLoteCargaNomina.Properties.DataSource = this.stpSelFolioLoteCargaNominaParaSolicitudChequesBindingSource;
            this.cboFolioLoteCargaNomina.Properties.DisplayMember = "FolioLoteCargaNomina";
            this.cboFolioLoteCargaNomina.Properties.ValueMember = "IdLoteCargaNomina";
            this.cboFolioLoteCargaNomina.Properties.View = this.gridLookUpEdit1View;
            this.cboFolioLoteCargaNomina.Size = new System.Drawing.Size(250, 20);
            this.cboFolioLoteCargaNomina.TabIndex = 18;
            this.cboFolioLoteCargaNomina.Tag = "Folio Lote Carga Nómina";
            this.cboFolioLoteCargaNomina.EditValueChanged += new System.EventHandler(this.cboFolioLoteCargaNomina_EditValueChanged);
            // 
            // stpSelFolioLoteCargaNominaParaSolicitudChequesBindingSource
            // 
            this.stpSelFolioLoteCargaNominaParaSolicitudChequesBindingSource.DataMember = "stpSelFolioLoteCargaNominaParaSolicitudCheques";
            this.stpSelFolioLoteCargaNominaParaSolicitudChequesBindingSource.DataSource = this.dbSAICBPOTesoreriaDataSet;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn3,
            this.colTenedora,
            this.colCliente,
            this.colOperador,
            this.colIdTenedora,
            this.colIdCliente});
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
            this.gridColumn2.Width = 22;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Folio Lote Carga Nómina";
            this.gridColumn3.FieldName = "FolioLoteCargaNomina";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 41;
            // 
            // colTenedora
            // 
            this.colTenedora.Caption = "Tenedora";
            this.colTenedora.FieldName = "Tenedora";
            this.colTenedora.Name = "colTenedora";
            this.colTenedora.Visible = true;
            this.colTenedora.VisibleIndex = 2;
            this.colTenedora.Width = 114;
            // 
            // colCliente
            // 
            this.colCliente.Caption = "Cliente";
            this.colCliente.FieldName = "Cliente";
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
            // colIdTenedora
            // 
            this.colIdTenedora.FieldName = "IdTenedora";
            this.colIdTenedora.Name = "colIdTenedora";
            // 
            // colIdCliente
            // 
            this.colIdCliente.FieldName = "IdCliente";
            this.colIdCliente.Name = "colIdCliente";
            // 
            // lblFolio
            // 
            this.lblFolio.Location = new System.Drawing.Point(12, 15);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(116, 13);
            this.lblFolio.TabIndex = 17;
            this.lblFolio.Text = "Folio Lote Carga Nómina";
            // 
            // stpSelInfoDetalleLoteCargaNominaGenericoChequesBindingSource
            // 
            this.stpSelInfoDetalleLoteCargaNominaGenericoChequesBindingSource.DataMember = "stpSelInfoDetalleLoteCargaNominaGenericoCheques";
            this.stpSelInfoDetalleLoteCargaNominaGenericoChequesBindingSource.DataSource = this.dbSAICBPOTesoreriaDataSet;
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
            this.barStaticItem1,
            this.barStaticItem2,
            this.barEditItem2,
            this.txtMes,
            this.barStaticItem3,
            this.txtAno,
            this.btnFiltrar,
            this.btnSalir});
            this.barManager1.MaxItemId = 9;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
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
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.txtMes),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.txtAno),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnFiltrar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSalir, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "Mes";
            this.barStaticItem1.Id = 0;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // txtMes
            // 
            this.txtMes.Caption = "barEditItem1";
            this.txtMes.Edit = this.repositoryItemSpinEdit2;
            this.txtMes.Id = 4;
            this.txtMes.Name = "txtMes";
            // 
            // repositoryItemSpinEdit2
            // 
            this.repositoryItemSpinEdit2.AutoHeight = false;
            this.repositoryItemSpinEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit2.Name = "repositoryItemSpinEdit2";
            // 
            // barStaticItem3
            // 
            this.barStaticItem3.Caption = "Año";
            this.barStaticItem3.Id = 5;
            this.barStaticItem3.Name = "barStaticItem3";
            this.barStaticItem3.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // txtAno
            // 
            this.txtAno.Caption = "barEditItem3";
            this.txtAno.Edit = this.repositoryItemSpinEdit3;
            this.txtAno.Id = 6;
            this.txtAno.Name = "txtAno";
            // 
            // repositoryItemSpinEdit3
            // 
            this.repositoryItemSpinEdit3.AutoHeight = false;
            this.repositoryItemSpinEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit3.Name = "repositoryItemSpinEdit3";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Caption = "Filtrar";
            this.btnFiltrar.Glyph = ((System.Drawing.Image)(resources.GetObject("btnFiltrar.Glyph")));
            this.btnFiltrar.Id = 7;
            this.btnFiltrar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnFiltrar.LargeGlyph")));
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFiltrar_ItemClick);
            // 
            // btnSalir
            // 
            this.btnSalir.Caption = "Salir";
            this.btnSalir.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSalir.Glyph")));
            this.btnSalir.Id = 8;
            this.btnSalir.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnSalir.LargeGlyph")));
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSalir_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(814, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 462);
            this.barDockControlBottom.Size = new System.Drawing.Size(814, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 431);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(814, 31);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 431);
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Caption = "Año";
            this.barStaticItem2.Id = 2;
            this.barStaticItem2.Name = "barStaticItem2";
            this.barStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barEditItem2
            // 
            this.barEditItem2.Caption = "barEditItem2";
            this.barEditItem2.Edit = this.repositoryItemSpinEdit1;
            this.barEditItem2.Id = 3;
            this.barEditItem2.Name = "barEditItem2";
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // stpSelInfoDetalleLoteCargaNominaGenericoChequesTableAdapter
            // 
            this.stpSelInfoDetalleLoteCargaNominaGenericoChequesTableAdapter.ClearBeforeFill = true;
            // 
            // stpSelFolioLoteCargaNominaParaSolicitudChequesTableAdapter
            // 
            this.stpSelFolioLoteCargaNominaParaSolicitudChequesTableAdapter.ClearBeforeFill = true;
            // 
            // splashSMCargando
            // 
            this.splashSMCargando.ClosingDelay = 500;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 31);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.btnBuscarNoLoteNomina);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtNoLoteCargaNomina);
            this.splitContainerControl1.Panel1.Controls.Add(this.panelControl7);
            this.splitContainerControl1.Panel1.Controls.Add(this.cboFolioLoteCargaNomina);
            this.splitContainerControl1.Panel1.Controls.Add(this.chkEstatusNominaContabilizada);
            this.splitContainerControl1.Panel1.Controls.Add(this.lblFolio);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtPeriodoPago);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl1);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtNombreOperador);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtTipoNomina);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl3);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtNombreComercialCliente);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl4);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtNombreComercialTenedora);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl5);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.panelControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(814, 431);
            this.splitContainerControl1.SplitterPosition = 155;
            this.splitContainerControl1.TabIndex = 10;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // btnBuscarNoLoteNomina
            // 
            this.btnBuscarNoLoteNomina.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarNoLoteNomina.Image")));
            this.btnBuscarNoLoteNomina.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnBuscarNoLoteNomina.Location = new System.Drawing.Point(507, 11);
            this.btnBuscarNoLoteNomina.Name = "btnBuscarNoLoteNomina";
            this.btnBuscarNoLoteNomina.Size = new System.Drawing.Size(32, 23);
            this.btnBuscarNoLoteNomina.TabIndex = 65;
            this.btnBuscarNoLoteNomina.ToolTip = "Buscar";
            this.btnBuscarNoLoteNomina.Visible = false;
            this.btnBuscarNoLoteNomina.Click += new System.EventHandler(this.btnBuscarNoLoteNomina_Click);
            // 
            // txtNoLoteCargaNomina
            // 
            this.txtNoLoteCargaNomina.Location = new System.Drawing.Point(392, 12);
            this.txtNoLoteCargaNomina.Name = "txtNoLoteCargaNomina";
            this.txtNoLoteCargaNomina.Properties.Mask.EditMask = "\\d{1,7}";
            this.txtNoLoteCargaNomina.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtNoLoteCargaNomina.Size = new System.Drawing.Size(109, 20);
            this.txtNoLoteCargaNomina.TabIndex = 64;
            this.txtNoLoteCargaNomina.Visible = false;
            // 
            // panelControl7
            // 
            this.panelControl7.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.panelControl7.Appearance.Options.UseBackColor = true;
            this.panelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl7.Controls.Add(this.cboIdBancoSolicitado);
            this.panelControl7.Controls.Add(this.labelControl6);
            this.panelControl7.Controls.Add(this.btnFiltrarRecibos);
            this.panelControl7.Controls.Add(this.lblAnoPago);
            this.panelControl7.Controls.Add(this.txtNoControl);
            this.panelControl7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl7.Location = new System.Drawing.Point(0, 120);
            this.panelControl7.Name = "panelControl7";
            this.panelControl7.Size = new System.Drawing.Size(814, 35);
            this.panelControl7.TabIndex = 0;
            // 
            // cboIdBancoSolicitado
            // 
            this.cboIdBancoSolicitado.Location = new System.Drawing.Point(392, 8);
            this.cboIdBancoSolicitado.MenuManager = this.barManager1;
            this.cboIdBancoSolicitado.Name = "cboIdBancoSolicitado";
            this.cboIdBancoSolicitado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboIdBancoSolicitado.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdBanco", "Id Banco", 65, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NombreBanco", "Nombre Banco", 120, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.cboIdBancoSolicitado.Properties.DataSource = this.stpSelBancoBindingSource;
            this.cboIdBancoSolicitado.Properties.DisplayMember = "NombreBanco";
            this.cboIdBancoSolicitado.Properties.NullText = "";
            this.cboIdBancoSolicitado.Properties.ValueMember = "IdBanco";
            this.cboIdBancoSolicitado.Size = new System.Drawing.Size(207, 20);
            this.cboIdBancoSolicitado.TabIndex = 4;
            this.cboIdBancoSolicitado.Tag = "Banco solicitado para Cheques";
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
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(240, 11);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(146, 13);
            this.labelControl6.TabIndex = 3;
            this.labelControl6.Text = "Banco solicitado para Cheques";
            // 
            // btnFiltrarRecibos
            // 
            this.btnFiltrarRecibos.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrarRecibos.Image")));
            this.btnFiltrarRecibos.Location = new System.Drawing.Point(629, 6);
            this.btnFiltrarRecibos.Name = "btnFiltrarRecibos";
            this.btnFiltrarRecibos.Size = new System.Drawing.Size(175, 23);
            this.btnFiltrarRecibos.TabIndex = 0;
            this.btnFiltrarRecibos.Text = "Generar Solicitud de Cheques";
            this.btnFiltrarRecibos.Click += new System.EventHandler(this.btnFiltrarRecibos_Click);
            // 
            // lblAnoPago
            // 
            this.lblAnoPago.Location = new System.Drawing.Point(13, 11);
            this.lblAnoPago.Name = "lblAnoPago";
            this.lblAnoPago.Size = new System.Drawing.Size(115, 13);
            this.lblAnoPago.TabIndex = 1;
            this.lblAnoPago.Text = "No. Control Orden Pago";
            // 
            // txtNoControl
            // 
            this.txtNoControl.Location = new System.Drawing.Point(134, 8);
            this.txtNoControl.Name = "txtNoControl";
            this.txtNoControl.Properties.Mask.BeepOnError = true;
            this.txtNoControl.Properties.Mask.EditMask = "\\d{1,10}";
            this.txtNoControl.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtNoControl.Size = new System.Drawing.Size(100, 20);
            this.txtNoControl.TabIndex = 2;
            this.txtNoControl.Tag = "No. Control Orden Pago";
            // 
            // stpSelBancoTableAdapter
            // 
            this.stpSelBancoTableAdapter.ClearBeforeFill = true;
            // 
            // stpSelChequesPorLoteCargaNominaTableAdapter
            // 
            this.stpSelChequesPorLoteCargaNominaTableAdapter.ClearBeforeFill = true;
            // 
            // solicitudChequeHeaderTableAdapter1
            // 
            this.solicitudChequeHeaderTableAdapter1.ClearBeforeFill = true;
            // 
            // solicitudChequeDetailTableAdapter1
            // 
            this.solicitudChequeDetailTableAdapter1.ClearBeforeFill = true;
            // 
            // frmxGenerarSolicitudChequesMasivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 462);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmxGenerarSolicitudChequesMasivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generar Solicitud de Cheques Masivos";
            this.Load += new System.EventHandler(this.frmxGenerarSolicitudCheques_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOTesoreriaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelGenerarSolicitudChequesGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelChequesPorLoteCargaNominaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkEstatusNominaContabilizada.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodoPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreOperador.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoNomina.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreComercialCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreComercialTenedora.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFolioLoteCargaNomina.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelFolioLoteCargaNominaParaSolicitudChequesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelInfoDetalleLoteCargaNominaGenericoChequesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtNoLoteCargaNomina.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl7)).EndInit();
            this.panelControl7.ResumeLayout(false);
            this.panelControl7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboIdBancoSolicitado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelBancoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoControl.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dbSAICBPOTesoreriaDataSet dbSAICBPOTesoreriaDataSet;
        private dbSAICBPOTesoreriaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl stpSelGenerarSolicitudChequesGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPDOHeader;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn colMontoNetoPagar;
        private DevExpress.XtraEditors.PanelControl panelControl1;
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
        private DevExpress.XtraGrid.Columns.GridColumn colIdTenedora;
        private DevExpress.XtraEditors.LabelControl lblFolio;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarEditItem txtMes;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit2;
        private DevExpress.XtraBars.BarStaticItem barStaticItem3;
        private DevExpress.XtraBars.BarEditItem txtAno;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit3;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        private DevExpress.XtraBars.BarEditItem barEditItem2;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraBars.BarButtonItem btnFiltrar;
        private DevExpress.XtraBars.BarButtonItem btnSalir;
        private System.Windows.Forms.BindingSource stpSelInfoDetalleLoteCargaNominaGenericoChequesBindingSource;
        private dbSAICBPOTesoreriaDataSetTableAdapters.stpSelInfoDetalleLoteCargaNominaGenericoChequesTableAdapter stpSelInfoDetalleLoteCargaNominaGenericoChequesTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCliente;
        private System.Windows.Forms.BindingSource stpSelFolioLoteCargaNominaParaSolicitudChequesBindingSource;
        private dbSAICBPOTesoreriaDataSetTableAdapters.stpSelFolioLoteCargaNominaParaSolicitudChequesTableAdapter stpSelFolioLoteCargaNominaParaSolicitudChequesTableAdapter;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashSMCargando;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.PanelControl panelControl7;
        private DevExpress.XtraEditors.SimpleButton btnFiltrarRecibos;
        private DevExpress.XtraEditors.LabelControl lblAnoPago;
        private DevExpress.XtraEditors.TextEdit txtNoControl;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LookUpEdit cboIdBancoSolicitado;
        private dbSAICBPOCatalogosDataSet dbSAICBPOCatalogosDataSet;
        private System.Windows.Forms.BindingSource stpSelBancoBindingSource;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelBancoTableAdapter stpSelBancoTableAdapter;
        private System.Windows.Forms.BindingSource stpSelChequesPorLoteCargaNominaBindingSource;
        private dbSAICBPOTesoreriaDataSetTableAdapters.stpSelChequesPorLoteCargaNominaTableAdapter stpSelChequesPorLoteCargaNominaTableAdapter;
        private dbSAICBPOTesoreriaDataSetTableAdapters.SolicitudChequeHeaderTableAdapter solicitudChequeHeaderTableAdapter1;
        private dbSAICBPOTesoreriaDataSetTableAdapters.SolicitudChequeDetailTableAdapter solicitudChequeDetailTableAdapter1;
        private DevExpress.XtraEditors.SimpleButton btnBuscarNoLoteNomina;
        private DevExpress.XtraEditors.TextEdit txtNoLoteCargaNomina;
    }
}