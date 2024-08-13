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

namespace winAppSAIC.Catalogos
{
    public partial class frmxClientesMatriz : DevExpress.XtraEditors.XtraForm
    {
        public frmxClientesMatriz()
        {
            InitializeComponent();
        }

        #region "Variables Globales"
        private Constantes.TipoOperacionABC tipoOperacionABC = Constantes.TipoOperacionABC.Ninguno;

        #endregion

        #region "Metodos Propios"
        private ClienteMatriz AsignarInfoCliente()
        {
            ClienteMatriz objCliente = null;

            try
            {
                objCliente = new ClienteMatriz();

                objCliente.IdCliente = Convert.ToInt32(txtIdCliente.Text);
                objCliente.RazonSocial = txtRazonSocial.Text.Trim();
                objCliente.NombreComercial = txtNombreComercial.Text.Trim();
                objCliente.RFC = txtRFC.Text.Trim();
                objCliente.IdActividadComercial = Convert.ToInt16(cboIdActividadComercial.EditValue);
                //Domicilio Fiscal
                objCliente.Calle = txtCalle.Text.Trim();
                objCliente.NoExterior = txtNoExterior.Text.Trim();
                objCliente.NoInterior = txtNoInterior.Text.Trim();
                objCliente.Colonia = txtColonia.Text.Trim();
                objCliente.CodigoPostal = txtCodigoPostal.Text.Trim();
                objCliente.IdEstado = Convert.ToInt32(cboIdEstado.EditValue);
                objCliente.IdPais = Convert.ToInt16(cboIdPais.EditValue);
                objCliente.NombreDelegacionMunicipio = txtNombreDelegacionMunicipio.Text.Trim();
                objCliente.NombrePoblacionCiudad = txtNombrePoblacionCiudad.Text.Trim();
                //Contacto
                objCliente.RepresentanteLegal = txtRepresentanteLegal.Text.Trim();
                objCliente.Contacto = txtContacto.Text.Trim();
                objCliente.Telefono1 = txtTelefono1.Text.Trim();
                objCliente.Telefono2 = txtTelefono2.Text.Trim();
                objCliente.CorreoElectronico = txtCorreoElectronico.Text.Trim();
                objCliente.PaginaWeb = txtPaginaWeb.Text.Trim();
                //Otros
                objCliente.IdEstatus = Convert.ToByte(cboIdEstatus.EditValue);
                objCliente.FechaBaja = Convert.ToDateTime(calFechaBaja.EditValue);
                
            }
            catch (Exception ex)
            {
                return null;            
            }
            return objCliente;
        }

        private void MostrarInfoCliente(ClienteMatriz objCliente)
        {
            txtIdCliente.Text = objCliente.IdCliente.ToString();
            txtRazonSocial.Text = objCliente.RazonSocial;
            txtNombreComercial.Text = objCliente.NombreComercial;
            txtRFC.Text = objCliente.RFC;
            cboIdActividadComercial.EditValue = objCliente.IdActividadComercial;
            //Domicilio Fiscal
            txtCalle.Text = objCliente.Calle;
            txtNoExterior.Text = objCliente.NoExterior;
            txtNoInterior.Text = objCliente.NoInterior;
            txtColonia.Text = objCliente.Colonia;
            txtCodigoPostal.Text = objCliente.CodigoPostal;
            cboIdEstado.EditValue = objCliente.IdEstado;
            cboIdPais.EditValue = objCliente.IdPais;
            txtNombreDelegacionMunicipio.Text = objCliente.NombreDelegacionMunicipio;
            txtNombrePoblacionCiudad.Text = objCliente.NombrePoblacionCiudad;
            //Contacto
            txtRepresentanteLegal.Text = objCliente.RepresentanteLegal;
            txtContacto.Text = objCliente.Contacto;
            txtTelefono1.Text = objCliente.Telefono1;
            txtTelefono2.Text = objCliente.Telefono2;
            txtCorreoElectronico.Text = objCliente.CorreoElectronico;
            txtPaginaWeb.Text = objCliente.PaginaWeb;
            //Otros
            cboIdEstatus.EditValue = objCliente.IdEstatus;
            calFechaBaja.EditValue = objCliente.FechaBaja;
            
        }

        private void ActivarControlesInfoCliente(bool bFlag)
        {
            //txtIdCliente.Enabled = bFlag;
            txtRazonSocial.Enabled = bFlag;
            txtNombreComercial.Enabled = bFlag;
            txtRFC.Enabled = bFlag;
            cboIdActividadComercial.Enabled = bFlag;
            //Domicilio Fiscal
            txtCalle.Enabled = bFlag;
            txtNoExterior.Enabled = bFlag;
            txtNoInterior.Enabled = bFlag;
            txtColonia.Enabled = bFlag;
            txtCodigoPostal.Enabled = bFlag;
            cboIdEstado.Enabled = bFlag;
            cboIdPais.Enabled = bFlag;
            txtNombreDelegacionMunicipio.Enabled = bFlag;
            txtNombrePoblacionCiudad.Enabled = bFlag;
            //Contacto
            txtRepresentanteLegal.Enabled = bFlag;
            txtContacto.Enabled = bFlag;
            txtTelefono1.Enabled = bFlag;
            txtTelefono2.Enabled = bFlag;
            txtCorreoElectronico.Enabled = bFlag;
            txtPaginaWeb.Enabled = bFlag;
            //Otros
            cboIdEstatus.Enabled = bFlag;
            btnABC_ActividadComercial.Enabled = bFlag;
        }

        private void LimpiarControlesInfoCliente()
        {
            txtIdCliente.Text = "0";
            txtRazonSocial.Text = string.Empty;
            txtNombreComercial.Text = string.Empty;
            txtRFC.Text = string.Empty;
            cboIdActividadComercial.EditValue = -1;
            //Domicilio Fiscal
            txtCalle.Text = string.Empty;
            txtNoExterior.Text = string.Empty;
            txtNoInterior.Text = string.Empty;
            txtColonia.Text = string.Empty;
            txtCodigoPostal.Text = string.Empty;
            cboIdEstado.EditValue = -1;
            cboIdPais.EditValue = -1;
            txtNombreDelegacionMunicipio.Text = string.Empty;
            txtNombrePoblacionCiudad.Text = string.Empty;
            //Contacto
            txtRepresentanteLegal.Text = string.Empty;
            txtContacto.Text = string.Empty;
            txtTelefono1.Text = string.Empty;
            txtTelefono2.Text = string.Empty;
            txtCorreoElectronico.Text = string.Empty;
            txtPaginaWeb.Text = string.Empty;
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
            cboIdClienteProveedor.Enabled = bFlag;
        }
        #endregion
        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();        //cerrar pantalla
        }

        private void frmxClientes_Load(object sender, EventArgs e)
        {
            try
            {
                splashSMCargando.ShowWaitForm();
                // TODO: This line of code loads data into the 'dbSAIC_Catalogos.vwCatEstatusCliente' table. You can move, or remove it, as needed.
                this.vwCatEstatusClienteTableAdapter.Fill(this.dbSAIC_Catalogos.vwCatEstatusCliente);
                // TODO: This line of code loads data into the 'dbSAIC_Catalogos.stpSelPais' table. You can move, or remove it, as needed.
                this.stpSelPaisTableAdapter.Fill(this.dbSAIC_Catalogos.stpSelPais);
                // TODO: This line of code loads data into the 'dbSAIC_Catalogos.ActividadComercial' table. You can move, or remove it, as needed.
                this.actividadComercialTableAdapter.Fill(this.dbSAIC_Catalogos.ActividadComercial);
                // TODO: This line of code loads data into the 'dbSAICBPOCatalogosDataSet.stpSelEstado' table. You can move, or remove it, as needed.
                this.stpSelEstadoTableAdapter.Fill(this.dbSAICBPOCatalogosDataSet.stpSelEstado);
                // TODO: This line of code loads data into the 'dbSAICBPOFactura.stpFactSelControlMatrizCliente' table. You can move, or remove it, as needed.
                this.stpFactSelControlMatrizClienteTableAdapter.Fill(this.dbSAICBPOFactura.stpFactSelControlMatrizCliente);

                // Set column widths according to their contents. 
                cboIdClienteProveedor.Properties.View.BestFitColumns();
                // Specify the total dropdown width. 
                cboIdClienteProveedor.Properties.PopupFormWidth = 800;
                // Set column widths according to their contents. 
                cboIdActividadComercial.Properties.View.BestFitColumns();
                // Specify the total dropdown width. 
                cboIdActividadComercial.Properties.PopupFormWidth = 800;


                ActivarDesactivarBotones(true);
                ActivarControlesInfoCliente(false);     //desactivar controles formulario

                tcgInformacionAdicional.SelectedTabPageIndex = 0;   //visualizar la primer pestaña
                tipoOperacionABC = Constantes.TipoOperacionABC.Ninguno; //tipo de Operacion ABC = NIGUNO

                splashSMCargando.CloseWaitForm();
            }
            catch (Exception ex)
            {
                splashSMCargando.CloseWaitForm();
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
                ClienteMatriz objCliente = ClienteMatrizBD.AsignarInfoCliente(row);

                if (objCliente != null)
                    MostrarInfoCliente(objCliente);
                else
                    XtraMessageBox.Show("¡La información del Grupo seleccionado no está disponible! \nContacte a Sistemas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            tipoOperacionABC = Constantes.TipoOperacionABC.Nuevo; //tipo de Operacion ABC = NUEVO
            tcgInformacionAdicional.SelectedTabPageIndex = 0;   //visualizar la primer pestaña

            LimpiarControlesInfoCliente();      //inicializar controles formulario
            ActivarDesactivarBotones(false);
            ActivarControlesInfoCliente(true);      //activar controles formulario
            txtRazonSocial.Focus();
            calFechaBaja.EditValue = new DateTime(1900, 1, 1);
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
                if (Validator.IsPresent(txtRazonSocial) && Validator.IsPresent(txtNombreComercial) &&
                    Validator.IsPresent(cboIdActividadComercial) && Validator.IsPresent(txtRFC) &&
                    Validator.IsPresent(cboIdEstatus))
                {
                    ClienteMatriz objCliente = AsignarInfoCliente();

                    if (objCliente != null)
                    {
                        if (tipoOperacionABC == Constantes.TipoOperacionABC.Nuevo)
                        {
                            int? pIdCliente = 0;
                            this.matrizClienteTableAdapter1.Insert(objCliente.RazonSocial,objCliente.NombreComercial,objCliente.RFC,
                                objCliente.IdActividadComercial, objCliente.Calle, objCliente.NoExterior, objCliente.NoInterior, 
                                objCliente.Colonia, objCliente.CodigoPostal, objCliente.IdPais, objCliente.IdEstado,
                                objCliente.NombreDelegacionMunicipio, objCliente.NombrePoblacionCiudad,objCliente.RepresentanteLegal,
                                objCliente.Contacto, objCliente.Telefono1, objCliente.Telefono2, objCliente.CorreoElectronico, 
                                objCliente.PaginaWeb, objCliente.IdEstatus, OperadorBD.OperadorGlobal.NombreUsuario, ref pIdCliente);
                            

                            if (pIdCliente == 0)        //si existe Id asignado => Alta del cliente exitosa
                                XtraMessageBox.Show("¡El alta del Grupo NO ha sido exitosa!\nContacte a Sistemas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else
                            {
                                txtIdCliente.Text = pIdCliente.ToString();
                                ActivarDesactivarBotones(true);
                                ActivarControlesInfoCliente(false);      //desactivar controles formulario
                                tipoOperacionABC = Constantes.TipoOperacionABC.Ninguno; //tipo de Operacion ABC = NIGUNO
                                XtraMessageBox.Show("¡El alta del Grupo ha sido exitosa!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                // actualizar Table Adapter
                                this.stpFactSelControlMatrizClienteTableAdapter.Fill(this.dbSAICBPOFactura.stpFactSelControlMatrizCliente);
                            }
                        }
                        else if (tipoOperacionABC == Constantes.TipoOperacionABC.Editar)
                        {
                            int intNoRegistrosAfectados =
                                this.matrizClienteTableAdapter1.Update(objCliente.RazonSocial, objCliente.NombreComercial,
                                objCliente.RFC, objCliente.IdActividadComercial, objCliente.Calle, objCliente.NoExterior,
                                objCliente.NoInterior, objCliente.Colonia, objCliente.CodigoPostal, objCliente.IdPais, 
                                objCliente.IdEstado,objCliente.NombreDelegacionMunicipio, objCliente.NombrePoblacionCiudad,
                                objCliente.RepresentanteLegal,objCliente.Contacto, objCliente.Telefono1, objCliente.Telefono2, 
                                objCliente.CorreoElectronico, objCliente.PaginaWeb, objCliente.FechaBaja, objCliente.IdEstatus,
                                OperadorBD.OperadorGlobal.NombreUsuario, Convert.ToInt32(txtIdCliente.Text));

                            if (intNoRegistrosAfectados == 0)        //si existe Id asignado => Alta del cliente exitosa
                                XtraMessageBox.Show("¡La modificación del Grupo NO ha sido exitosa!\nContacte a Sistemas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else
                            {
                                ActivarDesactivarBotones(true);
                                ActivarControlesInfoCliente(false);      //desactivar controles formulario
                                tipoOperacionABC = Constantes.TipoOperacionABC.Ninguno; //tipo de Operacion ABC = NIGUNO
                                XtraMessageBox.Show("¡La modificación del Grupo ha sido exitosa!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                // actualizar Table Adapter
                                this.stpFactSelControlMatrizClienteTableAdapter.Fill(this.dbSAICBPOFactura.stpFactSelControlMatrizCliente);
                            }
                        }
                    }   //if (objCliente != null)
                    else
                        XtraMessageBox.Show("¡La asignación de información del Grupo NO ha sido exitosa!\nContacte a Sistemas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtIdCliente.Text) > 0)
            {
                ActivarDesactivarBotones(false);        //desactivar botones
                ActivarControlesInfoCliente(true);      //activar controles formulario
                tipoOperacionABC = Constantes.TipoOperacionABC.Editar; //tipo de Operacion ABC = EDITAR
                tcgInformacionAdicional.SelectedTabPageIndex = 0;   //visualizar la primer pestaña
            }
            else
                XtraMessageBox.Show("No ha seleccionado un Grupo para modificar su información.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
       
        private void btnABC_ActividadComercial_Click(object sender, EventArgs e)
        {
            Catalogos.frmxActividadComercial objActividadComercial = new Catalogos.frmxActividadComercial();
            objActividadComercial.ShowDialog();     //mostrar pantalla
            this.actividadComercialTableAdapter.Fill(this.dbSAIC_Catalogos.ActividadComercial); //actualizar Table Adapter
        }

        private void cboIdEstatus_EditValueChanged(object sender, EventArgs e)
        {
            //si el estatus es ACTIVO, asignar fecha baja = 01/01/1900
            if (Convert.ToByte(cboIdEstatus.EditValue).Equals(2))
                calFechaBaja.EditValue = new DateTime(1900, 1, 1);
            else
                calFechaBaja.EditValue = DateTime.Now.Date;
        }

    }
}