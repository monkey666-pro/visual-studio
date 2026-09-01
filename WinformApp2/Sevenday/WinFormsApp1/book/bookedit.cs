using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace WinFormsApp1.book
{
    public partial class bookedit : Form
    {
        public bookedit()
        {
            InitializeComponent();
            show();
        }
        public void show()
        {
            //取出文件再进行展示
            string json = File.ReadAllText("./book.json");
            List<Class2> res = JsonSerializer.Deserialize<List<Class2>>(json);
            table1.DataSource = res;
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
                }
            };
            table1.Columns.Add(new AntdUI.Column("Handler", "操作")
            {
                Render = (object val, object cel, int index) => "删除"
            });
            table1.Columns.Add(new AntdUI.Column("Handler2", "操作")
            {
                Render = (object val, object cel, int index) => "编辑"
            });

            // 绑定事件
            table1.CellClick += button;

        }
        public void button(object sender, EventArgs e)
        {
            
        }
    }
}
