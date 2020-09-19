using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    class arithmeticUnit
    {
        public double register { get; private set; }

        public void run(char operationCode, double operand)
        {
            switch (operationCode)
            {
                case '+': register += operand; break;
                case '-': register -= operand; break;
                case '*': register *= operand; break;
                case '/': register /= operand; break;
            }
        }
    }
}
