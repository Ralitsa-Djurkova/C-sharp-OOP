using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractsClassesAndInterfacesEx.Exeptions
{
    public class InvalidMiisionaCompletionExeption : Exception
    {
        private const string DEF_EXC_MSG = "Mission already completed";
        public InvalidMiisionaCompletionExeption()
        {

        }

        public InvalidMiisionaCompletionExeption(string message) : base(message)
        {
        }
    }
}
