using System.Xml.Linq;

namespace day13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 访问器设置器
            GetAndSet gs = new GetAndSet();
            //gs.X = 1;
            //gs.setX(1000);
            //Console.WriteLine(gs.X);

            gs.N = 10;
            gs.N = 999;
            Console.WriteLine(gs.N);



            // this关键字
            //ThisClass1 ThisObj = new ThisClass1()
            //{
            //    N = 999
            //};
            ////Console.WriteLine(ThisObj.GetThis() == ThisObj);
            ////ThisObj.SetN(100);
            ////Console.WriteLine(ThisObj.N);
            //ThisObj.CallFn();

            //// 发放补助的时候， 都是 未知户主
            //new BankCard("1112222", "未知户主");
            //new BankCard("1112223", "未知户主");
            //new BankCard("1112224", "未知户主");
            //new BankCard("1112225", "未知户主");
            //new BankCard("1112226", "未知户主");
            //new BankCard("1112227", "未知户主");
            //new BankCard("1112227", "匿名户主");
            //new BankCard("1112227", "匿名户主");
            //// 发放补助的时候， 都是 未知户主
            //new BankCard("1112227");
            //new BankCard("1112228");
            //new BankCard("1112229", "zs");


            //var b = new BankCard("1112229", "zs");
            //Console.WriteLine(b[0]);
            //b[0] = 111;
            //Console.WriteLine(b[0]);





            // 接口案例
            //A zsA = new A()
            //{
            //    Name = "zs"
            //};
            //zsA.SayHi(10);
            //zsA.SayHello();// 接口中的已实现的方法不能继承使用，接口中的方法只能被实现


            // 静态类            
            //Console.WriteLine(Tool.GetRanL());
            //Console.WriteLine(Tool.GetRanI(10));
            //Console.WriteLine(Tool.GetRanD());



            // 抽象类 无法实例化
            //new AbstractClass();
            //Son son1 = new Son();
            //son1.Hi(10,"111");
            //Console.WriteLine(son1.IsMan);
            //son1.Say();


        }
    }
}
