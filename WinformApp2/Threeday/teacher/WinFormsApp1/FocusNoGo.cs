using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FocusNoGo : Form
    {
        public FocusNoGo()
        {
            InitializeComponent();
            InitFocusNoGo();
        }

        private void InitFocusNoGo()
        {
            // 绑定事件
            tb1.Leave += Tb1_Leave; // 光标离开事件
            tb1.TextChanged += tb1_TextChanged;


            // label 绑定事件
            lab2.MouseEnter += lab2_MouseEnter;
            lab2.MouseLeave += lab2_MouseLeave;
        }

        private void lab2_MouseEnter(object sender,EventArgs e)
        {
            // 高亮 下划线
            lab2.ForeColor = Color.Purple;
            // 字体  大小 样式  单位
            lab2.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Underline, GraphicsUnit.Point);

        }
        private void lab2_MouseLeave(object sender, EventArgs e)
        {
            // 高亮 默认
            lab2.ForeColor = Color.Blue;
            lab2.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        }


        private void Tb1_GotFocus(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {
            // 获取输入框的内容
            TextBox tb = (sender as TextBox);
            string conent = tb.Text;
            if (!string.IsNullOrEmpty(conent)) label1.Visible = false;
        }
        

        private void Tb1_Leave(object sender, EventArgs e)
        {
            // 获取输入框的内容
            TextBox tb = (sender as TextBox);
            string conent = tb.Text;
            // 判断内容是否为空
            if (string.IsNullOrEmpty(conent))
            {
                tb.Focus();
                label1.Visible = true;
            }
            
        }
    }
}
