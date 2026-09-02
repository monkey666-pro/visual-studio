using AntdUI;

namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Thread.CurrentThread 查看当前线程
            //MessageBox.Show(Thread.CurrentThread.ToString());


            // 查看线程名称
            //Thread.CurrentThread.
            //Thread.CurrentThread.Name = "main主线程";
            //MessageBox.Show(Thread.CurrentThread.Name);

            // 查看线程id
            //MessageBox.Show(Thread.CurrentThread.ManagedThreadId.ToString());

            // 开启一个新线程
            //Thread th = new Thread(ForTest); // 线程方法的参数必须是object
            //// 查看线程状态
            ////th.ThreadState
            //MessageBox.Show("111-" + th.ThreadState);
            //// 线程需要启动执行
            ////th.Start();

            //th.Start(5000);
            //MessageBox.Show("444-" + th.ThreadState);
            //// 线程等待
            ////th.Join();
            //th.Join(2000); // 最多等2s            
            //MessageBox.Show("5555-" + th.ThreadState);
            //Thread.Sleep(8000);
            //MessageBox.Show("6666-" + th.ThreadState);


            // 线程休眠
            //MessageBox.Show("1234");
            //Thread.Sleep(2000);
            //MessageBox.Show("6666");



            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());
            Application.Run(new Form2());
            //Application.Run(new Form3());
        }
        //private static void ForTest()
        //{
        //    int sum = 0;
        //    for (int i = 0; i < 10000; i++)
        //    {
        //        sum += i;
        //    }
        //    MessageBox.Show(sum.ToString());
        //}

        private static void ForTest(object num)
        {
            int sum = 0;
            for (int i = 0; i < (int)num; i++)
            {
                sum += i;
            }
            MessageBox.Show("222-" + Thread.CurrentThread.ThreadState);
            Thread.Sleep(5000);
            MessageBox.Show("333-" + Thread.CurrentThread.ThreadState);
            MessageBox.Show(sum.ToString());
        }
    }
}