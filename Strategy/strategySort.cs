using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    abstract class strategySort
    {
        public string title { get; set; }
        public abstract void sort(int[] array);
    }
}
