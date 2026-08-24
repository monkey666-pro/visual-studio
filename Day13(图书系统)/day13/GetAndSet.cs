using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day13
{
    internal class GetAndSet
    {
        // 在外部不允许 修改X
        public int X { get; private set; }

        public void setX(int x)
        {
            X = x;
        }

        private int _N;
        public int N
        {
            // 属性的访问器===》 访问方法===》必须要有返回值
            get {
                //Console.WriteLine("你访问了N属性");
                //return _N;
                return _N*100;


            }
            // 属性的设置器 ===> 设置方法====》修改这个属性的时候 方法内的value接受 修改的值
            set
            {
                //Console.WriteLine("你设置了N属性");
                //Console.WriteLine(value);
                if(value < 100) Console.WriteLine("N的值不能小于100");
                else _N = value;
            }

        }

    }
}
