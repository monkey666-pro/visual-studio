namespace 试试
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
                int a = 12,b = 11, c = a + b;
                Console.WriteLine(c);
            //2
                double huashidu ,sheshidu,aaa;
                Console.Write("当前华氏度为：");
                double huashidu2 = double.Parse( Console.ReadLine());
                double sheshidu0 =(5 * (huashidu2 - 32) / 9.0) ;
                sheshidu=Math.Truncate(sheshidu0*1000)/1000;
                Console.WriteLine("摄氏度为{0}°，华氏度为{1}°",sheshidu,huashidu2);
            //4
                Console.Write("当前救援小时数为：");
                string hours = Console.ReadLine();
                int real_hours = int.Parse(hours);
                int day = real_hours / 24;
                int h = real_hours - day * 24;
                Console.WriteLine("救援天数为{0}天，{1}小时。",day, h);




        }
    }
    
}
