using System.Security.Cryptography;

namespace Day5
{
    internal class Program
    {
        static void Main(string[] args)
        {
                        List<Dictionary<string, dynamic>> singerList = new List<Dictionary<string, dynamic>>
            {
                new Dictionary<string, dynamic>
                {
                    {"singerId", 1001},
                    {"singerName", "周杰伦"},
                    {"genre", "流行"}
                },
                new Dictionary<string, dynamic>
                {
                    {"singerId", 1002},
                    {"singerName", "林俊杰"},
                    {"genre", "华语流行"}
                },
                new Dictionary<string, dynamic>
                {
                    {"singerId", 1003},
                    {"singerName", "邓紫棋"},
                    {"genre", "流行、摇滚"}
                },
                new Dictionary<string, dynamic>
                {
                    {"singerId", 1004},
                    {"singerName", "薛之谦"},
                    {"genre", "抒情流行"}
                },
                new Dictionary<string, dynamic>
                {
                    {"singerId", 1005},
                    {"singerName", "毛不易"},
                    {"genre", "民谣流行"}
                }
            };

                        List<Dictionary<string, dynamic>> songList = new List<Dictionary<string, dynamic>>
            {
                new Dictionary<string, dynamic>
                {
                    {"songId", 10001},
                    {"singerId", 1001},
                    {"songName", "青花瓷"},
                    {"duration", 239}
                },
                new Dictionary<string, dynamic>
                {
                    {"songId", 10002},
                    {"singerId", 1001},
                    {"songName", "发如雪"},
                    {"duration", 253}
                },
                new Dictionary<string, dynamic>
                {
                    {"songId", 10003},
                    {"singerId", 1001},
                    {"songName", "东风破"},
                    {"duration", 215}
                },
                new Dictionary<string, dynamic>
                {
                    {"songId", 1004},
                    {"singerId", 3002},
                    {"songName", "不为谁而作的歌"},
                    {"duration", 296}
                },
                new Dictionary<string, dynamic>
                {
                    {"songId", 1005},
                    {"singerId", 1002},
                    {"songName", "背对背拥抱"},
                    {"duration", 262}
                }
            };
            //通过歌曲找歌手
            Console.WriteLine("请输入歌曲");
            dynamic gequ = Console.ReadLine();
            dynamic ID1 = 0;
            foreach (Dictionary<string,dynamic> i in songList)
            {
                if (gequ == i["songName"]) ID1 = i["singerId"];
            }
            var GG = new List<Dictionary<string, dynamic>>();
            foreach (Dictionary<string,dynamic> i in singerList)
            {
                if (ID1 == i["singerId"]) GG.Add(i);
            }
            foreach (dynamic i in GG) Console.WriteLine(i["singerName"]);
            //通过歌手找专辑
            Console.WriteLine("请输入您找的歌手");
            dynamic geshou = Console.ReadLine();
            dynamic ID = 0;
            foreach (Dictionary<string,dynamic> i in singerList)
            {
                if (geshou == i["singerName"]) ID = i["singerId"];
            }
            var jieguo = new List <Dictionary<string, dynamic>>();
            foreach (Dictionary<string, dynamic> i in songList)
            {
                if (ID == i["singerId"]) jieguo.Add(i);
            }
            foreach (dynamic jieguo1 in jieguo)
            {
                Console.WriteLine(jieguo1["songName"]);
            }

            //数组定义1
            int[] arr = new int[5];
            Console.WriteLine(arr[0]);
            arr[0] = 666;
            Console.WriteLine(arr[1]);
            //数组方式2
            int[] arr1 = new int[] { 10, 20, 30 };
            foreach (int i in arr1) { Console.WriteLine(i); }
            foreach (int i in arr) Console.WriteLine();
            for (int i = 0; i < arr.Length; i++) Console.WriteLine(arr[i]);
            ;
            //简化
            int[] arr2 = { 10, 20, 30 };
            foreach (int i in arr2) Console.WriteLine(i);
            //字典
            Dictionary<string, dynamic> arr3 = new()
            {
                ["name"] = "张三",
                ["age"] = 19
            };
            //增加键对值
            arr3.Add("heigh", 18);
            Console.WriteLine(arr3["heigh"]);
            foreach (var i in arr3) Console.WriteLine(i);
            //keys
            var rrr = arr3.Keys;
            Console.WriteLine(rrr);
            string[] keyarr3 = rrr.ToArray();//键集合转化为数组
            foreach (string i in keyarr3) Console.WriteLine(i);
            //value
            var rrr2 = arr3.Values;
            Console.WriteLine(rrr2);
            dynamic[] keyrrr2 = rrr2.ToArray();
            Console.WriteLine(keyrrr2);
            foreach (var i in keyrrr2) Console.WriteLine(i);
            //containskey、containsvalue
            Console.WriteLine(arr3.ContainsKey("heigh"));
            Console.WriteLine(arr3.ContainsKey("ggg"));
            Console.WriteLine(arr3.ContainsValue(18));
            Console.WriteLine(arr3.ContainsValue(20));
            //remove
            // arr3.Remove("name");
            foreach (var i in arr3) Console.WriteLine(i);
            foreach (var i in arr3) Console.WriteLine(i.Key);
            foreach (var i in arr3) Console.WriteLine(i.Value);
            //keys
            var arrkey = arr3.Keys;
            Console.WriteLine(arrkey);
            string[] kk = arrkey.ToArray();
            foreach (var i in kk) Console.WriteLine(i);
            //value
            var arrkey1 = arr3.Values;
            Console.WriteLine(arrkey1);
            dynamic[] kk1 = arrkey1.ToArray();
            foreach (var i in kk1) Console.WriteLine(i);
            //tryadd
            Console.WriteLine(arr3.TryAdd("name", "张三"));
            Console.WriteLine(arr3.TryAdd("name", "张四"));
            Console.WriteLine(arr3.TryAdd("name1", "张四"));
            //遍历
            foreach (var i in arr3)
            {
                Console.WriteLine(i.Value);
                Console.WriteLine(i.Key);
                Console.WriteLine(i);
            }
            //list 去重1
            List<int> ints = [1, 3, 3, 4, 5, 6, 7, 7, 8, 6, 4, 2, 3];
            //List<int> int1s = [];
            //foreach (int i in ints)
            //{
            //    if (int1s.Contains(i) == false)
            //    {
            //        int1s.Add(i);

            //    }

            //}
            //foreach (int i in int1s) Console.Write(i);
            //去重2
            for (int i = 0; i < ints.Count; i++)
            {
                if (ints.LastIndexOf(ints[i]) != ints.IndexOf(ints[i]))
                {
                    ints.RemoveAt(i);
                }
            }
            foreach (int i in ints) Console.WriteLine(i);
            //去重三
            Dictionary<int, dynamic> zidian = new();
            foreach (int i in ints)
            {
                zidian[i] = "aaa";
            }
            List<int> newzidian = zidian.Keys.ToList();
            foreach (int i in newzidian) Console.WriteLine(i);

            //冒泡排序
            dynamic tem;
            int[] maopao = [2, 7, 4, 3, 6, 5, 1];
            for (int i = 0; i < maopao.Length - 1; i++)
            {
                for (int j = 0; j < maopao.Length - 1; j++)
                {
                    if (maopao[j] > maopao[j + 1])
                    {
                        tem = maopao[j];
                        maopao[j] = maopao[j + 1];
                        maopao[j + 1] = tem;
                    }
                }
            }
            foreach (int i in maopao) Console.Write(i);
            //商品排序
            List<Dictionary<string, dynamic>> goodsList = new List<Dictionary<string, dynamic>>
{
            new Dictionary<string, dynamic>
            {
                {"name", "机械键盘"},
                {"price", 299.99},
                {"code", "G001"},
                {"stock", 120}
            },
            new Dictionary<string, dynamic>
            {
                {"name", "无线鼠标"},
                {"price", 89.50},
                {"code", "G002"},
                {"stock", 356}
            },
            new Dictionary<string, dynamic>
            {
                {"name", "27寸显示器"},
                {"price", 1299.00},
                {"code", "G003"},
                {"stock", 48}
            },
            new Dictionary<string, dynamic>
            {
                {"name", "电竞耳机"},
                {"price", 199.00},
                {"code", "G004"},
                {"stock", 85}
            },
            new Dictionary<string, dynamic>
            {
                {"name", "电脑支架"},
                {"price", 69.90},
                {"code", "G005"},
                {"stock", 210}
            }
        };
            for (int j = 0; j < goodsList.Count - 1; j++)
            {
                for (int i = 0; i < goodsList.Count - 1 - j; i++)
                {
                    if (goodsList[i]["price"] > goodsList[i + 1]["price"])
                    {
                        dynamic tmp = goodsList[i];
                        goodsList[i] = goodsList[i + 1];
                        goodsList[i + 1] = tmp;
                    }
                }
            }
            foreach (dynamic item in goodsList) Console.WriteLine($"{item["name"]}--{item["price"]}");
            Console.WriteLine("请输入选择比较的条件");
            dynamic TJ = Console.ReadLine();

            dynamic tem1, tem2, tem3, tem4;
            if (TJ == "price")
            {
                Console.WriteLine("请输入ASC(升序)/DSC（降序）");
                dynamic TJ1 = Console.ReadLine();
                if (TJ1 == "ASC")
                {
                    for (int j = 0; j < goodsList.Count - 1; j++)
                    {
                        for (int i = 0; i < goodsList.Count - 1 - j; i++)
                        {

                            if (goodsList[i]["price"] > goodsList[i + 1]["price"])
                            {
                                tem1 = goodsList[i];
                                goodsList[i] = goodsList[i + 1];
                                goodsList[i + 1] = tem1;
                            }

                        }
                    }
                    foreach (dynamic item in goodsList) Console.WriteLine($"{item["name"]}--{item["price"]}");
                }
                if (TJ1 == "DSC")
                {
                    for (int j = 0; j < goodsList.Count - 1; j++)
                    {
                        for (int i = 0; i < goodsList.Count - 1 - j; i++)
                        {

                            if (goodsList[i]["price"] < goodsList[i + 1]["price"])
                            {
                                tem2 = goodsList[i + 1];
                                goodsList[i + 1] = goodsList[i];
                                goodsList[i] = tem2;
                            }

                        }
                    }
                    foreach (dynamic item in goodsList) Console.WriteLine($"{item["name"]}--{item["price"]}");
                }
            }
            if (TJ == "stock")
            {
                Console.WriteLine("请输入ASC(升序)/DSC（降序）");
                dynamic TJ2 = Console.ReadLine();
                if (TJ2 == "ASC")
                {
                    for (int j = 0; j < goodsList.Count - 1; j++)
                    {
                        for (int i = 0; i < goodsList.Count - 1 - j; i++)
                        {

                            if (goodsList[i]["stock"] > goodsList[i + 1]["stock"])
                            {
                                tem3 = goodsList[i];
                                goodsList[i] = goodsList[i + 1];
                                goodsList[i + 1] = tem3;
                            }
                        }
                    }
                    foreach (dynamic item in goodsList) Console.WriteLine($"{item["name"]}--{item["stock"]}");
                }
                if (TJ2 == "DSC")
                {
                    for (int j = 0; j < goodsList.Count - 1; j++)
                    {
                        for (int i = 0; i < goodsList.Count - 1 - j; i++)
                        {

                            if (goodsList[i]["stock"] < goodsList[i + 1]["stock"])
                            {
                                tem4 = goodsList[i];
                                goodsList[i] = goodsList[i + 1];
                                goodsList[i + 1] = tem4;
                            }
                        }
                    }
                    foreach (dynamic item in goodsList) Console.WriteLine($"{item["name"]}--{item["stock"]}");
                }



            }
        }
    }
}
