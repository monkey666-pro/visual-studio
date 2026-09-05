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
    public partial class customeredit : Form
    {
        private Mysql editsql = new Mysql("text");
        public customeredit()
        {
            InitializeComponent();
        }
        public string name = "";
        public string idcard = "";

        public customeredit(string name1, string idcard1)
        {
            InitializeComponent();
            //先获取对应的信息，搜索出数据库数据回显
            this.name = name1;
            this.idcard = idcard1;
            show();

        }
        public async void show()
        {
            string operate = "select * from customer where name=@name and idcard=@idcard";
            await editsql.ConAndHandler(operate, cmd =>
             {
                 cmd.Parameters.AddWithValue("@name", name);
                 cmd.Parameters.AddWithValue("@idcard", idcard);
                 MySqlDataReader res = cmd.ExecuteReader();
                 if (!res.Read())
                 {
                     MessageBox.Show("数据库无数据，错误！！");
                     this.Close();
                 }
                 input1.Text = res.GetString("name");
                 input2.Text = res.GetString("idcard");
                 input3.Text = res.GetString("phone");
                 if (res.GetString("gender") == checkbox1.Text) checkbox1.Checked = true;
                 if (res.GetString("gender") == checkbox2.Text) checkbox2.Checked = true;
                 return true;
             });
        }
        public string gender = "";
        private async void button1_Click(object sender, EventArgs e)
        {
           DialogResult res= AntdUI.Modal.open(AntdUI.Modal.config("确认提示", "确定更改？", AntdUI.TType.Warn));
            if (res == DialogResult.OK)
            {
                string operate1 = "update customer set name=@name,idcard=@idcard,phone=@phone,gender=@gender";
                await editsql.ConAndHandler(operate1, cmd =>
                 {
                     if (checkbox1.Checked == true) gender = checkbox1.Text;
                     if (checkbox1.Checked == true) gender = checkbox1.Text;
                     cmd.Parameters.AddWithValue("@name", input1.Text);
                     cmd.Parameters.AddWithValue("@idcard", input2.Text);
                     cmd.Parameters.AddWithValue("@phone", input3.Text);
                     cmd.Parameters.AddWithValue("@gender", gender);
                     int row = cmd.ExecuteNonQuery();
                     if (row > 0)
                     {
                         MessageBox.Show("编辑成功");
                         this.Close();
                     }
                     return true;
                 });
            }
        }

        private void checkbox1_CheckedChanged(object sender, AntdUI.BoolEventArgs e)
        {
             gender = checkbox1.Text;

        }

        private void checkbox2_CheckedChanged(object sender, AntdUI.BoolEventArgs e)//bug
        {
             gender = checkbox2.Text;
        }
        
    }
}
