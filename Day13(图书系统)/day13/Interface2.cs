using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day13
{
    internal interface X
    {
        int Sum(int n, int m);
    }

    internal interface Y
    {
        int Sub(int n, int m);
    }


    // 类可以实现多个接口
    internal class Z : X, Y
    {
        public int Sum(int n, int m)
        {
            return n + m;
        }
        public int Sub(int n, int m)
        {
            return n - m;
        }
    }
}
