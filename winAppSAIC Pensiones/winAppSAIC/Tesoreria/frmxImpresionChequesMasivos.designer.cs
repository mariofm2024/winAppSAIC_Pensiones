namespace winAppSAIC.Tesoreria
{
    partial class frmxImpresionChequesMasivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmxImpresionChequesMasivos));
            this.txtCuentaBanco = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIdCuentabanco = new System.Windows.Forms.Label();
            this.txtNoChequeInicial = new DevExpress.XtraEditors.TextEdit();
            this.txtNoChequeFinal = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblIdTransaccionBancoInicial = new System.Windows.Forms.Label();
            this.lblIdTransaccionBancoFinal = new System.Windows.Forms.Label();
            this.btnBuscarChequeInicial = new DevExpress.XtraEditors.SimpleButton();
            this.btnBuscarChequeFinal = new DevExpress.XtraEditors.SimpleButton();
            this.cboTipoImpresora = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAceptar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuentaBanco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoChequeInicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoChequeFinal.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCuentaBanco
            // 
            this.txtCuentaBanco.Location = new System.Drawing.Point(116, 39);
            this.txtCuentaBanco.Name = "txtCuentaBanco";
            this.txtCuentaBanco.Properties.ReadOnly = true;
            this.txtCuentaBanco.Size = new System.Drawing.Size(368, 20);
            this.txtCuentaBanco.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cuenta de Banco";
            // 
            // lblIdCuentabanco
            // 
            this.lblIdCuentabanco.AutoSize = true;
            this.lblIdCuentabanco.Location = new System.Drawing.Point(16, 98);
            this.lblIdCuentabanco.Name = "lblIdCuentabanco";
            this.lblIdCuentabanco.Size = new System.Drawing.Size(91, 13);
            this.lblIdCuentabanco.TabIndex = 12;
            this.lblIdCuentabanco.Text = "lblIdCuentabanco";
            this.lblIdCuentabanco.Visible = false;
            // 
            // txtNoChequeInicial
            // 
            this.txtNoChequeInicial.Location = new System.Drawing.Point(116, 66);
            this.txtNoChequeInicial.Name = "txtNoChequeInicial";
            this.txtNoChequeInicial.Properties.ReadOnly = true;
            this.txtNoChequeInicial.Size = new System.Drawing.Size(90, 20);
            this.txtNoChequeInicial.TabIndex = 5;
            this.txtNoChequeInicial.Tag = "Folio Cheque Inicial";
            // 
            // txtNoChequeFinal
            // 
            this.txtNoChequeFinal.Location = new System.Drawing.Point(355, 66);
            this.txtNoChequeFinal.Name = "txtNoChequeFinal";
            this.txtNoChequeFinal.Properties.ReadOnly = true;
            this.txtNoChequeFinal.Size = new System.Drawing.Size(90, 20);
            this.txtNoChequeFinal.TabIndex = 8;
            this.txtNoChequeFinal.Tag = "Folio Cheque Final";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 4;
            this.label3.Tag = "";
            this.label3.Text = "Folio Cheque Inicial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 7;
            this.label4.Tag = "";
            this.label4.Text = "Folio Cheque Final";
            // 
            // lblIdTransaccionBancoInicial
            // 
            this.lblIdTransaccionBancoInicial.AutoSize = true;
            this.lblIdTransaccionBancoInicial.Location = new System.Drawing.Point(16, 111);
            this.lblIdTransaccionBancoInicial.Name = "lblIdTransaccionBancoInicial";
            this.lblIdTransaccionBancoInicial.Size = new System.Drawing.Size(140, 13);
            this.lblIdTransaccionBancoInicial.TabIndex = 14;
            this.lblIdTransaccionBancoInicial.Text = "lblIdTransaccionBancoInicial";
            this.lblIdTransaccionBancoInicial.Visible = false;
            // 
            // lblIdTransaccionBancoFinal
            // 
            this.lblIdTransaccionBancoFinal.AutoSize = true;
            this.lblIdTransaccionBancoFinal.Location = new System.Drawing.Point(162, 111);
            this.lblIdTransaccionBancoFinal.Name = "lblIdTransaccionBancoFinal";
            this.lblIdTransaccionBancoFinal.Size = new System.Drawing.Size(135, 13);
            this.lblIdTransaccionBancoFinal.TabIndex = 13;
            this.lblIdTransaccionBancoFinal.Text = "lblIdTransaccionBancoFinal";
            this.lblIdTransaccionBancoFinal.Visible = false;
            // 
            // btnBuscarChequeInicial
            // 
            this.btnBuscarChequeInicial.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarChequeInicial.Image")));
            this.btnBuscarChequeInicial.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnBuscarChequeInicial.Location = new System.Drawing.Point(212, 65);
            this.btnBuscarChequeInicial.Name = "btnBuscarChequeInicial";
            this.btnBuscarChequeInicial.Size = new System.Drawing.Size(32, 23);
            this.btnBuscarChequeInicial.TabIndex = 6;
            this.btnBuscarChequeInicial.ToolTip = "Buscar";
            this.btnBuscarChequeInicial.Click += new System.EventHandler(this.btnBuscarChequeInicial_Click);
            // 
            // btnBuscarChequeFinal
            // 
            this.btnBuscarChequeFinal.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarChequeFinal.Image")));
            this.btnBuscarChequeFinal.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnBuscarChequeFinal.Location = new System.Drawing.Point(452, 65);
            this.btnBuscarChequeFinal.Name = "btnBuscarChequeFinal";
            this.btnBuscarChequeFinal.Size = new System.Drawing.Size(32, 23);
            this.btnBuscarChequeFinal.TabIndex = 9;
            this.btnBuscarChequeFinal.ToolTip = "Buscar";
            this.btnBuscarChequeFinal.Click += new System.EventHandler(this.btnBuscarChequeFinal_Click);
            // 
            // cboTipoImpresora
            // 
            this.cboTipoImpresora.FormattingEnabled = true;
            this.cboTipoImpresora.Location = new System.Drawing.Point(116, 12);
            this.cboTipoImpresora.Name = "cboTipoImpresora";
            this.cboTipoImpresora.Size = new System.Drawing.Size(368, 21);
            this.cboTipoImpresora.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Impresora";
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(399, 101);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(308, 101);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(85, 23);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmxImpresionChequesMasivos
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(502, 137);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboTipoImpresora);
            this.Controls.Add(this.btnBuscarChequeFinal);
            this.Controls.Add(this.btnBuscarChequeInicial);
            this.Controls.Add(this.lblIdTransaccionBancoFinal);
            this.Controls.Add(this.lblIdTransaccionBancoInicial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNoChequeFinal);
            this.Controls.Add(this.txtNoChequeInicial);
            this.Controls.Add(this.lblIdCuentabanco);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCuentaBanco);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmxImpresionChequesMasivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Impresión de Cheques Masivos";
            this.Load += new System.EventHandler(this.frmxImpresionChequesMasivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtCuentaBanco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoChequeInicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoChequeFinal.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtCuentaBanco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIdCuentabanco;
        private DevExpress.XtraEditors.TextEdit txtNoChequeInicial;
        private DevExpress.XtraEditors.TextEdit txtNoChequeFinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblIdTransaccionBancoInicial;
        private System.Windows.Forms.Label lblIdTransaccionBancoFinal;
        private DevExpress.XtraEditors.SimpleButton btnBuscarChequeInicial;
        private DevExpress.XtraEditors.SimpleButton btnBuscarChequeFinal;
        private System.Windows.Forms.ComboBox cboTipoImpresora;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnAceptar;
    }
}