using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.IO
{
    public interface IWriter
    {
        void CustomWrite(string text);
        void CustomWriteLine(string text);
    }
}
