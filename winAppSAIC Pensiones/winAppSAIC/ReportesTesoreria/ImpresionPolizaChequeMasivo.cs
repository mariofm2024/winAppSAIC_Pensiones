using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace winAppSAIC.ReportesTesoreria
{
    public partial class ImpresionPolizaChequeMasivo : DevExpress.XtraReports.UI.XtraReport
    {
        public ImpresionPolizaChequeMasivo()
        {
            InitializeComponent();
        }

        private void ImpresionPolizaChequeMasivo_DataSourceDemanded(object sender, EventArgs e)
        {
            //asignar el valor del parámetro y obtener registros
            this.stpSelImpresionPolizaChequeMasivoTableAdapter1.Fill(this.dbSAICBPOTesoreriaDataSet1.stpSelImpresionPolizaChequeMasivo, Convert.ToInt32(this.pIdCuentaBanco.Value),
                this.pNoTransaccionInicial.Value.ToString(), this.pNoTransaccionFinal.Value.ToString());       
        }

    }
}
