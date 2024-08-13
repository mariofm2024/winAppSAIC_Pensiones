namespace winAppSAIC
{
    partial class AcuseRecibosEmpleadosAlimentos
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
            DevExpress.XtraReports.UI.XRSummary xrSummary3 = new DevExpress.XtraReports.UI.XRSummary();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.tbDetalle = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.txtNoRecibo = new DevExpress.XtraReports.UI.XRTableCell();
            this.txtNombreAsociado = new DevExpress.XtraReports.UI.XRTableCell();
            this.txtImporteAlimentosBruto = new DevExpress.XtraReports.UI.XRTableCell();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.tbEncabezado = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.txtPeriodo = new DevExpress.XtraReports.UI.XRLabel();
            this.lblTituloPeriodo = new DevExpress.XtraReports.UI.XRLabel();
            this.lblTipoNomina = new DevExpress.XtraReports.UI.XRLabel();
            this.lblNombreComercialCliente = new DevExpress.XtraReports.UI.XRLabel();
            this.lblRazonSocialTenedora = new DevExpress.XtraReports.UI.XRLabel();
            this.lblTituloRecibos = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.lblFolioLoteCargaNomina = new DevExpress.XtraReports.UI.XRLabel();
            this.lblTituloRecibi = new DevExpress.XtraReports.UI.XRLabel();
            this.LeyendaFechaImpresion = new DevExpress.XtraReports.UI.CalculatedField();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.lblTituloTotalAlimentosBruto = new DevExpress.XtraReports.UI.XRLabel();
            this.txtTotalAlimentosBruto = new DevExpress.XtraReports.UI.XRLabel();
            this.dbSAICBPOReportesDataSet1 = new winAppSAIC.dbSAICBPOReportesDataSet();
            this.stpSelAcuseRecibosNominaAlimentosSCTableAdapter = new winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.stpSelAcuseRecibosNominaAlimentosSCTableAdapter();
            this.pIdLoteCargaNomina = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this.tbDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEncabezado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOReportesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.tbDetalle});
            this.Detail.Dpi = 100F;
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
            this.tbDetalle.Dpi = 100F;
            this.tbDetalle.Font = new System.Drawing.Font("Arial", 8F);
            this.tbDetalle.LocationFloat = new DevExpress.Utils.PointFloat(2.167442E-05F, 0F);
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
            this.xrTableCell2,
            this.txtNoRecibo,
            this.txtNombreAsociado,
            this.txtImporteAlimentosBruto});
            this.xrTableRow1.Dpi = 100F;
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "stpSelAcuseRecibosNominaAlimentosSC.NombreEmpleado")});
            this.xrTableCell2.Dpi = 100F;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.StylePriority.UseTextAlignment = false;
            xrSummary1.FormatString = "{0:#}";
            xrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.RecordNumber;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrTableCell2.Summary = xrSummary1;
            this.xrTableCell2.Text = "xrTableCell2";
            this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell2.Weight = 0.25846151419194019D;
            // 
            // txtNoRecibo
            // 
            this.txtNoRecibo.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "stpSelAcuseRecibosNominaAlimentosSC.NoRecibo")});
            this.txtNoRecibo.Dpi = 100F;
            this.txtNoRecibo.Name = "txtNoRecibo";
            this.txtNoRecibo.StylePriority.UseTextAlignment = false;
            this.txtNoRecibo.Text = "txtNoRecibo";
            this.txtNoRecibo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.txtNoRecibo.Weight = 0.39230765546990914D;
            // 
            // txtNombreAsociado
            // 
            this.txtNombreAsociado.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "stpSelAcuseRecibosNominaAlimentosSC.NombreEmpleado")});
            this.txtNombreAsociado.Dpi = 100F;
            this.txtNombreAsociado.Name = "txtNombreAsociado";
            this.txtNombreAsociado.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.txtNombreAsociado.StylePriority.UsePadding = false;
            this.txtNombreAsociado.StylePriority.UseTextAlignment = false;
            this.txtNombreAsociado.Text = "txtNombreAsociado";
            this.txtNombreAsociado.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.txtNombreAsociado.Weight = 2.233847211740609D;
            // 
            // txtImporteAlimentosBruto
            // 
            this.txtImporteAlimentosBruto.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "stpSelAcuseRecibosNominaAlimentosSC.MontoNetoPagar", "{0:c2}")});
            this.txtImporteAlimentosBruto.Dpi = 100F;
            this.txtImporteAlimentosBruto.Name = "txtImporteAlimentosBruto";
            this.txtImporteAlimentosBruto.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100F);
            this.txtImporteAlimentosBruto.StylePriority.UsePadding = false;
            this.txtImporteAlimentosBruto.StylePriority.UseTextAlignment = false;
            this.txtImporteAlimentosBruto.Text = "txtImporteAlimentosBruto";
            this.txtImporteAlimentosBruto.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.txtImporteAlimentosBruto.Weight = 0.57230637091474124D;
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.tbEncabezado,
            this.txtPeriodo,
            this.lblTituloPeriodo,
            this.lblTipoNomina,
            this.lblNombreComercialCliente,
            this.lblRazonSocialTenedora,
            this.lblTituloRecibos});
            this.TopMargin.Dpi = 100F;
            this.TopMargin.HeightF = 158F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tbEncabezado
            // 
            this.tbEncabezado.Dpi = 100F;
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
            this.xrTableCell1,
            this.xrTableCell6,
            this.xrTableCell7,
            this.xrTableCell8});
            this.xrTableRow2.Dpi = 100F;
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Dpi = 100F;
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.StylePriority.UseTextAlignment = false;
            this.xrTableCell1.Text = "NO.";
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell1.Weight = 0.22510250826774703D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.Dpi = 100F;
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.StylePriority.UseTextAlignment = false;
            this.xrTableCell6.Text = "RECIBO";
            this.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell6.Weight = 0.341673449262977D;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.Dpi = 100F;
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.StylePriority.UseTextAlignment = false;
            this.xrTableCell7.Text = "NOMBRE DEL EMPLEADO";
            this.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell7.Weight = 1.9455295925577072D;
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.Dpi = 100F;
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.StylePriority.UseTextAlignment = false;
            this.xrTableCell8.Text = "MONTO";
            this.xrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell8.Weight = 0.49844047768492222D;
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "stpSelAcuseRecibosNominaAlimentosSC.PeriodoPago")});
            this.txtPeriodo.Dpi = 100F;
            this.txtPeriodo.Font = new System.Drawing.Font("Arial", 9F);
            this.txtPeriodo.LocationFloat = new DevExpress.Utils.PointFloat(586F, 101F);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtPeriodo.SizeF = new System.Drawing.SizeF(163F, 23F);
            this.txtPeriodo.StylePriority.UseFont = false;
            this.txtPeriodo.StylePriority.UseTextAlignment = false;
            this.txtPeriodo.Text = "txtPeriodo";
            this.txtPeriodo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // lblTituloPeriodo
            // 
            this.lblTituloPeriodo.Dpi = 100F;
            this.lblTituloPeriodo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblTituloPeriodo.LocationFloat = new DevExpress.Utils.PointFloat(517.71F, 101F);
            this.lblTituloPeriodo.Name = "lblTituloPeriodo";
            this.lblTituloPeriodo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblTituloPeriodo.SizeF = new System.Drawing.SizeF(68.28992F, 23F);
            this.lblTituloPeriodo.StylePriority.UseFont = false;
            this.lblTituloPeriodo.StylePriority.UseTextAlignment = false;
            this.lblTituloPeriodo.Text = "PERIODO";
            this.lblTituloPeriodo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // lblTipoNomina
            // 
            this.lblTipoNomina.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "stpSelAcuseRecibosNominaAlimentosSC.DescTipoPeriodoNomina")});
            this.lblTipoNomina.Dpi = 100F;
            this.lblTipoNomina.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblTipoNomina.LocationFloat = new DevExpress.Utils.PointFloat(586F, 78F);
            this.lblTipoNomina.Name = "lblTipoNomina";
            this.lblTipoNomina.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 4, 0, 0, 100F);
            this.lblTipoNomina.SizeF = new System.Drawing.SizeF(163F, 21F);
            this.lblTipoNomina.StylePriority.UseFont = false;
            this.lblTipoNomina.StylePriority.UsePadding = false;
            this.lblTipoNomina.StylePriority.UseTextAlignment = false;
            this.lblTipoNomina.Text = "lblTipoNomina";
            this.lblTipoNomina.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // lblNombreComercialCliente
            // 
            this.lblNombreComercialCliente.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "stpSelAcuseRecibosNominaAlimentosSC.NombreComercialCliente")});
            this.lblNombreComercialCliente.Dpi = 100F;
            this.lblNombreComercialCliente.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblNombreComercialCliente.LocationFloat = new DevExpress.Utils.PointFloat(0F, 78F);
            this.lblNombreComercialCliente.Name = "lblNombreComercialCliente";
            this.lblNombreComercialCliente.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 0, 0, 100F);
            this.lblNombreComercialCliente.SizeF = new System.Drawing.SizeF(499.9053F, 23F);
            this.lblNombreComercialCliente.StylePriority.UseFont = false;
            this.lblNombreComercialCliente.StylePriority.UsePadding = false;
            this.lblNombreComercialCliente.Text = "lblNombreComercialCliente";
            // 
            // lblRazonSocialTenedora
            // 
            this.lblRazonSocialTenedora.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "stpSelAcuseRecibosNominaAlimentosSC.RazonSocialTenedora")});
            this.lblRazonSocialTenedora.Dpi = 100F;
            this.lblRazonSocialTenedora.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblRazonSocialTenedora.LocationFloat = new DevExpress.Utils.PointFloat(0F, 55F);
            this.lblRazonSocialTenedora.Name = "lblRazonSocialTenedora";
            this.lblRazonSocialTenedora.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 0, 0, 100F);
            this.lblRazonSocialTenedora.SizeF = new System.Drawing.SizeF(749F, 23F);
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
            this.lblTituloRecibos.Dpi = 100F;
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
            this.BottomMargin.Dpi = 100F;
            this.BottomMargin.HeightF = 111.8333F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lblFolioLoteCargaNomina
            // 
            this.lblFolioLoteCargaNomina.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "stpSelAcuseRecibosNominaAlimentosSC.FolioLoteCargaNomina")});
            this.lblFolioLoteCargaNomina.Dpi = 100F;
            this.lblFolioLoteCargaNomina.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblFolioLoteCargaNomina.LocationFloat = new DevExpress.Utils.PointFloat(450.4583F, 65F);
            this.lblFolioLoteCargaNomina.Name = "lblFolioLoteCargaNomina";
            this.lblFolioLoteCargaNomina.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblFolioLoteCargaNomina.SizeF = new System.Drawing.SizeF(298.0017F, 23F);
            this.lblFolioLoteCargaNomina.StylePriority.UseFont = false;
            this.lblFolioLoteCargaNomina.StylePriority.UseTextAlignment = false;
            this.lblFolioLoteCargaNomina.Text = "lblFolioLoteCargaNomina";
            this.lblFolioLoteCargaNomina.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // lblTituloRecibi
            // 
            this.lblTituloRecibi.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.lblTituloRecibi.BorderWidth = 2F;
            this.lblTituloRecibi.Dpi = 100F;
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
            this.LeyendaFechaImpresion.DataMember = "vwAcuseRecibosEmpleadosAlimentos";
            this.LeyendaFechaImpresion.Expression = "\'Fecha de Impresión: \' + ToStr(Now())";
            this.LeyendaFechaImpresion.Name = "LeyendaFechaImpresion";
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblTituloTotalAlimentosBruto,
            this.txtTotalAlimentosBruto});
            this.ReportFooter.Dpi = 100F;
            this.ReportFooter.HeightF = 23F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // lblTituloTotalAlimentosBruto
            // 
            this.lblTituloTotalAlimentosBruto.Dpi = 100F;
            this.lblTituloTotalAlimentosBruto.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.lblTituloTotalAlimentosBruto.LocationFloat = new DevExpress.Utils.PointFloat(70.8334F, 0F);
            this.lblTituloTotalAlimentosBruto.Name = "lblTituloTotalAlimentosBruto";
            this.lblTituloTotalAlimentosBruto.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 10, 0, 0, 100F);
            this.lblTituloTotalAlimentosBruto.SizeF = new System.Drawing.SizeF(554.1667F, 23F);
            this.lblTituloTotalAlimentosBruto.StylePriority.UseFont = false;
            this.lblTituloTotalAlimentosBruto.StylePriority.UsePadding = false;
            this.lblTituloTotalAlimentosBruto.StylePriority.UseTextAlignment = false;
            xrSummary2.FormatString = "{0:c2}";
            this.lblTituloTotalAlimentosBruto.Summary = xrSummary2;
            this.lblTituloTotalAlimentosBruto.Text = "Total Pensión";
            this.lblTituloTotalAlimentosBruto.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // txtTotalAlimentosBruto
            // 
            this.txtTotalAlimentosBruto.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "stpSelAcuseRecibosNominaAlimentosSC.MontoNetoPagar")});
            this.txtTotalAlimentosBruto.Dpi = 100F;
            this.txtTotalAlimentosBruto.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.txtTotalAlimentosBruto.LocationFloat = new DevExpress.Utils.PointFloat(625.0001F, 0F);
            this.txtTotalAlimentosBruto.Name = "txtTotalAlimentosBruto";
            this.txtTotalAlimentosBruto.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtTotalAlimentosBruto.SizeF = new System.Drawing.SizeF(123.4599F, 23F);
            this.txtTotalAlimentosBruto.StylePriority.UseFont = false;
            this.txtTotalAlimentosBruto.StylePriority.UseTextAlignment = false;
            xrSummary3.FormatString = "{0:c2}";
            xrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.txtTotalAlimentosBruto.Summary = xrSummary3;
            this.txtTotalAlimentosBruto.Text = "txtTotalAlimentosBruto";
            this.txtTotalAlimentosBruto.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // dbSAICBPOReportesDataSet1
            // 
            this.dbSAICBPOReportesDataSet1.DataSetName = "dbSAICBPOReportesDataSet";
            this.dbSAICBPOReportesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stpSelAcuseRecibosNominaAlimentosSCTableAdapter
            // 
            this.stpSelAcuseRecibosNominaAlimentosSCTableAdapter.ClearBeforeFill = true;
            // 
            // pIdLoteCargaNomina
            // 
            this.pIdLoteCargaNomina.Description = "LoteCargaNomina";
            this.pIdLoteCargaNomina.Name = "pIdLoteCargaNomina";
            this.pIdLoteCargaNomina.Type = typeof(int);
            this.pIdLoteCargaNomina.ValueInfo = "0";
            this.pIdLoteCargaNomina.Visible = false;
            // 
            // AcuseRecibosEmpleadosAlimentos
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportFooter});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.LeyendaFechaImpresion});
            this.DataAdapter = this.stpSelAcuseRecibosNominaAlimentosSCTableAdapter;
            this.DataMember = "stpSelAcuseRecibosNominaAlimentosSC";
            this.DataSource = this.dbSAICBPOReportesDataSet1;
            this.DisplayName = "AcuseRecibosEmpleadosPension";
            this.Margins = new System.Drawing.Printing.Margins(49, 52, 158, 112);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.pIdLoteCargaNomina});
            this.Version = "16.2";
            this.DataSourceDemanded += new System.EventHandler<System.EventArgs>(this.AcuseRecibosEmpleadosAlimentos_DataSourceDemanded);
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
        private DevExpress.XtraReports.UI.XRLabel lblNombreComercialCliente;
        private DevExpress.XtraReports.UI.XRLabel lblRazonSocialTenedora;
        private DevExpress.XtraReports.UI.XRLabel lblTipoNomina;
        private DevExpress.XtraReports.UI.XRLabel lblTituloPeriodo;
        private DevExpress.XtraReports.UI.XRLabel txtPeriodo;
        private DevExpress.XtraReports.UI.XRTable tbEncabezado;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell7;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell8;
        private DevExpress.XtraReports.UI.XRTable tbDetalle;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell txtNoRecibo;
        private DevExpress.XtraReports.UI.XRTableCell txtNombreAsociado;
        private DevExpress.XtraReports.UI.XRTableCell txtImporteAlimentosBruto;
        private DevExpress.XtraReports.UI.CalculatedField LeyendaFechaImpresion;
        private DevExpress.XtraReports.UI.XRLabel lblTituloRecibi;
        private DevExpress.XtraReports.UI.XRLabel lblFolioLoteCargaNomina;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRLabel txtTotalAlimentosBruto;
        private DevExpress.XtraReports.UI.XRLabel lblTituloTotalAlimentosBruto;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private dbSAICBPOReportesDataSet dbSAICBPOReportesDataSet1;
        private dbSAICBPOReportesDataSetTableAdapters.stpSelAcuseRecibosNominaAlimentosSCTableAdapter stpSelAcuseRecibosNominaAlimentosSCTableAdapter;
        private DevExpress.XtraReports.Parameters.Parameter pIdLoteCargaNomina;
    }
}
