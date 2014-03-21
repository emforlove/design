using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 策略模式
{
    class ConcreteStrategyC : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("策略模式具体实现C方法执行");
        }
    }
}
