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
        public Form2()
        {
            InitializeComponent();
        }
        // label的高度
        private int Labheight = 0;
        private Label Lab = new();
        private Random Rand = new();

        private System.Windows.Forms.Timer labTimer = new();
        private void button1_Click(object sender, EventArgs e)
        {
            // 开始游戏
            // 设置Label
            SetLabel();
            // 设置定时器
            labTimer.Interval = 10;
            labTimer.Tick -= LabTimer_Tick; // 先解绑,再绑定,别名绑定多次
            labTimer.Tick += LabTimer_Tick;
            labTimer.Start();
            this.KeyPreview = true; // 让窗体得到光标
            this.ActiveControl = null;
            this.KeyUp -= Form2_KeyUp;
            this.KeyUp += Form2_KeyUp;
        }

        private void Form2_KeyUp(object? sender, KeyEventArgs e)
        {
            //e.KeyCode 是一个枚举值 Key
            //Console.WriteLine("触发了");
            if (!Enum.TryParse(Lab.Text, true, out Keys k)) return;
            if(k == e.KeyCode)
            {
                panel1.Controls.Remove(Lab);
                SetLabel();
            }
        }

        private void LabTimer_Tick(object? sender, EventArgs e)
        {            
            Labheight += 2;
            Lab.Top = Labheight;
            if (Lab.Top >= panel1.Height - 30)
            {
                // 游戏结束
                labTimer.Stop();
                MessageBox.Show("Game Over!!!");
                panel1.Controls.Remove(Lab);
            }
        }

        private void SetLabel()
        {
            Labheight = 0;
            // 1. 获取随机字母字符
            string str = "QWERTYUIOPASDFGHJKLZXCVBNM";
            Lab.Text = str[Rand.Next(str.Length)].ToString();
            Lab.Size = new Size(30, 30);
            Lab.Location = new Point(Rand.Next(panel1.Width - 30), 0);
            Lab.TextAlign = ContentAlignment.MiddleCenter;
            Lab.Font = new Font("微软雅黑", 14F, FontStyle.Bold, GraphicsUnit.Point);
            // 添加到panel中
            panel1.Controls.Add(Lab);
        }

    }
}


/*
  游戏开始
    - 设置label的Text/Location/Size...... ===> 定义个设置Label的方法
    - 启动定时器,定时器方法
        + 定时器让label下落,下落中判断高度
    - 窗体绑定键盘事件
        + 判断按键按下的和Label中的内容是否一致
*/