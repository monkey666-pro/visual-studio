using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Threeday
{
    public partial class wasd : Form
    {
         public int  speed=5 ;
        public wasd()
        {
            InitializeComponent();
            button1.KeyDown += bt;
        }
        public void bt(object sender, KeyEventArgs e)
        {
            Button bt = (Button)sender;
            Point b1 = bt.Location;
            switch (e.KeyCode)
            {
                case Keys.W:
                    b1.Y -= speed;
                    break;
                case Keys.S:
                    b1.Y += speed;
                    break;
                case Keys.A:
                    b1.X -= speed;
                    break;
                case Keys.D:
                    b1.X += speed;
                    break;
            }
            bt.Location = b1;
        }
    }
}
