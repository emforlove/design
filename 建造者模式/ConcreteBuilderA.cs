﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 建造者模式
{
    class ConcreteBuilderA : Builder
    {
        private Product product = new Product();

        public override void BuilderA()
        {
            product.Add("部件A");
        }

        public override void BuilderB()
        {
            product.Add("部件B");
        }

        public override Product GetResult()
        {
            return product;
        }
    }
}
