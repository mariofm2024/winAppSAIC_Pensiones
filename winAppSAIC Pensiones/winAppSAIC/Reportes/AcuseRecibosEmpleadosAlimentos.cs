using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace winAppSAIC
{
    public partial class AcuseRecibosEmpleadosAlimentos : DevExpress.XtraReports.UI.XtraReport
    {
        public AcuseRecibosEmpleadosAlimentos()
        {
            InitializeComponent();
        }

        /// <summary>
        /// evento utilizado para pasar los parametros que recibe un reporte 
        /// y que se ejecutan en el stored procedure
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AcuseRecibosEmpleadosAlimentos_DataSourceDemanded(object sender, EventArgs e)
        {
            //Ejecutar stored procedure con los parametros recibidos antes de mostrar la informacion            
            this.stpSelAcuseRecibosNominaAlimentosSCTableAdapter.Fill(this.dbSAICBPOReportesDataSet1.stpSelAcuseRecibosNominaAlimentosSC,
                Convert.ToInt64(this.pIdLoteCargaNomina.Value));
        }

    }
}
