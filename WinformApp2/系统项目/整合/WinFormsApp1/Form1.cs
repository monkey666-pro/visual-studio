using WinFormsApp1.Book;
using WinFormsApp1.car;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            用户中心ToolStripMenuItem.Text = "未登录";
            登录ToolStripMenuItem.Click += 登录ToolStripMenuItem_Click;
            注册ToolStripMenuItem.Click += 注册ToolStripMenuItem_Click;
            注销ToolStripMenuItem.Click += 注销ToolStripMenuItem_Click;
            AntdUI.Config.ShowInWindow = true;
        }

        private void 注销ToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            用户中心ToolStripMenuItem.Text = "未登录";
        }

        private void 注册ToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            signup sg = new signup();
            sg.Show();
            this.Hide();
            sg.FormClosing += Sg_FormClosing;

        }

        private void Sg_FormClosing(object? sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void 登录ToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            lg.LoginMark += Lg_LoginMark;
            this.Hide();
            lg.FormClosing += (object sender, FormClosingEventArgs e) => this.Show();
        }

        private string Mark { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            if (用户中心ToolStripMenuItem.Text == "已登录")
            {

                // 跳转到图书展示界面
                BookShow BS = new Book.BookShow();
                BS.Show(); // 展示目标窗体
                this.Hide(); // 当前窗体隐藏
                BS.FormClosing += BS_FormClosing; // 目标窗体关闭前事件
            }
            else
            {
                AntdUI.Message.warn(this, "请先登录或注册", autoClose: 2);
            }

        }
        private void Lg_LoginMark(string mark)
        {
            this.Mark = mark;
            用户中心ToolStripMenuItem.Text = mark;
            if (用户中心ToolStripMenuItem.Text == "已登录") 登录ToolStripMenuItem.Visible = false;
        }


        private void BS_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            carshow show= new carshow();
            show.Show();
        }
    }
}
