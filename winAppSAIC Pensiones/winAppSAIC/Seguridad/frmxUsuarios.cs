using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Configuration;
using compCatalogosSAIC;
using compCryptoSeguridad;
using System.Data.SqlClient;
using System.Security.Principal;
using winAppSAIC.UtileriasLocal;

namespace winAppSAIC.Seguridad
{
    public partial class frmxUsuarios : DevExpress.XtraEditors.XtraForm
    {
        public frmxUsuarios()
        {
            InitializeComponent();
        }

        #region "Metodos Propios"

        //asignar string de conexion
        string Cnn = winAppSAIC.Properties.Settings.Default.dbSAICBPOConnectionString;

        enum EstatusAccion : byte
        {
            Ninguno = 0,
            Nuevo = 1,
            Editar = 2
        }

        private EstatusAccion byEstatusAccion;

        private void ActivarBotones(bool bFlag)
        {
            btnNuevo.Enabled = bFlag;
            btnGuardar.Enabled = !bFlag;
            btnEditar.Enabled = bFlag;
            btnCancelar.Enabled = !bFlag;
        }
        
        private void InicializarControles()
        {
            txtIdOperador.Text = "";
            txtCveInternaOperador.Text = String.Empty;
            txtNombreOperadorCompleto.Text = String.Empty;
            txtUsuario.Text = String.Empty;
            txtContrasena.Text = String.Empty;
            txtCorreoElectronico.Text = String.Empty;
            dgvUsuarios.Refresh();
        }

        /// <summary>
        /// Método para Activar o Desactivar Controles de captura
        /// </summary>
        /// <param name="bFlag">Valor True/False</param>
        private void ActivarControles(bool bFlag)
        {
            txtCveInternaOperador.Enabled = bFlag;
            txtNombreOperadorCompleto.Enabled = bFlag;
            txtCorreoElectronico.Enabled = bFlag;
            txtUsuario.Enabled = bFlag;
            txtContrasena.Enabled = bFlag;
            cboIdAreaOperativa.Enabled = bFlag;
            cboIdPlaza.Enabled = bFlag;
            cboIdGrupo.Enabled = bFlag;
            cboIdEstatusReportes.Enabled = bFlag;
            chkActivo.Enabled = bFlag;
            chkConfidencial.Enabled = bFlag;
            chkActivoNominas.Enabled = bFlag;
        }

        /// <summary>
        /// Método para asignar información del Operador
        /// </summary>
        /// <param name="cipherText">contraseña encriptada</param>
        /// <returns>Objeto Operador</returns>
        private Operador AsignarInfoOperador(string cipherText)
        {
            Operador objOperador = null;

            try
            {
                objOperador = new Operador();
                objOperador.IdOperador = txtIdOperador.Text.Length > 0 ? Convert.ToInt16(txtIdOperador.Text) : Convert.ToInt16(0);
                objOperador.ClaveInternaOperador = txtCveInternaOperador.Text.Trim();
                objOperador.NombreOperador = txtNombreOperadorCompleto.Text.Trim();
                objOperador.CorreoElectronico = txtCorreoElectronico.Text.Trim();
                objOperador.NombreUsuario = txtUsuario.Text.Trim();
                objOperador.Contrasena = cipherText;
                objOperador.IdAreaOperativa = (byte)cboIdAreaOperativa.SelectedValue;
                objOperador.IdPlaza = (short)cboIdPlaza.SelectedValue;
                objOperador.IdGrupo = (short)cboIdGrupo.SelectedValue;
                objOperador.IdEstatusReportes = (byte)cboIdEstatusReportes.SelectedValue;
                objOperador.Activo = chkActivo.Checked;
                objOperador.Confidencial = chkConfidencial.Checked;
                objOperador.ActivoParaNominas = chkActivoNominas.Checked;
                objOperador.UsuarioCreacion = WindowsIdentity.GetCurrent().Name;
                objOperador.UsuarioModificacion = WindowsIdentity.GetCurrent().Name;
            }
            catch
            {
                return null;
            }
            return objOperador;
        }

        public string AES_Encryption(string pContrasena)
        {
            string clearText = pContrasena;

            System.Configuration.AppSettingsReader settingsReader =
                                    new AppSettingsReader();
            // Get the keys from config file
            var dataToEncrypt = CEAesEncryption.GenerateBytes(clearText);
            var key = CEAesEncryption.GenerateBytes((string)settingsReader.GetValue("SecurityKey32", typeof(String)));
            var keyIV = CEAesEncryption.GenerateBytes((string)settingsReader.GetValue("SecurityKey16", typeof(String)));

            return CEAesEncryption.Encrypt(clearText, key, keyIV);
        }

        private string AES_Decryption(string pCipherText)
        {
            System.Configuration.AppSettingsReader settingsReader =
                                    new AppSettingsReader();
            // Get the keys from config file
            var key = CEAesEncryption.GenerateBytes((string)settingsReader.GetValue("SecurityKey32", typeof(String)));
            var keyIV = CEAesEncryption.GenerateBytes((string)settingsReader.GetValue("SecurityKey16", typeof(String)));

            return CEAesEncryption.Decrypt(pCipherText, key, keyIV);
        }

        private void CargarInformacionGrid()
        {
            try
            {
                this.stpSelGeneralUsuariosGrupoTableAdapter.Fill(this.dbSAIC_Seguridad.stpSelGeneralUsuariosGrupo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        #endregion

        private void frmxUsuarios_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'dbSAIC_Seguridad.Estatus' table. You can move, or remove it, as needed.
                this.estatusTableAdapter.Fill(this.dbSAIC_Seguridad.Estatus);
                // TODO: This line of code loads data into the 'dbSAIC_Seguridad.SysGrupo' table. You can move, or remove it, as needed.
                this.sysGrupoTableAdapter.Fill(this.dbSAIC_Seguridad.SysGrupo);
                // TODO: This line of code loads data into the 'dbSAIC_Seguridad.Plaza' table. You can move, or remove it, as needed.
                this.plazaTableAdapter.Fill(this.dbSAIC_Seguridad.Plaza);
                // TODO: This line of code loads data into the 'dbSAIC_Seguridad.AreaOperativa' table. You can move, or remove it, as needed.
                this.areaOperativaTableAdapter.Fill(this.dbSAIC_Seguridad.AreaOperativa);

                CargarInformacionGrid();
                ActivarBotones(true);       //habilitar nuevo
                ActivarControles(false);    //desactivar controles

                //obtener No. de Version CFDI
                txtTipoEncripcion.Text = this.validacionesGeneralTableAdapter1.ObtenerValorParametro("ENCRIPCION").ToString();
                stpSelObtenerGrupoTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelObtenerGrupo);
                byEstatusAccion = EstatusAccion.Ninguno;
            }
            catch (SqlException ex)
            {
                XtraMessageBox.Show("Error en Base de Datos: " +
                            ex.Message, "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error en Base de Datos: " +
                            ex.Message, "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            }
        }

        private void dgvUsuarios_MouseClick(object sender, MouseEventArgs e)
        {
            ActivarBotones(false);
            ActivarControles(true);    //activar controles
            txtContrasena.Text = "";

            txtIdOperador.Text = dgvUsuarios.SelectedRows[0].Cells[0].Value.ToString();
            txtCveInternaOperador.Text = dgvUsuarios.SelectedRows[0].Cells[1].Value.ToString();
            txtNombreOperadorCompleto.Text = dgvUsuarios.SelectedRows[0].Cells[2].Value.ToString();
            txtUsuario.Text = dgvUsuarios.SelectedRows[0].Cells[3].Value.ToString();
            txtCorreoElectronico.Text = dgvUsuarios.SelectedRows[0].Cells[4].Value.ToString();
            cboIdAreaOperativa.SelectedValue = dgvUsuarios.SelectedRows[0].Cells[5].Value;
            chkActivo.Checked = Convert.ToBoolean(dgvUsuarios.SelectedRows[0].Cells[6].Value.ToString());
            chkConfidencial.Checked = Convert.ToBoolean(dgvUsuarios.SelectedRows[0].Cells[7].Value.ToString());
            chkActivoNominas.Checked = Convert.ToBoolean(dgvUsuarios.SelectedRows[0].Cells[8].Value.ToString());
            cboIdEstatusReportes.SelectedValue = dgvUsuarios.SelectedRows[0].Cells[9].Value;
            cboIdPlaza.SelectedValue = dgvUsuarios.SelectedRows[0].Cells[10].Value;
            cboIdGrupo.SelectedValue = dgvUsuarios.SelectedRows[0].Cells[11].Value;
            byEstatusAccion = EstatusAccion.Editar;

            try
            {
                DataRow[] unRow = dbSAIC_Seguridad.stpSelGeneralUsuariosGrupo.Select("idOperador = '" + dgvUsuarios.SelectedRows[0].Cells[0].Value.ToString() + "'");
                if (unRow.Count() > 0)
                {
                    txtContrasena.Text = AES_Decryption(unRow[0]["Contrasena"].ToString());
                }
                //txtContrasena.Text = AES_Decryption()
            }
            catch (Exception)
            {
                txtContrasena.Text = String.Empty;
            }
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();        //cerrar pantalla
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            byEstatusAccion = EstatusAccion.Nuevo;
            ActivarBotones(false);
            InicializarControles();
            ActivarControles(true);    //activar controles
            txtCveInternaOperador.Focus();
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string cipherText = String.Empty;

            if (Validator.IsPresent(txtCveInternaOperador) && Validator.IsPresent(txtNombreOperadorCompleto) &&
                Validator.IsPresent(txtCorreoElectronico) && Validator.IsPresent(txtUsuario) &&
                Validator.IsPresent(txtContrasena) && Validator.IsPresent(cboIdAreaOperativa) &&
                Validator.IsPresent(cboIdPlaza) && Validator.IsPresent(cboIdGrupo) &&
                Validator.IsPresent(cboIdEstatusReportes))
            { 
                if (byEstatusAccion == EstatusAccion.Nuevo)
                {
                    short shIdOperador = 0;

                    if (txtTipoEncripcion.Text.Equals("TDES"))
                        cipherText = CryptorEngine.Encrypt(txtContrasena.Text.Trim(), true);
                    else
                        cipherText = AES_Encryption(txtContrasena.Text.Trim());

                    //asignar informacion del Operador
                    Operador objOperador = AsignarInfoOperador(cipherText);
                    //insertar informacion Operador y obtener el IdOperador
                    shIdOperador = OperadorBD.InsertarOperador(objOperador, Cnn);

                    if (shIdOperador > 0)   //si se inserto correctamente
                    {
                        ActivarBotones(true);
                        ActivarControles(false);    //desactivar controles
                        byEstatusAccion = EstatusAccion.Ninguno;        //inicializar bandera Estatus Accion
                        XtraMessageBox.Show("Se ha dado de alta el No. Operador " +
                            shIdOperador, "Confirmación", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        InicializarControles();     //limpiar controles
                        CargarInformacionGrid();        //actualizar grid
                    }
                    else
                        XtraMessageBox.Show("NO se generó el alta del Operador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else   //Estatus = Editar
                {
                    if (txtTipoEncripcion.Text.Equals("TDES"))
                        cipherText = CryptorEngine.Encrypt(txtContrasena.Text.Trim(), true);
                    else
                        cipherText = AES_Encryption(txtContrasena.Text.Trim());

                    //asignar informacion del Operador
                    Operador objOperador = AsignarInfoOperador(cipherText);

                    using (SqlConnection connection = new SqlConnection(Cnn))
                    {
                        SqlCommand cmd = new SqlCommand("dbo.stpUpdOperador", connection)
                        {
                            CommandType = CommandType.StoredProcedure
                        };

                        cmd.Parameters.AddWithValue("@pClaveInternaOperador", objOperador.ClaveInternaOperador);
                        cmd.Parameters.AddWithValue("@pNombreCompletoOperador", objOperador.NombreOperador);
                        cmd.Parameters.AddWithValue("@pNombreUsuario", objOperador.NombreUsuario);
                        cmd.Parameters.AddWithValue("@pContrasena", objOperador.Contrasena);
                        cmd.Parameters.AddWithValue("@pCorreoElectronico", objOperador.CorreoElectronico);
                        cmd.Parameters.AddWithValue("@pIdAreaOperativa", objOperador.IdAreaOperativa);
                        cmd.Parameters.AddWithValue("@pActivo", objOperador.Activo);
                        cmd.Parameters.AddWithValue("@pConfidencial", objOperador.Confidencial);
                        cmd.Parameters.AddWithValue("@pActivoParaNominas", objOperador.ActivoParaNominas);
                        cmd.Parameters.AddWithValue("@pIdEstatusReportes", objOperador.IdEstatusReportes);
                        cmd.Parameters.AddWithValue("@pIdPlaza", objOperador.IdPlaza);
                        cmd.Parameters.AddWithValue("@pUsuarioModificacion", objOperador.UsuarioModificacion);
                        cmd.Parameters.AddWithValue("@pIdGrupo", objOperador.IdGrupo);
                        cmd.Parameters.AddWithValue("@pIdOperador", objOperador.IdOperador);

                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        CargarInformacionGrid();        //actualizar grid
                        ActivarBotones(true);
                        ActivarControles(false);    //desactivar controles
                    }
                }
            }
        }

        private void btnEditar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtIdOperador.Text.Length > 0)
            {
                ActivarBotones(false);
                ActivarControles(true);    //activar controles
                byEstatusAccion = EstatusAccion.Editar;
            }
            else
            {
                XtraMessageBox.Show("Para editar la información del Usuario, primero debe seleccionarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            InicializarControles();
            ActivarBotones(true);
            ActivarControles(false);    //desactivar controles
            byEstatusAccion = EstatusAccion.Ninguno;
        }

        private void txtNombreOperadorCompleto_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                String nombreUsuario = txtNombreOperadorCompleto.Text;
                String nombreN = String.Empty;

                if (txtNombreOperadorCompleto.Text == "")
                    txtCveInternaOperador.Text = String.Empty;
                txtUsuario.Text = String.Empty;

                if (nombreUsuario.Contains(" "))
                {
                    String[] separado = nombreUsuario.Split(' ');

                    if (separado.Length >= 2)
                        txtUsuario.Text = separado[0].ToLower() + "." + separado[1].ToLower();

                    separado = separado.Where(x => !String.IsNullOrEmpty(x)).ToArray();
                    for (int i = 0; i < separado.Length; i++)
                    {
                        nombreN += separado[i][0].ToString();
                    }

                    txtCveInternaOperador.Text = nombreN;
                }
            }
            catch (Exception) { }
        }

        private void gridLookAreaOperativa_EditValueChanged(object sender, EventArgs e)
        {
            int iGrupo = 0;
            int.TryParse(gridLookAreaOperativa.EditValue.ToString(), out iGrupo);
            stpSelObtenerPantallasTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelObtenerPantallas, iGrupo);
            habilitarPantallasGrupo();
        }

        private void checkCBoxPantallas_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void cboIdGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int iGrupo = 0;
                int.TryParse(cboIdGrupo.SelectedValue.ToString(), out iGrupo);
                iGrupo = iGrupo == 0 ? 1 : iGrupo;
                gridLookAreaOperativa.EditValue = iGrupo;
            }
            catch (Exception) { }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                String StResultado = String.Empty;
                int iGrupo = 0;
                int.TryParse(gridLookAreaOperativa.EditValue.ToString(), out iGrupo);

                foreach (DevExpress.XtraEditors.Controls.CheckedListBoxItem item in checkCBoxPantallas.Properties.Items)
                {
                    Boolean flagPantallaHabilitada = false;
                    flagPantallaHabilitada = item.CheckState.ToString() == "Checked" ? true : false;

                    var resultado = queriesTableAdapter1.stpInsPermisosAcesso(iGrupo, item.Description, flagPantallaHabilitada);
                    StResultado += resultado + Environment.NewLine;
                }

                if (String.IsNullOrEmpty(StResultado.Replace(Environment.NewLine, "")))
                {
                    StResultado = StResultado.Replace(Environment.NewLine, "");
                }

                XtraMessageBox.Show("Permisos " + Environment.NewLine +
                (StResultado.ToString() == String.Empty ? "Actualizados Correctamente." : StResultado)
                , "SAIC", MessageBoxButtons.OK, (StResultado.ToString() == String.Empty ? MessageBoxIcon.Information : MessageBoxIcon.Warning));
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Excepcion en al dar permisos." + Environment.NewLine + ex.Message
              , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void habilitarPantallasGrupo()
        {
            String stValorVentana = String.Empty;
            String stVentanasActivadas = String.Empty;
            memoEditPantallas.Text = String.Empty;
            foreach (DataRow unRow in dbSAICBPOCatalogosDataSet1.stpSelObtenerPantallas.Rows)
            {
                if (unRow["Habilitado"].ToString().Equals("SI"))
                {
                    stValorVentana += unRow["DescPantalla"].ToString() + ",";
                }
            }

            checkCBoxPantallas.SetEditValue(stValorVentana);

            foreach (DevExpress.XtraEditors.Controls.CheckedListBoxItem item in checkCBoxPantallas.Properties.Items)
            {
                if (Array.IndexOf(stValorVentana.Split(','), item.Description) != -1)
                {
                    item.CheckState = CheckState.Checked;
                }
            }

            stVentanasActivadas = stValorVentana.Replace(",", Environment.NewLine);
            memoEditPantallas.Text = stVentanasActivadas;
        }
    }
}