namespace winAppSAIC.Contablidad
{
    partial class frmxMonitoreoSolicitudCancelacionNominas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmxMonitoreoSolicitudCancelacionNominas));
            this.dbSAICBPODataSet = new winAppSAIC.dbSAICBPODataSet();
            this.vwInfoDetalleSolicitudCancelacionNominaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwInfoDetalleSolicitudCancelacionNominaTableAdapter = new winAppSAIC.dbSAICBPODataSetTableAdapters.vwInfoDetalleSolicitudCancelacionNominaTableAdapter();
            this.tableAdapterManager = new winAppSAIC.dbSAICBPODataSetTableAdapters.TableAdapterManager();
            this.vwInfoDetalleSolicitudCancelacionNominaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.vwInfoDetalleSolicitudCancelacionNominaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.vwInfoDetalleSolicitudCancelacionNominaGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdLoteCargaNomina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreComercialTenedora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreComercialCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPeriodoPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoNomina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOperador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMotivoCancelacion = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwInfoDetalleSolicitudCancelacionNominaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwInfoDetalleSolicitudCancelacionNominaBindingNavigator)).BeginInit();
            this.vwInfoDetalleSolicitudCancelacionNominaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vwInfoDetalleSolicitudCancelacionNominaGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dbSAICBPODataSet
            // 
            this.dbSAICBPODataSet.DataSetName = "dbSAICBPODataSet";
            this.dbSAICBPODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwInfoDetalleSolicitudCancelacionNominaBindingSource
            // 
            this.vwInfoDetalleSolicitudCancelacionNominaBindingSource.DataMember = "vwInfoDetalleSolicitudCancelacionNomina";
            this.vwInfoDetalleSolicitudCancelacionNominaBindingSource.DataSource = this.dbSAICBPODataSet;
            // 
            // vwInfoDetalleSolicitudCancelacionNominaTableAdapter
            // 
            this.vwInfoDetalleSolicitudCancelacionNominaTableAdapter.ClearBeforeFill = true;
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
            // vwInfoDetalleSolicitudCancelacionNominaBindingNavigator
            // 
            this.vwInfoDetalleSolicitudCancelacionNominaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.vwInfoDetalleSolicitudCancelacionNominaBindingNavigator.BindingSource = this.vwInfoDetalleSolicitudCancelacionNominaBindingSource;
            this.vwInfoDetalleSolicitudCancelacionNominaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vwInfoDetalleSolicitudCancelacionNominaBindingNavigator.CountItemFormat = "de {0}";
            this.vwInfoDetalleSolicitudCancelacionNominaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.vwInfoDetalleSolicitudCancelacionNominaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.vwInfoDetalleSolicitudCancelacionNominaBindingNavigatorSaveItem,
            this.btnSalir});
            this.vwInfoDetalleSolicitudCancelacionNominaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.vwInfoDetalleSolicitudCancelacionNominaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vwInfoDetalleSolicitudCancelacionNominaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vwInfoDetalleSolicitudCancelacionNominaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vwInfoDetalleSolicitudCancelacionNominaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vwInfoDetalleSolicitudCancelacionNominaBindingNavigator.Name = "vwInfoDetalleSolicitudCancelacionNominaBindingNavigator";
            this.vwInfoDetalleSolicitudCancelacionNominaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vwInfoDetalleSolicitudCancelacionNominaBindingNavigator.Size = new System.Drawing.Size(1008, 25);
            this.vwInfoDetalleSolicitudCancelacionNominaBindingNavigator.TabIndex = 0;
            this.vwInfoDetalleSolicitudCancelacionNominaBindingNavigator.Text = "bindingNavigator1";
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
            // vwInfoDetalleSolicitudCancelacionNominaBindingNavigatorSaveItem
            // 
            this.vwInfoDetalleSolicitudCancelacionNominaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.vwInfoDetalleSolicitudCancelacionNominaBindingNavigatorSaveItem.Enabled = false;
            this.vwInfoDetalleSolicitudCancelacionNominaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("vwInfoDetalleSolicitudCancelacionNominaBindingNavigatorSaveItem.Image")));
            this.vwInfoDetalleSolicitudCancelacionNominaBindingNavigatorSaveItem.Name = "vwInfoDetalleSolicitudCancelacionNominaBindingNavigatorSaveItem";
            this.vwInfoDetalleSolicitudCancelacionNominaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.vwInfoDetalleSolicitudCancelacionNominaBindingNavigatorSaveItem.Text = "Save Data";
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
            // vwInfoDetalleSolicitudCancelacionNominaGridControl
            // 
            this.vwInfoDetalleSolicitudCancelacionNominaGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.vwInfoDetalleSolicitudCancelacionNominaGridControl.DataSource = this.vwInfoDetalleSolicitudCancelacionNominaBindingSource;
            this.vwInfoDetalleSolicitudCancelacionNominaGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vwInfoDetalleSolicitudCancelacionNominaGridControl.Location = new System.Drawing.Point(0, 25);
            this.vwInfoDetalleSolicitudCancelacionNominaGridControl.MainView = this.gridView1;
            this.vwInfoDetalleSolicitudCancelacionNominaGridControl.Name = "vwInfoDetalleSolicitudCancelacionNominaGridControl";
            this.vwInfoDetalleSolicitudCancelacionNominaGridControl.Size = new System.Drawing.Size(1008, 387);
            this.vwInfoDetalleSolicitudCancelacionNominaGridControl.TabIndex = 1;
            this.vwInfoDetalleSolicitudCancelacionNominaGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdLoteCargaNomina,
            this.colNombreComercialTenedora,
            this.colNombreComercialCliente,
            this.colPeriodoPago,
            this.colTipoNomina,
            this.colOperador,
            this.colMotivoCancelacion});
            this.gridView1.GridControl = this.vwInfoDetalleSolicitudCancelacionNominaGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            // 
            // colIdLoteCargaNomina
            // 
            this.colIdLoteCargaNomina.AppearanceCell.Options.UseTextOptions = true;
            this.colIdLoteCargaNomina.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIdLoteCargaNomina.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdLoteCargaNomina.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIdLoteCargaNomina.Caption = "Lote Nómina";
            this.colIdLoteCargaNomina.FieldName = "IdLoteCargaNomina";
            this.colIdLoteCargaNomina.Name = "colIdLoteCargaNomina";
            this.colIdLoteCargaNomina.Visible = true;
            this.colIdLoteCargaNomina.VisibleIndex = 0;
            // 
            // colNombreComercialTenedora
            // 
            this.colNombreComercialTenedora.Caption = "Tenedora";
            this.colNombreComercialTenedora.FieldName = "NombreComercialTenedora";
            this.colNombreComercialTenedora.Name = "colNombreComercialTenedora";
            this.colNombreComercialTenedora.Visible = true;
            this.colNombreComercialTenedora.VisibleIndex = 1;
            this.colNombreComercialTenedora.Width = 250;
            // 
            // colNombreComercialCliente
            // 
            this.colNombreComercialCliente.Caption = "Cliente";
            this.colNombreComercialCliente.FieldName = "NombreComercialCliente";
            this.colNombreComercialCliente.Name = "colNombreComercialCliente";
            this.colNombreComercialCliente.Visible = true;
            this.colNombreComercialCliente.VisibleIndex = 2;
            this.colNombreComercialCliente.Width = 250;
            // 
            // colPeriodoPago
            // 
            this.colPeriodoPago.FieldName = "PeriodoPago";
            this.colPeriodoPago.Name = "colPeriodoPago";
            this.colPeriodoPago.OptionsColumn.ReadOnly = true;
            this.colPeriodoPago.Visible = true;
            this.colPeriodoPago.VisibleIndex = 3;
            this.colPeriodoPago.Width = 150;
            // 
            // colTipoNomina
            // 
            this.colTipoNomina.Caption = "Tipo Nómina";
            this.colTipoNomina.FieldName = "TipoNomina";
            this.colTipoNomina.Name = "colTipoNomina";
            this.colTipoNomina.Visible = true;
            this.colTipoNomina.VisibleIndex = 4;
            this.colTipoNomina.Width = 100;
            // 
            // colOperador
            // 
            this.colOperador.FieldName = "Operador";
            this.colOperador.Name = "colOperador";
            this.colOperador.Visible = true;
            this.colOperador.VisibleIndex = 5;
            this.colOperador.Width = 200;
            // 
            // colMotivoCancelacion
            // 
            this.colMotivoCancelacion.Caption = "Motivo Cancelación";
            this.colMotivoCancelacion.FieldName = "MotivoCancelacion";
            this.colMotivoCancelacion.Name = "colMotivoCancelacion";
            this.colMotivoCancelacion.Visible = true;
            this.colMotivoCancelacion.VisibleIndex = 6;
            this.colMotivoCancelacion.Width = 200;
            // 
            // frmxMonitoreoSolicitudCancelacionNominas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 412);
            this.ControlBox = false;
            this.Controls.Add(this.vwInfoDetalleSolicitudCancelacionNominaGridControl);
            this.Controls.Add(this.vwInfoDetalleSolicitudCancelacionNominaBindingNavigator);
            this.Name = "frmxMonitoreoSolicitudCancelacionNominas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monitoreo Solicitud Cancelación Nóminas";
            this.Load += new System.EventHandler(this.frmxMonitoreoSolicitudCancelacionNominas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwInfoDetalleSolicitudCancelacionNominaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwInfoDetalleSolicitudCancelacionNominaBindingNavigator)).EndInit();
            this.vwInfoDetalleSolicitudCancelacionNominaBindingNavigator.ResumeLayout(false);
            this.vwInfoDetalleSolicitudCancelacionNominaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vwInfoDetalleSolicitudCancelacionNominaGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dbSAICBPODataSet dbSAICBPODataSet;
        private System.Windows.Forms.BindingSource vwInfoDetalleSolicitudCancelacionNominaBindingSource;
        private dbSAICBPODataSetTableAdapters.vwInfoDetalleSolicitudCancelacionNominaTableAdapter vwInfoDetalleSolicitudCancelacionNominaTableAdapter;
        private dbSAICBPODataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator vwInfoDetalleSolicitudCancelacionNominaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton vwInfoDetalleSolicitudCancelacionNominaBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private DevExpress.XtraGrid.GridControl vwInfoDetalleSolicitudCancelacionNominaGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdLoteCargaNomina;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreComercialTenedora;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreComercialCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colPeriodoPago;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoNomina;
        private DevExpress.XtraGrid.Columns.GridColumn colOperador;
        private DevExpress.XtraGrid.Columns.GridColumn colMotivoCancelacion;


    }
}