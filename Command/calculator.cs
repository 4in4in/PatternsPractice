using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    class calculator
    {
        arithmeticUnit arithmeticUnit;
        controlUnit controlUnit;

        public calculator()
        {
            arithmeticUnit = new arithmeticUnit();
            controlUnit = new controlUnit();
        }

        private double run(command cmd)
        {
            controlUnit.storeCommand(cmd);
            controlUnit.executeCommand();
            return arithmeticUnit.register;
        }

        public double add(double operand)
        {
            return run(new add(arithmeticUnit, operand));
        }

        public double sub(double operand)
        {
            return run(new sub(arithmeticUnit, operand));
        }

        public double mul(double operand)
        {
            return run(new mul(arithmeticUnit, operand));
        }
        public double div(double operand)
        {
            return run(new div(arithmeticUnit, operand));
        }

        public double undo()
        {
            controlUnit.undo();
            return arithmeticUnit.register;
        }

        public double redo()
        {
            controlUnit.redo();
            return arithmeticUnit.register;
        }
    }
}
