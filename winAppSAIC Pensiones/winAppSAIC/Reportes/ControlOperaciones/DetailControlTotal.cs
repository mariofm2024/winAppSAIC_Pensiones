using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace winAppSAIC.Reportes.ControlOperaciones
{
    public partial class DetailControlTotal : DevExpress.XtraReports.UI.XtraReport
    {
        public DetailControlTotal()
        {
            InitializeComponent();
        }

        private void DetailControlTotal_DataSourceDemanded(object sender, EventArgs e)
        {
            this.stpFactSelDetailControlOperacionesTotalesTableAdapter1.Fill(this.dbSAICBPOFactura1.stpFactSelDetailControlOperacionesTotales, Convert.ToInt64(IdControl.Value));
        }
    }
}
