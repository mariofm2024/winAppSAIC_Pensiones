namespace winAppSAIC.Contablidad
{
    partial class frmxCierreNominaContable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmxCierreNominaContable));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cboTipoPoliza = new DevExpress.XtraEditors.GridLookUpEdit();
            this.stpSelTipoPolizaBindingSource = new System.Windows.Forms.BindingSource();
            this.dbSAICBPODataSet = new winAppSAIC.dbSAICBPODataSet();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdTipoPoliza = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescTipoPoliza = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtFolioPoliza = new DevExpress.XtraEditors.TextEdit();
            this.cboFechaPoliza = new DevExpress.XtraEditors.DateEdit();
            this.txtImportePoliza = new DevExpress.XtraEditors.TextEdit();
            this.txtObservaciones = new DevExpress.XtraEditors.MemoEdit();
            this.btnAceptar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.lblMesPago = new DevExpress.XtraEditors.LabelControl();
            this.lblAnoPago = new DevExpress.XtraEditors.LabelControl();
            this.stpSelTipoPolizaTableAdapter = new winAppSAIC.dbSAICBPODataSetTableAdapters.stpSelTipoPolizaTableAdapter();
            this.cboMesPago = new DevExpress.XtraEditors.GridLookUpEdit();
            this.stpSelMesBindingSource = new System.Windows.Forms.BindingSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdMes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescMes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.stpSelMesTableAdapter = new winAppSAIC.dbSAICBPODataSetTableAdapters.stpSelMesTableAdapter();
            this.spAnoPago = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTipoPoliza.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelTipoPolizaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFolioPoliza.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFechaPoliza.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFechaPoliza.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImportePoliza.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservaciones.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMesPago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelMesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spAnoPago.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 25);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tipo de Póliza";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(14, 51);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(52, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Folio Póliza";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(14, 77);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(59, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Fecha Póliza";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(14, 104);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(68, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Importe Póliza";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(14, 177);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(71, 13);
            this.labelControl5.TabIndex = 12;
            this.labelControl5.Text = "Observaciones";
            // 
            // cboTipoPoliza
            // 
            this.cboTipoPoliza.EditValue = "";
            this.cboTipoPoliza.Location = new System.Drawing.Point(99, 21);
            this.cboTipoPoliza.Name = "cboTipoPoliza";
            this.cboTipoPoliza.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTipoPoliza.Properties.DataSource = this.stpSelTipoPolizaBindingSource;
            this.cboTipoPoliza.Properties.DisplayMember = "DescTipoPoliza";
            this.cboTipoPoliza.Properties.ValueMember = "IdTipoPoliza";
            this.cboTipoPoliza.Properties.View = this.gridLookUpEdit1View;
            this.cboTipoPoliza.Size = new System.Drawing.Size(126, 20);
            this.cboTipoPoliza.TabIndex = 1;
            // 
            // stpSelTipoPolizaBindingSource
            // 
            this.stpSelTipoPolizaBindingSource.DataMember = "stpSelTipoPoliza";
            this.stpSelTipoPolizaBindingSource.DataSource = this.dbSAICBPODataSet;
            // 
            // dbSAICBPODataSet
            // 
            this.dbSAICBPODataSet.DataSetName = "dbSAICBPODataSet";
            this.dbSAICBPODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // txtFolioPoliza
            // 
            this.txtFolioPoliza.Location = new System.Drawing.Point(99, 47);
            this.txtFolioPoliza.Name = "txtFolioPoliza";
            this.txtFolioPoliza.Size = new System.Drawing.Size(126, 20);
            this.txtFolioPoliza.TabIndex = 3;
            // 
            // cboFechaPoliza
            // 
            this.cboFechaPoliza.EditValue = null;
            this.cboFechaPoliza.Location = new System.Drawing.Point(99, 73);
            this.cboFechaPoliza.Name = "cboFechaPoliza";
            this.cboFechaPoliza.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboFechaPoliza.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cboFechaPoliza.Size = new System.Drawing.Size(126, 20);
            this.cboFechaPoliza.TabIndex = 5;
            // 
            // txtImportePoliza
            // 
            this.txtImportePoliza.Location = new System.Drawing.Point(99, 100);
            this.txtImportePoliza.Name = "txtImportePoliza";
            this.txtImportePoliza.Properties.DisplayFormat.FormatString = "C2";
            this.txtImportePoliza.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtImportePoliza.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtImportePoliza.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtImportePoliza.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtImportePoliza.Size = new System.Drawing.Size(126, 20);
            this.txtImportePoliza.TabIndex = 7;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(99, 179);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservaciones.Properties.MaxLength = 1024;
            this.txtObservaciones.Size = new System.Drawing.Size(289, 88);
            this.txtObservaciones.TabIndex = 13;
            this.txtObservaciones.UseOptimizedRendering = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(232, 277);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(313, 277);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            // 
            // lblMesPago
            // 
            this.lblMesPago.Location = new System.Drawing.Point(14, 131);
            this.lblMesPago.Name = "lblMesPago";
            this.lblMesPago.Size = new System.Drawing.Size(46, 13);
            this.lblMesPago.TabIndex = 8;
            this.lblMesPago.Text = "Mes Pago";
            // 
            // lblAnoPago
            // 
            this.lblAnoPago.Location = new System.Drawing.Point(14, 157);
            this.lblAnoPago.Name = "lblAnoPago";
            this.lblAnoPago.Size = new System.Drawing.Size(46, 13);
            this.lblAnoPago.TabIndex = 10;
            this.lblAnoPago.Text = "Año Pago";
            // 
            // stpSelTipoPolizaTableAdapter
            // 
            this.stpSelTipoPolizaTableAdapter.ClearBeforeFill = true;
            // 
            // cboMesPago
            // 
            this.cboMesPago.EditValue = "";
            this.cboMesPago.Location = new System.Drawing.Point(99, 127);
            this.cboMesPago.Name = "cboMesPago";
            this.cboMesPago.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboMesPago.Properties.DataSource = this.stpSelMesBindingSource;
            this.cboMesPago.Properties.DisplayMember = "DescMes";
            this.cboMesPago.Properties.ValueMember = "IdMes";
            this.cboMesPago.Properties.View = this.gridView1;
            this.cboMesPago.Size = new System.Drawing.Size(126, 20);
            this.cboMesPago.TabIndex = 9;
            // 
            // stpSelMesBindingSource
            // 
            this.stpSelMesBindingSource.DataMember = "stpSelMes";
            this.stpSelMesBindingSource.DataSource = this.dbSAICBPODataSet;
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
            // stpSelMesTableAdapter
            // 
            this.stpSelMesTableAdapter.ClearBeforeFill = true;
            // 
            // spAnoPago
            // 
            this.spAnoPago.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spAnoPago.Location = new System.Drawing.Point(99, 153);
            this.spAnoPago.Name = "spAnoPago";
            this.spAnoPago.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spAnoPago.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spAnoPago.Size = new System.Drawing.Size(77, 20);
            this.spAnoPago.TabIndex = 11;
            // 
            // frmxCierreNominaContable
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(404, 312);
            this.ControlBox = false;
            this.Controls.Add(this.spAnoPago);
            this.Controls.Add(this.cboMesPago);
            this.Controls.Add(this.lblAnoPago);
            this.Controls.Add(this.lblMesPago);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.txtImportePoliza);
            this.Controls.Add(this.cboFechaPoliza);
            this.Controls.Add(this.txtFolioPoliza);
            this.Controls.Add(this.cboTipoPoliza);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmxCierreNominaContable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cierre de Nómina Contable";
            this.Load += new System.EventHandler(this.frmxCierreNominaContable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cboTipoPoliza.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelTipoPolizaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFolioPoliza.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFechaPoliza.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFechaPoliza.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImportePoliza.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservaciones.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMesPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelMesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spAnoPago.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private dbSAICBPODataSet dbSAICBPODataSet;
        private System.Windows.Forms.BindingSource stpSelTipoPolizaBindingSource;
        private dbSAICBPODataSetTableAdapters.stpSelTipoPolizaTableAdapter stpSelTipoPolizaTableAdapter;
        private DevExpress.XtraEditors.SimpleButton btnAceptar;
        public DevExpress.XtraEditors.GridLookUpEdit cboTipoPoliza;
        public DevExpress.XtraEditors.TextEdit txtFolioPoliza;
        public DevExpress.XtraEditors.DateEdit cboFechaPoliza;
        public DevExpress.XtraEditors.TextEdit txtImportePoliza;
        public DevExpress.XtraEditors.MemoEdit txtObservaciones;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoPoliza;
        private DevExpress.XtraGrid.Columns.GridColumn colDescTipoPoliza;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.LabelControl lblMesPago;
        private DevExpress.XtraEditors.LabelControl lblAnoPago;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource stpSelMesBindingSource;
        private dbSAICBPODataSetTableAdapters.stpSelMesTableAdapter stpSelMesTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMes;
        private DevExpress.XtraGrid.Columns.GridColumn colDescMes;
        public DevExpress.XtraEditors.GridLookUpEdit cboMesPago;
        public DevExpress.XtraEditors.SpinEdit spAnoPago;
    }
}