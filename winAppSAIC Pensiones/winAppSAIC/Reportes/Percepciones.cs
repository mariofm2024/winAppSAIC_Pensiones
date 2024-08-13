using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace winAppSAIC
{
    public partial class Percepciones : DevExpress.XtraReports.UI.XtraReport
    {
        public Percepciones()
        {
            InitializeComponent();
        }

        private void Percepciones_DataSourceDemanded(object sender, EventArgs e)
        {
            //asignar el valor del parámetro y obtener registros
            this.stpSelPercepcionesRecibosEmpleadosSATableAdapter.Fill(this.dbSAICBPOReportesDataSet1.stpSelPercepcionesRecibosEmpleadosSA, Convert.ToInt64(pIdPDOHeader.Value), Convert.ToInt64(pIdLoteCargaNomina.Value));
        }

    }
}
