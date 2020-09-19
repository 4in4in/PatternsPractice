using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    class microvawe
    {
        private drive drive;
        private power power;
        private notification notification;

        public microvawe(drive drive, power power, notification notification)
        {
            this.drive = drive;
            this.power = power;
            this.notification = notification;
        }

        public void defrost()
        {
            notification.startNotification();
            power.microwavePower = 1000;
            drive.turnRight();
            drive.turnRight();
            power.microwavePower = 500;
            drive.stop();
            drive.turnLeft();
            drive.turnLeft();
            power.microwavePower = 200;
            drive.stop();
            drive.turnRight();
            drive.turnRight();
            drive.stop();
            power.microwavePower = 0;
            notification.stopNotification();
        }

        public void cook()
        {
            notification.startNotification();
            power.microwavePower = 1000;
            drive.turnRight();
            power.microwavePower = 500;
            drive.stop();
            drive.turnLeft();
            power.microwavePower = 200;
            drive.stop();
            drive.turnRight();
            power.microwavePower = 1000;
            drive.turnRight();
            drive.stop();
            power.microwavePower = 0;
            notification.stopNotification();
        }
    }
}
