using System;
using System.Collections.Generic;
using System.Text;

namespace Telephone.Exeptions
{
    public class InvalidUrlexeption : Exception
    {
        private const string EXC_MSG = "Invalid URL!";
        public InvalidUrlexeption() : base(EXC_MSG)
        {

        }

        public InvalidUrlexeption(string message) 
            : base(message)
        {
        }
    }
}
