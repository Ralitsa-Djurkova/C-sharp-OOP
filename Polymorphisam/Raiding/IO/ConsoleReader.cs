
using System;

namespace Raiding.IO
{
    public class ConsoleReader : IReader
    {
        public string CustomReader()
        {
            return Console.ReadLine();
        }
    }
}
