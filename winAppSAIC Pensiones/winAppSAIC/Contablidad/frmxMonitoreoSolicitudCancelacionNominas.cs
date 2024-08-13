using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace winAppSAIC.Contablidad
{
    public partial class frmxMonitoreoSolicitudCancelacionNominas : DevExpress.XtraEditors.XtraForm
    {
        public frmxMonitoreoSolicitudCancelacionNominas()
        {
            InitializeComponent();
        }

        private void frmxMonitoreoSolicitudCancelacionNominas_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'dbSAICBPODataSet.vwInfoDetalleSolicitudCancelacionNomina' table. You can move, or remove it, as needed.
                this.vwInfoDetalleSolicitudCancelacionNominaTableAdapter.Fill(this.dbSAICBPODataSet.vwInfoDetalleSolicitudCancelacionNomina);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();        //cerrar pantalla
        }
    }
}