using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace winAppSAIC.ReportesCFDI
{
    public partial class UUIDsRELACION : DevExpress.XtraReports.UI.XtraReport
    {
        public UUIDsRELACION()
        {
            InitializeComponent();
        }

        private void UUIDsRELACION_DataSourceDemanded(object sender, EventArgs e)
        {
            this.stpFactSelUUIDPDFTableAdapter1.Fill(this.dbSAICBPOFactura1.stpFactSelUUIDPDF, Convert.ToInt64(pIdFactura.Value));
        }
    }
}
