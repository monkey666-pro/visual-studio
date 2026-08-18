using System.Text.RegularExpressions;

namespace day06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 作业1
            //// 商品数据
            //List<Dictionary<string, dynamic>> goodsList = new()
            //{
            //    new Dictionary<string, dynamic>
            //    {
            //        {"name", "机械键盘"},
            //        {"price", 299.99},
            //        {"code", "G001"},
            //        {"stock", 120}
            //    },
            //    new Dictionary<string, dynamic>
            //    {
            //        {"name", "无线鼠标"},
            //        {"price", 89.50},
            //        {"code", "G002"},
            //        {"stock", 356}
            //    },
            //    new Dictionary<string, dynamic>
            //    {
            //        {"name", "27寸显示器"},
            //        {"price", 1299.00},
            //        {"code", "G003"},
            //        {"stock", 48}
            //    },
            //    new Dictionary<string, dynamic>
            //    {
            //        {"name", "电竞耳机"},
            //        {"price", 199.00},
            //        {"code", "G004"},
            //        {"stock", 85}
            //    },
            //    new Dictionary<string, dynamic>
            //    {
            //        {"name", "电脑支架"},
            //        {"price", 69.90},
            //        {"code", "G005"},
            //        {"stock", 210}
            //    }
            //};
            //// 提示输入的 是price还是stock  排序类型 
            //// 提示输入的是 ASC 还是DSC     排序顺序(ASC升序,DSC降序)
            //// 根据输入完成数据排序
            //Console.WriteLine("请输入排序类型(price/stock)");
            //string sortType = Console.ReadLine();
            //Console.WriteLine("请输入排序方式(ASC升序,DSC降序)");
            //string sortMethod = Console.ReadLine();
            //if (sortType == "price" || sortType == "stock")
            //{
            //    for (int i = 0; i < goodsList.Count - 1; i++)
            //    {
            //        // 判断升降序 (排序方式)
            //        if (sortMethod == "ASC")
            //        {
            //            for (int j = 0; j < goodsList.Count - 1 - i; j++)
            //            {
            //                if (goodsList[j][sortType] > goodsList[j + 1][sortType])
            //                {
            //                    var tmp = goodsList[j];
            //                    goodsList[j] = goodsList[j + 1];
            //                    goodsList[j+1] = tmp;
            //                }
            //            }
            //        }
            //        else if (sortMethod == "DSC")
            //        {
            //            for (int j = 0; j < goodsList.Count - 1 - i; j++)
            //            {
            //                if (goodsList[j][sortType] < goodsList[j + 1][sortType])
            //                {
            //                    var tmp = goodsList[j];
            //                    goodsList[j] = goodsList[j + 1];
            //                    goodsList[j + 1] = tmp;
            //                }
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("输入排序方式有误!");
            //        }
            //    }
            //}
            //else Console.WriteLine("输入排序类型有误");

            //foreach (var item in goodsList) Console.WriteLine($"{item["name"]}--price: {item["price"]}-- stock:{item["stock"]}");


            // 作业2
            //List<Dictionary<string, dynamic>> singerList = new()
            //{
            //    new Dictionary<string, dynamic>
            //    {
            //        {"singerId", 1001},
            //        {"singerName", "周杰伦"},
            //        {"genre", "流行"}
            //    },
            //    new Dictionary<string, dynamic>
            //    {
            //        {"singerId", 1002},
            //        {"singerName", "林俊杰"},
            //        {"genre", "华语流行"}
            //    },
            //    new Dictionary<string, dynamic>
            //    {
            //        {"singerId", 1003},
            //        {"singerName", "邓紫棋"},
            //        {"genre", "流行、摇滚"}
            //    },
            //    new Dictionary<string, dynamic>
            //    {
            //        {"singerId", 1004},
            //        {"singerName", "薛之谦"},
            //        {"genre", "抒情流行"}
            //    },
            //    new Dictionary<string, dynamic>
            //    {
            //        {"singerId", 1005},
            //        {"singerName", "毛不易"},
            //        {"genre", "民谣流行"}
            //    }
            //};
            //List<Dictionary<string, dynamic>> songList = new()
            //{
            //    new Dictionary<string, dynamic>
            //    {
            //        {"songId", 10001},
            //        {"singerId", 1001},
            //        {"songName", "青花瓷"},
            //        {"duration", 239}
            //    },
            //    new Dictionary<string, dynamic>
            //    {
            //        {"songId", 10002},
            //        {"singerId", 1001},
            //        {"songName", "发如雪"},
            //        {"duration", 253}
            //    },
            //    new Dictionary<string, dynamic>
            //    {
            //        {"songId", 10003},
            //        {"singerId", 1001},
            //        {"songName", "东风破"},
            //        {"duration", 215}
            //    },
            //    new Dictionary<string, dynamic>
            //    {
            //        {"songId", 1004},
            //        {"singerId", 3002},
            //        {"songName", "不为谁而作的歌"},
            //        {"duration", 296}
            //    },
            //    new Dictionary<string, dynamic>
            //    {
            //        {"songId", 1005},
            //        {"singerId", 1002},
            //        {"songName", "背对背拥抱"},
            //        {"duration", 262}
            //    }
            //};
            //// 通过歌曲查找歌手
            //Console.WriteLine("输入歌曲名称：");
            //string song = Console.ReadLine();
            //int singerId = 0; // 查找到的歌手ID
            //string singerName = ""; //歌手名称
            //for (int i = 0; i < songList.Count; i++)
            //{
            //    if (song == songList[i]["songName"]) singerId = songList[i]["singerId"];
            //}

            //foreach (var item in singerList)
            //{
            //    if (item["singerId"] == singerId) singerName = item["singerName"];
            //}
            //if(singerName != "")
            //{
            //    Console.WriteLine($"{song} 是 {singerName} 演唱的");
            //}
            //else
            //{
            //    Console.WriteLine($"{song} 演唱者找不到");
            //}


            /********************************************************/
            // 字符串: 一串字符的集合, 字符串的内容不可变,但是可以通过下标访问内容
            //string str = "abcdefg";
            //Console.WriteLine(str[0]);
            //Console.WriteLine(str[1]);
            //str[0] = "s"; // 报错, 字符串内容不可修改

            // 字符串可以通过Length属性 获取字符串的长度
            //Console.WriteLine(str.Length); // 7
            // 可以使用 下标 配合 长度 完成字符串的遍历
            //for (int i = 0; i < str.Length; i++) Console.WriteLine(str[i]);

            //// 字符串去重
            //string str = "abcedgjjjsssabcd";
            //string resStr = ""; // 去重后的字符串
            ////遍历str
            //for (int i = 0; i < str.Length; i++)
            //{
            //    // 循环判断 str[i] 在resStr中是否存在
            //    int j = 0;
            //    for (; j < resStr.Length; j++)
            //    {
            //        // 如果str[i] 在resStr中存在则终止for-j循环
            //        if (str[i] == resStr[j]) break;
            //    }
            //    /*
            //     for-j循环结束
            //        1. for循环条件为false, 循环结束, 那么循环结束后j == resStr.Length
            //        2. for循环中执行了break(str[i]在resStr中存在),循环结束, 循环条件还是true             
            //     */
            //    // 循环结束后 j == resStr.Length 成立, 说明for-j循环中没有执行break, 那么str[i] 在resStr中不存在
            //    if (j == resStr.Length) resStr += str[i];
            //}
            //Console.WriteLine(resStr);


            /*********************************************************************/
            // C#中有一个特殊的值null, 可以理解为值为 空
            // 当我们想要将 变量中的值 销毁的时候,可以手动赋值为null
            // 在int类型的 变量中默认不允许为null的值
            //int n = null; // 报错

            //// ? 可以让int类型 变量允许为null
            //int? n = null;

            //// 字符串默认是允许为null
            //string str = null;
            //str += "a";
            //Console.WriteLine(str);

            // 字符串 空值 判断
            //string.IsNullOrEmpty：判断字符串是否为空或null
            //string.IsNullOrWhiteSpace：判断字符串是否为null或空格

            //string str = null;
            ////bool res = string.IsNullOrEmpty(str);
            //bool res = string.IsNullOrWhiteSpace(str);
            //Console.WriteLine(res); // True

            //string str = "";
            ////bool res = string.IsNullOrEmpty(str);
            //bool res = string.IsNullOrWhiteSpace(str);
            //Console.WriteLine(res); // True

            //string str = "   ";
            ////bool res = string.IsNullOrEmpty(str); // False
            //bool res = string.IsNullOrWhiteSpace(str); // True
            //Console.WriteLine(res); 

            //string str = "abc";
            ////bool res = string.IsNullOrEmpty(str); // False
            //bool res = string.IsNullOrWhiteSpace(str); // False
            //Console.WriteLine(res);

            /*********************************************/
            //// Substring：截取字符串
            //// 字符串.Substring(开始下标)   // 从开始下标到最后截取字符串内容
            //// 字符串.Substring(开始下标,个数) // 从开始下标根据个数,截取字符串内容
            //string str = "abcdefg";
            ////string res = str.Substring(2);
            //string res = str.Substring(2, 3);
            //Console.WriteLine(res);


            // Contains：判断字符串中是否包含小字符串（子串）
            //string str = "abcdefg";
            ////bool res = str.Contains("bc");
            //bool res = str.Contains("bcaa");
            //Console.WriteLine(res);

            //// 使用Contains 字符串去重
            //string str = "abcedgjjjsssabcd";
            //string resStr = ""; // 去重后的字符串
            ////遍历str
            //for (int i = 0; i < str.Length; i++)
            //{
            //    if (!resStr.Contains(str[i])) resStr += str[i];
            //}
            //Console.WriteLine(resStr);


            /*******************************************/
            // StartsWith：判断字符串是否用某个子串开头
            // EndsWith：判断字符串是否以某个子串结尾
            //string str = "abcdddddefg";
            ////bool res = str.StartsWith("a");
            ////bool res = str.StartsWith("abc");
            ////bool res = str.StartsWith("aaa");
            ////bool res = str.EndsWith("g");
            ////bool res = str.EndsWith("efg");
            //bool res = str.EndsWith("aaa");
            //Console.WriteLine(res);

            /********************************************/
            //IndexOf：在字符串中找某个子串第一次出现的下标，找到得到下标，找不到得到 - 1
            // 字符串.IndexOf(子串)  查找子串第一次出现的下标
            // 字符串.IndexOf(子串,开始下标)  从开始下标查找子串第一次出现的下标            
            //string str = "abcdebfg";
            ////int index = str.IndexOf("b");
            //int index = str.IndexOf("k");
            ////int index = str.IndexOf("b",2);
            //Console.WriteLine(index);

            //LastIndexOf：在字符串中找某个子串最后一次出现的下标，找到得到下标，找不到得到 - 1
            // 语法参数和IndexOf 一样
            //string str = "abcdebfg";
            ////int index = str.LastIndexOf("b");
            ////int index = str.LastIndexOf("b", 2);
            //int index = str.LastIndexOf("b",0 );
            //Console.WriteLine(index);


            // ToUpper: 将字符串内容转为大写
            // ToLower: 将字符串内容转为小写
            // 注意: 只有英文字符串才有大小写区分
            //string str = "abcDDDDefg";
            //Console.WriteLine(str.ToUpper()); // ABCDDDDEFG
            //Console.WriteLine(str.ToLower()); // abcddddefg


            /*********************************************************/
            // string 字符串类型 使用双引号包裹 表示一串字符的集合 一般用表示一段内容 
            // char 字符类型 使用单引号包裹, 表示单个字符, 字符类型可以和整型转换
            //string str = "ABC";
            //char s = 'A';
            //Console.WriteLine((int)s);

            // Trim：去除字符串首尾两端的空格
            //string str = "  abc    ";
            //Console.WriteLine("-" + str + "|"); // -  abc    |
            //string res = str.Trim();
            //Console.WriteLine("-" + res + "|"); // -abc|

            //string str = ",,!!,abc!!,,,";
            //Console.WriteLine("-" + str + "|"); // -  abc    |
            ////string res = str.Trim(','); // 根据传入的字符去除首尾两端内容
            //string res = str.Trim(',', '!'); // 根据传入的字符去除首尾两端内容
            //Console.WriteLine("-" + res + "|"); // -abc|

            // TrimStart：去除开头的空格
            //string str = "  abc    ";
            //Console.WriteLine("-" + str + "|"); // -  abc    |
            //string res = str.TrimStart();
            //Console.WriteLine("-" + res + "|"); // -abc    |

            // TrimEnd：去除结尾的空格
            //string str = "  abc    ";
            //Console.WriteLine("-" + str + "|"); // -  abc    |
            //string res = str.TrimEnd();
            //Console.WriteLine("-" + res + "|"); // -  abc|

            // Replace：将字符串中指定的子串都替换成的新的子串
            //string str = "abacdaeafeeg";
            ////Console.WriteLine(str.Replace("a","0"));
            //Console.WriteLine(str.Replace("ee","**"));

            //// 敏感词替换为 * , 而且个数要保持一致
            //string str = "生活总会有大麻烦, 黑夜总会过去";
            //// 假设list存储敏感词
            //List<string> mgc = ["大麻", "夜总会"];

            //foreach (string str1 in mgc)
            //{
            //    string newStr = "";
            //    for (int i = 0; i < str1.Length; i++) newStr += "*";

            //    str = str.Replace(str1, newStr);
            //}
            //Console.WriteLine(str);
            //// 生活总会有**烦, 黑***过去

            /******************************************************/
            // Split 分隔字符串
            // 字符串.Split(指定分隔符)
            //string str = "西瓜_葡萄_芒果_榴莲";
            //string[] resArr = str.Split("_");
            ////Console.WriteLine(resArr);
            //foreach(string item in resArr) Console.WriteLine(item);

            //string str = "西瓜 葡萄 芒果 榴莲";
            //string[] resArr = str.Split(); // 默认使用空格作为分隔符
            ////Console.WriteLine(resArr);
            //foreach (string item in resArr) Console.WriteLine(item);

            //string str = "西瓜-葡萄-芒果-榴莲";
            //string[] resArr = str.Split("-",2); // 参数2 数字将字符串分割为两份
            ////Console.WriteLine(resArr);
            //foreach (string item in resArr) Console.WriteLine(item);

            //string str = "西瓜--葡萄--芒果--榴莲"; // ""   "  "
            ////string[] resArr = str.Split("-"); 
            //string[] resArr = str.Split("-", StringSplitOptions.RemoveEmptyEntries);  //移除空字符串 
            ////Console.WriteLine(resArr);
            //foreach (string item in resArr) Console.WriteLine(item);

            //string str = "西瓜-葡萄!芒果+榴莲";
            //string[] resArr = str.Split(['-', '!', '+']);
            ////Console.WriteLine(resArr);
            //foreach (string item in resArr) Console.WriteLine(item);

            //"you love i"转成"I Love You"
            //string oldStr = "you love i";
            //// 将oldStr 通过Split分隔得到 字符串数组 
            //string[] strArr = oldStr.Split();
            //// 将字符串数组转为 List集合,然后调用Reverse方法反转
            //List<string> strList = new();
            //foreach (string str in strArr) strList.Add(str);
            //strList.Reverse();
            //// 将反转后的每个元素字符串的首字母改为大写并拼接为最终的字符串
            //string resStr = "";
            //foreach (string item in strList) {
            //    //Console.WriteLine(item);
            //    string fisrtLetter = item.Substring(0,1).ToUpper(); // 截取第一个字符转大写
            //    string otherLetters = item.Substring(1).ToLower();  // 其他字符转小写
            //    resStr += fisrtLetter + otherLetters + " ";
            //}
            //// 处理最后多余的 " "
            //Console.WriteLine(resStr.Substring(0,resStr.Length-1));

            /*****************************************************/

            // string.Concat：将多个字符串拼接成一个大字符串
            //string str1 = "aa";
            //string str2 = "bb";
            //string str3 = "cc";
            ////string[] strArr = ["qq", "ww", "EE"];
            //string res = string.Concat(str1, str2, str3);
            ////string res = string.Concat(strArr);
            //Console.WriteLine(res); // aabbcc

            // string.Join：将数组或List中的所有元素使用指定的连接符拼接成一个字符串
            //string[] strArr = ["qq", "ww", "EE"];
            //Console.WriteLine(string.Join("-", strArr)); // qq-ww-EE

            //List<string> strList = ["I", "Love", "U"];
            //Console.WriteLine(string.Join(" ",strList)); // I Love U 


            // PadLeft：给字符串左边填充指定的符号填满指定的长度
            // PadRight：给字符串右边填充指定的符号填满指定的长度
            //string str = "aa";
            // 字符串.PadLeft(数字,填充字符) // 数字表示填充后的长度
            //Console.WriteLine(str.PadLeft(2, '*')); // aa
            //Console.WriteLine(str.PadLeft(1, '*')); // aa
            //Console.WriteLine(str.PadLeft(4, '*')); // **aa

            //Console.WriteLine(str.PadRight(3,'*')); // aa*

            //// 敏感词替换为 * , 而且个数要保持一致
            //string str = "生活总会有大麻烦, 黑夜总会过去";
            //// 假设list存储敏感词
            //List<string> mgc = ["大麻", "夜总会"];

            //foreach (string str1 in mgc)
            //{
            //    string newStr = "".PadRight(str1.Length,'*');                
            //    str = str.Replace(str1, newStr);
            //}
            //Console.WriteLine(str);


            // Remove：删除字符串中的一段
            //string str = "abcdefhijk";
            //// 字符串.Remove(开始下标)// 从开始下标往最后的全删除
            //// 字符串.Remove(开始下标,个数)// 从开始下标根据个数删除
            //// 返回的是删除后的字符串
            ////Console.WriteLine(str.Remove(2)); // ab
            //Console.WriteLine(str.Remove(2,3)); // abfhijk
            //Console.WriteLine(str);


            // 正则 提取 方法
            //Regex.Match(字符串, 正则规则);  // 按照规则从字符串中提取内容
            //string reg = @"a";
            //string str = "bac";
            //var res = Regex.Match(str, reg);
            ////Console.WriteLine(res);
            //Console.WriteLine(res.Value); // a

            // 验证方法
            // Regex.IsMatch(字符串,正则)  // 判断字符串是否符合规则内容
            //string reg = @"a";
            //string str = "bac";
            //var res = Regex.IsMatch(str,reg);
            //Console.WriteLine(res);// True
            //Console.WriteLine(Regex.IsMatch("ffed",reg)); // False


            // 替换方法
            // Regex.Replace(字符串,正则,替换上的内容) // 按照正则规则 将字符串中的内容替换上指定字符串
            // 返回替换完成的字符串
            //string reg = @"a";
            //string str = "bac";
            //var res = Regex.Replace(str,reg,"F");
            //Console.WriteLine(res);

            // 特殊字符:  代表规则中要匹配的字符。
            //var reg = @"."; // 表示包含任意一个字符
            //Console.WriteLine(Regex.IsMatch("  ",reg));                
            //Console.WriteLine(Regex.IsMatch(" 你好 ", reg));                

            //var reg = @"\d"; // 表示包含任意一个数字
            //Console.WriteLine(Regex.IsMatch("abc", reg)); // False
            //Console.WriteLine(Regex.IsMatch("abc1", reg));  // True
            //Console.WriteLine(Regex.IsMatch("123", reg));  // True

            //var reg = @"\D"; // 表示包含任意一个非数字
            //Console.WriteLine(Regex.IsMatch("abc", reg)); // True
            //Console.WriteLine(Regex.IsMatch("abc1", reg));  // True
            //Console.WriteLine(Regex.IsMatch("123", reg));  // False

            //var reg = @"\w"; // 表示包含任意一个数字字母下划线
            //Console.WriteLine(Regex.IsMatch("abc", reg)); // True
            //Console.WriteLine(Regex.IsMatch("abc1", reg));  // True
            //Console.WriteLine(Regex.IsMatch("123", reg));  // True
            //Console.WriteLine(Regex.IsMatch("你好_", reg));  // True
            //Console.WriteLine(Regex.IsMatch("你好AAA", reg));  // True
            //Console.WriteLine(Regex.IsMatch("*<>", reg));  // False
            //Console.WriteLine(Regex.IsMatch("!@#$", reg));  // False

            //var reg = @"\W"; // 表示包含任意一个非数字字母下划线
            //Console.WriteLine(Regex.IsMatch("abc", reg)); // False
            //Console.WriteLine(Regex.IsMatch("abc1", reg));  // False
            //Console.WriteLine(Regex.IsMatch("123", reg));  // False
            //Console.WriteLine(Regex.IsMatch("你好_", reg));  // False
            //Console.WriteLine(Regex.IsMatch("你好AAA", reg));  // False
            //Console.WriteLine(Regex.IsMatch("*<>", reg));  // True
            //Console.WriteLine(Regex.IsMatch("!@#$", reg));  // True

            //var reg = @"\s"; // 表示包含任意一个空白符(空格)
            //Console.WriteLine(Regex.IsMatch("abc", reg)); // False
            //Console.WriteLine(Regex.IsMatch("a bc", reg)); // True
            //Console.WriteLine(Regex.IsMatch(" ", reg)); // True
            //Console.WriteLine(Regex.IsMatch("123-ABC", reg)); // False

            //var reg = @"\S"; // 表示包含任意一个非空白符(空格)
            //Console.WriteLine(Regex.IsMatch("abc", reg)); // True
            //Console.WriteLine(Regex.IsMatch("a bc", reg)); // True
            //Console.WriteLine(Regex.IsMatch(" ", reg)); // False
            //Console.WriteLine(Regex.IsMatch("123-ABC", reg)); // True

            //var reg = @"[abc]"; // 表示包含abc中的任意一个字符
            //Console.WriteLine(Regex.IsMatch("abc", reg)); // True
            //Console.WriteLine(Regex.IsMatch("a bc", reg)); // True
            //Console.WriteLine(Regex.IsMatch("c", reg)); // True
            //Console.WriteLine(Regex.IsMatch("C", reg)); // False
            //Console.WriteLine(Regex.IsMatch("123-ABC", reg)); // True

            //var reg = @"[a-z]"; // 表示包含任意一个小写字母
            //Console.WriteLine(Regex.IsMatch("abc", reg)); // True
            //Console.WriteLine(Regex.IsMatch("a bc", reg)); // True
            //Console.WriteLine(Regex.IsMatch("c", reg)); // True
            //Console.WriteLine(Regex.IsMatch("C", reg)); // False
            //Console.WriteLine(Regex.IsMatch("123-ABC", reg)); // False

            // @"[0-9]"  表示任意一个数字
            // @"[A-Z]"  表示任意一个大写字母
            // @"[A-Za-z]"  表示任意一个字母

            //var reg = @"[^abc]"; // 表示包含任意一个除了abc的字符
            //Console.WriteLine(Regex.IsMatch("abc", reg)); // False
            //Console.WriteLine(Regex.IsMatch("a bc", reg)); // True/
            //Console.WriteLine(Regex.IsMatch("c", reg)); // False
            //Console.WriteLine(Regex.IsMatch("C", reg)); // True
            //Console.WriteLine(Regex.IsMatch("123-ABC", reg)); // True

            /**********************************************************/
            //量词: 修饰前面的字符要匹配到的数量。
            //var reg = @"a*"; // 表示包含任意个字符a
            ////Console.WriteLine(Regex.IsMatch("abc", reg)); // True
            ////Console.WriteLine(Regex.IsMatch("a bc", reg)); // True
            ////Console.WriteLine(Regex.IsMatch("c", reg)); // True
            ////Console.WriteLine(Regex.IsMatch("C", reg)); // True
            ////Console.WriteLine(Regex.IsMatch("123-ABC", reg)); // True
            //Console.WriteLine(Regex.Match("abc", reg)); // a
            //Console.WriteLine(Regex.Match("123-ABC", reg)); // 

            //var reg = @"\d+"; // 表示包含至少1个数字字符
            //Console.WriteLine(Regex.IsMatch("abc", reg)); // False
            //Console.WriteLine(Regex.IsMatch("a2bc", reg)); // True
            //Console.WriteLine(Regex.IsMatch("c", reg)); // False
            //Console.WriteLine(Regex.IsMatch("123", reg)); // True
            //Console.WriteLine(Regex.IsMatch("123-ABC", reg)); // True

            //var reg = @"\d?"; // 表示包含0个或1个数字字符
            ////Console.WriteLine(Regex.IsMatch("abc", reg)); // True
            ////Console.WriteLine(Regex.IsMatch("a2bc", reg)); // True
            ////Console.WriteLine(Regex.IsMatch("c", reg)); // True
            ////Console.WriteLine(Regex.IsMatch("123", reg)); // True
            ////Console.WriteLine(Regex.IsMatch("123-ABC", reg)); // True
            //Console.WriteLine(Regex.Match("abc", reg)); //
            //Console.WriteLine(Regex.Match("123-ABC", reg)); // 1 

            //var reg = @"\d{3}"; // 表示包含三个连续的数字字符
            ////Console.WriteLine(Regex.IsMatch("abc", reg)); // False
            ////Console.WriteLine(Regex.IsMatch("a2bc", reg)); // False
            ////Console.WriteLine(Regex.IsMatch("c", reg)); // False
            ////Console.WriteLine(Regex.IsMatch("123", reg)); // True
            ////Console.WriteLine(Regex.IsMatch("123-ABC", reg)); // True
            ////Console.WriteLine(Regex.IsMatch("1c23", reg)); // False
            //Console.WriteLine(Regex.Match("1abc12", reg)); //
            //Console.WriteLine(Regex.Match("123-ABC", reg)); // 123 

            //var reg = @"\d{3,5}"; // 表示包含3到5个连续的数字字符
            ////Console.WriteLine(Regex.IsMatch("abc", reg)); // False
            ////Console.WriteLine(Regex.IsMatch("a2bc", reg)); // False
            ////Console.WriteLine(Regex.IsMatch("c", reg)); // False
            ////Console.WriteLine(Regex.IsMatch("a123", reg)); // True
            ////Console.WriteLine(Regex.IsMatch("a1123", reg)); // True
            ////Console.WriteLine(Regex.IsMatch("a11235", reg)); // True
            ////Console.WriteLine(Regex.IsMatch("12323-ABC", reg)); // True
            ////Console.WriteLine(Regex.IsMatch("1c2333333", reg)); // True
            //Console.WriteLine(Regex.Match("1abc1222", reg)); // 1222
            //Console.WriteLine(Regex.Match("123-ABC", reg)); // 123 

            //var reg = @"\d{3,}"; // 表示包含3到无数个连续的数字字符
            ////Console.WriteLine(Regex.IsMatch("abc", reg)); // False
            ////Console.WriteLine(Regex.IsMatch("a2bc", reg)); // False
            ////Console.WriteLine(Regex.IsMatch("c", reg)); // False
            ////Console.WriteLine(Regex.IsMatch("a123", reg)); // True
            ////Console.WriteLine(Regex.IsMatch("a1123", reg)); // True
            ////Console.WriteLine(Regex.IsMatch("a11235", reg)); // True
            ////Console.WriteLine(Regex.IsMatch("12323-ABC", reg)); // True
            ////Console.WriteLine(Regex.IsMatch("1c2333333", reg)); // True
            //Console.WriteLine(Regex.Match("1abc1222111111", reg)); // 1222111111
            //Console.WriteLine(Regex.Match("123-ABC", reg)); // 123 

            /*********************************************************/
            // 其他符号
            //// ^ 表示以什么内容开头  必须书写在最开头
            //var reg = @"^\d{3}"; // 表示必须以3到个连续的数字字符开头
            //Console.WriteLine(Regex.IsMatch("12abc", reg)); // False
            //Console.WriteLine(Regex.IsMatch("123abc", reg)); // True
            //Console.WriteLine(Regex.IsMatch("111abc", reg)); // True
            //Console.WriteLine(Regex.IsMatch("123456abc", reg)); // True
            //Console.WriteLine(Regex.IsMatch("1a23111", reg)); // False
            //Console.WriteLine(Regex.IsMatch("12z33333", reg)); // False

            //// $ 表示以什么内容结尾  必须书写在最后
            //var reg = @"\d{3}$"; // 表示必须以3到个连续的数字字符结尾
            //Console.WriteLine(Regex.IsMatch("12abc", reg)); // False
            //Console.WriteLine(Regex.IsMatch("123abc", reg)); // False
            //Console.WriteLine(Regex.IsMatch("111abc11", reg)); // False
            //Console.WriteLine(Regex.IsMatch("123456abc123", reg)); // True
            //Console.WriteLine(Regex.IsMatch("1a23111", reg)); // True
            //Console.WriteLine(Regex.IsMatch("12z33333", reg)); // True


            //// 以匹配到的这三个数字开头, 并以匹配到的这三个数字结尾
            //var reg = @"^\d{3}$"; // 表示必须  3个连续的数字字符
            //Console.WriteLine(Regex.IsMatch("12abc", reg)); // False
            //Console.WriteLine(Regex.IsMatch("123abc", reg)); // False
            //Console.WriteLine(Regex.IsMatch("111", reg)); // True
            //Console.WriteLine(Regex.IsMatch("123", reg)); // True
            //Console.WriteLine(Regex.IsMatch("123a123", reg)); // False
            //Console.WriteLine(Regex.IsMatch("123123", reg)); // False
            //Console.WriteLine(Regex.IsMatch("1a23111", reg)); // False
            //Console.WriteLine(Regex.IsMatch("12z33333", reg)); // False


            //var reg = @"a|bc"; // 表示  包含一个a或者bc 
            //Console.WriteLine(Regex.IsMatch("12abc", reg)); // True
            //Console.WriteLine(Regex.IsMatch("123abc", reg)); // True
            //Console.WriteLine(Regex.IsMatch("111", reg)); // False
            //Console.WriteLine(Regex.IsMatch("123", reg)); // False
            //Console.WriteLine(Regex.IsMatch("123a123", reg)); // True
            //Console.WriteLine(Regex.IsMatch("123123", reg)); // False
            //Console.WriteLine(Regex.IsMatch("1a23111", reg)); // True
            //Console.WriteLine(Regex.IsMatch("12z33333", reg)); // False


            //var reg = @"[\u4e00-\u9fa5]"; // 表示  包含一个汉字
            //Console.WriteLine(Regex.IsMatch("12abc", reg)); // False
            //Console.WriteLine(Regex.IsMatch("hello", reg)); // False
            //Console.WriteLine(Regex.IsMatch("hel你好lo", reg)); // True
            //Console.WriteLine(Regex.IsMatch("hel你lo", reg)); // True


            //var reg = @"\."; // 表示  包含字符.
            //Console.WriteLine(Regex.IsMatch("12abc", reg)); // False
            //Console.WriteLine(Regex.IsMatch("he.llo", reg)); // True
            //Console.WriteLine(Regex.IsMatch("hel你好lo", reg)); // False
            //Console.WriteLine(Regex.IsMatch("hel.你lo", reg)); // True


            /***********************************************************/

            // 提取
            //string reg = @"a|b";
            //string str = "abc";
            //var res1 = Regex.Match(str, reg);
            //Console.WriteLine(res1.Value);
            //var res2 = Regex.Match(str, reg);
            //Console.WriteLine(res2.Value);

            //// 多次提取
            //string reg = @"a|b";
            //string str = "abc";
            //MatchCollection res = Regex.Matches(str, reg);
            ////Console.WriteLine(res);
            ////Console.WriteLine(res[0]);
            ////Console.WriteLine(res[1]);
            //foreach (var item in res) Console.WriteLine(item);

            //分组: 用小括号表示一组
            //string reg = @"(\d{4})-(\d{2})-(\d{2})";
            //Match res = Regex.Match("2026-08-22", reg);
            ////Console.WriteLine(res);
            ////Console.WriteLine(res.Value);
            //// 正则中的() 是一个个单独的整体,除了整个正则表达式会匹配之外, 每个小括号也会单独匹配
            //// 这些小括号单独匹配的内容 在整体匹配结果的分组中
            ////Console.WriteLine(res.Groups);
            //Console.WriteLine(res.Groups[0]); // 整体正则匹配的结果
            //Console.WriteLine(res.Groups[1]);  // 第一个小括号匹配的结果
            //Console.WriteLine(res.Groups[2]);  // 第二个小括号匹配的结果
            //Console.WriteLine(res.Groups[3]);  // 第三个小括号匹配的结果


            // (?:字符) 代表这个小括号, 只表示一个小整体,不会单独匹配
            //string reg = @"(?:\d{4})-(?:\d{2})-(?:\d{2})";
            //Match res = Regex.Match("2026-07-22", reg);
            //Console.WriteLine(res.Value); // 2026-07-22
            //Console.WriteLine(res.Groups[0]); // 2026-07-22
            //Console.WriteLine(res.Groups[1]); //  获取不到(没有单独匹配的小括号)
            //Console.WriteLine(res.Groups.Count); // 1


            //var reg = @"^a|b$";
            //Console.WriteLine(Regex.IsMatch("a",reg)); // True
            //Console.WriteLine(Regex.IsMatch("b",reg)); // True
            //Console.WriteLine(Regex.IsMatch("accc",reg)); // True
            //Console.WriteLine(Regex.IsMatch("cccb", reg)); // True


            //var reg = @"^(a|b)$";
            //Console.WriteLine(Regex.IsMatch("a", reg)); // True
            //Console.WriteLine(Regex.IsMatch("b", reg)); // True
            //Console.WriteLine(Regex.IsMatch("accc", reg)); // False
            //Console.WriteLine(Regex.IsMatch("cccb", reg)); // False

            //案例：

            //-手机号 // 假设第二位不能是0
            var reg1 = @"^1[1-9]\d{9}$";
            //- qq号
            var reg2 = @"[1-9]\d{4,8}";
            //- QQ邮箱号
            var reg3 = @"[1-9]\d{4,8}@qq\.com";
            //- 提取一句话中的所有工资
            var str = "你的工资是: 10000 我的工资是:3000,小明的工资是: 20000";
            var reg4 = @"[1-9]\d{3,}";
            var res = Regex.Matches(str, reg4);
            foreach (var item in res) Console.WriteLine(item);

        }
    }
}
