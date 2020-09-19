using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    class Gamer
    {
        public string name { get; set; }

        public Gamer(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return name;
        }

        public int gameSession(IGame ig)
        {
            return ig.Throw();
        }
    }
}
