#define IsShowMessage
using System;
using System.Diagnostics;

namespace 特性
{

    class Program
    {
        [Obsolete]
        static void Test()
        {
            Console.WriteLine("已过时");
        }
        //相当于设置了一个全局的开关，可以通过定义宏来开启该方法
        [Conditional("IsShowMessage")]
        static void ShowMessage(string str)
        {
            Console.WriteLine(str);
        }

        //[Obsolete]
        static void Main(string[] args)
        {
            ShowMessage("Start to Main");

            Console.ReadLine();
        }
    }
}
