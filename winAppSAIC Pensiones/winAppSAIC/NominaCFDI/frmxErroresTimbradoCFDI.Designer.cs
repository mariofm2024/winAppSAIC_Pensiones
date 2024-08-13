namespace winAppSAIC.NominaCFDI
{
    partial class frmxErroresTimbradoCFDI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmxErroresTimbradoCFDI));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnSalir = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gvErroresTimbradoCFDI = new DevExpress.XtraGrid.GridControl();
            this.stpSelErroresTimbradoCFDIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPONominaCFDIDataSet = new winAppSAIC.NominaCFDI.dbSAICBPONominaCFDIDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigoError = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescError = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaCreacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.stpSelErroresTimbradoCFDITableAdapter = new winAppSAIC.NominaCFDI.dbSAICBPONominaCFDIDataSetTableAdapters.stpSelErroresTimbradoCFDITableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvErroresTimbradoCFDI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelErroresTimbradoCFDIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPONominaCFDIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnSalir});
            this.barManager1.MaxItemId = 1;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSalir, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnSalir
            // 
            this.btnSalir.Caption = "Salir";
            this.btnSalir.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSalir.Glyph")));
            this.btnSalir.Id = 0;
            this.btnSalir.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnSalir.LargeGlyph")));
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSalir_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            this.bar3.Visible = false;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1008, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 311);
            this.barDockControlBottom.Size = new System.Drawing.Size(1008, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 280);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1008, 31);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 280);
            // 
            // gvErroresTimbradoCFDI
            // 
            this.gvErroresTimbradoCFDI.DataSource = this.stpSelErroresTimbradoCFDIBindingSource;
            this.gvErroresTimbradoCFDI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvErroresTimbradoCFDI.Location = new System.Drawing.Point(0, 31);
            this.gvErroresTimbradoCFDI.MainView = this.gridView1;
            this.gvErroresTimbradoCFDI.MenuManager = this.barManager1;
            this.gvErroresTimbradoCFDI.Name = "gvErroresTimbradoCFDI";
            this.gvErroresTimbradoCFDI.Size = new System.Drawing.Size(1008, 280);
            this.gvErroresTimbradoCFDI.TabIndex = 4;
            this.gvErroresTimbradoCFDI.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // stpSelErroresTimbradoCFDIBindingSource
            // 
            this.stpSelErroresTimbradoCFDIBindingSource.DataMember = "stpSelErroresTimbradoCFDI";
            this.stpSelErroresTimbradoCFDIBindingSource.DataSource = this.dbSAICBPONominaCFDIDataSet;
            // 
            // dbSAICBPONominaCFDIDataSet
            // 
            this.dbSAICBPONominaCFDIDataSet.DataSetName = "dbSAICBPONominaCFDIDataSet";
            this.dbSAICBPONominaCFDIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpleado,
            this.colNombreEmpleado,
            this.colCodigoError,
            this.colDescError,
            this.colFechaCreacion});
            this.gridView1.GridControl = this.gvErroresTimbradoCFDI;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIdEmpleado
            // 
            this.colIdEmpleado.AppearanceCell.Options.UseTextOptions = true;
            this.colIdEmpleado.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIdEmpleado.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdEmpleado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIdEmpleado.Caption = "No. Empleado";
            this.colIdEmpleado.FieldName = "IdEmpleado";
            this.colIdEmpleado.Name = "colIdEmpleado";
            this.colIdEmpleado.Visible = true;
            this.colIdEmpleado.VisibleIndex = 0;
            this.colIdEmpleado.Width = 80;
            // 
            // colNombreEmpleado
            // 
            this.colNombreEmpleado.FieldName = "NombreEmpleado";
            this.colNombreEmpleado.Name = "colNombreEmpleado";
            this.colNombreEmpleado.Visible = true;
            this.colNombreEmpleado.VisibleIndex = 1;
            this.colNombreEmpleado.Width = 220;
            // 
            // colCodigoError
            // 
            this.colCodigoError.AppearanceCell.Options.UseTextOptions = true;
            this.colCodigoError.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCodigoError.AppearanceHeader.Options.UseTextOptions = true;
            this.colCodigoError.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCodigoError.Caption = "Código Error";
            this.colCodigoError.FieldName = "CodigoError";
            this.colCodigoError.Name = "colCodigoError";
            this.colCodigoError.Visible = true;
            this.colCodigoError.VisibleIndex = 2;
            this.colCodigoError.Width = 80;
            // 
            // colDescError
            // 
            this.colDescError.Caption = "Descripción Error";
            this.colDescError.FieldName = "DescError";
            this.colDescError.Name = "colDescError";
            this.colDescError.Visible = true;
            this.colDescError.VisibleIndex = 3;
            this.colDescError.Width = 483;
            // 
            // colFechaCreacion
            // 
            this.colFechaCreacion.AppearanceCell.Options.UseTextOptions = true;
            this.colFechaCreacion.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFechaCreacion.AppearanceHeader.Options.UseTextOptions = true;
            this.colFechaCreacion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFechaCreacion.Caption = "Fecha Registro";
            this.colFechaCreacion.DisplayFormat.FormatString = "g";
            this.colFechaCreacion.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colFechaCreacion.FieldName = "FechaCreacion";
            this.colFechaCreacion.Name = "colFechaCreacion";
            this.colFechaCreacion.Visible = true;
            this.colFechaCreacion.VisibleIndex = 4;
            this.colFechaCreacion.Width = 120;
            // 
            // stpSelErroresTimbradoCFDITableAdapter
            // 
            this.stpSelErroresTimbradoCFDITableAdapter.ClearBeforeFill = true;
            // 
            // frmxErroresTimbradoCFDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 334);
            this.ControlBox = false;
            this.Controls.Add(this.gvErroresTimbradoCFDI);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmxErroresTimbradoCFDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Errores de Timbrado XML CFDI";
            this.Load += new System.EventHandler(this.frmxErroresTimbradoCFDI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvErroresTimbradoCFDI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelErroresTimbradoCFDIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPONominaCFDIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnSalir;
        private DevExpress.XtraGrid.GridControl gvErroresTimbradoCFDI;
        private System.Windows.Forms.BindingSource stpSelErroresTimbradoCFDIBindingSource;
        private dbSAICBPONominaCFDIDataSet dbSAICBPONominaCFDIDataSet;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoError;
        private DevExpress.XtraGrid.Columns.GridColumn colDescError;
        private dbSAICBPONominaCFDIDataSetTableAdapters.stpSelErroresTimbradoCFDITableAdapter stpSelErroresTimbradoCFDITableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaCreacion;
    }
}