using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class KeyTest2 : Form
    {
        public KeyTest2()
        {
            InitializeComponent();
            InitCtrl(); // 组合键保存、复制
            InitNum(); // 限制文本框只能输入数字
        }
        public void InitNum()
        {
            // 字符之间可以直接比较大小  字符之间的比较是 编码的 比较
            // --字符先转为编码值(int)然后比较大小----
            //MessageBox.Show(('1' > '0').ToString());
            //MessageBox.Show(('a' > '0').ToString());

            // 给输入框绑定 键盘按下事件
            textBox2.KeyPress += TextBox2_KeyPress;
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = true; // 拦截输入

            // e.KeyChr 获取按下的字符

            // 判断按下的字符是否是数字
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                //输入的不是数字,则拦截输入
                e.Handled = true;
            }
        }

        public void InitCtrl()
        {
            // 给输入框绑定 键盘按下事件
            textBox1.KeyDown += TextBox1_KeyDown;
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            // 判断按键  e.Control 及 按键是否是C 
            if (e.Control && e.KeyCode == Keys.C)
            {
                MessageBox.Show("你要复制了吗?");
            }

            if (e.Control && e.KeyCode == Keys.S)
            {
                MessageBox.Show("你要保存了吗?");
            }
        }
    }
}
