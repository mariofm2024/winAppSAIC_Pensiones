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

namespace winAppSAIC.Facturas
{
    public partial class frmCancelarSolicitud : DevExpress.XtraEditors.XtraForm
    {
        public Int64 pIdSolicitud = 0;
        public frmCancelarSolicitud()
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
                if (txtJustifi.Text != string.Empty)
                {
                    string pError = "";
                    this.spSoloRespuesta1.stpFactDelCancelarSolicitudFacturaV2(pIdSolicitud, txtJustifi.Text, OperadorBD.OperadorGlobal.NombreUsuario, ref pError);

                    if (pError == "")
                        XtraMessageBox.Show("¡La Solicitud se Cancelo Correctamente!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        XtraMessageBox.Show("Error: " + pError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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