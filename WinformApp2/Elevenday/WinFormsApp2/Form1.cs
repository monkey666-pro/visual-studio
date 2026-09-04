namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += (object sender, EventArgs e) => ShowTime();
            timer.Start();
            ShowTime();
        }
        private void ShowTime()
        {
            TimeSpan diff = DateTime.Parse("2026-10-1 0:0:0") - DateTime.Now;
            label3.Text = Math.Floor(diff.TotalDays).ToString();
            label4.Text = Math.Floor(diff.TotalHours % 24).ToString();
            label6.Text = Math.Floor(diff.TotalMinutes % 60).ToString();
            label8.Text = Math.Floor(diff.TotalSeconds % 60).ToString();

        }
    }
}
