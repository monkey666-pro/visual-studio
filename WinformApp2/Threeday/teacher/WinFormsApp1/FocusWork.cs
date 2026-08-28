using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FocusWork : Form
    {
        public FocusWork()
        {
            InitializeComponent();
            InitFocusHieghtLigth(); // 获取焦点后高亮
            InitFocusOpen();
        }
        public void InitFocusOpen()
        {
            // 给下拉框 获取焦点 和失去焦点事件
            comboBox1.GotFocus += ComboBox1_GotFocus;
            comboBox1.Leave += ComboBox1_Leave;
        }

        private void ComboBox1_Leave(object sender, EventArgs e)
        {
            (sender as ComboBox).DroppedDown = false;
        }

        private void ComboBox1_GotFocus(object sender, EventArgs e)
        {
            // 下拉框.DroppedDown  设置 下拉框是否展开 
            (sender as ComboBox).DroppedDown = true;

        }

        public void InitFocusHieghtLigth()
        {
            // 给 按钮 添加 获取焦点和失去焦点 事件
            button1.GotFocus += Button1_GotFocus;
            button1.Leave += Button1_Leave;

            textBox1.GotFocus += TextBox1_GotFocus;
            textBox1.Leave += TextBox1_Leave;

        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {
            (sender as TextBox).BackColor = Color.White;
            (sender as TextBox).ForeColor = Color.Black;
            (sender as TextBox).BorderStyle = BorderStyle.FixedSingle;
        }

        private void TextBox1_GotFocus(object sender, EventArgs e)
        {
            (sender as TextBox).BackColor = Color.Orange;
            (sender as TextBox).ForeColor = Color.Blue;
            (sender as TextBox).BorderStyle = BorderStyle.Fixed3D;
        }

        private void Button1_Leave(object sender, EventArgs e)
        {
            // 高亮
            (sender as Button).BackColor = Color.White;
            (sender as Button).ForeColor = Color.Black;

        }

        private void Button1_GotFocus(object sender, EventArgs e)
        {
            // 高亮
            (sender as Button).BackColor = Color.Orange;
            (sender as Button).ForeColor = Color.Blue;

        }
    }
}
