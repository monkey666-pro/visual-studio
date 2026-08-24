using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Day15
{
    internal class car_costomer
    {
        private string Path { get; } = "./user.json";//提前初始化地址，不用program直接使用
        private JsonSerializerOptions Jsonopt { get; } = new JsonSerializerOptions()
        {
            WriteIndented = true,
            AllowTrailingCommas = true,
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        };
        public void Add()
        {
            List<user> lists = new();
            Console.WriteLine("请输入客户姓名");
            string username = Console.ReadLine();
            Console.WriteLine("请输入身份证");
            string idcard = Console.ReadLine();
            Console.WriteLine("请输入性别");
            string gender = Console.ReadLine();
            Console.WriteLine("请输入手机号");
            int phone = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入座右铭");
            string motto = Console.ReadLine();
            //先创建文件，如果文件已经存在就提取再反序列化
            if (File.Exists(Path))
            {
                var list = File.ReadAllText(Path);
                 lists = JsonSerializer.Deserialize<List<user>>(list);
                if (lists.Exists(i => i.Idcard == idcard))
                {
                    Console.WriteLine("已添加,请勿重新添加！！！");
                    return;
                }
            }
            int id = lists.Count == 0 ? 1 : lists[lists.Count - 1].Id + 1;
            var time=DateTime.Now.ToString();
            user udd = new user(id, username, idcard, gender, phone, time, motto);
            lists.Add(udd);
            var Json = JsonSerializer.Serialize(lists, Jsonopt);
            File.WriteAllText(Path, Json);
            Console.WriteLine("添加成功"); 
        }
        public void SeachAll()
        {
            List<user> list = new();
            //先判断文件是否存在，不存在则提醒，存在则读取反序列化
            if (!File.Exists(Path))
            {
                Console.WriteLine("无数据，请先添加");
                return;
            }
            var json=File.ReadAllText(Path);
            list= JsonSerializer.Deserialize<List<user>>(json);
            //存在则将取到的文件进行遍历输出
            list.ForEach(i => Console.WriteLine($"id:{i.Id}--姓名:{i.Username}--身份证:{i.Idcard}--性别:{i.Gender}--手机号:{i.Phone}--注册时间:{i.Time}"));
        }
        public void SeachOne(int id)
        {
            List<user> list = new();
            //先判断文件是否存在，不存在则提醒，存在则读取反序列化
            if (!File.Exists(Path))
            {
                Console.WriteLine("无数据，请先添加");
                return;
            }
            var json = File.ReadAllText(Path);
            list = JsonSerializer.Deserialize<List<user>>(json);
            //挑选出符合id的数据，进而进行输出
            user one = list.Find(i => i.Id == id);
            if (one == null)
            { Console.WriteLine("!!!!!!数据中无您填写的id，请重新输入!!!!!!!");return; } 
             Console.WriteLine($"id:{one.Id}--姓名:{one.Username}--身份证:{one.Idcard}--性别:{one.Gender}--手机号:{one.Phone}--注册时间:{one.Time}");
        }
        public (string, bool) rentuser(int a)//
        {
            //先读取客户文件，进行反序列化
            var json=File.ReadAllText(Path);
            var res = JsonSerializer.Deserialize<List<user>>(json);
            //判断客户id，如果id不存在则return false，如果存在则true
            var res1 = res.Find(i => i.Id == a);
            if(res1==null) return("没有该客户",false);
            return("ok",true);
        }
        public (string, bool) rentuser1(int a)//
        {
            //先读取客户文件，进行反序列化
            var json = File.ReadAllText(Path);
            var res = JsonSerializer.Deserialize<List<user>>(json);
            //判断客户id，如果id不存在则return false，如果存在则true
            var res1 = res.Find(i => i.Id == a);
            if (res1 == null) return ("没有该客户", false);
            return ("ok", true);
        }
    }
}
