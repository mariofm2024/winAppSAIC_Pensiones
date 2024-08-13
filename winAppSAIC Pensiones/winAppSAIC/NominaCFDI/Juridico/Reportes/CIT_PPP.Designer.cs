namespace winAppSAIC.Juridico.Reportes
{
    partial class CIT_PPP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CIT_PPP));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.DetailReport = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Detail1 = new DevExpress.XtraReports.UI.DetailBand();
            this.RichTextParrafo1 = new DevExpress.XtraReports.UI.XRRichText();
            this.dbSAICBPOCatalogosDataSet1 = new winAppSAIC.dbSAICBPOCatalogosDataSet();
            this.stpSelEstatusTableAdapter = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelEstatusTableAdapter();
            this.dbSAICBPODataSet1 = new winAppSAIC.dbSAICBPODataSet();
            this.vwCatTenedoraSATableAdapter = new winAppSAIC.dbSAICBPODataSetTableAdapters.vwCatTenedoraSATableAdapter();
            this.stpSelDetalleSolicitudChequesMasivosTableAdapter1 = new winAppSAIC.Tesoreria.dbSAICBPOTesoreriaDataSetTableAdapters.stpSelDetalleSolicitudChequesMasivosTableAdapter();
            this.Solicitud = new DevExpress.XtraReports.Parameters.Parameter();
            this.idMatrizTenedora = new DevExpress.XtraReports.Parameters.Parameter();
            this.IdEmpleado = new DevExpress.XtraReports.Parameters.Parameter();
            this.stEmpleados = new DevExpress.XtraReports.Parameters.Parameter();
            this.stpSelCITTableAdapter1 = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelCITTableAdapter();
            this.tipoConsulta = new DevExpress.XtraReports.Parameters.Parameter();
            this.ResultadoHTML = new DevExpress.XtraReports.Parameters.Parameter();
            this.stpSelConsultaContratoEmpleadoTableAdapter1 = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelConsultaContratoEmpleadoTableAdapter();
            this.IdFirmante = new DevExpress.XtraReports.Parameters.Parameter();
            this.flagConGenerico = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this.RichTextParrafo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPODataSet1)).BeginInit();
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
            // 
            // Detail1
            // 
            this.Detail1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.RichTextParrafo1});
            this.Detail1.HeightF = 1032F;
            this.Detail1.Name = "Detail1";
            // 
            // RichTextParrafo1
            // 
            this.RichTextParrafo1.Font = new System.Drawing.Font("Arial Narrow", 400F);
            this.RichTextParrafo1.LocationFloat = new DevExpress.Utils.PointFloat(0.0001430511F, 0F);
            this.RichTextParrafo1.Name = "RichTextParrafo1";
            this.RichTextParrafo1.SerializableRtfString = resources.GetString("RichTextParrafo1.SerializableRtfString");
            this.RichTextParrafo1.SizeF = new System.Drawing.SizeF(749.9999F, 53.38754F);
            this.RichTextParrafo1.StylePriority.UseFont = false;
            // 
            // dbSAICBPOCatalogosDataSet1
            // 
            this.dbSAICBPOCatalogosDataSet1.DataSetName = "dbSAICBPOCatalogosDataSet";
            this.dbSAICBPOCatalogosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stpSelEstatusTableAdapter
            // 
            this.stpSelEstatusTableAdapter.ClearBeforeFill = true;
            // 
            // dbSAICBPODataSet1
            // 
            this.dbSAICBPODataSet1.DataSetName = "dbSAICBPODataSet";
            this.dbSAICBPODataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwCatTenedoraSATableAdapter
            // 
            this.vwCatTenedoraSATableAdapter.ClearBeforeFill = true;
            // 
            // stpSelDetalleSolicitudChequesMasivosTableAdapter1
            // 
            this.stpSelDetalleSolicitudChequesMasivosTableAdapter1.ClearBeforeFill = true;
            // 
            // Solicitud
            // 
            this.Solicitud.Name = "Solicitud";
            this.Solicitud.Type = typeof(int);
            this.Solicitud.ValueInfo = "0";
            this.Solicitud.Visible = false;
            // 
            // idMatrizTenedora
            // 
            this.idMatrizTenedora.Name = "idMatrizTenedora";
            this.idMatrizTenedora.Type = typeof(int);
            this.idMatrizTenedora.ValueInfo = "0";
            this.idMatrizTenedora.Visible = false;
            // 
            // IdEmpleado
            // 
            this.IdEmpleado.Name = "IdEmpleado";
            this.IdEmpleado.Type = typeof(int);
            this.IdEmpleado.ValueInfo = "0";
            this.IdEmpleado.Visible = false;
            // 
            // stEmpleados
            // 
            this.stEmpleados.Name = "stEmpleados";
            this.stEmpleados.Visible = false;
            // 
            // stpSelCITTableAdapter1
            // 
            this.stpSelCITTableAdapter1.ClearBeforeFill = true;
            // 
            // tipoConsulta
            // 
            this.tipoConsulta.Name = "tipoConsulta";
            this.tipoConsulta.Type = typeof(int);
            this.tipoConsulta.ValueInfo = "0";
            this.tipoConsulta.Visible = false;
            // 
            // ResultadoHTML
            // 
            this.ResultadoHTML.Name = "ResultadoHTML";
            this.ResultadoHTML.Visible = false;
            // 
            // stpSelConsultaContratoEmpleadoTableAdapter1
            // 
            this.stpSelConsultaContratoEmpleadoTableAdapter1.ClearBeforeFill = true;
            // 
            // IdFirmante
            // 
            this.IdFirmante.Name = "IdFirmante";
            this.IdFirmante.Type = typeof(int);
            this.IdFirmante.ValueInfo = "0";
            this.IdFirmante.Visible = false;
            // 
            // flagConGenerico
            // 
            this.flagConGenerico.Name = "flagConGenerico";
            this.flagConGenerico.Type = typeof(bool);
            this.flagConGenerico.ValueInfo = "False";
            this.flagConGenerico.Visible = false;
            // 
            // CIT_PPP
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.DetailReport});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.dbSAICBPOCatalogosDataSet1,
            this.dbSAICBPODataSet1});
            this.Margins = new System.Drawing.Printing.Margins(50, 50, 25, 25);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.Solicitud,
            this.idMatrizTenedora,
            this.IdEmpleado,
            this.stEmpleados,
            this.tipoConsulta,
            this.ResultadoHTML,
            this.IdFirmante,
            this.flagConGenerico});
            this.Version = "17.1";
            this.DataSourceDemanded += new System.EventHandler<System.EventArgs>(this.CIT_PPP_DataSourceDemanded);
            this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.CIT_PPP_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(this.RichTextParrafo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPODataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailReportBand DetailReport;
        private DevExpress.XtraReports.UI.DetailBand Detail1;
        private DevExpress.XtraReports.UI.XRRichText RichTextParrafo1;
        private dbSAICBPOCatalogosDataSet dbSAICBPOCatalogosDataSet1;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelEstatusTableAdapter stpSelEstatusTableAdapter;
        private dbSAICBPODataSet dbSAICBPODataSet1;
        private dbSAICBPODataSetTableAdapters.vwCatTenedoraSATableAdapter vwCatTenedoraSATableAdapter;
        private Tesoreria.dbSAICBPOTesoreriaDataSetTableAdapters.stpSelDetalleSolicitudChequesMasivosTableAdapter stpSelDetalleSolicitudChequesMasivosTableAdapter1;
        public DevExpress.XtraReports.Parameters.Parameter Solicitud;
        public DevExpress.XtraReports.Parameters.Parameter idMatrizTenedora;
        public DevExpress.XtraReports.Parameters.Parameter IdEmpleado;
        public DevExpress.XtraReports.Parameters.Parameter stEmpleados;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelCITTableAdapter stpSelCITTableAdapter1;
        public DevExpress.XtraReports.Parameters.Parameter tipoConsulta;
        public DevExpress.XtraReports.Parameters.Parameter ResultadoHTML;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelConsultaContratoEmpleadoTableAdapter stpSelConsultaContratoEmpleadoTableAdapter1;
        public DevExpress.XtraReports.Parameters.Parameter IdFirmante;
        public DevExpress.XtraReports.Parameters.Parameter flagConGenerico;
    }
}
