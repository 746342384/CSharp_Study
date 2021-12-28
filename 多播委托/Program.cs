using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多播委托
{
    class Program
    {
        static void Main(string[] args)
        {
            Action method = null;
            method += Method1;
            method += Method2;
            method();
            method -= Method1;
            method();
            method += Method1;
            method += Method1;
            method();
            Delegate[] delegates = method.GetInvocationList();
            foreach (var item in delegates)
            {
                item.DynamicInvoke();
            }
            Console.ReadLine();
        }

        private static void Method2()
        {
            Console.WriteLine("Method2");
        }

        private static void Method1()
        {
            Console.WriteLine("Method1");
        }
    }
}
