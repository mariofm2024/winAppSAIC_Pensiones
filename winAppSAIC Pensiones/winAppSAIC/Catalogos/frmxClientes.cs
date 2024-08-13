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
using winAppSAIC.Reportes;
using DevExpress.XtraReports.UI;        //namespace a partir version 12.2.4

namespace winAppSAIC.Catalogos
{
    public partial class frmxClientes : DevExpress.XtraEditors.XtraForm
    {
        private bool bFlagAcceso = false;
        public frmxClientes()
        {
            InitializeComponent();
        }

        #region "Variables Globales"
        private Constantes.TipoOperacionABC tipoOperacionABC = Constantes.TipoOperacionABC.Ninguno;
        string Productos = "";
        string Periodo = "";
        string Fronting = "";
        string Promotor = "";
        string Comision = "";
        Int32 IdPromotor = 0;

        decimal PCTComision = 0;
        decimal PCTIVA = 0;
        decimal PCTUtilidadReal = 0;
        #endregion

        #region "Metodos Propios"
        private Cliente AsignarInfoCliente()
        {
            Cliente objCliente = null;

            try
            {
                objCliente = new Cliente();

                objCliente.IdCliente = Convert.ToInt32(txtIdCliente.Text);
                objCliente.CodigoClienteProvedor = "";
                objCliente.RazonSocial = txtRazonSocial.Text.Trim();
                objCliente.NombreComercial = txtNombreComercial.Text.Trim();
                objCliente.RFC = txtRFC.Text.Trim();
                objCliente.IdActividadComercial = Convert.ToInt16(cboIdActividadComercial.EditValue);
                objCliente.IdMatrizCliente = Convert.ToInt32(cbGrupo.EditValue);
                objCliente.idCategoriaCliente = Convert.ToInt32(cbCategoriaCliente.EditValue);
                objCliente.CURP = "";
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
                //Domicilio Operacion
                objCliente.CalleOperacion = txtCalleOperacion.Text.Trim();
                objCliente.NoExteriorOperacion = txtNoExteriorOperacion.Text.Trim();
                objCliente.NoInteriorOperacion = txtNoInteriorOperacion.Text.Trim();
                objCliente.ColoniaOperacion = txtColoniaOperacion.Text.Trim();
                objCliente.CodigoPostalOperacion = txtCodigoPostalOperacion.Text.Trim();
                objCliente.IdEstadoOperacion = Convert.ToInt32(cboIdEstadoOperacion.EditValue);
                objCliente.IdPaisOperacion = Convert.ToInt16(cboIdPaisOperacion.EditValue);
                objCliente.NombreDelegacionMunicipioOperacion = txtNombreDelegacionMunicipioOperacion.Text.Trim();
                objCliente.NombrePoblacionCiudadOperacion = txtNombrePoblacionCiudadOperacion.Text.Trim();
                //Contacto
                objCliente.RepresentanteLegal = txtRepresentanteLegal.Text.Trim();
                objCliente.Contacto = txtContacto.Text.Trim();
                objCliente.Telefono1 = txtTelefono1.Text.Trim();
                objCliente.Telefono2 = txtTelefono2.Text.Trim();
                objCliente.CorreoElectronico = txtCorreoElectronico.Text.Trim();
                objCliente.PaginaWeb = txtPaginaWeb.Text.Trim();
                objCliente.IdOperador = Convert.ToInt32(cbIdOperador.EditValue);
                //Otros
                objCliente.IdTipoClienteProveedor = Convert.ToInt16(cboIdTipoClienteProveedor.EditValue);
                objCliente.IdClaseRiesgo = Convert.ToInt16(cbIdClaseRiesgo.EditValue);
                objCliente.ISN = Convert.ToDecimal(spISN.EditValue);
                objCliente.TieneSucursales = Convert.ToBoolean(chkTieneSucursales.EditValue);
                objCliente.Confidencial = Convert.ToBoolean(chkConfidencial.EditValue);
                objCliente.Seguro = Convert.ToBoolean(chkSeguro.EditValue); //ADD
                objCliente.Decreto = Convert.ToBoolean(chkDecreto.EditValue); //ADD
                objCliente.Sindicato = Convert.ToBoolean(chkSindicato.EditValue); //ADD
                objCliente.PctComisionBPO = Convert.ToDecimal(spPctComisionBPO.EditValue);
                objCliente.PctAsimilados = Convert.ToDecimal(spPctAsimilados.EditValue);
                objCliente.SaldoAFavor = Convert.ToDecimal(spSaldoFavor.EditValue);
                objCliente.Financiamiento = Convert.ToDecimal(spFinanciamiento.EditValue);
                objCliente.Observaciones = txtObservaciones.Text.Trim();

                objCliente.IdEstatus = Convert.ToByte(cboIdEstatus.EditValue);
                objCliente.FechaBaja = Convert.ToDateTime(calFechaBaja.EditValue);

                objCliente.idPlazaCliente = Convert.ToInt16(cbPlazaCliente.EditValue);
                objCliente.IdRegimenFiscal = Convert.ToInt32(cboIdRegimenFiscalSAT.EditValue);
                objCliente.RegimenCapital = RegimenCapitaltextEdit.Text.Trim();

                objCliente.Tarjeta = Convert.ToDecimal(spPctBPOTarjeta.EditValue);
                objCliente.TarjetaP = Convert.ToDecimal(spPctProTarjeta.EditValue);
                objCliente.Cucas = Convert.ToDecimal(spPctBPOCucas.EditValue);
                objCliente.CucasP = Convert.ToDecimal(spPctProCucas.EditValue);
                objCliente.Efectivos = Convert.ToDecimal(spPctBPOEfectivo.EditValue);
                objCliente.EfectivosP = Convert.ToDecimal(spPctProEfectivo.EditValue);
                objCliente.Seguros = Convert.ToDecimal(spPctBPOSeguros.EditValue);
                objCliente.SegurosP = Convert.ToDecimal(spPctProSeguros.EditValue);
                objCliente.Proveedor = Convert.ToDecimal(spPctBPOProveedor.EditValue);
                objCliente.ProveedorP = Convert.ToDecimal(spPctProProveedor.EditValue);
                objCliente.Gasto = Convert.ToDecimal(spPctBPOGasto.EditValue);
                objCliente.GastoP = Convert.ToDecimal(spPctProGasto.EditValue);
                objCliente.Otro = Convert.ToDecimal(spPctBPOOtro.EditValue);
                objCliente.OtroP = Convert.ToDecimal(spPctProOtro.EditValue);

                //Llenar Conceptos Multiples
                AsignarConceptosMultiples(objCliente.IdCliente);
            }
            catch (Exception ex)
            {
                return null;
            }
            return objCliente;
        }

        private void MostrarInfoCliente(Cliente objCliente)
        {
            txtIdCliente.Text = objCliente.IdCliente.ToString();
            txtRazonSocial.Text = objCliente.RazonSocial;
            txtNombreComercial.Text = objCliente.NombreComercial;
            txtRFC.Text = objCliente.RFC;
            cboIdActividadComercial.EditValue = objCliente.IdActividadComercial;
            cbGrupo.EditValue = objCliente.IdMatrizCliente;
            cbCategoriaCliente.EditValue = objCliente.idCategoriaCliente;

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
            //Domicilio Operacion
            txtCalleOperacion.Text = objCliente.CalleOperacion;
            txtNoExteriorOperacion.Text = objCliente.NoExteriorOperacion;
            txtNoInteriorOperacion.Text = objCliente.NoInteriorOperacion;
            txtColoniaOperacion.Text = objCliente.ColoniaOperacion;
            txtCodigoPostalOperacion.Text = objCliente.CodigoPostalOperacion;
            cboIdEstadoOperacion.EditValue = objCliente.IdEstadoOperacion;
            cboIdPaisOperacion.EditValue = objCliente.IdPaisOperacion;
            txtNombreDelegacionMunicipioOperacion.Text = objCliente.NombreDelegacionMunicipioOperacion;
            txtNombrePoblacionCiudadOperacion.Text = objCliente.NombrePoblacionCiudadOperacion;
            //Contacto
            txtRepresentanteLegal.Text = objCliente.RepresentanteLegal;
            txtContacto.Text = objCliente.Contacto;
            txtTelefono1.Text = objCliente.Telefono1;
            txtTelefono2.Text = objCliente.Telefono2;
            txtCorreoElectronico.Text = objCliente.CorreoElectronico;
            txtPaginaWeb.Text = objCliente.PaginaWeb;
            cbIdOperador.EditValue = objCliente.IdOperador;
            //Otros
            cboIdTipoClienteProveedor.EditValue = objCliente.IdTipoClienteProveedor;
            cbIdClaseRiesgo.EditValue = objCliente.IdClaseRiesgo;
            spISN.EditValue = objCliente.ISN;
            chkTieneSucursales.EditValue = objCliente.TieneSucursales;
            chkConfidencial.EditValue = objCliente.Confidencial;
            chkSeguro.EditValue = objCliente.Seguro;
            chkDecreto.EditValue = objCliente.Decreto;
            chkSindicato.EditValue = objCliente.Sindicato;
            spPctComisionBPO.EditValue = objCliente.PctComisionBPO;
            spPctAsimilados.EditValue = objCliente.PctAsimilados;
            spSaldoFavor.EditValue = objCliente.SaldoAFavor;
            spFinanciamiento.EditValue = objCliente.Financiamiento;
            txtObservaciones.Text = objCliente.Observaciones;
            cboIdEstatus.EditValue = objCliente.IdEstatus;
            calFechaBaja.EditValue = objCliente.FechaBaja;

            //Llenar Conceptos Multiples
            MostrarConceptosMultiples(objCliente.IdCliente);

            cboIdRegimenFiscalSAT.EditValue = objCliente.IdRegimenFiscal;
            cboIdRegimenFiscalSAT.EditValue = objCliente.IdRegimenFiscal.ToString();
            cbPlazaCliente.EditValue = objCliente.idPlazaCliente;
            RegimenCapitaltextEdit.Text = objCliente.RegimenCapital;

            btnModificPromotor.Enabled = false;
        }

        private void ActivarControlesInfoCliente(bool bFlag)
        {
            //txtIdCliente.Enabled = bFlag;
            txtRazonSocial.Enabled = bFlag;
            txtNombreComercial.Enabled = bFlag;
            txtRFC.Enabled = bFlag;
            cboIdActividadComercial.Enabled = bFlag;
            cbGrupo.Enabled = bFlag;
            cbCategoriaCliente.Enabled = bFlag;
            btnAgregarCategoria.Enabled = bFlag;
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
            //Domicilio Operacion
            txtCalleOperacion.Enabled = bFlag;
            txtNoExteriorOperacion.Enabled = bFlag;
            txtNoInteriorOperacion.Enabled = bFlag;
            txtColoniaOperacion.Enabled = bFlag;
            txtCodigoPostalOperacion.Enabled = bFlag;
            cboIdEstadoOperacion.Enabled = bFlag;
            cboIdPaisOperacion.Enabled = bFlag;
            txtNombreDelegacionMunicipioOperacion.Enabled = bFlag;
            txtNombrePoblacionCiudadOperacion.Enabled = bFlag;
            //Contacto
            txtRepresentanteLegal.Enabled = bFlag;
            txtContacto.Enabled = bFlag;
            txtTelefono1.Enabled = bFlag;
            txtTelefono2.Enabled = bFlag;
            txtCorreoElectronico.Enabled = bFlag;
            txtPaginaWeb.Enabled = bFlag;
            cbIdOperador.Enabled = bFlag;
            cbPlazaCliente.Enabled = bFlag;
            //Otros
            cboIdTipoClienteProveedor.Enabled = bFlag;
            cbIdClaseRiesgo.Enabled = bFlag;
            spISN.Enabled = bFlag;
            chkTieneSucursales.Enabled = bFlag;
            chkConfidencial.Enabled = bFlag;
            chkSeguro.Enabled = bFlag;
            chkDecreto.Enabled = bFlag;
            chkSindicato.Enabled = bFlag;
            cbProductos.Enabled = bFlag;
            chkbPeriodicidad.Enabled = bFlag;

            //Productos
            spPctBPOTarjeta.Enabled = bFlag;
            spPctBPOCucas.Enabled = bFlag;
            spPctBPOEfectivo.Enabled = bFlag;
            spPctBPOSeguros.Enabled = bFlag;
            spPctBPOProveedor.Enabled = bFlag;
            spPctBPOGasto.Enabled = bFlag;
            spPctBPOOtro.Enabled = bFlag;

            spPctProTarjeta.Enabled = bFlag;
            spPctProCucas.Enabled = bFlag;
            spPctProEfectivo.Enabled = bFlag;
            spPctProSeguros.Enabled = bFlag;
            spPctProProveedor.Enabled = bFlag;
            spPctProGasto.Enabled = bFlag;
            spPctProOtro.Enabled = bFlag;

            //chkbPromotor.Enabled = bFlag;
            spPctComisionBPO.Enabled = bFlag;
            chkbComision.Enabled = bFlag;
            spPctAsimilados.Enabled = bFlag;
            spFinanciamiento.Enabled = bFlag;
            spSaldoFavor.Enabled = bFlag;
            txtObservaciones.Enabled = bFlag;
            cboIdEstatus.Enabled = bFlag;

            if (bFlag == false)
            {
                chkbFronting.Enabled = bFlag;
            }
            else
            {
                chkbFronting.Enabled = bFlagAcceso;
            }

            btnABC_ActividadComercial.Enabled = bFlag;
            btnGrupo.Enabled = bFlag;
            btnCrearProducto.Enabled = bFlag;
            //btnPromotor.Enabled = bFlag;
            cboIdRegimenFiscalSAT.Enabled = bFlag;

            cbPromotor.Enabled = bFlag;
            spComision.Enabled = bFlag;
            spIVA.Enabled = bFlag;
            spUtilidadReal.Enabled = bFlag;
            txtObservacionesPromo.Enabled = bFlag;
            cbRelIdPromotor.Enabled = bFlag;
            RegimenCapitaltextEdit.Enabled = bFlag;

            if (bFlag)
            {
                btnAgregarPromo.Enabled = bFlag;
                btnModificPromotor.Enabled = bFlag;
                btnGuardarPromo.Enabled = !bFlag;
                btnEliminarProm.Enabled = !bFlag;
                btnCancelarPro.Enabled = !bFlag;
            }
            else
            {
                btnAgregarPromo.Enabled = bFlag;
                btnModificPromotor.Enabled = bFlag;
                btnGuardarPromo.Enabled = bFlag;
                btnEliminarProm.Enabled = bFlag;
                btnCancelarPro.Enabled = bFlag;

            }
        }

        private void LimpiarControlesInfoCliente()
        {
            Productos = "";
            Periodo = "";
            Fronting = "";
            Promotor = "";
            Comision = "";

            txtIdCliente.Text = "0";
            txtRazonSocial.Text = string.Empty;
            txtNombreComercial.Text = string.Empty;
            txtRFC.Text = string.Empty;
            cboIdActividadComercial.EditValue = -1;
            cbGrupo.Text = string.Empty;
            cbCategoriaCliente.Text = string.Empty;
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
            //Domicilio Operacion
            txtCalleOperacion.Text = string.Empty;
            txtNoExteriorOperacion.Text = string.Empty;
            txtNoInteriorOperacion.Text = string.Empty;
            txtColoniaOperacion.Text = string.Empty;
            txtCodigoPostalOperacion.Text = string.Empty;
            cboIdEstadoOperacion.EditValue = -1;
            cboIdPaisOperacion.EditValue = -1;
            txtNombreDelegacionMunicipioOperacion.Text = string.Empty;
            txtNombrePoblacionCiudadOperacion.Text = string.Empty;
            //Contacto
            txtRepresentanteLegal.Text = string.Empty;
            txtContacto.Text = string.Empty;
            txtTelefono1.Text = string.Empty;
            txtTelefono2.Text = string.Empty;
            txtCorreoElectronico.Text = string.Empty;
            txtPaginaWeb.Text = string.Empty;
            cbIdOperador.EditValue = -1;
            //Otros
            cboIdTipoClienteProveedor.EditValue = -1;
            cbIdClaseRiesgo.EditValue = -1;
            spISN.EditValue = 0;
            chkTieneSucursales.EditValue = false;
            chkConfidencial.EditValue = false;
            chkSeguro.EditValue = false; //add
            chkDecreto.EditValue = false;
            chkSindicato.EditValue = false;

            spPctComisionBPO.Text = string.Empty;
            chkbComision.EditValue = -1;
            spPctAsimilados.EditValue = 0;
            spSaldoFavor.EditValue = 0;
            spFinanciamiento.EditValue = 0;
            txtObservaciones.Text = string.Empty;

            //cbProductos.Properties.itemx.oftype

            cbProductos.EditValue = "";
            chkbPeriodicidad.EditValue = "";
            //chkbPromotor.EditValue = "";
            chkbComision.EditValue = "";
            chkbFronting.EditValue = "";

            PCTComision = 0;
            PCTIVA = 0;
            PCTUtilidadReal = 0;
            IdPromotor = 0;

            //Productos
            spPctBPOTarjeta.Text = "0";
            spPctProTarjeta.Text = "0";
            spPctBPOCucas.Text = "0";
            spPctProCucas.Text = "0";
            spPctBPOEfectivo.Text = "0";
            spPctProEfectivo.Text = "0";
            spPctBPOSeguros.Text = "0";
            spPctProSeguros.Text = "0";
            spPctBPOProveedor.Text = "0";
            spPctProProveedor.Text = "0";
            spPctBPOGasto.Text = "0";
            spPctProGasto.Text = "0";
            spPctBPOOtro.Text = "0";
            spPctProOtro.Text = "0";
        }

        private void AsignarConceptosMultiples(Int32 IdCliente)
        {
            Productos = "";
            Periodo = "";
            Fronting = "";
            Promotor = "";
            Comision = "";

            foreach (var item in cbProductos.Properties.Items.GetCheckedValues())
            {
                Productos = Productos + item.ToString() + ",";
            }
            foreach (var item in chkbPeriodicidad.Properties.Items.GetCheckedValues())
            {
                Periodo = Periodo + item.ToString() + ",";
            }
            foreach (var item in chkbFronting.Properties.Items.GetCheckedValues())
            {
                Fronting = Fronting + item.ToString() + ",";
            }
            //foreach (var item in chkbPromotor.Properties.Items.GetCheckedValues())
            //{
            //    Promotor = Promotor + item.ToString() + ",";
            //}
            foreach (var item in chkbComision.Properties.Items.GetCheckedValues())
            {
                Comision = Comision + item.ToString() + ",";
            }
        }
        private void MostrarConceptosMultiples(Int32 IdCliente)
        {
            Productos = "";
            Periodo = "";
            Fronting = "";
            Promotor = "";
            Comision = "";

            stpFactSelClientePrPePrCoFoTableAdapter1.Fill(this.dbSAICBPOFactura.stpFactSelClientePrPePrCoFo, IdCliente);

            if (this.dbSAICBPOFactura.stpFactSelClientePrPePrCoFo.Rows.Count > 0)
            {
                for (int i = 0; i < this.dbSAICBPOFactura.stpFactSelClientePrPePrCoFo.Rows.Count; i++)
                {
                    if (this.dbSAICBPOFactura.stpFactSelClientePrPePrCoFo.Rows[i][0].ToString() == "Producto")
                    {
                        Productos = Productos + this.dbSAICBPOFactura.stpFactSelClientePrPePrCoFo.Rows[i][1].ToString() + ",";
                    }
                    else
                        if (this.dbSAICBPOFactura.stpFactSelClientePrPePrCoFo.Rows[i][0].ToString() == "Periodo")
                    {
                        Periodo = Periodo + this.dbSAICBPOFactura.stpFactSelClientePrPePrCoFo.Rows[i][1].ToString() + ",";
                    }
                    else
                        if (this.dbSAICBPOFactura.stpFactSelClientePrPePrCoFo.Rows[i][0].ToString() == "Promotor")
                    {
                        Promotor = Promotor + this.dbSAICBPOFactura.stpFactSelClientePrPePrCoFo.Rows[i][1].ToString() + ",";
                    }
                    else
                        if (this.dbSAICBPOFactura.stpFactSelClientePrPePrCoFo.Rows[i][0].ToString() == "Comision")
                    {
                        Comision = Comision + this.dbSAICBPOFactura.stpFactSelClientePrPePrCoFo.Rows[i][1].ToString() + ",";
                    }
                    else
                        if (this.dbSAICBPOFactura.stpFactSelClientePrPePrCoFo.Rows[i][0].ToString() == "Fronting")
                    {
                        Fronting = Fronting + this.dbSAICBPOFactura.stpFactSelClientePrPePrCoFo.Rows[i][1].ToString() + ",";
                    }
                }
            }
            cbProductos.Focus();
            cbProductos.SetEditValue(Productos);
            chkbPeriodicidad.Focus();
            chkbPeriodicidad.SetEditValue(Periodo);
            //chkbPromotor.Focus();
            //chkbPromotor.SetEditValue(Promotor);
            chkbComision.Focus();
            chkbComision.SetEditValue(Comision);
            chkbFronting.Focus();
            chkbFronting.SetEditValue(Fronting);

            this.stpSelPromotoresActivosTableAdapter.Fill(this.dbSAIC_Catalogos.stpSelPromotoresActivos, IdCliente);
            this.stpSelClientePromotoresTableAdapter.Fill(this.dbSAIC_Catalogos.stpSelClientePromotores, Convert.ToInt32(txtIdCliente.Text)); 

            this.stpSelClientePromotoresPorcetajeClienteTableAdapter1.Fill(this.dbSAIC_Catalogos.stpSelClientePromotoresPorcetajeCliente, Convert.ToInt32(txtIdCliente.Text), - 1);

            if (this.dbSAIC_Catalogos.stpSelClientePromotoresPorcetajeCliente.Count > 0)
            {
                DataRow row = this.dbSAIC_Catalogos.stpSelClientePromotoresPorcetajeCliente.Rows[0];

                PCTComision = (decimal)row[0];
                PCTIVA = (decimal)row[1];
                PCTUtilidadReal = (decimal)row[2];
                row = null;
            }
            else
            {
                PCTComision = 0;
                PCTIVA = 0;
                PCTUtilidadReal = 0;
            }

            this.stpSelClientePCTProductoTableAdapter1.Fill(this.dbSAIC_Catalogos.stpSelClientePCTProducto, IdCliente);
            if (this.dbSAIC_Catalogos.stpSelClientePCTProducto.Count > 0)
            {
                DataRow row = this.dbSAIC_Catalogos.stpSelClientePCTProducto.Rows[0];

                spPctBPOTarjeta.Text =row[1].ToString();
                spPctProTarjeta.Text = row[2].ToString();
                spPctBPOCucas.Text = row[3].ToString();
                spPctProCucas.Text = row[4].ToString();
                spPctBPOEfectivo.Text = row[5].ToString();
                spPctProEfectivo.Text = row[6].ToString();
                spPctBPOSeguros.Text = row[7].ToString();
                spPctProSeguros.Text = row[8].ToString();
                spPctBPOProveedor.Text = row[9].ToString();
                spPctProProveedor.Text = row[10].ToString();
                spPctBPOGasto.Text = row[11].ToString();
                spPctProGasto.Text = row[12].ToString();
                spPctBPOOtro.Text = row[13].ToString();
                spPctProOtro.Text = row[14].ToString();
            }
            else
            {
                spPctBPOTarjeta.Text = "0";
                spPctProTarjeta.Text = "0";
                spPctBPOCucas.Text = "0";
                spPctProCucas.Text = "0";
                spPctBPOEfectivo.Text = "0";
                spPctProEfectivo.Text = "0";
                spPctBPOSeguros.Text = "0";
                spPctProSeguros.Text = "0";
                spPctBPOProveedor.Text = "0";
                spPctProProveedor.Text = "0";
                spPctBPOGasto.Text = "0";
                spPctProGasto.Text = "0";
                spPctBPOOtro.Text = "0";
                spPctProOtro.Text = "0";
            }

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
            btnExportar.Enabled = bFlag;
            btnCancelar.Enabled = !bFlag;
            btnGuardar.Enabled = !bFlag;
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

                stpSelCategoriaClienteTableAdapter.Fill(dbSAICBPOCatalogosDataSet.stpSelCategoriaCliente, 1);

                // TODO: This line of code loads data into the 'dbSAIC_Catalogos.vwCatEstatusCliente' table. You can move, or remove it, as needed.
                this.vwCatEstatusClienteTableAdapter.Fill(this.dbSAIC_Catalogos.vwCatEstatusCliente);
                // TODO: This line of code loads data into the 'dbSAIC_Catalogos.stpSelPais' table. You can move, or remove it, as needed.
                this.stpSelPaisTableAdapter.Fill(this.dbSAIC_Catalogos.stpSelPais);
                // TODO: This line of code loads data into the 'dbSAIC_Catalogos.Producto' table. You can move, or remove it, as needed.
                this.productoTableAdapter.Fill(this.dbSAIC_Catalogos.Producto);
                // TODO: This line of code loads data into the 'dbSAIC_Catalogos.TipoClienteProveedor' table. You can move, or remove it, as needed.
                this.tipoClienteProveedorTableAdapter.Fill(this.dbSAIC_Catalogos.TipoClienteProveedor);
                // TODO: This line of code loads data into the 'dbSAIC_Catalogos.ActividadComercial' table. You can move, or remove it, as needed.
                this.actividadComercialTableAdapter.Fill(this.dbSAIC_Catalogos.ActividadComercial);
                // TODO: This line of code loads data into the 'dbSAICBPOCatalogosDataSet.stpSelEstado' table. You can move, or remove it, as needed.
                this.stpSelEstadoTableAdapter.Fill(this.dbSAICBPOCatalogosDataSet.stpSelEstado);
                // TODO: This line of code loads data into the 'dbSAICBPOFactura.stpFactSelMatrizClienteActivos' table. You can move, or remove it, as needed.
                this.stpFactSelMatrizClienteActivosTableAdapter.Fill(this.dbSAICBPOFactura.stpFactSelMatrizClienteActivos);
                // TODO: This line of code loads data into the 'dbSAICBPODataSet.stpSelOperador' table. You can move, or remove it, as needed.
                this.stpSelOperadorTableAdapter.Fill(this.dbSAICBPODataSet.stpSelOperador);
                // TODO: This line of code loads data into the 'dbSAICBPOFactura.stpFactSelComisionCliente' table. You can move, or remove it, as needed.
                this.stpFactSelComisionClienteTableAdapter.Fill(this.dbSAICBPOFactura.stpFactSelComisionCliente);
                // TODO: This line of code loads data into the 'dbSAICBPOFactura.vwcatFronting' table. You can move, or remove it, as needed.
                this.vwcatFrontingTableAdapter.Fill(this.dbSAICBPOFactura.vwcatFronting);
                // TODO: This line of code loads data into the 'dbSAICBPOFactura.stpFactSelClaseRiesgo' table. You can move, or remove it, as needed.
                this.stpFactSelClaseRiesgoTableAdapter.Fill(this.dbSAICBPOFactura.stpFactSelClaseRiesgo);
                // TODO: This line of code loads data into the 'dbSAICBPOFactura.stpFactSelPromotorCliente' table. You can move, or remove it, as needed.
                this.stpFactSelPromotorClienteTableAdapter.Fill(this.dbSAICBPOFactura.stpFactSelPromotorCliente);
                // TODO: This line of code loads data into the 'dbSAICBPOFactura.stpFactSelTipoPeriodoNominaCliente' table. You can move, or remove it, as needed.
                this.stpFactSelTipoPeriodoNominaClienteTableAdapter.Fill(this.dbSAICBPOFactura.stpFactSelTipoPeriodoNominaCliente);
                // TODO: This line of code loads data into the 'dbSAICBPOFactura.stpFactSelControlCliente' table. You can move, or remove it, as needed.
                this.stpFactSelControlClienteTableAdapter.Fill(this.dbSAICBPOFactura.stpFactSelControlCliente);
                // TODO: This line of code loads data into the 'dbSAIC_Catalogos.Cliente' table. You can move, or remove it, as needed.
                //this.clienteTableAdapter.Fill(this.dbSAIC_Catalogos.Cliente);
                this.stpSelPlazaClienteTableAdapter1.Fill(this.dbSAICBPOCatalogosDataSet.stpSelPlazaCliente);


                stpSelRegimenFiscalSATTableAdapter1.Fill(dbSAIC_Catalogos.stpSelRegimenFiscalSAT);

                // Set column widths according to their contents. 
                cboIdClienteProveedor.Properties.View.BestFitColumns();
                // Specify the total dropdown width. 
                cboIdClienteProveedor.Properties.PopupFormWidth = 800;
                // Set column widths according to their contents. 
                cboIdActividadComercial.Properties.View.BestFitColumns();
                // Specify the total dropdown width. 
                cboIdActividadComercial.Properties.PopupFormWidth = 800;
                // Set column widths according to their contents. 
                cbGrupo.Properties.View.BestFitColumns();
                // Specify the total dropdown width. 
                cbGrupo.Properties.PopupFormWidth = 800;

                cbCategoriaCliente.Properties.View.BestFitColumns();
                cbCategoriaCliente.Properties.PopupFormWidth = 800;

                // Set column widths according to their contents. 
                cbIdOperador.Properties.View.BestFitColumns();
                // Specify the total dropdown width. 
                cbIdOperador.Properties.PopupFormWidth = 800;
                // Set column widths according to their contents. 
                cbRelIdPromotor.Properties.View.BestFitColumns();
                // Specify the total dropdown width. 
                cbRelIdPromotor.Properties.PopupFormWidth = 800;
                // Set column widths according to their contents. 
                cbPromotor.Properties.View.BestFitColumns();
                // Specify the total dropdown width. 
                cbPromotor.Properties.PopupFormWidth = 600;


                //if (OperadorBD.OperadorGlobal.IdAreaOperativa == 1 || OperadorBD.OperadorGlobal.IdAreaOperativa == 6)
                //    bFlagAcceso = true;
                //else
                //    bFlagAcceso = false;

                ActivarDesactivarBotones(true);
                ActivarControlesInfoCliente(false);     //desactivar controles formulario

                tcgInformacionAdicional.SelectedTabPageIndex = 0;   //visualizar la primer pestaña
                tipoOperacionABC = Constantes.TipoOperacionABC.Ninguno; //tipo de Operacion ABC = NIGUNO

                //Obtener el acceso para la opcion Fronting
                bFlagAcceso = obtenerAcceso();

                if (obtenerAccesoPromotores())
                {
                    btnPromotores.Visible = true;
                }
                else
                {
                    btnPromotores.Visible = false;
                }

                splashSMCargando.CloseWaitForm();
            }
            catch (Exception ex)
            {
                splashSMCargando.CloseWaitForm();
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCrearPromotor_Click(object sender, EventArgs e)
        {
            frmxPromotores objPromotores = new frmxPromotores();
            objPromotores.ShowDialog();     //mostrar pantalla
            this.stpFactSelPromotorClienteTableAdapter.Fill(this.dbSAICBPOFactura.stpFactSelPromotorCliente);     //actualizar Table Adapter
        }

        private void cboIdClienteProveedor_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                //obtener el renglon completo del Combobox
                DataRow row = gridLookUpEdit1View.GetDataRow(gridLookUpEdit1View.FocusedRowHandle);

                //obtener la informacion del Cliente
                Cliente objCliente = ClienteBD.AsignarInfoCliente(row);

                if (objCliente != null)
                    MostrarInfoCliente(objCliente);
                else
                    XtraMessageBox.Show("¡La información del cliente seleccionado no está disponible! \nContacte a Sistemas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    Validator.IsPresent(cboIdTipoClienteProveedor) && Validator.IsPositiveOrZeroNumber(spPctAsimilados) &&
                    Validator.IsPositiveOrZeroNumber(spPctComisionBPO) && Validator.IsPositiveOrZeroNumber(spSaldoFavor) &&
                    Validator.IsPositiveOrZeroNumber(spFinanciamiento) && Validator.IsPresent(cboIdEstatus) &&
                    Validator.IsPresent(cbProductos) && Validator.IsPresent(chkbPeriodicidad) &&
                    //Validator.IsPresent(chkbFronting) && Validator.IsPresent(chkbPromotor) &&
                    Validator.IsPresent(chkbComision) && Validator.IsPresent(cbGrupo) && Validator.IsPresent(cbCategoriaCliente) &&
                    Validator.IsPositiveOrZeroNumberGrid(cbPlazaCliente) &&
                    Validator.IsPresent(cboIdRegimenFiscalSAT) &&
                    Validator.IsPositiveOrZeroNumber(spPctBPOTarjeta) && Validator.IsPositiveOrZeroNumber(spPctBPOCucas) &&
                    Validator.IsPositiveOrZeroNumber(spPctBPOEfectivo) && Validator.IsPositiveOrZeroNumber(spPctBPOSeguros) &&
                    Validator.IsPositiveOrZeroNumber(spPctBPOProveedor) && Validator.IsPositiveOrZeroNumber(spPctBPOGasto) &&
                    Validator.IsPositiveOrZeroNumber(spPctBPOOtro) &&
                    Validator.IsPositiveOrZeroNumber(spPctProTarjeta) && Validator.IsPositiveOrZeroNumber(spPctProCucas) &&
                    Validator.IsPositiveOrZeroNumber(spPctProEfectivo) && Validator.IsPositiveOrZeroNumber(spPctProSeguros) &&
                    Validator.IsPositiveOrZeroNumber(spPctProProveedor) && Validator.IsPositiveOrZeroNumber(spPctProGasto) &&
                    Validator.IsPositiveOrZeroNumber(spPctProOtro)
                    )
                {
                    Cliente objCliente = AsignarInfoCliente();

                    int? pOk = 0;
                    if (objCliente != null)
                    {
                        if (tipoOperacionABC == Constantes.TipoOperacionABC.Nuevo)
                        {
                            int? pIdCliente = 0;

                            this.clienteTableAdapter.Insert(objCliente.CodigoClienteProvedor, objCliente.RazonSocial, objCliente.NombreComercial,
                                objCliente.RFC, objCliente.CURP, objCliente.IdActividadComercial, objCliente.IdMatrizCliente, objCliente.Calle, objCliente.NoExterior,
                                objCliente.NoInterior, objCliente.Colonia, objCliente.CodigoPostal, objCliente.IdPais, objCliente.IdEstado,
                                objCliente.NombreDelegacionMunicipio, objCliente.NombrePoblacionCiudad, objCliente.CalleOperacion,
                                objCliente.NoExteriorOperacion, objCliente.NoInteriorOperacion, objCliente.ColoniaOperacion, objCliente.CodigoPostalOperacion,
                                objCliente.IdPaisOperacion, objCliente.IdEstadoOperacion, objCliente.NombreDelegacionMunicipioOperacion,
                                objCliente.NombrePoblacionCiudadOperacion, objCliente.RepresentanteLegal, objCliente.Contacto, objCliente.Telefono1, objCliente.Telefono2,
                                objCliente.CorreoElectronico, objCliente.PaginaWeb, objCliente.IdOperador, objCliente.IdTipoClienteProveedor,
                                objCliente.IdClaseRiesgo, objCliente.ISN, objCliente.TieneSucursales, objCliente.Confidencial, objCliente.Seguro, objCliente.Decreto, objCliente.Sindicato,
                                objCliente.PctComisionBPO,
                                objCliente.PctAsimilados,
                                objCliente.SaldoAFavor,
                                objCliente.Financiamiento,
                                objCliente.FechaBaja,
                                objCliente.Observaciones,
                                objCliente.IdEstatus,
                                OperadorBD.OperadorGlobal.NombreUsuario,
                                objCliente.idPlazaCliente,
                                objCliente.IdRegimenFiscal,
                                objCliente.RegimenCapital,
                                objCliente.idCategoriaCliente,
                                ref pIdCliente);

                            if (pIdCliente == 0)        //si existe Id asignado => Alta del cliente exitosa
                                XtraMessageBox.Show("¡El alta del cliente NO ha sido exitosa!\nContacte a Sistemas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else
                            {
                                this.stpSelClientePCTProductoTableAdapter1.stpUpdClientePCTProducto(pIdCliente, objCliente.Tarjeta, objCliente.TarjetaP, objCliente.Cucas, objCliente.CucasP, objCliente.Efectivos, objCliente.EfectivosP, objCliente.Seguros, objCliente.SegurosP, objCliente.Proveedor, objCliente.ProveedorP, objCliente.Gasto, objCliente.GastoP, objCliente.Otro, objCliente.OtroP, OperadorBD.OperadorGlobal.NombreUsuario, ref pOk);

                                spSoloRespuesta1.stpFactInsClientePrPePrCoFo(pIdCliente, Productos, Periodo, Fronting, Promotor, Comision, OperadorBD.OperadorGlobal.NombreUsuario, 0);
                                txtIdCliente.Text = pIdCliente.ToString();

                                ActivarDesactivarBotones(true);
                                ActivarControlesInfoCliente(false);      //desactivar controles formulario
                                tipoOperacionABC = Constantes.TipoOperacionABC.Ninguno; //tipo de Operacion ABC = NIGUNO
                                XtraMessageBox.Show("¡El alta del cliente ha sido exitosa!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                // actualizar Table Adapter
                                // TODO: This line of code loads data into the 'dbSAIC_Catalogos.stpSelControlCliente' table. You can move, or remove it, as needed.
                                this.stpFactSelControlClienteTableAdapter.Fill(this.dbSAICBPOFactura.stpFactSelControlCliente);
                                LimpiarControlesInfoCliente();
                            }
                        }
                        else if (tipoOperacionABC == Constantes.TipoOperacionABC.Editar)
                        {
                            int intNoRegistrosAfectados = this.clienteTableAdapter.Update(objCliente.CodigoClienteProvedor, objCliente.RazonSocial, objCliente.NombreComercial,
                                objCliente.RFC, objCliente.CURP, objCliente.IdActividadComercial, objCliente.IdMatrizCliente, objCliente.Calle, objCliente.NoExterior,
                                objCliente.NoInterior, objCliente.Colonia, objCliente.CodigoPostal, objCliente.IdPais, objCliente.IdEstado, objCliente.NombreDelegacionMunicipio,
                                objCliente.NombrePoblacionCiudad, objCliente.CalleOperacion, objCliente.NoExteriorOperacion, objCliente.NoInteriorOperacion,
                                objCliente.ColoniaOperacion, objCliente.CodigoPostalOperacion, objCliente.IdPaisOperacion, objCliente.IdEstadoOperacion,
                                objCliente.NombreDelegacionMunicipioOperacion, objCliente.NombrePoblacionCiudadOperacion, objCliente.RepresentanteLegal, objCliente.Contacto,
                                objCliente.Telefono1, objCliente.Telefono2, objCliente.CorreoElectronico, objCliente.PaginaWeb, objCliente.IdOperador,
                                objCliente.IdTipoClienteProveedor, objCliente.IdClaseRiesgo, objCliente.ISN, objCliente.TieneSucursales, objCliente.Confidencial,
                                objCliente.Seguro, objCliente.Decreto, objCliente.Sindicato, objCliente.PctComisionBPO, objCliente.PctAsimilados, objCliente.SaldoAFavor, objCliente.Financiamiento,
                                objCliente.FechaBaja, objCliente.Observaciones, objCliente.IdEstatus,
                                OperadorBD.OperadorGlobal.NombreUsuario, Convert.ToInt32(txtIdCliente.Text), objCliente.idPlazaCliente, objCliente.IdRegimenFiscal, objCliente.RegimenCapital, objCliente.idCategoriaCliente);

                            if (intNoRegistrosAfectados == 0)        //si existe Id asignado => Alta del cliente exitosa
                                XtraMessageBox.Show("¡La modificación del cliente NO ha sido exitosa!\nContacte a Sistemas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else
                            {
                                this.stpSelClientePCTProductoTableAdapter1.stpUpdClientePCTProducto(objCliente.IdCliente, objCliente.Tarjeta, objCliente.TarjetaP, objCliente.Cucas, objCliente.CucasP, objCliente.Efectivos, objCliente.EfectivosP, objCliente.Seguros, objCliente.SegurosP, objCliente.Proveedor, objCliente.ProveedorP, objCliente.Gasto, objCliente.GastoP, objCliente.Otro, objCliente.OtroP, OperadorBD.OperadorGlobal.NombreUsuario, ref pOk);

                                spSoloRespuesta1.stpFactInsClientePrPePrCoFo(Convert.ToInt32(txtIdCliente.Text), Productos, Periodo, Fronting, Promotor, Comision, OperadorBD.OperadorGlobal.NombreUsuario, 0);
                                ActivarDesactivarBotones(true);
                                ActivarControlesInfoCliente(false);      //desactivar controles formulario
                                tipoOperacionABC = Constantes.TipoOperacionABC.Ninguno; //tipo de Operacion ABC = NIGUNO
                                XtraMessageBox.Show("¡La modificación del cliente ha sido exitosa!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                // TODO: This line of code loads data into the 'dbSAIC_Catalogos.stpSelControlCliente' table. You can move, or remove it, as needed.
                                this.stpFactSelControlClienteTableAdapter.Fill(this.dbSAICBPOFactura.stpFactSelControlCliente);
                                LimpiarControlesInfoCliente();
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
                XtraMessageBox.Show("No ha seleccionado un Cliente para modificar su información.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCrearProducto_Click(object sender, EventArgs e)
        {
            Catalogos.frmxProductos objProductos = new Catalogos.frmxProductos();
            objProductos.ShowDialog();      //mostrar pantalla
            //this.productoTableAdapter.Fill(this.dbSAIC_Catalogos.Producto);     //actualizar Table Adapter
        }

        private void btnAsignarDomicilioFiscal2DomicilioOperacion_Click(object sender, EventArgs e)
        {
            //copiar la informacion del Domicilio Fiscal a Domicilio Operacion
            txtCalleOperacion.Text = txtCalle.Text;
            txtNoExteriorOperacion.Text = txtNoExterior.Text;
            txtNoInteriorOperacion.Text = txtNoInterior.Text;
            txtColoniaOperacion.Text = txtColonia.Text;
            txtCodigoPostalOperacion.Text = txtCodigoPostal.Text;
            cboIdEstadoOperacion.EditValue = cboIdEstado.EditValue;
            cboIdPaisOperacion.EditValue = cboIdPais.EditValue;
            txtNombreDelegacionMunicipioOperacion.Text = txtNombreDelegacionMunicipio.Text;
            txtNombrePoblacionCiudadOperacion.Text = txtNombrePoblacionCiudad.Text;
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

        private void btnFronting_Click(object sender, EventArgs e)
        {
        }

        private void btnPromotor_Click(object sender, EventArgs e)
        {
            Catalogos.frmxPromotores objPromotores = new Catalogos.frmxPromotores();
            objPromotores.ShowDialog();     //mostrar pantalla
            this.stpFactSelPromotorClienteTableAdapter.Fill(this.dbSAICBPOFactura.stpFactSelPromotorCliente); //actualizar Table Adapter
        }

        private void btnGrupo_Click(object sender, EventArgs e)
        {
            Catalogos.frmxClientesMatriz objCliente = new Catalogos.frmxClientesMatriz();
            objCliente.ShowDialog();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            Int32 intIdCliente = 0;
            //si existen Lotes de Carga de Nomina en el gridview
            if (cboIdClienteProveedor.EditValue != null)
            {
                //Obtener el Id del Lote de Carga Nomina
                //para asignarlo a los recibos
                intIdCliente = Convert.ToInt32(cboIdClienteProveedor.EditValue.ToString());

                if (intIdCliente > 0)       //si seleccionamos un Lote de Carga Nomina
                {
                    // splashScreenManager1.ShowWaitForm();        //mostrar pantalla de espera
                    this.Cursor = Cursors.AppStarting;      //cambiar cursor del mouse

                    MostrarReporte(intIdCliente);

                    this.Cursor = Cursors.Default;      //cambiar cursor del mouse
                                                        // splashScreenManager1.CloseWaitForm();   //quitar pantalla de espera
                }
                else
                    XtraMessageBox.Show("Seleccione un Cliente para obtener Carta de Instrucción", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                XtraMessageBox.Show("Seleccione un Cliente para obtener Carta de Instrucción.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void MostrarReporte(Int32 pIdCliente)
        {
            //crear reporte
            CartaInstruccion report = new CartaInstruccion();
            try
            {
                //asignar parametros del reporte
                report.Parameters["pIdCliente"].Value = pIdCliente;

                report.ShowPrintMarginsWarning = false;     //no mostrar mensaje de margenes

                //mostrar reporte
                report.ShowPreview();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private Boolean obtenerAcceso()
        {
            Boolean flagFronting = false;
            this.stpFactSelDerechosAccesoOperadorFacturacionTableAdapter1.Fill(this.dbSAICBPOFactura1.stpFactSelDerechosAccesoOperadorFacturacion, OperadorBD.OperadorGlobal.IdOperador, "Catalogos.frmxClientes", "btnAcceso");
            if (dbSAICBPOFactura1.stpFactSelDerechosAccesoOperadorFacturacion.Rows.Count > 0)
            {
                Boolean.TryParse(dbSAICBPOFactura1.stpFactSelDerechosAccesoOperadorFacturacion.Rows[0]["Consultar"].ToString(), out flagFronting);
            }
            else
            {
                flagFronting = false;
            }

            return flagFronting;
        }

        private Boolean obtenerAccesoPromotores()
        {
            Boolean flagFronting = false;
            this.stpFactSelDerechosAccesoOperadorFacturacionTableAdapter1.Fill(this.dbSAICBPOFactura1.stpFactSelDerechosAccesoOperadorFacturacion, OperadorBD.OperadorGlobal.IdOperador, "Catalogos.frmxClientes", "btnAccesoPromotores");
            if (dbSAICBPOFactura1.stpFactSelDerechosAccesoOperadorFacturacion.Rows.Count > 0)
            {
                Boolean.TryParse(dbSAICBPOFactura1.stpFactSelDerechosAccesoOperadorFacturacion.Rows[0]["Consultar"].ToString(), out flagFronting);
            }
            else
            {
                flagFronting = false;
            }

            return flagFronting;
        }

        private void btnAgregarPromo_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validator.IsPresent(cbPromotor) &&
                    Validator.IsPositiveOrZeroNumber(spComision) &&
                    Validator.IsPositiveOrZeroNumber(spIVA) &&
                    Validator.IsPositiveOrZeroNumber(spUtilidadReal) && txtIdCliente.Text != "0")
                {
                    if (Convert.ToDecimal(spComision.EditValue.ToString()) < 100 && Convert.ToDecimal(spIVA.EditValue.ToString()) < 100 &&
                        Convert.ToDecimal(spUtilidadReal.EditValue.ToString()) < 100)
                    {
                        if (Convert.ToDecimal(spComision.EditValue.ToString()) + PCTComision < 100 &&
                           Convert.ToDecimal(spIVA.EditValue.ToString()) + PCTIVA < 100 &&
                           Convert.ToDecimal(spUtilidadReal.EditValue.ToString()) + PCTUtilidadReal < 100)
                        {
                            Int64? pIdPC = 0;

                            this.stpSelClientePromotoresTableAdapter.Insert(Convert.ToInt32(txtIdCliente.Text), Convert.ToInt32(cbPromotor.EditValue), Convert.ToDecimal(spComision.EditValue), Convert.ToDecimal(spIVA.EditValue), Convert.ToDecimal(spUtilidadReal.EditValue), txtObservacionesPromo.Text, 2, OperadorBD.OperadorGlobal.NombreUsuario, ref pIdPC);

                            if (pIdPC == 0)        //si existe Id asignado => Alta del cliente exitosa
                                XtraMessageBox.Show("¡El alta del Promotor NO ha sido exitosa!\nContacte a Sistemas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else
                            {
                                XtraMessageBox.Show("¡El alta del Promotor ha sido exitosa!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                cbPromotor.EditValue = -1;
                                spComision.EditValue = 0;
                                spIVA.EditValue = 0;
                                spUtilidadReal.EditValue = 0;
                                txtObservacionesPromo.Text = "";
                                this.stpSelClientePromotoresTableAdapter.Fill(this.dbSAIC_Catalogos.stpSelClientePromotores, Convert.ToInt32(txtIdCliente.Text));
                            }
                        }
                        else
                            XtraMessageBox.Show("¡El(Los) Porcentaje(s) de Comisión entre Promotores no debe de superar el 100.00 %.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        XtraMessageBox.Show("¡El(Los) Porcentaje(s) de Comisión no debe de superar el 100.00 %.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardarPromo_Click(object sender, EventArgs e)
        {
            try
            {
                if (IdPromotor>0 &&
                    Validator.IsPositiveOrZeroNumber(spComision) &&
                    Validator.IsPositiveOrZeroNumber(spIVA) &&
                    Validator.IsPositiveOrZeroNumber(spUtilidadReal) && txtIdCliente.Text != "0")
                {
                    if (Convert.ToDecimal(spComision.EditValue.ToString()) < 100 && Convert.ToDecimal(spIVA.EditValue.ToString()) < 100 &&
                        Convert.ToDecimal(spUtilidadReal.EditValue.ToString()) < 100)
                    {
                        Int32? pIdPC = 0;
                        if (Convert.ToDecimal(spComision.EditValue.ToString()) + PCTComision < 100 &&
                               Convert.ToDecimal(spIVA.EditValue.ToString()) + PCTIVA < 100 &&
                               Convert.ToDecimal(spUtilidadReal.EditValue.ToString()) + PCTUtilidadReal < 100)
                        {

                            this.stpSelClientePromotoresTableAdapter.Update(Convert.ToInt64(cbRelIdPromotor.EditValue), Convert.ToDecimal(spComision.EditValue), Convert.ToDecimal(spIVA.EditValue), Convert.ToDecimal(spUtilidadReal.EditValue), txtObservacionesPromo.Text, 2, OperadorBD.OperadorGlobal.NombreUsuario, ref pIdPC);

                            if (pIdPC == 0)        //si existe Id asignado => Alta del cliente exitosa
                                XtraMessageBox.Show("¡La Modificación del Promotor NO ha sido exitosa!\nContacte a Sistemas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else
                            {
                                btnAgregarPromo.Enabled = true;
                                XtraMessageBox.Show("¡La Modificación del Promotor ha sido exitosa!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                cbPromotor.EditValue = -1;
                                spComision.EditValue = 0;
                                spIVA.EditValue = 0;
                                spUtilidadReal.EditValue = 0;
                                txtObservacionesPromo.Text = "";
                                btnAgregarPromo.Enabled = true;
                                btnModificPromotor.Enabled = true;
                                btnGuardarPromo.Enabled = false;
                                btnEliminarProm.Enabled = false;
                                btnCancelarPro.Enabled = false;
                                this.stpSelClientePromotoresTableAdapter.Fill(this.dbSAIC_Catalogos.stpSelClientePromotores, Convert.ToInt32(txtIdCliente.Text));
                            }
                        }
                        else
                            XtraMessageBox.Show("¡El(Los) Porcentaje(s) de Comisión entre Promotores no debe de superar el 100.00 %.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        XtraMessageBox.Show("¡El(Los) Porcentaje(s) de Comisión no debe de superar el 100.00 %.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarProm_Click(object sender, EventArgs e)
        {
            try
            {
                if (IdPromotor > 0 &&
                    Validator.IsPositiveOrZeroNumber(spComision) &&
                    Validator.IsPositiveOrZeroNumber(spIVA) &&
                    Validator.IsPositiveOrZeroNumber(spUtilidadReal) && txtIdCliente.Text != "0")
                {
                    Int32? pIdPC = 0;

                    this.stpSelClientePromotoresTableAdapter.Update(Convert.ToInt64(cbRelIdPromotor.EditValue), Convert.ToDecimal(spComision.EditValue), Convert.ToDecimal(spIVA.EditValue), Convert.ToDecimal(spUtilidadReal.EditValue),txtObservacionesPromo.Text, 3, OperadorBD.OperadorGlobal.NombreUsuario, ref pIdPC);

                    if (pIdPC == 0)        //si existe Id asignado => Alta del cliente exitosa
                        XtraMessageBox.Show("¡La Eliminación del Promotor NO ha sido exitosa!\nContacte a Sistemas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        XtraMessageBox.Show("¡La Eliminación del Promotor ha sido exitosa!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        cbPromotor.EditValue = -1;
                        spComision.EditValue = 0;
                        spIVA.EditValue = 0;
                        spUtilidadReal.EditValue = 0;
                        txtObservacionesPromo.Text = "";
                        IdPromotor = 0;
                        btnAgregarPromo.Enabled = true;
                        btnModificPromotor.Enabled = true;
                        btnGuardarPromo.Enabled = false;
                        btnEliminarProm.Enabled = false;
                        btnCancelarPro.Enabled = false;
                        this.stpSelClientePromotoresTableAdapter.Fill(this.dbSAIC_Catalogos.stpSelClientePromotores, Convert.ToInt32(txtIdCliente.Text));
                    }

                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificPromotor_Click(object sender, EventArgs e)
        {
            try
            {
                //obtener el renglon completo del Combobox
                DataRow row = gridView7.GetDataRow(gridView7.FocusedRowHandle);

                if (row != null)
                {
                    cbPromotor.EditValue = row[1].ToString();
                    IdPromotor =(Int32)row[1];
                    spComision.Text = row[3].ToString();
                    spIVA.Text = row[5].ToString();
                    spUtilidadReal.Text = row[6].ToString();
                    txtObservacionesPromo.Text = row[4].ToString();

                    this.stpSelClientePromotoresPorcetajeClienteTableAdapter1.Fill(this.dbSAIC_Catalogos.stpSelClientePromotoresPorcetajeCliente, Convert.ToInt32(txtIdCliente.Text), (Int32)row[1]);

                    if (this.dbSAIC_Catalogos.stpSelClientePromotoresPorcetajeCliente.Count > 0)
                    {
                        DataRow row1 = this.dbSAIC_Catalogos.stpSelClientePromotoresPorcetajeCliente.Rows[0];

                        PCTComision = (decimal)row1[0];
                        PCTIVA = (decimal)row1[1];
                        PCTUtilidadReal = (decimal)row1[2];
                        row1 = null;
                    }
                    else
                    {
                        PCTComision = 0;
                        PCTIVA = 0;
                        PCTUtilidadReal = 0;
                    }

                    btnAgregarPromo.Enabled = false;
                    btnModificPromotor.Enabled = false;
                    btnGuardarPromo.Enabled = true;
                    btnEliminarProm.Enabled = true;
                    btnCancelarPro.Enabled = true;
                }
                else
                    XtraMessageBox.Show("¡La información del Promotor seleccionado no está disponible! \nContacte a Sistemas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelarPro_Click(object sender, EventArgs e)
        {
            cbPromotor.EditValue = -1;
            spComision.EditValue = 0;
            spIVA.EditValue = 0;
            spUtilidadReal.EditValue = 0;
            txtObservacionesPromo.Text = "";
            IdPromotor = 0;
            btnAgregarPromo.Enabled = true;
            btnModificPromotor.Enabled = true;
            btnGuardarPromo.Enabled = false;
            btnEliminarProm.Enabled = false;
            btnCancelarPro.Enabled = false;
        }

        private void btnPromotores_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent(txtIdCliente) && txtIdCliente.Text != "0")
            {
                Catalogos.XtraListaPromotores objVen = new Catalogos.XtraListaPromotores()
                {
                    bIdCliente = Convert.ToInt32(txtIdCliente.Text)
                };
                objVen.ShowDialog();
            }
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            frmxCategoria ofrmxCategoria = new frmxCategoria();
            ofrmxCategoria.ShowDialog();
            stpSelCategoriaClienteTableAdapter.Fill(dbSAICBPOCatalogosDataSet.stpSelCategoriaCliente, 1);
        }

        private void cbRelIdPromotor_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                DataRow row1 = gridView7.GetDataRow(gridView7.FocusedRowHandle);

                if (row1 != null)
                {
                    this.stpSelClientePromotoresPorcetajeClienteTableAdapter1.Fill(this.dbSAIC_Catalogos.stpSelClientePromotoresPorcetajeCliente, Convert.ToInt32(txtIdCliente.Text), Convert.ToInt32(row1[1]));

                    if (this.dbSAIC_Catalogos.stpSelClientePromotoresPorcetajeCliente.Count > 0)
                    {
                        DataRow row = this.dbSAIC_Catalogos.stpSelClientePromotoresPorcetajeCliente.Rows[0];

                        PCTComision = (decimal)row[0];
                        PCTIVA = (decimal)row[1];
                        PCTUtilidadReal = (decimal)row[2];
                        row = null;
                    }
                    else
                    {
                        PCTComision = 0;
                        PCTIVA = 0;
                        PCTUtilidadReal = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}