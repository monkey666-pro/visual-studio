using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fourday
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            into();
        }
        public void into()
        {
            //靠近就显示提示词，离开就不显示
            label1.MouseEnter += lb;
            label1.MouseLeave += lb1;
        }
        public Label lb0 = new Label();
        public void lb(object sender, EventArgs e)
        {
            
            //首先创一个提示词

            lb0.Text = "wwww";
            //再根据lable给lb出现的坐标
            Point b = lb0.Location;//先定义lb坐标
            Point b1 = ((Label)sender).Location;//定义原lable坐标，方便坐标定义
            b.X = b1.X + ((Label)sender).Width + 10;
            b.Y = b1.Y;
            //此时b的数据还是原本的，需要再赋值进去
            lb0.Location = b;
            //最后在副容器显示
            this.Controls.Add(lb0);
        }
        public void lb1(object sender, EventArgs e)
        {
            this.Controls.Remove(lb0);
        }
    }
}
