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

namespace winAppSAIC.IMSS
{
    public partial class XtraParametros : DevExpress.XtraEditors.XtraForm
    {
        String sArea;
        public XtraParametros(String sArea)
        {
            InitializeComponent();
            this.sArea = sArea;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void XtraParametros_Load(object sender, EventArgs e)
        {

            obtenerInformacionParametros();

        }

        private void obtenerInformacionParametros()
        {
            stpSelParametrosTableAdapter1.Fill(dbSAICBPOActualizacionesIMSSDataSet1.stpSelParametros, sArea, OperadorBD.OperadorGlobal.IdOperador);
        }

        private void gridControlParametros_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridViewParametros.FocusedRowHandle >= 0)
                {
                    DataRow row = gridViewParametros.GetDataRow(gridViewParametros.FocusedRowHandle);

                    txtIdParametro.Text = row[0].ToString();
                    txtParametro.Text = row[1].ToString();
                    txtValorParametro.Text = row[2].ToString();
                    rTexBoxDescripcion.Text = row[3].ToString();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int idParametro = 0;
            int.TryParse(txtIdParametro.Text.ToString(), out idParametro);

            if (idParametro > 0)
            {
                actualizacionesIMSSTableAdapter1.stpupdParametros(idParametro, txtParametro.Text, txtValorParametro.Text, OperadorBD.OperadorGlobal.NombreUsuario);
                XtraMessageBox.Show("Parametro Guardado con Exito",
                  "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                obtenerInformacionParametros();
            }
            else
            {
                XtraMessageBox.Show("Seleccione un parametro para continuar",
                   "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}