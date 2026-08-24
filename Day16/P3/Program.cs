using System.Text.RegularExpressions;

namespace P3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num = "";
            Class1 cm = new Class1();
            while (num != "0")
            {
                tip();
                num = Console.ReadLine();
                switch (num)
                {
                    case "1":
                        cm.AddEm();
                        break;
                    case "2":
                        cm.Searchemp();
                        break;
                    case "3":
                        cm.salary();
                        break;
                    case "4":
                        cm.Removeemp();
                        break;
                    case "5":
                        cm.salaryemp();
                        break;
                    case "0":
                        Console.WriteLine("--**退出**--");
                        break;
                    default:
                        Console.WriteLine("****输入有误****");
                        break;
                }
            }
        }
        static void tip()
        {
            Console.WriteLine("==员工薪资管理系统==");
            Console.WriteLine("请选择操作编号：");
            Console.WriteLine("0：退出系统");
            Console.WriteLine("1：新增员工");
            Console.WriteLine("2：查看所有员工");
            Console.WriteLine("3：根据编号调整薪资");
            Console.WriteLine("4：根据编号删除员工");
            Console.WriteLine("5：按薪资条件筛选员工");
        }
    }

}
