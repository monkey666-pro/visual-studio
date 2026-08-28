namespace Twoday
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void initEvent()
        {
            textBox2.GotFocus += TextBox2_GotFocus;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("点击了", "标题");
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            MessageBox.Show("鼠标点击");
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            // MessageBox.Show("鼠标进入");
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            // MessageBox.Show("鼠标松开");
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            //MessageBox.Show("鼠标移出");
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show("键盘按下了");
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            // MessageBox.Show("键盘松开了");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show("键盘输入了内容");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("改变内容");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        public void TextBox2_GotFocus(object sender, EventArgs e)
        {
            label1.Text = "获取焦点";
        }
    }
}
