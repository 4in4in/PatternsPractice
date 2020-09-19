using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Navigator
{
    class roadNavigation : strategyNavigation
    {
        public roadNavigation()
        {
            title = "Прокладка автомобильного маршрута";
        }
        public override void navigate()
        {
            Console.WriteLine("Позволяет построить маршрут по автодороге.");
        }
    }
}
