namespace winAppSAIC.Contablidad
{
    partial class frmxDesgloseReporteNominasAlimentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmxDesgloseReporteNominasAlimentos));
            this.dbSAICBPOReportesDataSet = new winAppSAIC.dbSAICBPOReportesDataSet();
            this.stpSelReporteNominaAlimentosSC_XLSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stpSelReporteNominaAlimentosSC_XLSTableAdapter = new winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.stpSelReporteNominaAlimentosSC_XLSTableAdapter();
            this.tableAdapterManager = new winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.TableAdapterManager();
            this.stpSelReporteNominaAlimentosSC_XLSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.btnExportarXLS = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCerrarNominaContabilizada = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.stpSelReporteNominaAlimentosSC_XLSGridControl = new DevExpress.XtraGrid.GridControl();
            this.cmExportarGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportarAExcelXLSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNombreEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRFCEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCURP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSueldoBruto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVales = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPréstamoFonacot = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInfonavit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPensiónAlimenticia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPréstamo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAnticipoNómina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalAlimentosBruto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPréstamoAgna1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPréstamoAgna2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMiAdelanto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalAlimentosNeto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoCambio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMoneda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBancoDestino = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCostoSocial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJubilaciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pcFolioLoteCargaNomina = new DevExpress.XtraEditors.PanelControl();
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
            this.stpSelFolioLoteCargaNominaSCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPODataSet = new winAppSAIC.dbSAICBPODataSet();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenedora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOperador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblFolio = new DevExpress.XtraEditors.LabelControl();
            this.stpSelFolioLoteCargaNominaSCTableAdapter = new winAppSAIC.dbSAICBPODataSetTableAdapters.stpSelFolioLoteCargaNominaSCTableAdapter();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.sfdRutaArchivo = new System.Windows.Forms.SaveFileDialog();
            this.stpSelInfoDetalleLoteCargaNominaTableAdapter1 = new winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.stpSelInfoDetalleLoteCargaNominaTableAdapter();
            this.stpSelValidarLoteCargaNominaEnSolicitudCancelacionNominaTableAdapter1 = new winAppSAIC.dbSAICBPOValidacionDataSetTableAdapters.stpSelValidarLoteCargaNominaEnSolicitudCancelacionNominaTableAdapter();
            this.actualizacionesGeneralTableAdapter1 = new winAppSAIC.dbSAICBPOActualizacionesDataSetTableAdapters.ActualizacionesGeneralTableAdapter();
            this.dbSAICBPOValidacionDataSet1 = new winAppSAIC.dbSAICBPOValidacionDataSet();
            this.splashSMCargando = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::winAppSAIC.frmxCargandoInformacion), true, true);
            this.stpSelObtenerEstatusNominaSueldosVsTimbradoTableAdapter1 = new winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.stpSelObtenerEstatusNominaSueldosVsTimbradoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOReportesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelReporteNominaAlimentosSC_XLSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelReporteNominaAlimentosSC_XLSBindingNavigator)).BeginInit();
            this.stpSelReporteNominaAlimentosSC_XLSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelReporteNominaAlimentosSC_XLSGridControl)).BeginInit();
            this.cmExportarGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcFolioLoteCargaNomina)).BeginInit();
            this.pcFolioLoteCargaNomina.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.stpSelFolioLoteCargaNominaSCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOValidacionDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dbSAICBPOReportesDataSet
            // 
            this.dbSAICBPOReportesDataSet.DataSetName = "dbSAICBPOReportesDataSet";
            this.dbSAICBPOReportesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stpSelReporteNominaAlimentosSC_XLSBindingSource
            // 
            this.stpSelReporteNominaAlimentosSC_XLSBindingSource.DataMember = "stpSelReporteNominaAlimentosSC_XLS";
            this.stpSelReporteNominaAlimentosSC_XLSBindingSource.DataSource = this.dbSAICBPOReportesDataSet;
            // 
            // stpSelReporteNominaAlimentosSC_XLSTableAdapter
            // 
            this.stpSelReporteNominaAlimentosSC_XLSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.PDOHeaderSATableAdapter = null;
            this.tableAdapterManager.PDOHeaderSCTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // stpSelReporteNominaAlimentosSC_XLSBindingNavigator
            // 
            this.stpSelReporteNominaAlimentosSC_XLSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.stpSelReporteNominaAlimentosSC_XLSBindingNavigator.BindingSource = this.stpSelReporteNominaAlimentosSC_XLSBindingSource;
            this.stpSelReporteNominaAlimentosSC_XLSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.stpSelReporteNominaAlimentosSC_XLSBindingNavigator.CountItemFormat = "de {0}";
            this.stpSelReporteNominaAlimentosSC_XLSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.stpSelReporteNominaAlimentosSC_XLSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.btnExportarXLS,
            this.toolStripSeparator1,
            this.btnCerrarNominaContabilizada,
            this.toolStripSeparator2,
            this.btnSalir});
            this.stpSelReporteNominaAlimentosSC_XLSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.stpSelReporteNominaAlimentosSC_XLSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.stpSelReporteNominaAlimentosSC_XLSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.stpSelReporteNominaAlimentosSC_XLSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.stpSelReporteNominaAlimentosSC_XLSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.stpSelReporteNominaAlimentosSC_XLSBindingNavigator.Name = "stpSelReporteNominaAlimentosSC_XLSBindingNavigator";
            this.stpSelReporteNominaAlimentosSC_XLSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.stpSelReporteNominaAlimentosSC_XLSBindingNavigator.Size = new System.Drawing.Size(934, 25);
            this.stpSelReporteNominaAlimentosSC_XLSBindingNavigator.TabIndex = 0;
            this.stpSelReporteNominaAlimentosSC_XLSBindingNavigator.Text = "bindingNavigator1";
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
            // btnExportarXLS
            // 
            this.btnExportarXLS.Image = global::winAppSAIC.Properties.Resources.xls32x32;
            this.btnExportarXLS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExportarXLS.Name = "btnExportarXLS";
            this.btnExportarXLS.Size = new System.Drawing.Size(138, 22);
            this.btnExportarXLS.Text = "Exportar a Excel (XLS)";
            this.btnExportarXLS.Click += new System.EventHandler(this.btnExportarXLS_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnCerrarNominaContabilizada
            // 
            this.btnCerrarNominaContabilizada.Image = global::winAppSAIC.Properties.Resources._lock;
            this.btnCerrarNominaContabilizada.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCerrarNominaContabilizada.Name = "btnCerrarNominaContabilizada";
            this.btnCerrarNominaContabilizada.Size = new System.Drawing.Size(105, 22);
            this.btnCerrarNominaContabilizada.Text = "Cerrar Nómina";
            this.btnCerrarNominaContabilizada.Click += new System.EventHandler(this.btnCerrarNominaContabilizada_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // stpSelReporteNominaAlimentosSC_XLSGridControl
            // 
            this.stpSelReporteNominaAlimentosSC_XLSGridControl.ContextMenuStrip = this.cmExportarGrid;
            this.stpSelReporteNominaAlimentosSC_XLSGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.stpSelReporteNominaAlimentosSC_XLSGridControl.DataSource = this.stpSelReporteNominaAlimentosSC_XLSBindingSource;
            this.stpSelReporteNominaAlimentosSC_XLSGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stpSelReporteNominaAlimentosSC_XLSGridControl.Location = new System.Drawing.Point(2, 2);
            this.stpSelReporteNominaAlimentosSC_XLSGridControl.MainView = this.gridView1;
            this.stpSelReporteNominaAlimentosSC_XLSGridControl.Name = "stpSelReporteNominaAlimentosSC_XLSGridControl";
            this.stpSelReporteNominaAlimentosSC_XLSGridControl.Size = new System.Drawing.Size(930, 387);
            this.stpSelReporteNominaAlimentosSC_XLSGridControl.TabIndex = 2;
            this.stpSelReporteNominaAlimentosSC_XLSGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // cmExportarGrid
            // 
            this.cmExportarGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarAExcelXLSToolStripMenuItem});
            this.cmExportarGrid.Name = "cmExportarGrid";
            this.cmExportarGrid.Size = new System.Drawing.Size(186, 26);
            // 
            // exportarAExcelXLSToolStripMenuItem
            // 
            this.exportarAExcelXLSToolStripMenuItem.Image = global::winAppSAIC.Properties.Resources.xls32x32;
            this.exportarAExcelXLSToolStripMenuItem.Name = "exportarAExcelXLSToolStripMenuItem";
            this.exportarAExcelXLSToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.exportarAExcelXLSToolStripMenuItem.Text = "Exportar a Excel (XLS)";
            this.exportarAExcelXLSToolStripMenuItem.Click += new System.EventHandler(this.btnExportarXLS_Click);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNombreEmpleado,
            this.colRFCEmpleado,
            this.colCURP,
            this.colSueldoBruto,
            this.colVales,
            this.colPréstamoFonacot,
            this.colInfonavit,
            this.colPensiónAlimenticia,
            this.colPréstamo,
            this.colAnticipoNómina,
            this.colTotalAlimentosBruto,
            this.colPréstamoAgna1,
            this.colPréstamoAgna2,
            this.colMiAdelanto,
            this.colTotalAlimentosNeto,
            this.colTipoCambio,
            this.colIdMoneda,
            this.colTipoPago,
            this.colBancoDestino,
            this.colCostoSocial,
            this.colJubilaciones});
            this.gridView1.GridControl = this.stpSelReporteNominaAlimentosSC_XLSGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsPrint.AutoWidth = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colNombreEmpleado
            // 
            this.colNombreEmpleado.FieldName = "NombreEmpleado";
            this.colNombreEmpleado.Name = "colNombreEmpleado";
            this.colNombreEmpleado.OptionsColumn.AllowEdit = false;
            this.colNombreEmpleado.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colNombreEmpleado.OptionsColumn.AllowMove = false;
            this.colNombreEmpleado.OptionsColumn.AllowShowHide = false;
            this.colNombreEmpleado.OptionsColumn.FixedWidth = true;
            this.colNombreEmpleado.OptionsColumn.ReadOnly = true;
            this.colNombreEmpleado.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "NombreEmpleado", "No. de Empleados: {0:N0}")});
            this.colNombreEmpleado.Visible = true;
            this.colNombreEmpleado.VisibleIndex = 0;
            this.colNombreEmpleado.Width = 250;
            // 
            // colRFCEmpleado
            // 
            this.colRFCEmpleado.Caption = "RFC";
            this.colRFCEmpleado.FieldName = "RFCEmpleado";
            this.colRFCEmpleado.Name = "colRFCEmpleado";
            this.colRFCEmpleado.OptionsColumn.AllowEdit = false;
            this.colRFCEmpleado.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colRFCEmpleado.OptionsColumn.AllowMove = false;
            this.colRFCEmpleado.OptionsColumn.AllowShowHide = false;
            this.colRFCEmpleado.OptionsColumn.FixedWidth = true;
            this.colRFCEmpleado.OptionsColumn.ReadOnly = true;
            this.colRFCEmpleado.Visible = true;
            this.colRFCEmpleado.VisibleIndex = 1;
            this.colRFCEmpleado.Width = 160;
            // 
            // colCURP
            // 
            this.colCURP.FieldName = "CURP";
            this.colCURP.Name = "colCURP";
            this.colCURP.OptionsColumn.AllowEdit = false;
            this.colCURP.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colCURP.OptionsColumn.AllowMove = false;
            this.colCURP.OptionsColumn.AllowShowHide = false;
            this.colCURP.OptionsColumn.FixedWidth = true;
            this.colCURP.OptionsColumn.ReadOnly = true;
            this.colCURP.Visible = true;
            this.colCURP.VisibleIndex = 2;
            this.colCURP.Width = 160;
            // 
            // colSueldoBruto
            // 
            this.colSueldoBruto.DisplayFormat.FormatString = "C2";
            this.colSueldoBruto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSueldoBruto.FieldName = "SueldoBruto";
            this.colSueldoBruto.Name = "colSueldoBruto";
            this.colSueldoBruto.OptionsColumn.AllowEdit = false;
            this.colSueldoBruto.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colSueldoBruto.OptionsColumn.AllowMove = false;
            this.colSueldoBruto.OptionsColumn.AllowShowHide = false;
            this.colSueldoBruto.OptionsColumn.FixedWidth = true;
            this.colSueldoBruto.OptionsColumn.ReadOnly = true;
            this.colSueldoBruto.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SueldoBruto", "{0:C2}")});
            this.colSueldoBruto.Visible = true;
            this.colSueldoBruto.VisibleIndex = 3;
            this.colSueldoBruto.Width = 100;
            // 
            // colVales
            // 
            this.colVales.DisplayFormat.FormatString = "C2";
            this.colVales.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colVales.FieldName = "Vales";
            this.colVales.Name = "colVales";
            this.colVales.OptionsColumn.AllowEdit = false;
            this.colVales.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colVales.OptionsColumn.AllowMove = false;
            this.colVales.OptionsColumn.AllowShowHide = false;
            this.colVales.OptionsColumn.FixedWidth = true;
            this.colVales.OptionsColumn.ReadOnly = true;
            this.colVales.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Vales", "{0:C2}")});
            this.colVales.Visible = true;
            this.colVales.VisibleIndex = 4;
            this.colVales.Width = 85;
            // 
            // colPréstamoFonacot
            // 
            this.colPréstamoFonacot.DisplayFormat.FormatString = "C2";
            this.colPréstamoFonacot.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPréstamoFonacot.FieldName = "Préstamo Fonacot";
            this.colPréstamoFonacot.Name = "colPréstamoFonacot";
            this.colPréstamoFonacot.OptionsColumn.AllowEdit = false;
            this.colPréstamoFonacot.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colPréstamoFonacot.OptionsColumn.AllowMove = false;
            this.colPréstamoFonacot.OptionsColumn.AllowShowHide = false;
            this.colPréstamoFonacot.OptionsColumn.FixedWidth = true;
            this.colPréstamoFonacot.OptionsColumn.ReadOnly = true;
            this.colPréstamoFonacot.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Préstamo Fonacot", "{0:C2}")});
            this.colPréstamoFonacot.Visible = true;
            this.colPréstamoFonacot.VisibleIndex = 5;
            this.colPréstamoFonacot.Width = 110;
            // 
            // colInfonavit
            // 
            this.colInfonavit.DisplayFormat.FormatString = "C2";
            this.colInfonavit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colInfonavit.FieldName = "Infonavit";
            this.colInfonavit.Name = "colInfonavit";
            this.colInfonavit.OptionsColumn.AllowEdit = false;
            this.colInfonavit.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colInfonavit.OptionsColumn.AllowMove = false;
            this.colInfonavit.OptionsColumn.AllowShowHide = false;
            this.colInfonavit.OptionsColumn.FixedWidth = true;
            this.colInfonavit.OptionsColumn.ReadOnly = true;
            this.colInfonavit.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Infonavit", "{0:C2}")});
            this.colInfonavit.Visible = true;
            this.colInfonavit.VisibleIndex = 6;
            this.colInfonavit.Width = 100;
            // 
            // colPensiónAlimenticia
            // 
            this.colPensiónAlimenticia.DisplayFormat.FormatString = "C2";
            this.colPensiónAlimenticia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPensiónAlimenticia.FieldName = "Pensión Alimenticia";
            this.colPensiónAlimenticia.Name = "colPensiónAlimenticia";
            this.colPensiónAlimenticia.OptionsColumn.AllowEdit = false;
            this.colPensiónAlimenticia.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colPensiónAlimenticia.OptionsColumn.AllowMove = false;
            this.colPensiónAlimenticia.OptionsColumn.AllowShowHide = false;
            this.colPensiónAlimenticia.OptionsColumn.FixedWidth = true;
            this.colPensiónAlimenticia.OptionsColumn.ReadOnly = true;
            this.colPensiónAlimenticia.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Pensión Alimenticia", "{0:C2}")});
            this.colPensiónAlimenticia.Visible = true;
            this.colPensiónAlimenticia.VisibleIndex = 7;
            this.colPensiónAlimenticia.Width = 110;
            // 
            // colPréstamo
            // 
            this.colPréstamo.DisplayFormat.FormatString = "C2";
            this.colPréstamo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPréstamo.FieldName = "Préstamo";
            this.colPréstamo.Name = "colPréstamo";
            this.colPréstamo.OptionsColumn.AllowEdit = false;
            this.colPréstamo.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colPréstamo.OptionsColumn.AllowMove = false;
            this.colPréstamo.OptionsColumn.AllowShowHide = false;
            this.colPréstamo.OptionsColumn.FixedWidth = true;
            this.colPréstamo.OptionsColumn.ReadOnly = true;
            this.colPréstamo.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Préstamo", "{0:C2}")});
            this.colPréstamo.Visible = true;
            this.colPréstamo.VisibleIndex = 8;
            this.colPréstamo.Width = 100;
            // 
            // colAnticipoNómina
            // 
            this.colAnticipoNómina.DisplayFormat.FormatString = "C2";
            this.colAnticipoNómina.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAnticipoNómina.FieldName = "Anticipo Nómina";
            this.colAnticipoNómina.Name = "colAnticipoNómina";
            this.colAnticipoNómina.OptionsColumn.AllowEdit = false;
            this.colAnticipoNómina.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colAnticipoNómina.OptionsColumn.AllowMove = false;
            this.colAnticipoNómina.OptionsColumn.AllowShowHide = false;
            this.colAnticipoNómina.OptionsColumn.FixedWidth = true;
            this.colAnticipoNómina.OptionsColumn.ReadOnly = true;
            this.colAnticipoNómina.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Anticipo Nómina", "{0:C2}")});
            this.colAnticipoNómina.Visible = true;
            this.colAnticipoNómina.VisibleIndex = 9;
            this.colAnticipoNómina.Width = 100;
            // 
            // colTotalAlimentosBruto
            // 
            this.colTotalAlimentosBruto.Caption = "Total Pensiones Bruto";
            this.colTotalAlimentosBruto.DisplayFormat.FormatString = "C2";
            this.colTotalAlimentosBruto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalAlimentosBruto.FieldName = "TotalAlimentosBruto";
            this.colTotalAlimentosBruto.Name = "colTotalAlimentosBruto";
            this.colTotalAlimentosBruto.OptionsColumn.AllowEdit = false;
            this.colTotalAlimentosBruto.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colTotalAlimentosBruto.OptionsColumn.AllowMove = false;
            this.colTotalAlimentosBruto.OptionsColumn.AllowShowHide = false;
            this.colTotalAlimentosBruto.OptionsColumn.FixedWidth = true;
            this.colTotalAlimentosBruto.OptionsColumn.ReadOnly = true;
            this.colTotalAlimentosBruto.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalAlimentosBruto", "{0:C2}")});
            this.colTotalAlimentosBruto.Visible = true;
            this.colTotalAlimentosBruto.VisibleIndex = 11;
            this.colTotalAlimentosBruto.Width = 120;
            // 
            // colPréstamoAgna1
            // 
            this.colPréstamoAgna1.DisplayFormat.FormatString = "C2";
            this.colPréstamoAgna1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPréstamoAgna1.FieldName = "Préstamo Agna 1";
            this.colPréstamoAgna1.Name = "colPréstamoAgna1";
            this.colPréstamoAgna1.OptionsColumn.AllowEdit = false;
            this.colPréstamoAgna1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colPréstamoAgna1.OptionsColumn.AllowMove = false;
            this.colPréstamoAgna1.OptionsColumn.AllowShowHide = false;
            this.colPréstamoAgna1.OptionsColumn.FixedWidth = true;
            this.colPréstamoAgna1.OptionsColumn.ReadOnly = true;
            this.colPréstamoAgna1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Préstamo Agna 1", "{0:C2}")});
            this.colPréstamoAgna1.Visible = true;
            this.colPréstamoAgna1.VisibleIndex = 12;
            this.colPréstamoAgna1.Width = 100;
            // 
            // colPréstamoAgna2
            // 
            this.colPréstamoAgna2.DisplayFormat.FormatString = "C2";
            this.colPréstamoAgna2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPréstamoAgna2.FieldName = "Préstamo Agna 2";
            this.colPréstamoAgna2.Name = "colPréstamoAgna2";
            this.colPréstamoAgna2.OptionsColumn.AllowEdit = false;
            this.colPréstamoAgna2.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colPréstamoAgna2.OptionsColumn.AllowMove = false;
            this.colPréstamoAgna2.OptionsColumn.AllowShowHide = false;
            this.colPréstamoAgna2.OptionsColumn.FixedWidth = true;
            this.colPréstamoAgna2.OptionsColumn.ReadOnly = true;
            this.colPréstamoAgna2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Préstamo Agna 2", "{0:C2}")});
            this.colPréstamoAgna2.Visible = true;
            this.colPréstamoAgna2.VisibleIndex = 13;
            this.colPréstamoAgna2.Width = 100;
            // 
            // colMiAdelanto
            // 
            this.colMiAdelanto.DisplayFormat.FormatString = "C2";
            this.colMiAdelanto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMiAdelanto.FieldName = "Mi Adelanto";
            this.colMiAdelanto.Name = "colMiAdelanto";
            this.colMiAdelanto.OptionsColumn.AllowEdit = false;
            this.colMiAdelanto.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colMiAdelanto.OptionsColumn.AllowMove = false;
            this.colMiAdelanto.OptionsColumn.AllowShowHide = false;
            this.colMiAdelanto.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Mi Adelanto", "{0:C2}")});
            this.colMiAdelanto.Visible = true;
            this.colMiAdelanto.VisibleIndex = 14;
            // 
            // colTotalAlimentosNeto
            // 
            this.colTotalAlimentosNeto.Caption = "Total Pensiones Neto";
            this.colTotalAlimentosNeto.DisplayFormat.FormatString = "C2";
            this.colTotalAlimentosNeto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalAlimentosNeto.FieldName = "TotalAlimentosNeto";
            this.colTotalAlimentosNeto.Name = "colTotalAlimentosNeto";
            this.colTotalAlimentosNeto.OptionsColumn.AllowEdit = false;
            this.colTotalAlimentosNeto.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colTotalAlimentosNeto.OptionsColumn.AllowMove = false;
            this.colTotalAlimentosNeto.OptionsColumn.AllowShowHide = false;
            this.colTotalAlimentosNeto.OptionsColumn.FixedWidth = true;
            this.colTotalAlimentosNeto.OptionsColumn.ReadOnly = true;
            this.colTotalAlimentosNeto.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalAlimentosNeto", "{0:C2}")});
            this.colTotalAlimentosNeto.Visible = true;
            this.colTotalAlimentosNeto.VisibleIndex = 15;
            this.colTotalAlimentosNeto.Width = 120;
            // 
            // colTipoCambio
            // 
            this.colTipoCambio.DisplayFormat.FormatString = "C2";
            this.colTipoCambio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTipoCambio.FieldName = "TipoCambio";
            this.colTipoCambio.Name = "colTipoCambio";
            this.colTipoCambio.OptionsColumn.AllowEdit = false;
            this.colTipoCambio.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colTipoCambio.OptionsColumn.AllowMove = false;
            this.colTipoCambio.OptionsColumn.AllowShowHide = false;
            this.colTipoCambio.OptionsColumn.FixedWidth = true;
            this.colTipoCambio.OptionsColumn.ReadOnly = true;
            this.colTipoCambio.Visible = true;
            this.colTipoCambio.VisibleIndex = 17;
            this.colTipoCambio.Width = 70;
            // 
            // colIdMoneda
            // 
            this.colIdMoneda.Caption = "Moneda";
            this.colIdMoneda.FieldName = "IdMoneda";
            this.colIdMoneda.Name = "colIdMoneda";
            this.colIdMoneda.OptionsColumn.AllowEdit = false;
            this.colIdMoneda.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colIdMoneda.OptionsColumn.AllowMove = false;
            this.colIdMoneda.OptionsColumn.AllowShowHide = false;
            this.colIdMoneda.OptionsColumn.FixedWidth = true;
            this.colIdMoneda.OptionsColumn.ReadOnly = true;
            this.colIdMoneda.Visible = true;
            this.colIdMoneda.VisibleIndex = 18;
            // 
            // colTipoPago
            // 
            this.colTipoPago.FieldName = "TipoPago";
            this.colTipoPago.Name = "colTipoPago";
            this.colTipoPago.OptionsColumn.AllowEdit = false;
            this.colTipoPago.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colTipoPago.OptionsColumn.AllowMove = false;
            this.colTipoPago.OptionsColumn.AllowShowHide = false;
            this.colTipoPago.OptionsColumn.FixedWidth = true;
            this.colTipoPago.OptionsColumn.ReadOnly = true;
            this.colTipoPago.Visible = true;
            this.colTipoPago.VisibleIndex = 19;
            this.colTipoPago.Width = 100;
            // 
            // colBancoDestino
            // 
            this.colBancoDestino.FieldName = "BancoDestino";
            this.colBancoDestino.Name = "colBancoDestino";
            this.colBancoDestino.OptionsColumn.AllowEdit = false;
            this.colBancoDestino.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colBancoDestino.OptionsColumn.AllowMove = false;
            this.colBancoDestino.OptionsColumn.AllowShowHide = false;
            this.colBancoDestino.OptionsColumn.FixedWidth = true;
            this.colBancoDestino.OptionsColumn.ReadOnly = true;
            this.colBancoDestino.Visible = true;
            this.colBancoDestino.VisibleIndex = 20;
            this.colBancoDestino.Width = 100;
            // 
            // colCostoSocial
            // 
            this.colCostoSocial.DisplayFormat.FormatString = "C2";
            this.colCostoSocial.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCostoSocial.FieldName = "Costo Social";
            this.colCostoSocial.Name = "colCostoSocial";
            this.colCostoSocial.OptionsColumn.AllowEdit = false;
            this.colCostoSocial.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colCostoSocial.OptionsColumn.ReadOnly = true;
            this.colCostoSocial.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Costo Social", "{0:C2}")});
            this.colCostoSocial.Visible = true;
            this.colCostoSocial.VisibleIndex = 10;
            // 
            // colJubilaciones
            // 
            this.colJubilaciones.DisplayFormat.FormatString = "C2";
            this.colJubilaciones.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colJubilaciones.FieldName = "Jubilaciones";
            this.colJubilaciones.Name = "colJubilaciones";
            this.colJubilaciones.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Jubilaciones", "{0:C2}")});
            this.colJubilaciones.Visible = true;
            this.colJubilaciones.VisibleIndex = 16;
            this.colJubilaciones.Width = 120;
            // 
            // pcFolioLoteCargaNomina
            // 
            this.pcFolioLoteCargaNomina.Controls.Add(this.gcResumenEstatusNominaVsTimbrados);
            this.pcFolioLoteCargaNomina.Controls.Add(this.txtFechaPago);
            this.pcFolioLoteCargaNomina.Controls.Add(this.labelControl6);
            this.pcFolioLoteCargaNomina.Controls.Add(this.chkEstatusNominaContabilizada);
            this.pcFolioLoteCargaNomina.Controls.Add(this.txtPeriodoPago);
            this.pcFolioLoteCargaNomina.Controls.Add(this.txtNombreOperador);
            this.pcFolioLoteCargaNomina.Controls.Add(this.txtTipoNomina);
            this.pcFolioLoteCargaNomina.Controls.Add(this.txtNombreComercialCliente);
            this.pcFolioLoteCargaNomina.Controls.Add(this.txtNombreComercialTenedora);
            this.pcFolioLoteCargaNomina.Controls.Add(this.labelControl5);
            this.pcFolioLoteCargaNomina.Controls.Add(this.labelControl4);
            this.pcFolioLoteCargaNomina.Controls.Add(this.labelControl3);
            this.pcFolioLoteCargaNomina.Controls.Add(this.labelControl2);
            this.pcFolioLoteCargaNomina.Controls.Add(this.labelControl1);
            this.pcFolioLoteCargaNomina.Controls.Add(this.cboFolioLoteCargaNomina);
            this.pcFolioLoteCargaNomina.Controls.Add(this.lblFolio);
            this.pcFolioLoteCargaNomina.Dock = System.Windows.Forms.DockStyle.Top;
            this.pcFolioLoteCargaNomina.Location = new System.Drawing.Point(0, 25);
            this.pcFolioLoteCargaNomina.Name = "pcFolioLoteCargaNomina";
            this.pcFolioLoteCargaNomina.Size = new System.Drawing.Size(934, 173);
            this.pcFolioLoteCargaNomina.TabIndex = 3;
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
            this.gcResumenEstatusNominaVsTimbrados.Location = new System.Drawing.Point(536, 17);
            this.gcResumenEstatusNominaVsTimbrados.Name = "gcResumenEstatusNominaVsTimbrados";
            this.gcResumenEstatusNominaVsTimbrados.Size = new System.Drawing.Size(386, 141);
            this.gcResumenEstatusNominaVsTimbrados.TabIndex = 19;
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
            this.txtFechaPago.Location = new System.Drawing.Point(135, 141);
            this.txtFechaPago.Name = "txtFechaPago";
            this.txtFechaPago.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtFechaPago.Properties.Appearance.Options.UseBackColor = true;
            this.txtFechaPago.Size = new System.Drawing.Size(116, 20);
            this.txtFechaPago.TabIndex = 18;
            this.txtFechaPago.TabStop = false;
            // 
            // labelControl6
            // 
            this.labelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl6.Location = new System.Drawing.Point(73, 145);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(56, 13);
            this.labelControl6.TabIndex = 17;
            this.labelControl6.Text = "Fecha Pago";
            // 
            // chkEstatusNominaContabilizada
            // 
            this.chkEstatusNominaContabilizada.Enabled = false;
            this.chkEstatusNominaContabilizada.Location = new System.Drawing.Point(313, 142);
            this.chkEstatusNominaContabilizada.Name = "chkEstatusNominaContabilizada";
            this.chkEstatusNominaContabilizada.Properties.Caption = "Contabilizada";
            this.chkEstatusNominaContabilizada.Size = new System.Drawing.Size(116, 19);
            this.chkEstatusNominaContabilizada.TabIndex = 14;
            this.chkEstatusNominaContabilizada.TabStop = false;
            // 
            // txtPeriodoPago
            // 
            this.txtPeriodoPago.Enabled = false;
            this.txtPeriodoPago.Location = new System.Drawing.Point(313, 116);
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
            this.txtNombreOperador.Location = new System.Drawing.Point(135, 90);
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
            this.txtTipoNomina.Location = new System.Drawing.Point(135, 116);
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
            this.txtNombreComercialCliente.Location = new System.Drawing.Point(135, 65);
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
            this.txtNombreComercialTenedora.Location = new System.Drawing.Point(135, 40);
            this.txtNombreComercialTenedora.Name = "txtNombreComercialTenedora";
            this.txtNombreComercialTenedora.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtNombreComercialTenedora.Properties.Appearance.Options.UseBackColor = true;
            this.txtNombreComercialTenedora.Size = new System.Drawing.Size(392, 20);
            this.txtNombreComercialTenedora.TabIndex = 5;
            this.txtNombreComercialTenedora.TabStop = false;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(71, 120);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(58, 13);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Tipo Nómina";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(263, 120);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(36, 13);
            this.labelControl4.TabIndex = 12;
            this.labelControl4.Text = "Periodo";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(83, 94);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(46, 13);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Operador";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(96, 69);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(33, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Cliente";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(83, 44);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Tenedora";
            // 
            // cboFolioLoteCargaNomina
            // 
            this.cboFolioLoteCargaNomina.EditValue = "";
            this.cboFolioLoteCargaNomina.Location = new System.Drawing.Point(135, 14);
            this.cboFolioLoteCargaNomina.Name = "cboFolioLoteCargaNomina";
            this.cboFolioLoteCargaNomina.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
            this.cboFolioLoteCargaNomina.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboFolioLoteCargaNomina.Properties.DataSource = this.stpSelFolioLoteCargaNominaSCBindingSource;
            this.cboFolioLoteCargaNomina.Properties.DisplayMember = "FolioLoteCargaNomina";
            this.cboFolioLoteCargaNomina.Properties.NullText = "";
            this.cboFolioLoteCargaNomina.Properties.ValueMember = "IdLoteCargaNomina";
            this.cboFolioLoteCargaNomina.Properties.View = this.gridLookUpEdit1View;
            this.cboFolioLoteCargaNomina.Size = new System.Drawing.Size(250, 20);
            this.cboFolioLoteCargaNomina.TabIndex = 3;
            this.cboFolioLoteCargaNomina.EditValueChanged += new System.EventHandler(this.cboFolioLoteCargaNomina_EditValueChanged);
            // 
            // stpSelFolioLoteCargaNominaSCBindingSource
            // 
            this.stpSelFolioLoteCargaNominaSCBindingSource.DataMember = "stpSelFolioLoteCargaNominaSC";
            this.stpSelFolioLoteCargaNominaSCBindingSource.DataSource = this.dbSAICBPODataSet;
            // 
            // dbSAICBPODataSet
            // 
            this.dbSAICBPODataSet.DataSetName = "dbSAICBPODataSet";
            this.dbSAICBPODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // lblFolio
            // 
            this.lblFolio.Location = new System.Drawing.Point(13, 17);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(116, 13);
            this.lblFolio.TabIndex = 2;
            this.lblFolio.Text = "Folio Lote Carga Nómina";
            // 
            // stpSelFolioLoteCargaNominaSCTableAdapter
            // 
            this.stpSelFolioLoteCargaNominaSCTableAdapter.ClearBeforeFill = true;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.stpSelReporteNominaAlimentosSC_XLSGridControl);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 198);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(934, 391);
            this.panelControl1.TabIndex = 4;
            // 
            // sfdRutaArchivo
            // 
            this.sfdRutaArchivo.Filter = "Archivos de Excel | *.xls";
            this.sfdRutaArchivo.Title = "Guardar como...";
            // 
            // stpSelInfoDetalleLoteCargaNominaTableAdapter1
            // 
            this.stpSelInfoDetalleLoteCargaNominaTableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelValidarLoteCargaNominaEnSolicitudCancelacionNominaTableAdapter1
            // 
            this.stpSelValidarLoteCargaNominaEnSolicitudCancelacionNominaTableAdapter1.ClearBeforeFill = true;
            // 
            // dbSAICBPOValidacionDataSet1
            // 
            this.dbSAICBPOValidacionDataSet1.DataSetName = "dbSAICBPOValidacionDataSet";
            this.dbSAICBPOValidacionDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stpSelObtenerEstatusNominaSueldosVsTimbradoTableAdapter1
            // 
            this.stpSelObtenerEstatusNominaSueldosVsTimbradoTableAdapter1.ClearBeforeFill = true;
            // 
            // frmxDesgloseReporteNominasAlimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 589);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.pcFolioLoteCargaNomina);
            this.Controls.Add(this.stpSelReporteNominaAlimentosSC_XLSBindingNavigator);
            this.Name = "frmxDesgloseReporteNominasAlimentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Nómina S.C. (Detallado) y Cierre de Nómina";
            this.Load += new System.EventHandler(this.frmxDesgloseReporteNominasAlimentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOReportesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelReporteNominaAlimentosSC_XLSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelReporteNominaAlimentosSC_XLSBindingNavigator)).EndInit();
            this.stpSelReporteNominaAlimentosSC_XLSBindingNavigator.ResumeLayout(false);
            this.stpSelReporteNominaAlimentosSC_XLSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelReporteNominaAlimentosSC_XLSGridControl)).EndInit();
            this.cmExportarGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcFolioLoteCargaNomina)).EndInit();
            this.pcFolioLoteCargaNomina.ResumeLayout(false);
            this.pcFolioLoteCargaNomina.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.stpSelFolioLoteCargaNominaSCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOValidacionDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dbSAICBPOReportesDataSet dbSAICBPOReportesDataSet;
        private System.Windows.Forms.BindingSource stpSelReporteNominaAlimentosSC_XLSBindingSource;
        private dbSAICBPOReportesDataSetTableAdapters.stpSelReporteNominaAlimentosSC_XLSTableAdapter stpSelReporteNominaAlimentosSC_XLSTableAdapter;
        private dbSAICBPOReportesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator stpSelReporteNominaAlimentosSC_XLSBindingNavigator;
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
        private DevExpress.XtraGrid.GridControl stpSelReporteNominaAlimentosSC_XLSGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn colRFCEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn colCURP;
        private DevExpress.XtraGrid.Columns.GridColumn colSueldoBruto;
        private DevExpress.XtraGrid.Columns.GridColumn colInfonavit;
        private DevExpress.XtraGrid.Columns.GridColumn colPensiónAlimenticia;
        private DevExpress.XtraGrid.Columns.GridColumn colPréstamoFonacot;
        private DevExpress.XtraGrid.Columns.GridColumn colPréstamo;
        private DevExpress.XtraGrid.Columns.GridColumn colAnticipoNómina;
        private DevExpress.XtraEditors.PanelControl pcFolioLoteCargaNomina;
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
        private dbSAICBPODataSet dbSAICBPODataSet;
        private System.Windows.Forms.BindingSource stpSelFolioLoteCargaNominaSCBindingSource;
        private dbSAICBPODataSetTableAdapters.stpSelFolioLoteCargaNominaSCTableAdapter stpSelFolioLoteCargaNominaSCTableAdapter;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalAlimentosBruto;
        private DevExpress.XtraGrid.Columns.GridColumn colPréstamoAgna1;
        private DevExpress.XtraGrid.Columns.GridColumn colPréstamoAgna2;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalAlimentosNeto;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoCambio;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMoneda;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoPago;
        private DevExpress.XtraGrid.Columns.GridColumn colBancoDestino;
        private System.Windows.Forms.ToolStripButton btnExportarXLS;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnCerrarNominaContabilizada;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.SaveFileDialog sfdRutaArchivo;
        private System.Windows.Forms.ContextMenuStrip cmExportarGrid;
        private System.Windows.Forms.ToolStripMenuItem exportarAExcelXLSToolStripMenuItem;
        private dbSAICBPOReportesDataSetTableAdapters.stpSelInfoDetalleLoteCargaNominaTableAdapter stpSelInfoDetalleLoteCargaNominaTableAdapter1;
        private dbSAICBPOValidacionDataSetTableAdapters.stpSelValidarLoteCargaNominaEnSolicitudCancelacionNominaTableAdapter stpSelValidarLoteCargaNominaEnSolicitudCancelacionNominaTableAdapter1;
        private dbSAICBPOActualizacionesDataSetTableAdapters.ActualizacionesGeneralTableAdapter actualizacionesGeneralTableAdapter1;
        private dbSAICBPOValidacionDataSet dbSAICBPOValidacionDataSet1;
        private DevExpress.XtraEditors.TextEdit txtFechaPago;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraGrid.Columns.GridColumn colVales;
        private DevExpress.XtraGrid.Columns.GridColumn colMiAdelanto;
        private DevExpress.XtraGrid.Columns.GridColumn colCostoSocial;
        private DevExpress.XtraGrid.Columns.GridColumn colJubilaciones;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashSMCargando;
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
        private dbSAICBPOReportesDataSetTableAdapters.stpSelObtenerEstatusNominaSueldosVsTimbradoTableAdapter stpSelObtenerEstatusNominaSueldosVsTimbradoTableAdapter1;
    }
}