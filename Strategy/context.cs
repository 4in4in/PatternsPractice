using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    class context
    {
        strategySort strategySort;
        int[] array;

        public context(strategySort strategySort, int[] array)
        {
            this.strategySort = strategySort;
            this.array = array;
        }

        public void sort()
        {
            strategySort.sort(array);
        }

        public void printArray()
        {
            Console.WriteLine(strategySort.title);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
