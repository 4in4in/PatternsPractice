using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    class AudiCar : AbstractCar
    {
        public AudiCar()
        {
            name = "Ауди";
        }
        public override int maxSpeed(AbstractEngine engine)
        {
            return engine.maxSpeed;
        }

        public override string bodyName(AbstractBody body)
        {
            return body.bodyName;
        }
    }
}
