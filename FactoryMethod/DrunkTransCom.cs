using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod
{
    class DrunkTransCom : TransportCompany
    {
        public DrunkTransCom(string name)
            : base(name) { }
        public override TransportService Create(string name, int cost)
        {
            return new DrunkDriverServices(name, cost);
        }
    }
}
