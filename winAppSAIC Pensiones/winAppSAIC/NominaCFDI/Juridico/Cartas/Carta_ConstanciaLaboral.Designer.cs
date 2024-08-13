namespace winAppSAIC.Juridico.Cartas
{
    partial class Carta_ConstanciaLaboral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carta_ConstanciaLaboral));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.DetailReport = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Detail1 = new DevExpress.XtraReports.UI.DetailBand();
            this.xrPictureBoxLogo = new DevExpress.XtraReports.UI.XRPictureBox();
            this.txtCarta = new DevExpress.XtraReports.UI.XRRichText();
            this.dbSAICBPOCatalogosDataSet1 = new winAppSAIC.dbSAICBPOCatalogosDataSet();
            this.idMatrizTenedora = new DevExpress.XtraReports.Parameters.Parameter();
            this.stCarta = new DevExpress.XtraReports.Parameters.Parameter();
            this.stpSelEstatusTableAdapter = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelEstatusTableAdapter();
            this.stpSelObtenerLogoTenedoraTableAdapter1 = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelObtenerLogoTenedoraTableAdapter();
            this.stpFactSelReporteFacturaPDFTableAdapter = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelReporteFacturaPDFTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.txtCarta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.HeightF = 100F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 50F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 50F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // DetailReport
            // 
            this.DetailReport.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail1});
            this.DetailReport.DataSource = this.dbSAICBPOCatalogosDataSet1;
            this.DetailReport.Level = 0;
            this.DetailReport.Name = "DetailReport";
            // 
            // Detail1
            // 
            this.Detail1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPictureBoxLogo,
            this.txtCarta});
            this.Detail1.HeightF = 1032F;
            this.Detail1.Name = "Detail1";
            // 
            // xrPictureBoxLogo
            // 
            this.xrPictureBoxLogo.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("ImageUrl", null, "stpSelObtenerLogoTenedora.Logotipo"),
            new DevExpress.XtraReports.UI.XRBinding("Image", null, "stpSelObtenerLogoTenedora.Logotipo")});
            this.xrPictureBoxLogo.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleCenter;
            this.xrPictureBoxLogo.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 10.00001F);
            this.xrPictureBoxLogo.Name = "xrPictureBoxLogo";
            this.xrPictureBoxLogo.SizeF = new System.Drawing.SizeF(239.3717F, 196.875F);
            this.xrPictureBoxLogo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // txtCarta
            // 
            this.txtCarta.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.txtCarta.LocationFloat = new DevExpress.Utils.PointFloat(0F, 206.875F);
            this.txtCarta.Name = "txtCarta";
            this.txtCarta.SerializableRtfString = resources.GetString("txtCarta.SerializableRtfString");
            this.txtCarta.SizeF = new System.Drawing.SizeF(650F, 22.99998F);
            // 
            // dbSAICBPOCatalogosDataSet1
            // 
            this.dbSAICBPOCatalogosDataSet1.DataSetName = "dbSAICBPOCatalogosDataSet";
            this.dbSAICBPOCatalogosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idMatrizTenedora
            // 
            this.idMatrizTenedora.MultiValue = true;
            this.idMatrizTenedora.Name = "idMatrizTenedora";
            this.idMatrizTenedora.Type = typeof(int);
            this.idMatrizTenedora.ValueInfo = "0";
            this.idMatrizTenedora.Visible = false;
            // 
            // stCarta
            // 
            this.stCarta.Name = "stCarta";
            this.stCarta.Visible = false;
            // 
            // stpSelEstatusTableAdapter
            // 
            this.stpSelEstatusTableAdapter.ClearBeforeFill = true;
            // 
            // stpSelObtenerLogoTenedoraTableAdapter1
            // 
            this.stpSelObtenerLogoTenedoraTableAdapter1.ClearBeforeFill = true;
            // 
            // stpFactSelReporteFacturaPDFTableAdapter
            // 
            this.stpFactSelReporteFacturaPDFTableAdapter.ClearBeforeFill = true;
            // 
            // Carta_ConstanciaLaboral
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.DetailReport});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.dbSAICBPOCatalogosDataSet1});
            this.DataAdapter = this.stpSelObtenerLogoTenedoraTableAdapter1;
            this.DataMember = "stpSelObtenerLogoTenedora";
            this.DataSource = this.dbSAICBPOCatalogosDataSet1;
            this.Margins = new System.Drawing.Printing.Margins(100, 100, 50, 50);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.idMatrizTenedora,
            this.stCarta});
            this.Version = "17.1";
            this.DataSourceDemanded += new System.EventHandler<System.EventArgs>(this.Carta_ConstanciaLaboral_DataSourceDemanded);
            this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.Carta_ConstanciaLaboral_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(this.txtCarta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailReportBand DetailReport;
        private DevExpress.XtraReports.UI.DetailBand Detail1;
        private DevExpress.XtraReports.UI.XRRichText txtCarta;
        public DevExpress.XtraReports.Parameters.Parameter idMatrizTenedora;
        public DevExpress.XtraReports.Parameters.Parameter stCarta;
        private dbSAICBPOCatalogosDataSet dbSAICBPOCatalogosDataSet1;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelEstatusTableAdapter stpSelEstatusTableAdapter;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelObtenerLogoTenedoraTableAdapter stpSelObtenerLogoTenedoraTableAdapter1;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBoxLogo;
        private Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelReporteFacturaPDFTableAdapter stpFactSelReporteFacturaPDFTableAdapter;
    }
}
