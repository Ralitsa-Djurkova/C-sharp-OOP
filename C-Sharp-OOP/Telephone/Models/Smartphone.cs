
using System.Linq;
using Telephone.Contract;
using Telephone.Exeptions;

namespace Telephone.Models
{
    public class Smartphone : ICallable, IBrowsebla
    {
        public string Call(string number)
        {
            if (!number.All(ch => char.IsDigit(ch)))
            {
                throw new InvalidNumberExpetion();
            }
            return $"Calling... {number}";
        }
        public string Brows(string url)
        {
            if(url.Any(ch => char.IsDigit(ch)))
            {
                throw new InvalidUrlexeption();
            }

            return $"Browsing: {url}!";
            
        }
    }
}
