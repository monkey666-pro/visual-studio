namespace Day3
{
    internal class Program
    {

        static void Main(string[] args)
        {


            //switch简写
            Console.Write("请输入您的成绩");
            var cj = double.Parse(Console.ReadLine());
            string result = cj switch
            {
                >= 90 => "有前途",
                >= 80 => "还行",
                _ => "前途堪忧哦",
            };
            Console.WriteLine($"{result}");


            //三元运算符
            Console.WriteLine("年纪");
            var nianji = double.Parse(Console.ReadLine());
            string nj = nianji > 60 && nianji < 80 ? "中年人" : "老年人还是年轻人";
            Console.WriteLine($"{nj}");

            //作业八
            Console.Write("您当前的速度为：");
            var sudu = double.Parse(Console.ReadLine());
            if (sudu > 0)
            {
                if (sudu <= 30) Console.WriteLine("当前低速行驶");
                if (sudu <= 60) Console.WriteLine("当前中速速行驶");
                if (sudu <= 100) Console.WriteLine("当前中高行驶");
                if (sudu > 100)
                {
                    Console.WriteLine("您开始高速了");
                    if (sudu > 120 * 1.1)
                    {
                        Console.WriteLine("人才，驾驶证扣分了");
                        Console.Write("请再次看看你的速度:");
                        var sudu1 = double.Parse(Console.ReadLine());
                        if (sudu1 > 120 * 1.1) Console.WriteLine("马的，驾驶证别要了");
                        else Console.WriteLine("下次看好速度啊，人才");
                    }
                }

            }
            else Console.WriteLine("你是不是倒车了");


            //练习
            Console.Write("您现在的分数为：");
            var fenshu = double.Parse(Console.ReadLine());
            if (fenshu >= 0 && fenshu < 101)
            {
                if (fenshu < 60) { Console.WriteLine("您现在的等级为：D"); }
                if (fenshu > 60 && fenshu < 70) { Console.WriteLine("您现在的等级为：C"); }
                if (fenshu > 70 && fenshu < 80) { Console.WriteLine("您现在的等级为：B"); }
                if (fenshu > 80 && fenshu < 90) { Console.WriteLine("您现在的等级为：A"); }

            }

            //练习
            Console.WriteLine("请问今天是星期几");
            var xingqi = double.Parse(Console.ReadLine());
            if (xingqi > 0 && xingqi < 8)
            {
                switch (xingqi)
                {
                    case 1:
                        Console.WriteLine($"今天是星期{xingqi}");
                        break;
                    case 2:
                        Console.WriteLine($"今天是星期{xingqi}");
                        break;
                    case 3:
                        Console.WriteLine($"今天是星期{xingqi}");
                        break;
                    case 4:
                        Console.WriteLine($"今天是星期{xingqi}");
                        break;
                    case 5:
                        Console.WriteLine($"今天是星期{xingqi}");
                        break;
                    case 6:
                        Console.WriteLine("今天是星期{xingqi}");
                        break;
                    case 7:
                        Console.WriteLine("今天是星期天");
                        break;

                }
            }
            else { Console.WriteLine("数字有误"); }

            //作业七（拓展的用循环更合适，这仅是练习所学内容）
            var bianhao1 = double.Parse(Console.ReadLine());//设置商品编号总数
            Console.WriteLine("请输入商品编号");
            var bianhao = double.Parse(Console.ReadLine());

            if (bianhao <= bianhao1)
            {
                switch (bianhao)
                {
                    case 1:
                        Console.WriteLine("已购买可乐");
                        Console.Write("请问还需要什么，不需要请输入0");
                        var xuyao = double.Parse(Console.ReadLine());
                        if (xuyao != 0)
                        {

                            switch (xuyao)
                            {
                                case 1:
                                    Console.WriteLine("已再买可乐");
                                    break;
                                case 2:
                                    Console.WriteLine("已购买雪碧");
                                    break;
                                case 3:
                                    Console.WriteLine("已购买矿泉水");
                                    break;
                            }
                        }
                        break;
                    case 2:
                        Console.WriteLine("已购买雪碧");
                        Console.Write("请问还需要什么，不需要请输入0");
                        var xuyao1 = double.Parse(Console.ReadLine());
                        switch (xuyao1)
                        {
                            case 1:
                                Console.WriteLine("已购买可乐");
                                break;
                            case 2:
                                Console.WriteLine("已再买雪碧");
                                break;
                            case 3:
                                Console.WriteLine("已购买矿泉水");
                                break;
                        }
                        break;
                    case 3:
                        Console.WriteLine("已购买矿泉水");
                        Console.Write("请问还需要什么，不需要请输入0");
                        var xuyao2 = double.Parse(Console.ReadLine());
                        switch (xuyao2)
                        {
                            case 1:
                                Console.WriteLine("已购买可乐");
                                break;
                            case 2:
                                Console.WriteLine("已购买雪碧");
                                break;
                            case 3:
                                Console.WriteLine("已再买矿泉水");
                                break;
                        }
                        break;
                }
                if (bianhao > 3) Console.WriteLine("抱歉，您输入的编号中的商品还在备货中");
            }
            else { Console.WriteLine("抱歉，您输入的编号不在编号库内"); }

            //作业六
            Console.WriteLine("请输入您的会员等级");
            var dengji = double.Parse(Console.ReadLine());
            if (dengji > 2 && dengji < 6)
            {
                switch (dengji)
                {
                    case 3:
                        Console.WriteLine("购物打九折，无其他福利");
                        break;
                    case 4:
                        Console.WriteLine("每月可领优惠卷");
                        break;
                    case 5:
                        Console.WriteLine("终身免运费");
                        break;

                }
                ;


            }
            else { Console.WriteLine("等级错误"); }
            //作业五
            Console.WriteLine("请输入重量");
            var zhongliang = double.Parse(Console.ReadLine());
            if (zhongliang > 1)
            {
                if (zhongliang < 5)
                {
                    Console.Write("快递费为20元");
                }
                else { Console.Write("快递费50元"); }
            }
            else { Console.WriteLine("快递费为10元"); }


            //作业四（1）
            double[] a = [3, 4, 5];
            double[] b = [6, 7, 8];
            double[] c = [9, 10, 11];
            double[] d = [12, 1, 2];
            Console.WriteLine("请输入您现在所处的月份");
            var mouth = double.Parse(Console.ReadLine());
            var res = a.Contains(mouth);
            var res1 = b.Contains(mouth);
            var res2 = c.Contains(mouth);
            var res3 = d.Contains(mouth);

            switch (res)
            {
                case true:
                    Console.WriteLine("春季");
                    break;
            }
            switch (res1)
            {
                case true:
                    Console.WriteLine("夏季");
                    break;
            }
            switch (res2)
            {
                case true:
                    Console.WriteLine("秋季");
                    break;
            }
            switch (res3)
            {
                case true:
                    Console.WriteLine("冬季");
                    break;
            }

            //方法（2）switch穿透
            Console.WriteLine("请输入月份");
            var yuefen = double.Parse(Console.ReadLine());
            switch (yuefen)
            {
                case 1:
                    Console.WriteLine("冬季");
                    break;
                case 2:
                    Console.WriteLine("冬季");
                    break;
                case 3:
                    Console.WriteLine("c季");
                    break;
                case 4:
                    Console.WriteLine("c季");
                    break;
                case 5:
                    Console.WriteLine("c季");
                    break;
                case 6:
                    Console.WriteLine("x季");
                    break;
                case 7:
                    Console.WriteLine("x季");
                    break;
                case 8:
                    Console.WriteLine("x季");
                    break;
                case 9:
                    Console.WriteLine("q季");
                    break;
                case 10:
                    Console.WriteLine("q季");
                    break;
                case 11:
                    Console.WriteLine("q季");
                    break;
                case 12:
                    Console.WriteLine("冬季");
                    break;
            }

            //练习
            Console.WriteLine("请输入成绩");
            var chengji = double.Parse(Console.ReadLine());
            if (chengji > 60)
            {
                Console.Write("恭喜及格，");
                if (chengji < 80)
                {
                    Console.WriteLine("不过仅限于及格");
                }
                else { Console.WriteLine("而且优秀了"); }

            }

            Console.WriteLine("请输入年份");
            var year = double.Parse(Console.ReadLine());
            if (year % 4 == 0)
            {
                Console.WriteLine("是闰年,");
                if (year % 100 != 0)
                    Console.Write("不过普通闰年");
                if (year % 400 == 0)
                    Console.Write("超级闰年");

            }
            ;


            //作业三
            Console.WriteLine("请问您消费了多少呢");
            var jiner = double.Parse(Console.ReadLine());
            Console.WriteLine("请问您有没有会员(VIP或USER)");
            var shenfen = Console.ReadLine();
            switch (shenfen)
            {
                case "VIP":


                    if (jiner >= 1000)
                    {
                        jiner = jiner * 0.95;
                        Console.WriteLine($"您的消费金额为：{jiner}");
                    }
                    else
                    {
                        jiner = jiner;
                        Console.WriteLine("您的消费金额为：");
                    }
                    break;
                case "USER":
                    if (jiner >= 2000)
                    {
                        jiner = jiner * 0.95;
                        Console.WriteLine($"您的消费金额为：{jiner}");
                    }
                    else
                    {
                        jiner = jiner;
                        Console.WriteLine("您的消费金额为：");
                    }
                    break;
            }


            //作业二
            Console.WriteLine("请选择您的菜单add/edit/del");
            var shuzhi = Console.ReadLine();
            if (shuzhi == "add" || shuzhi == "edit" || shuzhi == "del")
            {
                switch (shuzhi)
                {
                    case "add":
                        Console.WriteLine("新增成功");
                        break;
                    case "edit":
                        Console.WriteLine("编辑成功");
                        break;
                    case "del":
                        Console.WriteLine("删除成功");
                        break;
                    default:
                        { Console.WriteLine("菜单无该选项"); }
                        break;
                }
            }



            //作业一
            var zhanghao = "admin";
            var mima = "123456";
            Console.WriteLine("请输入您的账号");
            var zhanghao1 = Console.ReadLine();
            Console.WriteLine("请输入您的密码");
            var mima1 = Console.ReadLine();
            if (zhanghao == zhanghao1 || mima == mima1)
            {

                if (zhanghao != zhanghao1)
                { Console.WriteLine("账号错误"); }
                if (mima != mima1)
                { Console.WriteLine("密码错误"); }
                if (zhanghao == zhanghao1 && mima == mima1) { Console.WriteLine("登录成功"); }
            }
            else { Console.WriteLine("账号和密码都错误"); }

            switch (zhanghao1)
            {
                case "admin":
                    Console.WriteLine("账号zq");
                    break;

            }

            Console.Write("请输入小红的资产");
            var caichan1 = double.Parse(Console.ReadLine());
            Console.Write("小红的颜值为");
            var yanzhi1 = double.Parse(Console.ReadLine());
            if (caichan1 > 3000000 || yanzhi1 > 9.5)
            {
                Console.WriteLine("满足小明胃口");
            }
            else
            {
                Console.WriteLine("不满足小明胃口");
            }
            Console.WriteLine("小红车模的年龄为");
            var age1 = double.Parse(Console.ReadLine());
            if (age1 > 16 && age1 < 22)
            {
                Console.WriteLine("小红这个车模我要了");
            }
            else { Console.WriteLine("这个车模我不要"); }



        }
    }
}
