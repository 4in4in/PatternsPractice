using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    class AdapterGame : IGame
    {
        Coin coin;

        public AdapterGame(Coin coin)
        {
            this.coin = coin;
        }

        public int Throw()
        {
            return coin.ThrowCoin();
        }
    }
}
