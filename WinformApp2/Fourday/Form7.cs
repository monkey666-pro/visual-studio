using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fourday
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            into();

        }
        public void into()
        {
            textBox1.KeyDown += tb;
        }
        public void tb(object sender ,KeyEventArgs e)
        {
            if (e.KeyCode == Keys.X && e.Control)
            {
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}
