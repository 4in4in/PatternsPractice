using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClimateControl
{
    class TemperatureAdapter : ISensor
    {
        private Sensor sensorFahrenheit;
        public TemperatureAdapter(Sensor sensor)
        {
            sensorFahrenheit = sensor;
        }
        public double getTemperature()
        {
            return celsiusToFahr(sensorFahrenheit.getTemperature());
        }

        private double celsiusToFahr(double fahr)
        {
            Console.WriteLine("(debug) T°F = {0}", fahr);
            return Math.Round(((fahr - 32) * 5 / 9), 1);
        }
    }
}
