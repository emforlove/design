using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 适配器模式
{
    class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Specific Request");
        }
    }
}
