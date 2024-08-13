namespace winAppSAIC.Facturas
{
    partial class frmxErroresTimbradoCFDIFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmxErroresTimbradoCFDIFactura));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnSalir = new DevExpress.XtraBars.BarButtonItem();
            this.btnExportarErrores2XLSX = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gvErroresTimbradoCFDI = new DevExpress.XtraGrid.GridControl();
            this.stpFactSelErroresTimbradoCFDIFacturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPOFactura = new winAppSAIC.Facturas.dbSAICBPOFactura();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdHeaderFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSerie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFolioInterno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigoError = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescError = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaCreacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.sfdRutaArchivo = new System.Windows.Forms.SaveFileDialog();
            this.stpFactSelErroresTimbradoCFDIFacturasTableAdapter = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelErroresTimbradoCFDIFacturasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvErroresTimbradoCFDI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelErroresTimbradoCFDIFacturasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
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
            this.btnSalir,
            this.btnExportarErrores2XLSX});
            this.barManager1.MaxItemId = 2;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSalir, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnExportarErrores2XLSX, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnSalir
            // 
            this.btnSalir.Caption = "Salir";
            this.btnSalir.Id = 0;
            this.btnSalir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.ImageOptions.Image")));
            this.btnSalir.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.ImageOptions.LargeImage")));
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSalir_ItemClick);
            // 
            // btnExportarErrores2XLSX
            // 
            this.btnExportarErrores2XLSX.Caption = "Exportar Errores a Excel (XLS)";
            this.btnExportarErrores2XLSX.Id = 1;
            this.btnExportarErrores2XLSX.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExportarErrores2XLSX.ImageOptions.Image")));
            this.btnExportarErrores2XLSX.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnExportarErrores2XLSX.ImageOptions.LargeImage")));
            this.btnExportarErrores2XLSX.Name = "btnExportarErrores2XLSX";
            this.btnExportarErrores2XLSX.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExportarErrores2XLSX_ItemClick);
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
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(904, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 311);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(904, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 280);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(904, 31);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 280);
            // 
            // gvErroresTimbradoCFDI
            // 
            this.gvErroresTimbradoCFDI.DataSource = this.stpFactSelErroresTimbradoCFDIFacturasBindingSource;
            this.gvErroresTimbradoCFDI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvErroresTimbradoCFDI.Location = new System.Drawing.Point(0, 31);
            this.gvErroresTimbradoCFDI.MainView = this.gridView1;
            this.gvErroresTimbradoCFDI.MenuManager = this.barManager1;
            this.gvErroresTimbradoCFDI.Name = "gvErroresTimbradoCFDI";
            this.gvErroresTimbradoCFDI.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1});
            this.gvErroresTimbradoCFDI.Size = new System.Drawing.Size(904, 280);
            this.gvErroresTimbradoCFDI.TabIndex = 4;
            this.gvErroresTimbradoCFDI.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // stpFactSelErroresTimbradoCFDIFacturasBindingSource
            // 
            this.stpFactSelErroresTimbradoCFDIFacturasBindingSource.DataMember = "stpFactSelErroresTimbradoCFDIFacturas";
            this.stpFactSelErroresTimbradoCFDIFacturasBindingSource.DataSource = this.dbSAICBPOFactura;
            // 
            // dbSAICBPOFactura
            // 
            this.dbSAICBPOFactura.DataSetName = "dbSAICBPOFactura";
            this.dbSAICBPOFactura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdHeaderFactura,
            this.colSerie,
            this.colFolioInterno,
            this.colCodigoError,
            this.colDescError,
            this.colFechaCreacion});
            this.gridView1.GridControl = this.gvErroresTimbradoCFDI;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIdHeaderFactura
            // 
            this.colIdHeaderFactura.Caption = "Id Factura";
            this.colIdHeaderFactura.FieldName = "IdHeaderFactura";
            this.colIdHeaderFactura.Name = "colIdHeaderFactura";
            this.colIdHeaderFactura.Visible = true;
            this.colIdHeaderFactura.VisibleIndex = 0;
            this.colIdHeaderFactura.Width = 80;
            // 
            // colSerie
            // 
            this.colSerie.FieldName = "Serie";
            this.colSerie.Name = "colSerie";
            this.colSerie.Visible = true;
            this.colSerie.VisibleIndex = 1;
            this.colSerie.Width = 78;
            // 
            // colFolioInterno
            // 
            this.colFolioInterno.Caption = "Folio Interno";
            this.colFolioInterno.FieldName = "FolioInterno";
            this.colFolioInterno.Name = "colFolioInterno";
            this.colFolioInterno.Visible = true;
            this.colFolioInterno.VisibleIndex = 2;
            this.colFolioInterno.Width = 81;
            // 
            // colCodigoError
            // 
            this.colCodigoError.Caption = "Codigo Error";
            this.colCodigoError.FieldName = "CodigoError";
            this.colCodigoError.Name = "colCodigoError";
            this.colCodigoError.Visible = true;
            this.colCodigoError.VisibleIndex = 3;
            this.colCodigoError.Width = 82;
            // 
            // colDescError
            // 
            this.colDescError.Caption = "Descripción Error";
            this.colDescError.FieldName = "DescError";
            this.colDescError.Name = "colDescError";
            this.colDescError.Visible = true;
            this.colDescError.VisibleIndex = 4;
            this.colDescError.Width = 424;
            // 
            // colFechaCreacion
            // 
            this.colFechaCreacion.Caption = "Fecha Creación";
            this.colFechaCreacion.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colFechaCreacion.FieldName = "FechaCreacion";
            this.colFechaCreacion.Name = "colFechaCreacion";
            this.colFechaCreacion.Visible = true;
            this.colFechaCreacion.VisibleIndex = 5;
            this.colFechaCreacion.Width = 139;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // sfdRutaArchivo
            // 
            this.sfdRutaArchivo.Filter = "Archivos de Excel | *.xls";
            this.sfdRutaArchivo.Title = "Guardar como...";
            // 
            // stpFactSelErroresTimbradoCFDIFacturasTableAdapter
            // 
            this.stpFactSelErroresTimbradoCFDIFacturasTableAdapter.ClearBeforeFill = true;
            // 
            // frmxErroresTimbradoCFDIFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 334);
            this.ControlBox = false;
            this.Controls.Add(this.gvErroresTimbradoCFDI);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmxErroresTimbradoCFDIFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Errores de Timbrado XML CFDI";
            this.Load += new System.EventHandler(this.frmxErroresTimbradoCFDI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvErroresTimbradoCFDI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelErroresTimbradoCFDIFacturasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
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
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraBars.BarButtonItem btnExportarErrores2XLSX;
        private System.Windows.Forms.SaveFileDialog sfdRutaArchivo;
        private System.Windows.Forms.BindingSource stpFactSelErroresTimbradoCFDIFacturasBindingSource;
        private dbSAICBPOFactura dbSAICBPOFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colIdHeaderFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colSerie;
        private DevExpress.XtraGrid.Columns.GridColumn colFolioInterno;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoError;
        private DevExpress.XtraGrid.Columns.GridColumn colDescError;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaCreacion;
        private dbSAICBPOFacturaTableAdapters.stpFactSelErroresTimbradoCFDIFacturasTableAdapter stpFactSelErroresTimbradoCFDIFacturasTableAdapter;
    }
}