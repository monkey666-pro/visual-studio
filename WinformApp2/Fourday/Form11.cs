using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fourday
{
    public partial class Form11 : Form
    {
        private string[] arr = ["1111", "2222", "3333", "4444", "555", "6666", "7777", "11122", "222333", "333444", "44455", "666777"];

        public Form11()
        {
            InitializeComponent();
            textBox1.TextChanged += lb;
            listBox1.Items.AddRange(arr);
            listBox1.SelectedIndexChanged += ls;

        }
        public void ls(object sender,EventArgs e)
        {
            label1.Text = listBox1.SelectedItem.ToString();
        }
        public void lb(object sender, EventArgs e)
        {
            
            //获取内容，遍历列表是否包含，包含就用新的list输出
            string neiro = ((TextBox)sender).Text;
           
            List<string> newlist = arr.ToList().FindAll(i => i.Contains(neiro));
            listBox1.Items.Clear();
            foreach (var item in newlist)
            {
                listBox1.Items.Add(item);
            }


        }
    }
}
