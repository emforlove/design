using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 模板方法模式
{
    class ConcreteClassB : AbstractClass
    {
        public override void PrmitiveOperationA()
        {
            Console.WriteLine("具体类B方法A实现");
        }

        public override void PrmitiveOperationB()
        {
            Console.WriteLine("具体类B方法B实现");
        }
    }
}
