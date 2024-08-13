namespace winAppSAIC.Tesoreria
{
    partial class frmxEmisionCheques
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmxEmisionCheques));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.cboFecha = new DevExpress.XtraEditors.DateEdit();
            this.cboCuentaBanco = new DevExpress.XtraEditors.GridLookUpEdit();
            this.stpSelCuentaBancoPorBancoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPOTesoreriaDataSet = new winAppSAIC.Tesoreria.dbSAICBPOTesoreriaDataSet();
            this.gridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNombreCuentaBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoCuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCuentaBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMoneda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtNoCheque = new DevExpress.XtraEditors.SpinEdit();
            this.txtImporte = new DevExpress.XtraEditors.SpinEdit();
            this.txtBeneficiarioCheque = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtOtroConcepto = new DevExpress.XtraEditors.MemoEdit();
            this.txtImporteLetra = new DevExpress.XtraEditors.MemoEdit();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cboTipoImpresora = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.btnImprimirCheque = new DevExpress.XtraEditors.SimpleButton();
            this.btnNuevoCheque = new DevExpress.XtraEditors.SimpleButton();
            this.cboBanco = new DevExpress.XtraEditors.GridLookUpEdit();
            this.stpSelBancoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPOCatalogosDataSet = new winAppSAIC.dbSAICBPOCatalogosDataSet();
            this.idBancoGridLookUpEditView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.lblMoneda = new DevExpress.XtraEditors.LabelControl();
            this.cboCategoriaTransaccionBanco = new DevExpress.XtraEditors.GridLookUpEdit();
            this.stpSelCategoriaTransaccionBancoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCategoriaTransaccionBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescCategoriaTransaccionBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboSubCategoriaTransaccionBanco = new DevExpress.XtraEditors.GridLookUpEdit();
            this.stpSelSubCategoriaTransaccionBancoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdSubCategoriaTransaccionBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescSubCategoriaTransaccionBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.lblFolioMovimiento = new DevExpress.XtraEditors.LabelControl();
            this.btnBuscarCheque = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelarCaptura = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardarCheque = new DevExpress.XtraEditors.SimpleButton();
            this.btnImprimirPoliza = new DevExpress.XtraEditors.SimpleButton();
            this.chkCancelado = new System.Windows.Forms.CheckBox();
            this.btnCancelarCheque = new DevExpress.XtraEditors.SimpleButton();
            this.txtBeneficiarioPoliza = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.lblFolio = new DevExpress.XtraEditors.LabelControl();
            this.cboFolioLoteCargaNomina = new DevExpress.XtraEditors.GridLookUpEdit();
            this.stpSelFolioLoteCargaNominaParaChequesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idLoteCargaNominaGridLookUpEditView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdLoteCargaNomina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFolioLoteCargaNomina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenedora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOperador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.txtObservaciones = new DevExpress.XtraEditors.MemoEdit();
            this.chkUtilizarFolioLoteNomina = new System.Windows.Forms.CheckBox();
            this.btnEditarCheque = new DevExpress.XtraEditors.SimpleButton();
            this.btnImpresionMasivaPolizas = new DevExpress.XtraEditors.SimpleButton();
            this.lblClienteProveedor = new DevExpress.XtraEditors.LabelControl();
            this.cboClienteProveedor = new DevExpress.XtraEditors.GridLookUpEdit();
            this.stpSelClienteProveedorChequesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRazonSocial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreComercial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dbSAICBPOActualizacionesTesoreriaDataSet1 = new winAppSAIC.Tesoreria.dbSAICBPOActualizacionesTesoreriaDataSet();
            this.actualizacionesTesoreriaTableAdapter1 = new winAppSAIC.Tesoreria.dbSAICBPOActualizacionesTesoreriaDataSetTableAdapters.ActualizacionesTesoreriaTableAdapter();
            this.chkAjusteContable = new System.Windows.Forms.CheckBox();
            this.chkChequeConciliado = new System.Windows.Forms.CheckBox();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.cboEstatusCheque = new DevExpress.XtraEditors.GridLookUpEdit();
            this.stpSelEstatusChequesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.stpSelBancoTableAdapter = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelBancoTableAdapter();
            this.stpSelCategoriaTransaccionBancoTableAdapter = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelCategoriaTransaccionBancoTableAdapter();
            this.stpSelSubCategoriaTransaccionBancoTableAdapter = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelSubCategoriaTransaccionBancoTableAdapter();
            this.beneficiarioTransaccionBancoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.beneficiarioTransaccionBancoTableAdapter = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.BeneficiarioTransaccionBancoTableAdapter();
            this.stpSelCuentaBancoPorBancoTableAdapter = new winAppSAIC.Tesoreria.dbSAICBPOTesoreriaDataSetTableAdapters.stpSelCuentaBancoPorBancoTableAdapter();
            this.stpSelInfoCuentaBancoTableAdapter1 = new winAppSAIC.Tesoreria.dbSAICBPOTesoreriaDataSetTableAdapters.stpSelInfoCuentaBancoTableAdapter();
            this.stpSelDetalleChequeTableAdapter1 = new winAppSAIC.Tesoreria.dbSAICBPOTesoreriaDataSetTableAdapters.stpSelDetalleChequeTableAdapter();
            this.stpSelFolioLoteCargaNominaParaChequesTableAdapter = new winAppSAIC.Tesoreria.dbSAICBPOTesoreriaDataSetTableAdapters.stpSelFolioLoteCargaNominaParaChequesTableAdapter();
            this.stpSelClienteProveedorChequesTableAdapter = new winAppSAIC.Tesoreria.dbSAICBPOTesoreriaDataSetTableAdapters.stpSelClienteProveedorChequesTableAdapter();
            this.stpSelClienteProveedorChequesTableAdapter1 = new winAppSAIC.Tesoreria.dbSAICBPOTesoreriaDataSetTableAdapters.stpSelClienteProveedorChequesTableAdapter();
            this.stpSelEstatusChequesTableAdapter = new winAppSAIC.Tesoreria.dbSAICBPOTesoreriaDataSetTableAdapters.stpSelEstatusChequesTableAdapter();
            this.splashSMCargando = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::winAppSAIC.frmxCargandoInformacion), true, true);
            this.btnImprimirChequesMasivos = new DevExpress.XtraEditors.SimpleButton();
            this.chFormato = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.cboFecha.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCuentaBanco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelCuentaBancoPorBancoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOTesoreriaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoCheque.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImporte.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBeneficiarioCheque.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOtroConcepto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImporteLetra.Properties)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboBanco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelBancoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idBancoGridLookUpEditView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCategoriaTransaccionBanco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelCategoriaTransaccionBancoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSubCategoriaTransaccionBanco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelSubCategoriaTransaccionBancoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBeneficiarioPoliza.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFolioLoteCargaNomina.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelFolioLoteCargaNominaParaChequesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idLoteCargaNominaGridLookUpEditView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservaciones.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboClienteProveedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelClienteProveedorChequesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOActualizacionesTesoreriaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboEstatusCheque.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelEstatusChequesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beneficiarioTransaccionBancoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(16, 64);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(69, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Fecha Cheque";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(16, 88);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(29, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Banco";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(16, 193);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(57, 13);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "No. Cheque";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(16, 219);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(38, 13);
            this.labelControl4.TabIndex = 16;
            this.labelControl4.Text = "Importe";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(16, 322);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(95, 13);
            this.labelControl5.TabIndex = 22;
            this.labelControl5.Text = "Beneficiario Cheque";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(16, 374);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(85, 13);
            this.labelControl6.TabIndex = 26;
            this.labelControl6.Text = "Clasificación Mov.";
            // 
            // cboFecha
            // 
            this.cboFecha.EditValue = null;
            this.cboFecha.Location = new System.Drawing.Point(138, 61);
            this.cboFecha.Name = "cboFecha";
            this.cboFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboFecha.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboFecha.Size = new System.Drawing.Size(100, 20);
            this.cboFecha.TabIndex = 4;
            // 
            // cboCuentaBanco
            // 
            this.cboCuentaBanco.EditValue = "";
            this.cboCuentaBanco.Location = new System.Drawing.Point(138, 111);
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
            this.cboCuentaBanco.EditValueChanged += new System.EventHandler(this.cboCuentaBanco_EditValueChanged);
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
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(16, 115);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(82, 13);
            this.labelControl7.TabIndex = 7;
            this.labelControl7.Text = "Cuenta de Banco";
            // 
            // txtNoCheque
            // 
            this.txtNoCheque.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtNoCheque.Location = new System.Drawing.Point(138, 190);
            this.txtNoCheque.Name = "txtNoCheque";
            this.txtNoCheque.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNoCheque.Properties.Mask.EditMask = "n0";
            this.txtNoCheque.Size = new System.Drawing.Size(100, 20);
            this.txtNoCheque.TabIndex = 15;
            this.txtNoCheque.Tag = "No. Cheque";
            // 
            // txtImporte
            // 
            this.txtImporte.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtImporte.Location = new System.Drawing.Point(138, 215);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtImporte.Properties.DisplayFormat.FormatString = "C2";
            this.txtImporte.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtImporte.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtImporte.Size = new System.Drawing.Size(100, 20);
            this.txtImporte.TabIndex = 17;
            this.txtImporte.Tag = "Importe";
            this.txtImporte.Leave += new System.EventHandler(this.txtImporte_Leave);
            // 
            // txtBeneficiarioCheque
            // 
            this.txtBeneficiarioCheque.Location = new System.Drawing.Point(138, 319);
            this.txtBeneficiarioCheque.Name = "txtBeneficiarioCheque";
            this.txtBeneficiarioCheque.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBeneficiarioCheque.Size = new System.Drawing.Size(409, 20);
            this.txtBeneficiarioCheque.TabIndex = 23;
            this.txtBeneficiarioCheque.Tag = "Beneficiario Cheque";
            this.txtBeneficiarioCheque.EditValueChanged += new System.EventHandler(this.txtBeneficiarioCheque_EditValueChanged);
            this.txtBeneficiarioCheque.TextChanged += new System.EventHandler(this.txtBeneficiarioCheque_TextChanged);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(16, 245);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(86, 13);
            this.labelControl8.TabIndex = 19;
            this.labelControl8.Text = "Importe con Letra";
            // 
            // txtOtroConcepto
            // 
            this.txtOtroConcepto.Location = new System.Drawing.Point(138, 423);
            this.txtOtroConcepto.Name = "txtOtroConcepto";
            this.txtOtroConcepto.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtOtroConcepto.Size = new System.Drawing.Size(409, 50);
            this.txtOtroConcepto.TabIndex = 31;
            this.txtOtroConcepto.Tag = "Otro Concepto";
            // 
            // txtImporteLetra
            // 
            this.txtImporteLetra.Enabled = false;
            this.txtImporteLetra.Location = new System.Drawing.Point(138, 242);
            this.txtImporteLetra.Name = "txtImporteLetra";
            this.txtImporteLetra.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtImporteLetra.Properties.ReadOnly = true;
            this.txtImporteLetra.Size = new System.Drawing.Size(409, 46);
            this.txtImporteLetra.TabIndex = 20;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.cboTipoImpresora,
            this.toolStripSeparator1,
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(700, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(117, 22);
            this.toolStripLabel1.Text = "Impresora a utilizar:";
            // 
            // cboTipoImpresora
            // 
            this.cboTipoImpresora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoImpresora.Name = "cboTipoImpresora";
            this.cboTipoImpresora.Size = new System.Drawing.Size(300, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::winAppSAIC.Properties.Resources.Salir24x24;
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(49, 22);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnImprimirCheque
            // 
            this.btnImprimirCheque.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimirCheque.ImageOptions.Image")));
            this.btnImprimirCheque.Location = new System.Drawing.Point(562, 193);
            this.btnImprimirCheque.Name = "btnImprimirCheque";
            this.btnImprimirCheque.Size = new System.Drawing.Size(120, 25);
            this.btnImprimirCheque.TabIndex = 42;
            this.btnImprimirCheque.Text = "Imprimir &Cheque";
            this.btnImprimirCheque.Click += new System.EventHandler(this.btnImprimirCheque_Click);
            // 
            // btnNuevoCheque
            // 
            this.btnNuevoCheque.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoCheque.ImageOptions.Image")));
            this.btnNuevoCheque.Location = new System.Drawing.Point(562, 51);
            this.btnNuevoCheque.Name = "btnNuevoCheque";
            this.btnNuevoCheque.Size = new System.Drawing.Size(120, 25);
            this.btnNuevoCheque.TabIndex = 38;
            this.btnNuevoCheque.Text = "&Nuevo Cheque";
            this.btnNuevoCheque.Click += new System.EventHandler(this.btnNuevoCheque_Click);
            // 
            // cboBanco
            // 
            this.cboBanco.EditValue = "";
            this.cboBanco.Location = new System.Drawing.Point(138, 85);
            this.cboBanco.Name = "cboBanco";
            this.cboBanco.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboBanco.Properties.DataSource = this.stpSelBancoBindingSource;
            this.cboBanco.Properties.DisplayMember = "NombreBanco";
            this.cboBanco.Properties.ValueMember = "IdBanco";
            this.cboBanco.Properties.View = this.idBancoGridLookUpEditView;
            this.cboBanco.Size = new System.Drawing.Size(250, 20);
            this.cboBanco.TabIndex = 6;
            this.cboBanco.Tag = "Banco";
            this.cboBanco.EditValueChanged += new System.EventHandler(this.cboBanco_EditValueChanged);
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
            // idBancoGridLookUpEditView
            // 
            this.idBancoGridLookUpEditView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.idBancoGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.idBancoGridLookUpEditView.Name = "idBancoGridLookUpEditView";
            this.idBancoGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.idBancoGridLookUpEditView.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "IdBanco";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Banco";
            this.gridColumn2.FieldName = "NombreBanco";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(16, 426);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(71, 13);
            this.labelControl9.TabIndex = 30;
            this.labelControl9.Text = "Otro Concepto";
            // 
            // lblMoneda
            // 
            this.lblMoneda.Location = new System.Drawing.Point(244, 219);
            this.lblMoneda.Name = "lblMoneda";
            this.lblMoneda.Size = new System.Drawing.Size(38, 13);
            this.lblMoneda.TabIndex = 18;
            this.lblMoneda.Text = "Moneda";
            // 
            // cboCategoriaTransaccionBanco
            // 
            this.cboCategoriaTransaccionBanco.EditValue = "";
            this.cboCategoriaTransaccionBanco.Enabled = false;
            this.cboCategoriaTransaccionBanco.Location = new System.Drawing.Point(138, 371);
            this.cboCategoriaTransaccionBanco.Name = "cboCategoriaTransaccionBanco";
            this.cboCategoriaTransaccionBanco.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboCategoriaTransaccionBanco.Properties.DataSource = this.stpSelCategoriaTransaccionBancoBindingSource;
            this.cboCategoriaTransaccionBanco.Properties.DisplayMember = "DescCategoriaTransaccionBanco";
            this.cboCategoriaTransaccionBanco.Properties.ValueMember = "IdCategoriaTransaccionBanco";
            this.cboCategoriaTransaccionBanco.Properties.View = this.gridLookUpEdit1View;
            this.cboCategoriaTransaccionBanco.Size = new System.Drawing.Size(215, 20);
            this.cboCategoriaTransaccionBanco.TabIndex = 27;
            this.cboCategoriaTransaccionBanco.Tag = "Clasificación Movimiento";
            this.cboCategoriaTransaccionBanco.EditValueChanged += new System.EventHandler(this.cboCategoriaTransaccionBanco_EditValueChanged);
            // 
            // stpSelCategoriaTransaccionBancoBindingSource
            // 
            this.stpSelCategoriaTransaccionBancoBindingSource.DataMember = "stpSelCategoriaTransaccionBanco";
            this.stpSelCategoriaTransaccionBancoBindingSource.DataSource = this.dbSAICBPOCatalogosDataSet;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCategoriaTransaccionBanco,
            this.colDescCategoriaTransaccionBanco});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdCategoriaTransaccionBanco
            // 
            this.colIdCategoriaTransaccionBanco.FieldName = "IdCategoriaTransaccionBanco";
            this.colIdCategoriaTransaccionBanco.Name = "colIdCategoriaTransaccionBanco";
            this.colIdCategoriaTransaccionBanco.OptionsColumn.ReadOnly = true;
            // 
            // colDescCategoriaTransaccionBanco
            // 
            this.colDescCategoriaTransaccionBanco.Caption = "Clasificación Movimiento";
            this.colDescCategoriaTransaccionBanco.FieldName = "DescCategoriaTransaccionBanco";
            this.colDescCategoriaTransaccionBanco.Name = "colDescCategoriaTransaccionBanco";
            this.colDescCategoriaTransaccionBanco.OptionsColumn.AllowEdit = false;
            this.colDescCategoriaTransaccionBanco.Visible = true;
            this.colDescCategoriaTransaccionBanco.VisibleIndex = 0;
            // 
            // cboSubCategoriaTransaccionBanco
            // 
            this.cboSubCategoriaTransaccionBanco.EditValue = "";
            this.cboSubCategoriaTransaccionBanco.Location = new System.Drawing.Point(138, 397);
            this.cboSubCategoriaTransaccionBanco.Name = "cboSubCategoriaTransaccionBanco";
            this.cboSubCategoriaTransaccionBanco.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboSubCategoriaTransaccionBanco.Properties.DataSource = this.stpSelSubCategoriaTransaccionBancoBindingSource;
            this.cboSubCategoriaTransaccionBanco.Properties.DisplayMember = "DescSubCategoriaTransaccionBanco";
            this.cboSubCategoriaTransaccionBanco.Properties.ValueMember = "IdSubCategoriaTransaccionBanco";
            this.cboSubCategoriaTransaccionBanco.Properties.View = this.gridView1;
            this.cboSubCategoriaTransaccionBanco.Size = new System.Drawing.Size(215, 20);
            this.cboSubCategoriaTransaccionBanco.TabIndex = 29;
            this.cboSubCategoriaTransaccionBanco.Tag = "SubClasificación Movimiento";
            this.cboSubCategoriaTransaccionBanco.EditValueChanged += new System.EventHandler(this.cboSubCategoriaTransaccionBanco_EditValueChanged);
            // 
            // stpSelSubCategoriaTransaccionBancoBindingSource
            // 
            this.stpSelSubCategoriaTransaccionBancoBindingSource.DataMember = "stpSelSubCategoriaTransaccionBanco";
            this.stpSelSubCategoriaTransaccionBancoBindingSource.DataSource = this.dbSAICBPOCatalogosDataSet;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdSubCategoriaTransaccionBanco,
            this.colDescSubCategoriaTransaccionBanco});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIdSubCategoriaTransaccionBanco
            // 
            this.colIdSubCategoriaTransaccionBanco.FieldName = "IdSubCategoriaTransaccionBanco";
            this.colIdSubCategoriaTransaccionBanco.Name = "colIdSubCategoriaTransaccionBanco";
            this.colIdSubCategoriaTransaccionBanco.OptionsColumn.ReadOnly = true;
            // 
            // colDescSubCategoriaTransaccionBanco
            // 
            this.colDescSubCategoriaTransaccionBanco.Caption = "SubClasificación Movimiento";
            this.colDescSubCategoriaTransaccionBanco.FieldName = "DescSubCategoriaTransaccionBanco";
            this.colDescSubCategoriaTransaccionBanco.Name = "colDescSubCategoriaTransaccionBanco";
            this.colDescSubCategoriaTransaccionBanco.OptionsColumn.AllowEdit = false;
            this.colDescSubCategoriaTransaccionBanco.Visible = true;
            this.colDescSubCategoriaTransaccionBanco.VisibleIndex = 0;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(16, 399);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(103, 13);
            this.labelControl10.TabIndex = 28;
            this.labelControl10.Text = "SubClasificación Mov.";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(16, 41);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(79, 13);
            this.labelControl11.TabIndex = 1;
            this.labelControl11.Text = "Folio Movimiento";
            // 
            // lblFolioMovimiento
            // 
            this.lblFolioMovimiento.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblFolioMovimiento.Appearance.Options.UseFont = true;
            this.lblFolioMovimiento.Location = new System.Drawing.Point(138, 41);
            this.lblFolioMovimiento.Name = "lblFolioMovimiento";
            this.lblFolioMovimiento.Size = new System.Drawing.Size(26, 13);
            this.lblFolioMovimiento.TabIndex = 2;
            this.lblFolioMovimiento.Text = "Folio";
            // 
            // btnBuscarCheque
            // 
            this.btnBuscarCheque.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCheque.ImageOptions.Image")));
            this.btnBuscarCheque.Location = new System.Drawing.Point(562, 350);
            this.btnBuscarCheque.Name = "btnBuscarCheque";
            this.btnBuscarCheque.Size = new System.Drawing.Size(120, 25);
            this.btnBuscarCheque.TabIndex = 45;
            this.btnBuscarCheque.Text = "&Buscar Cheque";
            this.btnBuscarCheque.Click += new System.EventHandler(this.btnBuscarCheque_Click);
            // 
            // btnCancelarCaptura
            // 
            this.btnCancelarCaptura.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarCaptura.ImageOptions.Image")));
            this.btnCancelarCaptura.Location = new System.Drawing.Point(562, 82);
            this.btnCancelarCaptura.Name = "btnCancelarCaptura";
            this.btnCancelarCaptura.Size = new System.Drawing.Size(120, 25);
            this.btnCancelarCaptura.TabIndex = 39;
            this.btnCancelarCaptura.Text = "Cancelar Captura";
            this.btnCancelarCaptura.Click += new System.EventHandler(this.btnCancelarCaptura_Click);
            // 
            // btnGuardarCheque
            // 
            this.btnGuardarCheque.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarCheque.ImageOptions.Image")));
            this.btnGuardarCheque.Location = new System.Drawing.Point(562, 113);
            this.btnGuardarCheque.Name = "btnGuardarCheque";
            this.btnGuardarCheque.Size = new System.Drawing.Size(120, 25);
            this.btnGuardarCheque.TabIndex = 40;
            this.btnGuardarCheque.Text = "&Guardar Cheque";
            this.btnGuardarCheque.Click += new System.EventHandler(this.btnGuardarCheque_Click);
            // 
            // btnImprimirPoliza
            // 
            this.btnImprimirPoliza.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimirPoliza.ImageOptions.Image")));
            this.btnImprimirPoliza.Location = new System.Drawing.Point(562, 276);
            this.btnImprimirPoliza.Name = "btnImprimirPoliza";
            this.btnImprimirPoliza.Size = new System.Drawing.Size(120, 25);
            this.btnImprimirPoliza.TabIndex = 43;
            this.btnImprimirPoliza.Text = "Imprimir Póliza";
            this.btnImprimirPoliza.Click += new System.EventHandler(this.btnImprimirPoliza_Click);
            // 
            // chkCancelado
            // 
            this.chkCancelado.AutoSize = true;
            this.chkCancelado.Enabled = false;
            this.chkCancelado.Location = new System.Drawing.Point(562, 537);
            this.chkCancelado.Name = "chkCancelado";
            this.chkCancelado.Size = new System.Drawing.Size(116, 17);
            this.chkCancelado.TabIndex = 37;
            this.chkCancelado.Text = "Cheque Cancelado";
            this.chkCancelado.UseVisualStyleBackColor = true;
            this.chkCancelado.Visible = false;
            // 
            // btnCancelarCheque
            // 
            this.btnCancelarCheque.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarCheque.ImageOptions.Image")));
            this.btnCancelarCheque.Location = new System.Drawing.Point(562, 394);
            this.btnCancelarCheque.Name = "btnCancelarCheque";
            this.btnCancelarCheque.Size = new System.Drawing.Size(120, 25);
            this.btnCancelarCheque.TabIndex = 46;
            this.btnCancelarCheque.Text = "Cancelar Cheque";
            this.btnCancelarCheque.Click += new System.EventHandler(this.btnCancelarCheque_Click);
            // 
            // txtBeneficiarioPoliza
            // 
            this.txtBeneficiarioPoliza.Location = new System.Drawing.Point(138, 345);
            this.txtBeneficiarioPoliza.Name = "txtBeneficiarioPoliza";
            this.txtBeneficiarioPoliza.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBeneficiarioPoliza.Size = new System.Drawing.Size(409, 20);
            this.txtBeneficiarioPoliza.TabIndex = 25;
            this.txtBeneficiarioPoliza.Tag = "Beneficiario Póliza";
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(16, 348);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(85, 13);
            this.labelControl12.TabIndex = 24;
            this.labelControl12.Text = "Beneficiario Póliza";
            // 
            // lblFolio
            // 
            this.lblFolio.Location = new System.Drawing.Point(16, 167);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(116, 13);
            this.lblFolio.TabIndex = 11;
            this.lblFolio.Text = "Folio Lote Carga Nómina";
            // 
            // cboFolioLoteCargaNomina
            // 
            this.cboFolioLoteCargaNomina.EditValue = "";
            this.cboFolioLoteCargaNomina.Location = new System.Drawing.Point(138, 164);
            this.cboFolioLoteCargaNomina.Name = "cboFolioLoteCargaNomina";
            this.cboFolioLoteCargaNomina.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
            this.cboFolioLoteCargaNomina.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboFolioLoteCargaNomina.Properties.DataSource = this.stpSelFolioLoteCargaNominaParaChequesBindingSource;
            this.cboFolioLoteCargaNomina.Properties.DisplayMember = "FolioLoteCargaNomina";
            this.cboFolioLoteCargaNomina.Properties.ValueMember = "IdLoteCargaNomina";
            this.cboFolioLoteCargaNomina.Properties.View = this.idLoteCargaNominaGridLookUpEditView;
            this.cboFolioLoteCargaNomina.Size = new System.Drawing.Size(250, 20);
            this.cboFolioLoteCargaNomina.TabIndex = 12;
            this.cboFolioLoteCargaNomina.Tag = "Folio Lote Carga Nómina";
            this.cboFolioLoteCargaNomina.EditValueChanged += new System.EventHandler(this.cboFolioLoteCargaNomina_EditValueChanged);
            // 
            // stpSelFolioLoteCargaNominaParaChequesBindingSource
            // 
            this.stpSelFolioLoteCargaNominaParaChequesBindingSource.DataMember = "stpSelFolioLoteCargaNominaParaCheques";
            this.stpSelFolioLoteCargaNominaParaChequesBindingSource.DataSource = this.dbSAICBPOTesoreriaDataSet;
            // 
            // idLoteCargaNominaGridLookUpEditView
            // 
            this.idLoteCargaNominaGridLookUpEditView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdLoteCargaNomina,
            this.colFolioLoteCargaNomina,
            this.colTenedora,
            this.colCliente,
            this.colOperador});
            this.idLoteCargaNominaGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.idLoteCargaNominaGridLookUpEditView.Name = "idLoteCargaNominaGridLookUpEditView";
            this.idLoteCargaNominaGridLookUpEditView.OptionsCustomization.AllowGroup = false;
            this.idLoteCargaNominaGridLookUpEditView.OptionsCustomization.AllowQuickHideColumns = false;
            this.idLoteCargaNominaGridLookUpEditView.OptionsCustomization.AllowSort = false;
            this.idLoteCargaNominaGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.idLoteCargaNominaGridLookUpEditView.OptionsView.ShowAutoFilterRow = true;
            this.idLoteCargaNominaGridLookUpEditView.OptionsView.ShowGroupPanel = false;
            this.idLoteCargaNominaGridLookUpEditView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colIdLoteCargaNomina, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colIdLoteCargaNomina
            // 
            this.colIdLoteCargaNomina.AppearanceCell.Options.UseTextOptions = true;
            this.colIdLoteCargaNomina.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIdLoteCargaNomina.Caption = "No. Lote";
            this.colIdLoteCargaNomina.FieldName = "IdLoteCargaNomina";
            this.colIdLoteCargaNomina.Name = "colIdLoteCargaNomina";
            this.colIdLoteCargaNomina.OptionsColumn.ReadOnly = true;
            this.colIdLoteCargaNomina.Visible = true;
            this.colIdLoteCargaNomina.VisibleIndex = 0;
            this.colIdLoteCargaNomina.Width = 22;
            // 
            // colFolioLoteCargaNomina
            // 
            this.colFolioLoteCargaNomina.Caption = "Folio Lote Carga Nómina";
            this.colFolioLoteCargaNomina.FieldName = "FolioLoteCargaNomina";
            this.colFolioLoteCargaNomina.Name = "colFolioLoteCargaNomina";
            this.colFolioLoteCargaNomina.Visible = true;
            this.colFolioLoteCargaNomina.VisibleIndex = 1;
            this.colFolioLoteCargaNomina.Width = 41;
            // 
            // colTenedora
            // 
            this.colTenedora.Caption = "Tenedora";
            this.colTenedora.FieldName = "NombreComercialTenedora";
            this.colTenedora.Name = "colTenedora";
            this.colTenedora.Visible = true;
            this.colTenedora.VisibleIndex = 2;
            this.colTenedora.Width = 114;
            // 
            // colCliente
            // 
            this.colCliente.Caption = "Cliente";
            this.colCliente.FieldName = "NombreComercialCliente";
            this.colCliente.Name = "colCliente";
            this.colCliente.Visible = true;
            this.colCliente.VisibleIndex = 3;
            this.colCliente.Width = 173;
            // 
            // colOperador
            // 
            this.colOperador.FieldName = "Operador";
            this.colOperador.Name = "colOperador";
            this.colOperador.Visible = true;
            this.colOperador.VisibleIndex = 4;
            this.colOperador.Width = 150;
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(16, 482);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(71, 13);
            this.labelControl13.TabIndex = 32;
            this.labelControl13.Text = "Observaciones";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(138, 479);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservaciones.Size = new System.Drawing.Size(409, 50);
            this.txtObservaciones.TabIndex = 33;
            this.txtObservaciones.Tag = "Observaciones";
            // 
            // chkUtilizarFolioLoteNomina
            // 
            this.chkUtilizarFolioLoteNomina.AutoSize = true;
            this.chkUtilizarFolioLoteNomina.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUtilizarFolioLoteNomina.ForeColor = System.Drawing.Color.Blue;
            this.chkUtilizarFolioLoteNomina.Location = new System.Drawing.Point(394, 166);
            this.chkUtilizarFolioLoteNomina.Name = "chkUtilizarFolioLoteNomina";
            this.chkUtilizarFolioLoteNomina.Size = new System.Drawing.Size(120, 17);
            this.chkUtilizarFolioLoteNomina.TabIndex = 13;
            this.chkUtilizarFolioLoteNomina.Text = "Utilizar Lote Nómina";
            this.chkUtilizarFolioLoteNomina.UseVisualStyleBackColor = true;
            this.chkUtilizarFolioLoteNomina.CheckedChanged += new System.EventHandler(this.chkUtilizarFolioLoteNomina_CheckedChanged);
            // 
            // btnEditarCheque
            // 
            this.btnEditarCheque.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarCheque.ImageOptions.Image")));
            this.btnEditarCheque.Location = new System.Drawing.Point(562, 144);
            this.btnEditarCheque.Name = "btnEditarCheque";
            this.btnEditarCheque.Size = new System.Drawing.Size(120, 25);
            this.btnEditarCheque.TabIndex = 41;
            this.btnEditarCheque.Text = "&Editar Cheque";
            this.btnEditarCheque.Click += new System.EventHandler(this.btnEditarCheque_Click);
            // 
            // btnImpresionMasivaPolizas
            // 
            this.btnImpresionMasivaPolizas.Appearance.Options.UseTextOptions = true;
            this.btnImpresionMasivaPolizas.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnImpresionMasivaPolizas.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnImpresionMasivaPolizas.ImageOptions.Image")));
            this.btnImpresionMasivaPolizas.Location = new System.Drawing.Point(562, 307);
            this.btnImpresionMasivaPolizas.Name = "btnImpresionMasivaPolizas";
            this.btnImpresionMasivaPolizas.Size = new System.Drawing.Size(120, 37);
            this.btnImpresionMasivaPolizas.TabIndex = 44;
            this.btnImpresionMasivaPolizas.Text = "Impresión masiva de Pólizas";
            this.btnImpresionMasivaPolizas.Click += new System.EventHandler(this.btnImpresionMasivaPolizas_Click);
            // 
            // lblClienteProveedor
            // 
            this.lblClienteProveedor.Location = new System.Drawing.Point(16, 142);
            this.lblClienteProveedor.Name = "lblClienteProveedor";
            this.lblClienteProveedor.Size = new System.Drawing.Size(87, 13);
            this.lblClienteProveedor.TabIndex = 9;
            this.lblClienteProveedor.Text = "Cliente/Proveedor";
            // 
            // cboClienteProveedor
            // 
            this.cboClienteProveedor.EditValue = "";
            this.cboClienteProveedor.Location = new System.Drawing.Point(138, 138);
            this.cboClienteProveedor.Name = "cboClienteProveedor";
            this.cboClienteProveedor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboClienteProveedor.Properties.DataSource = this.stpSelClienteProveedorChequesBindingSource;
            this.cboClienteProveedor.Properties.DisplayMember = "NombreComercial";
            this.cboClienteProveedor.Properties.ValueMember = "IdCliente";
            this.cboClienteProveedor.Properties.View = this.gridView2;
            this.cboClienteProveedor.Size = new System.Drawing.Size(409, 20);
            this.cboClienteProveedor.TabIndex = 10;
            this.cboClienteProveedor.Tag = "Cliente Operaciones";
            // 
            // stpSelClienteProveedorChequesBindingSource
            // 
            this.stpSelClienteProveedorChequesBindingSource.DataMember = "stpSelClienteProveedorCheques";
            this.stpSelClienteProveedorChequesBindingSource.DataSource = this.dbSAICBPOTesoreriaDataSet;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCliente,
            this.colRazonSocial,
            this.colNombreComercial});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colIdCliente
            // 
            this.colIdCliente.FieldName = "IdCliente";
            this.colIdCliente.Name = "colIdCliente";
            this.colIdCliente.OptionsColumn.ReadOnly = true;
            // 
            // colRazonSocial
            // 
            this.colRazonSocial.Caption = "Razón Social";
            this.colRazonSocial.FieldName = "RazonSocial";
            this.colRazonSocial.Name = "colRazonSocial";
            this.colRazonSocial.OptionsColumn.AllowEdit = false;
            this.colRazonSocial.OptionsColumn.ReadOnly = true;
            this.colRazonSocial.Visible = true;
            this.colRazonSocial.VisibleIndex = 0;
            // 
            // colNombreComercial
            // 
            this.colNombreComercial.FieldName = "NombreComercial";
            this.colNombreComercial.Name = "colNombreComercial";
            this.colNombreComercial.OptionsColumn.AllowEdit = false;
            this.colNombreComercial.OptionsColumn.ReadOnly = true;
            this.colNombreComercial.Visible = true;
            this.colNombreComercial.VisibleIndex = 1;
            // 
            // dbSAICBPOActualizacionesTesoreriaDataSet1
            // 
            this.dbSAICBPOActualizacionesTesoreriaDataSet1.DataSetName = "dbSAICBPOActualizacionesTesoreriaDataSet";
            this.dbSAICBPOActualizacionesTesoreriaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chkAjusteContable
            // 
            this.chkAjusteContable.AutoSize = true;
            this.chkAjusteContable.Location = new System.Drawing.Point(138, 294);
            this.chkAjusteContable.Name = "chkAjusteContable";
            this.chkAjusteContable.Size = new System.Drawing.Size(103, 17);
            this.chkAjusteContable.TabIndex = 21;
            this.chkAjusteContable.Text = "Ajuste Contable";
            this.chkAjusteContable.UseVisualStyleBackColor = true;
            // 
            // chkChequeConciliado
            // 
            this.chkChequeConciliado.AutoSize = true;
            this.chkChequeConciliado.Enabled = false;
            this.chkChequeConciliado.Location = new System.Drawing.Point(395, 537);
            this.chkChequeConciliado.Name = "chkChequeConciliado";
            this.chkChequeConciliado.Size = new System.Drawing.Size(152, 17);
            this.chkChequeConciliado.TabIndex = 36;
            this.chkChequeConciliado.Text = "Conciliado en Edo. Cuenta";
            this.chkChequeConciliado.UseVisualStyleBackColor = true;
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(16, 539);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(76, 13);
            this.labelControl14.TabIndex = 34;
            this.labelControl14.Text = "Estatus Cheque";
            // 
            // cboEstatusCheque
            // 
            this.cboEstatusCheque.EditValue = "";
            this.cboEstatusCheque.Enabled = false;
            this.cboEstatusCheque.Location = new System.Drawing.Point(138, 535);
            this.cboEstatusCheque.Name = "cboEstatusCheque";
            this.cboEstatusCheque.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.cboEstatusCheque.Properties.Appearance.Options.UseFont = true;
            this.cboEstatusCheque.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboEstatusCheque.Properties.DataSource = this.stpSelEstatusChequesBindingSource;
            this.cboEstatusCheque.Properties.DisplayMember = "DescEstatus";
            this.cboEstatusCheque.Properties.ValueMember = "IdEstatus";
            this.cboEstatusCheque.Properties.View = this.gridView3;
            this.cboEstatusCheque.Size = new System.Drawing.Size(215, 20);
            this.cboEstatusCheque.TabIndex = 35;
            // 
            // stpSelEstatusChequesBindingSource
            // 
            this.stpSelEstatusChequesBindingSource.DataMember = "stpSelEstatusCheques";
            this.stpSelEstatusChequesBindingSource.DataSource = this.dbSAICBPOTesoreriaDataSet;
            // 
            // gridView3
            // 
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // stpSelBancoTableAdapter
            // 
            this.stpSelBancoTableAdapter.ClearBeforeFill = true;
            // 
            // stpSelCategoriaTransaccionBancoTableAdapter
            // 
            this.stpSelCategoriaTransaccionBancoTableAdapter.ClearBeforeFill = true;
            // 
            // stpSelSubCategoriaTransaccionBancoTableAdapter
            // 
            this.stpSelSubCategoriaTransaccionBancoTableAdapter.ClearBeforeFill = true;
            // 
            // beneficiarioTransaccionBancoBindingSource
            // 
            this.beneficiarioTransaccionBancoBindingSource.DataMember = "BeneficiarioTransaccionBanco";
            this.beneficiarioTransaccionBancoBindingSource.DataSource = this.dbSAICBPOCatalogosDataSet;
            // 
            // beneficiarioTransaccionBancoTableAdapter
            // 
            this.beneficiarioTransaccionBancoTableAdapter.ClearBeforeFill = true;
            // 
            // stpSelCuentaBancoPorBancoTableAdapter
            // 
            this.stpSelCuentaBancoPorBancoTableAdapter.ClearBeforeFill = true;
            // 
            // stpSelInfoCuentaBancoTableAdapter1
            // 
            this.stpSelInfoCuentaBancoTableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelDetalleChequeTableAdapter1
            // 
            this.stpSelDetalleChequeTableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelFolioLoteCargaNominaParaChequesTableAdapter
            // 
            this.stpSelFolioLoteCargaNominaParaChequesTableAdapter.ClearBeforeFill = true;
            // 
            // stpSelClienteProveedorChequesTableAdapter
            // 
            this.stpSelClienteProveedorChequesTableAdapter.ClearBeforeFill = true;
            // 
            // stpSelClienteProveedorChequesTableAdapter1
            // 
            this.stpSelClienteProveedorChequesTableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelEstatusChequesTableAdapter
            // 
            this.stpSelEstatusChequesTableAdapter.ClearBeforeFill = true;
            // 
            // btnImprimirChequesMasivos
            // 
            this.btnImprimirChequesMasivos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimirChequesMasivos.ImageOptions.Image")));
            this.btnImprimirChequesMasivos.Location = new System.Drawing.Point(562, 224);
            this.btnImprimirChequesMasivos.Name = "btnImprimirChequesMasivos";
            this.btnImprimirChequesMasivos.Size = new System.Drawing.Size(120, 37);
            this.btnImprimirChequesMasivos.TabIndex = 47;
            this.btnImprimirChequesMasivos.Text = "Imprimir Cheques\r\nmasivos";
            this.btnImprimirChequesMasivos.Click += new System.EventHandler(this.btnImprimirChequesMasivos_Click);
            // 
            // chFormato
            // 
            this.chFormato.AutoSize = true;
            this.chFormato.Enabled = false;
            this.chFormato.Location = new System.Drawing.Point(394, 87);
            this.chFormato.Name = "chFormato";
            this.chFormato.Size = new System.Drawing.Size(100, 17);
            this.chFormato.TabIndex = 48;
            this.chFormato.Text = "Formato Nuevo";
            this.chFormato.UseVisualStyleBackColor = true;
            // 
            // frmxEmisionCheques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 572);
            this.ControlBox = false;
            this.Controls.Add(this.chFormato);
            this.Controls.Add(this.btnImprimirChequesMasivos);
            this.Controls.Add(this.cboEstatusCheque);
            this.Controls.Add(this.labelControl14);
            this.Controls.Add(this.chkChequeConciliado);
            this.Controls.Add(this.chkAjusteContable);
            this.Controls.Add(this.cboClienteProveedor);
            this.Controls.Add(this.lblClienteProveedor);
            this.Controls.Add(this.btnImpresionMasivaPolizas);
            this.Controls.Add(this.btnEditarCheque);
            this.Controls.Add(this.chkUtilizarFolioLoteNomina);
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.cboFolioLoteCargaNomina);
            this.Controls.Add(this.lblFolio);
            this.Controls.Add(this.txtBeneficiarioPoliza);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.btnCancelarCheque);
            this.Controls.Add(this.chkCancelado);
            this.Controls.Add(this.btnImprimirPoliza);
            this.Controls.Add(this.btnGuardarCheque);
            this.Controls.Add(this.btnCancelarCaptura);
            this.Controls.Add(this.btnBuscarCheque);
            this.Controls.Add(this.lblFolioMovimiento);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.cboSubCategoriaTransaccionBanco);
            this.Controls.Add(this.cboCategoriaTransaccionBanco);
            this.Controls.Add(this.lblMoneda);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.cboBanco);
            this.Controls.Add(this.btnNuevoCheque);
            this.Controls.Add(this.btnImprimirCheque);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.txtBeneficiarioCheque);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.txtNoCheque);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.cboCuentaBanco);
            this.Controls.Add(this.cboFecha);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtOtroConcepto);
            this.Controls.Add(this.txtImporteLetra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmxEmisionCheques";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emisión de Cheques";
            this.Load += new System.EventHandler(this.frmxEmisionCheques_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cboFecha.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCuentaBanco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelCuentaBancoPorBancoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOTesoreriaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoCheque.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImporte.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBeneficiarioCheque.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOtroConcepto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImporteLetra.Properties)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboBanco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelBancoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idBancoGridLookUpEditView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCategoriaTransaccionBanco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelCategoriaTransaccionBancoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSubCategoriaTransaccionBanco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelSubCategoriaTransaccionBancoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBeneficiarioPoliza.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFolioLoteCargaNomina.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelFolioLoteCargaNominaParaChequesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idLoteCargaNominaGridLookUpEditView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservaciones.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboClienteProveedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelClienteProveedorChequesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOActualizacionesTesoreriaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboEstatusCheque.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelEstatusChequesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beneficiarioTransaccionBancoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.DateEdit cboFecha;
        private DevExpress.XtraEditors.GridLookUpEdit cboCuentaBanco;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit2View;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SpinEdit txtNoCheque;
        private DevExpress.XtraEditors.SpinEdit txtImporte;
        private DevExpress.XtraEditors.TextEdit txtBeneficiarioCheque;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.MemoEdit txtOtroConcepto;
        private DevExpress.XtraEditors.MemoEdit txtImporteLetra;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private DevExpress.XtraEditors.SimpleButton btnImprimirCheque;
        private DevExpress.XtraEditors.SimpleButton btnNuevoCheque;
        private dbSAICBPOCatalogosDataSet dbSAICBPOCatalogosDataSet;
        private System.Windows.Forms.BindingSource stpSelBancoBindingSource;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelBancoTableAdapter stpSelBancoTableAdapter;
        private DevExpress.XtraEditors.GridLookUpEdit cboBanco;
        private DevExpress.XtraGrid.Views.Grid.GridView idBancoGridLookUpEditView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private System.Windows.Forms.BindingSource stpSelCuentaBancoPorBancoBindingSource;
        private dbSAICBPOTesoreriaDataSet dbSAICBPOTesoreriaDataSet;
        private dbSAICBPOTesoreriaDataSetTableAdapters.stpSelCuentaBancoPorBancoTableAdapter stpSelCuentaBancoPorBancoTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreCuentaBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colNoCuenta;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCuentaBanco;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMoneda;
        private DevExpress.XtraEditors.LabelControl lblMoneda;
        private dbSAICBPOTesoreriaDataSetTableAdapters.stpSelInfoCuentaBancoTableAdapter stpSelInfoCuentaBancoTableAdapter1;
        private DevExpress.XtraEditors.GridLookUpEdit cboCategoriaTransaccionBanco;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private System.Windows.Forms.BindingSource stpSelCategoriaTransaccionBancoBindingSource;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelCategoriaTransaccionBancoTableAdapter stpSelCategoriaTransaccionBancoTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCategoriaTransaccionBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colDescCategoriaTransaccionBanco;
        private DevExpress.XtraEditors.GridLookUpEdit cboSubCategoriaTransaccionBanco;
        private System.Windows.Forms.BindingSource stpSelSubCategoriaTransaccionBancoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelSubCategoriaTransaccionBancoTableAdapter stpSelSubCategoriaTransaccionBancoTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSubCategoriaTransaccionBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colDescSubCategoriaTransaccionBanco;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl lblFolioMovimiento;
        private System.Windows.Forms.BindingSource beneficiarioTransaccionBancoBindingSource;
        private dbSAICBPOCatalogosDataSetTableAdapters.BeneficiarioTransaccionBancoTableAdapter beneficiarioTransaccionBancoTableAdapter;
        private dbSAICBPOActualizacionesTesoreriaDataSet dbSAICBPOActualizacionesTesoreriaDataSet1;
        private dbSAICBPOActualizacionesTesoreriaDataSetTableAdapters.ActualizacionesTesoreriaTableAdapter actualizacionesTesoreriaTableAdapter1;
        private DevExpress.XtraEditors.SimpleButton btnBuscarCheque;
        private DevExpress.XtraEditors.SimpleButton btnCancelarCaptura;
        private DevExpress.XtraEditors.SimpleButton btnGuardarCheque;
        private DevExpress.XtraEditors.SimpleButton btnImprimirPoliza;
        private System.Windows.Forms.CheckBox chkCancelado;
        private DevExpress.XtraEditors.SimpleButton btnCancelarCheque;
        private dbSAICBPOTesoreriaDataSetTableAdapters.stpSelDetalleChequeTableAdapter stpSelDetalleChequeTableAdapter1;
        private DevExpress.XtraEditors.TextEdit txtBeneficiarioPoliza;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl lblFolio;
        private DevExpress.XtraEditors.GridLookUpEdit cboFolioLoteCargaNomina;
        private DevExpress.XtraGrid.Views.Grid.GridView idLoteCargaNominaGridLookUpEditView;
        private DevExpress.XtraGrid.Columns.GridColumn colIdLoteCargaNomina;
        private DevExpress.XtraGrid.Columns.GridColumn colFolioLoteCargaNomina;
        private DevExpress.XtraGrid.Columns.GridColumn colTenedora;
        private DevExpress.XtraGrid.Columns.GridColumn colCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colOperador;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.MemoEdit txtObservaciones;
        private System.Windows.Forms.BindingSource stpSelFolioLoteCargaNominaParaChequesBindingSource;
        private dbSAICBPOTesoreriaDataSetTableAdapters.stpSelFolioLoteCargaNominaParaChequesTableAdapter stpSelFolioLoteCargaNominaParaChequesTableAdapter;
        private System.Windows.Forms.CheckBox chkUtilizarFolioLoteNomina;
        private DevExpress.XtraEditors.SimpleButton btnEditarCheque;
        private DevExpress.XtraEditors.SimpleButton btnImpresionMasivaPolizas;
        private DevExpress.XtraEditors.LabelControl lblClienteProveedor;
        private DevExpress.XtraEditors.GridLookUpEdit cboClienteProveedor;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.BindingSource stpSelClienteProveedorChequesBindingSource;
        private dbSAICBPOTesoreriaDataSetTableAdapters.stpSelClienteProveedorChequesTableAdapter stpSelClienteProveedorChequesTableAdapter;
        private dbSAICBPOTesoreriaDataSetTableAdapters.stpSelClienteProveedorChequesTableAdapter stpSelClienteProveedorChequesTableAdapter1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colRazonSocial;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreComercial;
        private System.Windows.Forms.CheckBox chkAjusteContable;
        private System.Windows.Forms.CheckBox chkChequeConciliado;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.GridLookUpEdit cboEstatusCheque;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private System.Windows.Forms.BindingSource stpSelEstatusChequesBindingSource;
        private dbSAICBPOTesoreriaDataSetTableAdapters.stpSelEstatusChequesTableAdapter stpSelEstatusChequesTableAdapter;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashSMCargando;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cboTipoImpresora;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private DevExpress.XtraEditors.SimpleButton btnImprimirChequesMasivos;
        private System.Windows.Forms.CheckBox chFormato;
    }
}