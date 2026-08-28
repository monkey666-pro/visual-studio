using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            InitQD(); // 密码强度检测
            InitQFWFG(); // 输入数字自动千分位分割
            InitToUpper();
        }
        private void InitToUpper()
        {
            // 获取输入的内容, 调用转大写方法,内容写回输入框,注意光标处理
            textBox3.TextChanged += TextBox3_TextChanged;
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            string content = (sender as TextBox).Text;

            content = content.ToUpper();

            (sender as TextBox).Text = content;

            (sender as TextBox).SelectionStart = content.Length;
        }

        private void InitQFWFG()
        {
            // 输入的内容 转为数字,
            // 数字使用 ToString("#,#") 转为目标格式字符串
            // 写回输入框===>处理光标
            //  注意: 后续输入内容的时候 前面一次拿到的内容可能包含逗号,需要处理逗号在转整数

            // 输入框绑定 内容改变事件
            textBox2.TextChanged += TextBox2_TextChanged;
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            string content = (sender as TextBox).Text;

            if (string.IsNullOrWhiteSpace(content)) return; // 处理空白情况

            content = content.Replace(",", "");

            int resNum =  int.Parse(content);

            string resStr = resNum.ToString("#,#");

            (sender as TextBox).Text = resStr;

            (sender as TextBox).SelectionStart = resStr.Length;
        }

        private void InitQD()
        {

            // 密码: 数字 字母
            // 数字, 小写字母,大写字母: 有一项就是 弱,两项 中, 三项 强
            // 输入框 绑定 内容改变事件
            textBox1.TextChanged += TextBox1_TextChanged;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            // 获取输入的密码
            string pwd = (sender as TextBox).Text;
            int num = 0; // num 记录强度数字 1弱  2中  3强 
            
            // 使用正则校验强度
            if (Regex.IsMatch(pwd, @"\d")) num++;
            if (Regex.IsMatch(pwd, @"[a-z]")) num++;
            if (Regex.IsMatch(pwd, @"[A-Z]")) num++;
            string res = ""; // 接收密码强度
            Color resColor;
            if(num == 1)
            {
                res = "弱";
                resColor = Color.Red;
            }else if(num == 2)
            {
                res = "中";
                resColor = Color.Orange;
            }
            else if (num == 3)
            {
                res = "强";
                resColor = Color.Green;
            }
            else
            {
                res = "密码格式错误";
                resColor = Color.Gray;
            }

            // 结果展示
            lavelLab.Text = res;
            lavelLab.ForeColor = resColor;

        }
    }
}
