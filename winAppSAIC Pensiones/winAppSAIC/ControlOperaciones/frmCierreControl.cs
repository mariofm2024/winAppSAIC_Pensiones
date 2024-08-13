using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using compCatalogosSAIC;

namespace winAppSAIC.Facturas
{
    public partial class frmCierreControl : DevExpress.XtraEditors.XtraForm
    {
        public Int64 pIdControl = 0;
        public bool pFLAG = false;
        public bool pBoton = true;
        public string pRespuesta = "";
        public frmCierreControl()
        {
            InitializeComponent();
        }

        private void frmCierreControl_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'dbSAICBPODataSet.stpSelMes' table. You can move, or remove it, as needed.
                this.stpSelMesTableAdapter.Fill(this.dbSAICBPODataSet.stpSelMes);
                // TODO: This line of code loads data into the 'dbSAICBPODataSet.stpSelTipoPoliza' table. You can move, or remove it, as needed.
                this.stpSelTipoPolizaTableAdapter.Fill(this.dbSAICBPODataSet.stpSelTipoPoliza);
                spAnoPago.Value = DateTime.Now.Year;    //asignar año actual
                toolStripButton1.Visible = pBoton;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Close(); //Cerrar Ventana
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            string strError = "";
            try
            {
                if (cboMesPago.Text.Length == 0)
                    strError += "\t >Mes de Pago" + "\n";

                if (spAnoPago.Value <= 0)
                    strError += "\t >Año de Pago" + "\n";

                if (strError.Length > 0)
                    MessageBox.Show("Falta esta información: \n" + strError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (pFLAG)
                        Crear();
                    else if (Convert.ToInt32(cboMesPago.EditValue) <= 12)
                        Crear();
                    else
                        XtraMessageBox.Show("Solo puedes seleccionar de Enero - Diciembre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Crear()
        {
            if (pIdControl != 0)
            {
                this.spSoloRespuesta1.stpFactUpdBloquearControlesV2(pIdControl, true, Convert.ToInt16(spAnoPago.Text), Convert.ToByte(cboMesPago.EditValue),
                                                                        txtObservaciones.Text.Trim(), OperadorBD.OperadorGlobal.NombreOperador, ref pRespuesta);
            }

            if (pRespuesta.Length > 0)
                XtraMessageBox.Show(pRespuesta, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                XtraMessageBox.Show("¡Error al Cerrar el Control de Operaciones, intentelo mas tarde!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}