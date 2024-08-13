namespace winAppSAIC.Tesoreria
{
    partial class frmxBuscarCheque
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAceptar = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.gvFoliosCheques = new DevExpress.XtraGrid.GridControl();
            this.stpSelRelacionChequesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPOTesoreriaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPOTesoreriaDataSet = new winAppSAIC.Tesoreria.dbSAICBPOTesoreriaDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdTransaccionBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCuentaBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaTransaccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoTransaccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdBeneficiarioTransaccionBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreBeneficiarioTransaccionBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMontoConLetra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMoneda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescMoneda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCategoriaTransaccionBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSubCategoriaTransaccionBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOtroConcepto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservaciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAnoTransaccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstatusCancelado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescEstatusCancelado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.stpSelRelacionChequesTableAdapter = new winAppSAIC.Tesoreria.dbSAICBPOTesoreriaDataSetTableAdapters.stpSelRelacionChequesTableAdapter();
            this.colMontoTransaccionRetiro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvFoliosCheques)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelRelacionChequesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOTesoreriaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOTesoreriaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAceptar,
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(694, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = global::winAppSAIC.Properties.Resources.SelectAll16x16;
            this.btnAceptar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(68, 22);
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.gvFoliosCheques_DoubleClick);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::winAppSAIC.Properties.Resources.Salir24x24;
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(49, 22);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // gvFoliosCheques
            // 
            this.gvFoliosCheques.DataSource = this.stpSelRelacionChequesBindingSource;
            this.gvFoliosCheques.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvFoliosCheques.Location = new System.Drawing.Point(0, 25);
            this.gvFoliosCheques.MainView = this.gridView1;
            this.gvFoliosCheques.Name = "gvFoliosCheques";
            this.gvFoliosCheques.Size = new System.Drawing.Size(694, 247);
            this.gvFoliosCheques.TabIndex = 2;
            this.gvFoliosCheques.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gvFoliosCheques.DoubleClick += new System.EventHandler(this.gvFoliosCheques_DoubleClick);
            // 
            // stpSelRelacionChequesBindingSource
            // 
            this.stpSelRelacionChequesBindingSource.DataMember = "stpSelRelacionCheques";
            this.stpSelRelacionChequesBindingSource.DataSource = this.dbSAICBPOTesoreriaDataSetBindingSource;
            // 
            // dbSAICBPOTesoreriaDataSetBindingSource
            // 
            this.dbSAICBPOTesoreriaDataSetBindingSource.DataSource = this.dbSAICBPOTesoreriaDataSet;
            this.dbSAICBPOTesoreriaDataSetBindingSource.Position = 0;
            // 
            // dbSAICBPOTesoreriaDataSet
            // 
            this.dbSAICBPOTesoreriaDataSet.DataSetName = "dbSAICBPOTesoreriaDataSet";
            this.dbSAICBPOTesoreriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdTransaccionBanco,
            this.colIdCuentaBanco,
            this.colFechaTransaccion,
            this.colNoTransaccion,
            this.colIdBeneficiarioTransaccionBanco,
            this.colNombreBeneficiarioTransaccionBanco,
            this.colMontoConLetra,
            this.colIdMoneda,
            this.colDescMoneda,
            this.colIdCategoriaTransaccionBanco,
            this.colIdSubCategoriaTransaccionBanco,
            this.colOtroConcepto,
            this.colObservaciones,
            this.colAnoTransaccion,
            this.colEstatusCancelado,
            this.colDescEstatusCancelado,
            this.colMontoTransaccionRetiro});
            this.gridView1.GridControl = this.gvFoliosCheques;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIdTransaccionBanco
            // 
            this.colIdTransaccionBanco.AppearanceCell.Options.UseTextOptions = true;
            this.colIdTransaccionBanco.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIdTransaccionBanco.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdTransaccionBanco.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIdTransaccionBanco.Caption = "Folio Mov.";
            this.colIdTransaccionBanco.FieldName = "IdTransaccionBanco";
            this.colIdTransaccionBanco.Name = "colIdTransaccionBanco";
            this.colIdTransaccionBanco.OptionsColumn.AllowEdit = false;
            this.colIdTransaccionBanco.OptionsColumn.FixedWidth = true;
            this.colIdTransaccionBanco.OptionsColumn.ReadOnly = true;
            this.colIdTransaccionBanco.Visible = true;
            this.colIdTransaccionBanco.VisibleIndex = 0;
            this.colIdTransaccionBanco.Width = 50;
            // 
            // colIdCuentaBanco
            // 
            this.colIdCuentaBanco.FieldName = "IdCuentaBanco";
            this.colIdCuentaBanco.Name = "colIdCuentaBanco";
            this.colIdCuentaBanco.OptionsColumn.AllowEdit = false;
            // 
            // colFechaTransaccion
            // 
            this.colFechaTransaccion.AppearanceCell.Options.UseTextOptions = true;
            this.colFechaTransaccion.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFechaTransaccion.AppearanceHeader.Options.UseTextOptions = true;
            this.colFechaTransaccion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFechaTransaccion.Caption = "Fecha";
            this.colFechaTransaccion.FieldName = "FechaTransaccion";
            this.colFechaTransaccion.Name = "colFechaTransaccion";
            this.colFechaTransaccion.OptionsColumn.AllowEdit = false;
            this.colFechaTransaccion.OptionsColumn.FixedWidth = true;
            this.colFechaTransaccion.Visible = true;
            this.colFechaTransaccion.VisibleIndex = 1;
            this.colFechaTransaccion.Width = 50;
            // 
            // colNoTransaccion
            // 
            this.colNoTransaccion.AppearanceCell.Options.UseTextOptions = true;
            this.colNoTransaccion.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNoTransaccion.AppearanceHeader.Options.UseTextOptions = true;
            this.colNoTransaccion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNoTransaccion.Caption = "No. Cheque";
            this.colNoTransaccion.FieldName = "NoTransaccion";
            this.colNoTransaccion.Name = "colNoTransaccion";
            this.colNoTransaccion.OptionsColumn.AllowEdit = false;
            this.colNoTransaccion.OptionsColumn.FixedWidth = true;
            this.colNoTransaccion.Visible = true;
            this.colNoTransaccion.VisibleIndex = 2;
            this.colNoTransaccion.Width = 50;
            // 
            // colIdBeneficiarioTransaccionBanco
            // 
            this.colIdBeneficiarioTransaccionBanco.FieldName = "IdBeneficiarioTransaccionBanco";
            this.colIdBeneficiarioTransaccionBanco.Name = "colIdBeneficiarioTransaccionBanco";
            // 
            // colNombreBeneficiarioTransaccionBanco
            // 
            this.colNombreBeneficiarioTransaccionBanco.Caption = "Beneficiario";
            this.colNombreBeneficiarioTransaccionBanco.FieldName = "NombreBeneficiarioTransaccionBanco";
            this.colNombreBeneficiarioTransaccionBanco.Name = "colNombreBeneficiarioTransaccionBanco";
            this.colNombreBeneficiarioTransaccionBanco.OptionsColumn.AllowEdit = false;
            this.colNombreBeneficiarioTransaccionBanco.OptionsColumn.FixedWidth = true;
            this.colNombreBeneficiarioTransaccionBanco.Visible = true;
            this.colNombreBeneficiarioTransaccionBanco.VisibleIndex = 3;
            this.colNombreBeneficiarioTransaccionBanco.Width = 150;
            // 
            // colMontoConLetra
            // 
            this.colMontoConLetra.FieldName = "MontoConLetra";
            this.colMontoConLetra.Name = "colMontoConLetra";
            // 
            // colIdMoneda
            // 
            this.colIdMoneda.FieldName = "IdMoneda";
            this.colIdMoneda.Name = "colIdMoneda";
            this.colIdMoneda.OptionsColumn.AllowEdit = false;
            // 
            // colDescMoneda
            // 
            this.colDescMoneda.AppearanceCell.Options.UseTextOptions = true;
            this.colDescMoneda.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDescMoneda.AppearanceHeader.Options.UseTextOptions = true;
            this.colDescMoneda.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDescMoneda.Caption = "Moneda";
            this.colDescMoneda.FieldName = "DescMoneda";
            this.colDescMoneda.Name = "colDescMoneda";
            this.colDescMoneda.OptionsColumn.AllowEdit = false;
            this.colDescMoneda.OptionsColumn.FixedWidth = true;
            this.colDescMoneda.Visible = true;
            this.colDescMoneda.VisibleIndex = 5;
            this.colDescMoneda.Width = 50;
            // 
            // colIdCategoriaTransaccionBanco
            // 
            this.colIdCategoriaTransaccionBanco.FieldName = "IdCategoriaTransaccionBanco";
            this.colIdCategoriaTransaccionBanco.Name = "colIdCategoriaTransaccionBanco";
            // 
            // colIdSubCategoriaTransaccionBanco
            // 
            this.colIdSubCategoriaTransaccionBanco.FieldName = "IdSubCategoriaTransaccionBanco";
            this.colIdSubCategoriaTransaccionBanco.Name = "colIdSubCategoriaTransaccionBanco";
            // 
            // colOtroConcepto
            // 
            this.colOtroConcepto.FieldName = "OtroConcepto";
            this.colOtroConcepto.Name = "colOtroConcepto";
            // 
            // colObservaciones
            // 
            this.colObservaciones.FieldName = "Observaciones";
            this.colObservaciones.Name = "colObservaciones";
            // 
            // colAnoTransaccion
            // 
            this.colAnoTransaccion.FieldName = "AnoTransaccion";
            this.colAnoTransaccion.Name = "colAnoTransaccion";
            this.colAnoTransaccion.OptionsColumn.AllowEdit = false;
            this.colAnoTransaccion.OptionsColumn.ReadOnly = true;
            // 
            // colEstatusCancelado
            // 
            this.colEstatusCancelado.FieldName = "EstatusCancelado";
            this.colEstatusCancelado.Name = "colEstatusCancelado";
            // 
            // colDescEstatusCancelado
            // 
            this.colDescEstatusCancelado.FieldName = "DescEstatusCancelado";
            this.colDescEstatusCancelado.Name = "colDescEstatusCancelado";
            // 
            // stpSelRelacionChequesTableAdapter
            // 
            this.stpSelRelacionChequesTableAdapter.ClearBeforeFill = true;
            // 
            // colMontoTransaccionRetiro
            // 
            this.colMontoTransaccionRetiro.Caption = "Importe";
            this.colMontoTransaccionRetiro.DisplayFormat.FormatString = "C2";
            this.colMontoTransaccionRetiro.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMontoTransaccionRetiro.FieldName = "MontoTransaccionRetiro";
            this.colMontoTransaccionRetiro.Name = "colMontoTransaccionRetiro";
            this.colMontoTransaccionRetiro.OptionsColumn.AllowEdit = false;
            this.colMontoTransaccionRetiro.OptionsColumn.FixedWidth = true;
            this.colMontoTransaccionRetiro.Visible = true;
            this.colMontoTransaccionRetiro.VisibleIndex = 4;
            // 
            // frmxBuscarCheque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 272);
            this.ControlBox = false;
            this.Controls.Add(this.gvFoliosCheques);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmxBuscarCheque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Cheque";
            this.Load += new System.EventHandler(this.frmxBuscarCheque_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvFoliosCheques)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelRelacionChequesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOTesoreriaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOTesoreriaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.ToolStripButton btnAceptar;
        private DevExpress.XtraGrid.GridControl gvFoliosCheques;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource stpSelRelacionChequesBindingSource;
        private System.Windows.Forms.BindingSource dbSAICBPOTesoreriaDataSetBindingSource;
        private dbSAICBPOTesoreriaDataSet dbSAICBPOTesoreriaDataSet;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTransaccionBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCuentaBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaTransaccion;
        private DevExpress.XtraGrid.Columns.GridColumn colNoTransaccion;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreBeneficiarioTransaccionBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMoneda;
        private DevExpress.XtraGrid.Columns.GridColumn colDescMoneda;
        private DevExpress.XtraGrid.Columns.GridColumn colAnoTransaccion;
        private dbSAICBPOTesoreriaDataSetTableAdapters.stpSelRelacionChequesTableAdapter stpSelRelacionChequesTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBeneficiarioTransaccionBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colMontoConLetra;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCategoriaTransaccionBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSubCategoriaTransaccionBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colOtroConcepto;
        private DevExpress.XtraGrid.Columns.GridColumn colObservaciones;
        private DevExpress.XtraGrid.Columns.GridColumn colEstatusCancelado;
        private DevExpress.XtraGrid.Columns.GridColumn colDescEstatusCancelado;
        private DevExpress.XtraGrid.Columns.GridColumn colMontoTransaccionRetiro;
    }
}