using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using System.Reflection;

namespace winAppSAIC
{
    public partial class frmConfiguracion : DevExpress.XtraEditors.XtraForm
    {
        String stConexion;
        public frmConfiguracion(String stConexion)
        {
            InitializeComponent();
            this.stConexion = stConexion;
        }

        #region "Variables Globales"

        //variable globa que obtiene la informacion del Assembly
        private UtileriasLocal.AssemblyInfo entryAssemblyInfo = new UtileriasLocal.AssemblyInfo(Assembly.GetEntryAssembly());

        /// <summary>
        /// Propiedad que indica si ha sido modificada la configuracion
        /// de la Base de Datos
        /// </summary>
        public bool bFlagModificacionBD
        {
            get;
            set;
        }

        private const string sServer = "DATA SOURCE=";
        private const string sDataBase = "INITIAL CATALOG=";
        private const string sUserName = "USER ID=";
        private const string sPassword = "PWD=";
        private const string sAppName = "application name=";
        private string sConexion = "";
        private string sConexionEF = "";        //conexion EntityFramework
        private const string sInfoClassEF = @"metadata=res://*/NominaCFDITimbreFacil.dbSAICBPONominaCFDITimbreFacil.csdl|res://*/NominaCFDITimbreFacil.dbSAICBPONominaCFDITimbreFacil.ssdl|res://*/NominaCFDITimbreFacil.dbSAICBPONominaCFDITimbreFacil.msl;provider=System.Data.SqlClient;provider connection string='";
        private const string sLastInfoClasCF = @"MultipleActiveResultSets=True'";


        /// <summary>
        /// Método que valida los valores solicitados para la Conexión de la Base de Datos
        /// </summary>
        /// <returns>Valor TRUE o FALSE</returns>
        private bool IsValidServidorBD()
        {
            return txtNombreServidor.Text.Trim().Length > 0 &&
                    txtNombreBaseDatos.Text.Trim().Length > 0 &&
                        txtNombreUsuario.Text.Trim().Length > 0 &&
                        txtContrasena.Text.Trim().Length > 0;
        }

        /// <summary>
        /// Método para inicializar los textboxes de Conexion a la Base de Datos
        /// </summary>
        private void InicializarTextboxes()
        {
            txtNombreServidor.Text = "";
            txtNombreBaseDatos.Text = "";
            txtNombreUsuario.Text = "";
            txtContrasena.Text = "";
        }
        #endregion

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();        //cerrar pantalla
        }

        private void frmConfiguracion_Load(object sender, EventArgs e)
        {
            //Inicializar Textboxes
            InicializarTextboxes();
            this.bFlagModificacionBD = false;       //inicializar bandera sin cambios a la configuración BD
            txtNombreServidor.Focus();
            tipoConexion();
        }

        private void tipoConexion()
        {
            if (stConexion.Contains(" gorbos.ddns.net,54234"))
            {
                rdRemoto.Checked = true;
            }
            else
            {
                rdLocal.Checked = true;
            }
        }

        private void btnProbarConexionBD_Click_1(object sender, EventArgs e)
        {
            //validar la informacion definida por el usuario
            if (IsValidServidorBD())
            {
                sConexion = @sServer + txtNombreServidor.Text.Trim() + ";" +
                    sDataBase + txtNombreBaseDatos.Text.Trim() + ";" +
                    sUserName + txtNombreUsuario.Text.Trim() + ";" +
                    sPassword + txtContrasena.Text.Trim() + ";";

                try
                {
                    SqlConnection Cnn = new SqlConnection(sConexion);
                    Cnn.Open();      //abrir conexion
                    //si la conexión existe
                    if (Cnn != null)
                    {
                        //si la conexion extá abierta
                        if (Cnn.State == System.Data.ConnectionState.Open)
                        {
                            Cnn.Close();        //cerrar conexion
                            Cnn.Dispose();      //destruir conexion
                        }
                        else
                        {
                            Cnn.Dispose();      //destruir conexion
                        }
                        XtraMessageBox.Show("¡La conexión al Servidor de Base de Datos ES correcta!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        XtraMessageBox.Show("¡La conexión al Servidor de Base de Datos NO es correcta!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                XtraMessageBox.Show("¡No ha definido los valores para la conexión " + "\n" + " del Servidor de Base de Datos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnGuardarInfoAppConfig_Click_1(object sender, EventArgs e)
        {
            Configuration _config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            try
            {
                //validar la informacion definida por el usuario
                if (IsValidServidorBD())
                {
                    //sConexion = @sServer + txtNombreServidor.Text.Trim() + ";" + sDataBase + txtNombreBaseDatos.Text.Trim() + ";" + sUserName + txtNombreUsuario.Text.Trim() + ";" + sPassword + txtContrasena.Text.Trim() + ";";
                    sConexion = String.Format("{0}{1};{2}{3};{4}{5};{6}{7};{8}{9};",
                        sServer, txtNombreServidor.Text.Trim(), sDataBase,
                        txtNombreBaseDatos.Text.Trim(), sUserName,
                        txtNombreUsuario.Text.Trim(), sPassword,
                        txtContrasena.Text.Trim(), sAppName, entryAssemblyInfo.Product);

                    sConexionEF = String.Format("{0}{1}{2};{3}{4};{5}{6};{7}{8};{9}{10};{11}",
                        sInfoClassEF, sServer, txtNombreServidor.Text.Trim(), sDataBase,
                        txtNombreBaseDatos.Text.Trim(), sUserName,
                        txtNombreUsuario.Text.Trim(), sPassword,
                        txtContrasena.Text.Trim(), sAppName, entryAssemblyInfo.Product, sLastInfoClasCF);

                    //Asignar el nuevo valor en el archivo app.config
                    _config.ConnectionStrings.ConnectionStrings["winAppSAIC.Properties.Settings.dbSAICBPOConnectionString"].ConnectionString = sConexion;
                    //_config.ConnectionStrings.ConnectionStrings["dbSAICBPO_PENSION_MXEntities"].ConnectionString = sConexionEF;
                    _config.ConnectionStrings.ConnectionStrings["dbSAICBPO_PENSION_MX_Entities"].ConnectionString = sConexionEF;

                    //Guardar cambios
                    _config.Save(ConfigurationSaveMode.Modified);

                    //Forzar la aplicacion de los cambios con la nueva conexion a la Base de Datos
                    ConfigurationManager.RefreshSection(_config.ConnectionStrings.SectionInformation.Name);

                    //recargar los settings
                    Properties.Settings.Default.Reload();

                    XtraMessageBox.Show("¡Información almacenada correctamente!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Inicializar Textboxes
                    InicializarTextboxes();

                    this.bFlagModificacionBD = true;        //si se modificó la configuracion de la BD
                }
                else
                    XtraMessageBox.Show("¡No ha definido los valores para la conexión " + "\n" + " del Servidor de Base de Datos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rdRemoto_CheckedChanged(object sender, EventArgs e)
        {
            if (rdRemoto.Checked)
            {
                String stCOnexionRemoto = "Data Source=gorbos.ddns.net,54234;Initial Catalog=dbSAICBPO_PENSION_MX_20180301;Persist Security Info=True;User ID=dbUserPensionesMX;Password=e@}s[BB$q#?G6QTz;Application Name=\"SAIC Pensiones 2017\"";
                Configuration _config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                //Asignar el nuevo valor en el archivo app.config
                _config.ConnectionStrings.ConnectionStrings["winAppSAIC.Properties.Settings.dbSAICBPOConnectionString"].ConnectionString = stCOnexionRemoto;
                _config.ConnectionStrings.ConnectionStrings["dbSAICBPO_PENSION_MX_Entities"].ConnectionString = sConexionEF + stCOnexionRemoto + sLastInfoClasCF;
                _config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(_config.ConnectionStrings.SectionInformation.Name);
                Properties.Settings.Default.Reload();
            }
        }
    }
}
