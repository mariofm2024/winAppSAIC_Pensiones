namespace winAppSAIC.Tesoreria
{
    partial class frmxAgregarChequeEspecial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmxAgregarChequeEspecial));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtIdLoteCargaNomina = new DevExpress.XtraEditors.TextEdit();
            this.chkAjusteContable = new System.Windows.Forms.CheckBox();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.txtObservaciones = new DevExpress.XtraEditors.MemoEdit();
            this.txtBeneficiarioPoliza = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.dbSAICBPOCatalogosDataSet = new winAppSAIC.dbSAICBPOCatalogosDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdSubCategoriaTransaccionBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescSubCategoriaTransaccionBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCategoriaTransaccionBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescCategoriaTransaccionBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtNombreEmpleado = new DevExpress.XtraEditors.TextEdit();
            this.txtImporte = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtOtroConcepto = new DevExpress.XtraEditors.MemoEdit();
            this.txtImporteLetra = new DevExpress.XtraEditors.MemoEdit();
            this.btnGuardarCheque = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelarCaptura = new DevExpress.XtraEditors.SimpleButton();
            this.btnBuscarEmpleado = new DevExpress.XtraEditors.SimpleButton();
            this.txtNoEmpleado = new DevExpress.XtraEditors.TextEdit();
            this.stpSelObtenerInfoGenericaEmpleadoTableAdapter1 = new winAppSAIC.Catalogos.dbSAIC_CatalogosTableAdapters.stpSelObtenerInfoGenericaEmpleadoTableAdapter();
            this.stpSelCategoriaTransaccionBancoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stpSelCategoriaTransaccionBancoTableAdapter = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelCategoriaTransaccionBancoTableAdapter();
            this.stpSelSubCategoriaTransaccionBancoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stpSelSubCategoriaTransaccionBancoTableAdapter = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelSubCategoriaTransaccionBancoTableAdapter();
            this.cboSubCategoriaTransaccionBanco = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cboCategoriaTransaccionBanco = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDescCategoriaTransaccionBanco1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescSubCategoriaTransaccionBanco1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboIdMoneda = new DevExpress.XtraEditors.LookUpEdit();
            this.stpSelMonedaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stpSelMonedaTableAdapter = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelMonedaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdLoteCargaNomina.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservaciones.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBeneficiarioPoliza.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreEmpleado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImporte.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOtroConcepto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImporteLetra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoEmpleado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelCategoriaTransaccionBancoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelSubCategoriaTransaccionBancoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSubCategoriaTransaccionBanco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCategoriaTransaccionBanco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboIdMoneda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelMonedaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(78, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(79, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "No. Lote Nómina";
            // 
            // txtIdLoteCargaNomina
            // 
            this.txtIdLoteCargaNomina.Enabled = false;
            this.txtIdLoteCargaNomina.Location = new System.Drawing.Point(163, 20);
            this.txtIdLoteCargaNomina.Name = "txtIdLoteCargaNomina";
            this.txtIdLoteCargaNomina.Size = new System.Drawing.Size(100, 20);
            this.txtIdLoteCargaNomina.TabIndex = 1;
            this.txtIdLoteCargaNomina.TabStop = false;
            // 
            // chkAjusteContable
            // 
            this.chkAjusteContable.AutoSize = true;
            this.chkAjusteContable.Location = new System.Drawing.Point(163, 125);
            this.chkAjusteContable.Name = "chkAjusteContable";
            this.chkAjusteContable.Size = new System.Drawing.Size(103, 17);
            this.chkAjusteContable.TabIndex = 7;
            this.chkAjusteContable.Text = "Ajuste Contable";
            this.chkAjusteContable.UseVisualStyleBackColor = true;
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(86, 310);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(71, 13);
            this.labelControl13.TabIndex = 20;
            this.labelControl13.Text = "Observaciones";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(163, 310);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservaciones.Size = new System.Drawing.Size(409, 50);
            this.txtObservaciones.TabIndex = 21;
            this.txtObservaciones.Tag = "Observaciones";
            // 
            // txtBeneficiarioPoliza
            // 
            this.txtBeneficiarioPoliza.Location = new System.Drawing.Point(163, 176);
            this.txtBeneficiarioPoliza.Name = "txtBeneficiarioPoliza";
            this.txtBeneficiarioPoliza.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBeneficiarioPoliza.Size = new System.Drawing.Size(409, 20);
            this.txtBeneficiarioPoliza.TabIndex = 13;
            this.txtBeneficiarioPoliza.Tag = "Beneficiario Póliza";
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(22, 180);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(135, 13);
            this.labelControl12.TabIndex = 12;
            this.labelControl12.Text = "Beneficiario/Empleado Póliza";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(54, 232);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(103, 13);
            this.labelControl10.TabIndex = 16;
            this.labelControl10.Text = "SubClasificación Mov.";
            // 
            // dbSAICBPOCatalogosDataSet
            // 
            this.dbSAICBPOCatalogosDataSet.DataSetName = "dbSAICBPOCatalogosDataSet";
            this.dbSAICBPOCatalogosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
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
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
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
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(86, 254);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(71, 13);
            this.labelControl9.TabIndex = 18;
            this.labelControl9.Text = "Otro Concepto";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(71, 72);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(86, 13);
            this.labelControl8.TabIndex = 5;
            this.labelControl8.Text = "Importe con Letra";
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Location = new System.Drawing.Point(282, 148);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreEmpleado.Size = new System.Drawing.Size(290, 20);
            this.txtNombreEmpleado.TabIndex = 11;
            this.txtNombreEmpleado.Tag = "Beneficiario Cheque";
            this.txtNombreEmpleado.EditValueChanged += new System.EventHandler(this.txtBeneficiarioCheque_EditValueChanged);
            // 
            // txtImporte
            // 
            this.txtImporte.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtImporte.Location = new System.Drawing.Point(163, 46);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(100, 20);
            this.txtImporte.TabIndex = 3;
            this.txtImporte.Tag = "Importe";
            this.txtImporte.Leave += new System.EventHandler(this.txtImporte_Leave);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(72, 206);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(85, 13);
            this.labelControl6.TabIndex = 14;
            this.labelControl6.Text = "Clasificación Mov.";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 152);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(145, 13);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Beneficiario/Empleado Cheque";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(119, 50);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(38, 13);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Importe";
            // 
            // txtOtroConcepto
            // 
            this.txtOtroConcepto.Location = new System.Drawing.Point(163, 254);
            this.txtOtroConcepto.Name = "txtOtroConcepto";
            this.txtOtroConcepto.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtOtroConcepto.Size = new System.Drawing.Size(409, 50);
            this.txtOtroConcepto.TabIndex = 19;
            this.txtOtroConcepto.Tag = "Otro Concepto";
            // 
            // txtImporteLetra
            // 
            this.txtImporteLetra.Enabled = false;
            this.txtImporteLetra.Location = new System.Drawing.Point(163, 72);
            this.txtImporteLetra.Name = "txtImporteLetra";
            this.txtImporteLetra.Size = new System.Drawing.Size(409, 46);
            this.txtImporteLetra.TabIndex = 6;
            // 
            // btnGuardarCheque
            // 
            this.btnGuardarCheque.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarCheque.Image")));
            this.btnGuardarCheque.Location = new System.Drawing.Point(584, 20);
            this.btnGuardarCheque.Name = "btnGuardarCheque";
            this.btnGuardarCheque.Size = new System.Drawing.Size(120, 25);
            this.btnGuardarCheque.TabIndex = 22;
            this.btnGuardarCheque.Text = "&Guardar Cheque";
            this.btnGuardarCheque.Click += new System.EventHandler(this.btnGuardarCheque_Click);
            // 
            // btnCancelarCaptura
            // 
            this.btnCancelarCaptura.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelarCaptura.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarCaptura.Image")));
            this.btnCancelarCaptura.Location = new System.Drawing.Point(584, 50);
            this.btnCancelarCaptura.Name = "btnCancelarCaptura";
            this.btnCancelarCaptura.Size = new System.Drawing.Size(120, 25);
            this.btnCancelarCaptura.TabIndex = 23;
            this.btnCancelarCaptura.Text = "Cancelar Captura";
            // 
            // btnBuscarEmpleado
            // 
            this.btnBuscarEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarEmpleado.Image")));
            this.btnBuscarEmpleado.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnBuscarEmpleado.Location = new System.Drawing.Point(244, 147);
            this.btnBuscarEmpleado.Name = "btnBuscarEmpleado";
            this.btnBuscarEmpleado.Size = new System.Drawing.Size(32, 23);
            this.btnBuscarEmpleado.TabIndex = 10;
            this.btnBuscarEmpleado.ToolTip = "Buscar";
            this.btnBuscarEmpleado.Click += new System.EventHandler(this.btnBuscarEmpleado_Click);
            // 
            // txtNoEmpleado
            // 
            this.txtNoEmpleado.Location = new System.Drawing.Point(163, 148);
            this.txtNoEmpleado.Name = "txtNoEmpleado";
            this.txtNoEmpleado.Size = new System.Drawing.Size(75, 20);
            this.txtNoEmpleado.TabIndex = 9;
            this.txtNoEmpleado.Tag = "No. de Empleado";
            this.txtNoEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoEmpleado_KeyPress);
            // 
            // stpSelObtenerInfoGenericaEmpleadoTableAdapter1
            // 
            this.stpSelObtenerInfoGenericaEmpleadoTableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelCategoriaTransaccionBancoBindingSource
            // 
            this.stpSelCategoriaTransaccionBancoBindingSource.DataMember = "stpSelCategoriaTransaccionBanco";
            this.stpSelCategoriaTransaccionBancoBindingSource.DataSource = this.dbSAICBPOCatalogosDataSet;
            // 
            // stpSelCategoriaTransaccionBancoTableAdapter
            // 
            this.stpSelCategoriaTransaccionBancoTableAdapter.ClearBeforeFill = true;
            // 
            // stpSelSubCategoriaTransaccionBancoBindingSource
            // 
            this.stpSelSubCategoriaTransaccionBancoBindingSource.DataMember = "stpSelSubCategoriaTransaccionBanco";
            this.stpSelSubCategoriaTransaccionBancoBindingSource.DataSource = this.dbSAICBPOCatalogosDataSet;
            // 
            // stpSelSubCategoriaTransaccionBancoTableAdapter
            // 
            this.stpSelSubCategoriaTransaccionBancoTableAdapter.ClearBeforeFill = true;
            // 
            // cboSubCategoriaTransaccionBanco
            // 
            this.cboSubCategoriaTransaccionBanco.Location = new System.Drawing.Point(163, 229);
            this.cboSubCategoriaTransaccionBanco.Name = "cboSubCategoriaTransaccionBanco";
            this.cboSubCategoriaTransaccionBanco.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboSubCategoriaTransaccionBanco.Properties.DataSource = this.stpSelSubCategoriaTransaccionBancoBindingSource;
            this.cboSubCategoriaTransaccionBanco.Properties.DisplayMember = "DescSubCategoriaTransaccionBanco";
            this.cboSubCategoriaTransaccionBanco.Properties.NullText = "";
            this.cboSubCategoriaTransaccionBanco.Properties.ValueMember = "IdSubCategoriaTransaccionBanco";
            this.cboSubCategoriaTransaccionBanco.Properties.View = this.gridView3;
            this.cboSubCategoriaTransaccionBanco.Size = new System.Drawing.Size(215, 20);
            this.cboSubCategoriaTransaccionBanco.TabIndex = 17;
            this.cboSubCategoriaTransaccionBanco.Tag = "SubClasificación Mov.";
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDescSubCategoriaTransaccionBanco1});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // cboCategoriaTransaccionBanco
            // 
            this.cboCategoriaTransaccionBanco.EditValue = "";
            this.cboCategoriaTransaccionBanco.Location = new System.Drawing.Point(163, 202);
            this.cboCategoriaTransaccionBanco.Name = "cboCategoriaTransaccionBanco";
            this.cboCategoriaTransaccionBanco.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboCategoriaTransaccionBanco.Properties.DataSource = this.stpSelCategoriaTransaccionBancoBindingSource;
            this.cboCategoriaTransaccionBanco.Properties.DisplayMember = "DescCategoriaTransaccionBanco";
            this.cboCategoriaTransaccionBanco.Properties.ValueMember = "IdCategoriaTransaccionBanco";
            this.cboCategoriaTransaccionBanco.Properties.View = this.gridView4;
            this.cboCategoriaTransaccionBanco.Size = new System.Drawing.Size(215, 20);
            this.cboCategoriaTransaccionBanco.TabIndex = 15;
            this.cboCategoriaTransaccionBanco.Tag = "Clasificación Mov.";
            this.cboCategoriaTransaccionBanco.EditValueChanged += new System.EventHandler(this.cboCategoriaTransaccionBanco_EditValueChanged);
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDescCategoriaTransaccionBanco1});
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // colDescCategoriaTransaccionBanco1
            // 
            this.colDescCategoriaTransaccionBanco1.Caption = "Clasificación Mov.";
            this.colDescCategoriaTransaccionBanco1.FieldName = "DescCategoriaTransaccionBanco";
            this.colDescCategoriaTransaccionBanco1.Name = "colDescCategoriaTransaccionBanco1";
            this.colDescCategoriaTransaccionBanco1.Visible = true;
            this.colDescCategoriaTransaccionBanco1.VisibleIndex = 0;
            this.colDescCategoriaTransaccionBanco1.Width = 200;
            // 
            // colDescSubCategoriaTransaccionBanco1
            // 
            this.colDescSubCategoriaTransaccionBanco1.Caption = "SubClasificación Mov.";
            this.colDescSubCategoriaTransaccionBanco1.FieldName = "DescSubCategoriaTransaccionBanco";
            this.colDescSubCategoriaTransaccionBanco1.Name = "colDescSubCategoriaTransaccionBanco1";
            this.colDescSubCategoriaTransaccionBanco1.Visible = true;
            this.colDescSubCategoriaTransaccionBanco1.VisibleIndex = 0;
            this.colDescSubCategoriaTransaccionBanco1.Width = 200;
            // 
            // cboIdMoneda
            // 
            this.cboIdMoneda.Location = new System.Drawing.Point(269, 46);
            this.cboIdMoneda.Name = "cboIdMoneda";
            this.cboIdMoneda.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboIdMoneda.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdMoneda", "Id Moneda", 74, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DescMoneda", "Moneda", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.cboIdMoneda.Properties.DataSource = this.stpSelMonedaBindingSource;
            this.cboIdMoneda.Properties.DisplayMember = "DescMoneda";
            this.cboIdMoneda.Properties.NullText = "";
            this.cboIdMoneda.Properties.ValueMember = "IdMoneda";
            this.cboIdMoneda.Size = new System.Drawing.Size(122, 20);
            this.cboIdMoneda.TabIndex = 4;
            // 
            // stpSelMonedaBindingSource
            // 
            this.stpSelMonedaBindingSource.DataMember = "stpSelMoneda";
            this.stpSelMonedaBindingSource.DataSource = this.dbSAICBPOCatalogosDataSet;
            // 
            // stpSelMonedaTableAdapter
            // 
            this.stpSelMonedaTableAdapter.ClearBeforeFill = true;
            // 
            // frmxAgregarChequeEspecial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelarCaptura;
            this.ClientSize = new System.Drawing.Size(716, 374);
            this.ControlBox = false;
            this.Controls.Add(this.cboIdMoneda);
            this.Controls.Add(this.cboCategoriaTransaccionBanco);
            this.Controls.Add(this.btnBuscarEmpleado);
            this.Controls.Add(this.txtNoEmpleado);
            this.Controls.Add(this.btnGuardarCheque);
            this.Controls.Add(this.btnCancelarCaptura);
            this.Controls.Add(this.chkAjusteContable);
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.txtBeneficiarioPoliza);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.txtNombreEmpleado);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtOtroConcepto);
            this.Controls.Add(this.txtImporteLetra);
            this.Controls.Add(this.txtIdLoteCargaNomina);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cboSubCategoriaTransaccionBanco);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmxAgregarChequeEspecial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Cheque Especial";
            this.Load += new System.EventHandler(this.frmxAgregarChequeEspecial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtIdLoteCargaNomina.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservaciones.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBeneficiarioPoliza.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreEmpleado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImporte.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOtroConcepto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImporteLetra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoEmpleado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelCategoriaTransaccionBancoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelSubCategoriaTransaccionBancoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSubCategoriaTransaccionBanco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCategoriaTransaccionBanco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboIdMoneda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelMonedaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtIdLoteCargaNomina;
        private System.Windows.Forms.CheckBox chkAjusteContable;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.MemoEdit txtObservaciones;
        private DevExpress.XtraEditors.TextEdit txtBeneficiarioPoliza;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSubCategoriaTransaccionBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colDescSubCategoriaTransaccionBanco;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCategoriaTransaccionBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colDescCategoriaTransaccionBanco;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtNombreEmpleado;
        private DevExpress.XtraEditors.SpinEdit txtImporte;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.MemoEdit txtOtroConcepto;
        private DevExpress.XtraEditors.MemoEdit txtImporteLetra;
        private dbSAICBPOCatalogosDataSet dbSAICBPOCatalogosDataSet;
        private DevExpress.XtraEditors.SimpleButton btnGuardarCheque;
        private DevExpress.XtraEditors.SimpleButton btnCancelarCaptura;
        private DevExpress.XtraEditors.SimpleButton btnBuscarEmpleado;
        private DevExpress.XtraEditors.TextEdit txtNoEmpleado;
        private Catalogos.dbSAIC_CatalogosTableAdapters.stpSelObtenerInfoGenericaEmpleadoTableAdapter stpSelObtenerInfoGenericaEmpleadoTableAdapter1;
        private System.Windows.Forms.BindingSource stpSelSubCategoriaTransaccionBancoBindingSource;
        private System.Windows.Forms.BindingSource stpSelCategoriaTransaccionBancoBindingSource;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelCategoriaTransaccionBancoTableAdapter stpSelCategoriaTransaccionBancoTableAdapter;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelSubCategoriaTransaccionBancoTableAdapter stpSelSubCategoriaTransaccionBancoTableAdapter;
        private DevExpress.XtraEditors.GridLookUpEdit cboSubCategoriaTransaccionBanco;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.GridLookUpEdit cboCategoriaTransaccionBanco;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn colDescCategoriaTransaccionBanco1;
        private DevExpress.XtraGrid.Columns.GridColumn colDescSubCategoriaTransaccionBanco1;
        private DevExpress.XtraEditors.LookUpEdit cboIdMoneda;
        private System.Windows.Forms.BindingSource stpSelMonedaBindingSource;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelMonedaTableAdapter stpSelMonedaTableAdapter;
    }
}