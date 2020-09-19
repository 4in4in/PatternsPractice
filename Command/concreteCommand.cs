using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    class add : command
    {
        public add(arithmeticUnit unit, double operand)
        {
            this.unit = unit;
            this.operand = operand;
        }
        public override void execute()
        {
            unit.run('+', operand);
        }

        public override void unExecute()
        {
            unit.run('-', operand);
        }
    }

    class sub : command
    {
        public sub(arithmeticUnit unit, double operand)
        {
            this.unit = unit;
            this.operand = operand;
        }
        public override void execute()
        {
            unit.run('-', operand);
        }

        public override void unExecute()
        {
            unit.run('+', operand);
        }
    }

    class mul : command
    {
        public mul(arithmeticUnit unit, double operand)
        {
            this.unit = unit;
            this.operand = operand;
        }
        public override void execute()
        {
            unit.run('*', operand);
        }

        public override void unExecute()
        {
            unit.run('/', operand);
        }
    }

    class div : command
    {
        public div(arithmeticUnit unit, double operand)
        {
            this.unit = unit;
            this.operand = operand;
        }
        public override void execute()
        {
            unit.run('/', operand);
        }

        public override void unExecute()
        {
            unit.run('*', operand);
        }
    }
}
