using Raiding.Core;
using Raiding.Factories;
using Raiding.IO;
using System;

namespace Raiding
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();
            IBaseHeroFactory baseHero = new BaseHeroFactory();

            IEngine engine = new Engine(reader, writer, baseHero);
            engine.Run();
        }
    }
}
