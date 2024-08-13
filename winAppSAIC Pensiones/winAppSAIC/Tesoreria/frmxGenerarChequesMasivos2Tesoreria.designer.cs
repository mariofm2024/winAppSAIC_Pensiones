namespace winAppSAIC.Tesoreria
{
    partial class frmxGenerarChequesMasivos2Tesoreria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmxGenerarChequesMasivos2Tesoreria));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnSalir = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.btnImprimirCheques = new DevExpress.XtraEditors.SimpleButton();
            this.txtBancoSolicitado = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.lblNoSolicitud = new System.Windows.Forms.Label();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtNoControl = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnGenerarCheques = new DevExpress.XtraEditors.SimpleButton();
            this.txtFolioLoteCargaNomina = new DevExpress.XtraEditors.TextEdit();
            this.panelControl7 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.cboCuentaBanco = new DevExpress.XtraEditors.GridLookUpEdit();
            this.stpSelCuentaBancoPorBancoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPOTesoreriaDataSet = new winAppSAIC.Tesoreria.dbSAICBPOTesoreriaDataSet();
            this.gridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNombreCuentaBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoCuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCuentaBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMoneda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblFolioChequeFinal = new DevExpress.XtraEditors.LabelControl();
            this.txtFolioFinal = new DevExpress.XtraEditors.TextEdit();
            this.cboBanco = new DevExpress.XtraEditors.LookUpEdit();
            this.stpSelBancoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPOCatalogosDataSet = new winAppSAIC.dbSAICBPOCatalogosDataSet();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.lblFolioChequeInicial = new DevExpress.XtraEditors.LabelControl();
            this.txtFolioInicial = new DevExpress.XtraEditors.TextEdit();
            this.lblFolio = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtNombreOperador = new DevExpress.XtraEditors.TextEdit();
            this.btnAsignarFolios = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTipoNomina = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtNombreComercialCliente = new DevExpress.XtraEditors.TextEdit();
            this.txtNombreComercialTenedora = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.stpSelGenerarSolicitudChequesGridControl = new DevExpress.XtraGrid.GridControl();
            this.stpSelDetalleSolicitudChequesMasivosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdSolicitudChequeDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoTransaccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreBeneficiarioTransaccionBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMontoTransaccionRetiro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.stpSelBancoTableAdapter = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelBancoTableAdapter();
            this.stpSelDetalleSolicitudChequesMasivosTableAdapter = new winAppSAIC.Tesoreria.dbSAICBPOTesoreriaDataSetTableAdapters.stpSelDetalleSolicitudChequesMasivosTableAdapter();
            this.actualizacionesTesoreriaTableAdapter1 = new winAppSAIC.Tesoreria.dbSAICBPOActualizacionesTesoreriaDataSetTableAdapters.ActualizacionesTesoreriaTableAdapter();
            this.stpSelCuentaBancoPorBancoTableAdapter = new winAppSAIC.Tesoreria.dbSAICBPOTesoreriaDataSetTableAdapters.stpSelCuentaBancoPorBancoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBancoSolicitado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoControl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFolioLoteCargaNomina.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl7)).BeginInit();
            this.panelControl7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboCuentaBanco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelCuentaBancoPorBancoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOTesoreriaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFolioFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboBanco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelBancoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFolioInicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreOperador.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoNomina.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreComercialCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreComercialTenedora.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelGenerarSolicitudChequesGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelDetalleSolicitudChequesMasivosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.btnSalir.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSalir.Glyph")));
            this.btnSalir.Id = 0;
            this.btnSalir.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnSalir.LargeGlyph")));
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSalir_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(981, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 462);
            this.barDockControlBottom.Size = new System.Drawing.Size(981, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 431);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(981, 31);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 431);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 31);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.btnImprimirCheques);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtBancoSolicitado);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl9);
            this.splitContainerControl1.Panel1.Controls.Add(this.lblNoSolicitud);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl8);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtNoControl);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl4);
            this.splitContainerControl1.Panel1.Controls.Add(this.btnGenerarCheques);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtFolioLoteCargaNomina);
            this.splitContainerControl1.Panel1.Controls.Add(this.panelControl7);
            this.splitContainerControl1.Panel1.Controls.Add(this.lblFolio);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl1);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtNombreOperador);
            this.splitContainerControl1.Panel1.Controls.Add(this.btnAsignarFolios);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtTipoNomina);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl3);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtNombreComercialCliente);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtNombreComercialTenedora);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl5);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.panelControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(981, 431);
            this.splitContainerControl1.SplitterPosition = 185;
            this.splitContainerControl1.TabIndex = 11;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // btnImprimirCheques
            // 
            this.btnImprimirCheques.Appearance.Options.UseTextOptions = true;
            this.btnImprimirCheques.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnImprimirCheques.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimirCheques.Image")));
            this.btnImprimirCheques.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnImprimirCheques.Location = new System.Drawing.Point(778, 87);
            this.btnImprimirCheques.Name = "btnImprimirCheques";
            this.btnImprimirCheques.Size = new System.Drawing.Size(159, 25);
            this.btnImprimirCheques.TabIndex = 43;
            this.btnImprimirCheques.Text = "&3) Imprimir Cheques";
            this.btnImprimirCheques.Visible = false;
            this.btnImprimirCheques.Click += new System.EventHandler(this.btnImprimirCheques_Click);
            // 
            // txtBancoSolicitado
            // 
            this.txtBancoSolicitado.Enabled = false;
            this.txtBancoSolicitado.Location = new System.Drawing.Point(616, 114);
            this.txtBancoSolicitado.Name = "txtBancoSolicitado";
            this.txtBancoSolicitado.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtBancoSolicitado.Properties.Appearance.Options.UseBackColor = true;
            this.txtBancoSolicitado.Size = new System.Drawing.Size(136, 20);
            this.txtBancoSolicitado.TabIndex = 15;
            this.txtBancoSolicitado.TabStop = false;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(533, 119);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(77, 13);
            this.labelControl9.TabIndex = 14;
            this.labelControl9.Text = "Banco Solicitado";
            // 
            // lblNoSolicitud
            // 
            this.lblNoSolicitud.AutoSize = true;
            this.lblNoSolicitud.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblNoSolicitud.Location = new System.Drawing.Point(133, 15);
            this.lblNoSolicitud.Name = "lblNoSolicitud";
            this.lblNoSolicitud.Size = new System.Drawing.Size(69, 13);
            this.lblNoSolicitud.TabIndex = 1;
            this.lblNoSolicitud.Text = "NoSolicitud";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl8.Location = new System.Drawing.Point(60, 15);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(68, 13);
            this.labelControl8.TabIndex = 0;
            this.labelControl8.Text = "No. Solicitud";
            // 
            // txtNoControl
            // 
            this.txtNoControl.Enabled = false;
            this.txtNoControl.Location = new System.Drawing.Point(616, 88);
            this.txtNoControl.Name = "txtNoControl";
            this.txtNoControl.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtNoControl.Properties.Appearance.Options.UseBackColor = true;
            this.txtNoControl.Size = new System.Drawing.Size(136, 20);
            this.txtNoControl.TabIndex = 13;
            this.txtNoControl.TabStop = false;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(495, 92);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(115, 13);
            this.labelControl4.TabIndex = 12;
            this.labelControl4.Text = "No. Control Orden Pago";
            // 
            // btnGenerarCheques
            // 
            this.btnGenerarCheques.Appearance.Options.UseTextOptions = true;
            this.btnGenerarCheques.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnGenerarCheques.Enabled = false;
            this.btnGenerarCheques.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerarCheques.Image")));
            this.btnGenerarCheques.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnGenerarCheques.Location = new System.Drawing.Point(778, 51);
            this.btnGenerarCheques.Name = "btnGenerarCheques";
            this.btnGenerarCheques.Size = new System.Drawing.Size(159, 30);
            this.btnGenerarCheques.TabIndex = 17;
            this.btnGenerarCheques.Text = "&2 ) Generar Cheques";
            this.btnGenerarCheques.Click += new System.EventHandler(this.btnGenerarCheques_Click);
            // 
            // txtFolioLoteCargaNomina
            // 
            this.txtFolioLoteCargaNomina.Enabled = false;
            this.txtFolioLoteCargaNomina.Location = new System.Drawing.Point(134, 37);
            this.txtFolioLoteCargaNomina.Name = "txtFolioLoteCargaNomina";
            this.txtFolioLoteCargaNomina.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtFolioLoteCargaNomina.Properties.Appearance.Options.UseBackColor = true;
            this.txtFolioLoteCargaNomina.Size = new System.Drawing.Size(225, 20);
            this.txtFolioLoteCargaNomina.TabIndex = 3;
            this.txtFolioLoteCargaNomina.TabStop = false;
            // 
            // panelControl7
            // 
            this.panelControl7.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.panelControl7.Appearance.Options.UseBackColor = true;
            this.panelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl7.Controls.Add(this.labelControl7);
            this.panelControl7.Controls.Add(this.cboCuentaBanco);
            this.panelControl7.Controls.Add(this.lblFolioChequeFinal);
            this.panelControl7.Controls.Add(this.txtFolioFinal);
            this.panelControl7.Controls.Add(this.cboBanco);
            this.panelControl7.Controls.Add(this.labelControl6);
            this.panelControl7.Controls.Add(this.lblFolioChequeInicial);
            this.panelControl7.Controls.Add(this.txtFolioInicial);
            this.panelControl7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl7.Location = new System.Drawing.Point(0, 150);
            this.panelControl7.Name = "panelControl7";
            this.panelControl7.Size = new System.Drawing.Size(981, 35);
            this.panelControl7.TabIndex = 0;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(629, 11);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(82, 13);
            this.labelControl7.TabIndex = 7;
            this.labelControl7.Text = "Cuenta de Banco";
            // 
            // cboCuentaBanco
            // 
            this.cboCuentaBanco.EditValue = "";
            this.cboCuentaBanco.Location = new System.Drawing.Point(717, 8);
            this.cboCuentaBanco.Name = "cboCuentaBanco";
            this.cboCuentaBanco.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboCuentaBanco.Properties.DataSource = this.stpSelCuentaBancoPorBancoBindingSource;
            this.cboCuentaBanco.Properties.DisplayMember = "NombreCuentaBanco";
            this.cboCuentaBanco.Properties.ValueMember = "IdCuentaBanco";
            this.cboCuentaBanco.Properties.View = this.gridLookUpEdit2View;
            this.cboCuentaBanco.Size = new System.Drawing.Size(250, 20);
            this.cboCuentaBanco.TabIndex = 8;
            this.cboCuentaBanco.Tag = "Cuenta de Banco";
            // 
            // stpSelCuentaBancoPorBancoBindingSource
            // 
            this.stpSelCuentaBancoPorBancoBindingSource.DataMember = "stpSelCuentaBancoPorBanco";
            this.stpSelCuentaBancoPorBancoBindingSource.DataSource = this.dbSAICBPOTesoreriaDataSet;
            // 
            // dbSAICBPOTesoreriaDataSet
            // 
            this.dbSAICBPOTesoreriaDataSet.DataSetName = "dbSAICBPOTesoreriaDataSet";
            this.dbSAICBPOTesoreriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit2View
            // 
            this.gridLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNombreCuentaBanco,
            this.colNoCuenta,
            this.colIdCuentaBanco,
            this.colIdMoneda});
            this.gridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit2View.Name = "gridLookUpEdit2View";
            this.gridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // colNombreCuentaBanco
            // 
            this.colNombreCuentaBanco.Caption = "Nombre Cuenta Banco";
            this.colNombreCuentaBanco.FieldName = "NombreCuentaBanco";
            this.colNombreCuentaBanco.Name = "colNombreCuentaBanco";
            this.colNombreCuentaBanco.OptionsColumn.AllowEdit = false;
            this.colNombreCuentaBanco.OptionsColumn.FixedWidth = true;
            this.colNombreCuentaBanco.Visible = true;
            this.colNombreCuentaBanco.VisibleIndex = 0;
            this.colNombreCuentaBanco.Width = 300;
            // 
            // colNoCuenta
            // 
            this.colNoCuenta.Caption = "No. Cuenta";
            this.colNoCuenta.FieldName = "NoCuenta";
            this.colNoCuenta.Name = "colNoCuenta";
            this.colNoCuenta.OptionsColumn.AllowEdit = false;
            this.colNoCuenta.OptionsColumn.FixedWidth = true;
            this.colNoCuenta.Visible = true;
            this.colNoCuenta.VisibleIndex = 1;
            this.colNoCuenta.Width = 84;
            // 
            // colIdCuentaBanco
            // 
            this.colIdCuentaBanco.FieldName = "IdCuentaBanco";
            this.colIdCuentaBanco.Name = "colIdCuentaBanco";
            // 
            // colIdMoneda
            // 
            this.colIdMoneda.Caption = "Moneda";
            this.colIdMoneda.FieldName = "IdMoneda";
            this.colIdMoneda.Name = "colIdMoneda";
            this.colIdMoneda.OptionsColumn.AllowEdit = false;
            this.colIdMoneda.Visible = true;
            this.colIdMoneda.VisibleIndex = 2;
            // 
            // lblFolioChequeFinal
            // 
            this.lblFolioChequeFinal.Location = new System.Drawing.Point(211, 11);
            this.lblFolioChequeFinal.Name = "lblFolioChequeFinal";
            this.lblFolioChequeFinal.Size = new System.Drawing.Size(87, 13);
            this.lblFolioChequeFinal.TabIndex = 3;
            this.lblFolioChequeFinal.Text = "Folio Cheque Final";
            // 
            // txtFolioFinal
            // 
            this.txtFolioFinal.Location = new System.Drawing.Point(305, 8);
            this.txtFolioFinal.Name = "txtFolioFinal";
            this.txtFolioFinal.Properties.Mask.BeepOnError = true;
            this.txtFolioFinal.Properties.Mask.EditMask = "\\d{1,10}";
            this.txtFolioFinal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtFolioFinal.Size = new System.Drawing.Size(70, 20);
            this.txtFolioFinal.TabIndex = 4;
            this.txtFolioFinal.Tag = "Folio Cheque Final";
            // 
            // cboBanco
            // 
            this.cboBanco.Location = new System.Drawing.Point(416, 8);
            this.cboBanco.MenuManager = this.barManager1;
            this.cboBanco.Name = "cboBanco";
            this.cboBanco.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboBanco.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdBanco", "Id Banco", 65, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NombreBanco", "Nombre Banco", 120, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.cboBanco.Properties.DataSource = this.stpSelBancoBindingSource;
            this.cboBanco.Properties.DisplayMember = "NombreBanco";
            this.cboBanco.Properties.NullText = "";
            this.cboBanco.Properties.ValueMember = "IdBanco";
            this.cboBanco.Size = new System.Drawing.Size(207, 20);
            this.cboBanco.TabIndex = 6;
            this.cboBanco.Tag = "Banco";
            this.cboBanco.EditValueChanged += new System.EventHandler(this.cboIdBancoAsignado_EditValueChanged);
            // 
            // stpSelBancoBindingSource
            // 
            this.stpSelBancoBindingSource.DataMember = "stpSelBanco";
            this.stpSelBancoBindingSource.DataSource = this.dbSAICBPOCatalogosDataSet;
            // 
            // dbSAICBPOCatalogosDataSet
            // 
            this.dbSAICBPOCatalogosDataSet.DataSetName = "dbSAICBPOCatalogosDataSet";
            this.dbSAICBPOCatalogosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(381, 11);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(29, 13);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "Banco";
            // 
            // lblFolioChequeInicial
            // 
            this.lblFolioChequeInicial.Location = new System.Drawing.Point(36, 11);
            this.lblFolioChequeInicial.Name = "lblFolioChequeInicial";
            this.lblFolioChequeInicial.Size = new System.Drawing.Size(92, 13);
            this.lblFolioChequeInicial.TabIndex = 1;
            this.lblFolioChequeInicial.Tag = "";
            this.lblFolioChequeInicial.Text = "Folio Cheque Inicial";
            // 
            // txtFolioInicial
            // 
            this.txtFolioInicial.Location = new System.Drawing.Point(134, 8);
            this.txtFolioInicial.Name = "txtFolioInicial";
            this.txtFolioInicial.Properties.Mask.BeepOnError = true;
            this.txtFolioInicial.Properties.Mask.EditMask = "\\d{1,10}";
            this.txtFolioInicial.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtFolioInicial.Size = new System.Drawing.Size(70, 20);
            this.txtFolioInicial.TabIndex = 2;
            this.txtFolioInicial.Tag = "Folio Cheque Inicial";
            // 
            // lblFolio
            // 
            this.lblFolio.Location = new System.Drawing.Point(12, 40);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(116, 13);
            this.lblFolio.TabIndex = 2;
            this.lblFolio.Text = "Folio Lote Carga Nómina";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(82, 67);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Tenedora";
            // 
            // txtNombreOperador
            // 
            this.txtNombreOperador.Enabled = false;
            this.txtNombreOperador.Location = new System.Drawing.Point(134, 113);
            this.txtNombreOperador.Name = "txtNombreOperador";
            this.txtNombreOperador.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtNombreOperador.Properties.Appearance.Options.UseBackColor = true;
            this.txtNombreOperador.Size = new System.Drawing.Size(351, 20);
            this.txtNombreOperador.TabIndex = 9;
            this.txtNombreOperador.TabStop = false;
            // 
            // btnAsignarFolios
            // 
            this.btnAsignarFolios.Appearance.Options.UseTextOptions = true;
            this.btnAsignarFolios.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnAsignarFolios.Image = ((System.Drawing.Image)(resources.GetObject("btnAsignarFolios.Image")));
            this.btnAsignarFolios.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnAsignarFolios.Location = new System.Drawing.Point(778, 15);
            this.btnAsignarFolios.Name = "btnAsignarFolios";
            this.btnAsignarFolios.Size = new System.Drawing.Size(159, 30);
            this.btnAsignarFolios.TabIndex = 16;
            this.btnAsignarFolios.Text = "&1 ) Asignar Folios Cheques";
            this.btnAsignarFolios.Click += new System.EventHandler(this.btnAsignarFolios_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(95, 92);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(33, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Cliente";
            // 
            // txtTipoNomina
            // 
            this.txtTipoNomina.Enabled = false;
            this.txtTipoNomina.Location = new System.Drawing.Point(616, 63);
            this.txtTipoNomina.Name = "txtTipoNomina";
            this.txtTipoNomina.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtTipoNomina.Properties.Appearance.Options.UseBackColor = true;
            this.txtTipoNomina.Size = new System.Drawing.Size(136, 20);
            this.txtTipoNomina.TabIndex = 11;
            this.txtTipoNomina.TabStop = false;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(82, 117);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(46, 13);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Operador";
            // 
            // txtNombreComercialCliente
            // 
            this.txtNombreComercialCliente.Enabled = false;
            this.txtNombreComercialCliente.Location = new System.Drawing.Point(134, 88);
            this.txtNombreComercialCliente.Name = "txtNombreComercialCliente";
            this.txtNombreComercialCliente.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtNombreComercialCliente.Properties.Appearance.Options.UseBackColor = true;
            this.txtNombreComercialCliente.Size = new System.Drawing.Size(351, 20);
            this.txtNombreComercialCliente.TabIndex = 7;
            this.txtNombreComercialCliente.TabStop = false;
            // 
            // txtNombreComercialTenedora
            // 
            this.txtNombreComercialTenedora.Enabled = false;
            this.txtNombreComercialTenedora.Location = new System.Drawing.Point(134, 63);
            this.txtNombreComercialTenedora.Name = "txtNombreComercialTenedora";
            this.txtNombreComercialTenedora.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtNombreComercialTenedora.Properties.Appearance.Options.UseBackColor = true;
            this.txtNombreComercialTenedora.Size = new System.Drawing.Size(351, 20);
            this.txtNombreComercialTenedora.TabIndex = 5;
            this.txtNombreComercialTenedora.TabStop = false;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(552, 67);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(58, 13);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Tipo Nómina";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.stpSelGenerarSolicitudChequesGridControl);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(981, 241);
            this.panelControl1.TabIndex = 4;
            // 
            // stpSelGenerarSolicitudChequesGridControl
            // 
            this.stpSelGenerarSolicitudChequesGridControl.DataSource = this.stpSelDetalleSolicitudChequesMasivosBindingSource;
            this.stpSelGenerarSolicitudChequesGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stpSelGenerarSolicitudChequesGridControl.Location = new System.Drawing.Point(2, 2);
            this.stpSelGenerarSolicitudChequesGridControl.MainView = this.gridView1;
            this.stpSelGenerarSolicitudChequesGridControl.Name = "stpSelGenerarSolicitudChequesGridControl";
            this.stpSelGenerarSolicitudChequesGridControl.Size = new System.Drawing.Size(977, 237);
            this.stpSelGenerarSolicitudChequesGridControl.TabIndex = 0;
            this.stpSelGenerarSolicitudChequesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // stpSelDetalleSolicitudChequesMasivosBindingSource
            // 
            this.stpSelDetalleSolicitudChequesMasivosBindingSource.DataMember = "stpSelDetalleSolicitudChequesMasivos";
            this.stpSelDetalleSolicitudChequesMasivosBindingSource.DataSource = this.dbSAICBPOTesoreriaDataSet;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdSolicitudChequeDetail,
            this.colNoTransaccion,
            this.colNombreBeneficiarioTransaccionBanco,
            this.colMontoTransaccionRetiro});
            this.gridView1.GridControl = this.stpSelGenerarSolicitudChequesGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIdSolicitudChequeDetail
            // 
            this.colIdSolicitudChequeDetail.AppearanceCell.Options.UseTextOptions = true;
            this.colIdSolicitudChequeDetail.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIdSolicitudChequeDetail.Caption = "No. Control SAIC";
            this.colIdSolicitudChequeDetail.FieldName = "IdSolicitudChequeDetail";
            this.colIdSolicitudChequeDetail.Name = "colIdSolicitudChequeDetail";
            this.colIdSolicitudChequeDetail.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "IdSolicitudChequeDetail", "No. Registros: {0}")});
            this.colIdSolicitudChequeDetail.Visible = true;
            this.colIdSolicitudChequeDetail.VisibleIndex = 1;
            this.colIdSolicitudChequeDetail.Width = 100;
            // 
            // colNoTransaccion
            // 
            this.colNoTransaccion.AppearanceCell.Options.UseTextOptions = true;
            this.colNoTransaccion.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNoTransaccion.Caption = "No. Cheque";
            this.colNoTransaccion.FieldName = "NoTransaccion";
            this.colNoTransaccion.Name = "colNoTransaccion";
            this.colNoTransaccion.Visible = true;
            this.colNoTransaccion.VisibleIndex = 2;
            this.colNoTransaccion.Width = 100;
            // 
            // colNombreBeneficiarioTransaccionBanco
            // 
            this.colNombreBeneficiarioTransaccionBanco.Caption = "Beneficiario";
            this.colNombreBeneficiarioTransaccionBanco.FieldName = "NombreBeneficiarioTransaccionBanco";
            this.colNombreBeneficiarioTransaccionBanco.Name = "colNombreBeneficiarioTransaccionBanco";
            this.colNombreBeneficiarioTransaccionBanco.Visible = true;
            this.colNombreBeneficiarioTransaccionBanco.VisibleIndex = 3;
            this.colNombreBeneficiarioTransaccionBanco.Width = 400;
            // 
            // colMontoTransaccionRetiro
            // 
            this.colMontoTransaccionRetiro.Caption = "Monto a Pagar";
            this.colMontoTransaccionRetiro.DisplayFormat.FormatString = "N2";
            this.colMontoTransaccionRetiro.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMontoTransaccionRetiro.FieldName = "MontoTransaccionRetiro";
            this.colMontoTransaccionRetiro.Name = "colMontoTransaccionRetiro";
            this.colMontoTransaccionRetiro.Visible = true;
            this.colMontoTransaccionRetiro.VisibleIndex = 4;
            this.colMontoTransaccionRetiro.Width = 100;
            // 
            // stpSelBancoTableAdapter
            // 
            this.stpSelBancoTableAdapter.ClearBeforeFill = true;
            // 
            // stpSelDetalleSolicitudChequesMasivosTableAdapter
            // 
            this.stpSelDetalleSolicitudChequesMasivosTableAdapter.ClearBeforeFill = true;
            // 
            // stpSelCuentaBancoPorBancoTableAdapter
            // 
            this.stpSelCuentaBancoPorBancoTableAdapter.ClearBeforeFill = true;
            // 
            // frmxGenerarChequesMasivos2Tesoreria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 462);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmxGenerarChequesMasivos2Tesoreria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generar Cheques Masivos para Tesoreria";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmxGenerarChequesMasivos2Tesoreria_FormClosing);
            this.Load += new System.EventHandler(this.frmxGenerarChequesMasivos2Tesoreria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtBancoSolicitado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoControl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFolioLoteCargaNomina.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl7)).EndInit();
            this.panelControl7.ResumeLayout(false);
            this.panelControl7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboCuentaBanco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelCuentaBancoPorBancoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOTesoreriaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFolioFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboBanco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelBancoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFolioInicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreOperador.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoNomina.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreComercialCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreComercialTenedora.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stpSelGenerarSolicitudChequesGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelDetalleSolicitudChequesMasivosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
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
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.PanelControl panelControl7;
        private DevExpress.XtraEditors.LookUpEdit cboBanco;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton btnAsignarFolios;
        private DevExpress.XtraEditors.LabelControl lblFolioChequeInicial;
        private DevExpress.XtraEditors.TextEdit txtFolioInicial;
        private DevExpress.XtraEditors.LabelControl lblFolio;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtNombreOperador;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtTipoNomina;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtNombreComercialCliente;
        private DevExpress.XtraEditors.TextEdit txtNombreComercialTenedora;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl stpSelGenerarSolicitudChequesGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl lblFolioChequeFinal;
        private DevExpress.XtraEditors.TextEdit txtFolioFinal;
        private DevExpress.XtraEditors.TextEdit txtFolioLoteCargaNomina;
        private DevExpress.XtraEditors.SimpleButton btnGenerarCheques;
        private DevExpress.XtraEditors.TextEdit txtNoControl;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtBancoSolicitado;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.Label lblNoSolicitud;
        private dbSAICBPOCatalogosDataSet dbSAICBPOCatalogosDataSet;
        private System.Windows.Forms.BindingSource stpSelBancoBindingSource;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelBancoTableAdapter stpSelBancoTableAdapter;
        private System.Windows.Forms.BindingSource stpSelDetalleSolicitudChequesMasivosBindingSource;
        private dbSAICBPOTesoreriaDataSet dbSAICBPOTesoreriaDataSet;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSolicitudChequeDetail;
        private DevExpress.XtraGrid.Columns.GridColumn colNoTransaccion;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreBeneficiarioTransaccionBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colMontoTransaccionRetiro;
        private dbSAICBPOTesoreriaDataSetTableAdapters.stpSelDetalleSolicitudChequesMasivosTableAdapter stpSelDetalleSolicitudChequesMasivosTableAdapter;
        private dbSAICBPOActualizacionesTesoreriaDataSetTableAdapters.ActualizacionesTesoreriaTableAdapter actualizacionesTesoreriaTableAdapter1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.GridLookUpEdit cboCuentaBanco;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit2View;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreCuentaBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colNoCuenta;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCuentaBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMoneda;
        private System.Windows.Forms.BindingSource stpSelCuentaBancoPorBancoBindingSource;
        private dbSAICBPOTesoreriaDataSetTableAdapters.stpSelCuentaBancoPorBancoTableAdapter stpSelCuentaBancoPorBancoTableAdapter;
        private DevExpress.XtraEditors.SimpleButton btnImprimirCheques;
    }
}