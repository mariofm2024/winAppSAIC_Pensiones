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
    public partial class frmxProductos : DevExpress.XtraEditors.XtraForm
    {
        public frmxProductos()
        {
            InitializeComponent();
        }

        private void GuardarRegistros()
        {
            this.Validate();
            this.productoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbSAIC_Catalogos);
        }

        private void productoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
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

        private void frmxProductos_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'dbSAIC_Catalogos.Producto' table. You can move, or remove it, as needed.
                this.productoTableAdapter.Fill(this.dbSAIC_Catalogos.Producto);
            }
            catch (System.Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();    //cerrar pantalla
        }

        private void frmxProductos_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                //validar si existen cambios en el DataSet
                if (this.dbSAIC_Catalogos.HasChanges())
                {
                    if (XtraMessageBox.Show("¿Desea guardar los cambios realizados en los Productos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
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