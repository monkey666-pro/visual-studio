using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace nineday.book
{

    public partial class add : Form
    {
        private sql mysql;
        public add()
        {
            InitializeComponent();
        }
        //
        public add(string text)
        {
            label2.Text = "员工" + text;
            button5.Text = text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string name = input1.Text;
            string department = input2.Text;
            double salary = double.Parse(inputNumber1.Text);
            string sql = "insert into Employee (name,department,salary)value(@name,@department,@salary)";//语句
            //进行数据库命令
            mysql.connectoprate(sql, cmd =>
            {
                cmd.Parameters.AddWithValue("@name", Name);
                cmd.Parameters.AddWithValue("@department", department);
                cmd.Parameters.AddWithValue("@salary", salary);
                int row =cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    MessageBox.Show("成功");
                    this.Close();
                    }
                else
                {
                    MessageBox.Show("失败");
                    this.Close();
                }
                
            });
           
        }
    }
}
