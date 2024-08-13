namespace winAppSAIC
{
    partial class AcuseRecibosEmpleadosSueldos
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
            this.tbDetalle = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.txtNoRecibo = new DevExpress.XtraReports.UI.XRTableCell();
            this.txtNombreEmpleado = new DevExpress.XtraReports.UI.XRTableCell();
            this.txtImportePagar = new DevExpress.XtraReports.UI.XRTableCell();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.txtPeriodo = new DevExpress.XtraReports.UI.XRLabel();
            this.lblTituloPeriodo = new DevExpress.XtraReports.UI.XRLabel();
            this.tbEncabezado = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblTipoNomina = new DevExpress.XtraReports.UI.XRLabel();
            this.lblNombreComercialCliente = new DevExpress.XtraReports.UI.XRLabel();
            this.lblRazonSocialTenedora = new DevExpress.XtraReports.UI.XRLabel();
            this.lblTituloRecibos = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.lblFolioLoteCargaNomina = new DevExpress.XtraReports.UI.XRLabel();
            this.lblTituloRecibi = new DevExpress.XtraReports.UI.XRLabel();
            this.LeyendaFechaImpresion = new DevExpress.XtraReports.UI.CalculatedField();
            this.pIdLoteCargaNomina = new DevExpress.XtraReports.Parameters.Parameter();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.lblTituloTotalSueldos = new DevExpress.XtraReports.UI.XRLabel();
            this.txtTotalSueldos = new DevExpress.XtraReports.UI.XRLabel();
            this.dbSAICBPOReportesDataSet1 = new winAppSAIC.dbSAICBPOReportesDataSet();
            this.stpSelAcuseRecibosNominaSueldosSATableAdapter = new winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.stpSelAcuseRecibosNominaSueldosSATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEncabezado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOReportesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.tbDetalle});
            this.Detail.HeightF = 21F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tbDetalle
            // 
            this.tbDetalle.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tbDetalle.Font = new System.Drawing.Font("Arial", 8F);
            this.tbDetalle.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.tbDetalle.Name = "tbDetalle";
            this.tbDetalle.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.tbDetalle.SizeF = new System.Drawing.SizeF(749F, 21F);
            this.tbDetalle.StylePriority.UseBorders = false;
            this.tbDetalle.StylePriority.UseFont = false;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell4,
            this.txtNoRecibo,
            this.txtNombreEmpleado,
            this.txtImportePagar});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "stpSelAcuseRecibosNominaSueldosSA.NombreEmpleado")});
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.StylePriority.UseTextAlignment = false;
            xrSummary1.FormatString = "{0:#}";
            xrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.RecordNumber;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrTableCell4.Summary = xrSummary1;
            this.xrTableCell4.Text = "xrTableCell4";
            this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell4.Weight = 0.240848295759968D;
            // 
            // txtNoRecibo
            // 
            this.txtNoRecibo.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "stpSelAcuseRecibosNominaSueldosSA.NoRecibo")});
            this.txtNoRecibo.Name = "txtNoRecibo";
            this.txtNoRecibo.StylePriority.UseTextAlignment = false;
            this.txtNoRecibo.Text = "txtNoRecibo";
            this.txtNoRecibo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.txtNoRecibo.Weight = 0.36557328557304314D;
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "stpSelAcuseRecibosNominaSueldosSA.NombreEmpleado")});
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.txtNombreEmpleado.StylePriority.UsePadding = false;
            this.txtNombreEmpleado.StylePriority.UseTextAlignment = false;
            this.txtNombreEmpleado.Text = "txtNombreEmpleado";
            this.txtNombreEmpleado.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.txtNombreEmpleado.Weight = 2.0816176940737554D;
            // 
            // txtImportePagar
            // 
            this.txtImportePagar.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "stpSelAcuseRecibosNominaSueldosSA.MontoNetoPagar", "{0:c2}")});
            this.txtImportePagar.Name = "txtImportePagar";
            this.txtImportePagar.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100F);
            this.txtImportePagar.StylePriority.UsePadding = false;
            this.txtImportePagar.StylePriority.UseTextAlignment = false;
            this.txtImportePagar.Text = "txtImportePagar";
            this.txtImportePagar.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.txtImportePagar.Weight = 0.533306574884697D;
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.txtPeriodo,
            this.lblTituloPeriodo,
            this.tbEncabezado,
            this.lblTipoNomina,
            this.lblNombreComercialCliente,
            this.lblRazonSocialTenedora,
            this.lblTituloRecibos});
            this.TopMargin.HeightF = 158F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "stpSelAcuseRecibosNominaSueldosSA.PeriodoPago")});
            this.txtPeriodo.Font = new System.Drawing.Font("Arial", 9F);
            this.txtPeriodo.LocationFloat = new DevExpress.Utils.PointFloat(586.4584F, 99.00002F);
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
            this.lblTituloPeriodo.LocationFloat = new DevExpress.Utils.PointFloat(517.7085F, 99.00002F);
            this.lblTituloPeriodo.Name = "lblTituloPeriodo";
            this.lblTituloPeriodo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblTituloPeriodo.SizeF = new System.Drawing.SizeF(68.74997F, 23F);
            this.lblTituloPeriodo.StylePriority.UseFont = false;
            this.lblTituloPeriodo.StylePriority.UseTextAlignment = false;
            this.lblTituloPeriodo.Text = "PERIODO";
            this.lblTituloPeriodo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // tbEncabezado
            // 
            this.tbEncabezado.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.tbEncabezado.LocationFloat = new DevExpress.Utils.PointFloat(0F, 133F);
            this.tbEncabezado.Name = "tbEncabezado";
            this.tbEncabezado.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.tbEncabezado.SizeF = new System.Drawing.SizeF(749F, 25F);
            this.tbEncabezado.StylePriority.UseFont = false;
            this.tbEncabezado.StylePriority.UseTextAlignment = false;
            this.tbEncabezado.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell5,
            this.xrTableCell6,
            this.xrTableCell7,
            this.xrTableCell8});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.StylePriority.UseTextAlignment = false;
            this.xrTableCell5.Text = "NO.";
            this.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell5.Weight = 0.20976257294031425D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.StylePriority.UseTextAlignment = false;
            this.xrTableCell6.Text = "RECIBO";
            this.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell6.Weight = 0.31838962054316566D;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.StylePriority.UseTextAlignment = false;
            this.xrTableCell7.Text = "NOMBRE DEL TRABAJADOR";
            this.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell7.Weight = 1.8129482936464494D;
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.StylePriority.UseTextAlignment = false;
            this.xrTableCell8.Text = "MONTO";
            this.xrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell8.Weight = 0.46447394923337226D;
            // 
            // lblTipoNomina
            // 
            this.lblTipoNomina.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "stpSelAcuseRecibosNominaSueldosSA.DescTipoPeriodoNomina")});
            this.lblTipoNomina.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblTipoNomina.LocationFloat = new DevExpress.Utils.PointFloat(586.4584F, 78.00003F);
            this.lblTipoNomina.Name = "lblTipoNomina";
            this.lblTipoNomina.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 4, 0, 0, 100F);
            this.lblTipoNomina.SizeF = new System.Drawing.SizeF(162F, 21.00001F);
            this.lblTipoNomina.StylePriority.UseFont = false;
            this.lblTipoNomina.StylePriority.UsePadding = false;
            this.lblTipoNomina.StylePriority.UseTextAlignment = false;
            this.lblTipoNomina.Text = "lblTipoNomina";
            this.lblTipoNomina.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // lblNombreComercialCliente
            // 
            this.lblNombreComercialCliente.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "stpSelAcuseRecibosNominaSueldosSA.NombreComercialCliente")});
            this.lblNombreComercialCliente.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblNombreComercialCliente.LocationFloat = new DevExpress.Utils.PointFloat(0F, 78.00003F);
            this.lblNombreComercialCliente.Name = "lblNombreComercialCliente";
            this.lblNombreComercialCliente.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 0, 0, 100F);
            this.lblNombreComercialCliente.SizeF = new System.Drawing.SizeF(501.0418F, 23F);
            this.lblNombreComercialCliente.StylePriority.UseFont = false;
            this.lblNombreComercialCliente.StylePriority.UsePadding = false;
            this.lblNombreComercialCliente.Text = "lblNombreComercialCliente";
            // 
            // lblRazonSocialTenedora
            // 
            this.lblRazonSocialTenedora.CanGrow = false;
            this.lblRazonSocialTenedora.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "stpSelAcuseRecibosNominaSueldosSA.RazonSocialTenedora")});
            this.lblRazonSocialTenedora.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblRazonSocialTenedora.LocationFloat = new DevExpress.Utils.PointFloat(0F, 55.00002F);
            this.lblRazonSocialTenedora.Name = "lblRazonSocialTenedora";
            this.lblRazonSocialTenedora.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 0, 0, 100F);
            this.lblRazonSocialTenedora.SizeF = new System.Drawing.SizeF(739F, 23F);
            this.lblRazonSocialTenedora.StylePriority.UseFont = false;
            this.lblRazonSocialTenedora.StylePriority.UsePadding = false;
            this.lblRazonSocialTenedora.StylePriority.UseTextAlignment = false;
            this.lblRazonSocialTenedora.Text = "lblRazonSocialTenedora";
            this.lblRazonSocialTenedora.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lblTituloRecibos
            // 
            this.lblTituloRecibos.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloRecibos.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.lblTituloRecibos.BorderWidth = 3F;
            this.lblTituloRecibos.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblTituloRecibos.LocationFloat = new DevExpress.Utils.PointFloat(0F, 26F);
            this.lblTituloRecibos.Name = "lblTituloRecibos";
            this.lblTituloRecibos.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblTituloRecibos.SizeF = new System.Drawing.SizeF(749F, 23F);
            this.lblTituloRecibos.StylePriority.UseBackColor = false;
            this.lblTituloRecibos.StylePriority.UseBorders = false;
            this.lblTituloRecibos.StylePriority.UseBorderWidth = false;
            this.lblTituloRecibos.StylePriority.UseFont = false;
            this.lblTituloRecibos.StylePriority.UseTextAlignment = false;
            this.lblTituloRecibos.Text = "RELACION DE RECIBOS";
            this.lblTituloRecibos.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblFolioLoteCargaNomina,
            this.lblTituloRecibi});
            this.BottomMargin.HeightF = 110.0214F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lblFolioLoteCargaNomina
            // 
            this.lblFolioLoteCargaNomina.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "stpSelAcuseRecibosNominaSueldosSA.FolioLoteCargaNomina")});
            this.lblFolioLoteCargaNomina.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblFolioLoteCargaNomina.LocationFloat = new DevExpress.Utils.PointFloat(448.4582F, 64.99999F);
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
            this.lblTituloRecibi.BorderWidth = 2F;
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
            // LeyendaFechaImpresion
            // 
            this.LeyendaFechaImpresion.DataMember = "vwAcuseRecibosEmpleadosSueldos";
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
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblTituloTotalSueldos,
            this.txtTotalSueldos});
            this.ReportFooter.HeightF = 23F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // lblTituloTotalSueldos
            // 
            this.lblTituloTotalSueldos.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.lblTituloTotalSueldos.LocationFloat = new DevExpress.Utils.PointFloat(103.125F, 0F);
            this.lblTituloTotalSueldos.Name = "lblTituloTotalSueldos";
            this.lblTituloTotalSueldos.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 10, 0, 0, 100F);
            this.lblTituloTotalSueldos.SizeF = new System.Drawing.SizeF(521.8751F, 23F);
            this.lblTituloTotalSueldos.StylePriority.UseFont = false;
            this.lblTituloTotalSueldos.StylePriority.UsePadding = false;
            this.lblTituloTotalSueldos.StylePriority.UseTextAlignment = false;
            this.lblTituloTotalSueldos.Text = "Total Sueldos";
            this.lblTituloTotalSueldos.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // txtTotalSueldos
            // 
            this.txtTotalSueldos.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "stpSelAcuseRecibosNominaSueldosSA.MontoNetoPagar")});
            this.txtTotalSueldos.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.txtTotalSueldos.LocationFloat = new DevExpress.Utils.PointFloat(625.0001F, 0F);
            this.txtTotalSueldos.Name = "txtTotalSueldos";
            this.txtTotalSueldos.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtTotalSueldos.SizeF = new System.Drawing.SizeF(123.4581F, 23F);
            this.txtTotalSueldos.StylePriority.UseFont = false;
            this.txtTotalSueldos.StylePriority.UseTextAlignment = false;
            xrSummary2.FormatString = "{0:c2}";
            xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.txtTotalSueldos.Summary = xrSummary2;
            this.txtTotalSueldos.Text = "txtTotalSueldos";
            this.txtTotalSueldos.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // dbSAICBPOReportesDataSet1
            // 
            this.dbSAICBPOReportesDataSet1.DataSetName = "dbSAICBPOReportesDataSet";
            this.dbSAICBPOReportesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stpSelAcuseRecibosNominaSueldosSATableAdapter
            // 
            this.stpSelAcuseRecibosNominaSueldosSATableAdapter.ClearBeforeFill = true;
            // 
            // AcuseRecibosEmpleadosSueldos
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportFooter});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.LeyendaFechaImpresion});
            this.DataAdapter = this.stpSelAcuseRecibosNominaSueldosSATableAdapter;
            this.DataMember = "stpSelAcuseRecibosNominaSueldosSA";
            this.DataSource = this.dbSAICBPOReportesDataSet1;
            this.Margins = new System.Drawing.Printing.Margins(48, 53, 158, 110);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.pIdLoteCargaNomina});
            this.Version = "14.1";
            this.DataSourceDemanded += new System.EventHandler<System.EventArgs>(this.AcuseRecibosEmpleadosSueldos_DataSourceDemanded);
            ((System.ComponentModel.ISupportInitialize)(this.tbDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEncabezado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOReportesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRLabel lblTituloRecibos;
        private DevExpress.XtraReports.UI.XRTable tbDetalle;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell txtNoRecibo;
        private DevExpress.XtraReports.UI.XRTableCell txtNombreEmpleado;
        private DevExpress.XtraReports.UI.XRTableCell txtImportePagar;
        private DevExpress.XtraReports.UI.XRLabel lblNombreComercialCliente;
        private DevExpress.XtraReports.UI.XRLabel lblRazonSocialTenedora;
        private DevExpress.XtraReports.UI.XRLabel lblTipoNomina;
        private DevExpress.XtraReports.UI.CalculatedField LeyendaFechaImpresion;
        private DevExpress.XtraReports.UI.XRTable tbEncabezado;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell7;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell8;
        private DevExpress.XtraReports.UI.XRLabel lblTituloPeriodo;
        private DevExpress.XtraReports.UI.XRLabel txtPeriodo;
        private DevExpress.XtraReports.UI.XRLabel lblTituloRecibi;
        private DevExpress.XtraReports.Parameters.Parameter pIdLoteCargaNomina;
        private DevExpress.XtraReports.UI.XRLabel lblFolioLoteCargaNomina;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRLabel txtTotalSueldos;
        private DevExpress.XtraReports.UI.XRLabel lblTituloTotalSueldos;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
        private dbSAICBPOReportesDataSet dbSAICBPOReportesDataSet1;
        private dbSAICBPOReportesDataSetTableAdapters.stpSelAcuseRecibosNominaSueldosSATableAdapter stpSelAcuseRecibosNominaSueldosSATableAdapter;
    }
}
