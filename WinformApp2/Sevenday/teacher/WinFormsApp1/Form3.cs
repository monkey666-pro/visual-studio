using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            //MessageBox.Show("666");
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // 开启并执行任务
            //Task.Run(() =>
            //{
            //    MessageBox.Show("里面：" + Thread.CurrentThread.ManagedThreadId.ToString());
            //});
            //MessageBox.Show("外面：" + Thread.CurrentThread.ManagedThreadId.ToString());

            //// 开启并执行 带返回值的任务
            //Task<int> task = Task<int>.Run(() =>
            //{
            //    return 10;
            //});

            //// task.Result 获取任务结果 (会阻塞程序)
            //MessageBox.Show(task.Result.ToString());


            // 带参数的任务
            //Task<int> task = Task<int>.Run(() => ShowOther(1, 2));
            //MessageBox.Show(task.Result.ToString());

            //Task<int> task = new Task<int>(() =>
            //{
            //    return 100;
            //});
            //task.Start();
            //Thread.Sleep(1000);
            //MessageBox.Show(task.Result.ToString());


            //Task<int> t = Task.Run(() =>
            //{
            //    Thread.Sleep(3000);
            //    MessageBox.Show("正在运行中。。。");
            //    return 100;
            //});

            //MessageBox.Show("开始等待");
            //t.Wait();  // 等待Task的线程执行结束
            //MessageBox.Show("等待结束");


            //Task[] tasks = new Task[3]; // 任务数组
            //for (int i = 1; i <= 3; i++)
            //{
            //    int num = i;
            //    tasks[i - 1] = Task.Run(() =>
            //    {
            //        Thread.Sleep(num * 3000);
            //        MessageBox.Show($"任务{num}运行");
            //    });
            //}
            ////Task.WhenAll(tasks).Wait();
            //Task.WhenAny(tasks).Wait();
            //MessageBox.Show("所有任务完成");


            Task<int> t1 = Task.Run(() =>
            {
                MessageBox.Show("t1");
                int num = 10;
                return num;
            });

            Task<int> t2 = t1.ContinueWith((Task<int> Prev) =>
            {
                MessageBox.Show("t2");
                // Prev 是上一个任务
                return Prev.Result % 3;
            });
            MessageBox.Show(t2.Result.ToString()); // 连续任务的结果


        }
      
        private int ShowOther(int a, int b)
        {
            return a + b;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //// 开启一个新线程
            //Thread t2 = new Thread(ShowOther);
            //t2.IsBackground = true; // 设置为后台线程
            //MessageBox.Show("111-"+t2.IsAlive.ToString());
            //t2.Start();
            //MessageBox.Show("222-" + t2.IsAlive.ToString());
            //Thread.Sleep(10000);
            //MessageBox.Show("444-" + t2.IsAlive.ToString());

            //MessageBox.Show("主"+Thread.CurrentThread.IsBackground.ToString());


            //var t2 = new Thread(ShowOther);
            //t2.Priority = ThreadPriority.BelowNormal;
            //t2.IsBackground = true;
            //t2.Start("低优先级线程：");

            //var t3 = new Thread(ShowOther);
            //t3.Priority = ThreadPriority.AboveNormal;
            //t3.IsBackground = true;
            //t3.Start("高优先级线程：");


            //ThreadPool.QueueUserWorkItem(state =>
            //{
            //   MessageBox.Show($"线程池线程执行，ID：{Thread.CurrentThread.ManagedThreadId}");
            //});


            //ThreadPool.QueueUserWorkItem(state =>
            //{
            //    MessageBox.Show($"线程池线程执行，ID：{Thread.CurrentThread.ManagedThreadId}----{state}");
            //},666);


            //ThreadPool.GetMinThreads(out int minWork, out int minIO);
            //ThreadPool.GetMaxThreads(out int maxWork, out int maxIO);

            //MessageBox.Show("最小工作线程:" + minWork);
            //MessageBox.Show("最小IO线程:" + minIO);

            //MessageBox.Show("最大工作线程:" + maxWork);
            //MessageBox.Show("最大IO线程:" + maxIO);

        }


        //private void ShowOther(object tip)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < 100000000; i++)
        //    {
        //        sum += i;
        //    }
        //    MessageBox.Show(tip.ToString() + sum.ToString());
        //}

        private void ShowOther()
        {
            Thread.Sleep(5000);
            var t1 = Thread.CurrentThread; // 获取当前线程
            MessageBox.Show(t1.IsBackground.ToString());
            MessageBox.Show("3333-" + t1.IsAlive.ToString());
        }
    }
}
