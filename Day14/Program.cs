using System;
using System.Text.Json;

namespace Day14
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
                book bm = new book("./booker.json", new JsonSerializerOptions
                {
                    WriteIndented = true,
                    AllowTrailingCommas = true,
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
                        Console.WriteLine("请输入书名");
                        var bookname2 = Console.ReadLine();
                        var res2 = bm.Deletebook(bookname2);
                        Console.WriteLine(res2);
                        break;
                    case "3":
                        Console.WriteLine("请输入要改的书");
                        var bookname3 = Console.ReadLine();
                        Console.WriteLine("请输入作者");
                        var author3 = Console.ReadLine();
                        Console.WriteLine("类型");
                        var mark3 = Console.ReadLine();
                        Console.WriteLine("价格");
                        var price3 = double.Parse(Console.ReadLine());
                        Dictionary<string, dynamic> newbook3 = new()
                        {
                            ["name"] = bookname3,
                            ["author"] = author3,
                            ["mark"] = mark3,
                            ["isBorrow"] = false,
                            ["id"] = new Random().NextDouble(),
                            ["price"] = price3

                        };
                        var res3 = bm.Editbook(newbook3);
                        Console.WriteLine(res3);
                        break;
                    case "4":
                        Console.WriteLine("查询所有图书");
                        var reslist = bm.searchtbook();
                        if (reslist.Count == 0)
                        {
                            Console.WriteLine("没有书籍，请先添加");
                        }
                        else 
                        {
                            foreach(var item in reslist)
                            {
                                Console.WriteLine($"书名={item["name"]}--作者={item["author"]}-类型{item["mark"]}-id{item["id"]}-价格{item["price"]}");
                            }
                        }
                            break;
                    case "5":
                        Console.WriteLine("请输入书名");
                        var bookname5 = Console.ReadLine();
                        var res5 = bm.searchtbook1(bookname5);
                        if (res5.Count == 0) Console.WriteLine("无此书，请先添加");
                        else
                        {
                            Console.WriteLine($"书名：{res5["name"]}-作者：{res5["author"]}-价格{res5["price"]}");
                        }
                            break;
                    default:
                        Console.WriteLine("输入有误");
                        break;
                }
            }
           
        }
    }
}
