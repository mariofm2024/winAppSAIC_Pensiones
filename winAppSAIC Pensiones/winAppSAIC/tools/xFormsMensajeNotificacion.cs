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

namespace winAppSAIC.tools
{
    public partial class xFormsMensajeNotificacion : DevExpress.XtraEditors.XtraForm
    {
        String stTema;
        String stSubTema;
        String StDescripcion;
        DateTime dtFecha;
        int idNotificacion;
        public xFormsMensajeNotificacion(int idNotificacion, String stTema, String stSubTema, String StDescripcion, DateTime dtFecha)
        {
            InitializeComponent();
            this.stTema = stTema;
            this.stSubTema = stSubTema;
            this.StDescripcion = StDescripcion;
            this.dtFecha = dtFecha;
            this.idNotificacion = idNotificacion;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void xFormsMensajeNotificacion_Load(object sender, EventArgs e)
        {
            lblTema.Text = stTema;
            lblSubtema.Text = stSubTema;
            lblDescripcion.Text = StDescripcion;
            lblFechaHora.Text = dtFecha.Date.ToString("dd/MM/yyyy") + " " + dtFecha.Hour.ToString("##") + ":" + dtFecha.Minute.ToString("##");
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                queriesTableAdapter1.stpUpdNotificaciones(idNotificacion, OperadorBD.OperadorGlobal.IdOperador);
                this.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("No se puede actualizar la Notificacion."
                   , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}