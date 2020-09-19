using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TransportTickets
{
    class monthTicket : ticket
    {
        public monthTicket()
        {
            name = "Месячный";
            cost = 1500;
        }

        public override void ticketDescription()
        {
            Console.WriteLine("Билет позволяет в течение месяца пользоваться всеми типами муниципального общественного транспорта без ограничений\r\n");
        }
    }
}
