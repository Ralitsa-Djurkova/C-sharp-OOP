using AbstractsClassesAndInterfacesEx.Enumarations;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractsClassesAndInterfacesEx.Contracts
{
    public interface IMission
    {
        string CodeName { get; }
        State State { get; }

        void CompleteMession();
    }
}
