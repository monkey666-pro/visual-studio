using System.Text.RegularExpressions;

namespace Day6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //        List<Dictionary<string, dynamic>> goodsList = new List<Dictionary<string, dynamic>>
            //        {
            //        new Dictionary<string, dynamic>
            //        {
            //            {"name", "机械键盘"},
            //            {"price", 299.99},
            //            {"code", "G001"},
            //            {"stock", 120}
            //        },
            //        new Dictionary<string, dynamic>
            //        {
            //            {"name", "无线鼠标"},
            //            {"price", 89.50},
            //            {"code", "G002"},
            //            {"stock", 356}
            //        },
            //        new Dictionary<string, dynamic>
            //        {
            //            {"name", "27寸显示器"},
            //            {"price", 1299.00},
            //            {"code", "G003"},
            //            {"stock", 48}
            //        },
            //        new Dictionary<string, dynamic>
            //        {
            //            {"name", "电竞耳机"},
            //            {"price", 199.00},
            //            {"code", "G004"},
            //            {"stock", 85}
            //        },
            //        new Dictionary<string, dynamic>
            //{
            //    {"name", "电脑支架"},
            //    {"price", 69.90},
            //    {"code", "G005"},
            //    {"stock", 210}
            //}
            //        };
            //        Console.WriteLine("输入排序类型");
            //        string sortType = Console.ReadLine();
            //        Console.WriteLine("输入排序方法");
            //        string sortMethod = Console.ReadLine();
            //        if (sortType == "price" || sortMethod == "stock")
            //        {
            //            if (sortMethod == "ASC")
            //            {
            //                for (int i = 0; i < goodsList.Count - 1 - i; i++)
            //                {

            //                    for (int j = 0; j < goodsList.Count - 1 - j; j++)
            //                    {
            //                        if (goodsList[j]["price"] > goodsList[j + 1]["price"])
            //                        {
            //                            dynamic tem = goodsList[j];
            //                            goodsList[j] = goodsList[j + 1];
            //                            goodsList[i + 1] = tem;
            //                        }
            //                    }
            //                    foreach (dynamic q in goodsList) Console.WriteLine($"{q["name"]}--{q["price"]}");

            //                }
            //            }
            //        }
            string str = "abciokrtseaassccqa";
            Console.WriteLine(str[0]);
            int?a= null;
            Console.WriteLine(a);
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(str[i]);
            }
            string str1 = "gegjoevjlvnvkx";
            string res = "";
            for (int i = 0; i < str1.Length; i++)
            {
                int j = 0;
                for (; j < res.Length; j++)
                {
                    if (str1[i] == res[j]) break; 
                }
                if (j == res.Length) res += str1[i];
            }
            Console.WriteLine(res);
            string st2r = "生活总会有大麻烦, 黑夜总会过去";
            // 假设list存储敏感词
            List<string> mgc = ["大麻", "夜总会"];
            foreach (string i in mgc)
            {
                string xing = "";
                for (int q = 0; q < i.Length; q++) xing += "*";
               st2r = st2r.Replace(i, xing);
                //便捷方法
                //string xing1 = "";
                //xing1.PadLeft(i.Length, '*');
                //st2r = st2r.Replace(i, xing);
            }
            Console.WriteLine(st2r);
            //分割字符串
            string str2 = "you love i";
            string[] str3 = str2.Split();
            List<string> str4 = new();
            foreach (string i in str3) str4.Add(i);
            str4.Reverse();
            string str5 = "";
            foreach (string i in str4)
            {
                string first = i.Substring(0, 1).ToUpper();
                string other = i.Substring(1).ToLower();
                str5 += first + other + " ";
            }
            Console.WriteLine(str5.Substring(0,str5.Length-1));//因为最后一个字符是空格，所以删除了
            //concat
            string aa = "aa";
            string bb = "bb";
            string cc = "cc";
            string res1 = string.Concat(aa + bb + cc);
            string[] arr1 = ["qq", "www", "sss"];
            Console.WriteLine(string.Concat(arr1));
            Console.WriteLine(res1);
            //string.join
            string[] arr = ["qq", "www", "sss"];
            Console.WriteLine(string.Join("-",arr));
            //padleft/right
            string aaa = "aa";
            Console.WriteLine(aaa.PadLeft(4,'*'));//4为总长度而不是*的长度小于a的长度只输出aa本身
            Console.WriteLine(aaa.PadRight(4,'#'));
            //remove
            string aaaa = "eigheihgi";
            Console.WriteLine(aaaa.Remove(3));//不会改动aaaa里面的值，输出删除之后的值
            //正则表达式
            string reg = @"a";
            string regg = "bbaaaal";
            var res11 = Regex.Match(regg, reg);//提取a
            Console.WriteLine(res11);
            //验证正则表达式
            string re = @"a";
            bool re1=Regex.IsMatch(regg, re);
            Console.WriteLine(re1);
            bool re2 = Regex.IsMatch("feefef", re);
            Console.WriteLine(re2);
            //替换表达式
            Console.WriteLine(Regex.Replace(regg,re,"b"));
            bool u1 = Regex.IsMatch("aaaarkk", re);
            Console.WriteLine(u1);
            //正则字符
            var a0 = @".";//.字符表示任意一个字符
            Console.WriteLine(Regex.IsMatch("fwjijfw231",a0));

            a0 = @"\d";//\d表示任意一个数字
            Console.WriteLine(Regex.IsMatch("feihfe",a0));
            Console.WriteLine(Regex.IsMatch("3424aa",a0));
            a0 = @"\D";//\D表示任意一个非数字(大小写之分)
            Console.WriteLine(Regex.IsMatch("fefefe1",a0));
            Console.WriteLine(Regex.IsMatch("fefefe", a0));
            //string.isnullorempty()、string.isnullorwhitespace()
            string str22 = null;
            string str23 = " ";
            string str24="efe";
            bool ii = string.IsNullOrEmpty(str22);
            Console.WriteLine(ii);
            bool iii = string.IsNullOrWhiteSpace(str23);
            Console.WriteLine(iii);
            bool iiii = string.IsNullOrWhiteSpace(str24);
            Console.WriteLine(iiii);
            //substring
            string oo = " , egegegscvx ,";
            var l = oo.Substring(2);
            Console.WriteLine(l);
            var l1 = oo.Substring(2, 2);
            Console.WriteLine(l1);
            //startwith ,endwith
            bool l2 = oo.StartsWith("e");
            Console.WriteLine(l2);
            bool l3 = oo.StartsWith("a");
            Console.WriteLine(l3);
            bool l4 = oo.EndsWith("x");
            Console.WriteLine(l4);
            bool l5 = oo.EndsWith("a");
            Console.WriteLine(l5);
            //toupper ,tolower
            string oo1 = oo.ToUpper();
            Console.WriteLine(oo1);
            Console.WriteLine(oo.ToLower());
            //Trim ,Trimstart ,TrimEnd
            Console.WriteLine(oo.Trim(','));
            Console.WriteLine(oo.TrimStart(','));
            Console.WriteLine(oo.TrimStart());
            Console.WriteLine( oo.TrimEnd(','));
            Console.WriteLine(oo.TrimEnd());
            //split
            string oo2 = "密码-二分-我国=不呢=额_金额_就";
            string []oo3= oo2.Split('-');
            string[] oo4 = oo2.Split('=');
            string []oo5= oo2.Split('_');
            foreach(dynamic i in oo3) Console.WriteLine(i);
            foreach(dynamic i in oo4) Console.WriteLine(i);
            foreach(dynamic i in oo5) Console.WriteLine(i);
            string[] oo6 = oo2.Split(['-','=','_']);
            foreach(dynamic i in oo6) Console.WriteLine(i);
            //you love i转成i love you
            string oo7 = "you love i";
            string[] oo8 = oo7.Split();
            string ooo = "";
            List<string> pp = new();
           foreach(string i in oo8) pp.Add(i);
            pp.Reverse();
            foreach (string i in pp)
            {
                string first = i.Substring(0,1).ToUpper();
                string other = i.Substring(1).ToLower();
                ooo += first + other + " ";
            }
            Console.WriteLine(ooo.Trim()+"|");

            //作业一string str = "hello, I am 刘德华,your name is 黎明?"
            reg = @"[\u4e00-\u9fa5]+";
            MatchCollection mm=(Regex.Matches("hello, I am 刘德华,your name is 黎明?",reg));
            Console.WriteLine(mm[0]);
            Console.WriteLine(mm[1]);
            //作业二string str = "abc  dd  ee  ff  gg  HH  h j k"
            string str33 = "abc  dd  ee  ff  gg  HH  h j k";
            string ppp = str33.Replace(" ", "-");
            Console.WriteLine(ppp);
            //作业三string str = "我的身份证号是: 360731200111052112,你的身份证是: 42108320041119211X";
            // 书写正则, 找到字符串中的身份证号及 出生年,月,日
            // reg = @"((\d{17}(X|x))|\d{18)";
            // string str999 = "我的身份证号是: 360731200111052112,你的身份证是: 42108320041119211X";
            //MatchCollection lll=(Regex.Matches(str999,reg));
            // Console.WriteLine(lll[0]);
            // Console.WriteLine(lll[1]);
           var reg1 = @"[1-9]\d{5}(\d{4}(\d{2})(\d{2})\d{3}[1-9Xx]";

            //作业四//密码中可以有数字,字母,特殊符号;长度要求8~15 
            //如果只有一种则 强度为弱
            //如果只有两种则 强度为中
            //如果两种都有则 强度为强

            Console.WriteLine("请输入密码");
            string mima = Console.ReadLine();

            //if (mima.Length >= 8&& mima.Length <= 15)
            //{
            //    reg = @"\d";
            //    bool p1 = Regex.IsMatch(mima, reg);
            //    reg = @"\D";
            //    bool p2 = Regex.IsMatch(mima, reg);
            //    reg = @"\W";
            //    bool p3 = Regex.IsMatch(mima, reg);
            //    if (p2 == true || p1 == true || p3 == true)
            //    {
            //        if ((p2 == true && p1 == true) || (p2 == true && p3 == true) || (p1 == true && p3 == true))
            //        {

            //            if (p2 == true && p1 == true && p3 == true)
            //            {
            //                Console.WriteLine("高");
            //            }
            //            else Console.WriteLine("中");
            //        }
            //        else
            //        {
            //            Console.WriteLine("低");
            //        }

            //    }       
            //}
            //else Console.WriteLine("密码长度错误");
            if (mima.Length >= 8 && mima.Length <= 15)
            {
                var reg2 = @"\d";
                var reg3 = @"[A-Za-z]";
                var reg4 = @"[^A-Za-z[0-9]";
                bool m1 = Regex.IsMatch(mima, reg2);
                bool m2 = Regex.IsMatch(mima, reg3);
                bool m3 = Regex.IsMatch(mima, reg4);
                int count=0;
                if (m1 == true) count++;
                if (m2 == true) count++;
                if (m3 == true) count++;
                if(count==1) Console.WriteLine("低");
                if (count == 2) Console.WriteLine("中");
                if (count == 3) Console.WriteLine("高");
            }
        }
    }
}