using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace winAppSAIC.ReportesTesoreria
{
    public partial class ImpresionPolizaCheque : DevExpress.XtraReports.UI.XtraReport
    {
        public ImpresionPolizaCheque()
        {
            InitializeComponent();
        }

        private void ImpresionPolizaCheque_DataSourceDemanded(object sender, EventArgs e)
        {
            //asignar el valor del parámetro y obtener registros
            this.stpSelImpresionPolizaChequeTableAdapter.Fill(this.dbSAICBPOTesoreriaDataSet1.stpSelImpresionPolizaCheque, Convert.ToInt64(this.pIdTransaccionBanco.Value));
        }

    }
}
