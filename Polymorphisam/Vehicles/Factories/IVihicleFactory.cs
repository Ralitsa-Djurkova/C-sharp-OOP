using System;
using System.Collections.Generic;
using System.Text;
using Vehicles.Contracts;
using Vehicles.Models;

namespace Vehicles.Factories
{
    public interface IVihicleFactory
    {
        IVehicles CreateVehile(string type, double fuelQuantity, double fuelConsumption,double tankCapacity, bool hasAirConditioner = true);
    }
}
