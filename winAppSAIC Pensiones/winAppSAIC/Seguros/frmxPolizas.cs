using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using System.Security.Principal;
using DevExpress.XtraEditors;
using compCatalogosSAIC;
using winAppSAIC.UtileriasLocal;

namespace winAppSAIC.Seguros
{
    public partial class frmxPolizas : DevExpress.XtraEditors.XtraForm
    {
        public frmxPolizas()
        {
            InitializeComponent();
        }

        #region "Variables Globales"
        private Constantes.TipoOperacionABC tipoOperacionABC = Constantes.TipoOperacionABC.Ninguno;

        #endregion

        #region "Metodos Propios"
        private Poliza AsignarInfoPoliza()
        {
            Poliza objPoliza = null;

            try
            {
                objPoliza = new Poliza();

                objPoliza.IdPoliza = Convert.ToInt32(txtIdPoliza.Text);
                objPoliza.NoPoliza = txtNoPoliza.Text;
                objPoliza.IdCIAAseguradora = Convert.ToInt32(cbCIA.EditValue);
                objPoliza.IdTipoSeguro= Convert.ToInt32(cbTipoSeguro.EditValue);
                objPoliza.Concepto = txtConcepto.Text;
                objPoliza.IdCliente = Convert.ToInt32(cboCliente.EditValue);
                objPoliza.IdTenedora = Convert.ToInt32(cboTenedora.EditValue);
                objPoliza.IdTipoMetodoPago = Convert.ToInt32(cboMetodoPago.EditValue);
                objPoliza.IdEstatus = Convert.ToInt32(cboIdEstatus.EditValue);
                objPoliza.FechaEMI = Convert.ToDateTime(dtFechaEmision.EditValue);
                objPoliza.FechaIniVig = Convert.ToDateTime(dtFechaInicioVig.EditValue);
                objPoliza.FechaFinVig = Convert.ToDateTime(dtFechaFinVig.EditValue);
                objPoliza.IdTipoPagadorPoliza = Convert.ToInt32(cboPagadorPoliza.EditValue);
            }
            catch (Exception ex)
            {
                return null;
            }
            return objPoliza;
        }

        private void MostrarInfoPoliza(Poliza objPoliza)
        {
            txtIdPoliza.Text = objPoliza.IdPoliza.ToString();
            txtNoPoliza.Text = objPoliza.NoPoliza;
            cbCIA.EditValue = objPoliza.IdCIAAseguradora;
            cbTipoSeguro.EditValue = objPoliza.IdTipoSeguro;
            txtConcepto.Text = objPoliza.Concepto;
            cboCliente.EditValue = objPoliza.IdCliente;
            cboTenedora.EditValue = objPoliza.IdTenedora;
            cboMetodoPago.EditValue = objPoliza.IdTipoMetodoPago;
            cboIdEstatus.EditValue = objPoliza.IdEstatus;
            dtFechaEmision.EditValue = objPoliza.FechaEMI;
            dtFechaInicioVig.EditValue = objPoliza.FechaIniVig;
            dtFechaFinVig.EditValue = objPoliza.FechaFinVig;
            cboPagadorPoliza.EditValue = objPoliza.IdTipoPagadorPoliza;
        }
        
        private void ActivarControlesInfoCliente(bool bFlag)
        {
            // txtIdPoliza.Enabled = bFlag;
            txtNoPoliza.Enabled = bFlag;
            cbCIA.Enabled = bFlag;
            cbTipoSeguro.Enabled = bFlag;
            txtConcepto.Enabled = bFlag;
            cboCliente.Enabled = bFlag;
            cboTenedora.Enabled = bFlag;
            cboMetodoPago.Enabled = bFlag;
            cboIdEstatus.Enabled = bFlag;
            dtFechaEmision.Enabled = bFlag;
            dtFechaInicioVig.Enabled = bFlag;
            dtFechaFinVig.Enabled = bFlag;
            cboPagadorPoliza.Enabled = bFlag;
        }

        private void LimpiarControlesInfoCliente()
        {
            txtIdPoliza.Text =   "0";
            txtNoPoliza.Text = string.Empty;
            cbCIA.EditValue   = -1;
            cbTipoSeguro.EditValue = -1;
            txtConcepto.Text = string.Empty;
            cboCliente.EditValue = -1;
            cboTenedora.EditValue = -1;
            cboMetodoPago.EditValue = -1;
            cboIdEstatus.EditValue = -1;
            dtFechaEmision.EditValue = DateTime.Today; 
            dtFechaInicioVig.EditValue = DateTime.Today;
            dtFechaFinVig.EditValue = DateTime.Today;
        }


        /// <summary>
        /// Método para Activar o Desactivar Controles BOTONES y COMBOBOX
        /// en base a la acciones del usuario
        /// </summary>
        /// <param name="bFlag">Valor VERDADERO o FALSO</param>
        private void ActivarDesactivarBotones(bool bFlag)
        {
            btnNuevo.Enabled = bFlag;
            btnEditar.Enabled = bFlag;
            btnCancelar.Enabled = !bFlag;
            btnGuardar.Enabled = !bFlag;
            //btnBorrar.Enabled = bFlag;
            cboIdPoliza.Enabled = bFlag;
        }
        #endregion


        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();        //cerrar pantalla
        }

        private void frmxPolizas_Load(object sender, EventArgs e)
        {

            try
            {
                // TODO: This line of code loads data into the 'dbSAICBPOCatalogosDataSet.vwCatEstatusSeguro' table. You can move, or remove it, as needed.
                this.vwCatEstatusSeguroTableAdapter.Fill(this.dbSAICBPOCatalogosDataSet.vwCatEstatusSeguro);
                // TODO: This line of code loads data into the 'dbSAICBPOCatalogosDataSet.vwCatMetodoPago' table. You can move, or remove it, as needed.
                this.vwCatMetodoPagoTableAdapter.Fill(this.dbSAICBPOCatalogosDataSet.vwCatMetodoPago);
                // TODO: This line of code loads data into the 'dbSAICBPOCatalogosDataSet.vwCatTipoSeguro' table. You can move, or remove it, as needed.
                this.vwCatTipoSeguroTableAdapter.Fill(this.dbSAICBPOCatalogosDataSet.vwCatTipoSeguro);
                // TODO: This line of code loads data into the 'dbSAIC_Catalogos.stpSelClienteSeguro' table. You can move, or remove it, as needed.
                this.stpSelClienteSeguroTableAdapter.Fill(this.dbSAIC_Catalogos.stpSelClienteSeguro);
                // TODO: This line of code loads data into the 'dbSAICBPOCatalogosDataSet.vwCatTipoPagadorPoliza' table. You can move, or remove it, as needed.
                this.vwCatTipoPagadorPolizaTableAdapter.Fill(this.dbSAICBPOCatalogosDataSet.vwCatTipoPagadorPoliza);
                // TODO: This line of code loads data into the 'dbSAIC_Catalogos.vwCatCIA' table. You can move, or remove it, as needed.
                this.vwCatCIATableAdapter.Fill(this.dbSAIC_Catalogos.vwCatCIA);
                // TODO: This line of code loads data into the 'dbSAICBPODataSet.vwCatTenedoraMatriz' table. You can move, or remove it, as needed.
                this.vwCatTenedoraMatrizTableAdapter.Fill(this.dbSAICBPODataSet.vwCatTenedoraMatriz);
                // Carga Polizas
                this.catPolizaTableAdapter1.Fill(this.dbSAIC_Catalogos.CatPoliza);
                // Set column widths according to their contents. 
                cboIdPoliza.Properties.View.BestFitColumns();
                // Specify the total dropdown width. 
                cboIdPoliza.Properties.PopupFormWidth = 800;
                // Set column widths according to their contents. 
                cboCliente.Properties.View.BestFitColumns();
                // Specify the total dropdown width. 
                cboCliente.Properties.PopupFormWidth = 800;


                ActivarDesactivarBotones(true);
                ActivarControlesInfoCliente(false);     //desactivar controles formulario

                tipoOperacionABC = Constantes.TipoOperacionABC.Ninguno; //tipo de Operacion ABC = NIGUNO
                
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboIdClienteProveedor_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                //obtener el renglon completo del Combobox
                DataRow row = gridLookUpEdit1View.GetDataRow(gridLookUpEdit1View.FocusedRowHandle);

                //obtener la informacion del Cliente
                Poliza objPoliza = PolizaBD.AsignarInfoPoliza(row);

                if (objPoliza != null)
                    MostrarInfoPoliza(objPoliza);
                else
                    XtraMessageBox.Show("¡La información de la Poliza seleccionada no está disponible! \nContacte a Sistemas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            tipoOperacionABC = Constantes.TipoOperacionABC.Nuevo; //tipo de Operacion ABC = NUEVO

            LimpiarControlesInfoCliente();      //inicializar controles formulario
            ActivarDesactivarBotones(false);
            ActivarControlesInfoCliente(true);      //activar controles formulario
            txtNoPoliza.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ActivarDesactivarBotones(true);
            ActivarControlesInfoCliente(false);      //desactivar controles formulario
            tipoOperacionABC = Constantes.TipoOperacionABC.Ninguno; //tipo de Operacion ABC = NIGUNO
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validator.IsPresent(txtNoPoliza) && Validator.IsPresent(cboCliente) &&
                    Validator.IsPresent(cbCIA) && Validator.IsPresent(txtConcepto) &&
                    Validator.IsPresent(cboIdEstatus) && Validator.IsPresent(cboMetodoPago) &&
                    Validator.IsPresent(cboTenedora) && Validator.IsPresent(cbTipoSeguro) && Validator.IsPresent(cboPagadorPoliza) &&
                    Validator.IsDate(dtFechaEmision) && Validator.IsDate(dtFechaFinVig) && Validator.IsDate(dtFechaInicioVig))
                {
                    Poliza objPoliza = AsignarInfoPoliza();

                    if (objPoliza != null)
                    {
                        if (tipoOperacionABC == Constantes.TipoOperacionABC.Nuevo)
                        {
                            int? pIdPoliza = 0;

                            this.catPolizaTableAdapter1.Insert(objPoliza.NoPoliza, objPoliza.IdCIAAseguradora, objPoliza.IdTipoSeguro, objPoliza.Concepto,
                                                               objPoliza.IdCliente, objPoliza.IdTenedora, objPoliza.IdTipoMetodoPago, objPoliza.IdEstatus,
                                                               objPoliza.FechaEMI, objPoliza.FechaIniVig, objPoliza.FechaFinVig,  OperadorBD.OperadorGlobal.NombreUsuario,objPoliza.IdTipoPagadorPoliza , ref pIdPoliza);

                            if (pIdPoliza == 0)        //si existe Id asignado => Alta del cliente exitosa
                                XtraMessageBox.Show("¡El alta de la Poliza NO ha sido exitosa!\nContacte a Sistemas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else
                            {
                                txtIdPoliza.Text = pIdPoliza.ToString();
                                ActivarDesactivarBotones(true);
                                ActivarControlesInfoCliente(false);      //desactivar controles formulario
                                tipoOperacionABC = Constantes.TipoOperacionABC.Ninguno; //tipo de Operacion ABC = NIGUNO
                                XtraMessageBox.Show("¡El alta de la Poliza ha sido exitosa!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                // actualizar Table Adapter
                                this.catPolizaTableAdapter1.Fill(this.dbSAIC_Catalogos.CatPoliza);
                            }
                        }
                        else if (tipoOperacionABC == Constantes.TipoOperacionABC.Editar)
                        {
                            int intNoRegistrosAfectados = this.catPolizaTableAdapter1.Update(objPoliza.IdPoliza,objPoliza.NoPoliza, objPoliza.IdCIAAseguradora, objPoliza.IdTipoSeguro, objPoliza.Concepto,
                                                               objPoliza.IdCliente, objPoliza.IdTenedora, objPoliza.IdTipoMetodoPago, objPoliza.IdEstatus,
                                                               objPoliza.FechaEMI, objPoliza.FechaIniVig, objPoliza.FechaFinVig,OperadorBD.OperadorGlobal.NombreUsuario ,objPoliza.IdTipoPagadorPoliza);

                            if (intNoRegistrosAfectados == 0)        //si existe Id asignado => Alta del cliente exitosa
                                XtraMessageBox.Show("¡La modificación de la Poliza NO ha sido exitosa!\nContacte a Sistemas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else
                            {
                                ActivarDesactivarBotones(true);
                                ActivarControlesInfoCliente(false);      //desactivar controles formulario
                                tipoOperacionABC = Constantes.TipoOperacionABC.Ninguno; //tipo de Operacion ABC = NIGUNO
                                XtraMessageBox.Show("¡La modificación de la Poliza ha sido exitosa!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                // actualizar Table Adapter
                                this.catPolizaTableAdapter1.Fill(this.dbSAIC_Catalogos.CatPoliza);
                            }
                        }
                    }   //if (objCliente != null)
                    else
                        XtraMessageBox.Show("¡La asignación de información de la Poliza NO ha sido exitosa!\nContacte a Sistemas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtIdPoliza.Text) > 0)
            {
                ActivarDesactivarBotones(false);        //desactivar botones
                ActivarControlesInfoCliente(true);      //activar controles formulario
                tipoOperacionABC = Constantes.TipoOperacionABC.Editar; //tipo de Operacion ABC = EDITAR
            }
            else
                XtraMessageBox.Show("No ha seleccionado una Poliza para modificar su información.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void cboIdEstatus_EditValueChanged(object sender, EventArgs e)
        {
            ////si el estatus es ACTIVO, asignar fecha baja = 01/01/1900
            //if (Convert.ToByte(cboIdEstatus.EditValue).Equals(2))
            //    dtFechaInicioVig.EditValue = new DateTime(1900, 1, 1);
            //else
            //    dtFechaInicioVig.EditValue = DateTime.Now.Date;
        }

        private void cbTipoSeguro_EditValueChanged(object sender, EventArgs e)
        {
            if (cbTipoSeguro.EditValue != null && cbTipoSeguro.EditValue.ToString() != "")
            {
                this.stpSelCIAAseguradorasTableAdapter.Fill(this.dbSAICBPOCatalogosDataSet.stpSelCIAAseguradoras, -1);
            }
        }
    }
}