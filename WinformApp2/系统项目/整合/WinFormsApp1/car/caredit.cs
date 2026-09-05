using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1.car
{
    public partial class caredit : Form
    {
        private Mysql sql = new Mysql("text");
        public caredit()
        {
            InitializeComponent();
            AntdUI.Config.ShowInWindow = true;

        }
        public caredit(string id)
        {
            InitializeComponent();
            this.id = id;
            returnshow();
        }
        public string id = "";
        public async void returnshow()
        {
            //根据id进行信息获取并进行信息回显
            string operate = "select * from car where id=@id";
            await sql.ConAndHandler(operate, cmd =>
            {
                cmd.Parameters.AddWithValue("@id", id);
                var read = cmd.ExecuteReader();
                if (!read.Read())
                {
                    AntdUI.Message.warn(this, "查不到该车信息");
                    return false;
                }
                input1.Text = read.GetString("carnumber");
              input2.Text = read.GetString("type");
                 inputNumber1.Value = (decimal)read.GetDouble("hourrent");
                return true;
            });


        }

        private async void button1_Click(object sender, EventArgs e)
        {
            DialogResult res = AntdUI.Modal.open(new AntdUI.Modal.Config(this, "编辑提示", "请确认信息", AntdUI.TType.Warn)
            {
                OkText = "确认"
            });
            if (res == DialogResult.OK)
            {
                string operate = "update car set carnumber=@carnumber,type=@type,hourrent=@hourrent where id=@id";
                await sql.ConAndHandler(operate, cmd =>
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@carnumber", input1.Text);
                    cmd.Parameters.AddWithValue("@type", input2.Text);
                    cmd.Parameters.AddWithValue("@hourrent", inputNumber1.Value);
                    var row = cmd.ExecuteNonQuery();
                    if (row > 0)
                    {
                        MessageBox.Show("编辑成功！");
                        this.Close();
                        return false;
                    }
                    return true;
                });
            }
        }
    }
}
