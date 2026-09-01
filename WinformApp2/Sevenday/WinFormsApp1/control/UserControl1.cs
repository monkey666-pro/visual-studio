using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1.control
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();

        }
        public UserControl1(string text)
        {
            InitializeComponent();
            button1.Text = text;
            label1.Text = "图书" + text;
        }
        //定义一个事件
        internal event Action<Class2> data;
        private void button1_Click(object sender, EventArgs e)
        {
            data(new Class2()
            {
                Id = Guid.NewGuid().ToString(),
                Name = input1.Text,
                Author = input2.Text,
                Booklable = input3.Text,
                Isborrow = false,
                 Price = double.Parse(input4.Text)
            });


        }
    }
}
