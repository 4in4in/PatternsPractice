using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Navigator
{
    abstract class strategyNavigation
    {
        public string title { get; set; }

        public abstract void navigate();
    }
}
