using AbstractsClassesAndInterfacesEx.Contracts;
using AbstractsClassesAndInterfacesEx.IO.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractsClassesAndInterfacesEx.IO
{
    public class ConsoleWriter : IWriter
    {
        public void Write(string text)
        {
            Console.Write(text);
        }

        public void WriteLine(string text)
        {
            Console.WriteLine(text);
        }

        public void WriteLine(ISoldier soldier)
        {
            throw new NotImplementedException();
        }
    }
}
