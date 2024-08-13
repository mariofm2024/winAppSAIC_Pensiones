using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace winAppSAIC.Reportes
{
    public partial class DetailControlResumen : DevExpress.XtraReports.UI.XtraReport
    {
        public DetailControlResumen()
        {
            InitializeComponent();
        }

        private void DetailControlDispersion_DataSourceDemanded(object sender, EventArgs e)
        {
            this.stpFactSelDetailControlOperacionesResumenTableAdapter1.Fill(this.dbSAICBPOFactura1.stpFactSelDetailControlOperacionesResumen, Convert.ToInt64(IdControl.Value));
        }
    }
}
