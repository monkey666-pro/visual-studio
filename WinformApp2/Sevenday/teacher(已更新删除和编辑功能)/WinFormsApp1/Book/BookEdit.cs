using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Controls;

namespace WinFormsApp1.Book
{
    public partial class BookEdit : Form
    {
        public BookEdit()
        {
            InitializeComponent();
            ucBook1.SendData += data;

        }
        public BookEdit(string id="")
        {
            
            string idd = id;
            //根据id查找数据

            string json = File.ReadAllText(@"./book.json");
            List<BookInfo> res = JsonSerializer.Deserialize<List<BookInfo>>(json);
            BookInfo restr = res.Find(i => i.Id == id);
            InitializeComponent();
            //new UCBook(restr).Show();
            //MessageBox.Show(id);
            //回显 ====> 根据id 查找到 对应的书籍数据 ==> 显示在界面中(界面使用UCBook)
            //  编辑按钮, 修改
            


            // 在用户空间里面进行修改=》书的id=》传书的id
            //接收到新输入的数据，=》有原始书的id=》可以在里面找到这本书
        }
        private void data(BookInfo book)
        {
            if (File.Exists(@"./book.json"))
            {
                string json = File.ReadAllText(@"./book.json");
                List<BookInfo> res = JsonSerializer.Deserialize<List<BookInfo>>(json);
                BookInfo newbook = res.Find(i => i.Id == book.Id);
                newbook = book;
                string JsonStr = JsonSerializer.Serialize(res, new JsonSerializerOptions()
                {
                    WriteIndented = true,
                    AllowTrailingCommas = true,
                    Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
                });

                File.WriteAllText("./book.json", JsonStr);

                MessageBox.Show("图书编辑成功!!");
                this.Close();
            }
        }
    }
}
