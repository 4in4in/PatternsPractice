using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace chainOfResponsibility
{
    class bankPaymentHandler : paymentHandler
    {
        public override void handle(reciever reciever)
        {
            if (reciever.bankTransfer == true) Console.WriteLine("Выполняется банковский перевод");
            else if (successor != null) successor.handle(reciever);
        }
    }

    class moneyPaymentHandler : paymentHandler
    {
        public override void handle(reciever reciever)
        {
            if (reciever.moneyTransfer == true) Console.WriteLine("Выполняется денежный перевод");
            else if (successor != null) successor.handle(reciever);
        }
    }

    class payPalPaymentHandler : paymentHandler
    {
        public override void handle(reciever reciever)
        {
            if (reciever.payPalTransfer == true) Console.WriteLine("Выполняется перевод по системе PayPal");
            else if (successor != null) successor.handle(reciever);
        }
    }
}
