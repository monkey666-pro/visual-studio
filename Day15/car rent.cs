using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static Day15.user;

namespace Day15
{
    internal class car_rent//管理车俩信息
    {
        private string Path { get; } = "./rentreturn.json";//提前初始化地址，不用program直接使用
        private JsonSerializerOptions Jsonopt { get; } = new JsonSerializerOptions()
        {
            WriteIndented = true,
            AllowTrailingCommas = true,
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        };
        public void rent()
        {
            //先通过id去car类进行车辆的租借标记，将car中的false(已借)的数据序列化进行输出
            List<user> lists = new();
            Console.WriteLine("请输入车辆ID");
            int carid = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入客户id");
            int costomserid = int.Parse(Console.ReadLine());
            carmaneger cm = new carmaneger();
            var ( res, res1)  = cm.rentcar(carid);
            if (!res1)
            {
                Console.WriteLine("车辆id有误");
                return;
            }
            car_costomer um = new car_costomer();
            //进入客户类进行客户id判断
            //将客户类输出的结果进行判断，如果存在则继续，反之return

            car_costomer rm =new car_costomer();//将数据进行代入、进行序列化再上传

            var (cos, cos1) = rm.rentuser(costomserid);
            if (!res1)
            {
                Console.WriteLine("无该客户id");
                return;
            }
            List<rentreturn> list = new();
            var renttime = DateTime.Now.ToString();
            var renttime1 = DateTime.Now;
            int id = lists.Count == 0 ? 1 : lists[lists.Count - 1].Id + 1;
            rentreturn rm1 = new rentreturn(id,costomserid,carid,renttime,"",0);
            list.Add(rm1);
            var json=JsonSerializer.Serialize(list,Jsonopt);
            File.WriteAllText(Path, json);
            Console.WriteLine("租车成功！！");
        }
        public void rerurn()
        {
            List<user> lists = new();
            Console.WriteLine("请输入车辆ID");
            int carid = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入客户id");
            int costomserid = int.Parse(Console.ReadLine());
            carmaneger cm = new carmaneger();
            var (res, res1) = cm.return1(carid);
            if (!res)
            {
                Console.WriteLine("车辆id有误");
                return;
            }
            //核实客户id
            var json=File.ReadAllText(Path);
            var ress = JsonSerializer.Deserialize<List<rentreturn>>(json);
            var ress1 = ress.Find(i => i.Costomerid == costomserid);
            if (ress1.Costomerid!=costomserid)
            {
                Console.WriteLine("客户id不存在");
                return;
            }
            if (ress1.Returntime!="")
            {
                Console.WriteLine("车已还！");
                return;
             }
            List<rentreturn> list = new();
            //获取还车时间，再通过前面得的借车时间算出钱
            ress1.Returntime = DateTime.Now.ToString();
             
            TimeSpan hourcount = DateTime.Now - DateTime.Parse(ress1.Renttime);
            var restime = hourcount.TotalHours;
            //算钱
            ress1.Hourcount = (double)restime * res1;
            //代入
            var json00 = JsonSerializer.Serialize(ress, Jsonopt);
            File.WriteAllText(Path, json00);
            Console.WriteLine($"还车成功！！费用为{ress1.Hourcount}");
            return;
        }
    }
}
