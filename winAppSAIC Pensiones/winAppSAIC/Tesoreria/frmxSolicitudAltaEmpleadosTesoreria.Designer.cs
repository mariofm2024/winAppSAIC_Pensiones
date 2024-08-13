namespace winAppSAIC.Tesoreria
{
    partial class frmxSolicitudAltaEmpleadosTesoreria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmxSolicitudAltaEmpleadosTesoreria));
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.btnSolicitudRechazada = new DevExpress.XtraEditors.SimpleButton();
            this.btnSolicitudAtendida = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.GridControlSolcitudes = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.rdTenedoraSA = new System.Windows.Forms.RadioButton();
            this.rdTenedorSC = new System.Windows.Forms.RadioButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.rdTarjeta = new System.Windows.Forms.RadioButton();
            this.stpSelNominaCFDIBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlSolcitudes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelNominaCFDIBindingNavigator)).BeginInit();
            this.stpSelNominaCFDIBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.btnSolicitudRechazada);
            this.groupControl4.Controls.Add(this.btnSolicitudAtendida);
            this.groupControl4.Location = new System.Drawing.Point(590, 28);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(147, 111);
            this.groupControl4.TabIndex = 11;
            this.groupControl4.Text = "Acciones";
            // 
            // btnSolicitudRechazada
            // 
            this.btnSolicitudRechazada.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSolicitudRechazada.ImageOptions.Image")));
            this.btnSolicitudRechazada.Location = new System.Drawing.Point(7, 67);
            this.btnSolicitudRechazada.Name = "btnSolicitudRechazada";
            this.btnSolicitudRechazada.Size = new System.Drawing.Size(133, 23);
            this.btnSolicitudRechazada.TabIndex = 0;
            this.btnSolicitudRechazada.Text = "Rechazar Solicitud";
            // 
            // btnSolicitudAtendida
            // 
            this.btnSolicitudAtendida.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSolicitudAtendida.ImageOptions.Image")));
            this.btnSolicitudAtendida.Location = new System.Drawing.Point(7, 39);
            this.btnSolicitudAtendida.Name = "btnSolicitudAtendida";
            this.btnSolicitudAtendida.Size = new System.Drawing.Size(133, 23);
            this.btnSolicitudAtendida.TabIndex = 2;
            this.btnSolicitudAtendida.Text = "Solicitud Atendida";
            this.btnSolicitudAtendida.Click += new System.EventHandler(this.btnSolicitudAtendida_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(153)))), ((int)(((byte)(205)))));
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Location = new System.Drawing.Point(0, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 40);
            this.panel1.TabIndex = 17;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(8, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(45, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Estatus:";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.GridControlSolcitudes);
            this.groupControl3.Location = new System.Drawing.Point(9, 191);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(726, 212);
            this.groupControl3.TabIndex = 18;
            // 
            // GridControlSolcitudes
            // 
            this.GridControlSolcitudes.Cursor = System.Windows.Forms.Cursors.Default;
            this.GridControlSolcitudes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridControlSolcitudes.Location = new System.Drawing.Point(2, 20);
            this.GridControlSolcitudes.MainView = this.gridView2;
            this.GridControlSolcitudes.Name = "GridControlSolcitudes";
            this.GridControlSolcitudes.Size = new System.Drawing.Size(722, 190);
            this.GridControlSolcitudes.TabIndex = 3;
            this.GridControlSolcitudes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.GridControlSolcitudes;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView2.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsBehavior.ReadOnly = true;
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // rdTenedoraSA
            // 
            this.rdTenedoraSA.AutoSize = true;
            this.rdTenedoraSA.Checked = true;
            this.rdTenedoraSA.Location = new System.Drawing.Point(14, 37);
            this.rdTenedoraSA.Name = "rdTenedoraSA";
            this.rdTenedoraSA.Size = new System.Drawing.Size(62, 17);
            this.rdTenedoraSA.TabIndex = 3;
            this.rdTenedoraSA.TabStop = true;
            this.rdTenedoraSA.Text = "Sueldos";
            this.rdTenedoraSA.UseVisualStyleBackColor = true;
            // 
            // rdTenedorSC
            // 
            this.rdTenedorSC.AutoSize = true;
            this.rdTenedorSC.Location = new System.Drawing.Point(13, 56);
            this.rdTenedorSC.Name = "rdTenedorSC";
            this.rdTenedorSC.Size = new System.Drawing.Size(76, 17);
            this.rdTenedorSC.TabIndex = 4;
            this.rdTenedorSC.Text = "Excedente";
            this.rdTenedorSC.UseVisualStyleBackColor = true;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.rdTarjeta);
            this.groupControl2.Controls.Add(this.rdTenedorSC);
            this.groupControl2.Controls.Add(this.rdTenedoraSA);
            this.groupControl2.Location = new System.Drawing.Point(487, 28);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(97, 111);
            this.groupControl2.TabIndex = 12;
            this.groupControl2.Text = "Tipo Solicitud";
            // 
            // rdTarjeta
            // 
            this.rdTarjeta.AutoSize = true;
            this.rdTarjeta.Location = new System.Drawing.Point(13, 75);
            this.rdTarjeta.Name = "rdTarjeta";
            this.rdTarjeta.Size = new System.Drawing.Size(60, 17);
            this.rdTarjeta.TabIndex = 5;
            this.rdTarjeta.Text = "Tarjeta";
            this.rdTarjeta.UseVisualStyleBackColor = true;
            // 
            // stpSelNominaCFDIBindingNavigator
            // 
            this.stpSelNominaCFDIBindingNavigator.AddNewItem = null;
            this.stpSelNominaCFDIBindingNavigator.CountItem = null;
            this.stpSelNominaCFDIBindingNavigator.CountItemFormat = "de {0}";
            this.stpSelNominaCFDIBindingNavigator.DeleteItem = null;
            this.stpSelNominaCFDIBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.stpSelNominaCFDIBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.stpSelNominaCFDIBindingNavigator.MoveFirstItem = null;
            this.stpSelNominaCFDIBindingNavigator.MoveLastItem = null;
            this.stpSelNominaCFDIBindingNavigator.MoveNextItem = null;
            this.stpSelNominaCFDIBindingNavigator.MovePreviousItem = null;
            this.stpSelNominaCFDIBindingNavigator.Name = "stpSelNominaCFDIBindingNavigator";
            this.stpSelNominaCFDIBindingNavigator.PositionItem = null;
            this.stpSelNominaCFDIBindingNavigator.Size = new System.Drawing.Size(746, 25);
            this.stpSelNominaCFDIBindingNavigator.TabIndex = 19;
            this.stpSelNominaCFDIBindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::winAppSAIC.Properties.Resources.Salir24x24;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(49, 22);
            this.toolStripButton1.Text = "Salir";
            // 
            // frmxSolicitudAltaEmpleadosTesoreria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 415);
            this.Controls.Add(this.stpSelNominaCFDIBindingNavigator);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupControl4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(762, 454);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(762, 454);
            this.Name = "frmxSolicitudAltaEmpleadosTesoreria";
            this.Text = "Solicitudes";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridControlSolcitudes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelNominaCFDIBindingNavigator)).EndInit();
            this.stpSelNominaCFDIBindingNavigator.ResumeLayout(false);
            this.stpSelNominaCFDIBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.SimpleButton btnSolicitudAtendida;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraGrid.GridControl GridControlSolcitudes;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.RadioButton rdTenedoraSA;
        private System.Windows.Forms.RadioButton rdTenedorSC;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnSolicitudRechazada;
        private System.Windows.Forms.BindingNavigator stpSelNominaCFDIBindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.RadioButton rdTarjeta;
    }
}