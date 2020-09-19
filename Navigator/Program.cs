using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Navigator
{
    class Program
    {
        static void Main()
        {
            strategyNavigation myNavigation = new publicTransportNavigation();
            map map = new map(myNavigation);
            Console.WriteLine(myNavigation.title);
            map.navigate();

            myNavigation = new roadNavigation();
            map = new map(myNavigation);
            Console.WriteLine(myNavigation.title);
            map.navigate();

            myNavigation = new walkNavigation();
            map = new map(myNavigation);
            Console.WriteLine(myNavigation.title);
            map.navigate();

            myNavigation = new attractionsNavigation();
            map = new map(myNavigation);
            Console.WriteLine(myNavigation.title);
            map.navigate();

            Console.ReadLine();
        }
    }
}
