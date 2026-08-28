using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Twoday
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            into();
        }
        public void into()
        {
            button1.Text = "OFF";
            pictureBox1.Image = Image.FromFile(@"./images/off.png");
            button1.Click += able;

        }
        public void able(object senser, EventArgs e)
        {
            Button btn = (Button)senser;
            if (btn.Text == "ON")
            {
               
                pictureBox1.Image = Image.FromFile(@"./images/off.png");
                btn.Text = "OFF";
            }
            else 
            {
               
                pictureBox1.Image = Image.FromFile(@"./images/on.png");
                btn.Text = "ON";
            }
        }


    }
}
