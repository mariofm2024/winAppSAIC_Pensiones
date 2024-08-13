using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace winAppSAIC.Administracion
{
    public partial class XtraMonitoreoAltas : DevExpress.XtraEditors.XtraForm
    {
        public XtraMonitoreoAltas()
        {
            InitializeComponent();
        }

        private void toolStripbtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}