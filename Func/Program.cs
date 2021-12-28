using System;

namespace Func
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string> method1 = Test1;
            Console.WriteLine(method1());

            Func<int, int, int> method2 = Test2;
            Console.WriteLine(method2(1, 2));


            Console.ReadLine();
        }

        private static int Test2(int arg1, int arg2)
        {
            return arg1 + arg2;
        }

        private static string Test1()
        {
            return "Test1";
        }
    }
}
