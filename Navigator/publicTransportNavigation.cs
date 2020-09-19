using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Navigator
{
    class publicTransportNavigation : strategyNavigation
    {
        public publicTransportNavigation()
        {
            title = "Прокладка маршрута на общественном транспорте";
        }

        public override void navigate()
        {
            Console.WriteLine("Позволяет построить маршрут на общественном транспорте.");
        }
    }
}
