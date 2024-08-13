using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace winAppSAIC.ReportesCFDI
{
    public partial class PercepcionesGravadoExento : DevExpress.XtraReports.UI.XtraReport
    {
        public PercepcionesGravadoExento()
        {
            InitializeComponent();
        }

        private void PercepcionesGravadoExento_DataSourceDemanded(object sender, EventArgs e)
        {
            //asignar los valores de parámetros y obtener registros
            this.stpSelPercepcionesGravadoExentoRecibosEmpleadosSATableAdapter1.Fill(this.dbSAICBPONominaCFDIDataSet1.stpSelPercepcionesGravadoExentoRecibosEmpleadosSA, Convert.ToInt64(pIdPDOHeader.Value), pTipoMovimientoNomina.Value.ToString(), Convert.ToInt64(pIdLoteCargaNomina.Value));
        }

    }
}
