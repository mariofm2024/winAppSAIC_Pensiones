using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace winAppSAIC.Catalogos
{
    public partial class frmxCatalogosGenerales : DevExpress.XtraEditors.XtraForm
    {
        public frmxCatalogosGenerales()
        {
            InitializeComponent();
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();        //cerrar pantalla
        }

        private void nbiEstatus_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            splitContainerControl1.Panel2.Controls.Clear();
            var objForm = new uc.ucCatalogosGenerales() { Dock = DockStyle.Fill, OpcionMenu=1  /*Estatus*/};
            splitContainerControl1.Panel2.Controls.Add(objForm);
            objForm.Show();
        }

        private void nbiRegimenFiscalSAT_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            splitContainerControl1.Panel2.Controls.Clear();
            var objForm = new uc.ucCatalogosGenerales() { Dock = DockStyle.Fill, OpcionMenu = 2  /*Regimen Fiscal SAT*/};
            splitContainerControl1.Panel2.Controls.Add(objForm);
            objForm.Show();
        }

        private void nbiPeriodicidadSAT_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            splitContainerControl1.Panel2.Controls.Clear();
            var objForm = new uc.ucCatalogosGenerales() { Dock = DockStyle.Fill, OpcionMenu = 3  /*Periodicidad Pago SAT*/};
            splitContainerControl1.Panel2.Controls.Add(objForm);
            objForm.Show();
        }

        private void nbiTipoContratoSAT_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            splitContainerControl1.Panel2.Controls.Clear();
            var objForm = new uc.ucCatalogosGenerales() { Dock = DockStyle.Fill, OpcionMenu = 4  /*Tipo Contrato SAT*/};
            splitContainerControl1.Panel2.Controls.Add(objForm);
            objForm.Show();
        }

        private void nbiTipoJornadaSAT_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            splitContainerControl1.Panel2.Controls.Clear();
            var objForm = new uc.ucCatalogosGenerales() { Dock = DockStyle.Fill, OpcionMenu = 5  /*Tipo Jornada SAT*/};
            splitContainerControl1.Panel2.Controls.Add(objForm);
            objForm.Show();
        }

        private void nbiTipoNominaSAT_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            splitContainerControl1.Panel2.Controls.Clear();
            var objForm = new uc.ucCatalogosGenerales() { Dock = DockStyle.Fill, OpcionMenu = 6  /*Tipo Nomina SAT*/};
            splitContainerControl1.Panel2.Controls.Add(objForm);
            objForm.Show();
        }
    }
}