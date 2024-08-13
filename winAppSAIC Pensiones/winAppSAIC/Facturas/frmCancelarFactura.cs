using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using winAppSAIC.UtileriasLocal;
using compCatalogosSAIC;

namespace winAppSAIC.Facturas
{
    public partial class frmCancelarFactura : DevExpress.XtraEditors.XtraForm
    {
        public Boolean flagConRelacion = false;
        public Int64 pIdSolicitud = 0;
        public Int64 pIdFacturaRela = 0;
        public Int32 pIdMotivoCancela = 0;
        public string pRespuesta = "";
        public bool pflag = false;
        public frmCancelarFactura()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //Cerrar Ventana 
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validator.IsPresent(cbMotivoCancelacion) && txtJustifi.Text != string.Empty)
                {
                    pRespuesta = txtJustifi.Text;
                    pIdMotivoCancela = Convert.ToInt32(cbMotivoCancelacion.EditValue);

                    pflag = true;
                    Close();

                    //if (cbMotivoCancelacion.EditValue.ToString() == "1")
                    //{
                    //if (Validator.IsPresent(cbFacturaRelacion))
                    //{
                    //    pIdFacturaRela = Convert.ToInt64(cbFacturaRelacion.EditValue);
                    //    pflag = true;
                    //    Close();
                    //}
                    //else
                    //{
                    //    pflag = false;
                    //}
                    //}
                    //else
                    //{
                    //    pflag = true;
                    //    Close();
                    //}
                }
                else
                {
                    XtraMessageBox.Show("¡Se requiere un Motivo Interno!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pflag = false;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pflag = false;
            }
        }

        private void frmCancelarFactura_Load(object sender, EventArgs e)
        {
            try
            {
                //factMotivoCancelacionTableAdapter1.FillBy(dbSAICBPOFactura.FactMotivoCancelacion);
                stpFactSelMotivoCancelacionTableAdapter.Fill(dbSAICBPOFactura.stpFactSelMotivoCancelacion, flagConRelacion);
                // Set column widths according to their contents. 
                cbFacturaRelacion.Properties.View.BestFitColumns();
                // Specify the total dropdown width. 
                cbFacturaRelacion.Properties.PopupFormWidth = 700;
                // Set column widths according to their contents. 
                cbMotivoCancelacion.Properties.View.BestFitColumns();
                // Specify the total dropdown width. 
                cbMotivoCancelacion.Properties.PopupFormWidth = 400;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbMotivoCancelacion_EditValueChanged(object sender, EventArgs e)
        {
            if (Validator.IsPresent(cbMotivoCancelacion))
            {
                if (cbMotivoCancelacion.EditValue.ToString() == "1")
                {
                    cbFacturaRelacion.Enabled = true;
                    this.stpFactSelFacturasARelacionarSATTableAdapter1.Fill(dbSAICBPOFactura.stpFactSelFacturasARelacionarSAT, -1, -1, -1, "CAN", pIdSolicitud, 12);
                }
                else
                    cbFacturaRelacion.Enabled = false;
            }
        }
    }
}