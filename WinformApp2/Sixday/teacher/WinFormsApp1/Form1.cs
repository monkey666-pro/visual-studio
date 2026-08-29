namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // 窗体事件

            this.Load += Form1_Load; // 窗体在加载显示之前触发
            this.Shown += Form1_Shown; // 窗体显示完毕触发

            this.FormClosing += Form1_FormClosing; // 窗体关闭前触发, 可以在处理函数中区取消船体关闭
            this.FormClosed += Form1_FormClosed; // 窗体关闭完成

            this.Resize += Form1_Resize; // 只要窗体的尺寸变化就触发
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            widthLab.Text = this.Width.ToString();
            heightLab.Text = this.Height.ToString();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("窗体已经关闭了!!!");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //MessageBox.Show("窗体要关闭了!!!");

            ////条件取消
            //DialogResult res = MessageBox.Show("你真的要求离开吗?", "等等等", MessageBoxButtons.OKCancel);
            ////MessageBox.Show(res.ToString());
            //if (res == DialogResult.OK)
            //{
            //    MessageBox.Show("你好狠心啊!!!");
            //}
            //else
            //{

            //    e.Cancel = true;
            //}
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //MessageBox.Show("你看到窗体啦!!!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("你还看不到窗体!!!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog(); // 显示窗体, 会阻塞程序的执行, 展示的这个窗体没有关闭,不能操作其他窗体
        }
    }
}
