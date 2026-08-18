using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13
{
    internal class plc:device
    {
        public void Readresister()
        {
            Console.WriteLine("启动PLC");
        }
        public virtual void start()
        {
            Console.WriteLine($"{Name}先检查信号设备启动");
        }
    }
}
