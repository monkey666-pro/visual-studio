using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1.myControl
{
    public partial class UCText : UserControl
    {
        // 重写 构造函数
        public UCText(string BookName, string AuthorName, string IntroContent)
        {
            InitializeComponent();
            BookLab.Text = BookName;
            authoLab.Text = AuthorName;
            IntroLab.Text = IntroContent;
        }
        public UCText()
        {            
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BookLab.ForeColor = Color.Red;
        }   
    }
}
