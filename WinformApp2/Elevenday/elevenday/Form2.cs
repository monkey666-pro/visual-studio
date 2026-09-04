using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace elevenday
{
    public partial class Form2 : Form
    {
        private Class1 book = new Class1(1,"数据集");
        private List<Class1> books { get; set; } = new();
        public Form2()
        {
            InitializeComponent();
            books.AddRange(
                new Class1(1,"三过"),
            new Class1 (2,"水壶") );
            dataGridView1.DataSource = books;
        }
    }
}
