using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Day14
{
    internal static class tool
    {
        public static double Getrand()
        {
            return new Random().NextDouble();
        }
        public static int Getrani(int n, int m = 0)
        {
            return new Random().Next(m, n);
        }
        public static char get()
        {
            var str = "getwgwegwgwge";
            int index = Getrani(str.Length - 1);
            return str[index];
        }
        public static string jsonfn(List<Dictionary<string,dynamic>> data)
        {
            return JsonSerializer.Serialize(data, new JsonSerializerOptions
            {
                WriteIndented = true,
                AllowTrailingCommas = true,
            });
        }
    };

}
