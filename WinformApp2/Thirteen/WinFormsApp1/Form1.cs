using WinFormsControlLibrary1;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int heigh = 0;//高度
        private Label lab = new();
        private Random rand = new();
        private System.Windows.Forms.Timer labtime=new System.Windows.Forms.Timer();
        private void button1_Click(object sender, EventArgs e)
        {
            //设置lable的text/Location/Size.....
            //启动定时器，方法-绑定事件，按键按下的键是否和text一致
            heigh = 0;
            setlable();
            labtime.Interval = 10;
            labtime.Tick -= Labtime_Tick;
            labtime.Tick += Labtime_Tick;
            labtime.Start();
            this.KeyPreview = true; // 让窗体得到光标
            this.ActiveControl = null;
            this.KeyUp -= Form1_KeyUp;
            this.KeyUp += Form1_KeyUp;
        }

        private void Form1_KeyUp(object? sender, KeyEventArgs e)
        {
            if (!Enum.TryParse(lab.Text, true, out Keys k)) return;
            if (k == e.KeyCode)
            {
                panel1.Controls.Remove(lab);
                heigh = 0;
                setlable();
            }
        }

        private void Labtime_Tick(object? sender, EventArgs e)
        {
            heigh += 2;
            lab.Top = heigh;
            if (lab.Top >= panel1.Height - 30)
            {
                labtime.Stop();
                
                MessageBox.Show("no");
                panel1.Controls.Remove(lab);
            }
        }

        private void setlable()
        {
            //获取随机字符
            string srt = "WGEWGDSOKERPOERKVPOSDKV";
            lab.Text = srt[rand.Next(srt.Length)].ToString();
            lab.Size = new Size(30, 30);//lable尺寸
            lab.Location = new Point(rand.Next(panel1.Width - 30), 0);//随机在x轴的坐标
            lab.TextAlign = ContentAlignment.MiddleCenter;
            lab.Font = new Font("楷体", 10F, FontStyle.Bold, GraphicsUnit.Point);
            panel1.Controls.Add(lab);

        }
    }
}
