using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace Fourday
{
    public partial class Form12 : Form
    {
        public List<Dictionary<string, Control>> list = new();
        public Form12()
        {
            InitializeComponent();
            into();
        }
        public void into()
        {
      
            //先用一个列表装textbox
            //将控件有数据的控件加进列表
            list.Add(new Dictionary<string, Control>
            {
                ["price"]=label4,
                ["count"]=textBox1,
                ["-"]=button1,
                ["+"]=button2
            });
            list.Add(new Dictionary<string, Control>
            {
                ["price"] = label6,
                ["count"] = textBox2,
                ["-"] = button3,
                ["+"] = button4
            });
            textBox1.TextChanged += tb;
            textBox2.TextChanged += tb;
            button1.Click += bt;
            button2.Click += bt;
            button3.Click += bt;
            button4.Click += bt;
        }
        public void tb(object sender, EventArgs e)
        {
            int sum = 0;
            list.ForEach(i =>
            {
                int price = int.Parse(i["price"].Text);
                int count = int.Parse(i["count"].Text);
                sum += price * count;
                
            });
            label8.Text ="总价为：" +sum.ToString();
        }
        public void bt(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            list.ForEach(i =>
            {
                if (i["-"] == bt)
                {
                    int count = int.Parse(i["count"].Text);
                    count--;
                    i["count"].Text = count.ToString();
                }
                if (i["+"] == bt)
                {
                    int count = int.Parse(i["count"].Text);
                    count++;
                    i["count"].Text = count.ToString();
                }
            });
        }
    }
}
