using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_003
{
    internal class Plane : Vehicle 
    {
        private double maxHeigh;
        private int passangersQuantity;

        public void Show()
            => Console.WriteLine($"Цена самолета, USD : " + base.Price
                + $"\nСкорость самолета, км/ч : " + base.Speed
                + $"\nГод выпуска самолета, год : " + base.Year
                + $"\nМаксимальная высота пассажира, см : " + this.maxHeigh
                + $"\nКоличество пассажирова, человек : " + this.passangersQuantity);

        public Plane(double price, int speed, int year, double maxHeigh, int passangersQuantity)
            : base(price, speed, year) 
        {
            this.maxHeigh = maxHeigh;
            this.passangersQuantity = passangersQuantity;
        }
    }
}
