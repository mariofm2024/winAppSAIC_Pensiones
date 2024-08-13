namespace winAppSAIC.NominaCFDI
{
    partial class frmxAsignarNomina2XMLCFDI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmxAsignarNomina2XMLCFDI));
            this.dbSAICBPONominaCFDIDataSet = new winAppSAIC.NominaCFDI.dbSAICBPONominaCFDIDataSet();
            this.stpSelNominaCFDIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stpSelNominaCFDITableAdapter = new winAppSAIC.NominaCFDI.dbSAICBPONominaCFDIDataSetTableAdapters.stpSelNominaCFDITableAdapter();
            this.tableAdapterManager = new winAppSAIC.NominaCFDI.dbSAICBPONominaCFDIDataSetTableAdapters.TableAdapterManager();
            this.stpSelNominaCFDIBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.btnGenerarXML = new System.Windows.Forms.ToolStripButton();
            this.stpSelNominaCFDIBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAcuseRecibosNominaSueldosAsimiladosXML = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.stpSelNominaCFDIGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFolioRecibo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApellidoPaterno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApellidoMaterno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNSSEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoDiasPagados = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMontoPagado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRFCEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCURPEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COLTotalPercepciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoCheckSeleccionado = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.pcFolioLoteCargaNomina = new DevExpress.XtraEditors.PanelControl();
            this.gcResumenEstatusNominaVsTimbrados = new DevExpress.XtraEditors.GroupControl();
            this.lblPorEmpleadosTimbrados = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.lblPctEmpleadosPorTimbrar = new DevExpress.XtraEditors.LabelControl();
            this.lblNoEmpleadosXTimbrados = new DevExpress.XtraEditors.LabelControl();
            this.lblNoEmpleadosTimbrados = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.lblNoEmpleadosATimbrados = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.lblNoEmpleadosNomina = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.txtIdControl = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.lblDescEstatusCFDI = new DevExpress.XtraEditors.LabelControl();
            this.lblIdEstatusCFDI = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lblNoFoliosSeleccionados = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.btnDeseleccionarTodo = new DevExpress.XtraEditors.SimpleButton();
            this.btnSeleccionarTodos = new DevExpress.XtraEditors.SimpleButton();
            this.dtFechaPago = new DevExpress.XtraEditors.DateEdit();
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
            this.stpSelFolioLoteCargaNominaSACFDIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenedora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOperador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTenedora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRFC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblFolio = new DevExpress.XtraEditors.LabelControl();
            this.dbSAICBPODataSet = new winAppSAIC.dbSAICBPODataSet();
            this.pnGridNomina = new DevExpress.XtraEditors.PanelControl();
            this.stpSelInfoDetalleLoteCargaNominaTableAdapter1 = new winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.stpSelInfoDetalleLoteCargaNominaTableAdapter();
            this.pnCheckLixtBoxNomina = new DevExpress.XtraEditors.PanelControl();
            this.chkListNominas = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.stpSelNominaDetalleCFDITableAdapter1 = new winAppSAIC.NominaCFDI.dbSAICBPONominaCFDIDataSetTableAdapters.stpSelNominaDetalleCFDITableAdapter();
            this.seguridadTableAdapter1 = new winAppSAIC.NominaCFDI.dbSAICBPONominaCFDIDataSetTableAdapters.SeguridadTableAdapter();
            this.stpSelFolioLoteCargaNominaSACFDITableAdapter = new winAppSAIC.NominaCFDI.dbSAICBPONominaCFDIDataSetTableAdapters.stpSelFolioLoteCargaNominaSACFDITableAdapter();
            this.validacionesGeneralTableAdapter1 = new winAppSAIC.Catalogos.dbSAICBPO_CatalogosValidacionDataSetTableAdapters.ValidacionesGeneralTableAdapter();
            this.stpFactSelGenerarFacturaEmpleadosTableAdapter1 = new winAppSAIC.NominaCFDI.dbSAICBPONominaCFDIv12DataSetTableAdapters.stpFactSelGenerarFacturaEmpleadosTableAdapter();
            this.dbSAICBPONominaCFDIv12DataSet1 = new winAppSAIC.NominaCFDI.dbSAICBPONominaCFDIv12DataSet();
            this.spSoloRespuestaCFDIEmpleado1 = new winAppSAIC.NominaCFDI.dbSAICBPONominaCFDIv12DataSetTableAdapters.spSoloRespuestaCFDIEmpleado();
            this.stpSelObtenerEstatusNominaSueldosVsTimbradoOperadorTableAdapter1 = new winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.stpSelObtenerEstatusNominaSueldosVsTimbradoOperadorTableAdapter();
            this.splashSMProcesando = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::winAppSAIC.WaitSplashForms.frmxWaitFormProcesando), true, true);
            this.dbSAIC_Seguridad1 = new winAppSAIC.Seguridad.dbSAIC_Seguridad();
            this.stpSelObtenerDocCadenaOriginalTableAdapter1 = new winAppSAIC.Seguridad.dbSAIC_SeguridadTableAdapters.stpSelObtenerDocCadenaOriginalTableAdapter();
            this.stpFactSelDerechosAccesoOperadorFacturacionTableAdapter1 = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelDerechosAccesoOperadorFacturacionTableAdapter();
            this.dbSAICBPOFactura1 = new winAppSAIC.Facturas.dbSAICBPOFactura();
            this.dbSAICBPOValidacionDataSet1 = new winAppSAIC.dbSAICBPOValidacionDataSet();
            this.stpSelParametroTableAdapter1 = new winAppSAIC.dbSAICBPOValidacionDataSetTableAdapters.stpSelParametroTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPONominaCFDIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelNominaCFDIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelNominaCFDIBindingNavigator)).BeginInit();
            this.stpSelNominaCFDIBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelNominaCFDIGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoCheckSeleccionado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcFolioLoteCargaNomina)).BeginInit();
            this.pcFolioLoteCargaNomina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcResumenEstatusNominaVsTimbrados)).BeginInit();
            this.gcResumenEstatusNominaVsTimbrados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdControl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaPago.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaPago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFechaPago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEstatusNominaContabilizada.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodoPago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreOperador.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoNomina.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreComercialCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreComercialTenedora.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFolioLoteCargaNomina.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelFolioLoteCargaNominaSACFDIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnGridNomina)).BeginInit();
            this.pnGridNomina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnCheckLixtBoxNomina)).BeginInit();
            this.pnCheckLixtBoxNomina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkListNominas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPONominaCFDIv12DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAIC_Seguridad1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOFactura1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOValidacionDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dbSAICBPONominaCFDIDataSet
            // 
            this.dbSAICBPONominaCFDIDataSet.DataSetName = "dbSAICBPONominaCFDIDataSet";
            this.dbSAICBPONominaCFDIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stpSelNominaCFDIBindingSource
            // 
            this.stpSelNominaCFDIBindingSource.DataMember = "stpSelNominaCFDI";
            this.stpSelNominaCFDIBindingSource.DataSource = this.dbSAICBPONominaCFDIDataSet;
            // 
            // stpSelNominaCFDITableAdapter
            // 
            this.stpSelNominaCFDITableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = winAppSAIC.NominaCFDI.dbSAICBPONominaCFDIDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // stpSelNominaCFDIBindingNavigator
            // 
            this.stpSelNominaCFDIBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.stpSelNominaCFDIBindingNavigator.BindingSource = this.stpSelNominaCFDIBindingSource;
            this.stpSelNominaCFDIBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.stpSelNominaCFDIBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.stpSelNominaCFDIBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.btnGenerarXML,
            this.stpSelNominaCFDIBindingNavigatorSaveItem,
            this.toolStripSeparator1,
            this.btnAcuseRecibosNominaSueldosAsimiladosXML,
            this.toolStripSeparator2,
            this.btnSalir});
            this.stpSelNominaCFDIBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.stpSelNominaCFDIBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.stpSelNominaCFDIBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.stpSelNominaCFDIBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.stpSelNominaCFDIBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.stpSelNominaCFDIBindingNavigator.Name = "stpSelNominaCFDIBindingNavigator";
            this.stpSelNominaCFDIBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.stpSelNominaCFDIBindingNavigator.Size = new System.Drawing.Size(1168, 25);
            this.stpSelNominaCFDIBindingNavigator.TabIndex = 0;
            this.stpSelNominaCFDIBindingNavigator.Text = "bindingNavigator1";
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
            // btnGenerarXML
            // 
            this.btnGenerarXML.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGenerarXML.Image = global::winAppSAIC.Properties.Resources.table_export_icon32x32;
            this.btnGenerarXML.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGenerarXML.Name = "btnGenerarXML";
            this.btnGenerarXML.Size = new System.Drawing.Size(128, 22);
            this.btnGenerarXML.Text = "Timbrar XML CFDI";
            this.btnGenerarXML.Click += new System.EventHandler(this.btnGenerarXML_Click);
            // 
            // stpSelNominaCFDIBindingNavigatorSaveItem
            // 
            this.stpSelNominaCFDIBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stpSelNominaCFDIBindingNavigatorSaveItem.Enabled = false;
            this.stpSelNominaCFDIBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("stpSelNominaCFDIBindingNavigatorSaveItem.Image")));
            this.stpSelNominaCFDIBindingNavigatorSaveItem.Name = "stpSelNominaCFDIBindingNavigatorSaveItem";
            this.stpSelNominaCFDIBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.stpSelNominaCFDIBindingNavigatorSaveItem.Text = "Save Data";
            this.stpSelNominaCFDIBindingNavigatorSaveItem.Visible = false;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAcuseRecibosNominaSueldosAsimiladosXML
            // 
            this.btnAcuseRecibosNominaSueldosAsimiladosXML.Image = global::winAppSAIC.Properties.Resources.signup_icon16x16;
            this.btnAcuseRecibosNominaSueldosAsimiladosXML.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAcuseRecibosNominaSueldosAsimiladosXML.Name = "btnAcuseRecibosNominaSueldosAsimiladosXML";
            this.btnAcuseRecibosNominaSueldosAsimiladosXML.Size = new System.Drawing.Size(158, 22);
            this.btnAcuseRecibosNominaSueldosAsimiladosXML.Text = "Acuse Recibos XML CFDI";
            this.btnAcuseRecibosNominaSueldosAsimiladosXML.Visible = false;
            this.btnAcuseRecibosNominaSueldosAsimiladosXML.Click += new System.EventHandler(this.btnAcuseRecibosNominaSueldosAsimiladosXML_Click);
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
            // stpSelNominaCFDIGridControl
            // 
            this.stpSelNominaCFDIGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.stpSelNominaCFDIGridControl.DataSource = this.stpSelNominaCFDIBindingSource;
            this.stpSelNominaCFDIGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stpSelNominaCFDIGridControl.Location = new System.Drawing.Point(2, 2);
            this.stpSelNominaCFDIGridControl.MainView = this.gridView1;
            this.stpSelNominaCFDIGridControl.Name = "stpSelNominaCFDIGridControl";
            this.stpSelNominaCFDIGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repoCheckSeleccionado});
            this.stpSelNominaCFDIGridControl.Size = new System.Drawing.Size(1164, 187);
            this.stpSelNominaCFDIGridControl.TabIndex = 2;
            this.stpSelNominaCFDIGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFolioRecibo,
            this.colNoEmpleado,
            this.colApellidoPaterno,
            this.colApellidoMaterno,
            this.colNombre,
            this.colNSSEmpleado,
            this.colNoDiasPagados,
            this.colMontoPagado,
            this.colRFCEmpleado,
            this.colCURPEmpleado,
            this.COLTotalPercepciones});
            this.gridView1.GridControl = this.stpSelNominaCFDIGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // colFolioRecibo
            // 
            this.colFolioRecibo.Caption = "No. Control SAIC";
            this.colFolioRecibo.FieldName = "IdPDOHeader";
            this.colFolioRecibo.Name = "colFolioRecibo";
            this.colFolioRecibo.Visible = true;
            this.colFolioRecibo.VisibleIndex = 0;
            this.colFolioRecibo.Width = 103;
            // 
            // colNoEmpleado
            // 
            this.colNoEmpleado.AppearanceCell.Options.UseTextOptions = true;
            this.colNoEmpleado.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNoEmpleado.AppearanceHeader.Options.UseTextOptions = true;
            this.colNoEmpleado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNoEmpleado.DisplayFormat.FormatString = "N0";
            this.colNoEmpleado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colNoEmpleado.FieldName = "NoEmpleado";
            this.colNoEmpleado.Name = "colNoEmpleado";
            this.colNoEmpleado.Visible = true;
            this.colNoEmpleado.VisibleIndex = 1;
            this.colNoEmpleado.Width = 84;
            // 
            // colApellidoPaterno
            // 
            this.colApellidoPaterno.FieldName = "ApellidoPaterno";
            this.colApellidoPaterno.Name = "colApellidoPaterno";
            this.colApellidoPaterno.Visible = true;
            this.colApellidoPaterno.VisibleIndex = 2;
            this.colApellidoPaterno.Width = 133;
            // 
            // colApellidoMaterno
            // 
            this.colApellidoMaterno.FieldName = "ApellidoMaterno";
            this.colApellidoMaterno.Name = "colApellidoMaterno";
            this.colApellidoMaterno.Visible = true;
            this.colApellidoMaterno.VisibleIndex = 3;
            this.colApellidoMaterno.Width = 133;
            // 
            // colNombre
            // 
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 4;
            this.colNombre.Width = 133;
            // 
            // colNSSEmpleado
            // 
            this.colNSSEmpleado.Caption = "NSS";
            this.colNSSEmpleado.FieldName = "NSSEmpleado";
            this.colNSSEmpleado.Name = "colNSSEmpleado";
            this.colNSSEmpleado.Visible = true;
            this.colNSSEmpleado.VisibleIndex = 5;
            this.colNSSEmpleado.Width = 102;
            // 
            // colNoDiasPagados
            // 
            this.colNoDiasPagados.FieldName = "NoDiasPagados";
            this.colNoDiasPagados.Name = "colNoDiasPagados";
            this.colNoDiasPagados.Visible = true;
            this.colNoDiasPagados.VisibleIndex = 8;
            this.colNoDiasPagados.Width = 82;
            // 
            // colMontoPagado
            // 
            this.colMontoPagado.DisplayFormat.FormatString = "C2";
            this.colMontoPagado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMontoPagado.FieldName = "MontoPagado";
            this.colMontoPagado.Name = "colMontoPagado";
            this.colMontoPagado.Width = 77;
            // 
            // colRFCEmpleado
            // 
            this.colRFCEmpleado.Caption = "RFC";
            this.colRFCEmpleado.FieldName = "RFCEmpleado";
            this.colRFCEmpleado.Name = "colRFCEmpleado";
            this.colRFCEmpleado.Visible = true;
            this.colRFCEmpleado.VisibleIndex = 6;
            this.colRFCEmpleado.Width = 103;
            // 
            // colCURPEmpleado
            // 
            this.colCURPEmpleado.Caption = "CURP";
            this.colCURPEmpleado.FieldName = "CURPEmpleado";
            this.colCURPEmpleado.Name = "colCURPEmpleado";
            this.colCURPEmpleado.Visible = true;
            this.colCURPEmpleado.VisibleIndex = 7;
            this.colCURPEmpleado.Width = 112;
            // 
            // COLTotalPercepciones
            // 
            this.COLTotalPercepciones.Caption = "Total Percepciones";
            this.COLTotalPercepciones.DisplayFormat.FormatString = "C2";
            this.COLTotalPercepciones.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.COLTotalPercepciones.FieldName = "TotalPercepciones";
            this.COLTotalPercepciones.Name = "COLTotalPercepciones";
            this.COLTotalPercepciones.Visible = true;
            this.COLTotalPercepciones.VisibleIndex = 9;
            // 
            // repoCheckSeleccionado
            // 
            this.repoCheckSeleccionado.AutoHeight = false;
            this.repoCheckSeleccionado.Caption = "Check";
            this.repoCheckSeleccionado.Name = "repoCheckSeleccionado";
            // 
            // pcFolioLoteCargaNomina
            // 
            this.pcFolioLoteCargaNomina.Controls.Add(this.gcResumenEstatusNominaVsTimbrados);
            this.pcFolioLoteCargaNomina.Controls.Add(this.txtIdControl);
            this.pcFolioLoteCargaNomina.Controls.Add(this.labelControl8);
            this.pcFolioLoteCargaNomina.Controls.Add(this.simpleButton1);
            this.pcFolioLoteCargaNomina.Controls.Add(this.lblDescEstatusCFDI);
            this.pcFolioLoteCargaNomina.Controls.Add(this.lblIdEstatusCFDI);
            this.pcFolioLoteCargaNomina.Controls.Add(this.panelControl1);
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
            this.pcFolioLoteCargaNomina.Size = new System.Drawing.Size(1168, 214);
            this.pcFolioLoteCargaNomina.TabIndex = 4;
            this.pcFolioLoteCargaNomina.Paint += new System.Windows.Forms.PaintEventHandler(this.pcFolioLoteCargaNomina_Paint);
            // 
            // gcResumenEstatusNominaVsTimbrados
            // 
            this.gcResumenEstatusNominaVsTimbrados.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcResumenEstatusNominaVsTimbrados.Appearance.Options.UseFont = true;
            this.gcResumenEstatusNominaVsTimbrados.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gcResumenEstatusNominaVsTimbrados.AppearanceCaption.Options.UseFont = true;
            this.gcResumenEstatusNominaVsTimbrados.AppearanceCaption.Options.UseTextOptions = true;
            this.gcResumenEstatusNominaVsTimbrados.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcResumenEstatusNominaVsTimbrados.Controls.Add(this.lblPorEmpleadosTimbrados);
            this.gcResumenEstatusNominaVsTimbrados.Controls.Add(this.labelControl14);
            this.gcResumenEstatusNominaVsTimbrados.Controls.Add(this.lblPctEmpleadosPorTimbrar);
            this.gcResumenEstatusNominaVsTimbrados.Controls.Add(this.lblNoEmpleadosXTimbrados);
            this.gcResumenEstatusNominaVsTimbrados.Controls.Add(this.lblNoEmpleadosTimbrados);
            this.gcResumenEstatusNominaVsTimbrados.Controls.Add(this.labelControl10);
            this.gcResumenEstatusNominaVsTimbrados.Controls.Add(this.lblNoEmpleadosATimbrados);
            this.gcResumenEstatusNominaVsTimbrados.Controls.Add(this.labelControl11);
            this.gcResumenEstatusNominaVsTimbrados.Controls.Add(this.lblNoEmpleadosNomina);
            this.gcResumenEstatusNominaVsTimbrados.Controls.Add(this.labelControl13);
            this.gcResumenEstatusNominaVsTimbrados.Location = new System.Drawing.Point(556, 17);
            this.gcResumenEstatusNominaVsTimbrados.Name = "gcResumenEstatusNominaVsTimbrados";
            this.gcResumenEstatusNominaVsTimbrados.Size = new System.Drawing.Size(386, 141);
            this.gcResumenEstatusNominaVsTimbrados.TabIndex = 27;
            this.gcResumenEstatusNominaVsTimbrados.Text = "Resumen Nómina Vs Timbrados";
            // 
            // lblPorEmpleadosTimbrados
            // 
            this.lblPorEmpleadosTimbrados.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorEmpleadosTimbrados.Appearance.Options.UseFont = true;
            this.lblPorEmpleadosTimbrados.Location = new System.Drawing.Point(243, 120);
            this.lblPorEmpleadosTimbrados.Name = "lblPorEmpleadosTimbrados";
            this.lblPorEmpleadosTimbrados.Size = new System.Drawing.Size(9, 14);
            this.lblPorEmpleadosTimbrados.TabIndex = 11;
            this.lblPorEmpleadosTimbrados.Text = "X";
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(111, 121);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(117, 13);
            this.labelControl14.TabIndex = 10;
            this.labelControl14.Text = "% Empleados Timbrados";
            // 
            // lblPctEmpleadosPorTimbrar
            // 
            this.lblPctEmpleadosPorTimbrar.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPctEmpleadosPorTimbrar.Appearance.Options.UseFont = true;
            this.lblPctEmpleadosPorTimbrar.Location = new System.Drawing.Point(329, 90);
            this.lblPctEmpleadosPorTimbrar.Name = "lblPctEmpleadosPorTimbrar";
            this.lblPctEmpleadosPorTimbrar.Size = new System.Drawing.Size(8, 13);
            this.lblPctEmpleadosPorTimbrar.TabIndex = 9;
            this.lblPctEmpleadosPorTimbrar.Text = "X";
            // 
            // lblNoEmpleadosXTimbrados
            // 
            this.lblNoEmpleadosXTimbrados.Location = new System.Drawing.Point(190, 90);
            this.lblNoEmpleadosXTimbrados.Name = "lblNoEmpleadosXTimbrados";
            this.lblNoEmpleadosXTimbrados.Size = new System.Drawing.Size(129, 13);
            this.lblNoEmpleadosXTimbrados.TabIndex = 8;
            this.lblNoEmpleadosXTimbrados.Text = "No. Empleados por Timbrar";
            // 
            // lblNoEmpleadosTimbrados
            // 
            this.lblNoEmpleadosTimbrados.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblNoEmpleadosTimbrados.Appearance.Options.UseFont = true;
            this.lblNoEmpleadosTimbrados.Location = new System.Drawing.Point(152, 90);
            this.lblNoEmpleadosTimbrados.Name = "lblNoEmpleadosTimbrados";
            this.lblNoEmpleadosTimbrados.Size = new System.Drawing.Size(8, 13);
            this.lblNoEmpleadosTimbrados.TabIndex = 7;
            this.lblNoEmpleadosTimbrados.Text = "X";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(14, 90);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(123, 13);
            this.labelControl10.TabIndex = 6;
            this.labelControl10.Text = "No. Empleados Timbrados";
            // 
            // lblNoEmpleadosATimbrados
            // 
            this.lblNoEmpleadosATimbrados.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblNoEmpleadosATimbrados.Appearance.Options.UseFont = true;
            this.lblNoEmpleadosATimbrados.Location = new System.Drawing.Point(329, 36);
            this.lblNoEmpleadosATimbrados.Name = "lblNoEmpleadosATimbrados";
            this.lblNoEmpleadosATimbrados.Size = new System.Drawing.Size(8, 13);
            this.lblNoEmpleadosATimbrados.TabIndex = 3;
            this.lblNoEmpleadosATimbrados.Text = "X";
            // 
            // labelControl11
            // 
            this.labelControl11.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl11.Location = new System.Drawing.Point(190, 36);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(133, 39);
            this.labelControl11.TabIndex = 2;
            this.labelControl11.Text = "No. Empleados a Timbrar (Percepción >0) ó                      (Días Pago >0)";
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
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(13, 36);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(124, 13);
            this.labelControl13.TabIndex = 0;
            this.labelControl13.Text = "No. Empleados en Nómina\r\n";
            // 
            // txtIdControl
            // 
            this.txtIdControl.Enabled = false;
            this.txtIdControl.Location = new System.Drawing.Point(310, 133);
            this.txtIdControl.Name = "txtIdControl";
            this.txtIdControl.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtIdControl.Properties.Appearance.Options.UseBackColor = true;
            this.txtIdControl.Size = new System.Drawing.Size(217, 20);
            this.txtIdControl.TabIndex = 25;
            this.txtIdControl.TabStop = false;
            // 
            // labelControl8
            // 
            this.labelControl8.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl8.Location = new System.Drawing.Point(256, 136);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(48, 13);
            this.labelControl8.TabIndex = 24;
            this.labelControl8.Text = "Id Control";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.simpleButton1.Location = new System.Drawing.Point(948, 65);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(215, 40);
            this.simpleButton1.TabIndex = 23;
            this.simpleButton1.Text = "Visualizar Errores de Timbrado";
            this.simpleButton1.Click += new System.EventHandler(this.btnVisualizarErroresTimbrado_Click);
            // 
            // lblDescEstatusCFDI
            // 
            this.lblDescEstatusCFDI.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescEstatusCFDI.Appearance.ForeColor = System.Drawing.Color.Crimson;
            this.lblDescEstatusCFDI.Appearance.Options.UseFont = true;
            this.lblDescEstatusCFDI.Appearance.Options.UseForeColor = true;
            this.lblDescEstatusCFDI.Location = new System.Drawing.Point(442, 11);
            this.lblDescEstatusCFDI.Name = "lblDescEstatusCFDI";
            this.lblDescEstatusCFDI.Size = new System.Drawing.Size(139, 19);
            this.lblDescEstatusCFDI.TabIndex = 21;
            this.lblDescEstatusCFDI.Text = "lblDescEstatusCFDI";
            this.lblDescEstatusCFDI.Visible = false;
            // 
            // lblIdEstatusCFDI
            // 
            this.lblIdEstatusCFDI.Location = new System.Drawing.Point(310, 158);
            this.lblIdEstatusCFDI.Name = "lblIdEstatusCFDI";
            this.lblIdEstatusCFDI.Size = new System.Drawing.Size(80, 13);
            this.lblIdEstatusCFDI.TabIndex = 20;
            this.lblIdEstatusCFDI.Text = "lblIdEstatusCFDI";
            this.lblIdEstatusCFDI.Visible = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(153)))), ((int)(((byte)(205)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.lblNoFoliosSeleccionados);
            this.panelControl1.Controls.Add(this.labelControl9);
            this.panelControl1.Controls.Add(this.btnDeseleccionarTodo);
            this.panelControl1.Controls.Add(this.btnSeleccionarTodos);
            this.panelControl1.Controls.Add(this.dtFechaPago);
            this.panelControl1.Controls.Add(this.labelControl7);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(2, 176);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1164, 36);
            this.panelControl1.TabIndex = 19;
            // 
            // lblNoFoliosSeleccionados
            // 
            this.lblNoFoliosSeleccionados.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoFoliosSeleccionados.Appearance.Options.UseFont = true;
            this.lblNoFoliosSeleccionados.Location = new System.Drawing.Point(1092, 9);
            this.lblNoFoliosSeleccionados.Name = "lblNoFoliosSeleccionados";
            this.lblNoFoliosSeleccionados.Size = new System.Drawing.Size(8, 14);
            this.lblNoFoliosSeleccionados.TabIndex = 24;
            this.lblNoFoliosSeleccionados.Text = "0";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(955, 9);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(135, 14);
            this.labelControl9.TabIndex = 23;
            this.labelControl9.Text = "Folios seleccionados =";
            // 
            // btnDeseleccionarTodo
            // 
            this.btnDeseleccionarTodo.Location = new System.Drawing.Point(359, 5);
            this.btnDeseleccionarTodo.Name = "btnDeseleccionarTodo";
            this.btnDeseleccionarTodo.Size = new System.Drawing.Size(121, 23);
            this.btnDeseleccionarTodo.TabIndex = 20;
            this.btnDeseleccionarTodo.Text = "Deseleccionar Todo";
            this.btnDeseleccionarTodo.Click += new System.EventHandler(this.btnDeseleccionarTodo_Click);
            // 
            // btnSeleccionarTodos
            // 
            this.btnSeleccionarTodos.Location = new System.Drawing.Point(247, 5);
            this.btnSeleccionarTodos.Name = "btnSeleccionarTodos";
            this.btnSeleccionarTodos.Size = new System.Drawing.Size(106, 23);
            this.btnSeleccionarTodos.TabIndex = 19;
            this.btnSeleccionarTodos.Text = "Seleccionar Todo";
            this.btnSeleccionarTodos.Click += new System.EventHandler(this.btnSeleccionarTodos_Click);
            // 
            // dtFechaPago
            // 
            this.dtFechaPago.EditValue = null;
            this.dtFechaPago.Location = new System.Drawing.Point(133, 7);
            this.dtFechaPago.Name = "dtFechaPago";
            this.dtFechaPago.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaPago.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaPago.Size = new System.Drawing.Size(100, 20);
            this.dtFechaPago.TabIndex = 18;
            this.dtFechaPago.Visible = false;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Location = new System.Drawing.Point(47, 11);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(81, 13);
            this.labelControl7.TabIndex = 17;
            this.labelControl7.Text = "Fecha de Pago";
            this.labelControl7.Visible = false;
            // 
            // txtFechaPago
            // 
            this.txtFechaPago.Enabled = false;
            this.txtFechaPago.Location = new System.Drawing.Point(135, 133);
            this.txtFechaPago.Name = "txtFechaPago";
            this.txtFechaPago.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtFechaPago.Properties.Appearance.Options.UseBackColor = true;
            this.txtFechaPago.Size = new System.Drawing.Size(116, 20);
            this.txtFechaPago.TabIndex = 16;
            this.txtFechaPago.TabStop = false;
            // 
            // labelControl6
            // 
            this.labelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl6.Location = new System.Drawing.Point(34, 136);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(95, 13);
            this.labelControl6.TabIndex = 15;
            this.labelControl6.Text = "Fecha Pago Plantilla";
            // 
            // chkEstatusNominaContabilizada
            // 
            this.chkEstatusNominaContabilizada.Enabled = false;
            this.chkEstatusNominaContabilizada.Location = new System.Drawing.Point(135, 155);
            this.chkEstatusNominaContabilizada.Name = "chkEstatusNominaContabilizada";
            this.chkEstatusNominaContabilizada.Properties.Caption = "Contabilizada";
            this.chkEstatusNominaContabilizada.Size = new System.Drawing.Size(116, 19);
            this.chkEstatusNominaContabilizada.TabIndex = 14;
            this.chkEstatusNominaContabilizada.TabStop = false;
            // 
            // txtPeriodoPago
            // 
            this.txtPeriodoPago.Enabled = false;
            this.txtPeriodoPago.Location = new System.Drawing.Point(310, 109);
            this.txtPeriodoPago.Name = "txtPeriodoPago";
            this.txtPeriodoPago.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtPeriodoPago.Properties.Appearance.Options.UseBackColor = true;
            this.txtPeriodoPago.Size = new System.Drawing.Size(217, 20);
            this.txtPeriodoPago.TabIndex = 13;
            this.txtPeriodoPago.TabStop = false;
            // 
            // txtNombreOperador
            // 
            this.txtNombreOperador.Enabled = false;
            this.txtNombreOperador.Location = new System.Drawing.Point(135, 85);
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
            this.txtTipoNomina.Location = new System.Drawing.Point(135, 109);
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
            this.txtNombreComercialCliente.Location = new System.Drawing.Point(135, 61);
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
            this.txtNombreComercialTenedora.Location = new System.Drawing.Point(135, 37);
            this.txtNombreComercialTenedora.Name = "txtNombreComercialTenedora";
            this.txtNombreComercialTenedora.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtNombreComercialTenedora.Properties.Appearance.Options.UseBackColor = true;
            this.txtNombreComercialTenedora.Size = new System.Drawing.Size(392, 20);
            this.txtNombreComercialTenedora.TabIndex = 5;
            this.txtNombreComercialTenedora.TabStop = false;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(71, 112);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(58, 13);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Tipo Nómina";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(268, 112);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(36, 13);
            this.labelControl4.TabIndex = 12;
            this.labelControl4.Text = "Periodo";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(83, 89);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(46, 13);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Operador";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(96, 65);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(33, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Cliente";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(83, 41);
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
            this.cboFolioLoteCargaNomina.Properties.DataSource = this.stpSelFolioLoteCargaNominaSACFDIBindingSource;
            this.cboFolioLoteCargaNomina.Properties.DisplayMember = "FolioLoteCargaNomina";
            this.cboFolioLoteCargaNomina.Properties.NullText = "";
            this.cboFolioLoteCargaNomina.Properties.ValueMember = "IdLoteCargaNomina";
            this.cboFolioLoteCargaNomina.Properties.View = this.gridLookUpEdit1View;
            this.cboFolioLoteCargaNomina.Size = new System.Drawing.Size(250, 20);
            this.cboFolioLoteCargaNomina.TabIndex = 3;
            this.cboFolioLoteCargaNomina.EditValueChanged += new System.EventHandler(this.cboFolioLoteCargaNomina_EditValueChanged);
            // 
            // stpSelFolioLoteCargaNominaSACFDIBindingSource
            // 
            this.stpSelFolioLoteCargaNominaSACFDIBindingSource.DataMember = "stpSelFolioLoteCargaNominaSACFDI";
            this.stpSelFolioLoteCargaNominaSACFDIBindingSource.DataSource = this.dbSAICBPONominaCFDIDataSet;
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
            this.colRFC});
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
            // colRFC
            // 
            this.colRFC.FieldName = "RFC";
            this.colRFC.Name = "colRFC";
            // 
            // lblFolio
            // 
            this.lblFolio.Location = new System.Drawing.Point(13, 17);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(116, 13);
            this.lblFolio.TabIndex = 2;
            this.lblFolio.Text = "Folio Lote Carga Nómina";
            // 
            // dbSAICBPODataSet
            // 
            this.dbSAICBPODataSet.DataSetName = "dbSAICBPODataSet";
            this.dbSAICBPODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnGridNomina
            // 
            this.pnGridNomina.Controls.Add(this.stpSelNominaCFDIGridControl);
            this.pnGridNomina.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnGridNomina.Location = new System.Drawing.Point(0, 239);
            this.pnGridNomina.Name = "pnGridNomina";
            this.pnGridNomina.Size = new System.Drawing.Size(1168, 191);
            this.pnGridNomina.TabIndex = 5;
            // 
            // stpSelInfoDetalleLoteCargaNominaTableAdapter1
            // 
            this.stpSelInfoDetalleLoteCargaNominaTableAdapter1.ClearBeforeFill = true;
            // 
            // pnCheckLixtBoxNomina
            // 
            this.pnCheckLixtBoxNomina.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnCheckLixtBoxNomina.Appearance.Options.UseBackColor = true;
            this.pnCheckLixtBoxNomina.Controls.Add(this.chkListNominas);
            this.pnCheckLixtBoxNomina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCheckLixtBoxNomina.Location = new System.Drawing.Point(0, 430);
            this.pnCheckLixtBoxNomina.Name = "pnCheckLixtBoxNomina";
            this.pnCheckLixtBoxNomina.Size = new System.Drawing.Size(1168, 132);
            this.pnCheckLixtBoxNomina.TabIndex = 6;
            // 
            // chkListNominas
            // 
            this.chkListNominas.CheckOnClick = true;
            this.chkListNominas.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkListNominas.DataSource = this.stpSelNominaCFDIBindingSource;
            this.chkListNominas.DisplayMember = "IdPDOHeader";
            this.chkListNominas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkListNominas.HorizontalScrollbar = true;
            this.chkListNominas.Location = new System.Drawing.Point(2, 2);
            this.chkListNominas.MultiColumn = true;
            this.chkListNominas.Name = "chkListNominas";
            this.chkListNominas.Size = new System.Drawing.Size(1164, 128);
            this.chkListNominas.TabIndex = 5;
            this.chkListNominas.ValueMember = "IdPDOHeader";
            this.chkListNominas.ItemCheck += new DevExpress.XtraEditors.Controls.ItemCheckEventHandler(this.chkListNominas_ItemCheck_1);
            this.chkListNominas.DrawItem += new DevExpress.XtraEditors.ListBoxDrawItemEventHandler(this.chkListNominas_DrawItem);
            // 
            // stpSelNominaDetalleCFDITableAdapter1
            // 
            this.stpSelNominaDetalleCFDITableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelFolioLoteCargaNominaSACFDITableAdapter
            // 
            this.stpSelFolioLoteCargaNominaSACFDITableAdapter.ClearBeforeFill = true;
            // 
            // stpFactSelGenerarFacturaEmpleadosTableAdapter1
            // 
            this.stpFactSelGenerarFacturaEmpleadosTableAdapter1.ClearBeforeFill = true;
            // 
            // dbSAICBPONominaCFDIv12DataSet1
            // 
            this.dbSAICBPONominaCFDIv12DataSet1.DataSetName = "dbSAICBPONominaCFDIv12DataSet";
            this.dbSAICBPONominaCFDIv12DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stpSelObtenerEstatusNominaSueldosVsTimbradoOperadorTableAdapter1
            // 
            this.stpSelObtenerEstatusNominaSueldosVsTimbradoOperadorTableAdapter1.ClearBeforeFill = true;
            // 
            // splashSMProcesando
            // 
            this.splashSMProcesando.ClosingDelay = 500;
            // 
            // dbSAIC_Seguridad1
            // 
            this.dbSAIC_Seguridad1.DataSetName = "dbSAIC_Seguridad";
            this.dbSAIC_Seguridad1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stpSelObtenerDocCadenaOriginalTableAdapter1
            // 
            this.stpSelObtenerDocCadenaOriginalTableAdapter1.ClearBeforeFill = true;
            // 
            // stpFactSelDerechosAccesoOperadorFacturacionTableAdapter1
            // 
            this.stpFactSelDerechosAccesoOperadorFacturacionTableAdapter1.ClearBeforeFill = true;
            // 
            // dbSAICBPOFactura1
            // 
            this.dbSAICBPOFactura1.DataSetName = "dbSAICBPOFactura";
            this.dbSAICBPOFactura1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbSAICBPOValidacionDataSet1
            // 
            this.dbSAICBPOValidacionDataSet1.DataSetName = "dbSAICBPOValidacionDataSet";
            this.dbSAICBPOValidacionDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stpSelParametroTableAdapter1
            // 
            this.stpSelParametroTableAdapter1.ClearBeforeFill = true;
            // 
            // frmxAsignarNomina2XMLCFDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 562);
            this.ControlBox = false;
            this.Controls.Add(this.pnCheckLixtBoxNomina);
            this.Controls.Add(this.pnGridNomina);
            this.Controls.Add(this.pcFolioLoteCargaNomina);
            this.Controls.Add(this.stpSelNominaCFDIBindingNavigator);
            this.Name = "frmxAsignarNomina2XMLCFDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignar Nóminas y Timbrar XML CFDI";
            this.Load += new System.EventHandler(this.frmxAsignarNomina2XMLCFDI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPONominaCFDIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelNominaCFDIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelNominaCFDIBindingNavigator)).EndInit();
            this.stpSelNominaCFDIBindingNavigator.ResumeLayout(false);
            this.stpSelNominaCFDIBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelNominaCFDIGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoCheckSeleccionado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcFolioLoteCargaNomina)).EndInit();
            this.pcFolioLoteCargaNomina.ResumeLayout(false);
            this.pcFolioLoteCargaNomina.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcResumenEstatusNominaVsTimbrados)).EndInit();
            this.gcResumenEstatusNominaVsTimbrados.ResumeLayout(false);
            this.gcResumenEstatusNominaVsTimbrados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdControl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaPago.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFechaPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEstatusNominaContabilizada.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodoPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreOperador.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoNomina.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreComercialCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreComercialTenedora.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFolioLoteCargaNomina.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelFolioLoteCargaNominaSACFDIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnGridNomina)).EndInit();
            this.pnGridNomina.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnCheckLixtBoxNomina)).EndInit();
            this.pnCheckLixtBoxNomina.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkListNominas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPONominaCFDIv12DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAIC_Seguridad1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOFactura1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOValidacionDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dbSAICBPONominaCFDIDataSet dbSAICBPONominaCFDIDataSet;
        private System.Windows.Forms.BindingSource stpSelNominaCFDIBindingSource;
        private dbSAICBPONominaCFDIDataSetTableAdapters.stpSelNominaCFDITableAdapter stpSelNominaCFDITableAdapter;
        private dbSAICBPONominaCFDIDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator stpSelNominaCFDIBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton stpSelNominaCFDIBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl stpSelNominaCFDIGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl pcFolioLoteCargaNomina;
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
        private DevExpress.XtraEditors.LabelControl lblFolio;
        private DevExpress.XtraEditors.PanelControl pnGridNomina;
        private dbSAICBPODataSet dbSAICBPODataSet;
        private dbSAICBPOReportesDataSetTableAdapters.stpSelInfoDetalleLoteCargaNominaTableAdapter stpSelInfoDetalleLoteCargaNominaTableAdapter1;
        private DevExpress.XtraGrid.Columns.GridColumn colFolioRecibo;
        private DevExpress.XtraGrid.Columns.GridColumn colApellidoPaterno;
        private DevExpress.XtraGrid.Columns.GridColumn colApellidoMaterno;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colNSSEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn colNoEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn colNoDiasPagados;
        private DevExpress.XtraGrid.Columns.GridColumn colMontoPagado;
        private System.Windows.Forms.ToolStripButton btnGenerarXML;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repoCheckSeleccionado;
        private DevExpress.XtraEditors.PanelControl pnCheckLixtBoxNomina;
        private DevExpress.XtraEditors.CheckedListBoxControl chkListNominas;
        private dbSAICBPONominaCFDIDataSetTableAdapters.stpSelNominaDetalleCFDITableAdapter stpSelNominaDetalleCFDITableAdapter1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private dbSAICBPONominaCFDIDataSetTableAdapters.SeguridadTableAdapter seguridadTableAdapter1;
        private System.Windows.Forms.BindingSource stpSelFolioLoteCargaNominaSACFDIBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTenedora;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.DateEdit dtFechaPago;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colRFC;
        public dbSAICBPONominaCFDIDataSetTableAdapters.stpSelFolioLoteCargaNominaSACFDITableAdapter stpSelFolioLoteCargaNominaSACFDITableAdapter;
        private DevExpress.XtraEditors.SimpleButton btnDeseleccionarTodo;
        private DevExpress.XtraEditors.SimpleButton btnSeleccionarTodos;
        private DevExpress.XtraGrid.Columns.GridColumn colRFCEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn colCURPEmpleado;
        private DevExpress.XtraEditors.LabelControl lblDescEstatusCFDI;
        private DevExpress.XtraEditors.LabelControl lblIdEstatusCFDI;
        private System.Windows.Forms.ToolStripButton btnAcuseRecibosNominaSueldosAsimiladosXML;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit txtIdControl;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private Catalogos.dbSAICBPO_CatalogosValidacionDataSetTableAdapters.ValidacionesGeneralTableAdapter validacionesGeneralTableAdapter1;
        private dbSAICBPONominaCFDIv12DataSetTableAdapters.stpFactSelGenerarFacturaEmpleadosTableAdapter stpFactSelGenerarFacturaEmpleadosTableAdapter1;
        private dbSAICBPONominaCFDIv12DataSet dbSAICBPONominaCFDIv12DataSet1;
        private dbSAICBPONominaCFDIv12DataSetTableAdapters.spSoloRespuestaCFDIEmpleado spSoloRespuestaCFDIEmpleado1;
        private DevExpress.XtraGrid.Columns.GridColumn COLTotalPercepciones;
        private DevExpress.XtraEditors.LabelControl lblNoFoliosSeleccionados;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.GroupControl gcResumenEstatusNominaVsTimbrados;
        private DevExpress.XtraEditors.LabelControl lblPorEmpleadosTimbrados;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl lblPctEmpleadosPorTimbrar;
        private DevExpress.XtraEditors.LabelControl lblNoEmpleadosXTimbrados;
        private DevExpress.XtraEditors.LabelControl lblNoEmpleadosTimbrados;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl lblNoEmpleadosATimbrados;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl lblNoEmpleadosNomina;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private dbSAICBPOReportesDataSetTableAdapters.stpSelObtenerEstatusNominaSueldosVsTimbradoOperadorTableAdapter stpSelObtenerEstatusNominaSueldosVsTimbradoOperadorTableAdapter1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashSMProcesando;
        private Seguridad.dbSAIC_Seguridad dbSAIC_Seguridad1;
        private Seguridad.dbSAIC_SeguridadTableAdapters.stpSelObtenerDocCadenaOriginalTableAdapter stpSelObtenerDocCadenaOriginalTableAdapter1;
        private Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelDerechosAccesoOperadorFacturacionTableAdapter stpFactSelDerechosAccesoOperadorFacturacionTableAdapter1;
        private Facturas.dbSAICBPOFactura dbSAICBPOFactura1;
        private dbSAICBPOValidacionDataSet dbSAICBPOValidacionDataSet1;
        private dbSAICBPOValidacionDataSetTableAdapters.stpSelParametroTableAdapter stpSelParametroTableAdapter1;
    }
}