namespace winAppSAIC.ControlOperaciones
{
    partial class frmxSolicitudesPagoDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmxSolicitudesPagoDetail));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnSalir = new DevExpress.XtraBars.BarButtonItem();
            this.btnConfirmar = new DevExpress.XtraBars.BarButtonItem();
            this.btnAnularPago = new DevExpress.XtraBars.BarButtonItem();
            this.btnCargar = new DevExpress.XtraBars.BarButtonItem();
            this.btnDescargar = new DevExpress.XtraBars.BarButtonItem();
            this.btnDescargarC = new DevExpress.XtraBars.BarButtonItem();
            this.btnCarpeta = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barEditItem2 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.barEditItem3 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.spSoloRespuesta1 = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.spSoloRespuesta();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.gridControl5 = new DevExpress.XtraGrid.GridControl();
            this.stpTesSelSolicitudPagoDetailLayoutBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICAsimilados = new winAppSAIC.Asimilados.dbSAICAsimilados();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdSolicitudPagoDetail2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSolicitudPago1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCO1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdLoteCargaNomina3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFolioLoteCargaNomina1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTenedora2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRazonSocial2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdBanco1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreBanco1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdFormato1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescFormatoLayoutBanco1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmisora1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaPago1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstatus2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescEstatus2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdOperador1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreCompletoOperador1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservaciones1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbFlagDescarga1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoEmpleados1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLeyenda1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dtFechaPago = new System.Windows.Forms.DateTimePicker();
            this.gridControl4 = new DevExpress.XtraGrid.GridControl();
            this.stpTesSelSolicitudPagoDetailLayoutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPOTesoreriaDataSet = new winAppSAIC.Tesoreria.dbSAICBPOTesoreriaDataSet();
            this.dgvDetailSolicitud = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdSolicitudPagoDetail1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSolicitudPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdLoteCargaNomina2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFolioLoteCargaNomina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTenedora1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRazonSocial1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdFormato = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescFormatoLayoutBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmisora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstatus1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescEstatus1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdOperador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreCompletoOperador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservaciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbFlagDescarga = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoEmpleados = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLeyenda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.stpTesSelFacturasControlBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPOFactura = new winAppSAIC.Facturas.dbSAICBPOFactura();
            this.dgvLotesFac = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdHEaderFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.stpTesSelLotesControlBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvLotesAS = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdLoteCargaNomina1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.stpTesSelSolicitudPagoDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvSolicitudDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdSolicitudPagoDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTenedora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRazonSocial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescEstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaConfirmaPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioConfirmaPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaAltaArchivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioAltaArchivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBandera = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioCancelarPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaCancelarPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdLoteCargaNomina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActualizar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnActualiza = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.stpFactSelComprobanteSolicitudesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stpTesSelSolicitudPagoDetailTableAdapter = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpTesSelSolicitudPagoDetailTableAdapter();
            this.dbSAICBPOValidacionDataSet1 = new winAppSAIC.dbSAICBPOValidacionDataSet();
            this.splashSMCargando = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::winAppSAIC.frmxCargandoInformacion), true, true);
            this.validacionesGeneralTableAdapter1 = new winAppSAIC.Catalogos.dbSAICBPO_CatalogosValidacionDataSetTableAdapters.ValidacionesGeneralTableAdapter();
            this.stpFactSelComprobanteSolicitudesTableAdapter = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelComprobanteSolicitudesTableAdapter();
            this.stpFactSelDerechosAccesoOperadorFacturacionTableAdapter1 = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelDerechosAccesoOperadorFacturacionTableAdapter();
            this.stpSelParametroTableAdapter1 = new winAppSAIC.dbSAICBPOValidacionDataSetTableAdapters.stpSelParametroTableAdapter();
            this.stpFactSelComprobantesFacturaTableAdapter1 = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelComprobantesFacturaTableAdapter();
            this.stpTesSelLotesControlTableAdapter = new winAppSAIC.Asimilados.dbSAICAsimiladosTableAdapters.stpTesSelLotesControlTableAdapter();
            this.stpTesSelFacturasControlTableAdapter = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpTesSelFacturasControlTableAdapter();
            this.stpTesSelSolicitudPagoDetailLayoutTableAdapter = new winAppSAIC.Tesoreria.dbSAICBPOTesoreriaDataSetTableAdapters.stpTesSelSolicitudPagoDetailLayoutTableAdapter();
            this.stpSelInfoBancoCuentasLayoutTableAdapter1 = new winAppSAIC.dbSAICBPOValidacionDataSetTableAdapters.stpSelInfoBancoCuentasLayoutTableAdapter();
            this.stpSelLayoutBanamexTEFC05TableAdapter1 = new winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.stpSelLayoutBanamexTEFC05TableAdapter();
            this.dbSAICBPOReportesDataSet1 = new winAppSAIC.dbSAICBPOReportesDataSet();
            this.stpSelLayoutBanamexTEFC12TableAdapter1 = new winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.stpSelLayoutBanamexTEFC12TableAdapter();
            this.stpSelLayoutBanamexTEFD05TableAdapter1 = new winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.stpSelLayoutBanamexTEFD05TableAdapter();
            this.stpSelLayoutBanamexTEFD12TableAdapter1 = new winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.stpSelLayoutBanamexTEFD12TableAdapter();
            this.stpSelLayoutBancomer99TableAdapter1 = new winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.stpSelLayoutBancomer99TableAdapter();
            this.stpSelLayoutBancomer98TableAdapter1 = new winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.stpSelLayoutBancomer98TableAdapter();
            this.stpSelLayoutBanorte2016TableAdapter1 = new winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.stpSelLayoutBanorte2016TableAdapter();
            this.stpSelLayoutBanorteInterbancario2016TableAdapter1 = new winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.stpSelLayoutBanorteInterbancario2016TableAdapter();
            this.stpSelLayoutBanorteInterbancarioTableAdapter1 = new winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.stpSelLayoutBanorteInterbancarioTableAdapter();
            this.stpSelLayoutBanorteTableAdapter1 = new winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.stpSelLayoutBanorteTableAdapter();
            this.stpSelLayoutSantanderTableAdapter1 = new winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.stpSelLayoutSantanderTableAdapter();
            this.stpSelLayoutCIBancoTableAdapter1 = new winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.stpSelLayoutCIBancoTableAdapter();
            this.stpSelLayoutHSBCOtrasCuentasTableAdapter1 = new winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.stpSelLayoutHSBCOtrasCuentasTableAdapter();
            this.stpSelLayoutHSBCSPEITableAdapter1 = new winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.stpSelLayoutHSBCSPEITableAdapter();
            this.stpSelLayoutHSBCNominasTableAdapter1 = new winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.stpSelLayoutHSBCNominasTableAdapter();
            this.stpSelLayoutHSBCNETNominasTableAdapter1 = new winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.stpSelLayoutHSBCNETNominasTableAdapter();
            this.stpSelLayoutInbursaSPEITableAdapter1 = new winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.stpSelLayoutInbursaSPEITableAdapter();
            this.stpSelLayOutBancariosTableAdapter1 = new winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.stpSelLayOutBancariosTableAdapter();
            this.stpSelLayoutKuspitBanPay_InterbancariosProvTableAdapter1 = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpSelLayoutKuspitBanPay_InterbancariosProvTableAdapter();
            this.stpTesSelSolicitudPagoDetailLayoutTableAdapter1 = new winAppSAIC.Asimilados.dbSAICAsimiladosTableAdapters.stpTesSelSolicitudPagoDetailLayoutTableAdapter();
            this.stpSelLayoutBanamexTEFC05_IASTableAdapter1 = new winAppSAIC.Asimilados.dbSAICAsimiladosTableAdapters.stpSelLayoutBanamexTEFC05_IASTableAdapter();
            this.stpSelLayoutBanamexTEFC12_IASTableAdapter1 = new winAppSAIC.Asimilados.dbSAICAsimiladosTableAdapters.stpSelLayoutBanamexTEFC12_IASTableAdapter();
            this.stpSelLayoutBanamexTEFD05_IASTableAdapter1 = new winAppSAIC.Asimilados.dbSAICAsimiladosTableAdapters.stpSelLayoutBanamexTEFD05_IASTableAdapter();
            this.stpSelLayoutBanamexTEFD12_IASTableAdapter1 = new winAppSAIC.Asimilados.dbSAICAsimiladosTableAdapters.stpSelLayoutBanamexTEFD12_IASTableAdapter();
            this.stpSelLayoutBancomer99_IASTableAdapter1 = new winAppSAIC.Asimilados.dbSAICAsimiladosTableAdapters.stpSelLayoutBancomer99_IASTableAdapter();
            this.stpSelLayoutBancomer98_IASTableAdapter1 = new winAppSAIC.Asimilados.dbSAICAsimiladosTableAdapters.stpSelLayoutBancomer98_IASTableAdapter();
            this.stpSelLayoutBanorte_IASTableAdapter1 = new winAppSAIC.Asimilados.dbSAICAsimiladosTableAdapters.stpSelLayoutBanorte_IASTableAdapter();
            this.stpSelLayoutBanorteInterbancario_IASTableAdapter1 = new winAppSAIC.Asimilados.dbSAICAsimiladosTableAdapters.stpSelLayoutBanorteInterbancario_IASTableAdapter();
            this.stpSelLayoutSantander_IASTableAdapter1 = new winAppSAIC.Asimilados.dbSAICAsimiladosTableAdapters.stpSelLayoutSantander_IASTableAdapter();
            this.stpSelLayoutCIBanco_IASTableAdapter1 = new winAppSAIC.Asimilados.dbSAICAsimiladosTableAdapters.stpSelLayoutCIBanco_IASTableAdapter();
            this.stpSelLayoutHSBCOtrasCuentas_IASTableAdapter1 = new winAppSAIC.Asimilados.dbSAICAsimiladosTableAdapters.stpSelLayoutHSBCOtrasCuentas_IASTableAdapter();
            this.stpSelLayoutHSBCSPEI_IASTableAdapter1 = new winAppSAIC.Asimilados.dbSAICAsimiladosTableAdapters.stpSelLayoutHSBCSPEI_IASTableAdapter();
            this.stpSelLayoutHSBCNominas_IASTableAdapter1 = new winAppSAIC.Asimilados.dbSAICAsimiladosTableAdapters.stpSelLayoutHSBCNominas_IASTableAdapter();
            this.stpSelLayoutHSBCNETNominas_IASTableAdapter1 = new winAppSAIC.Asimilados.dbSAICAsimiladosTableAdapters.stpSelLayoutHSBCNETNominas_IASTableAdapter();
            this.stpSelLayoutInbursaSPEI_IASTableAdapter1 = new winAppSAIC.Asimilados.dbSAICAsimiladosTableAdapters.stpSelLayoutInbursaSPEI_IASTableAdapter();
            this.stpSelLayoutBanorte2016_IASTableAdapter1 = new winAppSAIC.Asimilados.dbSAICAsimiladosTableAdapters.stpSelLayoutBanorte2016_IASTableAdapter();
            this.stpSelLayoutBanorteInterbancario2016_IASTableAdapter1 = new winAppSAIC.Asimilados.dbSAICAsimiladosTableAdapters.stpSelLayoutBanorteInterbancario2016_IASTableAdapter();
            this.stpSelLayOutBancarios_IASTableAdapter1 = new winAppSAIC.Asimilados.dbSAICAsimiladosTableAdapters.stpSelLayOutBancarios_IASTableAdapter();
            this.stpSelLayoutKuspitBanPay_InterbancariosProv_IASTableAdapter1 = new winAppSAIC.Asimilados.dbSAICAsimiladosTableAdapters.stpSelLayoutKuspitBanPay_InterbancariosProv_IASTableAdapter();
            this.stpSelInfoBancoCuentasLayout_IASTableAdapter1 = new winAppSAIC.Asimilados.dbSAICAsimiladosTableAdapters.stpSelInfoBancoCuentasLayout_IASTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpTesSelSolicitudPagoDetailLayoutBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICAsimilados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpTesSelSolicitudPagoDetailLayoutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOTesoreriaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailSolicitud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpTesSelFacturasControlBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLotesFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpTesSelLotesControlBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLotesAS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpTesSelSolicitudPagoDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnActualiza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelComprobanteSolicitudesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOValidacionDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOReportesDataSet1)).BeginInit();
            this.SuspendLayout();
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
            this.barButtonItem3,
            this.btnCargar,
            this.barHeaderItem1,
            this.barEditItem1,
            this.barEditItem2,
            this.btnDescargar,
            this.btnCarpeta,
            this.btnAnularPago,
            this.btnDescargarC,
            this.barEditItem3});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 13;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemButtonEdit1,
            this.repositoryItemTextEdit2,
            this.repositoryItemDateEdit1});
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSalir),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnConfirmar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAnularPago),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCargar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDescargar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDescargarC),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCarpeta)});
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
            // btnConfirmar
            // 
            this.btnConfirmar.Caption = "Confirmar Pago";
            this.btnConfirmar.Id = 1;
            this.btnConfirmar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmar.ImageOptions.Image")));
            this.btnConfirmar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnConfirmar.ImageOptions.LargeImage")));
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnConfirmar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnConfirmar_ItemClick);
            // 
            // btnAnularPago
            // 
            this.btnAnularPago.Caption = "Anular Pago";
            this.btnAnularPago.Id = 9;
            this.btnAnularPago.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAnularPago.ImageOptions.Image")));
            this.btnAnularPago.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAnularPago.ImageOptions.LargeImage")));
            this.btnAnularPago.Name = "btnAnularPago";
            this.btnAnularPago.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnAnularPago.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAnularPago_ItemClick);
            // 
            // btnCargar
            // 
            this.btnCargar.Caption = "Cargar Archivo";
            this.btnCargar.Id = 3;
            this.btnCargar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCargar.ImageOptions.Image")));
            this.btnCargar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCargar.ImageOptions.LargeImage")));
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnCargar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btnDescargar
            // 
            this.btnDescargar.Caption = "Descarga Comprobantes";
            this.btnDescargar.Id = 7;
            this.btnDescargar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDescargar.ImageOptions.Image")));
            this.btnDescargar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDescargar.ImageOptions.LargeImage")));
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnDescargar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDescargar_ItemClick);
            // 
            // btnDescargarC
            // 
            this.btnDescargarC.Caption = "Descargar Control";
            this.btnDescargarC.Id = 10;
            this.btnDescargarC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDescargarC.ImageOptions.Image")));
            this.btnDescargarC.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDescargarC.ImageOptions.LargeImage")));
            this.btnDescargarC.Name = "btnDescargarC";
            this.btnDescargarC.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnDescargarC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDescargarC_ItemClick);
            // 
            // btnCarpeta
            // 
            this.btnCarpeta.Caption = "Carpeta de Descarga";
            this.btnCarpeta.Id = 8;
            this.btnCarpeta.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCarpeta.ImageOptions.Image")));
            this.btnCarpeta.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCarpeta.ImageOptions.LargeImage")));
            this.btnCarpeta.Name = "btnCarpeta";
            this.btnCarpeta.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnCarpeta.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCarpeta_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(956, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 348);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(956, 0);
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
            this.barDockControlRight.Location = new System.Drawing.Point(956, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 324);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem3";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barHeaderItem1
            // 
            this.barHeaderItem1.Id = 4;
            this.barHeaderItem1.Name = "barHeaderItem1";
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "barEditItem1";
            this.barEditItem1.Edit = this.repositoryItemTextEdit1;
            this.barEditItem1.Id = 5;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // barEditItem2
            // 
            this.barEditItem2.Edit = this.repositoryItemButtonEdit1;
            this.barEditItem2.Id = 6;
            this.barEditItem2.Name = "barEditItem2";
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            // 
            // barEditItem3
            // 
            this.barEditItem3.Caption = "barEditItem3";
            this.barEditItem3.Edit = this.repositoryItemTextEdit2;
            this.barEditItem3.Id = 11;
            this.barEditItem3.Name = "barEditItem3";
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
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
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.gridControl5);
            this.sidePanel1.Controls.Add(this.dtFechaPago);
            this.sidePanel1.Controls.Add(this.gridControl4);
            this.sidePanel1.Controls.Add(this.gridControl3);
            this.sidePanel1.Controls.Add(this.gridControl2);
            this.sidePanel1.Controls.Add(this.gridControl1);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidePanel1.Location = new System.Drawing.Point(0, 24);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(956, 324);
            this.sidePanel1.TabIndex = 4;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // gridControl5
            // 
            this.gridControl5.DataSource = this.stpTesSelSolicitudPagoDetailLayoutBindingSource1;
            this.gridControl5.Location = new System.Drawing.Point(323, 210);
            this.gridControl5.MainView = this.gridView1;
            this.gridControl5.MenuManager = this.barManager1;
            this.gridControl5.Name = "gridControl5";
            this.gridControl5.Size = new System.Drawing.Size(298, 100);
            this.gridControl5.TabIndex = 17;
            this.gridControl5.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl5.Visible = false;
            // 
            // stpTesSelSolicitudPagoDetailLayoutBindingSource1
            // 
            this.stpTesSelSolicitudPagoDetailLayoutBindingSource1.DataMember = "stpTesSelSolicitudPagoDetailLayout";
            this.stpTesSelSolicitudPagoDetailLayoutBindingSource1.DataSource = this.dbSAICAsimilados;
            // 
            // dbSAICAsimilados
            // 
            this.dbSAICAsimilados.DataSetName = "dbSAICAsimilados";
            this.dbSAICAsimilados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdSolicitudPagoDetail2,
            this.colIdSolicitudPago1,
            this.colIdCO1,
            this.colIdLoteCargaNomina3,
            this.colFolioLoteCargaNomina1,
            this.colIdTenedora2,
            this.colRazonSocial2,
            this.colIdBanco1,
            this.colNombreBanco1,
            this.colIdFormato1,
            this.colDescFormatoLayoutBanco1,
            this.colEmisora1,
            this.colTotal2,
            this.colFechaPago1,
            this.colTipo1,
            this.colIdEstatus2,
            this.colDescEstatus2,
            this.colIdOperador1,
            this.colNombreCompletoOperador1,
            this.colObservaciones1,
            this.colbFlagDescarga1,
            this.colNoEmpleados1,
            this.colLeyenda1});
            this.gridView1.GridControl = this.gridControl5;
            this.gridView1.Name = "gridView1";
            // 
            // colIdSolicitudPagoDetail2
            // 
            this.colIdSolicitudPagoDetail2.FieldName = "IdSolicitudPagoDetail";
            this.colIdSolicitudPagoDetail2.Name = "colIdSolicitudPagoDetail2";
            this.colIdSolicitudPagoDetail2.Visible = true;
            this.colIdSolicitudPagoDetail2.VisibleIndex = 0;
            // 
            // colIdSolicitudPago1
            // 
            this.colIdSolicitudPago1.FieldName = "IdSolicitudPago";
            this.colIdSolicitudPago1.Name = "colIdSolicitudPago1";
            this.colIdSolicitudPago1.Visible = true;
            this.colIdSolicitudPago1.VisibleIndex = 1;
            // 
            // colIdCO1
            // 
            this.colIdCO1.FieldName = "IdCO";
            this.colIdCO1.Name = "colIdCO1";
            this.colIdCO1.Visible = true;
            this.colIdCO1.VisibleIndex = 2;
            // 
            // colIdLoteCargaNomina3
            // 
            this.colIdLoteCargaNomina3.FieldName = "IdLoteCargaNomina";
            this.colIdLoteCargaNomina3.Name = "colIdLoteCargaNomina3";
            this.colIdLoteCargaNomina3.Visible = true;
            this.colIdLoteCargaNomina3.VisibleIndex = 3;
            // 
            // colFolioLoteCargaNomina1
            // 
            this.colFolioLoteCargaNomina1.FieldName = "FolioLoteCargaNomina";
            this.colFolioLoteCargaNomina1.Name = "colFolioLoteCargaNomina1";
            this.colFolioLoteCargaNomina1.Visible = true;
            this.colFolioLoteCargaNomina1.VisibleIndex = 4;
            // 
            // colIdTenedora2
            // 
            this.colIdTenedora2.FieldName = "IdTenedora";
            this.colIdTenedora2.Name = "colIdTenedora2";
            this.colIdTenedora2.Visible = true;
            this.colIdTenedora2.VisibleIndex = 5;
            // 
            // colRazonSocial2
            // 
            this.colRazonSocial2.FieldName = "RazonSocial";
            this.colRazonSocial2.Name = "colRazonSocial2";
            this.colRazonSocial2.Visible = true;
            this.colRazonSocial2.VisibleIndex = 6;
            // 
            // colIdBanco1
            // 
            this.colIdBanco1.FieldName = "IdBanco";
            this.colIdBanco1.Name = "colIdBanco1";
            this.colIdBanco1.Visible = true;
            this.colIdBanco1.VisibleIndex = 7;
            // 
            // colNombreBanco1
            // 
            this.colNombreBanco1.FieldName = "NombreBanco";
            this.colNombreBanco1.Name = "colNombreBanco1";
            this.colNombreBanco1.Visible = true;
            this.colNombreBanco1.VisibleIndex = 8;
            // 
            // colIdFormato1
            // 
            this.colIdFormato1.FieldName = "IdFormato";
            this.colIdFormato1.Name = "colIdFormato1";
            this.colIdFormato1.Visible = true;
            this.colIdFormato1.VisibleIndex = 9;
            // 
            // colDescFormatoLayoutBanco1
            // 
            this.colDescFormatoLayoutBanco1.FieldName = "DescFormatoLayoutBanco";
            this.colDescFormatoLayoutBanco1.Name = "colDescFormatoLayoutBanco1";
            this.colDescFormatoLayoutBanco1.Visible = true;
            this.colDescFormatoLayoutBanco1.VisibleIndex = 10;
            // 
            // colEmisora1
            // 
            this.colEmisora1.FieldName = "Emisora";
            this.colEmisora1.Name = "colEmisora1";
            this.colEmisora1.Visible = true;
            this.colEmisora1.VisibleIndex = 11;
            // 
            // colTotal2
            // 
            this.colTotal2.FieldName = "Total";
            this.colTotal2.Name = "colTotal2";
            this.colTotal2.Visible = true;
            this.colTotal2.VisibleIndex = 12;
            // 
            // colFechaPago1
            // 
            this.colFechaPago1.FieldName = "FechaPago";
            this.colFechaPago1.Name = "colFechaPago1";
            this.colFechaPago1.Visible = true;
            this.colFechaPago1.VisibleIndex = 13;
            // 
            // colTipo1
            // 
            this.colTipo1.FieldName = "Tipo";
            this.colTipo1.Name = "colTipo1";
            this.colTipo1.Visible = true;
            this.colTipo1.VisibleIndex = 14;
            // 
            // colIdEstatus2
            // 
            this.colIdEstatus2.FieldName = "IdEstatus";
            this.colIdEstatus2.Name = "colIdEstatus2";
            this.colIdEstatus2.Visible = true;
            this.colIdEstatus2.VisibleIndex = 15;
            // 
            // colDescEstatus2
            // 
            this.colDescEstatus2.FieldName = "DescEstatus";
            this.colDescEstatus2.Name = "colDescEstatus2";
            this.colDescEstatus2.Visible = true;
            this.colDescEstatus2.VisibleIndex = 16;
            // 
            // colIdOperador1
            // 
            this.colIdOperador1.FieldName = "IdOperador";
            this.colIdOperador1.Name = "colIdOperador1";
            this.colIdOperador1.Visible = true;
            this.colIdOperador1.VisibleIndex = 17;
            // 
            // colNombreCompletoOperador1
            // 
            this.colNombreCompletoOperador1.FieldName = "NombreCompletoOperador";
            this.colNombreCompletoOperador1.Name = "colNombreCompletoOperador1";
            this.colNombreCompletoOperador1.Visible = true;
            this.colNombreCompletoOperador1.VisibleIndex = 18;
            // 
            // colObservaciones1
            // 
            this.colObservaciones1.FieldName = "Observaciones";
            this.colObservaciones1.Name = "colObservaciones1";
            this.colObservaciones1.Visible = true;
            this.colObservaciones1.VisibleIndex = 19;
            // 
            // colbFlagDescarga1
            // 
            this.colbFlagDescarga1.FieldName = "bFlagDescarga";
            this.colbFlagDescarga1.Name = "colbFlagDescarga1";
            this.colbFlagDescarga1.Visible = true;
            this.colbFlagDescarga1.VisibleIndex = 20;
            // 
            // colNoEmpleados1
            // 
            this.colNoEmpleados1.FieldName = "NoEmpleados";
            this.colNoEmpleados1.Name = "colNoEmpleados1";
            this.colNoEmpleados1.Visible = true;
            this.colNoEmpleados1.VisibleIndex = 21;
            // 
            // colLeyenda1
            // 
            this.colLeyenda1.FieldName = "Leyenda";
            this.colLeyenda1.Name = "colLeyenda1";
            this.colLeyenda1.Visible = true;
            this.colLeyenda1.VisibleIndex = 22;
            // 
            // dtFechaPago
            // 
            this.dtFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaPago.Location = new System.Drawing.Point(428, 276);
            this.dtFechaPago.Name = "dtFechaPago";
            this.dtFechaPago.Size = new System.Drawing.Size(92, 21);
            this.dtFechaPago.TabIndex = 16;
            this.dtFechaPago.Visible = false;
            // 
            // gridControl4
            // 
            this.gridControl4.DataSource = this.stpTesSelSolicitudPagoDetailLayoutBindingSource;
            this.gridControl4.Location = new System.Drawing.Point(323, 94);
            this.gridControl4.MainView = this.dgvDetailSolicitud;
            this.gridControl4.MenuManager = this.barManager1;
            this.gridControl4.Name = "gridControl4";
            this.gridControl4.Size = new System.Drawing.Size(298, 110);
            this.gridControl4.TabIndex = 3;
            this.gridControl4.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvDetailSolicitud});
            this.gridControl4.Visible = false;
            // 
            // stpTesSelSolicitudPagoDetailLayoutBindingSource
            // 
            this.stpTesSelSolicitudPagoDetailLayoutBindingSource.DataMember = "stpTesSelSolicitudPagoDetailLayout";
            this.stpTesSelSolicitudPagoDetailLayoutBindingSource.DataSource = this.dbSAICBPOTesoreriaDataSet;
            // 
            // dbSAICBPOTesoreriaDataSet
            // 
            this.dbSAICBPOTesoreriaDataSet.DataSetName = "dbSAICBPOTesoreriaDataSet";
            this.dbSAICBPOTesoreriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvDetailSolicitud
            // 
            this.dgvDetailSolicitud.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdSolicitudPagoDetail1,
            this.colIdSolicitudPago,
            this.colIdCO,
            this.colIdLoteCargaNomina2,
            this.colFolioLoteCargaNomina,
            this.colIdTenedora1,
            this.colRazonSocial1,
            this.colIdBanco,
            this.colNombreBanco,
            this.colIdFormato,
            this.colDescFormatoLayoutBanco,
            this.colEmisora,
            this.colTotal1,
            this.colFechaPago,
            this.colTipo,
            this.colIdEstatus1,
            this.colDescEstatus1,
            this.colIdOperador,
            this.colNombreCompletoOperador,
            this.colObservaciones,
            this.colbFlagDescarga,
            this.colNoEmpleados,
            this.colLeyenda});
            this.dgvDetailSolicitud.GridControl = this.gridControl4;
            this.dgvDetailSolicitud.Name = "dgvDetailSolicitud";
            // 
            // colIdSolicitudPagoDetail1
            // 
            this.colIdSolicitudPagoDetail1.FieldName = "IdSolicitudPagoDetail";
            this.colIdSolicitudPagoDetail1.Name = "colIdSolicitudPagoDetail1";
            this.colIdSolicitudPagoDetail1.Visible = true;
            this.colIdSolicitudPagoDetail1.VisibleIndex = 0;
            // 
            // colIdSolicitudPago
            // 
            this.colIdSolicitudPago.FieldName = "IdSolicitudPago";
            this.colIdSolicitudPago.Name = "colIdSolicitudPago";
            this.colIdSolicitudPago.Visible = true;
            this.colIdSolicitudPago.VisibleIndex = 1;
            // 
            // colIdCO
            // 
            this.colIdCO.FieldName = "IdCO";
            this.colIdCO.Name = "colIdCO";
            this.colIdCO.Visible = true;
            this.colIdCO.VisibleIndex = 2;
            // 
            // colIdLoteCargaNomina2
            // 
            this.colIdLoteCargaNomina2.FieldName = "IdLoteCargaNomina";
            this.colIdLoteCargaNomina2.Name = "colIdLoteCargaNomina2";
            this.colIdLoteCargaNomina2.Visible = true;
            this.colIdLoteCargaNomina2.VisibleIndex = 3;
            // 
            // colFolioLoteCargaNomina
            // 
            this.colFolioLoteCargaNomina.FieldName = "FolioLoteCargaNomina";
            this.colFolioLoteCargaNomina.Name = "colFolioLoteCargaNomina";
            this.colFolioLoteCargaNomina.Visible = true;
            this.colFolioLoteCargaNomina.VisibleIndex = 4;
            // 
            // colIdTenedora1
            // 
            this.colIdTenedora1.FieldName = "IdTenedora";
            this.colIdTenedora1.Name = "colIdTenedora1";
            this.colIdTenedora1.Visible = true;
            this.colIdTenedora1.VisibleIndex = 5;
            // 
            // colRazonSocial1
            // 
            this.colRazonSocial1.FieldName = "RazonSocial";
            this.colRazonSocial1.Name = "colRazonSocial1";
            this.colRazonSocial1.Visible = true;
            this.colRazonSocial1.VisibleIndex = 6;
            // 
            // colIdBanco
            // 
            this.colIdBanco.FieldName = "IdBanco";
            this.colIdBanco.Name = "colIdBanco";
            this.colIdBanco.Visible = true;
            this.colIdBanco.VisibleIndex = 7;
            // 
            // colNombreBanco
            // 
            this.colNombreBanco.FieldName = "NombreBanco";
            this.colNombreBanco.Name = "colNombreBanco";
            this.colNombreBanco.Visible = true;
            this.colNombreBanco.VisibleIndex = 8;
            // 
            // colIdFormato
            // 
            this.colIdFormato.FieldName = "IdFormato";
            this.colIdFormato.Name = "colIdFormato";
            this.colIdFormato.Visible = true;
            this.colIdFormato.VisibleIndex = 9;
            // 
            // colDescFormatoLayoutBanco
            // 
            this.colDescFormatoLayoutBanco.FieldName = "DescFormatoLayoutBanco";
            this.colDescFormatoLayoutBanco.Name = "colDescFormatoLayoutBanco";
            this.colDescFormatoLayoutBanco.Visible = true;
            this.colDescFormatoLayoutBanco.VisibleIndex = 10;
            // 
            // colEmisora
            // 
            this.colEmisora.FieldName = "Emisora";
            this.colEmisora.Name = "colEmisora";
            this.colEmisora.Visible = true;
            this.colEmisora.VisibleIndex = 11;
            // 
            // colTotal1
            // 
            this.colTotal1.FieldName = "Total";
            this.colTotal1.Name = "colTotal1";
            this.colTotal1.Visible = true;
            this.colTotal1.VisibleIndex = 12;
            // 
            // colFechaPago
            // 
            this.colFechaPago.FieldName = "FechaPago";
            this.colFechaPago.Name = "colFechaPago";
            this.colFechaPago.Visible = true;
            this.colFechaPago.VisibleIndex = 13;
            // 
            // colTipo
            // 
            this.colTipo.FieldName = "Tipo";
            this.colTipo.Name = "colTipo";
            this.colTipo.Visible = true;
            this.colTipo.VisibleIndex = 14;
            // 
            // colIdEstatus1
            // 
            this.colIdEstatus1.FieldName = "IdEstatus";
            this.colIdEstatus1.Name = "colIdEstatus1";
            this.colIdEstatus1.Visible = true;
            this.colIdEstatus1.VisibleIndex = 15;
            // 
            // colDescEstatus1
            // 
            this.colDescEstatus1.FieldName = "DescEstatus";
            this.colDescEstatus1.Name = "colDescEstatus1";
            this.colDescEstatus1.Visible = true;
            this.colDescEstatus1.VisibleIndex = 16;
            // 
            // colIdOperador
            // 
            this.colIdOperador.FieldName = "IdOperador";
            this.colIdOperador.Name = "colIdOperador";
            this.colIdOperador.Visible = true;
            this.colIdOperador.VisibleIndex = 17;
            // 
            // colNombreCompletoOperador
            // 
            this.colNombreCompletoOperador.FieldName = "NombreCompletoOperador";
            this.colNombreCompletoOperador.Name = "colNombreCompletoOperador";
            this.colNombreCompletoOperador.Visible = true;
            this.colNombreCompletoOperador.VisibleIndex = 18;
            // 
            // colObservaciones
            // 
            this.colObservaciones.FieldName = "Observaciones";
            this.colObservaciones.Name = "colObservaciones";
            this.colObservaciones.Visible = true;
            this.colObservaciones.VisibleIndex = 19;
            // 
            // colbFlagDescarga
            // 
            this.colbFlagDescarga.FieldName = "bFlagDescarga";
            this.colbFlagDescarga.Name = "colbFlagDescarga";
            this.colbFlagDescarga.Visible = true;
            this.colbFlagDescarga.VisibleIndex = 20;
            // 
            // colNoEmpleados
            // 
            this.colNoEmpleados.FieldName = "NoEmpleados";
            this.colNoEmpleados.Name = "colNoEmpleados";
            this.colNoEmpleados.Visible = true;
            this.colNoEmpleados.VisibleIndex = 21;
            // 
            // colLeyenda
            // 
            this.colLeyenda.FieldName = "Leyenda";
            this.colLeyenda.Name = "colLeyenda";
            this.colLeyenda.Visible = true;
            this.colLeyenda.VisibleIndex = 22;
            // 
            // gridControl3
            // 
            this.gridControl3.DataSource = this.stpTesSelFacturasControlBindingSource;
            this.gridControl3.Location = new System.Drawing.Point(12, 210);
            this.gridControl3.MainView = this.dgvLotesFac;
            this.gridControl3.MenuManager = this.barManager1;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.Size = new System.Drawing.Size(305, 100);
            this.gridControl3.TabIndex = 2;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvLotesFac});
            this.gridControl3.Visible = false;
            // 
            // stpTesSelFacturasControlBindingSource
            // 
            this.stpTesSelFacturasControlBindingSource.DataMember = "stpTesSelFacturasControl";
            this.stpTesSelFacturasControlBindingSource.DataSource = this.dbSAICBPOFactura;
            // 
            // dbSAICBPOFactura
            // 
            this.dbSAICBPOFactura.DataSetName = "dbSAICBPOFactura";
            this.dbSAICBPOFactura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvLotesFac
            // 
            this.dgvLotesFac.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdHEaderFactura});
            this.dgvLotesFac.GridControl = this.gridControl3;
            this.dgvLotesFac.Name = "dgvLotesFac";
            // 
            // colIdHEaderFactura
            // 
            this.colIdHEaderFactura.FieldName = "IdHEaderFactura";
            this.colIdHEaderFactura.Name = "colIdHEaderFactura";
            this.colIdHEaderFactura.Visible = true;
            this.colIdHEaderFactura.VisibleIndex = 0;
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.stpTesSelLotesControlBindingSource;
            this.gridControl2.Location = new System.Drawing.Point(12, 94);
            this.gridControl2.MainView = this.dgvLotesAS;
            this.gridControl2.MenuManager = this.barManager1;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(305, 110);
            this.gridControl2.TabIndex = 1;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvLotesAS});
            this.gridControl2.Visible = false;
            // 
            // stpTesSelLotesControlBindingSource
            // 
            this.stpTesSelLotesControlBindingSource.DataMember = "stpTesSelLotesControl";
            this.stpTesSelLotesControlBindingSource.DataSource = this.dbSAICAsimilados;
            // 
            // dgvLotesAS
            // 
            this.dgvLotesAS.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdLoteCargaNomina1});
            this.dgvLotesAS.GridControl = this.gridControl2;
            this.dgvLotesAS.Name = "dgvLotesAS";
            // 
            // colIdLoteCargaNomina1
            // 
            this.colIdLoteCargaNomina1.FieldName = "IdLoteCargaNomina";
            this.colIdLoteCargaNomina1.Name = "colIdLoteCargaNomina1";
            this.colIdLoteCargaNomina1.Visible = true;
            this.colIdLoteCargaNomina1.VisibleIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.stpTesSelSolicitudPagoDetailBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.dgvSolicitudDetail;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnActualiza});
            this.gridControl1.Size = new System.Drawing.Size(956, 324);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvSolicitudDetail});
            // 
            // stpTesSelSolicitudPagoDetailBindingSource
            // 
            this.stpTesSelSolicitudPagoDetailBindingSource.DataMember = "stpTesSelSolicitudPagoDetail";
            this.stpTesSelSolicitudPagoDetailBindingSource.DataSource = this.dbSAICBPOFactura;
            // 
            // dgvSolicitudDetail
            // 
            this.dgvSolicitudDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdSolicitudPagoDetail,
            this.colIdProducto,
            this.colDescProducto,
            this.colIdTenedora,
            this.colRazonSocial,
            this.colTotal,
            this.colIdEstatus,
            this.colDescEstatus,
            this.colFechaConfirmaPago,
            this.colUsuarioConfirmaPago,
            this.colFechaAltaArchivo,
            this.colUsuarioAltaArchivo,
            this.colBandera,
            this.colUsuarioCancelarPago,
            this.colFechaCancelarPago,
            this.colIdLoteCargaNomina,
            this.colActualizar});
            this.dgvSolicitudDetail.GridControl = this.gridControl1;
            this.dgvSolicitudDetail.Name = "dgvSolicitudDetail";
            this.dgvSolicitudDetail.OptionsBehavior.Editable = false;
            this.dgvSolicitudDetail.OptionsSelection.MultiSelect = true;
            this.dgvSolicitudDetail.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.dgvSolicitudDetail.OptionsView.ColumnAutoWidth = false;
            this.dgvSolicitudDetail.OptionsView.ShowGroupPanel = false;
            // 
            // colIdSolicitudPagoDetail
            // 
            this.colIdSolicitudPagoDetail.Caption = "Id";
            this.colIdSolicitudPagoDetail.FieldName = "IdSolicitudPagoDetail";
            this.colIdSolicitudPagoDetail.Name = "colIdSolicitudPagoDetail";
            this.colIdSolicitudPagoDetail.Visible = true;
            this.colIdSolicitudPagoDetail.VisibleIndex = 1;
            this.colIdSolicitudPagoDetail.Width = 43;
            // 
            // colIdProducto
            // 
            this.colIdProducto.FieldName = "IdProducto";
            this.colIdProducto.Name = "colIdProducto";
            // 
            // colDescProducto
            // 
            this.colDescProducto.Caption = "Producto";
            this.colDescProducto.FieldName = "DescProducto";
            this.colDescProducto.Name = "colDescProducto";
            this.colDescProducto.Visible = true;
            this.colDescProducto.VisibleIndex = 2;
            this.colDescProducto.Width = 91;
            // 
            // colIdTenedora
            // 
            this.colIdTenedora.FieldName = "IdTenedora";
            this.colIdTenedora.Name = "colIdTenedora";
            // 
            // colRazonSocial
            // 
            this.colRazonSocial.Caption = "Empresa";
            this.colRazonSocial.FieldName = "RazonSocial";
            this.colRazonSocial.Name = "colRazonSocial";
            this.colRazonSocial.Visible = true;
            this.colRazonSocial.VisibleIndex = 3;
            this.colRazonSocial.Width = 164;
            // 
            // colTotal
            // 
            this.colTotal.DisplayFormat.FormatString = "N2";
            this.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotal.FieldName = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 5;
            this.colTotal.Width = 70;
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
            this.colDescEstatus.VisibleIndex = 6;
            this.colDescEstatus.Width = 61;
            // 
            // colFechaConfirmaPago
            // 
            this.colFechaConfirmaPago.Caption = "Fecha Pago";
            this.colFechaConfirmaPago.DisplayFormat.FormatString = "dd-MM-yyyy H:mm:ss";
            this.colFechaConfirmaPago.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colFechaConfirmaPago.FieldName = "FechaConfirmaPago";
            this.colFechaConfirmaPago.Name = "colFechaConfirmaPago";
            this.colFechaConfirmaPago.Visible = true;
            this.colFechaConfirmaPago.VisibleIndex = 7;
            this.colFechaConfirmaPago.Width = 104;
            // 
            // colUsuarioConfirmaPago
            // 
            this.colUsuarioConfirmaPago.Caption = "Usuario Pago";
            this.colUsuarioConfirmaPago.FieldName = "UsuarioConfirmaPago";
            this.colUsuarioConfirmaPago.Name = "colUsuarioConfirmaPago";
            this.colUsuarioConfirmaPago.Visible = true;
            this.colUsuarioConfirmaPago.VisibleIndex = 8;
            this.colUsuarioConfirmaPago.Width = 76;
            // 
            // colFechaAltaArchivo
            // 
            this.colFechaAltaArchivo.Caption = "Fecha Archivo";
            this.colFechaAltaArchivo.DisplayFormat.FormatString = "dd-MM-yyyy H:mm:ss";
            this.colFechaAltaArchivo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colFechaAltaArchivo.FieldName = "FechaAltaArchivo";
            this.colFechaAltaArchivo.Name = "colFechaAltaArchivo";
            this.colFechaAltaArchivo.Visible = true;
            this.colFechaAltaArchivo.VisibleIndex = 9;
            this.colFechaAltaArchivo.Width = 90;
            // 
            // colUsuarioAltaArchivo
            // 
            this.colUsuarioAltaArchivo.Caption = "Usuario Archivo";
            this.colUsuarioAltaArchivo.FieldName = "UsuarioAltaArchivo";
            this.colUsuarioAltaArchivo.Name = "colUsuarioAltaArchivo";
            this.colUsuarioAltaArchivo.Visible = true;
            this.colUsuarioAltaArchivo.VisibleIndex = 10;
            this.colUsuarioAltaArchivo.Width = 92;
            // 
            // colBandera
            // 
            this.colBandera.Caption = "Archivos";
            this.colBandera.FieldName = "FlagArchivo";
            this.colBandera.Name = "colBandera";
            this.colBandera.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.colBandera.Visible = true;
            this.colBandera.VisibleIndex = 11;
            // 
            // colUsuarioCancelarPago
            // 
            this.colUsuarioCancelarPago.Caption = "Usuario Cancelación Pago";
            this.colUsuarioCancelarPago.FieldName = "UsuarioCancelarPago";
            this.colUsuarioCancelarPago.Name = "colUsuarioCancelarPago";
            this.colUsuarioCancelarPago.Visible = true;
            this.colUsuarioCancelarPago.VisibleIndex = 12;
            this.colUsuarioCancelarPago.Width = 126;
            // 
            // colFechaCancelarPago
            // 
            this.colFechaCancelarPago.Caption = "Fecha Cancelación Pago";
            this.colFechaCancelarPago.DisplayFormat.FormatString = "dd-MM-yyyy H:mm:ss";
            this.colFechaCancelarPago.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colFechaCancelarPago.FieldName = "FechaCancelarPago";
            this.colFechaCancelarPago.Name = "colFechaCancelarPago";
            this.colFechaCancelarPago.Visible = true;
            this.colFechaCancelarPago.VisibleIndex = 13;
            this.colFechaCancelarPago.Width = 127;
            // 
            // colIdLoteCargaNomina
            // 
            this.colIdLoteCargaNomina.Caption = "Lote";
            this.colIdLoteCargaNomina.FieldName = "IdLoteCargaNomina";
            this.colIdLoteCargaNomina.Name = "colIdLoteCargaNomina";
            this.colIdLoteCargaNomina.Visible = true;
            this.colIdLoteCargaNomina.VisibleIndex = 4;
            this.colIdLoteCargaNomina.Width = 70;
            // 
            // colActualizar
            // 
            this.colActualizar.Caption = "Banco Origen";
            this.colActualizar.ColumnEdit = this.btnActualiza;
            this.colActualizar.Name = "colActualizar";
            // 
            // btnActualiza
            // 
            this.btnActualiza.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnActualiza.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnActualiza.Name = "btnActualiza";
            this.btnActualiza.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnActualiza.Click += new System.EventHandler(this.btnActualiza_Click);
            // 
            // stpFactSelComprobanteSolicitudesBindingSource
            // 
            this.stpFactSelComprobanteSolicitudesBindingSource.DataMember = "stpFactSelComprobanteSolicitudes";
            this.stpFactSelComprobanteSolicitudesBindingSource.DataSource = this.dbSAICBPOFactura;
            // 
            // stpTesSelSolicitudPagoDetailTableAdapter
            // 
            this.stpTesSelSolicitudPagoDetailTableAdapter.ClearBeforeFill = true;
            // 
            // dbSAICBPOValidacionDataSet1
            // 
            this.dbSAICBPOValidacionDataSet1.DataSetName = "dbSAICBPOValidacionDataSet";
            this.dbSAICBPOValidacionDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // splashSMCargando
            // 
            this.splashSMCargando.ClosingDelay = 500;
            // 
            // stpFactSelComprobanteSolicitudesTableAdapter
            // 
            this.stpFactSelComprobanteSolicitudesTableAdapter.ClearBeforeFill = true;
            // 
            // stpFactSelDerechosAccesoOperadorFacturacionTableAdapter1
            // 
            this.stpFactSelDerechosAccesoOperadorFacturacionTableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelParametroTableAdapter1
            // 
            this.stpSelParametroTableAdapter1.ClearBeforeFill = true;
            // 
            // stpFactSelComprobantesFacturaTableAdapter1
            // 
            this.stpFactSelComprobantesFacturaTableAdapter1.ClearBeforeFill = true;
            // 
            // stpTesSelLotesControlTableAdapter
            // 
            this.stpTesSelLotesControlTableAdapter.ClearBeforeFill = true;
            // 
            // stpTesSelFacturasControlTableAdapter
            // 
            this.stpTesSelFacturasControlTableAdapter.ClearBeforeFill = true;
            // 
            // stpTesSelSolicitudPagoDetailLayoutTableAdapter
            // 
            this.stpTesSelSolicitudPagoDetailLayoutTableAdapter.ClearBeforeFill = true;
            // 
            // stpSelInfoBancoCuentasLayoutTableAdapter1
            // 
            this.stpSelInfoBancoCuentasLayoutTableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelLayoutBanamexTEFC05TableAdapter1
            // 
            this.stpSelLayoutBanamexTEFC05TableAdapter1.ClearBeforeFill = true;
            // 
            // dbSAICBPOReportesDataSet1
            // 
            this.dbSAICBPOReportesDataSet1.DataSetName = "dbSAICBPOReportesDataSet";
            this.dbSAICBPOReportesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stpSelLayoutBanamexTEFC12TableAdapter1
            // 
            this.stpSelLayoutBanamexTEFC12TableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelLayoutBanamexTEFD05TableAdapter1
            // 
            this.stpSelLayoutBanamexTEFD05TableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelLayoutBanamexTEFD12TableAdapter1
            // 
            this.stpSelLayoutBanamexTEFD12TableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelLayoutBancomer99TableAdapter1
            // 
            this.stpSelLayoutBancomer99TableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelLayoutBancomer98TableAdapter1
            // 
            this.stpSelLayoutBancomer98TableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelLayoutBanorte2016TableAdapter1
            // 
            this.stpSelLayoutBanorte2016TableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelLayoutBanorteInterbancario2016TableAdapter1
            // 
            this.stpSelLayoutBanorteInterbancario2016TableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelLayoutBanorteInterbancarioTableAdapter1
            // 
            this.stpSelLayoutBanorteInterbancarioTableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelLayoutBanorteTableAdapter1
            // 
            this.stpSelLayoutBanorteTableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelLayoutSantanderTableAdapter1
            // 
            this.stpSelLayoutSantanderTableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelLayoutCIBancoTableAdapter1
            // 
            this.stpSelLayoutCIBancoTableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelLayoutHSBCOtrasCuentasTableAdapter1
            // 
            this.stpSelLayoutHSBCOtrasCuentasTableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelLayoutHSBCSPEITableAdapter1
            // 
            this.stpSelLayoutHSBCSPEITableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelLayoutHSBCNominasTableAdapter1
            // 
            this.stpSelLayoutHSBCNominasTableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelLayoutHSBCNETNominasTableAdapter1
            // 
            this.stpSelLayoutHSBCNETNominasTableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelLayoutInbursaSPEITableAdapter1
            // 
            this.stpSelLayoutInbursaSPEITableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelLayOutBancariosTableAdapter1
            // 
            this.stpSelLayOutBancariosTableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelLayoutKuspitBanPay_InterbancariosProvTableAdapter1
            // 
            this.stpSelLayoutKuspitBanPay_InterbancariosProvTableAdapter1.ClearBeforeFill = true;
            // 
            // stpTesSelSolicitudPagoDetailLayoutTableAdapter1
            // 
            this.stpTesSelSolicitudPagoDetailLayoutTableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelLayoutBanamexTEFC05_IASTableAdapter1
            // 
            this.stpSelLayoutBanamexTEFC05_IASTableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelLayoutBanamexTEFC12_IASTableAdapter1
            // 
            this.stpSelLayoutBanamexTEFC12_IASTableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelLayoutBanamexTEFD05_IASTableAdapter1
            // 
            this.stpSelLayoutBanamexTEFD05_IASTableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelLayoutBanamexTEFD12_IASTableAdapter1
            // 
            this.stpSelLayoutBanamexTEFD12_IASTableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelLayoutBancomer99_IASTableAdapter1
            // 
            this.stpSelLayoutBancomer99_IASTableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelLayoutBancomer98_IASTableAdapter1
            // 
            this.stpSelLayoutBancomer98_IASTableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelLayoutBanorte_IASTableAdapter1
            // 
            this.stpSelLayoutBanorte_IASTableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelLayoutBanorteInterbancario_IASTableAdapter1
            // 
            this.stpSelLayoutBanorteInterbancario_IASTableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelLayoutSantander_IASTableAdapter1
            // 
            this.stpSelLayoutSantander_IASTableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelLayoutCIBanco_IASTableAdapter1
            // 
            this.stpSelLayoutCIBanco_IASTableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelLayoutHSBCOtrasCuentas_IASTableAdapter1
            // 
            this.stpSelLayoutHSBCOtrasCuentas_IASTableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelLayoutHSBCSPEI_IASTableAdapter1
            // 
            this.stpSelLayoutHSBCSPEI_IASTableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelLayoutHSBCNominas_IASTableAdapter1
            // 
            this.stpSelLayoutHSBCNominas_IASTableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelLayoutHSBCNETNominas_IASTableAdapter1
            // 
            this.stpSelLayoutHSBCNETNominas_IASTableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelLayoutInbursaSPEI_IASTableAdapter1
            // 
            this.stpSelLayoutInbursaSPEI_IASTableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelLayoutBanorte2016_IASTableAdapter1
            // 
            this.stpSelLayoutBanorte2016_IASTableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelLayoutBanorteInterbancario2016_IASTableAdapter1
            // 
            this.stpSelLayoutBanorteInterbancario2016_IASTableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelLayOutBancarios_IASTableAdapter1
            // 
            this.stpSelLayOutBancarios_IASTableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelLayoutKuspitBanPay_InterbancariosProv_IASTableAdapter1
            // 
            this.stpSelLayoutKuspitBanPay_InterbancariosProv_IASTableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelInfoBancoCuentasLayout_IASTableAdapter1
            // 
            this.stpSelInfoBancoCuentasLayout_IASTableAdapter1.ClearBeforeFill = true;
            // 
            // frmxSolicitudesPagoDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 348);
            this.ControlBox = false;
            this.Controls.Add(this.sidePanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmxSolicitudesPagoDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle de Solicitudes Pago";
            this.Load += new System.EventHandler(this.frmxSolicitudesPagoDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpTesSelSolicitudPagoDetailLayoutBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICAsimilados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpTesSelSolicitudPagoDetailLayoutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOTesoreriaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailSolicitud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpTesSelFacturasControlBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLotesFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpTesSelLotesControlBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLotesAS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpTesSelSolicitudPagoDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnActualiza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelComprobanteSolicitudesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOValidacionDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOReportesDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnSalir;
        private DevExpress.XtraBars.BarButtonItem btnConfirmar;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private Facturas.dbSAICBPOFacturaTableAdapters.spSoloRespuesta spSoloRespuesta1;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvSolicitudDetail;
        private System.Windows.Forms.BindingSource stpTesSelSolicitudPagoDetailBindingSource;
        private Facturas.dbSAICBPOFactura dbSAICBPOFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSolicitudPagoDetail;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colDescProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTenedora;
        private DevExpress.XtraGrid.Columns.GridColumn colRazonSocial;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstatus;
        private DevExpress.XtraGrid.Columns.GridColumn colDescEstatus;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaConfirmaPago;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioConfirmaPago;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaAltaArchivo;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioAltaArchivo;
        private Facturas.dbSAICBPOFacturaTableAdapters.stpTesSelSolicitudPagoDetailTableAdapter stpTesSelSolicitudPagoDetailTableAdapter;
        private DevExpress.XtraBars.BarButtonItem btnCargar;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraBars.BarEditItem barEditItem2;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private dbSAICBPOValidacionDataSet dbSAICBPOValidacionDataSet1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashSMCargando;
        private DevExpress.XtraBars.BarButtonItem btnDescargar;
        private DevExpress.XtraBars.BarButtonItem btnCarpeta;
        private Catalogos.dbSAICBPO_CatalogosValidacionDataSetTableAdapters.ValidacionesGeneralTableAdapter validacionesGeneralTableAdapter1;
        private System.Windows.Forms.BindingSource stpFactSelComprobanteSolicitudesBindingSource;
        private Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelComprobanteSolicitudesTableAdapter stpFactSelComprobanteSolicitudesTableAdapter;
        private Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelDerechosAccesoOperadorFacturacionTableAdapter stpFactSelDerechosAccesoOperadorFacturacionTableAdapter1;
        private dbSAICBPOValidacionDataSetTableAdapters.stpSelParametroTableAdapter stpSelParametroTableAdapter1;
        private DevExpress.XtraGrid.Columns.GridColumn colBandera;
        private DevExpress.XtraBars.BarButtonItem btnAnularPago;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioCancelarPago;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaCancelarPago;
        private DevExpress.XtraGrid.Columns.GridColumn colIdLoteCargaNomina;
        private DevExpress.XtraBars.BarButtonItem btnDescargarC;
        private Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelComprobantesFacturaTableAdapter stpFactSelComprobantesFacturaTableAdapter1;
        private DevExpress.XtraGrid.GridControl gridControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvLotesFac;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private System.Windows.Forms.BindingSource stpTesSelLotesControlBindingSource;
        private Asimilados.dbSAICAsimilados dbSAICAsimilados;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvLotesAS;
        private DevExpress.XtraGrid.Columns.GridColumn colIdLoteCargaNomina1;
        private Asimilados.dbSAICAsimiladosTableAdapters.stpTesSelLotesControlTableAdapter stpTesSelLotesControlTableAdapter;
        private System.Windows.Forms.BindingSource stpTesSelFacturasControlBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdHEaderFactura;
        private Facturas.dbSAICBPOFacturaTableAdapters.stpTesSelFacturasControlTableAdapter stpTesSelFacturasControlTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colActualizar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnActualiza;
        private DevExpress.XtraGrid.GridControl gridControl4;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvDetailSolicitud;
        private System.Windows.Forms.BindingSource stpTesSelSolicitudPagoDetailLayoutBindingSource;
        private Tesoreria.dbSAICBPOTesoreriaDataSet dbSAICBPOTesoreriaDataSet;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSolicitudPagoDetail1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSolicitudPago;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCO;
        private DevExpress.XtraGrid.Columns.GridColumn colIdLoteCargaNomina2;
        private DevExpress.XtraGrid.Columns.GridColumn colFolioLoteCargaNomina;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTenedora1;
        private DevExpress.XtraGrid.Columns.GridColumn colRazonSocial1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFormato;
        private DevExpress.XtraGrid.Columns.GridColumn colDescFormatoLayoutBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colEmisora;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal1;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaPago;
        private DevExpress.XtraGrid.Columns.GridColumn colTipo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstatus1;
        private DevExpress.XtraGrid.Columns.GridColumn colDescEstatus1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdOperador;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreCompletoOperador;
        private DevExpress.XtraGrid.Columns.GridColumn colObservaciones;
        private DevExpress.XtraGrid.Columns.GridColumn colbFlagDescarga;
        private DevExpress.XtraGrid.Columns.GridColumn colNoEmpleados;
        private DevExpress.XtraGrid.Columns.GridColumn colLeyenda;
        private Tesoreria.dbSAICBPOTesoreriaDataSetTableAdapters.stpTesSelSolicitudPagoDetailLayoutTableAdapter stpTesSelSolicitudPagoDetailLayoutTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraBars.BarEditItem barEditItem3;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private dbSAICBPOValidacionDataSetTableAdapters.stpSelInfoBancoCuentasLayoutTableAdapter stpSelInfoBancoCuentasLayoutTableAdapter1;
        private dbSAICBPOReportesDataSetTableAdapters.stpSelLayoutBanamexTEFC05TableAdapter stpSelLayoutBanamexTEFC05TableAdapter1;
        private dbSAICBPOReportesDataSet dbSAICBPOReportesDataSet1;
        private dbSAICBPOReportesDataSetTableAdapters.stpSelLayoutBanamexTEFC12TableAdapter stpSelLayoutBanamexTEFC12TableAdapter1;
        private dbSAICBPOReportesDataSetTableAdapters.stpSelLayoutBanamexTEFD05TableAdapter stpSelLayoutBanamexTEFD05TableAdapter1;
        private dbSAICBPOReportesDataSetTableAdapters.stpSelLayoutBanamexTEFD12TableAdapter stpSelLayoutBanamexTEFD12TableAdapter1;
        private dbSAICBPOReportesDataSetTableAdapters.stpSelLayoutBancomer99TableAdapter stpSelLayoutBancomer99TableAdapter1;
        private dbSAICBPOReportesDataSetTableAdapters.stpSelLayoutBancomer98TableAdapter stpSelLayoutBancomer98TableAdapter1;
        private dbSAICBPOReportesDataSetTableAdapters.stpSelLayoutBanorte2016TableAdapter stpSelLayoutBanorte2016TableAdapter1;
        private dbSAICBPOReportesDataSetTableAdapters.stpSelLayoutBanorteInterbancario2016TableAdapter stpSelLayoutBanorteInterbancario2016TableAdapter1;
        private dbSAICBPOReportesDataSetTableAdapters.stpSelLayoutBanorteInterbancarioTableAdapter stpSelLayoutBanorteInterbancarioTableAdapter1;
        private dbSAICBPOReportesDataSetTableAdapters.stpSelLayoutBanorteTableAdapter stpSelLayoutBanorteTableAdapter1;
        private dbSAICBPOReportesDataSetTableAdapters.stpSelLayoutSantanderTableAdapter stpSelLayoutSantanderTableAdapter1;
        private dbSAICBPOReportesDataSetTableAdapters.stpSelLayoutCIBancoTableAdapter stpSelLayoutCIBancoTableAdapter1;
        private dbSAICBPOReportesDataSetTableAdapters.stpSelLayoutHSBCOtrasCuentasTableAdapter stpSelLayoutHSBCOtrasCuentasTableAdapter1;
        private dbSAICBPOReportesDataSetTableAdapters.stpSelLayoutHSBCSPEITableAdapter stpSelLayoutHSBCSPEITableAdapter1;
        private dbSAICBPOReportesDataSetTableAdapters.stpSelLayoutHSBCNominasTableAdapter stpSelLayoutHSBCNominasTableAdapter1;
        private dbSAICBPOReportesDataSetTableAdapters.stpSelLayoutHSBCNETNominasTableAdapter stpSelLayoutHSBCNETNominasTableAdapter1;
        private dbSAICBPOReportesDataSetTableAdapters.stpSelLayoutInbursaSPEITableAdapter stpSelLayoutInbursaSPEITableAdapter1;
        private dbSAICBPOReportesDataSetTableAdapters.stpSelLayOutBancariosTableAdapter stpSelLayOutBancariosTableAdapter1;
        private Facturas.dbSAICBPOFacturaTableAdapters.stpSelLayoutKuspitBanPay_InterbancariosProvTableAdapter stpSelLayoutKuspitBanPay_InterbancariosProvTableAdapter1;
        private System.Windows.Forms.DateTimePicker dtFechaPago;
        private DevExpress.XtraGrid.GridControl gridControl5;
        private System.Windows.Forms.BindingSource stpTesSelSolicitudPagoDetailLayoutBindingSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSolicitudPagoDetail2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSolicitudPago1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCO1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdLoteCargaNomina3;
        private DevExpress.XtraGrid.Columns.GridColumn colFolioLoteCargaNomina1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTenedora2;
        private DevExpress.XtraGrid.Columns.GridColumn colRazonSocial2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBanco1;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreBanco1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFormato1;
        private DevExpress.XtraGrid.Columns.GridColumn colDescFormatoLayoutBanco1;
        private DevExpress.XtraGrid.Columns.GridColumn colEmisora1;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal2;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaPago1;
        private DevExpress.XtraGrid.Columns.GridColumn colTipo1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstatus2;
        private DevExpress.XtraGrid.Columns.GridColumn colDescEstatus2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdOperador1;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreCompletoOperador1;
        private DevExpress.XtraGrid.Columns.GridColumn colObservaciones1;
        private DevExpress.XtraGrid.Columns.GridColumn colbFlagDescarga1;
        private DevExpress.XtraGrid.Columns.GridColumn colNoEmpleados1;
        private DevExpress.XtraGrid.Columns.GridColumn colLeyenda1;
        private Asimilados.dbSAICAsimiladosTableAdapters.stpTesSelSolicitudPagoDetailLayoutTableAdapter stpTesSelSolicitudPagoDetailLayoutTableAdapter1;
        private Asimilados.dbSAICAsimiladosTableAdapters.stpSelLayoutBanamexTEFC05_IASTableAdapter stpSelLayoutBanamexTEFC05_IASTableAdapter1;
        private Asimilados.dbSAICAsimiladosTableAdapters.stpSelLayoutBanamexTEFC12_IASTableAdapter stpSelLayoutBanamexTEFC12_IASTableAdapter1;
        private Asimilados.dbSAICAsimiladosTableAdapters.stpSelLayoutBanamexTEFD05_IASTableAdapter stpSelLayoutBanamexTEFD05_IASTableAdapter1;
        private Asimilados.dbSAICAsimiladosTableAdapters.stpSelLayoutBanamexTEFD12_IASTableAdapter stpSelLayoutBanamexTEFD12_IASTableAdapter1;
        private Asimilados.dbSAICAsimiladosTableAdapters.stpSelLayoutBancomer99_IASTableAdapter stpSelLayoutBancomer99_IASTableAdapter1;
        private Asimilados.dbSAICAsimiladosTableAdapters.stpSelLayoutBancomer98_IASTableAdapter stpSelLayoutBancomer98_IASTableAdapter1;
        private Asimilados.dbSAICAsimiladosTableAdapters.stpSelLayoutBanorte_IASTableAdapter stpSelLayoutBanorte_IASTableAdapter1;
        private Asimilados.dbSAICAsimiladosTableAdapters.stpSelLayoutBanorteInterbancario_IASTableAdapter stpSelLayoutBanorteInterbancario_IASTableAdapter1;
        private Asimilados.dbSAICAsimiladosTableAdapters.stpSelLayoutSantander_IASTableAdapter stpSelLayoutSantander_IASTableAdapter1;
        private Asimilados.dbSAICAsimiladosTableAdapters.stpSelLayoutCIBanco_IASTableAdapter stpSelLayoutCIBanco_IASTableAdapter1;
        private Asimilados.dbSAICAsimiladosTableAdapters.stpSelLayoutHSBCOtrasCuentas_IASTableAdapter stpSelLayoutHSBCOtrasCuentas_IASTableAdapter1;
        private Asimilados.dbSAICAsimiladosTableAdapters.stpSelLayoutHSBCSPEI_IASTableAdapter stpSelLayoutHSBCSPEI_IASTableAdapter1;
        private Asimilados.dbSAICAsimiladosTableAdapters.stpSelLayoutHSBCNominas_IASTableAdapter stpSelLayoutHSBCNominas_IASTableAdapter1;
        private Asimilados.dbSAICAsimiladosTableAdapters.stpSelLayoutHSBCNETNominas_IASTableAdapter stpSelLayoutHSBCNETNominas_IASTableAdapter1;
        private Asimilados.dbSAICAsimiladosTableAdapters.stpSelLayoutInbursaSPEI_IASTableAdapter stpSelLayoutInbursaSPEI_IASTableAdapter1;
        private Asimilados.dbSAICAsimiladosTableAdapters.stpSelLayoutBanorte2016_IASTableAdapter stpSelLayoutBanorte2016_IASTableAdapter1;
        private Asimilados.dbSAICAsimiladosTableAdapters.stpSelLayoutBanorteInterbancario2016_IASTableAdapter stpSelLayoutBanorteInterbancario2016_IASTableAdapter1;
        private Asimilados.dbSAICAsimiladosTableAdapters.stpSelLayOutBancarios_IASTableAdapter stpSelLayOutBancarios_IASTableAdapter1;
        private Asimilados.dbSAICAsimiladosTableAdapters.stpSelLayoutKuspitBanPay_InterbancariosProv_IASTableAdapter stpSelLayoutKuspitBanPay_InterbancariosProv_IASTableAdapter1;
        private Asimilados.dbSAICAsimiladosTableAdapters.stpSelInfoBancoCuentasLayout_IASTableAdapter stpSelInfoBancoCuentasLayout_IASTableAdapter1;
    }
}