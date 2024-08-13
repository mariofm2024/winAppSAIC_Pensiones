namespace winAppSAIC.Catalogos
{
    partial class XtraSubirCertificados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraSubirCertificados));
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcer = new DevExpress.XtraEditors.ButtonEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcerpem = new DevExpress.XtraEditors.ButtonEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.txtkeyenc = new DevExpress.XtraEditors.ButtonEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.txtkey = new DevExpress.XtraEditors.ButtonEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.txtkeypem = new DevExpress.XtraEditors.ButtonEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.txtContrasenaCer = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtContrasenaPack = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.queryCatalodos1 = new winAppSAIC.Catalogos.dbSAIC_CatalogosTableAdapters.QueryCatalodos();
            this.ofdComprobante = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.txtcer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcerpem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtkeyenc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtkey.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtkeypem.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(119, 15);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(100, 21);
            this.txtId.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(119, 39);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(372, 21);
            this.txtNombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre Comercial:";
            // 
            // txtRFC
            // 
            this.txtRFC.Location = new System.Drawing.Point(119, 63);
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.ReadOnly = true;
            this.txtRFC.Size = new System.Drawing.Size(200, 21);
            this.txtRFC.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "RFC:";
            // 
            // txtcer
            // 
            this.txtcer.EditValue = "";
            this.txtcer.Location = new System.Drawing.Point(119, 117);
            this.txtcer.Name = "txtcer";
            this.txtcer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtcer.Size = new System.Drawing.Size(315, 20);
            this.txtcer.TabIndex = 104;
            this.txtcer.Tag = "Certificado";
            this.txtcer.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtcer_ButtonClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 105;
            this.label4.Text = "Cer:";
            // 
            // txtcerpem
            // 
            this.txtcerpem.EditValue = "";
            this.txtcerpem.Location = new System.Drawing.Point(511, 117);
            this.txtcerpem.Name = "txtcerpem";
            this.txtcerpem.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtcerpem.Size = new System.Drawing.Size(315, 20);
            this.txtcerpem.TabIndex = 106;
            this.txtcerpem.Tag = "Certificado Pem";
            this.txtcerpem.Visible = false;
            this.txtcerpem.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtcerpem_ButtonClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(453, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 107;
            this.label5.Text = "Cer.pem:";
            this.label5.Visible = false;
            // 
            // txtkeyenc
            // 
            this.txtkeyenc.Location = new System.Drawing.Point(511, 143);
            this.txtkeyenc.Name = "txtkeyenc";
            this.txtkeyenc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtkeyenc.Size = new System.Drawing.Size(315, 20);
            this.txtkeyenc.TabIndex = 110;
            this.txtkeyenc.Tag = "Key enc";
            this.txtkeyenc.Visible = false;
            this.txtkeyenc.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtkeyenc_ButtonClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(455, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 111;
            this.label6.Text = "Key.enc:";
            this.label6.Visible = false;
            // 
            // txtkey
            // 
            this.txtkey.Location = new System.Drawing.Point(119, 143);
            this.txtkey.Name = "txtkey";
            this.txtkey.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtkey.Size = new System.Drawing.Size(315, 20);
            this.txtkey.TabIndex = 108;
            this.txtkey.Tag = "Key";
            this.txtkey.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtkey_ButtonClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(84, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 109;
            this.label7.Text = "Key:";
            // 
            // txtkeypem
            // 
            this.txtkeypem.Location = new System.Drawing.Point(511, 169);
            this.txtkeypem.Name = "txtkeypem";
            this.txtkeypem.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtkeypem.Size = new System.Drawing.Size(315, 20);
            this.txtkeypem.TabIndex = 112;
            this.txtkeypem.Tag = "Key pem";
            this.txtkeypem.Visible = false;
            this.txtkeypem.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtkeypem_ButtonClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(452, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 113;
            this.label8.Text = "Key.pem:";
            this.label8.Visible = false;
            // 
            // txtContrasenaCer
            // 
            this.txtContrasenaCer.Location = new System.Drawing.Point(119, 169);
            this.txtContrasenaCer.MaxLength = 30;
            this.txtContrasenaCer.Name = "txtContrasenaCer";
            this.txtContrasenaCer.PasswordChar = '*';
            this.txtContrasenaCer.Size = new System.Drawing.Size(148, 21);
            this.txtContrasenaCer.TabIndex = 115;
            this.txtContrasenaCer.Tag = "Contraseña Cer";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 114;
            this.label9.Text = "Contraseña Cer:";
            // 
            // txtContrasenaPack
            // 
            this.txtContrasenaPack.Location = new System.Drawing.Point(383, 169);
            this.txtContrasenaPack.MaxLength = 30;
            this.txtContrasenaPack.Name = "txtContrasenaPack";
            this.txtContrasenaPack.PasswordChar = '*';
            this.txtContrasenaPack.Size = new System.Drawing.Size(108, 21);
            this.txtContrasenaPack.TabIndex = 117;
            this.txtContrasenaPack.Tag = "Contraseña Pack";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(285, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 13);
            this.label10.TabIndex = 116;
            this.label10.Text = "Contraseña Pack:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(119, 90);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(200, 21);
            this.txtUsuario.TabIndex = 119;
            this.txtUsuario.Tag = "Usuario";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(66, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 118;
            this.label11.Text = "Usuario:";
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(383, 90);
            this.txtSerie.MaxLength = 10;
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(108, 21);
            this.txtSerie.TabIndex = 121;
            this.txtSerie.Tag = "Serie";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(342, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 120;
            this.label12.Text = "Serie:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.Image")));
            this.btnGuardar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftBottom;
            this.btnGuardar.Location = new System.Drawing.Point(415, 12);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(76, 24);
            this.btnGuardar.TabIndex = 122;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // ofdComprobante
            // 
            this.ofdComprobante.FileName = "openFileDialog1";
            // 
            // XtraSubirCertificados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 211);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtContrasenaPack);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtContrasenaCer);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtkeypem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtkeyenc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtkey);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtcerpem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtcer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRFC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Name = "XtraSubirCertificados";
            this.Text = "Certificados";
            this.Load += new System.EventHandler(this.XtraSubirCertificados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtcer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcerpem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtkeyenc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtkey.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtkeypem.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRFC;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.ButtonEdit txtcer;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.ButtonEdit txtcerpem;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.ButtonEdit txtkeyenc;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.ButtonEdit txtkey;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.ButtonEdit txtkeypem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtContrasenaCer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtContrasenaPack;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label label12;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private dbSAIC_CatalogosTableAdapters.QueryCatalodos queryCatalodos1;
        private System.Windows.Forms.OpenFileDialog ofdComprobante;
    }
}