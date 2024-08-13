using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace winAppSAIC.Asimilados.Reporte
{
    public partial class ResumenDispersionBanco : DevExpress.XtraReports.UI.XtraReport
    {
        public ResumenDispersionBanco()
        {
            InitializeComponent();
        }


        private void ResumenDispersionBanco_DataSourceDemanded(object sender, EventArgs e)
        {
            //asignar parametro al stored procedure
            try
            {
                this.stpFactSelLoteOperacionesDisperTableAdapter.Fill(dbSAICAsimilados1.stpFactSelLoteOperacionesDisper, pTipo.Value.ToString(), Convert.ToInt64(pIdLoteCargaNomina.Value));
            }
            catch (Exception)
            {
                
            }
        }
    }
}
