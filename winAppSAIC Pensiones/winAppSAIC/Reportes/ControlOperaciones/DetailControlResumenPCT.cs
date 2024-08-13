using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace winAppSAIC.Reportes.ControlOperaciones
{
    public partial class DetailControlResumenPCT : DevExpress.XtraReports.UI.XtraReport
    {
        public DetailControlResumenPCT()
        {
            InitializeComponent();
        }

        private void DetailControlResumenPCT_DataSourceDemanded(object sender, EventArgs e)
        {
            this.stpFactSelCOProductosPCTTableAdapter1.Fill(this.dbSAICBPOFactura1.stpFactSelCOProductosPCT, Convert.ToInt64(IdControl.Value));
        }
    }
}
