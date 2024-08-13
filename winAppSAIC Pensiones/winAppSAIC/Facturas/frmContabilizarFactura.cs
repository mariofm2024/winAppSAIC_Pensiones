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
    public partial class frmContabilizarFactura : DevExpress.XtraEditors.XtraForm
    {
        public Int64 pIdFactura = 0;
        public String pIdFacturaS = "";
        public frmContabilizarFactura()
        {
            InitializeComponent();
        }

        private void frmContabilizarFactura_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'dbSAICBPODataSet.stpSelMes' table. You can move, or remove it, as needed.
                this.stpSelMesTableAdapter.Fill(this.dbSAICBPODataSet.stpSelMes);
                // TODO: This line of code loads data into the 'dbSAICBPODataSet.stpSelTipoPoliza' table. You can move, or remove it, as needed.
                this.stpSelTipoPolizaTableAdapter.Fill(this.dbSAICBPODataSet.stpSelTipoPoliza);
                spAnoPago.Value = DateTime.Now.Year;    //asignar año actual
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
                if (cboTipoPoliza.Text.Length == 0)
                    strError = "\t >Tipo de Póliza" + "\n";

                if (txtFolioPoliza.Text.Trim().Length == 0)
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
                    MessageBox.Show("Falta esta información: \n" + strError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    int ? pOk = 0;

                    if (pIdFactura == 0 && pIdFacturaS.Length > 0)
                    {
                        this.spSoloRespuesta1.stpFactInsContabilizarFacturas(pIdFacturaS, cboTipoPoliza.EditValue.ToString(), txtFolioPoliza.Text.Trim(), Convert.ToDateTime(cboFechaPoliza.Text),
                                                                    Convert.ToDecimal(txtImportePoliza.Text.Trim().Replace(",", "")), txtObservaciones.Text.Trim(), Convert.ToInt16(spAnoPago.Text),
                                                                    Convert.ToByte(cboMesPago.EditValue), OperadorBD.OperadorGlobal.IdOperador, OperadorBD.OperadorGlobal.NombreOperador, ref pOk);
                    }
                    else
                    {
                        this.spSoloRespuesta1.stpFactInsContabilizarFactura(pIdFactura, cboTipoPoliza.EditValue.ToString(), txtFolioPoliza.Text.Trim(), Convert.ToDateTime(cboFechaPoliza.Text),
                                                                        Convert.ToDecimal(txtImportePoliza.Text.Trim().Replace(",", "")), txtObservaciones.Text.Trim(), Convert.ToInt16(spAnoPago.Text),
                                                                        Convert.ToByte(cboMesPago.EditValue), OperadorBD.OperadorGlobal.IdOperador, OperadorBD.OperadorGlobal.NombreOperador, ref pOk);
                    }

                    if (pOk == 1)
                    {
                        XtraMessageBox.Show("¡La(s) Factura(s) se Contabilizo(aron) Correctamente!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                        XtraMessageBox.Show("¡Error al Contabilizar Factura(s), intentelo mas tarde!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}