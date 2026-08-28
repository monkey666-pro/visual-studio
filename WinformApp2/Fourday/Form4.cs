using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fourday
{
    
    public partial class Form4 : Form
    {
        public string text;
        public int num = 10;
        public  string[] arr = ["111", "222", "333", "444", "555"];
        public Form4()
        {
            InitializeComponent();
            into();
        }
        private void into()
        {
            textBox1.TextChanged += tc;
            listBox1.Items.AddRange(arr);
            textBox2.TextChanged += tt;
        }
        public void tc(object sender, EventArgs e)
        {
            TextBox tx = (TextBox)sender;
            if (tx.Text.Length >= num)
            {
                label2.Visible= true;
                //截取,将到10的字符串装进另一个字符串中，如何就代替
                text= tx.Text.Substring(0,num);
                tx.Text = text;
                tx.SelectionStart=num;
            }
        }
        public void tt(object sender, EventArgs e)
        {
            string key = (sender as TextBox).ToString();
            List<string> res = arr.ToList().FindAll(item => item.Contains(key));

            listBox1.Items.Add(res.ToArray);

        }
    }
}
