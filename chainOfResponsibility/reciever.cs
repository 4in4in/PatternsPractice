using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace chainOfResponsibility
{
    class reciever
    {
        public bool bankTransfer { get; set; }
        public bool moneyTransfer { get; set; }
        public bool payPalTransfer { get; set; }

        public reciever(bool bankTransfer, bool moneyTransfer, bool payPalTransfer)
        {
            this.bankTransfer = bankTransfer;
            this.moneyTransfer = moneyTransfer;
            this.payPalTransfer = payPalTransfer;
        }
    }
}
