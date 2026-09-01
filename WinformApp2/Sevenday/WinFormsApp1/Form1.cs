using Microsoft.VisualBasic.Devices;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public List<string> aa = ["vvv1", "vvv2", "vvv3", "vvv4"];
        public Form1()
        {
            InitializeComponent();
            aa.ForEach(text =>
            {
                Label a = new Label()
                {
                    Text = text,
                    BackColor = Color.White,
                    AutoSize = false,
                    Size = new Size(flowLayoutPanel1.Width, 20),
                    Margin = new Padding(0, 5, 0, 5),
                    TextAlign = ContentAlignment.MiddleCenter,
                };
                a.Click += label1_Click;
                flowLayoutPanel1.Controls.Add(a);
            });
            Class1 c = Class1.geta();
            c.add(5, getresult);//getresult：将函数传给类，这样子另外一个容器直接调用类就可以直接对数据进行处理了
        }
        public string text = "";

        private void label1_Click(object sender, EventArgs e)
        {
            text = (sender as Label).Text;
            //重置其他lable
            foreach (Label a in flowLayoutPanel1.Controls)
            {
               a. BackColor = Color.White;
            }
            (sender as Label).BackColor = Color.Red;


        }
        public List<string> list = new();
        private void button1_Click(object sender, EventArgs e)
        {
            Class1 c= Class1.geta();
            c.call(5, text);
        }
        public void getresult(object text)
        {
            //数据的处理
            list.Add(text.ToString());
            flowLayoutPanel2.Controls.Clear();
            list.ForEach(i =>
            {
                Label aa = new Label()
                {
                    Text = i,
                    BackColor = Color.White,
                    AutoSize = false,
                    Size = new Size(flowLayoutPanel1.Width, 20),
                    Margin = new Padding(0, 5, 0, 5),
                    TextAlign = ContentAlignment.MiddleCenter,
                };
                flowLayoutPanel2.Controls.Add(aa);
            });

        }
    }
}
