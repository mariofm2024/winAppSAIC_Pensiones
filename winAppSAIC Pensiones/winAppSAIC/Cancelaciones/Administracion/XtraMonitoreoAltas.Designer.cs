namespace winAppSAIC.Administracion
{
    partial class XtraMonitoreoAltas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraMonitoreoAltas));
            this.cboFolioLoteCargaNomina = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenedora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOperador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTenedora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRFC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblFolio = new DevExpress.XtraEditors.LabelControl();
            this.toolStripbtnSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExportar = new System.Windows.Forms.ToolStripButton();
            this.stpSelNominaCFDIBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.GridControlSolicitudes = new DevExpress.XtraGrid.GridControl();
            this.gridViewSolicitudes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.cboFolioLoteCargaNomina.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelNominaCFDIBindingNavigator)).BeginInit();
            this.stpSelNominaCFDIBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlSolicitudes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSolicitudes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cboFolioLoteCargaNomina
            // 
            this.cboFolioLoteCargaNomina.EditValue = "";
            this.cboFolioLoteCargaNomina.Location = new System.Drawing.Point(72, 35);
            this.cboFolioLoteCargaNomina.Name = "cboFolioLoteCargaNomina";
            this.cboFolioLoteCargaNomina.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
            this.cboFolioLoteCargaNomina.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboFolioLoteCargaNomina.Properties.DisplayMember = "FolioLoteCargaNomina";
            this.cboFolioLoteCargaNomina.Properties.NullText = "";
            this.cboFolioLoteCargaNomina.Properties.ValueMember = "IdLoteCargaNomina";
            this.cboFolioLoteCargaNomina.Properties.View = this.gridLookUpEdit1View;
            this.cboFolioLoteCargaNomina.Size = new System.Drawing.Size(244, 20);
            this.cboFolioLoteCargaNomina.TabIndex = 24;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn3,
            this.colTenedora,
            this.colCliente,
            this.colOperador,
            this.colIdTenedora,
            this.colRFC});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsCustomization.AllowGroup = false;
            this.gridLookUpEdit1View.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridLookUpEdit1View.OptionsCustomization.AllowSort = false;
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            this.gridLookUpEdit1View.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn2, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "No. Lote";
            this.gridColumn2.FieldName = "IdLoteCargaNomina";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 22;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Folio Lote Carga Nómina";
            this.gridColumn3.FieldName = "FolioLoteCargaNomina";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 41;
            // 
            // colTenedora
            // 
            this.colTenedora.Caption = "Tenedora";
            this.colTenedora.FieldName = "Tenedora";
            this.colTenedora.Name = "colTenedora";
            this.colTenedora.Visible = true;
            this.colTenedora.VisibleIndex = 2;
            this.colTenedora.Width = 114;
            // 
            // colCliente
            // 
            this.colCliente.Caption = "Cliente";
            this.colCliente.FieldName = "Cliente";
            this.colCliente.Name = "colCliente";
            this.colCliente.Visible = true;
            this.colCliente.VisibleIndex = 3;
            this.colCliente.Width = 173;
            // 
            // colOperador
            // 
            this.colOperador.FieldName = "Operador";
            this.colOperador.Name = "colOperador";
            this.colOperador.Visible = true;
            this.colOperador.VisibleIndex = 4;
            this.colOperador.Width = 150;
            // 
            // colIdTenedora
            // 
            this.colIdTenedora.FieldName = "IdTenedora";
            this.colIdTenedora.Name = "colIdTenedora";
            // 
            // colRFC
            // 
            this.colRFC.FieldName = "RFC";
            this.colRFC.Name = "colRFC";
            // 
            // lblFolio
            // 
            this.lblFolio.Location = new System.Drawing.Point(12, 38);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(54, 13);
            this.lblFolio.TabIndex = 25;
            this.lblFolio.Text = "Solicitudes:";
            // 
            // toolStripbtnSalir
            // 
            this.toolStripbtnSalir.Image = global::winAppSAIC.Properties.Resources.Salir24x24;
            this.toolStripbtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripbtnSalir.Name = "toolStripbtnSalir";
            this.toolStripbtnSalir.Size = new System.Drawing.Size(49, 22);
            this.toolStripbtnSalir.Text = "Salir";
            this.toolStripbtnSalir.Click += new System.EventHandler(this.toolStripbtnSalir_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnExportar
            // 
            this.btnExportar.Enabled = false;
            this.btnExportar.Image = global::winAppSAIC.Properties.Resources.if_excel_836884;
            this.btnExportar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(131, 22);
            this.btnExportar.Text = "Exportar Empleados";
            // 
            // stpSelNominaCFDIBindingNavigator
            // 
            this.stpSelNominaCFDIBindingNavigator.AddNewItem = null;
            this.stpSelNominaCFDIBindingNavigator.CountItem = null;
            this.stpSelNominaCFDIBindingNavigator.CountItemFormat = "de {0}";
            this.stpSelNominaCFDIBindingNavigator.DeleteItem = null;
            this.stpSelNominaCFDIBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripbtnSalir,
            this.toolStripSeparator1,
            this.btnExportar});
            this.stpSelNominaCFDIBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.stpSelNominaCFDIBindingNavigator.MoveFirstItem = null;
            this.stpSelNominaCFDIBindingNavigator.MoveLastItem = null;
            this.stpSelNominaCFDIBindingNavigator.MoveNextItem = null;
            this.stpSelNominaCFDIBindingNavigator.MovePreviousItem = null;
            this.stpSelNominaCFDIBindingNavigator.Name = "stpSelNominaCFDIBindingNavigator";
            this.stpSelNominaCFDIBindingNavigator.PositionItem = null;
            this.stpSelNominaCFDIBindingNavigator.Size = new System.Drawing.Size(985, 25);
            this.stpSelNominaCFDIBindingNavigator.TabIndex = 23;
            this.stpSelNominaCFDIBindingNavigator.Text = "bindingNavigator1";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.GridControlSolicitudes);
            this.groupControl2.Location = new System.Drawing.Point(5, 247);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(973, 145);
            this.groupControl2.TabIndex = 36;
            // 
            // GridControlSolicitudes
            // 
            this.GridControlSolicitudes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridControlSolicitudes.Location = new System.Drawing.Point(2, 20);
            this.GridControlSolicitudes.MainView = this.gridViewSolicitudes;
            this.GridControlSolicitudes.Name = "GridControlSolicitudes";
            this.GridControlSolicitudes.Size = new System.Drawing.Size(969, 123);
            this.GridControlSolicitudes.TabIndex = 8;
            this.GridControlSolicitudes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSolicitudes});
            // 
            // gridViewSolicitudes
            // 
            this.gridViewSolicitudes.CustomizationFormBounds = new System.Drawing.Rectangle(395, 363, 208, 170);
            this.gridViewSolicitudes.FixedLineWidth = 1;
            this.gridViewSolicitudes.GridControl = this.GridControlSolicitudes;
            this.gridViewSolicitudes.Name = "gridViewSolicitudes";
            this.gridViewSolicitudes.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewSolicitudes.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewSolicitudes.OptionsBehavior.ReadOnly = true;
            this.gridViewSolicitudes.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewSolicitudes.OptionsView.ColumnAutoWidth = false;
            this.gridViewSolicitudes.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewSolicitudes.OptionsView.ShowFooter = true;
            this.gridViewSolicitudes.OptionsView.ShowGroupPanel = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(153)))), ((int)(((byte)(205)))));
            this.panel1.Location = new System.Drawing.Point(0, 147);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(985, 31);
            this.panel1.TabIndex = 37;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Location = new System.Drawing.Point(622, 38);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(354, 103);
            this.groupControl1.TabIndex = 37;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 20);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(350, 81);
            this.gridControl1.TabIndex = 8;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(395, 363, 208, 170);
            this.gridView1.FixedLineWidth = 1;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // XtraMonitoreoAltas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 404);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.lblFolio);
            this.Controls.Add(this.cboFolioLoteCargaNomina);
            this.Controls.Add(this.stpSelNominaCFDIBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "XtraMonitoreoAltas";
            this.Text = "Mnitoreo de Solicitudes";
            ((System.ComponentModel.ISupportInitialize)(this.cboFolioLoteCargaNomina.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelNominaCFDIBindingNavigator)).EndInit();
            this.stpSelNominaCFDIBindingNavigator.ResumeLayout(false);
            this.stpSelNominaCFDIBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridControlSolicitudes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSolicitudes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.GridLookUpEdit cboFolioLoteCargaNomina;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn colTenedora;
        private DevExpress.XtraGrid.Columns.GridColumn colCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colOperador;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTenedora;
        private DevExpress.XtraGrid.Columns.GridColumn colRFC;
        private DevExpress.XtraEditors.LabelControl lblFolio;
        private System.Windows.Forms.ToolStripButton toolStripbtnSalir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnExportar;
        private System.Windows.Forms.BindingNavigator stpSelNominaCFDIBindingNavigator;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl GridControlSolicitudes;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSolicitudes;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}