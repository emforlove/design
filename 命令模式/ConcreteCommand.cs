using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 命令模式
{
    class ConcreteCommand : Command
    {
        public ConcreteCommand(Receiver receiver) : base(receiver) { }

        public override void Exceute()
        {
            receiver.Action();
        }
    }
}
