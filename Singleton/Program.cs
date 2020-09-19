using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Singleton
{
    class Program
    {
        static void Main()
        {
            Log log = Log.MyLog;
            log.logExecution("Метод Main()");

            double operand = Operation.run('-', 35);
            operand = Operation.run('+', 30);

            Process.Start("notepad.exe", "log.txt");
        }
    }
}
