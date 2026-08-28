using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{

    public partial class LunBoTu : Form
    {
        private string[] picArr = [@"./images/bird.jpg", @"./images/cat.jpg", @"./images/eagle.jpg",];
        private int index = 0;
        private List<Button> btnList = new();
        public LunBoTu() // 构造函数 (一般只做赋值)
        {
            InitializeComponent();

            InitLunBo();
        }
        private void InitLunBo()
        {

            // 初始化 将 按钮添加到 btnList中
            btnList.AddRange(button1, button2, button3);

            Label[] labs = [label1, label2];

            foreach (Label lab in labs) lab.Click += Lab_Click;

            foreach (Button btn in btnList) btn.Click += Btn_Click;

            LunBo();

        }
        private void Btn_Click(object sender,EventArgs e)
        {
            //Button btn = (sender as Button);
            //int i = btnList.IndexOf(btn);
            //index = i;
            index = btnList.IndexOf(sender as Button);

            //pictureBox1.Image = Image.FromFile(picArr[index]);

            //btnList.ForEach(btn =>
            //{
            //    btn.BackColor = Color.DarkGray;
            //    btn.ForeColor = Color.Black;
            //});

            //btnList[index].BackColor = Color.Orange;
            //btnList[index].ForeColor = Color.White;
            LunBo();

        }


        private void Lab_Click(object sender, EventArgs e)
        {            
            Label lab = (sender as Label);
            if (lab.Text == ">")
            {
                //if (index == picArr.Length - 1) index = 0;
                //else index++;
                index = (index == picArr.Length - 1) ? 0 : (++index);

                //pictureBox1.Image = Image.FromFile(picArr[index]);

                //btnList.ForEach(btn =>
                //{
                //    btn.BackColor = Color.DarkGray;
                //    btn.ForeColor = Color.Black;
                //});

                //btnList[index].BackColor = Color.Orange;
                //btnList[index].ForeColor = Color.White;

            }
            else
            {
                index = (index == 0) ? picArr.Length - 1 : (--index);
                //pictureBox1.Image = Image.FromFile(picArr[index]);

                //btnList.ForEach(btn =>
                //{
                //    btn.BackColor = Color.DarkGray;
                //    btn.ForeColor = Color.Black;
                //});

                //btnList[index].BackColor = Color.Orange;
                //btnList[index].ForeColor = Color.White;
            }
            //pictureBox1.Image = Image.FromFile(picArr[index]);

            //btnList.ForEach(btn =>
            //{
            //    btn.BackColor = Color.DarkGray;
            //    btn.ForeColor = Color.Black;
            //});

            //btnList[index].BackColor = Color.Orange;
            //btnList[index].ForeColor = Color.White;

            LunBo();
        }
    
        
        private void LunBo()
        {
            pictureBox1.Image = Image.FromFile(picArr[index]);

            btnList.ForEach(btn =>
            {
                btn.BackColor = Color.DarkGray;
                btn.ForeColor = Color.Black;
            });

            btnList[index].BackColor = Color.Orange;
            btnList[index].ForeColor = Color.White;
        }
    }
}
/*
 界面设计: 
    - 一张图片/ 两个Label上一张下一张/三个小按钮
       + 设置属性: 文本, 按钮的背景,label的背景,图片缩放模式
 实现点击轮播
    - 将图片地址存储在 一个数组中
    - 定义一个属性index  存储当前展示图片的地址在数组中的下标
        + 为了让按钮 和 展示图片的下标相对应,可以将按钮一次存储在一个List中
    - 点击下一张/上一张轮播图
       + 给label绑定点击事件,为了方便,可以将label方法数组中
            - 遍历数组 添加事件绑定
       + 事件处理程序中
            - 判断点击的是上一张还是下一张
            - 修改index, 需要注意index的范围
            - 设置图片控件的 Image
            - 让下面按钮高亮跟随(先将所有的全部设置默认样式,设置目标控件高亮)
    - 点击按钮轮播 
       + 循环遍历 按钮List 绑定点击事件
         - 事件处理程序中
            + 获取当前按钮在List中的下标
                - 修改index
                - 设置图片控件的 Image
                - 让按钮高亮跟随
    - 在事件绑定的时候, 也要将图片盒子和按钮高亮设置一个默认的
       + 第一张图展示,第一个按钮高亮 
 
 */


