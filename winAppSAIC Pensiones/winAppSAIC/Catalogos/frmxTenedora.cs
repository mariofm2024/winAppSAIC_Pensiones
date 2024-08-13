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
using System.Data.SqlClient;

namespace winAppSAIC.Catalogos
{
    public partial class frmxTenedora : DevExpress.XtraEditors.XtraForm
    {
        public frmxTenedora()
        {
            InitializeComponent();
        }

        #region "Metodos Propios"
        private void GuardarRegistros()
        {
            if (Validator.IsPresent(IdMatrizTenedoraLookUpEdit) && Validator.IsPresent(RazonSocialTextEdit) &&
                Validator.IsPresent(NombreComercialTextEdit) && Validator.IsPresent(IdActividadComercialLookUpEdit) &&
                Validator.IsPresent(RFCTextEdit) && Validator.IsPresent(CalleTextEdit) &&
                Validator.IsPresent(NoExteriorTextEdit) && Validator.IsPresent(ColoniaTextEdit) &&
                Validator.IsPresent(CodigoPostalTextEdit) && Validator.IsPresent(IdEstadoLookUpEdit) &&
                Validator.IsPresent(IdPaisLookUpEdit) && Validator.IsPresent(IdClasifTenedoraLookUpEdit) &&
                Validator.IsPresent(EntidadFederativaSATLookUpEdit) && Validator.IsPresent(IdTipoRegimenLookUpEdit) &&
                Validator.IsPresent(IdSubRegionLookUpEdit) && Validator.IsPresent(RegistroPatronalIMSSTextEdit) &&
                //Validator.IsPresent(IdClaseRiesgoIMSSLookUpEdit) && Validator.IsPresent(GrupoTextEdit) &&
                Validator.IsPresent(PrimaRiesgoTextEdit) && Validator.IsPresent(ImpuestoNominaTextEdit) &&
                Validator.IsPresent(ImpuestoAdicionalTextEdit) && //Validator.IsPresent(TipoCalculoImpuestoNominaTextEdit) &&
                Validator.IsPresent(IdEstatusLookUpEdit) && Validator.IsPresent(IdEstatusReportesLookUpEdit))
            {
                if (CURPTextEdit.EditValue.ToString().Trim().Length == 0)
                    CURPTextEdit.EditValue = "";

                if (NoInteriorTextEdit.EditValue.ToString().Trim().Length == 0)
                    NoInteriorTextEdit.EditValue = "";

                if (NombreDelegacionMunicipioTextEdit.EditValue.ToString().Trim().Length == 0)
                    NombreDelegacionMunicipioTextEdit.EditValue = "";

                if (NombrePoblacionCiudadTextEdit.EditValue.ToString().Trim().Length == 0)
                    NombrePoblacionCiudadTextEdit.EditValue = "";

                if (txtRepresentanteLegal.EditValue.ToString().Trim().Length == 0)
                    txtRepresentanteLegal.EditValue = "";

                if (Telefono1TextEdit.EditValue.ToString().Trim().Length == 0)
                    Telefono1TextEdit.EditValue = "";

                if (Telefono2TextEdit.EditValue.ToString().Trim().Length == 0)
                    Telefono2TextEdit.EditValue = "";

                if (CorreoElectronicoTextEdit.EditValue.ToString().Trim().Length == 0)
                    CorreoElectronicoTextEdit.EditValue = "";

                if (PaginaWebTextEdit.EditValue.ToString().Trim().Length == 0)
                    PaginaWebTextEdit.EditValue = "";

                if (GrupoTextEdit.EditValue.ToString().Trim().Length == 0)
                    GrupoTextEdit.EditValue = "";

                if (FraccionTextEdit.EditValue.ToString().Trim().Length == 0)
                    FraccionTextEdit.EditValue = "";

                if (txtNoIMSS.EditValue.ToString().Trim().Length == 0)
                    txtNoIMSS.EditValue = "";

                if (txtFonacot.EditValue.ToString().Trim().Length == 0)
                    txtFonacot.EditValue = "";

                this.tenedoraBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dbSAIC_Catalogos);
            }
        }
        #endregion

        private void frmxTenedora_Load(object sender, EventArgs e)
        {
            try
            {
                splashSMCargando.ShowWaitForm();
                // TODO: This line of code loads data into the 'dbSAIC_Catalogos.ClaseRiesgoIMSS' table. You can move, or remove it, as needed.
                this.claseRiesgoIMSSTableAdapter.Fill(this.dbSAIC_Catalogos.ClaseRiesgoIMSS);
                // TODO: This line of code loads data into the 'dbSAIC_Catalogos.TipoCalculoImpuestoNomina' table. You can move, or remove it, as needed.
                this.tipoCalculoImpuestoNominaTableAdapter.Fill(this.dbSAIC_Catalogos.TipoCalculoImpuestoNomina);
                // TODO: This line of code loads data into the 'dbSAIC_Catalogos.SubRegion' table. You can move, or remove it, as needed.
                this.subRegionTableAdapter.Fill(this.dbSAIC_Catalogos.SubRegion);
                // TODO: This line of code loads data into the 'dbSAIC_Catalogos.TipoRegimen' table. You can move, or remove it, as needed.
                this.tipoRegimenTableAdapter.Fill(this.dbSAIC_Catalogos.TipoRegimen);
                // TODO: This line of code loads data into the 'dbSAIC_Catalogos.EntidadFederativa' table. You can move, or remove it, as needed.
                this.entidadFederativaTableAdapter.Fill(this.dbSAIC_Catalogos.EntidadFederativa);
                // TODO: This line of code loads data into the 'dbSAIC_Catalogos.Estatus' table. You can move, or remove it, as needed.
                this.estatusTableAdapter.Fill(this.dbSAIC_Catalogos.Estatus);
                // TODO: This line of code loads data into the 'dbSAIC_Catalogos.ClasifTenedora' table. You can move, or remove it, as needed.
                this.clasifTenedoraTableAdapter.Fill(this.dbSAIC_Catalogos.ClasifTenedora);
                // TODO: This line of code loads data into the 'dbSAIC_Catalogos.stpSelPais' table. You can move, or remove it, as needed.
                this.stpSelPaisTableAdapter.Fill(this.dbSAIC_Catalogos.stpSelPais);
                // TODO: This line of code loads data into the 'dbSAIC_Catalogos.stpSelEstado' table. You can move, or remove it, as needed.
                this.stpSelEstadoTableAdapter.Fill(this.dbSAIC_Catalogos.stpSelEstado);
                // TODO: This line of code loads data into the 'dbSAIC_Catalogos.ActividadComercial' table. You can move, or remove it, as needed.
                this.actividadComercialTableAdapter.Fill(this.dbSAIC_Catalogos.ActividadComercial);
                // TODO: This line of code loads data into the 'dbSAIC_Catalogos.MatrizTenedora' table. You can move, or remove it, as needed.
                this.matrizTenedoraTableAdapter.Fill(this.dbSAIC_Catalogos.MatrizTenedora);
                // TODO: This line of code loads data into the 'dbSAIC_Catalogos.Tenedora' table. You can move, or remove it, as needed.
                this.tenedoraTableAdapter.Fill(this.dbSAIC_Catalogos.Tenedora);

                stpSelRegimenFiscalSATTableAdapter1.Fill(dbSAIC_Catalogos.stpSelRegimenFiscalSAT);

                splashSMCargando.CloseWaitForm();
            }
            catch (Exception ex)
            {
                splashSMCargando.CloseWaitForm();
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();        //cerrar pantalla
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            IdClaseRiesgoIMSSLookUpEdit.ItemIndex = 0;  //asignar Clase I
            TipoCalculoImpuestoNominaTextEdit.ItemIndex = 0;    //asignar NA
            IdMatrizTenedoraLookUpEdit.Focus();    //colocar cursor en control
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                this.tenedoraBindingSource.CancelEdit();
            }
            catch (System.Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                GuardarRegistros();     //guardar cambios
                XtraMessageBox.Show("Información guardada con Exito", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                this.tenedoraTableAdapter.FillByRazonSocial(this.dbSAIC_Catalogos.Tenedora, pRazonSocialToolStripTextBox.Text);
                //si no existem registros, notificar
                if (this.dbSAIC_Catalogos.Tenedora.Rows.Count == 0)
                {
                    XtraMessageBox.Show("Razón Social Tenedora NO encontrada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pRazonSocialToolStripTextBox.Text = "";     //limpiar textbox
                    this.tenedoraTableAdapter.Fill(this.dbSAIC_Catalogos.Tenedora);
                }
            }
            catch (FormatException)
            {
                XtraMessageBox.Show("Razón Social Tenedora NO es válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            this.tenedoraTableAdapter.Fill(this.dbSAIC_Catalogos.Tenedora);
        }

        private void pRazonSocialToolStripTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnBuscar_Click(sender, e);     //si existe ENTER entonces ejecutar metodo-evento click
        }

        private void btnABC_MatrizTenedora_Click(object sender, EventArgs e)
        {
            frmxMatrizTenedora objForm = new frmxMatrizTenedora();
            objForm.ShowDialog();       //mostrar pantalla
            this.matrizTenedoraTableAdapter.Fill(this.dbSAIC_Catalogos.MatrizTenedora); //actualizar Matriz Tenedora
        }

        private void btnABC_ActividadComercial_Click(object sender, EventArgs e)
        {
            Catalogos.frmxActividadComercial objActividadComercial = new Catalogos.frmxActividadComercial();
            objActividadComercial.ShowDialog();     //mostrar pantalla
            this.actividadComercialTableAdapter.Fill(this.dbSAIC_Catalogos.ActividadComercial); //actualizar Actividad Comercial
        }

        private void btnAsignarInfoPAC_Click(object sender, EventArgs e)
        {
            if (IdTenedoraTextEdit.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("¡Debe seleccionar una Tenedora para asignar información del PAC!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                XtraSubirCertificados objForm = new XtraSubirCertificados()
                {
                    pIdTenedora = Convert.ToInt32(IdTenedoraTextEdit.EditValue),
                    pNombreComercialTenedora = NombreComercialTextEdit.Text,
                    pRFC = RFCTextEdit.Text
                };
                objForm.ShowDialog();       //mostrar pantalla
            }


        }

        private void pRazonSocialToolStripTextBox_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}