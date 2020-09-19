using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    class Client
    {
        private AbstractCar abstractCar;
        private AbstractEngine abstractEngine;
        private AbstractBody abstractBody;

        public Client(CarFactory carFactory)
        {
            abstractCar = carFactory.CreateCar();
            abstractEngine = carFactory.CreateEngine();
            abstractBody = carFactory.CreateBody();
        }

        public int runMaxSpeed()
        {
            return abstractCar.maxSpeed(abstractEngine);
        }

        public string getCarName()
        {
            return abstractCar.name;
        }

        public string getCarBody()
        {
            return abstractCar.bodyName(abstractBody);
        }
    }
}
