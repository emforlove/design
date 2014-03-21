﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 单例模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();

            if (s1 == s2)
            {
                Console.WriteLine("两个对象是相同的实例！");
            }

            Console.ReadLine();
        }
    }
}
