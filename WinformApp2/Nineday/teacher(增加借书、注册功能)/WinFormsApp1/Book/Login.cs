using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1.Book
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private Mysql MySql = new Mysql("text");
        public event Action<string> LoginMark;
        private void button1_Click(object sender, EventArgs e)
        {
            // 点击实现登录

            // 获取数据
            string Name = input1.Text;
            string Pwd = input2.Text;

            // 不为空校验
            if (Name.Trim() == "" || Pwd.Trim() == "")
            {
                MessageBox.Show("用户名或密码不能为空");
                return;
            }

            string sql = "select * from user where username=@username and password=@password";
            string sql1 = "select * from user where username=@username ";
            MySql.ConAndHandler(sql1, Cmd =>
            {
                Cmd.Parameters.AddWithValue("@username", Name);
                MySqlDataReader read = Cmd.ExecuteReader();
                if (!read.HasRows ) MessageBox.Show("用户名不存在，请先注册");
                else
                
                {
                    MySql.ConAndHandler(sql, Cmd =>
                    {
                        Cmd.Parameters.AddWithValue("@username", Name);
                        Cmd.Parameters.AddWithValue("@password", Pwd);

                        MySqlDataReader Reader = Cmd.ExecuteReader();
                        bool isLogin = Reader.Read();
                        if (isLogin)
                        {
                            MessageBox.Show("登录成功");
                            LoginMark.Invoke("已登录");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("用户名或密码错误!!!");
                            LoginMark.Invoke("未登录");
                            this.Close();
                        }
                    });
                }
       
            });
        


        }

        private void button2_Click(object sender, EventArgs e)
        {
            new signup().Show();
        }
    }
}
