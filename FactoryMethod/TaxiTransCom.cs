using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod
{
    class TaxiTransCom : TransportCompany
    {

        public TaxiTransCom(string name):
            base(name) { }

        public override TransportService Create(string name, int cost)
        {
            return new TaxiServices(name, cost);
        }
    }
}
