namespace winAppSAIC.Seguridad
{
    partial class frmxControlSeguridad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmxControlSeguridad));
            this.barManager1 = new DevExpress.XtraBars.BarManager();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnSalir = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navGenerales = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbiModulosApp = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiGrupos = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiPantallas = new DevExpress.XtraNavBar.NavBarItem();
            this.navPerfiles = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbiUsuariosGrupo = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbiUsuarios = new DevExpress.XtraNavBar.NavBarItem();
            this.navBancoLayout = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbiAsignarCuentaBancoLayout = new DevExpress.XtraNavBar.NavBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.SuspendLayout();
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
            this.btnSalir});
            this.barManager1.MaxItemId = 1;
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
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 31);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.navBarControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(860, 375);
            this.splitContainerControl1.SplitterPosition = 244;
            this.splitContainerControl1.TabIndex = 4;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navGenerales;
            this.navBarControl1.Appearance.ItemActive.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarControl1.Appearance.ItemActive.Options.UseFont = true;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navGenerales,
            this.navPerfiles,
            this.navBarGroup1,
            this.navBancoLayout});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.nbiModulosApp,
            this.nbiGrupos,
            this.nbiPantallas,
            this.nbiUsuariosGrupo,
            this.nbiUsuarios,
            this.nbiAsignarCuentaBancoLayout});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 244;
            this.navBarControl1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarControl1.Size = new System.Drawing.Size(244, 375);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            this.navBarControl1.View = new DevExpress.XtraNavBar.ViewInfo.StandardSkinExplorerBarViewInfoRegistrator("Metropolis");
            // 
            // navGenerales
            // 
            this.navGenerales.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navGenerales.Appearance.Options.UseFont = true;
            this.navGenerales.Caption = "Generales";
            this.navGenerales.Expanded = true;
            this.navGenerales.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiModulosApp),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiGrupos),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiPantallas)});
            this.navGenerales.LargeImage = ((System.Drawing.Image)(resources.GetObject("navGenerales.LargeImage")));
            this.navGenerales.Name = "navGenerales";
            this.navGenerales.SmallImage = ((System.Drawing.Image)(resources.GetObject("navGenerales.SmallImage")));
            // 
            // nbiModulosApp
            // 
            this.nbiModulosApp.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbiModulosApp.Appearance.Options.UseFont = true;
            this.nbiModulosApp.Caption = "Módulos Aplicación";
            this.nbiModulosApp.Name = "nbiModulosApp";
            this.nbiModulosApp.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiModulosApp_LinkClicked);
            // 
            // nbiGrupos
            // 
            this.nbiGrupos.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbiGrupos.Appearance.Options.UseFont = true;
            this.nbiGrupos.Caption = "Grupos";
            this.nbiGrupos.Name = "nbiGrupos";
            this.nbiGrupos.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiGrupos_LinkClicked);
            // 
            // nbiPantallas
            // 
            this.nbiPantallas.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbiPantallas.Appearance.Options.UseFont = true;
            this.nbiPantallas.Caption = "Pantallas";
            this.nbiPantallas.Name = "nbiPantallas";
            this.nbiPantallas.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiPantallas_LinkClicked);
            // 
            // navPerfiles
            // 
            this.navPerfiles.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navPerfiles.Appearance.Options.UseFont = true;
            this.navPerfiles.Caption = "Pefiles";
            this.navPerfiles.Expanded = true;
            this.navPerfiles.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiUsuariosGrupo)});
            this.navPerfiles.Name = "navPerfiles";
            this.navPerfiles.SmallImage = ((System.Drawing.Image)(resources.GetObject("navPerfiles.SmallImage")));
            // 
            // nbiUsuariosGrupo
            // 
            this.nbiUsuariosGrupo.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbiUsuariosGrupo.Appearance.Options.UseFont = true;
            this.nbiUsuariosGrupo.Caption = "Usuarios por Grupo";
            this.nbiUsuariosGrupo.Name = "nbiUsuariosGrupo";
            this.nbiUsuariosGrupo.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiUsuariosGrupo_LinkClicked);
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.navBarGroup1.Appearance.Options.UseFont = true;
            this.navBarGroup1.Caption = "Catálogos";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiUsuarios)});
            this.navBarGroup1.Name = "navBarGroup1";
            this.navBarGroup1.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup1.SmallImage")));
            // 
            // nbiUsuarios
            // 
            this.nbiUsuarios.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.nbiUsuarios.Appearance.Options.UseFont = true;
            this.nbiUsuarios.Caption = "Usuarios";
            this.nbiUsuarios.Name = "nbiUsuarios";
            this.nbiUsuarios.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiUsuarios_LinkClicked_1);
            // 
            // navBancoLayout
            // 
            this.navBancoLayout.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBancoLayout.Appearance.Options.UseFont = true;
            this.navBancoLayout.Caption = "Banco-Layout";
            this.navBancoLayout.Expanded = true;
            this.navBancoLayout.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiAsignarCuentaBancoLayout)});
            this.navBancoLayout.Name = "navBancoLayout";
            this.navBancoLayout.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBancoLayout.SmallImage")));
            // 
            // nbiAsignarCuentaBancoLayout
            // 
            this.nbiAsignarCuentaBancoLayout.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbiAsignarCuentaBancoLayout.Appearance.Options.UseFont = true;
            this.nbiAsignarCuentaBancoLayout.Caption = "Asignar Banco-Tenedora para Layout";
            this.nbiAsignarCuentaBancoLayout.Name = "nbiAsignarCuentaBancoLayout";
            this.nbiAsignarCuentaBancoLayout.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiAsignarCuentaBancoLayout_LinkClicked);
            // 
            // frmxControlSeguridad
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
            this.Name = "frmxControlSeguridad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Seguridad";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnSalir;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navGenerales;
        private DevExpress.XtraNavBar.NavBarItem nbiModulosApp;
        private DevExpress.XtraNavBar.NavBarItem nbiGrupos;
        private DevExpress.XtraNavBar.NavBarItem nbiPantallas;
        private DevExpress.XtraNavBar.NavBarGroup navPerfiles;
        private DevExpress.XtraNavBar.NavBarItem nbiUsuariosGrupo;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem nbiUsuarios;
        private DevExpress.XtraNavBar.NavBarGroup navBancoLayout;
        private DevExpress.XtraNavBar.NavBarItem nbiAsignarCuentaBancoLayout;
    }
}