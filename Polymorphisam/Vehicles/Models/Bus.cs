
using Vehicles.Contracts;

namespace Vehicles.Models
{
    public class Bus : Vehicle
    {
        private const double DefoultAirConditionerFouelCompsumtion = 1.4;

        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity, bool hasAirConditioner = true) 
            : base(fuelQuantity, fuelConsumption, tankCapacity, hasAirConditioner)
        {
        }

        public override double AirConditionarDuelCompsumptin => DefoultAirConditionerFouelCompsumtion;
    }
}
