using System.Text.RegularExpressions;

namespace P2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            Console.WriteLine( "请输入5个字符串");
            for (int i2 = 0; i2 < 5; i2++)
            {
                var i3= Console.ReadLine();
                i3.Trim();
                i3.ToLower();
                list.Add(i3);
            }

            var reg = @"^1[34578]\d{9}$";
            var reg1 = @"^[^1]\d{10}$";
            var reg2 = @"\D";
            foreach (dynamic i in list)
            {
                if(Regex.IsMatch(i,reg)) Console.WriteLine($"{i}-合法手机号");
                if (Regex.IsMatch(i, reg1)) Console.WriteLine($"{i}-非法手机号");
                if (Regex.IsMatch(i, reg2)) Console.WriteLine($"{i}-普通文本");

            }
        }
    }
}
