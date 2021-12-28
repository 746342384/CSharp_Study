using System;

namespace Delegate
{
    class Program
    {
        delegate void MyIntMethodDelegate(int x);
        delegate long TwoLongDelegate(long a, long b);
        delegate string GetAStringDelegate();
        delegate double DoubleOpDelegate(double x);
        static void Main(string[] args)
        {
            MyIntMethodDelegate myIntMethod = null;
            TwoLongDelegate twoLong = null;
            myIntMethod = Test;
            myIntMethod(100);
            twoLong = TestTwoLong;
            twoLong(1, 2);

            int x = 123;
            GetAStringDelegate getAString = x.ToString;
            GetAStringDelegate getAString1 = new GetAStringDelegate(x.ToString);
            Console.WriteLine(getAString());
            Console.WriteLine(getAString1());

            DoubleOpDelegate[] doubleOpDelegates = { MathOp.MultiPlayByTwo, MathOp.Square };

            foreach (var item in doubleOpDelegates)
            {
                ProcessAndDisplayRes(item, 5);
            }


            Console.ReadLine();
        }

        static void ProcessAndDisplayRes(DoubleOpDelegate doubleOpDelegate, double x)
        {
            double result = doubleOpDelegate(x);
            Console.WriteLine("ProcessAndDisplayRes:" + result);
        }

        private static long TestTwoLong(long a, long b)
        {
            Console.WriteLine("我是twoLong" + (a + b));
            return a + b;
        }

        private static void Test(int x)
        {
            Console.WriteLine("我是MyIntMethod" + x);
        }
    }
}
