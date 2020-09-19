using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    class Program
    {
        static void Main()
        {
            CarFactory myCarFactory = AudiFactory.instance;
            Client client1 = new Client(myCarFactory);

            Console.WriteLine("Макс. скорость {0} {2}: {1} км/ч"
                , client1.getCarName(), client1.runMaxSpeed(), client1.getCarBody());

            Console.ReadLine();
        }
    }
}
