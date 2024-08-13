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
using compUtileriasVBNet;
using System.Security.Principal;
using compCatalogosSAIC;

namespace winAppSAIC.Tesoreria
{
    public partial class frmxControlTransaccionBanco : DevExpress.XtraEditors.XtraForm
    {
        public frmxControlTransaccionBanco()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();        //cerrar pantalla
        }

        #region "Variables Globales"

        private Int64 intIdLoteCargaNomina;
        private string strFolioLoteCargaNomina;

        /// <summary>
        /// Constantes que indicarán el tipo de Movimiento
        /// que realiza el usuario
        /// </summary>
        enum TipoMovimientoBanco : byte
        {
            Ninguno = 0,
            AgregarTransaccion = 10,
            EditarTransaccion = 15,
            ConsultarTransaccion = 20
        }

        byte flagTipoOperacion;
        InfoCuentaBanco objInfoCuentaBancoOrigen = null;
        InfoCuentaBanco objInfoCuentaBancoDestino = null;

        //propiedad que indicará si el usuario es Operador o Tesorero
        public string ModuloOperativo
        {
            get;
            set;
        }
        #endregion

        #region "Metodos Propios"
        /// <summary>
        /// Método para generar la leyenda entra cuentas bancarias TRASPASO XXX a YYY 
        /// </summary>
        private void GenerarLeyendaTransferencia()
        {
            //Visualizar leyenda cuando sea transferencia
            txtBeneficiarioCheque.Text = String.Format("TRASPASO {0} A {1}", cboCuentaBanco.Text, cboACuentaBanco.Text);
        }
        /// <summary>
        /// Método que recibe el Objeto InfoDetalleMovimiento
        /// y lo despliega en los controls
        /// </summary>
        /// <param name="objInfoDetalle"></param>
        private void MostrarInfoDetalleMovimiento(InfoDetalleTransaccionBanco objInfoDetalle)
        {
            lblFolioMovimiento.Text = objInfoDetalle.IdTransaccionBanco.ToString();
            cboFecha.EditValue = objInfoDetalle.FechaTransaccion;
            cboFolioLoteCargaNomina.EditValue = objInfoDetalle.IdLoteCargaNomina;
            cboCuentaBanco.EditValue = objInfoDetalle.IdCuentaBanco;
            cboACuentaBanco.EditValue = objInfoDetalle.AIdCuentaBanco;

            txtNoCheque.Text = objInfoDetalle.NoTransaccion;
            
            if (objInfoDetalle.IdCodigoTransaccionBanco.Equals("RETI"))
                txtImporte.Text = objInfoDetalle.MontoTransaccionRetiro.ToString();
            else if (objInfoDetalle.IdCodigoTransaccionBanco.Equals("DEPO"))
                txtImporte.Text = objInfoDetalle.MontoTransaccionDeposito.ToString();
            else if (objInfoDetalle.IdCodigoTransaccionBanco.Equals("TRAN"))
                txtImporte.Text = (objInfoDetalle.MontoTransaccionRetiro > 0) ? objInfoDetalle.MontoTransaccionRetiro.ToString() : objInfoDetalle.MontoTransaccionDeposito.ToString();
           
            txtBeneficiarioCheque.Text = objInfoDetalle.NombreBeneficiarioTransaccionBanco;
            cboCategoriaTransaccionBanco.EditValue = objInfoDetalle.IdCategoriaTransaccionBanco;
            cboSubCategoriaTransaccionBanco.EditValue = objInfoDetalle.IdSubCategoriaTransaccionBanco;
            txtOtroConcepto.Text = objInfoDetalle.OtroConcepto;
            txtObservaciones.Text = objInfoDetalle.Observaciones;
            lblMoneda.Text = objInfoDetalle.DescMoneda;
            chkCancelado.Checked = objInfoDetalle.EstatusCancelado;
            cboClienteProveedor.EditValue = objInfoDetalle.IdClienteProveedor;
            cboFolioLoteCargaNomina.EditValue = objInfoDetalle.IdLoteCargaNomina;
            chkChequeConciliado.Checked = objInfoDetalle.EstatusConciliado;

            //actualizar checkbox Utilizar Lote Carga Nomina
            if (objInfoDetalle.IdLoteCargaNomina != -1)
                chkUtilizarFolioLoteNomina.Checked = true;
            else
                chkUtilizarFolioLoteNomina.Checked = false;
        }



        /// <summary>
        /// Método para modificar el comportamiento del Combobox de Lote Carga Nomina
        /// </summary>    
        private void CambiarComportamientoComboboxFolioLoteCargaNomina()
        {
            //si está activado entonces bloquear control
            if (chkUtilizarFolioLoteNomina.Checked)
                cboFolioLoteCargaNomina.Enabled = false;
        }


        /// <summary>
        /// Método para Habilitar/Deshabilitar botones
        /// </summary>
        /// <param name="bFlag"></param>
        private void HabilitarBotones(bool bFlag)
        {
            btnNuevoCheque.Enabled = bFlag;
            btnCancelarCaptura.Enabled = !bFlag;
            btnGuardarCheque.Enabled = !bFlag;
            btnEditarCheque.Enabled = bFlag;
            btnBuscarCheque.Enabled = bFlag;
            //btnImprimirCheque.Enabled = bFlag;
            //btnImprimirPoliza.Enabled = bFlag;
        }
        /// <summary>
        /// Método para inicializar controles visuales 
        /// de captura
        /// </summary>
        private void InicializarControles()
        {
            lblFolioMovimiento.Text = "";
            cboFecha.EditValue = DateTime.Now.Date;
            txtNoCheque.Text = "0";
            txtImporte.Text = "0";
            //txtImporteLetra.Text = "";
            txtBeneficiarioCheque.Text = "";
            txtOtroConcepto.Text = "";
            txtObservaciones.Text = "";
            //chkCancelado.Checked = false;
            //chkAjusteContable.Checked = false;
            chkUtilizarFolioLoteNomina.Checked = false;
            cboFolioLoteCargaNomina.Enabled = chkUtilizarFolioLoteNomina.Checked;
            //chkChequeConciliado.Checked = false;

            //verificar estatus cheque en base al tipo de Accion
            //if (flagTipoOperacion == (byte)TipoMovimientoBanco.Ninguno)
            //    cboEstatusCheque.EditValue = 1;     //N/D => NO DISPONIBLE
            //else if (flagTipoOperacion == (byte)TipoMovimientoBanco.AgregarTransaccion)
            //    cboEstatusCheque.EditValue = 4;     //CHEQUE EN TRANSITO
        }

        /// <summary>
        /// Método para bloquear controles cuando se guarde un cheque
        /// o se muestre la pantalla por primera vez
        /// </summary>
        /// <param name="bFlag">Verdadero o Falso</param>
        private void BloquearControles(bool bFlag)
        {
            //cboFecha.Enabled = bFlag;
            //cboTipoTransaccion.Enabled = bFlag;
            //cboCuentaBanco.Enabled = bFlag;
            cboClienteProveedor.Enabled = bFlag;
            cboFolioLoteCargaNomina.Enabled = bFlag;
            chkUtilizarFolioLoteNomina.Enabled = bFlag;
            txtNoCheque.Enabled = bFlag;
            txtImporte.Enabled = bFlag;
            txtTipoCambio.Enabled = bFlag;
            txtBeneficiarioCheque.Enabled = bFlag;
            cboCategoriaTransaccionBanco.Enabled = bFlag;
            cboSubCategoriaTransaccionBanco.Enabled = bFlag;
            txtOtroConcepto.Enabled = bFlag;
            txtObservaciones.Enabled = bFlag;
        }


        /// <summary>
        /// Método que oculta o muestra los controles que se emplean en 
        /// las transferencias entre cuentas bancarias
        /// </summary>
        /// <param name="bFlag">VERDADERO o FALSO</param>
        private void OcultarControles(bool bFlag)
        {
            lblACuentaBanco.Visible = bFlag;
            cboACuentaBanco.Visible = bFlag;
        }

        /// <summary>
        /// Método que valida la Existencia de un Cheque generado previamente
        /// </summary>
        /// <returns>VERDADERO o FALSO</returns>    
        private bool ExisteTransaccion()
        {
            //ejecutar validacion con Stored Procedure
            Int64 objResultado = Convert.ToInt64(this.actualizacionesTesoreriaTableAdapter1.stpSelValidarExistenciaCheque(Convert.ToInt32(cboCuentaBanco.EditValue), txtNoCheque.Text));

            if (objResultado != 0)
                return true;        //si existe transaccion
            else
                return false;       //no existe transaccion
        }

        /// <summary>
        /// Método que insertar la información del Movimiento Bancario
        /// </summary>
        private void InsertarTransaccionBanco()
        {
            int? pIdBeneficiarioTransaccionBanco = 0;
            int intIdBeneficiarioTransaccionBancoCheque = 0;
            int intIdBeneficiarioTransaccionBancoPoliza = 0;
            long? pIdTransaccionBanco = 0;

            try
            {
                //Insertar nuevo Beneficiario
                this.actualizacionesTesoreriaTableAdapter1.stpInsBeneficiarioTransaccionBanco(txtBeneficiarioCheque.Text.Trim(), ref pIdBeneficiarioTransaccionBanco);
                intIdBeneficiarioTransaccionBancoCheque = (int)pIdBeneficiarioTransaccionBanco;
                intIdBeneficiarioTransaccionBancoPoliza = intIdBeneficiarioTransaccionBancoCheque;    //asignar mismo IdBeneficiario                

                //si existen IdBeneficiario válidos
                if ((intIdBeneficiarioTransaccionBancoCheque > 0) && (intIdBeneficiarioTransaccionBancoPoliza > 0))
                {
                    //si la transacción es RETI/DEPO
                    if (!cboTipoTransaccion.EditValue.Equals("TRAN"))
                    {
                        if (chkUtilizarFolioLoteNomina.Checked)
                        {
                            //insertar Transaccion Bancaria CON Lote Carga Nomina
                            this.actualizacionesTesoreriaTableAdapter1.stpInsTransaccionBanco((long)cboFolioLoteCargaNomina.EditValue,
                                                                                                strFolioLoteCargaNomina,
                                                                                                (int)cboCuentaBanco.EditValue, -1,
                                                                                                intIdBeneficiarioTransaccionBancoCheque,
                                                                                                intIdBeneficiarioTransaccionBancoPoliza,
                                                                                                cboTipoTransaccion.EditValue.ToString(),
                                                                                                Convert.ToDecimal(txtImporte.Text),
                                                                                                "",
                                                                                                objInfoCuentaBancoOrigen.IdMoneda,
                                                                                                txtNoCheque.Text,
                                                                                                txtOtroConcepto.Text,
                                                                                                txtObservaciones.Text.Trim(),
                                                                                                (int)cboCategoriaTransaccionBanco.EditValue,
                                                                                                (int)cboSubCategoriaTransaccionBanco.EditValue,
                                                                                                Convert.ToDateTime(cboFecha.Text),
                                                                                                Convert.ToDecimal(txtImporte.Text),
                                                                                                OperadorBD.OperadorGlobal.NombreUsuario,
                                                                                                Convert.ToInt32(cboClienteProveedor.EditValue),
                                                                                                false,
                                                                                                "NO",   //es Cheque?
                                                                                                ref pIdTransaccionBanco);
                        }
                        else
                        {
                            //insertar Transaccion Bancaria SIN Lote Carga Nomina
                            this.actualizacionesTesoreriaTableAdapter1.stpInsTransaccionBanco(-1,
                                                                                                "",
                                                                                                (int)cboCuentaBanco.EditValue, -1,
                                                                                                intIdBeneficiarioTransaccionBancoCheque,
                                                                                                intIdBeneficiarioTransaccionBancoPoliza,
                                                                                                cboTipoTransaccion.EditValue.ToString(),
                                                                                                Convert.ToDecimal(txtImporte.Text),
                                                                                                "",
                                                                                                objInfoCuentaBancoOrigen.IdMoneda,
                                                                                                txtNoCheque.Text,
                                                                                                txtOtroConcepto.Text,
                                                                                                txtObservaciones.Text.Trim(),
                                                                                                (int)cboCategoriaTransaccionBanco.EditValue,
                                                                                                (int)cboSubCategoriaTransaccionBanco.EditValue,
                                                                                                Convert.ToDateTime(cboFecha.Text),
                                                                                                Convert.ToDecimal(txtImporte.Text),
                                                                                                OperadorBD.OperadorGlobal.NombreUsuario,
                                                                                                Convert.ToInt32(cboClienteProveedor.EditValue),
                                                                                                false,
                                                                                                "NO",   //es Cheque?
                                                                                                ref pIdTransaccionBanco);
                        }
                    }  //if  (!cboTipoTransaccion.EditValue.Equals("TRAN"))
                    else
                    {
                        //Si el movimiento es TRANSFERENCIA
                        if (chkUtilizarFolioLoteNomina.Checked)
                        {
                            //insertar Transaccion Bancaria CON Lote Carga Nomina
                            this.actualizacionesTesoreriaTableAdapter1.stpInsTransaccionTransferenciaBanco((long)cboFolioLoteCargaNomina.EditValue,
                                                                                                strFolioLoteCargaNomina,
                                                                                                (int)cboCuentaBanco.EditValue, 
                                                                                                (int) cboACuentaBanco.EditValue,
                                                                                                intIdBeneficiarioTransaccionBancoCheque,
                                                                                                intIdBeneficiarioTransaccionBancoPoliza,
                                                                                                cboTipoTransaccion.EditValue.ToString(),
                                                                                                Convert.ToDecimal(txtImporte.Text),
                                                                                                "",
                                                                                                objInfoCuentaBancoOrigen.IdMoneda,
                                                                                                objInfoCuentaBancoDestino.IdMoneda,
                                                                                                1, 
                                                                                                txtNoCheque.Text,
                                                                                                txtOtroConcepto.Text,
                                                                                                txtObservaciones.Text.Trim(),
                                                                                                (int)cboCategoriaTransaccionBanco.EditValue,
                                                                                                (int)cboSubCategoriaTransaccionBanco.EditValue,
                                                                                                Convert.ToDateTime(cboFecha.Text),
                                                                                                Convert.ToDecimal(txtImporte.Text),
                                                                                                OperadorBD.OperadorGlobal.NombreUsuario,
                                                                                                Convert.ToInt32(cboClienteProveedor.EditValue),
                                                                                                false,
                                                                                                "NO",   //es Cheque?
                                                                                                ref pIdTransaccionBanco);
                        }
                        else
                        {
                            //insertar Transaccion Bancaria SIN Lote Carga Nomina
                            this.actualizacionesTesoreriaTableAdapter1.stpInsTransaccionTransferenciaBanco(-1,
                                                                                                "",
                                                                                                (int)cboCuentaBanco.EditValue,
                                                                                                (int)cboACuentaBanco.EditValue,
                                                                                                intIdBeneficiarioTransaccionBancoCheque,
                                                                                                intIdBeneficiarioTransaccionBancoPoliza,
                                                                                                cboTipoTransaccion.EditValue.ToString(),
                                                                                                Convert.ToDecimal(txtImporte.Text),
                                                                                                "",
                                                                                                objInfoCuentaBancoOrigen.IdMoneda,
                                                                                                objInfoCuentaBancoDestino.IdMoneda,
                                                                                                1, 
                                                                                                txtNoCheque.Text,
                                                                                                txtOtroConcepto.Text,
                                                                                                txtObservaciones.Text.Trim(),
                                                                                                (int)cboCategoriaTransaccionBanco.EditValue,
                                                                                                (int)cboSubCategoriaTransaccionBanco.EditValue,
                                                                                                Convert.ToDateTime(cboFecha.Text),
                                                                                                Convert.ToDecimal(txtImporte.Text),
                                                                                                OperadorBD.OperadorGlobal.NombreUsuario,
                                                                                                Convert.ToInt32(cboClienteProveedor.EditValue),
                                                                                                false,
                                                                                                "NO",   //es Cheque?
                                                                                                ref pIdTransaccionBanco);
                        }
                    }

                    //si la inserción fué correcta, entonces mostrar IdTransaccionBanco
                    if (pIdTransaccionBanco > 0)
                    {
                        lblFolioMovimiento.Text = pIdTransaccionBanco.ToString();
                        btnCancelarCheque.Enabled = true;      //activar boton Cancelar Cheque
                        HabilitarBotones(true);     //habilitar botones
                        BloquearControles(false);       //bloquear controles
                        flagTipoOperacion = (byte)TipoMovimientoBanco.Ninguno;    //inicializar bandera que indica Tipo Operacion
                        CambiarComportamientoComboboxFolioLoteCargaNomina();    //Método para cambiar comportamiento
                    }
                    else
                        XtraMessageBox.Show("NO se creó el registro del Movimiento. ¡Contacte a Sistemas!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    XtraMessageBox.Show("NO se creó el registro del Concepto. ¡Contacte a Sistemas!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método que actualizar la información del Movimiento Bancario
        /// </summary>
        private void ActualizarTransaccionBanco()
        {
            int? pError = -99;
            int? pIdBeneficiarioTransaccionBanco = 0;
            int intIdBeneficiarioTransaccionBancoCheque = 0;
            int intIdBeneficiarioTransaccionBancoPoliza = 0;
            //            long? pIdTransaccionBanco = 0;

            try
            {
                //Insertar nuevo Beneficiario
                this.actualizacionesTesoreriaTableAdapter1.stpInsBeneficiarioTransaccionBanco(txtBeneficiarioCheque.Text.Trim(), ref pIdBeneficiarioTransaccionBanco);
                intIdBeneficiarioTransaccionBancoCheque = (int)pIdBeneficiarioTransaccionBanco;

                //si el Beneficiario Cheque <> Beneficiario Poliza, entonces insertar beneficiario
                //if (!txtBeneficiarioCheque.Equals(txtBeneficiarioPoliza.Text.Trim()))
                //{
                //    //Insertar nuevo Beneficiario
                //    this.actualizacionesTesoreriaTableAdapter1.stpInsBeneficiarioTransaccionBanco(txtBeneficiarioPoliza.Text.Trim(), ref pIdBeneficiarioTransaccionBanco);
                //    intIdBeneficiarioTransaccionBancoPoliza = (int)pIdBeneficiarioTransaccionBanco;
                //}
                //else
                    intIdBeneficiarioTransaccionBancoPoliza = intIdBeneficiarioTransaccionBancoCheque;    //asignar mismo IdBeneficiario                

                //si existen IdBeneficiario válidos
                if ((intIdBeneficiarioTransaccionBancoCheque > 0) && (intIdBeneficiarioTransaccionBancoPoliza > 0))
                {
                    if (chkUtilizarFolioLoteNomina.Checked)
                    {
                        //actualizar Transaccion Bancaria CON Lote Carga Nomina
                        this.actualizacionesTesoreriaTableAdapter1.stpUpdTransaccionBanco(Convert.ToInt64(lblFolioMovimiento.Text),
                                                                                            (long)cboFolioLoteCargaNomina.EditValue,
                                                                                            strFolioLoteCargaNomina,
                                                                                            (int)cboCuentaBanco.EditValue,
                                                                                            -1,
                                                                                            intIdBeneficiarioTransaccionBancoCheque,
                                                                                            intIdBeneficiarioTransaccionBancoPoliza,
                                                                                            cboTipoTransaccion.EditValue.ToString(), 
                                                                                            Convert.ToDecimal(txtImporte.Text),
                                                                                            "",
                                                                                            objInfoCuentaBancoOrigen.IdMoneda,
                                                                                            txtNoCheque.Text,
                                                                                            txtOtroConcepto.Text,
                                                                                            txtObservaciones.Text.Trim(),
                                                                                            (int)cboCategoriaTransaccionBanco.EditValue,
                                                                                            (int)cboSubCategoriaTransaccionBanco.EditValue,
                                                                                            Convert.ToDateTime(cboFecha.Text),
                                                                                            Convert.ToDecimal(txtImporte.Text),
                                                                                            OperadorBD.OperadorGlobal.NombreUsuario,
                                                                                            Convert.ToInt32(cboClienteProveedor.EditValue),
                                                                                            2,
                                                                                            false,
                                                                                            (bool)chkChequeConciliado.Checked,
                                                                                            ref pError);
                    }
                    else
                    {
                        //actualizar Transaccion Bancaria SIN Lote Carga Nomina
                        this.actualizacionesTesoreriaTableAdapter1.stpUpdTransaccionBanco(Convert.ToInt64(lblFolioMovimiento.Text),
                                                                                            -1,
                                                                                            "",
                                                                                            (int)cboCuentaBanco.EditValue,
                                                                                            -1,
                                                                                            intIdBeneficiarioTransaccionBancoCheque,
                                                                                            intIdBeneficiarioTransaccionBancoPoliza,
                                                                                            cboTipoTransaccion.EditValue.ToString(), 
                                                                                            Convert.ToDecimal(txtImporte.Text),
                                                                                            "",
                                                                                            objInfoCuentaBancoOrigen.IdMoneda,
                                                                                            txtNoCheque.Text,
                                                                                            txtOtroConcepto.Text,
                                                                                            txtObservaciones.Text.Trim(),
                                                                                            (int)cboCategoriaTransaccionBanco.EditValue,
                                                                                            (int)cboSubCategoriaTransaccionBanco.EditValue,
                                                                                            Convert.ToDateTime(cboFecha.Text),
                                                                                            Convert.ToDecimal(txtImporte.Text),
                                                                                            OperadorBD.OperadorGlobal.NombreUsuario,
                                                                                            Convert.ToInt32(cboClienteProveedor.EditValue),
                                                                                            2,
                                                                                            false,
                                                                                            (bool)chkChequeConciliado.Checked,
                                                                                            ref pError);

                    }
                    //si la actualización fué correcta
                    if (pError != -99)
                    {
                        XtraMessageBox.Show("El Cheque ha sido modificado exitosamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnCancelarCheque.Enabled = true;      //activar boton Cancelar Cheque
                        HabilitarBotones(true);     //habilitar botones
                        BloquearControles(false);       //bloquear controles
                        flagTipoOperacion = (byte)TipoMovimientoBanco.Ninguno;    //inicializar bandera que indica Tipo Operacion
                        CambiarComportamientoComboboxFolioLoteCargaNomina();    //Método para cambiar comportamiento
                    }
                    else
                        XtraMessageBox.Show("NO se modificó el Cheque. ¡Contacte a Sistemas!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    XtraMessageBox.Show("NO se creó el registro del Beneficiario. ¡Contacte a Sistemas!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método para Cancelar un Movimiento Bancario activo
        /// </summary>
        /// <param name="pIdTransaccionBanco">IdTransaccionBanco</param>
        /// <param name="pUsuarioCancelacion">Usuario que realiza la cancelacion</param>
        private Int32 CancelarTransaccionBanco(long pIdTransaccionBanco, string pUsuarioCancelacion)
        {
            int? pError = -99;

            try
            {
                //Cancelar Cheque
                //this.actualizacionesTesoreriaTableAdapter1.stpUpdCancelarCheque(pIdTransaccionBanco, pUsuarioCancelacion, ref pError);
            }
            catch (Exception ex)
            {
                //XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return (Int32)pError;
        }

        #endregion

        private void frmxControlTransaccionBanco_Load(object sender, EventArgs e)
        {
            try
            {
                this.stpSelCuentaBancoTransaccionTableAdapter.Fill(this.dbSAICBPOTesoreriaDataSet.stpSelCuentaBancoTransaccion);
                this.stpSelFolioLoteCargaNominaParaChequesTableAdapter.Fill(this.dbSAICBPOTesoreriaDataSet.stpSelFolioLoteCargaNominaParaCheques);

                //IdClasifCliente       = 1 incluir los Clientes
                //IdClasifProveedor  = 3 incluir los Proveedores
                this.stpSelClienteProveedorChequesTableAdapter.Fill(this.dbSAICBPOTesoreriaDataSet.stpSelClienteProveedorCheques, 1, 3);
                this.stpSelFolioLoteCargaNominaParaChequesTableAdapter.Fill(this.dbSAICBPOTesoreriaDataSet.stpSelFolioLoteCargaNominaParaCheques);
                this.stpSelCodigoTransaccionBancoTableAdapter.Fill(this.dbSAICBPOTesoreriaDataSet.stpSelCodigoTransaccionBanco);
                this.stpSelCategoriaTransaccionBancoTableAdapter.Fill(this.dbSAICBPOCatalogosDataSet.stpSelCategoriaTransaccionBanco, "TESO");
                cboFecha.DateTime = DateTime.Now.Date;

                // Specify the total dropdown width. 
                cboClienteProveedor.Properties.PopupFormWidth = 700;
                // Set column widths according to their contents. 
                cboFolioLoteCargaNomina.Properties.View.BestFitColumns();
                // Specify the total dropdown width. 
                cboFolioLoteCargaNomina.Properties.PopupFormWidth = 900;

                OcultarControles(false);        //ocultar controles
                cboFecha.DateTime = DateTime.Now.Date;
                InicializarControles();     //inicializar controles
                BloquearControles(false);       //bloquear controles
                HabilitarBotones(true);     //habilitar botones
                lblMoneda.Text = "";        //inicializar Moneda
                btnCancelarCheque.Enabled = false;      //desactivar boton Cancelar Cheque
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboCuentaBanco_EditValueChanged(object sender, EventArgs e)
        {
            if (!cboCuentaBanco.EditValue.Equals(""))         //asegurar que el valor sea diferente de vacio
            {
                //Obtener la información de la Cuenta Bancaria seleccionada
                this.stpSelInfoCuentaBancoTableAdapter1.Fill(this.dbSAICBPOTesoreriaDataSet.stpSelInfoCuentaBanco, Convert.ToInt32(cboCuentaBanco.EditValue));

                //si existe registro
                if (this.dbSAICBPOTesoreriaDataSet.stpSelInfoCuentaBanco.Count > 0)
                {
                    //asignar el renglon a variable DataRow
                    DataRow row = this.dbSAICBPOTesoreriaDataSet.stpSelInfoCuentaBanco.Rows[0];

                    //almacenar la información Cuenta Banco en Objeto
                    objInfoCuentaBancoOrigen = InfoCuentaBancoBD.ObtenerInfoCuentabanco(row);

                    lblMoneda.Text = objInfoCuentaBancoOrigen.DescMoneda;   //desplegar moneda en label
                }

                //validar tipo de transaccion
                if (cboTipoTransaccion.EditValue.ToString().Equals("TRAN"))
                {
                    OcultarControles(true);        //mostrar controles
                        //llenar combobox con los bancos y cuentas SIN incluir la del Banco Anterior
                        this.stpSelCuentaBancoPorBancoFiltradoTableAdapter.Fill(this.dbSAICBPOTesoreriaDataSet.stpSelCuentaBancoPorBancoFiltrado, Convert.ToInt32(cboCuentaBanco.EditValue));
                }
                else
                    OcultarControles(false);        //ocultar controles
            }
        }

        private void cboCategoriaTransaccionBanco_EditValueChanged(object sender, EventArgs e)
        {
            if (!cboCategoriaTransaccionBanco.EditValue.Equals(""))      //asegurar que el valor sea diferente de vacio
                //Obtener la información de la SubCategoriaTransaccionBanco
                this.stpSelSubCategoriaTransaccionBancoTableAdapter.Fill(this.dbSAICBPOCatalogosDataSet.stpSelSubCategoriaTransaccionBanco, Convert.ToInt32(cboCategoriaTransaccionBanco.EditValue));
        }

        private void btnNuevoCheque_Click(object sender, EventArgs e)
        {
            flagTipoOperacion = (byte)TipoMovimientoBanco.AgregarTransaccion;    //inicializar bandera que indica Tipo Operacion
            InicializarControles();     //inicializar controles
            BloquearControles(true);       //habilitar controles
            HabilitarBotones(false);     //deshabilitar botones
            btnCancelarCheque.Enabled = false;      //desactivar boton Cancelar Cheque
            cboFecha.Focus();       //colocar cursor en Fecha
            cboClienteProveedor.EditValue = -1;     //inicializar Cliente-Proveedor
        }

        private void btnCancelarCaptura_Click(object sender, EventArgs e)
        {
            flagTipoOperacion = (byte)TipoMovimientoBanco.Ninguno;    //inicializar bandera que indica Tipo Operacion
            InicializarControles();     //inicializar controles
            BloquearControles(false);       //bloquear controles
            HabilitarBotones(true);     //habilitar botones
        }

        private void btnGuardarCheque_Click(object sender, EventArgs e)
        {
            //validar controles
            if (UtileriasLocal.Validator.IsPresent(cboCuentaBanco) &&
                UtileriasLocal.Validator.IsPresent(cboClienteProveedor) &&
                UtileriasLocal.Validator.IsPositiveOrZeroNumber(txtNoCheque) &&
                UtileriasLocal.Validator.IsPresent(txtImporte) &&
                UtileriasLocal.Validator.IsPositiveNumber(txtImporte) &&
                UtileriasLocal.Validator.IsPresent(txtBeneficiarioCheque) &&
                UtileriasLocal.Validator.IsPresent(cboCategoriaTransaccionBanco) &&
                UtileriasLocal.Validator.IsPresent(cboSubCategoriaTransaccionBanco))
            {
                //la acción es agregar
                if (flagTipoOperacion == (byte)TipoMovimientoBanco.AgregarTransaccion)
                {
                    //validar Checked Usa Folio Nomina
                    if (chkUtilizarFolioLoteNomina.Checked)
                    {
                        //si está activado uso de Folio, entonces validar Folio Lote Nomina
                        if (UtileriasLocal.Validator.IsPresent(cboFolioLoteCargaNomina))
                            InsertarTransaccionBanco();   //método para insertar cheque
                    }
                    else   //no se asigna Folio Lote Nomina 
                        InsertarTransaccionBanco();   //método para insertar cheque
                }                 
                 //existe cheque y la acción es editar
                else if (flagTipoOperacion == (byte)TipoMovimientoBanco.EditarTransaccion)
                {
                    //validar Checked Usa Folio Nomina
                    if (chkUtilizarFolioLoteNomina.Checked)
                    {
                        //si está activado uso de Folio, entonces validar Folio Lote Nomina
                        if (UtileriasLocal.Validator.IsPresent(cboFolioLoteCargaNomina))
                            ActualizarTransaccionBanco();   //método para actualizar cheque
                    }
                    else
                        ActualizarTransaccionBanco();   //método para actualizar cheque
                }
            }

        }

        private void btnEditarCheque_Click(object sender, EventArgs e)
        {
            //si existe un folio activo
            if ((lblFolioMovimiento.Text.Length > 0) && (Convert.ToInt64(lblFolioMovimiento.Text) > 0))
                //si no está cancelado el cheque
                if (chkCancelado.Checked == false)
                {
                    //si no está conciliado el cheque
                    if (chkChequeConciliado.Checked == false)
                    {
                        flagTipoOperacion = (byte)TipoMovimientoBanco.EditarTransaccion;    //inicializar bandera que indica Tipo Operacion
                        BloquearControles(true);       //habilitar controles
                        HabilitarBotones(false);     //deshabilitar botones
                        btnCancelarCheque.Enabled = false;      //desactivar boton Cancelar Cheque
                        txtNoCheque.Enabled = false;
                    }
                    else
                        XtraMessageBox.Show("No se puede editar un Movimiento que está Conciliado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    XtraMessageBox.Show("No se puede editar un Movimiento que está Cancelado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                XtraMessageBox.Show("No tiene Folio Transacción Activo para editar un Movimiento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void cboClienteProveedor_EditValueChanged(object sender, EventArgs e)
        {
            //si existe cliente proveedor seleccionado, entonces asociar valor del combobox al textbox
            if (cboClienteProveedor.Text.Length > 0)
            {
                //si el movimeinto es diferente de TRANSFERENCIA
                if (!cboTipoTransaccion.EditValue.Equals("TRAN"))
                    txtBeneficiarioCheque.Text = cboClienteProveedor.Text;
            }
        }

        private void chkUtilizarFolioLoteNomina_CheckedChanged(object sender, EventArgs e)
        {
            //activar o desactivar uso de combobos LoteCargaNomina
            cboFolioLoteCargaNomina.Enabled = chkUtilizarFolioLoteNomina.Checked;

            if (chkUtilizarFolioLoteNomina.Checked == false)
                cboFolioLoteCargaNomina.EditValue = -1;
        }

        private void cboFolioLoteCargaNomina_EditValueChanged(object sender, EventArgs e)
        {
            //si el usuario seleccionó un renglon, entonces regresar el valor IdLoteCargaNomina
            if (idLoteCargaNominaGridLookUpEditView.FocusedRowHandle >= 0)
            {
                //obtener la información del renglon completo
                DataRow row = idLoteCargaNominaGridLookUpEditView.GetDataRow(idLoteCargaNominaGridLookUpEditView.FocusedRowHandle);
                //asignar el IdLoteCargaNomina y FolioLoteCargaNomina
                intIdLoteCargaNomina = (long)row[0];
                strFolioLoteCargaNomina = row[1].ToString();
            }
        }

        private void cboACuentaBanco_EditValueChanged(object sender, EventArgs e)
        {
            if (!cboACuentaBanco.EditValue.Equals(""))         //asegurar que el valor sea diferente de vacio
            {
                //Obtener la información de la Cuenta Bancaria seleccionada
                this.stpSelInfoCuentaBancoTableAdapter1.Fill(this.dbSAICBPOTesoreriaDataSet.stpSelInfoCuentaBanco, Convert.ToInt32(cboACuentaBanco.EditValue));

                //si existe registro
                if (this.dbSAICBPOTesoreriaDataSet.stpSelInfoCuentaBanco.Count > 0)
                {
                    //asignar el renglon a variable DataRow
                    DataRow row = this.dbSAICBPOTesoreriaDataSet.stpSelInfoCuentaBanco.Rows[0];

                    //almacenar la información Cuenta Banco Destino en Objeto
                    objInfoCuentaBancoDestino = InfoCuentaBancoBD.ObtenerInfoCuentabanco(row);

                    GenerarLeyendaTransferencia();  //actualizar leyenda de concepto para transferencias
                }
            }
        }



        private void btnBuscarCheque_Click(object sender, EventArgs e)
        {
            if (!cboCuentaBanco.Text.Equals(""))        //verifico que exista cuenta de banco activa
            {
                InicializarControles();     //limpiar controles
                //crear pantalla y asignar los valores para la consulta
                frmxBuscarCheque objBuscarCheque = new frmxBuscarCheque() { IdCuentaBanco = Convert.ToInt32(cboCuentaBanco.EditValue), AnoTransaccion = DateTime.Now.Year };

                if (objBuscarCheque.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    InfoDetalleTransaccionBanco objInfoDetalleMovimiento = objBuscarCheque.InfoDetalleChequeEmitido;
                    if (objInfoDetalleMovimiento != null)
                    {
                        MostrarInfoDetalleMovimiento(objInfoDetalleMovimiento); //mostrar detalle del cheque seleccionado en Buscar
                        btnCancelarCheque.Enabled = !objInfoDetalleMovimiento.EstatusCancelado;   //activar/desactivar boton Cancelar Cheque
                        CambiarComportamientoComboboxFolioLoteCargaNomina();    //Método para cambiar comportamiento
                    }
                    else
                        InicializarControles();     //inicializar controles
                }
            }
            else
                XtraMessageBox.Show("No tiene Cuenta de Banco para realizar la búsqueda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}