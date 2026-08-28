using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Threeday
{
    public partial class jiaodianlanjie : Form
    {
        public jiaodianlanjie()
        {
            InitializeComponent();
            textBox1.TextChanged += tb;
            textBox1.Leave += tb1;
        }
        public void tb(object sender, EventArgs e)
        {
            //输入过程中不为空就不显示
            TextBox tx = (TextBox)sender;
            string neirong = textBox1.Text.ToString();
            if (!string.IsNullOrEmpty(neirong))
            {
                tx.Focus();
                label1.Visible = false;
            }
            else label1.Visible = true;

        }
        public void tb1(object sender, EventArgs e)
        {//如果光标消失，空的话lable显示
            TextBox tx = (TextBox)sender;
            string neirong = textBox1.Text.ToString();
            if (string.IsNullOrEmpty(neirong))
            {
                tx.Focus();
                label1.Visible = true;
            }

        }
    }
}
