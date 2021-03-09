using System;
using System.Collections.Generic;
using System.Text;
using Vehicles.Contracts;
using Vehicles.Untilites;

namespace Vehicles.Models
{
    public abstract class Vehicle : IVehicles
    {
        private const double DefoultQuantityt = 0;
        private double fuelQuantity;
        protected Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity, bool hasAirConditioner = true)
        {
            this.TankCapacity = tankCapacity;
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            this.HasAirConditionar = hasAirConditioner;
            
        }

        public double FuelQuantity
        {
            get => this.fuelQuantity;

            protected set
            {
                if(value > this.TankCapacity)
                {
                    this.fuelQuantity = DefoultQuantityt;
                }
                else
                {
                    this.fuelQuantity = value;
                }
            }
        }

        public double FuelConsumption { get; private set; }
        public double TankCapacity { get; private set; }

        public bool HasAirConditionar { get; private set; }

        public abstract double AirConditionarDuelCompsumptin { get; }


        public bool Drive(double distance)
        {
            double spentFuel = distance * this.FuelConsumption;

            if (this.HasAirConditionar)
            {
                spentFuel += AirConditionarDuelCompsumptin * distance;
            }
            if(this.FuelQuantity < spentFuel)
            {
                return false;
            }

            this.FuelQuantity -= spentFuel;
            return true;

        }

        public virtual void Refuel(double liters)
        {
            if (liters <= 0)
            {
                throw new ArgumentException(ExeptionMessages.NegativeFuelAmount);
            }
           
            if (this.FuelQuantity + liters > this.TankCapacity)
            {
                
                string msg = string.Format(ExeptionMessages.InvalidFuelAmount, liters);
                throw new ArgumentException(msg);
            }
            this.FuelQuantity += liters;
        }
        public void StartAirConditioner()
        {
            this.HasAirConditionar = true;
        }
        public void StopAirConditioner()
        {
            this.HasAirConditionar = false;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}
