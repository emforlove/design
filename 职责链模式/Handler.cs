﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 职责链模式
{
    abstract class Handler
    {
        protected Handler successor;

        public void SetSuccessor(Handler successor)
        {
            this.successor = successor;
        }

        public abstract void HandleRequest(int request);
    }
}
