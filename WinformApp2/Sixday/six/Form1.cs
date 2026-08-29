using System.Runtime.CompilerServices;

namespace six
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += a;//窗体出来之前的操作
            this.Shown += a1;//窗体出来之后的操作
            this.FormClosing += a2;//关窗体前的操作
            this.FormClosed += a3; //关窗体后的操作
            this.Resize += a4;//窗体实时的尺寸
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
        }

        private void a(object sender, EventArgs e)
        {
            MessageBox.Show("窗体前");
        }
        private void a1(object sender, EventArgs e)
        {
            MessageBox.Show("窗体后");
        }
        private void a2(object sender, EventArgs e)
        {
            //DialogResult a = MessageBox.Show("确定关闭？", "等一下", MessageBoxButtons.OKCancel);
            //if (a.)
        }
        private void a3(object sender, EventArgs e)
        {
            MessageBox.Show("窗体关闭了");
        }
        private void a4(object sender, EventArgs e)
        {
            label1.Text = "宽度："+this.Width.ToString();
            label2.Text = "高度：" + this.Height.ToString();
        }
    }
}
