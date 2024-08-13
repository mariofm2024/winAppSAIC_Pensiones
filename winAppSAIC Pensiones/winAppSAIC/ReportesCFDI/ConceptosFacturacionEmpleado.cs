using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace winAppSAIC.ReportesCFDI
{
    public partial class ConceptosFacturacionEmpleado : DevExpress.XtraReports.UI.XtraReport
    {
        public ConceptosFacturacionEmpleado()
        {
            InitializeComponent();
        }

        private void ConceptosFacturacionEmpleado_DataSourceDemanded(object sender, EventArgs e)
        {
            this.stpFactSelDetailFacturasEmpleadoTableAdapter1.Fill(this.dbSAICBPONominaCFDIv12DataSet1.stpFactSelDetailFacturasEmpleado, Convert.ToInt64( pIdPDOHeader.Value));
        }
    }
}
