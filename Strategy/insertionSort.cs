﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    class insertionSort : strategySort
    {
        public insertionSort()
        {
            title = "Сортировка вставками";
        }

        public override void sort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int j = 0;
                int buffer = array[i];
                for (j = i - 1; j >= 0; j--)
                {
                    if (array[j] < buffer) break;
                    array[j + 1] = array[j];
                }
                array[j + 1] = buffer;
            }
        }
    }
}
