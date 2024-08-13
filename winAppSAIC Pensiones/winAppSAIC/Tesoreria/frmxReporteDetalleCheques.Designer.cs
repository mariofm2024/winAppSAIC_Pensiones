namespace winAppSAIC.Tesoreria
{
    partial class frmxReporteDetalleCheques
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmxReporteDetalleCheques));
            this.dbSAICBPOReportesDataSet = new winAppSAIC.dbSAICBPOReportesDataSet();
            this.tableAdapterManager = new winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.TableAdapterManager();
            this.cmExportarGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportarAExcelXLSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pcFolioLoteCargaNomina = new DevExpress.XtraEditors.PanelControl();
            this.txtNoControl = new System.Windows.Forms.TextBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtBanco = new System.Windows.Forms.TextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenedora = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtLote = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtIdSolicitud = new System.Windows.Forms.TextBox();
            this.stpSelReporteChequesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.lblFolio = new DevExpress.XtraEditors.LabelControl();
            this.stpSelOperadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPODataSet = new winAppSAIC.dbSAICBPODataSet();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gvSolicitudChequesMasivos = new DevExpress.XtraGrid.GridControl();
            this.stpSelSolicitudesChequesMasivosReporteDetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdTransaccionCheque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSolicitudChequeHeader = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoCheque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMonto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBancoSolicitado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBancoAsignado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.stpSelSolicitudesChequesMasivosReporteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sfdRutaArchivo = new System.Windows.Forms.SaveFileDialog();
            this.stpSelSolicitudesChequesMasivosReporteTableAdapter = new winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.stpSelSolicitudesChequesMasivosReporteTableAdapter();
            this.stpSelOperadorTableAdapter = new winAppSAIC.dbSAICBPODataSetTableAdapters.stpSelOperadorTableAdapter();
            this.stpSelSolicitudesChequesMasivosReporteDetalleTableAdapter = new winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.stpSelSolicitudesChequesMasivosReporteDetalleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOReportesDataSet)).BeginInit();
            this.cmExportarGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcFolioLoteCargaNomina)).BeginInit();
            this.pcFolioLoteCargaNomina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelReporteChequesBindingNavigator)).BeginInit();
            this.stpSelReporteChequesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelOperadorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSolicitudChequesMasivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelSolicitudesChequesMasivosReporteDetalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelSolicitudesChequesMasivosReporteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dbSAICBPOReportesDataSet
            // 
            this.dbSAICBPOReportesDataSet.DataSetName = "dbSAICBPOReportesDataSet";
            this.dbSAICBPOReportesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.PDOHeaderSATableAdapter = null;
            this.tableAdapterManager.PDOHeaderSCTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.exportarAExcelXLSToolStripMenuItem.Click += new System.EventHandler(this.exportarAExcelXLSToolStripMenuItem_Click);
            // 
            // pcFolioLoteCargaNomina
            // 
            this.pcFolioLoteCargaNomina.Controls.Add(this.txtNoControl);
            this.pcFolioLoteCargaNomina.Controls.Add(this.labelControl5);
            this.pcFolioLoteCargaNomina.Controls.Add(this.txtBanco);
            this.pcFolioLoteCargaNomina.Controls.Add(this.labelControl4);
            this.pcFolioLoteCargaNomina.Controls.Add(this.txtCliente);
            this.pcFolioLoteCargaNomina.Controls.Add(this.labelControl3);
            this.pcFolioLoteCargaNomina.Controls.Add(this.txtTenedora);
            this.pcFolioLoteCargaNomina.Controls.Add(this.labelControl2);
            this.pcFolioLoteCargaNomina.Controls.Add(this.txtLote);
            this.pcFolioLoteCargaNomina.Controls.Add(this.labelControl1);
            this.pcFolioLoteCargaNomina.Controls.Add(this.txtIdSolicitud);
            this.pcFolioLoteCargaNomina.Controls.Add(this.stpSelReporteChequesBindingNavigator);
            this.pcFolioLoteCargaNomina.Controls.Add(this.lblFolio);
            this.pcFolioLoteCargaNomina.Dock = System.Windows.Forms.DockStyle.Top;
            this.pcFolioLoteCargaNomina.Location = new System.Drawing.Point(0, 0);
            this.pcFolioLoteCargaNomina.Name = "pcFolioLoteCargaNomina";
            this.pcFolioLoteCargaNomina.Size = new System.Drawing.Size(915, 101);
            this.pcFolioLoteCargaNomina.TabIndex = 1;
            // 
            // txtNoControl
            // 
            this.txtNoControl.Enabled = false;
            this.txtNoControl.Location = new System.Drawing.Point(458, 40);
            this.txtNoControl.Name = "txtNoControl";
            this.txtNoControl.Size = new System.Drawing.Size(100, 21);
            this.txtNoControl.TabIndex = 33;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(397, 43);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(55, 13);
            this.labelControl5.TabIndex = 32;
            this.labelControl5.Text = "No. Control";
            // 
            // txtBanco
            // 
            this.txtBanco.Enabled = false;
            this.txtBanco.Location = new System.Drawing.Point(637, 40);
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.Size = new System.Drawing.Size(100, 21);
            this.txtBanco.TabIndex = 31;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(602, 43);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(29, 13);
            this.labelControl4.TabIndex = 30;
            this.labelControl4.Text = "Banco";
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Location = new System.Drawing.Point(458, 67);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(279, 21);
            this.txtCliente.TabIndex = 29;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(419, 70);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(33, 13);
            this.labelControl3.TabIndex = 28;
            this.labelControl3.Text = "Cliente";
            // 
            // txtTenedora
            // 
            this.txtTenedora.Enabled = false;
            this.txtTenedora.Location = new System.Drawing.Point(100, 67);
            this.txtTenedora.Name = "txtTenedora";
            this.txtTenedora.Size = new System.Drawing.Size(279, 21);
            this.txtTenedora.TabIndex = 27;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(48, 70);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 13);
            this.labelControl2.TabIndex = 26;
            this.labelControl2.Text = "Tenedora";
            // 
            // txtLote
            // 
            this.txtLote.Enabled = false;
            this.txtLote.Location = new System.Drawing.Point(267, 40);
            this.txtLote.Name = "txtLote";
            this.txtLote.Size = new System.Drawing.Size(112, 21);
            this.txtLote.TabIndex = 25;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(240, 43);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(21, 13);
            this.labelControl1.TabIndex = 24;
            this.labelControl1.Text = "Lote";
            // 
            // txtIdSolicitud
            // 
            this.txtIdSolicitud.Enabled = false;
            this.txtIdSolicitud.Location = new System.Drawing.Point(100, 40);
            this.txtIdSolicitud.Name = "txtIdSolicitud";
            this.txtIdSolicitud.Size = new System.Drawing.Size(112, 21);
            this.txtIdSolicitud.TabIndex = 23;
            // 
            // stpSelReporteChequesBindingNavigator
            // 
            this.stpSelReporteChequesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.stpSelReporteChequesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.stpSelReporteChequesBindingNavigator.CountItemFormat = "de {0}";
            this.stpSelReporteChequesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.stpSelReporteChequesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.btnSalir});
            this.stpSelReporteChequesBindingNavigator.Location = new System.Drawing.Point(2, 2);
            this.stpSelReporteChequesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.stpSelReporteChequesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.stpSelReporteChequesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.stpSelReporteChequesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.stpSelReporteChequesBindingNavigator.Name = "stpSelReporteChequesBindingNavigator";
            this.stpSelReporteChequesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.stpSelReporteChequesBindingNavigator.Size = new System.Drawing.Size(911, 25);
            this.stpSelReporteChequesBindingNavigator.TabIndex = 22;
            this.stpSelReporteChequesBindingNavigator.Text = "bindingNavigator1";
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
            // btnSalir
            // 
            this.btnSalir.Image = global::winAppSAIC.Properties.Resources.Salir24x24;
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(49, 22);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // lblFolio
            // 
            this.lblFolio.Location = new System.Drawing.Point(35, 43);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(59, 13);
            this.lblFolio.TabIndex = 2;
            this.lblFolio.Text = "Solicitud No.";
            // 
            // stpSelOperadorBindingSource
            // 
            this.stpSelOperadorBindingSource.DataMember = "stpSelOperador";
            this.stpSelOperadorBindingSource.DataSource = this.dbSAICBPODataSet;
            // 
            // dbSAICBPODataSet
            // 
            this.dbSAICBPODataSet.DataSetName = "dbSAICBPODataSet";
            this.dbSAICBPODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gvSolicitudChequesMasivos);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 101);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(915, 463);
            this.panelControl1.TabIndex = 10;
            // 
            // gvSolicitudChequesMasivos
            // 
            this.gvSolicitudChequesMasivos.DataSource = this.stpSelSolicitudesChequesMasivosReporteDetalleBindingSource;
            this.gvSolicitudChequesMasivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvSolicitudChequesMasivos.Location = new System.Drawing.Point(2, 2);
            this.gvSolicitudChequesMasivos.MainView = this.gridView1;
            this.gvSolicitudChequesMasivos.Name = "gvSolicitudChequesMasivos";
            this.gvSolicitudChequesMasivos.Size = new System.Drawing.Size(911, 459);
            this.gvSolicitudChequesMasivos.TabIndex = 5;
            this.gvSolicitudChequesMasivos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // stpSelSolicitudesChequesMasivosReporteDetalleBindingSource
            // 
            this.stpSelSolicitudesChequesMasivosReporteDetalleBindingSource.DataMember = "stpSelSolicitudesChequesMasivosReporteDetalle";
            this.stpSelSolicitudesChequesMasivosReporteDetalleBindingSource.DataSource = this.dbSAICBPOReportesDataSet;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdTransaccionCheque,
            this.colIdSolicitudChequeHeader,
            this.colIdEmpleado,
            this.colNombre,
            this.colNoCheque,
            this.colMonto,
            this.colBancoSolicitado,
            this.colBancoAsignado,
            this.ColTipo,
            this.colEstatus});
            this.gridView1.GridControl = this.gvSolicitudChequesMasivos;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIdTransaccionCheque
            // 
            this.colIdTransaccionCheque.Caption = "No. Control Cheque";
            this.colIdTransaccionCheque.FieldName = "IdSolicitudChequeDetail";
            this.colIdTransaccionCheque.Name = "colIdTransaccionCheque";
            this.colIdTransaccionCheque.Visible = true;
            this.colIdTransaccionCheque.VisibleIndex = 0;
            this.colIdTransaccionCheque.Width = 67;
            // 
            // colIdSolicitudChequeHeader
            // 
            this.colIdSolicitudChequeHeader.AppearanceCell.Options.UseTextOptions = true;
            this.colIdSolicitudChequeHeader.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIdSolicitudChequeHeader.Caption = "Solicitud No.";
            this.colIdSolicitudChequeHeader.FieldName = "IdSolicitudChequeHeader";
            this.colIdSolicitudChequeHeader.Name = "colIdSolicitudChequeHeader";
            this.colIdSolicitudChequeHeader.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "IdSolicitudChequeHeader", "No. Solicitudes: {0}")});
            this.colIdSolicitudChequeHeader.Width = 100;
            // 
            // colIdEmpleado
            // 
            this.colIdEmpleado.Caption = "No. Empleado";
            this.colIdEmpleado.FieldName = "IdEmpleado";
            this.colIdEmpleado.Name = "colIdEmpleado";
            this.colIdEmpleado.Visible = true;
            this.colIdEmpleado.VisibleIndex = 2;
            this.colIdEmpleado.Width = 70;
            // 
            // colNombre
            // 
            this.colNombre.Caption = "Nombre";
            this.colNombre.FieldName = "NombreBeneficiarioTransaccionBanco";
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 3;
            this.colNombre.Width = 230;
            // 
            // colNoCheque
            // 
            this.colNoCheque.Caption = "No. Cheque";
            this.colNoCheque.FieldName = "NoTransaccion";
            this.colNoCheque.Name = "colNoCheque";
            this.colNoCheque.Visible = true;
            this.colNoCheque.VisibleIndex = 1;
            this.colNoCheque.Width = 76;
            // 
            // colMonto
            // 
            this.colMonto.Caption = "Monto Cheque";
            this.colMonto.DisplayFormat.FormatString = "N2";
            this.colMonto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMonto.FieldName = "MontoTransaccionRetiro";
            this.colMonto.Name = "colMonto";
            this.colMonto.Visible = true;
            this.colMonto.VisibleIndex = 4;
            this.colMonto.Width = 98;
            // 
            // colBancoSolicitado
            // 
            this.colBancoSolicitado.Caption = "Banco Solicitado";
            this.colBancoSolicitado.FieldName = "BancoSolicitado";
            this.colBancoSolicitado.Name = "colBancoSolicitado";
            this.colBancoSolicitado.Visible = true;
            this.colBancoSolicitado.VisibleIndex = 5;
            this.colBancoSolicitado.Width = 74;
            // 
            // colBancoAsignado
            // 
            this.colBancoAsignado.Caption = "Banco Asignado";
            this.colBancoAsignado.FieldName = "NombreCuentaBanco";
            this.colBancoAsignado.Name = "colBancoAsignado";
            this.colBancoAsignado.Visible = true;
            this.colBancoAsignado.VisibleIndex = 6;
            this.colBancoAsignado.Width = 97;
            // 
            // ColTipo
            // 
            this.ColTipo.Caption = "Tipo de Pago";
            this.ColTipo.FieldName = "DescTipoPeriodoNomina";
            this.ColTipo.Name = "ColTipo";
            this.ColTipo.Visible = true;
            this.ColTipo.VisibleIndex = 7;
            // 
            // colEstatus
            // 
            this.colEstatus.Caption = "Estatus";
            this.colEstatus.FieldName = "DescEstatus";
            this.colEstatus.Name = "colEstatus";
            this.colEstatus.Visible = true;
            this.colEstatus.VisibleIndex = 8;
            this.colEstatus.Width = 114;
            // 
            // stpSelSolicitudesChequesMasivosReporteBindingSource
            // 
            this.stpSelSolicitudesChequesMasivosReporteBindingSource.DataMember = "stpSelSolicitudesChequesMasivosReporte";
            this.stpSelSolicitudesChequesMasivosReporteBindingSource.DataSource = this.dbSAICBPOReportesDataSet;
            // 
            // sfdRutaArchivo
            // 
            this.sfdRutaArchivo.Filter = "Archivos de Excel | *.xls";
            this.sfdRutaArchivo.Title = "Guardar como...";
            // 
            // stpSelSolicitudesChequesMasivosReporteTableAdapter
            // 
            this.stpSelSolicitudesChequesMasivosReporteTableAdapter.ClearBeforeFill = true;
            // 
            // stpSelOperadorTableAdapter
            // 
            this.stpSelOperadorTableAdapter.ClearBeforeFill = true;
            // 
            // stpSelSolicitudesChequesMasivosReporteDetalleTableAdapter
            // 
            this.stpSelSolicitudesChequesMasivosReporteDetalleTableAdapter.ClearBeforeFill = true;
            // 
            // frmxReporteDetalleCheques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 564);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.pcFolioLoteCargaNomina);
            this.Name = "frmxReporteDetalleCheques";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Detalle Solicitud de Cheques";
            this.Load += new System.EventHandler(this.frmxReporteDetalleCheques_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOReportesDataSet)).EndInit();
            this.cmExportarGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcFolioLoteCargaNomina)).EndInit();
            this.pcFolioLoteCargaNomina.ResumeLayout(false);
            this.pcFolioLoteCargaNomina.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelReporteChequesBindingNavigator)).EndInit();
            this.stpSelReporteChequesBindingNavigator.ResumeLayout(false);
            this.stpSelReporteChequesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelOperadorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvSolicitudChequesMasivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelSolicitudesChequesMasivosReporteDetalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelSolicitudesChequesMasivosReporteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private dbSAICBPOReportesDataSet dbSAICBPOReportesDataSet;
        private dbSAICBPOReportesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.PanelControl pcFolioLoteCargaNomina;
        private DevExpress.XtraEditors.LabelControl lblFolio;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ContextMenuStrip cmExportarGrid;
        private System.Windows.Forms.ToolStripMenuItem exportarAExcelXLSToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog sfdRutaArchivo;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashSMCargando;
        private DevExpress.XtraGrid.GridControl gvSolicitudChequesMasivos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSolicitudChequeHeader;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn colNoCheque;
        private DevExpress.XtraGrid.Columns.GridColumn colMonto;
        private System.Windows.Forms.BindingNavigator stpSelReporteChequesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton btnExportarXLS;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.BindingSource stpSelSolicitudesChequesMasivosReporteBindingSource;
        private dbSAICBPOReportesDataSetTableAdapters.stpSelSolicitudesChequesMasivosReporteTableAdapter stpSelSolicitudesChequesMasivosReporteTableAdapter;
        private dbSAICBPODataSet dbSAICBPODataSet;
        private System.Windows.Forms.BindingSource stpSelOperadorBindingSource;
        private dbSAICBPODataSetTableAdapters.stpSelOperadorTableAdapter stpSelOperadorTableAdapter;
        private System.Windows.Forms.TextBox txtLote;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox txtIdSolicitud;
        private System.Windows.Forms.TextBox txtTenedora;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox txtBanco;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.TextBox txtCliente;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.TextBox txtNoControl;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTransaccionCheque;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn ColTipo;
        private System.Windows.Forms.BindingSource stpSelSolicitudesChequesMasivosReporteDetalleBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colBancoSolicitado;
        private DevExpress.XtraGrid.Columns.GridColumn colEstatus;
        private dbSAICBPOReportesDataSetTableAdapters.stpSelSolicitudesChequesMasivosReporteDetalleTableAdapter stpSelSolicitudesChequesMasivosReporteDetalleTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colBancoAsignado;
    }
}