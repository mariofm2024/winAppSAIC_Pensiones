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
    public partial class frmVicularControl : DevExpress.XtraEditors.XtraForm
    {
        public Int64 IdFactura = 0;
        public Int32 IdFronting = 0;
        public Int32 IdCliente =0;

        public frmVicularControl()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Close();//Cerrar ventana
        }

        private void frmVicularControl_Load(object sender, EventArgs e)
        {
            try
            {
               this.stpFactSelControlOperacionesVincularFacturaTableAdapter.Fill(dbSAICBPOFactura.stpFactSelControlOperacionesVincularFactura,IdCliente,IdFronting, OperadorBD.OperadorGlobal.IdOperador);

                if(dbSAICBPOFactura.stpFactSelControlOperacionesVincularFactura.Count() == 0 )
                {
                    XtraMessageBox.Show("¡No existen Controles Disponibles!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close(); // Cerrar Ventana
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            string Controles = "";
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
                        Controles = Controles + row[0].ToString() + ",";
                    }

                    this.spSoloRespuesta1.stpFactInsControlesFactura(IdFactura, Controles, OperadorBD.OperadorGlobal.IdOperador, OperadorBD.OperadorGlobal.NombreUsuario, ref pOk);
                    if (pOk == 1)
                    {
                        XtraMessageBox.Show("¡La Vinculación de Control(es) fue exitosa!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                        XtraMessageBox.Show("¡Error al Vincular Control(es), intentelo mas tarde!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }
                else
                    XtraMessageBox.Show("¡Debe de seleccionar por lo menos un Control!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}