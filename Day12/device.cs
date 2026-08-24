using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13
{
    internal class device
    {
        public string Name = "父类device";
        public void connect()
        {
            Console.WriteLine("连接设备");
        }
        public void disconnect()
        {
            Console.WriteLine("断开设备");
        }
        public void getinfo()
        {
            Console.WriteLine("父类");
        }
        public virtual void start()
        {
            Console.WriteLine($"{Name}设备启动");
        }
    }
}
