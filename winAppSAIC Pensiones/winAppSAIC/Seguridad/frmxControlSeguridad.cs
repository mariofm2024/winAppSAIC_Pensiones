using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace winAppSAIC.Seguridad
{
    public partial class frmxControlSeguridad : DevExpress.XtraEditors.XtraForm
    {
        public frmxControlSeguridad()
        {
            InitializeComponent();
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();        //cerrar pantalla
        }

        private void nbiModulosApp_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            splitContainerControl1.Panel2.Controls.Clear();
            var objForm = new uc.ucModulosAplicacion() { Dock = DockStyle.Fill, TipoModulo = 1 };
            splitContainerControl1.Panel2.Controls.Add(objForm);
            objForm.Show();
        }

        private void nbiGrupos_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            splitContainerControl1.Panel2.Controls.Clear();
            var objForm = new uc.ucModulosAplicacion() { Dock = DockStyle.Fill, TipoModulo = 2 };
            splitContainerControl1.Panel2.Controls.Add(objForm);
            objForm.Show();
        }

        private void nbiPantallas_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            splitContainerControl1.Panel2.Controls.Clear();
            var objForm = new uc.ucModulosAplicacion() { Dock = DockStyle.Fill, TipoModulo = 3 };
            splitContainerControl1.Panel2.Controls.Add(objForm);
            objForm.Show();
        }

        private void nbiUsuariosGrupo_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            splitContainerControl1.Panel2.Controls.Clear();
            var objForm = new uc.ucModulosAplicacion() { Dock = DockStyle.Fill, TipoModulo = 4 };
            splitContainerControl1.Panel2.Controls.Add(objForm);
            objForm.Show();
        }

        private void nbiUsuarios_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmxUsuarios objForm = new frmxUsuarios();
            objForm.ShowDialog();
        }

        private void nbiAsignarCuentaBancoLayout_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Tesoreria.frmxAsignacionBancoTenedoraLayout objForm = new Tesoreria.frmxAsignacionBancoTenedoraLayout();
            objForm.ShowDialog();   //mostrar pantalla
        }
    }
}