namespace winAppSAIC.OperadoresM
{
    partial class frmxMonitoreoSolicitudesAreas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmxMonitoreoSolicitudesAreas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkCanceladas = new DevExpress.XtraEditors.CheckEdit();
            this.rdTesoreriaSC = new System.Windows.Forms.RadioButton();
            this.rdTesoreriaSA = new System.Windows.Forms.RadioButton();
            this.checkRechazadas = new DevExpress.XtraEditors.CheckEdit();
            this.checkAtendidas = new DevExpress.XtraEditors.CheckEdit();
            this.lblNumSoliciutd = new DevExpress.XtraEditors.LabelControl();
            this.checkProceso = new DevExpress.XtraEditors.CheckEdit();
            this.checkSolicitadas = new DevExpress.XtraEditors.CheckEdit();
            this.stpSelNominaCFDIBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnReporteSolTarjetas = new System.Windows.Forms.ToolStripButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.dbSAICBPOCatalogosDataSet = new winAppSAIC.dbSAICBPOCatalogosDataSet();
            this.dbSAICBPOCatalogosDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stpSelObtenerSolicitudesAltaOperacionesTableAdapter1 = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelObtenerSolicitudesAltaOperacionesTableAdapter();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.GridControlSolicitudes_2 = new DevExpress.XtraGrid.GridControl();
            this.gridVSolicitudes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.queriesTableAdapter1 = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.QueriesTableAdapter();
            this.stpSelSolicitudAltaEmpleadosTableAdapter1 = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelSolicitudAltaEmpleadosTableAdapter();
            this.stpSelObtenerSolicitudesAltaTesoreriaTableAdapter1 = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelObtenerSolicitudesAltaTesoreriaTableAdapter();
            this.stpSelObtenerSolicitudesAltaIMSSTableAdapter1 = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelObtenerSolicitudesAltaIMSSTableAdapter();
            this.stpSelInfoEmpleadosSolTarjetasTableAdapter1 = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelInfoEmpleadosSolTarjetasTableAdapter();
            this.stpSelParametroTableAdapter1 = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelParametroTableAdapter();
            this.stpSelObtenerSolicitudesAltaJuridicoTableAdapter1 = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelObtenerSolicitudesAltaJuridicoTableAdapter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splashScreenManager3 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::winAppSAIC.SplashDeCarga), true, true);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkCanceladas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkRechazadas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkAtendidas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkProceso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkSolicitadas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelNominaCFDIBindingNavigator)).BeginInit();
            this.stpSelNominaCFDIBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlSolicitudes_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVSolicitudes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(153)))), ((int)(((byte)(205)))));
            this.panel1.Controls.Add(this.checkCanceladas);
            this.panel1.Controls.Add(this.rdTesoreriaSC);
            this.panel1.Controls.Add(this.rdTesoreriaSA);
            this.panel1.Controls.Add(this.checkRechazadas);
            this.panel1.Controls.Add(this.checkAtendidas);
            this.panel1.Controls.Add(this.lblNumSoliciutd);
            this.panel1.Controls.Add(this.checkProceso);
            this.panel1.Controls.Add(this.checkSolicitadas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 39);
            this.panel1.TabIndex = 17;
            // 
            // checkCanceladas
            // 
            this.checkCanceladas.Location = new System.Drawing.Point(336, 12);
            this.checkCanceladas.Name = "checkCanceladas";
            this.checkCanceladas.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.checkCanceladas.Properties.Appearance.Options.UseForeColor = true;
            this.checkCanceladas.Properties.Caption = "Canceladas";
            this.checkCanceladas.Size = new System.Drawing.Size(86, 19);
            this.checkCanceladas.TabIndex = 29;
            this.checkCanceladas.CheckedChanged += new System.EventHandler(this.checkCanceladas_CheckedChanged);
            // 
            // rdTesoreriaSC
            // 
            this.rdTesoreriaSC.AutoSize = true;
            this.rdTesoreriaSC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(153)))), ((int)(((byte)(205)))));
            this.rdTesoreriaSC.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.rdTesoreriaSC.ForeColor = System.Drawing.Color.White;
            this.rdTesoreriaSC.Location = new System.Drawing.Point(548, 11);
            this.rdTesoreriaSC.Name = "rdTesoreriaSC";
            this.rdTesoreriaSC.Size = new System.Drawing.Size(84, 17);
            this.rdTesoreriaSC.TabIndex = 27;
            this.rdTesoreriaSC.Text = "Excedente";
            this.rdTesoreriaSC.UseVisualStyleBackColor = false;
            this.rdTesoreriaSC.Visible = false;
            this.rdTesoreriaSC.Click += new System.EventHandler(this.rdTesoreriaSC_Click_1);
            // 
            // rdTesoreriaSA
            // 
            this.rdTesoreriaSA.AutoSize = true;
            this.rdTesoreriaSA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(153)))), ((int)(((byte)(205)))));
            this.rdTesoreriaSA.Checked = true;
            this.rdTesoreriaSA.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.rdTesoreriaSA.ForeColor = System.Drawing.Color.White;
            this.rdTesoreriaSA.Location = new System.Drawing.Point(476, 11);
            this.rdTesoreriaSA.Name = "rdTesoreriaSA";
            this.rdTesoreriaSA.Size = new System.Drawing.Size(69, 17);
            this.rdTesoreriaSA.TabIndex = 26;
            this.rdTesoreriaSA.TabStop = true;
            this.rdTesoreriaSA.Text = "Sueldos";
            this.rdTesoreriaSA.UseVisualStyleBackColor = false;
            this.rdTesoreriaSA.Visible = false;
            this.rdTesoreriaSA.Click += new System.EventHandler(this.rdTesoreriaSA_Click_2);
            // 
            // checkRechazadas
            // 
            this.checkRechazadas.Location = new System.Drawing.Point(244, 12);
            this.checkRechazadas.Name = "checkRechazadas";
            this.checkRechazadas.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.checkRechazadas.Properties.Appearance.Options.UseForeColor = true;
            this.checkRechazadas.Properties.Caption = "Rechazadas";
            this.checkRechazadas.Size = new System.Drawing.Size(86, 19);
            this.checkRechazadas.TabIndex = 11;
            this.checkRechazadas.CheckedChanged += new System.EventHandler(this.checkRechazadas_CheckedChanged);
            // 
            // checkAtendidas
            // 
            this.checkAtendidas.Location = new System.Drawing.Point(167, 12);
            this.checkAtendidas.Name = "checkAtendidas";
            this.checkAtendidas.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.checkAtendidas.Properties.Appearance.Options.UseForeColor = true;
            this.checkAtendidas.Properties.Caption = "Atendidas";
            this.checkAtendidas.Size = new System.Drawing.Size(75, 19);
            this.checkAtendidas.TabIndex = 10;
            this.checkAtendidas.CheckedChanged += new System.EventHandler(this.checkAtendidas_CheckedChanged);
            // 
            // lblNumSoliciutd
            // 
            this.lblNumSoliciutd.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblNumSoliciutd.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblNumSoliciutd.Appearance.Options.UseFont = true;
            this.lblNumSoliciutd.Appearance.Options.UseForeColor = true;
            this.lblNumSoliciutd.Location = new System.Drawing.Point(640, 15);
            this.lblNumSoliciutd.Name = "lblNumSoliciutd";
            this.lblNumSoliciutd.Size = new System.Drawing.Size(128, 13);
            this.lblNumSoliciutd.TabIndex = 9;
            this.lblNumSoliciutd.Text = "Numero de Solicitudes:";
            // 
            // checkProceso
            // 
            this.checkProceso.EditValue = true;
            this.checkProceso.Location = new System.Drawing.Point(7, 12);
            this.checkProceso.Name = "checkProceso";
            this.checkProceso.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.checkProceso.Properties.Appearance.Options.UseForeColor = true;
            this.checkProceso.Properties.Caption = "En Proceso";
            this.checkProceso.Size = new System.Drawing.Size(75, 19);
            this.checkProceso.TabIndex = 8;
            this.checkProceso.CheckedChanged += new System.EventHandler(this.checkProceso_CheckedChanged);
            // 
            // checkSolicitadas
            // 
            this.checkSolicitadas.EditValue = true;
            this.checkSolicitadas.Location = new System.Drawing.Point(88, 12);
            this.checkSolicitadas.Name = "checkSolicitadas";
            this.checkSolicitadas.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.checkSolicitadas.Properties.Appearance.Options.UseForeColor = true;
            this.checkSolicitadas.Properties.Caption = "Solicitadas";
            this.checkSolicitadas.Size = new System.Drawing.Size(75, 19);
            this.checkSolicitadas.TabIndex = 7;
            this.checkSolicitadas.CheckedChanged += new System.EventHandler(this.checkSolicitadas_CheckedChanged);
            // 
            // stpSelNominaCFDIBindingNavigator
            // 
            this.stpSelNominaCFDIBindingNavigator.AddNewItem = null;
            this.stpSelNominaCFDIBindingNavigator.CountItem = null;
            this.stpSelNominaCFDIBindingNavigator.DeleteItem = null;
            this.stpSelNominaCFDIBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stpSelNominaCFDIBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.toolStripSeparator2,
            this.btnReporteSolTarjetas});
            this.stpSelNominaCFDIBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.stpSelNominaCFDIBindingNavigator.MoveFirstItem = null;
            this.stpSelNominaCFDIBindingNavigator.MoveLastItem = null;
            this.stpSelNominaCFDIBindingNavigator.MoveNextItem = null;
            this.stpSelNominaCFDIBindingNavigator.MovePreviousItem = null;
            this.stpSelNominaCFDIBindingNavigator.Name = "stpSelNominaCFDIBindingNavigator";
            this.stpSelNominaCFDIBindingNavigator.PositionItem = null;
            this.stpSelNominaCFDIBindingNavigator.Size = new System.Drawing.Size(870, 27);
            this.stpSelNominaCFDIBindingNavigator.TabIndex = 18;
            this.stpSelNominaCFDIBindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::winAppSAIC.Properties.Resources.Salir24x24;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(53, 24);
            this.toolStripButton1.Text = "Salir";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::winAppSAIC.Properties.Resources.if_Update_984748;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(83, 24);
            this.toolStripButton2.Text = "Actualizar";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // btnReporteSolTarjetas
            // 
            this.btnReporteSolTarjetas.Image = global::winAppSAIC.Properties.Resources.Excel;
            this.btnReporteSolTarjetas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReporteSolTarjetas.Name = "btnReporteSolTarjetas";
            this.btnReporteSolTarjetas.Size = new System.Drawing.Size(173, 24);
            this.btnReporteSolTarjetas.Text = "Archivo General de Tarjetas";
            this.btnReporteSolTarjetas.Visible = false;
            this.btnReporteSolTarjetas.Click += new System.EventHandler(this.btnReporteSolTarjetas_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(538, 3);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(187, 23);
            this.simpleButton1.TabIndex = 20;
            this.simpleButton1.Text = "Detalle Empleados";
            this.simpleButton1.Visible = false;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // dbSAICBPOCatalogosDataSet
            // 
            this.dbSAICBPOCatalogosDataSet.DataSetName = "dbSAICBPOCatalogosDataSet";
            this.dbSAICBPOCatalogosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbSAICBPOCatalogosDataSetBindingSource
            // 
            this.dbSAICBPOCatalogosDataSetBindingSource.DataSource = this.dbSAICBPOCatalogosDataSet;
            this.dbSAICBPOCatalogosDataSetBindingSource.Position = 0;
            // 
            // stpSelObtenerSolicitudesAltaOperacionesTableAdapter1
            // 
            this.stpSelObtenerSolicitudesAltaOperacionesTableAdapter1.ClearBeforeFill = true;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.GridControlSolicitudes_2);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(870, 444);
            this.groupControl2.TabIndex = 21;
            // 
            // GridControlSolicitudes_2
            // 
            this.GridControlSolicitudes_2.Cursor = System.Windows.Forms.Cursors.Default;
            this.GridControlSolicitudes_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridControlSolicitudes_2.Location = new System.Drawing.Point(2, 20);
            this.GridControlSolicitudes_2.MainView = this.gridVSolicitudes;
            this.GridControlSolicitudes_2.Name = "GridControlSolicitudes_2";
            this.GridControlSolicitudes_2.Size = new System.Drawing.Size(866, 422);
            this.GridControlSolicitudes_2.TabIndex = 2;
            this.GridControlSolicitudes_2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridVSolicitudes});
            // 
            // gridVSolicitudes
            // 
            this.gridVSolicitudes.GridControl = this.GridControlSolicitudes_2;
            this.gridVSolicitudes.Name = "gridVSolicitudes";
            this.gridVSolicitudes.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridVSolicitudes.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridVSolicitudes.OptionsBehavior.Editable = false;
            this.gridVSolicitudes.OptionsBehavior.ReadOnly = true;
            this.gridVSolicitudes.OptionsFind.FindNullPrompt = "Ingrese dato para buscar....";
            this.gridVSolicitudes.OptionsFind.ShowClearButton = false;
            this.gridVSolicitudes.OptionsFind.ShowFindButton = false;
            this.gridVSolicitudes.OptionsView.ColumnAutoWidth = false;
            this.gridVSolicitudes.OptionsView.ShowAutoFilterRow = true;
            this.gridVSolicitudes.OptionsView.ShowGroupPanel = false;
            this.gridVSolicitudes.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridVSolicitudes_RowStyle);
            this.gridVSolicitudes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gridVSolicitudes_KeyPress);
            this.gridVSolicitudes.DoubleClick += new System.EventHandler(this.gridVSolicitudes_DoubleClick);
            // 
            // stpSelSolicitudAltaEmpleadosTableAdapter1
            // 
            this.stpSelSolicitudAltaEmpleadosTableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelObtenerSolicitudesAltaTesoreriaTableAdapter1
            // 
            this.stpSelObtenerSolicitudesAltaTesoreriaTableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelObtenerSolicitudesAltaIMSSTableAdapter1
            // 
            this.stpSelObtenerSolicitudesAltaIMSSTableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelInfoEmpleadosSolTarjetasTableAdapter1
            // 
            this.stpSelInfoEmpleadosSolTarjetasTableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelParametroTableAdapter1
            // 
            this.stpSelParametroTableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelObtenerSolicitudesAltaJuridicoTableAdapter1
            // 
            this.stpSelObtenerSolicitudesAltaJuridicoTableAdapter1.ClearBeforeFill = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupControl2);
            this.splitContainer1.Size = new System.Drawing.Size(870, 487);
            this.splitContainer1.SplitterDistance = 39;
            this.splitContainer1.TabIndex = 22;
            // 
            // splashScreenManager3
            // 
            this.splashScreenManager3.ClosingDelay = 500;
            // 
            // frmxMonitoreoSolicitudesAreas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 514);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.stpSelNominaCFDIBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(762, 454);
            this.Name = "frmxMonitoreoSolicitudesAreas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitudes";
            this.Load += new System.EventHandler(this.frmxMonitoreoSolicitudesAreas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkCanceladas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkRechazadas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkAtendidas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkProceso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkSolicitadas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelNominaCFDIBindingNavigator)).EndInit();
            this.stpSelNominaCFDIBindingNavigator.ResumeLayout(false);
            this.stpSelNominaCFDIBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridControlSolicitudes_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVSolicitudes)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.CheckEdit checkAtendidas;
        private DevExpress.XtraEditors.LabelControl lblNumSoliciutd;
        private DevExpress.XtraEditors.CheckEdit checkProceso;
        private DevExpress.XtraEditors.CheckEdit checkSolicitadas;
        private System.Windows.Forms.BindingNavigator stpSelNominaCFDIBindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private dbSAICBPOCatalogosDataSet dbSAICBPOCatalogosDataSet;
        private System.Windows.Forms.BindingSource dbSAICBPOCatalogosDataSetBindingSource;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelObtenerSolicitudesAltaOperacionesTableAdapter stpSelObtenerSolicitudesAltaOperacionesTableAdapter1;
        private DevExpress.XtraEditors.CheckEdit checkRechazadas;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl GridControlSolicitudes_2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridVSolicitudes;
        private dbSAICBPOCatalogosDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelSolicitudAltaEmpleadosTableAdapter stpSelSolicitudAltaEmpleadosTableAdapter1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelObtenerSolicitudesAltaTesoreriaTableAdapter stpSelObtenerSolicitudesAltaTesoreriaTableAdapter1;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelObtenerSolicitudesAltaIMSSTableAdapter stpSelObtenerSolicitudesAltaIMSSTableAdapter1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnReporteSolTarjetas;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelInfoEmpleadosSolTarjetasTableAdapter stpSelInfoEmpleadosSolTarjetasTableAdapter1;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelParametroTableAdapter stpSelParametroTableAdapter1;
        private System.Windows.Forms.RadioButton rdTesoreriaSC;
        private System.Windows.Forms.RadioButton rdTesoreriaSA;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelObtenerSolicitudesAltaJuridicoTableAdapter stpSelObtenerSolicitudesAltaJuridicoTableAdapter1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager2;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager3;
        private DevExpress.XtraEditors.CheckEdit checkCanceladas;
    }
}