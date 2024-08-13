using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace winAppSAIC.NominaCFDI
{
    public partial class frmxErroresTimbradoCFDI : DevExpress.XtraEditors.XtraForm
    {
        public frmxErroresTimbradoCFDI()
        {
            InitializeComponent();
        }

        //propiedad para recibir Lote de Nomina con error
        public Int64 pIdLoteCargaNomina
        {
            get;
            set;
        }

        //propiedad para recibir el IdTipoError (1= Error Timbrado, 2=Error Cancelacion Timbrado)
        public byte pIdTipoError
        {
            get;
            set;
        }

        private void frmxErroresTimbradoCFDI_Load(object sender, EventArgs e)
        {
            try
            {
                if (pIdTipoError.Equals(1))
                    //cambiar titulo de la pantalla
                    this.Text = "Errores de Timbrado XML CFDI Lote No. " + pIdLoteCargaNomina.ToString();
                else if (pIdTipoError.Equals(2))
                    //cambiar titulo de la pantalla
                    this.Text = "Errores de Cancelación XML CFDI Lote No. " + pIdLoteCargaNomina.ToString();

                 this.stpSelErroresTimbradoCFDITableAdapter.Fill(this.dbSAICBPONominaCFDIDataSet.stpSelErroresTimbradoCFDI, pIdLoteCargaNomina, pIdTipoError);
            }
            catch (System.Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();        //cerrar pantalla
        }
    }
}