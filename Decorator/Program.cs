using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    class Program
    {
        static void Main()
        {
            renault renault = new renault("Рено", "Renault Megan", 499);
            Console.WriteLine(renault.getInfo());

            autoBase myRenault = new mediaNAV(renault, "Навигация");
            Console.WriteLine(myRenault.getInfo());

            autoBase myRenault1 = new securitySystem(myRenault, "Безопасность");
            Console.WriteLine(myRenault1.getInfo());

            citroen citroen = new citroen("Ситроен", "Citroen DS", 666);
            Console.WriteLine(citroen.getInfo());

            autoBase myCitroen = new securitySystem(citroen, "Защищенный");
            Console.WriteLine(myCitroen.getInfo());

            autoBase myCitroen1 = new conditioningSystem(myCitroen, "Кондиционируемый");
            Console.WriteLine(myCitroen1.getInfo());

            autoBase myCitroen2 = new windowLiftSystem(myCitroen1, "Кондиционируемый");
            Console.WriteLine(myCitroen2.getInfo());

            Console.ReadLine();
        }
    }
}
