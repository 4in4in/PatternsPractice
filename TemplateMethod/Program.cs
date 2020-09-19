using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethod
{
    class Program
    {
        static void Main()
        {
            progression p = new arithmeticProgression(2, 44, 2);
            p.templateMethod();

            p = new geometricProgression(10, 1000, 10);
            p.templateMethod();

            Console.ReadLine();
        }
    }
}
