using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Fourday
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            into();
        }
        public void into()
        {
            textBox1.TextChanged += tc;//密码强中弱
            textBox2.TextChanged += tc2;//输入的内容转为数字，通过tostring进行千分位分割
        }
        public void tc(object sender, EventArgs e)
        {
            //获取输入 密码
            string pwd = (sender as TextBox).Text;
            int num = 0;
            //正则校验
            if (Regex.IsMatch(pwd, @"\d")) num++;
            if (Regex.IsMatch(pwd, @"[a-z]")) num++;
            if (Regex.IsMatch(pwd, @"[A-Z]")) num++;
            //通过num判断强中弱
            if (num == 1)
            {
                label2.Text = "弱";
                label2.ForeColor= Color.Red;
            }
            else if (num == 2)
            {
                label2.Text = "中";
                label2.ForeColor = Color.Orange;
            }
            else if (num == 3)
            {
                label2.Text = "强";
                label2.ForeColor = Color.Green;
            }
            label2.Visible= true;
        }
        public void tc2(object sender, EventArgs e)
        {
            string content = (sender as TextBox).Text.ToString();
            content = content.Replace(",", "");
            int arr = int.Parse(content);
            string res = arr.ToString("#,#");
            textBox2.Text = res;

        }
    }
}
