namespace winAppSAIC.IMSS
{
    partial class frmxListadoSolicitudTramiteIMSS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmxListadoSolicitudTramiteIMSS));
            this.dbSAICBPODataSet = new winAppSAIC.dbSAICBPODataSet();
            this.vwListadoSolicitudTramiteIMSSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwListadoSolicitudTramiteIMSSTableAdapter = new winAppSAIC.dbSAICBPODataSetTableAdapters.vwListadoSolicitudTramiteIMSSTableAdapter();
            this.tableAdapterManager = new winAppSAIC.dbSAICBPODataSetTableAdapters.TableAdapterManager();
            this.vwListadoSolicitudTramiteIMSSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.vwListadoSolicitudTramiteIMSSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.btnModificacionInfoEmpleado = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnActualizarListado = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.vwListadoSolicitudTramiteIMSSGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdSolicitudTramiteIMSS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreComercialTenedora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescTipoMovimientoSolicitud = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreEmpleadoCompleto = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwListadoSolicitudTramiteIMSSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwListadoSolicitudTramiteIMSSBindingNavigator)).BeginInit();
            this.vwListadoSolicitudTramiteIMSSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vwListadoSolicitudTramiteIMSSGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dbSAICBPODataSet
            // 
            this.dbSAICBPODataSet.DataSetName = "dbSAICBPODataSet";
            this.dbSAICBPODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwListadoSolicitudTramiteIMSSBindingSource
            // 
            this.vwListadoSolicitudTramiteIMSSBindingSource.DataMember = "vwListadoSolicitudTramiteIMSS";
            this.vwListadoSolicitudTramiteIMSSBindingSource.DataSource = this.dbSAICBPODataSet;
            // 
            // vwListadoSolicitudTramiteIMSSTableAdapter
            // 
            this.vwListadoSolicitudTramiteIMSSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.FormatoLayoutBancoTableAdapter = null;
            this.tableAdapterManager.SolicitudCancelacionNominaTableAdapter = null;
            this.tableAdapterManager.TenedoraBancoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = winAppSAIC.dbSAICBPODataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // vwListadoSolicitudTramiteIMSSBindingNavigator
            // 
            this.vwListadoSolicitudTramiteIMSSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.vwListadoSolicitudTramiteIMSSBindingNavigator.BindingSource = this.vwListadoSolicitudTramiteIMSSBindingSource;
            this.vwListadoSolicitudTramiteIMSSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vwListadoSolicitudTramiteIMSSBindingNavigator.CountItemFormat = "de {0}";
            this.vwListadoSolicitudTramiteIMSSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.vwListadoSolicitudTramiteIMSSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.vwListadoSolicitudTramiteIMSSBindingNavigatorSaveItem,
            this.btnModificacionInfoEmpleado,
            this.toolStripSeparator2,
            this.btnActualizarListado,
            this.toolStripSeparator1,
            this.btnSalir});
            this.vwListadoSolicitudTramiteIMSSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.vwListadoSolicitudTramiteIMSSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vwListadoSolicitudTramiteIMSSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vwListadoSolicitudTramiteIMSSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vwListadoSolicitudTramiteIMSSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vwListadoSolicitudTramiteIMSSBindingNavigator.Name = "vwListadoSolicitudTramiteIMSSBindingNavigator";
            this.vwListadoSolicitudTramiteIMSSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vwListadoSolicitudTramiteIMSSBindingNavigator.Size = new System.Drawing.Size(984, 25);
            this.vwListadoSolicitudTramiteIMSSBindingNavigator.TabIndex = 0;
            this.vwListadoSolicitudTramiteIMSSBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Visible = false;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Visible = false;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // vwListadoSolicitudTramiteIMSSBindingNavigatorSaveItem
            // 
            this.vwListadoSolicitudTramiteIMSSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.vwListadoSolicitudTramiteIMSSBindingNavigatorSaveItem.Enabled = false;
            this.vwListadoSolicitudTramiteIMSSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("vwListadoSolicitudTramiteIMSSBindingNavigatorSaveItem.Image")));
            this.vwListadoSolicitudTramiteIMSSBindingNavigatorSaveItem.Name = "vwListadoSolicitudTramiteIMSSBindingNavigatorSaveItem";
            this.vwListadoSolicitudTramiteIMSSBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.vwListadoSolicitudTramiteIMSSBindingNavigatorSaveItem.Text = "Save Data";
            this.vwListadoSolicitudTramiteIMSSBindingNavigatorSaveItem.Visible = false;
            // 
            // btnModificacionInfoEmpleado
            // 
            this.btnModificacionInfoEmpleado.Image = global::winAppSAIC.Properties.Resources.people_icon16x16;
            this.btnModificacionInfoEmpleado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificacionInfoEmpleado.Name = "btnModificacionInfoEmpleado";
            this.btnModificacionInfoEmpleado.Size = new System.Drawing.Size(202, 22);
            this.btnModificacionInfoEmpleado.Text = "Modificar Información Empleado";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnActualizarListado
            // 
            this.btnActualizarListado.Image = global::winAppSAIC.Properties.Resources.Button_Refresh_icon24x24;
            this.btnActualizarListado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnActualizarListado.Name = "btnActualizarListado";
            this.btnActualizarListado.Size = new System.Drawing.Size(120, 22);
            this.btnActualizarListado.Text = "Actualizar Listado";
            this.btnActualizarListado.Click += new System.EventHandler(this.frmxListadoSolicitudTramiteIMSS_Load);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::winAppSAIC.Properties.Resources.Salir24x24;
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(49, 22);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // vwListadoSolicitudTramiteIMSSGridControl
            // 
            this.vwListadoSolicitudTramiteIMSSGridControl.DataSource = this.vwListadoSolicitudTramiteIMSSBindingSource;
            this.vwListadoSolicitudTramiteIMSSGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vwListadoSolicitudTramiteIMSSGridControl.Location = new System.Drawing.Point(0, 25);
            this.vwListadoSolicitudTramiteIMSSGridControl.MainView = this.gridView1;
            this.vwListadoSolicitudTramiteIMSSGridControl.Name = "vwListadoSolicitudTramiteIMSSGridControl";
            this.vwListadoSolicitudTramiteIMSSGridControl.Size = new System.Drawing.Size(984, 387);
            this.vwListadoSolicitudTramiteIMSSGridControl.TabIndex = 1;
            this.vwListadoSolicitudTramiteIMSSGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.vwListadoSolicitudTramiteIMSSGridControl.DoubleClick += new System.EventHandler(this.vwListadoSolicitudTramiteIMSSGridControl_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdSolicitudTramiteIMSS,
            this.colNombreComercialTenedora,
            this.colDescTipoMovimientoSolicitud,
            this.colIdEmpleado,
            this.colNombreEmpleadoCompleto});
            this.gridView1.GridControl = this.vwListadoSolicitudTramiteIMSSGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIdSolicitudTramiteIMSS
            // 
            this.colIdSolicitudTramiteIMSS.AppearanceCell.Options.UseTextOptions = true;
            this.colIdSolicitudTramiteIMSS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIdSolicitudTramiteIMSS.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdSolicitudTramiteIMSS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIdSolicitudTramiteIMSS.Caption = "No. Folio";
            this.colIdSolicitudTramiteIMSS.FieldName = "IdSolicitudTramiteIMSS";
            this.colIdSolicitudTramiteIMSS.Name = "colIdSolicitudTramiteIMSS";
            this.colIdSolicitudTramiteIMSS.Visible = true;
            this.colIdSolicitudTramiteIMSS.VisibleIndex = 0;
            this.colIdSolicitudTramiteIMSS.Width = 70;
            // 
            // colNombreComercialTenedora
            // 
            this.colNombreComercialTenedora.FieldName = "NombreComercialTenedora";
            this.colNombreComercialTenedora.Name = "colNombreComercialTenedora";
            this.colNombreComercialTenedora.Visible = true;
            this.colNombreComercialTenedora.VisibleIndex = 4;
            this.colNombreComercialTenedora.Width = 400;
            // 
            // colDescTipoMovimientoSolicitud
            // 
            this.colDescTipoMovimientoSolicitud.Caption = "Tipo Movimiento Solicitud";
            this.colDescTipoMovimientoSolicitud.FieldName = "DescTipoMovimientoSolicitud";
            this.colDescTipoMovimientoSolicitud.Name = "colDescTipoMovimientoSolicitud";
            this.colDescTipoMovimientoSolicitud.Visible = true;
            this.colDescTipoMovimientoSolicitud.VisibleIndex = 1;
            this.colDescTipoMovimientoSolicitud.Width = 180;
            // 
            // colIdEmpleado
            // 
            this.colIdEmpleado.Caption = "No. Empleado";
            this.colIdEmpleado.FieldName = "IdEmpleado";
            this.colIdEmpleado.Name = "colIdEmpleado";
            this.colIdEmpleado.Visible = true;
            this.colIdEmpleado.VisibleIndex = 2;
            // 
            // colNombreEmpleadoCompleto
            // 
            this.colNombreEmpleadoCompleto.Caption = "Nombre Empleado";
            this.colNombreEmpleadoCompleto.FieldName = "NombreEmpleadoCompleto";
            this.colNombreEmpleadoCompleto.Name = "colNombreEmpleadoCompleto";
            this.colNombreEmpleadoCompleto.Visible = true;
            this.colNombreEmpleadoCompleto.VisibleIndex = 3;
            this.colNombreEmpleadoCompleto.Width = 250;
            // 
            // frmxListadoSolicitudTramiteIMSS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 412);
            this.ControlBox = false;
            this.Controls.Add(this.vwListadoSolicitudTramiteIMSSGridControl);
            this.Controls.Add(this.vwListadoSolicitudTramiteIMSSBindingNavigator);
            this.Name = "frmxListadoSolicitudTramiteIMSS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado Solicitudes de Trámite IMSS";
            this.Load += new System.EventHandler(this.frmxListadoSolicitudTramiteIMSS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwListadoSolicitudTramiteIMSSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwListadoSolicitudTramiteIMSSBindingNavigator)).EndInit();
            this.vwListadoSolicitudTramiteIMSSBindingNavigator.ResumeLayout(false);
            this.vwListadoSolicitudTramiteIMSSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vwListadoSolicitudTramiteIMSSGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dbSAICBPODataSet dbSAICBPODataSet;
        private System.Windows.Forms.BindingSource vwListadoSolicitudTramiteIMSSBindingSource;
        private dbSAICBPODataSetTableAdapters.vwListadoSolicitudTramiteIMSSTableAdapter vwListadoSolicitudTramiteIMSSTableAdapter;
        private dbSAICBPODataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator vwListadoSolicitudTramiteIMSSBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton vwListadoSolicitudTramiteIMSSBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl vwListadoSolicitudTramiteIMSSGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSolicitudTramiteIMSS;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreComercialTenedora;
        private DevExpress.XtraGrid.Columns.GridColumn colDescTipoMovimientoSolicitud;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreEmpleadoCompleto;
        private System.Windows.Forms.ToolStripButton btnActualizarListado;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnModificacionInfoEmpleado;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}