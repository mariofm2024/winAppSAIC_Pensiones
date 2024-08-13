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
using compUtileriasVBNet;
using winAppSAIC.UtileriasLocal;

namespace winAppSAIC.Facturas
{
    public partial class frmRechazarSolicitud : DevExpress.XtraEditors.XtraForm
    {
        public Int64 pIdSolicitud = 0;
        public frmRechazarSolicitud()
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
            int respuesta = 0;
            try
            {
                if (txtJustifi.Text != string.Empty)
                {
                   this.spSoloRespuesta1.stpFactUpdRechazarSolicitudFactura(pIdSolicitud, txtJustifi.Text, OperadorBD.OperadorGlobal.NombreUsuario);
                    XtraMessageBox.Show("¡La Solicitud se Rechazo Correctamente!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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