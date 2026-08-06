using System;

namespace Day4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////作业二
            int nian1 = 0;
            for (int nian = 1000; nian < 2021; nian++)
           {
               if (nian % 4 == 0 && nian % 100 != 0)
                {
                   
                 Console.Write($"{nian}年  ");nian1++;
                    if (nian1 == 4)
                    {
                        Console.WriteLine("\r\n");
                        nian1 = 0;
                    }
                }
            }
            //作业一
            int n1=0;
            for (int n = 0; n <=100; n++)
            {
                if (n % 2 == 0)
                {
                    n1 += n;
                    if (n == 100)
                    { Console.WriteLine($"{n1}"); }
                }
            }
            //九九乘法口诀表
            for (int i = 1; i < 10; i++)
            {
                for (int j = i; j < 10; j++)
                {
                    int c = i * j;
                    Console.Write($"{i}*{j}={c}  ");
                }
                Console.WriteLine();
            }
        }
    }
}
