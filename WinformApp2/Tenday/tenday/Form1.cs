using Microsoft.Win32;

namespace tenday
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer mytime { get; set; }
        public Form1()
        {
            int i = 0;
            InitializeComponent();
            mytime = new System.Windows.Forms.Timer();
            mytime.Interval = 1000;
            show();
            mytime.Tick += (object sender, EventArgs e) =>
            {
                show();
            };
            mytime.Start();
        }
        public void show()
        {
            //先获取国庆时间和当前时间
            //现在时间
            DateTime nowtime = DateTime.Now;
            //国庆时间
            DateTime guoqing = new DateTime(nowtime.Year, 10, 1, 0, 0, 0);
            TimeSpan newtime = guoqing - nowtime;
            //获取对应的天时分
            var day = newtime.Days.ToString();
            var shi = newtime.Hours.ToString();
            var fen = newtime.Minutes.ToString();
            string time = day.PadLeft(3,'0') + shi.PadLeft(2, '0') + fen.PadLeft(2, '0');
            //将对应的符号照片放进picture并改好格式
            pictureBox4.Image = Image.FromFile("./images/天.png");
            pictureBox4.SizeMode=PictureBoxSizeMode.StretchImage;
            pictureBox10.Image = Image.FromFile("./images/分.png");
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.Image = Image.FromFile("./images/时.png");
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox[] pic = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox5, pictureBox6, pictureBox8, pictureBox9 };
            //将数组内的图片对应好图片因为一秒执行一次，所以就对应一次就行了
            for (int i = 0; i < pic.Length; i++)
            {
                pic[i].SizeMode=PictureBoxSizeMode.StretchImage;
                pic[i].Image = Image.FromFile("./images/" + time[i]+".png");
            }
        }

    }
}
