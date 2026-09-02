using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsApp1.Book
{

    public partial class BookShow : Form
    {
        private Mysql MySql { get; set; } = new Mysql("text");
        public BookShow()
        {
            InitializeComponent();
            ShowData();// 调用图书展示方法            
            table1.CellClick += Table1_CellClick; // 给表格单元绑定点击事件
        }

        private void Table1_CellClick(object sender, AntdUI.TableClickEventArgs e)
        {
            #region
            //TableClickEventArgs e
            //e.ColumnIndex 列下标
            //e.RowIndex 行下标
            //e.Column 列对象    key==> 列表名称           
            //e.Record 这一行数据
            //MessageBox.Show(e.ColumnIndex.ToString());
            //MessageBox.Show(e.RowIndex.ToString());
            //MessageBox.Show(e.Column.Key.ToString());
            //e.Record
            //System.Data.DataRow Book = e.Record as System.Data.DataRow;
            //MessageBox.Show(Book["name"].ToString());
            //MessageBox.Show(Book[1].ToString());
            #endregion

            // 获取点击这一行的数据
            System.Data.DataRow Book = e.Record as System.Data.DataRow;
            if (e.ColumnIndex == 6)
            {
                DialogResult res = MessageBox.Show("编辑还是删除?\n是=编辑\n否=删除", "编辑删除", MessageBoxButtons.YesNoCancel);
                if (res == DialogResult.Yes)
                {
                    // 编辑===> 展示编辑窗体
                    BookAddAndEdit BE = new BookAddAndEdit("编辑", Book["id"].ToString());
                    BE.Show();
                    this.Hide();
                    BE.FormClosing += (object sender, FormClosingEventArgs e) =>
                    {
                        this.Show();
                        ShowData();
                    };
                }
                else if (res == DialogResult.No)
                {
                    // 删除
                    Del(Book["id"].ToString());
                }
            }
            if (e.ColumnIndex == 7)
            {
                string id = Book["id"].ToString();
                DialogResult res = MessageBox.Show("借书还是还书?\n是=还书\n否=借书", "借书还书", MessageBoxButtons.YesNoCancel);
                if (res == DialogResult.Yes)
                {
                    //修改数据库的数据然后更新表就行了
                    string operate1 = "select * from book where is_borrow=1 and id=@id";
                        string operate = "update  book set is_borrow=1 where id=@id";
                    MySql.ConAndHandler(operate1, cmd =>
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        MySqlDataReader read = cmd.ExecuteReader();
                        if (read.HasRows)
                        {
                            MessageBox.Show("书已还！！");
                            return;
                        }
                        else {
                            MySql.ConAndHandler(operate, cmd =>
                            {
                                cmd.Parameters.AddWithValue("@id", id);
                                int row = cmd.ExecuteNonQuery();
                                if (row > 0)
                                {
                                    MessageBox.Show("还书成功");
                                    ShowData();
                                }
                            });

                        }
                    });
                   

                }
                else if (res == DialogResult.No)
                {
                        string operate = "update  book set is_borrow=2 where id=@id";
                    string operate1 = "select * from book where is_borrow=2 and id=@id";
                    MySql.ConAndHandler(operate1, cmd =>
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        MySqlDataReader read = cmd.ExecuteReader();
                        if (read.HasRows)
                        {
                            MessageBox.Show("书已借！！");
                            return;
                        }
                        else
                        {
                            MySql.ConAndHandler(operate, cmd =>
                            {
                                cmd.Parameters.AddWithValue("@id", id);
                                int row = cmd.ExecuteNonQuery();
                                if (row > 0)
                                {
                                    MessageBox.Show("借书成功");
                                    ShowData();
                                }
                                else MessageBox.Show("该书已借了");
                            });
                        }
                    });
                }
            }
        }
        private void Del(string id)
        {
            string sql = "delete from book where id=@id";
            MySql.ConAndHandler(sql, Cmd =>
            {
                Cmd.Parameters.AddWithValue("@id", id);
                int row = Cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    MessageBox.Show("删除成功!!");
                    ShowData();
                }
                else
                {
                    MessageBox.Show("删除失败!!!");
                }
            });
        }

        // 图书展示方法
        private void ShowData()
        {
            MySql.ConAndHandler("select * from book", Cmd =>
            {
                MySqlDataAdapter Ada = new MySqlDataAdapter(Cmd);// 创建适配器
                DataTable dt = new DataTable();// 创建内存表
                Ada.Fill(dt);
                table1.DataSource = dt;
                SetColumn();
            });
        }

        // 设置表头
        private void SetColumn()
        {
            table1.Columns.Clear();// 先清除
            table1.Bordered = true;
            table1.Radius = 4;
            table1.Columns = new AntdUI.ColumnCollection()
            {
                new AntdUI.Column("id","编号"){
                    Render=(object val,object cel,int rowIndex )=> rowIndex+1
                },
                new AntdUI.Column("name","书名"),
                new AntdUI.Column("author","作者"),
                new AntdUI.Column("price","价格"),
                new AntdUI.Column("label","标签"),
                new AntdUI.Column("is_borrow","借阅"){
                    Render=(object val,object cel,int index )=> val.ToString()=="1"?"已借阅":"在书架"
                },
            };
            var HandlerCol = new AntdUI.Column("handler", "操作");
            HandlerCol.Render = (object val, object cel, int index) => "删除 | 编辑";
            table1.Columns.Add(HandlerCol);
            var HandlerCo2 = new AntdUI.Column("handler", "借还书");
            HandlerCo2.Render = (object val, object cel, int index) => "借书 | 还书";
            table1.Columns.Add(HandlerCo2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 显示新增界面
            BookAddAndEdit BA = new BookAddAndEdit("新增");
            BA.Show();
            this.Hide();
            BA.FormClosing += BA_FormClosing;
        }

        private void BA_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
            ShowData();
        }
    }
}
