using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Threeday
{
    public partial class location : Form
    {
        public location()
        {
            InitializeComponent();
            this.MouseMove += mm;
        }
        public void mm(object sender, MouseEventArgs e)
        {
            label1.Text = "x轴：" + e.X.ToString();
            label2.Text = "y轴：" + e.Y.ToString();
        }
    }
}
