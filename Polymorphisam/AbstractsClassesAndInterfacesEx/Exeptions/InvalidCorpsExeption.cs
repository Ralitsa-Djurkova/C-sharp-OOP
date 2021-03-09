using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractsClassesAndInterfacesEx.Exeptions
{
    public class InvalidCorpsExeption : Exception
    {
        private const string DEF_EXC_MSG = "Invalid corps!";
        public InvalidCorpsExeption() :base(DEF_EXC_MSG)
        {

        }

       
        public InvalidCorpsExeption(string message) : base(message)
        {

        }
    }
}
