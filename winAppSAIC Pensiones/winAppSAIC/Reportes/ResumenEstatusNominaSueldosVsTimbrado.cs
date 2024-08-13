using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace winAppSAIC.Reportes
{
    public partial class ResumenEstatusNominaSueldosVsTimbrado : DevExpress.XtraReports.UI.XtraReport
    {
        public ResumenEstatusNominaSueldosVsTimbrado()
        {
            InitializeComponent();
        }

        private void ResumenEstatusNominaSueldosVsTimbrado_DataSourceDemanded(object sender, EventArgs e)
        {
            //asignar parametro al stored procedure
            this.stpSelObtenerEstatusNominaSueldosVsTimbradoTableAdapter1.Fill(dbSAICBPOReportesDataSet1.stpSelObtenerEstatusNominaSueldosVsTimbrado, Convert.ToInt64(pIdLoteCargaNomina.Value));
        }

    }
}
