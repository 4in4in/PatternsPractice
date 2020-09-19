using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod
{
    abstract class TransportCompany
    {
        public string name { get; set; }

        public TransportCompany(string name)
        {
            this.name = name;
        }

        abstract public TransportService Create(string name, int cost);
    }
}
