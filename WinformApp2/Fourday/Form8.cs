using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fourday
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            into();
        }
        public void into()
        {
            //靠近放大
            //离开还原
            button1.MouseEnter += me;
            button1.MouseLeave += me1;
        }
        public void me(object sneder, EventArgs e)
        {
            //放大：尺寸变大就行了
            button1.Width += 100;
            button1.Height += 100;
        }
        public void me1(object sneder, EventArgs e)
        {
            //放大：尺寸变大就行了
            button1.Width -= 100;
            button1.Height -= 100;
        }
    }
}
