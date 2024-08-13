using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using compCatalogosSAIC;

namespace winAppSAIC.Catalogos
{
    public partial class frmxCategoria : DevExpress.XtraEditors.XtraForm
    {
        public frmxCategoria()
        {
            InitializeComponent();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            txtCategoria.Enabled = true;
        }

        private void productoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (txtCategoria.Text.Replace(" ", "").Length > 0)
            {
                String sRespuesta = String.Empty;
                queriesTableAdapter1.stpInsCategoriaCliente(1, 0, txtCategoria.Text.Trim(), 2, OperadorBD.OperadorGlobal.NombreUsuario, ref sRespuesta);

                if (String.IsNullOrEmpty(sRespuesta))
                {
                    XtraMessageBox.Show("Categoria Guardada con Exito", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarInformacion();
                }
                else
                {
                    XtraMessageBox.Show(sRespuesta, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

            DataRow row = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (row != null)
            {
                int idCategoriaCliente = 0;
                int.TryParse(row["idCategoriaCliente"].ToString(), out idCategoriaCliente);

                int idEstatus = 0;
                String sDescEstatus = String.Empty;
                sDescEstatus = row["DescEstatus"].ToString();

                if (sDescEstatus == "ACTIVO")
                {
                    idEstatus = 3;
                }
                else if (sDescEstatus == "INACTIVO")
                {
                    idEstatus = 2;
                }

                String sRespuesta = String.Empty;
                queriesTableAdapter1.stpInsCategoriaCliente(2, idCategoriaCliente, String.Empty, idEstatus, OperadorBD.OperadorGlobal.NombreUsuario, ref sRespuesta);

                if (!String.IsNullOrEmpty(sRespuesta))
                {
                    XtraMessageBox.Show(sRespuesta, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    cargarInformacion();
                }
            }
            else
            {
                XtraMessageBox.Show("Seleccione una Categoria", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmxCategoria_Load(object sender, EventArgs e)
        {
            bindingNavigatorAddNewItem.Enabled = true;
            bindingNavigatorDeleteItem.Enabled = true;
            cargarInformacion();
        }

        private void cargarInformacion()
        {
            stpSelCategoriaClienteTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelCategoriaCliente, 2);
            txtCategoria.Enabled = false;
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}