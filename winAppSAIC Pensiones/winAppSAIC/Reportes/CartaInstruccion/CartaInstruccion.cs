using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace winAppSAIC.Reportes
{
    public partial class CartaInstruccion : DevExpress.XtraReports.UI.XtraReport
    {
        public CartaInstruccion()
        {
            InitializeComponent();
        }
      
        private void CartaInstruccion_DataSourceDemanded_1(object sender, EventArgs e)
        {
            //asignar el valor del parámetro y obtener registros
            this.stpFactSelReporteClienteTableAdapter1.Fill(this.dbSAICBPOFactura1.stpFactSelReporteCliente, Convert.ToInt32(pIdCliente.Value));
        }

        private void xrSubreport1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ((Productos)((XRSubreport)sender).ReportSource).IdCliente.Value =
                                          Convert.ToInt32(GetCurrentColumnValue("IdCliente"));
        }

        private void xrSubreport2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ((Periodicidad)((XRSubreport)sender).ReportSource).IdCliente.Value =
                                         Convert.ToInt32(GetCurrentColumnValue("IdCliente"));
        }

        private void xrSubreport3_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ((Fronting)((XRSubreport)sender).ReportSource).IdCliente.Value =
                                         Convert.ToInt32(GetCurrentColumnValue("IdCliente"));
        }

        private void xrSubreport4_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ((Promotores)((XRSubreport)sender).ReportSource).IdCliente.Value =
                                         Convert.ToInt32(GetCurrentColumnValue("IdCliente"));
        }

        private void xrSubreport5_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ((Comision)((XRSubreport)sender).ReportSource).IdCliente.Value =
                                         Convert.ToInt32(GetCurrentColumnValue("IdCliente"));
        }

        private void xrSubreport6_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ((ConceptosFacturacion)((XRSubreport)sender).ReportSource).IdCliente.Value =
                                         Convert.ToInt32(GetCurrentColumnValue("IdCliente"));
        }
    }
}
