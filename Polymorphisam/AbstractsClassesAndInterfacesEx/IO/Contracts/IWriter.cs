using AbstractsClassesAndInterfacesEx.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractsClassesAndInterfacesEx.IO.Contracts
{
    public interface IWriter
    {
        void Write(string text);
       
        void WriteLine(string text);
        void WriteLine(ISoldier soldier);
    }
}
