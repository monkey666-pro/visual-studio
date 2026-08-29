using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            // 初始数据
            PriceCb.Items.AddRange(["升序", "降序"]);
            TimeCb.Items.AddRange(["升序", "降序"]);

            // 绑定事件
            PriceCb.SelectedIndexChanged += Change;
            TimeCb.SelectedIndexChanged += Change;

        }
        private void Change(object sender, EventArgs e)
        {
            ComboBox cb = (sender as ComboBox);
            // 判断是哪个下拉框
            if (cb.Name == "PriceCb")
            {
                // 模拟排序
                if(cb.SelectedItem.ToString() == "升序")
                {
                    MessageBox.Show("按照价格升序排序");
                }
                else
                {
                    MessageBox.Show("按照价格降序排序");
                }
            }
            else
            {
                if (cb.SelectedItem.ToString() == "升序")
                {
                    MessageBox.Show("按照上架时间升序排序");
                }
                else
                {
                    MessageBox.Show("按照上架时间降序排序");
                }
            }
            
        }
    }
}
