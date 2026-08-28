using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            InitLimtLength(); // 限制最大输入长度
            InitFilterList(); // 列表框数据过滤
            //button1.Click += Button1_Click; // 演示 列表数据集合的操作
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // 列表.Items 获取列表框数据集合
            // 列表.Items.Add() 给列表集合添加数据
            //listBox1.Items.Add("P");
            //listBox1.Items.AddRange(["X","Y","Z"]); // 添加多个
            listBox1.Items.Clear();  // 清空

            string str = "";
            foreach (var item in listBox1.Items)
            {
                str += item.ToString() + "-";
            }
            MessageBox.Show(str);

        }

        private string[] strArr = ["1111", "2222", "3333", "4444", "555", "6666", "7777", "11122", "222333", "333444", "44455", "666777"];
        private void InitFilterList()
        {
            // 给列表 初始化数据            
            // 将数据添加到 列表集合中
            listBox1.Items.AddRange(strArr);
            // 输入框过滤数据===> 给输入框绑定 内容改变事件
            textBox2.TextChanged += TextBox2_TextChanged;

            // 给列表绑定一个 选中项改变事件
            listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 对于列表集合中选中项获取:   列表.SelectedItem
            selectedLab.Text = listBox1.SelectedItem.ToString();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            // 获取输入的内容  作为过滤的数据 
            string keyWords = (sender as TextBox).Text;
            // 使用keyWords 对 strArr 进过滤
            List<string> resList =  strArr.ToList().FindAll(item => item.Contains(keyWords));

            // 先清空 列表集合
            listBox1.Items.Clear();

            // 将过滤后的数据 添加到 列表集合中
            listBox1.Items.AddRange(resList.ToArray());
        }

        private int MaxLength = 10; // 最大长度10
        private void InitLimtLength()
        {
            // 限制输入框的输入长度:
            // 每次内容改变都检查 内容是否超过长度
            //   超过长度则 提示, 并且将最大长度内容 放回到输入框
            // 1234567890 
            // 1234567890123 ====>  1234567890
            // 输入框内容改变事件: TextChanged, 只要内容变化了则触发
            textBox1.TextChanged += TextBox1_TextChanged;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            // 获取输入框中的内容 并判断长度
            if (tb.Text.Length >= MaxLength)
            {
                // 此时内容长度超过了
                // 提示
                tipsLab.Visible = true;
                // 截取最长内容
                string maxContent = tb.Text.Substring(0, MaxLength);
                // 将截取的最长内容 放回到输入框
                tb.Text = maxContent;
                // 将输入框 整个文本内容 替换为别的 长字符串内容后 输入框的光标会跑到最前面
                // 内容回填后需要将光标复位
                // 设置输入框光标位置: 输入框.SelectionStart = 位置数字
                textBox1.SelectionStart = MaxLength;
            }
            else
            {
                tipsLab.Visible = false;
            }


        }
    }
}
