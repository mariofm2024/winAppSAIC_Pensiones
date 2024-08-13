namespace winAppSAIC
{
    partial class frmxVisualizarRelacionMovimientos
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.lblMovsTarjetasCheques = new DevExpress.XtraEditors.LabelControl();
            this.lblMovsInterbancarios = new DevExpress.XtraEditors.LabelControl();
            this.gvMovsTarjetasCheques = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gvMovsInterbancarios = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblNoMovsTarjetasCheques = new DevExpress.XtraEditors.LabelControl();
            this.lblNoMovsInterbancarios = new DevExpress.XtraEditors.LabelControl();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMovsTarjetasCheques)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMovsInterbancarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(934, 25);
            this.toolStrip1.TabIndex = 1;
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
            // lblMovsTarjetasCheques
            // 
            this.lblMovsTarjetasCheques.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblMovsTarjetasCheques.Location = new System.Drawing.Point(13, 41);
            this.lblMovsTarjetasCheques.Name = "lblMovsTarjetasCheques";
            this.lblMovsTarjetasCheques.Size = new System.Drawing.Size(178, 13);
            this.lblMovsTarjetasCheques.TabIndex = 2;
            this.lblMovsTarjetasCheques.Text = "Movimientos Tarjetas/Cheques";
            // 
            // lblMovsInterbancarios
            // 
            this.lblMovsInterbancarios.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblMovsInterbancarios.Location = new System.Drawing.Point(13, 246);
            this.lblMovsInterbancarios.Name = "lblMovsInterbancarios";
            this.lblMovsInterbancarios.Size = new System.Drawing.Size(160, 13);
            this.lblMovsInterbancarios.TabIndex = 3;
            this.lblMovsInterbancarios.Text = "Movimientos Interbancarios";
            // 
            // gvMovsTarjetasCheques
            // 
            this.gvMovsTarjetasCheques.Location = new System.Drawing.Point(13, 60);
            this.gvMovsTarjetasCheques.MainView = this.gridView1;
            this.gvMovsTarjetasCheques.Name = "gvMovsTarjetasCheques";
            this.gvMovsTarjetasCheques.Size = new System.Drawing.Size(909, 180);
            this.gvMovsTarjetasCheques.TabIndex = 4;
            this.gvMovsTarjetasCheques.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gvMovsTarjetasCheques;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gvMovsInterbancarios
            // 
            this.gvMovsInterbancarios.Location = new System.Drawing.Point(13, 266);
            this.gvMovsInterbancarios.MainView = this.gridView2;
            this.gvMovsInterbancarios.Name = "gvMovsInterbancarios";
            this.gvMovsInterbancarios.Size = new System.Drawing.Size(909, 180);
            this.gvMovsInterbancarios.TabIndex = 5;
            this.gvMovsInterbancarios.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gvMovsInterbancarios;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView2.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView2.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
            this.gridView2.OptionsView.EnableAppearanceOddRow = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelControl1.Location = new System.Drawing.Point(361, 41);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(177, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "No. de Movimientos Exportados";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelControl2.Location = new System.Drawing.Point(361, 246);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(177, 13);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "No. de Movimientos Exportados";
            // 
            // lblNoMovsTarjetasCheques
            // 
            this.lblNoMovsTarjetasCheques.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblNoMovsTarjetasCheques.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblNoMovsTarjetasCheques.Location = new System.Drawing.Point(551, 41);
            this.lblNoMovsTarjetasCheques.Name = "lblNoMovsTarjetasCheques";
            this.lblNoMovsTarjetasCheques.Size = new System.Drawing.Size(0, 13);
            this.lblNoMovsTarjetasCheques.TabIndex = 8;
            // 
            // lblNoMovsInterbancarios
            // 
            this.lblNoMovsInterbancarios.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblNoMovsInterbancarios.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblNoMovsInterbancarios.Location = new System.Drawing.Point(551, 246);
            this.lblNoMovsInterbancarios.Name = "lblNoMovsInterbancarios";
            this.lblNoMovsInterbancarios.Size = new System.Drawing.Size(0, 13);
            this.lblNoMovsInterbancarios.TabIndex = 9;
            // 
            // frmxVisualizarRelacionMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 461);
            this.ControlBox = false;
            this.Controls.Add(this.lblNoMovsInterbancarios);
            this.Controls.Add(this.lblNoMovsTarjetasCheques);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gvMovsInterbancarios);
            this.Controls.Add(this.gvMovsTarjetasCheques);
            this.Controls.Add(this.lblMovsInterbancarios);
            this.Controls.Add(this.lblMovsTarjetasCheques);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmxVisualizarRelacionMovimientos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizar Movimientos Exportados";
            this.Load += new System.EventHandler(this.frmxVisualizarRelacionMovimientos_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMovsTarjetasCheques)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMovsInterbancarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private DevExpress.XtraEditors.LabelControl lblMovsTarjetasCheques;
        private DevExpress.XtraEditors.LabelControl lblMovsInterbancarios;
        private DevExpress.XtraGrid.GridControl gvMovsTarjetasCheques;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gvMovsInterbancarios;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblNoMovsTarjetasCheques;
        private DevExpress.XtraEditors.LabelControl lblNoMovsInterbancarios;
    }
}