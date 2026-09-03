using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp2
{

    public partial class Form2 : Form
    {
        private System.Windows.Forms.Timer MyTimer { get; set; }
        private int n = 0;
        public Form2()
        {
            InitializeComponent();
            // 创建 定时器实例 
            MyTimer = new System.Windows.Forms.Timer();
            // 设置定时器 的间隔时间
            MyTimer.Interval = 1000;
            // 绑定定时器的处理程序
            MyTimer.Tick += (object sender, EventArgs e) =>
            {
                n++;
                label1.Text = n.ToString();
            };
            // 开启定时器
            MyTimer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 关闭定时器
            MyTimer.Stop();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // 开启定时器
            MyTimer.Start();
        }
    }
}
