using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    class decoratorOptions : autoBase
    {
        public autoBase autoBase { protected get; set; }

        public string title { get; set; }

        public decoratorOptions(autoBase autoBase, string title)
        {
            this.autoBase = autoBase;
            this.title = title;
        }

        public override double getCost()
        {
            throw new NotImplementedException();
        }
    }
}
