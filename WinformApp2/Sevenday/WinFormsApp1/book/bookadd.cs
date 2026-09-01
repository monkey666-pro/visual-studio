using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using WinFormsApp1.control;

namespace WinFormsApp1.book
{
    public partial class bookadd : Form
    {
        public string Path = "./book.json";
        public bookadd()
        {
            InitializeComponent();
            userControl11.data += aa;
        }
        
        public void aa(Class2 a)

        {
            List<Class2> res = new();
            if (File.Exists(Path))
            {
                string json = File.ReadAllText(Path);
                res = JsonSerializer.Deserialize<List<Class2>>(json);
            }
            res.Add(a);
            var resjson = JsonSerializer.Serialize(res, new JsonSerializerOptions()
            {
                WriteIndented = true,
                AllowTrailingCommas = true,
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            });
            File.WriteAllText(Path, resjson);
            MessageBox.Show("新增成功");
        }
    }
}
