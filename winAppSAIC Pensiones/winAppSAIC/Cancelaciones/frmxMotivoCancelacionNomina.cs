using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace winAppSAIC.Cancelaciones
{
    public partial class frmxMotivoCancelacionNomina : DevExpress.XtraEditors.XtraForm
    {
        public frmxMotivoCancelacionNomina()
        {
            InitializeComponent();
        }

        private void frmxMotivoCancelacionNomina_Load(object sender, EventArgs e)
        {
            txtMotivoCancelacion.Focus();     //mover cursor al control
        }
    }
}