using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethod
{
    abstract class progression
    {
        public int first { get; set; }
        public int last { get; set; }
        public int step { get; set; }

        public string progressionType { get; set; }

        public List<int> progressionList;

        public progression(int first, int last, int step)
        {
            this.first = first;
            this.last = last;
            this.step = step;

            progressionList = new List<int>();
        }

        public void templateMethod()
        {
            initializeProgression(first, last, step);
            progress();
            print(progressionList);
        }

        private void print(List<int> progression)
        {
            Console.Write("[");
            foreach (int item in progression) Console.Write(" " + item);
            Console.WriteLine(" ]");
        }

        public abstract void progress();

        private void initializeProgression(int first, int last, int step)
        {
            Console.WriteLine("{3} прогрессия от {0} до {1} с шагом {2}:", first, last, step, progressionType);
        }
    }
}
