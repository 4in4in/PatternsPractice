using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod
{
    abstract class TransportService
    {
        public string name { get; set; }

        public TransportService(string name)
        {
            this.name = name;
        }

        abstract public double CostTransportation(double distance);
    }
}
