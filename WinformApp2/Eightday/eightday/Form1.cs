namespace eightday
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task<int> t1 = Task.Run(() =>
            {
                //throw new Exception("ccc");抛出一个错误
                //MessageBox.Show(Thread.CurrentThread.ManagedThreadId.ToString());
                return 100;
            });
            Task<string> t2 = t1.ContinueWith((Task<int> prv) =>
            {
                //MessageBox.Show(Thread.CurrentThread.ManagedThreadId.ToString());
                return "6666";


            });
            //,TaskContinuationOptions.OnlyOnCanceled)
            //MessageBox.Show(t2.Result.ToString());
            CancellationTokenSource css = new CancellationTokenSource();
            Task t11 = Task.Run(() =>
            {
                MessageBox.Show("rw");
            }, css.Token);//取消令牌
            css.Cancel(); //如果取消后面就不执行
            //MessageBox.Show(t1.Result.ToString());
        }

        private async void button2_Click(object sender, EventArgs e)
        {
           string a1= await a();
            //MessageBox.Show(a1);
        }
        private async Task<string> a()
        {
         await   Task.Run(() =>
            {
                //MessageBox.Show("start");
                //Thread.Sleep(3000);
            });
            return "ok";//async:return的是task的结果
        }
    }
}
