namespace winAppSAIC
{
    partial class AcuseChequesNominaSueldos
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
            DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.txtPeriodo = new DevExpress.XtraReports.UI.XRLabel();
            this.lblTituloPeriodo = new DevExpress.XtraReports.UI.XRLabel();
            this.lblTipoNomina = new DevExpress.XtraReports.UI.XRLabel();
            this.lblNombreComercialCliente = new DevExpress.XtraReports.UI.XRLabel();
            this.lblRazonSocialTenedora = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblTituloRecibos = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.lblFolioLoteCargaNomina = new DevExpress.XtraReports.UI.XRLabel();
            this.lblTituloRecibi = new DevExpress.XtraReports.UI.XRLabel();
            this.dbSAICBPOReportesDataSet1 = new winAppSAIC.dbSAICBPOReportesDataSet();
            this.stpSelAcuseChequesNominaSueldosSATableAdapter = new winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.stpSelAcuseChequesNominaSueldosSATableAdapter();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.txtTotalSueldos = new DevExpress.XtraReports.UI.XRLabel();
            this.lblTituloTotalSueldos = new DevExpress.XtraReports.UI.XRLabel();
            this.LeyendaFechaImpresion = new DevExpress.XtraReports.UI.CalculatedField();
            this.pIdLoteCargaNomina = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOReportesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2});
            this.Detail.HeightF = 21F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTable2
            // 
            this.xrTable2.Font = new System.Drawing.Font("Arial", 8F);
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTable2.SizeF = new System.Drawing.SizeF(749F, 21F);
            this.xrTable2.StylePriority.UseFont = false;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell4,
            this.xrTableCell5,
            this.xrTableCell6,
            this.xrTableCell8,
            this.xrTableCell10});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "stpSelAcuseChequesNominaSueldosSA.NoRecibo")});
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.StylePriority.UseBorders = false;
            this.xrTableCell4.StylePriority.UseTextAlignment = false;
            xrSummary1.FormatString = "{0:#}";
            xrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.RecordNumber;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrTableCell4.Summary = xrSummary1;
            this.xrTableCell4.Text = "xrTableCell4";
            this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell4.Weight = 0.22429904504834564D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell5.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "stpSelAcuseChequesNominaSueldosSA.NoRecibo")});
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.StylePriority.UseBorders = false;
            this.xrTableCell5.StylePriority.UseTextAlignment = false;
            this.xrTableCell5.Text = "xrTableCell5";
            this.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell5.Weight = 0.34045391821256454D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell6.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "stpSelAcuseChequesNominaSueldosSA.NombreEmpleado")});
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.xrTableCell6.StylePriority.UseBorders = false;
            this.xrTableCell6.StylePriority.UsePadding = false;
            this.xrTableCell6.StylePriority.UseTextAlignment = false;
            this.xrTableCell6.Text = "xrTableCell6";
            this.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell6.Weight = 1.6481976171679424D;
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell8.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "stpSelAcuseChequesNominaSueldosSA.MontoNetoPagar", "{0:c2}")});
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100F);
            this.xrTableCell8.StylePriority.UseBorders = false;
            this.xrTableCell8.StylePriority.UsePadding = false;
            this.xrTableCell8.StylePriority.UseTextAlignment = false;
            this.xrTableCell8.Text = "xrTableCell8";
            this.xrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell8.Weight = 0.44058746011935185D;
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.txtPeriodo,
            this.lblTituloPeriodo,
            this.lblTipoNomina,
            this.lblNombreComercialCliente,
            this.lblRazonSocialTenedora,
            this.xrTable1,
            this.lblTituloRecibos});
            this.TopMargin.HeightF = 158F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "stpSelAcuseChequesNominaSueldosSA.PeriodoPago")});
            this.txtPeriodo.Font = new System.Drawing.Font("Arial", 9F);
            this.txtPeriodo.LocationFloat = new DevExpress.Utils.PointFloat(586.46F, 99F);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtPeriodo.SizeF = new System.Drawing.SizeF(162F, 23F);
            this.txtPeriodo.StylePriority.UseFont = false;
            this.txtPeriodo.StylePriority.UseTextAlignment = false;
            this.txtPeriodo.Text = "txtPeriodo";
            this.txtPeriodo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // lblTituloPeriodo
            // 
            this.lblTituloPeriodo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblTituloPeriodo.LocationFloat = new DevExpress.Utils.PointFloat(517.71F, 99F);
            this.lblTituloPeriodo.Name = "lblTituloPeriodo";
            this.lblTituloPeriodo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblTituloPeriodo.SizeF = new System.Drawing.SizeF(68.74997F, 23F);
            this.lblTituloPeriodo.StylePriority.UseFont = false;
            this.lblTituloPeriodo.StylePriority.UseTextAlignment = false;
            this.lblTituloPeriodo.Text = "PERIODO";
            this.lblTituloPeriodo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // lblTipoNomina
            // 
            this.lblTipoNomina.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "stpSelAcuseChequesNominaSueldosSA.DescTipoPeriodoNomina")});
            this.lblTipoNomina.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblTipoNomina.LocationFloat = new DevExpress.Utils.PointFloat(586.46F, 78F);
            this.lblTipoNomina.Name = "lblTipoNomina";
            this.lblTipoNomina.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblTipoNomina.SizeF = new System.Drawing.SizeF(162F, 21F);
            this.lblTipoNomina.StylePriority.UseFont = false;
            this.lblTipoNomina.StylePriority.UseTextAlignment = false;
            this.lblTipoNomina.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // lblNombreComercialCliente
            // 
            this.lblNombreComercialCliente.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "stpSelAcuseChequesNominaSueldosSA.NombreComercialCliente")});
            this.lblNombreComercialCliente.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblNombreComercialCliente.LocationFloat = new DevExpress.Utils.PointFloat(0F, 78F);
            this.lblNombreComercialCliente.Name = "lblNombreComercialCliente";
            this.lblNombreComercialCliente.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblNombreComercialCliente.SizeF = new System.Drawing.SizeF(501.04F, 23F);
            this.lblNombreComercialCliente.StylePriority.UseFont = false;
            // 
            // lblRazonSocialTenedora
            // 
            this.lblRazonSocialTenedora.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "stpSelAcuseChequesNominaSueldosSA.RazonSocialTenedora")});
            this.lblRazonSocialTenedora.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblRazonSocialTenedora.LocationFloat = new DevExpress.Utils.PointFloat(0F, 55F);
            this.lblRazonSocialTenedora.Name = "lblRazonSocialTenedora";
            this.lblRazonSocialTenedora.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblRazonSocialTenedora.SizeF = new System.Drawing.SizeF(739F, 23F);
            this.lblRazonSocialTenedora.StylePriority.UseFont = false;
            this.lblRazonSocialTenedora.StylePriority.UseTextAlignment = false;
            this.lblRazonSocialTenedora.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrTable1
            // 
            this.xrTable1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 133F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(748.9999F, 25F);
            this.xrTable1.StylePriority.UseFont = false;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell3,
            this.xrTableCell7,
            this.xrTableCell9});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.StylePriority.UseTextAlignment = false;
            this.xrTableCell1.Text = "NO.";
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell1.Weight = 0.22400001314290471D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.StylePriority.UseTextAlignment = false;
            this.xrTableCell2.Text = "RECIBO";
            this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell2.Weight = 0.34000005310059012D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.StylePriority.UseTextAlignment = false;
            this.xrTableCell3.Text = "NOMBRE DEL TRABAJADOR";
            this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell3.Weight = 1.6460002527354649D;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.StylePriority.UseTextAlignment = false;
            this.xrTableCell7.Text = "MONTO";
            this.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell7.Weight = 0.44000006162568894D;
            // 
            // lblTituloRecibos
            // 
            this.lblTituloRecibos.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloRecibos.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.lblTituloRecibos.BorderWidth = 3;
            this.lblTituloRecibos.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblTituloRecibos.LocationFloat = new DevExpress.Utils.PointFloat(0F, 32F);
            this.lblTituloRecibos.Name = "lblTituloRecibos";
            this.lblTituloRecibos.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblTituloRecibos.SizeF = new System.Drawing.SizeF(749F, 23F);
            this.lblTituloRecibos.StylePriority.UseBackColor = false;
            this.lblTituloRecibos.StylePriority.UseBorders = false;
            this.lblTituloRecibos.StylePriority.UseBorderWidth = false;
            this.lblTituloRecibos.StylePriority.UseFont = false;
            this.lblTituloRecibos.StylePriority.UseTextAlignment = false;
            this.lblTituloRecibos.Text = "RELACION DE CHEQUES SUELDOS";
            this.lblTituloRecibos.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblFolioLoteCargaNomina,
            this.lblTituloRecibi});
            this.BottomMargin.Font = new System.Drawing.Font("Arial", 9.75F);
            this.BottomMargin.HeightF = 110F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.StylePriority.UseFont = false;
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lblFolioLoteCargaNomina
            // 
            this.lblFolioLoteCargaNomina.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "stpSelAcuseChequesNominaSueldosSA.FolioLoteCargaNomina")});
            this.lblFolioLoteCargaNomina.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblFolioLoteCargaNomina.LocationFloat = new DevExpress.Utils.PointFloat(448.46F, 65F);
            this.lblFolioLoteCargaNomina.Name = "lblFolioLoteCargaNomina";
            this.lblFolioLoteCargaNomina.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblFolioLoteCargaNomina.SizeF = new System.Drawing.SizeF(300F, 23F);
            this.lblFolioLoteCargaNomina.StylePriority.UseFont = false;
            this.lblFolioLoteCargaNomina.StylePriority.UseTextAlignment = false;
            this.lblFolioLoteCargaNomina.Text = "lblFolioLoteCargaNomina";
            this.lblFolioLoteCargaNomina.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // lblTituloRecibi
            // 
            this.lblTituloRecibi.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.lblTituloRecibi.BorderWidth = 2;
            this.lblTituloRecibi.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblTituloRecibi.LocationFloat = new DevExpress.Utils.PointFloat(195F, 46F);
            this.lblTituloRecibi.Name = "lblTituloRecibi";
            this.lblTituloRecibi.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblTituloRecibi.SizeF = new System.Drawing.SizeF(322.8334F, 18.99999F);
            this.lblTituloRecibi.StylePriority.UseBorders = false;
            this.lblTituloRecibi.StylePriority.UseBorderWidth = false;
            this.lblTituloRecibi.StylePriority.UseFont = false;
            this.lblTituloRecibi.StylePriority.UseTextAlignment = false;
            this.lblTituloRecibi.Text = "RECIBI";
            this.lblTituloRecibi.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // dbSAICBPOReportesDataSet1
            // 
            this.dbSAICBPOReportesDataSet1.DataSetName = "dbSAICBPOReportesDataSet";
            this.dbSAICBPOReportesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stpSelAcuseChequesNominaSueldosSATableAdapter
            // 
            this.stpSelAcuseChequesNominaSueldosSATableAdapter.ClearBeforeFill = true;
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.txtTotalSueldos,
            this.lblTituloTotalSueldos});
            this.ReportFooter.HeightF = 23F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // txtTotalSueldos
            // 
            this.txtTotalSueldos.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "stpSelAcuseChequesNominaSueldosSA.MontoNetoPagar")});
            this.txtTotalSueldos.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.txtTotalSueldos.LocationFloat = new DevExpress.Utils.PointFloat(552.4999F, 0F);
            this.txtTotalSueldos.Name = "txtTotalSueldos";
            this.txtTotalSueldos.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtTotalSueldos.SizeF = new System.Drawing.SizeF(110.0001F, 23F);
            this.txtTotalSueldos.StylePriority.UseFont = false;
            this.txtTotalSueldos.StylePriority.UseTextAlignment = false;
            xrSummary2.FormatString = "{0:c2}";
            xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.txtTotalSueldos.Summary = xrSummary2;
            this.txtTotalSueldos.Text = "txtTotalSueldos";
            this.txtTotalSueldos.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // lblTituloTotalSueldos
            // 
            this.lblTituloTotalSueldos.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.lblTituloTotalSueldos.LocationFloat = new DevExpress.Utils.PointFloat(103.12F, 0F);
            this.lblTituloTotalSueldos.Name = "lblTituloTotalSueldos";
            this.lblTituloTotalSueldos.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 10, 0, 0, 100F);
            this.lblTituloTotalSueldos.SizeF = new System.Drawing.SizeF(449.3799F, 23F);
            this.lblTituloTotalSueldos.StylePriority.UseFont = false;
            this.lblTituloTotalSueldos.StylePriority.UsePadding = false;
            this.lblTituloTotalSueldos.StylePriority.UseTextAlignment = false;
            this.lblTituloTotalSueldos.Text = "Total Sueldos";
            this.lblTituloTotalSueldos.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // LeyendaFechaImpresion
            // 
            this.LeyendaFechaImpresion.DataMember = "stpSelAcuseChequesNominaSueldosSA";
            this.LeyendaFechaImpresion.Expression = "\'Fecha de Impresión: \' + ToStr(Now())";
            this.LeyendaFechaImpresion.Name = "LeyendaFechaImpresion";
            // 
            // pIdLoteCargaNomina
            // 
            this.pIdLoteCargaNomina.Description = "LoteCargaNomina";
            this.pIdLoteCargaNomina.Name = "pIdLoteCargaNomina";
            this.pIdLoteCargaNomina.Type = typeof(int);
            this.pIdLoteCargaNomina.ValueInfo = "0";
            this.pIdLoteCargaNomina.Visible = false;
            // 
            // xrTableCell9
            // 
            this.xrTableCell9.Name = "xrTableCell9";
            this.xrTableCell9.StylePriority.UseTextAlignment = false;
            this.xrTableCell9.Text = "NO. CHEQUE";
            this.xrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell9.Weight = 0.34599961906983068D;
            // 
            // xrTableCell10
            // 
            this.xrTableCell10.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell10.Name = "xrTableCell10";
            this.xrTableCell10.StylePriority.UseBorders = false;
            this.xrTableCell10.Weight = 0.34646195945179514D;
            // 
            // AcuseChequesNominaSueldos
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportFooter});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.LeyendaFechaImpresion});
            this.DataMember = "stpSelAcuseChequesNominaSueldosSA";
            this.DataSource = this.dbSAICBPOReportesDataSet1;
            this.Margins = new System.Drawing.Printing.Margins(50, 50, 158, 110);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.pIdLoteCargaNomina});
            this.Version = "13.1";
            this.DataSourceDemanded += new System.EventHandler<System.EventArgs>(this.AcuseChequesNominaSueldosSA_DataSourceDemanded);
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOReportesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private dbSAICBPOReportesDataSet dbSAICBPOReportesDataSet1;
        private dbSAICBPOReportesDataSetTableAdapters.stpSelAcuseChequesNominaSueldosSATableAdapter stpSelAcuseChequesNominaSueldosSATableAdapter;
        private DevExpress.XtraReports.UI.XRLabel lblTituloRecibos;
        private DevExpress.XtraReports.UI.XRLabel lblTituloRecibi;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRLabel lblTituloTotalSueldos;
        private DevExpress.XtraReports.UI.XRTable xrTable2;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell7;
        private DevExpress.XtraReports.UI.XRLabel lblRazonSocialTenedora;
        private DevExpress.XtraReports.UI.XRLabel lblNombreComercialCliente;
        private DevExpress.XtraReports.UI.XRLabel lblTipoNomina;
        private DevExpress.XtraReports.UI.XRLabel lblTituloPeriodo;
        private DevExpress.XtraReports.UI.XRLabel txtPeriodo;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell8;
        private DevExpress.XtraReports.UI.CalculatedField LeyendaFechaImpresion;
        private DevExpress.XtraReports.UI.XRLabel lblFolioLoteCargaNomina;
        private DevExpress.XtraReports.UI.XRLabel txtTotalSueldos;
        private DevExpress.XtraReports.Parameters.Parameter pIdLoteCargaNomina;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell10;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell9;
    }
}
