using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace six
{
    public partial class Form4 : Form
    {
        public string mytext { get; set; }
        public Form4()
        {
            InitializeComponent();
            //UserControl user = new UserControl()
            //{
            //    Location = new Point(200, 200),
            //    Size = new Size(100, 100)
            //};
            //this.Controls.Add(user);
            label1.Text = mytext;
        }
        public void form2(object sender, EventArgs e)
        {
       
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
           
        }
    }
}
