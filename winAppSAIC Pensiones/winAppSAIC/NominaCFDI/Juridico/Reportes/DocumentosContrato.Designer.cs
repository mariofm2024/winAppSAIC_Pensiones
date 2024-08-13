namespace winAppSAIC.Juridico.Reportes
{
    partial class DocumentosContrato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentosContrato));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.DetailReport = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Detail1 = new DevExpress.XtraReports.UI.DetailBand();
            this.RichTextParrafo2 = new DevExpress.XtraReports.UI.XRRichText();
            this.dbSAICBPOCatalogosDataSet1 = new winAppSAIC.dbSAICBPOCatalogosDataSet();
            this.stpSelDocumentosContratoTableAdapter1 = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelDocumentosContratoTableAdapter();
            this.stpSelEstatusTableAdapter = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelEstatusTableAdapter();
            this.idDocumentosContrato = new DevExpress.XtraReports.Parameters.Parameter();
            this.IdSolicitud = new DevExpress.XtraReports.Parameters.Parameter();
            this.IdFirmante = new DevExpress.XtraReports.Parameters.Parameter();
            this.IdEmpleado = new DevExpress.XtraReports.Parameters.Parameter();
            this.sArea = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this.RichTextParrafo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.HeightF = 0F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 25F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 25F;
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
            this.DetailReport.DataSourceDemanded += new System.EventHandler<System.EventArgs>(this.DetailReport_DataSourceDemanded);
            // 
            // Detail1
            // 
            this.Detail1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.RichTextParrafo2});
            this.Detail1.HeightF = 1032F;
            this.Detail1.Name = "Detail1";
            // 
            // RichTextParrafo2
            // 
            this.RichTextParrafo2.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.RichTextParrafo2.LocationFloat = new DevExpress.Utils.PointFloat(1.000023F, 0F);
            this.RichTextParrafo2.Name = "RichTextParrafo2";
            this.RichTextParrafo2.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.RichTextParrafo2.SerializableRtfString = resources.GetString("RichTextParrafo2.SerializableRtfString");
            this.RichTextParrafo2.SizeF = new System.Drawing.SizeF(749F, 54.30002F);
            this.RichTextParrafo2.StylePriority.UsePadding = false;
            // 
            // dbSAICBPOCatalogosDataSet1
            // 
            this.dbSAICBPOCatalogosDataSet1.DataSetName = "dbSAICBPOCatalogosDataSet";
            this.dbSAICBPOCatalogosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stpSelDocumentosContratoTableAdapter1
            // 
            this.stpSelDocumentosContratoTableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelEstatusTableAdapter
            // 
            this.stpSelEstatusTableAdapter.ClearBeforeFill = true;
            // 
            // idDocumentosContrato
            // 
            this.idDocumentosContrato.Name = "idDocumentosContrato";
            this.idDocumentosContrato.Type = typeof(short);
            this.idDocumentosContrato.ValueInfo = "0";
            this.idDocumentosContrato.Visible = false;
            // 
            // IdSolicitud
            // 
            this.IdSolicitud.Name = "IdSolicitud";
            this.IdSolicitud.Type = typeof(short);
            this.IdSolicitud.ValueInfo = "0";
            this.IdSolicitud.Visible = false;
            // 
            // IdFirmante
            // 
            this.IdFirmante.Name = "IdFirmante";
            this.IdFirmante.Type = typeof(short);
            this.IdFirmante.ValueInfo = "0";
            this.IdFirmante.Visible = false;
            // 
            // IdEmpleado
            // 
            this.IdEmpleado.Name = "IdEmpleado";
            this.IdEmpleado.Type = typeof(short);
            this.IdEmpleado.ValueInfo = "0";
            this.IdEmpleado.Visible = false;
            // 
            // sArea
            // 
            this.sArea.Name = "sArea";
            this.sArea.Visible = false;
            // 
            // DocumentosContrato
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.DetailReport});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.dbSAICBPOCatalogosDataSet1});
            this.Margins = new System.Drawing.Printing.Margins(50, 50, 25, 25);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.idDocumentosContrato,
            this.IdSolicitud,
            this.IdFirmante,
            this.IdEmpleado,
            this.sArea});
            this.Version = "17.1";
            this.DataSourceDemanded += new System.EventHandler<System.EventArgs>(this.DocumentosContrato_DataSourceDemanded);
            this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.DocumentosContrato_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(this.RichTextParrafo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailReportBand DetailReport;
        private DevExpress.XtraReports.UI.DetailBand Detail1;
        private DevExpress.XtraReports.UI.XRRichText RichTextParrafo2;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelDocumentosContratoTableAdapter stpSelDocumentosContratoTableAdapter1;
        private dbSAICBPOCatalogosDataSet dbSAICBPOCatalogosDataSet1;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelEstatusTableAdapter stpSelEstatusTableAdapter;
        public DevExpress.XtraReports.Parameters.Parameter idDocumentosContrato;
        public DevExpress.XtraReports.Parameters.Parameter IdSolicitud;
        public DevExpress.XtraReports.Parameters.Parameter IdFirmante;
        public DevExpress.XtraReports.Parameters.Parameter IdEmpleado;
        public DevExpress.XtraReports.Parameters.Parameter sArea;
    }
}
