namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //digui();
            //Console.WriteLine(digui(5));

            //Console.WriteLine(FeiBo(4));
            //Console.WriteLine(FeiBo(6));
            //Console.WriteLine(FeiBo(8));
            //Console.WriteLine(FeiBo(10));
            //Console.WriteLine(FeiBo(11));

            Console.WriteLine(GetSum(1));
            Console.WriteLine(GetSum(2));
            Console.WriteLine(GetSum(3));
        }
        static double GetSum(double n)
        {
            //Console.WriteLine(-1 / n);
            if (n == 1) return 1;
            // 1 - 1/2 + 1/3 - 1/4 + 1/5 ... - 1/100
            // GetSum(n) 表示得到n的 和
            // GetSum(n-1)  表示得到n-1的 和
            // n的和就是  GetSum(n-1) + (1/n)  // 加减取决于n是奇数还是偶数
            return GetSum(n - 1) + (n % 2 == 0 ? -1 / n : 1 / n);

        }
        static int FeiBo(int n)
        {
            if (n == 1 || n == 2) return 1;
            // FeiBo(n) 表示 第n个的斐波数字
            // FeiBo(n - 1) 表示 第n-1个的斐波数字
            // FeiBo(n - 2) 表示 第n-2个的斐波数字
            return FeiBo(n - 1) + FeiBo(n - 2);
        }
        static int digui(int num)
        {
            if (num == 1) return 1;
            //digui(num-1) 表示的是 num-1的 阶和
            //num的阶和 ===> num + digui(num-1)
            return num + digui(num - 1);
        }

        //static void digui() {
        //    digui();
        //}

    }
}
