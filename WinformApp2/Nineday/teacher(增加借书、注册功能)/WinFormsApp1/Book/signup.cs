using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsApp1.Book
{
    public partial class signup : Form
    {
        private Mysql mysql = new Mysql("text");
        public signup()
        {
            InitializeComponent();
            input1.TextChanged += rule;
            input2.TextChanged += rule1;
            button1.Click += Button1_Click;

        }

        private void Button1_Click(object? sender, EventArgs e)
        {
            if (input1.Text.Length >= 3 && input2.Text.Length >= 8 && input2.Text.Length <= 15 && input1.Text.Length <= 10)
            {
                if (input2.Text != input3.Text)
                {
                    MessageBox.Show("密码和确认密码不对");
                    return;
                }
                string name = input1.Text;
                //先进行用户名判断，重复就不添加
                string operate = "select * from user where username=@username limit 1";
                string operate1 = "insert into user (username,password,gender)values(@username,@password,@gender)";
                mysql.ConAndHandler(operate, cmd =>
                {
                    cmd.Parameters.AddWithValue("@username", name);
                    MySqlDataReader read = cmd.ExecuteReader();
                    
                    if (read.HasRows)
                    {
                        MessageBox.Show("用户名已存在！！");
                        return;

                    }
                    else
                    {
                        mysql.ConAndHandler(operate1, cmd =>
                        {
                            cmd.Parameters.AddWithValue("@username", name);
                            cmd.Parameters.AddWithValue("@password", input2.Text.ToString());
                            cmd.Parameters.AddWithValue("@gender", gender);
                            int row = cmd.ExecuteNonQuery();
                            if (row > 0)
                            {
                                MessageBox.Show("成功");
                                this.Close();
                            }
                            else MessageBox.Show("失败");

                        });
                    }
                });

            }
            else
            {
                MessageBox.Show("用户名或密码长度格式错误");
            }
        }

        public void rule(object sender, EventArgs e)
        {

            if (input1.Text.Length < 3)
            {
                label7.ForeColor = Color.Red;
                label7.Visible = true;
            }
            else label7.Visible = false;

        }
        public Color resultcolor;
        public void rule1(object sender, EventArgs e)
        {
            int num = 0;
            string text = input2.Text;
            if (Regex.IsMatch(text, @"\d")) num++;
            if (Regex.IsMatch(text, @"\D")) num++;
            if (Regex.IsMatch(text, @"\W")) num++;
            if (input2.Text.Length >= 8)
            {

                if (num == 1)
                {
                    label8.Text = "弱";
                    resultcolor = Color.Red;
                    label8.Visible = true;

                }
                if (num == 2)
                {
                    label8.Text = "中";
                    resultcolor = Color.Orange;
                    label8.Visible = true;
                }
                if (num == 3)
                {
                    label8.Text = "强";
                    resultcolor = Color.Green;
                    label8.Visible = true;
                }
                label8.ForeColor = resultcolor;
            }
            else label8.Visible = false;
        }

        public string gender = "";
        private void checkbox1_CheckedChanged(object sender, AntdUI.BoolEventArgs e)
        {
            AntdUI.Checkbox gay = (AntdUI.Checkbox)sender;
            gender = gay.Text;
        }

        private void checkbox2_CheckedChanged(object sender, AntdUI.BoolEventArgs e)
        {
            AntdUI.Checkbox mmei = (AntdUI.Checkbox)sender;
            gender = mmei.Text;
        }

        private void signup_Load(object sender, EventArgs e)
        {
            input3.UseSystemPasswordChar = true;
            input2.UseSystemPasswordChar = true;
        }
    }
}
