using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class MiddleWare
    {
        // 定义一个消息盒子(字典)  键 暗号 值 是一个方法(有参数)
        private Dictionary<int, Action<object>> MsgBox = new Dictionary<int, Action<object>>() { };

        // 需要一个可以给消息盒子 添加消息(函数)   方法
        public void AddMsg(int Id, Action<object> callBack)
        {
            MsgBox[Id] = callBack; // 存储消息
        }

        // 需要一个可以调用消息的方法
        public void CallMsg(int Id, object data)
        {
            MsgBox[Id].Invoke(data); // 调用消息中的方法
        }

        // 单例模式
        private MiddleWare() { }
        private static MiddleWare instance { get; set; }
        public static MiddleWare GetInstance()
        {
            if (instance == null) instance = new MiddleWare();
            return instance;
        }

    }
}
