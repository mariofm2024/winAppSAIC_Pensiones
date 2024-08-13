using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using compLibreriaSAIC;
using compCatalogosSAIC;

namespace winAppSAIC.Cancelaciones
{
    public partial class frmxEliminarNominas : DevExpress.XtraEditors.XtraForm
    {
        public frmxEliminarNominas()
        {
            InitializeComponent();
        }

        #region "Métodos Propios"
        
        InfoDetalleSolicitudCancelacionNomina objInfoDetalle;      //declarar objeto InfoDetalleLoteCargaNomina

        /// <summary>
        /// Método que despliega la Informacion Detallada
        /// del Lote Carga Nomina seleccionado
        /// </summary>
        private void MostrarInfoDetalleSolicitudCancelacionNomina(long pIdLoteCargaNomina)
        {
            //cargar informacion detalla LoteCargaNomina
            DataTable dt = this.stpSelInfoDetalleSolicitudCancelacionNominaTableAdapter1.GetData(pIdLoteCargaNomina);

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

                //desbloqueo de boton Eliminar Nomina
                btnEliminarNomina.Enabled = true;
            }
        }

        /// <summary>
        /// Método que actualiza el combobox LoteCargaNomina
        /// y limpia los controles
        /// </summary>
        private void InicializarFormulario()
        {
            //limpiar controles
            txtNombreComercialTenedora.Text = "";
            txtNombreComercialCliente.Text = "";
            txtNombreOperador.Text = "";
            txtPeriodoPago.Text = "";
            txtTipoNomina.Text = "";
            txtObservaciones.Text = "";

            //cboFolioLoteCargaNomina.EditValue = -1;
            btnEliminarNomina.Enabled = false;
            // actualizar combobox LoteCargaNomina
            this.stpSelSolicitudFolioCancelacionNominaTableAdapter.Fill(this.dbSAICBPODataSet.stpSelSolicitudFolioCancelacionNomina);
        }
        #endregion

        private void frmxEliminarNominas_Load(object sender, EventArgs e)
        {
            try
            {
                this.stpSelSolicitudFolioCancelacionNominaTableAdapter.Fill(this.dbSAICBPODataSet.stpSelSolicitudFolioCancelacionNomina);

                // Set column widths according to their contents. 
                cboFolioLoteCargaNomina.Properties.View.BestFitColumns();
                // Specify the total dropdown width. 
                cboFolioLoteCargaNomina.Properties.PopupFormWidth = 900;

                btnEliminarNomina.Enabled = false;      //bloqueo de botón Eliminar Nomina
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

        private void cboFolioLoteCargaNomina_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                //cargar informacion detallada InfoDetalleSolicitudCancelacionNomina
                MostrarInfoDetalleSolicitudCancelacionNomina((long)cboFolioLoteCargaNomina.EditValue);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEliminarNomina_Click(object sender, EventArgs e)
        {
            //Obtener el Id del Lote de Carga Nomina
            //para asignarlo a los recibos
            long intIdLoteCargaNomina = (long) cboFolioLoteCargaNomina.EditValue;

            //Obtener el FolioLoteCArgaNomina
            string strFolioLoteCargaNomina = cboFolioLoteCargaNomina.Text;

            if (intIdLoteCargaNomina > 0)       //si seleccionamos un Lote de Carga Nomina
            {
                try
                {
                    //solicitar confirmacion
                    if (XtraMessageBox.Show(String.Format("¿Está seguro que desea cancelar el Folio {0}?", strFolioLoteCargaNomina), "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                    {
                        //si la Nóminas es SA
                        if (strFolioLoteCargaNomina.Substring(0, 1) == "S")
                        {
                            //cambiar estatus Nómina SA: borrado = 1
                            this.actualizacionesGeneralTableAdapter1.stpDelNominaSueldosSA(intIdLoteCargaNomina, OperadorBD.OperadorGlobal.NombreUsuario);

                            //cambiar estatus Nómina Ahorro: borrado = 1
                            this.actualizacionesGeneralTableAdapter1.stpDelNominaAhorro(intIdLoteCargaNomina, OperadorBD.OperadorGlobal.NombreUsuario);
                        }

                        //si la Nóminas es SC
                        if (strFolioLoteCargaNomina.Substring(0, 1) == "A")
                        {
                            //cambiar estatus Nómina SC: borrado = 1
                            this.actualizacionesGeneralTableAdapter1.stpDelNominaAlimentosSC(intIdLoteCargaNomina, OperadorBD.OperadorGlobal.NombreUsuario);

                            //cambiar estatus Nómina Ahorro: borrado = 1
                            this.actualizacionesGeneralTableAdapter1.stpDelNominaAhorro(intIdLoteCargaNomina, OperadorBD.OperadorGlobal.NombreUsuario);
                        }

                        XtraMessageBox.Show(String.Format("¡La Nómina con Folio {0} ha sido cancelada!", strFolioLoteCargaNomina), "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        //inicializar controles y actualizar combobox LoteCargaNomina
                        InicializarFormulario();
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}