using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using winAppSAIC.Reportes;

namespace winAppSAIC
{
    public partial class ReporteNominaSueldos : DevExpress.XtraReports.UI.XtraReport
    {
        public ReporteNominaSueldos()
        {
            InitializeComponent();
        }

        //evento utilizado para pasar los parametros que recibe un reporte 
        //y que se ejecutan en el stored procedure
        private void ReporteNominaSueldos_DataSourceDemanded(object sender, EventArgs e)
        {
            //Ejecutar stored procedure con los parametros recibidos antes de mostrar la informacion            
            this.stpSelReporteNominaSueldosSATableAdapter.Fill(this.dbSAICBPOReportesDataSet1.stpSelReporteNominaSueldosSA, 
                Convert.ToInt64(this.pIdLoteCargaNomina.Value));
        }

        private void xrSRDeduccionesGravadasExentasDeduciblesNoDeducibles_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ((ResumenDeduccionesGravadasExentasDeduciblesNoDeducibles)((XRSubreport)sender).ReportSource).pIdLoteCargaNomina.Value =
                Convert.ToInt64(this.pIdLoteCargaNomina.Value);
        }

        private void xrSRPercepcionesGravadasExentasDeduciblesNoDeducibles_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ((ResumenPercepcionesGravadasExentasDeduciblesNoDeducibles)((XRSubreport)sender).ReportSource).pIdLoteCargaNomina.Value =
                Convert.ToInt64(this.pIdLoteCargaNomina.Value);
        }

        private void xrSREstatusNominaSueldosVsTimbrado_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ((ResumenEstatusNominaSueldosVsTimbrado)((XRSubreport)sender).ReportSource).pIdLoteCargaNomina.Value =
                Convert.ToInt64(this.pIdLoteCargaNomina.Value);
        }

        private void xrSubreport1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ((ResumenDispersionBanco)((XRSubreport)sender).ReportSource).pIdLoteCargaNomina.Value = Convert.ToInt64(this.pIdLoteCargaNomina.Value);
            ((ResumenDispersionBanco)((XRSubreport)sender).ReportSource).pTipo.Value = "S";
        }
    }
}
