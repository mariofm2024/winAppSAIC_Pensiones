namespace winAppSAIC
{
    partial class frmEliminarMovsRecibos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboIdTenedoraSC = new System.Windows.Forms.ComboBox();
            this.vwCatTenedoraSCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPODataSet = new winAppSAIC.dbSAICBPODataSet();
            this.lblFechaInicial = new System.Windows.Forms.Label();
            this.dtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblCliente = new System.Windows.Forms.Label();
            this.cboIdCliente = new System.Windows.Forms.ComboBox();
            this.vwCatClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboIdTenedoraSA = new System.Windows.Forms.ComboBox();
            this.vwCatTenedoraSABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.vwCatTenedoraSATableAdapter = new winAppSAIC.dbSAICBPODataSetTableAdapters.vwCatTenedoraSATableAdapter();
            this.vwCatTenedoraSCTableAdapter = new winAppSAIC.dbSAICBPODataSetTableAdapters.vwCatTenedoraSCTableAdapter();
            this.vwCatClienteTableAdapter = new winAppSAIC.dbSAICBPODataSetTableAdapters.vwCatClienteTableAdapter();
            this.stpSelEliminarRecibosEmpleadosHeaderSABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stpSelEliminarRecibosEmpleadosHeaderSCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stpSelEliminarRecibosEmpleadosHeaderSATableAdapter = new winAppSAIC.dbSAICBPODataSetTableAdapters.stpSelEliminarRecibosEmpleadosHeaderSATableAdapter();
            this.stpSelEliminarRecibosEmpleadosHeaderSCTableAdapter = new winAppSAIC.dbSAICBPODataSetTableAdapters.stpSelEliminarRecibosEmpleadosHeaderSCTableAdapter();
            this.lblFechaFinal = new System.Windows.Forms.Label();
            this.dtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.cboIdTipoPeriodoNomina = new System.Windows.Forms.ComboBox();
            this.stpSelTipoPeriodoNominaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblTipoNomina = new System.Windows.Forms.Label();
            this.cboIdOperador = new System.Windows.Forms.ComboBox();
            this.stpSelOperadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblOperador = new System.Windows.Forms.Label();
            this.stpSelOperadorTableAdapter = new winAppSAIC.dbSAICBPODataSetTableAdapters.stpSelOperadorTableAdapter();
            this.stpSelTipoPeriodoNominaTableAdapter = new winAppSAIC.dbSAICBPODataSetTableAdapters.stpSelTipoPeriodoNominaTableAdapter();
            this.lblNumRegistrosSA = new System.Windows.Forms.Label();
            this.lblNumRegistrosSC = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNumMovsAhorro = new System.Windows.Forms.Label();
            this.lblVisualizacionMovsAhorro = new System.Windows.Forms.Label();
            this.gvVisualizacionMovsAhorro = new System.Windows.Forms.DataGridView();
            this.tipoNominaDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicioDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFinDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noEmpleadoDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreEmpleadoDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nSSDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rFCDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cURPDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acumuladoAguinaldoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acumuladoPrimaVacacionalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionesDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stpSelEliminarMovsHeaderAhorroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblVisualizacionRecibosSC = new System.Windows.Forms.Label();
            this.gvVisualizacionRecibosSC = new System.Windows.Forms.DataGridView();
            this.tipoNominaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicioDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFinDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noEmpleadoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreEmpleadoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nSSDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rFCDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cURPDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noReciboDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sueldoBrutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAlimentosBrutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAlimentosNetoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoPagoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noCuentaBancoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descBancoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionesDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblVisualizacionRecibosSA = new System.Windows.Forms.Label();
            this.gvVisualizacionRecibosSA = new System.Windows.Forms.DataGridView();
            this.tipoNominaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noEmpleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreEmpleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nSSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rFCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cURPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaIngresoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noReciboDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diasPagarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoTotalPercepcionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoTotalDeduccionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoNetoPagarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoPagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noCuentaBancoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descBancoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diasJornadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stpSelEliminarMovsHeaderAhorroTableAdapter = new winAppSAIC.dbSAICBPODataSetTableAdapters.stpSelEliminarMovsHeaderAhorroTableAdapter();
            this.rbTenedoraSC = new System.Windows.Forms.RadioButton();
            this.rbTenedoraSA = new System.Windows.Forms.RadioButton();
            this.btnVisualizarMovs = new DevExpress.XtraEditors.SimpleButton();
            this.gvLotesCargaNomina = new System.Windows.Forms.DataGridView();
            this.idLoteCargaNominaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.folioLoteCargaNominaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMonedaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoCambioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nominaAutorizadaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.stpSelLoteCargaNominaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnMostrarLotes = new DevExpress.XtraEditors.SimpleButton();
            this.lblLotesCargaNomina = new System.Windows.Forms.Label();
            this.stpSelLoteCargaNominaTableAdapter = new winAppSAIC.dbSAICBPODataSetTableAdapters.stpSelLoteCargaNominaTableAdapter();
            this.btnEliminarMovs = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.vwCatTenedoraSCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCatClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCatTenedoraSABindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelEliminarRecibosEmpleadosHeaderSABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelEliminarRecibosEmpleadosHeaderSCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelTipoPeriodoNominaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelOperadorBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvVisualizacionMovsAhorro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelEliminarMovsHeaderAhorroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVisualizacionRecibosSC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVisualizacionRecibosSA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLotesCargaNomina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelLoteCargaNominaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cboIdTenedoraSC
            // 
            this.cboIdTenedoraSC.DataSource = this.vwCatTenedoraSCBindingSource;
            this.cboIdTenedoraSC.DisplayMember = "NombreComercial";
            this.cboIdTenedoraSC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdTenedoraSC.Enabled = false;
            this.cboIdTenedoraSC.FormattingEnabled = true;
            this.cboIdTenedoraSC.Location = new System.Drawing.Point(113, 64);
            this.cboIdTenedoraSC.Name = "cboIdTenedoraSC";
            this.cboIdTenedoraSC.Size = new System.Drawing.Size(525, 21);
            this.cboIdTenedoraSC.TabIndex = 4;
            this.cboIdTenedoraSC.ValueMember = "IdTenedora";
            // 
            // vwCatTenedoraSCBindingSource
            // 
            this.vwCatTenedoraSCBindingSource.DataMember = "vwCatTenedoraSC";
            this.vwCatTenedoraSCBindingSource.DataSource = this.dbSAICBPODataSet;
            // 
            // dbSAICBPODataSet
            // 
            this.dbSAICBPODataSet.DataSetName = "dbSAICBPODataSet";
            this.dbSAICBPODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblFechaInicial
            // 
            this.lblFechaInicial.AutoSize = true;
            this.lblFechaInicial.Location = new System.Drawing.Point(250, 149);
            this.lblFechaInicial.Name = "lblFechaInicial";
            this.lblFechaInicial.Size = new System.Drawing.Size(67, 13);
            this.lblFechaInicial.TabIndex = 11;
            this.lblFechaInicial.Text = "Fecha Inicial";
            // 
            // dtFechaInicio
            // 
            this.dtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaInicio.Location = new System.Drawing.Point(323, 145);
            this.dtFechaInicio.Name = "dtFechaInicio";
            this.dtFechaInicio.Size = new System.Drawing.Size(92, 20);
            this.dtFechaInicio.TabIndex = 12;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(17, 96);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 5;
            this.lblCliente.Text = "Cliente";
            // 
            // cboIdCliente
            // 
            this.cboIdCliente.DataSource = this.vwCatClienteBindingSource;
            this.cboIdCliente.DisplayMember = "NombreComercial";
            this.cboIdCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdCliente.FormattingEnabled = true;
            this.cboIdCliente.Location = new System.Drawing.Point(114, 91);
            this.cboIdCliente.Name = "cboIdCliente";
            this.cboIdCliente.Size = new System.Drawing.Size(525, 21);
            this.cboIdCliente.TabIndex = 6;
            this.cboIdCliente.ValueMember = "IdCliente";
            // 
            // vwCatClienteBindingSource
            // 
            this.vwCatClienteBindingSource.DataMember = "vwCatCliente";
            this.vwCatClienteBindingSource.DataSource = this.dbSAICBPODataSet;
            // 
            // cboIdTenedoraSA
            // 
            this.cboIdTenedoraSA.DataSource = this.vwCatTenedoraSABindingSource;
            this.cboIdTenedoraSA.DisplayMember = "NombreComercial";
            this.cboIdTenedoraSA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdTenedoraSA.FormattingEnabled = true;
            this.cboIdTenedoraSA.Location = new System.Drawing.Point(114, 35);
            this.cboIdTenedoraSA.Name = "cboIdTenedoraSA";
            this.cboIdTenedoraSA.Size = new System.Drawing.Size(525, 21);
            this.cboIdTenedoraSA.TabIndex = 2;
            this.cboIdTenedoraSA.ValueMember = "IdTenedora";
            // 
            // vwCatTenedoraSABindingSource
            // 
            this.vwCatTenedoraSABindingSource.DataMember = "vwCatTenedoraSA";
            this.vwCatTenedoraSABindingSource.DataSource = this.dbSAICBPODataSet;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(797, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
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
            // stpSelEliminarRecibosEmpleadosHeaderSABindingSource
            // 
            this.stpSelEliminarRecibosEmpleadosHeaderSABindingSource.DataMember = "stpSelEliminarRecibosEmpleadosHeaderSA";
            this.stpSelEliminarRecibosEmpleadosHeaderSABindingSource.DataSource = this.dbSAICBPODataSet;
            // 
            // stpSelEliminarRecibosEmpleadosHeaderSCBindingSource
            // 
            this.stpSelEliminarRecibosEmpleadosHeaderSCBindingSource.DataMember = "stpSelEliminarRecibosEmpleadosHeaderSC";
            this.stpSelEliminarRecibosEmpleadosHeaderSCBindingSource.DataSource = this.dbSAICBPODataSet;
            // 
            // stpSelEliminarRecibosEmpleadosHeaderSATableAdapter
            // 
            this.stpSelEliminarRecibosEmpleadosHeaderSATableAdapter.ClearBeforeFill = true;
            // 
            // stpSelEliminarRecibosEmpleadosHeaderSCTableAdapter
            // 
            this.stpSelEliminarRecibosEmpleadosHeaderSCTableAdapter.ClearBeforeFill = true;
            // 
            // lblFechaFinal
            // 
            this.lblFechaFinal.AutoSize = true;
            this.lblFechaFinal.Location = new System.Drawing.Point(421, 149);
            this.lblFechaFinal.Name = "lblFechaFinal";
            this.lblFechaFinal.Size = new System.Drawing.Size(62, 13);
            this.lblFechaFinal.TabIndex = 13;
            this.lblFechaFinal.Text = "Fecha Final";
            // 
            // dtFechaFin
            // 
            this.dtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaFin.Location = new System.Drawing.Point(489, 145);
            this.dtFechaFin.Name = "dtFechaFin";
            this.dtFechaFin.Size = new System.Drawing.Size(92, 20);
            this.dtFechaFin.TabIndex = 14;
            // 
            // cboIdTipoPeriodoNomina
            // 
            this.cboIdTipoPeriodoNomina.DataSource = this.stpSelTipoPeriodoNominaBindingSource;
            this.cboIdTipoPeriodoNomina.DisplayMember = "DescTipoPeriodoNomina";
            this.cboIdTipoPeriodoNomina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdTipoPeriodoNomina.FormattingEnabled = true;
            this.cboIdTipoPeriodoNomina.Location = new System.Drawing.Point(113, 145);
            this.cboIdTipoPeriodoNomina.Name = "cboIdTipoPeriodoNomina";
            this.cboIdTipoPeriodoNomina.Size = new System.Drawing.Size(131, 21);
            this.cboIdTipoPeriodoNomina.TabIndex = 10;
            this.cboIdTipoPeriodoNomina.ValueMember = "IdTipoPeriodoNomina";
            // 
            // stpSelTipoPeriodoNominaBindingSource
            // 
            this.stpSelTipoPeriodoNominaBindingSource.DataMember = "stpSelTipoPeriodoNomina";
            this.stpSelTipoPeriodoNominaBindingSource.DataSource = this.dbSAICBPODataSet;
            // 
            // lblTipoNomina
            // 
            this.lblTipoNomina.AutoSize = true;
            this.lblTipoNomina.Location = new System.Drawing.Point(17, 150);
            this.lblTipoNomina.Name = "lblTipoNomina";
            this.lblTipoNomina.Size = new System.Drawing.Size(82, 13);
            this.lblTipoNomina.TabIndex = 9;
            this.lblTipoNomina.Text = "Tipo de Nómina";
            // 
            // cboIdOperador
            // 
            this.cboIdOperador.DataSource = this.stpSelOperadorBindingSource;
            this.cboIdOperador.DisplayMember = "NombreCompletoOperador";
            this.cboIdOperador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdOperador.FormattingEnabled = true;
            this.cboIdOperador.Location = new System.Drawing.Point(113, 118);
            this.cboIdOperador.Name = "cboIdOperador";
            this.cboIdOperador.Size = new System.Drawing.Size(525, 21);
            this.cboIdOperador.TabIndex = 8;
            this.cboIdOperador.ValueMember = "IdOperador";
            // 
            // stpSelOperadorBindingSource
            // 
            this.stpSelOperadorBindingSource.DataMember = "stpSelOperador";
            this.stpSelOperadorBindingSource.DataSource = this.dbSAICBPODataSet;
            // 
            // lblOperador
            // 
            this.lblOperador.AutoSize = true;
            this.lblOperador.Location = new System.Drawing.Point(17, 123);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(51, 13);
            this.lblOperador.TabIndex = 7;
            this.lblOperador.Text = "Operador";
            // 
            // stpSelOperadorTableAdapter
            // 
            this.stpSelOperadorTableAdapter.ClearBeforeFill = true;
            // 
            // stpSelTipoPeriodoNominaTableAdapter
            // 
            this.stpSelTipoPeriodoNominaTableAdapter.ClearBeforeFill = true;
            // 
            // lblNumRegistrosSA
            // 
            this.lblNumRegistrosSA.AutoSize = true;
            this.lblNumRegistrosSA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumRegistrosSA.ForeColor = System.Drawing.Color.Blue;
            this.lblNumRegistrosSA.Location = new System.Drawing.Point(303, 7);
            this.lblNumRegistrosSA.Name = "lblNumRegistrosSA";
            this.lblNumRegistrosSA.Size = new System.Drawing.Size(0, 16);
            this.lblNumRegistrosSA.TabIndex = 19;
            // 
            // lblNumRegistrosSC
            // 
            this.lblNumRegistrosSC.AutoSize = true;
            this.lblNumRegistrosSC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumRegistrosSC.ForeColor = System.Drawing.Color.Blue;
            this.lblNumRegistrosSC.Location = new System.Drawing.Point(303, 161);
            this.lblNumRegistrosSC.Name = "lblNumRegistrosSC";
            this.lblNumRegistrosSC.Size = new System.Drawing.Size(0, 16);
            this.lblNumRegistrosSC.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblNumMovsAhorro);
            this.panel1.Controls.Add(this.lblVisualizacionMovsAhorro);
            this.panel1.Controls.Add(this.lblNumRegistrosSC);
            this.panel1.Controls.Add(this.gvVisualizacionMovsAhorro);
            this.panel1.Controls.Add(this.lblNumRegistrosSA);
            this.panel1.Controls.Add(this.lblVisualizacionRecibosSC);
            this.panel1.Controls.Add(this.gvVisualizacionRecibosSC);
            this.panel1.Controls.Add(this.lblVisualizacionRecibosSA);
            this.panel1.Controls.Add(this.gvVisualizacionRecibosSA);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 312);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 470);
            this.panel1.TabIndex = 21;
            // 
            // lblNumMovsAhorro
            // 
            this.lblNumMovsAhorro.AutoSize = true;
            this.lblNumMovsAhorro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumMovsAhorro.ForeColor = System.Drawing.Color.Blue;
            this.lblNumMovsAhorro.Location = new System.Drawing.Point(303, 314);
            this.lblNumMovsAhorro.Name = "lblNumMovsAhorro";
            this.lblNumMovsAhorro.Size = new System.Drawing.Size(0, 16);
            this.lblNumMovsAhorro.TabIndex = 45;
            // 
            // lblVisualizacionMovsAhorro
            // 
            this.lblVisualizacionMovsAhorro.AutoSize = true;
            this.lblVisualizacionMovsAhorro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisualizacionMovsAhorro.Location = new System.Drawing.Point(10, 317);
            this.lblVisualizacionMovsAhorro.Name = "lblVisualizacionMovsAhorro";
            this.lblVisualizacionMovsAhorro.Size = new System.Drawing.Size(214, 13);
            this.lblVisualizacionMovsAhorro.TabIndex = 43;
            this.lblVisualizacionMovsAhorro.Text = "Visualización de Movimientos Ahorro";
            // 
            // gvVisualizacionMovsAhorro
            // 
            this.gvVisualizacionMovsAhorro.AllowUserToAddRows = false;
            this.gvVisualizacionMovsAhorro.AllowUserToDeleteRows = false;
            this.gvVisualizacionMovsAhorro.AutoGenerateColumns = false;
            this.gvVisualizacionMovsAhorro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvVisualizacionMovsAhorro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipoNominaDataGridViewTextBoxColumn2,
            this.fechaInicioDataGridViewTextBoxColumn2,
            this.fechaFinDataGridViewTextBoxColumn2,
            this.noEmpleadoDataGridViewTextBoxColumn2,
            this.nombreEmpleadoDataGridViewTextBoxColumn2,
            this.nSSDataGridViewTextBoxColumn2,
            this.rFCDataGridViewTextBoxColumn2,
            this.cURPDataGridViewTextBoxColumn2,
            this.acumuladoAguinaldoDataGridViewTextBoxColumn,
            this.acumuladoPrimaVacacionalDataGridViewTextBoxColumn,
            this.observacionesDataGridViewTextBoxColumn2});
            this.gvVisualizacionMovsAhorro.DataSource = this.stpSelEliminarMovsHeaderAhorroBindingSource;
            this.gvVisualizacionMovsAhorro.Location = new System.Drawing.Point(10, 335);
            this.gvVisualizacionMovsAhorro.Name = "gvVisualizacionMovsAhorro";
            this.gvVisualizacionMovsAhorro.ReadOnly = true;
            this.gvVisualizacionMovsAhorro.Size = new System.Drawing.Size(765, 120);
            this.gvVisualizacionMovsAhorro.TabIndex = 44;
            // 
            // tipoNominaDataGridViewTextBoxColumn2
            // 
            this.tipoNominaDataGridViewTextBoxColumn2.DataPropertyName = "Tipo Nomina";
            this.tipoNominaDataGridViewTextBoxColumn2.HeaderText = "Tipo Nomina";
            this.tipoNominaDataGridViewTextBoxColumn2.Name = "tipoNominaDataGridViewTextBoxColumn2";
            this.tipoNominaDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // fechaInicioDataGridViewTextBoxColumn2
            // 
            this.fechaInicioDataGridViewTextBoxColumn2.DataPropertyName = "FechaInicio";
            this.fechaInicioDataGridViewTextBoxColumn2.HeaderText = "Fecha Inicio";
            this.fechaInicioDataGridViewTextBoxColumn2.Name = "fechaInicioDataGridViewTextBoxColumn2";
            this.fechaInicioDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // fechaFinDataGridViewTextBoxColumn2
            // 
            this.fechaFinDataGridViewTextBoxColumn2.DataPropertyName = "FechaFin";
            this.fechaFinDataGridViewTextBoxColumn2.HeaderText = "Fecha Fin";
            this.fechaFinDataGridViewTextBoxColumn2.Name = "fechaFinDataGridViewTextBoxColumn2";
            this.fechaFinDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // noEmpleadoDataGridViewTextBoxColumn2
            // 
            this.noEmpleadoDataGridViewTextBoxColumn2.DataPropertyName = "NoEmpleado";
            this.noEmpleadoDataGridViewTextBoxColumn2.HeaderText = "No. Empleado";
            this.noEmpleadoDataGridViewTextBoxColumn2.Name = "noEmpleadoDataGridViewTextBoxColumn2";
            this.noEmpleadoDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // nombreEmpleadoDataGridViewTextBoxColumn2
            // 
            this.nombreEmpleadoDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nombreEmpleadoDataGridViewTextBoxColumn2.DataPropertyName = "NombreEmpleado";
            this.nombreEmpleadoDataGridViewTextBoxColumn2.HeaderText = "Nombre Empleado";
            this.nombreEmpleadoDataGridViewTextBoxColumn2.Name = "nombreEmpleadoDataGridViewTextBoxColumn2";
            this.nombreEmpleadoDataGridViewTextBoxColumn2.ReadOnly = true;
            this.nombreEmpleadoDataGridViewTextBoxColumn2.Width = 109;
            // 
            // nSSDataGridViewTextBoxColumn2
            // 
            this.nSSDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nSSDataGridViewTextBoxColumn2.DataPropertyName = "NSS";
            this.nSSDataGridViewTextBoxColumn2.HeaderText = "NSS";
            this.nSSDataGridViewTextBoxColumn2.Name = "nSSDataGridViewTextBoxColumn2";
            this.nSSDataGridViewTextBoxColumn2.ReadOnly = true;
            this.nSSDataGridViewTextBoxColumn2.Width = 54;
            // 
            // rFCDataGridViewTextBoxColumn2
            // 
            this.rFCDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.rFCDataGridViewTextBoxColumn2.DataPropertyName = "RFC";
            this.rFCDataGridViewTextBoxColumn2.HeaderText = "RFC";
            this.rFCDataGridViewTextBoxColumn2.Name = "rFCDataGridViewTextBoxColumn2";
            this.rFCDataGridViewTextBoxColumn2.ReadOnly = true;
            this.rFCDataGridViewTextBoxColumn2.Width = 53;
            // 
            // cURPDataGridViewTextBoxColumn2
            // 
            this.cURPDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cURPDataGridViewTextBoxColumn2.DataPropertyName = "CURP";
            this.cURPDataGridViewTextBoxColumn2.HeaderText = "CURP";
            this.cURPDataGridViewTextBoxColumn2.Name = "cURPDataGridViewTextBoxColumn2";
            this.cURPDataGridViewTextBoxColumn2.ReadOnly = true;
            this.cURPDataGridViewTextBoxColumn2.Width = 62;
            // 
            // acumuladoAguinaldoDataGridViewTextBoxColumn
            // 
            this.acumuladoAguinaldoDataGridViewTextBoxColumn.DataPropertyName = "AcumuladoAguinaldo";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.Format = "C2";
            this.acumuladoAguinaldoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle14;
            this.acumuladoAguinaldoDataGridViewTextBoxColumn.HeaderText = "Acumulado Aguinaldo";
            this.acumuladoAguinaldoDataGridViewTextBoxColumn.Name = "acumuladoAguinaldoDataGridViewTextBoxColumn";
            this.acumuladoAguinaldoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // acumuladoPrimaVacacionalDataGridViewTextBoxColumn
            // 
            this.acumuladoPrimaVacacionalDataGridViewTextBoxColumn.DataPropertyName = "AcumuladoPrimaVacacional";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle15.Format = "C2";
            this.acumuladoPrimaVacacionalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle15;
            this.acumuladoPrimaVacacionalDataGridViewTextBoxColumn.HeaderText = "Acumulado Prima Vacacional";
            this.acumuladoPrimaVacacionalDataGridViewTextBoxColumn.Name = "acumuladoPrimaVacacionalDataGridViewTextBoxColumn";
            this.acumuladoPrimaVacacionalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // observacionesDataGridViewTextBoxColumn2
            // 
            this.observacionesDataGridViewTextBoxColumn2.DataPropertyName = "Observaciones";
            this.observacionesDataGridViewTextBoxColumn2.HeaderText = "Observaciones";
            this.observacionesDataGridViewTextBoxColumn2.Name = "observacionesDataGridViewTextBoxColumn2";
            this.observacionesDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // stpSelEliminarMovsHeaderAhorroBindingSource
            // 
            this.stpSelEliminarMovsHeaderAhorroBindingSource.DataMember = "stpSelEliminarMovsHeaderAhorro";
            this.stpSelEliminarMovsHeaderAhorroBindingSource.DataSource = this.dbSAICBPODataSet;
            // 
            // lblVisualizacionRecibosSC
            // 
            this.lblVisualizacionRecibosSC.AutoSize = true;
            this.lblVisualizacionRecibosSC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisualizacionRecibosSC.Location = new System.Drawing.Point(10, 164);
            this.lblVisualizacionRecibosSC.Name = "lblVisualizacionRecibosSC";
            this.lblVisualizacionRecibosSC.Size = new System.Drawing.Size(229, 13);
            this.lblVisualizacionRecibosSC.TabIndex = 21;
            this.lblVisualizacionRecibosSC.Text = "Visualización de Recibos Nóminas S.C.";
            // 
            // gvVisualizacionRecibosSC
            // 
            this.gvVisualizacionRecibosSC.AllowUserToAddRows = false;
            this.gvVisualizacionRecibosSC.AllowUserToDeleteRows = false;
            this.gvVisualizacionRecibosSC.AutoGenerateColumns = false;
            this.gvVisualizacionRecibosSC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvVisualizacionRecibosSC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipoNominaDataGridViewTextBoxColumn1,
            this.fechaInicioDataGridViewTextBoxColumn1,
            this.fechaFinDataGridViewTextBoxColumn1,
            this.noEmpleadoDataGridViewTextBoxColumn1,
            this.nombreEmpleadoDataGridViewTextBoxColumn1,
            this.nSSDataGridViewTextBoxColumn1,
            this.rFCDataGridViewTextBoxColumn1,
            this.cURPDataGridViewTextBoxColumn1,
            this.noReciboDataGridViewTextBoxColumn1,
            this.sueldoBrutoDataGridViewTextBoxColumn,
            this.totalAlimentosBrutoDataGridViewTextBoxColumn,
            this.totalAlimentosNetoDataGridViewTextBoxColumn,
            this.tipoPagoDataGridViewTextBoxColumn1,
            this.noCuentaBancoDataGridViewTextBoxColumn1,
            this.descBancoDataGridViewTextBoxColumn1,
            this.observacionesDataGridViewTextBoxColumn1});
            this.gvVisualizacionRecibosSC.DataSource = this.stpSelEliminarRecibosEmpleadosHeaderSCBindingSource;
            this.gvVisualizacionRecibosSC.Location = new System.Drawing.Point(10, 182);
            this.gvVisualizacionRecibosSC.Name = "gvVisualizacionRecibosSC";
            this.gvVisualizacionRecibosSC.ReadOnly = true;
            this.gvVisualizacionRecibosSC.Size = new System.Drawing.Size(765, 120);
            this.gvVisualizacionRecibosSC.TabIndex = 22;
            // 
            // tipoNominaDataGridViewTextBoxColumn1
            // 
            this.tipoNominaDataGridViewTextBoxColumn1.DataPropertyName = "Tipo Nomina";
            this.tipoNominaDataGridViewTextBoxColumn1.HeaderText = "Tipo Nomina";
            this.tipoNominaDataGridViewTextBoxColumn1.Name = "tipoNominaDataGridViewTextBoxColumn1";
            this.tipoNominaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // fechaInicioDataGridViewTextBoxColumn1
            // 
            this.fechaInicioDataGridViewTextBoxColumn1.DataPropertyName = "FechaInicio";
            this.fechaInicioDataGridViewTextBoxColumn1.HeaderText = "Fecha Inicio";
            this.fechaInicioDataGridViewTextBoxColumn1.Name = "fechaInicioDataGridViewTextBoxColumn1";
            this.fechaInicioDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // fechaFinDataGridViewTextBoxColumn1
            // 
            this.fechaFinDataGridViewTextBoxColumn1.DataPropertyName = "FechaFin";
            this.fechaFinDataGridViewTextBoxColumn1.HeaderText = "Fecha Fin";
            this.fechaFinDataGridViewTextBoxColumn1.Name = "fechaFinDataGridViewTextBoxColumn1";
            this.fechaFinDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // noEmpleadoDataGridViewTextBoxColumn1
            // 
            this.noEmpleadoDataGridViewTextBoxColumn1.DataPropertyName = "NoEmpleado";
            this.noEmpleadoDataGridViewTextBoxColumn1.HeaderText = "No. Empleado";
            this.noEmpleadoDataGridViewTextBoxColumn1.Name = "noEmpleadoDataGridViewTextBoxColumn1";
            this.noEmpleadoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nombreEmpleadoDataGridViewTextBoxColumn1
            // 
            this.nombreEmpleadoDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nombreEmpleadoDataGridViewTextBoxColumn1.DataPropertyName = "NombreEmpleado";
            this.nombreEmpleadoDataGridViewTextBoxColumn1.HeaderText = "Nombre Empleado";
            this.nombreEmpleadoDataGridViewTextBoxColumn1.Name = "nombreEmpleadoDataGridViewTextBoxColumn1";
            this.nombreEmpleadoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nombreEmpleadoDataGridViewTextBoxColumn1.Width = 109;
            // 
            // nSSDataGridViewTextBoxColumn1
            // 
            this.nSSDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nSSDataGridViewTextBoxColumn1.DataPropertyName = "NSS";
            this.nSSDataGridViewTextBoxColumn1.HeaderText = "NSS";
            this.nSSDataGridViewTextBoxColumn1.Name = "nSSDataGridViewTextBoxColumn1";
            this.nSSDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nSSDataGridViewTextBoxColumn1.Width = 54;
            // 
            // rFCDataGridViewTextBoxColumn1
            // 
            this.rFCDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.rFCDataGridViewTextBoxColumn1.DataPropertyName = "RFC";
            this.rFCDataGridViewTextBoxColumn1.HeaderText = "RFC";
            this.rFCDataGridViewTextBoxColumn1.Name = "rFCDataGridViewTextBoxColumn1";
            this.rFCDataGridViewTextBoxColumn1.ReadOnly = true;
            this.rFCDataGridViewTextBoxColumn1.Width = 53;
            // 
            // cURPDataGridViewTextBoxColumn1
            // 
            this.cURPDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cURPDataGridViewTextBoxColumn1.DataPropertyName = "CURP";
            this.cURPDataGridViewTextBoxColumn1.HeaderText = "CURP";
            this.cURPDataGridViewTextBoxColumn1.Name = "cURPDataGridViewTextBoxColumn1";
            this.cURPDataGridViewTextBoxColumn1.ReadOnly = true;
            this.cURPDataGridViewTextBoxColumn1.Width = 62;
            // 
            // noReciboDataGridViewTextBoxColumn1
            // 
            this.noReciboDataGridViewTextBoxColumn1.DataPropertyName = "NoRecibo";
            this.noReciboDataGridViewTextBoxColumn1.HeaderText = "No. Recibo";
            this.noReciboDataGridViewTextBoxColumn1.Name = "noReciboDataGridViewTextBoxColumn1";
            this.noReciboDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // sueldoBrutoDataGridViewTextBoxColumn
            // 
            this.sueldoBrutoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.sueldoBrutoDataGridViewTextBoxColumn.DataPropertyName = "SueldoBruto";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle16.Format = "C2";
            this.sueldoBrutoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle16;
            this.sueldoBrutoDataGridViewTextBoxColumn.HeaderText = "Sueldo Bruto";
            this.sueldoBrutoDataGridViewTextBoxColumn.Name = "sueldoBrutoDataGridViewTextBoxColumn";
            this.sueldoBrutoDataGridViewTextBoxColumn.ReadOnly = true;
            this.sueldoBrutoDataGridViewTextBoxColumn.Width = 86;
            // 
            // totalAlimentosBrutoDataGridViewTextBoxColumn
            // 
            this.totalAlimentosBrutoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.totalAlimentosBrutoDataGridViewTextBoxColumn.DataPropertyName = "TotalAlimentosBruto";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle17.Format = "C2";
            this.totalAlimentosBrutoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle17;
            this.totalAlimentosBrutoDataGridViewTextBoxColumn.HeaderText = "Total Alimentos Bruto";
            this.totalAlimentosBrutoDataGridViewTextBoxColumn.Name = "totalAlimentosBrutoDataGridViewTextBoxColumn";
            this.totalAlimentosBrutoDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalAlimentosBrutoDataGridViewTextBoxColumn.Width = 121;
            // 
            // totalAlimentosNetoDataGridViewTextBoxColumn
            // 
            this.totalAlimentosNetoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.totalAlimentosNetoDataGridViewTextBoxColumn.DataPropertyName = "TotalAlimentosNeto";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle18.Format = "C2";
            this.totalAlimentosNetoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle18;
            this.totalAlimentosNetoDataGridViewTextBoxColumn.HeaderText = "Total Alimentos Neto";
            this.totalAlimentosNetoDataGridViewTextBoxColumn.Name = "totalAlimentosNetoDataGridViewTextBoxColumn";
            this.totalAlimentosNetoDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalAlimentosNetoDataGridViewTextBoxColumn.Width = 119;
            // 
            // tipoPagoDataGridViewTextBoxColumn1
            // 
            this.tipoPagoDataGridViewTextBoxColumn1.DataPropertyName = "TipoPago";
            this.tipoPagoDataGridViewTextBoxColumn1.HeaderText = "Tipo Pago";
            this.tipoPagoDataGridViewTextBoxColumn1.Name = "tipoPagoDataGridViewTextBoxColumn1";
            this.tipoPagoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // noCuentaBancoDataGridViewTextBoxColumn1
            // 
            this.noCuentaBancoDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.noCuentaBancoDataGridViewTextBoxColumn1.DataPropertyName = "NoCuentaBanco";
            this.noCuentaBancoDataGridViewTextBoxColumn1.HeaderText = "No. Cuenta Banco";
            this.noCuentaBancoDataGridViewTextBoxColumn1.Name = "noCuentaBancoDataGridViewTextBoxColumn1";
            this.noCuentaBancoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.noCuentaBancoDataGridViewTextBoxColumn1.Width = 110;
            // 
            // descBancoDataGridViewTextBoxColumn1
            // 
            this.descBancoDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.descBancoDataGridViewTextBoxColumn1.DataPropertyName = "DescBanco";
            this.descBancoDataGridViewTextBoxColumn1.HeaderText = "Banco";
            this.descBancoDataGridViewTextBoxColumn1.Name = "descBancoDataGridViewTextBoxColumn1";
            this.descBancoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.descBancoDataGridViewTextBoxColumn1.Width = 63;
            // 
            // observacionesDataGridViewTextBoxColumn1
            // 
            this.observacionesDataGridViewTextBoxColumn1.DataPropertyName = "Observaciones";
            this.observacionesDataGridViewTextBoxColumn1.HeaderText = "Observaciones";
            this.observacionesDataGridViewTextBoxColumn1.Name = "observacionesDataGridViewTextBoxColumn1";
            this.observacionesDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // lblVisualizacionRecibosSA
            // 
            this.lblVisualizacionRecibosSA.AutoSize = true;
            this.lblVisualizacionRecibosSA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisualizacionRecibosSA.Location = new System.Drawing.Point(10, 10);
            this.lblVisualizacionRecibosSA.Name = "lblVisualizacionRecibosSA";
            this.lblVisualizacionRecibosSA.Size = new System.Drawing.Size(229, 13);
            this.lblVisualizacionRecibosSA.TabIndex = 19;
            this.lblVisualizacionRecibosSA.Text = "Visualización de Recibos Nóminas S.A.";
            // 
            // gvVisualizacionRecibosSA
            // 
            this.gvVisualizacionRecibosSA.AllowUserToAddRows = false;
            this.gvVisualizacionRecibosSA.AllowUserToDeleteRows = false;
            this.gvVisualizacionRecibosSA.AutoGenerateColumns = false;
            this.gvVisualizacionRecibosSA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvVisualizacionRecibosSA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipoNominaDataGridViewTextBoxColumn,
            this.fechaInicioDataGridViewTextBoxColumn,
            this.fechaFinDataGridViewTextBoxColumn,
            this.noEmpleadoDataGridViewTextBoxColumn,
            this.nombreEmpleadoDataGridViewTextBoxColumn,
            this.nSSDataGridViewTextBoxColumn,
            this.rFCDataGridViewTextBoxColumn,
            this.cURPDataGridViewTextBoxColumn,
            this.fechaIngresoDataGridViewTextBoxColumn,
            this.noReciboDataGridViewTextBoxColumn,
            this.sDDataGridViewTextBoxColumn,
            this.sDIDataGridViewTextBoxColumn,
            this.diasPagarDataGridViewTextBoxColumn,
            this.montoTotalPercepcionesDataGridViewTextBoxColumn,
            this.montoTotalDeduccionesDataGridViewTextBoxColumn,
            this.montoNetoPagarDataGridViewTextBoxColumn,
            this.tipoPagoDataGridViewTextBoxColumn,
            this.noCuentaBancoDataGridViewTextBoxColumn,
            this.descBancoDataGridViewTextBoxColumn,
            this.diasJornadaDataGridViewTextBoxColumn,
            this.observacionesDataGridViewTextBoxColumn});
            this.gvVisualizacionRecibosSA.DataSource = this.stpSelEliminarRecibosEmpleadosHeaderSABindingSource;
            this.gvVisualizacionRecibosSA.Location = new System.Drawing.Point(10, 28);
            this.gvVisualizacionRecibosSA.Name = "gvVisualizacionRecibosSA";
            this.gvVisualizacionRecibosSA.ReadOnly = true;
            this.gvVisualizacionRecibosSA.Size = new System.Drawing.Size(765, 120);
            this.gvVisualizacionRecibosSA.TabIndex = 20;
            // 
            // tipoNominaDataGridViewTextBoxColumn
            // 
            this.tipoNominaDataGridViewTextBoxColumn.DataPropertyName = "Tipo Nomina";
            this.tipoNominaDataGridViewTextBoxColumn.HeaderText = "Tipo Nomina";
            this.tipoNominaDataGridViewTextBoxColumn.Name = "tipoNominaDataGridViewTextBoxColumn";
            this.tipoNominaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaInicioDataGridViewTextBoxColumn
            // 
            this.fechaInicioDataGridViewTextBoxColumn.DataPropertyName = "FechaInicio";
            this.fechaInicioDataGridViewTextBoxColumn.HeaderText = "Fecha Inicio";
            this.fechaInicioDataGridViewTextBoxColumn.Name = "fechaInicioDataGridViewTextBoxColumn";
            this.fechaInicioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaFinDataGridViewTextBoxColumn
            // 
            this.fechaFinDataGridViewTextBoxColumn.DataPropertyName = "FechaFin";
            this.fechaFinDataGridViewTextBoxColumn.HeaderText = "Fecha Fin";
            this.fechaFinDataGridViewTextBoxColumn.Name = "fechaFinDataGridViewTextBoxColumn";
            this.fechaFinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noEmpleadoDataGridViewTextBoxColumn
            // 
            this.noEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "NoEmpleado";
            this.noEmpleadoDataGridViewTextBoxColumn.HeaderText = "No. Empleado";
            this.noEmpleadoDataGridViewTextBoxColumn.Name = "noEmpleadoDataGridViewTextBoxColumn";
            this.noEmpleadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreEmpleadoDataGridViewTextBoxColumn
            // 
            this.nombreEmpleadoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nombreEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "NombreEmpleado";
            this.nombreEmpleadoDataGridViewTextBoxColumn.HeaderText = "Nombre Empleado";
            this.nombreEmpleadoDataGridViewTextBoxColumn.Name = "nombreEmpleadoDataGridViewTextBoxColumn";
            this.nombreEmpleadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreEmpleadoDataGridViewTextBoxColumn.Width = 109;
            // 
            // nSSDataGridViewTextBoxColumn
            // 
            this.nSSDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nSSDataGridViewTextBoxColumn.DataPropertyName = "NSS";
            this.nSSDataGridViewTextBoxColumn.HeaderText = "NSS";
            this.nSSDataGridViewTextBoxColumn.Name = "nSSDataGridViewTextBoxColumn";
            this.nSSDataGridViewTextBoxColumn.ReadOnly = true;
            this.nSSDataGridViewTextBoxColumn.Width = 54;
            // 
            // rFCDataGridViewTextBoxColumn
            // 
            this.rFCDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.rFCDataGridViewTextBoxColumn.DataPropertyName = "RFC";
            this.rFCDataGridViewTextBoxColumn.HeaderText = "RFC";
            this.rFCDataGridViewTextBoxColumn.Name = "rFCDataGridViewTextBoxColumn";
            this.rFCDataGridViewTextBoxColumn.ReadOnly = true;
            this.rFCDataGridViewTextBoxColumn.Width = 53;
            // 
            // cURPDataGridViewTextBoxColumn
            // 
            this.cURPDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cURPDataGridViewTextBoxColumn.DataPropertyName = "CURP";
            this.cURPDataGridViewTextBoxColumn.HeaderText = "CURP";
            this.cURPDataGridViewTextBoxColumn.Name = "cURPDataGridViewTextBoxColumn";
            this.cURPDataGridViewTextBoxColumn.ReadOnly = true;
            this.cURPDataGridViewTextBoxColumn.Width = 62;
            // 
            // fechaIngresoDataGridViewTextBoxColumn
            // 
            this.fechaIngresoDataGridViewTextBoxColumn.DataPropertyName = "FechaIngreso";
            this.fechaIngresoDataGridViewTextBoxColumn.HeaderText = "Fecha Ingreso";
            this.fechaIngresoDataGridViewTextBoxColumn.Name = "fechaIngresoDataGridViewTextBoxColumn";
            this.fechaIngresoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noReciboDataGridViewTextBoxColumn
            // 
            this.noReciboDataGridViewTextBoxColumn.DataPropertyName = "NoRecibo";
            this.noReciboDataGridViewTextBoxColumn.HeaderText = "No. Recibo";
            this.noReciboDataGridViewTextBoxColumn.Name = "noReciboDataGridViewTextBoxColumn";
            this.noReciboDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sDDataGridViewTextBoxColumn
            // 
            this.sDDataGridViewTextBoxColumn.DataPropertyName = "SD";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle19.Format = "C2";
            dataGridViewCellStyle19.NullValue = null;
            this.sDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle19;
            this.sDDataGridViewTextBoxColumn.HeaderText = "SD";
            this.sDDataGridViewTextBoxColumn.Name = "sDDataGridViewTextBoxColumn";
            this.sDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sDIDataGridViewTextBoxColumn
            // 
            this.sDIDataGridViewTextBoxColumn.DataPropertyName = "SDI";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle20.Format = "C2";
            dataGridViewCellStyle20.NullValue = null;
            this.sDIDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle20;
            this.sDIDataGridViewTextBoxColumn.HeaderText = "SDI";
            this.sDIDataGridViewTextBoxColumn.Name = "sDIDataGridViewTextBoxColumn";
            this.sDIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diasPagarDataGridViewTextBoxColumn
            // 
            this.diasPagarDataGridViewTextBoxColumn.DataPropertyName = "DiasPagar";
            dataGridViewCellStyle21.Format = "N2";
            dataGridViewCellStyle21.NullValue = null;
            this.diasPagarDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle21;
            this.diasPagarDataGridViewTextBoxColumn.HeaderText = "Dias a Pagar";
            this.diasPagarDataGridViewTextBoxColumn.Name = "diasPagarDataGridViewTextBoxColumn";
            this.diasPagarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // montoTotalPercepcionesDataGridViewTextBoxColumn
            // 
            this.montoTotalPercepcionesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.montoTotalPercepcionesDataGridViewTextBoxColumn.DataPropertyName = "MontoTotalPercepciones";
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle22.Format = "C2";
            dataGridViewCellStyle22.NullValue = null;
            this.montoTotalPercepcionesDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle22;
            this.montoTotalPercepcionesDataGridViewTextBoxColumn.HeaderText = "Total Percepciones";
            this.montoTotalPercepcionesDataGridViewTextBoxColumn.Name = "montoTotalPercepcionesDataGridViewTextBoxColumn";
            this.montoTotalPercepcionesDataGridViewTextBoxColumn.ReadOnly = true;
            this.montoTotalPercepcionesDataGridViewTextBoxColumn.Width = 114;
            // 
            // montoTotalDeduccionesDataGridViewTextBoxColumn
            // 
            this.montoTotalDeduccionesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.montoTotalDeduccionesDataGridViewTextBoxColumn.DataPropertyName = "MontoTotalDeducciones";
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle23.Format = "C2";
            dataGridViewCellStyle23.NullValue = null;
            this.montoTotalDeduccionesDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle23;
            this.montoTotalDeduccionesDataGridViewTextBoxColumn.HeaderText = "Total Deducciones";
            this.montoTotalDeduccionesDataGridViewTextBoxColumn.Name = "montoTotalDeduccionesDataGridViewTextBoxColumn";
            this.montoTotalDeduccionesDataGridViewTextBoxColumn.ReadOnly = true;
            this.montoTotalDeduccionesDataGridViewTextBoxColumn.Width = 112;
            // 
            // montoNetoPagarDataGridViewTextBoxColumn
            // 
            this.montoNetoPagarDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.montoNetoPagarDataGridViewTextBoxColumn.DataPropertyName = "MontoNetoPagar";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle24.Format = "C2";
            dataGridViewCellStyle24.NullValue = null;
            this.montoNetoPagarDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle24;
            this.montoNetoPagarDataGridViewTextBoxColumn.HeaderText = "Neto a Pagar";
            this.montoNetoPagarDataGridViewTextBoxColumn.Name = "montoNetoPagarDataGridViewTextBoxColumn";
            this.montoNetoPagarDataGridViewTextBoxColumn.ReadOnly = true;
            this.montoNetoPagarDataGridViewTextBoxColumn.Width = 88;
            // 
            // tipoPagoDataGridViewTextBoxColumn
            // 
            this.tipoPagoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tipoPagoDataGridViewTextBoxColumn.DataPropertyName = "TipoPago";
            this.tipoPagoDataGridViewTextBoxColumn.HeaderText = "Tipo Pago";
            this.tipoPagoDataGridViewTextBoxColumn.Name = "tipoPagoDataGridViewTextBoxColumn";
            this.tipoPagoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoPagoDataGridViewTextBoxColumn.Width = 75;
            // 
            // noCuentaBancoDataGridViewTextBoxColumn
            // 
            this.noCuentaBancoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.noCuentaBancoDataGridViewTextBoxColumn.DataPropertyName = "NoCuentaBanco";
            this.noCuentaBancoDataGridViewTextBoxColumn.HeaderText = "No. Cuenta Banco";
            this.noCuentaBancoDataGridViewTextBoxColumn.Name = "noCuentaBancoDataGridViewTextBoxColumn";
            this.noCuentaBancoDataGridViewTextBoxColumn.ReadOnly = true;
            this.noCuentaBancoDataGridViewTextBoxColumn.Width = 110;
            // 
            // descBancoDataGridViewTextBoxColumn
            // 
            this.descBancoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.descBancoDataGridViewTextBoxColumn.DataPropertyName = "DescBanco";
            this.descBancoDataGridViewTextBoxColumn.HeaderText = "Banco";
            this.descBancoDataGridViewTextBoxColumn.Name = "descBancoDataGridViewTextBoxColumn";
            this.descBancoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descBancoDataGridViewTextBoxColumn.Width = 63;
            // 
            // diasJornadaDataGridViewTextBoxColumn
            // 
            this.diasJornadaDataGridViewTextBoxColumn.DataPropertyName = "DiasJornada";
            this.diasJornadaDataGridViewTextBoxColumn.HeaderText = "Dias Jornada";
            this.diasJornadaDataGridViewTextBoxColumn.Name = "diasJornadaDataGridViewTextBoxColumn";
            this.diasJornadaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // observacionesDataGridViewTextBoxColumn
            // 
            this.observacionesDataGridViewTextBoxColumn.DataPropertyName = "Observaciones";
            this.observacionesDataGridViewTextBoxColumn.HeaderText = "Observaciones";
            this.observacionesDataGridViewTextBoxColumn.Name = "observacionesDataGridViewTextBoxColumn";
            this.observacionesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stpSelEliminarMovsHeaderAhorroTableAdapter
            // 
            this.stpSelEliminarMovsHeaderAhorroTableAdapter.ClearBeforeFill = true;
            // 
            // rbTenedoraSC
            // 
            this.rbTenedoraSC.AutoSize = true;
            this.rbTenedoraSC.Location = new System.Drawing.Point(17, 66);
            this.rbTenedoraSC.Name = "rbTenedoraSC";
            this.rbTenedoraSC.Size = new System.Drawing.Size(94, 17);
            this.rbTenedoraSC.TabIndex = 3;
            this.rbTenedoraSC.Text = "Tenedora S.C.";
            this.rbTenedoraSC.UseVisualStyleBackColor = true;
            this.rbTenedoraSC.CheckedChanged += new System.EventHandler(this.rbTenedoraSC_CheckedChanged);
            // 
            // rbTenedoraSA
            // 
            this.rbTenedoraSA.AutoSize = true;
            this.rbTenedoraSA.Checked = true;
            this.rbTenedoraSA.Location = new System.Drawing.Point(17, 36);
            this.rbTenedoraSA.Name = "rbTenedoraSA";
            this.rbTenedoraSA.Size = new System.Drawing.Size(94, 17);
            this.rbTenedoraSA.TabIndex = 1;
            this.rbTenedoraSA.TabStop = true;
            this.rbTenedoraSA.Text = "Tenedora S.A.";
            this.rbTenedoraSA.UseVisualStyleBackColor = true;
            this.rbTenedoraSA.CheckedChanged += new System.EventHandler(this.rbTenedoraSA_CheckedChanged);
            // 
            // btnVisualizarMovs
            // 
            this.btnVisualizarMovs.Appearance.BackColor = System.Drawing.Color.White;
            this.btnVisualizarMovs.Appearance.Options.UseBackColor = true;
            this.btnVisualizarMovs.Appearance.Options.UseTextOptions = true;
            this.btnVisualizarMovs.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnVisualizarMovs.Image = global::winAppSAIC.Properties.Resources.ImprimirPreview;
            this.btnVisualizarMovs.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnVisualizarMovs.Location = new System.Drawing.Point(645, 233);
            this.btnVisualizarMovs.LookAndFeel.SkinName = "VS2010";
            this.btnVisualizarMovs.Name = "btnVisualizarMovs";
            this.btnVisualizarMovs.Size = new System.Drawing.Size(132, 30);
            this.btnVisualizarMovs.TabIndex = 55;
            this.btnVisualizarMovs.Text = "&2 ) Visualizar Movs.";
            this.btnVisualizarMovs.Click += new System.EventHandler(this.btnVisualizarMovs_Click);
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
            this.tipoCambioDataGridViewTextBoxColumn,
            this.nominaAutorizadaDataGridViewCheckBoxColumn});
            this.gvLotesCargaNomina.DataSource = this.stpSelLoteCargaNominaBindingSource;
            this.gvLotesCargaNomina.Location = new System.Drawing.Point(17, 197);
            this.gvLotesCargaNomina.Name = "gvLotesCargaNomina";
            this.gvLotesCargaNomina.ReadOnly = true;
            this.gvLotesCargaNomina.Size = new System.Drawing.Size(621, 100);
            this.gvLotesCargaNomina.TabIndex = 54;
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
            this.folioLoteCargaNominaDataGridViewTextBoxColumn.Width = 250;
            // 
            // idMonedaDataGridViewTextBoxColumn
            // 
            this.idMonedaDataGridViewTextBoxColumn.DataPropertyName = "IdMoneda";
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.idMonedaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle25;
            this.idMonedaDataGridViewTextBoxColumn.HeaderText = "Moneda";
            this.idMonedaDataGridViewTextBoxColumn.Name = "idMonedaDataGridViewTextBoxColumn";
            this.idMonedaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idMonedaDataGridViewTextBoxColumn.Width = 70;
            // 
            // tipoCambioDataGridViewTextBoxColumn
            // 
            this.tipoCambioDataGridViewTextBoxColumn.DataPropertyName = "TipoCambio";
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle26.Format = "C2";
            dataGridViewCellStyle26.NullValue = null;
            this.tipoCambioDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle26;
            this.tipoCambioDataGridViewTextBoxColumn.HeaderText = "Tipo de Cambio";
            this.tipoCambioDataGridViewTextBoxColumn.Name = "tipoCambioDataGridViewTextBoxColumn";
            this.tipoCambioDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoCambioDataGridViewTextBoxColumn.Width = 110;
            // 
            // nominaAutorizadaDataGridViewCheckBoxColumn
            // 
            this.nominaAutorizadaDataGridViewCheckBoxColumn.DataPropertyName = "NominaAutorizada";
            this.nominaAutorizadaDataGridViewCheckBoxColumn.HeaderText = "NominaAutorizada";
            this.nominaAutorizadaDataGridViewCheckBoxColumn.Name = "nominaAutorizadaDataGridViewCheckBoxColumn";
            this.nominaAutorizadaDataGridViewCheckBoxColumn.ReadOnly = true;
            this.nominaAutorizadaDataGridViewCheckBoxColumn.Width = 120;
            // 
            // stpSelLoteCargaNominaBindingSource
            // 
            this.stpSelLoteCargaNominaBindingSource.DataMember = "stpSelLoteCargaNomina";
            this.stpSelLoteCargaNominaBindingSource.DataSource = this.dbSAICBPODataSet;
            // 
            // btnMostrarLotes
            // 
            this.btnMostrarLotes.Appearance.BackColor = System.Drawing.Color.White;
            this.btnMostrarLotes.Appearance.Options.UseBackColor = true;
            this.btnMostrarLotes.Appearance.Options.UseTextOptions = true;
            this.btnMostrarLotes.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnMostrarLotes.Image = global::winAppSAIC.Properties.Resources.CascadeWindowsHS;
            this.btnMostrarLotes.Location = new System.Drawing.Point(645, 197);
            this.btnMostrarLotes.LookAndFeel.SkinName = "VS2010";
            this.btnMostrarLotes.Name = "btnMostrarLotes";
            this.btnMostrarLotes.Size = new System.Drawing.Size(132, 30);
            this.btnMostrarLotes.TabIndex = 53;
            this.btnMostrarLotes.Text = "&1 ) Mostrar Lotes";
            this.btnMostrarLotes.Click += new System.EventHandler(this.btnMostrarLotes_Click);
            // 
            // lblLotesCargaNomina
            // 
            this.lblLotesCargaNomina.AutoSize = true;
            this.lblLotesCargaNomina.Location = new System.Drawing.Point(17, 181);
            this.lblLotesCargaNomina.Name = "lblLotesCargaNomina";
            this.lblLotesCargaNomina.Size = new System.Drawing.Size(138, 13);
            this.lblLotesCargaNomina.TabIndex = 52;
            this.lblLotesCargaNomina.Text = "Lotes de Carga de Nóminas";
            // 
            // stpSelLoteCargaNominaTableAdapter
            // 
            this.stpSelLoteCargaNominaTableAdapter.ClearBeforeFill = true;
            // 
            // btnEliminarMovs
            // 
            this.btnEliminarMovs.Appearance.BackColor = System.Drawing.Color.White;
            this.btnEliminarMovs.Appearance.Options.UseBackColor = true;
            this.btnEliminarMovs.Appearance.Options.UseTextOptions = true;
            this.btnEliminarMovs.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnEliminarMovs.Image = global::winAppSAIC.Properties.Resources.Borrar1;
            this.btnEliminarMovs.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnEliminarMovs.Location = new System.Drawing.Point(645, 269);
            this.btnEliminarMovs.LookAndFeel.SkinName = "VS2010";
            this.btnEliminarMovs.Name = "btnEliminarMovs";
            this.btnEliminarMovs.Size = new System.Drawing.Size(132, 30);
            this.btnEliminarMovs.TabIndex = 56;
            this.btnEliminarMovs.Text = "&3 ) Eliminar Movs.";
            this.btnEliminarMovs.Click += new System.EventHandler(this.btnEliminarMovs_Click);
            // 
            // frmEliminarMovsRecibos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 782);
            this.ControlBox = false;
            this.Controls.Add(this.btnEliminarMovs);
            this.Controls.Add(this.btnVisualizarMovs);
            this.Controls.Add(this.gvLotesCargaNomina);
            this.Controls.Add(this.btnMostrarLotes);
            this.Controls.Add(this.lblLotesCargaNomina);
            this.Controls.Add(this.rbTenedoraSC);
            this.Controls.Add(this.rbTenedoraSA);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cboIdTipoPeriodoNomina);
            this.Controls.Add(this.lblTipoNomina);
            this.Controls.Add(this.cboIdOperador);
            this.Controls.Add(this.lblOperador);
            this.Controls.Add(this.lblFechaFinal);
            this.Controls.Add(this.dtFechaFin);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.cboIdTenedoraSC);
            this.Controls.Add(this.lblFechaInicial);
            this.Controls.Add(this.dtFechaInicio);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.cboIdCliente);
            this.Controls.Add(this.cboIdTenedoraSA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmEliminarMovsRecibos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar Movimientos Recibos de Nómina";
            this.Load += new System.EventHandler(this.frmEliminarMovsRecibos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vwCatTenedoraSCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCatClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCatTenedoraSABindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelEliminarRecibosEmpleadosHeaderSABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelEliminarRecibosEmpleadosHeaderSCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelTipoPeriodoNominaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelOperadorBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvVisualizacionMovsAhorro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelEliminarMovsHeaderAhorroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVisualizacionRecibosSC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVisualizacionRecibosSA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLotesCargaNomina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelLoteCargaNominaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboIdTenedoraSC;
        private System.Windows.Forms.Label lblFechaInicial;
        private System.Windows.Forms.DateTimePicker dtFechaInicio;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cboIdCliente;
        private System.Windows.Forms.ComboBox cboIdTenedoraSA;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private dbSAICBPODataSet dbSAICBPODataSet;
        private System.Windows.Forms.BindingSource vwCatTenedoraSABindingSource;
        private dbSAICBPODataSetTableAdapters.vwCatTenedoraSATableAdapter vwCatTenedoraSATableAdapter;
        private System.Windows.Forms.BindingSource vwCatTenedoraSCBindingSource;
        private dbSAICBPODataSetTableAdapters.vwCatTenedoraSCTableAdapter vwCatTenedoraSCTableAdapter;
        private System.Windows.Forms.BindingSource vwCatClienteBindingSource;
        private dbSAICBPODataSetTableAdapters.vwCatClienteTableAdapter vwCatClienteTableAdapter;
        private System.Windows.Forms.BindingSource stpSelEliminarRecibosEmpleadosHeaderSABindingSource;
        private dbSAICBPODataSetTableAdapters.stpSelEliminarRecibosEmpleadosHeaderSATableAdapter stpSelEliminarRecibosEmpleadosHeaderSATableAdapter;
        private System.Windows.Forms.BindingSource stpSelEliminarRecibosEmpleadosHeaderSCBindingSource;
        private dbSAICBPODataSetTableAdapters.stpSelEliminarRecibosEmpleadosHeaderSCTableAdapter stpSelEliminarRecibosEmpleadosHeaderSCTableAdapter;
        private System.Windows.Forms.Label lblFechaFinal;
        private System.Windows.Forms.DateTimePicker dtFechaFin;
        private System.Windows.Forms.ComboBox cboIdTipoPeriodoNomina;
        private System.Windows.Forms.Label lblTipoNomina;
        private System.Windows.Forms.ComboBox cboIdOperador;
        private System.Windows.Forms.Label lblOperador;
        private System.Windows.Forms.BindingSource stpSelOperadorBindingSource;
        private dbSAICBPODataSetTableAdapters.stpSelOperadorTableAdapter stpSelOperadorTableAdapter;
        private System.Windows.Forms.BindingSource stpSelTipoPeriodoNominaBindingSource;
        private dbSAICBPODataSetTableAdapters.stpSelTipoPeriodoNominaTableAdapter stpSelTipoPeriodoNominaTableAdapter;
        private System.Windows.Forms.Label lblNumRegistrosSA;
        private System.Windows.Forms.Label lblNumRegistrosSC;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblVisualizacionRecibosSC;
        private System.Windows.Forms.DataGridView gvVisualizacionRecibosSC;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoNominaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicioDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFinDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn noEmpleadoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEmpleadoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nSSDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rFCDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cURPDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn noReciboDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sueldoBrutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAlimentosBrutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAlimentosNetoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoPagoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn noCuentaBancoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descBancoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionesDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label lblVisualizacionRecibosSA;
        private System.Windows.Forms.DataGridView gvVisualizacionRecibosSA;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoNominaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noEmpleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEmpleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nSSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rFCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cURPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaIngresoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noReciboDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diasPagarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoTotalPercepcionesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoTotalDeduccionesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoNetoPagarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoPagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noCuentaBancoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descBancoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diasJornadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionesDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblVisualizacionMovsAhorro;
        private System.Windows.Forms.DataGridView gvVisualizacionMovsAhorro;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoNominaDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicioDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFinDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn noEmpleadoDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEmpleadoDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nSSDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn rFCDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cURPDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn acumuladoAguinaldoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn acumuladoPrimaVacacionalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionesDataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource stpSelEliminarMovsHeaderAhorroBindingSource;
        private dbSAICBPODataSetTableAdapters.stpSelEliminarMovsHeaderAhorroTableAdapter stpSelEliminarMovsHeaderAhorroTableAdapter;
        private System.Windows.Forms.Label lblNumMovsAhorro;
        private System.Windows.Forms.RadioButton rbTenedoraSC;
        private System.Windows.Forms.RadioButton rbTenedoraSA;
        private DevExpress.XtraEditors.SimpleButton btnVisualizarMovs;
        private System.Windows.Forms.DataGridView gvLotesCargaNomina;
        private DevExpress.XtraEditors.SimpleButton btnMostrarLotes;
        private System.Windows.Forms.Label lblLotesCargaNomina;
        private System.Windows.Forms.BindingSource stpSelLoteCargaNominaBindingSource;
        private dbSAICBPODataSetTableAdapters.stpSelLoteCargaNominaTableAdapter stpSelLoteCargaNominaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLoteCargaNominaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn folioLoteCargaNominaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMonedaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoCambioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn nominaAutorizadaDataGridViewCheckBoxColumn;
        private DevExpress.XtraEditors.SimpleButton btnEliminarMovs;
    }
}