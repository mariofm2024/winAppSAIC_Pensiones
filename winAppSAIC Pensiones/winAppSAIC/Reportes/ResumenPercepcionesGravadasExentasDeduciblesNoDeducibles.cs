using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace winAppSAIC.Reportes
{
    public partial class ResumenPercepcionesGravadasExentasDeduciblesNoDeducibles : DevExpress.XtraReports.UI.XtraReport
    {
        public ResumenPercepcionesGravadasExentasDeduciblesNoDeducibles()
        {
            InitializeComponent();
        }

        private void ResumenPercepcionesGravadasExentasDeduciblesNoDeducibles_DataSourceDemanded(object sender, EventArgs e)
        {
            //asignar parametro al stored procedure
            this.stpSelResumenPercepcionesGravadasExentasDeduciblesNoDeduciblesTableAdapter1.Fill(dbSAICBPOReportesDataSet1.stpSelResumenPercepcionesGravadasExentasDeduciblesNoDeducibles, Convert.ToInt64(pIdLoteCargaNomina.Value));
        }
    }
}
