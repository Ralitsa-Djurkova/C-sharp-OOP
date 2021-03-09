using System;
using System.Collections.Generic;
using System.Text;
using Vehicles.Contracts;
using Vehicles.Models;

namespace Vehicles.Factories
{
    public class VehicleFactory : IVihicleFactory
    {
        public IVehicles CreateVehile(string type, double fuelQuantity, double fuelConsumption, double tankCapacity, bool hasAirConditioner)
        {
            IVehicles vehicle = null;

            if (type == nameof(Car))
            {
                vehicle = new Car(fuelQuantity, fuelConsumption, tankCapacity, hasAirConditioner);
            }
            else if (type == nameof(Truck))
            {
                vehicle = new Truck(fuelQuantity, fuelConsumption, tankCapacity, hasAirConditioner);
            }
            else if (type == nameof(Bus))
            {
                vehicle = new Bus(fuelQuantity, fuelConsumption, tankCapacity, hasAirConditioner);
            }
            return vehicle;
        }
    }
}
