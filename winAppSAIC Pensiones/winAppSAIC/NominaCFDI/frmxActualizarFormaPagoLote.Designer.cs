namespace winAppSAIC.NominaCFDI
{
    partial class frmxActualizarFormaPagoLote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmxActualizarFormaPagoLote));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions4 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject13 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject14 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject15 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject16 = new DevExpress.Utils.SerializableAppearanceObject();
            this.stpSelNominaCFDIBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExportarExcel = new System.Windows.Forms.ToolStripButton();
            this.btnAbrirCarpeta = new System.Windows.Forms.ToolStripButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtLote = new DevExpress.XtraEditors.TextEdit();
            this.txtFolio = new DevExpress.XtraEditors.TextEdit();
            this.txtTenedora = new DevExpress.XtraEditors.TextEdit();
            this.txtObra = new DevExpress.XtraEditors.TextEdit();
            this.txtOperador = new DevExpress.XtraEditors.TextEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lnlLote = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.stpSelObtenerInfoEmpleadosLoteCargaNominaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPOCatalogosDataSet1 = new winAppSAIC.dbSAICBPOCatalogosDataSet();
            this.stpSelFormaPagoLoteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stpSelObtenerInfoEmpleadosLoteCargaNominaTableAdapter1 = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelObtenerInfoEmpleadosLoteCargaNominaTableAdapter();
            this.lblNumEmpleados = new DevExpress.XtraEditors.GroupControl();
            this.stpSelFormaPagoLoteTableAdapter1 = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelFormaPagoLoteTableAdapter();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpleadoInterno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdPDOHeader = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNSS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRFC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCURP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCLABECFDI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoCuentaBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBancoOrigen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstatusEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColFormaDePago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemGridLookUpEditFormaPago = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdFormaPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescFormaPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gColumnActualizarTipoPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnActualizar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gColumnActualizarBancoOrigen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemGridLookUpEditBancoOrigen = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.stpSelObtenerInfoBancosLoteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.stpSelFormaPagoLoteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.stpSelObtenerInfoEmpleadosDatosBancariosTableAdapter1 = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelObtenerInfoEmpleadosDatosBancariosTableAdapter();
            this.queriesTableAdapter1 = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.QueriesTableAdapter();
            this.stpSelObtenerInfoBancosLoteTableAdapter1 = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelObtenerInfoBancosLoteTableAdapter();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::winAppSAIC.frmxCargandoInformacion), true, true);
            this.stpSelObtenerBancoDeClabeTableAdapter = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelObtenerBancoDeClabeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelNominaCFDIBindingNavigator)).BeginInit();
            this.stpSelNominaCFDIBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFolio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenedora.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOperador.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelObtenerInfoEmpleadosLoteCargaNominaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelFormaPagoLoteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNumEmpleados)).BeginInit();
            this.lblNumEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemGridLookUpEditFormaPago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnActualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemGridLookUpEditBancoOrigen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelObtenerInfoBancosLoteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelFormaPagoLoteBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // stpSelNominaCFDIBindingNavigator
            // 
            this.stpSelNominaCFDIBindingNavigator.AddNewItem = null;
            this.stpSelNominaCFDIBindingNavigator.CountItem = null;
            this.stpSelNominaCFDIBindingNavigator.CountItemFormat = "de {0}";
            this.stpSelNominaCFDIBindingNavigator.DeleteItem = null;
            this.stpSelNominaCFDIBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.btnExportarExcel,
            this.btnAbrirCarpeta});
            this.stpSelNominaCFDIBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.stpSelNominaCFDIBindingNavigator.MoveFirstItem = null;
            this.stpSelNominaCFDIBindingNavigator.MoveLastItem = null;
            this.stpSelNominaCFDIBindingNavigator.MoveNextItem = null;
            this.stpSelNominaCFDIBindingNavigator.MovePreviousItem = null;
            this.stpSelNominaCFDIBindingNavigator.Name = "stpSelNominaCFDIBindingNavigator";
            this.stpSelNominaCFDIBindingNavigator.PositionItem = null;
            this.stpSelNominaCFDIBindingNavigator.Size = new System.Drawing.Size(964, 25);
            this.stpSelNominaCFDIBindingNavigator.TabIndex = 21;
            this.stpSelNominaCFDIBindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::winAppSAIC.Properties.Resources.Salir24x24;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(49, 22);
            this.toolStripButton1.Text = "Salir";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExportarExcel.Image")));
            this.btnExportarExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(99, 22);
            this.btnExportarExcel.Text = "Exportar Excel";
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // btnAbrirCarpeta
            // 
            this.btnAbrirCarpeta.Image = global::winAppSAIC.Properties.Resources.if_folder_416376;
            this.btnAbrirCarpeta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAbrirCarpeta.Name = "btnAbrirCarpeta";
            this.btnAbrirCarpeta.Size = new System.Drawing.Size(97, 22);
            this.btnAbrirCarpeta.Text = "Abrir Carpeta";
            this.btnAbrirCarpeta.Click += new System.EventHandler(this.btnAbrirCarpeta_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(30, 30);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(25, 13);
            this.labelControl1.TabIndex = 22;
            this.labelControl1.Text = "Lote:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(29, 56);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(26, 13);
            this.labelControl2.TabIndex = 24;
            this.labelControl2.Text = "Folio:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(5, 81);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(50, 13);
            this.labelControl3.TabIndex = 25;
            this.labelControl3.Text = "Tenedora:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(591, 56);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(28, 13);
            this.labelControl4.TabIndex = 26;
            this.labelControl4.Text = "Obra:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(569, 80);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(50, 13);
            this.labelControl5.TabIndex = 27;
            this.labelControl5.Text = "Operador:";
            // 
            // txtLote
            // 
            this.txtLote.Location = new System.Drawing.Point(57, 25);
            this.txtLote.Name = "txtLote";
            this.txtLote.Properties.Appearance.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtLote.Properties.Appearance.Options.UseBackColor = true;
            this.txtLote.Properties.ReadOnly = true;
            this.txtLote.Size = new System.Drawing.Size(100, 20);
            this.txtLote.TabIndex = 28;
            // 
            // txtFolio
            // 
            this.txtFolio.Location = new System.Drawing.Point(57, 51);
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Properties.Appearance.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtFolio.Properties.Appearance.Options.UseBackColor = true;
            this.txtFolio.Properties.ReadOnly = true;
            this.txtFolio.Size = new System.Drawing.Size(314, 20);
            this.txtFolio.TabIndex = 29;
            // 
            // txtTenedora
            // 
            this.txtTenedora.Location = new System.Drawing.Point(57, 77);
            this.txtTenedora.Name = "txtTenedora";
            this.txtTenedora.Properties.Appearance.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtTenedora.Properties.Appearance.Options.UseBackColor = true;
            this.txtTenedora.Properties.ReadOnly = true;
            this.txtTenedora.Size = new System.Drawing.Size(314, 20);
            this.txtTenedora.TabIndex = 30;
            // 
            // txtObra
            // 
            this.txtObra.Location = new System.Drawing.Point(621, 51);
            this.txtObra.Name = "txtObra";
            this.txtObra.Properties.Appearance.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtObra.Properties.Appearance.Options.UseBackColor = true;
            this.txtObra.Properties.ReadOnly = true;
            this.txtObra.Size = new System.Drawing.Size(314, 20);
            this.txtObra.TabIndex = 31;
            // 
            // txtOperador
            // 
            this.txtOperador.Location = new System.Drawing.Point(621, 77);
            this.txtOperador.Name = "txtOperador";
            this.txtOperador.Properties.Appearance.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtOperador.Properties.Appearance.Options.UseBackColor = true;
            this.txtOperador.Properties.ReadOnly = true;
            this.txtOperador.Size = new System.Drawing.Size(314, 20);
            this.txtOperador.TabIndex = 32;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(153)))), ((int)(((byte)(205)))));
            this.panel1.Controls.Add(this.lnlLote);
            this.panel1.Controls.Add(this.labelControl6);
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(963, 31);
            this.panel1.TabIndex = 33;
            // 
            // lnlLote
            // 
            this.lnlLote.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lnlLote.Appearance.ForeColor = System.Drawing.Color.White;
            this.lnlLote.Appearance.Options.UseFont = true;
            this.lnlLote.Appearance.Options.UseForeColor = true;
            this.lnlLote.Location = new System.Drawing.Point(9, 7);
            this.lnlLote.Name = "lnlLote";
            this.lnlLote.Size = new System.Drawing.Size(42, 16);
            this.lnlLote.TabIndex = 34;
            this.lnlLote.Text = "Lote:  ";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(784, 10);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(131, 13);
            this.labelControl6.TabIndex = 33;
            this.labelControl6.Text = "Número de Empleados: ";
            // 
            // stpSelObtenerInfoEmpleadosLoteCargaNominaBindingSource
            // 
            this.stpSelObtenerInfoEmpleadosLoteCargaNominaBindingSource.DataMember = "stpSelObtenerInfoEmpleadosLoteCargaNomina";
            this.stpSelObtenerInfoEmpleadosLoteCargaNominaBindingSource.DataSource = this.dbSAICBPOCatalogosDataSet1;
            // 
            // dbSAICBPOCatalogosDataSet1
            // 
            this.dbSAICBPOCatalogosDataSet1.DataSetName = "dbSAICBPOCatalogosDataSet";
            this.dbSAICBPOCatalogosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stpSelFormaPagoLoteBindingSource
            // 
            this.stpSelFormaPagoLoteBindingSource.DataMember = "stpSelFormaPagoLote";
            this.stpSelFormaPagoLoteBindingSource.DataSource = this.dbSAICBPOCatalogosDataSet1;
            // 
            // stpSelObtenerInfoEmpleadosLoteCargaNominaTableAdapter1
            // 
            this.stpSelObtenerInfoEmpleadosLoteCargaNominaTableAdapter1.ClearBeforeFill = true;
            // 
            // lblNumEmpleados
            // 
            this.lblNumEmpleados.Controls.Add(this.txtFolio);
            this.lblNumEmpleados.Controls.Add(this.labelControl1);
            this.lblNumEmpleados.Controls.Add(this.labelControl2);
            this.lblNumEmpleados.Controls.Add(this.txtOperador);
            this.lblNumEmpleados.Controls.Add(this.labelControl3);
            this.lblNumEmpleados.Controls.Add(this.txtObra);
            this.lblNumEmpleados.Controls.Add(this.labelControl4);
            this.lblNumEmpleados.Controls.Add(this.txtTenedora);
            this.lblNumEmpleados.Controls.Add(this.labelControl5);
            this.lblNumEmpleados.Controls.Add(this.txtLote);
            this.lblNumEmpleados.Location = new System.Drawing.Point(1016, 195);
            this.lblNumEmpleados.Name = "lblNumEmpleados";
            this.lblNumEmpleados.Size = new System.Drawing.Size(949, 104);
            this.lblNumEmpleados.TabIndex = 0;
            this.lblNumEmpleados.Text = "Lote";
            // 
            // stpSelFormaPagoLoteTableAdapter1
            // 
            this.stpSelFormaPagoLoteTableAdapter1.ClearBeforeFill = true;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl2);
            this.groupControl2.Location = new System.Drawing.Point(7, 69);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(951, 302);
            this.groupControl2.TabIndex = 34;
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.stpSelObtenerInfoEmpleadosLoteCargaNominaBindingSource;
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(2, 20);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ItemGridLookUpEditFormaPago,
            this.btnActualizar,
            this.ItemGridLookUpEditBancoOrigen});
            this.gridControl2.Size = new System.Drawing.Size(947, 280);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpleadoInterno,
            this.colIdPDOHeader,
            this.colNombreEmpleado,
            this.colNSS,
            this.colRFC,
            this.colCURP,
            this.colTipoPago,
            this.colCLABECFDI,
            this.colNoCuentaBanco,
            this.colDescBanco,
            this.colBancoOrigen,
            this.colEstatusEmpleado,
            this.gridColFormaDePago,
            this.gColumnActualizarTipoPago,
            this.gColumnActualizarBancoOrigen});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView2_RowStyle);
            this.gridView2.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.gridView2_ShowingEditor);
            this.gridView2.RowLoaded += new DevExpress.XtraGrid.Views.Base.RowEventHandler(this.gridView2_RowLoaded);
            // 
            // colIdEmpleadoInterno
            // 
            this.colIdEmpleadoInterno.Caption = "ID Empleado";
            this.colIdEmpleadoInterno.FieldName = "IdEmpleadoInterno";
            this.colIdEmpleadoInterno.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colIdEmpleadoInterno.Name = "colIdEmpleadoInterno";
            this.colIdEmpleadoInterno.OptionsColumn.ReadOnly = true;
            this.colIdEmpleadoInterno.Visible = true;
            this.colIdEmpleadoInterno.VisibleIndex = 0;
            this.colIdEmpleadoInterno.Width = 79;
            // 
            // colIdPDOHeader
            // 
            this.colIdPDOHeader.FieldName = "IdPDOHeader";
            this.colIdPDOHeader.Name = "colIdPDOHeader";
            this.colIdPDOHeader.OptionsColumn.ReadOnly = true;
            this.colIdPDOHeader.Width = 121;
            // 
            // colNombreEmpleado
            // 
            this.colNombreEmpleado.FieldName = "NombreEmpleado";
            this.colNombreEmpleado.Name = "colNombreEmpleado";
            this.colNombreEmpleado.OptionsColumn.ReadOnly = true;
            this.colNombreEmpleado.Visible = true;
            this.colNombreEmpleado.VisibleIndex = 1;
            this.colNombreEmpleado.Width = 227;
            // 
            // colNSS
            // 
            this.colNSS.FieldName = "NSS";
            this.colNSS.Name = "colNSS";
            this.colNSS.OptionsColumn.ReadOnly = true;
            this.colNSS.Visible = true;
            this.colNSS.VisibleIndex = 2;
            this.colNSS.Width = 153;
            // 
            // colRFC
            // 
            this.colRFC.FieldName = "RFC";
            this.colRFC.Name = "colRFC";
            this.colRFC.OptionsColumn.ReadOnly = true;
            this.colRFC.Visible = true;
            this.colRFC.VisibleIndex = 3;
            this.colRFC.Width = 162;
            // 
            // colCURP
            // 
            this.colCURP.FieldName = "CURP";
            this.colCURP.Name = "colCURP";
            this.colCURP.OptionsColumn.ReadOnly = true;
            this.colCURP.Visible = true;
            this.colCURP.VisibleIndex = 4;
            this.colCURP.Width = 156;
            // 
            // colTipoPago
            // 
            this.colTipoPago.FieldName = "TipoPago";
            this.colTipoPago.Name = "colTipoPago";
            this.colTipoPago.OptionsColumn.ReadOnly = true;
            this.colTipoPago.Width = 153;
            // 
            // colCLABECFDI
            // 
            this.colCLABECFDI.FieldName = "CLABECFDI";
            this.colCLABECFDI.Name = "colCLABECFDI";
            this.colCLABECFDI.OptionsColumn.ReadOnly = true;
            this.colCLABECFDI.Visible = true;
            this.colCLABECFDI.VisibleIndex = 6;
            this.colCLABECFDI.Width = 156;
            // 
            // colNoCuentaBanco
            // 
            this.colNoCuentaBanco.FieldName = "NoCuentaBanco";
            this.colNoCuentaBanco.Name = "colNoCuentaBanco";
            this.colNoCuentaBanco.OptionsColumn.ReadOnly = true;
            this.colNoCuentaBanco.Visible = true;
            this.colNoCuentaBanco.VisibleIndex = 7;
            this.colNoCuentaBanco.Width = 140;
            // 
            // colDescBanco
            // 
            this.colDescBanco.FieldName = "DescBanco";
            this.colDescBanco.Name = "colDescBanco";
            this.colDescBanco.OptionsColumn.ReadOnly = true;
            this.colDescBanco.Visible = true;
            this.colDescBanco.VisibleIndex = 8;
            this.colDescBanco.Width = 131;
            // 
            // colBancoOrigen
            // 
            this.colBancoOrigen.FieldName = "BancoOrigen";
            this.colBancoOrigen.Name = "colBancoOrigen";
            this.colBancoOrigen.OptionsColumn.ReadOnly = true;
            this.colBancoOrigen.Width = 138;
            // 
            // colEstatusEmpleado
            // 
            this.colEstatusEmpleado.FieldName = "Estatus Empleado";
            this.colEstatusEmpleado.Name = "colEstatusEmpleado";
            this.colEstatusEmpleado.OptionsColumn.ReadOnly = true;
            this.colEstatusEmpleado.Visible = true;
            this.colEstatusEmpleado.VisibleIndex = 10;
            this.colEstatusEmpleado.Width = 172;
            // 
            // gridColFormaDePago
            // 
            this.gridColFormaDePago.Caption = "Forma de Pago";
            this.gridColFormaDePago.ColumnEdit = this.ItemGridLookUpEditFormaPago;
            this.gridColFormaDePago.FieldName = "TipoPago";
            this.gridColFormaDePago.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.gridColFormaDePago.Name = "gridColFormaDePago";
            this.gridColFormaDePago.Visible = true;
            this.gridColFormaDePago.VisibleIndex = 5;
            this.gridColFormaDePago.Width = 178;
            // 
            // ItemGridLookUpEditFormaPago
            // 
            this.ItemGridLookUpEditFormaPago.AcceptEditorTextAsNewValue = DevExpress.Utils.DefaultBoolean.True;
            this.ItemGridLookUpEditFormaPago.AutoHeight = false;
            this.ItemGridLookUpEditFormaPago.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ItemGridLookUpEditFormaPago.DataSource = this.stpSelFormaPagoLoteBindingSource;
            this.ItemGridLookUpEditFormaPago.DisplayMember = "DescFormaPago";
            this.ItemGridLookUpEditFormaPago.Name = "ItemGridLookUpEditFormaPago";
            this.ItemGridLookUpEditFormaPago.NullText = "";
            this.ItemGridLookUpEditFormaPago.UseReadOnlyAppearance = false;
            this.ItemGridLookUpEditFormaPago.ValueMember = "DescFormaPago";
            this.ItemGridLookUpEditFormaPago.View = this.repositoryItemGridLookUpEdit1View;
            this.ItemGridLookUpEditFormaPago.EditValueChanged += new System.EventHandler(this.ItemGridLookUpEditFormaPago_EditValueChanged);
            this.ItemGridLookUpEditFormaPago.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.ItemGridLookUpEditFormaPago_EditValueChanging);
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdFormaPago,
            this.colDescFormaPago});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdFormaPago
            // 
            this.colIdFormaPago.FieldName = "IdFormaPago";
            this.colIdFormaPago.Name = "colIdFormaPago";
            // 
            // colDescFormaPago
            // 
            this.colDescFormaPago.FieldName = "DescFormaPago";
            this.colDescFormaPago.Name = "colDescFormaPago";
            this.colDescFormaPago.Visible = true;
            this.colDescFormaPago.VisibleIndex = 0;
            // 
            // gColumnActualizarTipoPago
            // 
            this.gColumnActualizarTipoPago.Caption = "Actualizar";
            this.gColumnActualizarTipoPago.ColumnEdit = this.btnActualizar;
            this.gColumnActualizarTipoPago.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.gColumnActualizarTipoPago.Name = "gColumnActualizarTipoPago";
            this.gColumnActualizarTipoPago.Visible = true;
            this.gColumnActualizarTipoPago.VisibleIndex = 11;
            // 
            // btnActualizar
            // 
            this.btnActualizar.AutoHeight = false;
            editorButtonImageOptions4.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions4.Image")));
            this.btnActualizar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions4, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject13, serializableAppearanceObject14, serializableAppearanceObject15, serializableAppearanceObject16, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // gColumnActualizarBancoOrigen
            // 
            this.gColumnActualizarBancoOrigen.Caption = "Banco Origen";
            this.gColumnActualizarBancoOrigen.ColumnEdit = this.ItemGridLookUpEditBancoOrigen;
            this.gColumnActualizarBancoOrigen.FieldName = "BancoOrigen";
            this.gColumnActualizarBancoOrigen.Name = "gColumnActualizarBancoOrigen";
            this.gColumnActualizarBancoOrigen.Visible = true;
            this.gColumnActualizarBancoOrigen.VisibleIndex = 9;
            this.gColumnActualizarBancoOrigen.Width = 126;
            // 
            // ItemGridLookUpEditBancoOrigen
            // 
            this.ItemGridLookUpEditBancoOrigen.AutoHeight = false;
            this.ItemGridLookUpEditBancoOrigen.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ItemGridLookUpEditBancoOrigen.DataSource = this.stpSelObtenerInfoBancosLoteBindingSource;
            this.ItemGridLookUpEditBancoOrigen.DisplayMember = "NombreBanco";
            this.ItemGridLookUpEditBancoOrigen.Name = "ItemGridLookUpEditBancoOrigen";
            this.ItemGridLookUpEditBancoOrigen.ValueMember = "NombreBanco";
            this.ItemGridLookUpEditBancoOrigen.View = this.gridView1;
            this.ItemGridLookUpEditBancoOrigen.EditValueChanged += new System.EventHandler(this.ItemGridLookUpEditBancoOrigen_EditValueChanged);
            this.ItemGridLookUpEditBancoOrigen.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.ItemGridLookUpEditBancoOrigen_EditValueChanging);
            // 
            // stpSelObtenerInfoBancosLoteBindingSource
            // 
            this.stpSelObtenerInfoBancosLoteBindingSource.DataMember = "stpSelObtenerInfoBancosLote";
            this.stpSelObtenerInfoBancosLoteBindingSource.DataSource = this.dbSAICBPOCatalogosDataSet1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdBanco,
            this.colNombreBanco});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIdBanco
            // 
            this.colIdBanco.FieldName = "IdBanco";
            this.colIdBanco.Name = "colIdBanco";
            // 
            // colNombreBanco
            // 
            this.colNombreBanco.FieldName = "NombreBanco";
            this.colNombreBanco.Name = "colNombreBanco";
            this.colNombreBanco.Visible = true;
            this.colNombreBanco.VisibleIndex = 0;
            // 
            // stpSelFormaPagoLoteBindingSource1
            // 
            this.stpSelFormaPagoLoteBindingSource1.DataMember = "stpSelFormaPagoLote";
            this.stpSelFormaPagoLoteBindingSource1.DataSource = this.dbSAICBPOCatalogosDataSet1;
            // 
            // stpSelObtenerInfoEmpleadosDatosBancariosTableAdapter1
            // 
            this.stpSelObtenerInfoEmpleadosDatosBancariosTableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelObtenerInfoBancosLoteTableAdapter1
            // 
            this.stpSelObtenerInfoBancosLoteTableAdapter1.ClearBeforeFill = true;
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // stpSelObtenerBancoDeClabeTableAdapter
            // 
            this.stpSelObtenerBancoDeClabeTableAdapter.ClearBeforeFill = true;
            // 
            // frmxActualizarFormaPagoLote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 379);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.lblNumEmpleados);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.stpSelNominaCFDIBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(980, 418);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(980, 418);
            this.Name = "frmxActualizarFormaPagoLote";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar Forma de Pago Empleados";
            this.Load += new System.EventHandler(this.frmxActualizarFormaPagoLote_Load);
            this.SizeChanged += new System.EventHandler(this.frmxActualizarFormaPagoLote_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.stpSelNominaCFDIBindingNavigator)).EndInit();
            this.stpSelNominaCFDIBindingNavigator.ResumeLayout(false);
            this.stpSelNominaCFDIBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFolio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenedora.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOperador.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelObtenerInfoEmpleadosLoteCargaNominaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelFormaPagoLoteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNumEmpleados)).EndInit();
            this.lblNumEmpleados.ResumeLayout(false);
            this.lblNumEmpleados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemGridLookUpEditFormaPago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnActualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemGridLookUpEditBancoOrigen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelObtenerInfoBancosLoteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelFormaPagoLoteBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator stpSelNominaCFDIBindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtLote;
        private DevExpress.XtraEditors.TextEdit txtFolio;
        private DevExpress.XtraEditors.TextEdit txtTenedora;
        private DevExpress.XtraEditors.TextEdit txtObra;
        private DevExpress.XtraEditors.TextEdit txtOperador;
        private System.Windows.Forms.Panel panel1;
        private dbSAICBPOCatalogosDataSet dbSAICBPOCatalogosDataSet1;
        private System.Windows.Forms.BindingSource stpSelObtenerInfoEmpleadosLoteCargaNominaBindingSource;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelObtenerInfoEmpleadosLoteCargaNominaTableAdapter stpSelObtenerInfoEmpleadosLoteCargaNominaTableAdapter1;
        private DevExpress.XtraEditors.GroupControl lblNumEmpleados;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelFormaPagoLoteTableAdapter stpSelFormaPagoLoteTableAdapter1;
        private System.Windows.Forms.BindingSource stpSelFormaPagoLoteBindingSource;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPDOHeader;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpleadoInterno;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn colNSS;
        private DevExpress.XtraGrid.Columns.GridColumn colRFC;
        private DevExpress.XtraGrid.Columns.GridColumn colCURP;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoPago;
        private DevExpress.XtraGrid.Columns.GridColumn colCLABECFDI;
        private DevExpress.XtraGrid.Columns.GridColumn colNoCuentaBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colDescBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colBancoOrigen;
        private DevExpress.XtraGrid.Columns.GridColumn colEstatusEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn gridColFormaDePago;
        private System.Windows.Forms.BindingSource stpSelFormaPagoLoteBindingSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        public DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit ItemGridLookUpEditFormaPago;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelObtenerInfoEmpleadosDatosBancariosTableAdapter stpSelObtenerInfoEmpleadosDatosBancariosTableAdapter1;
        private DevExpress.XtraGrid.Columns.GridColumn gColumnActualizarTipoPago;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnActualizar;
        private dbSAICBPOCatalogosDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFormaPago;
        private DevExpress.XtraGrid.Columns.GridColumn colDescFormaPago;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit ItemGridLookUpEditBancoOrigen;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelObtenerInfoBancosLoteTableAdapter stpSelObtenerInfoBancosLoteTableAdapter1;
        private DevExpress.XtraGrid.Columns.GridColumn gColumnActualizarBancoOrigen;
        private System.Windows.Forms.BindingSource stpSelObtenerInfoBancosLoteBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreBanco;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraEditors.LabelControl lnlLote;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelObtenerBancoDeClabeTableAdapter stpSelObtenerBancoDeClabeTableAdapter;
        private System.Windows.Forms.ToolStripButton btnExportarExcel;
        private System.Windows.Forms.ToolStripButton btnAbrirCarpeta;
    }
}