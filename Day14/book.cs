using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Day14
{
    internal class book
    {
        public string Path { get; }//文件路径
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
            List<Dictionary<string, dynamic>> booklist = new();
            List<Dictionary<string, dynamic>> booklist1 = new();
            var dic1 = File.ReadAllText(Path);
            booklist = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(dic1);
            if (dic1 == null) Console.WriteLine("该系统是空的，无书");
            bool b = booklist.Exists(item =>
            {
                return item["name"].ToString() == bookeedit["name"];
            });
            if (!b) return"无此书";
            foreach (dynamic i in booklist)
            {
                if (i["name"].ToString() == bookeedit["name"])
                {
                    i["name"] = bookeedit["name"];
                    i["author"] = bookeedit["author"];
                    i["mark"] = bookeedit["mark"];
                    i["price"] = bookeedit["price"];
                }
                booklist1.Add(i);
            }
            string json = JsonSerializer.Serialize(booklist1, jsonopt);
            File.WriteAllText(Path, json);
            return "ok";
        }
        public string Deletebook(string a)
        {
            List<Dictionary<string, dynamic>> booklist = new();
            var dic1 = File.ReadAllText(Path);
            if(dic1==null) Console.WriteLine("该系统是空的，无书");
            booklist = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(dic1);
           bool b= booklist.Exists(item =>
            {
                return item["name"].ToString() == a;
            });
            if(!b) Console.WriteLine("无此书");
            booklist.RemoveAll(item =>
            {
                return item["name"].ToString() == a;
            });
            string json = JsonSerializer.Serialize(booklist, jsonopt);
            File.WriteAllText(Path, json);
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
        public book(string bookpath, JsonSerializerOptions opts)

        {
            Path = bookpath;
            jsonopt = opts;
        }
    }
}
