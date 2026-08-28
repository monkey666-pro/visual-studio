using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Threeday
{
    public partial class iphone : Form
    {
        public iphone()
        {
            InitializeComponent();
            //先对消息框进行事件
            textBox1.GotFocus += tb;
            textBox1.Leave += tb1;
        }
        //正则：@"^1[1-9]\d{9}"
        public void tb(object sender, EventArgs e)
        {
            //一开始没输入内容就都屏蔽
            label1.Visible = false;
            label2.Visible = false;
        }
        public void tb1(object sender, EventArgs e)
        {
            //如果不符合就显示错误
            if (Regex.IsMatch(textBox1.Text, @"^1[1-9]\d{9}$")) 
            {
                label1.Visible = true;
            }
            else label2.Visible = true;
        }
    }
}
