using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    abstract class autoBase
    {
        public string name { get; set; }

        public string description { get; set; }

        public double costBase { get; set; }

        public abstract double getCost();

        public string getInfo()
        {
            return String.Format("Ваш автомобиль: {0}\r\nОписание: {1}\r\nСтоимость: {2}\r\n", name, description, getCost());
        }
    }
}
