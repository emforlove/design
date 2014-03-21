using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 享元模式
{
    class Program
    {
        static void Main(string[] args)
        {
            int extrinsicstate = 22;

            FlyweightFactory f = new FlyweightFactory();

            Flyweight fx = f.GetFlyweight("X");
            fx.Operation(--extrinsicstate);

            Flyweight fy = f.GetFlyweight("Y");
            fy.Operation(--extrinsicstate);

            Flyweight fz = f.GetFlyweight("Z");
            fz.Operation(--extrinsicstate);

            Flyweight uf = new UnsharedConcreteFlyweight();
            uf.Operation(--extrinsicstate);

            Flyweight fx2 = f.GetFlyweight("X");
            fx2.Operation(--extrinsicstate);

            if (fx.Equals(fx2))
            {
                Console.WriteLine("equals");
            }
            else
            {
                Console.WriteLine("not equals");
            }

            Console.ReadLine();
        }
    }
}
