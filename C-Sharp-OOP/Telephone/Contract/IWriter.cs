using System;
using System.Collections.Generic;
using System.Text;

namespace Telephone.Contract
{
    public interface IWriter
    {
        void Write(string text);

        void WriteLine(string text);
    }
}
