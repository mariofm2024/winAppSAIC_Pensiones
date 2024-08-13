using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Security.Principal;
using winAppSAIC.UtileriasLocal;
using compCatalogosSAIC;

namespace winAppSAIC.IMSS
{
    public partial class frmxSolicitudTramiteIMSSOperaciones : DevExpress.XtraEditors.XtraForm
    {
        public frmxSolicitudTramiteIMSSOperaciones()
        {
            InitializeComponent();
        }

        #region "Metodos Propios"

        /// <summary>
        /// Método que inicializa colores y valores de algunos controles
        /// </summary>
        private void LimpiarControles()
        {
            txtSDActual.Text = "0";
            txtSDActual.BackColor = Color.White;
            txtSDNuevo.Text = "0";
            txtSDNuevo.BackColor = Color.White;
            cboCausaBajaIMSS.EditValue = cboCausaBajaIMSS.Properties.GetKeyValue(0);
            cboCausaBajaIMSS.BackColor = Color.White;
            txtObservaciones.Text = "";
        }

        /// <summary>
        /// Método para habilitar o deshabilitar controles
        /// </summary>
        /// <param name="bFlag"></param>
        private void ActivarControles(bool bFlag)
        {
            txtSDActual.Enabled = bFlag;
            txtSDNuevo.Enabled = bFlag;
            cboCausaBajaIMSS.Enabled = bFlag;
        }

        #endregion

        private void frmxSolicitudTramiteIMSSOperaciones_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'dbSAICBPODataSet.stpSelTipoMovimientoTramiteIMSS' table. You can move, or remove it, as needed.
                this.stpSelTipoMovimientoTramiteIMSSTableAdapter.Fill(this.dbSAICBPODataSet.stpSelTipoMovimientoTramiteIMSS);
                // TODO: This line of code loads data into the 'dbSAICBPODataSet.vwCatTenedoraSA' table. You can move, or remove it, as needed.
                this.vwCatTenedoraSATableAdapter.Fill(this.dbSAICBPODataSet.vwCatTenedoraSA);
                // TODO: This line of code loads data into the 'dbSAICBPODataSet.vwCatCliente' table. You can move, or remove it, as needed.
                this.vwCatClienteTableAdapter.Fill(this.dbSAICBPODataSet.vwCatCliente);
                // TODO: This line of code loads data into the 'dbSAICBPODataSet.stpSelOperador' table. You can move, or remove it, as needed.
                this.stpSelOperadorTableAdapter.Fill(this.dbSAICBPODataSet.stpSelOperador);
                // TODO: This line of code loads data into the 'dbSAICBPODataSet.stpSelCausaBajaIMSS' table. You can move, or remove it, as needed.
                this.stpSelCausaBajaIMSSTableAdapter.Fill(this.dbSAICBPODataSet.stpSelCausaBajaIMSS);

                // Set column widths according to their contents. 
                cboTenedora.Properties.View.BestFitColumns();
                cboCliente.Properties.View.BestFitColumns();

                // Specify the total dropdown width. 
                cboTenedora.Properties.PopupFormWidth = 600;
                cboCliente.Properties.PopupFormWidth = 800;

                cboTipoMovimiento.Focus();      //colocar cursor en TipoMovimiento
                calFechaMovimiento.EditValue = DateTime.Today;      //asignar fecha actual

                LimpiarControles();     //inicializar controles
                ActivarControles(false);        //deshabilitar controles
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboTipoMovimiento_EditValueChanged(object sender, EventArgs e)
        {
            txtSDActual.Text = "0";
            txtSDNuevo.Text = "0";

            switch (Convert.ToByte(cboTipoMovimiento.EditValue))
            {
                case 8:     //BAJA
                    cboCausaBajaIMSS.Enabled = true;
                    cboCausaBajaIMSS.EditValue = cboCausaBajaIMSS.Properties.GetKeyValue(1);
                    lblFechaMovimiento.Text = "Fecha Baja";
                    txtSDActual.Enabled = false;
                    txtSDNuevo.Enabled = false;
                    cboCausaBajaIMSS.BackColor = Color.LightGoldenrodYellow;
                    txtSDActual.BackColor = Color.White;
                    txtSDNuevo.BackColor = Color.White;
                    break;
                
                case 9:     //REINGRESO
                    cboCausaBajaIMSS.Enabled = false;
                    cboCausaBajaIMSS.EditValue = cboCausaBajaIMSS.Properties.GetKeyValue(0);
                    lblFechaMovimiento.Text = "Fecha Reingreso";
                    txtSDActual.Enabled = false;
                    txtSDNuevo.Enabled = true;
                    cboCausaBajaIMSS.BackColor = Color.White;
                    txtSDActual.BackColor = Color.White;
                    txtSDNuevo.BackColor = Color.LightGoldenrodYellow;
                    break;

                case 10:    //ASIGNACION NSS
                    cboCausaBajaIMSS.Enabled = false;
                    cboCausaBajaIMSS.EditValue = cboCausaBajaIMSS.Properties.GetKeyValue(0);
                    lblFechaMovimiento.Text = "Fecha Movimiento";
                    txtSDActual.Enabled = false;
                    txtSDNuevo.Enabled = false;
                    cboCausaBajaIMSS.BackColor = Color.White;
                    txtSDActual.BackColor = Color.White;
                    txtSDNuevo.BackColor = Color.White;
                    break;

                case 11:    //MODIFICACION DE SALARIO
                    cboCausaBajaIMSS.Enabled = false;
                    cboCausaBajaIMSS.EditValue = cboCausaBajaIMSS.Properties.GetKeyValue(0);
                    lblFechaMovimiento.Text = "Fecha Inicio Sueldo";
                    txtSDActual.Enabled = true;
                    txtSDNuevo.Enabled = true;
                    cboCausaBajaIMSS.BackColor = Color.White;
                    txtSDActual.BackColor = Color.LightGoldenrodYellow;
                    txtSDNuevo.BackColor = Color.LightGoldenrodYellow;
                    break;
            }
        }

        private void btnGuardarSolicitud_Click(object sender, EventArgs e)
        {
            long? pIdSolicitudTramiteIMSS = 0;

            try
            {
                DateTime fechaActual = DateTime.Today;

                if (Validator.IsValidDataCombobox(cboTipoMovimiento) && 
                    Validator.IsDate(calFechaMovimiento)  &&     //validar fecha
                    Validator.IsValidDataCombobox(cboTenedora) &&
                    Validator.IsValidDataCombobox(cboCliente)&&
                    Validator.IsValidDataCombobox(cboOperador))
                {


                    this.actualizacionesIMSSTableAdapter1.stpInsSolicitudTramiteIMSS(Convert.ToByte(cboTipoMovimiento.EditValue),
                        Convert.ToInt32(cboTenedora.EditValue), Convert.ToInt32(cboCliente.EditValue),
                        Convert.ToInt32(txtNoEmpleado.Text), Convert.ToInt16(cboOperador.EditValue),
                        Convert.ToDateTime(calFechaMovimiento.EditValue),
                        Convert.ToDecimal(txtSDActual.Text), Convert.ToDecimal(txtSDNuevo.Text),
                        Convert.ToByte(cboCausaBajaIMSS.EditValue), txtObservaciones.Text,
                        OperadorBD.OperadorGlobal.NombreUsuario, ref pIdSolicitudTramiteIMSS);

                    if (pIdSolicitudTramiteIMSS > 0)
                    {
                        lblFolioSolicitudTramiteIMSS.Text = pIdSolicitudTramiteIMSS.ToString();
                        XtraMessageBox.Show("La Solicitud de Trámite ha sido generada con el Folio # " 
                            + pIdSolicitudTramiteIMSS.ToString(), "Confirmación",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        this.DialogResult = System.Windows.Forms.DialogResult.OK;   //cierre pantalla
                    }
                    else
                    {
                        XtraMessageBox.Show("No fue posible realizar la Solicitud, contacte a Sistemas!", 
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                XtraMessageBox.Show("No fue posible realizar la Solicitud, contacte a Sistemas!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}