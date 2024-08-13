using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using compUtileriasVBNet;
using compCatalogosSAIC;
using DevExpress.XtraReports.UI;
using System.Security.Principal;
using System.Linq;

namespace winAppSAIC.Tesoreria
{
    public partial class frmxEmisionCheques : DevExpress.XtraEditors.XtraForm
    {
        public frmxEmisionCheques()
        {
            InitializeComponent();
        }

        #region "Variables Globales"

            private Int64 intIdLoteCargaNomina;
            private string strFolioLoteCargaNomina;
            //private string[] Impresoras;

        /// <summary>
        /// Constantes que indicarán el tipo de Movimiento
        /// que realiza el usuario
        /// </summary>
            enum TipoMovimientoBanco:byte
            {
                Ninguno = 0,
                AgregarTransaccion = 10,
                EditarTransaccion = 15,
                ConsultarTransaccion = 20
            }

            byte flagTipoOperacion;
            InfoCuentaBanco objInfoCuentaBanco = null;

            //propiedad que indicará si el usuario es Operador o Tesorero
            public string ModuloOperativo
            {
                get;
                set;
            }
        #endregion

        #region "Metodos Propios"
        /// <summary>
        /// Método para Obtener las impresoras instaladas en el equipo actual
        /// y llenar combobox con modelos HP y EPSON
        /// </summary>
        private void CargarImpresorasAutorizadas()
        {
            int intNoImpresoras = System.Drawing.Printing.PrinterSettings.InstalledPrinters.Count;
            string[] strImpresorasInstaladas = new string[intNoImpresoras];
            int i = 0;

            //agregar impresoras a un arreglo
            foreach (string strImpresora in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                strImpresorasInstaladas[i] = strImpresora;
                i++;
            }

            //filtrar impresoras HP o EPSON
            var objImpresoras = from indice in strImpresorasInstaladas
                                    where indice.Contains("HP") || indice.Contains("EPSON")
                                    orderby indice
                                    select indice;
                
            //llenar combobox con valores filtrados
            foreach (var posicion in objImpresoras)
            {
                cboTipoImpresora.Items.Add(posicion);
            }
            
            if (cboTipoImpresora.Items.Count > 0)   //validar si existen impresoras
                cboTipoImpresora.SelectedIndex = 0;     //seleccionar primera impresora
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
        /// Método que valida la Existencia de un Cheque generado previamente
        /// </summary>
        /// <returns>VERDADERO o FALSO</returns>    
        private bool ExisteTransaccion()
            {
                //ejecutar validacion con Stored Procedure
                Int64 objResultado = Convert.ToInt64(this.actualizacionesTesoreriaTableAdapter1.stpSelValidarExistenciaCheque(Convert.ToInt32(cboCuentaBanco.EditValue),txtNoCheque.Text ));

                if (objResultado != 0)
                    return true;        //si existe cheque
                else
                    return false;       //no existe cheque
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
            btnImprimirCheque.Enabled = bFlag;
            btnImprimirPoliza.Enabled = bFlag;
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
            txtImporteLetra.Text = "";
            txtBeneficiarioCheque.Text = "";
            txtOtroConcepto.Text = "";
            txtObservaciones.Text = "";
            chkCancelado.Checked = false;
            chkAjusteContable.Checked = false;
            chkUtilizarFolioLoteNomina.Checked = false;
            cboFolioLoteCargaNomina.Enabled = chkUtilizarFolioLoteNomina.Checked;
            chkChequeConciliado.Checked = false;

            //verificar estatus cheque en base al tipo de Accion
            if (flagTipoOperacion == (byte)TipoMovimientoBanco.Ninguno)
                cboEstatusCheque.EditValue = 1;     //N/D => NO DISPONIBLE
            else if (flagTipoOperacion == (byte)TipoMovimientoBanco.AgregarTransaccion)
                cboEstatusCheque.EditValue = 4;     //CHEQUE EN TRANSITO
        }

        /// <summary>
        /// Método para bloquear controles cuando se guarde un cheque
        /// o se muestre la pantalla por primera vez
        /// </summary>
        /// <param name="bFlag">Verdadero o Falso</param>
        private void BloquearControles(bool bFlag)
        {
            //cboFecha.Enabled = bFlag;
            //cboBanco.Enabled = bFlag;
            //cboCuentaBanco.Enabled = bFlag;
            cboClienteProveedor.Enabled = bFlag;
            //cboFolioLoteCargaNomina.Enabled = bFlag;
            chkUtilizarFolioLoteNomina.Enabled = bFlag;
            txtNoCheque.Enabled = bFlag;
            txtImporte.Enabled = bFlag;
            txtBeneficiarioCheque.Enabled = bFlag;
            txtBeneficiarioPoliza.Enabled = bFlag;
            cboCategoriaTransaccionBanco.Enabled = bFlag;
            cboSubCategoriaTransaccionBanco.Enabled = bFlag;
            txtOtroConcepto.Enabled = bFlag;
            txtObservaciones.Enabled = bFlag;
            chkAjusteContable.Enabled = bFlag;
        }

        /// <summary>
        /// Método que recibe el Objeto InfoDetalleCheque
        /// y lo despliega en los controls
        /// </summary>
        /// <param name="objInfoDetalleCheque"></param>
        private void MostrarInfoDetalleCheque(InfoDetalleTransaccionBanco objInfoDetalleCheque)
        {
            lblFolioMovimiento.Text = objInfoDetalleCheque.IdTransaccionBanco.ToString();
            cboFecha.EditValue = objInfoDetalleCheque.FechaTransaccion;
            cboFolioLoteCargaNomina.EditValue = objInfoDetalleCheque.IdLoteCargaNomina;
            cboCuentaBanco.EditValue = objInfoDetalleCheque.IdCuentaBanco;
            txtNoCheque.Text = objInfoDetalleCheque.NoTransaccion;
            txtImporte.Text = objInfoDetalleCheque.MontoTransaccionRetiro.ToString();
            txtImporteLetra.Text = objInfoDetalleCheque.MontoConLetra;
            txtBeneficiarioCheque.Text = objInfoDetalleCheque.NombreBeneficiarioTransaccionBanco;
            txtBeneficiarioPoliza.Text = objInfoDetalleCheque.NombreBeneficiarioTransaccionPoliza;
            cboSubCategoriaTransaccionBanco.EditValue = objInfoDetalleCheque.IdSubCategoriaTransaccionBanco;
            txtOtroConcepto.Text = objInfoDetalleCheque.OtroConcepto;
            txtObservaciones.Text = objInfoDetalleCheque.Observaciones;
            lblMoneda.Text = objInfoDetalleCheque.DescMoneda;
            chkCancelado.Checked = objInfoDetalleCheque.EstatusCancelado;
            chkAjusteContable.Checked = objInfoDetalleCheque.EstatusAjusteContable;
            cboClienteProveedor.EditValue = objInfoDetalleCheque.IdClienteProveedor;
            cboEstatusCheque.EditValue = objInfoDetalleCheque.EstatusTransaccionBanco; 
            chkChequeConciliado.Checked = objInfoDetalleCheque.EstatusConciliado;
            
            //actualizar checkbox Utilizar Lote Carga Nomina
            if (objInfoDetalleCheque.IdLoteCargaNomina != -1)
                chkUtilizarFolioLoteNomina.Checked = true;
            else
                chkUtilizarFolioLoteNomina.Checked = false;
        }

        
        /// <summary>
        /// Método que insertar la información del Cheque
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
                intIdBeneficiarioTransaccionBancoCheque = (int) pIdBeneficiarioTransaccionBanco;

                //si el Beneficiario Cheque <> Beneficiario Poliza, entonces insertar beneficiario
                if (!txtBeneficiarioCheque.Equals(txtBeneficiarioPoliza.Text.Trim()))
                {
                    //Insertar nuevo Beneficiario
                    this.actualizacionesTesoreriaTableAdapter1.stpInsBeneficiarioTransaccionBanco(txtBeneficiarioPoliza.Text.Trim(), ref pIdBeneficiarioTransaccionBanco);
                    intIdBeneficiarioTransaccionBancoPoliza = (int) pIdBeneficiarioTransaccionBanco;
                }
                else
                    intIdBeneficiarioTransaccionBancoPoliza = intIdBeneficiarioTransaccionBancoCheque;    //asignar mismo IdBeneficiario                

                //si existen IdBeneficiario válidos
                if ((intIdBeneficiarioTransaccionBancoCheque > 0) && (intIdBeneficiarioTransaccionBancoPoliza > 0))
                {
                    if (chkUtilizarFolioLoteNomina.Checked)
                    {
                        //insertar Transaccion Bancaria CON Lote Carga Nomina
                        this.actualizacionesTesoreriaTableAdapter1.stpInsTransaccionBanco((long)cboFolioLoteCargaNomina.EditValue,
                                                                                            strFolioLoteCargaNomina,
                                                                                            (int)cboCuentaBanco.EditValue, -1,
                                                                                            intIdBeneficiarioTransaccionBancoCheque,
                                                                                            intIdBeneficiarioTransaccionBancoPoliza,
                                                                                            "RETI", 
                                                                                            Convert.ToDecimal(txtImporte.Text), 
                                                                                            txtImporteLetra.Text,
                                                                                            objInfoCuentaBanco.IdMoneda, 
                                                                                            txtNoCheque.Text,
                                                                                            txtOtroConcepto.Text,
                                                                                            txtObservaciones.Text.Trim(),
                                                                                            (int)cboCategoriaTransaccionBanco.EditValue,
                                                                                            (int)cboSubCategoriaTransaccionBanco.EditValue,
                                                                                            Convert.ToDateTime(cboFecha.Text),
                                                                                            Convert.ToDecimal(txtImporte.Text),
                                                                                            OperadorBD.OperadorGlobal.NombreUsuario,
                                                                                            Convert.ToInt32(cboClienteProveedor.EditValue),
                                                                                            (bool)chkAjusteContable.Checked,
                                                                                            "SI",   //es Cheque?
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
                                                                                            "RETI", 
                                                                                            Convert.ToDecimal(txtImporte.Text), 
                                                                                            txtImporteLetra.Text,
                                                                                            objInfoCuentaBanco.IdMoneda, 
                                                                                            txtNoCheque.Text,
                                                                                            txtOtroConcepto.Text,
                                                                                            txtObservaciones.Text.Trim(),
                                                                                            (int)cboCategoriaTransaccionBanco.EditValue,
                                                                                            (int)cboSubCategoriaTransaccionBanco.EditValue,
                                                                                            Convert.ToDateTime(cboFecha.Text),
                                                                                            Convert.ToDecimal(txtImporte.Text),
                                                                                            OperadorBD.OperadorGlobal.NombreUsuario,
                                                                                            Convert.ToInt32(cboClienteProveedor.EditValue),
                                                                                            (bool)chkAjusteContable.Checked,
                                                                                            "SI",   //es Cheque?
                                                                                            ref pIdTransaccionBanco);

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
                        XtraMessageBox.Show("NO se creó el registro del Cheque. ¡Contacte a Sistemas!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        /// Método que actualizar la información del Cheque
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
                if (!txtBeneficiarioCheque.Equals(txtBeneficiarioPoliza.Text.Trim()))
                {
                    //Insertar nuevo Beneficiario
                    this.actualizacionesTesoreriaTableAdapter1.stpInsBeneficiarioTransaccionBanco(txtBeneficiarioPoliza.Text.Trim(), ref pIdBeneficiarioTransaccionBanco);
                    intIdBeneficiarioTransaccionBancoPoliza = (int)pIdBeneficiarioTransaccionBanco;
                }
                else
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
                                                                                            "RETI", Convert.ToDecimal(txtImporte.Text), 
                                                                                            txtImporteLetra.Text,
                                                                                            objInfoCuentaBanco.IdMoneda, 
                                                                                            txtNoCheque.Text,
                                                                                            txtOtroConcepto.Text,
                                                                                            txtObservaciones.Text.Trim(),
                                                                                            (int)cboCategoriaTransaccionBanco.EditValue,
                                                                                            (int)cboSubCategoriaTransaccionBanco.EditValue,
                                                                                            Convert.ToDateTime(cboFecha.Text),
                                                                                            Convert.ToDecimal(txtImporte.Text),
                                                                                            OperadorBD.OperadorGlobal.NombreUsuario,
                                                                                            Convert.ToInt32(cboClienteProveedor.EditValue),
                                                                                            Convert.ToByte(cboEstatusCheque.EditValue),
                                                                                            (bool)chkAjusteContable.Checked,
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
                                                                                            "RETI", Convert.ToDecimal(txtImporte.Text),
                                                                                            txtImporteLetra.Text,
                                                                                            objInfoCuentaBanco.IdMoneda,
                                                                                            txtNoCheque.Text,
                                                                                            txtOtroConcepto.Text,
                                                                                            txtObservaciones.Text.Trim(),
                                                                                            (int)cboCategoriaTransaccionBanco.EditValue,
                                                                                            (int)cboSubCategoriaTransaccionBanco.EditValue,
                                                                                            Convert.ToDateTime(cboFecha.Text),
                                                                                            Convert.ToDecimal(txtImporte.Text),
                                                                                            OperadorBD.OperadorGlobal.NombreUsuario,
                                                                                            Convert.ToInt32(cboClienteProveedor.EditValue),
                                                                                            Convert.ToByte(cboEstatusCheque.EditValue),
                                                                                            (bool)chkAjusteContable.Checked,
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
        /// Método para Cancelar un Cheque activo
        /// </summary>
        /// <param name="pIdTransaccionBanco">IdTransaccionBanco</param>
        /// <param name="pUsuarioCancelacion">Usuario que realiza la cancelacion</param>
        private Int32 CancelarTransaccionBanco(long pIdTransaccionBanco, MotivoCancelacionChequera objMotivoCancelacionChequera, string pUsuarioCancelacion)
        {
            int? pError = -99;

            try
            {
                    //Cancelar Cheque
                    this.actualizacionesTesoreriaTableAdapter1.stpUpdCancelarCheque(pIdTransaccionBanco, 
                        objMotivoCancelacionChequera.EstatusCancelacionCheque,
                        objMotivoCancelacionChequera.ChequeQueSustituye,
                        objMotivoCancelacionChequera.MotivoCancelacion, pUsuarioCancelacion, ref pError);
            }
            catch (Exception ex)
            {
                //XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return (Int32)pError;
        }

         /// <summary>
        /// Método para Imprimir el Cheque BANAMEX
        /// <param name="pIdBanco">IdBanco</param>
        /// </summary>
        private void ImprimirChequeBX(DetalleChequesMasivos objDetalle = null)
        {
                Int64 IdTransaccionBanco = -1;
                Int64 IdTransaccionBancoFinal = -1;
                Int32 IdCuentaBanco = -1;

                //si es cheques masivos
                if (objDetalle != null)
                {
                    //asignar valores del IdTransaccionBanco, IdTransaccionBancoFinal, IdCuentaBanco
                    //para cheques masivos
                    IdTransaccionBanco = objDetalle.IdTransaccionBancoInicial;
                    IdTransaccionBancoFinal = objDetalle.IdTransaccionBancoFinal;
                    IdCuentaBanco = objDetalle.IdCuentaBanco;
                }
                else
                {
                    //asignar valor del IdTransaccionBanco 
                    //para emitir 1 cheque
                    IdTransaccionBanco = Convert.ToInt64(lblFolioMovimiento.Text);
                }

                try
                {
                    //verificar tipo de impresora
                    if (cboTipoImpresora.Text.Contains("EPSON"))
                    {
                        //crear objeto Reporte
                        ReportesTesoreria.ImpresionChequeBX_Epson report = new ReportesTesoreria.ImpresionChequeBX_Epson();

                        //asignar parametros del reporte
                        report.Parameters["pIdTransaccionBanco"].Value = IdTransaccionBanco;
                        report.Parameters["pIdTransaccionBancoFinal"].Value = IdTransaccionBancoFinal;
                        report.Parameters["pIdCuentaBanco"].Value = IdCuentaBanco;
                        //ajustar propiedades de impresion
                        report.Landscape = true;
                        report.ShowPrintMarginsWarning = false;
                        report.PrinterName = cboTipoImpresora.Text;
                        //mostrar reporte
                        report.ShowPreview();
                    }
                    else if (cboTipoImpresora.Text.Contains("HP"))
                    {
                        //crear objeto Reporte
                        ReportesTesoreria.ImpresionChequeBX report = new ReportesTesoreria.ImpresionChequeBX();

                        //asignar parametros del reporte
                        report.Parameters["pIdTransaccionBanco"].Value = IdTransaccionBanco;
                        report.Parameters["pIdTransaccionBancoFinal"].Value = IdTransaccionBancoFinal;
                        report.Parameters["pIdCuentaBanco"].Value = IdCuentaBanco;

                        //ajustar propiedades de impresion
                        report.PaperKind = System.Drawing.Printing.PaperKind.Letter;
                        report.PrinterName = cboTipoImpresora.Text;
                        //mostrar reporte
                        report.ShowPreview();
                    }
                    else
                        XtraMessageBox.Show("Seleccione una impresora EPSON o HP\npara realizar la impresión del Cheque.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        /// <summary>
        /// Método para Imprimir el Cheque BANCOMER
        /// <param name="pIdBanco">IdBanco</param>
        /// </summary>
        private void ImprimirChequeBBVA(DetalleChequesMasivos objDetalle = null)
        {
            Int64 IdTransaccionBanco = -1;
            Int64 IdTransaccionBancoFinal = -1;
            Int32 IdCuentaBanco = -1;

            //si es cheques masivos
            if (objDetalle != null)
            {
                //asignar valores del IdTransaccionBanco, IdTransaccionBancoFinal, IdCuentaBanco
                //para cheques masivos
                IdTransaccionBanco = objDetalle.IdTransaccionBancoInicial;
                IdTransaccionBancoFinal = objDetalle.IdTransaccionBancoFinal;
                IdCuentaBanco = objDetalle.IdCuentaBanco;
            }
            else
            {
                //asignar valor del IdTransaccionBanco 
                //para emitir 1 cheque
                IdTransaccionBanco = Convert.ToInt64(lblFolioMovimiento.Text);
            }

            try
            {
                //verificar tipo de impresora
                if (cboTipoImpresora.Text.Contains("EPSON"))
                {
                    //crear objeto Reporte
                    ReportesTesoreria.ImpresionChequeBBVA_Epson report = new ReportesTesoreria.ImpresionChequeBBVA_Epson();

                    //asignar parametros del reporte
                    report.Parameters["pIdTransaccionBanco"].Value = IdTransaccionBanco;
                    report.Parameters["pIdTransaccionBancoFinal"].Value = IdTransaccionBancoFinal;
                    report.Parameters["pIdCuentaBanco"].Value = IdCuentaBanco;

                    //ajustar propiedades de impresion
                    report.Landscape = true;
                    report.ShowPrintMarginsWarning = false;
                    report.PrinterName = cboTipoImpresora.Text;
                    //mostrar reporte
                    report.ShowPreview();
                }
                else if (cboTipoImpresora.Text.Contains("HP"))
                {
                    //crear objeto Reporte
                    ReportesTesoreria.ImpresionChequeBBVA report = new ReportesTesoreria.ImpresionChequeBBVA();

                    //asignar parametros del reporte
                    report.Parameters["pIdTransaccionBanco"].Value = IdTransaccionBanco;
                    report.Parameters["pIdTransaccionBancoFinal"].Value = IdTransaccionBancoFinal;
                    report.Parameters["pIdCuentaBanco"].Value = IdCuentaBanco;

                    //ajustar propiedades de impresion
                    report.PaperKind = System.Drawing.Printing.PaperKind.Letter;
                    report.PrinterName = cboTipoImpresora.Text;
                    //mostrar reporte
                    report.ShowPreview();
                }
                else
                    XtraMessageBox.Show("Seleccione una impresora EPSON o HP\npara realizar la impresión del Cheque.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método para Imprimir el Cheque BANORTE
        /// <param name="pIdBanco">IdBanco</param>
        /// </summary>
        private void ImprimirChequeBAN(DetalleChequesMasivos objDetalle = null)
        {
            Int64 IdTransaccionBanco = -1;
            Int64 IdTransaccionBancoFinal = -1;
            Int32 IdCuentaBanco = -1;

            //si es cheques masivos
            if (objDetalle != null)
            {
                //asignar valores del IdTransaccionBanco, IdTransaccionBancoFinal, IdCuentaBanco
                //para cheques masivos
                IdTransaccionBanco = objDetalle.IdTransaccionBancoInicial;
                IdTransaccionBancoFinal = objDetalle.IdTransaccionBancoFinal;
                IdCuentaBanco = objDetalle.IdCuentaBanco;
            }
            else
            {
                //asignar valor del IdTransaccionBanco 
                //para emitir 1 cheque
                IdTransaccionBanco = Convert.ToInt64(lblFolioMovimiento.Text);
            }

            try
            {
                //verificar tipo de impresora
                if (cboTipoImpresora.Text.Contains("EPSON"))
                {
                    //crear objeto Reporte
                    ReportesTesoreria.ImpresionChequeBAN_Epson report = new ReportesTesoreria.ImpresionChequeBAN_Epson();

                    //asignar parametros del reporte
                    report.Parameters["pIdTransaccionBanco"].Value = IdTransaccionBanco;
                    report.Parameters["pIdTransaccionBancoFinal"].Value = IdTransaccionBancoFinal;
                    report.Parameters["pIdCuentaBanco"].Value = IdCuentaBanco;

                    //ajustar propiedades de impresion
                    report.Landscape = true;
                    report.ShowPrintMarginsWarning = false;
                    report.PrinterName = cboTipoImpresora.Text;
                    //mostrar reporte
                    report.ShowPreview();
                }
                else if (cboTipoImpresora.Text.Contains("HP"))
                {
                    //crear objeto Reporte
                    ReportesTesoreria.ImpresionChequeBAN report = new ReportesTesoreria.ImpresionChequeBAN();

                    //asignar parametros del reporte
                    report.Parameters["pIdTransaccionBanco"].Value = IdTransaccionBanco;
                    report.Parameters["pIdTransaccionBancoFinal"].Value = IdTransaccionBancoFinal;
                    report.Parameters["pIdCuentaBanco"].Value = IdCuentaBanco;

                    //ajustar propiedades de impresion
                    report.PaperKind = System.Drawing.Printing.PaperKind.Letter;
                    report.PrinterName = cboTipoImpresora.Text;
                    //mostrar reporte
                    report.ShowPreview();
                }
                else
                    XtraMessageBox.Show("Seleccione una impresora EPSON o HP\npara realizar la impresión del Cheque.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método para Imprimir el Cheque HSBC
        /// <param name="pIdBanco">IdBanco</param>
        /// </summary>
        private void ImprimirChequeHSBC(DetalleChequesMasivos objDetalle = null)
        {
            Int64 IdTransaccionBanco = -1;
            Int64 IdTransaccionBancoFinal = -1;
            Int32 IdCuentaBanco = -1;

            //si es cheques masivos
            if (objDetalle != null)
            {
                //asignar valores del IdTransaccionBanco, IdTransaccionBancoFinal, IdCuentaBanco
                //para cheques masivos
                IdTransaccionBanco = objDetalle.IdTransaccionBancoInicial;
                IdTransaccionBancoFinal = objDetalle.IdTransaccionBancoFinal;
                IdCuentaBanco = objDetalle.IdCuentaBanco;
            }
            else
            {
                //asignar valor del IdTransaccionBanco 
                //para emitir 1 cheque
                IdTransaccionBanco = Convert.ToInt64(lblFolioMovimiento.Text);
            }

            try
            {
                //verificar tipo de impresora
                if (cboTipoImpresora.Text.Contains("EPSON"))
                {
                    //crear objeto Reporte
                    ReportesTesoreria.ImpresionChequeHSBC_Epson report = new ReportesTesoreria.ImpresionChequeHSBC_Epson();

                    //asignar parametros del reporte
                    report.Parameters["pIdTransaccionBanco"].Value = IdTransaccionBanco;
                    report.Parameters["pIdTransaccionBancoFinal"].Value = IdTransaccionBancoFinal;
                    report.Parameters["pIdCuentaBanco"].Value = IdCuentaBanco;

                    //ajustar propiedades de impresion
                    report.Landscape = true;
                    report.ShowPrintMarginsWarning = false;
                    report.PrinterName = cboTipoImpresora.Text;
                    //mostrar reporte
                    report.ShowPreview();
                }
                else if (cboTipoImpresora.Text.Contains("HP"))
                {
                    //crear objeto Reporte
                    ReportesTesoreria.ImpresionChequeHSBC report = new ReportesTesoreria.ImpresionChequeHSBC();

                    //asignar parametros del reporte
                    report.Parameters["pIdTransaccionBanco"].Value = IdTransaccionBanco;
                    report.Parameters["pIdTransaccionBancoFinal"].Value = IdTransaccionBancoFinal;
                    report.Parameters["pIdCuentaBanco"].Value = IdCuentaBanco;

                    //ajustar propiedades de impresion
                    report.PaperKind = System.Drawing.Printing.PaperKind.Letter;
                    report.PrinterName = cboTipoImpresora.Text;
                    //mostrar reporte
                    report.ShowPreview();
                }
                else
                    XtraMessageBox.Show("Seleccione una impresora EPSON o HP\npara realizar la impresión del Cheque.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método para Imprimir el Cheque IXE
        /// <param name="pIdBanco">IdBanco</param>
        /// </summary>
        private void ImprimirChequeIXE(DetalleChequesMasivos objDetalle = null)
        {
            Int64 IdTransaccionBanco = -1;
            Int64 IdTransaccionBancoFinal = -1;
            Int32 IdCuentaBanco = -1;

            //si es cheques masivos
            if (objDetalle != null)
            {
                //asignar valores del IdTransaccionBanco, IdTransaccionBancoFinal, IdCuentaBanco
                //para cheques masivos
                IdTransaccionBanco = objDetalle.IdTransaccionBancoInicial;
                IdTransaccionBancoFinal = objDetalle.IdTransaccionBancoFinal;
                IdCuentaBanco = objDetalle.IdCuentaBanco;
            }
            else
            {
                //asignar valor del IdTransaccionBanco 
                //para emitir 1 cheque
                IdTransaccionBanco = Convert.ToInt64(lblFolioMovimiento.Text);
            }

            try
            {
                //verificar tipo de impresora
                if (cboTipoImpresora.Text.Contains("EPSON"))
                {
                    //crear objeto Reporte
                    ReportesTesoreria.ImpresionChequeIXE_Epson report = new ReportesTesoreria.ImpresionChequeIXE_Epson();

                    //asignar parametros del reporte
                    report.Parameters["pIdTransaccionBanco"].Value = IdTransaccionBanco;
                    report.Parameters["pIdTransaccionBancoFinal"].Value = IdTransaccionBancoFinal;
                    report.Parameters["pIdCuentaBanco"].Value = IdCuentaBanco;

                    //ajustar propiedades de impresion
                    report.Landscape = true;
                    report.ShowPrintMarginsWarning = false;
                    report.PrinterName = cboTipoImpresora.Text;
                    //mostrar reporte
                    report.ShowPreview();
                }
                else if (cboTipoImpresora.Text.Contains("HP"))
                {
                    //crear objeto Reporte
                    ReportesTesoreria.ImpresionChequeIXE report = new ReportesTesoreria.ImpresionChequeIXE();

                    //asignar parametros del reporte
                    report.Parameters["pIdTransaccionBanco"].Value = IdTransaccionBanco;
                    report.Parameters["pIdTransaccionBancoFinal"].Value = IdTransaccionBancoFinal;
                    report.Parameters["pIdCuentaBanco"].Value = IdCuentaBanco;

                    //ajustar propiedades de impresion
                    report.PaperKind = System.Drawing.Printing.PaperKind.Letter;
                    report.PrinterName = cboTipoImpresora.Text;
                    //mostrar reporte
                    report.ShowPreview();
                }
                else
                    XtraMessageBox.Show("Seleccione una impresora EPSON o HP\npara realizar la impresión del Cheque.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método para Imprimir el Cheque SANTANDER
        /// <param name="pIdBanco">IdBanco</param>
        /// </summary>
        private void ImprimirChequeSAN(DetalleChequesMasivos objDetalle = null)
        {
            Int64 IdTransaccionBanco = -1;
            Int64 IdTransaccionBancoFinal = -1;
            Int32 IdCuentaBanco = -1;

            //si es cheques masivos
            if (objDetalle != null)
            {
                //asignar valores del IdTransaccionBanco, IdTransaccionBancoFinal, IdCuentaBanco
                //para cheques masivos
                IdTransaccionBanco = objDetalle.IdTransaccionBancoInicial;
                IdTransaccionBancoFinal = objDetalle.IdTransaccionBancoFinal;
                IdCuentaBanco = objDetalle.IdCuentaBanco;
            }
            else
            {
                //asignar valor del IdTransaccionBanco 
                //para emitir 1 cheque
                IdTransaccionBanco = Convert.ToInt64(lblFolioMovimiento.Text);
            }

            try
            {
                //verificar tipo de impresora
                if (cboTipoImpresora.Text.Contains("EPSON"))
                {
                    //crear objeto Reporte
                    ReportesTesoreria.ImpresionChequeSAN_Epson report = new ReportesTesoreria.ImpresionChequeSAN_Epson();

                    //asignar parametros del reporte
                    report.Parameters["pIdTransaccionBanco"].Value = IdTransaccionBanco;
                    report.Parameters["pIdTransaccionBancoFinal"].Value = IdTransaccionBancoFinal;
                    report.Parameters["pIdCuentaBanco"].Value = IdCuentaBanco;

                    //ajustar propiedades de impresion
                    report.Landscape = true;
                    report.ShowPrintMarginsWarning = false;
                    report.PrinterName = cboTipoImpresora.Text;
                    //mostrar reporte
                    report.ShowPreview();
                }
                else if (cboTipoImpresora.Text.Contains("HP"))
                {
                    //crear objeto Reporte
                    ReportesTesoreria.ImpresionChequeSAN report = new ReportesTesoreria.ImpresionChequeSAN();

                    //asignar parametros del reporte
                    report.Parameters["pIdTransaccionBanco"].Value = IdTransaccionBanco;
                    report.Parameters["pIdTransaccionBancoFinal"].Value = IdTransaccionBancoFinal;
                    report.Parameters["pIdCuentaBanco"].Value = IdCuentaBanco;

                    //ajustar propiedades de impresion
                    report.PaperKind = System.Drawing.Printing.PaperKind.Letter;
                    report.PrinterName = cboTipoImpresora.Text;
                    //mostrar reporte
                    report.ShowPreview();
                }
                else
                    XtraMessageBox.Show("Seleccione una impresora EPSON o HP\npara realizar la impresión del Cheque.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Método para Imprimir el Cheque SANTANDER
        /// <param name="pIdBanco">IdBanco</param>
        /// </summary>
        private void ImprimirChequeSAN_Nuevo(DetalleChequesMasivos objDetalle = null)
        {
            Int64 IdTransaccionBanco = -1;
            Int64 IdTransaccionBancoFinal = -1;
            Int32 IdCuentaBanco = -1;

            //si es cheques masivos
            if (objDetalle != null)
            {
                //asignar valores del IdTransaccionBanco, IdTransaccionBancoFinal, IdCuentaBanco
                //para cheques masivos
                IdTransaccionBanco = objDetalle.IdTransaccionBancoInicial;
                IdTransaccionBancoFinal = objDetalle.IdTransaccionBancoFinal;
                IdCuentaBanco = objDetalle.IdCuentaBanco;
            }
            else
            {
                //asignar valor del IdTransaccionBanco 
                //para emitir 1 cheque
                IdTransaccionBanco = Convert.ToInt64(lblFolioMovimiento.Text);
            }

            try
            {
                //verificar tipo de impresora
                if (cboTipoImpresora.Text.Contains("EPSON"))
                {
                    //crear objeto Reporte
                    ReportesTesoreria.ImpresionChequeSAN_Epson_Nuevo report = new ReportesTesoreria.ImpresionChequeSAN_Epson_Nuevo();

                    //asignar parametros del reporte
                    report.Parameters["pIdTransaccionBanco"].Value = IdTransaccionBanco;
                    report.Parameters["pIdTransaccionBancoFinal"].Value = IdTransaccionBancoFinal;
                    report.Parameters["pIdCuentaBanco"].Value = IdCuentaBanco;

                    //ajustar propiedades de impresion
                    report.Landscape = true;
                    report.ShowPrintMarginsWarning = false;
                    report.PrinterName = cboTipoImpresora.Text;
                    //mostrar reporte
                    report.ShowPreview();
                }
                else if (cboTipoImpresora.Text.Contains("HP"))
                {
                    //crear objeto Reporte
                    ReportesTesoreria.ImpresionChequeSAN_Nuevo report = new ReportesTesoreria.ImpresionChequeSAN_Nuevo();

                    //asignar parametros del reporte
                    report.Parameters["pIdTransaccionBanco"].Value = IdTransaccionBanco;
                    report.Parameters["pIdTransaccionBancoFinal"].Value = IdTransaccionBancoFinal;
                    report.Parameters["pIdCuentaBanco"].Value = IdCuentaBanco;

                    //ajustar propiedades de impresion
                    report.PaperKind = System.Drawing.Printing.PaperKind.Letter;
                    report.PrinterName = cboTipoImpresora.Text;
                    //mostrar reporte
                    report.ShowPreview();
                }
                else
                    XtraMessageBox.Show("Seleccione una impresora EPSON o HP\npara realizar la impresión del Cheque.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Método para Imprimir el Cheque INTERACCIONES
        /// <param name="pIdBanco">IdBanco</param>
        /// </summary>
        private void ImprimirChequeINT(DetalleChequesMasivos objDetalle = null)
        {
            Int64 IdTransaccionBanco = -1;
            Int64 IdTransaccionBancoFinal = -1;
            Int32 IdCuentaBanco = -1;

            //si es cheques masivos
            if (objDetalle != null)
            {
                //asignar valores del IdTransaccionBanco, IdTransaccionBancoFinal, IdCuentaBanco
                //para cheques masivos
                IdTransaccionBanco = objDetalle.IdTransaccionBancoInicial;
                IdTransaccionBancoFinal = objDetalle.IdTransaccionBancoFinal;
                IdCuentaBanco = objDetalle.IdCuentaBanco;
            }
            else
            {
                //asignar valor del IdTransaccionBanco 
                //para emitir 1 cheque
                IdTransaccionBanco = Convert.ToInt64(lblFolioMovimiento.Text);
            }

            try
            {
                //verificar tipo de impresora
                if (cboTipoImpresora.Text.Contains("EPSON"))
                {
                    //crear objeto Reporte
                    ReportesTesoreria.ImpresionChequeINT_Epson report = new ReportesTesoreria.ImpresionChequeINT_Epson();

                    //asignar parametros del reporte
                    report.Parameters["pIdTransaccionBanco"].Value = IdTransaccionBanco;
                    report.Parameters["pIdTransaccionBancoFinal"].Value = IdTransaccionBancoFinal;
                    report.Parameters["pIdCuentaBanco"].Value = IdCuentaBanco;

                    //ajustar propiedades de impresion
                    report.Landscape = true;
                    report.ShowPrintMarginsWarning = false;
                    report.PrinterName = cboTipoImpresora.Text;
                    //mostrar reporte
                    report.ShowPreview();
                }
                else if (cboTipoImpresora.Text.Contains("HP"))
                {
                    //crear objeto Reporte
                    ReportesTesoreria.ImpresionChequeINT report = new ReportesTesoreria.ImpresionChequeINT();

                    //asignar parametros del reporte
                    report.Parameters["pIdTransaccionBanco"].Value = IdTransaccionBanco;
                    report.Parameters["pIdTransaccionBancoFinal"].Value = IdTransaccionBancoFinal;
                    report.Parameters["pIdCuentaBanco"].Value = IdCuentaBanco;

                    //ajustar propiedades de impresion
                    report.PaperKind = System.Drawing.Printing.PaperKind.Letter;
                    report.PrinterName = cboTipoImpresora.Text;
                    //mostrar reporte
                    report.ShowPreview();
                }
                else
                    XtraMessageBox.Show("Seleccione una impresora EPSON o HP\npara realizar la impresión del Cheque.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método para Imprimir el Cheque SCOTIABANK
        /// <param name="pIdBanco">IdBanco</param>
        /// </summary>
        private void ImprimirChequeSCO(DetalleChequesMasivos objDetalle = null)
        {
            Int64 IdTransaccionBanco = -1;
            Int64 IdTransaccionBancoFinal = -1;
            Int32 IdCuentaBanco = -1;

            //si es cheques masivos
            if (objDetalle != null)
            {
                //asignar valores del IdTransaccionBanco, IdTransaccionBancoFinal, IdCuentaBanco
                //para cheques masivos
                IdTransaccionBanco = objDetalle.IdTransaccionBancoInicial;
                IdTransaccionBancoFinal = objDetalle.IdTransaccionBancoFinal;
                IdCuentaBanco = objDetalle.IdCuentaBanco;
            }
            else
            {
                //asignar valor del IdTransaccionBanco 
                //para emitir 1 cheque
                IdTransaccionBanco = Convert.ToInt64(lblFolioMovimiento.Text);
            }

            try
            {
                //verificar tipo de impresora
                if (cboTipoImpresora.Text.Contains("EPSON"))
                {
                    //crear objeto Reporte
                    ReportesTesoreria.ImpresionChequeSCO_Epson report = new ReportesTesoreria.ImpresionChequeSCO_Epson();

                    //asignar parametros del reporte
                    report.Parameters["pIdTransaccionBanco"].Value = IdTransaccionBanco;
                    report.Parameters["pIdTransaccionBancoFinal"].Value = IdTransaccionBancoFinal;
                    report.Parameters["pIdCuentaBanco"].Value = IdCuentaBanco;

                    //ajustar propiedades de impresion
                    report.Landscape = true;
                    report.ShowPrintMarginsWarning = false;
                    report.PrinterName = cboTipoImpresora.Text;
                    //mostrar reporte
                    report.ShowPreview();
                }
                else if (cboTipoImpresora.Text.Contains("HP"))
                {
                    //crear objeto Reporte
                    ReportesTesoreria.ImpresionChequeSCO report = new ReportesTesoreria.ImpresionChequeSCO();

                    //asignar parametros del reporte
                    report.Parameters["pIdTransaccionBanco"].Value = IdTransaccionBanco;
                    report.Parameters["pIdTransaccionBancoFinal"].Value = IdTransaccionBancoFinal;
                    report.Parameters["pIdCuentaBanco"].Value = IdCuentaBanco;

                    //ajustar propiedades de impresion
                    report.PaperKind = System.Drawing.Printing.PaperKind.Letter;
                    report.PrinterName = cboTipoImpresora.Text;
                    //mostrar reporte
                    report.ShowPreview();
                }
                else
                    XtraMessageBox.Show("Seleccione una impresora EPSON o HP\npara realizar la impresión del Cheque.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Método para Imprimir el Cheque CI BANCO
        /// <param name="pIdBanco">IdBanco</param>
        /// </summary>
        private void ImprimirChequeCIB(DetalleChequesMasivos objDetalle = null)
        {
            Int64 IdTransaccionBanco = -1;
            Int64 IdTransaccionBancoFinal = -1;
            Int32 IdCuentaBanco = -1;

            //si es cheques masivos
            if (objDetalle != null)
            {
                //asignar valores del IdTransaccionBanco, IdTransaccionBancoFinal, IdCuentaBanco
                //para cheques masivos
                IdTransaccionBanco = objDetalle.IdTransaccionBancoInicial;
                IdTransaccionBancoFinal = objDetalle.IdTransaccionBancoFinal;
                IdCuentaBanco = objDetalle.IdCuentaBanco;
            }
            else
            {
                //asignar valor del IdTransaccionBanco 
                //para emitir 1 cheque
                IdTransaccionBanco = Convert.ToInt64(lblFolioMovimiento.Text);
            }

            try
            {
                //verificar tipo de impresora
                if (cboTipoImpresora.Text.Contains("EPSON"))
                {
                    //crear objeto Reporte
                    ReportesTesoreria.ImpresionChequeCIB_Epson report = new ReportesTesoreria.ImpresionChequeCIB_Epson();

                    //asignar parametros del reporte
                    report.Parameters["pIdTransaccionBanco"].Value = IdTransaccionBanco;
                    report.Parameters["pIdTransaccionBancoFinal"].Value = IdTransaccionBancoFinal;
                    report.Parameters["pIdCuentaBanco"].Value = IdCuentaBanco;

                    //ajustar propiedades de impresion
                    report.Landscape = true;
                    report.ShowPrintMarginsWarning = false;
                    report.PrinterName = cboTipoImpresora.Text;
                    //mostrar reporte
                    report.ShowPreview();
                }
                else if (cboTipoImpresora.Text.Contains("HP"))
                {
                    //crear objeto Reporte
                    ReportesTesoreria.ImpresionChequeCIB report = new ReportesTesoreria.ImpresionChequeCIB();

                    //asignar parametros del reporte
                    report.Parameters["pIdTransaccionBanco"].Value = IdTransaccionBanco;
                    report.Parameters["pIdTransaccionBancoFinal"].Value = IdTransaccionBancoFinal;
                    report.Parameters["pIdCuentaBanco"].Value = IdCuentaBanco;

                    //ajustar propiedades de impresion
                    report.PaperKind = System.Drawing.Printing.PaperKind.Letter;
                    report.PrinterName = cboTipoImpresora.Text;
                    //mostrar reporte
                    report.ShowPreview();
                }
                else
                    XtraMessageBox.Show("Seleccione una impresora EPSON o HP\npara realizar la impresión del Cheque.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método para Imprimir el Cheque INBURSA
        /// <param name="pIdBanco">IdBanco</param>
        /// </summary>
        private void ImprimirChequeINBUR(DetalleChequesMasivos objDetalle = null)
        {
            Int64 IdTransaccionBanco = -1;
            Int64 IdTransaccionBancoFinal = -1;
            Int32 IdCuentaBanco = -1;

            //si es cheques masivos
            if (objDetalle != null)
            {
                //asignar valores del IdTransaccionBanco, IdTransaccionBancoFinal, IdCuentaBanco
                //para cheques masivos
                IdTransaccionBanco = objDetalle.IdTransaccionBancoInicial;
                IdTransaccionBancoFinal = objDetalle.IdTransaccionBancoFinal;
                IdCuentaBanco = objDetalle.IdCuentaBanco;
            }
            else
            {
                //asignar valor del IdTransaccionBanco 
                //para emitir 1 cheque
                IdTransaccionBanco = Convert.ToInt64(lblFolioMovimiento.Text);
            }

            try
            {
                //verificar tipo de impresora
                if (cboTipoImpresora.Text.Contains("EPSON"))
                {
                    //crear objeto Reporte
                    ReportesTesoreria.ImpresionChequeINBUR_Epson report = new ReportesTesoreria.ImpresionChequeINBUR_Epson();

                    //asignar parametros del reporte
                    report.Parameters["pIdTransaccionBanco"].Value = IdTransaccionBanco;
                    report.Parameters["pIdTransaccionBancoFinal"].Value = IdTransaccionBancoFinal;
                    report.Parameters["pIdCuentaBanco"].Value = IdCuentaBanco;

                    //ajustar propiedades de impresion
                    report.Landscape = true;
                    report.ShowPrintMarginsWarning = false;
                    report.PrinterName = cboTipoImpresora.Text;
                    //mostrar reporte
                    report.ShowPreview();
                }
                else if (cboTipoImpresora.Text.Contains("HP"))
                {
                    //crear objeto Reporte
                    ReportesTesoreria.ImpresionChequeINBUR report = new ReportesTesoreria.ImpresionChequeINBUR();

                    //asignar parametros del reporte
                    report.Parameters["pIdTransaccionBanco"].Value = IdTransaccionBanco;
                    report.Parameters["pIdTransaccionBancoFinal"].Value = IdTransaccionBancoFinal;
                    report.Parameters["pIdCuentaBanco"].Value = IdCuentaBanco;

                    //ajustar propiedades de impresion
                    report.PaperKind = System.Drawing.Printing.PaperKind.Letter;
                    report.PrinterName = cboTipoImpresora.Text;
                    //mostrar reporte
                    report.ShowPreview();
                }
                else
                    XtraMessageBox.Show("Seleccione una impresora EPSON o HP\npara realizar la impresión del Cheque.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método para Imprimir el Cheque SCOTIABANK
        /// <param name="pIdBanco">IdBanco</param>
        /// </summary>
        private void ImprimirChequeBBJ(DetalleChequesMasivos objDetalle = null)
        {
            Int64 IdTransaccionBanco = -1;
            Int64 IdTransaccionBancoFinal = -1;
            Int32 IdCuentaBanco = -1;

            //si es cheques masivos
            if (objDetalle != null)
            {
                //asignar valores del IdTransaccionBanco, IdTransaccionBancoFinal, IdCuentaBanco
                //para cheques masivos
                IdTransaccionBanco = objDetalle.IdTransaccionBancoInicial;
                IdTransaccionBancoFinal = objDetalle.IdTransaccionBancoFinal;
                IdCuentaBanco = objDetalle.IdCuentaBanco;
            }
            else
            {
                //asignar valor del IdTransaccionBanco 
                //para emitir 1 cheque
                IdTransaccionBanco = Convert.ToInt64(lblFolioMovimiento.Text);
            }

            try
            {
                //verificar tipo de impresora
                if (cboTipoImpresora.Text.Contains("EPSON"))
                {
                    //crear objeto Reporte
                    ReportesTesoreria.ImpresionChequeBBJ_Epson report = new ReportesTesoreria.ImpresionChequeBBJ_Epson();

                    //asignar parametros del reporte
                    report.Parameters["pIdTransaccionBanco"].Value = IdTransaccionBanco;
                    report.Parameters["pIdTransaccionBancoFinal"].Value = IdTransaccionBancoFinal;
                    report.Parameters["pIdCuentaBanco"].Value = IdCuentaBanco;

                    //ajustar propiedades de impresion
                    report.Landscape = true;
                    report.ShowPrintMarginsWarning = false;
                    report.PrinterName = cboTipoImpresora.Text;
                    //mostrar reporte
                    report.ShowPreview();
                }
                else if (cboTipoImpresora.Text.Contains("HP"))
                {
                    //crear objeto Reporte
                    ReportesTesoreria.ImpresionChequeBBJ report = new ReportesTesoreria.ImpresionChequeBBJ();

                    //asignar parametros del reporte
                    report.Parameters["pIdTransaccionBanco"].Value = IdTransaccionBanco;
                    report.Parameters["pIdTransaccionBancoFinal"].Value = IdTransaccionBancoFinal;
                    report.Parameters["pIdCuentaBanco"].Value = IdCuentaBanco;

                    //ajustar propiedades de impresion
                    report.PaperKind = System.Drawing.Printing.PaperKind.Letter;
                    report.PrinterName = cboTipoImpresora.Text;
                    //mostrar reporte
                    report.ShowPreview();
                }
                else
                    XtraMessageBox.Show("Seleccione una impresora EPSON o HP\npara realizar la impresión del Cheque.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Método para imprimir la Póliza de Cheque
        /// </summary>
        private void ImprimirPolizaCheque()
        {
                //asignar valor del IdTransaccionBanco
                Int64 IdTransaccionBanco = Convert.ToInt64(lblFolioMovimiento.Text);
                //crear objeto Reporte
                ReportesTesoreria.ImpresionPolizaCheque report = new ReportesTesoreria.ImpresionPolizaCheque();

                try
                {
                    //asignar parametros del reporte
                    report.Parameters["pIdTransaccionBanco"].Value = IdTransaccionBanco;

                    //asigna tamaño de papel
                    report.PaperKind = System.Drawing.Printing.PaperKind.Letter;
                    //mostrar reporte
                    report.ShowPreview();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }


        /// <summary>
        /// Método que despliega la pantalla Solicitud No. Cheque
        /// </summary>
        /// <returns>Texto escrito por el usuario</returns>
        public void MostrarSolicitudNoChequesDialogBox()
        {
            frmxSolicitudNoCheque objDialog = new frmxSolicitudNoCheque();
            string strNoChequeInicial = "";
            string strNoChequeFinal = "";

            // muestra la pantalla en modo Dialog
            //y se determina si DialogResult = OK
            if (objDialog.ShowDialog(this) == DialogResult.OK)
            {
                // Leer el rango de Cheques
                strNoChequeInicial = objDialog.txtNoChequeInicial.Text.Trim();
                strNoChequeFinal = objDialog.txtNoChequeFinal.Text.Trim();

                //validar que el No. de Folio Inicial
                if (Convert.ToInt64(strNoChequeFinal) >= Convert.ToInt64(strNoChequeInicial))
                {
                    //asignar valor del IdTransaccionBanco
                    Int32 IdCuentaBanco = Convert.ToInt32(cboCuentaBanco.EditValue);
                    //crear objeto Reporte
                    ReportesTesoreria.ImpresionPolizaChequeMasivo report = new ReportesTesoreria.ImpresionPolizaChequeMasivo();

                    try
                    {
                        //asignar parametros del reporte
                        report.Parameters["pIdCuentaBanco"].Value = IdCuentaBanco;
                        report.Parameters["pNoTransaccionInicial"].Value = strNoChequeInicial;
                        report.Parameters["pNoTransaccionFinal"].Value = strNoChequeFinal;

                        //asigna tamaño de papel
                        report.PaperKind = System.Drawing.Printing.PaperKind.Letter;
                        //mostrar reporte
                        report.ShowPreview();
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    XtraMessageBox.Show("El No. de Cheque Inicial NO puede \nser menor al No de Cheque Final", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            objDialog.Dispose();
            //return strMotivoCancelacion;      //regresar motivo cancelacion
        }

        /// <summary>
        /// Método para imprimir Pólizas de Cheque Masivo
        /// </summary>
        private void ImprimirPolizaChequeMasivo()
        {
            MostrarSolicitudNoChequesDialogBox();       //procesar reporte Polizas Cheque Masivo
        }

        #endregion

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();       //cerrar pantalla
        }

        private void frmxEmisionCheques_Load(object sender, EventArgs e)
        {
            try
            {
                splashSMCargando.ShowWaitForm();
                //IdClasifCliente       = 1 incluir los Clientes
                //IdClasifProveedor  = 3 incluir los Proveedores
                this.stpSelClienteProveedorChequesTableAdapter1.Fill(this.dbSAICBPOTesoreriaDataSet.stpSelClienteProveedorCheques,1,3);
                this.stpSelFolioLoteCargaNominaParaChequesTableAdapter.Fill(this.dbSAICBPOTesoreriaDataSet.stpSelFolioLoteCargaNominaParaCheques);
                this.stpSelCategoriaTransaccionBancoTableAdapter.Fill(this.dbSAICBPOCatalogosDataSet.stpSelCategoriaTransaccionBanco,"OPER");
                this.stpSelBancoTableAdapter.Fill(this.dbSAICBPOCatalogosDataSet.stpSelBanco);
                this.stpSelEstatusChequesTableAdapter.Fill(this.dbSAICBPOTesoreriaDataSet.stpSelEstatusCheques);

                flagTipoOperacion = (byte)TipoMovimientoBanco.Ninguno;    //inicializar bandera que indica Tipo Operacion

                // Specify the total dropdown width. 
                cboCuentaBanco.Properties.PopupFormWidth = 500;
                // Specify the total dropdown width. 
                cboClienteProveedor.Properties.PopupFormWidth = 700;
                // Set column widths according to their contents. 
                cboFolioLoteCargaNomina.Properties.View.BestFitColumns();
                // Specify the total dropdown width. 
                cboFolioLoteCargaNomina.Properties.PopupFormWidth = 900;

                cboFecha.DateTime = DateTime.Now.Date;
                InicializarControles();     //inicializar controles
                BloquearControles(false);       //bloquear controles
                HabilitarBotones(true);     //habilitar botones
                lblMoneda.Text = "";        //inicializar Moneda
                btnCancelarCheque.Enabled = false;      //desactivar boton Cancelar Cheque
                
                //colocar la Categoria Transaccion con el valor CHEQUE por default
                cboCategoriaTransaccionBanco.EditValue = cboCategoriaTransaccionBanco.Properties.GetKeyValue(0);

                //colocar Estatus Transaccion con el valor NO DISPONIBLE por default
                cboEstatusCheque.EditValue = cboEstatusCheque.Properties.GetKeyValue(0);
                CargarImpresorasAutorizadas();  //cargar impresoras autorizadas para impresion
                 
                splashSMCargando.CloseWaitForm();
            }
            catch (Exception ex)
            {
                splashSMCargando.CloseWaitForm();
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboBanco_EditValueChanged(object sender, EventArgs e)
        {
            if (!cboBanco.EditValue.Equals(""))     //asegurar que el valor sea diferente de vacio
            {
                //realizar consulta de las cuentas bancarias en base al Banco seleccionado
                this.stpSelCuentaBancoPorBancoTableAdapter.Fill(this.dbSAICBPOTesoreriaDataSet.stpSelCuentaBancoPorBanco, Convert.ToByte(cboBanco.EditValue));
                lblMoneda.Text = "";        //inicializar label de moneda

                if (cboBanco.Text == "SANTANDER")
                    chFormato.Enabled = true;
                else
                    chFormato.Enabled = false;
            }
        }

        private void btnImprimirCheque_Click(object sender, EventArgs e)
        {
            //si existe folio entonces mostrar formato cheque en base al Banco
            if ((lblFolioMovimiento.Text.Length > 0) && (Convert.ToInt64(lblFolioMovimiento.Text) > 0))
                //si no está cancelado el cheque
                if (chkCancelado.Checked == false)
                {
                    //
                    switch (cboBanco.Text)      //evaluo el banco seleccionado
                    {
                        case "BANAMEX":
                            ImprimirChequeBX();   //imprimir cheque BX
                            break;
                        case "BANCOMER":
                            ImprimirChequeBBVA();   //imprimir cheque BBVA
                            break;
                        case "BANORTE":
                            ImprimirChequeBAN();   //imprimir cheque BANORTE
                            break;
                        case "SANTANDER":
                            if (chFormato.Checked)
                                ImprimirChequeSAN_Nuevo();
                            else
                                ImprimirChequeSAN();   //imprimir cheque SANTANDER
                            break;
                        case "HSBC":
                            ImprimirChequeHSBC();   //imprimir cheque HSBC
                            break;
                        case "IXE":
                            ImprimirChequeIXE();   //imprimir cheque IXE
                            break;
                        case "INTERACCIONES":
                            ImprimirChequeINT();        //imprimir cheque INTERACCIONES
                            break;
                        case "SCOTIABANK":
                            ImprimirChequeSCO();     //imprimir cheque SCOTIABANK
                            break;
                        case "CI BANCO":
                            ImprimirChequeCIB();        //imprimir cheque CI BANCO
                            break;
                        case "INBURSA":
                            ImprimirChequeINBUR();
                            break;
                        case "BANBAJIO":
                            ImprimirChequeBBJ();        //imprimir cheque CI BANCO
                            break;
                        default:
                            XtraMessageBox.Show("El Banco seleccionado NO tiene Formato de Cheque asociado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            break;
                    }
                }
                else
                    XtraMessageBox.Show("No puede imprimir un Cheque Cancelado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                XtraMessageBox.Show("No tiene Folio Movimiento Activo para imprimir Cheque", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    objInfoCuentaBanco = InfoCuentaBancoBD.ObtenerInfoCuentabanco(row);

                    lblMoneda.Text = objInfoCuentaBanco.DescMoneda;   //desplegar moneda en label
                }
            }
        }

        private void btnNuevoCheque_Click(object sender, EventArgs e)
        {
            flagTipoOperacion = (byte)TipoMovimientoBanco.AgregarTransaccion;    //inicializar bandera que indica Tipo Operacion
            InicializarControles();     //inicializar controles
            BloquearControles(true);       //habilitar controles
            HabilitarBotones(false);     //deshabilitar botones
            btnCancelarCheque.Enabled = false;      //desactivar boton Cancelar Cheque
            //colocar la SubCategoria Transaccion con el valor SUELDOS por default
            cboSubCategoriaTransaccionBanco.EditValue = cboSubCategoriaTransaccionBanco.Properties.GetKeyValue(0);
            //si esta una cuenta de banco activa
            if (!cboCuentaBanco.Text.Equals(""))
                txtNoCheque.Focus();      //colocar cursor en No. Cheque
            else
                cboBanco.Focus();       //colocar cursor en Banco

            //validar el Movimiento Operativo para activar o desactivar CategoriaTransaccionBanco
            if (ModuloOperativo.Equals("OPER"))
                cboCategoriaTransaccionBanco.Enabled = false;
            else
                cboCategoriaTransaccionBanco.Enabled = true;

        }

        private void txtImporte_Leave(object sender, EventArgs e)
        {
            //convertir importe en Letra después que el cursor sale del control
            txtImporteLetra.Text = Convertidor.ConvierteImporte2Leyenda(Convert.ToDecimal(txtImporte.Text), lblMoneda.Text);
        }

        private void cboCategoriaTransaccionBanco_EditValueChanged(object sender, EventArgs e)
        {
            if (!cboCategoriaTransaccionBanco.EditValue.Equals(""))      //asegurar que el valor sea diferente de vacio
              //Obtener la información de la SubCategoriaTransaccionBanco
                this.stpSelSubCategoriaTransaccionBancoTableAdapter.Fill(this.dbSAICBPOCatalogosDataSet.stpSelSubCategoriaTransaccionBanco, Convert.ToInt32(cboCategoriaTransaccionBanco.EditValue));
        }

        private void cboSubCategoriaTransaccionBanco_EditValueChanged(object sender, EventArgs e)
        {
            //txtOtroConcepto.Text = "";

            //if (cboSubCategoriaTransaccionBanco.Text.Equals("OTRO"))
            //{
            //    txtOtroConcepto.Enabled = true;     //activar control
            //    txtOtroConcepto.Focus();        //colocar cursor en Otro Concepto
            //}
            //else
            //    txtOtroConcepto.Enabled = false;    //desactivar control
        }

        private void btnGuardarCheque_Click(object sender, EventArgs e)
        {
            //validar controles
            if (UtileriasLocal.Validator.IsPresent(cboBanco) && 
                UtileriasLocal.Validator.IsPresent(cboCuentaBanco) &&
                UtileriasLocal.Validator.IsPresent(cboClienteProveedor) &&
                UtileriasLocal.Validator.IsPresent(txtNoCheque) && 
                UtileriasLocal.Validator.IsPositiveNumber(txtNoCheque) &&
                UtileriasLocal.Validator.IsPresent(txtImporte) && 
                UtileriasLocal.Validator.IsPositiveNumber(txtImporte) &&
                UtileriasLocal.Validator.IsPresent(txtBeneficiarioCheque) &&
                UtileriasLocal.Validator.IsPresent(txtBeneficiarioPoliza) && 
                UtileriasLocal.Validator.IsPresent(cboCategoriaTransaccionBanco) &&
                UtileriasLocal.Validator.IsPresent(cboSubCategoriaTransaccionBanco))
                {
                        txtImporteLetra.Text = Convertidor.ConvierteImporte2Leyenda(Convert.ToDecimal(txtImporte.Text), lblMoneda.Text);
                        
                        //no existe cheque
                        if (!ExisteTransaccion())
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
                        }
                        else
                        {
                            //existe cheque y la acción es agregar
                            if (flagTipoOperacion == (byte)TipoMovimientoBanco.AgregarTransaccion)
                                    XtraMessageBox.Show("El No. de Cheque ya existe. NO se puede capturar nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
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

        private void btnImprimirPoliza_Click(object sender, EventArgs e)
        {
            //si existe un folio activo
            if ((lblFolioMovimiento.Text.Length > 0) && (Convert.ToInt64(lblFolioMovimiento.Text) > 0))
                //si no está cancelado el cheque
                if (chkCancelado.Checked == false)
                    ImprimirPolizaCheque();     //imprimir poliza cheque
                else
                    XtraMessageBox.Show("No puede imprimir la Póliza de un Cheque Cancelado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                XtraMessageBox.Show("No tiene Folio Movimiento Activo para imprimir la Póliza", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    InfoDetalleTransaccionBanco objInfoDetalleChequeEmitido = objBuscarCheque.InfoDetalleChequeEmitido;
                    if (objInfoDetalleChequeEmitido != null)
                    {
                        MostrarInfoDetalleCheque(objInfoDetalleChequeEmitido); //mostrar detalle del cheque seleccionado en Buscar
                        btnCancelarCheque.Enabled = !objInfoDetalleChequeEmitido.EstatusCancelado;   //activar/desactivar boton Cancelar Cheque
                        CambiarComportamientoComboboxFolioLoteCargaNomina();    //Método para cambiar comportamiento
                    }
                    else
                        InicializarControles();     //inicializar controles
                }
            }
            else
                XtraMessageBox.Show("No tiene Cuenta de Banco para realizar la búsqueda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void txtBeneficiarioCheque_TextChanged(object sender, EventArgs e)
        {
            txtBeneficiarioPoliza.Text = txtBeneficiarioCheque.Text;
        }

        private void btnCancelarCheque_Click(object sender, EventArgs e)
        {
            //si existe folio entonces mostrar formato cheque en base al Banco
            if ((lblFolioMovimiento.Text.Length > 0) && (Convert.ToInt64(lblFolioMovimiento.Text) > 0))
            {
                //si no está conciliado el cheque
                if (chkChequeConciliado.Checked == false)
                {
                    //confirmar cancelacion
                    if (XtraMessageBox.Show(string.Format("¿Está seguro que desea cancelar el Folio # {0}?", lblFolioMovimiento.Text), "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                    {
            
                        //obtener el motivo de la cancelacion
                        MotivoCancelacionChequera objMotivoCancelacion = MostrarCancelacionMovChequeraDialogBox();


                        //realizar cancelacion de cheque
                        int intError = CancelarTransaccionBanco(Convert.ToInt64(lblFolioMovimiento.Text), objMotivoCancelacion, OperadorBD.OperadorGlobal.NombreUsuario);

                        //InicializarControles();     //limpiar controles

                        if (intError < 0)
                            //si la actualizacion NO fué correcta, 
                            XtraMessageBox.Show("NO fué posible cancelar el Cheque. ¡Contacte a Sistemas!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            this.stpSelDetalleChequeTableAdapter1.Fill(this.dbSAICBPOTesoreriaDataSet.stpSelDetalleCheque, Convert.ToInt64(lblFolioMovimiento.Text));

                            if (this.dbSAICBPOTesoreriaDataSet.stpSelDetalleCheque.Count > 0)
                            {
                                //almacenar el Objeto Row con los cambios de cancelacion del cheque
                                DataRow row = this.dbSAICBPOTesoreriaDataSet.stpSelDetalleCheque.Rows[0];
                                //almacenar el Objeto Row en un objeto InfoDetalleCheque
                                InfoDetalleTransaccionBanco objInfoDetalleChequeEmitido = InfoDetalleTransaccionBancoBD.ObtenerInfoDetalleCheque(row);
                                if (objInfoDetalleChequeEmitido != null)
                                {
                                    MostrarInfoDetalleCheque(objInfoDetalleChequeEmitido);  //visualizar los ajustes
                                    btnCancelarCheque.Enabled = !objInfoDetalleChequeEmitido.EstatusCancelado;   //activar/desactivar boton Cancelar Cheque
                                }
                                else
                                    InicializarControles();     //inicializar controles
                            }
                        }
                    }   //XtraMessageBox
                }   //if NO cheque conciliado
                else
                    XtraMessageBox.Show("No se puede cancelar un Cheque que está Conciliado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                XtraMessageBox.Show("No tiene Folio Movimiento Activo para cancelar un cheque", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

       /// <summary>
        /// Método que despliega la pantalla Motivo Cancelacion
        /// </summary>
        /// <returns>Texto escrito por el usuario</returns>
        public MotivoCancelacionChequera MostrarCancelacionMovChequeraDialogBox()
        {
            frmxMotivoCancelacionMovChequera objDialog = new frmxMotivoCancelacionMovChequera();
            MotivoCancelacionChequera objMotivoCancelacion = null;

            // muestra la pantalla en modo Dialog
            //y se determina si DialogResult = OK
            if (objDialog.ShowDialog(this) == DialogResult.OK)
            {
                objMotivoCancelacion = new MotivoCancelacionChequera();     //crear objeto

                // Leer informacion de la Cancelación
                objMotivoCancelacion.EstatusCancelacionCheque = objDialog.cboSustituyeCheque.Text.Trim();
                objMotivoCancelacion.ChequeQueSustituye = objDialog.txtNoCheque.EditValue.ToString();
                objMotivoCancelacion.MotivoCancelacion = objDialog.txtMotivoCancelacion.Text.Trim();

                //si el usuario no escribió motivo entonces asignar valor default
                if (objMotivoCancelacion.MotivoCancelacion.Length == 0)
                    objMotivoCancelacion.MotivoCancelacion = "ERROR DE CAPTURA";
            }
            objDialog.Dispose();
            return objMotivoCancelacion;      //regresar motivo cancelacion
        }

        private void btnCancelarCaptura_Click(object sender, EventArgs e)
        {
            flagTipoOperacion = (byte)TipoMovimientoBanco.Ninguno;    //inicializar bandera que indica Tipo Operacion
            InicializarControles();     //inicializar controles
            BloquearControles(false);       //bloquear controles
            HabilitarBotones(true);     //habilitar botones
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
                        XtraMessageBox.Show("No se puede editar un Cheque que está Conciliado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    XtraMessageBox.Show("No se puede editar un Cheque que está Cancelado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                XtraMessageBox.Show("No tiene Folio Movimiento Activo para editar un Cheque", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtBeneficiarioCheque_EditValueChanged(object sender, EventArgs e)
        {
            txtBeneficiarioPoliza.Text = txtBeneficiarioCheque.Text;
        }

        private void chkUtilizarFolioLoteNomina_CheckedChanged(object sender, EventArgs e)
        {
            //activar o desactivar uso de combobos LoteCargaNomina
            cboFolioLoteCargaNomina.Enabled = chkUtilizarFolioLoteNomina.Checked;

            if (chkUtilizarFolioLoteNomina.Checked == false)
                cboFolioLoteCargaNomina.EditValue = -1;
        }

        private void btnImpresionMasivaPolizas_Click(object sender, EventArgs e)
        {
            //validar controles
            if (UtileriasLocal.Validator.IsPresent(cboBanco) && UtileriasLocal.Validator.IsPresent(cboCuentaBanco))
            {
                ImprimirPolizaChequeMasivo();       //mostrar pólizas
            }
        }

        private void btnImprimirChequesMasivos_Click(object sender, EventArgs e)
        {
            if (!cboCuentaBanco.EditValue.Equals(""))
            {
                frmxImpresionChequesMasivos objForm = new frmxImpresionChequesMasivos() { IdCuentaBanco = (int)cboCuentaBanco.EditValue, NombreCuentaBanco = cboCuentaBanco.Text };
                DialogResult result = objForm.ShowDialog();       //mostrar pantalla
                
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    //asignar valores capturados en la pantalla frmxImpresionChequesMasivos
                    DetalleChequesMasivos objDetalle = new DetalleChequesMasivos() { IdCuentaBanco = objForm.IdCuentaBanco, IdTransaccionBancoInicial = objForm.IdTransaccionBancoInicial, IdTransaccionBancoFinal = objForm.IdTransaccionBancoFinal };

                    switch (cboBanco.Text)      //evaluo el banco seleccionado
                    {
                        case "BANAMEX":
                            ImprimirChequeBX(objDetalle);   //imprimir cheque BX
                            break;
                        case "BANCOMER":
                            ImprimirChequeBBVA(objDetalle);   //imprimir cheque BBVA
                            break;
                        case "BANORTE":
                            ImprimirChequeBAN(objDetalle);   //imprimir cheque BANORTE
                            break;
                        case "SANTANDER":
                            if (chFormato.Checked)
                                ImprimirChequeSAN_Nuevo(objDetalle);
                            else
                                ImprimirChequeSAN(objDetalle);   //imprimir cheque SANTANDER
                            break;
                        case "HSBC":
                            ImprimirChequeHSBC(objDetalle);   //imprimir cheque HSBC
                            break;
                        case "IXE":
                            ImprimirChequeIXE(objDetalle);   //imprimir cheque IXE
                            break;
                        case "INTERACCIONES":
                            ImprimirChequeINT(objDetalle);        //imprimir cheque INTERACCIONES
                            break;
                        case "SCOTIABANK":
                            ImprimirChequeSCO(objDetalle);     //imprimir cheque SCOTIABANK
                            break;
                        case "CI BANCO":
                            ImprimirChequeCIB(objDetalle);        //imprimir cheque CI BANCO
                            break;
                        case "INBURSA":
                            ImprimirChequeINBUR(objDetalle);
                            break;
                        case "BANBAJIO":
                            ImprimirChequeBBJ(objDetalle);
                            break;
                        default:
                            XtraMessageBox.Show("El Banco seleccionado NO tiene Formato de Cheque asociado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            break;
                    }
                }   //if result == OK
            }
            else
                XtraMessageBox.Show("¡Debe seleccionar una Cuenta de Banco!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

    }
}