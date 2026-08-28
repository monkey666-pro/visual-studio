using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Threeday
{
    public partial class jiaodiangaoliang : Form
    {
        public jiaodiangaoliang()
        {
            InitializeComponent();
            into();


        }
        public void into()
        { button1.Leave += bt1;
            button1.GotFocus += bt;
           
            textBox1.GotFocus += tb;
            textBox1.Leave += tb1;
        }

        public void bt1(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            bt.BackColor = Color.White;
        }
        public void tb1(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.BackColor = Color.White;
        }
        public void bt(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            bt.BackColor = Color.Orange;
        }
        public void tb(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.BackColor = Color.Orange;
        }


    }
}
