using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 模板方法模式
{
    abstract class AbstractClass
    {
        public abstract void PrmitiveOperationA();
        public abstract void PrmitiveOperationB();

        public void TemplateMethod()
        {
            PrmitiveOperationA();
            PrmitiveOperationB();

            Console.WriteLine("");
        }
    }
}
