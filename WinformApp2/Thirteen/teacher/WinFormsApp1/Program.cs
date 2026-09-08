// 1. 先引用命名空间（注意：using 后面是DLL里定义的命名空间）
using MyTools;
using System.Runtime.InteropServices;
namespace WinFormsApp1
{
    internal static class Program
    {
        [DllImport("kernel32.dll")]
        public static extern bool AllocConsole();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // 2. 直接实例化 DLL 中的类并使用其方法
            //Person p = new Person();
            //MessageBox.Show(p.GetName());

            AllocConsole();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());           
            //Application.Run(new Form2());
            Application.Run(new Form3());
        }
    }
}