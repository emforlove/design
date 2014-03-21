using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 策略模式
{
    abstract class Strategy
    {
        public abstract void AlgorithmInterface();

        public virtual void Test()
        {
            Console.WriteLine("ttttt");
        }
    }
}
