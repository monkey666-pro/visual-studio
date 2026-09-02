using AntdUI;
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

namespace WinFormsApp1.Book
{
    public partial class BookShow : Form
    {
        public BookShow()
        {
            InitializeComponent();
            showBook();
        }
        private void showBook()
        {
            string JsonStr = File.ReadAllText("./book.json");
            List<BookInfo> books = JsonSerializer.Deserialize<List<BookInfo>>(JsonStr);
            table1.DataSource = books;

            // 重置表头
            table1.Columns.Clear();
            table1.Columns = new AntdUI.ColumnCollection {
                new AntdUI.Column("Id", "编号")
                {
                    Render = (object val,object cel,int index ) =>index.ToString()

                },
                new AntdUI.Column("Name", "书名"),
                new AntdUI.Column("Author", "作者"),
                new AntdUI.Column("Price", "价格"),
                new AntdUI.Column("BookLabel", "标签"),
                new AntdUI.Column("IsBorrow", "是否借阅"){
                    // val 单元的值, cel: 行数据, index 行号
                    Render = (object val,object cel,int index) =>
                    {
                        return (bool)val?"已借阅":"书架中";
                    }
                },
            };

            table1.Columns.Add(new AntdUI.Column("Handler", "操作")
            {
                Render = (object val, object cel, int index) => "删除"
            });
            table1.Columns.Add(new AntdUI.Column("Handler2", "操作")
            {
                Render = (object val, object cel, int index) => "编辑"
            });
            table1.Columns.Add(new AntdUI.Column("Handler", "操作")
            {
                Render = (object val, object cel, int index) => "借书"
            });
            table1.Columns.Add(new AntdUI.Column("Handler2", "操作")
            {
                Render = (object val, object cel, int index) => "还书"
            });

            // 绑定事件
            table1.CellClick += Table1_CellClick;

        }
        public string id = "";
        private void Table1_CellClick(object sender, TableClickEventArgs e)
        {
            BookInfo book = (e.Record as BookInfo);            
            //MessageBox.Show(e.ColumnIndex.ToString());
            if(e.ColumnIndex.ToString() == "6")
            {

                // 删除
                //读取文件，反序列化，删除列表名字对应的list数据
                if (File.Exists(@"./book.json"))
                {
                    string json = File.ReadAllText(@"./book.json");
                    List<BookInfo> res = JsonSerializer.Deserialize<List<BookInfo>>(json);
                    if (MessageBox.Show("确定删除？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        res.RemoveAt(e.RowIndex - 1);  // 删除点击的那一行
                    }
                    else return;
                    //传回文件
                    string jsons= JsonSerializer.Serialize(res, new JsonSerializerOptions()
                    {
                        WriteIndented = true,
                        AllowTrailingCommas = true,
                        Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
                    });
                    File.WriteAllText(@"./book.json", jsons);
                    MessageBox.Show("删除成功");
                    table1.DataSource = res;
                    
                }

                return;
            }
            if (e.ColumnIndex.ToString() == "7")
            {
                // 编辑
                new BookEdit(book.Id).Show();
            }               
        }


        private void goEdit(string id)
        {

            new BookEdit(id).Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new BookEdit().Show();
        }
    }
}
