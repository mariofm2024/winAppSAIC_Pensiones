using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using compCatalogosSAIC;

namespace winAppSAIC.ControlOperaciones
{
    public partial class frmxCancelarControl : DevExpress.XtraEditors.XtraForm
    {
        public long objPantalla;
        public frmxCancelarControl()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //Cerrar Ventana 
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMotivo.Text.Trim().Length > 0 )
                {
                    this.spSoloRespuesta1.stpFactDelControlOperaciones(objPantalla, txtMotivo.Text, OperadorBD.OperadorGlobal.NombreUsuario);
                    XtraMessageBox.Show(String.Format("¡La Solicitud de Cancelación  del control {0} se realizó correctamente!", objPantalla.ToString()), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Cerrar Ventana 
                    Close();
                }
                else
                {
                    XtraMessageBox.Show("¡Debe de registrar un motivo!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }       //try
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}
    }
}