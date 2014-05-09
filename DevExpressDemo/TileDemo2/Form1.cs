using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;

namespace TileDemo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DelegateAction actionDefaultSkin = new DelegateAction(CanSetDefaultSkin, SetDefaultSkin);
            actionDefaultSkin.Caption = "Default Theme";
            actionDefaultSkin.Type = ActionType.Context;
            actionDefaultSkin.Edge = ActionEdge.Left;
            actionDefaultSkin.Behavior = ActionBehavior.HideBarOnClick;
            windowsUIView1.ContentContainerActions.Add(actionDefaultSkin);
        }
        static bool CanSetDefaultSkin()
        {
            return DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName != "DevExpress Style";
        }
        static void SetDefaultSkin()
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
        }

        private void windowsUIView1_QueryControl(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e)
        {
            if (e.Document == document1)
                e.Control = new UserControl1();
            else
                e.Control = new UserControl2();
        }
    }
}
