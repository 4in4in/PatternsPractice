using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TransportTickets
{
    class weekTicket : ticket
    {
        public weekTicket()
        {
            name = "На неделю";
            cost = 450;
        }

        public override void ticketDescription()
        {
            Console.WriteLine("Билет позволяет в течение недели пользоваться всеми типами муниципального общественного транспорта без ограничений\r\n");
        }
    }
}
