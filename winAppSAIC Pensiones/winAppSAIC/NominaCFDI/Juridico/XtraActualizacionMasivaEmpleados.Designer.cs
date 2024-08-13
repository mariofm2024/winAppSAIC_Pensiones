namespace winAppSAIC.Juridico
{
    partial class XtraActualizacionMasivaEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraActualizacionMasivaEmpleados));
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btnDescargar = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDescargarErrores = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAbrirCarpeta = new System.Windows.Forms.ToolStripButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.label1 = new System.Windows.Forms.Label();
            this.btnValidarInformacion = new DevExpress.XtraEditors.SimpleButton();
            this.txtRutaArchivo = new DevExpress.XtraEditors.TextEdit();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnActualizar = new DevExpress.XtraEditors.SimpleButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gCtrlEmpleadosFiltrados = new DevExpress.XtraGrid.GridControl();
            this.stpSelObtenerEmpleadoActualizacionMasivaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPOActualizacionesIMSSDataSet1 = new winAppSAIC.IMSS.dbSAICBPOActualizacionesIMSSDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreEmpleadoCompleto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNSS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRFC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCURP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaIngresoCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaIngresoContrato = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPuestoCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPuestoContrato = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartamentoCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartamentoContrato = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFuncionesEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCorreoElectronico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCentroDeCosto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnNoExterior = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnNoInterior = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnColonia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCodigoPostal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnNombreDelegacionMunicipio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnTipoContrato = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnFechaInicioContratoCit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnTiempoContratoCIT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnAPaternoEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnAMaternoEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnNombreEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSeleccionados = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtEmpleadosConError = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtNumEmpleados = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdioSalarioDiarioCliente = new System.Windows.Forms.RadioButton();
            this.rdioNombreEmpleado = new System.Windows.Forms.RadioButton();
            this.rdioTipoContrato = new System.Windows.Forms.RadioButton();
            this.rdioCliente = new System.Windows.Forms.RadioButton();
            this.rdioTenedora = new System.Windows.Forms.RadioButton();
            this.rdioCorreo = new System.Windows.Forms.RadioButton();
            this.cboIdCliente = new DevExpress.XtraEditors.LookUpEdit();
            this.stpSelClientesConfidencialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPOCatalogosDataSet1 = new winAppSAIC.dbSAICBPOCatalogosDataSet();
            this.rdioFechaIngreso = new System.Windows.Forms.RadioButton();
            this.cboIdTenedora = new DevExpress.XtraEditors.LookUpEdit();
            this.vwCatTenedoraSABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPODataSet1 = new winAppSAIC.dbSAICBPODataSet();
            this.rdioPuesto = new System.Windows.Forms.RadioButton();
            this.rdioDepartamento = new System.Windows.Forms.RadioButton();
            this.rdioFunciones = new System.Windows.Forms.RadioButton();
            this.rdioCentroDeCosto = new System.Windows.Forms.RadioButton();
            this.gBoxDirecciones = new System.Windows.Forms.GroupBox();
            this.rbFiscal = new System.Windows.Forms.RadioButton();
            this.rbParticular = new System.Windows.Forms.RadioButton();
            this.rbCentroDeTrabajo = new System.Windows.Forms.RadioButton();
            this.btnDescargarLayout = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSelectAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnDesSelectAll = new DevExpress.XtraEditors.SimpleButton();
            this.lblEmpleadosConError = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblTotaldeEmpleados = new DevExpress.XtraEditors.LabelControl();
            this.lblRegistrosSeleccionados = new DevExpress.XtraEditors.LabelControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.groupControlEmpleados = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1EmpleadosExcel = new DevExpress.XtraGrid.GridControl();
            this.gridView2Empleados = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.stpSelObtenerEmpleado_ActualizacionMasivaTableAdapter1 = new winAppSAIC.IMSS.dbSAICBPOActualizacionesIMSSDataSetTableAdapters.stpSelObtenerEmpleado_ActualizacionMasivaTableAdapter();
            this.ObtenerArchivo = new System.Windows.Forms.OpenFileDialog();
            this.stpSelValidacionActualizacionEmpleadosMasivaTableAdapter1 = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelValidacionActualizacionEmpleadosMasivaTableAdapter();
            this.stpSelParametroRegExTableAdapter1 = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelParametroRegExTableAdapter();
            this.queriesTableAdapter1 = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.QueriesTableAdapter();
            this.stpSelClientesConfidencialTableAdapter = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelClientesConfidencialTableAdapter();
            this.stpSelClientesConfidencialTableAdapter1 = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelClientesConfidencialTableAdapter();
            this.vwCatTenedoraSATableAdapter1 = new winAppSAIC.dbSAICBPODataSetTableAdapters.vwCatTenedoraSATableAdapter();
            this.dbSAICBPOFactura1 = new winAppSAIC.Facturas.dbSAICBPOFactura();
            this.stpFactSelDerechosAccesoOperadorFacturacionTableAdapter1 = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelDerechosAccesoOperadorFacturacionTableAdapter();
            this.splashScreenManager3 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::winAppSAIC.SplashDeCarga), true, true);
            this.gridColumnSalarioDiarioCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRutaArchivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gCtrlEmpleadosFiltrados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelObtenerEmpleadoActualizacionMasivaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOActualizacionesIMSSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeleccionados.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmpleadosConError.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumEmpleados.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboIdCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelClientesConfidencialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboIdTenedora.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCatTenedoraSABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPODataSet1)).BeginInit();
            this.gBoxDirecciones.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlEmpleados)).BeginInit();
            this.groupControlEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1EmpleadosExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2Empleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOFactura1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Black;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(53, 24);
            this.toolStripButton1.Text = "Salir";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnDescargar
            // 
            this.btnDescargar.Image = global::winAppSAIC.Properties.Resources.Excel;
            this.btnDescargar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.Size = new System.Drawing.Size(122, 24);
            this.btnDescargar.Text = "Descargar Layout";
            this.btnDescargar.Click += new System.EventHandler(this.btnDescargar_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.btnDescargar,
            this.toolStripSeparator1,
            this.btnDescargarErrores,
            this.toolStripSeparator2,
            this.btnAbrirCarpeta});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(982, 27);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // btnDescargarErrores
            // 
            this.btnDescargarErrores.Image = global::winAppSAIC.Properties.Resources.if_excel_836883;
            this.btnDescargarErrores.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDescargarErrores.Name = "btnDescargarErrores";
            this.btnDescargarErrores.Size = new System.Drawing.Size(122, 24);
            this.btnDescargarErrores.Text = "Descargar Errores";
            this.btnDescargarErrores.Click += new System.EventHandler(this.btnDescargarErrores_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // btnAbrirCarpeta
            // 
            this.btnAbrirCarpeta.Image = global::winAppSAIC.Properties.Resources.if_folder_416376;
            this.btnAbrirCarpeta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAbrirCarpeta.Name = "btnAbrirCarpeta";
            this.btnAbrirCarpeta.Size = new System.Drawing.Size(101, 24);
            this.btnAbrirCarpeta.Text = "Abrir Carpeta";
            this.btnAbrirCarpeta.Click += new System.EventHandler(this.btnAbrirCarpeta_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.label1);
            this.groupControl2.Controls.Add(this.btnValidarInformacion);
            this.groupControl2.Controls.Add(this.txtRutaArchivo);
            this.groupControl2.Location = new System.Drawing.Point(19, 162);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(614, 63);
            this.groupControl2.TabIndex = 20;
            this.groupControl2.Text = "Archivo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ruta:";
            // 
            // btnValidarInformacion
            // 
            this.btnValidarInformacion.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnValidarInformacion.ImageOptions.Image")));
            this.btnValidarInformacion.Location = new System.Drawing.Point(454, 30);
            this.btnValidarInformacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnValidarInformacion.Name = "btnValidarInformacion";
            this.btnValidarInformacion.Size = new System.Drawing.Size(147, 19);
            this.btnValidarInformacion.TabIndex = 2;
            this.btnValidarInformacion.Text = "Archivo";
            this.btnValidarInformacion.ToolTip = "Seleccionar y Validar Archivo Layout";
            this.btnValidarInformacion.Click += new System.EventHandler(this.btnValidarInformacion_Click);
            // 
            // txtRutaArchivo
            // 
            this.txtRutaArchivo.Location = new System.Drawing.Point(45, 31);
            this.txtRutaArchivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRutaArchivo.Name = "txtRutaArchivo";
            this.txtRutaArchivo.Size = new System.Drawing.Size(404, 20);
            this.txtRutaArchivo.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.ImageOptions.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(18, 29);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(151, 19);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.ImageOptions.Image")));
            this.btnActualizar.Location = new System.Drawing.Point(174, 29);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(151, 19);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gCtrlEmpleadosFiltrados);
            this.splitContainer1.Panel1.Controls.Add(this.groupControl1);
            this.splitContainer1.Panel1.Controls.Add(this.btnDescargarLayout);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl1);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.groupControl2);
            this.splitContainer1.Panel1.Controls.Add(this.groupControl4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupControlEmpleados);
            this.splitContainer1.Size = new System.Drawing.Size(982, 498);
            this.splitContainer1.SplitterDistance = 267;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 22;
            // 
            // gCtrlEmpleadosFiltrados
            // 
            this.gCtrlEmpleadosFiltrados.DataSource = this.stpSelObtenerEmpleadoActualizacionMasivaBindingSource;
            this.gCtrlEmpleadosFiltrados.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gCtrlEmpleadosFiltrados.Location = new System.Drawing.Point(1093, 42);
            this.gCtrlEmpleadosFiltrados.MainView = this.gridView1;
            this.gCtrlEmpleadosFiltrados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gCtrlEmpleadosFiltrados.Name = "gCtrlEmpleadosFiltrados";
            this.gCtrlEmpleadosFiltrados.Size = new System.Drawing.Size(317, 130);
            this.gCtrlEmpleadosFiltrados.TabIndex = 24;
            this.gCtrlEmpleadosFiltrados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gCtrlEmpleadosFiltrados.Visible = false;
            // 
            // stpSelObtenerEmpleadoActualizacionMasivaBindingSource
            // 
            this.stpSelObtenerEmpleadoActualizacionMasivaBindingSource.DataMember = "stpSelObtenerEmpleado_ActualizacionMasiva";
            this.stpSelObtenerEmpleadoActualizacionMasivaBindingSource.DataSource = this.dbSAICBPOActualizacionesIMSSDataSet1;
            // 
            // dbSAICBPOActualizacionesIMSSDataSet1
            // 
            this.dbSAICBPOActualizacionesIMSSDataSet1.DataSetName = "dbSAICBPOActualizacionesIMSSDataSet";
            this.dbSAICBPOActualizacionesIMSSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpleado,
            this.colNombreEmpleadoCompleto,
            this.colNSS,
            this.colRFC,
            this.colCURP,
            this.colFechaIngresoCliente,
            this.colFechaIngresoContrato,
            this.colPuestoCliente,
            this.colPuestoContrato,
            this.colDepartamentoCliente,
            this.colDepartamentoContrato,
            this.colFuncionesEmpleado,
            this.colCorreoElectronico,
            this.gridColumnCentroDeCosto,
            this.gridColumnCalle,
            this.gridColumnNoExterior,
            this.gridColumnNoInterior,
            this.gridColumnColonia,
            this.gridColumnCodigoPostal,
            this.gridColumnNombreDelegacionMunicipio,
            this.gridColumnEstado,
            this.gridColumnTipoContrato,
            this.gridColumnFechaInicioContratoCit,
            this.gridColumnTiempoContratoCIT,
            this.gridColumnAPaternoEmpleado,
            this.gridColumnAMaternoEmpleado,
            this.gridColumnNombreEmpleado,
            this.gridColumnSalarioDiarioCliente});
            this.gridView1.GridControl = this.gCtrlEmpleadosFiltrados;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIdEmpleado
            // 
            this.colIdEmpleado.FieldName = "IdEmpleado";
            this.colIdEmpleado.Name = "colIdEmpleado";
            this.colIdEmpleado.Visible = true;
            this.colIdEmpleado.VisibleIndex = 0;
            this.colIdEmpleado.Width = 79;
            // 
            // colNombreEmpleadoCompleto
            // 
            this.colNombreEmpleadoCompleto.FieldName = "NombreEmpleadoCompleto";
            this.colNombreEmpleadoCompleto.Name = "colNombreEmpleadoCompleto";
            this.colNombreEmpleadoCompleto.Visible = true;
            this.colNombreEmpleadoCompleto.VisibleIndex = 1;
            this.colNombreEmpleadoCompleto.Width = 222;
            // 
            // colNSS
            // 
            this.colNSS.FieldName = "NSS";
            this.colNSS.Name = "colNSS";
            this.colNSS.Visible = true;
            this.colNSS.VisibleIndex = 2;
            this.colNSS.Width = 114;
            // 
            // colRFC
            // 
            this.colRFC.FieldName = "RFC";
            this.colRFC.Name = "colRFC";
            this.colRFC.Visible = true;
            this.colRFC.VisibleIndex = 3;
            this.colRFC.Width = 119;
            // 
            // colCURP
            // 
            this.colCURP.FieldName = "CURP";
            this.colCURP.Name = "colCURP";
            this.colCURP.Visible = true;
            this.colCURP.VisibleIndex = 4;
            this.colCURP.Width = 143;
            // 
            // colFechaIngresoCliente
            // 
            this.colFechaIngresoCliente.FieldName = "FechaIngresoCliente";
            this.colFechaIngresoCliente.Name = "colFechaIngresoCliente";
            this.colFechaIngresoCliente.Visible = true;
            this.colFechaIngresoCliente.VisibleIndex = 5;
            this.colFechaIngresoCliente.Width = 125;
            // 
            // colFechaIngresoContrato
            // 
            this.colFechaIngresoContrato.FieldName = "FechaIngresoContrato";
            this.colFechaIngresoContrato.Name = "colFechaIngresoContrato";
            this.colFechaIngresoContrato.Visible = true;
            this.colFechaIngresoContrato.VisibleIndex = 6;
            this.colFechaIngresoContrato.Width = 159;
            // 
            // colPuestoCliente
            // 
            this.colPuestoCliente.FieldName = "PuestoCliente";
            this.colPuestoCliente.Name = "colPuestoCliente";
            this.colPuestoCliente.Visible = true;
            this.colPuestoCliente.VisibleIndex = 7;
            this.colPuestoCliente.Width = 89;
            // 
            // colPuestoContrato
            // 
            this.colPuestoContrato.FieldName = "PuestoContrato";
            this.colPuestoContrato.Name = "colPuestoContrato";
            this.colPuestoContrato.Visible = true;
            this.colPuestoContrato.VisibleIndex = 8;
            this.colPuestoContrato.Width = 99;
            // 
            // colDepartamentoCliente
            // 
            this.colDepartamentoCliente.FieldName = "DepartamentoCliente";
            this.colDepartamentoCliente.Name = "colDepartamentoCliente";
            this.colDepartamentoCliente.Visible = true;
            this.colDepartamentoCliente.VisibleIndex = 9;
            this.colDepartamentoCliente.Width = 125;
            // 
            // colDepartamentoContrato
            // 
            this.colDepartamentoContrato.FieldName = "DepartamentoContrato";
            this.colDepartamentoContrato.Name = "colDepartamentoContrato";
            this.colDepartamentoContrato.Visible = true;
            this.colDepartamentoContrato.VisibleIndex = 10;
            this.colDepartamentoContrato.Width = 135;
            // 
            // colFuncionesEmpleado
            // 
            this.colFuncionesEmpleado.FieldName = "FuncionesEmpleado";
            this.colFuncionesEmpleado.Name = "colFuncionesEmpleado";
            this.colFuncionesEmpleado.Visible = true;
            this.colFuncionesEmpleado.VisibleIndex = 11;
            this.colFuncionesEmpleado.Width = 117;
            // 
            // colCorreoElectronico
            // 
            this.colCorreoElectronico.FieldName = "CorreoElectronico";
            this.colCorreoElectronico.Name = "colCorreoElectronico";
            this.colCorreoElectronico.Visible = true;
            this.colCorreoElectronico.VisibleIndex = 12;
            this.colCorreoElectronico.Width = 108;
            // 
            // gridColumnCentroDeCosto
            // 
            this.gridColumnCentroDeCosto.Caption = "Centro De Costo";
            this.gridColumnCentroDeCosto.FieldName = "CentroDeCosto";
            this.gridColumnCentroDeCosto.Name = "gridColumnCentroDeCosto";
            this.gridColumnCentroDeCosto.Visible = true;
            this.gridColumnCentroDeCosto.VisibleIndex = 13;
            this.gridColumnCentroDeCosto.Width = 100;
            // 
            // gridColumnCalle
            // 
            this.gridColumnCalle.Caption = "Calle";
            this.gridColumnCalle.FieldName = "Calle";
            this.gridColumnCalle.Name = "gridColumnCalle";
            this.gridColumnCalle.Visible = true;
            this.gridColumnCalle.VisibleIndex = 14;
            this.gridColumnCalle.Width = 76;
            // 
            // gridColumnNoExterior
            // 
            this.gridColumnNoExterior.Caption = "NoExterior";
            this.gridColumnNoExterior.FieldName = "NoExterior";
            this.gridColumnNoExterior.Name = "gridColumnNoExterior";
            this.gridColumnNoExterior.Visible = true;
            this.gridColumnNoExterior.VisibleIndex = 15;
            this.gridColumnNoExterior.Width = 76;
            // 
            // gridColumnNoInterior
            // 
            this.gridColumnNoInterior.Caption = "NoInterior";
            this.gridColumnNoInterior.FieldName = "NoInterior";
            this.gridColumnNoInterior.Name = "gridColumnNoInterior";
            this.gridColumnNoInterior.Visible = true;
            this.gridColumnNoInterior.VisibleIndex = 16;
            this.gridColumnNoInterior.Width = 76;
            // 
            // gridColumnColonia
            // 
            this.gridColumnColonia.Caption = "Colonia";
            this.gridColumnColonia.FieldName = "Colonia";
            this.gridColumnColonia.Name = "gridColumnColonia";
            this.gridColumnColonia.Visible = true;
            this.gridColumnColonia.VisibleIndex = 17;
            this.gridColumnColonia.Width = 76;
            // 
            // gridColumnCodigoPostal
            // 
            this.gridColumnCodigoPostal.Caption = "CodigoPostal";
            this.gridColumnCodigoPostal.FieldName = "CodigoPostal";
            this.gridColumnCodigoPostal.Name = "gridColumnCodigoPostal";
            this.gridColumnCodigoPostal.Visible = true;
            this.gridColumnCodigoPostal.VisibleIndex = 18;
            this.gridColumnCodigoPostal.Width = 82;
            // 
            // gridColumnNombreDelegacionMunicipio
            // 
            this.gridColumnNombreDelegacionMunicipio.Caption = "NombreDelegacionMunicipio";
            this.gridColumnNombreDelegacionMunicipio.FieldName = "NombreDelegacionMunicipio";
            this.gridColumnNombreDelegacionMunicipio.Name = "gridColumnNombreDelegacionMunicipio";
            this.gridColumnNombreDelegacionMunicipio.Visible = true;
            this.gridColumnNombreDelegacionMunicipio.VisibleIndex = 19;
            this.gridColumnNombreDelegacionMunicipio.Width = 152;
            // 
            // gridColumnEstado
            // 
            this.gridColumnEstado.Caption = "Estado";
            this.gridColumnEstado.FieldName = "Estado";
            this.gridColumnEstado.Name = "gridColumnEstado";
            this.gridColumnEstado.Visible = true;
            this.gridColumnEstado.VisibleIndex = 20;
            this.gridColumnEstado.Width = 76;
            // 
            // gridColumnTipoContrato
            // 
            this.gridColumnTipoContrato.Caption = "Tipo Contrato";
            this.gridColumnTipoContrato.FieldName = "Tipo Contrato";
            this.gridColumnTipoContrato.Name = "gridColumnTipoContrato";
            this.gridColumnTipoContrato.Visible = true;
            this.gridColumnTipoContrato.VisibleIndex = 21;
            this.gridColumnTipoContrato.Width = 86;
            // 
            // gridColumnFechaInicioContratoCit
            // 
            this.gridColumnFechaInicioContratoCit.Caption = "Fecha Inicio Contrato Cit";
            this.gridColumnFechaInicioContratoCit.FieldName = "Fecha Inicio Contrato Cit";
            this.gridColumnFechaInicioContratoCit.Name = "gridColumnFechaInicioContratoCit";
            this.gridColumnFechaInicioContratoCit.Visible = true;
            this.gridColumnFechaInicioContratoCit.VisibleIndex = 22;
            this.gridColumnFechaInicioContratoCit.Width = 221;
            // 
            // gridColumnTiempoContratoCIT
            // 
            this.gridColumnTiempoContratoCIT.Caption = "Tiempo Contrato CIT";
            this.gridColumnTiempoContratoCIT.FieldName = "Tiempo Contrato CIT";
            this.gridColumnTiempoContratoCIT.Name = "gridColumnTiempoContratoCIT";
            this.gridColumnTiempoContratoCIT.Visible = true;
            this.gridColumnTiempoContratoCIT.VisibleIndex = 23;
            this.gridColumnTiempoContratoCIT.Width = 198;
            // 
            // gridColumnAPaternoEmpleado
            // 
            this.gridColumnAPaternoEmpleado.Caption = "APaternoEmpleado";
            this.gridColumnAPaternoEmpleado.FieldName = "APaternoEmpleado";
            this.gridColumnAPaternoEmpleado.Name = "gridColumnAPaternoEmpleado";
            this.gridColumnAPaternoEmpleado.Visible = true;
            this.gridColumnAPaternoEmpleado.VisibleIndex = 24;
            this.gridColumnAPaternoEmpleado.Width = 174;
            // 
            // gridColumnAMaternoEmpleado
            // 
            this.gridColumnAMaternoEmpleado.Caption = "AMaternoEmpleado";
            this.gridColumnAMaternoEmpleado.FieldName = "AMaternoEmpleado";
            this.gridColumnAMaternoEmpleado.Name = "gridColumnAMaternoEmpleado";
            this.gridColumnAMaternoEmpleado.Visible = true;
            this.gridColumnAMaternoEmpleado.VisibleIndex = 25;
            this.gridColumnAMaternoEmpleado.Width = 164;
            // 
            // gridColumnNombreEmpleado
            // 
            this.gridColumnNombreEmpleado.Caption = "NombreEmpleado";
            this.gridColumnNombreEmpleado.FieldName = "NombreEmpleado";
            this.gridColumnNombreEmpleado.Name = "gridColumnNombreEmpleado";
            this.gridColumnNombreEmpleado.Visible = true;
            this.gridColumnNombreEmpleado.VisibleIndex = 26;
            this.gridColumnNombreEmpleado.Width = 186;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.groupBox2);
            this.groupControl1.Controls.Add(this.groupBox1);
            this.groupControl1.Controls.Add(this.gBoxDirecciones);
            this.groupControl1.Location = new System.Drawing.Point(19, 13);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(956, 144);
            this.groupControl1.TabIndex = 23;
            this.groupControl1.Text = "Actualizar";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSeleccionados);
            this.groupBox2.Controls.Add(this.labelControl5);
            this.groupBox2.Controls.Add(this.txtEmpleadosConError);
            this.groupBox2.Controls.Add(this.labelControl4);
            this.groupBox2.Controls.Add(this.txtNumEmpleados);
            this.groupBox2.Controls.Add(this.labelControl2);
            this.groupBox2.Location = new System.Drawing.Point(808, 38);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(143, 101);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resumen";
            // 
            // txtSeleccionados
            // 
            this.txtSeleccionados.EditValue = "0000";
            this.txtSeleccionados.Location = new System.Drawing.Point(85, 70);
            this.txtSeleccionados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSeleccionados.Name = "txtSeleccionados";
            this.txtSeleccionados.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.txtSeleccionados.Properties.Appearance.Options.UseFont = true;
            this.txtSeleccionados.Properties.Appearance.Options.UseTextOptions = true;
            this.txtSeleccionados.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtSeleccionados.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtSeleccionados.Size = new System.Drawing.Size(53, 18);
            this.txtSeleccionados.TabIndex = 29;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(9, 73);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(70, 13);
            this.labelControl5.TabIndex = 30;
            this.labelControl5.Text = "Por Actualizar:";
            // 
            // txtEmpleadosConError
            // 
            this.txtEmpleadosConError.EditValue = "0000";
            this.txtEmpleadosConError.Location = new System.Drawing.Point(85, 49);
            this.txtEmpleadosConError.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmpleadosConError.Name = "txtEmpleadosConError";
            this.txtEmpleadosConError.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.txtEmpleadosConError.Properties.Appearance.Options.UseFont = true;
            this.txtEmpleadosConError.Properties.Appearance.Options.UseTextOptions = true;
            this.txtEmpleadosConError.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtEmpleadosConError.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtEmpleadosConError.Size = new System.Drawing.Size(54, 18);
            this.txtEmpleadosConError.TabIndex = 26;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(31, 51);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(50, 13);
            this.labelControl4.TabIndex = 28;
            this.labelControl4.Text = "Con Error:";
            // 
            // txtNumEmpleados
            // 
            this.txtNumEmpleados.EditValue = "0000";
            this.txtNumEmpleados.Location = new System.Drawing.Point(84, 28);
            this.txtNumEmpleados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumEmpleados.Name = "txtNumEmpleados";
            this.txtNumEmpleados.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.txtNumEmpleados.Properties.Appearance.Options.UseFont = true;
            this.txtNumEmpleados.Properties.Appearance.Options.UseTextOptions = true;
            this.txtNumEmpleados.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtNumEmpleados.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtNumEmpleados.Size = new System.Drawing.Size(55, 18);
            this.txtNumEmpleados.TabIndex = 25;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(25, 31);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(55, 13);
            this.labelControl2.TabIndex = 27;
            this.labelControl2.Text = "Empleados:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdioSalarioDiarioCliente);
            this.groupBox1.Controls.Add(this.rdioNombreEmpleado);
            this.groupBox1.Controls.Add(this.rdioTipoContrato);
            this.groupBox1.Controls.Add(this.rdioCliente);
            this.groupBox1.Controls.Add(this.rdioTenedora);
            this.groupBox1.Controls.Add(this.rdioCorreo);
            this.groupBox1.Controls.Add(this.cboIdCliente);
            this.groupBox1.Controls.Add(this.rdioFechaIngreso);
            this.groupBox1.Controls.Add(this.cboIdTenedora);
            this.groupBox1.Controls.Add(this.rdioPuesto);
            this.groupBox1.Controls.Add(this.rdioDepartamento);
            this.groupBox1.Controls.Add(this.rdioFunciones);
            this.groupBox1.Controls.Add(this.rdioCentroDeCosto);
            this.groupBox1.Location = new System.Drawing.Point(8, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(643, 110);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos | Cliente | Tenedora";
            // 
            // rdioSalarioDiarioCliente
            // 
            this.rdioSalarioDiarioCliente.AutoSize = true;
            this.rdioSalarioDiarioCliente.Location = new System.Drawing.Point(259, 66);
            this.rdioSalarioDiarioCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdioSalarioDiarioCliente.Name = "rdioSalarioDiarioCliente";
            this.rdioSalarioDiarioCliente.Size = new System.Drawing.Size(123, 17);
            this.rdioSalarioDiarioCliente.TabIndex = 26;
            this.rdioSalarioDiarioCliente.Text = "Salario Diario Cliente";
            this.rdioSalarioDiarioCliente.UseVisualStyleBackColor = true;
            this.rdioSalarioDiarioCliente.CheckedChanged += new System.EventHandler(this.rdioSalarioDiarioCliente_CheckedChanged);
            // 
            // rdioNombreEmpleado
            // 
            this.rdioNombreEmpleado.AutoSize = true;
            this.rdioNombreEmpleado.Location = new System.Drawing.Point(132, 85);
            this.rdioNombreEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdioNombreEmpleado.Name = "rdioNombreEmpleado";
            this.rdioNombreEmpleado.Size = new System.Drawing.Size(111, 17);
            this.rdioNombreEmpleado.TabIndex = 25;
            this.rdioNombreEmpleado.Text = "Nombre Empleado";
            this.rdioNombreEmpleado.UseVisualStyleBackColor = true;
            this.rdioNombreEmpleado.CheckedChanged += new System.EventHandler(this.rdioNombreEmpleado_CheckedChanged);
            // 
            // rdioTipoContrato
            // 
            this.rdioTipoContrato.AutoSize = true;
            this.rdioTipoContrato.Location = new System.Drawing.Point(132, 63);
            this.rdioTipoContrato.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdioTipoContrato.Name = "rdioTipoContrato";
            this.rdioTipoContrato.Size = new System.Drawing.Size(91, 17);
            this.rdioTipoContrato.TabIndex = 24;
            this.rdioTipoContrato.Text = "Tipo Contrato";
            this.rdioTipoContrato.UseVisualStyleBackColor = true;
            this.rdioTipoContrato.CheckedChanged += new System.EventHandler(this.rdioTipoContrato_CheckedChanged);
            // 
            // rdioCliente
            // 
            this.rdioCliente.AutoSize = true;
            this.rdioCliente.Location = new System.Drawing.Point(259, 18);
            this.rdioCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdioCliente.Name = "rdioCliente";
            this.rdioCliente.Size = new System.Drawing.Size(58, 17);
            this.rdioCliente.TabIndex = 5;
            this.rdioCliente.Text = "Cliente";
            this.rdioCliente.UseVisualStyleBackColor = true;
            this.rdioCliente.CheckedChanged += new System.EventHandler(this.rdioCliente_CheckedChanged);
            // 
            // rdioTenedora
            // 
            this.rdioTenedora.AutoSize = true;
            this.rdioTenedora.Location = new System.Drawing.Point(259, 41);
            this.rdioTenedora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdioTenedora.Name = "rdioTenedora";
            this.rdioTenedora.Size = new System.Drawing.Size(71, 17);
            this.rdioTenedora.TabIndex = 19;
            this.rdioTenedora.Text = "Tenedora";
            this.rdioTenedora.UseVisualStyleBackColor = true;
            this.rdioTenedora.CheckedChanged += new System.EventHandler(this.rdioTenedora_CheckedChanged);
            // 
            // rdioCorreo
            // 
            this.rdioCorreo.AutoSize = true;
            this.rdioCorreo.Checked = true;
            this.rdioCorreo.Location = new System.Drawing.Point(5, 18);
            this.rdioCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdioCorreo.Name = "rdioCorreo";
            this.rdioCorreo.Size = new System.Drawing.Size(113, 17);
            this.rdioCorreo.TabIndex = 4;
            this.rdioCorreo.TabStop = true;
            this.rdioCorreo.Tag = "Correo Electronicos";
            this.rdioCorreo.Text = "Correo Electronico";
            this.rdioCorreo.UseVisualStyleBackColor = true;
            this.rdioCorreo.CheckedChanged += new System.EventHandler(this.rdioCorreo_CheckedChanged);
            // 
            // cboIdCliente
            // 
            this.cboIdCliente.Enabled = false;
            this.cboIdCliente.Location = new System.Drawing.Point(340, 19);
            this.cboIdCliente.Name = "cboIdCliente";
            this.cboIdCliente.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.cboIdCliente.Properties.Appearance.Options.UseBackColor = true;
            this.cboIdCliente.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboIdCliente.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdCliente", "Id Cliente", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RazonSocial", "Razon Social", 83, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NombreComercial", "Nombre Comercial", 116, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cboIdCliente.Properties.DataSource = this.stpSelClientesConfidencialBindingSource;
            this.cboIdCliente.Properties.DisplayMember = "NombreComercial";
            this.cboIdCliente.Properties.NullText = "";
            this.cboIdCliente.Properties.ValueMember = "IdCliente";
            this.cboIdCliente.Size = new System.Drawing.Size(285, 20);
            this.cboIdCliente.TabIndex = 18;
            this.cboIdCliente.Tag = "Razón Social Cliente";
            // 
            // stpSelClientesConfidencialBindingSource
            // 
            this.stpSelClientesConfidencialBindingSource.DataMember = "stpSelClientesConfidencial";
            this.stpSelClientesConfidencialBindingSource.DataSource = this.dbSAICBPOCatalogosDataSet1;
            // 
            // dbSAICBPOCatalogosDataSet1
            // 
            this.dbSAICBPOCatalogosDataSet1.DataSetName = "dbSAICBPOCatalogosDataSet";
            this.dbSAICBPOCatalogosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rdioFechaIngreso
            // 
            this.rdioFechaIngreso.AutoSize = true;
            this.rdioFechaIngreso.Location = new System.Drawing.Point(132, 41);
            this.rdioFechaIngreso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdioFechaIngreso.Name = "rdioFechaIngreso";
            this.rdioFechaIngreso.Size = new System.Drawing.Size(94, 17);
            this.rdioFechaIngreso.TabIndex = 21;
            this.rdioFechaIngreso.Text = "Fecha Ingreso";
            this.rdioFechaIngreso.UseVisualStyleBackColor = true;
            this.rdioFechaIngreso.CheckedChanged += new System.EventHandler(this.rdioFechaIngreso_CheckedChanged);
            // 
            // cboIdTenedora
            // 
            this.cboIdTenedora.Enabled = false;
            this.cboIdTenedora.Location = new System.Drawing.Point(340, 41);
            this.cboIdTenedora.Name = "cboIdTenedora";
            this.cboIdTenedora.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.cboIdTenedora.Properties.Appearance.Options.UseBackColor = true;
            this.cboIdTenedora.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboIdTenedora.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdTenedora", "Id Tenedora", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RazonSocial", "Razon Social", 83, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NombreComercial", "Nombre Comercial", 116, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cboIdTenedora.Properties.DataSource = this.vwCatTenedoraSABindingSource;
            this.cboIdTenedora.Properties.DisplayMember = "NombreComercial";
            this.cboIdTenedora.Properties.NullText = "";
            this.cboIdTenedora.Properties.ValueMember = "IdTenedora";
            this.cboIdTenedora.Size = new System.Drawing.Size(285, 20);
            this.cboIdTenedora.TabIndex = 20;
            this.cboIdTenedora.Tag = "Razón Social Cliente";
            // 
            // vwCatTenedoraSABindingSource
            // 
            this.vwCatTenedoraSABindingSource.DataMember = "vwCatTenedoraSA";
            this.vwCatTenedoraSABindingSource.DataSource = this.dbSAICBPODataSet1;
            // 
            // dbSAICBPODataSet1
            // 
            this.dbSAICBPODataSet1.DataSetName = "dbSAICBPODataSet";
            this.dbSAICBPODataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rdioPuesto
            // 
            this.rdioPuesto.AutoSize = true;
            this.rdioPuesto.Location = new System.Drawing.Point(5, 41);
            this.rdioPuesto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdioPuesto.Name = "rdioPuesto";
            this.rdioPuesto.Size = new System.Drawing.Size(58, 17);
            this.rdioPuesto.TabIndex = 1;
            this.rdioPuesto.Tag = "Puesto";
            this.rdioPuesto.Text = "Puesto";
            this.rdioPuesto.UseVisualStyleBackColor = true;
            this.rdioPuesto.CheckedChanged += new System.EventHandler(this.rdioPuesto_CheckedChanged);
            // 
            // rdioDepartamento
            // 
            this.rdioDepartamento.AutoSize = true;
            this.rdioDepartamento.Location = new System.Drawing.Point(5, 85);
            this.rdioDepartamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdioDepartamento.Name = "rdioDepartamento";
            this.rdioDepartamento.Size = new System.Drawing.Size(94, 17);
            this.rdioDepartamento.TabIndex = 2;
            this.rdioDepartamento.Text = "Departamento";
            this.rdioDepartamento.UseVisualStyleBackColor = true;
            this.rdioDepartamento.CheckedChanged += new System.EventHandler(this.rdioDepartamento_CheckedChanged);
            // 
            // rdioFunciones
            // 
            this.rdioFunciones.AutoSize = true;
            this.rdioFunciones.Location = new System.Drawing.Point(5, 63);
            this.rdioFunciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdioFunciones.Name = "rdioFunciones";
            this.rdioFunciones.Size = new System.Drawing.Size(73, 17);
            this.rdioFunciones.TabIndex = 3;
            this.rdioFunciones.Text = "Funciones";
            this.rdioFunciones.UseVisualStyleBackColor = true;
            this.rdioFunciones.CheckedChanged += new System.EventHandler(this.rdioFunciones_CheckedChanged);
            // 
            // rdioCentroDeCosto
            // 
            this.rdioCentroDeCosto.AutoSize = true;
            this.rdioCentroDeCosto.Location = new System.Drawing.Point(132, 18);
            this.rdioCentroDeCosto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdioCentroDeCosto.Name = "rdioCentroDeCosto";
            this.rdioCentroDeCosto.Size = new System.Drawing.Size(104, 17);
            this.rdioCentroDeCosto.TabIndex = 23;
            this.rdioCentroDeCosto.Text = "Centro de Costo";
            this.rdioCentroDeCosto.UseVisualStyleBackColor = true;
            this.rdioCentroDeCosto.CheckedChanged += new System.EventHandler(this.rdioCentroDeCosto_CheckedChanged);
            // 
            // gBoxDirecciones
            // 
            this.gBoxDirecciones.Controls.Add(this.rbFiscal);
            this.gBoxDirecciones.Controls.Add(this.rbParticular);
            this.gBoxDirecciones.Controls.Add(this.rbCentroDeTrabajo);
            this.gBoxDirecciones.Location = new System.Drawing.Point(656, 38);
            this.gBoxDirecciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBoxDirecciones.Name = "gBoxDirecciones";
            this.gBoxDirecciones.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBoxDirecciones.Size = new System.Drawing.Size(143, 101);
            this.gBoxDirecciones.TabIndex = 25;
            this.gBoxDirecciones.TabStop = false;
            this.gBoxDirecciones.Text = "Domicilios";
            // 
            // rbFiscal
            // 
            this.rbFiscal.AutoSize = true;
            this.rbFiscal.Location = new System.Drawing.Point(11, 69);
            this.rbFiscal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbFiscal.Name = "rbFiscal";
            this.rbFiscal.Size = new System.Drawing.Size(51, 17);
            this.rbFiscal.TabIndex = 5;
            this.rbFiscal.TabStop = true;
            this.rbFiscal.Text = "Fiscal";
            this.rbFiscal.UseVisualStyleBackColor = true;
            this.rbFiscal.CheckedChanged += new System.EventHandler(this.rbFiscal_CheckedChanged);
            // 
            // rbParticular
            // 
            this.rbParticular.AutoSize = true;
            this.rbParticular.Location = new System.Drawing.Point(11, 50);
            this.rbParticular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbParticular.Name = "rbParticular";
            this.rbParticular.Size = new System.Drawing.Size(70, 17);
            this.rbParticular.TabIndex = 4;
            this.rbParticular.TabStop = true;
            this.rbParticular.Text = "Particular";
            this.rbParticular.UseVisualStyleBackColor = true;
            this.rbParticular.CheckedChanged += new System.EventHandler(this.rbParticular_CheckedChanged);
            // 
            // rbCentroDeTrabajo
            // 
            this.rbCentroDeTrabajo.AutoSize = true;
            this.rbCentroDeTrabajo.Location = new System.Drawing.Point(11, 28);
            this.rbCentroDeTrabajo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbCentroDeTrabajo.Name = "rbCentroDeTrabajo";
            this.rbCentroDeTrabajo.Size = new System.Drawing.Size(113, 17);
            this.rbCentroDeTrabajo.TabIndex = 3;
            this.rbCentroDeTrabajo.TabStop = true;
            this.rbCentroDeTrabajo.Text = "Centro de Trabajo";
            this.rbCentroDeTrabajo.UseVisualStyleBackColor = true;
            this.rbCentroDeTrabajo.CheckedChanged += new System.EventHandler(this.rbCentroDeTrabajo_CheckedChanged);
            // 
            // btnDescargarLayout
            // 
            this.btnDescargarLayout.ImageOptions.Image = global::winAppSAIC.Properties.Resources.Excel;
            this.btnDescargarLayout.Location = new System.Drawing.Point(1185, 219);
            this.btnDescargarLayout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDescargarLayout.Name = "btnDescargarLayout";
            this.btnDescargarLayout.Size = new System.Drawing.Size(153, 19);
            this.btnDescargarLayout.TabIndex = 21;
            this.btnDescargarLayout.Text = "Descargar";
            this.btnDescargarLayout.Visible = false;
            this.btnDescargarLayout.Click += new System.EventHandler(this.btnDescargarLayout_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(1093, 222);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(89, 13);
            this.labelControl1.TabIndex = 22;
            this.labelControl1.Text = "Descargar Layout:";
            this.labelControl1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(153)))), ((int)(((byte)(205)))));
            this.panel1.Controls.Add(this.btnSelectAll);
            this.panel1.Controls.Add(this.btnDesSelectAll);
            this.panel1.Controls.Add(this.lblEmpleadosConError);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.lblTotaldeEmpleados);
            this.panel1.Controls.Add(this.lblRegistrosSeleccionados);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 236);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 31);
            this.panel1.TabIndex = 22;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(8, 3);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(110, 23);
            this.btnSelectAll.TabIndex = 1;
            this.btnSelectAll.Text = "Seleccionar Todo";
            this.btnSelectAll.Visible = false;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnDesSelectAll
            // 
            this.btnDesSelectAll.Location = new System.Drawing.Point(126, 3);
            this.btnDesSelectAll.Name = "btnDesSelectAll";
            this.btnDesSelectAll.Size = new System.Drawing.Size(110, 23);
            this.btnDesSelectAll.TabIndex = 7;
            this.btnDesSelectAll.Text = "Deseleccionar Todo";
            this.btnDesSelectAll.Visible = false;
            this.btnDesSelectAll.Click += new System.EventHandler(this.btnDesSelectAll_Click);
            // 
            // lblEmpleadosConError
            // 
            this.lblEmpleadosConError.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblEmpleadosConError.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblEmpleadosConError.Appearance.Options.UseFont = true;
            this.lblEmpleadosConError.Appearance.Options.UseForeColor = true;
            this.lblEmpleadosConError.Location = new System.Drawing.Point(886, 11);
            this.lblEmpleadosConError.Name = "lblEmpleadosConError";
            this.lblEmpleadosConError.Size = new System.Drawing.Size(7, 13);
            this.lblEmpleadosConError.TabIndex = 14;
            this.lblEmpleadosConError.Text = "0";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(705, 10);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(167, 13);
            this.labelControl3.TabIndex = 13;
            this.labelControl3.Text = "Total de Empleados con Error:";
            this.labelControl3.Visible = false;
            // 
            // lblTotaldeEmpleados
            // 
            this.lblTotaldeEmpleados.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTotaldeEmpleados.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblTotaldeEmpleados.Appearance.Options.UseFont = true;
            this.lblTotaldeEmpleados.Appearance.Options.UseForeColor = true;
            this.lblTotaldeEmpleados.Location = new System.Drawing.Point(646, 10);
            this.lblTotaldeEmpleados.Name = "lblTotaldeEmpleados";
            this.lblTotaldeEmpleados.Size = new System.Drawing.Size(7, 13);
            this.lblTotaldeEmpleados.TabIndex = 11;
            this.lblTotaldeEmpleados.Text = "0";
            this.lblTotaldeEmpleados.Visible = false;
            // 
            // lblRegistrosSeleccionados
            // 
            this.lblRegistrosSeleccionados.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblRegistrosSeleccionados.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblRegistrosSeleccionados.Appearance.Options.UseFont = true;
            this.lblRegistrosSeleccionados.Appearance.Options.UseForeColor = true;
            this.lblRegistrosSeleccionados.Location = new System.Drawing.Point(521, 10);
            this.lblRegistrosSeleccionados.Name = "lblRegistrosSeleccionados";
            this.lblRegistrosSeleccionados.Size = new System.Drawing.Size(113, 13);
            this.lblRegistrosSeleccionados.TabIndex = 10;
            this.lblRegistrosSeleccionados.Text = "Total de Empleados:";
            this.lblRegistrosSeleccionados.Visible = false;
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.btnCancelar);
            this.groupControl4.Controls.Add(this.btnActualizar);
            this.groupControl4.Location = new System.Drawing.Point(638, 162);
            this.groupControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(336, 63);
            this.groupControl4.TabIndex = 21;
            this.groupControl4.Text = "Acciones";
            // 
            // groupControlEmpleados
            // 
            this.groupControlEmpleados.Controls.Add(this.gridControl1EmpleadosExcel);
            this.groupControlEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlEmpleados.Location = new System.Drawing.Point(0, 0);
            this.groupControlEmpleados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControlEmpleados.Name = "groupControlEmpleados";
            this.groupControlEmpleados.Size = new System.Drawing.Size(982, 228);
            this.groupControlEmpleados.TabIndex = 0;
            this.groupControlEmpleados.Text = "Empleados";
            // 
            // gridControl1EmpleadosExcel
            // 
            this.gridControl1EmpleadosExcel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1EmpleadosExcel.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1EmpleadosExcel.Location = new System.Drawing.Point(2, 20);
            this.gridControl1EmpleadosExcel.MainView = this.gridView2Empleados;
            this.gridControl1EmpleadosExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1EmpleadosExcel.Name = "gridControl1EmpleadosExcel";
            this.gridControl1EmpleadosExcel.Size = new System.Drawing.Size(978, 206);
            this.gridControl1EmpleadosExcel.TabIndex = 0;
            this.gridControl1EmpleadosExcel.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2Empleados});
            // 
            // gridView2Empleados
            // 
            this.gridView2Empleados.GridControl = this.gridControl1EmpleadosExcel;
            this.gridView2Empleados.Name = "gridView2Empleados";
            this.gridView2Empleados.OptionsBehavior.ReadOnly = true;
            this.gridView2Empleados.OptionsSelection.MultiSelect = true;
            this.gridView2Empleados.OptionsView.ColumnAutoWidth = false;
            this.gridView2Empleados.OptionsView.ShowGroupPanel = false;
            this.gridView2Empleados.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridView2_SelectionChanged);
            this.gridView2Empleados.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView2Empleados_RowUpdated);
            // 
            // stpSelObtenerEmpleado_ActualizacionMasivaTableAdapter1
            // 
            this.stpSelObtenerEmpleado_ActualizacionMasivaTableAdapter1.ClearBeforeFill = true;
            // 
            // ObtenerArchivo
            // 
            this.ObtenerArchivo.FileName = "openFileDialog1";
            // 
            // stpSelValidacionActualizacionEmpleadosMasivaTableAdapter1
            // 
            this.stpSelValidacionActualizacionEmpleadosMasivaTableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelParametroRegExTableAdapter1
            // 
            this.stpSelParametroRegExTableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelClientesConfidencialTableAdapter
            // 
            this.stpSelClientesConfidencialTableAdapter.ClearBeforeFill = true;
            // 
            // stpSelClientesConfidencialTableAdapter1
            // 
            this.stpSelClientesConfidencialTableAdapter1.ClearBeforeFill = true;
            // 
            // vwCatTenedoraSATableAdapter1
            // 
            this.vwCatTenedoraSATableAdapter1.ClearBeforeFill = true;
            // 
            // dbSAICBPOFactura1
            // 
            this.dbSAICBPOFactura1.DataSetName = "dbSAICBPOFactura";
            this.dbSAICBPOFactura1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stpFactSelDerechosAccesoOperadorFacturacionTableAdapter1
            // 
            this.stpFactSelDerechosAccesoOperadorFacturacionTableAdapter1.ClearBeforeFill = true;
            // 
            // splashScreenManager3
            // 
            this.splashScreenManager3.ClosingDelay = 500;
            // 
            // gridColumnSalarioDiarioCliente
            // 
            this.gridColumnSalarioDiarioCliente.Caption = "SalarioDiarioCliente";
            this.gridColumnSalarioDiarioCliente.DisplayFormat.FormatString = "N2";
            this.gridColumnSalarioDiarioCliente.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnSalarioDiarioCliente.FieldName = "SalarioDiarioCliente";
            this.gridColumnSalarioDiarioCliente.Name = "gridColumnSalarioDiarioCliente";
            this.gridColumnSalarioDiarioCliente.Visible = true;
            this.gridColumnSalarioDiarioCliente.VisibleIndex = 27;
            this.gridColumnSalarioDiarioCliente.Width = 112;
            // 
            // XtraActualizacionMasivaEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 525);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimizeBox = false;
            this.Name = "XtraActualizacionMasivaEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizacion Masiva de Empleados";
            this.Load += new System.EventHandler(this.XtraActualizacionMasivaEmpleados_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRutaArchivo.Properties)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gCtrlEmpleadosFiltrados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelObtenerEmpleadoActualizacionMasivaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOActualizacionesIMSSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeleccionados.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmpleadosConError.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumEmpleados.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboIdCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelClientesConfidencialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboIdTenedora.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCatTenedoraSABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPODataSet1)).EndInit();
            this.gBoxDirecciones.ResumeLayout(false);
            this.gBoxDirecciones.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlEmpleados)).EndInit();
            this.groupControlEmpleados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1EmpleadosExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2Empleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOFactura1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton btnDescargar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtRutaArchivo;
        private DevExpress.XtraEditors.SimpleButton btnValidarInformacion;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnActualizar;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnSelectAll;
        private DevExpress.XtraEditors.SimpleButton btnDesSelectAll;
        private DevExpress.XtraEditors.LabelControl lblEmpleadosConError;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lblTotaldeEmpleados;
        private DevExpress.XtraEditors.LabelControl lblRegistrosSeleccionados;
        private DevExpress.XtraEditors.GroupControl groupControlEmpleados;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.RadioButton rdioCliente;
        private System.Windows.Forms.RadioButton rdioCorreo;
        private System.Windows.Forms.RadioButton rdioFunciones;
        private System.Windows.Forms.RadioButton rdioDepartamento;
        private System.Windows.Forms.RadioButton rdioPuesto;
        private DevExpress.XtraEditors.SimpleButton btnDescargarLayout;
        private DevExpress.XtraEditors.LookUpEdit cboIdTenedora;
        private System.Windows.Forms.RadioButton rdioTenedora;
        private DevExpress.XtraEditors.LookUpEdit cboIdCliente;
        private IMSS.dbSAICBPOActualizacionesIMSSDataSet dbSAICBPOActualizacionesIMSSDataSet1;
        private IMSS.dbSAICBPOActualizacionesIMSSDataSetTableAdapters.stpSelObtenerEmpleado_ActualizacionMasivaTableAdapter stpSelObtenerEmpleado_ActualizacionMasivaTableAdapter1;
        private DevExpress.XtraGrid.GridControl gCtrlEmpleadosFiltrados;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource stpSelObtenerEmpleadoActualizacionMasivaBindingSource;
        private System.Windows.Forms.RadioButton rdioFechaIngreso;
        private System.Windows.Forms.OpenFileDialog ObtenerArchivo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreEmpleadoCompleto;
        private DevExpress.XtraGrid.Columns.GridColumn colNSS;
        private DevExpress.XtraGrid.Columns.GridColumn colRFC;
        private DevExpress.XtraGrid.Columns.GridColumn colCURP;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaIngresoCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaIngresoContrato;
        private DevExpress.XtraGrid.Columns.GridColumn colPuestoCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colPuestoContrato;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartamentoCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartamentoContrato;
        private DevExpress.XtraGrid.Columns.GridColumn colFuncionesEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn colCorreoElectronico;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelValidacionActualizacionEmpleadosMasivaTableAdapter stpSelValidacionActualizacionEmpleadosMasivaTableAdapter1;
        private dbSAICBPOCatalogosDataSet dbSAICBPOCatalogosDataSet1;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelParametroRegExTableAdapter stpSelParametroRegExTableAdapter1;
        private dbSAICBPOCatalogosDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private System.Windows.Forms.BindingSource stpSelClientesConfidencialBindingSource;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelClientesConfidencialTableAdapter stpSelClientesConfidencialTableAdapter;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelClientesConfidencialTableAdapter stpSelClientesConfidencialTableAdapter1;
        private dbSAICBPODataSet dbSAICBPODataSet1;
        private dbSAICBPODataSetTableAdapters.vwCatTenedoraSATableAdapter vwCatTenedoraSATableAdapter1;
        private System.Windows.Forms.BindingSource vwCatTenedoraSABindingSource;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager2;
        private Facturas.dbSAICBPOFactura dbSAICBPOFactura1;
        private Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelDerechosAccesoOperadorFacturacionTableAdapter stpFactSelDerechosAccesoOperadorFacturacionTableAdapter1;
        private System.Windows.Forms.RadioButton rdioCentroDeCosto;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCentroDeCosto;
        private System.Windows.Forms.GroupBox gBoxDirecciones;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCalle;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnNoExterior;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnNoInterior;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnColonia;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCodigoPostal;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnNombreDelegacionMunicipio;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnEstado;
        private System.Windows.Forms.RadioButton rbFiscal;
        private System.Windows.Forms.RadioButton rbParticular;
        private System.Windows.Forms.RadioButton rbCentroDeTrabajo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnAbrirCarpeta;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.TextEdit txtSeleccionados;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtEmpleadosConError;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtNumEmpleados;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.ToolStripButton btnDescargarErrores;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private DevExpress.XtraGrid.GridControl gridControl1EmpleadosExcel;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2Empleados;
        private System.Windows.Forms.RadioButton rdioTipoContrato;
        private System.Windows.Forms.RadioButton rdioNombreEmpleado;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTipoContrato;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnFechaInicioContratoCit;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTiempoContratoCIT;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnAPaternoEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnAMaternoEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnNombreEmpleado;
        private System.Windows.Forms.RadioButton rdioSalarioDiarioCliente;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSalarioDiarioCliente;
    }
}