using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    class drive
    {
        public event EventHandler driveEvent;

        private string twistString;

        public string twist
        {
            get { return twistString; }
            set
            {
                twistString = value;
                if (driveEvent != null) driveEvent(this, new EventArgs());
            }
        }

        public drive()
        {
            twist = "Исходная позиция";
        }

        public void turnLeft()
        {
            twist = "Поворот налево";
        }

        public void turnRight()
        {
            twist = "Поворот направо";
        }

        public void stop()
        {
            twist = "Стоп";
        }

        public string getState()
        {
            return String.Format("Состояние привода: {0}", twist);
        }
    }
}
