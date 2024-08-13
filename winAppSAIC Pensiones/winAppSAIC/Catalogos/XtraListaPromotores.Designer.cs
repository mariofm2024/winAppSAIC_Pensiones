namespace winAppSAIC.Catalogos
{
    partial class XtraListaPromotores
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
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSAlir = new System.Windows.Forms.ToolStripButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.stpSelClientePromotoresDetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAIC_Catalogos = new winAppSAIC.Catalogos.dbSAIC_Catalogos();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdRelClientePromotor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdPromotor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreCompletoPromotor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComision = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservaciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCorreoElectronico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.stpSelClientePromotoresDetalleTableAdapter = new winAppSAIC.Catalogos.dbSAIC_CatalogosTableAdapters.stpSelClientePromotoresDetalleTableAdapter();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelClientePromotoresDetalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAIC_Catalogos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSAlir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(684, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSAlir
            // 
            this.btnSAlir.Image = global::winAppSAIC.Properties.Resources.Salir24x24;
            this.btnSAlir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSAlir.Name = "btnSAlir";
            this.btnSAlir.Size = new System.Drawing.Size(49, 22);
            this.btnSAlir.Text = "Salir";
            this.btnSAlir.Click += new System.EventHandler(this.btnSAlir_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.stpSelClientePromotoresDetalleBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 25);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(684, 208);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // stpSelClientePromotoresDetalleBindingSource
            // 
            this.stpSelClientePromotoresDetalleBindingSource.DataMember = "stpSelClientePromotoresDetalle";
            this.stpSelClientePromotoresDetalleBindingSource.DataSource = this.dbSAIC_Catalogos;
            // 
            // dbSAIC_Catalogos
            // 
            this.dbSAIC_Catalogos.DataSetName = "dbSAIC_Catalogos";
            this.dbSAIC_Catalogos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdRelClientePromotor,
            this.colIdPromotor,
            this.colNombreCompletoPromotor,
            this.colComision,
            this.colObservaciones,
            this.colCorreoElectronico,
            this.colTelefono});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIdRelClientePromotor
            // 
            this.colIdRelClientePromotor.Caption = "ID";
            this.colIdRelClientePromotor.FieldName = "IdRelClientePromotor";
            this.colIdRelClientePromotor.Name = "colIdRelClientePromotor";
            this.colIdRelClientePromotor.Visible = true;
            this.colIdRelClientePromotor.VisibleIndex = 0;
            this.colIdRelClientePromotor.Width = 98;
            // 
            // colIdPromotor
            // 
            this.colIdPromotor.FieldName = "IdPromotor";
            this.colIdPromotor.Name = "colIdPromotor";
            // 
            // colNombreCompletoPromotor
            // 
            this.colNombreCompletoPromotor.Caption = "Nombre";
            this.colNombreCompletoPromotor.FieldName = "NombreCompletoPromotor";
            this.colNombreCompletoPromotor.Name = "colNombreCompletoPromotor";
            this.colNombreCompletoPromotor.Visible = true;
            this.colNombreCompletoPromotor.VisibleIndex = 1;
            this.colNombreCompletoPromotor.Width = 221;
            // 
            // colComision
            // 
            this.colComision.Caption = "Comisión";
            this.colComision.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colComision.FieldName = "Comision";
            this.colComision.Name = "colComision";
            this.colComision.Visible = true;
            this.colComision.VisibleIndex = 2;
            this.colComision.Width = 66;
            // 
            // colObservaciones
            // 
            this.colObservaciones.FieldName = "Observaciones";
            this.colObservaciones.Name = "colObservaciones";
            this.colObservaciones.Visible = true;
            this.colObservaciones.VisibleIndex = 3;
            this.colObservaciones.Width = 66;
            // 
            // colCorreoElectronico
            // 
            this.colCorreoElectronico.Caption = "Correo Electrónico";
            this.colCorreoElectronico.FieldName = "CorreoElectronico";
            this.colCorreoElectronico.Name = "colCorreoElectronico";
            this.colCorreoElectronico.Visible = true;
            this.colCorreoElectronico.VisibleIndex = 4;
            this.colCorreoElectronico.Width = 66;
            // 
            // colTelefono
            // 
            this.colTelefono.Caption = "Tél.";
            this.colTelefono.FieldName = "Telefono";
            this.colTelefono.Name = "colTelefono";
            this.colTelefono.Visible = true;
            this.colTelefono.VisibleIndex = 5;
            // 
            // stpSelClientePromotoresDetalleTableAdapter
            // 
            this.stpSelClientePromotoresDetalleTableAdapter.ClearBeforeFill = true;
            // 
            // XtraListaPromotores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 233);
            this.ControlBox = false;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "XtraListaPromotores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Promotores";
            this.Load += new System.EventHandler(this.XtraListaPromotores_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelClientePromotoresDetalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAIC_Catalogos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Bar bar1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSAlir;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource stpSelClientePromotoresDetalleBindingSource;
        private dbSAIC_Catalogos dbSAIC_Catalogos;
        private DevExpress.XtraGrid.Columns.GridColumn colIdRelClientePromotor;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPromotor;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreCompletoPromotor;
        private DevExpress.XtraGrid.Columns.GridColumn colComision;
        private DevExpress.XtraGrid.Columns.GridColumn colObservaciones;
        private DevExpress.XtraGrid.Columns.GridColumn colCorreoElectronico;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefono;
        private dbSAIC_CatalogosTableAdapters.stpSelClientePromotoresDetalleTableAdapter stpSelClientePromotoresDetalleTableAdapter;
    }
}