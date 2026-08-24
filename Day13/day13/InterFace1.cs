using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day13
{
    // interface 接口 只能实现
    interface InterFace1
    {
        string Name { get; set; }

        void SayHi(int n);

        void SayHello()
        {
            Console.WriteLine($"{Name}说Hello啊");
        }
    }

    // 实现接口的类， 必须实现接口中的方法属性
    internal class A : InterFace1
    {
        public string Name { get; set; }

        public void SayHi(int n1)
        {
            Console.WriteLine($"{Name}说Hi啊{n1}");
        }
    }
}
