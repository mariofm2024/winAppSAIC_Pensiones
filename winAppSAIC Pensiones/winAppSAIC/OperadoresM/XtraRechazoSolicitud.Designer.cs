namespace winAppSAIC.OperadoresM
{
    partial class XtraRechazoSolicitud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraRechazoSolicitud));
            this.txtidEmpleado = new DevExpress.XtraEditors.TextEdit();
            this.txtNombreCompletoEmpleado = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelarTodaSolicitud = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRechazarTodaSolicitud = new System.Windows.Forms.ToolStripButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.memoRechazo = new DevExpress.XtraEditors.MemoEdit();
            this.btnSolicitudRechazada = new DevExpress.XtraEditors.SimpleButton();
            this.btnRechazar = new DevExpress.XtraEditors.SimpleButton();
            this.queriesTableAdapter1 = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.QueriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.txtidEmpleado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreCompletoEmpleado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelarTodaSolicitud)).BeginInit();
            this.btnCancelarTodaSolicitud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoRechazo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtidEmpleado
            // 
            this.txtidEmpleado.Enabled = false;
            this.txtidEmpleado.Location = new System.Drawing.Point(80, 34);
            this.txtidEmpleado.Name = "txtidEmpleado";
            this.txtidEmpleado.Properties.Appearance.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtidEmpleado.Properties.Appearance.Options.UseBackColor = true;
            this.txtidEmpleado.Size = new System.Drawing.Size(100, 20);
            this.txtidEmpleado.TabIndex = 0;
            // 
            // txtNombreCompletoEmpleado
            // 
            this.txtNombreCompletoEmpleado.Enabled = false;
            this.txtNombreCompletoEmpleado.Location = new System.Drawing.Point(292, 34);
            this.txtNombreCompletoEmpleado.Name = "txtNombreCompletoEmpleado";
            this.txtNombreCompletoEmpleado.Properties.Appearance.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtNombreCompletoEmpleado.Properties.Appearance.Options.UseBackColor = true;
            this.txtNombreCompletoEmpleado.Size = new System.Drawing.Size(312, 20);
            this.txtNombreCompletoEmpleado.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "IdEmpleado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.label4.Location = new System.Drawing.Point(190, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nombre Completo:";
            // 
            // btnCancelarTodaSolicitud
            // 
            this.btnCancelarTodaSolicitud.AddNewItem = null;
            this.btnCancelarTodaSolicitud.CountItem = null;
            this.btnCancelarTodaSolicitud.CountItemFormat = "de {0}";
            this.btnCancelarTodaSolicitud.DeleteItem = null;
            this.btnCancelarTodaSolicitud.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.btnRechazarTodaSolicitud});
            this.btnCancelarTodaSolicitud.Location = new System.Drawing.Point(0, 0);
            this.btnCancelarTodaSolicitud.MoveFirstItem = null;
            this.btnCancelarTodaSolicitud.MoveLastItem = null;
            this.btnCancelarTodaSolicitud.MoveNextItem = null;
            this.btnCancelarTodaSolicitud.MovePreviousItem = null;
            this.btnCancelarTodaSolicitud.Name = "btnCancelarTodaSolicitud";
            this.btnCancelarTodaSolicitud.PositionItem = null;
            this.btnCancelarTodaSolicitud.Size = new System.Drawing.Size(616, 25);
            this.btnCancelarTodaSolicitud.TabIndex = 22;
            this.btnCancelarTodaSolicitud.Text = "bindingNavigator1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::winAppSAIC.Properties.Resources.Salir24x24;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(49, 22);
            this.toolStripButton2.Text = "Salir";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnRechazarTodaSolicitud
            // 
            this.btnRechazarTodaSolicitud.Image = global::winAppSAIC.Properties.Resources.DocsCancelados32x32_1;
            this.btnRechazarTodaSolicitud.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRechazarTodaSolicitud.Name = "btnRechazarTodaSolicitud";
            this.btnRechazarTodaSolicitud.Size = new System.Drawing.Size(123, 22);
            this.btnRechazarTodaSolicitud.Text = "Rechazar Solicitud";
            this.btnRechazarTodaSolicitud.ToolTipText = "Se Rechazara todos los empleados de la Solicitud con el mismo comentario de Recha" +
    "zo agregado.";
            this.btnRechazarTodaSolicitud.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.memoRechazo);
            this.groupControl1.Location = new System.Drawing.Point(12, 60);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(591, 107);
            this.groupControl1.TabIndex = 23;
            this.groupControl1.Text = "Rechazo";
            // 
            // memoRechazo
            // 
            this.memoRechazo.Location = new System.Drawing.Point(4, 23);
            this.memoRechazo.Name = "memoRechazo";
            this.memoRechazo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.memoRechazo.Size = new System.Drawing.Size(565, 79);
            this.memoRechazo.TabIndex = 0;
            this.memoRechazo.EditValueChanged += new System.EventHandler(this.memoRechazo_EditValueChanged);
            // 
            // btnSolicitudRechazada
            // 
            this.btnSolicitudRechazada.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSolicitudRechazada.ImageOptions.Image")));
            this.btnSolicitudRechazada.Location = new System.Drawing.Point(331, 174);
            this.btnSolicitudRechazada.Name = "btnSolicitudRechazada";
            this.btnSolicitudRechazada.Size = new System.Drawing.Size(133, 23);
            this.btnSolicitudRechazada.TabIndex = 28;
            this.btnSolicitudRechazada.Text = "Cancelar";
            this.btnSolicitudRechazada.Click += new System.EventHandler(this.btnSolicitudRechazada_Click);
            // 
            // btnRechazar
            // 
            this.btnRechazar.Enabled = false;
            this.btnRechazar.ImageOptions.Image = global::winAppSAIC.Properties.Resources.SelectAll16x16;
            this.btnRechazar.Location = new System.Drawing.Point(470, 173);
            this.btnRechazar.Name = "btnRechazar";
            this.btnRechazar.Size = new System.Drawing.Size(133, 23);
            this.btnRechazar.TabIndex = 29;
            this.btnRechazar.Text = "Rechazar";
            this.btnRechazar.Click += new System.EventHandler(this.btnRechazar_Click);
            // 
            // XtraRechazoSolicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 205);
            this.Controls.Add(this.btnSolicitudRechazada);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.btnRechazar);
            this.Controls.Add(this.btnCancelarTodaSolicitud);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreCompletoEmpleado);
            this.Controls.Add(this.txtidEmpleado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(632, 244);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(632, 244);
            this.Name = "XtraRechazoSolicitud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rechazo";
            this.Load += new System.EventHandler(this.XtraRechazoSolicitud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtidEmpleado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreCompletoEmpleado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelarTodaSolicitud)).EndInit();
            this.btnCancelarTodaSolicitud.ResumeLayout(false);
            this.btnCancelarTodaSolicitud.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoRechazo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtidEmpleado;
        private DevExpress.XtraEditors.TextEdit txtNombreCompletoEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingNavigator btnCancelarTodaSolicitud;
        private System.Windows.Forms.ToolStripButton btnRechazarTodaSolicitud;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.MemoEdit memoRechazo;
        private DevExpress.XtraEditors.SimpleButton btnSolicitudRechazada;
        private DevExpress.XtraEditors.SimpleButton btnRechazar;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private dbSAICBPOCatalogosDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
    }
}