using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Day14
{
    internal class book
    {
        public string Path { get; }//文件路径
        public string Path1 { get; }//借书路径
        public JsonSerializerOptions jsonopt { get; }//json序列化

        public string Addbook(Dictionary<string, dynamic> bookdic)
        {
            List<Dictionary<string, dynamic>> booklist = new();
            if (File.Exists(Path))//先判断路径是否存在=》不存在就直接组装书籍list再进行序列化，写入文件
            {
                var dic1 = File.ReadAllText(Path);
                booklist = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(dic1);
                bool b = booklist.Exists(item =>
                {
                    return item["name"].ToString() == bookdic["name"];
                });
                if (b) return "重复";
            }
            
                booklist.Add(bookdic);
                string json = JsonSerializer.Serialize(booklist, jsonopt);
                File.WriteAllText(Path, json);
           
            //如果存在先进行反序列化判断是否重名如果重名就不加，反之
            return "ok";
        }
        public string Editbook(Dictionary<string, dynamic> bookeedit)
        {
            //List<Dictionary<string, dynamic>> booklist = new();
            //List<Dictionary<string, dynamic>> booklist1 = new();
            //var dic1 = File.ReadAllText(Path);
            //booklist = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(dic1);
            //if (dic1 == null) Console.WriteLine("该系统是空的，无书");
            //bool b = booklist.Exists(item =>
            //{
            //    return item["name"].ToString() == bookeedit["name"];
            //});
            //if (!b) return"无此书";
            //foreach (dynamic i in booklist)
            //{
            //    if (i["name"].ToString() == bookeedit["name"])
            //    {
            //        i["name"] = bookeedit["name"];
            //        i["author"] = bookeedit["author"];
            //        i["mark"] = bookeedit["mark"];
            //        i["price"] = bookeedit["price"];
            //    }
            //    booklist1.Add(i);
            //}
            //string json = JsonSerializer.Serialize(booklist1, jsonopt);
            //File.WriteAllText(Path, json);
            if(!File.Exists(this.Path)) Console.WriteLine("库无书籍请先添加");
            var json = File.ReadAllText(this.Path);
            List<Dictionary<string, dynamic>> list = new();
            list = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(json);
            Dictionary<string, dynamic> newlist = list.Find(item => item["name"].ToString() == bookeedit["name"]);
            if(newlist==null) return"找不到要改动的书籍";
            foreach (var i in bookeedit)
            {
                newlist[i.Key] = bookeedit[i.Key];
            }
            var json1 = JsonSerializer.Serialize(list, jsonopt);
            File.WriteAllText(this.Path, json1);


            return "ok";
        }
        public string Deletebook(string bookname)
        {
            // List<Dictionary<string, dynamic>> booklist = new();
            // var dic1 = File.ReadAllText(Path);
            // if(dic1==null) Console.WriteLine("该系统是空的，无书");
            // booklist = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(dic1);
            //bool b= booklist.Exists(item =>
            // {
            //     return item["name"].ToString() == a;
            // });
            // if(!b) Console.WriteLine("无此书");
            // booklist.RemoveAll(item =>
            // {
            //     return item["name"].ToString() == a;
            // });
            // string json = JsonSerializer.Serialize(booklist, jsonopt);
            // File.WriteAllText(Path, json);
            if (!File.Exists(Path)) return "无书籍，请先添加";
            var json =File.ReadAllText(Path);
            List<Dictionary<string, dynamic>> list = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(json);
            int index = list.FindIndex(item => item["name"].ToString() == bookname);
            if(index==-1) Console.WriteLine("要删除的书不存在，请先添加");
            list.RemoveAt(index);
            var json1= JsonSerializer.Serialize(list, jsonopt);
            File.WriteAllText(Path, json1);
            return "ok";
        }
        public List<Dictionary<string, dynamic>> searchtbook()
        {
            List<Dictionary<string, dynamic>> list = new();
            if (!File.Exists(Path)) return list;
            var json = File.ReadAllText(Path);
            list = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(json);
            return list;
        }
        public Dictionary<string, dynamic> searchtbook1(string bookName)
        {
            Dictionary<string, dynamic> bookdic = new();
            if (!File.Exists(Path)) return bookdic;
            var json = File.ReadAllText(Path);
            List<Dictionary<string, dynamic>> list = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(json);
            Dictionary<string, dynamic> rebookdic = list.Find(item =>item["name"].ToString() == bookName );
            if(rebookdic==null)return bookdic;
            return rebookdic;
        }
        public book(string bookpath, string bookpath1,JsonSerializerOptions opts)

        {
            Path = bookpath;
            Path1 = bookpath1;
            jsonopt = opts;
        }
        public List<Dictionary<string, dynamic>> Borrowcount()
        {
            if (!File.Exists(Path1)) ; 
            var json = File.ReadAllText(Path);
            List<Dictionary<string, dynamic>> list = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(json);
             list.RemoveAll(item =>item["isBorrow"].GetBoolean() == false);
            List<Dictionary<string, dynamic>> list1 = list;
            var json1 = JsonSerializer.Serialize(list1, jsonopt);
            File.WriteAllText(Path1, json1);
            return list;
        }
        public string Borrow(string borrowname)
        {
            var json = File.ReadAllText(Path);
            List<Dictionary<string, dynamic>> list = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(json);
            bool o=list.Exists(item =>
            {
                return  item["isBorrow"].GetBoolean() == true;
            });
            if(o) return("该书已经借了");
            foreach (dynamic i in list)
            {
                if (i["name"].ToString() == borrowname) i["isBorrow"] = true;
            }
            var json1 = JsonSerializer.Serialize(list, jsonopt);
            File.WriteAllText(Path, json1);
            return "ok";
        }
        public string returnbook(string borrowname)
        {
            var json = File.ReadAllText(Path);
            var json1= File.ReadAllText(Path1);
            List<Dictionary<string, dynamic>> list = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(json);
            List<Dictionary<string, dynamic>> list1 = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(json);
            bool o = list1.Exists(item =>
            {
                return item["isBorrow"].GetBoolean() == false;
            });
            if (!o) return ("该书没借");
            foreach (dynamic i in list)
            {
                if (i["name"].ToString() == borrowname) i["isBorrow"] = false;
            }
            var json0 = JsonSerializer.Serialize(list, jsonopt);
            File.WriteAllText(Path, json0);
            list1.RemoveAll(item => item["isBorrow"].GetBoolean() == true);
            var json00 = JsonSerializer.Serialize(list1, jsonopt);
            File.WriteAllText(Path1, json00);
            return "ok";
        }
    }
}
