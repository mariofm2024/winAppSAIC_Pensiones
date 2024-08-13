using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace winAppSAIC.Reportes.ControlOperaciones
{
    public partial class DetailControlAsimilados : DevExpress.XtraReports.UI.XtraReport
    {
        public DetailControlAsimilados()
        {
            InitializeComponent();
        }

        private void DetailControlAsimilados_DataSourceDemanded(object sender, EventArgs e)
        {
            this.stpSelReporteNominaSueldosControlTableAdapter1.Fill(this.dbSAICAsimilados1.stpSelReporteNominaSueldosControl, Convert.ToInt64(IdControl.Value));
        }
    }
}
