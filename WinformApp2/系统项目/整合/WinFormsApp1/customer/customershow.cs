using AntdUI;
using Microsoft.Extensions.Logging;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.car;

namespace WinFormsApp1.customer
{
    public partial class customershow : Form
    {
        private Mysql customersql = new Mysql("text");
        public customershow()
        {
            InitializeComponent();
            customershows();
            table1.CellButtonClick += Table1_CellButtonClick;
            button1.Click += Button1_Click;
        }

        private void Button1_Click(object? sender, EventArgs e)
        {
            customeradd add = new customeradd();
            add.Show();
            this.Hide();
            add.FormClosing += Add_FormClosing;
        }

        private void Add_FormClosing(object? sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private async void Table1_CellButtonClick(object sender, TableButtonEventArgs e)
        {
              System.Data.DataRow customer=e.Record as System.Data.DataRow;
            if (e.Btn.Text == "删除")
            {
                string id = customer["id"].ToString();
                DialogResult res = AntdUI.Modal.open(new AntdUI.Modal.Config(this, "删除提示", "确定要删除？", AntdUI.TType.Warn) { OkText="删除"});
                if (res == DialogResult.OK)
                {
                    string operate = "delete from customer where id=@id";
                  await  customersql.ConAndHandler(operate, cmd =>
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        int row = cmd.ExecuteNonQuery();
                        if (row > 0) AntdUI.Message.success(this, "删除成功", autoClose: 2);
                        else AntdUI.Message.warn(this, "删除失败", autoClose: 2);
                        customershows();
                        return true;
                    });
                }
            }
            if (e.Btn.Text == "编辑")
            {
               customeredit edit = new customeredit(customer["name"].ToString(), customer["idcard"].ToString());
                edit.Show();
                this.Hide();
                edit.FormClosing += Edit_FormClosing;
            }
        }

        private void Edit_FormClosing(object? sender, FormClosingEventArgs e)
        {
            customershows();
            this.Show();
            
        }

        public async void customershows()
        {
            string operate = "select * from customer";
            await customersql.ConAndHandler(operate, cmd =>
            {
                //适配器
                MySqlDataAdapter table= new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                table.Fill(dt);
               table1.DataSource = dt;
                tablecolumn();
                return true;
            });
            
        }
        public void tablecolumn()
        {
            //先清空表头-新增表头数据-在操作表头设置删除和编辑客户
            table1.Columns.Clear();
            table1.Columns.Clear();
            table1.Bordered = true;
            table1.Radius = 4;

            table1.ForeColor = Color.Black;
            table1.AutoSizeColumnsMode = ColumnsMode.Fill;
            table1.Columns = new AntdUI.ColumnCollection
            {
               new AntdUI.Column("id","编号"){ Render=(object val,object cel,int index)=>index=index+1},
               new AntdUI.Column("name","姓名"),
               new AntdUI.Column("idcard","身份证号"),
               new AntdUI.Column("gender","性别"),
               new AntdUI.Column("phone","手机号"),
                new AntdUI.Column("operate","操作"){ Render=(object val, object cel, int index)=>new AntdUI.CellButton[]
                {
                    new AntdUI.CellButton("del","删除",AntdUI.TTypeMini.Success),
                    new AntdUI.CellButton("edit","编辑",AntdUI.TTypeMini.Warn),
                } }
            };
        }
    }
}
