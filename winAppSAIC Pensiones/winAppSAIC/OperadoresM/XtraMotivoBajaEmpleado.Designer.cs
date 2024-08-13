namespace winAppSAIC.OperadoresM
{
    partial class XtraMotivoBajaEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraMotivoBajaEmpleado));
            this.btnDescargar = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtNombreEmpleado = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dteditFechabaja = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lookupMotivosBaja = new DevExpress.XtraEditors.LookUpEdit();
            this.stpSelObtenerConceptosBajaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPOCatalogosDataSet1 = new winAppSAIC.dbSAICBPOCatalogosDataSet();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtEditIdEmpleado = new DevExpress.XtraEditors.TextEdit();
            this.btnAceptar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.stpSelObtenerConceptosBajaTableAdapter1 = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelObtenerConceptosBajaTableAdapter();
            this.dbSAICBPOValidacionDataSet1 = new winAppSAIC.dbSAICBPOValidacionDataSet();
            this.stpSelEstatusNominaContabilizadaTableAdapter1 = new winAppSAIC.dbSAICBPOValidacionDataSetTableAdapters.stpSelEstatusNominaContabilizadaTableAdapter();
            this.queriesTableAdapter1 = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.QueriesTableAdapter();
            this.stpSelDiasFestivosTableAdapter1 = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelDiasFestivosTableAdapter();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.mmObservacionesBaja = new DevExpress.XtraEditors.MemoEdit();
            this.stpSelParametroTableAdapter1 = new winAppSAIC.dbSAICBPOValidacionDataSetTableAdapters.stpSelParametroTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.btnDescargar)).BeginInit();
            this.btnDescargar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreEmpleado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteditFechabaja.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteditFechabaja.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupMotivosBaja.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelObtenerConceptosBajaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditIdEmpleado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOValidacionDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmObservacionesBaja.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDescargar
            // 
            this.btnDescargar.AddNewItem = null;
            this.btnDescargar.CountItem = null;
            this.btnDescargar.CountItemFormat = "de {0}";
            this.btnDescargar.DeleteItem = null;
            this.btnDescargar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnSalir,
            this.toolStripSeparator1});
            this.btnDescargar.Location = new System.Drawing.Point(0, 0);
            this.btnDescargar.MoveFirstItem = null;
            this.btnDescargar.MoveLastItem = null;
            this.btnDescargar.MoveNextItem = null;
            this.btnDescargar.MovePreviousItem = null;
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.PositionItem = null;
            this.btnDescargar.Size = new System.Drawing.Size(538, 25);
            this.btnDescargar.TabIndex = 21;
            this.btnDescargar.Text = "bindingNavigator1";
            // 
            // toolBtnSalir
            // 
            this.toolBtnSalir.Image = global::winAppSAIC.Properties.Resources.Salir24x24;
            this.toolBtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnSalir.Name = "toolBtnSalir";
            this.toolBtnSalir.Size = new System.Drawing.Size(49, 22);
            this.toolBtnSalir.Text = "Salir";
            this.toolBtnSalir.Click += new System.EventHandler(this.toolBtnSalir_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(191, 37);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 13);
            this.labelControl2.TabIndex = 24;
            this.labelControl2.Text = "Nombre:";
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Enabled = false;
            this.txtNombreEmpleado.Location = new System.Drawing.Point(238, 34);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Properties.Appearance.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtNombreEmpleado.Properties.Appearance.Options.UseBackColor = true;
            this.txtNombreEmpleado.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreEmpleado.Properties.MaxLength = 100;
            this.txtNombreEmpleado.Size = new System.Drawing.Size(291, 20);
            this.txtNombreEmpleado.TabIndex = 27;
            this.txtNombreEmpleado.Tag = "Nombre del Empleado";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(12, 37);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(67, 13);
            this.labelControl9.TabIndex = 22;
            this.labelControl9.Text = "Id. Empleado:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.mmObservacionesBaja);
            this.groupControl1.Controls.Add(this.dteditFechabaja);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.lookupMotivosBaja);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 65);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(517, 125);
            this.groupControl1.TabIndex = 30;
            this.groupControl1.Text = "Baja";
            // 
            // dteditFechabaja
            // 
            this.dteditFechabaja.EditValue = null;
            this.dteditFechabaja.Location = new System.Drawing.Point(403, 31);
            this.dteditFechabaja.Name = "dteditFechabaja";
            this.dteditFechabaja.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.dteditFechabaja.Properties.Appearance.Options.UseBackColor = true;
            this.dteditFechabaja.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteditFechabaja.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteditFechabaja.Size = new System.Drawing.Size(104, 20);
            this.dteditFechabaja.TabIndex = 35;
            this.dteditFechabaja.Tag = "Fecha de Ingreso";
            this.dteditFechabaja.EditValueChanged += new System.EventHandler(this.dteditFechabaja_EditValueChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(329, 35);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(72, 13);
            this.labelControl3.TabIndex = 34;
            this.labelControl3.Text = "Fecha de baja:";
            // 
            // lookupMotivosBaja
            // 
            this.lookupMotivosBaja.Location = new System.Drawing.Point(112, 32);
            this.lookupMotivosBaja.Name = "lookupMotivosBaja";
            this.lookupMotivosBaja.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.lookupMotivosBaja.Properties.Appearance.Options.UseBackColor = true;
            this.lookupMotivosBaja.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookupMotivosBaja.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Concepto")});
            this.lookupMotivosBaja.Properties.DataSource = this.stpSelObtenerConceptosBajaBindingSource;
            this.lookupMotivosBaja.Properties.DisplayMember = "Descripcion";
            this.lookupMotivosBaja.Properties.NullText = "";
            this.lookupMotivosBaja.Properties.ValueMember = "idConcepto";
            this.lookupMotivosBaja.Size = new System.Drawing.Size(204, 20);
            this.lookupMotivosBaja.TabIndex = 33;
            this.lookupMotivosBaja.Tag = "Razón Social Cliente";
            // 
            // stpSelObtenerConceptosBajaBindingSource
            // 
            this.stpSelObtenerConceptosBajaBindingSource.DataMember = "stpSelObtenerConceptosBaja";
            this.stpSelObtenerConceptosBajaBindingSource.DataSource = this.dbSAICBPOCatalogosDataSet1;
            // 
            // dbSAICBPOCatalogosDataSet1
            // 
            this.dbSAICBPOCatalogosDataSet1.DataSetName = "dbSAICBPOCatalogosDataSet";
            this.dbSAICBPOCatalogosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(24, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(86, 13);
            this.labelControl1.TabIndex = 32;
            this.labelControl1.Text = "Motivo de la baja:";
            // 
            // txtEditIdEmpleado
            // 
            this.txtEditIdEmpleado.Enabled = false;
            this.txtEditIdEmpleado.Location = new System.Drawing.Point(84, 34);
            this.txtEditIdEmpleado.Name = "txtEditIdEmpleado";
            this.txtEditIdEmpleado.Properties.Appearance.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtEditIdEmpleado.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtEditIdEmpleado.Properties.Appearance.Options.UseBackColor = true;
            this.txtEditIdEmpleado.Properties.Appearance.Options.UseFont = true;
            this.txtEditIdEmpleado.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEditIdEmpleado.Properties.MaxLength = 100;
            this.txtEditIdEmpleado.Size = new System.Drawing.Size(98, 20);
            this.txtEditIdEmpleado.TabIndex = 31;
            this.txtEditIdEmpleado.Tag = "Nombre del Empleado";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Enabled = false;
            this.btnAceptar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.ImageOptions.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(398, 205);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(127, 23);
            this.btnAceptar.TabIndex = 32;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.ImageOptions.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(265, 205);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(127, 23);
            this.btnCancelar.TabIndex = 33;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // stpSelObtenerConceptosBajaTableAdapter1
            // 
            this.stpSelObtenerConceptosBajaTableAdapter1.ClearBeforeFill = true;
            // 
            // dbSAICBPOValidacionDataSet1
            // 
            this.dbSAICBPOValidacionDataSet1.DataSetName = "dbSAICBPOValidacionDataSet";
            this.dbSAICBPOValidacionDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stpSelDiasFestivosTableAdapter1
            // 
            this.stpSelDiasFestivosTableAdapter1.ClearBeforeFill = true;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(10, 58);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(99, 13);
            this.labelControl4.TabIndex = 42;
            this.labelControl4.Text = "Observaciones Baja:";
            // 
            // mmObservacionesBaja
            // 
            this.mmObservacionesBaja.Location = new System.Drawing.Point(112, 56);
            this.mmObservacionesBaja.Name = "mmObservacionesBaja";
            this.mmObservacionesBaja.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.mmObservacionesBaja.Properties.MaxLength = 1000;
            this.mmObservacionesBaja.Size = new System.Drawing.Size(395, 59);
            this.mmObservacionesBaja.TabIndex = 41;
            // 
            // stpSelParametroTableAdapter1
            // 
            this.stpSelParametroTableAdapter1.ClearBeforeFill = true;
            // 
            // XtraMotivoBajaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 237);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtEditIdEmpleado);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtNombreEmpleado);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.btnDescargar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "XtraMotivoBajaEmpleado";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitar Baja";
            this.Load += new System.EventHandler(this.XtraMotivoBajaEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnDescargar)).EndInit();
            this.btnDescargar.ResumeLayout(false);
            this.btnDescargar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreEmpleado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteditFechabaja.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteditFechabaja.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupMotivosBaja.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelObtenerConceptosBajaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditIdEmpleado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOValidacionDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmObservacionesBaja.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator btnDescargar;
        private System.Windows.Forms.ToolStripButton toolBtnSalir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtNombreEmpleado;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtEditIdEmpleado;
        private DevExpress.XtraEditors.LookUpEdit lookupMotivosBaja;
        private DevExpress.XtraEditors.SimpleButton btnAceptar;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private dbSAICBPOCatalogosDataSet dbSAICBPOCatalogosDataSet1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private System.Windows.Forms.BindingSource stpSelObtenerConceptosBajaBindingSource;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelObtenerConceptosBajaTableAdapter stpSelObtenerConceptosBajaTableAdapter1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit dteditFechabaja;
        private dbSAICBPOValidacionDataSet dbSAICBPOValidacionDataSet1;
        private dbSAICBPOValidacionDataSetTableAdapters.stpSelEstatusNominaContabilizadaTableAdapter stpSelEstatusNominaContabilizadaTableAdapter1;
        private dbSAICBPOCatalogosDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelDiasFestivosTableAdapter stpSelDiasFestivosTableAdapter1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.MemoEdit mmObservacionesBaja;
        private dbSAICBPOValidacionDataSetTableAdapters.stpSelParametroTableAdapter stpSelParametroTableAdapter1;
        //private dbSAICBPOCatalogosDataSetTableAdapters.stpSelDiasFestivosTableAdapter stpSelDiasFestivosTableAdapter1;
    }
}