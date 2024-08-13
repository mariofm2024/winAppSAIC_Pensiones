namespace winAppSAIC.Tesoreria
{
    partial class frmxMotivoCancelacionMovChequera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmxMotivoCancelacionMovChequera));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtMotivoCancelacion = new DevExpress.XtraEditors.MemoEdit();
            this.btnAceptar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cboSustituyeCheque = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtNoCheque = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMotivoCancelacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSustituyeCheque.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoCheque.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 71);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(120, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Motivo de la cancelación:";
            // 
            // txtMotivoCancelacion
            // 
            this.txtMotivoCancelacion.Location = new System.Drawing.Point(12, 91);
            this.txtMotivoCancelacion.Name = "txtMotivoCancelacion";
            this.txtMotivoCancelacion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMotivoCancelacion.Properties.MaxLength = 255;
            this.txtMotivoCancelacion.Size = new System.Drawing.Size(279, 51);
            this.txtMotivoCancelacion.TabIndex = 5;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(201, 148);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(90, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(181, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "¿La cancelación sustituye un Cheque?";
            // 
            // cboSustituyeCheque
            // 
            this.cboSustituyeCheque.Location = new System.Drawing.Point(216, 9);
            this.cboSustituyeCheque.Name = "cboSustituyeCheque";
            this.cboSustituyeCheque.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboSustituyeCheque.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cboSustituyeCheque.Properties.Items.AddRange(new object[] {
            "NO",
            "SI"});
            this.cboSustituyeCheque.Size = new System.Drawing.Size(75, 20);
            this.cboSustituyeCheque.TabIndex = 1;
            this.cboSustituyeCheque.SelectedIndexChanged += new System.EventHandler(this.cboSustituyeCheque_SelectedIndexChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 38);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(140, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "No. de Cheque que sustituye";
            // 
            // txtNoCheque
            // 
            this.txtNoCheque.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtNoCheque.Enabled = false;
            this.txtNoCheque.Location = new System.Drawing.Point(216, 35);
            this.txtNoCheque.Name = "txtNoCheque";
            this.txtNoCheque.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNoCheque.Properties.Mask.EditMask = "n0";
            this.txtNoCheque.Size = new System.Drawing.Size(75, 20);
            this.txtNoCheque.TabIndex = 3;
            this.txtNoCheque.Tag = "No. Cheque";
            // 
            // frmxMotivoCancelacionMovChequera
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 185);
            this.ControlBox = false;
            this.Controls.Add(this.txtNoCheque);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.cboSustituyeCheque);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtMotivoCancelacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmxMotivoCancelacionMovChequera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancelación Movimiento en Chequera";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmxSolicitudCancelacionNomina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtMotivoCancelacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSustituyeCheque.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoCheque.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnAceptar;
        public DevExpress.XtraEditors.MemoEdit txtMotivoCancelacion;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        public DevExpress.XtraEditors.ComboBoxEdit cboSustituyeCheque;
        public DevExpress.XtraEditors.SpinEdit txtNoCheque;
    }
}