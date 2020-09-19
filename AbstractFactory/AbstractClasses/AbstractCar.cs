using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    abstract class AbstractCar
    {
        public string name { get; set; }
        public abstract int maxSpeed(AbstractEngine engine);

        public abstract string bodyName(AbstractBody body);
    }
}
