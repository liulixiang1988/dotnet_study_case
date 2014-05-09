namespace DevExpressDemo
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.documentGroup1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(this.components);
            this.userControl1Document = new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(this.components);
            this.userControl2Document = new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(this.components);
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.panelContainer2 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.dockPanel3 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel3_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.dockPanel2 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel2_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.panelContainer1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel6 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel6_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.dockPanel5 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel5_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.dockPanel4 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel4_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockingMenuItem1 = new DevExpress.XtraBars.BarDockingMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userControl1Document)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userControl2Document)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.panelContainer2.SuspendLayout();
            this.dockPanel1.SuspendLayout();
            this.dockPanel3.SuspendLayout();
            this.dockPanel2.SuspendLayout();
            this.panelContainer1.SuspendLayout();
            this.dockPanel6.SuspendLayout();
            this.dockPanel5.SuspendLayout();
            this.dockPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // documentManager1
            // 
            this.documentManager1.ContainerControl = this;
            this.documentManager1.MenuManager = this.barManager1;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // tabbedView1
            // 
            this.tabbedView1.DocumentGroups.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup[] {
            this.documentGroup1});
            this.tabbedView1.Documents.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseDocument[] {
            this.userControl1Document,
            this.userControl2Document});
            this.tabbedView1.QueryControl += new DevExpress.XtraBars.Docking2010.Views.QueryControlEventHandler(this.tabbedView1_QueryControl);
            // 
            // documentGroup1
            // 
            this.documentGroup1.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document[] {
            this.userControl1Document,
            this.userControl2Document});
            // 
            // userControl1Document
            // 
            this.userControl1Document.Caption = "UserControl1";
            this.userControl1Document.ControlName = "UserControl1";
            this.userControl1Document.ControlTypeName = "DevExpressDemo.UserControl1";
            // 
            // userControl2Document
            // 
            this.userControl2Document.Caption = "UserControl2";
            this.userControl2Document.ControlName = "UserControl2";
            this.userControl2Document.ControlTypeName = "DevExpressDemo.UserControl2";
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.MenuManager = this.barManager1;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.panelContainer2,
            this.dockPanel2,
            this.panelContainer1});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // panelContainer2
            // 
            this.panelContainer2.Controls.Add(this.dockPanel1);
            this.panelContainer2.Controls.Add(this.dockPanel3);
            this.panelContainer2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.panelContainer2.ID = new System.Guid("3e2f43e3-db99-426b-89d2-1d0da3e31389");
            this.panelContainer2.Location = new System.Drawing.Point(503, 53);
            this.panelContainer2.Name = "panelContainer2";
            this.panelContainer2.OriginalSize = new System.Drawing.Size(200, 200);
            this.panelContainer2.Size = new System.Drawing.Size(200, 459);
            this.panelContainer2.Text = "panelContainer2";
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.dockPanel1.ID = new System.Guid("9834c94d-19c0-48e2-b6dd-19ebc46e23c9");
            this.dockPanel1.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(200, 267);
            this.dockPanel1.Size = new System.Drawing.Size(200, 229);
            this.dockPanel1.Text = "解决方案";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(192, 202);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // dockPanel3
            // 
            this.dockPanel3.Controls.Add(this.dockPanel3_Container);
            this.dockPanel3.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.dockPanel3.ID = new System.Guid("9affcde8-d0dd-4368-8bea-abe2e26afa57");
            this.dockPanel3.Location = new System.Drawing.Point(0, 229);
            this.dockPanel3.Name = "dockPanel3";
            this.dockPanel3.OriginalSize = new System.Drawing.Size(200, 268);
            this.dockPanel3.Size = new System.Drawing.Size(200, 230);
            this.dockPanel3.Text = "属性";
            // 
            // dockPanel3_Container
            // 
            this.dockPanel3_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel3_Container.Name = "dockPanel3_Container";
            this.dockPanel3_Container.Size = new System.Drawing.Size(192, 203);
            this.dockPanel3_Container.TabIndex = 0;
            // 
            // dockPanel2
            // 
            this.dockPanel2.Controls.Add(this.dockPanel2_Container);
            this.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel2.ID = new System.Guid("40c3712b-6fce-45f7-a579-98a1e3200bd6");
            this.dockPanel2.Location = new System.Drawing.Point(0, 53);
            this.dockPanel2.Name = "dockPanel2";
            this.dockPanel2.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel2.Size = new System.Drawing.Size(200, 459);
            this.dockPanel2.Text = "工具箱";
            // 
            // dockPanel2_Container
            // 
            this.dockPanel2_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel2_Container.Name = "dockPanel2_Container";
            this.dockPanel2_Container.Size = new System.Drawing.Size(192, 432);
            this.dockPanel2_Container.TabIndex = 0;
            // 
            // panelContainer1
            // 
            this.panelContainer1.ActiveChild = this.dockPanel6;
            this.panelContainer1.Controls.Add(this.dockPanel5);
            this.panelContainer1.Controls.Add(this.dockPanel4);
            this.panelContainer1.Controls.Add(this.dockPanel6);
            this.panelContainer1.CustomHeaderButtons.AddRange(new DevExpress.XtraBars.Docking2010.IButton[] {
            new DevExpress.XtraBars.Docking.CustomHeaderButton("", global::DevExpressDemo.Properties.Resources.camera_2, -1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, -1)});
            this.panelContainer1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom;
            this.panelContainer1.FloatVertical = true;
            this.panelContainer1.ID = new System.Guid("7c831046-e6a1-4d3b-b7e4-36343389d5a6");
            this.panelContainer1.Location = new System.Drawing.Point(200, 312);
            this.panelContainer1.Name = "panelContainer1";
            this.panelContainer1.OriginalSize = new System.Drawing.Size(200, 200);
            this.panelContainer1.Size = new System.Drawing.Size(303, 200);
            this.panelContainer1.Tabbed = true;
            this.panelContainer1.Text = "panelContainer1";
            // 
            // dockPanel6
            // 
            this.dockPanel6.Controls.Add(this.dockPanel6_Container);
            this.dockPanel6.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.dockPanel6.FloatVertical = true;
            this.dockPanel6.ID = new System.Guid("faa243fa-aa9b-4ebf-93d8-8a93a116df05");
            this.dockPanel6.Location = new System.Drawing.Point(4, 28);
            this.dockPanel6.Name = "dockPanel6";
            this.dockPanel6.OriginalSize = new System.Drawing.Size(295, 140);
            this.dockPanel6.Size = new System.Drawing.Size(295, 140);
            this.dockPanel6.Text = "警告";
            // 
            // dockPanel6_Container
            // 
            this.dockPanel6_Container.Location = new System.Drawing.Point(0, 0);
            this.dockPanel6_Container.Name = "dockPanel6_Container";
            this.dockPanel6_Container.Size = new System.Drawing.Size(295, 140);
            this.dockPanel6_Container.TabIndex = 0;
            // 
            // dockPanel5
            // 
            this.dockPanel5.Controls.Add(this.dockPanel5_Container);
            this.dockPanel5.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.dockPanel5.FloatVertical = true;
            this.dockPanel5.ID = new System.Guid("c800eafb-075f-47ff-9a64-28c4d44e532b");
            this.dockPanel5.Location = new System.Drawing.Point(4, 28);
            this.dockPanel5.Name = "dockPanel5";
            this.dockPanel5.OriginalSize = new System.Drawing.Size(295, 140);
            this.dockPanel5.Size = new System.Drawing.Size(295, 140);
            this.dockPanel5.Text = "错误";
            // 
            // dockPanel5_Container
            // 
            this.dockPanel5_Container.Location = new System.Drawing.Point(0, 0);
            this.dockPanel5_Container.Name = "dockPanel5_Container";
            this.dockPanel5_Container.Size = new System.Drawing.Size(295, 140);
            this.dockPanel5_Container.TabIndex = 0;
            // 
            // dockPanel4
            // 
            this.dockPanel4.Controls.Add(this.dockPanel4_Container);
            this.dockPanel4.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.dockPanel4.FloatVertical = true;
            this.dockPanel4.ID = new System.Guid("0b31366a-c2fd-4671-97cd-6f85da38490d");
            this.dockPanel4.Location = new System.Drawing.Point(4, 28);
            this.dockPanel4.Name = "dockPanel4";
            this.dockPanel4.OriginalSize = new System.Drawing.Size(295, 140);
            this.dockPanel4.Size = new System.Drawing.Size(295, 140);
            this.dockPanel4.Text = "消息";
            // 
            // dockPanel4_Container
            // 
            this.dockPanel4_Container.Location = new System.Drawing.Point(0, 0);
            this.dockPanel4_Container.Name = "dockPanel4_Container";
            this.dockPanel4_Container.Size = new System.Drawing.Size(295, 140);
            this.dockPanel4_Container.TabIndex = 0;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockManager = this.dockManager1;
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barSubItem1,
            this.barStaticItem1,
            this.barButtonItem1,
            this.barDockingMenuItem1});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 4;
            this.barManager1.StatusBar = this.bar3;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(703, 53);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 512);
            this.barDockControlBottom.Size = new System.Drawing.Size(703, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 53);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 459);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(703, 53);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 459);
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barSubItem1, DevExpress.XtraBars.BarItemPaintStyle.Standard),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barDockingMenuItem1)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "文件(&F)";
            this.barSubItem1.Id = 0;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "编辑(&E)";
            this.barStaticItem1.Id = 1;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "新建(&N)";
            this.barButtonItem1.Id = 2;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barDockingMenuItem1
            // 
            this.barDockingMenuItem1.Caption = "视图(&V)";
            this.barDockingMenuItem1.Id = 3;
            this.barDockingMenuItem1.Name = "barDockingMenuItem1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 535);
            this.Controls.Add(this.panelContainer1);
            this.Controls.Add(this.dockPanel2);
            this.Controls.Add(this.panelContainer2);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userControl1Document)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userControl2Document)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.panelContainer2.ResumeLayout(false);
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel3.ResumeLayout(false);
            this.dockPanel2.ResumeLayout(false);
            this.panelContainer1.ResumeLayout(false);
            this.dockPanel6.ResumeLayout(false);
            this.dockPanel5.ResumeLayout(false);
            this.dockPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel6;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel6_Container;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel5;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel5_Container;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel4;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel4_Container;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel3;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel3_Container;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel2;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel2_Container;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup documentGroup1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.Document userControl1Document;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.Document userControl2Document;
        private DevExpress.XtraBars.Docking.DockPanel panelContainer1;
        private DevExpress.XtraBars.Docking.DockPanel panelContainer2;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarDockingMenuItem barDockingMenuItem1;
    }
}

