using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fiveday
{
    public partial class Form6 : Form
    {
        public List<Dictionary<string,dynamic>>list=new();
        public Form6()
        {
            InitializeComponent();
            list = new()
            {
                new Dictionary<string, dynamic>()
                {
                    ["id"]=1,
                    ["name"]="广东省",
                    ["parentid"]=0
                },
                  new Dictionary<string, dynamic>()
                {
                    ["id"]=2,
                    ["name"]="深圳市",
                    ["parentid"]=1
                },
                  new Dictionary<string, dynamic>()
                {
                    ["id"]=3,
                    ["name"]="广州市",
                    ["parentid"]=1

                },
                   new Dictionary<string, dynamic>()
                {
                    ["id"]=4,
                    ["name"]="广西省",
                    ["parentid"]=0

                },
                  new Dictionary<string, dynamic>()
                {
                    ["id"]=5,
                    ["name"]="柳州市",
                    ["parentid"]=4

                }
            };
            comboBox1.SelectedIndexChanged += cb;
            //将com1显示的省份挑出来再添加到com1
            List<Dictionary<string, dynamic>> list1 = list.FindAll(i => i["parentid"] == 0);
            var newlist = list1.Select(i => i["name"]);
            comboBox1.Items.AddRange(newlist.ToArray());
            comboBox1.Text = ("请选择省份");
            comboBox2.Text=("请选择城市");
        }
        public void cb(object sender, EventArgs e)
        {
            string text = comboBox1.SelectedItem.ToString();
            //得到对应省份后，挑选出市parentid和省id一致的市区，再用新的list装再筛选出市区名字addrange
           Dictionary<string, dynamic> shilist = list.Find(i => i["name"] == text);
            List<Dictionary<string, dynamic>> newshi = list.FindAll(i => i["parentid"] == shilist["id"]);
            var final = newshi.Select(i => i["name"]);
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(final.ToArray());
        }
    }
}
