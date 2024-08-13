namespace winAppSAIC.Facturas
{
    partial class frmAgregarConceptos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarConceptos));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btnAgregar = new System.Windows.Forms.ToolStripButton();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblConcepto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCantidad = new DevExpress.XtraEditors.SpinEdit();
            this.txtPrecio = new DevExpress.XtraEditors.SpinEdit();
            this.cboIdConcepto = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescConceptoInternoBeneficiario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIVA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRetecion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObjetoImpuesto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtIVAPor = new DevExpress.XtraEditors.TextEdit();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.cbUnidad = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtDescuentoISN = new DevExpress.XtraEditors.SpinEdit();
            this.label17 = new System.Windows.Forms.Label();
            this.lblFolioFactura = new System.Windows.Forms.Label();
            this.txtRIVA = new DevExpress.XtraEditors.SpinEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConMoneda = new DevExpress.XtraEditors.TextEdit();
            this.txtCambio = new DevExpress.XtraEditors.SpinEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.vwFactCatClaveUnidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPOFactura = new winAppSAIC.Facturas.dbSAICBPOFactura();
            this.IdFactConceptoTenedoraBeneficiario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vwFactCatClaveUnidadTableAdapter = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.vwFactCatClaveUnidadTableAdapter();
            this.spSoloRespuesta1 = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.spSoloRespuesta();
            this.stpFactSelConceptoTenedoraBeneficiarioFiltro2022BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stpFactSelConceptoTenedoraBeneficiarioFiltro2022TableAdapter = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelConceptoTenedoraBeneficiarioFiltro2022TableAdapter();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboIdConcepto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIVAPor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUnidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescuentoISN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRIVA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConMoneda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCambio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwFactCatClaveUnidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelConceptoTenedoraBeneficiarioFiltro2022BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.btnAgregar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(552, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Black;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(49, 22);
            this.toolStripButton1.Text = "Salir";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = global::winAppSAIC.Properties.Resources.SelectAll24x24;
            this.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(69, 22);
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Precio Unitario:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(26, 49);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(54, 13);
            this.lblCantidad.TabIndex = 10;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblConcepto
            // 
            this.lblConcepto.AutoSize = true;
            this.lblConcepto.Location = new System.Drawing.Point(23, 74);
            this.lblConcepto.Name = "lblConcepto";
            this.lblConcepto.Size = new System.Drawing.Size(57, 13);
            this.lblConcepto.TabIndex = 8;
            this.lblConcepto.Text = "Concepto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Complemento:";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(91, 101);
            this.txtComplemento.MaxLength = 399;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(432, 37);
            this.txtComplemento.TabIndex = 3;
            this.txtComplemento.Tag = "Complemento";
            this.txtComplemento.Text = "";
            this.txtComplemento.TextChanged += new System.EventHandler(this.txtComplemento_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Unidad:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtCantidad.Location = new System.Drawing.Point(91, 46);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtCantidad.Properties.DisplayFormat.FormatString = "C2";
            this.txtCantidad.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtCantidad.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtCantidad.Size = new System.Drawing.Size(82, 20);
            this.txtCantidad.TabIndex = 0;
            this.txtCantidad.Tag = "Cantidad";
            // 
            // txtPrecio
            // 
            this.txtPrecio.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtPrecio.Location = new System.Drawing.Point(91, 144);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtPrecio.Properties.DisplayFormat.FormatString = "C2";
            this.txtPrecio.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPrecio.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtPrecio.Size = new System.Drawing.Size(82, 20);
            this.txtPrecio.TabIndex = 4;
            this.txtPrecio.Tag = "Precio Unitario";
            this.txtPrecio.EditValueChanged += new System.EventHandler(this.txtPrecio_EditValueChanged);
            // 
            // cboIdConcepto
            // 
            this.cboIdConcepto.Location = new System.Drawing.Point(91, 72);
            this.cboIdConcepto.Name = "cboIdConcepto";
            this.cboIdConcepto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboIdConcepto.Properties.DataSource = this.stpFactSelConceptoTenedoraBeneficiarioFiltro2022BindingSource;
            this.cboIdConcepto.Properties.DisplayMember = "DescConceptoInternoBeneficiario";
            this.cboIdConcepto.Properties.NullText = "";
            this.cboIdConcepto.Properties.PopupSizeable = false;
            this.cboIdConcepto.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboIdConcepto.Properties.ValueMember = "IdFactConcBeneficiario";
            this.cboIdConcepto.Properties.View = this.gridLookUpEdit1View;
            this.cboIdConcepto.Size = new System.Drawing.Size(432, 20);
            this.cboIdConcepto.TabIndex = 2;
            this.cboIdConcepto.Tag = "Concepto";
            this.cboIdConcepto.EditValueChanged += new System.EventHandler(this.cboIdConcepto_EditValueChanged);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdFactConceptoTenedoraBeneficiario,
            this.gridColumn5,
            this.colDescConceptoInternoBeneficiario,
            this.colIVA,
            this.colRetecion,
            this.colObjetoImpuesto});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            this.gridLookUpEdit1View.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colIVA, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Concepto";
            this.gridColumn5.FieldName = "DescConceptoInterno";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 1;
            this.gridColumn5.Width = 218;
            // 
            // colDescConceptoInternoBeneficiario
            // 
            this.colDescConceptoInternoBeneficiario.Caption = "Concepto Interno";
            this.colDescConceptoInternoBeneficiario.FieldName = "DescConceptoInternoBeneficiario";
            this.colDescConceptoInternoBeneficiario.Name = "colDescConceptoInternoBeneficiario";
            this.colDescConceptoInternoBeneficiario.Visible = true;
            this.colDescConceptoInternoBeneficiario.VisibleIndex = 0;
            this.colDescConceptoInternoBeneficiario.Width = 276;
            // 
            // colIVA
            // 
            this.colIVA.Caption = "IVA";
            this.colIVA.FieldName = "IVA";
            this.colIVA.Name = "colIVA";
            this.colIVA.Visible = true;
            this.colIVA.VisibleIndex = 2;
            this.colIVA.Width = 59;
            // 
            // colRetecion
            // 
            this.colRetecion.Caption = "Retención";
            this.colRetecion.FieldName = "Retencion";
            this.colRetecion.Name = "colRetecion";
            this.colRetecion.Visible = true;
            this.colRetecion.VisibleIndex = 3;
            this.colRetecion.Width = 68;
            // 
            // colObjetoImpuesto
            // 
            this.colObjetoImpuesto.Caption = "No Objeto Impuesto";
            this.colObjetoImpuesto.FieldName = "ObjetoImpuesto";
            this.colObjetoImpuesto.Name = "colObjetoImpuesto";
            this.colObjetoImpuesto.Visible = true;
            this.colObjetoImpuesto.VisibleIndex = 4;
            this.colObjetoImpuesto.Width = 71;
            // 
            // txtIVAPor
            // 
            this.txtIVAPor.EditValue = "16";
            this.txtIVAPor.Enabled = false;
            this.txtIVAPor.Location = new System.Drawing.Point(252, 144);
            this.txtIVAPor.Name = "txtIVAPor";
            this.txtIVAPor.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtIVAPor.Properties.Appearance.Options.UseBackColor = true;
            this.txtIVAPor.Size = new System.Drawing.Size(25, 20);
            this.txtIVAPor.TabIndex = 5;
            this.txtIVAPor.Tag = "IVA";
            // 
            // labelControl18
            // 
            this.labelControl18.Location = new System.Drawing.Point(278, 147);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(11, 13);
            this.labelControl18.TabIndex = 84;
            this.labelControl18.Text = "%";
            // 
            // cbUnidad
            // 
            this.cbUnidad.Location = new System.Drawing.Point(382, 46);
            this.cbUnidad.Name = "cbUnidad";
            this.cbUnidad.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbUnidad.Properties.DataSource = this.vwFactCatClaveUnidadBindingSource;
            this.cbUnidad.Properties.DisplayMember = "Nombre";
            this.cbUnidad.Properties.NullText = "";
            this.cbUnidad.Properties.PopupSizeable = false;
            this.cbUnidad.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbUnidad.Properties.ValueMember = "IdFactClaveUnidad";
            this.cbUnidad.Properties.View = this.gridView1;
            this.cbUnidad.Size = new System.Drawing.Size(141, 20);
            this.cbUnidad.TabIndex = 1;
            this.cbUnidad.Tag = "Unidad";
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.FieldName = "IdFactClaveUnidad";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Unidad";
            this.gridColumn2.FieldName = "Nombre";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 83;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Clave";
            this.gridColumn3.FieldName = "Clave";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 57;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Descripción";
            this.gridColumn4.FieldName = "Desc";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 228;
            // 
            // txtDescuentoISN
            // 
            this.txtDescuentoISN.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtDescuentoISN.Location = new System.Drawing.Point(431, 144);
            this.txtDescuentoISN.Name = "txtDescuentoISN";
            this.txtDescuentoISN.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDescuentoISN.Properties.DisplayFormat.FormatString = "C2";
            this.txtDescuentoISN.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDescuentoISN.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtDescuentoISN.Size = new System.Drawing.Size(92, 20);
            this.txtDescuentoISN.TabIndex = 6;
            this.txtDescuentoISN.Tag = "Tipo Cambio";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(343, 147);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 13);
            this.label17.TabIndex = 231;
            this.label17.Text = "Descuento ISN:";
            // 
            // lblFolioFactura
            // 
            this.lblFolioFactura.AutoSize = true;
            this.lblFolioFactura.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolioFactura.Location = new System.Drawing.Point(181, 25);
            this.lblFolioFactura.Name = "lblFolioFactura";
            this.lblFolioFactura.Size = new System.Drawing.Size(96, 18);
            this.lblFolioFactura.TabIndex = 232;
            this.lblFolioFactura.Text = "Serie-Folio:";
            // 
            // txtRIVA
            // 
            this.txtRIVA.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtRIVA.Enabled = false;
            this.txtRIVA.Location = new System.Drawing.Point(91, 167);
            this.txtRIVA.Name = "txtRIVA";
            this.txtRIVA.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtRIVA.Properties.DisplayFormat.FormatString = "C2";
            this.txtRIVA.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtRIVA.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtRIVA.Size = new System.Drawing.Size(82, 20);
            this.txtRIVA.TabIndex = 237;
            this.txtRIVA.Tag = "Precio Unitario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 236;
            this.label2.Text = "Retención IVA:";
            // 
            // txtConMoneda
            // 
            this.txtConMoneda.EditValue = "0";
            this.txtConMoneda.Location = new System.Drawing.Point(176, 145);
            this.txtConMoneda.Name = "txtConMoneda";
            this.txtConMoneda.Properties.ReadOnly = true;
            this.txtConMoneda.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtConMoneda.Size = new System.Drawing.Size(73, 20);
            this.txtConMoneda.TabIndex = 246;
            // 
            // txtCambio
            // 
            this.txtCambio.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtCambio.Enabled = false;
            this.txtCambio.Location = new System.Drawing.Point(431, 167);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtCambio.Properties.DisplayFormat.FormatString = "C2";
            this.txtCambio.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtCambio.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtCambio.Size = new System.Drawing.Size(92, 20);
            this.txtCambio.TabIndex = 244;
            this.txtCambio.Tag = "Tipo Cambio";
            this.txtCambio.EditValueChanged += new System.EventHandler(this.txtCambio_EditValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(360, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 245;
            this.label7.Text = "Tipo Cambio:";
            // 
            // vwFactCatClaveUnidadBindingSource
            // 
            this.vwFactCatClaveUnidadBindingSource.DataMember = "vwFactCatClaveUnidad";
            this.vwFactCatClaveUnidadBindingSource.DataSource = this.dbSAICBPOFactura;
            // 
            // dbSAICBPOFactura
            // 
            this.dbSAICBPOFactura.DataSetName = "dbSAICBPOFactura";
            this.dbSAICBPOFactura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // IdFactConceptoTenedoraBeneficiario
            // 
            this.IdFactConceptoTenedoraBeneficiario.Caption = "ID";
            this.IdFactConceptoTenedoraBeneficiario.FieldName = "IdFactConceptoTenedoraBeneficiario";
            this.IdFactConceptoTenedoraBeneficiario.Name = "IdFactConceptoTenedoraBeneficiario";
            // 
            // vwFactCatClaveUnidadTableAdapter
            // 
            this.vwFactCatClaveUnidadTableAdapter.ClearBeforeFill = true;
            // 
            // stpFactSelConceptoTenedoraBeneficiarioFiltro2022BindingSource
            // 
            this.stpFactSelConceptoTenedoraBeneficiarioFiltro2022BindingSource.DataMember = "stpFactSelConceptoTenedoraBeneficiarioFiltro2022";
            this.stpFactSelConceptoTenedoraBeneficiarioFiltro2022BindingSource.DataSource = this.dbSAICBPOFactura;
            // 
            // stpFactSelConceptoTenedoraBeneficiarioFiltro2022TableAdapter
            // 
            this.stpFactSelConceptoTenedoraBeneficiarioFiltro2022TableAdapter.ClearBeforeFill = true;
            // 
            // frmAgregarConceptos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 199);
            this.ControlBox = false;
            this.Controls.Add(this.txtConMoneda);
            this.Controls.Add(this.txtCambio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRIVA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFolioFactura);
            this.Controls.Add(this.txtDescuentoISN);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cbUnidad);
            this.Controls.Add(this.txtIVAPor);
            this.Controls.Add(this.labelControl18);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblConcepto);
            this.Controls.Add(this.cboIdConcepto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAgregarConceptos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Concepto";
            this.Load += new System.EventHandler(this.frmAgregarConceptos_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboIdConcepto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIVAPor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUnidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescuentoISN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRIVA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConMoneda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCambio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwFactCatClaveUnidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelConceptoTenedoraBeneficiarioFiltro2022BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton btnAgregar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblConcepto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtComplemento;
        private System.Windows.Forms.Label label4;
        private dbSAICBPOFactura dbSAICBPOFactura;
        private System.Windows.Forms.BindingSource vwFactCatClaveUnidadBindingSource;
        private dbSAICBPOFacturaTableAdapters.vwFactCatClaveUnidadTableAdapter vwFactCatClaveUnidadTableAdapter;
        private DevExpress.XtraEditors.SpinEdit txtCantidad;
        private DevExpress.XtraEditors.SpinEdit txtPrecio;
        private DevExpress.XtraEditors.GridLookUpEdit cboIdConcepto;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn IdFactConceptoTenedoraBeneficiario;
        private DevExpress.XtraGrid.Columns.GridColumn colDescConceptoInternoBeneficiario;
        private DevExpress.XtraGrid.Columns.GridColumn colIVA;
        private DevExpress.XtraEditors.TextEdit txtIVAPor;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.GridLookUpEdit cbUnidad;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.SpinEdit txtDescuentoISN;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblFolioFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colRetecion;
        private DevExpress.XtraEditors.SpinEdit txtRIVA;
        private System.Windows.Forms.Label label2;
        private dbSAICBPOFacturaTableAdapters.spSoloRespuesta spSoloRespuesta1;
        private DevExpress.XtraGrid.Columns.GridColumn colObjetoImpuesto;
        private DevExpress.XtraEditors.TextEdit txtConMoneda;
        private DevExpress.XtraEditors.SpinEdit txtCambio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource stpFactSelConceptoTenedoraBeneficiarioFiltro2022BindingSource;
        private dbSAICBPOFacturaTableAdapters.stpFactSelConceptoTenedoraBeneficiarioFiltro2022TableAdapter stpFactSelConceptoTenedoraBeneficiarioFiltro2022TableAdapter;
    }
}