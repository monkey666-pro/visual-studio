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

            //// 给 DataGridView 绑定数据 通过 DataSource 

            // 禁止自动生成列
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = books;

            // 因为禁止自动生成列了需要手动添加列
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "id",// 列名称
                HeaderText = "编号",
                DataPropertyName = "Id",
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "name",// 列名称
                HeaderText = "书名",
                DataPropertyName = "Name",
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "price",// 列名称
                HeaderText = "价格",
                DataPropertyName = "Price",
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "isBorrow",// 列名称
                HeaderText = "借阅",
                DataPropertyName = "IsBorrow",
            });
            dataGridView1.Columns.Add(new DataGridViewButtonColumn()
            {
                Name = "handler",// 列名称
                HeaderText = "操作",
                Text = "删除",
                UseColumnTextForButtonValue = true,
            });



            // 禁止用户自动新增空白行
            dataGridView1.AllowUserToAddRows = false;
            //dataGridView1.RowHeadersVisible = false;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // 隔行变色
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Red;
            // 表头背景
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            // 默认会被系统颜色覆盖，需要关闭系统颜色设置
            dataGridView1.EnableHeadersVisualStyles = false;



            //事件绑定
            dataGridView1.CellClick += DataGridView1_CellClick;
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
            dataGridView1.CellEndEdit += DataGridView1_CellEndEdit;
        }

        private void DataGridView1_CellEndEdit(object? sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("编辑结束");
        }

        private void DataGridView1_SelectionChanged(object? sender, EventArgs e)
        {
            //MessageBox.Show("切换选中的行了");
        }

        private void DataGridView1_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            //e.RowIndex // 第几行
            //MessageBox.Show(e.RowIndex.ToString());
            if (e.RowIndex >= 0)
            {
                //MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString());
            }
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
            //MessageBox.Show(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            //MessageBox.Show(dataGridView1.CurrentRow.Cells["Name"].Value.ToString());
            string ShowDataStr = "";
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                ShowDataStr += $"书名：{row.Cells["Name"].Value};;书价：{row.Cells["price"].Value}\n";
            }
            MessageBox.Show(ShowDataStr);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //object val = dataGridView1.Rows[0].Cells[1].Value;
            //MessageBox.Show(val.ToString());
            dataGridView1.Rows[0].Cells[1].Value = "东汉末年";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // 创建数据
            books.Add(new Book(1, "三国演义", 12.2, true));
            books.Add(new Book(2, "水浒传", 22.2, false));
            books.Add(new Book(3, "西游记", 32.2, true));
            books.Add(new Book(4, "红楼梦", 42.2, false));
        }
   
    }
}
