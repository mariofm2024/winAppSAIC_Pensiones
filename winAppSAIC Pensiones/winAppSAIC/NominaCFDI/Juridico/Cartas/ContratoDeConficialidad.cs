using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace winAppSAIC.Juridico.Cartas
{
    public partial class ContratoDeConficialidad : DevExpress.XtraReports.UI.XtraReport
    {
        public ContratoDeConficialidad()
        {
            InitializeComponent();

        }

        private void ContratoDeConficialidad_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrRichTextContrato.Html = stContrato.Value.ToString();
        }
    }
}
