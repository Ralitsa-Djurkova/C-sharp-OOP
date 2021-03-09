
using Raiding.Contracts;
using Raiding.Factories;
using Raiding.IO;

namespace Raiding.Core
{
    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;
        private readonly IBaseHeroFactory baseheroFactory;

        public Engine(IReader reader, IWriter writer, IBaseHeroFactory baseHeroFactory)
        {
            this.reader =new ConsoleReader();
            this.writer = new ConsoleWriter();
            this.baseheroFactory = new BaseHeroFactory();

        }

        public void Run()
        {
            int n = int.Parse(this.reader.CustomReader());

            for (int i = 0; i < n; i+=2)
            {
                string nameHero = this.reader.CustomReader();
                string type = this.reader.CustomReader();

                
                IBaseHero baseHero = this.baseheroFactory.CreateHero(type, nameHero);

                try
                {
                    if(type == "Druid")
                    {
                        
                    }
                }
                catch (System.Exception)
                {

                    throw;
                }
                //try
                //{

                //    if (command == "Drive")
                //    {
                //        this.DriveCommand(car, truck, bus, vehicleType, arg);
                //    }
                //    else if (command == "DriveEmpty")
                //    {
                //        DriveEmptyCommand(bus, arg);
                //    }
                //    else if (command == "Refuel")
                //    {
                //        this.RefuelCommand(car, truck, bus, vehicleType, arg);
                //    }
                //}
                //catch (ArgumentException e)
                //{
                //    this.writer.CustomWriteLine(e.Message);
                //}
            }

            //this.writer.CustomWriteLine(car.ToString());
            //this.writer.CustomWriteLine(truck.ToString());
            //this.writer.CustomWriteLine(bus.ToString());

        }
        }
    }
}
