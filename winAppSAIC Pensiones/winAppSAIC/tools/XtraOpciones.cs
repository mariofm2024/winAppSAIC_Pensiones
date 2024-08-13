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
    public partial class XtraOpciones : DevExpress.XtraEditors.XtraForm
    {

        public int iResultado = 0;

        String stDescripcion = String.Empty;
        String stOpcion1 = String.Empty;
        String stOpcion2 = String.Empty;
        public XtraOpciones(String stDescripcion, String stOpcion1, String stOpcion2)
        {
            InitializeComponent();
            this.stDescripcion = stDescripcion;
            this.stOpcion1 = stOpcion1;
            this.stOpcion2 = stOpcion2;
        }

        private void XtraOpciones_Load(object sender, EventArgs e)
        {
            lblDescripcion.Text = stDescripcion;
            btnOpcion1.Text = stOpcion1;
            btnOpcion2.Text = stOpcion2;
        }

        private void btnOpcion1_Click(object sender, EventArgs e)
        {
            iResultado = 1;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnOpcion2_Click(object sender, EventArgs e)
        {
            iResultado = 2;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}