using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    class citroen : autoBase
    {
        public citroen(string name, string description, double costBase)
        {
            this.name = name;
            this.description = description;
            this.costBase = costBase;
        }

        public override double getCost()
        {
            return costBase * 1.23;
        }
    }
}
