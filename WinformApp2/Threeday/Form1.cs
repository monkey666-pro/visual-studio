namespace Threeday
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            into();
        }
        public string[] patharr = [@"./images/bird.jpg", @"./images/cat.jpg", @"./images/eagle.jpg"]; 
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public int i = 0;
        public void into()
        {
            pictureBox1.Image = Image.FromFile(patharr[0]);
            button1.BackColor = Color.Blue;
            button1.ForeColor = Color.Red;
            button1.Click += able;
            button2.Click += able;
            button3.Click += able;
            button4.Click += able;
            button5.Click += able;
        }
        public void able(object senser, EventArgs e)
        {
           
            //全部默认(可以通过容器再进行循环，方便)
            button1. BackColor = Color.LightGray;
            button1.ForeColor = Color.Black;
            button2.BackColor = Color.LightGray;
            button2.ForeColor = Color.Black;
            button3.BackColor = Color.LightGray;
            button3.ForeColor = Color.Black;
            button4.BackColor = Color.LightGray;
            button4.ForeColor = Color.Black;
            button5.BackColor = Color.LightGray;
            button5.ForeColor = Color.Black;
            //当前按钮配置
            Button bt = (Button)senser;
            bt.BackColor = Color.Blue;
            bt.ForeColor = Color.Red;

            if (bt.Text == "<" || bt.Text == ">")
            {
                if (bt.Text == "<")
                {
                    if (i - 1 >= 0)
                    {
                        pictureBox1.Image = Image.FromFile(patharr[i - 1]);
                        i = i - 1;

                    }
                    else
                    {
                        pictureBox1.Image = Image.FromFile(patharr[2]);
                        i = 2;
                    }
                   

                }

                if (bt.Text == ">")
                {
                    if (i + 1 < 3)
                    {
                        pictureBox1.Image = Image.FromFile(patharr[i + 1]);
                        i = i + 1;

                    }
                    else
                    {
                        pictureBox1.Image = Image.FromFile(patharr[0]);
                        i = 0;
                    }
                  
                }

            }

            else
            {

                pictureBox1.Image = Image.FromFile(patharr[int.Parse(bt.Text) - 1]);
                i = int.Parse(bt.Text) - 1;
            }
            
        }
    }
}
