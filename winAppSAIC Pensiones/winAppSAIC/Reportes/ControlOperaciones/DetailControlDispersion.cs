using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace winAppSAIC.Reportes
{
    public partial class DetailControlDispersion : DevExpress.XtraReports.UI.XtraReport
    {
        public DetailControlDispersion()
        {
            InitializeComponent();
        }

        private void DetailControlDispersion_DataSourceDemanded(object sender, EventArgs e)
        {
            this.stpFactSelDetailControlOperacionesDisperTableAdapter1.Fill(this.dbSAICBPOFactura1.stpFactSelDetailControlOperacionesDisper, Convert.ToInt64(IdControl.Value));
        }
    }
}
