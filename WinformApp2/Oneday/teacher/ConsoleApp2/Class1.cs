using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Class1
    {
        public virtual void Say()
        {
            Console.WriteLine("Class1-Say");
        }
    }

    internal class Class2 : Class1  // 继承
    {
        public override void Say()  // 重写了父类的Say方法
        {
            Console.WriteLine("Class2-Say");
        }

        public void callSay()
        {
            // 调用子类的Say方法
            //this.Say();
            // 调用父类的Say方法
            base.Say();
        }


        // 文档注释
        /// <summary>
        /// 求和方法
        /// </summary>
        /// <param name="n">参数1</param>
        /// <param name="m">参数2</param>
        /// <returns>求和结果</returns>
        public int Sum(int n, int m)
        {
            return n + m;
        }
    }


}
