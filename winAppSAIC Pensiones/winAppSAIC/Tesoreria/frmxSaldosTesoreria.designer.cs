namespace winAppSAIC.Tesoreria
{
    partial class frmxSaldosTesoreria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmxSaldosTesoreria));
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.Edita = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cboTenedoraEditar = new DevExpress.XtraEditors.GridLookUpEdit();
            this.stpSelMatrizTenedoraEdoCtaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPOTesoreriaDataSet = new winAppSAIC.Tesoreria.dbSAICBPOTesoreriaDataSet();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboBancoEditar = new DevExpress.XtraEditors.GridLookUpEdit();
            this.stpSelCtaBcoMatrizTenedoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnConsultarEdicion = new DevExpress.XtraEditors.SimpleButton();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.gdEdicion = new DevExpress.XtraGrid.GridControl();
            this.stpSelTenedoraLibroDiarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPOTesoreriaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grMovimientos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCONSECUTIVO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFECHA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMOVIMIENTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCHEQUE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn29 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFACTURA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOPERADOR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCONTROL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINGRESO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEGRESO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOBSERVACIONES = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colESTATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTESORERO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.spiEgresoEd = new DevExpress.XtraEditors.SpinEdit();
            this.spiIngresoEd = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.cbCteProvEd = new DevExpress.XtraEditors.GridLookUpEdit();
            this.vwTesClienteProveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPODataSet1 = new winAppSAIC.dbSAICBPODataSet();
            this.gridView7 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cbEstatus = new DevExpress.XtraEditors.GridLookUpEdit();
            this.vwCatEstatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cbConcepEd = new DevExpress.XtraEditors.GridLookUpEdit();
            this.vwCatTesConceptoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtIdEd = new System.Windows.Forms.TextBox();
            this.labelControl25 = new DevExpress.XtraEditors.LabelControl();
            this.btnGuardarEd = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl24 = new DevExpress.XtraEditors.LabelControl();
            this.txtConsEd = new System.Windows.Forms.TextBox();
            this.labelControl23 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.dtFechaEd = new DevExpress.XtraEditors.DateEdit();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.txtObservacionesEd = new System.Windows.Forms.TextBox();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.txtControlEd = new System.Windows.Forms.TextBox();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.txtChequeEd = new System.Windows.Forms.TextBox();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.TxtFacturaEd = new System.Windows.Forms.TextBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtLoteEd = new System.Windows.Forms.TextBox();
            this.lblFolio = new DevExpress.XtraEditors.LabelControl();
            this.Carga = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.gpoSeleccionNvo = new System.Windows.Forms.GroupBox();
            this.glEsquemaNvo = new DevExpress.XtraEditors.GridLookUpEdit();
            this.stpSelEsquemaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.spinSaldoInicialNvo = new DevExpress.XtraEditors.SpinEdit();
            this.gridLookTenedoraNvo = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdMatrizTenedora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMatrizTenedora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRFC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridLookTenedoraCuentasNvo = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCuentaBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreCuentaBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoCuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoCLABE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dateSaldoNvo = new DevExpress.XtraEditors.DateEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.gpoSeleccion = new System.Windows.Forms.GroupBox();
            this.chkActSaldos = new DevExpress.XtraEditors.CheckEdit();
            this.rdbComplemento = new System.Windows.Forms.RadioButton();
            this.rdbNuevo = new System.Windows.Forms.RadioButton();
            this.txtNombreArchivoExcel = new DevExpress.XtraEditors.TextEdit();
            this.btnActualizar = new DevExpress.XtraEditors.SimpleButton();
            this.gpoSeleccionCmoss = new System.Windows.Forms.GroupBox();
            this.TxtCuentaBancoCmto = new DevExpress.XtraEditors.TextEdit();
            this.spinSaldoInicialCmto = new DevExpress.XtraEditors.SpinEdit();
            this.gridLookUpEdit1 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dateSaldoCmtos = new DevExpress.XtraEditors.DateEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.txtIdMatrizTenedoraCmos = new DevExpress.XtraEditors.TextEdit();
            this.txtTenedoraCuestasCmos = new DevExpress.XtraEditors.TextEdit();
            this.LdelTiempo = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.button1 = new System.Windows.Forms.Button();
            this.btnExpSalBancarioxDiaIng = new DevExpress.XtraEditors.SimpleButton();
            this.btnExpSalBancarioxDia = new DevExpress.XtraEditors.SimpleButton();
            this.btnExpSalBancario = new DevExpress.XtraEditors.SimpleButton();
            this.btnConsultaLT = new DevExpress.XtraEditors.SimpleButton();
            this.btnExpLineTiempo = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.spAnoCorte = new DevExpress.XtraEditors.SpinEdit();
            this.cboMesCorte = new DevExpress.XtraEditors.GridLookUpEdit();
            this.stpSelMesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView13 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdMes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescMes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblAno = new DevExpress.XtraEditors.LabelControl();
            this.lblMes = new DevExpress.XtraEditors.LabelControl();
            this.cmbTenedoraLT = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView8 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chkSelTenedoras = new DevExpress.XtraEditors.CheckEdit();
            this.lblTenedoraLT = new DevExpress.XtraEditors.LabelControl();
            this.gdCtrolSaldosBXDiaIngresos = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavMovimientos = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.gridLineaTiempo = new DevExpress.XtraGrid.GridControl();
            this.stpSelTenedoraLineaTiempovBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView9 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colESTRUCTURA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEMPRESA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCONSECUTIVO1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFECHA1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMOVIMIENTO1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCheque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnLote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFACTURA1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOPERADOR1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTESORERO_ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCONTROL1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINGRESO1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEGRESO1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOBSERVACIONES1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBANCO1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSALDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabNavSaldos = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.gridSaldosBancarios = new DevExpress.XtraGrid.GridControl();
            this.tesSaldosLTDBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView10 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBANBAJIO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBANCOMER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBANORTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHSBC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINBURSA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSANTANDER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSCOTIABANK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTOTAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabNavSaldosXDia = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.gdCtrolSaldosBXDia = new DevExpress.XtraGrid.GridControl();
            this.gridView11 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tabNavSaldosXDiaIng = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.gdCtrolSaldosBXDiaIng = new DevExpress.XtraGrid.GridControl();
            this.gridView12 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dbSAICBPOTesoreriaDataSet1 = new winAppSAIC.Tesoreria.dbSAICBPOTesoreriaDataSet();
            this.stpSelTenedoraLineaTiempoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tesSaldosLTDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stpSelSaldosBancariosFinalBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.stpSelSaldosBancariosFinalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPOTesoreriaDataSet2 = new winAppSAIC.Tesoreria.dbSAICBPOTesoreriaDataSet();
            this.stpSelMatrizTenedoraEdoCtaTableAdapter = new winAppSAIC.Tesoreria.dbSAICBPOTesoreriaDataSetTableAdapters.stpSelMatrizTenedoraEdoCtaTableAdapter();
            this.stpSelCtaBcoMatrizTenedoraTableAdapter = new winAppSAIC.Tesoreria.dbSAICBPOTesoreriaDataSetTableAdapters.stpSelCtaBcoMatrizTenedoraTableAdapter();
            this.splashScreenManager2 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::winAppSAIC.SplashDeCarga), true, true);
            this.respuestasTesoreria = new winAppSAIC.Tesoreria.dbSAICBPOTesoreriaDataSetTableAdapters.RespuestasTesoreria();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::winAppSAIC.SplashDeCarga), true, true);
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.stpSelEsquemaTableAdapter = new winAppSAIC.Tesoreria.dbSAICBPOTesoreriaDataSetTableAdapters.stpSelEsquemaTableAdapter();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.stpSelTenedoraLibroDiarioTableAdapter1 = new winAppSAIC.Tesoreria.dbSAICBPOTesoreriaDataSetTableAdapters.stpSelTenedoraLibroDiarioTableAdapter();
            this.vwCatTesConceptoTableAdapter1 = new winAppSAIC.dbSAICBPODataSetTableAdapters.vwCatTesConceptoTableAdapter();
            this.vwCatTesConceptoTableAdapter2 = new winAppSAIC.dbSAICBPODataSetTableAdapters.vwCatTesConceptoTableAdapter();
            this.vwCatEstatusTableAdapter1 = new winAppSAIC.dbSAICBPODataSetTableAdapters.vwCatEstatusTableAdapter();
            this.dbSAICBPODataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwTesClienteProveedorTableAdapter1 = new winAppSAIC.dbSAICBPODataSetTableAdapters.vwTesClienteProveedorTableAdapter();
            this.dbSAICBPODataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPO_CatalogosValidacionDataSet1 = new winAppSAIC.Catalogos.dbSAICBPO_CatalogosValidacionDataSet();
            this.stpSelSaldosBancariosFinalTableAdapter1 = new winAppSAIC.Tesoreria.dbSAICBPOTesoreriaDataSetTableAdapters.stpSelSaldosBancariosFinalTableAdapter();
            this.dbADNAPENSIONMX20240229DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stpSelSaldosBancariosFinalTableAdapter2 = new winAppSAIC.Tesoreria.dbSAICBPOTesoreriaDataSetTableAdapters.stpSelSaldosBancariosFinalTableAdapter();
            this.tableAdapterManager1 = new winAppSAIC.Tesoreria.dbSAICBPOTesoreriaDataSetTableAdapters.TableAdapterManager();
            this.tesSaldosLTDTableAdapter = new winAppSAIC.Tesoreria.dbSAICBPOTesoreriaDataSetTableAdapters.TesSaldosLTDTableAdapter();
            this.dbSAICAsimilados1 = new winAppSAIC.Asimilados.dbSAICAsimilados();
            this.stpSelSaldosBancariosAlCierreXDiaTableAdapter1 = new winAppSAIC.Tesoreria.dbSAICBPOTesoreriaDataSetTableAdapters.stpSelSaldosBancariosAlCierreXDiaTableAdapter();
            this.tesSaldosConceptoDiaMesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tesSaldosConceptoDiaMesTableAdapter = new winAppSAIC.Tesoreria.dbSAICBPOTesoreriaDataSetTableAdapters.TesSaldosConceptoDiaMesTableAdapter();
            this.stpSelMesTableAdapter1 = new winAppSAIC.dbSAICBPODataSetTableAdapters.stpSelMesTableAdapter();
            this.stpSelTenedoraLineaTiempovTableAdapter1 = new winAppSAIC.Tesoreria.dbSAICBPOTesoreriaDataSetTableAdapters.stpSelTenedoraLineaTiempovTableAdapter();
            this.dbSAICBPOActualizacionesDataSet = new winAppSAIC.dbSAICBPOActualizacionesDataSet();
            this.dbSAICBPOActualizacionesDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.Edita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboTenedoraEditar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelMatrizTenedoraEdoCtaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOTesoreriaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboBancoEditar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelCtaBcoMatrizTenedoraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdEdicion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelTenedoraLibroDiarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOTesoreriaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grMovimientos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spiEgresoEd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spiIngresoEd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCteProvEd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwTesClienteProveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPODataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEstatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCatEstatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbConcepEd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCatTesConceptoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaEd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaEd.Properties)).BeginInit();
            this.Carga.SuspendLayout();
            this.gpoSeleccionNvo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glEsquemaNvo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelEsquemaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSaldoInicialNvo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookTenedoraNvo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookTenedoraCuentasNvo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSaldoNvo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSaldoNvo.Properties)).BeginInit();
            this.gpoSeleccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkActSaldos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreArchivoExcel.Properties)).BeginInit();
            this.gpoSeleccionCmoss.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCuentaBancoCmto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSaldoInicialCmto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSaldoCmtos.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSaldoCmtos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdMatrizTenedoraCmos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenedoraCuestasCmos.Properties)).BeginInit();
            this.LdelTiempo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spAnoCorte.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMesCorte.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelMesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTenedoraLT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSelTenedoras.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdCtrolSaldosBXDiaIngresos)).BeginInit();
            this.gdCtrolSaldosBXDiaIngresos.SuspendLayout();
            this.tabNavMovimientos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLineaTiempo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelTenedoraLineaTiempovBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView9)).BeginInit();
            this.tabNavSaldos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSaldosBancarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tesSaldosLTDBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView10)).BeginInit();
            this.tabNavSaldosXDia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdCtrolSaldosBXDia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView11)).BeginInit();
            this.tabNavSaldosXDiaIng.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdCtrolSaldosBXDiaIng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOTesoreriaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelTenedoraLineaTiempoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tesSaldosLTDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelSaldosBancariosFinalBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelSaldosBancariosFinalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOTesoreriaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPODataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPODataSet1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPO_CatalogosValidacionDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbADNAPENSIONMX20240229DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICAsimilados1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tesSaldosConceptoDiaMesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOActualizacionesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOActualizacionesDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.Edita);
            this.tabPane1.Controls.Add(this.Carga);
            this.tabPane1.Controls.Add(this.LdelTiempo);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Location = new System.Drawing.Point(0, 32);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.Carga,
            this.Edita,
            this.LdelTiempo});
            this.tabPane1.RegularSize = new System.Drawing.Size(1460, 1018);
            this.tabPane1.SelectedPage = this.Carga;
            this.tabPane1.Size = new System.Drawing.Size(1460, 1018);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "tabPane1";
            this.tabPane1.SelectedPageChanged += new DevExpress.XtraBars.Navigation.SelectedPageChangedEventHandler(this.tabPane1_SelectedPageChanged);
            // 
            // Edita
            // 
            this.Edita.Caption = "Editar";
            this.Edita.Controls.Add(this.splitContainer1);
            this.Edita.Name = "Edita";
            this.Edita.Size = new System.Drawing.Size(1434, 950);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupControl1);
            this.splitContainer1.Panel1.Controls.Add(this.groupControl2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1434, 950);
            this.splitContainer1.SplitterDistance = 161;
            this.splitContainer1.TabIndex = 43;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cboTenedoraEditar);
            this.groupControl1.Controls.Add(this.cboBancoEditar);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Location = new System.Drawing.Point(28, 8);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(742, 128);
            this.groupControl1.TabIndex = 47;
            this.groupControl1.Text = "Filtros";
            // 
            // cboTenedoraEditar
            // 
            this.cboTenedoraEditar.EditValue = "vacio";
            this.cboTenedoraEditar.Location = new System.Drawing.Point(112, 48);
            this.cboTenedoraEditar.Margin = new System.Windows.Forms.Padding(4);
            this.cboTenedoraEditar.Name = "cboTenedoraEditar";
            this.cboTenedoraEditar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTenedoraEditar.Properties.DataSource = this.stpSelMatrizTenedoraEdoCtaBindingSource;
            this.cboTenedoraEditar.Properties.DisplayMember = "Matriz Tenedora";
            this.cboTenedoraEditar.Properties.ValueMember = "IdMatrizTenedora";
            this.cboTenedoraEditar.Properties.View = this.gridView4;
            this.cboTenedoraEditar.Size = new System.Drawing.Size(593, 26);
            this.cboTenedoraEditar.TabIndex = 1;
            this.cboTenedoraEditar.EditValueChanged += new System.EventHandler(this.cboTenedoraEditar_EditValueChanged);
            // 
            // stpSelMatrizTenedoraEdoCtaBindingSource
            // 
            this.stpSelMatrizTenedoraEdoCtaBindingSource.DataMember = "stpSelMatrizTenedoraEdoCta";
            this.stpSelMatrizTenedoraEdoCtaBindingSource.DataSource = this.dbSAICBPOTesoreriaDataSet;
            // 
            // dbSAICBPOTesoreriaDataSet
            // 
            this.dbSAICBPOTesoreriaDataSet.DataSetName = "dbSAICBPOTesoreriaDataSet";
            this.dbSAICBPOTesoreriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9});
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowAutoFilterRow = true;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn7
            // 
            this.gridColumn7.FieldName = "IdMatrizTenedora";
            this.gridColumn7.Name = "gridColumn7";
            // 
            // gridColumn8
            // 
            this.gridColumn8.FieldName = "Matriz Tenedora";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 0;
            // 
            // gridColumn9
            // 
            this.gridColumn9.FieldName = "RFC";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 1;
            // 
            // cboBancoEditar
            // 
            this.cboBancoEditar.EditValue = "vacio";
            this.cboBancoEditar.Location = new System.Drawing.Point(112, 82);
            this.cboBancoEditar.Margin = new System.Windows.Forms.Padding(4);
            this.cboBancoEditar.Name = "cboBancoEditar";
            this.cboBancoEditar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboBancoEditar.Properties.DataSource = this.stpSelCtaBcoMatrizTenedoraBindingSource;
            this.cboBancoEditar.Properties.DisplayMember = "NombreCuentaBanco";
            this.cboBancoEditar.Properties.ValueMember = "IdCuentaBanco";
            this.cboBancoEditar.Properties.View = this.gridView5;
            this.cboBancoEditar.Size = new System.Drawing.Size(593, 26);
            this.cboBancoEditar.TabIndex = 2;
            // 
            // stpSelCtaBcoMatrizTenedoraBindingSource
            // 
            this.stpSelCtaBcoMatrizTenedoraBindingSource.DataMember = "stpSelCtaBcoMatrizTenedora";
            this.stpSelCtaBcoMatrizTenedoraBindingSource.DataSource = this.dbSAICBPOTesoreriaDataSet;
            // 
            // gridView5
            // 
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn14});
            this.gridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView5.OptionsView.ShowAutoFilterRow = true;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn10
            // 
            this.gridColumn10.FieldName = "IdCuentaBanco";
            this.gridColumn10.Name = "gridColumn10";
            // 
            // gridColumn11
            // 
            this.gridColumn11.FieldName = "NombreCuentaBanco";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 0;
            // 
            // gridColumn12
            // 
            this.gridColumn12.FieldName = "Banco";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 1;
            // 
            // gridColumn13
            // 
            this.gridColumn13.FieldName = "NoCuenta";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 2;
            // 
            // gridColumn14
            // 
            this.gridColumn14.FieldName = "NoCLABE";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 3;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(38, 51);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(67, 19);
            this.labelControl7.TabIndex = 45;
            this.labelControl7.Text = "Tenedora";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(9, 85);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(96, 19);
            this.labelControl6.TabIndex = 44;
            this.labelControl6.Text = "Cuenta Banco";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnConsultarEdicion);
            this.groupControl2.Location = new System.Drawing.Point(778, 5);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(545, 128);
            this.groupControl2.TabIndex = 46;
            this.groupControl2.Text = "Acciones";
            // 
            // btnConsultarEdicion
            // 
            this.btnConsultarEdicion.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultarEdicion.ImageOptions.Image")));
            this.btnConsultarEdicion.Location = new System.Drawing.Point(38, 46);
            this.btnConsultarEdicion.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultarEdicion.Name = "btnConsultarEdicion";
            this.btnConsultarEdicion.Size = new System.Drawing.Size(222, 34);
            this.btnConsultarEdicion.TabIndex = 7;
            this.btnConsultarEdicion.Text = "Consultar";
            this.btnConsultarEdicion.Click += new System.EventHandler(this.btnConsultarEdicion_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.gdEdicion);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer2.Size = new System.Drawing.Size(1434, 785);
            this.splitContainer2.SplitterDistance = 637;
            this.splitContainer2.TabIndex = 0;
            // 
            // gdEdicion
            // 
            this.gdEdicion.DataSource = this.stpSelTenedoraLibroDiarioBindingSource;
            this.gdEdicion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdEdicion.Location = new System.Drawing.Point(0, 0);
            this.gdEdicion.MainView = this.grMovimientos;
            this.gdEdicion.Name = "gdEdicion";
            this.gdEdicion.Size = new System.Drawing.Size(1434, 637);
            this.gdEdicion.TabIndex = 6;
            this.gdEdicion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grMovimientos});
            // 
            // stpSelTenedoraLibroDiarioBindingSource
            // 
            this.stpSelTenedoraLibroDiarioBindingSource.DataMember = "stpSelTenedoraLibroDiario";
            this.stpSelTenedoraLibroDiarioBindingSource.DataSource = this.dbSAICBPOTesoreriaDataSetBindingSource;
            // 
            // dbSAICBPOTesoreriaDataSetBindingSource
            // 
            this.dbSAICBPOTesoreriaDataSetBindingSource.DataSource = this.dbSAICBPOTesoreriaDataSet;
            this.dbSAICBPOTesoreriaDataSetBindingSource.Position = 0;
            // 
            // grMovimientos
            // 
            this.grMovimientos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCONSECUTIVO,
            this.colFECHA,
            this.colMOVIMIENTO,
            this.colCHEQUE,
            this.colLOTE,
            this.gridColumn29,
            this.colFACTURA,
            this.colOPERADOR,
            this.colCONTROL,
            this.colINGRESO,
            this.colEGRESO,
            this.colOBSERVACIONES,
            this.colIdEstatus,
            this.colESTATUS,
            this.colTESORERO});
            this.grMovimientos.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.grMovimientos.GridControl = this.gdEdicion;
            this.grMovimientos.Name = "grMovimientos";
            this.grMovimientos.OptionsBehavior.Editable = false;
            this.grMovimientos.OptionsBehavior.ReadOnly = true;
            this.grMovimientos.OptionsView.ColumnAutoWidth = false;
            this.grMovimientos.OptionsView.ShowAutoFilterRow = true;
            this.grMovimientos.OptionsView.ShowGroupPanel = false;
            this.grMovimientos.DoubleClick += new System.EventHandler(this.grMovimientos_DoubleClick);
            // 
            // colCONSECUTIVO
            // 
            this.colCONSECUTIVO.FieldName = "CONSECUTIVO";
            this.colCONSECUTIVO.Name = "colCONSECUTIVO";
            this.colCONSECUTIVO.Visible = true;
            this.colCONSECUTIVO.VisibleIndex = 0;
            // 
            // colFECHA
            // 
            this.colFECHA.FieldName = "FECHA";
            this.colFECHA.Name = "colFECHA";
            this.colFECHA.Visible = true;
            this.colFECHA.VisibleIndex = 1;
            // 
            // colMOVIMIENTO
            // 
            this.colMOVIMIENTO.FieldName = "MOVIMIENTO";
            this.colMOVIMIENTO.Name = "colMOVIMIENTO";
            this.colMOVIMIENTO.Visible = true;
            this.colMOVIMIENTO.VisibleIndex = 2;
            // 
            // colCHEQUE
            // 
            this.colCHEQUE.FieldName = "CHEQUE";
            this.colCHEQUE.Name = "colCHEQUE";
            this.colCHEQUE.Visible = true;
            this.colCHEQUE.VisibleIndex = 3;
            // 
            // colLOTE
            // 
            this.colLOTE.FieldName = "LOTE";
            this.colLOTE.Name = "colLOTE";
            this.colLOTE.Visible = true;
            this.colLOTE.VisibleIndex = 4;
            // 
            // gridColumn29
            // 
            this.gridColumn29.FieldName = "CLIENTE / PROVEEDOR";
            this.gridColumn29.Name = "gridColumn29";
            this.gridColumn29.Visible = true;
            this.gridColumn29.VisibleIndex = 5;
            // 
            // colFACTURA
            // 
            this.colFACTURA.FieldName = "FACTURA";
            this.colFACTURA.Name = "colFACTURA";
            this.colFACTURA.Visible = true;
            this.colFACTURA.VisibleIndex = 6;
            // 
            // colOPERADOR
            // 
            this.colOPERADOR.FieldName = "OPERADOR";
            this.colOPERADOR.Name = "colOPERADOR";
            this.colOPERADOR.Visible = true;
            this.colOPERADOR.VisibleIndex = 7;
            // 
            // colCONTROL
            // 
            this.colCONTROL.FieldName = "CONTROL";
            this.colCONTROL.Name = "colCONTROL";
            this.colCONTROL.Visible = true;
            this.colCONTROL.VisibleIndex = 8;
            // 
            // colINGRESO
            // 
            this.colINGRESO.DisplayFormat.FormatString = "C2";
            this.colINGRESO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colINGRESO.FieldName = "INGRESO";
            this.colINGRESO.Name = "colINGRESO";
            this.colINGRESO.Visible = true;
            this.colINGRESO.VisibleIndex = 9;
            // 
            // colEGRESO
            // 
            this.colEGRESO.DisplayFormat.FormatString = "C2";
            this.colEGRESO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colEGRESO.FieldName = "EGRESO";
            this.colEGRESO.Name = "colEGRESO";
            this.colEGRESO.Visible = true;
            this.colEGRESO.VisibleIndex = 10;
            // 
            // colOBSERVACIONES
            // 
            this.colOBSERVACIONES.FieldName = "OBSERVACIONES";
            this.colOBSERVACIONES.Name = "colOBSERVACIONES";
            this.colOBSERVACIONES.Visible = true;
            this.colOBSERVACIONES.VisibleIndex = 11;
            // 
            // colIdEstatus
            // 
            this.colIdEstatus.FieldName = "IdEstatus";
            this.colIdEstatus.Name = "colIdEstatus";
            // 
            // colESTATUS
            // 
            this.colESTATUS.FieldName = "ESTATUS";
            this.colESTATUS.Name = "colESTATUS";
            this.colESTATUS.Visible = true;
            this.colESTATUS.VisibleIndex = 12;
            // 
            // colTESORERO
            // 
            this.colTESORERO.FieldName = "TESORERO";
            this.colTESORERO.Name = "colTESORERO";
            this.colTESORERO.Visible = true;
            this.colTESORERO.VisibleIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.spiEgresoEd);
            this.groupBox1.Controls.Add(this.spiIngresoEd);
            this.groupBox1.Controls.Add(this.labelControl13);
            this.groupBox1.Controls.Add(this.cbCteProvEd);
            this.groupBox1.Controls.Add(this.cbEstatus);
            this.groupBox1.Controls.Add(this.cbConcepEd);
            this.groupBox1.Controls.Add(this.txtIdEd);
            this.groupBox1.Controls.Add(this.labelControl25);
            this.groupBox1.Controls.Add(this.btnGuardarEd);
            this.groupBox1.Controls.Add(this.labelControl24);
            this.groupBox1.Controls.Add(this.txtConsEd);
            this.groupBox1.Controls.Add(this.labelControl23);
            this.groupBox1.Controls.Add(this.labelControl20);
            this.groupBox1.Controls.Add(this.dtFechaEd);
            this.groupBox1.Controls.Add(this.labelControl17);
            this.groupBox1.Controls.Add(this.txtObservacionesEd);
            this.groupBox1.Controls.Add(this.labelControl19);
            this.groupBox1.Controls.Add(this.labelControl16);
            this.groupBox1.Controls.Add(this.labelControl15);
            this.groupBox1.Controls.Add(this.txtControlEd);
            this.groupBox1.Controls.Add(this.labelControl14);
            this.groupBox1.Controls.Add(this.txtChequeEd);
            this.groupBox1.Controls.Add(this.labelControl18);
            this.groupBox1.Controls.Add(this.TxtFacturaEd);
            this.groupBox1.Controls.Add(this.labelControl8);
            this.groupBox1.Controls.Add(this.txtLoteEd);
            this.groupBox1.Controls.Add(this.lblFolio);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1331, 146);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editar";
            // 
            // spiEgresoEd
            // 
            this.spiEgresoEd.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spiEgresoEd.Enabled = false;
            this.spiEgresoEd.Location = new System.Drawing.Point(326, 108);
            this.spiEgresoEd.Name = "spiEgresoEd";
            this.spiEgresoEd.Properties.Appearance.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.spiEgresoEd.Properties.Appearance.Options.UseBackColor = true;
            this.spiEgresoEd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spiEgresoEd.Properties.EditFormat.FormatString = "C2";
            this.spiEgresoEd.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spiEgresoEd.Size = new System.Drawing.Size(158, 26);
            this.spiEgresoEd.TabIndex = 62;
            // 
            // spiIngresoEd
            // 
            this.spiIngresoEd.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spiIngresoEd.Enabled = false;
            this.spiIngresoEd.Location = new System.Drawing.Point(79, 109);
            this.spiIngresoEd.Name = "spiIngresoEd";
            this.spiIngresoEd.Properties.Appearance.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.spiIngresoEd.Properties.Appearance.Options.UseBackColor = true;
            this.spiIngresoEd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spiIngresoEd.Properties.EditFormat.FormatString = "C2";
            this.spiIngresoEd.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spiIngresoEd.Size = new System.Drawing.Size(165, 26);
            this.spiIngresoEd.TabIndex = 61;
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(254, 69);
            this.labelControl13.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(66, 19);
            this.labelControl13.TabIndex = 60;
            this.labelControl13.Text = "Cte/Prov.";
            // 
            // cbCteProvEd
            // 
            this.cbCteProvEd.EditValue = "";
            this.cbCteProvEd.Enabled = false;
            this.cbCteProvEd.Location = new System.Drawing.Point(326, 69);
            this.cbCteProvEd.Name = "cbCteProvEd";
            this.cbCteProvEd.Properties.Appearance.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.cbCteProvEd.Properties.Appearance.Options.UseBackColor = true;
            this.cbCteProvEd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbCteProvEd.Properties.DataSource = this.vwTesClienteProveedorBindingSource;
            this.cbCteProvEd.Properties.DisplayMember = "NombreClienteProveedor";
            this.cbCteProvEd.Properties.ValueMember = "NombreClienteProveedor";
            this.cbCteProvEd.Properties.View = this.gridView7;
            this.cbCteProvEd.Size = new System.Drawing.Size(489, 26);
            this.cbCteProvEd.TabIndex = 59;
            // 
            // vwTesClienteProveedorBindingSource
            // 
            this.vwTesClienteProveedorBindingSource.DataMember = "vwTesClienteProveedor";
            this.vwTesClienteProveedorBindingSource.DataSource = this.dbSAICBPODataSet1;
            // 
            // dbSAICBPODataSet1
            // 
            this.dbSAICBPODataSet1.DataSetName = "dbSAICBPODataSet";
            this.dbSAICBPODataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView7
            // 
            this.gridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView7.Name = "gridView7";
            this.gridView7.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView7.OptionsView.ShowGroupPanel = false;
            // 
            // cbEstatus
            // 
            this.cbEstatus.EditValue = "";
            this.cbEstatus.Enabled = false;
            this.cbEstatus.Location = new System.Drawing.Point(1049, 21);
            this.cbEstatus.Name = "cbEstatus";
            this.cbEstatus.Properties.Appearance.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.cbEstatus.Properties.Appearance.Options.UseBackColor = true;
            this.cbEstatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbEstatus.Properties.DataSource = this.vwCatEstatusBindingSource;
            this.cbEstatus.Properties.DisplayMember = "ESTATUS";
            this.cbEstatus.Properties.ValueMember = "IdEstatus";
            this.cbEstatus.Properties.View = this.gridView6;
            this.cbEstatus.Size = new System.Drawing.Size(136, 26);
            this.cbEstatus.TabIndex = 58;
            // 
            // vwCatEstatusBindingSource
            // 
            this.vwCatEstatusBindingSource.DataMember = "vwCatEstatus";
            this.vwCatEstatusBindingSource.DataSource = this.dbSAICBPODataSet1;
            // 
            // gridView6
            // 
            this.gridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView6.Name = "gridView6";
            this.gridView6.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView6.OptionsView.ShowGroupPanel = false;
            // 
            // cbConcepEd
            // 
            this.cbConcepEd.EditValue = "";
            this.cbConcepEd.Enabled = false;
            this.cbConcepEd.Location = new System.Drawing.Point(553, 25);
            this.cbConcepEd.Name = "cbConcepEd";
            this.cbConcepEd.Properties.Appearance.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.cbConcepEd.Properties.Appearance.Options.UseBackColor = true;
            this.cbConcepEd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbConcepEd.Properties.DataSource = this.vwCatTesConceptoBindingSource;
            this.cbConcepEd.Properties.DisplayMember = "Nombre concepto";
            this.cbConcepEd.Properties.ValueMember = "IdConcepto";
            this.cbConcepEd.Properties.View = this.gridView2;
            this.cbConcepEd.Size = new System.Drawing.Size(262, 26);
            this.cbConcepEd.TabIndex = 57;
            // 
            // vwCatTesConceptoBindingSource
            // 
            this.vwCatTesConceptoBindingSource.DataMember = "vwCatTesConcepto";
            this.vwCatTesConceptoBindingSource.DataSource = this.dbSAICBPODataSet1;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // txtIdEd
            // 
            this.txtIdEd.BackColor = System.Drawing.SystemColors.Info;
            this.txtIdEd.Enabled = false;
            this.txtIdEd.Location = new System.Drawing.Point(1257, 21);
            this.txtIdEd.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdEd.Name = "txtIdEd";
            this.txtIdEd.Size = new System.Drawing.Size(43, 27);
            this.txtIdEd.TabIndex = 56;
            this.txtIdEd.Visible = false;
            // 
            // labelControl25
            // 
            this.labelControl25.Location = new System.Drawing.Point(1229, 25);
            this.labelControl25.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl25.Name = "labelControl25";
            this.labelControl25.Size = new System.Drawing.Size(20, 19);
            this.labelControl25.TabIndex = 55;
            this.labelControl25.Text = "Id.";
            this.labelControl25.Visible = false;
            // 
            // btnGuardarEd
            // 
            this.btnGuardarEd.Enabled = false;
            this.btnGuardarEd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarEd.ImageOptions.Image")));
            this.btnGuardarEd.Location = new System.Drawing.Point(1210, 92);
            this.btnGuardarEd.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarEd.Name = "btnGuardarEd";
            this.btnGuardarEd.Size = new System.Drawing.Size(114, 43);
            this.btnGuardarEd.TabIndex = 21;
            this.btnGuardarEd.Text = "Guardar";
            this.btnGuardarEd.Click += new System.EventHandler(this.btnGuardarEd_Click);
            // 
            // labelControl24
            // 
            this.labelControl24.Location = new System.Drawing.Point(987, 22);
            this.labelControl24.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl24.Name = "labelControl24";
            this.labelControl24.Size = new System.Drawing.Size(55, 19);
            this.labelControl24.TabIndex = 54;
            this.labelControl24.Text = "Estatus.";
            // 
            // txtConsEd
            // 
            this.txtConsEd.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtConsEd.Enabled = false;
            this.txtConsEd.Location = new System.Drawing.Point(80, 22);
            this.txtConsEd.Margin = new System.Windows.Forms.Padding(4);
            this.txtConsEd.Name = "txtConsEd";
            this.txtConsEd.Size = new System.Drawing.Size(111, 27);
            this.txtConsEd.TabIndex = 10;
            // 
            // labelControl23
            // 
            this.labelControl23.Location = new System.Drawing.Point(20, 26);
            this.labelControl23.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl23.Name = "labelControl23";
            this.labelControl23.Size = new System.Drawing.Size(55, 19);
            this.labelControl23.TabIndex = 52;
            this.labelControl23.Text = "Consec.";
            // 
            // labelControl20
            // 
            this.labelControl20.Location = new System.Drawing.Point(275, 31);
            this.labelControl20.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(45, 19);
            this.labelControl20.TabIndex = 46;
            this.labelControl20.Text = "Fecha.";
            // 
            // dtFechaEd
            // 
            this.dtFechaEd.EditValue = null;
            this.dtFechaEd.Enabled = false;
            this.dtFechaEd.Location = new System.Drawing.Point(326, 26);
            this.dtFechaEd.Name = "dtFechaEd";
            this.dtFechaEd.Properties.Appearance.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.dtFechaEd.Properties.Appearance.Options.UseBackColor = true;
            this.dtFechaEd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaEd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaEd.Size = new System.Drawing.Size(123, 26);
            this.dtFechaEd.TabIndex = 11;
            // 
            // labelControl17
            // 
            this.labelControl17.Location = new System.Drawing.Point(475, 28);
            this.labelControl17.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(71, 19);
            this.labelControl17.TabIndex = 42;
            this.labelControl17.Text = "Concepto.";
            // 
            // txtObservacionesEd
            // 
            this.txtObservacionesEd.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtObservacionesEd.Enabled = false;
            this.txtObservacionesEd.Location = new System.Drawing.Point(553, 112);
            this.txtObservacionesEd.Margin = new System.Windows.Forms.Padding(4);
            this.txtObservacionesEd.Name = "txtObservacionesEd";
            this.txtObservacionesEd.Size = new System.Drawing.Size(632, 27);
            this.txtObservacionesEd.TabIndex = 19;
            // 
            // labelControl19
            // 
            this.labelControl19.Location = new System.Drawing.Point(491, 116);
            this.labelControl19.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(55, 19);
            this.labelControl19.TabIndex = 40;
            this.labelControl19.Text = "Observ.";
            // 
            // labelControl16
            // 
            this.labelControl16.Location = new System.Drawing.Point(13, 111);
            this.labelControl16.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(59, 19);
            this.labelControl16.TabIndex = 34;
            this.labelControl16.Text = "Ingreso.";
            // 
            // labelControl15
            // 
            this.labelControl15.Location = new System.Drawing.Point(267, 112);
            this.labelControl15.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(53, 19);
            this.labelControl15.TabIndex = 32;
            this.labelControl15.Text = "Egreso.";
            // 
            // txtControlEd
            // 
            this.txtControlEd.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtControlEd.Enabled = false;
            this.txtControlEd.Location = new System.Drawing.Point(1049, 65);
            this.txtControlEd.Margin = new System.Windows.Forms.Padding(4);
            this.txtControlEd.Name = "txtControlEd";
            this.txtControlEd.Size = new System.Drawing.Size(136, 27);
            this.txtControlEd.TabIndex = 16;
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(985, 67);
            this.labelControl14.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(57, 19);
            this.labelControl14.TabIndex = 30;
            this.labelControl14.Text = "Control.";
            // 
            // txtChequeEd
            // 
            this.txtChequeEd.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtChequeEd.Enabled = false;
            this.txtChequeEd.Location = new System.Drawing.Point(910, 19);
            this.txtChequeEd.Margin = new System.Windows.Forms.Padding(4);
            this.txtChequeEd.Name = "txtChequeEd";
            this.txtChequeEd.Size = new System.Drawing.Size(65, 27);
            this.txtChequeEd.TabIndex = 13;
            // 
            // labelControl18
            // 
            this.labelControl18.Location = new System.Drawing.Point(849, 67);
            this.labelControl18.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(56, 19);
            this.labelControl18.TabIndex = 28;
            this.labelControl18.Text = "Factura.";
            // 
            // TxtFacturaEd
            // 
            this.TxtFacturaEd.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.TxtFacturaEd.Enabled = false;
            this.TxtFacturaEd.Location = new System.Drawing.Point(910, 63);
            this.TxtFacturaEd.Margin = new System.Windows.Forms.Padding(4);
            this.TxtFacturaEd.Name = "TxtFacturaEd";
            this.TxtFacturaEd.Size = new System.Drawing.Size(65, 27);
            this.TxtFacturaEd.TabIndex = 15;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(37, 71);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(35, 19);
            this.labelControl8.TabIndex = 26;
            this.labelControl8.Text = "Lote.";
            // 
            // txtLoteEd
            // 
            this.txtLoteEd.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtLoteEd.Enabled = false;
            this.txtLoteEd.Location = new System.Drawing.Point(80, 65);
            this.txtLoteEd.Margin = new System.Windows.Forms.Padding(4);
            this.txtLoteEd.Name = "txtLoteEd";
            this.txtLoteEd.Size = new System.Drawing.Size(111, 27);
            this.txtLoteEd.TabIndex = 14;
            // 
            // lblFolio
            // 
            this.lblFolio.Location = new System.Drawing.Point(844, 23);
            this.lblFolio.Margin = new System.Windows.Forms.Padding(4);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(58, 19);
            this.lblFolio.TabIndex = 24;
            this.lblFolio.Text = "Cheque.";
            // 
            // Carga
            // 
            this.Carga.Caption = "Carga saldos iniciales";
            this.Carga.Controls.Add(this.gpoSeleccionNvo);
            this.Carga.Controls.Add(this.gpoSeleccion);
            this.Carga.Controls.Add(this.txtNombreArchivoExcel);
            this.Carga.Controls.Add(this.btnActualizar);
            this.Carga.Controls.Add(this.gpoSeleccionCmoss);
            this.Carga.Name = "Carga";
            this.Carga.Size = new System.Drawing.Size(1434, 950);
            // 
            // gpoSeleccionNvo
            // 
            this.gpoSeleccionNvo.Controls.Add(this.glEsquemaNvo);
            this.gpoSeleccionNvo.Controls.Add(this.labelControl5);
            this.gpoSeleccionNvo.Controls.Add(this.spinSaldoInicialNvo);
            this.gpoSeleccionNvo.Controls.Add(this.gridLookTenedoraNvo);
            this.gpoSeleccionNvo.Controls.Add(this.gridLookTenedoraCuentasNvo);
            this.gpoSeleccionNvo.Controls.Add(this.dateSaldoNvo);
            this.gpoSeleccionNvo.Controls.Add(this.labelControl4);
            this.gpoSeleccionNvo.Controls.Add(this.labelControl1);
            this.gpoSeleccionNvo.Controls.Add(this.labelControl2);
            this.gpoSeleccionNvo.Controls.Add(this.labelControl3);
            this.gpoSeleccionNvo.Location = new System.Drawing.Point(250, 10);
            this.gpoSeleccionNvo.Name = "gpoSeleccionNvo";
            this.gpoSeleccionNvo.Size = new System.Drawing.Size(759, 224);
            this.gpoSeleccionNvo.TabIndex = 34;
            this.gpoSeleccionNvo.TabStop = false;
            this.gpoSeleccionNvo.Text = "Selección";
            this.gpoSeleccionNvo.Enter += new System.EventHandler(this.gpoSeleccionNvo_Enter);
            // 
            // glEsquemaNvo
            // 
            this.glEsquemaNvo.EditValue = ".";
            this.glEsquemaNvo.Location = new System.Drawing.Point(124, 100);
            this.glEsquemaNvo.Name = "glEsquemaNvo";
            this.glEsquemaNvo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glEsquemaNvo.Properties.DataSource = this.stpSelEsquemaBindingSource;
            this.glEsquemaNvo.Properties.DisplayMember = "Esquema";
            this.glEsquemaNvo.Properties.ValueMember = "IdEsquema";
            this.glEsquemaNvo.Properties.View = this.gridLookUpEdit2View;
            this.glEsquemaNvo.Size = new System.Drawing.Size(592, 26);
            this.glEsquemaNvo.TabIndex = 21;
            this.glEsquemaNvo.EditValueChanged += new System.EventHandler(this.glEsquemaNvo_EditValueChanged);
            // 
            // stpSelEsquemaBindingSource
            // 
            this.stpSelEsquemaBindingSource.DataMember = "stpSelEsquema";
            this.stpSelEsquemaBindingSource.DataSource = this.dbSAICBPOTesoreriaDataSetBindingSource;
            // 
            // gridLookUpEdit2View
            // 
            this.gridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit2View.Name = "gridLookUpEdit2View";
            this.gridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(53, 103);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(63, 19);
            this.labelControl5.TabIndex = 30;
            this.labelControl5.Text = "Producto";
            // 
            // spinSaldoInicialNvo
            // 
            this.spinSaldoInicialNvo.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinSaldoInicialNvo.Location = new System.Drawing.Point(123, 165);
            this.spinSaldoInicialNvo.Name = "spinSaldoInicialNvo";
            this.spinSaldoInicialNvo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinSaldoInicialNvo.Properties.EditFormat.FormatString = "C2";
            this.spinSaldoInicialNvo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinSaldoInicialNvo.Size = new System.Drawing.Size(153, 26);
            this.spinSaldoInicialNvo.TabIndex = 23;
            // 
            // gridLookTenedoraNvo
            // 
            this.gridLookTenedoraNvo.EditValue = "vacio";
            this.gridLookTenedoraNvo.Location = new System.Drawing.Point(123, 32);
            this.gridLookTenedoraNvo.Margin = new System.Windows.Forms.Padding(4);
            this.gridLookTenedoraNvo.Name = "gridLookTenedoraNvo";
            this.gridLookTenedoraNvo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookTenedoraNvo.Properties.DataSource = this.stpSelMatrizTenedoraEdoCtaBindingSource;
            this.gridLookTenedoraNvo.Properties.DisplayMember = "Matriz Tenedora";
            this.gridLookTenedoraNvo.Properties.ValueMember = "IdMatrizTenedora";
            this.gridLookTenedoraNvo.Properties.View = this.gridLookUpEdit1View;
            this.gridLookTenedoraNvo.Size = new System.Drawing.Size(593, 26);
            this.gridLookTenedoraNvo.TabIndex = 19;
            this.gridLookTenedoraNvo.EditValueChanged += new System.EventHandler(this.gridLookTenedora_EditValueChanged);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdMatrizTenedora,
            this.colMatrizTenedora,
            this.colRFC});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdMatrizTenedora
            // 
            this.colIdMatrizTenedora.FieldName = "IdMatrizTenedora";
            this.colIdMatrizTenedora.Name = "colIdMatrizTenedora";
            // 
            // colMatrizTenedora
            // 
            this.colMatrizTenedora.FieldName = "Matriz Tenedora";
            this.colMatrizTenedora.Name = "colMatrizTenedora";
            this.colMatrizTenedora.Visible = true;
            this.colMatrizTenedora.VisibleIndex = 0;
            // 
            // colRFC
            // 
            this.colRFC.FieldName = "RFC";
            this.colRFC.Name = "colRFC";
            this.colRFC.Visible = true;
            this.colRFC.VisibleIndex = 1;
            // 
            // gridLookTenedoraCuentasNvo
            // 
            this.gridLookTenedoraCuentasNvo.EditValue = "vacio";
            this.gridLookTenedoraCuentasNvo.Location = new System.Drawing.Point(123, 66);
            this.gridLookTenedoraCuentasNvo.Margin = new System.Windows.Forms.Padding(4);
            this.gridLookTenedoraCuentasNvo.Name = "gridLookTenedoraCuentasNvo";
            this.gridLookTenedoraCuentasNvo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookTenedoraCuentasNvo.Properties.DataSource = this.stpSelCtaBcoMatrizTenedoraBindingSource;
            this.gridLookTenedoraCuentasNvo.Properties.DisplayMember = "NombreCuentaBanco";
            this.gridLookTenedoraCuentasNvo.Properties.ValueMember = "IdCuentaBanco";
            this.gridLookTenedoraCuentasNvo.Properties.View = this.gridView1;
            this.gridLookTenedoraCuentasNvo.Size = new System.Drawing.Size(593, 26);
            this.gridLookTenedoraCuentasNvo.TabIndex = 20;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCuentaBanco,
            this.colNombreCuentaBanco,
            this.colBanco,
            this.colNoCuenta,
            this.colNoCLABE});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIdCuentaBanco
            // 
            this.colIdCuentaBanco.FieldName = "IdCuentaBanco";
            this.colIdCuentaBanco.Name = "colIdCuentaBanco";
            // 
            // colNombreCuentaBanco
            // 
            this.colNombreCuentaBanco.FieldName = "NombreCuentaBanco";
            this.colNombreCuentaBanco.Name = "colNombreCuentaBanco";
            this.colNombreCuentaBanco.Visible = true;
            this.colNombreCuentaBanco.VisibleIndex = 0;
            // 
            // colBanco
            // 
            this.colBanco.FieldName = "Banco";
            this.colBanco.Name = "colBanco";
            this.colBanco.Visible = true;
            this.colBanco.VisibleIndex = 1;
            // 
            // colNoCuenta
            // 
            this.colNoCuenta.FieldName = "NoCuenta";
            this.colNoCuenta.Name = "colNoCuenta";
            this.colNoCuenta.Visible = true;
            this.colNoCuenta.VisibleIndex = 2;
            // 
            // colNoCLABE
            // 
            this.colNoCLABE.FieldName = "NoCLABE";
            this.colNoCLABE.Name = "colNoCLABE";
            this.colNoCLABE.Visible = true;
            this.colNoCLABE.VisibleIndex = 3;
            // 
            // dateSaldoNvo
            // 
            this.dateSaldoNvo.EditValue = null;
            this.dateSaldoNvo.Location = new System.Drawing.Point(123, 133);
            this.dateSaldoNvo.Name = "dateSaldoNvo";
            this.dateSaldoNvo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateSaldoNvo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateSaldoNvo.Size = new System.Drawing.Size(153, 26);
            this.dateSaldoNvo.TabIndex = 22;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(33, 168);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(84, 19);
            this.labelControl4.TabIndex = 28;
            this.labelControl4.Text = "Saldo inicial";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(77, 136);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 19);
            this.labelControl1.TabIndex = 22;
            this.labelControl1.Text = "Fecha";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(20, 69);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(96, 19);
            this.labelControl2.TabIndex = 24;
            this.labelControl2.Text = "Cuenta Banco";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(49, 35);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(67, 19);
            this.labelControl3.TabIndex = 25;
            this.labelControl3.Text = "Tenedora";
            // 
            // gpoSeleccion
            // 
            this.gpoSeleccion.Controls.Add(this.chkActSaldos);
            this.gpoSeleccion.Controls.Add(this.rdbComplemento);
            this.gpoSeleccion.Controls.Add(this.rdbNuevo);
            this.gpoSeleccion.Location = new System.Drawing.Point(18, 10);
            this.gpoSeleccion.Name = "gpoSeleccion";
            this.gpoSeleccion.Size = new System.Drawing.Size(210, 183);
            this.gpoSeleccion.TabIndex = 33;
            this.gpoSeleccion.TabStop = false;
            this.gpoSeleccion.Text = "Proceso";
            // 
            // chkActSaldos
            // 
            this.chkActSaldos.Location = new System.Drawing.Point(46, 154);
            this.chkActSaldos.Name = "chkActSaldos";
            this.chkActSaldos.Properties.Caption = "Act. Solo saldos";
            this.chkActSaldos.Size = new System.Drawing.Size(144, 23);
            this.chkActSaldos.TabIndex = 34;
            this.chkActSaldos.Visible = false;
            // 
            // rdbComplemento
            // 
            this.rdbComplemento.AutoSize = true;
            this.rdbComplemento.Location = new System.Drawing.Point(15, 113);
            this.rdbComplemento.Name = "rdbComplemento";
            this.rdbComplemento.Size = new System.Drawing.Size(133, 23);
            this.rdbComplemento.TabIndex = 33;
            this.rdbComplemento.Text = "Complemento";
            this.rdbComplemento.UseVisualStyleBackColor = true;
            this.rdbComplemento.Visible = false;
            // 
            // rdbNuevo
            // 
            this.rdbNuevo.AutoSize = true;
            this.rdbNuevo.Checked = true;
            this.rdbNuevo.Location = new System.Drawing.Point(15, 50);
            this.rdbNuevo.Name = "rdbNuevo";
            this.rdbNuevo.Size = new System.Drawing.Size(120, 23);
            this.rdbNuevo.TabIndex = 32;
            this.rdbNuevo.TabStop = true;
            this.rdbNuevo.Text = "Saldo Inicial";
            this.rdbNuevo.UseVisualStyleBackColor = true;
            this.rdbNuevo.CheckedChanged += new System.EventHandler(this.rdbNuevo_CheckedChanged);
            // 
            // txtNombreArchivoExcel
            // 
            this.txtNombreArchivoExcel.Enabled = false;
            this.txtNombreArchivoExcel.Location = new System.Drawing.Point(1405, 161);
            this.txtNombreArchivoExcel.Name = "txtNombreArchivoExcel";
            this.txtNombreArchivoExcel.Properties.Appearance.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtNombreArchivoExcel.Properties.Appearance.Options.UseBackColor = true;
            this.txtNombreArchivoExcel.Size = new System.Drawing.Size(80, 26);
            this.txtNombreArchivoExcel.TabIndex = 39;
            this.txtNombreArchivoExcel.Visible = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.ImageOptions.Image")));
            this.btnActualizar.Location = new System.Drawing.Point(1028, 22);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(152, 28);
            this.btnActualizar.TabIndex = 29;
            this.btnActualizar.Text = "Guarda Saldo";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // gpoSeleccionCmoss
            // 
            this.gpoSeleccionCmoss.Controls.Add(this.TxtCuentaBancoCmto);
            this.gpoSeleccionCmoss.Controls.Add(this.spinSaldoInicialCmto);
            this.gpoSeleccionCmoss.Controls.Add(this.gridLookUpEdit1);
            this.gpoSeleccionCmoss.Controls.Add(this.dateSaldoCmtos);
            this.gpoSeleccionCmoss.Controls.Add(this.labelControl9);
            this.gpoSeleccionCmoss.Controls.Add(this.labelControl10);
            this.gpoSeleccionCmoss.Controls.Add(this.labelControl11);
            this.gpoSeleccionCmoss.Controls.Add(this.labelControl12);
            this.gpoSeleccionCmoss.Controls.Add(this.txtIdMatrizTenedoraCmos);
            this.gpoSeleccionCmoss.Controls.Add(this.txtTenedoraCuestasCmos);
            this.gpoSeleccionCmoss.Location = new System.Drawing.Point(250, 10);
            this.gpoSeleccionCmoss.Name = "gpoSeleccionCmoss";
            this.gpoSeleccionCmoss.Size = new System.Drawing.Size(759, 183);
            this.gpoSeleccionCmoss.TabIndex = 29;
            this.gpoSeleccionCmoss.TabStop = false;
            this.gpoSeleccionCmoss.Text = "Selección";
            // 
            // TxtCuentaBancoCmto
            // 
            this.TxtCuentaBancoCmto.Enabled = false;
            this.TxtCuentaBancoCmto.Location = new System.Drawing.Point(123, 66);
            this.TxtCuentaBancoCmto.Name = "TxtCuentaBancoCmto";
            this.TxtCuentaBancoCmto.Properties.Appearance.BackColor = System.Drawing.Color.AntiqueWhite;
            this.TxtCuentaBancoCmto.Properties.Appearance.Options.UseBackColor = true;
            this.TxtCuentaBancoCmto.Size = new System.Drawing.Size(593, 26);
            this.TxtCuentaBancoCmto.TabIndex = 38;
            // 
            // spinSaldoInicialCmto
            // 
            this.spinSaldoInicialCmto.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinSaldoInicialCmto.Location = new System.Drawing.Point(123, 131);
            this.spinSaldoInicialCmto.Name = "spinSaldoInicialCmto";
            this.spinSaldoInicialCmto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinSaldoInicialCmto.Properties.EditFormat.FormatString = "C2";
            this.spinSaldoInicialCmto.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinSaldoInicialCmto.Size = new System.Drawing.Size(153, 26);
            this.spinSaldoInicialCmto.TabIndex = 36;
            // 
            // gridLookUpEdit1
            // 
            this.gridLookUpEdit1.EditValue = "vacio";
            this.gridLookUpEdit1.Location = new System.Drawing.Point(123, 32);
            this.gridLookUpEdit1.Margin = new System.Windows.Forms.Padding(4);
            this.gridLookUpEdit1.Name = "gridLookUpEdit1";
            this.gridLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit1.Properties.DisplayMember = "Matriz Tenedora";
            this.gridLookUpEdit1.Properties.ValueMember = "IdCuentaBanco";
            this.gridLookUpEdit1.Properties.View = this.gridView3;
            this.gridLookUpEdit1.Size = new System.Drawing.Size(593, 26);
            this.gridLookUpEdit1.TabIndex = 37;
            this.gridLookUpEdit1.EditValueChanged += new System.EventHandler(this.gridLookUpEdit1_EditValueChanged);
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn3});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowAutoFilterRow = true;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "IdMatrizTenedora";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "Matriz Tenedora";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Cuenta Banco";
            this.gridColumn4.FieldName = "NombreCuentaBanco";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Fecha Saldo Inicial";
            this.gridColumn5.FieldName = "FechaSaldoInicial";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Saldo Inicial";
            this.gridColumn6.FieldName = "SaldoInicial";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "RFC";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // dateSaldoCmtos
            // 
            this.dateSaldoCmtos.EditValue = null;
            this.dateSaldoCmtos.Location = new System.Drawing.Point(123, 99);
            this.dateSaldoCmtos.Name = "dateSaldoCmtos";
            this.dateSaldoCmtos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateSaldoCmtos.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateSaldoCmtos.Size = new System.Drawing.Size(153, 26);
            this.dateSaldoCmtos.TabIndex = 35;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(33, 134);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(84, 19);
            this.labelControl9.TabIndex = 32;
            this.labelControl9.Text = "Saldo inicial";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(77, 102);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(40, 19);
            this.labelControl10.TabIndex = 29;
            this.labelControl10.Text = "Fecha";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(20, 68);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(96, 19);
            this.labelControl11.TabIndex = 30;
            this.labelControl11.Text = "Cuenta Banco";
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(55, 35);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(61, 19);
            this.labelControl12.TabIndex = 31;
            this.labelControl12.Text = "Empresa";
            // 
            // txtIdMatrizTenedoraCmos
            // 
            this.txtIdMatrizTenedoraCmos.Location = new System.Drawing.Point(123, 32);
            this.txtIdMatrizTenedoraCmos.Name = "txtIdMatrizTenedoraCmos";
            this.txtIdMatrizTenedoraCmos.Size = new System.Drawing.Size(46, 26);
            this.txtIdMatrizTenedoraCmos.TabIndex = 40;
            // 
            // txtTenedoraCuestasCmos
            // 
            this.txtTenedoraCuestasCmos.Location = new System.Drawing.Point(123, 66);
            this.txtTenedoraCuestasCmos.Name = "txtTenedoraCuestasCmos";
            this.txtTenedoraCuestasCmos.Size = new System.Drawing.Size(47, 26);
            this.txtTenedoraCuestasCmos.TabIndex = 39;
            // 
            // LdelTiempo
            // 
            this.LdelTiempo.Caption = "Línea del tiempo";
            this.LdelTiempo.Controls.Add(this.splitContainer3);
            this.LdelTiempo.Name = "LdelTiempo";
            this.LdelTiempo.Size = new System.Drawing.Size(1434, 950);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.groupControl4);
            this.splitContainer3.Panel1.Controls.Add(this.groupControl3);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.gdCtrolSaldosBXDiaIngresos);
            this.splitContainer3.Size = new System.Drawing.Size(1434, 950);
            this.splitContainer3.SplitterDistance = 174;
            this.splitContainer3.TabIndex = 50;
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.button1);
            this.groupControl4.Controls.Add(this.btnExpSalBancarioxDiaIng);
            this.groupControl4.Controls.Add(this.btnExpSalBancarioxDia);
            this.groupControl4.Controls.Add(this.btnExpSalBancario);
            this.groupControl4.Controls.Add(this.btnConsultaLT);
            this.groupControl4.Controls.Add(this.btnExpLineTiempo);
            this.groupControl4.Location = new System.Drawing.Point(872, 4);
            this.groupControl4.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(549, 153);
            this.groupControl4.TabIndex = 50;
            this.groupControl4.Text = "Acciones";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(433, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 22);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExpSalBancarioxDiaIng
            // 
            this.btnExpSalBancarioxDiaIng.ImageOptions.Image = global::winAppSAIC.Properties.Resources.Excel;
            this.btnExpSalBancarioxDiaIng.Location = new System.Drawing.Point(510, 82);
            this.btnExpSalBancarioxDiaIng.Margin = new System.Windows.Forms.Padding(4);
            this.btnExpSalBancarioxDiaIng.Name = "btnExpSalBancarioxDiaIng";
            this.btnExpSalBancarioxDiaIng.Size = new System.Drawing.Size(29, 25);
            this.btnExpSalBancarioxDiaIng.TabIndex = 11;
            this.btnExpSalBancarioxDiaIng.Text = "Saldo bancario x día Ing.";
            this.btnExpSalBancarioxDiaIng.Visible = false;
            this.btnExpSalBancarioxDiaIng.Click += new System.EventHandler(this.btnExpSalBancarioxDiaIng_Click);
            // 
            // btnExpSalBancarioxDia
            // 
            this.btnExpSalBancarioxDia.ImageOptions.Image = global::winAppSAIC.Properties.Resources.Excel;
            this.btnExpSalBancarioxDia.Location = new System.Drawing.Point(156, 112);
            this.btnExpSalBancarioxDia.Margin = new System.Windows.Forms.Padding(4);
            this.btnExpSalBancarioxDia.Name = "btnExpSalBancarioxDia";
            this.btnExpSalBancarioxDia.Size = new System.Drawing.Size(204, 34);
            this.btnExpSalBancarioxDia.TabIndex = 10;
            this.btnExpSalBancarioxDia.Text = "Saldo bancario x día";
            this.btnExpSalBancarioxDia.Click += new System.EventHandler(this.btnExpSalBancarioxDia_Click);
            // 
            // btnExpSalBancario
            // 
            this.btnExpSalBancario.ImageOptions.Image = global::winAppSAIC.Properties.Resources.Excel;
            this.btnExpSalBancario.Location = new System.Drawing.Point(156, 75);
            this.btnExpSalBancario.Margin = new System.Windows.Forms.Padding(4);
            this.btnExpSalBancario.Name = "btnExpSalBancario";
            this.btnExpSalBancario.Size = new System.Drawing.Size(204, 29);
            this.btnExpSalBancario.TabIndex = 9;
            this.btnExpSalBancario.Text = "Saldos bancarios";
            this.btnExpSalBancario.Click += new System.EventHandler(this.btnExpSalBancario_Click_1);
            // 
            // btnConsultaLT
            // 
            this.btnConsultaLT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultaLT.ImageOptions.Image")));
            this.btnConsultaLT.Location = new System.Drawing.Point(16, 70);
            this.btnConsultaLT.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultaLT.Name = "btnConsultaLT";
            this.btnConsultaLT.Size = new System.Drawing.Size(118, 34);
            this.btnConsultaLT.TabIndex = 7;
            this.btnConsultaLT.Text = "Consultar";
            this.btnConsultaLT.Click += new System.EventHandler(this.btnConsultaLT_Click_1);
            // 
            // btnExpLineTiempo
            // 
            this.btnExpLineTiempo.ImageOptions.Image = global::winAppSAIC.Properties.Resources.Excel;
            this.btnExpLineTiempo.Location = new System.Drawing.Point(156, 38);
            this.btnExpLineTiempo.Margin = new System.Windows.Forms.Padding(4);
            this.btnExpLineTiempo.Name = "btnExpLineTiempo";
            this.btnExpLineTiempo.Size = new System.Drawing.Size(204, 29);
            this.btnExpLineTiempo.TabIndex = 8;
            this.btnExpLineTiempo.Text = "Línea tiempo";
            this.btnExpLineTiempo.Click += new System.EventHandler(this.btnExpLineTiempo_Click_1);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.spAnoCorte);
            this.groupControl3.Controls.Add(this.cboMesCorte);
            this.groupControl3.Controls.Add(this.lblAno);
            this.groupControl3.Controls.Add(this.lblMes);
            this.groupControl3.Controls.Add(this.cmbTenedoraLT);
            this.groupControl3.Controls.Add(this.chkSelTenedoras);
            this.groupControl3.Controls.Add(this.lblTenedoraLT);
            this.groupControl3.Location = new System.Drawing.Point(9, 9);
            this.groupControl3.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(838, 153);
            this.groupControl3.TabIndex = 48;
            this.groupControl3.Text = "Filtros";
            // 
            // spAnoCorte
            // 
            this.spAnoCorte.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spAnoCorte.Location = new System.Drawing.Point(643, 82);
            this.spAnoCorte.Margin = new System.Windows.Forms.Padding(4);
            this.spAnoCorte.Name = "spAnoCorte";
            this.spAnoCorte.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spAnoCorte.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spAnoCorte.Size = new System.Drawing.Size(116, 26);
            this.spAnoCorte.TabIndex = 53;
            // 
            // cboMesCorte
            // 
            this.cboMesCorte.EditValue = "";
            this.cboMesCorte.Location = new System.Drawing.Point(643, 41);
            this.cboMesCorte.Margin = new System.Windows.Forms.Padding(4);
            this.cboMesCorte.Name = "cboMesCorte";
            this.cboMesCorte.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboMesCorte.Properties.DataSource = this.stpSelMesBindingSource;
            this.cboMesCorte.Properties.DisplayMember = "DescMes";
            this.cboMesCorte.Properties.ValueMember = "IdMes";
            this.cboMesCorte.Properties.View = this.gridView13;
            this.cboMesCorte.Size = new System.Drawing.Size(189, 26);
            this.cboMesCorte.TabIndex = 51;
            // 
            // stpSelMesBindingSource
            // 
            this.stpSelMesBindingSource.DataMember = "stpSelMes";
            this.stpSelMesBindingSource.DataSource = this.dbSAICBPODataSet1;
            // 
            // gridView13
            // 
            this.gridView13.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdMes,
            this.colDescMes});
            this.gridView13.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView13.Name = "gridView13";
            this.gridView13.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView13.OptionsView.ShowGroupPanel = false;
            // 
            // colIdMes
            // 
            this.colIdMes.FieldName = "IdMes";
            this.colIdMes.Name = "colIdMes";
            this.colIdMes.OptionsColumn.ReadOnly = true;
            // 
            // colDescMes
            // 
            this.colDescMes.Caption = "Mes";
            this.colDescMes.FieldName = "DescMes";
            this.colDescMes.Name = "colDescMes";
            this.colDescMes.Visible = true;
            this.colDescMes.VisibleIndex = 0;
            // 
            // lblAno
            // 
            this.lblAno.Location = new System.Drawing.Point(600, 85);
            this.lblAno.Margin = new System.Windows.Forms.Padding(4);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(35, 19);
            this.lblAno.TabIndex = 52;
            this.lblAno.Text = "Año:";
            // 
            // lblMes
            // 
            this.lblMes.Location = new System.Drawing.Point(602, 44);
            this.lblMes.Margin = new System.Windows.Forms.Padding(4);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(33, 19);
            this.lblMes.TabIndex = 50;
            this.lblMes.Text = "Mes:";
            // 
            // cmbTenedoraLT
            // 
            this.cmbTenedoraLT.EditValue = "vacio";
            this.cmbTenedoraLT.Location = new System.Drawing.Point(103, 82);
            this.cmbTenedoraLT.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTenedoraLT.Name = "cmbTenedoraLT";
            this.cmbTenedoraLT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTenedoraLT.Properties.DataSource = this.stpSelMatrizTenedoraEdoCtaBindingSource;
            this.cmbTenedoraLT.Properties.DisplayMember = "Matriz Tenedora";
            this.cmbTenedoraLT.Properties.ValueMember = "IdMatrizTenedora";
            this.cmbTenedoraLT.Properties.View = this.gridView8;
            this.cmbTenedoraLT.Size = new System.Drawing.Size(484, 26);
            this.cmbTenedoraLT.TabIndex = 52;
            this.cmbTenedoraLT.Visible = false;
            // 
            // gridView8
            // 
            this.gridView8.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn15,
            this.gridColumn16,
            this.gridColumn17});
            this.gridView8.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView8.Name = "gridView8";
            this.gridView8.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView8.OptionsView.ShowAutoFilterRow = true;
            this.gridView8.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn15
            // 
            this.gridColumn15.FieldName = "IdMatrizTenedora";
            this.gridColumn15.Name = "gridColumn15";
            // 
            // gridColumn16
            // 
            this.gridColumn16.FieldName = "Matriz Tenedora";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 0;
            // 
            // gridColumn17
            // 
            this.gridColumn17.FieldName = "RFC";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 1;
            // 
            // chkSelTenedoras
            // 
            this.chkSelTenedoras.EditValue = true;
            this.chkSelTenedoras.Location = new System.Drawing.Point(103, 44);
            this.chkSelTenedoras.Name = "chkSelTenedoras";
            this.chkSelTenedoras.Properties.Caption = "Todas - Tenedoras";
            this.chkSelTenedoras.Size = new System.Drawing.Size(169, 23);
            this.chkSelTenedoras.TabIndex = 51;
            this.chkSelTenedoras.CheckedChanged += new System.EventHandler(this.chkSelTenedoras_CheckedChanged);
            // 
            // lblTenedoraLT
            // 
            this.lblTenedoraLT.Location = new System.Drawing.Point(29, 85);
            this.lblTenedoraLT.Name = "lblTenedoraLT";
            this.lblTenedoraLT.Size = new System.Drawing.Size(67, 19);
            this.lblTenedoraLT.TabIndex = 45;
            this.lblTenedoraLT.Text = "Tenedora";
            this.lblTenedoraLT.Visible = false;
            // 
            // gdCtrolSaldosBXDiaIngresos
            // 
            this.gdCtrolSaldosBXDiaIngresos.Controls.Add(this.tabNavMovimientos);
            this.gdCtrolSaldosBXDiaIngresos.Controls.Add(this.tabNavSaldos);
            this.gdCtrolSaldosBXDiaIngresos.Controls.Add(this.tabNavSaldosXDia);
            this.gdCtrolSaldosBXDiaIngresos.Controls.Add(this.tabNavSaldosXDiaIng);
            this.gdCtrolSaldosBXDiaIngresos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdCtrolSaldosBXDiaIngresos.Location = new System.Drawing.Point(0, 0);
            this.gdCtrolSaldosBXDiaIngresos.Name = "gdCtrolSaldosBXDiaIngresos";
            this.gdCtrolSaldosBXDiaIngresos.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavMovimientos,
            this.tabNavSaldos,
            this.tabNavSaldosXDia,
            this.tabNavSaldosXDiaIng});
            this.gdCtrolSaldosBXDiaIngresos.RegularSize = new System.Drawing.Size(1434, 772);
            this.gdCtrolSaldosBXDiaIngresos.SelectedPage = this.tabNavMovimientos;
            this.gdCtrolSaldosBXDiaIngresos.Size = new System.Drawing.Size(1434, 772);
            this.gdCtrolSaldosBXDiaIngresos.TabIndex = 1;
            this.gdCtrolSaldosBXDiaIngresos.Text = "tabPLineaTiempo";
            this.gdCtrolSaldosBXDiaIngresos.SelectedPageChanged += new DevExpress.XtraBars.Navigation.SelectedPageChangedEventHandler(this.tabPane2_SelectedPageChanged);
            this.gdCtrolSaldosBXDiaIngresos.Click += new System.EventHandler(this.gdCtrolSaldosBXDiaIngresos_Click);
            // 
            // tabNavMovimientos
            // 
            this.tabNavMovimientos.Caption = "Movimientos";
            this.tabNavMovimientos.Controls.Add(this.gridLineaTiempo);
            this.tabNavMovimientos.Name = "tabNavMovimientos";
            this.tabNavMovimientos.Size = new System.Drawing.Size(1408, 704);
            // 
            // gridLineaTiempo
            // 
            this.gridLineaTiempo.DataSource = this.stpSelTenedoraLineaTiempovBindingSource;
            this.gridLineaTiempo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridLineaTiempo.Location = new System.Drawing.Point(0, 0);
            this.gridLineaTiempo.MainView = this.gridView9;
            this.gridLineaTiempo.Name = "gridLineaTiempo";
            this.gridLineaTiempo.Size = new System.Drawing.Size(1408, 704);
            this.gridLineaTiempo.TabIndex = 0;
            this.gridLineaTiempo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView9});
            // 
            // stpSelTenedoraLineaTiempovBindingSource
            // 
            this.stpSelTenedoraLineaTiempovBindingSource.DataMember = "stpSelTenedoraLineaTiempov";
            this.stpSelTenedoraLineaTiempovBindingSource.DataSource = this.dbSAICBPOTesoreriaDataSet;
            // 
            // gridView9
            // 
            this.gridView9.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colESTRUCTURA,
            this.colEMPRESA,
            this.colCONSECUTIVO1,
            this.colFECHA1,
            this.colMOVIMIENTO1,
            this.gridColumnCheque,
            this.gridColumnLote,
            this.gridColumn18,
            this.colFACTURA1,
            this.colOPERADOR1,
            this.colTESORERO_,
            this.colCONTROL1,
            this.colINGRESO1,
            this.colEGRESO1,
            this.colOBSERVACIONES1,
            this.colBANCO1,
            this.colSALDO});
            this.gridView9.GridControl = this.gridLineaTiempo;
            this.gridView9.Name = "gridView9";
            this.gridView9.OptionsView.ColumnAutoWidth = false;
            this.gridView9.OptionsView.ShowAutoFilterRow = true;
            this.gridView9.OptionsView.ShowGroupPanel = false;
            this.gridView9.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colFECHA1, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colESTRUCTURA
            // 
            this.colESTRUCTURA.FieldName = "ESTRUCTURA";
            this.colESTRUCTURA.Name = "colESTRUCTURA";
            this.colESTRUCTURA.Visible = true;
            this.colESTRUCTURA.VisibleIndex = 0;
            this.colESTRUCTURA.Width = 131;
            // 
            // colEMPRESA
            // 
            this.colEMPRESA.FieldName = "EMPRESA";
            this.colEMPRESA.Name = "colEMPRESA";
            this.colEMPRESA.Visible = true;
            this.colEMPRESA.VisibleIndex = 1;
            this.colEMPRESA.Width = 99;
            // 
            // colCONSECUTIVO1
            // 
            this.colCONSECUTIVO1.FieldName = "CONSECUTIVO";
            this.colCONSECUTIVO1.Name = "colCONSECUTIVO1";
            this.colCONSECUTIVO1.Visible = true;
            this.colCONSECUTIVO1.VisibleIndex = 2;
            this.colCONSECUTIVO1.Width = 140;
            // 
            // colFECHA1
            // 
            this.colFECHA1.FieldName = "FECHA";
            this.colFECHA1.Name = "colFECHA1";
            this.colFECHA1.Visible = true;
            this.colFECHA1.VisibleIndex = 3;
            this.colFECHA1.Width = 79;
            // 
            // colMOVIMIENTO1
            // 
            this.colMOVIMIENTO1.FieldName = "MOVIMIENTO";
            this.colMOVIMIENTO1.Name = "colMOVIMIENTO1";
            this.colMOVIMIENTO1.Visible = true;
            this.colMOVIMIENTO1.VisibleIndex = 4;
            this.colMOVIMIENTO1.Width = 130;
            // 
            // gridColumnCheque
            // 
            this.gridColumnCheque.Caption = "CHEQUE";
            this.gridColumnCheque.FieldName = "CHEQUE";
            this.gridColumnCheque.Name = "gridColumnCheque";
            this.gridColumnCheque.Visible = true;
            this.gridColumnCheque.VisibleIndex = 5;
            this.gridColumnCheque.Width = 140;
            // 
            // gridColumnLote
            // 
            this.gridColumnLote.Caption = "LOTE";
            this.gridColumnLote.FieldName = "LOTE";
            this.gridColumnLote.Name = "gridColumnLote";
            this.gridColumnLote.Visible = true;
            this.gridColumnLote.VisibleIndex = 6;
            this.gridColumnLote.Width = 166;
            // 
            // gridColumn18
            // 
            this.gridColumn18.FieldName = "CLIENTE / PROVEEDOR";
            this.gridColumn18.Name = "gridColumn18";
            this.gridColumn18.Visible = true;
            this.gridColumn18.VisibleIndex = 7;
            this.gridColumn18.Width = 202;
            // 
            // colFACTURA1
            // 
            this.colFACTURA1.FieldName = "FACTURA";
            this.colFACTURA1.Name = "colFACTURA1";
            this.colFACTURA1.Visible = true;
            this.colFACTURA1.VisibleIndex = 8;
            this.colFACTURA1.Width = 101;
            // 
            // colOPERADOR1
            // 
            this.colOPERADOR1.FieldName = "OPERADOR";
            this.colOPERADOR1.Name = "colOPERADOR1";
            this.colOPERADOR1.Visible = true;
            this.colOPERADOR1.VisibleIndex = 9;
            this.colOPERADOR1.Width = 115;
            // 
            // colTESORERO_
            // 
            this.colTESORERO_.FieldName = "TESORERO";
            this.colTESORERO_.Name = "colTESORERO_";
            this.colTESORERO_.Visible = true;
            this.colTESORERO_.VisibleIndex = 10;
            // 
            // colCONTROL1
            // 
            this.colCONTROL1.FieldName = "CONTROL";
            this.colCONTROL1.Name = "colCONTROL1";
            this.colCONTROL1.Visible = true;
            this.colCONTROL1.VisibleIndex = 11;
            this.colCONTROL1.Width = 103;
            // 
            // colINGRESO1
            // 
            this.colINGRESO1.DisplayFormat.FormatString = "C2";
            this.colINGRESO1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colINGRESO1.FieldName = "INGRESO";
            this.colINGRESO1.Name = "colINGRESO1";
            this.colINGRESO1.Visible = true;
            this.colINGRESO1.VisibleIndex = 12;
            this.colINGRESO1.Width = 98;
            // 
            // colEGRESO1
            // 
            this.colEGRESO1.DisplayFormat.FormatString = "C2";
            this.colEGRESO1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colEGRESO1.FieldName = "EGRESO";
            this.colEGRESO1.Name = "colEGRESO1";
            this.colEGRESO1.Visible = true;
            this.colEGRESO1.VisibleIndex = 13;
            this.colEGRESO1.Width = 90;
            // 
            // colOBSERVACIONES1
            // 
            this.colOBSERVACIONES1.FieldName = "OBSERVACIONES";
            this.colOBSERVACIONES1.Name = "colOBSERVACIONES1";
            this.colOBSERVACIONES1.Visible = true;
            this.colOBSERVACIONES1.VisibleIndex = 14;
            this.colOBSERVACIONES1.Width = 157;
            // 
            // colBANCO1
            // 
            this.colBANCO1.FieldName = "BANCO";
            this.colBANCO1.Name = "colBANCO1";
            this.colBANCO1.Visible = true;
            this.colBANCO1.VisibleIndex = 15;
            this.colBANCO1.Width = 106;
            // 
            // colSALDO
            // 
            this.colSALDO.DisplayFormat.FormatString = "C2";
            this.colSALDO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSALDO.FieldName = "SALDO";
            this.colSALDO.Name = "colSALDO";
            this.colSALDO.Visible = true;
            this.colSALDO.VisibleIndex = 16;
            this.colSALDO.Width = 81;
            // 
            // tabNavSaldos
            // 
            this.tabNavSaldos.Caption = "Saldos bancarios";
            this.tabNavSaldos.Controls.Add(this.gridSaldosBancarios);
            this.tabNavSaldos.Name = "tabNavSaldos";
            this.tabNavSaldos.Size = new System.Drawing.Size(1408, 704);
            // 
            // gridSaldosBancarios
            // 
            this.gridSaldosBancarios.DataSource = this.tesSaldosLTDBindingSource1;
            this.gridSaldosBancarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSaldosBancarios.Location = new System.Drawing.Point(0, 0);
            this.gridSaldosBancarios.MainView = this.gridView10;
            this.gridSaldosBancarios.Name = "gridSaldosBancarios";
            this.gridSaldosBancarios.Size = new System.Drawing.Size(1408, 704);
            this.gridSaldosBancarios.TabIndex = 0;
            this.gridSaldosBancarios.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView10});
            // 
            // tesSaldosLTDBindingSource1
            // 
            this.tesSaldosLTDBindingSource1.DataMember = "TesSaldosLTD";
            this.tesSaldosLTDBindingSource1.DataSource = this.dbSAICBPOTesoreriaDataSet;
            // 
            // gridView10
            // 
            this.gridView10.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNombre,
            this.colBANBAJIO,
            this.colBANCOMER,
            this.colBANORTE,
            this.colHSBC,
            this.colINBURSA,
            this.colSANTANDER,
            this.colSCOTIABANK,
            this.colTOTAL});
            this.gridView10.GridControl = this.gridSaldosBancarios;
            this.gridView10.Name = "gridView10";
            this.gridView10.OptionsView.ColumnAutoWidth = false;
            this.gridView10.OptionsView.ShowAutoFilterRow = true;
            this.gridView10.OptionsView.ShowGroupPanel = false;
            // 
            // colNombre
            // 
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 0;
            this.colNombre.Width = 86;
            // 
            // colBANBAJIO
            // 
            this.colBANBAJIO.DisplayFormat.FormatString = "C2";
            this.colBANBAJIO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBANBAJIO.FieldName = "BANBAJIO";
            this.colBANBAJIO.Name = "colBANBAJIO";
            this.colBANBAJIO.Visible = true;
            this.colBANBAJIO.VisibleIndex = 1;
            this.colBANBAJIO.Width = 105;
            // 
            // colBANCOMER
            // 
            this.colBANCOMER.DisplayFormat.FormatString = "C2";
            this.colBANCOMER.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBANCOMER.FieldName = "BANCOMER";
            this.colBANCOMER.Name = "colBANCOMER";
            this.colBANCOMER.Visible = true;
            this.colBANCOMER.VisibleIndex = 2;
            this.colBANCOMER.Width = 114;
            // 
            // colBANORTE
            // 
            this.colBANORTE.DisplayFormat.FormatString = "C2";
            this.colBANORTE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBANORTE.FieldName = "BANORTE";
            this.colBANORTE.Name = "colBANORTE";
            this.colBANORTE.Visible = true;
            this.colBANORTE.VisibleIndex = 3;
            this.colBANORTE.Width = 101;
            // 
            // colHSBC
            // 
            this.colHSBC.DisplayFormat.FormatString = "C2";
            this.colHSBC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colHSBC.FieldName = "HSBC";
            this.colHSBC.Name = "colHSBC";
            this.colHSBC.Visible = true;
            this.colHSBC.VisibleIndex = 4;
            this.colHSBC.Width = 76;
            // 
            // colINBURSA
            // 
            this.colINBURSA.DisplayFormat.FormatString = "C2";
            this.colINBURSA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colINBURSA.FieldName = "INBURSA";
            this.colINBURSA.Name = "colINBURSA";
            this.colINBURSA.Visible = true;
            this.colINBURSA.VisibleIndex = 5;
            this.colINBURSA.Width = 96;
            // 
            // colSANTANDER
            // 
            this.colSANTANDER.DisplayFormat.FormatString = "C2";
            this.colSANTANDER.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSANTANDER.FieldName = "SANTANDER";
            this.colSANTANDER.Name = "colSANTANDER";
            this.colSANTANDER.Visible = true;
            this.colSANTANDER.VisibleIndex = 6;
            this.colSANTANDER.Width = 123;
            // 
            // colSCOTIABANK
            // 
            this.colSCOTIABANK.DisplayFormat.FormatString = "C2";
            this.colSCOTIABANK.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSCOTIABANK.FieldName = "SCOTIABANK";
            this.colSCOTIABANK.Name = "colSCOTIABANK";
            this.colSCOTIABANK.Visible = true;
            this.colSCOTIABANK.VisibleIndex = 7;
            this.colSCOTIABANK.Width = 128;
            // 
            // colTOTAL
            // 
            this.colTOTAL.DisplayFormat.FormatString = "C2";
            this.colTOTAL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTOTAL.FieldName = "TOTAL";
            this.colTOTAL.Name = "colTOTAL";
            this.colTOTAL.Visible = true;
            this.colTOTAL.VisibleIndex = 8;
            this.colTOTAL.Width = 80;
            // 
            // tabNavSaldosXDia
            // 
            this.tabNavSaldosXDia.Caption = "Saldos Bancarios Día";
            this.tabNavSaldosXDia.Controls.Add(this.gdCtrolSaldosBXDia);
            this.tabNavSaldosXDia.Name = "tabNavSaldosXDia";
            this.tabNavSaldosXDia.Size = new System.Drawing.Size(1434, 772);
            // 
            // gdCtrolSaldosBXDia
            // 
            this.gdCtrolSaldosBXDia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdCtrolSaldosBXDia.Location = new System.Drawing.Point(0, 0);
            this.gdCtrolSaldosBXDia.MainView = this.gridView11;
            this.gdCtrolSaldosBXDia.Name = "gdCtrolSaldosBXDia";
            this.gdCtrolSaldosBXDia.Size = new System.Drawing.Size(1434, 772);
            this.gdCtrolSaldosBXDia.TabIndex = 0;
            this.gdCtrolSaldosBXDia.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView11});
            // 
            // gridView11
            // 
            this.gridView11.GridControl = this.gdCtrolSaldosBXDia;
            this.gridView11.Name = "gridView11";
            this.gridView11.OptionsView.ShowAutoFilterRow = true;
            // 
            // tabNavSaldosXDiaIng
            // 
            this.tabNavSaldosXDiaIng.Caption = "Saldos Bancarios Día Ingresos";
            this.tabNavSaldosXDiaIng.Controls.Add(this.gdCtrolSaldosBXDiaIng);
            this.tabNavSaldosXDiaIng.Name = "tabNavSaldosXDiaIng";
            this.tabNavSaldosXDiaIng.PageVisible = false;
            this.tabNavSaldosXDiaIng.Size = new System.Drawing.Size(1434, 772);
            // 
            // gdCtrolSaldosBXDiaIng
            // 
            this.gdCtrolSaldosBXDiaIng.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdCtrolSaldosBXDiaIng.Location = new System.Drawing.Point(0, 0);
            this.gdCtrolSaldosBXDiaIng.MainView = this.gridView12;
            this.gdCtrolSaldosBXDiaIng.Name = "gdCtrolSaldosBXDiaIng";
            this.gdCtrolSaldosBXDiaIng.Size = new System.Drawing.Size(1434, 772);
            this.gdCtrolSaldosBXDiaIng.TabIndex = 0;
            this.gdCtrolSaldosBXDiaIng.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView12});
            // 
            // gridView12
            // 
            this.gridView12.GridControl = this.gdCtrolSaldosBXDiaIng;
            this.gridView12.Name = "gridView12";
            this.gridView12.OptionsView.ShowAutoFilterRow = true;
            // 
            // dbSAICBPOTesoreriaDataSet1
            // 
            this.dbSAICBPOTesoreriaDataSet1.DataSetName = "dbSAICBPOTesoreriaDataSet";
            this.dbSAICBPOTesoreriaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tesSaldosLTDBindingSource
            // 
            this.tesSaldosLTDBindingSource.DataMember = "TesSaldosLTD";
            this.tesSaldosLTDBindingSource.DataSource = this.dbSAICBPOTesoreriaDataSetBindingSource;
            // 
            // stpSelSaldosBancariosFinalBindingSource2
            // 
            this.stpSelSaldosBancariosFinalBindingSource2.DataMember = "stpSelSaldosBancariosFinal";
            this.stpSelSaldosBancariosFinalBindingSource2.DataSource = this.dbSAICBPOTesoreriaDataSet;
            // 
            // stpSelSaldosBancariosFinalBindingSource
            // 
            this.stpSelSaldosBancariosFinalBindingSource.DataMember = "stpSelSaldosBancariosFinal";
            this.stpSelSaldosBancariosFinalBindingSource.DataSource = this.dbSAICBPOTesoreriaDataSetBindingSource;
            // 
            // dbSAICBPOTesoreriaDataSet2
            // 
            this.dbSAICBPOTesoreriaDataSet2.DataSetName = "dbSAICBPOTesoreriaDataSet";
            this.dbSAICBPOTesoreriaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stpSelMatrizTenedoraEdoCtaTableAdapter
            // 
            this.stpSelMatrizTenedoraEdoCtaTableAdapter.ClearBeforeFill = true;
            // 
            // stpSelCtaBcoMatrizTenedoraTableAdapter
            // 
            this.stpSelCtaBcoMatrizTenedoraTableAdapter.ClearBeforeFill = true;
            // 
            // splashScreenManager2
            // 
            this.splashScreenManager2.ClosingDelay = 500;
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // stpSelEsquemaTableAdapter
            // 
            this.stpSelEsquemaTableAdapter.ClearBeforeFill = true;
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSalir,
            this.toolStripSeparator2});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip2.Size = new System.Drawing.Size(1460, 32);
            this.toolStrip2.TabIndex = 36;
            this.toolStrip2.Text = "toolStrip2";
            this.toolStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip2_ItemClicked);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::winAppSAIC.Properties.Resources.Salir24x24;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(69, 29);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 32);
            // 
            // stpSelTenedoraLibroDiarioTableAdapter1
            // 
            this.stpSelTenedoraLibroDiarioTableAdapter1.ClearBeforeFill = true;
            // 
            // vwCatTesConceptoTableAdapter1
            // 
            this.vwCatTesConceptoTableAdapter1.ClearBeforeFill = true;
            // 
            // vwCatTesConceptoTableAdapter2
            // 
            this.vwCatTesConceptoTableAdapter2.ClearBeforeFill = true;
            // 
            // vwCatEstatusTableAdapter1
            // 
            this.vwCatEstatusTableAdapter1.ClearBeforeFill = true;
            // 
            // dbSAICBPODataSet1BindingSource
            // 
            this.dbSAICBPODataSet1BindingSource.DataSource = this.dbSAICBPODataSet1;
            this.dbSAICBPODataSet1BindingSource.Position = 0;
            // 
            // vwTesClienteProveedorTableAdapter1
            // 
            this.vwTesClienteProveedorTableAdapter1.ClearBeforeFill = true;
            // 
            // dbSAICBPODataSet1BindingSource1
            // 
            this.dbSAICBPODataSet1BindingSource1.DataSource = this.dbSAICBPODataSet1;
            this.dbSAICBPODataSet1BindingSource1.Position = 0;
            // 
            // dbSAICBPO_CatalogosValidacionDataSet1
            // 
            this.dbSAICBPO_CatalogosValidacionDataSet1.DataSetName = "dbSAICBPO_CatalogosValidacionDataSet";
            this.dbSAICBPO_CatalogosValidacionDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stpSelSaldosBancariosFinalTableAdapter1
            // 
            this.stpSelSaldosBancariosFinalTableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelSaldosBancariosFinalTableAdapter2
            // 
            this.stpSelSaldosBancariosFinalTableAdapter2.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.CuentaBancoTableAdapter = null;
            this.tableAdapterManager1.SolicitudChequeDetailTableAdapter = null;
            this.tableAdapterManager1.SolicitudChequeHeaderTableAdapter = null;
            this.tableAdapterManager1.TenedoraBancoTableAdapter = null;
            this.tableAdapterManager1.TesSaldosConceptoDiaMesTableAdapter = null;
            this.tableAdapterManager1.TesSaldosLTDTableAdapter = null;
            this.tableAdapterManager1.TransaccionBancoTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = winAppSAIC.Tesoreria.dbSAICBPOTesoreriaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tesSaldosLTDTableAdapter
            // 
            this.tesSaldosLTDTableAdapter.ClearBeforeFill = true;
            // 
            // dbSAICAsimilados1
            // 
            this.dbSAICAsimilados1.DataSetName = "dbSAICAsimilados";
            this.dbSAICAsimilados1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stpSelSaldosBancariosAlCierreXDiaTableAdapter1
            // 
            this.stpSelSaldosBancariosAlCierreXDiaTableAdapter1.ClearBeforeFill = true;
            // 
            // tesSaldosConceptoDiaMesBindingSource
            // 
            this.tesSaldosConceptoDiaMesBindingSource.DataMember = "TesSaldosConceptoDiaMes";
            this.tesSaldosConceptoDiaMesBindingSource.DataSource = this.dbSAICBPOTesoreriaDataSetBindingSource;
            // 
            // tesSaldosConceptoDiaMesTableAdapter
            // 
            this.tesSaldosConceptoDiaMesTableAdapter.ClearBeforeFill = true;
            // 
            // stpSelMesTableAdapter1
            // 
            this.stpSelMesTableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelTenedoraLineaTiempovTableAdapter1
            // 
            this.stpSelTenedoraLineaTiempovTableAdapter1.ClearBeforeFill = true;
            // 
            // dbSAICBPOActualizacionesDataSet
            // 
            this.dbSAICBPOActualizacionesDataSet.DataSetName = "dbSAICBPOActualizacionesDataSet";
            this.dbSAICBPOActualizacionesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbSAICBPOActualizacionesDataSetBindingSource
            // 
            this.dbSAICBPOActualizacionesDataSetBindingSource.DataSource = this.dbSAICBPOActualizacionesDataSet;
            this.dbSAICBPOActualizacionesDataSetBindingSource.Position = 0;
            // 
            // frmxSaldosTesoreria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1460, 1050);
            this.Controls.Add(this.tabPane1);
            this.Controls.Add(this.toolStrip2);
            this.IsMdiContainer = true;
            this.MinimizeBox = false;
            this.Name = "frmxSaldosTesoreria";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saldos Tesorería - Carga saldo inicial";
            this.Load += new System.EventHandler(this.frmxEstadosdeCuenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.Edita.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboTenedoraEditar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelMatrizTenedoraEdoCtaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOTesoreriaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboBancoEditar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelCtaBcoMatrizTenedoraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdEdicion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelTenedoraLibroDiarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOTesoreriaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grMovimientos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spiEgresoEd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spiIngresoEd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCteProvEd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwTesClienteProveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPODataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEstatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCatEstatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbConcepEd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCatTesConceptoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaEd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaEd.Properties)).EndInit();
            this.Carga.ResumeLayout(false);
            this.gpoSeleccionNvo.ResumeLayout(false);
            this.gpoSeleccionNvo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glEsquemaNvo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelEsquemaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSaldoInicialNvo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookTenedoraNvo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookTenedoraCuentasNvo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSaldoNvo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSaldoNvo.Properties)).EndInit();
            this.gpoSeleccion.ResumeLayout(false);
            this.gpoSeleccion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkActSaldos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreArchivoExcel.Properties)).EndInit();
            this.gpoSeleccionCmoss.ResumeLayout(false);
            this.gpoSeleccionCmoss.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCuentaBancoCmto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSaldoInicialCmto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSaldoCmtos.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSaldoCmtos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdMatrizTenedoraCmos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenedoraCuestasCmos.Properties)).EndInit();
            this.LdelTiempo.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spAnoCorte.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMesCorte.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelMesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTenedoraLT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSelTenedoras.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdCtrolSaldosBXDiaIngresos)).EndInit();
            this.gdCtrolSaldosBXDiaIngresos.ResumeLayout(false);
            this.tabNavMovimientos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridLineaTiempo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelTenedoraLineaTiempovBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView9)).EndInit();
            this.tabNavSaldos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSaldosBancarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tesSaldosLTDBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView10)).EndInit();
            this.tabNavSaldosXDia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdCtrolSaldosBXDia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView11)).EndInit();
            this.tabNavSaldosXDiaIng.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdCtrolSaldosBXDiaIng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOTesoreriaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelTenedoraLineaTiempoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tesSaldosLTDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelSaldosBancariosFinalBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelSaldosBancariosFinalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOTesoreriaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPODataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPODataSet1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPO_CatalogosValidacionDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbADNAPENSIONMX20240229DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICAsimilados1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tesSaldosConceptoDiaMesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOActualizacionesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOActualizacionesDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.GridLookUpEdit gridLookTenedoraCuentasNvo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookTenedoraNvo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dateSaldoNvo;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private dbSAICBPOTesoreriaDataSet dbSAICBPOTesoreriaDataSet;
        private System.Windows.Forms.BindingSource stpSelMatrizTenedoraEdoCtaBindingSource;
        private dbSAICBPOTesoreriaDataSetTableAdapters.stpSelMatrizTenedoraEdoCtaTableAdapter stpSelMatrizTenedoraEdoCtaTableAdapter;
        private System.Windows.Forms.BindingSource stpSelCtaBcoMatrizTenedoraBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCuentaBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreCuentaBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colNoCuenta;
        private DevExpress.XtraGrid.Columns.GridColumn colNoCLABE;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMatrizTenedora;
        private DevExpress.XtraGrid.Columns.GridColumn colMatrizTenedora;
        private DevExpress.XtraGrid.Columns.GridColumn colRFC;
        private dbSAICBPOTesoreriaDataSetTableAdapters.stpSelCtaBcoMatrizTenedoraTableAdapter stpSelCtaBcoMatrizTenedoraTableAdapter;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SpinEdit spinSaldoInicialNvo;
        private DevExpress.XtraEditors.SimpleButton btnActualizar;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager2;
        private dbSAICBPOTesoreriaDataSetTableAdapters.RespuestasTesoreria respuestasTesoreria;
        private System.Windows.Forms.GroupBox gpoSeleccionNvo;
        private System.Windows.Forms.GroupBox gpoSeleccion;
        private System.Windows.Forms.RadioButton rdbComplemento;
        private System.Windows.Forms.RadioButton rdbNuevo;
        private dbSAICBPOTesoreriaDataSet dbSAICBPOTesoreriaDataSet1;
        private dbSAICBPOTesoreriaDataSet dbSAICBPOTesoreriaDataSet2;
        private System.Windows.Forms.GroupBox gpoSeleccionCmoss;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.SpinEdit spinSaldoInicialCmto;
        private DevExpress.XtraEditors.DateEdit dateSaldoCmtos;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.TextEdit TxtCuentaBancoCmto;
        private DevExpress.XtraEditors.TextEdit txtTenedoraCuestasCmos;
        private DevExpress.XtraEditors.TextEdit txtIdMatrizTenedoraCmos;
        private DevExpress.XtraEditors.CheckEdit chkActSaldos;
        private DevExpress.XtraEditors.TextEdit txtNombreArchivoExcel;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage Carga;
        private DevExpress.XtraBars.Navigation.TabNavigationPage Edita;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.BindingSource dbSAICBPOTesoreriaDataSetBindingSource;
        private System.Windows.Forms.BindingSource stpSelEsquemaBindingSource;
        private dbSAICBPOTesoreriaDataSetTableAdapters.stpSelEsquemaTableAdapter stpSelEsquemaTableAdapter;
        private DevExpress.XtraEditors.GridLookUpEdit glEsquemaNvo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit2View;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.GridLookUpEdit cboTenedoraEditar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraEditors.GridLookUpEdit cboBancoEditar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.TextBox txtLoteEd;
        private DevExpress.XtraEditors.LabelControl lblFolio;
        private System.Windows.Forms.TextBox TxtFacturaEd;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.TextBox txtControlEd;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private System.Windows.Forms.TextBox txtChequeEd;
        private System.Windows.Forms.TextBox txtObservacionesEd;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.LabelControl labelControl20;
        private DevExpress.XtraEditors.DateEdit dtFechaEd;
        private System.Windows.Forms.TextBox txtConsEd;
        private DevExpress.XtraEditors.LabelControl labelControl23;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl24;
        private DevExpress.XtraEditors.SimpleButton btnGuardarEd;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnConsultarEdicion;
        private dbSAICBPOTesoreriaDataSetTableAdapters.stpSelTenedoraLibroDiarioTableAdapter stpSelTenedoraLibroDiarioTableAdapter1;
        private System.Windows.Forms.BindingSource stpSelTenedoraLibroDiarioBindingSource;
        private System.Windows.Forms.TextBox txtIdEd;
        private DevExpress.XtraEditors.LabelControl labelControl25;
        private dbSAICBPODataSetTableAdapters.vwCatTesConceptoTableAdapter vwCatTesConceptoTableAdapter1;
        private dbSAICBPODataSetTableAdapters.vwCatTesConceptoTableAdapter vwCatTesConceptoTableAdapter2;
        private dbSAICBPODataSet dbSAICBPODataSet1;
        private System.Windows.Forms.BindingSource vwCatTesConceptoBindingSource;
        private DevExpress.XtraEditors.GridLookUpEdit cbConcepEd;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private dbSAICBPODataSetTableAdapters.vwCatEstatusTableAdapter vwCatEstatusTableAdapter1;
        private DevExpress.XtraEditors.GridLookUpEdit cbEstatus;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private System.Windows.Forms.BindingSource vwCatEstatusBindingSource;
        private System.Windows.Forms.BindingSource dbSAICBPODataSet1BindingSource;
        private dbSAICBPODataSetTableAdapters.vwTesClienteProveedorTableAdapter vwTesClienteProveedorTableAdapter1;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.GridLookUpEdit cbCteProvEd;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView7;
        private System.Windows.Forms.BindingSource vwTesClienteProveedorBindingSource;
        private System.Windows.Forms.BindingSource dbSAICBPODataSet1BindingSource1;
        private DevExpress.XtraEditors.SpinEdit spiIngresoEd;
        private DevExpress.XtraEditors.SpinEdit spiEgresoEd;
        private DevExpress.XtraBars.Navigation.TabNavigationPage LdelTiempo;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.LabelControl lblTenedoraLT;
        private DevExpress.XtraEditors.CheckEdit chkSelTenedoras;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private DevExpress.XtraEditors.GridLookUpEdit cmbTenedoraLT;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.GridControl gdEdicion;
        private DevExpress.XtraGrid.Views.Grid.GridView grMovimientos;
        private DevExpress.XtraGrid.Columns.GridColumn colCONSECUTIVO;
        private DevExpress.XtraGrid.Columns.GridColumn colFECHA;
        private DevExpress.XtraGrid.Columns.GridColumn colMOVIMIENTO;
        private DevExpress.XtraGrid.Columns.GridColumn colCHEQUE;
        private DevExpress.XtraGrid.Columns.GridColumn colLOTE;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn29;
        private DevExpress.XtraGrid.Columns.GridColumn colFACTURA;
        private DevExpress.XtraGrid.Columns.GridColumn colOPERADOR;
        private DevExpress.XtraGrid.Columns.GridColumn colCONTROL;
        private DevExpress.XtraGrid.Columns.GridColumn colINGRESO;
        private DevExpress.XtraGrid.Columns.GridColumn colEGRESO;
        private DevExpress.XtraGrid.Columns.GridColumn colOBSERVACIONES;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstatus;
        private DevExpress.XtraGrid.Columns.GridColumn colESTATUS;
        private System.Windows.Forms.BindingSource stpSelTenedoraLineaTiempoBindingSource;
        private Catalogos.dbSAICBPO_CatalogosValidacionDataSet dbSAICBPO_CatalogosValidacionDataSet1;
        //MAFM
        //////private dbSAICBPOTesoreriaDataSetTableAdapters.stpSelTenedoraLineaTiempoTableAdapter stpSelTenedoraLineaTiempoTableAdapter1;
        private DevExpress.XtraGrid.GridControl gridLineaTiempo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView9;
        private DevExpress.XtraGrid.Columns.GridColumn colESTRUCTURA;
        private DevExpress.XtraGrid.Columns.GridColumn colEMPRESA;
        private DevExpress.XtraGrid.Columns.GridColumn colCONSECUTIVO1;
        private DevExpress.XtraGrid.Columns.GridColumn colFECHA1;
        private DevExpress.XtraGrid.Columns.GridColumn colMOVIMIENTO1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraGrid.Columns.GridColumn colFACTURA1;
        private DevExpress.XtraGrid.Columns.GridColumn colOPERADOR1;
        private DevExpress.XtraGrid.Columns.GridColumn colCONTROL1;
        private DevExpress.XtraGrid.Columns.GridColumn colINGRESO1;
        private DevExpress.XtraGrid.Columns.GridColumn colEGRESO1;
        private DevExpress.XtraGrid.Columns.GridColumn colOBSERVACIONES1;
        private DevExpress.XtraGrid.Columns.GridColumn colBANCO1;
        private DevExpress.XtraGrid.Columns.GridColumn colSALDO;
        private DevExpress.XtraBars.Navigation.TabPane gdCtrolSaldosBXDiaIngresos;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavMovimientos;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavSaldos;
        private DevExpress.XtraGrid.GridControl gridSaldosBancarios;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView10;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colBANBAJIO;
        private DevExpress.XtraGrid.Columns.GridColumn colBANCOMER;
        private DevExpress.XtraGrid.Columns.GridColumn colBANORTE;
        private DevExpress.XtraGrid.Columns.GridColumn colHSBC;
        private DevExpress.XtraGrid.Columns.GridColumn colINBURSA;
        private DevExpress.XtraGrid.Columns.GridColumn colSANTANDER;
        private DevExpress.XtraGrid.Columns.GridColumn colSCOTIABANK;
        private DevExpress.XtraGrid.Columns.GridColumn colTOTAL;
        private dbSAICBPOTesoreriaDataSetTableAdapters.stpSelSaldosBancariosFinalTableAdapter stpSelSaldosBancariosFinalTableAdapter1;
        //private dbADNA_PENSION_MX_20240229DataSet dbADNA_PENSION_MX_20240229DataSet;
        private System.Windows.Forms.BindingSource dbADNAPENSIONMX20240229DataSetBindingSource;
        private System.Windows.Forms.BindingSource stpSelSaldosBancariosFinalBindingSource;
        private dbSAICBPOTesoreriaDataSetTableAdapters.stpSelSaldosBancariosFinalTableAdapter stpSelSaldosBancariosFinalTableAdapter2;
        private System.Windows.Forms.BindingSource stpSelSaldosBancariosFinalBindingSource2;
        private dbSAICBPOTesoreriaDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource tesSaldosLTDBindingSource;
        private dbSAICBPOTesoreriaDataSetTableAdapters.TesSaldosLTDTableAdapter tesSaldosLTDTableAdapter;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavSaldosXDia;
        private Asimilados.dbSAICAsimilados dbSAICAsimilados1;
        private dbSAICBPOTesoreriaDataSetTableAdapters.stpSelSaldosBancariosAlCierreXDiaTableAdapter stpSelSaldosBancariosAlCierreXDiaTableAdapter1;
        private System.Windows.Forms.BindingSource tesSaldosConceptoDiaMesBindingSource;
        private dbSAICBPOTesoreriaDataSetTableAdapters.TesSaldosConceptoDiaMesTableAdapter tesSaldosConceptoDiaMesTableAdapter;
        private DevExpress.XtraGrid.GridControl gdCtrolSaldosBXDia;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView11;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavSaldosXDiaIng;
        private DevExpress.XtraGrid.GridControl gdCtrolSaldosBXDiaIng;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView12;
        public DevExpress.XtraEditors.SpinEdit spAnoCorte;
        public DevExpress.XtraEditors.GridLookUpEdit cboMesCorte;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView13;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMes;
        private DevExpress.XtraGrid.Columns.GridColumn colDescMes;
        private DevExpress.XtraEditors.LabelControl lblAno;
        private DevExpress.XtraEditors.LabelControl lblMes;
        private dbSAICBPODataSetTableAdapters.stpSelMesTableAdapter stpSelMesTableAdapter1;
        private System.Windows.Forms.BindingSource stpSelMesBindingSource;
        private System.Windows.Forms.BindingSource tesSaldosLTDBindingSource1;
        private DevExpress.XtraEditors.SimpleButton btnExpSalBancario;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.SimpleButton btnConsultaLT;
        private DevExpress.XtraEditors.SimpleButton btnExpLineTiempo;
        private DevExpress.XtraEditors.SimpleButton btnExpSalBancarioxDiaIng;
        private DevExpress.XtraEditors.SimpleButton btnExpSalBancarioxDia;
        private System.Windows.Forms.Button button1;
        private dbSAICBPOTesoreriaDataSetTableAdapters.stpSelTenedoraLineaTiempovTableAdapter stpSelTenedoraLineaTiempovTableAdapter1;
        private System.Windows.Forms.BindingSource stpSelTenedoraLineaTiempovBindingSource;
        private dbSAICBPOActualizacionesDataSet dbSAICBPOActualizacionesDataSet;
        private System.Windows.Forms.BindingSource dbSAICBPOActualizacionesDataSetBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCheque;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnLote;
        private DevExpress.XtraGrid.Columns.GridColumn colTESORERO;
        private DevExpress.XtraGrid.Columns.GridColumn colTESORERO_;
    }
}