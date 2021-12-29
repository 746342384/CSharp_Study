using System;
using System.Reflection;

namespace 反射
{
    class Program
    {
        static void Main(string[] args)
        {
            //Type
            //Type t = typeof(MyClass);
            MyClass myClass = new MyClass();
            Type t = myClass.GetType();
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

            MethodInfo[] methods = t.GetMethods();
            foreach (var item in methods)
            {
                Console.WriteLine(item.Name);
            }
            Object obj = Activator.CreateInstance(t);
            MethodInfo method = t.GetMethod("MyMethod",
                new Type[] { });
            object[] parameters = null;
            method?.Invoke(obj, parameters);
            method = t.GetMethod("MyMethod",
                new Type[]
                {
                    typeof(string)
                });
            parameters = new object[] { "hello world!" };
            method?.Invoke(obj, parameters);

            method = t.GetMethod("MyMethod", new Type[]
                {
                    typeof(string),
                    typeof(string)
                });
            parameters = new object[] { "hello", " world!" };
            var result = method?.Invoke(obj, parameters);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
