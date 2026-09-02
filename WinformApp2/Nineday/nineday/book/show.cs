using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace nineday.book
{
    public partial class show : Form
    {
        private sql mysql=new sql("text");
        public show()
        {
            InitializeComponent();
            mysql = new sql("text");
            showsql();
            this.FormClosing += Show_FormClosing;
        }

        private void Show_FormClosing(object? sender, FormClosingEventArgs e)
        {
            InitializeComponent();
            showsql();
            table1.CellClick += Table1_CellClick;
        }

        private void Table1_CellClick(object sender, AntdUI.TableClickEventArgs e)
        {
            System.Data.DataRow people = e.Record as System.Data.DataRow;
            if (e.ColumnIndex == 3)
            {
                DialogResult res = MessageBox.Show("辞退还是更新？\nyes:辞退 no：更新", "员工处理",MessageBoxButtons.YesNoCancel);
                if (res == DialogResult.Yes)
                {
                    
                }
            }
        }

        public void showsql()
        {
            //展示数据--查询数据-创建命令对象-适配器-展示
            mysql.connectoprate("select * from Employee", cmd =>
            {
                MySqlDataAdapter adapter=new MySqlDataAdapter(cmd);
                DataTable data=new DataTable();
                adapter.Fill(data);
                table1.DataSource = data;
                tableshow();
            });
            
        }
        public void tableshow()
        {
            table1.Columns.Clear();// 先清除
            table1.Bordered = true;
            table1.Radius = 4;
            table1.Columns = new AntdUI.ColumnCollection()
            {
                new AntdUI.Column("id","编号"){
                    Render=(object val,object cel,int rowIndex )=> rowIndex+1
                },
                new AntdUI.Column("department","部门"),
                new AntdUI.Column("salary","薪资"),
            };
            var HandlerCol = new AntdUI.Column("handler", "操作");
            HandlerCol.Render = (object val, object cel, int index) => "辞退 | 更改";
            table1.Columns.Add(HandlerCol);
        }

    }
}
