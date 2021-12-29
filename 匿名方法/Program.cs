using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 匿名方法
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> plus = delegate (int a, int b)
                  {
                      return a + b;
                  };

            Console.WriteLine(plus(1, 2));

            Console.ReadLine();


        }
    }
}
