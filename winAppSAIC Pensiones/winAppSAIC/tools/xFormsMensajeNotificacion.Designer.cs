namespace winAppSAIC.tools
{
    partial class xFormsMensajeNotificacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xFormsMensajeNotificacion));
            this.lblTema = new DevExpress.XtraEditors.LabelControl();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.lblDescripcion = new DevExpress.XtraEditors.LabelControl();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAceptar = new DevExpress.XtraEditors.SimpleButton();
            this.lblFechaHora = new DevExpress.XtraEditors.LabelControl();
            this.lblSubtema = new DevExpress.XtraEditors.LabelControl();
            this.queriesTableAdapter1 = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.QueriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTema
            // 
            this.lblTema.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.lblTema.Appearance.Options.UseFont = true;
            this.lblTema.Location = new System.Drawing.Point(12, 12);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(55, 24);
            this.lblTema.TabIndex = 0;
            this.lblTema.Text = "Tema";
            // 
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(12, 116);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(537, 23);
            this.separatorControl1.TabIndex = 3;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AllowHtmlString = true;
            this.lblDescripcion.Appearance.Options.UseTextOptions = true;
            this.lblDescripcion.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblDescripcion.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.lblDescripcion.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.lblDescripcion.Location = new System.Drawing.Point(12, 65);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(537, 26);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras in elit dictum, bla" +
    "ndit lorem non, facilisis nulla. Aenean sem augue, molestie et est et, volutpat " +
    "tristique metus.";
            // 
            // btnCancelar
            // 
            this.btnCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.ImageOptions.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(301, 145);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cerrar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.ImageOptions.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(428, 145);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(121, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Dejar de Ver";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblFechaHora
            // 
            this.lblFechaHora.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblFechaHora.Appearance.Options.UseFont = true;
            this.lblFechaHora.Location = new System.Drawing.Point(447, 97);
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Size = new System.Drawing.Size(102, 13);
            this.lblFechaHora.TabIndex = 7;
            this.lblFechaHora.Text = "XX/XX/XXXX 00:00";
            // 
            // lblSubtema
            // 
            this.lblSubtema.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblSubtema.Appearance.Options.UseFont = true;
            this.lblSubtema.Location = new System.Drawing.Point(12, 40);
            this.lblSubtema.Name = "lblSubtema";
            this.lblSubtema.Size = new System.Drawing.Size(67, 19);
            this.lblSubtema.TabIndex = 8;
            this.lblSubtema.Text = "SubTema";
            // 
            // xFormsMensajeNotificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 177);
            this.Controls.Add(this.lblSubtema);
            this.Controls.Add(this.lblFechaHora);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.lblTema);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "xFormsMensajeNotificacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notificacion";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.xFormsMensajeNotificacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblTema;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.LabelControl lblDescripcion;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnAceptar;
        private DevExpress.XtraEditors.LabelControl lblFechaHora;
        private DevExpress.XtraEditors.LabelControl lblSubtema;
        private dbSAICBPOCatalogosDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
    }
}