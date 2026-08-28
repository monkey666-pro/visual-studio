using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            initSwitch();
        }
        public void initSwitch()
        {
            button1.Click += Button1_Click;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            // 判断按钮中的文本内容
            if (btn.Text == "打开") {
                // 通过代码给 图片控件 设置 图片资源Image.FromFile(图片路径)
                pictureBox1.Image = Image.FromFile(@"./images/on.png");
                btn.Text = "关闭";
            }
            else
            {
                pictureBox1.Image = Image.FromFile(@"./images/off.png");
                btn.Text = "打开";
            }
        }
    }
    
}
