using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form3 : Form
    {
        private System.Windows.Forms.Timer MyTimer1 { get; set; }
        private System.Windows.Forms.Timer MyTimer2 { get; set; }
        public Form3()
        {
            InitializeComponent();
            //MyTimer1 = new System.Windows.Forms.Timer();
            //MyTimer1.Interval = 1000;
            //MyTimer1.Tick += (object snender, EventArgs e) =>
            //{
            //    // 获取当前时间对象
            //    DateTime dt = DateTime.Now;
            //    // 获取小时
            //    var hour = dt.Hour;
            //    // 分钟
            //    var minute = dt.Minute;
            //    // 秒速
            //    var second = dt.Second;
            //    label1.Text = $"{hour}:{minute}:{second}";
            //};

            //MyTimer1.Start();
            show();
            ShowTime();

        }

        private void ShowTime()
        {
            MyTimer2 = new System.Windows.Forms.Timer();
            MyTimer2.Interval = 1000;
            MyTimer2.Tick += (object snender, EventArgs e) => show();

            MyTimer2.Start();
        }

        private void show()
        {
            // 获取当前时间对象
            DateTime dt = DateTime.Now;
            // 获取小时
            var hour = dt.Hour.ToString();
            // 分钟
            var minute = dt.Minute.ToString();
            // 秒速
            var second = dt.Second.ToString();
            pictureBox3.Image = Image.FromFile(@"./images/maohao.png");
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.Image = Image.FromFile(@"./images/maohao.png");
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            // @"./images/数字.png"
            string timeStr = hour.PadLeft(2, '0') + minute.PadLeft(2, '0') + second.PadLeft(2, '0');
            //组织一下控件在数组中
            var picArr = new PictureBox[] {
                    pictureBox1,pictureBox2,pictureBox4,
                    pictureBox5,pictureBox7,pictureBox8
                };
            for (int i = 0; i < picArr.Length; i++)
            {
                picArr[i].SizeMode = PictureBoxSizeMode.StretchImage;
                picArr[i].Image = Image.FromFile(@"./images/" + timeStr[i] + ".png");
            }

        }
    }
}
