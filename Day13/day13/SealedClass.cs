using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day13
{
    //// 密封类不能被继承
    //internal sealed class SealedClass
    //{
    //}

    //internal class Son1: SealedClass // 报错： 密封类不能被继承
    //{
    //}


    internal class Father
    {
        public virtual void Say()
        {
            Console.WriteLine("Hello");
        }
    }

    internal class Son2 : Father {
        public sealed override void Say()  // 如果这个方法不想再被子类重写了可以 添加密封
        {
            Console.WriteLine("World");
        }
     
    }

    internal class Son3 : Son2 {
        //public sealed override void Say()   // 报错
        //{
        //    Console.WriteLine("World");
        //}
    }
}
