namespace Fourday
{
    public partial class Form1 : Form
    {
        private DateTime startime { get; set; }
        private DateTime finaltime { get; set; }
        private bool flag = true;//开关
        private int n = 0;
        public Form1()
        {
            InitializeComponent();
            this.KeyDown += kd;
            this.KeyUp += ku;
        }
        private void kd(object sender, KeyEventArgs e)
        {
            if (flag)
            {
                n++;
                startime = DateTime.Now;
                flag = false;
            }
            
            
        }
        private void ku(object sender, KeyEventArgs e)
        {
            if (!flag)
            {
                finaltime = DateTime.Now;
                TimeSpan time = (finaltime - startime);
                label2.Text = n.ToString() + "--------" + time.TotalMilliseconds.ToString();
                flag = true;
            }


        }
    }
}
