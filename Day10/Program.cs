using Microsoft.VisualBasic;
using System.Globalization;
using System.Text.Json;
using System.Threading.Channels;

namespace Day10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = (string a) =>
            {
                var data = DateTime.Now;
                
                var datapath = @"./content.log";
                File.WriteAllText(datapath, a+data);
                
            };
            //path(Console.ReadLine());
            //读取文本
            //string aoo = File.ReadAllText("D:\\新建文本文档.text");
            //Console.WriteLine(aoo);
            Action wrirelog = () =>
                {
                    Console.WriteLine("输入模拟的操作");
                    string opt= Console.ReadLine();
                    var data = DateTime.Now;
                    File.AppendAllText("./content.log", $"{opt}--{data}\n");
                };
            //wrirelog();
            //判断目录是否存在
            bool aa=  Directory.Exists("./data");
            Console.WriteLine(aa);
            //创建文件夹
            Directory.CreateDirectory("./log/data");//创建log再创建data文件夹
            //删除文件夹
                   //Directory.Delete("./log");//因为还有里面data所以要先删除data
                  //Directory.Delete("./log/data");
                 //Directory.Delete("./log");
            Directory.Delete("./log", true);//第二个文件为true时不管里有没有文件直接删除
            //获取文件夹里的文件
            string[] files = Directory.GetFiles("./");
            foreach(string file in files) Console.WriteLine(file);
            //获取文件夹下的所以文件夹
            string[] file1 = Directory.GetDirectories("./");
            foreach(string fial in file1) Console.WriteLine(fial);
            //获取文件夹所有目录包括子目录
            Directory.CreateDirectory("./add/add1/add2");//先创建文件夹
            string[] ff = Directory.GetDirectories("./", "*", SearchOption.AllDirectories);//后面二个长的表示查找本目录加所有后代 目录
            foreach (string f in ff) Console.WriteLine(f);
  
            //判断一个路劲是文件还是文件夹
            Func<string, int> isfileordir = path =>
            {
                if (File.Exists(path)) return 1;//判断文件
                if (Directory.Exists(path)) return 2;//判断文件夹
                return 0;
            };
            string[] arr = ["NO", "is file", "is dir"];
            int res = isfileordir("./");
            Console.WriteLine(arr[res]);
            //获取目录下一级目录和文件
            Func<string, List<string>> getfiedir = path =>
            {
                List<string> relist = [];
                if (isfileordir(path) != 2) throw new Exception("有无");//先判断是不是目录,用上面函数
                string[] file= Directory.GetFiles(path);//获取文件
                relist.AddRange(file);
                string[]file1=Directory.GetDirectories(path);//获取目录
                relist.AddRange(file1);
                return relist;

            };
            //var aaa=getfiedir("./");
            //foreach(dynamic i in aaa) Console.WriteLine(i);

            ////获取文件夹所以文件路径
            ///da*以da开头的文件
           string[]ii= Directory.GetDirectories("./", "da*");
            foreach(dynamic i in ii) Console.WriteLine(i);

            //路径拼接
            var path1 =Path.Combine(@"D:\s\b","c","book.text");
            Console.WriteLine(path1);
            //作业
            var path0 = (string a) =>
            {
                
                Console.WriteLine("请输入用户名");
                string a1 = Console.ReadLine();
                var data = DateTime.Now;
                Console.WriteLine("请输入密码");
                string a2 = Console.ReadLine();
                var data1 = DateTime.Now;
                File.WriteAllText(a, $"用户===：{a1}-{data}\n密码为==={a2}-{data1}\n");
               
            };
            //path0("D:/个人信息/新建文本文档.txt");

            //作业二
            var zuce = (string aa) =>
            {
                string count="";
                string count1="";
                string password= "";
                string password1 = "";
                string json="";
                while (true)
                {
                    Console.WriteLine("菜单栏：1、注册  2、登录  0、退出");
                    int a = int.Parse(Console.ReadLine());
                    if (a==0) break;
                    if (a == 1)
                    {
                        Console.WriteLine("请输入用户名：");
                         count = Console.ReadLine();
                        Console.WriteLine("请输入密码：");
                         password = Console.ReadLine();
                        Console.WriteLine("请输入核对账号：");
                         count1 = Console.ReadLine();
                        Console.WriteLine("请输入核对密码：");
                         password1 = Console.ReadLine();
                        if (count == count1 && password == password1) Console.WriteLine("注册成功");
                        else Console.WriteLine("用户名或密码错误");
                        File.WriteAllText(aa, $"用户名：{count}\n密码：{password}\n");
                        List<string> list = new List<string>();
                        list.Add(count);list.Add(password);
                        json=JsonSerializer.Serialize(list);
                        File.WriteAllText(aa, json);
                        
                    }
                    if (a == 2)
                    {
                        Console.WriteLine("请输入用户名：");
                        string count11 = Console.ReadLine();
                        Console.WriteLine("请输入密码：");
                        string password11 = Console.ReadLine();

                        if((count==""&&password=="")) Console.WriteLine("账号密码错误或没注册");
                        if ((count == count11 && password11 == password) )
                        {
                            var pathh = "D:/个人信息/用户操作日志/log.txt";
                            while (true)//校验 
                            {
                                var A1 = new Random();
                                int num = A1.Next(10000);
                                Console.WriteLine($"请问图中数字是({num})");
                                int num1 = int.Parse(Console.ReadLine());
                                if (num1 == num) break;
                                else Console.WriteLine("请重新输入");
                            }
                            Console.WriteLine("操作空间：1、修改 2、删除 3、访问 4、移动、复制");
                            int ward = int.Parse(Console.ReadLine());
                            if (ward == 1)
                            {
                                string caozuo = Console.ReadLine();
                                var rinqi = DateTime.Now;
                                File.AppendAllText(pathh, $"{count}-修改-更改-{rinqi}");
                            }
                            if (ward == 2) 
                            {
                                Console.WriteLine("确定要删除文件？");
                                string yes=Console.ReadLine();
                                if (yes == "yes")
                                {
                                    File.Delete(pathh);
                                    throw new Exception("警告！用户操作文件已删除");
                                }
                            }
                            if (ward == 3)
                            {
                                File.ReadAllText(pathh);
                                var rinqi = DateTime.Now;
                                File.AppendAllText(pathh, $"{count}-访问-{rinqi}");
                            }
                            if (ward == 4)
                            {
                                File.Move(pathh, "D:/个人信息/用户操作日志/new.txt");
                                var rinqi = DateTime.Now;
                                File.AppendAllText(pathh, $"{count}-move-{rinqi}---警告：文件已被移动");
                            }
                            if (ward == 5)
                            {
                                File.Copy(pathh, "D:/个人信息/用户操作日志/newpath.txt");
                                var rinqi = DateTime.Now;
                                File.AppendAllText(pathh, $"{count}-复制-{rinqi}---警告：文件已被复制");
                            }
                        }
                    }
                    }
            };
            zuce("D:/个人信息/新建文本文档 (2).json");
           
        }
    }
} 
