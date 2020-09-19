using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    class securitySystem : decoratorOptions
    {
        public securitySystem(autoBase autoBase, string title)
            : base(autoBase, title)
        {
            this.name = autoBase.name + ". Повышенной безопасности";
            this.description = autoBase.description + ". " +
                this.title + ". Передние боковые подушки безопасности, ESP -система динамической стабилизации автомобиля";
        }

        public override double getCost()
        {
            return autoBase.getCost() + 20.99;
        }
    }
}
