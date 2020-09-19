using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod
{
    class ShipTransCom : TransportCompany
    {
        public ShipTransCom(string name):
            base(name) { }

        public override TransportService Create(string name, int cost)
        {
            return new ShippingServices(name, cost);
        }
    }
}
