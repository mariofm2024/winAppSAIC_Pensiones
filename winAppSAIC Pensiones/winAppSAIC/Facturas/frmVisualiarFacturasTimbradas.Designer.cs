namespace winAppSAIC.Facturas
{
    partial class frmVisualiarFacturasTimbradas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisualiarFacturasTimbradas));
            this.cboIdTenedoraSA = new DevExpress.XtraEditors.LookUpEdit();
            this.cboIdCliente = new DevExpress.XtraEditors.LookUpEdit();
            this.lblTenedora = new System.Windows.Forms.Label();
            this.gvSolicitudChequesMasivos = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dgvSolicitudes = new DevExpress.XtraGrid.GridControl();
            this.stpFactSelHeaderFacturasTimbradasBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.colMesContabilidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAnoContabilidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaContabilidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoBeneficiario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescTipoBeneficiario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMetodoPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClaveMetodoPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescMetodoPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdFormaPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescFormaPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMoneda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoCambio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalDepositado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIVA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImporteConLetra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUUID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdHeaderFacturaRelacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoRelacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescTipoRelacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUUIDRelacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescEstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComentarios = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdBancoOrigen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreBancoOrI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdBancoDestino = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreBancoDES = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colArchivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdOperador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreCompletoOperador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaCreacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSistema = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.txtUUID = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.btnActualizar = new DevExpress.XtraBars.BarButtonItem();
            this.barEliminarFiltro = new DevExpress.XtraBars.BarButtonItem();
            this.btnDescargarComprobante = new DevExpress.XtraBars.BarButtonItem();
            this.btnContabilizar = new DevExpress.XtraBars.BarButtonItem();
            this.btnDescontabilizar = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.btnRechazarSolicitud = new DevExpress.XtraBars.BarButtonItem();
            this.btnEliminarSolicitud = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barEditItem2 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTimeEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.vwFactCatEstatusSolicitudGlobalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwFactCatEstatusSolicitudGlobalTableAdapter = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.vwFactCatEstatusSolicitudGlobalTableAdapter();
            this.validacionesGeneralTableAdapter1 = new winAppSAIC.Catalogos.dbSAICBPO_CatalogosValidacionDataSetTableAdapters.ValidacionesGeneralTableAdapter();
            this.stpFactSelDerechosAccesoOperadorFacturacionTableAdapter1 = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelDerechosAccesoOperadorFacturacionTableAdapter();
            this.stpFactSelComprobantesFacturaTableAdapter1 = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelComprobantesFacturaTableAdapter();
            this.spSoloRespuesta1 = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.spSoloRespuesta();
            this.stpFactSelHeaderFacturasTimbradasTableAdapter = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelHeaderFacturasTimbradasTableAdapter();
            this.splashSMCargando = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::winAppSAIC.frmxCargandoInformacion), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.cboIdTenedoraSA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboIdCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSolicitudChequesMasivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelHeaderFacturasTimbradasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwFactCatEstatusSolicitudGlobalBindingSource)).BeginInit();
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
            this.barDockControlRight.Location = new System.Drawing.Point(983, 31);
            this.barDockControlRight.Manager = null;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 493);
            // 
            // dgvSolicitudes
            // 
            this.dgvSolicitudes.DataSource = this.stpFactSelHeaderFacturasTimbradasBindingSource;
            this.dgvSolicitudes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSolicitudes.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.dgvSolicitudes.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.dgvSolicitudes.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.dgvSolicitudes.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.dgvSolicitudes.EmbeddedNavigator.Buttons.Next.Visible = false;
            this.dgvSolicitudes.EmbeddedNavigator.Buttons.Prev.Visible = false;
            this.dgvSolicitudes.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.dgvSolicitudes.Location = new System.Drawing.Point(0, 31);
            this.dgvSolicitudes.MainView = this.gridView2;
            this.dgvSolicitudes.Name = "dgvSolicitudes";
            this.dgvSolicitudes.ShowOnlyPredefinedDetails = true;
            this.dgvSolicitudes.Size = new System.Drawing.Size(983, 493);
            this.dgvSolicitudes.TabIndex = 81;
            this.dgvSolicitudes.UseEmbeddedNavigator = true;
            this.dgvSolicitudes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.dgvSolicitudes.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // stpFactSelHeaderFacturasTimbradasBindingSource
            // 
            this.stpFactSelHeaderFacturasTimbradasBindingSource.DataMember = "stpFactSelHeaderFacturasTimbradas";
            this.stpFactSelHeaderFacturasTimbradasBindingSource.DataSource = this.dbSAICBPOFactura;
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
            this.colMesContabilidad,
            this.colAnoContabilidad,
            this.colFechaContabilidad,
            this.colIdTipoBeneficiario,
            this.colDescTipoBeneficiario,
            this.colIdMetodoPago,
            this.colClaveMetodoPago,
            this.colDescMetodoPago,
            this.colIdFormaPago,
            this.colDescFormaPago,
            this.colIdMoneda,
            this.colIdTipoFactura,
            this.colTipoCambio,
            this.colFechaPago,
            this.colTotalDepositado,
            this.colSubTotal,
            this.colIVA,
            this.colTotal,
            this.colImporteConLetra,
            this.colUUID,
            this.colIdHeaderFacturaRelacion,
            this.colIdTipoRelacion,
            this.colDescTipoRelacion,
            this.colUUIDRelacion,
            this.colIdEstatus,
            this.colDescEstatus,
            this.colComentarios,
            this.colIdBancoOrigen,
            this.colNombreBancoOrI,
            this.colIdBancoDestino,
            this.colNombreBancoDES,
            this.colArchivo,
            this.colIdOperador,
            this.colNombreCompletoOperador,
            this.colFechaCreacion,
            this.colSistema});
            this.gridView2.GridControl = this.dgvSolicitudes;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView2.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsBehavior.ReadOnly = true;
            this.gridView2.OptionsSelection.MultiSelect = true;
            this.gridView2.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            this.gridView2.OptionsView.EnableAppearanceOddRow = true;
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colFechaCreacion, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colIdHeaderFacturaCFDI
            // 
            this.colIdHeaderFacturaCFDI.Caption = "ID CFDI";
            this.colIdHeaderFacturaCFDI.FieldName = "IdHeaderFacturaCFDI";
            this.colIdHeaderFacturaCFDI.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colIdHeaderFacturaCFDI.Name = "colIdHeaderFacturaCFDI";
            this.colIdHeaderFacturaCFDI.Visible = true;
            this.colIdHeaderFacturaCFDI.VisibleIndex = 1;
            // 
            // colIdHeaderFactura
            // 
            this.colIdHeaderFactura.Caption = "Id Factura";
            this.colIdHeaderFactura.FieldName = "IdHeaderFactura";
            this.colIdHeaderFactura.Name = "colIdHeaderFactura";
            this.colIdHeaderFactura.Visible = true;
            this.colIdHeaderFactura.VisibleIndex = 2;
            // 
            // colIdSolicitudFactura
            // 
            this.colIdSolicitudFactura.Caption = "Id Solicitud";
            this.colIdSolicitudFactura.FieldName = "IdSolicitudFactura";
            this.colIdSolicitudFactura.Name = "colIdSolicitudFactura";
            this.colIdSolicitudFactura.Visible = true;
            this.colIdSolicitudFactura.VisibleIndex = 3;
            this.colIdSolicitudFactura.Width = 109;
            // 
            // colIdControlOperacion
            // 
            this.colIdControlOperacion.Caption = "Id Control Operaciones";
            this.colIdControlOperacion.FieldName = "IdControlOperacion";
            this.colIdControlOperacion.Name = "colIdControlOperacion";
            this.colIdControlOperacion.Visible = true;
            this.colIdControlOperacion.VisibleIndex = 4;
            this.colIdControlOperacion.Width = 79;
            // 
            // colSerie
            // 
            this.colSerie.Caption = "Serie";
            this.colSerie.FieldName = "Serie";
            this.colSerie.Name = "colSerie";
            this.colSerie.Visible = true;
            this.colSerie.VisibleIndex = 5;
            // 
            // ColFolio
            // 
            this.ColFolio.Caption = "Folio Interno";
            this.ColFolio.FieldName = "FolioInterno";
            this.ColFolio.Name = "ColFolio";
            this.ColFolio.Visible = true;
            this.ColFolio.VisibleIndex = 6;
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
            this.colRazonSocialFronting.VisibleIndex = 7;
            this.colRazonSocialFronting.Width = 390;
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
            this.colRazonSocialBeneficiario.VisibleIndex = 8;
            this.colRazonSocialBeneficiario.Width = 391;
            // 
            // colMesContabilidad
            // 
            this.colMesContabilidad.Caption = "Mes Contabilidad";
            this.colMesContabilidad.FieldName = "MesContabilidad";
            this.colMesContabilidad.Name = "colMesContabilidad";
            this.colMesContabilidad.Visible = true;
            this.colMesContabilidad.VisibleIndex = 12;
            // 
            // colAnoContabilidad
            // 
            this.colAnoContabilidad.Caption = "Año Contabilidad";
            this.colAnoContabilidad.FieldName = "AnoContabilidad";
            this.colAnoContabilidad.Name = "colAnoContabilidad";
            this.colAnoContabilidad.Visible = true;
            this.colAnoContabilidad.VisibleIndex = 11;
            // 
            // colFechaContabilidad
            // 
            this.colFechaContabilidad.Caption = "Fecha Contabilidad";
            this.colFechaContabilidad.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.colFechaContabilidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colFechaContabilidad.FieldName = "FechaContabilidad";
            this.colFechaContabilidad.Name = "colFechaContabilidad";
            this.colFechaContabilidad.Visible = true;
            this.colFechaContabilidad.VisibleIndex = 13;
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
            // colIdMetodoPago
            // 
            this.colIdMetodoPago.FieldName = "IdMetodoPago";
            this.colIdMetodoPago.Name = "colIdMetodoPago";
            // 
            // colClaveMetodoPago
            // 
            this.colClaveMetodoPago.Caption = "Método de Pago";
            this.colClaveMetodoPago.FieldName = "ClaveMetodoPago";
            this.colClaveMetodoPago.Name = "colClaveMetodoPago";
            this.colClaveMetodoPago.Visible = true;
            this.colClaveMetodoPago.VisibleIndex = 14;
            this.colClaveMetodoPago.Width = 105;
            // 
            // colDescMetodoPago
            // 
            this.colDescMetodoPago.FieldName = "DescMetodoPago";
            this.colDescMetodoPago.Name = "colDescMetodoPago";
            // 
            // colIdFormaPago
            // 
            this.colIdFormaPago.FieldName = "IdFormaPago";
            this.colIdFormaPago.Name = "colIdFormaPago";
            // 
            // colDescFormaPago
            // 
            this.colDescFormaPago.Caption = "Forma de Pago";
            this.colDescFormaPago.FieldName = "DescFormaPago";
            this.colDescFormaPago.Name = "colDescFormaPago";
            this.colDescFormaPago.Visible = true;
            this.colDescFormaPago.VisibleIndex = 15;
            this.colDescFormaPago.Width = 91;
            // 
            // colIdMoneda
            // 
            this.colIdMoneda.Caption = "Moneda";
            this.colIdMoneda.FieldName = "IdMoneda";
            this.colIdMoneda.Name = "colIdMoneda";
            this.colIdMoneda.Visible = true;
            this.colIdMoneda.VisibleIndex = 16;
            // 
            // colIdTipoFactura
            // 
            this.colIdTipoFactura.Caption = "Tipo Factura";
            this.colIdTipoFactura.FieldName = "IdTipoFactura";
            this.colIdTipoFactura.Name = "colIdTipoFactura";
            this.colIdTipoFactura.Visible = true;
            this.colIdTipoFactura.VisibleIndex = 10;
            // 
            // colTipoCambio
            // 
            this.colTipoCambio.Caption = "Tipo de Cambio";
            this.colTipoCambio.DisplayFormat.FormatString = "C2";
            this.colTipoCambio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTipoCambio.FieldName = "TipoCambio";
            this.colTipoCambio.Name = "colTipoCambio";
            this.colTipoCambio.Visible = true;
            this.colTipoCambio.VisibleIndex = 17;
            this.colTipoCambio.Width = 108;
            // 
            // colFechaPago
            // 
            this.colFechaPago.Caption = "Fecha de Pago";
            this.colFechaPago.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.colFechaPago.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colFechaPago.FieldName = "FechaPago";
            this.colFechaPago.Name = "colFechaPago";
            this.colFechaPago.Visible = true;
            this.colFechaPago.VisibleIndex = 18;
            this.colFechaPago.Width = 113;
            // 
            // colTotalDepositado
            // 
            this.colTotalDepositado.Caption = "Total Depositado";
            this.colTotalDepositado.DisplayFormat.FormatString = "C2";
            this.colTotalDepositado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalDepositado.FieldName = "TotalDepositado";
            this.colTotalDepositado.Name = "colTotalDepositado";
            this.colTotalDepositado.Visible = true;
            this.colTotalDepositado.VisibleIndex = 19;
            this.colTotalDepositado.Width = 101;
            // 
            // colSubTotal
            // 
            this.colSubTotal.Caption = "Sub-total";
            this.colSubTotal.DisplayFormat.FormatString = "C2";
            this.colSubTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSubTotal.FieldName = "SubTotal";
            this.colSubTotal.Name = "colSubTotal";
            this.colSubTotal.Visible = true;
            this.colSubTotal.VisibleIndex = 22;
            // 
            // colIVA
            // 
            this.colIVA.DisplayFormat.FormatString = "C2";
            this.colIVA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colIVA.FieldName = "IVA";
            this.colIVA.Name = "colIVA";
            this.colIVA.Visible = true;
            this.colIVA.VisibleIndex = 23;
            // 
            // colTotal
            // 
            this.colTotal.DisplayFormat.FormatString = "C2";
            this.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotal.FieldName = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 24;
            // 
            // colImporteConLetra
            // 
            this.colImporteConLetra.FieldName = "ImporteConLetra";
            this.colImporteConLetra.Name = "colImporteConLetra";
            // 
            // colUUID
            // 
            this.colUUID.FieldName = "UUID";
            this.colUUID.Name = "colUUID";
            this.colUUID.Visible = true;
            this.colUUID.VisibleIndex = 25;
            // 
            // colIdHeaderFacturaRelacion
            // 
            this.colIdHeaderFacturaRelacion.Caption = "Id Factura Relacionada";
            this.colIdHeaderFacturaRelacion.FieldName = "IdHeaderFacturaRelacion";
            this.colIdHeaderFacturaRelacion.Name = "colIdHeaderFacturaRelacion";
            this.colIdHeaderFacturaRelacion.Visible = true;
            this.colIdHeaderFacturaRelacion.VisibleIndex = 26;
            this.colIdHeaderFacturaRelacion.Width = 131;
            // 
            // colIdTipoRelacion
            // 
            this.colIdTipoRelacion.FieldName = "IdTipoRelacion";
            this.colIdTipoRelacion.Name = "colIdTipoRelacion";
            // 
            // colDescTipoRelacion
            // 
            this.colDescTipoRelacion.Caption = "Tipo Relación";
            this.colDescTipoRelacion.FieldName = "DescTipoRelacion";
            this.colDescTipoRelacion.Name = "colDescTipoRelacion";
            this.colDescTipoRelacion.Visible = true;
            this.colDescTipoRelacion.VisibleIndex = 27;
            // 
            // colUUIDRelacion
            // 
            this.colUUIDRelacion.Caption = "UUID Relación";
            this.colUUIDRelacion.FieldName = "UUIDRelacion";
            this.colUUIDRelacion.Name = "colUUIDRelacion";
            this.colUUIDRelacion.Visible = true;
            this.colUUIDRelacion.VisibleIndex = 28;
            // 
            // colIdEstatus
            // 
            this.colIdEstatus.FieldName = "IdEstatus";
            this.colIdEstatus.Name = "colIdEstatus";
            // 
            // colDescEstatus
            // 
            this.colDescEstatus.Caption = "Estatus";
            this.colDescEstatus.FieldName = "DescEstatus";
            this.colDescEstatus.Name = "colDescEstatus";
            // 
            // colComentarios
            // 
            this.colComentarios.FieldName = "Comentarios";
            this.colComentarios.Name = "colComentarios";
            this.colComentarios.Visible = true;
            this.colComentarios.VisibleIndex = 30;
            // 
            // colIdBancoOrigen
            // 
            this.colIdBancoOrigen.Caption = "Banco Origen";
            this.colIdBancoOrigen.FieldName = "IdBancoOrigen";
            this.colIdBancoOrigen.Name = "colIdBancoOrigen";
            // 
            // colNombreBancoOrI
            // 
            this.colNombreBancoOrI.Caption = "Banco Origen";
            this.colNombreBancoOrI.FieldName = "NombreBancoOrI";
            this.colNombreBancoOrI.Name = "colNombreBancoOrI";
            this.colNombreBancoOrI.Visible = true;
            this.colNombreBancoOrI.VisibleIndex = 20;
            // 
            // colIdBancoDestino
            // 
            this.colIdBancoDestino.FieldName = "IdBancoDestino";
            this.colIdBancoDestino.Name = "colIdBancoDestino";
            // 
            // colNombreBancoDES
            // 
            this.colNombreBancoDES.Caption = "Banco Destino";
            this.colNombreBancoDES.FieldName = "NombreBancoDES";
            this.colNombreBancoDES.Name = "colNombreBancoDES";
            this.colNombreBancoDES.Visible = true;
            this.colNombreBancoDES.VisibleIndex = 21;
            // 
            // colArchivo
            // 
            this.colArchivo.FieldName = "Archivo";
            this.colArchivo.Name = "colArchivo";
            // 
            // colIdOperador
            // 
            this.colIdOperador.FieldName = "IdOperador";
            this.colIdOperador.Name = "colIdOperador";
            // 
            // colNombreCompletoOperador
            // 
            this.colNombreCompletoOperador.Caption = "Operador";
            this.colNombreCompletoOperador.FieldName = "NombreCompletoOperador";
            this.colNombreCompletoOperador.Name = "colNombreCompletoOperador";
            this.colNombreCompletoOperador.Visible = true;
            this.colNombreCompletoOperador.VisibleIndex = 31;
            // 
            // colFechaCreacion
            // 
            this.colFechaCreacion.Caption = "Fecha Creación";
            this.colFechaCreacion.FieldName = "FechaCreacion";
            this.colFechaCreacion.Name = "colFechaCreacion";
            this.colFechaCreacion.Visible = true;
            this.colFechaCreacion.VisibleIndex = 29;
            // 
            // colSistema
            // 
            this.colSistema.Caption = "Sistema";
            this.colSistema.FieldName = "Sistema";
            this.colSistema.Name = "colSistema";
            this.colSistema.Visible = true;
            this.colSistema.VisibleIndex = 32;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 31);
            this.barDockControlTop.Manager = null;
            this.barDockControlTop.Size = new System.Drawing.Size(983, 0);
            // 
            // barDockControl7
            // 
            this.barDockControl7.CausesValidation = false;
            this.barDockControl7.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl7.Location = new System.Drawing.Point(0, 31);
            this.barDockControl7.Manager = null;
            this.barDockControl7.Size = new System.Drawing.Size(983, 0);
            // 
            // barDockControl8
            // 
            this.barDockControl8.CausesValidation = false;
            this.barDockControl8.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl8.Location = new System.Drawing.Point(0, 31);
            this.barDockControl8.Manager = null;
            this.barDockControl8.Size = new System.Drawing.Size(983, 0);
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
            this.txtUUID,
            this.barButtonItem1});
            this.barManager1.MaxItemId = 15;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemTimeEdit1,
            this.repositoryItemDateEdit1,
            this.repositoryItemTextEdit2,
            this.repositoryItemDateEdit2,
            this.repositoryItemTextEdit3});
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, this.dtFechaFin, "", false, true, true, 86),
            new DevExpress.XtraBars.LinkPersistInfo(((DevExpress.XtraBars.BarLinkUserDefines)((DevExpress.XtraBars.BarLinkUserDefines.PaintStyle | DevExpress.XtraBars.BarLinkUserDefines.Width))), this.txtUUID, "", false, true, true, 142, null, DevExpress.XtraBars.BarItemPaintStyle.Caption),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnActualizar),
            new DevExpress.XtraBars.LinkPersistInfo(this.barEliminarFiltro),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDescargarComprobante),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnContabilizar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDescontabilizar),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1)});
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
            this.dtFechaIni.Tag = "Fecha Inicio";
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
            this.dtFechaFin.Tag = "Fecha Inicio";
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
            // txtUUID
            // 
            this.txtUUID.Caption = "UUID";
            this.txtUUID.Edit = this.repositoryItemTextEdit3;
            this.txtUUID.EditValue = "";
            this.txtUUID.Id = 13;
            this.txtUUID.Name = "txtUUID";
            this.txtUUID.Tag = "UUID";
            // 
            // repositoryItemTextEdit3
            // 
            this.repositoryItemTextEdit3.AutoHeight = false;
            this.repositoryItemTextEdit3.Name = "repositoryItemTextEdit3";
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
            // btnDescargarComprobante
            // 
            this.btnDescargarComprobante.Caption = "Descargar XML/PDF";
            this.btnDescargarComprobante.Id = 5;
            this.btnDescargarComprobante.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDescargarComprobante.ImageOptions.Image")));
            this.btnDescargarComprobante.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDescargarComprobante.ImageOptions.LargeImage")));
            this.btnDescargarComprobante.Name = "btnDescargarComprobante";
            this.btnDescargarComprobante.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnDescargarComprobante.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDescargarComprobante_ItemClick);
            // 
            // btnContabilizar
            // 
            this.btnContabilizar.Caption = "Contabilizar";
            this.btnContabilizar.Id = 11;
            this.btnContabilizar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnContabilizar.ImageOptions.Image")));
            this.btnContabilizar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnContabilizar.ImageOptions.LargeImage")));
            this.btnContabilizar.Name = "btnContabilizar";
            this.btnContabilizar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnContabilizar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnContabilizar_ItemClick);
            // 
            // btnDescontabilizar
            // 
            this.btnDescontabilizar.Caption = "Descontabilizar";
            this.btnDescontabilizar.Id = 12;
            this.btnDescontabilizar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDescontabilizar.ImageOptions.Image")));
            this.btnDescontabilizar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDescontabilizar.ImageOptions.LargeImage")));
            this.btnDescontabilizar.Name = "btnDescontabilizar";
            this.btnDescontabilizar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnDescontabilizar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDescontabilizar_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 14;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.barManager1;
            this.barDockControl1.Size = new System.Drawing.Size(983, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 524);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(983, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 493);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl2.Location = new System.Drawing.Point(983, 31);
            this.barDockControl2.Manager = this.barManager1;
            this.barDockControl2.Size = new System.Drawing.Size(0, 493);
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
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // vwFactCatEstatusSolicitudGlobalBindingSource
            // 
            this.vwFactCatEstatusSolicitudGlobalBindingSource.DataMember = "vwFactCatEstatusSolicitudGlobal";
            this.vwFactCatEstatusSolicitudGlobalBindingSource.DataSource = this.dbSAICBPOFactura;
            // 
            // vwFactCatEstatusSolicitudGlobalTableAdapter
            // 
            this.vwFactCatEstatusSolicitudGlobalTableAdapter.ClearBeforeFill = true;
            // 
            // stpFactSelDerechosAccesoOperadorFacturacionTableAdapter1
            // 
            this.stpFactSelDerechosAccesoOperadorFacturacionTableAdapter1.ClearBeforeFill = true;
            // 
            // stpFactSelComprobantesFacturaTableAdapter1
            // 
            this.stpFactSelComprobantesFacturaTableAdapter1.ClearBeforeFill = true;
            // 
            // stpFactSelHeaderFacturasTimbradasTableAdapter
            // 
            this.stpFactSelHeaderFacturasTimbradasTableAdapter.ClearBeforeFill = true;
            // 
            // splashSMCargando
            // 
            this.splashSMCargando.ClosingDelay = 500;
            // 
            // frmVisualiarFacturasTimbradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 524);
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
            this.Name = "frmVisualiarFacturasTimbradas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizar y Contabilizar Facturas Timbradas";
            this.Load += new System.EventHandler(this.frmMonitoreoFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cboIdTenedoraSA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboIdCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSolicitudChequesMasivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelHeaderFacturasTimbradasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwFactCatEstatusSolicitudGlobalBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource vwFactCatEstatusSolicitudGlobalBindingSource;
        private dbSAICBPOFacturaTableAdapters.vwFactCatEstatusSolicitudGlobalTableAdapter vwFactCatEstatusSolicitudGlobalTableAdapter;
        private DevExpress.XtraBars.BarButtonItem barEliminarFiltro;
        private DevExpress.XtraBars.BarButtonItem btnDescargarComprobante;
        private winAppSAIC.Catalogos.dbSAICBPO_CatalogosValidacionDataSetTableAdapters.ValidacionesGeneralTableAdapter validacionesGeneralTableAdapter1;
        private dbSAICBPOFacturaTableAdapters.stpFactSelDerechosAccesoOperadorFacturacionTableAdapter stpFactSelDerechosAccesoOperadorFacturacionTableAdapter1;
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
        private DevExpress.XtraGrid.Columns.GridColumn colIdMetodoPago;
        private DevExpress.XtraGrid.Columns.GridColumn colClaveMetodoPago;
        private DevExpress.XtraGrid.Columns.GridColumn colDescMetodoPago;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFormaPago;
        private DevExpress.XtraGrid.Columns.GridColumn colDescFormaPago;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMoneda;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoCambio;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaPago;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalDepositado;
        private DevExpress.XtraGrid.Columns.GridColumn colSubTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colIVA;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colImporteConLetra;
        private DevExpress.XtraGrid.Columns.GridColumn colUUID;
        private DevExpress.XtraGrid.Columns.GridColumn colIdHeaderFacturaRelacion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoRelacion;
        private DevExpress.XtraGrid.Columns.GridColumn colDescTipoRelacion;
        private DevExpress.XtraGrid.Columns.GridColumn colUUIDRelacion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstatus;
        private DevExpress.XtraGrid.Columns.GridColumn colDescEstatus;
        private DevExpress.XtraGrid.Columns.GridColumn colComentarios;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBancoOrigen;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreBancoOrI;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBancoDestino;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreBancoDES;
        private DevExpress.XtraGrid.Columns.GridColumn colArchivo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdOperador;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreCompletoOperador;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaCreacion;
        private DevExpress.XtraGrid.Columns.GridColumn colAnoContabilidad;
        private DevExpress.XtraGrid.Columns.GridColumn colMesContabilidad;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaContabilidad;
        private dbSAICBPOFacturaTableAdapters.stpFactSelComprobantesFacturaTableAdapter stpFactSelComprobantesFacturaTableAdapter1;
        private DevExpress.XtraBars.BarButtonItem btnContabilizar;
        private DevExpress.XtraBars.BarButtonItem btnDescontabilizar;
        private dbSAICBPOFacturaTableAdapters.spSoloRespuesta spSoloRespuesta1;
        private DevExpress.XtraGrid.Columns.GridColumn colSerie;
        private DevExpress.XtraGrid.Columns.GridColumn ColFolio;
        private System.Windows.Forms.BindingSource stpFactSelHeaderFacturasTimbradasBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colSistema;
        private dbSAICBPOFacturaTableAdapters.stpFactSelHeaderFacturasTimbradasTableAdapter stpFactSelHeaderFacturasTimbradasTableAdapter;
        private DevExpress.XtraBars.BarEditItem txtUUID;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashSMCargando;
    }
}