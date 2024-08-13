using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace winAppSAIC.Tesoreria
{
    public partial class frmxSolicitudAltaEmpleadosTesoreria : DevExpress.XtraEditors.XtraForm
    {
        public frmxSolicitudAltaEmpleadosTesoreria()
        {
            InitializeComponent();
        }

        private void btnSolicitudAtendida_Click(object sender, EventArgs e)
        {
            //Obtener Opcion
           
        }

        private String cualOpcion()
        {
            String stOpcionenCheck = String.Empty;

            if (rdTenedoraSA.Checked)
            {
                stOpcionenCheck = rdTenedoraSA.Text;
            }
            else if (rdTenedorSC.Checked)
            {
                stOpcionenCheck = rdTenedorSC.Text;
            }
            else if (rdTarjeta.Checked)
            {
                stOpcionenCheck = rdTarjeta.Text;
            }

            return stOpcionenCheck;
        }
    }
}