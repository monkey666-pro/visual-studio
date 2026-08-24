/*
1. 将阶段考试项目代码自己写一遍
2. 将其中重复的代码 封装
3. 添加校验
    - id： int  
    - 薪资： double
*/

namespace day01
{
    internal static class Program
    {
        // 开辟一个新的线程： 用于渲染窗体界面
        [STAThread]
        static void Main() // 项目入口方法
        {
            
            ApplicationConfiguration.Initialize(); // 应用程序项目配置初始化
            //Application.Run(new Form1()); //应用程序运动 ===> 传递了一个窗体实例对象
            Application.Run(new Form2()); 
        }
    }
}