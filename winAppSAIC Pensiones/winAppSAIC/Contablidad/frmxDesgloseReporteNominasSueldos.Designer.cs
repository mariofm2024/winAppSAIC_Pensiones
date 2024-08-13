namespace winAppSAIC.Contablidad
{
    partial class frmxDesgloseReporteNominasSueldos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmxDesgloseReporteNominasSueldos));
            this.dbSAICBPOReportesDataSet = new winAppSAIC.dbSAICBPOReportesDataSet();
            this.stpSelReporteNominaSueldosSA_XLSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stpSelReporteNominaSueldosSA_XLSTableAdapter = new winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.stpSelReporteNominaSueldosSA_XLSTableAdapter();
            this.tableAdapterManager = new winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.TableAdapterManager();
            this.stpSelReporteNominaSueldosSA_XLSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.btnExportarXLS = new System.Windows.Forms.ToolStripButton();
            this.btnCerrarNominaContabilizada = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.stpSelReporteNominaSueldosSA_XLSGridControl = new DevExpress.XtraGrid.GridControl();
            this.cmExportarGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportarAExcelXLSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNombreEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNSS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCURP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoRecibo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiasPagar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSueldo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubsidio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubsidioIncapacidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComisiones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIncentivos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrimaDominical = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGratificación = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompensación = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBonoProductividad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRetroactivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAyudaporDefunción = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVacaciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrimaVacacional = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAguinaldo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIndemnización = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrimaAntigüedad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVales = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDespensa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPremiodeAsistencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPremiodePuntualidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAyudadeTransporte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAyudaVivienda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAyudaEducativa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCajadeAhorro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlimentación = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOtrasPercepciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMontoTotalPercepciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colISR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIMSS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRCV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInfonavit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSegurodeVivienda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCuotaSindical = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPensiónAlimenticia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescuentoAyudaporDefunción = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPréstamoFonacot = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAportaciónVoluntaria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPréstamo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOtros = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescuentoVales = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAnticipoSalarios = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPagosExcedentes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOtrasDeducciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAjustealNeto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMontoTotalDeducciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMontoNetoPagar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBancoDestino = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescTipoPeriodoNomina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPeriodoPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRazonSocialTenedora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHorasExtrasDobles = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHorasExtrasTiples = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonativos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstacionamiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPTU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCajaAhorroDeducción = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFondodeAhorro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMontoNetoPagarBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIncapacidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFondoAhorroDeduccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoCambio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMoneda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colISRporIndemnizacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIndemnizacion20diasporaño = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIndemnizacion90dias = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrestamoEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstadoTrabajo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pcFolioLoteCargaNomina = new DevExpress.XtraEditors.PanelControl();
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
            this.stpSelFolioLoteCargaNominaSABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPODataSet = new winAppSAIC.dbSAICBPODataSet();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenedora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOperador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblFolio = new DevExpress.XtraEditors.LabelControl();
            this.stpSelFolioLoteCargaNominaSATableAdapter = new winAppSAIC.dbSAICBPODataSetTableAdapters.stpSelFolioLoteCargaNominaSATableAdapter();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.sfdRutaArchivo = new System.Windows.Forms.SaveFileDialog();
            this.stpSelInfoDetalleLoteCargaNominaTableAdapter1 = new winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.stpSelInfoDetalleLoteCargaNominaTableAdapter();
            this.actualizacionesGeneralTableAdapter1 = new winAppSAIC.dbSAICBPOActualizacionesDataSetTableAdapters.ActualizacionesGeneralTableAdapter();
            this.stpSelValidarLoteCargaNominaEnSolicitudCancelacionNominaTableAdapter1 = new winAppSAIC.dbSAICBPOValidacionDataSetTableAdapters.stpSelValidarLoteCargaNominaEnSolicitudCancelacionNominaTableAdapter();
            this.dbSAICBPOValidacionDataSet1 = new winAppSAIC.dbSAICBPOValidacionDataSet();
            this.stpSelObtenerEstatusNominaSueldosVsTimbradoTableAdapter1 = new winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.stpSelObtenerEstatusNominaSueldosVsTimbradoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOReportesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelReporteNominaSueldosSA_XLSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelReporteNominaSueldosSA_XLSBindingNavigator)).BeginInit();
            this.stpSelReporteNominaSueldosSA_XLSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelReporteNominaSueldosSA_XLSGridControl)).BeginInit();
            this.cmExportarGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcFolioLoteCargaNomina)).BeginInit();
            this.pcFolioLoteCargaNomina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcResumenEstatusNominaVsTimbrados)).BeginInit();
            this.gcResumenEstatusNominaVsTimbrados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFechaPago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEstatusNominaContabilizada.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodoPago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreOperador.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoNomina.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreComercialCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreComercialTenedora.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFolioLoteCargaNomina.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelFolioLoteCargaNominaSABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOValidacionDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dbSAICBPOReportesDataSet
            // 
            this.dbSAICBPOReportesDataSet.DataSetName = "dbSAICBPOReportesDataSet";
            this.dbSAICBPOReportesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stpSelReporteNominaSueldosSA_XLSBindingSource
            // 
            this.stpSelReporteNominaSueldosSA_XLSBindingSource.DataMember = "stpSelReporteNominaSueldosSA_XLS";
            this.stpSelReporteNominaSueldosSA_XLSBindingSource.DataSource = this.dbSAICBPOReportesDataSet;
            // 
            // stpSelReporteNominaSueldosSA_XLSTableAdapter
            // 
            this.stpSelReporteNominaSueldosSA_XLSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.PDOHeaderSATableAdapter = null;
            this.tableAdapterManager.PDOHeaderSCTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // stpSelReporteNominaSueldosSA_XLSBindingNavigator
            // 
            this.stpSelReporteNominaSueldosSA_XLSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.stpSelReporteNominaSueldosSA_XLSBindingNavigator.BindingSource = this.stpSelReporteNominaSueldosSA_XLSBindingSource;
            this.stpSelReporteNominaSueldosSA_XLSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.stpSelReporteNominaSueldosSA_XLSBindingNavigator.CountItemFormat = "de {0}";
            this.stpSelReporteNominaSueldosSA_XLSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.stpSelReporteNominaSueldosSA_XLSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.btnExportarXLS,
            this.btnCerrarNominaContabilizada,
            this.toolStripSeparator1,
            this.btnSalir});
            this.stpSelReporteNominaSueldosSA_XLSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.stpSelReporteNominaSueldosSA_XLSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.stpSelReporteNominaSueldosSA_XLSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.stpSelReporteNominaSueldosSA_XLSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.stpSelReporteNominaSueldosSA_XLSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.stpSelReporteNominaSueldosSA_XLSBindingNavigator.Name = "stpSelReporteNominaSueldosSA_XLSBindingNavigator";
            this.stpSelReporteNominaSueldosSA_XLSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.stpSelReporteNominaSueldosSA_XLSBindingNavigator.Size = new System.Drawing.Size(942, 25);
            this.stpSelReporteNominaSueldosSA_XLSBindingNavigator.TabIndex = 0;
            this.stpSelReporteNominaSueldosSA_XLSBindingNavigator.Text = "bindingNavigator1";
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
            // btnExportarXLS
            // 
            this.btnExportarXLS.Image = global::winAppSAIC.Properties.Resources.xls32x32;
            this.btnExportarXLS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExportarXLS.Name = "btnExportarXLS";
            this.btnExportarXLS.Size = new System.Drawing.Size(138, 22);
            this.btnExportarXLS.Text = "Exportar a Excel (XLS)";
            this.btnExportarXLS.Click += new System.EventHandler(this.exportarAExcelXLSToolStripMenuItem_Click);
            // 
            // btnCerrarNominaContabilizada
            // 
            this.btnCerrarNominaContabilizada.Image = global::winAppSAIC.Properties.Resources._lock;
            this.btnCerrarNominaContabilizada.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCerrarNominaContabilizada.Name = "btnCerrarNominaContabilizada";
            this.btnCerrarNominaContabilizada.Size = new System.Drawing.Size(105, 22);
            this.btnCerrarNominaContabilizada.Text = "Cerrar Nómina";
            this.btnCerrarNominaContabilizada.Click += new System.EventHandler(this.btnCerrarNominaContabilizada_Click);
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
            // stpSelReporteNominaSueldosSA_XLSGridControl
            // 
            this.stpSelReporteNominaSueldosSA_XLSGridControl.ContextMenuStrip = this.cmExportarGrid;
            this.stpSelReporteNominaSueldosSA_XLSGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.stpSelReporteNominaSueldosSA_XLSGridControl.DataSource = this.stpSelReporteNominaSueldosSA_XLSBindingSource;
            this.stpSelReporteNominaSueldosSA_XLSGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stpSelReporteNominaSueldosSA_XLSGridControl.Location = new System.Drawing.Point(2, 2);
            this.stpSelReporteNominaSueldosSA_XLSGridControl.MainView = this.gridView1;
            this.stpSelReporteNominaSueldosSA_XLSGridControl.Name = "stpSelReporteNominaSueldosSA_XLSGridControl";
            this.stpSelReporteNominaSueldosSA_XLSGridControl.Size = new System.Drawing.Size(938, 362);
            this.stpSelReporteNominaSueldosSA_XLSGridControl.TabIndex = 2;
            this.stpSelReporteNominaSueldosSA_XLSGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // cmExportarGrid
            // 
            this.cmExportarGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarAExcelXLSToolStripMenuItem});
            this.cmExportarGrid.Name = "cmExportarGrid";
            this.cmExportarGrid.Size = new System.Drawing.Size(186, 26);
            // 
            // exportarAExcelXLSToolStripMenuItem
            // 
            this.exportarAExcelXLSToolStripMenuItem.Image = global::winAppSAIC.Properties.Resources.xls32x32;
            this.exportarAExcelXLSToolStripMenuItem.Name = "exportarAExcelXLSToolStripMenuItem";
            this.exportarAExcelXLSToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.exportarAExcelXLSToolStripMenuItem.Text = "Exportar a Excel (XLS)";
            this.exportarAExcelXLSToolStripMenuItem.Click += new System.EventHandler(this.exportarAExcelXLSToolStripMenuItem_Click);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNombreEmpleado,
            this.colNSS,
            this.colCURP,
            this.colNoRecibo,
            this.colSD,
            this.colSDI,
            this.colDiasPagar,
            this.colSueldo,
            this.colSubsidio,
            this.colSubsidioIncapacidad,
            this.colComisiones,
            this.colIncentivos,
            this.colPrimaDominical,
            this.gridColumn1,
            this.colGratificación,
            this.colCompensación,
            this.colBonoProductividad,
            this.colRetroactivo,
            this.colAyudaporDefunción,
            this.colVacaciones,
            this.colPrimaVacacional,
            this.colAguinaldo,
            this.colIndemnización,
            this.colPrimaAntigüedad,
            this.colVales,
            this.colDespensa,
            this.colPremiodeAsistencia,
            this.colPremiodePuntualidad,
            this.colAyudadeTransporte,
            this.colAyudaVivienda,
            this.colAyudaEducativa,
            this.colCajadeAhorro,
            this.colAlimentación,
            this.colOtrasPercepciones,
            this.colMontoTotalPercepciones,
            this.colISR,
            this.colIMSS,
            this.colRCV,
            this.colInfonavit,
            this.colSegurodeVivienda,
            this.colCuotaSindical,
            this.colPensiónAlimenticia,
            this.colDescuentoAyudaporDefunción,
            this.colPréstamoFonacot,
            this.colAportaciónVoluntaria,
            this.colPréstamo,
            this.colOtros,
            this.colDescuentoVales,
            this.colAnticipoSalarios,
            this.colPagosExcedentes,
            this.colOtrasDeducciones,
            this.colAjustealNeto,
            this.colMontoTotalDeducciones,
            this.colMontoNetoPagar,
            this.colTipoPago,
            this.colBancoDestino,
            this.colDescTipoPeriodoNomina,
            this.colPeriodoPago,
            this.colRazonSocialTenedora,
            this.colHorasExtrasDobles,
            this.colHorasExtrasTiples,
            this.colDonativos,
            this.colEstacionamiento,
            this.colPTU,
            this.colCajaAhorroDeducción,
            this.colFondodeAhorro,
            this.colMontoNetoPagarBanco,
            this.colIncapacidad,
            this.colFondoAhorroDeduccion,
            this.colTipoCambio,
            this.colIdMoneda,
            this.colISRporIndemnizacion,
            this.colIndemnizacion20diasporaño,
            this.colIndemnizacion90dias,
            this.colPrestamoEmpresa,
            this.colEstadoTrabajo});
            this.gridView1.GridControl = this.stpSelReporteNominaSueldosSA_XLSGridControl;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "RazonSocialTenedora", null, "")});
            this.gridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsPrint.AutoWidth = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupedColumns = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colMontoNetoPagarBanco, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colNombreEmpleado
            // 
            this.colNombreEmpleado.FieldName = "NombreEmpleado";
            this.colNombreEmpleado.Name = "colNombreEmpleado";
            this.colNombreEmpleado.OptionsColumn.AllowEdit = false;
            this.colNombreEmpleado.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colNombreEmpleado.OptionsColumn.AllowMove = false;
            this.colNombreEmpleado.OptionsColumn.AllowShowHide = false;
            this.colNombreEmpleado.OptionsColumn.FixedWidth = true;
            this.colNombreEmpleado.OptionsColumn.ReadOnly = true;
            this.colNombreEmpleado.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "NombreEmpleado", "No. de Empleados: {0:N0}")});
            this.colNombreEmpleado.Visible = true;
            this.colNombreEmpleado.VisibleIndex = 0;
            this.colNombreEmpleado.Width = 250;
            // 
            // colNSS
            // 
            this.colNSS.FieldName = "NSS";
            this.colNSS.Name = "colNSS";
            this.colNSS.OptionsColumn.AllowEdit = false;
            this.colNSS.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colNSS.OptionsColumn.AllowMove = false;
            this.colNSS.OptionsColumn.AllowShowHide = false;
            this.colNSS.OptionsColumn.FixedWidth = true;
            this.colNSS.OptionsColumn.ReadOnly = true;
            this.colNSS.Visible = true;
            this.colNSS.VisibleIndex = 1;
            this.colNSS.Width = 110;
            // 
            // colCURP
            // 
            this.colCURP.FieldName = "CURP";
            this.colCURP.Name = "colCURP";
            this.colCURP.OptionsColumn.AllowEdit = false;
            this.colCURP.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colCURP.OptionsColumn.AllowMove = false;
            this.colCURP.OptionsColumn.AllowShowHide = false;
            this.colCURP.OptionsColumn.FixedWidth = true;
            this.colCURP.OptionsColumn.ReadOnly = true;
            this.colCURP.Visible = true;
            this.colCURP.VisibleIndex = 2;
            this.colCURP.Width = 160;
            // 
            // colNoRecibo
            // 
            this.colNoRecibo.FieldName = "NoRecibo";
            this.colNoRecibo.Name = "colNoRecibo";
            this.colNoRecibo.OptionsColumn.AllowEdit = false;
            this.colNoRecibo.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colNoRecibo.OptionsColumn.ReadOnly = true;
            this.colNoRecibo.Visible = true;
            this.colNoRecibo.VisibleIndex = 3;
            // 
            // colSD
            // 
            this.colSD.DisplayFormat.FormatString = "C2";
            this.colSD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSD.FieldName = "SD";
            this.colSD.Name = "colSD";
            this.colSD.OptionsColumn.AllowEdit = false;
            this.colSD.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colSD.OptionsColumn.FixedWidth = true;
            this.colSD.OptionsColumn.ReadOnly = true;
            this.colSD.Visible = true;
            this.colSD.VisibleIndex = 4;
            this.colSD.Width = 60;
            // 
            // colSDI
            // 
            this.colSDI.DisplayFormat.FormatString = "C2";
            this.colSDI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSDI.FieldName = "SDI";
            this.colSDI.Name = "colSDI";
            this.colSDI.OptionsColumn.AllowEdit = false;
            this.colSDI.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colSDI.OptionsColumn.FixedWidth = true;
            this.colSDI.OptionsColumn.ReadOnly = true;
            this.colSDI.Visible = true;
            this.colSDI.VisibleIndex = 5;
            this.colSDI.Width = 60;
            // 
            // colDiasPagar
            // 
            this.colDiasPagar.DisplayFormat.FormatString = "N2";
            this.colDiasPagar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDiasPagar.FieldName = "DiasPagar";
            this.colDiasPagar.Name = "colDiasPagar";
            this.colDiasPagar.OptionsColumn.AllowEdit = false;
            this.colDiasPagar.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colDiasPagar.OptionsColumn.FixedWidth = true;
            this.colDiasPagar.OptionsColumn.ReadOnly = true;
            this.colDiasPagar.Visible = true;
            this.colDiasPagar.VisibleIndex = 6;
            this.colDiasPagar.Width = 60;
            // 
            // colSueldo
            // 
            this.colSueldo.DisplayFormat.FormatString = "C2";
            this.colSueldo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSueldo.FieldName = "Sueldo";
            this.colSueldo.Name = "colSueldo";
            this.colSueldo.OptionsColumn.AllowEdit = false;
            this.colSueldo.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colSueldo.OptionsColumn.FixedWidth = true;
            this.colSueldo.OptionsColumn.ReadOnly = true;
            this.colSueldo.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Sueldo", "{0:c2}")});
            this.colSueldo.Visible = true;
            this.colSueldo.VisibleIndex = 7;
            this.colSueldo.Width = 100;
            // 
            // colSubsidio
            // 
            this.colSubsidio.DisplayFormat.FormatString = "C2";
            this.colSubsidio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSubsidio.FieldName = "Subsidio";
            this.colSubsidio.Name = "colSubsidio";
            this.colSubsidio.OptionsColumn.AllowEdit = false;
            this.colSubsidio.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colSubsidio.OptionsColumn.FixedWidth = true;
            this.colSubsidio.OptionsColumn.ReadOnly = true;
            this.colSubsidio.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Subsidio", "{0:c2}")});
            this.colSubsidio.Visible = true;
            this.colSubsidio.VisibleIndex = 8;
            this.colSubsidio.Width = 100;
            // 
            // colSubsidioIncapacidad
            // 
            this.colSubsidioIncapacidad.DisplayFormat.FormatString = "C2";
            this.colSubsidioIncapacidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSubsidioIncapacidad.FieldName = "Subsidio Incapacidad";
            this.colSubsidioIncapacidad.Name = "colSubsidioIncapacidad";
            this.colSubsidioIncapacidad.OptionsColumn.AllowEdit = false;
            this.colSubsidioIncapacidad.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colSubsidioIncapacidad.OptionsColumn.FixedWidth = true;
            this.colSubsidioIncapacidad.OptionsColumn.ReadOnly = true;
            this.colSubsidioIncapacidad.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Subsidio Incapacidad", "{0:c2}")});
            this.colSubsidioIncapacidad.Visible = true;
            this.colSubsidioIncapacidad.VisibleIndex = 29;
            this.colSubsidioIncapacidad.Width = 109;
            // 
            // colComisiones
            // 
            this.colComisiones.DisplayFormat.FormatString = "C2";
            this.colComisiones.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colComisiones.FieldName = "Comisiones";
            this.colComisiones.Name = "colComisiones";
            this.colComisiones.OptionsColumn.AllowEdit = false;
            this.colComisiones.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colComisiones.OptionsColumn.FixedWidth = true;
            this.colComisiones.OptionsColumn.ReadOnly = true;
            this.colComisiones.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Comisiones", "{0:C2}")});
            this.colComisiones.Visible = true;
            this.colComisiones.VisibleIndex = 9;
            this.colComisiones.Width = 85;
            // 
            // colIncentivos
            // 
            this.colIncentivos.DisplayFormat.FormatString = "C2";
            this.colIncentivos.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colIncentivos.FieldName = "Incentivos";
            this.colIncentivos.Name = "colIncentivos";
            this.colIncentivos.OptionsColumn.AllowEdit = false;
            this.colIncentivos.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colIncentivos.OptionsColumn.FixedWidth = true;
            this.colIncentivos.OptionsColumn.ReadOnly = true;
            this.colIncentivos.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Incentivos", "{0:C2}")});
            this.colIncentivos.Visible = true;
            this.colIncentivos.VisibleIndex = 10;
            this.colIncentivos.Width = 85;
            // 
            // colPrimaDominical
            // 
            this.colPrimaDominical.DisplayFormat.FormatString = "C2";
            this.colPrimaDominical.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrimaDominical.FieldName = "Prima Dominical";
            this.colPrimaDominical.Name = "colPrimaDominical";
            this.colPrimaDominical.OptionsColumn.AllowEdit = false;
            this.colPrimaDominical.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colPrimaDominical.OptionsColumn.FixedWidth = true;
            this.colPrimaDominical.OptionsColumn.ReadOnly = true;
            this.colPrimaDominical.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Prima Dominical", "{0:C2}")});
            this.colPrimaDominical.Visible = true;
            this.colPrimaDominical.VisibleIndex = 11;
            this.colPrimaDominical.Width = 85;
            // 
            // gridColumn1
            // 
            this.gridColumn1.DisplayFormat.FormatString = "C2";
            this.gridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn1.FieldName = "Día Festivo-Descanso";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn1.OptionsColumn.FixedWidth = true;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Día Festivo-Descanso", "{0:C2}")});
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 12;
            this.gridColumn1.Width = 100;
            // 
            // colGratificación
            // 
            this.colGratificación.DisplayFormat.FormatString = "C2";
            this.colGratificación.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colGratificación.FieldName = "Gratificación";
            this.colGratificación.Name = "colGratificación";
            this.colGratificación.OptionsColumn.AllowEdit = false;
            this.colGratificación.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colGratificación.OptionsColumn.FixedWidth = true;
            this.colGratificación.OptionsColumn.ReadOnly = true;
            this.colGratificación.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Gratificación", "{0:C2}")});
            this.colGratificación.Visible = true;
            this.colGratificación.VisibleIndex = 13;
            this.colGratificación.Width = 85;
            // 
            // colCompensación
            // 
            this.colCompensación.DisplayFormat.FormatString = "C2";
            this.colCompensación.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCompensación.FieldName = "Compensación";
            this.colCompensación.Name = "colCompensación";
            this.colCompensación.OptionsColumn.AllowEdit = false;
            this.colCompensación.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colCompensación.OptionsColumn.FixedWidth = true;
            this.colCompensación.OptionsColumn.ReadOnly = true;
            this.colCompensación.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Compensación", "{0:C2}")});
            this.colCompensación.Visible = true;
            this.colCompensación.VisibleIndex = 14;
            this.colCompensación.Width = 85;
            // 
            // colBonoProductividad
            // 
            this.colBonoProductividad.DisplayFormat.FormatString = "C2";
            this.colBonoProductividad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBonoProductividad.FieldName = "Bono Productividad";
            this.colBonoProductividad.Name = "colBonoProductividad";
            this.colBonoProductividad.OptionsColumn.AllowEdit = false;
            this.colBonoProductividad.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colBonoProductividad.OptionsColumn.FixedWidth = true;
            this.colBonoProductividad.OptionsColumn.ReadOnly = true;
            this.colBonoProductividad.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Bono Productividad", "{0:C2}")});
            this.colBonoProductividad.Visible = true;
            this.colBonoProductividad.VisibleIndex = 15;
            this.colBonoProductividad.Width = 100;
            // 
            // colRetroactivo
            // 
            this.colRetroactivo.DisplayFormat.FormatString = "C2";
            this.colRetroactivo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colRetroactivo.FieldName = "Retroactivo";
            this.colRetroactivo.Name = "colRetroactivo";
            this.colRetroactivo.OptionsColumn.AllowEdit = false;
            this.colRetroactivo.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colRetroactivo.OptionsColumn.FixedWidth = true;
            this.colRetroactivo.OptionsColumn.ReadOnly = true;
            this.colRetroactivo.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Retroactivo", "{0:C2}")});
            this.colRetroactivo.Visible = true;
            this.colRetroactivo.VisibleIndex = 16;
            this.colRetroactivo.Width = 85;
            // 
            // colAyudaporDefunción
            // 
            this.colAyudaporDefunción.DisplayFormat.FormatString = "C2";
            this.colAyudaporDefunción.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAyudaporDefunción.FieldName = "Ayuda por Defunción";
            this.colAyudaporDefunción.Name = "colAyudaporDefunción";
            this.colAyudaporDefunción.OptionsColumn.AllowEdit = false;
            this.colAyudaporDefunción.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colAyudaporDefunción.OptionsColumn.FixedWidth = true;
            this.colAyudaporDefunción.OptionsColumn.ReadOnly = true;
            this.colAyudaporDefunción.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Ayuda por Defunción", "{0:C2}")});
            this.colAyudaporDefunción.Visible = true;
            this.colAyudaporDefunción.VisibleIndex = 32;
            this.colAyudaporDefunción.Width = 115;
            // 
            // colVacaciones
            // 
            this.colVacaciones.DisplayFormat.FormatString = "C2";
            this.colVacaciones.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colVacaciones.FieldName = "Vacaciones";
            this.colVacaciones.Name = "colVacaciones";
            this.colVacaciones.OptionsColumn.AllowEdit = false;
            this.colVacaciones.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colVacaciones.OptionsColumn.FixedWidth = true;
            this.colVacaciones.OptionsColumn.ReadOnly = true;
            this.colVacaciones.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Vacaciones", "{0:C2}")});
            this.colVacaciones.Visible = true;
            this.colVacaciones.VisibleIndex = 17;
            this.colVacaciones.Width = 85;
            // 
            // colPrimaVacacional
            // 
            this.colPrimaVacacional.DisplayFormat.FormatString = "C2";
            this.colPrimaVacacional.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrimaVacacional.FieldName = "Prima Vacacional";
            this.colPrimaVacacional.Name = "colPrimaVacacional";
            this.colPrimaVacacional.OptionsColumn.AllowEdit = false;
            this.colPrimaVacacional.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colPrimaVacacional.OptionsColumn.FixedWidth = true;
            this.colPrimaVacacional.OptionsColumn.ReadOnly = true;
            this.colPrimaVacacional.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Prima Vacacional", "{0:C2}")});
            this.colPrimaVacacional.Visible = true;
            this.colPrimaVacacional.VisibleIndex = 18;
            this.colPrimaVacacional.Width = 85;
            // 
            // colAguinaldo
            // 
            this.colAguinaldo.DisplayFormat.FormatString = "C2";
            this.colAguinaldo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAguinaldo.FieldName = "Aguinaldo";
            this.colAguinaldo.Name = "colAguinaldo";
            this.colAguinaldo.OptionsColumn.AllowEdit = false;
            this.colAguinaldo.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colAguinaldo.OptionsColumn.FixedWidth = true;
            this.colAguinaldo.OptionsColumn.ReadOnly = true;
            this.colAguinaldo.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Aguinaldo", "{0:C2}")});
            this.colAguinaldo.Visible = true;
            this.colAguinaldo.VisibleIndex = 19;
            this.colAguinaldo.Width = 85;
            // 
            // colIndemnización
            // 
            this.colIndemnización.DisplayFormat.FormatString = "C2";
            this.colIndemnización.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colIndemnización.FieldName = "Indemnización";
            this.colIndemnización.Name = "colIndemnización";
            this.colIndemnización.OptionsColumn.AllowEdit = false;
            this.colIndemnización.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colIndemnización.OptionsColumn.FixedWidth = true;
            this.colIndemnización.OptionsColumn.ReadOnly = true;
            this.colIndemnización.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Indemnización", "{0:C2}")});
            this.colIndemnización.Visible = true;
            this.colIndemnización.VisibleIndex = 20;
            this.colIndemnización.Width = 85;
            // 
            // colPrimaAntigüedad
            // 
            this.colPrimaAntigüedad.DisplayFormat.FormatString = "C2";
            this.colPrimaAntigüedad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrimaAntigüedad.FieldName = "Prima Antigüedad";
            this.colPrimaAntigüedad.Name = "colPrimaAntigüedad";
            this.colPrimaAntigüedad.OptionsColumn.AllowEdit = false;
            this.colPrimaAntigüedad.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colPrimaAntigüedad.OptionsColumn.FixedWidth = true;
            this.colPrimaAntigüedad.OptionsColumn.ReadOnly = true;
            this.colPrimaAntigüedad.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Prima Antigüedad", "{0:C2}")});
            this.colPrimaAntigüedad.Visible = true;
            this.colPrimaAntigüedad.VisibleIndex = 21;
            this.colPrimaAntigüedad.Width = 100;
            // 
            // colVales
            // 
            this.colVales.DisplayFormat.FormatString = "C2";
            this.colVales.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colVales.FieldName = "Vales";
            this.colVales.Name = "colVales";
            this.colVales.OptionsColumn.AllowEdit = false;
            this.colVales.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colVales.OptionsColumn.FixedWidth = true;
            this.colVales.OptionsColumn.ReadOnly = true;
            this.colVales.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Vales", "{0:C2}")});
            this.colVales.Visible = true;
            this.colVales.VisibleIndex = 30;
            this.colVales.Width = 85;
            // 
            // colDespensa
            // 
            this.colDespensa.DisplayFormat.FormatString = "C2";
            this.colDespensa.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDespensa.FieldName = "Despensa";
            this.colDespensa.Name = "colDespensa";
            this.colDespensa.OptionsColumn.AllowEdit = false;
            this.colDespensa.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colDespensa.OptionsColumn.FixedWidth = true;
            this.colDespensa.OptionsColumn.ReadOnly = true;
            this.colDespensa.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Despensa", "{0:C2}")});
            this.colDespensa.Visible = true;
            this.colDespensa.VisibleIndex = 31;
            this.colDespensa.Width = 85;
            // 
            // colPremiodeAsistencia
            // 
            this.colPremiodeAsistencia.DisplayFormat.FormatString = "C2";
            this.colPremiodeAsistencia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPremiodeAsistencia.FieldName = "Premio de Asistencia";
            this.colPremiodeAsistencia.Name = "colPremiodeAsistencia";
            this.colPremiodeAsistencia.OptionsColumn.AllowEdit = false;
            this.colPremiodeAsistencia.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colPremiodeAsistencia.OptionsColumn.FixedWidth = true;
            this.colPremiodeAsistencia.OptionsColumn.ReadOnly = true;
            this.colPremiodeAsistencia.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Premio de Asistencia", "{0:C2}")});
            this.colPremiodeAsistencia.Visible = true;
            this.colPremiodeAsistencia.VisibleIndex = 22;
            this.colPremiodeAsistencia.Width = 100;
            // 
            // colPremiodePuntualidad
            // 
            this.colPremiodePuntualidad.DisplayFormat.FormatString = "C2";
            this.colPremiodePuntualidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPremiodePuntualidad.FieldName = "Premio de Puntualidad";
            this.colPremiodePuntualidad.Name = "colPremiodePuntualidad";
            this.colPremiodePuntualidad.OptionsColumn.AllowEdit = false;
            this.colPremiodePuntualidad.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colPremiodePuntualidad.OptionsColumn.FixedWidth = true;
            this.colPremiodePuntualidad.OptionsColumn.ReadOnly = true;
            this.colPremiodePuntualidad.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Premio de Puntualidad", "{0:C2}")});
            this.colPremiodePuntualidad.Visible = true;
            this.colPremiodePuntualidad.VisibleIndex = 23;
            this.colPremiodePuntualidad.Width = 117;
            // 
            // colAyudadeTransporte
            // 
            this.colAyudadeTransporte.DisplayFormat.FormatString = "C2";
            this.colAyudadeTransporte.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAyudadeTransporte.FieldName = "Ayuda de Transporte";
            this.colAyudadeTransporte.Name = "colAyudadeTransporte";
            this.colAyudadeTransporte.OptionsColumn.AllowEdit = false;
            this.colAyudadeTransporte.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colAyudadeTransporte.OptionsColumn.FixedWidth = true;
            this.colAyudadeTransporte.OptionsColumn.ReadOnly = true;
            this.colAyudadeTransporte.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Ayuda de Transporte", "{0:C2}")});
            this.colAyudadeTransporte.Visible = true;
            this.colAyudadeTransporte.VisibleIndex = 33;
            this.colAyudadeTransporte.Width = 124;
            // 
            // colAyudaVivienda
            // 
            this.colAyudaVivienda.DisplayFormat.FormatString = "C2";
            this.colAyudaVivienda.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAyudaVivienda.FieldName = "Ayuda Vivienda";
            this.colAyudaVivienda.Name = "colAyudaVivienda";
            this.colAyudaVivienda.OptionsColumn.AllowEdit = false;
            this.colAyudaVivienda.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colAyudaVivienda.OptionsColumn.FixedWidth = true;
            this.colAyudaVivienda.OptionsColumn.ReadOnly = true;
            this.colAyudaVivienda.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Ayuda Vivienda", "{0:c2}")});
            this.colAyudaVivienda.Visible = true;
            this.colAyudaVivienda.VisibleIndex = 34;
            this.colAyudaVivienda.Width = 100;
            // 
            // colAyudaEducativa
            // 
            this.colAyudaEducativa.DisplayFormat.FormatString = "C2";
            this.colAyudaEducativa.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAyudaEducativa.FieldName = "Ayuda Educativa";
            this.colAyudaEducativa.Name = "colAyudaEducativa";
            this.colAyudaEducativa.OptionsColumn.AllowEdit = false;
            this.colAyudaEducativa.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colAyudaEducativa.OptionsColumn.FixedWidth = true;
            this.colAyudaEducativa.OptionsColumn.ReadOnly = true;
            this.colAyudaEducativa.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Ayuda Educativa", "{0:c2}")});
            this.colAyudaEducativa.Visible = true;
            this.colAyudaEducativa.VisibleIndex = 35;
            this.colAyudaEducativa.Width = 100;
            // 
            // colCajadeAhorro
            // 
            this.colCajadeAhorro.DisplayFormat.FormatString = "C2";
            this.colCajadeAhorro.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCajadeAhorro.FieldName = "Caja de Ahorro";
            this.colCajadeAhorro.Name = "colCajadeAhorro";
            this.colCajadeAhorro.OptionsColumn.AllowEdit = false;
            this.colCajadeAhorro.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colCajadeAhorro.OptionsColumn.FixedWidth = true;
            this.colCajadeAhorro.OptionsColumn.ReadOnly = true;
            this.colCajadeAhorro.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Caja de Ahorro", "{0:c2}")});
            this.colCajadeAhorro.Visible = true;
            this.colCajadeAhorro.VisibleIndex = 26;
            this.colCajadeAhorro.Width = 100;
            // 
            // colAlimentación
            // 
            this.colAlimentación.DisplayFormat.FormatString = "C2";
            this.colAlimentación.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAlimentación.FieldName = "Alimentación";
            this.colAlimentación.Name = "colAlimentación";
            this.colAlimentación.OptionsColumn.AllowEdit = false;
            this.colAlimentación.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colAlimentación.OptionsColumn.FixedWidth = true;
            this.colAlimentación.OptionsColumn.ReadOnly = true;
            this.colAlimentación.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Alimentación", "{0:C2}")});
            this.colAlimentación.Visible = true;
            this.colAlimentación.VisibleIndex = 37;
            this.colAlimentación.Width = 85;
            // 
            // colOtrasPercepciones
            // 
            this.colOtrasPercepciones.DisplayFormat.FormatString = "C2";
            this.colOtrasPercepciones.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOtrasPercepciones.FieldName = "Otras Percepciones";
            this.colOtrasPercepciones.Name = "colOtrasPercepciones";
            this.colOtrasPercepciones.OptionsColumn.AllowEdit = false;
            this.colOtrasPercepciones.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colOtrasPercepciones.OptionsColumn.FixedWidth = true;
            this.colOtrasPercepciones.OptionsColumn.ReadOnly = true;
            this.colOtrasPercepciones.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Otras Percepciones", "{0:c2}")});
            this.colOtrasPercepciones.Visible = true;
            this.colOtrasPercepciones.VisibleIndex = 27;
            this.colOtrasPercepciones.Width = 110;
            // 
            // colMontoTotalPercepciones
            // 
            this.colMontoTotalPercepciones.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMontoTotalPercepciones.AppearanceCell.Options.UseFont = true;
            this.colMontoTotalPercepciones.Caption = "Total Percepciones";
            this.colMontoTotalPercepciones.DisplayFormat.FormatString = "C2";
            this.colMontoTotalPercepciones.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMontoTotalPercepciones.FieldName = "MontoTotalPercepciones";
            this.colMontoTotalPercepciones.Name = "colMontoTotalPercepciones";
            this.colMontoTotalPercepciones.OptionsColumn.AllowEdit = false;
            this.colMontoTotalPercepciones.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colMontoTotalPercepciones.OptionsColumn.FixedWidth = true;
            this.colMontoTotalPercepciones.OptionsColumn.ReadOnly = true;
            this.colMontoTotalPercepciones.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MontoTotalPercepciones", "{0:C2}")});
            this.colMontoTotalPercepciones.Visible = true;
            this.colMontoTotalPercepciones.VisibleIndex = 41;
            this.colMontoTotalPercepciones.Width = 110;
            // 
            // colISR
            // 
            this.colISR.DisplayFormat.FormatString = "C2";
            this.colISR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colISR.FieldName = "ISR";
            this.colISR.Name = "colISR";
            this.colISR.OptionsColumn.AllowEdit = false;
            this.colISR.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colISR.OptionsColumn.FixedWidth = true;
            this.colISR.OptionsColumn.ReadOnly = true;
            this.colISR.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ISR", "{0:C2}")});
            this.colISR.Visible = true;
            this.colISR.VisibleIndex = 42;
            this.colISR.Width = 85;
            // 
            // colIMSS
            // 
            this.colIMSS.DisplayFormat.FormatString = "C2";
            this.colIMSS.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colIMSS.FieldName = "IMSS";
            this.colIMSS.Name = "colIMSS";
            this.colIMSS.OptionsColumn.AllowEdit = false;
            this.colIMSS.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colIMSS.OptionsColumn.FixedWidth = true;
            this.colIMSS.OptionsColumn.ReadOnly = true;
            this.colIMSS.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "IMSS", "{0:C2}")});
            this.colIMSS.Visible = true;
            this.colIMSS.VisibleIndex = 43;
            this.colIMSS.Width = 85;
            // 
            // colRCV
            // 
            this.colRCV.DisplayFormat.FormatString = "C2";
            this.colRCV.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colRCV.FieldName = "RCV";
            this.colRCV.Name = "colRCV";
            this.colRCV.OptionsColumn.AllowEdit = false;
            this.colRCV.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colRCV.OptionsColumn.FixedWidth = true;
            this.colRCV.OptionsColumn.ReadOnly = true;
            this.colRCV.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RCV", "{0:C2}")});
            this.colRCV.Visible = true;
            this.colRCV.VisibleIndex = 44;
            this.colRCV.Width = 85;
            // 
            // colInfonavit
            // 
            this.colInfonavit.DisplayFormat.FormatString = "C2";
            this.colInfonavit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colInfonavit.FieldName = "Infonavit";
            this.colInfonavit.Name = "colInfonavit";
            this.colInfonavit.OptionsColumn.AllowEdit = false;
            this.colInfonavit.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colInfonavit.OptionsColumn.FixedWidth = true;
            this.colInfonavit.OptionsColumn.ReadOnly = true;
            this.colInfonavit.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Infonavit", "{0:C2}")});
            this.colInfonavit.Visible = true;
            this.colInfonavit.VisibleIndex = 45;
            this.colInfonavit.Width = 85;
            // 
            // colSegurodeVivienda
            // 
            this.colSegurodeVivienda.DisplayFormat.FormatString = "C2";
            this.colSegurodeVivienda.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSegurodeVivienda.FieldName = "Seguro de Vivienda";
            this.colSegurodeVivienda.Name = "colSegurodeVivienda";
            this.colSegurodeVivienda.OptionsColumn.AllowEdit = false;
            this.colSegurodeVivienda.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colSegurodeVivienda.OptionsColumn.FixedWidth = true;
            this.colSegurodeVivienda.OptionsColumn.ReadOnly = true;
            this.colSegurodeVivienda.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Seguro de Vivienda", "{0:C2}")});
            this.colSegurodeVivienda.Visible = true;
            this.colSegurodeVivienda.VisibleIndex = 46;
            this.colSegurodeVivienda.Width = 100;
            // 
            // colCuotaSindical
            // 
            this.colCuotaSindical.DisplayFormat.FormatString = "C2";
            this.colCuotaSindical.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCuotaSindical.FieldName = "Cuota Sindical";
            this.colCuotaSindical.Name = "colCuotaSindical";
            this.colCuotaSindical.OptionsColumn.AllowEdit = false;
            this.colCuotaSindical.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colCuotaSindical.OptionsColumn.FixedWidth = true;
            this.colCuotaSindical.OptionsColumn.ReadOnly = true;
            this.colCuotaSindical.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Cuota Sindical", "{0:C2}")});
            this.colCuotaSindical.Visible = true;
            this.colCuotaSindical.VisibleIndex = 47;
            this.colCuotaSindical.Width = 100;
            // 
            // colPensiónAlimenticia
            // 
            this.colPensiónAlimenticia.DisplayFormat.FormatString = "C2";
            this.colPensiónAlimenticia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPensiónAlimenticia.FieldName = "Pensión Alimenticia";
            this.colPensiónAlimenticia.Name = "colPensiónAlimenticia";
            this.colPensiónAlimenticia.OptionsColumn.AllowEdit = false;
            this.colPensiónAlimenticia.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colPensiónAlimenticia.OptionsColumn.FixedWidth = true;
            this.colPensiónAlimenticia.OptionsColumn.ReadOnly = true;
            this.colPensiónAlimenticia.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Pensión Alimenticia", "{0:C2}")});
            this.colPensiónAlimenticia.Visible = true;
            this.colPensiónAlimenticia.VisibleIndex = 48;
            this.colPensiónAlimenticia.Width = 100;
            // 
            // colDescuentoAyudaporDefunción
            // 
            this.colDescuentoAyudaporDefunción.DisplayFormat.FormatString = "C2";
            this.colDescuentoAyudaporDefunción.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDescuentoAyudaporDefunción.FieldName = "Descuento Ayuda por Defunción";
            this.colDescuentoAyudaporDefunción.Name = "colDescuentoAyudaporDefunción";
            this.colDescuentoAyudaporDefunción.OptionsColumn.AllowEdit = false;
            this.colDescuentoAyudaporDefunción.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colDescuentoAyudaporDefunción.OptionsColumn.FixedWidth = true;
            this.colDescuentoAyudaporDefunción.OptionsColumn.ReadOnly = true;
            this.colDescuentoAyudaporDefunción.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Descuento Ayuda por Defunción", "{0:C2}")});
            this.colDescuentoAyudaporDefunción.Visible = true;
            this.colDescuentoAyudaporDefunción.VisibleIndex = 49;
            this.colDescuentoAyudaporDefunción.Width = 170;
            // 
            // colPréstamoFonacot
            // 
            this.colPréstamoFonacot.DisplayFormat.FormatString = "C2";
            this.colPréstamoFonacot.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPréstamoFonacot.FieldName = "Préstamo Fonacot";
            this.colPréstamoFonacot.Name = "colPréstamoFonacot";
            this.colPréstamoFonacot.OptionsColumn.AllowEdit = false;
            this.colPréstamoFonacot.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colPréstamoFonacot.OptionsColumn.FixedWidth = true;
            this.colPréstamoFonacot.OptionsColumn.ReadOnly = true;
            this.colPréstamoFonacot.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Préstamo Fonacot", "{0:C2}")});
            this.colPréstamoFonacot.Visible = true;
            this.colPréstamoFonacot.VisibleIndex = 50;
            this.colPréstamoFonacot.Width = 100;
            // 
            // colAportaciónVoluntaria
            // 
            this.colAportaciónVoluntaria.DisplayFormat.FormatString = "C2";
            this.colAportaciónVoluntaria.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAportaciónVoluntaria.FieldName = "Aportación Voluntaria";
            this.colAportaciónVoluntaria.Name = "colAportaciónVoluntaria";
            this.colAportaciónVoluntaria.OptionsColumn.AllowEdit = false;
            this.colAportaciónVoluntaria.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colAportaciónVoluntaria.OptionsColumn.FixedWidth = true;
            this.colAportaciónVoluntaria.OptionsColumn.ReadOnly = true;
            this.colAportaciónVoluntaria.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Aportación Voluntaria", "{0:C2}")});
            this.colAportaciónVoluntaria.Visible = true;
            this.colAportaciónVoluntaria.VisibleIndex = 51;
            this.colAportaciónVoluntaria.Width = 131;
            // 
            // colPréstamo
            // 
            this.colPréstamo.DisplayFormat.FormatString = "C2";
            this.colPréstamo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPréstamo.FieldName = "Préstamo";
            this.colPréstamo.Name = "colPréstamo";
            this.colPréstamo.OptionsColumn.AllowEdit = false;
            this.colPréstamo.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colPréstamo.OptionsColumn.FixedWidth = true;
            this.colPréstamo.OptionsColumn.ReadOnly = true;
            this.colPréstamo.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Préstamo", "{0:C2}")});
            this.colPréstamo.Visible = true;
            this.colPréstamo.VisibleIndex = 52;
            this.colPréstamo.Width = 85;
            // 
            // colOtros
            // 
            this.colOtros.DisplayFormat.FormatString = "C2";
            this.colOtros.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOtros.FieldName = "Otros";
            this.colOtros.Name = "colOtros";
            this.colOtros.OptionsColumn.AllowEdit = false;
            this.colOtros.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colOtros.OptionsColumn.FixedWidth = true;
            this.colOtros.OptionsColumn.ReadOnly = true;
            this.colOtros.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Otros", "{0:C2}")});
            this.colOtros.Visible = true;
            this.colOtros.VisibleIndex = 53;
            this.colOtros.Width = 120;
            // 
            // colDescuentoVales
            // 
            this.colDescuentoVales.DisplayFormat.FormatString = "C2";
            this.colDescuentoVales.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDescuentoVales.FieldName = "Descuento Vales";
            this.colDescuentoVales.Name = "colDescuentoVales";
            this.colDescuentoVales.OptionsColumn.AllowEdit = false;
            this.colDescuentoVales.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colDescuentoVales.OptionsColumn.FixedWidth = true;
            this.colDescuentoVales.OptionsColumn.ReadOnly = true;
            this.colDescuentoVales.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Descuento Vales", "{0:C2}")});
            this.colDescuentoVales.Visible = true;
            this.colDescuentoVales.VisibleIndex = 54;
            this.colDescuentoVales.Width = 110;
            // 
            // colAnticipoSalarios
            // 
            this.colAnticipoSalarios.DisplayFormat.FormatString = "C2";
            this.colAnticipoSalarios.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAnticipoSalarios.FieldName = "Anticipo Salarios";
            this.colAnticipoSalarios.Name = "colAnticipoSalarios";
            this.colAnticipoSalarios.OptionsColumn.AllowEdit = false;
            this.colAnticipoSalarios.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colAnticipoSalarios.OptionsColumn.FixedWidth = true;
            this.colAnticipoSalarios.OptionsColumn.ReadOnly = true;
            this.colAnticipoSalarios.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Anticipo Salarios", "{0:C2}")});
            this.colAnticipoSalarios.Visible = true;
            this.colAnticipoSalarios.VisibleIndex = 57;
            this.colAnticipoSalarios.Width = 100;
            // 
            // colPagosExcedentes
            // 
            this.colPagosExcedentes.DisplayFormat.FormatString = "C2";
            this.colPagosExcedentes.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPagosExcedentes.FieldName = "Pagos Excedentes";
            this.colPagosExcedentes.Name = "colPagosExcedentes";
            this.colPagosExcedentes.OptionsColumn.AllowEdit = false;
            this.colPagosExcedentes.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colPagosExcedentes.OptionsColumn.FixedWidth = true;
            this.colPagosExcedentes.OptionsColumn.ReadOnly = true;
            this.colPagosExcedentes.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Pagos Excedentes", "{0:C2}")});
            this.colPagosExcedentes.Visible = true;
            this.colPagosExcedentes.VisibleIndex = 58;
            this.colPagosExcedentes.Width = 100;
            // 
            // colOtrasDeducciones
            // 
            this.colOtrasDeducciones.DisplayFormat.FormatString = "C2";
            this.colOtrasDeducciones.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOtrasDeducciones.FieldName = "Otras Deducciones";
            this.colOtrasDeducciones.Name = "colOtrasDeducciones";
            this.colOtrasDeducciones.OptionsColumn.AllowEdit = false;
            this.colOtrasDeducciones.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colOtrasDeducciones.OptionsColumn.FixedWidth = true;
            this.colOtrasDeducciones.OptionsColumn.ReadOnly = true;
            this.colOtrasDeducciones.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Otras Deducciones", "{0:C2}")});
            this.colOtrasDeducciones.Visible = true;
            this.colOtrasDeducciones.VisibleIndex = 61;
            this.colOtrasDeducciones.Width = 100;
            // 
            // colAjustealNeto
            // 
            this.colAjustealNeto.DisplayFormat.FormatString = "C2";
            this.colAjustealNeto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAjustealNeto.FieldName = "Ajuste al Neto";
            this.colAjustealNeto.Name = "colAjustealNeto";
            this.colAjustealNeto.OptionsColumn.AllowEdit = false;
            this.colAjustealNeto.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colAjustealNeto.OptionsColumn.FixedWidth = true;
            this.colAjustealNeto.OptionsColumn.ReadOnly = true;
            this.colAjustealNeto.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Ajuste al Neto", "{0:C2}")});
            this.colAjustealNeto.Visible = true;
            this.colAjustealNeto.VisibleIndex = 62;
            this.colAjustealNeto.Width = 100;
            // 
            // colMontoTotalDeducciones
            // 
            this.colMontoTotalDeducciones.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMontoTotalDeducciones.AppearanceCell.Options.UseFont = true;
            this.colMontoTotalDeducciones.Caption = "Total Deducciones";
            this.colMontoTotalDeducciones.DisplayFormat.FormatString = "C2";
            this.colMontoTotalDeducciones.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMontoTotalDeducciones.FieldName = "MontoTotalDeducciones";
            this.colMontoTotalDeducciones.Name = "colMontoTotalDeducciones";
            this.colMontoTotalDeducciones.OptionsColumn.AllowEdit = false;
            this.colMontoTotalDeducciones.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colMontoTotalDeducciones.OptionsColumn.FixedWidth = true;
            this.colMontoTotalDeducciones.OptionsColumn.ReadOnly = true;
            this.colMontoTotalDeducciones.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MontoTotalDeducciones", "{0:C2}")});
            this.colMontoTotalDeducciones.Visible = true;
            this.colMontoTotalDeducciones.VisibleIndex = 65;
            this.colMontoTotalDeducciones.Width = 110;
            // 
            // colMontoNetoPagar
            // 
            this.colMontoNetoPagar.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMontoNetoPagar.AppearanceCell.Options.UseFont = true;
            this.colMontoNetoPagar.Caption = "Monto Neto Pagar";
            this.colMontoNetoPagar.DisplayFormat.FormatString = "C2";
            this.colMontoNetoPagar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMontoNetoPagar.FieldName = "MontoNetoPagar";
            this.colMontoNetoPagar.Name = "colMontoNetoPagar";
            this.colMontoNetoPagar.OptionsColumn.AllowEdit = false;
            this.colMontoNetoPagar.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colMontoNetoPagar.OptionsColumn.FixedWidth = true;
            this.colMontoNetoPagar.OptionsColumn.ReadOnly = true;
            this.colMontoNetoPagar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MontoNetoPagar", "{0:C2}")});
            this.colMontoNetoPagar.Visible = true;
            this.colMontoNetoPagar.VisibleIndex = 66;
            this.colMontoNetoPagar.Width = 103;
            // 
            // colTipoPago
            // 
            this.colTipoPago.FieldName = "TipoPago";
            this.colTipoPago.Name = "colTipoPago";
            this.colTipoPago.OptionsColumn.AllowEdit = false;
            this.colTipoPago.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colTipoPago.OptionsColumn.AllowMove = false;
            this.colTipoPago.OptionsColumn.FixedWidth = true;
            this.colTipoPago.OptionsColumn.ReadOnly = true;
            this.colTipoPago.Visible = true;
            this.colTipoPago.VisibleIndex = 70;
            this.colTipoPago.Width = 100;
            // 
            // colBancoDestino
            // 
            this.colBancoDestino.FieldName = "BancoDestino";
            this.colBancoDestino.Name = "colBancoDestino";
            this.colBancoDestino.OptionsColumn.AllowEdit = false;
            this.colBancoDestino.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colBancoDestino.OptionsColumn.AllowMove = false;
            this.colBancoDestino.OptionsColumn.FixedWidth = true;
            this.colBancoDestino.OptionsColumn.ReadOnly = true;
            this.colBancoDestino.Visible = true;
            this.colBancoDestino.VisibleIndex = 71;
            this.colBancoDestino.Width = 100;
            // 
            // colDescTipoPeriodoNomina
            // 
            this.colDescTipoPeriodoNomina.Caption = "Tipo Nómina";
            this.colDescTipoPeriodoNomina.FieldName = "DescTipoPeriodoNomina";
            this.colDescTipoPeriodoNomina.Name = "colDescTipoPeriodoNomina";
            this.colDescTipoPeriodoNomina.OptionsColumn.AllowEdit = false;
            this.colDescTipoPeriodoNomina.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colDescTipoPeriodoNomina.OptionsColumn.FixedWidth = true;
            this.colDescTipoPeriodoNomina.OptionsColumn.ReadOnly = true;
            this.colDescTipoPeriodoNomina.Width = 100;
            // 
            // colPeriodoPago
            // 
            this.colPeriodoPago.FieldName = "PeriodoPago";
            this.colPeriodoPago.Name = "colPeriodoPago";
            this.colPeriodoPago.OptionsColumn.AllowEdit = false;
            this.colPeriodoPago.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colPeriodoPago.OptionsColumn.FixedWidth = true;
            this.colPeriodoPago.OptionsColumn.ReadOnly = true;
            this.colPeriodoPago.Width = 160;
            // 
            // colRazonSocialTenedora
            // 
            this.colRazonSocialTenedora.Caption = "Patrón";
            this.colRazonSocialTenedora.FieldName = "RazonSocialTenedora";
            this.colRazonSocialTenedora.Name = "colRazonSocialTenedora";
            this.colRazonSocialTenedora.OptionsColumn.AllowEdit = false;
            this.colRazonSocialTenedora.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colRazonSocialTenedora.OptionsColumn.FixedWidth = true;
            this.colRazonSocialTenedora.OptionsColumn.ReadOnly = true;
            this.colRazonSocialTenedora.Width = 137;
            // 
            // colHorasExtrasDobles
            // 
            this.colHorasExtrasDobles.DisplayFormat.FormatString = "C2";
            this.colHorasExtrasDobles.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colHorasExtrasDobles.FieldName = "Horas Extras Dobles";
            this.colHorasExtrasDobles.Name = "colHorasExtrasDobles";
            this.colHorasExtrasDobles.OptionsColumn.AllowEdit = false;
            this.colHorasExtrasDobles.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colHorasExtrasDobles.OptionsColumn.ReadOnly = true;
            this.colHorasExtrasDobles.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Horas Extras Dobles", "{0:c2}")});
            this.colHorasExtrasDobles.Visible = true;
            this.colHorasExtrasDobles.VisibleIndex = 24;
            this.colHorasExtrasDobles.Width = 118;
            // 
            // colHorasExtrasTiples
            // 
            this.colHorasExtrasTiples.DisplayFormat.FormatString = "C2";
            this.colHorasExtrasTiples.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colHorasExtrasTiples.FieldName = "Horas Extras Tiples";
            this.colHorasExtrasTiples.Name = "colHorasExtrasTiples";
            this.colHorasExtrasTiples.OptionsColumn.AllowEdit = false;
            this.colHorasExtrasTiples.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colHorasExtrasTiples.OptionsColumn.ReadOnly = true;
            this.colHorasExtrasTiples.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Horas Extras Tiples", "{0:c2}")});
            this.colHorasExtrasTiples.Visible = true;
            this.colHorasExtrasTiples.VisibleIndex = 25;
            this.colHorasExtrasTiples.Width = 104;
            // 
            // colDonativos
            // 
            this.colDonativos.Caption = "Recuperación Infonavit";
            this.colDonativos.DisplayFormat.FormatString = "C2";
            this.colDonativos.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDonativos.FieldName = "Donativos";
            this.colDonativos.Name = "colDonativos";
            this.colDonativos.OptionsColumn.AllowEdit = false;
            this.colDonativos.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colDonativos.OptionsColumn.ReadOnly = true;
            this.colDonativos.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Donativos", "{0:c2}")});
            this.colDonativos.Visible = true;
            this.colDonativos.VisibleIndex = 60;
            // 
            // colEstacionamiento
            // 
            this.colEstacionamiento.DisplayFormat.FormatString = "C2";
            this.colEstacionamiento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colEstacionamiento.FieldName = "Estacionamiento";
            this.colEstacionamiento.Name = "colEstacionamiento";
            this.colEstacionamiento.OptionsColumn.AllowEdit = false;
            this.colEstacionamiento.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colEstacionamiento.OptionsColumn.ReadOnly = true;
            this.colEstacionamiento.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Estacionamiento", "{0:c2}")});
            this.colEstacionamiento.Visible = true;
            this.colEstacionamiento.VisibleIndex = 59;
            this.colEstacionamiento.Width = 105;
            // 
            // colPTU
            // 
            this.colPTU.DisplayFormat.FormatString = "C2";
            this.colPTU.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPTU.FieldName = "PTU";
            this.colPTU.Name = "colPTU";
            this.colPTU.OptionsColumn.AllowEdit = false;
            this.colPTU.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colPTU.OptionsColumn.ReadOnly = true;
            this.colPTU.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PTU", "{0:c2}")});
            this.colPTU.Visible = true;
            this.colPTU.VisibleIndex = 28;
            // 
            // colCajaAhorroDeducción
            // 
            this.colCajaAhorroDeducción.DisplayFormat.FormatString = "C2";
            this.colCajaAhorroDeducción.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCajaAhorroDeducción.FieldName = "Caja Ahorro Deducción";
            this.colCajaAhorroDeducción.Name = "colCajaAhorroDeducción";
            this.colCajaAhorroDeducción.OptionsColumn.AllowEdit = false;
            this.colCajaAhorroDeducción.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colCajaAhorroDeducción.OptionsColumn.ReadOnly = true;
            this.colCajaAhorroDeducción.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Caja Ahorro Deducción", "{0:c2}")});
            this.colCajaAhorroDeducción.Visible = true;
            this.colCajaAhorroDeducción.VisibleIndex = 55;
            this.colCajaAhorroDeducción.Width = 124;
            // 
            // colFondodeAhorro
            // 
            this.colFondodeAhorro.DisplayFormat.FormatString = "C2";
            this.colFondodeAhorro.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colFondodeAhorro.FieldName = "Fondo de Ahorro";
            this.colFondodeAhorro.Name = "colFondodeAhorro";
            this.colFondodeAhorro.OptionsColumn.AllowEdit = false;
            this.colFondodeAhorro.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colFondodeAhorro.OptionsColumn.ReadOnly = true;
            this.colFondodeAhorro.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Fondo de Ahorro", "{0:c2}")});
            this.colFondodeAhorro.Visible = true;
            this.colFondodeAhorro.VisibleIndex = 36;
            this.colFondodeAhorro.Width = 98;
            // 
            // colMontoNetoPagarBanco
            // 
            this.colMontoNetoPagarBanco.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMontoNetoPagarBanco.AppearanceCell.Options.UseFont = true;
            this.colMontoNetoPagarBanco.DisplayFormat.FormatString = "C2";
            this.colMontoNetoPagarBanco.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMontoNetoPagarBanco.FieldName = "MontoNetoPagarBanco";
            this.colMontoNetoPagarBanco.Name = "colMontoNetoPagarBanco";
            this.colMontoNetoPagarBanco.OptionsColumn.AllowEdit = false;
            this.colMontoNetoPagarBanco.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colMontoNetoPagarBanco.OptionsColumn.ReadOnly = true;
            this.colMontoNetoPagarBanco.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MontoNetoPagarBanco", "{0:c2}")});
            this.colMontoNetoPagarBanco.Visible = true;
            this.colMontoNetoPagarBanco.VisibleIndex = 67;
            this.colMontoNetoPagarBanco.Width = 140;
            // 
            // colIncapacidad
            // 
            this.colIncapacidad.DisplayFormat.FormatString = "C2";
            this.colIncapacidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colIncapacidad.FieldName = "Incapacidad";
            this.colIncapacidad.Name = "colIncapacidad";
            this.colIncapacidad.OptionsColumn.AllowEdit = false;
            this.colIncapacidad.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colIncapacidad.OptionsColumn.ReadOnly = true;
            this.colIncapacidad.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Incapacidad", "{0:c2}")});
            this.colIncapacidad.Visible = true;
            this.colIncapacidad.VisibleIndex = 63;
            // 
            // colFondoAhorroDeduccion
            // 
            this.colFondoAhorroDeduccion.DisplayFormat.FormatString = "C2";
            this.colFondoAhorroDeduccion.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colFondoAhorroDeduccion.FieldName = "Fondo Ahorro Deduccion";
            this.colFondoAhorroDeduccion.Name = "colFondoAhorroDeduccion";
            this.colFondoAhorroDeduccion.OptionsColumn.AllowEdit = false;
            this.colFondoAhorroDeduccion.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colFondoAhorroDeduccion.OptionsColumn.ReadOnly = true;
            this.colFondoAhorroDeduccion.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Fondo Ahorro Deduccion", "{0:c2}")});
            this.colFondoAhorroDeduccion.Visible = true;
            this.colFondoAhorroDeduccion.VisibleIndex = 56;
            this.colFondoAhorroDeduccion.Width = 129;
            // 
            // colTipoCambio
            // 
            this.colTipoCambio.DisplayFormat.FormatString = "C2";
            this.colTipoCambio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTipoCambio.FieldName = "TipoCambio";
            this.colTipoCambio.Name = "colTipoCambio";
            this.colTipoCambio.OptionsColumn.AllowEdit = false;
            this.colTipoCambio.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colTipoCambio.OptionsColumn.ReadOnly = true;
            this.colTipoCambio.Visible = true;
            this.colTipoCambio.VisibleIndex = 68;
            this.colTipoCambio.Width = 70;
            // 
            // colIdMoneda
            // 
            this.colIdMoneda.Caption = "Moneda";
            this.colIdMoneda.FieldName = "IdMoneda";
            this.colIdMoneda.Name = "colIdMoneda";
            this.colIdMoneda.Visible = true;
            this.colIdMoneda.VisibleIndex = 69;
            // 
            // colISRporIndemnizacion
            // 
            this.colISRporIndemnizacion.DisplayFormat.FormatString = "C2";
            this.colISRporIndemnizacion.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colISRporIndemnizacion.FieldName = "ISR por Indemnizacion";
            this.colISRporIndemnizacion.Name = "colISRporIndemnizacion";
            this.colISRporIndemnizacion.OptionsColumn.AllowEdit = false;
            this.colISRporIndemnizacion.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colISRporIndemnizacion.OptionsColumn.ReadOnly = true;
            this.colISRporIndemnizacion.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ISR por Indemnizacion", "{0:c2}")});
            this.colISRporIndemnizacion.Visible = true;
            this.colISRporIndemnizacion.VisibleIndex = 64;
            this.colISRporIndemnizacion.Width = 117;
            // 
            // colIndemnizacion20diasporaño
            // 
            this.colIndemnizacion20diasporaño.DisplayFormat.FormatString = "C2";
            this.colIndemnizacion20diasporaño.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colIndemnizacion20diasporaño.FieldName = "Indemnizacion 20 dias por año";
            this.colIndemnizacion20diasporaño.Name = "colIndemnizacion20diasporaño";
            this.colIndemnizacion20diasporaño.OptionsColumn.AllowEdit = false;
            this.colIndemnizacion20diasporaño.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colIndemnizacion20diasporaño.OptionsColumn.ReadOnly = true;
            this.colIndemnizacion20diasporaño.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Indemnizacion 20 dias por año", "{0:c2}")});
            this.colIndemnizacion20diasporaño.Visible = true;
            this.colIndemnizacion20diasporaño.VisibleIndex = 39;
            this.colIndemnizacion20diasporaño.Width = 155;
            // 
            // colIndemnizacion90dias
            // 
            this.colIndemnizacion90dias.DisplayFormat.FormatString = "C2";
            this.colIndemnizacion90dias.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colIndemnizacion90dias.FieldName = "Indemnizacion 90 dias";
            this.colIndemnizacion90dias.Name = "colIndemnizacion90dias";
            this.colIndemnizacion90dias.OptionsColumn.AllowEdit = false;
            this.colIndemnizacion90dias.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colIndemnizacion90dias.OptionsColumn.ReadOnly = true;
            this.colIndemnizacion90dias.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Indemnizacion 90 dias", "{0:c2}")});
            this.colIndemnizacion90dias.Visible = true;
            this.colIndemnizacion90dias.VisibleIndex = 38;
            this.colIndemnizacion90dias.Width = 116;
            // 
            // colPrestamoEmpresa
            // 
            this.colPrestamoEmpresa.Caption = "Préstamo Empresa";
            this.colPrestamoEmpresa.DisplayFormat.FormatString = "C2";
            this.colPrestamoEmpresa.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrestamoEmpresa.FieldName = "Prestamo Empresa";
            this.colPrestamoEmpresa.Name = "colPrestamoEmpresa";
            this.colPrestamoEmpresa.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Prestamo Empresa", "{0:c2}")});
            this.colPrestamoEmpresa.Visible = true;
            this.colPrestamoEmpresa.VisibleIndex = 40;
            this.colPrestamoEmpresa.Width = 102;
            // 
            // colEstadoTrabajo
            // 
            this.colEstadoTrabajo.Caption = "EstadoTrabajo";
            this.colEstadoTrabajo.FieldName = "EstadoTrabajo";
            this.colEstadoTrabajo.Name = "colEstadoTrabajo";
            this.colEstadoTrabajo.Visible = true;
            this.colEstadoTrabajo.VisibleIndex = 72;
            // 
            // pcFolioLoteCargaNomina
            // 
            this.pcFolioLoteCargaNomina.Controls.Add(this.gcResumenEstatusNominaVsTimbrados);
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
            this.pcFolioLoteCargaNomina.Size = new System.Drawing.Size(942, 171);
            this.pcFolioLoteCargaNomina.TabIndex = 1;
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
            this.gcResumenEstatusNominaVsTimbrados.Location = new System.Drawing.Point(544, 17);
            this.gcResumenEstatusNominaVsTimbrados.Name = "gcResumenEstatusNominaVsTimbrados";
            this.gcResumenEstatusNominaVsTimbrados.Size = new System.Drawing.Size(386, 141);
            this.gcResumenEstatusNominaVsTimbrados.TabIndex = 17;
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
            // txtFechaPago
            // 
            this.txtFechaPago.Enabled = false;
            this.txtFechaPago.Location = new System.Drawing.Point(135, 141);
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
            this.labelControl6.Location = new System.Drawing.Point(73, 145);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(56, 13);
            this.labelControl6.TabIndex = 15;
            this.labelControl6.Text = "Fecha Pago";
            // 
            // chkEstatusNominaContabilizada
            // 
            this.chkEstatusNominaContabilizada.Enabled = false;
            this.chkEstatusNominaContabilizada.Location = new System.Drawing.Point(305, 142);
            this.chkEstatusNominaContabilizada.Name = "chkEstatusNominaContabilizada";
            this.chkEstatusNominaContabilizada.Properties.Caption = "Contabilizada";
            this.chkEstatusNominaContabilizada.Size = new System.Drawing.Size(116, 19);
            this.chkEstatusNominaContabilizada.TabIndex = 14;
            this.chkEstatusNominaContabilizada.TabStop = false;
            // 
            // txtPeriodoPago
            // 
            this.txtPeriodoPago.Enabled = false;
            this.txtPeriodoPago.Location = new System.Drawing.Point(305, 116);
            this.txtPeriodoPago.Name = "txtPeriodoPago";
            this.txtPeriodoPago.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtPeriodoPago.Properties.Appearance.Options.UseBackColor = true;
            this.txtPeriodoPago.Size = new System.Drawing.Size(150, 20);
            this.txtPeriodoPago.TabIndex = 13;
            this.txtPeriodoPago.TabStop = false;
            // 
            // txtNombreOperador
            // 
            this.txtNombreOperador.Enabled = false;
            this.txtNombreOperador.Location = new System.Drawing.Point(135, 90);
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
            this.txtTipoNomina.Location = new System.Drawing.Point(135, 116);
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
            this.txtNombreComercialCliente.Location = new System.Drawing.Point(135, 65);
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
            this.txtNombreComercialTenedora.Location = new System.Drawing.Point(135, 40);
            this.txtNombreComercialTenedora.Name = "txtNombreComercialTenedora";
            this.txtNombreComercialTenedora.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtNombreComercialTenedora.Properties.Appearance.Options.UseBackColor = true;
            this.txtNombreComercialTenedora.Size = new System.Drawing.Size(392, 20);
            this.txtNombreComercialTenedora.TabIndex = 5;
            this.txtNombreComercialTenedora.TabStop = false;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(71, 120);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(58, 13);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Tipo Nómina";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(263, 120);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(36, 13);
            this.labelControl4.TabIndex = 12;
            this.labelControl4.Text = "Periodo";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(83, 94);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(46, 13);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Operador";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(96, 69);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(33, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Cliente";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(83, 44);
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
            this.cboFolioLoteCargaNomina.Properties.DataSource = this.stpSelFolioLoteCargaNominaSABindingSource;
            this.cboFolioLoteCargaNomina.Properties.DisplayMember = "FolioLoteCargaNomina";
            this.cboFolioLoteCargaNomina.Properties.NullText = "";
            this.cboFolioLoteCargaNomina.Properties.ValueMember = "IdLoteCargaNomina";
            this.cboFolioLoteCargaNomina.Properties.View = this.gridLookUpEdit1View;
            this.cboFolioLoteCargaNomina.Size = new System.Drawing.Size(250, 20);
            this.cboFolioLoteCargaNomina.TabIndex = 3;
            this.cboFolioLoteCargaNomina.EditValueChanged += new System.EventHandler(this.cboFolioLoteCargaNomina_EditValueChanged);
            // 
            // stpSelFolioLoteCargaNominaSABindingSource
            // 
            this.stpSelFolioLoteCargaNominaSABindingSource.DataMember = "stpSelFolioLoteCargaNominaSA";
            this.stpSelFolioLoteCargaNominaSABindingSource.DataSource = this.dbSAICBPODataSet;
            // 
            // dbSAICBPODataSet
            // 
            this.dbSAICBPODataSet.DataSetName = "dbSAICBPODataSet";
            this.dbSAICBPODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn3,
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
            // lblFolio
            // 
            this.lblFolio.Location = new System.Drawing.Point(13, 17);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(116, 13);
            this.lblFolio.TabIndex = 2;
            this.lblFolio.Text = "Folio Lote Carga Nómina";
            // 
            // stpSelFolioLoteCargaNominaSATableAdapter
            // 
            this.stpSelFolioLoteCargaNominaSATableAdapter.ClearBeforeFill = true;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.stpSelReporteNominaSueldosSA_XLSGridControl);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 196);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(942, 366);
            this.panelControl1.TabIndex = 10;
            // 
            // sfdRutaArchivo
            // 
            this.sfdRutaArchivo.Filter = "Archivos de Excel | *.xls";
            this.sfdRutaArchivo.Title = "Guardar como...";
            // 
            // stpSelInfoDetalleLoteCargaNominaTableAdapter1
            // 
            this.stpSelInfoDetalleLoteCargaNominaTableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelValidarLoteCargaNominaEnSolicitudCancelacionNominaTableAdapter1
            // 
            this.stpSelValidarLoteCargaNominaEnSolicitudCancelacionNominaTableAdapter1.ClearBeforeFill = true;
            // 
            // dbSAICBPOValidacionDataSet1
            // 
            this.dbSAICBPOValidacionDataSet1.DataSetName = "dbSAICBPOValidacionDataSet";
            this.dbSAICBPOValidacionDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stpSelObtenerEstatusNominaSueldosVsTimbradoTableAdapter1
            // 
            this.stpSelObtenerEstatusNominaSueldosVsTimbradoTableAdapter1.ClearBeforeFill = true;
            // 
            // frmxDesgloseReporteNominasSueldos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 562);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.pcFolioLoteCargaNomina);
            this.Controls.Add(this.stpSelReporteNominaSueldosSA_XLSBindingNavigator);
            this.Name = "frmxDesgloseReporteNominasSueldos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Nómina SA (Detallado) y Cierre de Nómina";
            this.Load += new System.EventHandler(this.frmxDesgloseReporteNominasSueldos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOReportesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelReporteNominaSueldosSA_XLSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelReporteNominaSueldosSA_XLSBindingNavigator)).EndInit();
            this.stpSelReporteNominaSueldosSA_XLSBindingNavigator.ResumeLayout(false);
            this.stpSelReporteNominaSueldosSA_XLSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelReporteNominaSueldosSA_XLSGridControl)).EndInit();
            this.cmExportarGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcFolioLoteCargaNomina)).EndInit();
            this.pcFolioLoteCargaNomina.ResumeLayout(false);
            this.pcFolioLoteCargaNomina.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcResumenEstatusNominaVsTimbrados)).EndInit();
            this.gcResumenEstatusNominaVsTimbrados.ResumeLayout(false);
            this.gcResumenEstatusNominaVsTimbrados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFechaPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEstatusNominaContabilizada.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodoPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreOperador.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoNomina.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreComercialCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreComercialTenedora.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFolioLoteCargaNomina.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelFolioLoteCargaNominaSABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOValidacionDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dbSAICBPOReportesDataSet dbSAICBPOReportesDataSet;
        private System.Windows.Forms.BindingSource stpSelReporteNominaSueldosSA_XLSBindingSource;
        private dbSAICBPOReportesDataSetTableAdapters.stpSelReporteNominaSueldosSA_XLSTableAdapter stpSelReporteNominaSueldosSA_XLSTableAdapter;
        private dbSAICBPOReportesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator stpSelReporteNominaSueldosSA_XLSBindingNavigator;
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
        private DevExpress.XtraGrid.GridControl stpSelReporteNominaSueldosSA_XLSGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn colCURP;
        private DevExpress.XtraGrid.Columns.GridColumn colSD;
        private DevExpress.XtraGrid.Columns.GridColumn colSDI;
        private DevExpress.XtraGrid.Columns.GridColumn colDiasPagar;
        private DevExpress.XtraGrid.Columns.GridColumn colMontoTotalPercepciones;
        private DevExpress.XtraGrid.Columns.GridColumn colMontoTotalDeducciones;
        private DevExpress.XtraGrid.Columns.GridColumn colMontoNetoPagar;
        private DevExpress.XtraGrid.Columns.GridColumn colSueldo;
        private DevExpress.XtraGrid.Columns.GridColumn colSubsidio;
        private DevExpress.XtraEditors.PanelControl pcFolioLoteCargaNomina;
        private DevExpress.XtraEditors.GridLookUpEdit cboFolioLoteCargaNomina;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn colTenedora;
        private DevExpress.XtraGrid.Columns.GridColumn colCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colOperador;
        private DevExpress.XtraEditors.LabelControl lblFolio;
        private dbSAICBPODataSet dbSAICBPODataSet;
        private System.Windows.Forms.BindingSource stpSelFolioLoteCargaNominaSABindingSource;
        private dbSAICBPODataSetTableAdapters.stpSelFolioLoteCargaNominaSATableAdapter stpSelFolioLoteCargaNominaSATableAdapter;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colComisiones;
        private DevExpress.XtraGrid.Columns.GridColumn colIncentivos;
        private DevExpress.XtraGrid.Columns.GridColumn colPrimaDominical;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colGratificación;
        private DevExpress.XtraGrid.Columns.GridColumn colCompensación;
        private DevExpress.XtraGrid.Columns.GridColumn colBonoProductividad;
        private DevExpress.XtraGrid.Columns.GridColumn colRetroactivo;
        private DevExpress.XtraGrid.Columns.GridColumn colAyudaporDefunción;
        private DevExpress.XtraGrid.Columns.GridColumn colVacaciones;
        private DevExpress.XtraGrid.Columns.GridColumn colPrimaVacacional;
        private DevExpress.XtraGrid.Columns.GridColumn colAguinaldo;
        private DevExpress.XtraGrid.Columns.GridColumn colIndemnización;
        private DevExpress.XtraGrid.Columns.GridColumn colPrimaAntigüedad;
        private DevExpress.XtraGrid.Columns.GridColumn colVales;
        private DevExpress.XtraGrid.Columns.GridColumn colDespensa;
        private DevExpress.XtraGrid.Columns.GridColumn colPremiodeAsistencia;
        private DevExpress.XtraGrid.Columns.GridColumn colPremiodePuntualidad;
        private DevExpress.XtraGrid.Columns.GridColumn colAyudadeTransporte;
        private DevExpress.XtraGrid.Columns.GridColumn colAlimentación;
        private System.Windows.Forms.ContextMenuStrip cmExportarGrid;
        private System.Windows.Forms.ToolStripMenuItem exportarAExcelXLSToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog sfdRutaArchivo;
        private DevExpress.XtraGrid.Columns.GridColumn colISR;
        private DevExpress.XtraGrid.Columns.GridColumn colIMSS;
        private DevExpress.XtraGrid.Columns.GridColumn colRCV;
        private DevExpress.XtraGrid.Columns.GridColumn colInfonavit;
        private DevExpress.XtraGrid.Columns.GridColumn colSegurodeVivienda;
        private DevExpress.XtraGrid.Columns.GridColumn colCuotaSindical;
        private DevExpress.XtraGrid.Columns.GridColumn colPensiónAlimenticia;
        private DevExpress.XtraGrid.Columns.GridColumn colDescuentoAyudaporDefunción;
        private DevExpress.XtraGrid.Columns.GridColumn colPréstamoFonacot;
        private DevExpress.XtraGrid.Columns.GridColumn colAportaciónVoluntaria;
        private DevExpress.XtraGrid.Columns.GridColumn colPréstamo;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.ToolStripButton btnExportarXLS;
        private DevExpress.XtraGrid.Columns.GridColumn colNSS;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoPago;
        private DevExpress.XtraGrid.Columns.GridColumn colBancoDestino;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtNombreOperador;
        private DevExpress.XtraEditors.TextEdit txtTipoNomina;
        private DevExpress.XtraEditors.TextEdit txtNombreComercialCliente;
        private DevExpress.XtraEditors.TextEdit txtNombreComercialTenedora;
        private DevExpress.XtraEditors.TextEdit txtPeriodoPago;
        private DevExpress.XtraEditors.CheckEdit chkEstatusNominaContabilizada;
        private dbSAICBPOReportesDataSetTableAdapters.stpSelInfoDetalleLoteCargaNominaTableAdapter stpSelInfoDetalleLoteCargaNominaTableAdapter1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnCerrarNominaContabilizada;
        private dbSAICBPOActualizacionesDataSetTableAdapters.ActualizacionesGeneralTableAdapter actualizacionesGeneralTableAdapter1;
        private dbSAICBPOValidacionDataSetTableAdapters.stpSelValidarLoteCargaNominaEnSolicitudCancelacionNominaTableAdapter stpSelValidarLoteCargaNominaEnSolicitudCancelacionNominaTableAdapter1;
        private dbSAICBPOValidacionDataSet dbSAICBPOValidacionDataSet1;
        private DevExpress.XtraEditors.TextEdit txtFechaPago;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraGrid.Columns.GridColumn colNoRecibo;
        private DevExpress.XtraGrid.Columns.GridColumn colPeriodoPago;
        private DevExpress.XtraGrid.Columns.GridColumn colRazonSocialTenedora;
        private DevExpress.XtraGrid.Columns.GridColumn colDescTipoPeriodoNomina;
        private DevExpress.XtraGrid.Columns.GridColumn colSubsidioIncapacidad;
        private DevExpress.XtraGrid.Columns.GridColumn colAyudaVivienda;
        private DevExpress.XtraGrid.Columns.GridColumn colAyudaEducativa;
        private DevExpress.XtraGrid.Columns.GridColumn colCajadeAhorro;
        private DevExpress.XtraGrid.Columns.GridColumn colOtrasPercepciones;
        private DevExpress.XtraGrid.Columns.GridColumn colOtros;
        private DevExpress.XtraGrid.Columns.GridColumn colDescuentoVales;
        private DevExpress.XtraGrid.Columns.GridColumn colAnticipoSalarios;
        private DevExpress.XtraGrid.Columns.GridColumn colPagosExcedentes;
        private DevExpress.XtraGrid.Columns.GridColumn colOtrasDeducciones;
        private DevExpress.XtraGrid.Columns.GridColumn colAjustealNeto;
        private DevExpress.XtraGrid.Columns.GridColumn colHorasExtrasDobles;
        private DevExpress.XtraGrid.Columns.GridColumn colHorasExtrasTiples;
        private DevExpress.XtraGrid.Columns.GridColumn colDonativos;
        private DevExpress.XtraGrid.Columns.GridColumn colEstacionamiento;
        private DevExpress.XtraGrid.Columns.GridColumn colPTU;
        private DevExpress.XtraGrid.Columns.GridColumn colCajaAhorroDeducción;
        private DevExpress.XtraGrid.Columns.GridColumn colFondodeAhorro;
        private DevExpress.XtraGrid.Columns.GridColumn colMontoNetoPagarBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colIncapacidad;
        private DevExpress.XtraGrid.Columns.GridColumn colFondoAhorroDeduccion;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoCambio;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMoneda;
        private DevExpress.XtraGrid.Columns.GridColumn colISRporIndemnizacion;
        private DevExpress.XtraGrid.Columns.GridColumn colIndemnizacion20diasporaño;
        private DevExpress.XtraGrid.Columns.GridColumn colIndemnizacion90dias;
        private DevExpress.XtraEditors.GroupControl gcResumenEstatusNominaVsTimbrados;
        private DevExpress.XtraEditors.LabelControl lblNoEmpleadosCancelados;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl lblNoEmpleadosTimbrados;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl lblNoEmpleadosNomina;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl lblLeyendaEstatusNominaSueldosVsTimbrados;
        private DevExpress.XtraEditors.LabelControl lblPctEmpleadosPorTimbrar;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl lblPctEmpleadosTimbrados;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private dbSAICBPOReportesDataSetTableAdapters.stpSelObtenerEstatusNominaSueldosVsTimbradoTableAdapter stpSelObtenerEstatusNominaSueldosVsTimbradoTableAdapter1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashSMCargando;
        private DevExpress.XtraGrid.Columns.GridColumn colPrestamoEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colEstadoTrabajo;
    }
}