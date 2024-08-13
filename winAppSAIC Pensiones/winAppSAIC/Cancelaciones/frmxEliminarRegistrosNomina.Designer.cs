namespace winAppSAIC.Cancelaciones
{
    partial class frmxEliminarRegistrosNomina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmxEliminarRegistrosNomina));
            this.splashSMProcesando = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::winAppSAIC.WaitSplashForms.frmxWaitFormProcesando), true, true);
            this.dbSAICBPONominaCFDIDataSet = new winAppSAIC.NominaCFDI.dbSAICBPONominaCFDIDataSet();
            this.stpSelFolioLoteCargaNominaTimbradosCFDIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stpSelFolioLoteCargaNominaTimbradosCFDITableAdapter = new winAppSAIC.NominaCFDI.dbSAICBPONominaCFDIDataSetTableAdapters.stpSelFolioLoteCargaNominaTimbradosCFDITableAdapter();
            this.tableAdapterManager = new winAppSAIC.NominaCFDI.dbSAICBPONominaCFDIDataSetTableAdapters.TableAdapterManager();
            this.stpSelFolioLoteCargaNominaTimbradosCFDIBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.stpSelInfoCancelacionDetalleLoteCargaNominaTimbradosCFDIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
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
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.stpSelFolioLoteCargaNominaTimbradosCFDIGridControl = new DevExpress.XtraGrid.GridControl();
            this.stpSelInfoCancelacionDetalleLoteCargaNominaRegistroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPODataSet = new winAppSAIC.dbSAICBPODataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdPDOHeaderCFDI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAPaternoEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAMaternoEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNSS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRFC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCURP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMontoPagado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pcInformacionNomina = new DevExpress.XtraEditors.PanelControl();
            this.pcBotonesChkList = new DevExpress.XtraEditors.PanelControl();
            this.lblNoFoliosSeleccionados = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
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
            this.stpSelFolioLoteCargaNominaBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.splashSMCargando = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::winAppSAIC.frmxCargandoInformacion), true, true);
            this.stpSelInfoDetalleLoteCargaNominaTableAdapter1 = new winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.stpSelInfoDetalleLoteCargaNominaTableAdapter();
            this.seguridadTableAdapter1 = new winAppSAIC.NominaCFDI.dbSAICBPONominaCFDIDataSetTableAdapters.SeguridadTableAdapter();
            this.stpSelInfoCancelacionDetalleLoteCargaNominaTimbradosCFDITableAdapter = new winAppSAIC.NominaCFDI.dbSAICBPONominaCFDIDataSetTableAdapters.stpSelInfoCancelacionDetalleLoteCargaNominaTimbradosCFDITableAdapter();
            this.stpSelObtenerEstatusNominaSueldosVsTimbradoTableAdapter1 = new winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.stpSelObtenerEstatusNominaSueldosVsTimbradoTableAdapter();
            this.sfdRutaArchivo = new System.Windows.Forms.SaveFileDialog();
            this.stpSelInfoCancelacionDetalleLoteCargaNominaRegistroTableAdapter = new winAppSAIC.dbSAICBPODataSetTableAdapters.stpSelInfoCancelacionDetalleLoteCargaNominaRegistroTableAdapter();
            this.stpSelFolioLoteCargaNominaTableAdapter = new winAppSAIC.dbSAICBPODataSetTableAdapters.stpSelFolioLoteCargaNominaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPONominaCFDIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelFolioLoteCargaNominaTimbradosCFDIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelFolioLoteCargaNominaTimbradosCFDIBindingNavigator)).BeginInit();
            this.stpSelFolioLoteCargaNominaTimbradosCFDIBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelInfoCancelacionDetalleLoteCargaNominaTimbradosCFDIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelFolioLoteCargaNominaTimbradosCFDIGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelInfoCancelacionDetalleLoteCargaNominaRegistroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcInformacionNomina)).BeginInit();
            this.pcInformacionNomina.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.stpSelFolioLoteCargaNominaBindingSource)).BeginInit();
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
            // stpSelFolioLoteCargaNominaTimbradosCFDIBindingSource
            // 
            this.stpSelFolioLoteCargaNominaTimbradosCFDIBindingSource.DataMember = "stpSelFolioLoteCargaNominaTimbradosCFDI";
            this.stpSelFolioLoteCargaNominaTimbradosCFDIBindingSource.DataSource = this.dbSAICBPONominaCFDIDataSet;
            // 
            // stpSelFolioLoteCargaNominaTimbradosCFDITableAdapter
            // 
            this.stpSelFolioLoteCargaNominaTimbradosCFDITableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = winAppSAIC.NominaCFDI.dbSAICBPONominaCFDIDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // stpSelFolioLoteCargaNominaTimbradosCFDIBindingNavigator
            // 
            this.stpSelFolioLoteCargaNominaTimbradosCFDIBindingNavigator.AddNewItem = null;
            this.stpSelFolioLoteCargaNominaTimbradosCFDIBindingNavigator.BindingSource = this.stpSelInfoCancelacionDetalleLoteCargaNominaTimbradosCFDIBindingSource;
            this.stpSelFolioLoteCargaNominaTimbradosCFDIBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.stpSelFolioLoteCargaNominaTimbradosCFDIBindingNavigator.CountItemFormat = "de {0}";
            this.stpSelFolioLoteCargaNominaTimbradosCFDIBindingNavigator.DeleteItem = null;
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
            this.btnCancelarXML,
            this.toolStripSeparator1,
            this.btnSalir});
            this.stpSelFolioLoteCargaNominaTimbradosCFDIBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.stpSelFolioLoteCargaNominaTimbradosCFDIBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.stpSelFolioLoteCargaNominaTimbradosCFDIBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.stpSelFolioLoteCargaNominaTimbradosCFDIBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.stpSelFolioLoteCargaNominaTimbradosCFDIBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.stpSelFolioLoteCargaNominaTimbradosCFDIBindingNavigator.Name = "stpSelFolioLoteCargaNominaTimbradosCFDIBindingNavigator";
            this.stpSelFolioLoteCargaNominaTimbradosCFDIBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.stpSelFolioLoteCargaNominaTimbradosCFDIBindingNavigator.Size = new System.Drawing.Size(1067, 25);
            this.stpSelFolioLoteCargaNominaTimbradosCFDIBindingNavigator.TabIndex = 0;
            this.stpSelFolioLoteCargaNominaTimbradosCFDIBindingNavigator.Text = "bindingNavigator1";
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
            this.btnCancelarXML.Image = global::winAppSAIC.Properties.Resources.DocsCancelados32x32_2;
            this.btnCancelarXML.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelarXML.Name = "btnCancelarXML";
            this.btnCancelarXML.Size = new System.Drawing.Size(172, 22);
            this.btnCancelarXML.Text = "Eliminar Registros Nómina";
            this.btnCancelarXML.Click += new System.EventHandler(this.btnCancelarXML_Click);
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
            // stpSelFolioLoteCargaNominaTimbradosCFDIGridControl
            // 
            this.stpSelFolioLoteCargaNominaTimbradosCFDIGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.stpSelFolioLoteCargaNominaTimbradosCFDIGridControl.DataSource = this.stpSelInfoCancelacionDetalleLoteCargaNominaRegistroBindingSource;
            this.stpSelFolioLoteCargaNominaTimbradosCFDIGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stpSelFolioLoteCargaNominaTimbradosCFDIGridControl.Location = new System.Drawing.Point(2, 2);
            this.stpSelFolioLoteCargaNominaTimbradosCFDIGridControl.MainView = this.gridView1;
            this.stpSelFolioLoteCargaNominaTimbradosCFDIGridControl.Name = "stpSelFolioLoteCargaNominaTimbradosCFDIGridControl";
            this.stpSelFolioLoteCargaNominaTimbradosCFDIGridControl.Size = new System.Drawing.Size(1063, 250);
            this.stpSelFolioLoteCargaNominaTimbradosCFDIGridControl.TabIndex = 1;
            this.stpSelFolioLoteCargaNominaTimbradosCFDIGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // stpSelInfoCancelacionDetalleLoteCargaNominaRegistroBindingSource
            // 
            this.stpSelInfoCancelacionDetalleLoteCargaNominaRegistroBindingSource.DataMember = "stpSelInfoCancelacionDetalleLoteCargaNominaRegistro";
            this.stpSelInfoCancelacionDetalleLoteCargaNominaRegistroBindingSource.DataSource = this.dbSAICBPODataSet;
            // 
            // dbSAICBPODataSet
            // 
            this.dbSAICBPODataSet.DataSetName = "dbSAICBPODataSet";
            this.dbSAICBPODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdPDOHeaderCFDI,
            this.colIdEmpleado,
            this.colAPaternoEmpleado,
            this.colAMaternoEmpleado,
            this.colNombreEmpleado,
            this.colNSS,
            this.colRFC,
            this.colCURP,
            this.colMontoPagado});
            this.gridView1.GridControl = this.stpSelFolioLoteCargaNominaTimbradosCFDIGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIdPDOHeaderCFDI
            // 
            this.colIdPDOHeaderCFDI.Caption = "No. Control SAIC";
            this.colIdPDOHeaderCFDI.FieldName = "IdPDOHeader";
            this.colIdPDOHeaderCFDI.Name = "colIdPDOHeaderCFDI";
            this.colIdPDOHeaderCFDI.OptionsColumn.ReadOnly = true;
            this.colIdPDOHeaderCFDI.Visible = true;
            this.colIdPDOHeaderCFDI.VisibleIndex = 0;
            this.colIdPDOHeaderCFDI.Width = 103;
            // 
            // colIdEmpleado
            // 
            this.colIdEmpleado.Caption = "No. Empleado";
            this.colIdEmpleado.FieldName = "NoEmpleado";
            this.colIdEmpleado.Name = "colIdEmpleado";
            this.colIdEmpleado.Visible = true;
            this.colIdEmpleado.VisibleIndex = 1;
            this.colIdEmpleado.Width = 85;
            // 
            // colAPaternoEmpleado
            // 
            this.colAPaternoEmpleado.Caption = "Apellido Paterno";
            this.colAPaternoEmpleado.FieldName = "APaternoEmpleado";
            this.colAPaternoEmpleado.Name = "colAPaternoEmpleado";
            this.colAPaternoEmpleado.Visible = true;
            this.colAPaternoEmpleado.VisibleIndex = 2;
            this.colAPaternoEmpleado.Width = 130;
            // 
            // colAMaternoEmpleado
            // 
            this.colAMaternoEmpleado.Caption = "Apellido Materno";
            this.colAMaternoEmpleado.FieldName = "AMaternoEmpleado";
            this.colAMaternoEmpleado.Name = "colAMaternoEmpleado";
            this.colAMaternoEmpleado.Visible = true;
            this.colAMaternoEmpleado.VisibleIndex = 3;
            this.colAMaternoEmpleado.Width = 130;
            // 
            // colNombreEmpleado
            // 
            this.colNombreEmpleado.Caption = "Nombre";
            this.colNombreEmpleado.FieldName = "NombreEmpleado";
            this.colNombreEmpleado.Name = "colNombreEmpleado";
            this.colNombreEmpleado.Visible = true;
            this.colNombreEmpleado.VisibleIndex = 4;
            this.colNombreEmpleado.Width = 130;
            // 
            // colNSS
            // 
            this.colNSS.FieldName = "NSS";
            this.colNSS.Name = "colNSS";
            this.colNSS.Visible = true;
            this.colNSS.VisibleIndex = 5;
            this.colNSS.Width = 114;
            // 
            // colRFC
            // 
            this.colRFC.FieldName = "RFC";
            this.colRFC.Name = "colRFC";
            this.colRFC.Visible = true;
            this.colRFC.VisibleIndex = 6;
            this.colRFC.Width = 114;
            // 
            // colCURP
            // 
            this.colCURP.FieldName = "CURP";
            this.colCURP.Name = "colCURP";
            this.colCURP.Visible = true;
            this.colCURP.VisibleIndex = 7;
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
            this.colMontoPagado.VisibleIndex = 8;
            this.colMontoPagado.Width = 100;
            // 
            // pcInformacionNomina
            // 
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
            this.pcInformacionNomina.Size = new System.Drawing.Size(1067, 207);
            this.pcInformacionNomina.TabIndex = 2;
            // 
            // pcBotonesChkList
            // 
            this.pcBotonesChkList.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.pcBotonesChkList.Appearance.Options.UseBackColor = true;
            this.pcBotonesChkList.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pcBotonesChkList.Controls.Add(this.lblNoFoliosSeleccionados);
            this.pcBotonesChkList.Controls.Add(this.labelControl8);
            this.pcBotonesChkList.Controls.Add(this.btnDeseleccionarTodo);
            this.pcBotonesChkList.Controls.Add(this.btnSeleccionarTodos);
            this.pcBotonesChkList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pcBotonesChkList.Location = new System.Drawing.Point(2, 172);
            this.pcBotonesChkList.Name = "pcBotonesChkList";
            this.pcBotonesChkList.Size = new System.Drawing.Size(1063, 33);
            this.pcBotonesChkList.TabIndex = 47;
            // 
            // lblNoFoliosSeleccionados
            // 
            this.lblNoFoliosSeleccionados.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoFoliosSeleccionados.Appearance.Options.UseFont = true;
            this.lblNoFoliosSeleccionados.Location = new System.Drawing.Point(983, 9);
            this.lblNoFoliosSeleccionados.Name = "lblNoFoliosSeleccionados";
            this.lblNoFoliosSeleccionados.Size = new System.Drawing.Size(8, 14);
            this.lblNoFoliosSeleccionados.TabIndex = 24;
            this.lblNoFoliosSeleccionados.Text = "0";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(841, 9);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(135, 14);
            this.labelControl8.TabIndex = 23;
            this.labelControl8.Text = "Folios seleccionados =";
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
            this.txtFechaPago.Location = new System.Drawing.Point(133, 100);
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
            this.labelControl6.Location = new System.Drawing.Point(71, 104);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(56, 13);
            this.labelControl6.TabIndex = 44;
            this.labelControl6.Text = "Fecha Pago";
            // 
            // chkEstatusNominaContabilizada
            // 
            this.chkEstatusNominaContabilizada.Enabled = false;
            this.chkEstatusNominaContabilizada.Location = new System.Drawing.Point(303, 101);
            this.chkEstatusNominaContabilizada.Name = "chkEstatusNominaContabilizada";
            this.chkEstatusNominaContabilizada.Properties.Caption = "Contabilizada";
            this.chkEstatusNominaContabilizada.Size = new System.Drawing.Size(116, 19);
            this.chkEstatusNominaContabilizada.TabIndex = 46;
            this.chkEstatusNominaContabilizada.TabStop = false;
            // 
            // txtPeriodoPago
            // 
            this.txtPeriodoPago.Enabled = false;
            this.txtPeriodoPago.Location = new System.Drawing.Point(843, 68);
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
            this.txtNombreOperador.Location = new System.Drawing.Point(133, 72);
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
            this.txtTipoNomina.Location = new System.Drawing.Point(600, 69);
            this.txtTipoNomina.Name = "txtTipoNomina";
            this.txtTipoNomina.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtTipoNomina.Properties.Appearance.Options.UseBackColor = true;
            this.txtTipoNomina.Size = new System.Drawing.Size(141, 20);
            this.txtTipoNomina.TabIndex = 41;
            this.txtTipoNomina.TabStop = false;
            // 
            // txtNombreComercialCliente
            // 
            this.txtNombreComercialCliente.Enabled = false;
            this.txtNombreComercialCliente.Location = new System.Drawing.Point(600, 39);
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
            this.txtNombreComercialTenedora.Location = new System.Drawing.Point(133, 42);
            this.txtNombreComercialTenedora.Name = "txtNombreComercialTenedora";
            this.txtNombreComercialTenedora.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtNombreComercialTenedora.Properties.Appearance.Options.UseBackColor = true;
            this.txtNombreComercialTenedora.Size = new System.Drawing.Size(392, 20);
            this.txtNombreComercialTenedora.TabIndex = 35;
            this.txtNombreComercialTenedora.TabStop = false;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(536, 73);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(58, 13);
            this.labelControl5.TabIndex = 40;
            this.labelControl5.Text = "Tipo Nómina";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(801, 72);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(36, 13);
            this.labelControl4.TabIndex = 42;
            this.labelControl4.Text = "Periodo";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(81, 76);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(46, 13);
            this.labelControl3.TabIndex = 38;
            this.labelControl3.Text = "Operador";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(561, 43);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(33, 13);
            this.labelControl2.TabIndex = 36;
            this.labelControl2.Text = "Cliente";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(81, 46);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 13);
            this.labelControl1.TabIndex = 34;
            this.labelControl1.Text = "Tenedora";
            // 
            // cboFolioLoteCargaNomina
            // 
            this.cboFolioLoteCargaNomina.EditValue = "";
            this.cboFolioLoteCargaNomina.Location = new System.Drawing.Point(133, 14);
            this.cboFolioLoteCargaNomina.Name = "cboFolioLoteCargaNomina";
            this.cboFolioLoteCargaNomina.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
            this.cboFolioLoteCargaNomina.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboFolioLoteCargaNomina.Properties.DataSource = this.stpSelFolioLoteCargaNominaBindingSource;
            this.cboFolioLoteCargaNomina.Properties.DisplayMember = "FolioLoteCargaNomina";
            this.cboFolioLoteCargaNomina.Properties.NullText = "";
            this.cboFolioLoteCargaNomina.Properties.ValueMember = "IdLoteCargaNomina";
            this.cboFolioLoteCargaNomina.Properties.View = this.gridLookUpEdit1View;
            this.cboFolioLoteCargaNomina.Size = new System.Drawing.Size(250, 20);
            this.cboFolioLoteCargaNomina.TabIndex = 33;
            this.cboFolioLoteCargaNomina.EditValueChanged += new System.EventHandler(this.cboFolioLoteCargaNomina_EditValueChanged);
            // 
            // stpSelFolioLoteCargaNominaBindingSource
            // 
            this.stpSelFolioLoteCargaNominaBindingSource.DataMember = "stpSelFolioLoteCargaNomina";
            this.stpSelFolioLoteCargaNominaBindingSource.DataSource = this.dbSAICBPODataSet;
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
            this.lblFolio.Location = new System.Drawing.Point(11, 17);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(116, 13);
            this.lblFolio.TabIndex = 32;
            this.lblFolio.Text = "Folio Lote Carga Nómina";
            // 
            // pcSerieFolios
            // 
            this.pcSerieFolios.Controls.Add(this.chkListNominas);
            this.pcSerieFolios.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pcSerieFolios.Location = new System.Drawing.Point(0, 486);
            this.pcSerieFolios.Name = "pcSerieFolios";
            this.pcSerieFolios.Size = new System.Drawing.Size(1067, 179);
            this.pcSerieFolios.TabIndex = 3;
            // 
            // chkListNominas
            // 
            this.chkListNominas.Appearance.BorderColor = System.Drawing.Color.Blue;
            this.chkListNominas.Appearance.Options.UseBorderColor = true;
            this.chkListNominas.CheckOnClick = true;
            this.chkListNominas.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkListNominas.DataSource = this.stpSelInfoCancelacionDetalleLoteCargaNominaRegistroBindingSource;
            this.chkListNominas.DisplayMember = "IdPDOHeader";
            this.chkListNominas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkListNominas.HorizontalScrollbar = true;
            this.chkListNominas.Location = new System.Drawing.Point(2, 2);
            this.chkListNominas.MultiColumn = true;
            this.chkListNominas.Name = "chkListNominas";
            this.chkListNominas.Size = new System.Drawing.Size(1063, 175);
            this.chkListNominas.TabIndex = 6;
            this.chkListNominas.ValueMember = "IdPDOHeader";
            this.chkListNominas.ItemCheck += new DevExpress.XtraEditors.Controls.ItemCheckEventHandler(this.chkListNominas_ItemCheck);
            this.chkListNominas.DrawItem += new DevExpress.XtraEditors.ListBoxDrawItemEventHandler(this.chkListNominas_DrawItem);
            // 
            // pcGridview
            // 
            this.pcGridview.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pcGridview.Appearance.Options.UseBackColor = true;
            this.pcGridview.Controls.Add(this.stpSelFolioLoteCargaNominaTimbradosCFDIGridControl);
            this.pcGridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcGridview.Location = new System.Drawing.Point(0, 232);
            this.pcGridview.Name = "pcGridview";
            this.pcGridview.Size = new System.Drawing.Size(1067, 254);
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
            // stpSelInfoCancelacionDetalleLoteCargaNominaRegistroTableAdapter
            // 
            this.stpSelInfoCancelacionDetalleLoteCargaNominaRegistroTableAdapter.ClearBeforeFill = true;
            // 
            // stpSelFolioLoteCargaNominaTableAdapter
            // 
            this.stpSelFolioLoteCargaNominaTableAdapter.ClearBeforeFill = true;
            // 
            // frmxEliminarRegistrosNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 665);
            this.ControlBox = false;
            this.Controls.Add(this.pcGridview);
            this.Controls.Add(this.pcSerieFolios);
            this.Controls.Add(this.pcInformacionNomina);
            this.Controls.Add(this.stpSelFolioLoteCargaNominaTimbradosCFDIBindingNavigator);
            this.Name = "frmxEliminarRegistrosNomina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar Registros de  Nomina";
            this.Load += new System.EventHandler(this.frmxCancelarXMLCFDI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPONominaCFDIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelFolioLoteCargaNominaTimbradosCFDIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelFolioLoteCargaNominaTimbradosCFDIBindingNavigator)).EndInit();
            this.stpSelFolioLoteCargaNominaTimbradosCFDIBindingNavigator.ResumeLayout(false);
            this.stpSelFolioLoteCargaNominaTimbradosCFDIBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelInfoCancelacionDetalleLoteCargaNominaTimbradosCFDIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelFolioLoteCargaNominaTimbradosCFDIGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelInfoCancelacionDetalleLoteCargaNominaRegistroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcInformacionNomina)).EndInit();
            this.pcInformacionNomina.ResumeLayout(false);
            this.pcInformacionNomina.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBotonesChkList)).EndInit();
            this.pcBotonesChkList.ResumeLayout(false);
            this.pcBotonesChkList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFechaPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEstatusNominaContabilizada.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodoPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreOperador.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoNomina.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreComercialCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreComercialTenedora.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFolioLoteCargaNomina.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelFolioLoteCargaNominaBindingSource)).EndInit();
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

        private NominaCFDI.dbSAICBPONominaCFDIDataSet dbSAICBPONominaCFDIDataSet;
        private System.Windows.Forms.BindingSource stpSelFolioLoteCargaNominaTimbradosCFDIBindingSource;
        private NominaCFDI.dbSAICBPONominaCFDIDataSetTableAdapters.stpSelFolioLoteCargaNominaTimbradosCFDITableAdapter stpSelFolioLoteCargaNominaTimbradosCFDITableAdapter;
        private NominaCFDI.dbSAICBPONominaCFDIDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator stpSelFolioLoteCargaNominaTimbradosCFDIBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
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
        private dbSAICBPOReportesDataSetTableAdapters.stpSelInfoDetalleLoteCargaNominaTableAdapter stpSelInfoDetalleLoteCargaNominaTableAdapter1;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private DevExpress.XtraEditors.PanelControl pcBotonesChkList;
        private DevExpress.XtraEditors.SimpleButton btnDeseleccionarTodo;
        private DevExpress.XtraEditors.SimpleButton btnSeleccionarTodos;
        private System.Windows.Forms.ToolStripButton btnCancelarXML;
        private NominaCFDI.dbSAICBPONominaCFDIDataSetTableAdapters.SeguridadTableAdapter seguridadTableAdapter1;
        private System.Windows.Forms.BindingSource stpSelInfoCancelacionDetalleLoteCargaNominaTimbradosCFDIBindingSource;
        private NominaCFDI.dbSAICBPONominaCFDIDataSetTableAdapters.stpSelInfoCancelacionDetalleLoteCargaNominaTimbradosCFDITableAdapter stpSelInfoCancelacionDetalleLoteCargaNominaTimbradosCFDITableAdapter;
        private dbSAICBPOReportesDataSetTableAdapters.stpSelObtenerEstatusNominaSueldosVsTimbradoTableAdapter stpSelObtenerEstatusNominaSueldosVsTimbradoTableAdapter1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.SaveFileDialog sfdRutaArchivo;
        private DevExpress.XtraEditors.LabelControl lblNoFoliosSeleccionados;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashSMProcesando;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashSMCargando;
        private System.Windows.Forms.BindingSource stpSelInfoCancelacionDetalleLoteCargaNominaRegistroBindingSource;
        private dbSAICBPODataSet dbSAICBPODataSet;
        private dbSAICBPODataSetTableAdapters.stpSelInfoCancelacionDetalleLoteCargaNominaRegistroTableAdapter stpSelInfoCancelacionDetalleLoteCargaNominaRegistroTableAdapter;
        private System.Windows.Forms.BindingSource stpSelFolioLoteCargaNominaBindingSource;
        private dbSAICBPODataSetTableAdapters.stpSelFolioLoteCargaNominaTableAdapter stpSelFolioLoteCargaNominaTableAdapter;
    }
}