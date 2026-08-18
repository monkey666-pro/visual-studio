using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13
{
    internal class person
    {
        public string Name { get; set; }
        public int Id { get; set; }
        protected int Age { get; set; }
        public bool Isman { get; set; }
        private double Salary { get; set; }
        public static bool Islive { get; set; }
        public void getinfo()
        {
            Console.WriteLine(Name + Id + Age + Isman + Salary);
        }

        //实例构造函数无返回值
        public person(string name, int age, double salary, bool isman, bool islive)//public修饰构造函数
        {
            Name = name; Age = age; Salary = salary; Isman = isman; Islive = islive;
            Console.WriteLine("实例");
        }
        static person()//静态构造函数必须无参数
        {
            Console.WriteLine("静态");
            new person("ssaaa", 22, 333, false, true);
        }
        //私有构造函数,外部无法实例化
        private person()
        {
            Console.WriteLine("私有");
        }
        static private person Instance { get; set; }


    }
}
