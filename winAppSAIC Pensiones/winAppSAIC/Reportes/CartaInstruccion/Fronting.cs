using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace winAppSAIC.Reportes
{
    public partial class Fronting : DevExpress.XtraReports.UI.XtraReport
    {
        public Fronting()
        {
            InitializeComponent();
        }

        private void Fronting_DataSourceDemanded(object sender, EventArgs e)
        {
            this.stpFactSelReporteClienteFrontingTableAdapter1.Fill(this.dbSAICBPOFactura1.stpFactSelReporteClienteFronting, Convert.ToInt32(IdCliente.Value));
        }
    }
}
