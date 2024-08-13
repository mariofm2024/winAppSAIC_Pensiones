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
    public partial class frmxSectores : DevExpress.XtraEditors.XtraForm
    {
        public frmxSectores()
        {
            InitializeComponent();
        }

        private void GuardarRegistros()
        {
            this.Validate();
            this.sectorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbSAIC_Catalogos);
        }

        private void sectorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
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

        private void frmxSectores_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'dbSAIC_Catalogos.Sector' table. You can move, or remove it, as needed.
                this.sectorTableAdapter.Fill(this.dbSAIC_Catalogos.Sector);
            }
            catch (System.Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();        //cerrar pantalla
        }

        private void frmxSectores_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                //validar si existen cambios en el DataSet
                if (this.dbSAIC_Catalogos.HasChanges())
                {
                    if (XtraMessageBox.Show("¿Desea guardar los cambios realizados en los Sectores?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
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