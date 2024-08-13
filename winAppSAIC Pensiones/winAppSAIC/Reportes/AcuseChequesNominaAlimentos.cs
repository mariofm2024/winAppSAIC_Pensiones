using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace winAppSAIC
{
    public partial class AcuseChequesNominaAlimentos : DevExpress.XtraReports.UI.XtraReport
    {
        public AcuseChequesNominaAlimentos()
        {
            InitializeComponent();
        }

        /// <summary>
        /// evento utilizado para pasar los parametros que recibe un reporte 
        /// y que se ejecutan en el stored procedure
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AcuseChequesNominaAlimentos_DataSourceDemanded(object sender, EventArgs e)
        {
            //Ejecutar stored procedure con los parametros recibidos antes de mostrar la informacion            
            this.stpSelAcuseChequesNominaAlimentosSCTableAdapter.Fill(this.dbSAICBPOReportesDataSet1.stpSelAcuseChequesNominaAlimentosSC,
                       Convert.ToInt64(this.pIdLoteCargaNomina.Value));
        }

    }
}
