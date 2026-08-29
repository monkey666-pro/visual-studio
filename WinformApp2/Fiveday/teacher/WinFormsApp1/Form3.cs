using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public class BcColor
    {
        public string Name;
        public Color _Color;
        public BcColor(string Name, Color _Color) {
            this.Name = Name;
            this._Color = _Color;
        }
    }
    public partial class Form3 : Form
    {
        private List<BcColor> ColorList= new ();
        public Form3()
        {
            InitializeComponent();
            // 初始化数据
            ColorList.AddRange([
                new BcColor("红色",Color.Red),
                new BcColor("橙色",Color.Orange),
                new BcColor("黄色",Color.Yellow),
                new BcColor("绿色",Color.Green),
                new BcColor("青色",Color.Cyan),
                new BcColor("蓝色",Color.Blue),
                new BcColor("紫色",Color.Purple),

             ]);
            // 下拉框初始化
            //ColorList.ConvertAll(item => item.Name).ToArray();

            BackColorCb.Items.AddRange(ColorList.ConvertAll(item => item.Name).ToArray());


            BackColorCb.SelectedIndexChanged += Change;
        }
        private void Change(object sender,EventArgs e)
        {
            string name = (sender as ComboBox).SelectedItem.ToString();

            Color c = ColorList.Find(item => item.Name == name)._Color;

            this.BackColor = c;

        }
    }
}
/*
数据模拟
    - 使用字典存储一组颜色: {Name="颜色名称",_Color=对应的颜色枚举}
       + 多个使用List组合
 
 
*/