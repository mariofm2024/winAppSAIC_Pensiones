namespace winAppSAIC.IMSS
{
    partial class XtraParametros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraParametros));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rTexBoxDescripcion = new System.Windows.Forms.RichTextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnActualizar = new DevExpress.XtraEditors.SimpleButton();
            this.txtParametro = new DevExpress.XtraEditors.TextEdit();
            this.txtValorParametro = new DevExpress.XtraEditors.TextEdit();
            this.txtIdParametro = new DevExpress.XtraEditors.TextEdit();
            this.gridControlParametros = new DevExpress.XtraGrid.GridControl();
            this.stpSelParametrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPOActualizacionesIMSSDataSet1 = new winAppSAIC.IMSS.dbSAICBPOActualizacionesIMSSDataSet();
            this.gridViewParametros = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdParametro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescParametro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorParametro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.actualizacionesIMSSTableAdapter1 = new winAppSAIC.IMSS.dbSAICBPOActualizacionesIMSSDataSetTableAdapters.ActualizacionesIMSSTableAdapter();
            this.stpSelParametrosTableAdapter1 = new winAppSAIC.IMSS.dbSAICBPOActualizacionesIMSSDataSetTableAdapters.stpSelParametrosTableAdapter();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtParametro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorParametro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdParametro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlParametros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelParametrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOActualizacionesIMSSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewParametros)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(930, 27);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
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
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.rTexBoxDescripcion);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl4);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl3);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl1);
            this.splitContainer1.Panel1.Controls.Add(this.btnActualizar);
            this.splitContainer1.Panel1.Controls.Add(this.txtParametro);
            this.splitContainer1.Panel1.Controls.Add(this.txtValorParametro);
            this.splitContainer1.Panel1.Controls.Add(this.txtIdParametro);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridControlParametros);
            this.splitContainer1.Size = new System.Drawing.Size(930, 383);
            this.splitContainer1.SplitterDistance = 147;
            this.splitContainer1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(153)))), ((int)(((byte)(205)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(930, 31);
            this.panel1.TabIndex = 18;
            // 
            // rTexBoxDescripcion
            // 
            this.rTexBoxDescripcion.Enabled = false;
            this.rTexBoxDescripcion.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.rTexBoxDescripcion.Location = new System.Drawing.Point(103, 60);
            this.rTexBoxDescripcion.Name = "rTexBoxDescripcion";
            this.rTexBoxDescripcion.Size = new System.Drawing.Size(616, 42);
            this.rTexBoxDescripcion.TabIndex = 9;
            this.rTexBoxDescripcion.Text = "";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(25, 60);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(58, 13);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Descripcion:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(223, 34);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(54, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Parametro:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(474, 33);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(75, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Valor Paremtro:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(39, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "idParametro:";
            // 
            // btnActualizar
            // 
            this.btnActualizar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.ImageOptions.Image")));
            this.btnActualizar.Location = new System.Drawing.Point(725, 28);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(196, 23);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtParametro
            // 
            this.txtParametro.Location = new System.Drawing.Point(279, 31);
            this.txtParametro.Name = "txtParametro";
            this.txtParametro.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtParametro.Properties.Appearance.Options.UseFont = true;
            this.txtParametro.Properties.Appearance.Options.UseTextOptions = true;
            this.txtParametro.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtParametro.Properties.ReadOnly = true;
            this.txtParametro.Size = new System.Drawing.Size(167, 20);
            this.txtParametro.TabIndex = 2;
            // 
            // txtValorParametro
            // 
            this.txtValorParametro.Location = new System.Drawing.Point(552, 31);
            this.txtValorParametro.Name = "txtValorParametro";
            this.txtValorParametro.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.txtValorParametro.Properties.Appearance.Options.UseFont = true;
            this.txtValorParametro.Size = new System.Drawing.Size(167, 20);
            this.txtValorParametro.TabIndex = 1;
            // 
            // txtIdParametro
            // 
            this.txtIdParametro.Location = new System.Drawing.Point(103, 31);
            this.txtIdParametro.Name = "txtIdParametro";
            this.txtIdParametro.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtIdParametro.Properties.Appearance.Options.UseFont = true;
            this.txtIdParametro.Properties.Appearance.Options.UseTextOptions = true;
            this.txtIdParametro.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtIdParametro.Properties.ReadOnly = true;
            this.txtIdParametro.Size = new System.Drawing.Size(100, 20);
            this.txtIdParametro.TabIndex = 0;
            // 
            // gridControlParametros
            // 
            this.gridControlParametros.DataSource = this.stpSelParametrosBindingSource;
            this.gridControlParametros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlParametros.Location = new System.Drawing.Point(0, 0);
            this.gridControlParametros.MainView = this.gridViewParametros;
            this.gridControlParametros.Name = "gridControlParametros";
            this.gridControlParametros.Size = new System.Drawing.Size(930, 232);
            this.gridControlParametros.TabIndex = 0;
            this.gridControlParametros.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewParametros});
            this.gridControlParametros.Click += new System.EventHandler(this.gridControlParametros_Click);
            // 
            // stpSelParametrosBindingSource
            // 
            this.stpSelParametrosBindingSource.DataMember = "stpSelParametros";
            this.stpSelParametrosBindingSource.DataSource = this.dbSAICBPOActualizacionesIMSSDataSet1;
            // 
            // dbSAICBPOActualizacionesIMSSDataSet1
            // 
            this.dbSAICBPOActualizacionesIMSSDataSet1.DataSetName = "dbSAICBPOActualizacionesIMSSDataSet";
            this.dbSAICBPOActualizacionesIMSSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewParametros
            // 
            this.gridViewParametros.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdParametro,
            this.colDescParametro,
            this.colValorParametro,
            this.gridColumnDescripcion});
            this.gridViewParametros.GridControl = this.gridControlParametros;
            this.gridViewParametros.Name = "gridViewParametros";
            this.gridViewParametros.OptionsBehavior.Editable = false;
            this.gridViewParametros.OptionsBehavior.ReadOnly = true;
            this.gridViewParametros.OptionsView.ColumnAutoWidth = false;
            this.gridViewParametros.OptionsView.ShowAutoFilterRow = true;
            this.gridViewParametros.OptionsView.ShowGroupPanel = false;
            // 
            // colIdParametro
            // 
            this.colIdParametro.FieldName = "IdParametro";
            this.colIdParametro.Name = "colIdParametro";
            this.colIdParametro.Visible = true;
            this.colIdParametro.VisibleIndex = 0;
            this.colIdParametro.Width = 80;
            // 
            // colDescParametro
            // 
            this.colDescParametro.FieldName = "DescParametro";
            this.colDescParametro.Name = "colDescParametro";
            this.colDescParametro.Visible = true;
            this.colDescParametro.VisibleIndex = 1;
            this.colDescParametro.Width = 225;
            // 
            // colValorParametro
            // 
            this.colValorParametro.FieldName = "ValorParametro";
            this.colValorParametro.Name = "colValorParametro";
            this.colValorParametro.Visible = true;
            this.colValorParametro.VisibleIndex = 2;
            this.colValorParametro.Width = 268;
            // 
            // gridColumnDescripcion
            // 
            this.gridColumnDescripcion.Caption = "Descripcion";
            this.gridColumnDescripcion.FieldName = "DescCompleta";
            this.gridColumnDescripcion.Name = "gridColumnDescripcion";
            this.gridColumnDescripcion.Visible = true;
            this.gridColumnDescripcion.VisibleIndex = 3;
            this.gridColumnDescripcion.Width = 819;
            // 
            // stpSelParametrosTableAdapter1
            // 
            this.stpSelParametrosTableAdapter1.ClearBeforeFill = true;
            // 
            // XtraParametros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 410);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "XtraParametros";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parametros";
            this.Load += new System.EventHandler(this.XtraParametros_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtParametro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorParametro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdParametro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlParametros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelParametrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOActualizacionesIMSSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewParametros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraGrid.GridControl gridControlParametros;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewParametros;
        private dbSAICBPOActualizacionesIMSSDataSet dbSAICBPOActualizacionesIMSSDataSet1;
        private dbSAICBPOActualizacionesIMSSDataSetTableAdapters.ActualizacionesIMSSTableAdapter actualizacionesIMSSTableAdapter1;
        private dbSAICBPOActualizacionesIMSSDataSetTableAdapters.stpSelParametrosTableAdapter stpSelParametrosTableAdapter1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnActualizar;
        private DevExpress.XtraEditors.TextEdit txtParametro;
        private DevExpress.XtraEditors.TextEdit txtValorParametro;
        private DevExpress.XtraEditors.TextEdit txtIdParametro;
        private System.Windows.Forms.BindingSource stpSelParametrosBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdParametro;
        private DevExpress.XtraGrid.Columns.GridColumn colDescParametro;
        private DevExpress.XtraGrid.Columns.GridColumn colValorParametro;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDescripcion;
        private System.Windows.Forms.RichTextBox rTexBoxDescripcion;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.Panel panel1;
    }
}