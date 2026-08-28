using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Threeday
{
    public partial class focustnogo : Form
    {
        public focustnogo()
        {
            InitializeComponent();
            inio();
        }
        private void inio()
        {
            //绑定事件
            textBox1.Leave += tb;
            textBox1.TextChanged += tb1;
            label2.MouseEnter += tb2;
            label2.MouseLeave += tb3;
        }
        private void tb(object sender, EventArgs e)
        {
            TextBox tb = (sender as TextBox);
            string content = tb.Text;
            if (string.IsNullOrEmpty(content))
            {
                tb.Focus();
                label1.Visible = true;
            }

        }
        private void tb1(object sender, EventArgs e)
        {
            TextBox tb = (sender as TextBox);
            string content = tb.Text;
            if (!string.IsNullOrEmpty(content))
            {
                label1.Visible = false;
            }

        }

        private void tb2(object sender, EventArgs e)
        {
            //靠近之后的效果
           
            label2.ForeColor = Color.Blue;
            label2.Font = new Font("楷体", 9F, FontStyle.Underline, GraphicsUnit.Point);
        }
        private void tb3(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Black;
            label2.Font = new Font("Microsoft YaHei UI", 9F);
        }
    }
}
