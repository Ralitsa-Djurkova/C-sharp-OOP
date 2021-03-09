using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Models
{
    public class Truck : Vehicle
    {
        private const double DefoultAirConditionerFouelCompsumtion = 1.6;
        private const double RefuelPercentage = 0.95;
        public Truck(double fuelQuantity, double fuelConsumption,double tankCapacity, bool hasAirConditioner = true) 
            : base(fuelQuantity, fuelConsumption,tankCapacity, hasAirConditioner)
        {
        }

        public override double AirConditionarDuelCompsumptin => DefoultAirConditionerFouelCompsumtion;

        public override void Refuel(double liters)
        {
            base.Refuel(liters * RefuelPercentage);
        }
    }
}
