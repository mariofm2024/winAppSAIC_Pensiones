namespace winAppSAIC.NominaCFDI
{
    partial class frmxControlEmisionRecibosCFDI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmxControlEmisionRecibosCFDI));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navCFDIs = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbiCFDIsEmpleado = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiCFDIsCliente = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiCFDIsPagadora = new DevExpress.XtraNavBar.NavBarItem();
            this.navEmail = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbiEmailCFDIsLote = new DevExpress.XtraNavBar.NavBarItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnSalir = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.nbiCFDIsLote = new DevExpress.XtraNavBar.NavBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 31);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.navBarControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(860, 375);
            this.splitContainerControl1.SplitterPosition = 210;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navCFDIs;
            this.navBarControl1.Appearance.ItemActive.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarControl1.Appearance.ItemActive.Options.UseFont = true;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navCFDIs,
            this.navEmail});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.nbiCFDIsEmpleado,
            this.nbiCFDIsCliente,
            this.nbiCFDIsPagadora,
            this.nbiEmailCFDIsLote,
            this.nbiCFDIsLote});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 210;
            this.navBarControl1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarControl1.Size = new System.Drawing.Size(210, 375);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            this.navBarControl1.View = new DevExpress.XtraNavBar.ViewInfo.StandardSkinExplorerBarViewInfoRegistrator("Metropolis");
            // 
            // navCFDIs
            // 
            this.navCFDIs.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navCFDIs.Appearance.Options.UseFont = true;
            this.navCFDIs.Caption = "Emisión Documentos";
            this.navCFDIs.Expanded = true;
            this.navCFDIs.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiCFDIsEmpleado),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiCFDIsCliente),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiCFDIsLote),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiCFDIsPagadora)});
            this.navCFDIs.LargeImage = ((System.Drawing.Image)(resources.GetObject("navCFDIs.LargeImage")));
            this.navCFDIs.Name = "navCFDIs";
            this.navCFDIs.SmallImage = ((System.Drawing.Image)(resources.GetObject("navCFDIs.SmallImage")));
            // 
            // nbiCFDIsEmpleado
            // 
            this.nbiCFDIsEmpleado.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbiCFDIsEmpleado.Appearance.Options.UseFont = true;
            this.nbiCFDIsEmpleado.Caption = "CFDIs por Empleado";
            this.nbiCFDIsEmpleado.Name = "nbiCFDIsEmpleado";
            this.nbiCFDIsEmpleado.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiCFDIsEmpleado_LinkClicked);
            // 
            // nbiCFDIsCliente
            // 
            this.nbiCFDIsCliente.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbiCFDIsCliente.Appearance.Options.UseFont = true;
            this.nbiCFDIsCliente.Caption = "CFDIs por Tenedora-Cliente";
            this.nbiCFDIsCliente.Name = "nbiCFDIsCliente";
            this.nbiCFDIsCliente.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiCFDIsCliente_LinkClicked);
            // 
            // nbiCFDIsPagadora
            // 
            this.nbiCFDIsPagadora.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbiCFDIsPagadora.Appearance.Options.UseFont = true;
            this.nbiCFDIsPagadora.Caption = "CFDIs por Pagadora";
            this.nbiCFDIsPagadora.Name = "nbiCFDIsPagadora";
            this.nbiCFDIsPagadora.Visible = false;
            this.nbiCFDIsPagadora.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiCFDIsPagadora_LinkClicked);
            // 
            // navEmail
            // 
            this.navEmail.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navEmail.Appearance.Options.UseFont = true;
            this.navEmail.Caption = "Correo Electrónico";
            this.navEmail.Expanded = true;
            this.navEmail.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiEmailCFDIsLote)});
            this.navEmail.Name = "navEmail";
            this.navEmail.SmallImage = ((System.Drawing.Image)(resources.GetObject("navEmail.SmallImage")));
            // 
            // nbiEmailCFDIsLote
            // 
            this.nbiEmailCFDIsLote.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbiEmailCFDIsLote.Appearance.Options.UseFont = true;
            this.nbiEmailCFDIsLote.Caption = "Envío CFDIs por Lote Nómina";
            this.nbiEmailCFDIsLote.Name = "nbiEmailCFDIsLote";
            this.nbiEmailCFDIsLote.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiEmailCFDIsLote_LinkClicked);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnSalir,
            this.barButtonItem1});
            this.barManager1.MaxItemId = 2;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSalir, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnSalir
            // 
            this.btnSalir.Caption = "Salir";
            this.btnSalir.Id = 0;
            this.btnSalir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.ImageOptions.Image")));
            this.btnSalir.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.ImageOptions.LargeImage")));
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSalir_ItemClick);
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
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(860, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 406);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(860, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 375);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(860, 31);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 375);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // nbiCFDIsLote
            // 
            this.nbiCFDIsLote.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.nbiCFDIsLote.Appearance.Options.UseFont = true;
            this.nbiCFDIsLote.Caption = "CFDIs por Lote";
            this.nbiCFDIsLote.Name = "nbiCFDIsLote";
            this.nbiCFDIsLote.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiCFDIsLote_LinkClicked);
            // 
            // frmxControlEmisionRecibosCFDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 429);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmxControlEmisionRecibosCFDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Recibos CFDI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnSalir;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navCFDIs;
        private DevExpress.XtraNavBar.NavBarItem nbiCFDIsEmpleado;
        private DevExpress.XtraNavBar.NavBarItem nbiCFDIsCliente;
        private DevExpress.XtraNavBar.NavBarItem nbiCFDIsPagadora;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraNavBar.NavBarGroup navEmail;
        private DevExpress.XtraNavBar.NavBarItem nbiEmailCFDIsLote;
        private DevExpress.XtraNavBar.NavBarItem nbiCFDIsLote;
    }
}