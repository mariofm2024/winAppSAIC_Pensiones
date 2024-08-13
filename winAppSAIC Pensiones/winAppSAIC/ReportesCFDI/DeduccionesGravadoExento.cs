using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace winAppSAIC.ReportesCFDI
{
    public partial class DeduccionesGravadoExento : DevExpress.XtraReports.UI.XtraReport
    {
        public DeduccionesGravadoExento()
        {
            InitializeComponent();
        }

        private void DeduccionesGravadoExento_DataSourceDemanded(object sender, EventArgs e)
        {
            //asignar los valores de parámetros y obtener registros
            this.stpSelDeduccionesGravadoExentoRecibosEmpleadosSATableAdapter1.Fill(this.dbSAICBPONominaCFDIDataSet1.stpSelDeduccionesGravadoExentoRecibosEmpleadosSA, Convert.ToInt64(pIdPDOHeader.Value), pTipoMovimientoNomina.Value.ToString(), Convert.ToInt64(pIdLoteCargaNomina.Value)); 
        }

    }
}
