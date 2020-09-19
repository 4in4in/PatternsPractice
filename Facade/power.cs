using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    class power
    {
        public event EventHandler powerEvent;

        private int powerValue;

        public int microwavePower
        {
            get { return powerValue; }
            set
            {
                powerValue = value;

                if (powerEvent != null) powerEvent(this, new EventArgs());
            }
        }

        public string getState()
        {
            return String.Format("Задана мощность {0} Вт", microwavePower);
        }
    }
}
