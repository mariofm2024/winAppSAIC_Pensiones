using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace winAppSAIC.Tesoreria
{
    public partial class frmxMotivoCancelacionMovChequera : DevExpress.XtraEditors.XtraForm
    {
        public frmxMotivoCancelacionMovChequera()
        {
            InitializeComponent();
        }

        private void frmxSolicitudCancelacionNomina_Load(object sender, EventArgs e)
        {
            cboSustituyeCheque.Focus();     //mover cursor al control
            cboSustituyeCheque.SelectedIndex = 0;   //seleccionar NO
            txtNoCheque.Enabled = false;    //bloquear NoCheque
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cboSustituyeCheque.Text.Equals("SI"))
            {
                if (Convert.ToInt64(txtNoCheque.EditValue) <= 0)
                    XtraMessageBox.Show("El No. de Cheque que sustituye debe ser MAYOR a Cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else if (cboSustituyeCheque.Text.Equals("NO"))
            {
                txtNoCheque.EditValue = 0;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        private void cboSustituyeCheque_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSustituyeCheque.Text.Equals("SI"))
                txtNoCheque.Enabled = true;
            else
                txtNoCheque.Enabled = false;

            txtNoCheque.EditValue = 0;      //inicializar
        }
    }
}