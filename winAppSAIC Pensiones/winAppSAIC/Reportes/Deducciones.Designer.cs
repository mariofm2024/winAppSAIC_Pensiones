namespace winAppSAIC
{
    partial class Deducciones
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
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.pIdPDOHeader = new DevExpress.XtraReports.Parameters.Parameter();
            this.dbSAICBPOReportesDataSet1 = new winAppSAIC.dbSAICBPOReportesDataSet();
            this.stpSelDeduccionesRecibosEmpleadosSATableAdapter = new winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.stpSelDeduccionesRecibosEmpleadosSATableAdapter();
            this.pIdLoteCargaNomina = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOReportesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel4,
            this.xrLabel3,
            this.xrLabel2,
            this.xrLabel1});
            this.Detail.Dpi = 100F;
            this.Detail.HeightF = 14.1F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel4
            // 
            this.xrLabel4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "stpSelDeduccionesRecibosEmpleadosSA.IdLoteCargaNomina")});
            this.xrLabel4.Dpi = 100F;
            this.xrLabel4.Font = new System.Drawing.Font("Arial", 8F);
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(396.6042F, 0.1416683F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(48.95833F, 13.95833F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.Visible = false;
            // 
            // xrLabel3
            // 
            this.xrLabel3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "stpSelDeduccionesRecibosEmpleadosSA.MontoPDO", "{0:$0.00}")});
            this.xrLabel3.Dpi = 100F;
            this.xrLabel3.Font = new System.Drawing.Font("Arial", 8F);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(211F, 0F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(90F, 14F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            xrSummary1.FormatString = "{0:$0.00}";
            this.xrLabel3.Summary = xrSummary1;
            this.xrLabel3.Text = "xrLabel3";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel2
            // 
            this.xrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "stpSelDeduccionesRecibosEmpleadosSA.DescConcepto")});
            this.xrLabel2.Dpi = 100F;
            this.xrLabel2.Font = new System.Drawing.Font("Arial", 8F);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 0F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(188F, 14F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.Text = "xrLabel2";
            // 
            // xrLabel1
            // 
            this.xrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "stpSelDeduccionesRecibosEmpleadosSA.IdPDOHeader")});
            this.xrLabel1.Dpi = 100F;
            this.xrLabel1.Font = new System.Drawing.Font("Arial", 8F);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(318.75F, 0F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(48.95833F, 13.95833F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.Text = "xrLabel1";
            this.xrLabel1.Visible = false;
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
            // pIdPDOHeader
            // 
            this.pIdPDOHeader.Name = "pIdPDOHeader";
            this.pIdPDOHeader.Type = typeof(long);
            this.pIdPDOHeader.ValueInfo = "0";
            this.pIdPDOHeader.Visible = false;
            // 
            // pIdLoteCargaNomina
            // 
            this.pIdLoteCargaNomina.Name = "pIdLoteCargaNomina";
            this.pIdLoteCargaNomina.Type = typeof(long);
            this.pIdLoteCargaNomina.ValueInfo = "0";
            this.pIdLoteCargaNomina.Visible = false;
            // 
            // dbSAICBPOReportesDataSet1
            // 
            this.dbSAICBPOReportesDataSet1.DataSetName = "dbSAICBPOReportesDataSet";
            this.dbSAICBPOReportesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stpSelDeduccionesRecibosEmpleadosSATableAdapter
            // 
            this.stpSelDeduccionesRecibosEmpleadosSATableAdapter.ClearBeforeFill = true;
            // 
            // pIdLoteCargaNomina
            // 
            this.pIdLoteCargaNomina.Name = "pIdLoteCargaNomina";
            this.pIdLoteCargaNomina.Type = typeof(long);
            this.pIdLoteCargaNomina.ValueInfo = "0";
            // 
            // Deducciones
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
            this.DataAdapter = this.stpSelDeduccionesRecibosEmpleadosSATableAdapter;
            this.DataMember = "stpSelDeduccionesRecibosEmpleadosSA";
            this.DataSource = this.dbSAICBPOReportesDataSet1;
            this.Margins = new System.Drawing.Printing.Margins(12, 100, 12, 12);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.pIdPDOHeader,
            this.pIdLoteCargaNomina});
            this.Version = "16.2";
            this.DataSourceDemanded += new System.EventHandler<System.EventArgs>(this.Deducciones_DataSourceDemanded);
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOReportesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        public DevExpress.XtraReports.Parameters.Parameter pIdPDOHeader;
        private dbSAICBPOReportesDataSet dbSAICBPOReportesDataSet1;
        private dbSAICBPOReportesDataSetTableAdapters.stpSelDeduccionesRecibosEmpleadosSATableAdapter stpSelDeduccionesRecibosEmpleadosSATableAdapter;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        public DevExpress.XtraReports.Parameters.Parameter pIdLoteCargaNomina;
    }
}
