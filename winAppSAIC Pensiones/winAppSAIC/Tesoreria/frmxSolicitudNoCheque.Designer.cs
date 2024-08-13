namespace winAppSAIC.Tesoreria
{
    partial class frmxSolicitudNoCheque
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
            this.btnAceptar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtNoChequeInicial = new DevExpress.XtraEditors.SpinEdit();
            this.txtNoChequeFinal = new DevExpress.XtraEditors.SpinEdit();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoChequeInicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoChequeFinal.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.Location = new System.Drawing.Point(222, 17);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(87, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "No. Cheque Inicial";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 49);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(82, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "No. Cheque Final";
            // 
            // txtNoChequeInicial
            // 
            this.txtNoChequeInicial.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtNoChequeInicial.Location = new System.Drawing.Point(105, 20);
            this.txtNoChequeInicial.Name = "txtNoChequeInicial";
            this.txtNoChequeInicial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNoChequeInicial.Properties.Mask.EditMask = "n0";
            this.txtNoChequeInicial.Size = new System.Drawing.Size(100, 20);
            this.txtNoChequeInicial.TabIndex = 1;
            this.txtNoChequeInicial.Tag = "No. Cheque";
            // 
            // txtNoChequeFinal
            // 
            this.txtNoChequeFinal.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtNoChequeFinal.Location = new System.Drawing.Point(105, 46);
            this.txtNoChequeFinal.Name = "txtNoChequeFinal";
            this.txtNoChequeFinal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNoChequeFinal.Properties.Mask.EditMask = "n0";
            this.txtNoChequeFinal.Size = new System.Drawing.Size(100, 20);
            this.txtNoChequeFinal.TabIndex = 3;
            this.txtNoChequeFinal.Tag = "No. Cheque";
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(222, 46);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            // 
            // frmxSolicitudNoCheque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 82);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtNoChequeFinal);
            this.Controls.Add(this.txtNoChequeInicial);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmxSolicitudNoCheque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lectura Folios de Cheques";
            ((System.ComponentModel.ISupportInitialize)(this.txtNoChequeInicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoChequeFinal.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnAceptar;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        public DevExpress.XtraEditors.SpinEdit txtNoChequeInicial;
        public DevExpress.XtraEditors.SpinEdit txtNoChequeFinal;
    }
}