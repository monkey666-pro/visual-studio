using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day13
{
    // this 只能在类的方法中使用， 表示当前的实例对象（静态方法中没有this）
    internal class ThisClass1
    {
        static void Fn()
        {
            //Console.WriteLine(this); // 报错
        }
        // 验证this 表示当前的实例对象 
        public ThisClass1 GetThis()
        {
            return this;
        }
        public int N { get; set; } // 实例的属性N
        // this关键字的作用：1. 类方法中区分属性和参数
        public void SetN(int N)
        {
            //N = N; // 此处被赋值的N是谁？  变量作用域导致，此处的N就是形参N
            this.N = N; // this.N 就是实例对象的属性N
        }

        // this关键字的作用：2.将当前实例对象传递给其他方法
        public void CallFn()
        {
            Console.WriteLine("要调用ABC的Fn方法");
            // this 表示当前的实例对象
            ABC.Fn(this);
            // 当前实例对象===> 调用这个CallFn方法时候的实例对象
        }
    }


    
    internal class ABC
    {

        static public void Fn(ThisClass1 o )
        {
            Console.WriteLine(o.N);
        }

    }
}
