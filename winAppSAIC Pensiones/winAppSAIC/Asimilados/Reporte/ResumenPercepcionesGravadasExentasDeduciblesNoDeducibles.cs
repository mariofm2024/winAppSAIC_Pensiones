using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace winAppSAIC.Asimilados.Reporte
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
            this.stpSelResumenPercepcionesGravadasExentasDeduciblesNoDeduciblesTableAdapter.Fill(this.dbSAICAsimilados1.stpSelResumenPercepcionesGravadasExentasDeduciblesNoDeducibles, Convert.ToInt64(pIdLoteCargaNomina.Value));
        }
    }
}
