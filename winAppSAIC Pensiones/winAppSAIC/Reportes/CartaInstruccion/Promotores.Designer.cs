namespace winAppSAIC.Reportes
{
    partial class Promotores
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.IdCliente = new DevExpress.XtraReports.Parameters.Parameter();
            this.dbSAICBPOFactura1 = new winAppSAIC.Facturas.dbSAICBPOFactura();
            this.stpFactSelReporteClientePromotoresTableAdapter1 = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelReporteClientePromotoresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOFactura1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1});
            this.Detail.Dpi = 100F;
            this.Detail.HeightF = 14.58333F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "stpFactSelReporteClientePromotores.NombreCompletoPromotor")});
            this.xrLabel1.Dpi = 100F;
            this.xrLabel1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(259F, 13.95833F);
            this.xrLabel1.StylePriority.UseBorders = false;
            this.xrLabel1.StylePriority.UseFont = false;
            // 
            // TopMargin
            // 
            this.TopMargin.Dpi = 100F;
            this.TopMargin.HeightF = 12F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Dpi = 100F;
            this.BottomMargin.HeightF = 12F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // IdCliente
            // 
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.Type = typeof(int);
            this.IdCliente.ValueInfo = "0";
            this.IdCliente.Visible = false;
            // 
            // dbSAICBPOFactura1
            // 
            this.dbSAICBPOFactura1.DataSetName = "dbSAICBPOFactura";
            this.dbSAICBPOFactura1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stpFactSelReporteClientePromotoresTableAdapter1
            // 
            this.stpFactSelReporteClientePromotoresTableAdapter1.ClearBeforeFill = true;
            // 
            // Promotores
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
            this.DataAdapter = this.stpFactSelReporteClientePromotoresTableAdapter1;
            this.DataMember = "stpFactSelReporteClientePromotores";
            this.DataSource = this.dbSAICBPOFactura1;
            this.Margins = new System.Drawing.Printing.Margins(12, 100, 12, 12);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.IdCliente});
            this.Version = "16.2";
            this.DataSourceDemanded += new System.EventHandler<System.EventArgs>(this.Promotores_DataSourceDemanded);
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOFactura1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        public DevExpress.XtraReports.Parameters.Parameter IdCliente;
        private Facturas.dbSAICBPOFactura dbSAICBPOFactura1;
        private Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelReporteClientePromotoresTableAdapter stpFactSelReporteClientePromotoresTableAdapter1;
    }
}
