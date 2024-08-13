using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace winAppSAIC.ReportesCFDI
{
    public partial class ConceptosFacturacionREP : DevExpress.XtraReports.UI.XtraReport
    {
        public ConceptosFacturacionREP()
        {
            InitializeComponent();
        }

        private void ConceptosFacturacionREP_DataSourceDemanded(object sender, EventArgs e)
        {
            this.stpFactSelDetailFacturasReciboTableAdapter1.Fill(this.dbSAICBPOFactura1.stpFactSelDetailFacturasRecibo, Convert.ToInt64(pIdFactura.Value));
        }
    }
}
