using System;
using System.IO;

namespace Day4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //
            int npy = 1;
            while (npy <= 5)
            {
                Console.Write("我爱你"); npy++ ;
            }
            //跑圈
            int paoq = 0;
                while (paoq < 5)
            { Console.WriteLine("跑圈");paoq++; }
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
            }            int shuzi = 1;
            //执行数字1-5
            while (shuzi <= 5)
            {
                Console.WriteLine($"{shuzi}");
                shuzi++;

            }
            //1-5相加
            int xiangjia = 0;
            int chu = 1;
            while (chu <= 5)
            {
                xiangjia += chu;
                chu++;
            }
            Console.WriteLine($"{xiangjia}");
            //将1-10的奇数加起来
            int js = 0, chu1 = 1;
            while (chu1 <=10)
            {
                if (chu1 % 2!= 0)
                {
                    js += chu1;
                }
                chu1++;
            }
            Console.WriteLine($"{js}");
            //例4
            int zheng3 = 0;
            while (zheng3 <= 50)
            {
                if (zheng3 % 3 == 0 && zheng3 % 5 == 0)
                {
                    Console.WriteLine($"{zheng3}");
                }
                zheng3++;
            }
            //1-5相乘
            int cheng = 1, zheng1 = 1;
             while (cheng <= 5)
            {
                zheng1 *= cheng;
                cheng++;
            }
            Console.WriteLine($"{zheng1}");
            //逢7就过
            int feng7 = 0, feng = 0, feng8 = 0;
            while (feng<=100)
            {
                feng7 = (feng % 10) ;
                feng8 = (feng % 100) / 10;
                if (feng7 == 7||feng8==7 )
                {
                    Console.WriteLine($"{feng}");
                }

                feng++;
            }
            //水仙花数
            int shuixianhua = 100, ge, shi,bai,fang;
            while (shuixianhua < 1000)
            {
                ge = shuixianhua % 10;
                shi = (shuixianhua / 10)%10 ;
                bai = (shuixianhua / 100)%10 ;
                if (Math.Pow(ge, 3) + Math.Pow(shi, 3) + Math.Pow(bai, 3) == shuixianhua)
               {
                    Console.WriteLine(shuixianhua);
                }
                shuixianhua++;
           }
            //do while
                    //string answer;
                    //do
                    //{
                    //    Console.WriteLine("老板，可以下班了吗？y/n");
                    //    answer = (Console.ReadLine());

                    //} 
                    //while (answer != "y");
                    //Console.WriteLine("OK,下班回家~~~");
                    //int igije = 987;
                    //Console.WriteLine(igije%100);
            //求数组的和
            List<int> shuzu = new()
            {
                1,
                2,
                3,
            };
            int number = 0;
            for (int shuzu1 = 0; shuzu1 < shuzu.Count(); shuzu1++)
            {
                number += shuzu[shuzu1];
            }
            Console.WriteLine(number);
            //例：倒着输出1-10
            for (int dao = 10; dao > 0; dao--)
            {
                Console.WriteLine(dao);
            }
            //例：输出1-10之间的偶数(1)
            int num22;
            for (int ou = 0; ou < 11; ou++)
            {
                if (ou % 2 == 0)
                {
                    Console.Write(ou);
                }
            }
            //例：输出1 - 10之间的偶数(2)
            for (int ou1 = 0; ou1 < 11; ou1 += 2)
            {
                Console.WriteLine(ou1);
            }
            //例：入职薪水10K，每年涨幅5%，50年后工资多少？
            double zf=0,xz=10000*12;
            for (int nians = 1; nians <= 50; nians++)
            {
                xz = xz * 1.05;
                zf += xz;
            }
            Console.WriteLine(zf);
            //作业三
            for (int xing = 8; xing > 0; xing--)
            {
                for(int xing1=xing;xing1>0;xing1--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            //作业四1 - 1/2 + 1/3 - 1/4 + ... - 1/100
            double jieg1=0,jieg2=0,jieg123=0,jieg1234=0;
            for (double n333 = 1; n333 <=100 ; n333++)
            {
                if (n333 % 2 == 0)
                {
                    jieg1 = (1.0 / n333);
                    jieg123 += (1.0 / n333);
     
                }
                 if(n333 % 2 != 0)
                { 
                    jieg2 = 1.0 / n333;
                    jieg1234 += 1.0 / n333;
                }
            }
            Console.WriteLine(jieg1234-  jieg123);
            //foreach
            int[] intArr = [10, 20, 30, 40];
            int arrz = 0;
            foreach (int iii in intArr)
            {
                arrz += iii;
                Console.WriteLine( iii);
            }
            Console.WriteLine(arrz);

            //foreach 拼接
            string pj="";
            List<string> www = new List<string>()
            {
                "i",
                "love",
                "you",
            };
            foreach (string ss in www)
            {

                pj += ss;
            }
            Console.WriteLine(pj);
            //作业五
            int jiehe = 0;
            int jieg12 = 1;
            for (int jie = 1; jie < 10; jie++)
            {
                jieg12 = 1;
                for (int jie1 = 1; jie1 <= jie;jie1++ )
                {
                    jieg12*=jie1;
                    
                }
                jiehe += jieg12;

            }
            Console.WriteLine(jieg12);
            Console.WriteLine(jiehe);
            //作业六
            double lanqiu=5,cishu,zuizhong=0;
            for (cishu=1; cishu >= 0; cishu++)
            {
                lanqiu = lanqiu * 0.3;
                zuizhong = lanqiu;
                if (lanqiu < 0.1)
                {
                    Console.WriteLine(cishu);
                    break;
                }
            }
            Console.WriteLine(zuizhong);
            //作业七
            double zhima=0.00001, li,zhongliang,ZZZ=0;
            for (int lii = 1; lii < 65; lii++)
            {
               li=Math.Pow(2, lii - 1);
                zhongliang = li * zhima;
                ZZZ += zhongliang;//加起来的重量
                
            }
            Console.WriteLine(ZZZ);
            //作业八
            double cunkuan = 50000.0,shengqian=0,shengqian1=0;
            for (int month = 1; month >= 0; month++)
            
            {
                cunkuan = cunkuan * 0.95;
                shengqian = cunkuan;
                if (shengqian < 5000)
                {
                    Console.WriteLine($"次数：{month}");
                    break;
                }
            }
            Console.WriteLine($"剩钱为{shengqian}");
            //作业九
            int peach = 1;
            for (int i = 0; i < 6; i++)
            {
                peach = 2 * (peach + 1);
            }
            Console.WriteLine(peach);
            //作业十
            double gaodu = 10,jingli=0,h=0;
            for (int luodi = 10; luodi > 0; luodi--)
            {
                jingli = gaodu * 1.5;
                gaodu = gaodu * 0.5;
                h += jingli;
            }
            Console.WriteLine(h);
        }
    }
}
