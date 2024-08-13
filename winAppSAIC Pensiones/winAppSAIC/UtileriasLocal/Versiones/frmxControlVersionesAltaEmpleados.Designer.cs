namespace winAppSAIC.Versiones
{
    partial class frmxControlVersionesAltaEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmxControlVersionesAltaEmpleados));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblNombreArchivo = new DevExpress.XtraEditors.LabelControl();
            this.btnSubirPlantilla = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.stpSelNominaCFDIBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.gridLookTipoDocumento = new DevExpress.XtraEditors.GridLookUpEdit();
            this.stpSelTipoDocumentacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPOCatalogosDataSet1 = new winAppSAIC.dbSAICBPOCatalogosDataSet();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnDocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridLookTenedora = new DevExpress.XtraEditors.GridLookUpEdit();
            this.stpSelObtenerInfoGenericaMatrizTenedora1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnTenedora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.queriesTableAdapter1 = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.QueriesTableAdapter();
            this.stpSelTipoDocumentacionTableAdapter1 = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelTipoDocumentacionTableAdapter();
            this.stpSelObtenerInfoGenericaMatrizTenedora_1TableAdapter1 = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelObtenerInfoGenericaMatrizTenedora_1TableAdapter();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelNominaCFDIBindingNavigator)).BeginInit();
            this.stpSelNominaCFDIBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookTipoDocumento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelTipoDocumentacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookTenedora.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelObtenerInfoGenericaMatrizTenedora1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(9, 43);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Archivo:";
            // 
            // lblNombreArchivo
            // 
            this.lblNombreArchivo.Location = new System.Drawing.Point(55, 44);
            this.lblNombreArchivo.Name = "lblNombreArchivo";
            this.lblNombreArchivo.Size = new System.Drawing.Size(0, 13);
            this.lblNombreArchivo.TabIndex = 1;
            // 
            // btnSubirPlantilla
            // 
            this.btnSubirPlantilla.Location = new System.Drawing.Point(416, 38);
            this.btnSubirPlantilla.Name = "btnSubirPlantilla";
            this.btnSubirPlantilla.Size = new System.Drawing.Size(95, 23);
            this.btnSubirPlantilla.TabIndex = 2;
            this.btnSubirPlantilla.Text = "Subir Archivo";
            this.btnSubirPlantilla.Click += new System.EventHandler(this.btnSubirPlantilla_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnSubirPlantilla);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.lblNombreArchivo);
            this.groupControl1.Location = new System.Drawing.Point(12, 65);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(516, 82);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Subir Documento";
            // 
            // stpSelNominaCFDIBindingNavigator
            // 
            this.stpSelNominaCFDIBindingNavigator.AddNewItem = null;
            this.stpSelNominaCFDIBindingNavigator.CountItem = null;
            this.stpSelNominaCFDIBindingNavigator.CountItemFormat = "de {0}";
            this.stpSelNominaCFDIBindingNavigator.DeleteItem = null;
            this.stpSelNominaCFDIBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator2,
            this.toolStripButton2});
            this.stpSelNominaCFDIBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.stpSelNominaCFDIBindingNavigator.MoveFirstItem = null;
            this.stpSelNominaCFDIBindingNavigator.MoveLastItem = null;
            this.stpSelNominaCFDIBindingNavigator.MoveNextItem = null;
            this.stpSelNominaCFDIBindingNavigator.MovePreviousItem = null;
            this.stpSelNominaCFDIBindingNavigator.Name = "stpSelNominaCFDIBindingNavigator";
            this.stpSelNominaCFDIBindingNavigator.PositionItem = null;
            this.stpSelNominaCFDIBindingNavigator.Size = new System.Drawing.Size(543, 25);
            this.stpSelNominaCFDIBindingNavigator.TabIndex = 18;
            this.stpSelNominaCFDIBindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::winAppSAIC.Properties.Resources.Salir24x24;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(49, 22);
            this.toolStripButton1.Text = "Salir";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(33, 42);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(81, 13);
            this.labelControl2.TabIndex = 20;
            this.labelControl2.Text = "Tipo Documento:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(300, 42);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(50, 13);
            this.labelControl3.TabIndex = 21;
            this.labelControl3.Text = "Tenedora:";
            // 
            // gridLookTipoDocumento
            // 
            this.gridLookTipoDocumento.EditValue = "vacio";
            this.gridLookTipoDocumento.Location = new System.Drawing.Point(119, 39);
            this.gridLookTipoDocumento.Name = "gridLookTipoDocumento";
            this.gridLookTipoDocumento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookTipoDocumento.Properties.DataSource = this.stpSelTipoDocumentacionBindingSource;
            this.gridLookTipoDocumento.Properties.DisplayMember = "DesTipoDocumento";
            this.gridLookTipoDocumento.Properties.ValueMember = "IdTipoDocumento";
            this.gridLookTipoDocumento.Properties.View = this.gridLookUpEdit1View;
            this.gridLookTipoDocumento.Size = new System.Drawing.Size(169, 20);
            this.gridLookTipoDocumento.TabIndex = 23;
            this.gridLookTipoDocumento.EditValueChanged += new System.EventHandler(this.gridLookTipoDocumento_EditValueChanged);
            // 
            // stpSelTipoDocumentacionBindingSource
            // 
            this.stpSelTipoDocumentacionBindingSource.DataMember = "stpSelTipoDocumentacion";
            this.stpSelTipoDocumentacionBindingSource.DataSource = this.dbSAICBPOCatalogosDataSet1;
            // 
            // dbSAICBPOCatalogosDataSet1
            // 
            this.dbSAICBPOCatalogosDataSet1.DataSetName = "dbSAICBPOCatalogosDataSet";
            this.dbSAICBPOCatalogosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnDocumento});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumnDocumento
            // 
            this.gridColumnDocumento.Caption = "Tipo Documento";
            this.gridColumnDocumento.FieldName = "DesTipoDocumento";
            this.gridColumnDocumento.Name = "gridColumnDocumento";
            this.gridColumnDocumento.Visible = true;
            this.gridColumnDocumento.VisibleIndex = 0;
            // 
            // gridLookTenedora
            // 
            this.gridLookTenedora.EditValue = "vacio";
            this.gridLookTenedora.Enabled = false;
            this.gridLookTenedora.Location = new System.Drawing.Point(357, 39);
            this.gridLookTenedora.Name = "gridLookTenedora";
            this.gridLookTenedora.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookTenedora.Properties.DataSource = this.stpSelObtenerInfoGenericaMatrizTenedora1BindingSource;
            this.gridLookTenedora.Properties.DisplayMember = "RazonSocial";
            this.gridLookTenedora.Properties.ValueMember = "IdMatrizTenedora";
            this.gridLookTenedora.Properties.View = this.gridView1;
            this.gridLookTenedora.Size = new System.Drawing.Size(169, 20);
            this.gridLookTenedora.TabIndex = 24;
            // 
            // stpSelObtenerInfoGenericaMatrizTenedora1BindingSource
            // 
            this.stpSelObtenerInfoGenericaMatrizTenedora1BindingSource.DataMember = "stpSelObtenerInfoGenericaMatrizTenedora_1";
            this.stpSelObtenerInfoGenericaMatrizTenedora1BindingSource.DataSource = this.dbSAICBPOCatalogosDataSet1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnTenedora});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumnTenedora
            // 
            this.gridColumnTenedora.Caption = "Tenedora";
            this.gridColumnTenedora.FieldName = "RazonSocial";
            this.gridColumnTenedora.Name = "gridColumnTenedora";
            this.gridColumnTenedora.Visible = true;
            this.gridColumnTenedora.VisibleIndex = 0;
            // 
            // stpSelTipoDocumentacionTableAdapter1
            // 
            this.stpSelTipoDocumentacionTableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelObtenerInfoGenericaMatrizTenedora_1TableAdapter1
            // 
            this.stpSelObtenerInfoGenericaMatrizTenedora_1TableAdapter1.ClearBeforeFill = true;
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::winAppSAIC.Properties.Resources.if_24_171492;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(79, 22);
            this.toolStripButton2.Text = "Descargar";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // frmxControlVersionesAltaEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 154);
            this.Controls.Add(this.gridLookTenedora);
            this.Controls.Add(this.gridLookTipoDocumento);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.stpSelNominaCFDIBindingNavigator);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmxControlVersionesAltaEmpleados";
            this.Text = "Control de Plantilla Alta";
            this.Load += new System.EventHandler(this.frmxControlVersionesAltaEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelNominaCFDIBindingNavigator)).EndInit();
            this.stpSelNominaCFDIBindingNavigator.ResumeLayout(false);
            this.stpSelNominaCFDIBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookTipoDocumento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelTipoDocumentacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookTenedora.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelObtenerInfoGenericaMatrizTenedora1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblNombreArchivo;
        private DevExpress.XtraEditors.SimpleButton btnSubirPlantilla;
        private dbSAICBPOCatalogosDataSet dbSAICBPOCatalogosDataSet1;
        private dbSAICBPOCatalogosDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.BindingNavigator stpSelNominaCFDIBindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelTipoDocumentacionTableAdapter stpSelTipoDocumentacionTableAdapter1;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookTipoDocumento;
        private System.Windows.Forms.BindingSource stpSelTipoDocumentacionBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookTenedora;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDocumento;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTenedora;
        private System.Windows.Forms.BindingSource stpSelObtenerInfoGenericaMatrizTenedora1BindingSource;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelObtenerInfoGenericaMatrizTenedora_1TableAdapter stpSelObtenerInfoGenericaMatrizTenedora_1TableAdapter1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}