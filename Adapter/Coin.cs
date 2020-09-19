using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    class Coin
    {
        Random rnd;

        public Coin()
        {
            rnd = new Random();
        }

        public int ThrowCoin()
        {
            return rnd.Next(2) + 1;
        }
    }
}
