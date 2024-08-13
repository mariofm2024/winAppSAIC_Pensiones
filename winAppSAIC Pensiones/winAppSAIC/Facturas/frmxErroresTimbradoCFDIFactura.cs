using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using compLibreriaSAIC;

namespace winAppSAIC.Facturas
{
    public partial class frmxErroresTimbradoCFDIFactura : DevExpress.XtraEditors.XtraForm
    {
        public frmxErroresTimbradoCFDIFactura()
        {
            InitializeComponent();
        }

        //propiedad para recibir Lote de Nomina con error
        public Int64 pIdFactura
        {
            get;
            set;
        }

        //propiedad para recibir el IdTipoError (1= Error Timbrado, 2=Error Cancelacion Timbrado)
        public byte pIdTipoError
        {
            get;
            set;
        }

        private void frmxErroresTimbradoCFDI_Load(object sender, EventArgs e)
        {
            try
            {
                if (pIdTipoError.Equals(1))
                    //cambiar titulo de la pantalla
                    this.Text = "Errores de Timbrado XML CFDI Factura No. " + pIdFactura.ToString();
                else if (pIdTipoError.Equals(2))
                    //cambiar titulo de la pantalla
                    this.Text = "Errores de Cancelación XML CFDI Factura No. " + pIdFactura.ToString();

                 this.stpFactSelErroresTimbradoCFDIFacturasTableAdapter.Fill(this.dbSAICBPOFactura.stpFactSelErroresTimbradoCFDIFacturas, pIdFactura, pIdTipoError);
            }
            catch (System.Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();        //cerrar pantalla
        }

        private void btnExportarErrores2XLSX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (sfdRutaArchivo.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    gvErroresTimbradoCFDI.ExportToXls(sfdRutaArchivo.FileName);

                    //Solicitar la visualización del nuevo archivo en Excel
                    if (XtraMessageBox.Show("¿Desea abrir el archivo en Excel?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        // Mostrar resultado en Excel.
                        Utilerias.StartProcess(sfdRutaArchivo.FileName);
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