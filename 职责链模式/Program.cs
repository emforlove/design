﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 职责链模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Handler h1 = new ConcreteHandler1();
            Handler h2 = new ConcreteHandler2();
            Handler h3 = new ConcreteHandler3();
            h1.SetSuccessor(h2);
            h2.SetSuccessor(h3);

            int[] requests = {2, 5, 8, 12, 15, 23, 28};

            foreach (int request in requests)
            {
                h1.HandleRequest(request);
            }

            Console.ReadLine();
        }
    }
}
