using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace winAppSAIC
{
    public partial class frmxVisualizarRelacionMovimientos : DevExpress.XtraEditors.XtraForm
    {
        #region "Propiedades Propias"

        public DataTable dtMovsTarjetasCheques
        {
            get;
            set;
        }

        public DataTable dtMovsInterbancarios
        {
            get;
            set;
        }

        #endregion

        public frmxVisualizarRelacionMovimientos()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();        //cerrar pantalla
        }

        private void frmxVisualizarRelacionMovimientos_Load(object sender, EventArgs e)
        {
            try
            {
                gvMovsTarjetasCheques.DataSource = dtMovsTarjetasCheques;
                gvMovsInterbancarios.DataSource = dtMovsInterbancarios;

                lblNoMovsTarjetasCheques.Text = dtMovsTarjetasCheques.Rows.Count.ToString();
                lblNoMovsInterbancarios.Text = dtMovsInterbancarios.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}