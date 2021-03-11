using System;
using System.Collections.Generic;
using System.Text;

namespace Telephone.Exeptions
{
    public class InvalidNumberExpetion : Exception 
    {
        private const string EXC_MSG = "Invalid number!";

        public InvalidNumberExpetion() : base(EXC_MSG)
        {

        }

        public InvalidNumberExpetion(string message) 
            : base(message)
        {
        }
    }
}
