using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    abstract class command
    {
        protected arithmeticUnit unit;
        protected double operand;
        public abstract void execute();
        public abstract void unExecute();
    }
}
