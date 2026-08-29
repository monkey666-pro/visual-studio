using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fiveday
{
    public partial class Form5 : Form
    {

       public List<count> list = new();

        public Form5()
        {
            InitializeComponent();

            comboBox1.SelectedIndexChanged += ss;
            list.AddRange
                ([
                new count("红色",Color.Red),
                new count("橙色",Color.Orange),
                new count("黄色",Color.Yellow),
                new count("绿色",Color.Green),
                new count("青色",Color.Cyan),
                new count("蓝色",Color.Blue),
                new count("紫色",Color.Purple),
                ]);
            comboBox1.Items.AddRange(list.Select(i => i.Color).ToArray());
        }
        public void ss(object sender, EventArgs e)
        {
            string name = (sender as ComboBox).SelectedItem.ToString();
            Color a = list.Find(i => i.Color == name).Name;
            this.BackColor= a;
        }
    }
    public class count
    {
        public string Color;
        public Color Name;
        public count(string color, Color name)
        {
            Color = color;
            Name = name;
        }
    }
}
