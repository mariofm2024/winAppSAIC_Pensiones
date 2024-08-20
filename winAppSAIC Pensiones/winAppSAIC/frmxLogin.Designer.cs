namespace winAppSAIC
{
    partial class frmxLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmxLogin));
            this.lblUsuario = new DevExpress.XtraEditors.LabelControl();
            this.lblContrasena = new DevExpress.XtraEditors.LabelControl();
            this.txtContrasena = new DevExpress.XtraEditors.TextEdit();
            this.txtUsuario = new DevExpress.XtraEditors.TextEdit();
            this.btnAceptar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.stpSelInfoOperadorLoginTableAdapter1 = new winAppSAIC.Seguridad.dbSAIC_SeguridadTableAdapters.stpSelInfoOperadorLoginTableAdapter();
            this.stpSelVersionApp2014TableAdapter1 = new winAppSAIC.dbSAICBPODataSetTableAdapters.stpSelVersionApp2014TableAdapter();
            this.checkRecordarPass = new DevExpress.XtraEditors.CheckEdit();
            this.stpSelObtenerDocCadenaOriginalTableAdapter1 = new winAppSAIC.Seguridad.dbSAIC_SeguridadTableAdapters.stpSelObtenerDocCadenaOriginalTableAdapter();
            this.splashScreenManager2 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::winAppSAIC.SplashDeCarga), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.txtContrasena.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkRecordarPass.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.Location = new System.Drawing.Point(18, 20);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(54, 19);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblContrasena
            // 
            this.lblContrasena.Location = new System.Drawing.Point(18, 60);
            this.lblContrasena.Margin = new System.Windows.Forms.Padding(4);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(79, 19);
            this.lblContrasena.TabIndex = 2;
            this.lblContrasena.Text = "Contraseña";
            // 
            // txtContrasena
            // 
            this.txtContrasena.EditValue = "mar0103floR3$";
            this.txtContrasena.Location = new System.Drawing.Point(128, 56);
            this.txtContrasena.Margin = new System.Windows.Forms.Padding(4);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Properties.MaxLength = 20;
            this.txtContrasena.Properties.PasswordChar = '*';
            this.txtContrasena.Properties.UseSystemPasswordChar = true;
            this.txtContrasena.Size = new System.Drawing.Size(338, 26);
            this.txtContrasena.TabIndex = 3;
            // 
            // txtUsuario
            // 
            this.txtUsuario.EditValue = "mario.flores";
            this.txtUsuario.Location = new System.Drawing.Point(128, 18);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Properties.MaxLength = 50;
            this.txtUsuario.Size = new System.Drawing.Size(338, 26);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.EditValueChanged += new System.EventHandler(this.txtUsuario_EditValueChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Enabled = false;
            this.btnAceptar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.ImageOptions.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(231, 98);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(112, 34);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.ImageOptions.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(352, 98);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 34);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // stpSelInfoOperadorLoginTableAdapter1
            // 
            this.stpSelInfoOperadorLoginTableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelVersionApp2014TableAdapter1
            // 
            this.stpSelVersionApp2014TableAdapter1.ClearBeforeFill = true;
            // 
            // checkRecordarPass
            // 
            this.checkRecordarPass.Location = new System.Drawing.Point(18, 102);
            this.checkRecordarPass.Margin = new System.Windows.Forms.Padding(4);
            this.checkRecordarPass.Name = "checkRecordarPass";
            this.checkRecordarPass.Properties.Caption = "Recordar Contraseña";
            this.checkRecordarPass.Size = new System.Drawing.Size(189, 23);
            this.checkRecordarPass.TabIndex = 6;
            this.checkRecordarPass.Visible = false;
            // 
            // stpSelObtenerDocCadenaOriginalTableAdapter1
            // 
            this.stpSelObtenerDocCadenaOriginalTableAdapter1.ClearBeforeFill = true;
            // 
            // splashScreenManager2
            // 
            this.splashScreenManager2.ClosingDelay = 500;
            // 
            // frmxLogin
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(533, 178);
            this.ControlBox = false;
            this.Controls.Add(this.checkRecordarPass);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.lblContrasena);
            this.Controls.Add(this.lblUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmxLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SAIC";
            this.Load += new System.EventHandler(this.frmxLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtContrasena.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkRecordarPass.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblUsuario;
        private DevExpress.XtraEditors.LabelControl lblContrasena;
        private DevExpress.XtraEditors.TextEdit txtContrasena;
        private DevExpress.XtraEditors.TextEdit txtUsuario;
        private DevExpress.XtraEditors.SimpleButton btnAceptar;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private Seguridad.dbSAIC_SeguridadTableAdapters.stpSelInfoOperadorLoginTableAdapter stpSelInfoOperadorLoginTableAdapter1;
        private dbSAICBPODataSetTableAdapters.stpSelVersionApp2014TableAdapter stpSelVersionApp2014TableAdapter1;
        private DevExpress.XtraEditors.CheckEdit checkRecordarPass;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private Seguridad.dbSAIC_SeguridadTableAdapters.stpSelObtenerDocCadenaOriginalTableAdapter stpSelObtenerDocCadenaOriginalTableAdapter1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager2;
    }
}