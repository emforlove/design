using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 建造者模式
{
    class ConcreteBuilderB : Builder
    {
        private Product product = new Product();

        public override void BuilderA()
        {
            product.Add("部件X");
        }

        public override void BuilderB()
        {
            product.Add("部件Y");
        }

        public override Product GetResult()
        {
            return product;
        }
    }
}
