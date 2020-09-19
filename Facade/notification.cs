using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    class notification
    {
        public event EventHandler notificationEvent;

        private string messageString;

        public string message
        {
            get { return messageString; }
            set
            {
                messageString = value;

                if (notificationEvent != null) notificationEvent(this, new EventArgs());
            }
        }

        public void startNotification()
        {
            message = "Операция началась";
        }

        public void stopNotification()
        {
            message = "Операция закончилась";
        }

        public string getState()
        {
            return String.Format("Информация: {0}", message);
        }
    }
}
