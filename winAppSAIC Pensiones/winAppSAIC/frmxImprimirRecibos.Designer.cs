namespace winAppSAIC
{
    partial class frmxImprimirRecibos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmxImprimirRecibos));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.gbSeleccioneTipoRecibo = new System.Windows.Forms.GroupBox();
            this.rbRelacionChequesSC = new System.Windows.Forms.RadioButton();
            this.rbRelacionChequesSA = new System.Windows.Forms.RadioButton();
            this.rbReporteNominaSC = new System.Windows.Forms.RadioButton();
            this.rbReporteNominaSA = new System.Windows.Forms.RadioButton();
            this.rbAcuseTenedoraSC = new System.Windows.Forms.RadioButton();
            this.rbAcuseTenedoraSA = new System.Windows.Forms.RadioButton();
            this.rbTenedoraSA = new System.Windows.Forms.RadioButton();
            this.rbTenedoraSC = new System.Windows.Forms.RadioButton();
            this.cboIdTipoPeriodoNomina = new System.Windows.Forms.ComboBox();
            this.stpSelTipoPeriodoNominaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPODataSet = new winAppSAIC.dbSAICBPODataSet();
            this.lblTipoNomina = new System.Windows.Forms.Label();
            this.lblOperador = new System.Windows.Forms.Label();
            this.lblFechaFinal = new System.Windows.Forms.Label();
            this.dtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.lblTenedoraSC = new System.Windows.Forms.Label();
            this.lblFechaInicial = new System.Windows.Forms.Label();
            this.dtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblTenedoraSA = new System.Windows.Forms.Label();
            this.btnVisualizarReporte = new DevExpress.XtraEditors.SimpleButton();
            this.btnMostrarLotes = new DevExpress.XtraEditors.SimpleButton();
            this.btnAutorizarNomina = new DevExpress.XtraEditors.SimpleButton();
            this.gvLotesCargaNomina = new System.Windows.Forms.DataGridView();
            this.idLoteCargaNominaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.folioLoteCargaNominaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMonedaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoCambio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NominaAutorizada = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NominaPorCancelar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IdControlOperacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stpSelLoteCargaNominaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblLotesCargaNomina = new System.Windows.Forms.Label();
            this.leyendaDispersionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPOCatalogosDataSet = new winAppSAIC.dbSAICBPOCatalogosDataSet();
            this.stpSelFormatoLayoutBancoPorIdBancoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwCatBancoLayoutActivoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stpSelInfoBancoCuentasLayoutTableAdapter = new winAppSAIC.dbSAICBPOValidacionDataSetTableAdapters.stpSelInfoBancoCuentasLayoutTableAdapter();
            this.dbSAICBPOValidacionDataSet = new winAppSAIC.dbSAICBPOValidacionDataSet();
            this.stpSelLayoutBanamexTEFC05TableAdapter = new winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.stpSelLayoutBanamexTEFC05TableAdapter();
            this.dbSAICBPOReportesDataSet = new winAppSAIC.dbSAICBPOReportesDataSet();
            this.stpSelLayoutBanamexTEFC12TableAdapter = new winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.stpSelLayoutBanamexTEFC12TableAdapter();
            this.chkVisualizarMovsBancarios = new System.Windows.Forms.CheckBox();
            this.stpSelLayoutBanamexTEFD05TableAdapter = new winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.stpSelLayoutBanamexTEFD05TableAdapter();
            this.stpSelLayoutBanamexTEFD12TableAdapter = new winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.stpSelLayoutBanamexTEFD12TableAdapter();
            this.btnSolicitarCancelacionNomina = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.stpSelValidarLoteCargaNominaEnSolicitudCancelacionNominaTableAdapter1 = new winAppSAIC.dbSAICBPOValidacionDataSetTableAdapters.stpSelValidarLoteCargaNominaEnSolicitudCancelacionNominaTableAdapter();
            this.stpSelEstatusNominaContabilizadaTableAdapter1 = new winAppSAIC.dbSAICBPOValidacionDataSetTableAdapters.stpSelEstatusNominaContabilizadaTableAdapter();
            this.stpSelLayoutBancomer98TableAdapter1 = new winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.stpSelLayoutBancomer98TableAdapter();
            this.stpSelLayoutBancomer99TableAdapter1 = new winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.stpSelLayoutBancomer99TableAdapter();
            this.stpSelLayoutBanorteTableAdapter1 = new winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.stpSelLayoutBanorteTableAdapter();
            this.stpSelLayoutSantanderTableAdapter1 = new winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.stpSelLayoutSantanderTableAdapter();
            this.stpSelLayoutCIBancoTableAdapter1 = new winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.stpSelLayoutCIBancoTableAdapter();
            this.stpSelLayoutHSBCNominasTableAdapter1 = new winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.stpSelLayoutHSBCNominasTableAdapter();
            this.stpSelLayoutHSBCOtrasCuentasTableAdapter1 = new winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.stpSelLayoutHSBCOtrasCuentasTableAdapter();
            this.stpSelLayoutHSBCSPEITableAdapter1 = new winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.stpSelLayoutHSBCSPEITableAdapter();
            this.leyendaDispersionTableAdapter = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.LeyendaDispersionTableAdapter();
            this.stpSelLoteCargaNominaTableAdapter = new winAppSAIC.dbSAICBPODataSetTableAdapters.stpSelLoteCargaNominaTableAdapter();
            this.btnAutorizarNominaCFDI = new DevExpress.XtraEditors.SimpleButton();
            this.seguridadTableAdapter1 = new winAppSAIC.NominaCFDI.dbSAICBPONominaCFDIDataSetTableAdapters.SeguridadTableAdapter();
            this.cboIdOperador = new DevExpress.XtraEditors.LookUpEdit();
            this.stpSelOperadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboIdTenedoraSC = new DevExpress.XtraEditors.LookUpEdit();
            this.vwCatTenedoraSCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboIdTenedoraSA = new DevExpress.XtraEditors.LookUpEdit();
            this.vwCatTenedoraSAAsimiladosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboIdCliente = new DevExpress.XtraEditors.LookUpEdit();
            this.vwCatClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stpSelLayoutHSBCNETNominasTableAdapter1 = new winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.stpSelLayoutHSBCNETNominasTableAdapter();
            this.stpSelLayoutInbursaSPEITableAdapter1 = new winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.stpSelLayoutInbursaSPEITableAdapter();
            this.stpSelLayoutBanorteInterbancarioTableAdapter1 = new winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.stpSelLayoutBanorteInterbancarioTableAdapter();
            this.stpSelLayoutBanorteInterbancario2016TableAdapter1 = new winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.stpSelLayoutBanorteInterbancario2016TableAdapter();
            this.validacionesGeneralTableAdapter1 = new winAppSAIC.Catalogos.dbSAICBPO_CatalogosValidacionDataSetTableAdapters.ValidacionesGeneralTableAdapter();
            this.sbBuscarIdLoteCargaNomina = new DevExpress.XtraEditors.SimpleButton();
            this.vwCatTenedoraSABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwCatTenedoraSATableAdapter = new winAppSAIC.dbSAICBPODataSetTableAdapters.vwCatTenedoraSATableAdapter();
            this.vwCatTenedoraSCTableAdapter = new winAppSAIC.dbSAICBPODataSetTableAdapters.vwCatTenedoraSCTableAdapter();
            this.vwCatClienteTableAdapter = new winAppSAIC.dbSAICBPODataSetTableAdapters.vwCatClienteTableAdapter();
            this.stpSelOperadorTableAdapter = new winAppSAIC.dbSAICBPODataSetTableAdapters.stpSelOperadorTableAdapter();
            this.stpSelTipoPeriodoNominaTableAdapter = new winAppSAIC.dbSAICBPODataSetTableAdapters.stpSelTipoPeriodoNominaTableAdapter();
            this.vwCatBancoLayoutActivoTableAdapter = new winAppSAIC.dbSAICBPODataSetTableAdapters.vwCatBancoLayoutActivoTableAdapter();
            this.stpSelFormatoLayoutBancoPorIdBancoTableAdapter = new winAppSAIC.dbSAICBPODataSetTableAdapters.stpSelFormatoLayoutBancoPorIdBancoTableAdapter();
            this.solicitudCancelacionNominaTableAdapter1 = new winAppSAIC.dbSAICBPODataSetTableAdapters.SolicitudCancelacionNominaTableAdapter();
            this.vwCatTenedoraSA_AsimiladosTableAdapter = new winAppSAIC.dbSAICBPODataSetTableAdapters.vwCatTenedoraSA_AsimiladosTableAdapter();
            this.dbSAICBPODataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPODataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idLoteCargaNominaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.folioLoteCargaNominaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMonedaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoCambioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nominaAutorizadaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nominaPorCancelarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.stpSelLayoutBanorte2016TableAdapter1 = new winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.stpSelLayoutBanorte2016TableAdapter();
            this.btnAbrirCarpetaLayOut = new DevExpress.XtraEditors.SimpleButton();
            this.cboLeyendaDispersion = new System.Windows.Forms.ComboBox();
            this.lblLeyendaDispersion = new System.Windows.Forms.Label();
            this.txtEmisora = new DevExpress.XtraEditors.TextEdit();
            this.lblEmisora = new System.Windows.Forms.Label();
            this.speNoSecuencia = new DevExpress.XtraEditors.SpinEdit();
            this.lblNoSecuencia = new System.Windows.Forms.Label();
            this.btnLayoutBancario = new DevExpress.XtraEditors.SimpleButton();
            this.dtFechaPago = new System.Windows.Forms.DateTimePicker();
            this.lblFechaPago = new System.Windows.Forms.Label();
            this.cboFormatoBanco = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboIdBanco = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtLote = new DevExpress.XtraEditors.TextEdit();
            this.txtIdLote = new DevExpress.XtraEditors.TextEdit();
            this.lblIdLoteCargaNomina = new System.Windows.Forms.Label();
            this.stpUpdAutorizacionNominaTableAdapter1 = new winAppSAIC.dbSAICBPODataSetTableAdapters.stpUpdAutorizacionNominaTableAdapter();
            this.stpSelLayOutBancariosTableAdapter1 = new winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.stpSelLayOutBancariosTableAdapter();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnActualizarFormaPagoLote = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.stpSelObtenerInfoEmpleadosLoteCargaNominaTableAdapter1 = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelObtenerInfoEmpleadosLoteCargaNominaTableAdapter();
            this.toolStrip1.SuspendLayout();
            this.gbSeleccioneTipoRecibo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelTipoPeriodoNominaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLotesCargaNomina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelLoteCargaNominaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leyendaDispersionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelFormatoLayoutBancoPorIdBancoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCatBancoLayoutActivoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOValidacionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOReportesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboIdOperador.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelOperadorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboIdTenedoraSC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCatTenedoraSCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboIdTenedoraSA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCatTenedoraSAAsimiladosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboIdCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCatClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCatTenedoraSABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPODataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPODataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmisora.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speNoSecuencia.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdLote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSalir,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(881, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::winAppSAIC.Properties.Resources.Salir24x24;
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(49, 22);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // gbSeleccioneTipoRecibo
            // 
            this.gbSeleccioneTipoRecibo.Controls.Add(this.rbRelacionChequesSC);
            this.gbSeleccioneTipoRecibo.Controls.Add(this.rbRelacionChequesSA);
            this.gbSeleccioneTipoRecibo.Controls.Add(this.rbReporteNominaSC);
            this.gbSeleccioneTipoRecibo.Controls.Add(this.rbReporteNominaSA);
            this.gbSeleccioneTipoRecibo.Controls.Add(this.rbAcuseTenedoraSC);
            this.gbSeleccioneTipoRecibo.Controls.Add(this.rbAcuseTenedoraSA);
            this.gbSeleccioneTipoRecibo.Controls.Add(this.rbTenedoraSA);
            this.gbSeleccioneTipoRecibo.Controls.Add(this.rbTenedoraSC);
            this.gbSeleccioneTipoRecibo.Location = new System.Drawing.Point(8, 73);
            this.gbSeleccioneTipoRecibo.Name = "gbSeleccioneTipoRecibo";
            this.gbSeleccioneTipoRecibo.Size = new System.Drawing.Size(651, 119);
            this.gbSeleccioneTipoRecibo.TabIndex = 2;
            this.gbSeleccioneTipoRecibo.TabStop = false;
            this.gbSeleccioneTipoRecibo.Text = "Seleccione el Tipo de Reporte";
            // 
            // rbRelacionChequesSC
            // 
            this.rbRelacionChequesSC.AutoSize = true;
            this.rbRelacionChequesSC.Location = new System.Drawing.Point(340, 92);
            this.rbRelacionChequesSC.Name = "rbRelacionChequesSC";
            this.rbRelacionChequesSC.Size = new System.Drawing.Size(172, 17);
            this.rbRelacionChequesSC.TabIndex = 16;
            this.rbRelacionChequesSC.TabStop = true;
            this.rbRelacionChequesSC.Text = "Relación Cheques Nómina S.C.";
            this.rbRelacionChequesSC.UseVisualStyleBackColor = true;
            this.rbRelacionChequesSC.CheckedChanged += new System.EventHandler(this.rbRelacionChequesSC_CheckedChanged);
            // 
            // rbRelacionChequesSA
            // 
            this.rbRelacionChequesSA.AutoSize = true;
            this.rbRelacionChequesSA.Location = new System.Drawing.Point(47, 92);
            this.rbRelacionChequesSA.Name = "rbRelacionChequesSA";
            this.rbRelacionChequesSA.Size = new System.Drawing.Size(172, 17);
            this.rbRelacionChequesSA.TabIndex = 15;
            this.rbRelacionChequesSA.TabStop = true;
            this.rbRelacionChequesSA.Text = "Relación Cheques Nómina S.A.";
            this.rbRelacionChequesSA.UseVisualStyleBackColor = true;
            this.rbRelacionChequesSA.CheckedChanged += new System.EventHandler(this.rbRelacionChequesSA_CheckedChanged);
            // 
            // rbReporteNominaSC
            // 
            this.rbReporteNominaSC.AutoSize = true;
            this.rbReporteNominaSC.Location = new System.Drawing.Point(340, 69);
            this.rbReporteNominaSC.Name = "rbReporteNominaSC";
            this.rbReporteNominaSC.Size = new System.Drawing.Size(163, 17);
            this.rbReporteNominaSC.TabIndex = 14;
            this.rbReporteNominaSC.TabStop = true;
            this.rbReporteNominaSC.Text = "Reporte de  S.C. (Resumido)";
            this.rbReporteNominaSC.UseVisualStyleBackColor = true;
            this.rbReporteNominaSC.CheckedChanged += new System.EventHandler(this.rbReporteNominaSC_CheckedChanged);
            // 
            // rbReporteNominaSA
            // 
            this.rbReporteNominaSA.AutoSize = true;
            this.rbReporteNominaSA.Location = new System.Drawing.Point(47, 69);
            this.rbReporteNominaSA.Name = "rbReporteNominaSA";
            this.rbReporteNominaSA.Size = new System.Drawing.Size(198, 17);
            this.rbReporteNominaSA.TabIndex = 13;
            this.rbReporteNominaSA.TabStop = true;
            this.rbReporteNominaSA.Text = "Reporte de Nómina S.A. (Resumido)";
            this.rbReporteNominaSA.UseVisualStyleBackColor = true;
            this.rbReporteNominaSA.CheckedChanged += new System.EventHandler(this.rbReporteNominaSA_CheckedChanged);
            // 
            // rbAcuseTenedoraSC
            // 
            this.rbAcuseTenedoraSC.AutoSize = true;
            this.rbAcuseTenedoraSC.Location = new System.Drawing.Point(340, 46);
            this.rbAcuseTenedoraSC.Name = "rbAcuseTenedoraSC";
            this.rbAcuseTenedoraSC.Size = new System.Drawing.Size(161, 17);
            this.rbAcuseTenedoraSC.TabIndex = 12;
            this.rbAcuseTenedoraSC.TabStop = true;
            this.rbAcuseTenedoraSC.Text = "Acuse Recibos Nóminas S.C.";
            this.rbAcuseTenedoraSC.UseVisualStyleBackColor = true;
            this.rbAcuseTenedoraSC.CheckedChanged += new System.EventHandler(this.rbAcuseTenedoraSC_CheckedChanged);
            // 
            // rbAcuseTenedoraSA
            // 
            this.rbAcuseTenedoraSA.AutoSize = true;
            this.rbAcuseTenedoraSA.Location = new System.Drawing.Point(47, 46);
            this.rbAcuseTenedoraSA.Name = "rbAcuseTenedoraSA";
            this.rbAcuseTenedoraSA.Size = new System.Drawing.Size(161, 17);
            this.rbAcuseTenedoraSA.TabIndex = 11;
            this.rbAcuseTenedoraSA.TabStop = true;
            this.rbAcuseTenedoraSA.Text = "Acuse Recibos Nóminas S.A.";
            this.rbAcuseTenedoraSA.UseVisualStyleBackColor = true;
            this.rbAcuseTenedoraSA.CheckedChanged += new System.EventHandler(this.rbAcuseTenedoraSA_CheckedChanged);
            // 
            // rbTenedoraSA
            // 
            this.rbTenedoraSA.AutoSize = true;
            this.rbTenedoraSA.Location = new System.Drawing.Point(47, 23);
            this.rbTenedoraSA.Name = "rbTenedoraSA";
            this.rbTenedoraSA.Size = new System.Drawing.Size(129, 17);
            this.rbTenedoraSA.TabIndex = 9;
            this.rbTenedoraSA.TabStop = true;
            this.rbTenedoraSA.Text = "Recibos Nóminas S.A.";
            this.rbTenedoraSA.UseVisualStyleBackColor = true;
            this.rbTenedoraSA.CheckedChanged += new System.EventHandler(this.rbTenedoraSA_CheckedChanged);
            // 
            // rbTenedoraSC
            // 
            this.rbTenedoraSC.AutoSize = true;
            this.rbTenedoraSC.Location = new System.Drawing.Point(340, 23);
            this.rbTenedoraSC.Name = "rbTenedoraSC";
            this.rbTenedoraSC.Size = new System.Drawing.Size(129, 17);
            this.rbTenedoraSC.TabIndex = 10;
            this.rbTenedoraSC.TabStop = true;
            this.rbTenedoraSC.Text = "Recibos Nóminas S.C.";
            this.rbTenedoraSC.UseVisualStyleBackColor = true;
            this.rbTenedoraSC.CheckedChanged += new System.EventHandler(this.rbTenedoraSC_CheckedChanged);
            // 
            // cboIdTipoPeriodoNomina
            // 
            this.cboIdTipoPeriodoNomina.DataSource = this.stpSelTipoPeriodoNominaBindingSource;
            this.cboIdTipoPeriodoNomina.DisplayMember = "DescTipoPeriodoNomina";
            this.cboIdTipoPeriodoNomina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdTipoPeriodoNomina.FormattingEnabled = true;
            this.cboIdTipoPeriodoNomina.Location = new System.Drawing.Point(115, 121);
            this.cboIdTipoPeriodoNomina.Name = "cboIdTipoPeriodoNomina";
            this.cboIdTipoPeriodoNomina.Size = new System.Drawing.Size(131, 21);
            this.cboIdTipoPeriodoNomina.TabIndex = 25;
            this.cboIdTipoPeriodoNomina.ValueMember = "IdTipoPeriodoNomina";
            // 
            // stpSelTipoPeriodoNominaBindingSource
            // 
            this.stpSelTipoPeriodoNominaBindingSource.DataMember = "stpSelTipoPeriodoNomina";
            this.stpSelTipoPeriodoNominaBindingSource.DataSource = this.dbSAICBPODataSet;
            // 
            // dbSAICBPODataSet
            // 
            this.dbSAICBPODataSet.DataSetName = "dbSAICBPODataSet";
            this.dbSAICBPODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblTipoNomina
            // 
            this.lblTipoNomina.AutoSize = true;
            this.lblTipoNomina.Location = new System.Drawing.Point(30, 125);
            this.lblTipoNomina.Name = "lblTipoNomina";
            this.lblTipoNomina.Size = new System.Drawing.Size(84, 13);
            this.lblTipoNomina.TabIndex = 24;
            this.lblTipoNomina.Text = "Tipo de Nómina:";
            // 
            // lblOperador
            // 
            this.lblOperador.AutoSize = true;
            this.lblOperador.Location = new System.Drawing.Point(56, 99);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(57, 13);
            this.lblOperador.TabIndex = 22;
            this.lblOperador.Text = "Operador:";
            // 
            // lblFechaFinal
            // 
            this.lblFechaFinal.AutoSize = true;
            this.lblFechaFinal.Location = new System.Drawing.Point(454, 125);
            this.lblFechaFinal.Name = "lblFechaFinal";
            this.lblFechaFinal.Size = new System.Drawing.Size(65, 13);
            this.lblFechaFinal.TabIndex = 28;
            this.lblFechaFinal.Text = "Fecha Final:";
            // 
            // dtFechaFin
            // 
            this.dtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaFin.Location = new System.Drawing.Point(522, 121);
            this.dtFechaFin.Name = "dtFechaFin";
            this.dtFechaFin.Size = new System.Drawing.Size(92, 21);
            this.dtFechaFin.TabIndex = 29;
            // 
            // lblTenedoraSC
            // 
            this.lblTenedoraSC.AutoSize = true;
            this.lblTenedoraSC.Location = new System.Drawing.Point(29, 52);
            this.lblTenedoraSC.Name = "lblTenedoraSC";
            this.lblTenedoraSC.Size = new System.Drawing.Size(84, 13);
            this.lblTenedoraSC.TabIndex = 18;
            this.lblTenedoraSC.Text = "Tenedora  S.C.:";
            // 
            // lblFechaInicial
            // 
            this.lblFechaInicial.AutoSize = true;
            this.lblFechaInicial.Location = new System.Drawing.Point(272, 125);
            this.lblFechaInicial.Name = "lblFechaInicial";
            this.lblFechaInicial.Size = new System.Drawing.Size(70, 13);
            this.lblFechaInicial.TabIndex = 26;
            this.lblFechaInicial.Text = "Fecha Inicial:";
            // 
            // dtFechaInicio
            // 
            this.dtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaInicio.Location = new System.Drawing.Point(344, 121);
            this.dtFechaInicio.Name = "dtFechaInicio";
            this.dtFechaInicio.Size = new System.Drawing.Size(92, 21);
            this.dtFechaInicio.TabIndex = 27;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(70, 73);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(44, 13);
            this.lblCliente.TabIndex = 20;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblTenedoraSA
            // 
            this.lblTenedoraSA.AutoSize = true;
            this.lblTenedoraSA.Location = new System.Drawing.Point(32, 26);
            this.lblTenedoraSA.Name = "lblTenedoraSA";
            this.lblTenedoraSA.Size = new System.Drawing.Size(81, 13);
            this.lblTenedoraSA.TabIndex = 16;
            this.lblTenedoraSA.Text = "Tenedora S.A.:";
            // 
            // btnVisualizarReporte
            // 
            this.btnVisualizarReporte.Appearance.BackColor = System.Drawing.Color.White;
            this.btnVisualizarReporte.Appearance.Options.UseBackColor = true;
            this.btnVisualizarReporte.Appearance.Options.UseTextOptions = true;
            this.btnVisualizarReporte.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnVisualizarReporte.ImageOptions.Image = global::winAppSAIC.Properties.Resources.ImprimirPreview;
            this.btnVisualizarReporte.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnVisualizarReporte.Location = new System.Drawing.Point(10, 61);
            this.btnVisualizarReporte.LookAndFeel.SkinName = "VS2010";
            this.btnVisualizarReporte.Name = "btnVisualizarReporte";
            this.btnVisualizarReporte.Size = new System.Drawing.Size(190, 30);
            this.btnVisualizarReporte.TabIndex = 34;
            this.btnVisualizarReporte.Text = "&2 ) Visualizar Reporte";
            this.btnVisualizarReporte.Click += new System.EventHandler(this.btnVisualizarReporte_Click);
            // 
            // btnMostrarLotes
            // 
            this.btnMostrarLotes.Appearance.BackColor = System.Drawing.Color.White;
            this.btnMostrarLotes.Appearance.Options.UseBackColor = true;
            this.btnMostrarLotes.Appearance.Options.UseTextOptions = true;
            this.btnMostrarLotes.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnMostrarLotes.ImageOptions.Image = global::winAppSAIC.Properties.Resources.CascadeWindowsHS;
            this.btnMostrarLotes.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnMostrarLotes.Location = new System.Drawing.Point(10, 23);
            this.btnMostrarLotes.LookAndFeel.SkinName = "VS2010";
            this.btnMostrarLotes.Name = "btnMostrarLotes";
            this.btnMostrarLotes.Size = new System.Drawing.Size(190, 30);
            this.btnMostrarLotes.TabIndex = 33;
            this.btnMostrarLotes.Text = "&1 ) Mostrar Lotes";
            this.btnMostrarLotes.Click += new System.EventHandler(this.btnMostrarLotes_Click);
            // 
            // btnAutorizarNomina
            // 
            this.btnAutorizarNomina.Appearance.BackColor = System.Drawing.Color.White;
            this.btnAutorizarNomina.Appearance.Options.UseBackColor = true;
            this.btnAutorizarNomina.Appearance.Options.UseTextOptions = true;
            this.btnAutorizarNomina.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnAutorizarNomina.ImageOptions.Image = global::winAppSAIC.Properties.Resources.SelectAll16x16;
            this.btnAutorizarNomina.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnAutorizarNomina.Location = new System.Drawing.Point(675, 556);
            this.btnAutorizarNomina.LookAndFeel.SkinName = "VS2010";
            this.btnAutorizarNomina.Name = "btnAutorizarNomina";
            this.btnAutorizarNomina.Size = new System.Drawing.Size(190, 30);
            this.btnAutorizarNomina.TabIndex = 35;
            this.btnAutorizarNomina.Text = "&3 ) Autorizar Nómina para Layout";
            this.btnAutorizarNomina.Visible = false;
            this.btnAutorizarNomina.Click += new System.EventHandler(this.btnAutorizarNomina_Click);
            // 
            // gvLotesCargaNomina
            // 
            this.gvLotesCargaNomina.AllowUserToAddRows = false;
            this.gvLotesCargaNomina.AllowUserToDeleteRows = false;
            this.gvLotesCargaNomina.AutoGenerateColumns = false;
            this.gvLotesCargaNomina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvLotesCargaNomina.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idLoteCargaNominaDataGridViewTextBoxColumn,
            this.folioLoteCargaNominaDataGridViewTextBoxColumn,
            this.idMonedaDataGridViewTextBoxColumn,
            this.TipoCambio,
            this.NominaAutorizada,
            this.NominaPorCancelar,
            this.IdControlOperacion});
            this.gvLotesCargaNomina.DataSource = this.stpSelLoteCargaNominaBindingSource;
            this.gvLotesCargaNomina.Location = new System.Drawing.Point(10, 172);
            this.gvLotesCargaNomina.Name = "gvLotesCargaNomina";
            this.gvLotesCargaNomina.ReadOnly = true;
            this.gvLotesCargaNomina.Size = new System.Drawing.Size(628, 102);
            this.gvLotesCargaNomina.TabIndex = 31;
            this.gvLotesCargaNomina.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gvLotesCargaNomina_CellFormatting);
            // 
            // idLoteCargaNominaDataGridViewTextBoxColumn
            // 
            this.idLoteCargaNominaDataGridViewTextBoxColumn.DataPropertyName = "IdLoteCargaNomina";
            this.idLoteCargaNominaDataGridViewTextBoxColumn.HeaderText = "IdLoteCargaNomina";
            this.idLoteCargaNominaDataGridViewTextBoxColumn.Name = "idLoteCargaNominaDataGridViewTextBoxColumn";
            this.idLoteCargaNominaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idLoteCargaNominaDataGridViewTextBoxColumn.Visible = false;
            // 
            // folioLoteCargaNominaDataGridViewTextBoxColumn
            // 
            this.folioLoteCargaNominaDataGridViewTextBoxColumn.DataPropertyName = "FolioLoteCargaNomina";
            this.folioLoteCargaNominaDataGridViewTextBoxColumn.HeaderText = "Folio Lote de Carga Nómina";
            this.folioLoteCargaNominaDataGridViewTextBoxColumn.Name = "folioLoteCargaNominaDataGridViewTextBoxColumn";
            this.folioLoteCargaNominaDataGridViewTextBoxColumn.ReadOnly = true;
            this.folioLoteCargaNominaDataGridViewTextBoxColumn.Width = 190;
            // 
            // idMonedaDataGridViewTextBoxColumn
            // 
            this.idMonedaDataGridViewTextBoxColumn.DataPropertyName = "IdMoneda";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.idMonedaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.idMonedaDataGridViewTextBoxColumn.HeaderText = "Moneda";
            this.idMonedaDataGridViewTextBoxColumn.Name = "idMonedaDataGridViewTextBoxColumn";
            this.idMonedaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idMonedaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idMonedaDataGridViewTextBoxColumn.Width = 60;
            // 
            // TipoCambio
            // 
            this.TipoCambio.DataPropertyName = "TipoCambio";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.TipoCambio.DefaultCellStyle = dataGridViewCellStyle2;
            this.TipoCambio.HeaderText = "Tipo de Cambio";
            this.TipoCambio.Name = "TipoCambio";
            this.TipoCambio.ReadOnly = true;
            this.TipoCambio.Width = 110;
            // 
            // NominaAutorizada
            // 
            this.NominaAutorizada.DataPropertyName = "NominaAutorizada";
            this.NominaAutorizada.HeaderText = "Autorizada";
            this.NominaAutorizada.Name = "NominaAutorizada";
            this.NominaAutorizada.ReadOnly = true;
            this.NominaAutorizada.Width = 70;
            // 
            // NominaPorCancelar
            // 
            this.NominaPorCancelar.DataPropertyName = "NominaPorCancelar";
            this.NominaPorCancelar.HeaderText = "Por Cancelar";
            this.NominaPorCancelar.Name = "NominaPorCancelar";
            this.NominaPorCancelar.ReadOnly = true;
            this.NominaPorCancelar.Width = 75;
            // 
            // IdControlOperacion
            // 
            this.IdControlOperacion.DataPropertyName = "IdControlOperacion";
            this.IdControlOperacion.HeaderText = "Id Control";
            this.IdControlOperacion.Name = "IdControlOperacion";
            this.IdControlOperacion.ReadOnly = true;
            this.IdControlOperacion.Width = 80;
            // 
            // stpSelLoteCargaNominaBindingSource
            // 
            this.stpSelLoteCargaNominaBindingSource.DataMember = "stpSelLoteCargaNomina";
            this.stpSelLoteCargaNominaBindingSource.DataSource = this.dbSAICBPODataSet;
            // 
            // lblLotesCargaNomina
            // 
            this.lblLotesCargaNomina.AutoSize = true;
            this.lblLotesCargaNomina.Location = new System.Drawing.Point(10, 153);
            this.lblLotesCargaNomina.Name = "lblLotesCargaNomina";
            this.lblLotesCargaNomina.Size = new System.Drawing.Size(138, 13);
            this.lblLotesCargaNomina.TabIndex = 30;
            this.lblLotesCargaNomina.Text = "Lotes de Carga de Nóminas";
            // 
            // leyendaDispersionBindingSource
            // 
            this.leyendaDispersionBindingSource.DataMember = "LeyendaDispersion";
            this.leyendaDispersionBindingSource.DataSource = this.dbSAICBPOCatalogosDataSet;
            // 
            // dbSAICBPOCatalogosDataSet
            // 
            this.dbSAICBPOCatalogosDataSet.DataSetName = "dbSAICBPOCatalogosDataSet";
            this.dbSAICBPOCatalogosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stpSelFormatoLayoutBancoPorIdBancoBindingSource
            // 
            this.stpSelFormatoLayoutBancoPorIdBancoBindingSource.DataMember = "stpSelFormatoLayoutBancoPorIdBanco";
            this.stpSelFormatoLayoutBancoPorIdBancoBindingSource.DataSource = this.dbSAICBPODataSet;
            // 
            // vwCatBancoLayoutActivoBindingSource
            // 
            this.vwCatBancoLayoutActivoBindingSource.DataMember = "vwCatBancoLayoutActivo";
            this.vwCatBancoLayoutActivoBindingSource.DataSource = this.dbSAICBPODataSet;
            // 
            // stpSelInfoBancoCuentasLayoutTableAdapter
            // 
            this.stpSelInfoBancoCuentasLayoutTableAdapter.ClearBeforeFill = true;
            // 
            // dbSAICBPOValidacionDataSet
            // 
            this.dbSAICBPOValidacionDataSet.DataSetName = "dbSAICBPOValidacionDataSet";
            this.dbSAICBPOValidacionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stpSelLayoutBanamexTEFC05TableAdapter
            // 
            this.stpSelLayoutBanamexTEFC05TableAdapter.ClearBeforeFill = true;
            // 
            // dbSAICBPOReportesDataSet
            // 
            this.dbSAICBPOReportesDataSet.DataSetName = "dbSAICBPOReportesDataSet";
            this.dbSAICBPOReportesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stpSelLayoutBanamexTEFC12TableAdapter
            // 
            this.stpSelLayoutBanamexTEFC12TableAdapter.ClearBeforeFill = true;
            // 
            // chkVisualizarMovsBancarios
            // 
            this.chkVisualizarMovsBancarios.AutoSize = true;
            this.chkVisualizarMovsBancarios.Enabled = false;
            this.chkVisualizarMovsBancarios.Location = new System.Drawing.Point(674, 467);
            this.chkVisualizarMovsBancarios.Name = "chkVisualizarMovsBancarios";
            this.chkVisualizarMovsBancarios.Size = new System.Drawing.Size(132, 17);
            this.chkVisualizarMovsBancarios.TabIndex = 38;
            this.chkVisualizarMovsBancarios.Text = "Visualizar Movimientos";
            this.chkVisualizarMovsBancarios.UseVisualStyleBackColor = true;
            this.chkVisualizarMovsBancarios.Visible = false;
            // 
            // stpSelLayoutBanamexTEFD05TableAdapter
            // 
            this.stpSelLayoutBanamexTEFD05TableAdapter.ClearBeforeFill = true;
            // 
            // stpSelLayoutBanamexTEFD12TableAdapter
            // 
            this.stpSelLayoutBanamexTEFD12TableAdapter.ClearBeforeFill = true;
            // 
            // btnSolicitarCancelacionNomina
            // 
            this.btnSolicitarCancelacionNomina.Appearance.BackColor = System.Drawing.Color.White;
            this.btnSolicitarCancelacionNomina.Appearance.Options.UseBackColor = true;
            this.btnSolicitarCancelacionNomina.Appearance.Options.UseTextOptions = true;
            this.btnSolicitarCancelacionNomina.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnSolicitarCancelacionNomina.ImageOptions.Image = global::winAppSAIC.Properties.Resources.Service_icon16x16;
            this.btnSolicitarCancelacionNomina.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSolicitarCancelacionNomina.Location = new System.Drawing.Point(11, 97);
            this.btnSolicitarCancelacionNomina.LookAndFeel.SkinName = "VS2010";
            this.btnSolicitarCancelacionNomina.Name = "btnSolicitarCancelacionNomina";
            this.btnSolicitarCancelacionNomina.Size = new System.Drawing.Size(190, 30);
            this.btnSolicitarCancelacionNomina.TabIndex = 37;
            this.btnSolicitarCancelacionNomina.Text = "Solicitar Cancelación Nómina";
            this.btnSolicitarCancelacionNomina.Click += new System.EventHandler(this.btnSolicitarCancelacionNomina_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.White;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseTextOptions = true;
            this.simpleButton1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.simpleButton1.ImageOptions.Image = global::winAppSAIC.Properties.Resources.XML_01_icon24x24;
            this.simpleButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.simpleButton1.Location = new System.Drawing.Point(674, 525);
            this.simpleButton1.LookAndFeel.SkinName = "VS2010";
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(190, 30);
            this.simpleButton1.TabIndex = 39;
            this.simpleButton1.Text = "&3) Asignar Nóminas a XML CFDI";
            this.simpleButton1.Visible = false;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // stpSelValidarLoteCargaNominaEnSolicitudCancelacionNominaTableAdapter1
            // 
            this.stpSelValidarLoteCargaNominaEnSolicitudCancelacionNominaTableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelLayoutBancomer98TableAdapter1
            // 
            this.stpSelLayoutBancomer98TableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelLayoutBancomer99TableAdapter1
            // 
            this.stpSelLayoutBancomer99TableAdapter1.ClearBeforeFill = true;
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
            // stpSelLayoutHSBCNominasTableAdapter1
            // 
            this.stpSelLayoutHSBCNominasTableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelLayoutHSBCOtrasCuentasTableAdapter1
            // 
            this.stpSelLayoutHSBCOtrasCuentasTableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelLayoutHSBCSPEITableAdapter1
            // 
            this.stpSelLayoutHSBCSPEITableAdapter1.ClearBeforeFill = true;
            // 
            // leyendaDispersionTableAdapter
            // 
            this.leyendaDispersionTableAdapter.ClearBeforeFill = true;
            // 
            // stpSelLoteCargaNominaTableAdapter
            // 
            this.stpSelLoteCargaNominaTableAdapter.ClearBeforeFill = true;
            // 
            // btnAutorizarNominaCFDI
            // 
            this.btnAutorizarNominaCFDI.Appearance.BackColor = System.Drawing.Color.White;
            this.btnAutorizarNominaCFDI.Appearance.Options.UseBackColor = true;
            this.btnAutorizarNominaCFDI.Appearance.Options.UseTextOptions = true;
            this.btnAutorizarNominaCFDI.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnAutorizarNominaCFDI.ImageOptions.Image = global::winAppSAIC.Properties.Resources.Transfer_Document_icon16x16;
            this.btnAutorizarNominaCFDI.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnAutorizarNominaCFDI.Location = new System.Drawing.Point(675, 592);
            this.btnAutorizarNominaCFDI.LookAndFeel.SkinName = "VS2010";
            this.btnAutorizarNominaCFDI.Name = "btnAutorizarNominaCFDI";
            this.btnAutorizarNominaCFDI.Size = new System.Drawing.Size(190, 30);
            this.btnAutorizarNominaCFDI.TabIndex = 36;
            this.btnAutorizarNominaCFDI.Text = "&4) Autorizar Nómina para CFDI";
            this.btnAutorizarNominaCFDI.Visible = false;
            this.btnAutorizarNominaCFDI.Click += new System.EventHandler(this.btnAutorizarNominaCFDI_Click);
            // 
            // cboIdOperador
            // 
            this.cboIdOperador.Location = new System.Drawing.Point(115, 95);
            this.cboIdOperador.Name = "cboIdOperador";
            this.cboIdOperador.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboIdOperador.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdOperador", "Id Operador", 82, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NombreCompletoOperador", "Operador", 144, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cboIdOperador.Properties.DataSource = this.stpSelOperadorBindingSource;
            this.cboIdOperador.Properties.DisplayMember = "NombreCompletoOperador";
            this.cboIdOperador.Properties.NullText = "";
            this.cboIdOperador.Properties.ValueMember = "IdOperador";
            this.cboIdOperador.Size = new System.Drawing.Size(515, 20);
            this.cboIdOperador.TabIndex = 23;
            // 
            // stpSelOperadorBindingSource
            // 
            this.stpSelOperadorBindingSource.DataMember = "stpSelOperador";
            this.stpSelOperadorBindingSource.DataSource = this.dbSAICBPODataSet;
            // 
            // cboIdTenedoraSC
            // 
            this.cboIdTenedoraSC.Location = new System.Drawing.Point(115, 45);
            this.cboIdTenedoraSC.Name = "cboIdTenedoraSC";
            this.cboIdTenedoraSC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboIdTenedoraSC.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdTenedora", "Id Tenedora", 82, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RazonSocial", "Razon Social", 70, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NombreComercial", "Nombre Comercial Tenedora S.C.", 96, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cboIdTenedoraSC.Properties.DataSource = this.vwCatTenedoraSCBindingSource;
            this.cboIdTenedoraSC.Properties.DisplayMember = "NombreComercial";
            this.cboIdTenedoraSC.Properties.NullText = "";
            this.cboIdTenedoraSC.Properties.ValueMember = "IdTenedora";
            this.cboIdTenedoraSC.Size = new System.Drawing.Size(516, 20);
            this.cboIdTenedoraSC.TabIndex = 19;
            // 
            // vwCatTenedoraSCBindingSource
            // 
            this.vwCatTenedoraSCBindingSource.DataMember = "vwCatTenedoraSC";
            this.vwCatTenedoraSCBindingSource.DataSource = this.dbSAICBPODataSet;
            // 
            // cboIdTenedoraSA
            // 
            this.cboIdTenedoraSA.Location = new System.Drawing.Point(115, 21);
            this.cboIdTenedoraSA.Name = "cboIdTenedoraSA";
            this.cboIdTenedoraSA.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboIdTenedoraSA.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdTenedora", "Id Tenedora", 82, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RazonSocial", "Razon Social", 70, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NombreComercial", "Nombre Comercial Tenedora S.A.", 96, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cboIdTenedoraSA.Properties.DataSource = this.vwCatTenedoraSAAsimiladosBindingSource;
            this.cboIdTenedoraSA.Properties.DisplayMember = "NombreComercial";
            this.cboIdTenedoraSA.Properties.NullText = "";
            this.cboIdTenedoraSA.Properties.ValueMember = "IdTenedora";
            this.cboIdTenedoraSA.Size = new System.Drawing.Size(516, 20);
            this.cboIdTenedoraSA.TabIndex = 17;
            // 
            // vwCatTenedoraSAAsimiladosBindingSource
            // 
            this.vwCatTenedoraSAAsimiladosBindingSource.DataMember = "vwCatTenedoraSA_Asimilados";
            this.vwCatTenedoraSAAsimiladosBindingSource.DataSource = this.dbSAICBPODataSet;
            // 
            // cboIdCliente
            // 
            this.cboIdCliente.Location = new System.Drawing.Point(115, 69);
            this.cboIdCliente.Name = "cboIdCliente";
            this.cboIdCliente.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboIdCliente.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdCliente", "Id Cliente", 69, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NombreComercial", "Nombre Comercial Cliente", 96, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cboIdCliente.Properties.DataSource = this.vwCatClienteBindingSource;
            this.cboIdCliente.Properties.DisplayMember = "NombreComercial";
            this.cboIdCliente.Properties.NullText = "";
            this.cboIdCliente.Properties.ValueMember = "IdCliente";
            this.cboIdCliente.Size = new System.Drawing.Size(515, 20);
            this.cboIdCliente.TabIndex = 21;
            // 
            // vwCatClienteBindingSource
            // 
            this.vwCatClienteBindingSource.DataMember = "vwCatCliente";
            this.vwCatClienteBindingSource.DataSource = this.dbSAICBPODataSet;
            // 
            // stpSelLayoutHSBCNETNominasTableAdapter1
            // 
            this.stpSelLayoutHSBCNETNominasTableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelLayoutInbursaSPEITableAdapter1
            // 
            this.stpSelLayoutInbursaSPEITableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelLayoutBanorteInterbancarioTableAdapter1
            // 
            this.stpSelLayoutBanorteInterbancarioTableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelLayoutBanorteInterbancario2016TableAdapter1
            // 
            this.stpSelLayoutBanorteInterbancario2016TableAdapter1.ClearBeforeFill = true;
            // 
            // sbBuscarIdLoteCargaNomina
            // 
            this.sbBuscarIdLoteCargaNomina.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbBuscarIdLoteCargaNomina.ImageOptions.Image")));
            this.sbBuscarIdLoteCargaNomina.ImageOptions.ImageUri.Uri = "Find;Size16x16";
            this.sbBuscarIdLoteCargaNomina.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.sbBuscarIdLoteCargaNomina.Location = new System.Drawing.Point(230, 4);
            this.sbBuscarIdLoteCargaNomina.Name = "sbBuscarIdLoteCargaNomina";
            this.sbBuscarIdLoteCargaNomina.Size = new System.Drawing.Size(77, 23);
            this.sbBuscarIdLoteCargaNomina.TabIndex = 42;
            this.sbBuscarIdLoteCargaNomina.Text = "Buscar";
            this.sbBuscarIdLoteCargaNomina.Click += new System.EventHandler(this.sbBuscarIdLoteCargaNomina_Click);
            // 
            // vwCatTenedoraSABindingSource
            // 
            this.vwCatTenedoraSABindingSource.DataMember = "vwCatTenedoraSA";
            this.vwCatTenedoraSABindingSource.DataSource = this.dbSAICBPODataSet;
            // 
            // vwCatTenedoraSATableAdapter
            // 
            this.vwCatTenedoraSATableAdapter.ClearBeforeFill = true;
            // 
            // vwCatTenedoraSCTableAdapter
            // 
            this.vwCatTenedoraSCTableAdapter.ClearBeforeFill = true;
            // 
            // vwCatClienteTableAdapter
            // 
            this.vwCatClienteTableAdapter.ClearBeforeFill = true;
            // 
            // stpSelOperadorTableAdapter
            // 
            this.stpSelOperadorTableAdapter.ClearBeforeFill = true;
            // 
            // stpSelTipoPeriodoNominaTableAdapter
            // 
            this.stpSelTipoPeriodoNominaTableAdapter.ClearBeforeFill = true;
            // 
            // vwCatBancoLayoutActivoTableAdapter
            // 
            this.vwCatBancoLayoutActivoTableAdapter.ClearBeforeFill = true;
            // 
            // stpSelFormatoLayoutBancoPorIdBancoTableAdapter
            // 
            this.stpSelFormatoLayoutBancoPorIdBancoTableAdapter.ClearBeforeFill = true;
            // 
            // solicitudCancelacionNominaTableAdapter1
            // 
            this.solicitudCancelacionNominaTableAdapter1.ClearBeforeFill = true;
            // 
            // vwCatTenedoraSA_AsimiladosTableAdapter
            // 
            this.vwCatTenedoraSA_AsimiladosTableAdapter.ClearBeforeFill = true;
            // 
            // dbSAICBPODataSetBindingSource
            // 
            this.dbSAICBPODataSetBindingSource.DataSource = this.dbSAICBPODataSet;
            this.dbSAICBPODataSetBindingSource.Position = 0;
            // 
            // dbSAICBPODataSetBindingSource1
            // 
            this.dbSAICBPODataSetBindingSource1.DataSource = this.dbSAICBPODataSet;
            this.dbSAICBPODataSetBindingSource1.Position = 0;
            // 
            // idLoteCargaNominaDataGridViewTextBoxColumn1
            // 
            this.idLoteCargaNominaDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idLoteCargaNominaDataGridViewTextBoxColumn1.DataPropertyName = "IdLoteCargaNomina";
            this.idLoteCargaNominaDataGridViewTextBoxColumn1.HeaderText = "IdLoteCargaNomina";
            this.idLoteCargaNominaDataGridViewTextBoxColumn1.Name = "idLoteCargaNominaDataGridViewTextBoxColumn1";
            this.idLoteCargaNominaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idLoteCargaNominaDataGridViewTextBoxColumn1.Visible = false;
            // 
            // folioLoteCargaNominaDataGridViewTextBoxColumn1
            // 
            this.folioLoteCargaNominaDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.folioLoteCargaNominaDataGridViewTextBoxColumn1.DataPropertyName = "FolioLoteCargaNomina";
            this.folioLoteCargaNominaDataGridViewTextBoxColumn1.HeaderText = "Folio Lote Carga Nomina";
            this.folioLoteCargaNominaDataGridViewTextBoxColumn1.Name = "folioLoteCargaNominaDataGridViewTextBoxColumn1";
            this.folioLoteCargaNominaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // idMonedaDataGridViewTextBoxColumn1
            // 
            this.idMonedaDataGridViewTextBoxColumn1.DataPropertyName = "IdMoneda";
            this.idMonedaDataGridViewTextBoxColumn1.HeaderText = "Moneda";
            this.idMonedaDataGridViewTextBoxColumn1.Name = "idMonedaDataGridViewTextBoxColumn1";
            this.idMonedaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tipoCambioDataGridViewTextBoxColumn
            // 
            this.tipoCambioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.tipoCambioDataGridViewTextBoxColumn.DataPropertyName = "TipoCambio";
            this.tipoCambioDataGridViewTextBoxColumn.HeaderText = "Tipo de Cambio";
            this.tipoCambioDataGridViewTextBoxColumn.Name = "tipoCambioDataGridViewTextBoxColumn";
            this.tipoCambioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nominaAutorizadaDataGridViewCheckBoxColumn
            // 
            this.nominaAutorizadaDataGridViewCheckBoxColumn.DataPropertyName = "NominaAutorizada";
            this.nominaAutorizadaDataGridViewCheckBoxColumn.HeaderText = "Autorizada";
            this.nominaAutorizadaDataGridViewCheckBoxColumn.Name = "nominaAutorizadaDataGridViewCheckBoxColumn";
            this.nominaAutorizadaDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // nominaPorCancelarDataGridViewTextBoxColumn
            // 
            this.nominaPorCancelarDataGridViewTextBoxColumn.DataPropertyName = "NominaPorCancelar";
            this.nominaPorCancelarDataGridViewTextBoxColumn.HeaderText = "Por Cancelar";
            this.nominaPorCancelarDataGridViewTextBoxColumn.Name = "nominaPorCancelarDataGridViewTextBoxColumn";
            this.nominaPorCancelarDataGridViewTextBoxColumn.ReadOnly = true;
            this.nominaPorCancelarDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nominaPorCancelarDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // stpSelLayoutBanorte2016TableAdapter1
            // 
            this.stpSelLayoutBanorte2016TableAdapter1.ClearBeforeFill = true;
            // 
            // btnAbrirCarpetaLayOut
            // 
            this.btnAbrirCarpetaLayOut.ImageOptions.Image = global::winAppSAIC.Properties.Resources.if_folder_416376;
            this.btnAbrirCarpetaLayOut.Location = new System.Drawing.Point(589, 77);
            this.btnAbrirCarpetaLayOut.Name = "btnAbrirCarpetaLayOut";
            this.btnAbrirCarpetaLayOut.Size = new System.Drawing.Size(24, 30);
            this.btnAbrirCarpetaLayOut.TabIndex = 13;
            this.btnAbrirCarpetaLayOut.ToolTip = "Abrir Carpeta LayOut";
            this.btnAbrirCarpetaLayOut.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // cboLeyendaDispersion
            // 
            this.cboLeyendaDispersion.DataSource = this.leyendaDispersionBindingSource;
            this.cboLeyendaDispersion.DisplayMember = "DescLeyendaDispersion";
            this.cboLeyendaDispersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLeyendaDispersion.FormattingEnabled = true;
            this.cboLeyendaDispersion.Location = new System.Drawing.Point(131, 73);
            this.cboLeyendaDispersion.Name = "cboLeyendaDispersion";
            this.cboLeyendaDispersion.Size = new System.Drawing.Size(200, 21);
            this.cboLeyendaDispersion.TabIndex = 12;
            this.cboLeyendaDispersion.ValueMember = "IdLeyendaDispersion";
            this.cboLeyendaDispersion.Visible = false;
            // 
            // lblLeyendaDispersion
            // 
            this.lblLeyendaDispersion.AutoSize = true;
            this.lblLeyendaDispersion.Location = new System.Drawing.Point(21, 77);
            this.lblLeyendaDispersion.Name = "lblLeyendaDispersion";
            this.lblLeyendaDispersion.Size = new System.Drawing.Size(104, 13);
            this.lblLeyendaDispersion.TabIndex = 11;
            this.lblLeyendaDispersion.Text = "Leyenda Dispersión:";
            this.lblLeyendaDispersion.Visible = false;
            // 
            // txtEmisora
            // 
            this.txtEmisora.Enabled = false;
            this.txtEmisora.Location = new System.Drawing.Point(524, 20);
            this.txtEmisora.Name = "txtEmisora";
            this.txtEmisora.Properties.Mask.EditMask = "00000";
            this.txtEmisora.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtEmisora.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtEmisora.Properties.MaxLength = 5;
            this.txtEmisora.Size = new System.Drawing.Size(92, 20);
            this.txtEmisora.TabIndex = 7;
            // 
            // lblEmisora
            // 
            this.lblEmisora.AutoSize = true;
            this.lblEmisora.Location = new System.Drawing.Point(466, 24);
            this.lblEmisora.Name = "lblEmisora";
            this.lblEmisora.Size = new System.Drawing.Size(48, 13);
            this.lblEmisora.TabIndex = 6;
            this.lblEmisora.Text = "Emisora:";
            // 
            // speNoSecuencia
            // 
            this.speNoSecuencia.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.speNoSecuencia.Location = new System.Drawing.Point(524, 46);
            this.speNoSecuencia.Name = "speNoSecuencia";
            this.speNoSecuencia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.speNoSecuencia.Size = new System.Drawing.Size(92, 20);
            this.speNoSecuencia.TabIndex = 9;
            // 
            // lblNoSecuencia
            // 
            this.lblNoSecuencia.AutoSize = true;
            this.lblNoSecuencia.Location = new System.Drawing.Point(372, 50);
            this.lblNoSecuencia.Name = "lblNoSecuencia";
            this.lblNoSecuencia.Size = new System.Drawing.Size(142, 13);
            this.lblNoSecuencia.TabIndex = 8;
            this.lblNoSecuencia.Text = "No. Secuencia/Consecutivo:";
            // 
            // btnLayoutBancario
            // 
            this.btnLayoutBancario.Appearance.BackColor = System.Drawing.Color.White;
            this.btnLayoutBancario.Appearance.Options.UseBackColor = true;
            this.btnLayoutBancario.Appearance.Options.UseTextOptions = true;
            this.btnLayoutBancario.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnLayoutBancario.ImageOptions.Image = global::winAppSAIC.Properties.Resources.cd_add;
            this.btnLayoutBancario.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnLayoutBancario.Location = new System.Drawing.Point(424, 77);
            this.btnLayoutBancario.LookAndFeel.SkinName = "VS2010";
            this.btnLayoutBancario.Name = "btnLayoutBancario";
            this.btnLayoutBancario.Size = new System.Drawing.Size(163, 30);
            this.btnLayoutBancario.TabIndex = 10;
            this.btnLayoutBancario.Text = "Generar Archivo Banco";
            this.btnLayoutBancario.Click += new System.EventHandler(this.btnLayoutBancario_Click_1);
            // 
            // dtFechaPago
            // 
            this.dtFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaPago.Location = new System.Drawing.Point(131, 100);
            this.dtFechaPago.Name = "dtFechaPago";
            this.dtFechaPago.Size = new System.Drawing.Size(92, 21);
            this.dtFechaPago.TabIndex = 5;
            // 
            // lblFechaPago
            // 
            this.lblFechaPago.AutoSize = true;
            this.lblFechaPago.Location = new System.Drawing.Point(43, 104);
            this.lblFechaPago.Name = "lblFechaPago";
            this.lblFechaPago.Size = new System.Drawing.Size(82, 13);
            this.lblFechaPago.TabIndex = 4;
            this.lblFechaPago.Text = "Fecha de Pago:";
            // 
            // cboFormatoBanco
            // 
            this.cboFormatoBanco.DataSource = this.stpSelFormatoLayoutBancoPorIdBancoBindingSource;
            this.cboFormatoBanco.DisplayMember = "DescFormatoLayoutBanco";
            this.cboFormatoBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFormatoBanco.FormattingEnabled = true;
            this.cboFormatoBanco.Location = new System.Drawing.Point(131, 46);
            this.cboFormatoBanco.Name = "cboFormatoBanco";
            this.cboFormatoBanco.Size = new System.Drawing.Size(200, 21);
            this.cboFormatoBanco.TabIndex = 3;
            this.cboFormatoBanco.ValueMember = "IdFormatoLayoutBanco";
            this.cboFormatoBanco.SelectedIndexChanged += new System.EventHandler(this.cboFormatoBanco_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seleccione el Formato:";
            // 
            // cboIdBanco
            // 
            this.cboIdBanco.DataSource = this.vwCatBancoLayoutActivoBindingSource;
            this.cboIdBanco.DisplayMember = "NombreBanco";
            this.cboIdBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdBanco.FormattingEnabled = true;
            this.cboIdBanco.Location = new System.Drawing.Point(131, 20);
            this.cboIdBanco.Name = "cboIdBanco";
            this.cboIdBanco.Size = new System.Drawing.Size(162, 21);
            this.cboIdBanco.TabIndex = 1;
            this.cboIdBanco.ValueMember = "IdBanco";
            this.cboIdBanco.SelectedIndexChanged += new System.EventHandler(this.cboIdBanco_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione el Banco:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(153)))), ((int)(((byte)(205)))));
            this.panel1.Controls.Add(this.txtLote);
            this.panel1.Controls.Add(this.txtIdLote);
            this.panel1.Controls.Add(this.lblIdLoteCargaNomina);
            this.panel1.Controls.Add(this.sbBuscarIdLoteCargaNomina);
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(871, 31);
            this.panel1.TabIndex = 44;
            // 
            // txtLote
            // 
            this.txtLote.EditValue = "";
            this.txtLote.Location = new System.Drawing.Point(126, 3);
            this.txtLote.Name = "txtLote";
            this.txtLote.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtLote.Properties.Appearance.Options.UseFont = true;
            this.txtLote.Properties.Appearance.Options.UseTextOptions = true;
            this.txtLote.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtLote.Size = new System.Drawing.Size(100, 26);
            this.txtLote.TabIndex = 17;
            this.txtLote.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLote_KeyPress_1);
            // 
            // txtIdLote
            // 
            this.txtIdLote.Location = new System.Drawing.Point(343, 3);
            this.txtIdLote.Name = "txtIdLote";
            this.txtIdLote.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtIdLote.Properties.Appearance.Options.UseFont = true;
            this.txtIdLote.Properties.Appearance.Options.UseTextOptions = true;
            this.txtIdLote.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtIdLote.Size = new System.Drawing.Size(101, 26);
            this.txtIdLote.TabIndex = 55;
            this.txtIdLote.Visible = false;
            this.txtIdLote.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdLote_KeyPress_1);
            // 
            // lblIdLoteCargaNomina
            // 
            this.lblIdLoteCargaNomina.AutoSize = true;
            this.lblIdLoteCargaNomina.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblIdLoteCargaNomina.ForeColor = System.Drawing.Color.White;
            this.lblIdLoteCargaNomina.Location = new System.Drawing.Point(9, 9);
            this.lblIdLoteCargaNomina.Name = "lblIdLoteCargaNomina";
            this.lblIdLoteCargaNomina.Size = new System.Drawing.Size(116, 13);
            this.lblIdLoteCargaNomina.TabIndex = 44;
            this.lblIdLoteCargaNomina.Text = "Lote Carga Nomina:";
            // 
            // stpSelLayOutBancariosTableAdapter1
            // 
            this.stpSelLayOutBancariosTableAdapter1.ClearBeforeFill = true;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnActualizarFormaPagoLote);
            this.groupControl1.Controls.Add(this.btnMostrarLotes);
            this.groupControl1.Controls.Add(this.btnVisualizarReporte);
            this.groupControl1.Controls.Add(this.btnSolicitarCancelacionNomina);
            this.groupControl1.Location = new System.Drawing.Point(665, 79);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(206, 170);
            this.groupControl1.TabIndex = 45;
            this.groupControl1.Text = "Acciones";
            // 
            // btnActualizarFormaPagoLote
            // 
            this.btnActualizarFormaPagoLote.Appearance.BackColor = System.Drawing.Color.White;
            this.btnActualizarFormaPagoLote.Appearance.Options.UseBackColor = true;
            this.btnActualizarFormaPagoLote.Appearance.Options.UseTextOptions = true;
            this.btnActualizarFormaPagoLote.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnActualizarFormaPagoLote.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizarFormaPagoLote.ImageOptions.Image")));
            this.btnActualizarFormaPagoLote.Location = new System.Drawing.Point(11, 133);
            this.btnActualizarFormaPagoLote.LookAndFeel.SkinName = "VS2010";
            this.btnActualizarFormaPagoLote.Name = "btnActualizarFormaPagoLote";
            this.btnActualizarFormaPagoLote.Size = new System.Drawing.Size(190, 30);
            this.btnActualizarFormaPagoLote.TabIndex = 52;
            this.btnActualizarFormaPagoLote.Text = "Actualizar Forma de Pago";
            this.btnActualizarFormaPagoLote.ToolTip = "Actualizar la forma de pago de los empleados del lote.";
            this.btnActualizarFormaPagoLote.Click += new System.EventHandler(this.btnActualizarFormaPagoLote_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.lblTenedoraSA);
            this.groupControl2.Controls.Add(this.lblCliente);
            this.groupControl2.Controls.Add(this.dtFechaInicio);
            this.groupControl2.Controls.Add(this.lblFechaInicial);
            this.groupControl2.Controls.Add(this.lblTenedoraSC);
            this.groupControl2.Controls.Add(this.gvLotesCargaNomina);
            this.groupControl2.Controls.Add(this.lblLotesCargaNomina);
            this.groupControl2.Controls.Add(this.dtFechaFin);
            this.groupControl2.Controls.Add(this.lblFechaFinal);
            this.groupControl2.Controls.Add(this.cboIdOperador);
            this.groupControl2.Controls.Add(this.lblOperador);
            this.groupControl2.Controls.Add(this.cboIdTenedoraSC);
            this.groupControl2.Controls.Add(this.lblTipoNomina);
            this.groupControl2.Controls.Add(this.cboIdTenedoraSA);
            this.groupControl2.Controls.Add(this.cboIdTipoPeriodoNomina);
            this.groupControl2.Controls.Add(this.cboIdCliente);
            this.groupControl2.Location = new System.Drawing.Point(8, 198);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(651, 284);
            this.groupControl2.TabIndex = 46;
            this.groupControl2.Text = "Lote";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.btnAbrirCarpetaLayOut);
            this.groupControl3.Controls.Add(this.label1);
            this.groupControl3.Controls.Add(this.cboLeyendaDispersion);
            this.groupControl3.Controls.Add(this.cboIdBanco);
            this.groupControl3.Controls.Add(this.lblLeyendaDispersion);
            this.groupControl3.Controls.Add(this.label2);
            this.groupControl3.Controls.Add(this.txtEmisora);
            this.groupControl3.Controls.Add(this.cboFormatoBanco);
            this.groupControl3.Controls.Add(this.lblEmisora);
            this.groupControl3.Controls.Add(this.lblFechaPago);
            this.groupControl3.Controls.Add(this.speNoSecuencia);
            this.groupControl3.Controls.Add(this.dtFechaPago);
            this.groupControl3.Controls.Add(this.lblNoSecuencia);
            this.groupControl3.Controls.Add(this.btnLayoutBancario);
            this.groupControl3.Location = new System.Drawing.Point(8, 488);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(651, 134);
            this.groupControl3.TabIndex = 47;
            this.groupControl3.Text = "Sección Layout Bancario";
            // 
            // stpSelObtenerInfoEmpleadosLoteCargaNominaTableAdapter1
            // 
            this.stpSelObtenerInfoEmpleadosLoteCargaNominaTableAdapter1.ClearBeforeFill = true;
            // 
            // frmxImprimirRecibos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 693);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.btnAutorizarNomina);
            this.Controls.Add(this.chkVisualizarMovsBancarios);
            this.Controls.Add(this.gbSeleccioneTipoRecibo);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnAutorizarNominaCFDI);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmxImprimirRecibos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administración de Recibos de Nómina y Layout Bancarios";
            this.Load += new System.EventHandler(this.frmxImprimirRecibos_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gbSeleccioneTipoRecibo.ResumeLayout(false);
            this.gbSeleccioneTipoRecibo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelTipoPeriodoNominaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLotesCargaNomina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelLoteCargaNominaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leyendaDispersionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelFormatoLayoutBancoPorIdBancoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCatBancoLayoutActivoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOValidacionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOReportesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboIdOperador.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelOperadorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboIdTenedoraSC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCatTenedoraSCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboIdTenedoraSA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCatTenedoraSAAsimiladosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboIdCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCatClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCatTenedoraSABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPODataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPODataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmisora.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speNoSecuencia.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdLote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.GroupBox gbSeleccioneTipoRecibo;
        private System.Windows.Forms.RadioButton rbReporteNominaSC;
        private System.Windows.Forms.RadioButton rbReporteNominaSA;
        private System.Windows.Forms.RadioButton rbAcuseTenedoraSC;
        private System.Windows.Forms.RadioButton rbAcuseTenedoraSA;
        private System.Windows.Forms.RadioButton rbTenedoraSA;
        private System.Windows.Forms.RadioButton rbTenedoraSC;
        private System.Windows.Forms.ComboBox cboIdTipoPeriodoNomina;
        private System.Windows.Forms.Label lblTipoNomina;
        private System.Windows.Forms.Label lblOperador;
        private System.Windows.Forms.Label lblFechaFinal;
        private System.Windows.Forms.DateTimePicker dtFechaFin;
        private System.Windows.Forms.Label lblTenedoraSC;
        private System.Windows.Forms.Label lblFechaInicial;
        private System.Windows.Forms.DateTimePicker dtFechaInicio;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblTenedoraSA;
        private dbSAICBPODataSet dbSAICBPODataSet;
        private System.Windows.Forms.BindingSource vwCatTenedoraSABindingSource;
        private dbSAICBPODataSetTableAdapters.vwCatTenedoraSATableAdapter vwCatTenedoraSATableAdapter;
        private System.Windows.Forms.BindingSource vwCatTenedoraSCBindingSource;
        private dbSAICBPODataSetTableAdapters.vwCatTenedoraSCTableAdapter vwCatTenedoraSCTableAdapter;
        private System.Windows.Forms.BindingSource vwCatClienteBindingSource;
        private dbSAICBPODataSetTableAdapters.vwCatClienteTableAdapter vwCatClienteTableAdapter;
        private System.Windows.Forms.BindingSource stpSelOperadorBindingSource;
        private dbSAICBPODataSetTableAdapters.stpSelOperadorTableAdapter stpSelOperadorTableAdapter;
        private System.Windows.Forms.BindingSource stpSelTipoPeriodoNominaBindingSource;
        private dbSAICBPODataSetTableAdapters.stpSelTipoPeriodoNominaTableAdapter stpSelTipoPeriodoNominaTableAdapter;
        private DevExpress.XtraEditors.SimpleButton btnVisualizarReporte;
        private DevExpress.XtraEditors.SimpleButton btnMostrarLotes;
        private DevExpress.XtraEditors.SimpleButton btnAutorizarNomina;
        private System.Windows.Forms.DataGridView gvLotesCargaNomina;
        private System.Windows.Forms.Label lblLotesCargaNomina;
        private System.Windows.Forms.BindingSource stpSelLoteCargaNominaBindingSource;
        private System.Windows.Forms.BindingSource vwCatBancoLayoutActivoBindingSource;
        private dbSAICBPODataSetTableAdapters.vwCatBancoLayoutActivoTableAdapter vwCatBancoLayoutActivoTableAdapter;
        private dbSAICBPODataSetTableAdapters.stpSelFormatoLayoutBancoPorIdBancoTableAdapter stpSelFormatoLayoutBancoPorIdBancoTableAdapter;
        private dbSAICBPOValidacionDataSetTableAdapters.stpSelInfoBancoCuentasLayoutTableAdapter stpSelInfoBancoCuentasLayoutTableAdapter;
        private dbSAICBPOValidacionDataSet dbSAICBPOValidacionDataSet;
        private dbSAICBPOReportesDataSetTableAdapters.stpSelLayoutBanamexTEFC05TableAdapter stpSelLayoutBanamexTEFC05TableAdapter;
        private dbSAICBPOReportesDataSet dbSAICBPOReportesDataSet;
        private dbSAICBPOReportesDataSetTableAdapters.stpSelLayoutBanamexTEFC12TableAdapter stpSelLayoutBanamexTEFC12TableAdapter;
        private System.Windows.Forms.CheckBox chkVisualizarMovsBancarios;
        private dbSAICBPOReportesDataSetTableAdapters.stpSelLayoutBanamexTEFD05TableAdapter stpSelLayoutBanamexTEFD05TableAdapter;
        private dbSAICBPOReportesDataSetTableAdapters.stpSelLayoutBanamexTEFD12TableAdapter stpSelLayoutBanamexTEFD12TableAdapter;
        private System.Windows.Forms.BindingSource stpSelFormatoLayoutBancoPorIdBancoBindingSource;
        private System.Windows.Forms.RadioButton rbRelacionChequesSC;
        private System.Windows.Forms.RadioButton rbRelacionChequesSA;
        private DevExpress.XtraEditors.SimpleButton btnSolicitarCancelacionNomina;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private dbSAICBPOValidacionDataSetTableAdapters.stpSelValidarLoteCargaNominaEnSolicitudCancelacionNominaTableAdapter stpSelValidarLoteCargaNominaEnSolicitudCancelacionNominaTableAdapter1;
        private dbSAICBPODataSetTableAdapters.SolicitudCancelacionNominaTableAdapter solicitudCancelacionNominaTableAdapter1;
        private dbSAICBPOValidacionDataSetTableAdapters.stpSelEstatusNominaContabilizadaTableAdapter stpSelEstatusNominaContabilizadaTableAdapter1;
        private dbSAICBPOReportesDataSetTableAdapters.stpSelLayoutBancomer98TableAdapter stpSelLayoutBancomer98TableAdapter1;
        private dbSAICBPOReportesDataSetTableAdapters.stpSelLayoutBancomer99TableAdapter stpSelLayoutBancomer99TableAdapter1;
        private dbSAICBPOReportesDataSetTableAdapters.stpSelLayoutBanorteTableAdapter stpSelLayoutBanorteTableAdapter1;
        private dbSAICBPOReportesDataSetTableAdapters.stpSelLayoutSantanderTableAdapter stpSelLayoutSantanderTableAdapter1;
        private dbSAICBPOReportesDataSetTableAdapters.stpSelLayoutCIBancoTableAdapter stpSelLayoutCIBancoTableAdapter1;
        private dbSAICBPOReportesDataSetTableAdapters.stpSelLayoutHSBCNominasTableAdapter stpSelLayoutHSBCNominasTableAdapter1;
        private dbSAICBPOReportesDataSetTableAdapters.stpSelLayoutHSBCOtrasCuentasTableAdapter stpSelLayoutHSBCOtrasCuentasTableAdapter1;
        private dbSAICBPOReportesDataSetTableAdapters.stpSelLayoutHSBCSPEITableAdapter stpSelLayoutHSBCSPEITableAdapter1;
        private dbSAICBPOCatalogosDataSet dbSAICBPOCatalogosDataSet;
        private System.Windows.Forms.BindingSource leyendaDispersionBindingSource;
        private dbSAICBPOCatalogosDataSetTableAdapters.LeyendaDispersionTableAdapter leyendaDispersionTableAdapter;
        private System.Windows.Forms.BindingSource vwCatTenedoraSAAsimiladosBindingSource;
        private dbSAICBPODataSetTableAdapters.vwCatTenedoraSA_AsimiladosTableAdapter vwCatTenedoraSA_AsimiladosTableAdapter;
        private DevExpress.XtraEditors.SimpleButton btnAutorizarNominaCFDI;
        private NominaCFDI.dbSAICBPONominaCFDIDataSetTableAdapters.SeguridadTableAdapter seguridadTableAdapter1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashSMCargando;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraEditors.LookUpEdit cboIdOperador;
        private DevExpress.XtraEditors.LookUpEdit cboIdTenedoraSC;
        private DevExpress.XtraEditors.LookUpEdit cboIdTenedoraSA;
        private DevExpress.XtraEditors.LookUpEdit cboIdCliente;
        private dbSAICBPOReportesDataSetTableAdapters.stpSelLayoutHSBCNETNominasTableAdapter stpSelLayoutHSBCNETNominasTableAdapter1;
        private dbSAICBPOReportesDataSetTableAdapters.stpSelLayoutInbursaSPEITableAdapter stpSelLayoutInbursaSPEITableAdapter1;
        private dbSAICBPOReportesDataSetTableAdapters.stpSelLayoutBanorteInterbancarioTableAdapter stpSelLayoutBanorteInterbancarioTableAdapter1;
        private dbSAICBPOReportesDataSetTableAdapters.stpSelLayoutBanorteInterbancario2016TableAdapter stpSelLayoutBanorteInterbancario2016TableAdapter1;
        private Catalogos.dbSAICBPO_CatalogosValidacionDataSetTableAdapters.ValidacionesGeneralTableAdapter validacionesGeneralTableAdapter1;
        private dbSAICBPODataSetTableAdapters.stpSelLoteCargaNominaTableAdapter stpSelLoteCargaNominaTableAdapter;
        private DevExpress.XtraEditors.SimpleButton sbBuscarIdLoteCargaNomina;
        private System.Windows.Forms.BindingSource dbSAICBPODataSetBindingSource;
        private System.Windows.Forms.BindingSource dbSAICBPODataSetBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLoteCargaNominaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn folioLoteCargaNominaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMonedaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoCambioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn nominaAutorizadaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn nominaPorCancelarDataGridViewTextBoxColumn;
        private dbSAICBPOReportesDataSetTableAdapters.stpSelLayoutBanorte2016TableAdapter stpSelLayoutBanorte2016TableAdapter1;
        private System.Windows.Forms.ComboBox cboLeyendaDispersion;
        private System.Windows.Forms.Label lblLeyendaDispersion;
        private DevExpress.XtraEditors.TextEdit txtEmisora;
        private System.Windows.Forms.Label lblEmisora;
        private DevExpress.XtraEditors.SpinEdit speNoSecuencia;
        private System.Windows.Forms.Label lblNoSecuencia;
        private DevExpress.XtraEditors.SimpleButton btnLayoutBancario;
        private System.Windows.Forms.DateTimePicker dtFechaPago;
        private System.Windows.Forms.Label lblFechaPago;
        private System.Windows.Forms.ComboBox cboFormatoBanco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboIdBanco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Panel panel1;
        private dbSAICBPODataSetTableAdapters.stpUpdAutorizacionNominaTableAdapter stpUpdAutorizacionNominaTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLoteCargaNominaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn folioLoteCargaNominaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMonedaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoCambio;
        private System.Windows.Forms.DataGridViewCheckBoxColumn NominaAutorizada;
        private System.Windows.Forms.DataGridViewCheckBoxColumn NominaPorCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdControlOperacion;
        private DevExpress.XtraEditors.SimpleButton btnAbrirCarpetaLayOut;
        private dbSAICBPOReportesDataSetTableAdapters.stpSelLayOutBancariosTableAdapter stpSelLayOutBancariosTableAdapter1;
        private System.Windows.Forms.Label lblIdLoteCargaNomina;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnActualizarFormaPagoLote;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelObtenerInfoEmpleadosLoteCargaNominaTableAdapter stpSelObtenerInfoEmpleadosLoteCargaNominaTableAdapter1;
        private DevExpress.XtraEditors.TextEdit txtIdLote;
        private DevExpress.XtraEditors.TextEdit txtLote;
    }
}