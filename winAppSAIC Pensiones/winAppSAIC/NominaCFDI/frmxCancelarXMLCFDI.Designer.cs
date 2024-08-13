namespace winAppSAIC.NominaCFDI
{
    partial class frmxCancelarXMLCFDI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmxCancelarXMLCFDI));
            this.dbSAICBPONominaCFDIDataSet = new winAppSAIC.NominaCFDI.dbSAICBPONominaCFDIDataSet();
            this.tableAdapterManager = new winAppSAIC.NominaCFDI.dbSAICBPONominaCFDIDataSetTableAdapters.TableAdapterManager();
            this.stpSelFolioLoteCargaNominaTimbradosCFDIBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.stpSelInfoCancelacionDetalleLoteCargaNominaTimbradosCFDIBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.btnCancelarXML = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExportarXLS = new System.Windows.Forms.ToolStripButton();
            this.btnFiltrar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminarFiltro = new System.Windows.Forms.ToolStripButton();
            this.stpSelFolioLoteCargaNominaTimbradosCFDIBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.stpSelFolioLoteCargaNominaTimbradosCFDIGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdPDOHeaderCFDI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSerie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFolioInterno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAPaternoEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAMaternoEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNSS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRFC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCURP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMontoPagado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFolioFiscalUUID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pcInformacionNomina = new DevExpress.XtraEditors.PanelControl();
            this.dtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtFechaIni = new System.Windows.Forms.DateTimePicker();
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
            this.pcBotonesChkList = new DevExpress.XtraEditors.PanelControl();
            this.btnDeseleccionarTodo = new DevExpress.XtraEditors.SimpleButton();
            this.btnSeleccionarTodos = new DevExpress.XtraEditors.SimpleButton();
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
            this.stpSelFolioLoteCargaNominaTimbradosCFDIv2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenedora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOperador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTenedora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblFolio = new DevExpress.XtraEditors.LabelControl();
            this.pcSerieFolios = new DevExpress.XtraEditors.PanelControl();
            this.chkListNominas = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.pcGridview = new DevExpress.XtraEditors.PanelControl();
            this.stpSelInfoDetalleLoteCargaNominaTableAdapter1 = new winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.stpSelInfoDetalleLoteCargaNominaTableAdapter();
            this.seguridadTableAdapter1 = new winAppSAIC.NominaCFDI.dbSAICBPONominaCFDIDataSetTableAdapters.SeguridadTableAdapter();
            this.stpSelInfoCancelacionDetalleLoteCargaNominaTimbradosCFDITableAdapter = new winAppSAIC.NominaCFDI.dbSAICBPONominaCFDIDataSetTableAdapters.stpSelInfoCancelacionDetalleLoteCargaNominaTimbradosCFDITableAdapter();
            this.stpSelObtenerEstatusNominaSueldosVsTimbradoTableAdapter1 = new winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.stpSelObtenerEstatusNominaSueldosVsTimbradoTableAdapter();
            this.sfdRutaArchivo = new System.Windows.Forms.SaveFileDialog();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::winAppSAIC.frmxCargandoInformacion), true, true);
            this.splashScreenManager2 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::winAppSAIC.frmxCargandoInformacion), true, true);
            this.stpSelFolioLoteCargaNominaTimbradosCFDIv2TableAdapter = new winAppSAIC.NominaCFDI.dbSAICBPONominaCFDIDataSetTableAdapters.stpSelFolioLoteCargaNominaTimbradosCFDIv2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPONominaCFDIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelFolioLoteCargaNominaTimbradosCFDIBindingNavigator)).BeginInit();
            this.stpSelFolioLoteCargaNominaTimbradosCFDIBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelInfoCancelacionDetalleLoteCargaNominaTimbradosCFDIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelFolioLoteCargaNominaTimbradosCFDIGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcInformacionNomina)).BeginInit();
            this.pcInformacionNomina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcResumenEstatusNominaVsTimbrados)).BeginInit();
            this.gcResumenEstatusNominaVsTimbrados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBotonesChkList)).BeginInit();
            this.pcBotonesChkList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFechaPago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEstatusNominaContabilizada.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodoPago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreOperador.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoNomina.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreComercialCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreComercialTenedora.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFolioLoteCargaNomina.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelFolioLoteCargaNominaTimbradosCFDIv2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcSerieFolios)).BeginInit();
            this.pcSerieFolios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkListNominas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcGridview)).BeginInit();
            this.pcGridview.SuspendLayout();
            this.SuspendLayout();
            // 
            // dbSAICBPONominaCFDIDataSet
            // 
            this.dbSAICBPONominaCFDIDataSet.DataSetName = "dbSAICBPONominaCFDIDataSet";
            this.dbSAICBPONominaCFDIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = winAppSAIC.NominaCFDI.dbSAICBPONominaCFDIDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // stpSelFolioLoteCargaNominaTimbradosCFDIBindingNavigator
            // 
            this.stpSelFolioLoteCargaNominaTimbradosCFDIBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.stpSelFolioLoteCargaNominaTimbradosCFDIBindingNavigator.BindingSource = this.stpSelInfoCancelacionDetalleLoteCargaNominaTimbradosCFDIBindingSource;
            this.stpSelFolioLoteCargaNominaTimbradosCFDIBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.stpSelFolioLoteCargaNominaTimbradosCFDIBindingNavigator.CountItemFormat = "de {0}";
            this.stpSelFolioLoteCargaNominaTimbradosCFDIBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.stpSelFolioLoteCargaNominaTimbradosCFDIBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.btnCancelarXML,
            this.bindingNavigatorDeleteItem,
            this.toolStripSeparator1,
            this.btnExportarXLS,
            this.btnFiltrar,
            this.btnEliminarFiltro,
            this.stpSelFolioLoteCargaNominaTimbradosCFDIBindingNavigatorSaveItem,
            this.toolStripSeparator2,
            this.btnSalir});
            this.stpSelFolioLoteCargaNominaTimbradosCFDIBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.stpSelFolioLoteCargaNominaTimbradosCFDIBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.stpSelFolioLoteCargaNominaTimbradosCFDIBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.stpSelFolioLoteCargaNominaTimbradosCFDIBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.stpSelFolioLoteCargaNominaTimbradosCFDIBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.stpSelFolioLoteCargaNominaTimbradosCFDIBindingNavigator.Name = "stpSelFolioLoteCargaNominaTimbradosCFDIBindingNavigator";
            this.stpSelFolioLoteCargaNominaTimbradosCFDIBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.stpSelFolioLoteCargaNominaTimbradosCFDIBindingNavigator.Size = new System.Drawing.Size(944, 25);
            this.stpSelFolioLoteCargaNominaTimbradosCFDIBindingNavigator.TabIndex = 0;
            this.stpSelFolioLoteCargaNominaTimbradosCFDIBindingNavigator.Text = "bindingNavigator1";
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
            // stpSelInfoCancelacionDetalleLoteCargaNominaTimbradosCFDIBindingSource
            // 
            this.stpSelInfoCancelacionDetalleLoteCargaNominaTimbradosCFDIBindingSource.DataMember = "stpSelInfoCancelacionDetalleLoteCargaNominaTimbradosCFDI";
            this.stpSelInfoCancelacionDetalleLoteCargaNominaTimbradosCFDIBindingSource.DataSource = this.dbSAICBPONominaCFDIDataSet;
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
            // btnCancelarXML
            // 
            this.btnCancelarXML.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancelarXML.Image = global::winAppSAIC.Properties.Resources.CancelApproval_32x32;
            this.btnCancelarXML.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelarXML.Name = "btnCancelarXML";
            this.btnCancelarXML.Size = new System.Drawing.Size(131, 22);
            this.btnCancelarXML.Text = "Cancelar XML CFDI";
            this.btnCancelarXML.Click += new System.EventHandler(this.btnCancelarXML_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnExportarXLS
            // 
            this.btnExportarXLS.Image = global::winAppSAIC.Properties.Resources.xls32x32;
            this.btnExportarXLS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExportarXLS.Name = "btnExportarXLS";
            this.btnExportarXLS.Size = new System.Drawing.Size(140, 22);
            this.btnExportarXLS.Text = "Exportar a Excel (XLS)";
            this.btnExportarXLS.Click += new System.EventHandler(this.btnExportarXLS_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Image = global::winAppSAIC.Properties.Resources.Verificar;
            this.btnFiltrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(57, 22);
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnEliminarFiltro
            // 
            this.btnEliminarFiltro.Image = global::winAppSAIC.Properties.Resources.VerificarErrores;
            this.btnEliminarFiltro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminarFiltro.Name = "btnEliminarFiltro";
            this.btnEliminarFiltro.Size = new System.Drawing.Size(100, 22);
            this.btnEliminarFiltro.Text = "Eliminar Filtro";
            this.btnEliminarFiltro.Click += new System.EventHandler(this.btnEliminarFiltro_Click);
            // 
            // stpSelFolioLoteCargaNominaTimbradosCFDIBindingNavigatorSaveItem
            // 
            this.stpSelFolioLoteCargaNominaTimbradosCFDIBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stpSelFolioLoteCargaNominaTimbradosCFDIBindingNavigatorSaveItem.Enabled = false;
            this.stpSelFolioLoteCargaNominaTimbradosCFDIBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("stpSelFolioLoteCargaNominaTimbradosCFDIBindingNavigatorSaveItem.Image")));
            this.stpSelFolioLoteCargaNominaTimbradosCFDIBindingNavigatorSaveItem.Name = "stpSelFolioLoteCargaNominaTimbradosCFDIBindingNavigatorSaveItem";
            this.stpSelFolioLoteCargaNominaTimbradosCFDIBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.stpSelFolioLoteCargaNominaTimbradosCFDIBindingNavigatorSaveItem.Text = "Save Data";
            this.stpSelFolioLoteCargaNominaTimbradosCFDIBindingNavigatorSaveItem.Visible = false;
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
            // stpSelFolioLoteCargaNominaTimbradosCFDIGridControl
            // 
            this.stpSelFolioLoteCargaNominaTimbradosCFDIGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.stpSelFolioLoteCargaNominaTimbradosCFDIGridControl.DataSource = this.stpSelInfoCancelacionDetalleLoteCargaNominaTimbradosCFDIBindingSource;
            this.stpSelFolioLoteCargaNominaTimbradosCFDIGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stpSelFolioLoteCargaNominaTimbradosCFDIGridControl.Location = new System.Drawing.Point(2, 2);
            this.stpSelFolioLoteCargaNominaTimbradosCFDIGridControl.MainView = this.gridView1;
            this.stpSelFolioLoteCargaNominaTimbradosCFDIGridControl.Name = "stpSelFolioLoteCargaNominaTimbradosCFDIGridControl";
            this.stpSelFolioLoteCargaNominaTimbradosCFDIGridControl.Size = new System.Drawing.Size(940, 222);
            this.stpSelFolioLoteCargaNominaTimbradosCFDIGridControl.TabIndex = 1;
            this.stpSelFolioLoteCargaNominaTimbradosCFDIGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdPDOHeaderCFDI,
            this.colSerie,
            this.colFolioInterno,
            this.colIdEmpleado,
            this.colAPaternoEmpleado,
            this.colAMaternoEmpleado,
            this.colNombreEmpleado,
            this.colNSS,
            this.colRFC,
            this.colCURP,
            this.colMontoPagado,
            this.colFolioFiscalUUID});
            this.gridView1.GridControl = this.stpSelFolioLoteCargaNominaTimbradosCFDIGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // colIdPDOHeaderCFDI
            // 
            this.colIdPDOHeaderCFDI.Caption = "No. Control SAIC";
            this.colIdPDOHeaderCFDI.FieldName = "IdPDOHeaderCFDI";
            this.colIdPDOHeaderCFDI.Name = "colIdPDOHeaderCFDI";
            this.colIdPDOHeaderCFDI.OptionsColumn.ReadOnly = true;
            this.colIdPDOHeaderCFDI.Visible = true;
            this.colIdPDOHeaderCFDI.VisibleIndex = 0;
            this.colIdPDOHeaderCFDI.Width = 103;
            // 
            // colSerie
            // 
            this.colSerie.Caption = "Serie";
            this.colSerie.FieldName = "SerieRecibo";
            this.colSerie.Name = "colSerie";
            this.colSerie.Visible = true;
            this.colSerie.VisibleIndex = 1;
            this.colSerie.Width = 55;
            // 
            // colFolioInterno
            // 
            this.colFolioInterno.Caption = "Folio";
            this.colFolioInterno.FieldName = "FolioRecibo";
            this.colFolioInterno.Name = "colFolioInterno";
            this.colFolioInterno.Visible = true;
            this.colFolioInterno.VisibleIndex = 2;
            this.colFolioInterno.Width = 65;
            // 
            // colIdEmpleado
            // 
            this.colIdEmpleado.Caption = "No. Empleado";
            this.colIdEmpleado.FieldName = "NoEmpleado";
            this.colIdEmpleado.Name = "colIdEmpleado";
            this.colIdEmpleado.Visible = true;
            this.colIdEmpleado.VisibleIndex = 3;
            this.colIdEmpleado.Width = 85;
            // 
            // colAPaternoEmpleado
            // 
            this.colAPaternoEmpleado.Caption = "Apellido Paterno";
            this.colAPaternoEmpleado.FieldName = "APaternoEmpleado";
            this.colAPaternoEmpleado.Name = "colAPaternoEmpleado";
            this.colAPaternoEmpleado.Visible = true;
            this.colAPaternoEmpleado.VisibleIndex = 4;
            this.colAPaternoEmpleado.Width = 130;
            // 
            // colAMaternoEmpleado
            // 
            this.colAMaternoEmpleado.Caption = "Apellido Materno";
            this.colAMaternoEmpleado.FieldName = "AMaternoEmpleado";
            this.colAMaternoEmpleado.Name = "colAMaternoEmpleado";
            this.colAMaternoEmpleado.Visible = true;
            this.colAMaternoEmpleado.VisibleIndex = 5;
            this.colAMaternoEmpleado.Width = 130;
            // 
            // colNombreEmpleado
            // 
            this.colNombreEmpleado.Caption = "Nombre";
            this.colNombreEmpleado.FieldName = "NombreEmpleado";
            this.colNombreEmpleado.Name = "colNombreEmpleado";
            this.colNombreEmpleado.Visible = true;
            this.colNombreEmpleado.VisibleIndex = 6;
            this.colNombreEmpleado.Width = 130;
            // 
            // colNSS
            // 
            this.colNSS.FieldName = "NSS";
            this.colNSS.Name = "colNSS";
            this.colNSS.Visible = true;
            this.colNSS.VisibleIndex = 7;
            this.colNSS.Width = 114;
            // 
            // colRFC
            // 
            this.colRFC.FieldName = "RFC";
            this.colRFC.Name = "colRFC";
            this.colRFC.Visible = true;
            this.colRFC.VisibleIndex = 8;
            this.colRFC.Width = 114;
            // 
            // colCURP
            // 
            this.colCURP.FieldName = "CURP";
            this.colCURP.Name = "colCURP";
            this.colCURP.Visible = true;
            this.colCURP.VisibleIndex = 9;
            this.colCURP.Width = 114;
            // 
            // colMontoPagado
            // 
            this.colMontoPagado.Caption = "Monto Pagado";
            this.colMontoPagado.DisplayFormat.FormatString = "N2";
            this.colMontoPagado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMontoPagado.FieldName = "MontoPagado";
            this.colMontoPagado.Name = "colMontoPagado";
            this.colMontoPagado.Visible = true;
            this.colMontoPagado.VisibleIndex = 10;
            this.colMontoPagado.Width = 100;
            // 
            // colFolioFiscalUUID
            // 
            this.colFolioFiscalUUID.FieldName = "FolioFiscalUUID";
            this.colFolioFiscalUUID.Name = "colFolioFiscalUUID";
            this.colFolioFiscalUUID.Visible = true;
            this.colFolioFiscalUUID.VisibleIndex = 11;
            this.colFolioFiscalUUID.Width = 250;
            // 
            // pcInformacionNomina
            // 
            this.pcInformacionNomina.Controls.Add(this.dtFechaFin);
            this.pcInformacionNomina.Controls.Add(this.label2);
            this.pcInformacionNomina.Controls.Add(this.label4);
            this.pcInformacionNomina.Controls.Add(this.dtFechaIni);
            this.pcInformacionNomina.Controls.Add(this.gcResumenEstatusNominaVsTimbrados);
            this.pcInformacionNomina.Controls.Add(this.pcBotonesChkList);
            this.pcInformacionNomina.Controls.Add(this.txtFechaPago);
            this.pcInformacionNomina.Controls.Add(this.labelControl6);
            this.pcInformacionNomina.Controls.Add(this.chkEstatusNominaContabilizada);
            this.pcInformacionNomina.Controls.Add(this.txtPeriodoPago);
            this.pcInformacionNomina.Controls.Add(this.txtNombreOperador);
            this.pcInformacionNomina.Controls.Add(this.txtTipoNomina);
            this.pcInformacionNomina.Controls.Add(this.txtNombreComercialCliente);
            this.pcInformacionNomina.Controls.Add(this.txtNombreComercialTenedora);
            this.pcInformacionNomina.Controls.Add(this.labelControl5);
            this.pcInformacionNomina.Controls.Add(this.labelControl4);
            this.pcInformacionNomina.Controls.Add(this.labelControl3);
            this.pcInformacionNomina.Controls.Add(this.labelControl2);
            this.pcInformacionNomina.Controls.Add(this.labelControl1);
            this.pcInformacionNomina.Controls.Add(this.cboFolioLoteCargaNomina);
            this.pcInformacionNomina.Controls.Add(this.lblFolio);
            this.pcInformacionNomina.Dock = System.Windows.Forms.DockStyle.Top;
            this.pcInformacionNomina.Location = new System.Drawing.Point(0, 25);
            this.pcInformacionNomina.Name = "pcInformacionNomina";
            this.pcInformacionNomina.Size = new System.Drawing.Size(944, 232);
            this.pcInformacionNomina.TabIndex = 2;
            // 
            // dtFechaFin
            // 
            this.dtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaFin.Location = new System.Drawing.Point(345, 8);
            this.dtFechaFin.Name = "dtFechaFin";
            this.dtFechaFin.Size = new System.Drawing.Size(114, 21);
            this.dtFechaFin.TabIndex = 103;
            this.dtFechaFin.Tag = "Fecha de Pago";
            this.dtFechaFin.Value = new System.DateTime(2018, 6, 4, 10, 45, 4, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 104;
            this.label2.Text = "Fecha de Fin:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 102;
            this.label4.Text = "Fecha de Inicio:";
            // 
            // dtFechaIni
            // 
            this.dtFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaIni.Location = new System.Drawing.Point(135, 8);
            this.dtFechaIni.Name = "dtFechaIni";
            this.dtFechaIni.Size = new System.Drawing.Size(114, 21);
            this.dtFechaIni.TabIndex = 101;
            this.dtFechaIni.Tag = "Fecha de Pago";
            this.dtFechaIni.Value = new System.DateTime(2018, 6, 4, 10, 44, 56, 0);
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
            this.gcResumenEstatusNominaVsTimbrados.Location = new System.Drawing.Point(548, 36);
            this.gcResumenEstatusNominaVsTimbrados.Name = "gcResumenEstatusNominaVsTimbrados";
            this.gcResumenEstatusNominaVsTimbrados.Size = new System.Drawing.Size(386, 141);
            this.gcResumenEstatusNominaVsTimbrados.TabIndex = 48;
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
            // pcBotonesChkList
            // 
            this.pcBotonesChkList.Appearance.BackColor = System.Drawing.Color.SkyBlue;
            this.pcBotonesChkList.Appearance.Options.UseBackColor = true;
            this.pcBotonesChkList.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pcBotonesChkList.Controls.Add(this.btnDeseleccionarTodo);
            this.pcBotonesChkList.Controls.Add(this.btnSeleccionarTodos);
            this.pcBotonesChkList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pcBotonesChkList.Location = new System.Drawing.Point(2, 197);
            this.pcBotonesChkList.Name = "pcBotonesChkList";
            this.pcBotonesChkList.Size = new System.Drawing.Size(940, 33);
            this.pcBotonesChkList.TabIndex = 47;
            // 
            // btnDeseleccionarTodo
            // 
            this.btnDeseleccionarTodo.Location = new System.Drawing.Point(404, 5);
            this.btnDeseleccionarTodo.Name = "btnDeseleccionarTodo";
            this.btnDeseleccionarTodo.Size = new System.Drawing.Size(121, 23);
            this.btnDeseleccionarTodo.TabIndex = 20;
            this.btnDeseleccionarTodo.Text = "Deseleccionar Todo";
            this.btnDeseleccionarTodo.Click += new System.EventHandler(this.btnDeseleccionarTodo_Click);
            // 
            // btnSeleccionarTodos
            // 
            this.btnSeleccionarTodos.Location = new System.Drawing.Point(292, 5);
            this.btnSeleccionarTodos.Name = "btnSeleccionarTodos";
            this.btnSeleccionarTodos.Size = new System.Drawing.Size(106, 23);
            this.btnSeleccionarTodos.TabIndex = 19;
            this.btnSeleccionarTodos.Text = "Seleccionar Todo";
            this.btnSeleccionarTodos.Click += new System.EventHandler(this.btnSeleccionarTodos_Click);
            // 
            // txtFechaPago
            // 
            this.txtFechaPago.Enabled = false;
            this.txtFechaPago.Location = new System.Drawing.Point(135, 160);
            this.txtFechaPago.Name = "txtFechaPago";
            this.txtFechaPago.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtFechaPago.Properties.Appearance.Options.UseBackColor = true;
            this.txtFechaPago.Size = new System.Drawing.Size(116, 20);
            this.txtFechaPago.TabIndex = 45;
            this.txtFechaPago.TabStop = false;
            // 
            // labelControl6
            // 
            this.labelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl6.Location = new System.Drawing.Point(73, 164);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(56, 13);
            this.labelControl6.TabIndex = 44;
            this.labelControl6.Text = "Fecha Pago";
            // 
            // chkEstatusNominaContabilizada
            // 
            this.chkEstatusNominaContabilizada.Enabled = false;
            this.chkEstatusNominaContabilizada.Location = new System.Drawing.Point(305, 161);
            this.chkEstatusNominaContabilizada.Name = "chkEstatusNominaContabilizada";
            this.chkEstatusNominaContabilizada.Properties.Caption = "Contabilizada";
            this.chkEstatusNominaContabilizada.Size = new System.Drawing.Size(116, 19);
            this.chkEstatusNominaContabilizada.TabIndex = 46;
            this.chkEstatusNominaContabilizada.TabStop = false;
            // 
            // txtPeriodoPago
            // 
            this.txtPeriodoPago.Enabled = false;
            this.txtPeriodoPago.Location = new System.Drawing.Point(305, 135);
            this.txtPeriodoPago.Name = "txtPeriodoPago";
            this.txtPeriodoPago.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtPeriodoPago.Properties.Appearance.Options.UseBackColor = true;
            this.txtPeriodoPago.Size = new System.Drawing.Size(150, 20);
            this.txtPeriodoPago.TabIndex = 43;
            this.txtPeriodoPago.TabStop = false;
            // 
            // txtNombreOperador
            // 
            this.txtNombreOperador.Enabled = false;
            this.txtNombreOperador.Location = new System.Drawing.Point(135, 111);
            this.txtNombreOperador.Name = "txtNombreOperador";
            this.txtNombreOperador.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtNombreOperador.Properties.Appearance.Options.UseBackColor = true;
            this.txtNombreOperador.Size = new System.Drawing.Size(392, 20);
            this.txtNombreOperador.TabIndex = 39;
            this.txtNombreOperador.TabStop = false;
            // 
            // txtTipoNomina
            // 
            this.txtTipoNomina.Enabled = false;
            this.txtTipoNomina.Location = new System.Drawing.Point(135, 135);
            this.txtTipoNomina.Name = "txtTipoNomina";
            this.txtTipoNomina.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtTipoNomina.Properties.Appearance.Options.UseBackColor = true;
            this.txtTipoNomina.Size = new System.Drawing.Size(116, 20);
            this.txtTipoNomina.TabIndex = 41;
            this.txtTipoNomina.TabStop = false;
            // 
            // txtNombreComercialCliente
            // 
            this.txtNombreComercialCliente.Enabled = false;
            this.txtNombreComercialCliente.Location = new System.Drawing.Point(135, 86);
            this.txtNombreComercialCliente.Name = "txtNombreComercialCliente";
            this.txtNombreComercialCliente.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtNombreComercialCliente.Properties.Appearance.Options.UseBackColor = true;
            this.txtNombreComercialCliente.Size = new System.Drawing.Size(392, 20);
            this.txtNombreComercialCliente.TabIndex = 37;
            this.txtNombreComercialCliente.TabStop = false;
            // 
            // txtNombreComercialTenedora
            // 
            this.txtNombreComercialTenedora.Enabled = false;
            this.txtNombreComercialTenedora.Location = new System.Drawing.Point(135, 61);
            this.txtNombreComercialTenedora.Name = "txtNombreComercialTenedora";
            this.txtNombreComercialTenedora.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtNombreComercialTenedora.Properties.Appearance.Options.UseBackColor = true;
            this.txtNombreComercialTenedora.Size = new System.Drawing.Size(392, 20);
            this.txtNombreComercialTenedora.TabIndex = 35;
            this.txtNombreComercialTenedora.TabStop = false;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(71, 139);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(58, 13);
            this.labelControl5.TabIndex = 40;
            this.labelControl5.Text = "Tipo Nómina";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(263, 139);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(36, 13);
            this.labelControl4.TabIndex = 42;
            this.labelControl4.Text = "Periodo";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(83, 115);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(46, 13);
            this.labelControl3.TabIndex = 38;
            this.labelControl3.Text = "Operador";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(96, 90);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(33, 13);
            this.labelControl2.TabIndex = 36;
            this.labelControl2.Text = "Cliente";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(83, 65);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 13);
            this.labelControl1.TabIndex = 34;
            this.labelControl1.Text = "Tenedora";
            // 
            // cboFolioLoteCargaNomina
            // 
            this.cboFolioLoteCargaNomina.EditValue = "";
            this.cboFolioLoteCargaNomina.Location = new System.Drawing.Point(135, 35);
            this.cboFolioLoteCargaNomina.Name = "cboFolioLoteCargaNomina";
            this.cboFolioLoteCargaNomina.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
            this.cboFolioLoteCargaNomina.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboFolioLoteCargaNomina.Properties.DataSource = this.stpSelFolioLoteCargaNominaTimbradosCFDIv2BindingSource;
            this.cboFolioLoteCargaNomina.Properties.DisplayMember = "FolioLoteCargaNomina";
            this.cboFolioLoteCargaNomina.Properties.NullText = "";
            this.cboFolioLoteCargaNomina.Properties.ValueMember = "IdLoteCargaNomina";
            this.cboFolioLoteCargaNomina.Properties.View = this.gridLookUpEdit1View;
            this.cboFolioLoteCargaNomina.Size = new System.Drawing.Size(250, 20);
            this.cboFolioLoteCargaNomina.TabIndex = 33;
            this.cboFolioLoteCargaNomina.EditValueChanged += new System.EventHandler(this.cboFolioLoteCargaNomina_EditValueChanged);
            // 
            // stpSelFolioLoteCargaNominaTimbradosCFDIv2BindingSource
            // 
            this.stpSelFolioLoteCargaNominaTimbradosCFDIv2BindingSource.DataMember = "stpSelFolioLoteCargaNominaTimbradosCFDIv2";
            this.stpSelFolioLoteCargaNominaTimbradosCFDIv2BindingSource.DataSource = this.dbSAICBPONominaCFDIDataSet;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn3,
            this.colTenedora,
            this.colCliente,
            this.colOperador,
            this.colIdTenedora});
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
            this.gridColumn2.Width = 65;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Folio Lote Carga Nómina";
            this.gridColumn3.FieldName = "FolioLoteCargaNomina";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 144;
            // 
            // colTenedora
            // 
            this.colTenedora.Caption = "Tenedora";
            this.colTenedora.FieldName = "Tenedora";
            this.colTenedora.Name = "colTenedora";
            this.colTenedora.Visible = true;
            this.colTenedora.VisibleIndex = 2;
            this.colTenedora.Width = 232;
            // 
            // colCliente
            // 
            this.colCliente.Caption = "Cliente";
            this.colCliente.FieldName = "Cliente";
            this.colCliente.Name = "colCliente";
            this.colCliente.Visible = true;
            this.colCliente.VisibleIndex = 3;
            this.colCliente.Width = 325;
            // 
            // colOperador
            // 
            this.colOperador.FieldName = "Operador";
            this.colOperador.Name = "colOperador";
            this.colOperador.Visible = true;
            this.colOperador.VisibleIndex = 4;
            this.colOperador.Width = 296;
            // 
            // colIdTenedora
            // 
            this.colIdTenedora.FieldName = "IdTenedora";
            this.colIdTenedora.Name = "colIdTenedora";
            // 
            // lblFolio
            // 
            this.lblFolio.Location = new System.Drawing.Point(13, 38);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(116, 13);
            this.lblFolio.TabIndex = 32;
            this.lblFolio.Text = "Folio Lote Carga Nómina";
            // 
            // pcSerieFolios
            // 
            this.pcSerieFolios.Controls.Add(this.chkListNominas);
            this.pcSerieFolios.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pcSerieFolios.Location = new System.Drawing.Point(0, 483);
            this.pcSerieFolios.Name = "pcSerieFolios";
            this.pcSerieFolios.Size = new System.Drawing.Size(944, 179);
            this.pcSerieFolios.TabIndex = 3;
            // 
            // chkListNominas
            // 
            this.chkListNominas.Appearance.BorderColor = System.Drawing.Color.Blue;
            this.chkListNominas.Appearance.Options.UseBorderColor = true;
            this.chkListNominas.CheckOnClick = true;
            this.chkListNominas.DataSource = this.stpSelInfoCancelacionDetalleLoteCargaNominaTimbradosCFDIBindingSource;
            this.chkListNominas.DisplayMember = "IdPDOHeaderCFDI";
            this.chkListNominas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkListNominas.HorizontalScrollbar = true;
            this.chkListNominas.Location = new System.Drawing.Point(2, 2);
            this.chkListNominas.MultiColumn = true;
            this.chkListNominas.Name = "chkListNominas";
            this.chkListNominas.Size = new System.Drawing.Size(940, 175);
            this.chkListNominas.TabIndex = 6;
            this.chkListNominas.ValueMember = "IdPDOHeaderCFDI";
            this.chkListNominas.DrawItem += new DevExpress.XtraEditors.ListBoxDrawItemEventHandler(this.chkListNominas_DrawItem);
            // 
            // pcGridview
            // 
            this.pcGridview.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pcGridview.Appearance.Options.UseBackColor = true;
            this.pcGridview.Controls.Add(this.stpSelFolioLoteCargaNominaTimbradosCFDIGridControl);
            this.pcGridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcGridview.Location = new System.Drawing.Point(0, 257);
            this.pcGridview.Name = "pcGridview";
            this.pcGridview.Size = new System.Drawing.Size(944, 226);
            this.pcGridview.TabIndex = 4;
            // 
            // stpSelInfoDetalleLoteCargaNominaTableAdapter1
            // 
            this.stpSelInfoDetalleLoteCargaNominaTableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelInfoCancelacionDetalleLoteCargaNominaTimbradosCFDITableAdapter
            // 
            this.stpSelInfoCancelacionDetalleLoteCargaNominaTimbradosCFDITableAdapter.ClearBeforeFill = true;
            // 
            // stpSelObtenerEstatusNominaSueldosVsTimbradoTableAdapter1
            // 
            this.stpSelObtenerEstatusNominaSueldosVsTimbradoTableAdapter1.ClearBeforeFill = true;
            // 
            // sfdRutaArchivo
            // 
            this.sfdRutaArchivo.Filter = "Archivos de Excel | *.xls";
            this.sfdRutaArchivo.Title = "Guardar como...";
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // splashScreenManager2
            // 
            this.splashScreenManager2.ClosingDelay = 500;
            // 
            // stpSelFolioLoteCargaNominaTimbradosCFDIv2TableAdapter
            // 
            this.stpSelFolioLoteCargaNominaTimbradosCFDIv2TableAdapter.ClearBeforeFill = true;
            // 
            // frmxCancelarXMLCFDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 662);
            this.ControlBox = false;
            this.Controls.Add(this.pcGridview);
            this.Controls.Add(this.pcSerieFolios);
            this.Controls.Add(this.pcInformacionNomina);
            this.Controls.Add(this.stpSelFolioLoteCargaNominaTimbradosCFDIBindingNavigator);
            this.Name = "frmxCancelarXMLCFDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancelar Timbrado XML CFDI";
            this.Load += new System.EventHandler(this.frmxCancelarXMLCFDI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPONominaCFDIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelFolioLoteCargaNominaTimbradosCFDIBindingNavigator)).EndInit();
            this.stpSelFolioLoteCargaNominaTimbradosCFDIBindingNavigator.ResumeLayout(false);
            this.stpSelFolioLoteCargaNominaTimbradosCFDIBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelInfoCancelacionDetalleLoteCargaNominaTimbradosCFDIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelFolioLoteCargaNominaTimbradosCFDIGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcInformacionNomina)).EndInit();
            this.pcInformacionNomina.ResumeLayout(false);
            this.pcInformacionNomina.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcResumenEstatusNominaVsTimbrados)).EndInit();
            this.gcResumenEstatusNominaVsTimbrados.ResumeLayout(false);
            this.gcResumenEstatusNominaVsTimbrados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBotonesChkList)).EndInit();
            this.pcBotonesChkList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtFechaPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEstatusNominaContabilizada.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodoPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreOperador.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoNomina.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreComercialCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreComercialTenedora.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFolioLoteCargaNomina.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelFolioLoteCargaNominaTimbradosCFDIv2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcSerieFolios)).EndInit();
            this.pcSerieFolios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkListNominas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcGridview)).EndInit();
            this.pcGridview.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dbSAICBPONominaCFDIDataSet dbSAICBPONominaCFDIDataSet;
        private dbSAICBPONominaCFDIDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator stpSelFolioLoteCargaNominaTimbradosCFDIBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton stpSelFolioLoteCargaNominaTimbradosCFDIBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl stpSelFolioLoteCargaNominaTimbradosCFDIGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl pcInformacionNomina;
        private DevExpress.XtraEditors.PanelControl pcSerieFolios;
        private DevExpress.XtraEditors.PanelControl pcGridview;
        private DevExpress.XtraEditors.TextEdit txtFechaPago;
        private DevExpress.XtraEditors.LabelControl labelControl6;
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
        private DevExpress.XtraEditors.CheckedListBoxControl chkListNominas;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPDOHeaderCFDI;
        private DevExpress.XtraGrid.Columns.GridColumn colAPaternoEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn colAMaternoEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn colNSS;
        private DevExpress.XtraGrid.Columns.GridColumn colRFC;
        private DevExpress.XtraGrid.Columns.GridColumn colCURP;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn colMontoPagado;
        private DevExpress.XtraGrid.Columns.GridColumn colFolioInterno;
        private DevExpress.XtraGrid.Columns.GridColumn colFolioFiscalUUID;
        private DevExpress.XtraGrid.Columns.GridColumn colSerie;
        private dbSAICBPOReportesDataSetTableAdapters.stpSelInfoDetalleLoteCargaNominaTableAdapter stpSelInfoDetalleLoteCargaNominaTableAdapter1;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private DevExpress.XtraEditors.PanelControl pcBotonesChkList;
        private DevExpress.XtraEditors.SimpleButton btnDeseleccionarTodo;
        private DevExpress.XtraEditors.SimpleButton btnSeleccionarTodos;
        private System.Windows.Forms.ToolStripButton btnCancelarXML;
        private dbSAICBPONominaCFDIDataSetTableAdapters.SeguridadTableAdapter seguridadTableAdapter1;
        private System.Windows.Forms.BindingSource stpSelInfoCancelacionDetalleLoteCargaNominaTimbradosCFDIBindingSource;
        private dbSAICBPONominaCFDIDataSetTableAdapters.stpSelInfoCancelacionDetalleLoteCargaNominaTimbradosCFDITableAdapter stpSelInfoCancelacionDetalleLoteCargaNominaTimbradosCFDITableAdapter;
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnExportarXLS;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.SaveFileDialog sfdRutaArchivo;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashSMProcesando;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashSMCargando;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager2;
        private System.Windows.Forms.ToolStripButton btnFiltrar;
        private System.Windows.Forms.ToolStripButton btnEliminarFiltro;
        private System.Windows.Forms.DateTimePicker dtFechaFin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtFechaIni;
        private System.Windows.Forms.BindingSource stpSelFolioLoteCargaNominaTimbradosCFDIv2BindingSource;
        private dbSAICBPONominaCFDIDataSetTableAdapters.stpSelFolioLoteCargaNominaTimbradosCFDIv2TableAdapter stpSelFolioLoteCargaNominaTimbradosCFDIv2TableAdapter;
    }
}