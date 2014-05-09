namespace TileDemo2
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
            this.windowsUIView1 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView(this.components);
            this.document1 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.document1Tile = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.tileContainer1 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer(this.components);
            this.document2 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.document2Tile = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.document3 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.document3Tile = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.document4 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.document4Tile = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.document5 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.document5Tile = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.document6 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.document6Tile = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsUIView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document1Tile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document2Tile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document3Tile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document4Tile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document5Tile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document6Tile)).BeginInit();
            this.SuspendLayout();
            // 
            // documentManager1
            // 
            this.documentManager1.ContainerControl = this;
            this.documentManager1.ShowThumbnailsInTaskBar = DevExpress.Utils.DefaultBoolean.False;
            this.documentManager1.View = this.windowsUIView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.windowsUIView1});
            // 
            // windowsUIView1
            // 
            this.windowsUIView1.ContentContainers.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.IContentContainer[] {
            this.tileContainer1});
            this.windowsUIView1.Documents.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseDocument[] {
            this.document1,
            this.document2,
            this.document3,
            this.document4,
            this.document5,
            this.document6});
            this.windowsUIView1.Tiles.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.BaseTile[] {
            this.document1Tile,
            this.document2Tile,
            this.document3Tile,
            this.document4Tile,
            this.document5Tile,
            this.document6Tile});
            // 
            // document1
            // 
            this.document1.Caption = "document1";
            this.document1.ControlName = "document1";
            // 
            // document1Tile
            // 
            this.document1Tile.Document = this.document1;
            this.document1Tile.Name = "document1Tile";
            this.document1Tile.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Small;
            // 
            // tileContainer1
            // 
            this.tileContainer1.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.BaseTile[] {
            this.document1Tile,
            this.document2Tile,
            this.document3Tile,
            this.document4Tile,
            this.document5Tile,
            this.document6Tile});
            this.tileContainer1.Name = "tileContainer1";
            // 
            // document2
            // 
            this.document2.Caption = "document2";
            this.document2.ControlName = "document2";
            // 
            // document2Tile
            // 
            this.document2Tile.Document = this.document2;
            this.tileContainer1.SetID(this.document2Tile, 1);
            this.document2Tile.Name = "document2Tile";
            this.document2Tile.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            // 
            // document3
            // 
            this.document3.Caption = "document3";
            this.document3.ControlName = "document3";
            // 
            // document3Tile
            // 
            this.document3Tile.Document = this.document3;
            this.tileContainer1.SetID(this.document3Tile, 2);
            this.document3Tile.Name = "document3Tile";
            this.document3Tile.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            // 
            // document4
            // 
            this.document4.Caption = "document4";
            this.document4.ControlName = "document4";
            // 
            // document4Tile
            // 
            this.document4Tile.Document = this.document4;
            this.tileContainer1.SetID(this.document4Tile, 3);
            this.document4Tile.Name = "document4Tile";
            this.document4Tile.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Large;
            // 
            // document5
            // 
            this.document5.Caption = "document5";
            this.document5.ControlName = "document5";
            // 
            // document5Tile
            // 
            this.document5Tile.Document = this.document5;
            this.tileContainer1.SetID(this.document5Tile, 4);
            this.document5Tile.Name = "document5Tile";
            // 
            // document6
            // 
            this.document6.Caption = "document6";
            this.document6.ControlName = "document6";
            // 
            // document6Tile
            // 
            this.document6Tile.Document = this.document6;
            this.tileContainer1.SetID(this.document6Tile, 5);
            this.document6Tile.Name = "document6Tile";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 578);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsUIView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document1Tile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileContainer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document2Tile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document3Tile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document4Tile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document5Tile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document6Tile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView windowsUIView1;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer tileContainer1;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile document1Tile;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document document1;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile document2Tile;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document document2;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile document3Tile;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document document3;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile document4Tile;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document document4;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile document5Tile;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document document5;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile document6Tile;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document document6;
    }
}

