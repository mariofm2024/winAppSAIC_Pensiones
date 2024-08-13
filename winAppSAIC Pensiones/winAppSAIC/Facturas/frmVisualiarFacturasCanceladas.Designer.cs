namespace winAppSAIC.Facturas
{
    partial class frmVisualiarFacturasCanceladas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisualiarFacturasCanceladas));
            this.cboIdTenedoraSA = new DevExpress.XtraEditors.LookUpEdit();
            this.cboIdCliente = new DevExpress.XtraEditors.LookUpEdit();
            this.lblTenedora = new System.Windows.Forms.Label();
            this.gvSolicitudChequesMasivos = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dgvSolicitudes = new DevExpress.XtraGrid.GridControl();
            this.stpFactSelHeaderFacturasCancelarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPOFactura = new winAppSAIC.Facturas.dbSAICBPOFactura();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdHeaderFacturaCFDI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdHeaderFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSolicitudFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdControlOperacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSerie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColFolio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdFacturador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRazonSocialFronting = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdBeneficiario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRazonSocialBeneficiario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoBeneficiario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescTipoBeneficiario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoRelacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIVA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUUID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComentarios = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdOperador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreCompletoOperador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescEstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaSolicitud = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaLimite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaUltConsul = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaCancelacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl7 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl8 = new DevExpress.XtraBars.BarDockControl();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnSalir = new DevExpress.XtraBars.BarButtonItem();
            this.dtFechaIni = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.dtFechaFin = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.txtUUIDs = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.cbEstatus = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.btnActualizar = new DevExpress.XtraBars.BarButtonItem();
            this.barEliminarFiltro = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.btnRechazarSolicitud = new DevExpress.XtraBars.BarButtonItem();
            this.btnEliminarSolicitud = new DevExpress.XtraBars.BarButtonItem();
            this.btnDescargarComprobante = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barEditItem2 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTimeEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.btnContabilizar = new DevExpress.XtraBars.BarButtonItem();
            this.btnDescontabilizar = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItem3 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.btnEstatus = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.stpFactSelHeaderFacturasCancelarTableAdapter = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelHeaderFacturasCancelarTableAdapter();
            this.splashSMCargando = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::winAppSAIC.frmxCargandoInformacion), true, true);
            this.stpFactSelDerechosAccesoOperadorFacturacionTableAdapter1 = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelDerechosAccesoOperadorFacturacionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cboIdTenedoraSA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboIdCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSolicitudChequesMasivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelHeaderFacturasCancelarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            this.SuspendLayout();
            // 
            // cboIdTenedoraSA
            // 
            this.cboIdTenedoraSA.Location = new System.Drawing.Point(-124, -12);
            this.cboIdTenedoraSA.Name = "cboIdTenedoraSA";
            this.cboIdTenedoraSA.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboIdTenedoraSA.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdTenedora", "Id Tenedora", 82, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RazonSocial", "Razon Social", 70, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NombreComercial", "Nombre Comercial Tenedora S.A.", 96, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cboIdTenedoraSA.Properties.DisplayMember = "NombreComercial";
            this.cboIdTenedoraSA.Properties.NullText = "";
            this.cboIdTenedoraSA.Properties.ValueMember = "IdTenedora";
            this.cboIdTenedoraSA.Size = new System.Drawing.Size(580, 20);
            this.cboIdTenedoraSA.TabIndex = 83;
            // 
            // cboIdCliente
            // 
            this.cboIdCliente.Location = new System.Drawing.Point(-124, 13);
            this.cboIdCliente.Name = "cboIdCliente";
            this.cboIdCliente.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboIdCliente.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdCliente", "Id Cliente", 69, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NombreComercial", "Nombre Comercial Cliente", 96, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cboIdCliente.Properties.DisplayMember = "NombreComercial";
            this.cboIdCliente.Properties.NullText = "";
            this.cboIdCliente.Properties.ValueMember = "IdCliente";
            this.cboIdCliente.Size = new System.Drawing.Size(580, 20);
            this.cboIdCliente.TabIndex = 85;
            // 
            // lblTenedora
            // 
            this.lblTenedora.AutoSize = true;
            this.lblTenedora.Location = new System.Drawing.Point(-200, -9);
            this.lblTenedora.Name = "lblTenedora";
            this.lblTenedora.Size = new System.Drawing.Size(70, 13);
            this.lblTenedora.TabIndex = 82;
            this.lblTenedora.Text = "Facturadora:";
            // 
            // gvSolicitudChequesMasivos
            // 
            this.gvSolicitudChequesMasivos.Location = new System.Drawing.Point(0, 98);
            this.gvSolicitudChequesMasivos.MainView = this.gridView1;
            this.gvSolicitudChequesMasivos.Name = "gvSolicitudChequesMasivos";
            this.gvSolicitudChequesMasivos.Size = new System.Drawing.Size(713, 216);
            this.gvSolicitudChequesMasivos.TabIndex = 16;
            this.gvSolicitudChequesMasivos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
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
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(957, 31);
            this.barDockControlRight.Manager = null;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 451);
            // 
            // dgvSolicitudes
            // 
            this.dgvSolicitudes.DataSource = this.stpFactSelHeaderFacturasCancelarBindingSource;
            this.dgvSolicitudes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSolicitudes.Location = new System.Drawing.Point(0, 31);
            this.dgvSolicitudes.MainView = this.gridView2;
            this.dgvSolicitudes.Name = "dgvSolicitudes";
            this.dgvSolicitudes.Size = new System.Drawing.Size(957, 451);
            this.dgvSolicitudes.TabIndex = 81;
            this.dgvSolicitudes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.dgvSolicitudes.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // stpFactSelHeaderFacturasCancelarBindingSource
            // 
            this.stpFactSelHeaderFacturasCancelarBindingSource.DataMember = "stpFactSelHeaderFacturasCancelar";
            this.stpFactSelHeaderFacturasCancelarBindingSource.DataSource = this.dbSAICBPOFactura;
            // 
            // dbSAICBPOFactura
            // 
            this.dbSAICBPOFactura.DataSetName = "dbSAICBPOFactura";
            this.dbSAICBPOFactura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdHeaderFacturaCFDI,
            this.colIdHeaderFactura,
            this.colIdSolicitudFactura,
            this.colIdControlOperacion,
            this.colSerie,
            this.ColFolio,
            this.colIdFacturador,
            this.colRazonSocialFronting,
            this.colIdBeneficiario,
            this.colRazonSocialBeneficiario,
            this.colIdTipoBeneficiario,
            this.colDescTipoBeneficiario,
            this.colProducto,
            this.colIdTipoFactura,
            this.colTipoRelacion,
            this.colSubTotal,
            this.colIVA,
            this.colTotal,
            this.colUUID,
            this.colComentarios,
            this.colIdOperador,
            this.colNombreCompletoOperador,
            this.colDescEstatus,
            this.colIdEstatus,
            this.colFechaSolicitud,
            this.colFechaLimite,
            this.colFechaUltConsul,
            this.colFechaCancelacion});
            this.gridView2.GridControl = this.dgvSolicitudes;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView2.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsBehavior.ReadOnly = true;
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            this.gridView2.OptionsView.EnableAppearanceOddRow = true;
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colSerie, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colIdHeaderFacturaCFDI
            // 
            this.colIdHeaderFacturaCFDI.Caption = "ID";
            this.colIdHeaderFacturaCFDI.FieldName = "IdHeaderFacturaCFDI";
            this.colIdHeaderFacturaCFDI.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colIdHeaderFacturaCFDI.Name = "colIdHeaderFacturaCFDI";
            this.colIdHeaderFacturaCFDI.Visible = true;
            this.colIdHeaderFacturaCFDI.VisibleIndex = 0;
            // 
            // colIdHeaderFactura
            // 
            this.colIdHeaderFactura.Caption = "Id Factura";
            this.colIdHeaderFactura.FieldName = "IdHeaderFactura";
            this.colIdHeaderFactura.Name = "colIdHeaderFactura";
            this.colIdHeaderFactura.Visible = true;
            this.colIdHeaderFactura.VisibleIndex = 1;
            // 
            // colIdSolicitudFactura
            // 
            this.colIdSolicitudFactura.Caption = "Id Solicitud";
            this.colIdSolicitudFactura.FieldName = "IdSolicitudFactura";
            this.colIdSolicitudFactura.Name = "colIdSolicitudFactura";
            this.colIdSolicitudFactura.Visible = true;
            this.colIdSolicitudFactura.VisibleIndex = 2;
            this.colIdSolicitudFactura.Width = 109;
            // 
            // colIdControlOperacion
            // 
            this.colIdControlOperacion.Caption = "Id Control Operaciones";
            this.colIdControlOperacion.FieldName = "IdControlOperacion";
            this.colIdControlOperacion.Name = "colIdControlOperacion";
            this.colIdControlOperacion.Visible = true;
            this.colIdControlOperacion.VisibleIndex = 3;
            this.colIdControlOperacion.Width = 104;
            // 
            // colSerie
            // 
            this.colSerie.Caption = "Serie";
            this.colSerie.FieldName = "Serie";
            this.colSerie.Name = "colSerie";
            this.colSerie.Visible = true;
            this.colSerie.VisibleIndex = 6;
            // 
            // ColFolio
            // 
            this.ColFolio.Caption = "Folio Interno";
            this.ColFolio.FieldName = "FolioInterno";
            this.ColFolio.Name = "ColFolio";
            this.ColFolio.Visible = true;
            this.ColFolio.VisibleIndex = 7;
            // 
            // colIdFacturador
            // 
            this.colIdFacturador.FieldName = "IdFacturador";
            this.colIdFacturador.Name = "colIdFacturador";
            // 
            // colRazonSocialFronting
            // 
            this.colRazonSocialFronting.Caption = "Fronting";
            this.colRazonSocialFronting.FieldName = "NombreComercialFronting";
            this.colRazonSocialFronting.Name = "colRazonSocialFronting";
            this.colRazonSocialFronting.Visible = true;
            this.colRazonSocialFronting.VisibleIndex = 8;
            this.colRazonSocialFronting.Width = 292;
            // 
            // colIdBeneficiario
            // 
            this.colIdBeneficiario.FieldName = "IdBeneficiario";
            this.colIdBeneficiario.Name = "colIdBeneficiario";
            // 
            // colRazonSocialBeneficiario
            // 
            this.colRazonSocialBeneficiario.Caption = "Beneficiario";
            this.colRazonSocialBeneficiario.FieldName = "NombreComercialBeneficiario";
            this.colRazonSocialBeneficiario.Name = "colRazonSocialBeneficiario";
            this.colRazonSocialBeneficiario.Visible = true;
            this.colRazonSocialBeneficiario.VisibleIndex = 10;
            this.colRazonSocialBeneficiario.Width = 281;
            // 
            // colIdTipoBeneficiario
            // 
            this.colIdTipoBeneficiario.FieldName = "IdTipoBeneficiario";
            this.colIdTipoBeneficiario.Name = "colIdTipoBeneficiario";
            // 
            // colDescTipoBeneficiario
            // 
            this.colDescTipoBeneficiario.Caption = "Tipo Beneficiario";
            this.colDescTipoBeneficiario.FieldName = "DescTipoBeneficiario";
            this.colDescTipoBeneficiario.Name = "colDescTipoBeneficiario";
            this.colDescTipoBeneficiario.Visible = true;
            this.colDescTipoBeneficiario.VisibleIndex = 9;
            this.colDescTipoBeneficiario.Width = 94;
            // 
            // colProducto
            // 
            this.colProducto.Caption = "Producto";
            this.colProducto.FieldName = "DescProducto";
            this.colProducto.Name = "colProducto";
            this.colProducto.Visible = true;
            this.colProducto.VisibleIndex = 22;
            // 
            // colIdTipoFactura
            // 
            this.colIdTipoFactura.Caption = "Tipo Factura";
            this.colIdTipoFactura.FieldName = "TipoComprobante";
            this.colIdTipoFactura.Name = "colIdTipoFactura";
            this.colIdTipoFactura.Visible = true;
            this.colIdTipoFactura.VisibleIndex = 4;
            // 
            // colTipoRelacion
            // 
            this.colTipoRelacion.Caption = "Tipo Relación";
            this.colTipoRelacion.Name = "colTipoRelacion";
            this.colTipoRelacion.Visible = true;
            this.colTipoRelacion.VisibleIndex = 5;
            // 
            // colSubTotal
            // 
            this.colSubTotal.Caption = "Sub-total";
            this.colSubTotal.DisplayFormat.FormatString = "C2";
            this.colSubTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSubTotal.FieldName = "SubTotal";
            this.colSubTotal.Name = "colSubTotal";
            this.colSubTotal.Visible = true;
            this.colSubTotal.VisibleIndex = 11;
            // 
            // colIVA
            // 
            this.colIVA.DisplayFormat.FormatString = "C2";
            this.colIVA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colIVA.FieldName = "IVA";
            this.colIVA.Name = "colIVA";
            this.colIVA.Visible = true;
            this.colIVA.VisibleIndex = 12;
            // 
            // colTotal
            // 
            this.colTotal.DisplayFormat.FormatString = "C2";
            this.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotal.FieldName = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 13;
            // 
            // colUUID
            // 
            this.colUUID.FieldName = "UUID";
            this.colUUID.Name = "colUUID";
            this.colUUID.Visible = true;
            this.colUUID.VisibleIndex = 14;
            this.colUUID.Width = 260;
            // 
            // colComentarios
            // 
            this.colComentarios.FieldName = "Comentarios";
            this.colComentarios.Name = "colComentarios";
            this.colComentarios.Visible = true;
            this.colComentarios.VisibleIndex = 21;
            this.colComentarios.Width = 201;
            // 
            // colIdOperador
            // 
            this.colIdOperador.Caption = "IdOperador";
            this.colIdOperador.FieldName = "IdOperador";
            this.colIdOperador.Name = "colIdOperador";
            // 
            // colNombreCompletoOperador
            // 
            this.colNombreCompletoOperador.Caption = "Operador";
            this.colNombreCompletoOperador.FieldName = "NombreCompletoOperador";
            this.colNombreCompletoOperador.Name = "colNombreCompletoOperador";
            this.colNombreCompletoOperador.Visible = true;
            this.colNombreCompletoOperador.VisibleIndex = 15;
            this.colNombreCompletoOperador.Width = 254;
            // 
            // colDescEstatus
            // 
            this.colDescEstatus.Caption = "Estatus";
            this.colDescEstatus.FieldName = "DescEstatus";
            this.colDescEstatus.Name = "colDescEstatus";
            this.colDescEstatus.Visible = true;
            this.colDescEstatus.VisibleIndex = 16;
            // 
            // colIdEstatus
            // 
            this.colIdEstatus.FieldName = "IdEstatus";
            this.colIdEstatus.Name = "colIdEstatus";
            // 
            // colFechaSolicitud
            // 
            this.colFechaSolicitud.Caption = "Fecha Solicitud";
            this.colFechaSolicitud.FieldName = "FechaSolicitud";
            this.colFechaSolicitud.Name = "colFechaSolicitud";
            this.colFechaSolicitud.Visible = true;
            this.colFechaSolicitud.VisibleIndex = 18;
            // 
            // colFechaLimite
            // 
            this.colFechaLimite.Caption = "Fecha Limite Aceptación";
            this.colFechaLimite.FieldName = "FechaLimite";
            this.colFechaLimite.Name = "colFechaLimite";
            this.colFechaLimite.Visible = true;
            this.colFechaLimite.VisibleIndex = 19;
            // 
            // colFechaUltConsul
            // 
            this.colFechaUltConsul.Caption = "Fecha Ultima Consulta SAT";
            this.colFechaUltConsul.FieldName = "FechaUltConsul";
            this.colFechaUltConsul.Name = "colFechaUltConsul";
            this.colFechaUltConsul.Visible = true;
            this.colFechaUltConsul.VisibleIndex = 20;
            // 
            // colFechaCancelacion
            // 
            this.colFechaCancelacion.Caption = "Fecha Cancelación";
            this.colFechaCancelacion.FieldName = "FechaCancelacion";
            this.colFechaCancelacion.Name = "colFechaCancelacion";
            this.colFechaCancelacion.Visible = true;
            this.colFechaCancelacion.VisibleIndex = 17;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 31);
            this.barDockControlTop.Manager = null;
            this.barDockControlTop.Size = new System.Drawing.Size(957, 0);
            // 
            // barDockControl7
            // 
            this.barDockControl7.CausesValidation = false;
            this.barDockControl7.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl7.Location = new System.Drawing.Point(0, 31);
            this.barDockControl7.Manager = null;
            this.barDockControl7.Size = new System.Drawing.Size(957, 0);
            // 
            // barDockControl8
            // 
            this.barDockControl8.CausesValidation = false;
            this.barDockControl8.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl8.Location = new System.Drawing.Point(0, 31);
            this.barDockControl8.Manager = null;
            this.barDockControl8.Size = new System.Drawing.Size(957, 0);
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControl1);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControl2);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnSalir,
            this.btnRechazarSolicitud,
            this.btnEliminarSolicitud,
            this.btnActualizar,
            this.barEliminarFiltro,
            this.btnDescargarComprobante,
            this.barEditItem1,
            this.barEditItem2,
            this.dtFechaIni,
            this.dtFechaFin,
            this.btnContabilizar,
            this.btnDescontabilizar,
            this.txtUUIDs,
            this.barEditItem3,
            this.btnEstatus,
            this.cbEstatus});
            this.barManager1.MaxItemId = 20;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemTimeEdit1,
            this.repositoryItemDateEdit1,
            this.repositoryItemTextEdit2,
            this.repositoryItemDateEdit2,
            this.repositoryItemTextEdit3,
            this.repositoryItemTextEdit4,
            this.repositoryItemComboBox1,
            this.repositoryItemComboBox2});
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSalir),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, this.dtFechaIni, "", false, true, true, 82),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, this.dtFechaFin, "", false, true, true, 82),
            new DevExpress.XtraBars.LinkPersistInfo(((DevExpress.XtraBars.BarLinkUserDefines)((DevExpress.XtraBars.BarLinkUserDefines.PaintStyle | DevExpress.XtraBars.BarLinkUserDefines.Width))), this.txtUUIDs, "", false, true, true, 152, null, DevExpress.XtraBars.BarItemPaintStyle.Caption),
            new DevExpress.XtraBars.LinkPersistInfo(((DevExpress.XtraBars.BarLinkUserDefines)((DevExpress.XtraBars.BarLinkUserDefines.PaintStyle | DevExpress.XtraBars.BarLinkUserDefines.Width))), this.cbEstatus, "", false, true, true, 96, null, DevExpress.XtraBars.BarItemPaintStyle.Caption),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnActualizar),
            new DevExpress.XtraBars.LinkPersistInfo(this.barEliminarFiltro)});
            this.bar1.Text = "Tools";
            // 
            // btnSalir
            // 
            this.btnSalir.Caption = "Salir";
            this.btnSalir.Id = 0;
            this.btnSalir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.ImageOptions.Image")));
            this.btnSalir.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.ImageOptions.LargeImage")));
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnSalir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSalir_ItemClick);
            // 
            // dtFechaIni
            // 
            this.dtFechaIni.Caption = "Fecha Inicio:";
            this.dtFechaIni.Edit = this.repositoryItemDateEdit1;
            this.dtFechaIni.EditValue = new System.DateTime(2018, 6, 14, 8, 17, 54, 863);
            this.dtFechaIni.Id = 8;
            this.dtFechaIni.Name = "dtFechaIni";
            this.dtFechaIni.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // dtFechaFin
            // 
            this.dtFechaFin.Caption = "Fecha Fin:";
            this.dtFechaFin.Edit = this.repositoryItemDateEdit2;
            this.dtFechaFin.EditValue = new System.DateTime(2018, 6, 14, 8, 19, 51, 355);
            this.dtFechaFin.Id = 10;
            this.dtFechaFin.Name = "dtFechaFin";
            this.dtFechaFin.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // repositoryItemDateEdit2
            // 
            this.repositoryItemDateEdit2.AutoHeight = false;
            this.repositoryItemDateEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.Name = "repositoryItemDateEdit2";
            // 
            // txtUUIDs
            // 
            this.txtUUIDs.Caption = "UUID";
            this.txtUUIDs.Edit = this.repositoryItemTextEdit3;
            this.txtUUIDs.EditValue = "";
            this.txtUUIDs.Id = 13;
            this.txtUUIDs.Name = "txtUUIDs";
            this.txtUUIDs.Tag = "UUID";
            // 
            // repositoryItemTextEdit3
            // 
            this.repositoryItemTextEdit3.AutoHeight = false;
            this.repositoryItemTextEdit3.Name = "repositoryItemTextEdit3";
            // 
            // cbEstatus
            // 
            this.cbEstatus.Caption = "Estatus";
            this.cbEstatus.Edit = this.repositoryItemComboBox2;
            this.cbEstatus.EditValue = "Proceso";
            this.cbEstatus.Id = 16;
            this.cbEstatus.Name = "cbEstatus";
            // 
            // repositoryItemComboBox2
            // 
            this.repositoryItemComboBox2.AutoHeight = false;
            this.repositoryItemComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox2.Items.AddRange(new object[] {
            "Proceso",
            "Cancelados"});
            this.repositoryItemComboBox2.Name = "repositoryItemComboBox2";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Caption = "Filtrar";
            this.btnActualizar.Id = 3;
            this.btnActualizar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.ImageOptions.Image")));
            this.btnActualizar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnActualizar.ImageOptions.LargeImage")));
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnActualizar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnActualizar_ItemClick);
            // 
            // barEliminarFiltro
            // 
            this.barEliminarFiltro.Caption = "Eliminar Filtro";
            this.barEliminarFiltro.Id = 4;
            this.barEliminarFiltro.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barEliminarFiltro.ImageOptions.Image")));
            this.barEliminarFiltro.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barEliminarFiltro.ImageOptions.LargeImage")));
            this.barEliminarFiltro.Name = "barEliminarFiltro";
            this.barEliminarFiltro.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barEliminarFiltro.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.barManager1;
            this.barDockControl1.Size = new System.Drawing.Size(957, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 482);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(957, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 451);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl2.Location = new System.Drawing.Point(957, 31);
            this.barDockControl2.Manager = this.barManager1;
            this.barDockControl2.Size = new System.Drawing.Size(0, 451);
            // 
            // btnRechazarSolicitud
            // 
            this.btnRechazarSolicitud.Caption = "Rechazar Solicitud";
            this.btnRechazarSolicitud.Id = 1;
            this.btnRechazarSolicitud.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRechazarSolicitud.ImageOptions.Image")));
            this.btnRechazarSolicitud.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRechazarSolicitud.ImageOptions.LargeImage")));
            this.btnRechazarSolicitud.Name = "btnRechazarSolicitud";
            this.btnRechazarSolicitud.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnRechazarSolicitud.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRechazarSolicitud_ItemClick);
            // 
            // btnEliminarSolicitud
            // 
            this.btnEliminarSolicitud.Caption = "Cancelar Solicitud";
            this.btnEliminarSolicitud.Id = 2;
            this.btnEliminarSolicitud.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarSolicitud.ImageOptions.Image")));
            this.btnEliminarSolicitud.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEliminarSolicitud.ImageOptions.LargeImage")));
            this.btnEliminarSolicitud.Name = "btnEliminarSolicitud";
            this.btnEliminarSolicitud.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnEliminarSolicitud.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEliminarSolicitud_ItemClick);
            // 
            // btnDescargarComprobante
            // 
            this.btnDescargarComprobante.Id = 17;
            this.btnDescargarComprobante.Name = "btnDescargarComprobante";
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "barEditItem1";
            this.barEditItem1.Edit = this.repositoryItemTextEdit1;
            this.barEditItem1.Id = 6;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // barEditItem2
            // 
            this.barEditItem2.Caption = "barEditItem2";
            this.barEditItem2.Edit = this.repositoryItemTimeEdit1;
            this.barEditItem2.Id = 7;
            this.barEditItem2.Name = "barEditItem2";
            // 
            // repositoryItemTimeEdit1
            // 
            this.repositoryItemTimeEdit1.AutoHeight = false;
            this.repositoryItemTimeEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemTimeEdit1.Name = "repositoryItemTimeEdit1";
            this.repositoryItemTimeEdit1.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI;
            // 
            // btnContabilizar
            // 
            this.btnContabilizar.Id = 18;
            this.btnContabilizar.Name = "btnContabilizar";
            // 
            // btnDescontabilizar
            // 
            this.btnDescontabilizar.Id = 19;
            this.btnDescontabilizar.Name = "btnDescontabilizar";
            // 
            // barEditItem3
            // 
            this.barEditItem3.Caption = "barEditItem3";
            this.barEditItem3.Edit = this.repositoryItemTextEdit4;
            this.barEditItem3.Id = 14;
            this.barEditItem3.Name = "barEditItem3";
            // 
            // repositoryItemTextEdit4
            // 
            this.repositoryItemTextEdit4.AutoHeight = false;
            this.repositoryItemTextEdit4.Name = "repositoryItemTextEdit4";
            // 
            // btnEstatus
            // 
            this.btnEstatus.Caption = "Estatus";
            this.btnEstatus.Edit = this.repositoryItemComboBox1;
            this.btnEstatus.Id = 15;
            this.btnEstatus.Name = "btnEstatus";
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // stpFactSelHeaderFacturasCancelarTableAdapter
            // 
            this.stpFactSelHeaderFacturasCancelarTableAdapter.ClearBeforeFill = true;
            // 
            // splashSMCargando
            // 
            this.splashSMCargando.ClosingDelay = 500;
            // 
            // stpFactSelDerechosAccesoOperadorFacturacionTableAdapter1
            // 
            this.stpFactSelDerechosAccesoOperadorFacturacionTableAdapter1.ClearBeforeFill = true;
            // 
            // frmVisualiarFacturasCanceladas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 482);
            this.ControlBox = false;
            this.Controls.Add(this.dgvSolicitudes);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControl7);
            this.Controls.Add(this.barDockControl8);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControl1);
            this.Name = "frmVisualiarFacturasCanceladas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizar Facturas Canceladas y en Proceso de Cancelado";
            this.Load += new System.EventHandler(this.frmVisualiarFacturasCanceladas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cboIdTenedoraSA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboIdCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSolicitudChequesMasivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelHeaderFacturasCancelarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit cboIdTenedoraSA;
        private DevExpress.XtraEditors.LookUpEdit cboIdCliente;
        private System.Windows.Forms.Label lblTenedora;
        private DevExpress.XtraGrid.GridControl gvSolicitudChequesMasivos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl dgvSolicitudes;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControl7;
        private DevExpress.XtraBars.BarDockControl barDockControl8;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnSalir;
        private DevExpress.XtraBars.BarButtonItem btnRechazarSolicitud;
        private DevExpress.XtraBars.BarButtonItem btnEliminarSolicitud;
        private DevExpress.XtraBars.BarButtonItem btnActualizar;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private dbSAICBPOFactura dbSAICBPOFactura;
        private DevExpress.XtraBars.BarButtonItem barEliminarFiltro;
        private DevExpress.XtraBars.BarButtonItem btnDescargarComprobante;
        private DevExpress.XtraBars.BarEditItem dtFechaIni;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraBars.BarEditItem dtFechaFin;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraBars.BarEditItem barEditItem2;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit repositoryItemTimeEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdHeaderFacturaCFDI;
        private DevExpress.XtraGrid.Columns.GridColumn colIdHeaderFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSolicitudFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colIdControlOperacion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFacturador;
        private DevExpress.XtraGrid.Columns.GridColumn colRazonSocialFronting;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBeneficiario;
        private DevExpress.XtraGrid.Columns.GridColumn colRazonSocialBeneficiario;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoBeneficiario;
        private DevExpress.XtraGrid.Columns.GridColumn colDescTipoBeneficiario;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colSubTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colIVA;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colUUID;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstatus;
        private DevExpress.XtraGrid.Columns.GridColumn colDescEstatus;
        private DevExpress.XtraGrid.Columns.GridColumn colComentarios;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreCompletoOperador;
        private DevExpress.XtraBars.BarButtonItem btnContabilizar;
        private DevExpress.XtraBars.BarButtonItem btnDescontabilizar;
        private DevExpress.XtraGrid.Columns.GridColumn colSerie;
        private DevExpress.XtraGrid.Columns.GridColumn ColFolio;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit3;
        private DevExpress.XtraBars.BarEditItem cbEstatus;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox2;
        private DevExpress.XtraBars.BarEditItem barEditItem3;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit4;
        private DevExpress.XtraBars.BarEditItem btnEstatus;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdOperador;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaSolicitud;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaLimite;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaUltConsul;
        private DevExpress.XtraGrid.Columns.GridColumn colProducto;
        private System.Windows.Forms.BindingSource stpFactSelHeaderFacturasCancelarBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaCancelacion;
        private dbSAICBPOFacturaTableAdapters.stpFactSelHeaderFacturasCancelarTableAdapter stpFactSelHeaderFacturasCancelarTableAdapter;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashSMCargando;
        public DevExpress.XtraBars.BarEditItem txtUUIDs;
        private dbSAICBPOFacturaTableAdapters.stpFactSelDerechosAccesoOperadorFacturacionTableAdapter stpFactSelDerechosAccesoOperadorFacturacionTableAdapter1;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoRelacion;
    }
}