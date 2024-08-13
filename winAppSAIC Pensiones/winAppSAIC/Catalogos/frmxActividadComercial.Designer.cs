namespace winAppSAIC.Catalogos
{
    partial class frmxActividadComercial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmxActividadComercial));
            this.dbSAIC_Catalogos = new winAppSAIC.Catalogos.dbSAIC_Catalogos();
            this.actividadComercialBindingSource = new System.Windows.Forms.BindingSource();
            this.actividadComercialTableAdapter = new winAppSAIC.Catalogos.dbSAIC_CatalogosTableAdapters.ActividadComercialTableAdapter();
            this.tableAdapterManager = new winAppSAIC.Catalogos.dbSAIC_CatalogosTableAdapters.TableAdapterManager();
            this.actividadComercialBindingNavigator = new System.Windows.Forms.BindingNavigator();
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
            this.actividadComercialBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.actividadComercialGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdActividadComercial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescActividadComercial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSector = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryLookUpEditIdSector = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.sectorBindingSource = new System.Windows.Forms.BindingSource();
            this.barManager1 = new DevExpress.XtraBars.BarManager();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.sectorTableAdapter = new winAppSAIC.Catalogos.dbSAIC_CatalogosTableAdapters.SectorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAIC_Catalogos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadComercialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadComercialBindingNavigator)).BeginInit();
            this.actividadComercialBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actividadComercialGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryLookUpEditIdSector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // dbSAIC_Catalogos
            // 
            this.dbSAIC_Catalogos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // actividadComercialBindingSource
            // 
            this.actividadComercialBindingSource.DataMember = "ActividadComercial";
            this.actividadComercialBindingSource.DataSource = this.dbSAIC_Catalogos;
            // 
            // actividadComercialTableAdapter
            // 
            this.actividadComercialTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActividadComercialTableAdapter = this.actividadComercialTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.ProductoTableAdapter = null;
            this.tableAdapterManager.PromotorTableAdapter = null;
            this.tableAdapterManager.SectorTableAdapter = null;
            this.tableAdapterManager.stpSelPaisTableAdapter = null;
            this.tableAdapterManager.TipoClienteProveedorTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = winAppSAIC.Catalogos.dbSAIC_CatalogosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // actividadComercialBindingNavigator
            // 
            this.actividadComercialBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.actividadComercialBindingNavigator.BindingSource = this.actividadComercialBindingSource;
            this.actividadComercialBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.actividadComercialBindingNavigator.CountItemFormat = "de {0}";
            this.actividadComercialBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.actividadComercialBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.actividadComercialBindingNavigatorSaveItem,
            this.toolStripSeparator1,
            this.btnSalir});
            this.actividadComercialBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.actividadComercialBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.actividadComercialBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.actividadComercialBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.actividadComercialBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.actividadComercialBindingNavigator.Name = "actividadComercialBindingNavigator";
            this.actividadComercialBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.actividadComercialBindingNavigator.Size = new System.Drawing.Size(784, 25);
            this.actividadComercialBindingNavigator.TabIndex = 0;
            this.actividadComercialBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(62, 22);
            this.bindingNavigatorAddNewItem.Text = "Nuevo";
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
            this.bindingNavigatorDeleteItem.Image = global::winAppSAIC.Properties.Resources.Borrar1;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(59, 22);
            this.bindingNavigatorDeleteItem.Text = "Borrar";
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
            // actividadComercialBindingNavigatorSaveItem
            // 
            this.actividadComercialBindingNavigatorSaveItem.Image = global::winAppSAIC.Properties.Resources.saveHS;
            this.actividadComercialBindingNavigatorSaveItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.actividadComercialBindingNavigatorSaveItem.Name = "actividadComercialBindingNavigatorSaveItem";
            this.actividadComercialBindingNavigatorSaveItem.Size = new System.Drawing.Size(69, 22);
            this.actividadComercialBindingNavigatorSaveItem.Text = "Guardar";
            this.actividadComercialBindingNavigatorSaveItem.Click += new System.EventHandler(this.actividadComercialBindingNavigatorSaveItem_Click);
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
            // actividadComercialGridControl
            // 
            this.actividadComercialGridControl.DataSource = this.actividadComercialBindingSource;
            this.actividadComercialGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actividadComercialGridControl.Location = new System.Drawing.Point(0, 25);
            this.actividadComercialGridControl.MainView = this.gridView1;
            this.actividadComercialGridControl.Name = "actividadComercialGridControl";
            this.actividadComercialGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryLookUpEditIdSector});
            this.actividadComercialGridControl.Size = new System.Drawing.Size(784, 314);
            this.actividadComercialGridControl.TabIndex = 1;
            this.actividadComercialGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdActividadComercial,
            this.colDescActividadComercial,
            this.colIdSector});
            this.gridView1.GridControl = this.actividadComercialGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIdActividadComercial
            // 
            this.colIdActividadComercial.FieldName = "IdActividadComercial";
            this.colIdActividadComercial.Name = "colIdActividadComercial";
            // 
            // colDescActividadComercial
            // 
            this.colDescActividadComercial.Caption = "Nombre Actividad Comercial";
            this.colDescActividadComercial.FieldName = "DescActividadComercial";
            this.colDescActividadComercial.Name = "colDescActividadComercial";
            this.colDescActividadComercial.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDescActividadComercial.Visible = true;
            this.colDescActividadComercial.VisibleIndex = 0;
            this.colDescActividadComercial.Width = 805;
            // 
            // colIdSector
            // 
            this.colIdSector.Caption = "Nombre del Sector";
            this.colIdSector.ColumnEdit = this.repositoryLookUpEditIdSector;
            this.colIdSector.FieldName = "IdSector";
            this.colIdSector.Name = "colIdSector";
            this.colIdSector.Visible = true;
            this.colIdSector.VisibleIndex = 1;
            this.colIdSector.Width = 212;
            // 
            // repositoryLookUpEditIdSector
            // 
            this.repositoryLookUpEditIdSector.AutoHeight = false;
            this.repositoryLookUpEditIdSector.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryLookUpEditIdSector.DataSource = this.sectorBindingSource;
            this.repositoryLookUpEditIdSector.DisplayMember = "DescSector";
            this.repositoryLookUpEditIdSector.Name = "repositoryLookUpEditIdSector";
            this.repositoryLookUpEditIdSector.ValueMember = "IdSector";
            // 
            // sectorBindingSource
            // 
            this.sectorBindingSource.DataMember = "Sector";
            this.sectorBindingSource.DataSource = this.dbSAIC_Catalogos;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.MaxItemId = 0;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(784, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 339);
            this.barDockControlBottom.Size = new System.Drawing.Size(784, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 339);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(784, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 339);
            // 
            // sectorTableAdapter
            // 
            this.sectorTableAdapter.ClearBeforeFill = true;
            // 
            // frmxActividadComercial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 362);
            this.ControlBox = false;
            this.Controls.Add(this.actividadComercialGridControl);
            this.Controls.Add(this.actividadComercialBindingNavigator);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmxActividadComercial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Actividades Comerciales";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmxActividadComercial_FormClosing);
            this.Load += new System.EventHandler(this.frmxActividadComercial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbSAIC_Catalogos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadComercialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadComercialBindingNavigator)).EndInit();
            this.actividadComercialBindingNavigator.ResumeLayout(false);
            this.actividadComercialBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actividadComercialGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryLookUpEditIdSector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dbSAIC_Catalogos dbSAIC_Catalogos;
        private System.Windows.Forms.BindingSource actividadComercialBindingSource;
        private dbSAIC_CatalogosTableAdapters.ActividadComercialTableAdapter actividadComercialTableAdapter;
        private dbSAIC_CatalogosTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator actividadComercialBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton actividadComercialBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl actividadComercialGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdActividadComercial;
        private DevExpress.XtraGrid.Columns.GridColumn colDescActividadComercial;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSector;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryLookUpEditIdSector;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource sectorBindingSource;
        private dbSAIC_CatalogosTableAdapters.SectorTableAdapter sectorTableAdapter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnSalir;
    }
}