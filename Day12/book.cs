using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day13
{
    internal class book
    {
        public string Path { get; }//文件路径
        public JsonSerializerOptions jsonopt { get;  }//json序列化
        
        public string Addbook(Dictionary<string,dynamic>bookdic)
        {
            List< Dictionary<string, dynamic>> booklist = new();
            if (File.Exists(Path))//先判断路径是否存在=》不存在就直接组装书籍list再进行序列化，写入文件
            {
                var dic1 = File.ReadAllText(Path);
                booklist = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(dic1);
                bool b= booklist.Exists(item =>
                {
                    return item["name"].ToString() == bookdic["name"];
                });
                if(b)return "重复";
            }
            else
            { 
                booklist.Add(bookdic);
                string json = JsonSerializer.Serialize(booklist, jsonopt);
                File.WriteAllText(Path, json);
            }
            //如果存在先进行反序列化判断是否重名如果重名就不加，反之
            return "ok";
        }
        public string Editbook(Dictionary<string, dynamic> bookeedit)
        {

            return "ok";
        }
        public string Deletebook(Dictionary<string, dynamic> bookdel)
        {

            return "ok";
        }
        public string searchtbook(string name4)
        {
            var dic = File.ReadAllText(Path);
            List<Dictionary<string, dynamic>> booklist = new();
            booklist = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(dic);
            bool aa=booklist.Exists(item => item["name"].ToString() == name4);
            if(!aa) return"无此书";
            foreach (dynamic i in booklist)

            {
                foreach(dynamic q in i) Console.WriteLine(q);
            }
            ;
                //var res=booklist.FindAll(item => item["name"] == name4);
                //foreach (dynamic i in res)
                //{

                //}
                return "ok";
        }
        public string searchtbook1(string bookName,string author)
        {
            var dic = File.ReadAllText(Path);
            List<Dictionary<string, dynamic>> booklist = new();
            booklist = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(dic);
            bool aa = booklist.Exists(item => item["name"].ToString() == bookName&& item["author"].ToString()==author);
            if (aa)
            {
                foreach (dynamic i in booklist)

                {
                    foreach (dynamic q in i) Console.WriteLine(q);
                }
            }
            else return"无此书";
                return "";
        }
        public book(string bookpath, JsonSerializerOptions opts)
            
        {
            Path = bookpath;
            jsonopt=  opts;
        }
       
        
            
        
    }
}
