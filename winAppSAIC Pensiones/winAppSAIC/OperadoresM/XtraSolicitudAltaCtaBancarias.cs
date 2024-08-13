using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Text.RegularExpressions;
using compCatalogosSAIC;

namespace winAppSAIC.OperadoresM
{
    public partial class XtraSolicitudAltaCtaBancarias : DevExpress.XtraEditors.XtraForm
    {
        //int idEmpleado;
        //String stNombreCompletoEmpleado;
        //String stClabe;
        //String stNoTarjeta;
        //String idEsquema;
        Empleado miEmpleado;
        Boolean Solicitar_Actualizar; // True: Solicituar Cambio. False: Actualizar Informacion
        int idSolicitud;

        public XtraSolicitudAltaCtaBancarias(Empleado miEmpleado, int idSolicitud, Boolean Solicitar_Actualizar)
        {
            InitializeComponent();
            this.miEmpleado = miEmpleado;
            this.Solicitar_Actualizar = Solicitar_Actualizar;
            this.idSolicitud = idSolicitud;
        }

        private void toolBtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void XtraSolicitudAltaCtaBancarias_Load(object sender, EventArgs e)
        {
            splashScreenManager2.ShowWaitForm();

            try
            {
                stpSelFormaPagoSolicitudCambioEmpleadosTableAdapter1.Fill(dbSAICBPOCatalogosDataSet.stpSelFormaPagoSolicitudCambioEmpleados);
                //stpSelObtenerInfoGenericaTenedoraSC_1TableAdapter1.Fill(dbSAICBPOCatalogosDataSet.stpSelObtenerInfoGenericaTenedoraSC_1, miEmpleado.IdMatrizTenedora, true);

                if (!Solicitar_Actualizar)
                {
                    if (miEmpleado.IdTipoMovimiento == "M" || miEmpleado.IdTipoMovimiento == "S")
                    {
                        stpSelObtenerInfoGenericaTenedoraSC_1TableAdapter1.Fill(dbSAICBPOCatalogosDataSet.stpSelObtenerInfoGenericaTenedoraSC_1, miEmpleado.IdMatrizTenedora, true);
                        upEditTenedoraSC.Enabled = true;
                    }
                    else if (miEmpleado.IdTipoMovimiento == "A")
                    {
                        stpSelObtenerInfoGenericaTenedoraSC_1TableAdapter1.Fill(dbSAICBPOCatalogosDataSet.stpSelObtenerInfoGenericaTenedoraSC_1, miEmpleado.IdMatrizTenedora, false);
                        upEditTenedoraSC.Enabled = true;
                    }
                }
                else
                {
                    upEditTenedoraSC.Enabled = false;
                }

                if (dbSAICBPOCatalogosDataSet.stpSelFormaPagoSolicitudCambioEmpleados.Count() > 0)
                {
                    cboIdFormaPago.EditValue = 4;
                    cboIdFormaPago.SelectedText = "TRANSFERENCIA";
                }

                txtIdEmpleado.Text = miEmpleado.IdEmpleado.ToString();
                txtNombreEmpleado.Text = miEmpleado.NombreEmpleado + " " + miEmpleado.APaternoEmpleado + " " + miEmpleado.AMaternoEmpleado;
                //txtCLABE.Text = miEmpleado.CLABE;
                //txtTarjeta.Text = miEmpleado.NoReferenciaEmpleadoBanco; // Numero de tarjeta Empleado NoReferenciaEmpleadoBanco = Tarjeta, como esta en la Base
                txtTenedoraSA.Text = miEmpleado.TenedoraSA;

                btnSolicitarEmpleados.Text = Solicitar_Actualizar ? "Solicitar" : "Actualizar";

                txtIdSolicitud.Text = idSolicitud.ToString();

                if (idSolicitud == 0)
                {
                    lblSolicitud.Visible = false;
                    txtIdSolicitud.Visible = false;
                }
            }
            catch (Exception ex)
            {
                if (splashScreenManager2.IsSplashFormVisible) { splashScreenManager2.CloseWaitForm(); }
                XtraMessageBox.Show("No se puede Cargar la Información." + Environment.NewLine + ex.Message
                    , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (splashScreenManager2.IsSplashFormVisible) { splashScreenManager2.CloseWaitForm(); }
        }

        private void cboIdFormaPago_EditValueChanged(object sender, EventArgs e)
        {
            erroProviderCampos.Clear();
            btnSolicitarEmpleados.Enabled = false;
            esClabe = false;
            esTarjeta = false;

            if (cboIdFormaPago.Text == "TARJETA" && miEmpleado.IdTipoMovimiento == "A")
            {
                XtraMessageBox.Show("No se puede Pedir Tarjeta con Tipo Moviento A."
           , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (cboIdFormaPago.Text == "TARJETA")
                {
                    //txtTarjeta.Enabled = true;
                    //txtTarjeta.BackColor = Color.White;
                    txtCLABE.Text = String.Empty;
                    txtBanco.Text = String.Empty;
                    txtNoCuentaBanco.Text = String.Empty;
                    validarClabeTarjeta();
                }
                else
                {
                    //txtTarjeta.Enabled = false;
                    //txtTarjeta.BackColor = Color.LightGoldenrodYellow;
                }

                if (cboIdFormaPago.Text == "TRANSFERENCIA")
                {
                    txtCLABE.Enabled = true;
                    txtCLABE.BackColor = Color.White;
                    //txtTarjeta.Text = String.Empty;
                    validarClabeInterbancaria();
                }
                else
                {
                    txtCLABE.Enabled = false;
                    txtCLABE.BackColor = Color.LightGoldenrodYellow;

                }
            }

            //txtTarjeta.Enabled = cboIdFormaPago.Text == "TARJETA" ? true : false;
            //txtTarjeta.BackColor = cboIdFormaPago.Text == "TARJETA" ? Color.White : Color.LightGoldenrodYellow;

            //txtCLABE.Enabled = cboIdFormaPago.Text == "TRANSFERENCIA" ? true : false;
            //txtCLABE.BackColor = cboIdFormaPago.Text == "TRANSFERENCIA" ? Color.White : Color.LightGoldenrodYellow;
        }


        Boolean esClabe = false;
        Boolean esTarjeta = false;

        ErrorProvider erroProviderCampos = new ErrorProvider();

        private void txtCLABE_EditValueChanged(object sender, EventArgs e)
        {
            lblLenClabe.Text = txtCLABE.Text.Count().ToString();
            validarClabeInterbancaria();
        }
        private void txtTarjeta_EditValueChanged(object sender, EventArgs e)
        {
            //lblLenTarjeta.Text = txtTarjeta.Text.Length.ToString();
            validarClabeTarjeta();
        }

        private void habilitarSolicitud()
        {
            if (cboIdFormaPago.Text == "TRANSFERENCIA" && esClabe)
            {
                btnSolicitarEmpleados.Enabled = true;
            }
            else if (cboIdFormaPago.Text == "TARJETA" && esTarjeta)
            {
                btnSolicitarEmpleados.Enabled = true;
            }
            else
            {
                btnSolicitarEmpleados.Enabled = false;
            }
        }

        private void validarClabeTarjeta()
        {
            //if (txtTarjeta.Text.Length > 5 && cboIdFormaPago.Text == "TARJETA")
            //{
            //    String stTarjeta = String.Empty;
            //    String reg = "^[0-9]{16}$";
            //    Regex regex = new Regex(reg);
            //    if (regex.IsMatch(txtTarjeta.Text))
            //    {
            //        erroProviderCampos.Clear();
            //        esTarjeta = true;
            //    }
            //    else
            //    {
            //        esTarjeta = false;
            //        erroProviderCampos.Icon = Properties.Resources.warning1;
            //        //erroProviderCampos.SetError(txtTarjeta, "La Tarjeta Ingresada no es Valida");
            //        erroProviderCampos.SetError(lblLenTarjeta, "La Tarjeta Ingresada no es Valida");
            //    }
            //}
            habilitarSolicitud();
        }


        private void validarClabeInterbancaria()
        {
            String stClabeInterbancaria = String.Empty;
            stClabeInterbancaria = txtCLABE.Text.Replace(" ", "").Replace("_", "");
            if (stClabeInterbancaria.Length > 2)
            {
                txtBanco.Text = queriesTableAdapter1.ClaveBanco(stClabeInterbancaria.Substring(0, 3));
            }
            if (stClabeInterbancaria.Length > 16)
            {
                var miCuenta = queriesTableAdapter1.CuentaClabe(stClabeInterbancaria.Substring(0, 3), stClabeInterbancaria);
                txtNoCuentaBanco.Text = miCuenta.ToString();
            }

            if (cboIdFormaPago.Text == "TRANSFERENCIA")
            {
                if (stClabeInterbancaria.Length == 18)
                {
                    var varEsClabe = queriesTableAdapter1.ValidarClabe(stClabeInterbancaria);
                    Boolean.TryParse(varEsClabe.ToString(), out esClabe);
                    //esClabe = queriesTableAdapter1.ValidarClabe(txtClabe.Text);
                    if (esClabe == false)
                    {
                        erroProviderCampos.Icon = Properties.Resources.warning1;
                        //erroProviderCampos.SetError(txtCLABE, "La Clabe Ingresada no es Valida");
                        erroProviderCampos.SetError(lblLenClabe, "La Clabe Ingresada no es Valida");
                        esClabe = false;
                    }
                    else
                    {
                        //Validar si la Cuenta solicitada es la misma que se tiene ya el empleado.
                        //validar si es la Clabe Generica
                        Boolean flagMismaClabeEmpleado = false;
                        if (stClabeInterbancaria.Substring(3, 3) == "000" && stClabeInterbancaria.Substring(17, 1) == "0")
                        {
                            if (miEmpleado.CLABE == txtNoCuentaBanco.Text)
                            {
                                flagMismaClabeEmpleado = true;
                            }
                        }
                        else
                        {
                            if (miEmpleado.CLABE == stClabeInterbancaria)
                            {
                                flagMismaClabeEmpleado = true;
                            }
                        }

                        if (flagMismaClabeEmpleado)
                        {
                            erroProviderCampos.Icon = Properties.Resources.warning1;
                            //erroProviderCampos.SetError(txtCLABE, "La Clabe Ingresada no es Valida");
                            erroProviderCampos.SetError(lblLenClabe, "No se puede Solicitar la misma Clabe para el Empleado.");
                            esClabe = false;
                        }
                        else
                        {
                            erroProviderCampos.Clear();
                            esClabe = true;
                        }
                    }
                }
                else
                {
                    erroProviderCampos.Icon = Properties.Resources.warning1;
                    erroProviderCampos.SetError(lblLenClabe, "la Clabe es muy Corta, No es Valida");
                    esClabe = false;
                }
            }

            habilitarSolicitud();
        }

        private void labelControl6_Click(object sender, EventArgs e)
        {

        }

        private void txtNoCuentaBanco_EditValueChanged(object sender, EventArgs e)
        {
            lblLenCuenta.Text = txtNoCuentaBanco.Text.Length.ToString();
        }

        private void btnSolicitarEmpleados_Click(object sender, EventArgs e)
        {
            String stmensaje = String.Empty;

            if (Solicitar_Actualizar)
            {
                stmensaje = "¿Esta seguro de actualizar la informacion a " +
              (cboIdFormaPago.Text == "TRANSFERENCIA" ? "de la Clabe " + txtCLABE.Text : "de " + cboIdFormaPago.Text) +
              ", para " + txtNombreEmpleado.Text + "? ";
            }
            else
            {
                stmensaje = "¿Esta seguro de Solicitar el Alta " +
                (cboIdFormaPago.Text == "TRANSFERENCIA" ? "de la Clabe " + txtCLABE.Text : "de " + cboIdFormaPago.Text) +
                ", para " + txtNombreEmpleado.Text + "? ";
            }

            DialogResult drResultado = XtraMessageBox.Show(stmensaje
                 , "SAIC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult.Yes == drResultado)
            {
                try
                {
                    if (Solicitar_Actualizar)
                    {
                        queriesTableAdapter1.stpUpdSolicitudAltaCuentaDetail(idSolicitud, miEmpleado.IdEmpleado, txtCLABE.Text, OperadorBD.OperadorGlobal.IdOperador);
                        XtraMessageBox.Show(Environment.NewLine + "Actualización con Exito." + Environment.NewLine + Environment.NewLine +
                               "Numero de Solicitud: " + idSolicitud + Environment.NewLine
                           , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        int? iSolicitud = 0;
                        int idTenedoraSC = 0;
                        String stMensaje = String.Empty;

                        //int.TryParse(upEditTenedoraSC.EditValue.ToString(), out idTenedoraSC);
                        idTenedoraSC = 0;
                        queriesTableAdapter1.stpInsSolicitudAltaEmpleadosHeader(
                        Convert.ToInt32(miEmpleado.IdTenedoraSA),
                        idTenedoraSC,
                        Convert.ToInt32(miEmpleado.IdCliente),
                        OperadorBD.OperadorGlobal.IdOperador,
                        OperadorBD.OperadorGlobal.NombreUsuario,
                        3, // Solicid de Alta de Cuentas
                        ref iSolicitud
                       );

                        if (iSolicitud > 0)
                        {
                            queriesTableAdapter1.stpInsSolicitudAltaCuentaDetail(iSolicitud, miEmpleado.IdEmpleado, miEmpleado.IdTenedoraSA, idTenedoraSC, txtCLABE.Text, OperadorBD.OperadorGlobal.IdOperador, stMensaje);
                            XtraMessageBox.Show(Environment.NewLine + "Solicitud Generada con Exito" + Environment.NewLine + Environment.NewLine +
                                  "Numero de Solicitud: " + iSolicitud + Environment.NewLine
                              , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            XtraMessageBox.Show("No se Genero la Solicud, Por favor vuelva a intentarlo."
                            , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show((Solicitar_Actualizar ? "No se puedo Solicitar Alta de Cuenta." : "No se puedo Actualizar la Cuenta.") + Environment.NewLine + ex.Message, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}