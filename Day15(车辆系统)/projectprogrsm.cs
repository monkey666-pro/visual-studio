using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Day15
{
    internal class projectprogrsm//便于存储车辆信息的数据类型
    {
        public int Id { get; set; }//id
        public string Card { get; set; }//车牌号
        public string Type { get; set; }//车辆类型
        public bool Status { get; set; }//车辆状态
        public double Price {   get; set; }//每小时费用
        public projectprogrsm(int id,string card, string type, bool status, double price)//方便实例化时设置属性值
        {
            Id = id;
            Card = card;
            Type = type;
            Status = status;
            Price = price;
        }
    }
    internal class user//便于存储车辆信息的数据类型
    {
        public int Id { get; set; }//id
        public string Username { get; set; }//名字
        public string Idcard { get; set; }//身份证
        public string Gender { get; set; }//性别
        public int Phone { get; set; }//手机号
        public string Time { get; set; }//注册时间
        public string Motto { get; set; }//座右铭
        public user(int id, string username, string idcard, string gender, int phone, string time, string motto)//方便实例化时设置属性值
        {
            Id = id;
            Username = username;
            Idcard = idcard;
            Gender = gender;
            Phone = phone;
            Time = time;
            Motto = motto;
        }
        internal class rentreturn//便于存储车辆信息的数据类型
        {
            public int Id { get; set; }//id
            public int Carid { get; set; }//车辆id
            public int Costomerid { get; set; }//客户id
            public string Renttime { get; set; }//租时间
            public string Returntime { get; set; }//租时间
            public double Hourcount { get; set; }//钱

            public rentreturn(int id, int carid, int costomerid, string renttime, string returntime,double hourcount)//方便实例化时设置属性值
            {
                Id = id;
                Carid = carid;
                Costomerid = costomerid;
                Renttime = renttime;
                Returntime = returntime;
                Hourcount = hourcount;

            }

        }
    }
}
