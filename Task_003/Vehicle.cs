using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_003
{
    internal class Vehicle
    {
        private double price;
        private int speed, year;

        public double Price => price; 
        public int Speed => speed;
        public int Year => year;

        public Vehicle(double price, int speed, int year)
        {
            this.price = price;
            this.speed = speed;
            this.year = year;
        }
    }
}
