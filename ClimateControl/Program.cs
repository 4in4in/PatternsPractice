using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClimateControl
{
    class Program
    {
        static void Main()
        {
            Sensor sensor=new Sensor();

            Control control = new Control();

            TemperatureAdapter adapter = new TemperatureAdapter(sensor);

            Console.WriteLine("Температура (°C): {0}", control.controlSession(adapter));
            Console.ReadLine();
        }
    }
}
