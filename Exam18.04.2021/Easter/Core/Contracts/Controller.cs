

using Easter.Models.Bunnies.Contracts;
using Easter.Models.Dyes.Contracts;
using Easter.Models.Eggs.Contracts;
using Easter.Models.Workshops.Contracts;
using Easter.Repositories.Contracts;
using Easter.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Easter.Core.Contracts
{
    public class Controller : IController
    {
        private readonly BunnyRepository bunnies;
        private readonly EggRepository eggs;
        private readonly Workshop workshop;


        public Controller()
        {
            bunnies = new BunnyRepository();
            eggs = new EggRepository();
            workshop = new Workshop();

        }
        public string AddBunny(string bunnyType, string bunnyName)
        {
            if (bunnyType == "HappyBunny")
            {
                var bunny = new HappyBunny(bunnyName);
                bunnies.Add(bunny);
            }
            else if (bunnyType == "SleepyBunny")
            {
                var bunny = new SleepyBunny(bunnyName);
                bunnies.Add(bunny);
            }
            else
            {
                throw new InvalidOperationException("Invalid bunny type.");
            }

            return $"Successfully added {bunnyType} named {bunnyName}.";
        }

        public string AddDyeToBunny(string bunnyName, int power)
        {
            var bunny = bunnies.FindByName(bunnyName);
            var dye = new Dye(power);
            if (bunnyName == null)
            {
                throw new InvalidOperationException("The bunny you want to add a dye to doesn't exist!");
            }
            bunny.AddDye(dye);
            return $"Successfully added dye with power {power} to bunny {bunnyName}!";
        }

        public string AddEgg(string eggName, int energyRequired)
        {
            var egg = new Egg(energyRequired, eggName);
            eggs.Add(egg);
            return $"Successfully added egg: {eggName}!";
        }

        public string ColorEgg(string eggName)
        {
            var egg = eggs.Models.FirstOrDefault(x => x.Name == eggName);
            var energyBunnies = bunnies.Models.Where(x => x.Energy >= 50).OrderByDescending(x => x.Energy).ToList();
            if (energyBunnies.Count == 0)
            {
                throw new InvalidOperationException(ExceptionMessages.BunniesNotReady);
            }
            IBunny energyBunny = null;

            while (energyBunnies.Count > 0 && energyBunnies.Any(x => x.Dyes.Any(x => x.IsFinished() == false)))
            {
                energyBunny = energyBunnies.First(x => x.Dyes.Any(x => x.IsFinished() == false));
                workshop.Color(egg, energyBunny);
                if (energyBunny.Energy == 0)
                {
                    bunnies.Remove(energyBunny);
                }
                if (egg.IsDone() == true)
                {
                    break;
                }
                if (energyBunny.Dyes.All(x => x.IsFinished() == true))
                {
                    break;
                }
            }

            if (egg.IsDone() == true)
            {
                return $"Egg {eggName} is done.";
            }
            else
            {
                return $"Egg {eggName} is not done.";
            }
        }


        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            List<IEgg> colleredEgg = eggs.Models.Where(x => x.IsDone() == true).ToList();
            sb.AppendLine($"{colleredEgg.Count} eggs are done!");
            sb.AppendLine("Bunnies info:");
            foreach (var item in bunnies.Models)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString().TrimEnd();

        }
    }
}
