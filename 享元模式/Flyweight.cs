using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 享元模式
{
    abstract class Flyweight
    {
        public abstract void Operation(int extrinsicstate);
    }
}
