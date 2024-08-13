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

namespace winAppSAIC.Catalogos
{
    public partial class frmxPromotores : DevExpress.XtraEditors.XtraForm
    {
        public frmxPromotores()
        {
            InitializeComponent();
        }


        #region "Variables Globales"
        private Constantes.TipoOperacionABC tipoOperacionABC = Constantes.TipoOperacionABC.Ninguno;
        private Promotor objMDetalle = null;
        #endregion

        #region "Metodos Propios"
        private Promotor AsignarInfo()
        {
            Promotor objAtributos = null;

            try
            {
                objAtributos = new Promotor();

                objAtributos.IdPromotor = Convert.ToInt16(txtId.Text.Replace(",", ""));
                objAtributos.Nombre = txtNombre.Text.Trim();
                objAtributos.APaterno = txtAPaterno.Text.Trim();
                objAtributos.AMaterno = txtAMaterno.Text.Trim();
                objAtributos.CorreoElectronico = txtEMAil.Text.Trim();
                objAtributos.Telefono = txtTelefono.Text.Trim();
                objAtributos.IdEstatus = Convert.ToInt16(cbxEstatus.EditValue);
            }
            catch (Exception ex)
            {
                return null;
            }
            return objAtributos;
        }

        private void MostrarInfo(Promotor objAtributos)
        {
            txtId.Text = objAtributos.IdPromotor.ToString();
            txtNombre.EditValue = objAtributos.Nombre;
            txtAPaterno.EditValue = objAtributos.APaterno;
            txtAMaterno.EditValue = objAtributos.AMaterno;
            txtEMAil.EditValue = objAtributos.CorreoElectronico;
            txtTelefono.EditValue = objAtributos.Telefono;
            cbxEstatus.EditValue = objAtributos.IdEstatus;
        }

        private void ActivarControlesInfo(bool bFlag)
        {
            txtNombre.Enabled = bFlag;
            txtAMaterno.Enabled = bFlag;
            txtAPaterno.Enabled = bFlag;
            txtEMAil.Enabled = bFlag;
            txtTelefono.Enabled = bFlag;
            cbxEstatus.Enabled = bFlag;
        }

        private void LimpiarControlesInfo()
        {
            txtId.Text = "0";
            txtNombre.Text = "";
            txtAPaterno.Text = "";
            txtAMaterno.Text = "";
            txtEMAil.Text = "";
            txtTelefono.Text = "";
            cbxEstatus.EditValue = -1;
        }

        private void ActivarDesactivarBotones(bool bFlag)
        {
            btnNuevo.Enabled = bFlag;
            btnCaptura.Enabled = !bFlag;
            btnGuardar.Enabled = !bFlag;
        }
        #endregion


        private void GuardarRegistros()
        {
            this.Validate();
            this.promotorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbSAIC_Catalogos);
        }

        private void promotorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                GuardarRegistros();     //guardar cambios
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmxPromotores_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'dbSAIC_Catalogos.Promotor' table. You can move, or remove it, as needed.
                this.promotorTableAdapter.Fill(this.dbSAIC_Catalogos.Promotor);

                // TODO: This line of code loads data into the 'dbSAICBPOFactura.vwFactCatEstatusGlobal' table. You can move, or remove it, as needed.
                this.vwFactCatEstatusGlobalTableAdapter.Fill(this.dbSAICBPOFactura.vwFactCatEstatusGlobal);

                ActivarDesactivarBotones(true);
                ActivarControlesInfo(false);     //desactivar controles 
                tipoOperacionABC = Constantes.TipoOperacionABC.Ninguno; //tipo de Operacion ABC = NIGUNO
            }
            catch (System.Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();        //cerrar pantalla
        }

        private void frmxPromotores_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                //validar si existen cambios en el DataSet
                if (this.dbSAIC_Catalogos.HasChanges())
                {
                    if (XtraMessageBox.Show("¿Desea guardar los cambios realizados en los Promotores?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                        GuardarRegistros();     //guardar cambios
                    else
                        this.dbSAIC_Catalogos.RejectChanges(); //deshacer cambios
                }
            }
            catch (Exception ex)
            {
                e.Cancel = true;        //cancelar cerrado de pantalla
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close(); //SALIR
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tipoOperacionABC = Constantes.TipoOperacionABC.Nuevo; //tipo de Operacion ABC = NUEVO
            LimpiarControlesInfo();      //inicializar controles formulario
            ActivarDesactivarBotones(false);
            ActivarControlesInfo(true);      //activar controles formulario
        }

        private void btnCaptura_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ActivarDesactivarBotones(true);
            ActivarControlesInfo(false);      //desactivar controles formulario
            tipoOperacionABC = Constantes.TipoOperacionABC.Ninguno; //tipo de Operacion ABC = NIGUNO
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (Validator.IsPresent(txtNombre) && Validator.IsPresent(txtAPaterno) && Validator.IsPresent(txtAMaterno))
                {
                    objMDetalle = AsignarInfo();

                    if (objMDetalle != null)
                    {
                        if (tipoOperacionABC == Constantes.TipoOperacionABC.Nuevo)
                        {
                            Int32? pId = 0;
                            this.promotorTableAdapter.Insert(objMDetalle.Nombre, objMDetalle.APaterno, objMDetalle.AMaterno, objMDetalle.CorreoElectronico, objMDetalle.Telefono, OperadorBD.OperadorGlobal.NombreUsuario, ref pId);

                            if (pId == -1)        //si existe Id asignado => Alta del cliente exitosa
                                XtraMessageBox.Show("¡El Promotor ya Existe!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else if (pId == 0)        //si existe Id asignado => Alta del cliente exitosa
                                XtraMessageBox.Show("¡El alta del Promotor NO ha sido exitosa!\nContacte a Sistemas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else
                            {
                                txtId.Text = pId.ToString();

                                ActivarDesactivarBotones(true);
                                ActivarControlesInfo(false);      //desactivar controles formulario
                                tipoOperacionABC = Constantes.TipoOperacionABC.Ninguno; //tipo de Operacion ABC = NIGUNO
                                XtraMessageBox.Show("¡El alta del Promotor ha sido exitosa!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                // actualizar Table Adapter
                                // TODO: This line of code loads data into the 'dbSAICBPOFactura.vwFactConceptoTenedora' table. You can move, or remove it, as needed.
                                this.promotorTableAdapter.Fill(this.dbSAIC_Catalogos.Promotor);
                            }
                        }
                        else if (tipoOperacionABC == Constantes.TipoOperacionABC.Editar)
                        {
                            int? intNoRegistrosAfectados = 0;
                            this.promotorTableAdapter.Update(objMDetalle.Nombre, objMDetalle.APaterno, objMDetalle.AMaterno, objMDetalle.CorreoElectronico, objMDetalle.Telefono, objMDetalle.IdEstatus, objMDetalle.IdPromotor, OperadorBD.OperadorGlobal.NombreUsuario, ref intNoRegistrosAfectados);

                            if (intNoRegistrosAfectados == -1)        //si existe Id asignado => Alta del cliente exitosa
                                XtraMessageBox.Show("¡El Promotor ya Existe!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else if (intNoRegistrosAfectados == 0)        //si existe Id asignado => Alta del cliente exitosa
                                XtraMessageBox.Show("¡La modificación del Promotor NO ha sido exitosa!\nContacte a Sistemas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else
                            {
                                ActivarDesactivarBotones(true);
                                ActivarControlesInfo(false);      //desactivar controles formulario
                                tipoOperacionABC = Constantes.TipoOperacionABC.Ninguno; //tipo de Operacion ABC = NIGUNO
                                XtraMessageBox.Show("¡La modificación del Promotor ha sido exitosa!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                // TODO: This line of code loads data into the 'dbSAICBPOFactura.vwFactConceptoTenedora' table. You can move, or remove it, as needed.
                                this.promotorTableAdapter.Fill(this.dbSAIC_Catalogos.Promotor);
                            }
                        }
                    }   //if (objCliente != null)
                    else
                        XtraMessageBox.Show("¡La asignación de información del Promotor NO ha sido exitosa!\nContacte a Sistemas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private Promotor ObtenerInfoAtributos()
        {
            //si el usuario seleccionó un renglon, entonces regresar el valor IdTransaccionBanco
            if (gridView3.FocusedRowHandle >= 0)
            {
                //obtener la información del renglon completo
                DataRow row = gridView3.GetDataRow(gridView3.FocusedRowHandle);
                //asignar InfoDetalle Solicitud Cheque Masivo
                return PromotorDB.ObtenerInfoPromotor(row);
            }
            else
                return null;       //si no se ha seleccionado un renglon válido, entonces regresar 0
        }
    }
}