using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace winAppSAIC.Contablidad
{
    public partial class frmxCierreNominaContable : DevExpress.XtraEditors.XtraForm
    {
        public frmxCierreNominaContable()
        {
            InitializeComponent();
        }

        private void frmxCierreNominaContable_Load(object sender, EventArgs e)
        {
            try
            {
                this.stpSelTipoPolizaTableAdapter.Fill(this.dbSAICBPODataSet.stpSelTipoPoliza);
                this.stpSelMesTableAdapter.Fill(this.dbSAICBPODataSet.stpSelMes);
                spAnoPago.Value = DateTime.Now.Year;    //asignar año actual
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string strError = "";

            if (cboTipoPoliza.Text.Length == 0)
                strError = "\t >Tipo de Póliza" + "\n";

            if (txtFolioPoliza.Text.Trim().Length ==0)
                strError += "\t >Folio Póliza" + "\n";

            if (cboFechaPoliza.Text.Length == 0)
                strError += "\t >Fecha Póliza" + "\n";

            if (txtImportePoliza.Text.Trim().Length == 0)
                strError += "\t >Importe Póliza" + "\n";

            if (cboMesPago.Text.Length == 0)
                strError += "\t >Mes de Pago" + "\n";

            if (spAnoPago.Value <= 0)
                strError += "\t >Año de Pago" + "\n";

            if (strError.Length > 0)
                XtraMessageBox.Show("Falta esta información: \n" + strError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}