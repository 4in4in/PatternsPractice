using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethod
{
    class arithmeticProgression : progression
    {
        public arithmeticProgression(int first, int last, int step)
            : base(first, last, step)
        {
            progressionType = "Арифметическая";
        }

        public override void progress()
        {
            int counter = first;
            while (counter <= last)
            {
                progressionList.Add(counter);
                counter += step;
            }
        }
    }
}
