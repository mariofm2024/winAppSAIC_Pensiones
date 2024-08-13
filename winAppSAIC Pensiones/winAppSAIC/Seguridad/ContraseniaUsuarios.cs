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
using System.Net.Mail;
using System.Net;
using compEmail;

namespace winAppSAIC.Seguridad
{
    public partial class ContraseniaUsuarios : DevExpress.XtraEditors.XtraForm
    {
        public Boolean flagTaMuyBien = false;
        ErrorProvider erroProviderContrasenia = new ErrorProvider();
        ErrorProvider erroProviderRepetirContrasenia = new ErrorProvider();
        Boolean flagValidarContrasenia = false;
        Boolean flagValidarRepetirContrasenia = false;
        int iDiasVigencia = 40;
        DateTime dFechaHoy = new DateTime();

        String stvalorRegEx = String.Empty;
        tools.dsc dsc = new tools.dsc();

        private ConfiguracionNotificacion objConfigCorreo;

        public ContraseniaUsuarios()
        {
            InitializeComponent();
        }

        private void ContraseniaUsuarios_Load(object sender, EventArgs e)
        {
            stpSelParametroRegExTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelParametroRegEx, "CONTRASENIAUSUARIOS");
            if (dbSAICBPOCatalogosDataSet1.stpSelParametroRegEx.Rows.Count > 0)
            {
                stvalorRegEx = dbSAICBPOCatalogosDataSet1.stpSelParametroRegEx.Rows[0]["ValorParametro"].ToString();
            }
            else
            {
                XtraMessageBox.Show("Sin validacion de contraseña."
                           , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNuevaContraseña.Enabled = false;
                txtRepetirContraseña.Enabled = false;

            }

            stpSelParametro_1TableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelParametro_1, "CONTRASENIAUSUARIO_VIGENCIA");
            if (dbSAICBPOCatalogosDataSet1.stpSelParametro_1.Rows.Count > 0)
            {
                if (int.TryParse(dbSAICBPOCatalogosDataSet1.stpSelParametro_1.Rows[0]["ValorParametro"].ToString(), out iDiasVigencia))
                {
                    int.TryParse(dbSAICBPOCatalogosDataSet1.stpSelParametro_1.Rows[0]["ValorParametro"].ToString(), out iDiasVigencia);
                }
            }

            DateTime.TryParse(stpSelEstatusNominaContabilizadaTableAdapter1.ObtenerFechaServidor().ToString(), out dFechaHoy);
            txtfechaVigencia.Text = dFechaHoy.AddDays((iDiasVigencia - 1)).ToShortDateString();

            lblDias.Text = iDiasVigencia + (iDiasVigencia == 1 ? " Dia" : " Dias");

            txtNombre.Text = OperadorBD.OperadorGlobal.NombreOperador;
            txtUsuario.Text = OperadorBD.OperadorGlobal.NombreUsuario;
            txtCorreo.Text = OperadorBD.OperadorGlobal.CorreoElectronico;
            txtNuevaContraseña.Text = String.Empty;
            txtRepetirContraseña.Text = String.Empty;
        }

        private void txtNuevaContraseña_EditValueChanged(object sender, EventArgs e)
        {
            if (!dsc.validarCURP(txtNuevaContraseña.Text, stvalorRegEx))
            {
                erroProviderContrasenia.Icon = Properties.Resources.error_16;
                erroProviderContrasenia.SetError(txtNuevaContraseña, "Contraseña invalida");
                btnCambiar.Enabled = false;
                flagValidarContrasenia = false;
            }
            else
            {
                erroProviderContrasenia.Clear();
                erroProviderContrasenia.SetError(txtNuevaContraseña, String.Empty);
                flagValidarContrasenia = true;

                if (flagValidarContrasenia && flagValidarRepetirContrasenia)
                {
                    btnCambiar.Enabled = true;
                }
                else
                {
                    btnCambiar.Enabled = false;
                }

            }
        }


        private void txtRepetirContraseña_EditValueChanged(object sender, EventArgs e)
        {
            if (txtRepetirContraseña.Text.Length > 0)
            {
                if (txtNuevaContraseña.Text != txtRepetirContraseña.Text)
                {
                    erroProviderRepetirContrasenia.Icon = Properties.Resources.error_16;
                    erroProviderRepetirContrasenia.SetError(txtRepetirContraseña, "Contraseña invalida");
                    btnCambiar.Enabled = false;
                    flagValidarRepetirContrasenia = false;
                }
                else
                {
                    erroProviderRepetirContrasenia.Clear();
                    erroProviderRepetirContrasenia.SetError(txtNuevaContraseña, String.Empty);
                    flagValidarRepetirContrasenia = true;

                    if (flagValidarContrasenia && flagValidarRepetirContrasenia)
                    {
                        btnCambiar.Enabled = true;
                    }
                    else
                    {
                        btnCambiar.Enabled = false;
                    }
                }
            }
            else
            {
                flagValidarRepetirContrasenia = false;
            }
        }
        private void btnCambiar_Click(object sender, EventArgs e)
        {
            String stTipoEncriptacion = String.Empty;
            String stNuevaContrasenia = String.Empty;
            stTipoEncriptacion = this.validacionesGeneralTableAdapter1.ObtenerValorParametro("ENCRIPCION").ToString();
            if (stTipoEncriptacion == "TDES")
            {
                stNuevaContrasenia = CryptorEngine.Encrypt(txtNuevaContraseña.Text.Trim(), true);
            }
            else
            {
                frmxUsuarios ofrmxUsuarios = new frmxUsuarios();
                stNuevaContrasenia = ofrmxUsuarios.AES_Encryption(txtNuevaContraseña.Text.Trim());
            }

            if (stNuevaContrasenia != OperadorBD.OperadorGlobal.Contrasena)
            {
                int? iResultado = 0;
                queriesTableAdapter1.stpUpdContraseniaOperador(OperadorBD.OperadorGlobal.IdOperador, OperadorBD.OperadorGlobal.NombreUsuario, stNuevaContrasenia, ref iResultado);
                if (iResultado == 1)
                {
                    XtraMessageBox.Show("Contraseña actualizada"
                                   , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    flagTaMuyBien = true;

                    enviandoNotificacion();

                    this.Close();
                }
                else
                {
                    XtraMessageBox.Show("Contraseña NO actualizada"
                                  , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                XtraMessageBox.Show("la contraseña no puede ser igual a la actual"
                          , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }


        private void enviandoNotificacion()
        {
            try
            {
                DataTable dt = this.stpSelCorreosNotificacionTableAdapter1.GetData();
                objConfigCorreo = ConfiguracionNotificacionBD.ObtenerConfiguracionNotificacionCorreos(dt);

                if (objConfigCorreo != null)
                {
                    StringBuilder strBody = new StringBuilder();

                    //integrar Body del Correo Electrónico
                    strBody.Append("Buen día.\n\n");
                    strBody.Append("Actualización de contraseña Exitosa en SAIC");
                    strBody.Append("\n\n");
                    strBody.Append("Esta dirección de correo electrónico no admite respuestas. Para obtener más información contacte a su ejecutivo.");

                    MailMessage mail = new MailMessage();

                    mail.From = new MailAddress(objConfigCorreo.EmailUser, "Notificaciones SAIC");
                    mail.To.Add(new MailAddress(OperadorBD.OperadorGlobal.CorreoElectronico));
                    mail.Subject = "Actualizacion de Contraseña del Usuario " + OperadorBD.OperadorGlobal.NombreUsuario;
                    mail.Body = strBody.ToString();
                    //configurar conexion SMTP Server
                    var client = new SmtpClient(objConfigCorreo.SMTPServer, Int16.Parse(objConfigCorreo.Puerto))
                    {
                        Credentials = new NetworkCredential(objConfigCorreo.EmailUser, objConfigCorreo.EmailPassword),
                        EnableSsl = objConfigCorreo.SSL
                    };

                    System.Threading.Thread.Sleep(2000);
                    client.Send(mail);  //enviar correo electronico            
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("No se pudo enviar la notificacion." + Environment.NewLine + ex.Message
                                  , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public Boolean validarContraseniaOperador(int idOperador)
        {
            Boolean flagTaMuyBien = false;

            //stpSelInfoVigenciaContraseniaOperadorTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelInfoVigenciaContraseniaOperador, OperadorBD.OperadorGlobal.IdOperador);
            //if (dbSAICBPOCatalogosDataSet1.stpSelInfoVigenciaContraseniaOperador.Rows.Count > 0)
            //{
            //    DateTime.TryParse(stpSelEstatusNominaContabilizadaTableAdapter1.ObtenerFechaServidor().ToString(), out dFechaHoy);

            //    DateTime dtVigencia = new DateTime();
            //    DateTime.TryParse(dbSAICBPOCatalogosDataSet1.stpSelInfoVigenciaContraseniaOperador.Rows[0]["Vigencia"].ToString(), out dtVigencia);

            //    if (dtVigencia <= dFechaHoy)
            //    {
            //        flagTaMuyBien = true;
            //    }
            //}

            return flagTaMuyBien;
        }

    }
}