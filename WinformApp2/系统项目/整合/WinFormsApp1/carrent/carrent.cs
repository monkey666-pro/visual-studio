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
    public partial class carrent : Form
    {
        private Mysql rentsql = new Mysql("text");
        public carrent()
        {

            //车辆id、客户id、租车时间
            //展示车id、车牌号、状态、费用
            InitializeComponent();
            show();
            table1.CellButtonClick += Table1_CellButtonClick;
        }
        public string customerid = "";
       public DateTime now = DateTime.Now;
        public double hour = 0.0;

        private async void Table1_CellButtonClick(object sender, TableButtonEventArgs e)
        {
            customerid = input1.Text;
            if (customerid == "")
            {
                AntdUI.Message.warn(this, "客户id不能为空", autoClose: 2);
                return;
            }
            string operate2 = "select * from customer where id=@id";
          bool result=  await rentsql.ConAndHandler(operate2, cmd =>
            {
                cmd.Parameters.AddWithValue("@id", customerid);
              MySqlDataReader res=  cmd.ExecuteReader();
                if (!res.Read()) return false;
                return true;
            });
            if(result==false)
            {
                AntdUI.Message.warn(this, "没有该客户id", autoClose: 2);
                return;

            }
            System.Data.DataRow rent = e.Record as System.Data.DataRow;
            if (e.Btn.Text == "借车")
            {
                DialogResult res = AntdUI.Modal.open(AntdUI.Modal.config("借车提示", "确定借车吗 ？", AntdUI.TType.Info));
                if (res == DialogResult.OK)
                {
                    string id = rent["id"].ToString();
                     hour = (double)rent["hourrent"];
                    string operate = "update car set isborrow=1 where id=@id";
                    await rentsql.ConAndHandler(operate, cmd =>
                      {
                          cmd.Parameters.AddWithValue("@id", id);
                          int row = cmd.ExecuteNonQuery();
                          if (row > 0)
                          {
                              show();
                              AntdUI.Message.success(this, "借车成功", autoClose: 2);
                              customerid = input1.Text;
                          }

                          return true;
                      });

                }
            }
        }

        public async void show()
        {
            string operate = "select * from car where isborrow=2";
            await rentsql.ConAndHandler(operate, cmd =>
             {
                 MySqlDataAdapter res = new MySqlDataAdapter(cmd);
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

        private void button1_Click(object sender, EventArgs e)
        {
            show();
        }
    }


}
