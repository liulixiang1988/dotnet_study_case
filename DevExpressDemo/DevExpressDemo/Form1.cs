using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExpressDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabbedView1_QueryControl(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e)
        {
            if (e.Document.ControlName == "UserControl1")
            {
                e.Control = new UserControl1();
            }
            else
            {
                e.Control = new UserControl2();}
        }
    }
}
