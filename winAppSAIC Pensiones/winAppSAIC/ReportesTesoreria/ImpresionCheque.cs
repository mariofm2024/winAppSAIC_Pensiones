using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting;

namespace winAppSAIC.ReportesTesoreria
{
    public partial class ImpresionCheque : DevExpress.XtraReports.UI.XtraReport
    {
        public ImpresionCheque()
        {
            InitializeComponent();
        }

        private void ImpresionCheque_DataSourceDemanded(object sender, EventArgs e)
        {
            //asignar el valor del parámetro y obtener registros
            this.stpSelImpresionChequeTableAdapter1.Fill(this.dbSAICBPOTesoreriaDataSet1.stpSelImpresionCheque, Convert.ToInt64(this.pIdTransaccionBanco.Value), Convert.ToInt64(this.pIdTransaccionBancoFinal.Value), Convert.ToInt32(this.pIdCuentaBanco.Value));
        }
    }
}
