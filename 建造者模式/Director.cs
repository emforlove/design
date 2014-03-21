using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 建造者模式
{
    class Director
    {
        public void Construct(Builder builder)
        {
            builder.BuilderA();
            builder.BuilderB();
        }
    }
}
