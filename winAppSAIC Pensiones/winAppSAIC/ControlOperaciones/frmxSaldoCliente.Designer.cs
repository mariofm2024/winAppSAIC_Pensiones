namespace winAppSAIC.ControlOperaciones
{
    partial class frmxSaldoCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmxSaldoCliente));
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.btnSalir = new DevExpress.XtraBars.BarButtonItem();
            this.btnExtraer = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnConsultar = new DevExpress.XtraBars.BarButtonItem();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cbCliente = new DevExpress.XtraEditors.GridLookUpEdit();
            this.vwCatClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPODataSet = new winAppSAIC.dbSAICBPODataSet();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreComercial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRazonSocialC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRFC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sidePanel2 = new DevExpress.XtraEditors.SidePanel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.stpFactSelDetailCOSaldoFullBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPOFactura = new winAppSAIC.Facturas.dbSAICBPOFactura();
            this.dgvSaldo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colConcepto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSUMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRESTA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.stpFactSelDetailCOSaldoFullTableAdapter = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelDetailCOSaldoFullTableAdapter();
            this.vwCatClienteTableAdapter = new winAppSAIC.dbSAICBPODataSetTableAdapters.vwCatClienteTableAdapter();
            this.savedescarga = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCatClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.sidePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelDetailCOSaldoFullBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaldo)).BeginInit();
            this.SuspendLayout();
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar1
            // 
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar4});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnSalir,
            this.btnConsultar,
            this.btnExtraer});
            this.barManager1.MainMenu = this.bar4;
            this.barManager1.MaxItemId = 3;
            // 
            // bar4
            // 
            this.bar4.BarName = "Main menu";
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSalir),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExtraer)});
            this.bar4.OptionsBar.MultiLine = true;
            this.bar4.OptionsBar.UseWholeRow = true;
            this.bar4.Text = "Main menu";
            // 
            // btnSalir
            // 
            this.btnSalir.Caption = "Salir";
            this.btnSalir.Id = 0;
            this.btnSalir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.ImageOptions.Image")));
            this.btnSalir.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.ImageOptions.LargeImage")));
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnSalir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSalir_ItemClick);
            // 
            // btnExtraer
            // 
            this.btnExtraer.Caption = "Descargar";
            this.btnExtraer.Id = 2;
            this.btnExtraer.ImageOptions.Image = global::winAppSAIC.Properties.Resources.Excel;
            this.btnExtraer.Name = "btnExtraer";
            this.btnExtraer.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnExtraer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExtraer_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(1054, 36);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 630);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1054, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 36);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 594);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1054, 36);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 594);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Caption = "Obtener";
            this.btnConsultar.Id = 1;
            this.btnConsultar.ImageOptions.Image = global::winAppSAIC.Properties.Resources.if_excel_836882;
            this.btnConsultar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnConsultar.ImageOptions.LargeImage")));
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.labelControl2);
            this.sidePanel1.Controls.Add(this.cbCliente);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel1.Location = new System.Drawing.Point(0, 36);
            this.sidePanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(1054, 77);
            this.sidePanel1.TabIndex = 4;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(45, 28);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(54, 19);
            this.labelControl2.TabIndex = 45;
            this.labelControl2.Text = "Cliente:";
            // 
            // cbCliente
            // 
            this.cbCliente.Location = new System.Drawing.Point(110, 23);
            this.cbCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.cbCliente.Properties.Appearance.Options.UseBackColor = true;
            this.cbCliente.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbCliente.Properties.DataSource = this.vwCatClienteBindingSource;
            this.cbCliente.Properties.DisplayMember = "NombreComercial";
            this.cbCliente.Properties.NullText = "";
            this.cbCliente.Properties.PopupSizeable = false;
            this.cbCliente.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbCliente.Properties.ValueMember = "IdCliente";
            this.cbCliente.Properties.View = this.gridLookUpEdit1View;
            this.cbCliente.Size = new System.Drawing.Size(688, 26);
            this.cbCliente.TabIndex = 44;
            this.cbCliente.Tag = "Cliente";
            this.cbCliente.EditValueChanged += new System.EventHandler(this.cbCliente_EditValueChanged);
            // 
            // vwCatClienteBindingSource
            // 
            this.vwCatClienteBindingSource.DataMember = "vwCatCliente";
            this.vwCatClienteBindingSource.DataSource = this.dbSAICBPODataSet;
            // 
            // dbSAICBPODataSet
            // 
            this.dbSAICBPODataSet.DataSetName = "dbSAICBPODataSet";
            this.dbSAICBPODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCliente,
            this.colNombreComercial,
            this.colRazonSocialC,
            this.colRFC});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdCliente
            // 
            this.colIdCliente.Caption = "IdCliente";
            this.colIdCliente.FieldName = "IdCliente";
            this.colIdCliente.Name = "colIdCliente";
            // 
            // colNombreComercial
            // 
            this.colNombreComercial.Caption = "Nombre Comercial";
            this.colNombreComercial.FieldName = "NombreComercial";
            this.colNombreComercial.Name = "colNombreComercial";
            this.colNombreComercial.Visible = true;
            this.colNombreComercial.VisibleIndex = 0;
            // 
            // colRazonSocialC
            // 
            this.colRazonSocialC.Caption = "Razon Social";
            this.colRazonSocialC.FieldName = "RazonSocial";
            this.colRazonSocialC.Name = "colRazonSocialC";
            this.colRazonSocialC.Visible = true;
            this.colRazonSocialC.VisibleIndex = 1;
            // 
            // colRFC
            // 
            this.colRFC.Caption = "RFC";
            this.colRFC.FieldName = "RFC";
            this.colRFC.Name = "colRFC";
            this.colRFC.Visible = true;
            this.colRFC.VisibleIndex = 2;
            // 
            // sidePanel2
            // 
            this.sidePanel2.Controls.Add(this.gridControl1);
            this.sidePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidePanel2.Location = new System.Drawing.Point(0, 113);
            this.sidePanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sidePanel2.Name = "sidePanel2";
            this.sidePanel2.Size = new System.Drawing.Size(1054, 517);
            this.sidePanel2.TabIndex = 5;
            this.sidePanel2.Text = "sidePanel2";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.stpFactSelDetailCOSaldoFullBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.dgvSaldo;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1054, 517);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvSaldo});
            // 
            // stpFactSelDetailCOSaldoFullBindingSource
            // 
            this.stpFactSelDetailCOSaldoFullBindingSource.DataMember = "stpFactSelDetailCOSaldoFull";
            this.stpFactSelDetailCOSaldoFullBindingSource.DataSource = this.dbSAICBPOFactura;
            // 
            // dbSAICBPOFactura
            // 
            this.dbSAICBPOFactura.DataSetName = "dbSAICBPOFactura";
            this.dbSAICBPOFactura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvSaldo
            // 
            this.dgvSaldo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colConcepto,
            this.colSUMA,
            this.colRESTA,
            this.gridColumn1,
            this.gridColumn2});
            this.dgvSaldo.GridControl = this.gridControl1;
            this.dgvSaldo.Name = "dgvSaldo";
            this.dgvSaldo.OptionsBehavior.Editable = false;
            this.dgvSaldo.OptionsPrint.PrintGroupFooter = false;
            this.dgvSaldo.OptionsView.ShowGroupPanel = false;
            // 
            // colConcepto
            // 
            this.colConcepto.Caption = "Detalle";
            this.colConcepto.FieldName = "Concepto";
            this.colConcepto.Name = "colConcepto";
            this.colConcepto.Visible = true;
            this.colConcepto.VisibleIndex = 0;
            this.colConcepto.Width = 374;
            // 
            // colSUMA
            // 
            this.colSUMA.Caption = "Ingresos";
            this.colSUMA.DisplayFormat.FormatString = "N2";
            this.colSUMA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSUMA.FieldName = "SUMA";
            this.colSUMA.Name = "colSUMA";
            this.colSUMA.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SUMA", "{0:N2}")});
            this.colSUMA.Visible = true;
            this.colSUMA.VisibleIndex = 1;
            this.colSUMA.Width = 140;
            // 
            // colRESTA
            // 
            this.colRESTA.Caption = "Egresos";
            this.colRESTA.DisplayFormat.FormatString = "N2";
            this.colRESTA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colRESTA.FieldName = "RESTA";
            this.colRESTA.Name = "colRESTA";
            this.colRESTA.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RESTA", "{0:N2}")});
            this.colRESTA.Visible = true;
            this.colRESTA.VisibleIndex = 2;
            this.colRESTA.Width = 117;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Total";
            this.gridColumn1.DisplayFormat.FormatString = "N2";
            this.gridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn1.FieldName = "Resultado";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Resultado", "{0:N2}")});
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            this.gridColumn1.Width = 128;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Fecha";
            this.gridColumn2.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.gridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn2.FieldName = "Fecha";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 4;
            this.gridColumn2.Width = 144;
            // 
            // stpFactSelDetailCOSaldoFullTableAdapter
            // 
            this.stpFactSelDetailCOSaldoFullTableAdapter.ClearBeforeFill = true;
            // 
            // vwCatClienteTableAdapter
            // 
            this.vwCatClienteTableAdapter.ClearBeforeFill = true;
            // 
            // frmxSaldoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 630);
            this.Controls.Add(this.sidePanel2);
            this.Controls.Add(this.sidePanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmxSaldoCliente";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saldo Cliente";
            this.Load += new System.EventHandler(this.frmxSaldoCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            this.sidePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCatClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.sidePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelDetailCOSaldoFullBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaldo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.BarButtonItem btnSalir;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnConsultar;
        private DevExpress.XtraEditors.SidePanel sidePanel2;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvSaldo;
        private System.Windows.Forms.BindingSource stpFactSelDetailCOSaldoFullBindingSource;
        private Facturas.dbSAICBPOFactura dbSAICBPOFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colConcepto;
        private DevExpress.XtraGrid.Columns.GridColumn colSUMA;
        private DevExpress.XtraGrid.Columns.GridColumn colRESTA;
        private Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelDetailCOSaldoFullTableAdapter stpFactSelDetailCOSaldoFullTableAdapter;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GridLookUpEdit cbCliente;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreComercial;
        private DevExpress.XtraGrid.Columns.GridColumn colRazonSocialC;
        private DevExpress.XtraGrid.Columns.GridColumn colRFC;
        private dbSAICBPODataSet dbSAICBPODataSet;
        private System.Windows.Forms.BindingSource vwCatClienteBindingSource;
        private dbSAICBPODataSetTableAdapters.vwCatClienteTableAdapter vwCatClienteTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private System.Windows.Forms.SaveFileDialog savedescarga;
        private DevExpress.XtraBars.BarButtonItem btnExtraer;
    }
}