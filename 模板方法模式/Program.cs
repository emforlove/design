using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 模板方法模式
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractClass ac = new ConcreteClassA();
            ac.TemplateMethod();

            ac = new ConcreteClassB();
            ac.TemplateMethod();

            Console.ReadLine();
        }
    }
}
