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
    public partial class carrecord : Form
    {
        private Mysql recordsql = new Mysql("text");
       public string number = "", cusid = "",carid="";
        public double count = 0.0, resmoney = 0.0;
        public DateTime time1, time2;
        public carrecord()
        {
            InitializeComponent();
            carrent rent= new carrent();
            carreturn turn = new carreturn();
            cusid = rent.customerid;
            number = turn.carnumber;
            carid = turn.carid;
            time1 = rent.now;
            time2 = turn.now;
            //借车记录点击后该页面会将借车的信息传过来，不建议在数据库中将二个表的数据进行互通，不方便
            //只需要将借车时间和还车时间设置好就行了，然后再把费用算清就ok了

        }
        public carrecord(DateTime rent,double hourmoney)//借车时间
        {
            InitializeComponent();
            time1 = rent;
            count = hourmoney;
        }
        public  carrecord(string carid, string carnumber,string customerid,DateTime huan)//借车时间，车牌号也是唯一的代替id,客户id
        {
            InitializeComponent();
            this.carid = carid;
            this.number=carnumber;
            this.cusid= customerid;
            time2 = huan;
            add();
        }
        public async void show()
        {
            await recordsql.ConAndHandler("select * from carrent", cmd =>
              {
                  MySqlDataAdapter Ada = new MySqlDataAdapter(cmd);// 创建适配器
                  DataTable dt = new DataTable();// 创建内存表
                  Ada.Fill(dt);
                  table1.DataSource = dt;
                  settable();
                  return true;
              });
        }
        public void settable()
        {
            double count = 0.0;
            table1.Columns.Clear();
            table1.Bordered = true;
            table1.Radius = 4;;
            table1.ForeColor = Color.Black;
            //table1.AutoSizeColumnsMode = ColumnsMode.Auto;//列自动拉伸
            table1.AutoSizeColumnsMode = ColumnsMode.Fill;
            table1.Columns = new AntdUI.ColumnCollection
            {
                new AntdUI.Column("id","车辆id"){  Render=(object val,object cal,int rowindex)=>{ return carid; }},
                new AntdUI.Column("customerid","客户id"){  Render=(object val,object cal,int rowindex)=>{ return cusid; }},
                new AntdUI.Column("carnumber","车牌号"){  Render=(object val,object cal,int rowindex)=>{ return number; }},
                new AntdUI.Column("rent","借车时间"){  Render=(object val,object cal,int rowindex)=>{ return time1; }},
                new AntdUI.Column("return","还车时间"){  Render=(object val,object cal,int rowindex)=>{ return time2; }},
                new AntdUI.Column("count","费用"){  Render=(object val,object cal,int rowindex)=>{ return count; }},
            };
        }
        public async void add()
        {
         await   recordsql.ConAndHandler("insert into customer (id,carnumber,customerid,rentaltime,returntime,count)value (@id,@carnumber,@customerid,@rentaltime,@returntime,@count)", cmd=>
            {
                cmd.Parameters.AddWithValue("@id", carid);
                cmd.Parameters.AddWithValue("@carnumber", number);
                cmd.Parameters.AddWithValue("@customerid", cusid);
                cmd.Parameters.AddWithValue("@rentaltime", time1);
                cmd.Parameters.AddWithValue("@returntime", time2);
                cmd.Parameters.AddWithValue("@count", resmoney);
                
                return true;
            });
            
        }
        public void feiyong()
        {
            TimeSpan restime = time2 - time1;
            var hour = restime.TotalHours;
            //算钱
            resmoney = hour * count;
        }
    }
}
