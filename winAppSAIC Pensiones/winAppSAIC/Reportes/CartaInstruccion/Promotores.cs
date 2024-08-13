using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace winAppSAIC.Reportes
{
    public partial class Promotores : DevExpress.XtraReports.UI.XtraReport
    {
        public Promotores()
        {
            InitializeComponent();
        }

        private void Promotores_DataSourceDemanded(object sender, EventArgs e)
        {
            this.stpFactSelReporteClientePromotoresTableAdapter1.Fill(this.dbSAICBPOFactura1.stpFactSelReporteClientePromotores, Convert.ToInt32(IdCliente.Value));
        }
    }
}
