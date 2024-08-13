namespace winAppSAIC.Facturas
{
    partial class frmCierreControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCierreControl));
            this.spAnoPago = new DevExpress.XtraEditors.SpinEdit();
            this.cboMesPago = new DevExpress.XtraEditors.GridLookUpEdit();
            this.stpSelMesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPODataSet = new winAppSAIC.dbSAICBPODataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdMes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescMes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblAnoPago = new DevExpress.XtraEditors.LabelControl();
            this.lblMesPago = new DevExpress.XtraEditors.LabelControl();
            this.txtObservaciones = new DevExpress.XtraEditors.MemoEdit();
            this.stpSelTipoPolizaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.stpSelTipoPolizaTableAdapter = new winAppSAIC.dbSAICBPODataSetTableAdapters.stpSelTipoPolizaTableAdapter();
            this.stpSelMesTableAdapter = new winAppSAIC.dbSAICBPODataSetTableAdapters.stpSelMesTableAdapter();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.spSoloRespuesta1 = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.spSoloRespuesta();
            ((System.ComponentModel.ISupportInitialize)(this.spAnoPago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMesPago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelMesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservaciones.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelTipoPolizaBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // spAnoPago
            // 
            this.spAnoPago.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spAnoPago.Location = new System.Drawing.Point(317, 41);
            this.spAnoPago.Name = "spAnoPago";
            this.spAnoPago.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spAnoPago.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spAnoPago.Size = new System.Drawing.Size(77, 20);
            this.spAnoPago.TabIndex = 27;
            // 
            // cboMesPago
            // 
            this.cboMesPago.EditValue = "";
            this.cboMesPago.Location = new System.Drawing.Point(93, 41);
            this.cboMesPago.Name = "cboMesPago";
            this.cboMesPago.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboMesPago.Properties.DataSource = this.stpSelMesBindingSource;
            this.cboMesPago.Properties.DisplayMember = "DescMes";
            this.cboMesPago.Properties.ValueMember = "IdMes";
            this.cboMesPago.Properties.View = this.gridView1;
            this.cboMesPago.Size = new System.Drawing.Size(126, 20);
            this.cboMesPago.TabIndex = 25;
            // 
            // stpSelMesBindingSource
            // 
            this.stpSelMesBindingSource.DataMember = "stpSelMes";
            this.stpSelMesBindingSource.DataSource = this.dbSAICBPODataSet;
            // 
            // dbSAICBPODataSet
            // 
            this.dbSAICBPODataSet.DataSetName = "dbSAICBPODataSet";
            this.dbSAICBPODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdMes,
            this.colDescMes});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
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
            // lblAnoPago
            // 
            this.lblAnoPago.Location = new System.Drawing.Point(256, 44);
            this.lblAnoPago.Name = "lblAnoPago";
            this.lblAnoPago.Size = new System.Drawing.Size(55, 13);
            this.lblAnoPago.TabIndex = 26;
            this.lblAnoPago.Text = "Año Cierre:";
            // 
            // lblMesPago
            // 
            this.lblMesPago.Location = new System.Drawing.Point(28, 44);
            this.lblMesPago.Name = "lblMesPago";
            this.lblMesPago.Size = new System.Drawing.Size(55, 13);
            this.lblMesPago.TabIndex = 24;
            this.lblMesPago.Text = "Mes Cierre:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(93, 80);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservaciones.Properties.MaxLength = 200;
            this.txtObservaciones.Size = new System.Drawing.Size(301, 58);
            this.txtObservaciones.TabIndex = 29;
            // 
            // stpSelTipoPolizaBindingSource
            // 
            this.stpSelTipoPolizaBindingSource.DataMember = "stpSelTipoPoliza";
            this.stpSelTipoPolizaBindingSource.DataSource = this.dbSAICBPODataSet;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(8, 78);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(75, 13);
            this.labelControl5.TabIndex = 28;
            this.labelControl5.Text = "Observaciones:";
            // 
            // stpSelTipoPolizaTableAdapter
            // 
            this.stpSelTipoPolizaTableAdapter.ClearBeforeFill = true;
            // 
            // stpSelMesTableAdapter
            // 
            this.stpSelMesTableAdapter.ClearBeforeFill = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.btnCancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(409, 25);
            this.toolStrip1.TabIndex = 30;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Black;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(49, 22);
            this.toolStripButton1.Text = "Salir";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::winAppSAIC.Properties.Resources.cerrar;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(102, 22);
            this.btnCancelar.Text = "Cerrar Control";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmCierreControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 160);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.spAnoPago);
            this.Controls.Add(this.cboMesPago);
            this.Controls.Add(this.lblAnoPago);
            this.Controls.Add(this.lblMesPago);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.labelControl5);
            this.Name = "frmCierreControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cierre de Control de Operaciones";
            this.Load += new System.EventHandler(this.frmCierreControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spAnoPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMesPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelMesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservaciones.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelTipoPolizaBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraEditors.SpinEdit spAnoPago;
        public DevExpress.XtraEditors.GridLookUpEdit cboMesPago;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMes;
        private DevExpress.XtraGrid.Columns.GridColumn colDescMes;
        private DevExpress.XtraEditors.LabelControl lblAnoPago;
        private DevExpress.XtraEditors.LabelControl lblMesPago;
        public DevExpress.XtraEditors.MemoEdit txtObservaciones;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private dbSAICBPODataSet dbSAICBPODataSet;
        private System.Windows.Forms.BindingSource stpSelTipoPolizaBindingSource;
        private dbSAICBPODataSetTableAdapters.stpSelTipoPolizaTableAdapter stpSelTipoPolizaTableAdapter;
        private System.Windows.Forms.BindingSource stpSelMesBindingSource;
        private dbSAICBPODataSetTableAdapters.stpSelMesTableAdapter stpSelMesTableAdapter;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private dbSAICBPOFacturaTableAdapters.spSoloRespuesta spSoloRespuesta1;
    }
}