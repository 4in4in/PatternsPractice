using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace chainOfResponsibility
{
    class Program
    {
        static void Main()
        {
            reciever reciever = new reciever(false, true, false);

            paymentHandler bankPaymentHandler = new bankPaymentHandler();
            paymentHandler moneyPaymentHandler = new moneyPaymentHandler();
            paymentHandler payPalPaymentHandler = new payPalPaymentHandler();

            bankPaymentHandler.successor = moneyPaymentHandler;
            payPalPaymentHandler.successor = moneyPaymentHandler;

            bankPaymentHandler.handle(reciever);

            Console.ReadLine();
        }
    }
}
