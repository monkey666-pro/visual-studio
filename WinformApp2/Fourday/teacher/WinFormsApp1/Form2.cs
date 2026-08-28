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
        private Label tipsLabel;
        public Form2()
        {
            InitializeComponent();
            InitLimitDelete(); // 限制删除
            InitBigSmall(); // 放大缩小控件
            InitTips(); // 鼠标移入出现提示

        }
        private void InitTips()
        {
            // 移入提示及内容展示.移除提示消失
            // 提示内容,动态创建(代码创建)
            tipsLabel = new Label();
            tipsLabel.Name = "tipsLabel";
            tipsLabel.Text = "提示信息";

            // 设置提示位置
            Point tl = tipsLabel.Location;
            // 获取移入控件的坐标
            // 控件.Location 可以得到控件的坐标
            tl.X = button1.Location.X + button1.Width + 10;
            tl.Y = button1.Location.Y;
            tipsLabel.Location = tl;

            // 绑定移入移出事件
            button1.MouseEnter += Button1_MouseEnter;
            button1.MouseLeave += Button1_MouseLeave;


        }

        private void Button1_MouseLeave(object sender, EventArgs e)
        {
            this.Controls.Remove(tipsLabel);
        }

        private void Button1_MouseEnter(object sender, EventArgs e)
        {
            // tipsLabel 添加到窗体
            this.Controls.Add(tipsLabel);

        }

        private void InitBigSmall()
        {
            // 鼠标移入方法  移除缩小
            panel1.MouseEnter += Panel1_MouseEnter;
            panel1.MouseLeave += Panel1_MouseLeave;
            // 方法缩小 控制 控件的尺寸 
            // 控件.Width   控件.Height  获取设置都是 int类型
            // 控件.Size  获取设置 new Size(宽,高)
        }

        private void Panel1_MouseLeave(object sender, EventArgs e)
        {
            //panel1.Width -= 100;
            //panel1.Height -= 100;
            panel1.Size = new Size(50, 50);
        }

        private void Panel1_MouseEnter(object sender, EventArgs e)
        {
            //panel1.Width += 100;
            //panel1.Height += 100;
            panel1.Size = new Size(300, 300);
        }

        private void InitLimitDelete()
        {
            // 限制删除: 不让删除内容 (判断按键是否是删除删除按键)
            // 键入  按下  松开
            // 给 输入框 绑定 键盘键入事件
            textBox1.KeyPress += TextBox1_KeyPress; //只能限制 BackSpce 
            //textBox1.KeyDown+= TextBox1_KeyDown; // 可以限制 BackSpce  Delete
        }
        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show(e.KeyCode.ToString());
            // 判断键入的按键是否是删除(BackSpace)

            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                // 限制键入,                 
                e.SuppressKeyPress = true;
            }

            // 如果要限制剪切 判断组合键 ctrl+x
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 判断键入的按键是否是删除(BackSpace)
            // e.KeyChar 得到按键字符
            if (e.KeyChar == (char)8)
            {
                // 限制键入, 
                e.Handled = true;
            }
        }
    }
}
