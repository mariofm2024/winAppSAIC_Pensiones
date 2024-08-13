namespace winAppSAIC.IMSS
{
    partial class frmActualizarSBC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActualizarSBC));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btnDescargar = new System.Windows.Forms.ToolStripButton();
            this.txtLiga = new System.Windows.Forms.ToolStripTextBox();
            this.btnCargarArchivo = new System.Windows.Forms.ToolStripButton();
            this.btnCargarRecupe = new System.Windows.Forms.ToolStripButton();
            this.gvdInfonavit = new DevExpress.XtraGrid.GridControl();
            this.stpSelObtenerEmpleadoSDIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPOActualizacionesIMSSDataSet = new winAppSAIC.IMSS.dbSAICBPOActualizacionesIMSSDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreEmpleadoCompleto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNSS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRFC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCURP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalarioDiarioContrato = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalarioDiarioIntegradoContrato = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sfdRutaArchivo = new System.Windows.Forms.SaveFileDialog();
            this.ObtenerArchivo = new System.Windows.Forms.OpenFileDialog();
            this.stpSelObtenerEmpleadoSDITableAdapter = new winAppSAIC.IMSS.dbSAICBPOActualizacionesIMSSDataSetTableAdapters.stpSelObtenerEmpleadoSDITableAdapter();
            this.actualizacionesIMSSTableAdapter1 = new winAppSAIC.IMSS.dbSAICBPOActualizacionesIMSSDataSetTableAdapters.ActualizacionesIMSSTableAdapter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnActualizar = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.label2 = new System.Windows.Forms.Label();
            this.dtFechaCaculoSD = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRutaArchivo = new DevExpress.XtraEditors.TextEdit();
            this.btnValidarInformacion = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSelectAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnDesSelectAll = new DevExpress.XtraEditors.SimpleButton();
            this.lblEmpleadosConError = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblTotaldeEmpleados = new DevExpress.XtraEditors.LabelControl();
            this.lblRegistrosSeleccionados = new DevExpress.XtraEditors.LabelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.gCtrlEmpleados = new DevExpress.XtraGrid.GridControl();
            this.gridViewEmpleados = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dbSAICBPOCatalogosDataSet1 = new winAppSAIC.dbSAICBPOCatalogosDataSet();
            this.stpSelEstatusNominaContabilizadaTableAdapter1 = new winAppSAIC.dbSAICBPOValidacionDataSetTableAdapters.stpSelEstatusNominaContabilizadaTableAdapter();
            this.dbSAICBPOValidacionDataSet1 = new winAppSAIC.dbSAICBPOValidacionDataSet();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::winAppSAIC.SplashDeCarga), true, true);
            this.stpSelValidacionActualizacionEmpleadosMasiva_SD_SDITableAdapter1 = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelValidacionActualizacionEmpleadosMasiva_SD_SDITableAdapter();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvdInfonavit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelObtenerEmpleadoSDIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOActualizacionesIMSSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaCaculoSD.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaCaculoSD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRutaArchivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gCtrlEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOValidacionDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.btnDescargar,
            this.txtLiga,
            this.btnCargarArchivo,
            this.btnCargarRecupe});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1052, 27);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Black;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(62, 24);
            this.toolStripButton1.Text = "Salir";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnDescargar
            // 
            this.btnDescargar.Image = global::winAppSAIC.Properties.Resources.Excel;
            this.btnDescargar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.Size = new System.Drawing.Size(148, 24);
            this.btnDescargar.Text = "Descargar Layout";
            this.btnDescargar.Click += new System.EventHandler(this.btnDescargar_Click);
            // 
            // txtLiga
            // 
            this.txtLiga.Name = "txtLiga";
            this.txtLiga.ReadOnly = true;
            this.txtLiga.Size = new System.Drawing.Size(116, 27);
            this.txtLiga.Visible = false;
            // 
            // btnCargarArchivo
            // 
            this.btnCargarArchivo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCargarArchivo.Image = global::winAppSAIC.Properties.Resources.ImprimirPreview;
            this.btnCargarArchivo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCargarArchivo.Name = "btnCargarArchivo";
            this.btnCargarArchivo.Size = new System.Drawing.Size(24, 24);
            this.btnCargarArchivo.Text = "toolStripButton3";
            this.btnCargarArchivo.Visible = false;
            this.btnCargarArchivo.Click += new System.EventHandler(this.btnCargarArchivo_Click);
            // 
            // btnCargarRecupe
            // 
            this.btnCargarRecupe.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCargarRecupe.Name = "btnCargarRecupe";
            this.btnCargarRecupe.Size = new System.Drawing.Size(106, 24);
            this.btnCargarRecupe.Text = "Actualizar SDI";
            this.btnCargarRecupe.Visible = false;
            this.btnCargarRecupe.Click += new System.EventHandler(this.btnCargarRecupe_Click);
            // 
            // gvdInfonavit
            // 
            this.gvdInfonavit.DataSource = this.stpSelObtenerEmpleadoSDIBindingSource;
            this.gvdInfonavit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvdInfonavit.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gvdInfonavit.Location = new System.Drawing.Point(2, 25);
            this.gvdInfonavit.MainView = this.gridView1;
            this.gvdInfonavit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gvdInfonavit.Name = "gvdInfonavit";
            this.gvdInfonavit.Size = new System.Drawing.Size(549, 73);
            this.gvdInfonavit.TabIndex = 4;
            this.gvdInfonavit.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // stpSelObtenerEmpleadoSDIBindingSource
            // 
            this.stpSelObtenerEmpleadoSDIBindingSource.DataMember = "stpSelObtenerEmpleadoSDI";
            this.stpSelObtenerEmpleadoSDIBindingSource.DataSource = this.dbSAICBPOActualizacionesIMSSDataSet;
            // 
            // dbSAICBPOActualizacionesIMSSDataSet
            // 
            this.dbSAICBPOActualizacionesIMSSDataSet.DataSetName = "dbSAICBPOActualizacionesIMSSDataSet";
            this.dbSAICBPOActualizacionesIMSSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpleado,
            this.colNombreEmpleadoCompleto,
            this.colNSS,
            this.colRFC,
            this.colCURP,
            this.colSalarioDiarioContrato,
            this.colSalarioDiarioIntegradoContrato});
            this.gridView1.GridControl = this.gvdInfonavit;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colSalarioDiarioContrato, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // colIdEmpleado
            // 
            this.colIdEmpleado.FieldName = "IdEmpleado";
            this.colIdEmpleado.Name = "colIdEmpleado";
            this.colIdEmpleado.Visible = true;
            this.colIdEmpleado.VisibleIndex = 0;
            // 
            // colNombreEmpleadoCompleto
            // 
            this.colNombreEmpleadoCompleto.FieldName = "NombreEmpleadoCompleto";
            this.colNombreEmpleadoCompleto.Name = "colNombreEmpleadoCompleto";
            this.colNombreEmpleadoCompleto.Visible = true;
            this.colNombreEmpleadoCompleto.VisibleIndex = 1;
            this.colNombreEmpleadoCompleto.Width = 271;
            // 
            // colNSS
            // 
            this.colNSS.FieldName = "NSS";
            this.colNSS.Name = "colNSS";
            this.colNSS.Visible = true;
            this.colNSS.VisibleIndex = 2;
            this.colNSS.Width = 102;
            // 
            // colRFC
            // 
            this.colRFC.FieldName = "RFC";
            this.colRFC.Name = "colRFC";
            this.colRFC.Visible = true;
            this.colRFC.VisibleIndex = 3;
            this.colRFC.Width = 102;
            // 
            // colCURP
            // 
            this.colCURP.FieldName = "CURP";
            this.colCURP.Name = "colCURP";
            this.colCURP.Visible = true;
            this.colCURP.VisibleIndex = 4;
            this.colCURP.Width = 102;
            // 
            // colSalarioDiarioContrato
            // 
            this.colSalarioDiarioContrato.Caption = "S.D.";
            this.colSalarioDiarioContrato.DisplayFormat.FormatString = "c2";
            this.colSalarioDiarioContrato.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSalarioDiarioContrato.FieldName = "SalarioDiarioContrato";
            this.colSalarioDiarioContrato.Name = "colSalarioDiarioContrato";
            this.colSalarioDiarioContrato.Visible = true;
            this.colSalarioDiarioContrato.VisibleIndex = 5;
            this.colSalarioDiarioContrato.Width = 102;
            // 
            // colSalarioDiarioIntegradoContrato
            // 
            this.colSalarioDiarioIntegradoContrato.Caption = "S.D.I.";
            this.colSalarioDiarioIntegradoContrato.DisplayFormat.FormatString = "C2";
            this.colSalarioDiarioIntegradoContrato.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSalarioDiarioIntegradoContrato.FieldName = "SalarioDiarioIntegradoContrato";
            this.colSalarioDiarioIntegradoContrato.Name = "colSalarioDiarioIntegradoContrato";
            this.colSalarioDiarioIntegradoContrato.Visible = true;
            this.colSalarioDiarioIntegradoContrato.VisibleIndex = 6;
            this.colSalarioDiarioIntegradoContrato.Width = 115;
            // 
            // sfdRutaArchivo
            // 
            this.sfdRutaArchivo.Filter = "Archivos de Excel | *.xls";
            this.sfdRutaArchivo.Title = "Guardar como...";
            // 
            // ObtenerArchivo
            // 
            this.ObtenerArchivo.FileName = "openFileDialog1";
            // 
            // stpSelObtenerEmpleadoSDITableAdapter
            // 
            this.stpSelObtenerEmpleadoSDITableAdapter.ClearBeforeFill = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupControl4);
            this.splitContainer1.Panel1.Controls.Add(this.groupControl2);
            this.splitContainer1.Panel1.Controls.Add(this.groupControl1);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupControl3);
            this.splitContainer1.Size = new System.Drawing.Size(1052, 549);
            this.splitContainer1.SplitterDistance = 162;
            this.splitContainer1.TabIndex = 6;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.btnCancelar);
            this.groupControl4.Controls.Add(this.btnActualizar);
            this.groupControl4.Location = new System.Drawing.Point(832, 19);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(200, 94);
            this.groupControl4.TabIndex = 6;
            this.groupControl4.Text = "Acciones";
            // 
            // btnCancelar
            // 
            this.btnCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.ImageOptions.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(14, 28);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(176, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.ImageOptions.Image")));
            this.btnActualizar.Location = new System.Drawing.Point(14, 57);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(176, 23);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.label2);
            this.groupControl2.Controls.Add(this.dtFechaCaculoSD);
            this.groupControl2.Controls.Add(this.label1);
            this.groupControl2.Controls.Add(this.txtRutaArchivo);
            this.groupControl2.Controls.Add(this.btnValidarInformacion);
            this.groupControl2.Location = new System.Drawing.Point(16, 15);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(805, 98);
            this.groupControl2.TabIndex = 19;
            this.groupControl2.Text = "Archivo";
            this.groupControl2.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl2_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha de Calculo:";
            // 
            // dtFechaCaculoSD
            // 
            this.dtFechaCaculoSD.EditValue = null;
            this.dtFechaCaculoSD.Location = new System.Drawing.Point(137, 56);
            this.dtFechaCaculoSD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtFechaCaculoSD.Name = "dtFechaCaculoSD";
            this.dtFechaCaculoSD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaCaculoSD.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaCaculoSD.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dtFechaCaculoSD.Size = new System.Drawing.Size(209, 23);
            this.dtFechaCaculoSD.TabIndex = 4;
            this.dtFechaCaculoSD.EditValueChanged += new System.EventHandler(this.dtFechaCaculoSD_EditValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ruta:";
            // 
            // txtRutaArchivo
            // 
            this.txtRutaArchivo.Location = new System.Drawing.Point(137, 28);
            this.txtRutaArchivo.Name = "txtRutaArchivo";
            this.txtRutaArchivo.Size = new System.Drawing.Size(461, 23);
            this.txtRutaArchivo.TabIndex = 1;
            // 
            // btnValidarInformacion
            // 
            this.btnValidarInformacion.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnValidarInformacion.ImageOptions.Image")));
            this.btnValidarInformacion.Location = new System.Drawing.Point(600, 28);
            this.btnValidarInformacion.Name = "btnValidarInformacion";
            this.btnValidarInformacion.Size = new System.Drawing.Size(179, 23);
            this.btnValidarInformacion.TabIndex = 2;
            this.btnValidarInformacion.Text = "Validar Archivo";
            this.btnValidarInformacion.Click += new System.EventHandler(this.btnValidarInformacion_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gvdInfonavit);
            this.groupControl1.Location = new System.Drawing.Point(1229, 15);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(553, 100);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Empleados";
            this.groupControl1.Visible = false;
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
            this.panel1.Location = new System.Drawing.Point(0, 124);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1052, 38);
            this.panel1.TabIndex = 18;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(9, 4);
            this.btnSelectAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(128, 28);
            this.btnSelectAll.TabIndex = 1;
            this.btnSelectAll.Text = "Seleccionar Todo";
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnDesSelectAll
            // 
            this.btnDesSelectAll.Location = new System.Drawing.Point(147, 4);
            this.btnDesSelectAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDesSelectAll.Name = "btnDesSelectAll";
            this.btnDesSelectAll.Size = new System.Drawing.Size(128, 28);
            this.btnDesSelectAll.TabIndex = 7;
            this.btnDesSelectAll.Text = "Deseleccionar Todo";
            this.btnDesSelectAll.Click += new System.EventHandler(this.btnDesSelectAll_Click);
            // 
            // lblEmpleadosConError
            // 
            this.lblEmpleadosConError.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblEmpleadosConError.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblEmpleadosConError.Appearance.Options.UseFont = true;
            this.lblEmpleadosConError.Appearance.Options.UseForeColor = true;
            this.lblEmpleadosConError.Location = new System.Drawing.Point(1007, 13);
            this.lblEmpleadosConError.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblEmpleadosConError.Name = "lblEmpleadosConError";
            this.lblEmpleadosConError.Size = new System.Drawing.Size(9, 17);
            this.lblEmpleadosConError.TabIndex = 14;
            this.lblEmpleadosConError.Text = "0";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(792, 12);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(209, 17);
            this.labelControl3.TabIndex = 13;
            this.labelControl3.Text = "Total de Empleados con Error:";
            // 
            // lblTotaldeEmpleados
            // 
            this.lblTotaldeEmpleados.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTotaldeEmpleados.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblTotaldeEmpleados.Appearance.Options.UseFont = true;
            this.lblTotaldeEmpleados.Appearance.Options.UseForeColor = true;
            this.lblTotaldeEmpleados.Location = new System.Drawing.Point(729, 12);
            this.lblTotaldeEmpleados.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblTotaldeEmpleados.Name = "lblTotaldeEmpleados";
            this.lblTotaldeEmpleados.Size = new System.Drawing.Size(9, 17);
            this.lblTotaldeEmpleados.TabIndex = 11;
            this.lblTotaldeEmpleados.Text = "0";
            // 
            // lblRegistrosSeleccionados
            // 
            this.lblRegistrosSeleccionados.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblRegistrosSeleccionados.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblRegistrosSeleccionados.Appearance.Options.UseFont = true;
            this.lblRegistrosSeleccionados.Appearance.Options.UseForeColor = true;
            this.lblRegistrosSeleccionados.Location = new System.Drawing.Point(583, 12);
            this.lblRegistrosSeleccionados.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblRegistrosSeleccionados.Name = "lblRegistrosSeleccionados";
            this.lblRegistrosSeleccionados.Size = new System.Drawing.Size(140, 17);
            this.lblRegistrosSeleccionados.TabIndex = 10;
            this.lblRegistrosSeleccionados.Text = "Total de Empleados:";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.gCtrlEmpleados);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(1052, 383);
            this.groupControl3.TabIndex = 0;
            this.groupControl3.Text = "Empleados";
            // 
            // gCtrlEmpleados
            // 
            this.gCtrlEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gCtrlEmpleados.Location = new System.Drawing.Point(2, 25);
            this.gCtrlEmpleados.MainView = this.gridViewEmpleados;
            this.gCtrlEmpleados.Name = "gCtrlEmpleados";
            this.gCtrlEmpleados.Size = new System.Drawing.Size(1048, 356);
            this.gCtrlEmpleados.TabIndex = 0;
            this.gCtrlEmpleados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewEmpleados});
            this.gCtrlEmpleados.Click += new System.EventHandler(this.gCtrlEmpleados_Click);
            // 
            // gridViewEmpleados
            // 
            this.gridViewEmpleados.GridControl = this.gCtrlEmpleados;
            this.gridViewEmpleados.Name = "gridViewEmpleados";
            this.gridViewEmpleados.OptionsBehavior.ReadOnly = true;
            this.gridViewEmpleados.OptionsSelection.MultiSelect = true;
            this.gridViewEmpleados.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewEmpleados.OptionsView.ShowGroupPanel = false;
            this.gridViewEmpleados.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridViewEmpleados_SelectionChanged);
            // 
            // dbSAICBPOCatalogosDataSet1
            // 
            this.dbSAICBPOCatalogosDataSet1.DataSetName = "dbSAICBPOCatalogosDataSet";
            this.dbSAICBPOCatalogosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbSAICBPOValidacionDataSet1
            // 
            this.dbSAICBPOValidacionDataSet1.DataSetName = "dbSAICBPOValidacionDataSet";
            this.dbSAICBPOValidacionDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // stpSelValidacionActualizacionEmpleadosMasiva_SD_SDITableAdapter1
            // 
            this.stpSelValidacionActualizacionEmpleadosMasiva_SD_SDITableAdapter1.ClearBeforeFill = true;
            // 
            // frmActualizarSBC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 576);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1056, 572);
            this.Name = "frmActualizarSBC";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmActualizarMontosRecup_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvdInfonavit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelObtenerEmpleadoSDIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOActualizacionesIMSSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaCaculoSD.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaCaculoSD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRutaArchivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gCtrlEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOValidacionDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton btnCargarRecupe;
        private System.Windows.Forms.ToolStripTextBox txtLiga;
        private System.Windows.Forms.ToolStripButton btnCargarArchivo;
        private DevExpress.XtraGrid.GridControl gvdInfonavit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.ToolStripButton btnDescargar;
        private System.Windows.Forms.SaveFileDialog sfdRutaArchivo;
        private System.Windows.Forms.OpenFileDialog ObtenerArchivo;
        private System.Windows.Forms.BindingSource stpSelObtenerEmpleadoSDIBindingSource;
        private dbSAICBPOActualizacionesIMSSDataSet dbSAICBPOActualizacionesIMSSDataSet;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreEmpleadoCompleto;
        private DevExpress.XtraGrid.Columns.GridColumn colNSS;
        private DevExpress.XtraGrid.Columns.GridColumn colRFC;
        private DevExpress.XtraGrid.Columns.GridColumn colCURP;
        private DevExpress.XtraGrid.Columns.GridColumn colSalarioDiarioContrato;
        private DevExpress.XtraGrid.Columns.GridColumn colSalarioDiarioIntegradoContrato;
        private dbSAICBPOActualizacionesIMSSDataSetTableAdapters.stpSelObtenerEmpleadoSDITableAdapter stpSelObtenerEmpleadoSDITableAdapter;
        private dbSAICBPOActualizacionesIMSSDataSetTableAdapters.ActualizacionesIMSSTableAdapter actualizacionesIMSSTableAdapter1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.SimpleButton btnActualizar;
        private DevExpress.XtraEditors.SimpleButton btnValidarInformacion;
        private DevExpress.XtraEditors.TextEdit txtRutaArchivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl lblRegistrosSeleccionados;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.LabelControl lblTotaldeEmpleados;
        private DevExpress.XtraGrid.GridControl gCtrlEmpleados;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEmpleados;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl lblEmpleadosConError;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        
        private dbSAICBPOCatalogosDataSet dbSAICBPOCatalogosDataSet1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.DateEdit dtFechaCaculoSD;
        private dbSAICBPOValidacionDataSetTableAdapters.stpSelEstatusNominaContabilizadaTableAdapter stpSelEstatusNominaContabilizadaTableAdapter1;
        private dbSAICBPOValidacionDataSet dbSAICBPOValidacionDataSet1;
        private DevExpress.XtraEditors.SimpleButton btnDesSelectAll;
        private DevExpress.XtraEditors.SimpleButton btnSelectAll;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelValidacionActualizacionEmpleadosMasiva_SD_SDITableAdapter stpSelValidacionActualizacionEmpleadosMasiva_SD_SDITableAdapter1;
    }
}