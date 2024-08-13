namespace winAppSAIC.Catalogos
{
    partial class frmxClientesMatriz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmxClientesMatriz));
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
            this.btnEditar = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnNuevo = new DevExpress.XtraEditors.SimpleButton();
            this.cboIdClienteProveedor = new DevExpress.XtraEditors.GridLookUpEdit();
            this.stpFactSelControlMatrizClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPOFactura = new winAppSAIC.Facturas.dbSAICBPOFactura();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRazonSocial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreComercial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRFC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdActividadComercial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoExterior = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoInterior = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colColonia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigoPostal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdPais = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreDelegacionMunicipio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombrePoblacionCiudad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColRepresentanteLegal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContacto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefono1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefono2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCorreoElectronico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaginaWeb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaBaja = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaModificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioCreacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioModificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnABC_ActividadComercial = new DevExpress.XtraEditors.SimpleButton();
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
            this.txtTelefono1 = new DevExpress.XtraEditors.TextEdit();
            this.txtTelefono2 = new DevExpress.XtraEditors.TextEdit();
            this.txtContacto = new DevExpress.XtraEditors.TextEdit();
            this.txtCorreoElectronico = new DevExpress.XtraEditors.TextEdit();
            this.txtPaginaWeb = new DevExpress.XtraEditors.TextEdit();
            this.cboIdEstatus = new DevExpress.XtraEditors.LookUpEdit();
            this.vwCatEstatusClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calFechaBaja = new DevExpress.XtraEditors.DateEdit();
            this.UsuarioCreacionTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.UsuarioModificacionTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.txtIdCliente = new DevExpress.XtraEditors.TextEdit();
            this.cboIdActividadComercial = new DevExpress.XtraEditors.GridLookUpEdit();
            this.actividadComercialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdActividadComercial1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescActividadComercial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtRepresentanteLegal = new DevExpress.XtraEditors.TextEdit();
            this.ItemForUsuarioCreacion = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForUsuarioModificacion = new DevExpress.XtraLayout.LayoutControlItem();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup5 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.tcgInformacionAdicional = new DevExpress.XtraLayout.TabbedControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForCalle = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNoExterior = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNoInterior = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForColonia = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForIdEstado = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNombreDelegacionMunicipio = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNombrePoblacionCiudad = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForIdPais = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem6 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.ItemForCodigoPostal = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem7 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForContacto = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPaginaWeb = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCorreoElectronico = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem13 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.ItemForContacto1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTelefono2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTelefono1 = new DevExpress.XtraLayout.LayoutControlItem();
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
            this.ItemForIdEstatus = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForFechaBaja = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem11 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem8 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem12 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.stpSelPaisBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.stpSelEstadoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICCatalogosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.stpSelEstadoTableAdapter = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelEstadoTableAdapter();
            this.actividadComercialTableAdapter = new winAppSAIC.Catalogos.dbSAIC_CatalogosTableAdapters.ActividadComercialTableAdapter();
            this.splashSMCargando = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::winAppSAIC.frmxCargandoInformacion), true, true);
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
            this.matrizClienteTableAdapter1 = new winAppSAIC.Catalogos.dbSAIC_CatalogosTableAdapters.MatrizClienteTableAdapter();
            this.stpFactSelControlMatrizClienteTableAdapter = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelControlMatrizClienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboIdClienteProveedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelControlMatrizClienteBindingSource)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContacto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCorreoElectronico.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPaginaWeb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboIdEstatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCatEstatusClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calFechaBaja.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calFechaBaja.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioCreacionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioModificacionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboIdActividadComercial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadComercialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRepresentanteLegal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUsuarioCreacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUsuarioModificacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcgInformacionAdicional)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNoExterior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNoInterior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForColonia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNombreDelegacionMunicipio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNombrePoblacionCiudad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdPais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCodigoPostal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForContacto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPaginaWeb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCorreoElectronico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForContacto1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTelefono2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTelefono1)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdEstatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFechaBaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelPaisBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelEstadoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICCatalogosBindingSource)).BeginInit();
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
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 607);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1069, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 576);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1069, 31);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 576);
            // 
            // dbSAICBPOCatalogosDataSet
            // 
            this.dbSAICBPOCatalogosDataSet.DataSetName = "dbSAICBPOCatalogosDataSet";
            this.dbSAICBPOCatalogosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.btnEditar);
            this.dataLayoutControl1.Controls.Add(this.btnGuardar);
            this.dataLayoutControl1.Controls.Add(this.btnCancelar);
            this.dataLayoutControl1.Controls.Add(this.btnNuevo);
            this.dataLayoutControl1.Controls.Add(this.cboIdClienteProveedor);
            this.dataLayoutControl1.Controls.Add(this.btnABC_ActividadComercial);
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
            this.dataLayoutControl1.Controls.Add(this.txtTelefono1);
            this.dataLayoutControl1.Controls.Add(this.txtTelefono2);
            this.dataLayoutControl1.Controls.Add(this.txtContacto);
            this.dataLayoutControl1.Controls.Add(this.txtCorreoElectronico);
            this.dataLayoutControl1.Controls.Add(this.txtPaginaWeb);
            this.dataLayoutControl1.Controls.Add(this.cboIdEstatus);
            this.dataLayoutControl1.Controls.Add(this.calFechaBaja);
            this.dataLayoutControl1.Controls.Add(this.UsuarioCreacionTextEdit);
            this.dataLayoutControl1.Controls.Add(this.UsuarioModificacionTextEdit);
            this.dataLayoutControl1.Controls.Add(this.txtIdCliente);
            this.dataLayoutControl1.Controls.Add(this.cboIdActividadComercial);
            this.dataLayoutControl1.Controls.Add(this.txtRepresentanteLegal);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForUsuarioCreacion,
            this.ItemForUsuarioModificacion});
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 31);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(148, 191, 461, 312);
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(1069, 576);
            this.dataLayoutControl1.TabIndex = 4;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(936, 98);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(121, 22);
            this.btnEditar.StyleController = this.dataLayoutControl1;
            this.btnEditar.TabIndex = 46;
            this.btnEditar.Text = "Editar Grupo";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(936, 150);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(121, 22);
            this.btnGuardar.StyleController = this.dataLayoutControl1;
            this.btnGuardar.TabIndex = 48;
            this.btnGuardar.Text = "Guardar Grupo";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(936, 124);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 22);
            this.btnCancelar.StyleController = this.dataLayoutControl1;
            this.btnCancelar.TabIndex = 47;
            this.btnCancelar.Text = "Cancelar Grupo";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(936, 72);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(121, 22);
            this.btnNuevo.StyleController = this.dataLayoutControl1;
            this.btnNuevo.TabIndex = 45;
            this.btnNuevo.Text = "Nuevo Grupo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // cboIdClienteProveedor
            // 
            this.cboIdClienteProveedor.Location = new System.Drawing.Point(115, 12);
            this.cboIdClienteProveedor.MenuManager = this.barManager1;
            this.cboIdClienteProveedor.Name = "cboIdClienteProveedor";
            this.cboIdClienteProveedor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboIdClienteProveedor.Properties.DataSource = this.stpFactSelControlMatrizClienteBindingSource;
            this.cboIdClienteProveedor.Properties.DisplayMember = "RazonSocial";
            this.cboIdClienteProveedor.Properties.NullText = "";
            this.cboIdClienteProveedor.Properties.ValueMember = "IdMatrizCliente";
            this.cboIdClienteProveedor.Properties.View = this.gridLookUpEdit1View;
            this.cboIdClienteProveedor.Size = new System.Drawing.Size(817, 20);
            this.cboIdClienteProveedor.StyleController = this.dataLayoutControl1;
            this.cboIdClienteProveedor.TabIndex = 1;
            this.cboIdClienteProveedor.EditValueChanged += new System.EventHandler(this.cboIdClienteProveedor_EditValueChanged);
            // 
            // stpFactSelControlMatrizClienteBindingSource
            // 
            this.stpFactSelControlMatrizClienteBindingSource.DataMember = "stpFactSelControlMatrizCliente";
            this.stpFactSelControlMatrizClienteBindingSource.DataSource = this.dbSAICBPOFactura;
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
            this.colIdActividadComercial,
            this.colCalle,
            this.colNoExterior,
            this.colNoInterior,
            this.colColonia,
            this.colCodigoPostal,
            this.colIdPais,
            this.colIdEstado,
            this.colNombreDelegacionMunicipio,
            this.colNombrePoblacionCiudad,
            this.ColRepresentanteLegal,
            this.colContacto,
            this.colTelefono1,
            this.colTelefono2,
            this.colCorreoElectronico,
            this.colPaginaWeb,
            this.colIdEstatus,
            this.colFechaBaja,
            this.colFechaModificacion,
            this.colUsuarioCreacion,
            this.colUsuarioModificacion});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ColumnAutoWidth = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdCliente
            // 
            this.colIdCliente.Caption = "No. Grupo";
            this.colIdCliente.FieldName = "IdMatrizCliente";
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
            // colIdActividadComercial
            // 
            this.colIdActividadComercial.FieldName = "IdActividadComercial";
            this.colIdActividadComercial.Name = "colIdActividadComercial";
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
            // ColRepresentanteLegal
            // 
            this.ColRepresentanteLegal.Caption = "Representante Legal";
            this.ColRepresentanteLegal.FieldName = "RepresentanteLegal";
            this.ColRepresentanteLegal.Name = "ColRepresentanteLegal";
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
            // colIdEstatus
            // 
            this.colIdEstatus.FieldName = "IdEstatus";
            this.colIdEstatus.Name = "colIdEstatus";
            // 
            // colFechaBaja
            // 
            this.colFechaBaja.FieldName = "FechaBaja";
            this.colFechaBaja.Name = "colFechaBaja";
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
            // btnABC_ActividadComercial
            // 
            this.btnABC_ActividadComercial.Image = global::winAppSAIC.Properties.Resources.Product16x16;
            this.btnABC_ActividadComercial.Location = new System.Drawing.Point(894, 199);
            this.btnABC_ActividadComercial.Name = "btnABC_ActividadComercial";
            this.btnABC_ActividadComercial.Size = new System.Drawing.Size(26, 22);
            this.btnABC_ActividadComercial.StyleController = this.dataLayoutControl1;
            this.btnABC_ActividadComercial.TabIndex = 7;
            this.btnABC_ActividadComercial.ToolTip = "Alta de Actividad Comercial";
            this.btnABC_ActividadComercial.Click += new System.EventHandler(this.btnABC_ActividadComercial_Click);
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(127, 127);
            this.txtRazonSocial.MenuManager = this.barManager1;
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRazonSocial.Properties.MaxLength = 255;
            this.txtRazonSocial.Size = new System.Drawing.Size(793, 20);
            this.txtRazonSocial.StyleController = this.dataLayoutControl1;
            this.txtRazonSocial.TabIndex = 3;
            this.txtRazonSocial.Tag = "Razón Social";
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            this.dxValidationProvider1.SetValidationRule(this.txtRazonSocial, conditionValidationRule1);
            // 
            // txtNombreComercial
            // 
            this.txtNombreComercial.Location = new System.Drawing.Point(127, 151);
            this.txtNombreComercial.MenuManager = this.barManager1;
            this.txtNombreComercial.Name = "txtNombreComercial";
            this.txtNombreComercial.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreComercial.Properties.MaxLength = 255;
            this.txtNombreComercial.Size = new System.Drawing.Size(793, 20);
            this.txtNombreComercial.StyleController = this.dataLayoutControl1;
            this.txtNombreComercial.TabIndex = 4;
            this.txtNombreComercial.Tag = "Nombre Comercial";
            // 
            // txtRFC
            // 
            this.txtRFC.Location = new System.Drawing.Point(127, 175);
            this.txtRFC.MenuManager = this.barManager1;
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRFC.Properties.MaxLength = 13;
            this.txtRFC.Size = new System.Drawing.Size(763, 20);
            this.txtRFC.StyleController = this.dataLayoutControl1;
            this.txtRFC.TabIndex = 5;
            this.txtRFC.Tag = "RFC";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(139, 345);
            this.txtCalle.MenuManager = this.barManager1;
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCalle.Properties.MaxLength = 255;
            this.txtCalle.Size = new System.Drawing.Size(769, 20);
            this.txtCalle.StyleController = this.dataLayoutControl1;
            this.txtCalle.TabIndex = 10;
            // 
            // txtNoExterior
            // 
            this.txtNoExterior.Location = new System.Drawing.Point(139, 369);
            this.txtNoExterior.MenuManager = this.barManager1;
            this.txtNoExterior.Name = "txtNoExterior";
            this.txtNoExterior.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNoExterior.Properties.MaxLength = 30;
            this.txtNoExterior.Size = new System.Drawing.Size(72, 20);
            this.txtNoExterior.StyleController = this.dataLayoutControl1;
            this.txtNoExterior.TabIndex = 11;
            // 
            // txtNoInterior
            // 
            this.txtNoInterior.Location = new System.Drawing.Point(318, 369);
            this.txtNoInterior.MenuManager = this.barManager1;
            this.txtNoInterior.Name = "txtNoInterior";
            this.txtNoInterior.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNoInterior.Properties.MaxLength = 30;
            this.txtNoInterior.Size = new System.Drawing.Size(72, 20);
            this.txtNoInterior.StyleController = this.dataLayoutControl1;
            this.txtNoInterior.TabIndex = 12;
            // 
            // txtColonia
            // 
            this.txtColonia.Location = new System.Drawing.Point(139, 393);
            this.txtColonia.MenuManager = this.barManager1;
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtColonia.Properties.MaxLength = 255;
            this.txtColonia.Size = new System.Drawing.Size(769, 20);
            this.txtColonia.StyleController = this.dataLayoutControl1;
            this.txtColonia.TabIndex = 13;
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.Location = new System.Drawing.Point(139, 417);
            this.txtCodigoPostal.MenuManager = this.barManager1;
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoPostal.Properties.Mask.EditMask = "\\d\\d\\d\\d\\d";
            this.txtCodigoPostal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtCodigoPostal.Properties.Mask.ShowPlaceHolders = false;
            this.txtCodigoPostal.Properties.MaxLength = 5;
            this.txtCodigoPostal.Size = new System.Drawing.Size(72, 20);
            this.txtCodigoPostal.StyleController = this.dataLayoutControl1;
            this.txtCodigoPostal.TabIndex = 14;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Código Postal requerido";
            this.dxValidationProvider1.SetValidationRule(this.txtCodigoPostal, conditionValidationRule2);
            // 
            // cboIdPais
            // 
            this.cboIdPais.Location = new System.Drawing.Point(578, 417);
            this.cboIdPais.MenuManager = this.barManager1;
            this.cboIdPais.Name = "cboIdPais";
            this.cboIdPais.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboIdPais.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdPais", "Id Pais", 55, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NombrePais", "País", 69, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.cboIdPais.Properties.DataSource = this.stpSelPaisBindingSource;
            this.cboIdPais.Properties.DisplayMember = "NombrePais";
            this.cboIdPais.Properties.NullText = "";
            this.cboIdPais.Properties.ValueMember = "IdPais";
            this.cboIdPais.Size = new System.Drawing.Size(330, 20);
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
            this.cboIdEstado.Location = new System.Drawing.Point(318, 417);
            this.cboIdEstado.MenuManager = this.barManager1;
            this.cboIdEstado.Name = "cboIdEstado";
            this.cboIdEstado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboIdEstado.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdEstado", "Id Estado", 69, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NombreEstado", "Estado", 83, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.cboIdEstado.Properties.DataSource = this.stpSelEstadoBindingSource;
            this.cboIdEstado.Properties.DisplayMember = "NombreEstado";
            this.cboIdEstado.Properties.NullText = "";
            this.cboIdEstado.Properties.ValueMember = "IdEstado";
            this.cboIdEstado.Size = new System.Drawing.Size(153, 20);
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
            this.txtNombreDelegacionMunicipio.Location = new System.Drawing.Point(139, 441);
            this.txtNombreDelegacionMunicipio.MenuManager = this.barManager1;
            this.txtNombreDelegacionMunicipio.Name = "txtNombreDelegacionMunicipio";
            this.txtNombreDelegacionMunicipio.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreDelegacionMunicipio.Properties.MaxLength = 255;
            this.txtNombreDelegacionMunicipio.Size = new System.Drawing.Size(769, 20);
            this.txtNombreDelegacionMunicipio.StyleController = this.dataLayoutControl1;
            this.txtNombreDelegacionMunicipio.TabIndex = 17;
            // 
            // txtNombrePoblacionCiudad
            // 
            this.txtNombrePoblacionCiudad.Location = new System.Drawing.Point(139, 465);
            this.txtNombrePoblacionCiudad.MenuManager = this.barManager1;
            this.txtNombrePoblacionCiudad.Name = "txtNombrePoblacionCiudad";
            this.txtNombrePoblacionCiudad.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombrePoblacionCiudad.Properties.MaxLength = 255;
            this.txtNombrePoblacionCiudad.Size = new System.Drawing.Size(769, 20);
            this.txtNombrePoblacionCiudad.StyleController = this.dataLayoutControl1;
            this.txtNombrePoblacionCiudad.TabIndex = 18;
            // 
            // txtTelefono1
            // 
            this.txtTelefono1.Location = new System.Drawing.Point(139, 393);
            this.txtTelefono1.MenuManager = this.barManager1;
            this.txtTelefono1.Name = "txtTelefono1";
            this.txtTelefono1.Properties.MaxLength = 30;
            this.txtTelefono1.Size = new System.Drawing.Size(135, 20);
            this.txtTelefono1.StyleController = this.dataLayoutControl1;
            this.txtTelefono1.TabIndex = 31;
            // 
            // txtTelefono2
            // 
            this.txtTelefono2.Location = new System.Drawing.Point(381, 393);
            this.txtTelefono2.MenuManager = this.barManager1;
            this.txtTelefono2.Name = "txtTelefono2";
            this.txtTelefono2.Properties.MaxLength = 30;
            this.txtTelefono2.Size = new System.Drawing.Size(527, 20);
            this.txtTelefono2.StyleController = this.dataLayoutControl1;
            this.txtTelefono2.TabIndex = 32;
            // 
            // txtContacto
            // 
            this.txtContacto.Location = new System.Drawing.Point(139, 369);
            this.txtContacto.MenuManager = this.barManager1;
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtContacto.Properties.MaxLength = 100;
            this.txtContacto.Size = new System.Drawing.Size(769, 20);
            this.txtContacto.StyleController = this.dataLayoutControl1;
            this.txtContacto.TabIndex = 30;
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Location = new System.Drawing.Point(139, 417);
            this.txtCorreoElectronico.MenuManager = this.barManager1;
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtCorreoElectronico.Properties.Mask.EditMask = "\\w+([-+.\']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            this.txtCorreoElectronico.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtCorreoElectronico.Properties.MaxLength = 255;
            this.txtCorreoElectronico.Size = new System.Drawing.Size(769, 20);
            this.txtCorreoElectronico.StyleController = this.dataLayoutControl1;
            this.txtCorreoElectronico.TabIndex = 33;
            // 
            // txtPaginaWeb
            // 
            this.txtPaginaWeb.Location = new System.Drawing.Point(139, 441);
            this.txtPaginaWeb.MenuManager = this.barManager1;
            this.txtPaginaWeb.Name = "txtPaginaWeb";
            this.txtPaginaWeb.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtPaginaWeb.Properties.MaxLength = 255;
            this.txtPaginaWeb.Size = new System.Drawing.Size(769, 20);
            this.txtPaginaWeb.StyleController = this.dataLayoutControl1;
            this.txtPaginaWeb.TabIndex = 34;
            // 
            // cboIdEstatus
            // 
            this.cboIdEstatus.Location = new System.Drawing.Point(143, 542);
            this.cboIdEstatus.MenuManager = this.barManager1;
            this.cboIdEstatus.Name = "cboIdEstatus";
            this.cboIdEstatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboIdEstatus.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdEstatus", "Id Estatus", 72, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DescEstatus", "Estatus", 72, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.cboIdEstatus.Properties.DataSource = this.vwCatEstatusClienteBindingSource;
            this.cboIdEstatus.Properties.DisplayMember = "DescEstatus";
            this.cboIdEstatus.Properties.NullText = "";
            this.cboIdEstatus.Properties.ValueMember = "IdEstatus";
            this.cboIdEstatus.Size = new System.Drawing.Size(98, 20);
            this.cboIdEstatus.StyleController = this.dataLayoutControl1;
            this.cboIdEstatus.TabIndex = 57;
            this.cboIdEstatus.Tag = "Estatus";
            this.cboIdEstatus.ToolTip = "Estatus";
            this.cboIdEstatus.EditValueChanged += new System.EventHandler(this.cboIdEstatus_EditValueChanged);
            // 
            // vwCatEstatusClienteBindingSource
            // 
            this.vwCatEstatusClienteBindingSource.DataMember = "vwCatEstatusCliente";
            this.vwCatEstatusClienteBindingSource.DataSource = this.dbSAIC_Catalogos;
            // 
            // calFechaBaja
            // 
            this.calFechaBaja.EditValue = null;
            this.calFechaBaja.Enabled = false;
            this.calFechaBaja.Location = new System.Drawing.Point(348, 542);
            this.calFechaBaja.MenuManager = this.barManager1;
            this.calFechaBaja.Name = "calFechaBaja";
            this.calFechaBaja.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calFechaBaja.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calFechaBaja.Size = new System.Drawing.Size(104, 20);
            this.calFechaBaja.StyleController = this.dataLayoutControl1;
            this.calFechaBaja.TabIndex = 58;
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
            this.txtIdCliente.Location = new System.Drawing.Point(127, 102);
            this.txtIdCliente.MenuManager = this.barManager1;
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.txtIdCliente.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtIdCliente.Size = new System.Drawing.Size(144, 20);
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
            this.cboIdActividadComercial.Location = new System.Drawing.Point(127, 199);
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
            this.cboIdActividadComercial.Size = new System.Drawing.Size(763, 20);
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
            // txtRepresentanteLegal
            // 
            this.txtRepresentanteLegal.Location = new System.Drawing.Point(139, 345);
            this.txtRepresentanteLegal.Name = "txtRepresentanteLegal";
            this.txtRepresentanteLegal.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRepresentanteLegal.Properties.MaxLength = 100;
            this.txtRepresentanteLegal.Size = new System.Drawing.Size(769, 20);
            this.txtRepresentanteLegal.StyleController = this.dataLayoutControl1;
            this.txtRepresentanteLegal.TabIndex = 29;
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
            this.Root.Size = new System.Drawing.Size(1069, 576);
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
            this.emptySpaceItem8,
            this.emptySpaceItem12,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem9,
            this.emptySpaceItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1049, 556);
            // 
            // layoutControlGroup5
            // 
            this.layoutControlGroup5.CustomizationFormText = "Domicilios y Contacto";
            this.layoutControlGroup5.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.tcgInformacionAdicional});
            this.layoutControlGroup5.Location = new System.Drawing.Point(0, 269);
            this.layoutControlGroup5.Name = "layoutControlGroup5";
            this.layoutControlGroup5.Size = new System.Drawing.Size(924, 261);
            this.layoutControlGroup5.Text = "Información Adicional";
            // 
            // tcgInformacionAdicional
            // 
            this.tcgInformacionAdicional.CustomizationFormText = "tabbedControlGroup1";
            this.tcgInformacionAdicional.Location = new System.Drawing.Point(0, 0);
            this.tcgInformacionAdicional.Name = "tcgInformacionAdicional";
            this.tcgInformacionAdicional.SelectedTabPage = this.layoutControlGroup2;
            this.tcgInformacionAdicional.SelectedTabPageIndex = 0;
            this.tcgInformacionAdicional.Size = new System.Drawing.Size(900, 219);
            this.tcgInformacionAdicional.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlGroup4});
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
            this.emptySpaceItem6,
            this.ItemForCodigoPostal,
            this.emptySpaceItem7});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(876, 173);
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
            this.ItemForCalle.TextSize = new System.Drawing.Size(100, 13);
            // 
            // ItemForNoExterior
            // 
            this.ItemForNoExterior.Control = this.txtNoExterior;
            this.ItemForNoExterior.CustomizationFormText = "No Exterior";
            this.ItemForNoExterior.Location = new System.Drawing.Point(0, 24);
            this.ItemForNoExterior.Name = "ItemForNoExterior";
            this.ItemForNoExterior.Size = new System.Drawing.Size(179, 24);
            this.ItemForNoExterior.Text = "No. Exterior";
            this.ItemForNoExterior.TextSize = new System.Drawing.Size(100, 13);
            // 
            // ItemForNoInterior
            // 
            this.ItemForNoInterior.Control = this.txtNoInterior;
            this.ItemForNoInterior.CustomizationFormText = "No Interior";
            this.ItemForNoInterior.Location = new System.Drawing.Point(179, 24);
            this.ItemForNoInterior.Name = "ItemForNoInterior";
            this.ItemForNoInterior.Size = new System.Drawing.Size(179, 24);
            this.ItemForNoInterior.Text = "No. Interior";
            this.ItemForNoInterior.TextSize = new System.Drawing.Size(100, 13);
            // 
            // ItemForColonia
            // 
            this.ItemForColonia.Control = this.txtColonia;
            this.ItemForColonia.CustomizationFormText = "Colonia";
            this.ItemForColonia.Location = new System.Drawing.Point(0, 48);
            this.ItemForColonia.Name = "ItemForColonia";
            this.ItemForColonia.Size = new System.Drawing.Size(876, 24);
            this.ItemForColonia.Text = "Colonia";
            this.ItemForColonia.TextSize = new System.Drawing.Size(100, 13);
            // 
            // ItemForIdEstado
            // 
            this.ItemForIdEstado.Control = this.cboIdEstado;
            this.ItemForIdEstado.CustomizationFormText = "Id Estado";
            this.ItemForIdEstado.Location = new System.Drawing.Point(179, 72);
            this.ItemForIdEstado.Name = "ItemForIdEstado";
            this.ItemForIdEstado.Size = new System.Drawing.Size(260, 24);
            this.ItemForIdEstado.Text = "Estado";
            this.ItemForIdEstado.TextSize = new System.Drawing.Size(100, 13);
            // 
            // ItemForNombreDelegacionMunicipio
            // 
            this.ItemForNombreDelegacionMunicipio.Control = this.txtNombreDelegacionMunicipio;
            this.ItemForNombreDelegacionMunicipio.CustomizationFormText = "Nombre Delegacion Municipio";
            this.ItemForNombreDelegacionMunicipio.Location = new System.Drawing.Point(0, 96);
            this.ItemForNombreDelegacionMunicipio.Name = "ItemForNombreDelegacionMunicipio";
            this.ItemForNombreDelegacionMunicipio.Size = new System.Drawing.Size(876, 24);
            this.ItemForNombreDelegacionMunicipio.Text = "Delegación/Municipio";
            this.ItemForNombreDelegacionMunicipio.TextSize = new System.Drawing.Size(100, 13);
            // 
            // ItemForNombrePoblacionCiudad
            // 
            this.ItemForNombrePoblacionCiudad.Control = this.txtNombrePoblacionCiudad;
            this.ItemForNombrePoblacionCiudad.CustomizationFormText = "Nombre Poblacion Ciudad";
            this.ItemForNombrePoblacionCiudad.Location = new System.Drawing.Point(0, 120);
            this.ItemForNombrePoblacionCiudad.Name = "ItemForNombrePoblacionCiudad";
            this.ItemForNombrePoblacionCiudad.Size = new System.Drawing.Size(876, 24);
            this.ItemForNombrePoblacionCiudad.Text = "Población/Ciudad";
            this.ItemForNombrePoblacionCiudad.TextSize = new System.Drawing.Size(100, 13);
            // 
            // ItemForIdPais
            // 
            this.ItemForIdPais.Control = this.cboIdPais;
            this.ItemForIdPais.CustomizationFormText = "Id Pais";
            this.ItemForIdPais.Location = new System.Drawing.Point(439, 72);
            this.ItemForIdPais.Name = "ItemForIdPais";
            this.ItemForIdPais.Size = new System.Drawing.Size(437, 24);
            this.ItemForIdPais.Text = "País";
            this.ItemForIdPais.TextSize = new System.Drawing.Size(100, 13);
            // 
            // emptySpaceItem6
            // 
            this.emptySpaceItem6.AllowHotTrack = false;
            this.emptySpaceItem6.CustomizationFormText = "emptySpaceItem6";
            this.emptySpaceItem6.Location = new System.Drawing.Point(0, 144);
            this.emptySpaceItem6.Name = "emptySpaceItem6";
            this.emptySpaceItem6.Size = new System.Drawing.Size(876, 29);
            this.emptySpaceItem6.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ItemForCodigoPostal
            // 
            this.ItemForCodigoPostal.Control = this.txtCodigoPostal;
            this.ItemForCodigoPostal.CustomizationFormText = "Codigo Postal";
            this.ItemForCodigoPostal.Location = new System.Drawing.Point(0, 72);
            this.ItemForCodigoPostal.Name = "ItemForCodigoPostal";
            this.ItemForCodigoPostal.Size = new System.Drawing.Size(179, 24);
            this.ItemForCodigoPostal.Text = "Código Postal";
            this.ItemForCodigoPostal.TextSize = new System.Drawing.Size(100, 13);
            // 
            // emptySpaceItem7
            // 
            this.emptySpaceItem7.AllowHotTrack = false;
            this.emptySpaceItem7.Location = new System.Drawing.Point(358, 24);
            this.emptySpaceItem7.Name = "emptySpaceItem7";
            this.emptySpaceItem7.Size = new System.Drawing.Size(518, 24);
            this.emptySpaceItem7.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.CustomizationFormText = "Contacto";
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForContacto,
            this.ItemForPaginaWeb,
            this.ItemForCorreoElectronico,
            this.emptySpaceItem13,
            this.ItemForContacto1,
            this.ItemForTelefono2,
            this.ItemForTelefono1});
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Size = new System.Drawing.Size(876, 173);
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
            this.ItemForContacto.TextSize = new System.Drawing.Size(100, 13);
            // 
            // ItemForPaginaWeb
            // 
            this.ItemForPaginaWeb.Control = this.txtPaginaWeb;
            this.ItemForPaginaWeb.CustomizationFormText = "Pagina Web";
            this.ItemForPaginaWeb.Location = new System.Drawing.Point(0, 96);
            this.ItemForPaginaWeb.Name = "ItemForPaginaWeb";
            this.ItemForPaginaWeb.Size = new System.Drawing.Size(876, 24);
            this.ItemForPaginaWeb.Text = "Página Web";
            this.ItemForPaginaWeb.TextSize = new System.Drawing.Size(100, 13);
            // 
            // ItemForCorreoElectronico
            // 
            this.ItemForCorreoElectronico.Control = this.txtCorreoElectronico;
            this.ItemForCorreoElectronico.CustomizationFormText = "Correo Electronico";
            this.ItemForCorreoElectronico.Location = new System.Drawing.Point(0, 72);
            this.ItemForCorreoElectronico.Name = "ItemForCorreoElectronico";
            this.ItemForCorreoElectronico.Size = new System.Drawing.Size(876, 24);
            this.ItemForCorreoElectronico.Text = "Correo Electrónico";
            this.ItemForCorreoElectronico.TextSize = new System.Drawing.Size(100, 13);
            // 
            // emptySpaceItem13
            // 
            this.emptySpaceItem13.AllowHotTrack = false;
            this.emptySpaceItem13.Location = new System.Drawing.Point(0, 120);
            this.emptySpaceItem13.Name = "emptySpaceItem13";
            this.emptySpaceItem13.Size = new System.Drawing.Size(876, 53);
            this.emptySpaceItem13.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ItemForContacto1
            // 
            this.ItemForContacto1.Control = this.txtRepresentanteLegal;
            this.ItemForContacto1.CustomizationFormText = "Representante Legal";
            this.ItemForContacto1.Location = new System.Drawing.Point(0, 0);
            this.ItemForContacto1.Name = "ItemForContacto1";
            this.ItemForContacto1.Size = new System.Drawing.Size(876, 24);
            this.ItemForContacto1.Text = "Representante Legal";
            this.ItemForContacto1.TextSize = new System.Drawing.Size(100, 13);
            // 
            // ItemForTelefono2
            // 
            this.ItemForTelefono2.Control = this.txtTelefono2;
            this.ItemForTelefono2.CustomizationFormText = "Telefono2";
            this.ItemForTelefono2.Location = new System.Drawing.Point(242, 48);
            this.ItemForTelefono2.Name = "ItemForTelefono2";
            this.ItemForTelefono2.Size = new System.Drawing.Size(634, 24);
            this.ItemForTelefono2.Text = "Teléfono 2";
            this.ItemForTelefono2.TextSize = new System.Drawing.Size(100, 13);
            // 
            // ItemForTelefono1
            // 
            this.ItemForTelefono1.Control = this.txtTelefono1;
            this.ItemForTelefono1.CustomizationFormText = "Telefono1";
            this.ItemForTelefono1.Location = new System.Drawing.Point(0, 48);
            this.ItemForTelefono1.Name = "ItemForTelefono1";
            this.ItemForTelefono1.Size = new System.Drawing.Size(242, 24);
            this.ItemForTelefono1.Text = "Teléfono 1";
            this.ItemForTelefono1.TextSize = new System.Drawing.Size(100, 13);
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
            this.layoutControlItem2});
            this.layoutControlGroup6.Location = new System.Drawing.Point(0, 60);
            this.layoutControlGroup6.Name = "layoutControlGroup6";
            this.layoutControlGroup6.Size = new System.Drawing.Size(924, 209);
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
            this.ItemForIdCliente.Size = new System.Drawing.Size(251, 25);
            this.ItemForIdCliente.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.ItemForIdCliente.Text = "No. Grupo";
            this.ItemForIdCliente.TextSize = new System.Drawing.Size(100, 13);
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.CustomizationFormText = "emptySpaceItem5";
            this.emptySpaceItem5.Location = new System.Drawing.Point(251, 0);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(649, 25);
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ItemForRazonSocial
            // 
            this.ItemForRazonSocial.Control = this.txtRazonSocial;
            this.ItemForRazonSocial.CustomizationFormText = "Razon Social";
            this.ItemForRazonSocial.Location = new System.Drawing.Point(0, 25);
            this.ItemForRazonSocial.Name = "ItemForRazonSocial";
            this.ItemForRazonSocial.Size = new System.Drawing.Size(900, 24);
            this.ItemForRazonSocial.Text = "Razón Social";
            this.ItemForRazonSocial.TextSize = new System.Drawing.Size(100, 13);
            // 
            // ItemForNombreComercial
            // 
            this.ItemForNombreComercial.Control = this.txtNombreComercial;
            this.ItemForNombreComercial.CustomizationFormText = "Nombre Comercial";
            this.ItemForNombreComercial.Location = new System.Drawing.Point(0, 49);
            this.ItemForNombreComercial.Name = "ItemForNombreComercial";
            this.ItemForNombreComercial.Size = new System.Drawing.Size(900, 24);
            this.ItemForNombreComercial.Text = "Nombre Comercial";
            this.ItemForNombreComercial.TextSize = new System.Drawing.Size(100, 13);
            // 
            // emptySpaceItem9
            // 
            this.emptySpaceItem9.AllowHotTrack = false;
            this.emptySpaceItem9.Location = new System.Drawing.Point(0, 123);
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
            this.ItemForIdActividadComercial.Size = new System.Drawing.Size(870, 26);
            this.ItemForIdActividadComercial.Text = "Actividad Comercial";
            this.ItemForIdActividadComercial.TextSize = new System.Drawing.Size(100, 13);
            // 
            // ItemForRFC
            // 
            this.ItemForRFC.Control = this.txtRFC;
            this.ItemForRFC.CustomizationFormText = "RFC";
            this.ItemForRFC.Location = new System.Drawing.Point(0, 73);
            this.ItemForRFC.Name = "ItemForRFC";
            this.ItemForRFC.Size = new System.Drawing.Size(870, 24);
            this.ItemForRFC.Text = "RFC";
            this.ItemForRFC.TextSize = new System.Drawing.Size(100, 13);
            // 
            // emptySpaceItem10
            // 
            this.emptySpaceItem10.AllowHotTrack = false;
            this.emptySpaceItem10.Location = new System.Drawing.Point(870, 73);
            this.emptySpaceItem10.Name = "emptySpaceItem10";
            this.emptySpaceItem10.Size = new System.Drawing.Size(30, 24);
            this.emptySpaceItem10.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnABC_ActividadComercial;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(870, 97);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(30, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(30, 26);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // ItemForIdEstatus
            // 
            this.ItemForIdEstatus.Control = this.cboIdEstatus;
            this.ItemForIdEstatus.CustomizationFormText = "Id Estatus";
            this.ItemForIdEstatus.Location = new System.Drawing.Point(28, 530);
            this.ItemForIdEstatus.Name = "ItemForIdEstatus";
            this.ItemForIdEstatus.Size = new System.Drawing.Size(205, 26);
            this.ItemForIdEstatus.Text = "Estatus";
            this.ItemForIdEstatus.TextSize = new System.Drawing.Size(100, 13);
            // 
            // ItemForFechaBaja
            // 
            this.ItemForFechaBaja.Control = this.calFechaBaja;
            this.ItemForFechaBaja.CustomizationFormText = "Fecha Baja";
            this.ItemForFechaBaja.Location = new System.Drawing.Point(233, 530);
            this.ItemForFechaBaja.MinSize = new System.Drawing.Size(179, 24);
            this.ItemForFechaBaja.Name = "ItemForFechaBaja";
            this.ItemForFechaBaja.Size = new System.Drawing.Size(211, 26);
            this.ItemForFechaBaja.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.ItemForFechaBaja.Text = "Fecha Baja";
            this.ItemForFechaBaja.TextSize = new System.Drawing.Size(100, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 530);
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
            this.emptySpaceItem11.Size = new System.Drawing.Size(924, 36);
            this.emptySpaceItem11.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.cboIdClienteProveedor;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(924, 24);
            this.layoutControlItem4.Text = "Buscar Grupos";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(100, 13);
            // 
            // emptySpaceItem8
            // 
            this.emptySpaceItem8.AllowHotTrack = false;
            this.emptySpaceItem8.Location = new System.Drawing.Point(924, 164);
            this.emptySpaceItem8.Name = "emptySpaceItem8";
            this.emptySpaceItem8.Size = new System.Drawing.Size(125, 392);
            this.emptySpaceItem8.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem12
            // 
            this.emptySpaceItem12.AllowHotTrack = false;
            this.emptySpaceItem12.Location = new System.Drawing.Point(924, 0);
            this.emptySpaceItem12.Name = "emptySpaceItem12";
            this.emptySpaceItem12.Size = new System.Drawing.Size(125, 60);
            this.emptySpaceItem12.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnNuevo;
            this.layoutControlItem5.Location = new System.Drawing.Point(924, 60);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(125, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnCancelar;
            this.layoutControlItem6.Location = new System.Drawing.Point(924, 112);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(125, 26);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btnGuardar;
            this.layoutControlItem7.Location = new System.Drawing.Point(924, 138);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(125, 26);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.btnEditar;
            this.layoutControlItem9.Location = new System.Drawing.Point(924, 86);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(125, 26);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(444, 530);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(480, 26);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // stpSelPaisBindingSource1
            // 
            this.stpSelPaisBindingSource1.DataMember = "stpSelPais";
            this.stpSelPaisBindingSource1.DataSource = this.dbSAIC_Catalogos;
            // 
            // stpSelEstadoBindingSource1
            // 
            this.stpSelEstadoBindingSource1.DataMember = "stpSelEstado";
            this.stpSelEstadoBindingSource1.DataSource = this.dbSAICBPOCatalogosDataSet;
            // 
            // dbSAICCatalogosBindingSource
            // 
            this.dbSAICCatalogosBindingSource.DataSource = this.dbSAIC_Catalogos;
            this.dbSAICCatalogosBindingSource.Position = 0;
            // 
            // stpSelEstadoTableAdapter
            // 
            this.stpSelEstadoTableAdapter.ClearBeforeFill = true;
            // 
            // actividadComercialTableAdapter
            // 
            this.actividadComercialTableAdapter.ClearBeforeFill = true;
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
            // matrizClienteTableAdapter1
            // 
            this.matrizClienteTableAdapter1.ClearBeforeFill = true;
            // 
            // stpFactSelControlMatrizClienteTableAdapter
            // 
            this.stpFactSelControlMatrizClienteTableAdapter.ClearBeforeFill = true;
            // 
            // frmxClientesMatriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 607);
            this.ControlBox = false;
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmxClientesMatriz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Grupos";
            this.Load += new System.EventHandler(this.frmxClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboIdClienteProveedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelControlMatrizClienteBindingSource)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContacto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCorreoElectronico.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPaginaWeb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboIdEstatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCatEstatusClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calFechaBaja.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calFechaBaja.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioCreacionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioModificacionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboIdActividadComercial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadComercialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRepresentanteLegal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUsuarioCreacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUsuarioModificacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcgInformacionAdicional)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNoExterior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNoInterior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForColonia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNombreDelegacionMunicipio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNombrePoblacionCiudad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdPais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCodigoPostal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForContacto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPaginaWeb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCorreoElectronico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForContacto1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTelefono2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTelefono1)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdEstatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFechaBaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelPaisBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelEstadoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICCatalogosBindingSource)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit txtTelefono1;
        private DevExpress.XtraEditors.TextEdit txtTelefono2;
        private DevExpress.XtraEditors.TextEdit txtContacto;
        private DevExpress.XtraEditors.TextEdit txtCorreoElectronico;
        private DevExpress.XtraEditors.TextEdit txtPaginaWeb;
        private DevExpress.XtraEditors.LookUpEdit cboIdEstatus;
        private DevExpress.XtraEditors.DateEdit calFechaBaja;
        private DevExpress.XtraEditors.TextEdit UsuarioCreacionTextEdit;
        private DevExpress.XtraEditors.TextEdit UsuarioModificacionTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForRazonSocial;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNombreComercial;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIdActividadComercial;
        private DevExpress.XtraLayout.LayoutControlItem ItemForRFC;
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
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem6;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIdCliente;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.SimpleButton btnABC_ActividadComercial;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private System.Windows.Forms.BindingSource stpSelEstadoBindingSource;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelEstadoTableAdapter stpSelEstadoTableAdapter;
        private System.Windows.Forms.BindingSource stpSelEstadoBindingSource1;
        private dbSAIC_Catalogos dbSAIC_Catalogos;
        private System.Windows.Forms.BindingSource actividadComercialBindingSource;
        private dbSAIC_CatalogosTableAdapters.ActividadComercialTableAdapter actividadComercialTableAdapter;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem9;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem11;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem10;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashSMCargando;
        private DevExpress.XtraEditors.GridLookUpEdit cboIdClienteProveedor;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colRazonSocial;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreComercial;
        private DevExpress.XtraGrid.Columns.GridColumn colIdActividadComercial;
        private DevExpress.XtraGrid.Columns.GridColumn colRFC;
        private DevExpress.XtraGrid.Columns.GridColumn colCalle;
        private DevExpress.XtraGrid.Columns.GridColumn colNoExterior;
        private DevExpress.XtraGrid.Columns.GridColumn colNoInterior;
        private DevExpress.XtraGrid.Columns.GridColumn colColonia;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoPostal;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPais;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreDelegacionMunicipio;
        private DevExpress.XtraGrid.Columns.GridColumn colNombrePoblacionCiudad;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefono1;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefono2;
        private DevExpress.XtraGrid.Columns.GridColumn colContacto;
        private DevExpress.XtraGrid.Columns.GridColumn colCorreoElectronico;
        private DevExpress.XtraGrid.Columns.GridColumn colPaginaWeb;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstatus;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaBaja;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaModificacion;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioCreacion;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioModificacion;
        private DevExpress.XtraEditors.TextEdit txtIdCliente;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnNuevo;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem8;
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
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem7;
        private System.Windows.Forms.BindingSource vwCatEstatusClienteBindingSource;
        private dbSAIC_CatalogosTableAdapters.vwCatEstatusClienteTableAdapter vwCatEstatusClienteTableAdapter;
        private DevExpress.XtraEditors.GridLookUpEdit cboIdActividadComercial;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdActividadComercial1;
        private DevExpress.XtraGrid.Columns.GridColumn colDescActividadComercial;
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
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraLayout.LayoutControlItem ItemForContacto;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPaginaWeb;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCorreoElectronico;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem13;
        private DevExpress.XtraLayout.LayoutControlItem ItemForContacto1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTelefono2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTelefono1;
        private DevExpress.XtraGrid.Columns.GridColumn ColRepresentanteLegal;
        private dbSAIC_CatalogosTableAdapters.MatrizClienteTableAdapter matrizClienteTableAdapter1;
        private Facturas.dbSAICBPOFactura dbSAICBPOFactura;
        private System.Windows.Forms.BindingSource stpFactSelControlMatrizClienteBindingSource;
        private Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelControlMatrizClienteTableAdapter stpFactSelControlMatrizClienteTableAdapter;
    }
}