using System;
using System.Globalization;
using System.Text.Json;
using System.Xml.Linq;

namespace Day9
{
    delegate void mydelegate(string msg);
    internal class Program
    {
        static void Main(string[] args)
        {
            //委托  多播
            void hello(string name) { Console.WriteLine($"hello{name}"); }
            void hi(string name) { Console.WriteLine($"hi{name}"); }
            void bye(string name) { Console.WriteLine($"bye{name }"); }
            mydelegate del = hi;
            del("密码机");
            del += hello;
            del += bye;
            del("俄国");//多播
            //简便(action)
            void sayhello(string name) { Console.WriteLine($"hello{name}"); }
            void sayhi(string name) { Console.WriteLine($"hi{name}"); }
            Action<string> del1 = sayhello;
            del1 += sayhi;
            del1("能解决");
            //可变数量参数 params
            var getsum = (params int[] n) => 
            {
                int sum = 0;
                foreach (int i in n)
                {
                    sum += i;
                }
                return sum;
             };
            Console.WriteLine(getsum(1, 2, 3, 4));
            //元组
            var aa = ("name", 14, true);
            Console.WriteLine(aa.Item1);
            (string id, int age) aa1 = ("弖", 24);
            Console.WriteLine(aa1.id);
            Console.WriteLine(aa1.age);
            //(int age,string gender ,bool isadult) get()
            //{
            //    int age = int.Parse(Console.ReadLine());
            //    string gender = Console.ReadLine();
            //    bool isadult = age > 18;
            //    return (age, gender, isadult);
            //}
            //var (age,gender, isadult) =get();
            //Console.WriteLine($"{age}{gender}{isadult}");

            //回调函数
            Func<int, int,int > sum = delegate (int a, int b)
            {
                int c = a + b;
                return c;
            };
            Func<int, int, int, Func<int, int, int>, double> sum1 = delegate (int a, int b, int c, Func<int, int, int> sum2)
            {
                int Sum = sum2(a, b);
                double sum1 = (double)Sum / c;
                return sum1;
            };
            double sum3 = sum1(1, 3, 2, sum);
            Console.WriteLine(sum3);

            List<Dictionary<string, dynamic>> list = new() {
    new Dictionary<string, dynamic>(){
        ["name"] = "zs",
        ["age"] = 29,
        ["isMan"] = true,
        ["isSingle"] = true,
        ["salary"] = 4200
    },
    new Dictionary<string, dynamic>(){
        ["name"] = "ls",
        ["age"] = 20,
        ["isMan"] = false,
        ["isSingle"] = true,
        ["salary"] = 3400
    },
    new Dictionary<string, dynamic>(){
        ["name"] = "ww",
        ["age"] = 19,
        ["isMan"] = true,
        ["isSingle"] = false,
        ["salary"] = 6000
    },
    new Dictionary<string, dynamic>(){
        ["name"] = "zl",
        ["age"] = 14,
        ["isMan"] = false,
        ["isSingle"] = true,
        ["salary"] = 2000
    },
    new Dictionary<string, dynamic>(){
        ["name"] = "sq",
        ["age"] = 35,
        ["isMan"] = true,
        ["isSingle"] = false,
        ["salary"] = 7000
    },
    new Dictionary<string, dynamic>(){
        ["name"] = "zb",
        ["age"] = 27,
        ["isMan"] = false,
        ["isSingle"] = true,
        ["salary"] = 2900
    },
};
            //作业1// Find: 要求查找年龄小于20的

            var a1 = list.Find(n =>
            {
                return n["age"] < 20;
                
            });
           // foreach(dynamic i in a1) Console.WriteLine(i);
            var a2 = list.FindAll(n => n["age"]<20);
            var option = new JsonSerializerOptions
            {
                WriteIndented = true,
                AllowTrailingCommas = true,
            };
            string json = JsonSerializer.Serialize(a2, option);
           // Console.WriteLine(json);
            // FindLast: 要求查找年龄大于25的
            var a3 = list.FindAll(n =>
            {

                return n["age"] > 25;
            });
            string json1 = JsonSerializer.Serialize(a3, option);
           // Console.WriteLine(json1);
            // FindAll: 找出性别男的
            var a4 = list.FindAll(n =>
            {
                return n["isMan"] == true;
            });
            string json2 = JsonSerializer.Serialize(a4, option);
            Console.WriteLine(json2);
            // FindIndex: 找出薪水大于5000
            var a5 = list.FindAll(n =>
            {
                return n["salary"] > 5000;
            });
            string json3 = JsonSerializer.Serialize(a5, option);
            //Console.WriteLine(json3);
            // FindLastIndex: 找出薪水小于3000
            var a6 = list.FindAll(n =>
            {
                return n["salary"] < 3000;
            });
            string json4 = JsonSerializer.Serialize(a6, option);
            Console.WriteLine(json4);
            // Exists: 判断是否有薪水大于5000
            bool a7 = list.Exists(n =>
            {
                return n["salary"] > 5000;
            });
            Console.WriteLine(a7);
            // ForEach: 输出每个的 名字-年龄-薪水
            foreach (dynamic i in list)
            {
                Console.WriteLine($"{i["name"]}-{i["age"]}-{i["salary"]}");
            }
            // ConvertAll: 映射得到一个所以薪水的list
            dynamic a8 = list.ConvertAll(n => n["salary"]);
            foreach(dynamic i in a8) Console.WriteLine(i);
            //TrueForAll: 判断是否都成年
            bool a9 = list.TrueForAll(n => n["age"] > 18);
            Console.WriteLine(a9);

            //作业二
            var mum = (string a) =>
            {
                int count = 0;
                string i = "";
                char ii;
                Dictionary<string, int> number = new Dictionary<string, int>();
                
                for (int i1 = 0; i1 < a.Length; i1++)
                {
                    ii = a[i1];
                    if (a[i1].ToString().IndexOf(ii) == a[i1].ToString().LastIndexOf(ii))
                    { i += a[i1]; }

                }

                return number;
            };
        }
    }
}
