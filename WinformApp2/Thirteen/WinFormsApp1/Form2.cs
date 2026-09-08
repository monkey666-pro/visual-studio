using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//先将每一个出现字符格式封装好，每一个字符都有一个定时器，用list装数据
namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public int heigh = 0;
        public int speed = 0;
        private System.Windows.Forms.Timer timer = new();
        private System.Windows.Forms.Timer timerpro = new();
        private System.Windows.Forms.Timer timerpromax = new();
        public List<feng> list = new();
        private Random ran = new();
        private int count = 0;
        public Form2()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyUp += Form2_KeyUp;
            timer.Tick += Timer_Tick;
            timer.Interval = 800;
        }
        public void show()
        {//先对字体的属性进行设置
           Label a = new();
            a.Size = new Size(30, 30);
            a.Text = ((char)ran.Next(65, 91)).ToString();
            a.Location = new Point(ran.Next(panel1.Width - 30), 0);
            a.Font = new Font("楷体", 10F, FontStyle.Bold, GraphicsUnit.Point);
            panel1.Controls.Add(a);//容器进行添加
            System.Windows.Forms.Timer time = new();
            time.Interval = 10;//定义下落的速度
            time.Tick += (object sender, EventArgs e) =>
            {
                a.Top += 2;
                label1.Text = count.ToString();
                if (a.Top >= panel1.Height - 30)
                {
                    //关闭所有定时器并清空list
                    timer.Stop();//关闭总计时器
                    timerpro.Stop();
                    timerpromax.Stop();
                    foreach (var i in list) { i.time.Stop(); };//关闭list内存储的所有定时器
                    list.Clear();//清空list
                    MessageBox.Show("失败!!!!");
                }
            };
            time.Start();
            list.Add(new feng(time, a));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count = 0;
            panel1.Controls.Clear();
            heigh = 0;
            timer.Start();
        }

        private void Form2_KeyUp(object? sender, KeyEventArgs e)
        {
            for (int i = 0; i < list.Count; i++)
            {
                //if (!Enum.TryParse(list[i].a.Text, true, out Keys k)) continue;
                    if (list[i].a.Text == e.KeyCode.ToString())
                    {
                        //关闭定时器并panel删除对应控件以及list
                        list[i].time.Stop();
                    panel1.Controls.Remove(list[i].a);
                    list.RemoveAt(i);
                    ++count;
                    return;
                    }
            }
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            show();
            if (count == 20)
            {
                timer.Stop();
                timerpro.Interval = 500;
                timerpro.Tick += Timerpro_Tick;
                timerpro.Start();
            }
            
        }

        private void Timerpromax_Tick(object? sender, EventArgs e)
        {
            show();
        }

        private void Timerpro_Tick(object? sender, EventArgs e)
        {
            show();
            if (count == 30)
            {
                timerpro.Stop();
                timerpromax.Interval = 100;
                timerpromax.Tick += Timerpromax_Tick;
                timerpromax.Start();
            }
        }
    }
    public class feng
    {
        public System.Windows.Forms.Timer time = new();
        public Label a = new();
       public  feng(System.Windows.Forms.Timer time, Label a)
        {
            this.a=a; this.time=time;
        }
    }//进行封装，通过list装，删除时通过list删除对应下标
}
