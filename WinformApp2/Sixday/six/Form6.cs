using six.a;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace six
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addbook add = new addbook();
            add.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            editbook edit = new editbook();
            edit.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            delbook del = new delbook();
            del.Show();
        }
    }
}
