using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 状态模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Context c = new Context(new ConcreteStateA());

            c.Request();
            c.Request();
            c.Request();
            c.Request();
            c.Request();

            Console.ReadLine();
        }
    }
}
