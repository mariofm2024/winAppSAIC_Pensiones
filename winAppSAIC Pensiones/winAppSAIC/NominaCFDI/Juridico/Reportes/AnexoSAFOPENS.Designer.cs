namespace winAppSAIC.Juridico.Reportes
{
    partial class ReportSAFOPENS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportSAFOPENS));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.DetailReport = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Detail1 = new DevExpress.XtraReports.UI.DetailBand();
            this.xrRichText = new DevExpress.XtraReports.UI.XRRichText();
            this.NombreTenedora = new DevExpress.XtraReports.Parameters.Parameter();
            this.idPlan = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.HeightF = 1.041667F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 100F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 100F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // DetailReport
            // 
            this.DetailReport.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail1});
            this.DetailReport.Level = 0;
            this.DetailReport.Name = "DetailReport";
            // 
            // Detail1
            // 
            this.Detail1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrRichText});
            this.Detail1.HeightF = 1032F;
            this.Detail1.Name = "Detail1";
            // 
            // xrRichText
            // 
            this.xrRichText.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.xrRichText.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrRichText.Name = "xrRichText";
            this.xrRichText.SerializableRtfString = resources.GetString("xrRichText.SerializableRtfString");
            this.xrRichText.SizeF = new System.Drawing.SizeF(650.0001F, 1032F);
            this.xrRichText.StylePriority.UseFont = false;
            // 
            // NombreTenedora
            // 
            this.NombreTenedora.Name = "NombreTenedora";
            this.NombreTenedora.ValueInfo = "Hola";
            this.NombreTenedora.Visible = false;
            // 
            // idPlan
            // 
            this.idPlan.Name = "idPlan";
            this.idPlan.Visible = false;
            // 
            // ReportSAFOPENS
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.DetailReport});
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.NombreTenedora,
            this.idPlan});
            this.Version = "17.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailReportBand DetailReport;
        private DevExpress.XtraReports.UI.DetailBand Detail1;
        private DevExpress.XtraReports.UI.XRRichText xrRichText;
        private DevExpress.XtraReports.Parameters.Parameter NombreTenedora;
        private DevExpress.XtraReports.Parameters.Parameter idPlan;
    }
}
