using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod
{
    class ShippingServices : TransportService
    {
        public double tariff { get; set; }

        public ShippingServices(string name, int tariff) :
            base(name)
        {
            this.tariff = tariff;
        }

        public override double CostTransportation(double distance)
        {
            return distance * tariff;
        }

        public override string ToString()
        {
            return String.Format("Фирма {0}, доставка по тарифу {1}",name,tariff);
        }


    }
}