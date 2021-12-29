using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event事件
{
    class Program
    {
        static void Main(string[] args)
        {
            ToolMan toolMan = new ToolMan("小明");
            LazyMan lazyMan1 = new LazyMan("张三");
            LazyMan lazyMan2 = new LazyMan("李四");
            LazyMan lazyMan3 = new LazyMan("王五");


            toolMan.downStairDelegate += lazyMan1.TakePackage;
            toolMan.downStairDelegate += lazyMan1.TakeFood;
            toolMan.downStairDelegate += lazyMan2.TakePackage;
            toolMan.downStairDelegate += lazyMan3.TakeFood;
            toolMan.downStairDelegate += lazyMan2.TakeFood;
            toolMan.downStairDelegate += lazyMan3.TakePackage;

            toolMan.DownStair();
            Console.ReadLine();
        }
    }
}
