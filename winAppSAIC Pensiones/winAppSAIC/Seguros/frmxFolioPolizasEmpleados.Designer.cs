namespace winAppSAIC.Seguros
{
    partial class frmxFolioPolizasEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmxFolioPolizasEmpleados));
            this.btnDescargar = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExportarExcel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnImportarExcel = new System.Windows.Forms.ToolStripButton();
            this.txtRutaExcel = new System.Windows.Forms.ToolStripTextBox();
            this.gCtrlEmpleadosPoliza = new DevExpress.XtraEditors.GroupControl();
            this.ctrPolizaEmpleados = new DevExpress.XtraGrid.GridControl();
            this.stpSelInfoEmpleadosPolizaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPOCatalogosDataSet1 = new winAppSAIC.dbSAICBPOCatalogosDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpleadoPoliza = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAPaternoEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAMaternoEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNSS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRFC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCURP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenedora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstatusEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoPoliza = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescCIAAseguradora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFolio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaInicioVigencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaVencimientoVigencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstatusPoliza = new DevExpress.XtraGrid.Columns.GridColumn();
            this.stpSelInfoEmpleadosPolizaTableAdapter1 = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelInfoEmpleadosPolizaTableAdapter();
            this.queriesTableAdapter1 = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.QueriesTableAdapter();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::winAppSAIC.SplashDeCarga), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.btnDescargar)).BeginInit();
            this.btnDescargar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gCtrlEmpleadosPoliza)).BeginInit();
            this.gCtrlEmpleadosPoliza.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctrPolizaEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelInfoEmpleadosPolizaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDescargar
            // 
            this.btnDescargar.AddNewItem = null;
            this.btnDescargar.CountItem = null;
            this.btnDescargar.CountItemFormat = "de {0}";
            this.btnDescargar.DeleteItem = null;
            this.btnDescargar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnSalir,
            this.toolStripSeparator1,
            this.btnExportarExcel,
            this.toolStripSeparator4,
            this.toolStripButton1,
            this.toolStripSeparator2,
            this.btnImportarExcel,
            this.txtRutaExcel});
            this.btnDescargar.Location = new System.Drawing.Point(0, 0);
            this.btnDescargar.MoveFirstItem = null;
            this.btnDescargar.MoveLastItem = null;
            this.btnDescargar.MoveNextItem = null;
            this.btnDescargar.MovePreviousItem = null;
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.PositionItem = null;
            this.btnDescargar.Size = new System.Drawing.Size(842, 25);
            this.btnDescargar.TabIndex = 20;
            this.btnDescargar.Text = "bindingNavigator1";
            // 
            // toolBtnSalir
            // 
            this.toolBtnSalir.Image = global::winAppSAIC.Properties.Resources.Salir24x24;
            this.toolBtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnSalir.Name = "toolBtnSalir";
            this.toolBtnSalir.Size = new System.Drawing.Size(49, 22);
            this.toolBtnSalir.Text = "Salir";
            this.toolBtnSalir.Click += new System.EventHandler(this.toolBtnSalir_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExportarExcel.Image")));
            this.btnExportarExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(99, 22);
            this.btnExportarExcel.Text = "Exportar Excel";
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(97, 22);
            this.toolStripButton1.Text = "Abrir Carpeta";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnImportarExcel
            // 
            this.btnImportarExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnImportarExcel.Image")));
            this.btnImportarExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImportarExcel.Name = "btnImportarExcel";
            this.btnImportarExcel.Size = new System.Drawing.Size(102, 22);
            this.btnImportarExcel.Text = "Importar Excel";
            this.btnImportarExcel.Click += new System.EventHandler(this.btnImportarExcel_Click);
            // 
            // txtRutaExcel
            // 
            this.txtRutaExcel.Name = "txtRutaExcel";
            this.txtRutaExcel.Size = new System.Drawing.Size(400, 25);
            // 
            // gCtrlEmpleadosPoliza
            // 
            this.gCtrlEmpleadosPoliza.Controls.Add(this.ctrPolizaEmpleados);
            this.gCtrlEmpleadosPoliza.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gCtrlEmpleadosPoliza.Location = new System.Drawing.Point(0, 25);
            this.gCtrlEmpleadosPoliza.Name = "gCtrlEmpleadosPoliza";
            this.gCtrlEmpleadosPoliza.Size = new System.Drawing.Size(842, 454);
            this.gCtrlEmpleadosPoliza.TabIndex = 21;
            this.gCtrlEmpleadosPoliza.Text = "Póliza de Empleados";
            // 
            // ctrPolizaEmpleados
            // 
            this.ctrPolizaEmpleados.DataSource = this.stpSelInfoEmpleadosPolizaBindingSource;
            this.ctrPolizaEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrPolizaEmpleados.Location = new System.Drawing.Point(2, 22);
            this.ctrPolizaEmpleados.MainView = this.gridView1;
            this.ctrPolizaEmpleados.Name = "ctrPolizaEmpleados";
            this.ctrPolizaEmpleados.Size = new System.Drawing.Size(838, 430);
            this.ctrPolizaEmpleados.TabIndex = 0;
            this.ctrPolizaEmpleados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // stpSelInfoEmpleadosPolizaBindingSource
            // 
            this.stpSelInfoEmpleadosPolizaBindingSource.DataMember = "stpSelInfoEmpleadosPoliza";
            this.stpSelInfoEmpleadosPolizaBindingSource.DataSource = this.dbSAICBPOCatalogosDataSet1;
            // 
            // dbSAICBPOCatalogosDataSet1
            // 
            this.dbSAICBPOCatalogosDataSet1.DataSetName = "dbSAICBPOCatalogosDataSet";
            this.dbSAICBPOCatalogosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpleadoPoliza,
            this.colIdEmpleado,
            this.colAPaternoEmpleado,
            this.colAMaternoEmpleado,
            this.colNombreEmpleado,
            this.colNSS,
            this.colRFC,
            this.colCURP,
            this.colTenedora,
            this.colCliente,
            this.colEstatusEmpleado,
            this.colNoPoliza,
            this.colDescCIAAseguradora,
            this.colFolio,
            this.colFechaInicioVigencia,
            this.colFechaVencimientoVigencia,
            this.colEstatusPoliza});
            this.gridView1.GridControl = this.ctrPolizaEmpleados;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIdEmpleadoPoliza
            // 
            this.colIdEmpleadoPoliza.FieldName = "IdEmpleadoPoliza";
            this.colIdEmpleadoPoliza.Name = "colIdEmpleadoPoliza";
            this.colIdEmpleadoPoliza.Visible = true;
            this.colIdEmpleadoPoliza.VisibleIndex = 0;
            this.colIdEmpleadoPoliza.Width = 109;
            // 
            // colIdEmpleado
            // 
            this.colIdEmpleado.FieldName = "IdEmpleado";
            this.colIdEmpleado.Name = "colIdEmpleado";
            this.colIdEmpleado.Visible = true;
            this.colIdEmpleado.VisibleIndex = 1;
            this.colIdEmpleado.Width = 79;
            // 
            // colAPaternoEmpleado
            // 
            this.colAPaternoEmpleado.FieldName = "APaternoEmpleado";
            this.colAPaternoEmpleado.Name = "colAPaternoEmpleado";
            this.colAPaternoEmpleado.Visible = true;
            this.colAPaternoEmpleado.VisibleIndex = 2;
            this.colAPaternoEmpleado.Width = 114;
            // 
            // colAMaternoEmpleado
            // 
            this.colAMaternoEmpleado.FieldName = "AMaternoEmpleado";
            this.colAMaternoEmpleado.Name = "colAMaternoEmpleado";
            this.colAMaternoEmpleado.Visible = true;
            this.colAMaternoEmpleado.VisibleIndex = 3;
            this.colAMaternoEmpleado.Width = 116;
            // 
            // colNombreEmpleado
            // 
            this.colNombreEmpleado.FieldName = "NombreEmpleado";
            this.colNombreEmpleado.Name = "colNombreEmpleado";
            this.colNombreEmpleado.Visible = true;
            this.colNombreEmpleado.VisibleIndex = 4;
            this.colNombreEmpleado.Width = 106;
            // 
            // colNSS
            // 
            this.colNSS.FieldName = "NSS";
            this.colNSS.Name = "colNSS";
            this.colNSS.Visible = true;
            this.colNSS.VisibleIndex = 5;
            this.colNSS.Width = 132;
            // 
            // colRFC
            // 
            this.colRFC.FieldName = "RFC";
            this.colRFC.Name = "colRFC";
            this.colRFC.Visible = true;
            this.colRFC.VisibleIndex = 6;
            this.colRFC.Width = 146;
            // 
            // colCURP
            // 
            this.colCURP.FieldName = "CURP";
            this.colCURP.Name = "colCURP";
            this.colCURP.Visible = true;
            this.colCURP.VisibleIndex = 7;
            this.colCURP.Width = 147;
            // 
            // colTenedora
            // 
            this.colTenedora.FieldName = "Tenedora";
            this.colTenedora.Name = "colTenedora";
            this.colTenedora.Visible = true;
            this.colTenedora.VisibleIndex = 8;
            this.colTenedora.Width = 224;
            // 
            // colCliente
            // 
            this.colCliente.FieldName = "Cliente";
            this.colCliente.Name = "colCliente";
            this.colCliente.Visible = true;
            this.colCliente.VisibleIndex = 9;
            this.colCliente.Width = 225;
            // 
            // colEstatusEmpleado
            // 
            this.colEstatusEmpleado.FieldName = "Estatus Empleado";
            this.colEstatusEmpleado.Name = "colEstatusEmpleado";
            this.colEstatusEmpleado.Visible = true;
            this.colEstatusEmpleado.VisibleIndex = 10;
            this.colEstatusEmpleado.Width = 105;
            // 
            // colNoPoliza
            // 
            this.colNoPoliza.FieldName = "NoPoliza";
            this.colNoPoliza.Name = "colNoPoliza";
            this.colNoPoliza.Visible = true;
            this.colNoPoliza.VisibleIndex = 11;
            this.colNoPoliza.Width = 76;
            // 
            // colDescCIAAseguradora
            // 
            this.colDescCIAAseguradora.FieldName = "DescCIAAseguradora";
            this.colDescCIAAseguradora.Name = "colDescCIAAseguradora";
            this.colDescCIAAseguradora.Visible = true;
            this.colDescCIAAseguradora.VisibleIndex = 12;
            this.colDescCIAAseguradora.Width = 129;
            // 
            // colFolio
            // 
            this.colFolio.FieldName = "Folio";
            this.colFolio.Name = "colFolio";
            this.colFolio.Visible = true;
            this.colFolio.VisibleIndex = 13;
            this.colFolio.Width = 76;
            // 
            // colFechaInicioVigencia
            // 
            this.colFechaInicioVigencia.FieldName = "Fecha Inicio Vigencia";
            this.colFechaInicioVigencia.Name = "colFechaInicioVigencia";
            this.colFechaInicioVigencia.Visible = true;
            this.colFechaInicioVigencia.VisibleIndex = 14;
            this.colFechaInicioVigencia.Width = 119;
            // 
            // colFechaVencimientoVigencia
            // 
            this.colFechaVencimientoVigencia.FieldName = "Fecha Vencimiento Vigencia";
            this.colFechaVencimientoVigencia.Name = "colFechaVencimientoVigencia";
            this.colFechaVencimientoVigencia.Visible = true;
            this.colFechaVencimientoVigencia.VisibleIndex = 15;
            this.colFechaVencimientoVigencia.Width = 151;
            // 
            // colEstatusPoliza
            // 
            this.colEstatusPoliza.FieldName = "Estatus Poliza";
            this.colEstatusPoliza.Name = "colEstatusPoliza";
            this.colEstatusPoliza.Visible = true;
            this.colEstatusPoliza.VisibleIndex = 16;
            this.colEstatusPoliza.Width = 86;
            // 
            // stpSelInfoEmpleadosPolizaTableAdapter1
            // 
            this.stpSelInfoEmpleadosPolizaTableAdapter1.ClearBeforeFill = true;
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // frmxFolioPolizasEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 479);
            this.Controls.Add(this.gCtrlEmpleadosPoliza);
            this.Controls.Add(this.btnDescargar);
            this.MinimizeBox = false;
            this.Name = "frmxFolioPolizasEmpleados";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmxFolioPolizasEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnDescargar)).EndInit();
            this.btnDescargar.ResumeLayout(false);
            this.btnDescargar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gCtrlEmpleadosPoliza)).EndInit();
            this.gCtrlEmpleadosPoliza.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ctrPolizaEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelInfoEmpleadosPolizaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator btnDescargar;
        private System.Windows.Forms.ToolStripButton toolBtnSalir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnExportarExcel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnImportarExcel;
        private System.Windows.Forms.ToolStripTextBox txtRutaExcel;
        private DevExpress.XtraEditors.GroupControl gCtrlEmpleadosPoliza;
        private DevExpress.XtraGrid.GridControl ctrPolizaEmpleados;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private dbSAICBPOCatalogosDataSet dbSAICBPOCatalogosDataSet1;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelInfoEmpleadosPolizaTableAdapter stpSelInfoEmpleadosPolizaTableAdapter1;
        private dbSAICBPOCatalogosDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private System.Windows.Forms.BindingSource stpSelInfoEmpleadosPolizaBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpleadoPoliza;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn colAPaternoEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn colAMaternoEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn colNSS;
        private DevExpress.XtraGrid.Columns.GridColumn colRFC;
        private DevExpress.XtraGrid.Columns.GridColumn colCURP;
        private DevExpress.XtraGrid.Columns.GridColumn colTenedora;
        private DevExpress.XtraGrid.Columns.GridColumn colCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colEstatusEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn colNoPoliza;
        private DevExpress.XtraGrid.Columns.GridColumn colDescCIAAseguradora;
        private DevExpress.XtraGrid.Columns.GridColumn colFolio;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaInicioVigencia;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaVencimientoVigencia;
        private DevExpress.XtraGrid.Columns.GridColumn colEstatusPoliza;
    }
}