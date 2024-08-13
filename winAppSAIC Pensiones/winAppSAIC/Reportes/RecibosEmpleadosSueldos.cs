using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace winAppSAIC
{
    public partial class RecibosEmpleadosSueldos : DevExpress.XtraReports.UI.XtraReport
    {
        public RecibosEmpleadosSueldos()
        {
            InitializeComponent();
        }

        private void xrSubreport1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ((Percepciones)((XRSubreport)sender).ReportSource).pIdPDOHeader.Value =
                                           Convert.ToInt64(GetCurrentColumnValue("IdPDOHeader"));
            ((Percepciones)((XRSubreport)sender).ReportSource).pIdLoteCargaNomina.Value =
                             Convert.ToInt64(GetCurrentColumnValue("IdLoteCargaNomina"));
        }

        private void xrSubreport2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ((Deducciones)((XRSubreport)sender).ReportSource).pIdPDOHeader.Value =
                               Convert.ToInt64(GetCurrentColumnValue("IdPDOHeader"));
            ((Deducciones)((XRSubreport)sender).ReportSource).pIdLoteCargaNomina.Value =
                             Convert.ToInt64(GetCurrentColumnValue("IdLoteCargaNomina"));
        }

        private void xrSubreport3_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ((Percepciones)((XRSubreport)sender).ReportSource).pIdPDOHeader.Value =
                                          Convert.ToInt64(GetCurrentColumnValue("IdPDOHeader"));
            ((Percepciones)((XRSubreport)sender).ReportSource).pIdLoteCargaNomina.Value =
                             Convert.ToInt64(GetCurrentColumnValue("IdLoteCargaNomina"));
        }

        private void xrSubreport4_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ((Deducciones)((XRSubreport)sender).ReportSource).pIdPDOHeader.Value =
                             Convert.ToInt64(GetCurrentColumnValue("IdPDOHeader"));
            ((Deducciones)((XRSubreport)sender).ReportSource).pIdLoteCargaNomina.Value =
                             Convert.ToInt64(GetCurrentColumnValue("IdLoteCargaNomina"));
        }

        private void xrSubreport5_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ((Percepciones)((XRSubreport)sender).ReportSource).pIdPDOHeader.Value =
                                          Convert.ToInt64(GetCurrentColumnValue("IdPDOHeader"));
            ((Percepciones)((XRSubreport)sender).ReportSource).pIdLoteCargaNomina.Value =
                             Convert.ToInt64(GetCurrentColumnValue("IdLoteCargaNomina"));
        }

        private void xrSubreport6_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ((Deducciones)((XRSubreport)sender).ReportSource).pIdPDOHeader.Value =
                             Convert.ToInt64(GetCurrentColumnValue("IdPDOHeader"));
            ((Deducciones)((XRSubreport)sender).ReportSource).pIdLoteCargaNomina.Value =
                             Convert.ToInt64(GetCurrentColumnValue("IdLoteCargaNomina"));
        }

        private void RecibosEmpleadosSueldos_DataSourceDemanded(object sender, EventArgs e)
        {
            //asignar el valor del parámetro y obtener registros
            this.stpSelRecibosEmpleadosHeaderSATableAdapter.Fill(this.dbSAICBPOReportesDataSet1.stpSelRecibosEmpleadosHeaderSA, Convert.ToInt64(pIdLoteCargaNomina.Value));
        }

    }
}
