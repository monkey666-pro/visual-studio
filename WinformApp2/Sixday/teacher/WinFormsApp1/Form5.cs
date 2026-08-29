using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.myControl;
namespace WinFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        // 使用list模拟数据库
        private List<User> users = new List<User>();

        // 点击添加按钮
        private void button1_Click(object sender, EventArgs e)
        {
            string uname = textBox1.Text;
            string uage = textBox2.Text;

            UCinfo uci = new UCinfo(uname, uage);
            // uci 就是子控件的实例
            uci.toParent += del; // 将del方法委托为子控件的属性


            // 获取唯一id
            string uid = Guid.NewGuid().ToString();
            // 将用户的唯一id 通过 Tag属性传给 用户控件
            uci.Tag = uid; // Tag 是所有控件都有的属性 给控件存储数据的位置

            // 模拟数据库 ====> 将添加的数据在 users 列表中添加
            users.Add(new User(uname, uage, uid));

            // 界面展示
            flowLayoutPanel1.Controls.Add(uci);
        }
        private void del(string id)
        {
            //MessageBox.Show("我是父容器: "+id);
            // users 去根据id删除
            users.RemoveAll(item => item.uuid == id);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 点击获取 users 长度
            MessageBox.Show(users.Count.ToString());
        }
    }


    public class User
    {
        public string username { get; set; }
        public string userage { get; set; }
        public string uuid {  get; set; }
        public User(string username, string userage,string uuid)
        {
            this.username = username;
            this.userage = userage;
            this.uuid = uuid;

        }
    }
}
