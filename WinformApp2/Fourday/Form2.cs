using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fourday
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            into();
        }
        private void into()
        {//判断按键是否是删除按键
            textBox1.KeyPress += kp;
            textBox1.KeyDown += kd;
            panel1.MouseEnter += me;
            panel1.MouseLeave += l;
            label2.MouseEnter += lb;
            //label2.MouseLeave += lb1;
        }
        public void kd(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                e.SuppressKeyPress = true;
            }
            //快捷键
            if (e.Control && e.KeyCode == Keys.X)
            {
                e.SuppressKeyPress = true;
            }
        }
        private void kp(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)8)
            {
                //限制键入
                e.Handled = true;
            }
        }
        //如果限制剪切，判断组合键ctrl+x

        private void me(object sender, EventArgs e)
        {
            panel1.Width += 100;
            panel1.Height += 100;
        }
        private void l(object sender, EventArgs e)
        {
            panel1.Width -= 100;
            panel1.Height -= 100;
        }
        private void lb(object sender, EventArgs e)
        {
            Label ll = (Label)sender;
            //先获取出现提示的坐标
            Point l1 = label2.Location;
            Label lb = new Label();
            lb.Name = "ddd";
            lb.Text = "fef";
            Point l2 = lb.Location;
            l2.X = l1.X + ll.Width + 10;
            l2.Y = l1.Y;
            //进行展示
            lb.Location = l2;//展示的坐标
            this.Controls.Add(lb);//这个才是展示
        }
    }
}
