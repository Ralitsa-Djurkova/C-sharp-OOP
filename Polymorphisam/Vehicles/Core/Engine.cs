

using System;
using Vehicles.Contracts;
using Vehicles.Factories;
using Vehicles.IO;
using Vehicles.Models;

namespace Vehicles.Core
{
    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;
        private readonly IVihicleFactory vehicleFactory;

        public Engine(IReader reader, IWriter writer, IVihicleFactory vihicleFactory)
        {
            this.reader = new ConsolReader();
            this.writer = new ConsoleWriter();
            this.vehicleFactory = new VehicleFactory();
        }
        public void Run()
        {
            string[] carData = this.reader.CustomReadLine().Split();
            IVehicles car = CreateVehicle(carData);

            string[] truckData = this.reader.CustomReadLine().Split();
            IVehicles truck = CreateVehicle(truckData);

            string[] busData = this.reader.CustomReadLine().Split();
            IVehicles bus = CreateVehicle(busData);

            int n = int.Parse(this.reader.CustomReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] args = this.reader.CustomReadLine().Split();
                string command = args[0];
                string vehicleType = args[1];
                double arg = double.Parse(args[2]);

                try
                {

                    if (command == "Drive")
                    {
                        this.DriveCommand(car, truck, bus, vehicleType, arg);
                    }
                    else if (command == "DriveEmpty")
                    {
                        DriveEmptyCommand(bus, arg);
                    }
                    else if (command == "Refuel")
                    {
                        this.RefuelCommand(car, truck, bus, vehicleType, arg);
                    }
                }
                catch (ArgumentException e)
                {
                    this.writer.CustomWriteLine(e.Message);
                }
            }

            this.writer.CustomWriteLine(car.ToString());
            this.writer.CustomWriteLine(truck.ToString());
            this.writer.CustomWriteLine(bus.ToString());
        }

        private void DriveEmptyCommand(IVehicles bus, double arg)
        {
            bus.StopAirConditioner();
            bool isDrive = bus.Drive(arg);
            
            if (isDrive)
            {
                this.writer.CustomWriteLine($"Bus travelled {arg} km");
            }
            else
            {
                this.writer.CustomWriteLine($"Bus needs refueling");
            }
        }

        private  void RefuelCommand(IVehicles car, IVehicles truck,IVehicles bus, string vehicleType, double arg)
        {
            if (vehicleType == nameof(Car))
            {
                car.Refuel(arg);
            }
            else if (vehicleType == nameof(Truck))
            {
                truck.Refuel(arg);
            }
            else if (vehicleType == nameof(Bus))
            {
                bus.Refuel(arg);
            }
        }

        private void DriveCommand(IVehicles car, IVehicles truck,IVehicles bus, string vehicleType, double arg)
        {
            bool isDrive = false;
            if (vehicleType == nameof(Car))
            {
                isDrive = car.Drive(arg);
            }
            else if (vehicleType == nameof(Truck))
            {
                isDrive = truck.Drive(arg);
            }
            else if (vehicleType == nameof(Bus))
            {
                bus.StartAirConditioner();
                isDrive = bus.Drive(arg);
            }
            if (isDrive)
            {
                this.writer.CustomWriteLine($"{vehicleType} travelled {arg} km");
            }
            else
            {
                this.writer.CustomWriteLine($"{vehicleType} needs refueling");
            }
        }

        private IVehicles CreateVehicle(string[] date)
        {
            string type = date[0];
            double fuelQuantity = double.Parse(date[1]);
            double fuelCompsuntion = double.Parse(date[2]);
            double tankCapacity = double.Parse(date[3]);

            IVehicles vehicle = this.vehicleFactory.CreateVehile(type, fuelQuantity, fuelCompsuntion, tankCapacity);

            return vehicle;
        }
    }
}
