using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace chainOfResponsibility
{
    abstract class paymentHandler
    {
        public paymentHandler successor { get; set; }
        public abstract void handle(reciever reciever);
    }
}
