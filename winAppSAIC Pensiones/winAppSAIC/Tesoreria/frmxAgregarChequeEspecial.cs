using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using compUtileriasVBNet;
using winAppSAIC.UtileriasLocal;
using compCatalogosSAIC;

namespace winAppSAIC.Tesoreria
{
    public partial class frmxAgregarChequeEspecial : DevExpress.XtraEditors.XtraForm
    {
        public frmxAgregarChequeEspecial()
        {
            InitializeComponent();
        }

        #region "Variables Globales"
        private EmpleadoGenerico objEmpleadoGenerico;
        #endregion

        private void cboCategoriaTransaccionBanco_EditValueChanged(object sender, EventArgs e)
        {
            if (!cboCategoriaTransaccionBanco.EditValue.Equals(""))      //asegurar que el valor sea diferente de vacio
                //Obtener la información de la SubCategoriaTransaccionBanco
                this.stpSelSubCategoriaTransaccionBancoTableAdapter.Fill(this.dbSAICBPOCatalogosDataSet.stpSelSubCategoriaTransaccionBanco, Convert.ToInt32(cboCategoriaTransaccionBanco.EditValue));
        }

        private void frmxAgregarChequeEspecial_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbSAICBPOCatalogosDataSet.stpSelMoneda' table. You can move, or remove it, as needed.
            this.stpSelMonedaTableAdapter.Fill(this.dbSAICBPOCatalogosDataSet.stpSelMoneda);
            try
            {
                this.stpSelMonedaTableAdapter.Fill(this.dbSAICBPOCatalogosDataSet.stpSelMoneda);
                this.stpSelCategoriaTransaccionBancoTableAdapter.Fill(this.dbSAICBPOCatalogosDataSet.stpSelCategoriaTransaccionBanco, "OPER");
                //colocar la Categoria Transaccion con el valor CHEQUE por default
                cboCategoriaTransaccionBanco.EditValue = cboCategoriaTransaccionBanco.Properties.GetKeyValue(0);
                //colocar la Moneda con el valor PESOS por default
                cboIdMoneda.EditValue = cboIdMoneda.Properties.GetKeyValueByDisplayValue("PESOS");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtImporte_Leave(object sender, EventArgs e)
        {
            //convertir importe en Letra después que el cursor sale del control
            txtImporteLetra.Text = Convertidor.ConvierteImporte2Leyenda(Convert.ToDecimal(txtImporte.Text), cboIdMoneda.Text);
        }

        private void btnGuardarCheque_Click(object sender, EventArgs e)
        {
            try
            {
                //validaciones
                if (Validator.IsPositiveNumber(txtImporte) && Validator.IsPresent(txtNombreEmpleado) &&
                    Validator.IsPresent(txtBeneficiarioPoliza) && Validator.IsPresent(cboSubCategoriaTransaccionBanco) && 
                    Validator.IsPresentOtroConceptoSubClasificacion(cboSubCategoriaTransaccionBanco, txtOtroConcepto))
                { 
                    ChequesLineItem objCheque = new ChequesLineItem();
                    objCheque.MontoNetoPagar = Convert.ToDecimal(txtImporte.Text);
                    objCheque.ImporteConLetra = txtImporteLetra.Text.Trim();
                    objCheque.IdMoneda = cboIdMoneda.EditValue.ToString();
                    objCheque.DescMoneda = cboIdMoneda.Text;
                    objCheque.AjusteContable = chkAjusteContable.Checked;
                    //objCheque.IdEmpleadoInterno = Convert.ToInt32(txtNoEmpleado.EditValue);
                    objCheque.NombreEmpleado = txtNombreEmpleado.Text.Trim();
                    objCheque.BeneficiarioCheque = txtNombreEmpleado.Text.Trim();
                    objCheque.BeneficiarioPoliza = txtBeneficiarioPoliza.Text.Trim();
                    objCheque.IdCategoriaTransaccionBanco = Convert.ToInt32(cboCategoriaTransaccionBanco.EditValue);
                    objCheque.IdSubCategoriaTransaccionBanco = Convert.ToInt32(cboSubCategoriaTransaccionBanco.EditValue);
                    objCheque.OtroConcepto = txtOtroConcepto.Text.Trim();
                    objCheque.Observaciones = txtObservaciones.Text.Trim();

                    if (txtNoEmpleado.Text.Trim().Length == 0)
                        objCheque.IdEmpleadoInterno = -1;
                    else
                        objCheque.IdEmpleadoInterno = Convert.ToInt32(txtNoEmpleado.Text);

                    this.Tag = objCheque;   //pasar por propiedad tag el objeto
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBeneficiarioCheque_EditValueChanged(object sender, EventArgs e)
        {
            txtBeneficiarioPoliza.Text = txtNombreEmpleado.Text;
        }

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                //si escribieron un valor
                if (txtNoEmpleado.Text.Trim().Length > 0)
                {
                    if (Validator.IsPositiveNumber(txtNoEmpleado))
                    {
                        DataTable dt = this.stpSelObtenerInfoGenericaEmpleadoTableAdapter1.GetData(Convert.ToInt32(txtNoEmpleado.Text));

                        objEmpleadoGenerico = EmpleadoBD.ObtenerInfoGenericaEmpleadoCFDI(dt);

                        if (objEmpleadoGenerico != null)
                        {
                            txtNombreEmpleado.Text = objEmpleadoGenerico.NombreEmpleadoCompleto;
                        }
                        else
                        {
                            XtraMessageBox.Show(string.Format("No existe información del No. de Empleado {0}", txtNoEmpleado.Text), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                    XtraMessageBox.Show("Debe escribir el No. de Empleado para obtener la Información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNoEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnBuscarEmpleado_Click(sender, e);     //si existe ENTER entonces ejecutar metodo-evento click
        }
    }
}