using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace winAppSAIC.Reportes.ControlOperaciones
{
    public partial class DetailControlDispersionAsimilados : DevExpress.XtraReports.UI.XtraReport
    {
        public DetailControlDispersionAsimilados()
        {
            InitializeComponent();
        }

        private void DetailControlDispersionAsimilados_DataSourceDemanded(object sender, EventArgs e)
        {
            this.stpFactSelDetailControlOperacionesDisperAsiTableAdapter1.Fill(this.dbSAICAsimilados1.stpFactSelDetailControlOperacionesDisperAsi, Convert.ToInt64(IdControl.Value));
        }
    }
}
