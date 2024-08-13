namespace winAppSAIC.Contablidad
{
    partial class frmxCierreNominaMasivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmxCierreNominaMasivo));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDescargarFormato = new System.Windows.Forms.ToolStripButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.linkAyuda = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.btnActualizar = new DevExpress.XtraEditors.SimpleButton();
            this.lblImporteTotalPoliza = new DevExpress.XtraEditors.LabelControl();
            this.lblTotalRegistros = new DevExpress.XtraEditors.LabelControl();
            this.btnCerrarNominas = new DevExpress.XtraEditors.SimpleButton();
            this.lblNombreArchivo = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblLotesValidos = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.lblImportesInvalidos = new DevExpress.XtraEditors.LabelControl();
            this.lblImportesValidos = new DevExpress.XtraEditors.LabelControl();
            this.lblLotesValid = new DevExpress.XtraEditors.LabelControl();
            this.lblLotesInvalidos = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDescargarLotesInvalidos = new DevExpress.XtraEditors.SimpleButton();
            this.lblLotesSeleccionados = new DevExpress.XtraEditors.LabelControl();
            this.btnDesSelectAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnSelectAll = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GridControlContabilizarLotes = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.stpSelLotesContabilizadosTableAdapter1 = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelLotesContabilizadosTableAdapter();
            this.stpSelLotesContabilizadosSASCTableAdapter1 = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelLotesContabilizadosSASCTableAdapter();
            this.stpSelLotesContabilizadosCierreTableAdapter1 = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelLotesContabilizadosCierreTableAdapter();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::winAppSAIC.frmxCargandoInformacion), true, true);
            this.dbSAICBPOCatalogosDataSet1 = new winAppSAIC.dbSAICBPOCatalogosDataSet();
            this.stpSelTipoPolizaTableAdapter1 = new winAppSAIC.dbSAICBPODataSetTableAdapters.stpSelTipoPolizaTableAdapter();
            this.dbSAICBPODataSet1 = new winAppSAIC.dbSAICBPODataSet();
            this.queriesTableAdapter1 = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.QueriesTableAdapter();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlContabilizarLotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPODataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSalir,
            this.toolStripSeparator1,
            this.btnDescargarFormato});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(865, 25);
            this.toolStrip.TabIndex = 2;
            this.toolStrip.Text = "toolStrip1";
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(49, 22);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnDescargarFormato
            // 
            this.btnDescargarFormato.Image = ((System.Drawing.Image)(resources.GetObject("btnDescargarFormato.Image")));
            this.btnDescargarFormato.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnDescargarFormato.Name = "btnDescargarFormato";
            this.btnDescargarFormato.Size = new System.Drawing.Size(127, 22);
            this.btnDescargarFormato.Text = "Descargar Formato";
            this.btnDescargarFormato.Click += new System.EventHandler(this.btnDescargarFormato_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.linkAyuda);
            this.groupControl1.Controls.Add(this.btnActualizar);
            this.groupControl1.Controls.Add(this.lblImporteTotalPoliza);
            this.groupControl1.Controls.Add(this.lblTotalRegistros);
            this.groupControl1.Controls.Add(this.btnCerrarNominas);
            this.groupControl1.Controls.Add(this.lblNombreArchivo);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.lblLotesValidos);
            this.groupControl1.Location = new System.Drawing.Point(12, 38);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(543, 89);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "Archivo";
            // 
            // linkAyuda
            // 
            this.linkAyuda.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.linkAyuda.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.linkAyuda.Appearance.Options.UseFont = true;
            this.linkAyuda.Appearance.Options.UseForeColor = true;
            this.linkAyuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkAyuda.Location = new System.Drawing.Point(487, 2);
            this.linkAyuda.Name = "linkAyuda";
            this.linkAyuda.Size = new System.Drawing.Size(7, 16);
            this.linkAyuda.TabIndex = 7;
            this.linkAyuda.Text = "?";
            this.linkAyuda.Visible = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(359, 32);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(25, 22);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Visible = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lblImporteTotalPoliza
            // 
            this.lblImporteTotalPoliza.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblImporteTotalPoliza.Appearance.Options.UseFont = true;
            this.lblImporteTotalPoliza.Location = new System.Drawing.Point(10, 69);
            this.lblImporteTotalPoliza.Name = "lblImporteTotalPoliza";
            this.lblImporteTotalPoliza.Size = new System.Drawing.Size(157, 13);
            this.lblImporteTotalPoliza.TabIndex = 6;
            this.lblImporteTotalPoliza.Text = "Importe Poliza Documento: ";
            // 
            // lblTotalRegistros
            // 
            this.lblTotalRegistros.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTotalRegistros.Appearance.Options.UseFont = true;
            this.lblTotalRegistros.Location = new System.Drawing.Point(10, 52);
            this.lblTotalRegistros.Name = "lblTotalRegistros";
            this.lblTotalRegistros.Size = new System.Drawing.Size(171, 13);
            this.lblTotalRegistros.TabIndex = 7;
            this.lblTotalRegistros.Text = "Total de Lotes en Documento: ";
            // 
            // btnCerrarNominas
            // 
            this.btnCerrarNominas.Enabled = false;
            this.btnCerrarNominas.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarNominas.ImageOptions.Image")));
            this.btnCerrarNominas.Location = new System.Drawing.Point(415, 59);
            this.btnCerrarNominas.Name = "btnCerrarNominas";
            this.btnCerrarNominas.Size = new System.Drawing.Size(120, 23);
            this.btnCerrarNominas.TabIndex = 5;
            this.btnCerrarNominas.Text = "Cerrar Nominas";
            this.btnCerrarNominas.Click += new System.EventHandler(this.btnCerrarNominas_Click);
            // 
            // lblNombreArchivo
            // 
            this.lblNombreArchivo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblNombreArchivo.Location = new System.Drawing.Point(62, 33);
            this.lblNombreArchivo.Name = "lblNombreArchivo";
            this.lblNombreArchivo.Size = new System.Drawing.Size(285, 18);
            this.lblNombreArchivo.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(10, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Archivo:";
            // 
            // lblLotesValidos
            // 
            this.lblLotesValidos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("lblLotesValidos.ImageOptions.Image")));
            this.lblLotesValidos.Location = new System.Drawing.Point(415, 31);
            this.lblLotesValidos.Name = "lblLotesValidos";
            this.lblLotesValidos.Size = new System.Drawing.Size(120, 23);
            this.lblLotesValidos.TabIndex = 0;
            this.lblLotesValidos.Text = "Agregar Plantilla";
            this.lblLotesValidos.Click += new System.EventHandler(this.lblLotesValidos_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.lblImportesInvalidos);
            this.groupControl2.Controls.Add(this.lblImportesValidos);
            this.groupControl2.Controls.Add(this.lblLotesValid);
            this.groupControl2.Controls.Add(this.lblLotesInvalidos);
            this.groupControl2.Location = new System.Drawing.Point(563, 40);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(295, 89);
            this.groupControl2.TabIndex = 11;
            this.groupControl2.Text = "Detalle";
            // 
            // lblImportesInvalidos
            // 
            this.lblImportesInvalidos.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblImportesInvalidos.Appearance.Options.UseFont = true;
            this.lblImportesInvalidos.Location = new System.Drawing.Point(7, 74);
            this.lblImportesInvalidos.Name = "lblImportesInvalidos";
            this.lblImportesInvalidos.Size = new System.Drawing.Size(139, 13);
            this.lblImportesInvalidos.TabIndex = 6;
            this.lblImportesInvalidos.Text = "Importe Lotes Invalidos:";
            // 
            // lblImportesValidos
            // 
            this.lblImportesValidos.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblImportesValidos.Appearance.Options.UseFont = true;
            this.lblImportesValidos.Location = new System.Drawing.Point(18, 56);
            this.lblImportesValidos.Name = "lblImportesValidos";
            this.lblImportesValidos.Size = new System.Drawing.Size(127, 13);
            this.lblImportesValidos.TabIndex = 5;
            this.lblImportesValidos.Text = "Importe Lotes Validos:";
            // 
            // lblLotesValid
            // 
            this.lblLotesValid.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblLotesValid.Appearance.Options.UseFont = true;
            this.lblLotesValid.Location = new System.Drawing.Point(67, 21);
            this.lblLotesValid.Name = "lblLotesValid";
            this.lblLotesValid.Size = new System.Drawing.Size(77, 13);
            this.lblLotesValid.TabIndex = 3;
            this.lblLotesValid.Text = "Lotes Validos:";
            // 
            // lblLotesInvalidos
            // 
            this.lblLotesInvalidos.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblLotesInvalidos.Appearance.Options.UseFont = true;
            this.lblLotesInvalidos.Location = new System.Drawing.Point(55, 39);
            this.lblLotesInvalidos.Name = "lblLotesInvalidos";
            this.lblLotesInvalidos.Size = new System.Drawing.Size(89, 13);
            this.lblLotesInvalidos.TabIndex = 4;
            this.lblLotesInvalidos.Text = "Lotes Invalidos:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(153)))), ((int)(((byte)(205)))));
            this.panel2.Controls.Add(this.btnDescargarLotesInvalidos);
            this.panel2.Controls.Add(this.lblLotesSeleccionados);
            this.panel2.Controls.Add(this.btnDesSelectAll);
            this.panel2.Controls.Add(this.btnSelectAll);
            this.panel2.Location = new System.Drawing.Point(0, 132);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(865, 41);
            this.panel2.TabIndex = 12;
            // 
            // btnDescargarLotesInvalidos
            // 
            this.btnDescargarLotesInvalidos.Enabled = false;
            this.btnDescargarLotesInvalidos.Location = new System.Drawing.Point(246, 10);
            this.btnDescargarLotesInvalidos.Name = "btnDescargarLotesInvalidos";
            this.btnDescargarLotesInvalidos.Size = new System.Drawing.Size(138, 23);
            this.btnDescargarLotesInvalidos.TabIndex = 8;
            this.btnDescargarLotesInvalidos.Text = "Descargar Lotes Invalidos";
            this.btnDescargarLotesInvalidos.Click += new System.EventHandler(this.btnDescargarLotesInvalidos_Click);
            // 
            // lblLotesSeleccionados
            // 
            this.lblLotesSeleccionados.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblLotesSeleccionados.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblLotesSeleccionados.Appearance.Options.UseFont = true;
            this.lblLotesSeleccionados.Appearance.Options.UseForeColor = true;
            this.lblLotesSeleccionados.Location = new System.Drawing.Point(402, 15);
            this.lblLotesSeleccionados.Name = "lblLotesSeleccionados";
            this.lblLotesSeleccionados.Size = new System.Drawing.Size(117, 13);
            this.lblLotesSeleccionados.TabIndex = 6;
            this.lblLotesSeleccionados.Text = "Lotes Seleccionados:";
            // 
            // btnDesSelectAll
            // 
            this.btnDesSelectAll.Location = new System.Drawing.Point(130, 10);
            this.btnDesSelectAll.Name = "btnDesSelectAll";
            this.btnDesSelectAll.Size = new System.Drawing.Size(110, 23);
            this.btnDesSelectAll.TabIndex = 1;
            this.btnDesSelectAll.Text = "Deseleccionar Todo";
            this.btnDesSelectAll.Click += new System.EventHandler(this.btnDesSelectAll_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(14, 10);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(110, 23);
            this.btnSelectAll.TabIndex = 0;
            this.btnSelectAll.Text = "Seleccionar Todo";
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.GridControlContabilizarLotes);
            this.panel1.Location = new System.Drawing.Point(4, 179);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(856, 288);
            this.panel1.TabIndex = 13;
            // 
            // GridControlContabilizarLotes
            // 
            this.GridControlContabilizarLotes.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.GridControlContabilizarLotes.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.GridControlContabilizarLotes.Location = new System.Drawing.Point(0, 0);
            this.GridControlContabilizarLotes.MainView = this.gridView1;
            this.GridControlContabilizarLotes.Name = "GridControlContabilizarLotes";
            this.GridControlContabilizarLotes.Size = new System.Drawing.Size(856, 288);
            this.GridControlContabilizarLotes.TabIndex = 7;
            this.GridControlContabilizarLotes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(395, 363, 208, 170);
            this.gridView1.GridControl = this.GridControlContabilizarLotes;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridView1_SelectionChanged);
            // 
            // stpSelLotesContabilizadosTableAdapter1
            // 
            this.stpSelLotesContabilizadosTableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelLotesContabilizadosSASCTableAdapter1
            // 
            this.stpSelLotesContabilizadosSASCTableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelLotesContabilizadosCierreTableAdapter1
            // 
            this.stpSelLotesContabilizadosCierreTableAdapter1.ClearBeforeFill = true;
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // dbSAICBPOCatalogosDataSet1
            // 
            this.dbSAICBPOCatalogosDataSet1.DataSetName = "dbSAICBPOCatalogosDataSet";
            this.dbSAICBPOCatalogosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stpSelTipoPolizaTableAdapter1
            // 
            this.stpSelTipoPolizaTableAdapter1.ClearBeforeFill = true;
            // 
            // dbSAICBPODataSet1
            // 
            this.dbSAICBPODataSet1.DataSetName = "dbSAICBPODataSet";
            this.dbSAICBPODataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmxCierreNominaMasivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 473);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.toolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(881, 512);
            this.MinimumSize = new System.Drawing.Size(881, 512);
            this.Name = "frmxCierreNominaMasivo";
            this.Text = "Cierre Nomina Masivo";
            this.Load += new System.EventHandler(this.frmxCierreNominaMasivo_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridControlContabilizarLotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPODataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnDescargarFormato;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.HyperlinkLabelControl linkAyuda;
        private DevExpress.XtraEditors.SimpleButton btnActualizar;
        private DevExpress.XtraEditors.LabelControl lblImporteTotalPoliza;
        private DevExpress.XtraEditors.LabelControl lblTotalRegistros;
        private DevExpress.XtraEditors.SimpleButton btnCerrarNominas;
        private DevExpress.XtraEditors.LabelControl lblNombreArchivo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton lblLotesValidos;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl lblImportesInvalidos;
        private DevExpress.XtraEditors.LabelControl lblImportesValidos;
        private DevExpress.XtraEditors.LabelControl lblLotesValid;
        private DevExpress.XtraEditors.LabelControl lblLotesInvalidos;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btnDescargarLotesInvalidos;
        private DevExpress.XtraEditors.LabelControl lblLotesSeleccionados;
        private DevExpress.XtraEditors.SimpleButton btnDesSelectAll;
        private DevExpress.XtraEditors.SimpleButton btnSelectAll;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl GridControlContabilizarLotes;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelLotesContabilizadosTableAdapter stpSelLotesContabilizadosTableAdapter1;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelLotesContabilizadosSASCTableAdapter stpSelLotesContabilizadosSASCTableAdapter1;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelLotesContabilizadosCierreTableAdapter stpSelLotesContabilizadosCierreTableAdapter1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private dbSAICBPOCatalogosDataSet dbSAICBPOCatalogosDataSet1;
        private dbSAICBPODataSetTableAdapters.stpSelTipoPolizaTableAdapter stpSelTipoPolizaTableAdapter1;
        private dbSAICBPODataSet dbSAICBPODataSet1;
        private dbSAICBPOCatalogosDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
    }
}