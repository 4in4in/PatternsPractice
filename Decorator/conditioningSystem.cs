using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    class conditioningSystem : decoratorOptions
    {
        public conditioningSystem(autoBase autoBase, string title)
            : base(autoBase, title)
        {
            this.name = autoBase.name + ". Кондиционер";
            this.description = autoBase.description + ". " +
                this.title + ". Наличие кондиционера";
        }
        public override double getCost()
        {
            return autoBase.getCost() + 21.99;
        }
    }
}
