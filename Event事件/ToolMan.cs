using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event事件
{

    delegate void DownStairDelegate();

    internal class ToolMan
    {
        public ToolMan(string name)
        {
            Name = name;
        }

        public event DownStairDelegate downStairDelegate = null;


        public string Name { get; private set; }

        public void DownStair()
        {
            Console.WriteLine("ToolMan:" + Name + "下楼了");

            downStairDelegate?.Invoke();

        }
    }
}
