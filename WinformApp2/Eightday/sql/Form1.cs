using MySqlConnector;

namespace sql
{
    //先下载第三方库
    public partial class Form1 : Form
    {//定义数据库链接的字符串
        private string sql = "server=127.0.1;port:3306;database=text;uid=root;password=root;charset=";
        public Form1()
        {
            InitializeComponent();
            //创建连接
            using (MySqlConnection c = new MySqlConnection(sql))
            {
                c.Open();
                string 
            }
        }
    }
}
