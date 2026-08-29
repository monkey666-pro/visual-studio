using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fiveday
{
    public partial class Form4 : Form
    {
        public Dictionary<string, string[] >Dic = new();
        public Form4()
        {
            InitializeComponent();
            //Dic.Add("广东省",[ "广州市", "深圳市", "佛山市"]);
            Dic["广东省"] =    ["广州市", "深圳市", "佛山市"] ;
            Dic["湖南省"] = ["长沙市", "湘潭市", "永州市" ];
            comboBox1.SelectedIndexChanged += aa;
            comboBox1.Items.AddRange(Dic.Keys.ToArray());
            comboBox1.Text=("请选择省份");
            comboBox2.Text = ("请选择城市");
        }
        public void aa(object sneder, EventArgs e)
        {
            //先获取省放到com1，
            string text = comboBox1.SelectedItem.ToString();
            //在字典中找到对应名字的键名存到新字典，如何显示键值就行了
           string[] Dic1 = Dic.ToList().Find(i => i.Key == text).Value;
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(Dic1);
        }
    }
}
