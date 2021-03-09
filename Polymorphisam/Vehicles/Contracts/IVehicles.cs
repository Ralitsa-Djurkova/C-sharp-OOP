using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Contracts
{
    public interface IVehicles
    {
        
        public double FuelQuantity { get; }
        public double FuelConsumption { get; }
        public double TankCapacity { get; }
        bool HasAirConditionar { get; }
        double AirConditionarDuelCompsumptin { get; }
        public bool Drive(double distance);
        public void Refuel(double liters);

        void StartAirConditioner();

        void StopAirConditioner();
    }
}
