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

namespace WinFormsApp1.Controls
{
    public partial class UCBook : UserControl
    {
        internal BookInfo a1;
        public UCBook()
        {
            InitializeComponent();
        }
        public UCBook(string text) // 添加书籍
        {
            InitializeComponent();
            button1.Text = text;
            label1.Text = "图书" + text;
        }
        internal UCBook(string text, BookInfo a) // 编辑书籍
        {
            InitializeComponent();
            button1.Text = text;
            label1.Text = "图书" + text;

            nameInp.Text = a.Name;
            priceInpNum.Text = a.Price.ToString();
            authorInp.Text = a.Author;
            input3.Text = a.BookLabel;
            a1 = a;

        }

        internal event Action<BookInfo> SendData;


        private void button1_Click(object sender, EventArgs e)
        {
            if (a1 != null)
            {
                a1.Name = nameInp.Text;
                a1.Author = authorInp.Text;
                a1.Price = double.Parse(priceInpNum.Text);
                a1.BookLabel = input3.Text;
                a1.IsBorrow = false;
                string json = File.ReadAllText(@"./book.json");
                List<BookInfo> res = JsonSerializer.Deserialize<List<BookInfo>>(json);
                if (res.Exists(i => i.Id == a1.Id))
                {
                    res.RemoveAll(i => i.Id == a1.Id);
                    res.Add(a1);
                }
                string JsonStr = JsonSerializer.Serialize(res, new JsonSerializerOptions()
                {
                    WriteIndented = true,
                    AllowTrailingCommas = true,
                    Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
                });

                File.WriteAllText("./book.json", JsonStr);

                MessageBox.Show("图书编辑成功!!");


            }
            else
            {
                SendData.Invoke(new BookInfo()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = nameInp.Text,
                    Author = authorInp.Text,
                    Price = double.Parse(priceInpNum.Text),
                    BookLabel = input3.Text,
                    IsBorrow = false
                });
            }


        }
    }
}
