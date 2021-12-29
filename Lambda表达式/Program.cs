using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda表达式
{
    class Program
    {
        static void Main(string[] args)
        {
            //Func<int, int, int> plus = (a, b) => { return a + b; };
            //Func<int, int, int> plus = (a, b) => a + b;
            //Console.WriteLine(plus(1, 2));

            Func<double, double> square = x => x * x;
            Console.WriteLine(square(2));

            int a = 5;
            Func<int, int> f = x => x + a;
            Console.WriteLine(f(5));
            a = 8;
            Console.WriteLine(f(5));
            Console.ReadLine();
        }
    }
}
