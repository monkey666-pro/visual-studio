namespace WinFormsApp1
{
    public partial class Form6 : Form
    {
        private Form5 f5;
        public Form6()
        {
            InitializeComponent();
            button1.Click += Button1_Click;
            button2.Click += (object sender, EventArgs e) =>
            {
                // 隐藏窗体   窗体实例.Close()
                // 隐藏Form5窗体 
                // f5.Hide();
                // this.Hide(); // 注意: 不要隐藏当前窗体, 隐藏后无法关闭,会在电脑后台中挂起占用内存 
            };
            

            button3.Click += (object sender, EventArgs e) =>
            {
                // 关闭窗体   窗体实例.Close()

                // 关闭Form5窗体                
                f5.Close();
            };

            button4.Click += (object sender, EventArgs e) =>
            {
                // 退出应用             
                Application.Exit();
            };




        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //窗体实例对象.Show(); // 窗体显示
            // 打开Form5窗体
            f5 = new Form5();
            f5.Show();

        }
    }
}
