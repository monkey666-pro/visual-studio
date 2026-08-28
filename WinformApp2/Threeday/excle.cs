using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Threeday
{
    public partial class excle : Form
    {
        public excle()
        {
            InitializeComponent();
            textBox1.KeyUp += tb;

        }
        public void tb(object sender, KeyEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if(e.KeyCode==Keys.Enter)
            MessageBox.Show(tb.Text);
        }
    }
}
