using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace winAppSAIC.Reportes
{
    public partial class Periodicidad : DevExpress.XtraReports.UI.XtraReport
    {
        public Periodicidad()
        {
            InitializeComponent();
        }
        private void Periodicidad_DataSourceDemanded(object sender, EventArgs e)
        {
            this.stpFactSelReporteClientePeriodicidadTableAdapter1.Fill(this.dbSAICBPOFactura1.stpFactSelReporteClientePeriodicidad, Convert.ToInt32(IdCliente.Value));
        }
    }
}
