using System;
using System.Collections.Generic;
using System.Text;
using Telephone.Contract;

namespace Telephone.IO
{
    public class ConsoleWriter : IWriter
    {
        public void Write(string text)
        {
            System.Console.Write(text);
        }

        public void WriteLine(string text)
        {
            System.Console.WriteLine(text);
        }
    }
}
