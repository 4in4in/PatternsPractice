using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClimateControl
{
    class Sensor : ISensor
    {
        int min = -148;
        int max = 212;

        Random rnd;

        public Sensor()
        {
            rnd = new Random();
        }

        public double getTemperature()
        {
            return (double)rnd.Next(min * 10, max * 10) / 10;
        }
    }
}
