using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace winAppSAIC.Reportes
{
    public partial class Comision : DevExpress.XtraReports.UI.XtraReport
    {
        public Comision()
        {
            InitializeComponent();
        }

        private void Comision_DataSourceDemanded(object sender, EventArgs e)
        {
            this.stpFactSelReporteClienteComisionTableAdapter1.Fill(this.dbSAICBPOFactura1.stpFactSelReporteClienteComision, Convert.ToInt32(IdCliente.Value));
        }
    }
}
