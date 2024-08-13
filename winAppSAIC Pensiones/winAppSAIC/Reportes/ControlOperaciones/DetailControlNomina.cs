using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace winAppSAIC.Reportes
{
    public partial class DetailControlNomina : DevExpress.XtraReports.UI.XtraReport
    {
        public DetailControlNomina()
        {
            InitializeComponent();
        }

        private void DetailControlNomina_DataSourceDemanded(object sender, EventArgs e)
        {
            this.stpFactSelDetailControlOperacionesTableAdapter1.Fill(this.dbSAICBPOFactura1.stpFactSelDetailControlOperaciones, Convert.ToInt64(IdControl.Value));
        }
    }
}
