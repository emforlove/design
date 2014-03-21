using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 适配器模式
{
    abstract class Target
    {
        public virtual void Request()
        {
            Console.WriteLine("Common Request");
        }
    }
}
