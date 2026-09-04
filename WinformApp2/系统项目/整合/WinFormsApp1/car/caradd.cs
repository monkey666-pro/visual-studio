using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1.car
{
    public partial class caradd : Form
    {
        private Mysql addsql = new Mysql("text");
        public caradd()
        {
            InitializeComponent();
            AntdUI.Config.ShowInWindow = true;
        }


        private async void  button1_Click(object sender, EventArgs e)
        {
            string carnumber = input1.Text;
            string cartype = input2.Text;
            double hourent = (double)inputNumber1.Value;
            if (carnumber == "" || cartype == "" || hourent.ToString() == "")
            {
                AntdUI.Message.warn(this, "内容不能为空");
                return;
            }
            
            string addoperate = "insert into car (carnumber,type,hourrent) values(@carnumber,@type,@hourrent)";
            string addoperate1 = "select * from car where carnumber=@carnumber";
            bool res = await addsql.ConAndHandler(addoperate1, cmd =>
            {
                cmd.Parameters.AddWithValue("@carnumber", carnumber);
                MySqlDataReader read=cmd.ExecuteReader();
                if (read.Read())
                {
                    return false;
                }
                    return true;
            });
            if (!res)
            {
                AntdUI.Message.warn(this, "车牌号已存在，请重新输入！");
                return;
            }
            await addsql.ConAndHandler(addoperate, cmd =>
            {
                cmd.Parameters.AddWithValue("@carnumber", carnumber);
                cmd.Parameters.AddWithValue("@type", cartype);
                cmd.Parameters.AddWithValue("@hourrent", hourent);
                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    AntdUI.Message.success(this, "新增成功", autoClose: 1);
                    this.Close();
                }
                else MessageBox.Show("新增失败");
                return true;
            });
        }
    }
}
