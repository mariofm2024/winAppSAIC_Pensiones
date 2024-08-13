using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace winAppSAIC.ReportesCFDI
{
    public partial class RecibosAsimiladosSalariosCFDI : DevExpress.XtraReports.UI.XtraReport
    {
        public RecibosAsimiladosSalariosCFDI()
        {
            InitializeComponent();
        }

        private void RecibosAsimiladosSalariosCFDI_DataSourceDemanded(object sender, EventArgs e)
        {
            ////asignar el valor del parámetro y obtener registros
            this.stpSelRecibosEmpleadosSueldosAsimiladosCFDITableAdapter1.Fill(this.dbSAICBPONominaCFDIDataSet1.stpSelRecibosEmpleadosSueldosAsimiladosCFDI, Convert.ToInt64(pIdLoteCargaNomina.Value), Convert.ToInt64(pIdPDOHeader.Value));
        }

        private void xrSubreport1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ((PercepcionesGravadoExento)((XRSubreport)sender).ReportSource).pIdPDOHeader.Value =
                                           Convert.ToInt64(GetCurrentColumnValue("IdPDOHeader"));
            ((PercepcionesGravadoExento)((XRSubreport)sender).ReportSource).pTipoMovimientoNomina.Value =
                                           pTipoMovimientoNomina.Value.ToString();
        }

        private void xrSubreport2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ((DeduccionesGravadoExento)((XRSubreport)sender).ReportSource).pIdPDOHeader.Value =
                               Convert.ToInt64(GetCurrentColumnValue("IdPDOHeader"));
            ((DeduccionesGravadoExento)((XRSubreport)sender).ReportSource).pTipoMovimientoNomina.Value =
                                           pTipoMovimientoNomina.Value.ToString();
        }

    }
}
