namespace winAppSAIC.Facturas
{
    partial class frmContabilizarFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContabilizarFactura));
            this.spAnoPago = new DevExpress.XtraEditors.SpinEdit();
            this.cboMesPago = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdMes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescMes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblAnoPago = new DevExpress.XtraEditors.LabelControl();
            this.lblMesPago = new DevExpress.XtraEditors.LabelControl();
            this.txtObservaciones = new DevExpress.XtraEditors.MemoEdit();
            this.cboFechaPoliza = new DevExpress.XtraEditors.DateEdit();
            this.txtFolioPoliza = new DevExpress.XtraEditors.TextEdit();
            this.cboTipoPoliza = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdTipoPoliza = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescTipoPoliza = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dbSAICBPODataSet = new winAppSAIC.dbSAICBPODataSet();
            this.stpSelTipoPolizaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stpSelTipoPolizaTableAdapter = new winAppSAIC.dbSAICBPODataSetTableAdapters.stpSelTipoPolizaTableAdapter();
            this.stpSelMesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stpSelMesTableAdapter = new winAppSAIC.dbSAICBPODataSetTableAdapters.stpSelMesTableAdapter();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.spSoloRespuesta1 = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.spSoloRespuesta();
            this.txtImportePoliza = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.spAnoPago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMesPago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservaciones.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFechaPoliza.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFechaPoliza.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFolioPoliza.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTipoPoliza.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelTipoPolizaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelMesBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtImportePoliza.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // spAnoPago
            // 
            this.spAnoPago.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spAnoPago.Location = new System.Drawing.Point(105, 165);
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
            this.cboMesPago.Location = new System.Drawing.Point(105, 139);
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
            this.lblAnoPago.Location = new System.Drawing.Point(20, 169);
            this.lblAnoPago.Name = "lblAnoPago";
            this.lblAnoPago.Size = new System.Drawing.Size(46, 13);
            this.lblAnoPago.TabIndex = 26;
            this.lblAnoPago.Text = "Año Pago";
            // 
            // lblMesPago
            // 
            this.lblMesPago.Location = new System.Drawing.Point(20, 143);
            this.lblMesPago.Name = "lblMesPago";
            this.lblMesPago.Size = new System.Drawing.Size(46, 13);
            this.lblMesPago.TabIndex = 24;
            this.lblMesPago.Text = "Mes Pago";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(105, 191);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservaciones.Properties.MaxLength = 1024;
            this.txtObservaciones.Size = new System.Drawing.Size(289, 88);
            this.txtObservaciones.TabIndex = 29;
            // 
            // cboFechaPoliza
            // 
            this.cboFechaPoliza.EditValue = null;
            this.cboFechaPoliza.Location = new System.Drawing.Point(105, 85);
            this.cboFechaPoliza.Name = "cboFechaPoliza";
            this.cboFechaPoliza.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboFechaPoliza.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cboFechaPoliza.Size = new System.Drawing.Size(126, 20);
            this.cboFechaPoliza.TabIndex = 21;
            // 
            // txtFolioPoliza
            // 
            this.txtFolioPoliza.Location = new System.Drawing.Point(105, 59);
            this.txtFolioPoliza.Name = "txtFolioPoliza";
            this.txtFolioPoliza.Size = new System.Drawing.Size(126, 20);
            this.txtFolioPoliza.TabIndex = 19;
            // 
            // cboTipoPoliza
            // 
            this.cboTipoPoliza.EditValue = "";
            this.cboTipoPoliza.Location = new System.Drawing.Point(105, 33);
            this.cboTipoPoliza.Name = "cboTipoPoliza";
            this.cboTipoPoliza.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTipoPoliza.Properties.DataSource = this.stpSelTipoPolizaBindingSource;
            this.cboTipoPoliza.Properties.DisplayMember = "DescTipoPoliza";
            this.cboTipoPoliza.Properties.ValueMember = "IdTipoPoliza";
            this.cboTipoPoliza.Properties.View = this.gridLookUpEdit1View;
            this.cboTipoPoliza.Size = new System.Drawing.Size(126, 20);
            this.cboTipoPoliza.TabIndex = 17;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdTipoPoliza,
            this.colDescTipoPoliza});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdTipoPoliza
            // 
            this.colIdTipoPoliza.Caption = "Clave Póliza";
            this.colIdTipoPoliza.FieldName = "IdTipoPoliza";
            this.colIdTipoPoliza.Name = "colIdTipoPoliza";
            this.colIdTipoPoliza.Visible = true;
            this.colIdTipoPoliza.VisibleIndex = 0;
            // 
            // colDescTipoPoliza
            // 
            this.colDescTipoPoliza.Caption = "Descripción Póliza";
            this.colDescTipoPoliza.FieldName = "DescTipoPoliza";
            this.colDescTipoPoliza.Name = "colDescTipoPoliza";
            this.colDescTipoPoliza.Visible = true;
            this.colDescTipoPoliza.VisibleIndex = 1;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(20, 189);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(71, 13);
            this.labelControl5.TabIndex = 28;
            this.labelControl5.Text = "Observaciones";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(20, 116);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(68, 13);
            this.labelControl4.TabIndex = 22;
            this.labelControl4.Text = "Importe Póliza";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(20, 89);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(59, 13);
            this.labelControl3.TabIndex = 20;
            this.labelControl3.Text = "Fecha Póliza";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(20, 63);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(52, 13);
            this.labelControl2.TabIndex = 18;
            this.labelControl2.Text = "Folio Póliza";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(20, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 13);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "Tipo de Póliza";
            // 
            // dbSAICBPODataSet
            // 
            this.dbSAICBPODataSet.DataSetName = "dbSAICBPODataSet";
            this.dbSAICBPODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stpSelTipoPolizaBindingSource
            // 
            this.stpSelTipoPolizaBindingSource.DataMember = "stpSelTipoPoliza";
            this.stpSelTipoPolizaBindingSource.DataSource = this.dbSAICBPODataSet;
            // 
            // stpSelTipoPolizaTableAdapter
            // 
            this.stpSelTipoPolizaTableAdapter.ClearBeforeFill = true;
            // 
            // stpSelMesBindingSource
            // 
            this.stpSelMesBindingSource.DataMember = "stpSelMes";
            this.stpSelMesBindingSource.DataSource = this.dbSAICBPODataSet;
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
            this.btnCancelar.Image = global::winAppSAIC.Properties.Resources.EliminarNomina32x32;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 22);
            this.btnCancelar.Text = "Contabilizar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtImportePoliza
            // 
            this.txtImportePoliza.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtImportePoliza.Location = new System.Drawing.Point(105, 113);
            this.txtImportePoliza.Name = "txtImportePoliza";
            this.txtImportePoliza.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtImportePoliza.Properties.DisplayFormat.FormatString = "C2";
            this.txtImportePoliza.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtImportePoliza.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtImportePoliza.Size = new System.Drawing.Size(126, 20);
            this.txtImportePoliza.TabIndex = 31;
            this.txtImportePoliza.Tag = "Total Deposito";
            // 
            // frmContabilizarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 290);
            this.ControlBox = false;
            this.Controls.Add(this.txtImportePoliza);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.spAnoPago);
            this.Controls.Add(this.cboMesPago);
            this.Controls.Add(this.lblAnoPago);
            this.Controls.Add(this.lblMesPago);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.cboFechaPoliza);
            this.Controls.Add(this.txtFolioPoliza);
            this.Controls.Add(this.cboTipoPoliza);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmContabilizarFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cierre de Factura(s) Contable";
            this.Load += new System.EventHandler(this.frmContabilizarFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spAnoPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMesPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservaciones.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFechaPoliza.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFechaPoliza.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFolioPoliza.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTipoPoliza.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelTipoPolizaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelMesBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtImportePoliza.Properties)).EndInit();
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
        public DevExpress.XtraEditors.DateEdit cboFechaPoliza;
        public DevExpress.XtraEditors.TextEdit txtFolioPoliza;
        public DevExpress.XtraEditors.GridLookUpEdit cboTipoPoliza;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoPoliza;
        private DevExpress.XtraGrid.Columns.GridColumn colDescTipoPoliza;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private dbSAICBPODataSet dbSAICBPODataSet;
        private System.Windows.Forms.BindingSource stpSelTipoPolizaBindingSource;
        private dbSAICBPODataSetTableAdapters.stpSelTipoPolizaTableAdapter stpSelTipoPolizaTableAdapter;
        private System.Windows.Forms.BindingSource stpSelMesBindingSource;
        private dbSAICBPODataSetTableAdapters.stpSelMesTableAdapter stpSelMesTableAdapter;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private dbSAICBPOFacturaTableAdapters.spSoloRespuesta spSoloRespuesta1;
        private DevExpress.XtraEditors.SpinEdit txtImportePoliza;
    }
}