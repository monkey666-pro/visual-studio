using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Day15
{
    internal class carmaneger
    {
        //属性：数据存储位置、序列化配置项
        private string Path { get; } = "./car.json";//提前初始化地址，不用program直接使用
        private JsonSerializerOptions Jsonopt { get; } = new JsonSerializerOptions()
        {
            WriteIndented = true,
            AllowTrailingCommas = true,
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        };
        public string Add(string card,string type,string price)//新增车辆方法
        {
            List<projectprogrsm> cars = new();
            //判断文件是否存在（存在、不存在）
            //不存在--定义一个空的list--将接收到的数据组装成car实例对象，添加到list中再序列化
            //存在--定义一个空list--读取文件内容-反序列化赋值给list--添加后写入
            if (File.Exists(Path))
            {
                string jsonstr = File.ReadAllText(this.Path);
                cars = JsonSerializer.Deserialize<List<projectprogrsm>>(jsonstr);
                if(cars.Exists(item => item.Card == card))return("已存在"); ;
            }
            projectprogrsm cadd=new projectprogrsm(cars.Count + 1, card, type, true, double.Parse(price));
            cars.Add(cadd);
            string res=JsonSerializer.Serialize(cars,Jsonopt);
            File.WriteAllText(Path, res);
            return "ok";
        }
        public string SearchAll()//查看车辆信息，方法
        {
            //先判断文件是否存在（存在-读取文件-反序列化-遍历输出）（不存在-return无车辆信息）
            if(!File.Exists(this.Path)) Console.WriteLine("无车信息，请先添加");
            var json=File.ReadAllText(this.Path);
            if (json == null)
            {
                return "无数据";
            }
            List<projectprogrsm> cars = JsonSerializer.Deserialize<List<projectprogrsm>>(json);
            foreach (projectprogrsm i in cars)
            {
                string status = i.Status ? "空闲" : "已借";
                Console.WriteLine($"车id:{i.Id}   车牌：{i.Card}   类型：{i.Type}   状态：{status}  时租费：{i.Price}  ");
            }
            return "ok";
        }
        public void SearchOne(int id)//
        {
            //先判断文件是否存在（存在-读取文件-反序列化-根据id查找具体信息，找不到就提示）（不存在-return无车辆信息）
            if (!File.Exists(this.Path))
            {
                Console.WriteLine("无车信息，请先添加");
                return ;
             } ;
            string json = File.ReadAllText(this.Path);
            List<projectprogrsm> cars = JsonSerializer.Deserialize<List<projectprogrsm>>(json);
             projectprogrsm cars11= cars.Find(item=>item.Id == id);
            if (cars11==null)//如果没有就不输出下面代码
            { Console.WriteLine("无此车数据"); } ;
            string status = cars11.Status ? "空闲" : "已借";
            Console.WriteLine($"车牌：{cars11.Card}  类型：{cars11.Type}  状态：{status}  时租费：{cars11.Price}  "); 
             //Console.WriteLine($"车牌：{cars11.Card}  类型：{cars11.Type}  状态：{cars11.Status}  时租费：{cars11.Price}  ");
            ;//遍历
        }
        public string Searchfree()//查看车辆信息，方法
        {
            //先判断文件是否存在（存在-读取文件-反序列化-挑选-遍历输出）（不存在-return无车辆信息）
            if (!File.Exists(this.Path)) return"无车信息，请先添加";
            var json = File.ReadAllText(this.Path);//读取文件
            List<projectprogrsm> cars = JsonSerializer.Deserialize<List<projectprogrsm>>(json);//反序列化文件
            List<projectprogrsm> cars1 = cars.FindAll(i => i.Status == true);
            if(cars1.Count==0) return"无空闲车辆";
            foreach(dynamic i in cars1) Console.WriteLine($"车牌：{i.Card}  类型：{i.Type}  时租费：{i.Price}  ");//遍历空闲的车
            return "";
        }
        public (string,bool) rentcar(int a)//
        {

            var json = File.ReadAllText(this.Path);//读取文件
            List<projectprogrsm> cars = JsonSerializer.Deserialize<List<projectprogrsm>>(json);//反序列化文件
            //判断有没有车辆id如果没有就给false--有就判断是不是已经借出然后更新文件再上传
            var cars11 = cars.Find(i => i.Id == a);
            if (cars11 == null) return ("没有该车",false);//如果为空则车库里没有该id的车
            if (!cars11.Status) return ("该车已经借出", false);
            cars11.Status = false;
            var json1 = JsonSerializer.Serialize(cars, Jsonopt);
            File.WriteAllText(Path, json1);
            return ("成功",true);
        }
        public (bool, double) return1(int a)
        {
            var json = File.ReadAllText(this.Path);//读取文件
            List<projectprogrsm> cars = JsonSerializer.Deserialize<List<projectprogrsm>>(json);//反序列化文件
            //判断有没有车辆id如果没有就给false--有就判断是不是已经借出然后更新文件再上传
            var cars11 = cars.Find(i => i.Id == a);
            if (cars11 == null) return (false,0 );//如果为空则车库里没有该id的车
            if (cars11.Status) return (true, 0);
            cars11.Status = true;
            var json1 = JsonSerializer.Serialize(cars, Jsonopt);
            File.WriteAllText(Path, json1);
            return(true, cars11.Price);
        }

    }
}
