using MySqlConnector;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        // 定义数据库连接字符串
        private string ConnStr = "server=127.0.0.1;port=3306;database=test;uid=root;password=root;charset=utf8";
        public Form1()
        {
            InitializeComponent();

            // 创建数据库连接 
            using (MySqlConnection Conn = new MySqlConnection(ConnStr))
            {
                Conn.Open();// 打开连接

                // 写sql语句
                string Sql = "select * from user";

                // 创建命令对象 (sql语句)
                using (MySqlCommand Comm = new MySqlCommand(Sql, Conn))
                {
                    // 创建适配器 ===> 查询的数据库数据 和 内存数据集关联
                    MySqlDataAdapter Ada = new MySqlDataAdapter(Comm);
                    // 创建内存表
                    DataTable dt = new DataTable();

                    Ada.Fill(dt); // 数据填充

                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;

            // 创建数据库连接 
            using (MySqlConnection Conn = new MySqlConnection(ConnStr))
            {
                Conn.Open();// 打开连接

                // 写sql语句
                //string Sql = "select * from user where username = @username";
                //string Sql = $"select * from user where username like '%{str}%'";
                string Sql = "select * from user where username like  CONCAT('%',@username,'%')";

                // 创建命令对象 (sql语句)
                using (MySqlCommand Comm = new MySqlCommand(Sql, Conn))
                {
                    // Comm 的参数填充
                    Comm.Parameters.AddWithValue("@username", str);


                    // 创建适配器 ===> 查询的数据库数据 和 内存数据集关联
                    MySqlDataAdapter Ada = new MySqlDataAdapter(Comm);
                    // 创建内存表
                    DataTable dt = new DataTable();

                    Ada.Fill(dt); // 数据填充

                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (MySqlConnection Conn = new MySqlConnection(ConnStr))
            {
                Conn.Open();// 打开连接

                // 写sql语句

                //string Sql = "delete from user where username = @username";
                //string Sql = "update user set gender=@gender,age=@age where id = @id";
                //string Sql = "insert into user(username,age,gender,banji,password) value(@username,@age,@gender,@banji,@password)";

                string Sql = "update user set gender='男',age=age+1 where id = 1";
                // 创建命令对象 (sql语句)
                using (MySqlCommand Comm = new MySqlCommand(Sql, Conn))
                {
                    // Comm 的参数填充
                    //Comm.Parameters.AddWithValue("@username", "张三2");

                    //Comm.Parameters.AddWithValue("@id", 2);
                    //Comm.Parameters.AddWithValue("@gender", "女");
                    //Comm.Parameters.AddWithValue("@age", 18);

                    //Comm.Parameters.AddWithValue("@username", "小红");
                    //Comm.Parameters.AddWithValue("@age", 18);
                    //Comm.Parameters.AddWithValue("@gender", "女");
                    //Comm.Parameters.AddWithValue("@banji", "02班");
                    //Comm.Parameters.AddWithValue("@password", "123456");



                    // 命令对象.ExecuteNonQuery()  执行非查询语句
                    int row = Comm.ExecuteNonQuery();
                    if (row > 0)
                    {
                        MessageBox.Show("成功");
                    }
                    else
                    {
                        MessageBox.Show("失败");
                    }



                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (MySqlConnection Conn = new MySqlConnection(ConnStr))
            {
                Conn.Open();// 打开连接

                // 写sql语句
                //string Sql = "select count(*) from user";
                //string Sql = "select * from user";
                //string Sql = "select * from user where id=1000";
                string Sql = "select * from user where id=1";
                // 创建命令对象 (sql语句)
                using (MySqlCommand Comm = new MySqlCommand(Sql, Conn))
                {
                    // Comm 的参数填充
                    //Comm.Parameters.AddWithValue("@username", "张三2");


                    //// ExecuteScalar: 获取聚合查询结果
                    //Object res = Comm.ExecuteScalar();
                    //label1.Text = res.ToString();

                    // 结果读取对象
                    MySqlDataReader Reader = Comm.ExecuteReader();
                    //label1.Text = Reader.FieldCount.ToString(); // 获取结果的列数
                    //label1.Text = Reader.HasRows.ToString(); // 判断是否有至少一行的结果

                    bool isRows = Reader.Read(); // 结果对象读取数据
                    // 结果对象 是否读到数据
                    //label1.Text = isRows.ToString();

                    //label1.Text = Reader.GetInt32(3).ToString();
                    //label1.Text = Reader.GetString(6);

                    //label1.Text = Reader.GetString("banji");
                    label1.Text = Reader.GetDateTime("create_at").ToString();
                }
            }
        }
    }
}
