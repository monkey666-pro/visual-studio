using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14
{
    internal abstract class @abstract
    {
        public string name { get; set; }
        public abstract bool isman { get; set; }//抽象属性
        public abstract void hi(int n ,string s);//抽象方法
        public void say()
        {
            Console.WriteLine("hello");
        }
     

    }
    internal class Abstrac : @abstract
    {
        //继承了父类（抽象类）必须实现其中的抽象属性和抽象方法
        public override bool isman { get; set; }
        public override void hi(int n1, string s1)
        {
            Console.WriteLine("hi");
        }
    }
    internal abstract class abstra : @abstract
    { }
    internal abstract class Son1
    {
        public string name { get; set; }
        public abstract bool isman { get; set; }//抽象属性
        public abstract void hello(int n, string s);//抽象方法
        public void say()
        {
            Console.WriteLine("hello");
        }


    }

}
