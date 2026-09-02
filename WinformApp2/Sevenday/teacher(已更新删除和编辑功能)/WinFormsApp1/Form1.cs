namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public List<string> users = ["张三", "李四", "王五", "赵六", "孙七", "周八", "吴九", "小明", "小红", "小兰", "小刚", "丧彪"];
        public Form1()
        {
            InitializeComponent();

            // 左边users渲染
            users.ForEach(text =>
            {
                Label lab = new Label()
                {
                    Text = text,
                    BackColor = Color.White,
                    AutoSize = false,
                    Size = new Size(flowLayoutPanel1.Width, 20),
                    Margin = new Padding(0, 5, 0, 5),
                    TextAlign = ContentAlignment.MiddleCenter,
                };
                lab.Click += Lab_Click;
                flowLayoutPanel1.Controls.Add(lab);

            });


            // 需要给接受数据方法 添加消息
            MiddleWare mw = MiddleWare.GetInstance();
            mw.AddMsg(101, getData);
        }

        private string data = "";
        private void Lab_Click(object? sender, EventArgs e)
        {
            data = (sender as Label).Text;
            // 点击的高亮
            foreach (Label lab in flowLayoutPanel1.Controls) lab.BackColor = Color.White;

            (sender as Label).BackColor = Color.Yellow;
        }
        /****************************发送数据*********************************/
        private void button1_Click(object sender, EventArgs e)
        {
            MiddleWare mw = MiddleWare.GetInstance();
            mw.CallMsg(101, data);
        }

        /****************************发送数据*********************************/



        /**************************接收数据容器*******************************/
        // 存储数据的容器
        public List<string> getUsers = new List<string>();
        // 方法接受数据
        private void getData(object data)
        {
            // 接收到数据
            getUsers.Add(data.ToString());
            flowLayoutPanel2.Controls.Clear();
            // 左边users渲染
            getUsers.ForEach(text =>
            {
                Label lab = new Label()
                {
                    Text = text,
                    BackColor = Color.White,
                    AutoSize = false,
                    Size = new Size(flowLayoutPanel1.Width, 20),
                    Margin = new Padding(0, 5, 0, 5),
                    TextAlign = ContentAlignment.MiddleCenter,
                };               
                flowLayoutPanel2.Controls.Add(lab);
            });
        }      
        /**************************接收数据容器*******************************/
    }
}
