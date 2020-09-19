using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton
{
    class Operation
    {
        public static double run(char operCode, int operand)
        {
            Log log = Log.MyLog;
            double result = 0;

            switch (operCode)
            {
                case '+':
                    {
                        result += operand;
                        log.logExecution("Сложение " + operand);
                        break;
                    }
                case '-':
                    {
                        result -= operand;
                        log.logExecution("Вычитание " + operand);
                        break;
                    }
                case '*':
                    {
                        result *= operand;
                        //log.logExecution("Умножение" + operand);
                        break;
                    }
                case '/': case ':':
                    {
                        result /= operand;
                        //log.logExecution("Деление " + operand);
                        break;
                    }
            }
            return result;
        }
    }
}
