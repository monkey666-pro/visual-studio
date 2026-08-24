using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace day13
{
    // 静态工具类
    internal static class Tool
    {
        // 获取随机小数 0~1
        public static double GetRanD()
        {
            return new Random().NextDouble();
        }
        // 获取范围整数
        public static int GetRanI(int n, int m = 0)
        {
            return new Random().Next(m, n);
        }

        // 获取随机小写字母
        public static char GetRanL()
        {
            var str = "qwertyuiopasdfghjklzxcvbnm";
            int index = GetRanI(str.Length - 1);
            return str[index];
        }

        // 序列化数据
        public static string JsonFn(List<Dictionary<string,dynamic>> data)
        {
            return JsonSerializer.Serialize(data, new JsonSerializerOptions
            {
                WriteIndented = true,
                AllowTrailingCommas = true,

            });
        }


    }
}
