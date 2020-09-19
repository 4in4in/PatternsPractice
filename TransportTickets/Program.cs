using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TransportTickets
{
    class Program
    {
        static void Main()
        {
            ticket ticket = new monthTicket();
            ticket.ticketMethod();

            ticket = new weekTicket();
            ticket.ticketMethod();

            Console.ReadLine();
        }
    }
}
