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

namespace winAppSAIC.ControlOperaciones
{
    public partial class frmVicularFacControl : DevExpress.XtraEditors.XtraForm
    {
        public long IdControl;
        public frmVicularFacControl()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Close(); //SALIR
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            string IdFacturas = "";
            int? pOk = 0;
            try
            {
                //obtener el No. de Items seleccionados
                DataRow row = null;
                if (gridView1.SelectedRowsCount > 0)
                {
                    foreach (int indice in gridView1.GetSelectedRows())
                    {
                        row = gridView1.GetDataRow(indice);
                        IdFacturas = IdFacturas + row[0].ToString() + ",";
                    }

                    this.spSoloRespuesta1.stpFactInsFacturasControl(IdControl, IdFacturas, OperadorBD.OperadorGlobal.IdOperador, OperadorBD.OperadorGlobal.NombreUsuario, ref pOk);
                    if (pOk == 1)
                    {
                        XtraMessageBox.Show("¡La Vinculación de Factura(s) fue exitosa!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                        XtraMessageBox.Show("¡Error al Vincular Factura(s), intentelo mas tarde!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                    XtraMessageBox.Show("¡Debe de seleccionar por lo menos una Factura!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmVicularFacControl_Load(object sender, EventArgs e)
        {
            try
            {
                this.stpFactSelFacturasARelacionarTableAdapter.Fill(this.dbSAICBPOFactura.stpFactSelFacturasARelacionar, IdControl,0,0,0,2);
                if (this.dbSAICBPOFactura.stpFactSelFacturasARelacionar.Count == 0)
                {
                    XtraMessageBox.Show("¡No existen Facturas disponibles!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }

            }       //try
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}