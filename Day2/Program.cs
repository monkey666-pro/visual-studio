using System.Runtime.InteropServices;

namespace Day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, dynamic> user = new Dictionary<string, dynamic>
            {
                ["name"] = "刚刚",
                ["age"] = 18,
                ["mex"]=14,
                ["main"]= new Dictionary<string, dynamic>()
                {
                    ["name"]="俄格",
                    ["age"]=21,
                }
            };
            //输出对应的键值
                Console.WriteLine(user["name"]);
                Console.WriteLine(user["main"]["age"]);
            //修改键值
                user["name"] = "经济法";
                Console.WriteLine(user["name"]);
                user["main"]["age"] = "让她和她";
                Console.WriteLine(user["main"]["age"]);
            //获取对应键值
                //Console.WriteLine(user["main"].TryGetValue("name", out dynamic val));
                //Console.WriteLine(val);
            //删除对应键值
                //user.Remove("age");
                //Console.WriteLine(user.TryGetValue("age", out dynamic val1));
            //获取元素个数
                //Console.WriteLine(user.Count);
                //Console.WriteLine(user["main"].Count);
            //清空键值 变量名.clear()
               // user["main"].Clear();
              // Console.WriteLine(user.TryGetValue("mex", out dynamic v1));

            //数组
            List<string> aaa = new List<string>() { "gh","egeg"};
            //Console.WriteLine(aaa[0]);
            //Console.WriteLine(aaa.Count);
            List<string> A = new List<string>(4) { "A", "B", "C", "D" };
            //往尾部加数据
            //A.Add("Z");
            //Console.WriteLine(A[4]);
            //往目标索引增加数据
            //A.Insert(2, "X");
            //Console.WriteLine(A[2]);
            //增加多数据
            //A.AddRange(["Q", "W", "E"]);
            //删除数据
            // A.Remove("A");
            // Console.WriteLine(A[0]);
            //删除索引
            // A.RemoveAt(2);
            //Console.WriteLine(A[5]);
            //点名器
            // List<string> D = new List<string>()
            // {
            //    "李","李1","李2","李3","李4","李5","李6","李7","李8","李9","李10","李11","李12"
            // };
            // Random r = new Random();
            // int num = r.Next(D.Count);

            //  Console.WriteLine(D.Count);
            //dynamic(可变类型变量)
                dynamic a = 10;
                Console.WriteLine($"a:{a}");
                dynamic b = "很好吃";
                Console.WriteLine($"a:{a}");
            //.GetType()---变量类型检测
                int n = 10;
                Console.WriteLine( n.GetType());
                double n1 = 10.1;
                Console.WriteLine( n1.GetType());
                string n12 = "而二极管";
                Console.WriteLine(n12.GetType());
                bool bbb = true;
                Console.WriteLine(bbb.GetType());
            //匿名类型var
                var a11 = new
                {
                    name = "我",
                    age = 18,
                };
                Console.WriteLine(a11);
                Console.WriteLine(a11.GetType());
            //数据字典
                Dictionary<string, dynamic> ZD = new Dictionary<string, dynamic>
                {
                    ["name"] = "♥",
                    ["age"] = 17,
                    ["new1"] = new Dictionary<string, dynamic>
                    {
                        ["name"] = "我",
                        ["age"] = 19
                    }
                };
                Console.WriteLine(ZD["name"]);
                Console.WriteLine(ZD["new1"]["name"]);
            //获取键值.TryGetValue
                ZD.TryGetValue("name", out dynamic val);
                Console.WriteLine(val);
                ZD["new1"].TryGetValue("name", out dynamic va1);
                Console.WriteLine(va1);
            //修改
                ZD["new1"]["name"] = "rc";
                Console.WriteLine(ZD["new1"]["name"]);
                ZD["name"] = "多好多好";
                Console.WriteLine(ZD["name"]);
            //添加
                ZD["HOT"] = 20;
                Console.WriteLine(ZD["HOT"]);
            //清空
                ZD.Clear();
            //数组
            int[] a33 = new int[] {10,20,3,333 };
                Console.WriteLine(a33[0]);
                Console.WriteLine(a33[1]);
                Console.WriteLine(a33[2]);
            //获取长度
                Console.WriteLine(a33.Length);
                Console.WriteLine(a33.Count());
            //list
                List<string> aaaa = new List<string>() {"d","w","3" };
                Console.WriteLine(aaaa[0]);
                Console.WriteLine(aaaa[1]);
                Console.WriteLine(aaaa[2]);
                aaaa[0] = "qq";
                Console.WriteLine(aaaa[0]);
                Console.WriteLine(aaaa.Count());
            //add
                aaaa.Add("rrr");
                Console.WriteLine(aaaa[3]);
                aaaa.AddRange([ "idwjd","efieh"]);
                Console.WriteLine(aaaa.Count);
                aaaa.AddRange(new List<string>() { "阿" ,"二号"});
                Console.WriteLine(aaaa.Count);
            //insert
                aaaa.Insert(2, "插入");
                Console.WriteLine(aaaa[2]);
            //remove 删除
                aaaa.Remove("插入");
                Console.WriteLine(aaaa[2]);
            //removerange
                aaaa.RemoveRange(0, 3);
                Console.WriteLine(aaaa[0]);
            //removeat
                aaaa.RemoveAt(0);
                Console.WriteLine(aaaa[0]);
            //clear,contains
                aaaa.Clear();
                Console.WriteLine(aaaa.Contains("二号"));
            //indexof,lastindexof
                List<int> shuzi = new List<int>() {10,12,1212,121,12,134 };
                Console.WriteLine(shuzi.IndexOf(12));
                Console.WriteLine(shuzi.LastIndexOf(12));
            //getrange
                List<int> shuzi1 = shuzi.GetRange(0, 3);
                Console.WriteLine(shuzi1[0]);
                Console.WriteLine(shuzi1[1]);
                Console.WriteLine(shuzi1[2]);
            //reverse
                shuzi.Reverse();
                Console.WriteLine(shuzi[0]);
            //随机数
             Random A1 = new Random();
            int num = A1.Next(2, 9);
            Console.WriteLine(num);
            
            Console.WriteLine(A1.NextDouble());
            //点名器
            List<string> dianmin= new List<string>() { "谢谊","覃东稳",
    "姜添舒","张小松","方锦",
    "黄陆基","王耀腾","李佳鑫",
    "蓝启耿","周佳龙","黄宇盛",
    "韦炳湘","韩旭颖","钟朝林",
    "曾杰文","李卓达","彭钇霖",
    "田健","何战胜","徐诚",
    "张仁杰","龙昊","陈佳",
    "陈志锋","王明宇","李之阳",
    "潘家涵","蓝浩天","杨天硕",
    "董俊涛","蒙琛 ","张英玉",
    "陈煜松","莫远宁","李家良",
    "丁佳俊","谭森华","刘宏阳",
    "宁东明","崔世锦","唐海波",};
            Random DM = new Random();
            int DM1 = DM.Next(dianmin.Count);
            Console.WriteLine(dianmin[DM1]);
            List<Dictionary<string, dynamic>> shango = new List<Dictionary<string, dynamic>>()
            {
                new Dictionary<string,dynamic>(){ }

            };



























        }
    }
}
