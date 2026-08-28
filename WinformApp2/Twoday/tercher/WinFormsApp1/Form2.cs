using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            initEvent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 弹窗
            //MessageBox.Show(提示信息,标题,按钮类型,图标)
            //MessageBox.Show("点击了");
            //MessageBox.Show("点击了","标题");
            //MessageBox.Show("点击了","标题",MessageBoxButtons.YesNo);
            //MessageBox.Show("点击了","标题", MessageBoxButtons.OKCancel);
            //MessageBox.Show("点击了","标题", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            //MessageBox.Show("点击了", "标题", MessageBoxButtons.OK, MessageBoxIcon.Question);

            //DialogResult res = MessageBox.Show("点击了","标题", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            //MessageBox.Show((DialogResult.Yes == res).ToString());

        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("鼠标按下了");
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("鼠标松开了");
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            //MessageBox.Show("鼠标进入");
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            //MessageBox.Show("鼠标离开");
        }

        public int n = 0;
        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            n++;
            label1.Text = n.ToString();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show("键盘按键下了");
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            //MessageBox.Show("键盘按键松开");
        }
        // 键盘按下松开事件  只要是 按键就可以触发

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 键入表示有内容变化的按键
            //MessageBox.Show("键盘键入--->输入了内容");
        }

        private void initEvent()
        {
            textBox1.GotFocus += TextBox1_GotFocus;
            textBox1.LostFocus += TextBox1LostFocus;

            textBox3.GotFocus += TextBox3_GotFocus;
            //textBox3.Validating += TextBox3_Validating;
            //textBox3.Validated += TextBox3_Validated;
            textBox3.LostFocus += TextBox3_LostFocus;
            //textBox3.Leave += TextBox3_Leave;

        }

        private void TextBox3_Leave(object sender, EventArgs e)
        {
            label2.Text = "失去焦点-leave";
        }

        private void TextBox3_LostFocus(object sender, EventArgs e)
        {
            label2.Text = "失去焦点";
        }

        //private void TextBox3_Validated(object sender, EventArgs e)
        //{
        //    label2.Text = "校验成功之后触发";
        //}

        //private void TextBox3_Validating(object sender, CancelEventArgs e)
        //{
        //    label2.Text = "将要失去焦点，校验数据";
        //}

        private void TextBox3_GotFocus(object sender, EventArgs e)
        {
            label2.Text = "获取焦点";
        }

        private void TextBox1LostFocus(object sender, EventArgs e)
        {
            label1.Text = "失去光标";

        }
        private void TextBox1_GotFocus(object sender, EventArgs e)
        {
            label1.Text = "获取到光标";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            label1.Text = ((TextBox)sender).Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = ((ComboBox)sender).Text;
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = ((ComboBox)sender).Text;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = ((ListBox)sender).Text;
        }
    }
}
