using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace winAppSAIC.ReportesCFDI
{
    public partial class ReciboFacturacionRecibo : DevExpress.XtraReports.UI.XtraReport
    {
        public ReciboFacturacionRecibo()
        {
            InitializeComponent();
        }

        private void ReciboFacturacionRecibo_DataSourceDemanded(object sender, EventArgs e)
        {
            this.stpFactSelReporteFacturaReciboPDFTableAdapter1.Fill(this.dbSAICBPOFactura1.stpFactSelReporteFacturaReciboPDF, Convert.ToInt64(pIdFactura.Value));
        }

        private void xrSubreport1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ((ConceptosFacturacionREP)((XRSubreport)sender).ReportSource).pIdFactura.Value = Convert.ToInt64(GetCurrentColumnValue("IdHeaderFactura"));
        }

        private void xrSubreport2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ((UUIDsRELACION)((XRSubreport)sender).ReportSource).pIdFactura.Value = Convert.ToInt64(GetCurrentColumnValue("IdHeaderFactura"));
        }
    }
}
