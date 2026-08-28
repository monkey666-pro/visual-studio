using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Threeday
{
    public partial class lunbotu : Form
    {
        public lunbotu()
        {
            InitializeComponent();
            //初始化，将按钮添加到list中
            into();

        }
        public void into()
        {
            indexarr.AddRange([button1, button2, button3]);
            Label[] lbarr = [label1, label2];
            foreach (Label i in lbarr) i.Click += lb;
            foreach (Button i in indexarr) i.Click += bt;
            //初始化页面
            pictureBox1.Image = Image.FromFile(patharr[0]);
            indexarr[0].BackColor = Color.Orange;
            indexarr[0].ForeColor = Color.Blue;
        }

        private void I_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public string[] patharr = [@"./images/bird.jpg", @"./images/cat.jpg", @"./images/eagle.jpg"];
        private int index = 0;
        public List<Button> indexarr = new();
        public void lb(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            if (lb.Text == ">")
            {
                //if (index == patharr.Length - 1) index = 0;
                //else index++;
                index = index == patharr.Length - 1 ? 0 : (++index);
                pictureBox1.Image = Image.FromFile(patharr[index]);
                //indexarr.ForEach(i =>
                //{
                //    i.BackColor = Color.White;
                //    i.ForeColor= Color.Black;
                //});
                //indexarr[index].BackColor = Color.Orange;
                //indexarr[index].ForeColor = Color.Blue;
                lunbo();
            }
            else
            {
                index = index == 0 ? patharr.Length - 1 : (--index);
                pictureBox1.Image = Image.FromFile(patharr[index]);
                //indexarr.ForEach(i =>
                //{
                //    i.BackColor = Color.White;
                //    i.ForeColor = Color.Black;
                //});
                //indexarr[index].BackColor = Color.Orange;
                //indexarr[index].ForeColor = Color.Blue;
                lunbo();
            }

        }
        public void bt(object sender, EventArgs e)
        {
            index = indexarr.IndexOf((Button)sender);
            pictureBox1.Image=Image.FromFile(patharr[indexarr.IndexOf((Button)sender)]);
            //indexarr.ForEach(i =>
            //{
            //    i.BackColor = Color.White;
            //    i.ForeColor = Color.Black;
            //});
            //indexarr[index].BackColor = Color.Orange;
            //indexarr[index].ForeColor = Color.Blue;
            lunbo();
        }
        public void lunbo()
        {
            indexarr.ForEach(i =>
            {
                i.BackColor = Color.White;
                i.ForeColor = Color.Black;
            });
            indexarr[index].BackColor = Color.Orange;
            indexarr[index].ForeColor = Color.Blue;
        }
    }
}
