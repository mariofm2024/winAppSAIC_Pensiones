namespace winAppSAIC
{
    partial class frmxControlRecibosFirmadosAlimentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmxControlRecibosFirmadosAlimentos));
            this.dbSAICBPOReportesDataSet = new winAppSAIC.dbSAICBPOReportesDataSet();
            this.pDOHeaderSCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pDOHeaderSCTableAdapter = new winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.PDOHeaderSCTableAdapter();
            this.tableAdapterManager = new winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.TableAdapterManager();
            this.pDOHeaderSCBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.pDOHeaderSCBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.pDOHeaderSCGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdPDOHeader = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaInicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaFin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoRecibo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNSS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRFC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCURP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImporte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReciboFirmado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioModificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pcFolioLoteCargaNomina = new DevExpress.XtraEditors.PanelControl();
            this.cboFolioLoteCargaNomina = new DevExpress.XtraEditors.GridLookUpEdit();
            this.stpSelFolioLoteCargaNominaSCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPODataSet = new winAppSAIC.dbSAICBPODataSet();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdLoteCargaNomina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFolioLoteCargaNomina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenedora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOperador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblFolio = new DevExpress.XtraEditors.LabelControl();
            this.stpSelFolioLoteCargaNominaSCTableAdapter = new winAppSAIC.dbSAICBPODataSetTableAdapters.stpSelFolioLoteCargaNominaSCTableAdapter();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.splashSMCargando = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::winAppSAIC.frmxCargandoInformacion), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOReportesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDOHeaderSCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDOHeaderSCBindingNavigator)).BeginInit();
            this.pDOHeaderSCBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pDOHeaderSCGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcFolioLoteCargaNomina)).BeginInit();
            this.pcFolioLoteCargaNomina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboFolioLoteCargaNomina.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelFolioLoteCargaNominaSCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dbSAICBPOReportesDataSet
            // 
            this.dbSAICBPOReportesDataSet.DataSetName = "dbSAICBPOReportesDataSet";
            this.dbSAICBPOReportesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pDOHeaderSCBindingSource
            // 
            this.pDOHeaderSCBindingSource.DataMember = "PDOHeaderSC";
            this.pDOHeaderSCBindingSource.DataSource = this.dbSAICBPOReportesDataSet;
            // 
            // pDOHeaderSCTableAdapter
            // 
            this.pDOHeaderSCTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PDOHeaderSATableAdapter = null;
            this.tableAdapterManager.PDOHeaderSCTableAdapter = this.pDOHeaderSCTableAdapter;
            this.tableAdapterManager.UpdateOrder = winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pDOHeaderSCBindingNavigator
            // 
            this.pDOHeaderSCBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pDOHeaderSCBindingNavigator.BindingSource = this.pDOHeaderSCBindingSource;
            this.pDOHeaderSCBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pDOHeaderSCBindingNavigator.CountItemFormat = "de {0}";
            this.pDOHeaderSCBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pDOHeaderSCBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pDOHeaderSCBindingNavigatorSaveItem,
            this.btnSalir});
            this.pDOHeaderSCBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pDOHeaderSCBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pDOHeaderSCBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pDOHeaderSCBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pDOHeaderSCBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pDOHeaderSCBindingNavigator.Name = "pDOHeaderSCBindingNavigator";
            this.pDOHeaderSCBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pDOHeaderSCBindingNavigator.Size = new System.Drawing.Size(934, 25);
            this.pDOHeaderSCBindingNavigator.TabIndex = 0;
            this.pDOHeaderSCBindingNavigator.Text = "bindingNavigator1";
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
            // pDOHeaderSCBindingNavigatorSaveItem
            // 
            this.pDOHeaderSCBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pDOHeaderSCBindingNavigatorSaveItem.Image")));
            this.pDOHeaderSCBindingNavigatorSaveItem.Name = "pDOHeaderSCBindingNavigatorSaveItem";
            this.pDOHeaderSCBindingNavigatorSaveItem.Size = new System.Drawing.Size(69, 22);
            this.pDOHeaderSCBindingNavigatorSaveItem.Text = "Guardar";
            this.pDOHeaderSCBindingNavigatorSaveItem.Click += new System.EventHandler(this.pDOHeaderSCBindingNavigatorSaveItem_Click);
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
            // pDOHeaderSCGridControl
            // 
            this.pDOHeaderSCGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.pDOHeaderSCGridControl.DataSource = this.pDOHeaderSCBindingSource;
            this.pDOHeaderSCGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDOHeaderSCGridControl.Location = new System.Drawing.Point(2, 2);
            this.pDOHeaderSCGridControl.MainView = this.gridView1;
            this.pDOHeaderSCGridControl.Name = "pDOHeaderSCGridControl";
            this.pDOHeaderSCGridControl.Size = new System.Drawing.Size(930, 384);
            this.pDOHeaderSCGridControl.TabIndex = 2;
            this.pDOHeaderSCGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdPDOHeader,
            this.colFechaInicio,
            this.colFechaFin,
            this.colNoRecibo,
            this.colNombreEmpleado,
            this.colNSS,
            this.colRFC,
            this.colCURP,
            this.colImporte,
            this.colReciboFirmado,
            this.colUsuarioModificacion});
            this.gridView1.GridControl = this.pDOHeaderSCGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIdPDOHeader
            // 
            this.colIdPDOHeader.FieldName = "IdPDOHeader";
            this.colIdPDOHeader.Name = "colIdPDOHeader";
            this.colIdPDOHeader.OptionsColumn.ReadOnly = true;
            // 
            // colFechaInicio
            // 
            this.colFechaInicio.AppearanceCell.Options.UseTextOptions = true;
            this.colFechaInicio.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFechaInicio.AppearanceHeader.Options.UseTextOptions = true;
            this.colFechaInicio.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFechaInicio.FieldName = "FechaInicio";
            this.colFechaInicio.Name = "colFechaInicio";
            this.colFechaInicio.OptionsColumn.AllowEdit = false;
            this.colFechaInicio.Visible = true;
            this.colFechaInicio.VisibleIndex = 0;
            this.colFechaInicio.Width = 87;
            // 
            // colFechaFin
            // 
            this.colFechaFin.AppearanceCell.Options.UseTextOptions = true;
            this.colFechaFin.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFechaFin.AppearanceHeader.Options.UseTextOptions = true;
            this.colFechaFin.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFechaFin.FieldName = "FechaFin";
            this.colFechaFin.Name = "colFechaFin";
            this.colFechaFin.OptionsColumn.AllowEdit = false;
            this.colFechaFin.Visible = true;
            this.colFechaFin.VisibleIndex = 1;
            this.colFechaFin.Width = 87;
            // 
            // colNoRecibo
            // 
            this.colNoRecibo.AppearanceCell.Options.UseTextOptions = true;
            this.colNoRecibo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNoRecibo.AppearanceHeader.Options.UseTextOptions = true;
            this.colNoRecibo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNoRecibo.FieldName = "NoRecibo";
            this.colNoRecibo.Name = "colNoRecibo";
            this.colNoRecibo.OptionsColumn.AllowEdit = false;
            this.colNoRecibo.Visible = true;
            this.colNoRecibo.VisibleIndex = 2;
            this.colNoRecibo.Width = 116;
            // 
            // colNombreEmpleado
            // 
            this.colNombreEmpleado.FieldName = "NombreEmpleado";
            this.colNombreEmpleado.Name = "colNombreEmpleado";
            this.colNombreEmpleado.OptionsColumn.AllowEdit = false;
            this.colNombreEmpleado.Visible = true;
            this.colNombreEmpleado.VisibleIndex = 3;
            this.colNombreEmpleado.Width = 302;
            // 
            // colNSS
            // 
            this.colNSS.FieldName = "NSS";
            this.colNSS.Name = "colNSS";
            this.colNSS.OptionsColumn.AllowEdit = false;
            // 
            // colRFC
            // 
            this.colRFC.AppearanceCell.Options.UseTextOptions = true;
            this.colRFC.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRFC.AppearanceHeader.Options.UseTextOptions = true;
            this.colRFC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRFC.FieldName = "RFC";
            this.colRFC.Name = "colRFC";
            this.colRFC.OptionsColumn.AllowEdit = false;
            this.colRFC.Visible = true;
            this.colRFC.VisibleIndex = 4;
            this.colRFC.Width = 99;
            // 
            // colCURP
            // 
            this.colCURP.FieldName = "CURP";
            this.colCURP.Name = "colCURP";
            this.colCURP.OptionsColumn.AllowEdit = false;
            // 
            // colImporte
            // 
            this.colImporte.DisplayFormat.FormatString = "C2";
            this.colImporte.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colImporte.FieldName = "Importe";
            this.colImporte.Name = "colImporte";
            this.colImporte.OptionsColumn.AllowEdit = false;
            this.colImporte.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Importe", "{0:C2}")});
            this.colImporte.Visible = true;
            this.colImporte.VisibleIndex = 5;
            this.colImporte.Width = 99;
            // 
            // colReciboFirmado
            // 
            this.colReciboFirmado.AppearanceHeader.Options.UseTextOptions = true;
            this.colReciboFirmado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colReciboFirmado.Caption = "Firmado";
            this.colReciboFirmado.FieldName = "ReciboFirmado";
            this.colReciboFirmado.Name = "colReciboFirmado";
            this.colReciboFirmado.Visible = true;
            this.colReciboFirmado.VisibleIndex = 6;
            this.colReciboFirmado.Width = 100;
            // 
            // colUsuarioModificacion
            // 
            this.colUsuarioModificacion.FieldName = "UsuarioModificacion";
            this.colUsuarioModificacion.Name = "colUsuarioModificacion";
            // 
            // pcFolioLoteCargaNomina
            // 
            this.pcFolioLoteCargaNomina.Controls.Add(this.cboFolioLoteCargaNomina);
            this.pcFolioLoteCargaNomina.Controls.Add(this.lblFolio);
            this.pcFolioLoteCargaNomina.Dock = System.Windows.Forms.DockStyle.Top;
            this.pcFolioLoteCargaNomina.Location = new System.Drawing.Point(0, 25);
            this.pcFolioLoteCargaNomina.Name = "pcFolioLoteCargaNomina";
            this.pcFolioLoteCargaNomina.Size = new System.Drawing.Size(934, 48);
            this.pcFolioLoteCargaNomina.TabIndex = 9;
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
            this.cboFolioLoteCargaNomina.Size = new System.Drawing.Size(239, 20);
            this.cboFolioLoteCargaNomina.TabIndex = 5;
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
            this.colIdLoteCargaNomina,
            this.colFolioLoteCargaNomina,
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
            this.colIdLoteCargaNomina.Width = 20;
            // 
            // colFolioLoteCargaNomina
            // 
            this.colFolioLoteCargaNomina.Caption = "Folio Lote Carga Nómina";
            this.colFolioLoteCargaNomina.FieldName = "FolioLoteCargaNomina";
            this.colFolioLoteCargaNomina.Name = "colFolioLoteCargaNomina";
            this.colFolioLoteCargaNomina.Visible = true;
            this.colFolioLoteCargaNomina.VisibleIndex = 1;
            this.colFolioLoteCargaNomina.Width = 28;
            // 
            // colTenedora
            // 
            this.colTenedora.Caption = "Tenedora";
            this.colTenedora.FieldName = "Tenedora";
            this.colTenedora.Name = "colTenedora";
            this.colTenedora.Visible = true;
            this.colTenedora.VisibleIndex = 2;
            this.colTenedora.Width = 79;
            // 
            // colCliente
            // 
            this.colCliente.Caption = "Cliente";
            this.colCliente.FieldName = "Cliente";
            this.colCliente.Name = "colCliente";
            this.colCliente.Visible = true;
            this.colCliente.VisibleIndex = 3;
            this.colCliente.Width = 120;
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
            this.lblFolio.TabIndex = 6;
            this.lblFolio.Text = "Folio Lote Carga Nómina";
            // 
            // stpSelFolioLoteCargaNominaSCTableAdapter
            // 
            this.stpSelFolioLoteCargaNominaSCTableAdapter.ClearBeforeFill = true;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.pDOHeaderSCGridControl);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 73);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(934, 388);
            this.panelControl1.TabIndex = 10;
            // 
            // frmxControlRecibosFirmadosAlimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 461);
            this.ControlBox = false;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.pcFolioLoteCargaNomina);
            this.Controls.Add(this.pDOHeaderSCBindingNavigator);
            this.Name = "frmxControlRecibosFirmadosAlimentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Recibos Firmados S.C.";
            this.Load += new System.EventHandler(this.frmxControlRecibosFirmadosAlimentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOReportesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDOHeaderSCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDOHeaderSCBindingNavigator)).EndInit();
            this.pDOHeaderSCBindingNavigator.ResumeLayout(false);
            this.pDOHeaderSCBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pDOHeaderSCGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcFolioLoteCargaNomina)).EndInit();
            this.pcFolioLoteCargaNomina.ResumeLayout(false);
            this.pcFolioLoteCargaNomina.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboFolioLoteCargaNomina.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelFolioLoteCargaNominaSCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dbSAICBPOReportesDataSet dbSAICBPOReportesDataSet;
        private System.Windows.Forms.BindingSource pDOHeaderSCBindingSource;
        private dbSAICBPOReportesDataSetTableAdapters.PDOHeaderSCTableAdapter pDOHeaderSCTableAdapter;
        private dbSAICBPOReportesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pDOHeaderSCBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pDOHeaderSCBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl pDOHeaderSCGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPDOHeader;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaInicio;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaFin;
        private DevExpress.XtraGrid.Columns.GridColumn colNoRecibo;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn colNSS;
        private DevExpress.XtraGrid.Columns.GridColumn colRFC;
        private DevExpress.XtraGrid.Columns.GridColumn colCURP;
        private DevExpress.XtraGrid.Columns.GridColumn colImporte;
        private DevExpress.XtraGrid.Columns.GridColumn colReciboFirmado;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioModificacion;
        private DevExpress.XtraEditors.PanelControl pcFolioLoteCargaNomina;
        private DevExpress.XtraEditors.GridLookUpEdit cboFolioLoteCargaNomina;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colIdLoteCargaNomina;
        private DevExpress.XtraGrid.Columns.GridColumn colFolioLoteCargaNomina;
        private DevExpress.XtraGrid.Columns.GridColumn colTenedora;
        private DevExpress.XtraGrid.Columns.GridColumn colCliente;
        private DevExpress.XtraEditors.LabelControl lblFolio;
        private dbSAICBPODataSet dbSAICBPODataSet;
        private System.Windows.Forms.BindingSource stpSelFolioLoteCargaNominaSCBindingSource;
        private dbSAICBPODataSetTableAdapters.stpSelFolioLoteCargaNominaSCTableAdapter stpSelFolioLoteCargaNominaSCTableAdapter;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private DevExpress.XtraGrid.Columns.GridColumn colOperador;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashSMCargando;
    }
}