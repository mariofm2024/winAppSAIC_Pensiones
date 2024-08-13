using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace winAppSAIC.Juridico.Reportes
{
    public partial class DocumentosContrato : DevExpress.XtraReports.UI.XtraReport
    {
        public DocumentosContrato()
        {
            InitializeComponent();
        }

        private void DetailReport_DataSourceDemanded(object sender, EventArgs e)
        {
           
        }

        private void DocumentosContrato_DataSourceDemanded(object sender, EventArgs e)
        {
            String ssArea = sArea.Value.ToString();
            int iidDocumentosContrato = Convert.ToInt32(idDocumentosContrato.Value.ToString());
            int iIdSolicitud = Convert.ToInt32(IdSolicitud.Value.ToString());
            int iIdFirmante = Convert.ToInt32(IdFirmante.Value.ToString());
            int iIdEmpleado = Convert.ToInt32(IdEmpleado.Value.ToString());

            stpSelDocumentosContratoTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelDocumentosContrato, ssArea, iidDocumentosContrato, iIdSolicitud, iIdFirmante, iIdEmpleado);

            if (dbSAICBPOCatalogosDataSet1.stpSelDocumentosContrato.Rows.Count > 0)
            {
                if (!String.IsNullOrEmpty(dbSAICBPOCatalogosDataSet1.stpSelDocumentosContrato.Rows[0]["DocumentoContrato"].ToString()))
                {
                    RichTextParrafo2.Html = dbSAICBPOCatalogosDataSet1.stpSelDocumentosContrato.Rows[0]["DocumentoContrato"].ToString();
                }
            }
        }

        private void DocumentosContrato_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }
    }
}
