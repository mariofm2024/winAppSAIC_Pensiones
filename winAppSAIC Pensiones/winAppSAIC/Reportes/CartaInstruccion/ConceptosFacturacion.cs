using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace winAppSAIC.Reportes
{
    public partial class ConceptosFacturacion : DevExpress.XtraReports.UI.XtraReport
    {
        public ConceptosFacturacion()
        {
            InitializeComponent();
        }

        private void ConceptosFacturacion_DataSourceDemanded(object sender, EventArgs e)
        {
            this.stpFactSelReporteClienteConceptosTableAdapter1.Fill(this.dbSAICBPOFactura1.stpFactSelReporteClienteConceptos, Convert.ToInt32(IdCliente.Value));
        }
    }
}
