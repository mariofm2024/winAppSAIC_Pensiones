using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace winAppSAIC.Reportes
{
    public partial class DetailControlSinDispersion : DevExpress.XtraReports.UI.XtraReport
    {
        public DetailControlSinDispersion()
        {
            InitializeComponent();
        }

        private void DetailControlDispersion_DataSourceDemanded(object sender, EventArgs e)
        {
            this.stpFactSelDetailControlOperacioneSinDisperTableAdapter1.Fill(this.dbSAICBPOFactura1.stpFactSelDetailControlOperacioneSinDisper, Convert.ToInt64(IdControl.Value));
        }
    }
}
