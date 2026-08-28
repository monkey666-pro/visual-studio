using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class KeyTest : Form
    {
        public KeyTest()
        {
            InitializeComponent();
            InitEnter(); // 回车键(提示)提交表单
            //InitEsc();// ESC退出窗体 
        }
        public void InitEsc()
        {

            textBox1.Visible = false; // 此时ESC退出窗体 的时候 将 textBox1 隐藏
            // 给 窗体 绑定 按键按下
            this.KeyDown += KeyTest_KeyDown;

        }

        private void KeyTest_KeyDown(object sender, KeyEventArgs e)
        {
            // e.KeyCode 是否是 Escape
            if (e.KeyCode == Keys.Escape) {
                this.Close(); // 关闭窗体
            }
            
        }

        public void InitEnter()
        {
            // 给输入框 绑定  键盘松开  
            textBox1.KeyUp += TextBox1_KeyUp;
        }

        private void TextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            // 判断 keyCode 是否是 回车按键
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("模拟提交");
            }
        }
    }
}
