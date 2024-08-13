namespace winAppSAIC.Facturas
{
    partial class frmCancelarFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCancelarFactura));
            this.txtJustifi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbFacturaRelacion = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView9 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdHeaderFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColSerie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColFolioInterno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColDescMetodoPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColDescFormadPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColTotalF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaGeneracionCFDI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColUUID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbMotivoCancelacion = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cbID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.desc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.stpFactSelFacturasARelacionarSATBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPOFactura = new winAppSAIC.Facturas.dbSAICBPOFactura();
            this.factMotivoCancelacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spSoloRespuesta1 = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.spSoloRespuesta();
            this.factMotivoCancelacionTableAdapter1 = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.FactMotivoCancelacionTableAdapter();
            this.stpFactSelFacturasARelacionarSATTableAdapter1 = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelFacturasARelacionarSATTableAdapter();
            this.stpFactSelMotivoCancelacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stpFactSelMotivoCancelacionTableAdapter = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelMotivoCancelacionTableAdapter();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbFacturaRelacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMotivoCancelacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelFacturasARelacionarSATBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factMotivoCancelacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelMotivoCancelacionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtJustifi
            // 
            this.txtJustifi.Location = new System.Drawing.Point(138, 72);
            this.txtJustifi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtJustifi.Multiline = true;
            this.txtJustifi.Name = "txtJustifi";
            this.txtJustifi.Size = new System.Drawing.Size(415, 47);
            this.txtJustifi.TabIndex = 3;
            this.txtJustifi.Tag = "Motivo Interno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Motivo Interno:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.btnCancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(566, 27);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Black;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(62, 24);
            this.toolStripButton1.Text = "Salir";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::winAppSAIC.Properties.Resources.DocsCancelados32x32_1;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(141, 24);
            this.btnCancelar.Text = "Cancelar Timbre";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Motivo SAT:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(601, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 17);
            this.label11.TabIndex = 98;
            this.label11.Text = "Factura de Relación:";
            // 
            // cbFacturaRelacion
            // 
            this.cbFacturaRelacion.Location = new System.Drawing.Point(732, 71);
            this.cbFacturaRelacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbFacturaRelacion.Name = "cbFacturaRelacion";
            this.cbFacturaRelacion.Properties.Appearance.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.cbFacturaRelacion.Properties.Appearance.Options.UseBackColor = true;
            this.cbFacturaRelacion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbFacturaRelacion.Properties.DataSource = this.stpFactSelFacturasARelacionarSATBindingSource;
            this.cbFacturaRelacion.Properties.DisplayMember = "IdHeaderFactura";
            this.cbFacturaRelacion.Properties.NullText = "";
            this.cbFacturaRelacion.Properties.ValueMember = "IdHeaderFactura";
            this.cbFacturaRelacion.Properties.View = this.gridView9;
            this.cbFacturaRelacion.Size = new System.Drawing.Size(415, 22);
            this.cbFacturaRelacion.TabIndex = 2;
            this.cbFacturaRelacion.Tag = "Factura de Relación";
            // 
            // gridView9
            // 
            this.gridView9.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdHeaderFactura,
            this.ColSerie,
            this.ColFolioInterno,
            this.ColDescMetodoPago,
            this.ColDescFormadPago,
            this.ColTotalF,
            this.colFechaGeneracionCFDI,
            this.ColUUID,
            this.colEstatus});
            this.gridView9.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView9.Name = "gridView9";
            this.gridView9.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView9.OptionsView.ColumnAutoWidth = false;
            this.gridView9.OptionsView.ShowGroupPanel = false;
            // 
            // colIdHeaderFactura
            // 
            this.colIdHeaderFactura.Caption = "Id Factura";
            this.colIdHeaderFactura.FieldName = "IdHeaderFactura";
            this.colIdHeaderFactura.Name = "colIdHeaderFactura";
            this.colIdHeaderFactura.Visible = true;
            this.colIdHeaderFactura.VisibleIndex = 0;
            this.colIdHeaderFactura.Width = 70;
            // 
            // ColSerie
            // 
            this.ColSerie.Caption = "Serie";
            this.ColSerie.FieldName = "Serie";
            this.ColSerie.Name = "ColSerie";
            this.ColSerie.Visible = true;
            this.ColSerie.VisibleIndex = 1;
            this.ColSerie.Width = 48;
            // 
            // ColFolioInterno
            // 
            this.ColFolioInterno.Caption = "Folio";
            this.ColFolioInterno.FieldName = "FolioInterno";
            this.ColFolioInterno.Name = "ColFolioInterno";
            this.ColFolioInterno.Visible = true;
            this.ColFolioInterno.VisibleIndex = 2;
            this.ColFolioInterno.Width = 52;
            // 
            // ColDescMetodoPago
            // 
            this.ColDescMetodoPago.Caption = "Metodo de Pago";
            this.ColDescMetodoPago.FieldName = "ClaveMetodoPago";
            this.ColDescMetodoPago.Name = "ColDescMetodoPago";
            this.ColDescMetodoPago.Visible = true;
            this.ColDescMetodoPago.VisibleIndex = 3;
            this.ColDescMetodoPago.Width = 98;
            // 
            // ColDescFormadPago
            // 
            this.ColDescFormadPago.Caption = "Forma de Pago";
            this.ColDescFormadPago.FieldName = "DescFormaPago";
            this.ColDescFormadPago.Name = "ColDescFormadPago";
            this.ColDescFormadPago.Visible = true;
            this.ColDescFormadPago.VisibleIndex = 4;
            this.ColDescFormadPago.Width = 92;
            // 
            // ColTotalF
            // 
            this.ColTotalF.Caption = "Total";
            this.ColTotalF.DisplayFormat.FormatString = "C2";
            this.ColTotalF.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ColTotalF.FieldName = "Total";
            this.ColTotalF.Name = "ColTotalF";
            this.ColTotalF.Visible = true;
            this.ColTotalF.VisibleIndex = 5;
            this.ColTotalF.Width = 97;
            // 
            // colFechaGeneracionCFDI
            // 
            this.colFechaGeneracionCFDI.Caption = "Fecha";
            this.colFechaGeneracionCFDI.FieldName = "FechaGeneracionCFDI";
            this.colFechaGeneracionCFDI.Name = "colFechaGeneracionCFDI";
            this.colFechaGeneracionCFDI.Visible = true;
            this.colFechaGeneracionCFDI.VisibleIndex = 6;
            // 
            // ColUUID
            // 
            this.ColUUID.Caption = "UUID";
            this.ColUUID.FieldName = "UUID";
            this.ColUUID.Name = "ColUUID";
            this.ColUUID.Visible = true;
            this.ColUUID.VisibleIndex = 7;
            this.ColUUID.Width = 197;
            // 
            // colEstatus
            // 
            this.colEstatus.Caption = "Estatus";
            this.colEstatus.FieldName = "EstatusDocumento";
            this.colEstatus.Name = "colEstatus";
            this.colEstatus.Visible = true;
            this.colEstatus.VisibleIndex = 8;
            // 
            // cbMotivoCancelacion
            // 
            this.cbMotivoCancelacion.Location = new System.Drawing.Point(139, 38);
            this.cbMotivoCancelacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbMotivoCancelacion.Name = "cbMotivoCancelacion";
            this.cbMotivoCancelacion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMotivoCancelacion.Properties.DataSource = this.stpFactSelMotivoCancelacionBindingSource;
            this.cbMotivoCancelacion.Properties.DisplayMember = "Desc";
            this.cbMotivoCancelacion.Properties.NullText = "";
            this.cbMotivoCancelacion.Properties.PopupSizeable = false;
            this.cbMotivoCancelacion.Properties.ValueMember = "IdFactMotivoCancelacion";
            this.cbMotivoCancelacion.Properties.View = this.gridLookUpEdit1View;
            this.cbMotivoCancelacion.Size = new System.Drawing.Size(415, 22);
            this.cbMotivoCancelacion.TabIndex = 1;
            this.cbMotivoCancelacion.Tag = "Motivo SAT";
            this.cbMotivoCancelacion.EditValueChanged += new System.EventHandler(this.cbMotivoCancelacion_EditValueChanged);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cbID,
            this.desc});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // cbID
            // 
            this.cbID.Caption = "Id";
            this.cbID.FieldName = "IdFactMotivoCancelacion";
            this.cbID.Name = "cbID";
            this.cbID.Visible = true;
            this.cbID.VisibleIndex = 0;
            this.cbID.Width = 76;
            // 
            // desc
            // 
            this.desc.Caption = "Motivo";
            this.desc.FieldName = "Desc";
            this.desc.Name = "desc";
            this.desc.Visible = true;
            this.desc.VisibleIndex = 1;
            this.desc.Width = 616;
            // 
            // stpFactSelFacturasARelacionarSATBindingSource
            // 
            this.stpFactSelFacturasARelacionarSATBindingSource.DataMember = "stpFactSelFacturasARelacionarSAT";
            this.stpFactSelFacturasARelacionarSATBindingSource.DataSource = this.dbSAICBPOFactura;
            // 
            // dbSAICBPOFactura
            // 
            this.dbSAICBPOFactura.DataSetName = "dbSAICBPOFactura";
            this.dbSAICBPOFactura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // factMotivoCancelacionBindingSource
            // 
            this.factMotivoCancelacionBindingSource.DataMember = "FactMotivoCancelacion";
            this.factMotivoCancelacionBindingSource.DataSource = this.dbSAICBPOFactura;
            // 
            // factMotivoCancelacionTableAdapter1
            // 
            this.factMotivoCancelacionTableAdapter1.ClearBeforeFill = true;
            // 
            // stpFactSelFacturasARelacionarSATTableAdapter1
            // 
            this.stpFactSelFacturasARelacionarSATTableAdapter1.ClearBeforeFill = true;
            // 
            // stpFactSelMotivoCancelacionBindingSource
            // 
            this.stpFactSelMotivoCancelacionBindingSource.DataMember = "stpFactSelMotivoCancelacion";
            this.stpFactSelMotivoCancelacionBindingSource.DataSource = this.dbSAICBPOFactura;
            // 
            // stpFactSelMotivoCancelacionTableAdapter
            // 
            this.stpFactSelMotivoCancelacionTableAdapter.ClearBeforeFill = true;
            // 
            // frmCancelarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 140);
            this.ControlBox = false;
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbFacturaRelacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtJustifi);
            this.Controls.Add(this.cbMotivoCancelacion);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(584, 187);
            this.MinimumSize = new System.Drawing.Size(584, 187);
            this.Name = "frmCancelarFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancelar Timbre";
            this.Load += new System.EventHandler(this.frmCancelarFactura_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbFacturaRelacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMotivoCancelacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelFacturasARelacionarSATBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factMotivoCancelacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelMotivoCancelacionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtJustifi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private dbSAICBPOFacturaTableAdapters.spSoloRespuesta spSoloRespuesta1;
        private System.Windows.Forms.Label label1;
        private dbSAICBPOFacturaTableAdapters.FactMotivoCancelacionTableAdapter factMotivoCancelacionTableAdapter1;
        private System.Windows.Forms.BindingSource factMotivoCancelacionBindingSource;
        private dbSAICBPOFactura dbSAICBPOFactura;
        private System.Windows.Forms.Label label11;
        private DevExpress.XtraEditors.GridLookUpEdit cbFacturaRelacion;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView9;
        private DevExpress.XtraGrid.Columns.GridColumn colIdHeaderFactura;
        private DevExpress.XtraGrid.Columns.GridColumn ColSerie;
        private DevExpress.XtraGrid.Columns.GridColumn ColFolioInterno;
        private DevExpress.XtraGrid.Columns.GridColumn ColDescMetodoPago;
        private DevExpress.XtraGrid.Columns.GridColumn ColDescFormadPago;
        private DevExpress.XtraGrid.Columns.GridColumn ColTotalF;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaGeneracionCFDI;
        private DevExpress.XtraGrid.Columns.GridColumn ColUUID;
        private DevExpress.XtraGrid.Columns.GridColumn colEstatus;
        private dbSAICBPOFacturaTableAdapters.stpFactSelFacturasARelacionarSATTableAdapter stpFactSelFacturasARelacionarSATTableAdapter1;
        private System.Windows.Forms.BindingSource stpFactSelFacturasARelacionarSATBindingSource;
        private DevExpress.XtraEditors.GridLookUpEdit cbMotivoCancelacion;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn cbID;
        private DevExpress.XtraGrid.Columns.GridColumn desc;
        private System.Windows.Forms.BindingSource stpFactSelMotivoCancelacionBindingSource;
        private dbSAICBPOFacturaTableAdapters.stpFactSelMotivoCancelacionTableAdapter stpFactSelMotivoCancelacionTableAdapter;
    }
}