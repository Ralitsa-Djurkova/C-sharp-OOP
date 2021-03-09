using System;
using Vehicles.Core;
using Vehicles.Factories;
using Vehicles.IO;

namespace Vehicles
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            IReader reader = new ConsolReader();
            IWriter writer = new ConsoleWriter();
            IVihicleFactory vehicleFactory = new VehicleFactory();

            IEngine engine = new Engine(reader, writer, vehicleFactory);
            engine.Run();
        }
    }
}
