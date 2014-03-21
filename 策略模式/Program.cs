using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 策略模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context;

            context = new Context(new ConcreteStrategyA());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyB());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyC());
            context.ContextInterface();

            Console.ReadLine();

            context = new Context("A");
            context.ContextInterface();

            context = new Context("B");
            context.ContextInterface();

            context = new Context("C");
            context.ContextInterface();

            Console.ReadLine();

        }
    }
}
