using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace winAppSAIC.Asimilados.Reporte
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
            this.stpSelObtenerEstatusNominaSueldosVsTimbradoTableAdapter.Fill(dbSAICAsimilados1.stpSelObtenerEstatusNominaSueldosVsTimbrado, Convert.ToInt64(pIdLoteCargaNomina.Value));
        }

    }
}
