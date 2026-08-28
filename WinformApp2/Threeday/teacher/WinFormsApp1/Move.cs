using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Move : Form
    {
        private int speed = 5;
        public Move()
        {
            

            InitializeComponent();
            // 键盘控制方向移动
            this.KeyDown += Move_KeyDown;
            
            // 获取控件的尺寸
            //MessageBox.Show(box.Width.ToString());
            //MessageBox.Show(this.Height.ToString());
        }

        private void Move_KeyDown(object sender, KeyEventArgs e)
        {
            Point bl = box.Location;
            //获取窗体尺寸
            int formwidth = this.Width;
            int formheigh = this.Height;
            //获取控件尺寸
            int boxwidth=box.Width;
            int boxheigh=box.Height;
            //计算最大的移动距离
            int widthmax = formwidth - box.Width;
            int heighmax = formheigh - box.Height;
            switch (e.KeyCode)
            {
                case Keys.W:
                    bl.Y -= speed;
                    if (bl.Y <= 0) bl.Y = 0;
                    break;
                case Keys.S:
                    bl.Y += speed;
                    if (bl.Y == heighmax) bl.Y = bl.Y = heighmax;
                    break;
                case Keys.A:
                    if (bl.X <= 0) bl.X=0;
                    bl.X -= speed;
                    
                    break;
                case Keys.D:
                    bl.X += speed;
                    if (bl.X == widthmax) bl.X = bl.X = widthmax;
                    break;
                default:
                    break;
            }
            box.Location = bl;
            //判断按键是否是esc，是就窗体退出
            if (e.KeyCode == Keys.Escape) this.Close();
        }
    }
}

/*
 键盘控制方向移动
    - 定义一个speed: 速度 每次按键触发移动的距离
    - 给窗体绑定 键盘按下 事件  
        + 判断按下的按键
            - W: 上   将盒子的Location Y 减 speed
            - S: 下   将盒子的Location Y 加 speed
            - A: 左   将盒子的Location X 减 speed
            - D: 右   将盒子的Location X 加 speed
        + 修改后赋值会给box
*/
