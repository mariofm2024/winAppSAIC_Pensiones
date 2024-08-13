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
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;

namespace winAppSAIC.Facturas.Catalogos
{
    public partial class frmConceptoTenedora : DevExpress.XtraEditors.XtraForm
    {
        public frmConceptoTenedora()
        {
            InitializeComponent();
        }
        #region "Variables Globales"
        private Constantes.TipoOperacionABC tipoOperacionABC = Constantes.TipoOperacionABC.Ninguno;
        private FactConceptoTenedora objMDetalle = null;
        #endregion

        #region "Metodos Propios"
        private FactConceptoTenedora AsignarInfo()
        {
            FactConceptoTenedora objAtributos = null;

            try
            {
                objAtributos = new FactConceptoTenedora();

                objAtributos.IdFactConceptoTenedora = Convert.ToInt64(txtId.Text.Replace(",",""));
                objAtributos.IdFactClaveProduServ = Convert.ToInt32(cbxServicio.EditValue);
                objAtributos.IdTenedoraMatriz = Convert.ToInt32(cbxFronting.EditValue);
                objAtributos.DescConceptoInterno = cbxServicio.Text.Trim();
                objAtributos.IdEstatus = Convert.ToInt16(cbxEstatus.EditValue);
            }
            catch (Exception ex)
            {
                return null;
            }
            return objAtributos;
        }

        private void MostrarInfo(FactConceptoTenedora objAtributos)
        {
            txtId.Text = objAtributos.IdFactConceptoTenedora.ToString();
            cbxServicio.EditValue = objAtributos.IdFactClaveProduServ;
            cbxFronting.EditValue = objAtributos.IdTenedoraMatriz;
            cbxEstatus.EditValue = objAtributos.IdEstatus;          
        }

        private void ActivarControlesInfo(bool bFlag)
        {
            cbxServicio.Enabled = bFlag;
            cbxFronting.Enabled = bFlag;
            cbxEstatus.Enabled = bFlag;
        }

        private void LimpiarControlesInfo()
        {
            txtId.Text = "0";
            cbxServicio.EditValue = -1;
            cbxFronting.EditValue = -1;
            cbxEstatus.EditValue = -1;
        }

        private void ActivarDesactivarBotones(bool bFlag)
        {
            btnNuevo.Enabled = bFlag;
            btnCaptura.Enabled = !bFlag;
            btnGuardar.Enabled = !bFlag;
        }
        #endregion

        private void frmConceptoTenedora_Load(object sender, EventArgs e)
        {
            try
            {
                splashSMCargando.ShowWaitForm();
                // TODO: This line of code loads data into the 'dbSAICBPOFactura.vwFactConceptoFronting' table. You can move, or remove it, as needed.
                this.vwFactConceptoFrontingTableAdapter.Fill(this.dbSAICBPOFactura.vwFactConceptoFronting);
                // TODO: This line of code loads data into the 'dbSAICBPOFactura.vwFactCatEstatusGlobal' table. You can move, or remove it, as needed.
                this.vwFactCatEstatusGlobalTableAdapter.Fill(this.dbSAICBPOFactura.vwFactCatEstatusGlobal);
                // TODO: This line of code loads data into the 'dbSAICBPOFactura.vwFactCatClaveProdServ' table. You can move, or remove it, as needed.
                this.vwFactCatClaveProdServTableAdapter.Fill(this.dbSAICBPOFactura.vwFactCatClaveProdServ);
                // TODO: This line of code loads data into the 'dbSAICBPOFactura.vwcatFronting' table. You can move, or remove it, as needed.
                this.vwcatFrontingTableAdapter.Fill(this.dbSAICBPOFactura.vwcatFronting);

                // Set column widths according to their contents. 
                cbxServicio.Properties.View.BestFitColumns();
                // Specify the total dropdown width. 
                cbxServicio.Properties.PopupFormWidth = 800;
                // Set column widths according to their contents. 
                cbxFronting.Properties.View.BestFitColumns();
                // Specify the total dropdown width. 
                cbxFronting.Properties.PopupFormWidth = 800;
                // Set column widths according to their contents. 

                ActivarDesactivarBotones(true);
                ActivarControlesInfo(false);     //desactivar controles formulario

                tipoOperacionABC = Constantes.TipoOperacionABC.Ninguno; //tipo de Operacion ABC = NIGUNO
                splashSMCargando.CloseWaitForm();
            }
            catch (Exception ex)
            {
                splashSMCargando.CloseWaitForm();
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close(); //SALIR
        }

        private void btnCaptura_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ActivarDesactivarBotones(true);
            ActivarControlesInfo(false);      //desactivar controles formulario
            tipoOperacionABC = Constantes.TipoOperacionABC.Ninguno; //tipo de Operacion ABC = NIGUNO
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tipoOperacionABC = Constantes.TipoOperacionABC.Nuevo; //tipo de Operacion ABC = NUEVO
            LimpiarControlesInfo();      //inicializar controles formulario
            ActivarDesactivarBotones(false);
            ActivarControlesInfo(true);      //activar controles formulario
        }

        private void gvrCatalogo_DoubleClick(object sender, EventArgs e)
        {
            objMDetalle = ObtenerInfoAtributos();
            try
            {
                if (objMDetalle != null)
                {
                    MostrarInfo(objMDetalle);
                    ActivarDesactivarBotones(false);        //desactivar botones
                    ActivarControlesInfo(true);      //activar controles formulario
                    tipoOperacionABC = Constantes.TipoOperacionABC.Editar; //tipo de Operacion ABC = EDITAR
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private FactConceptoTenedora ObtenerInfoAtributos()
        {
            //si el usuario seleccionó un renglon, entonces regresar el valor IdTransaccionBanco
            if (gridView3.FocusedRowHandle >= 0)
            {
                //obtener la información del renglon completo
                DataRow row = gridView3.GetDataRow(gridView3.FocusedRowHandle);
                //asignar InfoDetalle Solicitud Cheque Masivo
                return FactConceptoTenedoraDB.ObtenerInfoDetalleFactConceptoTenedora(row);
            }
            else
                return null;       //si no se ha seleccionado un renglon válido, entonces regresar 0
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (Validator.IsPresent(cbxServicio) && Validator.IsPresent(cbxFronting) && Validator.IsPresent(cbxEstatus))
                {
                    objMDetalle = AsignarInfo();

                    if (objMDetalle != null)
                    {
                        if (tipoOperacionABC == Constantes.TipoOperacionABC.Nuevo)
                        {
                            Int64? pId = 0;
                            this.spSoloRespuesta1.stpFactInsConceptoTenedora(objMDetalle.IdFactClaveProduServ, objMDetalle.IdTenedoraMatriz,
                                                                         objMDetalle.DescConceptoInterno, objMDetalle.IdEstatus, OperadorBD.OperadorGlobal.NombreUsuario, ref pId);

                            if (pId == -1)        //si existe Id asignado => Alta del cliente exitosa
                                XtraMessageBox.Show("¡El Concepto ya Existe!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else if (pId == 0)        //si existe Id asignado => Alta del cliente exitosa
                                XtraMessageBox.Show("¡El alta del Concepto NO ha sido exitosa!\nContacte a Sistemas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else
                            {
                               txtId.Text = pId.ToString();

                                ActivarDesactivarBotones(true);
                                ActivarControlesInfo(false);      //desactivar controles formulario
                                tipoOperacionABC = Constantes.TipoOperacionABC.Ninguno; //tipo de Operacion ABC = NIGUNO
                                XtraMessageBox.Show("¡El alta del Concepto ha sido exitosa!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                // actualizar Table Adapter
                                // TODO: This line of code loads data into the 'dbSAICBPOFactura.vwFactConceptoTenedora' table. You can move, or remove it, as needed.
                                this.vwFactConceptoFrontingTableAdapter.Fill(this.dbSAICBPOFactura.vwFactConceptoFronting);
                            }
                        }
                        else if (tipoOperacionABC == Constantes.TipoOperacionABC.Editar)
                        {
                            int? intNoRegistrosAfectados = 0;
                            this.spSoloRespuesta1.stpFactUpdConceptoTenedora(objMDetalle.IdFactConceptoTenedora, objMDetalle.IdFactClaveProduServ,
                            objMDetalle.IdTenedoraMatriz, objMDetalle.DescConceptoInterno, objMDetalle.IdEstatus, OperadorBD.OperadorGlobal.NombreUsuario, ref intNoRegistrosAfectados);

                            if (intNoRegistrosAfectados == -1)        //si existe Id asignado => Alta del cliente exitosa
                                XtraMessageBox.Show("¡El Concepto ya Existe!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else if (intNoRegistrosAfectados == 0)        //si existe Id asignado => Alta del cliente exitosa
                                XtraMessageBox.Show("¡La modificación del Concepto NO ha sido exitosa!\nContacte a Sistemas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else
                            {
                               ActivarDesactivarBotones(true);
                                ActivarControlesInfo(false);      //desactivar controles formulario
                                tipoOperacionABC = Constantes.TipoOperacionABC.Ninguno; //tipo de Operacion ABC = NIGUNO
                                XtraMessageBox.Show("¡La modificación del Concepto ha sido exitosa!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                // TODO: This line of code loads data into the 'dbSAICBPOFactura.vwFactConceptoTenedora' table. You can move, or remove it, as needed.
                                this.vwFactConceptoFrontingTableAdapter.Fill(this.dbSAICBPOFactura.vwFactConceptoFronting);
                            }
                        }
                    }   //if (objCliente != null)
                    else
                        XtraMessageBox.Show("¡La asignación de información del cliente NO ha sido exitosa!\nContacte a Sistemas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxFronting_EditValueChanged(object sender, EventArgs e)
        {
            gridView3.ActiveFilter.Clear();
            if (cbxFronting.EditValue != null)
            {
                if (cbxFronting.EditValue.ToString() != "-1")
                {
                    ColumnView view = gridView3;
                    ViewColumnFilterInfo viewFilterInfo = new ViewColumnFilterInfo(view.Columns["IdTenedoraMatriz"],
                    new ColumnFilterInfo("[IdTenedoraMatriz] = " + cbxFronting.EditValue.ToString(), ""));
                    gridView3.ActiveFilter.Add(viewFilterInfo);
                }
            }
        }
    }
}