
using System.Linq;
using Telephone.Contract;
using Telephone.Exeptions;

namespace Telephone.Models
{
    public class StationaryPhone : ICallable
    {
        public StationaryPhone()
        {

        }
        public string Call(string number)
        {
            if(!number.All(ch => char.IsDigit(ch)))
            {
                throw new InvalidNumberExpetion();
            }
            return $"Dialing... {number}";
        }
    }
}
