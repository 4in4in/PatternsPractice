using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    class Program
    {
        static void Main()
        {
            Coin coin = new Coin();

            IGame coinAdapter = new AdapterGame(coin);
            Gamer gamer = new Gamer("Alex");
            Console.WriteLine("игрок: {1}\r\nкол-во очков: {0}", gamer.gameSession(coinAdapter), gamer.name);

            Console.ReadLine();
        }
    }
}
