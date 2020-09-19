using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    class windowLiftSystem : decoratorOptions
    {
        public windowLiftSystem(autoBase autoBase, string title)
            : base(autoBase, title)
        {
            this.name = autoBase.name + ". Электростеклоподъемники";
            this.description = autoBase.description + ". " +
                this.title + ". Нажми на кнопку - получишь результат";
        }
        public override double getCost()
        {
            return autoBase.getCost() + 16.69;
        }
    }
}
