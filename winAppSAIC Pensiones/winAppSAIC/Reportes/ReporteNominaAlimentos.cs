using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using winAppSAIC.Reportes;

namespace winAppSAIC
{
    public partial class ReporteNominaAlimentos : DevExpress.XtraReports.UI.XtraReport
    {
        public ReporteNominaAlimentos()
        {
            InitializeComponent();
        }

        private void ReporteNominaAlimentos_DataSourceDemanded(object sender, EventArgs e)
        {
            //Ejecutar stored procedure con los parametros recibidos antes de mostrar la informacion
            this.stpSelReporteNominaAlimentosSCTableAdapter.Fill(this.dbSAICBPOReportesDataSet1.stpSelReporteNominaAlimentosSC,
                Convert.ToInt64(this.pIdLoteCargaNomina.Value));
        }

        private void xrSubreport1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ((ResumenDispersionBanco)((XRSubreport)sender).ReportSource).pIdLoteCargaNomina.Value = Convert.ToInt64(this.pIdLoteCargaNomina.Value);
            ((ResumenDispersionBanco)((XRSubreport)sender).ReportSource).pTipo.Value = "A";
        }
    }
}
