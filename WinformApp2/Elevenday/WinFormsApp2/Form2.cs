using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            // 创建文件打开实例
            using (OpenFileDialog OFD = new OpenFileDialog())
            {
                // 配置文件打开的 : 标题,过滤器,是否多选择
                OFD.Title = "你要打开文件了";
                OFD.Filter = "图片|*.png|图像|*.jpg;*.jpeg;*.webp|所有|*.*";
                OFD.FilterIndex = 2; // 过滤默认展示第一个
                // 设置 默认打开的文件夹
                OFD.InitialDirectory = Application.StartupPath; // 项目启动路径

                DialogResult res = OFD.ShowDialog(); // 打开文件选择对话框
                //MessageBox.Show(res.ToString());
                if (res == DialogResult.OK)
                {
                    //MessageBox.Show(OFD.FileName);
                    pictureBox1.Image = Image.FromFile(OFD.FileName);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 创建文件打开实例
            using (OpenFileDialog OFD = new OpenFileDialog())
            {
                // 配置文件打开的 : 标题,过滤器,是否多选择
                OFD.Title = "你要打开文件了";
                OFD.Filter = "图片|*.png|图像|*.jpg;*.jpeg;*.webp|所有|*.*";
                OFD.FilterIndex = 2; // 过滤默认展示第一个
                // 设置 默认打开的文件夹
                //OFD.InitialDirectory = Application.StartupPath; // 项目启动路径
                OFD.Multiselect = true; // 开启文件多选

                DialogResult res = OFD.ShowDialog(); // 打开文件选择对话框
                //MessageBox.Show(res.ToString());
                if (res == DialogResult.OK)
                {
                    //MessageBox.Show(string.Join('-', OFD.FileNames));
                    string[] pics = OFD.FileNames;
                    for (int i = 0; i < pics.Length; i++)
                    {
                        var p = new PictureBox()
                        {
                            Image = Image.FromFile(pics[i]),
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Size = new Size(100, 140),
                            Location = new Point(i * 105, 200)
                        };
                        this.Controls.Add(p);
                    }

                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog SFD = new SaveFileDialog())
            {
                SFD.Title = "你要好好保存内容哦";
                SFD.Filter = "文档|*.txt;*.md|文件|*.*";

                SFD.OverwritePrompt = false;
                SFD.DefaultExt = "md";
                SFD.AddExtension = true;

                // SFD.ShowDialog() // 打开目录保存文件对话框
                if (SFD.ShowDialog() == DialogResult.OK)
                {
                    // 点击确定 则 保存文件
                    //MessageBox.Show(SFD.FileName);
                    File.WriteAllText(SFD.FileName, "123456abc");

                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog FBD = new FolderBrowserDialog())
            {
                FBD.Description = "好好看看文件夹的地址";
                FBD.SelectedPath = Application.StartupPath;
                if (FBD.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show(FBD.SelectedPath);                    
                }

            }
        }
    }
}
