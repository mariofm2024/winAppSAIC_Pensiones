using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace winAppSAIC.Reportes.ControlOperaciones
{
    public partial class DetailControlProducto : DevExpress.XtraReports.UI.XtraReport
    {
        public DetailControlProducto()
        {
            InitializeComponent();
        }

        private void DetailControlProducto_DataSourceDemanded(object sender, EventArgs e)
        {
            this.stpFactSelCOProductosTableAdapter1.Fill(this.dbSAICBPOFactura1.stpFactSelCOProductos, Convert.ToInt64(IdControl.Value));
        }
    }
}
