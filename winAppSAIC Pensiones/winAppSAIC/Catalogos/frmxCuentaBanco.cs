using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using winAppSAIC.UtileriasLocal;
using compCatalogosSAIC;

namespace winAppSAIC.Catalogos
{
    public partial class frmxCuentaBanco : DevExpress.XtraEditors.XtraForm
    {
        public frmxCuentaBanco()
        {
            InitializeComponent();
        }

        #region "Variables Globales"
        private Constantes.TipoOperacionABC tipoOperacionABC = Constantes.TipoOperacionABC.Ninguno;
        #endregion


        #region "Metodos Propios"
        private CuentaBancoCliente AsignarInfoCliente()
        {
            CuentaBancoCliente objCliente = null;

            try
            {
                objCliente = new CuentaBancoCliente();
                objCliente.IdCuentaBanco = Convert.ToInt32(IdFactCuentaBancoBeneficiarioTextEdit.Text.Trim() == "" ? "0" : IdFactCuentaBancoBeneficiarioTextEdit.Text.Trim());
                objCliente.IdTipoBeneficiario = Convert.ToInt32(IdTipoBeneficiarioComboBoxEdit.EditValue);
                objCliente.IdBeneficiario = Convert.ToInt32(txtBeneficiario.Text);
                objCliente.IdBanco = Convert.ToInt32(IdBancoComboBoxEdit.EditValue);
                objCliente.NoCuenta = CuentaTextEdit.Text.Trim();
                objCliente.IdEstatus = Convert.ToInt16(IdEstatusComboBoxEdit.EditValue);
            }
            catch (Exception ex)
            {
                return null;
            }
            return objCliente;
        }

        private void MostrarInfoCliente(CuentaBancoCliente objCliente)
        {
            IdFactCuentaBancoBeneficiarioTextEdit.EditValue = objCliente.IdCuentaBanco.ToString();
            IdTipoBeneficiarioComboBoxEdit.EditValue = objCliente.IdTipoBeneficiario;
            txtBeneficiario.Text = objCliente.IdBeneficiario.ToString();
            IdBancoComboBoxEdit.Text = objCliente.IdBanco.ToString();
            CuentaTextEdit.EditValue = objCliente.NoCuenta;
            IdEstatusComboBoxEdit.EditValue = objCliente.IdEstatus;
        }

        private void ActivarControlesInfoCliente(bool bFlag)
        {
            //txtIdCliente.Enabled = bFlag;
            IdTipoBeneficiarioComboBoxEdit.Enabled = bFlag;
            IdTipoBeneficiarioComboBoxEdit.BackColor = bFlag ? Color.White : Color.LightGoldenrodYellow;

            IdBancoComboBoxEdit.Enabled = bFlag;
            IdBancoComboBoxEdit.BackColor = bFlag ? Color.White : Color.LightGoldenrodYellow;

            CuentaTextEdit.Enabled = bFlag;
            CuentaTextEdit.BackColor = bFlag ? Color.White : Color.LightGoldenrodYellow;

            IdEstatusComboBoxEdit.Enabled = bFlag;
            IdEstatusComboBoxEdit.BackColor = bFlag ? Color.White : Color.LightGoldenrodYellow;

            cbTenedora.Enabled = bFlag;
            cbTenedora.BackColor = bFlag ? Color.White : Color.LightGoldenrodYellow;

            cbCliente.Enabled = bFlag;
            cbCliente.BackColor = bFlag ? Color.White : Color.LightGoldenrodYellow;
            if (tipoOperacionABC != Constantes.TipoOperacionABC.Ninguno)
            {
                if (IdTipoBeneficiarioComboBoxEdit.Text == "CLIENTE")
                {
                    cbCliente.Enabled = true;
                    cbCliente.BackColor = Color.White;

                    cbTenedora.Enabled = false;
                    cbTenedora.BackColor = Color.LightGoldenrodYellow;

                    if (txtBeneficiario.Text.Trim().Length > 0)
                    {
                        cbCliente.EditValue = Convert.ToInt32(txtBeneficiario.Text);
                        if (cbTenedora.EditValue != null && cbTenedora.EditValue.ToString() != "-1")
                            cbTenedora.EditValue = -1;
                    }
                }
                else if (IdTipoBeneficiarioComboBoxEdit.Text == "TENEDORA")
                {
                    cbCliente.Enabled = false;
                    cbCliente.BackColor = Color.LightGoldenrodYellow;

                    cbTenedora.Enabled = true;
                    cbTenedora.BackColor = Color.White;

                    if (txtBeneficiario.Text.Trim().Length > 0)
                    {
                        cbTenedora.EditValue = Convert.ToInt32(txtBeneficiario.Text);
                        if (cbCliente.EditValue != null && cbCliente.EditValue.ToString() != "-1")
                            cbCliente.EditValue = -1;
                    }
                }
                else
                {
                    cbCliente.Enabled = false;
                    cbCliente.BackColor = Color.LightGoldenrodYellow;

                    cbTenedora.Enabled = false;
                    cbTenedora.BackColor = Color.LightGoldenrodYellow;

                    if (txtBeneficiario.Text.Trim().Length > 0)
                    {
                        if (cbCliente.EditValue != null && cbCliente.EditValue.ToString() != "-1")
                            cbCliente.EditValue = -1;
                        if (cbTenedora.EditValue != null && cbTenedora.EditValue.ToString() != "-1")
                            cbTenedora.EditValue = -1;
                    }
                }
            }
        }

        private void LimpiarControlesInfoCliente()
        {
            IdTipoBeneficiarioComboBoxEdit.Text = "0";
            cbTenedora.EditValue = -1;
            cbCliente.EditValue = -1;
            IdBancoComboBoxEdit.EditValue = -1;
            CuentaTextEdit.Text = string.Empty;
            IdEstatusComboBoxEdit.EditValue = -1;
        }

        /// <summary>
        /// Método para Activar o Desactivar Controles BOTONES y COMBOBOX
        /// en base a la acciones del usuario
        /// </summary>
        /// <param name="bFlag">Valor VERDADERO o FALSO</param>
        private void ActivarDesactivarBotones(bool bFlag)
        {
            btnNuevo.Enabled = bFlag;
            btnEditar.Enabled = bFlag;
            btnCancelar.Enabled = !bFlag;
            btnGuardar.Enabled = !bFlag;
        }
        #endregion
        private void frmxCuentaBanco_Load(object sender, EventArgs e)
        {
            try
            {
                splashSMCargando.ShowWaitForm();
                // TODO: This line of code loads data into the 'dbSAICBPOFactura.vwFactCuentaBancoBeneficiario' table. You can move, or remove it, as needed.
                this.vwFactCuentaBancoBeneficiarioTableAdapter.Fill(this.dbSAICBPOFactura.vwFactCuentaBancoBeneficiario);
                // TODO: This line of code loads data into the 'dbSAICBPOFactura.vwFactBeneficiarioCliente' table. You can move, or remove it, as needed.
                this.vwFactBeneficiarioClienteTableAdapter.Fill(this.dbSAICBPOFactura.vwFactBeneficiarioCliente);
                // TODO: This line of code loads data into the 'dbSAICBPOFactura.vwFactBeneficiarioTenedora' table. You can move, or remove it, as needed.
                this.vwFactBeneficiarioTenedoraTableAdapter.Fill(this.dbSAICBPOFactura.vwFactBeneficiarioTenedora);
                // TODO: This line of code loads data into the 'dbSAICBPOFactura.vwFactCatBancos' table. You can move, or remove it, as needed.
                this.vwFactCatBancosTableAdapter.Fill(this.dbSAICBPOFactura.vwFactCatBancos);
                // TODO: This line of code loads data into the 'dbSAICBPOFactura.vwFactCatTipoBeneficiario' table. You can move, or remove it, as needed.
                this.vwFactCatTipoBeneficiarioTableAdapter.Fill(this.dbSAICBPOFactura.vwFactCatTipoBeneficiario);
                // TODO: This line of code loads data into the 'dbSAIC_Catalogos.vwCatEstatusCliente' table. You can move, or remove it, as needed.
                this.vwCatEstatusClienteTableAdapter.Fill(this.dbSAIC_Catalogos.vwCatEstatusCliente);
                // TODO: This line of code loads data into the 'dbSAIC_Catalogos.FactCuentaBancoBeneficiario' table. You can move, or remove it, as needed.
                this.factCuentaBancoBeneficiarioTableAdapter.Fill(this.dbSAIC_Catalogos.FactCuentaBancoBeneficiario);

                // Set column widths according to their contents. 
                cbCuentas.Properties.View.BestFitColumns();
                // Specify the total dropdown width. 
                cbCuentas.Properties.PopupFormWidth = 800;

                ActivarDesactivarBotones(true);
                ActivarControlesInfoCliente(false);      //desactivar controles formulario

                splashSMCargando.CloseWaitForm();
            }
            catch (Exception ex)
            {
                splashSMCargando.CloseWaitForm();
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            cbCuentas.EditValue = 0;
            IdTipoBeneficiarioComboBoxEdit.Focus();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Close();        //cerrar pantalla
        }

        #region "Metodos Propios"
        private void GuardarRegistros()
        {
            if (Validator.IsPresent(IdTipoBeneficiarioComboBoxEdit) && Validator.IsPresent(txtBeneficiario) &&
                Validator.IsPresent(IdBancoComboBoxEdit) && //Validator.IsPresent(CuentaTextEdit) &&
                Validator.IsPresent(IdEstatusComboBoxEdit))
            {
                CuentaBancoCliente objCliente = AsignarInfoCliente();

                if (objCliente != null)
                {
                    if (tipoOperacionABC == Constantes.TipoOperacionABC.Nuevo)
                    {

                        Boolean flatYaExiste = false;

                        //Saber si la Cuenta a ingresar Ya Existe en la Base
                        flatYaExiste = existeCuantaBancoCliente();

                        if (flatYaExiste)
                        {
                            XtraMessageBox.Show("No se puede agregar la cuenta. Ya existe en el Catalogo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            this.factCuentaBancoBeneficiarioTableAdapter.Insert(objCliente.IdBeneficiario, objCliente.IdTipoBeneficiario, objCliente.IdBanco,
                            objCliente.NoCuenta, objCliente.IdEstatus);
                        }
                    }
                    else if (tipoOperacionABC == Constantes.TipoOperacionABC.Editar)
                    {
                        this.factCuentaBancoBeneficiarioTableAdapter.Update(objCliente.IdBeneficiario, objCliente.IdTipoBeneficiario,
                            objCliente.IdBanco, objCliente.NoCuenta, objCliente.IdEstatus, objCliente.IdCuentaBanco);

                    }
                }   //if (objCliente != null)
                else
                    XtraMessageBox.Show("¡La asignación de información de la Cuenta NO ha sido exitosa!\nContacte a Sistemas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }
        #endregion

        private void cbCuentas_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.factCuentaBancoBeneficiarioTableAdapter.FillByID(this.dbSAIC_Catalogos.FactCuentaBancoBeneficiario, Convert.ToInt32(cbCuentas.EditValue));
            }
            catch (FormatException)
            {
                XtraMessageBox.Show("Razón Social Matriz Tenedora NO es válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IdTipoBeneficiarioComboBoxEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (tipoOperacionABC != Constantes.TipoOperacionABC.Ninguno)
                {
                    if (IdTipoBeneficiarioComboBoxEdit.Text == "CLIENTE")
                    {
                        cbCliente.Enabled = true;
                        cbCliente.BackColor = Color.White;

                        cbTenedora.Enabled = false;
                        cbTenedora.BackColor = Color.LightGoldenrodYellow;

                        if (txtBeneficiario.Text.Trim().Length > 0)
                        {
                            cbCliente.EditValue = Convert.ToInt32(txtBeneficiario.Text);
                            if (cbTenedora.EditValue != null && cbTenedora.EditValue.ToString() != "-1")
                                cbTenedora.EditValue = -1;
                        }
                    }
                    else
                    {
                        cbCliente.Enabled = false;
                        cbCliente.BackColor = Color.LightGoldenrodYellow;

                        cbTenedora.Enabled = true;
                        cbTenedora.BackColor = Color.White;

                        if (txtBeneficiario.Text.Trim().Length > 0)
                        {
                            cbTenedora.EditValue = Convert.ToInt32(txtBeneficiario.Text);
                            if (cbCliente.EditValue != null && cbCliente.EditValue.ToString() != "-1")
                                cbCliente.EditValue = -1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbTenedora_EditValueChanged(object sender, EventArgs e)
        {
            if (cbTenedora.EditValue != null && cbTenedora.EditValue.ToString() != "-1")
            {
                txtBeneficiario.Text = cbTenedora.EditValue.ToString();
            }
        }

        private void cbCliente_EditValueChanged(object sender, EventArgs e)
        {
            if (cbCliente.EditValue != null && cbCliente.EditValue.ToString() != "-1")
            {
                txtBeneficiario.Text = cbCliente.EditValue.ToString();
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            cbCuentas.EditValue = 0;
            IdTipoBeneficiarioComboBoxEdit.Focus();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            tipoOperacionABC = Constantes.TipoOperacionABC.Nuevo; //tipo de Operacion ABC = NUEVO
            cbCuentas.EditValue = -1;   //visualizar la primer pestaña
            LimpiarControlesInfoCliente();      //inicializar controles formulario
            ActivarDesactivarBotones(false);
            ActivarControlesInfoCliente(true);      //activar controles formulario
            IdTipoBeneficiarioComboBoxEdit.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(IdFactCuentaBancoBeneficiarioTextEdit.EditValue) > 0)
            {
                ActivarDesactivarBotones(false);        //desactivar botones
                tipoOperacionABC = Constantes.TipoOperacionABC.Editar; //tipo de Operacion ABC = EDITAR
                ActivarControlesInfoCliente(true);      //activar controles formulario
            }
            else
                XtraMessageBox.Show("No ha seleccionado un Cliente para modificar su información.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tipoOperacionABC = Constantes.TipoOperacionABC.Ninguno; //tipo de Operacion ABC = NIGUNO
            ActivarDesactivarBotones(true);
            ActivarControlesInfoCliente(false);      //desactivar controles formulario
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                    GuardarRegistros();     //guardar cambios
                    ActivarDesactivarBotones(true);
                    tipoOperacionABC = Constantes.TipoOperacionABC.Ninguno; //tipo de Operacion ABC = NUEVO
                    ActivarControlesInfoCliente(false);      //desactivar controles formulario
                    this.vwFactCuentaBancoBeneficiarioTableAdapter.Fill(this.dbSAICBPOFactura.vwFactCuentaBancoBeneficiario);
            }
            catch (DBConcurrencyException)
            {
                XtraMessageBox.Show("Error de concurrencia, NO fue insertardo/actualizado el registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DataException ex)
            {
                XtraMessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException ex)
            {
                XtraMessageBox.Show("Error Base de Datos: " + ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBeneficiario_EditValueChanged(object sender, EventArgs e)
        {
            if (tipoOperacionABC == Constantes.TipoOperacionABC.Ninguno)
            {
                if (IdTipoBeneficiarioComboBoxEdit.Text == "CLIENTE")
                {
                    cbTenedora.EditValue = -1;
                    cbCliente.EditValue = txtBeneficiario.Text;
                }
                else
                {
                    cbTenedora.EditValue = txtBeneficiario.Text;
                    cbCliente.EditValue = -1;
                }
            }
        }

        /// <summary>
        /// Funcion para saber si la cuenta por ingresar ya Existe en la Base.
        /// </summary>
        /// <returns></returns>
        private Boolean existeCuantaBancoCliente()
        {
            Boolean? flagYaExiste = false;
            Boolean flagYaExiste1 = false;

            int idBeneficiario;
            int idTipoBeneficiario;
            int idBanco;
            String stCuenta = String.Empty;

            int.TryParse(txtBeneficiario.EditValue.ToString(), out idBeneficiario);
            int.TryParse(IdTipoBeneficiarioComboBoxEdit.EditValue.ToString(), out idTipoBeneficiario);
            int.TryParse(IdBancoComboBoxEdit.EditValue.ToString(), out idBanco);
            stCuenta = CuentaTextEdit.Text;

            spSoloRespuesta1.stpFactSelExisteCuentaBancoCliente(idBeneficiario, idTipoBeneficiario, idBanco, stCuenta, ref flagYaExiste);

            Boolean.TryParse(flagYaExiste.ToString(), out flagYaExiste1);

            return flagYaExiste1;
        }
    }
}