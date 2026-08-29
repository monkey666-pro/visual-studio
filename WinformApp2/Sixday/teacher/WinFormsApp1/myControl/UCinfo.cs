using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1.myControl
{
    public partial class UCinfo : UserControl
    {
        public UCinfo(string uname, string uage)
        {
            InitializeComponent();
            nameLab.Text = uname;
            ageLab.Text = uage;
        }
        public UCinfo()
        {
            InitializeComponent();
        }
        // 定义一个公开数据 不赋值:  值类型是一个函数
        public Action<string> toParent;
        // Action<string> 函数类型  没有返回值 


        // 点击删除按钮
        private void button1_Click(object sender, EventArgs e)
        {
            // 删除了界面中的内容  button1.Parent 是UCinfo用户控件
            // button1.Parent.Parent 就是 flowLayoutPanel1
            button1.Parent.Parent.Controls.Remove(button1.Parent);
            //MessageBox.Show(this.Tag.ToString());
            //toParent(this.Tag.ToString());
            toParent?.Invoke(this.Tag.ToString());
        }
    }
}
