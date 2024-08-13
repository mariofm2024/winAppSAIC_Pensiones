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
    public partial class frmxActividadComercial : DevExpress.XtraEditors.XtraForm
    {
        public frmxActividadComercial()
        {
            InitializeComponent();
        }

        private void GuardarRegistros()
        {
            this.Validate();
            this.actividadComercialBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbSAIC_Catalogos);
        }

        
        private void actividadComercialBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                GuardarRegistros();     //guardar cambios
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmxActividadComercial_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'dbSAIC_Catalogos.Sector' table. You can move, or remove it, as needed.
                this.sectorTableAdapter.Fill(this.dbSAIC_Catalogos.Sector);
                // TODO: This line of code loads data into the 'dbSAIC_Catalogos.ActividadComercial' table. You can move, or remove it, as needed.
                this.actividadComercialTableAdapter.Fill(this.dbSAIC_Catalogos.ActividadComercial);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();        //cerrar pantalla
        }

        private void frmxActividadComercial_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                //validar si existen cambios en el DataSet
                if (this.dbSAIC_Catalogos.HasChanges())
                {
                    if (XtraMessageBox.Show("¿Desea guardar los cambios realizados en\nlas Actividades Comerciales?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                        GuardarRegistros();     //guardar cambios
                    else
                        this.dbSAIC_Catalogos.RejectChanges(); //deshacer cambios
                }
            }
            catch (Exception ex)
            {
                e.Cancel = true;        //cancelar cerrado de pantalla
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}