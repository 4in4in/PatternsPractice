using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Navigator
{
    class attractionsNavigation : strategyNavigation
    {
        public attractionsNavigation()
        {
            title = "Прокладка маршрута по достопримечательностям";
        }
        public override void navigate()
        {
            Console.WriteLine("Позволяет построить маршрут по достопримечательностям.");

        }
    }
}
