using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Threeday
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            //MessageBox.Show(e.X.ToString());
            //MessageBox.Show(e.Y.ToString());
            //MessageBox.Show(e.Location.ToString());
            //鼠标按键相关
            //MessageBox.Show(e.Button.ToString());
            //点击次数
            //MessageBox.Show(e.Clicks.ToString());
            label1.Text = e.Clicks.ToString();
        }
        //鼠标滚轮
        private void panel1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //label1.Text="内存"+e.KeyCode.ToString();只识别大写字母
            //label1.Text = "内存" + e.Shift.ToString();//按shift就true
            //label1.Text = "内存" + e.Alt.ToString();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            label1.Text = e.KeyChar.ToString();
            if (label1.Text=="a")
            {
                e.Handled = true;
            }
        }
    }
}
