using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace winAppSAIC.ReportesTesoreria
{
    public partial class ImpresionChequeCIB_Epson : DevExpress.XtraReports.UI.XtraReport
    {
        public ImpresionChequeCIB_Epson()
        {
            InitializeComponent();
        }

        private void ImpresionChequeCIB_DataSourceDemanded(object sender, EventArgs e)
        {
            //asignar el valor del parámetro y obtener registros
            this.stpSelImpresionChequeTableAdapter.Fill(this.dbSAICBPOTesoreriaDataSet1.stpSelImpresionCheque, Convert.ToInt64(this.pIdTransaccionBanco.Value), Convert.ToInt64(this.pIdTransaccionBancoFinal.Value), Convert.ToInt32(this.pIdCuentaBanco.Value));
        }

    }
}
