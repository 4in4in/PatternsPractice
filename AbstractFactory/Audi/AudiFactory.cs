using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    class AudiFactory : CarFactory
    {
        private static AudiFactory thisFactory = null;
        private AudiFactory() { }
        public static AudiFactory instance
        {
            get
            {
                if (thisFactory == null) thisFactory = new AudiFactory();
                return thisFactory;
            }
        }
        public override AbstractCar CreateCar()
        {
            return new AudiCar();
        }

        public override AbstractEngine CreateEngine()
        {
            return new AudiEngine();
        }

        public override AbstractBody CreateBody()
        {
            return new AudiBody();
        }
    }
}
