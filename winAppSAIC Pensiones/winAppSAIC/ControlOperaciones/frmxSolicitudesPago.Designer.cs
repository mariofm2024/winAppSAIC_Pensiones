namespace winAppSAIC.ControlOperaciones
{
    partial class frmxSolicitudesPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmxSolicitudesPago));
            this.panel1 = new System.Windows.Forms.Panel();
            this.sidePanel2 = new DevExpress.XtraEditors.SidePanel();
            this.gridSolicitudes = new DevExpress.XtraGrid.GridControl();
            this.stpTesSelSolicitudPagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPOFactura = new winAppSAIC.Facturas.dbSAICBPOFactura();
            this.dgvSolicitudes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdSolicitudPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreCompletoOperador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaCreacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioModificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaModificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescEstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservacionesCancelacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioConfirmacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaConfirmacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTOTAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPorcentaje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COLCLIENTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COLFRONTING1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COLFRONTING2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COLFRONTING3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COLFRONTING4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COLFRONTING5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.dtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtFechaIni = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.vwTesCatEstatusSolicitudGlobalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stpTesSelSolicitudPagoTableAdapter = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpTesSelSolicitudPagoTableAdapter();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnSalir = new DevExpress.XtraBars.BarButtonItem();
            this.btnCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.btnExportar = new DevExpress.XtraBars.BarButtonItem();
            this.btnFiltrar = new DevExpress.XtraBars.BarButtonItem();
            this.btnEFiltro = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnConfirmar = new DevExpress.XtraBars.BarButtonItem();
            this.btnDescargar = new DevExpress.XtraBars.BarButtonItem();
            this.btnDescargarControl = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.splashSMCargando = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::winAppSAIC.frmxCargandoInformacion), true, true);
            this.spSoloRespuesta1 = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.spSoloRespuesta();
            this.vwTesCatEstatusSolicitudGlobalTableAdapter = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.vwTesCatEstatusSolicitudGlobalTableAdapter();
            this.stpFactSelDerechosAccesoOperadorFacturacionTableAdapter1 = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelDerechosAccesoOperadorFacturacionTableAdapter();
            this.validacionesGeneralTableAdapter1 = new winAppSAIC.Catalogos.dbSAICBPO_CatalogosValidacionDataSetTableAdapters.ValidacionesGeneralTableAdapter();
            this.savedescarga = new System.Windows.Forms.SaveFileDialog();
            this.stpFactSelComprobantesFacturaTableAdapter1 = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelComprobantesFacturaTableAdapter();
            this.queriesAsimilados1 = new winAppSAIC.Asimilados.dbSAICAsimiladosTableAdapters.QueriesAsimilados();
            this.panel1.SuspendLayout();
            this.sidePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSolicitudes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpTesSelSolicitudPagoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).BeginInit();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vwTesCatEstatusSolicitudGlobalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sidePanel2);
            this.panel1.Controls.Add(this.sidePanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1294, 324);
            this.panel1.TabIndex = 1;
            // 
            // sidePanel2
            // 
            this.sidePanel2.Controls.Add(this.gridSolicitudes);
            this.sidePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidePanel2.Location = new System.Drawing.Point(0, 36);
            this.sidePanel2.Name = "sidePanel2";
            this.sidePanel2.Size = new System.Drawing.Size(1294, 288);
            this.sidePanel2.TabIndex = 2;
            this.sidePanel2.Text = "sidePanel2";
            // 
            // gridSolicitudes
            // 
            this.gridSolicitudes.DataSource = this.stpTesSelSolicitudPagoBindingSource;
            this.gridSolicitudes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSolicitudes.Location = new System.Drawing.Point(0, 0);
            this.gridSolicitudes.MainView = this.dgvSolicitudes;
            this.gridSolicitudes.Name = "gridSolicitudes";
            this.gridSolicitudes.Size = new System.Drawing.Size(1294, 288);
            this.gridSolicitudes.TabIndex = 0;
            this.gridSolicitudes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvSolicitudes});
            // 
            // stpTesSelSolicitudPagoBindingSource
            // 
            this.stpTesSelSolicitudPagoBindingSource.DataMember = "stpTesSelSolicitudPago";
            this.stpTesSelSolicitudPagoBindingSource.DataSource = this.dbSAICBPOFactura;
            // 
            // dbSAICBPOFactura
            // 
            this.dbSAICBPOFactura.DataSetName = "dbSAICBPOFactura";
            this.dbSAICBPOFactura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvSolicitudes
            // 
            this.dgvSolicitudes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdSolicitudPago,
            this.colIdCO,
            this.colDescripcion,
            this.colNombreCompletoOperador,
            this.colFechaCreacion,
            this.colUsuarioModificacion,
            this.colFechaModificacion,
            this.colIdEstatus,
            this.colDescEstatus,
            this.colObservacionesCancelacion,
            this.colUsuarioConfirmacion,
            this.colFechaConfirmacion,
            this.colTOTAL,
            this.colPorcentaje,
            this.COLCLIENTE,
            this.COLFRONTING1,
            this.COLFRONTING2,
            this.COLFRONTING3,
            this.COLFRONTING4,
            this.COLFRONTING5});
            this.dgvSolicitudes.GridControl = this.gridSolicitudes;
            this.dgvSolicitudes.Name = "dgvSolicitudes";
            this.dgvSolicitudes.OptionsBehavior.Editable = false;
            this.dgvSolicitudes.OptionsView.ColumnAutoWidth = false;
            this.dgvSolicitudes.OptionsView.ShowGroupPanel = false;
            this.dgvSolicitudes.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.dgvSolicitudes_RowStyle);
            this.dgvSolicitudes.DoubleClick += new System.EventHandler(this.dgvSolicitudes_DoubleClick);
            // 
            // colIdSolicitudPago
            // 
            this.colIdSolicitudPago.Caption = "Id Solicitud de Pago";
            this.colIdSolicitudPago.FieldName = "IdSolicitudPago";
            this.colIdSolicitudPago.Name = "colIdSolicitudPago";
            this.colIdSolicitudPago.Visible = true;
            this.colIdSolicitudPago.VisibleIndex = 0;
            this.colIdSolicitudPago.Width = 67;
            // 
            // colIdCO
            // 
            this.colIdCO.Caption = "Id Control Operaciones";
            this.colIdCO.FieldName = "IdCO";
            this.colIdCO.Name = "colIdCO";
            this.colIdCO.Visible = true;
            this.colIdCO.VisibleIndex = 1;
            this.colIdCO.Width = 85;
            // 
            // colDescripcion
            // 
            this.colDescripcion.Caption = "Descripción";
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            // 
            // colNombreCompletoOperador
            // 
            this.colNombreCompletoOperador.Caption = "Operador";
            this.colNombreCompletoOperador.FieldName = "NombreCompletoOperador";
            this.colNombreCompletoOperador.Name = "colNombreCompletoOperador";
            this.colNombreCompletoOperador.Visible = true;
            this.colNombreCompletoOperador.VisibleIndex = 2;
            this.colNombreCompletoOperador.Width = 246;
            // 
            // colFechaCreacion
            // 
            this.colFechaCreacion.Caption = "Fecha Creación";
            this.colFechaCreacion.DisplayFormat.FormatString = "dd-MM-yyyy H:mm:ss";
            this.colFechaCreacion.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colFechaCreacion.FieldName = "FechaCreacion";
            this.colFechaCreacion.Name = "colFechaCreacion";
            this.colFechaCreacion.Visible = true;
            this.colFechaCreacion.VisibleIndex = 3;
            this.colFechaCreacion.Width = 110;
            // 
            // colUsuarioModificacion
            // 
            this.colUsuarioModificacion.Caption = "Usuario Cancelación";
            this.colUsuarioModificacion.FieldName = "UsuarioModificacion";
            this.colUsuarioModificacion.Name = "colUsuarioModificacion";
            this.colUsuarioModificacion.Visible = true;
            this.colUsuarioModificacion.VisibleIndex = 9;
            this.colUsuarioModificacion.Width = 116;
            // 
            // colFechaModificacion
            // 
            this.colFechaModificacion.Caption = "Fecha Cancelación";
            this.colFechaModificacion.DisplayFormat.FormatString = "dd-MM-yyyy H:mm:ss";
            this.colFechaModificacion.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colFechaModificacion.FieldName = "FechaModificacion";
            this.colFechaModificacion.Name = "colFechaModificacion";
            this.colFechaModificacion.Visible = true;
            this.colFechaModificacion.VisibleIndex = 10;
            this.colFechaModificacion.Width = 109;
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
            this.colDescEstatus.Visible = true;
            this.colDescEstatus.VisibleIndex = 4;
            this.colDescEstatus.Width = 147;
            // 
            // colObservacionesCancelacion
            // 
            this.colObservacionesCancelacion.FieldName = "ObservacionesCancelacion";
            this.colObservacionesCancelacion.Name = "colObservacionesCancelacion";
            // 
            // colUsuarioConfirmacion
            // 
            this.colUsuarioConfirmacion.Caption = "Usuario Pago";
            this.colUsuarioConfirmacion.FieldName = "UsuarioConfirmacion";
            this.colUsuarioConfirmacion.Name = "colUsuarioConfirmacion";
            this.colUsuarioConfirmacion.Visible = true;
            this.colUsuarioConfirmacion.VisibleIndex = 8;
            this.colUsuarioConfirmacion.Width = 132;
            // 
            // colFechaConfirmacion
            // 
            this.colFechaConfirmacion.Caption = "Fecha Pago";
            this.colFechaConfirmacion.DisplayFormat.FormatString = "dd-MM-yyyy H:mm:ss";
            this.colFechaConfirmacion.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colFechaConfirmacion.FieldName = "FechaConfirmacion";
            this.colFechaConfirmacion.Name = "colFechaConfirmacion";
            this.colFechaConfirmacion.Visible = true;
            this.colFechaConfirmacion.VisibleIndex = 7;
            this.colFechaConfirmacion.Width = 149;
            // 
            // colTOTAL
            // 
            this.colTOTAL.Caption = "Total Control";
            this.colTOTAL.DisplayFormat.FormatString = "{0:C2}";
            this.colTOTAL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTOTAL.FieldName = "TOTAL";
            this.colTOTAL.Name = "colTOTAL";
            this.colTOTAL.Visible = true;
            this.colTOTAL.VisibleIndex = 6;
            // 
            // colPorcentaje
            // 
            this.colPorcentaje.Caption = "% Avance";
            this.colPorcentaje.FieldName = "Porcentaje";
            this.colPorcentaje.Name = "colPorcentaje";
            this.colPorcentaje.Visible = true;
            this.colPorcentaje.VisibleIndex = 5;
            // 
            // COLCLIENTE
            // 
            this.COLCLIENTE.Caption = "CLIENTE";
            this.COLCLIENTE.FieldName = "CLIENTE";
            this.COLCLIENTE.Name = "COLCLIENTE";
            this.COLCLIENTE.Visible = true;
            this.COLCLIENTE.VisibleIndex = 11;
            this.COLCLIENTE.Width = 150;
            // 
            // COLFRONTING1
            // 
            this.COLFRONTING1.Caption = "FRONTING 1";
            this.COLFRONTING1.FieldName = "FRONTING1";
            this.COLFRONTING1.Name = "COLFRONTING1";
            this.COLFRONTING1.Visible = true;
            this.COLFRONTING1.VisibleIndex = 12;
            this.COLFRONTING1.Width = 222;
            // 
            // COLFRONTING2
            // 
            this.COLFRONTING2.Caption = "FRONTING 2";
            this.COLFRONTING2.FieldName = "FRONTING2";
            this.COLFRONTING2.Name = "COLFRONTING2";
            this.COLFRONTING2.Visible = true;
            this.COLFRONTING2.VisibleIndex = 13;
            this.COLFRONTING2.Width = 206;
            // 
            // COLFRONTING3
            // 
            this.COLFRONTING3.Caption = "FRONTING 3";
            this.COLFRONTING3.FieldName = "FRONTING3";
            this.COLFRONTING3.Name = "COLFRONTING3";
            this.COLFRONTING3.Visible = true;
            this.COLFRONTING3.VisibleIndex = 14;
            this.COLFRONTING3.Width = 201;
            // 
            // COLFRONTING4
            // 
            this.COLFRONTING4.Caption = "FRONTING 4";
            this.COLFRONTING4.FieldName = "FRONTING4";
            this.COLFRONTING4.Name = "COLFRONTING4";
            this.COLFRONTING4.Visible = true;
            this.COLFRONTING4.VisibleIndex = 15;
            this.COLFRONTING4.Width = 238;
            // 
            // COLFRONTING5
            // 
            this.COLFRONTING5.Caption = "FRONTING 5";
            this.COLFRONTING5.FieldName = "FRONTING5";
            this.COLFRONTING5.Name = "COLFRONTING5";
            this.COLFRONTING5.Visible = true;
            this.COLFRONTING5.VisibleIndex = 16;
            this.COLFRONTING5.Width = 174;
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.dtFechaFin);
            this.sidePanel1.Controls.Add(this.dtFechaIni);
            this.sidePanel1.Controls.Add(this.label9);
            this.sidePanel1.Controls.Add(this.label10);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel1.Location = new System.Drawing.Point(0, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(1294, 36);
            this.sidePanel1.TabIndex = 1;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // dtFechaFin
            // 
            this.dtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaFin.Location = new System.Drawing.Point(314, 6);
            this.dtFechaFin.Name = "dtFechaFin";
            this.dtFechaFin.Size = new System.Drawing.Size(114, 21);
            this.dtFechaFin.TabIndex = 107;
            this.dtFechaFin.Tag = "Fecha Fin";
            this.dtFechaFin.Value = new System.DateTime(2018, 6, 4, 10, 45, 4, 0);
            // 
            // dtFechaIni
            // 
            this.dtFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaIni.Location = new System.Drawing.Point(104, 6);
            this.dtFechaIni.Name = "dtFechaIni";
            this.dtFechaIni.Size = new System.Drawing.Size(114, 21);
            this.dtFechaIni.TabIndex = 105;
            this.dtFechaIni.Tag = "Fecha Inicio";
            this.dtFechaIni.Value = new System.DateTime(2018, 6, 4, 10, 44, 56, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 106;
            this.label9.Text = "Fecha de Inicio:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(236, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 108;
            this.label10.Text = "Fecha de Fin:";
            // 
            // vwTesCatEstatusSolicitudGlobalBindingSource
            // 
            this.vwTesCatEstatusSolicitudGlobalBindingSource.DataMember = "vwTesCatEstatusSolicitudGlobal";
            this.vwTesCatEstatusSolicitudGlobalBindingSource.DataSource = this.dbSAICBPOFactura;
            // 
            // stpTesSelSolicitudPagoTableAdapter
            // 
            this.stpTesSelSolicitudPagoTableAdapter.ClearBeforeFill = true;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnSalir,
            this.btnConfirmar,
            this.btnCancelar,
            this.btnFiltrar,
            this.btnEFiltro,
            this.btnExportar,
            this.btnDescargar,
            this.btnDescargarControl,
            this.barButtonItem2});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 9;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSalir),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCancelar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExportar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnFiltrar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEFiltro)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
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
            // btnCancelar
            // 
            this.btnCancelar.Caption = "Cancelar Solicitud";
            this.btnCancelar.Id = 2;
            this.btnCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.ImageOptions.Image")));
            this.btnCancelar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.ImageOptions.LargeImage")));
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnCancelar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCancelar_ItemClick);
            // 
            // btnExportar
            // 
            this.btnExportar.Caption = "Exportar a Excel";
            this.btnExportar.Id = 5;
            this.btnExportar.ImageOptions.Image = global::winAppSAIC.Properties.Resources.if_excel_83688;
            this.btnExportar.ImageOptions.LargeImage = global::winAppSAIC.Properties.Resources.if_excel_836881;
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnExportar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExportar_ItemClick);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Caption = "Filtrar";
            this.btnFiltrar.Id = 3;
            this.btnFiltrar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrar.ImageOptions.Image")));
            this.btnFiltrar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnFiltrar.ImageOptions.LargeImage")));
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnFiltrar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFiltrar_ItemClick);
            // 
            // btnEFiltro
            // 
            this.btnEFiltro.Caption = "Eliminar Filtro";
            this.btnEFiltro.Id = 4;
            this.btnEFiltro.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEFiltro.ImageOptions.Image")));
            this.btnEFiltro.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEFiltro.ImageOptions.LargeImage")));
            this.btnEFiltro.Name = "btnEFiltro";
            this.btnEFiltro.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnEFiltro.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEFiltro_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1294, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 348);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1294, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 324);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1294, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 324);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Caption = "Confirmar 100%";
            this.btnConfirmar.Id = 1;
            this.btnConfirmar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmar.ImageOptions.Image")));
            this.btnConfirmar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnConfirmar.ImageOptions.LargeImage")));
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnDescargar
            // 
            this.btnDescargar.Caption = "Descargar Control";
            this.btnDescargar.Id = 6;
            this.btnDescargar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDescargar.ImageOptions.Image")));
            this.btnDescargar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDescargar.ImageOptions.LargeImage")));
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnDescargarControl
            // 
            this.btnDescargarControl.Caption = "Descargar Control";
            this.btnDescargarControl.Id = 7;
            this.btnDescargarControl.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDescargarControl.ImageOptions.Image")));
            this.btnDescargarControl.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDescargarControl.ImageOptions.LargeImage")));
            this.btnDescargarControl.Name = "btnDescargarControl";
            this.btnDescargarControl.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 8;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // splashSMCargando
            // 
            this.splashSMCargando.ClosingDelay = 500;
            // 
            // vwTesCatEstatusSolicitudGlobalTableAdapter
            // 
            this.vwTesCatEstatusSolicitudGlobalTableAdapter.ClearBeforeFill = true;
            // 
            // stpFactSelDerechosAccesoOperadorFacturacionTableAdapter1
            // 
            this.stpFactSelDerechosAccesoOperadorFacturacionTableAdapter1.ClearBeforeFill = true;
            // 
            // stpFactSelComprobantesFacturaTableAdapter1
            // 
            this.stpFactSelComprobantesFacturaTableAdapter1.ClearBeforeFill = true;
            // 
            // frmxSolicitudesPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 348);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmxSolicitudesPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administración de Solicitudes de Pago";
            this.Load += new System.EventHandler(this.frmxSolicitudesPago_Load);
            this.panel1.ResumeLayout(false);
            this.sidePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSolicitudes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpTesSelSolicitudPagoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            this.sidePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vwTesCatEstatusSolicitudGlobalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridSolicitudes;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvSolicitudes;
        private DevExpress.XtraEditors.SidePanel sidePanel2;
        private System.Windows.Forms.BindingSource stpTesSelSolicitudPagoBindingSource;
        private Facturas.dbSAICBPOFactura dbSAICBPOFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSolicitudPago;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCO;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreCompletoOperador;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaCreacion;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioModificacion;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaModificacion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstatus;
        private DevExpress.XtraGrid.Columns.GridColumn colDescEstatus;
        private DevExpress.XtraGrid.Columns.GridColumn colObservacionesCancelacion;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private Facturas.dbSAICBPOFacturaTableAdapters.stpTesSelSolicitudPagoTableAdapter stpTesSelSolicitudPagoTableAdapter;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnSalir;
        private DevExpress.XtraBars.BarButtonItem btnConfirmar;
        private DevExpress.XtraBars.BarButtonItem btnCancelar;
        private DevExpress.XtraBars.BarButtonItem btnFiltrar;
        private DevExpress.XtraBars.BarButtonItem btnEFiltro;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.DateTimePicker dtFechaFin;
        private System.Windows.Forms.DateTimePicker dtFechaIni;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashSMCargando;
        private Facturas.dbSAICBPOFacturaTableAdapters.spSoloRespuesta spSoloRespuesta1;
        private System.Windows.Forms.BindingSource vwTesCatEstatusSolicitudGlobalBindingSource;
        private Facturas.dbSAICBPOFacturaTableAdapters.vwTesCatEstatusSolicitudGlobalTableAdapter vwTesCatEstatusSolicitudGlobalTableAdapter;
        private Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelDerechosAccesoOperadorFacturacionTableAdapter stpFactSelDerechosAccesoOperadorFacturacionTableAdapter1;
        private Catalogos.dbSAICBPO_CatalogosValidacionDataSetTableAdapters.ValidacionesGeneralTableAdapter validacionesGeneralTableAdapter1;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioConfirmacion;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaConfirmacion;
        private DevExpress.XtraGrid.Columns.GridColumn colTOTAL;
        private DevExpress.XtraGrid.Columns.GridColumn colPorcentaje;
        private DevExpress.XtraBars.BarButtonItem btnExportar;
        private System.Windows.Forms.SaveFileDialog savedescarga;
        private DevExpress.XtraBars.BarButtonItem btnDescargar;
        private DevExpress.XtraBars.BarButtonItem btnDescargarControl;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelComprobantesFacturaTableAdapter stpFactSelComprobantesFacturaTableAdapter1;
        private DevExpress.XtraGrid.Columns.GridColumn COLCLIENTE;
        private DevExpress.XtraGrid.Columns.GridColumn COLFRONTING1;
        private DevExpress.XtraGrid.Columns.GridColumn COLFRONTING2;
        private DevExpress.XtraGrid.Columns.GridColumn COLFRONTING3;
        private DevExpress.XtraGrid.Columns.GridColumn COLFRONTING4;
        private DevExpress.XtraGrid.Columns.GridColumn COLFRONTING5;
        private Asimilados.dbSAICAsimiladosTableAdapters.QueriesAsimilados queriesAsimilados1;
    }
}