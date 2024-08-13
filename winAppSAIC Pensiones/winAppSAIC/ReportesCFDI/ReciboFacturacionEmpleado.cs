using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace winAppSAIC.ReportesCFDI
{
    public partial class ReciboFacturacionEmpleado : DevExpress.XtraReports.UI.XtraReport
    {
        public ReciboFacturacionEmpleado()
        {
            InitializeComponent();
        }

        private void ReciboFacturacion_DataSourceDemanded(object sender, EventArgs e)
        {
            this.stpFactSelReporteFacturaPDFEmpleadoTableAdapter1.Fill(this.dbSAICBPONominaCFDIv12DataSet1.stpFactSelReporteFacturaPDFEmpleado, Convert.ToInt64(pIdPDOHeader.Value), Convert.ToInt64(pIdLoteCargaNomina.Value));
        }

        private void xrSubreport1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ((ConceptosFacturacionEmpleado)((XRSubreport)sender).ReportSource).pIdPDOHeader.Value = Convert.ToInt64(GetCurrentColumnValue("IdPDOHeader"));
        }
    }
}
