using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace winAppSAIC.ReportesCFDI
{
    public partial class AcuseRecibosNominaSueldosAsimiladosXML : DevExpress.XtraReports.UI.XtraReport
    {
        public AcuseRecibosNominaSueldosAsimiladosXML()
        {
            InitializeComponent();
        }

        private void AcuseRecibosNominaSueldosAsimiladosXML_DataSourceDemanded(object sender, EventArgs e)
        {
            //Ejecutar stored procedure con los parametros recibidos antes de mostrar la informacion            
            this.stpSelAcuseRecibosNominaSueldosAsimiladosXMLTableAdapter1.Fill(this.dbSAICBPONominaCFDIDataSet1.stpSelAcuseRecibosNominaSueldosAsimiladosXML,
                Convert.ToInt64(this.pIdLoteCargaNomina.Value));
        }

    }
}
