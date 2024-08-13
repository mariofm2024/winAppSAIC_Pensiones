using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace winAppSAIC.ReportesCFDI
{
    public partial class ReporteNominaSueldosTimbradosCFDI : DevExpress.XtraReports.UI.XtraReport
    {
        public ReporteNominaSueldosTimbradosCFDI()
        {
            InitializeComponent();
        }

        private void ReporteNominaSueldosTimbradosCFDI_DataSourceDemanded(object sender, EventArgs e)
        {
            //Ejecutar stored procedure con los parametros recibidos antes de mostrar la informacion            
            this.stpSelReporteNominaSueldosSATimbradosCFDITableAdapter1.Fill(this.dbSAICBPONominaCFDIDataSet1.stpSelReporteNominaSueldosSATimbradosCFDI,
                Convert.ToInt64(this.pIdLoteCargaNomina.Value));
        }

    }
}
