using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;

namespace winAppSAIC.Tesoreria
{
    public partial class frmxConciliacionBanco : DevExpress.XtraEditors.XtraForm
    {
        public frmxConciliacionBanco()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método paera asignar fechas a los controles Date
        /// </summary>
        private void AsignarFechas()
        {
            dtFechaInicio.EditValue = DateTime.Now.AddMonths(-1);
            dtFechaFin.EditValue = DateTime.Now.Date;
        }

        private void transaccionBancoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                GuardarRegistros();     //guardar cambios
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GuardarRegistros()
        {
            this.Validate();
            this.transaccionBancoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbSAICBPOTesoreriaDataSet);
        }

        private void frmxConciliacionBanco_Load(object sender, EventArgs e)
        {
            try
            {
                splashSMCargando.ShowWaitForm();
                this.stpSelBancoTableAdapter.Fill(this.dbSAICBPOCatalogosDataSet.stpSelBanco);
                this.stpSelBeneficiarioTransaccionBancoTableAdapter.Fill(this.dbSAICBPOTesoreriaDataSet.stpSelBeneficiarioTransaccionBanco);
                this.stpSelEstatusChequesTableAdapter.Fill(this.dbSAICBPOTesoreriaDataSet.stpSelEstatusCheques);
                //IdClasifCliente       = 1 incluir los Clientes
                //IdClasifProveedor  = 3 incluir los Proveedores
                this.stpSelClienteProveedorChequesTableAdapter.Fill(this.dbSAICBPOTesoreriaDataSet.stpSelClienteProveedorCheques, 1, 3);

                // Specify the total dropdown width. 
                cboCuentaBanco.Properties.PopupFormWidth = 500;

                AsignarFechas();        //método para asignar fechas a los controles de fecha
                splashSMCargando.CloseWaitForm();
              }
            catch (System.Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();    //cerrar pantalla
        }

        private void cboBanco_EditValueChanged(object sender, EventArgs e)
        {
            if (!cboBanco.EditValue.Equals(""))     //asegurar que el valor sea diferente de vacio
                //realizar consulta de las cuentas bancarias en base al Banco seleccionado
                this.stpSelCuentaBancoPorBancoTableAdapter.Fill(this.dbSAICBPOTesoreriaDataSet.stpSelCuentaBancoPorBanco, Convert.ToByte(cboBanco.EditValue));
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                //validar controles
                if (UtileriasLocal.Validator.IsPresent(cboBanco) &&
                    UtileriasLocal.Validator.IsPresent(cboCuentaBanco) &&
                    UtileriasLocal.Validator.IsPresent(dtFechaInicio) &&
                    UtileriasLocal.Validator.IsPresent(dtFechaFin))
                {
                    this.transaccionBancoTableAdapter.Fill(this.dbSAICBPOTesoreriaDataSet.TransaccionBanco, Convert.ToInt32(cboCuentaBanco.EditValue), Convert.ToDateTime(dtFechaInicio.EditValue.ToString()), Convert.ToDateTime(dtFechaFin.EditValue.ToString()));
                }
                
            }
            catch (System.Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView1_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            GridView view = sender as GridView;
            System.Data.DataRow row = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (view.FocusedColumn.FieldName == "FechaAplicacionBanco")
            {
                //Get the currently edited value 
                DateTime dtFechaDefault = new DateTime(1900, 1, 1);
                DateTime dtFechaPago = Convert.ToDateTime(e.Value);

                ////Fecha Pago < Fecha Movimiento Transaccion Banco Y
                //Fecha de Pago != Fecha 01-01-1900
                if ((dtFechaPago < Convert.ToDateTime(row[9])) && (!dtFechaPago.Equals(dtFechaDefault)))
                {
                        e.Valid = false;
                        e.ErrorText = "La Fecha de Aplicación no puede ser menor a la Fecha del Movimiento";
                }
            }
        }

        private void frmxConciliacionBanco_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                //validar si existen cambios en el DataSet
                if (this.dbSAICBPOTesoreriaDataSet.HasChanges())
                {
                    if (XtraMessageBox.Show("¿Desea guardar los cambios realizados en la Conciliación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                        GuardarRegistros();     //guardar cambios
                    else
                        this.dbSAICBPOTesoreriaDataSet.RejectChanges(); //deshacer cambios
                }
            }
            catch (System.Exception ex)
            {
                e.Cancel = true;        //cancelar cerrado de pantalla
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}