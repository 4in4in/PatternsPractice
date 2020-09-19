using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Navigator
{
    class map
    {
        private strategyNavigation strategyNavigation;

        public map(strategyNavigation strategyNavigation)
        {
            this.strategyNavigation = strategyNavigation;
        }

        public void navigate()
        {
            strategyNavigation.navigate();
        }
    }
}
