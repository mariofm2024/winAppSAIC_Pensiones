using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace winAppSAIC.ControlOperaciones
{
    public partial class frmxCancelarSolicitud : DevExpress.XtraEditors.XtraForm
    {
        public string pRespuesta = "";
        public bool bFlag = false;

        public frmxCancelarSolicitud()
        {
            InitializeComponent();
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (txtJustifi.Text != string.Empty)
                {
                    pRespuesta = txtJustifi.Text;
                    bFlag = true;
                    Close();
                }
                else
                    XtraMessageBox.Show("¡Se requiere un Motivo!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}