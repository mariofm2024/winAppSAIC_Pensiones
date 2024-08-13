using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace winAppSAIC.reportes
{
    public partial class ReporteAsimilados : DevExpress.XtraReports.UI.XtraReport
    {
        public ReporteAsimilados()
        {
            InitializeComponent();
        }

        //evento utilizado para pasar los parametros que recibe un reporte 
        //y que se ejecutan en el stored procedure
        private void ReporteAsimilados_DataSourceDemanded(object sender, EventArgs e)
        {
            //Ejecutar stored procedure con los parametros recibidos antes de mostrar la informacion            
            this.stpSelRecibosAsimiladosHeaderSATableAdapter1.Fill(this.dbSAICBPOReportesDataSet1.stpSelRecibosAsimiladosHeaderSA,
                Convert.ToInt64(this.pIdLoteCargaNomina.Value));
        }

    }
}
