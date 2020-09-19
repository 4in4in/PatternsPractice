using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    class Program
    {
        static void Main()
        {
            calculator calc = new calculator();
            double result = 0;

            result = calc.add(5);
            Console.WriteLine(result);
            result = calc.div(2);
            Console.WriteLine(result);

            result = calc.mul(4);
            Console.WriteLine(result);

            result = calc.sub(3);
            Console.WriteLine(result);

            result = calc.redo();
            Console.WriteLine(result);

            result = calc.undo();
            Console.WriteLine(result);



            Console.ReadLine();
        }
    }
}
