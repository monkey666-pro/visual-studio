using System;

namespace Day8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fn = (int n) =>
            {
                for (int i = 1; i <= n; i++)
                {
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write($"{j}*{i}={j * i}   ");
                        }
                    }
                    Console.WriteLine();
                }
            };
            var fn1 = () =>
            {
                int count=0;
                Random A = new Random();
                int A1 = A.Next(100);
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("请输入数字");
                    int shu=int.Parse(Console.ReadLine());
                    if (shu != A1)
                    {
                        if (shu > A1) { Console.WriteLine("偏大"); }
                        else Console.WriteLine("偏小"); 
                    }
                    else { Console.WriteLine("WIN!");break; }
                    count++;
                }
                if(count==5) Console.WriteLine("GAME OVER");
                Console.WriteLine($"答案为{A1}");
            };
            // fn1();
            //作业一
            var zhuangxiu = (double n, out double money) =>
            {
                double n1 =( Math.Pow(Math.PI*n,2))/2;
                double count = n1 * 200;
               
                money = count / 2;
                return count;
            };
            //Console.WriteLine(zhuangxiu(200, out double money));
            //Console.WriteLine(money);
            //作业二
            var zifu = (string q,string q1) =>
            {
                int count = 0;
                for (int n = 0; n < q.Length; n++)
                {
                    if (q[n].ToString()==q1)
                    {
                        count++;
                    }
                }
                Console.WriteLine($"子串{q1}在字符串中有{count}个");
            };
            // zifu("ffffeeewww", "e");
            //作业三(1)
            var xiabiao = (int[] a) =>
            {
                int m = a[0]; ;
                foreach (int i in a)
                {
                    if (i <= m)
                    { m = i;
                    } 
                }
                List<int> a1 = a.ToList(); 
                Console.WriteLine(a1.IndexOf(m));

            };
              //xiabiao([12,33,1,44,55,11,3,4]);
            //(2)
            Func<int[], int> getmin = (intarr) =>
            {
                int index = 0;//最小值索引
                for (int i = 0; i < intarr.Length; i++)
                {
                    if (intarr[i] < intarr[index]) index=i;
                }
                return index;
            };
            //作业四
            var huiwen = (string a) =>
            {
               bool s=true;
                int count = 0;
                for (int i = 0; i < a.Length/2; i++)
                {
                    int index = a.Length - 1 - i;
                    if (a[i] == a[index]) count++;

                    if ((a.Length / 2) == count)
                    { Console.WriteLine("true"); }
                }
                
            };
           // huiwen("ab6tjjyccba");
            //(2)
            Func<string, bool> huiwen1 = (str) =>
            {
                for (int i = 0; i < str.Length/2; i++)
                {
                    if (str[i] != str[str.Length - 1 - i])
                    { return false; };
                }
                return true;
            };
            Console.WriteLine(huiwen1("abfba"));
        }
    }
}
