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

namespace winAppSAIC.Facturas
{
    public partial class frmVincularFactura : DevExpress.XtraEditors.XtraForm
    {
        public Int64 IdFactura= 0;
        public Int32 IdFronting = 0;
        public Int32 IdCliente = 0;
        public Int32 IdBeneficiario = 0;
        public frmVincularFactura()
        {
            InitializeComponent();
        }

        private void frmVincularFactura_Load(object sender, EventArgs e)
        {
            try
            {
                this.stpFactSelFacturasARelacionarTableAdapter.Fill(dbSAICBPOFactura.stpFactSelFacturasARelacionar,IdFactura,IdFronting, IdBeneficiario ,IdCliente, 1);

                if (dbSAICBPOFactura.stpFactSelFacturasARelacionar.Count() == 0)
                {
                    XtraMessageBox.Show("¡No existen Facturas Disponibles!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close(); // Cerrar Ventana
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Close(); //Salir
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            string Facturas = "";
            int? pOk = 0;
            try
            {
                //obtener el No. de Items seleccionados
                DataRow row = null;
                if (gridView3.SelectedRowsCount > 0)
                {
                    foreach (int indice in gridView3.GetSelectedRows())
                    {
                        row = gridView3.GetDataRow(indice);
                        Facturas = Facturas + row[0].ToString() + ",";
                    }

                    this.spSoloRespuesta1.stpFactInsFacturasFactura(IdFactura, Facturas, OperadorBD.OperadorGlobal.IdOperador, OperadorBD.OperadorGlobal.NombreUsuario, ref pOk);
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
    }
}