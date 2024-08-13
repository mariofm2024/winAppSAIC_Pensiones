using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace winAppSAIC.ReportesCFDI
{
    public partial class ConceptosFacturacion : DevExpress.XtraReports.UI.XtraReport
    {
        public ConceptosFacturacion()
        {
            InitializeComponent();
        }

        private void ConceptosFacturacion_DataSourceDemanded(object sender, EventArgs e)
        {
            this.stpFactSelDetailFacturasTableAdapter1.Fill(this.dbSAICBPOFactura1.stpFactSelDetailFacturas, Convert.ToInt64( pIdFactura.Value));
            //this.stpSelDetailFacturasTableAdapter1.Fill(this.dbSAICBPOFactura1.stpSelDetailFacturas, Convert.ToInt64(pIdFactura.Value));
        }
    }
}
