using System;

namespace ActionAndFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            Action method = Test1;
            method();
            Action<int> method2 = Test2;
            method2(1);
            Action<int, string, double> method3 = Test3;
            method3(2, "Action", 3);
            Console.ReadLine();
        }

        private static void Test3(int arg1, string arg2, double arg3)
        {
            Console.WriteLine("Test3:" + arg1 + arg2 + arg3);
        }

        private static void Test2(int obj)
        {
            Console.WriteLine("Test2:" + obj);
        }

        private static void Test1()
        {
            Console.WriteLine("Test1");
        }
    }
}
