using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace pratice
{
    public partial class Form2 : Form
    {
       public string[] patharr = [@"./images/bird.jpg", @"./images/cat.jpg", @"./images/eagle.jpg"];
       public List<Button> btarr = new();
        public Form2()
        {
            InitializeComponent();
            into();
        }
        public int index = 0;
        public void into()
        {
            label1.Click += lb;
            label2.Click += lb;
            btarr.AddRange(button1, button2, button3);
            foreach(Button i in btarr)i.Click += bt;
            bt();
        }
        public void lb(object sender, EventArgs e)//处理二边
        {
           Label lb =(Label)sender;
            //根据下标，如果下标》2就index=0,如果《0则为2
            if (lb.Text == ">")
            {
                index = index == patharr.Length - 1 ? 0 : (++index);
                foreach (Button i in btarr)
                {
                    i.BackColor = Color.White;
                    i.ForeColor = Color.Black;
                }
                pictureBox1.Image = Image.FromFile(patharr[index]);
                btarr[index].BackColor = Color.Orange;
                btarr[index].ForeColor = Color.Black;
                btarr[index].Focus();
            }
            else
            {
                index = index == 0 ? patharr.Length - 1 : (--index);
                foreach (Button i in btarr)
                {
                    i.BackColor = Color.White;
                    i.ForeColor = Color.Black;
                }
                pictureBox1.Image = Image.FromFile(patharr[index]);
                btarr[index].BackColor = Color.Orange;
                btarr[index].ForeColor = Color.Black;
                btarr[index].Focus();
            }
            
        }
        public void bt(object sender, EventArgs e)
        {
            pictureBox1.Image= Image.FromFile(patharr[btarr.IndexOf((Button)sender)]);
            foreach (Button i in btarr)
            {
                i.BackColor = Color.White;
                i.ForeColor = Color.Black;
            }
            btarr[btarr.IndexOf((Button)sender)].BackColor = Color.Orange;
            btarr[btarr.IndexOf((Button)sender)].ForeColor = Color.Black;
        }
    }
}
