using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    class mediaNAV : decoratorOptions
    {
        public mediaNAV(autoBase autoBase, string title)
            : base(autoBase, title)
        {
            this.name = autoBase.name + ". Современный";
            this.description = autoBase.description + ". " +
                this.title + ". Обновленная мультимедийная навигационная система";
        }

        public override double getCost()
        {
            return autoBase.getCost() + 15.99;
        }
    }
}
