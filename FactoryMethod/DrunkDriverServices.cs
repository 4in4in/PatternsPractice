using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod
{
    class DrunkDriverServices : TransportService
    {
        public double degree { get; set; }

        public DrunkDriverServices(string name, double degree)
            : base(name)
        {
            this.degree = degree;
        }
        public override double CostTransportation(double distance)
        {
            return (100 - degree)/100 * distance;
        }

        public override string ToString()
        {
            return String.Format("Услуга {0}, степень опьянения {1}", name, degree);
        }
    }
}
