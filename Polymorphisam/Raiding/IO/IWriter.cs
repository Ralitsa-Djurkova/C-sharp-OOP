using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.IO
{
    public interface IWriter
    {
        void CustomWrite(string text);
        void CustumWriteLine(string text);
        
    }
}
