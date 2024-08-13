namespace winAppSAIC.OperadoresM
{
    partial class XtraEmpleadoExcepcionAcumulado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraEmpleadoExcepcionAcumulado));
            this.cboIdEmpleado = new DevExpress.XtraEditors.GridLookUpEdit();
            this.stpSelEmpleadosDisponiblesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPOCatalogosDataSet1 = new winAppSAIC.dbSAICBPOCatalogosDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreEmpleadoCompleto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNSS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRFC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCURP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.toolBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.btnDescargar = new System.Windows.Forms.BindingNavigator(this.components);
            this.stpSelEmpleadosDisponiblesTableAdapter1 = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelEmpleadosDisponiblesTableAdapter();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::winAppSAIC.SplashDeCarga), true, true);
            this.dbSAICBPOCatalogosDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtLimiteAcumulado = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.txtLimiteRegistro = new DevExpress.XtraEditors.TextEdit();
            this.txtLimiteMensual = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.dbSAICBPOValidacionDataSet1 = new winAppSAIC.dbSAICBPOValidacionDataSet();
            this.stpSelParametroTableAdapter1 = new winAppSAIC.dbSAICBPOValidacionDataSetTableAdapters.stpSelParametroTableAdapter();
            this.dbSAICBPOCatalogosDataSet2 = new winAppSAIC.dbSAICBPOCatalogosDataSet();
            this.queriesTableAdapter1 = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.QueriesTableAdapter();
            this.queriesTableAdapter2 = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.QueriesTableAdapter();
            this.stpSelEmpleadoExcepcionAcumuladoTableAdapter1 = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelEmpleadoExcepcionAcumuladoTableAdapter();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.stpSelEmpleadosEnAltaoBajaTableAdapter1 = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelEmpleadosEnAltaoBajaTableAdapter();
            this.stpSelEmpleadosEnAltaoBajaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cboIdEmpleado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelEmpleadosDisponiblesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDescargar)).BeginInit();
            this.btnDescargar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLimiteAcumulado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLimiteRegistro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLimiteMensual.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOValidacionDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelEmpleadosEnAltaoBajaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cboIdEmpleado
            // 
            this.cboIdEmpleado.EditValue = "";
            this.cboIdEmpleado.Location = new System.Drawing.Point(110, 34);
            this.cboIdEmpleado.Name = "cboIdEmpleado";
            this.cboIdEmpleado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboIdEmpleado.Properties.DataSource = this.stpSelEmpleadosEnAltaoBajaBindingSource;
            this.cboIdEmpleado.Properties.DisplayMember = "NombreEmpleadoCompleto";
            this.cboIdEmpleado.Properties.ValueMember = "IdEmpleado";
            this.cboIdEmpleado.Properties.View = this.gridView1;
            this.cboIdEmpleado.Size = new System.Drawing.Size(383, 20);
            this.cboIdEmpleado.TabIndex = 4;
            this.cboIdEmpleado.EditValueChanged += new System.EventHandler(this.cboIdEmpleado_EditValueChanged_1);
            // 
            // stpSelEmpleadosDisponiblesBindingSource
            // 
            this.stpSelEmpleadosDisponiblesBindingSource.DataMember = "stpSelEmpleadosDisponibles";
            this.stpSelEmpleadosDisponiblesBindingSource.DataSource = this.dbSAICBPOCatalogosDataSet1;
            // 
            // dbSAICBPOCatalogosDataSet1
            // 
            this.dbSAICBPOCatalogosDataSet1.DataSetName = "dbSAICBPOCatalogosDataSet";
            this.dbSAICBPOCatalogosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpleado,
            this.colNombreEmpleadoCompleto,
            this.colNSS,
            this.colRFC,
            this.colCURP});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsCustomization.AllowColumnMoving = false;
            this.gridView1.OptionsCustomization.AllowGroup = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIdEmpleado
            // 
            this.colIdEmpleado.AppearanceCell.Options.UseTextOptions = true;
            this.colIdEmpleado.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIdEmpleado.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdEmpleado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIdEmpleado.Caption = "No. Empleado";
            this.colIdEmpleado.FieldName = "IdEmpleado";
            this.colIdEmpleado.Name = "colIdEmpleado";
            this.colIdEmpleado.OptionsColumn.ReadOnly = true;
            this.colIdEmpleado.Visible = true;
            this.colIdEmpleado.VisibleIndex = 0;
            // 
            // colNombreEmpleadoCompleto
            // 
            this.colNombreEmpleadoCompleto.Caption = "Nombre Completo";
            this.colNombreEmpleadoCompleto.FieldName = "NombreEmpleadoCompleto";
            this.colNombreEmpleadoCompleto.Name = "colNombreEmpleadoCompleto";
            this.colNombreEmpleadoCompleto.OptionsColumn.ReadOnly = true;
            this.colNombreEmpleadoCompleto.Visible = true;
            this.colNombreEmpleadoCompleto.VisibleIndex = 1;
            this.colNombreEmpleadoCompleto.Width = 250;
            // 
            // colNSS
            // 
            this.colNSS.FieldName = "NSS";
            this.colNSS.Name = "colNSS";
            this.colNSS.Visible = true;
            this.colNSS.VisibleIndex = 2;
            this.colNSS.Width = 100;
            // 
            // colRFC
            // 
            this.colRFC.FieldName = "RFC";
            this.colRFC.Name = "colRFC";
            this.colRFC.Visible = true;
            this.colRFC.VisibleIndex = 3;
            this.colRFC.Width = 100;
            // 
            // colCURP
            // 
            this.colCURP.FieldName = "CURP";
            this.colCURP.Name = "colCURP";
            this.colCURP.Visible = true;
            this.colCURP.VisibleIndex = 4;
            this.colCURP.Width = 150;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(23, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(81, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Buscar Empleado";
            // 
            // toolBtnSalir
            // 
            this.toolBtnSalir.Image = global::winAppSAIC.Properties.Resources.Salir24x24;
            this.toolBtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnSalir.Name = "toolBtnSalir";
            this.toolBtnSalir.Size = new System.Drawing.Size(53, 24);
            this.toolBtnSalir.Text = "Salir";
            this.toolBtnSalir.Click += new System.EventHandler(this.toolBtnSalir_Click);
            // 
            // btnDescargar
            // 
            this.btnDescargar.AddNewItem = null;
            this.btnDescargar.CountItem = null;
            this.btnDescargar.DeleteItem = null;
            this.btnDescargar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.btnDescargar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnSalir});
            this.btnDescargar.Location = new System.Drawing.Point(0, 0);
            this.btnDescargar.MoveFirstItem = null;
            this.btnDescargar.MoveLastItem = null;
            this.btnDescargar.MoveNextItem = null;
            this.btnDescargar.MovePreviousItem = null;
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.PositionItem = null;
            this.btnDescargar.Size = new System.Drawing.Size(507, 27);
            this.btnDescargar.TabIndex = 21;
            this.btnDescargar.Text = "bindingNavigator1";
            // 
            // stpSelEmpleadosDisponiblesTableAdapter1
            // 
            this.stpSelEmpleadosDisponiblesTableAdapter1.ClearBeforeFill = true;
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // dbSAICBPOCatalogosDataSet1BindingSource
            // 
            this.dbSAICBPOCatalogosDataSet1BindingSource.DataSource = this.dbSAICBPOCatalogosDataSet1;
            this.dbSAICBPOCatalogosDataSet1BindingSource.Position = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtLimiteAcumulado);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Location = new System.Drawing.Point(12, 66);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(280, 81);
            this.groupControl1.TabIndex = 22;
            // 
            // txtLimiteAcumulado
            // 
            this.txtLimiteAcumulado.EditValue = "999999999";
            this.txtLimiteAcumulado.Enabled = false;
            this.txtLimiteAcumulado.Location = new System.Drawing.Point(153, 35);
            this.txtLimiteAcumulado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLimiteAcumulado.Name = "txtLimiteAcumulado";
            this.txtLimiteAcumulado.Properties.Appearance.Options.UseTextOptions = true;
            this.txtLimiteAcumulado.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtLimiteAcumulado.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtLimiteAcumulado.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtLimiteAcumulado.Size = new System.Drawing.Size(111, 20);
            this.txtLimiteAcumulado.TabIndex = 3;
            this.txtLimiteAcumulado.EditValueChanged += new System.EventHandler(this.txtLimiteAcumulado_EditValueChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(15, 37);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(127, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Importe Limite Acumulado:";
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(16, 32);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(171, 19);
            this.simpleButton2.TabIndex = 11;
            this.simpleButton2.Text = "Limpiar Datos";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(16, 55);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(171, 19);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtLimiteRegistro
            // 
            this.txtLimiteRegistro.EditValue = "999999999";
            this.txtLimiteRegistro.Enabled = false;
            this.txtLimiteRegistro.Location = new System.Drawing.Point(673, 183);
            this.txtLimiteRegistro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLimiteRegistro.Name = "txtLimiteRegistro";
            this.txtLimiteRegistro.Properties.Appearance.Options.UseTextOptions = true;
            this.txtLimiteRegistro.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtLimiteRegistro.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtLimiteRegistro.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtLimiteRegistro.Size = new System.Drawing.Size(111, 20);
            this.txtLimiteRegistro.TabIndex = 9;
            this.txtLimiteRegistro.Visible = false;
            this.txtLimiteRegistro.EditValueChanged += new System.EventHandler(this.txtLimiteRegistro_EditValueChanged);
            // 
            // txtLimiteMensual
            // 
            this.txtLimiteMensual.EditValue = "999999999";
            this.txtLimiteMensual.Enabled = false;
            this.txtLimiteMensual.Location = new System.Drawing.Point(435, 183);
            this.txtLimiteMensual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLimiteMensual.Name = "txtLimiteMensual";
            this.txtLimiteMensual.Properties.Appearance.Options.UseTextOptions = true;
            this.txtLimiteMensual.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtLimiteMensual.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtLimiteMensual.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtLimiteMensual.Size = new System.Drawing.Size(111, 20);
            this.txtLimiteMensual.TabIndex = 8;
            this.txtLimiteMensual.Visible = false;
            this.txtLimiteMensual.EditValueChanged += new System.EventHandler(this.txtLimiteMensual_EditValueChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(582, 185);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(82, 13);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "Importe Limite R:";
            this.labelControl5.Visible = false;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(311, 185);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(114, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Importe Limite Mensual:";
            this.labelControl4.Visible = false;
            // 
            // dbSAICBPOValidacionDataSet1
            // 
            this.dbSAICBPOValidacionDataSet1.DataSetName = "dbSAICBPOValidacionDataSet";
            this.dbSAICBPOValidacionDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stpSelParametroTableAdapter1
            // 
            this.stpSelParametroTableAdapter1.ClearBeforeFill = true;
            // 
            // dbSAICBPOCatalogosDataSet2
            // 
            this.dbSAICBPOCatalogosDataSet2.DataSetName = "dbSAICBPOCatalogosDataSet";
            this.dbSAICBPOCatalogosDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stpSelEmpleadoExcepcionAcumuladoTableAdapter1
            // 
            this.stpSelEmpleadoExcepcionAcumuladoTableAdapter1.ClearBeforeFill = true;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.simpleButton2);
            this.groupControl2.Controls.Add(this.btnGuardar);
            this.groupControl2.Location = new System.Drawing.Point(297, 66);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(204, 81);
            this.groupControl2.TabIndex = 23;
            // 
            // stpSelEmpleadosEnAltaoBajaTableAdapter1
            // 
            this.stpSelEmpleadosEnAltaoBajaTableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelEmpleadosEnAltaoBajaBindingSource
            // 
            this.stpSelEmpleadosEnAltaoBajaBindingSource.DataMember = "stpSelEmpleadosEnAltaoBaja";
            this.stpSelEmpleadosEnAltaoBajaBindingSource.DataSource = this.dbSAICBPOCatalogosDataSet1;
            // 
            // XtraEmpleadoExcepcionAcumulado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 159);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.btnDescargar);
            this.Controls.Add(this.txtLimiteRegistro);
            this.Controls.Add(this.cboIdEmpleado);
            this.Controls.Add(this.txtLimiteMensual);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(609, 243);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(523, 198);
            this.Name = "XtraEmpleadoExcepcionAcumulado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleado Excepcion Acumulado";
            this.Load += new System.EventHandler(this.XtraEmpleadoExcepcionAcumulado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cboIdEmpleado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelEmpleadosDisponiblesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDescargar)).EndInit();
            this.btnDescargar.ResumeLayout(false);
            this.btnDescargar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLimiteAcumulado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLimiteRegistro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLimiteMensual.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOValidacionDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stpSelEmpleadosEnAltaoBajaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GridLookUpEdit cboIdEmpleado;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreEmpleadoCompleto;
        private DevExpress.XtraGrid.Columns.GridColumn colNSS;
        private DevExpress.XtraGrid.Columns.GridColumn colRFC;
        private DevExpress.XtraGrid.Columns.GridColumn colCURP;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ToolStripButton toolBtnSalir;
        private System.Windows.Forms.BindingNavigator btnDescargar;
        private dbSAICBPOCatalogosDataSet dbSAICBPOCatalogosDataSet1;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelEmpleadosDisponiblesTableAdapter stpSelEmpleadosDisponiblesTableAdapter1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private System.Windows.Forms.BindingSource stpSelEmpleadosDisponiblesBindingSource;
        private System.Windows.Forms.BindingSource dbSAICBPOCatalogosDataSet1BindingSource;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.TextEdit txtLimiteRegistro;
        private DevExpress.XtraEditors.TextEdit txtLimiteMensual;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtLimiteAcumulado;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private dbSAICBPOValidacionDataSet dbSAICBPOValidacionDataSet1;
        private dbSAICBPOValidacionDataSetTableAdapters.stpSelParametroTableAdapter stpSelParametroTableAdapter1;
        private dbSAICBPOCatalogosDataSet dbSAICBPOCatalogosDataSet2;
        private dbSAICBPOCatalogosDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private dbSAICBPOCatalogosDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter2;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelEmpleadoExcepcionAcumuladoTableAdapter stpSelEmpleadoExcepcionAcumuladoTableAdapter1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelEmpleadosEnAltaoBajaTableAdapter stpSelEmpleadosEnAltaoBajaTableAdapter1;
        private System.Windows.Forms.BindingSource stpSelEmpleadosEnAltaoBajaBindingSource;
    }
}