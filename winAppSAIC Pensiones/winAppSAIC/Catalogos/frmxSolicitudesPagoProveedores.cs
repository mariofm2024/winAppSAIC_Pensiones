using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using winAppSAIC.UtileriasLocal;
using compCatalogosSAIC;

namespace winAppSAIC.Catalogos
{
    public partial class frmxSolicitudesPagoProveedores : Form
    {
        public frmxSolicitudesPagoProveedores()
        {
            InitializeComponent();
        }

        private void frmxSolicitudesPagoProveedores_Load(object sender, EventArgs e)
        {

            
            
           txtIdAreaOperativa.Text = OperadorBD.OperadorGlobal.NombreUsuario;
            txtIdNombreUsuario.Text = OperadorBD.OperadorGlobal.IdAreaOperativa.ToString();

            this.vwCatAreaOperativaTableAdapter1.Fill(this.dbSAICBPOCatalogosDataSet.vwCatAreaOperativa);

            
            //Id = cmbArea.SelectedIndex
            cmbArea.EditValue = OperadorBD.OperadorGlobal.IdAreaOperativa.ToString();
            dtFechaSolicitud.EditValue = DateTime.Now.Date;

            this.vwAreaOpTipoPagoProvTableAdapter1.Fill(this.dbSAICBPOCatalogosDataSet.vwAreaOpTipoPagoProv);


            DataTable dtAreaOpTipoPagoProv = this.vwAreaOpTipoPagoProvTableAdapter1.GetData();
int IdAreaOperativa = OperadorBD.OperadorGlobal.IdAreaOperativa;

            //DataTable dtFAreaOpTipoPagoProv = ( from x in dtAreaOpTipoPagoProv.AsEnumerable()
            //                                    where x.Field<int>("IdAreaOperativa").Equals(IdAreaOperativa)
            //                                    select x).CopyToDataTable();

            //
            //////var table = new DataTable();
            //////table.Columns.Add("IdTipoPagoProveedor", typeof(int));
            //////table.Columns.Add("DescTipoPagoProveedor", typeof(string));

            //////var query = from x in dtAreaOpTipoPagoProv.AsEnumerable()
            //////            where x.Field<int>("IdAreaOperativa").Equals(IdAreaOperativa)
            //////            select new {
            //////                IdTipoPagoProveedor = x.Field<int>("IdTipoPagoProveedor"),
            //////                DescTipoPagoProveedor = x.Field<string>("DescTipoPagoProveedor")
            //////            };

            var table = new DataTable();
            table.Columns.Add("IdTipoPagoProveedor", typeof(int));
            table.Columns.Add("DescTipoPagoProveedor", typeof(string));

            var query = from x in dtAreaOpTipoPagoProv.AsEnumerable()
                        where x.Field<int>("IdAreaOperativa").Equals(IdAreaOperativa)
                        select new  {x.IdTipoPagoProveedor , x.DescTipoPagoProveedor};

            //DataTable dtFAreaOpTipoPagoProv = 
            query.CopyToDataTable(table, LoadOption.PreserveChanges);



            if (dtFAreaOpTipoPagoProv.Rows.Count > 0)
            {
                gdTipoPagoProveedor.Properties.DataSource = dtFAreaOpTipoPagoProv;
                //dtTipoPagoProv.Rows.[0].["IdTipoPagoProveedor"].ToString();
            }


            //'gdTipoPagoProveedor.DataBindings


                //txtIdAreaOperativa.Text = dt.Rows.Count.ToString();

                //gcSolicitudes.Height = 257 ;
                //gcSolicitudes.Width = 1000;
        }

        //private void frmxSolicitudesPagoProveedores_Load(object sender, EventArgs e)
        //{
        //    XtraMessageBox.Show("Load");
        //}
    }
}
