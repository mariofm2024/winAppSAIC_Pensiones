using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace winAppSAIC
{
    public partial class Deducciones : DevExpress.XtraReports.UI.XtraReport
    {
        public Deducciones()
        {
            InitializeComponent();
        }

        private void Deducciones_DataSourceDemanded(object sender, EventArgs e)
        {
            //asignar el valor del parámetro y obtener registros
            this.stpSelDeduccionesRecibosEmpleadosSATableAdapter.Fill(this.dbSAICBPOReportesDataSet1.stpSelDeduccionesRecibosEmpleadosSA, Convert.ToInt64(pIdPDOHeader.Value), Convert.ToInt64(pIdLoteCargaNomina.Value));
        }

    }
}
