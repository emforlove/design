using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 建造者模式
{
    abstract class Builder
    {
        public abstract void BuilderA();
        public abstract void BuilderB();
        public abstract Product GetResult();
    }
}
