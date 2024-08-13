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
    public partial class XtraTextBox : DevExpress.XtraEditors.XtraForm
    {

        public String sTextBox { get; set; }

        public XtraTextBox(String sNombreVentana, String sNombreLabel, int iMaxLenghTextBox)
        {
            InitializeComponent();
            this.Text = sNombreVentana;
            lblNombre.Text = sNombreLabel + ":";
            txtTextBox.Properties.MaxLength = iMaxLenghTextBox;
        }

        private void XtraTextBox_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTextBox.Text))
            {
                DialogResult oDialogResult = XtraMessageBox.Show(lblNombre.Text + " se encuentra vacio. ¿Desea continuar?", "SAIC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == oDialogResult)
                {
                    sTextBox = txtTextBox.Text;
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                DialogResult = DialogResult.OK;
                sTextBox = txtTextBox.Text;
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            sTextBox = String.Empty;
            this.Close();
        }
    }
}