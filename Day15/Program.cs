using System.Globalization;

namespace Day15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num="" ;//操作编号
            carmaneger cm = new carmaneger();
            car_costomer um = new car_costomer();
            car_rent rm=new car_rent();
            while (num!="0")
            {
                tip();
                 num=Console.ReadLine();
                switch (num)
                { 
                   case "1":
                        Console.WriteLine("请输入车牌号");
                        string car = Console.ReadLine();
                        Console.WriteLine("请输入车类型");
                        string cartype = Console.ReadLine();
                        Console.WriteLine("请输入时租费");
                        string hourcount = Console.ReadLine();

                        var res = cm.Add(car, cartype, hourcount);
                        Console.WriteLine(res);
                        break;
                case "2":
                        Console.WriteLine("所有车辆如下：");
                        cm.SearchAll();
                        break;
                    case "3":
                        Console.WriteLine("请输入车辆ID");
                        int id = int.Parse(Console.ReadLine());
                        cm.SearchOne(id);
                        break;
                    case "4":
                        cm.Searchfree();
                        break;

                    case "5":
                        um.Add();
                        break;
                    case "6":
                        um.SeachAll();
                        break;
                    case "7":
                        Console.WriteLine("请输入要查询的客户id");
                        int id1=int.Parse(Console.ReadLine());
                        um.SeachOne(id1);
                        break;
                    case "8":
                        rm.rent();
                        break;
                       
                    case "9":
                        rm.rerurn();
                        break;
                    case "0":
                        
                        break;
                }
            }
        }
        static void tip()
        {
            Console.WriteLine("==欢迎来到神车boos系统==");
            Console.WriteLine("请选择操作编号：");
            Console.WriteLine("0：退出系统");   
            Console.WriteLine("1：新增车辆");
            Console.WriteLine("2：查看所有车辆信息");
            Console.WriteLine("3：查看某辆车");
            Console.WriteLine("4：查看所有空闲车辆");
            Console.WriteLine("5：新增客户");
            Console.WriteLine("6：查看所有客户");
            Console.WriteLine("7：查看某个客户");
            Console.WriteLine("8：租车");
            Console.WriteLine("9：换车");
        }
    }
}
