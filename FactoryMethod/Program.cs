using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod
{
    class Program
    {
        static void Main()
        {
            TransportCompany taxiCompany = new TaxiTransCom("зеленоглазое такси");
            TransportService companyService = taxiCompany.Create("Такси", 2);

            double distance = 13.5;
            printInfo(companyService, distance);

            TransportCompany shippingCompany = new ShipTransCom("доставочка");
            companyService = shippingCompany.Create("Тяжкий груз", 3);

            distance = 135.7;
            printInfo(companyService, distance);

            TransportCompany drunkDriverCompany = new DrunkTransCom("Пьяный водитель");
            companyService = drunkDriverCompany.Create("Стакановец", 25);

            distance = 135.7;
            printInfo(companyService, distance);

            Console.ReadLine();
        }

        private static void printInfo(TransportService transpService, double distance)
        {
            Console.WriteLine("{0}, расстояние: {1}, стоимость: {2}"
                , transpService.ToString(), distance, transpService.CostTransportation(distance));
        }
    }
}
