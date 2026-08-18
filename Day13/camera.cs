using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13
{
    internal class camera:device
    {
        public string deviceName { get; set; }
        public bool isconnected { get; set; }

        public void phone()
        {
            Console.WriteLine("拍照");
        }

    }
}
