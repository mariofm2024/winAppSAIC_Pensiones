using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace winAppSAIC.Juridico.Cartas
{
    public partial class Carta_ConstanciaLaboral : DevExpress.XtraReports.UI.XtraReport
    {
        public Carta_ConstanciaLaboral()
        {
            InitializeComponent();
        }

        private void Carta_ConstanciaLaboral_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            txtCarta.Html = stCarta.Value.ToString();
        }

        private void Carta_ConstanciaLaboral_DataSourceDemanded(object sender, EventArgs e)
        {
            int? idMtenedora = int.Parse(idMatrizTenedora.Value.ToString());
            stpSelObtenerLogoTenedoraTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelObtenerLogoTenedora, idMtenedora);
        }
    }
}
