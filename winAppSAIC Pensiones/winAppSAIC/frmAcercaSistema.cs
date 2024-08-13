using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace winAppSAIC
{
    public partial class frmAcercaSistema : DevExpress.XtraEditors.XtraForm
    {
        public frmAcercaSistema()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();        //cerrar pantalla
        }
    }
}
