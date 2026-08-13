using System;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace Day7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "清风漫过湖畔，午间薄雾缓缓消散，夜色悄然而至，河水静静流淌，渡船缓缓靠岸，渡口游人往来，相逢知己相交，互换见闻感受，留心世间风情，记录山河晚报。";
            string salt = "7-16-30-38-49-52-63-70";
            string result = ""; // 最终获取到的情报
            string[] fenge = salt.Split("-");
            int mum =0 ;
            for (int o = 0; o < fenge.Length; o++)
            {
                mum = int.Parse(fenge[o]);
                     result += text[mum];
            }


            Console.WriteLine(result); // 午夜渡口交换情报

            string salt1 = "午夜渡口交换情报";
            List<int> jieguo = new();
            string jieguo1 = "";
            for (int i1 = 0; i1 < salt1.Length; i1++)
            {
                int index= text.IndexOf(salt1[i1]);
                jieguo.Add(index);
            }
            Console.WriteLine( string.Join("-",jieguo));//通过情报获得码

            string salt2 = "午夜渡口交换情报";
            List<int> jieguo11 = new();
            string jieguo22 = "";
            for (int i1 = 0; i1 < salt1.Length; i1++)
            {
                int index = text.IndexOf(salt2[i1])-1;
                jieguo11.Add(index);
            }
            jieguo22=(string.Join("-", jieguo11));//通过情报获得码的上一个字符，然后需要解密得到情报
            Console.WriteLine(jieguo22);
            //进行解密
            string []res = jieguo22.Split("-");
            string jiemi = "";
            for (int o = 0; o < res.Length; o++)
            {
                int index = int.Parse(res[o]) + 1;
                jiemi += text[index];
            }
            Console.WriteLine(jiemi);
            ;
            //奇- 偶+
            List<int> ma = new();

            for (int i = 0; i < jiemi.Length; i++)
            {
                int index = text.IndexOf(jiemi[i]);
                index += index % 2 == 0 ? 1 : -1;
                ma.Add(index);
            }
            string mimama=(string.Join("-",ma));
            Console.WriteLine(mimama);

            //通过码进行解密获取情报
            string[] ma1 = mimama.Split("-");
            string jiemi1 = "";
            for (int i = 0; i < ma1.Length; i++)
            {
                int index=int.Parse(ma1[i]);
                index += index % 2 == 0 ? 1 : -1;
                jiemi1 += text[index];
            }
            Console.WriteLine(jiemi1);
            int money = 100096;
            string zhuanhua = money.ToString();
            string[] arr = ["零", "壹", "贰", "叁", "肆", "伍", "陆", "柒", "捌", "玖"];
            // 创建单位数组
            string[] units = ["", "拾", "佰", "仟", "萬", "拾", "佰", "仟", "亿"];
            string result33 = "";
            for (int i = zhuanhua.Length - 1; i >= 0; i--)//从后面开始排，一个数对应相应的单位，最后倒着输出
            {
                int index = int.Parse(zhuanhua[i].ToString());
                int danwei = zhuanhua.Length - 1 - i;
                string unit = units[danwei];
                if (index != 0)
                {
                    result33 = arr[index] + unit + result33;
                }

                else
                    if (zhuanhua.Length - i == 5)
                {
                    result33 = arr[index] + unit + result33;
                }
                else result33 = arr[index] + result33;
            }

            result33=(Regex.Replace(result33,@"零+","零"));
            result33=(Regex.Replace(result33, @"零+萬", "萬"));
            if (result33.EndsWith("零") == true)
            {
                result33.Substring(0, result33.Length - 1);
            }
            Console.WriteLine(result33);
            ////int money = 100096;10089
            ////string zhuanhua = money.ToString();
            ////string[] arr = ["零", "壹", "贰", "叁", "肆", "伍", "陆", "柒", "捌", "玖"];
            ////// 创建单位数组
            ////string[] units = ["", "拾", "佰", "仟", "萬", "拾", "佰", "仟", "亿"];
            ////string result33 = "";
            ////for (int i = zhuanhua.Length - 1; i >= 0; i--)
            ////{
            ////    int dex = int.Parse(zhuanhua[i].ToString());
            ////    int index = zhuanhua.Length - 1 - i;
            ////    string unit = units[index];
            ////    if (index != 0|| zhuanhua.Length - i == 5)
            ////    {
            ////        result33 = arr[dex] + unit + result33;
            ////    }
            ////    else
            ////    {
            ////        result33 = arr[dex] + result33;
            ////    }
            ////}
            ////result33 = Regex.Replace(result33, @"零+", "零");
            ////result33 = Regex.Replace(result33, @"零+萬", "萬");
            ////if(result33.EndsWith("萬"))result33.Substring(0,result33.Length-1);
            ////Console.WriteLine(result33);

            ////List<Dictionary<string, dynamic>> singerList = new List<Dictionary<string, dynamic>>
            ////    {
            ////        new Dictionary<string, dynamic>
            ////        {
            ////            {"singerId", 1001},
            ////            {"singerName", "周杰伦"},
            ////            {"genre", "流行"}
            ////        },
            ////        new Dictionary<string, dynamic>
            ////        {
            ////            {"singerId", 1002},
            ////            {"singerName", "林俊杰"},
            ////            {"genre", "华语流行"}
            ////        },
            ////        new Dictionary<string, dynamic>
            ////        {
            ////            {"singerId", 1003},
            ////            {"singerName", "邓紫棋"},
            ////            {"genre", "流行、摇滚"}
            ////        }
            ////    };
            ////var options = new JsonSerializerOptions
            ////{
            ////    WriteIndented = true,
            ////    AllowTrailingCommas = true,
            ////};
            ////string json=JsonSerializer.Serialize(singerList,options);
            ////Console.WriteLine(json);
        }
    }
}
