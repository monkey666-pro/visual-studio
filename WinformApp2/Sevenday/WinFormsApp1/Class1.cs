using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    internal class Class1
    {

        //作用：定义二个窗体联系的媒介
        private Dictionary<int, Action<object>> middle = new Dictionary<int, Action<object>>() { };
        //添加一个装 信息的方法
        public void add(int Id, Action<object> a1)
        {
            middle[Id] = a1;//此时函数还没有执行
        }
        //添加一个处理消息的方法
        public void call(int Id, object text)
        {
            middle[Id]  (text);//函数执行
        }
        //单例模式
        private Class1() { }
        private static Class1 a { get; set; }
        public static Class1 geta()
        {
            if(a==null)a= new  Class1();
            return a;
        }
    }
}
