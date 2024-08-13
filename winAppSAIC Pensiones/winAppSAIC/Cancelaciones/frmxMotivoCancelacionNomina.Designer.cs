namespace winAppSAIC.Cancelaciones
{
    partial class frmxMotivoCancelacionNomina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmxMotivoCancelacionNomina));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtMotivoCancelacion = new DevExpress.XtraEditors.MemoEdit();
            this.btnAceptar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtMotivoCancelacion.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(212, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Motivo por el cual desea cancelar la Nómina:";
            // 
            // txtMotivoCancelacion
            // 
            this.txtMotivoCancelacion.Location = new System.Drawing.Point(13, 33);
            this.txtMotivoCancelacion.Name = "txtMotivoCancelacion";
            this.txtMotivoCancelacion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMotivoCancelacion.Properties.MaxLength = 255;
            this.txtMotivoCancelacion.Size = new System.Drawing.Size(279, 51);
            this.txtMotivoCancelacion.TabIndex = 1;
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(202, 90);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(90, 23);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            // 
            // frmxMotivoCancelacionNomina
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 122);
            this.ControlBox = false;
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtMotivoCancelacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmxMotivoCancelacionNomina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitud Cancelación Nomina";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmxMotivoCancelacionNomina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtMotivoCancelacion.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnAceptar;
        public DevExpress.XtraEditors.MemoEdit txtMotivoCancelacion;
    }
}