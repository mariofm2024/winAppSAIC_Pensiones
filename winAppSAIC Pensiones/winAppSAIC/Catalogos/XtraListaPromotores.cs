using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace winAppSAIC.Catalogos
{
    public partial class XtraListaPromotores : DevExpress.XtraEditors.XtraForm
    {
        public Int32 bIdCliente = 0;

        public XtraListaPromotores()
        {
            InitializeComponent();
        }

        private void btnSAlir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void XtraListaPromotores_Load(object sender, EventArgs e)
        {
            try
            {
                this.stpSelClientePromotoresDetalleTableAdapter.Fill(this.dbSAIC_Catalogos.stpSelClientePromotoresDetalle, bIdCliente);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}