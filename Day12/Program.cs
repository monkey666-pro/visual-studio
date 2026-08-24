using System;
using System.Text.Json;

namespace Day13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //回调函数
            List<int> filete(List<int> arr, Func<int, bool> panduan)
            {
                List<int> newlist = new List<int>();
                foreach (var item in arr)
                {
                    if (panduan(item)) newlist.Add(item);
                }
                return newlist;
            }
            List<int> list = new List<int>() { 1, 2, 30, 4, 5, 6, 70 };
            var newlist = filete(list, (item) => item > 10);
            foreach (dynamic i in newlist) Console.WriteLine(i);


            //类
            animal name = new animal();
            Console.WriteLine(name.Name);
            name.Name = "fwf";
            Console.WriteLine(name.Name);
            animal run = new animal();
            Console.WriteLine(run.Name);
            run.Name = "==========";
            animal dog = new animal();
            Console.WriteLine(dog.Name);
            dog.Name = "旺财";
            Console.WriteLine($"{dog.Name}{run.Name}");
            dog.run();
            //person p1 = new person();
            //Console.WriteLine(p1.Name);
            //Console.WriteLine(p1.Age);//protected无法访问
            person p1 = new person("ssd", 12, 4444, false, true);
            Console.WriteLine(p1.Name + p1.Isman);
            Console.WriteLine(person.Islive);
            //person p2 = new person()//普通构造函数
            //{
            //    Name = "ff",
            //    Id = 99,
            //    Isman = false
            //};
            var c1 = new camera();
            c1.connect();
            c1.disconnect();
            c1.phone();
            var m1 = new move();

            m1.connect();
            m1.Move1();
            m1.disconnect();

            var p11 = new plc();//多态（1）继承后重写
            p11.start();
            string num = "";





           
            while (num != "0")
            {
                Console.WriteLine("===图书馆管理===");
                Console.WriteLine("1、增加书");
                Console.WriteLine("2、删除数");
                Console.WriteLine("3、编辑书");
                Console.WriteLine("4、搜索书");
                Console.WriteLine("5、搜索单本书");
                Console.WriteLine("0、退出");
                num = Console.ReadLine();
                book bm = new book("./booker.json",new JsonSerializerOptions
                {
                    WriteIndented= true,
                    AllowTrailingCommas= true,
                });
                switch (num)
                {
                    case "1":
                        Console.WriteLine("请输入书名");
                        var bookname = Console.ReadLine();
                        Console.WriteLine("请输入作者");
                        var author = Console.ReadLine();
                        Console.WriteLine("类型");
                        var mark = Console.ReadLine();
                        Console.WriteLine("价格");
                        var price = double.Parse(Console.ReadLine());
                        Dictionary<string, dynamic> newbook = new()
                        {
                            ["name"] = bookname,
                            ["author"] = author,
                            ["mark"] = mark,
                            ["isBorrow"] = false,
                            ["id"] = new Random().NextDouble(),
                            ["price"] = price

                        };
                        string res = bm.Addbook(newbook);
                        Console.WriteLine(res);
                        break;
                    case "2":

                        break;
                    case "3":

                        break;
                    case "4":
                        Console.WriteLine("请输入书名");
                        var bookname4 = Console.ReadLine();
                        string res4 = bm.searchtbook(bookname4);
                        Console.WriteLine(res4);
                        break;
                    case "5":
                        Console.WriteLine("请输入书名");
                        var bookname5 = Console.ReadLine();
                        Console.WriteLine("请输入作者");
                        var author5 = Console.ReadLine();
                        string res5 = bm.searchtbook1(bookname5, author5);
                        Console.WriteLine(res5);
                        break;
                }

            }

        }
        public void say()
        {
            Console.WriteLine("egg我为国家为各位各位");
        }
        public void say(string content)
        {
            Console.WriteLine("五个五个为我国");
        }
        public void say(string aa, string aaa)
        {
            Console.WriteLine("wefweffewef");
        }
     
    }
     



 

    
    public class animal
    {
        public string Name { get; set; }
        public string decrection { get; set; }
        static string Live { get; set; }
        public void run()
        {
            Console.WriteLine($"{Name}再跑，描述：{decrection}");
        }
    };
   
}
