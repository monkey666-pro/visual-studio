using AntdUI;
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
    public partial class carshow : Form
    {
        private Mysql showsql = new Mysql("text");
        public carshow()
        {
            InitializeComponent();
            show();
        }
        public async Task show()
        {
            string showoperate = "select * from car";
            await showsql.ConAndHandler(showoperate, cmd =>
              {
                  MySqlDataAdapter Ada = new MySqlDataAdapter(cmd);// 创建适配器
                  DataTable dt = new DataTable();// 创建内存表
                  Ada.Fill(dt);
                  table1.DataSource = dt;
                  settable();
                  table1.CellButtonClick += Table1_CellButtonClick;
                  return true;
              });
        }
        private void settable()
        {
            //清空表头-添加表头并增加内容-调整格式
            table1.Columns.Clear();
            table1.Bordered = true;
            table1.Radius = 4;

            table1.ForeColor = Color.Black;
            //table1.AutoSizeColumnsMode = ColumnsMode.Auto;//列自动拉伸
            table1.AutoSizeColumnsMode = ColumnsMode.Fill;
            table1.Columns = new AntdUI.ColumnCollection
            {
                new AntdUI.Column("id","编号"){ Render=(object val,object cel,int rowindex)=>rowindex+1},
                new AntdUI.Column("carnumber","车牌号"),
                new AntdUI.Column("type","类型"),
                new AntdUI.Column("hourrent","时租费"),
                new AntdUI.Column("isborrow","出租情况")
                {
                   Render=(object val,object cal,int rowindex)=>cal.ToString()=="1"?"已出租":"空闲中"
                },
                new AntdUI.Column("operate","操作"){Render=(object val,object cel,int rowindex)=> new AntdUI.CellButton[]
                {
                    new AntdUI.CellButton("rental","删除车辆",AntdUI.TTypeMini.Success),
                    new AntdUI.CellButton("return","编辑车辆",AntdUI.TTypeMini.Success)
                } }
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            caradd add = new caradd();
            add.Show();
            this.Hide();
            add.FormClosing += Add_FormClosing;
        }

        private void Add_FormClosing(object? sender, FormClosingEventArgs e)
        {
            this.Show();
            show();
        }
        private string id = "";
        private async void Table1_CellButtonClick(object? sender, TableButtonEventArgs e)
        {
            System.Data.DataRow car = e.Record as System.Data.DataRow;
           
            if (e.Btn.Text == "编辑车辆")
            {
                //获取车辆id并核对租车状态
                caredit edit=new caredit(car["isborrow"].ToString());
                //展示编辑界面

                //先收起本界面
                this.Hide();
                //当借车完成后关闭界面并更新表格数据，所以要绑定事件
                edit.FormClosing += Edit_FormClosing;//页面关闭前要更新列表数据
            }
            if (e.Btn.Text == "删除车辆")
            {
                id = car["id"].ToString();
                //先提示
                DialogResult res= MessageBox.Show("确定要删除该车辆？","删除车辆",MessageBoxButtons.YesNoCancel);
                //根据id或车牌进行数据库删除，然后更新界面
                if (res == DialogResult.Yes)
                {
                    string deloperate = "delete from car where id=@id";
                  await  showsql.ConAndHandler(deloperate, cmd =>
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        int row = cmd.ExecuteNonQuery();
                        if (row > 0)
                        {
                            MessageBox.Show("删除成功");
                            show();
                        }
                        else MessageBox.Show("删除失败");
                        return true;
                    });
                }
               
            }
        }

        private void Edit_FormClosing(object? sender, FormClosingEventArgs e)
        {
            this.Show();
            show();
        }
    }
}
