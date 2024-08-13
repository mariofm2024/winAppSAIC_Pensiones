namespace winAppSAIC.Facturas
{
    partial class frmActualizarConceptos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActualizarConceptos));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btnAgregar = new System.Windows.Forms.ToolStripButton();
            this.lblConcepto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.RichTextBox();
            this.cboIdConcepto = new DevExpress.XtraEditors.GridLookUpEdit();
            this.stpFactSelConceptoTenedoraBeneficiarioFiltroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPOFactura = new winAppSAIC.Facturas.dbSAICBPOFactura();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdFactConceptoTenedoraBeneficiario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescConceptoInternoBeneficiario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIVA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbUnidad = new DevExpress.XtraEditors.GridLookUpEdit();
            this.vwFactCatClaveUnidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtCantidad = new DevExpress.XtraEditors.SpinEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.stpFactSelConceptoTenedoraBeneficiarioFiltroTableAdapter = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelConceptoTenedoraBeneficiarioFiltroTableAdapter();
            this.spSoloRespuesta1 = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.spSoloRespuesta();
            this.vwFactCatClaveUnidadTableAdapter = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.vwFactCatClaveUnidadTableAdapter();
            this.colObjetoImpuesto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboIdConcepto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelConceptoTenedoraBeneficiarioFiltroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUnidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwFactCatClaveUnidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.btnAgregar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(553, 25);
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
            this.btnAgregar.Size = new System.Drawing.Size(79, 22);
            this.btnAgregar.Text = "Actualizar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblConcepto
            // 
            this.lblConcepto.AutoSize = true;
            this.lblConcepto.Location = new System.Drawing.Point(21, 67);
            this.lblConcepto.Name = "lblConcepto";
            this.lblConcepto.Size = new System.Drawing.Size(57, 13);
            this.lblConcepto.TabIndex = 8;
            this.lblConcepto.Text = "Concepto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Complemento:";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(89, 94);
            this.txtComplemento.MaxLength = 399;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(432, 37);
            this.txtComplemento.TabIndex = 3;
            this.txtComplemento.Tag = "Complemento";
            this.txtComplemento.Text = "";
            this.txtComplemento.TextChanged += new System.EventHandler(this.txtComplemento_TextChanged);
            // 
            // cboIdConcepto
            // 
            this.cboIdConcepto.Location = new System.Drawing.Point(89, 65);
            this.cboIdConcepto.Name = "cboIdConcepto";
            this.cboIdConcepto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboIdConcepto.Properties.DataSource = this.stpFactSelConceptoTenedoraBeneficiarioFiltroBindingSource;
            this.cboIdConcepto.Properties.DisplayMember = "DescConceptoInternoBeneficiario";
            this.cboIdConcepto.Properties.NullText = "";
            this.cboIdConcepto.Properties.PopupSizeable = false;
            this.cboIdConcepto.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboIdConcepto.Properties.ValueMember = "IdFactConcBeneficiario";
            this.cboIdConcepto.Properties.View = this.gridLookUpEdit1View;
            this.cboIdConcepto.Size = new System.Drawing.Size(432, 20);
            this.cboIdConcepto.TabIndex = 21;
            this.cboIdConcepto.Tag = "Concepto";
            // 
            // stpFactSelConceptoTenedoraBeneficiarioFiltroBindingSource
            // 
            this.stpFactSelConceptoTenedoraBeneficiarioFiltroBindingSource.DataMember = "stpFactSelConceptoTenedoraBeneficiarioFiltro";
            this.stpFactSelConceptoTenedoraBeneficiarioFiltroBindingSource.DataSource = this.dbSAICBPOFactura;
            // 
            // dbSAICBPOFactura
            // 
            this.dbSAICBPOFactura.DataSetName = "dbSAICBPOFactura";
            this.dbSAICBPOFactura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdFactConceptoTenedoraBeneficiario,
            this.colDescConceptoInternoBeneficiario,
            this.gridColumn5,
            this.colIVA,
            this.colObjetoImpuesto});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            this.gridLookUpEdit1View.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colIVA, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // IdFactConceptoTenedoraBeneficiario
            // 
            this.IdFactConceptoTenedoraBeneficiario.Caption = "ID";
            this.IdFactConceptoTenedoraBeneficiario.FieldName = "IdFactConceptoTenedoraBeneficiario";
            this.IdFactConceptoTenedoraBeneficiario.Name = "IdFactConceptoTenedoraBeneficiario";
            // 
            // colDescConceptoInternoBeneficiario
            // 
            this.colDescConceptoInternoBeneficiario.Caption = "Concepto Interno";
            this.colDescConceptoInternoBeneficiario.FieldName = "DescConceptoInternoBeneficiario";
            this.colDescConceptoInternoBeneficiario.Name = "colDescConceptoInternoBeneficiario";
            this.colDescConceptoInternoBeneficiario.Visible = true;
            this.colDescConceptoInternoBeneficiario.VisibleIndex = 0;
            this.colDescConceptoInternoBeneficiario.Width = 398;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Concepto";
            this.gridColumn5.FieldName = "DescConceptoInterno";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 1;
            this.gridColumn5.Width = 418;
            // 
            // colIVA
            // 
            this.colIVA.Caption = "IVA";
            this.colIVA.FieldName = "IVA";
            this.colIVA.Name = "colIVA";
            this.colIVA.Visible = true;
            this.colIVA.VisibleIndex = 2;
            this.colIVA.Width = 56;
            // 
            // cbUnidad
            // 
            this.cbUnidad.Location = new System.Drawing.Point(380, 39);
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
            this.cbUnidad.TabIndex = 89;
            this.cbUnidad.Tag = "Concepto";
            // 
            // vwFactCatClaveUnidadBindingSource
            // 
            this.vwFactCatClaveUnidadBindingSource.DataMember = "vwFactCatClaveUnidad";
            this.vwFactCatClaveUnidadBindingSource.DataSource = this.dbSAICBPOFactura;
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
            // txtCantidad
            // 
            this.txtCantidad.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtCantidad.Location = new System.Drawing.Point(89, 39);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtCantidad.Properties.DisplayFormat.FormatString = "C2";
            this.txtCantidad.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtCantidad.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtCantidad.Size = new System.Drawing.Size(82, 20);
            this.txtCantidad.TabIndex = 86;
            this.txtCantidad.Tag = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 88;
            this.label4.Text = "Unidad:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(24, 42);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(54, 13);
            this.lblCantidad.TabIndex = 87;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // stpFactSelConceptoTenedoraBeneficiarioFiltroTableAdapter
            // 
            this.stpFactSelConceptoTenedoraBeneficiarioFiltroTableAdapter.ClearBeforeFill = true;
            // 
            // vwFactCatClaveUnidadTableAdapter
            // 
            this.vwFactCatClaveUnidadTableAdapter.ClearBeforeFill = true;
            // 
            // colObjetoImpuesto
            // 
            this.colObjetoImpuesto.Caption = "No Objeto Impuesto";
            this.colObjetoImpuesto.FieldName = "ObjetoImpuesto";
            this.colObjetoImpuesto.Name = "colObjetoImpuesto";
            this.colObjetoImpuesto.Visible = true;
            this.colObjetoImpuesto.VisibleIndex = 3;
            // 
            // frmActualizarConceptos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 146);
            this.ControlBox = false;
            this.Controls.Add(this.cbUnidad);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblConcepto);
            this.Controls.Add(this.cboIdConcepto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmActualizarConceptos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar Concepto";
            this.Load += new System.EventHandler(this.frmAgregarConceptos_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboIdConcepto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelConceptoTenedoraBeneficiarioFiltroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUnidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwFactCatClaveUnidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton btnAgregar;
        private System.Windows.Forms.Label lblConcepto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtComplemento;
        private dbSAICBPOFactura dbSAICBPOFactura;
        private System.Windows.Forms.BindingSource stpFactSelConceptoTenedoraBeneficiarioFiltroBindingSource;
        private dbSAICBPOFacturaTableAdapters.stpFactSelConceptoTenedoraBeneficiarioFiltroTableAdapter stpFactSelConceptoTenedoraBeneficiarioFiltroTableAdapter;
        private DevExpress.XtraEditors.GridLookUpEdit cboIdConcepto;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn IdFactConceptoTenedoraBeneficiario;
        private DevExpress.XtraGrid.Columns.GridColumn colDescConceptoInternoBeneficiario;
        private DevExpress.XtraGrid.Columns.GridColumn colIVA;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.GridLookUpEdit cbUnidad;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.SpinEdit txtCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCantidad;
        private dbSAICBPOFacturaTableAdapters.spSoloRespuesta spSoloRespuesta1;
        private System.Windows.Forms.BindingSource vwFactCatClaveUnidadBindingSource;
        private dbSAICBPOFacturaTableAdapters.vwFactCatClaveUnidadTableAdapter vwFactCatClaveUnidadTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colObjetoImpuesto;
    }
}