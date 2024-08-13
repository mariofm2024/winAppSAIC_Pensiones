using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using compLibreriaSAIC;

namespace winAppSAIC
{
    public partial class frmxDesgloseNominasCanceladas : DevExpress.XtraEditors.XtraForm
    {
        InfoDetalleSolicitudCancelacionNomina objInfoDetalle;      //declarar objeto InfoDetalleLoteCargaNomina

        #region "Metodos Propios"
        /// <summary>
        /// Método que despliega la Informacion Detallada
        /// del Lote Carga Nomina seleccionado
        /// </summary>
        private void MostrarInfoDetalleLoteCargaNomina(long pIdLoteCargaNomina)
        {
            //cargar informacion detalla LoteCargaNomina
            DataTable dt = this.stpSelInfoDetalleLoteCargaNominaCanceladoTableAdapter1.GetData(pIdLoteCargaNomina);

            //crear objeto y pasar el DataTable para asignar los valores
            objInfoDetalle = InfoDetalleSolicitudCancelacionNominaBD.ObtenerInfoDetalleSolicitudCancelacionNomina(dt);

            //si existe el objeto entonces mostrar los valores
            if (objInfoDetalle != null)
            {
                txtNombreComercialTenedora.Text = objInfoDetalle.NombreComercialTenedora;
                txtNombreComercialCliente.Text = objInfoDetalle.NombreComercialCliente;
                txtNombreOperador.Text = objInfoDetalle.Operador;
                txtTipoNomina.Text = objInfoDetalle.TipoNomina;
                txtPeriodoPago.Text = objInfoDetalle.PeriodoPago;
                txtObservaciones.Text = objInfoDetalle.MotivoCancelacion;
            }
        }

        #endregion

        public frmxDesgloseNominasCanceladas()
        {
            InitializeComponent();
        }

        private void cboFolioLoteCargaNomina_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                string strTipoNomina = "S";


               //cargar informacion detalla LoteCargaNomina
               MostrarInfoDetalleLoteCargaNomina((long)cboFolioLoteCargaNomina.EditValue);

               strTipoNomina = cboFolioLoteCargaNomina.Text.Substring(0, 1);    //primer caracter

               if (strTipoNomina.Equals("S"))
               {
                   //mostrar datos en base al IdLoteCargaNomina
                   this.stpSelReporteNominaSueldosSATodo_XLSTableAdapter.Fill(this.dbSAICBPOReportesDataSet.stpSelReporteNominaSueldosSATodo_XLS, (long)cboFolioLoteCargaNomina.EditValue);
                   //asignar valor -1 en IdLoteCargaNomina
                   this.stpSelReporteNominaAlimentosSCTodo_XLSTableAdapter.Fill(this.dbSAICBPOReportesDataSet.stpSelReporteNominaAlimentosSCTodo_XLS, -1);
               }
               else
               {
                   //asignar valor -1 en IdLoteCargaNomina
                   this.stpSelReporteNominaSueldosSATodo_XLSTableAdapter.Fill(this.dbSAICBPOReportesDataSet.stpSelReporteNominaSueldosSATodo_XLS, -1);
                   //mostrar datos en base al IdLoteCargaNomina
                   this.stpSelReporteNominaAlimentosSCTodo_XLSTableAdapter.Fill(this.dbSAICBPOReportesDataSet.stpSelReporteNominaAlimentosSCTodo_XLS, (long)cboFolioLoteCargaNomina.EditValue);
               }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmxDesgloseNominasCanceladas_Load(object sender, EventArgs e)
        {
            try
            {
                this.stpSelFolioLoteCargaNominaCanceladosTableAdapter.Fill(this.dbSAICBPOReportesDataSet.stpSelFolioLoteCargaNominaCancelados);

                // Set column widths according to their contents. 
                cboFolioLoteCargaNomina.Properties.View.BestFitColumns();
                // Specify the total dropdown width. 
                cboFolioLoteCargaNomina.Properties.PopupFormWidth = 900;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();        //cerrar pantalla
        }
    }
}