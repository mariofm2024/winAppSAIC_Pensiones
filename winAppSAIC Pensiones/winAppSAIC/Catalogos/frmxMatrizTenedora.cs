using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using winAppSAIC.UtileriasLocal;
using compCatalogosSAIC;

namespace winAppSAIC.Catalogos
{
    public partial class frmxMatrizTenedora : DevExpress.XtraEditors.XtraForm
    {
        public frmxMatrizTenedora()
        {
            InitializeComponent();
        }

        #region "Variables Globales"
        private Constantes.TipoOperacionABC tipoOperacionABC = Constantes.TipoOperacionABC.Ninguno;
        #endregion

        private MatrizTenedora AsignarInfoMatrizTenedora()
        {
            MatrizTenedora objMT = null;

            try
            {
                objMT = new MatrizTenedora();
                objMT.IdMatrizTenedora = Convert.ToInt32(IdMatrizTenedoraTextEdit.Text.Replace(",", ""));
                objMT.RazonSocial = RazonSocialTextEdit.Text;
                objMT.NombreComercial = NombreComercialTextEdit.Text;
                objMT.RFC = RFCTextEdit.Text;
                objMT.IdActividadComercial = Convert.ToInt16(IdActividadComercialLookUpEdit.EditValue);
                objMT.Calle = CalleTextEdit.Text;
                objMT.NoExterior = NoExteriorTextEdit.Text;
                objMT.NoInterior = NoInteriorTextEdit.Text;
                objMT.Colonia = ColoniaTextEdit.Text;
                objMT.CodigoPostal = CodigoPostalTextEdit.Text;
                objMT.IdPais = Convert.ToInt16(IdPaisLookUpEdit.EditValue);
                objMT.IdEstado = Convert.ToInt16(IdEstadoLookUpEdit.EditValue);
                objMT.NombreDelegacionMunicipio = NombreDelegacionMunicipioTextEdit.Text;
                objMT.NombrePoblacionCiudad = NombrePoblacionCiudadTextEdit.Text;
                objMT.RepresentanteLegal = txtRepresentanteLegal.Text;
                objMT.Telefono1 = Telefono1TextEdit.Text;
                objMT.Telefono2 = Telefono2TextEdit.Text;
                objMT.CorreoElectronico = CorreoElectronicoTextEdit.Text;
                objMT.IdClasifTenedora = Convert.ToInt16(IdClasifTenedoraLookUpEdit.EditValue);
                objMT.IdRegion = IdRegionLookUpEdit.EditValue.ToString();
                objMT.Subcontratacion = Convert.ToBoolean(chkSubcontratacion.Checked);
                objMT.IdEstatus = Convert.ToByte(IdEstatusLookUpEdit.EditValue);
                objMT.ASimilados = Convert.ToBoolean(chkAsimilados.Checked);
                objMT.IVA8 = Convert.ToBoolean(chkIVA8.Checked);
                objMT.IdRFSAT = cbRF.EditValue.ToString();
                objMT.RegimenCapital = RegimenCapitaltextEdit.Text.Trim();
                objMT.VersionCFDI = txtVersion.Text.Trim();
                objMT.IdAsimilados = Convert.ToInt16(txtIdAsimilados.Text.Trim());
            }
            catch (Exception ex)
            {
                return null;
            }
            return objMT;
        }

        string Fronting = "";

        #region "Metodos Propios"
        private void GuardarRegistros()
        {
            if (Validator.IsPresent(RazonSocialTextEdit) && Validator.IsPresent(NombreComercialTextEdit) &&
                Validator.IsPresent(RFCTextEdit) && Validator.IsPresent(IdActividadComercialLookUpEdit) &&
                Validator.IsPresent(CalleTextEdit) && Validator.IsPresent(NoExteriorTextEdit) &&
                Validator.IsPresent(ColoniaTextEdit) && Validator.IsPresent(CodigoPostalTextEdit) &&
                Validator.IsPresent(IdEstadoLookUpEdit) && Validator.IsPresent(IdPaisLookUpEdit) &&
                Validator.IsPresent(IdClasifTenedoraLookUpEdit) && Validator.IsPresent(IdRegionLookUpEdit) &&
                Validator.IsPresent(IdEstatusLookUpEdit) && Validator.IsPresent(cbRF))
            {

                if (NoInteriorTextEdit.EditValue.ToString().Trim().Length == 0)
                    NoInteriorTextEdit.EditValue = "";

                if (NombreDelegacionMunicipioTextEdit.EditValue.ToString().Trim().Length == 0)
                    NombreDelegacionMunicipioTextEdit.EditValue = "";

                if (NombrePoblacionCiudadTextEdit.EditValue.ToString().Trim().Length == 0)
                    NombrePoblacionCiudadTextEdit.EditValue = "";

                if (Telefono1TextEdit.EditValue.ToString().Trim().Length == 0)
                    Telefono1TextEdit.EditValue = "";

                if (txtRepresentanteLegal.EditValue.ToString().Trim().Length == 0)
                    txtRepresentanteLegal.EditValue = "";

                if (Telefono2TextEdit.EditValue.ToString().Trim().Length == 0)
                    Telefono2TextEdit.EditValue = "";

                if (CorreoElectronicoTextEdit.EditValue.ToString().Trim().Length == 0)
                    CorreoElectronicoTextEdit.EditValue = "";
                if (cbRF.EditValue.ToString().Trim().Length == 0)
                    cbRF.EditValue = "";

                this.matrizTenedoraBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dbSAIC_Catalogos);

                MatrizTenedora objMT = AsignarInfoMatrizTenedora();
                if (objMT != null)
                {
                    Int32? Id = 0;
                    if (tipoOperacionABC == Constantes.TipoOperacionABC.Nuevo)
                    {
                        this.matrizTenedoraTableAdapter.Insert(objMT.RazonSocial, objMT.NombreComercial, objMT.RFC, objMT.IdActividadComercial, objMT.Calle,
                                                               objMT.NoExterior, objMT.NoInterior, objMT.Colonia, objMT.CodigoPostal, objMT.IdPais,
                                                               objMT.IdEstado, objMT.NombreDelegacionMunicipio, objMT.NombrePoblacionCiudad, objMT.RepresentanteLegal, objMT.Telefono1,
                                                               objMT.Telefono2, objMT.CorreoElectronico, objMT.IdEstatus,
                                                               objMT.IdRegion, objMT.Subcontratacion, objMT.ASimilados, objMT.IVA8, objMT.IdRFSAT, objMT.IdClasifTenedora, objMT.RegimenCapital, objMT.VersionCFDI, OperadorBD.OperadorGlobal.NombreUsuario, objMT.IdAsimilados);
                    }
                    else if (tipoOperacionABC == Constantes.TipoOperacionABC.Editar)
                    {
                        this.matrizTenedoraTableAdapter.Update(objMT.RazonSocial, objMT.NombreComercial, objMT.RFC, objMT.IdActividadComercial, objMT.Calle,
                                                               objMT.NoExterior, objMT.NoInterior, objMT.Colonia, objMT.CodigoPostal, objMT.IdPais,
                                                               objMT.IdEstado, objMT.NombreDelegacionMunicipio, objMT.NombrePoblacionCiudad, objMT.RepresentanteLegal, objMT.Telefono1,
                                                               objMT.Telefono2, objMT.CorreoElectronico, objMT.IdEstatus,
                                                               objMT.IdRegion, objMT.Subcontratacion, objMT.ASimilados, objMT.IVA8, objMT.IdRFSAT, objMT.IdClasifTenedora, objMT.RegimenCapital, objMT.VersionCFDI,  objMT.IdAsimilados,OperadorBD.OperadorGlobal.NombreUsuario,  objMT.IdMatrizTenedora);

                    }


                    if (txtLogo.EditValue.ToString().Trim().Length != 0)
                    {
                        // Asignando el valor de la imagen
                        piclogo.Image = Image.FromFile(txtLogo.Text);
                        // Stream usado como buffer
                        System.IO.MemoryStream ms = new System.IO.MemoryStream();
                        // Se guarda la imagen en el buffer
                        piclogo.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        // Se extraen los bytes del buffer para asignarlos como valor para el 
                        spSoloRespuesta1.stpFactInsTenedoraLogotipo(Convert.ToInt32(IdMatrizTenedoraTextEdit.Text.Replace(",", "")), ms.GetBuffer(), 0);

                        txtLogo.EditValue = "";
                    }
                    if (Fronting != "")
                        spSoloRespuesta1.stpFactInsTenedoraFronting(Convert.ToInt32(IdMatrizTenedoraTextEdit.Text.Replace(",", "")), Fronting, OperadorBD.OperadorGlobal.NombreUsuario, 0);

                    XtraMessageBox.Show("¡Los Cambios se realizaron correctamente!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    XtraMessageBox.Show("¡Error en la Actualización intentelo más tarde!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion


        private void frmxMatrizTenedora_Load(object sender, EventArgs e)
        {
            try
            {
                splashSMCargando.ShowWaitForm();
                // TODO: This line of code loads data into the 'dbSAIC_Catalogos.stpSelPais' table. You can move, or remove it, as needed.
                this.stpSelPaisTableAdapter.Fill(this.dbSAIC_Catalogos.stpSelPais);
                // TODO: This line of code loads data into the 'dbSAIC_Catalogos.stpSelEstado' table. You can move, or remove it, as needed.
                this.stpSelEstadoTableAdapter.Fill(this.dbSAIC_Catalogos.stpSelEstado);
                // TODO: This line of code loads data into the 'dbSAIC_Catalogos.Estatus' table. You can move, or remove it, as needed.
                this.estatusTableAdapter.Fill(this.dbSAIC_Catalogos.Estatus);
                // TODO: This line of code loads data into the 'dbSAIC_Catalogos.Region' table. You can move, or remove it, as needed.
                this.regionTableAdapter.Fill(this.dbSAIC_Catalogos.Region);
                // TODO: This line of code loads data into the 'dbSAIC_Catalogos.ClasifTenedora' table. You can move, or remove it, as needed.
                this.clasifTenedoraTableAdapter.Fill(this.dbSAIC_Catalogos.ClasifTenedora);
                // TODO: This line of code loads data into the 'dbSAIC_Catalogos.ActividadComercial' table. You can move, or remove it, as needed.
                this.actividadComercialTableAdapter.Fill(this.dbSAIC_Catalogos.ActividadComercial);
                // TODO: This line of code loads data into the 'dbSAIC_Catalogos.MatrizTenedora' table. You can move, or remove it, as needed.
                this.matrizTenedoraTableAdapter.Fill(this.dbSAIC_Catalogos.MatrizTenedora);
                // TODO: This line of code loads data into the 'dbSAICBPOFactura.vwcatFronting' table. You can move, or remove it, as needed.
                this.vwcatFrontingTableAdapter.Fill(this.dbSAICBPOFactura.vwcatFronting);
                // TODO: This line of code loads data into the 'dbSAIC_CatalogosSAT.vwRegimenFiscalSAT' table. You can move, or remove it, as needed.
                this.vwRegimenFiscalSATTableAdapter.Fill(this.dbSAIC_CatalogosSAT.vwRegimenFiscalSAT);

                if (OperadorBD.OperadorGlobal.AreaOperativa.Contains("ADMIN"))
                    pRazonSocialToolStripTextBox.Focus();
                else
                {
                    piclogo.ReadOnly = true;
                    txtLogo.ReadOnly = true;
                    RazonSocialTextEdit.ReadOnly = true;
                    NombreComercialTextEdit.ReadOnly = true;
                    RFCTextEdit.ReadOnly = true;
                    IdActividadComercialLookUpEdit.ReadOnly = true;
                    CalleTextEdit.ReadOnly = true;
                    NoExteriorTextEdit.ReadOnly = true;
                    NoInteriorTextEdit.ReadOnly = true;
                    ColoniaTextEdit.ReadOnly = true;
                    CodigoPostalTextEdit.ReadOnly = true;
                    IdPaisLookUpEdit.ReadOnly = true;
                    IdEstadoLookUpEdit.ReadOnly = true;
                    NombreDelegacionMunicipioTextEdit.ReadOnly = true;
                    NombrePoblacionCiudadTextEdit.ReadOnly = true;
                    txtRepresentanteLegal.ReadOnly = true;
                    Telefono1TextEdit.ReadOnly = true;
                    Telefono2TextEdit.ReadOnly = true;
                    CorreoElectronicoTextEdit.ReadOnly = true;
                    IdClasifTenedoraLookUpEdit.ReadOnly = true;
                    IdRegionLookUpEdit.ReadOnly = true;
                    chkSubcontratacion.ReadOnly = true;
                    chkAsimilados.ReadOnly = true;
                    IdEstatusLookUpEdit.ReadOnly = true;
                    btnABC_ActividadComercial.Enabled = false;
                }
                splashSMCargando.CloseWaitForm();
            }
            catch (Exception ex)
            {
                splashSMCargando.CloseWaitForm();
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                AsignarConceptosMultiples();
                GuardarRegistros();     //guardar cambios
            }
            catch (DBConcurrencyException)
            {
                XtraMessageBox.Show("Error de concurrencia, NO fue insertardo/actualizado el registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DataException ex)
            {
                XtraMessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                //this.matrizTenedoraBindingSource.CancelEdit();
            }
            catch (SqlException ex)
            {
                XtraMessageBox.Show("Error Base de Datos: " + ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnABC_ActividadComercial_Click(object sender, EventArgs e)
        {
            Catalogos.frmxActividadComercial objActividadComercial = new Catalogos.frmxActividadComercial();
            objActividadComercial.ShowDialog();     //mostrar pantalla
            this.actividadComercialTableAdapter.Fill(this.dbSAIC_Catalogos.ActividadComercial); //actualizar Actividad Comercial
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                this.matrizTenedoraTableAdapter.FillByRazonSocial(this.dbSAIC_Catalogos.MatrizTenedora, pRazonSocialToolStripTextBox.Text);

                //si no existem registros, notificar
                if (this.dbSAIC_Catalogos.MatrizTenedora.Rows.Count == 0)
                {
                    XtraMessageBox.Show("Razón Social Matriz Tenedora NO encontrada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pRazonSocialToolStripTextBox.Text = "";     //limpiar textbox
                    this.matrizTenedoraTableAdapter.Fill(this.dbSAIC_Catalogos.MatrizTenedora);
                }
            }
            catch (FormatException)
            {
                XtraMessageBox.Show("Razón Social Matriz Tenedora NO es válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMostrarTodos_Click_1(object sender, EventArgs e)
        {
            this.matrizTenedoraTableAdapter.Fill(this.dbSAIC_Catalogos.MatrizTenedora);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            tipoOperacionABC = Constantes.TipoOperacionABC.Nuevo; //tipo de Operacion ABC = NUEVO
            RazonSocialTextEdit.Focus();    //colocar cursor en control
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                this.matrizTenedoraBindingSource.CancelEdit();
            }
            catch (System.Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pRazonSocialToolStripTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnBuscar_Click(sender, e);     //si existe ENTER entonces ejecutar metodo-evento click
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();        //cerrar pantalla
        }

        private void IdMatrizTenedoraTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (IdMatrizTenedoraTextEdit.Text != "")
            {
                //Lllenar Fronting
                MostrarConceptosMultiples(Convert.ToInt32(IdMatrizTenedoraTextEdit.Text.Replace(",", "")));
                tipoOperacionABC = Constantes.TipoOperacionABC.Editar; //tipo de Operacion ABC = EDITAR
            }
        }

        private void AsignarConceptosMultiples()
        {
            Fronting = "";
            foreach (var item in chkbFronting.Properties.Items.GetCheckedValues())
            {
                Fronting = Fronting + item.ToString() + ",";
            }

        }

        private void MostrarConceptosMultiples(Int32 IdTenedora)
        {
            Fronting = "";
            try
            {

                this.stpFactSelTenedoraFrontingTableAdapter1.Fill(this.dbSAICBPOFactura.stpFactSelTenedoraFronting, IdTenedora);

                if (this.dbSAICBPOFactura.stpFactSelTenedoraFronting.Rows.Count > 0)
                {
                    for (int i = 0; i < this.dbSAICBPOFactura.stpFactSelTenedoraFronting.Rows.Count; i++)
                    {
                        Fronting = Fronting + this.dbSAICBPOFactura.stpFactSelTenedoraFronting.Rows[i][1].ToString() + ",";
                    }
                }
                chkbFronting.Focus();
                chkbFronting.SetEditValue(Fronting);

            }
            catch (System.Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void spinEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ofdComprobante.Filter = "JPEG Files|*.JPEG";
            ofdComprobante.ShowDialog();
            txtLogo.Text = ofdComprobante.FileName;
        }
    }
}