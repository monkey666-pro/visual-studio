using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fiveday
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            button1.MouseDown += b;
            button1.MouseMove += b1;
            button1.MouseUp += b2;
        }
        bool key;
        Point a;
        public void b(object sender, MouseEventArgs e)
        {
            key = true;
            //MessageBox.Show(e.Location.X.ToString());//鼠标相对于按钮的坐标
            a = e.Location;//注意：a如果在本方法创建，值只在本方法改变，而下面的方法a只是第一次按下按钮的坐标
            //MessageBox.Show(b.X.ToString());


        }
        public void b1(object sender, MouseEventArgs e)
        {
            if (!key) return;
            //求的是控件到窗体的坐标（鼠标到屏幕-窗体到屏幕-鼠标到控件）
            Point a1=button1.PointToScreen(e.Location);//获得鼠标到屏幕的坐标
            a1.Offset(-a.X, -a.Y);//控件到屏幕的坐标
            Point a2= this.PointToClient(a1);//控件到窗体的坐标
            if (a2.X <= 0) a2.X=0;
            if (a2.Y <= 0) a2.Y = 0;
            if (a2.X >= this.Width - button1.Width) a2.X = this.Width - button1.Width;
            if (a2.Y >= this.Height - button1.Height) a2.Y = this.Height - button1.Height;
            button1.Location = a2;

        }
        public void b2(object sender, MouseEventArgs e)
        {
            key = false;
        }
    }
}
