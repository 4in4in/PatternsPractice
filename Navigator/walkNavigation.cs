using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Navigator
{
    class walkNavigation : strategyNavigation
    {
        public walkNavigation()
        {
            title = "Прокладка пешего маршрута";
        }
        public override void navigate()
        {
            Console.WriteLine("Позволяет построить пеший маршрут.");
        }
    }
}
