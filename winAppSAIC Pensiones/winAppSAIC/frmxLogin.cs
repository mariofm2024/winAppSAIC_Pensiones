using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using compLibreriaSAIC;
using compCatalogosSAIC;
using System.Configuration;
using winAppSAIC.UtileriasLocal;
using System.Reflection;
using compSeguridad;
using compCryptoSeguridad;
using System.IO;
using System.Linq;
using System.Security.Cryptography;

namespace winAppSAIC
{
    public partial class frmxLogin : DevExpress.XtraEditors.XtraForm
    {
        tools.dsc dsc = new tools.dsc();
        public Boolean flagVigenciaContraseniaOperador = false;
        public frmxLogin()
        {
            InitializeComponent();
        }

        #region "Variables Globales"
        //variable globa que obtiene la informacion del Assembly
        private UtileriasLocal.AssemblyInfo entryAssemblyInfo = new UtileriasLocal.AssemblyInfo(Assembly.GetEntryAssembly());
        #endregion

        #region "Métodos Propios"

        /// <summary>
        /// Método que reinicia la aplicacion cuando se han modificado
        /// valores internos que afectan la información que se manipula
        /// </summary>
        private void ReiniciarAplicacion()
        {
            // Get the parameters/arguments passed to program if any 
            string arguments = string.Empty;
            string[] args = Environment.GetCommandLineArgs();
            for (int i = 1; i < args.Length; i++) // args[0] is always exe path/filename 
                arguments += args[i] + " ";

            // Restart current application, with same arguments/parameters 
            Application.Exit();
            System.Diagnostics.Process.Start(Application.ExecutablePath, arguments);

        }

        /// <summary>
        /// Método que muestra la pantalla de configuración de la conexion a BD
        /// </summary>
        private void MostrarPantallaConfiguracion(String stConexion)
        {
            frmConfiguracion objConfig = new frmConfiguracion(stConexion);
            objConfig.ShowDialog();     //mostrar pantalla
            objConfig.TopMost = true;       //mostrar al frente

            bool bFlag = objConfig.bFlagModificacionBD;     //obtener bandera cambios en BD

            if (bFlag)          //si se modificó la configuración de la BD entonces reiniciar aplicación
            {
                try
                {
                    ReiniciarAplicacion();      //reiniciar aplicacion
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        #endregion

        #region "Métodos Encripcion"
        private string AES_Encryption(string pContrasena)
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


        #endregion

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (txtUsuario.Text.Trim().Length > 0 && txtContrasena.Text.Trim().Length > 0)
            {
                string cipherText = AES_Encryption(txtContrasena.Text.Trim());

                //cargar informacion Operador
                DataTable dt = this.stpSelInfoOperadorLoginTableAdapter1.GetData(txtUsuario.Text.Trim(), cipherText);
                //DataTable dt = this.stpSelInfoOperadorLoginTableAdapter1.GetData(txtUsuario.Text.Trim(), txtContrasena.Text.Trim());

                //crear objeto y pasar el DataTable para asignar los valores
                Operador objOperador = OperadorBD.ObtenerInfoOperador(dt);
                //Operador objOperador = new Operador();
                //objOperador.IdOperador = 1;

                //WindowsIdentity.GetCurrent().Name
                //objOperador.NombreUsuario = txtUsuario.Text;
                //objOperador.NombreOperador = txtUsuario.Text;
                //objOperador.IdAreaOperativa = 1;
                //objOperador.Confidencial = false;
                //objOperador.Activo = true;
                //objOperador.CorreoElectronico = txtUsuario.Text + "@bpo.mx";

                //si existe el objeto entonces mostrar los valores
                if (objOperador != null)
                {
                    if (objOperador.Activo)     //si el usuario está activo
                    {
                        OperadorBD.OperadorGlobal = objOperador;        //asignar globalmente la informacion del Operador
                        flagVigenciaContraseniaOperador = objOperador.VigenciaContrasenia == 1 ? true : false;
                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                        addUsers(txtUsuario.Text.ToLower());
                        this.Close();
                    }
                    else
                        XtraMessageBox.Show("El usuario utilizado no está activo, contacte a\nAplicaciones de Negocio para autorizar su acceso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    XtraMessageBox.Show("Usuario o Contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                XtraMessageBox.Show("Debe escribir Usuario y Contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            //Application.Exit();     //terminar aplicacion
        }

        Dictionary<String, String> operadores = new Dictionary<String, String>();
        private void autoCompleteTextEdit()
        {
            String pathFileUsers = @"C:\SAIC\SaicU.ini";
            try
            {
                AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

                String[] datos;
                if (File.Exists(pathFileUsers))
                {
                    datos = File.ReadAllLines(pathFileUsers);
                    for (int i = 0; i < datos.Length; i++)
                    {
                        String stDesNombre = dsc.StrExtract(dsc.DesEncriptado(datos[i]), "", "<pass>");
                        String stDesPass = dsc.StrExtract(dsc.DesEncriptado(datos[i]), "<pass>");
                        //collection.Add(datos[i].Trim());
                        collection.Add(stDesNombre.Trim());
                        operadores.Add(stDesNombre, stDesPass);
                    }

                    txtUsuario.MaskBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    txtUsuario.MaskBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    txtUsuario.MaskBox.AutoCompleteCustomSource = collection;
                }
            }
            catch (Exception)
            {
                File.Delete(pathFileUsers);
            }
        }

        private void addUsers(String nameUser)
        {
            try
            {
                Boolean existe = false;
                Boolean primeravez = false;
                String path = @"C:\SAIC";
                String pathFileUsers = @"C:\SAIC\SaicU.ini";
                String datos = String.Empty;
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                if (!File.Exists(pathFileUsers))
                    File.Create(pathFileUsers).Close();

                String[] arrayUsuario = File.ReadAllLines(pathFileUsers);

                if (arrayUsuario.Length > 0)
                {
                    arrayUsuario = arrayUsuario.Distinct().ToArray();
                    for (int i = 0; i < arrayUsuario.Length; i++)
                    {
                        if (arrayUsuario[i].Contains(dsc.Encriptado(nameUser).Substring(0, dsc.Encriptado(nameUser).Length - 3)))
                        {
                            String stConPass = String.Empty;
                            if (checkRecordarPass.Checked) { stConPass = txtContrasena.Text; }
                            datos += dsc.Encriptado(nameUser + "<pass>" + stConPass) + Environment.NewLine;
                            existe = true;
                        }
                        else
                        {
                            datos += arrayUsuario[i] + Environment.NewLine;
                        }
                    }
                }
                else
                {
                    String stConPass = String.Empty;
                    if (checkRecordarPass.Checked) { stConPass = txtContrasena.Text; }
                    datos += dsc.Encriptado(nameUser + "<pass>" + stConPass) + Environment.NewLine;
                    primeravez = true;
                }

                if (!existe && !primeravez)
                {
                    String stConPass = String.Empty;
                    if (checkRecordarPass.Checked) { stConPass = txtContrasena.Text; }
                    datos += dsc.Encriptado(nameUser + "<pass>" + stConPass) + Environment.NewLine;
                }

                File.WriteAllText(pathFileUsers, datos);

            }
            catch (Exception) { }
        }

        String stConexionLocal = "Data Source=MXGORBOSSQL,54234;Initial Catalog=dbSAICBPO_PENSION_MX_20180301;Persist Security Info=True;User ID=dbUserPensionesMX;Password=e@}s[BB$q#?G6QTz;Application Name=SAIC Pensiones 2017;";
        String stConexionRemota = "Data Source=gorbos.ddns.net,54234;Initial Catalog=dbSAICBPO_PENSION_MX_20180301;Persist Security Info=True;User ID=dbUserPensionesMX;Password=e@}s[BB$q#?G6QTz;Application Name=SAIC Pensiones 2017;";

        private void frmxLogin_Load(object sender, EventArgs e)
        {
            //this.Text = entryAssemblyInfo.Product;
            bool bFlagIsServidorConectado = false;
            //bool local = false;

            //String stNombreAplicacion = "Tipo Conexion: " + entryAssemblyInfo.Product + " ";
            //List<String> stConexiones = new List<String>();

            //splashScreenManager2.ShowWaitForm();

            ////Obtener el tipo de conexion
            //String stDatosConexion = String.Empty;
            //int indice = 0;
            //if (File.Exists(tools.dsc.stRutaConexion))
            //{
            //    stConexiones = File.ReadAllLines(tools.dsc.stRutaConexion).ToList();
            //    stConexiones = stConexiones.Where(x => !String.IsNullOrEmpty(x.ToString())).ToList();
            //    stConexiones = stConexiones.Select(x => x.ToString()).Distinct().ToList();
            //    for (int i = 0; i < stConexiones.Count; i++)
            //    {
            //        if (stConexiones[i].Contains(stNombreAplicacion))
            //        {
            //            indice = i;
            //            stDatosConexion = dsc.StrExtract(stConexiones[i], stNombreAplicacion).Trim();
            //            break;
            //        }
            //    }
            //}
            //else { dsc.CheckandCreateFolder(dsc.stRutaTemp); }
            ////Obtener el tipo de conexion

            //if (!String.IsNullOrEmpty(stDatosConexion))
            //{
            //    if (stDatosConexion.Contains("Local"))
            //    {
            //        switchConexion(true);
            //        bFlagIsServidorConectado = Utilerias.IsServidorConectado(winAppSAIC.Properties.Settings.Default.dbSAICBPOConnectionString);

            //       if (!bFlagIsServidorConectado)
            //        {
            //            stConexiones.RemoveAt(indice);
            //            switchConexion(false);
            //            bFlagIsServidorConectado = Utilerias.IsServidorConectado(winAppSAIC.Properties.Settings.Default.dbSAICBPOConnectionString);
            //            if (bFlagIsServidorConectado)
            //            {
            //                stConexiones.Add(stNombreAplicacion + "Remoto");
            //                File.WriteAllLines(tools.dsc.stRutaConexion, stConexiones);
            //            }
            //        }
            //    }
            //    else if (stDatosConexion.Contains("Remoto"))
            //    {
            //        switchConexion(false);
            //        bFlagIsServidorConectado = Utilerias.IsServidorConectado(winAppSAIC.Properties.Settings.Default.dbSAICBPOConnectionString);
            //        if (!bFlagIsServidorConectado)
            //        {
            //            stConexiones.RemoveAt(indice);
            //            switchConexion(true);
            //            bFlagIsServidorConectado = Utilerias.IsServidorConectado(winAppSAIC.Properties.Settings.Default.dbSAICBPOConnectionString);
            //            if (bFlagIsServidorConectado)
            //            {
            //                local = true;
            //                stConexiones.Add(stNombreAplicacion + "Local");
            //                File.WriteAllLines(tools.dsc.stRutaConexion, stConexiones);
            //            }
            //        }
            //    }
            //}
            //else
            //{
            //    switchConexion(true);
            //    bFlagIsServidorConectado = Utilerias.IsServidorConectado(winAppSAIC.Properties.Settings.Default.dbSAICBPOConnectionString);
            //    if (bFlagIsServidorConectado)
            //    {
            //        stConexiones.Add(stNombreAplicacion + "Local");
            //        File.WriteAllLines(tools.dsc.stRutaConexion, stConexiones);
            //    }
            //    else
            //    {
            //        switchConexion(false);
            //        bFlagIsServidorConectado = Utilerias.IsServidorConectado(winAppSAIC.Properties.Settings.Default.dbSAICBPOConnectionString);
            //        if (bFlagIsServidorConectado)
            //        {
            //            stConexiones.Add(stNombreAplicacion + "Remoto");
            //            File.WriteAllLines(tools.dsc.stRutaConexion, stConexiones);
            //        }
            //    }
            //}

            splashScreenManager2.ShowWaitForm();
            bFlagIsServidorConectado = Utilerias.IsServidorConectado(winAppSAIC.Properties.Settings.Default.dbSAICBPOConnectionString);
            splashScreenManager2.CloseWaitForm();

            EliminarCarpetaSAT();

            if (!bFlagIsServidorConectado)        //si no se puede conectar
                MostrarPantallaConfiguracion(winAppSAIC.Properties.Settings.Default.dbSAICBPOConnectionString);     //Mostrar pantalla de configuracion BD
            else
            {
                autoCompleteTextEdit();

                //cargar informacion Operador
                short? pIdVersionApp = 0;
                string pNoVersionAppAutorizada = "";
                string pIdTipoMovimiento = "";

                this.stpSelVersionApp2014TableAdapter1.GetData(entryAssemblyInfo.Product, entryAssemblyInfo.Version, ref pIdVersionApp, ref pNoVersionAppAutorizada, ref pIdTipoMovimiento);

                if (pIdVersionApp == 0)        //si no se puede conectar
                {
                    XtraMessageBox.Show("Esta APP NO es la última versión., La versión autorizada es: " + pNoVersionAppAutorizada, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    btnAceptar.Enabled = true;
                    this.Text = string.Format("Acceso {0}", entryAssemblyInfo.Product);    //mostrar version de la aplicacion
                }
            }
        }
        private void EliminarCarpetaSAT()
        {
            string subPath = @"C:\SAT\";

            try
            {
                bool directoryExists = Directory.Exists(subPath);
                System.IO.DirectoryInfo di = new DirectoryInfo(subPath);
                if (directoryExists)
                {
                    foreach(FileInfo file in di.GetFiles())
                    {
                        file.Delete();
                    }
                    
                    Directory.Delete(subPath);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.Message);
            }
        }


        private void txtUsuario_EditValueChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Contains("."))
            {
                if (operadores.ContainsKey(txtUsuario.Text))
                {
                    if (!String.IsNullOrEmpty(operadores[txtUsuario.Text]))
                    {
                        checkRecordarPass.Checked = true;
                        txtContrasena.Text = operadores[txtUsuario.Text];
                    }
                }
            }
        }

        //Switch Entre conexion Remota y Local.
        private void switchConexion(Boolean blLocal)
        {
            String stConexion = String.Empty;
            if (blLocal)
            {
                stConexion = stConexionLocal;
            }
            else
            {
                stConexion = stConexionRemota;
            }

            Configuration _config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            _config.ConnectionStrings.ConnectionStrings["winAppSAIC.Properties.Settings.dbSAICBPOConnectionString"].ConnectionString = stConexion;
            _config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(_config.ConnectionStrings.SectionInformation.Name);
            Properties.Settings.Default.Reload();
        }

        private Boolean probarConexion()
        {
            Boolean flatServidorConectado = false;
            flatServidorConectado = Utilerias.IsServidorConectado(winAppSAIC.Properties.Settings.Default.dbSAICBPOConnectionString);
            return flatServidorConectado;
        }


        private void InitipoConexion()
        {
            Configuration _config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            _config.ConnectionStrings.ConnectionStrings["winAppSAIC.Properties.Settings.dbSAICBPOConnectionString"].ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["winAppSAIC.Properties.Settings.dbSAICBPOConnectionString"].ConnectionString;
            _config.ConnectionStrings.ConnectionStrings["winAppSAIC.Properties.Settings.dbSAICBPOConnectionLocalString"].ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["winAppSAIC.Properties.Settings.dbSAICBPOConnectionLocalString"].ConnectionString;

            _config.Save(ConfigurationSaveMode.Modified);

            ////Forzar la aplicacion de los cambios con la nueva conexion a la Base de Datos
            ConfigurationManager.RefreshSection(_config.ConnectionStrings.SectionInformation.Name);
            Properties.Settings.Default.Reload();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtUsuario.Text =  "mario.flores";
            txtContrasena.Text = "mar0103floR3$";

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            txtUsuario.Text = "juan.martin";
            txtContrasena.Text = "jua1802mar+8A";


        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            txtUsuario.Text = "mayra.ortiz";
            txtContrasena.Text = "may0511ort!2@";
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            txtUsuario.Text = "salvador.galicia";
            txtContrasena.Text = "sal1004gal0O$";


        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            txtUsuario.Text = "regina.tapia";
            txtContrasena.Text = "reg2012tap¿5D";
        }
    }
}