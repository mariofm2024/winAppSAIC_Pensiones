using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using compCatalogosSAIC;

namespace winAppSAIC.Seguridad.uc
{
    public partial class ucModulosAplicacion : DevExpress.XtraEditors.XtraUserControl
    {
        //propiedad que indicará el tipo de Emision CFDIs
        //Modulo Aplicacion = 1, Grupos = 2, Pantallas = 3
        //Usuarios = 4, Usuario por Grupo = 5, Derechos de Acceso = 6
        public byte TipoModulo
        { get; set; }

        public ucModulosAplicacion()
        {
            InitializeComponent();
        }

        private void sysModuloAppBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.sysModuloAppBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dbSAIC_Seguridad);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucModulosAplicacion_Load(object sender, EventArgs e)
        {
            try
            {
                splashSMProcesando.ShowWaitForm();

                if (TipoModulo.Equals(1)) //Modulo Aplicacion
                {
                    xtpModulosAplicacion.PageVisible = true;
                    xtpGrupos.PageVisible = false;
                    xtpPantallas.PageVisible = false;
                    xtpUsuariosGrupos.PageVisible = false;

                    // TODO: This line of code loads data 
                    this.sysModuloAppTableAdapter.Fill(this.dbSAIC_Seguridad.SysModuloApp);
                }
                else if (TipoModulo.Equals(2))        //Grupos
                {
                    xtpModulosAplicacion.PageVisible = false;
                    xtpGrupos.PageVisible = true;
                    xtpPantallas.PageVisible = false;
                    xtpUsuariosGrupos.PageVisible = false;

                    // TODO: This line of code loads data 
                    this.sysGrupoTableAdapter.Fill(this.dbSAIC_Seguridad.SysGrupo);
                }
                else if (TipoModulo.Equals(3))        //Pantallas
                {
                    xtpModulosAplicacion.PageVisible = false;
                    xtpGrupos.PageVisible = false;
                    xtpPantallas.PageVisible = true;
                    xtpUsuariosGrupos.PageVisible = false;

                    // TODO: This line of code loads data 
                    this.sysModuloAppTableAdapter.Fill(this.dbSAIC_Seguridad.SysModuloApp);
                    this.sysPantallaTableAdapter.Fill(this.dbSAIC_Seguridad.SysPantalla);
                }
                else if (TipoModulo.Equals(4))        //Usuario por Grupo
                {
                    xtpModulosAplicacion.PageVisible = false;
                    xtpGrupos.PageVisible = false;
                    xtpPantallas.PageVisible = false;
                    xtpUsuariosGrupos.PageVisible = true;

                    // TODO: This line of code loads data 
                    this.stpSelOperadorSeguridadTableAdapter.Fill(this.dbSAIC_Seguridad.stpSelOperadorSeguridad);
                    this.sysGrupoTableAdapter.Fill(this.dbSAIC_Seguridad.SysGrupo);
                    this.sysOperadorGrupoTableAdapter.Fill(this.dbSAIC_Seguridad.SysOperadorGrupo);
                }

                splashSMProcesando.CloseWaitForm();
            }

            catch (System.Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sysGrupoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.sysGrupoBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dbSAIC_Seguridad);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sysPantallaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.sysPantallaBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dbSAIC_Seguridad);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sysOperadorGrupoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.sysOperadorGrupoBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dbSAIC_Seguridad);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
