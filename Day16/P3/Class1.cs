using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace P3
{
    internal class Class1
    {
        private JsonSerializerOptions JsonOpt { get; } = new JsonSerializerOptions
        {
            WriteIndented = true,
            AllowTrailingCommas = true,
            // 在JSON序列化的时候中文不变
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        };
        public string path { get; } = "./emp.json";

        
        public string AddEm()
        {

            Console.WriteLine("请输入员工编号");
            int Id = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入员工姓名");
            string Name = Console.ReadLine();
            Console.WriteLine("请输入员工部门");
            string Department = Console.ReadLine();
            Console.WriteLine("请输入员工薪资");
            double Salary = double.Parse(Console.ReadLine());
            //创建一个空list集合
            List<Employee> list = new();
            //如果存在读文件
            if (File.Exists(this.path))
            {
                var json = File.ReadAllText(this.path);
                list = JsonSerializer.Deserialize<List<Employee>>(json);
            }
            Employee em = new(Id, Name, Department, Salary);
            //判断是否有重复添加
            if (list.Exists(item => item.EmpId == Id)) return "员工已存在，请勿重复添加";
            list.Add(em);
            //序列化,存文件
            var newjson = JsonSerializer.Serialize(list, JsonOpt);
            File.WriteAllText(this.path, newjson);
            return "新增员工成功";
        }
        // 查看全部员工
        public void Searchemp()
        {
            // 判断文件是否存在
            if (!File.Exists(path))
            {
                Console.WriteLine("暂时没有员工，请先添加");
                return;
                    };
            //存在则反序列化进行输出
            string json = File.ReadAllText(path);
            List<Employee> list = JsonSerializer.Deserialize<List<Employee>>(json);
            foreach (var item in list)
            {
                Console.WriteLine($"员工编号：{item.EmpId}------姓名：{item.EmpName}------部门：{item.Department}------薪资：{item.Salary}------");
            }
        }
        // 删除员工
        public string Removeemp()
        {

            List<Employee> list = new();
            Console.WriteLine("请输入删除员工编号");
            int Id = int.Parse(Console.ReadLine());
            if (!File.Exists(this.path)) return "文件不存在，请先添加";
           
            var json = File.ReadAllText(this.path);
            list = JsonSerializer.Deserialize<List<Employee>>(json);
            if (!list.Exists(item => item.EmpId == Id)) return "员工不存在，请重新输入";
            list.RemoveAll(item => item.EmpId == Id);
            var newjson = JsonSerializer.Serialize(list, this.JsonOpt);
            File.WriteAllText(this.path, newjson);
            return "删除成功";
        }
        // 调整薪资
        public string salary() 
        {
            Console.WriteLine("请输入员工编号");
            int EmpId = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入更改的薪资");
            double Salary = double.Parse(Console.ReadLine());
            // 判断文件是否存在
            if (!File.Exists(path)) return "无记录";
            // 存在===> 读取文件====>反序列化===>取对应id员工字典，如果空则提醒，不空则更换薪资并更新文件
            var json = File.ReadAllText(path);
            List<Employee> list = JsonSerializer.Deserialize<List<Employee>>(json);
            Employee res = list.Find(i => i.EmpId == EmpId);
            if (res == null) return "无该员工";
            res.Salary = Salary;
            var json1 = JsonSerializer.Serialize(list, JsonOpt);
            File.WriteAllText(path, json1);
            return "更改成功";
        }
        // 根据薪资筛选员工
        public void salaryemp() 
        {
            //先判断文件是否存在
            List<Employee> list1 = new();
            if (!File.Exists(path))
            {
                Console.WriteLine("无记录");
                return;
            }
            Console.WriteLine("请输入员工薪资范围");
            double Salary = double.Parse(Console.ReadLine());
            //根据t薪资筛选出来，如果没有就提醒，用新list输出
            var json = File.ReadAllText(path);
            List<Employee> list = JsonSerializer.Deserialize<List<Employee>>(json);
            list1 = list.FindAll(i => i.Salary > Salary);
            foreach (var item in list1)
            {
                Console.WriteLine($"员工编号：{item.EmpId}------姓名：{item.EmpName}------部门：{item.Department}------薪资：{item.Salary}------");
            }
        }

    }
}
