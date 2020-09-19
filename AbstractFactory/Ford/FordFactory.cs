using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    class FordFactory : CarFactory
    {
        private static FordFactory thisFactory = null;
        private FordFactory() { }
        public static FordFactory instance
        {
            get
            {
                if (thisFactory == null) thisFactory = new FordFactory();
                return thisFactory;
            }
        }
        public override AbstractCar CreateCar()
        {
            return new FordCar("Форд");
        }

        public override AbstractEngine CreateEngine()
        {
            return new FordEngine();
        }

        public override AbstractBody CreateBody()
        {
            return new FordBody();
        }
    }
}
