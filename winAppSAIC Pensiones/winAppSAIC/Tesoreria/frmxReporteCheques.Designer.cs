namespace winAppSAIC.Tesoreria
{
    partial class frmxReporteCheques
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmxReporteCheques));
            this.dbSAICBPOReportesDataSet = new winAppSAIC.dbSAICBPOReportesDataSet();
            this.tableAdapterManager = new winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.TableAdapterManager();
            this.cmExportarGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportarAExcelXLSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pcFolioLoteCargaNomina = new DevExpress.XtraEditors.PanelControl();
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
            this.btnCancelarSolicitud = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.btnMostrarTodas = new DevExpress.XtraEditors.SimpleButton();
            this.cboOperador = new DevExpress.XtraEditors.GridLookUpEdit();
            this.stpSelOperadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPODataSet = new winAppSAIC.dbSAICBPODataSet();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdOperador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOperador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblFolio = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gvSolicitudChequesMasivos = new DevExpress.XtraGrid.GridControl();
            this.stpSelSolicitudesChequesMasivosReporteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdSolicitudChequeHeader = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdLoteCargaNomina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreComercialTenedora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreComercialCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBancoSolicitado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOperador1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaInicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaFin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescTipoPeriodoNomina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoControl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sfdRutaArchivo = new System.Windows.Forms.SaveFileDialog();
            this.stpSelSolicitudesChequesMasivosReporteTableAdapter = new winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.stpSelSolicitudesChequesMasivosReporteTableAdapter();
            this.stpSelOperadorTableAdapter = new winAppSAIC.dbSAICBPODataSetTableAdapters.stpSelOperadorTableAdapter();
            this.stpSelSolicitudesChequesMasivosReporteDetalleEliminarTableAdapter1 = new winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.stpSelSolicitudesChequesMasivosReporteDetalleEliminarTableAdapter();
            this.stpQueryTableAdapter1 = new winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.stpQueryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOReportesDataSet)).BeginInit();
            this.cmExportarGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcFolioLoteCargaNomina)).BeginInit();
            this.pcFolioLoteCargaNomina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelReporteChequesBindingNavigator)).BeginInit();
            this.stpSelReporteChequesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboOperador.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelOperadorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSolicitudChequesMasivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelSolicitudesChequesMasivosReporteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.pcFolioLoteCargaNomina.Controls.Add(this.stpSelReporteChequesBindingNavigator);
            this.pcFolioLoteCargaNomina.Controls.Add(this.btnMostrarTodas);
            this.pcFolioLoteCargaNomina.Controls.Add(this.cboOperador);
            this.pcFolioLoteCargaNomina.Controls.Add(this.lblFolio);
            this.pcFolioLoteCargaNomina.Dock = System.Windows.Forms.DockStyle.Top;
            this.pcFolioLoteCargaNomina.Location = new System.Drawing.Point(0, 0);
            this.pcFolioLoteCargaNomina.Name = "pcFolioLoteCargaNomina";
            this.pcFolioLoteCargaNomina.Size = new System.Drawing.Size(942, 77);
            this.pcFolioLoteCargaNomina.TabIndex = 1;
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
            this.btnCancelarSolicitud,
            this.toolStripSeparator1,
            this.btnSalir});
            this.stpSelReporteChequesBindingNavigator.Location = new System.Drawing.Point(2, 2);
            this.stpSelReporteChequesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.stpSelReporteChequesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.stpSelReporteChequesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.stpSelReporteChequesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.stpSelReporteChequesBindingNavigator.Name = "stpSelReporteChequesBindingNavigator";
            this.stpSelReporteChequesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.stpSelReporteChequesBindingNavigator.Size = new System.Drawing.Size(938, 25);
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
            // btnCancelarSolicitud
            // 
            this.btnCancelarSolicitud.Image = global::winAppSAIC.Properties.Resources.DocsCancelados32x32_1;
            this.btnCancelarSolicitud.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelarSolicitud.Name = "btnCancelarSolicitud";
            this.btnCancelarSolicitud.Size = new System.Drawing.Size(122, 22);
            this.btnCancelarSolicitud.Text = "Cancelar Solicitud";
            this.btnCancelarSolicitud.Click += new System.EventHandler(this.btnCancelarSolicitud_Click);
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
            // btnMostrarTodas
            // 
            this.btnMostrarTodas.Location = new System.Drawing.Point(759, 34);
            this.btnMostrarTodas.Name = "btnMostrarTodas";
            this.btnMostrarTodas.Size = new System.Drawing.Size(158, 30);
            this.btnMostrarTodas.TabIndex = 21;
            this.btnMostrarTodas.Text = "Mostrar todas las Solicitudes";
            this.btnMostrarTodas.Click += new System.EventHandler(this.btnMostrarTodas_Click);
            // 
            // cboOperador
            // 
            this.cboOperador.EditValue = "";
            this.cboOperador.Location = new System.Drawing.Point(91, 40);
            this.cboOperador.Name = "cboOperador";
            this.cboOperador.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
            this.cboOperador.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboOperador.Properties.DataSource = this.stpSelOperadorBindingSource;
            this.cboOperador.Properties.DisplayMember = "NombreCompletoOperador";
            this.cboOperador.Properties.NullText = "";
            this.cboOperador.Properties.ValueMember = "IdOperador";
            this.cboOperador.Properties.View = this.gridLookUpEdit1View;
            this.cboOperador.Size = new System.Drawing.Size(250, 20);
            this.cboOperador.TabIndex = 3;
            this.cboOperador.EditValueChanged += new System.EventHandler(this.cboFolioLoteCargaNomina_EditValueChanged);
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
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdOperador,
            this.colOperador});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsCustomization.AllowGroup = false;
            this.gridLookUpEdit1View.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridLookUpEdit1View.OptionsCustomization.AllowSort = false;
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdOperador
            // 
            this.colIdOperador.Caption = "gridColumn2";
            this.colIdOperador.FieldName = "IdOperador";
            this.colIdOperador.Name = "colIdOperador";
            // 
            // colOperador
            // 
            this.colOperador.FieldName = "NombreCompletoOperador";
            this.colOperador.Name = "colOperador";
            this.colOperador.Visible = true;
            this.colOperador.VisibleIndex = 0;
            this.colOperador.Width = 150;
            // 
            // lblFolio
            // 
            this.lblFolio.Location = new System.Drawing.Point(35, 43);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(46, 13);
            this.lblFolio.TabIndex = 2;
            this.lblFolio.Text = "Operador";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gvSolicitudChequesMasivos);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 77);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(942, 485);
            this.panelControl1.TabIndex = 10;
            // 
            // gvSolicitudChequesMasivos
            // 
            this.gvSolicitudChequesMasivos.DataSource = this.stpSelSolicitudesChequesMasivosReporteBindingSource;
            this.gvSolicitudChequesMasivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvSolicitudChequesMasivos.Location = new System.Drawing.Point(2, 2);
            this.gvSolicitudChequesMasivos.MainView = this.gridView1;
            this.gvSolicitudChequesMasivos.Name = "gvSolicitudChequesMasivos";
            this.gvSolicitudChequesMasivos.Size = new System.Drawing.Size(938, 481);
            this.gvSolicitudChequesMasivos.TabIndex = 5;
            this.gvSolicitudChequesMasivos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gvSolicitudChequesMasivos.DoubleClick += new System.EventHandler(this.gvSolicitudChequesMasivos_DoubleClick);
            // 
            // stpSelSolicitudesChequesMasivosReporteBindingSource
            // 
            this.stpSelSolicitudesChequesMasivosReporteBindingSource.DataMember = "stpSelSolicitudesChequesMasivosReporte";
            this.stpSelSolicitudesChequesMasivosReporteBindingSource.DataSource = this.dbSAICBPOReportesDataSet;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdSolicitudChequeHeader,
            this.colIdLoteCargaNomina,
            this.colNombreComercialTenedora,
            this.colNombreComercialCliente,
            this.colBancoSolicitado,
            this.colOperador1,
            this.colFechaInicio,
            this.colFechaFin,
            this.colDescTipoPeriodoNomina,
            this.colNoControl,
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
            // colIdSolicitudChequeHeader
            // 
            this.colIdSolicitudChequeHeader.AppearanceCell.Options.UseTextOptions = true;
            this.colIdSolicitudChequeHeader.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIdSolicitudChequeHeader.Caption = "Solicitud No.";
            this.colIdSolicitudChequeHeader.FieldName = "IdSolicitudChequeHeader";
            this.colIdSolicitudChequeHeader.Name = "colIdSolicitudChequeHeader";
            this.colIdSolicitudChequeHeader.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "IdSolicitudChequeHeader", "No. Solicitudes: {0}")});
            this.colIdSolicitudChequeHeader.Visible = true;
            this.colIdSolicitudChequeHeader.VisibleIndex = 0;
            this.colIdSolicitudChequeHeader.Width = 100;
            // 
            // colIdLoteCargaNomina
            // 
            this.colIdLoteCargaNomina.Caption = "Lote Nómina";
            this.colIdLoteCargaNomina.FieldName = "IdLoteCargaNomina";
            this.colIdLoteCargaNomina.Name = "colIdLoteCargaNomina";
            this.colIdLoteCargaNomina.Visible = true;
            this.colIdLoteCargaNomina.VisibleIndex = 2;
            // 
            // colNombreComercialTenedora
            // 
            this.colNombreComercialTenedora.Caption = "Tenedora";
            this.colNombreComercialTenedora.FieldName = "NombreComercialTenedora";
            this.colNombreComercialTenedora.Name = "colNombreComercialTenedora";
            this.colNombreComercialTenedora.Visible = true;
            this.colNombreComercialTenedora.VisibleIndex = 4;
            this.colNombreComercialTenedora.Width = 200;
            // 
            // colNombreComercialCliente
            // 
            this.colNombreComercialCliente.Caption = "Cliente";
            this.colNombreComercialCliente.FieldName = "NombreComercialCliente";
            this.colNombreComercialCliente.Name = "colNombreComercialCliente";
            this.colNombreComercialCliente.Visible = true;
            this.colNombreComercialCliente.VisibleIndex = 5;
            this.colNombreComercialCliente.Width = 200;
            // 
            // colBancoSolicitado
            // 
            this.colBancoSolicitado.FieldName = "BancoSolicitado";
            this.colBancoSolicitado.Name = "colBancoSolicitado";
            this.colBancoSolicitado.Visible = true;
            this.colBancoSolicitado.VisibleIndex = 6;
            this.colBancoSolicitado.Width = 150;
            // 
            // colOperador1
            // 
            this.colOperador1.Caption = "Operador";
            this.colOperador1.FieldName = "Operador";
            this.colOperador1.Name = "colOperador1";
            this.colOperador1.Visible = true;
            this.colOperador1.VisibleIndex = 7;
            this.colOperador1.Width = 150;
            // 
            // colFechaInicio
            // 
            this.colFechaInicio.FieldName = "FechaInicio";
            this.colFechaInicio.Name = "colFechaInicio";
            this.colFechaInicio.Visible = true;
            this.colFechaInicio.VisibleIndex = 8;
            // 
            // colFechaFin
            // 
            this.colFechaFin.FieldName = "FechaFin";
            this.colFechaFin.Name = "colFechaFin";
            this.colFechaFin.Visible = true;
            this.colFechaFin.VisibleIndex = 9;
            // 
            // colDescTipoPeriodoNomina
            // 
            this.colDescTipoPeriodoNomina.Caption = "Tipo Nómina";
            this.colDescTipoPeriodoNomina.FieldName = "DescTipoPeriodoNomina";
            this.colDescTipoPeriodoNomina.Name = "colDescTipoPeriodoNomina";
            this.colDescTipoPeriodoNomina.Visible = true;
            this.colDescTipoPeriodoNomina.VisibleIndex = 3;
            this.colDescTipoPeriodoNomina.Width = 100;
            // 
            // colNoControl
            // 
            this.colNoControl.AppearanceCell.Options.UseTextOptions = true;
            this.colNoControl.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNoControl.Caption = "No. Control Orden Pago";
            this.colNoControl.FieldName = "NoControl";
            this.colNoControl.Name = "colNoControl";
            this.colNoControl.Visible = true;
            this.colNoControl.VisibleIndex = 1;
            this.colNoControl.Width = 130;
            // 
            // colEstatus
            // 
            this.colEstatus.Caption = "Estatus";
            this.colEstatus.FieldName = "DescEstatus";
            this.colEstatus.Name = "colEstatus";
            this.colEstatus.Visible = true;
            this.colEstatus.VisibleIndex = 10;
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
            // stpSelSolicitudesChequesMasivosReporteDetalleEliminarTableAdapter1
            // 
            this.stpSelSolicitudesChequesMasivosReporteDetalleEliminarTableAdapter1.ClearBeforeFill = true;
            // 
            // frmxReporteCheques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 562);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.pcFolioLoteCargaNomina);
            this.Name = "frmxReporteCheques";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Solicitud de Cheques";
            this.Load += new System.EventHandler(this.frmxReporteCheques_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOReportesDataSet)).EndInit();
            this.cmExportarGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcFolioLoteCargaNomina)).EndInit();
            this.pcFolioLoteCargaNomina.ResumeLayout(false);
            this.pcFolioLoteCargaNomina.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelReporteChequesBindingNavigator)).EndInit();
            this.stpSelReporteChequesBindingNavigator.ResumeLayout(false);
            this.stpSelReporteChequesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboOperador.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelOperadorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvSolicitudChequesMasivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelSolicitudesChequesMasivosReporteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private dbSAICBPOReportesDataSet dbSAICBPOReportesDataSet;
        private dbSAICBPOReportesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.PanelControl pcFolioLoteCargaNomina;
        private DevExpress.XtraEditors.GridLookUpEdit cboOperador;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colOperador;
        private DevExpress.XtraEditors.LabelControl lblFolio;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ContextMenuStrip cmExportarGrid;
        private System.Windows.Forms.ToolStripMenuItem exportarAExcelXLSToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog sfdRutaArchivo;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashSMCargando;
        private DevExpress.XtraEditors.SimpleButton btnMostrarTodas;
        private DevExpress.XtraGrid.GridControl gvSolicitudChequesMasivos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSolicitudChequeHeader;
        private DevExpress.XtraGrid.Columns.GridColumn colIdLoteCargaNomina;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreComercialTenedora;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreComercialCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colBancoSolicitado;
        private DevExpress.XtraGrid.Columns.GridColumn colOperador1;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaInicio;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaFin;
        private DevExpress.XtraGrid.Columns.GridColumn colDescTipoPeriodoNomina;
        private DevExpress.XtraGrid.Columns.GridColumn colNoControl;
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
        private DevExpress.XtraGrid.Columns.GridColumn colIdOperador;
        private DevExpress.XtraGrid.Columns.GridColumn colEstatus;
        private System.Windows.Forms.ToolStripButton btnCancelarSolicitud;
        private dbSAICBPOReportesDataSetTableAdapters.stpSelSolicitudesChequesMasivosReporteDetalleEliminarTableAdapter stpSelSolicitudesChequesMasivosReporteDetalleEliminarTableAdapter1;
        private dbSAICBPOReportesDataSetTableAdapters.stpQueryTableAdapter stpQueryTableAdapter1;
    }
}