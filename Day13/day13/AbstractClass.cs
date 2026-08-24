using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 抽象类先关内容
namespace day13
{
    // 定义的抽象类
    internal abstract class AbstractClass
    {
        public string Name { get; set; }
        // 抽象属性
        public abstract bool IsMan {  get; set; }
        // 抽象方法
        public abstract void Hi(int n,string s);
        
        public void Say()
        {
            Console.WriteLine("Hello");
        }
    }
    
    // 普通子类继承 抽象类
    internal class Son : AbstractClass
    { 
        // 继承了父类（抽象类） 必须实现 其中的抽象属性和抽象方法
        public override bool IsMan { get; set; }

        public override void Hi(int n1, string s1) {
            Console.WriteLine("hi");
        }
    }


    // 如果子类也是抽象类，那么可以不是实现父类中的抽象方法
    internal abstract class AbstractSon : AbstractClass
    {
        
    } 
}
