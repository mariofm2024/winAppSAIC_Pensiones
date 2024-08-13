namespace winAppSAIC.IMSS
{
    partial class XtraCreditosInfonavitMasivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraCreditosInfonavitMasivos));
            this.label1 = new System.Windows.Forms.Label();
            this.btnSeleccionarExcel = new DevExpress.XtraEditors.SimpleButton();
            this.txtRutaArchivo = new DevExpress.XtraEditors.TextEdit();
            this.txtNombreArchivo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumEmpleados = new DevExpress.XtraEditors.TextEdit();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDesSelectAll = new DevExpress.XtraEditors.SimpleButton();
            this.lblEmpleadosSeleccionados = new System.Windows.Forms.Label();
            this.btnSelectAll = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tctEmpleadoConError = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDescargar = new System.Windows.Forms.ToolStripButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlEmpleados = new DevExpress.XtraGrid.GridControl();
            this.gridViewEmpleados = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.stpSelValidarEmpleadosInfonatitTableAdapter1 = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelValidarEmpleadosInfonatitTableAdapter();
            this.dbSAICBPOCatalogosDataSet1 = new winAppSAIC.dbSAICBPOCatalogosDataSet();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::winAppSAIC.SplashDeCarga), true, true);
            this.queriesTableAdapter1 = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.QueriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.txtRutaArchivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumEmpleados.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tctEmpleadoConError.Properties)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ruta:";
            // 
            // btnSeleccionarExcel
            // 
            this.btnSeleccionarExcel.ImageOptions.Image = global::winAppSAIC.Properties.Resources.Excel;
            this.btnSeleccionarExcel.Location = new System.Drawing.Point(405, 43);
            this.btnSeleccionarExcel.Name = "btnSeleccionarExcel";
            this.btnSeleccionarExcel.Size = new System.Drawing.Size(179, 23);
            this.btnSeleccionarExcel.TabIndex = 5;
            this.btnSeleccionarExcel.Text = "Seleccionar Excel";
            this.btnSeleccionarExcel.Click += new System.EventHandler(this.btnSeleccionarExcel_Click);
            // 
            // txtRutaArchivo
            // 
            this.txtRutaArchivo.Location = new System.Drawing.Point(61, 43);
            this.txtRutaArchivo.Name = "txtRutaArchivo";
            this.txtRutaArchivo.Size = new System.Drawing.Size(339, 22);
            this.txtRutaArchivo.TabIndex = 4;
            // 
            // txtNombreArchivo
            // 
            this.txtNombreArchivo.AutoSize = true;
            this.txtNombreArchivo.Location = new System.Drawing.Point(63, 68);
            this.txtNombreArchivo.Name = "txtNombreArchivo";
            this.txtNombreArchivo.Size = new System.Drawing.Size(128, 17);
            this.txtNombreArchivo.TabIndex = 6;
            this.txtNombreArchivo.Text = "Nombre del Archivo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(607, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Empleados en Archivo:";
            // 
            // txtNumEmpleados
            // 
            this.txtNumEmpleados.Location = new System.Drawing.Point(758, 45);
            this.txtNumEmpleados.Name = "txtNumEmpleados";
            this.txtNumEmpleados.Properties.Appearance.Options.UseTextOptions = true;
            this.txtNumEmpleados.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtNumEmpleados.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtNumEmpleados.Properties.ReadOnly = true;
            this.txtNumEmpleados.Size = new System.Drawing.Size(99, 22);
            this.txtNumEmpleados.TabIndex = 8;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupControl3);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.groupControl1);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupControl2);
            this.splitContainer1.Size = new System.Drawing.Size(1144, 521);
            this.splitContainer1.SplitterDistance = 209;
            this.splitContainer1.TabIndex = 9;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.btnCancelar);
            this.groupControl3.Controls.Add(this.btnAgregar);
            this.groupControl3.Location = new System.Drawing.Point(889, 39);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(246, 106);
            this.groupControl3.TabIndex = 26;
            // 
            // btnCancelar
            // 
            this.btnCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.ImageOptions.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(16, 39);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(213, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Enabled = false;
            this.btnAgregar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.ImageOptions.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(16, 71);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(213, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Actualizar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(153)))), ((int)(((byte)(205)))));
            this.panel1.Controls.Add(this.btnDesSelectAll);
            this.panel1.Controls.Add(this.lblEmpleadosSeleccionados);
            this.panel1.Controls.Add(this.btnSelectAll);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 160);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1144, 49);
            this.panel1.TabIndex = 25;
            // 
            // btnDesSelectAll
            // 
            this.btnDesSelectAll.Location = new System.Drawing.Point(148, 12);
            this.btnDesSelectAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDesSelectAll.Name = "btnDesSelectAll";
            this.btnDesSelectAll.Size = new System.Drawing.Size(128, 28);
            this.btnDesSelectAll.TabIndex = 11;
            this.btnDesSelectAll.Text = "Deseleccionar Todo";
            this.btnDesSelectAll.Click += new System.EventHandler(this.btnDesSelectAll_Click);
            // 
            // lblEmpleadosSeleccionados
            // 
            this.lblEmpleadosSeleccionados.AutoSize = true;
            this.lblEmpleadosSeleccionados.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblEmpleadosSeleccionados.ForeColor = System.Drawing.Color.White;
            this.lblEmpleadosSeleccionados.Location = new System.Drawing.Point(1092, 18);
            this.lblEmpleadosSeleccionados.Name = "lblEmpleadosSeleccionados";
            this.lblEmpleadosSeleccionados.Size = new System.Drawing.Size(44, 17);
            this.lblEmpleadosSeleccionados.TabIndex = 12;
            this.lblEmpleadosSeleccionados.Text = "9999";
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(12, 12);
            this.btnSelectAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(128, 28);
            this.btnSelectAll.TabIndex = 10;
            this.btnSelectAll.Text = "Seleccionar Todo";
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(902, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Empleados Seleccionados:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.tctEmpleadoConError);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.txtNombreArchivo);
            this.groupControl1.Controls.Add(this.btnSeleccionarExcel);
            this.groupControl1.Controls.Add(this.txtNumEmpleados);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.txtRutaArchivo);
            this.groupControl1.Location = new System.Drawing.Point(12, 39);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(871, 106);
            this.groupControl1.TabIndex = 10;
            // 
            // tctEmpleadoConError
            // 
            this.tctEmpleadoConError.Location = new System.Drawing.Point(758, 75);
            this.tctEmpleadoConError.Name = "tctEmpleadoConError";
            this.tctEmpleadoConError.Properties.Appearance.Options.UseTextOptions = true;
            this.tctEmpleadoConError.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tctEmpleadoConError.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.tctEmpleadoConError.Properties.ReadOnly = true;
            this.tctEmpleadoConError.Size = new System.Drawing.Size(99, 22);
            this.tctEmpleadoConError.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(614, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Empleados con Error:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.btnDescargar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1144, 27);
            this.toolStrip1.TabIndex = 9;
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
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
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControlEmpleados);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1144, 308);
            this.groupControl2.TabIndex = 0;
            // 
            // gridControlEmpleados
            // 
            this.gridControlEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlEmpleados.Location = new System.Drawing.Point(2, 25);
            this.gridControlEmpleados.MainView = this.gridViewEmpleados;
            this.gridControlEmpleados.Name = "gridControlEmpleados";
            this.gridControlEmpleados.Size = new System.Drawing.Size(1140, 281);
            this.gridControlEmpleados.TabIndex = 0;
            this.gridControlEmpleados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewEmpleados});
            // 
            // gridViewEmpleados
            // 
            this.gridViewEmpleados.GridControl = this.gridControlEmpleados;
            this.gridViewEmpleados.Name = "gridViewEmpleados";
            this.gridViewEmpleados.OptionsBehavior.ReadOnly = true;
            this.gridViewEmpleados.OptionsSelection.MultiSelect = true;
            this.gridViewEmpleados.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewEmpleados.OptionsView.ShowAutoFilterRow = true;
            this.gridViewEmpleados.OptionsView.ShowGroupPanel = false;
            this.gridViewEmpleados.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridViewEmpleados_RowStyle);
            this.gridViewEmpleados.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridViewEmpleados_SelectionChanged);
            // 
            // stpSelValidarEmpleadosInfonatitTableAdapter1
            // 
            this.stpSelValidarEmpleadosInfonatitTableAdapter1.ClearBeforeFill = true;
            // 
            // dbSAICBPOCatalogosDataSet1
            // 
            this.dbSAICBPOCatalogosDataSet1.DataSetName = "dbSAICBPOCatalogosDataSet";
            this.dbSAICBPOCatalogosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // XtraCreditosInfonavitMasivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 521);
            this.Controls.Add(this.splitContainer1);
            this.MinimizeBox = false;
            this.Name = "XtraCreditosInfonavitMasivos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creditos de Infonavit";
            this.Load += new System.EventHandler(this.XtraCreditosInfonavitMasivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtRutaArchivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumEmpleados.Properties)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tctEmpleadoConError.Properties)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnSeleccionarExcel;
        private DevExpress.XtraEditors.TextEdit txtRutaArchivo;
        private System.Windows.Forms.Label txtNombreArchivo;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtNumEmpleados;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnDescargar;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControlEmpleados;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEmpleados;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnAgregar;
        private DevExpress.XtraEditors.TextEdit tctEmpleadoConError;
        private System.Windows.Forms.Label label3;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelValidarEmpleadosInfonatitTableAdapter stpSelValidarEmpleadosInfonatitTableAdapter1;
        private dbSAICBPOCatalogosDataSet dbSAICBPOCatalogosDataSet1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private System.Windows.Forms.Label lblEmpleadosSeleccionados;
        private System.Windows.Forms.Label label4;
        private dbSAICBPOCatalogosDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private DevExpress.XtraEditors.SimpleButton btnDesSelectAll;
        private DevExpress.XtraEditors.SimpleButton btnSelectAll;
    }
}