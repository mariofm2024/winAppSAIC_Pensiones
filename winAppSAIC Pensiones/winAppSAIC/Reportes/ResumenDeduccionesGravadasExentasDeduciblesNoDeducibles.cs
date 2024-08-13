using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace winAppSAIC.Reportes
{
    public partial class ResumenDeduccionesGravadasExentasDeduciblesNoDeducibles : DevExpress.XtraReports.UI.XtraReport
    {
        public ResumenDeduccionesGravadasExentasDeduciblesNoDeducibles()
        {
            InitializeComponent();
        }

        private void ResumenDeduccionesGravadasExentasDeduciblesNoDeducibles_DataSourceDemanded(object sender, EventArgs e)
        {
            //asignar parametro al stored procedure
            this.stpSelResumenDeduccionesGravadasExentasDeduciblesNoDeduciblesTableAdapter1.Fill(dbSAICBPOReportesDataSet1.stpSelResumenDeduccionesGravadasExentasDeduciblesNoDeducibles, Convert.ToInt64(pIdLoteCargaNomina.Value));
        }

    }
}
