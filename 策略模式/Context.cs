                             using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace 策略模式
{
    class Context
    {
        Strategy strategy;

        public Context(Strategy strategy)
        {
            this.strategy = strategy;
        }

        public void ContextInterface()
        {
            strategy.AlgorithmInterface();
        }

        // 简单工厂 + 策略模式

        public Context(string type)
        {
            switch (type)
            {
                case "A":
                    strategy = new ConcreteStrategyA();
                    break;
                case "B":
                    strategy = new ConcreteStrategyB();
                    break;
                case "C":
                    strategy = new ConcreteStrategyC();
                    break;
            }

            Assembly assembly = null;
            Type t = null;
            Object obj = null;
            MethodInfo mi = null;

            assembly = Assembly.LoadFrom("");
            t = assembly.GetType("");

            obj = Activator.CreateInstance(t);
            mi = t.GetMethod("");

            mi.Invoke(obj, null); // 调用反射 
            

        }

        // 反射 + 简单工厂 + 策略模式


        
    }
}
