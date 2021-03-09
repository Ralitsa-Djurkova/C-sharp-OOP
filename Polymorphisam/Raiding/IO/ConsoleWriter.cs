
using System;

namespace Raiding.IO
{
    public class ConsoleWriter : IWriter
    {
        public void CustomWrite(string text)
        {
            Console.Write(text);
        }

      
        public void CustumWriteLine(string text)
        {
            Console.WriteLine(text);
        }
    }
}
