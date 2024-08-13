namespace winAppSAIC.Seguridad
{
    partial class ContraseniaUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContraseniaUsuarios));
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCambiar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.txtUsuario = new DevExpress.XtraEditors.TextEdit();
            this.txtNuevaContraseña = new DevExpress.XtraEditors.TextEdit();
            this.txtRepetirContraseña = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lblDias = new DevExpress.XtraEditors.LabelControl();
            this.txtfechaVigencia = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtCorreo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.validacionesGeneralTableAdapter1 = new winAppSAIC.Catalogos.dbSAICBPO_CatalogosValidacionDataSetTableAdapters.ValidacionesGeneralTableAdapter();
            this.stpSelEstatusNominaContabilizadaTableAdapter1 = new winAppSAIC.dbSAICBPOValidacionDataSetTableAdapters.stpSelEstatusNominaContabilizadaTableAdapter();
            this.stpSelParametroRegExTableAdapter1 = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelParametroRegExTableAdapter();
            this.dbSAICBPOCatalogosDataSet1 = new winAppSAIC.dbSAICBPOCatalogosDataSet();
            this.queriesTableAdapter1 = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.QueriesTableAdapter();
            this.stpSelParametro_1TableAdapter1 = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelParametro_1TableAdapter();
            this.stpSelInfoVigenciaContraseniaOperadorTableAdapter1 = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelInfoVigenciaContraseniaOperadorTableAdapter();
            this.stpSelCorreosNotificacionTableAdapter1 = new winAppSAIC.CorreoElectronico.dbSAICCorreosNotificacionTableAdapters.stpSelCorreosNotificacionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNuevaContraseña.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRepetirContraseña.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtfechaVigencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCorreo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.ImageOptions.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(330, 146);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(175, 19);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCambiar
            // 
            this.btnCambiar.Enabled = false;
            this.btnCambiar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCambiar.ImageOptions.Image")));
            this.btnCambiar.Location = new System.Drawing.Point(510, 146);
            this.btnCambiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(174, 19);
            this.btnCambiar.TabIndex = 1;
            this.btnCambiar.Text = "Cambiar";
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(60, 32);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Nombre:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(8, 76);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(94, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Nueva Contraseña:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(430, 31);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(40, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Usuario:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(327, 74);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(98, 13);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Repetir Contraseña:";
            // 
            // txtNombre
            // 
            this.txtNombre.EditValue = "";
            this.txtNombre.Location = new System.Drawing.Point(105, 28);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Properties.Appearance.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtNombre.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.txtNombre.Properties.Appearance.Options.UseBackColor = true;
            this.txtNombre.Properties.Appearance.Options.UseFont = true;
            this.txtNombre.Properties.Appearance.Options.UseTextOptions = true;
            this.txtNombre.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtNombre.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtNombre.Properties.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(312, 18);
            this.txtNombre.TabIndex = 6;
            // 
            // txtUsuario
            // 
            this.txtUsuario.EditValue = "";
            this.txtUsuario.Location = new System.Drawing.Point(472, 28);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Properties.Appearance.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtUsuario.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.txtUsuario.Properties.Appearance.Options.UseBackColor = true;
            this.txtUsuario.Properties.Appearance.Options.UseFont = true;
            this.txtUsuario.Properties.Appearance.Options.UseTextOptions = true;
            this.txtUsuario.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtUsuario.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtUsuario.Properties.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(153, 18);
            this.txtUsuario.TabIndex = 7;
            // 
            // txtNuevaContraseña
            // 
            this.txtNuevaContraseña.Location = new System.Drawing.Point(104, 72);
            this.txtNuevaContraseña.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNuevaContraseña.Name = "txtNuevaContraseña";
            this.txtNuevaContraseña.Size = new System.Drawing.Size(196, 20);
            this.txtNuevaContraseña.TabIndex = 8;
            this.txtNuevaContraseña.EditValueChanged += new System.EventHandler(this.txtNuevaContraseña_EditValueChanged);
            // 
            // txtRepetirContraseña
            // 
            this.txtRepetirContraseña.Location = new System.Drawing.Point(428, 71);
            this.txtRepetirContraseña.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRepetirContraseña.Name = "txtRepetirContraseña";
            this.txtRepetirContraseña.Size = new System.Drawing.Size(196, 20);
            this.txtRepetirContraseña.TabIndex = 9;
            this.txtRepetirContraseña.EditValueChanged += new System.EventHandler(this.txtRepetirContraseña_EditValueChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lblDias);
            this.groupControl1.Controls.Add(this.txtfechaVigencia);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.txtCorreo);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtRepetirContraseña);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtNuevaContraseña);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtUsuario);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtNombre);
            this.groupControl1.Location = new System.Drawing.Point(10, 10);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(674, 132);
            this.groupControl1.TabIndex = 10;
            this.groupControl1.Text = "Usuario";
            // 
            // lblDias
            // 
            this.lblDias.Location = new System.Drawing.Point(627, 52);
            this.lblDias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(0, 13);
            this.lblDias.TabIndex = 15;
            // 
            // txtfechaVigencia
            // 
            this.txtfechaVigencia.EditValue = "";
            this.txtfechaVigencia.Location = new System.Drawing.Point(472, 51);
            this.txtfechaVigencia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtfechaVigencia.Name = "txtfechaVigencia";
            this.txtfechaVigencia.Properties.Appearance.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtfechaVigencia.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.txtfechaVigencia.Properties.Appearance.Options.UseBackColor = true;
            this.txtfechaVigencia.Properties.Appearance.Options.UseFont = true;
            this.txtfechaVigencia.Properties.Appearance.Options.UseTextOptions = true;
            this.txtfechaVigencia.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtfechaVigencia.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtfechaVigencia.Properties.ReadOnly = true;
            this.txtfechaVigencia.Size = new System.Drawing.Size(153, 18);
            this.txtfechaVigencia.TabIndex = 14;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(427, 52);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(43, 13);
            this.labelControl7.TabIndex = 13;
            this.labelControl7.Text = "Vigencia:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(65, 54);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(37, 13);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Correo:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.EditValue = "";
            this.txtCorreo.Location = new System.Drawing.Point(105, 51);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Properties.Appearance.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtCorreo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.txtCorreo.Properties.Appearance.Options.UseBackColor = true;
            this.txtCorreo.Properties.Appearance.Options.UseFont = true;
            this.txtCorreo.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCorreo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtCorreo.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtCorreo.Properties.ReadOnly = true;
            this.txtCorreo.Size = new System.Drawing.Size(312, 18);
            this.txtCorreo.TabIndex = 12;
            // 
            // labelControl5
            // 
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl5.Location = new System.Drawing.Point(105, 94);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(519, 26);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "La nueva contraseña debe contener: De 10 a 20 Caracteres, Mayusculas y Minisculas" +
    ", Por lo menos un caracter especial (!,\",#,$,%,&,/,(,),=,?).\r\n";
            // 
            // stpSelParametroRegExTableAdapter1
            // 
            this.stpSelParametroRegExTableAdapter1.ClearBeforeFill = true;
            // 
            // dbSAICBPOCatalogosDataSet1
            // 
            this.dbSAICBPOCatalogosDataSet1.DataSetName = "dbSAICBPOCatalogosDataSet";
            this.dbSAICBPOCatalogosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stpSelParametro_1TableAdapter1
            // 
            this.stpSelParametro_1TableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelInfoVigenciaContraseniaOperadorTableAdapter1
            // 
            this.stpSelInfoVigenciaContraseniaOperadorTableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelCorreosNotificacionTableAdapter1
            // 
            this.stpSelCorreosNotificacionTableAdapter1.ClearBeforeFill = true;
            // 
            // ContraseniaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 177);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.btnCancelar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ContraseniaUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar Contraseña";
            this.Load += new System.EventHandler(this.ContraseniaUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNuevaContraseña.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRepetirContraseña.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtfechaVigencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCorreo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnCambiar;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraEditors.TextEdit txtUsuario;
        private DevExpress.XtraEditors.TextEdit txtNuevaContraseña;
        private DevExpress.XtraEditors.TextEdit txtRepetirContraseña;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelParametroRegExTableAdapter stpSelParametroRegExTableAdapter1;
        private dbSAICBPOCatalogosDataSet dbSAICBPOCatalogosDataSet1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtCorreo;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private Catalogos.dbSAICBPO_CatalogosValidacionDataSetTableAdapters.ValidacionesGeneralTableAdapter validacionesGeneralTableAdapter1;
        private dbSAICBPOCatalogosDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private DevExpress.XtraEditors.TextEdit txtfechaVigencia;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelParametro_1TableAdapter stpSelParametro_1TableAdapter1;
        private dbSAICBPOValidacionDataSetTableAdapters.stpSelEstatusNominaContabilizadaTableAdapter stpSelEstatusNominaContabilizadaTableAdapter1;
        private DevExpress.XtraEditors.LabelControl lblDias;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelInfoVigenciaContraseniaOperadorTableAdapter stpSelInfoVigenciaContraseniaOperadorTableAdapter1;
        private CorreoElectronico.dbSAICCorreosNotificacionTableAdapters.stpSelCorreosNotificacionTableAdapter stpSelCorreosNotificacionTableAdapter1;
    }
}