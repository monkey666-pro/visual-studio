using System.ComponentModel;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 鼠标滚轮 滚动事件
            panel1.MouseWheel += panel1_MouseWheel;
        }



        // 鼠标事件：MouseEventArgs  事件参数对象
        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            // 鼠标事件参数对象

            // 坐标相关
            //MessageBox.Show(e.X.ToString());
            //MessageBox.Show(e.Y.ToString());
            //MessageBox.Show(e.Location.ToString());

            // 按键相关
            //MessageBox.Show(e.Button.ToString());

            // 点击次数
            //MessageBox.Show(e.Clicks.ToString());
            //label1.Text = e.Clicks.ToString();


        }

        private void panel1_MouseWheel(object sender, MouseEventArgs e)
        {
            //滚轮
            label1.Text = e.Delta.ToString();
        }

        // 键盘事件参数对象
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            // 按键 内容
            //label8.Text = "内容: "+ e.KeyCode.ToString();
            //label8.Text = "内容: " + (e.KeyCode == Keys.Enter).ToString();

            // 功能按键判断
            //label8.Text = "内容: " + e.Control.ToString();
            //label8.Text = "内容: " + e.Shift.ToString();
            //label8.Text = "内容: " + e.Alt.ToString();

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            label8.Text = "内容: " + e.KeyChar;
            if (e.KeyChar.ToString() == "a")
            {
                // 置 true 拦截本次输入，字符不会进到文本框
                e.Handled = true;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            //e.Cancel = true;
            //label8.Text = "内容: " + e.CloseReason.ToString();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            //e.Cancel = true;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            // 控件.Focus()
            (sender as TextBox).Focus();
        }
    }
}
