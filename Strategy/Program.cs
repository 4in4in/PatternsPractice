using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    class Program
    {
        static void Main()
        {
            int[] array1 = new int[] 
            { 31, 15, 10, 2, 4, 2, 14, 23, 12, 66 };

            strategySort sort = new selectionSort();
            context context = new context(sort, array1);

            context.sort();
            context.printArray();

            int[] array2 = new int[] 
            { 1, 5, 10, 2, 4, 12, 14, 23, 12, 66 };

            sort = new insertionSort();
            context = new context(sort, array2);

            context.sort();
            context.printArray();

            int[] array3 = new int[] { 1, 4, 9, 2, 8, 12, 14, 34, 15, 61 };

            sort = new bubbleSort();
            context = new context(sort, array3);

            context.sort();
            context.printArray();

            Console.ReadLine();
        }
    }
}
