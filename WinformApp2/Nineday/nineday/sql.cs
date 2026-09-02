using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Text;

namespace nineday
{
    internal class sql
    {
        public string Serve { get; set; }= "127.0.0.1";
        public string Port { get; set; } = "3306";
        public string Password { get; set; } = "root";
        public string Charset { get; set; } = "utf8";
        public string Uid { get; set; } = "root";
        public string Connstr { get; set; }
        public string Datebase { get; set; }
        public  sql(string database)
        {
            this.Datebase = database;
        }
        public  void connectoprate(string oparate,Action<MySqlCommand>cmd)
        {
            //连接数据库-打开连接-创建命令对象，cmd调用
            string connstr = $"server={Serve};port={Port};database={Datebase};uid={Uid};password={Password};charset={Charset}";
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                 conn.Open();
                using (MySqlCommand Cmd = new MySqlCommand(oparate,conn )) {
                    cmd(Cmd);
                }
            }
        }
    }
    
}
