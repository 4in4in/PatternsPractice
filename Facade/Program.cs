using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    class Program
    {
        static void Main()
        {
            drive drive = new drive();
            power power = new power();
            notification notification = new notification();

            microvawe microvawe = new microvawe(drive, power, notification);

            power.powerEvent += power_powerEvent;
            drive.driveEvent += drive_driveEvent;
            notification.notificationEvent += notification_notificationEvent;

            Console.WriteLine("Разморозка");
            microvawe.defrost();

            Console.WriteLine();

            Console.WriteLine("Приготовление");
            microvawe.cook();

            Console.ReadLine();
        }

        static void notification_notificationEvent(object sender, EventArgs e)
        {
            Console.WriteLine((sender as notification).getState());
        }

        static void drive_driveEvent(object sender, EventArgs e)
        {
            Console.WriteLine((sender as drive).getState());
        }

        static void power_powerEvent(object sender, EventArgs e)
        {
            Console.WriteLine((sender as power).getState());
        }
    }
}
