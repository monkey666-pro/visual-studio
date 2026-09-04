namespace elevenday
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button2.Click += button2_Click;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "打开文件";
                ofd.Filter = "图片|*.png|图像|*.jpg";
                var res = ofd.ShowDialog();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "保存文件";
                sfd.Filter = "文档|*.txt;*.md";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show(sfd.FileName);
                }
            }
        }
    }
}
