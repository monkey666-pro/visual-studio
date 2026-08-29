using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using six;

namespace six
{
    public partial class Form5 : Form
    {
        public List<userss> list = new List<userss>();//list存userss类的类型数据
        public Form5()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(list.Count.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.ToString();
            string age = textBox2.Text.ToString();
            user2 user = new user2(name, age);
            flowLayoutPanel1.Controls.Add(user);//将5框得到的内容实例化传到user2中的labletext，再将其传到右边容器中
            string id = Guid.NewGuid().ToString();//随机id
            user.Tag = id;//给子控件一个专属id
            user.tofather += del;//通过子控件的函数，将子控件的tag传递给del
            list.Add(new userss(name, age,id));//将增加的数量通过listcount显示总数量

            
        }
        public void del(string iid)
        {
            list.RemoveAll(i => i.Id == iid);
        }
    }
    public class userss//将输入的内容用类来封装在一起（）
    {
        public string Name;
        public string Age;
        public string Id;
        public userss(string name, string age,string id)
        {
            Name = name;
            Age = age;
            Id = id;
        }
    }
}
