using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace winAppSAIC
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.Skins.SkinManager.EnableMdiFormSkins();

            frmxLogin objLogin = new frmxLogin();
            DialogResult dr = objLogin.ShowDialog();
            Boolean flagVigenciaContraseniaOperador = objLogin.flagVigenciaContraseniaOperador;

            if (dr == DialogResult.OK)
            {
                if (flagVigenciaContraseniaOperador)
                {
                    Application.Run(new frmxMenu());
                }
                else
                {
                    MessageBox.Show("Contraseña Vencida. Actualice su contraseña para Iniciar Session en SAIC", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Run(new Seguridad.ContraseniaUsuarios());
                    Application.Exit();
                }
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
