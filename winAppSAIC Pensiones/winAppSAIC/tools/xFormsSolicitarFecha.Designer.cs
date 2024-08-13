namespace winAppSAIC.tools
{
    partial class xFormsSolicitarFecha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xFormsSolicitarFecha));
            this.labelDescripcion = new DevExpress.XtraEditors.LabelControl();
            this.dtFecha = new DevExpress.XtraEditors.DateEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTitulo = new DevExpress.XtraEditors.LabelControl();
            this.btnAceptar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.stpSelNominaCFDIBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.stpSelEstatusNominaContabilizadaTableAdapter1 = new winAppSAIC.dbSAICBPOValidacionDataSetTableAdapters.stpSelEstatusNominaContabilizadaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelNominaCFDIBindingNavigator)).BeginInit();
            this.stpSelNominaCFDIBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelDescripcion.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelDescripcion.Appearance.Options.UseFont = true;
            this.labelDescripcion.Appearance.Options.UseForeColor = true;
            this.labelDescripcion.Location = new System.Drawing.Point(12, 10);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(99, 13);
            this.labelDescripcion.TabIndex = 0;
            this.labelDescripcion.Text = "Seleccione Fecha:";
            // 
            // dtFecha
            // 
            this.dtFecha.EditValue = null;
            this.dtFecha.Location = new System.Drawing.Point(189, 7);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFecha.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFecha.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dtFecha.Size = new System.Drawing.Size(179, 20);
            this.dtFecha.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(153)))), ((int)(((byte)(205)))));
            this.panel1.Controls.Add(this.labelDescripcion);
            this.panel1.Controls.Add(this.dtFecha);
            this.panel1.Location = new System.Drawing.Point(0, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 33);
            this.panel1.TabIndex = 2;
            // 
            // labelTitulo
            // 
            this.labelTitulo.Appearance.Font = new System.Drawing.Font("Tahoma", 9.25F, System.Drawing.FontStyle.Bold);
            this.labelTitulo.Appearance.Options.UseFont = true;
            this.labelTitulo.Location = new System.Drawing.Point(7, 37);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(284, 14);
            this.labelTitulo.TabIndex = 2;
            this.labelTitulo.Text = "Seleccione una fecha de Confirmacion de pago";
            // 
            // btnAceptar
            // 
            this.btnAceptar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.ImageOptions.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(222, 105);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(146, 23);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Confirmar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.ImageOptions.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(70, 105);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(146, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // stpSelNominaCFDIBindingNavigator
            // 
            this.stpSelNominaCFDIBindingNavigator.AddNewItem = null;
            this.stpSelNominaCFDIBindingNavigator.CountItem = null;
            this.stpSelNominaCFDIBindingNavigator.CountItemFormat = "de {0}";
            this.stpSelNominaCFDIBindingNavigator.DeleteItem = null;
            this.stpSelNominaCFDIBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripSeparator1});
            this.stpSelNominaCFDIBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.stpSelNominaCFDIBindingNavigator.MoveFirstItem = null;
            this.stpSelNominaCFDIBindingNavigator.MoveLastItem = null;
            this.stpSelNominaCFDIBindingNavigator.MoveNextItem = null;
            this.stpSelNominaCFDIBindingNavigator.MovePreviousItem = null;
            this.stpSelNominaCFDIBindingNavigator.Name = "stpSelNominaCFDIBindingNavigator";
            this.stpSelNominaCFDIBindingNavigator.PositionItem = null;
            this.stpSelNominaCFDIBindingNavigator.Size = new System.Drawing.Size(380, 25);
            this.stpSelNominaCFDIBindingNavigator.TabIndex = 24;
            this.stpSelNominaCFDIBindingNavigator.Text = "bindingNavigator1";
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
            // xFormsSolicitarFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 138);
            this.Controls.Add(this.stpSelNominaCFDIBindingNavigator);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(396, 177);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(396, 177);
            this.Name = "xFormsSolicitarFecha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "Fecha";
            this.Text = "Fecha";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.xFormsSolicitarFecha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelNominaCFDIBindingNavigator)).EndInit();
            this.stpSelNominaCFDIBindingNavigator.ResumeLayout(false);
            this.stpSelNominaCFDIBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelDescripcion;
        private DevExpress.XtraEditors.DateEdit dtFecha;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelTitulo;
        private DevExpress.XtraEditors.SimpleButton btnAceptar;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private System.Windows.Forms.BindingNavigator stpSelNominaCFDIBindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private dbSAICBPOValidacionDataSetTableAdapters.stpSelEstatusNominaContabilizadaTableAdapter stpSelEstatusNominaContabilizadaTableAdapter1;
    }
}