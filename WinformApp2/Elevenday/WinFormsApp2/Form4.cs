using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form4 : Form
    {
        //private List<Book> books { get; set; } = new List<Book>();
        private BindingList<Book> books { get; set; } = new BindingList<Book>();
        public Form4()
        {
            InitializeComponent();
            // 创建数据
            books.Add(new Book(1, "三国演义", 12.2, true));
            books.Add(new Book(2, "水浒传", 22.2, false));
            books.Add(new Book(3, "西游记", 32.2, true));
            books.Add(new Book(4, "红楼梦", 42.2, false));

            // 给 DataGridView 绑定数据 通过 DataSource 
            dataGridView1.DataSource = books;

            // 禁止用户自动新增空白行
            dataGridView1.AllowUserToAddRows = false;

            //// 禁止删除
            //dataGridView1.AllowUserToDeleteRows = false;
            //// 禁止 手动拖拉 行列宽高
            //dataGridView1.AllowUserToResizeColumns = false;
            //dataGridView1.AllowUserToResizeRows = false;

            // 设置选择 整行
            //dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // 设置选择多行
            //dataGridView1.MultiSelect = false;

            // 设置只读, 不能修改单元格
            //dataGridView1.ReadOnly = true;

            // 设置表头. 第一行 是否可见
            //dataGridView1.ColumnHeadersVisible = false;
            //dataGridView1.RowHeadersVisible = false;

            // 列操作
            //dataGridView1.Columns[1].Visible = false;
            //dataGridView1.Columns["Price"].Visible = false;

            //dataGridView1.Columns["Price"].Width = 300;
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //dataGridView1.Columns.Remove("Id"); // 只是将这一列放到最后

            // 列设置
            //DataGridViewButtonColumn ColBtn = new DataGridViewButtonColumn();
            //ColBtn.Name = "opt";
            //ColBtn.HeaderText = "操作";
            //ColBtn.Text = "删除";
            //ColBtn.UseColumnTextForButtonValue = true;// 所有这一列都是这个文本
            //dataGridView1.Columns.Add(ColBtn);

            // 行操作
            //dataGridView1.Rows.Add(); // 特殊操作

            //dataGridView1.Rows.Clear();
            //dataGridView1.Rows.RemoveAt(2); // 下标

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ShowDataStr = "";
            foreach (var item in books)
            {
                ShowDataStr += $"书名：{item.Name};;书价：{item.Price}\n";
            }
            MessageBox.Show(ShowDataStr);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;

            dataGridView1.Columns.Add("Id", "编号");
            dataGridView1.Columns.Add("Name", "名字");
            dataGridView1.Columns.Add("Price", "价格");

            dataGridView1.Rows.Add();
            dataGridView1.Rows.Add(1, "三国", 12.3);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //object val = dataGridView1.Rows[0].Cells[1].Value;
            //MessageBox.Show(val.ToString());
            dataGridView1.Rows[0].Cells[1].Value = "东汉末年";
        }
    }
}
