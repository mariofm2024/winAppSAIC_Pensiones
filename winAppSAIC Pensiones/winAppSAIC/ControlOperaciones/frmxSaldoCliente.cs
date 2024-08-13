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
using winAppSAIC.UtileriasLocal;
using compLibreriaSAIC;

namespace winAppSAIC.ControlOperaciones
{
    public partial class frmxSaldoCliente : DevExpress.XtraEditors.XtraForm
    {
        public frmxSaldoCliente()
        {
            InitializeComponent();
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void frmxSaldoCliente_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'dbSAICBPODataSet.vwCatCliente' table. You can move, or remove it, as needed.
                this.vwCatClienteTableAdapter.Fill(this.dbSAICBPODataSet.vwCatCliente);

                // Set column widths according to their contents. 
                cbCliente.Properties.View.BestFitColumns();
                // Specify the total dropdown width. 
                cbCliente.Properties.PopupFormWidth = 500;

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbCliente_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Int32 IdCliente = 0;


                if (Validator.IsPresent(cbCliente))
                {
                    IdCliente = Convert.ToInt32(cbCliente.EditValue.ToString());

                    dbSAICBPOFactura.stpFactSelDetailCOSaldoFull.Clear();

                    this.stpFactSelDetailCOSaldoFullTableAdapter.Fill(dbSAICBPOFactura.stpFactSelDetailCOSaldoFull, Convert.ToInt32(IdCliente));

                }
                else
                {
                    dbSAICBPOFactura.stpFactSelDetailCOSaldoFull.Clear();

                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
      

        private void btnExtraer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                savedescarga.Filter = "Excel Files(.xls)|*.xls|Excel Files(.xlsx) | *.xlsx | Excel Files(*.xlsm) | *.xlsm";
                if (savedescarga.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    dgvSaldo.ExportToXls(savedescarga.FileName);

                    //Solicitar la visualización del nuevo archivo en Excel
                    if (XtraMessageBox.Show("¿Desea abrir el archivo en Excel?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        // Mostrar resultado en Excel.
                        Utilerias.StartProcess(savedescarga.FileName);
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}