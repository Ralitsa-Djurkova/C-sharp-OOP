using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Beverage : Product
    {
        public Beverage(string name, decimal price, double millitires) 
            : base(name, price)
        {
            this.Milliliters = millitires;
        }
        public double Milliliters  { get; set; }

    }
}
