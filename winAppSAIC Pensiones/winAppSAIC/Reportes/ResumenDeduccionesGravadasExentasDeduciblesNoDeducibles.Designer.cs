namespace winAppSAIC.Reportes
{
    partial class ResumenDeduccionesGravadasExentasDeduciblesNoDeducibles
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
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.dbSAICBPOReportesDataSet1 = new winAppSAIC.dbSAICBPOReportesDataSet();
            this.pDOHeaderSATableAdapter = new winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.PDOHeaderSATableAdapter();
            this.stpSelDeduccionesGravadoExentoRecibosEmpleadosSATableAdapter1 = new winAppSAIC.NominaCFDI.dbSAICBPONominaCFDIDataSetTableAdapters.stpSelDeduccionesGravadoExentoRecibosEmpleadosSATableAdapter();
            this.pIdLoteCargaNomina = new DevExpress.XtraReports.Parameters.Parameter();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.stpSelResumenDeduccionesGravadasExentasDeduciblesNoDeduciblesTableAdapter1 = new winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.stpSelResumenDeduccionesGravadasExentasDeduciblesNoDeduciblesTableAdapter();
            this.xrControlStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOReportesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.Detail.HeightF = 15F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTable1
            // 
            this.xrTable1.Font = new System.Drawing.Font("Arial", 9F);
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.OddStyleName = "xrControlStyle1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(320F, 15F);
            this.xrTable1.StylePriority.UseFont = false;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "stpSelResumenDeduccionesGravadasExentasDeduciblesNoDeducibles.Concepto")});
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Text = "xrTableCell1";
            this.xrTableCell1.Weight = 0.7441821191659086D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "stpSelResumenDeduccionesGravadasExentasDeduciblesNoDeducibles.ImporteTotal", "{0:N2}")});
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.StylePriority.UseTextAlignment = false;
            this.xrTableCell2.Text = "xrTableCell2";
            this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell2.Weight = 0.44650925333103675D;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 22.91667F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 28.125F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // dbSAICBPOReportesDataSet1
            // 
            this.dbSAICBPOReportesDataSet1.DataSetName = "dbSAICBPOReportesDataSet";
            this.dbSAICBPOReportesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pDOHeaderSATableAdapter
            // 
            this.pDOHeaderSATableAdapter.ClearBeforeFill = true;
            // 
            // stpSelDeduccionesGravadoExentoRecibosEmpleadosSATableAdapter1
            // 
            this.stpSelDeduccionesGravadoExentoRecibosEmpleadosSATableAdapter1.ClearBeforeFill = true;
            // 
            // pIdLoteCargaNomina
            // 
            this.pIdLoteCargaNomina.Description = "IdLoteCargaNomina";
            this.pIdLoteCargaNomina.Name = "pIdLoteCargaNomina";
            this.pIdLoteCargaNomina.Type = typeof(int);
            this.pIdLoteCargaNomina.ValueInfo = "0";
            this.pIdLoteCargaNomina.Visible = false;
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2});
            this.ReportFooter.HeightF = 26.04167F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // xrTable2
            // 
            this.xrTable2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(2.083333F, 1.041667F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTable2.SizeF = new System.Drawing.SizeF(320F, 25F);
            this.xrTable2.StylePriority.UseFont = false;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell3,
            this.xrTableCell4});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.StylePriority.UseTextAlignment = false;
            this.xrTableCell3.Text = "Total Deducciones >>";
            this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell3.Weight = 2D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.xrTableCell4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "stpSelResumenDeduccionesGravadasExentasDeduciblesNoDeducibles.ImporteTotal")});
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.StylePriority.UseBorders = false;
            this.xrTableCell4.StylePriority.UseTextAlignment = false;
            xrSummary1.FormatString = "{0:N2}";
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrTableCell4.Summary = xrSummary1;
            this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell4.Weight = 1.2000000000000002D;
            // 
            // stpSelResumenDeduccionesGravadasExentasDeduciblesNoDeduciblesTableAdapter1
            // 
            this.stpSelResumenDeduccionesGravadasExentasDeduciblesNoDeduciblesTableAdapter1.ClearBeforeFill = true;
            // 
            // xrControlStyle1
            // 
            this.xrControlStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.xrControlStyle1.Name = "xrControlStyle1";
            this.xrControlStyle1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            // 
            // ResumenDeduccionesGravadasExentasDeduciblesNoDeducibles
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportFooter});
            this.DataAdapter = this.stpSelResumenDeduccionesGravadasExentasDeduciblesNoDeduciblesTableAdapter1;
            this.DataMember = "stpSelResumenDeduccionesGravadasExentasDeduciblesNoDeducibles";
            this.DataSource = this.dbSAICBPOReportesDataSet1;
            this.Margins = new System.Drawing.Printing.Margins(36, 65, 23, 28);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.pIdLoteCargaNomina});
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.xrControlStyle1});
            this.Version = "14.1";
            this.DataSourceDemanded += new System.EventHandler<System.EventArgs>(this.ResumenDeduccionesGravadasExentasDeduciblesNoDeducibles_DataSourceDemanded);
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOReportesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private dbSAICBPOReportesDataSet dbSAICBPOReportesDataSet1;
        private dbSAICBPOReportesDataSetTableAdapters.PDOHeaderSATableAdapter pDOHeaderSATableAdapter;
        private NominaCFDI.dbSAICBPONominaCFDIDataSetTableAdapters.stpSelDeduccionesGravadoExentoRecibosEmpleadosSATableAdapter stpSelDeduccionesGravadoExentoRecibosEmpleadosSATableAdapter1;
        public DevExpress.XtraReports.Parameters.Parameter pIdLoteCargaNomina;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRTable xrTable2;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private dbSAICBPOReportesDataSetTableAdapters.stpSelResumenDeduccionesGravadasExentasDeduciblesNoDeduciblesTableAdapter stpSelResumenDeduccionesGravadasExentasDeduciblesNoDeduciblesTableAdapter1;
        private DevExpress.XtraReports.UI.XRControlStyle xrControlStyle1;
    }
}
