using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using System.Collections;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using compCatalogosSAIC;
using winAppSAIC.UtileriasLocal;

namespace winAppSAIC.Tesoreria
{
    public partial class frmxGenerarChequesMasivos2Tesoreria : DevExpress.XtraEditors.XtraForm
    {
        public frmxGenerarChequesMasivos2Tesoreria()
        {
            InitializeComponent();
        }

        #region "Variables Globales"
        public InfoSolicitudChequeHeader objInfoDetalle;
        
        #endregion

        #region "Metodos Propios"
        
        /// <summary>
        /// Método que despliega la información del encabezado de
        /// la solicitud cheque masivo
        /// </summary>
        private void MostrarInformacionSolicitudChequeMasivo()
        {
            lblNoSolicitud.Text = objInfoDetalle.IdSolicitudChequeHeader.ToString("N0");
            txtFolioLoteCargaNomina.Text = objInfoDetalle.FolioLoteCargaNomina;
            txtNombreComercialTenedora.Text = objInfoDetalle.NombreComercialTenedora;
            txtNombreComercialCliente.Text = objInfoDetalle.NombreComercialCliente;
            txtNombreOperador.Text = objInfoDetalle.Operador;
            txtTipoNomina.Text = objInfoDetalle.DescTipoPeriodoNomina;
            txtNoControl.Text = objInfoDetalle.NoControl;
            txtBancoSolicitado.Text = objInfoDetalle.BancoSolicitado;
        }

        /// <summary>
        /// Método que insertar la información del Cheque
        /// <param name="row">Objeto row con información del Cheque</param>
        /// </summary>
        private void InsertarTransaccionBanco(DataRow row)
        {
            int? pIdBeneficiarioTransaccionBanco = 0;
            int intIdBeneficiarioTransaccionBancoCheque = 0;
            int intIdBeneficiarioTransaccionBancoPoliza = 0;
            long? pIdTransaccionBanco = 0;

            try
            {
                //Insertar nuevo Beneficiario
                this.actualizacionesTesoreriaTableAdapter1.stpInsBeneficiarioTransaccionBanco(row["NombreBeneficiarioTransaccionBanco"].ToString(), ref pIdBeneficiarioTransaccionBanco);
                intIdBeneficiarioTransaccionBancoCheque = (int)pIdBeneficiarioTransaccionBanco;
                intIdBeneficiarioTransaccionBancoPoliza = intIdBeneficiarioTransaccionBancoCheque;    //asignar mismo IdBeneficiario                

                //si existen IdBeneficiario válidos
                if ((intIdBeneficiarioTransaccionBancoCheque > 0) && (intIdBeneficiarioTransaccionBancoPoliza > 0))
                {
                        //insertar Transaccion Bancaria CON Lote Carga Nomina
                    this.actualizacionesTesoreriaTableAdapter1.stpInsTransaccionMasivoBanco(objInfoDetalle.IdLoteCargaNomina, 
                                                                                            objInfoDetalle.FolioLoteCargaNomina,
                                                                                            (int)row["IdCuentaBanco"], -1,
                                                                                            intIdBeneficiarioTransaccionBancoCheque,
                                                                                            intIdBeneficiarioTransaccionBancoPoliza,
                                                                                            "RETI",
                                                                                            Convert.ToDecimal(row["MontoTransaccionRetiro"]),
                                                                                            row["MontoConLetra"].ToString(),
                                                                                            row["IdMoneda"].ToString(),
                                                                                            row["NoTransaccion"].ToString(),
                                                                                            "",
                                                                                            row["Observaciones"].ToString(),
                                                                                            (int)row["IdCategoriaTransaccionBanco"],
                                                                                            (int)row["IdSubCategoriaTransaccionBanco"],
                                                                                            Convert.ToDateTime(row["FechaTransaccion"]),
                                                                                            Convert.ToDecimal(row["MontoTransaccionRetiro"]),
                                                                                            OperadorBD.OperadorGlobal.NombreUsuario,
                                                                                            objInfoDetalle.IdCliente,
                                                                                            false,
                                                                                            "SI",   //es Cheque?
                                                                                            (long)row["IdPDOHeader"],
                                                                                            ref pIdTransaccionBanco);

                    
                    //si la inserción fué correcta, entonces mostrar IdTransaccionBanco
                    if (pIdTransaccionBanco == 0)
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


        #endregion

        

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();        //cerrar pantalla
        }

        private void frmxGenerarChequesMasivos2Tesoreria_Load(object sender, EventArgs e)
        {
            try
            {
                this.stpSelBancoTableAdapter.Fill(this.dbSAICBPOCatalogosDataSet.stpSelBanco);
                MostrarInformacionSolicitudChequeMasivo();  //mostrar informacion Solicitud Cheque Masivo
                this.stpSelDetalleSolicitudChequesMasivosTableAdapter.Fill(dbSAICBPOTesoreriaDataSet.stpSelDetalleSolicitudChequesMasivos, objInfoDetalle.IdSolicitudChequeHeader);
                btnGenerarCheques.Enabled = false;       //desactivar boton
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAsignarFolios_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent(txtFolioInicial) && Validator.IsPresent(txtFolioFinal) 
                && Validator.IsPresent(cboBanco) && Validator.IsPresent(cboCuentaBanco))
            {
                int intFolioInicial = Convert.ToInt32(txtFolioInicial.Text);        //asignar valores de los folios
                int intFolioFinal = Convert.ToInt32(txtFolioFinal.Text);

                if (intFolioInicial <= intFolioFinal)   //validar que el Folio Inicial sea menor o igual a Folio Final
                {
                    //si el No. de Folios es igual el No. de registros seleccionados
                    if (intFolioFinal - intFolioInicial + 1 <= gridView1.RowCount)
                    {
                        //existen registros seleccionados
                        if (gridView1.SelectedRowsCount > 0)
                        {
                            ArrayList rows = new ArrayList();
                            // almacenar los valores en arreglo
                            for (int i = 0; i < gridView1.SelectedRowsCount; i++)
                            {
                                if (gridView1.GetSelectedRows()[i] >= 0)
                                    rows.Add(gridView1.GetDataRow(gridView1.GetSelectedRows()[i]));
                            }

                            try
                            {
                                int ContadorFolio = Convert.ToInt32(txtFolioInicial.Text);
                                gridView1.BeginUpdate();
                                for (int i = 0; i < rows.Count; i++)
                                {
                                    DataRow row = rows[i] as DataRow;
                                    // asignar No. Transaccion
                                    row["NoTransaccion"] = ContadorFolio.ToString();
                                    //asignar Cuenta Banco
                                    row["IdCuentaBanco"] = cboCuentaBanco.EditValue;

                                    InfoSolicitudChequeDetail objDetSol = InfoSolicitudChequeDetailBD.ObtenerInfoDetalleSolicitudChequeMasivo(row);

                                    if (ContadorFolio <= intFolioFinal)
                                    {
                                        ContadorFolio++;
                                    }
                                }
                            }
                            finally
                            {
                                gridView1.EndUpdate();
                                btnGenerarCheques.Enabled = true;       //activar boton
                            }
                        }   
                        else
                        {
                            XtraMessageBox.Show("¡Debe seleccionar al menos un movimiento\npara generar el Cheque!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }   //gridView1.SelectedRowsCount
                    }
                    else
                    {
                        XtraMessageBox.Show("¡El No. de Folios de Cheques NO son suficientes\npara los movimientos seleccionados!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }  //intFolioFinal - intFolioInicial + 1 == gridView1.RowCount
                } 
                else
                {
                    XtraMessageBox.Show("¡El Folio Cheque Inicial NO puede ser mayor al Folio Cheque Final!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
                }  //intFolioInicial <= intFolioFinal
            }   
        }

        private void btnGenerarCheques_Click(object sender, EventArgs e)
        {
            int iRegAfectado = 0;
            ArrayList rows = new ArrayList();
            // almacenar los valores en arreglo
            for (int i = 0; i < gridView1.SelectedRowsCount; i++)
            {
                if (gridView1.GetSelectedRows()[i] >= 0)
                    rows.Add(gridView1.GetDataRow(gridView1.GetSelectedRows()[i]));
            }

            //insertar registros detalle de cheques masivos
            for (int i = 0; i < rows.Count; i++)
            {
                DataRow row = rows[i] as DataRow;
                InsertarTransaccionBanco(row);      //insertar cada uno de los cheques
                iRegAfectado = this.actualizacionesTesoreriaTableAdapter1.stpUpdSolicitudChequeDetailCuentaBancoNoTransaccionEstatus((long)row["IdSolicitudChequeDetail"],(Int32)row["IdCuentaBanco"],row["NoTransaccion"].ToString(), 19, OperadorBD.OperadorGlobal.NombreUsuario);
            }
            //actualizar Detalle de Cheques
            this.stpSelDetalleSolicitudChequesMasivosTableAdapter.Fill(dbSAICBPOTesoreriaDataSet.stpSelDetalleSolicitudChequesMasivos, objInfoDetalle.IdSolicitudChequeHeader);

            //sino existen más registros en el gridview
            if (gridView1.RowCount == 0)
            {
                XtraMessageBox.Show("¡Ya no existen cheques por generar!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNoControl.Text = string.Empty;
                txtFolioInicial.Text = string.Empty;
                txtFolioFinal.Text = string.Empty;
            }

        }

        private void cboIdBancoAsignado_EditValueChanged(object sender, EventArgs e)
        {
            if (!cboBanco.EditValue.Equals(""))     //asegurar que el valor sea diferente de vacio
            {
                //realizar consulta de las cuentas bancarias en base al Banco seleccionado
                this.stpSelCuentaBancoPorBancoTableAdapter.Fill(this.dbSAICBPOTesoreriaDataSet.stpSelCuentaBancoPorBanco, Convert.ToByte(cboBanco.EditValue));
            }
        }

        private void btnImprimirCheques_Click(object sender, EventArgs e)
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
                            //ImprimirChequeBX(objDetalle);   //imprimir cheque BX
                            break;
                        case "BANCOMER":
                            //ImprimirChequeBBVA(objDetalle);   //imprimir cheque BBVA
                            break;
                        case "BANORTE":
                            //ImprimirChequeBAN(objDetalle);   //imprimir cheque BANORTE
                            break;
                        case "SANTANDER":
                            //ImprimirChequeSAN(objDetalle);   //imprimir cheque SANTANDER
                            break;
                        case "HSBC":
                            //ImprimirChequeHSBC(objDetalle);   //imprimir cheque HSBC
                            break;
                        case "IXE":
                            //ImprimirChequeIXE(objDetalle);   //imprimir cheque IXE
                            break;
                        case "INTERACCIONES":
                            //ImprimirChequeINT(objDetalle);        //imprimir cheque INTERACCIONES
                            break;
                        case "SCOTIABANK":
                            //ImprimirChequeSCO(objDetalle);     //imprimir cheque SCOTIABANK
                            break;
                        case "CI BANCO":
                            //ImprimirChequeCIB(objDetalle);        //imprimir cheque CI BANCO
                            break;
                        case "INBURSA":
                            //ImprimirChequeINBUR(objDetalle);
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

        private void frmxGenerarChequesMasivos2Tesoreria_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                //si todavia existen cheque pendientes
                if (stpSelDetalleSolicitudChequesMasivosBindingSource.Count > 0)
                    //BLOQUEAR REGISTRO EN CASO DE NO ESTAR SELECCIONADO POR TESORERO
                    //  16=SOLICITUD EN PROCESO
                    this.actualizacionesTesoreriaTableAdapter1.stpUpdEstatusBloqueado(Convert.ToInt64(lblNoSolicitud.Text.Replace(",", "")), OperadorBD.OperadorGlobal.NombreUsuario, false, 16);
                else
                    //  17=SOLICITUD ATENDIDA AL 100%
                    this.actualizacionesTesoreriaTableAdapter1.stpUpdEstatusBloqueado(Convert.ToInt64(lblNoSolicitud.Text.Replace(",", "")), OperadorBD.OperadorGlobal.NombreUsuario, false, 17);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}