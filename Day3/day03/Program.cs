namespace day03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// 关系运算符,比较运算符 ===> 运算结果一定是布尔值
            //// > >= < <= == !=
            //Console.WriteLine("请输入第一个数字");
            //int n1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("请输入第二个数字");
            //int n2 = int.Parse(Console.ReadLine());
            ////bool res = n1 > n2;
            ////bool res = n1 < n2;
            ////bool res = n1 >= n2;
            ////bool res = n1 <= n2;
            ////bool res = n1 == n2;
            //bool res = n1 != n2;

            //Console.WriteLine(res);

            /*******************************************/

            // 逻辑运算
            // && 逻辑与运算符 并且
            // 表达式1 && 表达式2 
            // 当两边结果都是true的时候,最终结果才为true
            //  只要一边为false,则最终结果才为false

            // 小红想做车模，车模条件年龄16~22
            //Console.WriteLine("请输入的年龄");
            //int age = int.Parse(Console.ReadLine());
            //bool res = age > 16 && age < 22;
            //Console.WriteLine(res);


            // ||  逻辑或
            // 表达式1 || 表达式2 
            // 只要有一个为true, 最终结果就为true
            // 只要两边都是false, 最终结果就为false
            //小明择偶标准：要么资产在300w以上，要么颜值大于9.5。输入小红的资产和颜值
            //Console.WriteLine("请输入资产");
            //int money = int.Parse(Console.ReadLine());
            //Console.WriteLine("请输入颜值");
            //double yz = double.Parse(Console.ReadLine());
            //bool res = money > 300 || yz > 9.5;
            //Console.WriteLine(res);

            // ! 取反
            // 原来是true取反后为false,原来是false取反后为true
            //小明是真男人，去了一趟泰国，回来就反了
            //bool isMan = false;
            //isMan = !isMan;
            //Console.WriteLine(isMan);

            // 小红想做车模，车模条件年龄16~22
            //Console.WriteLine("请输入的年龄");
            //int age = int.Parse(Console.ReadLine());
            //bool res = !(age < 16 || age > 22);
            //Console.WriteLine(res);

            // && 短路运算
            // 表达式1 && 表达式2 ===> 只要有一个是false 结果就是false
            // 先执行表达式1, 如果表达式1是false,整体结果就是false 那么表达式2不会执行
            //int n = 0;
            //int num = 1;
            //bool res = n > num && n < num++;
            //// n > num 执行为false, res就是false;那么 n < num++ 不会执行
            //// bool res = n < num && n > num++;
            ////  n < num 执行为true;此时需要继续执行 n < num++
            //Console.WriteLine(res);
            //Console.WriteLine(num); // 2


            // || 的短路运算
            // 表达式1 || 表达式2 ===> 只要有一个是true 结果就是true
            // 如果表达式1执行是true; 整体结果就是true, 那么表达式2不会执行
            //int n = 0;
            //int num = 1;
            ////bool res = n > num || n < num++;
            ////// n > num 执行为false,需要继续执行 n < num++;
            //bool res = n < num || n < num++;
            //// n < num 执行为true,不会执行 n < num++;
            //Console.WriteLine(num);


            //// &不断路
            //int n = 0;
            //int num = 1;
            //bool res = n > num & n < num++;
            //Console.WriteLine(res);
            //Console.WriteLine(num);


            //// | 不断路
            //int n = 0;
            //int num = 1;
            //bool res = n < num | n < num++;
            //Console.WriteLine(res);
            //Console.WriteLine(num);

            /****************************************/
            //// 单分支
            //Console.WriteLine("请输入年龄");
            //int age = int.Parse(Console.ReadLine());
            //if (age >= 18)
            //{
            //    Console.WriteLine("成年了");
            //}


            // 双分支
            //Console.WriteLine("请输入年龄");
            //int age = int.Parse(Console.ReadLine());
            //if (age >= 18)
            //{
            //    Console.WriteLine("成年了");
            //}
            //else
            //{
            //    Console.WriteLine("未成年");
            //}

            // 输入年份，判断是否是闰年
            // 普通闰年：能被4整除但不能被100整除 ===> year%4 == 0 && year%100 != 0
            // 世纪闰年：可以被400整除 ====> year%400 == 0
            //Console.WriteLine("请输入年份");
            //int year = int.Parse(Console.ReadLine());
            //if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            //{
            //    Console.WriteLine($"闰年:{year}");
            //}
            //else
            //{
            //    Console.WriteLine($"{year}不是闰年");
            //}


            // 多分支
            /*
             if(条件1){
                代码1
             }else if(条件2){
                代码2
             }else if(条件3){
                代码3
             }....
             else{
                代码n
             }
             */

            // 多分支
            //根据输入的成绩判断是不及格(小于60),及格(大于60小于80), 良好(大于80小于90),优秀(大于90小于100)
            //Console.WriteLine("请输入考试成绩(1~100)：");
            //double score = double.Parse(Console.ReadLine());
            //// 判断
            //if (score < 60)
            //{
            //    Console.WriteLine($"{score} - 不及格");
            //}
            //else if (score < 80)
            //{
            //    Console.WriteLine($"{score} - 及格");
            //}
            //else if (score < 90)
            //{
            //    Console.WriteLine($"{score} - 良好");
            //}
            //else if (score <= 100)
            //{
            //    Console.WriteLine($"{score} - 优秀");
            //}
            //else
            //{
            //    Console.WriteLine("重新输入(1~100)分数");
            //}

            /******************************************************************/

            //// 分支结构简写
            //// 一般当 条件判断后需要执行的代码只有一行的时候可以简写====> 省略大括号
            //Console.WriteLine("请输入考试成绩(1~100)：");
            //double score = double.Parse(Console.ReadLine());
            ////判断
            ////if (score < 60) Console.WriteLine("不及格");
            ////else Console.WriteLine("及格");
            //if (score < 60) Console.WriteLine("不及格");
            //else if (score < 80) Console.WriteLine("及格");
            //else if (score < 90) Console.WriteLine("良好");
            //else if (score <= 100) Console.WriteLine("优秀");
            //else Console.WriteLine("请输入正确的分数");


            /**************************************************************/

            // 分支结构的嵌套
            //定义三个变量，求出三个值中的最大值。
            // 分支嵌套求3个数的最大值
            //int a = 5;
            //int b = 4;
            //int c = 10;
            //// 先比较a和b
            //if (a > b)
            //{
            //    // 比较a和c
            //    if (a > c) Console.WriteLine($"最大的是{a}");
            //    else Console.WriteLine($"最大的是{c}");
            //}
            //else
            //{
            //    // 比较b和c
            //    if (b > c) Console.WriteLine($"最大的是{b}");
            //    else Console.WriteLine($"最大的是{c}");
            //}

            //int age = 19;
            //bool flag = age >= 18;
            //if (flag) // 如果表达式的结果是布尔值,则表达式可以直接作为判断的条件
            //{
            //    Console.WriteLine("成年");
            //}
            //else
            //{
            //    Console.WriteLine("未成年");
            //}

            /******************************************************************/
            //switch多路判断

            /*              
             switch (变量) {
                case 值1:
                    代码1;
                break;
                case 值2:
                    代码2;
                break;
                case 值3:
                    代码3;
                break;
                ....
                default:
                    代码n;
             }                          
             */

            // 输出星期几
            //Console.WriteLine("请输入1-7");
            //int n = int.Parse(Console.ReadLine());
            //switch (n)
            //{
            //    case 1:
            //        Console.WriteLine("星期一");
            //        break;
            //    case 2:
            //        Console.WriteLine("星期二");
            //        break;
            //    case 3:
            //        Console.WriteLine("星期三");
            //        break;
            //    case 4:
            //        Console.WriteLine("星期四");
            //        break;
            //    case 5:
            //        Console.WriteLine("星期五");
            //        break;
            //    case 6:
            //        Console.WriteLine("星期六");
            //        break;
            //    case 7:
            //        Console.WriteLine("星期天");
            //        break;
            //    default:
            //        Console.WriteLine("输入有误");
            //        break;
            //}


            // 输入分数 1~100
            // 判断等级输出
            // 分数90~100  输出A  ===> 分数的十位9 / 10
            // 分数80~90   输出B  ===> 分数的十位8
            // 分数70~80   输出C  ===> 分数的十位7
            // 分数60~70   输出D  ===> 分数的十位6
            // 分数1~60    输出F  ===> 分数的十位0/1/2/3/4/5
            //Console.WriteLine("请输入分数");
            //int score = int.Parse(Console.ReadLine());
            //if (score > 0 && score <= 100)
            //{
            //    // 分数等级输出
            //    // 处理分数===> 获取分数的十位数字
            //    int n = score / 10;
            //    switch (n)
            //    {
            //        case 0: Console.WriteLine($"{score}分数是F等级"); break;
            //        case 1: Console.WriteLine($"{score}分数是F等级"); break;
            //        case 2: Console.WriteLine($"{score}分数是F等级"); break;
            //        case 3: Console.WriteLine($"{score}分数是F等级"); break;
            //        case 4: Console.WriteLine($"{score}分数是F等级"); break;
            //        case 5: Console.WriteLine($"{score}分数是F等级"); break;
            //        case 6: Console.WriteLine($"{score}分数是D等级"); break;
            //        case 7: Console.WriteLine($"{score}分数是C等级"); break;
            //        case 8: Console.WriteLine($"{score}分数是B等级"); break;
            //        case 9: Console.WriteLine($"{score}分数是A等级"); break;
            //        case 10: Console.WriteLine($"{score}分数是A等级"); break;                    
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("输入的分数有误");
            //}


            // switch的穿透  ===> 当变量和值 比对为true的时候,执行代码,但是找到break,则会向下继续执行代码,直到找到break则 switch才结束
            // 输出星期几  6-7输出周末
            //Console.WriteLine("请输入1-7");
            //int n = int.Parse(Console.ReadLine());
            //switch (n)
            //{
            //    case 1: Console.WriteLine("星期一"); break;
            //    case 2: Console.WriteLine("星期二"); break;
            //    case 3: Console.WriteLine("星期三"); break;
            //    case 4: Console.WriteLine("星期四"); break;
            //    case 5: Console.WriteLine("星期五"); break;
            //    case 6: // 穿透
            //    case 7: Console.WriteLine("周末"); break;
            //    default: Console.WriteLine("输入有误"); break;
            //}


            //输入一个月份，判断并输出这个月有多少天？
            //// 1,3,5,7,8,10,12 31天
            //// 2  ===> 28天
            //// 4,6,9,11 30天
            //Console.WriteLine("请输入月份1~12");
            //int month = int.Parse(Console.ReadLine());
            //switch (month)
            //{
            //    case 1: 
            //    case 3: 
            //    case 5: 
            //    case 7: 
            //    case 8: 
            //    case 10: 
            //    case 12: Console.WriteLine("31天"); break;
            //    case 2: Console.WriteLine("28天"); break;
            //    case 4: 
            //    case 6: 
            //    case 9: 
            //    case 11: Console.WriteLine("30天"); break;
            //    default: Console.WriteLine("输入有误"); break;
            //}



            // switch的简写
            //Console.WriteLine("输入成绩：");
            //double score = double.Parse(Console.ReadLine());
            //if (score > 0 && score <= 100)
            //{
            //    string res = score switch
            //    {
            //        //表达式 => 结果,  // 表达式中变量省略
            //        // _ => 结果  _ 表示default
            //        >= 90 => "A",
            //        >= 80 => "B",
            //        >= 70 => "C",
            //        >= 60 => "D",
            //        _ => "F"
            //    };
            //    Console.WriteLine(res);
            //}
            //else
            //{
            //    Console.WriteLine("输入有误");
            //}

            /****************************************/
            //三元运算 ===> 对if双分支的简写
            //if (条件) { 代码1} else { 代码2}
            // 三元运算===>   条件?代码1:代码2;
            // 变量 = 条件?代码1:代码2;   ===> 执行三元运算后的结果可以接受

            //int a = 1;
            //int b = 2;
            //int max = 0;
            ////if (a > b) {  max = a; } else { max = b; }
            ////Console.WriteLine(max);

            //max = a > b ? a : b;
            //Console.WriteLine(max);


            // 用三元运算简写
            // 双分支
            //Console.WriteLine("请输入年龄：");
            //int age = int.Parse(Console.ReadLine());
            //// 判断 成年了/ 未成年
            ////if (age > 18) { Console.WriteLine("成年了"); } else { Console.WriteLine("未成年"); }
            //string res = age > 18 ? "成年了" : "未成年";
            //Console.WriteLine(res);

            // 判断 闰年(能被4整除但不能被100整除,能被400整除) 平年
            //Console.WriteLine("请输入年份：");
            //int year = int.Parse(Console.ReadLine());
            ////if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            ////{
            ////    Console.WriteLine($"{year}是闰年");
            ////}
            ////else
            ////{
            ////    Console.WriteLine($"{year}是平年");
            ////}
            //string result = year % 4 == 0 && year % 100 != 0 || year % 400 == 0 ? "闰年" : "平年";
            //Console.WriteLine($"{year}是{result}");



            // 输出星期几
            //Console.WriteLine("请输入1-7");
            //int n = int.Parse(Console.ReadLine());
            //string r = n switch
            //{
            //    1 => "星期一",
            //    2 => "星期二",
            //    3 => "星期三",
            //    4 => "星期四",
            //    5 => "星期五",
            //    6 => "星期六",
            //    7 => "星期天",
            //    _ => "输入有误"
            //};
            //Console.WriteLine(r);
            // shift + alt + .  是快速匹配下个选中


            /*
            - 奇数偶数判断
            - 是否在线
            - 文件大小单位不同（1024以下kb/以上MB）
            - 数学运算计算器：让用户输入两个数字，再输入一个运算符(+ - * /)，判断输入的运算符是什么，对两个数字进行对应的数学运算，将结果输出
            - 不同血型不同性格：输入血型，当血型为A时，输出"细心稳重"；当血型为B时，输出"乐观自由"；当血型为AB时，输出"思维多变"；当血型为O时，输出"热情外向"             
             */

            //// 奇数偶数判断
            Console.WriteLine("请输入一个数字,判断奇数偶数");
            int n = int.Parse(Console.ReadLine());
            //if(n%2 == 0)
            //{
            //    Console.WriteLine($"{n}是偶数");
            //}
            //else
            //{
            //    Console.WriteLine($"{n}是奇数");
            //}
            string r = n % 2 == 0 ? "偶数" : "奇数";
            Console.WriteLine($"{n}是{r}");


            ////是否在线  1/2
            int n = 2;
            Console.WriteLine(n == 1 ? "在线" : "离线");


            //文件大小单位不同（1024以下kb / 以上MB）
            Console.WriteLine("请输入一个文件的大小数字");
            int m = int.Parse(Console.ReadLine());
            //if (m > 1024) {
            //    int r = m / 1024;
            //    Console.WriteLine($"文件{r}MB");
            //} else {
            //    Console.WriteLine($"文件{m}KB");
            //}

            string res = m > 1024 ? m / 1024 + "MB" : m + "KB";
            Console.WriteLine($"文件{res}");



            // 数学运算计算器：让用户输入两个数字，再输入一个运算符(+ - * /)，判断输入的运算符是什么，对两个数字进行对应的数学运算，将结果输出
            //Console.WriteLine("请输入第一个数字");
            //int n1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("请输入第二个数字");
            //int n2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("请输入运算符(+ - * /)");
            //string opt = Console.ReadLine();

            //switch (opt)
            //{
            //    case "+":
            //        Console.WriteLine($"n1{opt}n2 = {n1 + n2}");
            //        break;
            //    case "-":
            //        Console.WriteLine($"n1{opt}n2 = {n1 - n2}");
            //        break;
            //    case "*":
            //        Console.WriteLine($"n1{opt}n2 = {n1 * n2}");
            //        break;
            //    case "/":
            //        if (n2 == 0) Console.WriteLine("除数不能为0");
            //        else Console.WriteLine($"n1{opt}n2 = {n1 / n2}");
            //        break;
            //    default:
            //        Console.WriteLine("输入运算符有误");
            //        break;
            //}



            // 不同血型不同性格：输入血型，当血型为A时，输出"细心稳重"；当血型为B时，输出"乐观自由"；当血型为AB时，输出"思维多变"；当血型为O时，输出"热情外向"
            Console.WriteLine("请输入你的血型");
            string s = Console.ReadLine();
            string res = s switch
            {
                "A" => "细心稳重",
                "B" => "乐观自由",
                "AB" => "思维多变",
                "O" => "热情外向",
                _ => "输入有误"
            };
            Console.WriteLine(res);
        }
    }
}
