using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 反射
{
    internal class MyClass
    {
        private int a;
        private int b;
        public int c;
        public int d;

        public string Name { get; set; }

        public void MyMethod()
        {
            Console.WriteLine("这是一个方法");
        }

        public void MyMethod(string str)
        {
            Console.WriteLine("这是一个有参数的方法" + str);
        }
        public string MyMethod(string str1, string str2)
        {
            Console.WriteLine("这是一个有返回值参数的方法" + str1 + str2);
            return str1 + str2;
        }
    }
}
