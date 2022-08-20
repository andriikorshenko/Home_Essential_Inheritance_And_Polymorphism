using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_003
{
    internal class Ship : Vehicle
    {
        private int passangersQuantity;
        private string localPort;

        public void Show()
            => Console.WriteLine($"Цена лодки, USD : " + base.Price
                + $"\nСкорость лодки, км/ч : " + base.Speed
                + $"\nГод выпуска лодки, год : " + base.Year
                + $"\nВместимость пассажирова, человек : " + this.passangersQuantity
                + $"\nНомер порта : " + this.localPort);

        public Ship(double price, int speed, int year, int passangersQuantity, string localPort)
            : base(price, speed, year) 
        { 
            this.localPort = localPort;
            this.passangersQuantity = passangersQuantity;
        }
    }
}
