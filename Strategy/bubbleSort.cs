using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    class bubbleSort : strategySort
    {
        public bubbleSort()
        {
            title = "Сортировка пузырьком";
        }
                                  
        public override void sort(int[] array)
        {
            for (int j = 1; j < array.Length; j++)
            {
                for (int i = 0; i < array.Length - j; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int buffer = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = buffer;
                    }
                }
            }
        }
    }
}
