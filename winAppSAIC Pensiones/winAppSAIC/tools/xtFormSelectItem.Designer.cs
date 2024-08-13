namespace winAppSAIC.tools
{
    partial class xtFormSelectItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xtFormSelectItem));
            this.lblItemSeleccionado = new DevExpress.XtraEditors.LabelControl();
            this.btnSeleccionar = new DevExpress.XtraEditors.SimpleButton();
            this.cbListaItems = new DevExpress.XtraEditors.ComboBoxEdit();
            //this.stpSelObtenerBancoDeClabeTableAdapter1 = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelObtenerBancoDeClabeTableAdapter();
            this.lblTitulo = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.cbListaItems.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblItemSeleccionado
            // 
            this.lblItemSeleccionado.Location = new System.Drawing.Point(17, 62);
            this.lblItemSeleccionado.Name = "lblItemSeleccionado";
            this.lblItemSeleccionado.Size = new System.Drawing.Size(0, 13);
            this.lblItemSeleccionado.TabIndex = 15;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(120, 79);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(114, 23);
            this.btnSeleccionar.TabIndex = 14;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // cbListaItems
            // 
            this.cbListaItems.Location = new System.Drawing.Point(14, 36);
            this.cbListaItems.Name = "cbListaItems";
            this.cbListaItems.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbListaItems.Size = new System.Drawing.Size(340, 20);
            this.cbListaItems.TabIndex = 12;
            this.cbListaItems.SelectedIndexChanged += new System.EventHandler(this.cbListaItems_SelectedIndexChanged);
            // 
            // stpSelObtenerBancoDeClabeTableAdapter1
            // 
            //this.stpSelObtenerBancoDeClabeTableAdapter1.ClearBeforeFill = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblTitulo.Appearance.Options.UseFont = true;
            this.lblTitulo.Location = new System.Drawing.Point(14, 11);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(58, 19);
            this.lblTitulo.TabIndex = 13;
            this.lblTitulo.Text = "lblTitulo";
            // 
            // xtFormSelectItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 113);
            this.Controls.Add(this.lblItemSeleccionado);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.cbListaItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(385, 152);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(385, 152);
            this.Name = "xtFormSelectItem";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "xtFormSelectItem";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.xtFormSelectItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbListaItems.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblItemSeleccionado;
        private DevExpress.XtraEditors.SimpleButton btnSeleccionar;
        private DevExpress.XtraEditors.ComboBoxEdit cbListaItems;
        //private dbSAICBPOCatalogosDataSetTableAdapters.stpSelObtenerBancoDeClabeTableAdapter stpSelObtenerBancoDeClabeTableAdapter1;
        private DevExpress.XtraEditors.LabelControl lblTitulo;
    }
}