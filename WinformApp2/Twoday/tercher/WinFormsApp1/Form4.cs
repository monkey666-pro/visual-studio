using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            initTab();
        }
        public string[] picArr = [@"./images/cat.jpg", @"./images/bird.jpg", @"./images/eagle.jpg"];
        public void initTab() {
            
            // 设置初始值
            pictureBox1.Image = Image.FromFile(picArr[0]);
            panel1.Controls[0].BackColor = Color.Cyan;
            panel1.Controls[0].ForeColor = Color.White;

            // 绑定事件
            for (int i = 0; i < panel1.Controls.Count; i++)
            {
                panel1.Controls[i].Click += btn_Click;

            }
        }
        public void btn_Click(object sender,EventArgs e) // 事件函数
        {
            // 先将所有的按钮的高亮效果移除
            for (int i = 0; i < panel1.Controls.Count; i++)
            {
                panel1.Controls[i].BackColor = Color.DarkGray; 
                panel1.Controls[i].ForeColor = Color.Black;
            }
            // 将当前这个按钮的高亮添加
            Button btn = (Button)sender;
            btn.BackColor = Color.Cyan;
            btn.ForeColor = Color.White;

            // 修改图片地址: 当前按钮和对应的图片地址的索引一致
            // 获取 btn按钮在容器中的下标
            int index = panel1.Controls.IndexOf(btn);

            pictureBox1.Image = Image.FromFile(picArr[index]);


        }
    }
}
