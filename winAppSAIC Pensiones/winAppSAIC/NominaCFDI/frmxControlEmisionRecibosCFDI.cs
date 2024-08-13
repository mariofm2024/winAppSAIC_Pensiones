using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace winAppSAIC.NominaCFDI
{
    public partial class frmxControlEmisionRecibosCFDI : DevExpress.XtraEditors.XtraForm
    {
        public frmxControlEmisionRecibosCFDI()
        {
            InitializeComponent();
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();        //cerrar pantalla
        }

        private void nbiCFDIsEmpleado_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            splitContainerControl1.Panel2.Controls.Clear();
            var objForm = new  uc.ucEmisionCFDIsGenerico() { Dock = DockStyle.Fill, TipoEmisionCFDIs = 1 /*empleado*/ };
            splitContainerControl1.Panel2.Controls.Add(objForm);
            objForm.Show();
        }

        private void nbiCFDIsCliente_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            splitContainerControl1.Panel2.Controls.Clear();
            var objForm = new uc.ucEmisionCFDIsGenerico() { Dock = DockStyle.Fill, TipoEmisionCFDIs = 2 /*cliente*/ };
            splitContainerControl1.Panel2.Controls.Add(objForm);
            objForm.Show();
        }

        private void nbiCFDIsPagadora_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            splitContainerControl1.Panel2.Controls.Clear();
            var objForm = new uc.ucEmisionCFDIsGenerico() { Dock = DockStyle.Fill, TipoEmisionCFDIs = 3 /*pagadora*/ };
            //var objForm = new frmxEmisionCFDIsGenerico() { TipoEmisionCFDIs = 3 /*pagadora*/, TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill };
            splitContainerControl1.Panel2.Controls.Add(objForm);
            objForm.Show();
        }

        private void nbiEmailCFDIsLote_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            splitContainerControl1.Panel2.Controls.Clear();
            var objForm = new uc.ucEmisionCFDIsGenerico() { Dock = DockStyle.Fill, TipoEmisionCFDIs = 4 /*Correo Electronico por Lote Nomina*/ };
            splitContainerControl1.Panel2.Controls.Add(objForm);
            objForm.Show();
        }

        private void nbiCFDIsLote_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            splitContainerControl1.Panel2.Controls.Clear();
            var objForm = new uc.ucEmisionCFDIsGenerico() { Dock = DockStyle.Fill, TipoEmisionCFDIs = 3 /*Lote*/ };
            //var objForm = new frmxEmisionCFDIsGenerico() { TipoEmisionCFDIs = 3 /*pagadora*/, TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill };
            splitContainerControl1.Panel2.Controls.Add(objForm);
            objForm.Show();
        }
    }
}