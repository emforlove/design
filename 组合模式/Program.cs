using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 组合模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Composite root = new Composite("Root");
            root.Add(new Leaf("Leaf A"));
            root.Add(new Leaf("Leaf B"));
            root.Add(new Leaf("Leaf C"));

            Composite comp = new Composite("Comp X");
            comp.Add(new Leaf("Leaf XA"));
            comp.Add(new Leaf("Leaf XB"));
            comp.Add(new Leaf("Leaf XC"));

            root.Add(comp);

            Composite comp2 = new Composite("Comp Y");
            comp2.Add(new Leaf("Leaf YA"));
            comp2.Add(new Leaf("Leaf YB"));
            comp2.Add(new Leaf("Leaf YC"));

            Composite comp3 = new Composite("Comp YZ");
            comp3.Add(new Leaf("Leaf ZYA"));
            comp3.Add(new Leaf("Leaf ZYB"));
            comp3.Add(new Leaf("Leaf ZYC"));

            comp2.Add(comp3);

            root.Add(comp2);

            root.Add(new Leaf("Leaf D"));

            root.Display(1);

            Console.ReadLine();
        }
    }
}
