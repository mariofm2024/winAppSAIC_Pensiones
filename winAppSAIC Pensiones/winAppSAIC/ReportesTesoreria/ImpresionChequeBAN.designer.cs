namespace winAppSAIC.ReportesTesoreria
{
    partial class ImpresionChequeBAN
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
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.pIdTransaccionBanco = new DevExpress.XtraReports.Parameters.Parameter();
            this.formattingRule1 = new DevExpress.XtraReports.UI.FormattingRule();
            this.dbSAICBPOTesoreriaDataSet1 = new winAppSAIC.Tesoreria.dbSAICBPOTesoreriaDataSet();
            this.stpSelImpresionChequeTableAdapter = new winAppSAIC.Tesoreria.dbSAICBPOTesoreriaDataSetTableAdapters.stpSelImpresionChequeTableAdapter();
            this.pIdTransaccionBancoFinal = new DevExpress.XtraReports.Parameters.Parameter();
            this.pIdCuentaBanco = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOTesoreriaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel4,
            this.xrLabel3,
            this.xrLabel2,
            this.xrLabel1});
            this.Detail.Dpi = 254F;
            this.Detail.HeightF = 391.555F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand;
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel4
            // 
            this.xrLabel4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "stpSelImpresionCheque.MontoTransaccion", "{0:n2}")});
            this.xrLabel4.Dpi = 254F;
            this.xrLabel4.Font = new System.Drawing.Font("Arial Narrow", 8.25F);
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(1238.25F, 84.58002F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(269.8744F, 58.41999F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "xrLabel4";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel3
            // 
            this.xrLabel3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "stpSelImpresionCheque.NombreBeneficiarioTransaccionBanco")});
            this.xrLabel3.Dpi = 254F;
            this.xrLabel3.Font = new System.Drawing.Font("Arial Narrow", 8.25F);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(269.875F, 162.1526F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(941.9165F, 58.42F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.Text = "xrLabel3";
            // 
            // xrLabel2
            // 
            this.xrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "stpSelImpresionCheque.MontoConLetra")});
            this.xrLabel2.Dpi = 254F;
            this.xrLabel2.Font = new System.Drawing.Font("Arial Narrow", 8.25F);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(103.1875F, 244.5725F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(1293.813F, 58.41998F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.Text = "xrLabel2";
            // 
            // xrLabel1
            // 
            this.xrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "stpSelImpresionCheque.FechaTexto")});
            this.xrLabel1.Dpi = 254F;
            this.xrLabel1.Font = new System.Drawing.Font("Arial Narrow", 8.25F);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(771.208F, 84.58002F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(391.5834F, 58.42F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "xrLabel1";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Dpi = 254F;
            this.BottomMargin.HeightF = 101F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.Dpi = 254F;
            this.TopMargin.HeightF = 158.6458F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // pIdTransaccionBanco
            // 
            this.pIdTransaccionBanco.Description = "Id Transaccion Banco";
            this.pIdTransaccionBanco.Name = "pIdTransaccionBanco";
            this.pIdTransaccionBanco.Type = typeof(long);
            this.pIdTransaccionBanco.ValueInfo = "0";
            this.pIdTransaccionBanco.Visible = false;
            // 
            // formattingRule1
            // 
            this.formattingRule1.Name = "formattingRule1";
            // 
            // dbSAICBPOTesoreriaDataSet1
            // 
            this.dbSAICBPOTesoreriaDataSet1.DataSetName = "dbSAICBPOTesoreriaDataSet";
            this.dbSAICBPOTesoreriaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stpSelImpresionChequeTableAdapter
            // 
            this.stpSelImpresionChequeTableAdapter.ClearBeforeFill = true;
            // 
            // pIdTransaccionBancoFinal
            // 
            this.pIdTransaccionBancoFinal.Description = "Id Transaccion Banco Final";
            this.pIdTransaccionBancoFinal.Name = "pIdTransaccionBancoFinal";
            this.pIdTransaccionBancoFinal.Type = typeof(long);
            this.pIdTransaccionBancoFinal.ValueInfo = "0";
            this.pIdTransaccionBancoFinal.Visible = false;
            // 
            // pIdCuentaBanco
            // 
            this.pIdCuentaBanco.Description = "Id Cuenta Banco";
            this.pIdCuentaBanco.Name = "pIdCuentaBanco";
            this.pIdCuentaBanco.Type = typeof(int);
            this.pIdCuentaBanco.ValueInfo = "0";
            this.pIdCuentaBanco.Visible = false;
            // 
            // ImpresionChequeBAN
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
            this.DataAdapter = this.stpSelImpresionChequeTableAdapter;
            this.DataMember = "stpSelImpresionCheque";
            this.DataSource = this.dbSAICBPOTesoreriaDataSet1;
            this.Dpi = 254F;
            this.FormattingRuleSheet.AddRange(new DevExpress.XtraReports.UI.FormattingRule[] {
            this.formattingRule1});
            this.Margins = new System.Drawing.Printing.Margins(254, 254, 159, 101);
            this.PageHeight = 2794;
            this.PageWidth = 2159;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.pIdTransaccionBanco,
            this.pIdTransaccionBancoFinal,
            this.pIdCuentaBanco});
            this.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter;
            this.SnapGridSize = 25F;
            this.Version = "16.1";
            this.DataSourceDemanded += new System.EventHandler<System.EventArgs>(this.ImpresionChequeBAN_DataSourceDemanded);
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOTesoreriaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.Parameters.Parameter pIdTransaccionBanco;
        private DevExpress.XtraReports.UI.FormattingRule formattingRule1;
        private Tesoreria.dbSAICBPOTesoreriaDataSet dbSAICBPOTesoreriaDataSet1;
        private Tesoreria.dbSAICBPOTesoreriaDataSetTableAdapters.stpSelImpresionChequeTableAdapter stpSelImpresionChequeTableAdapter;
        private DevExpress.XtraReports.Parameters.Parameter pIdTransaccionBancoFinal;
        private DevExpress.XtraReports.Parameters.Parameter pIdCuentaBanco;



    }
}
