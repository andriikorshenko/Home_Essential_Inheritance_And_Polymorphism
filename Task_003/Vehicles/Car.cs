using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_003
{
    internal class Car : Vehicle
    {
        public void Show()
            => Console.WriteLine($"Цена авто, USD : " + base.Price
                + $"\nСкорость авто, км/ч : " + base.Speed
                + $"\nГод выпуска авто, год : " + base.Year);
        public Car(double price, int speed, int year) 
            : base(price, speed, year) { }
    }
}
