using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace winAppSAIC
{
    public partial class RecibosEmpleadosAlimentos : DevExpress.XtraReports.UI.XtraReport
    {
        public RecibosEmpleadosAlimentos()
        {
            InitializeComponent();
        }

        private void RecibosEmpleadosAlimentos_DataSourceDemanded(object sender, EventArgs e)
        {
            //asignar el valor del parámetro y obtener registros
            this.stpSelRecibosEmpleadosHeaderSCTableAdapter.Fill(this.dbSAICBPOReportesDataSet1.stpSelRecibosEmpleadosHeaderSC, Convert.ToInt64(pIdLoteCargaNomina.Value));
        }

    }
}
