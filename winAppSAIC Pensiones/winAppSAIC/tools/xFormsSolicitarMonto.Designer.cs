namespace winAppSAIC.tools
{
    partial class xFormsSolicitarMonto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xFormsSolicitarMonto));
            this.lblTitulo = new DevExpress.XtraEditors.LabelControl();
            this.seImporte = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.rdSinImporte = new System.Windows.Forms.RadioButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lblImporteLetra = new DevExpress.XtraEditors.LabelControl();
            this.rdConImporte = new System.Windows.Forms.RadioButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAceptar = new DevExpress.XtraEditors.SimpleButton();
            this.stpSelNominaCFDIBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.UpEditTenedoraSC = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblDepartamento = new DevExpress.XtraEditors.LabelControl();
            this.gridLookUpFirmanteCartas = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lblImporteLetraSA = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.seImporteSA = new DevExpress.XtraEditors.SpinEdit();
            this.lblImporteLetraSC = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.seImporteSC = new DevExpress.XtraEditors.SpinEdit();
            this.stpSelObtenerInfoGenericaTenedoraSC1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPOCatalogosDataSet1 = new winAppSAIC.dbSAICBPOCatalogosDataSet();
            this.stpSelFirmanteCartasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.queriesTableAdapter1 = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.QueriesTableAdapter();
            this.stpSelFirmanteCartasTableAdapter1 = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelFirmanteCartasTableAdapter();
            this.stpSelObtenerInfoGenericaTenedoraSC_1TableAdapter1 = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelObtenerInfoGenericaTenedoraSC_1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.seImporte.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelNominaCFDIBindingNavigator)).BeginInit();
            this.stpSelNominaCFDIBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpEditTenedoraSC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpFirmanteCartas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seImporteSA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seImporteSC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelObtenerInfoGenericaTenedoraSC1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelFirmanteCartasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblTitulo.Appearance.Options.UseFont = true;
            this.lblTitulo.Location = new System.Drawing.Point(12, 28);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(58, 19);
            this.lblTitulo.TabIndex = 14;
            this.lblTitulo.Text = "lblTitulo";
            // 
            // seImporte
            // 
            this.seImporte.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seImporte.Enabled = false;
            this.seImporte.Location = new System.Drawing.Point(125, 45);
            this.seImporte.Name = "seImporte";
            this.seImporte.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.seImporte.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.seImporte.Properties.Appearance.Options.UseBackColor = true;
            this.seImporte.Properties.Appearance.Options.UseFont = true;
            this.seImporte.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seImporte.Properties.DisplayFormat.FormatString = "N2";
            this.seImporte.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seImporte.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.seImporte.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.seImporte.Size = new System.Drawing.Size(97, 22);
            this.seImporte.TabIndex = 30;
            this.seImporte.Tag = "Salario Diario (SD)";
            this.seImporte.EditValueChanged += new System.EventHandler(this.seImporte_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(113, 46);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(9, 19);
            this.labelControl1.TabIndex = 31;
            this.labelControl1.Text = "$";
            // 
            // rdSinImporte
            // 
            this.rdSinImporte.AutoSize = true;
            this.rdSinImporte.Checked = true;
            this.rdSinImporte.Location = new System.Drawing.Point(13, 25);
            this.rdSinImporte.Name = "rdSinImporte";
            this.rdSinImporte.Size = new System.Drawing.Size(80, 17);
            this.rdSinImporte.TabIndex = 33;
            this.rdSinImporte.TabStop = true;
            this.rdSinImporte.Text = "Sin Importe";
            this.rdSinImporte.UseVisualStyleBackColor = true;
            this.rdSinImporte.CheckedChanged += new System.EventHandler(this.rdSinImporte_CheckedChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lblImporteLetraSC);
            this.groupControl1.Controls.Add(this.lblImporteLetra);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.rdConImporte);
            this.groupControl1.Controls.Add(this.seImporteSC);
            this.groupControl1.Controls.Add(this.rdSinImporte);
            this.groupControl1.Controls.Add(this.lblImporteLetraSA);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.seImporte);
            this.groupControl1.Controls.Add(this.seImporteSA);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Location = new System.Drawing.Point(12, 53);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(632, 140);
            this.groupControl1.TabIndex = 34;
            this.groupControl1.Text = "Importe";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // lblImporteLetra
            // 
            this.lblImporteLetra.Location = new System.Drawing.Point(225, 51);
            this.lblImporteLetra.Name = "lblImporteLetra";
            this.lblImporteLetra.Size = new System.Drawing.Size(0, 13);
            this.lblImporteLetra.TabIndex = 35;
            // 
            // rdConImporte
            // 
            this.rdConImporte.AutoSize = true;
            this.rdConImporte.Location = new System.Drawing.Point(13, 48);
            this.rdConImporte.Name = "rdConImporte";
            this.rdConImporte.Size = new System.Drawing.Size(85, 17);
            this.rdConImporte.TabIndex = 34;
            this.rdConImporte.Text = "Con Importe";
            this.rdConImporte.UseVisualStyleBackColor = true;
            this.rdConImporte.CheckedChanged += new System.EventHandler(this.rdConImporte_CheckedChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.ImageOptions.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(346, 307);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(146, 23);
            this.btnCancelar.TabIndex = 36;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.ImageOptions.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(498, 307);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(146, 23);
            this.btnAceptar.TabIndex = 35;
            this.btnAceptar.Text = "Confirmar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // stpSelNominaCFDIBindingNavigator
            // 
            this.stpSelNominaCFDIBindingNavigator.AddNewItem = null;
            this.stpSelNominaCFDIBindingNavigator.CountItem = null;
            this.stpSelNominaCFDIBindingNavigator.CountItemFormat = "de {0}";
            this.stpSelNominaCFDIBindingNavigator.DeleteItem = null;
            this.stpSelNominaCFDIBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripSeparator1});
            this.stpSelNominaCFDIBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.stpSelNominaCFDIBindingNavigator.MoveFirstItem = null;
            this.stpSelNominaCFDIBindingNavigator.MoveLastItem = null;
            this.stpSelNominaCFDIBindingNavigator.MoveNextItem = null;
            this.stpSelNominaCFDIBindingNavigator.MovePreviousItem = null;
            this.stpSelNominaCFDIBindingNavigator.Name = "stpSelNominaCFDIBindingNavigator";
            this.stpSelNominaCFDIBindingNavigator.PositionItem = null;
            this.stpSelNominaCFDIBindingNavigator.Size = new System.Drawing.Size(654, 25);
            this.stpSelNominaCFDIBindingNavigator.TabIndex = 37;
            this.stpSelNominaCFDIBindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::winAppSAIC.Properties.Resources.Salir24x24;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(49, 22);
            this.toolStripButton2.Text = "Salir";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.UpEditTenedoraSC);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.lblDepartamento);
            this.groupControl2.Controls.Add(this.gridLookUpFirmanteCartas);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Location = new System.Drawing.Point(12, 199);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(632, 102);
            this.groupControl2.TabIndex = 36;
            // 
            // UpEditTenedoraSC
            // 
            this.UpEditTenedoraSC.Location = new System.Drawing.Point(122, 24);
            this.UpEditTenedoraSC.Name = "UpEditTenedoraSC";
            this.UpEditTenedoraSC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.UpEditTenedoraSC.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RazonSocial", "Razon Social", 70, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.UpEditTenedoraSC.Properties.DataSource = this.stpSelObtenerInfoGenericaTenedoraSC1BindingSource;
            this.UpEditTenedoraSC.Properties.DisplayMember = "RazonSocial";
            this.UpEditTenedoraSC.Properties.NullText = "";
            this.UpEditTenedoraSC.Properties.ValueMember = "IdTenedora";
            this.UpEditTenedoraSC.Size = new System.Drawing.Size(302, 20);
            this.UpEditTenedoraSC.TabIndex = 40;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(16, 28);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(104, 13);
            this.labelControl3.TabIndex = 39;
            this.labelControl3.Text = "Tenedora Excedente:";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.Location = new System.Drawing.Point(125, 71);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(0, 13);
            this.lblDepartamento.TabIndex = 36;
            // 
            // gridLookUpFirmanteCartas
            // 
            this.gridLookUpFirmanteCartas.Location = new System.Drawing.Point(122, 47);
            this.gridLookUpFirmanteCartas.Name = "gridLookUpFirmanteCartas";
            this.gridLookUpFirmanteCartas.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpFirmanteCartas.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idFirmantesCarta", "id Firmantes Carta", 111, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NombreCompleto", "Nombre Completo", 95, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Puesto", "Puesto", 43, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.gridLookUpFirmanteCartas.Properties.DataSource = this.stpSelFirmanteCartasBindingSource;
            this.gridLookUpFirmanteCartas.Properties.DisplayMember = "NombreCompleto";
            this.gridLookUpFirmanteCartas.Properties.NullText = "";
            this.gridLookUpFirmanteCartas.Properties.ValueMember = "idFirmantesCarta";
            this.gridLookUpFirmanteCartas.Size = new System.Drawing.Size(302, 20);
            this.gridLookUpFirmanteCartas.TabIndex = 38;
            this.gridLookUpFirmanteCartas.EditValueChanged += new System.EventHandler(this.gridLookUpFirmanteCartas_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(74, 50);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Firmante:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(11, 78);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(93, 13);
            this.labelControl4.TabIndex = 38;
            this.labelControl4.Text = "Neto Mensual S.A.:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(11, 105);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(93, 13);
            this.labelControl5.TabIndex = 39;
            this.labelControl5.Text = "Neto Mensual S.C.:";
            // 
            // lblImporteLetraSA
            // 
            this.lblImporteLetraSA.Location = new System.Drawing.Point(224, 79);
            this.lblImporteLetraSA.Name = "lblImporteLetraSA";
            this.lblImporteLetraSA.Size = new System.Drawing.Size(0, 13);
            this.lblImporteLetraSA.TabIndex = 42;
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(112, 74);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(9, 19);
            this.labelControl7.TabIndex = 41;
            this.labelControl7.Text = "$";
            // 
            // seImporteSA
            // 
            this.seImporteSA.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seImporteSA.Location = new System.Drawing.Point(124, 73);
            this.seImporteSA.Name = "seImporteSA";
            this.seImporteSA.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.seImporteSA.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.seImporteSA.Properties.Appearance.Options.UseBackColor = true;
            this.seImporteSA.Properties.Appearance.Options.UseFont = true;
            this.seImporteSA.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seImporteSA.Properties.DisplayFormat.FormatString = "N2";
            this.seImporteSA.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seImporteSA.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.seImporteSA.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.seImporteSA.Size = new System.Drawing.Size(97, 22);
            this.seImporteSA.TabIndex = 40;
            this.seImporteSA.Tag = "Salario Diario (SD)";
            this.seImporteSA.EditValueChanged += new System.EventHandler(this.seImporteSA_EditValueChanged);
            // 
            // lblImporteLetraSC
            // 
            this.lblImporteLetraSC.Location = new System.Drawing.Point(224, 106);
            this.lblImporteLetraSC.Name = "lblImporteLetraSC";
            this.lblImporteLetraSC.Size = new System.Drawing.Size(0, 13);
            this.lblImporteLetraSC.TabIndex = 45;
            // 
            // labelControl9
            // 
            this.labelControl9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(112, 101);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(9, 19);
            this.labelControl9.TabIndex = 44;
            this.labelControl9.Text = "$";
            // 
            // seImporteSC
            // 
            this.seImporteSC.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seImporteSC.Location = new System.Drawing.Point(124, 100);
            this.seImporteSC.Name = "seImporteSC";
            this.seImporteSC.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.seImporteSC.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.seImporteSC.Properties.Appearance.Options.UseBackColor = true;
            this.seImporteSC.Properties.Appearance.Options.UseFont = true;
            this.seImporteSC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seImporteSC.Properties.DisplayFormat.FormatString = "N2";
            this.seImporteSC.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seImporteSC.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.seImporteSC.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.seImporteSC.Size = new System.Drawing.Size(97, 22);
            this.seImporteSC.TabIndex = 43;
            this.seImporteSC.Tag = "Salario Diario (SD)";
            this.seImporteSC.EditValueChanged += new System.EventHandler(this.seImporteSC_EditValueChanged);
            // 
            // stpSelObtenerInfoGenericaTenedoraSC1BindingSource
            // 
            this.stpSelObtenerInfoGenericaTenedoraSC1BindingSource.DataMember = "stpSelObtenerInfoGenericaTenedoraSC_1";
            this.stpSelObtenerInfoGenericaTenedoraSC1BindingSource.DataSource = this.dbSAICBPOCatalogosDataSet1;
            // 
            // dbSAICBPOCatalogosDataSet1
            // 
            this.dbSAICBPOCatalogosDataSet1.DataSetName = "dbSAICBPOCatalogosDataSet";
            this.dbSAICBPOCatalogosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stpSelFirmanteCartasBindingSource
            // 
            this.stpSelFirmanteCartasBindingSource.DataMember = "stpSelFirmanteCartas";
            this.stpSelFirmanteCartasBindingSource.DataSource = this.dbSAICBPOCatalogosDataSet1;
            // 
            // stpSelFirmanteCartasTableAdapter1
            // 
            this.stpSelFirmanteCartasTableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelObtenerInfoGenericaTenedoraSC_1TableAdapter1
            // 
            this.stpSelObtenerInfoGenericaTenedoraSC_1TableAdapter1.ClearBeforeFill = true;
            // 
            // xFormsSolicitarMonto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 338);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.stpSelNominaCFDIBindingNavigator);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "xFormsSolicitarMonto";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cartas";
            this.Load += new System.EventHandler(this.lnlImporteLetra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.seImporte.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelNominaCFDIBindingNavigator)).EndInit();
            this.stpSelNominaCFDIBindingNavigator.ResumeLayout(false);
            this.stpSelNominaCFDIBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpEditTenedoraSC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpFirmanteCartas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seImporteSA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seImporteSC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelObtenerInfoGenericaTenedoraSC1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelFirmanteCartasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblTitulo;
        private DevExpress.XtraEditors.SpinEdit seImporte;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.RadioButton rdSinImporte;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl lblImporteLetra;
        private System.Windows.Forms.RadioButton rdConImporte;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnAceptar;
        private System.Windows.Forms.BindingNavigator stpSelNominaCFDIBindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private dbSAICBPOCatalogosDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblDepartamento;
        private DevExpress.XtraEditors.LookUpEdit gridLookUpFirmanteCartas;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelFirmanteCartasTableAdapter stpSelFirmanteCartasTableAdapter1;
        private dbSAICBPOCatalogosDataSet dbSAICBPOCatalogosDataSet1;
        private System.Windows.Forms.BindingSource stpSelFirmanteCartasBindingSource;
        private DevExpress.XtraEditors.LookUpEdit UpEditTenedoraSC;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.BindingSource stpSelObtenerInfoGenericaTenedoraSC1BindingSource;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelObtenerInfoGenericaTenedoraSC_1TableAdapter stpSelObtenerInfoGenericaTenedoraSC_1TableAdapter1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraEditors.LabelControl lblImporteLetraSC;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.SpinEdit seImporteSC;
        private DevExpress.XtraEditors.LabelControl lblImporteLetraSA;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SpinEdit seImporteSA;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}