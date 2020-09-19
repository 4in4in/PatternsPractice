using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TransportTickets
{
    abstract class ticket
    {
        public int cost { get; set; }
        public string name { get; set; }

        public ticket(string name, int cost)
        {
            this.cost = cost;
            this.name = name;
        }

        public ticket() { }

        private void ticketInfo()
        {
            Console.WriteLine("Билет: \"{0}\" Цена: {1}", name, cost);
        }

        public void ticketMethod()
        {
            ticketInfo();
            ticketDescription();
        }

        public abstract void ticketDescription();


    }
}
