using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace winAppSAIC.tools
{
    public partial class xFormsSolicitarFecha : DevExpress.XtraEditors.XtraForm
    {
        public DateTime dtFechaSeleccionada { get; set; }
        public xFormsSolicitarFecha(String stVentana, String stTitulo, String stDescripcion)
        {
            InitializeComponent();
            this.Text = stVentana;
            labelTitulo.Text = stTitulo;
            labelDescripcion.Text = stDescripcion;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void xFormsSolicitarFecha_Load(object sender, EventArgs e)
        {
            String stfechaServidor = String.Empty;
            DateTime dtFechaServidor = new DateTime();
            stfechaServidor = stpSelEstatusNominaContabilizadaTableAdapter1.ObtenerFechaServidor().ToString();
            DateTime.TryParse(stfechaServidor, out dtFechaServidor);
            dtFecha.DateTime = dtFechaServidor;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            dtFechaSeleccionada = dtFecha.DateTime;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dtFechaSeleccionada = new DateTime(1900, 01, 01);
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}