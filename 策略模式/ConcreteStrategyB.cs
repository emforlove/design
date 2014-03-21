using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 策略模式
{
    class ConcreteStrategyB : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("策略模式具体实现B方法执行");
        }
    }
}
