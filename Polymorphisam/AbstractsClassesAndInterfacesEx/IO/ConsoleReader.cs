using AbstractsClassesAndInterfacesEx.IO.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractsClassesAndInterfacesEx.IO
{
    public class ConsoleReader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
