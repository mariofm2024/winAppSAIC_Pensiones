using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using winAppSAIC.Reportes.ControlOperaciones;

namespace winAppSAIC.Reportes
{
    public partial class ReporteControlOperaciones : DevExpress.XtraReports.UI.XtraReport
    {
        public ReporteControlOperaciones()
        {
            InitializeComponent();
        }

        private void ReporteControlOperaciones_DataSourceDemanded(object sender, EventArgs e)
        {
            //Ejecutar stored procedure con los parametros recibidos antes de mostrar la informacion
            this.stpFactSelControlOperacionesPDFTableAdapter1.Fill(this.dbSAICBPOFactura1.stpFactSelControlOperacionesPDF, Convert.ToInt64(pIdControlOperaciones.Value), -1, -1, -1, -1, -1, false);
        }

        private void xrSubreport1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ((DetailControlNomina)((XRSubreport)sender).ReportSource).IdControl.Value = Convert.ToInt64(GetCurrentColumnValue("IdControlOperaciones"));
        }

        private void xrSubreport2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ((DetailControlDispersion)((XRSubreport)sender).ReportSource).IdControl.Value = Convert.ToInt64(GetCurrentColumnValue("IdControlOperaciones"));
        }

        private void xrSubreport3_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ((DetailControlFactura)((XRSubreport)sender).ReportSource).IdControl.Value = Convert.ToInt64(GetCurrentColumnValue("IdControlOperaciones"));
        }

        private void xrSubreport4_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ((DetailControlSinDispersion)((XRSubreport)sender).ReportSource).IdControl.Value = Convert.ToInt64(GetCurrentColumnValue("IdControlOperaciones"));
        }

        private void xrSubreport5_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ((DetailControlResumen)((XRSubreport)sender).ReportSource).IdControl.Value = Convert.ToInt64(GetCurrentColumnValue("IdControlOperaciones"));
        }

        private void xrSubreport6_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ((DetailControlTotal)((XRSubreport)sender).ReportSource).IdControl.Value = Convert.ToInt64(GetCurrentColumnValue("IdControlOperaciones"));
        }

        private void xrSubreport7_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ((DetailControlProducto)((XRSubreport)sender).ReportSource).IdControl.Value = Convert.ToInt64(GetCurrentColumnValue("IdControlOperaciones"));
        }

        private void xrSubreport8_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ((DetailControlResumenPCT)((XRSubreport)sender).ReportSource).IdControl.Value = Convert.ToInt64(GetCurrentColumnValue("IdControlOperaciones"));
        }

        private void xrSubreport9_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ((DetailControlAsimilados)((XRSubreport)sender).ReportSource).IdControl.Value = Convert.ToInt64(GetCurrentColumnValue("IdControlOperaciones"));
        }

        private void xrSubreport10_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ((DetailControlDispersionAsimilados)((XRSubreport)sender).ReportSource).IdControl.Value = Convert.ToInt64(GetCurrentColumnValue("IdControlOperaciones"));
        }
    }
}
