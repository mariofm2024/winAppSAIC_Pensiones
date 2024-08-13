using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using static winAppSAIC.tools.dsc;
using winAppSAIC.UtileriasLocal;
using compLibreriaSAIC;
using compCatalogosSAIC;
using System.Text.RegularExpressions;
using DevExpress.XtraGrid.Views.Grid;


namespace winAppSAIC.Tesoreria
{
    public partial class frmxSaldosTesoreria : DevExpress.XtraEditors.XtraForm
    {
        tools.dsc dsc = new tools.dsc();
        String[] Estructura;
        DataTable dtValidado;
        DataTable dtTablaDinamica = new DataTable();
        private static Color mainColor;

        private InfoEstadoCuentaSaldos AsignarInfoEmpresaSaldoNvo()
        {
            InfoEstadoCuentaSaldos objEstadoCuentaSaldos = null;

            try
            {
                objEstadoCuentaSaldos = new InfoEstadoCuentaSaldos();

                objEstadoCuentaSaldos.IdMatrizTenedora = Convert.ToInt16(gridLookTenedoraNvo.EditValue);
                objEstadoCuentaSaldos.IdCuentaBanco = Convert.ToInt16(gridLookTenedoraCuentasNvo.EditValue);
                objEstadoCuentaSaldos.NombreArchivo = "";
                //TODO
                objEstadoCuentaSaldos.Consecutivo = "SALINI";
                objEstadoCuentaSaldos.IdEsquema = glEsquemaNvo.EditValue.ToString();
                objEstadoCuentaSaldos.IdConcepto = 15;
                objEstadoCuentaSaldos.ClienteProveedor = "SALDO INICIAL";
                objEstadoCuentaSaldos.Observaciones = "Carga de saldo inicial";
                objEstadoCuentaSaldos.IdOperador = OperadorBD.OperadorGlobal.IdOperador;

                objEstadoCuentaSaldos.Cheque = "";
                objEstadoCuentaSaldos.Lote = "";
                objEstadoCuentaSaldos.Factura = "";
                objEstadoCuentaSaldos.Control = "";
                objEstadoCuentaSaldos.NombreHoja = "";
 

        objEstadoCuentaSaldos.Registros = 0;
                objEstadoCuentaSaldos.FechaSaldoInicial = Convert.ToDateTime(dateSaldoNvo.EditValue);
                objEstadoCuentaSaldos.SaldoInicial = Convert.ToDecimal(spinSaldoInicialNvo.EditValue);
            }

            catch (Exception ex)
            {
                XtraMessageBox.Show("Error en AsignarInfoEmpresaSaldoNvo" + Environment.NewLine +
                       ex.Message, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            return objEstadoCuentaSaldos;
        }



private InfoEstadoCuentaSaldos AsignarInfoMovimientoEd()
        {
            InfoEstadoCuentaSaldos objLibroDiarioMovimiento = null;

            try
            {
                objLibroDiarioMovimiento = new InfoEstadoCuentaSaldos();

                objLibroDiarioMovimiento.IdEstadoCuentaDetail = Convert.ToInt16(txtIdEd.Text);
                objLibroDiarioMovimiento.IdMatrizTenedora = Convert.ToInt16(cboTenedoraEditar.EditValue);
                objLibroDiarioMovimiento.IdCuentaBanco = Convert.ToInt16(cboBancoEditar.EditValue);
                objLibroDiarioMovimiento.Consecutivo = txtConsEd.Text;
                objLibroDiarioMovimiento.FechaRegistro = Convert.ToDateTime(dtFechaEd.EditValue);
                objLibroDiarioMovimiento.IdConcepto = Convert.ToInt16(cbConcepEd.EditValue);
                objLibroDiarioMovimiento.Cheque = txtChequeEd.Text.TrimEnd();
                objLibroDiarioMovimiento.Lote = txtLoteEd.Text.TrimEnd();
                objLibroDiarioMovimiento.ClienteProveedor = cbCteProvEd.Text;
                objLibroDiarioMovimiento.Factura = TxtFacturaEd.Text.TrimEnd();
                objLibroDiarioMovimiento.Control = txtControlEd.Text.TrimEnd();
                objLibroDiarioMovimiento.Ingreso = Convert.ToDecimal(spiIngresoEd.EditValue);
                objLibroDiarioMovimiento.Egreso = Convert.ToDecimal(spiEgresoEd.EditValue);
                objLibroDiarioMovimiento.Observaciones = txtObservacionesEd.Text.TrimEnd();
                objLibroDiarioMovimiento.IdEstatus = Convert.ToInt16(cbEstatus.EditValue);
                objLibroDiarioMovimiento.UsuarioModificacion = OperadorBD.OperadorGlobal.NombreUsuario;

            }

            catch (Exception ex)
            {
                XtraMessageBox.Show("Error en AsignarInfoMovimientoEd" + Environment.NewLine +
                       ex.Message, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            return objLibroDiarioMovimiento;
        }

        private void InicializaEstructura()
        {
            Estructura = new String[]
            {
                "FECHA",
                "TIPO DE MOVIMIENTO",
                "CHEQUE",
                "LOTE",
                "CLIENTE / PROVEEDOR",
                "FACTURA",
                "OPERADOR",
                "CONTROL",
                "ESQUEMA",
                "INGRESO",
                "EGRESO",
                "OBSERVACIONES"
            };
        }


        public frmxSaldosTesoreria()
        {
            InitializeComponent();
            InicializaEstructura();
            
            ComponentsAuto();
            // This line of code is generated by Data Source Configuration Wizard
            //stpSelMatrizTenedoraEdoCtaCmtoTableAdapter1.Fill(dbSAICBPOTesoreriaDataSet1.stpSelMatrizTenedoraEdoCtaCmto);
            this.vwCatTesConceptoTableAdapter2.Fill(this.dbSAICBPODataSet1.vwCatTesConcepto);
            this.vwCatEstatusTableAdapter1.Fill(this.dbSAICBPODataSet1.vwCatEstatus);
            this.vwTesClienteProveedorTableAdapter1.Fill(this.dbSAICBPODataSet1.vwTesClienteProveedor);

        }

        private void gridLookTenedora_EditValueChanged(object sender, EventArgs e)
        {

            int iIdMatrizTenedora = 0;
            int.TryParse(gridLookTenedoraNvo.EditValue.ToString(), out iIdMatrizTenedora);
            stpSelCtaBcoMatrizTenedoraTableAdapter.Fill(dbSAICBPOTesoreriaDataSet.stpSelCtaBcoMatrizTenedora, iIdMatrizTenedora);

        }

        private void cboTenedoraEditar_EditValueChanged(object sender, EventArgs e)
        {
            int iIdMatrizTenedora = 0;
            int.TryParse(cboTenedoraEditar.EditValue.ToString(), out iIdMatrizTenedora);
            stpSelCtaBcoMatrizTenedoraTableAdapter.Fill(dbSAICBPOTesoreriaDataSet.stpSelCtaBcoMatrizTenedora, iIdMatrizTenedora);
        }



        private void frmxEstadosdeCuenta_Load(object sender, EventArgs e)
        {
            try
            {

            // TODO: esta línea de código carga datos en la tabla 'dbSAICBPOTesoreriaDataSet.TesSaldosConceptoDiaMes' Puede moverla o quitarla según sea necesario.
            this.tesSaldosConceptoDiaMesTableAdapter.Fill(this.dbSAICBPOTesoreriaDataSet.TesSaldosConceptoDiaMes);
            // TODO: esta línea de código carga datos en la tabla 'dbSAICBPOTesoreriaDataSet.TesSaldosLTD' Puede moverla o quitarla según sea necesario.
            this.tesSaldosLTDTableAdapter.Fill(this.dbSAICBPOTesoreriaDataSet.TesSaldosLTD);
            // TODO: esta línea de código carga datos en la tabla 'dbSAICBPOTesoreriaDataSet.stpSelEsquema' Puede moverla o quitarla según sea necesario.
            this.stpSelEsquemaTableAdapter.Fill(this.dbSAICBPOTesoreriaDataSet.stpSelEsquema);
            // TODO: esta línea de código carga datos en la tabla 'dbSAICBPOTesoreriaDataSet.stpSelMatrizTenedoraEdoCta' Puede moverla o quitarla según sea necesario.
            this.stpSelMatrizTenedoraEdoCtaTableAdapter.Fill(this.dbSAICBPOTesoreriaDataSet.stpSelMatrizTenedoraEdoCta,1);
            //gdEdicion.Location = new Point(1, 1);

                this.stpSelMesTableAdapter1.Fill(this.dbSAICBPODataSet1.stpSelMes);
                cboMesCorte.EditValue = DateTime.Now.Month;
                spAnoCorte.Value = DateTime.Now.Year;    //asignar año actual
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void glEsquemaNvo_EditValueChanged(object sender, EventArgs e)
        {
            string sIdEsquema = "";
            sIdEsquema = glEsquemaNvo.EditValue.ToString();
            stpSelEsquemaTableAdapter.Fill(dbSAICBPOTesoreriaDataSet.stpSelEsquema);
        }

        private void CopyDataTable(DataTable table)
        {
            dtValidado = table.Copy();
        }

        private Boolean validaDatosLayOut(DataTable dtArchivoExcel, string NombreArchivo, String NombreHoja)
        {
            DataRow row1 = null;
            int Fila = 1;
            String sres = string.Empty;
            string pErrores = "Error al cargar el archivo \n ";
            
            try
            {
                splashScreenManager1.ShowWaitForm();
                
                if (dtArchivoExcel.Rows.Count > 2)
                {
                    for (int i = 0; i < dtArchivoExcel.Rows.Count; i++)
                    {
                        row1 = dtArchivoExcel.Rows[i];

                        Fila = Fila + i;

                        decimal dcEgreso = 0;
                        decimal dcIngreso = 0;
                        decimal.TryParse(row1[9].ToString(), out dcIngreso);
                        decimal.TryParse(row1[10].ToString(), out dcEgreso);

                        this.respuestasTesoreria.stpTesValSaldosIniDetails(
                            Convert.ToDateTime(row1[0].ToString())
                            , row1[1].ToString()
                            , row1[2].ToString()
                            , row1[3].ToString()
                            , row1[4].ToString()
                            , row1[5].ToString()
                            , row1[6].ToString()
                            , row1[7].ToString()
                            , row1[8].ToString()
                            , dcIngreso
                            , dcEgreso
                            , row1[11].ToString()
                            , ref sres);


                        if (sres != "Ok")
                        {
                            //Todo ok
                            pErrores = pErrores + " FILA:" + (i + 2).ToString() + " " + sres + " \n ";
                        }

                    }
                    splashScreenManager1.CloseWaitForm();
                    if (pErrores != "" && pErrores != "Error al cargar el archivo \n ")
                    {
                        XtraMessageBox.Show(pErrores, "Aviso. Archivo: " + Environment.NewLine +
                           NombreArchivo + "Hoja" + NombreHoja + "No contiene registros a procesar.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                        
                    }
                    else
                    {
                        XtraMessageBox.Show("La hoja se cargó correctamente", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                }
                else
                {
                    XtraMessageBox.Show("Error al validar los datos del archivo" + Environment.NewLine +
                           NombreArchivo + "Hoja" + NombreHoja + "No contiene registros a procesar.", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                
            }
            
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error al validar los datos del archivo" + Environment.NewLine +
                       ex.Message, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                splashScreenManager1.CloseWaitForm();
                return false;
            }
        }

        private Boolean validaEstructuraLayOut(DataTable dtArchivoExcel, string NombreArchivo, String NombreHoja)
        {
            int Error = 0;

            try
            {
                splashScreenManager1.ShowWaitForm();

                if (dtArchivoExcel.Rows.Count > 2)
                {
                    for (int i = 0; i < dtArchivoExcel.Columns.Count; i++)
                    {
                        if (Estructura[i] != dtArchivoExcel.Columns[i].Caption)
                        {
                            XtraMessageBox.Show("Error al guardar validar la estructura del archivo, corregir los nombres de los encabezados. " + Environment.NewLine + ""
                             , "En el nombre del campo: -" + dtArchivoExcel.Columns[i].Caption + "- diferente -" + Estructura[i] + "-", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Error = Error + 1;
                        }
                    }
                }
                
                else
                { Error = Error + 1; }
                if (Error == 0)
                {
                    splashScreenManager1.CloseWaitForm();
                    return true;
                }
                else
                {
                    XtraMessageBox.Show("Error al validar la estructura del archivo: " + NombreArchivo + Environment.NewLine +
                    "Revise la hoja a procesar. " + NombreHoja, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    splashScreenManager1.CloseWaitForm();
                    return false;

                }
            }

            catch (Exception ex)
            {
                XtraMessageBox.Show("Error al validar la estructura del archivo: " + Environment.NewLine
                        + NombreArchivo + " hoja: " + NombreHoja + ex.Message, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                splashScreenManager1.CloseWaitForm();
                return false;
            }

        }

        private void rdbNuevo_CheckedChanged(object sender, EventArgs e)
        {
            chkActSaldos.Checked = false;
            if (rdbNuevo.Checked)
            {
                gpoSeleccionNvo.Visible = true;
                gpoSeleccionCmoss.Visible = false;
                chkActSaldos.Visible = false;
            }
            else
            {
                gpoSeleccionNvo.Visible = false;
                gpoSeleccionCmoss.Visible = true;
                gpoSeleccionCmoss.Width = 506;
                gpoSeleccionCmoss.Height = 125;
                gpoSeleccionCmoss.Location = new Point(152, 33);
                chkActSaldos.Visible = true;

            }
        }


        private void gridLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            DataRow unRow = gridView3.GetDataRow(gridView3.FocusedRowHandle);

            txtIdMatrizTenedoraCmos.Text = unRow["IdMatrizTenedora"].ToString();
            TxtCuentaBancoCmto.Text = unRow["NombreCuentaBanco"].ToString();

            txtTenedoraCuestasCmos.Text = unRow["IdCuentaBanco"].ToString();
            dateSaldoCmtos.Text = unRow["FechaSaldoInicial"].ToString();
            spinSaldoInicialCmto.Text = unRow["SaldoInicial"].ToString();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdbNuevo.Checked)
                {
                    if (gridLookTenedoraNvo.Text.Trim() == "")
                    { XtraMessageBox.Show("Seleccione la matriz tenedora.", "Complete la información.", MessageBoxButtons.OK, MessageBoxIcon.Error);}
                    else
                    {
                        if (gridLookTenedoraCuentasNvo.Text.Trim() == "")
                        { XtraMessageBox.Show("Seleccione la cuenta de banco.", "Complete la información.", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                        else
                        {
                            if (glEsquemaNvo.Text.Trim() == "")
                            { XtraMessageBox.Show("Seleccione el esquema indicado.", "Complete la información.", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                            else
                            {

                                if (spinSaldoInicialNvo.Text.Trim() == "0")
                                { XtraMessageBox.Show("El monto del saldo inicial no puede ser cero.", "Complete la información.", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                                else
                                {
                                    if (Validator.IsPresent(gridLookTenedoraNvo) &&
                                    Validator.IsPresent(gridLookTenedoraCuentasNvo) &&
                                    Validator.IsPresent(glEsquemaNvo) &&
                                    Validator.IsPresent(dateSaldoNvo) &&
                                    Validator.IsPositiveOrZeroNumber(spinSaldoInicialNvo))
                                    {
                                        InfoEstadoCuentaSaldos objEstadoCuentaSaldos = AsignarInfoEmpresaSaldoNvo();
                                        string pOk = "";
                                        string TipoAct = "1";
                                        if (objEstadoCuentaSaldos != null)
                                        {
                                            
                                            this.respuestasTesoreria.stpTesInsUpdHeaderEdoCta(1, objEstadoCuentaSaldos.IdMatrizTenedora
                                                                                                , objEstadoCuentaSaldos.IdCuentaBanco
                                                                                                , objEstadoCuentaSaldos.IdEsquema
                                                                                                , objEstadoCuentaSaldos.Consecutivo
                                                                                                , objEstadoCuentaSaldos.FechaSaldoInicial
                                                                                                , objEstadoCuentaSaldos.IdConcepto
                                                                                                , objEstadoCuentaSaldos.Cheque
                                                                                                , objEstadoCuentaSaldos.Lote
                                                                                                , objEstadoCuentaSaldos.ClienteProveedor
                                                                                                , objEstadoCuentaSaldos.Factura
                                                                                                , objEstadoCuentaSaldos.Control
                                                                                                , objEstadoCuentaSaldos.SaldoInicial
                                                                                                , objEstadoCuentaSaldos.Observaciones
                                                                                                , objEstadoCuentaSaldos.IdOperador
                                                                                                , objEstadoCuentaSaldos.NombreArchivo
                                                                                                , objEstadoCuentaSaldos.NombreHoja
                                                                                                , OperadorBD.OperadorGlobal.NombreUsuario
                                                                                                , objEstadoCuentaSaldos.FechaRegistro
                                                                                                , objEstadoCuentaSaldos.Ingreso
                                                                                                , objEstadoCuentaSaldos.Egreso
                                                                                                , objEstadoCuentaSaldos.Observaciones
                                                                                                , objEstadoCuentaSaldos.IdEstatus
                                                                                                , objEstadoCuentaSaldos.UsuarioModificacion
                                                                                                ,ref pOk);
                                        }

                                        if (pOk == "Ok")
                                        {
                                            XtraMessageBox.Show("¡Los datosde la Empresa - Cta Bancaria y saldo, Han sido guardadas exitosamente!", "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            LimpiarControlesSaldoInicial();
                                        }

                                        //AlmacenaDetalleCtas(dtValidado, TipoAct);
                                        else if (pOk.ToString().Trim() != "Ok" || pOk.ToString().Trim() != "")
                                        {
                                            XtraMessageBox.Show(pOk.ToString(), "Saldo inicial no agregado.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                        else if (pOk.ToString().Trim() == "")
                                        {
                                            XtraMessageBox.Show("El saldo inicial no fue agregado.", "Consulte con el administrador.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                }
                            }

                        }
                    }
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error al almacenar el detalle de cuentas del archivo excel: " + Environment.NewLine
                        + ex, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        /// <summary>
        /// Edicion /////////////////
        /// </summary>
        /// 

        private void grMovimientos_DoubleClick(object sender, EventArgs e)

        {
            try
            {
            
               LimpiarControlesMovimiento();

               DataRow row = grMovimientos.GetDataRow(grMovimientos.FocusedRowHandle);
  
                txtIdEd.Text = row["Id"].ToString();
                txtConsEd.Text = row["CONSECUTIVO"].ToString();
                dtFechaEd.Text = row["FECHA"].ToString();
                cbConcepEd.EditValue = row["IdConcepto"].ToString();
                txtChequeEd.Text = row["CHEQUE"].ToString().TrimEnd();
                txtLoteEd.Text = row["LOTE"].ToString().TrimEnd();
                cbCteProvEd.Text = row["CLIENTE / PROVEEDOR"].ToString();
                TxtFacturaEd.Text = row["FACTURA"].ToString().TrimEnd();
                txtControlEd.Text = row["CONTROL"].ToString().TrimEnd();
                spiIngresoEd.Text = row["INGRESO"].ToString();
                spiEgresoEd.Text = row["EGRESO"].ToString();
                cbEstatus.Text = row["IdEstatus"].ToString();
                txtObservacionesEd.Text = row["OBSERVACIONES"].ToString().TrimEnd();

                ActivarControles(true);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Error al cargar los datos del movimiento: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void btnConsultarEdicion_Click(object sender, EventArgs e)
        {
            int lIdCuentaBanco = 0;
            int lIdMatrizTenedora = 0;
            //Int32 IdTenedora = 0;
            string Banco = "";
            try
            {

                lIdCuentaBanco = Convert.ToInt16(cboBancoEditar.EditValue); 
                lIdMatrizTenedora = Convert.ToInt16(cboTenedoraEditar.EditValue); 
                this.stpSelTenedoraLibroDiarioTableAdapter1.Fill(dbSAICBPOTesoreriaDataSet.stpSelTenedoraLibroDiario, lIdMatrizTenedora, lIdCuentaBanco);
                XtraMessageBox.Show("Registros de la consulta " + dbSAICBPOTesoreriaDataSet.stpSelTenedoraLibroDiario.Count, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardarEd_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult oDialogResult = XtraMessageBox.Show("Los cambios del  movimiento se actualizaran." + Environment.NewLine +
                            "¿Desea continuar?", "SAIC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (DialogResult.Yes == oDialogResult)
                {
                    if (Validator.IsPresent(cboTenedoraEditar) &&
                    Validator.IsPresent(cboBancoEditar) &&
                    //Validator.IsPresent(glEsquemaNvo) &&
                    Validator.IsPresent(dtFechaEd) &&
                    Validator.IsPositiveOrZeroNumber(spiIngresoEd) &&
                    Validator.IsPositiveOrZeroNumber(spiEgresoEd))
                    {
                        InfoEstadoCuentaSaldos objMovimientosEd = AsignarInfoMovimientoEd();
                        string pOk = "";
                        if (objMovimientosEd != null)
                        {

                            this.respuestasTesoreria.stpTesInsUpdHeaderEdoCta(2, objMovimientosEd.IdMatrizTenedora
                                                                                , objMovimientosEd.IdCuentaBanco
                                                                                , objMovimientosEd.IdEsquema
                                                                                , objMovimientosEd.Consecutivo.TrimEnd()
                                                                                , objMovimientosEd.FechaSaldoInicial
                                                                                , objMovimientosEd.IdConcepto
                                                                                , objMovimientosEd.Cheque.TrimEnd()
                                                                                , objMovimientosEd.Lote.TrimEnd()
                                                                                , objMovimientosEd.ClienteProveedor
                                                                                , objMovimientosEd.Factura.TrimEnd()
                                                                                , objMovimientosEd.Control.TrimEnd()
                                                                                , objMovimientosEd.SaldoInicial
                                                                                , objMovimientosEd.Observaciones
                                                                                , objMovimientosEd.IdOperador
                                                                                , objMovimientosEd.NombreArchivo
                                                                                , objMovimientosEd.NombreHoja
                                                                                , OperadorBD.OperadorGlobal.NombreUsuario
                                                                                , objMovimientosEd.FechaRegistro
                                                                                , objMovimientosEd.Ingreso
                                                                                , objMovimientosEd.Egreso
                                                                                , objMovimientosEd.Observaciones.TrimEnd()
                                                                                , objMovimientosEd.IdEstatus
                                                                                , objMovimientosEd.UsuarioModificacion
                                                                                , ref pOk);
                        }

                        if (pOk == "Ok")
                        {

                            XtraMessageBox.Show("¡Los datosde del movimiento han sido guardados exitosamente!", "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (pOk.ToString().Trim() != "Ok" || pOk.ToString().Trim() != "")
                        {
                            XtraMessageBox.Show(pOk.ToString(), "La información no se actualizó.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error al actualizar el movimiento de cuentas del archivo excel: " + Environment.NewLine
                        + ex, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                LimpiarControlesMovimiento();
                ActivarControles(false);

                btnConsultarEdicion_Click(null,null);
            }
            
        }

        private void ActivarControles(bool bFlag)
        {
            if (bFlag)
                { mainColor = Color.White; }
                else
                { mainColor = Color.LightGoldenrodYellow; }

            dtFechaEd.Enabled = bFlag;
            cbConcepEd.Enabled = bFlag;
            txtChequeEd.Enabled = bFlag;
            txtLoteEd.Enabled = bFlag;
            cbCteProvEd.Enabled = bFlag;
            TxtFacturaEd.Enabled = bFlag;
            txtControlEd.Enabled = bFlag;

            spiIngresoEd.Enabled = bFlag;
            spiEgresoEd.Enabled = bFlag;

            cbEstatus.Enabled = bFlag;
            txtObservacionesEd.Enabled = bFlag;
            btnGuardarEd.Enabled = bFlag;

            dtFechaEd.BackColor = mainColor;
            cbConcepEd.BackColor = mainColor;
            txtChequeEd.BackColor = mainColor;
            txtLoteEd.BackColor = mainColor;
            cbCteProvEd.BackColor = mainColor;
            TxtFacturaEd.BackColor = mainColor;
            txtControlEd.BackColor = mainColor;

            spiIngresoEd.BackColor = mainColor;
            spiEgresoEd.BackColor = mainColor;

            cbEstatus.BackColor = mainColor;
            txtObservacionesEd.BackColor = mainColor;
            btnGuardarEd.BackColor = mainColor;

        }

        private void LimpiarControlesSaldoInicial()
        {
            gridLookTenedoraNvo.EditValue = 0;
            gridLookTenedoraCuentasNvo.EditValue = 0;
            glEsquemaNvo.EditValue = 0;
            dateSaldoNvo.EditValue = DateTime.Now;
            spinSaldoInicialNvo.Text = "0";
        }
        private void LimpiarControlesMovimiento()
        {
            txtIdEd.Text = String.Empty;
            txtConsEd.Text = String.Empty;
            dtFechaEd.Text = String.Empty;
            cbConcepEd.EditValue = 0;
            txtChequeEd.Text = String.Empty;
            txtLoteEd.Text = String.Empty;
            cbCteProvEd.Text = String.Empty;
            TxtFacturaEd.Text = String.Empty;
            txtControlEd.Text = String.Empty;
            spiIngresoEd.Text = "0";
            spiEgresoEd.Text = "0";
            cbEstatus.EditValue = 0;
            txtObservacionesEd.Text = String.Empty;
        }

        private void ComponentsAuto()
        {
            try
            {

                splitContainer1.SplitterDistance = 100;
                splitContainer1.Panel2.Size = new System.Drawing.Size(100, 700);

                splitContainer2.SplitterDistance = 350;
            }

            catch (Exception ex)
            {
                XtraMessageBox.Show("Error al realizar el ajuste de la pantalla: " + Environment.NewLine
                        + ex, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void tabPane1_Click(object sender, EventArgs e)
        {

            if (tabPane1.SelectedPage.Caption == "Carga saldos iniciales")
            {
                this.stpSelMatrizTenedoraEdoCtaTableAdapter.Fill(this.dbSAICBPOTesoreriaDataSet.stpSelMatrizTenedoraEdoCta, 1);
            }

            if (tabPane1.SelectedPage.Caption == "Editar")
            {
                this.stpSelMatrizTenedoraEdoCtaTableAdapter.Fill(this.dbSAICBPOTesoreriaDataSet.stpSelMatrizTenedoraEdoCta, 2);
            }
        }


        private void tabPane1_SelectedPageChanged(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs e)
        {
            if (tabPane1.SelectedPage.Caption == "Carga saldos iniciales" )
            {
                this.stpSelMatrizTenedoraEdoCtaTableAdapter.Fill(this.dbSAICBPOTesoreriaDataSet.stpSelMatrizTenedoraEdoCta, 1);
            }

            if (tabPane1.SelectedPage.Caption == "Editar" || tabPane1.SelectedPage.Caption == "Línea del tiempo")
            {
                this.stpSelMatrizTenedoraEdoCtaTableAdapter.Fill(this.dbSAICBPOTesoreriaDataSet.stpSelMatrizTenedoraEdoCta, 2);
            }
        }



        /// <summary>
        /// Consulta Linea de Tiempo /////////////////
        /// </summary>

        private Boolean validaFechas()
        {
            
            try
            {
                string strError = string.Empty;
                //return false;
                /* ---------------------------------------Movimientos----------------------------------------- */
                if (cboMesCorte.Text.Length == 0)
                { strError += "\t >Mes de Pago" + "\n"; }

                if (spAnoCorte.Text.Length != 4)
                { strError += "\t >Año de Pago" + "\n"; }

                if (strError.Length > 0)
                    {
                    XtraMessageBox.Show("Falta esta información: \n" + strError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                    }
                else
                    return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
            

        }
        private void btnConsultaLT_Click_1(object sender, EventArgs e)
        {
                if (validaFechas() == true)
                {
                    int lIdMatrizTenedora = 0;
                    if (chkSelTenedoras.Checked == false)
                    {
                        lIdMatrizTenedora = Convert.ToInt16(cmbTenedoraLT.EditValue);
                    }

                    DateTime dFechaCorte = new DateTime(Convert.ToInt16(spAnoCorte.EditValue), Convert.ToInt16(cboMesCorte.EditValue), 01);

                    CargaLineaTiempo(dFechaCorte, lIdMatrizTenedora);
                    CargaSaldosBancarios(dFechaCorte);
                    CargaSaldosBancariosxDia(dFechaCorte);

                }
        }

        private void CargaLineaTiempo(DateTime dFechaCorte, int lIdMatrizTenedora)
        {
            try
            {
                this.stpSelTenedoraLineaTiempovTableAdapter1.Fill(dbSAICBPOTesoreriaDataSet.stpSelTenedoraLineaTiempov, lIdMatrizTenedora, Convert.ToDateTime(dFechaCorte.ToString("yyyy/MM/dd")), Convert.ToDateTime(dFechaCorte.ToString("yyyy/MM/dd")));
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error al realizar la consulta de movimientos: " + Environment.NewLine
                        + ex, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

            /* -----------------------------------------Saldos Bancarios--------------------------------------- */
        private void CargaSaldosBancarios(DateTime dFechaCorte)
        {
            try
            {
            this.stpSelSaldosBancariosFinalTableAdapter2.Fill(dbSAICBPOTesoreriaDataSet.stpSelSaldosBancariosFinal, Convert.ToDateTime(dFechaCorte.ToString("yyyy/MM/dd")));
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error al realizar la consulta de saldos bancarios: " + Environment.NewLine
                        + ex, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargaSaldosBancariosxDia(DateTime dFechaCorte)
        {
            try
            {
            /* ------------------------------------------Saldos Bancarios Dia-------------------------------------- */
                this.stpSelSaldosBancariosAlCierreXDiaTableAdapter1.Fill(this.dbSAICBPOTesoreriaDataSet.stpSelSaldosBancariosAlCierreXDia, Convert.ToDateTime(dFechaCorte.ToString("yyyy/MM/dd")));
            this.tesSaldosConceptoDiaMesTableAdapter.Fill(this.dbSAICBPOTesoreriaDataSet.TesSaldosConceptoDiaMes);
            gdCtrolSaldosBXDia.DataSource = ObtieneDtDinamico(dbSAICBPOTesoreriaDataSet.TesSaldosConceptoDiaMes);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error al realizar la consulta de saldos bancarios x dia: " + Environment.NewLine
                        + ex, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void chkSelTenedoras_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSelTenedoras.Checked)
                {
                cmbTenedoraLT.Visible = false;
                lblTenedoraLT.Visible = false;
                chkSelTenedoras.Text = "Todas - tenedoras";
            }
                else
                {
                cmbTenedoraLT.Visible = true;
                lblTenedoraLT.Visible = true;
                chkSelTenedoras.Text = "Seleccion - tenedora";
                this.stpSelMatrizTenedoraEdoCtaTableAdapter.Fill(this.dbSAICBPOTesoreriaDataSet.stpSelMatrizTenedoraEdoCta, 2);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabPane2_SelectedPageChanged(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs e)
        {

            if (cboMesCorte.Text != "")
                {
                DateTime dFechaCorte = new DateTime(Convert.ToInt16(spAnoCorte.EditValue), Convert.ToInt16(cboMesCorte.EditValue), 01);

                int lIdMatrizTenedora = 0;
                if (chkSelTenedoras.Checked == false)
                {
                    lIdMatrizTenedora = Convert.ToInt16(cmbTenedoraLT.EditValue);
                }
                if (gdCtrolSaldosBXDiaIngresos.SelectedPage.Caption == "Movimientos")
                {

                    CargaLineaTiempo(dFechaCorte, lIdMatrizTenedora);
                }
                    if (gdCtrolSaldosBXDiaIngresos.SelectedPage.Caption == "Saldos bancarios")
                {
                    CargaSaldosBancarios(dFechaCorte);
                }

                if (gdCtrolSaldosBXDiaIngresos.SelectedPage.Caption == "Saldos Bancarios Día")
                {
                    CargaSaldosBancariosxDia(dFechaCorte);

                }
            }
        }


        private DataTable ObtieneDtDinamicoFormat(DataTable DtOrg)
        {

            String TipoS = "String";

            DataTable dtTabla = new DataTable();


            for (int i = 0; i < DtOrg.Columns.Count-1; i++)
            {
                if (i == 0)
                {
                    dtTabla.Columns.Add(DtOrg.Columns[i].ColumnName, typeof(String));
                }
                else
                {
                    dtTabla.Columns.Add(DtOrg.Columns[i].ColumnName, typeof(Decimal));
                }
                
            }

            for (int f = 0; f < DtOrg.Rows.Count; f++)
            {
                DataRow unRow = dtTabla.NewRow();
                Decimal valor;

                for (int c = 0; c < DtOrg.Columns.Count - 1; c++)
                {
                    if (c == 0)
                    {
                        unRow[c] = DtOrg.Rows[f][c].ToString();
                    }
                    else
                    {
                        valor = decimal.Parse(DtOrg.Rows[f][c].ToString().Remove(0,1));
                        unRow[c] = valor;
                    }
                }

                dtTabla.Rows.Add(unRow);
            }
            return dtTabla;
        }
 


        private DataTable ObtieneDtDinamico(DataTable Dt)
        {

            DataTable dtTabla = new DataTable();

            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                if (i == 0)
                {
                    String[] sColumnas = Dt.Rows[i]["Data"].ToString().Split(new string[] { "[NC]" }, StringSplitOptions.None);
                    foreach (String sCol in sColumnas)
                    {
                        if (sCol != "")
                        { 
                        dtTabla.Columns.Add(sCol, typeof(string));
                        }
                    }
                }
                else
                {
                    String[] sDatos = Dt.Rows[i]["Data"].ToString().Split(new string[] { "[NC]" }, StringSplitOptions.None);
                    dtTabla = AgregarColumnas(sDatos, dtTabla);
                    DataRow unRow = dtTabla.NewRow();
                    Decimal Monto = 0.00m;

                    for (int x = 0; x < sDatos.Count(); x++)
                    {
                        if (x == 0)
                        {
                            unRow[x] = sDatos[x];
                        }
                        else
                        {
                            if (sDatos[x] == "")
                            { unRow[x] = Monto.ToString("C"); }
                                
                            else
                            {
                                Monto = Convert.ToDecimal(sDatos[x]);
                                unRow[x] = Monto.ToString("C");
                            }
                        }
                    }

                    dtTabla.Rows.Add(unRow);
                }
            }

            return dtTabla;

        }


        private DataTable AgregarColumnas(String[] sDatos, DataTable dtTabla)
        {
            if (sDatos.Count() > dtTabla.Columns.Count)
            {
                dtTabla.Columns.Add();
                AgregarColumnas(sDatos, dtTabla);
            }

            return dtTabla;
        }



        private void gdCtrolSaldosBXDiaIngresos_Click(object sender, EventArgs e)
        {

        }

        private void btnExpLineTiempo_Click_1(object sender, EventArgs e)
        {

            if (cboMesCorte.EditValue.ToString() != "")
            {
                if ((gridLineaTiempo.FocusedView as GridView).RowCount > 0)
                {
                    DateTime dFechaCorte = new DateTime(Convert.ToInt16(spAnoCorte.EditValue), Convert.ToInt16(cboMesCorte.EditValue), 01);
                    String ruta = dsc.stRutaSAICTesoreria + "Linea del tiempo " + dFechaCorte.ToString("yyyyMMdd") + "-" +  dsc.nombreAleatorio() + ".xlsx";
                    dsc.CheckandCreateFolder(dsc.stRutaSAICTesoreria);
                    gridLineaTiempo.Views.Count();

                    gridLineaTiempo.ExportToXlsx(ruta);
                    ExportaImprime(ruta);

                    //if (XtraMessageBox.Show("¿Desea abrir el archivo en Excel?", "Documento descargado: " + ruta, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    //{
                    //    Utilerias.StartProcess(ruta);
                    //}


                }
            }
        }

        private void btnExpSalBancario_Click_1(object sender, EventArgs e)
        {
            if (cboMesCorte.EditValue.ToString() != "")
            {
                if ((gridSaldosBancarios.FocusedView as GridView).RowCount > 0)
                {
                    DateTime dFechaCorte = new DateTime(Convert.ToInt16(spAnoCorte.EditValue), Convert.ToInt16(cboMesCorte.EditValue), 01);

                    String ruta = dsc.stRutaSAICTesoreria + "Saldos bancarios " + dFechaCorte.ToString("yyyyMMdd") + "-" + dsc.nombreAleatorio() + ".xlsx";

                    dsc.CheckandCreateFolder(dsc.stRutaSAICTesoreria);
                    gridSaldosBancarios.ExportToXlsx(ruta);
                    ExportaImprime(ruta);

                    //XtraMessageBox.Show("Documentos Descargados. Ruta: " + ruta, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private void btnExpSalBancarioxDia_Click(object sender, EventArgs e)
        {
            if (cboMesCorte.EditValue.ToString() != "")
            {
                if ((gdCtrolSaldosBXDia.FocusedView as GridView).RowCount > 0)
                {
                    DateTime dFechaCorte = new DateTime(Convert.ToInt16(spAnoCorte.EditValue), Convert.ToInt16(cboMesCorte.EditValue), 01);

                    String ruta = dsc.stRutaSAICTesoreria + "Saldos bancarios x día " + dFechaCorte.ToString("yyyyMMdd") + "-" + dsc.nombreAleatorio() + ".xlsx";

                    dsc.CheckandCreateFolder(dsc.stRutaSAICTesoreria);
                    gdCtrolSaldosBXDia.ExportToXlsx(ruta);
                    ExportaImprime(ruta);
                    //XtraMessageBox.Show("Documentos Descargados. Ruta: " + ruta, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                }
            }

        private void ExportaImprime(String Ruta ) 
        {

            if (XtraMessageBox.Show("¿Desea abrir el archivo en Excel?", "Documento descargado: " + Ruta, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Utilerias.StartProcess(Ruta);
            }
        }
        private void btnExpSalBancarioxDiaIng_Click(object sender, EventArgs e)
        {


        }

    private void button1_Click(object sender, EventArgs e)
        {
            gdCtrolSaldosBXDiaIng.DataSource = ObtieneDtDinamicoFormat(dtTablaDinamica);
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;  
        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void gpoSeleccionNvo_Enter(object sender, EventArgs e)
        {

        }
    }
}