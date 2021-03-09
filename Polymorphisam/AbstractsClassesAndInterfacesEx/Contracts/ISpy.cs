using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractsClassesAndInterfacesEx.Contracts
{
    public interface ISpy : ISoldier
    {
        int CodeNumber { get; }
    }
}
