using AbstractsClassesAndInterfacesEx.Core;
using AbstractsClassesAndInterfacesEx.IO;
using AbstractsClassesAndInterfacesEx.IO.Contracts;
using System;

namespace AbstractsClassesAndInterfacesEx
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();
            IEngine engine = new Engine(reader, writer);
            engine.Run();
            

        }
    }
}
