using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 命令模式
{
    abstract class Command
    {
        protected Receiver receiver;

        public Command(Receiver receiver)
        {
            this.receiver = receiver;
        }

        abstract public void Exceute();
    }
}
