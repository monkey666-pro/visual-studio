using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace six
{
    public partial class user2 : UserControl
    {
        //public string name { get; set; }
        //public string age { get; set; }
        public user2()
        {
            InitializeComponent();
        }
        public user2(string name, string age)
        {
            InitializeComponent();
            label1.Text = name;
            label2.Text = age;
        }
        public Action<string> tofather;//定义一个能传递一个字符串无返回值函数，用来传递给父控件,

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Parent.Parent.Controls.Remove(button1.Parent);
            tofather(this.Tag.ToString());//调用，将要删除的子控件tag(id)传递给父类del
        }
    }


}
