namespace winAppSAIC.Seguridad
{
    partial class frmxUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmxUsuarios));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnNuevo = new DevExpress.XtraBars.BarButtonItem();
            this.btnGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditar = new DevExpress.XtraBars.BarButtonItem();
            this.btnCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.btnSalir = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.idOperadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.claveInternaOperadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCompletoOperadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoElectronicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAreaOperativaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.confidencialDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.activoParaNominasDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idEstatusReportesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPlazaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdGrupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescAreaOperativa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descGrupoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stpSelGeneralUsuariosGrupoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAIC_Seguridad = new winAppSAIC.Seguridad.dbSAIC_Seguridad();
            this.cboIdEstatusReportes = new System.Windows.Forms.ComboBox();
            this.estatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.cboIdGrupo = new System.Windows.Forms.ComboBox();
            this.sysGrupoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.cboIdPlaza = new System.Windows.Forms.ComboBox();
            this.plazaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboIdAreaOperativa = new System.Windows.Forms.ComboBox();
            this.areaOperativaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIdOperador = new System.Windows.Forms.Label();
            this.stpSelGeneralUsuariosGrupoTableAdapter = new winAppSAIC.Seguridad.dbSAIC_SeguridadTableAdapters.stpSelGeneralUsuariosGrupoTableAdapter();
            this.areaOperativaTableAdapter = new winAppSAIC.Seguridad.dbSAIC_SeguridadTableAdapters.AreaOperativaTableAdapter();
            this.plazaTableAdapter = new winAppSAIC.Seguridad.dbSAIC_SeguridadTableAdapters.PlazaTableAdapter();
            this.sysGrupoTableAdapter = new winAppSAIC.Seguridad.dbSAIC_SeguridadTableAdapters.SysGrupoTableAdapter();
            this.estatusTableAdapter = new winAppSAIC.Seguridad.dbSAIC_SeguridadTableAdapters.EstatusTableAdapter();
            this.validacionesGeneralTableAdapter1 = new winAppSAIC.Catalogos.dbSAICBPO_CatalogosValidacionDataSetTableAdapters.ValidacionesGeneralTableAdapter();
            this.txtIdOperador = new DevExpress.XtraEditors.TextEdit();
            this.txtNombreOperadorCompleto = new DevExpress.XtraEditors.TextEdit();
            this.txtCorreoElectronico = new DevExpress.XtraEditors.TextEdit();
            this.txtUsuario = new DevExpress.XtraEditors.TextEdit();
            this.txtContrasena = new DevExpress.XtraEditors.TextEdit();
            this.chkActivo = new DevExpress.XtraEditors.CheckEdit();
            this.chkConfidencial = new DevExpress.XtraEditors.CheckEdit();
            this.chkActivoNominas = new DevExpress.XtraEditors.CheckEdit();
            this.txtTipoEncripcion = new DevExpress.XtraEditors.TextEdit();
            this.txtCveInternaOperador = new DevExpress.XtraEditors.TextEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.memoEditPantallas = new DevExpress.XtraEditors.MemoEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.checkCBoxPantallas = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.gridLookAreaOperativa = new DevExpress.XtraEditors.GridLookUpEdit();
            this.stpSelObtenerGrupoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPOCatalogosDataSet1 = new winAppSAIC.dbSAICBPOCatalogosDataSet();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridCRazonSocial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.queriesTableAdapter1 = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.QueriesTableAdapter();
            this.stpSelObtenerGrupoTableAdapter1 = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelObtenerGrupoTableAdapter();
            this.stpSelObtenerPantallasTableAdapter1 = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelObtenerPantallasTableAdapter();
            this.stpSelInfoEmpleadosCorrespondenciaXEmpleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stpSelInfoEmpleadosCorrespondenciaXEmpleadoTableAdapter = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelInfoEmpleadosCorrespondenciaXEmpleadoTableAdapter();
            this.stpSelObtenerPantallasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelGeneralUsuariosGrupoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAIC_Seguridad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sysGrupoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plazaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaOperativaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdOperador.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreOperadorCompleto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCorreoElectronico.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContrasena.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkConfidencial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActivoNominas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoEncripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCveInternaOperador.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditPantallas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkCBoxPantallas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookAreaOperativa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelObtenerGrupoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelInfoEmpleadosCorrespondenciaXEmpleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelObtenerPantallasBindingSource)).BeginInit();
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
            this.btnNuevo,
            this.btnGuardar,
            this.btnEditar,
            this.btnCancelar,
            this.btnSalir});
            this.barManager1.MaxItemId = 6;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnNuevo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGuardar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEditar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCancelar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSalir, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Caption = "Nuevo";
            this.btnNuevo.Id = 0;
            this.btnNuevo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.ImageOptions.Image")));
            this.btnNuevo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.ImageOptions.LargeImage")));
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNuevo_ItemClick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Caption = "Guardar";
            this.btnGuardar.Id = 1;
            this.btnGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.Image")));
            this.btnGuardar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.LargeImage")));
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGuardar_ItemClick);
            // 
            // btnEditar
            // 
            this.btnEditar.Caption = "Editar";
            this.btnEditar.Id = 2;
            this.btnEditar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.ImageOptions.Image")));
            this.btnEditar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.ImageOptions.LargeImage")));
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditar_ItemClick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Caption = "Cancelar";
            this.btnCancelar.Id = 3;
            this.btnCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.ImageOptions.Image")));
            this.btnCancelar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.ImageOptions.LargeImage")));
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCancelar_ItemClick);
            // 
            // btnSalir
            // 
            this.btnSalir.Caption = "Salir";
            this.btnSalir.Id = 5;
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
            this.barDockControlTop.Size = new System.Drawing.Size(1084, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 493);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1084, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 462);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1084, 31);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 462);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.dgvUsuarios);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 31);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1084, 215);
            this.panelControl1.TabIndex = 0;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AutoGenerateColumns = false;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOperadorDataGridViewTextBoxColumn,
            this.claveInternaOperadorDataGridViewTextBoxColumn,
            this.nombreCompletoOperadorDataGridViewTextBoxColumn,
            this.nombreUsuarioDataGridViewTextBoxColumn,
            this.correoElectronicoDataGridViewTextBoxColumn,
            this.idAreaOperativaDataGridViewTextBoxColumn,
            this.activoDataGridViewCheckBoxColumn,
            this.confidencialDataGridViewCheckBoxColumn,
            this.activoParaNominasDataGridViewCheckBoxColumn,
            this.idEstatusReportesDataGridViewTextBoxColumn,
            this.idPlazaDataGridViewTextBoxColumn,
            this.IdGrupo,
            this.DescAreaOperativa,
            this.descGrupoDataGridViewTextBoxColumn});
            this.dgvUsuarios.DataSource = this.stpSelGeneralUsuariosGrupoBindingSource;
            this.dgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsuarios.Location = new System.Drawing.Point(2, 2);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(1080, 211);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvUsuarios_MouseClick);
            // 
            // idOperadorDataGridViewTextBoxColumn
            // 
            this.idOperadorDataGridViewTextBoxColumn.DataPropertyName = "IdOperador";
            this.idOperadorDataGridViewTextBoxColumn.HeaderText = "Id Usuario";
            this.idOperadorDataGridViewTextBoxColumn.Name = "idOperadorDataGridViewTextBoxColumn";
            this.idOperadorDataGridViewTextBoxColumn.ReadOnly = true;
            this.idOperadorDataGridViewTextBoxColumn.Width = 80;
            // 
            // claveInternaOperadorDataGridViewTextBoxColumn
            // 
            this.claveInternaOperadorDataGridViewTextBoxColumn.DataPropertyName = "ClaveInternaOperador";
            this.claveInternaOperadorDataGridViewTextBoxColumn.HeaderText = "Clave Interna";
            this.claveInternaOperadorDataGridViewTextBoxColumn.Name = "claveInternaOperadorDataGridViewTextBoxColumn";
            this.claveInternaOperadorDataGridViewTextBoxColumn.ReadOnly = true;
            this.claveInternaOperadorDataGridViewTextBoxColumn.Width = 80;
            // 
            // nombreCompletoOperadorDataGridViewTextBoxColumn
            // 
            this.nombreCompletoOperadorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nombreCompletoOperadorDataGridViewTextBoxColumn.DataPropertyName = "NombreCompletoOperador";
            this.nombreCompletoOperadorDataGridViewTextBoxColumn.HeaderText = "Nombre Completo";
            this.nombreCompletoOperadorDataGridViewTextBoxColumn.Name = "nombreCompletoOperadorDataGridViewTextBoxColumn";
            this.nombreCompletoOperadorDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreCompletoOperadorDataGridViewTextBoxColumn.Width = 107;
            // 
            // nombreUsuarioDataGridViewTextBoxColumn
            // 
            this.nombreUsuarioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nombreUsuarioDataGridViewTextBoxColumn.DataPropertyName = "NombreUsuario";
            this.nombreUsuarioDataGridViewTextBoxColumn.HeaderText = "Nombre Usuario";
            this.nombreUsuarioDataGridViewTextBoxColumn.Name = "nombreUsuarioDataGridViewTextBoxColumn";
            this.nombreUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreUsuarioDataGridViewTextBoxColumn.Width = 99;
            // 
            // correoElectronicoDataGridViewTextBoxColumn
            // 
            this.correoElectronicoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.correoElectronicoDataGridViewTextBoxColumn.DataPropertyName = "CorreoElectronico";
            this.correoElectronicoDataGridViewTextBoxColumn.HeaderText = "Correo Electrónico";
            this.correoElectronicoDataGridViewTextBoxColumn.Name = "correoElectronicoDataGridViewTextBoxColumn";
            this.correoElectronicoDataGridViewTextBoxColumn.ReadOnly = true;
            this.correoElectronicoDataGridViewTextBoxColumn.Width = 110;
            // 
            // idAreaOperativaDataGridViewTextBoxColumn
            // 
            this.idAreaOperativaDataGridViewTextBoxColumn.DataPropertyName = "IdAreaOperativa";
            this.idAreaOperativaDataGridViewTextBoxColumn.HeaderText = "IdAreaOperativa";
            this.idAreaOperativaDataGridViewTextBoxColumn.Name = "idAreaOperativaDataGridViewTextBoxColumn";
            this.idAreaOperativaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idAreaOperativaDataGridViewTextBoxColumn.Visible = false;
            // 
            // activoDataGridViewCheckBoxColumn
            // 
            this.activoDataGridViewCheckBoxColumn.DataPropertyName = "Activo";
            this.activoDataGridViewCheckBoxColumn.HeaderText = "Activo";
            this.activoDataGridViewCheckBoxColumn.Name = "activoDataGridViewCheckBoxColumn";
            this.activoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // confidencialDataGridViewCheckBoxColumn
            // 
            this.confidencialDataGridViewCheckBoxColumn.DataPropertyName = "Confidencial";
            this.confidencialDataGridViewCheckBoxColumn.HeaderText = "Confidencial";
            this.confidencialDataGridViewCheckBoxColumn.Name = "confidencialDataGridViewCheckBoxColumn";
            this.confidencialDataGridViewCheckBoxColumn.ReadOnly = true;
            this.confidencialDataGridViewCheckBoxColumn.Visible = false;
            // 
            // activoParaNominasDataGridViewCheckBoxColumn
            // 
            this.activoParaNominasDataGridViewCheckBoxColumn.DataPropertyName = "ActivoParaNominas";
            this.activoParaNominasDataGridViewCheckBoxColumn.HeaderText = "ActivoParaNominas";
            this.activoParaNominasDataGridViewCheckBoxColumn.Name = "activoParaNominasDataGridViewCheckBoxColumn";
            this.activoParaNominasDataGridViewCheckBoxColumn.ReadOnly = true;
            this.activoParaNominasDataGridViewCheckBoxColumn.Visible = false;
            // 
            // idEstatusReportesDataGridViewTextBoxColumn
            // 
            this.idEstatusReportesDataGridViewTextBoxColumn.DataPropertyName = "IdEstatusReportes";
            this.idEstatusReportesDataGridViewTextBoxColumn.HeaderText = "IdEstatusReportes";
            this.idEstatusReportesDataGridViewTextBoxColumn.Name = "idEstatusReportesDataGridViewTextBoxColumn";
            this.idEstatusReportesDataGridViewTextBoxColumn.ReadOnly = true;
            this.idEstatusReportesDataGridViewTextBoxColumn.Visible = false;
            // 
            // idPlazaDataGridViewTextBoxColumn
            // 
            this.idPlazaDataGridViewTextBoxColumn.DataPropertyName = "IdPlaza";
            this.idPlazaDataGridViewTextBoxColumn.HeaderText = "IdPlaza";
            this.idPlazaDataGridViewTextBoxColumn.Name = "idPlazaDataGridViewTextBoxColumn";
            this.idPlazaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPlazaDataGridViewTextBoxColumn.Visible = false;
            // 
            // IdGrupo
            // 
            this.IdGrupo.DataPropertyName = "IdGrupo";
            this.IdGrupo.HeaderText = "IdGrupo";
            this.IdGrupo.Name = "IdGrupo";
            this.IdGrupo.ReadOnly = true;
            this.IdGrupo.Visible = false;
            // 
            // DescAreaOperativa
            // 
            this.DescAreaOperativa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DescAreaOperativa.DataPropertyName = "DescAreaOperativa";
            this.DescAreaOperativa.HeaderText = "Area Operativa";
            this.DescAreaOperativa.Name = "DescAreaOperativa";
            this.DescAreaOperativa.ReadOnly = true;
            this.DescAreaOperativa.Width = 97;
            // 
            // descGrupoDataGridViewTextBoxColumn
            // 
            this.descGrupoDataGridViewTextBoxColumn.DataPropertyName = "DescGrupo";
            this.descGrupoDataGridViewTextBoxColumn.HeaderText = "Grupo Aplicación-Usuario";
            this.descGrupoDataGridViewTextBoxColumn.Name = "descGrupoDataGridViewTextBoxColumn";
            this.descGrupoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descGrupoDataGridViewTextBoxColumn.Width = 200;
            // 
            // stpSelGeneralUsuariosGrupoBindingSource
            // 
            this.stpSelGeneralUsuariosGrupoBindingSource.DataMember = "stpSelGeneralUsuariosGrupo";
            this.stpSelGeneralUsuariosGrupoBindingSource.DataSource = this.dbSAIC_Seguridad;
            // 
            // dbSAIC_Seguridad
            // 
            this.dbSAIC_Seguridad.DataSetName = "dbSAIC_Seguridad";
            this.dbSAIC_Seguridad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cboIdEstatusReportes
            // 
            this.cboIdEstatusReportes.DataSource = this.estatusBindingSource;
            this.cboIdEstatusReportes.DisplayMember = "DescEstatus";
            this.cboIdEstatusReportes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdEstatusReportes.FormattingEnabled = true;
            this.cboIdEstatusReportes.Location = new System.Drawing.Point(471, 153);
            this.cboIdEstatusReportes.Name = "cboIdEstatusReportes";
            this.cboIdEstatusReportes.Size = new System.Drawing.Size(135, 21);
            this.cboIdEstatusReportes.TabIndex = 19;
            this.cboIdEstatusReportes.ValueMember = "IdEstatus";
            // 
            // estatusBindingSource
            // 
            this.estatusBindingSource.DataMember = "Estatus";
            this.estatusBindingSource.DataSource = this.dbSAIC_Seguridad;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(375, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Estatus Reportes";
            // 
            // cboIdGrupo
            // 
            this.cboIdGrupo.DataSource = this.sysGrupoBindingSource;
            this.cboIdGrupo.DisplayMember = "DescGrupo";
            this.cboIdGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdGrupo.FormattingEnabled = true;
            this.cboIdGrupo.Location = new System.Drawing.Point(146, 153);
            this.cboIdGrupo.Name = "cboIdGrupo";
            this.cboIdGrupo.Size = new System.Drawing.Size(217, 21);
            this.cboIdGrupo.TabIndex = 17;
            this.cboIdGrupo.Tag = "Grupo Aplicación-Usuario";
            this.cboIdGrupo.ValueMember = "IdGrupo";
            this.cboIdGrupo.SelectedIndexChanged += new System.EventHandler(this.cboIdGrupo_SelectedIndexChanged);
            // 
            // sysGrupoBindingSource
            // 
            this.sysGrupoBindingSource.DataMember = "SysGrupo";
            this.sysGrupoBindingSource.DataSource = this.dbSAIC_Seguridad;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(16, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Grupo Aplicación-Usuario";
            // 
            // cboIdPlaza
            // 
            this.cboIdPlaza.DataSource = this.plazaBindingSource;
            this.cboIdPlaza.DisplayMember = "DescPlaza";
            this.cboIdPlaza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdPlaza.FormattingEnabled = true;
            this.cboIdPlaza.Location = new System.Drawing.Point(471, 125);
            this.cboIdPlaza.Name = "cboIdPlaza";
            this.cboIdPlaza.Size = new System.Drawing.Size(136, 21);
            this.cboIdPlaza.TabIndex = 15;
            this.cboIdPlaza.Tag = "Plaza";
            this.cboIdPlaza.ValueMember = "IdPlaza";
            // 
            // plazaBindingSource
            // 
            this.plazaBindingSource.DataMember = "Plaza";
            this.plazaBindingSource.DataSource = this.dbSAIC_Seguridad;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(433, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Plaza";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(434, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Tipo Encripción";
            // 
            // cboIdAreaOperativa
            // 
            this.cboIdAreaOperativa.DataSource = this.areaOperativaBindingSource;
            this.cboIdAreaOperativa.DisplayMember = "DescAreaOperativa";
            this.cboIdAreaOperativa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdAreaOperativa.FormattingEnabled = true;
            this.cboIdAreaOperativa.Location = new System.Drawing.Point(146, 125);
            this.cboIdAreaOperativa.Name = "cboIdAreaOperativa";
            this.cboIdAreaOperativa.Size = new System.Drawing.Size(217, 21);
            this.cboIdAreaOperativa.TabIndex = 13;
            this.cboIdAreaOperativa.Tag = "Area Operativa";
            this.cboIdAreaOperativa.ValueMember = "IdAreaOperativa";
            // 
            // areaOperativaBindingSource
            // 
            this.areaOperativaBindingSource.DataMember = "AreaOperativa";
            this.areaOperativaBindingSource.DataSource = this.dbSAIC_Seguridad;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(61, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Area Operativa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(47, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Correo Electrónico";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(402, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(99, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(11, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre Completo Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(353, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Clave Interna Usuario";
            // 
            // lblIdOperador
            // 
            this.lblIdOperador.AutoSize = true;
            this.lblIdOperador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.lblIdOperador.ForeColor = System.Drawing.Color.Black;
            this.lblIdOperador.Location = new System.Drawing.Point(72, 27);
            this.lblIdOperador.Name = "lblIdOperador";
            this.lblIdOperador.Size = new System.Drawing.Size(70, 13);
            this.lblIdOperador.TabIndex = 0;
            this.lblIdOperador.Text = "Id. Operador";
            // 
            // stpSelGeneralUsuariosGrupoTableAdapter
            // 
            this.stpSelGeneralUsuariosGrupoTableAdapter.ClearBeforeFill = true;
            // 
            // areaOperativaTableAdapter
            // 
            this.areaOperativaTableAdapter.ClearBeforeFill = true;
            // 
            // plazaTableAdapter
            // 
            this.plazaTableAdapter.ClearBeforeFill = true;
            // 
            // sysGrupoTableAdapter
            // 
            this.sysGrupoTableAdapter.ClearBeforeFill = true;
            // 
            // estatusTableAdapter
            // 
            this.estatusTableAdapter.ClearBeforeFill = true;
            // 
            // txtIdOperador
            // 
            this.txtIdOperador.Enabled = false;
            this.txtIdOperador.Location = new System.Drawing.Point(145, 23);
            this.txtIdOperador.MenuManager = this.barManager1;
            this.txtIdOperador.Name = "txtIdOperador";
            this.txtIdOperador.Size = new System.Drawing.Size(100, 20);
            this.txtIdOperador.TabIndex = 1;
            this.txtIdOperador.TabStop = false;
            // 
            // txtNombreOperadorCompleto
            // 
            this.txtNombreOperadorCompleto.Location = new System.Drawing.Point(145, 48);
            this.txtNombreOperadorCompleto.MenuManager = this.barManager1;
            this.txtNombreOperadorCompleto.Name = "txtNombreOperadorCompleto";
            this.txtNombreOperadorCompleto.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreOperadorCompleto.Properties.MaxLength = 255;
            this.txtNombreOperadorCompleto.Size = new System.Drawing.Size(462, 20);
            this.txtNombreOperadorCompleto.TabIndex = 5;
            this.txtNombreOperadorCompleto.Tag = "Nombre Completo Usuario";
            this.txtNombreOperadorCompleto.EditValueChanged += new System.EventHandler(this.txtNombreOperadorCompleto_EditValueChanged);
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Location = new System.Drawing.Point(146, 74);
            this.txtCorreoElectronico.MenuManager = this.barManager1;
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtCorreoElectronico.Properties.MaxLength = 100;
            this.txtCorreoElectronico.Size = new System.Drawing.Size(460, 20);
            this.txtCorreoElectronico.TabIndex = 7;
            this.txtCorreoElectronico.Tag = "Correo Electrónico";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(146, 99);
            this.txtUsuario.MenuManager = this.barManager1;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Properties.MaxLength = 50;
            this.txtUsuario.Size = new System.Drawing.Size(217, 20);
            this.txtUsuario.TabIndex = 9;
            this.txtUsuario.Tag = "Usuario";
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(471, 100);
            this.txtContrasena.MenuManager = this.barManager1;
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Properties.MaxLength = 100;
            this.txtContrasena.Size = new System.Drawing.Size(135, 20);
            this.txtContrasena.TabIndex = 11;
            this.txtContrasena.Tag = "Contraseña";
            // 
            // chkActivo
            // 
            this.chkActivo.Location = new System.Drawing.Point(145, 185);
            this.chkActivo.MenuManager = this.barManager1;
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Properties.Caption = "Activo";
            this.chkActivo.Size = new System.Drawing.Size(75, 19);
            this.chkActivo.TabIndex = 20;
            // 
            // chkConfidencial
            // 
            this.chkConfidencial.Location = new System.Drawing.Point(205, 185);
            this.chkConfidencial.MenuManager = this.barManager1;
            this.chkConfidencial.Name = "chkConfidencial";
            this.chkConfidencial.Properties.Caption = "Confidencial";
            this.chkConfidencial.Size = new System.Drawing.Size(87, 19);
            this.chkConfidencial.TabIndex = 21;
            // 
            // chkActivoNominas
            // 
            this.chkActivoNominas.Location = new System.Drawing.Point(307, 185);
            this.chkActivoNominas.MenuManager = this.barManager1;
            this.chkActivoNominas.Name = "chkActivoNominas";
            this.chkActivoNominas.Properties.Caption = "Activo para Nóminas";
            this.chkActivoNominas.Size = new System.Drawing.Size(129, 19);
            this.chkActivoNominas.TabIndex = 22;
            // 
            // txtTipoEncripcion
            // 
            this.txtTipoEncripcion.Enabled = false;
            this.txtTipoEncripcion.Location = new System.Drawing.Point(518, 184);
            this.txtTipoEncripcion.MenuManager = this.barManager1;
            this.txtTipoEncripcion.Name = "txtTipoEncripcion";
            this.txtTipoEncripcion.Size = new System.Drawing.Size(88, 20);
            this.txtTipoEncripcion.TabIndex = 24;
            // 
            // txtCveInternaOperador
            // 
            this.txtCveInternaOperador.Location = new System.Drawing.Point(471, 23);
            this.txtCveInternaOperador.MenuManager = this.barManager1;
            this.txtCveInternaOperador.Name = "txtCveInternaOperador";
            this.txtCveInternaOperador.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCveInternaOperador.Properties.MaxLength = 255;
            this.txtCveInternaOperador.Size = new System.Drawing.Size(136, 20);
            this.txtCveInternaOperador.TabIndex = 3;
            this.txtCveInternaOperador.Tag = "Clave Interna Usuario";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.memoEditPantallas);
            this.groupControl2.Controls.Add(this.simpleButton1);
            this.groupControl2.Controls.Add(this.checkCBoxPantallas);
            this.groupControl2.Controls.Add(this.gridLookAreaOperativa);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Location = new System.Drawing.Point(663, 265);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(366, 216);
            this.groupControl2.TabIndex = 31;
            this.groupControl2.Text = "Operador";
            // 
            // memoEditPantallas
            // 
            this.memoEditPantallas.Location = new System.Drawing.Point(7, 76);
            this.memoEditPantallas.MenuManager = this.barManager1;
            this.memoEditPantallas.Name = "memoEditPantallas";
            this.memoEditPantallas.Size = new System.Drawing.Size(349, 96);
            this.memoEditPantallas.TabIndex = 36;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = global::winAppSAIC.Properties.Resources.saveHS;
            this.simpleButton1.Location = new System.Drawing.Point(213, 180);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(143, 23);
            this.simpleButton1.TabIndex = 35;
            this.simpleButton1.Text = "Guardar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // checkCBoxPantallas
            // 
            this.checkCBoxPantallas.EditValue = "";
            this.checkCBoxPantallas.Location = new System.Drawing.Point(61, 50);
            this.checkCBoxPantallas.Name = "checkCBoxPantallas";
            this.checkCBoxPantallas.Properties.AllowMultiSelect = true;
            this.checkCBoxPantallas.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.checkCBoxPantallas.Properties.DataSource = this.stpSelObtenerPantallasBindingSource;
            this.checkCBoxPantallas.Properties.DisplayMember = "DescPantalla";
            this.checkCBoxPantallas.Properties.ValueMember = "IdPantalla";
            this.checkCBoxPantallas.Size = new System.Drawing.Size(295, 20);
            this.checkCBoxPantallas.TabIndex = 34;
            this.checkCBoxPantallas.EditValueChanged += new System.EventHandler(this.checkCBoxPantallas_EditValueChanged);
            // 
            // gridLookAreaOperativa
            // 
            this.gridLookAreaOperativa.EditValue = "vacio";
            this.gridLookAreaOperativa.Location = new System.Drawing.Point(61, 25);
            this.gridLookAreaOperativa.Name = "gridLookAreaOperativa";
            this.gridLookAreaOperativa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookAreaOperativa.Properties.DataSource = this.stpSelObtenerGrupoBindingSource;
            this.gridLookAreaOperativa.Properties.DisplayMember = "DescGrupo";
            this.gridLookAreaOperativa.Properties.ValueMember = "IdGrupo";
            this.gridLookAreaOperativa.Properties.View = this.gridLookUpEdit1View;
            this.gridLookAreaOperativa.Size = new System.Drawing.Size(295, 20);
            this.gridLookAreaOperativa.TabIndex = 32;
            this.gridLookAreaOperativa.EditValueChanged += new System.EventHandler(this.gridLookAreaOperativa_EditValueChanged);
            // 
            // stpSelObtenerGrupoBindingSource
            // 
            this.stpSelObtenerGrupoBindingSource.DataMember = "stpSelObtenerGrupo";
            this.stpSelObtenerGrupoBindingSource.DataSource = this.dbSAICBPOCatalogosDataSet1;
            // 
            // dbSAICBPOCatalogosDataSet1
            // 
            this.dbSAICBPOCatalogosDataSet1.DataSetName = "dbSAICBPOCatalogosDataSet";
            this.dbSAICBPOCatalogosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridCRazonSocial});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridCRazonSocial
            // 
            this.gridCRazonSocial.Caption = "Grupo";
            this.gridCRazonSocial.FieldName = "DescGrupo";
            this.gridCRazonSocial.Name = "gridCRazonSocial";
            this.gridCRazonSocial.Visible = true;
            this.gridCRazonSocial.VisibleIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(7, 53);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(47, 13);
            this.labelControl2.TabIndex = 33;
            this.labelControl2.Text = "Pantallas:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(28, 28);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(27, 13);
            this.labelControl1.TabIndex = 31;
            this.labelControl1.Text = "Area:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lblIdOperador);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.txtCveInternaOperador);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.txtTipoEncripcion);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.chkActivoNominas);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.chkConfidencial);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.chkActivo);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.txtContrasena);
            this.groupControl1.Controls.Add(this.cboIdAreaOperativa);
            this.groupControl1.Controls.Add(this.txtUsuario);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.txtCorreoElectronico);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.txtNombreOperadorCompleto);
            this.groupControl1.Controls.Add(this.cboIdPlaza);
            this.groupControl1.Controls.Add(this.txtIdOperador);
            this.groupControl1.Controls.Add(this.label9);
            this.groupControl1.Controls.Add(this.cboIdEstatusReportes);
            this.groupControl1.Controls.Add(this.cboIdGrupo);
            this.groupControl1.Controls.Add(this.label10);
            this.groupControl1.Location = new System.Drawing.Point(12, 264);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(625, 217);
            this.groupControl1.TabIndex = 32;
            this.groupControl1.Text = "Operadors";
            // 
            // stpSelObtenerGrupoTableAdapter1
            // 
            this.stpSelObtenerGrupoTableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelObtenerPantallasTableAdapter1
            // 
            this.stpSelObtenerPantallasTableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelInfoEmpleadosCorrespondenciaXEmpleadoBindingSource
            // 
            this.stpSelInfoEmpleadosCorrespondenciaXEmpleadoBindingSource.DataMember = "stpSelInfoEmpleadosCorrespondenciaXEmpleado";
            this.stpSelInfoEmpleadosCorrespondenciaXEmpleadoBindingSource.DataSource = this.dbSAICBPOCatalogosDataSet1;
            // 
            // stpSelInfoEmpleadosCorrespondenciaXEmpleadoTableAdapter
            // 
            this.stpSelInfoEmpleadosCorrespondenciaXEmpleadoTableAdapter.ClearBeforeFill = true;
            // 
            // stpSelObtenerPantallasBindingSource
            // 
            this.stpSelObtenerPantallasBindingSource.DataMember = "stpSelObtenerPantallas";
            this.stpSelObtenerPantallasBindingSource.DataSource = this.dbSAICBPOCatalogosDataSet1;
            // 
            // frmxUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 493);
            this.ControlBox = false;
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmxUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catálogo de Usuarios";
            this.Load += new System.EventHandler(this.frmxUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelGeneralUsuariosGrupoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAIC_Seguridad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sysGrupoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plazaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaOperativaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdOperador.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreOperadorCompleto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCorreoElectronico.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContrasena.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkConfidencial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActivoNominas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoEncripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCveInternaOperador.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditPantallas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkCBoxPantallas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookAreaOperativa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelObtenerGrupoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelInfoEmpleadosCorrespondenciaXEmpleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelObtenerPantallasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnNuevo;
        private DevExpress.XtraBars.BarButtonItem btnGuardar;
        private DevExpress.XtraBars.BarButtonItem btnEditar;
        private DevExpress.XtraBars.BarButtonItem btnCancelar;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnSalir;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.ComboBox cboIdEstatusReportes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboIdGrupo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboIdPlaza;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboIdAreaOperativa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIdOperador;
        private dbSAIC_Seguridad dbSAIC_Seguridad;
        private System.Windows.Forms.BindingSource stpSelGeneralUsuariosGrupoBindingSource;
        private dbSAIC_SeguridadTableAdapters.stpSelGeneralUsuariosGrupoTableAdapter stpSelGeneralUsuariosGrupoTableAdapter;
        private System.Windows.Forms.BindingSource areaOperativaBindingSource;
        private dbSAIC_SeguridadTableAdapters.AreaOperativaTableAdapter areaOperativaTableAdapter;
        private System.Windows.Forms.BindingSource plazaBindingSource;
        private dbSAIC_SeguridadTableAdapters.PlazaTableAdapter plazaTableAdapter;
        private System.Windows.Forms.BindingSource sysGrupoBindingSource;
        private dbSAIC_SeguridadTableAdapters.SysGrupoTableAdapter sysGrupoTableAdapter;
        private System.Windows.Forms.BindingSource estatusBindingSource;
        private dbSAIC_SeguridadTableAdapters.EstatusTableAdapter estatusTableAdapter;
        private Catalogos.dbSAICBPO_CatalogosValidacionDataSetTableAdapters.ValidacionesGeneralTableAdapter validacionesGeneralTableAdapter1;
        private DevExpress.XtraEditors.TextEdit txtContrasena;
        private DevExpress.XtraEditors.TextEdit txtUsuario;
        private DevExpress.XtraEditors.TextEdit txtCorreoElectronico;
        private DevExpress.XtraEditors.TextEdit txtNombreOperadorCompleto;
        private DevExpress.XtraEditors.TextEdit txtIdOperador;
        private DevExpress.XtraEditors.TextEdit txtTipoEncripcion;
        private DevExpress.XtraEditors.CheckEdit chkActivoNominas;
        private DevExpress.XtraEditors.CheckEdit chkConfidencial;
        private DevExpress.XtraEditors.CheckEdit chkActivo;
        private DevExpress.XtraEditors.TextEdit txtCveInternaOperador;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOperadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn claveInternaOperadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCompletoOperadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoElectronicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAreaOperativaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn confidencialDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activoParaNominasDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEstatusReportesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPlazaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdGrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescAreaOperativa;
        private System.Windows.Forms.DataGridViewTextBoxColumn descGrupoDataGridViewTextBoxColumn;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.MemoEdit memoEditPantallas;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.CheckedComboBoxEdit checkCBoxPantallas;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookAreaOperativa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridCRazonSocial;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private dbSAICBPOCatalogosDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelObtenerGrupoTableAdapter stpSelObtenerGrupoTableAdapter1;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelObtenerPantallasTableAdapter stpSelObtenerPantallasTableAdapter1;
        private dbSAICBPOCatalogosDataSet dbSAICBPOCatalogosDataSet1;
        private System.Windows.Forms.BindingSource stpSelObtenerGrupoBindingSource;
        private System.Windows.Forms.BindingSource stpSelInfoEmpleadosCorrespondenciaXEmpleadoBindingSource;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelInfoEmpleadosCorrespondenciaXEmpleadoTableAdapter stpSelInfoEmpleadosCorrespondenciaXEmpleadoTableAdapter;
        private System.Windows.Forms.BindingSource stpSelObtenerPantallasBindingSource;
    }
}