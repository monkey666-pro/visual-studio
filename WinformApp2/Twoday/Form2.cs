using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Twoday
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            into();
        }
        //先搞定图片地址
        public string[] patharr = [@"./images/eagle.jpg", @"./images/bird.jpg", @"./images/cat.jpg"];
        public void into()
        {
            pictureBox1.Image = Image.FromFile(patharr[0]);
            tableLayoutPanel1.Controls[2].BackColor = Color.Cyan;
            tableLayoutPanel1.Controls[2].ForeColor = Color.White;
            //绑定
            for (int i=0;i<tableLayoutPanel1.Controls.Count;i++)
            {
                tableLayoutPanel1.Controls[i].Click += able;
            }

        }
        //绑定方法
        public void able(object senser, EventArgs e)
        {
            //全部还原属性
            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                tableLayoutPanel1.Controls[i].BackColor = Color.LightGray;
                tableLayoutPanel1.Controls[i].ForeColor= Color.Black;
            }
            //当前按钮的配置
            Button able = (Button)senser;
            able.BackColor = Color.Brown;
            able.ForeColor = Color.Blue;
            //对应照片
            int index = tableLayoutPanel1.Controls.IndexOf(able);
            pictureBox1.Image = Image.FromFile(patharr[index]);
        }
    }
}
