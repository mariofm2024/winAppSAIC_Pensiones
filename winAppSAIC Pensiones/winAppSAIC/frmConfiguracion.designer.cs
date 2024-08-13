namespace winAppSAIC
{
    partial class frmConfiguracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfiguracion));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Conexion = new System.Windows.Forms.TabPage();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.rdRemoto = new System.Windows.Forms.RadioButton();
            this.rdLocal = new System.Windows.Forms.RadioButton();
            this.tpServidorBD = new System.Windows.Forms.TabPage();
            this.btnGuardarInfoAppConfig = new DevExpress.XtraEditors.SimpleButton();
            this.btnProbarConexionBD = new DevExpress.XtraEditors.SimpleButton();
            this.txtNombreBaseDatos = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContrasena = new DevExpress.XtraEditors.TextEdit();
            this.txtNombreUsuario = new DevExpress.XtraEditors.TextEdit();
            this.txtNombreServidor = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.formAssistant1 = new DevExpress.XtraBars.FormAssistant();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Conexion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.tpServidorBD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreBaseDatos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContrasena.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreServidor.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(506, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::winAppSAIC.Properties.Resources.Salir24x24;
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(49, 22);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpServidorBD);
            this.tabControl1.Controls.Add(this.Conexion);
            this.tabControl1.Location = new System.Drawing.Point(12, 40);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(482, 234);
            this.tabControl1.TabIndex = 1;
            // 
            // Conexion
            // 
            this.Conexion.Controls.Add(this.groupControl1);
            this.Conexion.Location = new System.Drawing.Point(4, 22);
            this.Conexion.Name = "Conexion";
            this.Conexion.Padding = new System.Windows.Forms.Padding(3);
            this.Conexion.Size = new System.Drawing.Size(474, 208);
            this.Conexion.TabIndex = 1;
            this.Conexion.Text = "Conexion";
            this.Conexion.UseVisualStyleBackColor = true;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.rdRemoto);
            this.groupControl1.Controls.Add(this.rdLocal);
            this.groupControl1.Location = new System.Drawing.Point(126, 53);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(200, 100);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Tipo Conexion";
            // 
            // rdRemoto
            // 
            this.rdRemoto.AutoSize = true;
            this.rdRemoto.Location = new System.Drawing.Point(42, 56);
            this.rdRemoto.Name = "rdRemoto";
            this.rdRemoto.Size = new System.Drawing.Size(62, 17);
            this.rdRemoto.TabIndex = 1;
            this.rdRemoto.TabStop = true;
            this.rdRemoto.Text = "Remota";
            this.rdRemoto.UseVisualStyleBackColor = true;
            this.rdRemoto.CheckedChanged += new System.EventHandler(this.rdRemoto_CheckedChanged);
            // 
            // rdLocal
            // 
            this.rdLocal.AutoSize = true;
            this.rdLocal.Location = new System.Drawing.Point(42, 33);
            this.rdLocal.Name = "rdLocal";
            this.rdLocal.Size = new System.Drawing.Size(49, 17);
            this.rdLocal.TabIndex = 0;
            this.rdLocal.TabStop = true;
            this.rdLocal.Text = "Local";
            this.rdLocal.UseVisualStyleBackColor = true;
            // 
            // tpServidorBD
            // 
            this.tpServidorBD.Controls.Add(this.btnGuardarInfoAppConfig);
            this.tpServidorBD.Controls.Add(this.btnProbarConexionBD);
            this.tpServidorBD.Controls.Add(this.txtNombreBaseDatos);
            this.tpServidorBD.Controls.Add(this.label4);
            this.tpServidorBD.Controls.Add(this.txtContrasena);
            this.tpServidorBD.Controls.Add(this.txtNombreUsuario);
            this.tpServidorBD.Controls.Add(this.txtNombreServidor);
            this.tpServidorBD.Controls.Add(this.label3);
            this.tpServidorBD.Controls.Add(this.label2);
            this.tpServidorBD.Controls.Add(this.label1);
            this.tpServidorBD.Location = new System.Drawing.Point(4, 22);
            this.tpServidorBD.Name = "tpServidorBD";
            this.tpServidorBD.Padding = new System.Windows.Forms.Padding(3);
            this.tpServidorBD.Size = new System.Drawing.Size(474, 208);
            this.tpServidorBD.TabIndex = 0;
            this.tpServidorBD.Text = "Servidor Base de Datos";
            this.tpServidorBD.UseVisualStyleBackColor = true;
            // 
            // btnGuardarInfoAppConfig
            // 
            this.btnGuardarInfoAppConfig.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarInfoAppConfig.ImageOptions.Image")));
            this.btnGuardarInfoAppConfig.Location = new System.Drawing.Point(301, 71);
            this.btnGuardarInfoAppConfig.Name = "btnGuardarInfoAppConfig";
            this.btnGuardarInfoAppConfig.Size = new System.Drawing.Size(167, 25);
            this.btnGuardarInfoAppConfig.TabIndex = 12;
            this.btnGuardarInfoAppConfig.Text = "Guardar Información";
            this.btnGuardarInfoAppConfig.Click += new System.EventHandler(this.btnGuardarInfoAppConfig_Click_1);
            // 
            // btnProbarConexionBD
            // 
            this.btnProbarConexionBD.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnProbarConexionBD.ImageOptions.Image")));
            this.btnProbarConexionBD.Location = new System.Drawing.Point(303, 39);
            this.btnProbarConexionBD.Name = "btnProbarConexionBD";
            this.btnProbarConexionBD.Size = new System.Drawing.Size(165, 25);
            this.btnProbarConexionBD.TabIndex = 11;
            this.btnProbarConexionBD.Text = "Probar Conexión BD";
            this.btnProbarConexionBD.Click += new System.EventHandler(this.btnProbarConexionBD_Click_1);
            // 
            // txtNombreBaseDatos
            // 
            this.txtNombreBaseDatos.Location = new System.Drawing.Point(15, 87);
            this.txtNombreBaseDatos.Name = "txtNombreBaseDatos";
            this.txtNombreBaseDatos.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreBaseDatos.Properties.MaxLength = 50;
            this.txtNombreBaseDatos.Size = new System.Drawing.Size(258, 20);
            this.txtNombreBaseDatos.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre Base de Datos";
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(15, 173);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Properties.MaxLength = 20;
            this.txtContrasena.Properties.PasswordChar = '*';
            this.txtContrasena.Properties.UseSystemPasswordChar = true;
            this.txtContrasena.Size = new System.Drawing.Size(258, 20);
            this.txtContrasena.TabIndex = 8;
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(15, 130);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Properties.MaxLength = 20;
            this.txtNombreUsuario.Size = new System.Drawing.Size(258, 20);
            this.txtNombreUsuario.TabIndex = 6;
            // 
            // txtNombreServidor
            // 
            this.txtNombreServidor.Location = new System.Drawing.Point(15, 44);
            this.txtNombreServidor.Name = "txtNombreServidor";
            this.txtNombreServidor.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreServidor.Properties.MaxLength = 50;
            this.txtNombreServidor.Size = new System.Drawing.Size(258, 20);
            this.txtNombreServidor.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre del Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del Servidor/Dirección IP";
            // 
            // frmConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 290);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmConfiguracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opciones de Configuración";
            this.Load += new System.EventHandler(this.frmConfiguracion_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.Conexion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.tpServidorBD.ResumeLayout(false);
            this.tpServidorBD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreBaseDatos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContrasena.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreServidor.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpServidorBD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtContrasena;
        private DevExpress.XtraEditors.TextEdit txtNombreUsuario;
        private DevExpress.XtraEditors.TextEdit txtNombreServidor;
        private DevExpress.XtraEditors.TextEdit txtNombreBaseDatos;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraBars.FormAssistant formAssistant1;
        private DevExpress.XtraEditors.SimpleButton btnGuardarInfoAppConfig;
        private DevExpress.XtraEditors.SimpleButton btnProbarConexionBD;
        private System.Windows.Forms.TabPage Conexion;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.RadioButton rdRemoto;
        private System.Windows.Forms.RadioButton rdLocal;
    }
}