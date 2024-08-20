namespace winAppSAIC.Catalogos
{
    partial class frmxSolicitudesPagoProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmxSolicitudesPagoProveedores));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btnFacturar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.gpoSol = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbControlRelac = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView10 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFechaSolicitud = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.gpoSinLotesPago = new System.Windows.Forms.GroupBox();
            this.gridLookUpEdit1 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtImporte = new DevExpress.XtraEditors.SpinEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gridLookUpEdit2 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlBase = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnNuevo = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardarDetalle = new DevExpress.XtraEditors.SimpleButton();
            this.toolStrip1.SuspendLayout();
            this.gpoSol.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbControlRelac.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            this.gpoSinLotesPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImporte.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlBase)).BeginInit();
            this.layoutControlBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.btnFacturar,
            this.toolStripButton3,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1835, 32);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Black;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(73, 29);
            this.toolStripButton1.Text = "Salir";
            // 
            // btnFacturar
            // 
            this.btnFacturar.Image = global::winAppSAIC.Properties.Resources.folder_add_256_icon_icons1;
            this.btnFacturar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(154, 29);
            this.btnFacturar.Text = "Crear Solicitud";
            this.btnFacturar.ToolTipText = "Nueva solicitud";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = global::winAppSAIC.Properties.Resources.folder_add_256_icon_icons1;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(186, 29);
            this.toolStripButton3.Text = "Consultar solicitud";
            this.toolStripButton3.ToolTipText = "Consultar Solicitud";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(28, 29);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // gpoSol
            // 
            this.gpoSol.Controls.Add(this.cbControlRelac);
            this.gpoSol.Controls.Add(this.label2);
            this.gpoSol.Controls.Add(this.txtDescripcion);
            this.gpoSol.Controls.Add(this.label1);
            this.gpoSol.Controls.Add(this.dtFechaSolicitud);
            this.gpoSol.Controls.Add(this.label4);
            this.gpoSol.Location = new System.Drawing.Point(13, 74);
            this.gpoSol.Name = "gpoSol";
            this.gpoSol.Size = new System.Drawing.Size(997, 112);
            this.gpoSol.TabIndex = 123;
            this.gpoSol.TabStop = false;
            this.gpoSol.Text = "Solicitud de pago a proveedores";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Location = new System.Drawing.Point(1103, 536);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 264);
            this.groupBox1.TabIndex = 125;
            this.groupBox1.TabStop = false;
            // 
            // cbControlRelac
            // 
            this.cbControlRelac.Location = new System.Drawing.Point(323, 52);
            this.cbControlRelac.Margin = new System.Windows.Forms.Padding(4);
            this.cbControlRelac.Name = "cbControlRelac";
            this.cbControlRelac.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.cbControlRelac.Properties.Appearance.Options.UseBackColor = true;
            this.cbControlRelac.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbControlRelac.Properties.DisplayMember = "IdControlOperaciones";
            this.cbControlRelac.Properties.NullText = "";
            this.cbControlRelac.Properties.PopupSizeable = false;
            this.cbControlRelac.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbControlRelac.Properties.ValueMember = "IdControlOperaciones";
            this.cbControlRelac.Properties.View = this.gridView10;
            this.cbControlRelac.Size = new System.Drawing.Size(305, 26);
            this.cbControlRelac.TabIndex = 124;
            this.cbControlRelac.Tag = "Cliente";
            // 
            // gridView10
            // 
            this.gridView10.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView10.Name = "gridView10";
            this.gridView10.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView10.OptionsView.ShowGroupPanel = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 123;
            this.label2.Text = "Área:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(116, 52);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtDescripcion.Properties.Appearance.Options.UseBackColor = true;
            this.txtDescripcion.Size = new System.Drawing.Size(101, 26);
            this.txtDescripcion.TabIndex = 122;
            this.txtDescripcion.TabStop = false;
            this.txtDescripcion.Tag = "Descripción";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 121;
            this.label1.Text = "No. Solicitud:";
            // 
            // dtFechaSolicitud
            // 
            this.dtFechaSolicitud.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaSolicitud.Location = new System.Drawing.Point(818, 49);
            this.dtFechaSolicitud.Margin = new System.Windows.Forms.Padding(4);
            this.dtFechaSolicitud.Name = "dtFechaSolicitud";
            this.dtFechaSolicitud.Size = new System.Drawing.Size(140, 26);
            this.dtFechaSolicitud.TabIndex = 119;
            this.dtFechaSolicitud.Tag = "Fecha de solicitud";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(691, 54);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 120;
            this.label4.Text = "Fecha solicitud:";
            // 
            // gpoSinLotesPago
            // 
            this.gpoSinLotesPago.Controls.Add(this.btnGuardarDetalle);
            this.gpoSinLotesPago.Controls.Add(this.gridLookUpEdit1);
            this.gpoSinLotesPago.Controls.Add(this.txtImporte);
            this.gpoSinLotesPago.Controls.Add(this.label3);
            this.gpoSinLotesPago.Controls.Add(this.label6);
            this.gpoSinLotesPago.Controls.Add(this.label5);
            this.gpoSinLotesPago.Controls.Add(this.gridLookUpEdit2);
            this.gpoSinLotesPago.Location = new System.Drawing.Point(13, 213);
            this.gpoSinLotesPago.Name = "gpoSinLotesPago";
            this.gpoSinLotesPago.Size = new System.Drawing.Size(1320, 100);
            this.gpoSinLotesPago.TabIndex = 133;
            this.gpoSinLotesPago.TabStop = false;
            this.gpoSinLotesPago.Text = "Pago";
            // 
            // gridLookUpEdit1
            // 
            this.gridLookUpEdit1.Location = new System.Drawing.Point(120, 36);
            this.gridLookUpEdit1.Margin = new System.Windows.Forms.Padding(4);
            this.gridLookUpEdit1.Name = "gridLookUpEdit1";
            this.gridLookUpEdit1.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.gridLookUpEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.gridLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit1.Properties.DisplayMember = "IdControlOperaciones";
            this.gridLookUpEdit1.Properties.NullText = "";
            this.gridLookUpEdit1.Properties.PopupSizeable = false;
            this.gridLookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.gridLookUpEdit1.Properties.ValueMember = "IdControlOperaciones";
            this.gridLookUpEdit1.Properties.View = this.gridView1;
            this.gridLookUpEdit1.Size = new System.Drawing.Size(278, 26);
            this.gridLookUpEdit1.TabIndex = 127;
            this.gridLookUpEdit1.Tag = "Cliente";
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // txtImporte
            // 
            this.txtImporte.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtImporte.Location = new System.Drawing.Point(1040, 36);
            this.txtImporte.Margin = new System.Windows.Forms.Padding(4);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtImporte.Properties.DisplayFormat.FormatString = "C2";
            this.txtImporte.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtImporte.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtImporte.Size = new System.Drawing.Size(150, 26);
            this.txtImporte.TabIndex = 131;
            this.txtImporte.Tag = "Importe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 126;
            this.label3.Text = "Tipo de pago:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(974, 39);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 130;
            this.label6.Text = "Monto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(432, 39);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 128;
            this.label5.Text = "Cliente:";
            // 
            // gridLookUpEdit2
            // 
            this.gridLookUpEdit2.Location = new System.Drawing.Point(502, 36);
            this.gridLookUpEdit2.Margin = new System.Windows.Forms.Padding(4);
            this.gridLookUpEdit2.Name = "gridLookUpEdit2";
            this.gridLookUpEdit2.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.gridLookUpEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.gridLookUpEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit2.Properties.DisplayMember = "IdControlOperaciones";
            this.gridLookUpEdit2.Properties.NullText = "";
            this.gridLookUpEdit2.Properties.PopupSizeable = false;
            this.gridLookUpEdit2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.gridLookUpEdit2.Properties.ValueMember = "IdControlOperaciones";
            this.gridLookUpEdit2.Properties.View = this.gridView2;
            this.gridLookUpEdit2.Size = new System.Drawing.Size(428, 26);
            this.gridLookUpEdit2.TabIndex = 129;
            this.gridLookUpEdit2.Tag = "Cliente";
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // layoutControlBase
            // 
            this.layoutControlBase.Controls.Add(this.layoutControl1);
            this.layoutControlBase.Location = new System.Drawing.Point(190, 334);
            this.layoutControlBase.Name = "layoutControlBase";
            this.layoutControlBase.Root = this.layoutControlGroup1;
            this.layoutControlBase.Size = new System.Drawing.Size(856, 583);
            this.layoutControlBase.TabIndex = 134;
            this.layoutControlBase.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 5;
            this.layoutControlGroup1.Size = new System.Drawing.Size(856, 583);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.layoutControl2);
            this.layoutControl1.Location = new System.Drawing.Point(18, 18);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(820, 547);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.layoutControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(826, 553);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.Root.Location = new System.Drawing.Point(0, 0);
            this.Root.Name = "Root";
            this.Root.OptionsItemText.TextToControlDistance = 5;
            this.Root.Size = new System.Drawing.Size(820, 547);
            this.Root.TextVisible = false;
            // 
            // layoutControl2
            // 
            this.layoutControl2.Location = new System.Drawing.Point(18, 18);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup2;
            this.layoutControl2.Size = new System.Drawing.Size(784, 511);
            this.layoutControl2.TabIndex = 135;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.OptionsItemText.TextToControlDistance = 5;
            this.layoutControlGroup2.Size = new System.Drawing.Size(784, 511);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.layoutControl2;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(790, 517);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.ImageOptions.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(28, 22);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(328, 32);
            this.btnNuevo.TabIndex = 135;
            this.btnNuevo.Text = "Nueva solicitud";
            // 
            // btnEditar
            // 
            this.btnEditar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.ImageOptions.Image")));
            this.btnEditar.Location = new System.Drawing.Point(28, 62);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(328, 32);
            this.btnEditar.TabIndex = 136;
            this.btnEditar.Text = "Editar solicitud";
            // 
            // btnCancelar
            // 
            this.btnCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.ImageOptions.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(28, 102);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(328, 32);
            this.btnCancelar.TabIndex = 137;
            this.btnCancelar.Text = "Cancelar solicitud";
            // 
            // btnGuardar
            // 
            this.btnGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(28, 142);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(328, 32);
            this.btnGuardar.TabIndex = 138;
            this.btnGuardar.Text = "Guardar solicitud";
            // 
            // btnGuardarDetalle
            // 
            this.btnGuardarDetalle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnGuardarDetalle.Location = new System.Drawing.Point(1040, 70);
            this.btnGuardarDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarDetalle.Name = "btnGuardarDetalle";
            this.btnGuardarDetalle.Size = new System.Drawing.Size(106, 32);
            this.btnGuardarDetalle.TabIndex = 139;
            this.btnGuardarDetalle.Text = "Agregar";
            // 
            // frmxSolicitudesPagoProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1835, 1004);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.layoutControlBase);
            this.Controls.Add(this.gpoSinLotesPago);
            this.Controls.Add(this.gpoSol);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmxSolicitudesPagoProveedores";
            this.Text = "frmxSolicitudesPagoProveedores";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gpoSol.ResumeLayout(false);
            this.gpoSol.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbControlRelac.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            this.gpoSinLotesPago.ResumeLayout(false);
            this.gpoSinLotesPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImporte.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlBase)).EndInit();
            this.layoutControlBase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton btnFacturar;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.GroupBox gpoSol;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.GridLookUpEdit cbControlRelac;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView10;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtFechaSolicitud;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gpoSinLotesPago;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SpinEdit txtImporte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraLayout.LayoutControl layoutControlBase;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton btnNuevo;
        private DevExpress.XtraEditors.SimpleButton btnEditar;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnGuardarDetalle;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
    }
}