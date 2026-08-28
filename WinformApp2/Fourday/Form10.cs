using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fourday
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
            into();
        }
        public void into()
        {
            textBox1.TextChanged += tb;
        }
        public void tb(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            //先获取到限制数的字符串，判断是否大于限制数
            string a = tb.Text;
            if (a.Length > 10)
            {
                a=a.Substring(0,10);
                textBox1.Text = a;
                label1.Text = "已超过10位";
                label1.Visible= true;

            }
            textBox1.SelectionStart = 10;
        }
    }
}
