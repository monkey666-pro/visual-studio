using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            InitTotal();
        }
        private List<Dictionary<string, Control>> ConList = [];
        private void InitTotal()
        {
            /* 功能: 
                 每个输入框 数量变化则 总计统计结果 变化
                    - 输入框的数量 * 单价 得到这一行的 小计
                    - 因为有多行,每一个的数量和单价 需要一一对应起来
                        + 将单价的控件和数量的控件 一起组合 成一个字典(对象)
                        + 多个行的组合字典  放到list中
             */
            // 初始化 将 单价控件和数量控件 组合的字典 添加到 ConList 
            ConList.Add(new Dictionary<string, Control>
            {
                ["price"] = label6,
                ["count"] = textBox1,
                ["reduceBtn"] = button1,
                ["addBtn"] = button2,
            });
            ConList.Add(new Dictionary<string, Control>
            {
                ["price"] = label8,
                ["count"] = textBox2,
                ["reduceBtn"] = button3,
                ["addBtn"] = button4,
            });
            // 初始化 的 进行统计
            GetTotal();
            //遍历给输入框绑定事件
            ConList.ForEach(tb => tb["count"].TextChanged += TextChanged);
            // 给所有的+按钮绑定点击事件
            ConList.ForEach(tb => tb["addBtn"].Click += Add);
            ConList.ForEach(tb => tb["reduceBtn"].Click += Reduce);
        }
        private void Add(object sender, EventArgs e)
        {
            // 点击的按钮 ===> sender as Button
            // 在ConList中找到 这个按钮对应的字典
            Dictionary<string, Control> dic = ConList.Find(item => item["addBtn"] == (sender as Button));
            if (string.IsNullOrEmpty(dic["count"].Text))
            {
                dic["count"].Text = "0";
                (dic["count"] as TextBox).SelectionStart = 1;
            }
            // 获取数量
            int n = int.Parse(dic["count"].Text);
            dic["count"].Text = (++n).ToString();
        }

        private void Reduce(object sender, EventArgs e)
        {
            // 点击的按钮 ===> sender as Button
            // 在ConList中找到 这个按钮对应的字典
            Dictionary<string, Control> dic = ConList.Find(item => item["reduceBtn"] == (sender as Button));            
            if (string.IsNullOrEmpty(dic["count"].Text))
            {
                dic["count"].Text = "0";
                (dic["count"] as TextBox).SelectionStart = 1;
            }
            // 获取数量
            int n = int.Parse(dic["count"].Text);
            if (n <= 0) return;
            dic["count"].Text = (--n).ToString();
        }

        private void TextChanged(object sender, EventArgs e)
        {
            GetTotal();
        }

        // 统计总价方法
        private void GetTotal()
        {
            // 遍历ConList 直接计算总价
            int sum = 0;

            ConList.ForEach(item =>
            {
                // item是每一个字典 { ["price"]=单价控件,["count"] = 数量控件}
                if (string.IsNullOrEmpty(item["count"].Text)) return;
                else if (!Regex.IsMatch(item["count"].Text, @"^[1-9]\d*$"))
                {
                    item["count"].Text = "0";
                    (item["count"] as TextBox).SelectionStart = 1;
                }
                int price = int.Parse(item["price"].Text);
                int count = int.Parse(item["count"].Text);
                sum += price * count; // 累加当前这一行的 小计结果 
            });

            // 将统计结果给totalLab 展示
            totalLab.Text = sum.ToString();
        }






    }
}
