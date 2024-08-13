namespace winAppSAIC.Contablidad
{
    partial class frmxConciliacionUUID
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmxConciliacionUUID));
            this.txtRutaArchivo = new DevExpress.XtraEditors.TextEdit();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtRegistrosEnSAIC = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSeparador = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblNombreArchivo = new DevExpress.XtraEditors.LabelControl();
            this.btnDescargar = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExcel = new System.Windows.Forms.ToolStripButton();
            this.txtNumRegistros = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnSubirArchivo = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dbSAICBPOContabilidad1 = new winAppSAIC.Contablidad.dbSAICBPOContabilidad();
            this.stpSelValidacionConciliacionUUIDTableAdapter1 = new winAppSAIC.Contablidad.dbSAICBPOContabilidadTableAdapters.stpSelValidacionConciliacionUUIDTableAdapter();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::winAppSAIC.SplashDeCarga), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.txtRutaArchivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegistrosEnSAIC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeparador.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDescargar)).BeginInit();
            this.btnDescargar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumRegistros.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOContabilidad1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRutaArchivo
            // 
            this.txtRutaArchivo.Location = new System.Drawing.Point(52, 40);
            this.txtRutaArchivo.Name = "txtRutaArchivo";
            this.txtRutaArchivo.Size = new System.Drawing.Size(414, 22);
            this.txtRutaArchivo.TabIndex = 0;
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
            this.splitContainer1.Panel1.Controls.Add(this.txtRegistrosEnSAIC);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txtSeparador);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainer1.Panel1.Controls.Add(this.lblNombreArchivo);
            this.splitContainer1.Panel1.Controls.Add(this.btnDescargar);
            this.splitContainer1.Panel1.Controls.Add(this.txtNumRegistros);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl1);
            this.splitContainer1.Panel1.Controls.Add(this.btnSubirArchivo);
            this.splitContainer1.Panel1.Controls.Add(this.txtRutaArchivo);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1085, 522);
            this.splitContainer1.SplitterDistance = 139;
            this.splitContainer1.TabIndex = 1;
            // 
            // txtRegistrosEnSAIC
            // 
            this.txtRegistrosEnSAIC.Location = new System.Drawing.Point(735, 100);
            this.txtRegistrosEnSAIC.Name = "txtRegistrosEnSAIC";
            this.txtRegistrosEnSAIC.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.txtRegistrosEnSAIC.Properties.Appearance.Options.UseFont = true;
            this.txtRegistrosEnSAIC.Properties.Appearance.Options.UseTextOptions = true;
            this.txtRegistrosEnSAIC.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtRegistrosEnSAIC.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtRegistrosEnSAIC.Properties.ReadOnly = true;
            this.txtRegistrosEnSAIC.Size = new System.Drawing.Size(100, 24);
            this.txtRegistrosEnSAIC.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(603, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "#Registros en SAIC:";
            // 
            // txtSeparador
            // 
            this.txtSeparador.EditValue = "~";
            this.txtSeparador.Location = new System.Drawing.Point(735, 45);
            this.txtSeparador.Name = "txtSeparador";
            this.txtSeparador.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtSeparador.Properties.Appearance.Options.UseFont = true;
            this.txtSeparador.Properties.Appearance.Options.UseTextOptions = true;
            this.txtSeparador.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtSeparador.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtSeparador.Size = new System.Drawing.Size(43, 24);
            this.txtSeparador.TabIndex = 25;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(667, 48);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(65, 16);
            this.labelControl2.TabIndex = 24;
            this.labelControl2.Text = "Separador:";
            // 
            // lblNombreArchivo
            // 
            this.lblNombreArchivo.Location = new System.Drawing.Point(52, 69);
            this.lblNombreArchivo.Name = "lblNombreArchivo";
            this.lblNombreArchivo.Size = new System.Drawing.Size(127, 16);
            this.lblNombreArchivo.TabIndex = 23;
            this.lblNombreArchivo.Text = "xxxxxxxxxxxxxxxxxxxxx";
            // 
            // btnDescargar
            // 
            this.btnDescargar.AddNewItem = null;
            this.btnDescargar.CountItem = null;
            this.btnDescargar.DeleteItem = null;
            this.btnDescargar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.btnDescargar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnSalir,
            this.toolStripSeparator1,
            this.btnExcel});
            this.btnDescargar.Location = new System.Drawing.Point(0, 0);
            this.btnDescargar.MoveFirstItem = null;
            this.btnDescargar.MoveLastItem = null;
            this.btnDescargar.MoveNextItem = null;
            this.btnDescargar.MovePreviousItem = null;
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.PositionItem = null;
            this.btnDescargar.Size = new System.Drawing.Size(1085, 27);
            this.btnDescargar.TabIndex = 22;
            this.btnDescargar.Text = "bindingNavigator1";
            // 
            // toolBtnSalir
            // 
            this.toolBtnSalir.Image = global::winAppSAIC.Properties.Resources.Salir24x24;
            this.toolBtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnSalir.Name = "toolBtnSalir";
            this.toolBtnSalir.Size = new System.Drawing.Size(62, 24);
            this.toolBtnSalir.Text = "Salir";
            this.toolBtnSalir.Click += new System.EventHandler(this.toolBtnSalir_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // btnExcel
            // 
            this.btnExcel.Image = global::winAppSAIC.Properties.Resources.Excel;
            this.btnExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(138, 24);
            this.btnExcel.Text = "Descargar Excel";
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // txtNumRegistros
            // 
            this.txtNumRegistros.Location = new System.Drawing.Point(735, 75);
            this.txtNumRegistros.Name = "txtNumRegistros";
            this.txtNumRegistros.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.txtNumRegistros.Properties.Appearance.Options.UseFont = true;
            this.txtNumRegistros.Properties.Appearance.Options.UseTextOptions = true;
            this.txtNumRegistros.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtNumRegistros.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtNumRegistros.Properties.ReadOnly = true;
            this.txtNumRegistros.Size = new System.Drawing.Size(100, 24);
            this.txtNumRegistros.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(654, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "#Registros:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 43);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(31, 16);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Ruta:";
            // 
            // btnSubirArchivo
            // 
            this.btnSubirArchivo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSubirArchivo.ImageOptions.Image")));
            this.btnSubirArchivo.Location = new System.Drawing.Point(472, 41);
            this.btnSubirArchivo.Name = "btnSubirArchivo";
            this.btnSubirArchivo.Size = new System.Drawing.Size(154, 23);
            this.btnSubirArchivo.TabIndex = 1;
            this.btnSubirArchivo.Text = "Subir Archivo";
            this.btnSubirArchivo.Click += new System.EventHandler(this.btnSubirArchivo_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1085, 379);
            this.groupControl1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 25);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1081, 352);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // dbSAICBPOContabilidad1
            // 
            this.dbSAICBPOContabilidad1.DataSetName = "dbSAICBPOContabilidad";
            this.dbSAICBPOContabilidad1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stpSelValidacionConciliacionUUIDTableAdapter1
            // 
            this.stpSelValidacionConciliacionUUIDTableAdapter1.ClearBeforeFill = true;
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // frmxConciliacionUUID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 522);
            this.Controls.Add(this.splitContainer1);
            this.MinimizeBox = false;
            this.Name = "frmxConciliacionUUID";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conciliacion SAT UUID";
            this.Load += new System.EventHandler(this.frmxConciliacionUUID_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtRutaArchivo.Properties)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtRegistrosEnSAIC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeparador.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDescargar)).EndInit();
            this.btnDescargar.ResumeLayout(false);
            this.btnDescargar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumRegistros.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOContabilidad1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtRutaArchivo;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSubirArchivo;
        private DevExpress.XtraEditors.TextEdit txtNumRegistros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingNavigator btnDescargar;
        private System.Windows.Forms.ToolStripButton toolBtnSalir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private DevExpress.XtraEditors.LabelControl lblNombreArchivo;
        private DevExpress.XtraEditors.TextEdit txtSeparador;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ToolStripButton btnExcel;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit txtRegistrosEnSAIC;
        private System.Windows.Forms.Label label2;
        private dbSAICBPOContabilidad dbSAICBPOContabilidad1;
        private dbSAICBPOContabilidadTableAdapters.stpSelValidacionConciliacionUUIDTableAdapter stpSelValidacionConciliacionUUIDTableAdapter1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}