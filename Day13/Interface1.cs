using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14
{
    internal interface X
    {
        int sum(int n, int m);
    }
    internal interface Y
    {
        int sum1(int n, int m);
    }
    internal class Z:X,Y 
    {
        public int sum(int n, int m)
        {
            return n + m;
        }
        public int sum1(int n, int m)
        {
            return n - m;
        }
    }
}
