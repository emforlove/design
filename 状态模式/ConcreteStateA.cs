using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 状态模式
{
    class ConcreteStateA : State
    {
        public override void Handle(Context context)
        {
            context.State = new ConcreteStateB();
        }
    }
}
