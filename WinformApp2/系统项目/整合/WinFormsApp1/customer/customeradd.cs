using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1.customer
{
    public partial class customeradd : Form
    {
        private Mysql addsql = new Mysql("text");
        public customeradd()
        {
            InitializeComponent();

        }
        public string gender = "";
        private async void button1_Click(object sender, EventArgs e)
        {
            if (input1.Text == "" || input2.Text == "" || input3.Text == ""||gender=="")
            {
                AntdUI.Message.warn(this, "内容不能为空", autoClose: 1);
                return;
            }
            string operate = "insert into customer (name,idcard,gender,phone) values(@name,@idcard,@gender,@phone)";
            string operate1 = "select * from customer where name=@name and idcard=@idcard";
           bool res= await addsql.ConAndHandler(operate1, cmd =>
            {
                cmd.Parameters.AddWithValue("name", input1.Text);
                cmd.Parameters.AddWithValue("idcard", input2.Text);
                MySqlDataReader row = cmd.ExecuteReader();
                if (row.Read())
                {
                    return false;
                }
                return true;
            });
            if (!res)
            {
                AntdUI.Message.warn(this, "用户信息重复!!", autoClose: 2);
                return;
            }
            await addsql.ConAndHandler(operate, cmd =>
             {
                 cmd.Parameters.AddWithValue("@name", input1.Text);
                 cmd.Parameters.AddWithValue("@idcard", input2.Text);
                 cmd.Parameters.AddWithValue("@gender",gender);
                 cmd.Parameters.AddWithValue("@phone", input3.Text);
                int row= cmd.ExecuteNonQuery();
                 if (row > 0)
                 {
                     MessageBox.Show("注册成功");
                     this.Close();
                 }

                 return true;
             });
        }

        private void checkbox1_CheckedChanged(object sender, AntdUI.BoolEventArgs e)
        {
            gender = checkbox1.Text;
        }

        private void checkbox2_CheckedChanged(object sender, AntdUI.BoolEventArgs e)
        {
            gender = checkbox2.Text;
        }
    }
}
