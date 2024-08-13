using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace winAppSAIC.Reportes
{
    public partial class Productos : DevExpress.XtraReports.UI.XtraReport
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void Productos_DataSourceDemanded(object sender, EventArgs e)
        {
            this.stpFactSelReporteClienteProductosTableAdapter1.Fill(this.dbSAICBPOFactura1.stpFactSelReporteClienteProductos, Convert.ToInt32(IdCliente.Value));
        }
    }
}
