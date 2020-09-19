using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    class Dice : IGame
    {
        Random rnd;
        public Dice()
        {
            rnd = new Random();
        }
        public int Throw()
        {
            return rnd.Next(6)+1;
        }
    }
}
