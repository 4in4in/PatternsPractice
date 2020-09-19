using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    class selectionSort : strategySort
    {
        public selectionSort()
        {
            title = "Сортировка выбором";
        }
        public override void sort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int k = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[k] > array[j]) k = j;
                }
                if (k != i)
                {
                    int buffer = array[k];
                    array[k] = array[i];
                    array[i] = buffer;
                }
            }
        }
    }
}
