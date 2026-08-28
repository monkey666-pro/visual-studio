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
    public partial class CursorLocation : Form
    {
        public CursorLocation()
        {
            InitializeComponent();
            // 鼠标在窗体中移动 获取到 实时坐标
            // 事件: 鼠标移动事件
            //类的方法中this表示 实例
            this.MouseMove += This_MouseMove;


            // 给输入框绑定 失去焦点 触发
            textBox1.Leave += TextBox1_Leave;
            // 给输入框绑定 获取焦点 触发
            textBox1.GotFocus += TextBox1_GotFocus;
        }

        private void TextBox1_GotFocus(object sender, EventArgs e)
        {
            // 将两个lab 隐藏
            labT.Visible = false;
            labF.Visible = false;
        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {
            // 获取输入框的内容
            string content = (sender as TextBox).Text;
            // 根据正则校验 内容是否符合要求  @"^1[1-9]\d{9}$"
            if (Regex.IsMatch(content, @"^1[1-9]\d{9}$"))
            {
                // 通过labT 展示
                labT.Visible = true;
            }
            else
            {
                // 如果不通过则 labF 展示
                labF.Visible = true;
            }

        }

        private void This_MouseMove(object sender, EventArgs e)
        {
            // 将事件参数对象转为 鼠标事件参数对象 (只有鼠标事件才行)
            MouseEventArgs ev = (e as MouseEventArgs);
            // 获取当前的坐标位置 并赋值展示
            lab1.Text = ev.X.ToString();
            lab2.Text = ev.Y.ToString();
        }


    }
}
