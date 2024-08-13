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
using Excel = Microsoft.Office.Interop.Excel;
using System.Text.RegularExpressions;

namespace winAppSAIC.Facturas.Catalogos
{
    public partial class frmConceptoTenedoraBeneficiario : DevExpress.XtraEditors.XtraForm
    {
        public frmConceptoTenedoraBeneficiario()
        {
            InitializeComponent();
        }

        #region "Variables Globales"
        private Constantes.TipoOperacionABC tipoOperacionABC = Constantes.TipoOperacionABC.Ninguno;
        FactConceptoTenedoraBeneficiario objMDetalle = null;

        String stRechazo;
        ErrorProvider erroProviderCampos = new ErrorProvider();
        tools.dsc dsc = new tools.dsc();
        #endregion

        #region "Metodos Propios"
        private FactConceptoTenedoraBeneficiario AsignarInfo()
        {
            FactConceptoTenedoraBeneficiario objAtributos = null;

            try
            {
                objAtributos = new FactConceptoTenedoraBeneficiario();

                objAtributos.IdFactConceptoTenedoraBeneficiario = Convert.ToInt64(txtId.Text.Replace(",", ""));
                objAtributos.IdConceptoTenedora = Convert.ToInt64(CbxServicio.EditValue);
                objAtributos.IdUsoCFDI = Convert.ToInt16(cbxUso.EditValue);
                objAtributos.IdTipoBeneficiario = Convert.ToInt16(cbxTipoBeneficiario.EditValue);

                if (cbxTipoBeneficiario.EditValue.ToString() == "2")
                    objAtributos.IdBeneficiario = Convert.ToInt32(cbxCliente.EditValue.ToString());
                else
                    if (cbxTipoBeneficiario.EditValue.ToString() == "3")
                    objAtributos.IdBeneficiario = Convert.ToInt32(cbxTenedora.EditValue.ToString());
                else
                    objAtributos.IdBeneficiario = 0;

                objAtributos.DescConceptoInterno = txtConcepto.Text.Trim();
                objAtributos.IVA = Convert.ToBoolean(chckIVA.Checked);
                objAtributos.Retencion = Convert.ToBoolean(chckIVARetencion.Checked);
                objAtributos.ObjetoImpuesto = Convert.ToBoolean(chckObjetoImpuesto.Checked);
                objAtributos.IdEstatus = Convert.ToInt16(cbxEstatus.EditValue);
                objAtributos.Monto = Convert.ToDecimal(txtMonto.Text.Replace("$", "").Replace(",", ""));
                objAtributos.FechaInicio = Convert.ToDateTime(dtFechaInicio.Text);
                objAtributos.FechaFin = Convert.ToDateTime(dtFechaFin.Text);
            }
            catch (Exception ex)
            {
                return null;
            }
            return objAtributos;
        }

        private void MostrarInfo(FactConceptoTenedoraBeneficiario objAtributos)
        {
            txtId.Text = objAtributos.IdFactConceptoTenedoraBeneficiario.ToString();
            cbxFronting.EditValue = objAtributos.IdFronting;
            CbxServicio.EditValue = objAtributos.IdConceptoTenedora;
            cbxTipoBeneficiario.EditValue = objAtributos.IdTipoBeneficiario;
            if (objAtributos.IdTipoBeneficiario == 2)
            {
                cbxCliente.EditValue = objAtributos.IdBeneficiario;
            }
            else if (objAtributos.IdTipoBeneficiario == 3)
            {
                cbxTenedora.EditValue = objAtributos.IdBeneficiario;
            }
            txtConcepto.Text = objAtributos.DescConceptoInterno.ToString();
            cbxUso.EditValue = objAtributos.IdUsoCFDI;
            chckIVA.Checked = objAtributos.IVA;
            chckIVARetencion.Checked = objAtributos.Retencion;
            chckObjetoImpuesto.Checked = objAtributos.ObjetoImpuesto;
            cbxEstatus.EditValue = objAtributos.IdEstatus;
            txtMonto.Text = objAtributos.Monto.ToString();
            dtFechaInicio.Text = objAtributos.FechaInicio.ToString();
            dtFechaFin.Text = objAtributos.FechaFin.ToString();
        }
        private void ActivarControlesInfo(bool bFlag)
        {
            cbxFronting.Enabled = bFlag;
            CbxServicio.Enabled = bFlag;
            cbxTipoBeneficiario.Enabled = bFlag;
            cbxCliente.Enabled = bFlag;
            cbxTenedora.Enabled = bFlag;
            txtConcepto.Enabled = bFlag;
            cbxUso.Enabled = bFlag;
            chckIVA.Enabled = bFlag;
            chckIVARetencion.Enabled = bFlag;
            chckObjetoImpuesto.Enabled = bFlag;
            cbxEstatus.Enabled = bFlag;
            groupLimite.Enabled = bFlag;

        }
        private void ActivarControlesBenefi(bool bFlag)
        {
            cbxCliente.Visible = bFlag;
            cbxCliente.Enabled = bFlag;
            cbxTenedora.Visible = !bFlag;
            cbxTenedora.Enabled = !bFlag;
        }
        private void LimpiarControlesInfo()
        {
            txtId.Text = "0";
            cbxFronting.EditValue = -1;
            CbxServicio.EditValue = -1;
            cbxTipoBeneficiario.EditValue = -1;
            cbxCliente.EditValue = -1;
            cbxTenedora.EditValue = -1;
            txtConcepto.Text = string.Empty;
            cbxUso.EditValue = -1;
            chckIVA.Checked = false;
            chckIVARetencion.Checked = false;
            chckObjetoImpuesto.Checked = false;
            cbxEstatus.EditValue = -1;
            txtMonto.Text = string.Empty;
        }
        private void ActivarDesactivarBotones(bool bFlag)
        {
            btnNuevo.Enabled = bFlag;
            btnCaptura.Enabled = !bFlag;
            btnGuardar.Enabled = !bFlag;
            btnGuardarLimite.Enabled = !bFlag;
        }
        #endregion
        private void frmCinceptoTenedoraBeneficiario_Load(object sender, EventArgs e)
        {
            try
            {
                splashSMCargando.ShowWaitForm();

                // TODO: This line of code loads data into the 'dbSAICBPOFactura.vwFactCatEstatusGlobal' table. You can move, or remove it, as needed.
                this.vwFactCatEstatusGlobalTableAdapter.Fill(this.dbSAICBPOFactura.vwFactCatEstatusGlobal);
                // TODO: This line of code loads data into the 'dbSAICBPOFactura.vwFactCatUsoCFDI' table. You can move, or remove it, as needed.
                this.vwFactCatUsoCFDITableAdapter.Fill(this.dbSAICBPOFactura.vwFactCatUsoCFDI);
                // TODO: This line of code loads data into the 'dbSAICBPOFactura.vwFactCatTipoBeneficiario' table. You can move, or remove it, as needed.
                this.vwFactCatTipoBeneficiarioTableAdapter.Fill(this.dbSAICBPOFactura.vwFactCatTipoBeneficiario);
                // TODO: This line of code loads data into the 'dbSAICBPOFactura.vwcatFronting' table. You can move, or remove it, as needed.
                this.vwcatFrontingTableAdapter.Fill(this.dbSAICBPOFactura.vwcatFronting);
                // TODO: This line of code loads data into the 'dbSAICBPOFactura.stpFactSelConceptoTenedoraBeneficiario' table. You can move, or remove it, as needed.
                this.stpFactSelConceptoTenedoraBeneficiarioFiltroTableAdapter.Fill(this.dbSAICBPOFactura.stpFactSelConceptoTenedoraBeneficiarioFiltro, 0, 0, 0, 0, 0, false);

                // Set column widths according to their contents. 
                cbxFronting.Properties.View.BestFitColumns();
                // Specify the total dropdown width. 
                cbxFronting.Properties.PopupFormWidth = 800;

                // Set column widths according to their contents. 
                CbxServicio.Properties.View.BestFitColumns();
                // Specify the total dropdown width. 
                CbxServicio.Properties.PopupFormWidth = 800;

                // Set column widths according to their contents. 
                cbxCliente.Properties.View.BestFitColumns();
                // Specify the total dropdown width. 
                cbxCliente.Properties.PopupFormWidth = 800;

                // Set column widths according to their contents. 
                cbxFronting.Properties.View.BestFitColumns();
                // Specify the total dropdown width. 
                cbxFronting.Properties.PopupFormWidth = 800;


                // Set column widths according to their contents. 
                cbxUso.Properties.View.BestFitColumns();
                // Specify the total dropdown width. 
                cbxUso.Properties.PopupFormWidth = 600;

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
                if (Validator.IsPresent(CbxServicio) && Validator.IsPresent(txtConcepto) &&
                    Validator.IsPresent(cbxFronting) && Validator.IsPresent(cbxEstatus) &&
                    Validator.IsPresent(cbxTipoBeneficiario) && Validator.IsPresent(cbxUso) && Validator.IsPositiveNumber(txtMonto))
                {

                    if (cbxTipoBeneficiario.EditValue.ToString() == "2")
                        Validator.IsPresent(cbxCliente);
                    else
                        Validator.IsPresent(cbxTenedora);

                    objMDetalle = AsignarInfo();

                    if (objMDetalle != null)
                    {
                        if (objMDetalle.IdBeneficiario != 0)
                        {
                            if (tipoOperacionABC == Constantes.TipoOperacionABC.Nuevo)
                            {
                                Int64? pId = 0;
                                string FechaInicio = Convert.ToDateTime(objMDetalle.FechaInicio).Year.ToString() + "-" + Convert.ToDateTime(objMDetalle.FechaInicio).Month.ToString() + "-" + Convert.ToDateTime(objMDetalle.FechaInicio).Day.ToString();
                                string FechaFin = Convert.ToDateTime(objMDetalle.FechaInicio).Year.ToString() + "-" + Convert.ToDateTime(objMDetalle.FechaInicio).Month.ToString() + "-" + Convert.ToDateTime(objMDetalle.FechaInicio).Day.ToString();

                                this.spSoloRespuesta1.stpFactInsConceptoTenedoraBeneficiario2020(objMDetalle.IdConceptoTenedora, objMDetalle.IdBeneficiario,
                                    objMDetalle.IdUsoCFDI, objMDetalle.IdTipoBeneficiario, objMDetalle.DescConceptoInterno, objMDetalle.IVA, objMDetalle.Retencion, objMDetalle.ObjetoImpuesto,
                                   Convert.ToByte(objMDetalle.IdEstatus), OperadorBD.OperadorGlobal.NombreUsuario, objMDetalle.Monto, FechaInicio, FechaFin, ref pId);

                                if (pId == 0)        //si existe Id asignado => Alta del cliente exitosa
                                    XtraMessageBox.Show("¡El alta del Concepto NO ha sido exitosa!\nContacte a Sistemas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                else
                                {
                                    txtId.Text = pId.ToString();

                                    ActivarDesactivarBotones(true);
                                    ActivarControlesInfo(false);      //desactivar controles formulario
                                    tipoOperacionABC = Constantes.TipoOperacionABC.Ninguno; //tipo de Operacion ABC = NIGUNO
                                    XtraMessageBox.Show("¡El alta del Concepto ha sido exitosa!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    // actualizar Table Adapter
                                    // TODO: This line of code loads data into the 'dbSAICBPOFactura.stpFactSelConceptoTenedoraBeneficiario' table. You can move, or remove it, as needed.
                                    this.stpFactSelConceptoTenedoraBeneficiarioFiltroTableAdapter.Fill(this.dbSAICBPOFactura.stpFactSelConceptoTenedoraBeneficiarioFiltro, 0, 0, 0, 0, 0, false);

                                }
                            }
                            else if (tipoOperacionABC == Constantes.TipoOperacionABC.Editar)
                            {

                                int? intNoRegistrosAfectados = 0;
                                this.spSoloRespuesta1.stpFactUpdConceptoTenedoraBeneficiario2020(objMDetalle.IdFactConceptoTenedoraBeneficiario, objMDetalle.IdConceptoTenedora,
                                objMDetalle.IdBeneficiario, objMDetalle.IdUsoCFDI, Convert.ToByte(objMDetalle.IdTipoBeneficiario), objMDetalle.DescConceptoInterno, objMDetalle.IVA,
                                objMDetalle.Retencion, objMDetalle.ObjetoImpuesto, Convert.ToByte(objMDetalle.IdEstatus), OperadorBD.OperadorGlobal.NombreUsuario, ref intNoRegistrosAfectados);


                                if (intNoRegistrosAfectados == 0)        //si existe Id asignado => Alta del cliente exitosa
                                    XtraMessageBox.Show("¡La modificación del Concepto NO ha sido exitosa!\nContacte a Sistemas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                else
                                {
                                    ActivarDesactivarBotones(true);
                                    ActivarControlesInfo(false);      //desactivar controles formulario
                                    tipoOperacionABC = Constantes.TipoOperacionABC.Ninguno; //tipo de Operacion ABC = NIGUNO
                                    XtraMessageBox.Show("¡La modificación del Concepto ha sido exitosa!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    // TODO: This line of code loads data into the 'dbSAICBPOFactura.stpFactSelConceptoTenedoraBeneficiario' table. You can move, or remove it, as needed.
                                    this.stpFactSelConceptoTenedoraBeneficiarioFiltroTableAdapter.Fill(this.dbSAICBPOFactura.stpFactSelConceptoTenedoraBeneficiarioFiltro, 0, 0, 0, 0, 0, false);
                                }
                            }
                            else if (tipoOperacionABC == Constantes.TipoOperacionABC.EditarNuevo)
                            {

                                Int64? intNoRegistrosAfectados = 0;
                                string FechaInicio = Convert.ToDateTime(objMDetalle.FechaInicio).Year.ToString() + "-" + Convert.ToDateTime(objMDetalle.FechaInicio).Month.ToString() + "-" + Convert.ToDateTime(objMDetalle.FechaInicio).Day.ToString();
                                string FechaFin = Convert.ToDateTime(objMDetalle.FechaInicio).Year.ToString() + "-" + Convert.ToDateTime(objMDetalle.FechaInicio).Month.ToString() + "-" + Convert.ToDateTime(objMDetalle.FechaInicio).Day.ToString();

                                this.spSoloRespuesta1.stpFactInsLimiteConcepto(objMDetalle.IdFactConceptoTenedoraBeneficiario, OperadorBD.OperadorGlobal.NombreUsuario, objMDetalle.Monto, FechaInicio, FechaFin, ref intNoRegistrosAfectados);


                                if (intNoRegistrosAfectados == 0)        //si existe Id asignado => Alta del cliente exitosa
                                    XtraMessageBox.Show("¡La modificación del Limite del Concepto NO ha sido exitosa!\nContacte a Sistemas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                else
                                {
                                    ActivarDesactivarBotones(true);
                                    ActivarControlesInfo(false);      //desactivar controles formulario
                                    tipoOperacionABC = Constantes.TipoOperacionABC.Ninguno; //tipo de Operacion ABC = NIGUNO
                                    XtraMessageBox.Show("¡La modificación del Limite del Concepto ha sido exitosa!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    // TODO: This line of code loads data into the 'dbSAICBPOFactura.stpFactSelConceptoTenedoraBeneficiario' table. You can move, or remove it, as needed.
                                    this.stpFactSelConceptoTenedoraBeneficiarioFiltroTableAdapter.Fill(this.dbSAICBPOFactura.stpFactSelConceptoTenedoraBeneficiarioFiltro, 0, 0, 0, 0, 0, false);
                                }
                            }
                        }
                        else
                            XtraMessageBox.Show("Debe de Seleccionar Un Beneficiario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private FactConceptoTenedoraBeneficiario ObtenerInfoAtributos()
        {
            //si el usuario seleccionó un renglon, entonces regresar el valor IdTransaccionBanco
            if (gridView3.FocusedRowHandle >= 0)
            {
                //obtener la información del renglon completo
                DataRow row = gridView3.GetDataRow(gridView3.FocusedRowHandle);
                //asignar InfoDetalle Solicitud Cheque Masivo
                return FactConceptoTenedoraBeneficiarioDB.ObtenerInfoDetalleFactConceptoTenedoraBeneficiario(row);
            }
            else
                return null;       //si no se ha seleccionado un renglon válido, entonces regresar 0
        }

        private void cbxTipoBeneficiario_EditValueChanged(object sender, EventArgs e)
        {
            if (cbxTipoBeneficiario.EditValue.ToString() == "2")
                ActivarControlesBenefi(true);
            else
                ActivarControlesBenefi(false);
        }

        private void cbxFronting_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxFronting.EditValue.ToString() != "0" && cbxFronting.EditValue.ToString() != "-1")
                {
                    // TODO: This line of code loads data into the 'dbSAICBPOFactura.stpSelBeneficiarioCliente' table. You can move, or remove it, as needed.
                    this.stpFactSelBeneficiarioClienteTableAdapter.Fill(this.dbSAICBPOFactura.stpFactSelBeneficiarioCliente, (Int32)cbxFronting.EditValue);
                    // TODO: This line of code loads data into the 'dbSAICBPOFactura.stpSelBeneficiarioCliente' table. You can move, or remove it, as needed.
                    this.stpFactSelBeneficiarioTenedoraTableAdapter.Fill(this.dbSAICBPOFactura.stpFactSelBeneficiarioTenedora, (Int32)cbxFronting.EditValue);
                    // TODO: This line of code loads data into the 'dbSAICBPOFactura.stpSelBeneficiarioCliente' table. You can move, or remove it, as needed.
                    this.stpFactSelConceptoFrontingTableAdapter.Fill(this.dbSAICBPOFactura.stpFactSelConceptoFronting, (Int32)cbxFronting.EditValue);

                    gridView3.ActiveFilter.Clear();

                    ColumnView view = gridView3;
                    ViewColumnFilterInfo viewFilterInfo = new ViewColumnFilterInfo(view.Columns["IdFronting"],
                    new ColumnFilterInfo("[IdFronting] = " + cbxFronting.EditValue.ToString(), ""));
                    gridView3.ActiveFilter.Add(viewFilterInfo);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtConcepto_EditValueChanged(object sender, EventArgs e)
        {
            String stCaracEspeNombre = dsc.contieneCaracteresEspeciales(txtConcepto.Text.ToUpper().Trim(), dsc.stCaracteresEspeciales);
            if (!String.IsNullOrEmpty(stCaracEspeNombre))
            {
                erroProviderCampos.Icon = Properties.Resources.warning1;
                erroProviderCampos.SetError(txtConcepto, "Rechazo Contiene Caracteres Especiales: " + stCaracEspeNombre);
                btnGuardar.Enabled = false;
                btnGuardarLimite.Enabled = false;
            }
            else
            {
                erroProviderCampos.Clear();
                btnGuardar.Enabled = true;
                btnGuardarLimite.Enabled = true;
            }
        }

        private void btnGuardarLimite_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (Validator.IsPresent(CbxServicio) && Validator.IsPresent(txtConcepto) &&
                    Validator.IsPresent(cbxFronting) && Validator.IsPresent(cbxEstatus) &&
                    Validator.IsPresent(cbxTipoBeneficiario) && Validator.IsPresent(cbxUso) && Validator.IsPositiveNumber(txtMonto))
                {

                    if (cbxTipoBeneficiario.EditValue.ToString() == "2")
                        Validator.IsPresent(cbxCliente);
                    else
                        Validator.IsPresent(cbxTenedora);

                    objMDetalle = AsignarInfo();

                    if (objMDetalle != null)
                    {
                        if (objMDetalle.IdBeneficiario != 0)
                        {
                            Int64? intNoRegistrosAfectados = 0;
                            string FechaInicio = Convert.ToDateTime(objMDetalle.FechaInicio).Year.ToString() + "-" + Convert.ToDateTime(objMDetalle.FechaInicio).Month.ToString() + "-" + Convert.ToDateTime(objMDetalle.FechaInicio).Day.ToString();
                            string FechaFin = Convert.ToDateTime(objMDetalle.FechaFin).Year.ToString() + "-" + Convert.ToDateTime(objMDetalle.FechaFin).Month.ToString() + "-" + Convert.ToDateTime(objMDetalle.FechaFin).Day.ToString();

                            this.spSoloRespuesta1.stpFactInsLimiteConcepto(objMDetalle.IdFactConceptoTenedoraBeneficiario, OperadorBD.OperadorGlobal.NombreUsuario, objMDetalle.Monto, FechaInicio, FechaFin, ref intNoRegistrosAfectados);


                            if (intNoRegistrosAfectados == 0)        //si existe Id asignado => Alta del cliente exitosa
                                XtraMessageBox.Show("¡La modificación del Limite del Concepto NO ha sido exitosa!\nContacte a Sistemas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else
                            {
                                ActivarDesactivarBotones(true);
                                ActivarControlesInfo(false);      //desactivar controles formulario
                                tipoOperacionABC = Constantes.TipoOperacionABC.Ninguno; //tipo de Operacion ABC = NIGUNO
                                XtraMessageBox.Show("¡La modificación del Limite del Concepto ha sido exitosa!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                // TODO: This line of code loads data into the 'dbSAICBPOFactura.stpFactSelConceptoTenedoraBeneficiario' table. You can move, or remove it, as needed.
                                this.stpFactSelConceptoTenedoraBeneficiarioFiltroTableAdapter.Fill(this.dbSAICBPOFactura.stpFactSelConceptoTenedoraBeneficiarioFiltro, 0, 0, 0, 0, 0, false);
                            }

                        }
                        else
                            XtraMessageBox.Show("Debe de Seleccionar Un Beneficiario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btnMasivo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                DataTable dtDatos = new DataTable();
                DataRow row = null;
                string pOk;
                string pErrores = "Error en Conceptos de Facturación:";
                if (barEditItem5.EditValue != null && barEditItem5.EditValue.ToString().Trim().Length > 0)
                {
                    splashScreenManager2.ShowWaitForm();
                    dtDatos = ConvertExcelToDataTable(barEditItem5.EditValue.ToString().Trim());
                    if (dtDatos.Rows.Count > 0)
                    {
                        for (int i = 0; i < dtDatos.Rows.Count; i++)
                        {
                            row = dtDatos.Rows[i];
                            if (Convert.ToDecimal(row[9].ToString().Replace(",", "").Replace("$", "")) > 0)
                            {
                                pOk = "";

                                this.spSoloRespuesta1.stpCargarConceptosSAT(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString(), row[8].ToString(), Convert.ToDecimal(row[9].ToString()), Convert.ToDateTime(row[10].ToString()), Convert.ToDateTime(row[11].ToString()), OperadorBD.OperadorGlobal.NombreUsuario, ref pOk);
                                if (pOk != "")
                                    pErrores = pErrores + " FILA:" + (i + 2).ToString() + " " + pOk + " \n ";
                            }
                        }
                        if (pErrores != "" && pErrores != "Error en Conceptos de Facturación:")
                        {
                            splashScreenManager2.CloseWaitForm();
                            XtraMessageBox.Show(pErrores, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            splashScreenManager2.CloseWaitForm();
                            XtraMessageBox.Show("Los Conceptos se Cargaron Correctamente", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        this.stpFactSelConceptoTenedoraBeneficiarioFiltroTableAdapter.Fill(this.dbSAICBPOFactura.stpFactSelConceptoTenedoraBeneficiarioFiltro, 0, 0, 0, 0, 0, false);
                    }
                    else
                    {
                        splashScreenManager2.CloseWaitForm();
                        XtraMessageBox.Show(String.Format("!El Archivo no cumple con las columnas requeridas!."), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                    XtraMessageBox.Show(String.Format("!Debes de Cargar el Archivo de Alta!."), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable ConvertExcelToDataTable(String stRutaArchivo)
        {
            DataTable dtDatos = new DataTable();

            String ultimaCelda = String.Empty;
            String losDatos = String.Empty;
            String stUltimaColumna = "L";
            Excel.Application appExcel;
            Excel.Workbooks booksExcel;
            Excel.Workbook bookExcel = null;
            Excel.Worksheet SheetExcel;
            Excel.Range unRango;

            appExcel = new Excel.Application();
            booksExcel = appExcel.Workbooks;

            try
            {
                appExcel.Visible = true;
                appExcel.DisplayAlerts = false;
                bookExcel = booksExcel.Open(stRutaArchivo);
                ((Excel.Worksheet)appExcel.Sheets[1]).Select();
                SheetExcel = (Excel.Worksheet)bookExcel.ActiveSheet;
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Por favor asegúrese de Cerrar la ventana de Validacion de Office y despues de Click en Aceptar de este mensaje."
                          , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                ((Excel.Worksheet)appExcel.Sheets[1]).Select();
                SheetExcel = (Excel.Worksheet)bookExcel.ActiveSheet;
                unRango = SheetExcel.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell, Type.Missing);
                ultimaCelda = unRango.get_AddressLocal(false, false, Excel.XlReferenceStyle.xlA1, false, false);
                unRango = SheetExcel.get_Range("A2", stUltimaColumna + soloNumeros(ultimaCelda));
                unRango.Select();
                unRango.Copy();
                System.Threading.Thread.Sleep(2000);
                losDatos = Clipboard.GetText();
                losDatos = losDatos.ToUpper();
                dtDatos = ConvertToDataTable(losDatos);
                appExcel.Quit();
            }

            return dtDatos;

        }

        private String soloNumeros(String valor)
        {
            Regex regex = new Regex("[A-Z]");
            return regex.Replace(valor, "");
        }

        private DataTable ConvertToDataTable(String stLosDatos)
        {
            stLosDatos = stLosDatos.Replace("\r", "");
            DataTable valores = new DataTable();
            String[] registros = stLosDatos.Split('\n');
            int iContaColumnas = 0;

            for (int i = 0; i < registros.Length; i++)
            {
                if (!String.IsNullOrEmpty(registros[i]))
                {
                    DataRow unData = valores.NewRow();
                    String[] rows = registros[i].Split('\t');

                    if (iContaColumnas == 0)
                    {
                        for (int col = 0; col < rows.Length; col++) { valores.Columns.Add(); }
                        iContaColumnas++;
                    }

                    for (int cel = 0; cel < rows.Length; cel++)
                    {
                        unData[cel] = rows[cel].Trim();
                    }

                    valores.Rows.Add(unData);
                }
            }

            return valores;
        }

        private void barEditItem5_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ObtenerArchivo.Filter = "Excel Files (*.xls;*.xlsm;*.xlsb;*.xlsx)|*.xls;*.xlsm;*.xlsb;*.xlsx";
            ObtenerArchivo.ShowDialog();
            barEditItem5.EditValue = ObtenerArchivo.FileName;
        }
    }
}
