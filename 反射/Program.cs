using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace 反射
{
    class Program
    { 
        static void Main(string[] args)
        {
            //Type
            Type t = typeof(MyClass);

            Console.WriteLine(t.Name);
            Console.WriteLine(t.Namespace);
            Console.WriteLine(t.Assembly);

            FieldInfo[] fields = t.GetFields();

            foreach (var item in fields)
            {
                Console.WriteLine(item.Name);
            }
            PropertyInfo[] properties = t.GetProperties();
            foreach (var item in properties)
            {
                Console.WriteLine(item.Name);
            }
            Console.ReadLine();
        }
    }
}
