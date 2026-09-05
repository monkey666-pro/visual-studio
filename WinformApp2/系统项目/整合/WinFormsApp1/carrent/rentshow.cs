using AntdUI;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.customer;

namespace WinFormsApp1.carrent
{
    public partial class rentshow : Form
    {
        private Mysql rentsql = new Mysql("text");
        public rentshow()
        {

            //车辆id、客户id、租车时间
            //展示车id、车牌号、状态、费用
            InitializeComponent();
            show();
            table1.CellButtonClick += Table1_CellButtonClick;
        }

        private void Table1_CellButtonClick(object sender, TableButtonEventArgs e)
        {
            
        }

        public async void show()
        {
            string operate = "select * from car where isborrow=1";
           await rentsql.ConAndHandler(operate, cmd =>
            {
                MySqlDataAdapter res=new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                res.Fill(dt);
                table1.DataSource = dt;
                showcolumn();
                return true;
            });
        }
        public void showcolumn()
        {
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
                new AntdUI.Column("hourrent","时租/小时"),
                new AntdUI.Column("isborrow","出租情况")
                {
                   Render=(object val,object cal,int rowindex)=>cal.ToString()=="1"?"已出租":"空闲中"
                },
                new AntdUI.Column("operate","操作"){Render=(object val,object cel,int rowindex)=> new AntdUI.CellButton[]
                {
                    new AntdUI.CellButton("rental","借车",AntdUI.TTypeMini.Success),
                } }
            };
        }
    }
    

}
