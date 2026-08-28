using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class LunBoTu : Form
    {
        private int speed = 15;

        // 按键按下的开始时间
        private DateTime StartTime { get; set; }

        // 键盘按下事件 键盘一直按下会一直执行
        // 使用开关控制目标代码执行
        // 判断开关是开 则执行目标代码
        //      第一次触发按下事件 则将 开关关闭
        //      那么后续长按触发的事件 开关都是关闭的则不会执行目标代码
        // 只有当按键松开的时候 则开关打开

        // 定义一个开关属性,
        private bool flag = true;
        private void LunBoTu_KeyUp(object sender, KeyEventArgs e)
        {
            // 打开开关
            flag = true;

            // 在键盘松开事件中 获取 结束时间 
            DateTime EndTime = DateTime.Now;
            // 并计算时差 展示在label中
            TimeSpan diff =  EndTime - StartTime;
            // 转ms
            labelTime.Text = diff.TotalMilliseconds.ToString();
            label2.Text = n.ToString();
        }

        private int n = 0;
        private void Move_KeyDown(object sender, KeyEventArgs e)
        {
            if (flag)  // 开关打开才执行
            {
                n++;
                // 按键按下时间功能
                StartTime = DateTime.Now;
                // 关闭开关
                flag = false;
            }
            


            // 按键控制移动
            Point bl = box.Location;
            // 获取窗体的尺寸
            int formWidth = this.Width;
            int formHeight = this.Height;
            // 获取 移动控件的尺寸
            int boxWidth = box.Width;
            int boxHeight = box.Height;
            // 计算最大运动距离
            int xMax = formWidth - boxWidth;
            int yMax = formHeight - boxHeight;


            switch (e.KeyCode)
            {
                case Keys.W:
                    bl.Y -= speed;
                    if (bl.Y <= 0) bl.Y = 0;
                    break;
                case Keys.S:
                    bl.Y += speed;
                    if (bl.Y >= yMax) bl.Y = yMax;
                    break;
                case Keys.A:
                    bl.X -= speed;
                    if (bl.X <= 0) bl.X = 0;
                    break;
                case Keys.D:
                    bl.X += speed;
                    if (bl.X >= xMax) bl.X = xMax;
                    break;
                default:
                    break;
            }
            box.Location = bl;


            // 判断键盘按下的是否是ESC 是就退出窗体
            if (e.KeyCode == Keys.Escape) this.Close();
        }

        public LunBoTu()
        {
            InitializeComponent();
            // 键盘控制方向移动
            this.KeyDown += Move_KeyDown;

            // 按键按下时间功能
            // 键盘松开事件
            this.KeyUp += LunBoTu_KeyUp;
        }
    }
}
