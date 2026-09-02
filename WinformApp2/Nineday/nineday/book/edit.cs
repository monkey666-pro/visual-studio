using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace nineday.book
{
    public partial class edit : Form
    {
        private sql mysql = new sql("text");
        public edit()
        {
            InitializeComponent();
        }
    }
}
