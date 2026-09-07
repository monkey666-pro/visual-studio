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
    public partial class carreturn : Form
    {
        private Mysql returnsql = new Mysql("text");
        public carreturn()
        {
            InitializeComponent();
            table1.CellButtonClick += Table1_CellButtonClick;
            show();
        }
        public double hourmoney;
        public string id;
        public double count;
        public DateTime renttime;

        private async void Table1_CellButtonClick(object sender, TableButtonEventArgs e)
        {


                if (e.Btn.Text == "还车")
            {
                DialogResult res = AntdUI.Modal.open(AntdUI.Modal.config("还车提示", "确定结束借车吗 ？", AntdUI.TType.Info));
                if (res == DialogResult.OK)
                {
                    System.Data.DataRow rent = e.Record as System.Data.DataRow;
                    string id = rent["id"].ToString();
                    string operates = "select * from carrent where id=@id";
                    await returnsql.ConAndHandler(operates, cmd =>
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        MySqlDataReader time = cmd.ExecuteReader();
                        if (time.Read())
                        {
                            renttime = (DateTime)time["rentaltime"];
                            hourmoney = time.GetDouble("hourmoney");
                        }
                        return true;
                    });
                    string operate = "update car set isborrow=2 where id=@id";
                  bool a=  await returnsql.ConAndHandler(operate, cmd =>
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        int row = cmd.ExecuteNonQuery();
                        if (row > 0)
                        {
                            show();
                            AntdUI.Message.success(this, "还车成功", autoClose: 2);
                            return false;
                        }

                        return true;
                    });

                    if (a == false)
                    {
                        DateTime nowtime = DateTime.Now;
                        string carid = rent["id"].ToString();
                      await  returnsql.ConAndHandler("update carrent set returntime=@returntime,count=@count where id=@id", cmd=>
                        {
                            TimeSpan restime = renttime - nowtime;
                            var hour = restime.TotalHours;
                            //算钱
                            count = hour * hourmoney;
                            cmd.Parameters.AddWithValue("@returntime", nowtime);
                            cmd.Parameters.AddWithValue("@count", count);
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.ExecuteNonQuery();
                            return true;
                        });
                    }
                }
            }
        }

        public async void show()
        {
            string operate = "select * from car where isborrow=1";
            await returnsql.ConAndHandler(operate, cmd =>
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
                new AntdUI.Column("id","车辆id"),
                new AntdUI.Column("carnumber","车牌号"),
                new AntdUI.Column("type","类型"),
                new AntdUI.Column("hourrent","时租/小时"),
                new AntdUI.Column("isborrow","出租情况")
                {
                   Render=(object val,object cal,int rowindex)=>val.ToString()=="1"?"已出租":"空闲中"
                },
                new AntdUI.Column("operate","操作"){Render=(object val,object cel,int rowindex)=> new AntdUI.CellButton[]
                {
                    new AntdUI.CellButton("rental","还车",AntdUI.TTypeMini.Success),
                } }
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            show();
        }
    }
}
