namespace winAppSAIC.Catalogos
{
    partial class frmxClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmxClientes));
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnSalir = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dbSAICBPOCatalogosDataSet = new winAppSAIC.dbSAICBPOCatalogosDataSet();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.btnAgregarCategoria = new DevExpress.XtraEditors.SimpleButton();
            this.cbCategoriaCliente = new DevExpress.XtraEditors.GridLookUpEdit();
            this.stpSelCategoriaClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView9 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidCategoriaCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescCategoria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescEstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chkSindicato = new DevExpress.XtraEditors.CheckEdit();
            this.btnGrupo = new DevExpress.XtraEditors.SimpleButton();
            this.btnCrearProducto = new DevExpress.XtraEditors.SimpleButton();
            this.txtObservaciones = new DevExpress.XtraEditors.MemoEdit();
            this.btnEditar = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnNuevo = new DevExpress.XtraEditors.SimpleButton();
            this.cboIdClienteProveedor = new DevExpress.XtraEditors.GridLookUpEdit();
            this.stpFactSelControlClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPOFactura = new winAppSAIC.Facturas.dbSAICBPOFactura();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRazonSocial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreComercial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRFC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCURP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdActividadComercial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMatrizCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoExterior = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoInterior = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colColonia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigoPostal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdPais = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreDelegacionMunicipio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombrePoblacionCiudad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCalleOperacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoExteriorOperacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoInteriorOperacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colColoniaOperacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigoPostalOperacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdPaisOperacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstadoOperacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreDelegacionMunicipioOperacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombrePoblacionCiudadOperacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRepresentanteLegal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContacto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefono1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefono2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCorreoElectronico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaginaWeb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdOperador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoClienteProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdClaseRiesgo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colISN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTieneSucursales = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colConfidencial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeguro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDecreto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSindicato = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPctComisionBPO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPctAsimilados = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaBaja = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservaciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaModificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioCreacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioModificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnRegimenFiscal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnRegimenCapital = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4idCategoriaCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnABC_ActividadComercial = new DevExpress.XtraEditors.SimpleButton();
            this.btnAsignarDomicilioFiscal2DomicilioOperacion = new DevExpress.XtraEditors.SimpleButton();
            this.txtRazonSocial = new DevExpress.XtraEditors.TextEdit();
            this.txtNombreComercial = new DevExpress.XtraEditors.TextEdit();
            this.txtRFC = new DevExpress.XtraEditors.TextEdit();
            this.txtCalle = new DevExpress.XtraEditors.TextEdit();
            this.txtNoExterior = new DevExpress.XtraEditors.TextEdit();
            this.txtNoInterior = new DevExpress.XtraEditors.TextEdit();
            this.txtColonia = new DevExpress.XtraEditors.TextEdit();
            this.txtCodigoPostal = new DevExpress.XtraEditors.TextEdit();
            this.cboIdPais = new DevExpress.XtraEditors.LookUpEdit();
            this.stpSelPaisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAIC_Catalogos = new winAppSAIC.Catalogos.dbSAIC_Catalogos();
            this.cboIdEstado = new DevExpress.XtraEditors.LookUpEdit();
            this.stpSelEstadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtNombreDelegacionMunicipio = new DevExpress.XtraEditors.TextEdit();
            this.txtNombrePoblacionCiudad = new DevExpress.XtraEditors.TextEdit();
            this.txtCalleOperacion = new DevExpress.XtraEditors.TextEdit();
            this.txtNoExteriorOperacion = new DevExpress.XtraEditors.TextEdit();
            this.txtNoInteriorOperacion = new DevExpress.XtraEditors.TextEdit();
            this.txtColoniaOperacion = new DevExpress.XtraEditors.TextEdit();
            this.txtCodigoPostalOperacion = new DevExpress.XtraEditors.TextEdit();
            this.cboIdPaisOperacion = new DevExpress.XtraEditors.LookUpEdit();
            this.stpSelPaisBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cboIdEstadoOperacion = new DevExpress.XtraEditors.LookUpEdit();
            this.stpSelEstadoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtNombreDelegacionMunicipioOperacion = new DevExpress.XtraEditors.TextEdit();
            this.txtNombrePoblacionCiudadOperacion = new DevExpress.XtraEditors.TextEdit();
            this.txtTelefono1 = new DevExpress.XtraEditors.TextEdit();
            this.txtTelefono2 = new DevExpress.XtraEditors.TextEdit();
            this.txtContacto = new DevExpress.XtraEditors.TextEdit();
            this.txtCorreoElectronico = new DevExpress.XtraEditors.TextEdit();
            this.txtPaginaWeb = new DevExpress.XtraEditors.TextEdit();
            this.cboIdEstatus = new DevExpress.XtraEditors.LookUpEdit();
            this.vwCatEstatusClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chkConfidencial = new DevExpress.XtraEditors.CheckEdit();
            this.chkTieneSucursales = new DevExpress.XtraEditors.CheckEdit();
            this.spPctComisionBPO = new DevExpress.XtraEditors.SpinEdit();
            this.calFechaBaja = new DevExpress.XtraEditors.DateEdit();
            this.UsuarioCreacionTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.UsuarioModificacionTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.txtIdCliente = new DevExpress.XtraEditors.TextEdit();
            this.cboIdActividadComercial = new DevExpress.XtraEditors.GridLookUpEdit();
            this.actividadComercialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdActividadComercial1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescActividadComercial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chkSeguro = new DevExpress.XtraEditors.CheckEdit();
            this.txtRepresentanteLegal = new DevExpress.XtraEditors.TextEdit();
            this.spPctAsimilados = new DevExpress.XtraEditors.SpinEdit();
            this.spISN = new DevExpress.XtraEditors.SpinEdit();
            this.chkDecreto = new DevExpress.XtraEditors.CheckEdit();
            this.chkbPeriodicidad = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.stpFactSelTipoPeriodoNominaClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chkbFronting = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.vwcatFrontingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chkbComision = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.stpFactSelComisionClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbGrupo = new DevExpress.XtraEditors.GridLookUpEdit();
            this.stpFactSelMatrizClienteActivosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdMatrizCliente0 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRazonSocial0 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbIdOperador = new DevExpress.XtraEditors.GridLookUpEdit();
            this.stpSelOperadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPODataSet = new winAppSAIC.dbSAICBPODataSet();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdOperador0 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOperador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbProductos = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbIdClaseRiesgo = new DevExpress.XtraEditors.GridLookUpEdit();
            this.stpFactSelClaseRiesgoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.COLIdClaseRiesgoIMSS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COLDescClaseRiesgoIMSS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboIdTipoClienteProveedor = new DevExpress.XtraEditors.GridLookUpEdit();
            this.tipoClienteProveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescTipoClienteProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnExportar = new DevExpress.XtraEditors.SimpleButton();
            this.cboIdRegimenFiscalSAT = new DevExpress.XtraEditors.LookUpEdit();
            this.stpSelRegimenFiscalSATBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbPlazaCliente = new DevExpress.XtraEditors.GridLookUpEdit();
            this.stpSelPlazaClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.spSaldoFavor = new DevExpress.XtraEditors.SpinEdit();
            this.spFinanciamiento = new DevExpress.XtraEditors.SpinEdit();
            this.spComision = new DevExpress.XtraEditors.SpinEdit();
            this.txtObservacionesPromo = new DevExpress.XtraEditors.TextEdit();
            this.btnAgregarPromo = new DevExpress.XtraEditors.SimpleButton();
            this.btnEliminarProm = new DevExpress.XtraEditors.SimpleButton();
            this.btnModificPromotor = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardarPromo = new DevExpress.XtraEditors.SimpleButton();
            this.cbRelIdPromotor = new DevExpress.XtraEditors.GridLookUpEdit();
            this.stpSelClientePromotoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView7 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdRelClientePromotor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdPromotor1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreCompletoPromotor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComision = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIVA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUtilidadReal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservaciones1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbPromotor = new DevExpress.XtraEditors.GridLookUpEdit();
            this.stpSelPromotoresActivosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICCatalogosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView8 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdPromotor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CorreoElectronico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnCancelarPro = new DevExpress.XtraEditors.SimpleButton();
            this.RegimenCapitaltextEdit = new DevExpress.XtraEditors.TextEdit();
            this.btnPromotores = new DevExpress.XtraEditors.SimpleButton();
            this.spIVA = new DevExpress.XtraEditors.SpinEdit();
            this.spUtilidadReal = new DevExpress.XtraEditors.SpinEdit();
            this.spPctBPOTarjeta = new DevExpress.XtraEditors.SpinEdit();
            this.spPctProTarjeta = new DevExpress.XtraEditors.SpinEdit();
            this.spPctBPOCucas = new DevExpress.XtraEditors.SpinEdit();
            this.spPctProCucas = new DevExpress.XtraEditors.SpinEdit();
            this.spPctBPOEfectivo = new DevExpress.XtraEditors.SpinEdit();
            this.spPctProEfectivo = new DevExpress.XtraEditors.SpinEdit();
            this.spPctBPOSeguros = new DevExpress.XtraEditors.SpinEdit();
            this.spPctProSeguros = new DevExpress.XtraEditors.SpinEdit();
            this.spPctBPOProveedor = new DevExpress.XtraEditors.SpinEdit();
            this.spPctProProveedor = new DevExpress.XtraEditors.SpinEdit();
            this.ItemForUsuarioCreacion = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForUsuarioModificacion = new DevExpress.XtraLayout.LayoutControlItem();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup5 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.tcgInformacionAdicional = new DevExpress.XtraLayout.TabbedControlGroup();
            this.layoutControlGroup9 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.simpleLabelItem1 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.simpleLabelItem2 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.simpleLabelItem3 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.simpleLabelItem4 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.simpleLabelItem5 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.layoutControlItem44 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem45 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem13 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem46 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem47 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem48 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem49 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem50 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem51 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem52 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem53 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleLabelItem6 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.simpleLabelItem7 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.simpleLabelItem8 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.simpleLabelItem9 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.emptySpaceItem19 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem20 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem21 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForCalle = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNoExterior = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNoInterior = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForColonia = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForIdEstado = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNombreDelegacionMunicipio = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNombrePoblacionCiudad = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForIdPais = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCodigoPostal = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem7 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.ItemForRegimenFiscalSAT = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForCalleOperacion = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNoExteriorOperacion = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForColoniaOperacion = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForIdEstadoOperacion = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNombreDelegacionMunicipioOperacion = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNombrePoblacionCiudadOperacion = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNoInteriorOperacion = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCodigoPostalOperacion = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForIdPaisOperacion = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem14 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem15 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForContacto = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPaginaWeb = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCorreoElectronico = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForContacto1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTelefono2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTelefono1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem24 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup7 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForIdTipoClienteProveedor = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPeriodicidad = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemClaseRiesgo = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPctComisionBPO = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem26 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lyGrupo = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem23 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem17 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem18 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.ItemForTieneSucursales = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForConfidencial = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem27 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem20 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem16 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem19 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem21 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem22 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup8 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem28 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem30 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem8 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem32 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem34 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem35 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem37 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem42 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem6 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem31 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem36 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem29 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem43 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            this.layoutControlGroup6 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForIdCliente = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.ItemForRazonSocial = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNombreComercial = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem9 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.ItemForIdActividadComercial = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForRFC = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem10 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem14 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.RegimenCapitalItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem40 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem41 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForIdEstatus = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForFechaBaja = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem11 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem12 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem25 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem39 = new DevExpress.XtraLayout.LayoutControlItem();
            this.stpFactSelPromotorClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.stpSelEstadoTableAdapter = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelEstadoTableAdapter();
            this.actividadComercialTableAdapter = new winAppSAIC.Catalogos.dbSAIC_CatalogosTableAdapters.ActividadComercialTableAdapter();
            this.tipoClienteProveedorTableAdapter = new winAppSAIC.Catalogos.dbSAIC_CatalogosTableAdapters.TipoClienteProveedorTableAdapter();
            this.stpSelPaisTableAdapter = new winAppSAIC.Catalogos.dbSAIC_CatalogosTableAdapters.stpSelPaisTableAdapter();
            this.vwCatEstatusClienteTableAdapter = new winAppSAIC.Catalogos.dbSAIC_CatalogosTableAdapters.vwCatEstatusClienteTableAdapter();
            this.spinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            this.ItemForPctComisionBPO1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.layoutControlItem15 = new DevExpress.XtraLayout.LayoutControlItem();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlItem16 = new DevExpress.XtraLayout.LayoutControlItem();
            this.checkEdit2 = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlItem17 = new DevExpress.XtraLayout.LayoutControlItem();
            this.checkEdit3 = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlItem18 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem23 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.productoTableAdapter = new winAppSAIC.Catalogos.dbSAIC_CatalogosTableAdapters.ProductoTableAdapter();
            this.stpFactSelControlClienteTableAdapter = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelControlClienteTableAdapter();
            this.stpFactSelTipoPeriodoNominaClienteTableAdapter = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelTipoPeriodoNominaClienteTableAdapter();
            this.stpFactSelPromotorClienteTableAdapter = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelPromotorClienteTableAdapter();
            this.stpFactSelClaseRiesgoTableAdapter = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelClaseRiesgoTableAdapter();
            this.vwcatFrontingTableAdapter = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.vwcatFrontingTableAdapter();
            this.stpFactSelComisionClienteTableAdapter = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelComisionClienteTableAdapter();
            this.stpSelOperadorTableAdapter = new winAppSAIC.dbSAICBPODataSetTableAdapters.stpSelOperadorTableAdapter();
            this.stpFactSelMatrizClienteActivosTableAdapter = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelMatrizClienteActivosTableAdapter();
            this.stpFactSelClientePrPePrCoFoTableAdapter1 = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelClientePrPePrCoFoTableAdapter();
            this.spSoloRespuesta1 = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.spSoloRespuesta();
            this.clienteTableAdapter = new winAppSAIC.Catalogos.dbSAIC_CatalogosTableAdapters.ClienteTableAdapter();
            this.splashSMCargando = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::winAppSAIC.frmxCargandoInformacion), true, true);
            this.stpFactSelDerechosAccesoOperadorFacturacionTableAdapter1 = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelDerechosAccesoOperadorFacturacionTableAdapter();
            this.dbSAICBPOFactura1 = new winAppSAIC.Facturas.dbSAICBPOFactura();
            this.stpSelPlazaClienteTableAdapter1 = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelPlazaClienteTableAdapter();
            this.stpSelRegimenFiscalSATTableAdapter1 = new winAppSAIC.Catalogos.dbSAIC_CatalogosTableAdapters.stpSelRegimenFiscalSATTableAdapter();
            this.simpleSeparator2 = new DevExpress.XtraLayout.SimpleSeparator();
            this.simpleSeparator3 = new DevExpress.XtraLayout.SimpleSeparator();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem33 = new DevExpress.XtraLayout.LayoutControlItem();
            this.stpSelPromotoresActivosTableAdapter = new winAppSAIC.Catalogos.dbSAIC_CatalogosTableAdapters.stpSelPromotoresActivosTableAdapter();
            this.stpSelClientePromotoresTableAdapter = new winAppSAIC.Catalogos.dbSAIC_CatalogosTableAdapters.stpSelClientePromotoresTableAdapter();
            this.buttonEdit1 = new DevExpress.XtraEditors.ButtonEdit();
            this.layoutControlItem38 = new DevExpress.XtraLayout.LayoutControlItem();
            this.stpSelCategoriaClienteTableAdapter = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelCategoriaClienteTableAdapter();
            this.stpSelClientePromotoresPorcetajeClienteTableAdapter1 = new winAppSAIC.Catalogos.dbSAIC_CatalogosTableAdapters.stpSelClientePromotoresPorcetajeClienteTableAdapter();
            this.stpSelClientePCTProductoTableAdapter1 = new winAppSAIC.Catalogos.dbSAIC_CatalogosTableAdapters.stpSelClientePCTProductoTableAdapter();
            this.emptySpaceItem22 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem24 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem25 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.simpleLabelItem10 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.simpleLabelItem11 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.simpleLabelItem12 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.spPctBPOGasto = new DevExpress.XtraEditors.SpinEdit();
            this.layoutControlItem54 = new DevExpress.XtraLayout.LayoutControlItem();
            this.spPctProGasto = new DevExpress.XtraEditors.SpinEdit();
            this.layoutControlItem55 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleLabelItem13 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.spPctBPOOtro = new DevExpress.XtraEditors.SpinEdit();
            this.layoutControlItem56 = new DevExpress.XtraLayout.LayoutControlItem();
            this.spPctProOtro = new DevExpress.XtraEditors.SpinEdit();
            this.layoutControlItem57 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem26 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbCategoriaCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelCategoriaClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSindicato.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservaciones.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboIdClienteProveedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelControlClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRazonSocial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreComercial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRFC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCalle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoExterior.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoInterior.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtColonia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoPostal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboIdPais.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelPaisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAIC_Catalogos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboIdEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelEstadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreDelegacionMunicipio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombrePoblacionCiudad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCalleOperacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoExteriorOperacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoInteriorOperacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtColoniaOperacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoPostalOperacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboIdPaisOperacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelPaisBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboIdEstadoOperacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelEstadoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreDelegacionMunicipioOperacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombrePoblacionCiudadOperacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContacto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCorreoElectronico.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPaginaWeb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboIdEstatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCatEstatusClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkConfidencial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkTieneSucursales.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spPctComisionBPO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calFechaBaja.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calFechaBaja.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioCreacionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioModificacionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboIdActividadComercial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadComercialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSeguro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRepresentanteLegal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spPctAsimilados.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spISN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDecreto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkbPeriodicidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelTipoPeriodoNominaClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkbFronting.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwcatFrontingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkbComision.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelComisionClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelMatrizClienteActivosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbIdOperador.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelOperadorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbProductos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbIdClaseRiesgo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelClaseRiesgoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboIdTipoClienteProveedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoClienteProveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboIdRegimenFiscalSAT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelRegimenFiscalSATBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPlazaCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelPlazaClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSaldoFavor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spFinanciamiento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spComision.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacionesPromo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRelIdPromotor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelClientePromotoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPromotor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelPromotoresActivosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICCatalogosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegimenCapitaltextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spIVA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spUtilidadReal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spPctBPOTarjeta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spPctProTarjeta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spPctBPOCucas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spPctProCucas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spPctBPOEfectivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spPctProEfectivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spPctBPOSeguros.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spPctProSeguros.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spPctBPOProveedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spPctProProveedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUsuarioCreacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUsuarioModificacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcgInformacionAdicional)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem44)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem45)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem46)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem47)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem48)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem49)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem51)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem52)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem53)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNoExterior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNoInterior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForColonia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNombreDelegacionMunicipio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNombrePoblacionCiudad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdPais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCodigoPostal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRegimenFiscalSAT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCalleOperacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNoExteriorOperacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForColoniaOperacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdEstadoOperacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNombreDelegacionMunicipioOperacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNombrePoblacionCiudadOperacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNoInteriorOperacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCodigoPostalOperacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdPaisOperacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForContacto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPaginaWeb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCorreoElectronico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForContacto1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTelefono2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTelefono1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdTipoClienteProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPeriodicidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemClaseRiesgo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPctComisionBPO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyGrupo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTieneSucursales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForConfidencial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem43)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRazonSocial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNombreComercial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdActividadComercial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRFC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegimenCapitalItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdEstatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFechaBaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelPromotorClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPctComisionBPO1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOFactura1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spPctBPOGasto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem54)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spPctProGasto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem55)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spPctBPOOtro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem56)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spPctProOtro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem57)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem26)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnSalir});
            this.barManager1.MaxItemId = 1;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSalir, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnSalir
            // 
            this.btnSalir.Caption = "Salir";
            this.btnSalir.Id = 0;
            this.btnSalir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.ImageOptions.Image")));
            this.btnSalir.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.ImageOptions.LargeImage")));
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSalir_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1069, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 637);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1069, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 606);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1069, 31);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 606);
            // 
            // dbSAICBPOCatalogosDataSet
            // 
            this.dbSAICBPOCatalogosDataSet.DataSetName = "dbSAICBPOCatalogosDataSet";
            this.dbSAICBPOCatalogosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.btnAgregarCategoria);
            this.dataLayoutControl1.Controls.Add(this.cbCategoriaCliente);
            this.dataLayoutControl1.Controls.Add(this.chkSindicato);
            this.dataLayoutControl1.Controls.Add(this.btnGrupo);
            this.dataLayoutControl1.Controls.Add(this.btnCrearProducto);
            this.dataLayoutControl1.Controls.Add(this.txtObservaciones);
            this.dataLayoutControl1.Controls.Add(this.btnEditar);
            this.dataLayoutControl1.Controls.Add(this.btnGuardar);
            this.dataLayoutControl1.Controls.Add(this.btnCancelar);
            this.dataLayoutControl1.Controls.Add(this.btnNuevo);
            this.dataLayoutControl1.Controls.Add(this.cboIdClienteProveedor);
            this.dataLayoutControl1.Controls.Add(this.btnABC_ActividadComercial);
            this.dataLayoutControl1.Controls.Add(this.btnAsignarDomicilioFiscal2DomicilioOperacion);
            this.dataLayoutControl1.Controls.Add(this.txtRazonSocial);
            this.dataLayoutControl1.Controls.Add(this.txtNombreComercial);
            this.dataLayoutControl1.Controls.Add(this.txtRFC);
            this.dataLayoutControl1.Controls.Add(this.txtCalle);
            this.dataLayoutControl1.Controls.Add(this.txtNoExterior);
            this.dataLayoutControl1.Controls.Add(this.txtNoInterior);
            this.dataLayoutControl1.Controls.Add(this.txtColonia);
            this.dataLayoutControl1.Controls.Add(this.txtCodigoPostal);
            this.dataLayoutControl1.Controls.Add(this.cboIdPais);
            this.dataLayoutControl1.Controls.Add(this.cboIdEstado);
            this.dataLayoutControl1.Controls.Add(this.txtNombreDelegacionMunicipio);
            this.dataLayoutControl1.Controls.Add(this.txtNombrePoblacionCiudad);
            this.dataLayoutControl1.Controls.Add(this.txtCalleOperacion);
            this.dataLayoutControl1.Controls.Add(this.txtNoExteriorOperacion);
            this.dataLayoutControl1.Controls.Add(this.txtNoInteriorOperacion);
            this.dataLayoutControl1.Controls.Add(this.txtColoniaOperacion);
            this.dataLayoutControl1.Controls.Add(this.txtCodigoPostalOperacion);
            this.dataLayoutControl1.Controls.Add(this.cboIdPaisOperacion);
            this.dataLayoutControl1.Controls.Add(this.cboIdEstadoOperacion);
            this.dataLayoutControl1.Controls.Add(this.txtNombreDelegacionMunicipioOperacion);
            this.dataLayoutControl1.Controls.Add(this.txtNombrePoblacionCiudadOperacion);
            this.dataLayoutControl1.Controls.Add(this.txtTelefono1);
            this.dataLayoutControl1.Controls.Add(this.txtTelefono2);
            this.dataLayoutControl1.Controls.Add(this.txtContacto);
            this.dataLayoutControl1.Controls.Add(this.txtCorreoElectronico);
            this.dataLayoutControl1.Controls.Add(this.txtPaginaWeb);
            this.dataLayoutControl1.Controls.Add(this.cboIdEstatus);
            this.dataLayoutControl1.Controls.Add(this.chkConfidencial);
            this.dataLayoutControl1.Controls.Add(this.chkTieneSucursales);
            this.dataLayoutControl1.Controls.Add(this.spPctComisionBPO);
            this.dataLayoutControl1.Controls.Add(this.calFechaBaja);
            this.dataLayoutControl1.Controls.Add(this.UsuarioCreacionTextEdit);
            this.dataLayoutControl1.Controls.Add(this.UsuarioModificacionTextEdit);
            this.dataLayoutControl1.Controls.Add(this.txtIdCliente);
            this.dataLayoutControl1.Controls.Add(this.cboIdActividadComercial);
            this.dataLayoutControl1.Controls.Add(this.chkSeguro);
            this.dataLayoutControl1.Controls.Add(this.txtRepresentanteLegal);
            this.dataLayoutControl1.Controls.Add(this.spPctAsimilados);
            this.dataLayoutControl1.Controls.Add(this.spISN);
            this.dataLayoutControl1.Controls.Add(this.chkDecreto);
            this.dataLayoutControl1.Controls.Add(this.chkbPeriodicidad);
            this.dataLayoutControl1.Controls.Add(this.chkbFronting);
            this.dataLayoutControl1.Controls.Add(this.chkbComision);
            this.dataLayoutControl1.Controls.Add(this.cbGrupo);
            this.dataLayoutControl1.Controls.Add(this.cbIdOperador);
            this.dataLayoutControl1.Controls.Add(this.cbProductos);
            this.dataLayoutControl1.Controls.Add(this.cbIdClaseRiesgo);
            this.dataLayoutControl1.Controls.Add(this.cboIdTipoClienteProveedor);
            this.dataLayoutControl1.Controls.Add(this.btnExportar);
            this.dataLayoutControl1.Controls.Add(this.cboIdRegimenFiscalSAT);
            this.dataLayoutControl1.Controls.Add(this.cbPlazaCliente);
            this.dataLayoutControl1.Controls.Add(this.spSaldoFavor);
            this.dataLayoutControl1.Controls.Add(this.spFinanciamiento);
            this.dataLayoutControl1.Controls.Add(this.spComision);
            this.dataLayoutControl1.Controls.Add(this.txtObservacionesPromo);
            this.dataLayoutControl1.Controls.Add(this.btnAgregarPromo);
            this.dataLayoutControl1.Controls.Add(this.btnEliminarProm);
            this.dataLayoutControl1.Controls.Add(this.btnModificPromotor);
            this.dataLayoutControl1.Controls.Add(this.btnGuardarPromo);
            this.dataLayoutControl1.Controls.Add(this.cbRelIdPromotor);
            this.dataLayoutControl1.Controls.Add(this.cbPromotor);
            this.dataLayoutControl1.Controls.Add(this.btnCancelarPro);
            this.dataLayoutControl1.Controls.Add(this.RegimenCapitaltextEdit);
            this.dataLayoutControl1.Controls.Add(this.btnPromotores);
            this.dataLayoutControl1.Controls.Add(this.spIVA);
            this.dataLayoutControl1.Controls.Add(this.spUtilidadReal);
            this.dataLayoutControl1.Controls.Add(this.spPctBPOTarjeta);
            this.dataLayoutControl1.Controls.Add(this.spPctProTarjeta);
            this.dataLayoutControl1.Controls.Add(this.spPctBPOCucas);
            this.dataLayoutControl1.Controls.Add(this.spPctProCucas);
            this.dataLayoutControl1.Controls.Add(this.spPctBPOEfectivo);
            this.dataLayoutControl1.Controls.Add(this.spPctProEfectivo);
            this.dataLayoutControl1.Controls.Add(this.spPctBPOSeguros);
            this.dataLayoutControl1.Controls.Add(this.spPctProSeguros);
            this.dataLayoutControl1.Controls.Add(this.spPctBPOProveedor);
            this.dataLayoutControl1.Controls.Add(this.spPctProProveedor);
            this.dataLayoutControl1.Controls.Add(this.spPctBPOGasto);
            this.dataLayoutControl1.Controls.Add(this.spPctProGasto);
            this.dataLayoutControl1.Controls.Add(this.spPctBPOOtro);
            this.dataLayoutControl1.Controls.Add(this.spPctProOtro);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForUsuarioCreacion,
            this.ItemForUsuarioModificacion});
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 31);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(148, 191, 461, 312);
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(1069, 606);
            this.dataLayoutControl1.TabIndex = 4;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.ImageOptions.Image = global::winAppSAIC.Properties.Resources.categorias_16;
            this.btnAgregarCategoria.Location = new System.Drawing.Point(588, 232);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(332, 22);
            this.btnAgregarCategoria.StyleController = this.dataLayoutControl1;
            this.btnAgregarCategoria.TabIndex = 75;
            this.btnAgregarCategoria.Text = "Categoria";
            this.btnAgregarCategoria.ToolTip = "Categoria";
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // cbCategoriaCliente
            // 
            this.cbCategoriaCliente.EditValue = "";
            this.cbCategoriaCliente.Location = new System.Drawing.Point(149, 232);
            this.cbCategoriaCliente.MenuManager = this.barManager1;
            this.cbCategoriaCliente.Name = "cbCategoriaCliente";
            this.cbCategoriaCliente.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbCategoriaCliente.Properties.DataSource = this.stpSelCategoriaClienteBindingSource;
            this.cbCategoriaCliente.Properties.DisplayMember = "DescCategoria";
            this.cbCategoriaCliente.Properties.ValueMember = "idCategoriaCliente";
            this.cbCategoriaCliente.Properties.View = this.gridView9;
            this.cbCategoriaCliente.Size = new System.Drawing.Size(435, 20);
            this.cbCategoriaCliente.StyleController = this.dataLayoutControl1;
            this.cbCategoriaCliente.TabIndex = 74;
            this.cbCategoriaCliente.Tag = "Categoria";
            // 
            // stpSelCategoriaClienteBindingSource
            // 
            this.stpSelCategoriaClienteBindingSource.DataMember = "stpSelCategoriaCliente";
            this.stpSelCategoriaClienteBindingSource.DataSource = this.dbSAICBPOCatalogosDataSet;
            // 
            // gridView9
            // 
            this.gridView9.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidCategoriaCliente,
            this.colDescCategoria,
            this.colDescEstatus});
            this.gridView9.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView9.Name = "gridView9";
            this.gridView9.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView9.OptionsView.ShowAutoFilterRow = true;
            this.gridView9.OptionsView.ShowGroupPanel = false;
            // 
            // colidCategoriaCliente
            // 
            this.colidCategoriaCliente.FieldName = "idCategoriaCliente";
            this.colidCategoriaCliente.Name = "colidCategoriaCliente";
            this.colidCategoriaCliente.Visible = true;
            this.colidCategoriaCliente.VisibleIndex = 0;
            // 
            // colDescCategoria
            // 
            this.colDescCategoria.FieldName = "DescCategoria";
            this.colDescCategoria.Name = "colDescCategoria";
            this.colDescCategoria.Visible = true;
            this.colDescCategoria.VisibleIndex = 1;
            // 
            // colDescEstatus
            // 
            this.colDescEstatus.FieldName = "DescEstatus";
            this.colDescEstatus.Name = "colDescEstatus";
            // 
            // chkSindicato
            // 
            this.chkSindicato.Location = new System.Drawing.Point(743, 378);
            this.chkSindicato.MenuManager = this.barManager1;
            this.chkSindicato.Name = "chkSindicato";
            this.chkSindicato.Properties.Caption = "Sindicato";
            this.chkSindicato.Size = new System.Drawing.Size(165, 19);
            this.chkSindicato.StyleController = this.dataLayoutControl1;
            this.chkSindicato.TabIndex = 43;
            this.chkSindicato.Tag = "Tiene Sindicato";
            // 
            // btnGrupo
            // 
            this.btnGrupo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGrupo.ImageOptions.Image")));
            this.btnGrupo.Location = new System.Drawing.Point(588, 206);
            this.btnGrupo.Name = "btnGrupo";
            this.btnGrupo.Size = new System.Drawing.Size(332, 22);
            this.btnGrupo.StyleController = this.dataLayoutControl1;
            this.btnGrupo.TabIndex = 9;
            this.btnGrupo.Text = "Alta de Grupo";
            this.btnGrupo.ToolTip = "Alta de Grupo";
            this.btnGrupo.Click += new System.EventHandler(this.btnGrupo_Click);
            // 
            // btnCrearProducto
            // 
            this.btnCrearProducto.ImageOptions.Image = global::winAppSAIC.Properties.Resources.Product2_16x16;
            this.btnCrearProducto.Location = new System.Drawing.Point(159, 412);
            this.btnCrearProducto.Name = "btnCrearProducto";
            this.btnCrearProducto.Size = new System.Drawing.Size(24, 22);
            this.btnCrearProducto.StyleController = this.dataLayoutControl1;
            this.btnCrearProducto.TabIndex = 45;
            this.btnCrearProducto.Tag = "Alta de Productos";
            this.btnCrearProducto.ToolTip = "Alta de Producto";
            this.btnCrearProducto.Click += new System.EventHandler(this.btnCrearProducto_Click);
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(161, 482);
            this.txtObservaciones.MenuManager = this.barManager1;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservaciones.Size = new System.Drawing.Size(747, 62);
            this.txtObservaciones.StyleController = this.dataLayoutControl1;
            this.txtObservaciones.TabIndex = 58;
            this.txtObservaciones.Tag = "Observaciones";
            this.txtObservaciones.ToolTip = "Observaciones";
            // 
            // btnEditar
            // 
            this.btnEditar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.ImageOptions.Image")));
            this.btnEditar.Location = new System.Drawing.Point(936, 79);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(121, 22);
            this.btnEditar.StyleController = this.dataLayoutControl1;
            this.btnEditar.TabIndex = 46;
            this.btnEditar.Text = "Editar Cliente";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(936, 131);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(121, 22);
            this.btnGuardar.StyleController = this.dataLayoutControl1;
            this.btnGuardar.TabIndex = 48;
            this.btnGuardar.Text = "Guardar Cliente";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.ImageOptions.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(936, 105);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 22);
            this.btnCancelar.StyleController = this.dataLayoutControl1;
            this.btnCancelar.TabIndex = 47;
            this.btnCancelar.Text = "Cancelar captura";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.ImageOptions.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(936, 53);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(121, 22);
            this.btnNuevo.StyleController = this.dataLayoutControl1;
            this.btnNuevo.TabIndex = 45;
            this.btnNuevo.Text = "Nuevo Cliente";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // cboIdClienteProveedor
            // 
            this.dxValidationProvider1.SetIconAlignment(this.cboIdClienteProveedor, System.Windows.Forms.ErrorIconAlignment.TopLeft);
            this.cboIdClienteProveedor.Location = new System.Drawing.Point(137, 12);
            this.cboIdClienteProveedor.MenuManager = this.barManager1;
            this.cboIdClienteProveedor.Name = "cboIdClienteProveedor";
            this.cboIdClienteProveedor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboIdClienteProveedor.Properties.DataSource = this.stpFactSelControlClienteBindingSource;
            this.cboIdClienteProveedor.Properties.DisplayMember = "RazonSocial";
            this.cboIdClienteProveedor.Properties.NullText = "";
            this.cboIdClienteProveedor.Properties.ValueMember = "IdCliente";
            this.cboIdClienteProveedor.Properties.View = this.gridLookUpEdit1View;
            this.cboIdClienteProveedor.Size = new System.Drawing.Size(795, 20);
            this.cboIdClienteProveedor.StyleController = this.dataLayoutControl1;
            this.cboIdClienteProveedor.TabIndex = 1;
            this.cboIdClienteProveedor.EditValueChanged += new System.EventHandler(this.cboIdClienteProveedor_EditValueChanged);
            // 
            // stpFactSelControlClienteBindingSource
            // 
            this.stpFactSelControlClienteBindingSource.DataMember = "stpFactSelControlCliente";
            this.stpFactSelControlClienteBindingSource.DataSource = this.dbSAICBPOFactura;
            // 
            // dbSAICBPOFactura
            // 
            this.dbSAICBPOFactura.DataSetName = "dbSAICBPOFactura";
            this.dbSAICBPOFactura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCliente,
            this.colRazonSocial,
            this.colNombreComercial,
            this.colRFC,
            this.colCURP,
            this.colIdActividadComercial,
            this.colIdMatrizCliente,
            this.colCalle,
            this.colNoExterior,
            this.colNoInterior,
            this.colColonia,
            this.colCodigoPostal,
            this.colIdPais,
            this.colIdEstado,
            this.colNombreDelegacionMunicipio,
            this.colNombrePoblacionCiudad,
            this.colCalleOperacion,
            this.colNoExteriorOperacion,
            this.colNoInteriorOperacion,
            this.colColoniaOperacion,
            this.colCodigoPostalOperacion,
            this.colIdPaisOperacion,
            this.colIdEstadoOperacion,
            this.colNombreDelegacionMunicipioOperacion,
            this.colNombrePoblacionCiudadOperacion,
            this.colRepresentanteLegal,
            this.colContacto,
            this.colTelefono1,
            this.colTelefono2,
            this.colCorreoElectronico,
            this.colPaginaWeb,
            this.colIdOperador,
            this.colIdTipoClienteProveedor,
            this.colIdClaseRiesgo,
            this.colISN,
            this.colTieneSucursales,
            this.colConfidencial,
            this.colSeguro,
            this.colDecreto,
            this.colSindicato,
            this.colPctComisionBPO,
            this.colPctAsimilados,
            this.colFechaBaja,
            this.colObservaciones,
            this.colIdEstatus,
            this.colFechaModificacion,
            this.colUsuarioCreacion,
            this.colUsuarioModificacion,
            this.gridColumnRegimenFiscal,
            this.gridColumnRegimenCapital,
            this.gridColumn4idCategoriaCliente});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ColumnAutoWidth = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdCliente
            // 
            this.colIdCliente.Caption = "No. Cliente";
            this.colIdCliente.FieldName = "IdCliente";
            this.colIdCliente.Name = "colIdCliente";
            this.colIdCliente.Visible = true;
            this.colIdCliente.VisibleIndex = 0;
            this.colIdCliente.Width = 90;
            // 
            // colRazonSocial
            // 
            this.colRazonSocial.Caption = "Razón Social";
            this.colRazonSocial.FieldName = "RazonSocial";
            this.colRazonSocial.Name = "colRazonSocial";
            this.colRazonSocial.Visible = true;
            this.colRazonSocial.VisibleIndex = 1;
            this.colRazonSocial.Width = 250;
            // 
            // colNombreComercial
            // 
            this.colNombreComercial.FieldName = "NombreComercial";
            this.colNombreComercial.Name = "colNombreComercial";
            this.colNombreComercial.Visible = true;
            this.colNombreComercial.VisibleIndex = 2;
            this.colNombreComercial.Width = 250;
            // 
            // colRFC
            // 
            this.colRFC.FieldName = "RFC";
            this.colRFC.Name = "colRFC";
            this.colRFC.Visible = true;
            this.colRFC.VisibleIndex = 3;
            this.colRFC.Width = 100;
            // 
            // colCURP
            // 
            this.colCURP.FieldName = "CURP";
            this.colCURP.Name = "colCURP";
            // 
            // colIdActividadComercial
            // 
            this.colIdActividadComercial.FieldName = "IdActividadComercial";
            this.colIdActividadComercial.Name = "colIdActividadComercial";
            // 
            // colIdMatrizCliente
            // 
            this.colIdMatrizCliente.FieldName = "IdMatrizCliente";
            this.colIdMatrizCliente.Name = "colIdMatrizCliente";
            // 
            // colCalle
            // 
            this.colCalle.FieldName = "Calle";
            this.colCalle.Name = "colCalle";
            // 
            // colNoExterior
            // 
            this.colNoExterior.FieldName = "NoExterior";
            this.colNoExterior.Name = "colNoExterior";
            // 
            // colNoInterior
            // 
            this.colNoInterior.FieldName = "NoInterior";
            this.colNoInterior.Name = "colNoInterior";
            // 
            // colColonia
            // 
            this.colColonia.FieldName = "Colonia";
            this.colColonia.Name = "colColonia";
            // 
            // colCodigoPostal
            // 
            this.colCodigoPostal.FieldName = "CodigoPostal";
            this.colCodigoPostal.Name = "colCodigoPostal";
            // 
            // colIdPais
            // 
            this.colIdPais.FieldName = "IdPais";
            this.colIdPais.Name = "colIdPais";
            // 
            // colIdEstado
            // 
            this.colIdEstado.FieldName = "IdEstado";
            this.colIdEstado.Name = "colIdEstado";
            // 
            // colNombreDelegacionMunicipio
            // 
            this.colNombreDelegacionMunicipio.FieldName = "NombreDelegacionMunicipio";
            this.colNombreDelegacionMunicipio.Name = "colNombreDelegacionMunicipio";
            // 
            // colNombrePoblacionCiudad
            // 
            this.colNombrePoblacionCiudad.FieldName = "NombrePoblacionCiudad";
            this.colNombrePoblacionCiudad.Name = "colNombrePoblacionCiudad";
            // 
            // colCalleOperacion
            // 
            this.colCalleOperacion.FieldName = "CalleOperacion";
            this.colCalleOperacion.Name = "colCalleOperacion";
            // 
            // colNoExteriorOperacion
            // 
            this.colNoExteriorOperacion.FieldName = "NoExteriorOperacion";
            this.colNoExteriorOperacion.Name = "colNoExteriorOperacion";
            // 
            // colNoInteriorOperacion
            // 
            this.colNoInteriorOperacion.FieldName = "NoInteriorOperacion";
            this.colNoInteriorOperacion.Name = "colNoInteriorOperacion";
            // 
            // colColoniaOperacion
            // 
            this.colColoniaOperacion.FieldName = "ColoniaOperacion";
            this.colColoniaOperacion.Name = "colColoniaOperacion";
            // 
            // colCodigoPostalOperacion
            // 
            this.colCodigoPostalOperacion.FieldName = "CodigoPostalOperacion";
            this.colCodigoPostalOperacion.Name = "colCodigoPostalOperacion";
            // 
            // colIdPaisOperacion
            // 
            this.colIdPaisOperacion.FieldName = "IdPaisOperacion";
            this.colIdPaisOperacion.Name = "colIdPaisOperacion";
            // 
            // colIdEstadoOperacion
            // 
            this.colIdEstadoOperacion.FieldName = "IdEstadoOperacion";
            this.colIdEstadoOperacion.Name = "colIdEstadoOperacion";
            // 
            // colNombreDelegacionMunicipioOperacion
            // 
            this.colNombreDelegacionMunicipioOperacion.FieldName = "NombreDelegacionMunicipioOperacion";
            this.colNombreDelegacionMunicipioOperacion.Name = "colNombreDelegacionMunicipioOperacion";
            // 
            // colNombrePoblacionCiudadOperacion
            // 
            this.colNombrePoblacionCiudadOperacion.FieldName = "NombrePoblacionCiudadOperacion";
            this.colNombrePoblacionCiudadOperacion.Name = "colNombrePoblacionCiudadOperacion";
            // 
            // colRepresentanteLegal
            // 
            this.colRepresentanteLegal.Caption = "Representante Legal";
            this.colRepresentanteLegal.FieldName = "RepresentanteLegal";
            this.colRepresentanteLegal.Name = "colRepresentanteLegal";
            // 
            // colContacto
            // 
            this.colContacto.FieldName = "Contacto";
            this.colContacto.Name = "colContacto";
            // 
            // colTelefono1
            // 
            this.colTelefono1.FieldName = "Telefono1";
            this.colTelefono1.Name = "colTelefono1";
            // 
            // colTelefono2
            // 
            this.colTelefono2.FieldName = "Telefono2";
            this.colTelefono2.Name = "colTelefono2";
            // 
            // colCorreoElectronico
            // 
            this.colCorreoElectronico.FieldName = "CorreoElectronico";
            this.colCorreoElectronico.Name = "colCorreoElectronico";
            // 
            // colPaginaWeb
            // 
            this.colPaginaWeb.FieldName = "PaginaWeb";
            this.colPaginaWeb.Name = "colPaginaWeb";
            // 
            // colIdOperador
            // 
            this.colIdOperador.Caption = "Operador";
            this.colIdOperador.FieldName = "IdOperador";
            this.colIdOperador.Name = "colIdOperador";
            // 
            // colIdTipoClienteProveedor
            // 
            this.colIdTipoClienteProveedor.FieldName = "IdTipoClienteProveedor";
            this.colIdTipoClienteProveedor.Name = "colIdTipoClienteProveedor";
            // 
            // colIdClaseRiesgo
            // 
            this.colIdClaseRiesgo.Caption = "Id Clase Riesgo";
            this.colIdClaseRiesgo.FieldName = "IdClaseRiesgo";
            this.colIdClaseRiesgo.Name = "colIdClaseRiesgo";
            // 
            // colISN
            // 
            this.colISN.Caption = "ISN";
            this.colISN.FieldName = "ISN";
            this.colISN.Name = "colISN";
            // 
            // colTieneSucursales
            // 
            this.colTieneSucursales.FieldName = "TieneSucursales";
            this.colTieneSucursales.Name = "colTieneSucursales";
            // 
            // colConfidencial
            // 
            this.colConfidencial.FieldName = "Confidencial";
            this.colConfidencial.Name = "colConfidencial";
            // 
            // colSeguro
            // 
            this.colSeguro.Caption = "Seguro";
            this.colSeguro.FieldName = "Seguro";
            this.colSeguro.Name = "colSeguro";
            // 
            // colDecreto
            // 
            this.colDecreto.Caption = "Decreto";
            this.colDecreto.FieldName = "Decreto";
            this.colDecreto.Name = "colDecreto";
            // 
            // colSindicato
            // 
            this.colSindicato.Caption = "Sindicato";
            this.colSindicato.FieldName = "Sindicato";
            this.colSindicato.Name = "colSindicato";
            // 
            // colPctComisionBPO
            // 
            this.colPctComisionBPO.FieldName = "PctComisionBPO";
            this.colPctComisionBPO.Name = "colPctComisionBPO";
            // 
            // colPctAsimilados
            // 
            this.colPctAsimilados.Caption = "PctAsimilados";
            this.colPctAsimilados.FieldName = "PctAsimilados";
            this.colPctAsimilados.Name = "colPctAsimilados";
            // 
            // colFechaBaja
            // 
            this.colFechaBaja.FieldName = "FechaBaja";
            this.colFechaBaja.Name = "colFechaBaja";
            // 
            // colObservaciones
            // 
            this.colObservaciones.Caption = "Observaciones";
            this.colObservaciones.FieldName = "Observaciones";
            this.colObservaciones.Name = "colObservaciones";
            // 
            // colIdEstatus
            // 
            this.colIdEstatus.FieldName = "IdEstatus";
            this.colIdEstatus.Name = "colIdEstatus";
            // 
            // colFechaModificacion
            // 
            this.colFechaModificacion.FieldName = "FechaModificacion";
            this.colFechaModificacion.Name = "colFechaModificacion";
            // 
            // colUsuarioCreacion
            // 
            this.colUsuarioCreacion.FieldName = "UsuarioCreacion";
            this.colUsuarioCreacion.Name = "colUsuarioCreacion";
            // 
            // colUsuarioModificacion
            // 
            this.colUsuarioModificacion.FieldName = "UsuarioModificacion";
            this.colUsuarioModificacion.Name = "colUsuarioModificacion";
            // 
            // gridColumnRegimenFiscal
            // 
            this.gridColumnRegimenFiscal.Caption = "RegimenFiscal";
            this.gridColumnRegimenFiscal.FieldName = "IdRegimenFiscal";
            this.gridColumnRegimenFiscal.Name = "gridColumnRegimenFiscal";
            // 
            // gridColumnRegimenCapital
            // 
            this.gridColumnRegimenCapital.Caption = "Regimen Capital";
            this.gridColumnRegimenCapital.FieldName = "RegimenCapital";
            this.gridColumnRegimenCapital.Name = "gridColumnRegimenCapital";
            // 
            // gridColumn4idCategoriaCliente
            // 
            this.gridColumn4idCategoriaCliente.Caption = "idCategoriaCliente";
            this.gridColumn4idCategoriaCliente.FieldName = "idCategoriaCliente";
            this.gridColumn4idCategoriaCliente.Name = "gridColumn4idCategoriaCliente";
            // 
            // btnABC_ActividadComercial
            // 
            this.btnABC_ActividadComercial.ImageOptions.Image = global::winAppSAIC.Properties.Resources.Product16x16;
            this.btnABC_ActividadComercial.Location = new System.Drawing.Point(588, 180);
            this.btnABC_ActividadComercial.Name = "btnABC_ActividadComercial";
            this.btnABC_ActividadComercial.Size = new System.Drawing.Size(332, 22);
            this.btnABC_ActividadComercial.StyleController = this.dataLayoutControl1;
            this.btnABC_ActividadComercial.TabIndex = 7;
            this.btnABC_ActividadComercial.Text = "Act Comercial";
            this.btnABC_ActividadComercial.ToolTip = "Alta de Actividad Comercial";
            this.btnABC_ActividadComercial.Click += new System.EventHandler(this.btnABC_ActividadComercial_Click);
            // 
            // btnAsignarDomicilioFiscal2DomicilioOperacion
            // 
            this.btnAsignarDomicilioFiscal2DomicilioOperacion.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAsignarDomicilioFiscal2DomicilioOperacion.ImageOptions.Image")));
            this.btnAsignarDomicilioFiscal2DomicilioOperacion.Location = new System.Drawing.Point(697, 522);
            this.btnAsignarDomicilioFiscal2DomicilioOperacion.Name = "btnAsignarDomicilioFiscal2DomicilioOperacion";
            this.btnAsignarDomicilioFiscal2DomicilioOperacion.Size = new System.Drawing.Size(211, 22);
            this.btnAsignarDomicilioFiscal2DomicilioOperacion.StyleController = this.dataLayoutControl1;
            this.btnAsignarDomicilioFiscal2DomicilioOperacion.TabIndex = 19;
            this.btnAsignarDomicilioFiscal2DomicilioOperacion.Text = "Copiar datos a Domicilio Operación";
            this.btnAsignarDomicilioFiscal2DomicilioOperacion.Click += new System.EventHandler(this.btnAsignarDomicilioFiscal2DomicilioOperacion_Click);
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(149, 108);
            this.txtRazonSocial.MenuManager = this.barManager1;
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRazonSocial.Properties.MaxLength = 255;
            this.txtRazonSocial.Size = new System.Drawing.Size(294, 20);
            this.txtRazonSocial.StyleController = this.dataLayoutControl1;
            this.txtRazonSocial.TabIndex = 3;
            this.txtRazonSocial.Tag = "Razón Social";
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            this.dxValidationProvider1.SetValidationRule(this.txtRazonSocial, conditionValidationRule1);
            // 
            // txtNombreComercial
            // 
            this.txtNombreComercial.Location = new System.Drawing.Point(149, 132);
            this.txtNombreComercial.MenuManager = this.barManager1;
            this.txtNombreComercial.Name = "txtNombreComercial";
            this.txtNombreComercial.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreComercial.Properties.MaxLength = 255;
            this.txtNombreComercial.Size = new System.Drawing.Size(771, 20);
            this.txtNombreComercial.StyleController = this.dataLayoutControl1;
            this.txtNombreComercial.TabIndex = 4;
            this.txtNombreComercial.Tag = "Nombre Comercial";
            // 
            // txtRFC
            // 
            this.txtRFC.Location = new System.Drawing.Point(149, 156);
            this.txtRFC.MenuManager = this.barManager1;
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRFC.Properties.MaxLength = 13;
            this.txtRFC.Size = new System.Drawing.Size(435, 20);
            this.txtRFC.StyleController = this.dataLayoutControl1;
            this.txtRFC.TabIndex = 5;
            this.txtRFC.Tag = "RFC";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(161, 378);
            this.txtCalle.MenuManager = this.barManager1;
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCalle.Properties.MaxLength = 255;
            this.txtCalle.Size = new System.Drawing.Size(747, 20);
            this.txtCalle.StyleController = this.dataLayoutControl1;
            this.txtCalle.TabIndex = 10;
            // 
            // txtNoExterior
            // 
            this.txtNoExterior.Location = new System.Drawing.Point(161, 402);
            this.txtNoExterior.MenuManager = this.barManager1;
            this.txtNoExterior.Name = "txtNoExterior";
            this.txtNoExterior.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNoExterior.Properties.MaxLength = 30;
            this.txtNoExterior.Size = new System.Drawing.Size(50, 20);
            this.txtNoExterior.StyleController = this.dataLayoutControl1;
            this.txtNoExterior.TabIndex = 11;
            // 
            // txtNoInterior
            // 
            this.txtNoInterior.Location = new System.Drawing.Point(340, 402);
            this.txtNoInterior.MenuManager = this.barManager1;
            this.txtNoInterior.Name = "txtNoInterior";
            this.txtNoInterior.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNoInterior.Properties.MaxLength = 30;
            this.txtNoInterior.Size = new System.Drawing.Size(50, 20);
            this.txtNoInterior.StyleController = this.dataLayoutControl1;
            this.txtNoInterior.TabIndex = 12;
            // 
            // txtColonia
            // 
            this.txtColonia.Location = new System.Drawing.Point(161, 426);
            this.txtColonia.MenuManager = this.barManager1;
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtColonia.Properties.MaxLength = 255;
            this.txtColonia.Size = new System.Drawing.Size(747, 20);
            this.txtColonia.StyleController = this.dataLayoutControl1;
            this.txtColonia.TabIndex = 13;
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.Location = new System.Drawing.Point(161, 450);
            this.txtCodigoPostal.MenuManager = this.barManager1;
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoPostal.Properties.Mask.EditMask = "\\d\\d\\d\\d\\d";
            this.txtCodigoPostal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtCodigoPostal.Properties.Mask.ShowPlaceHolders = false;
            this.txtCodigoPostal.Properties.MaxLength = 5;
            this.txtCodigoPostal.Size = new System.Drawing.Size(50, 20);
            this.txtCodigoPostal.StyleController = this.dataLayoutControl1;
            this.txtCodigoPostal.TabIndex = 14;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Código Postal requerido";
            this.dxValidationProvider1.SetValidationRule(this.txtCodigoPostal, conditionValidationRule2);
            // 
            // cboIdPais
            // 
            this.cboIdPais.Location = new System.Drawing.Point(519, 450);
            this.cboIdPais.MenuManager = this.barManager1;
            this.cboIdPais.Name = "cboIdPais";
            this.cboIdPais.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboIdPais.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdPais", "Id Pais", 55, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NombrePais", "País", 69, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cboIdPais.Properties.DataSource = this.stpSelPaisBindingSource;
            this.cboIdPais.Properties.DisplayMember = "NombrePais";
            this.cboIdPais.Properties.NullText = "";
            this.cboIdPais.Properties.ValueMember = "IdPais";
            this.cboIdPais.Size = new System.Drawing.Size(389, 20);
            this.cboIdPais.StyleController = this.dataLayoutControl1;
            this.cboIdPais.TabIndex = 16;
            // 
            // stpSelPaisBindingSource
            // 
            this.stpSelPaisBindingSource.DataMember = "stpSelPais";
            this.stpSelPaisBindingSource.DataSource = this.dbSAIC_Catalogos;
            // 
            // dbSAIC_Catalogos
            // 
            this.dbSAIC_Catalogos.DataSetName = "dbSAIC_Catalogos";
            this.dbSAIC_Catalogos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cboIdEstado
            // 
            this.cboIdEstado.Location = new System.Drawing.Point(340, 450);
            this.cboIdEstado.MenuManager = this.barManager1;
            this.cboIdEstado.Name = "cboIdEstado";
            this.cboIdEstado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboIdEstado.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdEstado", "Id Estado", 69, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NombreEstado", "Estado", 83, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cboIdEstado.Properties.DataSource = this.stpSelEstadoBindingSource;
            this.cboIdEstado.Properties.DisplayMember = "NombreEstado";
            this.cboIdEstado.Properties.NullText = "";
            this.cboIdEstado.Properties.ValueMember = "IdEstado";
            this.cboIdEstado.Size = new System.Drawing.Size(50, 20);
            this.cboIdEstado.StyleController = this.dataLayoutControl1;
            this.cboIdEstado.TabIndex = 15;
            // 
            // stpSelEstadoBindingSource
            // 
            this.stpSelEstadoBindingSource.DataMember = "stpSelEstado";
            this.stpSelEstadoBindingSource.DataSource = this.dbSAICBPOCatalogosDataSet;
            // 
            // txtNombreDelegacionMunicipio
            // 
            this.txtNombreDelegacionMunicipio.Location = new System.Drawing.Point(161, 474);
            this.txtNombreDelegacionMunicipio.MenuManager = this.barManager1;
            this.txtNombreDelegacionMunicipio.Name = "txtNombreDelegacionMunicipio";
            this.txtNombreDelegacionMunicipio.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreDelegacionMunicipio.Properties.MaxLength = 255;
            this.txtNombreDelegacionMunicipio.Size = new System.Drawing.Size(747, 20);
            this.txtNombreDelegacionMunicipio.StyleController = this.dataLayoutControl1;
            this.txtNombreDelegacionMunicipio.TabIndex = 17;
            // 
            // txtNombrePoblacionCiudad
            // 
            this.txtNombrePoblacionCiudad.Location = new System.Drawing.Point(161, 498);
            this.txtNombrePoblacionCiudad.MenuManager = this.barManager1;
            this.txtNombrePoblacionCiudad.Name = "txtNombrePoblacionCiudad";
            this.txtNombrePoblacionCiudad.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombrePoblacionCiudad.Properties.MaxLength = 255;
            this.txtNombrePoblacionCiudad.Size = new System.Drawing.Size(747, 20);
            this.txtNombrePoblacionCiudad.StyleController = this.dataLayoutControl1;
            this.txtNombrePoblacionCiudad.TabIndex = 18;
            // 
            // txtCalleOperacion
            // 
            this.txtCalleOperacion.Location = new System.Drawing.Point(161, 378);
            this.txtCalleOperacion.MenuManager = this.barManager1;
            this.txtCalleOperacion.Name = "txtCalleOperacion";
            this.txtCalleOperacion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCalleOperacion.Properties.MaxLength = 255;
            this.txtCalleOperacion.Size = new System.Drawing.Size(747, 20);
            this.txtCalleOperacion.StyleController = this.dataLayoutControl1;
            this.txtCalleOperacion.TabIndex = 20;
            // 
            // txtNoExteriorOperacion
            // 
            this.txtNoExteriorOperacion.Location = new System.Drawing.Point(161, 402);
            this.txtNoExteriorOperacion.MenuManager = this.barManager1;
            this.txtNoExteriorOperacion.Name = "txtNoExteriorOperacion";
            this.txtNoExteriorOperacion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNoExteriorOperacion.Properties.MaxLength = 30;
            this.txtNoExteriorOperacion.Size = new System.Drawing.Size(50, 20);
            this.txtNoExteriorOperacion.StyleController = this.dataLayoutControl1;
            this.txtNoExteriorOperacion.TabIndex = 21;
            // 
            // txtNoInteriorOperacion
            // 
            this.txtNoInteriorOperacion.Location = new System.Drawing.Point(340, 402);
            this.txtNoInteriorOperacion.MenuManager = this.barManager1;
            this.txtNoInteriorOperacion.Name = "txtNoInteriorOperacion";
            this.txtNoInteriorOperacion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNoInteriorOperacion.Properties.MaxLength = 30;
            this.txtNoInteriorOperacion.Size = new System.Drawing.Size(50, 20);
            this.txtNoInteriorOperacion.StyleController = this.dataLayoutControl1;
            this.txtNoInteriorOperacion.TabIndex = 22;
            // 
            // txtColoniaOperacion
            // 
            this.txtColoniaOperacion.Location = new System.Drawing.Point(161, 426);
            this.txtColoniaOperacion.MenuManager = this.barManager1;
            this.txtColoniaOperacion.Name = "txtColoniaOperacion";
            this.txtColoniaOperacion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtColoniaOperacion.Properties.MaxLength = 255;
            this.txtColoniaOperacion.Size = new System.Drawing.Size(747, 20);
            this.txtColoniaOperacion.StyleController = this.dataLayoutControl1;
            this.txtColoniaOperacion.TabIndex = 23;
            // 
            // txtCodigoPostalOperacion
            // 
            this.txtCodigoPostalOperacion.Location = new System.Drawing.Point(161, 450);
            this.txtCodigoPostalOperacion.MenuManager = this.barManager1;
            this.txtCodigoPostalOperacion.Name = "txtCodigoPostalOperacion";
            this.txtCodigoPostalOperacion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoPostalOperacion.Properties.Mask.EditMask = "\\d\\d\\d\\d\\d";
            this.txtCodigoPostalOperacion.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtCodigoPostalOperacion.Properties.Mask.ShowPlaceHolders = false;
            this.txtCodigoPostalOperacion.Properties.MaxLength = 5;
            this.txtCodigoPostalOperacion.Size = new System.Drawing.Size(38, 20);
            this.txtCodigoPostalOperacion.StyleController = this.dataLayoutControl1;
            this.txtCodigoPostalOperacion.TabIndex = 24;
            // 
            // cboIdPaisOperacion
            // 
            this.cboIdPaisOperacion.Location = new System.Drawing.Point(507, 450);
            this.cboIdPaisOperacion.MenuManager = this.barManager1;
            this.cboIdPaisOperacion.Name = "cboIdPaisOperacion";
            this.cboIdPaisOperacion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboIdPaisOperacion.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdPais", "Id Pais", 55, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NombrePais", "País", 69, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cboIdPaisOperacion.Properties.DataSource = this.stpSelPaisBindingSource1;
            this.cboIdPaisOperacion.Properties.DisplayMember = "NombrePais";
            this.cboIdPaisOperacion.Properties.NullText = "";
            this.cboIdPaisOperacion.Properties.ValueMember = "IdPais";
            this.cboIdPaisOperacion.Size = new System.Drawing.Size(401, 20);
            this.cboIdPaisOperacion.StyleController = this.dataLayoutControl1;
            this.cboIdPaisOperacion.TabIndex = 26;
            // 
            // stpSelPaisBindingSource1
            // 
            this.stpSelPaisBindingSource1.DataMember = "stpSelPais";
            this.stpSelPaisBindingSource1.DataSource = this.dbSAIC_Catalogos;
            // 
            // cboIdEstadoOperacion
            // 
            this.cboIdEstadoOperacion.Location = new System.Drawing.Point(328, 450);
            this.cboIdEstadoOperacion.MenuManager = this.barManager1;
            this.cboIdEstadoOperacion.Name = "cboIdEstadoOperacion";
            this.cboIdEstadoOperacion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboIdEstadoOperacion.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdEstado", "Id Estado", 69, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NombreEstado", "Estado", 83, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdPais", "Id Pais", 42, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cboIdEstadoOperacion.Properties.DataSource = this.stpSelEstadoBindingSource1;
            this.cboIdEstadoOperacion.Properties.DisplayMember = "NombreEstado";
            this.cboIdEstadoOperacion.Properties.NullText = "";
            this.cboIdEstadoOperacion.Properties.ValueMember = "IdEstado";
            this.cboIdEstadoOperacion.Size = new System.Drawing.Size(50, 20);
            this.cboIdEstadoOperacion.StyleController = this.dataLayoutControl1;
            this.cboIdEstadoOperacion.TabIndex = 25;
            // 
            // stpSelEstadoBindingSource1
            // 
            this.stpSelEstadoBindingSource1.DataMember = "stpSelEstado";
            this.stpSelEstadoBindingSource1.DataSource = this.dbSAICBPOCatalogosDataSet;
            // 
            // txtNombreDelegacionMunicipioOperacion
            // 
            this.txtNombreDelegacionMunicipioOperacion.Location = new System.Drawing.Point(161, 474);
            this.txtNombreDelegacionMunicipioOperacion.MenuManager = this.barManager1;
            this.txtNombreDelegacionMunicipioOperacion.Name = "txtNombreDelegacionMunicipioOperacion";
            this.txtNombreDelegacionMunicipioOperacion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreDelegacionMunicipioOperacion.Properties.MaxLength = 255;
            this.txtNombreDelegacionMunicipioOperacion.Size = new System.Drawing.Size(747, 20);
            this.txtNombreDelegacionMunicipioOperacion.StyleController = this.dataLayoutControl1;
            this.txtNombreDelegacionMunicipioOperacion.TabIndex = 27;
            // 
            // txtNombrePoblacionCiudadOperacion
            // 
            this.txtNombrePoblacionCiudadOperacion.Location = new System.Drawing.Point(161, 498);
            this.txtNombrePoblacionCiudadOperacion.MenuManager = this.barManager1;
            this.txtNombrePoblacionCiudadOperacion.Name = "txtNombrePoblacionCiudadOperacion";
            this.txtNombrePoblacionCiudadOperacion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombrePoblacionCiudadOperacion.Properties.MaxLength = 255;
            this.txtNombrePoblacionCiudadOperacion.Size = new System.Drawing.Size(747, 20);
            this.txtNombrePoblacionCiudadOperacion.StyleController = this.dataLayoutControl1;
            this.txtNombrePoblacionCiudadOperacion.TabIndex = 28;
            // 
            // txtTelefono1
            // 
            this.txtTelefono1.Location = new System.Drawing.Point(161, 426);
            this.txtTelefono1.MenuManager = this.barManager1;
            this.txtTelefono1.Name = "txtTelefono1";
            this.txtTelefono1.Properties.MaxLength = 30;
            this.txtTelefono1.Size = new System.Drawing.Size(50, 20);
            this.txtTelefono1.StyleController = this.dataLayoutControl1;
            this.txtTelefono1.TabIndex = 31;
            // 
            // txtTelefono2
            // 
            this.txtTelefono2.Location = new System.Drawing.Point(340, 426);
            this.txtTelefono2.MenuManager = this.barManager1;
            this.txtTelefono2.Name = "txtTelefono2";
            this.txtTelefono2.Properties.MaxLength = 30;
            this.txtTelefono2.Size = new System.Drawing.Size(568, 20);
            this.txtTelefono2.StyleController = this.dataLayoutControl1;
            this.txtTelefono2.TabIndex = 32;
            // 
            // txtContacto
            // 
            this.txtContacto.Location = new System.Drawing.Point(161, 402);
            this.txtContacto.MenuManager = this.barManager1;
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtContacto.Properties.MaxLength = 100;
            this.txtContacto.Size = new System.Drawing.Size(747, 20);
            this.txtContacto.StyleController = this.dataLayoutControl1;
            this.txtContacto.TabIndex = 30;
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Location = new System.Drawing.Point(161, 450);
            this.txtCorreoElectronico.MenuManager = this.barManager1;
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtCorreoElectronico.Properties.Mask.EditMask = "\\w+([-+.\']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            this.txtCorreoElectronico.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtCorreoElectronico.Properties.MaxLength = 255;
            this.txtCorreoElectronico.Size = new System.Drawing.Size(747, 20);
            this.txtCorreoElectronico.StyleController = this.dataLayoutControl1;
            this.txtCorreoElectronico.TabIndex = 33;
            // 
            // txtPaginaWeb
            // 
            this.txtPaginaWeb.Location = new System.Drawing.Point(161, 474);
            this.txtPaginaWeb.MenuManager = this.barManager1;
            this.txtPaginaWeb.Name = "txtPaginaWeb";
            this.txtPaginaWeb.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtPaginaWeb.Properties.MaxLength = 255;
            this.txtPaginaWeb.Size = new System.Drawing.Size(747, 20);
            this.txtPaginaWeb.StyleController = this.dataLayoutControl1;
            this.txtPaginaWeb.TabIndex = 34;
            // 
            // cboIdEstatus
            // 
            this.cboIdEstatus.Location = new System.Drawing.Point(165, 572);
            this.cboIdEstatus.MenuManager = this.barManager1;
            this.cboIdEstatus.Name = "cboIdEstatus";
            this.cboIdEstatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboIdEstatus.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdEstatus", "Id Estatus", 72, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DescEstatus", "Estatus", 72, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cboIdEstatus.Properties.DataSource = this.vwCatEstatusClienteBindingSource;
            this.cboIdEstatus.Properties.DisplayMember = "DescEstatus";
            this.cboIdEstatus.Properties.NullText = "";
            this.cboIdEstatus.Properties.ValueMember = "IdEstatus";
            this.cboIdEstatus.Size = new System.Drawing.Size(50, 20);
            this.cboIdEstatus.StyleController = this.dataLayoutControl1;
            this.cboIdEstatus.TabIndex = 59;
            this.cboIdEstatus.Tag = "Estatus";
            this.cboIdEstatus.ToolTip = "Estatus";
            this.cboIdEstatus.EditValueChanged += new System.EventHandler(this.cboIdEstatus_EditValueChanged);
            // 
            // vwCatEstatusClienteBindingSource
            // 
            this.vwCatEstatusClienteBindingSource.DataMember = "vwCatEstatusCliente";
            this.vwCatEstatusClienteBindingSource.DataSource = this.dbSAIC_Catalogos;
            // 
            // chkConfidencial
            // 
            this.chkConfidencial.Location = new System.Drawing.Point(539, 378);
            this.chkConfidencial.MenuManager = this.barManager1;
            this.chkConfidencial.Name = "chkConfidencial";
            this.chkConfidencial.Properties.Caption = "Confidencial";
            this.chkConfidencial.Size = new System.Drawing.Size(80, 19);
            this.chkConfidencial.StyleController = this.dataLayoutControl1;
            this.chkConfidencial.TabIndex = 40;
            this.chkConfidencial.Tag = "Confidencial";
            // 
            // chkTieneSucursales
            // 
            this.chkTieneSucursales.Location = new System.Drawing.Point(433, 378);
            this.chkTieneSucursales.MenuManager = this.barManager1;
            this.chkTieneSucursales.Name = "chkTieneSucursales";
            this.chkTieneSucursales.Properties.Caption = "Tiene Sucursales";
            this.chkTieneSucursales.Size = new System.Drawing.Size(102, 19);
            this.chkTieneSucursales.StyleController = this.dataLayoutControl1;
            this.chkTieneSucursales.TabIndex = 39;
            this.chkTieneSucursales.Tag = "Tiene Sucursales";
            // 
            // spPctComisionBPO
            // 
            this.spPctComisionBPO.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spPctComisionBPO.Location = new System.Drawing.Point(101, 448);
            this.spPctComisionBPO.MenuManager = this.barManager1;
            this.spPctComisionBPO.Name = "spPctComisionBPO";
            this.spPctComisionBPO.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spPctComisionBPO.Properties.DisplayFormat.FormatString = "N6";
            this.spPctComisionBPO.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spPctComisionBPO.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spPctComisionBPO.Size = new System.Drawing.Size(54, 20);
            this.spPctComisionBPO.StyleController = this.dataLayoutControl1;
            this.spPctComisionBPO.TabIndex = 52;
            this.spPctComisionBPO.Tag = "Pct Comisión";
            this.spPctComisionBPO.ToolTip = "Pct Comisión";
            // 
            // calFechaBaja
            // 
            this.calFechaBaja.EditValue = null;
            this.calFechaBaja.Enabled = false;
            this.calFechaBaja.Location = new System.Drawing.Point(344, 572);
            this.calFechaBaja.MenuManager = this.barManager1;
            this.calFechaBaja.Name = "calFechaBaja";
            this.calFechaBaja.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calFechaBaja.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calFechaBaja.Size = new System.Drawing.Size(50, 20);
            this.calFechaBaja.StyleController = this.dataLayoutControl1;
            this.calFechaBaja.TabIndex = 60;
            this.calFechaBaja.TabStop = false;
            // 
            // UsuarioCreacionTextEdit
            // 
            this.UsuarioCreacionTextEdit.Location = new System.Drawing.Point(125, 301);
            this.UsuarioCreacionTextEdit.MenuManager = this.barManager1;
            this.UsuarioCreacionTextEdit.Name = "UsuarioCreacionTextEdit";
            this.UsuarioCreacionTextEdit.Size = new System.Drawing.Size(644, 20);
            this.UsuarioCreacionTextEdit.StyleController = this.dataLayoutControl1;
            this.UsuarioCreacionTextEdit.TabIndex = 43;
            // 
            // UsuarioModificacionTextEdit
            // 
            this.UsuarioModificacionTextEdit.Location = new System.Drawing.Point(125, 325);
            this.UsuarioModificacionTextEdit.MenuManager = this.barManager1;
            this.UsuarioModificacionTextEdit.Name = "UsuarioModificacionTextEdit";
            this.UsuarioModificacionTextEdit.Size = new System.Drawing.Size(644, 20);
            this.UsuarioModificacionTextEdit.StyleController = this.dataLayoutControl1;
            this.UsuarioModificacionTextEdit.TabIndex = 44;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtIdCliente.Enabled = false;
            this.txtIdCliente.Location = new System.Drawing.Point(149, 83);
            this.txtIdCliente.MenuManager = this.barManager1;
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.txtIdCliente.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtIdCliente.Size = new System.Drawing.Size(33, 20);
            this.txtIdCliente.StyleController = this.dataLayoutControl1;
            this.txtIdCliente.TabIndex = 2;
            this.txtIdCliente.TabStop = false;
            // 
            // cboIdActividadComercial
            // 
            this.cboIdActividadComercial.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.cboIdActividadComercial.Location = new System.Drawing.Point(149, 180);
            this.cboIdActividadComercial.MenuManager = this.barManager1;
            this.cboIdActividadComercial.Name = "cboIdActividadComercial";
            this.cboIdActividadComercial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboIdActividadComercial.Properties.DataSource = this.actividadComercialBindingSource;
            this.cboIdActividadComercial.Properties.DisplayMember = "DescActividadComercial";
            this.cboIdActividadComercial.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.cboIdActividadComercial.Properties.NullText = "";
            this.cboIdActividadComercial.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cboIdActividadComercial.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboIdActividadComercial.Properties.ValueMember = "IdActividadComercial";
            this.cboIdActividadComercial.Properties.View = this.gridView1;
            this.cboIdActividadComercial.Size = new System.Drawing.Size(435, 20);
            this.cboIdActividadComercial.StyleController = this.dataLayoutControl1;
            this.cboIdActividadComercial.TabIndex = 6;
            this.cboIdActividadComercial.Tag = "Actividad Comercial";
            // 
            // actividadComercialBindingSource
            // 
            this.actividadComercialBindingSource.DataMember = "ActividadComercial";
            this.actividadComercialBindingSource.DataSource = this.dbSAIC_Catalogos;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdActividadComercial1,
            this.colDescActividadComercial});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIdActividadComercial1
            // 
            this.colIdActividadComercial1.FieldName = "IdActividadComercial";
            this.colIdActividadComercial1.Name = "colIdActividadComercial1";
            // 
            // colDescActividadComercial
            // 
            this.colDescActividadComercial.Caption = "Actividad Comercial";
            this.colDescActividadComercial.FieldName = "DescActividadComercial";
            this.colDescActividadComercial.Name = "colDescActividadComercial";
            this.colDescActividadComercial.Visible = true;
            this.colDescActividadComercial.VisibleIndex = 0;
            // 
            // chkSeguro
            // 
            this.chkSeguro.Location = new System.Drawing.Point(623, 378);
            this.chkSeguro.MenuManager = this.barManager1;
            this.chkSeguro.Name = "chkSeguro";
            this.chkSeguro.Properties.Caption = "Seguro";
            this.chkSeguro.Size = new System.Drawing.Size(56, 19);
            this.chkSeguro.StyleController = this.dataLayoutControl1;
            this.chkSeguro.TabIndex = 41;
            this.chkSeguro.Tag = "Tiene Seguro";
            // 
            // txtRepresentanteLegal
            // 
            this.txtRepresentanteLegal.Location = new System.Drawing.Point(161, 378);
            this.txtRepresentanteLegal.Name = "txtRepresentanteLegal";
            this.txtRepresentanteLegal.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRepresentanteLegal.Properties.MaxLength = 100;
            this.txtRepresentanteLegal.Size = new System.Drawing.Size(747, 20);
            this.txtRepresentanteLegal.StyleController = this.dataLayoutControl1;
            this.txtRepresentanteLegal.TabIndex = 29;
            // 
            // spPctAsimilados
            // 
            this.spPctAsimilados.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spPctAsimilados.Location = new System.Drawing.Point(284, 448);
            this.spPctAsimilados.Name = "spPctAsimilados";
            this.spPctAsimilados.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spPctAsimilados.Properties.DisplayFormat.FormatString = "N6";
            this.spPctAsimilados.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spPctAsimilados.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spPctAsimilados.Size = new System.Drawing.Size(50, 20);
            this.spPctAsimilados.StyleController = this.dataLayoutControl1;
            this.spPctAsimilados.TabIndex = 55;
            this.spPctAsimilados.Tag = "Pct Comisión Asimilados";
            this.spPctAsimilados.ToolTip = "Pct Comisión Asimilados";
            // 
            // spISN
            // 
            this.spISN.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spISN.Location = new System.Drawing.Point(379, 378);
            this.spISN.Name = "spISN";
            this.spISN.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spISN.Properties.DisplayFormat.FormatString = "N2";
            this.spISN.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spISN.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spISN.Size = new System.Drawing.Size(50, 20);
            this.spISN.StyleController = this.dataLayoutControl1;
            this.spISN.TabIndex = 38;
            this.spISN.Tag = "ISN";
            this.spISN.ToolTip = "ISN";
            // 
            // chkDecreto
            // 
            this.chkDecreto.Location = new System.Drawing.Point(683, 378);
            this.chkDecreto.MenuManager = this.barManager1;
            this.chkDecreto.Name = "chkDecreto";
            this.chkDecreto.Properties.Caption = "Sin IVA";
            this.chkDecreto.Size = new System.Drawing.Size(56, 19);
            this.chkDecreto.StyleController = this.dataLayoutControl1;
            this.chkDecreto.TabIndex = 42;
            this.chkDecreto.Tag = "Tiene Decreto";
            // 
            // chkbPeriodicidad
            // 
            this.chkbPeriodicidad.Location = new System.Drawing.Point(252, 412);
            this.chkbPeriodicidad.MenuManager = this.barManager1;
            this.chkbPeriodicidad.Name = "chkbPeriodicidad";
            this.chkbPeriodicidad.Properties.AllowMultiSelect = true;
            this.chkbPeriodicidad.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.chkbPeriodicidad.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.chkbPeriodicidad.Properties.DataSource = this.stpFactSelTipoPeriodoNominaClienteBindingSource;
            this.chkbPeriodicidad.Properties.DisplayMember = "DescTipoPeriodoNomina";
            this.chkbPeriodicidad.Properties.MaxLength = 100;
            this.chkbPeriodicidad.Properties.ValueMember = "IdTipoPeriodoNomina";
            this.chkbPeriodicidad.Size = new System.Drawing.Size(66, 20);
            this.chkbPeriodicidad.StyleController = this.dataLayoutControl1;
            this.chkbPeriodicidad.TabIndex = 46;
            this.chkbPeriodicidad.Tag = "Periodicidad";
            // 
            // stpFactSelTipoPeriodoNominaClienteBindingSource
            // 
            this.stpFactSelTipoPeriodoNominaClienteBindingSource.DataMember = "stpFactSelTipoPeriodoNominaCliente";
            this.stpFactSelTipoPeriodoNominaClienteBindingSource.DataSource = this.dbSAICBPOFactura;
            // 
            // chkbFronting
            // 
            this.chkbFronting.Location = new System.Drawing.Point(526, 412);
            this.chkbFronting.MenuManager = this.barManager1;
            this.chkbFronting.Name = "chkbFronting";
            this.chkbFronting.Properties.AllowMultiSelect = true;
            this.chkbFronting.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.chkbFronting.Properties.DataSource = this.vwcatFrontingBindingSource;
            this.chkbFronting.Properties.DisplayMember = "RazonSocial";
            this.chkbFronting.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.chkbFronting.Properties.ValueMember = "IdMatrizTenedora";
            this.chkbFronting.Size = new System.Drawing.Size(382, 20);
            this.chkbFronting.StyleController = this.dataLayoutControl1;
            this.chkbFronting.TabIndex = 48;
            this.chkbFronting.Tag = "Fronting";
            // 
            // vwcatFrontingBindingSource
            // 
            this.vwcatFrontingBindingSource.DataMember = "vwcatFronting";
            this.vwcatFrontingBindingSource.DataSource = this.dbSAICBPOFactura;
            // 
            // chkbComision
            // 
            this.chkbComision.EditValue = "";
            this.chkbComision.Location = new System.Drawing.Point(427, 412);
            this.chkbComision.MenuManager = this.barManager1;
            this.chkbComision.Name = "chkbComision";
            this.chkbComision.Properties.AllowMultiSelect = true;
            this.chkbComision.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.chkbComision.Properties.DataSource = this.stpFactSelComisionClienteBindingSource;
            this.chkbComision.Properties.DisplayMember = "Desc";
            this.chkbComision.Properties.ValueMember = "IdConceptoComision";
            this.chkbComision.Size = new System.Drawing.Size(50, 20);
            this.chkbComision.StyleController = this.dataLayoutControl1;
            this.chkbComision.TabIndex = 53;
            this.chkbComision.Tag = "Conceptos de Comisión";
            this.chkbComision.ToolTip = "Conceptos de Comisión";
            // 
            // stpFactSelComisionClienteBindingSource
            // 
            this.stpFactSelComisionClienteBindingSource.DataMember = "stpFactSelComisionCliente";
            this.stpFactSelComisionClienteBindingSource.DataSource = this.dbSAICBPOFactura;
            // 
            // cbGrupo
            // 
            this.cbGrupo.EditValue = "0";
            this.cbGrupo.Location = new System.Drawing.Point(149, 206);
            this.cbGrupo.MenuManager = this.barManager1;
            this.cbGrupo.Name = "cbGrupo";
            this.cbGrupo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbGrupo.Properties.DataSource = this.stpFactSelMatrizClienteActivosBindingSource;
            this.cbGrupo.Properties.DisplayMember = "RazonSocial";
            this.cbGrupo.Properties.NullText = "";
            this.cbGrupo.Properties.PopupSizeable = false;
            this.cbGrupo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbGrupo.Properties.ValueMember = "IdMatrizCliente";
            this.cbGrupo.Properties.View = this.gridView2;
            this.cbGrupo.Size = new System.Drawing.Size(435, 20);
            this.cbGrupo.StyleController = this.dataLayoutControl1;
            this.cbGrupo.TabIndex = 7;
            this.cbGrupo.Tag = "Grupo";
            // 
            // stpFactSelMatrizClienteActivosBindingSource
            // 
            this.stpFactSelMatrizClienteActivosBindingSource.DataMember = "stpFactSelMatrizClienteActivos";
            this.stpFactSelMatrizClienteActivosBindingSource.DataSource = this.dbSAICBPOFactura;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdMatrizCliente0,
            this.colRazonSocial0});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colIdMatrizCliente0
            // 
            this.colIdMatrizCliente0.Caption = "IdMatrizCliente";
            this.colIdMatrizCliente0.FieldName = "IdMatrizCliente";
            this.colIdMatrizCliente0.Name = "colIdMatrizCliente0";
            // 
            // colRazonSocial0
            // 
            this.colRazonSocial0.Caption = "Razon Social";
            this.colRazonSocial0.FieldName = "RazonSocial";
            this.colRazonSocial0.Name = "colRazonSocial0";
            this.colRazonSocial0.Visible = true;
            this.colRazonSocial0.VisibleIndex = 0;
            // 
            // cbIdOperador
            // 
            this.cbIdOperador.EditValue = "";
            this.cbIdOperador.Location = new System.Drawing.Point(161, 498);
            this.cbIdOperador.Name = "cbIdOperador";
            this.cbIdOperador.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbIdOperador.Properties.DataSource = this.stpSelOperadorBindingSource;
            this.cbIdOperador.Properties.DisplayMember = "NombreCompletoOperador";
            this.cbIdOperador.Properties.NullText = "";
            this.cbIdOperador.Properties.PopupSizeable = false;
            this.cbIdOperador.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbIdOperador.Properties.ValueMember = "IdOperador";
            this.cbIdOperador.Properties.View = this.gridView3;
            this.cbIdOperador.Size = new System.Drawing.Size(747, 20);
            this.cbIdOperador.StyleController = this.dataLayoutControl1;
            this.cbIdOperador.TabIndex = 35;
            // 
            // stpSelOperadorBindingSource
            // 
            this.stpSelOperadorBindingSource.DataMember = "stpSelOperador";
            this.stpSelOperadorBindingSource.DataSource = this.dbSAICBPODataSet;
            // 
            // dbSAICBPODataSet
            // 
            this.dbSAICBPODataSet.DataSetName = "dbSAICBPODataSet";
            this.dbSAICBPODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdOperador0,
            this.colOperador});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colIdOperador0
            // 
            this.colIdOperador0.Caption = "IdOperador";
            this.colIdOperador0.FieldName = "IdOperador";
            this.colIdOperador0.Name = "colIdOperador0";
            // 
            // colOperador
            // 
            this.colOperador.Caption = "Operador";
            this.colOperador.FieldName = "NombreCompletoOperador";
            this.colOperador.Name = "colOperador";
            this.colOperador.Visible = true;
            this.colOperador.VisibleIndex = 0;
            // 
            // cbProductos
            // 
            this.cbProductos.Location = new System.Drawing.Point(91, 412);
            this.cbProductos.MenuManager = this.barManager1;
            this.cbProductos.Name = "cbProductos";
            this.cbProductos.Properties.AllowMultiSelect = true;
            this.cbProductos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbProductos.Properties.DataSource = this.productoBindingSource;
            this.cbProductos.Properties.DisplayMember = "DescProducto";
            this.cbProductos.Properties.ValueMember = "IdProducto";
            this.cbProductos.Size = new System.Drawing.Size(64, 20);
            this.cbProductos.StyleController = this.dataLayoutControl1;
            this.cbProductos.TabIndex = 59;
            this.cbProductos.Tag = "Productos";
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "Producto";
            this.productoBindingSource.DataSource = this.dbSAIC_Catalogos;
            // 
            // cbIdClaseRiesgo
            // 
            this.cbIdClaseRiesgo.Location = new System.Drawing.Point(290, 378);
            this.cbIdClaseRiesgo.MenuManager = this.barManager1;
            this.cbIdClaseRiesgo.Name = "cbIdClaseRiesgo";
            this.cbIdClaseRiesgo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbIdClaseRiesgo.Properties.DataSource = this.stpFactSelClaseRiesgoBindingSource;
            this.cbIdClaseRiesgo.Properties.DisplayMember = "DescClaseRiesgoIMSS";
            this.cbIdClaseRiesgo.Properties.NullText = "";
            this.cbIdClaseRiesgo.Properties.PopupSizeable = false;
            this.cbIdClaseRiesgo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbIdClaseRiesgo.Properties.ValueMember = "IdClaseRiesgoIMSS";
            this.cbIdClaseRiesgo.Properties.View = this.gridView4;
            this.cbIdClaseRiesgo.Size = new System.Drawing.Size(50, 20);
            this.cbIdClaseRiesgo.StyleController = this.dataLayoutControl1;
            this.cbIdClaseRiesgo.TabIndex = 37;
            this.cbIdClaseRiesgo.Tag = "Clase de Riesgo";
            this.cbIdClaseRiesgo.ToolTip = "Clase de Riesgo";
            // 
            // stpFactSelClaseRiesgoBindingSource
            // 
            this.stpFactSelClaseRiesgoBindingSource.DataMember = "stpFactSelClaseRiesgo";
            this.stpFactSelClaseRiesgoBindingSource.DataSource = this.dbSAICBPOFactura;
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.COLIdClaseRiesgoIMSS,
            this.COLDescClaseRiesgoIMSS});
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // COLIdClaseRiesgoIMSS
            // 
            this.COLIdClaseRiesgoIMSS.Caption = "ID";
            this.COLIdClaseRiesgoIMSS.FieldName = "IdClaseRiesgoIMSS";
            this.COLIdClaseRiesgoIMSS.Name = "COLIdClaseRiesgoIMSS";
            // 
            // COLDescClaseRiesgoIMSS
            // 
            this.COLDescClaseRiesgoIMSS.Caption = "Clase";
            this.COLDescClaseRiesgoIMSS.FieldName = "DescClaseRiesgoIMSS";
            this.COLDescClaseRiesgoIMSS.Name = "COLDescClaseRiesgoIMSS";
            this.COLDescClaseRiesgoIMSS.Visible = true;
            this.COLDescClaseRiesgoIMSS.VisibleIndex = 0;
            // 
            // cboIdTipoClienteProveedor
            // 
            this.cboIdTipoClienteProveedor.Location = new System.Drawing.Point(151, 378);
            this.cboIdTipoClienteProveedor.MenuManager = this.barManager1;
            this.cboIdTipoClienteProveedor.Name = "cboIdTipoClienteProveedor";
            this.cboIdTipoClienteProveedor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboIdTipoClienteProveedor.Properties.DataSource = this.tipoClienteProveedorBindingSource;
            this.cboIdTipoClienteProveedor.Properties.DisplayMember = "DescTipoClienteProveedor";
            this.cboIdTipoClienteProveedor.Properties.NullText = "";
            this.cboIdTipoClienteProveedor.Properties.ValueMember = "IdTipoClienteProveedor";
            this.cboIdTipoClienteProveedor.Properties.View = this.gridView5;
            this.cboIdTipoClienteProveedor.Size = new System.Drawing.Size(50, 20);
            this.cboIdTipoClienteProveedor.StyleController = this.dataLayoutControl1;
            this.cboIdTipoClienteProveedor.TabIndex = 36;
            this.cboIdTipoClienteProveedor.Tag = "Tipo Cliente/Proveedor";
            this.cboIdTipoClienteProveedor.ToolTip = "Tipo Cliente/Proveedor";
            // 
            // tipoClienteProveedorBindingSource
            // 
            this.tipoClienteProveedorBindingSource.DataMember = "TipoClienteProveedor";
            this.tipoClienteProveedorBindingSource.DataSource = this.dbSAIC_Catalogos;
            // 
            // gridView5
            // 
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colDescTipoClienteProveedor});
            this.gridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "IdTipoClienteProveedor";
            this.colId.Name = "colId";
            // 
            // colDescTipoClienteProveedor
            // 
            this.colDescTipoClienteProveedor.Caption = "Tipo";
            this.colDescTipoClienteProveedor.FieldName = "DescTipoClienteProveedor";
            this.colDescTipoClienteProveedor.Name = "colDescTipoClienteProveedor";
            this.colDescTipoClienteProveedor.Visible = true;
            this.colDescTipoClienteProveedor.VisibleIndex = 0;
            // 
            // btnExportar
            // 
            this.btnExportar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExportar.ImageOptions.Image")));
            this.btnExportar.Location = new System.Drawing.Point(936, 157);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(121, 22);
            this.btnExportar.StyleController = this.dataLayoutControl1;
            this.btnExportar.TabIndex = 61;
            this.btnExportar.Text = "Carta Instrucción";
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // cboIdRegimenFiscalSAT
            // 
            this.cboIdRegimenFiscalSAT.Location = new System.Drawing.Point(161, 522);
            this.cboIdRegimenFiscalSAT.Name = "cboIdRegimenFiscalSAT";
            this.cboIdRegimenFiscalSAT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboIdRegimenFiscalSAT.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdRegimenFiscal", "Id Regimen Fiscal", 30, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DescRegimenFiscal", "Desc Regimen Fiscal", 127, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cboIdRegimenFiscalSAT.Properties.DataSource = this.stpSelRegimenFiscalSATBindingSource;
            this.cboIdRegimenFiscalSAT.Properties.DisplayMember = "DescRegimenFiscal";
            this.cboIdRegimenFiscalSAT.Properties.NullText = "";
            this.cboIdRegimenFiscalSAT.Properties.ValueMember = "IdRegimenFiscal";
            this.cboIdRegimenFiscalSAT.Size = new System.Drawing.Size(532, 20);
            this.cboIdRegimenFiscalSAT.StyleController = this.dataLayoutControl1;
            this.cboIdRegimenFiscalSAT.TabIndex = 62;
            this.cboIdRegimenFiscalSAT.Tag = "Regimen Fiscal SAT";
            // 
            // stpSelRegimenFiscalSATBindingSource
            // 
            this.stpSelRegimenFiscalSATBindingSource.DataMember = "stpSelRegimenFiscalSAT";
            this.stpSelRegimenFiscalSATBindingSource.DataSource = this.dbSAIC_Catalogos;
            // 
            // cbPlazaCliente
            // 
            this.cbPlazaCliente.EditValue = "";
            this.cbPlazaCliente.Location = new System.Drawing.Point(161, 522);
            this.cbPlazaCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPlazaCliente.Name = "cbPlazaCliente";
            this.cbPlazaCliente.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbPlazaCliente.Properties.DataSource = this.stpSelPlazaClienteBindingSource;
            this.cbPlazaCliente.Properties.DisplayMember = "DescPlazaCliente";
            this.cbPlazaCliente.Properties.ValueMember = "idPlazaCliente";
            this.cbPlazaCliente.Properties.View = this.gridView6;
            this.cbPlazaCliente.Size = new System.Drawing.Size(747, 20);
            this.cbPlazaCliente.StyleController = this.dataLayoutControl1;
            this.cbPlazaCliente.TabIndex = 62;
            this.cbPlazaCliente.Tag = "Plaza Operacion Cliente";
            // 
            // stpSelPlazaClienteBindingSource
            // 
            this.stpSelPlazaClienteBindingSource.DataMember = "stpSelPlazaCliente";
            this.stpSelPlazaClienteBindingSource.DataSource = this.dbSAICBPOCatalogosDataSet;
            // 
            // gridView6
            // 
            this.gridView6.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView6.Name = "gridView6";
            this.gridView6.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView6.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "idPlazaCliente";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Plaza Cliente";
            this.gridColumn2.FieldName = "DescPlazaCliente";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // spSaldoFavor
            // 
            this.spSaldoFavor.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spSaldoFavor.Location = new System.Drawing.Point(409, 448);
            this.spSaldoFavor.MenuManager = this.barManager1;
            this.spSaldoFavor.Name = "spSaldoFavor";
            this.spSaldoFavor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spSaldoFavor.Properties.DisplayFormat.FormatString = "N2";
            this.spSaldoFavor.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spSaldoFavor.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.spSaldoFavor.Size = new System.Drawing.Size(81, 20);
            this.spSaldoFavor.StyleController = this.dataLayoutControl1;
            this.spSaldoFavor.TabIndex = 56;
            this.spSaldoFavor.Tag = "Saldo a Favor";
            this.spSaldoFavor.ToolTip = "Saldo a Favor";
            // 
            // spFinanciamiento
            // 
            this.spFinanciamiento.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spFinanciamiento.Location = new System.Drawing.Point(570, 448);
            this.spFinanciamiento.MenuManager = this.barManager1;
            this.spFinanciamiento.Name = "spFinanciamiento";
            this.spFinanciamiento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spFinanciamiento.Properties.DisplayFormat.FormatString = "N2";
            this.spFinanciamiento.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spFinanciamiento.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.spFinanciamiento.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.spFinanciamiento.Size = new System.Drawing.Size(338, 20);
            this.spFinanciamiento.StyleController = this.dataLayoutControl1;
            this.spFinanciamiento.TabIndex = 57;
            this.spFinanciamiento.Tag = "Financiamiento";
            this.spFinanciamiento.ToolTip = "Financiamiento";
            // 
            // spComision
            // 
            this.spComision.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spComision.Location = new System.Drawing.Point(83, 402);
            this.spComision.Name = "spComision";
            this.spComision.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spComision.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.spComision.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.spComision.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spComision.Size = new System.Drawing.Size(59, 20);
            this.spComision.StyleController = this.dataLayoutControl1;
            this.spComision.TabIndex = 64;
            this.spComision.Tag = "Comisión";
            // 
            // txtObservacionesPromo
            // 
            this.txtObservacionesPromo.Location = new System.Drawing.Point(431, 378);
            this.txtObservacionesPromo.MenuManager = this.barManager1;
            this.txtObservacionesPromo.Name = "txtObservacionesPromo";
            this.txtObservacionesPromo.Properties.MaxLength = 200;
            this.txtObservacionesPromo.Size = new System.Drawing.Size(477, 20);
            this.txtObservacionesPromo.StyleController = this.dataLayoutControl1;
            this.txtObservacionesPromo.TabIndex = 65;
            this.txtObservacionesPromo.Tag = "Observaciones";
            // 
            // btnAgregarPromo
            // 
            this.btnAgregarPromo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarPromo.ImageOptions.Image")));
            this.btnAgregarPromo.Location = new System.Drawing.Point(604, 402);
            this.btnAgregarPromo.Name = "btnAgregarPromo";
            this.btnAgregarPromo.Size = new System.Drawing.Size(67, 22);
            this.btnAgregarPromo.StyleController = this.dataLayoutControl1;
            this.btnAgregarPromo.TabIndex = 66;
            this.btnAgregarPromo.Text = "Agregar";
            this.btnAgregarPromo.Click += new System.EventHandler(this.btnAgregarPromo_Click);
            // 
            // btnEliminarProm
            // 
            this.btnEliminarProm.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarProm.ImageOptions.Image")));
            this.btnEliminarProm.Location = new System.Drawing.Point(646, 462);
            this.btnEliminarProm.Name = "btnEliminarProm";
            this.btnEliminarProm.Size = new System.Drawing.Size(262, 22);
            this.btnEliminarProm.StyleController = this.dataLayoutControl1;
            this.btnEliminarProm.TabIndex = 68;
            this.btnEliminarProm.Text = "Eliminar";
            this.btnEliminarProm.Click += new System.EventHandler(this.btnEliminarProm_Click);
            // 
            // btnModificPromotor
            // 
            this.btnModificPromotor.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnModificPromotor.ImageOptions.Image")));
            this.btnModificPromotor.Location = new System.Drawing.Point(490, 462);
            this.btnModificPromotor.Name = "btnModificPromotor";
            this.btnModificPromotor.Size = new System.Drawing.Size(77, 22);
            this.btnModificPromotor.StyleController = this.dataLayoutControl1;
            this.btnModificPromotor.TabIndex = 69;
            this.btnModificPromotor.Text = "Modificar";
            this.btnModificPromotor.Click += new System.EventHandler(this.btnModificPromotor_Click);
            // 
            // btnGuardarPromo
            // 
            this.btnGuardarPromo.Enabled = false;
            this.btnGuardarPromo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarPromo.ImageOptions.Image")));
            this.btnGuardarPromo.Location = new System.Drawing.Point(675, 402);
            this.btnGuardarPromo.Name = "btnGuardarPromo";
            this.btnGuardarPromo.Size = new System.Drawing.Size(233, 22);
            this.btnGuardarPromo.StyleController = this.dataLayoutControl1;
            this.btnGuardarPromo.TabIndex = 70;
            this.btnGuardarPromo.Text = "Guardar";
            this.btnGuardarPromo.Visible = false;
            this.btnGuardarPromo.Click += new System.EventHandler(this.btnGuardarPromo_Click);
            // 
            // cbRelIdPromotor
            // 
            this.cbRelIdPromotor.Location = new System.Drawing.Point(96, 462);
            this.cbRelIdPromotor.MenuManager = this.barManager1;
            this.cbRelIdPromotor.Name = "cbRelIdPromotor";
            this.cbRelIdPromotor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbRelIdPromotor.Properties.DataSource = this.stpSelClientePromotoresBindingSource;
            this.cbRelIdPromotor.Properties.DisplayMember = "NombreCompletoPromotor";
            this.cbRelIdPromotor.Properties.NullText = "";
            this.cbRelIdPromotor.Properties.ValueMember = "IdRelClientePromotor";
            this.cbRelIdPromotor.Properties.View = this.gridView7;
            this.cbRelIdPromotor.Size = new System.Drawing.Size(390, 20);
            this.cbRelIdPromotor.StyleController = this.dataLayoutControl1;
            this.cbRelIdPromotor.TabIndex = 67;
            this.cbRelIdPromotor.EditValueChanged += new System.EventHandler(this.cbRelIdPromotor_EditValueChanged);
            // 
            // stpSelClientePromotoresBindingSource
            // 
            this.stpSelClientePromotoresBindingSource.DataMember = "stpSelClientePromotores";
            this.stpSelClientePromotoresBindingSource.DataSource = this.dbSAIC_Catalogos;
            // 
            // gridView7
            // 
            this.gridView7.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdRelClientePromotor,
            this.colIdPromotor1,
            this.colNombreCompletoPromotor,
            this.colComision,
            this.colIVA,
            this.colUtilidadReal,
            this.colObservaciones1});
            this.gridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView7.Name = "gridView7";
            this.gridView7.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView7.OptionsView.ShowGroupPanel = false;
            // 
            // colIdRelClientePromotor
            // 
            this.colIdRelClientePromotor.FieldName = "IdRelClientePromotor";
            this.colIdRelClientePromotor.Name = "colIdRelClientePromotor";
            this.colIdRelClientePromotor.Visible = true;
            this.colIdRelClientePromotor.VisibleIndex = 0;
            // 
            // colIdPromotor1
            // 
            this.colIdPromotor1.FieldName = "IdPromotor";
            this.colIdPromotor1.Name = "colIdPromotor1";
            // 
            // colNombreCompletoPromotor
            // 
            this.colNombreCompletoPromotor.FieldName = "NombreCompletoPromotor";
            this.colNombreCompletoPromotor.Name = "colNombreCompletoPromotor";
            this.colNombreCompletoPromotor.Visible = true;
            this.colNombreCompletoPromotor.VisibleIndex = 1;
            // 
            // colComision
            // 
            this.colComision.Caption = "Comisión";
            this.colComision.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colComision.FieldName = "Comision";
            this.colComision.Name = "colComision";
            this.colComision.Visible = true;
            this.colComision.VisibleIndex = 2;
            // 
            // colIVA
            // 
            this.colIVA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colIVA.FieldName = "IVA";
            this.colIVA.Name = "colIVA";
            this.colIVA.Visible = true;
            this.colIVA.VisibleIndex = 3;
            // 
            // colUtilidadReal
            // 
            this.colUtilidadReal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colUtilidadReal.FieldName = "UtilidadReal";
            this.colUtilidadReal.Name = "colUtilidadReal";
            this.colUtilidadReal.Visible = true;
            this.colUtilidadReal.VisibleIndex = 4;
            // 
            // colObservaciones1
            // 
            this.colObservaciones1.FieldName = "Observaciones";
            this.colObservaciones1.Name = "colObservaciones1";
            this.colObservaciones1.Visible = true;
            this.colObservaciones1.VisibleIndex = 5;
            // 
            // cbPromotor
            // 
            this.cbPromotor.EditValue = "";
            this.cbPromotor.Location = new System.Drawing.Point(85, 378);
            this.cbPromotor.MenuManager = this.barManager1;
            this.cbPromotor.Name = "cbPromotor";
            this.cbPromotor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbPromotor.Properties.DataSource = this.stpSelPromotoresActivosBindingSource;
            this.cbPromotor.Properties.DisplayMember = "NombreCompletoPromotor";
            this.cbPromotor.Properties.NullText = "";
            this.cbPromotor.Properties.PopupSizeable = false;
            this.cbPromotor.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbPromotor.Properties.ValueMember = "IdPromotor";
            this.cbPromotor.Properties.View = this.gridView8;
            this.cbPromotor.Size = new System.Drawing.Size(266, 20);
            this.cbPromotor.StyleController = this.dataLayoutControl1;
            this.cbPromotor.TabIndex = 63;
            this.cbPromotor.Tag = "Promotor";
            // 
            // stpSelPromotoresActivosBindingSource
            // 
            this.stpSelPromotoresActivosBindingSource.DataMember = "stpSelPromotoresActivos";
            this.stpSelPromotoresActivosBindingSource.DataSource = this.dbSAICCatalogosBindingSource;
            // 
            // dbSAICCatalogosBindingSource
            // 
            this.dbSAICCatalogosBindingSource.DataSource = this.dbSAIC_Catalogos;
            this.dbSAICCatalogosBindingSource.Position = 0;
            // 
            // gridView8
            // 
            this.gridView8.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdPromotor,
            this.colNombre,
            this.CorreoElectronico});
            this.gridView8.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView8.Name = "gridView8";
            this.gridView8.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView8.OptionsView.ShowGroupPanel = false;
            // 
            // colIdPromotor
            // 
            this.colIdPromotor.Caption = "Id";
            this.colIdPromotor.FieldName = "IdPromotor";
            this.colIdPromotor.Name = "colIdPromotor";
            this.colIdPromotor.Visible = true;
            this.colIdPromotor.VisibleIndex = 0;
            this.colIdPromotor.Width = 66;
            // 
            // colNombre
            // 
            this.colNombre.Caption = "Nombre";
            this.colNombre.FieldName = "NombreCompletoPromotor";
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 1;
            this.colNombre.Width = 330;
            // 
            // CorreoElectronico
            // 
            this.CorreoElectronico.Caption = "Correo Electronico";
            this.CorreoElectronico.FieldName = "CorreoElectronico";
            this.CorreoElectronico.Name = "CorreoElectronico";
            this.CorreoElectronico.Visible = true;
            this.CorreoElectronico.VisibleIndex = 2;
            this.CorreoElectronico.Width = 296;
            // 
            // btnCancelarPro
            // 
            this.btnCancelarPro.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarPro.ImageOptions.Image")));
            this.btnCancelarPro.Location = new System.Drawing.Point(571, 462);
            this.btnCancelarPro.Name = "btnCancelarPro";
            this.btnCancelarPro.Size = new System.Drawing.Size(71, 22);
            this.btnCancelarPro.StyleController = this.dataLayoutControl1;
            this.btnCancelarPro.TabIndex = 71;
            this.btnCancelarPro.Text = "Cancelar";
            this.btnCancelarPro.Click += new System.EventHandler(this.btnCancelarPro_Click);
            // 
            // RegimenCapitaltextEdit
            // 
            this.RegimenCapitaltextEdit.EditValue = "";
            this.RegimenCapitaltextEdit.Location = new System.Drawing.Point(572, 108);
            this.RegimenCapitaltextEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegimenCapitaltextEdit.MenuManager = this.barManager1;
            this.RegimenCapitaltextEdit.Name = "RegimenCapitaltextEdit";
            this.RegimenCapitaltextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.RegimenCapitaltextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.RegimenCapitaltextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.RegimenCapitaltextEdit.Size = new System.Drawing.Size(348, 20);
            this.RegimenCapitaltextEdit.StyleController = this.dataLayoutControl1;
            this.RegimenCapitaltextEdit.TabIndex = 72;
            this.RegimenCapitaltextEdit.Tag = "Regimen Capital";
            // 
            // btnPromotores
            // 
            this.btnPromotores.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPromotores.ImageOptions.Image")));
            this.btnPromotores.Location = new System.Drawing.Point(936, 183);
            this.btnPromotores.Name = "btnPromotores";
            this.btnPromotores.Size = new System.Drawing.Size(121, 22);
            this.btnPromotores.StyleController = this.dataLayoutControl1;
            this.btnPromotores.TabIndex = 73;
            this.btnPromotores.Text = "Pomotores";
            this.btnPromotores.Click += new System.EventHandler(this.btnPromotores_Click);
            // 
            // spIVA
            // 
            this.spIVA.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spIVA.Location = new System.Drawing.Point(168, 402);
            this.spIVA.MenuManager = this.barManager1;
            this.spIVA.Name = "spIVA";
            this.spIVA.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spIVA.Size = new System.Drawing.Size(62, 20);
            this.spIVA.StyleController = this.dataLayoutControl1;
            this.spIVA.TabIndex = 76;
            this.spIVA.Tag = "IVA";
            // 
            // spUtilidadReal
            // 
            this.spUtilidadReal.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spUtilidadReal.Location = new System.Drawing.Point(298, 402);
            this.spUtilidadReal.MenuManager = this.barManager1;
            this.spUtilidadReal.Name = "spUtilidadReal";
            this.spUtilidadReal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spUtilidadReal.Size = new System.Drawing.Size(52, 20);
            this.spUtilidadReal.StyleController = this.dataLayoutControl1;
            this.spUtilidadReal.TabIndex = 77;
            this.spUtilidadReal.Tag = "Utilidad Real";
            // 
            // spPctBPOTarjeta
            // 
            this.spPctBPOTarjeta.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spPctBPOTarjeta.Location = new System.Drawing.Point(170, 415);
            this.spPctBPOTarjeta.MenuManager = this.barManager1;
            this.spPctBPOTarjeta.Name = "spPctBPOTarjeta";
            this.spPctBPOTarjeta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spPctBPOTarjeta.Size = new System.Drawing.Size(114, 20);
            this.spPctBPOTarjeta.StyleController = this.dataLayoutControl1;
            this.spPctBPOTarjeta.TabIndex = 78;
            this.spPctBPOTarjeta.Tag = "Tarjeta Casa";
            // 
            // spPctProTarjeta
            // 
            this.spPctProTarjeta.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spPctProTarjeta.Location = new System.Drawing.Point(296, 415);
            this.spPctProTarjeta.MenuManager = this.barManager1;
            this.spPctProTarjeta.Name = "spPctProTarjeta";
            this.spPctProTarjeta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spPctProTarjeta.Size = new System.Drawing.Size(114, 20);
            this.spPctProTarjeta.StyleController = this.dataLayoutControl1;
            this.spPctProTarjeta.TabIndex = 79;
            this.spPctProTarjeta.Tag = "Tarjeta Proveedor";
            // 
            // spPctBPOCucas
            // 
            this.spPctBPOCucas.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spPctBPOCucas.Location = new System.Drawing.Point(170, 439);
            this.spPctBPOCucas.MenuManager = this.barManager1;
            this.spPctBPOCucas.Name = "spPctBPOCucas";
            this.spPctBPOCucas.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spPctBPOCucas.Size = new System.Drawing.Size(114, 20);
            this.spPctBPOCucas.StyleController = this.dataLayoutControl1;
            this.spPctBPOCucas.TabIndex = 80;
            this.spPctBPOCucas.Tag = "Cucas Casa";
            // 
            // spPctProCucas
            // 
            this.spPctProCucas.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spPctProCucas.Location = new System.Drawing.Point(296, 439);
            this.spPctProCucas.MenuManager = this.barManager1;
            this.spPctProCucas.Name = "spPctProCucas";
            this.spPctProCucas.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spPctProCucas.Size = new System.Drawing.Size(114, 20);
            this.spPctProCucas.StyleController = this.dataLayoutControl1;
            this.spPctProCucas.TabIndex = 81;
            this.spPctProCucas.Tag = "Cucas Proveedor";
            // 
            // spPctBPOEfectivo
            // 
            this.spPctBPOEfectivo.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spPctBPOEfectivo.Location = new System.Drawing.Point(170, 463);
            this.spPctBPOEfectivo.MenuManager = this.barManager1;
            this.spPctBPOEfectivo.Name = "spPctBPOEfectivo";
            this.spPctBPOEfectivo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spPctBPOEfectivo.Size = new System.Drawing.Size(114, 20);
            this.spPctBPOEfectivo.StyleController = this.dataLayoutControl1;
            this.spPctBPOEfectivo.TabIndex = 82;
            this.spPctBPOEfectivo.Tag = "Efectivos Casa";
            // 
            // spPctProEfectivo
            // 
            this.spPctProEfectivo.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spPctProEfectivo.Location = new System.Drawing.Point(296, 463);
            this.spPctProEfectivo.MenuManager = this.barManager1;
            this.spPctProEfectivo.Name = "spPctProEfectivo";
            this.spPctProEfectivo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spPctProEfectivo.Size = new System.Drawing.Size(114, 20);
            this.spPctProEfectivo.StyleController = this.dataLayoutControl1;
            this.spPctProEfectivo.TabIndex = 83;
            this.spPctProEfectivo.Tag = "Efectivos Proveedor";
            // 
            // spPctBPOSeguros
            // 
            this.spPctBPOSeguros.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spPctBPOSeguros.Location = new System.Drawing.Point(170, 487);
            this.spPctBPOSeguros.MenuManager = this.barManager1;
            this.spPctBPOSeguros.Name = "spPctBPOSeguros";
            this.spPctBPOSeguros.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spPctBPOSeguros.Size = new System.Drawing.Size(114, 20);
            this.spPctBPOSeguros.StyleController = this.dataLayoutControl1;
            this.spPctBPOSeguros.TabIndex = 84;
            this.spPctBPOSeguros.Tag = "Seguros Casa";
            // 
            // spPctProSeguros
            // 
            this.spPctProSeguros.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spPctProSeguros.Location = new System.Drawing.Point(296, 487);
            this.spPctProSeguros.MenuManager = this.barManager1;
            this.spPctProSeguros.Name = "spPctProSeguros";
            this.spPctProSeguros.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spPctProSeguros.Size = new System.Drawing.Size(114, 20);
            this.spPctProSeguros.StyleController = this.dataLayoutControl1;
            this.spPctProSeguros.TabIndex = 85;
            this.spPctProSeguros.Tag = "Seguros Proveedor";
            // 
            // spPctBPOProveedor
            // 
            this.spPctBPOProveedor.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spPctBPOProveedor.Location = new System.Drawing.Point(170, 511);
            this.spPctBPOProveedor.MenuManager = this.barManager1;
            this.spPctBPOProveedor.Name = "spPctBPOProveedor";
            this.spPctBPOProveedor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spPctBPOProveedor.Size = new System.Drawing.Size(114, 20);
            this.spPctBPOProveedor.StyleController = this.dataLayoutControl1;
            this.spPctBPOProveedor.TabIndex = 86;
            this.spPctBPOProveedor.Tag = "Proveedores Casa";
            // 
            // spPctProProveedor
            // 
            this.spPctProProveedor.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spPctProProveedor.Location = new System.Drawing.Point(296, 511);
            this.spPctProProveedor.MenuManager = this.barManager1;
            this.spPctProProveedor.Name = "spPctProProveedor";
            this.spPctProProveedor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spPctProProveedor.Size = new System.Drawing.Size(114, 20);
            this.spPctProProveedor.StyleController = this.dataLayoutControl1;
            this.spPctProProveedor.TabIndex = 87;
            this.spPctProProveedor.Tag = "Proveedores Proveedor";
            // 
            // ItemForUsuarioCreacion
            // 
            this.ItemForUsuarioCreacion.Control = this.UsuarioCreacionTextEdit;
            this.ItemForUsuarioCreacion.CustomizationFormText = "Usuario Creacion";
            this.ItemForUsuarioCreacion.Location = new System.Drawing.Point(0, 684);
            this.ItemForUsuarioCreacion.Name = "ItemForUsuarioCreacion";
            this.ItemForUsuarioCreacion.Size = new System.Drawing.Size(761, 24);
            this.ItemForUsuarioCreacion.Text = "Usuario Creacion";
            this.ItemForUsuarioCreacion.TextSize = new System.Drawing.Size(190, 13);
            // 
            // ItemForUsuarioModificacion
            // 
            this.ItemForUsuarioModificacion.Control = this.UsuarioModificacionTextEdit;
            this.ItemForUsuarioModificacion.CustomizationFormText = "Usuario Modificacion";
            this.ItemForUsuarioModificacion.Location = new System.Drawing.Point(0, 684);
            this.ItemForUsuarioModificacion.Name = "ItemForUsuarioModificacion";
            this.ItemForUsuarioModificacion.Size = new System.Drawing.Size(761, 24);
            this.ItemForUsuarioModificacion.Text = "Usuario Modificacion";
            this.ItemForUsuarioModificacion.TextSize = new System.Drawing.Size(190, 13);
            // 
            // Root
            // 
            this.Root.CustomizationFormText = "Root";
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Location = new System.Drawing.Point(0, 0);
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1069, 606);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.CustomizationFormText = "autoGeneratedGroup0";
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup5,
            this.layoutControlGroup6,
            this.ItemForIdEstatus,
            this.ItemForFechaBaja,
            this.emptySpaceItem1,
            this.emptySpaceItem11,
            this.layoutControlItem4,
            this.emptySpaceItem12,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem9,
            this.emptySpaceItem4,
            this.emptySpaceItem3,
            this.layoutControlItem25,
            this.layoutControlItem39});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1049, 586);
            // 
            // layoutControlGroup5
            // 
            this.layoutControlGroup5.CustomizationFormText = "Domicilios y Contacto";
            this.layoutControlGroup5.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.tcgInformacionAdicional});
            this.layoutControlGroup5.Location = new System.Drawing.Point(0, 302);
            this.layoutControlGroup5.Name = "layoutControlGroup5";
            this.layoutControlGroup5.Size = new System.Drawing.Size(924, 258);
            this.layoutControlGroup5.Text = "Información Adicional";
            // 
            // tcgInformacionAdicional
            // 
            this.tcgInformacionAdicional.CustomizationFormText = "tabbedControlGroup1";
            this.tcgInformacionAdicional.Location = new System.Drawing.Point(0, 0);
            this.tcgInformacionAdicional.Name = "tcgInformacionAdicional";
            this.tcgInformacionAdicional.SelectedTabPage = this.layoutControlGroup9;
            this.tcgInformacionAdicional.SelectedTabPageIndex = 4;
            this.tcgInformacionAdicional.Size = new System.Drawing.Size(900, 216);
            this.tcgInformacionAdicional.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlGroup3,
            this.layoutControlGroup4,
            this.layoutControlGroup7,
            this.layoutControlGroup9,
            this.layoutControlGroup8});
            // 
            // layoutControlGroup9
            // 
            this.layoutControlGroup9.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.simpleLabelItem1,
            this.simpleLabelItem2,
            this.simpleLabelItem3,
            this.simpleLabelItem4,
            this.simpleLabelItem5,
            this.layoutControlItem44,
            this.layoutControlItem45,
            this.emptySpaceItem13,
            this.layoutControlItem46,
            this.layoutControlItem47,
            this.layoutControlItem48,
            this.layoutControlItem49,
            this.layoutControlItem50,
            this.layoutControlItem51,
            this.layoutControlItem52,
            this.layoutControlItem53,
            this.simpleLabelItem6,
            this.simpleLabelItem7,
            this.simpleLabelItem8,
            this.simpleLabelItem9,
            this.emptySpaceItem19,
            this.emptySpaceItem20,
            this.emptySpaceItem21,
            this.emptySpaceItem22,
            this.emptySpaceItem24,
            this.emptySpaceItem25,
            this.simpleLabelItem10,
            this.simpleLabelItem11,
            this.simpleLabelItem12,
            this.layoutControlItem54,
            this.layoutControlItem55,
            this.simpleLabelItem13,
            this.layoutControlItem56,
            this.layoutControlItem57,
            this.emptySpaceItem26});
            this.layoutControlGroup9.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup9.Name = "layoutControlGroup9";
            this.layoutControlGroup9.Size = new System.Drawing.Size(876, 170);
            this.layoutControlGroup9.Text = "Productos";
            // 
            // simpleLabelItem1
            // 
            this.simpleLabelItem1.AllowHotTrack = false;
            this.simpleLabelItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleLabelItem1.AppearanceItemCaption.Options.UseFont = true;
            this.simpleLabelItem1.AppearanceItemCaption.Options.UseTextOptions = true;
            this.simpleLabelItem1.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.simpleLabelItem1.Location = new System.Drawing.Point(0, 0);
            this.simpleLabelItem1.Name = "simpleLabelItem1";
            this.simpleLabelItem1.Size = new System.Drawing.Size(378, 20);
            this.simpleLabelItem1.Text = "Comisiones %";
            this.simpleLabelItem1.TextSize = new System.Drawing.Size(122, 16);
            // 
            // simpleLabelItem2
            // 
            this.simpleLabelItem2.AllowHotTrack = false;
            this.simpleLabelItem2.Location = new System.Drawing.Point(0, 20);
            this.simpleLabelItem2.Name = "simpleLabelItem2";
            this.simpleLabelItem2.Size = new System.Drawing.Size(126, 17);
            this.simpleLabelItem2.Text = " ";
            this.simpleLabelItem2.TextSize = new System.Drawing.Size(122, 13);
            // 
            // simpleLabelItem3
            // 
            this.simpleLabelItem3.AllowHotTrack = false;
            this.simpleLabelItem3.AppearanceItemCaption.Options.UseTextOptions = true;
            this.simpleLabelItem3.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.simpleLabelItem3.Location = new System.Drawing.Point(126, 20);
            this.simpleLabelItem3.Name = "simpleLabelItem3";
            this.simpleLabelItem3.Size = new System.Drawing.Size(126, 17);
            this.simpleLabelItem3.Text = "Casa";
            this.simpleLabelItem3.TextSize = new System.Drawing.Size(122, 13);
            // 
            // simpleLabelItem4
            // 
            this.simpleLabelItem4.AllowHotTrack = false;
            this.simpleLabelItem4.AppearanceItemCaption.Options.UseTextOptions = true;
            this.simpleLabelItem4.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.simpleLabelItem4.Location = new System.Drawing.Point(252, 20);
            this.simpleLabelItem4.Name = "simpleLabelItem4";
            this.simpleLabelItem4.Size = new System.Drawing.Size(126, 17);
            this.simpleLabelItem4.Text = "Proveedor";
            this.simpleLabelItem4.TextSize = new System.Drawing.Size(122, 13);
            // 
            // simpleLabelItem5
            // 
            this.simpleLabelItem5.AllowHotTrack = false;
            this.simpleLabelItem5.Location = new System.Drawing.Point(0, 37);
            this.simpleLabelItem5.Name = "simpleLabelItem5";
            this.simpleLabelItem5.Size = new System.Drawing.Size(126, 24);
            this.simpleLabelItem5.Text = "Tarjeta";
            this.simpleLabelItem5.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.simpleLabelItem5.TextSize = new System.Drawing.Size(50, 20);
            // 
            // layoutControlItem44
            // 
            this.layoutControlItem44.Control = this.spPctBPOTarjeta;
            this.layoutControlItem44.Location = new System.Drawing.Point(126, 37);
            this.layoutControlItem44.Name = "layoutControlItem44";
            this.layoutControlItem44.Size = new System.Drawing.Size(126, 24);
            this.layoutControlItem44.Text = " ";
            this.layoutControlItem44.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem44.TextSize = new System.Drawing.Size(3, 13);
            this.layoutControlItem44.TextToControlDistance = 5;
            // 
            // layoutControlItem45
            // 
            this.layoutControlItem45.Control = this.spPctProTarjeta;
            this.layoutControlItem45.Location = new System.Drawing.Point(252, 37);
            this.layoutControlItem45.Name = "layoutControlItem45";
            this.layoutControlItem45.Size = new System.Drawing.Size(126, 24);
            this.layoutControlItem45.Text = " ";
            this.layoutControlItem45.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem45.TextSize = new System.Drawing.Size(3, 13);
            this.layoutControlItem45.TextToControlDistance = 5;
            // 
            // emptySpaceItem13
            // 
            this.emptySpaceItem13.AllowHotTrack = false;
            this.emptySpaceItem13.Location = new System.Drawing.Point(388, 0);
            this.emptySpaceItem13.Name = "emptySpaceItem13";
            this.emptySpaceItem13.Size = new System.Drawing.Size(378, 20);
            this.emptySpaceItem13.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem46
            // 
            this.layoutControlItem46.Control = this.spPctBPOCucas;
            this.layoutControlItem46.Location = new System.Drawing.Point(126, 61);
            this.layoutControlItem46.Name = "layoutControlItem46";
            this.layoutControlItem46.Size = new System.Drawing.Size(126, 24);
            this.layoutControlItem46.Text = " ";
            this.layoutControlItem46.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem46.TextSize = new System.Drawing.Size(3, 13);
            this.layoutControlItem46.TextToControlDistance = 5;
            // 
            // layoutControlItem47
            // 
            this.layoutControlItem47.Control = this.spPctProCucas;
            this.layoutControlItem47.Location = new System.Drawing.Point(252, 61);
            this.layoutControlItem47.Name = "layoutControlItem47";
            this.layoutControlItem47.Size = new System.Drawing.Size(126, 24);
            this.layoutControlItem47.Text = " ";
            this.layoutControlItem47.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem47.TextSize = new System.Drawing.Size(3, 13);
            this.layoutControlItem47.TextToControlDistance = 5;
            // 
            // layoutControlItem48
            // 
            this.layoutControlItem48.Control = this.spPctBPOEfectivo;
            this.layoutControlItem48.Location = new System.Drawing.Point(126, 85);
            this.layoutControlItem48.Name = "layoutControlItem48";
            this.layoutControlItem48.Size = new System.Drawing.Size(126, 24);
            this.layoutControlItem48.Text = " ";
            this.layoutControlItem48.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem48.TextSize = new System.Drawing.Size(3, 13);
            this.layoutControlItem48.TextToControlDistance = 5;
            // 
            // layoutControlItem49
            // 
            this.layoutControlItem49.Control = this.spPctProEfectivo;
            this.layoutControlItem49.Location = new System.Drawing.Point(252, 85);
            this.layoutControlItem49.Name = "layoutControlItem49";
            this.layoutControlItem49.Size = new System.Drawing.Size(126, 24);
            this.layoutControlItem49.Text = " ";
            this.layoutControlItem49.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem49.TextSize = new System.Drawing.Size(3, 13);
            this.layoutControlItem49.TextToControlDistance = 5;
            // 
            // layoutControlItem50
            // 
            this.layoutControlItem50.Control = this.spPctBPOSeguros;
            this.layoutControlItem50.Location = new System.Drawing.Point(126, 109);
            this.layoutControlItem50.Name = "layoutControlItem50";
            this.layoutControlItem50.Size = new System.Drawing.Size(126, 24);
            this.layoutControlItem50.Text = " ";
            this.layoutControlItem50.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem50.TextSize = new System.Drawing.Size(3, 13);
            this.layoutControlItem50.TextToControlDistance = 5;
            // 
            // layoutControlItem51
            // 
            this.layoutControlItem51.Control = this.spPctProSeguros;
            this.layoutControlItem51.Location = new System.Drawing.Point(252, 109);
            this.layoutControlItem51.Name = "layoutControlItem51";
            this.layoutControlItem51.Size = new System.Drawing.Size(126, 24);
            this.layoutControlItem51.Text = " ";
            this.layoutControlItem51.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem51.TextSize = new System.Drawing.Size(3, 13);
            this.layoutControlItem51.TextToControlDistance = 5;
            // 
            // layoutControlItem52
            // 
            this.layoutControlItem52.Control = this.spPctBPOProveedor;
            this.layoutControlItem52.Location = new System.Drawing.Point(126, 133);
            this.layoutControlItem52.Name = "layoutControlItem52";
            this.layoutControlItem52.Size = new System.Drawing.Size(126, 24);
            this.layoutControlItem52.Text = " ";
            this.layoutControlItem52.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem52.TextSize = new System.Drawing.Size(3, 13);
            this.layoutControlItem52.TextToControlDistance = 5;
            // 
            // layoutControlItem53
            // 
            this.layoutControlItem53.Control = this.spPctProProveedor;
            this.layoutControlItem53.Location = new System.Drawing.Point(252, 133);
            this.layoutControlItem53.Name = "layoutControlItem53";
            this.layoutControlItem53.Size = new System.Drawing.Size(126, 24);
            this.layoutControlItem53.Text = " ";
            this.layoutControlItem53.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem53.TextSize = new System.Drawing.Size(3, 13);
            this.layoutControlItem53.TextToControlDistance = 5;
            // 
            // simpleLabelItem6
            // 
            this.simpleLabelItem6.AllowHotTrack = false;
            this.simpleLabelItem6.Location = new System.Drawing.Point(0, 61);
            this.simpleLabelItem6.Name = "simpleLabelItem6";
            this.simpleLabelItem6.Size = new System.Drawing.Size(126, 24);
            this.simpleLabelItem6.Text = "Cucas";
            this.simpleLabelItem6.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.simpleLabelItem6.TextSize = new System.Drawing.Size(50, 20);
            // 
            // simpleLabelItem7
            // 
            this.simpleLabelItem7.AllowHotTrack = false;
            this.simpleLabelItem7.Location = new System.Drawing.Point(0, 85);
            this.simpleLabelItem7.Name = "simpleLabelItem7";
            this.simpleLabelItem7.Size = new System.Drawing.Size(126, 24);
            this.simpleLabelItem7.Text = "Efectivos";
            this.simpleLabelItem7.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.simpleLabelItem7.TextSize = new System.Drawing.Size(50, 20);
            // 
            // simpleLabelItem8
            // 
            this.simpleLabelItem8.AllowHotTrack = false;
            this.simpleLabelItem8.Location = new System.Drawing.Point(0, 109);
            this.simpleLabelItem8.Name = "simpleLabelItem8";
            this.simpleLabelItem8.Size = new System.Drawing.Size(126, 24);
            this.simpleLabelItem8.Text = "Seguros";
            this.simpleLabelItem8.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.simpleLabelItem8.TextSize = new System.Drawing.Size(50, 20);
            // 
            // simpleLabelItem9
            // 
            this.simpleLabelItem9.AllowHotTrack = false;
            this.simpleLabelItem9.Location = new System.Drawing.Point(0, 133);
            this.simpleLabelItem9.Name = "simpleLabelItem9";
            this.simpleLabelItem9.Size = new System.Drawing.Size(126, 24);
            this.simpleLabelItem9.Text = "Proveedores";
            this.simpleLabelItem9.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.simpleLabelItem9.TextSize = new System.Drawing.Size(50, 20);
            // 
            // emptySpaceItem19
            // 
            this.emptySpaceItem19.AllowHotTrack = false;
            this.emptySpaceItem19.Location = new System.Drawing.Point(0, 157);
            this.emptySpaceItem19.Name = "emptySpaceItem19";
            this.emptySpaceItem19.Size = new System.Drawing.Size(126, 13);
            this.emptySpaceItem19.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem20
            // 
            this.emptySpaceItem20.AllowHotTrack = false;
            this.emptySpaceItem20.Location = new System.Drawing.Point(126, 157);
            this.emptySpaceItem20.Name = "emptySpaceItem20";
            this.emptySpaceItem20.Size = new System.Drawing.Size(126, 13);
            this.emptySpaceItem20.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem21
            // 
            this.emptySpaceItem21.AllowHotTrack = false;
            this.emptySpaceItem21.Location = new System.Drawing.Point(252, 157);
            this.emptySpaceItem21.Name = "emptySpaceItem21";
            this.emptySpaceItem21.Size = new System.Drawing.Size(126, 13);
            this.emptySpaceItem21.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.CustomizationFormText = "Domicilio Fiscal";
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForCalle,
            this.ItemForNoExterior,
            this.ItemForNoInterior,
            this.ItemForColonia,
            this.ItemForIdEstado,
            this.ItemForNombreDelegacionMunicipio,
            this.ItemForNombrePoblacionCiudad,
            this.ItemForIdPais,
            this.layoutControlItem1,
            this.ItemForCodigoPostal,
            this.emptySpaceItem7,
            this.ItemForRegimenFiscalSAT});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(876, 170);
            this.layoutControlGroup2.Text = "Domicilio Fiscal";
            // 
            // ItemForCalle
            // 
            this.ItemForCalle.Control = this.txtCalle;
            this.ItemForCalle.CustomizationFormText = "Calle";
            this.ItemForCalle.Location = new System.Drawing.Point(0, 0);
            this.ItemForCalle.Name = "ItemForCalle";
            this.ItemForCalle.Size = new System.Drawing.Size(876, 24);
            this.ItemForCalle.Text = "Calle";
            this.ItemForCalle.TextSize = new System.Drawing.Size(122, 13);
            // 
            // ItemForNoExterior
            // 
            this.ItemForNoExterior.Control = this.txtNoExterior;
            this.ItemForNoExterior.CustomizationFormText = "No Exterior";
            this.ItemForNoExterior.Location = new System.Drawing.Point(0, 24);
            this.ItemForNoExterior.Name = "ItemForNoExterior";
            this.ItemForNoExterior.Size = new System.Drawing.Size(179, 24);
            this.ItemForNoExterior.Text = "No. Exterior";
            this.ItemForNoExterior.TextSize = new System.Drawing.Size(122, 13);
            // 
            // ItemForNoInterior
            // 
            this.ItemForNoInterior.Control = this.txtNoInterior;
            this.ItemForNoInterior.CustomizationFormText = "No Interior";
            this.ItemForNoInterior.Location = new System.Drawing.Point(179, 24);
            this.ItemForNoInterior.Name = "ItemForNoInterior";
            this.ItemForNoInterior.Size = new System.Drawing.Size(179, 24);
            this.ItemForNoInterior.Text = "No. Interior";
            this.ItemForNoInterior.TextSize = new System.Drawing.Size(122, 13);
            // 
            // ItemForColonia
            // 
            this.ItemForColonia.Control = this.txtColonia;
            this.ItemForColonia.CustomizationFormText = "Colonia";
            this.ItemForColonia.Location = new System.Drawing.Point(0, 48);
            this.ItemForColonia.Name = "ItemForColonia";
            this.ItemForColonia.Size = new System.Drawing.Size(876, 24);
            this.ItemForColonia.Text = "Colonia";
            this.ItemForColonia.TextSize = new System.Drawing.Size(122, 13);
            // 
            // ItemForIdEstado
            // 
            this.ItemForIdEstado.Control = this.cboIdEstado;
            this.ItemForIdEstado.CustomizationFormText = "Id Estado";
            this.ItemForIdEstado.Location = new System.Drawing.Point(179, 72);
            this.ItemForIdEstado.Name = "ItemForIdEstado";
            this.ItemForIdEstado.Size = new System.Drawing.Size(179, 24);
            this.ItemForIdEstado.Text = "Estado";
            this.ItemForIdEstado.TextSize = new System.Drawing.Size(122, 13);
            // 
            // ItemForNombreDelegacionMunicipio
            // 
            this.ItemForNombreDelegacionMunicipio.Control = this.txtNombreDelegacionMunicipio;
            this.ItemForNombreDelegacionMunicipio.CustomizationFormText = "Nombre Delegacion Municipio";
            this.ItemForNombreDelegacionMunicipio.Location = new System.Drawing.Point(0, 96);
            this.ItemForNombreDelegacionMunicipio.Name = "ItemForNombreDelegacionMunicipio";
            this.ItemForNombreDelegacionMunicipio.Size = new System.Drawing.Size(876, 24);
            this.ItemForNombreDelegacionMunicipio.Text = "Delegación/Municipio";
            this.ItemForNombreDelegacionMunicipio.TextSize = new System.Drawing.Size(122, 13);
            // 
            // ItemForNombrePoblacionCiudad
            // 
            this.ItemForNombrePoblacionCiudad.Control = this.txtNombrePoblacionCiudad;
            this.ItemForNombrePoblacionCiudad.CustomizationFormText = "Nombre Poblacion Ciudad";
            this.ItemForNombrePoblacionCiudad.Location = new System.Drawing.Point(0, 120);
            this.ItemForNombrePoblacionCiudad.Name = "ItemForNombrePoblacionCiudad";
            this.ItemForNombrePoblacionCiudad.Size = new System.Drawing.Size(876, 24);
            this.ItemForNombrePoblacionCiudad.Text = "Población/Ciudad";
            this.ItemForNombrePoblacionCiudad.TextSize = new System.Drawing.Size(122, 13);
            // 
            // ItemForIdPais
            // 
            this.ItemForIdPais.Control = this.cboIdPais;
            this.ItemForIdPais.CustomizationFormText = "Id Pais";
            this.ItemForIdPais.Location = new System.Drawing.Point(358, 72);
            this.ItemForIdPais.Name = "ItemForIdPais";
            this.ItemForIdPais.Size = new System.Drawing.Size(518, 24);
            this.ItemForIdPais.Text = "País";
            this.ItemForIdPais.TextSize = new System.Drawing.Size(122, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnAsignarDomicilioFiscal2DomicilioOperacion;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(661, 144);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(215, 26);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(215, 26);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(215, 26);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // ItemForCodigoPostal
            // 
            this.ItemForCodigoPostal.Control = this.txtCodigoPostal;
            this.ItemForCodigoPostal.CustomizationFormText = "Codigo Postal";
            this.ItemForCodigoPostal.Location = new System.Drawing.Point(0, 72);
            this.ItemForCodigoPostal.Name = "ItemForCodigoPostal";
            this.ItemForCodigoPostal.Size = new System.Drawing.Size(179, 24);
            this.ItemForCodigoPostal.Text = "Código Postal";
            this.ItemForCodigoPostal.TextSize = new System.Drawing.Size(122, 13);
            // 
            // emptySpaceItem7
            // 
            this.emptySpaceItem7.AllowHotTrack = false;
            this.emptySpaceItem7.Location = new System.Drawing.Point(358, 24);
            this.emptySpaceItem7.Name = "emptySpaceItem7";
            this.emptySpaceItem7.Size = new System.Drawing.Size(518, 24);
            this.emptySpaceItem7.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ItemForRegimenFiscalSAT
            // 
            this.ItemForRegimenFiscalSAT.Control = this.cboIdRegimenFiscalSAT;
            this.ItemForRegimenFiscalSAT.CustomizationFormText = "Regimen Fiscal SAT";
            this.ItemForRegimenFiscalSAT.Location = new System.Drawing.Point(0, 144);
            this.ItemForRegimenFiscalSAT.Name = "ItemForRegimenFiscalSAT";
            this.ItemForRegimenFiscalSAT.Size = new System.Drawing.Size(661, 26);
            this.ItemForRegimenFiscalSAT.Text = "Regimen Fiscal SAT";
            this.ItemForRegimenFiscalSAT.TextSize = new System.Drawing.Size(122, 13);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.CustomizationFormText = "Domicilio Operación";
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForCalleOperacion,
            this.ItemForNoExteriorOperacion,
            this.ItemForColoniaOperacion,
            this.ItemForIdEstadoOperacion,
            this.ItemForNombreDelegacionMunicipioOperacion,
            this.ItemForNombrePoblacionCiudadOperacion,
            this.ItemForNoInteriorOperacion,
            this.ItemForCodigoPostalOperacion,
            this.ItemForIdPaisOperacion,
            this.emptySpaceItem14,
            this.emptySpaceItem15});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(876, 170);
            this.layoutControlGroup3.Text = "Domicilio Operación";
            // 
            // ItemForCalleOperacion
            // 
            this.ItemForCalleOperacion.Control = this.txtCalleOperacion;
            this.ItemForCalleOperacion.CustomizationFormText = "Calle Operacion";
            this.ItemForCalleOperacion.Location = new System.Drawing.Point(0, 0);
            this.ItemForCalleOperacion.Name = "ItemForCalleOperacion";
            this.ItemForCalleOperacion.Size = new System.Drawing.Size(876, 24);
            this.ItemForCalleOperacion.Text = "Calle";
            this.ItemForCalleOperacion.TextSize = new System.Drawing.Size(122, 13);
            // 
            // ItemForNoExteriorOperacion
            // 
            this.ItemForNoExteriorOperacion.Control = this.txtNoExteriorOperacion;
            this.ItemForNoExteriorOperacion.CustomizationFormText = "No Exterior Operacion";
            this.ItemForNoExteriorOperacion.Location = new System.Drawing.Point(0, 24);
            this.ItemForNoExteriorOperacion.Name = "ItemForNoExteriorOperacion";
            this.ItemForNoExteriorOperacion.Size = new System.Drawing.Size(179, 24);
            this.ItemForNoExteriorOperacion.Text = "No. Exterior";
            this.ItemForNoExteriorOperacion.TextSize = new System.Drawing.Size(122, 13);
            // 
            // ItemForColoniaOperacion
            // 
            this.ItemForColoniaOperacion.Control = this.txtColoniaOperacion;
            this.ItemForColoniaOperacion.CustomizationFormText = "Colonia Operacion";
            this.ItemForColoniaOperacion.Location = new System.Drawing.Point(0, 48);
            this.ItemForColoniaOperacion.Name = "ItemForColoniaOperacion";
            this.ItemForColoniaOperacion.Size = new System.Drawing.Size(876, 24);
            this.ItemForColoniaOperacion.Text = "Colonia";
            this.ItemForColoniaOperacion.TextSize = new System.Drawing.Size(122, 13);
            // 
            // ItemForIdEstadoOperacion
            // 
            this.ItemForIdEstadoOperacion.Control = this.cboIdEstadoOperacion;
            this.ItemForIdEstadoOperacion.CustomizationFormText = "Id Estado Operacion";
            this.ItemForIdEstadoOperacion.Location = new System.Drawing.Point(167, 72);
            this.ItemForIdEstadoOperacion.Name = "ItemForIdEstadoOperacion";
            this.ItemForIdEstadoOperacion.Size = new System.Drawing.Size(179, 24);
            this.ItemForIdEstadoOperacion.Text = "Estado";
            this.ItemForIdEstadoOperacion.TextSize = new System.Drawing.Size(122, 13);
            // 
            // ItemForNombreDelegacionMunicipioOperacion
            // 
            this.ItemForNombreDelegacionMunicipioOperacion.Control = this.txtNombreDelegacionMunicipioOperacion;
            this.ItemForNombreDelegacionMunicipioOperacion.CustomizationFormText = "Nombre Delegacion Municipio Operacion";
            this.ItemForNombreDelegacionMunicipioOperacion.Location = new System.Drawing.Point(0, 96);
            this.ItemForNombreDelegacionMunicipioOperacion.Name = "ItemForNombreDelegacionMunicipioOperacion";
            this.ItemForNombreDelegacionMunicipioOperacion.Size = new System.Drawing.Size(876, 24);
            this.ItemForNombreDelegacionMunicipioOperacion.Text = "Delegación/Municipio";
            this.ItemForNombreDelegacionMunicipioOperacion.TextSize = new System.Drawing.Size(122, 13);
            // 
            // ItemForNombrePoblacionCiudadOperacion
            // 
            this.ItemForNombrePoblacionCiudadOperacion.Control = this.txtNombrePoblacionCiudadOperacion;
            this.ItemForNombrePoblacionCiudadOperacion.CustomizationFormText = "Nombre Poblacion Ciudad Operacion";
            this.ItemForNombrePoblacionCiudadOperacion.Location = new System.Drawing.Point(0, 120);
            this.ItemForNombrePoblacionCiudadOperacion.Name = "ItemForNombrePoblacionCiudadOperacion";
            this.ItemForNombrePoblacionCiudadOperacion.Size = new System.Drawing.Size(876, 24);
            this.ItemForNombrePoblacionCiudadOperacion.Text = "Población/Ciudad";
            this.ItemForNombrePoblacionCiudadOperacion.TextSize = new System.Drawing.Size(122, 13);
            // 
            // ItemForNoInteriorOperacion
            // 
            this.ItemForNoInteriorOperacion.Control = this.txtNoInteriorOperacion;
            this.ItemForNoInteriorOperacion.CustomizationFormText = "No Interior Operacion";
            this.ItemForNoInteriorOperacion.Location = new System.Drawing.Point(179, 24);
            this.ItemForNoInteriorOperacion.Name = "ItemForNoInteriorOperacion";
            this.ItemForNoInteriorOperacion.Size = new System.Drawing.Size(179, 24);
            this.ItemForNoInteriorOperacion.Text = "No. Interior";
            this.ItemForNoInteriorOperacion.TextSize = new System.Drawing.Size(122, 13);
            // 
            // ItemForCodigoPostalOperacion
            // 
            this.ItemForCodigoPostalOperacion.Control = this.txtCodigoPostalOperacion;
            this.ItemForCodigoPostalOperacion.CustomizationFormText = "Codigo Postal Operacion";
            this.ItemForCodigoPostalOperacion.Location = new System.Drawing.Point(0, 72);
            this.ItemForCodigoPostalOperacion.MinSize = new System.Drawing.Size(167, 24);
            this.ItemForCodigoPostalOperacion.Name = "ItemForCodigoPostalOperacion";
            this.ItemForCodigoPostalOperacion.Size = new System.Drawing.Size(167, 24);
            this.ItemForCodigoPostalOperacion.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.ItemForCodigoPostalOperacion.Text = "Código Postal";
            this.ItemForCodigoPostalOperacion.TextSize = new System.Drawing.Size(122, 13);
            // 
            // ItemForIdPaisOperacion
            // 
            this.ItemForIdPaisOperacion.Control = this.cboIdPaisOperacion;
            this.ItemForIdPaisOperacion.CustomizationFormText = "Id Pais Operacion";
            this.ItemForIdPaisOperacion.Location = new System.Drawing.Point(346, 72);
            this.ItemForIdPaisOperacion.Name = "ItemForIdPaisOperacion";
            this.ItemForIdPaisOperacion.Size = new System.Drawing.Size(530, 24);
            this.ItemForIdPaisOperacion.Text = "País";
            this.ItemForIdPaisOperacion.TextSize = new System.Drawing.Size(122, 13);
            // 
            // emptySpaceItem14
            // 
            this.emptySpaceItem14.AllowHotTrack = false;
            this.emptySpaceItem14.Location = new System.Drawing.Point(0, 144);
            this.emptySpaceItem14.Name = "emptySpaceItem14";
            this.emptySpaceItem14.Size = new System.Drawing.Size(876, 26);
            this.emptySpaceItem14.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem15
            // 
            this.emptySpaceItem15.AllowHotTrack = false;
            this.emptySpaceItem15.Location = new System.Drawing.Point(358, 24);
            this.emptySpaceItem15.Name = "emptySpaceItem15";
            this.emptySpaceItem15.Size = new System.Drawing.Size(518, 24);
            this.emptySpaceItem15.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.CustomizationFormText = "Contacto";
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForContacto,
            this.ItemForPaginaWeb,
            this.ItemForCorreoElectronico,
            this.ItemForContacto1,
            this.ItemForTelefono2,
            this.ItemForTelefono1,
            this.layoutControlItem24,
            this.layoutControlItem3});
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Size = new System.Drawing.Size(876, 170);
            this.layoutControlGroup4.Text = "Contacto";
            // 
            // ItemForContacto
            // 
            this.ItemForContacto.Control = this.txtContacto;
            this.ItemForContacto.CustomizationFormText = "Contancto";
            this.ItemForContacto.Location = new System.Drawing.Point(0, 24);
            this.ItemForContacto.Name = "ItemForContacto";
            this.ItemForContacto.Size = new System.Drawing.Size(876, 24);
            this.ItemForContacto.Text = "Contacto";
            this.ItemForContacto.TextSize = new System.Drawing.Size(122, 13);
            // 
            // ItemForPaginaWeb
            // 
            this.ItemForPaginaWeb.Control = this.txtPaginaWeb;
            this.ItemForPaginaWeb.CustomizationFormText = "Pagina Web";
            this.ItemForPaginaWeb.Location = new System.Drawing.Point(0, 96);
            this.ItemForPaginaWeb.Name = "ItemForPaginaWeb";
            this.ItemForPaginaWeb.Size = new System.Drawing.Size(876, 24);
            this.ItemForPaginaWeb.Text = "Página Web";
            this.ItemForPaginaWeb.TextSize = new System.Drawing.Size(122, 13);
            // 
            // ItemForCorreoElectronico
            // 
            this.ItemForCorreoElectronico.Control = this.txtCorreoElectronico;
            this.ItemForCorreoElectronico.CustomizationFormText = "Correo Electronico";
            this.ItemForCorreoElectronico.Location = new System.Drawing.Point(0, 72);
            this.ItemForCorreoElectronico.Name = "ItemForCorreoElectronico";
            this.ItemForCorreoElectronico.Size = new System.Drawing.Size(876, 24);
            this.ItemForCorreoElectronico.Text = "Correo Electrónico";
            this.ItemForCorreoElectronico.TextSize = new System.Drawing.Size(122, 13);
            // 
            // ItemForContacto1
            // 
            this.ItemForContacto1.Control = this.txtRepresentanteLegal;
            this.ItemForContacto1.CustomizationFormText = "Representante Legal";
            this.ItemForContacto1.Location = new System.Drawing.Point(0, 0);
            this.ItemForContacto1.Name = "ItemForContacto1";
            this.ItemForContacto1.Size = new System.Drawing.Size(876, 24);
            this.ItemForContacto1.Text = "Representante Legal";
            this.ItemForContacto1.TextSize = new System.Drawing.Size(122, 13);
            // 
            // ItemForTelefono2
            // 
            this.ItemForTelefono2.Control = this.txtTelefono2;
            this.ItemForTelefono2.CustomizationFormText = "Telefono2";
            this.ItemForTelefono2.Location = new System.Drawing.Point(179, 48);
            this.ItemForTelefono2.Name = "ItemForTelefono2";
            this.ItemForTelefono2.Size = new System.Drawing.Size(697, 24);
            this.ItemForTelefono2.Text = "Teléfono 2";
            this.ItemForTelefono2.TextSize = new System.Drawing.Size(122, 13);
            // 
            // ItemForTelefono1
            // 
            this.ItemForTelefono1.Control = this.txtTelefono1;
            this.ItemForTelefono1.CustomizationFormText = "Telefono1";
            this.ItemForTelefono1.Location = new System.Drawing.Point(0, 48);
            this.ItemForTelefono1.Name = "ItemForTelefono1";
            this.ItemForTelefono1.Size = new System.Drawing.Size(179, 24);
            this.ItemForTelefono1.Text = "Teléfono 1";
            this.ItemForTelefono1.TextSize = new System.Drawing.Size(122, 13);
            // 
            // layoutControlItem24
            // 
            this.layoutControlItem24.Control = this.cbIdOperador;
            this.layoutControlItem24.CustomizationFormText = "Operador";
            this.layoutControlItem24.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem24.Name = "layoutControlItem24";
            this.layoutControlItem24.Size = new System.Drawing.Size(876, 24);
            this.layoutControlItem24.Text = "Operador";
            this.layoutControlItem24.TextSize = new System.Drawing.Size(122, 13);
            this.layoutControlItem24.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.cbPlazaCliente;
            this.layoutControlItem3.CustomizationFormText = "Plaza Operacion Cliente";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 144);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(876, 26);
            this.layoutControlItem3.Text = "Plaza Operacion Cliente";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(122, 13);
            // 
            // layoutControlGroup7
            // 
            this.layoutControlGroup7.CustomizationFormText = "Otros";
            this.layoutControlGroup7.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForIdTipoClienteProveedor,
            this.layoutControlItem11,
            this.ItemForPeriodicidad,
            this.ItemClaseRiesgo,
            this.ItemForPctComisionBPO,
            this.layoutControlItem26,
            this.lyGrupo,
            this.layoutControlItem23,
            this.emptySpaceItem17,
            this.emptySpaceItem18,
            this.ItemForTieneSucursales,
            this.ItemForConfidencial,
            this.layoutControlItem8,
            this.layoutControlItem27,
            this.layoutControlItem20,
            this.emptySpaceItem16,
            this.layoutControlItem10,
            this.layoutControlItem19,
            this.layoutControlItem21,
            this.layoutControlItem13,
            this.layoutControlItem22});
            this.layoutControlGroup7.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup7.Name = "layoutControlGroup7";
            this.layoutControlGroup7.Size = new System.Drawing.Size(876, 170);
            this.layoutControlGroup7.Text = "Otros";
            // 
            // ItemForIdTipoClienteProveedor
            // 
            this.ItemForIdTipoClienteProveedor.Control = this.cboIdTipoClienteProveedor;
            this.ItemForIdTipoClienteProveedor.CustomizationFormText = "Id Tipo Cliente Proveedor";
            this.ItemForIdTipoClienteProveedor.Location = new System.Drawing.Point(0, 0);
            this.ItemForIdTipoClienteProveedor.Name = "ItemForIdTipoClienteProveedor";
            this.ItemForIdTipoClienteProveedor.Size = new System.Drawing.Size(169, 24);
            this.ItemForIdTipoClienteProveedor.Text = "Tipo Cliente/Proveedor";
            this.ItemForIdTipoClienteProveedor.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.ItemForIdTipoClienteProveedor.TextSize = new System.Drawing.Size(115, 13);
            this.ItemForIdTipoClienteProveedor.TextToControlDistance = 0;
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.btnCrearProducto;
            this.layoutControlItem11.Location = new System.Drawing.Point(123, 34);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(28, 26);
            this.layoutControlItem11.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem11.TextVisible = false;
            // 
            // ItemForPeriodicidad
            // 
            this.ItemForPeriodicidad.Control = this.chkbPeriodicidad;
            this.ItemForPeriodicidad.CustomizationFormText = "Periodicidad";
            this.ItemForPeriodicidad.Location = new System.Drawing.Point(151, 34);
            this.ItemForPeriodicidad.Name = "ItemForPeriodicidad";
            this.ItemForPeriodicidad.Size = new System.Drawing.Size(135, 26);
            this.ItemForPeriodicidad.Text = "Periodicidad";
            this.ItemForPeriodicidad.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.ItemForPeriodicidad.TextSize = new System.Drawing.Size(60, 13);
            this.ItemForPeriodicidad.TextToControlDistance = 5;
            // 
            // ItemClaseRiesgo
            // 
            this.ItemClaseRiesgo.Control = this.cbIdClaseRiesgo;
            this.ItemClaseRiesgo.CustomizationFormText = "IdClaseRiesgo";
            this.ItemClaseRiesgo.Location = new System.Drawing.Point(169, 0);
            this.ItemClaseRiesgo.Name = "ItemClaseRiesgo";
            this.ItemClaseRiesgo.Size = new System.Drawing.Size(139, 24);
            this.ItemClaseRiesgo.Text = "Clase de Riesgo";
            this.ItemClaseRiesgo.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.ItemClaseRiesgo.TextSize = new System.Drawing.Size(80, 13);
            this.ItemClaseRiesgo.TextToControlDistance = 5;
            // 
            // ItemForPctComisionBPO
            // 
            this.ItemForPctComisionBPO.Control = this.spPctComisionBPO;
            this.ItemForPctComisionBPO.CustomizationFormText = "Pct Comision";
            this.ItemForPctComisionBPO.Location = new System.Drawing.Point(0, 70);
            this.ItemForPctComisionBPO.Name = "ItemForPctComisionBPO";
            this.ItemForPctComisionBPO.Size = new System.Drawing.Size(123, 24);
            this.ItemForPctComisionBPO.Text = "Pct Comisión";
            this.ItemForPctComisionBPO.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.ItemForPctComisionBPO.TextSize = new System.Drawing.Size(60, 13);
            this.ItemForPctComisionBPO.TextToControlDistance = 5;
            // 
            // layoutControlItem26
            // 
            this.layoutControlItem26.Control = this.spISN;
            this.layoutControlItem26.CustomizationFormText = "ISN";
            this.layoutControlItem26.Location = new System.Drawing.Point(308, 0);
            this.layoutControlItem26.Name = "layoutControlItem26";
            this.layoutControlItem26.Size = new System.Drawing.Size(89, 24);
            this.layoutControlItem26.Text = "ISN";
            this.layoutControlItem26.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem26.TextSize = new System.Drawing.Size(30, 13);
            this.layoutControlItem26.TextToControlDistance = 5;
            // 
            // lyGrupo
            // 
            this.lyGrupo.Control = this.txtObservaciones;
            this.lyGrupo.Location = new System.Drawing.Point(0, 104);
            this.lyGrupo.Name = "lyGrupo";
            this.lyGrupo.Size = new System.Drawing.Size(876, 66);
            this.lyGrupo.Text = "Observaciones";
            this.lyGrupo.TextLocation = DevExpress.Utils.Locations.Left;
            this.lyGrupo.TextSize = new System.Drawing.Size(122, 13);
            // 
            // layoutControlItem23
            // 
            this.layoutControlItem23.Control = this.spPctAsimilados;
            this.layoutControlItem23.CustomizationFormText = "Pct Comision BPO";
            this.layoutControlItem23.Location = new System.Drawing.Point(123, 70);
            this.layoutControlItem23.Name = "layoutControlItem23";
            this.layoutControlItem23.Size = new System.Drawing.Size(179, 24);
            this.layoutControlItem23.Text = "Pct Asimilado/Honorario";
            this.layoutControlItem23.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem23.TextSize = new System.Drawing.Size(120, 13);
            this.layoutControlItem23.TextToControlDistance = 5;
            // 
            // emptySpaceItem17
            // 
            this.emptySpaceItem17.AllowHotTrack = false;
            this.emptySpaceItem17.Location = new System.Drawing.Point(0, 60);
            this.emptySpaceItem17.Name = "emptySpaceItem17";
            this.emptySpaceItem17.Size = new System.Drawing.Size(876, 10);
            this.emptySpaceItem17.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem18
            // 
            this.emptySpaceItem18.AllowHotTrack = false;
            this.emptySpaceItem18.Location = new System.Drawing.Point(0, 94);
            this.emptySpaceItem18.Name = "emptySpaceItem18";
            this.emptySpaceItem18.Size = new System.Drawing.Size(876, 10);
            this.emptySpaceItem18.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ItemForTieneSucursales
            // 
            this.ItemForTieneSucursales.Control = this.chkTieneSucursales;
            this.ItemForTieneSucursales.CustomizationFormText = "Tiene Sucursales";
            this.ItemForTieneSucursales.Location = new System.Drawing.Point(397, 0);
            this.ItemForTieneSucursales.Name = "ItemForTieneSucursales";
            this.ItemForTieneSucursales.Size = new System.Drawing.Size(106, 24);
            this.ItemForTieneSucursales.Text = "Tiene Sucursales";
            this.ItemForTieneSucursales.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForTieneSucursales.TextVisible = false;
            // 
            // ItemForConfidencial
            // 
            this.ItemForConfidencial.Control = this.chkConfidencial;
            this.ItemForConfidencial.CustomizationFormText = "Confidencial";
            this.ItemForConfidencial.Location = new System.Drawing.Point(503, 0);
            this.ItemForConfidencial.Name = "ItemForConfidencial";
            this.ItemForConfidencial.Size = new System.Drawing.Size(84, 24);
            this.ItemForConfidencial.Text = "Confidencial";
            this.ItemForConfidencial.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForConfidencial.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.chkSeguro;
            this.layoutControlItem8.Location = new System.Drawing.Point(587, 0);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(60, 24);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem27
            // 
            this.layoutControlItem27.Control = this.chkDecreto;
            this.layoutControlItem27.Location = new System.Drawing.Point(647, 0);
            this.layoutControlItem27.Name = "layoutControlItem27";
            this.layoutControlItem27.Size = new System.Drawing.Size(60, 24);
            this.layoutControlItem27.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem27.TextVisible = false;
            // 
            // layoutControlItem20
            // 
            this.layoutControlItem20.Control = this.chkSindicato;
            this.layoutControlItem20.Location = new System.Drawing.Point(707, 0);
            this.layoutControlItem20.Name = "layoutControlItem20";
            this.layoutControlItem20.Size = new System.Drawing.Size(169, 24);
            this.layoutControlItem20.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem20.TextVisible = false;
            // 
            // emptySpaceItem16
            // 
            this.emptySpaceItem16.AllowHotTrack = false;
            this.emptySpaceItem16.Location = new System.Drawing.Point(0, 24);
            this.emptySpaceItem16.Name = "emptySpaceItem16";
            this.emptySpaceItem16.Size = new System.Drawing.Size(876, 10);
            this.emptySpaceItem16.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.cbProductos;
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 34);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(123, 26);
            this.layoutControlItem10.Text = "Productos";
            this.layoutControlItem10.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem10.TextSize = new System.Drawing.Size(50, 20);
            this.layoutControlItem10.TextToControlDistance = 5;
            // 
            // layoutControlItem19
            // 
            this.layoutControlItem19.Control = this.chkbComision;
            this.layoutControlItem19.Location = new System.Drawing.Point(286, 34);
            this.layoutControlItem19.Name = "layoutControlItem19";
            this.layoutControlItem19.Size = new System.Drawing.Size(159, 26);
            this.layoutControlItem19.Text = "Conceptos Comisión";
            this.layoutControlItem19.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem19.TextSize = new System.Drawing.Size(100, 13);
            this.layoutControlItem19.TextToControlDistance = 5;
            // 
            // layoutControlItem21
            // 
            this.layoutControlItem21.Control = this.chkbFronting;
            this.layoutControlItem21.Location = new System.Drawing.Point(445, 34);
            this.layoutControlItem21.Name = "layoutControlItem21";
            this.layoutControlItem21.Size = new System.Drawing.Size(431, 26);
            this.layoutControlItem21.Text = "Fronting";
            this.layoutControlItem21.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem21.TextSize = new System.Drawing.Size(40, 13);
            this.layoutControlItem21.TextToControlDistance = 5;
            // 
            // layoutControlItem13
            // 
            this.layoutControlItem13.Control = this.spSaldoFavor;
            this.layoutControlItem13.Location = new System.Drawing.Point(302, 70);
            this.layoutControlItem13.Name = "layoutControlItem13";
            this.layoutControlItem13.Size = new System.Drawing.Size(156, 24);
            this.layoutControlItem13.Text = "Saldo a Favor";
            this.layoutControlItem13.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem13.TextSize = new System.Drawing.Size(66, 13);
            this.layoutControlItem13.TextToControlDistance = 5;
            // 
            // layoutControlItem22
            // 
            this.layoutControlItem22.Control = this.spFinanciamiento;
            this.layoutControlItem22.Location = new System.Drawing.Point(458, 70);
            this.layoutControlItem22.Name = "layoutControlItem22";
            this.layoutControlItem22.Size = new System.Drawing.Size(418, 24);
            this.layoutControlItem22.Text = "Financiamiento";
            this.layoutControlItem22.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem22.TextSize = new System.Drawing.Size(71, 13);
            this.layoutControlItem22.TextToControlDistance = 5;
            // 
            // layoutControlGroup8
            // 
            this.layoutControlGroup8.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem28,
            this.emptySpaceItem2,
            this.layoutControlItem30,
            this.emptySpaceItem8,
            this.layoutControlItem32,
            this.layoutControlItem34,
            this.layoutControlItem35,
            this.layoutControlItem37,
            this.layoutControlItem42,
            this.emptySpaceItem6,
            this.layoutControlItem31,
            this.layoutControlItem36,
            this.layoutControlItem29,
            this.layoutControlItem43,
            this.simpleSeparator1});
            this.layoutControlGroup8.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup8.Name = "layoutControlGroup8";
            this.layoutControlGroup8.Size = new System.Drawing.Size(876, 170);
            this.layoutControlGroup8.Text = "Promotor(es)";
            // 
            // layoutControlItem28
            // 
            this.layoutControlItem28.Control = this.cbPromotor;
            this.layoutControlItem28.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem28.Name = "layoutControlItem28";
            this.layoutControlItem28.Size = new System.Drawing.Size(319, 24);
            this.layoutControlItem28.Text = "Promotor";
            this.layoutControlItem28.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem28.TextSize = new System.Drawing.Size(44, 13);
            this.layoutControlItem28.TextToControlDistance = 5;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 110);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(876, 60);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem30
            // 
            this.layoutControlItem30.Control = this.txtObservacionesPromo;
            this.layoutControlItem30.Location = new System.Drawing.Point(319, 0);
            this.layoutControlItem30.Name = "layoutControlItem30";
            this.layoutControlItem30.Size = new System.Drawing.Size(557, 24);
            this.layoutControlItem30.Text = "Observaciones";
            this.layoutControlItem30.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem30.TextSize = new System.Drawing.Size(71, 13);
            this.layoutControlItem30.TextToControlDistance = 5;
            // 
            // emptySpaceItem8
            // 
            this.emptySpaceItem8.AllowHotTrack = false;
            this.emptySpaceItem8.Location = new System.Drawing.Point(0, 52);
            this.emptySpaceItem8.Name = "emptySpaceItem8";
            this.emptySpaceItem8.Size = new System.Drawing.Size(876, 32);
            this.emptySpaceItem8.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem32
            // 
            this.layoutControlItem32.Control = this.cbRelIdPromotor;
            this.layoutControlItem32.Location = new System.Drawing.Point(0, 84);
            this.layoutControlItem32.Name = "layoutControlItem32";
            this.layoutControlItem32.Size = new System.Drawing.Size(454, 26);
            this.layoutControlItem32.Text = "Promotores";
            this.layoutControlItem32.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem32.TextSize = new System.Drawing.Size(55, 13);
            this.layoutControlItem32.TextToControlDistance = 5;
            // 
            // layoutControlItem34
            // 
            this.layoutControlItem34.Control = this.btnEliminarProm;
            this.layoutControlItem34.Location = new System.Drawing.Point(610, 84);
            this.layoutControlItem34.Name = "layoutControlItem34";
            this.layoutControlItem34.Size = new System.Drawing.Size(266, 26);
            this.layoutControlItem34.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem34.TextVisible = false;
            // 
            // layoutControlItem35
            // 
            this.layoutControlItem35.Control = this.btnModificPromotor;
            this.layoutControlItem35.Location = new System.Drawing.Point(454, 84);
            this.layoutControlItem35.Name = "layoutControlItem35";
            this.layoutControlItem35.Size = new System.Drawing.Size(81, 26);
            this.layoutControlItem35.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem35.TextVisible = false;
            // 
            // layoutControlItem37
            // 
            this.layoutControlItem37.Control = this.btnCancelarPro;
            this.layoutControlItem37.Location = new System.Drawing.Point(535, 84);
            this.layoutControlItem37.Name = "layoutControlItem37";
            this.layoutControlItem37.Size = new System.Drawing.Size(75, 26);
            this.layoutControlItem37.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem37.TextVisible = false;
            // 
            // layoutControlItem42
            // 
            this.layoutControlItem42.Control = this.spIVA;
            this.layoutControlItem42.Location = new System.Drawing.Point(110, 24);
            this.layoutControlItem42.Name = "layoutControlItem42";
            this.layoutControlItem42.Size = new System.Drawing.Size(88, 26);
            this.layoutControlItem42.Text = "IVA";
            this.layoutControlItem42.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem42.TextSize = new System.Drawing.Size(17, 13);
            this.layoutControlItem42.TextToControlDistance = 5;
            // 
            // emptySpaceItem6
            // 
            this.emptySpaceItem6.AllowHotTrack = false;
            this.emptySpaceItem6.Location = new System.Drawing.Point(318, 24);
            this.emptySpaceItem6.Name = "emptySpaceItem6";
            this.emptySpaceItem6.Size = new System.Drawing.Size(250, 26);
            this.emptySpaceItem6.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem31
            // 
            this.layoutControlItem31.Control = this.btnAgregarPromo;
            this.layoutControlItem31.Location = new System.Drawing.Point(568, 24);
            this.layoutControlItem31.Name = "layoutControlItem31";
            this.layoutControlItem31.Size = new System.Drawing.Size(71, 26);
            this.layoutControlItem31.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem31.TextVisible = false;
            // 
            // layoutControlItem36
            // 
            this.layoutControlItem36.Control = this.btnGuardarPromo;
            this.layoutControlItem36.Location = new System.Drawing.Point(639, 24);
            this.layoutControlItem36.Name = "layoutControlItem36";
            this.layoutControlItem36.Size = new System.Drawing.Size(237, 26);
            this.layoutControlItem36.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem36.TextVisible = false;
            // 
            // layoutControlItem29
            // 
            this.layoutControlItem29.Control = this.spComision;
            this.layoutControlItem29.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem29.Name = "layoutControlItem29";
            this.layoutControlItem29.Size = new System.Drawing.Size(110, 26);
            this.layoutControlItem29.Tag = "Comisión";
            this.layoutControlItem29.Text = "Comisión";
            this.layoutControlItem29.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem29.TextSize = new System.Drawing.Size(42, 13);
            this.layoutControlItem29.TextToControlDistance = 5;
            // 
            // layoutControlItem43
            // 
            this.layoutControlItem43.Control = this.spUtilidadReal;
            this.layoutControlItem43.Location = new System.Drawing.Point(198, 24);
            this.layoutControlItem43.Name = "layoutControlItem43";
            this.layoutControlItem43.Size = new System.Drawing.Size(120, 26);
            this.layoutControlItem43.Text = "Utilidad Real";
            this.layoutControlItem43.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem43.TextSize = new System.Drawing.Size(59, 13);
            this.layoutControlItem43.TextToControlDistance = 5;
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.AllowHotTrack = false;
            this.simpleSeparator1.Location = new System.Drawing.Point(0, 50);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(876, 2);
            // 
            // layoutControlGroup6
            // 
            this.layoutControlGroup6.CustomizationFormText = "Información General";
            this.layoutControlGroup6.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForIdCliente,
            this.emptySpaceItem5,
            this.ItemForRazonSocial,
            this.ItemForNombreComercial,
            this.emptySpaceItem9,
            this.ItemForIdActividadComercial,
            this.ItemForRFC,
            this.emptySpaceItem10,
            this.layoutControlItem2,
            this.layoutControlItem14,
            this.layoutControlItem12,
            this.RegimenCapitalItem,
            this.layoutControlItem40,
            this.layoutControlItem41});
            this.layoutControlGroup6.Location = new System.Drawing.Point(0, 41);
            this.layoutControlGroup6.Name = "layoutControlGroup6";
            this.layoutControlGroup6.Size = new System.Drawing.Size(924, 261);
            this.layoutControlGroup6.Text = "Información General";
            // 
            // ItemForIdCliente
            // 
            this.ItemForIdCliente.Control = this.txtIdCliente;
            this.ItemForIdCliente.CustomizationFormText = "Id Cliente";
            this.ItemForIdCliente.Location = new System.Drawing.Point(0, 0);
            this.ItemForIdCliente.MaxSize = new System.Drawing.Size(0, 25);
            this.ItemForIdCliente.MinSize = new System.Drawing.Size(50, 25);
            this.ItemForIdCliente.Name = "ItemForIdCliente";
            this.ItemForIdCliente.Size = new System.Drawing.Size(162, 25);
            this.ItemForIdCliente.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.ItemForIdCliente.Text = "No. Cliente";
            this.ItemForIdCliente.TextSize = new System.Drawing.Size(122, 13);
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.CustomizationFormText = "emptySpaceItem5";
            this.emptySpaceItem5.Location = new System.Drawing.Point(162, 0);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(738, 25);
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ItemForRazonSocial
            // 
            this.ItemForRazonSocial.Control = this.txtRazonSocial;
            this.ItemForRazonSocial.CustomizationFormText = "Razon Social";
            this.ItemForRazonSocial.Location = new System.Drawing.Point(0, 25);
            this.ItemForRazonSocial.Name = "ItemForRazonSocial";
            this.ItemForRazonSocial.Size = new System.Drawing.Size(423, 24);
            this.ItemForRazonSocial.Text = "Razón Social";
            this.ItemForRazonSocial.TextSize = new System.Drawing.Size(122, 13);
            // 
            // ItemForNombreComercial
            // 
            this.ItemForNombreComercial.Control = this.txtNombreComercial;
            this.ItemForNombreComercial.CustomizationFormText = "Nombre Comercial";
            this.ItemForNombreComercial.Location = new System.Drawing.Point(0, 49);
            this.ItemForNombreComercial.Name = "ItemForNombreComercial";
            this.ItemForNombreComercial.Size = new System.Drawing.Size(900, 24);
            this.ItemForNombreComercial.Text = "Nombre Comercial";
            this.ItemForNombreComercial.TextSize = new System.Drawing.Size(122, 13);
            // 
            // emptySpaceItem9
            // 
            this.emptySpaceItem9.AllowHotTrack = false;
            this.emptySpaceItem9.Location = new System.Drawing.Point(0, 175);
            this.emptySpaceItem9.MaxSize = new System.Drawing.Size(900, 44);
            this.emptySpaceItem9.MinSize = new System.Drawing.Size(900, 44);
            this.emptySpaceItem9.Name = "emptySpaceItem9";
            this.emptySpaceItem9.Size = new System.Drawing.Size(900, 44);
            this.emptySpaceItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem9.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ItemForIdActividadComercial
            // 
            this.ItemForIdActividadComercial.Control = this.cboIdActividadComercial;
            this.ItemForIdActividadComercial.CustomizationFormText = "Id Actividad Comercial";
            this.ItemForIdActividadComercial.Location = new System.Drawing.Point(0, 97);
            this.ItemForIdActividadComercial.Name = "ItemForIdActividadComercial";
            this.ItemForIdActividadComercial.Size = new System.Drawing.Size(564, 26);
            this.ItemForIdActividadComercial.Text = "Actividad Comercial";
            this.ItemForIdActividadComercial.TextSize = new System.Drawing.Size(122, 13);
            // 
            // ItemForRFC
            // 
            this.ItemForRFC.Control = this.txtRFC;
            this.ItemForRFC.CustomizationFormText = "RFC";
            this.ItemForRFC.Location = new System.Drawing.Point(0, 73);
            this.ItemForRFC.Name = "ItemForRFC";
            this.ItemForRFC.Size = new System.Drawing.Size(564, 24);
            this.ItemForRFC.Text = "RFC";
            this.ItemForRFC.TextSize = new System.Drawing.Size(122, 13);
            // 
            // emptySpaceItem10
            // 
            this.emptySpaceItem10.AllowHotTrack = false;
            this.emptySpaceItem10.Location = new System.Drawing.Point(564, 73);
            this.emptySpaceItem10.Name = "emptySpaceItem10";
            this.emptySpaceItem10.Size = new System.Drawing.Size(336, 24);
            this.emptySpaceItem10.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnABC_ActividadComercial;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(564, 97);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(30, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(336, 26);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem14
            // 
            this.layoutControlItem14.Control = this.btnGrupo;
            this.layoutControlItem14.Location = new System.Drawing.Point(564, 123);
            this.layoutControlItem14.Name = "layoutControlItem14";
            this.layoutControlItem14.Size = new System.Drawing.Size(336, 26);
            this.layoutControlItem14.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem14.TextVisible = false;
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.cbGrupo;
            this.layoutControlItem12.Location = new System.Drawing.Point(0, 123);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(564, 26);
            this.layoutControlItem12.Text = "Grupo";
            this.layoutControlItem12.TextSize = new System.Drawing.Size(122, 13);
            // 
            // RegimenCapitalItem
            // 
            this.RegimenCapitalItem.Control = this.RegimenCapitaltextEdit;
            this.RegimenCapitalItem.Location = new System.Drawing.Point(423, 25);
            this.RegimenCapitalItem.Name = "RegimenCapitalItem";
            this.RegimenCapitalItem.Size = new System.Drawing.Size(477, 24);
            this.RegimenCapitalItem.Text = "Regimen Capital";
            this.RegimenCapitalItem.TextSize = new System.Drawing.Size(122, 13);
            // 
            // layoutControlItem40
            // 
            this.layoutControlItem40.Control = this.cbCategoriaCliente;
            this.layoutControlItem40.Location = new System.Drawing.Point(0, 149);
            this.layoutControlItem40.Name = "layoutControlItem40";
            this.layoutControlItem40.Size = new System.Drawing.Size(564, 26);
            this.layoutControlItem40.Text = "Categoria";
            this.layoutControlItem40.TextSize = new System.Drawing.Size(122, 13);
            // 
            // layoutControlItem41
            // 
            this.layoutControlItem41.Control = this.btnAgregarCategoria;
            this.layoutControlItem41.Location = new System.Drawing.Point(564, 149);
            this.layoutControlItem41.Name = "layoutControlItem41";
            this.layoutControlItem41.Size = new System.Drawing.Size(336, 26);
            this.layoutControlItem41.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem41.TextVisible = false;
            // 
            // ItemForIdEstatus
            // 
            this.ItemForIdEstatus.Control = this.cboIdEstatus;
            this.ItemForIdEstatus.CustomizationFormText = "Id Estatus";
            this.ItemForIdEstatus.Location = new System.Drawing.Point(28, 560);
            this.ItemForIdEstatus.Name = "ItemForIdEstatus";
            this.ItemForIdEstatus.Size = new System.Drawing.Size(179, 26);
            this.ItemForIdEstatus.Text = "Estatus";
            this.ItemForIdEstatus.TextSize = new System.Drawing.Size(122, 13);
            // 
            // ItemForFechaBaja
            // 
            this.ItemForFechaBaja.Control = this.calFechaBaja;
            this.ItemForFechaBaja.CustomizationFormText = "Fecha Baja";
            this.ItemForFechaBaja.Location = new System.Drawing.Point(207, 560);
            this.ItemForFechaBaja.MinSize = new System.Drawing.Size(179, 24);
            this.ItemForFechaBaja.Name = "ItemForFechaBaja";
            this.ItemForFechaBaja.Size = new System.Drawing.Size(179, 26);
            this.ItemForFechaBaja.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.ItemForFechaBaja.Text = "Fecha Baja";
            this.ItemForFechaBaja.TextSize = new System.Drawing.Size(122, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 560);
            this.emptySpaceItem1.MaxSize = new System.Drawing.Size(28, 26);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(28, 26);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(28, 26);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem11
            // 
            this.emptySpaceItem11.AllowHotTrack = false;
            this.emptySpaceItem11.Location = new System.Drawing.Point(0, 24);
            this.emptySpaceItem11.Name = "emptySpaceItem11";
            this.emptySpaceItem11.Size = new System.Drawing.Size(924, 17);
            this.emptySpaceItem11.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.cboIdClienteProveedor;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(924, 24);
            this.layoutControlItem4.Text = "Buscar Cliente/Proveedor";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(122, 13);
            // 
            // emptySpaceItem12
            // 
            this.emptySpaceItem12.AllowHotTrack = false;
            this.emptySpaceItem12.Location = new System.Drawing.Point(924, 0);
            this.emptySpaceItem12.Name = "emptySpaceItem12";
            this.emptySpaceItem12.Size = new System.Drawing.Size(125, 41);
            this.emptySpaceItem12.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnNuevo;
            this.layoutControlItem5.Location = new System.Drawing.Point(924, 41);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(125, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnCancelar;
            this.layoutControlItem6.Location = new System.Drawing.Point(924, 93);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(125, 26);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btnGuardar;
            this.layoutControlItem7.Location = new System.Drawing.Point(924, 119);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(125, 26);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.btnEditar;
            this.layoutControlItem9.Location = new System.Drawing.Point(924, 67);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(125, 26);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(386, 560);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(538, 26);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(924, 197);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(125, 389);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem25
            // 
            this.layoutControlItem25.Control = this.btnExportar;
            this.layoutControlItem25.Location = new System.Drawing.Point(924, 145);
            this.layoutControlItem25.Name = "layoutControlItem25";
            this.layoutControlItem25.Size = new System.Drawing.Size(125, 26);
            this.layoutControlItem25.Text = "Exportar Control";
            this.layoutControlItem25.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem25.TextVisible = false;
            // 
            // layoutControlItem39
            // 
            this.layoutControlItem39.Control = this.btnPromotores;
            this.layoutControlItem39.Location = new System.Drawing.Point(924, 171);
            this.layoutControlItem39.Name = "layoutControlItem39";
            this.layoutControlItem39.Size = new System.Drawing.Size(125, 26);
            this.layoutControlItem39.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem39.TextVisible = false;
            // 
            // stpFactSelPromotorClienteBindingSource
            // 
            this.stpFactSelPromotorClienteBindingSource.DataMember = "stpFactSelPromotorCliente";
            this.stpFactSelPromotorClienteBindingSource.DataSource = this.dbSAICBPOFactura;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.dbSAIC_Catalogos;
            // 
            // stpSelEstadoTableAdapter
            // 
            this.stpSelEstadoTableAdapter.ClearBeforeFill = true;
            // 
            // actividadComercialTableAdapter
            // 
            this.actividadComercialTableAdapter.ClearBeforeFill = true;
            // 
            // tipoClienteProveedorTableAdapter
            // 
            this.tipoClienteProveedorTableAdapter.ClearBeforeFill = true;
            // 
            // stpSelPaisTableAdapter
            // 
            this.stpSelPaisTableAdapter.ClearBeforeFill = true;
            // 
            // vwCatEstatusClienteTableAdapter
            // 
            this.vwCatEstatusClienteTableAdapter.ClearBeforeFill = true;
            // 
            // spinEdit1
            // 
            this.spinEdit1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEdit1.Location = new System.Drawing.Point(650, 381);
            this.spinEdit1.Name = "spinEdit1";
            this.spinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEdit1.Properties.DisplayFormat.FormatString = "N2";
            this.spinEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinEdit1.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spinEdit1.Size = new System.Drawing.Size(50, 20);
            this.spinEdit1.TabIndex = 38;
            this.spinEdit1.Tag = "Pct Comisión BPO";
            // 
            // ItemForPctComisionBPO1
            // 
            this.ItemForPctComisionBPO1.Control = this.spinEdit1;
            this.ItemForPctComisionBPO1.CustomizationFormText = "Pct Comision BPO";
            this.ItemForPctComisionBPO1.Location = new System.Drawing.Point(488, 50);
            this.ItemForPctComisionBPO1.Name = "ItemForPctComisionBPO1";
            this.ItemForPctComisionBPO1.Size = new System.Drawing.Size(179, 24);
            this.ItemForPctComisionBPO1.Text = "Pct Comisión BPO";
            this.ItemForPctComisionBPO1.TextSize = new System.Drawing.Size(122, 13);
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(162, 405);
            this.comboBoxEdit1.MenuManager = this.barManager1;
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Size = new System.Drawing.Size(428, 20);
            this.comboBoxEdit1.TabIndex = 54;
            // 
            // layoutControlItem15
            // 
            this.layoutControlItem15.Control = this.comboBoxEdit1;
            this.layoutControlItem15.Location = new System.Drawing.Point(0, 74);
            this.layoutControlItem15.Name = "layoutControlItem15";
            this.layoutControlItem15.Size = new System.Drawing.Size(557, 24);
            this.layoutControlItem15.TextSize = new System.Drawing.Size(122, 13);
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(341, 405);
            this.checkEdit1.MenuManager = this.barManager1;
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "checkEdit1";
            this.checkEdit1.Size = new System.Drawing.Size(73, 19);
            this.checkEdit1.TabIndex = 55;
            // 
            // layoutControlItem16
            // 
            this.layoutControlItem16.Control = this.checkEdit1;
            this.layoutControlItem16.Location = new System.Drawing.Point(179, 74);
            this.layoutControlItem16.Name = "layoutControlItem16";
            this.layoutControlItem16.Size = new System.Drawing.Size(202, 24);
            this.layoutControlItem16.TextSize = new System.Drawing.Size(122, 13);
            // 
            // checkEdit2
            // 
            this.checkEdit2.Location = new System.Drawing.Point(543, 405);
            this.checkEdit2.MenuManager = this.barManager1;
            this.checkEdit2.Name = "checkEdit2";
            this.checkEdit2.Properties.Caption = "checkEdit2";
            this.checkEdit2.Size = new System.Drawing.Size(73, 19);
            this.checkEdit2.TabIndex = 56;
            // 
            // layoutControlItem17
            // 
            this.layoutControlItem17.Control = this.checkEdit2;
            this.layoutControlItem17.Location = new System.Drawing.Point(381, 74);
            this.layoutControlItem17.Name = "layoutControlItem17";
            this.layoutControlItem17.Size = new System.Drawing.Size(202, 24);
            this.layoutControlItem17.TextSize = new System.Drawing.Size(122, 13);
            // 
            // checkEdit3
            // 
            this.checkEdit3.Location = new System.Drawing.Point(745, 405);
            this.checkEdit3.MenuManager = this.barManager1;
            this.checkEdit3.Name = "checkEdit3";
            this.checkEdit3.Properties.Caption = "checkEdit3";
            this.checkEdit3.Size = new System.Drawing.Size(73, 19);
            this.checkEdit3.TabIndex = 57;
            // 
            // layoutControlItem18
            // 
            this.layoutControlItem18.Control = this.checkEdit3;
            this.layoutControlItem18.Location = new System.Drawing.Point(583, 74);
            this.layoutControlItem18.Name = "layoutControlItem18";
            this.layoutControlItem18.Size = new System.Drawing.Size(202, 24);
            this.layoutControlItem18.TextSize = new System.Drawing.Size(122, 13);
            // 
            // emptySpaceItem23
            // 
            this.emptySpaceItem23.AllowHotTrack = false;
            this.emptySpaceItem23.Location = new System.Drawing.Point(0, 74);
            this.emptySpaceItem23.Name = "emptySpaceItem23";
            this.emptySpaceItem23.Size = new System.Drawing.Size(438, 10);
            this.emptySpaceItem23.TextSize = new System.Drawing.Size(0, 0);
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // stpFactSelControlClienteTableAdapter
            // 
            this.stpFactSelControlClienteTableAdapter.ClearBeforeFill = true;
            // 
            // stpFactSelTipoPeriodoNominaClienteTableAdapter
            // 
            this.stpFactSelTipoPeriodoNominaClienteTableAdapter.ClearBeforeFill = true;
            // 
            // stpFactSelPromotorClienteTableAdapter
            // 
            this.stpFactSelPromotorClienteTableAdapter.ClearBeforeFill = true;
            // 
            // stpFactSelClaseRiesgoTableAdapter
            // 
            this.stpFactSelClaseRiesgoTableAdapter.ClearBeforeFill = true;
            // 
            // vwcatFrontingTableAdapter
            // 
            this.vwcatFrontingTableAdapter.ClearBeforeFill = true;
            // 
            // stpFactSelComisionClienteTableAdapter
            // 
            this.stpFactSelComisionClienteTableAdapter.ClearBeforeFill = true;
            // 
            // stpSelOperadorTableAdapter
            // 
            this.stpSelOperadorTableAdapter.ClearBeforeFill = true;
            // 
            // stpFactSelMatrizClienteActivosTableAdapter
            // 
            this.stpFactSelMatrizClienteActivosTableAdapter.ClearBeforeFill = true;
            // 
            // stpFactSelClientePrPePrCoFoTableAdapter1
            // 
            this.stpFactSelClientePrPePrCoFoTableAdapter1.ClearBeforeFill = true;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // splashSMCargando
            // 
            this.splashSMCargando.ClosingDelay = 500;
            // 
            // stpFactSelDerechosAccesoOperadorFacturacionTableAdapter1
            // 
            this.stpFactSelDerechosAccesoOperadorFacturacionTableAdapter1.ClearBeforeFill = true;
            // 
            // dbSAICBPOFactura1
            // 
            this.dbSAICBPOFactura1.DataSetName = "dbSAICBPOFactura";
            this.dbSAICBPOFactura1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stpSelPlazaClienteTableAdapter1
            // 
            this.stpSelPlazaClienteTableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelRegimenFiscalSATTableAdapter1
            // 
            this.stpSelRegimenFiscalSATTableAdapter1.ClearBeforeFill = true;
            // 
            // simpleSeparator2
            // 
            this.simpleSeparator2.AllowHotTrack = false;
            this.simpleSeparator2.Location = new System.Drawing.Point(0, 149);
            this.simpleSeparator2.Name = "simpleSeparator2";
            this.simpleSeparator2.Size = new System.Drawing.Size(897, 2);
            // 
            // simpleSeparator3
            // 
            this.simpleSeparator3.AllowHotTrack = false;
            this.simpleSeparator3.Location = new System.Drawing.Point(0, 24);
            this.simpleSeparator3.Name = "simpleSeparator3";
            this.simpleSeparator3.Size = new System.Drawing.Size(921, 2);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(832, 374);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(76, 22);
            this.simpleButton2.TabIndex = 68;
            this.simpleButton2.Text = "simpleButton2";
            // 
            // layoutControlItem33
            // 
            this.layoutControlItem33.Control = this.simpleButton2;
            this.layoutControlItem33.Location = new System.Drawing.Point(796, 26);
            this.layoutControlItem33.Name = "layoutControlItem33";
            this.layoutControlItem33.Size = new System.Drawing.Size(80, 26);
            this.layoutControlItem33.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem33.TextVisible = false;
            // 
            // stpSelPromotoresActivosTableAdapter
            // 
            this.stpSelPromotoresActivosTableAdapter.ClearBeforeFill = true;
            // 
            // stpSelClientePromotoresTableAdapter
            // 
            this.stpSelClientePromotoresTableAdapter.ClearBeforeFill = true;
            // 
            // buttonEdit1
            // 
            this.buttonEdit1.Location = new System.Drawing.Point(161, 453);
            this.buttonEdit1.MenuManager = this.barManager1;
            this.buttonEdit1.Name = "buttonEdit1";
            this.buttonEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.buttonEdit1.Size = new System.Drawing.Size(747, 20);
            this.buttonEdit1.TabIndex = 73;
            // 
            // layoutControlItem38
            // 
            this.layoutControlItem38.Control = this.buttonEdit1;
            this.layoutControlItem38.Location = new System.Drawing.Point(0, 105);
            this.layoutControlItem38.Name = "layoutControlItem38";
            this.layoutControlItem38.Size = new System.Drawing.Size(876, 24);
            this.layoutControlItem38.TextSize = new System.Drawing.Size(122, 13);
            // 
            // stpSelCategoriaClienteTableAdapter
            // 
            this.stpSelCategoriaClienteTableAdapter.ClearBeforeFill = true;
            // 
            // stpSelClientePromotoresPorcetajeClienteTableAdapter1
            // 
            this.stpSelClientePromotoresPorcetajeClienteTableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelClientePCTProductoTableAdapter1
            // 
            this.stpSelClientePCTProductoTableAdapter1.ClearBeforeFill = true;
            // 
            // emptySpaceItem22
            // 
            this.emptySpaceItem22.AllowHotTrack = false;
            this.emptySpaceItem22.Location = new System.Drawing.Point(388, 20);
            this.emptySpaceItem22.Name = "emptySpaceItem22";
            this.emptySpaceItem22.Size = new System.Drawing.Size(126, 17);
            this.emptySpaceItem22.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem24
            // 
            this.emptySpaceItem24.AllowHotTrack = false;
            this.emptySpaceItem24.Location = new System.Drawing.Point(378, 0);
            this.emptySpaceItem24.Name = "emptySpaceItem24";
            this.emptySpaceItem24.Size = new System.Drawing.Size(10, 170);
            this.emptySpaceItem24.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem25
            // 
            this.emptySpaceItem25.AllowHotTrack = false;
            this.emptySpaceItem25.Location = new System.Drawing.Point(388, 85);
            this.emptySpaceItem25.Name = "emptySpaceItem25";
            this.emptySpaceItem25.Size = new System.Drawing.Size(378, 85);
            this.emptySpaceItem25.TextSize = new System.Drawing.Size(0, 0);
            // 
            // simpleLabelItem10
            // 
            this.simpleLabelItem10.AllowHotTrack = false;
            this.simpleLabelItem10.AppearanceItemCaption.Options.UseTextOptions = true;
            this.simpleLabelItem10.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.simpleLabelItem10.Location = new System.Drawing.Point(514, 20);
            this.simpleLabelItem10.Name = "simpleLabelItem10";
            this.simpleLabelItem10.Size = new System.Drawing.Size(126, 17);
            this.simpleLabelItem10.Text = "Casa";
            this.simpleLabelItem10.TextSize = new System.Drawing.Size(122, 13);
            // 
            // simpleLabelItem11
            // 
            this.simpleLabelItem11.AllowHotTrack = false;
            this.simpleLabelItem11.AppearanceItemCaption.Options.UseTextOptions = true;
            this.simpleLabelItem11.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.simpleLabelItem11.Location = new System.Drawing.Point(640, 20);
            this.simpleLabelItem11.Name = "simpleLabelItem11";
            this.simpleLabelItem11.Size = new System.Drawing.Size(126, 17);
            this.simpleLabelItem11.Text = "Proveedor";
            this.simpleLabelItem11.TextSize = new System.Drawing.Size(122, 13);
            // 
            // simpleLabelItem12
            // 
            this.simpleLabelItem12.AllowHotTrack = false;
            this.simpleLabelItem12.Location = new System.Drawing.Point(388, 37);
            this.simpleLabelItem12.Name = "simpleLabelItem12";
            this.simpleLabelItem12.Size = new System.Drawing.Size(126, 24);
            this.simpleLabelItem12.Text = "Gasto";
            this.simpleLabelItem12.TextSize = new System.Drawing.Size(122, 13);
            // 
            // spPctBPOGasto
            // 
            this.spPctBPOGasto.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spPctBPOGasto.Location = new System.Drawing.Point(558, 415);
            this.spPctBPOGasto.MenuManager = this.barManager1;
            this.spPctBPOGasto.Name = "spPctBPOGasto";
            this.spPctBPOGasto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spPctBPOGasto.Size = new System.Drawing.Size(114, 20);
            this.spPctBPOGasto.StyleController = this.dataLayoutControl1;
            this.spPctBPOGasto.TabIndex = 88;
            this.spPctBPOGasto.Tag = "Gasto Casa";
            // 
            // layoutControlItem54
            // 
            this.layoutControlItem54.Control = this.spPctBPOGasto;
            this.layoutControlItem54.Location = new System.Drawing.Point(514, 37);
            this.layoutControlItem54.Name = "layoutControlItem54";
            this.layoutControlItem54.Size = new System.Drawing.Size(126, 24);
            this.layoutControlItem54.Text = " ";
            this.layoutControlItem54.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem54.TextSize = new System.Drawing.Size(3, 13);
            this.layoutControlItem54.TextToControlDistance = 5;
            // 
            // spPctProGasto
            // 
            this.spPctProGasto.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spPctProGasto.Location = new System.Drawing.Point(684, 415);
            this.spPctProGasto.MenuManager = this.barManager1;
            this.spPctProGasto.Name = "spPctProGasto";
            this.spPctProGasto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spPctProGasto.Size = new System.Drawing.Size(114, 20);
            this.spPctProGasto.StyleController = this.dataLayoutControl1;
            this.spPctProGasto.TabIndex = 89;
            this.spPctProGasto.Tag = "Gasto Proveedor";
            // 
            // layoutControlItem55
            // 
            this.layoutControlItem55.Control = this.spPctProGasto;
            this.layoutControlItem55.Location = new System.Drawing.Point(640, 37);
            this.layoutControlItem55.Name = "layoutControlItem55";
            this.layoutControlItem55.Size = new System.Drawing.Size(126, 24);
            this.layoutControlItem55.Text = " ";
            this.layoutControlItem55.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem55.TextSize = new System.Drawing.Size(3, 13);
            this.layoutControlItem55.TextToControlDistance = 5;
            // 
            // simpleLabelItem13
            // 
            this.simpleLabelItem13.AllowHotTrack = false;
            this.simpleLabelItem13.Location = new System.Drawing.Point(388, 61);
            this.simpleLabelItem13.Name = "simpleLabelItem13";
            this.simpleLabelItem13.Size = new System.Drawing.Size(126, 24);
            this.simpleLabelItem13.Text = "Otro";
            this.simpleLabelItem13.TextSize = new System.Drawing.Size(122, 13);
            // 
            // spPctBPOOtro
            // 
            this.spPctBPOOtro.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spPctBPOOtro.Location = new System.Drawing.Point(558, 439);
            this.spPctBPOOtro.MenuManager = this.barManager1;
            this.spPctBPOOtro.Name = "spPctBPOOtro";
            this.spPctBPOOtro.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spPctBPOOtro.Size = new System.Drawing.Size(114, 20);
            this.spPctBPOOtro.StyleController = this.dataLayoutControl1;
            this.spPctBPOOtro.TabIndex = 90;
            this.spPctBPOOtro.Tag = "Otro Casa";
            // 
            // layoutControlItem56
            // 
            this.layoutControlItem56.Control = this.spPctBPOOtro;
            this.layoutControlItem56.Location = new System.Drawing.Point(514, 61);
            this.layoutControlItem56.Name = "layoutControlItem56";
            this.layoutControlItem56.Size = new System.Drawing.Size(126, 24);
            this.layoutControlItem56.Text = " ";
            this.layoutControlItem56.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem56.TextSize = new System.Drawing.Size(3, 13);
            this.layoutControlItem56.TextToControlDistance = 5;
            // 
            // spPctProOtro
            // 
            this.spPctProOtro.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spPctProOtro.Location = new System.Drawing.Point(684, 439);
            this.spPctProOtro.MenuManager = this.barManager1;
            this.spPctProOtro.Name = "spPctProOtro";
            this.spPctProOtro.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spPctProOtro.Size = new System.Drawing.Size(114, 20);
            this.spPctProOtro.StyleController = this.dataLayoutControl1;
            this.spPctProOtro.TabIndex = 91;
            this.spPctProOtro.Tag = "Otro Proveedor";
            // 
            // layoutControlItem57
            // 
            this.layoutControlItem57.Control = this.spPctProOtro;
            this.layoutControlItem57.Location = new System.Drawing.Point(640, 61);
            this.layoutControlItem57.Name = "layoutControlItem57";
            this.layoutControlItem57.Size = new System.Drawing.Size(126, 24);
            this.layoutControlItem57.Text = " ";
            this.layoutControlItem57.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem57.TextSize = new System.Drawing.Size(3, 13);
            this.layoutControlItem57.TextToControlDistance = 5;
            // 
            // emptySpaceItem26
            // 
            this.emptySpaceItem26.AllowHotTrack = false;
            this.emptySpaceItem26.Location = new System.Drawing.Point(766, 0);
            this.emptySpaceItem26.Name = "emptySpaceItem26";
            this.emptySpaceItem26.Size = new System.Drawing.Size(110, 170);
            this.emptySpaceItem26.TextSize = new System.Drawing.Size(0, 0);
            // 
            // frmxClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 637);
            this.ControlBox = false;
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmxClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Clientes/Proveedores";
            this.Load += new System.EventHandler(this.frmxClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbCategoriaCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelCategoriaClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSindicato.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservaciones.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboIdClienteProveedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelControlClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRazonSocial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreComercial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRFC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCalle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoExterior.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoInterior.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtColonia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoPostal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboIdPais.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelPaisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAIC_Catalogos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboIdEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelEstadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreDelegacionMunicipio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombrePoblacionCiudad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCalleOperacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoExteriorOperacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoInteriorOperacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtColoniaOperacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoPostalOperacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboIdPaisOperacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelPaisBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboIdEstadoOperacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelEstadoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreDelegacionMunicipioOperacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombrePoblacionCiudadOperacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContacto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCorreoElectronico.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPaginaWeb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboIdEstatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCatEstatusClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkConfidencial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkTieneSucursales.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spPctComisionBPO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calFechaBaja.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calFechaBaja.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioCreacionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioModificacionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboIdActividadComercial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadComercialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSeguro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRepresentanteLegal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spPctAsimilados.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spISN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDecreto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkbPeriodicidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelTipoPeriodoNominaClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkbFronting.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwcatFrontingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkbComision.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelComisionClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGrupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelMatrizClienteActivosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbIdOperador.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelOperadorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbProductos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbIdClaseRiesgo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelClaseRiesgoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboIdTipoClienteProveedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoClienteProveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboIdRegimenFiscalSAT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelRegimenFiscalSATBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPlazaCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelPlazaClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSaldoFavor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spFinanciamiento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spComision.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacionesPromo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRelIdPromotor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelClientePromotoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPromotor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelPromotoresActivosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICCatalogosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegimenCapitaltextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spIVA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spUtilidadReal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spPctBPOTarjeta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spPctProTarjeta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spPctBPOCucas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spPctProCucas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spPctBPOEfectivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spPctProEfectivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spPctBPOSeguros.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spPctProSeguros.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spPctBPOProveedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spPctProProveedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUsuarioCreacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUsuarioModificacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcgInformacionAdicional)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem44)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem45)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem46)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem47)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem48)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem49)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem51)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem52)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem53)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNoExterior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNoInterior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForColonia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNombreDelegacionMunicipio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNombrePoblacionCiudad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdPais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCodigoPostal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRegimenFiscalSAT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCalleOperacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNoExteriorOperacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForColoniaOperacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdEstadoOperacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNombreDelegacionMunicipioOperacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNombrePoblacionCiudadOperacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNoInteriorOperacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCodigoPostalOperacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdPaisOperacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForContacto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPaginaWeb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCorreoElectronico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForContacto1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTelefono2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTelefono1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdTipoClienteProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPeriodicidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemClaseRiesgo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPctComisionBPO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyGrupo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTieneSucursales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForConfidencial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem43)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRazonSocial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNombreComercial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdActividadComercial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRFC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegimenCapitalItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdEstatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFechaBaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelPromotorClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPctComisionBPO1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOFactura1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spPctBPOGasto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem54)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spPctProGasto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem55)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spPctBPOOtro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem56)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spPctProOtro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem57)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem26)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnSalir;
        private dbSAICBPOCatalogosDataSet dbSAICBPOCatalogosDataSet;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.TextEdit txtRazonSocial;
        private DevExpress.XtraEditors.TextEdit txtNombreComercial;
        private DevExpress.XtraEditors.TextEdit txtRFC;
        private DevExpress.XtraEditors.TextEdit txtCalle;
        private DevExpress.XtraEditors.TextEdit txtNoExterior;
        private DevExpress.XtraEditors.TextEdit txtNoInterior;
        private DevExpress.XtraEditors.TextEdit txtColonia;
        private DevExpress.XtraEditors.TextEdit txtCodigoPostal;
        private DevExpress.XtraEditors.LookUpEdit cboIdPais;
        private DevExpress.XtraEditors.LookUpEdit cboIdEstado;
        private DevExpress.XtraEditors.TextEdit txtNombreDelegacionMunicipio;
        private DevExpress.XtraEditors.TextEdit txtNombrePoblacionCiudad;
        private DevExpress.XtraEditors.TextEdit txtCalleOperacion;
        private DevExpress.XtraEditors.TextEdit txtNoExteriorOperacion;
        private DevExpress.XtraEditors.TextEdit txtNoInteriorOperacion;
        private DevExpress.XtraEditors.TextEdit txtColoniaOperacion;
        private DevExpress.XtraEditors.TextEdit txtCodigoPostalOperacion;
        private DevExpress.XtraEditors.LookUpEdit cboIdPaisOperacion;
        private DevExpress.XtraEditors.LookUpEdit cboIdEstadoOperacion;
        private DevExpress.XtraEditors.TextEdit txtNombreDelegacionMunicipioOperacion;
        private DevExpress.XtraEditors.TextEdit txtNombrePoblacionCiudadOperacion;
        private DevExpress.XtraEditors.TextEdit txtTelefono1;
        private DevExpress.XtraEditors.TextEdit txtTelefono2;
        private DevExpress.XtraEditors.TextEdit txtContacto;
        private DevExpress.XtraEditors.TextEdit txtCorreoElectronico;
        private DevExpress.XtraEditors.TextEdit txtPaginaWeb;
        private DevExpress.XtraEditors.LookUpEdit cboIdEstatus;
        private DevExpress.XtraEditors.CheckEdit chkConfidencial;
        private DevExpress.XtraEditors.CheckEdit chkTieneSucursales;
        private DevExpress.XtraEditors.SpinEdit spPctComisionBPO;
        private DevExpress.XtraEditors.DateEdit calFechaBaja;
        private DevExpress.XtraEditors.TextEdit UsuarioCreacionTextEdit;
        private DevExpress.XtraEditors.TextEdit UsuarioModificacionTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIdEstatus;
        private DevExpress.XtraLayout.LayoutControlItem ItemForFechaBaja;
        private DevExpress.XtraLayout.LayoutControlItem ItemForUsuarioCreacion;
        private DevExpress.XtraLayout.LayoutControlItem ItemForUsuarioModificacion;
        private DevExpress.XtraLayout.TabbedControlGroup tcgInformacionAdicional;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCalle;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNoExterior;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNoInterior;
        private DevExpress.XtraLayout.LayoutControlItem ItemForColonia;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIdEstado;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIdPais;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNombreDelegacionMunicipio;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNombrePoblacionCiudad;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCodigoPostal;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup5;
        private DevExpress.XtraEditors.SimpleButton btnAsignarDomicilioFiscal2DomicilioOperacion;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.SimpleButton btnABC_ActividadComercial;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private System.Windows.Forms.BindingSource stpSelEstadoBindingSource;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelEstadoTableAdapter stpSelEstadoTableAdapter;
        private System.Windows.Forms.BindingSource stpSelEstadoBindingSource1;
        private dbSAIC_Catalogos dbSAIC_Catalogos;
        private System.Windows.Forms.BindingSource actividadComercialBindingSource;
        private dbSAIC_CatalogosTableAdapters.ActividadComercialTableAdapter actividadComercialTableAdapter;
        private System.Windows.Forms.BindingSource tipoClienteProveedorBindingSource;
        private dbSAIC_CatalogosTableAdapters.TipoClienteProveedorTableAdapter tipoClienteProveedorTableAdapter;
        private DevExpress.XtraEditors.GridLookUpEdit cboIdClienteProveedor;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colRazonSocial;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreComercial;
        private DevExpress.XtraGrid.Columns.GridColumn colIdActividadComercial;
        private DevExpress.XtraGrid.Columns.GridColumn colRFC;
        private DevExpress.XtraGrid.Columns.GridColumn colCURP;
        private DevExpress.XtraGrid.Columns.GridColumn colCalle;
        private DevExpress.XtraGrid.Columns.GridColumn colNoExterior;
        private DevExpress.XtraGrid.Columns.GridColumn colNoInterior;
        private DevExpress.XtraGrid.Columns.GridColumn colColonia;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoPostal;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPais;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreDelegacionMunicipio;
        private DevExpress.XtraGrid.Columns.GridColumn colNombrePoblacionCiudad;
        private DevExpress.XtraGrid.Columns.GridColumn colCalleOperacion;
        private DevExpress.XtraGrid.Columns.GridColumn colNoExteriorOperacion;
        private DevExpress.XtraGrid.Columns.GridColumn colNoInteriorOperacion;
        private DevExpress.XtraGrid.Columns.GridColumn colColoniaOperacion;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoPostalOperacion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPaisOperacion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstadoOperacion;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreDelegacionMunicipioOperacion;
        private DevExpress.XtraGrid.Columns.GridColumn colNombrePoblacionCiudadOperacion;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefono1;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefono2;
        private DevExpress.XtraGrid.Columns.GridColumn colContacto;
        private DevExpress.XtraGrid.Columns.GridColumn colCorreoElectronico;
        private DevExpress.XtraGrid.Columns.GridColumn colPaginaWeb;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMatrizCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstatus;
        private DevExpress.XtraGrid.Columns.GridColumn colConfidencial;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoClienteProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colIdOperador;
        private DevExpress.XtraGrid.Columns.GridColumn colTieneSucursales;
        private DevExpress.XtraGrid.Columns.GridColumn colPctAsimilados;
        private DevExpress.XtraGrid.Columns.GridColumn colPctComisionBPO;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaBaja;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaModificacion;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioCreacion;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioModificacion;
        private DevExpress.XtraEditors.TextEdit txtIdCliente;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnNuevo;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem12;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.SimpleButton btnEditar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private System.Windows.Forms.BindingSource dbSAICCatalogosBindingSource;
        private System.Windows.Forms.BindingSource stpSelPaisBindingSource;
        private dbSAIC_CatalogosTableAdapters.stpSelPaisTableAdapter stpSelPaisTableAdapter;
        private System.Windows.Forms.BindingSource stpSelPaisBindingSource1;
        private DevExpress.XtraEditors.MemoEdit txtObservaciones;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem7;
        private DevExpress.XtraEditors.SimpleButton btnCrearProducto;
        private System.Windows.Forms.BindingSource vwCatEstatusClienteBindingSource;
        private dbSAIC_CatalogosTableAdapters.vwCatEstatusClienteTableAdapter vwCatEstatusClienteTableAdapter;
        private DevExpress.XtraEditors.GridLookUpEdit cboIdActividadComercial;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdActividadComercial1;
        private DevExpress.XtraGrid.Columns.GridColumn colDescActividadComercial;
        private DevExpress.XtraEditors.CheckEdit chkSeguro;
        private DevExpress.XtraGrid.Columns.GridColumn colSeguro;
        private DevExpress.XtraEditors.SimpleButton btnGrupo;
        private DevExpress.XtraEditors.SpinEdit spinEdit1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPctComisionBPO1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem15;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem16;
        private DevExpress.XtraEditors.CheckEdit checkEdit2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem17;
        private DevExpress.XtraEditors.CheckEdit checkEdit3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem18;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem23;
        private DevExpress.XtraEditors.TextEdit txtRepresentanteLegal;
        private DevExpress.XtraEditors.SpinEdit spPctAsimilados;
        private DevExpress.XtraEditors.SpinEdit spISN;
        private DevExpress.XtraEditors.CheckEdit chkDecreto;
        private DevExpress.XtraEditors.CheckEdit chkSindicato;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCalleOperacion;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNoExteriorOperacion;
        private DevExpress.XtraLayout.LayoutControlItem ItemForColoniaOperacion;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIdEstadoOperacion;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNombreDelegacionMunicipioOperacion;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNombrePoblacionCiudadOperacion;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNoInteriorOperacion;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCodigoPostalOperacion;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIdPaisOperacion;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem14;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem15;
        private Facturas.dbSAICBPOFactura dbSAICBPOFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colRepresentanteLegal;
        private DevExpress.XtraGrid.Columns.GridColumn colIdClaseRiesgo;
        private DevExpress.XtraGrid.Columns.GridColumn colISN;
        private DevExpress.XtraGrid.Columns.GridColumn colDecreto;
        private DevExpress.XtraGrid.Columns.GridColumn colSindicato;
        private DevExpress.XtraGrid.Columns.GridColumn colObservaciones;
        private DevExpress.XtraEditors.CheckedComboBoxEdit chkbPeriodicidad;
        private DevExpress.XtraEditors.CheckedComboBoxEdit chkbFronting;
        private DevExpress.XtraEditors.CheckedComboBoxEdit chkbComision;
        private DevExpress.XtraEditors.GridLookUpEdit cbGrupo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMatrizCliente0;
        private DevExpress.XtraGrid.Columns.GridColumn colRazonSocial0;
        private DevExpress.XtraEditors.GridLookUpEdit cbIdOperador;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private dbSAICBPODataSet dbSAICBPODataSet;
        private DevExpress.XtraGrid.Columns.GridColumn colIdOperador0;
        private DevExpress.XtraGrid.Columns.GridColumn colOperador;
        private DevExpress.XtraEditors.CheckedComboBoxEdit cbProductos;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private dbSAIC_CatalogosTableAdapters.ProductoTableAdapter productoTableAdapter;
        private DevExpress.XtraEditors.GridLookUpEdit cbIdClaseRiesgo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn COLIdClaseRiesgoIMSS;
        private DevExpress.XtraGrid.Columns.GridColumn COLDescClaseRiesgoIMSS;
        private DevExpress.XtraEditors.GridLookUpEdit cboIdTipoClienteProveedor;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colDescTipoClienteProveedor;
        private DevExpress.XtraEditors.SimpleButton btnExportar;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem25;
        private System.Windows.Forms.BindingSource stpFactSelControlClienteBindingSource;
        private Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelControlClienteTableAdapter stpFactSelControlClienteTableAdapter;
        private System.Windows.Forms.BindingSource stpFactSelTipoPeriodoNominaClienteBindingSource;
        private Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelTipoPeriodoNominaClienteTableAdapter stpFactSelTipoPeriodoNominaClienteTableAdapter;
        private System.Windows.Forms.BindingSource stpFactSelPromotorClienteBindingSource;
        private Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelPromotorClienteTableAdapter stpFactSelPromotorClienteTableAdapter;
        private System.Windows.Forms.BindingSource stpFactSelClaseRiesgoBindingSource;
        private Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelClaseRiesgoTableAdapter stpFactSelClaseRiesgoTableAdapter;
        private System.Windows.Forms.BindingSource vwcatFrontingBindingSource;
        private Facturas.dbSAICBPOFacturaTableAdapters.vwcatFrontingTableAdapter vwcatFrontingTableAdapter;
        private System.Windows.Forms.BindingSource stpFactSelComisionClienteBindingSource;
        private Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelComisionClienteTableAdapter stpFactSelComisionClienteTableAdapter;
        private System.Windows.Forms.BindingSource stpSelOperadorBindingSource;
        private dbSAICBPODataSetTableAdapters.stpSelOperadorTableAdapter stpSelOperadorTableAdapter;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup7;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIdTipoClienteProveedor;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPeriodicidad;
        private DevExpress.XtraLayout.LayoutControlItem ItemClaseRiesgo;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem19;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPctComisionBPO;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem26;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem21;
        private DevExpress.XtraLayout.LayoutControlItem lyGrupo;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem23;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem17;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem18;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTieneSucursales;
        private DevExpress.XtraLayout.LayoutControlItem ItemForConfidencial;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem27;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem20;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem16;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private System.Windows.Forms.BindingSource stpFactSelMatrizClienteActivosBindingSource;
        private Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelMatrizClienteActivosTableAdapter stpFactSelMatrizClienteActivosTableAdapter;
        private Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelClientePrPePrCoFoTableAdapter stpFactSelClientePrPePrCoFoTableAdapter1;
        private Facturas.dbSAICBPOFacturaTableAdapters.spSoloRespuesta spSoloRespuesta1;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private dbSAIC_CatalogosTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashSMCargando;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraLayout.LayoutControlItem ItemForContacto;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPaginaWeb;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCorreoElectronico;
        private DevExpress.XtraLayout.LayoutControlItem ItemForContacto1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTelefono2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTelefono1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem24;
        private Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelDerechosAccesoOperadorFacturacionTableAdapter stpFactSelDerechosAccesoOperadorFacturacionTableAdapter1;
        private Facturas.dbSAICBPOFactura dbSAICBPOFactura1;
        private DevExpress.XtraEditors.LookUpEdit cboIdRegimenFiscalSAT;
        private DevExpress.XtraEditors.GridLookUpEdit cbPlazaCliente;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem ItemForRegimenFiscalSAT;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelPlazaClienteTableAdapter stpSelPlazaClienteTableAdapter1;
        private dbSAIC_CatalogosTableAdapters.stpSelRegimenFiscalSATTableAdapter stpSelRegimenFiscalSATTableAdapter1;
        private System.Windows.Forms.BindingSource stpSelRegimenFiscalSATBindingSource;
        private System.Windows.Forms.BindingSource stpSelPlazaClienteBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnRegimenFiscal;
        private DevExpress.XtraEditors.SpinEdit spSaldoFavor;
        private DevExpress.XtraEditors.SpinEdit spFinanciamiento;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem13;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem22;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup8;
        private DevExpress.XtraEditors.SpinEdit spComision;
        private DevExpress.XtraEditors.TextEdit txtObservacionesPromo;
        private DevExpress.XtraEditors.SimpleButton btnAgregarPromo;
        private DevExpress.XtraEditors.SimpleButton btnEliminarProm;
        private DevExpress.XtraEditors.SimpleButton btnModificPromotor;
        private DevExpress.XtraEditors.SimpleButton btnGuardarPromo;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem28;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem29;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem30;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem32;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem34;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem35;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem36;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem31;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup6;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIdCliente;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraLayout.LayoutControlItem ItemForRazonSocial;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNombreComercial;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem9;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIdActividadComercial;
        private DevExpress.XtraLayout.LayoutControlItem ItemForRFC;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem14;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem11;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator2;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem33;
        private System.Windows.Forms.BindingSource stpSelPromotoresActivosBindingSource;
        private dbSAIC_CatalogosTableAdapters.stpSelPromotoresActivosTableAdapter stpSelPromotoresActivosTableAdapter;
        private System.Windows.Forms.BindingSource stpSelClientePromotoresBindingSource;
        private dbSAIC_CatalogosTableAdapters.stpSelClientePromotoresTableAdapter stpSelClientePromotoresTableAdapter;
        private DevExpress.XtraEditors.GridLookUpEdit cbRelIdPromotor;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView7;
        private DevExpress.XtraEditors.GridLookUpEdit cbPromotor;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView8;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPromotor;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn CorreoElectronico;
        private DevExpress.XtraEditors.SimpleButton btnCancelarPro;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem37;
        private DevExpress.XtraEditors.TextEdit RegimenCapitaltextEdit;
        private DevExpress.XtraLayout.LayoutControlItem RegimenCapitalItem;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnRegimenCapital;
        private DevExpress.XtraEditors.SimpleButton btnPromotores;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem39;
        private DevExpress.XtraEditors.ButtonEdit buttonEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem38;
        private DevExpress.XtraEditors.SimpleButton btnAgregarCategoria;
        private DevExpress.XtraEditors.GridLookUpEdit cbCategoriaCliente;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem40;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem41;
        private System.Windows.Forms.BindingSource stpSelCategoriaClienteBindingSource;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelCategoriaClienteTableAdapter stpSelCategoriaClienteTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4idCategoriaCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colidCategoriaCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colDescCategoria;
        private DevExpress.XtraGrid.Columns.GridColumn colDescEstatus;
        private DevExpress.XtraEditors.SpinEdit spIVA;
        private DevExpress.XtraEditors.SpinEdit spUtilidadReal;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem42;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem43;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup9;
        private DevExpress.XtraEditors.SpinEdit spPctBPOTarjeta;
        private DevExpress.XtraEditors.SpinEdit spPctProTarjeta;
        private DevExpress.XtraEditors.SpinEdit spPctBPOCucas;
        private DevExpress.XtraEditors.SpinEdit spPctProCucas;
        private DevExpress.XtraEditors.SpinEdit spPctBPOEfectivo;
        private DevExpress.XtraEditors.SpinEdit spPctProEfectivo;
        private DevExpress.XtraEditors.SpinEdit spPctBPOSeguros;
        private DevExpress.XtraEditors.SpinEdit spPctProSeguros;
        private DevExpress.XtraEditors.SpinEdit spPctBPOProveedor;
        private DevExpress.XtraEditors.SpinEdit spPctProProveedor;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem1;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem2;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem3;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem4;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem44;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem45;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem13;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem46;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem47;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem48;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem49;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem50;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem51;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem52;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem53;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem6;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem7;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem8;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem9;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem19;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem20;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem21;
        private dbSAIC_CatalogosTableAdapters.stpSelClientePromotoresPorcetajeClienteTableAdapter stpSelClientePromotoresPorcetajeClienteTableAdapter1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdRelClientePromotor;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPromotor1;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreCompletoPromotor;
        private DevExpress.XtraGrid.Columns.GridColumn colComision;
        private DevExpress.XtraGrid.Columns.GridColumn colIVA;
        private DevExpress.XtraGrid.Columns.GridColumn colUtilidadReal;
        private DevExpress.XtraGrid.Columns.GridColumn colObservaciones1;
        private dbSAIC_CatalogosTableAdapters.stpSelClientePCTProductoTableAdapter stpSelClientePCTProductoTableAdapter1;
        private DevExpress.XtraEditors.SpinEdit spPctBPOGasto;
        private DevExpress.XtraEditors.SpinEdit spPctProGasto;
        private DevExpress.XtraEditors.SpinEdit spPctBPOOtro;
        private DevExpress.XtraEditors.SpinEdit spPctProOtro;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem22;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem24;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem25;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem10;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem11;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem12;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem54;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem55;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem13;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem56;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem57;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem26;
    }
}