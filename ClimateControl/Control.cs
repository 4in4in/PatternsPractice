using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClimateControl
{
    class Control
    {
        public Control() { }

        public double controlSession(ISensor sensor)
        {
            return sensor.getTemperature();
        }
    }
}
