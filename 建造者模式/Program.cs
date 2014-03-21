using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 建造者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();

            Builder b1 = new ConcreteBuilderA();
            Builder b2 = new ConcreteBuilderB();

            director.Construct(b1);
            Product p1 = b1.GetResult();
            p1.Show();

            director.Construct(b2);
            Product p2 = b2.GetResult();
            p2.Show();

            Console.ReadLine();
        }
    }
}
