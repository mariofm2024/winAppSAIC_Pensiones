namespace winAppSAIC.OperadoresM
{
    partial class xtraInformacionContrato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xtraInformacionContrato));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnAgregarInformacionContrato = new DevExpress.XtraEditors.SimpleButton();
            this.btnLimpiarCampos = new DevExpress.XtraEditors.SimpleButton();
            this.lblDiasVacaciones = new System.Windows.Forms.Label();
            this.lblPVacacional = new System.Windows.Forms.Label();
            this.lblAguinaldo = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.sePrimaVacacional = new DevExpress.XtraEditors.SpinEdit();
            this.txtSDGV = new DevExpress.XtraEditors.TextEdit();
            this.seAguinaldo = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.seVacaciones = new DevExpress.XtraEditors.SpinEdit();
            this.txtUMA = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtFactorIntegracion = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sePrimaVacacional.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDGV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seAguinaldo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seVacaciones.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUMA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFactorIntegracion.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(50, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(57, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Vacaciones:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(55, 73);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(51, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Aguinaldo:";
            // 
            // btnAgregarInformacionContrato
            // 
            this.btnAgregarInformacionContrato.ImageOptions.Image = global::winAppSAIC.Properties.Resources.add;
            this.btnAgregarInformacionContrato.Location = new System.Drawing.Point(321, 116);
            this.btnAgregarInformacionContrato.Name = "btnAgregarInformacionContrato";
            this.btnAgregarInformacionContrato.Size = new System.Drawing.Size(104, 23);
            this.btnAgregarInformacionContrato.TabIndex = 8;
            this.btnAgregarInformacionContrato.Text = "Agregar";
            this.btnAgregarInformacionContrato.Click += new System.EventHandler(this.btnAgregarInformacionContrato_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiarCampos.ImageOptions.Image")));
            this.btnLimpiarCampos.Location = new System.Drawing.Point(212, 116);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(104, 23);
            this.btnLimpiarCampos.TabIndex = 9;
            this.btnLimpiarCampos.Text = "Restablecer";
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // lblDiasVacaciones
            // 
            this.lblDiasVacaciones.AutoSize = true;
            this.lblDiasVacaciones.Location = new System.Drawing.Point(164, 31);
            this.lblDiasVacaciones.Name = "lblDiasVacaciones";
            this.lblDiasVacaciones.Size = new System.Drawing.Size(27, 13);
            this.lblDiasVacaciones.TabIndex = 11;
            this.lblDiasVacaciones.Text = "Días";
            // 
            // lblPVacacional
            // 
            this.lblPVacacional.AutoSize = true;
            this.lblPVacacional.Location = new System.Drawing.Point(166, 54);
            this.lblPVacacional.Name = "lblPVacacional";
            this.lblPVacacional.Size = new System.Drawing.Size(18, 13);
            this.lblPVacacional.TabIndex = 13;
            this.lblPVacacional.Text = "%";
            // 
            // lblAguinaldo
            // 
            this.lblAguinaldo.AutoSize = true;
            this.lblAguinaldo.Location = new System.Drawing.Point(165, 76);
            this.lblAguinaldo.Name = "lblAguinaldo";
            this.lblAguinaldo.Size = new System.Drawing.Size(27, 13);
            this.lblAguinaldo.TabIndex = 15;
            this.lblAguinaldo.Text = "Días";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.sePrimaVacacional);
            this.groupControl1.Controls.Add(this.txtSDGV);
            this.groupControl1.Controls.Add(this.seAguinaldo);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.seVacaciones);
            this.groupControl1.Controls.Add(this.txtUMA);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtFactorIntegracion);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.lblAguinaldo);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.lblPVacacional);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.lblDiasVacaciones);
            this.groupControl1.Location = new System.Drawing.Point(8, 8);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(418, 101);
            this.groupControl1.TabIndex = 16;
            this.groupControl1.Text = "Prestaciones";
            // 
            // sePrimaVacacional
            // 
            this.sePrimaVacacional.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.sePrimaVacacional.Location = new System.Drawing.Point(109, 48);
            this.sePrimaVacacional.Name = "sePrimaVacacional";
            this.sePrimaVacacional.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.sePrimaVacacional.Properties.Appearance.Options.UseBackColor = true;
            this.sePrimaVacacional.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sePrimaVacacional.Properties.DisplayFormat.FormatString = "N2";
            this.sePrimaVacacional.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.sePrimaVacacional.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.sePrimaVacacional.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.sePrimaVacacional.Size = new System.Drawing.Size(55, 20);
            this.sePrimaVacacional.TabIndex = 35;
            this.sePrimaVacacional.Tag = "Salario Diario (SD)";
            this.sePrimaVacacional.EditValueChanged += new System.EventHandler(this.sePrimaVacacional_EditValueChanged);
            // 
            // txtSDGV
            // 
            this.txtSDGV.Enabled = false;
            this.txtSDGV.Location = new System.Drawing.Point(326, 70);
            this.txtSDGV.Name = "txtSDGV";
            this.txtSDGV.Properties.Appearance.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtSDGV.Properties.Appearance.Options.UseBackColor = true;
            this.txtSDGV.Size = new System.Drawing.Size(82, 20);
            this.txtSDGV.TabIndex = 24;
            // 
            // seAguinaldo
            // 
            this.seAguinaldo.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seAguinaldo.Location = new System.Drawing.Point(109, 69);
            this.seAguinaldo.Name = "seAguinaldo";
            this.seAguinaldo.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.seAguinaldo.Properties.Appearance.Options.UseBackColor = true;
            this.seAguinaldo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seAguinaldo.Properties.DisplayFormat.FormatString = "N2";
            this.seAguinaldo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seAguinaldo.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.seAguinaldo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.seAguinaldo.Size = new System.Drawing.Size(55, 20);
            this.seAguinaldo.TabIndex = 34;
            this.seAguinaldo.Tag = "Salario Diario (SD)";
            this.seAguinaldo.EditValueChanged += new System.EventHandler(this.seAguinaldo_EditValueChanged);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(247, 75);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(71, 13);
            this.labelControl6.TabIndex = 23;
            this.labelControl6.Text = "SDGV (Actual):";
            // 
            // seVacaciones
            // 
            this.seVacaciones.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seVacaciones.Location = new System.Drawing.Point(109, 26);
            this.seVacaciones.Name = "seVacaciones";
            this.seVacaciones.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.seVacaciones.Properties.Appearance.Options.UseBackColor = true;
            this.seVacaciones.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seVacaciones.Properties.DisplayFormat.FormatString = "N2";
            this.seVacaciones.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seVacaciones.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.seVacaciones.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.seVacaciones.Size = new System.Drawing.Size(55, 20);
            this.seVacaciones.TabIndex = 33;
            this.seVacaciones.Tag = "Salario Diario (SD)";
            this.seVacaciones.EditValueChanged += new System.EventHandler(this.seVacaciones_EditValueChanged);
            // 
            // txtUMA
            // 
            this.txtUMA.Enabled = false;
            this.txtUMA.Location = new System.Drawing.Point(326, 48);
            this.txtUMA.Name = "txtUMA";
            this.txtUMA.Properties.Appearance.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtUMA.Properties.Appearance.Options.UseBackColor = true;
            this.txtUMA.Size = new System.Drawing.Size(82, 20);
            this.txtUMA.TabIndex = 22;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(251, 51);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(67, 13);
            this.labelControl4.TabIndex = 21;
            this.labelControl4.Text = "UMA (Actual):";
            // 
            // txtFactorIntegracion
            // 
            this.txtFactorIntegracion.Enabled = false;
            this.txtFactorIntegracion.Location = new System.Drawing.Point(326, 24);
            this.txtFactorIntegracion.Name = "txtFactorIntegracion";
            this.txtFactorIntegracion.Properties.Appearance.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtFactorIntegracion.Properties.Appearance.Options.UseBackColor = true;
            this.txtFactorIntegracion.Size = new System.Drawing.Size(82, 20);
            this.txtFactorIntegracion.TabIndex = 20;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(213, 29);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(108, 13);
            this.labelControl2.TabIndex = 19;
            this.labelControl2.Text = "Factor de Integración:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(24, 53);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(83, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Prima Vacacional:";
            // 
            // xtraInformacionContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 147);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnAgregarInformacionContrato);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "xtraInformacionContrato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informacion Contrato";
            this.Load += new System.EventHandler(this.xtraInformacionContrato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sePrimaVacacional.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDGV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seAguinaldo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seVacaciones.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUMA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFactorIntegracion.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnAgregarInformacionContrato;
        private DevExpress.XtraEditors.SimpleButton btnLimpiarCampos;
        private System.Windows.Forms.Label lblDiasVacaciones;
        private System.Windows.Forms.Label lblPVacacional;
        private System.Windows.Forms.Label lblAguinaldo;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtFactorIntegracion;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtUMA;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtSDGV;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SpinEdit sePrimaVacacional;
        private DevExpress.XtraEditors.SpinEdit seAguinaldo;
        private DevExpress.XtraEditors.SpinEdit seVacaciones;
    }
}