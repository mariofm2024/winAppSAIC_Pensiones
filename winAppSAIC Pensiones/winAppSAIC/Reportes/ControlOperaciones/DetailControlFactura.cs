using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace winAppSAIC.Reportes.ControlOperaciones
{
    public partial class DetailControlFactura : DevExpress.XtraReports.UI.XtraReport
    {
        public DetailControlFactura()
        {
            InitializeComponent();
        }

        private void DetailControlFactura_DataSourceDemanded(object sender, EventArgs e)
        {
            this.stpFactSelDetailControlOperacionesFactTableAdapter1.Fill(this.dbSAICBPOFactura1.stpFactSelDetailControlOperacionesFact, Convert.ToInt64(IdControl.Value));
        }
    }
}
