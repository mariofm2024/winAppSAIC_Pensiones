namespace winAppSAIC.OperadoresM
{
    partial class frmxRechazarSolicitud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmxRechazarSolicitud));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtbxRPatronal = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtbxTenedoraSA = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtbxOperador = new DevExpress.XtraEditors.TextEdit();
            this.txtbxfechaAlta = new DevExpress.XtraEditors.TextEdit();
            this.txtbxSolicitud = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.controlEmpleados = new DevExpress.XtraGrid.GridControl();
            this.gridViewEmpleados = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gColumnIdEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gColumnPaterno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gColumnMaterno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gColumnNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gColumnRechazo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.btnRechazoCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAceptar = new DevExpress.XtraEditors.SimpleButton();
            this.queriesTableAdapter1 = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.QueriesTableAdapter();
            this.queriesTableAdapter2 = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.QueriesTableAdapter();
            this.stpSelNominaCFDIBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtbxRPatronal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbxTenedoraSA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbxOperador.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbxfechaAlta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbxSolicitud.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.controlEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelNominaCFDIBindingNavigator)).BeginInit();
            this.stpSelNominaCFDIBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtbxRPatronal);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtbxTenedoraSA);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.txtbxOperador);
            this.groupControl1.Controls.Add(this.txtbxfechaAlta);
            this.groupControl1.Controls.Add(this.txtbxSolicitud);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Location = new System.Drawing.Point(5, 31);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(574, 92);
            this.groupControl1.TabIndex = 23;
            this.groupControl1.Text = "Solicitud";
            // 
            // txtbxRPatronal
            // 
            this.txtbxRPatronal.Enabled = false;
            this.txtbxRPatronal.Location = new System.Drawing.Point(356, 49);
            this.txtbxRPatronal.Name = "txtbxRPatronal";
            this.txtbxRPatronal.Size = new System.Drawing.Size(213, 20);
            this.txtbxRPatronal.TabIndex = 16;
            // 
            // labelControl1
            // 
            this.labelControl1.AllowHtmlString = true;
            this.labelControl1.Location = new System.Drawing.Point(269, 52);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(87, 13);
            this.labelControl1.TabIndex = 15;
            this.labelControl1.Text = "Registro Patronal:";
            // 
            // txtbxTenedoraSA
            // 
            this.txtbxTenedoraSA.Enabled = false;
            this.txtbxTenedoraSA.Location = new System.Drawing.Point(356, 23);
            this.txtbxTenedoraSA.Name = "txtbxTenedoraSA";
            this.txtbxTenedoraSA.Size = new System.Drawing.Size(213, 20);
            this.txtbxTenedoraSA.TabIndex = 14;
            // 
            // labelControl8
            // 
            this.labelControl8.AllowHtmlString = true;
            this.labelControl8.Location = new System.Drawing.Point(287, 26);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(66, 13);
            this.labelControl8.TabIndex = 13;
            this.labelControl8.Text = "Tenedora SA:";
            // 
            // txtbxOperador
            // 
            this.txtbxOperador.Enabled = false;
            this.txtbxOperador.Location = new System.Drawing.Point(92, 66);
            this.txtbxOperador.Name = "txtbxOperador";
            this.txtbxOperador.Size = new System.Drawing.Size(171, 20);
            this.txtbxOperador.TabIndex = 12;
            // 
            // txtbxfechaAlta
            // 
            this.txtbxfechaAlta.Enabled = false;
            this.txtbxfechaAlta.Location = new System.Drawing.Point(92, 44);
            this.txtbxfechaAlta.Name = "txtbxfechaAlta";
            this.txtbxfechaAlta.Size = new System.Drawing.Size(171, 20);
            this.txtbxfechaAlta.TabIndex = 11;
            // 
            // txtbxSolicitud
            // 
            this.txtbxSolicitud.Enabled = false;
            this.txtbxSolicitud.Location = new System.Drawing.Point(92, 22);
            this.txtbxSolicitud.Name = "txtbxSolicitud";
            this.txtbxSolicitud.Size = new System.Drawing.Size(68, 20);
            this.txtbxSolicitud.TabIndex = 10;
            // 
            // labelControl4
            // 
            this.labelControl4.AllowHtmlString = true;
            this.labelControl4.Location = new System.Drawing.Point(11, 47);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(75, 13);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Fecha Solicitud:";
            // 
            // labelControl3
            // 
            this.labelControl3.AllowHtmlString = true;
            this.labelControl3.Location = new System.Drawing.Point(36, 68);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(50, 13);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Operador:";
            // 
            // labelControl2
            // 
            this.labelControl2.AllowHtmlString = true;
            this.labelControl2.Location = new System.Drawing.Point(43, 26);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(43, 13);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Solicitud:";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.controlEmpleados);
            this.groupControl2.Location = new System.Drawing.Point(5, 130);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(725, 222);
            this.groupControl2.TabIndex = 26;
            // 
            // controlEmpleados
            // 
            this.controlEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlEmpleados.Location = new System.Drawing.Point(2, 20);
            this.controlEmpleados.MainView = this.gridViewEmpleados;
            this.controlEmpleados.Name = "controlEmpleados";
            this.controlEmpleados.Size = new System.Drawing.Size(721, 200);
            this.controlEmpleados.TabIndex = 8;
            this.controlEmpleados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewEmpleados});
            // 
            // gridViewEmpleados
            // 
            this.gridViewEmpleados.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gColumnIdEmpleado,
            this.gColumnPaterno,
            this.gColumnMaterno,
            this.gColumnNombre,
            this.gColumnRechazo});
            this.gridViewEmpleados.CustomizationFormBounds = new System.Drawing.Rectangle(395, 363, 208, 170);
            this.gridViewEmpleados.FixedLineWidth = 1;
            this.gridViewEmpleados.GridControl = this.controlEmpleados;
            this.gridViewEmpleados.Name = "gridViewEmpleados";
            this.gridViewEmpleados.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewEmpleados.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewEmpleados.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplaceHideCurrentRow;
            this.gridViewEmpleados.OptionsBehavior.ImmediateUpdateRowPosition = false;
            this.gridViewEmpleados.OptionsBehavior.ReadOnly = true;
            this.gridViewEmpleados.OptionsEditForm.FormCaptionFormat = "Rechazo IMSS";
            this.gridViewEmpleados.OptionsEditForm.PopupEditFormWidth = 600;
            this.gridViewEmpleados.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewEmpleados.OptionsView.ColumnAutoWidth = false;
            this.gridViewEmpleados.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewEmpleados.OptionsView.ShowFooter = true;
            this.gridViewEmpleados.OptionsView.ShowGroupPanel = false;
            this.gridViewEmpleados.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridViewEmpleados_InitNewRow);
            // 
            // gColumnIdEmpleado
            // 
            this.gColumnIdEmpleado.Caption = "IdEmpleado";
            this.gColumnIdEmpleado.FieldName = "IdEmpleado";
            this.gColumnIdEmpleado.Name = "gColumnIdEmpleado";
            this.gColumnIdEmpleado.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.gColumnIdEmpleado.Visible = true;
            this.gColumnIdEmpleado.VisibleIndex = 0;
            // 
            // gColumnPaterno
            // 
            this.gColumnPaterno.Caption = "Apellido Paterno";
            this.gColumnPaterno.FieldName = "Apellido Paterno";
            this.gColumnPaterno.Name = "gColumnPaterno";
            this.gColumnPaterno.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.gColumnPaterno.Visible = true;
            this.gColumnPaterno.VisibleIndex = 1;
            this.gColumnPaterno.Width = 94;
            // 
            // gColumnMaterno
            // 
            this.gColumnMaterno.Caption = "Apellido Materno";
            this.gColumnMaterno.FieldName = "Apellido Materno";
            this.gColumnMaterno.Name = "gColumnMaterno";
            this.gColumnMaterno.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.gColumnMaterno.Visible = true;
            this.gColumnMaterno.VisibleIndex = 2;
            this.gColumnMaterno.Width = 99;
            // 
            // gColumnNombre
            // 
            this.gColumnNombre.Caption = "Nombre";
            this.gColumnNombre.FieldName = "Nombre";
            this.gColumnNombre.Name = "gColumnNombre";
            this.gColumnNombre.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.gColumnNombre.Visible = true;
            this.gColumnNombre.VisibleIndex = 3;
            this.gColumnNombre.Width = 104;
            // 
            // gColumnRechazo
            // 
            this.gColumnRechazo.Caption = "Rechazo";
            this.gColumnRechazo.FieldName = "Rechazo";
            this.gColumnRechazo.Name = "gColumnRechazo";
            this.gColumnRechazo.OptionsEditForm.UseEditorColRowSpan = false;
            this.gColumnRechazo.Visible = true;
            this.gColumnRechazo.VisibleIndex = 4;
            this.gColumnRechazo.Width = 466;
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.btnRechazoCancelar);
            this.groupControl4.Controls.Add(this.btnAceptar);
            this.groupControl4.Location = new System.Drawing.Point(585, 35);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(145, 92);
            this.groupControl4.TabIndex = 27;
            this.groupControl4.Text = "Rechazo";
            // 
            // btnRechazoCancelar
            // 
            this.btnRechazoCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRechazoCancelar.ImageOptions.Image")));
            this.btnRechazoCancelar.Location = new System.Drawing.Point(6, 31);
            this.btnRechazoCancelar.Name = "btnRechazoCancelar";
            this.btnRechazoCancelar.Size = new System.Drawing.Size(133, 23);
            this.btnRechazoCancelar.TabIndex = 26;
            this.btnRechazoCancelar.Text = "Cancelar";
            this.btnRechazoCancelar.Click += new System.EventHandler(this.btnRechazoCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.ImageOptions.Image = global::winAppSAIC.Properties.Resources.SelectAll16x16;
            this.btnAceptar.Location = new System.Drawing.Point(6, 57);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(133, 23);
            this.btnAceptar.TabIndex = 27;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
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
            this.stpSelNominaCFDIBindingNavigator.Size = new System.Drawing.Size(738, 25);
            this.stpSelNominaCFDIBindingNavigator.TabIndex = 28;
            this.stpSelNominaCFDIBindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::winAppSAIC.Properties.Resources.Salir24x24;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(49, 22);
            this.toolStripButton1.Text = "Salir";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // frmxRechazarSolicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 358);
            this.Controls.Add(this.stpSelNominaCFDIBindingNavigator);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(754, 397);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(754, 397);
            this.Name = "frmxRechazarSolicitud";
            this.Text = "Rechazar Solicitud";
            this.Load += new System.EventHandler(this.frmxRechazarSolicitud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtbxRPatronal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbxTenedoraSA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbxOperador.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbxfechaAlta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbxSolicitud.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.controlEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stpSelNominaCFDIBindingNavigator)).EndInit();
            this.stpSelNominaCFDIBindingNavigator.ResumeLayout(false);
            this.stpSelNominaCFDIBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtbxRPatronal;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtbxTenedoraSA;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtbxOperador;
        private DevExpress.XtraEditors.TextEdit txtbxfechaAlta;
        private DevExpress.XtraEditors.TextEdit txtbxSolicitud;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl controlEmpleados;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEmpleados;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.SimpleButton btnRechazoCancelar;
        private DevExpress.XtraEditors.SimpleButton btnAceptar;
        private DevExpress.XtraGrid.Columns.GridColumn gColumnIdEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn gColumnPaterno;
        private DevExpress.XtraGrid.Columns.GridColumn gColumnMaterno;
        private DevExpress.XtraGrid.Columns.GridColumn gColumnNombre;
        private DevExpress.XtraGrid.Columns.GridColumn gColumnRechazo;
        private dbSAICBPOCatalogosDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private dbSAICBPOCatalogosDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter2;
        private System.Windows.Forms.BindingNavigator stpSelNominaCFDIBindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}