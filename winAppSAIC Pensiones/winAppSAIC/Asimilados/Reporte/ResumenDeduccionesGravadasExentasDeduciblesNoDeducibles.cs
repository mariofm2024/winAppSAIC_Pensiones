using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace winAppSAIC.Asimilados.Reporte
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
            this.stpSelResumenDeduccionesGravadasExentasDeduciblesNoDeduciblesTableAdapter1.Fill(this.dbSAICAsimilados1.stpSelResumenDeduccionesGravadasExentasDeduciblesNoDeducibles, Convert.ToInt64(pIdLoteCargaNomina.Value));
        }

    }
}
